using System;
using System.Collections;
using System.Runtime.Serialization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.NodeProcessor;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using log4net;

namespace Ⴈ;

internal sealed class ႨႷ
{
	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('\u0004', 985805792, 6), 566, 555);

	private CtyCacheCfg.Ⴓ m_Ⴍ = new CtyCacheCfg.Ⴓ();

	public ႨႷ()
	{
		object obj = new ႰႰ();
		IDeserializationCallback deserializationCallback = new Hashtable();
		this.m_Ⴍ.Ⴈ = deserializationCallback as Hashtable;
		try
		{
			foreach (NodeCmdCfg item in ((ႰႰ)obj).Ⴃ)
			{
				HealthMonitorCfg.Ⴍ(this.m_Ⴍ.Ⴈ, (object)(item as NodeCmdCfg).Key, (object)item, (short)762, 'ˎ');
			}
		}
		catch (Exception ex)
		{
			Ⴅ.Error(SkimmerSpotBins.Ⴈ(ex as Exception, 959, 913));
		}
	}

	public NodeCmdCfg Ⴍ(string P_0)
	{
		return (NodeCmdCfg)ShowWwv.Ⴐ(this.m_Ⴍ.Ⴈ, (object)P_0, 'Ə', 'Ǫ');
	}
}
