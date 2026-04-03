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
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.AnnWx;

public sealed class WxFullUser : AnnWxSpotBase, IArcCmd
{
	private static readonly ILog Ⴃ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(2, null, 1267021958, typeof(ArcEngine.ArcCmds.User.Talk.Talk)), 639, 610);

	private static void Ⴍ(NodeUserCmd P_0)
	{
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 2:
			case 4:
				obj = new WxFullHelp();
				break;
			case 3:
				break;
			case 0:
				return;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(2, 4, 1157903763), P_0.Rx.Msg, 209, 159));
			num = 2;
		}
		((WxFullHelp)obj).Exec(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			int num = 16;
			object obj = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					goto case 19;
				case 19:
					ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 505, 440);
					num = ((cmd.Rx.Split.Length <= 2) ? (ⴄႷ[113] - ⴄႷ[113]) : 9);
					continue;
				case 9:
					cmd.Tx.DistroType = DistroType.ToAll;
					AppLogCfg.Ⴜ(AnnWx, SetTalkCount.Ⴗ(3, null, 1267022528, typeof(ArcEngine.ArcCmds.User.Talk.Talk)), '\u0319', '\u0340');
					num = 2;
					continue;
				case 2:
					ႰႰ.Ⴄ(AnnWx, ReplyMail.Ⴅ(6, 15, 1217944966), '\u008e', '÷');
					goto case 7;
				case 7:
					num = 4;
					continue;
				case 4:
					ShowLog.Ⴗ(AnnWx, cmd.Ⴍ().Call, 610, 'ɮ');
					AppLogCfg.Ⴜ(AnnWx, cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call, 'ǣ', 'ƹ');
						num = ⴄႤ[34] - 67;
						continue;
					case 20:
						qslinfoResponse.Ⴅ(AnnWx, qslinfoResponse.Ⴗ(cmd.Ⴍ().Call, CallBlockCacheCfg.Ⴅ(null, 3, 62058063, null), cmd.Ⴍ().Io.EndPoint, ReplyMail.Ⴅ(3, 9, 1217945011), 412, 'ǿ'), '\u02c4', 'ʌ');
						num = 3;
						continue;
					case 3:
						TalkSpotHelp.Ⴃ(AnnWx, ShowAnnHelp.Ⴅ('Ĥ', 277), 'Ċ', 347);
						num = 10;
						continue;
					case 10:
						ChatRoomPvtCfg.Ⴅ(AnnWx, cmd.Rx.GetMsgEnd(2), 491, 'ǣ');
						num = ⴐ[136];
						continue;
					case 18:
						AppLogCfg.Ⴜ(AnnWx, ReplyMail.Ⴅ(5, 8, 1217945001), '\u008d', 'Õ');
						num = ⴃႥ[319] - 38974;
						continue;
					case 8:
						flag = ProcessSpot(cmd);
						ByeHelp.Ⴄ((PrecisionTimer)obj, 'ʌ', 735);
						num = ⴀ[197] - 6376;
						continue;
					case 17:
						num = ((!flag) ? 5 : (ⴀႨ[98] - 41420));
						continue;
					case 14:
					{
						ILog ⴃ2 = Ⴃ;
						object obj3 = new object[4];
						(obj3 as object[])[0] = obj as PrecisionTimer;
						(obj3 as object[])[1] = cmd.Ⴍ().Call;
						(obj3 as object[])[2] = SetStationClubHelp.Ⴍ(10, 6, 1747257862, null);
						(obj3 as object[])[3] = cmd.Tx.Msg[0];
						ⴃ2.Info(SetDxDefaultHelp.Ⴍ((object[])obj3, '\u0345', 812));
						num = 13;
						continue;
					}
					case 13:
					{
						object obj2 = new Publisher();
						(obj2 as Publisher).Process(cmd);
						num = ⴀႣ[231] - 27013;
						continue;
					}
					case 1:
					case 5:
						num = ((!qslinfoRequest.Ⴗ(AnnWx, 369, 352)) ? (ⴃႠ[324] - 29382) : (ⴍႤ[298] - 54749));
						continue;
					case 15:
						num = ((!qslinfoRequest.Ⴗ(AnnWx, 939, 954)) ? (ⴀႳ[231] - 16519) : 21);
						continue;
					case 21:
						num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
							.AppLog.LogAnnWxDupes) ? 6 : 12);
						continue;
					case 12:
					{
						ILog ⴃ = Ⴃ;
						Array array = new object[4];
						((object[])array)[0] = obj as PrecisionTimer;
						(array as object[])[1] = cmd.Ⴍ().Call;
						(array as object[])[2] = SetStationClubHelp.Ⴍ(5, 8, 1747257864, null);
						((object[])array)[3] = cmd.Tx.Msg[0];
						ⴃ.Warn(string.Concat((object[])array));
						num = 6;
						continue;
					}
					case 0:
						Ⴍ(cmd);
						break;
					case 6:
						break;
					}
					break;
				}
			}
			catch (Exception)
			{
				Ⴍ(cmd);
			}
			switch (2)
			{
			}
		}
	}
