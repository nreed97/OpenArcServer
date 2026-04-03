using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using ArcEngine.ArcCmds.Talk;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class SkimmerCtyCoverageData
{
	private static readonly ILog m_Ⴅ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(5, null, 1267023113, typeof(ႨႷ)), 536, 517);

	public readonly ConcurrentDictionary<string, DateTime> SkimmerCoverage;

	public SkimmerCtyCoverageData()
	{
		SkimmerCoverage = new ConcurrentDictionary<string, DateTime>();
	}

	internal void Ⴅ(DxSpot P_0)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
			{
				SkimmerCoverage.TryGetValue(ShowVersion.Ⴐ(P_0, 470, 426), out var _);
				goto case 1;
			}
			case 1:
				num = 4;
				continue;
			case 4:
			case 5:
			{
				DateTime dateTime = TalkSpotHelp.Ⴈ(P_0, 281, 'Ũ');
				return;
			}
			}
			if (SkimmerCoverage.ContainsKey(ShowVersion.Ⴐ(P_0, 190, 194)))
			{
				num = 0;
				continue;
			}
			SkimmerCoverage.TryAdd(P_0.Spotter, P_0.Dts);
			return;
		}
	}

	internal void Ⴓ(int P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			int num = 7;
			object obj = default(object);
			int num2 = default(int);
			KeyValuePair<string, DateTime> keyValuePair = default(KeyValuePair<string, DateTime>);
			TimeSpan timeSpan = default(TimeSpan);
			while (true)
			{
				switch (num)
				{
				default:
					obj = SkimmerCoverage.ToArray();
					num2 = 0;
					goto case 10;
				case 10:
					num = 2;
					continue;
				case 3:
					keyValuePair = ((KeyValuePair<string, DateTime>[])obj)[num2];
					timeSpan = SetWxMode.Ⴃ(ShowAnnHelp.Ⴅ('g', 86), keyValuePair.Value, 500, 442);
					num = 6;
					continue;
				case 6:
				case 9:
					num = ((ShowNodes.Ⴍ(ref timeSpan, 288, 'Ē') <= P_0) ? (ⴄႤ[320] - ⴄႤ[109]) : 5);
					continue;
				case 5:
				{
					SkimmerCoverage.TryRemove(keyValuePair.Key, out var _);
					num = 4;
					continue;
				}
				case 4:
					num2++;
					num = 2;
					continue;
				case 0:
				case 2:
					num = ((num2 < (obj as KeyValuePair<string, DateTime>[]).Length) ? 3 : (ⴀႳ[342] - 46504));
					continue;
				case 8:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			SkimmerCtyCoverageData.m_Ⴅ.Error((ex as Exception).Message);
		}
		switch (3)
		{
		}
	}
}
