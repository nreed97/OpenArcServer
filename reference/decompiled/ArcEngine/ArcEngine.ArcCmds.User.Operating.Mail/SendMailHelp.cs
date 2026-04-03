using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class SendMailHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 5;
			case 5:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267022837, typeof(DirectoryBulletin)));
				num = ⴀႣ[217] - 50653;
				break;
			case 3:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133312, 6, 'Ì'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(11, null, 1057162013, 5));
				goto case 0;
			case 0:
				num = ⴀ[231] - 33756;
				break;
			case 6:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(4, 'Ø', 952620086));
				goto case 1;
			case 1:
				obj = new Publisher();
				num = 4;
				break;
			case 4:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : DxSpotBlockUpdate
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴐ[50] - 10;
				break;
			case 2:
			case 8:
				num = (((P_3 ^ P_2) - 97) ^ num2) switch
				{
					0 => 9, 
					_ => ⴀႼ[117] - 117, 
				};
				break;
			case 1:
			case 4:
				num = ⴀ[217] - 8310;
				break;
			case 9:
				P_0.Download(P_1);
				goto case 3;
			case 3:
				num2++;
				goto case 5;
			case 5:
				num = (((P_3 * P_3 + P_3) % 2 != 0) ? (ⴀႳ[183] - 43496) : 0);
				break;
			case 7:
				num = 2;
				break;
			case 0:
				return;
			}
		}
	}
}
