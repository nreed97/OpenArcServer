using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using WeifenLuo.WinFormsUI.Docking;

namespace ArcServer.ArcForms;

public class SandBox : DockContent
{
	private IContainer components;

	private TextBox txtCmdMsg;

	private Button btnCmdTest;

	private CheckBox chkIsBeta;

	private Button btnUpdate;

	private Button btnListThreads;

	private TextBox txtCall;

	private Label label1;

	private Button btnAddPcxxNode;

	private ArCluster _arc;

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
		this.txtCmdMsg = new System.Windows.Forms.TextBox();
		this.btnCmdTest = new System.Windows.Forms.Button();
		this.chkIsBeta = new System.Windows.Forms.CheckBox();
		this.btnUpdate = new System.Windows.Forms.Button();
		this.btnListThreads = new System.Windows.Forms.Button();
		this.txtCall = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnAddPcxxNode = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.txtCmdMsg.Location = new System.Drawing.Point(107, 107);
		this.txtCmdMsg.Name = "txtCmdMsg";
		this.txtCmdMsg.Size = new System.Drawing.Size(583, 20);
		this.txtCmdMsg.TabIndex = 7;
		this.txtCmdMsg.Text = "PC19^1^WU3V^0^5447^1^N5UXT-3^0^5447^1^K5MDX^0^5447^1^K5USL^0^5447^H99^";
		this.btnCmdTest.Location = new System.Drawing.Point(21, 105);
		this.btnCmdTest.Name = "btnCmdTest";
		this.btnCmdTest.Size = new System.Drawing.Size(51, 23);
		this.btnCmdTest.TabIndex = 6;
		this.btnCmdTest.Text = "Cmd";
		this.btnCmdTest.UseVisualStyleBackColor = true;
		this.btnCmdTest.Click += new System.EventHandler(btnCmdTest_Click);
		this.chkIsBeta.AutoSize = true;
		this.chkIsBeta.Location = new System.Drawing.Point(23, 68);
		this.chkIsBeta.Name = "chkIsBeta";
		this.chkIsBeta.Size = new System.Drawing.Size(48, 17);
		this.chkIsBeta.TabIndex = 5;
		this.chkIsBeta.Text = "Beta";
		this.chkIsBeta.UseVisualStyleBackColor = true;
		this.btnUpdate.Location = new System.Drawing.Point(88, 64);
		this.btnUpdate.Name = "btnUpdate";
		this.btnUpdate.Size = new System.Drawing.Size(97, 23);
		this.btnUpdate.TabIndex = 4;
		this.btnUpdate.Text = "Check For Updates";
		this.btnUpdate.UseVisualStyleBackColor = true;
		this.btnListThreads.Location = new System.Drawing.Point(500, 63);
		this.btnListThreads.Name = "btnListThreads";
		this.btnListThreads.Size = new System.Drawing.Size(75, 23);
		this.btnListThreads.TabIndex = 8;
		this.btnListThreads.Text = "List Threads";
		this.btnListThreads.UseVisualStyleBackColor = true;
		this.btnListThreads.Click += new System.EventHandler(btnListThreads_Click);
		this.txtCall.Location = new System.Drawing.Point(80, 14);
		this.txtCall.Name = "txtCall";
		this.txtCall.Size = new System.Drawing.Size(58, 20);
		this.txtCall.TabIndex = 9;
		this.txtCall.Text = "AB5K";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(35, 17);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(24, 13);
		this.label1.TabIndex = 10;
		this.label1.Text = "Call";
		this.btnAddPcxxNode.Location = new System.Drawing.Point(144, 12);
		this.btnAddPcxxNode.Name = "btnAddPcxxNode";
		this.btnAddPcxxNode.Size = new System.Drawing.Size(75, 23);
		this.btnAddPcxxNode.TabIndex = 11;
		this.btnAddPcxxNode.Text = "Add PcxxNode";
		this.btnAddPcxxNode.UseVisualStyleBackColor = true;
		this.btnAddPcxxNode.Click += new System.EventHandler(btnAddPcxxNode_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(714, 152);
		base.Controls.Add(this.btnAddPcxxNode);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.txtCall);
		base.Controls.Add(this.btnListThreads);
		base.Controls.Add(this.txtCmdMsg);
		base.Controls.Add(this.btnCmdTest);
		base.Controls.Add(this.chkIsBeta);
		base.Controls.Add(this.btnUpdate);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Name = "SandBox";
		this.Text = "Sandbox";
		base.Load += new System.EventHandler(SandBox_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public SandBox()
	{
		InitializeComponent();
	}

	public void Init(ArCluster arc)
	{
		_arc = arc;
	}

	private void btnCmdTest_Click(object sender, EventArgs e)
	{
		_arc.CmdTest(txtCall.Text, txtCmdMsg.Text);
	}

	private void btnUpdate_Click(object sender, EventArgs e)
	{
	}

	private void SandBox_Load(object sender, EventArgs e)
	{
	}

	private void btnListThreads_Click(object sender, EventArgs e)
	{
	}

	private void btnAddPcxxNode_Click(object sender, EventArgs e)
	{
		_arc.AddPcxxNode(txtCall.Text);
	}
}
