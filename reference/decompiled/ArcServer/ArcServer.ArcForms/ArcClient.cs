using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AppControl;
using WeifenLuo.WinFormsUI.Docking;

namespace ArcServer.ArcForms;

public class ArcClient : DockContent
{
	private IContainer components;

	private AppLogControl applicationControl1;

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
		this.applicationControl1 = new AppControl.AppLogControl();
		base.SuspendLayout();
		this.applicationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.applicationControl1.ExeName = "";
		this.applicationControl1.Location = new System.Drawing.Point(0, 0);
		this.applicationControl1.Name = "applicationControl1";
		this.applicationControl1.Size = new System.Drawing.Size(292, 273);
		this.applicationControl1.TabIndex = 0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(292, 273);
		base.Controls.Add(this.applicationControl1);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Name = "ArcClient";
		this.Text = "ArcClient";
		base.ResumeLayout(false);
	}

	public ArcClient()
	{
		InitializeComponent();
	}
}
