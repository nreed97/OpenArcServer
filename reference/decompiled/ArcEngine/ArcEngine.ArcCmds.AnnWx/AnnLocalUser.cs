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
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.AnnWx;

public sealed class AnnLocalUser : AnnWxSpotBase, IArcCmd
{
	private static readonly ILog Ⴍ = SkimmerValidSpot.Ⴐ(ႰႥ.Ⴅ(1, '\u008b', 952619768), 908, 913);

	private static void Ⴄ(NodeUserCmd P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
			case 4:
			{
				object obj = new AnnSpotHelp();
				((AnnSpotHelp)obj).Process(P_0);
				return;
			}
			case 1:
				return;
			}
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(7, 1, 1157906045), P_0.Rx.Msg, 472, 406));
			num = ⴀႨ[72] - 30947;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		try
		{
			int num = 2;
			object obj2 = default(object);
			bool flag = default(bool);
			object obj3 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj2, 557, 620);
					num = ((cmd.Rx.Split.Length != 1) ? (ⴍႭ[238] - 48045) : 8);
					continue;
				case 8:
				{
					IArcCmd arcCmd = new AnnHelp();
					(arcCmd as AnnHelp).Exec(cmd);
					num = ⴀႳ[27] - 42050;
					continue;
				}
				case 11:
					num = ((cmd.Rx.Split.Length <= 1) ? 16 : (ⴄႷ[113] - 58458));
					continue;
				case 13:
					cmd.Tx.DistroType = DistroType.ToUsers;
					AppLogCfg.Ⴜ(AnnWx, SetTalkCount.Ⴗ(7, null, 1267022532, typeof(SetDxMode)), 'Ļ', 'Ţ');
					num = ⴀ[307] - 27825;
					continue;
				case 12:
					ႰႰ.Ⴄ(AnnWx, ႨႨ.Ⴀ(2, 4, 1157905964), 'ʹ', 'ˀ');
					num = ⴄႤ[239];
					continue;
				case 20:
					ShowLog.Ⴗ(AnnWx, cmd.Ⴍ().Call, 901, 'Ή');
					AppLogCfg.Ⴜ(AnnWx, cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call, '8', 'b');
						num = ⴀႼ[141] - 110;
						continue;
					case 7:
						qslinfoResponse.Ⴅ(AnnWx, qslinfoResponse.Ⴗ(cmd.Ⴍ().Call, CallBlockCacheCfg.Ⴅ(null, 8, 62058052, null), cmd.Ⴍ().Io.EndPoint, ReplyMail.Ⴅ(3, 15, 1217945011), 718, 'ʭ'), '\u0300', '\u0348');
						num = ⴀႼ[93] - 117;
						continue;
					case 18:
						TalkSpotHelp.Ⴃ(AnnWx, ShowAnnHelp.Ⴅ('Ȇ', 567), '\u0307', 854);
						num = 5;
						continue;
					case 5:
						ChatRoomPvtCfg.Ⴅ(AnnWx, cmd.Rx.GetMsgEnd(1), 1015, 'Ͽ');
						num = ⴍႭ[163] - 17750;
						continue;
					case 6:
						AppLogCfg.Ⴜ(AnnWx, SetTalkCount.Ⴗ(2, null, 1267017781, typeof(PublishInfo)), 'Ϧ', 'ξ');
						num = 4;
						continue;
					case 4:
						flag = ProcessSpot(cmd);
						goto case 15;
					case 15:
						ByeHelp.Ⴄ((PrecisionTimer)obj2, 'Ŝ', 271);
						num = ⴅ[6];
						continue;
					case 0:
						num = ((!flag) ? 10 : 14);
						continue;
					case 14:
					{
						ILog ⴍ2 = Ⴍ;
						Array array = new object[4];
						((object[])array)[0] = (PrecisionTimer)obj2;
						(array as object[])[1] = cmd.Ⴍ().Call;
						(array as object[])[2] = SetStationClubHelp.Ⴍ(3, 2, 1747257858, null);
						(array as object[])[3] = cmd.Tx.Msg[0];
						ⴍ2.Info(SetDxDefaultHelp.Ⴍ((object[])array, '\u034c', 805));
						num = ⴀႳ[300] - 10815;
						continue;
					}
					case 3:
						obj3 = new Publisher();
						goto case 23;
					case 23:
						(obj3 as Publisher).Process(cmd);
						num = ⴃႥ[78] - 62902;
						continue;
					case 10:
						num = ((!qslinfoRequest.Ⴗ(AnnWx, 82, 67)) ? 1 : 19);
						continue;
					case 19:
						num = ((!qslinfoRequest.Ⴗ(AnnWx, 579, 594)) ? (ⴐ[275] - ⴐ[8]) : 21);
						continue;
					case 17:
					case 21:
						num = (cmd.Ⴍ().Ⴅ().Ⴍ()
							.AppLog.LogAnnWxDupes ? 1 : 9);
						continue;
					case 1:
					{
						ILog ⴍ = Ⴍ;
						object obj = new object[4];
						((object[])obj)[0] = obj2 as PrecisionTimer;
						((object[])obj)[1] = cmd.Ⴍ().Call;
						(obj as object[])[2] = SetStationClubHelp.Ⴍ(11, 3, 1747257859, null);
						((object[])obj)[3] = cmd.Tx.Msg[0];
						ⴍ.Warn(string.Concat((object[])obj));
						num = 9;
						continue;
					}
					case 16:
						Ⴄ(cmd);
						break;
					case 9:
						break;
					}
					break;
				}
			}
			catch (Exception)
			{
				Ⴄ(cmd);
			}
			switch (4)
			{
			}
		}
	}
