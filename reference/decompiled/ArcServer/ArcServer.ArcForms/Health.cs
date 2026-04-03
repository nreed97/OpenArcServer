using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcInterfaces.Ui;
using ArcServer.Properties;
using WeifenLuo.WinFormsUI.Docking;

namespace ArcServer.ArcForms;

public class Health : DockContent
{
	private ArCluster _arc;

	private IContainer components;

	private Timer timer1;

	private Label lblUptime;

	private PictureBox pictureBoxNodes;

	private PictureBox pictureBoxUsers;

	private PictureBox pictureBoxSpotRate;

	private Label lblNodes;

	private Label lblUsers;

	private Label lblSpotRate;

	public Health()
	{
		InitializeComponent();
		_arc = ArCluster.Instance;
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		_ = DateTime.UtcNow;
		StatusBarData statusBarData = _arc.GetStatusBarData();
		lblUptime.Text = "Uptime: " + statusBarData.Uptime.ToString("dd\\.hh\\:mm");
		lblNodes.Text = "Nodes: " + statusBarData.NodeCnt;
		pictureBoxNodes.Image = GetStatusBitMap(statusBarData.AlertNodeCnt);
		lblUsers.Text = "Users: " + statusBarData.UserCnt;
		pictureBoxUsers.Image = GetStatusBitMap(statusBarData.AlertUserCnt);
		lblSpotRate.Text = "DX Spots: " + statusBarData.DxRate;
		pictureBoxSpotRate.Image = GetStatusBitMap(statusBarData.AlertDxRate);
		SetHealthWndIcon(statusBarData.AlertNodeCnt || statusBarData.AlertUserCnt || statusBarData.AlertDxRate);
	}

	private Bitmap GetStatusBitMap(bool isBad)
	{
		if (isBad)
		{
			return Resources.Health2;
		}
		return Resources.Check2;
	}

	private void SetHealthWndIcon(bool isBad)
	{
		if (isBad)
		{
			base.Icon = Resources.HealthBad;
		}
		else
		{
			base.Icon = Resources.HealthOk;
		}
		base.DockPanel.Refresh();
	}

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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcServer.ArcForms.Health));
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.lblUptime = new System.Windows.Forms.Label();
		this.pictureBoxNodes = new System.Windows.Forms.PictureBox();
		this.pictureBoxUsers = new System.Windows.Forms.PictureBox();
		this.pictureBoxSpotRate = new System.Windows.Forms.PictureBox();
		this.lblNodes = new System.Windows.Forms.Label();
		this.lblUsers = new System.Windows.Forms.Label();
		this.lblSpotRate = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxNodes).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxUsers).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxSpotRate).BeginInit();
		base.SuspendLayout();
		this.timer1.Enabled = true;
		this.timer1.Interval = 1000;
		this.timer1.Tick += new System.EventHandler(timer1_Tick);
		this.lblUptime.AutoSize = true;
		this.lblUptime.Location = new System.Drawing.Point(12, 14);
		this.lblUptime.Name = "lblUptime";
		this.lblUptime.Size = new System.Drawing.Size(44, 13);
		this.lblUptime.TabIndex = 3;
		this.lblUptime.Text = "UpTime";
		this.pictureBoxNodes.Image = (System.Drawing.Image)resources.GetObject("pictureBoxNodes.Image");
		this.pictureBoxNodes.Location = new System.Drawing.Point(12, 46);
		this.pictureBoxNodes.Name = "pictureBoxNodes";
		this.pictureBoxNodes.Size = new System.Drawing.Size(16, 16);
		this.pictureBoxNodes.TabIndex = 6;
		this.pictureBoxNodes.TabStop = false;
		this.pictureBoxUsers.Image = (System.Drawing.Image)resources.GetObject("pictureBoxUsers.Image");
		this.pictureBoxUsers.Location = new System.Drawing.Point(12, 81);
		this.pictureBoxUsers.Name = "pictureBoxUsers";
		this.pictureBoxUsers.Size = new System.Drawing.Size(16, 16);
		this.pictureBoxUsers.TabIndex = 7;
		this.pictureBoxUsers.TabStop = false;
		this.pictureBoxSpotRate.Image = (System.Drawing.Image)resources.GetObject("pictureBoxSpotRate.Image");
		this.pictureBoxSpotRate.Location = new System.Drawing.Point(12, 116);
		this.pictureBoxSpotRate.Name = "pictureBoxSpotRate";
		this.pictureBoxSpotRate.Size = new System.Drawing.Size(16, 16);
		this.pictureBoxSpotRate.TabIndex = 8;
		this.pictureBoxSpotRate.TabStop = false;
		this.lblNodes.AutoSize = true;
		this.lblNodes.Location = new System.Drawing.Point(39, 49);
		this.lblNodes.Name = "lblNodes";
		this.lblNodes.Size = new System.Drawing.Size(38, 13);
		this.lblNodes.TabIndex = 9;
		this.lblNodes.Text = "Nodes";
		this.lblUsers.AutoSize = true;
		this.lblUsers.Location = new System.Drawing.Point(39, 84);
		this.lblUsers.Name = "lblUsers";
		this.lblUsers.Size = new System.Drawing.Size(34, 13);
		this.lblUsers.TabIndex = 10;
		this.lblUsers.Text = "Users";
		this.lblSpotRate.AutoSize = true;
		this.lblSpotRate.Location = new System.Drawing.Point(39, 118);
		this.lblSpotRate.Name = "lblSpotRate";
		this.lblSpotRate.Size = new System.Drawing.Size(52, 13);
		this.lblSpotRate.TabIndex = 11;
		this.lblSpotRate.Text = "SpotRate";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(114, 166);
		base.Controls.Add(this.lblSpotRate);
		base.Controls.Add(this.lblUsers);
		base.Controls.Add(this.lblNodes);
		base.Controls.Add(this.pictureBoxSpotRate);
		base.Controls.Add(this.pictureBoxUsers);
		base.Controls.Add(this.pictureBoxNodes);
		base.Controls.Add(this.lblUptime);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Health";
		this.Text = "Health";
		((System.ComponentModel.ISupportInitialize)this.pictureBoxNodes).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxUsers).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxSpotRate).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
