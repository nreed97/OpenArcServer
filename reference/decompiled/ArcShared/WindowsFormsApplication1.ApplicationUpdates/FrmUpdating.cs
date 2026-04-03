using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Resources;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using ArcInterfaces.Spots;
using ArcShared;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Extensions;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using ArcShared.Forms;
using Microsoft.VisualBasic.PowerPacks;
using Ⴃ;

namespace WindowsFormsApplication1.ApplicationUpdates;

public class FrmUpdating : Form
{
	internal sealed class ႠႨ
	{
		internal bool Ⴀ;

		internal string Ⴓ;

		internal float Ⴅ;

		internal string Ⴍ;

		internal ႠႨ()
		{
		}
	}

	private DownloadUrl2 Ⴓ;

	private bool Ⴗ;

	private System.Windows.Forms.Timer Ⴀ;

	private IContainer Ⴅ;

	private Label Ⴍ;

	private Label Ⴃ;

	private Label Ⴜ;

	private PictureBox ႷႷ;

	private Button ႷႠ;

	private string ႷႭ;

	private string ႷႨ;

	private string ႷႣ;

	private UtilsXml.Ⴄ ႳႰ;

	public string Url
	{
		get
		{
			return ႷႭ;
		}
		set
		{
			ႷႭ = value;
		}
	}

