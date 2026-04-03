using System.Collections.Generic;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class NetworkHelp : IArcCmd
{
	internal sealed class Ⴅ
	{
		internal List<string> Ⴃ;

		internal Ⴅ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(0, null, 1267018299, typeof(SetWwvCount)));
				num = 9;
				break;
			case 9:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131267, 6, 'á'));
				goto case 3;
			case 3:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(11, null, 1057163438, 7));
				num = ⴍႭ[333] - 17132;
				break;
			case 2:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(3, 'h', 952622496));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 7, 62055994, null));
				num = 7;
				break;
			case 7:
			{
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(5, 13, 1217943262));
				cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(15, 8, 1747255904, null));
				byte num2 = ⴄႭ[291];
				Arc4ServerClient.ႠႣ[17] = (char)((Arc4ServerClient.ႠႣ[17] * Arc4ServerClient.ႠႣ[83]) & 0xA0);
				num = num2 - 141;
				break;
			}
			case 1:
				cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687353718, 3, 15));
				num = ⴄႭ[371] - 177;
				break;
			case 6:
				cmd.Tx.Msg.Add(ႨႨ.Ⴀ(0, 7, 1157905739));
				goto case 8;
			case 8:
				obj = new Publisher();
				num = 5;
				break;
			case 5:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}
}
