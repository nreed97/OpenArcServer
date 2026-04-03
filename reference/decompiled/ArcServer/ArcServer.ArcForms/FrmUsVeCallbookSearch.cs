using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcInterfaces;
using log4net;

namespace ArcServer.ArcForms;

internal class FrmUsVeCallbookSearch : Form
{
	private static readonly ILog _log = LogManager.GetLogger("FrmUsVeCallbookSearch");

	internal ArCluster Arc;

	private IContainer components;

	private Label label14;

	private Label label7;

	private Label label13;

	private TextBox txtState;

	private Label label12;

	private TextBox txtLicenseIssue;

	private Label label11;

	private TextBox txtLicenseExpiration;

	private Label label10;

	private TextBox txtLicenseClass;

	private Label label9;

	private TextBox txtArrlSection;

	private Label label6;

	private TextBox txtCounty;

	private Label label5;

	private TextBox txtZip;

	private Label label4;

	private TextBox txtCity;

	private Label label3;

	private TextBox txtAddress;

	private TextBox txtLastName;

	private TextBox txtMiddleName;

	private TextBox txtFirstName;

	private Label label2;

	private Button btnLookup;

	private TextBox txtCall;

	private Label label1;

	internal FrmUsVeCallbookSearch()
	{
		InitializeComponent();
	}

	private void btnLookup_Click(object sender, EventArgs e)
	{
		try
		{
			Cursor = Cursors.WaitCursor;
			ClearForm();
			txtCall.Text = txtCall.Text.ToUpper();
			CallbookData callbookData = Arc.CallbookSearch(txtCall.Text);
			if (callbookData != null)
			{
				txtFirstName.Text = callbookData.FirstName;
				txtMiddleName.Text = callbookData.MiddleName;
				txtLastName.Text = callbookData.LastName;
				txtAddress.Text = callbookData.Address;
				txtCity.Text = callbookData.City;
				txtState.Text = callbookData.State;
				txtZip.Text = callbookData.Zip;
				txtCounty.Text = callbookData.County;
				txtArrlSection.Text = callbookData.ArrlSection;
				txtLicenseClass.Text = callbookData.LicenseClass;
				txtLicenseExpiration.Text = callbookData.LicenseExpirationDate;
				txtLicenseIssue.Text = callbookData.LicenseIssueDate;
			}
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
			MessageBox.Show("An error occurred in looking up the call.  Please make sure the callsign databases files are present in the correct location.", "Error in callbook lookup");
		}
		Cursor = Cursors.Default;
	}

