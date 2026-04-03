using System;
using System.Collections.Generic;
using System.Net;
using System.Xml;
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
using ArcEngine.ArcServerConfig.Caches;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public class ShowHamQth : IArcCmd
{
	private static readonly ILog Ⴀ = SkimmerValidSpot.Ⴐ(ႰႥ.Ⴅ(7, '¹', 952619943), 624, 621);

	public void Exec(NodeUserCmd cmd)
	{
		try
		{
			int num = 7;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 3) ? 4 : 6);
					continue;
				case 6:
					cmd.Tx.DistroType = DistroType.ToRequester;
					Ⴓ(cmd);
					goto case 1;
				case 1:
				case 3:
					cmd.Ⴀ();
					goto case 0;
				case 0:
					obj = new Publisher();
					num = 8;
					continue;
				case 8:
					(obj as Publisher).Process(cmd);
					num = 2;
					continue;
				case 4:
					Ⴅ(cmd);
					break;
				case 2:
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

	private static void Ⴅ(NodeUserCmd P_0)
	{
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowWxHelp.Ⴍ('ó', 985806409, 2), P_0.Rx.Msg, 543, 593));
				goto IL_0056;
			case 3:
				goto IL_0056;
			case 1:
				obj = new ShowHamQthHelp();
				break;
			case 0:
				break;
			}
			break;
			IL_0056:
			num = 1;
		}
		(obj as ShowHamQthHelp).Exec(P_0);
		object obj2 = new Publisher();
		((Publisher)obj2).Process(P_0);
	}

	private void Ⴓ(NodeUserCmd P_0)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		IEquatable<string> equatable = P_0.Rx.Split[2];
		try
		{
			int num = 0;
			object obj2 = default(object);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = Ⴄ(P_0.Ⴍ().Ⴅ());
					num = (ႰႨ.ႥႥ((string)obj2, 'ǰ', 'ǖ') ? ⴀႼ[136] : (ⴄႷ[141] - 32627));
					break;
				case 3:
				case 4:
				case 7:
					obj = Ⴄ(P_0, (string)equatable, (string)obj2);
					goto case 2;
				case 2:
					num = (((HamQthDotComLookup)obj != null) ? 1 : 6);
					break;
				case 1:
					Ⴅ(P_0, obj as HamQthDotComLookup);
					num = ⴄႷ[58] - 48423;
					break;
				case 5:
					Ⴀ.Error(SetStationQth.Ⴍ(null, 1687354338, 3, 25));
					P_0.Tx.Msg.Add(ႨႨ.Ⴀ(11, 4, 1157905121));
					return;
				case 6:
					return;
				}
			}
		}
		catch (Exception ex)
		{
			Ⴀ.Error(SkimmerSpotBins.Ⴈ(ex as Exception, 599, 633));
			P_0.Tx.Msg.Add(ႨႨ.Ⴀ(13, 6, 1157905123));
		}
	}

	private void Ⴅ(NodeUserCmd P_0, HamQthDotComLookup P_1)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 19;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216132297, 4, '}'), P_1.Ⴍ(), 796, 850));
				num = ⴐ[238] - 180;
				break;
			case 13:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႰႥ.Ⴅ(3, 'µ', 952621485), P_1.Ⴀ(), 790, 856));
				num = 14;
				break;
			case 14:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ReplyMail.Ⴅ(7, 12, 1217941529), P_1.Ⴓ(), 130, 204));
				num = ⴀႳ[22] - 54432;
				break;
			case 22:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetStationQth.Ⴍ(null, 1687354252, 0, 5), P_1.Ⴅ(), 417, 495));
				num = 20;
				break;
			case 20:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowWxHelp.Ⴍ('(', 985806224, 2), P_1.Ⴐ(), 295, 361));
				num = 4;
				break;
			case 4:
			case 11:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216132229, 5, '\t'), P_1.Ⴗ(), 823, 889));
				num = 8;
				break;
			case 8:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႰႥ.Ⴅ(2, ':', 952621496), P_1.Ⴈ(), 881, 831));
				num = 2;
				break;
			case 2:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ReplyMail.Ⴅ(7, 7, 1217941526), P_1.Ⴄ(), 1023, 945));
				goto case 7;
			case 7:
				num = 18;
				break;
			case 18:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetStationQth.Ⴍ(null, 1687354303, 2, 10), P_1.Ⴜ(), 434, 508));
				num = 5;
				break;
			case 5:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowWxHelp.Ⴍ('\u0080', 985806215, 6), P_1.ႠႭ(), 3, 77));
				num = ⴄႷ[113] - 58450;
				break;
			case 21:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216132232, 7, 'é'), P_1.ႠႠ(), 401, 479));
				num = ⴀ[338] - 25683;
				break;
			case 17:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႰႥ.Ⴅ(6, '£', 952621376), P_1.ႠႥ(), 444, 498));
				goto case 23;
			case 23:
				num = 3;
				break;
			case 3:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ReplyMail.Ⴅ(1, 4, 1217941564), P_1.ႠႣ(), 654, 704));
				num = 16;
				break;
			case 16:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetStationQth.Ⴍ(null, 1687354280, 1, 10), P_1.ႠႰ(), 436, 506));
				num = ⴀ[242] - 62357;
				break;
			case 15:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowWxHelp.Ⴍ('+', 985806325, 3), P_1.ႠႷ(), 500, 442));
				num = 10;
				break;
			case 10:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216132256, 6, 'U'), P_1.ႠႨ(), 239, 161));
				num = 0;
				break;
			case 0:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႰႥ.Ⴅ(2, '`', 952621396), P_1.ႠႤ(), 592, 542));
				num = ⴍႭ[105] - 23844;
				break;
			case 9:
				P_0.Tx.Msg.Add(ReplyMail.Ⴅ(2, 5, 1217941548) + P_1.ႠႼ());
				num = 1;
				break;
			case 1:
				P_0.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687354457, 4, 26) + P_1.ႳႭ());
				num = ⴄႤ[332] - 180;
				break;
			case 6:
				P_0.Tx.Msg.Add(ShowWxHelp.Ⴍ('\u001c', 985806315, 8) + P_1.ႳႠ());
				num = 12;
				break;
			case 12:
				P_0.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132274, 0, 'Y') + P_1.ႳႳ());
				return;
			}
		}
	}

	private HamQthDotComLookup Ⴄ(NodeUserCmd P_0, string P_1, string P_2)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		_ = string.Empty;
		object obj = null;
		try
		{
			int num = 3;
			object obj2 = default(object);
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = new WebClient();
					goto IL_005f;
				case 1:
					goto IL_005f;
				case 0:
				case 5:
					obj = new HamQthDotComLookup();
					break;
				case 2:
					break;
				}
				break;
				IL_005f:
				WebClient obj3 = obj2 as WebClient;
				Array array = new string[6];
				((string[])array)[0] = P_0.Ⴍ().Ⴅ().Ⴍ()
					.Configuration.HamQth.Url;
				((string[])array)[1] = ReplyMailHelp.Ⴄ(4, null, 1057164502, 6);
				(array as string[])[2] = P_2;
				((string[])array)[3] = SetStationClubHelp.Ⴍ(1, 0, 1747263179, null);
				(array as string[])[4] = P_1;
				((string[])array)[5] = SetTalkCount.Ⴗ(6, null, 1267018901, typeof(ShowWwv));
				enumerable = SetStationGrid.Ⴀ(obj3, ShowWwv.Ⴈ(array as string[], 'ʋ', 739), 'ɡ', 622);
				num = ⴅ[135] - 202;
			}
			(obj as HamQthDotComLookup).Deserialize(enumerable as string);
		}
		catch (Exception ex)
		{
			Ⴀ.Error(SkimmerSpotBins.Ⴈ(ex as Exception, 726, 760));
			P_0.Tx.Msg.Add(ႨႨ.Ⴀ(15, 1, 1157905124));
		}
		return 0 switch
		{
			_ => obj as HamQthDotComLookup, 
		};
	}

	private string Ⴄ(ObjectManager P_0)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		IEquatable<string> equatable = string.Empty;
		try
		{
			int num = 6;
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			object obj4 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
				{
					object obj = new WebClient();
					WebClient obj2 = obj as WebClient;
					object obj3 = new string[5];
					(obj3 as string[])[0] = P_0.Ⴍ().Configuration.HamQth.Url;
					((string[])obj3)[1] = ShowSkimCtyHelp.Ⴍ(1216132932, 5, '!');
					(obj3 as string[])[2] = P_0.Ⴍ().Configuration.HamQth.Callsign;
					(obj3 as string[])[3] = ReplyMail.Ⴅ(8, 2, 1217941975);
					(obj3 as string[])[4] = P_0.Ⴍ().Configuration.HamQth.Password;
					enumerable = SetStationGrid.Ⴀ(obj2, ShowWwv.Ⴈ(obj3 as string[], 'ļ', 340), 'ơ', 430);
					goto case 1;
				}
				case 1:
					num = 5;
					continue;
				case 5:
					obj4 = new XmlDocument();
					ႷႷ.Ⴈ((XmlDocument)obj4, (string)enumerable, 674, 747);
					goto case 2;
				case 2:
					num = 0;
					continue;
				case 0:
					equatable = OperatingHelp.Ⴃ((XmlNode)LogCacheCfg.Ⴐ((XmlDocument)obj4, 'Ψ', 1009), 'ǿ', 471);
					num = ⴃႰ[27] - 9168;
					continue;
				case 7:
				{
					bool num2 = (equatable as string).StartsWith(ReplyMail.Ⴅ(8, 9, 1217941981));
					SetDxCountHelp.ႭႤ[85] = (SetDxCountHelp.ႭႤ[85] ^ SetDxCountHelp.ႭႤ[478]) & 0xEE;
					num = ((!num2) ? 9 : 4);
					continue;
				}
				case 4:
				case 8:
					equatable = string.Empty;
					num = 9;
					continue;
				case 9:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴀ.Error(ex.Message);
		}
		return 4 switch
		{
			_ => equatable as string, 
		};
	}
}
