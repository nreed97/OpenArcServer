using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using log4net;

namespace ArcEngine.ArcCaches;

public sealed class SkimmerServerCache
{
	private static readonly ILog Ⴐ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(2, null, 1267023864, typeof(CtyCacheCfg)), 258, 287);

	public ConcurrentDictionary<string, SkimmerServerData> Dictionary;

	public SkimmerServerCache()
	{
		Dictionary = new ConcurrentDictionary<string, SkimmerServerData>();
	}

	public float Update(string call, SkimmerCt1bohCache.SkimmerQualityType quality)
	{
		while (true)
		{
			Dictionary.TryGetValue(call, out var value);
			int num = ((value != null) ? 6 : 7);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 1;
					continue;
				case 1:
					break;
				case 7:
					value = new SkimmerServerData(quality);
					value.Call = call;
					Dictionary.TryAdd(call, value);
					num = 3;
					continue;
				case 0:
				case 2:
				case 6:
					value.Ⴍ(quality);
					goto case 3;
				case 3:
				{
					float result = value.Ⴓ();
					IpLockoutCacheCfg.ႭႭ[193] = (char)((IpLockoutCacheCfg.ႭႭ[193] * DirectoryBulletin.ႠႨ[200]) & 0xFF);
					return result;
				}
				}
				break;
			}
		}
	}

	public void OneMinMaint()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		try
		{
			int num = 1;
			Array array = default(Array);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					array = Dictionary.ToArray();
					goto case 6;
				case 6:
					num2 = 0;
					num = 4;
					break;
				case 0:
				{
					KeyValuePair<string, SkimmerServerData> keyValuePair = ((KeyValuePair<string, SkimmerServerData>[])array)[num2];
					keyValuePair.Value.Ⴐ();
					num2++;
					num = ⴀႼ[96];
					break;
				}
				case 4:
				case 5:
					num = ((num2 >= ((KeyValuePair<string, SkimmerServerData>[])array).Length) ? (ⴃႠ[17] - 62735) : 0);
					break;
				case 3:
					return;
				}
			}
		}
		catch (Exception ex)
		{
			Ⴐ.Error(SkimmerSpotBins.Ⴈ(ex as Exception, 979, 1021));
		}
	}
}
