using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Security;
using System.Text;
using System.Windows.Forms;
using ArcInterfaces.Spots;
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

public class HelpAboutServer : Form
{
	internal sealed class ႷႷ
	{
		internal string Ⴓ;

		internal int Ⴐ;

		internal bool Ⴄ;

		internal bool Ⴗ;

		internal ႷႷ()
		{
		}
	}

	internal sealed class ႷႠ
	{
		internal long Ⴗ;

		internal long Ⴃ;

		internal ႷႠ()
		{
		}
	}

	private IContainer Ⴈ;

	private Button Ⴃ;

	private PictureBox Ⴐ;

	private TextBox Ⴄ;

	private TextBox Ⴓ;

	private Label Ⴅ;

	protected override void Dispose(bool disposing)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? 4 : 5);
				continue;
			case 5:
				num = ((Ⴈ == null) ? 4 : 2);
				continue;
			case 2:
			case 3:
				Ⴈ.Dispose();
				break;
			case 4:
			case 6:
				break;
			case 0:
				return;
			}
			break;
		}
		base.Dispose(disposing);
		WxCfg.ႣႭ[255] = (char)((WxCfg.ႣႭ[255] ^ WxCfg.ႣႭ[269]) & 0x21);
	}

	private void Ⴍ()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 4;
		ResourceManager resourceManager = default(ResourceManager);
		while (true)
		{
			switch (num)
			{
			default:
				resourceManager = new ComponentResourceManager(typeof(HelpAboutServer));
				Ⴃ = new Button();
				Ⴐ = new PictureBox();
				num = 6;
				break;
			case 6:
				Ⴄ = new TextBox();
				Ⴓ = new TextBox();
				Ⴅ = new Label();
				((ISupportInitialize)Ⴐ).BeginInit();
				num = 19;
				break;
			case 19:
				AutoUpdater.Ⴜ((Control)this, 793, '\u0303');
				PrecisionTimer.Ⴗ((Control)Ⴃ, new Point(247, 204), 'Ȩ', (short)512);
				num = 33;
				break;
			case 33:
				LogFile.Ⴀ((Control)Ⴃ, ႣႼ.Ⴜ(0, 365387209, 29), (short)880, (short)895);
				num = ⴐ[85] - 5713;
				break;
			case 2:
				ServerIoCfg.ႤႰ((Control)Ⴃ, new Size(75, 23), '^', (short)127);
				ObjectCopierExt.Ⴅ((Control)Ⴃ, 0, (short)439, 'Ƈ');
				num = 10;
				break;
			case 10:
				AnnCfg.Ⴗ((Control)Ⴃ, UtilsString.Ⴐ(null, 6, 192631526), (short)842, '\u034d');
				num = ⴀ[155] - 17748;
				break;
			case 34:
				LogFile.Ⴄ((ButtonBase)Ⴃ, true, (short)454, 420);
				UtilsCopyright.Ⴃ<Control, EventHandler>(Ⴃ, Ⴀ, 393, 384);
				goto case 30;
			case 30:
				num = ⴃႤ[193] - 14819;
				break;
			case 1:
				ႣႼ.ႰႥ(Ⴐ, (Image)ႰႨ.Ⴅ(), (short)682, (short)672);
				PrecisionTimer.Ⴗ((Control)Ⴐ, new Point(-2, -2), 'ȃ', (short)555);
				num = ⴃႣ[116] - 21521;
				break;
			case 14:
				LogFile.Ⴀ((Control)Ⴐ, DownloadUrl2.Ⴅ(30, null, 2018867824, 0), (short)598, (short)601);
				num = 11;
				break;
			case 11:
				ServerIoCfg.ႤႰ((Control)Ⴐ, new Size(150, 250), 'ΰ', (short)913);
				AutoUpdater.ႨႠ(Ⴐ, PictureBoxSizeMode.StretchImage, 395, 'ǣ');
				num = 9;
				break;
			case 9:
				DgvFilterHost.ႥႰ(Ⴐ, 1, 726, 706);
				ႷႳ(Ⴐ, false, 'ϖ', 996);
				num = 26;
				break;
			case 26:
				FrmUpdating.ႠႷ((TextBoxBase)Ⴄ, BorderStyle.None, '\u008c', 'î');
				AutoUpdater.ႨႨ((Control)Ⴄ, ႰႣ.Ⴗ(354, 293), (short)988, (short)910);
				num = 8;
				break;
			case 8:
				PrecisionTimer.Ⴗ((Control)Ⴄ, new Point(166, 46), 'ʄ', (short)684);
				ArxServerClient.Ⴀ((TextBoxBase)Ⴄ, true, (short)305, 380);
				num = ⴐ[168] - 4246;
				break;
			case 5:
				LogFile.Ⴀ((Control)Ⴄ, UtilsString.Ⴐ(null, 6, 192631545), (short)954, (short)949);
				num = 22;
				break;
			case 22:
				ReverseBeaconClient.Ⴃ((TextBoxBase)Ⴄ, true, 'Ͱ', 871);
				ServerIoCfg.ႤႰ((Control)Ⴄ, new Size(236, 114), 'ϭ', (short)972);
				num = 21;
				break;
			case 21:
				ObjectCopierExt.Ⴅ((Control)Ⴄ, 3, (short)241, 'Á');
				AnnCfg.Ⴗ((Control)Ⴄ, ReverseBeaconClient.Ⴈ((ResourceManager)(resourceManager as ComponentResourceManager), ႣႼ.ႥႭ(null, 624736118, 6, null), 739, (short)687), (short)656, 'ʗ');
				num = 16;
				break;
			case 16:
				FrmUpdating.ႠႷ((TextBoxBase)Ⴓ, BorderStyle.None, 'Γ', 'ϱ');
				UnZipFiles.Ⴅ((Control)Ⴓ, new Font(ArcLogInRqstExt.Ⴗ(1706507061, 4, 4), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0), (short)228, (short)250);
				num = ⴃႭ[67] - 30137;
				break;
			case 15:
				PrecisionTimer.Ⴗ((Control)Ⴓ, new Point(180, 172), 'ɚ', (short)626);
				LogFile.Ⴀ((Control)Ⴓ, TelnetServerClient.Ⴄ(1945322732, 'Ø', 6), (short)268, (short)259);
				num = ⴐ[168] - 4222;
				break;
			case 29:
				ReverseBeaconClient.Ⴃ((TextBoxBase)Ⴓ, true, 'υ', 978);
				ServerIoCfg.ႤႰ((Control)Ⴓ, new Size(221, 15), '\u0362', (short)835);
				num = ⴀ[370] - 60414;
				break;
			case 23:
				ObjectCopierExt.Ⴅ((Control)Ⴓ, 5, (short)263, 'ķ');
				AnnCfg.Ⴗ((Control)Ⴓ, ႣႼ.Ⴜ(3, 365387156, 26), (short)564, 'ȳ');
				num = ⴃႤ[413] - 24152;
				break;
			case 32:
				TelnetServerClient.Ⴗ(Ⴓ, HorizontalAlignment.Center, 'ŏ', 'ī');
				DxSpotExt.Ⴀ((Control)Ⴅ, true, (short)291, 'ĝ');
				goto case 13;
			case 13:
				num = ⴃႤ[474] - ⴃႤ[474];
				break;
			case 0:
				Ⴅ.Font = new Font(ArcLogInRqstExt.Ⴗ(1706507062, 9, 7), 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
				num = ⴃႤ[612] - 53369;
				break;
			case 7:
				Ⴅ.ForeColor = Color.Blue;
				Ⴅ.Location = new Point(249, 12);
				num = 18;
				break;
			case 18:
				Ⴅ.Name = UtilsString.Ⴐ(null, 5, 192631490);
				Ⴅ.Size = new Size(61, 24);
				num = 24;
				break;
			case 24:
				Ⴅ.TabIndex = 6;
				Ⴅ.Text = ႣႼ.Ⴜ(6, 365387170, 17);
				num = ⴃႣ[214] - 56049;
				break;
			case 17:
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				base.AutoScaleMode = AutoScaleMode.Font;
				AutoSize = true;
				goto case 31;
			case 31:
				num = 20;
				break;
			case 20:
				base.ClientSize = new Size(418, 248);
				base.Controls.Add(Ⴅ);
				num = ⴀ[43] - 13278;
				break;
			case 3:
				base.Controls.Add(Ⴓ);
				base.Controls.Add(Ⴄ);
				num = 12;
				break;
			case 12:
				base.Controls.Add(Ⴐ);
				base.Controls.Add(Ⴃ);
				num = 28;
				break;
			case 28:
				base.Name = ArcLogInRqstExt.Ⴗ(1706507085, 9, 5);
				base.StartPosition = FormStartPosition.CenterParent;
				num = ⴃႣ[176] - 11019;
				break;
			case 27:
				Text = ArcLogInRqstExt.Ⴗ(1706507098, 17, 0);
				((ISupportInitialize)Ⴐ).EndInit();
				num = ⴃႣ[2] - 5243;
				break;
			case 25:
				ResumeLayout(performLayout: false);
				PerformLayout();
				return;
			}
		}
	}

	public HelpAboutServer()
	{
		Ⴍ();
	}

	public void Init(string call, string version)
	{
		AnnCfg.Ⴗ((Control)Ⴅ, call, (short)509, 'Ǻ');
		Ⴓ.Text = TelnetServerClient.Ⴄ(1945322724, 'Ý', 2) + version;
	}

	private void Ⴀ(object P_0, EventArgs P_1)
	{
		DgvFreqRangeColumnFilter.Ⴅ((Form)this, (short)754, '\u02e6');
	}

	[SecuritySafeCritical]
	static HelpAboutServer()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210, _0021_00211, _0021_00212, _0021_00213>(_0021_00213 P_0, _0021_00211 P_1, _0021_00212 P_2, _0021_00210 P_3, short P_4, char P_5) where _0021_00210 : string where _0021_00211 : string where _0021_00212 : string where _0021_00213 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 9;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႤ[32] - 26645;
					continue;
				case 0:
					break;
				case 9:
					num2 = (((P_4 ^ P_5) - 110) ^ num) switch
					{
						0 => ⴃႣ[194] - 48170, 
						_ => ⴃႣ[131] - 64724, 
					};
					continue;
				case 4:
					obj = null;
					goto case 1;
				case 1:
					num2 = ⴗ[33] - 33383;
					continue;
				case 2:
				case 10:
					obj = string.Concat(P_0, P_1, P_2, P_3);
					num2 = 8;
					continue;
				case 8:
				{
					num++;
					int num3 = 140;
					int num4 = 34;
					num2 = ((35 < num3 / 4 - num4) ? 9 : (ⴃႣ[232] - 47280));
					continue;
				}
				case 3:
					return (string)obj;
				case 5:
				case 7:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210>(_0021_00210 P_0, byte[] P_1, int P_2, int P_3, char P_4, int P_5) where _0021_00210 : Stream
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႤ[452] - 24074;
				break;
			case 0:
				num = (((P_4 ^ P_5) - 78) ^ num2) switch
				{
					0 => ⴃႭ[32] - 53231, 
					_ => ⴗ[135] - 48373, 
				};
				break;
			case 8:
				num = 5;
				break;
			case 7:
			case 9:
				P_0.Write(P_1, P_2, P_3);
				goto case 4;
			case 4:
			case 5:
			{
				num2++;
				int num3 = 572;
				int num4 = 1019;
				num = ((9171 > num4 - num3 * 9) ? 6 : 3);
				break;
			}
			case 1:
			case 3:
				num = 0;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႳ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, short P_3) where _0021_00210 : PictureBox
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴐ[533] - ⴐ[533];
				break;
			case 0:
				num = (((P_2 ^ P_3) - 50) ^ num2) switch
				{
					0 => ⴐ[124] - 50859, 
					_ => 7, 
				};
				break;
			case 7:
				num = 8;
				break;
			case 3:
			case 4:
			case 6:
				P_0.TabStop = P_1;
				goto case 5;
			case 5:
			case 8:
			{
				num2++;
				int num3 = 308;
				int num4 = 732;
				num = ((6588 > num4 - num3 * 9) ? 2 : 9);
				break;
			}
			case 9:
				num = 0;
				break;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Encoding ႷႥ(int P_0, short P_1)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႤ[358] - 63040;
					continue;
				case 10:
					break;
				case 0:
					num2 = (((P_0 ^ P_1) - 107) ^ num) switch
					{
						0 => 2, 
						_ => 5, 
					};
					continue;
				case 5:
				case 11:
					obj = null;
					num2 = 7;
					continue;
				case 2:
					obj = Encoding.UTF8;
					num2 = 7;
					continue;
				case 7:
					num++;
					num3 = 113;
					goto case 1;
				case 1:
				{
					int num4 = 149;
					num2 = ((745 > num4 - num3 * 5) ? 9 : (ⴗ[140] - 43352));
					continue;
				}
				case 4:
				case 8:
					num2 = 0;
					continue;
				case 9:
					return obj as Encoding;
				case 6:
					num2 = ⴃႣ[53] - 65089;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static UriHostNameType ႷႤ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		UriHostNameType uriHostNameType = default(UriHostNameType);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[52] - 52156;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[10] - 46792;
					continue;
				case 10:
				case 11:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 95) ^ num) switch
					{
						0 => 3, 
						_ => ⴐ[487] - 19314, 
					};
					continue;
				case 6:
					uriHostNameType = UriHostNameType.Unknown;
					num2 = ⴃႤ[134] - 5897;
					continue;
				case 3:
					uriHostNameType = Uri.CheckHostName(P_0);
					num2 = ⴗ[36] - 32126;
					continue;
				case 1:
				case 8:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 0;
					continue;
				case 0:
					num2 = ((num3 % 2 != 0) ? 7 : 2);
					continue;
				case 2:
				case 5:
				{
					UriHostNameType result = uriHostNameType;
					TalkCfg.ႣႣ[193] = (char)(TalkCfg.ႣႣ[193] & DataGridViewColumnSelector.Ⴐ[435] & 0x8B);
					return result;
				}
				case 4:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႷႰ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႤ[554] - 10975;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[93] - 25917;
					continue;
				case 4:
					break;
				case 3:
				case 7:
				case 10:
					num2 = (((P_3 ^ P_2) - 79) ^ num) switch
					{
						0 => 0, 
						_ => 1, 
					};
					continue;
				case 1:
					result = true;
					num2 = 2;
					continue;
				case 0:
					result = P_0.EndsWith(P_1);
					num2 = 2;
					continue;
				case 2:
					num++;
					num3 = 617;
					goto case 5;
				case 5:
				{
					int num4 = 834;
					num2 = ((5004 > num4 - num3 * 6) ? 11 : 8);
					continue;
				}
				case 8:
					num2 = ⴃႤ[222] - 57356;
					continue;
				case 11:
					return result;
				case 9:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႭ<_0021_00210>(_0021_00210 P_0, ToolStripItemDisplayStyle P_1, char P_2, int P_3) where _0021_00210 : ToolStripItem
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 6;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀ[168] - ⴀ[168];
				break;
			case 0:
				num = (((P_2 ^ P_3) - 78) ^ num2) switch
				{
					0 => ⴃႭ[277] - 550, 
					_ => 5, 
				};
				break;
			case 5:
				num = 8;
				break;
			case 4:
				P_0.DisplayStyle = P_1;
				goto case 8;
			case 8:
				num2++;
				num3 = 572;
				goto case 9;
			case 9:
			{
				int num4 = 1019;
				num = ((9171 > num4 - num3 * 9) ? 1 : (ⴃႭ[82] - 56662));
				break;
			}
			case 7:
				num = 0;
				break;
			case 1:
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte ႷႨ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : DxSpot
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		byte result = default(byte);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[221] - 59518;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 90) ^ num) switch
					{
						0 => 3, 
						_ => ⴐ[241] - 18677, 
					};
					continue;
				case 4:
					result = 21;
					num2 = 7;
					continue;
				case 3:
					result = P_0.ItuZone;
					num2 = 7;
					continue;
				case 0:
				case 6:
				case 7:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴗ[50] - 11831;
					continue;
				case 10:
					num2 = ((num3 % 2 != 0) ? (ⴃႭ[220] - 42476) : (ⴃႭ[272] - 8223));
					continue;
				case 1:
				case 8:
					return result;
				case 5:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႷႣ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : BindingSource
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 10;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[519] - 58360;
					continue;
				case 2:
					break;
				case 10:
				case 11:
					num2 = (((P_1 ^ P_2) - 96) ^ num) switch
					{
						0 => 3, 
						_ => 1, 
					};
					continue;
				case 1:
					obj = null;
					num2 = 0;
					continue;
				case 3:
					obj = P_0.DataMember;
					num2 = ⴗ[139] - 41092;
					continue;
				case 0:
				case 4:
					num++;
					goto case 8;
				case 8:
				{
					int num3 = 7;
					int num4 = 39;
					num2 = ((117 > num4 - num3 * 3) ? 6 : 5);
					continue;
				}
				case 5:
					num2 = 10;
					continue;
				case 6:
					return obj as string;
				case 7:
					num2 = ⴃႤ[615] - 35708;
					continue;
				}
				break;
			}
		}
	}
}
