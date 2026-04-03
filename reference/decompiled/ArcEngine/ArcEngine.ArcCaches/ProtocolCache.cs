using System;
using System.Collections.Generic;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class ProtocolCache
{
	private readonly Dictionary<string, long> Ⴄ;

	private ShowContestStation.Ⴓ Ⴅ = new ShowContestStation.Ⴓ();

	public ProtocolCache()
	{
		Ⴄ = new Dictionary<string, long>();
		object obj = new Dictionary<string, long>();
		Ⴅ.Ⴐ = obj as Dictionary<string, long>;
	}

	public void Update(string cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 10;
		ICloneable cloneable = default(ICloneable);
		long num2 = default(long);
		while (true)
		{
			switch (num)
			{
			default:
				cloneable = SetTalkOutputHelp.Ⴍ(cmd, 0, 4, 112, 35);
				num2 = CallBlockCacheCfg.Ⴜ(cmd, 758, 663);
				num = ⴃႠ[416] - 8140;
				break;
			case 3:
				num = (SetAnnDefault.Ⴍ((string)cloneable, ႨႨ.Ⴀ(6, 2, 1157905617), 32, 114) ? ⴐ[367] : (ⴍႭ[133] - 22338));
				break;
			case 1:
				if (SetAnnDefault.Ⴍ(cloneable as string, ႨႨ.Ⴀ(7, 0, 1157904770), 280, 330))
				{
					num = 4;
					break;
				}
				return;
			case 4:
				num = (Ⴄ.ContainsKey((string)cloneable) ? (ⴀႨ[46] - 49127) : 0);
				break;
			case 6:
				Ⴄ[(string)cloneable] = Ⴄ[cloneable as string] + 1;
				goto case 8;
			case 8:
				num = 7;
				break;
			case 0:
			case 2:
				Ⴄ.Add(cloneable as string, 1L);
				goto case 7;
			case 7:
				if (Ⴅ.Ⴐ.ContainsKey(cloneable as string))
				{
					num = ⴃႰ[155] - 30432;
					break;
				}
				Ⴅ.Ⴐ.Add(cloneable as string, num2);
				return;
			case 9:
				Ⴅ.Ⴐ[(string)cloneable] = Ⴅ.Ⴐ[cloneable as string] + num2;
				return;
			}
		}
	}
}
