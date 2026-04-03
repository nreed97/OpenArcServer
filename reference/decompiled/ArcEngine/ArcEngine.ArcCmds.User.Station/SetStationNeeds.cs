using System;
using System.Collections.Generic;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcServerConfig.Io;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationNeeds : IArcCmd
{
	private static void Ⴅ(NodeUserCmd P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 4:
				obj = new SetStationNeedsHelp();
				goto case 0;
			case 0:
				((SetStationNeedsHelp)obj).Exec(P_0);
				break;
			case 3:
				break;
			case 1:
				return;
			}
			break;
			IL_0023:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(8, 4, 1157906223), P_0.Rx.Msg, 620, 546));
			num = ⴃႥ[205] - 24720;
		}
		object obj2 = new Publisher();
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		try
		{
			int num = 12;
			object obj2 = default(object);
			ICloneable cloneable = default(ICloneable);
			object obj = default(object);
			IComparable comparable = default(IComparable);
			int value = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = ((cmd.Rx.Split.Length < 5) ? 17 : 19);
					continue;
				case 19:
					obj2 = SetDxFilter.Ⴀ(cmd.Rx.Split[3], 402, 'Ǔ');
					num = ⴅ[192] / 6;
					continue;
				case 34:
					cloneable = SetDxFilter.Ⴀ(cmd.Rx.GetMsgEnd(4), 322, 'ă');
					cloneable = ShowContestStationHelp.Ⴅ(SetTalkDefault.Ⴃ(cloneable as string, 763, '\u02d7'), SetTalkCount.Ⴗ(1, null, 1267022530, typeof(SetWwvOutputHelp)), string.Empty, 125, '%');
					num = 29;
					continue;
				case 29:
					obj = new Publisher();
					num = (((comparable = obj2 as string) == null) ? 21 : 36);
					continue;
				case 36:
					num = ((ႳႠ.Ⴐ != null) ? 43 : 10);
					continue;
				case 10:
					ႳႠ.Ⴐ = new Dictionary<string, int>(9)
					{
						{
							SetStationQth.Ⴍ(null, 1687352334, 5, 18),
							0
						},
						{
							ShowSkimCtyHelp.Ⴍ(1216131724, 5, '\u00ad'),
							1
						},
						{
							ႰႥ.Ⴅ(3, 'ö', 952622861),
							2
						},
						{
							ReplyMail.Ⴅ(5, 12, 1217943149),
							3
						},
						{
							SetStationQth.Ⴍ(null, 1687353915, 3, 19),
							4
						},
						{
							ShowWxHelp.Ⴍ('\u0018', 985806716, 6),
							5
						},
						{
							ShowWxHelp.Ⴍ('\u0014', 985806734, 0),
							6
						},
						{
							ႰႥ.Ⴅ(6, '\u008d', 952622870),
							7
						},
						{
							ReplyMail.Ⴅ(3, 12, 1217943297),
							8
						}
					};
					num = 43;
					continue;
				case 43:
					num = ((!ႳႠ.Ⴐ.TryGetValue(comparable as string, out value)) ? 21 : 2);
					continue;
				case 2:
					num = value switch
					{
						0 => ⴄႷ[66] - 17209, 
						1 => ⴀႣ[333] - 23428, 
						2 => 7, 
						3 => 16, 
						4 => 20, 
						5 => ⴃႠ[411] - 51461, 
						6 => ⴐ[270] - 222, 
						7 => 37, 
						8 => 32, 
						_ => ⴐ[308] - 79, 
					};
					continue;
				case 28:
					num = ⴀႣ[307] - 30931;
					continue;
				case 33:
					SetTalkOutput.Ⴓ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 209, 171), 861, 867), AnnHelp.Ⴈ(ShowWxHelp.Ⴍ('©', 985808777, 4), cloneable as string, ShowWxHelp.Ⴍ('\u0003', 985808782, 3), 308, 'ă'), '\u0085', 139);
					num = 27;
					continue;
				case 27:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(CallBlockCacheCfg.Ⴅ(null, 1, 62056350, null), SetTalkDefault.Ⴃ(IoDevicesCfg.Ⴅ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 404, 494), 601, 615), 'ϵ', 1006), 91, 'v'), 211, 157));
					goto case 1;
				case 1:
					num = 11;
					continue;
				case 11:
					((Publisher)obj).Process(cmd);
					num = 3;
					continue;
				case 5:
					SetTalkOutput.Ⴓ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 847, 821), 464, 494), Ⴈ(IoDevicesCfg.Ⴅ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 514, 632), 89, 103), '\u008b', 144), cloneable as string), '\u0351', 863);
					num = 23;
					continue;
				case 23:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(CallBlockCacheCfg.Ⴅ(null, 2, 62056349, null), SetTalkDefault.Ⴃ(IoDevicesCfg.Ⴅ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 498, 392), 374, 328), 'Ɛ', 395), 712, '\u02e5'), 149, 219));
					num = ⴃႥ[143] - 48112;
					continue;
				case 31:
				case 38:
					((Publisher)obj).Process(cmd);
					num = ⴀႼ[33] / 3;
					continue;
				case 7:
					SetTalkOutput.Ⴓ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 229, 159), 951, 905), Ⴄ(IoDevicesCfg.Ⴅ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 404, 494), 454, 504), '\u02d6', 717), cloneable as string), 'ϖ', 984);
					num = 42;
					continue;
				case 42:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(CallBlockCacheCfg.Ⴅ(null, 8, 62056343, null), SetTalkDefault.Ⴃ(IoDevicesCfg.Ⴅ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 865, 795), 263, 313), 'Ϫ', 1009), 700, 'ʑ'), 261, 331));
					num = ⴐ[27] / 5;
					continue;
				case 30:
					(obj as Publisher).Process(cmd);
					goto case 8;
				case 8:
					num = ⴄႷ[116] - 52929;
					continue;
				case 16:
					ShowVersionHelp.Ⴍ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 718, 692), 829, 771), AnnHelp.Ⴈ(ShowWxHelp.Ⴍ('Ì', 985808783, 2), cloneable as string, ShowWxHelp.Ⴍ('\u0088', 985808778, 7), 482, 'Ǖ'), 293, 'Ě');
					num = ⴍႭ[62] - 28313;
					continue;
				case 26:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216131780, 8, 'ë'), SetTalkDefault.Ⴃ(SetWxDefault.Ⴍ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 283, 353), 406, 424), '\u034e', 833), 562, 'ȟ'), 210, 156));
					num = ⴄႷ[126] - 39145;
					continue;
				case 25:
					(obj as Publisher).Process(cmd);
					num = ⴀႨ[45] - 15630;
					continue;
				case 20:
					ShowVersionHelp.Ⴍ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 358, 284), 106, 84), Ⴈ(SetWxDefault.Ⴍ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 621, 535), 559, 529), '\u031b', 788), cloneable as string), 827, '\u0304');
					num = 0;
					continue;
				case 0:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216131788, 0, '\u007f'), SetTalkDefault.Ⴃ(SetWxDefault.Ⴍ(SkimDupeDat.Ⴃ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 766, 644), 516, 570), 'ø', 247), 911, '\u03a2'), 966, 904));
					num = ⴀႼ[15] - 136;
					continue;
				case 13:
					((Publisher)obj).Process(cmd);
					num = ⴃႰ[100] - 44489;
					continue;
				case 22:
					cmd.Ⴍ().Cfg.Dx.Needs.Ssb = Ⴄ(cmd.Ⴍ().Cfg.Dx.Needs.Ssb, (string)cloneable);
					num = ⴄႭ[338] / 9;
					continue;
				case 24:
				{
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131790, 2, '"') + UtilsString.RemoveStartAndEndCommas(cmd.Ⴍ().Cfg.Dx.Needs.Ssb));
					char num2 = ⴀႳ[290];
					Arc4ServerClient.ႠႣ[227] = (char)((Arc4ServerClient.ႠႣ[227] - Arc4ServerClient.ႠႣ[307]) & 0xB9);
					num = num2 - 40252;
					continue;
				}
				case 39:
					((Publisher)obj).Process(cmd);
					num = 3;
					continue;
				case 4:
					cmd.Ⴍ().Cfg.Dx.Needs.Rtty = ShowWxHelp.Ⴍ('L', 985808773, 8) + (cloneable as string) + ShowWxHelp.Ⴍ('6', 985808783, 2);
					num = 35;
					continue;
				case 35:
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(10, 3, 1157906186) + UtilsString.RemoveStartAndEndCommas(cmd.Ⴍ().Cfg.Dx.Needs.Rtty));
					num = ⴃႥ[111] - 24779;
					continue;
				case 41:
					((Publisher)obj).Process(cmd);
					num = 3;
					continue;
				case 37:
					cmd.Ⴍ().Cfg.Dx.Needs.Rtty = Ⴈ(cmd.Ⴍ().Cfg.Dx.Needs.Rtty, (string)cloneable);
					num = ⴀႼ[33];
					continue;
				case 9:
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(1, 6, 1157906191) + UtilsString.RemoveStartAndEndCommas(cmd.Ⴍ().Cfg.Dx.Needs.Rtty));
					num = 18;
					continue;
				case 18:
					(obj as Publisher).Process(cmd);
					num = ⴀ[515] - 965;
					continue;
				case 32:
					cmd.Ⴍ().Cfg.Dx.Needs.Rtty = Ⴄ(cmd.Ⴍ().Cfg.Dx.Needs.Rtty, (string)cloneable);
					num = 14;
					continue;
				case 14:
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(12, 6, 1157906191) + UtilsString.RemoveStartAndEndCommas(cmd.Ⴍ().Cfg.Dx.Needs.Rtty));
					num = ⴀႳ[236] - 22325;
					continue;
				case 40:
					(obj as Publisher).Process(cmd);
					num = 3;
					continue;
				case 21:
					Ⴅ(cmd);
					goto case 3;
				case 3:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					num = 6;
					continue;
				case 17:
					Ⴅ(cmd);
					break;
				case 6:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴅ(cmd);
		}
		switch (1)
		{
		}
	}

	private static string Ⴈ(string P_0, string P_1)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		while (true)
		{
			P_0 = SetTalkDefault.Ⴃ(P_0, 56, '\u0015');
			while (true)
			{
				IL_0072:
				P_0 = qslinfoResponse.Ⴗ(P_0, ShowWxHelp.Ⴍ('\u001c', 985808782, 3), P_1, ShowWxHelp.Ⴍ(':', 985808783, 2), 465, 'Ʋ');
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
					{
						/*OpCode not supported: LdMemberToken*/;
						char num2 = ⴃႰ[189];
						ShowWwvOptionsHelp.ႣႥ[365] = (char)((ShowWwvOptionsHelp.ႣႥ[365] + ShowWwvOptionsHelp.ႣႥ[134]) & 0xB9);
						num = num2 - 41971;
						continue;
					}
					case 3:
					case 4:
						break;
					case 1:
						goto IL_0072;
					case 2:
					case 5:
						return P_0;
					}
					break;
				}
				break;
			}
		}
	}

	private static string Ⴄ(string P_0, string P_1)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num2 = default(int);
		while (true)
		{
			Array array = new char[1];
			(array as char[])[0] = ',';
			Array array2 = Directory.Ⴓ(P_1, (char[])array, 621, 571);
			int num = ⴃႰ[125] - 57500;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႭ[246];
					continue;
				case 2:
					break;
				case 1:
				case 4:
					num2 = 0;
					num = ⴍႭ[125] - 56615;
					continue;
				case 7:
				case 9:
					P_0 = ShowContestStationHelp.Ⴅ(P_0, AnnHelp.Ⴈ(ShowWxHelp.Ⴍ('8', 985808773, 8), ((string[])array2)[num2], ShowWxHelp.Ⴍ('\v', 985808779, 6), 764, 'ˋ'), ShowWxHelp.Ⴍ('\u0012', 985808777, 4), 20, 'L');
					num = ⴀႳ[347] - 25067;
					continue;
				case 6:
					num2++;
					num = 0;
					continue;
				case 0:
				case 8:
					num = ((num2 < ((string[])array2).Length) ? (ⴀ[470] - 21324) : 3);
					continue;
				case 3:
					return P_0;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴓ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, short P_3) where _0021_00210 : IFormatProvider where _0021_00211 : string
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		DateTime result = default(DateTime);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[367];
					continue;
				case 4:
					break;
				case 5:
					num2 = (((P_2 ^ P_3) - 97) ^ num) switch
					{
						0 => ⴀႨ[144] - 11818, 
						_ => 2, 
					};
					continue;
				case 1:
				case 2:
					result = default(DateTime);
					goto case 11;
				case 11:
					num2 = 8;
					continue;
				case 10:
					result = DateTime.Parse(P_0, P_1);
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 9;
					continue;
				case 9:
					num2 = ((num3 % 2 != 0) ? 5 : 6);
					continue;
				case 0:
				case 6:
					return result;
				case 3:
					num2 = ⴐ[81] - 130;
					continue;
				}
				break;
			}
		}
	}
}
