using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ArcEngine.ArcCaches;
using ArcEngine.Callbook;
using ArcShared.ArcUtils;
using log4net;

namespace ArcServer.ArcForms;

internal class FrmUpdateUsVeCallbookOld : Form
{
	private IContainer components;

	private Button btnExit;

	private TextBox txtStatus;

	private Label lblLastUpdate;

	private Button btnUpdate;

	private System.Windows.Forms.Timer timer1;

	private ProgressBar progressBar1;

	private static readonly ILog _log = LogManager.GetLogger("FrmUpdateUsVeCallbookOld");

	private readonly Queue _queue = new Queue();

	private Thread _processingThread;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcServer.ArcForms.FrmUpdateUsVeCallbookOld));
		this.btnExit = new System.Windows.Forms.Button();
		this.txtStatus = new System.Windows.Forms.TextBox();
		this.lblLastUpdate = new System.Windows.Forms.Label();
		this.btnUpdate = new System.Windows.Forms.Button();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.progressBar1 = new System.Windows.Forms.ProgressBar();
		base.SuspendLayout();
		this.btnExit.Location = new System.Drawing.Point(334, 191);
		this.btnExit.Name = "btnExit";
		this.btnExit.Size = new System.Drawing.Size(80, 23);
		this.btnExit.TabIndex = 11;
		this.btnExit.Text = "Exit";
		this.btnExit.UseVisualStyleBackColor = true;
		this.btnExit.Click += new System.EventHandler(btnExit_Click);
		this.txtStatus.Location = new System.Drawing.Point(12, 36);
		this.txtStatus.Multiline = true;
		this.txtStatus.Name = "txtStatus";
		this.txtStatus.ReadOnly = true;
		this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtStatus.Size = new System.Drawing.Size(613, 111);
		this.txtStatus.TabIndex = 10;
		this.lblLastUpdate.AutoSize = true;
		this.lblLastUpdate.Location = new System.Drawing.Point(10, 9);
		this.lblLastUpdate.Name = "lblLastUpdate";
		this.lblLastUpdate.Size = new System.Drawing.Size(71, 13);
		this.lblLastUpdate.TabIndex = 9;
		this.lblLastUpdate.Text = "Last Update: ";
		this.btnUpdate.Location = new System.Drawing.Point(224, 191);
		this.btnUpdate.Name = "btnUpdate";
		this.btnUpdate.Size = new System.Drawing.Size(80, 23);
		this.btnUpdate.TabIndex = 8;
		this.btnUpdate.Text = "Update";
		this.btnUpdate.UseVisualStyleBackColor = true;
		this.btnUpdate.Click += new System.EventHandler(btnUpdate_Click);
		this.timer1.Enabled = true;
		this.timer1.Interval = 250;
		this.timer1.Tick += new System.EventHandler(timer1_Tick);
		this.progressBar1.Location = new System.Drawing.Point(13, 153);
		this.progressBar1.Name = "progressBar1";
		this.progressBar1.Size = new System.Drawing.Size(612, 23);
		this.progressBar1.TabIndex = 12;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(637, 224);
		base.Controls.Add(this.progressBar1);
		base.Controls.Add(this.btnExit);
		base.Controls.Add(this.txtStatus);
		base.Controls.Add(this.lblLastUpdate);
		base.Controls.Add(this.btnUpdate);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FrmUpdateUsVeCallbook";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Update US/VE Callbook";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(UpdateUsVeCallbook_FormClosing);
		base.Load += new System.EventHandler(UpdateUsVeCallbook_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	internal FrmUpdateUsVeCallbookOld()
	{
		InitializeComponent();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (_queue.Count > 0)
		{
			TextBox textBox = txtStatus;
			textBox.Text = textBox.Text + (string)_queue.Dequeue() + "\r\n";
		}
		if (_processingThread != null && _processingThread.IsAlive)
		{
			if (progressBar1.Value >= 100)
			{
				progressBar1.Value = 0;
			}
			progressBar1.Value++;
		}
		if (!btnUpdate.Enabled && (_processingThread == null || !_processingThread.IsAlive))
		{
			progressBar1.Value = 100;
		}
	}

	private void btnUpdate_Click(object sender, EventArgs e)
	{
	}

	private void ProcessCallbooks(string fccUrl, string veUrl, int fccTimeout, int veTimeout)
	{
		try
		{
			DateTime now = DateTime.Now;
			string text = Application.StartupPath + "\\Cfg\\Downloads\\UsVeCallbook\\";
			new List<string>(Directory.GetFiles(text)).ForEach(File.Delete);
			_queue.Enqueue("Downloading FCC file l_amat.zip");
			string filePath = text + "l_amat.zip";
			DownloadUrl.DownloadToFile(fccUrl, filePath, string.Empty);
			_queue.Enqueue("UnZipping FCC file to \\Downloads\\UsVeCallbook ");
			UnZipFiles.UnZip(text + "l_amat.zip", text);
			CallBookExtCache callBookExtCache = new CallBookExtCache();
			_queue.Enqueue("Processing FCC files to callbook database ");
			UsCallbook usCallbook = new UsCallbook(callBookExtCache, "\\Cfg\\Downloads\\UsVeCallbook\\");
			usCallbook.BuildIndexes();
			usCallbook.WriteIndexFiles();
			_queue.Enqueue("Downloading VE file amateur.zip");
			string filePath2 = text + "amateur.zip";
			DownloadUrl.DownloadToFile(veUrl, filePath2, string.Empty);
			_queue.Enqueue("UnZipping VE file to \\Cfg\\Downloads\\UsVeCallbook");
			UnZipFiles.UnZip(text + "amateur.zip", text);
			_queue.Enqueue("Processing VE files to callbook database");
			VeCallbook veCallbook = new VeCallbook("\\Cfg\\Downloads\\UsVeCallbook\\");
			veCallbook.BuildIndex();
			veCallbook.WriteIndexFile();
			CleanUp();
			TimeSpan timeSpan = DateTime.Now - now;
			_queue.Enqueue("FCC/VE callbook downloaded and processed in " + timeSpan.Minutes + " minutes");
			_queue.Enqueue("Please shutdown ARC and copy files from folder \\Cfg\\Downloads\\UsVeCallbook to \\Cfg\\UsVeCallbook");
		}
		catch (Exception ex)
		{
			_queue.Enqueue("Exception downloading or processing FCC VE files");
			_queue.Enqueue(ex.Message);
			_queue.Enqueue(ex.Source);
			_queue.Enqueue(ex.StackTrace);
		}
	}

	private static void CleanUp()
	{
		string text = Application.StartupPath + "\\Cfg\\Downloads\\UsVeCallbook\\";
		DeleteFile(text + "CO.dat");
		DeleteFile(text + "counts");
		DeleteFile(text + "HS.dat");
		DeleteFile(text + "l_amat.zip");
		DeleteFile(text + "LA.dat");
		DeleteFile(text + "SC.dat");
		DeleteFile(text + "SF.dat");
		DeleteFile(text + "amateur.zip");
		DeleteFile(text + "lisezmoi.txt");
		DeleteFile(text + "readme.txt");
	}

	private static void DeleteFile(string filePath)
	{
		try
		{
			if (File.Exists(filePath))
			{
				File.Delete(filePath);
			}
		}
		catch (Exception ex)
		{
			_log.Error("Error deleting " + filePath + " - " + ex.Message);
		}
	}

	private void UpdateUsVeCallbook_Load(object sender, EventArgs e)
	{
		GetFccUpdateDts();
	}

	private void GetFccUpdateDts()
	{
		lblLastUpdate.Text = string.Empty;
		string fileName = Application.StartupPath + "\\Cfg\\UsVeCallbook\\AM.dat";
		FileInfo fileInfo = new FileInfo(fileName);
		if (fileInfo.Exists)
		{
			DateTime lastWriteTime = fileInfo.LastWriteTime;
			lblLastUpdate.Text = "Last FCC/VE (AM.dat)update:  " + lastWriteTime.ToString("MM/dd/yyyy HHmmZ");
		}
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void UpdateUsVeCallbook_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (_processingThread != null && _processingThread.IsAlive)
		{
			_processingThread.Abort();
			Thread.Sleep(100);
		}
	}
}
