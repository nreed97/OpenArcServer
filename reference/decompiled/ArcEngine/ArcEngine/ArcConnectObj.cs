using System;
using System.Data;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;

namespace ArcEngine;

public class ArcConnectObj
{
	private string Ⴃ;

	private string Ⴐ;

	private SetStationLoginCmdsHelp.Ⴃ Ⴀ = new SetStationLoginCmdsHelp.Ⴃ();

	public string Call
	{
		get
		{
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	public ConnectStateType ConnectState
	{
		get
		{
			char[] ⴃႰ = SetWxOutput.ႣႰ;
			return Ⴀ.Ⴃ;
		}
		set
		{
			Ⴀ.Ⴃ = value;
		}
	}

	public string Cont
	{
		get
		{
			return Ⴀ.Ⴍ;
		}
		set
		{
			Ⴀ.Ⴍ = value;
		}
	}

	public string Cty
	{
		get
		{
			return Ⴀ.Ⴐ;
		}
		set
		{
			Ⴀ.Ⴐ = value;
		}
	}

	public string State
	{
		get
		{
			string ⴐ = Ⴐ;
			IpLockoutCacheCfg.ႭႭ[211] = (char)((IpLockoutCacheCfg.ႭႭ[211] * IpLockoutCacheCfg.ႭႭ[165]) & 0x8D);
			return ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	public string SwVersion
	{
		get
		{
			char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
			return Ⴀ.Ⴈ;
		}
		set
		{
			Ⴀ.Ⴈ = value;
		}
	}

	public string IpAddress
	{
		get
		{
			return Ⴀ.Ⴀ;
		}
		set
		{
			Ⴀ.Ⴀ = value as string;
		}
	}

	public Guid Id
	{
		get
		{
			return Ⴀ.Ⴅ;
		}
		set
		{
			Ⴀ.Ⴅ = value;
		}
	}

	public SerializableConcurrentDictionary<Guid, ArcConnectObj> ArcConnects
	{
		get
		{
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			return Ⴀ.Ⴓ;
		}
		set
		{
			Ⴀ.Ⴓ = value;
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211, _0021_00212>(_0021_00210 P_0, _0021_00211 P_1, _0021_00212 P_2, char P_3, char P_4) where _0021_00210 : DataRow where _0021_00211 : string
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴍႤ[104] - 43565;
				break;
			case 1:
				num = (((P_4 ^ P_3) - 19) ^ num2) switch
				{
					0 => 8, 
					_ => 7, 
				};
				break;
			case 7:
				num = 4;
				break;
			case 8:
				P_0[P_1] = P_2;
				goto case 2;
			case 2:
			case 4:
			case 6:
			case 9:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 != 0) ? 3 : 0);
				break;
			case 3:
				num = ⴄႷ[60] - 11697;
				break;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, byte P_1, int P_2, short P_3) where _0021_00210 : DxSpot
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 0;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_3 ^ P_2) - 116) ^ num2) switch
				{
					0 => 3, 
					_ => 5, 
				};
				break;
			case 5:
				num = ⴃႠ[204] - 17769;
				break;
			case 3:
				P_0.SkimWpm = P_1;
				goto case 2;
			case 2:
			case 9:
				num2++;
				goto case 1;
			case 1:
				num3 = 39;
				goto case 8;
			case 8:
			{
				int num4 = 71;
				num = ((426 > num4 - num3 * 6) ? 7 : 6);
				break;
			}
			case 6:
				num = ⴄႤ[50] / 6;
				break;
			case 7:
				return;
			}
		}
	}
}
