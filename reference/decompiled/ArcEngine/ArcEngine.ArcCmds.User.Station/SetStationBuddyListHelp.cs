using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ContestProcessing;
using ArcInterfaces.Spots;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationBuddyListHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(8, null, 1267017285, typeof(N1mmCallHist)));
				num = ⴄႤ[522] - 247;
				break;
			case 3:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129532, 1, '\u0098'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(31, null, 1057166078, 8));
				goto case 1;
			case 1:
				num = 5;
				break;
			case 5:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(8, 'Ç', 952622018));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 2, 62057202, null));
				goto case 6;
			case 6:
				num = 0;
				break;
			case 0:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : string where _0021_00211 : AnnWxSpot
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				continue;
			case 2:
			case 5:
				num = (((P_2 ^ P_3) - 72) ^ num2) switch
				{
					0 => 7, 
					_ => ⴄႤ[298] - 85, 
				};
				continue;
			case 0:
				num = ⴄႤ[50] / 8;
				continue;
			case 7:
				P_0.SpotterCont = P_1;
				break;
			case 3:
				break;
			case 4:
			case 6:
			case 8:
				return;
			}
			num2++;
			int num3 = 1071;
			int num4 = 338;
			num = ((357 < num3 / 3 - num4) ? 2 : 6);
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : string where _0021_00211 : IpLockoutUpdate
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 6;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 5;
				break;
			case 5:
				num = (((P_2 ^ P_3) - 122) ^ num3) switch
				{
					0 => ⴀ[458] - 33454, 
					_ => 7, 
				};
				break;
			case 7:
				num = ⴃႠ[110] - 60969;
				break;
			case 2:
			case 3:
			case 8:
				P_0.Download(P_1);
				goto case 0;
			case 0:
				num3++;
				num2 = P_2 * P_2;
				goto case 4;
			case 4:
				num2 = P_2 + num2;
				num = ⴀႨ[209] - 44061;
				break;
			case 9:
				num = ((num2 % 2 == 0) ? 1 : (ⴐ[409] - 187));
				break;
			case 1:
				return;
			}
		}
	}
}
