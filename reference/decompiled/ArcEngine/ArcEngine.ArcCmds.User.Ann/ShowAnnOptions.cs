using System;
using System.Security;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class ShowAnnOptions : IArcCmd
{
	private static void Ⴄ(NodeUserCmd P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(9, 1, 1157903280), P_0.Rx.Msg, 841, 775));
				goto IL_005a;
			case 2:
				goto IL_005a;
			case 0:
			case 3:
				obj = new ShowAnnOptionsHelp();
				break;
			case 1:
				break;
			}
			break;
			IL_005a:
			num = ⴄႤ[407] - 43;
		}
		((ShowAnnOptionsHelp)obj).Exec(P_0);
		object obj2 = new Publisher();
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		try
		{
			int num = 10;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length == 3) ? 7 : 0);
					continue;
				case 7:
					cmd.Tx.DistroType = DistroType.ToRequester;
					cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(0, null, 1267017022, typeof(ႷႭ)));
					num = 8;
					continue;
				case 8:
				case 9:
					cmd.Tx.Msg.Add(SetWxCountHelp.Ⴗ((object)ႨႨ.Ⴀ(3, 6, 1157903705), (object)ShowNodesHelp.Ⴍ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 989, 1012), 426, 'ƕ'), 787, (short)872));
					num = ⴍႭ[347] - 58768;
					continue;
				case 3:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႰႥ.Ⴅ(0, '2', 952619949), LogEntry.Ⴄ(SunCalculations.Ⴃ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 636, 597), 589, 516), 'ĉ', 293), 210, 156));
					num = ⴀႳ[123] - 17554;
					continue;
				case 6:
					Ⴗ(cmd);
					goto case 4;
				case 4:
					Ⴅ(cmd);
					Ⴃ(cmd);
					goto case 5;
				case 5:
				{
					object obj = new Publisher();
					(obj as Publisher).Process(cmd);
					num = ⴄႷ[37] - 43356;
					continue;
				}
				case 0:
					Ⴄ(cmd);
					break;
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴄ(cmd);
		}
		switch (2)
		{
		}
	}

	private static void Ⴅ(NodeUserCmd P_0)
	{
		int num = 5;
		OutputType outputType = default(OutputType);
		while (true)
		{
			switch (num)
			{
			default:
				outputType = ႰႨ.ႥႭ(TalkHelp.Ⴃ(P_0.Ⴍ().Cfg, 617, 576), '>', 56);
				goto case 4;
			case 4:
				num = 0;
				break;
			case 0:
			case 3:
				switch (outputType)
				{
				default:
					num = 1;
					break;
				case OutputType.Off:
					P_0.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687354656, 8, 9));
					return;
				case OutputType.On:
					P_0.Tx.Msg.Add(ShowWxHelp.Ⴍ('\a', 985805607, 1));
					return;
				}
				break;
			case 1:
				return;
			}
		}
	}

	private static void Ⴗ(NodeUserCmd P_0)
	{
		int num = 1;
		ModeType modeType = default(ModeType);
		while (true)
		{
			switch (num)
			{
			default:
				modeType = DxSpotUserHelp.Ⴗ(TalkHelp.Ⴃ(P_0.Ⴍ().Cfg, 321, 360), 287, 331);
				goto case 2;
			case 2:
			case 5:
				num = 4;
				break;
			case 4:
				switch (modeType)
				{
				default:
					num = 0;
					break;
				case ModeType.Open:
					P_0.Tx.Msg.Add(ReplyMailHelp.Ⴄ(13, null, 1057165421, 5));
					return;
				case ModeType.Filter:
					P_0.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 1, 62055392, null));
					return;
				case ModeType.Debug:
					P_0.Tx.Msg.Add(SetStationClubHelp.Ⴍ(8, 5, 1747263331, null));
					return;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static void Ⴃ(NodeUserCmd P_0)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				if (!SetStationName.Ⴅ(TalkHelp.Ⴃ(P_0.Ⴍ().Cfg, 872, 833), '\u0310', 780))
				{
					P_0.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687354835, 4, 13));
					return;
				}
				break;
			case 0:
			case 3:
				P_0.Tx.Msg.Add(ReplyMail.Ⴅ(4, 5, 1217942468));
				return;
			case 1:
			case 4:
				return;
			}
			num = 3;
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, short P_3) where _0021_00210 : AnnCfg
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 1;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴄႤ[135];
				break;
			case 5:
			case 6:
			case 8:
				num = (((P_2 ^ P_3) - 53) ^ num3) switch
				{
					0 => 3, 
					_ => 9, 
				};
				break;
			case 9:
				num = 2;
				break;
			case 3:
				P_0.Wrap = P_1;
				goto case 2;
			case 2:
			case 7:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 4;
				break;
			case 4:
				num = ((num2 % 2 != 0) ? (ⴀႨ[185] - 58115) : 0);
				break;
			case 0:
				return;
			}
		}
	}
}
