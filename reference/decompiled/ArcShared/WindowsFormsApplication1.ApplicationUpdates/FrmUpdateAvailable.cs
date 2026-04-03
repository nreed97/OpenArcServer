using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using ArcShared;
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
using ArcShared.Forms;
using Microsoft.VisualBasic.PowerPacks;
using Ⴃ;

namespace WindowsFormsApplication1.ApplicationUpdates;

public class FrmUpdateAvailable : Form
{
	private IContainer Ⴀ;

	private Button Ⴄ;

	private ShapeContainer Ⴜ;

	private AnnCfg.ႷႷ ႳႤ = new AnnCfg.ႷႷ();

	public string AppName
	{
		get
		{
			return ႳႤ.Ⴄ;
		}
		set
		{
			ႳႤ.Ⴄ = value;
		}
	}

	public string UpdateVersion
	{
		get
		{
			string ⴜ = ႳႤ.Ⴜ;
			DxCfg.Ⴗ[138] = (char)((DxCfg.Ⴗ[138] - DataGridViewColumnSelector.Ⴐ[139]) & 0x4F);
			return ⴜ;
		}
		set
		{
			ႳႤ.Ⴜ = value;
			NeedsCfg.ႣႤ[399] = (NeedsCfg.ႣႤ[399] + UtilsNumeric.Ⴀ[6]) & 0x47;
		}
	}

	public FrmUpdateAvailable()
	{
		ႤႨ();
	}

	private void ႤႰ(object P_0, EventArgs P_1)
	{
		ArxServerClient.Ⴗ((Form)this, DialogResult.OK, (short)556, 553);
		Close();
	}

	private void ႤႤ(object P_0, EventArgs P_1)
	{
		DgvFreqRangeColumnFilter.Ⴅ((Form)this, (short)385, 'ƕ');
	}

