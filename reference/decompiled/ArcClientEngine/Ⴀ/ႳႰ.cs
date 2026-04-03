using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;

namespace Ⴀ;

internal sealed class ႳႰ
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
	private struct ႭႼ
	{
		[SecuritySafeCritical]
		static ႭႼ()
		{
			ArcClientConnectDat.Ⴍ();
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 6)]
	private struct ႠႤ
	{
		[SecuritySafeCritical]
		static ႠႤ()
		{
			ArcClientConnectDat.Ⴍ();
		}
	}

	internal static Dictionary<string, int> Ⴅ;

	internal static Dictionary<string, int> Ⴄ;

	internal static ႭႼ Ⴍ/* Not supported: data(28 00 5B 00 7B 00 3C 00 7E 00 3B 00) */;

	internal static ႠႤ Ⴗ/* Not supported: data(20 00 2F 00 5F 00) */;

	[SecuritySafeCritical]
	static ႳႰ()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, Color P_1, short P_2, int P_3) where _0021_00210 : DataGridViewCellStyle
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				break;
			case 6:
				num = (((P_3 ^ P_2) - 85) ^ num2) switch
				{
					0 => 7, 
					1 => ⴅ[295] - 91, 
					_ => ⴀႠ[115] - 48709, 
				};
				break;
			case 8:
				num = ⴀႠ[116] - 60583;
				break;
			case 7:
				P_0.SelectionBackColor = P_1;
				num = 3;
				break;
			case 4:
			case 9:
				P_0.SelectionForeColor = P_1;
				goto case 1;
			case 1:
			case 3:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 != 0) ? 2 : 0);
				break;
			case 2:
				num = 6;
				break;
			case 0:
			case 10:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DxSpot
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		IEquatable<string> equatable = default(IEquatable<string>);
		int num3 = default(int);
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
					num2 = 15;
					continue;
				case 15:
					break;
				case 7:
				{
					int num4;
					switch (((P_1 ^ P_2) - 83) ^ num)
					{
					default:
					{
						byte num5 = ⴅ[159];
						Bye.Ⴄ[241] = (char)((Bye.Ⴄ[241] + P_2) & 0x73);
						num4 = num5 - 158;
						break;
					}
					case 0:
						num4 = ⴅ[199] - ⴅ[7];
						break;
					case 1:
						num4 = ⴄ[5] - 60820;
						break;
					case 2:
						num4 = ⴗ[39] - 27019;
						break;
					case 3:
						num4 = 8;
						break;
					case 4:
						num4 = 11;
						break;
					case 5:
						num4 = 14;
						break;
					}
					num2 = num4;
					continue;
				}
				case 3:
					equatable = null;
					num2 = 2;
					continue;
				case 12:
					equatable = P_0.ArrlSection;
					num2 = ⴀႠ[63] - 29198;
					continue;
				case 1:
				case 5:
					equatable = P_0.Grid;
					num2 = 2;
					continue;
				case 10:
				case 16:
					equatable = P_0.SpotterCty;
					num2 = 2;
					continue;
				case 0:
				case 8:
					equatable = P_0.Spotter;
					num2 = 2;
					continue;
				case 11:
					equatable = P_0.SpotterNode;
					num2 = 2;
					continue;
				case 14:
					equatable = P_0.SpotterCont;
					num2 = ⴄ[116] - 53601;
					continue;
				case 2:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴅ[18] - 27;
					continue;
				case 9:
					num2 = ((num3 % 2 != 0) ? 7 : 4);
					continue;
				case 4:
					return equatable as string;
				case 6:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, short P_3) where _0021_00210 : DataGridViewLinkColumn
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 3;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴀႠ[126] - 21887;
				break;
			case 7:
				num = (((P_2 ^ P_3) - 14) ^ num3) switch
				{
					0 => ⴀႠ[110] - ⴀႠ[110], 
					_ => 8, 
				};
				break;
			case 6:
			case 8:
				num = 4;
				break;
			case 0:
				P_0.UseColumnTextForLinkValue = P_1;
				goto case 4;
			case 4:
				num3++;
				num2 = P_3 * P_3;
				goto case 5;
			case 5:
				num2 = P_3 + num2;
				num = 1;
				break;
			case 1:
				num = ((num2 % 2 != 0) ? (ⴅ[319] - 131) : (ⴄ[109] - 56959));
				break;
			case 2:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, char P_3) where _0021_00210 : TextWriter where _0021_00211 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_2 ^ P_3) - 63) ^ num2) switch
				{
					0 => ⴅ[185] - 214, 
					_ => ⴗ[86] - 42636, 
				};
				break;
			case 9:
				num = 6;
				break;
			case 2:
			case 7:
				P_0.WriteLine(P_1);
				goto case 6;
			case 6:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? 3 : (ⴄ[234] - 24923));
				break;
			case 0:
				num = 4;
				break;
			case 3:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static char[] Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		Array array = default(Array);
		int num4 = default(int);
		int num3 = default(int);
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
					num2 = 0;
					continue;
				case 0:
					break;
				case 7:
				case 11:
					num2 = (((P_1 ^ P_2) - 13) ^ num) switch
					{
						0 => 10, 
						_ => 6, 
					};
					continue;
				case 6:
					array = null;
					num2 = ⴀႠ[20] - 33391;
					continue;
				case 10:
					array = P_0.ToCharArray();
					num2 = ⴀႠ[101] - 46666;
					continue;
				case 5:
				case 9:
				{
					num++;
					num4 = 610;
					int num5 = num4;
					num3 = num5 * num5;
					num2 = ⴅ[25];
					continue;
				}
				case 2:
					num3 = num4 + num3;
					num2 = ((num3 % 2 != 0) ? 11 : 3);
					continue;
				case 3:
					return (char[])array;
				case 1:
					num2 = ⴀႠ[2] - 58297;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴜ(string[] P_0, int P_1, int P_2)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		object obj = default(object);
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
					num2 = ⴀႠ[35] - 25312;
					continue;
				case 3:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 102) ^ num) switch
					{
						0 => 8, 
						_ => ⴄ[114] / 2, 
					};
					continue;
				case 11:
					obj = null;
					num2 = ⴅ[243] - 100;
					continue;
				case 8:
					obj = string.Concat(P_0);
					num2 = ⴄ[191] - 7656;
					continue;
				case 7:
				{
					num++;
					int num3 = 651;
					num2 = (((num3 * num3 + num3) % 2 != 0) ? 10 : 0);
					continue;
				}
				case 10:
					num2 = ⴄ[248] - 4573;
					continue;
				case 0:
				case 2:
				case 4:
					return (string)obj;
				case 5:
				case 6:
					num2 = ⴄ[239] - 49134;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႭႣ<_0021_00210>(_0021_00210 P_0, byte[] P_1, int P_2, int P_3, short P_4, char P_5) where _0021_00210 : Stream
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 4;
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
				num = (((P_4 ^ P_5) - 90) ^ num2) switch
				{
					0 => 0, 
					_ => ⴗ[88] - 27879, 
				};
				break;
			case 1:
			case 6:
			case 9:
				num = ⴅ[176] / 5;
				break;
			case 0:
				P_0.Write(P_1, P_2, P_3);
				goto case 3;
			case 3:
			{
				num2++;
				int num3 = 890;
				int num4 = 1023;
				num = ((4092 > num4 - num3 * 4) ? (ⴅ[46] - 121) : ⴅ[4]);
				break;
			}
			case 8:
				num = ⴅ[4] / 4;
				break;
			case 5:
			case 7:
				return;
			}
		}
	}
}
