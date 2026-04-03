using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcInterfaces.Io;
using ArcServer.Properties;
using WeifenLuo.WinFormsUI.Docking;
using log4net;

namespace ArcServer.ArcForms;

public class OutboundConnects : DockContent
{
	private IContainer components;

	private DataGridView dataGridView1;

	private Timer timer1;

	private static readonly ILog _log = LogManager.GetLogger("OutboundConnects");

	private ArCluster _arc;

	private BindingSource _bindingSource;

	private BindingList<IIoClient> _listClients;

	private Bitmap _greenCheck;

	private Bitmap _nilCheck;

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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		this.dataGridView1 = new System.Windows.Forms.DataGridView();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
		base.SuspendLayout();
		this.dataGridView1.AllowUserToAddRows = false;
		this.dataGridView1.AllowUserToDeleteRows = false;
		this.dataGridView1.AllowUserToResizeRows = false;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.Black;
		this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dataGridView1.Location = new System.Drawing.Point(0, 0);
		this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
		this.dataGridView1.MultiSelect = false;
		this.dataGridView1.Name = "dataGridView1";
		this.dataGridView1.RowHeadersVisible = false;
		this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
		this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
		this.dataGridView1.RowTemplate.Height = 24;
		this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
		this.dataGridView1.Size = new System.Drawing.Size(690, 267);
		this.dataGridView1.TabIndex = 3;
		this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dataGridView1_CellContentClick);
		this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
		this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(dataGridView1_DataError);
		this.timer1.Interval = 10000;
		this.timer1.Tick += new System.EventHandler(timer1_Tick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(690, 267);
		base.Controls.Add(this.dataGridView1);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Name = "OutboundConnects";
		this.Text = "Outbound Connects";
		((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
		base.ResumeLayout(false);
	}

	public OutboundConnects()
	{
		InitializeComponent();
		_greenCheck = new Bitmap(Resources.GrnCheck);
		_nilCheck = new Bitmap(Resources.NilCheck);
	}

	public void Init(ArCluster arc)
	{
		_arc = arc;
		InitDataGrid();
		_listClients = _arc.GetEnabledClients();
		_bindingSource = new BindingSource
		{
			DataSource = _listClients
		};
		dataGridView1.DataSource = _bindingSource;
		timer1.Enabled = true;
	}

	private void InitDataGrid()
	{
		dataGridView1.AutoGenerateColumns = false;
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn.HeaderText = "Id";
		dataGridViewTextBoxColumn.Name = "Id";
		dataGridViewTextBoxColumn.DataPropertyName = "Id";
		dataGridViewTextBoxColumn.Width = 25;
		dataGridViewTextBoxColumn.Visible = false;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn2.HeaderText = "Type";
		dataGridViewTextBoxColumn2.Name = "Type";
		dataGridViewTextBoxColumn2.DataPropertyName = "Type";
		dataGridViewTextBoxColumn2.Width = 95;
		dataGridViewTextBoxColumn2.ToolTipText = "Type";
		dataGridViewTextBoxColumn2.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn2);
		DataGridViewLinkColumn dataGridViewLinkColumn = new DataGridViewLinkColumn();
		dataGridViewLinkColumn.HeaderText = "ConnectTo";
		dataGridViewLinkColumn.Name = "ConnectTo";
		dataGridViewLinkColumn.DataPropertyName = "ConnectTo";
		dataGridViewLinkColumn.UseColumnTextForLinkValue = false;
		dataGridViewLinkColumn.ActiveLinkColor = Color.White;
		dataGridViewLinkColumn.LinkBehavior = LinkBehavior.HoverUnderline;
		dataGridViewLinkColumn.LinkColor = Color.Blue;
		dataGridViewLinkColumn.TrackVisitedState = true;
		dataGridViewLinkColumn.VisitedLinkColor = Color.YellowGreen;
		dataGridViewLinkColumn.Width = 75;
		dataGridViewLinkColumn.ToolTipText = "Callsign";
		dataGridViewLinkColumn.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewLinkColumn);
		DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
		dataGridViewImageColumn.HeaderText = "Connected";
		dataGridViewImageColumn.Name = "IsConnected";
		dataGridViewImageColumn.DataPropertyName = "IsConnected";
		dataGridViewImageColumn.Width = 65;
		dataGridViewImageColumn.ToolTipText = "Connected";
		dataGridViewLinkColumn.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewImageColumn);
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		dataGridViewCheckBoxColumn.HeaderText = "Enabled";
		dataGridViewCheckBoxColumn.Name = "Enabled";
		dataGridViewCheckBoxColumn.DataPropertyName = "Enabled";
		dataGridViewCheckBoxColumn.Width = 55;
		dataGridViewCheckBoxColumn.ToolTipText = "Enabled";
		dataGridView1.Columns.Add(dataGridViewCheckBoxColumn);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn3.HeaderText = "ConnectAs";
		dataGridViewTextBoxColumn3.Name = "ConnectAs";
		dataGridViewTextBoxColumn3.DataPropertyName = "ConnectAs";
		dataGridViewTextBoxColumn3.Width = 80;
		dataGridViewTextBoxColumn3.ToolTipText = "ConnectAs";
		dataGridViewTextBoxColumn3.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn3);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn4.HeaderText = "Description";
		dataGridViewTextBoxColumn4.Name = "Description";
		dataGridViewTextBoxColumn4.DataPropertyName = "Description";
		dataGridViewTextBoxColumn4.Width = 155;
		dataGridViewTextBoxColumn4.ToolTipText = "Description";
		dataGridViewTextBoxColumn4.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn4);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn5.HeaderText = "IpAddress";
		dataGridViewTextBoxColumn5.Name = "IpAddress";
		dataGridViewTextBoxColumn5.DataPropertyName = "IpAddress";
		dataGridViewTextBoxColumn5.Width = 125;
		dataGridViewTextBoxColumn5.ToolTipText = "IpAddress";
		dataGridViewTextBoxColumn5.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn5);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn6.HeaderText = "Port";
		dataGridViewTextBoxColumn6.Name = "Port";
		dataGridViewTextBoxColumn6.DataPropertyName = "Port";
		dataGridViewTextBoxColumn6.Width = 50;
		dataGridViewTextBoxColumn6.ToolTipText = "IpAddress";
		dataGridViewTextBoxColumn6.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn6);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn7.HeaderText = "DxPerHr";
		dataGridViewTextBoxColumn7.Name = "DxPerHr";
		dataGridViewTextBoxColumn7.DataPropertyName = "LastTenMinuteDxCnt";
		dataGridViewTextBoxColumn7.Width = 60;
		dataGridViewTextBoxColumn7.ToolTipText = "DxPerHr";
		dataGridViewTextBoxColumn7.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn7);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn8.HeaderText = "DupesPerHr";
		dataGridViewTextBoxColumn8.Name = "DupesPerHr";
		dataGridViewTextBoxColumn8.DataPropertyName = "LastTenMinuteDxDupeCnt";
		dataGridViewTextBoxColumn8.Width = 75;
		dataGridViewTextBoxColumn8.ToolTipText = "DupesPerHr";
		dataGridViewTextBoxColumn8.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn8);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn9.HeaderText = "UpTime";
		dataGridViewTextBoxColumn9.Name = "UpTime";
		dataGridViewTextBoxColumn9.DataPropertyName = "EndPoint";
		dataGridViewTextBoxColumn9.Width = 75;
		dataGridViewTextBoxColumn9.ToolTipText = "UpTime";
		dataGridViewTextBoxColumn9.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn9);
		for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
		{
			dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
		}
	}

	private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
		e.ThrowException = false;
	}

	private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		switch (e.ColumnIndex)
		{
		case 1:
			e.Value = GetClientIoType(_listClients[e.RowIndex].GetType().ToString());
			break;
		case 2:
			e.Value = _listClients[e.RowIndex].IoCfg.ConnectTo;
			e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
			break;
		case 3:
			if ((bool)e.Value)
			{
				e.Value = _greenCheck;
			}
			else
			{
				e.Value = _nilCheck;
			}
			break;
		case 4:
		{
			bool enabled = _listClients[e.RowIndex].IoCfg.Enabled;
			e.Value = enabled;
			bool isConnected = _listClients[e.RowIndex].IsConnected;
			if (enabled && !isConnected)
			{
				e.CellStyle.BackColor = Color.Yellow;
			}
			else
			{
				e.CellStyle.BackColor = Color.White;
			}
			break;
		}
		case 5:
			e.Value = _listClients[e.RowIndex].IoCfg.ConnectAs;
			break;
		case 6:
			e.Value = _listClients[e.RowIndex].IoCfg.Description;
			break;
		case 7:
			e.Value = _listClients[e.RowIndex].IoCfg.IpAddress;
			break;
		case 8:
			e.Value = _listClients[e.RowIndex].IoCfg.Port;
			break;
		case 9:
			e.Value = GetDxCnt(e.RowIndex);
			break;
		case 10:
			e.Value = _listClients[e.RowIndex].LastTenMinuteDxDupeCnt * 6;
			break;
		}
	}

	private double GetDxCnt(int rowIndex)
	{
		double num = 0.0;
		for (int i = 48; i < 59; i++)
		{
			num += _listClients[rowIndex].DxSpotRate[i];
		}
		return num * 6.0;
	}

	private string GetClientIoType(string type)
	{
		string[] array = type.Split('.');
		return array[array.Length - 1];
	}

	private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		Cursor = Cursors.WaitCursor;
		if (e.RowIndex < 0)
		{
			return;
		}
		string dataPropertyName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
		_ = dataGridView1.Rows[e.RowIndex];
		switch (dataPropertyName)
		{
		case "ConnectTo":
		{
			string clientIoType = GetClientIoType(_listClients[e.RowIndex].GetType().ToString());
			if (clientIoType == "TelnetClient" || clientIoType == "ReverseBeaconClient")
			{
				try
				{
					string ipAddress = _listClients[e.RowIndex].IoCfg.IpAddress;
					string text = _listClients[e.RowIndex].IoCfg.Port.ToString();
					Process.Start("Telnet", ipAddress + " " + text);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Operation error");
				}
			}
			else
			{
				MessageBox.Show("Only telnet connections are allowed.", "Telnet Connection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			break;
		}
		case "Enabled":
		{
			IIoClient ioClient = (IIoClient)_bindingSource[e.RowIndex];
			_arc.DisableClientConnect(ioClient.IoCfg.Id);
			dataGridView1.EndEdit();
			_bindingSource.EndEdit();
			UpdateBindingList();
			break;
		}
		case "IsConnected":
		{
			IIoClient ioClient = (IIoClient)_bindingSource[e.RowIndex];
			_arc.DisconnectClientConnect(ioClient.IoCfg.Id);
			break;
		}
		}
		Cursor = Cursors.Default;
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		UpdateBindingList();
	}

	private void UpdateBindingList()
	{
		BindingList<IIoClient> enabledClients = _arc.GetEnabledClients();
		UpdateConnectUptimes(enabledClients);
		_bindingSource.Clear();
		for (int i = 0; i < enabledClients.Count; i++)
		{
			_bindingSource.Add(enabledClients[i]);
		}
	}

	private void UpdateConnectUptimes(BindingList<IIoClient> listClients)
	{
		int num = 0;
		foreach (IIoClient listClient in listClients)
		{
			listClient.EndPoint = GetUptime(listClient.ConnectDts);
			num++;
		}
	}

	private string GetUptime(DateTime connectDts)
	{
		string result = string.Empty;
		if (connectDts != DateTime.MinValue)
		{
			TimeSpan timeSpan = DateTime.UtcNow - connectDts;
			result = timeSpan.Days + "-" + timeSpan.Hours + ":" + timeSpan.Minutes + ":" + timeSpan.Seconds;
		}
		return result;
	}
}
