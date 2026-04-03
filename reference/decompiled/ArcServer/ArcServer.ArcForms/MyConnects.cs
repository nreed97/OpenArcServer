using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcInterfaces.Ui;
using ArcShared.ArcUtils;
using WeifenLuo.WinFormsUI.Docking;
using log4net;

namespace ArcServer.ArcForms;

public class MyConnects : DockContent
{
	private delegate void AddLocalConnecCallback(LocalConnect connect);

	private delegate void DeleteLocalConnectCallback(Guid guid);

	private IContainer components;

	private ImageList imageList1;

	private TreeView treeView1;

	private ContextMenuStrip MenuStrip;

	private ToolStripMenuItem MenuItemCfg;

	private ToolStripMenuItem MenuItemConnection;

	private ToolStripSeparator toolStripMenuItem1;

	private ToolStripMenuItem MenuItemQrzLookup;

	private ToolStripMenuItem MenuItemQthLookup;

	private ToolStripMenuItem MenuItemHamQthLookup;

	private static readonly ILog _log = LogManager.GetLogger("MyConnects");

	private static readonly object _locker = new object();

	private ArCluster _arc;

	private TreeNode _rootNode;

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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcServer.ArcForms.MyConnects));
		this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		this.treeView1 = new System.Windows.Forms.TreeView();
		this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.MenuItemCfg = new System.Windows.Forms.ToolStripMenuItem();
		this.MenuItemConnection = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
		this.MenuItemQrzLookup = new System.Windows.Forms.ToolStripMenuItem();
		this.MenuItemQthLookup = new System.Windows.Forms.ToolStripMenuItem();
		this.MenuItemHamQthLookup = new System.Windows.Forms.ToolStripMenuItem();
		this.MenuStrip.SuspendLayout();
		base.SuspendLayout();
		this.imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
		this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.imageList1.Images.SetKeyName(0, "Arc6NodeIn.png");
		this.imageList1.Images.SetKeyName(1, "Arc6NodeOut.png");
		this.imageList1.Images.SetKeyName(2, "Arc4NodeIn.png");
		this.imageList1.Images.SetKeyName(3, "Arc4NodeOut.png");
		this.imageList1.Images.SetKeyName(4, "PcxxIn.png");
		this.imageList1.Images.SetKeyName(5, "PcxxOut.png");
		this.imageList1.Images.SetKeyName(6, "ArxClientIn.png");
		this.imageList1.Images.SetKeyName(7, "TelnetIn.png");
		this.imageList1.Images.SetKeyName(8, "AgwBpqIn.png");
		this.imageList1.Images.SetKeyName(9, "SpotSuckerOut.png");
		this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.treeView1.HideSelection = false;
		this.treeView1.ImageIndex = 0;
		this.treeView1.ImageList = this.imageList1;
		this.treeView1.Location = new System.Drawing.Point(0, 0);
		this.treeView1.Name = "treeView1";
		this.treeView1.SelectedImageIndex = 0;
		this.treeView1.Size = new System.Drawing.Size(200, 279);
		this.treeView1.TabIndex = 0;
		this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(treeView1_NodeMouseClick);
		this.treeView1.MouseUp += new System.Windows.Forms.MouseEventHandler(treeView1_MouseUp);
		this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.MenuItemCfg, this.MenuItemConnection, this.toolStripMenuItem1, this.MenuItemQrzLookup, this.MenuItemQthLookup, this.MenuItemHamQthLookup });
		this.MenuStrip.Name = "MenuStrip";
		this.MenuStrip.Size = new System.Drawing.Size(165, 142);
		this.MenuItemCfg.Name = "MenuItemCfg";
		this.MenuItemCfg.Size = new System.Drawing.Size(167, 22);
		this.MenuItemCfg.Text = "Configuration";
		this.MenuItemCfg.Click += new System.EventHandler(MenuItemCfg_Click);
		this.MenuItemConnection.Name = "MenuItemConnection";
		this.MenuItemConnection.Size = new System.Drawing.Size(167, 22);
		this.MenuItemConnection.Text = "Connection";
		this.MenuItemConnection.Click += new System.EventHandler(MenuItemConnection_Click);
		this.toolStripMenuItem1.Name = "toolStripMenuItem1";
		this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
		this.MenuItemQrzLookup.Name = "MenuItemQrzLookup";
		this.MenuItemQrzLookup.Size = new System.Drawing.Size(167, 22);
		this.MenuItemQrzLookup.Text = "QRZ  Lookup";
		this.MenuItemQrzLookup.Click += new System.EventHandler(MenuItemQrzLookup_Click);
		this.MenuItemQthLookup.Name = "MenuItemQthLookup";
		this.MenuItemQthLookup.Size = new System.Drawing.Size(167, 22);
		this.MenuItemQthLookup.Text = "QTH Lookup";
		this.MenuItemQthLookup.Click += new System.EventHandler(MenuItemQthLookup_Click);
		this.MenuItemHamQthLookup.Name = "MenuItemHamQthLookup";
		this.MenuItemHamQthLookup.Size = new System.Drawing.Size(164, 22);
		this.MenuItemHamQthLookup.Text = "HamQTH Lookup";
		this.MenuItemHamQthLookup.Click += new System.EventHandler(MenuItemHamQthLookup_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(200, 279);
		base.Controls.Add(this.treeView1);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Name = "MyConnects";
		this.Text = "My Connects";
		base.Load += new System.EventHandler(LocalConnects_Load);
		this.MenuStrip.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public MyConnects(ArCluster arc)
	{
		_arc = arc;
		InitializeComponent();
	}

	private void LocalConnects_Load(object sender, EventArgs e)
	{
		try
		{
			Cursor = Cursors.WaitCursor;
			treeView1.Nodes.Clear();
			treeView1.Indent = 20;
			treeView1.ItemHeight = 20;
			treeView1.BeginUpdate();
			PopulateTreeView();
			treeView1.EndUpdate();
			treeView1.Sort();
			treeView1.Refresh();
			Cursor = Cursors.Default;
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
	}

	private void PopulateTreeView()
	{
		_rootNode = new TreeNode(_arc.Call);
		_rootNode.Tag = _arc.Id;
		_rootNode.ImageIndex = 0;
		_rootNode.SelectedImageIndex = 0;
		_rootNode.ToolTipText = _arc.Id.ToString();
		treeView1.Nodes.Add(_rootNode);
		if (_arc.Call.StartsWith("AB5K"))
		{
			treeView1.ShowNodeToolTips = true;
		}
	}

	public void AddLocalConnectSafe(LocalConnect connect)
	{
		lock (_locker)
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new AddLocalConnecCallback(AddLocalConnectSafe), connect);
				return;
			}
			TreeNode treeNode = new TreeNode(connect.Call);
			treeNode.ImageIndex = (int)connect.Type;
			treeNode.SelectedImageIndex = (int)connect.Type;
			treeNode.Tag = connect.Id;
			treeNode.ToolTipText = connect.Id.ToString();
			_rootNode.Nodes.Add(treeNode);
		}
	}

	public void DeleteLocalConnectSafe(Guid guid)
	{
		lock (_locker)
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new DeleteLocalConnectCallback(DeleteLocalConnectSafe), guid);
				return;
			}
			foreach (TreeNode node in _rootNode.Nodes)
			{
				if (guid == (Guid)node.Tag)
				{
					_rootNode.Nodes.Remove(node);
					break;
				}
			}
		}
	}

	private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		((TreeView)sender).SelectedNode = e.Node;
	}

	private void treeView1_MouseUp(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Right)
		{
			treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);
			if (treeView1.SelectedNode != null)
			{
				MenuStrip.Show(treeView1, e.Location);
			}
		}
	}

	private void MenuItemCfg_Click(object sender, EventArgs e)
	{
		try
		{
			Guid id = (Guid)treeView1.SelectedNode.Tag;
			MyConnectsConfiguration myConnectsConfiguration = new MyConnectsConfiguration(_arc, id);
			myConnectsConfiguration.ShowDialog();
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
	}

	private void MenuItemConnection_Click(object sender, EventArgs e)
	{
		try
		{
			Guid guid = (Guid)treeView1.SelectedNode.Tag;
			MyConnectsIo myConnectsIo = new MyConnectsIo(_arc, guid);
			if (myConnectsIo.ShowDialog() == DialogResult.No)
			{
				DeleteLocalConnectSafe(guid);
			}
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
	}

	private void MenuItemQrzLookup_Click(object sender, EventArgs e)
	{
		string noSsidCall = UtilsCallsign.GetNoSsidCall(treeView1.SelectedNode.Text);
		Process.Start("IExplore.exe", "http://www.qrz.com/db/" + noSsidCall);
	}

	private void MenuItemQthLookup_Click(object sender, EventArgs e)
	{
		string noSsidCall = UtilsCallsign.GetNoSsidCall(treeView1.SelectedNode.Text);
		Process.Start("IExplore.exe", "http://www.qth.com/callsign.php?cs=" + noSsidCall);
	}

	private void MenuItemHamQthLookup_Click(object sender, EventArgs e)
	{
		string noSsidCall = UtilsCallsign.GetNoSsidCall(treeView1.SelectedNode.Text);
		Process.Start("IExplore.exe", "http://www.hamqth.com/" + noSsidCall);
	}
}
