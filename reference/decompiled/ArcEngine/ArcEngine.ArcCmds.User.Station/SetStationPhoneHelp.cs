using System;
using System.Collections;
using System.Security;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationPhoneHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267022641, typeof(DxSpotUserHelp)));
				num = 6;
				break;
			case 2:
			case 6:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133154, 2, ','));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(15, null, 1057162081, 2));
				num = ⴀႨ[219] - 45729;
				break;
			case 0:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(2, '¥', 952620051));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 0, 62057749, null));
				num = ⴍႭ[190] - 25676;
				break;
			case 5:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : Letter
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		IEnumerable enumerable = default(IEnumerable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[102] - ⴄႷ[35];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႤ[139] / 7;
					continue;
				case 2:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 87) ^ num) switch
					{
						0 => 0, 
						_ => ⴀႼ[127] - 32, 
					};
					continue;
				case 7:
					enumerable = null;
					num2 = ⴃႰ[63] - 42193;
					continue;
				case 0:
					enumerable = P_0.FromNode;
					num2 = 3;
					continue;
				case 3:
					num++;
					num3 = 324;
					goto case 5;
				case 5:
				{
					int num4 = 843;
					num2 = ((4215 > num4 - num3 * 5) ? (ⴀႼ[67] - 228) : (ⴀႣ[72] - 51852));
					continue;
				}
				case 4:
				case 8:
				case 10:
					num2 = ⴄႷ[126] - 39161;
					continue;
				case 6:
					return enumerable as string;
				case 11:
					num2 = ⴃႥ[46] - 62977;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴄ(ref DateTime P_0, int P_1, short P_2, int P_3)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		DateTime result = default(DateTime);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 0:
					num2 = (((P_3 ^ P_2) - 88) ^ num) switch
					{
						0 => ⴀ[519] - 42593, 
						_ => 4, 
					};
					continue;
				case 2:
				case 4:
					result = default(DateTime);
					num2 = ⴃႥ[152] - 55227;
					continue;
				case 9:
					result = P_0.AddYears(P_1);
					num2 = ⴄႷ[37] - 43352;
					continue;
				case 5:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 3;
				case 3:
					num2 = 8;
					continue;
				case 8:
					num2 = ((num3 % 2 == 0) ? 6 : 0);
					continue;
				case 6:
				case 7:
					return result;
				case 10:
					num2 = ⴍႤ[447] - ⴍႤ[447];
					continue;
				}
				break;
			}
		}
	}
}
