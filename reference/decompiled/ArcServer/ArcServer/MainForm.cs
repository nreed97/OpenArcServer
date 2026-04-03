using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using ArcClientUi;
using ArcEngine;
using ArcInterfaces.Ui;
using ArcServer.ArcForms;
using ArcServer.Properties;
using ArcShared.ArcUtils;
using ArcShared.DxAtlas;
using ArcShared.Forms;
using ArcShared.SplashScreen;
using WeifenLuo.WinFormsUI.Docking;
using log4net;

namespace ArcServer;

public class MainForm : Form, IUi
{
	private IContainer components;

	private ToolStripContainer toolStripContainer1;

	private DockPanel dockPanel;

	private ToolStrip toolStrip2;

	private ToolStripDropDownButton mnuFile;

	private ToolStripMenuItem mnuFileAppLog;

	private ToolStripMenuItem mnuFileAppLogDocked;

	private ToolStripSeparator toolStripMenuItem2;

	private ToolStripMenuItem mnuFileExit;

	private ToolStripDropDownButton mnuConnects;

	private ToolStripMenuItem mnuConnectsMy;

	private ToolStripSeparator toolStripMenuItem4;

	private ToolStripMenuItem mnuConnectsInbound;

	private ToolStripMenuItem mnuConnectsOutbound;

	private ToolStripMenuItem mnuConnectsOutboundDisabled;

	private ToolStripSeparator toolStripMenuItem5;

	private ToolStripMenuItem mnuConnectsMyTelnetServers;

	private ToolStripDropDownButton mnuTools;

	private ToolStripMenuItem mnuToolsSetup;

	private ToolStripDropDownButton mnuTest;

	private ToolStripMenuItem mnuTestTest1;

	private ToolStripMenuItem mnuTestTest2;

	private ToolStripSeparator toolStripMenuItem1;

	private ToolStripMenuItem mnuTestSandbox;

	private ToolStripDropDownButton mnuAnalysis;

	private ToolStripMenuItem mnuAnalysisDxRateGraph;

	private ToolStripDropDownButton mnuHelp;

	private ToolStripMenuItem mnuHelpAb5k;

	private ToolStripSeparator toolStripMenuItem7;

	private ToolStripMenuItem mnuHelpFtpAb5k;

	private ToolStripMenuItem mnuHelpFtpN7od;

	private ToolStripSeparator toolStripMenuItem8;

	private ToolStripMenuItem mnuHelpAbout;

	private ToolStripSeparator toolStripMenuItem6;

	private ToolStripMenuItem mnuToolsCallbookLookup;

	private ToolStripMenuItem mnuConnectsArcClient;

	private ToolStripSeparator toolStripMenuItem9;

	private ToolStripMenuItem mnuHelpDocs;

	private ToolStripSeparator toolStripMenuItem10;

	private ToolStripMenuItem mnuHelpYouTube;

	private ToolStripMenuItem mnuHelpYouTubeOne;

	private ToolStripMenuItem mnuHelpYouTubeTwo;

	private ToolStripMenuItem mnuHelpYouTubeThree;

	private ToolStripSeparator toolStripMenuItem12;

	private ToolStripSeparator toolStripMenuItem11;

	private ToolStripDropDownButton mnuDxAtlas;

	private ToolStripMenuItem mnuDxAtlasConnects;

	private ToolStripSeparator toolStripMenuItem13;

	private ToolStripMenuItem mnuToolsAppLogDiagnosticsTelnetOutboundbound;

	private ToolStripMenuItem mnuToolsAppLogDiagnosticsTelnetInbound;

	private ToolStripMenuItem mnuToolsAppLogDiagnosticsArc6Nodes;

	private ToolStripMenuItem mnuToolsAppLogDiagnosticsArc6Clients;

	private ToolStripMenuItem mnuToolsAppLogDiagnosticsAgwBpq;

	private ToolStripMenuItem mnuToolsAppLogDiagnosticsPcxx;

	private ToolStripMenuItem mnuToolsAppLogDiagnosticsDxDupes;

	private ToolStripMenuItem mnuToolsAppLogDiagnosticsAnnWxDupes;

	private ToolStripMenuItem mnuToolsAppLogDiagnosticsWwvDupes;

	private ToolStripMenuItem mnuToolsAppLogDiagnosticsTelnetOutbound;

	private DxAtlasWrapper _dxAtlas;

	private static readonly ILog _log = LogManager.GetLogger("MainForm");

	private ArCluster _arc;