	private void ClearForm()
	{
		txtFirstName.Text = string.Empty;
		txtMiddleName.Text = string.Empty;
		txtLastName.Text = string.Empty;
		txtAddress.Text = string.Empty;
		txtCity.Text = string.Empty;
		txtState.Text = string.Empty;
		txtZip.Text = string.Empty;
		txtCounty.Text = string.Empty;
		txtArrlSection.Text = string.Empty;
		txtLicenseClass.Text = string.Empty;
		txtLicenseExpiration.Text = string.Empty;
		txtLicenseIssue.Text = string.Empty;
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
		this.label14 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.txtState = new System.Windows.Forms.TextBox();
		this.label12 = new System.Windows.Forms.Label();
		this.txtLicenseIssue = new System.Windows.Forms.TextBox();
		this.label11 = new System.Windows.Forms.Label();
		this.txtLicenseExpiration = new System.Windows.Forms.TextBox();
		this.label10 = new System.Windows.Forms.Label();
		this.txtLicenseClass = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.txtArrlSection = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.txtCounty = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.txtZip = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.txtCity = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.txtAddress = new System.Windows.Forms.TextBox();
		this.txtLastName = new System.Windows.Forms.TextBox();
		this.txtMiddleName = new System.Windows.Forms.TextBox();
		this.txtFirstName = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.btnLookup = new System.Windows.Forms.Button();
		this.txtCall = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.label14.AutoSize = true;
		this.label14.Location = new System.Drawing.Point(319, 9);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(58, 13);
		this.label14.TabIndex = 59;
		this.label14.Text = "Last Name";
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(199, 9);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(69, 13);
		this.label7.TabIndex = 58;
		this.label7.Text = "Middle Name";
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(319, 54);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(32, 13);
		this.label13.TabIndex = 57;
		this.label13.Text = "State";
		this.txtState.Location = new System.Drawing.Point(319, 73);
		this.txtState.Name = "txtState";
		this.txtState.ReadOnly = true;
		this.txtState.Size = new System.Drawing.Size(32, 20);
		this.txtState.TabIndex = 56;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(319, 144);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(32, 13);
		this.label12.TabIndex = 55;
		this.label12.Text = "Issue";
		this.txtLicenseIssue.Location = new System.Drawing.Point(319, 163);
		this.txtLicenseIssue.Name = "txtLicenseIssue";
		this.txtLicenseIssue.ReadOnly = true;
		this.txtLicenseIssue.Size = new System.Drawing.Size(113, 20);
		this.txtLicenseIssue.TabIndex = 54;
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(199, 144);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(53, 13);
		this.label11.TabIndex = 53;
		this.label11.Text = "Expiration";
		this.txtLicenseExpiration.Location = new System.Drawing.Point(199, 163);
		this.txtLicenseExpiration.Name = "txtLicenseExpiration";
		this.txtLicenseExpiration.ReadOnly = true;
		this.txtLicenseExpiration.Size = new System.Drawing.Size(112, 20);
		this.txtLicenseExpiration.TabIndex = 52;
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(12, 144);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(72, 13);
		this.label10.TabIndex = 51;
		this.label10.Text = "License Class";
		this.txtLicenseClass.Location = new System.Drawing.Point(12, 163);
		this.txtLicenseClass.Name = "txtLicenseClass";
		this.txtLicenseClass.ReadOnly = true;
		this.txtLicenseClass.Size = new System.Drawing.Size(175, 20);
		this.txtLicenseClass.TabIndex = 50;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(199, 99);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(75, 13);
		this.label9.TabIndex = 49;
		this.label9.Text = "ARRL Section";
		this.txtArrlSection.Location = new System.Drawing.Point(199, 118);
		this.txtArrlSection.Name = "txtArrlSection";
		this.txtArrlSection.ReadOnly = true;
		this.txtArrlSection.Size = new System.Drawing.Size(112, 20);
		this.txtArrlSection.TabIndex = 48;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(12, 99);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(40, 13);
		this.label6.TabIndex = 45;
		this.label6.Text = "County";
		this.txtCounty.Location = new System.Drawing.Point(12, 118);
		this.txtCounty.Name = "txtCounty";
		this.txtCounty.ReadOnly = true;
		this.txtCounty.Size = new System.Drawing.Size(175, 20);
		this.txtCounty.TabIndex = 44;
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(369, 54);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(22, 13);
		this.label5.TabIndex = 43;
		this.label5.Text = "Zip";
		this.txtZip.Location = new System.Drawing.Point(372, 73);
		this.txtZip.Name = "txtZip";
		this.txtZip.ReadOnly = true;
		this.txtZip.Size = new System.Drawing.Size(60, 20);
		this.txtZip.TabIndex = 42;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(199, 54);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(24, 13);
		this.label4.TabIndex = 41;
		this.label4.Text = "City";
		this.txtCity.Location = new System.Drawing.Point(199, 73);
		this.txtCity.Name = "txtCity";
		this.txtCity.ReadOnly = true;
		this.txtCity.Size = new System.Drawing.Size(112, 20);
		this.txtCity.TabIndex = 40;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(12, 54);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(45, 13);
		this.label3.TabIndex = 39;
		this.label3.Text = "Address";
		this.txtAddress.Location = new System.Drawing.Point(12, 73);
		this.txtAddress.Name = "txtAddress";
		this.txtAddress.ReadOnly = true;
		this.txtAddress.Size = new System.Drawing.Size(175, 20);
		this.txtAddress.TabIndex = 38;
		this.txtLastName.Location = new System.Drawing.Point(319, 28);
		this.txtLastName.Name = "txtLastName";
		this.txtLastName.ReadOnly = true;
		this.txtLastName.Size = new System.Drawing.Size(113, 20);
		this.txtLastName.TabIndex = 37;
		this.txtMiddleName.Location = new System.Drawing.Point(199, 28);
		this.txtMiddleName.Name = "txtMiddleName";
		this.txtMiddleName.ReadOnly = true;
		this.txtMiddleName.Size = new System.Drawing.Size(112, 20);
		this.txtMiddleName.TabIndex = 36;
		this.txtFirstName.Location = new System.Drawing.Point(12, 28);
		this.txtFirstName.Name = "txtFirstName";
		this.txtFirstName.ReadOnly = true;
		this.txtFirstName.Size = new System.Drawing.Size(175, 20);
		this.txtFirstName.TabIndex = 35;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(12, 9);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(57, 13);
		this.label2.TabIndex = 34;
		this.label2.Text = "First Name";
		this.btnLookup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.btnLookup.Location = new System.Drawing.Point(186, 214);
		this.btnLookup.Name = "btnLookup";
		this.btnLookup.Size = new System.Drawing.Size(84, 23);
		this.btnLookup.TabIndex = 33;
		this.btnLookup.Text = "Lookup";
		this.btnLookup.UseVisualStyleBackColor = true;
		this.btnLookup.Click += new System.EventHandler(btnLookup_Click);
		this.txtCall.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.txtCall.Location = new System.Drawing.Point(58, 216);
		this.txtCall.Name = "txtCall";
		this.txtCall.Size = new System.Drawing.Size(100, 20);
		this.txtCall.TabIndex = 32;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(12, 219);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(24, 13);
		this.label1.TabIndex = 31;
		this.label1.Text = "Call";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(443, 256);
		base.Controls.Add(this.label14);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.label13);
		base.Controls.Add(this.txtState);
		base.Controls.Add(this.label12);
		base.Controls.Add(this.txtLicenseIssue);
		base.Controls.Add(this.label11);
		base.Controls.Add(this.txtLicenseExpiration);
		base.Controls.Add(this.label10);
		base.Controls.Add(this.txtLicenseClass);
		base.Controls.Add(this.label9);
		base.Controls.Add(this.txtArrlSection);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.txtCounty);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.txtZip);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.txtCity);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.txtAddress);
		base.Controls.Add(this.txtLastName);
		base.Controls.Add(this.txtMiddleName);
		base.Controls.Add(this.txtFirstName);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.btnLookup);
		base.Controls.Add(this.txtCall);
		base.Controls.Add(this.label1);
		base.Name = "FrmUsVeCallbookSearch";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "US/VE Callbook Search";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
