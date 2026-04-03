using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Security;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Arx;
using ArcShared.ArcIo.Pcxx;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using ArcShared.Forms;
using ArcShared.MaintenanceUpdates;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.DgvUtils.DgvFilter.Implementations;

[ToolboxItem(false)]
public class DgvFilterHost : DgvBaseFilterHost
{
	private new Label Ⴓ;

	private PictureBox Ⴅ;

	private new UtilsXml.Ⴐ Ⴀ = new UtilsXml.Ⴐ();

	public override Control FilterClientArea
	{
		get
		{
			Panel ⴈ = Ⴈ;
			NeedsCfg.ႣႤ[318] = (NeedsCfg.ႣႤ[318] | NeedsCfg.ႣႤ[341]) & 0x8E;
			return ⴈ;
		}
	}

	protected override void Dispose(bool disposing)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? 3 : 6);
				continue;
			case 6:
				num = ((Ⴀ.Ⴐ == null) ? 3 : (ⴀ[373] - 62332));
				continue;
			case 0:
			case 1:
			case 5:
				Ⴀ.Ⴐ.Dispose();
				break;
			case 3:
			case 4:
				break;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void ႤႠ()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 55;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				obj = new ComponentResourceManager(typeof(DgvFilterHost));
				object obj4 = new ToolStrip();
				Ⴀ.Ⴄ = (ToolStrip)obj4;
				num = ⴐ[351] - 17270;
				break;
			}
			case 15:
			{
				base.Ⴜ = new ToolStripButton();
				object obj3 = new ToolStripButton();
				Ⴀ.Ⴗ = (ToolStripButton)obj3;
				num = 50;
				break;
			}
			case 50:
				base.Ⴀ = new ToolStripButton();
				Ⴄ = new ToolStripButton();
				Ⴗ = new Panel();
				Ⴓ = new Label();
				num = 36;
				break;
			case 36:
				Ⴅ = new PictureBox();
				Ⴈ = new Panel();
				DgvDateColumnFilter.ႳႰ((Control)Ⴀ.Ⴄ, '\u007f', (short)58);
				num = ⴃႣ[93] - 25887;
				break;
			case 34:
				DgvDateColumnFilter.ႳႰ((Control)Ⴗ, 'Ʒ', (short)498);
				((ISupportInitialize)Ⴅ).BeginInit();
				AutoUpdater.Ⴜ((Control)this, 845, '\u0357');
				num = ⴃႤ[554] - 10939;
				break;
			case 39:
				UtilsCopyright.Ⴀ(Ⴀ.Ⴄ, DgvTextBoxColumnFilter.Ⴐ(462, 'Ƥ'), 62, 55);
				num = 60;
				break;
			case 60:
				AnnWxSpotExt.ႤႷ((Control)Ⴀ.Ⴄ, DockStyle.Bottom, (short)729, 744);
				DgvTextBoxColumnFilter.ႷႤ(Ⴀ.Ⴄ, ToolStripGripStyle.Hidden, 'Α', 'Ϭ');
				num = 25;
				break;
			case 25:
			{
				ToolStripItemCollection toolStripItemCollection = AutoUpdater.ႨႳ(Ⴀ.Ⴄ, 395, 'ǣ');
				object obj2 = new ToolStripItem[4];
				(obj2 as ToolStripItem[])[0] = base.Ⴜ;
				(obj2 as ToolStripItem[])[1] = Ⴀ.Ⴗ;
				(obj2 as ToolStripItem[])[2] = base.Ⴀ;
				(obj2 as ToolStripItem[])[3] = Ⴄ;
				ႥႭ(toolStripItemCollection, obj2 as ToolStripItem[], 726, 706);
				num = 26;
				break;
			}
			case 26:
				PrecisionTimer.Ⴗ((Control)Ⴀ.Ⴄ, new Point(0, 69), 'ʗ', (short)703);
				num = 42;
				break;
			case 42:
				LogFile.Ⴀ((Control)Ⴀ.Ⴄ, UtilsString.Ⴐ(null, 7, 192631370), (short)87, (short)88);
				num = 32;
				break;
			case 32:
				UtilsSql.ႨႰ(Ⴀ.Ⴄ, ToolStripRenderMode.System, 279, 368);
				ServerIoCfg.ႤႰ((Control)Ⴀ.Ⴄ, new Size(152, 25), '\u0336', (short)791);
				num = 11;
				break;
			case 11:
				ObjectCopierExt.Ⴅ((Control)Ⴀ.Ⴄ, 5, (short)254, 'Î');
				AnnCfg.Ⴗ((Control)Ⴀ.Ⴄ, TelnetServerClient.Ⴄ(1945322830, 'w', 3), (short)199, 'À');
				num = ⴃႤ[222] - 57343;
				break;
			case 16:
				HelpAboutServer.ႷႭ((ToolStripItem)base.Ⴜ, ToolStripItemDisplayStyle.Image, '\u02c2', 652);
				HelpAboutClient.ႷႠ((ToolStripItem)base.Ⴜ, (Image)TelnetServerClient.ႥႥ((ResourceManager)(obj as ComponentResourceManager), TelnetServerClient.Ⴄ(1945322820, '\u00b8', 6), 223, 'È'), 907, (short)1018);
				num = 40;
				break;
			case 40:
				UtilsValidation.Ⴀ((ToolStripItem)base.Ⴜ, ArxServerClient.Ⴄ(411, 'ƽ'), (short)512, (short)613);
				num = 41;
				break;
			case 41:
				ႰႣ.ႰႠ((ToolStripItem)base.Ⴜ, TelnetServerClient.Ⴄ(1945322837, '»', 1), (short)824, 890);
				num = 46;
				break;
			case 46:
				AnnCfg.ႷႰ((ToolStripItem)base.Ⴜ, new Size(23, 22), (short)143, 'ú');
				ႰႣ.ႰႠ((ToolStripItem)base.Ⴜ, TelnetServerClient.Ⴄ(1945322857, '$', 4), (short)268, 335);
				num = ⴗ[33] - 33372;
				break;
			case 19:
				ArcLogInRespExt.Ⴓ((ToolStripItem)base.Ⴜ, DownloadUrl2.Ⴅ(21, null, 2018869114, 4), 265, 'ĩ');
				num = 0;
				break;
			case 0:
				ArcLogInRespExt.Ⴄ<EventHandler, ToolStripItem>(base.Ⴜ, ႤႥ, '\u02dd', 756);
				HelpAboutServer.ႷႭ((ToolStripItem)Ⴀ.Ⴗ, ToolStripItemDisplayStyle.Image, 'Ϋ', 997);
				num = 5;
				break;
			case 5:
				HelpAboutClient.ႷႠ((ToolStripItem)Ⴀ.Ⴗ, (Image)TelnetServerClient.ႥႥ((ResourceManager)(ComponentResourceManager)obj, TelnetServerClient.Ⴄ(1945322874, '\u0080', 2), 742, '\u02f1'), 574, (short)591);
				num = 51;
				break;
			case 51:
				UtilsValidation.Ⴀ((ToolStripItem)Ⴀ.Ⴗ, ArxServerClient.Ⴄ(493, 'ǋ'), (short)907, (short)1006);
				num = ⴐ[98] - 35637;
				break;
			case 43:
				DirectoryMonitor.ႠႨ((ToolStripItem)Ⴀ.Ⴗ, new Padding(0), 216, 'ÿ');
				num = 37;
				break;
			case 37:
				ႰႣ.ႰႠ((ToolStripItem)Ⴀ.Ⴗ, TelnetServerClient.Ⴄ(1945322868, '\u009d', 6), (short)376, 314);
				num = 17;
				break;
			case 17:
				AnnCfg.ႷႰ((ToolStripItem)Ⴀ.Ⴗ, new Size(23, 25), (short)287, 'Ū');
				num = 27;
				break;
			case 27:
				ႰႣ.ႰႠ((ToolStripItem)Ⴀ.Ⴗ, TelnetServerClient.Ⴄ(1945322752, 'Ó', 0), (short)40, 107);
				num = 1;
				break;
			case 1:
				ArcLogInRespExt.Ⴄ<EventHandler, ToolStripItem>(Ⴀ.Ⴗ, ႤႷ, '\u02f2', 731);
				num = ⴃႭ[82] - 56661;
				break;
			case 8:
				HelpAboutServer.ႷႭ((ToolStripItem)base.Ⴀ, ToolStripItemDisplayStyle.Image, 'Ȟ', 592);
				HelpAboutClient.ႷႠ((ToolStripItem)base.Ⴀ, (Image)TelnetServerClient.ႥႥ((ResourceManager)(obj as ComponentResourceManager), ArcLogInRqstExt.Ⴗ(1706507558, 16, 7), 157, '\u008a'), 399, (short)510);
				num = 33;
				break;
			case 33:
				UtilsValidation.Ⴀ((ToolStripItem)base.Ⴀ, ArxServerClient.Ⴄ(33, '\a'), (short)743, (short)642);
				num = 30;
				break;
			case 30:
			{
				DirectoryMonitor.ႠႨ((ToolStripItem)base.Ⴀ, new Padding(5, 1, 0, 2), 933, '\u0382');
				char num2 = ⴐ[415];
				DataGridViewColumnSelector.Ⴐ[263] = (char)(DataGridViewColumnSelector.Ⴐ[263] & NeedsCfg.ႣႤ[308] & 0x42);
				num = num2 - 57826;
				break;
			}
			case 44:
				ႰႣ.ႰႠ((ToolStripItem)base.Ⴀ, ႣႼ.ႥႭ(null, 624735412, 7, null), (short)108, 46);
				num = ⴃႭ[136] - 62979;
				break;
			case 18:
				AnnCfg.ႷႰ((ToolStripItem)base.Ⴀ, new Size(23, 22), (short)673, '\u02d4');
				ႰႣ.ႰႠ((ToolStripItem)base.Ⴀ, ႣႼ.ႥႭ(null, 624735402, 4, null), (short)618, 553);
				num = ⴐ[481] - 29194;
				break;
			case 58:
				ArcLogInRespExt.Ⴓ((ToolStripItem)base.Ⴀ, ႣႼ.Ⴜ(6, 365385993, 1), 263, 'ħ');
				num = 56;
				break;
			case 56:
				ArcLogInRespExt.Ⴄ<EventHandler, ToolStripItem>(base.Ⴀ, ႤႳ, 'Ϳ', 854);
				LegalCfg.Ⴍ((ToolStripItem)Ⴄ, ToolStripItemAlignment.Right, '\u0368', (short)853);
				num = 53;
				break;
			case 53:
				HelpAboutServer.ႷႭ((ToolStripItem)Ⴄ, ToolStripItemDisplayStyle.Image, '\u02d4', 666);
				HelpAboutClient.ႷႠ((ToolStripItem)Ⴄ, (Image)TelnetServerClient.ႥႥ((ResourceManager)(obj as ComponentResourceManager), ႣႼ.Ⴜ(8, 365386007, 24), 553, 'Ⱦ'), 589, (short)572);
				num = 52;
				break;
			case 52:
				UtilsValidation.Ⴀ((ToolStripItem)Ⴄ, ArxServerClient.Ⴄ(377, 'ş'), (short)176, (short)213);
				num = 3;
				break;
			case 3:
				ႰႣ.ႰႠ((ToolStripItem)Ⴄ, ႣႼ.Ⴜ(0, 365386025, 30), (short)313, 379);
				goto case 14;
			case 14:
				num = 24;
				break;
			case 24:
				AnnCfg.ႷႰ((ToolStripItem)Ⴄ, new Size(23, 22), (short)0, 'u');
				goto case 35;
			case 35:
				ႰႣ.ႰႠ((ToolStripItem)Ⴄ, UtilsString.Ⴐ(null, 6, 192631526), (short)860, 799);
				num = ⴃႣ[187] - 55687;
				break;
			case 29:
				ArcLogInRespExt.Ⴄ<EventHandler, ToolStripItem>(Ⴄ, ႤႣ, 'ɲ', 603);
				StringConstants.Ⴓ((Control)Ⴗ, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, 'ˁ', 719);
				num = 48;
				break;
			case 48:
				UtilsLatLon.ႷႭ((Control)Ⴗ, ႰႣ.Ⴗ(851, 794), 244, 182);
				num = 45;
				break;
			case 45:
				LogFile.Ⴜ((Control)Ⴗ, 921, 930).Add(Ⴓ);
				LogFile.Ⴜ((Control)Ⴗ, 870, 861).Add(Ⴅ);
				num = 20;
				break;
			case 20:
				PrecisionTimer.Ⴗ((Control)Ⴗ, new Point(-9, -1), 'Ċ', (short)290);
				LogFile.Ⴀ((Control)Ⴗ, DownloadUrl2.Ⴅ(16, null, 2018867682, 6), (short)229, (short)234);
				num = 6;
				break;
			case 6:
				ServerIoCfg.ႤႰ((Control)Ⴗ, new Size(162, 24), 's', (short)82);
				ObjectCopierExt.Ⴅ((Control)Ⴗ, 10, (short)350, 'Ů');
				num = 57;
				break;
			case 57:
				DxSpotExt.Ⴀ((Control)Ⴓ, true, (short)14, '0');
				Ⴓ.BackColor = Color.Transparent;
				num = ⴃႭ[74] - 34498;
				break;
			case 21:
				Ⴓ.Font = new Font(ArcLogInRqstExt.Ⴗ(1706507056, 23, 1), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
				num = 47;
				break;
			case 47:
				Ⴓ.Location = new Point(34, 5);
				Ⴓ.Name = TelnetServerClient.Ⴄ(1945322733, 'k', 7);
				num = ⴃႤ[243] - 32116;
				break;
			case 22:
				Ⴓ.Size = new Size(84, 13);
				Ⴓ.TabIndex = 12;
				num = 10;
				break;
			case 10:
				Ⴓ.Text = ArcLogInRqstExt.Ⴗ(1706507564, 26, 7);
				Ⴅ.BackColor = Color.Transparent;
				num = 9;
				break;
			case 9:
			case 59:
				Ⴅ.Image = (Image)(obj as ComponentResourceManager).GetObject(ႣႼ.ႥႭ(null, 624735724, 2, null));
				num = 12;
				break;
			case 12:
				Ⴅ.Location = new Point(12, 3);
				Ⴅ.Name = UtilsString.Ⴐ(null, 5, 192631490);
				num = ⴗ[50] - 11839;
				break;
			case 2:
				Ⴅ.Size = new Size(16, 16);
				Ⴅ.SizeMode = PictureBoxSizeMode.AutoSize;
				num = ⴃႭ[272] - 8203;
				break;
			case 28:
				Ⴅ.TabIndex = 10;
				Ⴅ.TabStop = false;
				Ⴈ.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
				num = ⴃႭ[220] - 42456;
				break;
			case 31:
				Ⴈ.Location = new Point(3, 26);
				Ⴈ.Name = UtilsString.Ⴐ(null, 6, 192632790);
				num = 23;
				break;
			case 23:
				Ⴈ.Size = new Size(146, 40);
				Ⴈ.TabIndex = 11;
				num = ⴃႣ[67] - 59327;
				break;
			case 54:
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				base.AutoScaleMode = AutoScaleMode.Font;
				BackColor = Color.White;
				num = ⴃႣ[20] - 44808;
				break;
			case 4:
				base.BorderStyle = BorderStyle.FixedSingle;
				base.Controls.Add(Ⴈ);
				base.Controls.Add(Ⴀ.Ⴄ);
				num = 49;
				break;
			case 49:
				base.Controls.Add(Ⴗ);
				base.Name = ArcLogInRqstExt.Ⴗ(1706507581, 20, 4);
				num = 13;
				break;
			case 13:
				base.Size = new Size(152, 94);
				Ⴀ.Ⴄ.ResumeLayout(performLayout: false);
				num = ⴃႤ[406] - 38112;
				break;
			case 38:
				Ⴀ.Ⴄ.PerformLayout();
				Ⴗ.ResumeLayout(performLayout: false);
				Ⴗ.PerformLayout();
				num = ⴃႤ[481] - 29435;
				break;
			case 7:
				((ISupportInitialize)Ⴅ).EndInit();
				ResumeLayout(performLayout: false);
				PerformLayout();
				return;
			}
		}
	}

	public DgvFilterHost()
	{
		ႤႠ();
		base.CurrentColumnFilterChanged += ႤႤ;
	}

	private void ႤႤ(object P_0, EventArgs P_1)
	{
		AnnCfg.Ⴗ((Control)Ⴓ, base.CurrentColumnFilter.OriginalDataGridViewColumnHeaderText, (short)481, 'Ǧ');
	}

	private void ႤႣ(object P_0, EventArgs P_1)
	{
		base.FilterManager.ActivateFilter(Active: true);
		PcxxServerClient.Ⴈ(base.Popup, 'Ĉ', 326);
	}

	private void ႤႳ(object P_0, EventArgs P_1)
	{
		base.FilterManager.ActivateFilter(Active: false);
		PcxxServerClient.Ⴈ(base.Popup, 'ʭ', 739);
	}

	private void ႤႷ(object P_0, EventArgs P_1)
	{
		base.FilterManager.ActivateAllFilters(Active: false);
		PcxxServerClient.Ⴈ(base.Popup, '\u0332', 892);
	}

	private void ႤႥ(object P_0, EventArgs P_1)
	{
		base.FilterManager.Ⴅ();
		PcxxServerClient.Ⴈ(base.Popup, 'ɟ', 529);
	}

	[SecuritySafeCritical]
	static DgvFilterHost()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static StringBuilder ႥႨ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string where _0021_00211 : StringBuilder
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[155] - 46129;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[9] - 32471;
					continue;
				case 6:
				case 9:
					break;
				case 7:
					num2 = (((P_3 ^ P_2) - 32) ^ num) switch
					{
						0 => 11, 
						_ => ⴐ[497] - 8516, 
					};
					continue;
				case 0:
					obj = null;
					num2 = 10;
					continue;
				case 11:
					obj = P_0.Append(P_1);
					num2 = 10;
					continue;
				case 10:
					num++;
					num3 = 205;
					goto case 5;
				case 5:
				{
					int num4 = 853;
					num2 = ((1706 > num4 - num3 * 2) ? 3 : 2);
					continue;
				}
				case 2:
					num2 = 7;
					continue;
				case 3:
				case 4:
					return obj as StringBuilder;
				case 8:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႥႥ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : Control
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 7;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[30] - 17778;
					continue;
				case 6:
					break;
				case 7:
					num2 = (((P_2 ^ P_1) - 94) ^ num) switch
					{
						0 => 11, 
						_ => 4, 
					};
					continue;
				case 4:
					result = true;
					goto case 0;
				case 0:
					num2 = ⴗ[144] - 45242;
					continue;
				case 1:
				case 11:
					result = P_0.Visible;
					num2 = ⴐ[15] - 19737;
					continue;
				case 3:
				{
					num++;
					int num3 = 715;
					int num4 = 851;
					num2 = ((3404 > num4 - num3 * 4) ? (ⴃႤ[427] - 50431) : (ⴃႣ[42] - 15426));
					continue;
				}
				case 8:
					num2 = 7;
					continue;
				case 5:
					return result;
				case 2:
				case 9:
					num2 = ⴐ[90] - 34732;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႰ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, int P_3) where _0021_00210 : PictureBox
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 4;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႭ[173] - 11197;
				break;
			case 8:
				num = (((P_2 ^ P_3) - 20) ^ num2) switch
				{
					0 => ⴃႤ[123] - 21536, 
					_ => ⴃႣ[103] - 47723, 
				};
				break;
			case 0:
			case 7:
				num = 2;
				break;
			case 3:
				P_0.TabIndex = P_1;
				goto case 2;
			case 2:
			case 9:
				num2++;
				num3 = 64;
				num4 = 163;
				goto case 5;
			case 5:
			{
				int num5 = num4;
				int num6 = num3;
				UtilsNumeric.Ⴀ[260] = (char)((UtilsNumeric.Ⴀ[260] - WxCfg.ႣႭ[198]) & 0x7D);
				num = ((978 > num5 - num6 * 6) ? 1 : (ⴀ[298] - 702));
				break;
			}
			case 6:
				num = ⴃႣ[214] - 56058;
				break;
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႳ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : ArrayList
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 2;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				break;
			case 0:
				num = (((P_2 ^ P_3) - 5) ^ num2) switch
				{
					0 => ⴃႣ[96] - 36626, 
					_ => ⴃႣ[215] - 32471, 
				};
				break;
			case 9:
				num = 1;
				break;
			case 8:
				P_0.Remove(P_1);
				goto case 1;
			case 1:
			case 4:
				num2++;
				goto case 6;
			case 6:
				num3 = 195;
				num4 = 741;
				goto case 7;
			case 7:
				num = ((5187 > num4 - num3 * 7) ? (ⴃႣ[5] - 35957) : 5);
				break;
			case 5:
				num = 0;
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႷ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : string where _0021_00211 : XmlWriter
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 5;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႣ[6] - 35266;
				continue;
			case 6:
				num = (((P_2 ^ P_3) - 6) ^ num2) switch
				{
					0 => ⴃႭ[43] - 34346, 
					_ => 8, 
				};
				continue;
			case 8:
				num = 1;
				continue;
			case 2:
			case 3:
			case 4:
				P_0.WriteStartElement(P_1);
				goto case 1;
			case 1:
				num2++;
				num3 = 2760;
				break;
			case 0:
				break;
			case 7:
				return;
			}
			int num4 = 202;
			num = ((920 < num3 / 3 - num4) ? 6 : (ⴃႭ[97] - 35149));
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႭ<_0021_00210>(_0021_00210 P_0, ToolStripItem[] P_1, int P_2, int P_3) where _0021_00210 : ToolStripItemCollection
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				break;
			case 8:
				num = (((P_2 ^ P_3) - 20) ^ num2) switch
				{
					0 => 2, 
					_ => ⴐ[596] - ⴐ[596], 
				};
				break;
			case 0:
			case 7:
				num = ⴗ[128] - 21303;
				break;
			case 2:
				P_0.AddRange(P_1);
				goto case 4;
			case 4:
			case 5:
			{
				num2++;
				int num3 = 64;
				int num4 = 163;
				num = ((978 > num4 - num3 * 6) ? (ⴃႣ[49] - 50432) : (ⴀ[329] - 29352));
				break;
			}
			case 6:
				num = ⴀ[387] - 45964;
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႥႣ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : Control
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 11;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[178] - 58281;
					continue;
				case 8:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 123) ^ num) switch
					{
						0 => 1, 
						1 => ⴃႭ[15] - 26127, 
						_ => 6, 
					};
					continue;
				case 6:
					result = false;
					goto case 2;
				case 2:
					num2 = 9;
					continue;
				case 1:
					result = P_0.InvokeRequired;
					num2 = ⴗ[1] - 50400;
					continue;
				case 4:
				{
					result = P_0.IsDisposed;
					char num3 = ⴀ[106];
					DxCfg.Ⴗ[81] = (char)((DxCfg.Ⴗ[81] + P_2) & 0x40);
					num2 = num3 - 19401;
					continue;
				}
				case 9:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 12 : 7);
					continue;
				case 7:
				case 10:
					num2 = ⴀ[387] - 45961;
					continue;
				case 12:
					return result;
				case 0:
					num2 = ⴐ[168] - 4240;
					continue;
				}
				break;
			}
		}
	}
}
