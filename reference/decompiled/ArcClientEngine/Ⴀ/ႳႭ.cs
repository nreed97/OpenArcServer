using System.Security;
using System.Threading;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;

namespace Ⴀ;

internal sealed class ႳႭ
{
	private static readonly WaitCallback Ⴍ;

	private static void Ⴐ(object P_0)
	{
		object obj = (ႳႳ)P_0;
		(obj as ႳႳ).Ⴍ();
	}

	internal static bool Ⴓ(ႳႳ P_0)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		return HighlightStateCfg.Ⴗ(Ⴍ, (object)P_0, (short)425, (short)418);
	}

	[SecuritySafeCritical]
	static ႳႭ()
	{
		ArcClientConnectDat.Ⴍ();
		Ⴍ = Ⴐ;
	}
}
