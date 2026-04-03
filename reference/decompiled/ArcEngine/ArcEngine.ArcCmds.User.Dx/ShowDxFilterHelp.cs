using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class ShowDxFilterHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 5;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(2, null, 1267021619, typeof(ShowCluster.ႨႠ)));
				goto case 4;
			case 4:
				num = ⴀႨ[2] - 62086;
				break;
			case 0:
			case 1:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131395, 0, '$'));
				obj = new Publisher();
				num = 3;
				break;
			case 3:
				((Publisher)obj).Process(cmd);
				return;
			case 2:
				return;
			}
		}
	}
}
