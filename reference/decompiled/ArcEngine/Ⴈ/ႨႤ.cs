using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;

namespace Ⴈ;

internal sealed class ႨႤ
{
	private int[] m_Ⴃ;

	[SpecialName]
	internal int[] Ⴃ()
	{
		return this.m_Ⴃ;
	}

	[SpecialName]
	internal void Ⴗ(int[] P_0)
	{
		this.m_Ⴃ = P_0;
	}

	[SpecialName]
	internal int Ⴄ()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		while (true)
		{
			int num = 0;
			int num2 = 0;
			int num3 = ⴀႳ[96] - 54403;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = ⴅ[134] - 54;
					continue;
				case 4:
					break;
				case 0:
					num += Ⴃ()[num2];
					goto case 7;
				case 7:
					num2++;
					num3 = 3;
					continue;
				case 1:
				case 3:
				case 6:
					num3 = ((num2 < 10) ? (ⴄႤ[31] - ⴄႤ[31]) : 5);
					continue;
				case 5:
					return num * 10;
				}
				break;
			}
		}
	}

	internal ႨႤ()
	{
		Ⴗ(new int[11]);
	}

	internal void Ⴍ()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				goto case 0;
			case 0:
			{
				char num3 = ⴃႰ[89];
				IpLockoutCacheCfg.ႭႭ[155] = (char)((IpLockoutCacheCfg.ႭႭ[155] + TxNodeUserCmd.ႤႷ[52]) & 0x76);
				num = num3 - 30448;
				break;
			}
			case 2:
				Ⴃ()[num2] = Ⴃ()[num2 + 1];
				num = 7;
				break;
			case 7:
				num2++;
				num = ⴐ[204];
				break;
			case 4:
			case 6:
				num = ((num2 < 10) ? (ⴀႳ[218] - 25756) : (ⴃႠ[338] - 60202));
				break;
			case 1:
			case 5:
				Ⴃ()[10] = 0;
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, CipherMode P_1, char P_2, char P_3) where _0021_00210 : SymmetricAlgorithm
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 7;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				continue;
			case 0:
				num = (((P_3 ^ P_2) - 111) ^ num2) switch
				{
					0 => ⴍႤ[404] - 20855, 
					_ => ⴄႷ[135] - 15686, 
				};
				continue;
			case 6:
				num = ⴍႤ[474] - 65085;
				continue;
			case 4:
				P_0.Mode = P_1;
				goto case 8;
			case 8:
				num2++;
				goto case 1;
			case 1:
				num3 = 1056;
				num4 = 121;
				break;
			case 5:
				break;
			case 2:
			case 3:
				return;
			}
			num = ((352 >= num3 / 3 - num4) ? 2 : 0);
		}
	}
}
