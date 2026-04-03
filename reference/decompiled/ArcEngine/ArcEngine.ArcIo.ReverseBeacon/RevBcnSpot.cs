using System;
using System.Security;
using System.Xml.Serialization;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
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
using Ⴈ;

namespace ArcEngine.ArcIo.ReverseBeacon;

[XmlRoot("rs")]
public class RevBcnSpot
{
	private string Ⴄ;

	private string Ⴅ;

	private string Ⴀ;

	private string Ⴍ;

	private string Ⴓ;

	private string Ⴜ;

	private SetStationBeepHelp.Ⴍ ႰႤ = new SetStationBeepHelp.Ⴍ();

	[XmlElement("id")]
	public string Id
	{
		get
		{
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	[XmlElement("de")]
	public string Spotter
	{
		get
		{
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			return Ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	[XmlElement("qrg")]
	public string Freq
	{
		get
		{
			return ႰႤ.Ⴐ;
		}
		set
		{
			ႰႤ.Ⴐ = value as string;
		}
	}

	[XmlElement("dx")]
	public string Call
	{
		get
		{
			string ⴅ = ႰႤ.Ⴅ;
			AnnCacheCfg.ႠႼ[10] = (byte)(AnnCacheCfg.ႠႼ[10] & AnnCacheCfg.ႠႼ[46] & 0x7C);
			return ⴅ;
		}
		set
		{
			ႰႤ.Ⴅ = value;
			SetAnnMode.ႤႭ[408] = SetTalkCountHelp.Ⴅ[210];
		}
	}

	[XmlElement("db")]
	public string Snr
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	[XmlElement("wpm")]
	public string Wpm
	{
		get
		{
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			return Ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	[XmlElement("utc")]
	public string Utc
	{
		get
		{
			byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
			return Ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	[XmlElement("df")]
	public string Df
	{
		get
		{
			return ႰႤ.Ⴃ;
		}
		set
		{
			ႰႤ.Ⴃ = value;
		}
	}

	[XmlElement("b")]
	public string B
	{
		get
		{
			char[] ⴀ = SetAnnChatRooms.Ⴀ;
			return ႰႤ.Ⴈ;
		}
		set
		{
			ႰႤ.Ⴈ = value as string;
		}
	}

	[XmlElement("t")]
	public string T
	{
		get
		{
			string ⴜ = Ⴜ;
			IpLockoutCacheCfg.ႭႭ[291] = (char)((IpLockoutCacheCfg.ႭႭ[291] | IpLockoutCacheCfg.ႭႭ[264]) & 0xAA);
			return ⴜ;
		}
		set
		{
			Ⴜ = value;
		}
	}

	public override string ToString()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		IComparable comparable = default(IComparable);
		object obj = default(object);
		while (true)
		{
			int num = ((CallBlockCacheCfg.Ⴜ(Snr, 802, 835) != 1) ? 14 : (ⴃႥ[117] - 55996));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 11;
					continue;
				case 11:
				case 17:
					break;
				case 6:
					Snr = ShowUsersHelp.Ⴅ(SetTalkCount.Ⴗ(1, null, 1267022530, typeof(TalkCacheCfg)), Snr, 425, 487);
					goto case 14;
				case 14:
					num = ((CallBlockCacheCfg.Ⴜ(Wpm, 58, 91) != 1) ? (ⴃႰ[177] - 20356) : 9);
					continue;
				case 9:
				case 12:
					Wpm = ShowUsersHelp.Ⴅ(SetTalkCount.Ⴗ(7, null, 1267022532, typeof(ShowCluster.ႨႠ)), Wpm, 660, 730);
					goto case 4;
				case 4:
					T = (ByeHelp.Ⴍ(T, ReplyMail.Ⴅ(6, 9, 1217944966), 464, 439) ? ReplyMailHelp.Ⴄ(16, null, 1057163010, 5) : string.Empty);
					comparable = AnnHelp.Ⴈ(ႨႨ.Ⴀ(0, 3, 1157902486), Spotter, ႰႥ.Ⴅ(1, '\u009b', 952621755), 407, 'Ơ');
					num = ⴀႼ[134] - 138;
					continue;
				case 13:
					comparable = PublishInfo.Ⴄ((string)comparable, 24 - CallBlockCacheCfg.Ⴜ(Freq, 856, 825), ' ', 62, 29);
					num = 5;
					continue;
				case 5:
					comparable = qslinfoResponse.Ⴗ(comparable as string, Freq, CallBlockCacheCfg.Ⴅ(null, 1, 62058418, null), Call, 638, 'ȝ');
					num = 16;
					continue;
				case 16:
					obj = new string[7];
					(obj as string[])[0] = PublishInfo.Ⴄ((string)comparable, 39, ' ', 943, 908);
					num = 2;
					continue;
				case 2:
					(obj as string[])[1] = CallBlockCacheCfg.Ⴅ(null, 5, 62058422, null);
					num = 15;
					continue;
				case 15:
					(obj as string[])[2] = Snr;
					(obj as string[])[3] = SetStationQth.Ⴍ(null, 1687354555, 4, 10);
					num = ⴀႼ[37] - 22;
					continue;
				case 3:
					(obj as string[])[4] = Wpm;
					(obj as string[])[5] = ShowSkimCtyHelp.Ⴍ(1216132763, 2, 'j');
					num = 1;
					continue;
				case 1:
					((string[])obj)[6] = T;
					comparable = string.Concat((string[])obj);
					num = 10;
					continue;
				case 10:
					comparable = (comparable as string).PadRight(70, ' ') + Utc.Substring(0, 4) + ႨႨ.Ⴀ(12, 4, 1157903721);
					goto case 8;
				case 8:
					num = 0;
					continue;
				case 0:
					return (string)comparable;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Guid ႰႭ(short P_0, char P_1)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		Guid result = default(Guid);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 10;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 10:
					num2 = (((P_0 ^ P_1) - 120) ^ num) switch
					{
						0 => 5, 
						_ => 8, 
					};
					continue;
				case 0:
				case 8:
					result = default(Guid);
					num2 = 6;
					continue;
				case 3:
				case 5:
					result = Guid.NewGuid();
					num2 = ⴀႳ[26] - 61922;
					continue;
				case 6:
				case 7:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = ⴀႼ[96];
					continue;
				case 4:
					num2 = ((num3 % 2 != 0) ? 10 : (ⴃႰ[135] - 57445));
					continue;
				case 9:
					return result;
				case 1:
					num2 = ⴄႷ[113] - 58461;
					continue;
				}
				break;
			}
		}
	}
}
