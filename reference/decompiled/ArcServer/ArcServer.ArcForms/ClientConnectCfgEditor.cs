using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcInterfaces.Io;
using ArcShared.ArcUtils;

namespace ArcServer.ArcForms;

public class ClientConnectCfgEditor : Form
{
	private IContainer components;

	private Button btnSave;

	private Button btnCancel;

	private Label label1;

	private TextBox txtConnectTo;

	private ComboBox cboConnectType;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private TextBox txtIpAddress;

	private TextBox txtPort;

	private TextBox txtConnectAs;

	private TextBox txtPassword;

	private TextBox txtDescription;

	private Label label7;

	private Label lblError;

	private ArCluster _arc;

	private ClientIoCfg _clientCfg;

	public ClientIoCfg ClientCfg
	{
		get
		{
			return _clientCfg;
		}
		set
		{
			_clientCfg = value;
			cboConnectType.Text = value.Type.ToString();
			txtConnectTo.Text = value.ConnectTo;
			txtConnectAs.Text = value.ConnectAs;
			txtDescription.Text = value.Description;
			txtIpAddress.Text = value.IpAddress;
			txtPort.Text = value.Port.ToString();
			txtPassword.Text = value.Password;
		}
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
		this.btnSave = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.txtConnectTo = new System.Windows.Forms.TextBox();
		this.cboConnectType = new System.Windows.Forms.ComboBox();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.txtIpAddress = new System.Windows.Forms.TextBox();
		this.txtPort = new System.Windows.Forms.TextBox();
		this.txtConnectAs = new System.Windows.Forms.TextBox();
		this.txtPassword = new System.Windows.Forms.TextBox();
		this.txtDescription = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.lblError = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.btnSave.Location = new System.Drawing.Point(69, 262);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(75, 23);
		this.btnSave.TabIndex = 0;
		this.btnSave.Text = "Save";
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnSave.Click += new System.EventHandler(btnSave_Click);
		this.btnCancel.Location = new System.Drawing.Point(175, 262);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 1;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(23, 19);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(31, 13);
		this.label1.TabIndex = 2;
		this.label1.Text = "Type";
		this.txtConnectTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.txtConnectTo.Location = new System.Drawing.Point(92, 113);
		this.txtConnectTo.Name = "txtConnectTo";
		this.txtConnectTo.Size = new System.Drawing.Size(152, 20);
		this.txtConnectTo.TabIndex = 3;
		this.cboConnectType.FormattingEnabled = true;
		this.cboConnectType.Items.AddRange(new object[8] { "Arc4Active", "Arc4Passive", "Ar6Node", "TelnetClient", "PCxx", "ReverseBeaconClient", "AGW", "BPQ" });
		this.cboConnectType.Location = new System.Drawing.Point(92, 16);
		this.cboConnectType.Name = "cboConnectType";
		this.cboConnectType.Size = new System.Drawing.Size(152, 21);
		this.cboConnectType.TabIndex = 4;
		this.cboConnectType.Text = "TelnetClient";
		this.cboConnectType.SelectedIndexChanged += new System.EventHandler(cboConnectType_SelectedIndexChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(23, 51);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(54, 13);
		this.label2.TabIndex = 5;
		this.label2.Text = "IpAddress";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(23, 83);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(26, 13);
		this.label3.TabIndex = 6;
		this.label3.Text = "Port";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(23, 115);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 13);
		this.label4.TabIndex = 7;
		this.label4.Text = "ConnectTo";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(23, 147);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(59, 13);
		this.label5.TabIndex = 8;
		this.label5.Text = "ConnectAs";
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(23, 179);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(53, 13);
		this.label6.TabIndex = 9;
		this.label6.Text = "Password";
		this.txtIpAddress.Location = new System.Drawing.Point(92, 49);
		this.txtIpAddress.Name = "txtIpAddress";
		this.txtIpAddress.Size = new System.Drawing.Size(152, 20);
		this.txtIpAddress.TabIndex = 10;
		this.txtPort.Location = new System.Drawing.Point(92, 81);
		this.txtPort.Name = "txtPort";
		this.txtPort.Size = new System.Drawing.Size(152, 20);
		this.txtPort.TabIndex = 11;
		this.txtConnectAs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.txtConnectAs.Location = new System.Drawing.Point(92, 145);
		this.txtConnectAs.Name = "txtConnectAs";
		this.txtConnectAs.Size = new System.Drawing.Size(152, 20);
		this.txtConnectAs.TabIndex = 12;
		this.txtPassword.Location = new System.Drawing.Point(92, 177);
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.Size = new System.Drawing.Size(152, 20);
		this.txtPassword.TabIndex = 13;
		this.txtDescription.Location = new System.Drawing.Point(92, 209);
		this.txtDescription.Name = "txtDescription";
		this.txtDescription.Size = new System.Drawing.Size(208, 20);
		this.txtDescription.TabIndex = 14;
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(26, 211);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(60, 13);
		this.label7.TabIndex = 15;
		this.label7.Text = "Description";
		this.lblError.AutoSize = true;
		this.lblError.ForeColor = System.Drawing.Color.Red;
		this.lblError.Location = new System.Drawing.Point(26, 240);
		this.lblError.Name = "lblError";
		this.lblError.Size = new System.Drawing.Size(106, 13);
		this.lblError.TabIndex = 17;
		this.lblError.Text = "Error messaging here";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(319, 297);
		base.Controls.Add(this.lblError);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.txtDescription);
		base.Controls.Add(this.txtPassword);
		base.Controls.Add(this.txtConnectAs);
		base.Controls.Add(this.txtPort);
		base.Controls.Add(this.txtIpAddress);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.cboConnectType);
		base.Controls.Add(this.txtConnectTo);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnSave);
		base.Name = "ClientConnectCfgEditor";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "New Client Connect Configuration";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public ClientConnectCfgEditor(ArCluster arc)
	{
		InitializeComponent();
		_arc = arc;
		lblError.Text = string.Empty;
		_clientCfg = new ClientIoCfg();
		txtConnectAs.Text = _arc.Call;
		txtPort.Text = "23";
	}

	private ClientIoType GetIoType()
	{
		return cboConnectType.Text switch
		{
			"Arc4Active" => ClientIoType.Arc4Active, 
			"Arc4Passive" => ClientIoType.Arc4Active, 
			"Ar6Node" => ClientIoType.Ar6Node, 
			"Telnet" => ClientIoType.Telnet, 
			"ReverseBeacon" => ClientIoType.TelnetExtComment, 
			"PCxx" => ClientIoType.PCxx, 
			"Mirc" => ClientIoType.Mirc, 
			_ => ClientIoType.Telnet, 
		};
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void cboConnectType_SelectedIndexChanged(object sender, EventArgs e)
	{
		switch (cboConnectType.Text)
		{
		case "Arc4Active":
			txtPort.Text = "3605";
			txtPort.ReadOnly = true;
			txtConnectAs.Text = _arc.Call;
			txtConnectAs.ReadOnly = true;
			break;
		case "Arc4Passive":
			txtPort.Text = "3606";
			txtPort.ReadOnly = true;
			txtConnectAs.Text = _arc.Call;
			txtConnectAs.ReadOnly = true;
			break;
		case "Ar6Node":
			txtPort.Text = "3607";
			txtPort.ReadOnly = true;
			txtConnectAs.Text = _arc.Call;
			txtConnectAs.ReadOnly = true;
			break;
		default:
			txtPort.Text = "23";
			txtPort.ReadOnly = false;
			txtConnectAs.ReadOnly = false;
			break;
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		if (IsValidForm())
		{
			int port = Convert.ToInt32(txtPort.Text);
			_clientCfg.Type = GetIoType();
			_clientCfg.ConnectTo = txtConnectTo.Text;
			_clientCfg.ConnectAs = txtConnectAs.Text;
			_clientCfg.Description = txtDescription.Text;
			_clientCfg.IpAddress = txtIpAddress.Text;
			_clientCfg.Port = port;
			_clientCfg.Password = txtPassword.Text;
			base.DialogResult = DialogResult.OK;
			Close();
		}
	}

	private bool IsValidForm()
	{
		txtIpAddress.Text = txtIpAddress.Text.Trim();
		txtPort.Text = txtPort.Text.Trim();
		txtConnectTo.Text = txtConnectTo.Text.Trim();
		txtConnectAs.Text = txtConnectAs.Text.Trim();
		txtDescription.Text = txtDescription.Text.Trim();
		txtPassword.Text = txtPassword.Text.Trim();
		if (string.IsNullOrEmpty(txtIpAddress.Text))
		{
			lblError.Text = "Please enter a valid IP address";
			return false;
		}
		if (string.IsNullOrEmpty(txtPort.Text) || !UtilsNumeric.IsNumeric(txtPort.Text))
		{
			lblError.Text = "Please enter a valid numerical port";
			return false;
		}
		if ((string.IsNullOrEmpty(txtConnectTo.Text) || !UtilsCallsign.IsValidCall(txtConnectTo.Text)) && txtConnectTo.Text != "#CQDX")
		{
			lblError.Text = "Please enter a valid Connect To call";
			return false;
		}
		if (string.IsNullOrEmpty(txtConnectAs.Text) || !UtilsCallsign.IsValidCall(txtConnectAs.Text))
		{
			lblError.Text = "Please enter a valid Connect As call";
			return false;
		}
		if (string.IsNullOrEmpty(txtDescription.Text))
		{
			lblError.Text = "Please enter a valid description for the connection";
			return false;
		}
		return true;
	}
}
