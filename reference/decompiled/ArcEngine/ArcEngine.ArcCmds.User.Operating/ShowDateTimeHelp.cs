using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowDateTimeHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(2, null, 1267014259, typeof(ShowDxFilter)));
				num = ⴃႥ[246] - 15133;
				break;
			case 4:
			case 6:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130026, 6, 'ò'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(7, null, 1057165367, 1));
				num = ⴍႤ[488] - 14198;
				break;
			case 1:
			case 2:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(4, '(', 952620895));
				obj = new Publisher();
				num = ⴃႥ[243] - 40666;
				break;
			case 5:
				((Publisher)obj).Process(cmd);
				return;
			case 3:
				return;
			}
		}
	}
}
