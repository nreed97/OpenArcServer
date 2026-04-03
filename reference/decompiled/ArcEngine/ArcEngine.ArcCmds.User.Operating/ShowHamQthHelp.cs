using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowHamQthHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int num = 5;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(8, null, 1267018967, typeof(DxSpotBase)));
				num = 3;
				break;
			case 1:
			case 3:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132146, 4, 'ú'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(19, null, 1057164491, 2));
				num = 4;
				break;
			case 4:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(1, '÷', 952620890));
				goto case 0;
			case 0:
				obj = new Publisher();
				num = 2;
				break;
			case 2:
			case 6:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}
}
