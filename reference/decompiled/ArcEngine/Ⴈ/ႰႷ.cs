using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using ArcEngine;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using log4net;

namespace Ⴈ;

internal sealed class ႰႷ
{
	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216133893, 7, 'S'), 181, 168);

	private ConcurrentQueue<NodeUserCmd> m_Ⴍ;

	private SetDxCount.Ⴃ Ⴃ;

	internal ႰႷ(ObjectManager P_0)
	{
		Ⴃ.Ⴐ = P_0;
		this.m_Ⴍ = new ConcurrentQueue<NodeUserCmd>();
		PublishInfo.Ⴅ(624, 555).StartNew(Ⴍ, TaskCreationOptions.LongRunning);
	}

	internal void Ⴀ(NodeUserCmd P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		try
		{
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = (Ⴃ.Ⴐ.Ⴍ().PcxxCfg.IgnoreNodeUserProtocol ? (ⴃႰ[143] - 1474) : (ⴍႭ[134] - 36332));
					break;
				case 1:
				case 5:
					this.m_Ⴍ.Enqueue(P_0);
					return;
				case 2:
				case 4:
					return;
				}
				num = num2;
			}
		}
		catch (Exception ex)
		{
			Ⴅ.Error(SkimmerSpotBins.Ⴈ(ex, 452, 490));
		}
	}

	private void Ⴍ()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		try
		{
			int num = 6;
			NodeUserCmd result = default(NodeUserCmd);
			while (true)
			{
				switch (num)
				{
				case 0:
					this.m_Ⴍ.TryDequeue(out result);
					goto case 7;
				case 7:
					num = ((result == null) ? 3 : (ⴀႨ[16] - 34735));
					break;
				case 1:
					Ⴈ(result);
					goto default;
				default:
					num = ((this.m_Ⴍ.Count <= 0) ? 2 : 0);
					break;
				case 2:
				case 4:
				case 5:
					ShowDxHelp.Ⴄ(200, 914, 928);
					return;
				}
			}
		}
		catch (Exception ex)
		{
			Ⴅ.Error(SkimmerSpotBins.Ⴈ(ex, 628, 602));
		}
	}

	private void Ⴈ(NodeUserCmd P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		try
		{
			int num = 6;
			object obj3 = default(object);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj3 = SetTalkOutputHelp.Ⴍ(P_0.Rx.Msg, 0, 4, 440, 491);
					goto case 3;
				case 3:
					num = ⴍႭ[374] - 54488;
					continue;
				case 2:
					obj = Ⴃ.Ⴐ.Ⴗ().Ⴈ((string)obj3);
					goto case 5;
				case 5:
					num = (((IArcCmd)obj == null) ? 1 : (ⴍႤ[132] - 24577));
					continue;
				case 4:
				case 7:
				{
					((IArcCmd)obj).Exec(P_0);
					object obj2 = new Publisher();
					(obj2 as Publisher).Process(P_0);
					num = ⴍႭ[267] - 46238;
					continue;
				}
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴅ.Error(SkimmerSpotBins.Ⴈ(ex as Exception, 232, 198));
		}
		switch (0)
		{
		}
	}
}