	public string FilePath
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			return ႷႨ;
		}
		set
		{
			ႷႨ = value;
		}
	}

	public string WorkPath
	{
		get
		{
			string ⴗႣ = ႷႣ;
			UtilsNumeric.Ⴀ[196] = (char)((UtilsNumeric.Ⴀ[196] * UtilsNumeric.Ⴀ[402]) & 0x2B);
			return ⴗႣ;
		}
		set
		{
			ႷႣ = value;
		}
	}

	public string AppName
	{
		get
		{
			string ⴈ = ႳႰ.Ⴈ;
			DataGridViewColumnSelector.Ⴐ[167] = (char)((DataGridViewColumnSelector.Ⴐ[167] ^ DataGridViewColumnSelector.Ⴐ[247]) & 0x31);
			return ⴈ;
		}
		set
		{
			ႳႰ.Ⴈ = value as string;
		}
	}

	public FrmUpdating()
	{
		ႭႷ();
		Ⴓ = new DownloadUrl2();
		Ⴀ = new System.Windows.Forms.Timer();
		DgvDateColumnFilter.Ⴍ(Ⴀ, 1000, 1008, 'Ϯ');
		Ⴀ.Tick += ႭႰ;
	}

	private void ႭႣ(object P_0, EventArgs P_1)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new Thread(ႭႭ);
				UtilsValidation.Ⴃ((Thread)obj, true, 292, 321);
				goto case 6;
			case 6:
				num = 3;
				break;
			case 3:
				UtilsValidation.Ⴗ((Thread)obj, '\u02d5', 701);
				AnnCfg.Ⴗ((Control)ႳႰ.Ⴃ, ႣႼ.ႥႭ(null, 624735866, 5, null), (short)364, 'ū');
				num = 5;
				break;
			case 5:
				ႳႰ.Ⴓ.Maximum = 100;
				Ⴀ.Enabled = true;
				goto case 0;
			case 0:
			{
				char num2 = ⴗ[130];
				TalkCfg.ႣႣ[156] = (char)((TalkCfg.ႣႣ[156] * TalkCfg.ႣႣ[134]) & 0x66);
				num = num2 - 63631;
				break;
			}
			case 2:
			case 4:
				Cursor = Cursors.WaitCursor;
				return;
			}
		}
	}

	private void ႭႭ()
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴓ.DownloadToFile(Url, FilePath, string.Empty);
				UnZipFiles.UnZip(FilePath, WorkPath);
				break;
			case 2:
			case 3:
				break;
			case 1:
				WwvSpotExt.Ⴀ(FilePath, 983, 923);
				Ⴗ = true;
				return;
			case 0:
				return;
			}
			num = 1;
		}
	}

	private void ႭႤ(object P_0, EventArgs P_1)
	{
		DgvFreqRangeColumnFilter.Ⴅ((Form)this, (short)587, 'ɟ');
	}

	private void ႭႰ(object P_0, EventArgs P_1)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 7;
		double num3 = default(double);
		double num2 = default(double);
		double value = default(double);
		while (true)
		{
			switch (num)
			{
			default:
			{
				int num4;
				if (Ⴗ)
				{
					num4 = 4;
				}
				else
				{
					char num5 = ⴗ[8];
					DxCfg.Ⴗ[66] = (char)((DxCfg.Ⴗ[66] * DxCfg.Ⴗ[112]) & 0x87);
					num4 = num5 - 15538;
				}
				num = num4;
				break;
			}
			case 4:
				WwvCfg.Ⴅ((Control)this, UtilsCallsign.Ⴃ(45, '4'), '©', 220);
				AnnCfg.Ⴗ((Control)ႷႠ, UtilsString.Ⴐ(null, 2, 192632508), (short)346, 'ŝ');
				goto case 0;
			case 0:
				num = ((Ⴓ.Length <= 0) ? 1 : 5);
				break;
			case 5:
				num3 = Ⴓ.Length / 1000000;
				num2 = Ⴓ.Progress / 1000000;
				num = ⴃႣ[103] - 47720;
				break;
			case 10:
				value = Ⴓ.Progress * 100 / Ⴓ.Length;
				goto case 8;
			case 8:
			case 11:
				num = 3;
				break;
			case 3:
			{
				Label ⴐ = ႳႰ.Ⴐ;
				Array array = new string[5];
				((string[])array)[0] = ႣႼ.ႥႭ(null, 624735761, 7, null);
				((string[])array)[1] = StationCfg.Ⴄ(ref num2, ႣႼ.Ⴜ(3, 365387670, 5), 45, 73);
				(array as string[])[2] = ArcLogInRqstExt.Ⴗ(1706506596, 7, 4);
				(array as string[])[3] = StationCfg.Ⴄ(ref num3, ႣႼ.Ⴜ(4, 365387665, 20), 869, 769);
				((string[])array)[4] = ႣႼ.ႥႭ(null, 624735746, 4, null);
				AnnCfg.Ⴗ((Control)ⴐ, DgvDateColumnFilter.Ⴀ((string[])array, 'ȓ', 'Ȱ'), (short)867, '\u0364');
				num = 6;
				break;
			}
			case 6:
				Text = ႣႼ.ႥႭ(null, 624735739, 3, null) + value.ToString(UtilsString.Ⴐ(null, 8, 192631403)) + ႣႼ.Ⴜ(7, 365387692, 30) + AppName;
				num = 9;
				break;
			case 2:
			case 9:
				ႳႰ.Ⴓ.Value = Convert.ToInt32(value);
				return;
			case 1:
				return;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				num = (disposing ? 1 : (ⴀ[377] - 26000));
				continue;
			case 1:
			case 5:
				num = ((Ⴅ == null) ? 2 : 0);
				continue;
			case 0:
				Ⴅ.Dispose();
				break;
			case 2:
				break;
			case 3:
			case 6:
				return;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void ႭႷ()
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 45;
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				obj2 = new ComponentResourceManager(typeof(FrmUpdating));
				Control control3 = new Label();
				ႳႰ.Ⴃ = (Label)control3;
				num = 2;
				break;
			}
			case 2:
			{
				Ⴍ = new Label();
				object obj6 = new Label();
				ႳႰ.Ⴗ = (Label)obj6;
				num = ⴗ[130] - 63587;
				break;
			}
			case 46:
			{
				Ⴃ = new Label();
				Ⴜ = new Label();
				Control control2 = new ProgressBar();
				ႳႰ.Ⴓ = (ProgressBar)control2;
				num = 58;
				break;
			}
			case 58:
			{
				ႷႠ = new Button();
				ႷႷ = new PictureBox();
				object obj5 = new PictureBox();
				ႳႰ.Ⴅ = obj5 as PictureBox;
				num = 39;
				break;
			}
			case 39:
			{
				Control control = new Label();
				ႳႰ.Ⴐ = (Label)control;
				object obj4 = new LineShape();
				ႳႰ.Ⴀ = (LineShape)obj4;
				num = 20;
				break;
			}
			case 20:
			{
				object obj3 = new ShapeContainer();
				ႳႰ.Ⴍ = obj3 as ShapeContainer;
				((ISupportInitialize)ႷႷ).BeginInit();
				num = 64;
				break;
			}
			case 64:
				((ISupportInitialize)ႳႰ.Ⴅ).BeginInit();
				AutoUpdater.Ⴜ((Control)this, 27, '\u0001');
				num = 18;
				break;
			case 18:
			case 33:
				UtilsLatLon.ႷႭ((Control)ႳႰ.Ⴃ, ႰႣ.Ⴗ(220, 148), 23, 85);
				num = 14;
				break;
			case 14:
				PrecisionTimer.Ⴗ((Control)ႳႰ.Ⴃ, new Point(28, 31), 'Ȭ', (short)516);
				num = ⴃႣ[221] - 58036;
				break;
			case 35:
				LogFile.Ⴀ((Control)ႳႰ.Ⴃ, DownloadUrl2.Ⴅ(7, null, 2018867828, 4), (short)405, (short)410);
				num = 62;
				break;
			case 62:
				ServerIoCfg.ႤႰ((Control)ႳႰ.Ⴃ, new Size(363, 28), 'ơ', (short)384);
				num = 34;
				break;
			case 34:
				ObjectCopierExt.Ⴅ((Control)ႳႰ.Ⴃ, 3, (short)361, 'ř');
				AnnCfg.Ⴗ((Control)ႳႰ.Ⴃ, DownloadUrl2.Ⴅ(4, null, 2018868192, 0), (short)9, '\u000e');
				num = 61;
				break;
			case 61:
				DxSpotExt.Ⴀ((Control)Ⴍ, true, (short)491, 'Ǖ');
				PrecisionTimer.Ⴗ((Control)Ⴍ, new Point(51, 75), 'Ʈ', (short)390);
				num = ⴃႭ[225] - 59515;
				break;
			case 27:
				LogFile.Ⴀ((Control)Ⴍ, UtilsString.Ⴐ(null, 5, 192631368), (short)40, (short)39);
				num = 1;
				break;
			case 1:
				ServerIoCfg.ႤႰ((Control)Ⴍ, new Size(38, 13), 'ɨ', (short)585);
				ObjectCopierExt.Ⴅ((Control)Ⴍ, 4, (short)267, 'Ļ');
				goto case 47;
			case 47:
				num = 16;
				break;
			case 16:
			case 65:
				AnnCfg.Ⴗ((Control)Ⴍ, ႣႼ.Ⴜ(4, 365387709, 1), (short)576, 'ɇ');
				num = 25;
				break;
			case 25:
				DxSpotExt.Ⴀ((Control)ႳႰ.Ⴗ, true, (short)810, '\u0314');
				PrecisionTimer.Ⴗ((Control)ႳႰ.Ⴗ, new Point(51, 95), 'Ɖ', (short)417);
				num = 4;
				break;
			case 4:
				LogFile.Ⴀ((Control)ႳႰ.Ⴗ, UtilsString.Ⴐ(null, 3, 192632787), (short)62, (short)49);
				num = 55;
				break;
			case 55:
				ServerIoCfg.ႤႰ((Control)ႳႰ.Ⴗ, new Size(33, 13), 'ƙ', (short)440);
				num = 19;
				break;
			case 19:
				ObjectCopierExt.Ⴅ((Control)ႳႰ.Ⴗ, 5, (short)885, '\u0345');
				AnnCfg.Ⴗ((Control)ႳႰ.Ⴗ, ArcLogInRqstExt.Ⴗ(1706506495, 21, 7), (short)892, 'ͻ');
				num = ⴃႭ[119] - 58716;
				break;
			case 9:
				DxSpotExt.Ⴀ((Control)Ⴃ, true, (short)908, 'β');
				UnZipFiles.Ⴅ((Control)Ⴃ, new Font(ArcLogInRqstExt.Ⴗ(1706507059, 11, 2), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0), (short)168, (short)182);
				num = 12;
				break;
			case 12:
				PrecisionTimer.Ⴗ((Control)Ⴃ, new Point(90, 76), 'ů', (short)327);
				LogFile.Ⴀ((Control)Ⴃ, ႣႼ.Ⴜ(1, 365387208, 7), (short)666, (short)661);
				num = 40;
				break;
			case 40:
				ServerIoCfg.ႤႰ((Control)Ⴃ, new Size(108, 13), 'Ŋ', (short)363);
				ObjectCopierExt.Ⴅ((Control)Ⴃ, 6, (short)813, '\u031d');
				num = 66;
				break;
			case 66:
				AnnCfg.Ⴗ((Control)Ⴃ, ႣႼ.Ⴜ(1, 365387696, 30), (short)372, 'ų');
				num = ⴃႣ[99] - 22208;
				break;
			case 26:
				DxSpotExt.Ⴀ((Control)Ⴜ, true, (short)386, 'Ƽ');
				UnZipFiles.Ⴅ((Control)Ⴜ, new Font(ArcLogInRqstExt.Ⴗ(1706507056, 12, 1), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0), (short)118, (short)104);
				num = 22;
				break;
			case 22:
				PrecisionTimer.Ⴗ((Control)Ⴜ, new Point(89, 95), 'ʉ', (short)673);
				LogFile.Ⴀ((Control)Ⴜ, TelnetServerClient.Ⴄ(1945322576, 'n', 2), (short)356, (short)363);
				num = ⴃႣ[199] - 41511;
				break;
			case 7:
				ServerIoCfg.ႤႰ((Control)Ⴜ, new Size(88, 13), 'Μ', (short)957);
				ObjectCopierExt.Ⴅ((Control)Ⴜ, 7, (short)217, 'é');
				num = 37;
				break;
			case 37:
				AnnCfg.Ⴗ((Control)Ⴜ, DownloadUrl2.Ⴅ(10, null, 2018868097, 2), (short)296, 'į');
				num = ⴗ[88] - 34665;
				break;
			case 57:
				PrecisionTimer.Ⴗ((Control)ႳႰ.Ⴓ, new Point(31, 121), ' ', (short)8);
				num = ⴃႭ[233] - 62723;
				break;
			case 3:
				LogFile.Ⴀ((Control)ႳႰ.Ⴓ, DownloadUrl2.Ⴅ(0, null, 2018868106, 6), (short)90, (short)85);
				num = ⴐ[444] - 44348;
				break;
			case 42:
				ServerIoCfg.ႤႰ((Control)ႳႰ.Ⴓ, new Size(409, 18), 'ʜ', (short)701);
				num = ⴐ[550] - 50692;
				break;
			case 54:
				ObjectCopierExt.Ⴅ((Control)ႳႰ.Ⴓ, 9, (short)650, 'ʺ');
				PrecisionTimer.Ⴗ((Control)ႷႠ, new Point(359, 176), 'ʟ', (short)695);
				num = 11;
				break;
			case 11:
				LogFile.Ⴀ((Control)ႷႠ, DownloadUrl2.Ⴅ(13, null, 2018868144, 7), (short)990, (short)977);
				num = 15;
				break;
			case 15:
				ServerIoCfg.ႤႰ((Control)ႷႠ, new Size(85, 23), 'ϳ', (short)978);
				ObjectCopierExt.Ⴅ((Control)ႷႠ, 11, (short)922, 'Ϊ');
				num = ⴃႤ[9] - 1021;
				break;
			case 50:
				AnnCfg.Ⴗ((Control)ႷႠ, ႣႼ.ႥႭ(null, 624735741, 1, null), (short)596, 'ɓ');
				num = ⴃႭ[267] - 11672;
				break;
			case 44:
				LogFile.Ⴄ((ButtonBase)ႷႠ, true, (short)178, 208);
				UtilsCopyright.Ⴃ<Control, EventHandler>(ႷႠ, ႭႤ, 638, 631);
				num = ⴃႣ[212] - 7525;
				break;
			case 56:
				PrecisionTimer.Ⴗ((Control)ႷႷ, new Point(8, 72), '\u0308', (short)800);
				LogFile.Ⴀ((Control)ႷႷ, ႣႼ.ႥႭ(null, 624735734, 3, null), (short)306, (short)317);
				num = 21;
				break;
			case 21:
				ServerIoCfg.ႤႰ((Control)ႷႷ, new Size(37, 39), '=', (short)28);
				DgvFilterHost.ႥႰ(ႷႷ, 10, 422, 434);
				num = 48;
				break;
			case 48:
				HelpAboutServer.ႷႳ(ႷႷ, false, 'Ϧ', 980);
				ႣႼ.ႰႥ(ႳႰ.Ⴅ, (Image)TelnetServerClient.ႥႥ((ResourceManager)(obj2 as ComponentResourceManager), ႣႼ.ႥႭ(null, 624735724, 2, null), 1006, 'Ϲ'), 423, 429);
				num = ⴃႤ[516] - 16554;
				break;
			case 60:
				UnZipFiles.Ⴍ<PictureBox, Image>(ႳႰ.Ⴅ, null, 699, 738);
				PrecisionTimer.Ⴗ((Control)ႳႰ.Ⴅ, new Point(-2, 0), 'Ϩ', (short)960);
				num = ⴃႤ[228] - 17918;
				break;
			case 53:
				LogFile.Ⴀ((Control)ႳႰ.Ⴅ, UtilsString.Ⴐ(null, 6, 192631545), (short)142, (short)129);
				num = 67;
				break;
			case 67:
				ServerIoCfg.ႤႰ((Control)ႳႰ.Ⴅ, new Size(474, 64), ' ', (short)1);
				num = 24;
				break;
			case 24:
				AutoUpdater.ႨႠ(ႳႰ.Ⴅ, PictureBoxSizeMode.AutoSize, 773, '\u036d');
				DgvFilterHost.ႥႰ(ႳႰ.Ⴅ, 2, 360, 380);
				num = 0;
				break;
			case 0:
				HelpAboutServer.ႷႳ(ႳႰ.Ⴅ, false, 'ó', 193);
				DxSpotExt.Ⴀ((Control)ႳႰ.Ⴐ, true, (short)616, 'ɖ');
				num = ⴐ[180] - 10432;
				break;
			case 59:
				PrecisionTimer.Ⴗ((Control)ႳႰ.Ⴐ, new Point(28, 142), '\r', (short)37);
				num = 28;
				break;
			case 28:
				LogFile.Ⴀ((Control)ႳႰ.Ⴐ, TelnetServerClient.Ⴄ(1945322605, 'ò', 3), (short)998, (short)1001);
				num = 41;
				break;
			case 41:
				ServerIoCfg.ႤႰ((Control)ႳႰ.Ⴐ, new Size(79, 13), '\u0384', (short)933);
				num = ⴐ[170] - 29934;
				break;
			case 17:
				ObjectCopierExt.Ⴅ((Control)ႳႰ.Ⴐ, 12, (short)865, '\u0351');
				AnnCfg.Ⴗ((Control)ႳႰ.Ⴐ, DownloadUrl2.Ⴅ(5, null, 2018868158, 4), (short)78, 'I');
				num = 51;
				break;
			case 51:
				ColumnFilterEventArgs.Ⴜ((Shape)ႳႰ.Ⴀ, ႣႼ.ႥႭ(null, 624735706, 5, null), 978, (short)937);
				num = ⴗ[117] - 12510;
				break;
			case 29:
				ႳႰ.Ⴀ.X1 = -5;
				ႳႰ.Ⴀ.X2 = 475;
				num = ⴀ[300] - 61425;
				break;
			case 13:
				ႳႰ.Ⴀ.Y1 = 164;
				ႳႰ.Ⴀ.Y2 = 164;
				num = 30;
				break;
			case 30:
				ႳႰ.Ⴍ.Location = new Point(0, 0);
				ႳႰ.Ⴍ.Margin = new Padding(0);
				num = ⴀ[110] - 48935;
				break;
			case 5:
				ႳႰ.Ⴍ.Name = TelnetServerClient.Ⴄ(1945322607, '¡', 4);
				num = 63;
				break;
			case 63:
			{
				ShapeCollection shapes = ႳႰ.Ⴍ.Shapes;
				object obj = new Shape[1];
				(obj as Shape[])[0] = ႳႰ.Ⴀ;
				shapes.AddRange((Shape[])obj);
				num = 36;
				break;
			}
			case 36:
				ႳႰ.Ⴍ.Size = new Size(471, 204);
				ႳႰ.Ⴍ.TabIndex = 13;
				num = 38;
				break;
			case 38:
				ႳႰ.Ⴍ.TabStop = false;
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				num = ⴐ[538] - 53377;
				break;
			case 52:
				base.AutoScaleMode = AutoScaleMode.Font;
				base.ClientSize = new Size(471, 204);
				base.Controls.Add(ႳႰ.Ⴃ);
				num = 8;
				break;
			case 8:
				base.Controls.Add(ႳႰ.Ⴐ);
				base.Controls.Add(ႷႠ);
				num = ⴃႣ[114] - 1552;
				break;
			case 43:
				base.Controls.Add(ႷႷ);
				base.Controls.Add(ႳႰ.Ⴓ);
				num = 31;
				break;
			case 31:
				base.Controls.Add(Ⴜ);
				base.Controls.Add(Ⴃ);
				num = 6;
				break;
			case 6:
				base.Controls.Add(ႳႰ.Ⴗ);
				base.Controls.Add(Ⴍ);
				num = 10;
				break;
			case 10:
				base.Controls.Add(ႳႰ.Ⴅ);
				base.Controls.Add(ႳႰ.Ⴍ);
				num = ⴐ[3] - 58476;
				break;
			case 23:
				base.Name = ႣႼ.ႥႭ(null, 624735693, 5, null);
				Text = UtilsString.Ⴐ(null, 7, 192631930);
				num = 49;
				break;
			case 49:
				base.Load += ႭႣ;
				((ISupportInitialize)ႷႷ).EndInit();
				((ISupportInitialize)ႳႰ.Ⴅ).EndInit();
				num = ⴃႭ[177] - 31749;
				break;
			case 32:
				ResumeLayout(performLayout: false);
				PerformLayout();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static FrmUpdating()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static bool ႠႥ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : string where _0021_00211 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႤ[315] - 16714;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 7:
					break;
				case 9:
				{
					int num5;
					switch (((P_2 ^ P_3) - 60) ^ num)
					{
					default:
						num5 = 5;
						break;
					case 0:
					{
						char num3 = ⴗ[134];
						char num4 = ⴗ[134];
						NeedsCfg.ႣႤ[268] = (NeedsCfg.ႣႤ[268] - NeedsCfg.ႣႤ[203]) & 0xD6;
						num5 = num3 - num4;
						break;
					}
					}
					num2 = num5;
					continue;
				}
				case 5:
				case 10:
					result = true;
					num2 = 1;
					continue;
				case 0:
					result = P_0 == P_1;
					num2 = 1;
					continue;
				case 1:
				case 8:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴐ[440] - 56354) : 11);
					continue;
				case 11:
					num2 = 9;
					continue;
				case 2:
				case 4:
					return result;
				case 3:
					num2 = ⴃႣ[182] - 56441;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႷ<_0021_00210>(_0021_00210 P_0, BorderStyle P_1, char P_2, char P_3) where _0021_00210 : TextBoxBase
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 1;
				continue;
			case 1:
				num = (((P_3 ^ P_2) - 98) ^ num2) switch
				{
					0 => ⴗ[88] - 34716, 
					_ => ⴃႣ[136] - 56828, 
				};
				continue;
			case 7:
				num = ⴀ[336] - 2399;
				continue;
			case 6:
				P_0.BorderStyle = P_1;
				goto case 5;
			case 5:
				num2++;
				break;
			case 3:
			case 8:
				break;
			case 0:
			case 2:
				return;
			}
			int num3 = 1878;
			int num4 = 174;
			num = ((626 < num3 / 3 - num4) ? 1 : 0);
		}
	}

	[SecuritySafeCritical]
	internal static AddressFamily ႠႠ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : Socket
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		AddressFamily result = default(AddressFamily);
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 9:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 67) ^ num) switch
					{
						0 => 6, 
						_ => 10, 
					};
					continue;
				case 5:
				case 10:
					result = AddressFamily.Unspecified;
					num2 = ⴗ[80] - 32461;
					continue;
				case 6:
				case 8:
					result = P_0.AddressFamily;
					num2 = ⴃႤ[236] - ⴃႤ[236];
					continue;
				case 0:
				case 1:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴐ[204] - 59672) : 4);
					continue;
				case 4:
					num2 = ⴐ[214] - 10769;
					continue;
				case 11:
					return result;
				case 7:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႰ<_0021_00210, _0021_00211, _0021_00212>(_0021_00211 P_0, _0021_00212 P_1, _0021_00210 P_2, char P_3, char P_4) where _0021_00211 : XmlSerializer where _0021_00212 : XmlWriter
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 5;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 3;
				break;
			case 3:
			case 9:
				num = (((P_4 ^ P_3) - 68) ^ num3) switch
				{
					0 => 0, 
					_ => 6, 
				};
				break;
			case 6:
				num = ⴀ[287] - 5920;
				break;
			case 0:
				P_0.Serialize(P_1, P_2);
				goto case 1;
			case 1:
			case 4:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = 2;
				break;
			case 2:
				num = ((num2 % 2 != 0) ? 3 : 8);
				break;
			case 7:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႠႭ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : XElement
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[12] - 15402;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 1;
					continue;
				case 1:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 72) ^ num) switch
					{
						0 => 10, 
						_ => ⴀ[214] - ⴀ[214], 
					};
					continue;
				case 0:
				case 4:
					obj = null;
					num2 = 8;
					continue;
				case 9:
				case 10:
					obj = P_0.Value;
					num2 = 8;
					continue;
				case 8:
				{
					num++;
					int num3 = 770;
					int num4 = 885;
					num2 = ((7965 > num4 - num3 * 9) ? 6 : (ⴗ[130] - 63628));
					continue;
				}
				case 5:
					num2 = ⴗ[50] - 11834;
					continue;
				case 3:
				case 6:
					return (string)obj;
				case 11:
					num2 = ⴀ[267] - 9741;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႠႤ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : AnnWxSpot
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		IConvertible convertible = default(IConvertible);
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
					num2 = ⴀ[389] - 16036;
					continue;
				case 4:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 0) ^ num) switch
					{
						0 => ⴃႭ[144] - ⴃႭ[144], 
						1 => ⴃႤ[475] - 63714, 
						2 => 8, 
						_ => ⴃႣ[178] - 54140, 
					};
					continue;
				case 10:
					convertible = null;
					num2 = 12;
					continue;
				case 0:
				case 2:
					convertible = P_0.Spotter;
					num2 = ⴗ[26] - 58704;
					continue;
				case 6:
				case 13:
					convertible = P_0.SpotterNode;
					num2 = 12;
					continue;
				case 7:
				case 8:
					convertible = P_0.SpotterCty;
					num2 = 12;
					continue;
				case 12:
				{
					num++;
					int num3 = 553;
					int num4 = 721;
					num2 = ((5047 > num4 - num3 * 7) ? (ⴀ[341] - 32414) : 5);
					continue;
				}
				case 5:
					num2 = 1;
					continue;
				case 3:
					return (string)convertible;
				case 9:
					num2 = ⴀ[350] - 33810;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႠႣ(Color P_0, Color P_1, char P_2, int P_3)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		bool result = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[71] - 17814;
					continue;
				case 5:
					break;
				case 6:
					num2 = (((P_3 ^ P_2) - 122) ^ num) switch
					{
						0 => 3, 
						_ => ⴃႭ[130] - 29244, 
					};
					continue;
				case 10:
					result = true;
					num2 = ⴗ[12] - 35084;
					continue;
				case 3:
				case 4:
					result = P_0 != P_1;
					num2 = 7;
					continue;
				case 7:
				case 9:
					num++;
					num3 = 528;
					num4 = 538;
					goto case 11;
				case 11:
					num2 = ((2152 > num4 - num3 * 4) ? 8 : (ⴃႭ[251] - ⴃႭ[251]));
					continue;
				case 0:
					num2 = 6;
					continue;
				case 8:
					return result;
				case 1:
					num2 = ⴃႤ[73] - 63803;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႳ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, Rectangle P_2, char P_3, int P_4) where _0021_00210 : Graphics where _0021_00211 : Brush
	{
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				break;
			case 0:
				num = (((P_4 ^ P_3) - 122) ^ num2) switch
				{
					0 => 5, 
					_ => 6, 
				};
				break;
			case 6:
				num = 9;
				break;
			case 3:
			case 4:
			case 5:
			case 8:
				P_0.FillRectangle(P_1, P_2);
				goto case 9;
			case 9:
			{
				num2++;
				int num3 = 528;
				int num4 = 538;
				num = ((2152 > num4 - num3 * 4) ? 7 : 2);
				break;
			}
			case 2:
				num = 0;
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႠႼ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		bool result = default(bool);
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
					num2 = ⴃႣ[208] - 34473;
					continue;
				case 10:
					break;
				case 4:
				case 9:
					num2 = (((P_1 ^ P_2) - 106) ^ num) switch
					{
						0 => 0, 
						_ => 1, 
					};
					continue;
				case 1:
					result = true;
					num2 = 5;
					continue;
				case 0:
				case 3:
					result = Convert.ToBoolean(P_0);
					num2 = ⴃႣ[236] - 1747;
					continue;
				case 5:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႤ[388] - 10746) : (ⴃႤ[279] - 51466));
					continue;
				case 7:
					num2 = 9;
					continue;
				case 2:
				case 8:
					return result;
				case 11:
					num2 = ⴗ[33] - 33382;
					continue;
				}
				break;
			}
		}
	}
}
