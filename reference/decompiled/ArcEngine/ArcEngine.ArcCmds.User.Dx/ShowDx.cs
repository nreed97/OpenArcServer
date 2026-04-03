using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.Node.Pc;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcObjs.ArcUtils;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using Common.Logging;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class ShowDx : IArcCmd
{
	private enum ႥႼ
	{

	}

	private static readonly ILog Ⴈ = NodeUserCmd.Ⴗ(SetStationQth.Ⴍ(null, 1687352702, 4, 12), 575, 594);

	private void Ⴍ(NodeUserCmd P_0)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				object obj = new ShowDxHelp();
				(obj as ShowDxHelp).Exec(P_0);
				return;
			}
			case 2:
				return;
			}
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(1, 3, 1157904639), P_0.Rx.Msg, 194, 140));
			num = 1;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		try
		{
			int num = 21;
			ႥႼ ⴅႼ = default(ႥႼ);
			int num2 = default(int);
			ICloneable cloneable = default(ICloneable);
			Array array = default(Array);
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					ⴅႼ = (ႥႼ)0;
					cmd.Tx.DistroType = DistroType.ToRequester;
					num2 = ShowQslInfoHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 1008, 906), 'w', 75);
					num = 5;
					continue;
				case 5:
					cloneable = string.Empty;
					num = ((cmd.Rx.Split.Length != 3) ? (ⴀႳ[273] - 64069) : 17);
					continue;
				case 10:
				case 17:
					num = ((!ByeHelp.Ⴍ(LogEntry.Ⴄ(cmd.Rx.Split[2], '\u035a', 880), CallBlockCacheCfg.Ⴅ(null, 7, 62056359, null), 250, 157)) ? (ⴃႥ[374] - 45357) : 15);
					continue;
				case 15:
					cloneable = SetStationClubHelp.Ⴍ(9, 4, 1747255681, null);
					num = ⴅ[169] / 7;
					continue;
				case 6:
					num = ((cmd.Rx.Split.Length < 3) ? 22 : (ⴀ[351] - 58066));
					continue;
				case 24:
					cloneable = cmd.Rx.GetMsgEnd2(2);
					num = ⴄႤ[166] - ⴄႤ[137];
					continue;
				case 22:
					cloneable = HamQthCfg.Ⴅ((string)cloneable, CallBlockCacheCfg.Ⴅ(null, 8, 62056358, null), string.Empty, RegexOptions.IgnoreCase, 'Ȯ', 566);
					num = ⴐ[112];
					continue;
				case 26:
					num = (SetAnnDefault.Ⴍ(LogEntry.Ⴄ(cloneable as string, 'ǅ', 495), SetStationQth.Ⴍ(null, 1687353910, 7, 26), 612, 566) ? 25 : (ⴃႠ[70] - 48893));
					continue;
				case 9:
					num = ((CallBlockCacheCfg.Ⴜ(cloneable as string, 257, 352) <= 0) ? 8 : 20);
					continue;
				case 20:
				{
					string obj2 = cloneable as string;
					Array array2 = new char[1];
					((char[])array2)[0] = ' ';
					array = Directory.Ⴓ(obj2, array2 as char[], 268, 346);
					num = ⴅ[318] - 1;
					continue;
				}
				case 29:
					num = (((array as string[]).Length <= 0) ? (ⴃႠ[402] - 22719) : (ⴃႥ[401] - 25380));
					continue;
				case 19:
					num = ((!SkimmerValidSpot.Ⴈ((array as string[])[0], 590, 570)) ? 30 : (ⴀႳ[181] - 60248));
					continue;
				case 28:
					num2 = ShowVersion.Ⴄ(((string[])array)[0], 'Ŏ', 'ż');
					num3 = Clear.Ⴀ((string)cloneable, ' ', 'ú', 188);
					num = 13;
					continue;
				case 13:
					num = ((num3 <= 0) ? ⴀႼ[96] : 0);
					continue;
				case 0:
					cloneable = Clear.Ⴄ(cloneable as string, num3 + 1, 'Ė', 'ľ');
					num = 30;
					continue;
				case 4:
					cloneable = string.Empty;
					num = 30;
					continue;
				case 30:
					num = ((CallBlockCacheCfg.Ⴜ(cloneable as string, 30, 127) <= 0) ? 8 : 16);
					continue;
				case 16:
					num = ((!SkimmerValidSpot.Ⴈ(cloneable as string, 931, 983)) ? 8 : 3);
					continue;
				case 3:
					cloneable = ShowUsersHelp.Ⴅ(SetTalkCount.Ⴗ(0, null, 1267019378, typeof(AddNodePc19)), cloneable as string, 797, 851);
					num = ⴅ[210];
					continue;
				case 8:
					num = ((ShowNodes.Ⴄ(cloneable as string, ႰႥ.Ⴅ(6, 'ú', 952622897), 680, 663) <= -1) ? (ⴀ[435] - 13737) : (ⴍႭ[347] - 58744));
					continue;
				case 27:
					ⴅႼ = (ႥႼ)1;
					cloneable = ShowContestStationHelp.Ⴅ((string)cloneable, ႰႥ.Ⴅ(3, 'ñ', 952622900), string.Empty, 594, 'Ȋ');
					num = 23;
					continue;
				case 23:
					num = (((cloneable as string).IndexOf(ShowWxHelp.Ⴍ('³', 985807915, 3)) <= -1) ? (ⴃႠ[213] - 47842) : (ⴀႣ[347] - 48135));
					continue;
				case 1:
				case 7:
					ⴅႼ = (ႥႼ)2;
					cloneable = (cloneable as string).Replace(ShowWxHelp.Ⴍ('\u00b8', 985807914, 2), string.Empty);
					num = 18;
					continue;
				case 18:
					cloneable = cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴃ()
						.FormatSqlFilter(cloneable as string);
					num2 = Math.Min(num2, cmd.Ⴍ().Ⴅ().Ⴍ()
						.SpotProcessing.MaxNmbrDxSpots);
					goto case 2;
				case 2:
					num = 11;
					continue;
				case 11:
					Ⴗ(cmd, ⴅႼ, cloneable as string, num2);
					cmd.Ⴀ();
					cmd.Ⴍ().SendId();
					num = ⴃႰ[80] - 24191;
					continue;
				case 12:
				{
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					num = 25;
					continue;
				}
				case 25:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴍ(cmd);
		}
		switch (0)
		{
		}
	}

	private static void Ⴗ(NodeUserCmd P_0, ႥႼ P_1, string P_2, int P_3)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 4;
		int num4 = default(int);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		object dataTable = default(object);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = ((!ႷႷ.Ⴍ(SetDxFilter.Ⴀ(P_2, 157, 'Ü'), 973, 'π')) ? 1 : (ⴍႭ[19] - 38508));
				break;
			case 11:
				P_2 = AnnHelp.Ⴈ(CallBlockCacheCfg.Ⴅ(null, 0, 62054505, null), P_2, ႨႨ.Ⴀ(4, 5, 1157903552), 221, 'ê');
				num = 1;
				break;
			case 1:
				num = ((!ShowTalk.Ⴀ(P_2, ႰႥ.Ⴅ(1, 'm', 952621288), 688, 'ˑ')) ? (ⴐ[408] - 138) : 10);
				break;
			case 3:
			case 8:
			case 10:
				enumerable = SetDxFilter.Ⴀ(ShowContestStationHelp.Ⴅ(P_2, ႰႥ.Ⴅ(8, 'V', 952621281), string.Empty, 408, 'ǀ'), 642, '\u02c2');
				num = ⴀ[311] - 60446;
				break;
			case 14:
				num = ((CallBlockCacheCfg.Ⴜ(ShowSkimmerHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 689, 715), 711, 725), 433, 464) <= 0) ? 13 : 15);
				break;
			case 15:
				num = ((CallBlockCacheCfg.Ⴜ(P_2, 562, 595) <= 0) ? (ⴀႣ[236] - 22279) : (ⴀႳ[259] - 12435));
				break;
			case 9:
				enumerable = qslinfoResponse.Ⴗ(SetStationClubHelp.Ⴍ(7, 4, 1747258348, null), ShowSkimmerHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 468, 430), 694, 676), ReplyMailHelp.Ⴄ(22, null, 1057161349, 2), P_2, 723, 'ʰ');
				num = 2;
				break;
			case 0:
			case 13:
				num = ((CallBlockCacheCfg.Ⴜ(P_2, 119, 22) <= 0) ? 12 : (ⴀႨ[219] - 45724));
				break;
			case 5:
				enumerable = P_2;
				num = ⴀႣ[411] - 60777;
				break;
			case 12:
				enumerable = ShowSkimmerHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 764, 646), 935, 949);
				num = 2;
				break;
			case 2:
				dataTable = P_0.Ⴍ().Ⴅ().Ⴀ()
					.Ⴃ()
					.GetDataTable((string)enumerable, P_3);
				num = ⴀႣ[23] - 53179;
				break;
			case 7:
				if ((DataTable)dataTable == null)
				{
					num = 6;
					break;
				}
				while (true)
				{
					int num2 = ((DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(dataTable as DataTable, 'ȭ', 557), (short)610, (short)575) != 0) ? 1 : 2);
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 9:
							break;
						case 2:
							P_0.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132451, 0, 'r'));
							return;
						case 1:
							num2 = ((((DataTable)dataTable).Rows.Count <= P_3) ? 10 : 15);
							continue;
						case 15:
							num4 = ((DataTable)dataTable).Rows.Count - P_3;
							num2 = 10;
							continue;
						case 6:
						case 10:
							num3 = num4;
							num2 = 0;
							continue;
						case 14:
							num2 = P_1 switch
							{
								(ႥႼ)0 => ⴀႣ[211] - 42933, 
								(ႥႼ)1 => ⴃႠ[75] - 14925, 
								(ႥႼ)2 => 4, 
								_ => ⴃႥ[330] - 24844, 
							};
							continue;
						case 12:
							num2 = 3;
							continue;
						case 8:
							GetPlayBackFormat(P_0, (dataTable as DataTable).Rows[num3]);
							goto case 13;
						case 13:
							num2 = 3;
							continue;
						case 7:
							Ⴀ(P_0, (dataTable as DataTable).Rows[num3]);
							num2 = 3;
							continue;
						case 4:
							Ⴗ(P_0, (dataTable as DataTable).Rows[num3]);
							goto case 3;
						case 3:
							num3++;
							num2 = 0;
							continue;
						case 0:
							num2 = ((num3 < ((DataTable)dataTable).Rows.Count) ? (ⴀႼ[96] + 10) : 5);
							continue;
						case 5:
						case 11:
							return;
						}
						break;
					}
				}
			case 6:
				Ⴈ.Warn(AnnHelp.Ⴈ(P_0.Ⴍ().Call, ႰႥ.Ⴅ(5, '\u0013', 952620215), P_2, 731, 'ˬ'));
				return;
			}
		}
	}

	public static void GetPlayBackFormat(NodeUserCmd cmd, DataRow row)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 8;
		double num2 = default(double);
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = (double)qslinfoSoapClient.Ⴓ(row, ႨႨ.Ⴀ(9, 0, 1157905517), 291, 'ŭ');
				num = 3;
				break;
			case 3:
				comparable = ႷႳ.Ⴗ(ref num2, ShowWxHelp.Ⴍ('è', 985806519, 3), 691, 'ʦ');
				num = 1;
				break;
			case 1:
				comparable = qslinfoResponse.Ⴃ((string)comparable, 10, ' ', 83, 'l');
				comparable = ShowUsersHelp.Ⴅ(comparable as string, UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(row, SetTalkCount.Ⴗ(5, null, 1267022182, typeof(ShowPrefixCallsHelp)), 728, 'ʖ'), 'ʊ', 737), 253, 179);
				num = 4;
				break;
			case 4:
			{
				comparable = PublishInfo.Ⴄ(comparable as string, 22, ' ', 825, 794);
				string obj = (string)comparable;
				DateTime dateTime = (DateTime)qslinfoSoapClient.Ⴓ(row, ႰႥ.Ⴅ(4, '\u0099', 952620233), 779, '\u0345');
				comparable = obj + ShowAnnOptionsHelp.Ⴗ(ref dateTime, SetTalkCount.Ⴗ(5, null, 1267022660, typeof(SetStationLatLon)), 713, 717) + CallBlockCacheCfg.Ⴅ(null, 6, 62058421, null) + SetDxFilter.Ⴀ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(row, ႰႥ.Ⴅ(5, '3', 952622297), 835, '\u030d'), '\u033c', 855), 249, '¹');
				num = 7;
				break;
			}
			case 7:
				comparable = (comparable as string).PadRight(70, ' ');
				comparable = (comparable as string) + ShowSkimCtyHelp.Ⴍ(1216133148, 0, '©') + row[ReplyMailHelp.Ⴄ(2, null, 1057162069, 7)].ToString().Trim() + ReplyMail.Ⴅ(4, 3, 1217944635);
				goto case 6;
			case 6:
				num = ⴃႰ[107] - 9438;
				break;
			case 2:
				Ⴅ(cmd, row, comparable as string);
				return;
			case 5:
				return;
			}
		}
	}

	private static void Ⴅ(NodeUserCmd P_0, DataRow P_1, string P_2)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 12;
		IComparable comparable = default(IComparable);
		bool flag = default(bool);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			switch (num)
			{
			default:
				comparable = UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(P_1, ShowSkimCtyHelp.Ⴍ(1216131548, 4, '\u001a'), 416, 'Ǯ'), 'í', 134);
				num = 18;
				break;
			case 18:
				flag = (bool)qslinfoSoapClient.Ⴓ(P_1, SetStationClubHelp.Ⴍ(6, 8, 1747258405, null), 547, 'ɭ');
				goto case 22;
			case 22:
				num = ⴀႳ[108] - 41955;
				break;
			case 13:
				enumerable = string.Empty;
				num = ((!HamQthCfg.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 916, 1006), 466, 'Ɠ'), 'ǃ', 'Ƃ')) ? 17 : 2);
				break;
			case 2:
				num = ((!flag) ? (ⴍႤ[157] - 37344) : (ⴍႤ[427] - 18748));
				break;
			case 5:
			case 20:
				enumerable = ShowWxHelp.Ⴍ(':', 985808857, 4);
				num = 17;
				break;
			case 17:
				num = ((!SetWxCountHelp.Ⴀ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 61, 71), 439, 'Ƕ'), 44, 112)) ? (ⴃႥ[338] - 3851) : (ⴀႼ[98] - 126));
				break;
			case 1:
				num = ((CallBlockCacheCfg.Ⴜ((string)enumerable, 531, 626) >= 2) ? (ⴃႰ[58] - 19203) : (ⴀႣ[300] - 62481));
				break;
			case 11:
				enumerable = ShowUsersHelp.Ⴅ((string)enumerable, comparable as string, 871, 809);
				num = ⴃႰ[108] - 48235;
				break;
			case 21:
				enumerable = AnnHelp.Ⴈ((string)enumerable, ReplyMailHelp.Ⴄ(26, null, 1057162114, 4), comparable as string, 35, '\u0014');
				num = 3;
				break;
			case 3:
				num = (ByeHelp.Ⴍ(comparable as string, ReplyMailHelp.Ⴄ(26, null, 1057162201, 2), 99, 4) ? 15 : 0);
				break;
			case 15:
				num = ((!SetStationClub.Ⴄ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 808, 850), 535, 'ɖ'), 925, 984)) ? (ⴍႤ[359] - 6544) : 4);
				break;
			case 4:
				num = ((CallBlockCacheCfg.Ⴜ((string)enumerable, 261, 356) >= 2) ? (ⴄႤ[324] - 237) : (ⴄႤ[51] / 3));
				break;
			case 9:
				enumerable = ShowUsersHelp.Ⴅ(enumerable as string, UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(P_1, ShowSkimCtyHelp.Ⴍ(1216131545, 7, '\v'), 632, 'ȶ'), 'Ɩ', 509), 306, 380);
				num = ⴅ[20];
				break;
			case 6:
				enumerable = ShowPrefixCalls.Ⴃ((object)(string)enumerable, (object)ReplyMailHelp.Ⴄ(11, null, 1057162126, 8), qslinfoSoapClient.Ⴓ(P_1, ShowSkimCtyHelp.Ⴍ(1216131546, 4, '_'), 312, 'Ŷ'), '»', 145);
				num = 10;
				break;
			case 10:
				num = ((!P_0.Ⴍ().Cfg.Dx.CommentExt.County) ? ⴄႭ[66] : (ⴃႠ[216] - 62950));
				break;
			case 14:
			case 19:
				num = ((((string)enumerable).Length >= 2) ? 7 : (ⴃႥ[374] - 45339));
				break;
			case 24:
				enumerable = (string)enumerable + P_1[ReplyMailHelp.Ⴄ(31, null, 1057163958, 0)].ToString();
				num = 0;
				break;
			case 7:
				enumerable = (enumerable as string) + ReplyMailHelp.Ⴄ(15, null, 1057162113, 7) + P_1[ReplyMailHelp.Ⴄ(31, null, 1057163952, 6)];
				num = 0;
				break;
			case 0:
				num = ((!Ⴄ(((string)enumerable).Length, P_2)) ? 23 : 8);
				break;
			case 8:
				convertible = P_2.Substring(0, 69 - (enumerable as string).Length) + (enumerable as string) + P_2.Substring(69);
				num = 16;
				break;
			case 23:
				convertible = P_2;
				num = 16;
				break;
			case 16:
				P_0.Tx.Msg.Add((string)convertible);
				return;
			}
		}
	}

	private static bool Ⴄ(int P_0, string P_1)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		while (true)
		{
			int num = 70 - P_0;
			int num2 = num;
			int num3 = ⴍႤ[350] - 15042;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = ⴅ[464] - 142;
					continue;
				case 6:
					break;
				case 4:
				case 7:
					num3 = ((SetStationNeedsHelp.Ⴃ(P_1, num2, 297, 330) != ' ') ? (ⴀႳ[79] - 30183) : 0);
					continue;
				case 2:
					return false;
				case 0:
					num2++;
					num3 = 3;
					continue;
				case 3:
					num3 = ((num2 >= 70) ? 1 : (ⴀႼ[60] - 74));
					continue;
				case 1:
				case 8:
					return true;
				}
				break;
			}
		}
	}

	private static void Ⴀ(NodeUserCmd P_0, DataRow P_1)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 4;
		double num2 = default(double);
		IComparable comparable = default(IComparable);
		DateTime dateTime = default(DateTime);
		object obj = default(object);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = (double)qslinfoSoapClient.Ⴓ(P_1, ႨႨ.Ⴀ(8, 6, 1157905515), 977, 'Ο');
				num = 2;
				break;
			case 2:
				comparable = ႷႳ.Ⴗ(ref num2, ႰႥ.Ⴅ(7, 'P', 952619059), 74, '_');
				num = ⴐ[257];
				break;
			case 7:
				dateTime = (DateTime)qslinfoSoapClient.Ⴓ(P_1, ႰႥ.Ⴅ(6, 'A', 952620235), 376, 'Ķ');
				num = ⴀႳ[80] - 56120;
				break;
			case 0:
			case 6:
				enumerable = ShowPrefixCalls.Ⴃ((object)SetTalkCount.Ⴗ(8, null, 1267019302, typeof(UtilsDatabase)), qslinfoSoapClient.Ⴓ(P_1, ReplyMailHelp.Ⴄ(19, null, 1057162065, 3), 558, 'ɠ'), (object)ShowSkimCtyHelp.Ⴍ(1216134122, 1, 'Ô'), 'Ǔ', 505);
				num = 3;
				break;
			case 3:
				enumerable = PublishInfo.Ⴄ((string)enumerable, 24 - CallBlockCacheCfg.Ⴜ(comparable as string, 607, 574), ' ', 829, 798);
				num = ⴀႼ[54] - 69;
				break;
			case 9:
			{
				object obj2 = (string)enumerable;
				obj = new object[4];
				((object[])obj)[0] = obj2;
				num = ⴍႤ[56] - 14302;
				break;
			}
			case 8:
			case 13:
				((object[])obj)[1] = (string)comparable;
				goto case 1;
			case 1:
				(obj as object[])[2] = CallBlockCacheCfg.Ⴅ(null, 4, 62058423, null);
				num = 10;
				break;
			case 10:
				(obj as object[])[3] = qslinfoSoapClient.Ⴓ(P_1, SetTalkCount.Ⴗ(3, null, 1267022176, typeof(SetAnnMode)), 944, 'Ͼ');
				num = 5;
				break;
			case 5:
				enumerable = SetDxDefaultHelp.Ⴍ((object[])obj, 'ϐ', 953);
				enumerable = PublishInfo.Ⴄ((string)enumerable, 39, ' ', 629, 598) + P_1[ႰႥ.Ⴅ(2, 'Í', 952622302)];
				num = 11;
				break;
			case 11:
				enumerable = ((string)enumerable).PadRight(70, ' ') + dateTime.ToString(ReplyMailHelp.Ⴄ(4, null, 1057161792, 6));
				num = 12;
				break;
			case 12:
				P_0.Tx.Msg.Add(enumerable as string);
				return;
			}
		}
	}

	private static void Ⴗ(NodeUserCmd P_0, DataRow P_1)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 12;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		DateTime dateTime = default(DateTime);
		object obj2 = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				enumerable = SetDxFilter.Ⴀ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(P_1, ShowSkimCtyHelp.Ⴍ(1216133141, 1, '6'), 374, 'ĸ'), 'π', 939), 456, 'ƈ');
				num = ⴅ[255] - 245;
				break;
			case 1:
				enumerable = ScrubRoute(enumerable as string);
				goto case 11;
			case 11:
				dateTime = (DateTime)qslinfoSoapClient.Ⴓ(P_1, ႰႥ.Ⴅ(7, 'Ñ', 952620234), 12, 'B');
				num = ⴄႭ[94];
				break;
			case 7:
				obj = ShowAnnOptionsHelp.Ⴗ(ref dateTime, SetTalkCount.Ⴗ(5, null, 1267022660, typeof(MailManager)), 140, 136);
				num = ⴃႠ[360] - 55997;
				break;
			case 8:
			{
				IConvertible convertible = obj as string;
				obj2 = new string[5];
				((string[])obj2)[0] = (string)convertible;
				num = 9;
				break;
			}
			case 9:
				((string[])obj2)[1] = SetTalkCount.Ⴗ(2, null, 1267022529, typeof(SpotProcessingCfg));
				goto case 4;
			case 4:
				num = 3;
				break;
			case 3:
				((string[])obj2)[2] = SetDxFilter.Ⴀ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(P_1, SetTalkCount.Ⴗ(6, null, 1267022181, typeof(Arc4Client)), 188, 'ò'), 'Ȥ', 591), 676, 'ˤ');
				num = ⴀ[139] - 30228;
				break;
			case 5:
				(obj2 as string[])[3] = ReplyMailHelp.Ⴄ(8, null, 1057162083, 7);
				num = ⴀႼ[142] - 58;
				break;
			case 2:
			case 10:
				(obj2 as string[])[4] = SetDxFilter.Ⴀ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(P_1, ReplyMailHelp.Ⴄ(16, null, 1057162074, 8), 121, '7'), 'Ǳ', 410), 858, '\u031a');
				num = 6;
				break;
			case 6:
				obj = ShowWwv.Ⴈ(obj2 as string[], '\u034c', 804);
				obj = (string)obj + ႨႨ.Ⴀ(6, 4, 1157902496) + ((DateTime)P_1[SetStationQth.Ⴍ(null, 1687353272, 3, 18)]).ToString(SetTalkCount.Ⴗ(1, null, 1267019302, typeof(SkimmerCt1bohCache)));
				num = ⴀႳ[121] - 35635;
				break;
			case 0:
				obj = (string)obj + SetStationQth.Ⴍ(null, 1687354106, 1, 28) + (enumerable as string);
				num = 13;
				break;
			case 13:
				P_0.Tx.Msg.Add((string)obj);
				return;
			}
		}
	}

	public static string ScrubRoute(string msg)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		bool flag2 = default(bool);
		bool flag = default(bool);
		IEquatable<string> equatable = default(IEquatable<string>);
		int num2 = default(int);
		while (true)
		{
			Array array = SkimmerServerData.Ⴃ(SetDxFilter.Ⴀ(msg, 62, '~'), '\u02de', 658);
			int num = 10;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႠ[177] - 5188;
					continue;
				case 15:
					break;
				case 10:
					flag2 = false;
					flag = false;
					equatable = string.Empty;
					num2 = 0;
					goto case 5;
				case 5:
					num = ⴍႤ[81] - 29124;
					continue;
				case 6:
					num = ((((char[])array)[num2] != '[') ? (ⴐ[367] * 2) : 14);
					continue;
				case 14:
					flag2 = true;
					goto case 20;
				case 20:
					equatable = SetWxCountHelp.Ⴗ((object)(string)equatable, (object)(array as char[])[num2], 844, (short)823);
					num = ⴄႤ[143] - 73;
					continue;
				case 8:
					num = (((array as char[])[num2] != ']') ? (ⴃႠ[151] - 42615) : (ⴀႨ[109] - 2189));
					continue;
				case 9:
					flag2 = false;
					flag = false;
					equatable = SetWxCountHelp.Ⴗ((object)(string)equatable, (object)((char[])array)[num2], 732, (short)679);
					num = 2;
					continue;
				case 1:
					num = ((!flag2) ? (ⴄႤ[54] - ⴄႤ[50]) : 0);
					continue;
				case 0:
					num = ((((char[])array)[num2] != ':') ? (ⴀႨ[227] - 31303) : 7);
					continue;
				case 7:
					flag = true;
					num = 2;
					continue;
				case 16:
					num = (flag ? 2 : (ⴃႠ[232] - 22996));
					continue;
				case 12:
					num = ((((char[])array)[num2] != '.') ? 3 : 11);
					continue;
				case 11:
					num = (flag2 ? (ⴍႤ[190] - 43816) : 18);
					continue;
				case 18:
					equatable = SetWxCountHelp.Ⴗ((object)(equatable as string), (object)'<', 992, (short)923);
					num = 2;
					continue;
				case 3:
				case 17:
					equatable = (string)equatable + (array as char[])[num2];
					num = ⴐ[154] - 94;
					continue;
				case 2:
				{
					num2++;
					char num3 = ⴄႷ[31];
					SetTalkCountHelp.Ⴅ[15] = (byte)((SetTalkCountHelp.Ⴅ[15] - SetTalkCountHelp.Ⴅ[413]) & 0xB0);
					num = num3 - 42319;
					continue;
				}
				case 4:
					num = ((num2 < (array as char[]).Length) ? 6 : 13);
					continue;
				case 13:
					return equatable as string;
				}
				break;
			}
		}
	}
}
