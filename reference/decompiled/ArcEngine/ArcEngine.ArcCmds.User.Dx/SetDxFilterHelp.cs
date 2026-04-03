using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class SetDxFilterHelp : IArcCmd
{
	internal sealed class Ⴈ
	{
		internal bool Ⴐ;

		internal Ⴈ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267015613, typeof(SetWxDefault)));
				num = ⴀ[10] - 6091;
				continue;
			case 3:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216127274, 2, 'ª'));
				goto case 6;
			case 6:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(18, null, 1057166354, 5));
				num = 1;
				continue;
			case 1:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(6, '¢', 952616946));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 1, 62062396, null));
				num = 4;
				continue;
			case 4:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 7, 62054857, null));
				num = ⴀႼ[136];
				continue;
			case 5:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 3, 62057760, null));
				goto case 7;
			case 7:
				num = 8;
				continue;
			case 8:
				obj = new Publisher();
				break;
			case 2:
				break;
			}
			break;
		}
		(obj as Publisher).Process(cmd);
	}
}
