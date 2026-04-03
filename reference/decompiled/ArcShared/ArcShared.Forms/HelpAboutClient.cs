using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Security;
using System.Windows.Forms;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Arx;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter.Extensions;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.Forms;

public class HelpAboutClient : Form
{
	internal sealed class Ⴜ
	{
		internal OutputType Ⴄ;

		internal int Ⴓ;

		internal Ⴜ()
		{
		}
	}

	private IContainer Ⴅ;

	private Button Ⴃ;

	private TextBox Ⴓ;

	private TextBox Ⴐ;

	private Label Ⴀ;

	private DgvDateColumnFilter.Ⴅ m_Ⴍ;

	protected override void Dispose(bool disposing)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? (ⴐ[91] - 967) : (ⴀ[298] - 704));
				continue;
			case 4:
			case 6:
				num = ((Ⴅ != null) ? (ⴀ[403] - 52878) : 0);
				continue;
			case 2:
			case 5:
				Ⴅ.Dispose();
				break;
			case 0:
				break;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void Ⴈ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new ComponentResourceManager(typeof(HelpAboutClient));
				goto case 31;
			case 31:
			{
				Ⴃ = new Button();
				object obj2 = new PictureBox();
				this.m_Ⴍ.Ⴈ = obj2 as PictureBox;
				num = 4;
				break;
			}
			case 4:
				Ⴓ = new TextBox();
				Ⴐ = new TextBox();
				Ⴀ = new Label();
				goto case 27;
			case 27:
				((ISupportInitialize)this.m_Ⴍ.Ⴈ).BeginInit();
				num = ⴀ[126] - 16230;
				break;
			case 17:
				AutoUpdater.Ⴜ((Control)this, 257, 'ě');
				PrecisionTimer.Ⴗ((Control)Ⴃ, new Point(235, 206), 'ɨ', (short)576);
				num = ⴗ[59] - 8049;
				break;
			case 23:
				LogFile.Ⴀ((Control)Ⴃ, ႣႼ.Ⴜ(3, 365387210, 6), (short)623, (short)608);
				num = ⴗ[31] - 480;
				break;
			case 7:
				ServerIoCfg.ႤႰ((Control)Ⴃ, new Size(75, 23), 'ơ', (short)384);
				ObjectCopierExt.Ⴅ((Control)Ⴃ, 0, (short)966, '϶');
				num = 25;
				break;
			case 25:
				AnnCfg.Ⴗ((Control)Ⴃ, UtilsString.Ⴐ(null, 5, 192631525), (short)719, 'ˈ');
				num = 20;
				break;
			case 20:
				LogFile.Ⴄ((ButtonBase)Ⴃ, true, (short)256, 354);
				UtilsCopyright.Ⴃ<Control, EventHandler>(Ⴃ, Ⴍ, 623, 614);
				num = 5;
				break;
			case 5:
				ႣႼ.ႰႥ(this.m_Ⴍ.Ⴈ, (Image)ႰႨ.Ⴍ(), (short)340, (short)350);
				PrecisionTimer.Ⴗ((Control)this.m_Ⴍ.Ⴈ, new Point(-2, -2), '3', (short)27);
				num = 30;
				break;
			case 30:
			case 32:
				LogFile.Ⴀ((Control)this.m_Ⴍ.Ⴈ, DownloadUrl2.Ⴅ(16, null, 2018867684, 0), (short)303, (short)288);
				num = 16;
				break;
			case 16:
				ServerIoCfg.ႤႰ((Control)this.m_Ⴍ.Ⴈ, new Size(150, 248), 't', (short)85);
				num = 34;
				break;
			case 34:
				AutoUpdater.ႨႠ(this.m_Ⴍ.Ⴈ, PictureBoxSizeMode.StretchImage, 369, 'ę');
				DgvFilterHost.ႥႰ(this.m_Ⴍ.Ⴈ, 1, 794, 782);
				num = 10;
				break;
			case 10:
				HelpAboutServer.ႷႳ(this.m_Ⴍ.Ⴈ, false, '\u0083', 177);
				FrmUpdating.ႠႷ((TextBoxBase)Ⴓ, BorderStyle.None, 'Ő', 'Ĳ');
				num = 14;
				break;
			case 14:
				AutoUpdater.ႨႨ((Control)Ⴓ, ႰႣ.Ⴗ(537, 606), (short)288, (short)370);
				num = 18;
				break;
			case 18:
				PrecisionTimer.Ⴗ((Control)Ⴓ, new Point(166, 46), 'ɾ', (short)598);
				ArxServerClient.Ⴀ((TextBoxBase)Ⴓ, true, (short)154, 215);
				num = 35;
				break;
			case 35:
				LogFile.Ⴀ((Control)Ⴓ, TelnetServerClient.Ⴄ(1945322733, '\v', 7), (short)550, (short)553);
				num = ⴀ[55] - 33061;
				break;
			case 3:
				ReverseBeaconClient.Ⴃ((TextBoxBase)Ⴓ, true, 'Ŭ', 379);
				ServerIoCfg.ႤႰ((Control)Ⴓ, new Size(236, 114), 'ȑ', (short)560);
				num = ⴀ[277] - 60584;
				break;
			case 1:
				ObjectCopierExt.Ⴅ((Control)Ⴓ, 3, (short)967, 'Ϸ');
				AnnCfg.Ⴗ((Control)Ⴓ, ReverseBeaconClient.Ⴈ((ResourceManager)(obj as ComponentResourceManager), DownloadUrl2.Ⴅ(3, null, 2018868809, 1), 686, (short)738), (short)1003, 'Ϭ');
				num = ⴃႣ[105] - 52215;
				break;
			case 9:
				FrmUpdating.ႠႷ((TextBoxBase)Ⴐ, BorderStyle.None, 'ʐ', '\u02f2');
				UnZipFiles.Ⴅ((Control)Ⴐ, new Font(ArcLogInRqstExt.Ⴗ(1706507060, 7, 5), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0), (short)700, (short)674);
				num = 28;
				break;
			case 28:
				PrecisionTimer.Ⴗ((Control)Ⴐ, new Point(168, 174), '\u032c', (short)772);
				LogFile.Ⴀ((Control)Ⴐ, DownloadUrl2.Ⴅ(3, null, 2018867832, 8), (short)58, (short)53);
				num = ⴃႣ[214] - 56051;
				break;
			case 15:
				ReverseBeaconClient.Ⴃ((TextBoxBase)Ⴐ, true, 'ΐ', 903);
				ServerIoCfg.ႤႰ((Control)Ⴐ, new Size(221, 15), 'ƹ', (short)408);
				num = 29;
				break;
			case 29:
				ObjectCopierExt.Ⴅ((Control)Ⴐ, 5, (short)637, 'ɍ');
				AnnCfg.Ⴗ((Control)Ⴐ, ႣႼ.Ⴜ(3, 365387156, 13), (short)622, 'ɩ');
				num = ⴀ[43] - 13268;
				break;
			case 13:
				TelnetServerClient.Ⴗ(Ⴐ, HorizontalAlignment.Center, 'ɶ', 'Ȓ');
				DxSpotExt.Ⴀ((Control)Ⴀ, true, (short)453, 'ǻ');
				num = 12;
				break;
			case 12:
				Ⴀ.Font = new Font(ArcLogInRqstExt.Ⴗ(1706507058, 4, 3), 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
				num = 24;
				break;
			case 24:
				Ⴀ.ForeColor = Color.Blue;
				Ⴀ.Location = new Point(249, 12);
				num = ⴃႣ[176] - 11013;
				break;
			case 33:
				Ⴀ.Name = UtilsString.Ⴐ(null, 5, 192632193);
				Ⴀ.Size = new Size(61, 24);
				num = ⴃႣ[2] - 5257;
				break;
			case 11:
				Ⴀ.TabIndex = 6;
				Ⴀ.Text = ႣႼ.Ⴜ(1, 365387173, 13);
				num = 21;
				break;
			case 21:
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				base.AutoScaleMode = AutoScaleMode.Font;
				AutoSize = true;
				num = 6;
				break;
			case 6:
				base.ClientSize = new Size(418, 241);
				base.Controls.Add(Ⴀ);
				num = 22;
				break;
			case 22:
				base.Controls.Add(Ⴐ);
				base.Controls.Add(Ⴓ);
				num = 19;
				break;
			case 19:
				base.Controls.Add(this.m_Ⴍ.Ⴈ);
				base.Controls.Add(Ⴃ);
				num = 8;
				break;
			case 8:
				base.Name = TelnetServerClient.Ⴄ(1945322556, 'b', 3);
				base.StartPosition = FormStartPosition.CenterParent;
				num = 2;
				break;
			case 2:
				Text = ArcLogInRqstExt.Ⴗ(1706507096, 5, 2);
				((ISupportInitialize)this.m_Ⴍ.Ⴈ).EndInit();
				num = 26;
				break;
			case 26:
				ResumeLayout(performLayout: false);
				PerformLayout();
				return;
			}
		}
	}

	public HelpAboutClient()
	{
		Ⴈ();
	}

	public void Init(string call, string version)
	{
		AnnCfg.Ⴗ((Control)Ⴀ, call, (short)539, 'Ȝ');
		Ⴐ.Text = TelnetServerClient.Ⴄ(1945322725, 'æ', 3) + version;
	}

	private void Ⴍ(object P_0, EventArgs P_1)
	{
		DgvFreqRangeColumnFilter.Ⴅ((Form)this, (short)760, 'ˬ');
	}

	[SecuritySafeCritical]
	static HelpAboutClient()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static object Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, short P_3) where _0021_00210 : ArrayList
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[290] - 25262;
					continue;
				case 2:
					break;
				case 1:
					num2 = (((P_2 ^ P_3) - 85) ^ num) switch
					{
						0 => 11, 
						_ => 4, 
					};
					continue;
				case 4:
					result = null;
					num2 = 0;
					continue;
				case 9:
				case 11:
					result = P_0[P_1];
					num2 = 0;
					continue;
				case 0:
				{
					num++;
					int num3 = 45;
					int num4 = 944;
					int num5;
					if (4720 <= num4 - num3 * 5)
					{
						num5 = ⴐ[128] - 44707;
					}
					else
					{
						char num6 = ⴃႭ[67];
						DataGridViewColumnSelector.Ⴐ[75] = (char)((DataGridViewColumnSelector.Ⴐ[75] | P_3) & 0xA9);
						num5 = num6 - 30144;
					}
					num2 = num5;
					continue;
				}
				case 10:
					num2 = ⴀ[136] - 25398;
					continue;
				case 8:
					return result;
				case 3:
				case 5:
				case 7:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Size ႷႳ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : Control
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		Size result = default(Size);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႭ[32] - 53234;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 8;
					continue;
				case 8:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 7) ^ num) switch
					{
						0 => 9, 
						_ => 0, 
					};
					continue;
				case 0:
					result = default(Size);
					goto case 2;
				case 2:
					num2 = 6;
					continue;
				case 9:
					result = P_0.Size;
					num2 = 6;
					continue;
				case 6:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 3 : 11);
					continue;
				case 11:
					num2 = ⴀ[154] - 28010;
					continue;
				case 3:
				case 10:
					return result;
				case 5:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႷ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : EventHandler where _0021_00211 : Timer
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				continue;
			case 2:
				num = (((P_3 ^ P_2) - 7) ^ num2) switch
				{
					0 => ⴃႤ[125] - 39734, 
					_ => ⴗ[12] - 35083, 
				};
				continue;
			case 8:
				num = 1;
				continue;
			case 3:
			case 4:
			case 6:
				P_0.Tick += P_1;
				goto case 1;
			case 1:
				num2++;
				break;
			case 5:
				break;
			case 7:
				return;
			}
			int num3 = 110;
			int num4 = 19;
			num = ((55 < num3 / 2 - num4) ? 2 : 7);
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႠ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : Image where _0021_00211 : ToolStripItem
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 9;
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = ⴃႤ[608] - 18931;
				break;
			case 6:
				num = (((P_3 ^ P_2) - 113) ^ num4) switch
				{
					0 => 5, 
					_ => 8, 
				};
				break;
			case 8:
				num = ⴀ[241] - 35027;
				break;
			case 5:
				P_0.Image = P_1;
				goto case 7;
			case 7:
				num4++;
				goto case 0;
			case 0:
				num3 = P_3 * P_3;
				num3 = P_3 + num3;
				goto case 3;
			case 3:
				num = 2;
				break;
			case 2:
			case 4:
			{
				int num2 = num3 % 2;
				UtilsNumeric.Ⴀ[204] = (char)((UtilsNumeric.Ⴀ[204] - DataGridViewColumnSelector.Ⴐ[311]) & 0x12);
				num = ((num2 == 0) ? 1 : 6);
				break;
			}
			case 1:
				return;
			}
		}
	}
}
