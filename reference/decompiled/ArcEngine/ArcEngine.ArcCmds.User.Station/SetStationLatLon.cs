using System;
using System.Collections.Generic;
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
using ArcEngine.ArcIo.ReverseBeacon;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationLatLon : IArcCmd
{
	private static void Ⴄ(NodeUserCmd P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(13, 2, 1157899266), P_0.Rx.Msg, 171, 229));
				break;
			case 0:
			case 3:
				break;
			case 4:
			{
				IArcCmd arcCmd = new SetStationLatLonHelp();
				(arcCmd as SetStationLatLonHelp).Exec(P_0);
				object obj = new Publisher();
				(obj as Publisher).Process(P_0);
				return;
			}
			case 1:
				return;
			}
			num = ⴄႤ[350] - 75;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		try
		{
			int num = 16;
			IComparable<string> comparable = default(IComparable<string>);
			Array array = default(Array);
			object obj = default(object);
			int num4 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = ((cmd.Rx.Split.Length <= 3) ? 12 : (ⴃႠ[183] - 24328));
					continue;
				case 8:
					comparable = SetDxFilter.Ⴀ(cmd.Rx.GetMsgEnd(3), 230, '§');
					comparable = ShowContestStationHelp.Ⴅ((string)comparable, CallBlockCacheCfg.Ⴅ(null, 1, 62058418, null), SetTalkCount.Ⴗ(1, null, 1267022530, typeof(ShowHeading)), 751, 'ʷ');
					num = 21;
					continue;
				case 21:
					comparable = ShowContestStationHelp.Ⴅ(comparable as string, CallBlockCacheCfg.Ⴅ(null, 1, 62058418, null), SetTalkCount.Ⴗ(5, null, 1267022534, typeof(RevBcnSpot)), 1006, 'ζ');
					num = ⴀႨ[42] - 24444;
					continue;
				case 10:
				{
					string obj2 = comparable as string;
					Array array2 = new char[1];
					((char[])array2)[0] = ' ';
					array = Directory.Ⴓ(obj2, array2 as char[], 454, 400);
					num = ⴄႤ[139];
					continue;
				}
				case 14:
					obj = new Publisher();
					goto case 0;
				case 0:
				{
					num4 = (array as string[]).Length;
					int num5 = num4;
					IpLockoutCacheCfg.ႭႭ[161] = (char)((IpLockoutCacheCfg.ႭႭ[161] ^ IpLockoutCacheCfg.ႭႭ[40]) & 0x29);
					num = ((num5 == 2) ? 3 : (ⴀ[236] - 31142));
					continue;
				}
				case 22:
					num = ((num4 == 6) ? 5 : 13);
					continue;
				case 4:
				case 13:
					num = 23;
					continue;
				case 3:
					num = ((!ShowWwvHelp.Ⴗ(((string[])array)[0], 'ʝ', 697)) ? 7 : 2);
					continue;
				case 2:
					num = ((!ShowWwvHelp.Ⴗ((array as string[])[1], '\u008c', 168)) ? 7 : 19);
					continue;
				case 19:
					ShowQrz.Ⴈ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 400, 390), (float)SetStationBuddyList.Ⴈ((array as string[])[0], 'Õ', 244), 129, 151);
					num = ⴃႥ[278] - 35261;
					continue;
				case 15:
					ShowAnnHelp.Ⴐ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 926, 904), (float)SetStationBuddyList.Ⴈ(((string[])array)[1], 'T', 117), 'ơ', 462);
					num = 17;
					continue;
				case 17:
				{
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					List<string> msg = cmd.Tx.Msg;
					string text = ShowWxHelp.Ⴍ('\u008d', 985805890, 4);
					float num2 = ႰႰ.Ⴅ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 128, 150), 43, 'e');
					string text2 = ShowDxOptionsHelp.Ⴅ(ref num2, ShowSkimCtyHelp.Ⴍ(1216131783, 6, '¦'), 926, 'Μ');
					string text3 = ShowWxHelp.Ⴍ('4', 985805737, 3);
					float num3 = ByeHelp.Ⴅ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 789, 771), '\u032d', 876);
					msg.Add(qslinfoResponse.Ⴗ(text, text2, text3, ShowDxOptionsHelp.Ⴅ(ref num3, ShowSkimCtyHelp.Ⴍ(1216131780, 5, '\u0004'), 757, '\u02f7'), 490, 'Ɖ'));
					num = 11;
					continue;
				}
				case 11:
					((Publisher)obj).Process(cmd);
					num = ⴄႷ[49] - 17971;
					continue;
				case 7:
					Ⴄ(cmd);
					num = ⴀႼ[63] - 73;
					continue;
				case 5:
					cmd.Ⴍ().Cfg.Station.Lat = UtilsLatLon.LatLonStringToFloat(comparable as string, isLat: true);
					cmd.Ⴍ().Cfg.Station.Lon = UtilsLatLon.LatLonStringToFloat(comparable as string, isLat: false);
					num = 20;
					continue;
				case 20:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(23, null, 1057165992, 0) + (comparable as string));
					num = ⴄႤ[413] - 22;
					continue;
				case 9:
					(obj as Publisher).Process(cmd);
					num = 1;
					continue;
				case 23:
					Ⴄ(cmd);
					num = 1;
					continue;
				case 12:
					Ⴄ(cmd);
					break;
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴄ(cmd);
		}
		switch (2)
		{
		}
	}

	[SecuritySafeCritical]
	internal static float Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : CallbookData
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		float result = default(float);
		int num3 = default(int);
		int num4 = default(int);
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
					num2 = 2;
					continue;
				case 2:
					break;
				case 5:
					num2 = (((P_2 ^ P_1) - 116) ^ num) switch
					{
						0 => 10, 
						_ => ⴍႭ[151] - 43201, 
					};
					continue;
				case 6:
					result = 0.20955595f;
					num2 = ⴄႭ[613] - 16;
					continue;
				case 10:
					result = P_0.Lat;
					num2 = ⴍႭ[331] - 20130;
					continue;
				case 3:
					num++;
					goto case 4;
				case 4:
					num3 = 1308;
					goto case 8;
				case 8:
					num4 = 227;
					goto case 7;
				case 7:
					num2 = ((327 < num3 / 4 - num4) ? 5 : 0);
					continue;
				case 0:
					return result;
				case 1:
					num2 = ⴃႠ[157] - 60706;
					continue;
				}
				break;
			}
		}
	}
}
