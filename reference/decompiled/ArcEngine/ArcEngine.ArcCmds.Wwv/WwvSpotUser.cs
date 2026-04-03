using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
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
using ArcEngine.ArcIo.ReverseBeacon;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using Meebey.SmartIrc4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Wwv;

public class WwvSpotUser : WwvSpotBase, IArcCmd
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴓ
	{
		internal string Ⴈ;

		internal int Ⴓ;

		internal string Ⴗ;

		internal string Ⴄ;

		internal bool Ⴃ;

		internal HamQthCfg Ⴐ;
	}

	private static void Ⴄ(NodeUserCmd P_0)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(0, 8, 1157905173), P_0.Rx.Msg, 893, 819));
				break;
			case 4:
				break;
			case 2:
			{
				object obj = new WwvSpotUserHelp();
				(obj as WwvSpotUserHelp).Exec(P_0);
				SetAnnMode.ႤႭ[99] = (byte)((SetAnnMode.ႤႭ[99] ^ SetAnnChatRooms.Ⴀ[452]) & 0x13);
				return;
			}
			case 0:
			case 1:
				return;
			}
			num = ⴄႷ[87] - 25171;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		try
		{
			int num = 11;
			IEnumerable msgEnd = default(IEnumerable);
			object obj4 = default(object);
			IEnumerable enumerable = default(IEnumerable);
			object obj2 = default(object);
			object obj3 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length <= 1) ? (ⴅ[383] / 6) : 16);
					continue;
				case 16:
					msgEnd = cmd.Rx.GetMsgEnd(1);
					ShowHamHelp.Ⴃ(Wwv, Ⴐ((string)msgEnd, SetStationQth.Ⴍ(null, 1687354565, 8, 4)), 'ȟ', 568);
					num = ⴅ[242] - 243;
					continue;
				case 1:
					SetStationHereHelp.Ⴀ(Wwv, Ⴐ(msgEnd as string, CallBlockCacheCfg.Ⴅ(null, 6, 62057839, null)), 983, 'Δ');
					num = 0;
					continue;
				case 0:
					ShowQslInfoHelp.Ⴍ(Wwv, Ⴐ((string)msgEnd, ReplyMailHelp.Ⴄ(7, null, 1057162202, 1)), 383, 287);
					goto case 12;
				case 12:
					num = 3;
					continue;
				case 3:
				case 8:
				{
					string obj5 = (string)msgEnd;
					Array array = new char[1];
					((char[])array)[0] = ',';
					obj4 = Directory.Ⴓ(obj5, (char[])array, 951, 993);
					num = 10;
					continue;
				}
				case 10:
					num = ((((string[])obj4).Length <= 3) ? 9 : 17);
					continue;
				case 17:
					ႰႥ.Ⴐ(Wwv, SetDxFilter.Ⴀ((obj4 as string[])[3], 953, 'Ϲ'), 802, '\u0308');
					goto case 9;
				case 9:
					SetStationHereHelp.Ⴀ(Wwv, cmd.Ⴍ().Call, 269, 'ŉ');
					ႰႥ.Ⴐ(Wwv, cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call, 679, 'ʌ');
						num = 14;
						continue;
					case 14:
					{
						DateTime dateTime2 = ShowAnnHelp.Ⴅ('ϙ', 1000);
						enumerable = ShowAnnOptionsHelp.Ⴗ(ref dateTime2, CallBlockCacheCfg.Ⴅ(null, 8, 62057707, null), 416, 420);
						num = 2;
						continue;
					}
					case 2:
					{
						DateTime dateTime = ShowAnnHelp.Ⴅ('"', 19);
						obj2 = Ⴀ(ShowAnnOptionsHelp.Ⴗ(ref dateTime, SetStationClubHelp.Ⴍ(11, 0, 1747257883, null), 874, 878));
						num = 6;
						continue;
					}
					case 6:
						obj3 = new CultureInfo(SetTalkCount.Ⴗ(1, null, 1267022538, typeof(RevBcnSpotProcessor)), useUserOverride: true);
						num = ⴐ[367];
						continue;
					case 4:
						Wwv.Dts = DateTime.Parse((string)enumerable + SetTalkCount.Ⴗ(6, null, 1267022533, typeof(SkimmerServerData)) + (obj2 as string) + SetStationClubHelp.Ⴍ(5, 8, 1747257862, null), (IFormatProvider)obj3);
						num = 7;
						continue;
					case 7:
					{
						ProcessSpot(cmd);
						object obj = new Publisher();
						(obj as Publisher).Process(cmd);
						num = 5;
						continue;
					}
					case 15:
						Ⴄ(cmd);
						break;
					case 5:
					case 13:
						break;
					}
					break;
				}
			}
			catch (Exception)
			{
				Ⴄ(cmd);
			}
			switch (4)
			{
			}
		}

		private static string Ⴐ(string P_0, string P_1)
		{
			byte[] ⴐ = ႨႣ.Ⴐ;
			char[] ⴀ = SetAnnChatRooms.Ⴀ;
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			while (true)
			{
				IEnumerable<char> enumerable = string.Empty;
				P_0 = SetDxFilter.Ⴀ(P_0, 808, '\u0369');
				int num = ShowNodes.Ⴄ(P_0, P_1, 511, 448);
				while (true)
				{
					IL_0086:
					int num2 = ⴀ[218] - 62884;
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							num2 = ⴐ[257];
							continue;
						case 7:
							break;
						case 4:
							goto IL_0086;
						case 2:
						case 6:
							num += CallBlockCacheCfg.Ⴜ(P_1, 295, 326) + 1;
							num2 = 1;
							continue;
						case 5:
							enumerable = ShowUsersHelp.Ⴅ(enumerable as string, SetTalkOutputHelp.Ⴍ(P_0, num, 1, 1017, 938), 742, 680);
							num2 = ⴃႠ[288] - 10232;
							continue;
						case 9:
							num++;
							num2 = 1;
							continue;
						case 1:
							num2 = ((num >= P_0.Length) ? 10 : 8);
							continue;
						case 0:
						case 8:
							num2 = ((P_0.Substring(num, 1) != ShowWxHelp.Ⴍ('\u0094', 985808778, 7)) ? 5 : 10);
							continue;
						case 10:
							return enumerable as string;
						}
						break;
					}
					break;
				}
			}
		}

		private static string Ⴀ(string P_0)
		{
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			char[] ⴀ = SetAnnChatRooms.Ⴀ;
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			int num2 = default(int);
			while (true)
			{
				int num = ((!SkimmerValidSpot.Ⴈ(P_0, 190, 202)) ? 21 : 29);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 6;
						continue;
					case 6:
						break;
					case 29:
						num2 = ShowVersion.Ⴄ(P_0, 'ɛ', 'ɩ');
						num = ((num2 < 0) ? 25 : 27);
						continue;
					case 27:
						num = ((num2 >= 3) ? 25 : (ⴀႣ[390] - 24704));
						continue;
					case 7:
					case 15:
					case 23:
						return SetStationClubHelp.Ⴍ(8, 1, 1747263099, null);
					case 25:
						num = ((num2 < 3) ? (ⴄႭ[31] / 2) : (ⴄႷ[126] - 39162));
						continue;
					case 8:
						num = ((num2 >= 6) ? 5 : 4);
						continue;
					case 4:
						return SetTalkCount.Ⴗ(3, null, 1267016666, typeof(ShowDateTimeHelp));
					case 5:
						num = ((num2 < 6) ? 26 : (ⴀ[282] - 54203));
						continue;
					case 3:
						num = ((num2 >= 9) ? (ⴍႤ[152] - 62661) : 16);
						continue;
					case 16:
						return ReplyMail.Ⴅ(1, 5, 1217941908);
					case 26:
						num = ((num2 < 9) ? 10 : 28);
						continue;
					case 28:
						num = ((num2 >= 12) ? 10 : 13);
						continue;
					case 13:
						return ShowSkimCtyHelp.Ⴍ(1216132689, 7, 'ä');
					case 10:
						num = ((num2 < 12) ? 14 : 18);
						continue;
					case 18:
						num = ((num2 >= 15) ? (ⴄႷ[128] - 3822) : 24);
						continue;
					case 24:
						return ReplyMailHelp.Ⴄ(5, null, 1057164054, 4);
					case 14:
						num = ((num2 >= 15) ? 2 : 0);
						continue;
					case 2:
						num = ((num2 < 18) ? (ⴀႣ[390] - 24700) : 0);
						continue;
					case 19:
						return SetTalkCount.Ⴗ(7, null, 1267021670, typeof(DeleteMailHelp));
					case 0:
						num = ((num2 < 18) ? (ⴃႥ[267] - 5572) : (ⴃႥ[37] - 10705));
						continue;
					case 17:
						num = ((num2 >= 21) ? 1 : 20);
						continue;
					case 20:
					case 22:
						return ShowWxHelp.Ⴍ('\u0087', 985806034, 2);
					case 1:
						num = ((num2 < 21) ? 30 : 11);
						continue;
					case 11:
						num = ((num2 >= 24) ? 30 : 12);
						continue;
					case 12:
						return ReplyMail.Ⴅ(4, 0, 1217941910);
					case 30:
						return P_0;
					case 21:
						return P_0;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static string Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : WwvSpot
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			byte[] ⴅ = SetTalkCountHelp.Ⴅ;
			char[] ⴃႰ = SetWxOutput.ႣႰ;
			object obj = default(object);
			int num3 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 4;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = ⴄႷ[38] - 46341;
						continue;
					case 8:
						break;
					case 4:
						num2 = (((P_2 ^ P_1) - 17) ^ num) switch
						{
							0 => ⴃႥ[294] - 39532, 
							_ => 5, 
						};
						continue;
					case 2:
					case 5:
					case 7:
						obj = null;
						num2 = ⴅ[172] / 8;
						continue;
					case 6:
						obj = P_0.K;
						num2 = 9;
						continue;
					case 9:
						num++;
						num3 = 64;
						num4 = 147;
						goto case 1;
					case 1:
						num2 = ((294 > num4 - num3 * 2) ? 11 : 0);
						continue;
					case 0:
						num2 = ⴃႰ[85] - 51301;
						continue;
					case 11:
						return obj as string;
					case 10:
						num2 = 4;
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, ModeType P_1, short P_2, char P_3) where _0021_00210 : WxCfg
		{
			char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			int num = 4;
			int num3 = default(int);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					num3 = 0;
					num = ⴍႭ[336] - 32783;
					break;
				case 1:
					num = (((P_2 ^ P_3) - 18) ^ num3) switch
					{
						0 => 0, 
						_ => 5, 
					};
					break;
				case 5:
					num = 2;
					break;
				case 0:
					P_0.Mode = P_1;
					goto case 2;
				case 2:
				case 9:
					num3++;
					num2 = P_3 * P_3;
					num2 = P_3 + num2;
					num = ⴄႭ[134];
					break;
				case 8:
					num = ((num2 % 2 != 0) ? 1 : 7);
					break;
				case 3:
				case 7:
					return;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3, int P_4) where _0021_00210 : IrcConnection where _0021_00211 : string
		{
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			int num = 4;
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					num2 = 0;
					num = 6;
					continue;
				case 6:
					num = (((P_4 ^ P_3) - 17) ^ num2) switch
					{
						0 => ⴍႤ[391] - 44948, 
						_ => 7, 
					};
					continue;
				case 7:
					num = ⴍႤ[90] - 8258;
					continue;
				case 5:
					P_0.Connect(P_1, P_2);
					goto case 2;
				case 2:
					num2++;
					break;
				case 0:
				case 8:
					break;
				case 3:
					return;
				}
				int num3 = 40;
				int num4 = 19;
				num = ((20 < num3 / 2 - num4) ? 6 : 3);
			}
		}
	}
