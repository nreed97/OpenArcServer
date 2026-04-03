using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Security;
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
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces;
using ArcShared;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class ShowStation : IArcCmd
{
	private static void Ⴃ(NodeUserCmd P_0)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 2:
			case 4:
			{
				object obj = new ShowStationHelp();
				((ShowStationHelp)obj).Exec(P_0);
				break;
			}
			case 0:
			case 1:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(14, 7, 1157906276), P_0.Rx.Msg, 872, 806));
			num = 4;
		}
		object obj2 = new Publisher();
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		try
		{
			int num = 12;
			object obj = default(object);
			BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = ((cmd.Rx.Split.Length != 2) ? (ⴀႨ[203] - 48781) : 10);
					continue;
				case 10:
					Ⴀ(cmd, cmd.Ⴍ());
					goto case 0;
				case 0:
					Ⴗ(cmd);
					num = ⴀႼ[128] - 31;
					continue;
				case 3:
					num = ((cmd.Rx.Split.Length != 3) ? (ⴀႼ[77] / 2) : (ⴃႥ[118] - 60958));
					continue;
				case 6:
					obj = SetDxFilter.Ⴀ(cmd.Rx.Split[2], 950, 'Ϸ');
					num = 9;
					continue;
				case 2:
				case 9:
					baseXmlSerializer = new ArcConnect(cmd.Ⴍ().Ⴅ(), obj as string);
					num = ((!ႷႷ.Ⴍ((string)obj, 862, '\u0353')) ? (ⴃႠ[271] - 23578) : 7);
					continue;
				case 7:
				case 13:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴀ((baseXmlSerializer as ArcConnect).Call)) ? ⴀႼ[136] : 8);
					continue;
				case 8:
					(baseXmlSerializer as ArcConnect).Cfg = cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴃ(baseXmlSerializer as ArcConnect);
					num = ⴄႭ[549] - 4;
					continue;
				case 1:
					Ⴀ(cmd, (ArcConnect)baseXmlSerializer);
					num = 11;
					continue;
				case 5:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetTalkCount.Ⴗ(4, null, 1267018046, typeof(SetTalkDefault)), (string)obj, 841, 775));
					break;
				case 11:
					break;
				}
				break;
			}
			cmd.Ⴀ();
			object obj2 = new Publisher();
			(obj2 as Publisher).Process(cmd);
		}
		catch (Exception)
		{
			Ⴃ(cmd);
		}
		switch (4)
		{
		}
	}

	private static void Ⴀ(NodeUserCmd P_0, ArcConnect P_1)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 8;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴗ(P_0.Ⴍ().Ⴅ(), P_1);
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetStationQth.Ⴍ(null, 1687353970, 3, 21), P_1.Call, 527, 577));
				num = ⴍႭ[325] - 18841;
				break;
			case 0:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowWxHelp.Ⴍ('Å', 985806606, 7), Bye.Ⴀ(ShowConnectsHelp.Ⴍ(P_1.Cfg, 552, 574), 561, 617), 994, 940));
				num = ⴀႼ[1] - 214;
				break;
			case 10:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216131645, 4, '\u0090'), ႷႷ.Ⴐ(ShowConnectsHelp.Ⴍ(P_1.Cfg, 409, 399), 394, 404), 930, 1004));
				num = 4;
				break;
			case 4:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႰႥ.Ⴅ(1, '<', 952622945), ႷႷ.Ⴐ(ShowConnectsHelp.Ⴍ(P_1.Cfg, 277, 259), 949, 938), 257, 335));
				num = 13;
				break;
			case 13:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ReplyMail.Ⴅ(6, 4, 1217943327), Bye.Ⴀ(ShowConnectsHelp.Ⴍ(P_1.Cfg, 877, 891), 320, 281), 319, 369));
				num = ⴃႥ[225] - 56853;
				break;
			case 1:
			case 6:
			{
				List<string> msg2 = P_0.Tx.Msg;
				string text2 = SetStationQth.Ⴍ(null, 1687353873, 4, 20);
				float num3 = ႰႰ.Ⴅ(ShowConnectsHelp.Ⴍ(P_1.Cfg, 862, 840), 469, 'ƛ');
				msg2.Add(ShowUsersHelp.Ⴅ(text2, ShowDxOptionsHelp.Ⴅ(ref num3, ShowSkimCtyHelp.Ⴍ(1216131782, 7, '\u00b4'), 420, 'Ʀ'), 290, 364));
				num = 12;
				break;
			}
			case 12:
			{
				List<string> msg = P_0.Tx.Msg;
				string text = ReplyMailHelp.Ⴄ(28, null, 1057165002, 8);
				float num2 = ByeHelp.Ⴅ(ShowConnectsHelp.Ⴍ(P_1.Cfg, 1008, 998), 'ñ', 176);
				msg.Add(ShowUsersHelp.Ⴅ(text, ShowDxOptionsHelp.Ⴅ(ref num2, ShowSkimCtyHelp.Ⴍ(1216131785, 8, '\0'), 489, 'ǫ'), 966, 904));
				num = 7;
				break;
			}
			case 7:
				P_0.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687353867, 3, 3) + UtilsLatLon.LatLonToMaidenHeadGrid(ႰႰ.Ⴅ(ShowConnectsHelp.Ⴍ(P_1.Cfg, 2, 20), 429, 'ǣ'), ByeHelp.Ⴅ(ShowConnectsHelp.Ⴍ(P_1.Cfg, 54, 32), 'έ', 1004)));
				num = 14;
				break;
			case 14:
				P_0.Tx.Msg.Add(ReplyMailHelp.Ⴄ(11, null, 1057165015, 7) + P_1.Cfg.Station.GridSq);
				num = ⴀႣ[263] - 56182;
				break;
			case 3:
				P_0.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 1, 62056350, null) + UtilsString.RemoveStartAndEndCommas(P_0.Ⴍ().Cfg.Dx.Needs.Cw));
				goto case 9;
			case 9:
			case 11:
				num = 5;
				break;
			case 5:
				P_0.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131787, 7, 'a') + UtilsString.RemoveStartAndEndCommas(P_0.Ⴍ().Cfg.Dx.Needs.Ssb));
				num = ⴃႰ[61] - 64134;
				break;
			case 2:
				P_0.Tx.Msg.Add(ႨႨ.Ⴀ(4, 0, 1157906185) + UtilsString.RemoveStartAndEndCommas(P_0.Ⴍ().Cfg.Dx.Needs.Rtty));
				return;
			}
		}
	}

	internal static void Ⴗ(ObjectManager P_0, ArcConnect P_1)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		try
		{
			int num = 9;
			object obj = default(object);
			IEnumerable enumerable = default(IEnumerable);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj = P_0.Ⴀ().ႤႷ().CtyInfoFromCall(P_1.Ⴀ());
					num = (((CtyInfo)obj == null) ? (ⴄႭ[565] - 192) : 4);
					continue;
				case 4:
				case 7:
					enumerable = qslinfoSoapClient.Ⴈ((CtyInfo)obj, '\b', 17);
					goto case 19;
				case 19:
				{
					bool num2 = ByeHelp.Ⴍ(enumerable as string, ReplyMailHelp.Ⴄ(25, null, 1057162195, 8), 381, 282);
					TxNodeUserCmd.ႤႷ[131] = (char)(TxNodeUserCmd.ႤႷ[131] & TxNodeUserCmd.ႤႷ[113] & 0x63);
					num = ((!num2) ? 3 : (ⴍႭ[169] - 60517));
					continue;
				}
				case 10:
					obj2 = P_0.Ⴀ().UsVeCallbook.Search(P_1.Ⴀ());
					num = ((!(obj2 is CallbookData)) ? 21 : 8);
					continue;
				case 8:
					num = ((!ႰႨ.ႥႥ(Bye.Ⴀ(ShowConnectsHelp.Ⴍ(P_1.Cfg, 108, 122), 196, 156), 'ɱ', 'ɗ')) ? 14 : (ⴀ[525] - 26790));
					continue;
				case 20:
					SetDxDefaultHelp.Ⴓ(ShowConnectsHelp.Ⴍ(P_1.Cfg, 492, 506), Top100CacheCfg.Ⴄ(obj2 as CallbookData, 530, 553), 166, 190);
					goto case 14;
				case 14:
					num = (ႰႨ.ႥႥ(ႷႷ.Ⴐ(ShowConnectsHelp.Ⴍ(P_1.Cfg, 977, 967), 523, 533), 'ð', 'Ö') ? (ⴀႣ[341] - 36651) : 0);
					continue;
				case 2:
					SetStationNeedsHelp.Ⴀ(ShowConnectsHelp.Ⴍ(P_1.Cfg, 692, 674), AnnHelp.Ⴈ(SetDxDefault.Ⴅ((CallbookData)obj2, 640, 753), CallBlockCacheCfg.Ⴅ(null, 6, 62057696, null), BadWordCacheCfg.Ⴅ((CallbookData)obj2, 503, 414), 934, 'Α'), 438, 488);
					goto case 0;
				case 0:
					num = ((ႰႰ.Ⴅ(ShowConnectsHelp.Ⴍ(P_1.Cfg, 195, 213), 1000, 'Φ') == 0f) ? 1 : (ⴄႷ[66] - 17237));
					continue;
				case 1:
					ShowConnectsHelp.Ⴍ(P_1.Cfg, 47, 57).Lat = SetStationLatLon.Ⴓ((CallbookData)obj2, 840, '\u033c');
					goto case 5;
				case 5:
					num = ((P_1.Cfg.Station.Lon != 0f) ? (ⴃႥ[243] - 40660) : 13);
					continue;
				case 13:
				case 16:
					P_1.Cfg.Station.Lon = ((CallbookData)obj2).Lon;
					goto case 11;
				case 11:
					num = ((!string.IsNullOrEmpty(P_1.Cfg.Station.GridSq)) ? 21 : (ⴅ[223] - ⴅ[50]));
					continue;
				case 15:
					P_1.Cfg.Station.GridSq = ((CallbookData)obj2).Grid;
					num = 21;
					continue;
				case 3:
					num = ((P_1.Cfg.Station.Lat != 0f) ? 6 : ⴄႤ[47]);
					continue;
				case 12:
					P_1.Cfg.Station.Lat = ((CtyInfo)obj).Latitude;
					goto case 6;
				case 6:
					num = ((P_1.Cfg.Station.Lon != 0f) ? (ⴃႠ[53] - 46715) : 18);
					continue;
				case 18:
					P_1.Cfg.Station.Lon = ((CtyInfo)obj).Longitude;
					break;
				case 17:
					break;
				case 21:
					return;
				}
				break;
			}
			P_1.Cty = (obj as CtyInfo).Cty;
		}
		catch (Exception)
		{
		}
	}

	private static void Ⴗ(NodeUserCmd P_0)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
			{
				bool num3 = ByeHelp.Ⴍ(P_0.Ⴍ().Here, ReplyMail.Ⴅ(2, 6, 1217944962), 55, 80);
				SetTalkCountHelp.Ⴅ[90] = (byte)(SetTalkCountHelp.Ⴅ[90] & SetTalkCountHelp.Ⴅ[4] & 0xFE);
				num = (num3 ? ⴀႼ[136] : 0);
				break;
			}
			case 5:
				P_0.Tx.Msg.Add(ReplyMail.Ⴅ(3, 3, 1217943312));
				goto case 9;
			case 9:
				num = ⴄႭ[94];
				break;
			case 0:
				P_0.Tx.Msg.Add(ႨႨ.Ⴀ(8, 0, 1157906200));
				goto case 2;
			case 2:
			case 7:
				num2 = 0;
				num = 8;
				break;
			case 1:
			{
				List<string> msg = P_0.Tx.Msg;
				object obj = new object[4];
				((object[])obj)[0] = ReplyMailHelp.Ⴄ(21, null, 1057165025, 8);
				(obj as object[])[1] = num2;
				((object[])obj)[2] = ShowWxHelp.Ⴍ('}', 985806709, 5);
				((object[])obj)[3] = ႷႷ.Ⴀ(ShowConnectsHelp.Ⴍ(P_0.Ⴍ().Cfg, 394, 412), 'ͷ', 877)[num2];
				msg.Add(SetDxDefaultHelp.Ⴍ((object[])obj, 'Ə', 486));
				num = 10;
				break;
			}
			case 10:
				num2++;
				num = ⴀႨ[125] - 14036;
				break;
			case 3:
			case 8:
				num = ((num2 < 10) ? 1 : (ⴄႷ[26] - 9164));
				break;
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static SqlCeParameterCollection Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : SqlCeCommand
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[136] / 2;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႣ[97] - 9497;
					continue;
				case 7:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 119) ^ num) switch
					{
						0 => 5, 
						_ => 2, 
					};
					continue;
				case 2:
					obj = null;
					num2 = 0;
					continue;
				case 4:
				case 5:
					obj = P_0.Parameters;
					num2 = ⴀႣ[133] - ⴀႣ[133];
					continue;
				case 0:
					num++;
					num3 = 536;
					num4 = 621;
					goto case 11;
				case 11:
				{
					int num5 = num4;
					int num6 = num3;
					SetAnnMode.ႤႭ[23] = (byte)((SetAnnMode.ႤႭ[23] | P_2) & 0x3F);
					num2 = ((3726 > num5 - num6 * 6) ? 6 : 8);
					continue;
				}
				case 8:
					num2 = 9;
					continue;
				case 3:
				case 6:
					return obj as SqlCeParameterCollection;
				case 1:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴐ(ref DateTime P_0, short P_1, short P_2)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႤ[399] - 48105;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
					break;
				case 4:
					num2 = (((P_2 ^ P_1) - 59) ^ num) switch
					{
						0 => 2, 
						_ => 7, 
					};
					continue;
				case 7:
					enumerable = null;
					num2 = ⴃႰ[110] - 21217;
					continue;
				case 2:
					enumerable = P_0.ToShortDateString();
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴍႤ[408] - 25579;
					continue;
				case 6:
					num2 = ((num3 % 2 != 0) ? (ⴍႭ[320] - 30605) : (ⴀႼ[2] / 6));
					continue;
				case 3:
				case 9:
				{
					string result = enumerable as string;
					BandModeCacheCfg.ႠႳ[137] = (char)((BandModeCacheCfg.ႠႳ[137] ^ ShowQrzHelp.ႤႤ[325]) & 0x8A);
					return result;
				}
				case 1:
				case 11:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}
}
