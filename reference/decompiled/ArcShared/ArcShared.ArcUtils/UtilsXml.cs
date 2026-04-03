using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using System.Xml.Linq;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Arx;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using Microsoft.VisualBasic.PowerPacks;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class UtilsXml
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴄ
	{
		internal PictureBox Ⴅ;

		internal Label Ⴃ;

		internal Label Ⴗ;

		internal ProgressBar Ⴓ;

		internal Label Ⴐ;

		internal LineShape Ⴀ;

		internal ShapeContainer Ⴍ;

		internal string Ⴈ;
	}

	internal sealed class Ⴐ
	{
		internal IContainer Ⴐ;

		internal ToolStrip Ⴄ;

		internal ToolStripButton Ⴗ;

		internal Ⴐ()
		{
		}
	}

	public static string SerializeColor(Color color)
	{
		string format = ႣႼ.Ⴜ(2, 365386233, 2);
		Array array = new object[4];
		(array as object[])[0] = ArxServerClient.Ⴅ(ref color, 598, 587);
		((object[])array)[1] = DgvDateColumnFilter.Ⴜ(ref color, 'ϥ', 1006);
		((object[])array)[2] = ArxServerClient.Ⴅ(ref color, 701, 675);
		((object[])array)[3] = color.B;
		return string.Format(format, array as object[]);
	}

	public static Color DeserializeColor(string color)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		byte alpha = default(byte);
		byte red = default(byte);
		byte green = default(byte);
		byte blue = default(byte);
		while (true)
		{
			Array array = new char[1];
			((char[])array)[0] = ':';
			object obj = ႰႨ.ႨႥ(color, (char[])array, 266, 363);
			while (true)
			{
				IL_0073:
				int num = 0;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႤ[472] - 14252;
						continue;
					case 4:
					case 5:
						break;
					case 7:
						goto IL_0073;
					case 0:
						alpha = Ⴜ((obj as string[])[0], 143, '·');
						red = Ⴜ(((string[])obj)[1], 12, '4');
						num = 2;
						continue;
					case 1:
					case 2:
						green = Ⴜ(((string[])obj)[2], 358, 'Ş');
						blue = byte.Parse((obj as string[])[3]);
						num = 3;
						continue;
					case 3:
						return Color.FromArgb(alpha, red, green, blue);
					}
					break;
				}
				break;
			}
		}
	}

	public static string SerializeFont(Font font)
	{
		return string.Format(ArcLogInRqstExt.Ⴗ(1706507650, 20, 1), ServerIoCfg.ႤႠ(font, 219, 220), DgvCheckBoxColumnFilter.Ⴈ(font, 261, 361).ToString(), font.Style.ToString());
	}

	public static Font DeserializeFont(string font)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IComparable comparable = default(IComparable);
		float emSize = default(float);
		object obj = default(object);
		FontStyle fontStyle = default(FontStyle);
		int num2 = default(int);
		while (true)
		{
			Array array = new char[1];
			((char[])array)[0] = ':';
			Array array2 = ႰႨ.ႨႥ(font, array as char[], 111, 14);
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႤ[0] - 60764;
					continue;
				case 5:
					break;
				case 4:
					comparable = (array2 as string[])[0];
					emSize = StringConstants.Ⴈ(((string[])array2)[1], (IFormatProvider)new CultureInfo(ArcLogInRqstExt.Ⴗ(1706507947, 1, 4)), 491, 511);
					goto case 8;
				case 8:
					num = 2;
					continue;
				case 2:
				{
					string obj2 = (array2 as string[])[2];
					object obj3 = new char[1];
					(obj3 as char[])[0] = ',';
					obj = ႰႨ.ႨႥ(obj2, (char[])obj3, 463, 430);
					num = ⴃႭ[100] - ⴃႭ[100];
					continue;
				}
				case 0:
					fontStyle = Ⴃ(((string[])obj)[0]);
					goto case 6;
				case 6:
					num = ((((string[])obj).Length <= 1) ? 9 : (ⴐ[245] - 13564));
					continue;
				case 12:
					num2 = 1;
					num = 10;
					continue;
				case 1:
					fontStyle |= Ⴃ(Ⴗ(((string[])obj)[num2], 40, '9'));
					num = 3;
					continue;
				case 3:
					num2++;
					num = 10;
					continue;
				case 7:
				case 10:
					num = ((num2 < ((string[])obj).Length) ? 1 : 9);
					continue;
				case 9:
					return new Font((string)comparable, emSize, fontStyle);
				}
				break;
			}
		}
	}

	public static Font DeserializePrinterFont(string font)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		IEquatable<string> equatable = default(IEquatable<string>);
		float emSize = default(float);
		FontStyle style = default(FontStyle);
		while (true)
		{
			object obj = new char[1];
			(obj as char[])[0] = ':';
			object obj2 = ႰႨ.ႨႥ(font, (char[])obj, 552, 585);
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
					break;
				case 2:
				case 4:
				case 5:
					equatable = (obj2 as string[])[0];
					emSize = StringConstants.Ⴈ((obj2 as string[])[1], (IFormatProvider)new CultureInfo(ArcLogInRqstExt.Ⴗ(1706507948, 25, 3)), 267, 287) + 10f;
					num = ⴗ[54] - 64200;
					continue;
				case 3:
					style = Ⴃ((obj2 as string[])[2]);
					goto case 1;
				case 1:
					return new Font(equatable as string, emSize, style);
				}
				break;
			}
		}
	}

	private static FontStyle Ⴃ(string P_0)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		while (true)
		{
			IComparable comparable;
			int num = (((comparable = P_0) == null) ? 3 : (ⴃႤ[272] - 43561));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴐ[127] - 19386;
					continue;
				case 1:
				case 5:
					break;
				case 8:
					num = (FrmUpdating.ႠႥ((string)comparable, ႣႼ.ႥႭ(P_0, 624735473, 6, null), 635, 583) ? (ⴃႤ[120] - 14309) : (ⴐ[124] - 50849));
					continue;
				case 13:
					num = ((!FrmUpdating.ႠႥ(comparable as string, ႣႼ.Ⴜ(3, 365386126, 7), 790, 810)) ? (ⴀ[361] - 23647) : 0);
					continue;
				case 4:
					num = (FrmUpdating.ႠႥ(comparable as string, UtilsString.Ⴐ(null, 2, 192633565), 437, 393) ? 14 : (ⴃႭ[32] - 53232));
					continue;
				case 2:
				case 6:
					num = (FrmUpdating.ႠႥ(comparable as string, ArcLogInRqstExt.Ⴗ(1706507706, 30, 1), 2, 62) ? (ⴐ[505] - 21209) : 9);
					continue;
				case 9:
					num = 3;
					continue;
				case 11:
					return FontStyle.Bold;
				case 0:
				case 7:
					return FontStyle.Italic;
				case 14:
					return FontStyle.Strikeout;
				case 12:
					return FontStyle.Underline;
				case 3:
					return FontStyle.Regular;
				}
				break;
			}
		}
	}

	public static string GetFirstTag(string xml)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num2 = default(int);
		while (true)
		{
			int num = ((AnnWxSpotExt.Ⴅ(xml, 0, 387, 440) != '<') ? 4 : (ⴃႤ[174] - 59344));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 6;
					continue;
				case 6:
					break;
				case 3:
					num2 = UtilsSql.ႨႷ(xml, '>', 824, 885);
					num = ((num2 <= 0) ? 4 : 2);
					continue;
				case 2:
					return xml.Substring(1, num2 - 1);
				case 0:
				case 1:
				case 4:
				case 5:
					return xml;
				}
				break;
			}
		}
	}

	public static string ConvertToLine(string xml)
	{
		while (true)
		{
			int num = ((!AutoUpdater.ႨႰ(xml, ႣႼ.ႥႭ(xml, 624736211, 1, null), 786, 'ͻ')) ? 7 : 5);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 1;
					continue;
				case 1:
					break;
				case 5:
					xml = DgvFilterManager.ႭႭ(xml, TelnetServerClient.Ⴄ(1945322881, 'n', 2), ArcLogInRqstExt.Ⴗ(1706507725, 10, 2), 1006, 908);
					num = 2;
					continue;
				case 2:
					xml = xml.Replace(TelnetServerClient.Ⴄ(1945322898, '\u0006', 6), ArcLogInRqstExt.Ⴗ(1706507720, 13, 7));
					num = 7;
					continue;
				case 6:
				case 7:
					return xml;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static UtilsXml()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static FileInfo[] Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DirectoryInfo
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		Array array = default(Array);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[134] - ⴀ[134];
					continue;
				case 0:
					break;
				case 2:
					num2 = (((P_2 ^ P_1) - 32) ^ num) switch
					{
						0 => ⴀ[221] - 59523, 
						_ => 9, 
					};
					continue;
				case 4:
				case 9:
					array = null;
					num2 = 3;
					continue;
				case 6:
					array = P_0.GetFiles();
					num2 = ⴀ[287] - 5921;
					continue;
				case 3:
					num++;
					num3 = 2109;
					goto case 10;
				case 10:
				{
					int num4 = 433;
					num2 = ((703 < num3 / 3 - num4) ? 2 : 8);
					continue;
				}
				case 8:
					return array as FileInfo[];
				case 1:
				case 7:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Stream Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : WebResponse
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[118] - 463;
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
				case 3:
				case 9:
					num2 = (((P_1 ^ P_2) - 62) ^ num) switch
					{
						0 => 7, 
						_ => ⴀ[302] - 55858, 
					};
					continue;
				case 5:
					obj = null;
					num2 = 4;
					continue;
				case 1:
				case 7:
					obj = P_0.GetResponseStream();
					num2 = 4;
					continue;
				case 4:
					num++;
					num3 = 458;
					num4 = 707;
					goto case 11;
				case 11:
					num2 = ((1414 > num4 - num3 * 2) ? (ⴃႭ[91] - 28862) : (ⴗ[116] - 43236));
					continue;
				case 10:
					num2 = ⴀ[39] - 63121;
					continue;
				case 6:
					return obj as Stream;
				case 2:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static IAsyncResult Ⴅ<_0021_00210, _0021_00211, _0021_00212>(_0021_00211 P_0, _0021_00212 P_1, _0021_00210 P_2, char P_3, int P_4) where _0021_00211 : Socket where _0021_00212 : AsyncCallback
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[187] - 55709;
					continue;
				case 7:
					break;
				case 0:
				case 3:
				case 5:
					num2 = (((P_3 ^ P_4) - 20) ^ num) switch
					{
						0 => 10, 
						_ => 9, 
					};
					continue;
				case 9:
					obj = null;
					num2 = ⴀ[166] - 10219;
					continue;
				case 8:
				case 10:
					obj = P_0.BeginAccept(P_1, P_2);
					num2 = ⴐ[588] - 38897;
					continue;
				case 2:
				{
					num++;
					int num3 = 3720;
					int num4 = 831;
					num2 = ((930 < num3 / 4 - num4) ? (ⴃႣ[96] - 36629) : (ⴀ[317] - 4379));
					continue;
				}
				case 1:
					return obj as IAsyncResult;
				case 4:
					num2 = ⴗ[69] - 49311;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[216] - 57477;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[45] - 54535;
					continue;
				case 4:
					break;
				case 3:
					num2 = (((P_2 ^ P_1) - 17) ^ num) switch
					{
						0 => 2, 
						_ => ⴀ[32] - 38567, 
					};
					continue;
				case 6:
					obj = null;
					num2 = ⴃႤ[515] - 50903;
					continue;
				case 2:
					obj = P_0.Trim();
					num2 = 8;
					continue;
				case 8:
				case 9:
					num++;
					num3 = 82;
					num4 = 179;
					goto case 5;
				case 5:
					num2 = ((716 > num4 - num3 * 4) ? 1 : (ⴀ[303] - 4124));
					continue;
				case 7:
					num2 = 3;
					continue;
				case 1:
				case 11:
					return obj as string;
				case 10:
					num2 = ⴃႣ[35] - 31528;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static XName Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : XElement
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႭ[88] - 34985;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 27) ^ num) switch
					{
						0 => ⴃႣ[93] - 25913, 
						_ => 3, 
					};
					continue;
				case 3:
					obj = null;
					num2 = ⴃႣ[47] - 35630;
					continue;
				case 8:
					obj = P_0.Name;
					num2 = 7;
					continue;
				case 7:
					num++;
					goto case 0;
				case 0:
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴐ[22] - 21213) : 10);
					continue;
				case 5:
				case 10:
					num2 = 1;
					continue;
				case 2:
				case 9:
					return (XName)obj;
				case 4:
					num2 = ⴃႤ[600] - 48683;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : OnIoClientDisconnectEventHandler where _0021_00211 : string
	{
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
				num = 0;
				break;
			case 0:
				num = (((P_2 ^ P_3) - 76) ^ num2) switch
				{
					0 => 7, 
					_ => 6, 
				};
				break;
			case 6:
				num = ⴗ[74] - 30232;
				break;
			case 7:
				P_0(P_1);
				goto case 5;
			case 5:
			{
				num2++;
				int num3 = 41;
				int num4 = 668;
				num = ((2004 > num4 - num3 * 3) ? 1 : (ⴀ[234] - 32554));
				break;
			}
			case 2:
				num = 0;
				break;
			case 1:
			case 3:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte Ⴜ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		byte result = default(byte);
		int num3 = default(int);
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
					num2 = ⴐ[261] - 25214;
					continue;
				case 5:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 56) ^ num) switch
					{
						0 => 8, 
						_ => 9, 
					};
					continue;
				case 9:
					result = 1;
					num2 = 3;
					continue;
				case 8:
					result = byte.Parse(P_0);
					num2 = ⴗ[53] - 64147;
					continue;
				case 1:
				case 3:
					num++;
					num3 = 67;
					goto case 11;
				case 11:
				{
					int num4 = 219;
					num2 = ((1752 > num4 - num3 * 8) ? (ⴐ[22] - 21222) : 10);
					continue;
				}
				case 2:
				case 10:
					num2 = ⴀ[156] - 26365;
					continue;
				case 0:
					return result;
				case 6:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႨႠ<_0021_00210>(_0021_00210 P_0, DataGridViewColumnHeadersHeightSizeMode P_1, int P_2, char P_3) where _0021_00210 : DataGridView
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 3;
				break;
			case 3:
			case 9:
				num = (((P_3 ^ P_2) - 27) ^ num2) switch
				{
					0 => 7, 
					_ => ⴃႭ[235] - 3397, 
				};
				break;
			case 0:
			case 4:
				num = 1;
				break;
			case 7:
			case 8:
				P_0.ColumnHeadersHeightSizeMode = P_1;
				goto case 1;
			case 1:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? 6 : 5);
				break;
			case 5:
				num = ⴀ[211] - 35371;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႨႨ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : DataGridViewColumn where _0021_00211 : string
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႭ[26] - 58110;
				continue;
			case 8:
				num = (((P_2 ^ P_3) - 117) ^ num2) switch
				{
					0 => 5, 
					_ => 2, 
				};
				continue;
			case 2:
				num = 0;
				continue;
			case 5:
			case 7:
				P_0.HeaderText = P_1;
				goto case 0;
			case 0:
			case 1:
				num2++;
				break;
			case 6:
				break;
			case 3:
				return;
			}
			int num3 = 1386;
			int num4 = 415;
			num = ((462 < num3 / 3 - num4) ? (ⴃႣ[110] - 184) : (ⴐ[129] - 20627));
		}
	}
}
