using System;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ContestProcessing;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class SetWxFilter : IArcCmd
{
	private static void Ⴍ(NodeUserCmd P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 4:
			{
				object obj = new SetWxFilterHelp();
				((SetWxFilterHelp)obj).Exec(P_0);
				break;
			}
			case 0:
			case 1:
				break;
			case 3:
				return;
			}
			break;
			IL_0023:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(12, 2, 1157904754), P_0.Rx.Msg, 267, 325));
			num = ⴐ[367];
		}
		object obj2 = new Publisher();
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		cmd.Tx.DistroType = DistroType.ToRequester;
		object obj = new Publisher();
		try
		{
			int num = 9;
			IComparable<string> comparable = default(IComparable<string>);
			IEquatable<string> equatable = default(IEquatable<string>);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 3) ? ⴐ[50] : (ⴍႭ[356] - 15171));
					continue;
				case 11:
					CallHistoryOverride.Ⴍ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 285, 297), string.Empty, 'ċ', 354);
					num = 1;
					continue;
				case 1:
				case 10:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132110, 8, '¤'));
					num = ⴃႰ[139] - 40012;
					continue;
				case 15:
					((Publisher)obj).Process(cmd);
					goto case 2;
				case 2:
					num = ⴀႣ[270] - 52110;
					continue;
				case 12:
					num = ((cmd.Rx.Split.Length < 3) ? (ⴃႥ[276] - 61049) : (ⴀႼ[2] / 3));
					continue;
				case 6:
				case 16:
					comparable = SetStationGrid.Ⴍ(cmd.Rx.GetMsgEnd(3), 449, 'Ɠ');
					equatable = cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴄ()
						.FormatSqlFilter((string)comparable);
					num = ⴀႨ[160] - 46639;
					continue;
				case 7:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴈ()
						.Ⴓ(equatable as string)) ? 3 : (ⴍႭ[15] - 41652));
					continue;
				case 8:
					CallHistoryOverride.Ⴍ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 302, 282), (string)equatable, '\u036a', 771);
					num = 13;
					continue;
				case 13:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႰႥ.Ⴅ(6, '_', 952621451), comparable as string, 990, 912));
					num = ⴃႥ[284] - 40960;
					continue;
				case 3:
					cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(31, null, 1057164639, 8) + (comparable as string));
					goto case 14;
				case 14:
					((Publisher)obj).Process(cmd);
					num = ⴅ[447] - 237;
					continue;
				case 4:
					Ⴍ(cmd);
					break;
				case 5:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴍ(cmd);
		}
		switch (2)
		{
		}
	}
}