	private MyConnects _localConnects;

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
		WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
		WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
		WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
		WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient = new WeifenLuo.WinFormsUI.Docking.TabGradient();
		WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
		WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
		WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
		WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
		WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
		WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
		WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
		WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
		WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
		WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
		WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcServer.MainForm));
		this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
		this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
		this.toolStrip2 = new System.Windows.Forms.ToolStrip();
		this.mnuFile = new System.Windows.Forms.ToolStripDropDownButton();
		this.mnuFileAppLog = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuFileAppLogDocked = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
		this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuConnects = new System.Windows.Forms.ToolStripDropDownButton();
		this.mnuConnectsMy = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
		this.mnuConnectsInbound = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuConnectsOutbound = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuConnectsOutboundDisabled = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
		this.mnuConnectsArcClient = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
		this.mnuConnectsMyTelnetServers = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuTools = new System.Windows.Forms.ToolStripDropDownButton();
		this.mnuToolsSetup = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
		this.mnuToolsCallbookLookup = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
		this.mnuToolsAppLogDiagnosticsTelnetOutboundbound = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuToolsAppLogDiagnosticsTelnetInbound = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuToolsAppLogDiagnosticsTelnetOutbound = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuToolsAppLogDiagnosticsArc6Nodes = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuToolsAppLogDiagnosticsArc6Clients = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuToolsAppLogDiagnosticsPcxx = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuToolsAppLogDiagnosticsAgwBpq = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuToolsAppLogDiagnosticsDxDupes = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuToolsAppLogDiagnosticsAnnWxDupes = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuToolsAppLogDiagnosticsWwvDupes = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuTest = new System.Windows.Forms.ToolStripDropDownButton();
		this.mnuTestTest1 = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuTestTest2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
		this.mnuTestSandbox = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuAnalysis = new System.Windows.Forms.ToolStripDropDownButton();
		this.mnuAnalysisDxRateGraph = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuDxAtlas = new System.Windows.Forms.ToolStripDropDownButton();
		this.mnuDxAtlasConnects = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuHelp = new System.Windows.Forms.ToolStripDropDownButton();
		this.mnuHelpDocs = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
		this.mnuHelpAb5k = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
		this.mnuHelpFtpAb5k = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuHelpFtpN7od = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
		this.mnuHelpYouTube = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuHelpYouTubeOne = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuHelpYouTubeTwo = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuHelpYouTubeThree = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
		this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
		this.toolStripContainer1.ContentPanel.SuspendLayout();
		this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
		this.toolStripContainer1.SuspendLayout();
		this.toolStrip2.SuspendLayout();
		base.SuspendLayout();
		this.toolStripContainer1.ContentPanel.Controls.Add(this.dockPanel);
		this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1444, 360);
		this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
		this.toolStripContainer1.Name = "toolStripContainer1";
		this.toolStripContainer1.Size = new System.Drawing.Size(1444, 385);
		this.toolStripContainer1.TabIndex = 15;
		this.toolStripContainer1.Text = "toolStripContainer1";
		this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
		this.dockPanel.ActiveAutoHideContent = null;
		this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dockPanel.DockBackColor = System.Drawing.SystemColors.AppWorkspace;
		this.dockPanel.DockBottomPortion = 150.0;
		this.dockPanel.DockLeftPortion = 200.0;
		this.dockPanel.DockRightPortion = 200.0;
		this.dockPanel.DockTopPortion = 150.0;
		this.dockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
		this.dockPanel.Location = new System.Drawing.Point(0, 0);
		this.dockPanel.Name = "dockPanel";
		this.dockPanel.Size = new System.Drawing.Size(1444, 360);
		dockPanelGradient.EndColor = System.Drawing.SystemColors.ControlLight;
		dockPanelGradient.StartColor = System.Drawing.SystemColors.ControlLight;
		autoHideStripSkin.DockStripGradient = dockPanelGradient;
		tabGradient.EndColor = System.Drawing.SystemColors.Control;
		tabGradient.StartColor = System.Drawing.SystemColors.Control;
		tabGradient.TextColor = System.Drawing.SystemColors.ControlDarkDark;
		autoHideStripSkin.TabGradient = tabGradient;
		autoHideStripSkin.TextFont = new System.Drawing.Font("Tahoma", 8.25f);
		dockPanelSkin.AutoHideStripSkin = autoHideStripSkin;
		tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
		tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
		tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
		dockPaneStripGradient.ActiveTabGradient = tabGradient2;
		dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
		dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
		dockPaneStripGradient.DockStripGradient = dockPanelGradient2;
		tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
		tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
		tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
		dockPaneStripGradient.InactiveTabGradient = tabGradient3;
		dockPaneStripSkin.DocumentGradient = dockPaneStripGradient;
		dockPaneStripSkin.TextFont = new System.Drawing.Font("Tahoma", 8.25f);
		tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
		tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
		tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
		tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
		dockPaneStripToolWindowGradient.ActiveCaptionGradient = tabGradient4;
		tabGradient5.EndColor = System.Drawing.SystemColors.Control;
		tabGradient5.StartColor = System.Drawing.SystemColors.Control;
		tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
		dockPaneStripToolWindowGradient.ActiveTabGradient = tabGradient5;
		dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
		dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
		dockPaneStripToolWindowGradient.DockStripGradient = dockPanelGradient3;
		tabGradient6.EndColor = System.Drawing.SystemColors.InactiveCaption;
		tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
		tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
		tabGradient6.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
		dockPaneStripToolWindowGradient.InactiveCaptionGradient = tabGradient6;
		tabGradient7.EndColor = System.Drawing.Color.Transparent;
		tabGradient7.StartColor = System.Drawing.Color.Transparent;
		tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
		dockPaneStripToolWindowGradient.InactiveTabGradient = tabGradient7;
		dockPaneStripSkin.ToolWindowGradient = dockPaneStripToolWindowGradient;
		dockPanelSkin.DockPaneStripSkin = dockPaneStripSkin;
		this.dockPanel.Skin = dockPanelSkin;
		this.dockPanel.TabIndex = 17;
		this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
		this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.mnuFile, this.mnuConnects, this.mnuTools, this.mnuTest, this.mnuAnalysis, this.mnuDxAtlas, this.mnuHelp });
		this.toolStrip2.Location = new System.Drawing.Point(3, 0);
		this.toolStrip2.Name = "toolStrip2";
		this.toolStrip2.Size = new System.Drawing.Size(469, 25);
		this.toolStrip2.TabIndex = 0;
		this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.mnuFileAppLog, this.mnuFileAppLogDocked, this.toolStripMenuItem2, this.mnuFileExit });
		this.mnuFile.Image = (System.Drawing.Image)resources.GetObject("mnuFile.Image");
		this.mnuFile.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mnuFile.Name = "mnuFile";
		this.mnuFile.Size = new System.Drawing.Size(52, 22);
		this.mnuFile.Text = "File";
		this.mnuFileAppLog.Name = "mnuFileAppLog";
		this.mnuFileAppLog.Size = new System.Drawing.Size(170, 22);
		this.mnuFileAppLog.Text = "App Log";
		this.mnuFileAppLog.Click += new System.EventHandler(mnuFileAppLog_Click);
		this.mnuFileAppLogDocked.Name = "mnuFileAppLogDocked";
		this.mnuFileAppLogDocked.Size = new System.Drawing.Size(170, 22);
		this.mnuFileAppLogDocked.Text = "App Log (Docked)";
		this.mnuFileAppLogDocked.Click += new System.EventHandler(mnuFileAppLogDocked_Click);
		this.toolStripMenuItem2.Name = "toolStripMenuItem2";
		this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 6);
		this.mnuFileExit.Name = "mnuFileExit";
		this.mnuFileExit.Size = new System.Drawing.Size(170, 22);
		this.mnuFileExit.Text = "Exit";
		this.mnuFileExit.Click += new System.EventHandler(mnuFileExit_Click);
		this.mnuConnects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[9] { this.mnuConnectsMy, this.toolStripMenuItem4, this.mnuConnectsInbound, this.mnuConnectsOutbound, this.mnuConnectsOutboundDisabled, this.toolStripMenuItem5, this.mnuConnectsArcClient, this.toolStripMenuItem9, this.mnuConnectsMyTelnetServers });
		this.mnuConnects.Image = (System.Drawing.Image)resources.GetObject("mnuConnects.Image");
		this.mnuConnects.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mnuConnects.Name = "mnuConnects";
		this.mnuConnects.Size = new System.Drawing.Size(81, 22);
		this.mnuConnects.Text = "Connects";
		this.mnuConnectsMy.Name = "mnuConnectsMy";
		this.mnuConnectsMy.Size = new System.Drawing.Size(189, 22);
		this.mnuConnectsMy.Text = "My Connects";
		this.mnuConnectsMy.Click += new System.EventHandler(mnuConnectsMy_Click);
		this.toolStripMenuItem4.Name = "toolStripMenuItem4";
		this.toolStripMenuItem4.Size = new System.Drawing.Size(186, 6);
		this.mnuConnectsInbound.Name = "mnuConnectsInbound";
		this.mnuConnectsInbound.Size = new System.Drawing.Size(189, 22);
		this.mnuConnectsInbound.Text = "Inbound";
		this.mnuConnectsInbound.Click += new System.EventHandler(mnuConnectsInbound_Click);
		this.mnuConnectsOutbound.Name = "mnuConnectsOutbound";
		this.mnuConnectsOutbound.Size = new System.Drawing.Size(189, 22);
		this.mnuConnectsOutbound.Text = "Outbound";
		this.mnuConnectsOutbound.Click += new System.EventHandler(mnuConnectsOutbound_Click);
		this.mnuConnectsOutboundDisabled.Name = "mnuConnectsOutboundDisabled";
		this.mnuConnectsOutboundDisabled.Size = new System.Drawing.Size(189, 22);
		this.mnuConnectsOutboundDisabled.Text = "Outbound (Disabled)";
		this.mnuConnectsOutboundDisabled.Click += new System.EventHandler(mnuConnectsOutboundDisabled_Click);
		this.toolStripMenuItem5.Name = "toolStripMenuItem5";
		this.toolStripMenuItem5.Size = new System.Drawing.Size(186, 6);
		this.mnuConnectsArcClient.Name = "mnuConnectsArcClient";
		this.mnuConnectsArcClient.Size = new System.Drawing.Size(189, 22);
		this.mnuConnectsArcClient.Text = "AR-Cluster Client App";
		this.mnuConnectsArcClient.Click += new System.EventHandler(mnuConnectsArcClient_Click);
		this.toolStripMenuItem9.Name = "toolStripMenuItem9";
		this.toolStripMenuItem9.Size = new System.Drawing.Size(186, 6);
		this.mnuConnectsMyTelnetServers.Name = "mnuConnectsMyTelnetServers";
		this.mnuConnectsMyTelnetServers.Size = new System.Drawing.Size(189, 22);
		this.mnuConnectsMyTelnetServers.Text = "My Telnet Servers";
		this.mnuConnectsMyTelnetServers.Click += new System.EventHandler(mnuConnectsMyTelnetServers_Click);
		this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.mnuToolsSetup, this.toolStripMenuItem6, this.mnuToolsCallbookLookup, this.toolStripMenuItem13, this.mnuToolsAppLogDiagnosticsTelnetOutboundbound });
		this.mnuTools.Image = (System.Drawing.Image)resources.GetObject("mnuTools.Image");
		this.mnuTools.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mnuTools.Name = "mnuTools";
		this.mnuTools.Size = new System.Drawing.Size(61, 22);
		this.mnuTools.Text = "Tools";
		this.mnuToolsSetup.Name = "mnuToolsSetup";
		this.mnuToolsSetup.Size = new System.Drawing.Size(181, 22);
		this.mnuToolsSetup.Text = "Setup";
		this.mnuToolsSetup.Click += new System.EventHandler(mnuToolsSetup_Click);
		this.toolStripMenuItem6.Name = "toolStripMenuItem6";
		this.toolStripMenuItem6.Size = new System.Drawing.Size(178, 6);
		this.mnuToolsCallbookLookup.Name = "mnuToolsCallbookLookup";
		this.mnuToolsCallbookLookup.Size = new System.Drawing.Size(181, 22);
		this.mnuToolsCallbookLookup.Text = "Callbook Lookup";
		this.mnuToolsCallbookLookup.Click += new System.EventHandler(mnuToolsCallbookLookup_Click);
		this.toolStripMenuItem13.Name = "toolStripMenuItem13";
		this.toolStripMenuItem13.Size = new System.Drawing.Size(178, 6);
		this.mnuToolsAppLogDiagnosticsTelnetOutboundbound.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[9] { this.mnuToolsAppLogDiagnosticsTelnetInbound, this.mnuToolsAppLogDiagnosticsTelnetOutbound, this.mnuToolsAppLogDiagnosticsArc6Nodes, this.mnuToolsAppLogDiagnosticsArc6Clients, this.mnuToolsAppLogDiagnosticsPcxx, this.mnuToolsAppLogDiagnosticsAgwBpq, this.mnuToolsAppLogDiagnosticsDxDupes, this.mnuToolsAppLogDiagnosticsAnnWxDupes, this.mnuToolsAppLogDiagnosticsWwvDupes });
		this.mnuToolsAppLogDiagnosticsTelnetOutboundbound.Name = "mnuToolsAppLogDiagnosticsTelnetOutboundbound";
		this.mnuToolsAppLogDiagnosticsTelnetOutboundbound.Size = new System.Drawing.Size(181, 22);
		this.mnuToolsAppLogDiagnosticsTelnetOutboundbound.Text = "App Log Diagnostics";
		this.mnuToolsAppLogDiagnosticsTelnetInbound.Name = "mnuToolsAppLogDiagnosticsTelnetInbound";
		this.mnuToolsAppLogDiagnosticsTelnetInbound.Size = new System.Drawing.Size(186, 22);
		this.mnuToolsAppLogDiagnosticsTelnetInbound.Text = "Log Inbound Telnet";
		this.mnuToolsAppLogDiagnosticsTelnetInbound.Click += new System.EventHandler(mnuToolsAppLogDiagnosticsTelnetInbound_Click);
		this.mnuToolsAppLogDiagnosticsTelnetOutbound.Name = "mnuToolsAppLogDiagnosticsTelnetOutbound";
		this.mnuToolsAppLogDiagnosticsTelnetOutbound.Size = new System.Drawing.Size(186, 22);
		this.mnuToolsAppLogDiagnosticsTelnetOutbound.Text = "Log Outbound Telnet";
		this.mnuToolsAppLogDiagnosticsTelnetOutbound.Click += new System.EventHandler(mnuToolsAppLogDiagnosticsTelnetOutbound_Click);
		this.mnuToolsAppLogDiagnosticsArc6Nodes.Name = "mnuToolsAppLogDiagnosticsArc6Nodes";
		this.mnuToolsAppLogDiagnosticsArc6Nodes.Size = new System.Drawing.Size(186, 22);
		this.mnuToolsAppLogDiagnosticsArc6Nodes.Text = "Log Arc6 Nodes";
		this.mnuToolsAppLogDiagnosticsArc6Nodes.Click += new System.EventHandler(mnuToolsAppLogDiagnosticsArc6Nodes_Click);
		this.mnuToolsAppLogDiagnosticsArc6Clients.Name = "mnuToolsAppLogDiagnosticsArc6Clients";
		this.mnuToolsAppLogDiagnosticsArc6Clients.Size = new System.Drawing.Size(186, 22);
		this.mnuToolsAppLogDiagnosticsArc6Clients.Text = "Log Arc6 Clients";
		this.mnuToolsAppLogDiagnosticsArc6Clients.Click += new System.EventHandler(mnuToolsAppLogDiagnosticsArc6Clients_Click);
		this.mnuToolsAppLogDiagnosticsPcxx.Name = "mnuToolsAppLogDiagnosticsPcxx";
		this.mnuToolsAppLogDiagnosticsPcxx.Size = new System.Drawing.Size(186, 22);
		this.mnuToolsAppLogDiagnosticsPcxx.Text = "Log PCxx";
		this.mnuToolsAppLogDiagnosticsPcxx.Click += new System.EventHandler(mnuToolsAppLogDiagnosticsPcxx_Click);
		this.mnuToolsAppLogDiagnosticsAgwBpq.Name = "mnuToolsAppLogDiagnosticsAgwBpq";
		this.mnuToolsAppLogDiagnosticsAgwBpq.Size = new System.Drawing.Size(186, 22);
		this.mnuToolsAppLogDiagnosticsAgwBpq.Text = "Log AGW/BPQ";
		this.mnuToolsAppLogDiagnosticsAgwBpq.Click += new System.EventHandler(mnuToolsAppLogDiagnosticsAgwBpq_Click);
		this.mnuToolsAppLogDiagnosticsDxDupes.Name = "mnuToolsAppLogDiagnosticsDxDupes";
		this.mnuToolsAppLogDiagnosticsDxDupes.Size = new System.Drawing.Size(186, 22);
		this.mnuToolsAppLogDiagnosticsDxDupes.Text = "Log DX Dupes";
		this.mnuToolsAppLogDiagnosticsDxDupes.Click += new System.EventHandler(mnuToolsAppLogDiagnosticsDxDupes_Click);
		this.mnuToolsAppLogDiagnosticsAnnWxDupes.Name = "mnuToolsAppLogDiagnosticsAnnWxDupes";
		this.mnuToolsAppLogDiagnosticsAnnWxDupes.Size = new System.Drawing.Size(186, 22);
		this.mnuToolsAppLogDiagnosticsAnnWxDupes.Text = "Log Ann/WX Dupes";
		this.mnuToolsAppLogDiagnosticsAnnWxDupes.Click += new System.EventHandler(mnuToolsAppLogDiagnosticsAnnWxDupes_Click);
		this.mnuToolsAppLogDiagnosticsWwvDupes.Name = "mnuToolsAppLogDiagnosticsWwvDupes";
		this.mnuToolsAppLogDiagnosticsWwvDupes.Size = new System.Drawing.Size(186, 22);
		this.mnuToolsAppLogDiagnosticsWwvDupes.Text = "Log WWV Dupes";
		this.mnuToolsAppLogDiagnosticsWwvDupes.Click += new System.EventHandler(mnuToolsAppLogDiagnosticsWwvDupes_Click);
		this.mnuTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.mnuTestTest1, this.mnuTestTest2, this.toolStripMenuItem1, this.mnuTestSandbox });
		this.mnuTest.Image = ArcServer.Properties.Resources.Check2;
		this.mnuTest.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mnuTest.Name = "mnuTest";
		this.mnuTest.Size = new System.Drawing.Size(57, 22);
		this.mnuTest.Text = "Test";
		this.mnuTestTest1.Name = "mnuTestTest1";
		this.mnuTestTest1.Size = new System.Drawing.Size(127, 22);
		this.mnuTestTest1.Text = "Test1";
		this.mnuTestTest1.Click += new System.EventHandler(mnuTestTest1_Click);
		this.mnuTestTest2.Name = "mnuTestTest2";
		this.mnuTestTest2.Size = new System.Drawing.Size(127, 22);
		this.mnuTestTest2.Text = "Test2";
		this.mnuTestTest2.Click += new System.EventHandler(mnuTestTest2_Click);
		this.toolStripMenuItem1.Name = "toolStripMenuItem1";
		this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 6);
		this.mnuTestSandbox.Name = "mnuTestSandbox";
		this.mnuTestSandbox.Size = new System.Drawing.Size(127, 22);
		this.mnuTestSandbox.Text = "Sandbox";
		this.mnuTestSandbox.Click += new System.EventHandler(mnuTestSandbox_Click);
		this.mnuAnalysis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.mnuAnalysisDxRateGraph });
		this.mnuAnalysis.Image = (System.Drawing.Image)resources.GetObject("mnuAnalysis.Image");
		this.mnuAnalysis.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mnuAnalysis.Name = "mnuAnalysis";
		this.mnuAnalysis.Size = new System.Drawing.Size(75, 22);
		this.mnuAnalysis.Text = "Analysis";
		this.mnuAnalysisDxRateGraph.Name = "mnuAnalysisDxRateGraph";
		this.mnuAnalysisDxRateGraph.Size = new System.Drawing.Size(181, 22);
		this.mnuAnalysisDxRateGraph.Text = "DX Spot Rate Graph";
		this.mnuAnalysisDxRateGraph.Click += new System.EventHandler(mnuAnalysisDxRateGraph_Click);
		this.mnuDxAtlas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.mnuDxAtlasConnects });
		this.mnuDxAtlas.Image = (System.Drawing.Image)resources.GetObject("mnuDxAtlas.Image");
		this.mnuDxAtlas.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mnuDxAtlas.Name = "mnuDxAtlas";
		this.mnuDxAtlas.Size = new System.Drawing.Size(76, 22);
		this.mnuDxAtlas.Text = "DX Atlas";
		this.mnuDxAtlasConnects.Name = "mnuDxAtlasConnects";
		this.mnuDxAtlasConnects.Size = new System.Drawing.Size(130, 22);
		this.mnuDxAtlasConnects.Text = "Connects";
		this.mnuDxAtlasConnects.Click += new System.EventHandler(mnuDxAtlasConnects_Click);
		this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[11]
		{
			this.mnuHelpDocs, this.toolStripMenuItem10, this.mnuHelpAb5k, this.toolStripMenuItem7, this.mnuHelpFtpAb5k, this.mnuHelpFtpN7od, this.toolStripMenuItem8, this.mnuHelpYouTube, this.toolStripMenuItem12, this.mnuHelpAbout,
			this.toolStripMenuItem11
		});
		this.mnuHelp.Image = (System.Drawing.Image)resources.GetObject("mnuHelp.Image");
		this.mnuHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mnuHelp.Name = "mnuHelp";
		this.mnuHelp.Size = new System.Drawing.Size(57, 22);
		this.mnuHelp.Text = "Help";
		this.mnuHelpDocs.Name = "mnuHelpDocs";
		this.mnuHelpDocs.Size = new System.Drawing.Size(159, 22);
		this.mnuHelpDocs.Text = "Docs";
		this.mnuHelpDocs.Click += new System.EventHandler(mnuHelpDocs_Click);
		this.toolStripMenuItem10.Name = "toolStripMenuItem10";
		this.toolStripMenuItem10.Size = new System.Drawing.Size(156, 6);
		this.mnuHelpAb5k.Name = "mnuHelpAb5k";
		this.mnuHelpAb5k.Size = new System.Drawing.Size(159, 22);
		this.mnuHelpAb5k.Text = "www.ab5k.net";
		this.mnuHelpAb5k.Click += new System.EventHandler(mnuHelpAb5k_Click);
		this.toolStripMenuItem7.Name = "toolStripMenuItem7";
		this.toolStripMenuItem7.Size = new System.Drawing.Size(156, 6);
		this.mnuHelpFtpAb5k.Name = "mnuHelpFtpAb5k";
		this.mnuHelpFtpAb5k.Size = new System.Drawing.Size(159, 22);
		this.mnuHelpFtpAb5k.Text = "ftp.ab5k.net";
		this.mnuHelpFtpAb5k.Click += new System.EventHandler(mnuHelpFtpAb5k_Click);
		this.mnuHelpFtpN7od.Name = "mnuHelpFtpN7od";
		this.mnuHelpFtpN7od.Size = new System.Drawing.Size(159, 22);
		this.mnuHelpFtpN7od.Text = "ftp.n7od.net";
		this.mnuHelpFtpN7od.Click += new System.EventHandler(mnuHelpFtpN7od_Click);
		this.toolStripMenuItem8.Name = "toolStripMenuItem8";
		this.toolStripMenuItem8.Size = new System.Drawing.Size(156, 6);
		this.mnuHelpYouTube.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.mnuHelpYouTubeOne, this.mnuHelpYouTubeTwo, this.mnuHelpYouTubeThree });
		this.mnuHelpYouTube.Name = "mnuHelpYouTube";
		this.mnuHelpYouTube.Size = new System.Drawing.Size(159, 22);
		this.mnuHelpYouTube.Text = "You Tube Video";
		this.mnuHelpYouTubeOne.Name = "mnuHelpYouTubeOne";
		this.mnuHelpYouTubeOne.Size = new System.Drawing.Size(150, 22);
		this.mnuHelpYouTubeOne.Text = "AR-Server I";
		this.mnuHelpYouTubeOne.Click += new System.EventHandler(mnuHelpYouTubeOne_Click);
		this.mnuHelpYouTubeTwo.Name = "mnuHelpYouTubeTwo";
		this.mnuHelpYouTubeTwo.Size = new System.Drawing.Size(150, 22);
		this.mnuHelpYouTubeTwo.Text = "AR-Server II";
		this.mnuHelpYouTubeTwo.Click += new System.EventHandler(mnuHelpYouTubeTwo_Click);
		this.mnuHelpYouTubeThree.Name = "mnuHelpYouTubeThree";
		this.mnuHelpYouTubeThree.Size = new System.Drawing.Size(150, 22);
		this.mnuHelpYouTubeThree.Text = "AR-Server III";
		this.mnuHelpYouTubeThree.Click += new System.EventHandler(mnuHelpYouTubeThree_Click);
		this.toolStripMenuItem12.Name = "toolStripMenuItem12";
		this.toolStripMenuItem12.Size = new System.Drawing.Size(156, 6);
		this.mnuHelpAbout.Name = "mnuHelpAbout";
		this.mnuHelpAbout.Size = new System.Drawing.Size(159, 22);
		this.mnuHelpAbout.Text = "About";
		this.mnuHelpAbout.Click += new System.EventHandler(mnuHelpAbout_Click);
		this.toolStripMenuItem11.Name = "toolStripMenuItem11";
		this.toolStripMenuItem11.Size = new System.Drawing.Size(156, 6);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1444, 385);
		base.Controls.Add(this.toolStripContainer1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(2);
		base.Name = "MainForm";
		this.Text = "AR-Cluster Server";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Main_FormClosing);
		base.Load += new System.EventHandler(Form1_Load);
		this.toolStripContainer1.ContentPanel.ResumeLayout(false);
		this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
		this.toolStripContainer1.TopToolStripPanel.PerformLayout();
		this.toolStripContainer1.ResumeLayout(false);
		this.toolStripContainer1.PerformLayout();
		this.toolStrip2.ResumeLayout(false);
		this.toolStrip2.PerformLayout();
		base.ResumeLayout(false);
	}

	public MainForm()
	{
		InitializeComponent();
		Thread.CurrentThread.Name = "ArCluster_UI";
		Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
		Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
		SplashScreen.ShowSplashScreen(isServer: true);
		Application.DoEvents();
		try
		{
			_arc = ArCluster.Instance;
			_arc.Ui = this;
		}
		catch (Exception ex)
		{
			_log.Fatal(ex.Message);
		}
		SplashScreen.CloseForm();
		Thread.Sleep(1000);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (!UtilsValidation.LicenseFilePresent())
		{
			MessageBox.Show("The AR-Cluster license file was not found.  Please copy the license file into the application folder.  Restart when done.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Close();
		}
		Text = Text + " - " + _arc.Call;
		if (!UtilsValidation.CurrentCallbookPresent())
		{
			MessageBox.Show("The FCC/VE callsign databases not found.  Node processing will continue but features that depend on callbook lookups will not function until the databases are on-line.  The FCC/VE callsign databases will be automatically downloaded and processed and placed on-line in a few minutes.", "FCC/VE Callsign Databases", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			_arc.StartFccVeCallsignUpdate();
		}
		AddTelnetServersToMenu();
		mnuTest.Visible = _arc.Call.StartsWith("AB5K");
		mnuConnectsMy_Click(null, null);
		_arc.InitIoDevices();
	}

	private void Main_FormClosing(object sender, FormClosingEventArgs e)
	{
		Cursor = Cursors.WaitCursor;
		if (_arc != null)
		{
			_arc.ShutDown();
		}
		Cursor = Cursors.Default;
	}

	private void AddTelnetServersToMenu()
	{
		List<string> telnetServerPorts = _arc.GetTelnetServerPorts();
		if (telnetServerPorts == null)
		{
			return;
		}
		foreach (string item in telnetServerPorts)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem.Text = item;
			toolStripMenuItem.Tag = item;
			toolStripMenuItem.Click += TelnetServerMenuItem_Click;
			mnuConnectsMyTelnetServers.DropDownItems.Add(toolStripMenuItem);
		}
	}

	private bool WindowAlreadyCreated(Type type)
	{
		foreach (IDockContent content in dockPanel.Contents)
		{
			if (content.GetType() == type)
			{
				content.DockHandler.Activate();
				return true;
			}
		}
		return false;
	}

	private void TelnetServerMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("Telnet", "localhost " + ((ToolStripMenuItem)sender).Tag);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Operation error");
		}
	}

	private void mnuFileExit_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void mnuFileAppLog_Click(object sender, EventArgs e)
	{
		try
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string directoryName = Path.GetDirectoryName(executingAssembly.Location);
			Process.Start(directoryName + "\\Utils\\BareTail.exe", "Logs\\ArcServer.log");
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
	}

	private void mnuFileAppLogDocked_Click(object sender, EventArgs e)
	{
		if (!WindowAlreadyCreated(typeof(AppLog)))
		{
			AppLog appLog = new AppLog();
			appLog.Show(dockPanel);
		}
	}

	private void mnuConnectsMy_Click(object sender, EventArgs e)
	{
		if (!WindowAlreadyCreated(typeof(MyConnects)))
		{
			_localConnects = new MyConnects(_arc);
			_localConnects.Show(dockPanel, DockState.DockLeft);
		}
		if (!WindowAlreadyCreated(typeof(Health)))
		{
			Health health = new Health();
			health.Show(dockPanel, DockState.DockRightAutoHide);
		}
	}

	private void mnuConnectsInbound_Click(object sender, EventArgs e)
	{
		if (!WindowAlreadyCreated(typeof(InboundConnects)))
		{
			InboundConnects inboundConnects = new InboundConnects();
			inboundConnects.Init(_arc);
			inboundConnects.Show(dockPanel);
		}
	}

	private void mnuConnectsOutbound_Click(object sender, EventArgs e)
	{
		if (!WindowAlreadyCreated(typeof(OutboundConnects)))
		{
			OutboundConnects outboundConnects = new OutboundConnects();
			outboundConnects.Init(_arc);
			outboundConnects.Show(dockPanel);
		}
	}

	private void mnuConnectsOutboundDisabled_Click(object sender, EventArgs e)
	{
		ConnectsClientDisabled connectsClientDisabled = new ConnectsClientDisabled(_arc);
		connectsClientDisabled.Show();
	}

	private void mnuConnectsMyTelnetServers_Click(object sender, EventArgs e)
	{
	}

	private void mnuToolsSetup_Click(object sender, EventArgs e)
	{
		ArcServerSetup arcServerSetup = new ArcServerSetup();
		arcServerSetup.ArcServerCfg = _arc.GetArcServerCfg();
		arcServerSetup.ShowDialog();
	}

	private void mnuToolsCallbookLookup_Click(object sender, EventArgs e)
	{
		FrmUsVeCallbookSearch frmUsVeCallbookSearch = new FrmUsVeCallbookSearch();
		frmUsVeCallbookSearch.Arc = _arc;
		FrmUsVeCallbookSearch frmUsVeCallbookSearch2 = frmUsVeCallbookSearch;
		frmUsVeCallbookSearch2.Show();
	}

	private void mnuTestTest1_Click(object sender, EventArgs e)
	{
		_arc.Test1();
	}

	private void mnuTestTest2_Click(object sender, EventArgs e)
	{
		_arc.Test2();
	}

	private void mnuTestSandbox_Click(object sender, EventArgs e)
	{
		SandBox sandBox = new SandBox();
		sandBox.Init(_arc);
		sandBox.Text = "Sand Box";
		sandBox.Show(dockPanel);
	}

	private void mnuAnalysisDxRateGraph_Click(object sender, EventArgs e)
	{
		DxSpotRateGraph dxSpotRateGraph = new DxSpotRateGraph(_arc);
		dxSpotRateGraph.Show();
	}

	private void mnuHelpAb5k_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("IExplore.exe", "http://www.ab5k.net");
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
	}

	private void mnuHelpFtpAb5k_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("IExplore.exe", "ftp://www.ab5k.net");
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
	}

	private void mnuHelpFtpN7od_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("IExplore.exe", "ftp://n7od.pentux.net/");
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
	}

	private void mnuHelpAbout_Click(object sender, EventArgs e)
	{
		HelpAboutServer helpAboutServer = new HelpAboutServer();
		helpAboutServer.Init(_arc.Call, UtilsVersion.LongVersionAndBits);
		helpAboutServer.ShowDialog();
	}

	public void AddLocalConnect(LocalConnect connect)
	{
		if (_localConnects != null)
		{
			_localConnects.AddLocalConnectSafe(connect);
		}
	}

	public void DeleteLocalConnect(Guid guid)
	{
		if (_localConnects != null)
		{
			_localConnects.DeleteLocalConnectSafe(guid);
		}
	}

	private void mnuConnectsArcClient_Click(object sender, EventArgs e)
	{
		try
		{
			ArcClientMain arcClientMain = new ArcClientMain();
			arcClientMain.CheckCall(_arc.Call);
			arcClientMain.Connect = "Localhost";
			arcClientMain.DisableLogViewing();
			arcClientMain.Show(dockPanel);
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
	}

	private void mnuHelpDocs_Click(object sender, EventArgs e)
	{
		try
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string directoryName = Path.GetDirectoryName(executingAssembly.Location);
			Process.Start(directoryName + "\\Cfg\\Docs\\AR-ClusterServer.docx");
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
	}

	private void mnuHelpYouTubeOne_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("IExplore.exe", "http://www.youtube.com/watch?v=rTUi4LMHvs0");
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
	}

	private void mnuHelpYouTubeTwo_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("IExplore.exe", "http://www.youtube.com/watch?v=WipJUGmXASs");
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
	}

	private void mnuHelpYouTubeThree_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("IExplore.exe", "http://www.youtube.com/watch?v=oXhyA66hgZ0");
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
	}

	private void mnuDxAtlasConnects_Click(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("DxAtlas");
		foreach (Process process in processesByName)
		{
			try
			{
				process.Kill();
				process.WaitForExit();
			}
			catch (Win32Exception)
			{
			}
			catch (InvalidOperationException)
			{
			}
		}
		List<DxAtlasData> dxAtlasConnectData = _arc.GetDxAtlasConnectData();
		if (dxAtlasConnectData.Count > 1)
		{
			_dxAtlas = new DxAtlasWrapper();
			_dxAtlas.Draw(dxAtlasConnectData);
		}
	}

	private void mnuToolsAppLogDiagnosticsTelnetInbound_Click(object sender, EventArgs e)
	{
		if (!mnuToolsAppLogDiagnosticsTelnetInbound.Checked)
		{
			if (MessageBox.Show("Logging inbound telnet traffic can effect performance.  Do you want to activate this diagnostic feature?", "Log Telnet Inbound Traffic", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				mnuToolsAppLogDiagnosticsTelnetInbound.Checked = true;
				_arc.LogTelnetInboundTraffic(action: true);
			}
		}
		else
		{
			mnuToolsAppLogDiagnosticsTelnetInbound.Checked = false;
			_arc.LogTelnetInboundTraffic(action: false);
		}
	}

	private void mnuToolsAppLogDiagnosticsTelnetOutbound_Click(object sender, EventArgs e)
	{
		if (!mnuToolsAppLogDiagnosticsTelnetOutbound.Checked)
		{
			if (MessageBox.Show("Logging outbound telnet traffic can effect performance.  Do you want to activate this diagnostic feature?", "Log Telnet Outbound Traffic", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				mnuToolsAppLogDiagnosticsTelnetOutbound.Checked = true;
				_arc.LogTelnetOutboundTraffic(action: true);
			}
		}
		else
		{
			mnuToolsAppLogDiagnosticsTelnetOutbound.Checked = false;
			_arc.LogTelnetOutboundTraffic(action: false);
		}
	}

	private void mnuToolsAppLogDiagnosticsArc6Nodes_Click(object sender, EventArgs e)
	{
		if (!mnuToolsAppLogDiagnosticsArc6Nodes.Checked)
		{
			if (MessageBox.Show("Logging all ARC6 node connections can effect performance.  Do you want to activate this diagnostic feature?", "Log ARC6 Node Traffic", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				mnuToolsAppLogDiagnosticsArc6Nodes.Checked = true;
				_arc.LogArc6NodeTraffic(action: true);
			}
		}
		else
		{
			mnuToolsAppLogDiagnosticsArc6Nodes.Checked = false;
			_arc.LogArc6NodeTraffic(action: false);
		}
	}

	private void mnuToolsAppLogDiagnosticsArc6Clients_Click(object sender, EventArgs e)
	{
		if (!mnuToolsAppLogDiagnosticsArc6Clients.Checked)
		{
			if (MessageBox.Show("Logging all ARC6 client connections can effect performance.  Do you want to activate this diagnostic feature?", "Log ARC6 Client Traffic", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				mnuToolsAppLogDiagnosticsArc6Clients.Checked = true;
				_arc.LogArc6ClientTraffic(action: true);
			}
		}
		else
		{
			mnuToolsAppLogDiagnosticsArc6Clients.Checked = false;
			_arc.LogArc6ClientTraffic(action: false);
		}
	}

	private void mnuToolsAppLogDiagnosticsPcxx_Click(object sender, EventArgs e)
	{
		if (!mnuToolsAppLogDiagnosticsPcxx.Checked)
		{
			if (MessageBox.Show("Logging all PCxx connections can effect performance.  Do you want to activate this diagnostic feature?", "Log PCxx Traffic", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				mnuToolsAppLogDiagnosticsPcxx.Checked = true;
				_arc.LogPcxxTraffic(action: true);
			}
		}
		else
		{
			mnuToolsAppLogDiagnosticsPcxx.Checked = false;
			_arc.LogPcxxTraffic(action: false);
		}
	}

	private void mnuToolsAppLogDiagnosticsAgwBpq_Click(object sender, EventArgs e)
	{
		if (!mnuToolsAppLogDiagnosticsAgwBpq.Checked)
		{
			mnuToolsAppLogDiagnosticsAgwBpq.Checked = true;
			_arc.LogAgwBpqTraffic(action: true);
		}
		else
		{
			mnuToolsAppLogDiagnosticsAgwBpq.Checked = false;
			_arc.LogAgwBpqTraffic(action: false);
		}
	}

	private void mnuToolsAppLogDiagnosticsDxDupes_Click(object sender, EventArgs e)
	{
		if (!mnuToolsAppLogDiagnosticsDxDupes.Checked)
		{
			mnuToolsAppLogDiagnosticsDxDupes.Checked = true;
			_arc.LogDxDupes(action: true);
		}
		else
		{
			mnuToolsAppLogDiagnosticsDxDupes.Checked = false;
			_arc.LogDxDupes(action: false);
		}
	}

	private void mnuToolsAppLogDiagnosticsAnnWxDupes_Click(object sender, EventArgs e)
	{
		if (!mnuToolsAppLogDiagnosticsAnnWxDupes.Checked)
		{
			mnuToolsAppLogDiagnosticsAnnWxDupes.Checked = true;
			_arc.LogAnnWxDupes(action: true);
		}
		else
		{
			mnuToolsAppLogDiagnosticsAnnWxDupes.Checked = false;
			_arc.LogAnnWxDupes(action: false);
		}
	}

	private void mnuToolsAppLogDiagnosticsWwvDupes_Click(object sender, EventArgs e)
	{
		if (!mnuToolsAppLogDiagnosticsWwvDupes.Checked)
		{
			mnuToolsAppLogDiagnosticsWwvDupes.Checked = true;
			_arc.LogWwvDupes(action: true);
		}
		else
		{
			mnuToolsAppLogDiagnosticsWwvDupes.Checked = false;
			_arc.LogWwvDupes(action: false);
		}
	}
}
