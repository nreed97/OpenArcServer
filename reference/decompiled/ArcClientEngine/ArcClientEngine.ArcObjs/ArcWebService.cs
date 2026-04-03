using System.Security;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using log4net;

namespace ArcClientEngine.ArcObjs;

public sealed class ArcWebService
{
	private static readonly ILog Ⴅ;

	private HighlightStateCfg.Ⴄ Ⴓ = new HighlightStateCfg.Ⴄ();

	public ArcWebService(ArcClientObjMgr om)
	{
		Ⴓ.Ⴓ = om as ArcClientObjMgr;
	}

	public void GetClientConnectList()
	{
	}

	[SecuritySafeCritical]
	static ArcWebService()
	{
		ArcClientConnectDat.Ⴍ();
		Ⴅ = HighlightItuZoneCfg.Ⴓ(WxFilters.Ⴀ(null, 6, 103388713), 269, 317);
	}
}
