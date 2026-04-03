using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using ArcEngine.ArcCaches;
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
using ArcInterfaces.Io;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class SetDxExtension : IArcCmd
{
	private static void Ⴅ(NodeUserCmd P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 1;
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(2, 5, 1157906161), P_0.Rx.Msg, 895, 817));
				goto IL_0059;
			case 2:
				goto IL_0059;
			case 0:
				obj = new SetDxExtensionHelp();
				goto case 4;
			case 4:
				((SetDxExtensionHelp)obj).Exec(P_0);
				obj2 = new Publisher();
				break;
			case 3:
				break;
			}
			break;
			IL_0059:
			num = ⴅ[6];
		}
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		try
		{
			int num = 15;
			int num2 = default(int);
			IComparable<string> comparable = default(IComparable<string>);
			object obj2 = default(object);
			int value = default(int);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = ((cmd.Rx.Split.Length <= 2) ? 21 : 0);
					continue;
				case 0:
					Ⴓ(cmd);
					num2 = 3;
					num = ⴀ[439] - 14889;
					continue;
				case 8:
				case 24:
					comparable = SetDxFilter.Ⴀ(LogEntry.Ⴄ(cmd.Rx.Split[num2], 'ϒ', 1016), 221, '\u009d');
					num = 32;
					continue;
				case 32:
					num = (((obj2 = (string)comparable) == null) ? 11 : ⴄႭ[31]);
					continue;
				case 10:
					num = ((ႳႠ.Ⴗ != null) ? (ⴍႤ[494] - 40449) : 26);
					continue;
				case 25:
				case 26:
					ႳႠ.Ⴗ = new Dictionary<string, int>(16)
					{
						{
							ReplyMail.Ⴅ(3, 11, 1217943088),
							0
						},
						{
							SetStationQth.Ⴍ(null, 1687353746, 5, 24),
							1
						},
						{
							ShowWxHelp.Ⴍ('t', 985806816, 6),
							2
						},
						{
							ShowSkimCtyHelp.Ⴍ(1216131976, 4, 'ñ'),
							3
						},
						{
							ႰႥ.Ⴅ(1, 'ï', 952622755),
							4
						},
						{
							ReplyMail.Ⴅ(6, 5, 1217943084),
							5
						},
						{
							SetStationQth.Ⴍ(null, 1687353745, 0, 3),
							6
						},
						{
							ShowWxHelp.Ⴍ('þ', 985806827, 5),
							7
						},
						{
							ShowSkimCtyHelp.Ⴍ(1216131987, 1, '\u000e'),
							8
						},
						{
							ႰႥ.Ⴅ(5, '¼', 952622765),
							9
						},
						{
							SetStationClubHelp.Ⴍ(4, 2, 1747255505, null),
							10
						},
						{
							ShowWxHelp.Ⴍ('&', 985806813, 8),
							11
						},
						{
							ReplyMailHelp.Ⴄ(0, null, 1057165184, 4),
							12
						},
						{
							ReplyMail.Ⴅ(2, 2, 1217943512),
							13
						},
						{
							ႨႨ.Ⴀ(8, 1, 1157906087),
							14
						},
						{
							ShowSkimCtyHelp.Ⴍ(1216131993, 5, 'æ'),
							15
						}
					};
					num = 18;
					continue;
				case 18:
					num = ((!ႳႠ.Ⴗ.TryGetValue((string)obj2, out value)) ? (ⴀႣ[347] - 48125) : (ⴀႣ[375] - 21700));
					continue;
				case 4:
				{
					int num3;
					switch (value)
					{
					default:
						num3 = 28;
						break;
					case 0:
						num3 = ⴀႣ[136] - 4215;
						break;
					case 1:
						num3 = ⴄႭ[224];
						break;
					case 2:
						num3 = ⴀႳ[300] - 10789;
						break;
					case 3:
						num3 = ⴄႤ[180];
						break;
					case 4:
						num3 = ⴐ[257];
						break;
					case 5:
						num3 = ⴀႨ[64] - 60324;
						break;
					case 6:
						num3 = 9;
						break;
					case 7:
						num3 = ⴍႤ[465] - 52348;
						break;
					case 8:
						num3 = 12;
						break;
					case 9:
						num3 = 31;
						break;
					case 10:
					{
						byte num4 = ⴄႤ[401];
						AnnCacheCfg.ႠႼ[72] = (byte)((AnnCacheCfg.ႠႼ[72] ^ ShowWwvOptionsHelp.ႣႥ[73]) & 0x9D);
						num3 = num4 - 148;
						break;
					}
					case 11:
						num3 = 20;
						break;
					case 12:
						num3 = 13;
						break;
					case 13:
						num3 = ⴃႰ[100] - 44473;
						break;
					case 14:
						num3 = ⴀႨ[83] - 31142;
						break;
					case 15:
						num3 = 27;
						break;
					}
					num = num3;
					continue;
				}
				case 28:
					num = 11;
					continue;
				case 1:
					SetDxFilter.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 390, 508), 573, 'ɼ'), true, 495, 503);
					num = 11;
					continue;
				case 14:
					SetDxExtensionHelp.Ⴃ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 905, 1011), 28, ']'), true, 985, 897);
					num = 11;
					continue;
				case 29:
					SkimDupeDat.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 879, 789), 422, 'ǧ'), true, 'Ϗ', 'ϕ');
					num = ⴀႣ[257] - 51103;
					continue;
				case 30:
					UserLoginRegistrationCfg.Ⴍ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 445, 455), 267, 'Ŋ'), true, '\u007f', 118);
					num = ⴃႰ[204] - 24648;
					continue;
				case 7:
					ReplyMailHelp.Ⴍ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 212, 174), 1011, 'β'), true, 279, 'ť');
					num = 11;
					continue;
				case 17:
					ReplyMailHelp.Ⴍ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 269, 375), 236, '\u00ad'), true, 536, 'ɫ');
					num = 11;
					continue;
				case 9:
					ReplyMailHelp.Ⴍ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 996, 926), 935, 'Ϧ'), true, 1017, '\u038d');
					num = 11;
					continue;
				case 34:
					SetTalkDefaultHelp.Ⴄ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 195, 185), 787, '\u0352'), true, 644, 744);
					num = 11;
					continue;
				case 12:
					SetDxFilter.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 395, 497), 893, '\u033c'), true, 147, 138);
					num = 11;
					continue;
				case 31:
					cmd.Ⴍ().Cfg.Dx.CommentExt.Name = true;
					num = 11;
					continue;
				case 3:
					cmd.Ⴍ().Cfg.Dx.CommentExt.SpotterCty = true;
					goto case 23;
				case 23:
					num = 11;
					continue;
				case 20:
					cmd.Ⴍ().Cfg.Dx.CommentExt.SpotterState = true;
					num = 11;
					continue;
				case 13:
					cmd.Ⴍ().Cfg.Dx.CommentExt.SpotterLoc = true;
					num = 11;
					continue;
				case 19:
					cmd.Ⴍ().Cfg.Dx.CommentExt.SpotterCont = true;
					num = ⴀ[394] - 22131;
					continue;
				case 33:
					cmd.Ⴍ().Cfg.Dx.CommentExt.SkimmerQuality = true;
					num = ⴃႠ[188] - 18625;
					continue;
				case 27:
					cmd.Ⴍ().Cfg.Dx.CommentExt.Eos = true;
					goto case 11;
				case 11:
					num2++;
					num = 2;
					continue;
				case 2:
					num = ((num2 < cmd.Rx.Split.Length) ? 24 : (ⴃႥ[78] - 62906));
					continue;
				case 5:
				{
					ICloneable cloneable = Ⴍ(cmd);
					cmd.Tx.Msg.Add((string)cloneable);
					obj = new Publisher();
					num = ⴐ[204];
					continue;
				}
				case 6:
					(obj as Publisher).Process(cmd);
					num = 22;
					continue;
				case 21:
					Ⴅ(cmd);
					break;
				case 22:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴅ(cmd);
		}
		switch (4)
		{
		}
	}

	private static void Ⴓ(NodeUserCmd P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 9;
		while (true)
		{
			switch (num)
			{
			default:
				SetDxFilter.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 39, 93), 357, 'Ĥ'), false, 296, 304);
				num = 4;
				break;
			case 4:
				SetDxExtensionHelp.Ⴃ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 735, 677), 785, '\u0350'), false, 244, 172);
				num = ⴍႭ[370] - 25906;
				break;
			case 6:
			case 7:
				SkimDupeDat.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 63, 69), 952, 'Ϲ'), false, 'ʧ', 'ʽ');
				num = 1;
				break;
			case 1:
				UserLoginRegistrationCfg.Ⴍ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 468, 430), 788, '\u0355'), false, 'þ', 247);
				num = ⴍႭ[115] - 12358;
				break;
			case 0:
				ReplyMailHelp.Ⴍ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 987, 929), 175, 'î'), false, 314, 'ň');
				num = 13;
				break;
			case 2:
			case 13:
				ReplyMailHelp.Ⴍ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 394, 496), 460, 'ƍ'), false, 386, 'Ǳ');
				num = ⴀႣ[27] - 42954;
				break;
			case 3:
				SetTalkDefaultHelp.Ⴄ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 933, 991), 901, 'τ'), false, 328, 292);
				num = 10;
				break;
			case 10:
				P_0.Ⴍ().Cfg.Dx.CommentExt.ItuZone = false;
				P_0.Ⴍ().Cfg.Dx.CommentExt.Grid = false;
				num = 5;
				break;
			case 5:
				P_0.Ⴍ().Cfg.Dx.CommentExt.Name = false;
				P_0.Ⴍ().Cfg.Dx.CommentExt.SpotterCty = false;
				num = 14;
				break;
			case 14:
				P_0.Ⴍ().Cfg.Dx.CommentExt.SpotterState = false;
				P_0.Ⴍ().Cfg.Dx.CommentExt.SpotterLoc = false;
				num = 11;
				break;
			case 11:
				P_0.Ⴍ().Cfg.Dx.CommentExt.SpotterCont = false;
				goto case 8;
			case 8:
				P_0.Ⴍ().Cfg.Dx.CommentExt.SkimmerQuality = false;
				num = 12;
				break;
			case 12:
				P_0.Ⴍ().Cfg.Dx.CommentExt.Eos = false;
				return;
			}
		}
	}

	private static string Ⴍ(NodeUserCmd P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		while (true)
		{
			IEnumerable enumerable = string.Empty;
			int num = ((!HamQthCfg.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 573, 583), 316, 'Ž'), 'Ú', '\u009b')) ? (ⴀႨ[82] - 5739) : (ⴀႣ[247] - 12299));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴍႭ[124] - 41297;
					continue;
				case 9:
					break;
				case 10:
					enumerable = ShowUsersHelp.Ⴅ(enumerable as string, SetStationClubHelp.Ⴍ(2, 2, 1747259310, null), 36, 106);
					num = ⴅ[301] / 4;
					continue;
				case 33:
					num = ((!SetWxCountHelp.Ⴀ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 402, 488), 937, 'Ϩ'), 473, 389)) ? 7 : (ⴄႤ[452] - ⴄႤ[407]));
					continue;
				case 25:
					enumerable = ShowUsersHelp.Ⴅ((string)enumerable, SetStationClubHelp.Ⴍ(7, 1, 1747259301, null), 369, 319);
					num = 7;
					continue;
				case 7:
					num = ((!DxCacheCfg.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 77, 55), 491, 'ƪ'), 475, 476)) ? 15 : (ⴀ[92] - 2227));
					continue;
				case 11:
					enumerable = ShowUsersHelp.Ⴅ(enumerable as string, SetStationClubHelp.Ⴍ(8, 4, 1747259355, null), 13, 67);
					num = ⴀႳ[258] - 27276;
					continue;
				case 15:
				case 19:
					num = ((!HamQthDotComLookupExt.Ⴀ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 89, 35), 1021, 'μ'), 243, 235)) ? 38 : (ⴃႰ[114] - 38464));
					continue;
				case 0:
				case 20:
					enumerable = ShowUsersHelp.Ⴅ((string)enumerable, SetStationClubHelp.Ⴍ(9, 5, 1747259345, null), 622, 544);
					num = ⴃႥ[109] - 17124;
					continue;
				case 38:
					num = ((!SetStationClub.Ⴄ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 315, 321), 341, 'Ĕ'), 773, 832)) ? (ⴃႥ[5] - 12765) : 30);
					continue;
				case 30:
					enumerable = ShowUsersHelp.Ⴅ((string)enumerable, SetStationClubHelp.Ⴍ(4, 5, 1747259338, null), 116, 58);
					num = ⴄႤ[520] - 22;
					continue;
				case 6:
					num = ((!HamQthDotComLookupExt.Ⴀ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 803, 857), 1022, 'ο'), 135, 158)) ? 18 : 21);
					continue;
				case 21:
					enumerable = ShowUsersHelp.Ⴅ(enumerable as string, SetStationClubHelp.Ⴍ(6, 4, 1747259390, null), 16, 94);
					num = ⴃႥ[168] - 13128;
					continue;
				case 18:
					num = ((!HamQthCfg.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 258, 376), 586, 'ȋ'), 'Æ', '\u0084')) ? 4 : 27);
					continue;
				case 27:
					enumerable = ShowUsersHelp.Ⴅ(enumerable as string, SetStationClubHelp.Ⴍ(3, 8, 1747259384, null), 362, 292);
					num = 4;
					continue;
				case 4:
				case 34:
					num = ((!SetStationClub.Ⴄ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 14, 116), 283, 'Ś'), 111, 41)) ? 23 : (ⴍႭ[370] - 25899));
					continue;
				case 13:
					enumerable = ShowUsersHelp.Ⴅ(enumerable as string, SetStationClubHelp.Ⴍ(15, 7, 1747259375, null), 860, 786);
					num = 23;
					continue;
				case 23:
					num = ((!SetStationClub.Ⴄ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 478, 420), 807, '\u0366'), 533, 594)) ? (ⴅ[169] - 125) : 36);
					continue;
				case 36:
					enumerable = ShowUsersHelp.Ⴅ((string)enumerable, SetStationClubHelp.Ⴍ(6, 7, 1747259361, null), 935, 1001);
					num = 29;
					continue;
				case 29:
					num = ((!SkimDupeDat.Ⴐ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 238, 148), 704, 'ʁ'), 981, 898)) ? 24 : ⴄႤ[47]);
					continue;
				case 12:
					enumerable = (string)enumerable + SetStationClubHelp.Ⴍ(8, 8, 1747259157, null);
					num = 24;
					continue;
				case 24:
					num = ((!P_0.Ⴍ().Cfg.Dx.CommentExt.SpotterCty) ? 26 : 22);
					continue;
				case 22:
					enumerable = (string)enumerable + ReplyMail.Ⴅ(8, 13, 1217943488);
					num = 26;
					continue;
				case 26:
					num = ((!P_0.Ⴍ().Cfg.Dx.CommentExt.SpotterState) ? (ⴄႭ[236] - 73) : 32);
					continue;
				case 32:
					enumerable = (enumerable as string) + SetStationClubHelp.Ⴍ(0, 7, 1747259136, null);
					num = 35;
					continue;
				case 35:
					num = ((!P_0.Ⴍ().Cfg.Dx.CommentExt.SpotterLoc) ? (ⴄႤ[301] - 170) : 37);
					continue;
				case 37:
					enumerable = (string)enumerable + SetStationClubHelp.Ⴍ(6, 7, 1747259184, null);
					num = ⴄႤ[148];
					continue;
				case 1:
					num = ((!P_0.Ⴍ().Cfg.Dx.CommentExt.SpotterCont) ? 28 : 5);
					continue;
				case 5:
					enumerable = (string)enumerable + SetStationClubHelp.Ⴍ(11, 2, 1747259171, null);
					num = 28;
					continue;
				case 28:
					num = ((!P_0.Ⴍ().Cfg.Dx.CommentExt.SkimmerQuality) ? 31 : 16);
					continue;
				case 16:
					enumerable = (string)enumerable + ReplyMail.Ⴅ(1, 4, 1217943447);
					num = 31;
					continue;
				case 31:
					num = ((!P_0.Ⴍ().Cfg.Dx.CommentExt.Eos) ? (ⴍႤ[134] - 41368) : 14);
					continue;
				case 14:
					enumerable = (string)enumerable + SetStationClubHelp.Ⴍ(9, 7, 1747259223, null);
					num = 8;
					continue;
				case 8:
					num = ((((string)enumerable).Length != 0) ? 17 : 2);
					continue;
				case 2:
					enumerable = CallBlockCacheCfg.Ⴅ(null, 2, 62056210, null);
					num = 17;
					continue;
				case 17:
					return SetTalkCount.Ⴗ(7, null, 1267018641, typeof(ShowWwv.ႥႣ)) + (string)enumerable;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string where _0021_00211 : ClientIoCfg
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 3;
				continue;
			case 3:
			case 4:
				num = (((P_2 ^ P_3) - 12) ^ num2) switch
				{
					0 => ⴃႰ[112] - 2872, 
					_ => 2, 
				};
				continue;
			case 2:
				num = 6;
				continue;
			case 0:
			case 7:
				P_0.ConnectAs = P_1;
				break;
			case 1:
			case 6:
				break;
			case 8:
				return;
			}
			num2++;
			int num3 = 510;
			int num4 = 75;
			num = ((255 < num3 / 2 - num4) ? 3 : 8);
		}
	}
}
