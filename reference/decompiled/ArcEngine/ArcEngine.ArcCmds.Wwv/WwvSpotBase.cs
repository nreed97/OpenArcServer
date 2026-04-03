using System;
using System.Collections.Generic;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcServerConfig.Io;
using ArcEngine.QslInfo;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods;
using Common.Logging;
using Ⴈ;

namespace ArcEngine.ArcCmds.Wwv;

public class WwvSpotBase
{
	private static readonly ILog Ⴐ = NodeUserCmd.Ⴗ(SetStationClubHelp.Ⴍ(9, 1, 1747257885, null), 270, 355);

	protected readonly WwvSpot Wwv;

	public WwvSpotBase()
	{
		Wwv = new WwvSpot();
	}

	private void Ⴄ()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 7;
		while (true)
		{
			switch (num)
			{
			default:
				ShowHamHelp.Ⴃ(Wwv, DxCacheCfg.Ⴀ(ShowTalkOptionsHelp.Ⴅ(Wwv, 518, 'ȁ'), 5, 'ˏ', 671), '\u0379', 862);
				num = 0;
				break;
			case 0:
				SetStationHereHelp.Ⴀ(Wwv, DxCacheCfg.Ⴀ(SetStationEmail.Ⴍ(Wwv, 800, 848), 5, 'ɿ', 559), 155, 'Ø');
				num = 1;
				break;
			case 1:
				ShowQslInfoHelp.Ⴍ(Wwv, DxCacheCfg.Ⴀ(WwvSpotUser.Ⴈ(Wwv, 'Ɲ', 396), 5, 'ʨ', 760), 154, 250);
				num = ⴅ[47] - ⴅ[476];
				break;
			case 5:
			case 6:
				ႰႥ.Ⴐ(Wwv, DxCacheCfg.Ⴀ(ShowQslInfoHelp.Ⴃ(Wwv, 908, 950), 100, 'Ŋ', 282), 295, 'č');
				goto case 3;
			case 3:
				num = 2;
				break;
			case 2:
			case 8:
				Wwv.Spotter = UtilsString.ScrubLength(Wwv.Spotter, 12);
				Wwv.SpotterNode = UtilsString.ScrubLength(Wwv.SpotterNode, 12);
				num = 4;
				break;
			case 4:
				Wwv.Route = UtilsString.ScrubLength(Wwv.Route, 255);
				Wwv.DupeKey = Wwv.Dts.ToString(ShowSkimCtyHelp.Ⴍ(1216133545, 5, 'z'));
				return;
			}
		}
	}

	public bool ProcessSpot(NodeUserCmd cmd)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		while (true)
		{
			cmd.Tx.MsgType = MsgType.Wwv;
			int num = ((!Ⴍ(cmd)) ? 9 : 0);
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
				case 9:
					return false;
				case 0:
					Ⴄ();
					ShowHam.Ⴗ(Wwv, ShowPrefixCalls.Ⴃ((object)cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call, (object)'.', (object)ShowLogHelp.Ⴃ(Wwv, 'ͱ', 877), 'Ż', 337), 834, 780);
					num = 4;
					continue;
				case 4:
				{
					int num2;
					if (cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴍ()
						.AddSpot(Wwv))
					{
						num2 = 5;
					}
					else
					{
						byte num3 = ⴅ[193];
						byte num4 = ⴅ[266];
						SetDxCountHelp.ႭႤ[439] = (SetDxCountHelp.ႭႤ[439] + ShowQrzHelp.ႤႤ[356]) & 6;
						num2 = num3 - num4;
					}
					num = num2;
					continue;
				}
				case 5:
					Ⴃ(cmd, ShowSkimCtyHelp.Ⴍ(1216133565, 8, 'Z'));
					CallbookCfg.Ⴓ(Wwv, true, 917, 'Ϥ');
					num = 10;
					continue;
				case 10:
					return false;
				case 1:
				case 3:
				case 7:
				case 11:
					cmd.Tx.Msg.Add(Ⴃ());
					cmd.Tx.Pcxx = Ⴀ();
					num = ⴍႭ[266] - 51345;
					continue;
				case 6:
					cmd.Tx.NodeXml = WxFullHelp.Ⴐ(Wwv, 879, 782);
					cmd.Tx.ClientXml = Wwv.SerializeUser();
					num = ⴄႭ[134];
					continue;
				case 8:
					cmd.Tx.DistroType = DistroType.ToAll;
					return true;
				}
				break;
			}
		}
	}

	private void Ⴃ(NodeUserCmd P_0, string P_1)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				P_0.Ⴍ().Io.TenMinuteDxDupeCnt++;
				P_0.Tx.DistroType = DistroType.ToNil;
				return;
			case 1:
				return;
			}
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(P_1, Ⴃ(), 446, 496));
			num = 0;
		}
	}

	private string Ⴃ()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		Array array = default(Array);
		while (true)
		{
			string text = ShowSkimCtyHelp.Ⴍ(1216133196, 6, '³');
			string text2 = ႨႨ.Ⴃ(Wwv, 'ω', 927);
			string text3 = SetStationQth.Ⴍ(null, 1687351541, 1, 23);
			DateTime dateTime = IoDevicesCfg.Ⴍ(Wwv, 443, 505);
			IConvertible convertible = qslinfoResponse.Ⴗ(text, text2, text3, ShowAnnOptionsHelp.Ⴗ(ref dateTime, SetStationClubHelp.Ⴍ(12, 6, 1747257885, null), 958, 954), 153, 'ú');
			int num = ⴀႳ[214] - 17007;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 9;
					continue;
				case 6:
				case 9:
					break;
				case 2:
				{
					IComparable<string> comparable = (string)convertible;
					array = new string[9];
					((string[])array)[0] = comparable as string;
					num = 1;
					continue;
				}
				case 1:
					((string[])array)[1] = ႨႨ.Ⴀ(1, 1, 1157903498);
					(array as string[])[2] = ShowTalkOptionsHelp.Ⴅ(Wwv, 621, 'ɪ');
					num = 12;
					continue;
				case 0:
				case 12:
					((string[])array)[3] = SetTalkCount.Ⴗ(6, null, 1267022546, typeof(CallbookCfg));
					num = 7;
					continue;
				case 7:
					(array as string[])[4] = SetStationEmail.Ⴍ(Wwv, 317, 333);
					num = 10;
					continue;
				case 10:
					((string[])array)[5] = ReplyMailHelp.Ⴄ(22, null, 1057162159, 4);
					num = 11;
					continue;
				case 11:
					((string[])array)[6] = WwvSpotUser.Ⴈ(Wwv, 'ǘ', 457);
					num = ⴀ[34] - 50643;
					continue;
				case 5:
					(array as string[])[7] = CallBlockCacheCfg.Ⴅ(null, 5, 62057699, null);
					num = ⴐ[243];
					continue;
				case 8:
					(array as string[])[8] = Wwv.Forecast;
					goto case 13;
				case 13:
					convertible = string.Concat((string[])array);
					num = 3;
					continue;
				case 3:
					return (string)convertible;
				}
				break;
			}
		}
	}

	private string Ⴀ()
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		IConvertible convertible = default(IConvertible);
		Array array = default(Array);
		while (true)
		{
			object obj = new string[9];
			((string[])obj)[0] = ReplyMailHelp.Ⴄ(29, null, 1057162154, 8);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 11;
					continue;
				case 11:
					break;
				case 0:
				{
					string[] obj3 = obj as string[];
					DateTime dateTime2 = IoDevicesCfg.Ⴍ(Wwv, 436, 502);
					obj3[1] = ShowAnnOptionsHelp.Ⴗ(ref dateTime2, CallBlockCacheCfg.Ⴅ(null, 5, 62057702, null), 221, 217);
					num = 14;
					continue;
				}
				case 14:
					((string[])obj)[2] = SetStationQth.Ⴍ(null, 1687351529, 6, 30);
					num = ⴍႭ[191] - 25426;
					continue;
				case 7:
				{
					string[] obj2 = (string[])obj;
					DateTime dateTime = IoDevicesCfg.Ⴍ(Wwv, 604, 542);
					obj2[3] = ShowAnnOptionsHelp.Ⴗ(ref dateTime, SetStationClubHelp.Ⴍ(7, 0, 1747257883, null), 713, 717);
					num = ⴃႠ[30] - 58852;
					continue;
				}
				case 16:
					((string[])obj)[4] = SetStationQth.Ⴍ(null, 1687351527, 8, 15);
					num = ⴄႭ[312] / 8;
					continue;
				case 18:
					(obj as string[])[5] = ShowTalkOptionsHelp.Ⴅ(Wwv, 571, 'ȼ');
					num = 19;
					continue;
				case 19:
					((string[])obj)[6] = SetStationQth.Ⴍ(null, 1687351535, 0, 31);
					num = 13;
					continue;
				case 13:
					((string[])obj)[7] = SetStationEmail.Ⴍ(Wwv, 508, 396);
					num = 8;
					continue;
				case 5:
				case 8:
					(obj as string[])[8] = SetStationQth.Ⴍ(null, 1687351534, 1, 3);
					goto case 1;
				case 1:
					num = ⴃႠ[288] - 10224;
					continue;
				case 17:
				{
					IEnumerable<char> enumerable = ShowWwv.Ⴈ((string[])obj, 'ȶ', 606);
					convertible = enumerable as string;
					num = ⴍႭ[115] - 12337;
					continue;
				}
				case 21:
					array = new string[9];
					(array as string[])[0] = convertible as string;
					goto case 20;
				case 20:
					((string[])array)[1] = WwvSpotUser.Ⴈ(Wwv, 'O', 94);
					num = ⴍႤ[126] - 61697;
					continue;
				case 4:
					((string[])array)[2] = SetStationQth.Ⴍ(null, 1687351531, 4, 16);
					num = ⴐ[136] / 9;
					continue;
				case 2:
					(array as string[])[3] = ShowQslInfoHelp.Ⴃ(Wwv, 276, 302);
					num = ⴄႭ[568];
					continue;
				case 12:
					((string[])array)[4] = SetStationQth.Ⴍ(null, 1687351529, 6, 22);
					num = 15;
					continue;
				case 15:
					((string[])array)[5] = ႨႨ.Ⴃ(Wwv, '\u0096', 192);
					num = 6;
					continue;
				case 6:
					((string[])array)[6] = SetStationQth.Ⴍ(null, 1687351531, 4, 1);
					num = 10;
					continue;
				case 10:
					((string[])array)[7] = Wwv.SpotterNode;
					((string[])array)[8] = SetStationQth.Ⴍ(null, 1687351528, 3, 8);
					num = 3;
					continue;
				case 3:
				{
					IEnumerable<char> enumerable = string.Concat(array as string[]);
					return enumerable as string;
				}
				}
				break;
			}
		}
	}

	private bool Ⴍ(NodeUserCmd P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		while (true)
		{
			int num = (Ⴓ() ? 1 : ⴄႤ[139]);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 8;
					continue;
				case 8:
					break;
				case 1:
					Ⴃ(P_0, ႰႥ.Ⴅ(6, '\u0002', 952620179));
					return false;
				case 14:
					num = (Ⴀ(ShowTalkOptionsHelp.Ⴅ(Wwv, 196, 'Ã'), 0, 600) ? (ⴀႳ[27] - 42054) : ⴄႭ[66]);
					continue;
				case 0:
					Ⴃ(P_0, ShowSkimCtyHelp.Ⴍ(1216133207, 3, ']'));
					return false;
				case 5:
					num = (Ⴀ(SetStationEmail.Ⴍ(Wwv, 746, 666), 0, 300) ? (ⴄႷ[0] - 19551) : 6);
					continue;
				case 6:
				case 11:
					Ⴃ(P_0, ShowWxHelp.Ⴍ('\a', 985808664, 2));
					return false;
				case 7:
				case 12:
					num = (Ⴀ(WwvSpotUser.Ⴈ(Wwv, 'c', 114), 0, 50) ? (ⴄႷ[52] - 60813) : 13);
					continue;
				case 13:
					Ⴃ(P_0, CallBlockCacheCfg.Ⴅ(null, 5, 62057620, null));
					return false;
				case 9:
					num = ((!P_0.Ⴍ().Ⴅ().Ⴀ()
						.ႤႥ()
						.IsBlocked(ႨႨ.Ⴃ(Wwv, 'Ɯ', 458))) ? 10 : ⴐ[367]);
					continue;
				case 3:
				case 4:
					Ⴃ(P_0, SetStationQth.Ⴍ(null, 1687351527, 5, 3));
					return false;
				case 10:
					return true;
				}
				break;
			}
		}
	}

	private static bool Ⴀ(string P_0, int P_1, int P_2)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num2 = default(int);
		while (true)
		{
			int num = ((!SkimmerValidSpot.Ⴈ(P_0, 476, 424)) ? (ⴄႤ[47] / 4) : (ⴃႰ[190] - 47001));
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
				case 8:
					num2 = ShowVersion.Ⴄ(P_0, '\u031e', '\u032c');
					num = ((num2 < P_1) ? 7 : (ⴐ[382] - 134));
					continue;
				case 1:
				case 2:
					return num2 <= P_2;
				case 4:
				case 7:
					return false;
				case 3:
					return false;
				}
				break;
			}
		}
	}

	private bool Ⴓ()
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		while (true)
		{
			DateTime dateTime = IoDevicesCfg.Ⴍ(Wwv, 807, 869);
			TimeSpan timeSpan = DirectoryBulletinHelp.Ⴓ(ref dateTime, ShowAnnHelp.Ⴅ('\u02df', 750), 192, '÷');
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႷ[49] - 17967;
					continue;
				case 4:
				case 5:
					break;
				case 2:
					return Math.Abs(timeSpan.TotalMinutes) > 180.0;
				}
				break;
			}
		}
	}
}
