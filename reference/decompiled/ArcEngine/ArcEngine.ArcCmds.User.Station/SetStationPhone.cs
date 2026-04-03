using System;
using System.Collections.Generic;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationPhone : IArcCmd
{
	private static void Ⴍ(NodeUserCmd P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 1:
			case 4:
			{
				object obj = new SetStationPhoneHelp();
				(obj as SetStationPhoneHelp).Exec(P_0);
				break;
			}
			case 0:
				break;
			case 2:
				return;
			}
			break;
			IL_0023:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(5, 0, 1157903368), P_0.Rx.Msg, 750, 672));
			num = ⴍႭ[328] - 34972;
		}
		object obj2 = new Publisher();
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		try
		{
			int num = 8;
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 4) ? 7 : 9);
					continue;
				case 0:
				case 9:
					cmd.Tx.DistroType = DistroType.ToRequester;
					goto case 10;
				case 10:
					enumerable = cmd.Rx.Split[3];
					num = ⴍႭ[44] - 53160;
					continue;
				case 3:
					DirectorySubjectHelp.Ⴍ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 854, 832), enumerable as string, 261, 343);
					num = ⴀ[59] - 2559;
					continue;
				case 2:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ReplyMail.Ⴅ(8, 8, 1217944614), enumerable as string, 267, 325));
					goto case 4;
				case 4:
					num = 5;
					continue;
				case 5:
				{
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					num = 1;
					continue;
				}
				case 7:
					Ⴍ(cmd);
					break;
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴍ(cmd);
		}
		switch (1)
		{
		}
	}
}
