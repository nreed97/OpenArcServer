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

public sealed class DxSpotAr17 : DxSpotBase, IArcCmd
{
	private static readonly ILog Ⴗ = SkimmerValidSpot.Ⴐ(CallBlockCacheCfg.Ⴅ(null, 7, 62057079, null), 602, 583);

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		try
		{
			int num = 8;
			object obj = default(object);
			Array array2 = default(Array);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 42, 107);
					ႰႰ.Ⴈ(SetStationBeepHelp.Ⴓ(384, 435), CallBlockCacheCfg.Ⴅ(null, 8, 62057080, null), 'ξ', 926);
					goto case 25;
				case 25:
					num = 15;
					continue;
				case 15:
				{
					string msg = cmd.Rx.Msg;
					object obj5 = new char[1];
					((char[])obj5)[0] = '^';
					array2 = Directory.Ⴓ(msg, obj5 as char[], 838, 784);
					num = 12;
					continue;
				}
				case 12:
					num = ((((string[])array2).Length != 19) ? (ⴃႥ[183] - 11641) : 22);
					continue;
				case 22:
					num = (ShowWwvHelp.Ⴗ(((string[])array2)[2], 'ǉ', 493) ? 18 : 0);
					continue;
				case 18:
					MircIo.Ⴐ(base.Dx, SetWwvDefaultHelp.Ⴗ((array2 as string[])[2], (IFormatProvider)new CultureInfo(SetStationClubHelp.Ⴍ(12, 4, 1747258245, null)), 802, '\u035f'), 121, 47);
					goto case 0;
				case 0:
					SetAnnDefaultHelp.Ⴀ(base.Dx, ((string[])array2)[3], 'ϊ', 'Ε');
					num = 24;
					continue;
				case 24:
					base.Date = SetDxFilter.Ⴀ((array2 as string[])[4], 798, '\u035e');
					num = 23;
					continue;
				case 23:
					base.Time = ShowContestStationHelp.Ⴅ((array2 as string[])[5], ႨႨ.Ⴀ(14, 8, 1157903717), string.Empty, 567, 'ɯ');
					goto case 9;
				case 9:
					num = 16;
					continue;
				case 16:
				{
					DxSpot dx = base.Dx;
					object obj2 = new string[5];
					((string[])obj2)[0] = base.Date;
					(obj2 as string[])[1] = SetTalkCount.Ⴗ(4, null, 1267022535, typeof(ShowCluster.ႨႨ));
					((string[])obj2)[2] = SetTalkOutputHelp.Ⴍ(base.Time, 0, 2, 850, 769);
					(obj2 as string[])[3] = ShowSkimCtyHelp.Ⴍ(1216134124, 7, '\u009d');
					(obj2 as string[])[4] = Clear.Ⴄ(base.Time, 2, 'ͽ', '\u0355');
					ShowWx.Ⴅ(dx, SetAnnWrap.Ⴍ(ShowWwv.Ⴈ((string[])obj2, 'Ƹ', 464), 929, 'Ϯ'), 898, 950);
					num = 21;
					continue;
				}
				case 21:
					SetAnnDefaultHelp.Ⴀ(base.Dx, ((string[])array2)[6], 'Ǆ', 'Ƥ');
					num = 3;
					continue;
				case 3:
					ShowDxOptionsHelp.Ⴍ(base.Dx, ((string[])array2)[7], 556, 582);
					num = ⴅ[397] - 13;
					continue;
				case 1:
					DxClusterCacheCfg.Ⴗ(base.Dx, ((string[])array2)[8], 1005, 1019);
					num = 11;
					continue;
				case 11:
					ShowQslInfoHelp.Ⴈ(base.Dx, cmd.Ⴍ().Call, 163, 248);
					cmd.Tx.MsgType = MsgType.Dx;
					num = 5;
					continue;
				case 5:
					flag = ProcessSpot(cmd);
					ByeHelp.Ⴄ(obj as PrecisionTimer, 'Å', 150);
					num = 7;
					continue;
				case 7:
					num = ((!flag) ? (ⴀႨ[89] - 5110) : (ⴄႷ[139] - 44122));
					continue;
				case 4:
				{
					ILog ⴗ2 = Ⴗ;
					object obj4 = new object[4];
					(obj4 as object[])[0] = (PrecisionTimer)obj;
					((object[])obj4)[1] = cmd.Ⴍ().Call;
					((object[])obj4)[2] = SetStationClubHelp.Ⴍ(6, 3, 1747257859, null);
					(obj4 as object[])[3] = cmd.Tx.Msg[0];
					ⴗ2.Info(SetDxDefaultHelp.Ⴍ((object[])obj4, '\u009a', 243));
					num = 17;
					continue;
				}
				case 17:
				{
					object obj3 = new Publisher();
					(obj3 as Publisher).Process(cmd);
					num = 20;
					continue;
				}
				case 6:
					num = ((!SetAnnDefaultHelp.Ⴅ(base.Dx, 181, 140)) ? (ⴀ[288] - 61464) : (ⴍႤ[296] - 51532));
					continue;
				case 14:
					num = ((!SetAnnDefaultHelp.Ⴅ(base.Dx, 293, 284)) ? 20 : 19);
					continue;
				case 19:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
						.AppLog.LogDxDupes) ? 20 : 13);
					continue;
				case 2:
				case 13:
				{
					ILog ⴗ = Ⴗ;
					Array array = new object[4];
					((object[])array)[0] = obj as PrecisionTimer;
					(array as object[])[1] = cmd.Ⴍ().Call;
					(array as object[])[2] = SetStationClubHelp.Ⴍ(8, 2, 1747257858, null);
					(array as object[])[3] = cmd.Tx.Msg[0];
					ⴗ.Warn(string.Concat(array as object[]));
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
			ILog ⴗ3 = Ⴗ;
			Array array3 = new string[6];
			(array3 as string[])[0] = SetStationQth.Ⴍ(null, 1687351436, 6, 23);
			((string[])array3)[1] = cmd.Rx.Msg;
			((string[])array3)[2] = ReplyMail.Ⴅ(7, 12, 1217945259);
			(array3 as string[])[3] = CultureInfo.CurrentCulture.Name;
			((string[])array3)[4] = ႰႥ.Ⴅ(6, 'ô', 952620212);
			((string[])array3)[5] = (ex as Exception).Message;
			ⴗ3.Warn(string.Concat(array3 as string[]));
		}
		switch (3)
		{
		}
	}
}
