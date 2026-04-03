using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.ArcCmds.Talk;

public sealed class TalkSpotHelp : IArcCmd
{
	internal sealed class Ⴐ
	{
		internal bool Ⴈ;

		internal string Ⴄ;

		internal string Ⴃ;

		internal string Ⴀ;

		internal Ⴐ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		int num = 3;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(2, null, 1267019890, typeof(DirectorySubject)));
				num = 5;
				break;
			case 5:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216135105, 4, 'ó'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(24, null, 1057162433, 5));
				goto case 2;
			case 2:
				num = 4;
				break;
			case 4:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(7, '\u001d', 952619637));
				goto case 1;
			case 1:
				obj = new Publisher();
				num = 6;
				break;
			case 6:
				((Publisher)obj).Process(cmd);
				return;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, DateTime P_1, char P_2, int P_3) where _0021_00210 : AnnWxSpot
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႠ[13] - 8123;
				break;
			case 5:
				num = (((P_3 ^ P_2) - 81) ^ num2) switch
				{
					0 => 9, 
					_ => 8, 
				};
				break;
			case 8:
				num = 3;
				break;
			case 2:
			case 9:
				P_0.Dts = P_1;
				goto case 3;
			case 3:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 7 : 0);
				break;
			case 0:
				num = 5;
				break;
			case 6:
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴈ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DxSpot
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		DateTime dateTime = default(DateTime);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[328] - 34973;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႷ[44] - 49663;
					continue;
				case 5:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 113) ^ num) switch
					{
						0 => 4, 
						_ => 10, 
					};
					continue;
				case 10:
					dateTime = default(DateTime);
					goto case 0;
				case 0:
					num2 = 7;
					continue;
				case 4:
				case 11:
					dateTime = P_0.Dts;
					num2 = 7;
					continue;
				case 7:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 6;
					continue;
				case 6:
					num2 = ((num3 % 2 != 0) ? 3 : (ⴀႼ[0] - 48));
					continue;
				case 1:
				case 8:
				{
					DateTime result = dateTime;
					Arc4ServerClient.ႠႣ[241] = (char)((Arc4ServerClient.ႠႣ[241] * P_1) & 0x22);
					return result;
				}
				case 2:
					num2 = ⴄႭ[465] - 66;
					continue;
				}
				break;
			}
		}
	}
}
