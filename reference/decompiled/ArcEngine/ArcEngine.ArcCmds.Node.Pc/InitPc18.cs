using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Node.Pc;

public sealed class InitPc18 : IArcCmd
{
	private static readonly ILog Ⴀ = SkimmerValidSpot.Ⴐ(ReplyMailHelp.Ⴄ(20, null, 1057166658, 7), 970, 983);

	public void Exec(NodeUserCmd cmd)
	{
		try
		{
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					goto IL_0022;
				case 2:
					Ⴈ(cmd);
					break;
				case 0:
					break;
				}
				break;
				IL_0022:
				object obj = new PrecisionTimer();
				ILog ⴀ = Ⴀ;
				object obj2 = new object[4];
				((object[])obj2)[0] = obj as PrecisionTimer;
				((object[])obj2)[1] = cmd.Ⴍ().Call;
				(obj2 as object[])[2] = SetStationClubHelp.Ⴍ(7, 4, 1747257860, null);
				((object[])obj2)[3] = cmd.Rx.Msg;
				ⴀ.Info(SetDxDefaultHelp.Ⴍ(obj2 as object[], 'Q', 56));
				num = 2;
			}
			object obj3 = new Publisher();
			((Publisher)obj3).Process(cmd);
		}
		catch (Exception ex)
		{
			Ⴀ.Warn(SkimmerSpotBins.Ⴈ(ex, 812, 770));
		}
		switch (0)
		{
		}
	}

	private void Ⴈ(NodeUserCmd P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.DistroType = DistroType.ToNode;
				goto IL_002e;
			case 1:
				goto IL_002e;
			case 2:
				(obj as PcxxNodeUser).BuildAndSend(P_0);
				break;
			case 4:
				break;
			case 3:
				return;
			}
			break;
			IL_002e:
			P_0.Ⴍ().ConnectState = ConnectStateType.PcxxNode;
			obj = new PcxxNodeUser();
			num = ⴐ[196] - 54;
		}
		Ⴄ(P_0);
	}

	public static string GetPc18Cmd()
	{
		return ShowWxHelp.Ⴍ('Ð', 985805377, 1) + BadWordCacheCfg.Ⴍ(695, 734) + ShowWxHelp.Ⴍ('(', 985805243, 7);
	}

	private static void Ⴄ(NodeUserCmd P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 3;
		object obj2 = default(object);
		IComparable comparable = default(IComparable);
		while (true)
		{
			switch (num)
			{
			default:
				obj2 = new PrecisionTimer();
				goto case 7;
			case 7:
				ShowPrefixCallsHelp.Ⴗ(obj2 as PrecisionTimer, 945, 1008);
				comparable = ReplyMailHelp.Ⴄ(4, null, 1057166667, 6);
				goto case 2;
			case 2:
				num = 6;
				break;
			case 6:
				P_0.Tx.Msg.Add((string)comparable);
				ByeHelp.Ⴄ(obj2 as PrecisionTimer, 'Ǉ', 404);
				num = 1;
				break;
			case 1:
				num = ((!P_0.Ⴍ().Ⴅ().Ⴍ()
					.PcxxCfg.LogOutboundNodeUser) ? ⴄႤ[135] : 4);
				break;
			case 4:
			{
				ILog ⴀ = Ⴀ;
				object obj = new object[4];
				(obj as object[])[0] = (PrecisionTimer)obj2;
				(obj as object[])[1] = P_0.Ⴍ().Call;
				((object[])obj)[2] = ReplyMail.Ⴅ(0, 10, 1217944108);
				((object[])obj)[3] = comparable as string;
				ⴀ.Info(string.Concat((object[])obj));
				return;
			}
			case 0:
			case 5:
				return;
			}
		}
	}
}
