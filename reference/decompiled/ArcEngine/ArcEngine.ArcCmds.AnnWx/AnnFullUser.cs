using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.Talk;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.AnnWx;

public sealed class AnnFullUser : AnnWxSpotBase, IArcCmd
{
	private static readonly ILog Ⴓ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('Ú', 985807664, 6), 1015, 1002);

	private static void Ⴅ(NodeUserCmd P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				object obj = new AnnFullHelp();
				(obj as AnnFullHelp).Exec(P_0);
				return;
			}
			case 0:
				return;
			}
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(8, 2, 1157904982), P_0.Rx.Msg, 946, 1020));
			num = ⴍႤ[403] - 60840;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		try
		{
			int num = 4;
			object obj2 = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj2 as PrecisionTimer, 782, 847);
					num = ((cmd.Rx.Split.Length <= 2) ? (ⴀႨ[145] - 20384) : 10);
					continue;
				case 10:
					cmd.Tx.DistroType = DistroType.ToAll;
					AppLogCfg.Ⴜ(AnnWx, SetTalkCount.Ⴗ(7, null, 1267022532, typeof(SetAnnCountHelp)), 'ˑ', 'ʈ');
					num = ⴀႨ[45] - 15614;
					continue;
				case 19:
					ႰႰ.Ⴄ(AnnWx, ႨႨ.Ⴀ(7, 6, 1157905966), 'K', '2');
					num = ⴅ[332] - 219;
					continue;
				case 2:
					ShowLog.Ⴗ(AnnWx, cmd.Ⴍ().Call, 449, 'Ǎ');
					AppLogCfg.Ⴜ(AnnWx, cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call, 'Ǫ', 'ư');
						num = ⴀႨ[82] - 5759;
						continue;
					case 13:
						qslinfoResponse.Ⴅ(AnnWx, qslinfoResponse.Ⴗ(cmd.Ⴍ().Call, CallBlockCacheCfg.Ⴅ(null, 3, 62058063, null), cmd.Ⴍ().Io.EndPoint, ReplyMail.Ⴅ(7, 4, 1217945015), 479, 'Ƽ'), 'Ϻ', 'β');
						num = 20;
						continue;
					case 20:
						TalkSpotHelp.Ⴃ(AnnWx, ShowAnnHelp.Ⴅ('\r', 60), 'Ħ', 375);
						num = 16;
						continue;
					case 16:
						ChatRoomPvtCfg.Ⴅ(AnnWx, cmd.Rx.GetMsgEnd(2), 908, '\u0384');
						num = ⴀႣ[106] - 1383;
						continue;
					case 3:
						AppLogCfg.Ⴜ(AnnWx, CallBlockCacheCfg.Ⴅ(null, 0, 62057594, null), 'Ń', 'ě');
						num = ⴃႰ[15] - 46741;
						continue;
					case 7:
					case 8:
						flag = ProcessSpot(cmd);
						ByeHelp.Ⴄ((PrecisionTimer)obj2, 'ǀ', 403);
						num = ⴀႼ[2];
						continue;
					case 18:
						num = ((!flag) ? 6 : 14);
						continue;
					case 14:
					{
						ILog ⴓ2 = Ⴓ;
						Array array = new object[4];
						(array as object[])[0] = (PrecisionTimer)obj2;
						((object[])array)[1] = cmd.Ⴍ().Call;
						((object[])array)[2] = SetStationClubHelp.Ⴍ(2, 0, 1747257856, null);
						(array as object[])[3] = cmd.Tx.Msg[0];
						ⴓ2.Info(SetDxDefaultHelp.Ⴍ(array as object[], '\u02f6', 671));
						num = 17;
						continue;
					}
					case 17:
					{
						object obj3 = new Publisher();
						(obj3 as Publisher).Process(cmd);
						num = 5;
						continue;
					}
					case 6:
						num = ((!qslinfoRequest.Ⴗ(AnnWx, 900, 917)) ? 21 : (ⴄႷ[110] - 20064));
						continue;
					case 9:
					case 11:
						num = ((!qslinfoRequest.Ⴗ(AnnWx, 504, 489)) ? 5 : (ⴍႭ[10] - ⴍႭ[10]));
						continue;
					case 0:
						num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
							.AppLog.LogAnnWxDupes) ? 5 : (ⴄႷ[85] - 6766));
						continue;
					case 21:
					{
						ILog ⴓ = Ⴓ;
						object obj = new object[4];
						((object[])obj)[0] = obj2 as PrecisionTimer;
						(obj as object[])[1] = cmd.Ⴍ().Call;
						(obj as object[])[2] = SetStationClubHelp.Ⴍ(14, 1, 1747257857, null);
						((object[])obj)[3] = cmd.Tx.Msg[0];
						ⴓ.Warn(string.Concat((object[])obj));
						num = ⴄႤ[135];
						continue;
					}
					case 15:
						Ⴅ(cmd);
						break;
					case 5:
						break;
					}
					break;
				}
			}
			catch (Exception)
			{
				Ⴅ(cmd);
			}
			switch (1)
			{
			}
		}
	}
