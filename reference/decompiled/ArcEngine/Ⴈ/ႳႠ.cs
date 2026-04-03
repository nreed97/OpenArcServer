using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared;
using HtmlAgilityPack;

namespace Ⴈ;

internal sealed class ႳႠ
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct ႨႼ
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 6)]
	private struct ႷႣ
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
	private struct ႷႥ
	{
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴜ
	{
		internal DateTime Ⴐ;
	}

	internal static Dictionary<string, int> Ⴈ;

	internal static Dictionary<string, int> Ⴃ;

	internal static Dictionary<string, int> Ⴍ;

	internal static Dictionary<string, int> Ⴓ;

	internal static Dictionary<string, int> Ⴗ;

	internal static Dictionary<string, int> Ⴐ;

	internal static Dictionary<string, int> Ⴅ;

	internal static ႨႼ Ⴃ/* Not supported: data(01 02 03 04 05 06 07 08 09 10 11 12 13 14 15 16) */;

	internal static ႨႼ Ⴅ/* Not supported: data(02 03 04 05 06 07 08 09 10 11 12 13 14 15 16 17) */;

	internal static Dictionary<string, int> Ⴀ;

	internal static ႷႣ Ⴃ/* Not supported: data(20 00 2F 00 5F 00) */;

	internal static ႷႥ Ⴍ/* Not supported: data(28 00 5B 00 7B 00 3C 00 7E 00 3B 00) */;

	[SecuritySafeCritical]
	internal static string Ⴄ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : HtmlNode
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႳ[283] - 19808;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[21];
					continue;
				case 3:
					break;
				case 11:
					num2 = (((P_1 ^ P_2) - 72) ^ num) switch
					{
						0 => ⴍႭ[370] - 25905, 
						1 => 8, 
						_ => 5, 
					};
					continue;
				case 2:
				case 5:
					enumerable = null;
					num2 = 1;
					continue;
				case 7:
					enumerable = P_0.Id;
					num2 = ⴐ[180] - 192;
					continue;
				case 8:
					enumerable = P_0.InnerHtml;
					num2 = 1;
					continue;
				case 1:
				case 10:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 9 : (ⴍႭ[281] - 23361));
					continue;
				case 6:
					num2 = 11;
					continue;
				case 4:
				case 9:
					return enumerable as string;
				case 0:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႰႥ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : string where _0021_00211 : ServerIoCfg
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 1;
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_3 ^ P_2) - 38) ^ num4) switch
				{
					0 => ⴀႨ[211] - 16886, 
					1 => ⴀႳ[48] - 16489, 
					2 => ⴄႤ[81] / 4, 
					_ => ⴃႠ[416] - 8138, 
				};
				break;
			case 5:
				num = ⴀႳ[239] - 27211;
				break;
			case 2:
			case 10:
				P_0.Description = P_1;
				num = ⴅ[391] - 104;
				break;
			case 0:
			case 11:
				P_0.LoginErrorMsg = P_1;
				num = ⴀႼ[138] - 62;
				break;
			case 9:
				P_0.DefaultWxFilter = P_1;
				goto case 6;
			case 6:
			{
				num4++;
				num3 = 1393;
				int num5 = num3;
				num2 = num5 * num5;
				num = 8;
				break;
			}
			case 3:
			case 8:
				num2 = num3 + num2;
				num = ((num2 % 2 != 0) ? 4 : (ⴅ[281] - 229));
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႰႰ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : ServerIoCfg where _0021_00211 : string
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				continue;
			case 0:
				num = (((P_2 ^ P_3) - 124) ^ num2) switch
				{
					0 => 6, 
					_ => 7, 
				};
				continue;
			case 7:
				num = 2;
				continue;
			case 1:
			case 5:
			case 6:
				P_0.DefaultAnnFilter = P_1;
				goto case 2;
			case 2:
				num2++;
				break;
			case 4:
				break;
			case 3:
				return;
			}
			int num3 = 297;
			int num4 = 11;
			int num6;
			if (99 >= num3 / 3 - num4)
			{
				int num5 = ⴍႤ[59];
				IpLockoutCacheCfg.ႭႭ[201] = (char)((IpLockoutCacheCfg.ႭႭ[201] + IpLockoutCacheCfg.ႭႭ[208]) & 0xA3);
				num6 = num5 - 53754;
			}
			else
			{
				num6 = 0;
			}
			num = num6;
		}
	}
}
