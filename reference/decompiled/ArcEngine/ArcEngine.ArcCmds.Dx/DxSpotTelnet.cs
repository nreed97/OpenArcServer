using System;
using System.Globalization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.AnnWx;
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
using ArcEngine.ArcDatabase;
using ArcEngine.ArcIo.Mirc;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Dx;

public sealed class DxSpotTelnet : DxSpotBase, IArcCmd
{
	private static readonly ILog m_Ⴃ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(2, null, 1267017398, typeof(WwvMaintenance)), 751, 754);

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		try
		{
			int num = 0;
			bool flag = default(bool);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					flag = false;
					obj = new PrecisionTimer();
					ႰႰ.Ⴈ(SetStationBeepHelp.Ⴓ(817, 770), SetTalkCount.Ⴗ(0, null, 1267017396, typeof(ႷႰ)), 'λ', 923);
					num = ⴀႼ[98] - 124;
					continue;
				case 3:
					ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 333, 268);
					num = ((!SetAnnDefault.Ⴍ(cmd.Rx.Msg, SetStationQth.Ⴍ(null, 1687354534, 6, 15), 318, 364)) ? (ⴄႤ[239] / 2) : (ⴀႳ[79] - 30169));
					continue;
				case 16:
					cmd.Tx.MsgType = MsgType.DxLocal;
					num = ((BaseCmd.Ⴓ((ClientIoCfg)cmd.Ⴍ().Io.IoCfg, 'ď', 318) == ClientIoType.TelnetExtComment) ? 1 : 11);
					continue;
				case 1:
					flag = Ⴗ(cmd);
					num = 10;
					continue;
				case 11:
					flag = Ⴍ(cmd);
					num = 10;
					continue;
				case 10:
					ByeHelp.Ⴄ(obj as PrecisionTimer, 'Ţ', 305);
					num = ((!flag) ? 7 : 17);
					continue;
				case 17:
					num = ((cmd.Tx.DxCmdMsgExt.SkimmerQuality == null) ? (ⴄႭ[415] - 74) : 6);
					continue;
				case 6:
					num = ((CallBlockCacheCfg.Ⴜ(cmd.Tx.DxCmdMsgExt.SkimmerQuality, 904, 1001) <= 2) ? 2 : 12);
					continue;
				case 12:
				{
					ILog ⴃ3 = DxSpotTelnet.m_Ⴃ;
					Array array2 = new object[6];
					(array2 as object[])[0] = obj as PrecisionTimer;
					(array2 as object[])[1] = cmd.Ⴍ().Call;
					(array2 as object[])[2] = SetStationClubHelp.Ⴍ(8, 8, 1747257864, null);
					(array2 as object[])[3] = cmd.Tx.Msg[0];
					(array2 as object[])[4] = ReplyMail.Ⴅ(1, 7, 1217943651);
					(array2 as object[])[5] = SetTalkOutputHelp.Ⴍ(cmd.Tx.DxCmdMsgExt.SkimmerQuality, 0, CallBlockCacheCfg.Ⴜ(cmd.Tx.DxCmdMsgExt.SkimmerQuality, 956, 989) - 1, 805, 886);
					ⴃ3.Info(SetDxDefaultHelp.Ⴍ((object[])array2, 'Í', 164));
					goto case 15;
				}
				case 15:
					num = 19;
					continue;
				case 2:
				{
					ILog ⴃ2 = DxSpotTelnet.m_Ⴃ;
					object obj2 = new object[5];
					((object[])obj2)[0] = (PrecisionTimer)obj;
					(obj2 as object[])[1] = cmd.Ⴍ().Call;
					((object[])obj2)[2] = SetStationClubHelp.Ⴍ(2, 8, 1747257864, null);
					((object[])obj2)[3] = cmd.Tx.Msg[0];
					(obj2 as object[])[4] = cmd.Tx.DxCmdMsgExt.SkimmerQuality;
					ⴃ2.Info(SetDxDefaultHelp.Ⴍ(obj2 as object[], 'ż', 277));
					goto case 19;
				}
				case 19:
				{
					object obj3 = new Publisher();
					(obj3 as Publisher).Process(cmd);
					num = ⴀႨ[143] - 64086;
					continue;
				}
				case 7:
					num = ((!SetAnnDefaultHelp.Ⴅ(base.Dx, 365, 340)) ? (ⴍႤ[481] - 37707) : 8);
					continue;
				case 8:
					num = ((!SetAnnDefaultHelp.Ⴅ(base.Dx, 263, 318)) ? 5 : 9);
					continue;
				case 9:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
						.AppLog.LogDxDupes) ? 5 : 4);
					continue;
				case 4:
				case 14:
				{
					ILog ⴃ = DxSpotTelnet.m_Ⴃ;
					Array array = new object[4];
					((object[])array)[0] = obj as PrecisionTimer;
					((object[])array)[1] = cmd.Ⴍ().Call;
					((object[])array)[2] = SetStationClubHelp.Ⴍ(10, 1, 1747257857, null);
					(array as object[])[3] = cmd.Tx.Msg[0];
					ⴃ.Warn(SetDxDefaultHelp.Ⴍ(array as object[], 'ɕ', 572));
					break;
				}
				case 5:
				case 13:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ILog ⴃ4 = DxSpotTelnet.m_Ⴃ;
			Array array3 = new string[6];
			((string[])array3)[0] = SetStationQth.Ⴍ(null, 1687351433, 3, 24);
			((string[])array3)[1] = cmd.Rx.Msg;
			((string[])array3)[2] = ReplyMail.Ⴅ(7, 6, 1217945259);
			(array3 as string[])[3] = CultureInfo.CurrentCulture.Name;
			(array3 as string[])[4] = ႰႥ.Ⴅ(3, '\u0080', 952620209);
			((string[])array3)[5] = ex.Message;
			ⴃ4.Warn(string.Concat((string[])array3));
		}
		switch (0)
		{
		}
	}

	private bool Ⴍ(NodeUserCmd P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num3 = default(int);
		while (true)
		{
			ICloneable msg = P_0.Rx.Msg;
			msg = ShowContestStationHelp.Ⴅ((string)msg, SetStationClubHelp.Ⴍ(1, 4, 1747263128, null), string.Empty, 908, 'ϔ');
			int num = 9;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 1;
					continue;
				case 1:
					break;
				case 9:
					num3 = Clear.Ⴀ(msg as string, ':', 'Ͳ', 820);
					num = ((num3 <= 0) ? (ⴃႠ[192] - 23550) : ⴄႤ[504]);
					continue;
				case 13:
					ShowDxOptionsHelp.Ⴍ(base.Dx, SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ(msg as string, 6, num3 - 6, 410, 457), 348, 'Ĝ'), 480, 394);
					goto case 5;
				case 5:
				case 11:
					num = 7;
					continue;
				case 7:
					MircIo.Ⴐ(base.Dx, Ⴃ(SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ(msg as string, num3 + 1, 25 - num3 - 1, 701, 750), 287, 'ş')), 812, 890);
					num = 8;
					continue;
				case 8:
					SetAnnDefaultHelp.Ⴀ(base.Dx, SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ(msg as string, 26, 13, 256, 339), 1019, 'λ'), 'D', '\u001b');
					num = ⴃႰ[57] - 49580;
					continue;
				case 3:
				{
					int num2 = CallBlockCacheCfg.Ⴜ(msg as string, 418, 451);
					num = ((num2 != 76) ? (ⴍႭ[266] - 51337) : 6);
					continue;
				}
				case 6:
					base.Time = SetTalkOutputHelp.Ⴍ(msg as string, 71, 4, 467, 384);
					num = 0;
					continue;
				case 0:
					SetAnnDefaultHelp.Ⴀ(base.Dx, AnnFullHelp.Ⴍ(SetTalkOutputHelp.Ⴍ(msg as string, 40, 30, 529, 578), new char[0], 180, '§'), '\u0340', '\u0320');
					num = 10;
					continue;
				case 14:
					base.Time = SetTalkOutputHelp.Ⴍ(msg as string, 70, 4, 432, 483);
					num = 17;
					continue;
				case 17:
					SetAnnDefaultHelp.Ⴀ(base.Dx, AnnFullHelp.Ⴍ(SetTalkOutputHelp.Ⴍ((string)msg, 39, 30, 295, 372), new char[0], 543, 'Ȍ'), '\u001c', '|');
					goto case 10;
				case 10:
				{
					DateTime dateTime = ShowAnnHelp.Ⴅ('\u02fd', 716);
					base.Date = ShowAnnOptionsHelp.Ⴗ(ref dateTime, CallBlockCacheCfg.Ⴅ(null, 2, 62057697, null), 766, 762);
					num = 16;
					continue;
				}
				case 16:
				{
					DxSpot dx = base.Dx;
					object obj = new string[5];
					(obj as string[])[0] = base.Date;
					((string[])obj)[1] = SetTalkCount.Ⴗ(1, null, 1267022530, typeof(ႨႼ));
					(obj as string[])[2] = base.Time.Substring(0, 2);
					(obj as string[])[3] = ShowSkimCtyHelp.Ⴍ(1216134120, 3, '\u001c');
					((string[])obj)[4] = base.Time.Substring(2);
					dx.Dts = Convert.ToDateTime(string.Concat((string[])obj));
					goto case 12;
				}
				case 12:
					num = 18;
					continue;
				case 18:
					base.Dx.SpotterNode = P_0.Ⴍ().Ⴅ().Ⴓ()
						.Ⴀ() + ReplyMailHelp.Ⴄ(7, null, 1057165917, 2);
					num = 2;
					continue;
				case 2:
					base.Dx.Route = P_0.Ⴍ().Call;
					return ProcessSpot(P_0);
				case 4:
					return false;
				}
				break;
			}
		}
	}

	private bool Ⴗ(NodeUserCmd P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			IEquatable<string> msg = P_0.Rx.Msg;
			msg = ShowContestStationHelp.Ⴅ((string)msg, SetStationClubHelp.Ⴍ(3, 2, 1747263134, null), string.Empty, 487, 'ƿ');
			int num = 16;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2:
					break;
				case 16:
					num3 = Clear.Ⴀ((string)msg, ':', 'ˏ', 649);
					num = ((num3 <= 0) ? (ⴃႥ[309] - 45443) : 3);
					continue;
				case 3:
					ShowDxOptionsHelp.Ⴍ(base.Dx, SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ(msg as string, 6, num3 - 6, 958, 1005), 751, 'ʯ'), 983, 957);
					num = 15;
					continue;
				case 15:
					MircIo.Ⴐ(base.Dx, Ⴃ(SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ((string)msg, 17, 9, 955, 1000), 489, 'Ʃ')), 573, 619);
					num = 14;
					continue;
				case 14:
					SetAnnDefaultHelp.Ⴀ(base.Dx, SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ((string)msg, 28, 10, 121, 42), 950, '϶'), 'ʺ', '\u02e5');
					num = 9;
					continue;
				case 9:
					SetAnnDefaultHelp.Ⴀ(base.Dx, AnnFullHelp.Ⴍ(SetTalkOutputHelp.Ⴍ(msg as string, 39, 30, 273, 322), new char[0], 315, 'Ĩ'), '\u036c', '\u030c');
					num = 10;
					continue;
				case 10:
					num2 = ShowLog.Ⴃ((string)msg, 'Z', '\u035e', 839);
					num = ((num2 <= 0) ? ⴅ[6] : 11);
					continue;
				case 11:
					base.Time = SetTalkOutputHelp.Ⴍ((string)msg, num2 - 4, 4, 374, 293);
					goto case 0;
				case 0:
				{
					DateTime dateTime = ShowAnnHelp.Ⴅ('ˠ', 721);
					base.Date = ShowAnnOptionsHelp.Ⴗ(ref dateTime, CallBlockCacheCfg.Ⴅ(null, 8, 62057707, null), 330, 334);
					num = ⴍႤ[193] - 9323;
					continue;
				}
				case 4:
				{
					DxSpot dx = base.Dx;
					object obj = new string[5];
					(obj as string[])[0] = base.Date;
					(obj as string[])[1] = SetTalkCount.Ⴗ(0, null, 1267022531, typeof(ShowAnnOptionsHelp));
					(obj as string[])[2] = base.Time.Substring(0, 2);
					(obj as string[])[3] = ShowSkimCtyHelp.Ⴍ(1216134122, 1, 'Ò');
					(obj as string[])[4] = base.Time.Substring(2);
					dx.Dts = Convert.ToDateTime(string.Concat(obj as string[]));
					num = ⴃႰ[17] - 56145;
					continue;
				}
				case 5:
					base.Dx.SpotterNode = P_0.Ⴍ().Ⴅ().Ⴓ()
						.Ⴀ() + ReplyMailHelp.Ⴄ(10, null, 1057165915, 4);
					goto case 1;
				case 1:
				case 6:
				case 12:
					num = ⴄႷ[66] - 17235;
					continue;
				case 7:
					base.Dx.Route = P_0.Ⴍ().Call;
					return ProcessSpot(P_0);
				case 13:
					return false;
				}
				break;
			}
		}
	}

	private static float Ⴃ(string P_0)
	{
		while (true)
		{
			bool num = LogCacheCfg.Ⴗ(P_0, 8, 9);
			IpLockoutCacheCfg.ႭႭ[215] = (char)((IpLockoutCacheCfg.ႭႭ[215] - IpLockoutCacheCfg.ႭႭ[100]) & 0x1C);
			int num2 = (num ? 6 : 4);
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
				case 3:
					break;
				case 4:
				case 5:
					return 0f;
				case 1:
				case 6:
					return Convert.ToSingle(P_0, new CultureInfo(SetStationClubHelp.Ⴍ(13, 2, 1747258243, null)));
				}
				break;
			}
		}
	}
}
