using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class ReadMailHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(0, null, 1267022833, typeof(ShowWwv.ႥႣ)));
				goto case 4;
			case 4:
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133316, 2, 'j'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(15, null, 1057162008, 0));
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(7, '{', 952620085));
				obj = new Publisher();
				goto case 6;
			case 6:
				num = 5;
				break;
			case 5:
				((Publisher)obj).Process(cmd);
				return;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static double Ⴗ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : PrecisionTimer
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		double result = default(double);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[60] - 11692;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[243] - 7;
					continue;
				case 1:
				case 3:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 66) ^ num) switch
					{
						0 => ⴄႭ[145] - ⴄႭ[145], 
						_ => ⴀႼ[77] / 2, 
					};
					continue;
				case 11:
					result = 0.8998374893968257;
					num2 = ⴅ[126] - 96;
					continue;
				case 0:
				case 7:
					result = P_0.Duration;
					num2 = 4;
					continue;
				case 4:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴄႷ[139] - 44124) : (ⴃႥ[241] - 26507));
					continue;
				case 10:
					num2 = 6;
					continue;
				case 2:
					return result;
				case 9:
					num2 = ⴀႨ[164] - 38308;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴍ(ref DateTime P_0, double P_1, int P_2, short P_3)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		DateTime dateTime = default(DateTime);
		DateTime result = default(DateTime);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[308] - 22565;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
					break;
				case 5:
					num2 = (((P_2 ^ P_3) - 0) ^ num) switch
					{
						0 => ⴀႣ[329] - 49813, 
						_ => 7, 
					};
					continue;
				case 7:
					dateTime = default(DateTime);
					goto case 0;
				case 0:
					result = dateTime;
					num2 = 2;
					continue;
				case 11:
					result = P_0.AddMinutes(P_1);
					num2 = 2;
					continue;
				case 1:
				case 2:
				case 6:
				{
					num++;
					int num3 = 629;
					int num4 = 955;
					num2 = ((1910 > num4 - num3 * 2) ? 10 : 9);
					continue;
				}
				case 9:
					num2 = ⴀ[383] - 19835;
					continue;
				case 10:
					return result;
				case 8:
					num2 = ⴄႤ[135];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴓ(ref DateTime P_0, short P_1, short P_2)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 7:
					break;
				case 6:
				case 10:
					num2 = (((P_1 ^ P_2) - 64) ^ num) switch
					{
						0 => ⴀႳ[287] - 59546, 
						_ => 0, 
					};
					continue;
				case 0:
					result = 15;
					num2 = 9;
					continue;
				case 2:
				case 4:
					result = P_0.Month;
					num2 = 9;
					continue;
				case 8:
				case 9:
				{
					num++;
					int num3 = 72;
					int num4 = 153;
					num2 = ((918 > num4 - num3 * 6) ? (ⴄႷ[21] - 64085) : 5);
					continue;
				}
				case 5:
					num2 = ⴅ[335] - 117;
					continue;
				case 3:
					return result;
				case 11:
					num2 = ⴄႷ[137] - 63933;
					continue;
				}
				break;
			}
		}
	}
}
