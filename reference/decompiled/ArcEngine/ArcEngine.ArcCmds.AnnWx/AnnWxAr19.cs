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

public sealed class AnnWxAr19 : AnnWxSpotBase, IArcCmd
{
	private static readonly ILog Ⴗ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('È', 985806516, 8), 1017, 996);

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		try
		{
			int num = 19;
			object obj2 = default(object);
			object obj3 = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
				{
					obj2 = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj2 as PrecisionTimer, 986, 923);
					string msg = cmd.Rx.Msg;
					object obj5 = new char[1];
					(obj5 as char[])[0] = '^';
					obj3 = Directory.Ⴓ(msg, (char[])obj5, 279, 321);
					num = 3;
					continue;
				}
				case 3:
					ShowLog.Ⴗ(AnnWx, (obj3 as string[])[2], 375, 'Ż');
					num = 1;
					continue;
				case 1:
					AppLogCfg.Ⴜ(AnnWx, ((string[])obj3)[3], '\u00ad', 'õ');
					num = 7;
					continue;
				case 7:
					ChatRoomPvtCfg.Ⴅ(AnnWx, (obj3 as string[])[4], 17, '\u0019');
					num = ⴄႤ[170] - 212;
					continue;
				case 0:
					AppLogCfg.Ⴜ(AnnWx, (obj3 as string[])[5], 'Ș', 'Ɂ');
					num = ⴀႣ[6] - 36795;
					continue;
				case 2:
					AppLogCfg.Ⴜ(AnnWx, ((string[])obj3)[6], 'Ξ', 'τ');
					num = 5;
					continue;
				case 5:
					ႰႰ.Ⴄ(AnnWx, ((string[])obj3)[7], 'Ϧ', 'Ο');
					num = ⴀႣ[380] - 26115;
					continue;
				case 8:
					TalkSpotHelp.Ⴃ(AnnWx, ShowAnnHelp.Ⴅ('U', 100), 'Ϲ', 936);
					num = ⴀႳ[302] - 61664;
					continue;
				case 22:
					num = ((!SetTalkDefaultHelp.Ⴈ(SetDxFilter.Ⴀ(LotwCacheCfg.Ⴀ(AnnWx, 185, 'Î'), 850, '\u0313'), ႨႨ.Ⴀ(1, 8, 1157904477), 828, 848)) ? 10 : 12);
					continue;
				case 12:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႠ()
						.Ⴍ(SunCalculations.Ⴍ(AnnWx, 288, 361))) ? 24 : (ⴍႭ[159] - 34468));
					continue;
				case 23:
					cmd.Tx.DistroType = DistroType.ToPubChatRoom;
					cmd.Tx.To = SunCalculations.Ⴍ(AnnWx, 195, 138);
					num = 16;
					continue;
				case 24:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႳ()
						.Ⴀ(SunCalculations.Ⴍ(AnnWx, 20, 93))) ? 16 : 9);
					continue;
				case 9:
					cmd.Tx.DistroType = DistroType.ToPvtChatRoom;
					cmd.Tx.To = SunCalculations.Ⴍ(AnnWx, 365, 292);
					num = 16;
					continue;
				case 10:
					cmd.Tx.DistroType = DistroType.ToAll;
					goto case 16;
				case 16:
					qslinfoResponse.Ⴅ(AnnWx, cmd.Ⴍ().Call, 'Ÿ', 'İ');
					flag = ProcessSpot(cmd);
					num = ⴐ[204];
					continue;
				case 6:
					ByeHelp.Ⴄ((PrecisionTimer)obj2, '\u02f6', 677);
					num = ((!flag) ? (ⴀ[321] - 31047) : 20);
					continue;
				case 20:
				{
					ILog ⴗ2 = Ⴗ;
					Array array = new object[4];
					((object[])array)[0] = (PrecisionTimer)obj2;
					((object[])array)[1] = cmd.Ⴍ().Call;
					((object[])array)[2] = SetStationClubHelp.Ⴍ(2, 1, 1747257857, null);
					((object[])array)[3] = cmd.Tx.Msg[0];
					ⴗ2.Info(SetDxDefaultHelp.Ⴍ(array as object[], '\u0339', 848));
					num = 26;
					continue;
				}
				case 21:
				case 26:
				{
					object obj4 = new Publisher();
					((Publisher)obj4).Process(cmd);
					num = ⴍႤ[280] - 58256;
					continue;
				}
				case 17:
				case 25:
					num = ((!qslinfoRequest.Ⴗ(AnnWx, 244, 229)) ? (ⴃႰ[53] - 30346) : 18);
					continue;
				case 18:
					num = ((!qslinfoRequest.Ⴗ(AnnWx, 69, 84)) ? 11 : ⴄႤ[504]);
					continue;
				case 13:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
						.AppLog.LogAnnWxDupes) ? 11 : (ⴀႣ[88] - 11511));
					continue;
				case 15:
				{
					ILog ⴗ = Ⴗ;
					object obj = new object[4];
					(obj as object[])[0] = obj2 as PrecisionTimer;
					(obj as object[])[1] = cmd.Ⴍ().Call;
					(obj as object[])[2] = SetStationClubHelp.Ⴍ(0, 8, 1747257864, null);
					((object[])obj)[3] = cmd.Tx.Msg[0];
					ⴗ.Warn(string.Concat((object[])obj));
					break;
				}
				case 11:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴗ.Warn(SetStationClubHelp.Ⴍ(14, 5, 1747261909, null) + cmd.Rx.Msg + ႰႥ.Ⴅ(3, '\n', 952621290) + (ex as Exception).Message);
		}
		switch (3)
		{
		}
	}
}
