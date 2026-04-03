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
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcIo.Mirc;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Dx;

public sealed class DxSpotMirc : DxSpotBase, IArcCmd
{
	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(8, null, 1267019265, typeof(ႷႣ)), 331, 342);

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		try
		{
			int num = 9;
			bool flag = default(bool);
			object obj = default(object);
			object obj2 = default(object);
			int num2 = default(int);
			IComparable comparable = default(IComparable);
			while (true)
			{
				switch (num)
				{
				default:
					flag = false;
					cmd.Rx.Msg = Clear.Ⴄ(cmd.Rx.Msg, 10, '\u035c', 'ʹ');
					num = 16;
					continue;
				case 16:
					num = ((CallBlockCacheCfg.Ⴜ(cmd.Rx.Msg, 178, 211) == 66) ? 2 : 26);
					continue;
				case 26:
					break;
				case 2:
					obj = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 215, 150);
					ႰႰ.Ⴈ(SetStationBeepHelp.Ⴓ(475, 488), SetTalkCount.Ⴗ(2, null, 1267019275, typeof(ShowSkimCtyHelp)), 'ε', 917);
					num = ⴍႤ[284] - 31674;
					continue;
				case 21:
					SetAnnDefaultHelp.Ⴀ(base.Dx, SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ(cmd.Rx.Msg, 20, 12, 372, 295), 68, '\u0004'), 'ý', '¢');
					num = 20;
					continue;
				case 20:
					SetAnnDefaultHelp.Ⴀ(base.Dx, SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ(cmd.Rx.Msg, 32, 30, 533, 582), 422, 'Ǧ'), 'λ', 'ϛ');
					num = ⴃႰ[198] - 3692;
					continue;
				case 10:
					obj2 = SetTalkOutputHelp.Ⴍ(cmd.Rx.Msg, 0, 20, 845, 798);
					num = 6;
					continue;
				case 6:
					num2 = Clear.Ⴀ(cmd.Rx.Msg, ' ', '\u02ed', 683);
					num = ((num2 <= 0) ? (ⴀႨ[179] - 27566) : ⴅ[125]);
					continue;
				case 27:
					ShowDxOptionsHelp.Ⴍ(base.Dx, SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ(obj2 as string, 0, num2, 892, 815), 979, 'Γ'), 403, 505);
					num = 19;
					continue;
				case 19:
					ShowDxOptionsHelp.Ⴍ(base.Dx, ShowContestStationHelp.Ⴅ(ShowVersion.Ⴐ(base.Dx, 904, 1012), SetStationClubHelp.Ⴍ(9, 3, 1747261916, null), string.Empty, 544, 'ɸ'), 132, 238);
					num = ⴍႭ[347] - 58770;
					continue;
				case 1:
					comparable = SetDxFilter.Ⴀ(Clear.Ⴄ((string)obj2, num2, 'Ϻ', 'ϒ'), 162, 'â');
					num = 11;
					continue;
				case 11:
					MircIo.Ⴐ(base.Dx, Ⴀ((string)comparable), 233, 191);
					goto case 5;
				case 5:
					DxClusterCacheCfg.Ⴗ(base.Dx, ShowUsersHelp.Ⴅ(cmd.Ⴍ().Ⴅ().Ⴓ()
						.Ⴀ(), ReplyMail.Ⴅ(3, 9, 1217941748), 357, 299), 270, 280);
					num = ⴃႠ[146] - 42142;
					continue;
				case 25:
					base.Time = SetTalkOutputHelp.Ⴍ(cmd.Rx.Msg, 62, 4, 367, 316);
					num = ⴍႤ[73] - 60490;
					continue;
				case 23:
				{
					DateTime dateTime = ShowAnnHelp.Ⴅ('œ', 354);
					base.Date = ShowAnnOptionsHelp.Ⴗ(ref dateTime, CallBlockCacheCfg.Ⴅ(null, 2, 62057697, null), 357, 353);
					num = ⴍႭ[175] - 7046;
					continue;
				}
				case 15:
				{
					DxSpot dx = base.Dx;
					Array array3 = new string[5];
					((string[])array3)[0] = base.Date;
					(array3 as string[])[1] = SetTalkCount.Ⴗ(5, null, 1267022534, typeof(DirectorySubjectHelp));
					((string[])array3)[2] = SetTalkOutputHelp.Ⴍ(base.Time, 0, 2, 649, 730);
					(array3 as string[])[3] = ShowSkimCtyHelp.Ⴍ(1216134124, 7, 'F');
					((string[])array3)[4] = Clear.Ⴄ(base.Time, 2, 'Ɏ', 'ɦ');
					ShowWx.Ⴅ(dx, SetAnnWrap.Ⴍ(ShowWwv.Ⴈ((string[])array3, 'ͼ', 788), 956, 'ϳ'), 922, 942);
					num = 18;
					continue;
				}
				case 13:
				case 18:
					ShowQslInfoHelp.Ⴈ(base.Dx, ႨႨ.Ⴀ(8, 3, 1157904465), 499, 424);
					num = ⴀႣ[255] - 417;
					continue;
				case 22:
					cmd.Tx.MsgType = MsgType.DxLocal;
					goto case 4;
				case 4:
					flag = ProcessSpot(cmd);
					goto case 12;
				case 12:
					ByeHelp.Ⴄ((PrecisionTimer)obj, '\u0087', 212);
					num = 24;
					continue;
				case 24:
					num = ((!flag) ? (ⴃႥ[315] - 42393) : 29);
					continue;
				case 29:
				{
					ILog ⴅ3 = Ⴅ;
					Array array2 = new object[4];
					(array2 as object[])[0] = obj as PrecisionTimer;
					(array2 as object[])[1] = cmd.Ⴍ().Call;
					(array2 as object[])[2] = SetStationClubHelp.Ⴍ(11, 0, 1747257856, null);
					(array2 as object[])[3] = cmd.Tx.Msg[0];
					ⴅ3.Info(SetDxDefaultHelp.Ⴍ((object[])array2, 'Đ', 377));
					num = ⴍႤ[432] - 25660;
					continue;
				}
				case 17:
				{
					object obj3 = new Publisher();
					((Publisher)obj3).Process(cmd);
					num = 28;
					continue;
				}
				case 7:
					num = (base.Dx.IsDupe ? 14 : 0);
					continue;
				case 14:
					num = ((!base.Dx.IsDupe) ? (ⴍႭ[331] - 20105) : (ⴀႳ[121] - 35632));
					continue;
				case 3:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
						.AppLog.LogDxDupes) ? (ⴀႼ[96] * 7) : 0);
					continue;
				case 0:
				{
					ILog ⴅ2 = Ⴅ;
					Array array = new object[4];
					(array as object[])[0] = (PrecisionTimer)obj;
					(array as object[])[1] = cmd.Ⴍ().Call;
					(array as object[])[2] = SetStationClubHelp.Ⴍ(12, 5, 1747257861, null);
					(array as object[])[3] = cmd.Tx.Msg[0];
					ⴅ2.Warn(string.Concat(array as object[]));
					break;
				}
				case 28:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ILog ⴅ4 = Ⴅ;
			object obj4 = new string[6];
			(obj4 as string[])[0] = SetStationQth.Ⴍ(null, 1687351434, 0, 8);
			((string[])obj4)[1] = cmd.Rx.Msg;
			((string[])obj4)[2] = ReplyMail.Ⴅ(3, 6, 1217945263);
			(obj4 as string[])[3] = CultureInfo.CurrentCulture.Name;
			((string[])obj4)[4] = ႰႥ.Ⴅ(6, 'e', 952620212);
			((string[])obj4)[5] = (ex as Exception).Message;
			ⴅ4.Warn(string.Concat(obj4 as string[]));
		}
		switch (0)
		{
		}
	}

	private static float Ⴀ(string P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		while (true)
		{
			int num = (LogCacheCfg.Ⴗ(P_0, 928, 929) ? (ⴀႣ[43] - 38047) : ⴄႤ[148]);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 3:
					break;
				case 1:
				case 5:
				case 6:
					return 0f;
				case 0:
					return Convert.ToSingle(P_0, new CultureInfo(SetStationClubHelp.Ⴍ(11, 4, 1747258245, null)));
				}
				break;
			}
		}
	}
}
