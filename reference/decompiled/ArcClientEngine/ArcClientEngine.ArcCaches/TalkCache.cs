using System.Data;
using System.Runtime.CompilerServices;
using System.Security;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.CmdProcessing;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public sealed class TalkCache
{
	private static readonly ILog Ⴐ;

	private static readonly object m_Ⴃ;

	private bool Ⴈ;

	private FilterViewer.ႨႭ Ⴓ = new FilterViewer.ႨႭ();

	[SpecialName]
	private DataSet Ⴃ()
	{
		return Ⴓ.Ⴈ;
	}

	[SpecialName]
	private void Ⴃ(DataSet P_0)
	{
		Ⴓ.Ⴈ = P_0 as DataSet;
		UserCmd.Ⴅ[293] = (byte)((UserCmd.Ⴅ[293] ^ UserCmd.Ⴅ[182]) & 0xAB);
	}

	[SpecialName]
	internal bool Ⴍ()
	{
		return Ⴈ;
	}

	[SpecialName]
	internal void Ⴍ(bool P_0)
	{
		Ⴈ = P_0;
	}

	internal TalkCache()
	{
		Ⴃ(new DataSet());
	}

	[SecuritySafeCritical]
	static TalkCache()
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				ArcClientConnectDat.Ⴍ();
				Ⴐ = HighlightItuZoneCfg.Ⴓ(ႥႥ.Ⴍ(8, 1580608363, 'ñ', null), 92, 108);
				break;
			case 1:
				break;
			case 2:
			case 3:
				TalkCache.m_Ⴃ = new object();
				return;
			}
			num = 2;
		}
	}
}
