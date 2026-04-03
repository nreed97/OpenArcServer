using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods.Login;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using Ⴃ;

namespace ArcShared.MaintenanceUpdates;

public sealed class ChatRoomPubUpdate
{
	private static readonly ILog m_Ⴄ;

	private DxCommentExtCfg.ႷႰ Ⴀ;

	[SpecialName]
	internal string Ⴃ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		return Ⴀ.Ⴀ;
	}

	[SpecialName]
	internal void Ⴄ(string P_0)
	{
		Ⴀ.Ⴀ = P_0 as string;
	}

	public ChatRoomPubUpdate()
	{
		_Assembly assembly = FrmUpdateAvailable.ႷႥ(155, 245);
		Ⴄ(DownloadUrl2.ႥႤ(CtyInfo.Ⴐ((Assembly)assembly, 1006, 981), 'ĭ', 'Ł') + ArcLogInRqstExt.Ⴗ(1706507641, 16, 5));
	}

	public void Download(string url)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		try
		{
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 4:
				case 5:
				{
					object obj = new PrecisionTimer();
					((PrecisionTimer)obj).Start();
					object obj2 = new WebClient();
					try
					{
						switch (4)
						{
						default:
							UtilsString.Ⴃ((WebClient)obj2, url, Ⴃ(), 'ū', 377);
							break;
						}
					}
					finally
					{
						int num2 = 1;
						while (true)
						{
							int num3;
							switch (num2)
							{
							default:
								num3 = (((WebClient)obj2 == null) ? (ⴀ[329] - 29355) : 2);
								goto IL_00d7;
							case 2:
								((IDisposable)(obj2 as WebClient)).Dispose();
								break;
							case 3:
							case 4:
							case 5:
								break;
							}
							break;
							IL_00d7:
							num2 = num3;
						}
					}
					switch (4)
					{
					default:
						((PrecisionTimer)obj).Stop();
						ChatRoomPubUpdate.m_Ⴄ.Info(DxAtlasData.Ⴄ((object)(PrecisionTimer)obj, (object)DownloadUrl2.Ⴅ(3, null, 2018869009, 7), (object)url, 983, 'θ'));
						break;
					}
					goto end_IL_000a;
				}
				}
				ChatRoomPubUpdate.m_Ⴄ.Info(ReverseBeaconClient.Ⴗ(ArcLogInRqstExt.Ⴗ(1706507412, 18, 5), url, 'ʽ', '\u02f5'));
				num = 4;
				continue;
				end_IL_000a:
				break;
			}
		}
		catch (WebException ex)
		{
			ChatRoomPubUpdate.m_Ⴄ.Error(DxAtlasData.Ⴄ((object)PrecisionTimer.Ⴜ((Exception)ex, 607, 'Ȃ'), (object)ႣႼ.Ⴜ(0, 365387134, 7), (object)UtilsLatLon.Ⴍ((Exception)ex, (short)453, (short)455), 694, '\u02d9'));
		}
		catch (Exception ex2)
		{
			ChatRoomPubUpdate.m_Ⴄ.Error((ex2 as Exception).Message + ႣႼ.Ⴜ(4, 365387130, 6) + ex2.InnerException);
		}
		switch (1)
		{
		}
	}

	[SecuritySafeCritical]
	static ChatRoomPubUpdate()
	{
		UtilsIdentity.Ⴐ();
		ChatRoomPubUpdate.m_Ⴄ = ArcLogInRqstExt.Ⴍ(TelnetServerClient.Ⴄ(1945322804, 'Í', 1), 202, 149);
	}
}
