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
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.AnnWx;

public sealed class AnnWxSpotClient : AnnWxSpotBase, IArcCmd
{
	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(ReplyMail.Ⴅ(5, 13, 1217944690), 330, 343);

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		try
		{
			int num = 11;
			object obj2 = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj2 as PrecisionTimer, 818, 883);
					ShowLog.Ⴗ(AnnWx, cmd.Rx.Msg, 878, '\u0361');
					num = 8;
					continue;
				case 4:
				case 8:
					AppLogCfg.Ⴜ(AnnWx, cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call, 'ɘ', 'Ȃ');
						num = 1;
						continue;
					case 1:
						qslinfoResponse.Ⴅ(AnnWx, qslinfoResponse.Ⴗ(cmd.Ⴍ().Call, CallBlockCacheCfg.Ⴅ(null, 1, 62058061, null), cmd.Ⴍ().Io.EndPoint, ReplyMail.Ⴅ(6, 4, 1217945014), 792, 'ͻ'), 'Ē', 'Ś');
						num = ⴀႨ[33] - 62140;
						continue;
					case 16:
						TalkSpotHelp.Ⴃ(AnnWx, ShowAnnHelp.Ⴅ('ù', 200), 'f', 55);
						num = 0;
						continue;
					case 0:
						num = ((!ByeHelp.Ⴍ(SunCalculations.Ⴍ(AnnWx, 726, 671), CallBlockCacheCfg.Ⴅ(null, 2, 62057592, null), 588, 555)) ? 9 : (ⴄႭ[84] - ⴄႭ[221]));
						continue;
					case 13:
						cmd.Tx.DistroType = DistroType.ToAll;
						num = 3;
						continue;
					case 9:
						cmd.Tx.DistroType = DistroType.ToUsers;
						goto case 3;
					case 3:
						num = ((!ByeHelp.Ⴍ(SunCalculations.Ⴍ(AnnWx, 307, 377), ReplyMail.Ⴅ(6, 11, 1217944966), 73, 46)) ? 12 : 7);
						continue;
					case 7:
						AppLogCfg.Ⴜ(AnnWx, ReplyMail.Ⴅ(7, 5, 1217945003), 'Ɔ', 'Ǟ');
						goto case 12;
					case 12:
						flag = ProcessSpot(cmd);
						ByeHelp.Ⴄ((PrecisionTimer)obj2, 'û', 168);
						num = ⴄႭ[239] - 12;
						continue;
					case 5:
						num = ((!flag) ? 6 : 10);
						continue;
					case 10:
					{
						ILog ⴅ3 = Ⴅ;
						Array array = new object[4];
						(array as object[])[0] = (PrecisionTimer)obj2;
						((object[])array)[1] = cmd.Ⴍ().Call;
						((object[])array)[2] = SetStationClubHelp.Ⴍ(2, 7, 1747257863, null);
						(array as object[])[3] = cmd.Tx.Msg[0];
						ⴅ3.Info(SetDxDefaultHelp.Ⴍ(array as object[], 'Ȝ', 629));
						num = 15;
						continue;
					}
					case 15:
					{
						object obj3 = new Publisher();
						((Publisher)obj3).Process(cmd);
						num = ⴀႳ[25] - 26711;
						continue;
					}
					case 6:
					case 21:
						num = ((!qslinfoRequest.Ⴗ(AnnWx, 407, 390)) ? ⴀႼ[113] : (ⴄႤ[448] - ⴄႤ[258]));
						continue;
					case 19:
						num = ((!qslinfoRequest.Ⴗ(AnnWx, 804, 821)) ? 20 : 14);
						continue;
					case 14:
					case 17:
						num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
							.AppLog.LogAnnWxDupes) ? 20 : (ⴅ[62] - 163));
						continue;
					case 2:
					{
						ILog ⴅ2 = Ⴅ;
						object obj = new object[4];
						((object[])obj)[0] = (PrecisionTimer)obj2;
						((object[])obj)[1] = cmd.Ⴍ().Call;
						((object[])obj)[2] = SetStationClubHelp.Ⴍ(9, 1, 1747257857, null);
						((object[])obj)[3] = cmd.Tx.Msg[0];
						ⴅ2.Warn(string.Concat(obj as object[]));
						break;
					}
					case 20:
						break;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				Ⴅ.Warn(SetStationQth.Ⴍ(null, 1687351439, 5, 30) + cmd.Rx.Msg + ႰႥ.Ⴅ(3, 'ª', 952620209) + ex.Message);
			}
			switch (3)
			{
			}
		}
	}
