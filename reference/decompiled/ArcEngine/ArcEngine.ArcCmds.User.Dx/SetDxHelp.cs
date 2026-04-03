using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcCmds.Wwv;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class SetDxHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 3;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267016895, typeof(WwvSpotUser)));
				goto case 1;
			case 1:
				num = ⴃႰ[97] - 18258;
				break;
			case 0:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129154, 4, 'ñ'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(23, null, 1057165471, 2));
				goto case 5;
			case 5:
				num = ⴍႭ[175] - 7053;
				break;
			case 8:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(2, '\u0083', 952616144));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 3, 62055211, null));
				num = 4;
				break;
			case 4:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(2, 7, 1217942070));
				cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(8, 1, 1747263322, null));
				num = 2;
				break;
			case 2:
			case 9:
				cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687354632, 0, 22));
				num = 7;
				break;
			case 7:
				cmd.Tx.Msg.Add(ႨႨ.Ⴀ(14, 0, 1157900085));
				obj = new Publisher();
				num = ⴍႭ[34] - 15432;
				break;
			case 6:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}
}
