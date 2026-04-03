using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;

namespace ArcEngine.ArcServerConfig;

public class AppLogCfg
{
	private bool Ⴓ;

	private bool Ⴐ;

	private bool Ⴄ;

	private bool Ⴍ;

	private DxClusterCacheCfg.Ⴈ m_Ⴜ;

	public bool LogTelnetInboundTraffic
	{
		get
		{
			return this.m_Ⴜ.Ⴄ;
		}
		set
		{
			bool ⴄ = value;
			this.m_Ⴜ.Ⴄ = ⴄ;
		}
	}

	public bool LogTelnetOutboundTraffic
	{
		get
		{
			return Ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	public bool LogArc6NodeTraffic
	{
		get
		{
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			bool ⴀ = this.m_Ⴜ.Ⴀ;
			SetTalkCountHelp.Ⴅ[418] = (byte)((SetTalkCountHelp.Ⴅ[418] * SetTalkCountHelp.Ⴅ[7]) & 0xC8);
			return ⴀ;
		}
		set
		{
			bool ⴀ = value;
			this.m_Ⴜ.Ⴀ = ⴀ;
		}
	}

	public bool LogArc6ClientTraffic
	{
		get
		{
			bool ⴐ = Ⴐ;
			BandModeCacheCfg.ႠႳ[176] = (char)((BandModeCacheCfg.ႠႳ[176] * BandModeCacheCfg.ႠႳ[328]) & 0x26);
			return ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	public bool LogPcxxTraffic
	{
		get
		{
			char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
			return this.m_Ⴜ.Ⴗ;
		}
		set
		{
			bool ⴗ = value;
			this.m_Ⴜ.Ⴗ = ⴗ;
		}
	}

	public bool LogAgwBpqTraffic
	{
		get
		{
			char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	public bool LogDxDupes
	{
		get
		{
			bool ⴃ = this.m_Ⴜ.Ⴃ;
			SetWxOutput.ႣႰ[29] = (char)((SetWxOutput.ႣႰ[29] | SetWxOutput.ႣႰ[47]) & 0x18);
			return ⴃ;
		}
		set
		{
			bool ⴃ = value;
			this.m_Ⴜ.Ⴃ = ⴃ;
		}
	}

	public bool LogAnnWxDupes
	{
		get
		{
			return this.m_Ⴜ.Ⴓ;
		}
		set
		{
			bool ⴓ = value;
			this.m_Ⴜ.Ⴓ = ⴓ;
		}
	}

	public bool LogWwvDupes
	{
		get
		{
			return Ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : string where _0021_00211 : AnnWxSpot
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 7;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴃႰ[143] - 1469;
				break;
			case 9:
				num = (((P_3 ^ P_2) - 88) ^ num3) switch
				{
					0 => 2, 
					1 => 1, 
					2 => 6, 
					_ => 11, 
				};
				break;
			case 11:
				num = ⴀႼ[57] - 161;
				break;
			case 2:
				P_0.To = P_1;
				num = ⴃႥ[355] - 20618;
				break;
			case 1:
				P_0.SysopFlag = P_1;
				goto case 3;
			case 3:
			case 8:
				num = 4;
				break;
			case 6:
				P_0.SpotterNode = P_1;
				goto case 4;
			case 4:
				num3++;
				Arc4ServerClient.ႠႣ[226] = (char)((Arc4ServerClient.ႠႣ[226] ^ Arc4ServerClient.ႠႣ[194]) & 0xA0);
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = ⴃႠ[426] - 16010;
				break;
			case 0:
			case 5:
				num = ((num2 % 2 != 0) ? (ⴄႷ[120] - 46464) : 10);
				break;
			case 10:
				return;
			}
		}
	}
}
