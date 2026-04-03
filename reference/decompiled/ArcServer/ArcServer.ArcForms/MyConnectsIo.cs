using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.ArcObjs;

namespace ArcServer.ArcForms;

public class MyConnectsIo : Form
{
	private ArCluster _arc;

	private Guid _id;

	private IContainer components;

	private Button btnExit;

	private PropertyGrid propertyGrid1;

	private Button btnDisconnect;

	public MyConnectsIo(ArCluster arc, Guid id)
	{
		InitializeComponent();
		_arc = arc;
		_id = id;
		ArcConnect arcBaseById = _arc.GetArcBaseById(_id);
		if (arcBaseById != null)
		{
			propertyGrid1.SelectedObject = arcBaseById.Io;
		}
	}

	private void btnDisconnect_Click(object sender, EventArgs e)
	{
		if (!_arc.DisconnectById(_id))
		{
			base.DialogResult = DialogResult.No;
		}
		Close();
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		Close();
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
		this.btnExit = new System.Windows.Forms.Button();
		this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
		this.btnDisconnect = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.btnExit.Location = new System.Drawing.Point(524, 236);
		this.btnExit.Name = "btnExit";
		this.btnExit.Size = new System.Drawing.Size(75, 23);
		this.btnExit.TabIndex = 0;
		this.btnExit.Text = "Exit";
		this.btnExit.UseVisualStyleBackColor = true;
		this.btnExit.Click += new System.EventHandler(btnExit_Click);
		this.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.propertyGrid1.Location = new System.Drawing.Point(2, 1);
		this.propertyGrid1.Name = "propertyGrid1";
		this.propertyGrid1.Size = new System.Drawing.Size(596, 229);
		this.propertyGrid1.TabIndex = 2;
		this.btnDisconnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnDisconnect.Location = new System.Drawing.Point(3, 236);
		this.btnDisconnect.Name = "btnDisconnect";
		this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
		this.btnDisconnect.TabIndex = 3;
		this.btnDisconnect.Text = "Disconnect";
		this.btnDisconnect.UseVisualStyleBackColor = true;
		this.btnDisconnect.Click += new System.EventHandler(btnDisconnect_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(601, 262);
		base.Controls.Add(this.btnDisconnect);
		base.Controls.Add(this.propertyGrid1);
		base.Controls.Add(this.btnExit);
		base.Name = "MyConnectsIo";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Connection";
		base.ResumeLayout(false);
	}
}
