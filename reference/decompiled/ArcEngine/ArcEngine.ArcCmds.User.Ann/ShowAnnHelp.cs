using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class ShowAnnHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 3;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(3, null, 1267023805, typeof(qslinfoSoapClient)));
				num = ⴀႼ[96];
				continue;
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134485, 7, 'ë'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(21, null, 1057161290, 2));
				num = 0;
				continue;
			case 0:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(5, 'û', 952620963));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 8, 62056493, null));
				num = ⴃႠ[420] - 35534;
				continue;
			case 2:
			case 5:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(8, 1, 1217945452));
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(7, 9, 1217945179));
				num = 7;
				continue;
			case 7:
				obj = new Publisher();
				break;
			case 1:
			case 6:
				break;
			}
			break;
		}
		((Publisher)obj).Process(cmd);
		ShowSunHelp.ႣႠ[47] = (char)((ShowSunHelp.ႣႠ[47] * ShowSunHelp.ႣႠ[82]) & 0xF2);
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴅ(char P_0, short P_1)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		DateTime result = default(DateTime);
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
					num2 = 8;
					continue;
				case 8:
					break;
				case 7:
					num2 = (((P_0 ^ P_1) - 49) ^ num) switch
					{
						0 => ⴄႤ[15] - 47, 
						_ => 9, 
					};
					continue;
				case 3:
				case 9:
					result = default(DateTime);
					num2 = ⴅ[92];
					continue;
				case 4:
				case 6:
					result = DateTime.UtcNow;
					num2 = 11;
					continue;
				case 11:
				{
					num++;
					int num3 = 233;
					int num4 = 321;
					num2 = ((2247 > num4 - num3 * 7) ? 5 : 10);
					continue;
				}
				case 10:
					num2 = 7;
					continue;
				case 0:
				case 5:
					return result;
				case 2:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210>(_0021_00210 P_0, float P_1, char P_2, short P_3) where _0021_00210 : StationCfg
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				break;
			case 0:
				num = (((P_2 ^ P_3) - 111) ^ num2) switch
				{
					0 => ⴃႥ[200] - 30021, 
					_ => ⴃႠ[155] - 34035, 
				};
				break;
			case 9:
				num = ⴀ[172] - 3513;
				break;
			case 2:
			case 5:
				P_0.Lon = P_1;
				goto case 6;
			case 6:
			{
				num2++;
				int num3 = 224;
				int num4 = 982;
				num = ((8838 > num4 - num3 * 9) ? (ⴀႳ[261] - 25325) : (ⴀ[330] - 54207));
				break;
			}
			case 3:
				num = ⴃႠ[243] - 16808;
				break;
			case 1:
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, int P_3) where _0021_00210 : string
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
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
					num2 = ⴀႣ[301] - 4355;
					continue;
				case 0:
					break;
				case 3:
					num2 = (((P_3 ^ P_2) - 86) ^ num) switch
					{
						0 => ⴀ[22] - 41832, 
						_ => 10, 
					};
					continue;
				case 10:
					comparable = null;
					num2 = 5;
					continue;
				case 2:
					comparable = P_0.PadRight(P_1);
					num2 = 5;
					continue;
				case 1:
				case 5:
				{
					num++;
					int num3 = 263;
					int num4 = 974;
					num2 = ((7792 > num4 - num3 * 8) ? 7 : (ⴃႠ[399] - 40900));
					continue;
				}
				case 6:
					num2 = 3;
					continue;
				case 7:
				case 8:
				case 11:
					return (string)comparable;
				case 4:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}
}
