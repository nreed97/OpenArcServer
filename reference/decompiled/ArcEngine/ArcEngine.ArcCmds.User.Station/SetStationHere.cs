using System;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationHere : IArcCmd
{
	private static void Ⴍ(NodeUserCmd P_0)
	{
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 2:
			{
				IArcCmd arcCmd = new SetStationHereHelp();
				(arcCmd as SetStationHereHelp).Exec(P_0);
				obj = new Publisher();
				break;
			}
			case 3:
				break;
			case 0:
				return;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(11, 4, 1157898731), P_0.Rx.Msg, 327, 265));
			num = 2;
		}
		(obj as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		try
		{
			int num = 14;
			object obj = default(object);
			ICloneable cloneable = default(ICloneable);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 4) ? (ⴍႭ[18] - 56766) : (ⴀႣ[345] - 45944));
					continue;
				case 3:
					cmd.Tx.DistroType = DistroType.ToRequester;
					obj = new Publisher();
					cloneable = SetDxFilter.Ⴀ(cmd.Rx.Split[3], 323, 'Ă');
					num = 12;
					continue;
				case 12:
					num = ((!ByeHelp.Ⴍ(cloneable as string, SetDxFilter.Ⴀ(ShowWxHelp.Ⴍ('\u0086', 985807973, 6), 286, 'ş'), 565, 594)) ? (ⴍႭ[6] - 37953) : 13);
					continue;
				case 13:
					cmd.Ⴍ().Here = ReplyMail.Ⴅ(4, 9, 1217944964);
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					num = 11;
					continue;
				case 11:
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130517, 7, '\u0013'));
					(obj as Publisher).Process(cmd);
					num = ⴐ[361] - 244;
					continue;
				case 6:
				case 9:
					num = ((!ByeHelp.Ⴍ((string)cloneable, SetDxFilter.Ⴀ(ႨႨ.Ⴀ(9, 6, 1157902450), 856, '\u0319'), 915, 1012)) ? (ⴄႭ[421] - ⴄႭ[189]) : 0);
					continue;
				case 0:
					cmd.Ⴍ().Here = ႨႨ.Ⴀ(10, 8, 1157905952);
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					num = 4;
					continue;
				case 4:
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(3, 4, 1157898653));
					goto case 5;
				case 5:
					(obj as Publisher).Process(cmd);
					num = 7;
					continue;
				case 10:
					Ⴍ(cmd);
					goto case 8;
				case 8:
					num = ⴄႭ[94];
					continue;
				case 1:
					Ⴍ(cmd);
					break;
				case 7:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴍ(cmd);
		}
		switch (3)
		{
		}
	}
}