	private void ႤႷ(object P_0, EventArgs P_1)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				ႳႤ.Ⴃ.Text = AppName + ArcLogInRqstExt.Ⴗ(1706507913, 5, 4) + UpdateVersion;
				return;
			case 2:
				return;
			}
			AnnCfg.Ⴗ((Control)ႳႤ.Ⴗ, DownloadUrl2.Ⴅ(30, null, 2018867496, 3), (short)391, 'ƀ');
			num = ⴀ[35] - 1103;
		}
	}

	protected override void Dispose(bool disposing)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				num = (disposing ? 1 : 6);
				continue;
			case 1:
			case 2:
			case 3:
				num = ((Ⴀ == null) ? (ⴐ[99] - 51743) : 0);
				continue;
			case 0:
				Ⴀ.Dispose();
				break;
			case 6:
				break;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void ႤႨ()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 51;
		ResourceManager resourceManager = default(ResourceManager);
		while (true)
		{
			switch (num)
			{
			default:
			{
				resourceManager = new ComponentResourceManager(typeof(FrmUpdateAvailable));
				IButtonControl buttonControl = new Button();
				ႳႤ.Ⴅ = buttonControl as Button;
				num = ⴐ[237] - 23058;
				break;
			}
			case 37:
			{
				Control control = new Label();
				ႳႤ.Ⴗ = control as Label;
				Control control2 = new Label();
				ႳႤ.Ⴈ = control2 as Label;
				num = 36;
				break;
			}
			case 36:
			{
				object obj3 = new Label();
				ႳႤ.Ⴍ = (Label)obj3;
				object obj4 = new Label();
				ႳႤ.Ⴃ = obj4 as Label;
				num = ⴃႣ[187] - 55695;
				break;
			}
			case 21:
			{
				object obj2 = new Label();
				ႳႤ.Ⴐ = obj2 as Label;
				Ⴄ = new Button();
				num = 11;
				break;
			}
			case 11:
			{
				object obj = new PictureBox();
				ႳႤ.Ⴀ = obj as PictureBox;
				Ⴜ = new ShapeContainer();
				num = ⴗ[141] - 5912;
				break;
			}
			case 30:
			{
				Shape shape = new LineShape();
				ႳႤ.Ⴓ = shape as LineShape;
				((ISupportInitialize)ႳႤ.Ⴀ).BeginInit();
				num = ⴀ[398] - 36358;
				break;
			}
			case 23:
				AutoUpdater.Ⴜ((Control)this, 361, 'ų');
				PrecisionTimer.Ⴗ((Control)ႳႤ.Ⴅ, new Point(384, 135), '\u000e', (short)38);
				num = 58;
				break;
			case 58:
				LogFile.Ⴀ((Control)ႳႤ.Ⴅ, DownloadUrl2.Ⴅ(16, null, 2018867829, 5), (short)491, (short)484);
				num = 29;
				break;
			case 29:
				ServerIoCfg.ႤႰ((Control)ႳႤ.Ⴅ, new Size(75, 23), 'Ə', (short)430);
				num = 4;
				break;
			case 4:
				ObjectCopierExt.Ⴅ((Control)ႳႤ.Ⴅ, 0, (short)40, '\u0018');
				AnnCfg.Ⴗ((Control)ႳႤ.Ⴅ, UtilsString.Ⴐ(null, 5, 192631525), (short)590, 'ɉ');
				num = 50;
				break;
			case 50:
				LogFile.Ⴄ((ButtonBase)ႳႤ.Ⴅ, true, (short)361, 267);
				UtilsCopyright.Ⴃ<Control, EventHandler>(ႳႤ.Ⴅ, ႤႰ, 583, 590);
				num = 12;
				break;
			case 12:
				DxSpotExt.Ⴀ((Control)ႳႤ.Ⴗ, true, (short)810, '\u0314');
				UtilsLatLon.ႷႭ((Control)ႳႤ.Ⴗ, DownloadUrl.Ⴐ(813, 794), 371, 305);
				num = 57;
				break;
			case 57:
				PrecisionTimer.Ⴗ((Control)ႳႤ.Ⴗ, new Point(38, 29), 'Ƃ', (short)426);
				num = 24;
				break;
			case 24:
				LogFile.Ⴀ((Control)ႳႤ.Ⴗ, TelnetServerClient.Ⴄ(1945322735, 'È', 5), (short)104, (short)103);
				num = 38;
				break;
			case 38:
				ServerIoCfg.ႤႰ((Control)ႳႤ.Ⴗ, new Size(129, 13), 'ʨ', (short)649);
				num = 41;
				break;
			case 41:
				ObjectCopierExt.Ⴅ((Control)ႳႤ.Ⴗ, 3, (short)356, 'Ŕ');
				AnnCfg.Ⴗ((Control)ႳႤ.Ⴗ, DownloadUrl2.Ⴅ(2, null, 2018868192, 0), (short)954, 'ν');
				num = 56;
				break;
			case 56:
				DxSpotExt.Ⴀ((Control)ႳႤ.Ⴈ, true, (short)217, 'ç');
				PrecisionTimer.Ⴗ((Control)ႳႤ.Ⴈ, new Point(25, 70), 'į', (short)263);
				num = ⴃႣ[197] - 30593;
				break;
			case 34:
				LogFile.Ⴀ((Control)ႳႤ.Ⴈ, DownloadUrl2.Ⴅ(15, null, 2018867686, 2), (short)32, (short)47);
				num = 42;
				break;
			case 42:
				ServerIoCfg.ႤႰ((Control)ႳႤ.Ⴈ, new Size(38, 13), '{', (short)90);
				num = 54;
				break;
			case 54:
				ObjectCopierExt.Ⴅ((Control)ႳႤ.Ⴈ, 4, (short)701, 'ʍ');
				AnnCfg.Ⴗ((Control)ႳႤ.Ⴈ, ႣႼ.Ⴜ(1, 365387704, 5), (short)653, 'ʊ');
				num = ⴀ[355] - 54717;
				break;
			case 19:
				DxSpotExt.Ⴀ((Control)ႳႤ.Ⴍ, true, (short)671, 'ʡ');
				PrecisionTimer.Ⴗ((Control)ႳႤ.Ⴍ, new Point(25, 90), 'Ϟ', (short)1014);
				num = ⴐ[251] - 43159;
				break;
			case 39:
				LogFile.Ⴀ((Control)ႳႤ.Ⴍ, UtilsString.Ⴐ(null, 7, 192632791), (short)978, (short)989);
				goto case 5;
			case 5:
				num = 43;
				break;
			case 43:
				ServerIoCfg.ႤႰ((Control)ႳႤ.Ⴍ, new Size(33, 13), 'λ', (short)922);
				num = ⴐ[438] - 37949;
				break;
			case 14:
				ObjectCopierExt.Ⴅ((Control)ႳႤ.Ⴍ, 5, (short)595, 'ɣ');
				AnnCfg.Ⴗ((Control)ႳႤ.Ⴍ, ArcLogInRqstExt.Ⴗ(1706506490, 31, 2), (short)215, 'Ð');
				num = 28;
				break;
			case 28:
				DxSpotExt.Ⴀ((Control)ႳႤ.Ⴃ, true, (short)638, 'ɀ');
				UnZipFiles.Ⴅ((Control)ႳႤ.Ⴃ, new Font(ArcLogInRqstExt.Ⴗ(1706507059, 21, 2), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0), (short)790, (short)776);
				num = ⴗ[47] - 58980;
				break;
			case 31:
				PrecisionTimer.Ⴗ((Control)ႳႤ.Ⴃ, new Point(68, 71), 'Ĳ', (short)282);
				num = 53;
				break;
			case 53:
				LogFile.Ⴀ((Control)ႳႤ.Ⴃ, UtilsString.Ⴐ(null, 3, 192631492), (short)28, (short)19);
				num = 47;
				break;
			case 47:
				ServerIoCfg.ႤႰ((Control)ႳႤ.Ⴃ, new Size(108, 13), 'Ɠ', (short)434);
				num = ⴃႭ[286] - 63488;
				break;
			case 8:
				ObjectCopierExt.Ⴅ((Control)ႳႤ.Ⴃ, 6, (short)980, 'Ϥ');
				AnnCfg.Ⴗ((Control)ႳႤ.Ⴃ, ႣႼ.Ⴜ(8, 365387705, 18), (short)1001, 'Ϯ');
				num = 35;
				break;
			case 35:
				DxSpotExt.Ⴀ((Control)ႳႤ.Ⴐ, true, (short)429, 'Ɠ');
				UnZipFiles.Ⴅ((Control)ႳႤ.Ⴐ, new Font(ArcLogInRqstExt.Ⴗ(1706507058, 21, 3), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0), (short)677, (short)699);
				num = 9;
				break;
			case 9:
				PrecisionTimer.Ⴗ((Control)ႳႤ.Ⴐ, new Point(67, 90), 'Ϩ', (short)960);
				num = ⴀ[321] - ⴀ[321];
				break;
			case 0:
				LogFile.Ⴀ((Control)ႳႤ.Ⴐ, UtilsString.Ⴐ(null, 1, 192631372), (short)142, (short)129);
				num = ⴃႤ[398] - 57207;
				break;
			case 13:
				ServerIoCfg.ႤႰ((Control)ႳႤ.Ⴐ, new Size(88, 13), ' ', (short)1);
				num = ⴀ[356] - 16254;
				break;
			case 22:
				ObjectCopierExt.Ⴅ((Control)ႳႤ.Ⴐ, 7, (short)877, '\u035d');
				AnnCfg.Ⴗ((Control)ႳႤ.Ⴐ, DownloadUrl2.Ⴅ(1, null, 2018868103, 4), (short)379, 'ż');
				num = 49;
				break;
			case 49:
				PrecisionTimer.Ⴗ((Control)Ⴄ, new Point(303, 135), 'Á', (short)233);
				LogFile.Ⴀ((Control)Ⴄ, UtilsString.Ⴐ(null, 2, 192631549), (short)616, (short)615);
				num = 20;
				break;
			case 20:
				ServerIoCfg.ႤႰ((Control)Ⴄ, new Size(75, 23), ',', (short)13);
				ObjectCopierExt.Ⴅ((Control)Ⴄ, 9, (short)998, 'ϖ');
				num = 26;
				break;
			case 26:
			case 44:
				AnnCfg.Ⴗ((Control)Ⴄ, DownloadUrl2.Ⴅ(9, null, 2018867689, 1), (short)930, 'Υ');
				num = 32;
				break;
			case 32:
				LogFile.Ⴄ((ButtonBase)Ⴄ, true, (short)771, 865);
				UtilsCopyright.Ⴃ<Control, EventHandler>(Ⴄ, ႤႤ, 73, 64);
				num = 60;
				break;
			case 60:
				ႣႼ.ႰႥ(ႳႤ.Ⴀ, (Image)TelnetServerClient.ႥႥ((ResourceManager)(ComponentResourceManager)resourceManager, ႣႼ.ႥႭ(null, 624735720, 6, null), 106, '}'), 378, 368);
				num = ⴃႭ[98] - 39544;
				break;
			case 16:
				UnZipFiles.Ⴍ(ႳႤ.Ⴀ, (Image)TelnetServerClient.ႥႥ((ResourceManager)(ComponentResourceManager)resourceManager, ႣႼ.Ⴜ(1, 365387513, 1), 988, 'ϋ'), 158, 199);
				num = 18;
				break;
			case 18:
				PrecisionTimer.Ⴗ((Control)ႳႤ.Ⴀ, new Point(-2, 0), '\u001c', (short)52);
				num = ⴗ[85] - 5447;
				break;
			case 3:
				LogFile.Ⴀ((Control)ႳႤ.Ⴀ, ႣႼ.Ⴜ(3, 365387210, 9), (short)611, (short)620);
				num = ⴃႣ[21] - 1813;
				break;
			case 59:
				ServerIoCfg.ႤႰ((Control)ႳႤ.Ⴀ, new Size(474, 50), 'Ǜ', (short)506);
				num = 15;
				break;
			case 15:
				DgvFilterHost.ႥႰ(ႳႤ.Ⴀ, 10, 323, 343);
				HelpAboutServer.ႷႳ(ႳႤ.Ⴀ, false, 'Ͻ', 975);
				num = 55;
				break;
			case 55:
				PrecisionTimer.Ⴗ((Control)Ⴜ, new Point(0, 0), '\u0094', (short)188);
				Ⴜ.Margin = new Padding(0);
				num = 48;
				break;
			case 48:
			{
				Ⴜ.Name = TelnetServerClient.Ⴄ(1945322586, '\u000f', 8);
				ShapeCollection shapes = Ⴜ.Shapes;
				Array array = new Shape[1];
				((Shape[])array)[0] = ႳႤ.Ⴓ;
				shapes.AddRange(array as Shape[]);
				num = 25;
				break;
			}
			case 25:
				Ⴜ.Size = new Size(471, 166);
				Ⴜ.TabIndex = 11;
				goto case 33;
			case 33:
				num = 10;
				break;
			case 10:
				Ⴜ.TabStop = false;
				ႳႤ.Ⴓ.Name = ႣႼ.ႥႭ(null, 624735706, 5, null);
				num = 52;
				break;
			case 52:
				ႳႤ.Ⴓ.X1 = -7;
				ႳႤ.Ⴓ.X2 = 473;
				num = ⴀ[87] - 54609;
				break;
			case 6:
				ႳႤ.Ⴓ.Y1 = 125;
				ႳႤ.Ⴓ.Y2 = 125;
				num = 2;
				break;
			case 2:
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				base.AutoScaleMode = AutoScaleMode.Font;
				base.ClientSize = new Size(471, 166);
				num = 46;
				break;
			case 46:
				base.Controls.Add(Ⴄ);
				base.Controls.Add(ႳႤ.Ⴐ);
				num = 17;
				break;
			case 17:
				base.Controls.Add(ႳႤ.Ⴃ);
				base.Controls.Add(ႳႤ.Ⴍ);
				num = ⴃႣ[69] - 61595;
				break;
			case 1:
				base.Controls.Add(ႳႤ.Ⴈ);
				base.Controls.Add(ႳႤ.Ⴗ);
				num = 40;
				break;
			case 40:
				base.Controls.Add(ႳႤ.Ⴅ);
				base.Controls.Add(ႳႤ.Ⴀ);
				num = ⴐ[213] - 45888;
				break;
			case 45:
				base.Controls.Add(Ⴜ);
				base.Name = ArcLogInRqstExt.Ⴗ(1706507927, 10, 5);
				num = ⴗ[15] - 33604;
				break;
			case 27:
				Text = DownloadUrl2.Ⴅ(19, null, 2018867604, 5);
				base.Load += ႤႷ;
				num = 7;
				break;
			case 7:
				((ISupportInitialize)ႳႤ.Ⴀ).EndInit();
				ResumeLayout(performLayout: false);
				PerformLayout();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static FrmUpdateAvailable()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static Assembly ႷႥ(int P_0, short P_1)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		_Assembly assembly = default(_Assembly);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[99] - 22228;
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
				case 6:
					num2 = (((P_0 ^ P_1) - 110) ^ num) switch
					{
						0 => ⴀ[343] - 36640, 
						_ => 3, 
					};
					continue;
				case 3:
					assembly = null;
					num2 = 4;
					continue;
				case 0:
				case 7:
					assembly = Assembly.GetExecutingAssembly();
					num2 = 4;
					continue;
				case 4:
				case 5:
				case 9:
				{
					num++;
					int num3 = 2488;
					int num4 = 453;
					num2 = ((622 < num3 / 4 - num4) ? (ⴐ[501] - 23261) : (ⴃႣ[32] - 43997));
					continue;
				}
				case 10:
					return (Assembly)assembly;
				case 1:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႷႷ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : Control
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႤ[252] - 30960;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 1;
					continue;
				case 1:
				case 7:
					break;
				case 10:
					num2 = (((P_1 ^ P_2) - 99) ^ num) switch
					{
						0 => 3, 
						_ => ⴀ[306] - 12945, 
					};
					continue;
				case 4:
					convertible = null;
					num2 = ⴀ[326] - 52084;
					continue;
				case 3:
				case 8:
					convertible = P_0.Text;
					num2 = 11;
					continue;
				case 11:
				{
					num++;
					int num3 = 508;
					int num4 = 788;
					num2 = ((2364 > num4 - num3 * 3) ? 9 : 6);
					continue;
				}
				case 6:
					num2 = 10;
					continue;
				case 5:
				case 9:
					return (string)convertible;
				case 2:
					num2 = ⴗ[39] - 40804;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႷႠ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : IAsyncResult where _0021_00211 : Socket
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int result = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[69] - 53233;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 10:
					break;
				case 3:
					num2 = (((P_3 ^ P_2) - 119) ^ num) switch
					{
						0 => 1, 
						_ => ⴃႣ[23] - 17518, 
					};
					continue;
				case 8:
					result = 8;
					goto case 0;
				case 0:
					num2 = 6;
					continue;
				case 1:
					result = P_0.EndReceive(P_1);
					num2 = ⴃႣ[196] - 52694;
					continue;
				case 6:
					num++;
					num3 = 1317;
					num4 = 376;
					goto case 2;
				case 2:
				case 9:
					num2 = ((439 < num3 / 3 - num4) ? 3 : 7);
					continue;
				case 7:
					return result;
				case 5:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႷႨ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : ExternalException
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int result = default(int);
		int num3 = default(int);
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
					num2 = 4;
					continue;
				case 4:
					break;
				case 9:
				{
					int num4 = P_1 ^ P_2;
					TalkCfg.ႣႣ[75] = (char)(TalkCfg.ႣႣ[75] & P_2 & 0x10);
					num2 = ((num4 - 55) ^ num) switch
					{
						0 => ⴗ[127] - 49523, 
						_ => 11, 
					};
					continue;
				}
				case 11:
					result = P_2;
					num2 = ⴐ[340] - 61517;
					continue;
				case 3:
					result = P_0.ErrorCode;
					num2 = 7;
					continue;
				case 7:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					goto case 5;
				case 5:
				case 8:
					num2 = ⴐ[135] - 62696;
					continue;
				case 2:
					num2 = ((num3 % 2 != 0) ? (ⴃႭ[272] - 8222) : (ⴃႭ[104] - 37836));
					continue;
				case 1:
				case 6:
					return result;
				case 10:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Graphics ႷႰ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : Control
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			int num = 0;
			int num2 = 4;
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
					num2 = (((P_2 ^ P_1) - 121) ^ num) switch
					{
						0 => 5, 
						_ => ⴃႤ[105] - 3381, 
					};
					continue;
				case 1:
				case 9:
					disposable = null;
					num2 = 7;
					continue;
				case 5:
					disposable = P_0.CreateGraphics();
					num2 = ⴀ[219] - 16949;
					continue;
				case 7:
					num++;
					goto case 6;
				case 6:
				{
					int num3 = 100;
					int num4 = 130;
					num2 = ((1040 <= num4 - num3 * 8) ? (ⴐ[590] - 62395) : 0);
					continue;
				}
				case 2:
					num2 = 4;
					continue;
				case 0:
					return disposable as Graphics;
				case 3:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}
}
