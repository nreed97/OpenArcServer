using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine.ArcServerConfig;

namespace ArcServer.ArcForms;

internal class ArcServerSetup : Form
{
	private IContainer components;

	private PropertyGrid propertyGrid1;

	private Button btnExit;

	private TextBox textBox1;

	public ArcServerCfg ArcServerCfg;

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
		this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
		this.btnExit = new System.Windows.Forms.Button();
		this.textBox1 = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.propertyGrid1.Location = new System.Drawing.Point(4, 29);
		this.propertyGrid1.Name = "propertyGrid1";
		this.propertyGrid1.Size = new System.Drawing.Size(585, 477);
		this.propertyGrid1.TabIndex = 0;
		this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.btnExit.Location = new System.Drawing.Point(498, 514);
		this.btnExit.Name = "btnExit";
		this.btnExit.Size = new System.Drawing.Size(85, 23);
		this.btnExit.TabIndex = 2;
		this.btnExit.Text = "Exit";
		this.btnExit.UseVisualStyleBackColor = true;
		this.btnExit.Click += new System.EventHandler(btnExit_Click);
		this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBox1.Location = new System.Drawing.Point(12, 6);
		this.textBox1.Multiline = true;
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(507, 31);
		this.textBox1.TabIndex = 3;
		this.textBox1.Text = "All changes take place immediately except for Server and Client IO provisioning which requires a restart.";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(595, 541);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.btnExit);
		base.Controls.Add(this.propertyGrid1);
		base.Name = "ArcServerSetup";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "AR-Cluster Server Setup";
		base.Load += new System.EventHandler(CfgEditor_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public ArcServerSetup()
	{
		InitializeComponent();
	}

	private void CfgEditor_Load(object sender, EventArgs e)
	{
		propertyGrid1.SelectedObject = ArcServerCfg;
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		ArcServerCfg.Save(saveToWebService: true);
		Close();
	}
}
