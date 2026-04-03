using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;

namespace Ⴃ;

internal sealed class ႰႣ
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 6)]
	private struct ႰႼ
	{
		[SecuritySafeCritical]
		static ႰႼ()
		{
			UtilsIdentity.Ⴐ();
		}
	}

	internal static ႰႼ Ⴐ/* Not supported: data(3D 00 5B 00 2C 00) */;

	internal static Dictionary<string, int> Ⴅ;

	internal static Dictionary<string, int> Ⴐ;

	internal static Dictionary<string, int> Ⴈ;

	internal static Dictionary<string, int> Ⴃ;

	internal static Dictionary<string, int> Ⴓ;

	internal static Dictionary<string, int> Ⴍ;

	[SecuritySafeCritical]
	static ႰႣ()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
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
					num2 = 4;
					continue;
				case 4:
				case 5:
					break;
				case 1:
					num2 = (((P_3 ^ P_2) - 66) ^ num) switch
					{
						0 => ⴐ[192] - 13904, 
						_ => 8, 
					};
					continue;
				case 8:
					enumerable = null;
					num2 = ⴀ[411] - ⴀ[411];
					continue;
				case 7:
					enumerable = string.Concat(P_0, P_1);
					num2 = ⴃႭ[188] - 1900;
					continue;
				case 0:
				case 9:
					num++;
					goto case 10;
				case 10:
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 11 : (ⴃႭ[198] - 52102));
					continue;
				case 6:
					num2 = ⴗ[127] - 49525;
					continue;
				case 11:
					return (string)enumerable;
				case 3:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Color Ⴗ(short P_0, int P_1)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		Color result = default(Color);
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
					num2 = ⴃႭ[158] - 9175;
					continue;
				case 3:
					break;
				case 2:
					num2 = (((P_1 ^ P_0) - 71) ^ num) switch
					{
						0 => 7, 
						1 => ⴃႤ[571] - 22432, 
						2 => 1, 
						_ => 5, 
					};
					continue;
				case 5:
					result = default(Color);
					goto case 11;
				case 11:
					num2 = ⴃႤ[524] - 23479;
					continue;
				case 7:
					result = SystemColors.InfoText;
					num2 = 4;
					continue;
				case 9:
					result = SystemColors.ActiveCaptionText;
					num2 = 4;
					continue;
				case 1:
				case 12:
					result = Color.Gainsboro;
					num2 = 4;
					continue;
				case 4:
					num++;
					num3 = P_0 * P_0;
					num3 = P_0 + num3;
					num2 = ⴗ[51] - 12334;
					continue;
				case 0:
					num2 = ((num3 % 2 != 0) ? (ⴀ[403] - 52881) : (ⴃႭ[43] - 34342));
					continue;
				case 8:
					return result;
				case 10:
				case 13:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Socket Ⴄ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : IAsyncResult where _0021_00211 : Socket
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[33] - 33389;
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
				case 9:
					num2 = (((P_3 ^ P_2) - 73) ^ num) switch
					{
						0 => 5, 
						_ => 8, 
					};
					continue;
				case 8:
					obj = null;
					num2 = 3;
					continue;
				case 5:
				case 10:
					obj = P_0.EndAccept(P_1);
					num2 = 3;
					continue;
				case 3:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 != 0) ? 1 : (ⴀ[215] - 2685));
					continue;
				case 1:
					num2 = ⴗ[42] - 37004;
					continue;
				case 0:
				case 11:
					return obj as Socket;
				case 7:
					num2 = ⴐ[161] - 4791;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long Ⴜ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : WebResponse
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		long result = default(long);
		int num3 = default(int);
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
					num2 = 6;
					continue;
				case 6:
					break;
				case 8:
					num2 = (((P_1 ^ P_2) - 33) ^ num) switch
					{
						0 => 0, 
						_ => 11, 
					};
					continue;
				case 11:
					result = 10L;
					num2 = ⴀ[55] - 33063;
					continue;
				case 0:
				case 2:
				case 4:
					result = P_0.ContentLength;
					num2 = ⴀ[277] - 60584;
					continue;
				case 1:
				case 3:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴃႣ[105] - 52217;
					continue;
				case 7:
					num2 = ((num3 % 2 != 0) ? (ⴃႣ[214] - 56058) : 9);
					continue;
				case 9:
					return result;
				case 10:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႰႠ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : ToolStripItem where _0021_00211 : string
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 7;
				break;
			case 7:
				num = (((P_3 ^ P_2) - 66) ^ num2) switch
				{
					0 => ⴃႭ[262] - 43405, 
					1 => 2, 
					_ => 8, 
				};
				break;
			case 8:
				num = 3;
				break;
			case 10:
				P_0.Name = P_1;
				num = 3;
				break;
			case 1:
			case 2:
				P_0.Text = P_1;
				goto case 3;
			case 3:
				num2++;
				goto case 4;
			case 4:
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 5 : 6);
				break;
			case 0:
			case 6:
				num = 7;
				break;
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႰႰ(ref Rectangle P_0, char P_1, int P_2)
	{
		int result = default(int);
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
					num2 = 6;
					continue;
				case 4:
				case 6:
					break;
				case 7:
					num2 = (((P_2 ^ P_1) - 85) ^ num) switch
					{
						0 => 2, 
						_ => 3, 
					};
					continue;
				case 3:
				case 5:
					result = P_2;
					num2 = 9;
					continue;
				case 2:
					result = P_0.X;
					num2 = 9;
					continue;
				case 9:
					num++;
					goto case 11;
				case 11:
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 10;
					continue;
				case 10:
					num2 = ((num3 % 2 == 0) ? 1 : 7);
					continue;
				case 1:
					return result;
				case 8:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႰႳ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, int P_3) where _0021_00210 : DxSpot
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				continue;
			case 4:
				num = (((P_3 ^ P_2) - 78) ^ num2) switch
				{
					0 => 2, 
					_ => ⴃႣ[232] - 47283, 
				};
				continue;
			case 0:
			case 1:
			case 8:
				num = 7;
				continue;
			case 2:
				P_0.Bob = P_1;
				break;
			case 7:
				break;
			case 3:
			case 6:
				return;
			}
			num2++;
			int num3 = 576;
			int num4 = 32;
			num = ((288 < num3 / 2 - num4) ? 4 : (ⴐ[320] - 49921));
		}
	}
}
