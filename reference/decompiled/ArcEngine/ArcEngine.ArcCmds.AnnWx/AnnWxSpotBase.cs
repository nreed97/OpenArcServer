using System;
using System.Collections.Generic;
using ArcEngine.ArcCaches;
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
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces;
using ArcInterfaces.Spots;
using ArcShared;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.AnnWx;

public class AnnWxSpotBase
{
	private static readonly ILog m_Ⴃ;

	private static int m_Ⴗ;

	protected readonly AnnWxSpot AnnWx;

	public AnnWxSpotBase()
	{
		object obj = new AnnWxSpot();
		AppLogCfg.Ⴜ((AnnWxSpot)obj, CallBlockCacheCfg.Ⴅ(null, 6, 62057596, null), '\u034b', '\u0313');
		AnnWx = (AnnWxSpot)obj;
	}

	private void Ⴃ()
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 6;
		while (true)
		{
			switch (num)
			{
			default:
				AppLogCfg.Ⴜ(AnnWx, DxCacheCfg.Ⴀ(SunCalculations.Ⴍ(AnnWx, 354, 299), 50, 'Â', 146), 'é', '±');
				goto case 5;
			case 5:
				num = 3;
				break;
			case 3:
				ChatRoomPvtCfg.Ⴅ(AnnWx, DxCacheCfg.Ⴀ(LotwCacheCfg.Ⴀ(AnnWx, 994, 'Δ'), 200, 'ɔ', 516), 186, '²');
				num = 1;
				break;
			case 1:
				ShowLog.Ⴗ(AnnWx, DxCacheCfg.Ⴀ(ShowPrefixCallsHelp.Ⴍ(AnnWx, '\u034d', 885), 12, '\u02dd', 653), 788, '\u0318');
				num = ⴍႤ[206] - 40691;
				break;
			case 0:
			case 8:
				AppLogCfg.Ⴜ(AnnWx, DxCacheCfg.Ⴀ(WxFullHelp.Ⴍ(AnnWx, 801, 869), 12, 'ˣ', 691), 'ǉ', 'Ɠ');
				num = 4;
				break;
			case 4:
			case 7:
				AnnWx.SpotterCty = UtilsString.ScrubLength(AnnWx.SpotterCty, 5);
				AnnWx.SpotterState = UtilsString.ScrubLength(AnnWx.SpotterState, 2);
				num = 2;
				break;
			case 2:
				AnnWx.SpotterCont = UtilsString.ScrubLength(AnnWx.SpotterCont, 2);
				AnnWx.Route = UtilsString.ScrubLength(AnnWx.Route, 255);
				return;
			}
		}
	}

	protected bool ProcessSpot(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		object obj = default(object);
		object obj2 = default(object);
		bool flag = default(bool);
		while (true)
		{
			int num = ((!Ⴈ(cmd)) ? 4 : 25);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႠ[292] - 56592;
					continue;
				case 33:
					break;
				case 25:
					num = (ByeHelp.Ⴍ(SetDxFilter.Ⴀ(ShowPrefixCallsHelp.Ⴍ(AnnWx, 'Ű', 328), 958, 'Ͽ'), SetStationQth.Ⴍ(null, 1687351746, 8, 1), 920, 1023) ? 31 : (ⴐ[384] - 147));
					continue;
				case 9:
					num = (ByeHelp.Ⴍ(SetDxFilter.Ⴀ(ShowPrefixCallsHelp.Ⴍ(AnnWx, '\u0342', 890), 621, 'Ȭ'), ReplyMail.Ⴅ(8, 5, 1217944967), 633, 542) ? 31 : (ⴃႠ[123] - 19735));
					continue;
				case 19:
					num = ((!ByeHelp.Ⴍ(SetDxFilter.Ⴀ(ShowPrefixCallsHelp.Ⴍ(AnnWx, '\u0301', 825), 880, '\u0331'), ႰႥ.Ⴅ(7, '³', 952620405), 163, 196)) ? (ⴀႼ[92] - 87) : 31);
					continue;
				case 31:
					ShowLog.Ⴗ(AnnWx, ShowSkimCtyHelp.Ⴍ(1216133940, 5, 'v'), 425, 'ƥ');
					num = 15;
					continue;
				case 15:
					SetStationBuddyListHelp.Ⴐ(AnnWx, SetStationQth.Ⴍ(null, 1687351751, 6, 10), 'Ǟ', 'Ɩ');
					num = ⴍႭ[356] - 15181;
					continue;
				case 1:
				case 14:
					ShowLog.Ⴄ(AnnWx, ReplyMailHelp.Ⴄ(14, null, 1057162205, 6), 'ƭ', 481);
					num = ⴍႤ[0] - 24008;
					continue;
				case 0:
					ShowLog.Ⴗ(AnnWx, ShowWxHelp.Ⴍ('!', 985808555, 5), 270, 'ă');
					num = 16;
					continue;
				case 21:
					obj = cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႷ()
						.CtyInfoFromCall(ShowPrefixCallsHelp.Ⴍ(AnnWx, 'Ȧ', 542));
					num = ⴃႠ[426] - 16012;
					continue;
				case 3:
					num = (((CtyInfo)obj == null) ? 24 : 32);
					continue;
				case 32:
					SetStationBuddyListHelp.Ⴐ(AnnWx, ShowDxFilter.Ⴈ(obj as CtyInfo, '5', '|'), 'd', ',');
					num = 22;
					continue;
				case 22:
					ShowLog.Ⴄ(AnnWx, qslinfoSoapClient.Ⴈ((CtyInfo)obj, 'ý', 228), 'ȫ', 615);
					goto case 24;
				case 24:
					num = (ByeHelp.Ⴍ(qslinfoRequestBody.Ⴐ(AnnWx, 233, 211), ReplyMailHelp.Ⴄ(9, null, 1057162205, 6), 185, 222) ? (ⴀႳ[26] - 61920) : (ⴀႣ[316] - 54624));
					continue;
				case 11:
					num = ((!ByeHelp.Ⴍ(qslinfoRequestBody.Ⴐ(AnnWx, 450, 504), CallBlockCacheCfg.Ⴅ(null, 3, 62057566, null), 785, 886)) ? (ⴀႨ[190] - 45578) : 8);
					continue;
				case 8:
					obj2 = cmd.Ⴍ().Ⴅ().Ⴀ()
						.UsVeCallbook.Search(ShowPrefixCallsHelp.Ⴍ(AnnWx, '\r', 53));
					goto case 12;
				case 12:
					num = ⴀႼ[6] - 38;
					continue;
				case 34:
					num = ((!(obj2 is CallbookData)) ? 16 : (ⴀႨ[98] - 41424));
					continue;
				case 10:
					ShowLog.Ⴗ(AnnWx, BadWordCacheCfg.Ⴅ(obj2 as CallbookData, 57, 80), 648, 'ʅ');
					goto case 16;
				case 16:
					num = ((!ByeHelp.Ⴍ(SunCalculations.Ⴍ(AnnWx, 918, 991), CallBlockCacheCfg.Ⴅ(null, 7, 62057919, null), 194, 165)) ? 6 : (ⴀႣ[220] - 64263));
					continue;
				case 29:
					AppLogCfg.Ⴜ(AnnWx, ReplyMail.Ⴅ(2, 0, 1217944756), 'θ', 'Ϡ');
					goto case 6;
				case 6:
					ShowLog.Ⴗ(AnnWx, SetTalkDefault.Ⴃ(qslinfoResponse.Ⴗ(SunCalculations.Ⴍ(AnnWx, 667, 722), ShowPrefixCallsHelp.Ⴍ(AnnWx, 'Ȉ', 560), LotwCacheCfg.Ⴀ(AnnWx, 712, 'ʾ'), WxFullHelp.Ⴍ(AnnWx, 699, 767), 284, 'ſ'), 900, 'ί'), 366, 'Š');
					goto case 20;
				case 20:
					num = ⴄႭ[157] - 217;
					continue;
				case 35:
					AnnWx.Id = AnnWxSpotBase.m_Ⴗ++;
					cmd.Tx.Id = AnnWx.Id;
					num = 26;
					continue;
				case 26:
					AnnWx.Route = cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call + '.' + AnnWx.Route;
					num = 23;
					continue;
				case 23:
					Ⴃ();
					num = ((!(AnnWx.WxFlag == ReplyMail.Ⴅ(1, 6, 1217944961))) ? ⴀႼ[139] : 30);
					continue;
				case 30:
					flag = cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴈ()
						.AddSpot(AnnWx);
					cmd.Tx.MsgType = MsgType.Wx;
					num = 27;
					continue;
				case 17:
					flag = cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴄ()
						.AddSpot(AnnWx);
					cmd.Tx.MsgType = MsgType.Ann;
					goto case 27;
				case 27:
					num = ((!flag) ? (ⴀႣ[281] - 27592) : 5);
					continue;
				case 5:
					Ⴓ(cmd, ShowSkimCtyHelp.Ⴍ(1216133558, 3, 'Õ'));
					AnnWx.IsDupe = true;
					num = 28;
					continue;
				case 28:
					return false;
				case 18:
					Ⴗ(cmd, false);
					cmd.Tx.Msg.Add(Ⴄ());
					num = 2;
					continue;
				case 2:
					cmd.Tx.NodeXml = AnnWx.SerializeNode();
					cmd.Tx.ClientXml = AnnWx.SerializeClient();
					num = 7;
					continue;
				case 7:
					return true;
				case 4:
					return false;
				}
				break;
			}
		}
	}

	private void Ⴓ(NodeUserCmd P_0, string P_1)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0022;
			case 0:
				P_0.Ⴍ().Io.TenMinuteDxDupeCnt++;
				break;
			case 2:
			case 3:
				break;
			case 4:
				return;
			}
			break;
			IL_0022:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(P_1, Ⴄ(), 743, 681));
			num = ⴀႨ[8] - 49086;
		}
		P_0.Tx.DistroType = DistroType.ToNil;
		SetTalkCountHelp.Ⴅ[478] = (byte)((SetTalkCountHelp.Ⴅ[478] * SetTalkCountHelp.Ⴅ[306]) & 0x3A);
	}

	private bool Ⴈ(NodeUserCmd P_0)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		while (true)
		{
			int num = ((CallBlockCacheCfg.Ⴜ(ShowPrefixCallsHelp.Ⴍ(AnnWx, 'ň', 368), 5, 100) >= 3) ? 6 : (ⴄႷ[87] - 25173));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 9;
					continue;
				case 9:
					break;
				case 0:
					Ⴓ(P_0, ReplyMailHelp.Ⴄ(6, null, 1057161898, 8));
					return false;
				case 6:
					num = (ႷႷ.Ⴍ(ShowPrefixCallsHelp.Ⴍ(AnnWx, '\u034b', 883), 581, 'Ɉ') ? (ⴃႠ[325] - 17539) : 7);
					continue;
				case 4:
				case 7:
					Ⴓ(P_0, CallBlockCacheCfg.Ⴅ(null, 2, 62057894, null));
					return false;
				case 2:
				case 12:
					num = ((!P_0.Ⴍ().Ⴅ().Ⴀ()
						.ႤႥ()
						.IsBlocked(ShowPrefixCallsHelp.Ⴍ(AnnWx, 'm', 85))) ? 11 : 3);
					continue;
				case 3:
					Ⴓ(P_0, SetStationQth.Ⴍ(null, 1687351522, 0, 8));
					return false;
				case 11:
				{
					bool num2 = P_0.Ⴍ().Ⴅ().Ⴀ()
						.ႤႤ()
						.Ⴈ(LotwCacheCfg.Ⴀ(AnnWx, 48, 'F'));
					ShowWwvOptionsHelp.ႣႥ[442] = (char)((ShowWwvOptionsHelp.ႣႥ[442] - Arc4ServerClient.ႠႣ[155]) & 0xA8);
					num = (num2 ? 5 : 13);
					continue;
				}
				case 13:
					Ⴓ(P_0, SetTalkCount.Ⴗ(6, null, 1267021987, typeof(ShowConnects.ႥႥ)));
					goto case 10;
				case 10:
					num = ⴀ[21] - 28081;
					continue;
				case 1:
					return false;
				case 5:
					return true;
				}
				break;
			}
		}
	}

	private string Ⴄ()
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		object obj = default(object);
		ICloneable cloneable = default(ICloneable);
		Array array = default(Array);
		while (true)
		{
			int num = ((!ByeHelp.Ⴍ(SunCalculations.Ⴍ(AnnWx, 414, 468), ReplyMail.Ⴅ(0, 4, 1217944960), 824, 863)) ? 18 : (ⴃႠ[104] - 44120));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀ[16] - 49514;
					continue;
				case 4:
					break;
				case 3:
				case 14:
					obj = new string[6];
					((string[])obj)[0] = CallBlockCacheCfg.Ⴅ(null, 1, 62058074, null);
					num = 10;
					continue;
				case 10:
					((string[])obj)[1] = ShowPrefixCallsHelp.Ⴍ(AnnWx, 'ή', 918);
					num = 19;
					continue;
				case 19:
					((string[])obj)[2] = SetStationQth.Ⴍ(null, 1687351538, 6, 30);
					num = 5;
					continue;
				case 5:
				{
					string[] obj2 = obj as string[];
					DateTime dateTime = ShowAnnHelp.Ⴅ('Ċ', 315);
					obj2[3] = ShowAnnOptionsHelp.Ⴗ(ref dateTime, ReplyMailHelp.Ⴄ(10, null, 1057161794, 4), 692, 688);
					num = 16;
					continue;
				}
				case 16:
					(obj as string[])[4] = ReplyMail.Ⴅ(4, 11, 1217945016);
					(obj as string[])[5] = LotwCacheCfg.Ⴀ(AnnWx, 652, '\u02fa');
					num = ⴅ[422] - 137;
					continue;
				case 9:
					cloneable = ShowWwv.Ⴈ((string[])obj, 'Ϭ', 900);
					num = 8;
					continue;
				case 2:
				case 6:
				case 18:
					array = new string[8];
					((string[])array)[0] = ႰႥ.Ⴅ(3, '\u009a', 952620414);
					num = ⴐ[180] - 192;
					continue;
				case 1:
					(array as string[])[1] = SunCalculations.Ⴍ(AnnWx, 991, 918);
					num = ⴀ[172] - 3506;
					continue;
				case 13:
				{
					((string[])array)[2] = ReplyMailHelp.Ⴄ(25, null, 1057162087, 3);
					char num2 = ⴀ[330];
					IpLockoutCacheCfg.ႭႭ[170] = (char)((IpLockoutCacheCfg.ႭႭ[170] ^ IpLockoutCacheCfg.ႭႭ[329]) & 0x72);
					num = num2 - 54198;
					continue;
				}
				case 12:
					(array as string[])[3] = ShowPrefixCallsHelp.Ⴍ(AnnWx, 'Ύ', 950);
					num = ⴀႳ[261] - 25318;
					continue;
				case 11:
					(array as string[])[4] = SetStationQth.Ⴍ(null, 1687351536, 4, 31);
					num = ⴃႠ[243] - 16801;
					continue;
				case 7:
					(array as string[])[5] = ShowAnnHelp.Ⴅ('x', 73).ToString(ReplyMailHelp.Ⴄ(1, null, 1057161795, 5));
					num = ⴃႰ[112] - 2862;
					continue;
				case 17:
					(array as string[])[6] = ReplyMail.Ⴅ(1, 0, 1217945021);
					((string[])array)[7] = AnnWx.Msg;
					num = 0;
					continue;
				case 0:
					cloneable = string.Concat(array as string[]);
					num = 8;
					continue;
				case 8:
					return (string)cloneable;
				}
				break;
			}
		}
	}

	private void Ⴗ(NodeUserCmd P_0, bool P_1)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 18;
		object obj3 = default(object);
		ICloneable cloneable = default(ICloneable);
		object obj = default(object);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		object obj2 = default(object);
		while (true)
		{
			string text;
			switch (num)
			{
			default:
				num = (ByeHelp.Ⴍ(SunCalculations.Ⴍ(AnnWx, 801, 872), ReplyMail.Ⴅ(2, 8, 1217944756), 568, 607) ? (ⴀႼ[121] - 90) : (ⴍႭ[107] - 31414));
				break;
			case 11:
				text = SunCalculations.Ⴍ(AnnWx, 236, 165);
				goto IL_00f7;
			case 4:
				text = CallBlockCacheCfg.Ⴅ(null, 3, 62057915, null);
				goto IL_00f7;
			case 16:
				obj3 = new string[6];
				((string[])obj3)[0] = ShowPrefixCallsHelp.Ⴍ(AnnWx, '!', 25);
				num = 3;
				break;
			case 3:
				((string[])obj3)[1] = SetStationQth.Ⴍ(null, 1687351534, 1, 16);
				num = 5;
				break;
			case 5:
				(obj3 as string[])[2] = (string)cloneable;
				goto case 14;
			case 14:
				((string[])obj3)[3] = SetStationQth.Ⴍ(null, 1687351531, 4, 22);
				num = 1;
				break;
			case 1:
				((string[])obj3)[4] = LotwCacheCfg.Ⴀ(AnnWx, 281, 'ů');
				num = ⴀႳ[116] - 39958;
				break;
			case 10:
				(obj3 as string[])[5] = SetStationQth.Ⴍ(null, 1687351534, 1, 13);
				num = 8;
				break;
			case 8:
				obj = ShowWwv.Ⴈ(obj3 as string[], 'ø', 144);
				enumerable = (string)obj;
				num = 15;
				break;
			case 15:
				obj2 = new string[7];
				goto case 12;
			case 12:
				(obj2 as string[])[0] = enumerable as string;
				((string[])obj2)[1] = LotwCacheCfg.Ⴀ(AnnWx, 947, 'τ');
				num = 13;
				break;
			case 13:
				((string[])obj2)[2] = SetStationQth.Ⴍ(null, 1687351529, 6, 13);
				num = ⴃႠ[278] - 2728;
				break;
			case 17:
				(obj2 as string[])[3] = WxFullHelp.Ⴍ(AnnWx, 962, 902);
				num = ⴐ[278] - 204;
				break;
			case 9:
				(obj2 as string[])[4] = SetStationQth.Ⴍ(null, 1687351531, 4, 6);
				num = 0;
				break;
			case 0:
				(obj2 as string[])[5] = SunCalculations.Ⴍ(AnnWx, 770, 840);
				num = 7;
				break;
			case 7:
				((string[])obj2)[6] = SetStationQth.Ⴍ(null, 1687351535, 0, 6);
				num = ⴃႥ[78] - 62905;
				break;
			case 6:
				obj = ShowWwv.Ⴈ((string[])obj2, 'Ƙ', 496);
				if (P_1)
				{
					num = 19;
					break;
				}
				while (true)
				{
					P_0.Tx.Pcxx = AnnHelp.Ⴈ(ShowWxHelp.Ⴍ('\u0001', 985808532, 5), (string)obj, ShowSkimCtyHelp.Ⴍ(1216133939, 4, 'M'), 483, 'ǔ');
					while (true)
					{
						switch (1)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 0:
							break;
						case 4:
							continue;
						case 1:
						{
							TxNodeUserCmd tx2 = P_0.Tx;
							Array array2 = new string[6];
							((string[])array2)[0] = SetStationQth.Ⴍ(null, 1687351796, 8, 19);
							((string[])array2)[1] = (string)obj;
							(array2 as string[])[2] = AnnWx.SpotterCty;
							((string[])array2)[3] = SetStationQth.Ⴍ(null, 1687351533, 2, 29);
							((string[])array2)[4] = AnnWx.SpotterState;
							(array2 as string[])[5] = SetStationQth.Ⴍ(null, 1687351529, 2, 14);
							tx2.Arxx = string.Concat(array2 as string[]);
							return;
						}
						case 3:
						case 5:
							return;
						}
						break;
					}
				}
			case 19:
				P_0.Tx.Pcxx = AnnHelp.Ⴈ(ShowWxHelp.Ⴍ('1', 985808535, 6), obj as string, ReplyMail.Ⴅ(3, 7, 1217945016), 679, 'ʐ');
				num = ⴃႥ[183] - 11659;
				break;
			case 2:
				{
					TxNodeUserCmd tx = P_0.Tx;
					Array array = new string[6];
					((string[])array)[0] = SetStationQth.Ⴍ(null, 1687351802, 6, 23);
					(array as string[])[1] = obj as string;
					(array as string[])[2] = qslinfoRequestBody.Ⴐ(AnnWx, 714, 752);
					(array as string[])[3] = SetStationQth.Ⴍ(null, 1687351535, 0, 8);
					((string[])array)[4] = SetWxCountHelp.Ⴈ(AnnWx, 'Ğ', 'Š');
					(array as string[])[5] = SetTalkCount.Ⴗ(4, null, 1267021962, typeof(TalkCacheCfg));
					tx.Arxx = ShowWwv.Ⴈ((string[])array, 'μ', 980);
					return;
				}
				IL_00f7:
				cloneable = text;
				goto case 16;
			}
		}
	}

	static AnnWxSpotBase()
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				AnnWxSpotBase.m_Ⴗ = 0;
				return;
			case 0:
			case 2:
			case 4:
				return;
			}
			AnnWxSpotBase.m_Ⴃ = SkimmerValidSpot.Ⴐ(CallBlockCacheCfg.Ⴅ(null, 5, 62058061, null), 601, 580);
			num = 1;
		}
	}
}
