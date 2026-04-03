using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Security;
using System.Windows.Forms;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;

namespace ArcShared;

public sealed class StringConstants
{
	internal sealed class Ⴀ
	{
		internal DataGridView Ⴃ;

		internal CheckedListBox Ⴍ;

		internal ToolStripDropDown Ⴄ;

		internal Ⴀ()
		{
		}
	}

	public const string Spacer = "   ";

	private StringConstants()
	{
	}

	[SecuritySafeCritical]
	static StringConstants()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, AnchorStyles P_1, char P_2, int P_3) where _0021_00210 : Control
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴐ[180] - ⴐ[180];
				break;
			case 0:
				num = (((P_3 ^ P_2) - 14) ^ num2) switch
				{
					0 => 5, 
					_ => ⴃႤ[355] - 17423, 
				};
				break;
			case 2:
				num = 1;
				break;
			case 5:
				P_0.Anchor = P_1;
				goto case 1;
			case 1:
			case 4:
			{
				num2++;
				int num3;
				if ((P_2 * P_2 + P_2) % 2 != 0)
				{
					num3 = 7;
				}
				else
				{
					char num4 = ⴐ[76];
					NeedsCfg.ႣႤ[318] = (NeedsCfg.ႣႤ[318] - NeedsCfg.ႣႤ[173]) & 0xFE;
					num3 = num4 - 5890;
				}
				num = num3;
				break;
			}
			case 7:
			case 8:
				num = 0;
				break;
			case 6:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႭ[130] - 29250;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[180] - 10490;
					continue;
				case 1:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 15) ^ num) switch
					{
						0 => 5, 
						1 => 8, 
						_ => 12, 
					};
					continue;
				case 12:
					result = true;
					num2 = 2;
					continue;
				case 5:
					result = File.Exists(P_0);
					goto case 10;
				case 10:
					num2 = ⴐ[285] - 32144;
					continue;
				case 6:
				case 8:
					result = string.IsNullOrEmpty(P_0);
					num2 = 2;
					continue;
				case 2:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 0;
					continue;
				case 0:
					num2 = ((num3 % 2 != 0) ? 4 : 9);
					continue;
				case 7:
				case 9:
					return result;
				case 11:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴄ(int P_0, char P_1)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		bool result = default(bool);
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
					num2 = ⴃႤ[572] - 58681;
					continue;
				case 6:
					break;
				case 0:
					num2 = (((P_0 ^ P_1) - 43) ^ num) switch
					{
						0 => ⴗ[5] - 11052, 
						_ => ⴀ[168] - 49802, 
					};
					continue;
				case 2:
					result = true;
					goto case 11;
				case 11:
					num2 = 1;
					continue;
				case 5:
				case 9:
					result = Socket.OSSupportsIPv6;
					num2 = 1;
					continue;
				case 1:
				case 10:
				{
					num++;
					int num3 = 66;
					int num4 = 112;
					num2 = ((672 > num4 - num3 * 6) ? (ⴐ[15] - 19732) : (ⴀ[285] - 19060));
					continue;
				}
				case 7:
					num2 = ⴃႤ[524] - ⴃႤ[524];
					continue;
				case 8:
					return result;
				case 3:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Size Ⴗ(Size P_0, Size P_1, short P_2, char P_3)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		Size result = default(Size);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[350] - 33809;
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
				case 2:
					num2 = (((P_2 ^ P_3) - 70) ^ num) switch
					{
						0 => 6, 
						_ => 10, 
					};
					continue;
				case 10:
					result = P_0;
					num2 = ⴃႣ[166] - 48244;
					continue;
				case 6:
					result = Size.Subtract(P_0, P_1);
					num2 = ⴗ[15] - 33622;
					continue;
				case 5:
				case 9:
					num++;
					num3 = 1674;
					num4 = 221;
					goto case 3;
				case 3:
				{
					int num5 = num3 / 3;
					int num6 = num4;
					DataGridViewColumnSelector.Ⴐ[167] = (char)((DataGridViewColumnSelector.Ⴐ[167] + P_2) & 0xF9);
					num2 = ((558 < num5 - num6) ? 2 : (ⴗ[144] - 45245));
					continue;
				}
				case 0:
					return result;
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
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : Process
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		IComparable comparable = default(IComparable);
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
					num2 = ⴀ[198] - 33780;
					continue;
				case 0:
					break;
				case 3:
					num2 = (((P_2 ^ P_1) - 80) ^ num) switch
					{
						0 => 8, 
						_ => 10, 
					};
					continue;
				case 10:
					comparable = null;
					num2 = ⴃႭ[21] - 64599;
					continue;
				case 1:
				case 8:
					comparable = P_0.ProcessName;
					num2 = 4;
					continue;
				case 4:
				case 5:
				case 6:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴀ[332] - 59874) : 9);
					continue;
				case 9:
					num2 = ⴀ[31] - 18974;
					continue;
				case 2:
					return (string)comparable;
				case 11:
					num2 = ⴃႭ[161] - 54238;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float Ⴈ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : string where _0021_00211 : IFormatProvider
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		float result = default(float);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[381] - 53539;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႤ[116] - 199;
					continue;
				case 10:
					break;
				case 2:
					num2 = (((P_3 ^ P_2) - 20) ^ num) switch
					{
						0 => ⴃႣ[136] - 56835, 
						_ => 8, 
					};
					continue;
				case 4:
				case 8:
					result = 0.52278936f;
					num2 = 7;
					continue;
				case 0:
					result = Convert.ToSingle(P_0, P_1);
					num2 = 7;
					continue;
				case 7:
					num++;
					num3 = 148;
					goto case 9;
				case 9:
				{
					int num4 = 417;
					num2 = ((3336 > num4 - num3 * 8) ? (ⴃႤ[315] - 16722) : (ⴀ[221] - 59518));
					continue;
				}
				case 11:
					num2 = 2;
					continue;
				case 1:
				case 3:
					return result;
				case 6:
					num2 = ⴃႤ[449] - 61463;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Brush Ⴃ(int P_0, char P_1)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		IDisposable disposable = default(IDisposable);
		int num4 = default(int);
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
					num2 = 11;
					continue;
				case 11:
					break;
				case 2:
				case 3:
					num2 = (((P_0 ^ P_1) - 2) ^ num) switch
					{
						0 => 10, 
						_ => 5, 
					};
					continue;
				case 5:
					disposable = null;
					num2 = 1;
					continue;
				case 7:
				case 10:
					disposable = Brushes.White;
					num2 = ⴗ[80] - 32460;
					continue;
				case 1:
					num++;
					num4 = P_1 * P_1;
					num4 = P_1 + num4;
					num2 = 9;
					continue;
				case 4:
				case 9:
					num2 = ((num4 % 2 != 0) ? 2 : 0);
					continue;
				case 0:
					return disposable as Brush;
				case 6:
				{
					char num3 = ⴗ[157];
					TalkCfg.ႣႣ[226] = (char)(TalkCfg.ႣႣ[226] & DataGridViewColumnSelector.Ⴐ[611] & 0xCF);
					num2 = num3 - 44221;
					continue;
				}
				}
				break;
			}
		}
	}
}
