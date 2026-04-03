using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Xml.Serialization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Dx;
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
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public static class ShDxOpdx
{
	public static void ShowDxOpdx1(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		try
		{
			int num = 18;
			object msgEnd = default(object);
			DateTime dateTime = default(DateTime);
			DateTime dateTime2 = default(DateTime);
			object obj4 = default(object);
			object obj2 = default(object);
			ISupportInitialize supportInitialize = default(ISupportInitialize);
			object obj3 = default(object);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					msgEnd = cmd.Rx.GetMsgEnd(3);
					num = ((!ShowWwvHelp.Ⴗ(msgEnd as string, '1', 20)) ? 3 : 20);
					continue;
				case 20:
					dateTime = SetAnnWrap.Ⴍ((string)msgEnd, 378, 'ĵ');
					dateTime2 = SetAnnWrap.Ⴃ(ref dateTime, 1.0, 61, 97);
					num = 11;
					continue;
				case 11:
					obj2 = ReplyMail.Ⴅ(5, 10, 1217943276);
					obj2 = ShowUsersHelp.Ⴅ(obj2 as string, ReplyMailHelp.Ⴄ(17, null, 1057163328, 7), 387, 461);
					num = ⴃႠ[70] - 48890;
					continue;
				case 12:
					obj2 = ShowUsersHelp.Ⴅ(obj2 as string, CallBlockCacheCfg.Ⴅ(null, 8, 62056134, null), 63, 113);
					goto case 21;
				case 21:
					num = ⴀႣ[99] - ⴀႣ[99];
					continue;
				case 0:
					obj2 = ShowUsersHelp.Ⴅ(obj2 as string, SetStationClubHelp.Ⴍ(14, 3, 1747256246, null), 704, 654);
					num = 13;
					continue;
				case 13:
				{
					object obj5 = (string)obj2;
					obj4 = new object[6];
					(obj4 as object[])[0] = obj5;
					num = ⴅ[147] + 1;
					continue;
				}
				case 19:
					(obj4 as object[])[1] = SetStationQth.Ⴍ(null, 1687353618, 2, 28);
					num = 9;
					continue;
				case 9:
					(obj4 as object[])[2] = dateTime;
					((object[])obj4)[3] = SetStationClubHelp.Ⴍ(1, 1, 1747256313, null);
					num = ⴀႨ[216] - 59548;
					continue;
				case 5:
					(obj4 as object[])[4] = dateTime2;
					((object[])obj4)[5] = ReplyMail.Ⴅ(1, 3, 1217943135);
					num = 10;
					continue;
				case 10:
					obj2 = SetDxDefaultHelp.Ⴍ(obj4 as object[], 'ň', 289);
					obj2 = ShowUsersHelp.Ⴅ(obj2 as string, SetTalkCount.Ⴗ(6, null, 1267018483, typeof(SetDxCount)), 68, 10);
					num = 6;
					continue;
				case 6:
					supportInitialize = new DataSet();
					obj3 = new SqlCeDataAdapter(obj2 as string, cmd.Ⴍ().Ⴅ().Ⴍ()
						.Configuration.DbConnect);
					num = 17;
					continue;
				case 14:
				case 17:
					ShowDxFilter.Ⴄ((DbDataAdapter)(SqlCeDataAdapter)obj3, supportInitialize as DataSet, SetStationClubHelp.Ⴍ(6, 2, 1747257820, null), '\u02db', 'ʁ');
					num = ⴅ[145];
					continue;
				case 7:
					num2 = 0;
					num = ⴃႥ[111] - 24819;
					continue;
				case 8:
					ShowDx.GetPlayBackFormat(cmd, qslinfoRequestBody.Ⴍ(ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(supportInitialize as DataSet, 'ϛ', 'Φ'), 0, 'ş', 267), 'Ǎ', 461), num2, '\u02f4', 723));
					num = 2;
					continue;
				case 2:
					num2++;
					num = 1;
					continue;
				case 1:
					num = ((num2 < ((DataSet)supportInitialize).Tables[0].Rows.Count) ? (ⴍႤ[111] - 53932) : (ⴄႤ[171] - 163));
					continue;
				case 15:
				case 16:
				{
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					num = ⴀ[14] - 32168;
					continue;
				}
				case 3:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687353607, 3, 14) + ex.Message);
		}
		switch (3)
		{
		}
	}

	public static void ShowDxOpdx2(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		try
		{
			int num = 29;
			object msgEnd = default(object);
			DateTime dateTime2 = default(DateTime);
			DateTime dateTime = default(DateTime);
			object obj5 = default(object);
			object obj3 = default(object);
			ICloneable cloneable = default(ICloneable);
			IXmlSerializable xmlSerializable = default(IXmlSerializable);
			int num2 = default(int);
			int num4 = default(int);
			IConvertible convertible2 = default(IConvertible);
			int num3 = default(int);
			object obj4 = default(object);
			IConvertible convertible = default(IConvertible);
			Array array = default(Array);
			while (true)
			{
				switch (num)
				{
				default:
					msgEnd = cmd.Rx.GetMsgEnd(3);
					num = (ShowWwvHelp.Ⴗ(msgEnd as string, 'á', 196) ? 1 : (ⴄႷ[28] - 45666));
					continue;
				case 1:
					dateTime2 = SetAnnWrap.Ⴍ(msgEnd as string, 647, 'ˈ');
					dateTime2 = SetAnnWrap.Ⴃ(ref dateTime2, 1.0, 83, 15);
					num = 3;
					continue;
				case 3:
					dateTime = SetAnnWrap.Ⴃ(ref dateTime2, -7.0, 37, 121);
					dateTime2 = SetWwvOutput.Ⴗ(ref dateTime2, -1.0, 'Ʉ', 514);
					num = 18;
					continue;
				case 18:
					cloneable = SetTalkCount.Ⴗ(7, null, 1267018453, typeof(TalkCacheCfg));
					obj5 = (string)cloneable;
					num = 15;
					continue;
				case 15:
					obj3 = new object[6];
					(obj3 as object[])[0] = obj5;
					((object[])obj3)[1] = SetStationClubHelp.Ⴍ(2, 8, 1747256288, null);
					num = ⴍႤ[152] - 62665;
					continue;
				case 22:
					((object[])obj3)[2] = dateTime;
					(obj3 as object[])[3] = ReplyMail.Ⴅ(4, 0, 1217943122);
					goto case 0;
				case 0:
					num = ⴀႨ[39] - 33462;
					continue;
				case 17:
					((object[])obj3)[4] = dateTime2;
					(obj3 as object[])[5] = CallBlockCacheCfg.Ⴅ(null, 6, 62056079, null);
					num = 9;
					continue;
				case 9:
					cloneable = SetDxDefaultHelp.Ⴍ(obj3 as object[], '\u0352', 827);
					cloneable = ShowUsersHelp.Ⴅ((string)cloneable, ShowWxHelp.Ⴍ(':', 985806863, 2), 912, 990);
					num = ⴀႣ[113] - 24801;
					continue;
				case 23:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, ShowSkimCtyHelp.Ⴍ(1216131311, 1, '}'), 547, 621);
					num = ⴄႷ[129] - 22977;
					continue;
				case 13:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, ႰႥ.Ⴅ(8, 'Á', 952622419), 79, 1);
					num = 8;
					continue;
				case 8:
					xmlSerializable = null;
					num2 = 0;
					num4 = 1;
					convertible2 = string.Empty;
					num3 = 0;
					num = ⴄႤ[477] - 81;
					continue;
				case 6:
				case 31:
					obj4 = UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(qslinfoRequestBody.Ⴍ(ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(xmlSerializable as DataSet, 'Ε', 'Ϩ'), 0, 'ϝ', 905), 'ȴ', 564), num3, 'Ȍ', 555), ShowSkimCtyHelp.Ⴍ(1216131547, 3, 'Ä'), 908, 'ς'), '\u0017', 124);
					num = 27;
					continue;
				case 27:
					num = ((CallBlockCacheCfg.Ⴜ((string)obj4, 521, 616) <= 0) ? ⴄႭ[246] : 24);
					continue;
				case 24:
					num = ((!ByeHelp.Ⴍ(obj4 as string, ReplyMailHelp.Ⴄ(25, null, 1057163279, 8), 327, 303)) ? (ⴀႨ[23] - 24027) : 4);
					continue;
				case 4:
					convertible2 = qslinfoResponse.Ⴗ((string)convertible2, SetTalkCount.Ⴗ(0, null, 1267022531, typeof(BadWordCache)), (string)obj4, ShowWxHelp.Ⴍ('@', 985808780, 1), 998, '\u0385');
					num = 11;
					continue;
				case 11:
					num2++;
					num = ((CallBlockCacheCfg.Ⴜ((string)convertible2, 651, 746) <= 70 * num4) ? 2 : 26);
					continue;
				case 26:
					convertible2 = ShowUsersHelp.Ⴅ(convertible2 as string, ReplyMailHelp.Ⴄ(19, null, 1057162487, 6), 837, 779);
					num = 20;
					continue;
				case 20:
					num4++;
					num = 2;
					continue;
				case 2:
					num3++;
					num = 21;
					continue;
				case 21:
					num = ((num3 < DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)xmlSerializable, 'ǚ', 'Ƨ'), 0, 'ˉ', 669), '0', 48), (short)454, (short)411)) ? 6 : (ⴍႤ[485] - 28493));
					continue;
				case 14:
					convertible2 = SetTalkOutputHelp.Ⴍ(convertible2 as string, 0, CallBlockCacheCfg.Ⴜ(convertible2 as string, 883, 786) - 1, 517, 598);
					num = ⴅ[133] - 187;
					continue;
				case 5:
					convertible = SetTalkCount.Ⴗ(8, null, 1267018430, typeof(DxSpotClient));
					convertible = (convertible as string) + ShowAnnOptionsHelp.Ⴗ(ref dateTime, ShowSkimCtyHelp.Ⴍ(1216131327, 2, '@'), 460, 456) + ShowSkimCtyHelp.Ⴍ(1216131214, 5, 'ê') + dateTime2.ToString(ShowSkimCtyHelp.Ⴍ(1216131323, 6, '£'));
					num = 19;
					continue;
				case 19:
				{
					object obj2 = (string)convertible;
					array = new object[4];
					(array as object[])[0] = obj2;
					num = ⴃႥ[66] - 30353;
					continue;
				}
				case 7:
					(array as object[])[1] = SetStationClubHelp.Ⴍ(0, 4, 1747256288, null);
					num = ⴄႷ[77] - 61859;
					continue;
				case 25:
					(array as object[])[2] = num2;
					((object[])array)[3] = SetStationClubHelp.Ⴍ(0, 0, 1747256087, null);
					num = ⴄႷ[4] - 30640;
					continue;
				case 12:
					convertible = string.Concat((object[])array);
					cmd.Tx.Msg.Add((convertible as string) + (convertible2 as string));
					num = ⴃႠ[229] - 45255;
					continue;
				case 10:
				{
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					num = 16;
					continue;
				}
				case 16:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687353633, 3, 22) + ex.Message);
		}
		switch (3)
		{
		}
	}

	public static void ShowDxOpdx3(NodeUserCmd cmd)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		try
		{
			int num = 4;
			IComparable msgEnd = default(IComparable);
			DateTime dateTime = default(DateTime);
			DateTime dateTime2 = default(DateTime);
			object obj2 = default(object);
			Array array = default(Array);
			IComparable<string> comparable = default(IComparable<string>);
			ISupportInitializeNotification supportInitializeNotification = default(ISupportInitializeNotification);
			ICloneable cloneable = default(ICloneable);
			int num2 = default(int);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					msgEnd = cmd.Rx.GetMsgEnd(3);
					num = (ShowWwvHelp.Ⴗ(msgEnd as string, 'â', 199) ? 9 : 0);
					continue;
				case 9:
					dateTime = SetAnnWrap.Ⴍ((string)msgEnd, 895, '\u0330');
					dateTime = SetAnnWrap.Ⴃ(ref dateTime, 1.0, 849, 781);
					num = 19;
					continue;
				case 19:
					dateTime2 = SetAnnWrap.Ⴃ(ref dateTime, -7.0, 427, 503);
					dateTime = SetWwvOutput.Ⴗ(ref dateTime, -1.0, '·', 961);
					num = 6;
					continue;
				case 6:
					comparable = ShowSkimCtyHelp.Ⴍ(1216131229, 4, 'S');
					obj2 = comparable as string;
					array = new object[6];
					num = 20;
					continue;
				case 20:
					((object[])array)[0] = obj2;
					(array as object[])[1] = SetStationClubHelp.Ⴍ(2, 4, 1747256300, null);
					num = 11;
					continue;
				case 11:
					((object[])array)[2] = dateTime2;
					goto case 8;
				case 8:
					((object[])array)[3] = ReplyMail.Ⴅ(0, 11, 1217943126);
					num = 21;
					continue;
				case 21:
					(array as object[])[4] = dateTime;
					(array as object[])[5] = CallBlockCacheCfg.Ⴅ(null, 1, 62056072, null);
					num = 2;
					continue;
				case 2:
					comparable = SetDxDefaultHelp.Ⴍ(array as object[], '\a', 110);
					comparable = ShowUsersHelp.Ⴅ((string)comparable, SetTalkCount.Ⴗ(3, null, 1267018622, typeof(WsPcxxCache)), 916, 986);
					num = 5;
					continue;
				case 5:
					comparable = ShowUsersHelp.Ⴅ(comparable as string, ReplyMailHelp.Ⴄ(23, null, 1057163295, 3), 661, 731);
					num = ⴅ[46];
					continue;
				case 17:
				{
					comparable = ShowUsersHelp.Ⴅ(comparable as string, CallBlockCacheCfg.Ⴅ(null, 3, 62056114, null), 585, 519);
					byte num3 = ⴐ[373];
					ShowWwvOptionsHelp.ႣႥ[58] = (char)((ShowWwvOptionsHelp.ႣႥ[58] ^ ShowWwvOptionsHelp.ႣႥ[444]) & 0xD8);
					num = num3 - 50;
					continue;
				}
				case 1:
					supportInitializeNotification = new DataSet();
					cloneable = new SqlCeDataAdapter((string)comparable, cmd.Ⴍ().Ⴅ().Ⴍ()
						.Configuration.DbConnect);
					num = 13;
					continue;
				case 13:
					ShowDxFilter.Ⴄ((DbDataAdapter)(cloneable as SqlCeDataAdapter), (DataSet)supportInitializeNotification, SetStationClubHelp.Ⴍ(4, 6, 1747257816, null), 'Ɵ', 'ǅ');
					num = 14;
					continue;
				case 14:
					num2 = 0;
					num = 18;
					continue;
				case 16:
					ShowDx.GetPlayBackFormat(cmd, ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(supportInitializeNotification as DataSet, 'i', '\u0014'), 0, 'Ʈ', 506), '\u0385', 901)[num2]);
					num = 15;
					continue;
				case 15:
					num2++;
					num = 18;
					continue;
				case 18:
					num = ((num2 < ((DataSet)supportInitializeNotification).Tables[0].Rows.Count) ? (ⴃႰ[162] - 58480) : (ⴍႤ[91] - 37901));
					continue;
				case 7:
				case 10:
					obj = new Publisher();
					break;
				case 12:
					break;
				case 0:
					goto end_IL_001f;
				}
				((Publisher)obj).Process(cmd);
				num = 0;
				continue;
				end_IL_001f:
				break;
			}
		}
		catch (Exception ex)
		{
			cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131258, 1, '×') + ex.Message);
		}
		switch (0)
		{
		}
	}

	public static void ShowDxOpdx4(NodeUserCmd cmd)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		try
		{
			int num = 11;
			IEnumerable msgEnd = default(IEnumerable);
			DateTime dateTime2 = default(DateTime);
			DateTime dateTime = default(DateTime);
			object obj6 = default(object);
			IConvertible convertible = default(IConvertible);
			int num2 = default(int);
			int num3 = default(int);
			IEquatable<string> empty = default(IEquatable<string>);
			object obj4 = default(object);
			int num4 = default(int);
			IEnumerable enumerable = default(IEnumerable);
			object obj3 = default(object);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					msgEnd = cmd.Rx.GetMsgEnd(3);
					num = ((!ShowWwvHelp.Ⴗ(msgEnd as string, 'Ƶ', 400)) ? 1 : (ⴍႤ[440] - 1875));
					continue;
				case 7:
					dateTime2 = SetAnnWrap.Ⴍ((string)msgEnd, 544, 'ɯ');
					dateTime2 = SetAnnWrap.Ⴃ(ref dateTime2, 1.0, 621, 561);
					num = ⴍႭ[184] - 40024;
					continue;
				case 4:
					dateTime = SetAnnWrap.Ⴃ(ref dateTime2, -7.0, 25, 69);
					dateTime2 = SetWwvOutput.Ⴗ(ref dateTime2, -1.0, 'Ɓ', 455);
					goto case 23;
				case 23:
					num = ⴅ[397];
					continue;
				case 14:
					convertible = ReplyMailHelp.Ⴄ(6, null, 1057163309, 1);
					convertible = ShowUsersHelp.Ⴅ(convertible as string, ShowWxHelp.Ⴍ('\u0018', 985806931, 0), 920, 982);
					num = 28;
					continue;
				case 28:
				{
					object obj5 = (string)convertible;
					obj6 = new string[5];
					(obj6 as string[])[0] = (string)obj5;
					num = ⴀႣ[254] - 29325;
					continue;
				}
				case 16:
					(obj6 as string[])[1] = SetTalkCount.Ⴗ(0, null, 1267018590, typeof(ႳႠ));
					num = ⴄႤ[50] - 12;
					continue;
				case 12:
					((string[])obj6)[2] = ShowAnnOptionsHelp.Ⴗ(ref dateTime, ShowSkimCtyHelp.Ⴍ(1216131327, 2, 'Ë'), 227, 231);
					num = 2;
					continue;
				case 2:
					(obj6 as string[])[3] = ႰႥ.Ⴅ(1, 'i', 952620211);
					(obj6 as string[])[4] = ShowAnnOptionsHelp.Ⴗ(ref dateTime2, SetStationClubHelp.Ⴍ(7, 4, 1747256103, null), 262, 258);
					num = 15;
					continue;
				case 15:
					convertible = ShowWwv.Ⴈ((string[])obj6, 'ɯ', 519);
					convertible = ShowUsersHelp.Ⴅ(convertible as string, SetStationClubHelp.Ⴍ(15, 8, 1747256155, null), 518, 584);
					num = ⴃႰ[80] - 24200;
					continue;
				case 3:
					convertible = ShowUsersHelp.Ⴅ((string)convertible, ႨႨ.Ⴀ(6, 6, 1157905681), 842, 772);
					num = 18;
					continue;
				case 18:
					convertible = ShowUsersHelp.Ⴅ(convertible as string, SetTalkCount.Ⴗ(3, null, 1267018557, typeof(LogCacheCfg)), 706, 652);
					num = 25;
					continue;
				case 25:
					cmd.Ⴍ().ႠႰ(convertible as string);
					num2 = 0;
					num3 = 0;
					empty = string.Empty;
					num = ⴃႥ[126] - 63602;
					continue;
				case 6:
				{
					string obj7 = (string)empty;
					object obj8 = new char[1];
					((char[])obj8)[0] = ',';
					obj4 = Directory.Ⴓ(obj7, obj8 as char[], 745, 703);
					num = 19;
					continue;
				}
				case 10:
				case 19:
					num4 = 0;
					num = 8;
					continue;
				case 17:
					enumerable = ((string[])obj4)[num4];
					num = ((CallBlockCacheCfg.Ⴜ((string)enumerable, 749, 652) <= 0) ? 24 : (ⴀ[518] - 38760));
					continue;
				case 5:
					convertible = Ⴈ((string)enumerable, dateTime, dateTime2, ref num2, ref num3);
					cmd.Ⴍ().ႠႰ(convertible as string);
					goto case 24;
				case 24:
					num4++;
					num = 8;
					continue;
				case 8:
					num = ((num4 < (obj4 as string[]).Length) ? (ⴍႤ[223] - 31733) : (ⴅ[254] - 34));
					continue;
				case 20:
					convertible = ႰႥ.Ⴅ(2, '¾', 952622441);
					obj3 = convertible as string;
					obj2 = new object[5];
					num = 22;
					continue;
				case 22:
					(obj2 as object[])[0] = obj3;
					((object[])obj2)[1] = ShowWxHelp.Ⴍ('\u0004', 985806756, 0);
					num = 0;
					continue;
				case 0:
					((object[])obj2)[2] = num3;
					(obj2 as object[])[3] = ShowWxHelp.Ⴍ('\u0011', 985806746, 1);
					num = ⴄႤ[65] - 39;
					continue;
				case 9:
					((object[])obj2)[4] = num2.ToString();
					goto case 26;
				case 26:
					convertible = SetDxDefaultHelp.Ⴍ(obj2 as object[], '\u036f', 774);
					num = 27;
					continue;
				case 27:
					convertible = (string)convertible + ReplyMail.Ⴅ(4, 7, 1217943106) + Ⴓ(dateTime, dateTime2) + ReplyMailHelp.Ⴄ(28, null, 1057162481, 0);
					num = 13;
					continue;
				case 13:
				{
					cmd.Tx.Msg.Add(convertible as string);
					object obj = new Publisher();
					(obj as Publisher).Process(cmd);
					num = ⴃႠ[389] - 46744;
					continue;
				}
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(2, 4, 1747255443, null) + (ex as Exception).Message);
		}
		switch (2)
		{
		}
	}

	private static string Ⴈ(string P_0, DateTime P_1, DateTime P_2, ref int P_3, ref int P_4)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		object obj = default(object);
		while (true)
		{
			int num = Ⴃ(P_0, P_1, P_2);
			P_4 += num;
			while (true)
			{
				IL_004d:
				int num2 = 4;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = 6;
						continue;
					case 6:
						break;
					case 5:
						goto IL_004d;
					case 4:
						obj = P_0;
						obj = ShowAnnHelp.Ⴀ((string)obj, 6, 737, 695);
						num2 = ⴄႷ[113] - 58463;
						continue;
					case 8:
						obj = AnnHelp.Ⴈ((string)obj, ႰႥ.Ⴜ(num.ToString(), 6, 'ƞ', 426), CallBlockCacheCfg.Ⴅ(null, 1, 62058418, null), 53, '\u0002');
						num2 = 0;
						continue;
					case 0:
						obj = ShowUsersHelp.Ⴅ((string)obj, Ⴃ(P_0, P_1, P_2, ref P_3), 453, 395);
						num2 = 3;
						continue;
					case 3:
						return (string)obj + ReplyMailHelp.Ⴄ(13, null, 1057162485, 4);
					}
					break;
				}
				break;
			}
		}
	}

	private static int Ⴃ(string P_0, DateTime P_1, DateTime P_2)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num2 = default(int);
		while (true)
		{
			object obj = new object[7];
			((object[])obj)[0] = ShowSkimCtyHelp.Ⴍ(1216131931, 6, 'Î');
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႠ[324] - 29387;
					continue;
				case 7:
					break;
				case 5:
					(obj as object[])[1] = P_0;
					(obj as object[])[2] = ႰႥ.Ⴅ(7, 'ö', 952622393);
					num = ⴄႷ[22] - 7324;
					continue;
				case 8:
					((object[])obj)[3] = P_1;
					goto case 4;
				case 4:
					((object[])obj)[4] = ReplyMail.Ⴅ(2, 10, 1217943124);
					goto case 0;
				case 0:
					num = ⴀႳ[301] - 36929;
					continue;
				case 1:
					(obj as object[])[5] = P_2;
					(obj as object[])[6] = SetStationQth.Ⴍ(null, 1687353796, 4, 0);
					num = 2;
					continue;
				case 2:
					SetDxDefaultHelp.Ⴍ((object[])obj, 'ȑ', 632);
					goto case 9;
				case 9:
				{
					ISupportInitialize supportInitialize = null;
					num2 = Convert.ToInt32(ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitialize, 'Ĭ', 'ő'), 0, 'ƙ', 461), 'C', 67)[0][0].ToString());
					num = 6;
					continue;
				}
				case 6:
				{
					int result = num2;
					SetWxOutput.ႣႰ[43] = (char)(SetWxOutput.ႣႰ[43] & SetWxOutput.ႣႰ[31] & 0x80);
					return result;
				}
				}
				break;
			}
		}
	}

	private static string Ⴃ(string P_0, DateTime P_1, DateTime P_2, ref int P_3)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		bool flag6 = default(bool);
		bool flag7 = default(bool);
		bool flag8 = default(bool);
		bool flag9 = default(bool);
		bool flag10 = default(bool);
		bool flag18 = default(bool);
		bool flag19 = default(bool);
		bool flag20 = default(bool);
		bool flag17 = default(bool);
		bool flag16 = default(bool);
		bool flag14 = default(bool);
		bool flag13 = default(bool);
		bool flag15 = default(bool);
		bool flag12 = default(bool);
		bool flag11 = default(bool);
		bool flag5 = default(bool);
		Array array = default(Array);
		object obj3 = default(object);
		int num3 = default(int);
		IEnumerable enumerable = default(IEnumerable);
		IConvertible convertible = default(IConvertible);
		object obj2 = default(object);
		object obj = default(object);
		int value2 = default(int);
		DateTime dateTime = default(DateTime);
		IEnumerable<char> enumerable2 = default(IEnumerable<char>);
		IComparable<string> comparable = default(IComparable<string>);
		int value = default(int);
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			int num2 = 55;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႭ[8] - 21421;
					continue;
				case 36:
					break;
				case 55:
					flag6 = false;
					flag7 = false;
					flag8 = false;
					flag9 = false;
					flag10 = false;
					num2 = 38;
					continue;
				case 38:
					flag18 = false;
					flag19 = false;
					flag20 = false;
					flag17 = false;
					flag16 = false;
					num2 = ⴄႭ[56];
					continue;
				case 27:
					flag14 = false;
					flag13 = false;
					flag15 = false;
					flag12 = false;
					flag11 = false;
					num2 = ⴄႭ[7] * 2;
					continue;
				case 94:
					flag5 = false;
					goto case 118;
				case 118:
					array = new object[7];
					(array as object[])[0] = ႰႥ.Ⴅ(6, '÷', 952622792);
					num2 = 66;
					continue;
				case 66:
					((object[])array)[1] = P_0;
					((object[])array)[2] = ႰႥ.Ⴅ(6, '6', 952622392);
					num2 = 26;
					continue;
				case 26:
					((object[])array)[3] = P_1;
					(array as object[])[4] = ReplyMail.Ⴅ(5, 6, 1217943123);
					num2 = 43;
					continue;
				case 43:
					(array as object[])[5] = P_2;
					((object[])array)[6] = ႰႥ.Ⴅ(1, '¡', 952620227);
					num2 = ⴀ[193] - 90;
					continue;
				case 65:
					SetDxDefaultHelp.Ⴍ((object[])array, '\u00af', 198);
					obj3 = null;
					num3 = 0;
					num2 = ⴄႷ[4] - 30650;
					continue;
				case 3:
					enumerable = UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(qslinfoRequestBody.Ⴍ(ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(obj3 as DataSet, 'Ƌ', 'Ƕ'), 0, '\u0352', 774), 'Ƶ', 437), num3, 'ι', 926), SetStationClubHelp.Ⴍ(15, 2, 1747257418, null), 37, 'k'), 'Ϫ', 897);
					num2 = ⴄႭ[118];
					continue;
				case 50:
					num2 = (((convertible = enumerable as string) == null) ? 16 : (ⴀ[116] - 54168));
					continue;
				case 14:
					num2 = (ByeHelp.Ⴍ((string)convertible, SetStationQth.Ⴍ(null, 1687352334, 5, 30), 35, 68) ? 25 : (ⴄႷ[103] - 22397));
					continue;
				case 23:
					num2 = (ByeHelp.Ⴍ(convertible as string, ReplyMail.Ⴅ(4, 12, 1217943148), 957, 986) ? (ⴅ[389] + ⴅ[99]) : 114);
					continue;
				case 114:
					num2 = (ByeHelp.Ⴍ((string)convertible, ShowWxHelp.Ⴍ('\u000e', 985806735, 1), 378, 285) ? 56 : (ⴀႣ[209] - 53519));
					continue;
				case 84:
					num2 = 16;
					continue;
				case 25:
					flag = true;
					num2 = 16;
					continue;
				case 116:
					flag2 = true;
					num2 = 16;
					continue;
				case 56:
					flag3 = true;
					num2 = ⴀ[435] - 13744;
					continue;
				case 16:
					obj2 = UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(qslinfoRequestBody.Ⴍ(ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)obj3, 'Æ', '»'), 0, 'ȃ', 599), 'Ź', 377), num3, 'σ', 996), SetTalkCount.Ⴗ(8, null, 1267023357, typeof(SetStationClubHelp)), 891, '\u0335'), '\u009d', 246);
					num2 = ⴄႤ[289] - 154;
					continue;
				case 92:
					num2 = (((obj = (string)obj2) == null) ? 69 : (ⴐ[158] - ⴐ[11]));
					continue;
				case 17:
				case 89:
					num2 = ((ႳႠ.Ⴍ != null) ? (ⴀႣ[373] - 13214) : 70);
					continue;
				case 70:
					ႳႠ.Ⴍ = new Dictionary<string, int>(10)
					{
						{
							ႨႨ.Ⴀ(13, 5, 1157905601),
							0
						},
						{
							SetTalkCount.Ⴗ(3, null, 1267021679, typeof(ႷႰ.ႥႳ)),
							1
						},
						{
							ReplyMailHelp.Ⴄ(8, null, 1057164042, 8),
							2
						},
						{
							CallBlockCacheCfg.Ⴅ(null, 8, 62055689, null),
							3
						},
						{
							SetStationClubHelp.Ⴍ(4, 0, 1747258517, null),
							4
						},
						{
							ႨႨ.Ⴀ(14, 1, 1157905615),
							5
						},
						{
							SetTalkCount.Ⴗ(4, null, 1267021669, typeof(ConnectsCache)),
							6
						},
						{
							ReplyMailHelp.Ⴄ(26, null, 1057164054, 4),
							7
						},
						{
							CallBlockCacheCfg.Ⴅ(null, 6, 62055688, null),
							8
						},
						{
							SetStationClubHelp.Ⴍ(0, 3, 1747258509, null),
							9
						}
					};
					num2 = ⴀႨ[39] - 33434;
					continue;
				case 45:
					num2 = ((!ႳႠ.Ⴍ.TryGetValue((string)obj, out value2)) ? 69 : 35);
					continue;
				case 35:
					num2 = value2 switch
					{
						0 => 21, 
						1 => ⴍႭ[52] - 69, 
						2 => 1, 
						3 => ⴍႤ[21] - 4978, 
						4 => ⴃႰ[4] - 5231, 
						5 => ⴅ[162], 
						6 => 98, 
						7 => ⴍႤ[355] - 45156, 
						8 => ⴀႣ[410] - 37925, 
						9 => ⴃႥ[414] - 40647, 
						_ => 115, 
					};
					continue;
				case 115:
					num2 = 69;
					continue;
				case 21:
					flag4 = true;
					num2 = ⴃႠ[160] - 12910;
					continue;
				case 6:
					flag6 = true;
					num2 = ⴄႤ[379] - ⴄႤ[407];
					continue;
				case 1:
					flag7 = true;
					num2 = ⴀႼ[2] + 51;
					continue;
				case 39:
					flag8 = true;
					num2 = ⴀႼ[108] - 87;
					continue;
				case 80:
					flag9 = true;
					num2 = 69;
					continue;
				case 86:
					flag10 = true;
					num2 = 69;
					continue;
				case 98:
					flag18 = true;
					num2 = ⴀႼ[101] + 28;
					continue;
				case 15:
					flag19 = true;
					num2 = ⴀႨ[171] - 5106;
					continue;
				case 68:
					flag20 = true;
					num2 = ⴐ[124];
					continue;
				case 75:
					flag17 = true;
					num2 = 69;
					continue;
				case 69:
					dateTime = SetAnnWrap.Ⴍ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(qslinfoRequestBody.Ⴍ(ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(obj3 as DataSet, 'Ɓ', 'Ǽ'), 0, 'Ù', 141), 'γ', 947), num3, '\u0349', 878), ႰႥ.Ⴅ(4, 'Ú', 952620233), 190, 'ð'), '\u02c3', 680), 442, 'ǵ');
					num2 = 64;
					continue;
				case 64:
					enumerable2 = ShowAnnOptionsHelp.Ⴗ(ref dateTime, SetStationClubHelp.Ⴍ(1, 7, 1747255474, null), 534, 530);
					num2 = 67;
					continue;
				case 67:
					num2 = (((comparable = enumerable2 as string) == null) ? ⴅ[69] : 41);
					continue;
				case 41:
					num2 = ((ႳႠ.Ⴓ != null) ? (ⴀႣ[182] - 39476) : 20);
					continue;
				case 20:
					ႳႠ.Ⴓ = new Dictionary<string, int>(7)
					{
						{
							ReplyMail.Ⴅ(8, 3, 1217945216),
							0
						},
						{
							SetStationClubHelp.Ⴍ(2, 1, 1747255469, null),
							1
						},
						{
							ႨႨ.Ⴀ(8, 5, 1157906157),
							2
						},
						{
							SetTalkCount.Ⴗ(8, null, 1267018729, typeof(Help)),
							3
						},
						{
							ReplyMailHelp.Ⴄ(24, null, 1057165274, 5),
							4
						},
						{
							CallBlockCacheCfg.Ⴅ(null, 8, 62056271, null),
							5
						},
						{
							SetStationClubHelp.Ⴍ(1, 5, 1747255519, null),
							6
						}
					};
					num2 = ⴄႭ[137] - 210;
					continue;
				case 29:
					num2 = ((!ႳႠ.Ⴓ.TryGetValue((string)comparable, out value)) ? 107 : (ⴐ[48] / 2));
					continue;
				case 79:
					num2 = value switch
					{
						0 => 99, 
						1 => ⴃႰ[162] - 58385, 
						2 => 37, 
						3 => 33, 
						4 => 34, 
						5 => ⴀႣ[350] - 49077, 
						6 => 101, 
						_ => ⴅ[6], 
					};
					continue;
				case 0:
					num2 = 107;
					continue;
				case 99:
					flag16 = true;
					num2 = 107;
					continue;
				case 111:
					flag14 = true;
					num2 = ⴀႨ[79] - 6609;
					continue;
				case 37:
					flag13 = true;
					num2 = 107;
					continue;
				case 33:
					flag15 = true;
					num2 = 107;
					continue;
				case 34:
					flag12 = true;
					num2 = 107;
					continue;
				case 53:
					flag11 = true;
					num2 = 107;
					continue;
				case 101:
					flag5 = true;
					num2 = 107;
					continue;
				case 107:
					num++;
					num3++;
					num2 = 2;
					continue;
				case 2:
					num2 = ((num3 < DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(obj3 as DataSet, 'ˆ', 'ʻ'), 0, '\u0328', 892), 'ï', 239), (short)679, (short)762)) ? 3 : 40);
					continue;
				case 40:
					cloneable = num.ToString();
					cloneable = ShowUsersHelp.Ⴅ(ႰႥ.Ⴜ((string)cloneable, 5, 'ſ', 331), ႨႨ.Ⴀ(9, 5, 1157902547), 466, 412);
					num2 = 85;
					continue;
				case 85:
					num2 = ((!flag4) ? 82 : (ⴄႷ[29] - 57684));
					continue;
				case 88:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, SetStationQth.Ⴍ(null, 1687353847, 3, 31), 623, 545);
					num2 = 110;
					continue;
				case 82:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, ႰႥ.Ⴅ(3, '8', 952622828), 981, 923);
					num2 = ⴀႣ[209] - 53493;
					continue;
				case 110:
					num2 = ((!flag6) ? (ⴃႥ[405] - 45626) : (ⴃႰ[32] - 1118));
					continue;
				case 4:
					cloneable = ShowUsersHelp.Ⴅ((string)cloneable, ShowSkimCtyHelp.Ⴍ(1216131881, 5, '#'), 161, 239);
					num2 = ⴀႼ[74] - 111;
					continue;
				case 77:
					cloneable = ShowUsersHelp.Ⴅ((string)cloneable, SetStationQth.Ⴍ(null, 1687353837, 0, 22), 451, 397);
					num2 = 103;
					continue;
				case 103:
					num2 = ((!flag7) ? (ⴃႠ[324] - 29375) : (ⴃႰ[127] - 32118));
					continue;
				case 52:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, ReplyMail.Ⴅ(7, 12, 1217943137), 643, 717);
					num2 = ⴀႼ[6] + ⴀႼ[96];
					continue;
				case 19:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, SetStationQth.Ⴍ(null, 1687353837, 0, 3), 310, 376);
					num2 = 76;
					continue;
				case 76:
					num2 = ((!flag8) ? (ⴀႣ[248] - 37911) : (ⴄႷ[87] - 25110));
					continue;
				case 63:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, ShowWxHelp.Ⴍ('p', 985806833, 6), 994, 940);
					num2 = 46;
					continue;
				case 11:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, SetStationQth.Ⴍ(null, 1687353836, 1, 18), 312, 374);
					num2 = ⴃႠ[207] - 65439;
					continue;
				case 46:
					num2 = ((!flag9) ? 47 : 28);
					continue;
				case 28:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, ႰႥ.Ⴅ(1, 'Ô', 952622839), 845, 771);
					num2 = 108;
					continue;
				case 47:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, SetStationQth.Ⴍ(null, 1687353833, 4, 30), 630, 568);
					num2 = ⴃႠ[82] - 35395;
					continue;
				case 108:
					num2 = ((!flag10) ? 9 : (ⴍႭ[236] - 49138));
					continue;
				case 104:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, SetStationQth.Ⴍ(null, 1687353830, 1, 3), 790, 856);
					num2 = 74;
					continue;
				case 9:
					cloneable = ShowUsersHelp.Ⴅ((string)cloneable, SetStationQth.Ⴍ(null, 1687353834, 7, 21), 144, 222);
					num2 = ⴐ[87] - 35;
					continue;
				case 74:
					num2 = ((!flag18) ? 44 : (ⴀႳ[79] - 30098));
					continue;
				case 87:
					cloneable = ShowUsersHelp.Ⴅ((string)cloneable, ShowSkimCtyHelp.Ⴍ(1216131894, 4, '\u0016'), 459, 389);
					num2 = 61;
					continue;
				case 44:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, SetStationQth.Ⴍ(null, 1687353838, 3, 17), 802, 876);
					num2 = 61;
					continue;
				case 61:
					num2 = ((!flag19) ? (ⴐ[301] - 78) : 24);
					continue;
				case 24:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, ReplyMail.Ⴅ(1, 7, 1217943069), 173, 227);
					num2 = ⴅ[406] - 228;
					continue;
				case 71:
					cloneable = ShowUsersHelp.Ⴅ((string)cloneable, SetStationQth.Ⴍ(null, 1687353832, 5, 14), 114, 60);
					num2 = 5;
					continue;
				case 5:
					num2 = ((!flag20) ? 62 : 112);
					continue;
				case 112:
					cloneable = ShowUsersHelp.Ⴅ((string)cloneable, ShowWxHelp.Ⴍ('\u001c', 985806840, 1), 298, 356);
					num2 = 48;
					continue;
				case 62:
					cloneable = ShowUsersHelp.Ⴅ((string)cloneable, SetStationQth.Ⴍ(null, 1687353829, 8, 2), 382, 304);
					num2 = 48;
					continue;
				case 48:
					num2 = ((!flag17) ? ⴅ[17] : 7);
					continue;
				case 7:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, SetStationClubHelp.Ⴍ(10, 0, 1747258510, null), 617, 551);
					goto case 106;
				case 106:
					num2 = ⴄႭ[358] - 126;
					continue;
				case 30:
					cloneable = ShowUsersHelp.Ⴅ((string)cloneable, SetTalkCount.Ⴗ(1, null, 1267022530, typeof(ConnectBlockCacheCfg)), 868, 810);
					num2 = 102;
					continue;
				case 102:
					cloneable = ShowUsersHelp.Ⴅ((string)cloneable, CallBlockCacheCfg.Ⴅ(null, 8, 62058427, null), 68, 10);
					num2 = 51;
					continue;
				case 51:
					num2 = ((!flag16) ? (ⴅ[412] - ⴅ[17]) : 72);
					continue;
				case 72:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, ShowSkimCtyHelp.Ⴍ(1216131900, 4, 'J'), 491, 421);
					num2 = 78;
					continue;
				case 93:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, SetStationQth.Ⴍ(null, 1687353826, 3, 18), 376, 310);
					num2 = ⴃႥ[55] - 14391;
					continue;
				case 78:
					num2 = ((!flag14) ? (ⴀ[74] - 12691) : (ⴀႣ[94] - 31810));
					continue;
				case 58:
					cloneable = ShowUsersHelp.Ⴅ(cloneable as string, ReplyMail.Ⴅ(3, 3, 1217943065), 644, 714);
					num2 = ⴄႷ[12] - 43719;
					continue;
				case 22:
					cloneable = ShowUsersHelp.Ⴅ((string)cloneable, SetStationQth.Ⴍ(null, 1687353829, 4, 14), 850, 796);
					num2 = ⴃႥ[125] - 33309;
					continue;
				case 54:
					num2 = ((!flag13) ? 32 : 73);
					continue;
				case 73:
					cloneable = ShowUsersHelp.Ⴅ((string)cloneable, ShowWxHelp.Ⴍ('Û', 985806818, 1), 515, 589);
					num2 = 120;
					continue;
				case 32:
					cloneable = ShowUsersHelp.Ⴅ((string)cloneable, SetStationQth.Ⴍ(null, 1687353830, 7, 19), 977, 927);
					num2 = 120;
					continue;
				case 120:
					num2 = ((!flag15) ? 49 : 8);
					continue;
				case 8:
					cloneable = (string)cloneable + ReplyMail.Ⴅ(6, 6, 1217943068);
					num2 = 60;
					continue;
				case 49:
					cloneable = (string)cloneable + SetStationQth.Ⴍ(null, 1687353827, 2, 4);
					num2 = ⴄႷ[44] - 49608;
					continue;
				case 60:
					num2 = ((!flag12) ? 117 : 90);
					continue;
				case 90:
					cloneable = (string)cloneable + SetStationQth.Ⴍ(null, 1687353754, 6, 24);
					num2 = ⴍႭ[226] - 11080;
					continue;
				case 117:
					cloneable = (string)cloneable + SetStationQth.Ⴍ(null, 1687353829, 4, 23);
					num2 = 10;
					continue;
				case 10:
					num2 = ((!flag11) ? 31 : (ⴄႷ[58] - 48324));
					continue;
				case 105:
					cloneable = (string)cloneable + ShowSkimCtyHelp.Ⴍ(1216131971, 4, '\u0090');
					num2 = 119;
					continue;
				case 31:
					cloneable = (cloneable as string) + SetStationQth.Ⴍ(null, 1687353826, 3, 7);
					num2 = 119;
					continue;
				case 119:
					num2 = ((!flag5) ? (ⴃႠ[328] - 63872) : (ⴄႭ[435] - 216));
					continue;
				case 18:
					cloneable = (cloneable as string) + ReplyMail.Ⴅ(5, 14, 1217943090);
					num2 = ⴀ[477] - 2469;
					continue;
				case 59:
					cloneable = (cloneable as string) + SetTalkCount.Ⴗ(5, null, 1267022534, typeof(MailCacheCfg));
					num2 = 81;
					continue;
				case 81:
					cloneable = (string)cloneable + CallBlockCacheCfg.Ⴅ(null, 0, 62058419, null);
					num2 = ⴃႥ[41] - 51062;
					continue;
				case 95:
					num2 = ((!flag) ? 91 : 12);
					continue;
				case 12:
					cloneable = (cloneable as string) + ReplyMailHelp.Ⴄ(15, null, 1057165194, 4);
					num2 = 83;
					continue;
				case 91:
					cloneable = (cloneable as string) + SetStationQth.Ⴍ(null, 1687353832, 5, 18);
					num2 = ⴐ[238] - 110;
					continue;
				case 83:
					num2 = ((!flag2) ? (ⴀႳ[22] - 54441) : 42);
					continue;
				case 42:
					cloneable = (cloneable as string) + ReplyMail.Ⴅ(0, 10, 1217943075);
					num2 = 97;
					continue;
				case 13:
					cloneable = (string)cloneable + ႰႥ.Ⴅ(7, 'u', 952622824);
					num2 = 97;
					continue;
				case 97:
					num2 = ((!flag3) ? 113 : 57);
					continue;
				case 57:
					cloneable = (cloneable as string) + ShowWxHelp.Ⴍ('\u0005', 985806734, 0);
					num2 = 109;
					continue;
				case 113:
					cloneable = (string)cloneable + SetTalkCount.Ⴗ(7, null, 1267022532, typeof(ShowPrefixCallsHelp));
					num2 = 109;
					continue;
				case 109:
					cloneable = ((string)cloneable).Replace(ႨႨ.Ⴀ(15, 0, 1157906103), ႨႨ.Ⴀ(12, 5, 1157902547));
					num2 = ⴄႷ[113] - 58375;
					continue;
				case 96:
					P_3 += num;
					return cloneable as string;
				}
				break;
			}
		}
	}

	private static string Ⴓ(DateTime P_0, DateTime P_1)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		ISupportInitializeNotification supportInitializeNotification = default(ISupportInitializeNotification);
		ICloneable cloneable = default(ICloneable);
		IConvertible convertible = default(IConvertible);
		int num4 = default(int);
		int num2 = default(int);
		int num3 = default(int);
		IComparable<string> comparable = default(IComparable<string>);
		object obj2 = default(object);
		while (true)
		{
			object obj = new object[5];
			(obj as object[])[0] = ReplyMail.Ⴅ(7, 8, 1217943545);
			int num = ⴀႨ[193] - 56079;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႣ[318] - 54981;
					continue;
				case 2:
					break;
				case 11:
					(obj as object[])[1] = P_0;
					((object[])obj)[2] = ReplyMail.Ⴅ(6, 9, 1217943120);
					num = 4;
					continue;
				case 4:
					((object[])obj)[3] = P_1;
					(obj as object[])[4] = ႰႥ.Ⴅ(8, 'N', 952622779);
					num = 7;
					continue;
				case 7:
					SetDxDefaultHelp.Ⴍ((object[])obj, '\u009d', 244);
					supportInitializeNotification = null;
					cloneable = string.Empty;
					num = 12;
					continue;
				case 12:
					convertible = string.Empty;
					num4 = 0;
					num2 = 0;
					num3 = 0;
					num = ⴐ[80];
					continue;
				case 8:
					comparable = UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(qslinfoRequestBody.Ⴍ(ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitializeNotification, 'ˮ', 'ʓ'), 0, 'h', 60), 'ͻ', 891), num3, 'ł', 357), ReplyMailHelp.Ⴄ(21, null, 1057162069, 7), 651, '\u02c5'), 'ȇ', 620);
					num = ⴃႠ[48] - 38913;
					continue;
				case 5:
					num = ((!ByeHelp.Ⴍ((string)comparable, (string)convertible, 709, 685)) ? 19 : 9);
					continue;
				case 9:
					num = ((num4 > num2) ? (ⴀႨ[72] - 30937) : 0);
					continue;
				case 13:
					num2 = num4;
					cloneable = (string)convertible;
					num = 0;
					continue;
				case 0:
					convertible = comparable as string;
					num4 = 1;
					num = 18;
					continue;
				case 19:
					num4++;
					num = ⴅ[147];
					continue;
				case 16:
				case 18:
					num3++;
					num = ⴐ[80];
					continue;
				case 14:
					num = ((num3 < ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitializeNotification, 'ð', '\u008d'), 0, 'Ǣ', 438), 'ε', 949).Count) ? (ⴀႨ[118] - 41565) : (ⴄႤ[51] - 12));
					continue;
				case 15:
					obj2 = new object[4];
					((object[])obj2)[0] = (string)cloneable;
					goto case 3;
				case 3:
					(obj2 as object[])[1] = ShowSkimCtyHelp.Ⴍ(1216132003, 1, 's');
					num = 17;
					continue;
				case 17:
					(obj2 as object[])[2] = num2;
					((object[])obj2)[3] = ShowSkimCtyHelp.Ⴍ(1216132015, 8, 'ß');
					num = ⴃႥ[366] - 28054;
					continue;
				case 6:
				case 10:
					return string.Concat((object[])obj2);
				}
				break;
			}
		}
	}

	public static void ShowDxOpdx5(NodeUserCmd cmd)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		try
		{
			int num = 27;
			IEquatable<string> msgEnd = default(IEquatable<string>);
			DateTime dateTime2 = default(DateTime);
			DateTime dateTime = default(DateTime);
			object obj3 = default(object);
			object obj2 = default(object);
			object obj4 = default(object);
			MarshalByValueComponent marshalByValueComponent = default(MarshalByValueComponent);
			int num2 = default(int);
			int num4 = default(int);
			IEquatable<string> equatable = default(IEquatable<string>);
			int num3 = default(int);
			IEnumerable enumerable2 = default(IEnumerable);
			Array array = default(Array);
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
					msgEnd = cmd.Rx.GetMsgEnd(3);
					goto case 31;
				case 31:
					num = ((!ShowWwvHelp.Ⴗ(msgEnd as string, 'Ě', 319)) ? (ⴃႥ[231] - 57232) : 21);
					continue;
				case 21:
					dateTime2 = SetAnnWrap.Ⴍ(msgEnd as string, 510, 'Ʊ');
					goto case 7;
				case 7:
					dateTime2 = SetAnnWrap.Ⴃ(ref dateTime2, 1.0, 230, 186);
					num = ⴄႷ[118] - 56535;
					continue;
				case 28:
					dateTime = SetAnnWrap.Ⴃ(ref dateTime2, -7.0, 20, 72);
					dateTime2 = SetWwvOutput.Ⴗ(ref dateTime2, -1.0, 'Ŀ', 377);
					num = 6;
					continue;
				case 6:
					obj4 = SetTalkCount.Ⴗ(1, null, 1267018451, typeof(global::_003CModule_003E));
					obj3 = (string)obj4;
					num = ⴀႼ[8] - 182;
					continue;
				case 19:
					obj2 = new object[6];
					(obj2 as object[])[0] = obj3;
					(obj2 as object[])[1] = SetStationClubHelp.Ⴍ(9, 4, 1747256300, null);
					num = 25;
					continue;
				case 25:
					(obj2 as object[])[2] = dateTime;
					((object[])obj2)[3] = ReplyMail.Ⴅ(8, 6, 1217943134);
					num = ⴃႥ[231] - 57224;
					continue;
				case 20:
					(obj2 as object[])[4] = dateTime2;
					((object[])obj2)[5] = CallBlockCacheCfg.Ⴅ(null, 5, 62056076, null);
					num = 17;
					continue;
				case 17:
					obj4 = SetDxDefaultHelp.Ⴍ(obj2 as object[], 'Ŕ', 317);
					obj4 = ShowUsersHelp.Ⴅ((string)obj4, ShowWxHelp.Ⴍ('&', 985806862, 3), 50, 124);
					num = 16;
					continue;
				case 16:
					obj4 = ShowUsersHelp.Ⴅ(obj4 as string, ႨႨ.Ⴀ(9, 0, 1157906105), 96, 46);
					num = 15;
					continue;
				case 15:
					obj4 = ShowUsersHelp.Ⴅ(obj4 as string, ႰႥ.Ⴅ(7, '\u0083', 952622428), 247, 185);
					num = 2;
					continue;
				case 2:
					marshalByValueComponent = null;
					num2 = 0;
					num4 = 1;
					equatable = string.Empty;
					num3 = 0;
					num = ⴃႥ[379] - 3035;
					continue;
				case 11:
					enumerable2 = UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(qslinfoRequestBody.Ⴍ(ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(marshalByValueComponent as DataSet, 'ʘ', '\u02e5'), 0, 'İ', 356), 'ɔ', 596), num3, 'ɒ', 629), ShowSkimCtyHelp.Ⴍ(1216131550, 6, '¦'), 831, 'ͱ'), '>', 85);
					num = ⴐ[293] - 84;
					continue;
				case 13:
					num = ((CallBlockCacheCfg.Ⴜ((string)enumerable2, 538, 635) <= 0) ? (ⴄႷ[39] - 54278) : 22);
					continue;
				case 22:
					equatable = qslinfoResponse.Ⴗ(equatable as string, SetTalkCount.Ⴗ(6, null, 1267022533, typeof(UserLoginRegistrationCfg)), (string)enumerable2, ShowWxHelp.Ⴍ('[', 985808778, 7), 493, 'Ǝ');
					num = ⴄႤ[132] - 115;
					continue;
				case 3:
					num2++;
					num = ((CallBlockCacheCfg.Ⴜ(equatable as string, 132, 229) <= 70 * num4) ? 1 : (ⴃႠ[102] - 14908));
					continue;
				case 23:
					equatable = ShowUsersHelp.Ⴅ((string)equatable, ReplyMailHelp.Ⴄ(25, null, 1057162484, 5), 605, 531);
					num = 8;
					continue;
				case 8:
					num4++;
					num = 1;
					continue;
				case 1:
					num3++;
					num = ⴍႭ[337] - 2348;
					continue;
				case 0:
					num = ((num3 < DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)marshalByValueComponent, 'Ȝ', 'ɡ'), 0, 'Ȥ', 624), '\u0080', 128), (short)357, (short)312)) ? 11 : 14);
					continue;
				case 14:
					equatable = SetTalkOutputHelp.Ⴍ((string)equatable, 0, CallBlockCacheCfg.Ⴜ(equatable as string, 750, 655) - 1, 585, 538);
					num = ⴄႷ[49] - 17942;
					continue;
				case 30:
					enumerable = SetTalkCount.Ⴗ(4, null, 1267018418, typeof(MorseCodeConverter.ႨႳ));
					enumerable = (enumerable as string) + ShowAnnOptionsHelp.Ⴗ(ref dateTime, ShowSkimCtyHelp.Ⴍ(1216131326, 3, 'õ'), 788, 784) + ShowSkimCtyHelp.Ⴍ(1216131203, 8, '!') + dateTime2.ToString(ShowSkimCtyHelp.Ⴍ(1216131324, 1, '\u00a0'));
					num = 29;
					continue;
				case 29:
				{
					object obj = (string)enumerable;
					array = new object[4];
					((object[])array)[0] = obj;
					num = 9;
					continue;
				}
				case 9:
					(array as object[])[1] = SetStationClubHelp.Ⴍ(6, 8, 1747256300, null);
					num = 18;
					continue;
				case 18:
					(array as object[])[2] = num2;
					((object[])array)[3] = SetStationClubHelp.Ⴍ(10, 5, 1747255497, null);
					num = 24;
					continue;
				case 24:
					enumerable = string.Concat(array as object[]);
					enumerable = (enumerable as string) + ႰႥ.Ⴅ(8, 'S', 952622668);
					num = ⴅ[51] - 162;
					continue;
				case 26:
					enumerable = (string)enumerable + SetStationQth.Ⴍ(null, 1687353738, 0, 16);
					goto case 4;
				case 4:
					num = 5;
					continue;
				case 5:
					cmd.Tx.Msg.Add((string)enumerable + (string)equatable);
					break;
				case 12:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			cmd.Tx.Msg.Add(ShowWxHelp.Ⴍ('\u0002', 985806788, 2) + (ex as Exception).Message);
		}
		switch (2)
		{
		}
	}

	public static void ShowDxOpdx6(NodeUserCmd cmd)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			int num = 13;
			object msgEnd = default(object);
			DateTime dateTime = default(DateTime);
			DateTime dateTime2 = default(DateTime);
			object obj = default(object);
			Array array = default(Array);
			ISupportInitialize supportInitialize = default(ISupportInitialize);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					msgEnd = cmd.Rx.GetMsgEnd(3);
					num = ((!ShowWwvHelp.Ⴗ((string)msgEnd, '\u02df', 762)) ? 3 : 12);
					continue;
				case 12:
					dateTime = SetAnnWrap.Ⴍ((string)msgEnd, 467, 'Ɯ');
					dateTime = SetAnnWrap.Ⴃ(ref dateTime, 1.0, 406, 458);
					num = 8;
					continue;
				case 8:
					dateTime2 = SetAnnWrap.Ⴃ(ref dateTime, -7.0, 920, 964);
					dateTime = SetWwvOutput.Ⴗ(ref dateTime, -1.0, 't', 50);
					num = 1;
					continue;
				case 1:
				{
					IConvertible convertible = ReplyMail.Ⴅ(6, 5, 1217943279);
					obj = (string)convertible;
					array = new object[6];
					num = ⴀႼ[127] - 29;
					continue;
				}
				case 10:
					((object[])array)[0] = obj;
					(array as object[])[1] = SetStationClubHelp.Ⴍ(10, 2, 1747256298, null);
					num = 16;
					continue;
				case 16:
					(array as object[])[2] = dateTime2;
					(array as object[])[3] = ReplyMail.Ⴅ(7, 14, 1217943121);
					goto case 0;
				case 0:
					num = ⴀႣ[326] - 26490;
					continue;
				case 11:
					(array as object[])[4] = dateTime;
					((object[])array)[5] = CallBlockCacheCfg.Ⴅ(null, 7, 62056078, null);
					num = 9;
					continue;
				case 9:
				{
					IConvertible convertible = SetDxDefaultHelp.Ⴍ((object[])array, 'ϕ', 956);
					convertible = ShowUsersHelp.Ⴅ(convertible as string, SetStationQth.Ⴍ(null, 1687353946, 0, 7), 699, 757);
					num = 14;
					continue;
				}
				case 14:
					supportInitialize = null;
					num2 = 0;
					num = 4;
					continue;
				case 7:
				case 15:
					ShowDx.GetPlayBackFormat(cmd, ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitialize, 'Ŵ', 'ĉ'), 0, 'j', 62), 'k', 107)[num2]);
					goto case 5;
				case 5:
					num = 2;
					continue;
				case 2:
					num2++;
					num = ⴀႳ[204] - 27648;
					continue;
				case 4:
					num = ((num2 < (supportInitialize as DataSet).Tables[0].Rows.Count) ? 7 : 3);
					continue;
				case 3:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			cmd.Tx.Msg.Add(ReplyMail.Ⴅ(5, 1, 1217943429) + ex.Message);
		}
		switch (4)
		{
		}
	}
}
