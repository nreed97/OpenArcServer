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
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.AnnWx;

public sealed class AnnWxPc12 : AnnWxSpotBase, IArcCmd
{
	private static readonly ILog Ⴐ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('\u0094', 985806636, 8), 947, 942);

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		try
		{
			int num = 5;
			object obj2 = default(object);
			Array array = default(Array);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
				{
					obj2 = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj2 as PrecisionTimer, 722, 659);
					string msg = cmd.Rx.Msg;
					object obj4 = new char[1];
					((char[])obj4)[0] = '^';
					array = Directory.Ⴓ(msg, obj4 as char[], 825, 879);
					num = 1;
					continue;
				}
				case 1:
					ShowLog.Ⴗ(AnnWx, ((string[])array)[1], 284, 'Đ');
					num = 19;
					continue;
				case 19:
					AppLogCfg.Ⴜ(AnnWx, (array as string[])[2], '\u001a', 'B');
					goto case 16;
				case 16:
					num = 12;
					continue;
				case 12:
					ChatRoomPvtCfg.Ⴅ(AnnWx, ((string[])array)[3], 530, 'Ț');
					num = ⴅ[6];
					continue;
				case 0:
					AppLogCfg.Ⴜ(AnnWx, (array as string[])[4], 'ò', '«');
					num = ⴀႼ[2];
					continue;
				case 18:
					AppLogCfg.Ⴜ(AnnWx, ((string[])array)[5], 'ʳ', '\u02e9');
					num = 15;
					continue;
				case 15:
					ႰႰ.Ⴄ(AnnWx, (array as string[])[6], 'ʣ', '\u02da');
					num = 4;
					continue;
				case 4:
					TalkSpotHelp.Ⴃ(AnnWx, ShowAnnHelp.Ⴅ('ŋ', 378), 'ΰ', 993);
					num = 2;
					continue;
				case 2:
				case 6:
					qslinfoResponse.Ⴅ(AnnWx, cmd.Ⴍ().Call, 'Τ', 'Ϭ');
					cmd.Tx.DistroType = DistroType.ToAll;
					num = 3;
					continue;
				case 3:
					flag = ProcessSpot(cmd);
					ByeHelp.Ⴄ((PrecisionTimer)obj2, 'Ŋ', 281);
					num = 14;
					continue;
				case 14:
					num = ((!flag) ? 13 : 20);
					continue;
				case 20:
				{
					ILog ⴐ2 = Ⴐ;
					Array array2 = new object[4];
					(array2 as object[])[0] = (PrecisionTimer)obj2;
					(array2 as object[])[1] = cmd.Ⴍ().Call;
					(array2 as object[])[2] = SetStationClubHelp.Ⴍ(1, 3, 1747257859, null);
					(array2 as object[])[3] = cmd.Tx.Msg[0];
					ⴐ2.Info(SetDxDefaultHelp.Ⴍ((object[])array2, 'Ǎ', 420));
					goto case 11;
				}
				case 11:
					num = 9;
					continue;
				case 9:
				{
					object obj3 = new Publisher();
					((Publisher)obj3).Process(cmd);
					num = ⴃႥ[64] - 26222;
					continue;
				}
				case 13:
					num = ((!qslinfoRequest.Ⴗ(AnnWx, 213, 196)) ? 8 : 21);
					continue;
				case 21:
					num = ((!qslinfoRequest.Ⴗ(AnnWx, 84, 69)) ? 10 : (ⴃႥ[81] - 13212));
					continue;
				case 7:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
						.AppLog.LogAnnWxDupes) ? 10 : 8);
					continue;
				case 8:
				{
					ILog ⴐ = Ⴐ;
					object obj = new object[4];
					((object[])obj)[0] = obj2 as PrecisionTimer;
					(obj as object[])[1] = cmd.Ⴍ().Call;
					((object[])obj)[2] = SetStationClubHelp.Ⴍ(9, 3, 1747257859, null);
					(obj as object[])[3] = cmd.Tx.Msg[0];
					ⴐ.Warn(string.Concat((object[])obj));
					break;
				}
				case 10:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴐ.Warn(SetStationQth.Ⴍ(null, 1687351432, 2, 19) + cmd.Rx.Msg + ႰႥ.Ⴅ(0, '5', 952620210) + ex.Message);
		}
		switch (1)
		{
		}
	}
}
