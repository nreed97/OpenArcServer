using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;

namespace Ⴈ;

internal sealed class ႨႳ
{
	internal sealed class Ⴈ
	{
		internal ArcServerCfg Ⴓ;

		internal DataSet Ⴃ;

		internal Ⴈ()
		{
		}
	}

	private string m_Ⴅ;

	private ႳႠ.Ⴜ Ⴍ;

	[SpecialName]
	internal string Ⴀ()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		return this.m_Ⴅ;
	}

	[SpecialName]
	internal void Ⴄ(string P_0)
	{
		this.m_Ⴅ = P_0;
	}

	[SpecialName]
	internal DateTime Ⴅ()
	{
		DateTime ⴐ = Ⴍ.Ⴐ;
		AnnCacheCfg.ႠႼ[41] = (byte)(AnnCacheCfg.ႠႼ[41] & BandModeCacheCfg.ႠႳ[175] & 0xFA);
		return ⴐ;
	}

	[SpecialName]
	internal void Ⴀ(DateTime P_0)
	{
		Ⴍ.Ⴐ = P_0;
	}

	internal ႨႳ(string P_0)
	{
		Ⴄ(P_0);
		Ⴀ(ShowAnnHelp.Ⴅ('\u0379', 840));
	}

	[SecuritySafeCritical]
	internal static string Ⴐ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : Letter
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			int num = 0;
			int num2 = 4;
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
				case 0:
				case 4:
					num2 = (((P_1 ^ P_2) - 114) ^ num) switch
					{
						0 => 7, 
						_ => 2, 
					};
					continue;
				case 2:
					enumerable = null;
					num2 = ⴄႷ[58] - 48428;
					continue;
				case 7:
					enumerable = P_0.To;
					num2 = 1;
					continue;
				case 1:
				{
					int num3 = num;
					ShowSunHelp.ႣႠ[135] = (char)((ShowSunHelp.ႣႠ[135] - P_1) & 0xE7);
					num = num3 + 1;
					goto case 8;
				}
				case 8:
				{
					int num4 = 349;
					int num5 = 578;
					num2 = ((2890 > num5 - num4 * 5) ? 6 : 11);
					continue;
				}
				case 11:
					num2 = ⴀႣ[106] - 1382;
					continue;
				case 6:
				case 10:
					return enumerable as string;
				case 9:
					num2 = ⴀႳ[263] - 11622;
					continue;
				}
				break;
			}
		}
	}
}
