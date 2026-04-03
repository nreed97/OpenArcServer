using System;
using System.Drawing;
using System.Net;
using System.Runtime.Serialization;
using System.Security;
using System.Windows.Forms;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.DgvUtils;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class UtilsCopyright
{
	public static string Copyright
	{
		get
		{
			string result = ႣႼ.Ⴜ(1, 365387236, 8);
			TalkCfg.ႣႣ[201] = (char)((TalkCfg.ႣႣ[201] - TalkCfg.ႣႣ[75]) & 0xFC);
			return result;
		}
	}

	[SecuritySafeCritical]
	static UtilsCopyright()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static WebResponse Ⴅ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : WebRequest
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		ISerializable serializable = default(ISerializable);
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
					num2 = ⴗ[140] - 43355;
					continue;
				case 5:
					break;
				case 1:
				case 4:
					num2 = (((P_2 ^ P_1) - 28) ^ num) switch
					{
						0 => ⴃႣ[53] - 65078, 
						_ => 0, 
					};
					continue;
				case 0:
					serializable = null;
					num2 = ⴀ[210] - 35504;
					continue;
				case 11:
					serializable = P_0.GetResponse();
					num2 = ⴗ[72] - 50236;
					continue;
				case 7:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 10 : 9);
					continue;
				case 2:
				case 9:
					num2 = ⴀ[19] - 12905;
					continue;
				case 3:
				case 10:
					return serializable as WebResponse;
				case 6:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : Control where _0021_00211 : EventHandler
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 7;
				continue;
			case 7:
				num = (((P_3 ^ P_2) - 9) ^ num2) switch
				{
					0 => ⴗ[36] - 32128, 
					1 => 9, 
					_ => ⴃႤ[134] - 5901, 
				};
				continue;
			case 3:
			case 4:
				num = 0;
				continue;
			case 6:
				P_0.Click += P_1;
				num = 0;
				continue;
			case 9:
				P_0.TextChanged += P_1;
				break;
			case 0:
				break;
			case 1:
			case 5:
				return;
			}
			num2++;
			int num3 = 195;
			int num4 = 52;
			num = ((65 >= num3 / 3 - num4) ? 1 : 7);
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, DateTimePickerFormat P_1, char P_2, short P_3) where _0021_00210 : DateTimePicker
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 9;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				break;
			case 2:
				num = (((P_2 ^ P_3) - 9) ^ num2) switch
				{
					0 => ⴃႣ[93] - 25913, 
					_ => 1, 
				};
				break;
			case 1:
				num = ⴃႤ[554] - 10978;
				break;
			case 7:
			case 8:
				P_0.Format = P_1;
				goto case 0;
			case 0:
				num2++;
				num3 = 210;
				goto case 6;
			case 6:
			{
				int num4 = 574;
				num = ((4592 > num4 - num3 * 8) ? 3 : 5);
				break;
			}
			case 5:
				num = 2;
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : Version
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int result = default(int);
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
					num2 = ⴀ[219] - 16950;
					continue;
				case 6:
					break;
				case 2:
					num2 = (((P_2 ^ P_1) - 27) ^ num) switch
					{
						0 => 5, 
						_ => 4, 
					};
					continue;
				case 4:
				{
					result = 12;
					char num5 = ⴃႭ[82];
					TalkCfg.ႣႣ[139] = (char)((TalkCfg.ႣႣ[139] ^ P_1) & 0xD9);
					num2 = num5 - 56660;
					continue;
				}
				case 5:
					result = P_0.Major;
					num2 = 9;
					continue;
				case 9:
					num++;
					goto case 8;
				case 8:
					num3 = 366;
					goto case 7;
				case 7:
				case 11:
				{
					int num4 = 611;
					num2 = ((5499 > num4 - num3 * 9) ? (ⴐ[415] - 57869) : 3);
					continue;
				}
				case 3:
					num2 = ⴃႭ[136] - 62995;
					continue;
				case 1:
					return result;
				case 10:
					num2 = ⴐ[481] - 29250;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴐ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DxSpot
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[155] - 35357;
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
				case 0:
				case 5:
					DataGridViewColumnSelector.Ⴐ[293] = (char)(DataGridViewColumnSelector.Ⴐ[293] & TalkCfg.ႣႣ[108] & 0xEF);
					num2 = (((P_2 ^ P_1) - 58) ^ num) switch
					{
						0 => ⴃႤ[243] - 32135, 
						1 => 12, 
						2 => 9, 
						3 => 4, 
						_ => 1, 
					};
					continue;
				case 1:
					convertible = null;
					num2 = ⴗ[50] - 11831;
					continue;
				case 3:
					convertible = P_0.Call;
					num2 = ⴃႭ[272] - 8221;
					continue;
				case 12:
				case 14:
					convertible = P_0.Cont;
					num2 = ⴃႭ[220] - 42477;
					continue;
				case 9:
					convertible = P_0.County;
					goto case 7;
				case 7:
					num2 = 10;
					continue;
				case 4:
					convertible = P_0.State;
					num2 = ⴃႣ[67] - 59371;
					continue;
				case 10:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 13 : (ⴃႣ[20] - 44801));
					continue;
				case 11:
					num2 = 5;
					continue;
				case 13:
					return (string)convertible;
				case 2:
					num2 = ⴃႤ[406] - 38145;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210>(_0021_00210 P_0, Color P_1, int P_2, int P_3) where _0021_00210 : ToolStrip
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴗ[24] - ⴗ[24];
				break;
			case 0:
				num = (((P_3 ^ P_2) - 9) ^ num2) switch
				{
					0 => 6, 
					_ => ⴃႣ[206] - 36151, 
				};
				break;
			case 5:
				num = 8;
				break;
			case 1:
			case 6:
				P_0.BackColor = P_1;
				goto case 4;
			case 4:
			case 8:
				num2++;
				goto case 7;
			case 7:
			{
				int num3 = 397;
				num = (((num3 * num3 + num3) % 2 == 0) ? (ⴃႤ[396] - 9923) : 9);
				break;
			}
			case 9:
				num = ⴐ[54] - 45101;
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static double Ⴍ(double P_0, short P_1, int P_2)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		double result = default(double);
		int num4 = default(int);
		int num5 = default(int);
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
					num2 = 8;
					continue;
				case 8:
					break;
				case 3:
				case 5:
					num2 = (((P_2 ^ P_1) - 40) ^ num) switch
					{
						0 => ⴃႣ[104] - 1858, 
						1 => 6, 
						_ => 2, 
					};
					continue;
				case 2:
					result = 0.3265267428201207;
					num2 = 7;
					continue;
				case 10:
					result = Math.Sin(P_0);
					num2 = ⴗ[31] - 480;
					continue;
				case 6:
					result = Math.Cos(P_0);
					num2 = 7;
					continue;
				case 7:
				case 11:
				{
					int num3 = num;
					TalkCfg.ႣႣ[44] = (char)((TalkCfg.ႣႣ[44] * P_1) & 0x6C);
					num = num3 + 1;
					num4 = 992;
					num5 = 30;
					goto case 0;
				}
				case 0:
					num2 = ((496 < num4 / 2 - num5) ? 3 : 9);
					continue;
				case 9:
					return result;
				case 4:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static TimeSpan Ⴈ(DateTime P_0, DateTime P_1, short P_2, short P_3)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		TimeSpan result = default(TimeSpan);
		int num3 = default(int);
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
					num2 = ⴃႤ[330] - 30406;
					continue;
				case 2:
					break;
				case 1:
					num2 = (((P_2 ^ P_3) - 68) ^ num) switch
					{
						0 => ⴗ[30] - 17778, 
						_ => 7, 
					};
					continue;
				case 7:
					result = default(TimeSpan);
					goto case 0;
				case 0:
					num2 = 11;
					continue;
				case 6:
				case 9:
					result = P_0 - P_1;
					num2 = 11;
					continue;
				case 8:
				case 11:
				{
					int num4 = num;
					DxCfg.Ⴗ[13] = (char)((DxCfg.Ⴗ[13] * UtilsNumeric.Ⴀ[353]) & 0xF8);
					num = num4 + 1;
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					num2 = 4;
					continue;
				}
				case 4:
					num2 = ((num3 % 2 != 0) ? (ⴐ[15] - 19739) : (ⴗ[144] - 45240));
					continue;
				case 5:
					return result;
				case 3:
					num2 = ⴃႣ[42] - 15433;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Rectangle Ⴄ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : Control
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		Rectangle result = default(Rectangle);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[270] - 6474;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 2:
				case 11:
					break;
				case 7:
					num2 = (((P_2 ^ P_1) - 92) ^ num) switch
					{
						0 => 6, 
						_ => 1, 
					};
					continue;
				case 1:
					result = default(Rectangle);
					num2 = ⴃႣ[214] - 56056;
					continue;
				case 6:
					result = P_0.ClientRectangle;
					num2 = ⴀ[400] - 20047;
					continue;
				case 10:
					num++;
					num3 = P_1 * P_1;
					goto case 8;
				case 8:
					num3 = P_1 + num3;
					goto case 3;
				case 3:
					num2 = ⴀ[342] - 32046;
					continue;
				case 5:
					num2 = ((num3 % 2 != 0) ? (ⴀ[250] - 26012) : (ⴃႭ[245] - 52417));
					continue;
				case 9:
					return result;
				case 4:
					num2 = ⴃႭ[109] - 6059;
					continue;
				}
				break;
			}
		}
	}
}
