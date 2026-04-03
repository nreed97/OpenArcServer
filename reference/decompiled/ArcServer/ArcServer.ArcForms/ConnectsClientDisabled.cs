using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcInterfaces.Io;

namespace ArcServer.ArcForms;

public class ConnectsClientDisabled : Form
{
	private IContainer components;

	private DataGridView dataGridView1;

	private Button btnNewConnectCfg;

	private Button btnExit;

	private ArCluster _arc;

	private BindingList<ClientIoCfg> listInactiveClientCfgs;

	private BindingSource _bindingSource;

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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		this.dataGridView1 = new System.Windows.Forms.DataGridView();
		this.btnNewConnectCfg = new System.Windows.Forms.Button();
		this.btnExit = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
		base.SuspendLayout();
		this.dataGridView1.AllowUserToAddRows = false;
		this.dataGridView1.AllowUserToResizeRows = false;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 255, 192);
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.Black;
		this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(255, 255, 192);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView1.Location = new System.Drawing.Point(0, 0);
		this.dataGridView1.MultiSelect = false;
		this.dataGridView1.Name = "dataGridView1";
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(255, 255, 192);
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
		this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
		this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dataGridView1.Size = new System.Drawing.Size(850, 196);
		this.dataGridView1.TabIndex = 0;
		this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dataGridView1_CellContentClick);
		this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
		this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(dataGridView1_DataError);
		this.btnNewConnectCfg.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.btnNewConnectCfg.Location = new System.Drawing.Point(315, 199);
		this.btnNewConnectCfg.Name = "btnNewConnectCfg";
		this.btnNewConnectCfg.Size = new System.Drawing.Size(108, 23);
		this.btnNewConnectCfg.TabIndex = 7;
		this.btnNewConnectCfg.Text = "New Connect Cfg";
		this.btnNewConnectCfg.UseVisualStyleBackColor = true;
		this.btnNewConnectCfg.Click += new System.EventHandler(btnNewConnectCfg_Click);
		this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.btnExit.Location = new System.Drawing.Point(486, 199);
		this.btnExit.Name = "btnExit";
		this.btnExit.Size = new System.Drawing.Size(90, 23);
		this.btnExit.TabIndex = 8;
		this.btnExit.Text = "Exit";
		this.btnExit.UseVisualStyleBackColor = true;
		this.btnExit.Click += new System.EventHandler(btnExit_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(850, 223);
		base.Controls.Add(this.btnExit);
		base.Controls.Add(this.btnNewConnectCfg);
		base.Controls.Add(this.dataGridView1);
		base.Name = "ConnectsClientDisabled";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Disabled Client Configurations";
		base.Load += new System.EventHandler(CfgClientConnects_Load);
		((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
		base.ResumeLayout(false);
	}

	public ConnectsClientDisabled(ArCluster arc)
	{
		InitializeComponent();
		_arc = arc;
		InitilizeDataGrid();
	}

	private void InitilizeDataGrid()
	{
		dataGridView1.AutoGenerateColumns = false;
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn.HeaderText = "Type";
		dataGridViewTextBoxColumn.Name = "Type";
		dataGridViewTextBoxColumn.DataPropertyName = "Type";
		dataGridViewTextBoxColumn.Width = 125;
		dataGridViewTextBoxColumn.ToolTipText = "Type";
		dataGridViewTextBoxColumn.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn);
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
		dataGridViewLinkColumn.ToolTipText = "Connect To";
		dataGridViewLinkColumn.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewLinkColumn);
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		dataGridViewCheckBoxColumn.HeaderText = "Enable";
		dataGridViewCheckBoxColumn.Name = "Enabled";
		dataGridViewCheckBoxColumn.DataPropertyName = "Enabled";
		dataGridViewCheckBoxColumn.Width = 55;
		dataGridViewCheckBoxColumn.ToolTipText = "Enabled";
		dataGridView1.Columns.Add(dataGridViewCheckBoxColumn);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn2.HeaderText = "ConnectAs";
		dataGridViewTextBoxColumn2.Name = "ConnectAs";
		dataGridViewTextBoxColumn2.DataPropertyName = "ConnectAs";
		dataGridViewTextBoxColumn2.Width = 80;
		dataGridViewTextBoxColumn2.ToolTipText = "ConnectAs";
		dataGridViewTextBoxColumn2.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn2);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn3.HeaderText = "Description";
		dataGridViewTextBoxColumn3.Name = "Description";
		dataGridViewTextBoxColumn3.DataPropertyName = "Description";
		dataGridViewTextBoxColumn3.Width = 188;
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
		dataGridViewTextBoxColumn5.HeaderText = "Port";
		dataGridViewTextBoxColumn5.Name = "Port";
		dataGridViewTextBoxColumn5.DataPropertyName = "Port";
		dataGridViewTextBoxColumn5.Width = 50;
		dataGridViewTextBoxColumn5.ToolTipText = "IpAddress";
		dataGridViewTextBoxColumn5.ReadOnly = true;
		dataGridView1.Columns.Add(dataGridViewTextBoxColumn5);
		DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
		dataGridViewButtonColumn.HeaderText = "Edit\nConfig";
		dataGridViewButtonColumn.Text = "Edit";
		dataGridViewButtonColumn.DataPropertyName = "Edit";
		dataGridViewButtonColumn.Width = 45;
		dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
		dataGridViewButtonColumn.ToolTipText = "Edit client configuration";
		dataGridView1.Columns.Add(dataGridViewButtonColumn);
		DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
		dataGridViewButtonColumn2.HeaderText = "Delete\nConfig";
		dataGridViewButtonColumn2.Text = "Delete";
		dataGridViewButtonColumn2.DataPropertyName = "Delete";
		dataGridViewButtonColumn2.Width = 45;
		dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
		dataGridViewButtonColumn2.ToolTipText = "Delete client configuration";
		dataGridView1.Columns.Add(dataGridViewButtonColumn2);
		for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
		{
			dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
		}
	}

	private void CfgClientConnects_Load(object sender, EventArgs e)
	{
		listInactiveClientCfgs = _arc.GetDisabledClientCfgs();
		_bindingSource = new BindingSource
		{
			DataSource = listInactiveClientCfgs
		};
		dataGridView1.DataSource = _bindingSource;
	}

	private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
		e.ThrowException = false;
	}

	private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.Value != null && e.ColumnIndex == 2)
		{
			e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
		}
	}

	private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		Cursor = Cursors.WaitCursor;
		if (e.RowIndex < 0)
		{
			return;
		}
		string dataPropertyName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
		DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
		switch (dataPropertyName)
		{
		case "ConnectTo":
		{
			string text = dataGridViewRow.Cells["Type"].Value.ToString();
			if (text == "TelnetClient" || text == "ReverseBeaconClient")
			{
				try
				{
					string text2 = dataGridViewRow.Cells["IpAddress"].Value.ToString();
					string text3 = dataGridViewRow.Cells["Port"].Value.ToString();
					Process.Start("Telnet", text2 + " " + text3);
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
			dataGridView1.EndEdit();
			ClientIoCfg clientIoCfg = listInactiveClientCfgs[e.RowIndex];
			_arc.EnableClientConnect(clientIoCfg);
			_bindingSource.EndEdit();
			listInactiveClientCfgs.RemoveAt(e.RowIndex);
			break;
		}
		case "Edit":
		{
			ClientIoCfg clientIoCfg = listInactiveClientCfgs[e.RowIndex];
			ClientConnectCfgEditor clientConnectCfgEditor = new ClientConnectCfgEditor(_arc);
			clientConnectCfgEditor.ClientCfg = clientIoCfg;
			clientConnectCfgEditor.Text = "Edit Client Connect Configuration";
			if (clientConnectCfgEditor.ShowDialog() == DialogResult.OK)
			{
				_arc.UpdateClientConnect(clientConnectCfgEditor.ClientCfg);
				CfgClientConnects_Load(null, null);
			}
			break;
		}
		case "Delete":
		{
			ClientIoCfg clientIoCfg = listInactiveClientCfgs[e.RowIndex];
			_arc.RemoveClientConnect(clientIoCfg.Id);
			_bindingSource.RemoveAt(e.RowIndex);
			break;
		}
		}
		Cursor = Cursors.Default;
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnNewConnectCfg_Click(object sender, EventArgs e)
	{
		ClientConnectCfgEditor clientConnectCfgEditor = new ClientConnectCfgEditor(_arc);
		if (clientConnectCfgEditor.ShowDialog() == DialogResult.OK)
		{
			ClientIoCfg clientCfg = clientConnectCfgEditor.ClientCfg;
			_arc.AddClientIoProviderCfg(clientCfg);
			listInactiveClientCfgs.Add(clientCfg);
		}
	}
}
