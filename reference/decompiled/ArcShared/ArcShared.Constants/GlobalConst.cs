using System;
using System.Collections;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Windows.Forms;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;

namespace ArcShared.Constants;

public static class GlobalConst
{
	public const string CrLf = "\r\n";

	public const string Cr = "\r";

	public const string Lf = "\n";

	[SecuritySafeCritical]
	static GlobalConst()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static int Ⴈ(DateTime P_0, DateTime P_1, char P_2, char P_3)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		int result = default(int);
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
					num2 = ⴃႣ[199] - 41508;
					continue;
				case 1:
				case 10:
					break;
				case 2:
				case 5:
					num2 = (((P_3 ^ P_2) - 95) ^ num) switch
					{
						0 => 0, 
						_ => ⴗ[85] - 5447, 
					};
					continue;
				case 3:
					result = 3;
					num2 = 6;
					continue;
				case 0:
				case 11:
					result = DateTime.Compare(P_0, P_1);
					num2 = 6;
					continue;
				case 6:
				{
					num++;
					int num3 = 44;
					int num4 = 136;
					num2 = ((544 > num4 - num3 * 4) ? 8 : 7);
					continue;
				}
				case 7:
					num2 = ⴃႣ[12] - 27348;
					continue;
				case 8:
					return result;
				case 4:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ(int P_0, short P_1)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IEnumerable enumerable = default(IEnumerable);
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
					num2 = 1;
					continue;
				case 1:
					break;
				case 10:
					num2 = (((P_1 ^ P_0) - 15) ^ num) switch
					{
						0 => 5, 
						_ => 0, 
					};
					continue;
				case 0:
				case 7:
					enumerable = null;
					goto case 8;
				case 8:
					num2 = ⴀ[28] - 35534;
					continue;
				case 5:
					enumerable = Environment.MachineName;
					num2 = 2;
					continue;
				case 2:
				{
					num++;
					int num3 = 1752;
					int num4 = 281;
					num2 = ((584 < num3 / 3 - num4) ? 10 : 9);
					continue;
				}
				case 9:
					return enumerable as string;
				case 4:
					num2 = ⴐ[161] - 4783;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : EndPoint where _0021_00211 : Socket
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 0;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀ[143] - 58723;
				continue;
			case 1:
				num = (((P_2 ^ P_3) - 69) ^ num2) switch
				{
					0 => ⴃႣ[182] - 56442, 
					_ => ⴃႣ[70] - 48566, 
				};
				continue;
			case 6:
				num = 3;
				continue;
			case 7:
			case 8:
				P_0.Bind(P_1);
				goto case 3;
			case 3:
			case 5:
				num2++;
				num3 = 3636;
				num4 = 18;
				break;
			case 4:
				break;
			case 2:
				return;
			}
			num = ((909 < num3 / 4 - num4) ? 1 : 2);
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : AnnWxSpot
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 12;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
					break;
				case 12:
					DxCfg.Ⴗ[119] = (char)((DxCfg.Ⴗ[119] * P_1) & 0x7D);
					num2 = (((P_1 ^ P_2) - 18) ^ num) switch
					{
						0 => 11, 
						1 => 4, 
						_ => ⴗ[141] - 5941, 
					};
					continue;
				case 1:
					comparable = null;
					num2 = ⴃႭ[71] - 17809;
					continue;
				case 11:
					comparable = P_0.Msg;
					goto case 0;
				case 0:
					num2 = 10;
					continue;
				case 4:
					comparable = P_0.SysopFlag;
					num2 = ⴗ[134] - 54684;
					continue;
				case 10:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 7;
					continue;
				case 7:
					num2 = ((num3 % 2 != 0) ? (ⴃႣ[72] - 41152) : 8);
					continue;
				case 5:
				case 8:
				case 9:
					return (string)comparable;
				case 6:
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ(ref Size P_0, int P_1, short P_2, int P_3)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴐ[491] - 22729;
				break;
			case 0:
				num = (((P_3 ^ P_2) - 46) ^ num2) switch
				{
					0 => ⴃႣ[65] - 116, 
					_ => 5, 
				};
				break;
			case 5:
				num = 8;
				break;
			case 1:
			case 7:
				P_0.Width = P_1;
				goto case 2;
			case 2:
			case 8:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 9 : (ⴗ[33] - 33387));
				break;
			case 4:
				num = ⴐ[84] - 25862;
				break;
			case 3:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DataGridViewBand
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[288] - 12637;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[288] - 12630;
					continue;
				case 6:
				case 10:
					break;
				case 3:
					num2 = (((P_2 ^ P_1) - 46) ^ num) switch
					{
						0 => 7, 
						_ => ⴀ[350] - 33802, 
					};
					continue;
				case 1:
				case 9:
					result = true;
					num2 = 5;
					continue;
				case 0:
				case 7:
					result = P_0.Visible;
					num2 = ⴀ[292] - 56427;
					continue;
				case 5:
				{
					num++;
					int num3 = 712;
					int num4 = 794;
					num2 = ((7940 > num4 - num3 * 10) ? (ⴃႤ[466] - 65297) : 8);
					continue;
				}
				case 8:
					num2 = ⴀ[178] - 55587;
					continue;
				case 4:
					return result;
				case 11:
					num2 = ⴀ[267] - 9745;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : Timer
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
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
				num = ⴃႭ[8] - 30693;
				continue;
			case 5:
				num = (((P_1 ^ P_2) - 86) ^ num2) switch
				{
					0 => ⴃႤ[166] - 54271, 
					_ => 3, 
				};
				continue;
			case 3:
				num = ⴃႭ[106] - ⴃႭ[106];
				continue;
			case 1:
			case 6:
				P_0.Stop();
				goto case 0;
			case 0:
				num2++;
				num3 = 3488;
				num4 = 109;
				break;
			case 7:
				break;
			case 8:
				return;
			}
			num = ((872 < num3 / 4 - num4) ? (ⴀ[246] - 23128) : (ⴃႭ[65] - 41719));
		}
	}
}
