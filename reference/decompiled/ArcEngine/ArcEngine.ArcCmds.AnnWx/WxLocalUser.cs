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
using ArcEngine.ArcDatabase;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.AnnWx;

public sealed class WxLocalUser : AnnWxSpotBase, IArcCmd
{
	public sealed class WxLocalHelp : IArcCmd
	{
		public void Exec(NodeUserCmd cmd)
		{
			int num = 5;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267017834, typeof(TalkMaintenance)));
					num = 0;
					continue;
				case 0:
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131648, 2, 'T'));
					cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(9, null, 1057165211, 2));
					goto case 3;
				case 3:
					num = 4;
					continue;
				case 1:
				case 4:
					obj = new Publisher();
					break;
				case 2:
					break;
				}
				break;
			}
			((Publisher)obj).Process(cmd);
		}
	}

	private static readonly ILog Ⴀ = SkimmerValidSpot.Ⴐ(SetStationQth.Ⴍ(null, 1687352762, 2, 15), 678, 699);

	private static void Ⴅ(NodeUserCmd P_0)
	{
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 4:
				obj = new WxLocalHelp();
				break;
			case 0:
			case 3:
				break;
			case 2:
				return;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(14, 6, 1157906007), P_0.Rx.Msg, 828, 882));
			num = 4;
		}
		(obj as WxLocalHelp).Exec(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		try
		{
			int num = 5;
			object obj2 = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj2, 679, 742);
					num = ((cmd.Rx.Split.Length != 1) ? 13 : 8);
					continue;
				case 8:
				case 15:
				{
					object obj4 = new WxHelp();
					((WxHelp)obj4).Exec(cmd);
					num = 7;
					continue;
				}
				case 13:
					num = ((cmd.Rx.Split.Length <= 1) ? 9 : (ⴄႭ[536] - 241));
					continue;
				case 4:
					cmd.Tx.DistroType = DistroType.ToUsers;
					goto case 23;
				case 23:
					AppLogCfg.Ⴜ(AnnWx, SetTalkCount.Ⴗ(8, null, 1267022539, typeof(ShowTalkOptions)), 'ν', 'Ϥ');
					num = ⴄႤ[47];
					continue;
				case 12:
					ႰႰ.Ⴄ(AnnWx, ReplyMail.Ⴅ(0, 2, 1217944960), 'ɧ', 'Ȟ');
					num = ⴃႰ[20] - 30596;
					continue;
				case 16:
					ShowLog.Ⴗ(AnnWx, cmd.Ⴍ().Call, 898, 'Ύ');
					AppLogCfg.Ⴜ(AnnWx, cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call, '\u0383', 'ϙ');
						num = 14;
						continue;
					case 14:
						qslinfoResponse.Ⴅ(AnnWx, qslinfoResponse.Ⴗ(cmd.Ⴍ().Call, CallBlockCacheCfg.Ⴅ(null, 2, 62058062, null), cmd.Ⴍ().Io.EndPoint, ReplyMail.Ⴅ(3, 7, 1217945011), 135, 'ä'), '\f', 'D');
						num = 2;
						continue;
					case 2:
						TalkSpotHelp.Ⴃ(AnnWx, ShowAnnHelp.Ⴅ('ȧ', 534), 'ƚ', 459);
						num = ⴃႠ[157] - 60689;
						continue;
					case 20:
					case 22:
						ChatRoomPvtCfg.Ⴅ(AnnWx, cmd.Rx.GetMsgEnd(1), 282, 'Ē');
						num = 10;
						continue;
					case 10:
						AppLogCfg.Ⴜ(AnnWx, ReplyMail.Ⴅ(8, 0, 1217944996), 'Ɵ', 'Ǉ');
						num = ⴀႳ[11] - 7279;
						continue;
					case 6:
						flag = ProcessSpot(cmd);
						ByeHelp.Ⴄ((PrecisionTimer)obj2, '³', 224);
						num = 1;
						continue;
					case 1:
						num = (flag ? 11 : 0);
						continue;
					case 11:
					{
						ILog ⴀ2 = Ⴀ;
						Array array = new object[4];
						(array as object[])[0] = obj2 as PrecisionTimer;
						((object[])array)[1] = cmd.Ⴍ().Call;
						(array as object[])[2] = SetStationClubHelp.Ⴍ(8, 7, 1747257863, null);
						(array as object[])[3] = cmd.Tx.Msg[0];
						ⴀ2.Info(SetDxDefaultHelp.Ⴍ(array as object[], '\u0015', 124));
						num = ⴄႭ[492] / 2;
						continue;
					}
					case 18:
					{
						object obj3 = new Publisher();
						(obj3 as Publisher).Process(cmd);
						num = 7;
						continue;
					}
					case 0:
						num = ((!qslinfoRequest.Ⴗ(AnnWx, 999, 1014)) ? (ⴃႠ[92] - 52156) : (ⴍႤ[52] - 30981));
						continue;
					case 3:
						num = ((!qslinfoRequest.Ⴗ(AnnWx, 236, 253)) ? (ⴀႳ[259] - 12437) : 19);
						continue;
					case 19:
						num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
							.AppLog.LogAnnWxDupes) ? 7 : 21);
						continue;
					case 21:
					{
						ILog ⴀ = Ⴀ;
						object obj = new object[4];
						((object[])obj)[0] = obj2 as PrecisionTimer;
						((object[])obj)[1] = cmd.Ⴍ().Call;
						(obj as object[])[2] = SetStationClubHelp.Ⴍ(9, 4, 1747257860, null);
						((object[])obj)[3] = cmd.Tx.Msg[0];
						ⴀ.Warn(string.Concat(obj as object[]));
						num = 7;
						continue;
					}
					case 9:
						Ⴅ(cmd);
						break;
					case 7:
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
