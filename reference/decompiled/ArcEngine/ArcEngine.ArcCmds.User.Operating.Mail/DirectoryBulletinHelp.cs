using System;
using System.Data.SqlServerCe;
using System.Security;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class DirectoryBulletinHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(8, null, 1267022841, typeof(AnnLocalUser)));
				num = 4;
				break;
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133326, 8, 'Ã'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(27, null, 1057162000, 8));
				goto case 6;
			case 6:
				num = ⴀႼ[4] - 34;
				break;
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(1, 'n', 952620083));
				obj = new Publisher();
				num = 5;
				break;
			case 2:
			case 5:
				((Publisher)obj).Process(cmd);
				return;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static TimeSpan Ⴓ(ref DateTime P_0, DateTime P_1, short P_2, char P_3)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		TimeSpan result = default(TimeSpan);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႭ[398] - 210;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႨ[208] - 6507;
					continue;
				case 4:
					break;
				case 2:
				case 7:
					num2 = (((P_2 ^ P_3) - 55) ^ num) switch
					{
						0 => ⴃႥ[420] - 8224, 
						_ => 8, 
					};
					continue;
				case 8:
					result = default(TimeSpan);
					num2 = 3;
					continue;
				case 6:
					result = P_0.Subtract(P_1);
					num2 = 3;
					continue;
				case 1:
				case 3:
				case 9:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 != 0) ? (ⴀ[483] - 55409) : 0);
					continue;
				case 11:
					num2 = ⴀႳ[282] - 35094;
					continue;
				case 0:
					return result;
				case 5:
					num2 = ⴀႣ[128] - 26880;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : SqlCeDataAdapter where _0021_00211 : SqlCeCommand
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 3;
				break;
			case 3:
				num = (((P_2 ^ P_3) - 16) ^ num2) switch
				{
					0 => ⴃႰ[119] - ⴃႰ[119], 
					_ => 8, 
				};
				break;
			case 8:
				num = 6;
				break;
			case 0:
				P_0.UpdateCommand = P_1;
				goto case 6;
			case 6:
			{
				num2++;
				int num3 = 74;
				int num4 = 613;
				num = ((6130 > num4 - num3 * 10) ? (ⴄႭ[297] / 7) : 2);
				break;
			}
			case 2:
			case 7:
				num = ⴄႤ[53] - 236;
				break;
			case 4:
				return;
			}
		}
	}
}
