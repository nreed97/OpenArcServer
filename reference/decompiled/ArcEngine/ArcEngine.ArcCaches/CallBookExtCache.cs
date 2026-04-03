using System.Threading;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class CallBookExtCache
{
	private static readonly ILog Ⴃ;

	private static readonly object Ⴓ;

	public CallbookExtensionDat GetCallbookExtensionDat(string zip)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		bool flag = false;
		object ⴓ = default(object);
		object obj;
		try
		{
			int num = 0;
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴓ = Ⴓ, ref flag, 11, 2);
					goto case 3;
				case 3:
					num = ((CallBlockCacheCfg.Ⴜ(zip, 198, 167) == 9) ? 1 : 2);
					continue;
				case 1:
					zip = SetTalkOutputHelp.Ⴍ(zip, 0, 5, 783, 860);
					num = ⴅ[210] / 4;
					continue;
				case 2:
				case 4:
					obj = ႨႥ.Ⴀ(zip, 434, 495);
					break;
				}
				break;
			}
		}
		finally
		{
			int num2 = 0;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 4 : (ⴀႳ[291] - 40782));
					goto IL_0105;
				case 1:
				case 2:
				case 5:
					Monitor.Exit(ⴓ);
					break;
				case 3:
				case 4:
					break;
				}
				break;
				IL_0105:
				num2 = num3;
			}
		}
		return (CallbookExtensionDat)obj;
	}

	static CallBookExtCache()
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 1:
				Ⴓ = new object();
				return;
			case 0:
				return;
			}
			Ⴃ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('±', 985808236, 0), 933, 952);
			num = 1;
		}
	}
}
