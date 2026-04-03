using System;
using System.Data;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcDatabase;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;

namespace Ⴈ;

internal sealed class ႨႰ
{
	internal static int Ⴗ(CommandType P_0, string P_1)
	{
		return AccessHelper.ExecuteNonQuery(Ⴈ(), P_0, P_1);
	}

	internal static string Ⴈ()
	{
		return ႨႨ.Ⴀ(13, 1, 1157899629);
	}

	[SecuritySafeCritical]
	internal static bool Ⴄ(short P_0, short P_1)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		bool result = default(bool);
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
					num2 = ⴍႭ[318] - 10048;
					continue;
				case 2:
					break;
				case 3:
				case 9:
				{
					int num5;
					switch (((P_0 ^ P_1) - 88) ^ num)
					{
					default:
					{
						int num6 = ⴍႤ[210];
						BandModeCacheCfg.ႠႳ[54] = (char)((BandModeCacheCfg.ႠႳ[54] ^ P_1) & 0xBE);
						num5 = num6 - 16109;
						break;
					}
					case 0:
						num5 = ⴄႷ[70] - 5439;
						break;
					}
					num2 = num5;
					continue;
				}
				case 4:
					result = false;
					num2 = 1;
					continue;
				case 0:
					result = UtilsValidation.LicenseFilePresent();
					num2 = 1;
					continue;
				case 1:
				case 8:
					num++;
					goto case 5;
				case 5:
				{
					int num3 = 1474;
					int num4 = 296;
					num2 = ((737 < num3 / 2 - num4) ? 3 : (ⴀ[208] - 20755));
					continue;
				}
				case 6:
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
	internal static int Ⴀ(ref DateTime P_0, int P_1, int P_2)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
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
					num2 = ⴀႣ[105] - 53606;
					continue;
				case 4:
				case 7:
					break;
				case 2:
					num2 = (((P_2 ^ P_1) - 78) ^ num) switch
					{
						0 => 11, 
						_ => ⴀ[192] - 29306, 
					};
					continue;
				case 10:
					result = 1;
					num2 = 9;
					continue;
				case 11:
					result = P_0.Minute;
					num2 = 9;
					continue;
				case 9:
					num++;
					goto case 8;
				case 8:
					num3 = 136;
					goto case 1;
				case 1:
				{
					int num4 = 157;
					num2 = ((628 > num4 - num3 * 4) ? (ⴃႠ[3] - 45664) : 6);
					continue;
				}
				case 6:
					num2 = ⴄႷ[61] - 8219;
					continue;
				case 0:
					return result;
				case 3:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}
}
