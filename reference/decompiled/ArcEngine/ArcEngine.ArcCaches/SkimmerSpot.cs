using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcDatabase;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class SkimmerSpot
{
	private string Ⴀ;

	private SkimmerCt1bohCache.SkimmerQualityType Ⴅ;

	private SetStationBeep.Ⴀ m_Ⴗ = new SetStationBeep.Ⴀ();

	public string Call
	{
		get
		{
			return this.m_Ⴗ.Ⴗ;
		}
		set
		{
			this.m_Ⴗ.Ⴗ = value as string;
		}
	}

	public string Spotter
	{
		get
		{
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	public int FreqHz
	{
		get
		{
			return this.m_Ⴗ.Ⴍ;
		}
		set
		{
			this.m_Ⴗ.Ⴍ = value;
		}
	}

	public DateTime DtsRx
	{
		get
		{
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			return this.m_Ⴗ.Ⴈ;
		}
		set
		{
			this.m_Ⴗ.Ⴈ = value;
		}
	}

	public SkimmerCt1bohCache.SkimmerQualityType QualityFlag
	{
		get
		{
			return Ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	public SkimmerSpot(string call, string spotter, float freq, DateTime dtsRx)
	{
		Call = call;
		Spotter = spotter;
		FreqHz = ShowUsersHelp.Ⴓ(freq * 1000f, 875, 782);
		DtsRx = dtsRx;
		QualityFlag = SkimmerCt1bohCache.SkimmerQualityType.Unknown;
	}

	public override string ToString()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		while (true)
		{
			Array array = new object[9];
			(array as object[])[0] = Call;
			((object[])array)[1] = SetTalkCount.Ⴗ(6, null, 1267022533, typeof(DxMaintenance));
			int num = ⴃႠ[17] - 62733;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႳ[96] - 54397;
					continue;
				case 7:
				case 9:
					break;
				case 5:
					(array as object[])[2] = Spotter;
					(array as object[])[3] = SetTalkCount.Ⴗ(8, null, 1267022539, typeof(DxClusterListCache));
					num = ⴍႭ[74] - 63173;
					continue;
				case 4:
					(array as object[])[4] = FreqHz;
					(array as object[])[5] = SetTalkCount.Ⴗ(8, null, 1267022539, typeof(SetAnnFilter));
					num = ⴄႷ[141] - 32628;
					continue;
				case 0:
				case 1:
				case 2:
					((object[])array)[6] = DtsRx;
					(array as object[])[7] = ShowSkimCtyHelp.Ⴍ(1216134126, 5, '¾');
					num = ⴃႥ[81] - 13216;
					continue;
				case 3:
					(array as object[])[8] = UserCacheCfg.Ⴃ((object)QualityFlag, 'ğ', 372);
					num = ⴐ[204];
					continue;
				case 6:
					return string.Concat((object[])array);
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : string
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[92];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[145];
					continue;
				case 7:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 21) ^ num) switch
					{
						0 => ⴀႣ[224] - 51413, 
						1 => 2, 
						_ => 12, 
					};
					continue;
				case 12:
					enumerable = null;
					goto case 3;
				case 3:
					num2 = 4;
					continue;
				case 6:
					enumerable = Path.GetDirectoryName(P_0);
					goto case 5;
				case 5:
					num2 = 4;
					continue;
				case 2:
					enumerable = UtilsSql.ScrubSqlToSqlSvrExpress(P_0);
					num2 = ⴀ[488] - 62078;
					continue;
				case 4:
				{
					num++;
					num3 = P_2 * P_2;
					int num4 = num3;
					ShowSunHelp.ႣႠ[318] = (char)((ShowSunHelp.ႣႠ[318] - SetTalkCountHelp.Ⴅ[381]) & 0x88);
					num3 = P_2 + num4;
					goto case 8;
				}
				case 8:
					num2 = 9;
					continue;
				case 9:
					num2 = ((num3 % 2 != 0) ? (ⴃႥ[185] - 8949) : 0);
					continue;
				case 0:
					return (string)enumerable;
				case 10:
					num2 = ⴀႣ[262] - 57912;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, short P_3) where _0021_00210 : string where _0021_00211 : BandModeUpdate
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 8;
		int num4 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = ⴐ[264] - 136;
				break;
			case 1:
			{
				int num3 = P_3 ^ P_2;
				SetWxOutput.ႣႰ[92] = (char)((SetWxOutput.ႣႰ[92] ^ P_3) & 0xCC);
				num = ((num3 - 19) ^ num4) switch
				{
					0 => ⴀႣ[219] - 19975, 
					_ => 9, 
				};
				break;
			}
			case 0:
			case 9:
				num = ⴀႳ[4] - 24693;
				break;
			case 6:
			case 7:
				P_0.Download(P_1);
				goto case 4;
			case 4:
				num4++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = 3;
				break;
			case 3:
				num = ((num2 % 2 != 0) ? 1 : (ⴄႤ[424] - 4));
				break;
			case 2:
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string[] Ⴐ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		Array array = default(Array);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႰ[143] - 1473;
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
					num2 = (((P_2 ^ P_1) - 127) ^ num) switch
					{
						0 => 6, 
						_ => ⴃႰ[65] - 51842, 
					};
					continue;
				case 1:
					array = null;
					goto case 0;
				case 0:
					num2 = 9;
					continue;
				case 6:
					array = Directory.GetFiles(P_0);
					num2 = ⴐ[136] - 9;
					continue;
				case 9:
				{
					num++;
					int num3 = 674;
					int num4 = 6;
					num2 = ((337 < num3 / 2 - num4) ? (ⴃႠ[293] - 12948) : 7);
					continue;
				}
				case 7:
				case 8:
					return array as string[];
				case 4:
				case 10:
					num2 = ⴃႥ[329] - 21278;
					continue;
				}
				break;
			}
		}
	}
}
