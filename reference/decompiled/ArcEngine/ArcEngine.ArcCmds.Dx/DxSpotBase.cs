using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Talk;
using ArcEngine.ArcCmds.User;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcCmds.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcIo.Mirc;
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

namespace ArcEngine.ArcCmds.Dx;

public class DxSpotBase
{
	private static readonly ILog m_Ⴗ;

	private static int m_Ⴈ;

	private DxSpot m_Ⴃ;

	private string m_Ⴅ;

	private string m_Ⴓ;

	private TalkSpotHelp.Ⴐ m_Ⴄ = new TalkSpotHelp.Ⴐ();

	public DxSpot Dx
	{
		get
		{
			DxSpot ⴃ = this.m_Ⴃ;
			IpLockoutCacheCfg.ႭႭ[48] = (char)(IpLockoutCacheCfg.ႭႭ[48] & DirectoryBulletin.ႠႨ[127] & 0x8E);
			return ⴃ;
		}
		set
		{
			this.m_Ⴃ = value;
		}
	}

	protected bool IsEchoRequestOnly
	{
		get
		{
			return this.m_Ⴄ.Ⴈ;
		}
		set
		{
			bool ⴈ = value;
			this.m_Ⴄ.Ⴈ = ⴈ;
		}
	}

	protected string Date
	{
		get
		{
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			return this.m_Ⴄ.Ⴄ;
		}
		set
		{
			this.m_Ⴄ.Ⴄ = value as string;
		}
	}

	protected string Time
	{
		get
		{
			return this.m_Ⴅ;
		}
		set
		{
			this.m_Ⴅ = value;
		}
	}

