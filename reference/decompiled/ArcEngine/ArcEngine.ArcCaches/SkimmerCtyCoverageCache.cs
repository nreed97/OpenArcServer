using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcDatabase;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using log4net;

namespace ArcEngine.ArcCaches;

public sealed class SkimmerCtyCoverageCache
{
	private static readonly ILog Ⴀ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(6, null, 1267014383, typeof(TalkMaintenance)), 507, 486);

	public ConcurrentDictionary<string, SkimmerCtyCoverageData> CtyCoverageDict;

	public SkimmerCtyCoverageCache()
	{
		CtyCoverageDict = new ConcurrentDictionary<string, SkimmerCtyCoverageData>();
	}

	public int UpdateAndReturnCnt(DxSpot dx)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		SkimmerCtyCoverageData value = default(SkimmerCtyCoverageData);
		IComparable comparable = default(IComparable);
		while (true)
		{
			int num = ((!ByeHelp.Ⴍ(ShowVersion.Ⴐ(dx, 362, 279), string.Empty, 336, 311)) ? 11 : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႣ[323] - 12062;
					continue;
				case 6:
				case 13:
					break;
				case 0:
					return 0;
				case 11:
					value = null;
					comparable = ShowVersion.Ⴐ(dx, 853, 808);
					num = ((!ByeHelp.Ⴍ((string)comparable, ReplyMailHelp.Ⴄ(9, null, 1057162201, 2), 883, 788)) ? 8 : 4);
					continue;
				case 4:
					comparable = ShowUsersHelp.Ⴅ((string)comparable, SetStationGridHelp.Ⴓ(dx, 210, 177).ToString(), 134, 200);
					num = 8;
					continue;
				case 8:
					num = ((!CtyCoverageDict.ContainsKey(comparable as string)) ? (ⴀႼ[22] - ⴀႼ[1]) : 9);
					continue;
				case 9:
					CtyCoverageDict.TryGetValue((string)comparable, out value);
					goto case 5;
				case 5:
					num = ((value == null) ? (ⴍႭ[82] - 37565) : (ⴄႤ[474] - 57));
					continue;
				case 3:
					value.Ⴅ(dx);
					goto case 1;
				case 1:
					return value.SkimmerCoverage.Count;
				case 7:
					value = new SkimmerCtyCoverageData();
					value.Ⴅ(dx);
					CtyCoverageDict.TryAdd(comparable as string, value);
					num = ⴀႳ[291] - 40772;
					continue;
				case 12:
					return 1;
				}
				break;
			}
		}
	}

	internal void Ⴄ(int P_0)
	{
		try
		{
			int num = 5;
			object obj = default(object);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					obj = CtyCoverageDict.ToArray();
					num2 = 0;
					num = 0;
					continue;
				case 2:
				case 4:
				{
					KeyValuePair<string, SkimmerCtyCoverageData> keyValuePair = ((KeyValuePair<string, SkimmerCtyCoverageData>[])obj)[num2];
					keyValuePair.Value.Ⴓ(P_0);
					num = 8;
					continue;
				}
				case 1:
				case 8:
					num2++;
					num = 0;
					continue;
				case 0:
				case 3:
					num = ((num2 < ((KeyValuePair<string, SkimmerCtyCoverageData>[])obj).Length) ? 2 : 6);
					continue;
				case 6:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴀ.Error(SkimmerSpotBins.Ⴈ(ex as Exception, 433, 415));
		}
		switch (2)
		{
		}
	}
}
