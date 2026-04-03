using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.Arc4;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowUptimeHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267016798, typeof(SetStationClub)));
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129216, 4, 'ä'));
				goto case 4;
			case 4:
			case 5:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(9, null, 1057165518, 8));
				goto case 0;
			case 0:
				num = 6;
				break;
			case 6:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(3, '¬', 952620888));
				obj = new Publisher();
				num = ⴀႣ[166] - 45409;
				break;
			case 3:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : Top100Update where _0021_00211 : string
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 6;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႠ[107] - 2814;
				break;
			case 1:
				num = (((P_3 ^ P_2) - 1) ^ num2) switch
				{
					0 => 2, 
					_ => 9, 
				};
				break;
			case 9:
				num = 5;
				break;
			case 2:
				P_0.Download(P_1);
				goto case 5;
			case 5:
				num2++;
				num3 = 291;
				goto case 0;
			case 0:
				num4 = 667;
				goto case 4;
			case 4:
				num = ((6670 > num4 - num3 * 10) ? (ⴅ[99] - 13) : 8);
				break;
			case 8:
				num = 1;
				break;
			case 3:
				return;
			}
		}
	}
}
