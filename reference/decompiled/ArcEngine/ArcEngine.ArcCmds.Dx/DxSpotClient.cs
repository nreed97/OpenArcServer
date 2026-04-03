using System;
using System.Globalization;
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
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Dx;

public sealed class DxSpotClient : DxSpotBase, IArcCmd
{
	private static readonly ILog Ⴃ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('|', 985808689, 7), 249, 228);

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		try
		{
			int num = 15;
			object obj = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 767, 702);
					goto case 2;
				case 2:
					ႰႰ.Ⴈ(SetStationBeepHelp.Ⴓ(329, 378), ShowWxHelp.Ⴍ(',', 985808694, 0), '\t', 41);
					num = 11;
					continue;
				case 11:
					SetAnnDefaultHelp.Ⴀ(base.Dx, cmd.Rx.Msg, 'Α', 'ϳ');
					DxClusterCacheCfg.Ⴗ(base.Dx, cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call, 1014, 992);
						num = 8;
						continue;
					case 8:
						ShowQslInfoHelp.Ⴈ(base.Dx, qslinfoResponse.Ⴗ(cmd.Ⴍ().Call, CallBlockCacheCfg.Ⴅ(null, 4, 62058056, null), cmd.Ⴍ().Io.EndPoint, ReplyMail.Ⴅ(7, 1, 1217945015), 128, 'ã'), 633, 546);
						num = ⴍႤ[329] - 51077;
						continue;
					case 5:
						ShowWx.Ⴅ(base.Dx, ShowAnnHelp.Ⴅ('\u0338', 777), 923, 943);
						num = 17;
						continue;
					case 17:
					{
						DateTime dateTime2 = TalkSpotHelp.Ⴈ(base.Dx, 382, 'ď');
						base.Time = ShowAnnOptionsHelp.Ⴗ(ref dateTime2, ႰႥ.Ⴅ(5, '·', 952619390), 425, 429);
						num = 7;
						continue;
					}
					case 7:
					{
						DateTime dateTime = TalkSpotHelp.Ⴈ(base.Dx, 985, 'Ψ');
						base.Date = ShowAnnOptionsHelp.Ⴗ(ref dateTime, CallBlockCacheCfg.Ⴅ(null, 2, 62057697, null), 839, 835);
						num = 18;
						continue;
					}
					case 6:
					case 18:
						cmd.Tx.MsgType = MsgType.Dx;
						flag = ProcessSpot(cmd);
						ByeHelp.Ⴄ((PrecisionTimer)obj, 'ʃ', 720);
						num = 9;
						continue;
					case 9:
						num = (flag ? 1 : (ⴄႤ[11] - 55));
						continue;
					case 1:
					{
						ILog ⴃ2 = Ⴃ;
						Array array2 = new object[4];
						((object[])array2)[0] = (PrecisionTimer)obj;
						((object[])array2)[1] = cmd.Ⴍ().Call;
						((object[])array2)[2] = SetStationClubHelp.Ⴍ(1, 2, 1747257858, null);
						(array2 as object[])[3] = cmd.Tx.Msg[0];
						ⴃ2.Info(SetDxDefaultHelp.Ⴍ((object[])array2, 'ǔ', 445));
						num = 4;
						continue;
					}
					case 4:
					{
						object obj2 = new Publisher();
						(obj2 as Publisher).Process(cmd);
						num = ⴄႭ[172] - 175;
						continue;
					}
					case 10:
					case 14:
						num = ((!SetAnnDefaultHelp.Ⴅ(base.Dx, 593, 616)) ? (ⴀႨ[69] - 7580) : (ⴃႰ[57] - 49567));
						continue;
					case 16:
						num = ((!SetAnnDefaultHelp.Ⴅ(base.Dx, 302, 279)) ? 3 : 13);
						continue;
					case 13:
						num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
							.AppLog.LogDxDupes) ? (ⴅ[425] - 105) : ⴅ[365]);
						continue;
					case 12:
					{
						ILog ⴃ = Ⴃ;
						Array array = new object[4];
						((object[])array)[0] = obj as PrecisionTimer;
						((object[])array)[1] = cmd.Ⴍ().Call;
						((object[])array)[2] = SetStationClubHelp.Ⴍ(13, 3, 1747257859, null);
						((object[])array)[3] = cmd.Tx.Msg[0];
						ⴃ.Warn(SetDxDefaultHelp.Ⴍ(array as object[], 'ń', 301));
						break;
					}
					case 3:
						break;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				ILog ⴃ3 = Ⴃ;
				object obj3 = new string[6];
				((string[])obj3)[0] = SetStationQth.Ⴍ(null, 1687351434, 0, 17);
				(obj3 as string[])[1] = cmd.Rx.Msg;
				(obj3 as string[])[2] = ReplyMail.Ⴅ(1, 2, 1217945261);
				(obj3 as string[])[3] = CultureInfo.CurrentCulture.Name;
				(obj3 as string[])[4] = ႰႥ.Ⴅ(8, 'Ò', 952620218);
				((string[])obj3)[5] = ex.Message;
				ⴃ3.Warn(string.Concat(obj3 as string[]));
			}
			switch (4)
			{
			}
		}
	}
