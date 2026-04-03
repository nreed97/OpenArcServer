using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces;
using ArcInterfaces.Arcx;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods.Login;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowSun : IArcCmd
{
	private static void Ⴃ(NodeUserCmd P_0)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 3:
				obj = new ShowSunHelp();
				goto case 2;
			case 2:
				(obj as ShowSunHelp).Exec(P_0);
				break;
			case 0:
				break;
			}
			break;
			IL_0023:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(7, 5, 1157898679), P_0.Rx.Msg, 1001, 935));
			num = ⴀႼ[112] - 213;
		}
		object obj2 = new Publisher();
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		try
		{
			int num = 12;
			IComparable<string> msgEnd = default(IComparable<string>);
			string empty = default(string);
			DateTime dateTime = default(DateTime);
			BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = ((cmd.Rx.Split.Length == 2) ? 2 : (ⴄႤ[397] - ⴄႤ[15]));
					continue;
				case 22:
					num = ((cmd.Rx.Split.Length == 3) ? 2 : 5);
					continue;
				case 5:
					num = ((cmd.Rx.Split.Length != 4) ? (ⴃႰ[8] - ⴃႰ[8]) : 2);
					continue;
				case 2:
					msgEnd = cmd.Rx.GetMsgEnd(2);
					empty = string.Empty;
					dateTime = ShowAnnHelp.Ⴅ('Ɨ', 422);
					num = 25;
					continue;
				case 25:
					Ⴅ(msgEnd as string, ref empty, ref dateTime);
					num = ((CallBlockCacheCfg.Ⴜ(empty, 457, 424) != 0) ? 18 : 14);
					continue;
				case 14:
					num = ((!ShowPrefix.Ⴓ(global::Ⴈ.ႰႰ.Ⴅ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 525, 539), 509, 'Ƴ'), ByeHelp.Ⴅ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 263, 273), 'Ɛ', 465), 999, 'ι')) ? 21 : 13);
					continue;
				case 13:
					Ⴃ(cmd, SetAnnChatRoomsHelp.Ⴄ(ref dateTime, 257, 312), ReadMailHelp.Ⴓ(ref dateTime, 99, 35), SetWxCountHelp.Ⴄ(ref dateTime, 'ƻ', 419), ByeHelp.Ⴅ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 128, 150), 'Ȣ', 611), global::Ⴈ.ႰႰ.Ⴅ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 97, 119), 186, 'ô'));
					num = 1;
					continue;
				case 1:
				{
					cmd.Tx.Msg.Add(ႰႥ.Ⴅ(0, 'p', 952616302));
					List<string> msg = cmd.Tx.Msg;
					string text = CallBlockCacheCfg.Ⴅ(null, 6, 62062020, null);
					float num2 = global::Ⴈ.ႰႰ.Ⴅ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 421, 435), 473, 'Ɨ');
					msg.Add(ShowUsersHelp.Ⴅ(text, ShowDxOptionsHelp.Ⴅ(ref num2, ShowSkimCtyHelp.Ⴍ(1216131780, 5, '\u0081'), 101, 'g'), 744, 678));
					num = ⴍႭ[306] - 20875;
					continue;
				}
				case 9:
				{
					List<string> msg2 = cmd.Tx.Msg;
					string text2 = ReplyMail.Ⴅ(0, 12, 1217940951);
					float num3 = ByeHelp.Ⴅ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 96, 118), '\u0097', 214);
					msg2.Add(ShowUsersHelp.Ⴅ(text2, ShowDxOptionsHelp.Ⴅ(ref num3, ShowSkimCtyHelp.Ⴍ(1216131779, 2, '\r'), 527, 'ȍ'), 124, 50));
					num = 6;
					continue;
				}
				case 21:
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130477, 1, '='));
					num = 6;
					continue;
				case 18:
					baseXmlSerializer = new ArcConnect();
					((ArcConnect)baseXmlSerializer).Call = empty;
					ShowStation.Ⴗ(cmd.Ⴍ().Ⴅ(), baseXmlSerializer as ArcConnect);
					goto case 10;
				case 10:
				case 19:
					num = 24;
					continue;
				case 24:
					num = ((!ShowPrefix.Ⴓ(global::Ⴈ.ႰႰ.Ⴅ(ShowConnectsHelp.Ⴍ((baseXmlSerializer as ArcConnect).Cfg, 443, 429), 50, '|'), ByeHelp.Ⴅ(ShowConnectsHelp.Ⴍ(((ArcConnect)baseXmlSerializer).Cfg, 1014, 992), '\u030e', 847), 974, 'ΐ')) ? 15 : (ⴀႨ[79] - 6696));
					continue;
				case 20:
					Ⴃ(cmd, SetAnnChatRoomsHelp.Ⴄ(ref dateTime, 374, 335), ReadMailHelp.Ⴓ(ref dateTime, 679, 743), SetWxCountHelp.Ⴄ(ref dateTime, 'Ι', 897), global::Ⴈ.ႰႰ.Ⴅ(ShowConnectsHelp.Ⴍ((baseXmlSerializer as ArcConnect).Cfg, 897, 919), 55, 'y'), ByeHelp.Ⴅ(ShowConnectsHelp.Ⴍ((baseXmlSerializer as ArcConnect).Cfg, 258, 276), 'Ϥ', 933));
					num = 11;
					continue;
				case 11:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႰႥ.Ⴅ(6, '²', 952616296), empty, 593, 543));
					num = 8;
					continue;
				case 8:
				case 23:
					cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 6, 62062020, null) + ((ArcConnect)baseXmlSerializer).Cfg.Station.Lat.ToString(ShowSkimCtyHelp.Ⴍ(1216131779, 2, '\u0015')));
					num = 16;
					continue;
				case 16:
					cmd.Tx.Msg.Add(ReplyMail.Ⴅ(3, 9, 1217940948) + (baseXmlSerializer as ArcConnect).Cfg.Station.Lon.ToString(ShowSkimCtyHelp.Ⴍ(1216131778, 3, 'ù')));
					num = 26;
					continue;
				case 26:
					num = ((!((baseXmlSerializer as ArcConnect).Cty != ReplyMailHelp.Ⴄ(26, null, 1057162201, 2))) ? 6 : 7);
					continue;
				case 7:
					num = ((!(((ArcConnect)baseXmlSerializer).Cty != CallBlockCacheCfg.Ⴅ(null, 8, 62057557, null))) ? 6 : 3);
					continue;
				case 3:
					cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687354892, 1, 22) + cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႷ()
						.Ⴓ(((ArcConnect)baseXmlSerializer).Cty));
					num = ⴄႷ[29] - 57766;
					continue;
				case 15:
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130476, 0, ','));
					goto case 6;
				case 6:
				{
					object obj = new Publisher();
					(obj as Publisher).Process(cmd);
					num = 4;
					continue;
				}
				case 0:
					Ⴃ(cmd);
					break;
				case 4:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴃ(cmd);
		}
		switch (1)
		{
		}
	}

	private static void Ⴅ(string P_0, ref string P_1, ref DateTime P_2)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 2;
		object obj = default(object);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
			{
				Array array = new char[1];
				((char[])array)[0] = ',';
				obj = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, (char[])array, 222, 136);
				num = ⴍႭ[203] - 29756;
				break;
			}
			case 4:
			case 10:
				num2 = 0;
				num = ⴀ[273] - 46730;
				break;
			case 7:
				num = ((!Ⴐ(((string[])obj)[num2])) ? (ⴃႰ[127] - 32164) : 0);
				break;
			case 0:
			case 1:
				P_2 = SetTalkDefaultHelp.Ⴀ(((string[])obj)[num2], 394, 463);
				num = ⴃႠ[324] - 29386;
				break;
			case 6:
				P_1 = SetDxFilter.Ⴀ(SetDxFilter.Ⴀ((obj as string[])[num2], 767, 'ʿ'), 252, '½');
				num = ⴀႼ[101] - 33;
				break;
			case 8:
			{
				int num3 = num2;
				SetAnnMode.ႤႭ[427] = (byte)((SetAnnMode.ႤႭ[427] ^ AnnCacheCfg.ႠႼ[6]) & 0xBA);
				num2 = num3 + 1;
				num = ⴐ[212] - 4;
				break;
			}
			case 5:
			case 9:
				num = ((num2 < (obj as string[]).Length) ? (ⴀႨ[44] - 6924) : 3);
				break;
			case 3:
				return;
			}
		}
	}

	private static bool Ⴐ(string P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			Array array = new char[1];
			(array as char[])[0] = '-';
			Array array2 = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, array as char[], 804, 882);
			int num = 9;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
					break;
				case 3:
				case 9:
					num = ((((string[])array2).Length == 3) ? 1 : 8);
					continue;
				case 1:
					num = ((!SkimmerValidSpot.Ⴈ(((string[])array2)[0], 826, 846)) ? ⴅ[210] : 6);
					continue;
				case 6:
					num = ((!SkimmerValidSpot.Ⴈ((array2 as string[])[1], 943, 987)) ? 8 : (ⴄႭ[311] - ⴄႭ[49]));
					continue;
				case 5:
					num = ((!SkimmerValidSpot.Ⴈ(((string[])array2)[2], 921, 1005)) ? (ⴃႰ[136] - 29124) : 11);
					continue;
				case 11:
					num4 = ShowVersion.Ⴄ((array2 as string[])[0], 'ɏ', 'ɽ');
					num3 = ShowVersion.Ⴄ(((string[])array2)[1], 'ǫ', 'Ǚ');
					num = 12;
					continue;
				case 12:
					num2 = ShowVersion.Ⴄ((array2 as string[])[2], 'Ę', 'Ī');
					num = ((num4 <= 0) ? 8 : 4);
					continue;
				case 4:
				case 14:
					num = ((num4 >= 13) ? 8 : 16);
					continue;
				case 16:
				case 17:
					num = ((num3 <= 0) ? 8 : 13);
					continue;
				case 13:
					num = ((num3 >= 32) ? ⴅ[210] : 15);
					continue;
				case 15:
					num = ((num2 <= 1900) ? ⴐ[243] : (ⴍႤ[251] - 35336));
					continue;
				case 10:
					num = ((num2 >= 3000) ? 8 : (ⴀ[54] - 17320));
					continue;
				case 2:
					return true;
				case 8:
					return false;
				}
				break;
			}
		}
	}

	private static void Ⴃ(NodeUserCmd P_0, int P_1, int P_2, int P_3, double P_4, double P_5)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ReplyMailHelp.Ⴄ(0, null, 1057167019, 0));
				num = 2;
				break;
			case 2:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႰႥ.Ⴅ(1, '\u008a', 952616203), Ⴄ(P_1, P_2, P_3, P_4, P_5, P_0.Ⴍ()), 28, 82));
				num = ⴍႤ[395] - 14302;
				break;
			case 6:
			case 7:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetStationQth.Ⴍ(null, 1687354939, 2, 27), Ⴍ(P_1, P_2, P_3, P_4, P_5, P_0.Ⴍ()), 489, 423));
				num = 0;
				break;
			case 0:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216130063, 6, 'L'), Ⴀ(P_1, P_2, P_3, P_4, P_5, P_0.Ⴍ()), 541, 595));
				goto case 3;
			case 3:
				num = 1;
				break;
			case 1:
			case 5:
				P_0.Tx.Msg.Add(ReplyMail.Ⴅ(7, 14, 1217940941) + Ⴓ(P_1, P_2, P_3, P_4, P_5, P_0.Ⴍ()));
				return;
			}
		}
	}

	private static string Ⴄ(int P_0, int P_1, int P_2, double P_3, double P_4, ArcConnect P_5)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		while (true)
		{
			double trise = 0.0;
			while (true)
			{
				IL_004e:
				double tset = 0.0;
				while (true)
				{
					IL_0058:
					int num = SunCalculations.SunRiseSet(P_0, P_1, P_2, P_3, P_4, -7.0 / 12.0, upperLimb: true, ref trise, ref tset);
					int num2 = ⴄႷ[44] - 49666;
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							num2 = ⴀႼ[138] - 65;
							continue;
						case 3:
							break;
						case 4:
							goto IL_004e;
						case 0:
						case 1:
							goto IL_0058;
						case 2:
							return Ⴍ(num, trise, tset, P_5);
						}
						break;
					}
					break;
				}
				break;
			}
		}
	}

	private static string Ⴍ(int P_0, int P_1, int P_2, double P_3, double P_4, ArcConnect P_5)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		while (true)
		{
			double trise = 0.0;
			double tset = 0.0;
			while (true)
			{
				IL_007d:
				int num = SunCalculations.SunRiseSet(P_0, P_1, P_2, P_3, P_4, -6.0, upperLimb: false, ref trise, ref tset);
				while (true)
				{
					IL_0097:
					int num2 = ⴍႤ[402] - 27287;
					while (true)
					{
						switch (num2)
						{
						default:
						{
							/*OpCode not supported: LdMemberToken*/;
							char num3 = ⴃႠ[242];
							ႨႣ.Ⴐ[267] = (byte)((ႨႣ.Ⴐ[267] | DirectoryBulletin.ႠႨ[34]) & 0x4E);
							num2 = num3 - 57252;
							continue;
						}
						case 1:
							break;
						case 0:
							goto IL_007d;
						case 3:
							goto IL_0097;
						case 5:
							return Ⴍ(num, trise, tset, P_5);
						}
						break;
					}
					break;
				}
				break;
			}
		}
	}

	private static string Ⴀ(int P_0, int P_1, int P_2, double P_3, double P_4, ArcConnect P_5)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		while (true)
		{
			double trise = 0.0;
			double tset = 0.0;
			int num = SunCalculations.SunRiseSet(P_0, P_1, P_2, P_3, P_4, -12.0, upperLimb: false, ref trise, ref tset);
			while (true)
			{
				IL_0068:
				int num2 = 4;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = ⴄႤ[135];
						continue;
					case 2:
					case 5:
						break;
					case 0:
						goto IL_0068;
					case 4:
					{
						string result = Ⴍ(num, trise, tset, P_5);
						ShowWwvOptionsHelp.ႣႥ[166] = (char)((ShowWwvOptionsHelp.ႣႥ[166] ^ SetTalkCountHelp.Ⴅ[374]) & 0xB7);
						return result;
					}
					}
					break;
				}
				break;
			}
		}
	}

	private static string Ⴓ(int P_0, int P_1, int P_2, double P_3, double P_4, ArcConnect P_5)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		while (true)
		{
			double trise = 0.0;
			double tset = 0.0;
			int num = SunCalculations.SunRiseSet(P_0, P_1, P_2, P_3, P_4, -18.0, upperLimb: false, ref trise, ref tset);
			while (true)
			{
				IL_0061:
				int num2 = ⴀႨ[193] - 56086;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = 3;
						continue;
					case 3:
						break;
					case 0:
					case 2:
						goto IL_0061;
					case 4:
					{
						string result = Ⴍ(num, trise, tset, P_5);
						AnnCacheCfg.ႠႼ[55] = (byte)((AnnCacheCfg.ႠႼ[55] * P_1) & 0x32);
						return result;
					}
					}
					break;
				}
				break;
			}
		}
	}

	private static string Ⴍ(int P_0, double P_1, double P_2, ArcConnect P_3)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num4 = default(int);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		object obj = default(object);
		while (true)
		{
			int num = ((P_0 != 1) ? 15 : 9);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႤ[440] - ⴄႤ[109];
					continue;
				case 8:
					break;
				case 9:
					return ShowSkimCtyHelp.Ⴍ(1216133032, 2, 'â');
				case 15:
					num = ((P_0 != -1) ? (ⴍႭ[374] - 54478) : 11);
					continue;
				case 11:
					return ႰႥ.Ⴅ(8, 'ù', 952621784);
				case 12:
				case 14:
					num = ((!(P_1 < 0.0)) ? (ⴄႷ[44] - 49661) : 18);
					continue;
				case 18:
					P_1 += 24.0;
					num = ⴄႷ[118] - 56556;
					continue;
				case 6:
				case 7:
					num = ((!(P_2 < 0.0)) ? (ⴀႼ[8] - 199) : 4);
					continue;
				case 4:
					P_2 += 24.0;
					num = 2;
					continue;
				case 2:
					num = ((!(P_1 > 24.0)) ? 16 : (ⴃႥ[231] - 57227));
					continue;
				case 17:
					P_1 -= 24.0;
					num = 16;
					continue;
				case 16:
					num = ((P_2 > 24.0) ? 1 : 0);
					continue;
				case 1:
					P_2 -= 24.0;
					num = ⴃႥ[379] - 3035;
					continue;
				case 0:
					num4 = (int)P_1;
					goto case 5;
				case 5:
				{
					string text3 = SetStationBuddyList.Ⴓ(ref num4, SetStationClubHelp.Ⴍ(1, 7, 1747263101, null), 'ǂ', 384);
					string text4 = ShowSkimCtyHelp.Ⴍ(1216134123, 0, 'ã');
					int num5 = ShowSkimmerHelp.Ⴅ((int)((P_1 - (double)(int)P_1) * 60.0), 572, 'Ȃ');
					enumerable = qslinfoResponse.Ⴗ(text3, text4, SetStationBuddyList.Ⴓ(ref num5, SetStationClubHelp.Ⴍ(8, 8, 1747263090, null), 'ʘ', 730), ႨႨ.Ⴀ(1, 0, 1157903725), 562, 'ɑ');
					num = ⴐ[293] - 87;
					continue;
				}
				case 10:
				{
					int num2 = (int)P_2;
					string text = SetStationBuddyList.Ⴓ(ref num2, SetStationClubHelp.Ⴍ(P_0, 5, 1747263103, null), '\u0089', 203);
					string text2 = ShowSkimCtyHelp.Ⴍ(1216134122, 1, 'u');
					int num3 = ShowSkimmerHelp.Ⴅ((int)((P_2 - (double)(int)P_2) * 60.0), 538, 'Ȥ');
					obj = text + text2 + SetStationBuddyList.Ⴓ(ref num3, SetStationClubHelp.Ⴍ(8, 4, 1747263102, null), '^', 28) + ႨႨ.Ⴀ(3, 8, 1157903717);
					num = 3;
					continue;
				}
				case 3:
					return ႨႨ.Ⴀ(0, 8, 1157902558) + (string)enumerable + CallBlockCacheCfg.Ⴅ(null, 7, 62062066, null) + (string)obj;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DataSet
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 9;
				break;
			case 9:
				num = (((P_1 ^ P_2) - 43) ^ num2) switch
				{
					0 => 2, 
					_ => 4, 
				};
				break;
			case 4:
			case 7:
				num = 0;
				break;
			case 2:
				P_0.Clear();
				goto case 0;
			case 0:
			case 3:
				num2++;
				goto case 5;
			case 5:
			{
				int num3 = 77;
				int num4 = 751;
				num = ((1502 <= num4 - num3 * 2) ? 1 : (ⴀႳ[299] - 13490));
				break;
			}
			case 1:
				num = 9;
				break;
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : ArcLogInRqst
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[27] - ⴅ[80];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႠ[85] - 16998;
					continue;
				case 5:
					break;
				case 8:
				{
					int num5 = P_2 ^ P_1;
					BandModeCacheCfg.ႠႳ[174] = (char)((BandModeCacheCfg.ႠႳ[174] | P_1) & 0x4F);
					num2 = ((num5 - 74) ^ num) switch
					{
						0 => ⴀ[197] - 6390, 
						_ => ⴄႷ[58] - 48427, 
					};
					continue;
				}
				case 2:
					equatable = null;
					num2 = ⴃႠ[213] - ⴃႠ[213];
					continue;
				case 3:
				case 4:
					equatable = P_0.SerializeNode();
					num2 = 0;
					continue;
				case 0:
				{
					num++;
					int num3 = 128;
					int num4 = 7;
					num2 = ((32 < num3 / 4 - num4) ? 8 : 9);
					continue;
				}
				case 7:
				case 9:
				case 10:
					return equatable as string;
				case 1:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴜ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : BinaryReader
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				default:
				{
					/*OpCode not supported: LdMemberToken*/;
					char num5 = ⴀႳ[204];
					ShowWwvOptionsHelp.ႣႥ[208] = (char)((ShowWwvOptionsHelp.ႣႥ[208] - P_1) & 0x43);
					num2 = num5 - 27646;
					continue;
				}
				case 6:
					break;
				case 4:
					num2 = (((P_2 ^ P_1) - 78) ^ num) switch
					{
						0 => ⴀႼ[80], 
						_ => 2, 
					};
					continue;
				case 2:
					convertible = null;
					num2 = 3;
					continue;
				case 0:
				case 1:
					convertible = P_0.ReadString();
					num2 = 3;
					continue;
				case 3:
				{
					num++;
					int num3 = 1964;
					int num4 = 628;
					num2 = ((982 < num3 / 2 - num4) ? (ⴀႳ[120] - 50675) : (ⴀႣ[50] - 11221));
					continue;
				}
				case 5:
				case 7:
				case 10:
					return convertible as string;
				case 8:
					num2 = ⴀႨ[181] - 3888;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ICredentials ႰႷ(char P_0, int P_1)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႳ[139] - 4372;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 2:
				case 7:
					break;
				case 4:
					num2 = (((P_1 ^ P_0) - 83) ^ num) switch
					{
						0 => 0, 
						_ => 6, 
					};
					continue;
				case 6:
					obj = null;
					goto case 1;
				case 1:
					num2 = 10;
					continue;
				case 0:
					obj = CredentialCache.DefaultCredentials;
					num2 = 10;
					continue;
				case 10:
					num++;
					num3 = P_0 * P_0;
					num3 = P_0 + num3;
					goto case 3;
				case 3:
					num2 = ⴍႭ[65] - 54282;
					continue;
				case 8:
					num2 = ((num3 % 2 != 0) ? 4 : 9);
					continue;
				case 9:
					return obj as ICredentials;
				case 11:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႰႰ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : string where _0021_00211 : CallbookData
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴅ[6] * 8;
				break;
			case 0:
				num = (((P_3 ^ P_2) - 106) ^ num2) switch
				{
					0 => 4, 
					_ => ⴐ[36] - 175, 
				};
				break;
			case 9:
				num = 1;
				break;
			case 4:
				P_0.LastName = P_1;
				goto case 1;
			case 1:
			case 5:
			{
				num2++;
				int num3 = 1745;
				num = (((num3 * num3 + num3) % 2 == 0) ? 7 : ⴀႼ[113]);
				break;
			}
			case 2:
				num = ⴃႥ[216] - 63051;
				break;
			case 7:
			case 8:
				return;
			}
		}
	}
}
