using System;
using System.Collections;
using System.ComponentModel;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods.Login;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using Ⴃ;

namespace ArcShared.MaintenanceUpdates;

public sealed class DxClusterListUpdate
{
	private static readonly ILog Ⴀ;

	private DxCommentExtCfg.ႷႰ Ⴐ;

	public DxClusterListUpdate()
	{
		_Assembly assembly = FrmUpdateAvailable.ႷႥ(67, 45);
		IEnumerable enumerable = DownloadUrl2.ႥႤ(CtyInfo.Ⴐ(assembly as Assembly, 869, 862), 'ɜ', 'Ȱ') + ႣႼ.Ⴜ(3, 365385869, 9);
		Ⴐ.Ⴀ = (string)enumerable;
	}

	public void Download(string url)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		try
		{
			int num = 4;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					goto IL_0029;
				case 3:
					obj = new PrecisionTimer();
					break;
				case 0:
				case 1:
				case 2:
					break;
				}
				break;
				IL_0029:
				Ⴀ.Info(ReverseBeaconClient.Ⴗ(ႣႼ.Ⴜ(8, 365385891, 1), url, '\u0364', '\u032c'));
				num = 3;
			}
			(obj as PrecisionTimer).Start();
			Component component = new WebClient();
			try
			{
				switch (0)
				{
				default:
					UtilsString.Ⴃ((WebClient)component, url, Ⴐ.Ⴀ, '\u001b', 9);
					break;
				case 1:
					break;
				}
			}
			finally
			{
				int num2 = 4;
				while (true)
				{
					int num3;
					switch (num2)
					{
					default:
						num3 = ((!(component is WebClient)) ? (ⴐ[166] - 64385) : 2);
						goto IL_00d5;
					case 0:
					case 2:
					case 3:
						((IDisposable)(WebClient)component).Dispose();
						break;
					case 5:
					case 6:
						break;
					}
					break;
					IL_00d5:
					num2 = num3;
				}
			}
			switch (4)
			{
			default:
				(obj as PrecisionTimer).Stop();
				break;
			case 0:
			case 3:
				break;
			case 2:
				goto end_IL_0007;
			}
			Ⴀ.Info(DxAtlasData.Ⴄ((object)(PrecisionTimer)obj, (object)ArcLogInRqstExt.Ⴗ(1706507477, 21, 5), (object)url, 184, '×'));
			end_IL_0007:;
		}
		catch (WebException ex)
		{
			Ⴀ.Error(DxAtlasData.Ⴄ((object)PrecisionTimer.Ⴜ((Exception)(ex as WebException), 220, '\u0081'), (object)ႣႼ.Ⴜ(2, 365387132, 17), (object)UtilsLatLon.Ⴍ((Exception)(ex as WebException), (short)23, (short)21), 556, 'Ƀ'));
		}
		catch (Exception ex2)
		{
			Ⴀ.Error((ex2 as Exception).Message + ႣႼ.Ⴜ(5, 365387131, 6) + ex2.InnerException);
		}
		switch (0)
		{
		}
	}

	[SecuritySafeCritical]
	static DxClusterListUpdate()
	{
		UtilsIdentity.Ⴐ();
		Ⴀ = ArcLogInRqstExt.Ⴍ(UtilsString.Ⴐ(null, 3, 192633784), 405, 458);
	}
}
