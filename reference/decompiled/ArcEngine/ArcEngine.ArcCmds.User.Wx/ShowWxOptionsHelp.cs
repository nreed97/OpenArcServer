using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class ShowWxOptionsHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 5;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267014313, typeof(Help)));
				num = ⴃႥ[36] - 25080;
				break;
			case 1:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130426, 1, 'â'));
				goto case 6;
			case 6:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(29, null, 1057167145, 8));
				goto case 3;
			case 3:
				num = ⴀႨ[125] - 14040;
				break;
			case 0:
			case 4:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(6, 7, 1217944679));
				obj = new Publisher();
				num = 2;
				break;
			case 2:
				(obj as Publisher).Process(cmd);
				return;
			}
		}
	}
}
