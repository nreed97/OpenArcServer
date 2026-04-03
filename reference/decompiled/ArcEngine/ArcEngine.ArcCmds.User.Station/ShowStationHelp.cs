using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class ShowStationHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 6;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 4;
			case 4:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(8, null, 1267018100, typeof(Configuration)));
				num = 3;
				continue;
			case 3:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131618, 4, '\u0090'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(23, null, 1057165106, 5));
				num = ⴅ[237] - 138;
				continue;
			case 5:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 4, 62057745, null));
				num = ⴄႭ[520] - 140;
				continue;
			case 0:
			case 1:
				obj = new Publisher();
				break;
			case 2:
				break;
			}
			break;
		}
		((Publisher)obj).Process(cmd);
	}
}
