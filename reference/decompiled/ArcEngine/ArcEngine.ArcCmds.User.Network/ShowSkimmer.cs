using System;
using System.Collections.Generic;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcDatabase;
using ArcEngine.ArcServerConfig.Caches;
using log4net;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ShowSkimmer : IArcCmd
{
	private sealed class ႥႨ
	{
		public NodeUserCmd Ⴗ;

		public void Ⴐ(SkimmerServerData P_0)
		{
			Ⴗ.Tx.Msg.Add(UserCacheCfg.Ⴃ((object)P_0, '0', 91));
		}
	}

	private static readonly ILog Ⴃ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(1, null, 1267020451, typeof(AnnLocalUser)), 943, 946);

	private static Comparison<SkimmerServerData> Ⴄ;

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		object obj = null;
		object obj2 = new ႥႨ();
		(obj2 as ႥႨ).Ⴗ = cmd;
		try
		{
			int num = 5;
			object obj5 = default(object);
			object obj7 = default(object);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					(obj2 as ႥႨ).Ⴗ.Tx.DistroType = DistroType.ToRequester;
					(obj2 as ႥႨ).Ⴗ.Tx.Msg.Add(SetTalkCount.Ⴗ(5, null, 1267020507, typeof(WwvMaintenance)));
					num = 2;
					continue;
				case 2:
				case 11:
					(obj2 as ႥႨ).Ⴗ.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687352465, 2, 26));
					goto case 10;
				case 10:
					num = 8;
					continue;
				case 8:
				case 12:
					obj5 = new List<SkimmerServerData>();
					obj7 = ((ႥႨ)obj2).Ⴗ.Ⴍ().Ⴅ().Ⴀ()
						.ႨႳ()
						.SkimmerServerDataCache.Dictionary.ToArray();
					num = 6;
					continue;
				case 6:
					num2 = 0;
					num = ⴍႤ[111] - 53933;
					continue;
				case 1:
				{
					KeyValuePair<string, SkimmerServerData> keyValuePair = (obj7 as KeyValuePair<string, SkimmerServerData>[])[num2];
					(obj5 as List<SkimmerServerData>).Add(keyValuePair.Value);
					num = 4;
					continue;
				}
				case 4:
					num2++;
					num = ⴃႠ[414] - 54157;
					continue;
				case 7:
					num = ((num2 < (obj7 as KeyValuePair<string, SkimmerServerData>[]).Length) ? (ⴃႥ[319] - 38981) : 0);
					continue;
				case 0:
				{
					List<SkimmerServerData> obj4 = obj5 as List<SkimmerServerData>;
					if (Ⴄ == null)
					{
						Ⴄ = Ⴅ;
					}
					obj4.Sort(Ⴄ);
					List<SkimmerServerData> obj6 = (List<SkimmerServerData>)obj5;
					if (!(obj is Action<SkimmerServerData>))
					{
						obj = new Action<SkimmerServerData>(((ႥႨ)obj2).Ⴐ);
					}
					obj6.ForEach((Action<SkimmerServerData>)obj);
					((ႥႨ)obj2).Ⴗ.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687352469, 6, 25));
					num = ⴀႼ[44] - 156;
					continue;
				}
				case 3:
				{
					((ႥႨ)obj2).Ⴗ.Ⴀ();
					object obj3 = new Publisher();
					((Publisher)obj3).Process(((ႥႨ)obj2).Ⴗ);
					break;
				}
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴃ.Error(SkimmerSpotBins.Ⴈ(ex as Exception, 960, 1006));
		}
		switch (1)
		{
		}
	}

	private static int Ⴅ(SkimmerServerData P_0, SkimmerServerData P_1)
	{
		return P_0.Ⴓ().CompareTo(P_1.Ⴓ());
	}
}
