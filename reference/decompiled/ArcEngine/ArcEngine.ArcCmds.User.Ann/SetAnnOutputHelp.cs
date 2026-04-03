using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnOutputHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 6;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267017640, typeof(SetDxFilter)));
				num = ⴍႭ[34] - 15431;
				break;
			case 7:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129151, 7, '\u0090'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(0, null, 1057165568, 5));
				num = 0;
				break;
			case 0:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 6, 62058366, null));
				goto case 2;
			case 2:
				num = 5;
				break;
			case 5:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(5, 10, 1217945177));
				obj = new Publisher();
				goto case 1;
			case 1:
				num = 3;
				break;
			case 3:
			case 4:
				(obj as Publisher).Process(cmd);
				return;
			}
		}
	}
}
