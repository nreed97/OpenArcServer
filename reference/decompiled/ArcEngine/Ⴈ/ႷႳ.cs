using System.Collections;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared;
using ArcShared.ArcCfg;

namespace Ⴈ;

internal sealed class ႷႳ
{
	public static void Ⴍ(ArcConnect P_0, NodeUserCmd P_1)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
			case 4:
				return;
			}
			if (StationHelp.Ⴃ(ShowHeading.Ⴅ(P_0.Cfg, 551, 547), 165, 150) == OutputType.Off)
			{
				num = ⴀႼ[50] - 97;
				continue;
			}
			while (true)
			{
				OutputType outputType = StationHelp.Ⴃ(ShowHeading.Ⴅ(P_0.Cfg, 419, 423), 633, 586);
				int num2 = ⴀႼ[113];
				while (true)
				{
					int num3;
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 0:
					case 4:
					case 7:
						break;
					case 2:
						num3 = ((outputType != OutputType.On) ? 1 : 3);
						goto IL_00b6;
					case 1:
					case 6:
						return;
					case 3:
						P_0.ႠႣ(P_1.Tx.Msg);
						return;
					}
					break;
					IL_00b6:
					num2 = num3;
				}
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210>(ref double P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႨ[199] - 25201;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႤ[50] / 3;
					continue;
				case 8:
					break;
				case 4:
					num2 = (((P_3 ^ P_2) - 21) ^ num) switch
					{
						0 => ⴍႭ[239] - 12401, 
						_ => ⴐ[204], 
					};
					continue;
				case 6:
					enumerable = null;
					num2 = ⴀႣ[248] - 37922;
					continue;
				case 7:
				case 10:
					enumerable = P_0.ToString(P_1);
					num2 = 0;
					continue;
				case 0:
					num++;
					goto case 5;
				case 5:
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴍႤ[438] - 42476) : (ⴄႷ[20] - 44133));
					continue;
				case 9:
					num2 = 4;
					continue;
				case 11:
					return enumerable as string;
				case 2:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, char P_3) where _0021_00210 : ServerIoCfg
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႨ[44] - 6922;
				break;
			case 5:
			case 9:
				num = (((P_2 ^ P_3) - 74) ^ num2) switch
				{
					0 => ⴍႤ[318] - 30265, 
					_ => 7, 
				};
				break;
			case 0:
			case 7:
				num = ⴅ[423] - ⴅ[172];
				break;
			case 1:
				P_0.Port = P_1;
				goto case 8;
			case 8:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴄႤ[333] - 240) : 2);
				break;
			case 2:
				num = ⴀႼ[33];
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : ServerIoCfg where _0021_00211 : string
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 3;
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴀႨ[118] - 41571;
				continue;
			case 2:
				num = (((P_3 ^ P_2) - 106) ^ num3) switch
				{
					0 => 9, 
					1 => ⴃႰ[57] - 49577, 
					_ => ⴃႥ[72] - 18623, 
				};
				continue;
			case 8:
				num = 1;
				continue;
			case 9:
				P_0.WelcomeLoginFile = P_1;
				goto case 0;
			case 0:
				num = 1;
				continue;
			case 6:
				P_0.LogoutMsg = P_1;
				goto case 1;
			case 1:
			{
				int num2 = num3;
				SetAnnMode.ႤႭ[216] = (byte)((SetAnnMode.ႤႭ[216] ^ P_3) & 0x57);
				num3 = num2 + 1;
				break;
			}
			case 5:
				break;
			case 4:
			case 7:
				return;
			}
			int num4 = 1767;
			int num5 = 323;
			num = ((589 < num4 / 3 - num5) ? 2 : 4);
		}
	}
}
