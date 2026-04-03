using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcInterfaces.Io;
using ArcServer.Properties;
using WeifenLuo.WinFormsUI.Docking;
using log4net;

namespace ArcServer.ArcForms;

public class InboundConnects : DockContent
{
	private IContainer components;

	private Label label1;

	private ComboBox cboServerConnectFilter;

	private DataGridView dataGridView1;

	private Timer timer1;

	private static readonly ILog _log = LogManager.GetLogger("InboundConnects");

	private ArCluster _arc;

	private BindingSource _bindingSource;

	private BindingList<IIoClient> _listServerClients;

	private Bitmap _greenCheck;

	private Bitmap _nilCheck;

	private string _filter = string.Empty;

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
		this.label1 = new System.Windows.Forms.Label();
		this.cboServerConnectFilter = new System.Windows.Forms.ComboBox();
		this.dataGridView1 = new System.Windows.Forms.DataGridView();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(0, 6);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(37, 13);
		this.label1.TabIndex = 8;
		this.label1.Text = "Select";
		this.cboServerConnectFilter.FormattingEnabled = true;
		this.cboServerConnectFilter.Items.AddRange(new object[7] { "All", "Arc4 Server", "Arc6 Server", "AgwBpq Server", "Pcxx Server", "Telnet Server", "ArxClient" });
		this.cboServerConnectFilter.Location = new System.Drawing.Point(41, 3);
		this.cboServerConnectFilter.Name = "cboServerConnectFilter";
		this.cboServerConnectFilter.Size = new System.Drawing.Size(121, 21);
		this.cboServerConnectFilter.TabIndex = 7;
		this.cboServerConnectFilter.Text = "All";
		this.cboServerConnectFilter.SelectedIndexChanged += new System.EventHandler(cboServerConnectFilter_SelectedIndexChanged);
		this.dataGridView1.AllowUserToAddRows = false;
		this.dataGridView1.AllowUserToDeleteRows = false;
		this.dataGridView1.AllowUserToResizeRows = false;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.Black;
		this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.dataGridView1.Location = new System.Drawing.Point(-1, 29);
		this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
		this.dataGridView1.MultiSelect = false;
		this.dataGridView1.Name = "dataGridView1";
		this.dataGridView1.RowHeadersVisible = false;
		this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
		this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
		this.dataGridView1.RowTemplate.Height = 24;
		this.dataGridView1.Size = new System.Drawing.Size(801, 359);
		this.dataGridView1.TabIndex = 6;
		this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dataGridView1_CellContentClick);
		this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
		this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(dataGridView1_DataError);
		this.timer1.Interval = 5000;
		this.timer1.Tick += new System.EventHandler(timer1_Tick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(797, 382);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.cboServerConnectFilter);
		base.Controls.Add(this.dataGridView1);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Name = "InboundConnects";
		this.Text = "Inbound Connects";
		((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public InboundConnects()
	{
		InitializeComponent();
		_greenCheck = new Bitmap(Resources.GrnCheck);
		_nilCheck = new Bitmap(Resources.NilCheck);
	}

	public void Init(ArCluster arc)
	{
		_arc = arc;
		InitDataGrid();
		_listServerClients = _arc.GetActiveServerClients(_filter);
		_bindingSource = new BindingSource
		{
			DataSource = _listServerClients
		};
		dataGridView1.DataSource = _bindingSource;
		timer1.Enabled = true;
	}

	private void cboServerConnectFilter_SelectedIndexChanged(object sender, EventArgs e)
	{
		switch (cboServerConnectFilter.Text)
		{
		case "Pcxx Server":
			_filter = "PcxxServerClient";
			break;
		case "Telnet Server":
			_filter = "TelnetServerClient";
			break;
		case "Arc6 Server":
			_filter = "ArxServerClient";
			break;
		case "Arc4 Server":
			_filter = "Arc4ServerClient";
			break;
		case "AgwBpq Server":
			_filter = "AgwBpqServerClient";
			break;
		case "ArxClient":
			_filter = "ArxClient";
			break;
		case "All":
			_filter = string.Empty;
			break;
		}
		UpdateBindingList();
	}

	private void InitDataGrid()
	{
		dataGridView1.AutoGenerateColumns = false;
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn.HeaderText = "Type";
		dataGridViewTextBoxColumn.Name = "Type";
		dataGridViewTextBoxColumn.DataPropertyName = "Type";
		dataGridViewTextBoxColumn.Width = 115;
		dataGridViewTextBoxColumn.ToolTipText = "Type";
		dataGridViewTextBoxColumn.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn2.HeaderText = "Call";
		dataGridViewTextBoxColumn2.Name = "Call";
		dataGridViewTextBoxColumn2.DataPropertyName = "Call";
		dataGridViewTextBoxColumn2.Width = 80;
		dataGridViewTextBoxColumn2.ToolTipText = "Call";
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn2);
		DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
		dataGridViewImageColumn.HeaderText = "Connected";
		dataGridViewImageColumn.Name = "Connected";
		dataGridViewImageColumn.DataPropertyName = "Connected";
		dataGridViewImageColumn.Width = 65;
		dataGridViewImageColumn.ToolTipText = "Connected";
		dataGridViewTextBoxColumn2.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewImageColumn);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn3.HeaderText = "Description";
		dataGridViewTextBoxColumn3.Name = "Description";
		dataGridViewTextBoxColumn3.DataPropertyName = "Description";
		dataGridViewTextBoxColumn3.Width = 165;
		dataGridViewTextBoxColumn3.ToolTipText = "Description";
		dataGridViewTextBoxColumn3.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn3);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn4.HeaderText = "IpAddress";
		dataGridViewTextBoxColumn4.Name = "IpAddress";
		dataGridViewTextBoxColumn4.DataPropertyName = "IpAddress";
		dataGridViewTextBoxColumn4.Width = 125;
		dataGridViewTextBoxColumn4.ToolTipText = "IpAddress";
		dataGridViewTextBoxColumn4.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn4);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn5.HeaderText = "DxPerHr";
		dataGridViewTextBoxColumn5.Name = "DxPerHr";
		dataGridViewTextBoxColumn5.DataPropertyName = "DxPerHr";
		dataGridViewTextBoxColumn5.Width = 60;
		dataGridViewTextBoxColumn5.ToolTipText = "DxPerHr";
		dataGridViewTextBoxColumn5.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn5);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn6.HeaderText = "DupesPerHr";
		dataGridViewTextBoxColumn6.Name = "DupesPerHr";
		dataGridViewTextBoxColumn6.DataPropertyName = "DupesPerHr";
		dataGridViewTextBoxColumn6.Width = 75;
		dataGridViewTextBoxColumn6.ToolTipText = "DupesPerHr";
		dataGridViewTextBoxColumn6.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn6);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn7.HeaderText = "UpTime";
		dataGridViewTextBoxColumn7.Name = "UpTime";
		dataGridViewTextBoxColumn7.DataPropertyName = "EndPoint";
		dataGridViewTextBoxColumn7.Width = 75;
		dataGridViewTextBoxColumn7.ToolTipText = "UpTime";
		dataGridViewTextBoxColumn7.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn7);
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
		case 0:
			e.Value = GetClientIoType(_listServerClients[e.RowIndex].GetType().ToString());
			break;
		case 1:
			e.Value = _listServerClients[e.RowIndex].IoCfg.ConnectTo;
			e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
			break;
		case 2:
			e.Value = _greenCheck;
			break;
		case 3:
			e.Value = _listServerClients[e.RowIndex].IoCfg.Description;
			break;
		case 4:
			e.Value = _listServerClients[e.RowIndex].IoCfg.IpAddress;
			break;
		case 5:
			e.Value = GetDxCnt(e.RowIndex);
			break;
		case 6:
			e.Value = _listServerClients[e.RowIndex].LastTenMinuteDxDupeCnt * 6;
			break;
		}
	}

	private double GetDxCnt(int rowIndex)
	{
		double num = 0.0;
		for (int i = 48; i < 59; i++)
		{
			num += _listServerClients[rowIndex].DxSpotRate[i];
		}
		return num * 6.0;
	}

	private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		UpdateBindingList();
	}

	private void UpdateBindingList()
	{
		BindingList<IIoClient> activeServerClients = _arc.GetActiveServerClients(_filter);
		UpdateConnectUptimes(activeServerClients);
		_bindingSource.Clear();
		for (int i = 0; i < activeServerClients.Count; i++)
		{
			_bindingSource.Add(activeServerClients[i]);
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

	private string GetClientIoType(string type)
	{
		string[] array = type.Split('.');
		return array[array.Length - 1];
	}
}
