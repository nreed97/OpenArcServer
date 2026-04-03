using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcServerConfig.Io;
using ArcInterfaces.Io;
using ArcShared;
using ArcShared.ArcCfg;

namespace Ⴈ;

internal sealed class ႨႼ
{
	public static void Ⴈ(ArcConnect P_0, NodeUserCmd P_1)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				if (P_1.Tx.DxCmdMsgExt.Skimmer)
				{
					num = 3;
					continue;
				}
				break;
			case 0:
			case 3:
				if (P_0.Io.IoCfg.Category == IoCategoryType.Server)
				{
					num = 1;
					continue;
				}
				break;
			case 1:
				if (ReadMail.Ⴃ((ServerIoCfg)P_0.Io.IoCfg, 491, 420) == ServerIoType.AgwBpqTcp)
				{
					num = 2;
					continue;
				}
				break;
			case 2:
			case 5:
				return;
			}
			break;
		}
		bool flag = default(bool);
		DxModeType dxModeType = default(DxModeType);
		object obj2 = default(object);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			int num2 = ((ႷႷ.Ⴃ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 267, 369), 'ϣ', 902) != OutputType.Off) ? 15 : (ⴄႤ[15] - 28));
			while (true)
			{
				string text;
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					return;
				case 3:
					break;
				case 25:
					return;
				case 15:
					flag = true;
					dxModeType = ShowWwv.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 345, 291), 175, 184);
					num2 = 18;
					continue;
				case 18:
					num2 = dxModeType switch
					{
						DxModeType.Filter => 17, 
						DxModeType.Needs => 24, 
						DxModeType.Debug => ⴄႭ[492] - 19, 
						_ => ⴃႠ[155] - 34028, 
					};
					continue;
				case 16:
					num2 = ⴃႠ[122] - 25026;
					continue;
				case 17:
					num2 = ((CallBlockCacheCfg.Ⴜ(ShowSkimmerHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 441, 451), 689, 675), 967, 934) <= 0) ? (ⴍႤ[185] - 5392) : 5);
					continue;
				case 5:
					obj2 = new object[5];
					(obj2 as object[])[0] = CallBlockCacheCfg.Ⴅ(null, 4, 62057685, null);
					num2 = ⴃႰ[136] - 29118;
					continue;
				case 14:
					((object[])obj2)[1] = P_1.Tx.Id;
					((object[])obj2)[2] = ShowWxHelp.Ⴍ('\u0015', 985805199, 4);
					num2 = ⴄႭ[600] - 148;
					continue;
				case 4:
					(obj2 as object[])[3] = ShowSkimmerHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 202, 176), 884, 870);
					num2 = ⴄႤ[392] - 140;
					continue;
				case 21:
					((object[])obj2)[4] = ReplyMailHelp.Ⴄ(29, null, 1057162114, 8);
					goto case 2;
				case 2:
					num2 = 6;
					continue;
				case 6:
				{
					object obj = SetDxDefaultHelp.Ⴍ(obj2 as object[], ']', 52);
					flag = P_1.Ⴍ().Ⴅ().Ⴀ()
						.Ⴃ()
						.Ⴍ(obj as string);
					num2 = 28;
					continue;
				}
				case 0:
				case 24:
					flag = Ⴃ(P_0, P_1.Tx.DxCmdMsgExt.Mode, AnnHelp.Ⴈ(ShowWxHelp.Ⴍ('@', 985808780, 1), P_1.Tx.DxCmdMsgExt.Cty, ShowWxHelp.Ⴍ('þ', 985808779, 6), 406, 'ơ'));
					num2 = ⴃႥ[374] - 45335;
					continue;
				case 19:
					flag = true;
					num2 = 28;
					continue;
				case 28:
					num2 = ((!ByeHelp.Ⴍ(P_0.Call, P_1.Ⴍ().Call, 724, 691)) ? ⴐ[257] : (ⴀႼ[57] - 164));
					continue;
				case 1:
					flag = true;
					num2 = 7;
					continue;
				case 7:
					num2 = (flag ? 26 : (ⴀႼ[75] - 132));
					continue;
				case 10:
					num2 = ((ShowWwv.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 132, 254), 647, 656) == DxModeType.Debug) ? 26 : (ⴀ[96] - 20534));
					continue;
				case 27:
					return;
				case 26:
					enumerable = string.Empty;
					goto case 9;
				case 9:
					num2 = ((ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 96, 26).Mode != DxModeType.Debug) ? 8 : 11);
					continue;
				case 11:
					num2 = (flag ? 29 : (ⴍႤ[254] - 62923));
					continue;
				case 23:
					text = ReplyMailHelp.Ⴄ(0, null, 1057162113, 7);
					goto IL_04eb;
				case 29:
					text = ShowWxHelp.Ⴍ('.', 985808863, 2);
					goto IL_04eb;
				case 8:
					num2 = P_0.Cfg.Dx.Output switch
					{
						OutputType.On => ⴍႭ[82] - 37544, 
						OutputType.AR17 => 30, 
						OutputType.XML => 20, 
						_ => ⴄႤ[504], 
					};
					continue;
				case 13:
					return;
				case 22:
					P_0.ႠႰ((enumerable as string) + Ⴄ(P_0, P_1));
					return;
				case 30:
					P_0.ႠႰ(P_1.Tx.Arxx);
					return;
				case 20:
					{
						P_0.ႠႰ(P_1.Tx.ClientXml);
						return;
					}
					IL_04eb:
					enumerable = text;
					num2 = ⴀ[286] - 24712;
					continue;
				}
				break;
			}
		}
	}

	private static string Ⴄ(ArcConnect P_0, NodeUserCmd P_1)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		object obj = default(object);
		while (true)
		{
			IEquatable<string> equatable = string.Empty;
			int num = ((!HamQthCfg.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 750, 660), 814, '\u036f'), 'Í', '\u008c')) ? 30 : 35);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 48;
					continue;
				case 48:
					break;
				case 35:
					num = (P_1.Tx.DxCmdMsgExt.Lotw ? 1 : (ⴀ[251] - 7795));
					continue;
				case 1:
					equatable = ShowWxHelp.Ⴍ('ú', 985808858, 7);
					num = ⴍႤ[195] - 62504;
					continue;
				case 30:
					num = ((!SetWxCountHelp.Ⴀ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 619, 529), 520, 'ɉ'), 670, 706)) ? 24 : (ⴄႷ[14] - 21554));
					continue;
				case 40:
					equatable = ShowUsersHelp.Ⴅ(equatable as string, P_1.Tx.DxCmdMsgExt.Cty, 819, 893);
					num = ⴀႳ[206] - 51378;
					continue;
				case 24:
					num = ((!DxCacheCfg.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 582, 572), 314, 'Ż'), 541, 538)) ? 42 : 20);
					continue;
				case 20:
					equatable = Ⴍ((string)equatable);
					equatable = ShowUsersHelp.Ⴅ((string)equatable, P_1.Tx.DxCmdMsgExt.State, 867, 813);
					num = 42;
					continue;
				case 42:
					num = ((!HamQthDotComLookupExt.Ⴀ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 523, 625), 359, 'Ħ'), 891, 867)) ? (ⴃႥ[73] - 11782) : 39);
					continue;
				case 39:
					equatable = Ⴍ((string)equatable);
					num = ((CallBlockCacheCfg.Ⴜ(P_1.Tx.DxCmdMsgExt.State, 239, 142) <= 0) ? 21 : 14);
					continue;
				case 14:
					equatable = ShowUsersHelp.Ⴅ(equatable as string, P_1.Tx.DxCmdMsgExt.State, 450, 396);
					num = 46;
					continue;
				case 21:
					equatable = ShowUsersHelp.Ⴅ(equatable as string, P_1.Tx.DxCmdMsgExt.Cty, 476, 402);
					num = ⴄႷ[52] - 60776;
					continue;
				case 46:
					num = ((!SetStationClub.Ⴄ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 786, 872), 444, 'ǽ'), 676, 737)) ? (ⴄႭ[295] - 176) : 13);
					continue;
				case 11:
				case 13:
					num = ((!ByeHelp.Ⴍ(P_1.Tx.DxCmdMsgExt.Cty, ReplyMailHelp.Ⴄ(29, null, 1057162203, 0), 124, 27)) ? (ⴃႥ[243] - 40666) : 15);
					continue;
				case 15:
					equatable = Ⴍ(equatable as string);
					goto case 37;
				case 37:
					equatable = ShowUsersHelp.Ⴅ(equatable as string, P_1.Tx.DxCmdMsgExt.ArrlSection, 165, 235);
					num = ⴅ[223] - ⴅ[91];
					continue;
				case 5:
					num = ((!HamQthDotComLookupExt.Ⴀ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 965, 959), 257, 'ŀ'), 79, 86)) ? 49 : 23);
					continue;
				case 23:
					num = ((!ByeHelp.Ⴍ(P_1.Tx.DxCmdMsgExt.Cty, ReplyMailHelp.Ⴄ(3, null, 1057162207, 4), 991, 952)) ? 49 : ⴄႤ[12]);
					continue;
				case 26:
					equatable = Ⴍ(equatable as string);
					equatable = ShowUsersHelp.Ⴅ((string)equatable, P_1.Tx.DxCmdMsgExt.County, 620, 546);
					num = 49;
					continue;
				case 49:
					num = ((!HamQthCfg.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 471, 429), 455, 'Ɔ'), 'Õ', '\u0097')) ? (ⴃႰ[204] - 24642) : (ⴃႠ[53] - 46681));
					continue;
				case 51:
					num = ((!ByeHelp.Ⴍ(P_1.Tx.DxCmdMsgExt.Cty, ReplyMailHelp.Ⴄ(24, null, 1057162205, 6), 950, 977)) ? (ⴃႠ[334] - 13067) : (ⴀႨ[205] - 993));
					continue;
				case 29:
					equatable = Ⴍ(equatable as string);
					equatable = ShowUsersHelp.Ⴅ(equatable as string, P_1.Tx.DxCmdMsgExt.Grid, 160, 238);
					num = 17;
					continue;
				case 17:
					num = ((!SetStationClub.Ⴄ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 413, 487), 760, 'ʹ'), 325, 259)) ? 22 : 32);
					continue;
				case 32:
					equatable = Ⴍ((string)equatable);
					equatable = SetWxCountHelp.Ⴗ((object)(equatable as string), (object)P_1.Tx.DxCmdMsgExt.CqZone, 977, (short)938);
					num = ⴀ[234] - 30284;
					continue;
				case 22:
					num = ((!SetStationClub.Ⴄ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 698, 704), 141, 'Ì'), 384, 455)) ? (ⴀႨ[125] - 14025) : 36);
					continue;
				case 36:
					equatable = Ⴍ((string)equatable);
					equatable = SetWxCountHelp.Ⴗ((object)(equatable as string), (object)P_1.Tx.DxCmdMsgExt.ItuZone, 851, (short)808);
					num = ⴄႷ[26] - 9149;
					continue;
				case 19:
					num = ((!SkimDupeDat.Ⴐ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 580, 574), 264, 'ŉ'), 1023, 936)) ? (ⴃႥ[315] - 42357) : 3);
					continue;
				case 3:
					equatable = Ⴍ(equatable as string);
					equatable = ShowUsersHelp.Ⴅ((string)equatable, P_1.Tx.DxCmdMsgExt.Name, 666, 724);
					num = 43;
					continue;
				case 43:
					num = ((!SetWxModeHelp.Ⴅ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 549, 607), 1, '@'), 495, 447)) ? (ⴀ[343] - 29591) : (ⴄႤ[101] / 9));
					continue;
				case 16:
					equatable = Ⴍ((string)equatable);
					equatable = ShowUsersHelp.Ⴅ((string)equatable, P_1.Tx.DxCmdMsgExt.SkimmerQuality, 944, 1022);
					num = 12;
					continue;
				case 12:
					num = ((!SetWxModeHelp.Ⴅ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 817, 843), 387, 'ǂ'), 86, 7)) ? 4 : 50);
					continue;
				case 50:
					equatable = Ⴍ((string)equatable);
					equatable = ShowUsersHelp.Ⴅ(equatable as string, P_1.Tx.DxCmdMsgExt.SpotterCty, 389, 459);
					num = 4;
					continue;
				case 4:
					num = ((!P_0.Cfg.Dx.CommentExt.SpotterState) ? 18 : 44);
					continue;
				case 44:
					equatable = Ⴍ(equatable as string);
					equatable = (string)equatable + P_1.Tx.DxCmdMsgExt.SpotterState;
					num = 18;
					continue;
				case 18:
					num = ((!P_0.Cfg.Dx.CommentExt.SpotterLoc) ? 45 : 33);
					continue;
				case 33:
					equatable = Ⴍ((string)equatable);
					num = ((P_1.Tx.DxCmdMsgExt.SpotterState.Length <= 0) ? 6 : (ⴀႳ[278] - 16209));
					continue;
				case 31:
					equatable = (equatable as string) + P_1.Tx.DxCmdMsgExt.SpotterState;
					num = ⴀႼ[74] - 169;
					continue;
				case 6:
					equatable = (string)equatable + P_1.Tx.DxCmdMsgExt.SpotterCty;
					num = ⴃႥ[241] - 26472;
					continue;
				case 45:
					num = ((!P_0.Cfg.Dx.CommentExt.SpotterCont) ? 41 : ⴄႭ[134]);
					continue;
				case 8:
					equatable = Ⴍ(equatable as string);
					equatable = (equatable as string) + P_1.Tx.DxCmdMsgExt.SpotterCont;
					num = ⴄႤ[323];
					continue;
				case 41:
					num = ((!(equatable as string).EndsWith(ReplyMailHelp.Ⴄ(24, null, 1057162113, 7))) ? 10 : 7);
					continue;
				case 7:
					equatable = (equatable as string).Substring(0, ((string)equatable).Length - 1);
					num = 10;
					continue;
				case 2:
				case 10:
					num = ((!P_0.Cfg.Dx.CommentExt.Eos) ? (ⴍႭ[234] - 34420) : 47);
					continue;
				case 47:
					obj = P_1.Tx.Msg[0] + SetTalkCount.Ⴗ(2, null, 1267022529, typeof(ShowCluster.ႨႨ)) + (string)equatable;
					num = ⴀ[321] - 31072;
					continue;
				case 25:
					num = ((((string)equatable).Length <= 28) ? 28 : (ⴀႳ[278] - 16231));
					continue;
				case 9:
					equatable = (equatable as string).Substring(0, 28);
					equatable = (equatable as string) + ႨႨ.Ⴀ(10, 5, 1157899793);
					num = ⴍႤ[273] / 6;
					continue;
				case 28:
					num = ((!Ⴀ(P_1.Tx.Msg[0], (equatable as string).Length)) ? 27 : 34);
					continue;
				case 34:
					obj = P_1.Tx.Msg[0].Substring(0, 69 - (equatable as string).Length) + (string)equatable + P_1.Tx.Msg[0].Substring(69);
					num = 0;
					continue;
				case 27:
					obj = P_1.Tx.Msg[0];
					num = ⴄႭ[66];
					continue;
				case 0:
					return obj as string;
				}
				break;
			}
		}
	}

	private static string Ⴍ(string P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		while (true)
		{
			int num = ((CallBlockCacheCfg.Ⴜ(P_0, 182, 215) <= 0) ? 2 : 6);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴐ[307] - 218;
					continue;
				case 1:
				case 4:
					break;
				case 6:
					P_0 = ShowUsersHelp.Ⴅ(P_0, ReplyMailHelp.Ⴄ(3, null, 1057162117, 3), 228, 170);
					num = ⴐ[329] - 83;
					continue;
				case 2:
				case 5:
					return P_0;
				}
				break;
			}
		}
	}

	private static bool Ⴀ(string P_0, int P_1)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		while (true)
		{
			int num = 70 - P_1;
			int num2 = num;
			while (true)
			{
				IL_004f:
				int num3 = ⴍႭ[320] - 30602;
				while (true)
				{
					switch (num3)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num3 = 1;
						continue;
					case 1:
						break;
					case 4:
						goto IL_004f;
					case 3:
						num3 = ((SetStationNeedsHelp.Ⴃ(P_0, num2, 588, 559) != ' ') ? 9 : 0);
						continue;
					case 9:
						return false;
					case 0:
						num2++;
						num3 = ⴄႷ[137] - 63932;
						continue;
					case 6:
					case 7:
						num3 = ((num2 < 70) ? 3 : 2);
						continue;
					case 2:
						return true;
					}
					break;
				}
				break;
			}
		}
	}

	private static bool Ⴃ(ArcConnect P_0, string P_1, string P_2)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		while (true)
		{
			IConvertible convertible;
			int num = (((convertible = P_1) == null) ? 9 : 8);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 7;
					continue;
				case 7:
				case 10:
					break;
				case 8:
					num = (ByeHelp.Ⴍ((string)convertible, SetStationQth.Ⴍ(null, 1687352333, 6, 30), 676, 707) ? 12 : 6);
					continue;
				case 6:
					num = (ByeHelp.Ⴍ((string)convertible, ReplyMail.Ⴅ(6, 13, 1217943150), 237, 138) ? 11 : 0);
					continue;
				case 0:
					num = (ByeHelp.Ⴍ(convertible as string, ShowWxHelp.Ⴍ('ò', 985806728, 6), 522, 621) ? 3 : 2);
					continue;
				case 2:
					num = ⴄႭ[195] - 43;
					continue;
				case 5:
				case 12:
					return ShowTalk.Ⴀ(IoDevicesCfg.Ⴅ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 588, 566), 324, 378), '\u031a', 769), P_2, 369, 'Đ');
				case 11:
					return P_0.Cfg.Dx.Needs.Ssb.Contains(P_2);
				case 3:
					return P_0.Cfg.Dx.Needs.Rtty.Contains(P_2);
				case 4:
				case 9:
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : SqlCeEngine
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 6;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄႤ[208] - 92;
				continue;
			case 4:
				num = (((P_1 ^ P_2) - 36) ^ num2) switch
				{
					0 => 8, 
					_ => ⴄႷ[90] - 34326, 
				};
				continue;
			case 7:
				num = 5;
				continue;
			case 8:
				P_0.CreateDatabase();
				goto case 5;
			case 5:
				num2++;
				num3 = 856;
				goto case 0;
			case 0:
			case 2:
				num4 = 47;
				break;
			case 3:
				break;
			case 1:
				return;
			}
			num = ((214 < num3 / 4 - num4) ? (ⴐ[78] - ⴐ[194]) : (ⴃႠ[165] - 47294));
		}
	}
}
