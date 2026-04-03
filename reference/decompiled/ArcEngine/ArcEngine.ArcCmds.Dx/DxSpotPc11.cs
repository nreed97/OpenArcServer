using System;
using System.Globalization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Mirc;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Dx;

public sealed class DxSpotPc11 : DxSpotBase, IArcCmd
{
	private static readonly ILog Ⴃ = SkimmerValidSpot.Ⴐ(CallBlockCacheCfg.Ⴅ(null, 7, 62058154, null), 880, 877);

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		try
		{
			int num = 3;
			object obj = default(object);
			Array array2 = default(Array);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					goto case 25;
				case 25:
					ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 324, 261);
					ႰႰ.Ⴈ(SetStationBeepHelp.Ⴓ(733, 750), CallBlockCacheCfg.Ⴅ(null, 2, 62058159, null), 'ɪ', 586);
					num = ⴍႭ[191] - 25425;
					continue;
				case 8:
				{
					string msg = cmd.Rx.Msg;
					Array array3 = new char[1];
					(array3 as char[])[0] = '^';
					array2 = Directory.Ⴓ(msg, array3 as char[], 407, 449);
					num = 10;
					continue;
				}
				case 10:
					MircIo.Ⴐ(base.Dx, SetWwvDefaultHelp.Ⴗ((array2 as string[])[1], (IFormatProvider)new CultureInfo(SetStationClubHelp.Ⴍ(2, 5, 1747258244, null)), 683, '\u02d6'), 497, 423);
					num = 13;
					continue;
				case 13:
					SetAnnDefaultHelp.Ⴀ(base.Dx, ((string[])array2)[2], 'Ȱ', 'ɯ');
					num = 23;
					continue;
				case 23:
					base.Date = SetDxFilter.Ⴀ((array2 as string[])[3], 309, 'ŵ');
					num = 1;
					continue;
				case 1:
					base.Time = ShowContestStationHelp.Ⴅ((array2 as string[])[4], ႨႨ.Ⴀ(14, 6, 1157903723), string.Empty, 950, 'Ϯ');
					num = ⴍႤ[91] - 37891;
					continue;
				case 20:
				{
					DxSpot dx = base.Dx;
					object obj2 = new string[5];
					(obj2 as string[])[0] = base.Date;
					((string[])obj2)[1] = SetTalkCount.Ⴗ(0, null, 1267022531, typeof(ႥႨ));
					(obj2 as string[])[2] = SetTalkOutputHelp.Ⴍ(base.Time, 0, 2, 637, 558);
					((string[])obj2)[3] = ShowSkimCtyHelp.Ⴍ(1216134121, 2, 'ß');
					(obj2 as string[])[4] = Clear.Ⴄ(base.Time, 2, 'Ä', 'ì');
					ShowWx.Ⴅ(dx, SetAnnWrap.Ⴍ(ShowWwv.Ⴈ((string[])obj2, 'ΰ', 984), 887, '\u0338'), 622, 602);
					num = 16;
					continue;
				}
				case 16:
					SetAnnDefaultHelp.Ⴀ(base.Dx, ((string[])array2)[5], 'ī', 'ŋ');
					num = 7;
					continue;
				case 7:
					ShowDxOptionsHelp.Ⴍ(base.Dx, ((string[])array2)[6], 89, 51);
					num = 12;
					continue;
				case 12:
					num = ((cmd.Ⴍ().Io.IoCfg.Port != 23659) ? (ⴀႳ[324] - 47308) : (ⴄႷ[14] - 21579));
					continue;
				case 15:
				case 22:
				{
					DxSpot dx2 = base.Dx;
					ShowDxOptionsHelp.Ⴍ(dx2, ShowUsersHelp.Ⴅ(ShowVersion.Ⴐ(dx2, 272, 364), ႨႨ.Ⴀ(9, 6, 1157903735), 194, 140), 461, 423);
					goto case 19;
				}
				case 19:
					DxClusterCacheCfg.Ⴗ(base.Dx, ((string[])array2)[7], 279, 257);
					num = ⴃႥ[239] - 50022;
					continue;
				case 9:
					ShowQslInfoHelp.Ⴈ(base.Dx, cmd.Ⴍ().Call, 445, 486);
					goto case 21;
				case 21:
					cmd.Tx.MsgType = MsgType.Dx;
					num = 5;
					continue;
				case 5:
					flag = ProcessSpot(cmd);
					ByeHelp.Ⴄ((PrecisionTimer)obj, 'ͺ', 809);
					num = 6;
					continue;
				case 6:
					num = ((!flag) ? (ⴃႠ[412] - 34619) : 4);
					continue;
				case 4:
				{
					ILog ⴃ2 = Ⴃ;
					Array array4 = new object[4];
					(array4 as object[])[0] = obj as PrecisionTimer;
					(array4 as object[])[1] = cmd.Ⴍ().Call;
					(array4 as object[])[2] = SetStationClubHelp.Ⴍ(11, 4, 1747257860, null);
					((object[])array4)[3] = cmd.Tx.Msg[0];
					ⴃ2.Info(SetDxDefaultHelp.Ⴍ((object[])array4, '\u0383', 1002));
					num = 2;
					continue;
				}
				case 2:
				{
					object obj3 = new Publisher();
					(obj3 as Publisher).Process(cmd);
					num = ⴀႨ[182] - 13123;
					continue;
				}
				case 14:
					num = (SetAnnDefaultHelp.Ⴅ(base.Dx, 542, 551) ? (ⴃႥ[200] - 30006) : 0);
					continue;
				case 17:
					num = ((!SetAnnDefaultHelp.Ⴅ(base.Dx, 769, 824)) ? (ⴀႳ[214] - 16985) : (ⴀႨ[79] - 6705));
					continue;
				case 11:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
						.AppLog.LogDxDupes) ? (ⴀ[516] - 31161) : (ⴀႳ[43] - ⴀႳ[43]));
					continue;
				case 0:
				{
					ILog ⴃ = Ⴃ;
					Array array = new object[4];
					(array as object[])[0] = (PrecisionTimer)obj;
					((object[])array)[1] = cmd.Ⴍ().Call;
					((object[])array)[2] = SetStationClubHelp.Ⴍ(11, 3, 1747257859, null);
					((object[])array)[3] = cmd.Tx.Msg[0];
					ⴃ.Warn(string.Concat(array as object[]));
					break;
				}
				case 24:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ILog ⴃ3 = Ⴃ;
			object obj4 = new string[6];
			((string[])obj4)[0] = SetStationQth.Ⴍ(null, 1687351438, 4, 19);
			((string[])obj4)[1] = cmd.Rx.Msg;
			(obj4 as string[])[2] = ReplyMail.Ⴅ(1, 10, 1217945261);
			((string[])obj4)[3] = CultureInfo.CurrentCulture.Name;
			(obj4 as string[])[4] = ႰႥ.Ⴅ(2, 'g', 952620208);
			(obj4 as string[])[5] = ex.Message;
			ⴃ3.Warn(string.Concat(obj4 as string[]));
		}
		switch (1)
		{
		}
	}
}
