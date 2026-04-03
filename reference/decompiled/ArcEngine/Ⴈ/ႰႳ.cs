using System;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;

namespace Ⴈ;

internal sealed class ႰႳ
{
	public double Ⴄ;

	public string Ⴍ = string.Empty;

	public double Ⴀ;

	public double Ⴈ;

	internal bool Ⴍ(string[] P_0)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		while (true)
		{
			bool num = Ⴀ(P_0);
			IpLockoutCacheCfg.ႭႭ[196] = (char)((IpLockoutCacheCfg.ႭႭ[196] + IpLockoutCacheCfg.ႭႭ[40]) & 0x84);
			int num2 = ((!num) ? 6 : 4);
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႣ[187] - ⴀႣ[187];
					continue;
				case 0:
					break;
				case 4:
					Ⴄ = SetStationBuddyList.Ⴈ(P_0[0], ')', 8);
					this.Ⴍ = P_0[1];
					num2 = 8;
					continue;
				case 8:
					this.Ⴀ = SetStationBuddyList.Ⴈ(P_0[2], 'ʇ', 678);
					Ⴈ = Convert.ToDouble(P_0[3]);
					num2 = 3;
					continue;
				case 2:
				case 3:
					return true;
				case 6:
				case 7:
					return false;
				}
				break;
			}
		}
	}

	private static bool Ⴀ(string[] P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		while (true)
		{
			int num = ((!ShowWwvHelp.Ⴗ(P_0[0], '\u031d', 825)) ? 10 : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 7;
					continue;
				case 2:
				case 7:
					break;
				case 1:
				case 10:
					TxNodeUserCmd.ႤႷ[101] = (char)(TxNodeUserCmd.ႤႷ[101] & TxNodeUserCmd.ႤႷ[22] & 0xC8);
					return false;
				case 0:
				case 5:
					num = ((CallBlockCacheCfg.Ⴜ(P_0[1], 859, 826) == 0) ? 4 : (ⴃႥ[64] - 26229));
					continue;
				case 3:
					num = ((CallBlockCacheCfg.Ⴜ(P_0[1], 848, 817) <= 4) ? (ⴀႣ[320] - 58349) : 4);
					continue;
				case 4:
					return false;
				case 9:
					num = ((!ShowWwvHelp.Ⴗ(P_0[2], 'ǹ', 477)) ? 6 : (ⴍႤ[461] - 37940));
					continue;
				case 12:
					num = (UtilsNumeric.IsFloat(P_0[3]) ? 11 : 6);
					continue;
				case 6:
					return false;
				case 11:
					return true;
				}
				break;
			}
		}
	}
}
