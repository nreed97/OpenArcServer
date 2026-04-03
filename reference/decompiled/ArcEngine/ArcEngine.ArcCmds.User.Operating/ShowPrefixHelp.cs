using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowPrefixHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(3, null, 1267022834, typeof(AnnWxCmdType)));
				num = ⴀႣ[375] - 21700;
				break;
			case 4:
			case 5:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133326, 8, 'À'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(26, null, 1057162010, 2));
				goto case 2;
			case 2:
			case 3:
			{
				byte num2 = ⴄႭ[242];
				SetTalkCountHelp.Ⴅ[286] = (byte)((SetTalkCountHelp.Ⴅ[286] ^ SetTalkCountHelp.Ⴅ[457]) & 0xAD);
				num = num2 - 127;
				break;
			}
			case 1:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(3, 'p', 952620081));
				obj = new Publisher();
				num = ⴍႭ[61] - 10206;
				break;
			case 6:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}
}
