using System.Runtime.CompilerServices;
using System.Security;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public sealed class CacheManager
{
	private static readonly ILog m_Ⴗ;

	private readonly ႥႭ Ⴍ;

	public AnnCache Ann
	{
		get
		{
			byte[] ⴅ = UserCmd.Ⴅ;
			return Ⴍ.Ⴀ();
		}
	}

	public ArcConnectsCache ArcConnects
	{
		get
		{
			char[] ⴗ = ႥႰ.Ⴗ;
			return Ⴍ.Ⴃ();
		}
	}

	public DxCache Dx => Ⴍ.Ⴐ();

	public DxccCache Dxcc
	{
		get
		{
			byte[] ⴅ = UserCmd.Ⴅ;
			return Ⴍ.Ⴓ();
		}
	}

	public CtyHdgDistCache CtyHdgDist
	{
		get
		{
			char[] ⴗ = ႥႰ.Ⴗ;
			CtyHdgDistCache result = Ⴍ.Ⴈ();
			Bye.Ⴄ[7] = (char)((Bye.Ⴄ[7] + Bye.Ⴄ[163]) & 0x92);
			return result;
		}
	}

	public CtyCache Cty => Ⴍ.Ⴄ();

	public WxCache Wx
	{
		get
		{
			char[] ⴗ = ႥႰ.Ⴗ;
			WxCache result = Ⴍ.Ⴗ();
			ႥႰ.Ⴗ[153] = (char)((ႥႰ.Ⴗ[153] | ႥႰ.Ⴗ[71]) & 0x63);
			return result;
		}
	}

	public WwvCache Wwv
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			return Ⴍ.Ⴅ();
		}
	}

	[SpecialName]
	internal BuddyCache Ⴗ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		return Ⴍ.Ⴍ();
	}

	[SpecialName]
	internal MultimediaCache Ⴀ()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		return Ⴍ.Ⴜ();
	}

	internal CacheManager(ႥႭ P_0)
	{
		Ⴍ = P_0;
	}

	[SecuritySafeCritical]
	static CacheManager()
	{
		ArcClientConnectDat.Ⴍ();
		CacheManager.m_Ⴗ = HighlightItuZoneCfg.Ⴓ(WxFilters.Ⴀ(null, 5, 103388339), 666, 682);
	}
}
