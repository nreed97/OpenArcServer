using System;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class DxHelp : IArcCmd
{
	internal sealed class Ⴐ
	{
		internal int Ⴗ;

		internal DateTime Ⴍ;

		internal Ⴐ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		int num = 6;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 2;
			case 2:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(3, null, 1267013829, typeof(SetDxExtensionHelp)));
				goto case 4;
			case 4:
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130246, 5, '\n'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(29, null, 1057166956, 8));
				num = 1;
				break;
			case 1:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(5, 'Ë', 952616235));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 8, 62062071, null));
				num = 7;
				break;
			case 7:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(6, 5, 1217940960));
				obj = new Publisher();
				num = 5;
				break;
			case 5:
				(obj as Publisher).Process(cmd);
				SetAnnMode.ႤႭ[234] = (byte)(SetAnnMode.ႤႭ[234] & SetAnnMode.ႤႭ[418] & 0x8E);
				return;
			}
		}
	}
}