	[SpecialName]
	private string Ⴀ()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		return this.m_Ⴄ.Ⴃ;
	}

	[SpecialName]
	private void Ⴍ(string P_0)
	{
		this.m_Ⴄ.Ⴃ = P_0;
	}

	[SpecialName]
	private string Ⴗ()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		return this.m_Ⴄ.Ⴀ;
	}

	[SpecialName]
	private void Ⴈ(string P_0)
	{
		this.m_Ⴄ.Ⴀ = P_0 as string;
	}

	[SpecialName]
	private string Ⴃ()
	{
		return this.m_Ⴓ;
	}

	[SpecialName]
	private void Ⴀ(string P_0)
	{
		this.m_Ⴓ = P_0;
	}

	[SpecialName]
	private string Ⴄ()
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		return HealthMonitorCfg.Ⴓ(Dx, 904, 943).ToString(ႰႥ.Ⴅ(5, '\u0014', 952619057));
	}

	public DxSpotBase()
	{
		Dx = new DxSpot();
	}

	private static string Ⴓ(string P_0)
	{
		while (true)
		{
			int num = CallBlockCacheCfg.Ⴜ(P_0, 403, 498);
			SetAnnChatRooms.Ⴀ[335] = (char)((SetAnnChatRooms.Ⴀ[335] - SetAnnChatRooms.Ⴀ[1]) & 0xAC);
			int num2 = ((num <= 30) ? 3 : 2);
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 7:
					break;
				case 2:
					return SetTalkOutputHelp.Ⴍ(P_0, 0, 30, 142, 221);
				case 3:
					num2 = ((CallBlockCacheCfg.Ⴜ(P_0, 186, 219) != 0) ? 8 : 0);
					continue;
				case 0:
				case 6:
					return SetTalkCount.Ⴗ(2, null, 1267022529, typeof(ShowContestStation));
				case 8:
					return P_0;
				}
				break;
			}
		}
	}

	private static string Ⴃ(string P_0)
	{
		return P_0;
	}

	private static string Ⴅ(string P_0)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		while (true)
		{
			P_0 = ShowContestStationHelp.Ⴅ(P_0, global::Ⴈ.ႨႨ.Ⴀ(14, 5, 1157903720), string.Empty, 724, 'ʌ');
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႳ[335] - 20595;
					continue;
				case 2:
					break;
				case 4:
					num = ((CallBlockCacheCfg.Ⴜ(P_0, 196, 165) != 4) ? (ⴅ[92] - 6) : (ⴃႥ[223] - 25464));
					continue;
				case 1:
				case 3:
					P_0 = SetTalkOutputHelp.Ⴍ(P_0, 0, 2, 716, 671) + ':' + P_0.Substring(2, 2);
					num = 5;
					continue;
				case 0:
				case 5:
				case 7:
					return P_0;
				}
				break;
			}
		}
	}

	private void Ⴓ()
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴈ(ShowQslInfoHelp.Ⴓ(WxHelp.Ⴀ(Dx, 865, 892), 493, 'ƞ'));
				num = ⴍႤ[111] - 53937;
				break;
			case 0:
			case 3:
				Ⴀ(ShowQslInfoHelp.Ⴓ(ShowVersion.Ⴐ(Dx, 770, 894), 349, 'Į'));
				goto case 8;
			case 8:
				num = 6;
				break;
			case 6:
				Ⴍ(Ⴅ(Time));
				Date = Ⴃ(Date);
				num = ⴄႷ[87] - 25172;
				break;
			case 1:
			case 5:
				num = ((!ShowTalk.Ⴀ(ShowVersion.Ⴐ(Dx, 204, 176), global::Ⴈ.ႨႨ.Ⴀ(7, 0, 1157903729), 295, 'ņ')) ? 4 : 7);
				break;
			case 7:
				Dx.Skimmer = true;
				Dx.Comment = CallBlockCacheCfg.Ⴅ(null, 2, 62058417, null) + Dx.Comment.Trim();
				return;
			case 4:
				return;
			}
		}
	}

	private void Ⴗ(NodeUserCmd P_0)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 24;
		object obj = default(object);
		SkimmerCt1bohCache.SkimmerQualityType skimmerQualityCt1boh = default(SkimmerCt1bohCache.SkimmerQualityType);
		float freqQsyPercent = default(float);
		int skimCtyCnt = default(int);
		string bustedKeyCall = default(string);
		while (true)
		{
			switch (num)
			{
			default:
				SetAnnDefaultHelp.Ⴀ(Dx, DxCacheCfg.Ⴀ(WxHelp.Ⴀ(Dx, 108, 113), 12, 'ȣ', 627), 'Ō', 'ē');
				num = 12;
				break;
			case 12:
				ShowDxOptionsHelp.Ⴍ(Dx, DxCacheCfg.Ⴀ(ShowVersion.Ⴐ(Dx, 72, 52), 12, 'Ƒ', 449), 689, 731);
				num = 13;
				break;
			case 13:
				DxClusterCacheCfg.Ⴗ(Dx, DxCacheCfg.Ⴀ(ShowPrefix.Ⴍ(Dx, 656, 675), 12, 'ɟ', 527), 768, 790);
				num = ⴀ[206] - 9788;
				break;
			case 17:
				SetAnnDefaultHelp.Ⴀ(Dx, Ⴓ(SetDxExtensionHelp.Ⴍ(Dx, '\u0379', '\u036b')), 'ɟ', 'ȿ');
				num = ⴐ[177];
				break;
			case 35:
				ShowDxOptionsHelp.Ⴍ(Dx, DxCacheCfg.Ⴀ(MailCacheCfg.Ⴅ(Dx, 272, 'š'), 2, 'ļ', 364), 232, 131);
				num = ⴄႷ[66] - 17228;
				break;
			case 14:
				WwvHelp.Ⴐ(Dx, DxCacheCfg.Ⴀ(ShowVersion.Ⴐ(Dx, 386, 511), 5, 'Ô', 132), '<', 3);
				num = 33;
				break;
			case 33:
				SetAnnDefaultHelp.Ⴀ(Dx, DxCacheCfg.Ⴀ(SetDxExtensionHelp.Ⴍ(Dx, '0', '#'), 5, 'ȩ', 633), '«', 'Ê');
				num = 30;
				break;
			case 30:
				DxClusterCacheCfg.Ⴗ(Dx, DxCacheCfg.Ⴀ(ShowVersion.Ⴐ(Dx, 78, 48), 4, 'η', 999), 635, 620);
				goto case 8;
			case 8:
				num = ⴃႰ[163] - 18237;
				break;
			case 7:
				WxHelp.Ⴗ(Dx, DxCacheCfg.Ⴀ(MailCacheCfg.Ⴅ(Dx, 580, 'ȶ'), 2, '\f', 92), 'ʨ', 'ʞ');
				num = 25;
				break;
			case 25:
				DxClusterCacheCfg.Ⴗ(Dx, DxCacheCfg.Ⴀ(MircIo.Ⴈ(Dx, '5', 't'), 2, 'Ì', 156), 815, 823);
				num = 29;
				break;
			case 29:
				ShowQslInfoHelp.Ⴈ(Dx, DxCacheCfg.Ⴀ(ShowAnn.Ⴄ(Dx, '\u031a', 864), 255, '°', 224), 289, 378);
				num = ⴄႤ[34] - 66;
				break;
			case 21:
				NodeCacheCfg.Ⴄ(Dx, ShowAnnHelp.Ⴅ('\u00ad', 156), 676, 675);
				num = 19;
				break;
			case 19:
				num = ((!ShowPrefixCallsHelp.Ⴈ(Dx, '\u009f', 139)) ? 9 : (ⴐ[60] - 65));
				break;
			case 1:
			{
				obj = global::Ⴈ.ႨႠ.Ⴈ(SetDxExtensionHelp.Ⴍ(Dx, 'ɽ', 'ɯ'));
				ႨႠ obj2 = obj as ႨႠ;
				ႨႣ.Ⴐ[68] = (byte)((ႨႣ.Ⴐ[68] ^ ႨႣ.Ⴐ[220]) & 0x11);
				num = ((obj2 == null) ? 27 : (ⴀႨ[208] - 6509));
				break;
			}
			case 2:
				DxCmdMsgExt.ႨႨ(Dx, (byte)(obj as ႨႠ).Ⴗ(), 493, 490);
				num = 26;
				break;
			case 0:
			case 26:
				ArcConnectObj.Ⴍ(Dx, (byte)(obj as ႨႠ).Ⴍ(), 831, 843);
				num = 10;
				break;
			case 10:
				DxClusterCacheCfg.Ⴗ(Dx, SetStationQth.Ⴍ(null, 1687352335, 4, 9), 1009, 998);
				goto case 27;
			case 27:
				P_0.Tx.MsgType = MsgType.DxLocal;
				num = ((!P_0.Ⴍ().Ⴅ().Ⴍ()
					.SpotProcessing.EnableCt1bohProcessing) ? (ⴐ[184] - 97) : (ⴄႤ[282] - 166));
				break;
			case 22:
				SetAnnDefaultHelp.Ⴀ(Dx, SetTalkDefault.Ⴃ(SetDxFilter.Ⴀ(SetDxExtensionHelp.Ⴍ(Dx, '\u0322', '\u0330'), 338, 'Ē'), 993, 'ύ'), '\u00ad', 'Í');
				num = ⴐ[182] - ⴐ[367];
				break;
			case 18:
				skimmerQualityCt1boh = P_0.Ⴍ().Ⴅ().Ⴀ()
					.ႨႳ()
					.GetSkimmerQualityCt1boh(Dx, out freqQsyPercent, out skimCtyCnt, out bustedKeyCall);
				num = ⴄႤ[302] - 133;
				break;
			case 5:
				num = skimmerQualityCt1boh switch
				{
					SkimmerCt1bohCache.SkimmerQualityType.Unknown => 4, 
					SkimmerCt1bohCache.SkimmerQualityType.Valid => 37, 
					SkimmerCt1bohCache.SkimmerQualityType.Qsy => 20, 
					SkimmerCt1bohCache.SkimmerQualityType.Busted => 6, 
					SkimmerCt1bohCache.SkimmerQualityType.BustedOverride => 23, 
					_ => 28, 
				};
				break;
			case 28:
				num = ⴅ[372] - 56;
				break;
			case 4:
				ShowQslInfoHelp.Ⴗ(Dx, true, '\u0337', 808);
				WxHelp.Ⴗ(Dx, ReplyMailHelp.Ⴄ(25, null, 1057163017, 3), '«', '\u009c');
				num = ⴐ[21];
				break;
			case 37:
				ShowContestStationHelp.Ⴃ(Dx, true, 726, 694);
				Dx.SkimQualityFlag = ReplyMail.Ⴅ(1, 13, 1217943652);
				num = 3;
				break;
			case 20:
				Dx.IsSkimQsy = true;
				Dx.SkimQualityFlag = global::Ⴈ.ႨႨ.Ⴀ(6, 6, 1157902584);
				num = ⴀႳ[226] - 25857;
				break;
			case 6:
				Dx.IsSkimBusted = true;
				Dx.SkimQualityFlag = bustedKeyCall + ReplyMail.Ⴅ(5, 15, 1217943655);
				num = ⴄႭ[562] - 204;
				break;
			case 15:
			case 23:
				Dx.IsSkimUnknown = true;
				Dx.SkimQualityFlag = bustedKeyCall + ReplyMailHelp.Ⴄ(18, null, 1057163019, 1);
				goto case 3;
			case 3:
				Dx.SkimFreqQsyPercent = freqQsyPercent;
				Dx.SkimCtyCnt = skimCtyCnt;
				goto case 9;
			case 9:
				num = ((!Dx.Comment.Contains(ReplyMailHelp.Ⴄ(11, null, 1057163013, 2))) ? 32 : 36);
				break;
			case 36:
				num = ((!Dx.Skimmer) ? 34 : (ⴀ[249] - 56105));
				break;
			case 11:
				Dx.SkimCq = true;
				num = 32;
				break;
			case 34:
				Dx.Cq = true;
				goto case 32;
			case 32:
				Dx.Master = P_0.Ⴍ().Ⴅ().Ⴀ()
					.ႤႼ()
					.Ⴍ(Dx.Call);
				num = ⴐ[124] - ⴐ[111];
				break;
			case 38:
				Dx.Unique = P_0.Ⴍ().Ⴅ().Ⴀ()
					.ႨႤ()
					.Ⴀ(Dx.Call, Dx.Band, Dx.Spotter);
				num = 16;
				break;
			case 16:
				Dx.Top100 = P_0.Ⴍ().Ⴅ().Ⴀ()
					.ႨႥ()
					.Ⴐ(Dx.Cty);
				num = 31;
				break;
			case 31:
				Dx.Foc = P_0.Ⴍ().Ⴅ().Ⴀ()
					.ႨႷ()
					.Ⴈ(Dx.Call);
				return;
			}
		}
	}

	private string Ⴈ()
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		IEquatable<string> equatable = default(IEquatable<string>);
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			IEnumerable<char> enumerable = ShowQslInfoHelp.Ⴓ(ShowVersion.Ⴐ(Dx, 201, 181), 890, '\u0309');
			char num = ⴀႣ[263];
			ႨႣ.Ⴐ[282] = (byte)((ႨႣ.Ⴐ[282] | ႨႣ.Ⴐ[48]) & 0x2B);
			int num2 = num - 56180;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႭ[357] - 4259;
					continue;
				case 10:
					break;
				case 5:
				case 8:
					equatable = ShowPrefixCalls.Ⴃ((object)WxHelp.Ⴀ(Dx, 889, 868), (object)(string)enumerable, (object)HealthMonitorCfg.Ⴓ(Dx, 340, 371), 'Ʃ', 387);
					num2 = 9;
					continue;
				case 9:
					num2 = (ShowPrefixCallsHelp.Ⴈ(Dx, 'Ĕ', 256) ? (ⴄႷ[29] - 57768) : (ⴄႭ[88] - 185));
					continue;
				case 3:
					cloneable = Dx.Comment;
					num2 = ((((string)cloneable).Length <= 10) ? ⴐ[254] : (ⴀႣ[99] - 5372));
					continue;
				case 7:
					cloneable = (cloneable as string).Substring(0, 10);
					num2 = 0;
					continue;
				case 0:
				case 2:
					equatable = (equatable as string) + (string)cloneable;
					num2 = 4;
					continue;
				case 4:
					return UtilsString.ScrubKey((string)equatable);
				}
				break;
			}
		}
	}

	public bool ProcessSpot(NodeUserCmd cmd)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		bool flag = default(bool);
		float band = default(float);
		string mode = default(string);
		while (true)
		{
			int num;
			if (cmd.Ⴍ().Io != null)
			{
				num = 8;
			}
			else
			{
				byte num2 = ⴅ[367];
				SetTalkCountHelp.Ⴅ[275] = (byte)(SetTalkCountHelp.Ⴅ[275] & SetTalkCountHelp.Ⴅ[253] & 0x9A);
				num = num2 - 222;
			}
			int num3 = num;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = 18;
					continue;
				case 18:
					break;
				case 8:
					cmd.Ⴍ().Io.DxSpotRate[59] += 1.0;
					num3 = 3;
					continue;
				case 3:
					Ⴓ();
					ShowQslInfoHelp.Ⴈ(Dx, Ⴈ(), 662, 714);
					num3 = ⴅ[128] - ⴅ[52];
					continue;
				case 14:
					flag = cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴃ()
						.Ⴍ(SetDxExtensionHelp.Ⴍ(Dx, '\u033b', '\u032f'), TalkSpotHelp.Ⴈ(Dx, 44, ']'));
					num3 = ⴄႭ[344] - 122;
					continue;
				case 21:
					num3 = ((!flag) ? (ⴄႷ[100] - 20015) : 11);
					continue;
				case 11:
					Ⴀ(cmd, global::Ⴈ.ႨႨ.Ⴀ(4, 8, 1157902475), true);
					return false;
				case 1:
				case 12:
					SetStationGrid.Ⴐ(Dx, Ⴐ(cmd), 180, '\u00b4');
					num3 = ((!IsValid(cmd)) ? 15 : (ⴃႰ[157] - 27345));
					continue;
				case 7:
					Ⴄ(cmd);
					SetWwvOutput.Ⴃ(Dx, cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႣ()
						.Ⴃ(Ⴗ()), 'è', 157);
					num3 = ⴄႤ[109] - 94;
					continue;
				case 4:
					band = 0f;
					mode = string.Empty;
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႨ()
						.GetBandMode(HealthMonitorCfg.Ⴓ(Dx, 434, 405), ref band, ref mode);
					num3 = 19;
					continue;
				case 19:
					MircIo.Ⴐ(Dx, band, 700, 747);
					DxClusterCacheCfg.Ⴗ(Dx, mode, 655, 664);
					num3 = 16;
					continue;
				case 16:
					ShowQslInfoHelp.Ⴈ(Dx, ShowPrefixCalls.Ⴃ((object)cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call, (object)'.', (object)ShowAnn.Ⴄ(Dx, 'Ž', 263), 'ľ', 276), 150, 205);
					num3 = 23;
					continue;
				case 23:
					ShowWxHelp.Ⴈ(Dx, Ⴍ(), 'ϐ', '\u038b');
					SetWwvOutputHelp.Ⴍ(Dx, Ⴐ(), 491, 498);
					num3 = ⴄႭ[532] - 88;
					continue;
				case 24:
					qslinfoResponse.Ⴈ(Dx, DxSpotBase.m_Ⴈ++, 'ȥ', 'ɿ');
					num3 = ⴀႼ[80];
					continue;
				case 0:
					Ⴗ(cmd);
					flag = cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴃ()
						.AddSpot(Dx);
					num3 = ⴀႨ[83] - 31169;
					continue;
				case 6:
					num3 = ((!flag) ? 10 : 22);
					continue;
				case 22:
					Ⴀ(cmd, ShowSkimCtyHelp.Ⴍ(1216134209, 2, '£'), true);
					return false;
				case 10:
					cmd.Ⴍ().Ⴅ().Ⴍ()
						.SpotProcessing.BumpDxSpotCount();
					cmd.Tx.Msg.Add(Ⴜ(cmd));
					num3 = 13;
					continue;
				case 13:
					ႨႠ(cmd);
					ႨႨ(cmd);
					cmd.Tx.Id = Dx.Id;
					num3 = 9;
					continue;
				case 9:
					cmd.Tx.NodeXml = Dx.SerializeNode();
					cmd.Tx.ClientXml = Dx.SerializeClient();
					num3 = ⴀႣ[257] - 51094;
					continue;
				case 20:
					cmd.Tx.DistroType = ((!IsEchoRequestOnly) ? DistroType.ToAll : DistroType.ToRequester);
					return true;
				case 5:
				case 15:
					return false;
				}
				break;
			}
		}
	}

	private void Ⴀ(NodeUserCmd P_0, string P_1, bool P_2)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(P_1, Ⴜ(P_0), 863, 785));
				num = ⴃႰ[162] - 58496;
				break;
			case 0:
				P_0.Ⴍ().Io.TenMinuteDxDupeCnt++;
				goto case 1;
			case 1:
			case 4:
				P_0.Tx.DistroType = DistroType.ToNil;
				goto case 3;
			case 3:
				num = 2;
				break;
			case 2:
				Dx.IsDupe = P_2;
				return;
			}
		}
	}

	private void Ⴄ(NodeUserCmd P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 12;
		object obj = default(object);
		ICallbookData callbookData = default(ICallbookData);
		while (true)
		{
			switch (num)
			{
			default:
				obj = P_0.Ⴍ().Ⴅ().Ⴀ()
					.ႤႷ()
					.CtyInfoFromCall(Ⴃ());
				num = (((CtyInfo)obj == null) ? 10 : (ⴐ[243] / 4));
				break;
			case 2:
				SetAnnDefaultHelp.Ⴀ(Dx, qslinfoSoapClient.Ⴈ(obj as CtyInfo, 'Ų', 363), '\u0017', 'v');
				goto case 9;
			case 9:
				num = 11;
				break;
			case 11:
				SendMail.Ⴄ(Dx, ShowDxFilter.Ⴈ((CtyInfo)obj, 'ϸ', 'α'), '\u0002', 65);
				num = ⴀႼ[35] - 121;
				break;
			case 7:
				ShowUptime.Ⴅ(Dx, ShowUptime.Ⴄ(obj as CtyInfo, 594, 633), '¦', 134);
				num = 1;
				break;
			case 1:
				UserCacheCfg.Ⴅ(Dx, SetStationMacros.Ⴐ(obj as CtyInfo, 43, 'l'), 891, 774);
				goto case 0;
			case 0:
			case 10:
				num = (ByeHelp.Ⴍ(SetDxExtensionHelp.Ⴍ(Dx, 'ċ', 'Ę'), ReplyMailHelp.Ⴄ(10, null, 1057162206, 5), 632, 543) ? 8 : 5);
				break;
			case 5:
				num = ((!(Dx.SpotterCty == CallBlockCacheCfg.Ⴅ(null, 8, 62057557, null))) ? 4 : (ⴀႣ[66] - 36083));
				break;
			case 6:
			case 8:
				callbookData = P_0.Ⴍ().Ⴅ().Ⴀ()
					.UsVeCallbook.Search(Ⴃ());
				num = ((!(callbookData is CallbookData)) ? (ⴍႤ[336] - 43921) : (ⴀ[397] - 6774));
				break;
			case 3:
				Dx.SpotterState = ((CallbookData)callbookData).State;
				return;
			case 4:
				return;
			}
		}
	}

	private bool Ⴐ(NodeUserCmd P_0)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		object obj2 = default(object);
		while (true)
		{
			object obj = P_0.Ⴍ().Ⴅ().Ⴀ()
				.ႤႷ()
				.CtyInfoFromCall(Ⴗ());
			int num = (((CtyInfo)obj == null) ? 10 : 9);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႣ[163] - 57912;
					continue;
				case 11:
					break;
				case 9:
					SetDxOutput.Ⴀ(Dx, ShowUptime.Ⴄ(obj as CtyInfo, 767, 724), '\u033b', '\u0308');
					num = 5;
					continue;
				case 5:
					AnnSpotHelp.Ⴃ(Dx, SetStationMacros.Ⴐ(obj as CtyInfo, 348, 'ě'), 642, 'ʋ');
					num = ⴀ[95] - 5675;
					continue;
				case 6:
					ShowDxOptionsHelp.Ⴍ(Dx, ShowDxFilter.Ⴈ(obj as CtyInfo, 'η', 'Ͼ'), 822, 861);
					goto case 17;
				case 17:
					num = 12;
					continue;
				case 12:
					WwvHelp.Ⴐ(Dx, qslinfoSoapClient.Ⴈ(obj as CtyInfo, 'ˣ', 762), 'Ϋ', 916);
					num = 7;
					continue;
				case 7:
					num = (ByeHelp.Ⴍ(ShowVersion.Ⴐ(Dx, 96, 29), ReplyMailHelp.Ⴄ(14, null, 1057162207, 4), 998, 897) ? 4 : 3);
					continue;
				case 3:
				case 14:
					num = ((!ByeHelp.Ⴍ(ShowVersion.Ⴐ(Dx, 247, 138), CallBlockCacheCfg.Ⴅ(null, 3, 62057566, null), 35, 68)) ? 10 : 4);
					continue;
				case 4:
					obj2 = P_0.Ⴍ().Ⴅ().Ⴀ()
						.UsVeCallbook.Search(Ⴗ());
					num = (((CallbookData)obj2 == null) ? 10 : (ⴍႭ[115] - 12342));
					continue;
				case 16:
					WxHelp.Ⴗ(Dx, BadWordCacheCfg.Ⴅ((CallbookData)obj2, 43, 66), 'ʰ', 'ʆ');
					num = ⴀႣ[27] - 42949;
					continue;
				case 8:
					Dx.Name = ((CallbookData)obj2).FirstName;
					num = ((!(Dx.Cty == ReplyMailHelp.Ⴄ(20, null, 1057162202, 1))) ? 1 : 15);
					continue;
				case 15:
					Dx.Name = ((CallbookData)obj2).FirstName;
					Dx.County = ((CallbookData)obj2).County;
					num = 2;
					continue;
				case 2:
					Dx.ArrlSection = ((CallbookData)obj2).ArrlSection;
					goto case 13;
				case 13:
					Dx.Grid = (obj2 as CallbookData).Grid;
					goto case 1;
				case 1:
					return true;
				case 10:
					return false;
				}
				break;
			}
		}
	}

	public bool IsValid(NodeUserCmd cmd)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		while (true)
		{
			int num = (Ⴐ() ? (ⴀႨ[227] - 31286) : 5);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႭ[542];
					continue;
				case 25:
					break;
				case 5:
					Ⴀ(cmd, ReplyMail.Ⴅ(5, 7, 1217943578), false);
					return false;
				case 33:
					num = ((!Ⴅ()) ? (ⴃႠ[267] - 19270) : 26);
					continue;
				case 26:
					Ⴀ(cmd, ႰႥ.Ⴅ(6, '~', 952620179), false);
					return false;
				case 14:
					num = ((CallBlockCacheCfg.Ⴜ(WxHelp.Ⴀ(Dx, 68, 89), 146, 243) >= 3) ? (ⴃႥ[78] - 62892) : (ⴀ[435] - 13730));
					continue;
				case 30:
					Ⴀ(cmd, ReplyMailHelp.Ⴄ(22, null, 1057161894, 4), false);
					num = 20;
					continue;
				case 8:
				case 20:
					return false;
				case 19:
					num = (ႷႷ.Ⴍ(Ⴗ(), 869, '\u0368') ? (ⴀႳ[144] - 30554) : 7);
					continue;
				case 7:
					Ⴀ(cmd, CallBlockCacheCfg.Ⴅ(null, 1, 62056887, null), false);
					num = 16;
					continue;
				case 16:
					return false;
				case 18:
					num = (ႷႷ.Ⴍ(Ⴃ(), 954, 'η') ? 9 : ⴐ[21]);
					continue;
				case 3:
				case 22:
				case 27:
					Ⴀ(cmd, ReplyMailHelp.Ⴄ(28, null, 1057163038, 2), false);
					num = ⴀႳ[258] - 27256;
					continue;
				case 35:
					return false;
				case 9:
					num = (cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႤ()
						.Ⴈ(SetDxExtensionHelp.Ⴍ(Dx, '¶', '¤')) ? 34 : (ⴃႰ[114] - 38455));
					continue;
				case 29:
					Ⴀ(cmd, ShowWxHelp.Ⴍ('\u001e', 985808111, 2), false);
					return false;
				case 34:
					num = (cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႤ()
						.Ⴈ(Ⴗ()) ? 32 : (ⴃႥ[109] - 17152));
					continue;
				case 10:
					Ⴀ(cmd, ShowSkimCtyHelp.Ⴍ(1216134239, 6, '7'), false);
					return false;
				case 32:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႭ()
						.Ⴃ(Ⴗ())) ? (ⴄႤ[520] + 3) : (ⴃႥ[5] - 12769));
					continue;
				case 2:
					Ⴀ(cmd, ႰႥ.Ⴅ(3, 'ù', 952619461), false);
					return false;
				case 31:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႥ()
						.IsBlocked(Ⴗ())) ? 21 : 4);
					continue;
				case 4:
					Ⴀ(cmd, ReplyMail.Ⴅ(5, 6, 1217943610), false);
					return false;
				case 21:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႥ()
						.IsBlocked(Ⴃ())) ? 11 : (ⴃႥ[168] - 13134));
					continue;
				case 12:
					Ⴀ(cmd, SetStationQth.Ⴍ(null, 1687352320, 6, 0), false);
					num = 24;
					continue;
				case 24:
					return false;
				case 11:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႥ()
						.IsBlocked(ShowPrefix.Ⴍ(Dx, 664, 683))) ? (ⴍႭ[370] - 25899) : 6);
					continue;
				case 6:
					Ⴀ(cmd, CallBlockCacheCfg.Ⴅ(null, 8, 62056867, null), false);
					num = 1;
					continue;
				case 1:
					return false;
				case 13:
					num = (ShowWwvHelp.Ⴗ(AnnHelp.Ⴈ(Date, SetTalkCount.Ⴗ(2, null, 1267022529, typeof(ShowUptime)), Ⴀ(), 465, 'Ǧ'), 'Ů', 331) ? 28 : 15);
					continue;
				case 15:
					Ⴀ(cmd, ShowSkimCtyHelp.Ⴍ(1216134256, 2, '\u0096'), false);
					return false;
				case 28:
					num = ((!UtilsNumeric.IsNumeric(Ⴗ())) ? (ⴍႤ[361] - 48023) : ⴅ[6]);
					continue;
				case 0:
					Ⴀ(cmd, ShowWxHelp.Ⴍ('K', 985808075, 2), false);
					return false;
				case 23:
					return true;
				}
				break;
			}
		}
	}

	private bool Ⴅ()
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		while (true)
		{
			DateTime dateTime = TalkSpotHelp.Ⴈ(Dx, 253, '\u008c');
			TimeSpan timeSpan = DirectoryBulletinHelp.Ⴓ(ref dateTime, ShowAnnHelp.Ⴅ('\u0342', 883), 887, '\u0340');
			int num = 7;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 5;
					continue;
				case 5:
					break;
				case 2:
				case 7:
					num = ((!(Math.Abs(timeSpan.TotalMinutes) > 20.0)) ? (ⴀႨ[216] - 59552) : (ⴍႭ[252] - 23370));
					continue;
				case 4:
				case 6:
					return true;
				case 1:
					return false;
				}
				break;
			}
		}
	}

	private string Ⴜ(NodeUserCmd P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		while (true)
		{
			ISerializable serializable = new StringBuilder();
			ႷႰ.Ⴅ(serializable as StringBuilder, global::Ⴈ.ႨႨ.Ⴀ(2, 3, 1157902486), '\u034c', 'ͼ');
			int num = ⴄႤ[135] + ⴄႤ[135];
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
				case 10:
					ႷႰ.Ⴅ((StringBuilder)serializable, SetWxCountHelp.Ⴗ((object)ShowVersion.Ⴐ(Dx, 245, 137), (object)':', 42, (short)81), 'Ɵ', 'Ư');
					goto case 1;
				case 1:
					num = ⴀ[460] - 8779;
					continue;
				case 0:
				case 5:
					ႷႰ.Ⴅ((StringBuilder)serializable, ႨႭ(ShowClusterHelp.Ⴈ((StringBuilder)serializable, 626, 574)), '\u033e', '\u030e');
					goto case 2;
				case 2:
					num = 3;
					continue;
				case 3:
					ႷႰ.Ⴅ(serializable as StringBuilder, CallBlockCacheCfg.Ⴅ(null, 2, 62058417, null), 'å', 'Õ');
					num = 7;
					continue;
				case 7:
					(serializable as StringBuilder).Append(WxHelp.Ⴀ(Dx, 426, 439).PadRight(13));
					num = 4;
					continue;
				case 4:
					(serializable as StringBuilder).Append(Dx.Comment.PadRight(31));
					((StringBuilder)serializable).Append(Time);
					num = ⴀ[82] - 36549;
					continue;
				case 8:
					((StringBuilder)serializable).Append('Z');
					return ((StringBuilder)serializable).ToString();
				}
				break;
			}
		}
	}

	private string ႨႭ(int P_0)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		while (true)
		{
			IConvertible convertible = SetWxCountHelp.Ⴗ((object)' ', (object)Ⴄ(), 1021, (short)902);
			while (true)
			{
				IL_005a:
				int num = ((P_0 + CallBlockCacheCfg.Ⴜ((string)convertible, 198, 167) < 35) ? 5 : 0);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႰ[112] - 2873;
						continue;
					case 6:
						break;
					case 2:
						goto IL_005a;
					case 1:
					case 5:
						return Ⴄ().PadLeft(24 - P_0);
					case 0:
					case 3:
						return convertible as string;
					}
					break;
				}
				break;
			}
		}
	}

	private void ႨႨ(NodeUserCmd P_0)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 8;
		object obj2 = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj2 = new DxCmdMsgExt();
				((DxCmdMsgExt)obj2).Lotw = ShowPrefixCallsHelp.Ⴈ(Dx, '½', 168);
				num = 3;
				break;
			case 3:
				(obj2 as DxCmdMsgExt).Skimmer = ShowPrefixCallsHelp.Ⴈ(Dx, 'Ȩ', 572);
				(obj2 as DxCmdMsgExt).Cty = ShowVersion.Ⴐ(Dx, 693, 712);
				goto case 9;
			case 9:
				num = 5;
				break;
			case 5:
				(obj2 as DxCmdMsgExt).State = ((CallBlockCacheCfg.Ⴜ(MailCacheCfg.Ⴅ(Dx, 892, '\u030e'), 189, 220) == 0) ? string.Empty : MailCacheCfg.Ⴅ(Dx, 185, 'Ë'));
				((DxCmdMsgExt)obj2).ArrlSection = ((CallBlockCacheCfg.Ⴜ(MailCacheCfg.Ⴅ(Dx, 596, 'ȧ'), 24, 121) == 0) ? ShowWxHelp.Ⴍ('×', 985807904, 8) : MailCacheCfg.Ⴅ(Dx, 728, 'ʫ'));
				((DxCmdMsgExt)obj2).County = ((CallBlockCacheCfg.Ⴜ(MailCacheCfg.Ⴅ(Dx, 233, '\u009d'), 211, 178) == 0) ? ShowWxHelp.Ⴍ('\u0092', 985807904, 8) : MailCacheCfg.Ⴅ(Dx, 590, 'Ⱥ'));
				((DxCmdMsgExt)obj2).Mode = ShowVersion.Ⴐ(Dx, 370, 268);
				num = 2;
				break;
			case 2:
				((DxCmdMsgExt)obj2).CqZone = SendMail.Ⴐ(Dx, 955, 'ϸ');
				((DxCmdMsgExt)obj2).ItuZone = SetStationGridHelp.Ⴓ(Dx, 449, 418);
				num = ⴃႰ[118] - ⴃႰ[118];
				break;
			case 0:
				(obj2 as DxCmdMsgExt).Name = ShowNodesHelp.Ⴓ(Dx, 156, '\u009b');
				((DxCmdMsgExt)obj2).Grid = Dx.Grid;
				num = ⴀႼ[134] - 144;
				break;
			case 1:
			case 7:
				((DxCmdMsgExt)obj2).SpotterCty = Dx.SpotterCty;
				((DxCmdMsgExt)obj2).SpotterState = ((Dx.SpotterState.Length == 0) ? string.Empty : Dx.SpotterState);
				(obj2 as DxCmdMsgExt).SpotterCont = ((Dx.SpotterCont.Length == 0) ? string.Empty : Dx.SpotterCont);
				(obj2 as DxCmdMsgExt).SkimmerQuality = Dx.SkimQualityFlag;
				obj = (DxCmdMsgExt)obj2;
				num = 4;
				break;
			case 4:
				P_0.Tx.DxCmdMsgExt = (DxCmdMsgExt)obj;
				return;
			case 6:
				return;
			}
		}
	}

	private void ႨႠ(NodeUserCmd P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 19;
		object obj = default(object);
		ISerializable serializable = default(ISerializable);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new StringBuilder();
				ႷႰ.Ⴅ(obj as StringBuilder, ShowSkimCtyHelp.Ⴍ(1216134152, 4, ';'), 'Ŧ', 'Ŗ');
				num = 13;
				break;
			case 13:
			{
				StringBuilder obj2 = (StringBuilder)obj;
				float num2 = HealthMonitorCfg.Ⴓ(Dx, 785, 822);
				ႷႰ.Ⴅ(obj2, ShowDxOptionsHelp.Ⴅ(ref num2, global::Ⴈ.ႨႨ.Ⴀ(10, 2, 1157902496), 465, 'Ǔ'), 'Μ', 'ά');
				num = 3;
				break;
			}
			case 3:
				Help.Ⴍ(obj as StringBuilder, '^', 'ĉ', 'ď');
				ႷႰ.Ⴅ((StringBuilder)obj, WxHelp.Ⴀ(Dx, 888, 869), 'ϡ', 'ϑ');
				num = ⴍႭ[169] - 60521;
				break;
			case 6:
				Help.Ⴍ(obj as StringBuilder, '^', 'þ', 'ø');
				ႷႰ.Ⴅ(obj as StringBuilder, Date, '\u038d', 'ν');
				num = ⴄႷ[26] - 9164;
				break;
			case 4:
				Help.Ⴍ((StringBuilder)obj, '^', 'ɥ', 'ɣ');
				ႷႰ.Ⴅ(obj as StringBuilder, Time, 'Ƽ', 'ƌ');
				num = 12;
				break;
			case 12:
				ႷႰ.Ⴅ((StringBuilder)obj, ReplyMail.Ⴅ(0, 7, 1217944031), 'ę', 'ĩ');
				num = 7;
				break;
			case 7:
				ႷႰ.Ⴅ((StringBuilder)obj, SetDxExtensionHelp.Ⴍ(Dx, 'ʕ', 'ʇ'), 'ϼ', 'ό');
				num = 23;
				break;
			case 23:
				Help.Ⴍ((StringBuilder)obj, '^', 'ɀ', 'Ɇ');
				goto case 16;
			case 16:
				ႷႰ.Ⴅ((StringBuilder)obj, ShowVersion.Ⴐ(Dx, 429, 465), 'ĸ', 'Ĉ');
				num = ⴄႷ[4] - 30631;
				break;
			case 21:
				Help.Ⴍ(obj as StringBuilder, '^', 'ͷ', 'ͱ');
				ႷႰ.Ⴅ(obj as StringBuilder, ShowPrefix.Ⴍ(Dx, 387, 432), '\u0344', 'ʹ');
				num = ⴍႤ[378] - 55423;
				break;
			case 22:
				serializable = new StringBuilder();
				SetStationNeedsHelp.Ⴐ(serializable as StringBuilder, (object)(obj as StringBuilder), (short)899, 897);
				num = 15;
				break;
			case 15:
				ShowLog.Ⴅ(serializable as StringBuilder, ShowSkimCtyHelp.Ⴍ(1216134152, 4, '^'), SetTalkCount.Ⴗ(0, null, 1267023137, typeof(qslinfoSoapChannel)), 44, '\\');
				num = 17;
				break;
			case 17:
				Help.Ⴍ(serializable as StringBuilder, '^', '}', '{');
				ႷႰ.Ⴅ(serializable as StringBuilder, ShowVersion.Ⴐ(Dx, 353, 284), '\u02fc', 'ˌ');
				num = 10;
				break;
			case 10:
				Help.Ⴍ((StringBuilder)serializable, '^', 'ȅ', 'ȃ');
				WwvSpotUserHelp.Ⴍ(serializable as StringBuilder, StationHelp.Ⴗ(Dx, '¡', 140), 'ǔ', 403);
				num = 8;
				break;
			case 0:
			case 8:
				(serializable as StringBuilder).Append('^');
				(serializable as StringBuilder).Append(Dx.Mode);
				num = 2;
				break;
			case 2:
				((StringBuilder)serializable).Append('^');
				(serializable as StringBuilder).Append(Dx.CqZone);
				num = 5;
				break;
			case 5:
				((StringBuilder)serializable).Append('^');
				((StringBuilder)serializable).Append(Dx.ItuZone);
				num = 14;
				break;
			case 14:
				((StringBuilder)serializable).Append(ShowSkimCtyHelp.Ⴍ(1216133781, 6, '0'));
				(serializable as StringBuilder).Append(Dx.SpotterCty);
				num = 9;
				break;
			case 9:
				(serializable as StringBuilder).Append('^');
				((StringBuilder)serializable).Append(Dx.SpotterState);
				num = 20;
				break;
			case 20:
				(obj as StringBuilder).Append(SetStationQth.Ⴍ(null, 1687351534, 5, 13));
				num = 11;
				break;
			case 11:
				P_0.Tx.Pcxx = (obj as StringBuilder).ToString();
				goto case 1;
			case 1:
				(serializable as StringBuilder).Append(SetStationQth.Ⴍ(null, 1687351529, 2, 10));
				num = 18;
				break;
			case 18:
				P_0.Tx.Arxx = (serializable as StringBuilder).ToString();
				return;
			}
		}
	}

	private bool Ⴍ()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		while (true)
		{
			int num = ((HealthMonitorCfg.Ⴓ(Dx, 989, 1018) == 1800f) ? 13 : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႨ[40] - 39548;
					continue;
				case 9:
					break;
				case 0:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 787, 820) == 3500f) ? 13 : (ⴍႤ[415] - 11564));
					continue;
				case 2:
				case 14:
				case 15:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 497, 470) == 7000f) ? 13 : (ⴍႤ[23] - 41757));
					continue;
				case 7:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 161, 134) == 10100f) ? (ⴍႭ[19] - 38506) : (ⴀႼ[110] - 212));
					continue;
				case 11:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 235, 204) == 14000f) ? 13 : 4);
					continue;
				case 4:
				case 6:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 99, 68) != 18068f) ? 1 : (ⴀႼ[67] - 221));
					continue;
				case 1:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 382, 345) == 21000f) ? 13 : 10);
					continue;
				case 10:
				{
					float freq = Dx.Freq;
					ႨႣ.Ⴐ[64] = (byte)((ႨႣ.Ⴐ[64] + ႨႣ.Ⴐ[55]) & 0x80);
					num = ((freq == 24890f) ? (ⴀ[36] - 64290) : 8);
					continue;
				}
				case 8:
					num = ((Dx.Freq == 28000f) ? (ⴍႤ[259] - 27497) : 12);
					continue;
				case 12:
					num = ((Dx.Freq == 50000f) ? 13 : (ⴃႰ[203] - 59430));
					continue;
				case 3:
					return Dx.Freq == 144000f;
				case 13:
					return true;
				}
				break;
			}
		}
	}

	private bool Ⴐ()
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		while (true)
		{
			int num = ((!(HealthMonitorCfg.Ⴓ(Dx, 704, 743) >= 1800f)) ? (ⴍႭ[81] - 9393) : (ⴀ[73] - 59782));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴍႤ[488] - 14173;
					continue;
				case 27:
					break;
				case 19:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 392, 431) <= 2000f) ? 18 : ⴄႭ[498]);
					continue;
				case 63:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 10, 45) >= 3500f)) ? (ⴃႰ[73] - 48487) : 61);
					continue;
				case 61:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 318, 281) <= 4000f) ? 18 : 60);
					continue;
				case 60:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 373, 338) >= 7000f)) ? 37 : (ⴃႥ[126] - 63561));
					continue;
				case 47:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 319, 280) <= 7300f) ? 18 : (ⴍႤ[110] - 58405));
					continue;
				case 37:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 318, 281) >= 10100f)) ? (ⴀ[414] - 8959) : 53);
					continue;
				case 53:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 997, 962) <= 10150f) ? (ⴍႭ[238] - 48038) : 48);
					continue;
				case 48:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 519, 544) >= 14000f)) ? (ⴄႷ[113] - 58458) : (ⴀႳ[27] - 42055));
					continue;
				case 4:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 361, 334) <= 14350f) ? (ⴀ[307] - 27819) : 13);
					continue;
				case 13:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 314, 285) >= 18068f)) ? (ⴀႨ[204] - 1987) : (ⴄႤ[155] / 3));
					continue;
				case 15:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 822, 785) <= 18168f) ? ⴅ[147] : (ⴃႥ[231] - 57187));
					continue;
				case 57:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 219, 252) >= 21000f)) ? 25 : 41);
					continue;
				case 38:
				case 41:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 689, 662) <= 21450f) ? (ⴃႥ[78] - 62893) : (ⴀႳ[300] - 10793));
					continue;
				case 25:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 923, 956) >= 24890f)) ? 42 : 12);
					continue;
				case 12:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 491, 460) <= 24990f) ? ⴐ[136] : 42);
					continue;
				case 42:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 785, 822) >= 28000f)) ? 31 : (ⴍႭ[333] - 17070));
					continue;
				case 64:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 142, 169) <= 30000f) ? (ⴀ[450] - 56807) : 31);
					continue;
				case 31:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 575, 536) >= 50000f)) ? 8 : (ⴃႥ[315] - 42361));
					continue;
				case 28:
				case 39:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 282, 317) <= 54000f) ? (ⴄႭ[14] - 169) : 8);
					continue;
				case 8:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 471, 496) >= 144000f)) ? 7 : 32);
					continue;
				case 32:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 940, 907) <= 148000f) ? 18 : 7);
					continue;
				case 7:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 247, 208) >= 5330f)) ? (ⴀႣ[297] - 335) : 23);
					continue;
				case 23:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 310, 273) <= 5408f) ? (ⴍႭ[19] - 38501) : (ⴃႠ[304] - 2891));
					continue;
				case 16:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 55, 16) >= 420000f)) ? 45 : (ⴀႼ[127] - ⴀႼ[33]));
					continue;
				case 30:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 850, 885) <= 450000f) ? 18 : 45);
					continue;
				case 45:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 849, 886) >= 219000f)) ? 21 : (ⴀႼ[85] - ⴀႼ[57]));
					continue;
				case 26:
				case 59:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 556, 523) <= 225000f) ? 18 : 21);
					continue;
				case 21:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 531, 564) >= 902000f)) ? 62 : (ⴀ[447] - 45795));
					continue;
				case 29:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 831, 792) <= 928000f) ? 18 : 62);
					continue;
				case 62:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 862, 889) >= 1240000f)) ? (ⴍႤ[231] - 55796) : ⴐ[338]);
					continue;
				case 24:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 432, 407) <= 1300000f) ? (ⴃႰ[112] - 2861) : 54);
					continue;
				case 54:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 5, 34) >= 2300000f)) ? 43 : 11);
					continue;
				case 11:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 241, 214) <= 2310000f) ? (ⴀႣ[209] - 53585) : (ⴀႳ[214] - 16966));
					continue;
				case 43:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 544, 519) >= 2390000f)) ? (ⴀႨ[147] - 30785) : 3);
					continue;
				case 3:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 264, 303) <= 2450000f) ? 18 : 52);
					continue;
				case 52:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 745, 718) >= 3300000f)) ? 10 : 20);
					continue;
				case 20:
					num = ((HealthMonitorCfg.Ⴓ(Dx, 7, 32) <= 3500000f) ? (ⴀ[33] - 16113) : (ⴐ[275] - ⴐ[179]));
					continue;
				case 10:
					num = ((!(HealthMonitorCfg.Ⴓ(Dx, 873, 846) >= 5650000f)) ? (ⴄႷ[22] - 7299) : 0);
					continue;
				case 0:
					num = ((Dx.Freq <= 5925000f) ? 18 : 33);
					continue;
				case 33:
					num = ((!(Dx.Freq >= 10000000f)) ? (ⴍႤ[197] - 5309) : 49);
					continue;
				case 49:
					num = ((Dx.Freq <= 10500000f) ? (ⴍႤ[199] - 19058) : 14);
					continue;
				case 14:
					num = ((!(Dx.Freq >= 24000000f)) ? 34 : 9);
					continue;
				case 9:
					num = ((Dx.Freq <= 24250000f) ? 18 : 34);
					continue;
				case 34:
					num = ((!(Dx.Freq >= 47000000f)) ? 55 : (ⴍႭ[157] - 60954));
					continue;
				case 50:
					num = ((Dx.Freq <= 47200000f) ? 18 : 55);
					continue;
				case 55:
					num = ((Dx.Freq >= 76000000f) ? 1 : 51);
					continue;
				case 1:
					num = ((Dx.Freq <= 81000000f) ? 18 : (ⴀႼ[139] * 3));
					continue;
				case 51:
					num = ((!(Dx.Freq >= 122250000f)) ? 6 : (ⴍႭ[173] - 9034));
					continue;
				case 58:
					num = ((Dx.Freq <= 123000000f) ? (ⴃႠ[56] - 20621) : (ⴃႥ[110] - 54590));
					continue;
				case 6:
					num = ((!(Dx.Freq >= 134000000f)) ? 2 : 56);
					continue;
				case 56:
					num = ((Dx.Freq <= 141000000f) ? (ⴀႣ[88] - 11508) : ⴄႭ[246]);
					continue;
				case 2:
					num = ((!(Dx.Freq >= 241000000f)) ? 40 : 36);
					continue;
				case 36:
					num = ((Dx.Freq <= 250000000f) ? 18 : 40);
					continue;
				case 40:
					num = ((!(Dx.Freq >= 70000f)) ? 22 : 46);
					continue;
				case 46:
					num = ((Dx.Freq <= 70500f) ? 18 : 22);
					continue;
				case 22:
					num = ((!(Dx.Freq >= 5200f)) ? 65 : (ⴍႤ[307] - 52330));
					continue;
				case 35:
					num = ((Dx.Freq <= 5500f) ? 18 : 65);
					continue;
				case 65:
					num = ((!(Dx.Freq >= 135f)) ? 5 : 17);
					continue;
				case 17:
					num = ((Dx.Freq <= 137f) ? 18 : (ⴃႥ[194] - 55719));
					continue;
				case 5:
					return Dx.Freq >= 275000000f;
				case 18:
					return true;
				}
				break;
			}
		}
	}

	static DxSpotBase()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				DxSpotBase.m_Ⴗ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216134167, 3, '\u000e'), 315, 294);
				break;
			case 4:
				break;
			case 1:
			case 2:
			case 3:
				DxSpotBase.m_Ⴈ = 0;
				return;
			}
			num = 2;
		}
	}
}
