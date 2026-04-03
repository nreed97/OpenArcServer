using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wx;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class PCxx : IArcCmd
{
	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(ႰႥ.Ⴅ(1, 'Ò', 952619895), 305, 300);

	public void Exec(NodeUserCmd cmd)
	{
		try
		{
			int num = 7;
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					cmd.Ⴍ().ႠႰ(ReplyMail.Ⴅ(2, 4, 1217942360));
					num = 2;
					continue;
				case 2:
					cmd.Ⴍ().Ⴀ(false);
					SetWxOutputHelp.Ⴓ(cmd.Ⴍ().Cfg, ShowAnnHelp.Ⴅ('Ȓ', 547), 'Ŭ', 258);
					goto case 3;
				case 3:
					num = 5;
					continue;
				case 5:
					cmd.Ⴍ().ႳႳ();
					cmd.Ⴍ().ႳႨ();
					Ⴅ.Warn(AnnHelp.Ⴈ(ReplyMail.Ⴅ(1, 15, 1217942289), cmd.Ⴍ().Call, ShowSkimCtyHelp.Ⴍ(1216129634, 0, '»'), 312, 'ď'));
					goto case 0;
				case 0:
					num = 6;
					continue;
				case 6:
				{
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					break;
				}
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
		}
		switch (3)
		{
		}
	}
}
