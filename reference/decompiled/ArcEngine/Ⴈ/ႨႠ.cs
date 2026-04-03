using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using log4net;

namespace Ⴈ;

internal sealed class ႨႠ
{
	private static readonly ILog Ⴃ = SkimmerValidSpot.Ⴐ(ႰႥ.Ⴅ(4, '#', 952621936), 940, 945);

	private int m_Ⴗ;

	private SetStationQthHelp.Ⴈ m_Ⴓ = new SetStationQthHelp.Ⴈ();

	[SpecialName]
	internal int Ⴗ()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		return this.m_Ⴗ;
	}

	[SpecialName]
	internal void Ⴓ(int P_0)
	{
		this.m_Ⴗ = P_0;
	}

	[SpecialName]
	internal int Ⴍ()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		return this.m_Ⴓ.Ⴍ;
	}

	[SpecialName]
	internal void Ⴄ(int P_0)
	{
		this.m_Ⴓ.Ⴍ = P_0;
	}

	internal ႨႠ(int P_0, int P_1)
	{
		Ⴓ(P_0);
		Ⴄ(P_1);
	}

	internal static ႨႠ Ⴈ(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		object obj = default(object);
		try
		{
			int num = 7;
			int num4 = default(int);
			int num5 = default(int);
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			object obj3 = default(object);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num4 = ShowNodes.Ⴄ(P_0, SetStationClubHelp.Ⴍ(11, 2, 1747263291, null), 47, 16);
					num = 1;
					continue;
				case 1:
					num5 = ShowNodes.Ⴄ(P_0, CallBlockCacheCfg.Ⴅ(null, 5, 62055288, null), 687, 656);
					num = 0;
					continue;
				case 0:
					num = ((num4 <= 0) ? 14 : 10);
					continue;
				case 10:
					num = ((num5 <= 0) ? 14 : (ⴃႥ[198] - 55649));
					continue;
				case 9:
					enumerable = SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ(P_0, num4 - 3, 2, 852, 775), 753, 'ʱ');
					num = 13;
					continue;
				case 13:
					obj3 = SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ(P_0, num5 - 3, 2, 377, 298), 760, 'ʸ');
					num = 2;
					continue;
				case 2:
				case 5:
					num = ((!SkimmerValidSpot.Ⴈ(enumerable as string, 444, 456)) ? (ⴀႼ[128] / 3) : 3);
					continue;
				case 3:
					num = ((!SkimmerValidSpot.Ⴈ((string)obj3, 80, 36)) ? 14 : 4);
					continue;
				case 4:
				{
					int num2 = Convert.ToInt32((string)enumerable);
					int num3 = Convert.ToInt32((string)obj3);
					obj2 = new ႨႠ(num2, num3);
					num = ⴃႥ[262] - 48614;
					continue;
				}
				case 8:
				case 12:
					obj = obj2 as ႨႠ;
					break;
				case 11:
					break;
				case 14:
					goto IL_01c8;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴃ.Warn((ex as Exception).Message);
			goto IL_01c8;
		}
		goto IL_01ec;
		IL_01c8:
		switch (2)
		{
		default:
			return null;
		case 0:
		case 3:
		case 5:
			break;
		}
		goto IL_01ec;
		IL_01ec:
		return (ႨႠ)obj;
	}
}
