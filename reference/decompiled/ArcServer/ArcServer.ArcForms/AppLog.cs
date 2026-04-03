using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AppControl;
using WeifenLuo.WinFormsUI.Docking;

namespace ArcServer.ArcForms;

public class AppLog : DockContent
{
	private IContainer components;

	private AppLogControl appLogControl1;

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
		this.appLogControl1 = new AppControl.AppLogControl();
		base.SuspendLayout();
		this.appLogControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.appLogControl1.ExeName = string.Empty;
		this.appLogControl1.Location = new System.Drawing.Point(0, 0);
		this.appLogControl1.Name = "appLogControl1";
		this.appLogControl1.Size = new System.Drawing.Size(292, 273);
		this.appLogControl1.TabIndex = 0;
		base.ClientSize = new System.Drawing.Size(292, 273);
		base.Controls.Add(this.appLogControl1);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Name = "AppLog";
		this.Text = "App Log";
		base.ResumeLayout(false);
	}

	public AppLog()
	{
		InitializeComponent();
	}
}
