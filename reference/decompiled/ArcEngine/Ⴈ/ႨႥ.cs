using System.Security;
using System.Threading;
using ArcCallbookExt;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces;

namespace Ⴈ;

internal sealed class ႨႥ
{
	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, ref bool P_1, short P_2, int P_3)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႳ[152] - 25344;
				break;
			case 5:
				num = (((P_3 ^ P_2) - 9) ^ num2) switch
				{
					0 => ⴀႨ[146] - 22246, 
					_ => 8, 
				};
				break;
			case 4:
			case 8:
				num = ⴄႤ[417] - 1;
				break;
			case 1:
				Monitor.Enter(P_0, ref P_1);
				goto case 7;
			case 7:
			case 9:
			{
				num2++;
				int num3 = 597;
				int num4 = 625;
				num = ((6250 > num4 - num3 * 10) ? 6 : ⴐ[21]);
				break;
			}
			case 3:
				num = 5;
				break;
			case 0:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static CallbookExtensionDat Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႠ[131] - 13665;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 4;
					continue;
				case 4:
				case 10:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 93) ^ num) switch
					{
						0 => 3, 
						_ => 6, 
					};
					continue;
				case 6:
					obj = null;
					num2 = 8;
					continue;
				case 0:
				case 3:
					obj = CbExtLookup.GetCallbookExtensionDat(P_0);
					num2 = ⴄႭ[134];
					continue;
				case 8:
					num++;
					goto case 7;
				case 7:
				{
					int num3 = 2124;
					int num4 = 120;
					num2 = ((531 < num3 / 4 - num4) ? (ⴄႷ[61] - 8212) : (ⴀႼ[0] - 48));
					continue;
				}
				case 1:
					return (CallbookExtensionDat)obj;
				case 2:
					num2 = ⴍႭ[52] - 66;
					continue;
				}
				break;
			}
		}
	}
}
