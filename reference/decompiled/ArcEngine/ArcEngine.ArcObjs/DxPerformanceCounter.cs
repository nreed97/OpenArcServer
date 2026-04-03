using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcObjs;

public sealed class DxPerformanceCounter
{
	private static readonly ILog Ⴍ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('\u007f', 985807835, 6), 752, 749);

	private PerformanceCounter Ⴍ;

	private PerformanceCounter Ⴄ;

	private SetWxModeHelp.Ⴃ Ⴃ;

	public DxPerformanceCounter()
	{
		try
		{
			if (!SkimmerSpotBins.Ⴓ(ReplyMailHelp.Ⴄ(24, null, 1057161394, 6), 'ʎ', 748))
			{
				CollectionBase collectionBase = new CounterCreationDataCollection();
				object obj = new CounterCreationData();
				ShowNodesHelp.Ⴃ((CounterCreationData)obj, ႰႥ.Ⴅ(8, '\0', 952619327), 176, '\u0084');
				ShowQrz.Ⴃ((CounterCreationData)obj, SetStationQth.Ⴍ(null, 1687352596, 2, 5), 273, 339);
				SetStationMacrosHelp.Ⴅ((CounterCreationData)obj, PerformanceCounterType.NumberOfItems32, 254, 217);
				AnnSpotHelp.Ⴀ((CounterCreationDataCollection)collectionBase, obj as CounterCreationData, 'ˎ', 'ˀ');
				object obj2 = new CounterCreationData();
				ShowNodesHelp.Ⴃ(obj2 as CounterCreationData, ႨႨ.Ⴀ(15, 0, 1157902757), 551, 'ȓ');
				ShowQrz.Ⴃ(obj2 as CounterCreationData, ReplyMailHelp.Ⴄ(25, null, 1057162782, 7), 655, 717);
				SetStationMacrosHelp.Ⴅ(obj2 as CounterCreationData, PerformanceCounterType.RateOfCountsPerSecond32, 390, 417);
				AnnSpotHelp.Ⴀ((CounterCreationDataCollection)collectionBase, (CounterCreationData)obj2, 'ʁ', 'ʏ');
				object obj3 = new CounterCreationData();
				ShowNodesHelp.Ⴃ(obj3 as CounterCreationData, ႰႥ.Ⴅ(6, 'ô', 952619727), 326, 'Ų');
				ShowQrz.Ⴃ(obj3 as CounterCreationData, SetStationQth.Ⴍ(null, 1687352625, 3, 2), 308, 374);
				SetStationMacrosHelp.Ⴅ(obj3 as CounterCreationData, PerformanceCounterType.AverageTimer32, 384, 423);
				AnnSpotHelp.Ⴀ(collectionBase as CounterCreationDataCollection, obj3 as CounterCreationData, 'Ʌ', 'ɋ');
				object obj4 = new CounterCreationData();
				ShowNodesHelp.Ⴃ((CounterCreationData)obj4, ႨႨ.Ⴀ(7, 1, 1157902777), 250, 'Î');
				ShowQrz.Ⴃ((CounterCreationData)obj4, ReplyMailHelp.Ⴄ(10, null, 1057162803, 1), 184, 250);
				SetStationMacrosHelp.Ⴅ(obj4 as CounterCreationData, PerformanceCounterType.AverageBase, 969, 1006);
				AnnSpotHelp.Ⴀ((CounterCreationDataCollection)collectionBase, (CounterCreationData)obj4, 'η', 'ι');
				SetTalkCount.Ⴓ(ReplyMailHelp.Ⴄ(4, null, 1057161398, 2), ReplyMail.Ⴅ(2, 13, 1217944032), (CounterCreationDataCollection)collectionBase, 167, '\u0081');
			}
			Ⴍ = new PerformanceCounter();
			SetTalkCount.Ⴜ(Ⴍ, ReplyMailHelp.Ⴄ(22, null, 1057161396, 0), 352, 'ā');
			WxCacheCfg.Ⴄ(Ⴍ, ႰႥ.Ⴅ(6, 'U', 952619313), '\u02ed', 'ʙ');
			ByeHelp.Ⴐ(Ⴍ, SetStationClubHelp.Ⴍ(7, 2, 1747257863, null), 511, 473);
			BaseCmd.Ⴗ(Ⴍ, false, 415, 'Ǒ');
			SetWwvCount.Ⴃ(Ⴍ, 0L, 'ʸ', 665);
			Component component = new PerformanceCounter();
			Ⴃ.Ⴃ = component as PerformanceCounter;
			SetTalkCount.Ⴜ(Ⴃ.Ⴃ, ReplyMailHelp.Ⴄ(20, null, 1057161394, 6), 862, '\u033f');
			WxCacheCfg.Ⴄ(Ⴃ.Ⴃ, ႨႨ.Ⴀ(1, 3, 1157902758), 'ē', 'ŧ');
			ByeHelp.Ⴐ(Ⴃ.Ⴃ, SetStationClubHelp.Ⴍ(6, 7, 1747257858, null), 183, 145);
			BaseCmd.Ⴗ(Ⴃ.Ⴃ, false, 779, '\u0345');
			SetWwvCount.Ⴃ(Ⴃ.Ⴃ, 0L, 'ǀ', 481);
			Ⴄ = new PerformanceCounter();
			SetTalkCount.Ⴜ(Ⴄ, ReplyMailHelp.Ⴄ(30, null, 1057161394, 6), 961, 'Π');
			Ⴄ.CounterName = ႰႥ.Ⴅ(8, '\0', 952619713);
			Ⴄ.MachineName = SetStationClubHelp.Ⴍ(2, 4, 1747257857, null);
			Ⴄ.ReadOnly = false;
			Ⴄ.RawValue = 0L;
			object obj5 = new PerformanceCounter();
			Ⴃ.Ⴅ = obj5 as PerformanceCounter;
			Ⴃ.Ⴅ.CategoryName = ReplyMailHelp.Ⴄ(4, null, 1057161399, 3);
			Ⴃ.Ⴅ.CounterName = ႨႨ.Ⴀ(8, 2, 1157902778);
			Ⴃ.Ⴅ.MachineName = SetStationClubHelp.Ⴍ(15, 6, 1747257859, null);
			Ⴃ.Ⴅ.ReadOnly = false;
			Ⴃ.Ⴅ.RawValue = 0L;
		}
		catch (Exception ex)
		{
			DxPerformanceCounter.Ⴍ.Error(ReplyMailHelp.Ⴄ(15, null, 1057162742, 5) + (ex as Exception).Message);
		}
	}

	public void OnEvent(long ticks)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				ShowPrefix.Ⴈ(Ⴍ, 620, 'ț');
				goto case 3;
			case 3:
				ShowPrefix.Ⴈ(Ⴃ.Ⴃ, 574, 'ɉ');
				break;
			case 1:
				break;
			case 4:
				UserCacheCfg.Ⴀ(Ⴄ, ticks, '§', 153);
				Ⴃ.Ⴅ.Increment();
				ShowQrzHelp.ႤႤ[37] = (byte)((ShowQrzHelp.ႤႤ[37] * ShowQrzHelp.ႤႤ[181]) & 2);
				return;
			}
			num = ⴃႠ[84] - 58609;
		}
	}
}
