using System;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ZedGraph;

namespace Ⴀ;

internal static class ႥႠ
{
	[StructLayout(LayoutKind.Auto)]
	internal struct ႭႷ
	{
		internal string Ⴅ;

		internal string Ⴄ;

		internal string Ⴗ;

		internal string Ⴈ;
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct ႭႰ
	{
		internal double[] Ⴗ;

		internal double[] Ⴓ;

		internal double[] Ⴐ;
	}

	public static void Ⴗ()
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 0;
		ICustomAttributeProvider customAttributeProvider = default(ICustomAttributeProvider);
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			switch (num)
			{
			default:
				customAttributeProvider = WxFilters.ႭႭ(565, 542);
				goto IL_0033;
			case 2:
				goto IL_0033;
			case 3:
				Ⴍ((string)comparable);
				break;
			case 1:
			case 4:
				break;
			}
			break;
			IL_0033:
			comparable = HighlightCfg.ႳႳ(Ⴅ(customAttributeProvider as Assembly, 483, 479), 'ˣ', 655) + ႥႥ.Ⴅ(1673507105, null, 3);
			num = ⴄ[233] - 29045;
		}
		Ⴀ((string)comparable);
	}

	private static void Ⴍ(string P_0)
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				P_0 = DxFilters.Ⴈ(P_0, ႥႥ.Ⴍ(6, 1580607785, '_', P_0), 163, 251);
				num = 3;
				break;
			case 3:
				num = (DxSpotRates.ႠႼ(P_0, 'Ĳ', 'į') ? (ⴄ[6] - 43984) : 5);
				break;
			case 0:
			case 4:
			case 5:
			case 6:
				Ⴈ(P_0);
				return;
			case 2:
				return;
			}
		}
	}

	private static void Ⴀ(string P_0)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				P_0 = DxFilters.Ⴈ(P_0, WxFilters.Ⴀ(null, 2, 103389121), 68, 28);
				num = 4;
				break;
			case 4:
				num = (DxSpotRates.ႠႼ(P_0, 'ĳ', 'Į') ? (ⴅ[220] - 97) : 0);
				break;
			case 0:
			case 2:
			case 6:
				Ⴐ(P_0);
				return;
			case 3:
			case 5:
				return;
			}
		}
	}

	private static void Ⴈ(string P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new StreamWriter(P_0);
				ႳႰ.Ⴀ((TextWriter)(StreamWriter)obj, WxFilters.Ⴀ(null, 1, 103389175), 368, 'ŏ');
				num = ⴀႠ[99] - 46021;
				break;
			case 3:
				ႳႰ.Ⴀ((TextWriter)(obj as StreamWriter), WxFilters.Ⴀ(null, 7, 103387686), 780, '\u0333');
				goto case 7;
			case 7:
				num = 17;
				break;
			case 17:
				ႳႰ.Ⴀ((TextWriter)(StreamWriter)obj, WxFilters.Ⴀ(null, 8, 103387689), 79, 'p');
				num = ⴗ[97] - ⴗ[97];
				break;
			case 0:
				ႳႰ.Ⴀ((TextWriter)(obj as StreamWriter), ClientCty.Ⴗ('\u0091', 5, 307012418), 280, 'ħ');
				goto case 13;
			case 13:
				num = 6;
				break;
			case 6:
				ႳႰ.Ⴀ((TextWriter)(StreamWriter)obj, WxFilters.Ⴀ(null, 3, 103389113), 728, '\u02e7');
				num = 2;
				break;
			case 2:
			case 8:
				ႳႰ.Ⴀ((TextWriter)(StreamWriter)obj, ႥႥ.Ⴍ(1, 1580607954, '\u0019', P_0), 848, '\u036f');
				num = 4;
				break;
			case 4:
				ႳႰ.Ⴀ((TextWriter)(obj as StreamWriter), WxFilters.Ⴀ(null, 8, 103389106), 204, 'ó');
				num = 15;
				break;
			case 15:
				ႳႰ.Ⴀ((TextWriter)(obj as StreamWriter), ClientCty.Ⴗ('c', 1, 307012536), 852, '\u036b');
				num = ⴅ[102];
				break;
			case 10:
				ႳႰ.Ⴀ((TextWriter)(obj as StreamWriter), WxFilters.Ⴀ(null, 1, 103389115), 101, 'Z');
				num = ⴅ[343] - 108;
				break;
			case 12:
				ႳႰ.Ⴀ((TextWriter)(obj as StreamWriter), ႥႥ.Ⴍ(3, 1580607878, 'c', null), 566, 'ȉ');
				num = ⴄ[101] - 33638;
				break;
			case 11:
				ႳႰ.Ⴀ((TextWriter)(StreamWriter)obj, ႥႥ.Ⴅ(1673507272, null, 6), 992, 'ϟ');
				num = ⴗ[128] - 43518;
				break;
			case 5:
				ႳႰ.Ⴀ((TextWriter)(obj as StreamWriter), WxFilters.Ⴀ(null, 5, 103389119), 871, '\u0358');
				num = 9;
				break;
			case 9:
				ႳႰ.Ⴀ((TextWriter)(StreamWriter)obj, WxFilters.Ⴀ(null, 5, 103388257), 109, 'R');
				num = ⴗ[158] - 28134;
				break;
			case 16:
				ႳႰ.Ⴀ((TextWriter)(StreamWriter)obj, ႥႥ.Ⴍ(1, 1580607606, '3', null), 640, 'ʿ');
				num = 18;
				break;
			case 18:
				(obj as StreamWriter).WriteLine(ႥႥ.Ⴅ(1673507227, null, 7));
				(obj as StreamWriter).WriteLine(WxFilters.Ⴀ(null, 8, 103389106));
				num = 19;
				break;
			case 19:
				(obj as StreamWriter).WriteLine(ClientCty.Ⴗ('ð', 1, 307012422));
				((StreamWriter)obj).WriteLine(ႥႥ.Ⴍ(2, 1580607547, '6', null));
				num = ⴄ[6] - 43972;
				break;
			case 14:
				((StreamWriter)obj).WriteLine(ႥႥ.Ⴅ(1673506900, null, 6));
				((StreamWriter)obj).Close();
				return;
			}
		}
	}

	private static void Ⴐ(string P_0)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 7;
		TextWriter textWriter = default(TextWriter);
		while (true)
		{
			switch (num)
			{
			default:
				textWriter = new StreamWriter(P_0);
				goto case 1;
			case 1:
			case 8:
				ႳႰ.Ⴀ((TextWriter)(textWriter as StreamWriter), ClientCty.Ⴗ('Ñ', 7, 307012588), 971, 'ϴ');
				num = 3;
				break;
			case 3:
				ႳႰ.Ⴀ((TextWriter)(StreamWriter)textWriter, WxFilters.Ⴀ(null, 5, 103387684), 986, 'ϥ');
				num = 10;
				break;
			case 10:
				ႳႰ.Ⴀ((TextWriter)(StreamWriter)textWriter, WxFilters.Ⴀ(null, 0, 103387681), 572, 'ȃ');
				num = ⴅ[13] - 200;
				break;
			case 9:
				ႳႰ.Ⴀ((TextWriter)(StreamWriter)textWriter, ႥႥ.Ⴅ(1673506923, null, 0), 642, 'ʽ');
				num = ⴅ[176] / 3;
				break;
			case 5:
				ႳႰ.Ⴀ((TextWriter)(StreamWriter)textWriter, ClientCty.Ⴗ('å', 5, 307011673), 289, 'Ğ');
				goto case 11;
			case 11:
				num = 0;
				break;
			case 0:
				ႳႰ.Ⴀ((TextWriter)(textWriter as StreamWriter), WxFilters.Ⴀ(null, 3, 103388373), 973, 'ϲ');
				num = 6;
				break;
			case 6:
				ႳႰ.Ⴀ((TextWriter)(textWriter as StreamWriter), ႥႥ.Ⴍ(6, 1580607743, '\u0083', null), 669, 'ʢ');
				num = 2;
				break;
			case 2:
				ႳႰ.Ⴀ((TextWriter)(StreamWriter)textWriter, ႥႥ.Ⴅ(1673506932, null, 2), 13, '2');
				num = 4;
				break;
			case 4:
				(textWriter as StreamWriter).WriteLine(ClientCty.Ⴗ('É', 8, 307011692));
				(textWriter as StreamWriter).WriteLine(WxFilters.Ⴀ(null, 2, 103388365));
				num = 12;
				break;
			case 12:
				(textWriter as StreamWriter).WriteLine(ႥႥ.Ⴍ(1, 1580607717, 'ö', null));
				(textWriter as StreamWriter).Close();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static ႥႠ()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, char P_3) where _0021_00210 : SmtpClient
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႠ[126] - 21894;
				break;
			case 0:
				num = (((P_3 ^ P_2) - 44) ^ num2) switch
				{
					0 => ⴀႠ[84] - 18797, 
					_ => ⴅ[10] - 168, 
				};
				break;
			case 1:
			case 9:
				num = ⴄ[109] - 56962;
				break;
			case 5:
				P_0.UseDefaultCredentials = P_1;
				goto case 2;
			case 2:
			case 6:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 7 : (ⴗ[156] - 48822));
				break;
			case 8:
				num = ⴄ[284] - ⴄ[284];
				break;
			case 4:
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataTableCollection Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DataSet
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[102] - 35212;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 6;
					continue;
				case 6:
					break;
				case 1:
				case 11:
					num2 = (((P_1 ^ P_2) - 5) ^ num) switch
					{
						0 => 3, 
						_ => 10, 
					};
					continue;
				case 9:
				case 10:
					obj = null;
					num2 = 2;
					continue;
				case 3:
				case 8:
					obj = P_0.Tables;
					num2 = 2;
					continue;
				case 2:
				{
					num++;
					int num3 = 107;
					int num4 = 497;
					num2 = ((2982 > num4 - num3 * 6) ? 7 : (ⴀႠ[10] - 7242));
					continue;
				}
				case 4:
					num2 = ⴅ[398] - 149;
					continue;
				case 7:
					return (DataTableCollection)obj;
				case 0:
					num2 = ⴅ[154] - 207;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static XAxis Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : GraphPane
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = 8;
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
				case 8:
					num2 = (((P_1 ^ P_2) - 22) ^ num) switch
					{
						0 => ⴗ[120] - 5082, 
						_ => 6, 
					};
					continue;
				case 6:
					cloneable = null;
					goto case 3;
				case 3:
				case 7:
					num2 = 0;
					continue;
				case 2:
					cloneable = P_0.XAxis;
					num2 = 0;
					continue;
				case 0:
				{
					num++;
					int num3 = 1253;
					int num4 = num3 * num3;
					HighlightCtyCfg.ႠႠ[123] = (char)((HighlightCtyCfg.ႠႠ[123] | P_1) & 0x1F);
					num2 = (((num4 + num3) % 2 == 0) ? 10 : 5);
					continue;
				}
				case 4:
				case 5:
					num2 = 8;
					continue;
				case 10:
					return (XAxis)cloneable;
				case 11:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : Assembly
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		IComparable comparable = default(IComparable);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[110] - 48490;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
					break;
				case 8:
					HighlightCtyCfg.ႠႠ[73] = (char)((HighlightCtyCfg.ႠႠ[73] | UserCmd.Ⴅ[55]) & 0xE0);
					num2 = (((P_1 ^ P_2) - 60) ^ num) switch
					{
						0 => ⴅ[17], 
						_ => 7, 
					};
					continue;
				case 7:
					comparable = null;
					num2 = 1;
					continue;
				case 0:
					comparable = P_0.Location;
					num2 = ⴀႠ[103] - 38478;
					continue;
				case 1:
				case 10:
					num++;
					num3 = 154;
					num4 = 640;
					goto case 3;
				case 3:
					num2 = ((5760 > num4 - num3 * 9) ? 2 : 4);
					continue;
				case 4:
					num2 = 8;
					continue;
				case 2:
					return (string)comparable;
				case 9:
				case 11:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataRow Ⴜ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DataTable
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[290] - ⴄ[295];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[140] - 60682;
					continue;
				case 3:
					break;
				case 7:
					num2 = (((P_2 ^ P_1) - 106) ^ num) switch
					{
						0 => 4, 
						_ => 1, 
					};
					continue;
				case 1:
					obj = null;
					num2 = 5;
					continue;
				case 4:
				case 10:
					obj = P_0.NewRow();
					num2 = 5;
					continue;
				case 0:
				case 5:
					num++;
					num3 = P_1 * P_1;
					goto case 11;
				case 11:
					num3 = P_1 + num3;
					num2 = ⴗ[52] - 21961;
					continue;
				case 9:
					num2 = ((num3 % 2 != 0) ? (ⴀႠ[30] - 50922) : 6);
					continue;
				case 6:
					return (DataRow)obj;
				case 8:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႭႤ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : string where _0021_00211 : Control
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 3;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 0;
				break;
			case 0:
				num = (((P_3 ^ P_2) - 96) ^ num3) switch
				{
					0 => 4, 
					_ => ⴅ[4], 
				};
				break;
			case 8:
				num = 7;
				break;
			case 4:
				P_0.Text = P_1;
				goto case 1;
			case 1:
			case 7:
				num3++;
				goto case 2;
			case 2:
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = ⴄ[6] - 43977;
				break;
			case 9:
				num = ((num2 % 2 == 0) ? 5 : 0);
				break;
			case 5:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte ႭႭ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : DxSpot
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		byte result = default(byte);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[175] - 59449;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
					break;
				case 4:
				case 11:
					num2 = (((P_2 ^ P_1) - 95) ^ num) switch
					{
						0 => ⴄ[91] - 47808, 
						_ => 7, 
					};
					continue;
				case 7:
					result = 20;
					num2 = 10;
					continue;
				case 9:
				{
					result = P_0.SkimWpm;
					char num3 = ⴗ[149];
					UserCmd.Ⴅ[60] = (byte)((UserCmd.Ⴅ[60] | P_2) & 0x6D);
					num2 = num3 - 53671;
					continue;
				}
				case 6:
				case 8:
				case 10:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴄ[43] - 7773) : ⴅ[25]);
					continue;
				case 2:
					num2 = ⴄ[199] - 65149;
					continue;
				case 3:
					return result;
				case 0:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte ႭႠ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : DxSpot
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		byte result = default(byte);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[72] - 15843;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 1;
					continue;
				case 1:
				case 8:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 16) ^ num) switch
					{
						0 => ⴄ[159] - 48362, 
						_ => ⴗ[113] - 53667, 
					};
					continue;
				case 10:
					result = 15;
					goto case 9;
				case 9:
					num2 = ⴗ[38] - ⴗ[38];
					continue;
				case 5:
				case 7:
					result = P_0.SkimDb;
					num2 = 0;
					continue;
				case 0:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 4 : 3);
					continue;
				case 3:
					num2 = 6;
					continue;
				case 4:
					return result;
				case 11:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Thread ႭႳ(int P_0, int P_1)
	{
		CriticalFinalizerObject criticalFinalizerObject = default(CriticalFinalizerObject);
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
					num2 = 10;
					continue;
				case 8:
				case 10:
					break;
				case 6:
					num2 = (((P_0 ^ P_1) - 93) ^ num) switch
					{
						0 => 1, 
						_ => 4, 
					};
					continue;
				case 4:
				case 5:
					criticalFinalizerObject = null;
					num2 = 0;
					continue;
				case 1:
					criticalFinalizerObject = Thread.CurrentThread;
					num2 = 0;
					continue;
				case 0:
				{
					num++;
					int num3 = 2457;
					int num4 = 775;
					num2 = ((819 < num3 / 3 - num4) ? 6 : 7);
					continue;
				}
				case 3:
				case 7:
					return (Thread)criticalFinalizerObject;
				case 2:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႭႨ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DataGridViewCellMouseEventArgs
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 8;
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
				case 8:
					num2 = (((P_2 ^ P_1) - 96) ^ num) switch
					{
						0 => ⴅ[63] - 186, 
						_ => 0, 
					};
					continue;
				case 0:
					result = P_2;
					num2 = 1;
					continue;
				case 9:
					result = P_0.RowIndex;
					num2 = 1;
					continue;
				case 1:
				case 3:
				case 5:
				{
					num++;
					int num3 = 3344;
					int num4 = 725;
					int num5 = num3 / 4 - num4;
					UserCmd.Ⴅ[54] = (byte)((UserCmd.Ⴅ[54] * Bye.Ⴄ[155]) & 4);
					num2 = ((836 < num5) ? ⴅ[4] : 2);
					continue;
				}
				case 2:
					return result;
				case 7:
					num2 = ⴀႠ[63] - 29192;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly ႭႣ(short P_0, char P_1)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[188] - 59970;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႠ[104] - 61261;
					continue;
				case 6:
					break;
				case 1:
				case 7:
					num2 = (((P_1 ^ P_0) - 30) ^ num) switch
					{
						0 => 4, 
						_ => 9, 
					};
					continue;
				case 9:
					obj = null;
					num2 = ⴀႠ[125] - 26173;
					continue;
				case 4:
					obj = Assembly.GetExecutingAssembly();
					num2 = 2;
					continue;
				case 2:
					num++;
					goto case 3;
				case 3:
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					goto case 5;
				case 5:
					num2 = ⴗ[119] - 30787;
					continue;
				case 10:
					num2 = ((num3 % 2 != 0) ? (ⴀႠ[117] - 64728) : (ⴄ[146] - 18545));
					continue;
				case 8:
					return obj as Assembly;
				case 0:
					num2 = ⴀႠ[90] - 47364;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႭႥ<_0021_00210, _0021_00211, _0021_00212>(_0021_00210 P_0, _0021_00211 P_1, _0021_00212 P_2, int P_3, int P_4) where _0021_00210 : AppDomain where _0021_00211 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				break;
			case 2:
				num = (((P_3 ^ P_4) - 54) ^ num2) switch
				{
					0 => 8, 
					_ => 1, 
				};
				break;
			case 1:
			case 4:
				num = 3;
				break;
			case 5:
			case 8:
				P_0.SetData(P_1, P_2);
				goto case 3;
			case 3:
			{
				num2++;
				int num3 = 701;
				int num4 = 756;
				int num5 = num3 * 3;
				Bye.Ⴄ[229] = (char)((Bye.Ⴄ[229] - P_3) & 0xA2);
				num = ((2268 > num4 - num5) ? (ⴄ[91] - 47810) : (ⴀႠ[61] - 26815));
				break;
			}
			case 6:
				num = 2;
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] ႭႼ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : MemoryStream
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		object obj = default(object);
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
					num2 = 5;
					continue;
				case 5:
					break;
				case 11:
					num2 = (((P_1 ^ P_2) - 92) ^ num) switch
					{
						0 => ⴅ[29] - 96, 
						_ => 0, 
					};
					continue;
				case 0:
					obj = null;
					num2 = ⴀႠ[93] - 27759;
					continue;
				case 1:
				case 8:
					obj = P_0.ToArray();
					num2 = ⴅ[154] - 212;
					continue;
				case 6:
					num++;
					goto case 2;
				case 2:
				{
					int num3 = 518;
					int num4 = 1004;
					int num5 = num3 * 3;
					UserCmd.Ⴅ[245] = (byte)((UserCmd.Ⴅ[245] | P_2) & 0xE1);
					num2 = ((3012 > num4 - num5) ? 3 : (ⴅ[220] - 93));
					continue;
				}
				case 7:
					num2 = ⴅ[155] + 7;
					continue;
				case 3:
				case 4:
					return (byte[])obj;
				case 9:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}
}
