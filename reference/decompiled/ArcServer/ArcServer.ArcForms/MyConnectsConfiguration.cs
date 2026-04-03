using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.ArcObjs;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;

namespace ArcServer.ArcForms;

public class MyConnectsConfiguration : Form
{
	private IContainer components;

	private Button btnSave;

	private PropertyGrid propertyGrid1;

	private Button btnCancel;

	private ArCluster _arc;

	private Guid _id;

	private ArcUserCfg _clonedUserCfg;

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
		this.btnSave = new System.Windows.Forms.Button();
		this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
		this.btnCancel = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.btnSave.Location = new System.Drawing.Point(426, 380);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(75, 23);
		this.btnSave.TabIndex = 0;
		this.btnSave.Text = "Save";
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnSave.Click += new System.EventHandler(btnSave_Click);
		this.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.propertyGrid1.Location = new System.Drawing.Point(7, 3);
		this.propertyGrid1.Name = "propertyGrid1";
		this.propertyGrid1.Size = new System.Drawing.Size(494, 371);
		this.propertyGrid1.TabIndex = 1;
		this.btnCancel.Location = new System.Drawing.Point(290, 380);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 2;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(506, 407);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.propertyGrid1);
		base.Controls.Add(this.btnSave);
		base.Name = "MyConnectsConfiguration";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Connect Configuration";
		base.ResumeLayout(false);
	}

	public MyConnectsConfiguration(ArCluster arc, Guid id)
	{
		InitializeComponent();
		_arc = arc;
		_id = id;
		ArcConnect arcBaseById = _arc.GetArcBaseById(_id);
		if (arcBaseById != null)
		{
			_clonedUserCfg = CloneAndScrub(arcBaseById.Cfg);
			propertyGrid1.SelectedObject = _clonedUserCfg;
		}
	}

	private ArcUserCfg CloneAndScrub(ArcUserCfg cfg)
	{
		string rawValue = cfg.Serialize();
		ArcUserCfg arcUserCfg = rawValue.Deserialize<ArcUserCfg>();
		arcUserCfg.Dx.Filter = UtilsSql.UnFormatSqlFilter(arcUserCfg.Dx.Filter);
		arcUserCfg.Ann.Filter = UtilsSql.UnFormatSqlFilter(arcUserCfg.Ann.Filter);
		arcUserCfg.Wx.Filter = UtilsSql.UnFormatSqlFilter(arcUserCfg.Wx.Filter);
		return arcUserCfg;
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		if (IsValidDxCfg() && IsValidAnnCfg() && IsValidWxCfg())
		{
			_arc.UpdateUserConfig(_id, _clonedUserCfg);
			Close();
		}
	}

	private bool IsValidDxCfg()
	{
		string newFilter = string.Empty;
		bool flag = _arc.IsValidDxFilter(_clonedUserCfg.Dx.Filter, out newFilter);
		if (flag)
		{
			_clonedUserCfg.Dx.Filter = newFilter;
		}
		else
		{
			MessageBox.Show("The DX filter does not pass validation and cannot be saved.  Please correct and retry.", "Invalid DX Filter", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		return flag;
	}

	private bool IsValidAnnCfg()
	{
		string newFilter = string.Empty;
		bool flag = _arc.IsValidAnnFilter(_clonedUserCfg.Ann.Filter, out newFilter);
		if (flag)
		{
			_clonedUserCfg.Ann.Filter = newFilter;
		}
		else
		{
			MessageBox.Show("The Ann filter does not pass validation and cannot be saved.  Please correct and retry.", "Invalid Ann Filter", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		return flag;
	}

	private bool IsValidWxCfg()
	{
		string newFilter = string.Empty;
		bool flag = _arc.IsValidWxFilter(_clonedUserCfg.Wx.Filter, out newFilter);
		if (flag)
		{
			_clonedUserCfg.Wx.Filter = newFilter;
		}
		else
		{
			MessageBox.Show("The WX filter does not pass validation and cannot be saved.  Please correct and retry.", "Invalid WX Filter", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		return flag;
	}
}
