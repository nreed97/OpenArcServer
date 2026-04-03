using System;
using System.Collections;
using System.Net.Mail;
using System.Security;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcShared.ArcUtils;
using log4net;

namespace Ⴀ;

internal sealed class ႥႣ
{
	private static readonly ILog Ⴈ;

	private HighlightCfg.ႳႷ Ⴗ = new HighlightCfg.ႳႷ();

	internal ႥႣ(ArcClientObjMgr P_0)
	{
		Ⴗ.Ⴍ = P_0;
	}

	internal void Ⴄ()
	{
		IEnumerable enumerable = TelnetServerCfg.Ⴗ(Ⴗ.Ⴍ.Cfg.DxEmail.Filter, SqlFilterType.Dx, 'ȁ', 547);
		Ⴗ.Ⴗ = enumerable as string;
	}

	internal void Ⴅ(string P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		try
		{
			int num = 7;
			bool flag = default(bool);
			IDisposable disposable2 = default(IDisposable);
			IDisposable disposable = default(IDisposable);
			while (true)
			{
				switch (num)
				{
				default:
					flag = Ⴗ.Ⴍ.Caches.Dx.Ⴓ(Ⴗ.Ⴗ);
					num = 4;
					continue;
				case 4:
					num = ((!Ⴗ.Ⴍ.Cfg.DxEmail.DxAlertEnabled) ? 5 : (ⴀႠ[26] - 10571));
					continue;
				case 10:
					num = ((!flag) ? (ⴄ[39] - 46465) : 2);
					continue;
				case 2:
					disposable2 = new MailMessage(Ⴗ.Ⴍ.Cfg.DxEmail.MailFrom, Ⴗ.Ⴍ.Cfg.DxEmail.MailTo, WxFilters.Ⴀ(null, 6, 103387737), P_0);
					goto case 8;
				case 8:
				case 9:
					num = ⴀႠ[24] - 40413;
					continue;
				case 1:
					disposable = new SmtpClient(Ⴗ.Ⴍ.Cfg.DxEmail.MailServer);
					ႥႠ.Ⴄ(disposable as SmtpClient, true, 478, 'ǲ');
					goto case 0;
				case 0:
					num = ⴄ[114] - 19;
					continue;
				case 3:
					WxFilters.Ⴜ(disposable as SmtpClient, (MailMessage)disposable2, 345, 370);
					break;
				case 5:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴈ.Error((ex as Exception).Message);
		}
		switch (0)
		{
		}
	}

	[SecuritySafeCritical]
	static ႥႣ()
	{
		ArcClientConnectDat.Ⴍ();
		Ⴈ = HighlightItuZoneCfg.Ⴓ(ClientCty.Ⴗ('\u009c', 4, 307013136), 817, 769);
	}
}
