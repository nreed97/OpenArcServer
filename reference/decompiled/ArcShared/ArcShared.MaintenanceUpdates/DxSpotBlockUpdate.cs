using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using Ⴃ;

namespace ArcShared.MaintenanceUpdates;

public sealed class DxSpotBlockUpdate
{
	private static readonly ILog m_Ⴐ;

	private string m_Ⴐ;

	private DxCommentExtCfg.ႷႰ m_Ⴃ;

	[SpecialName]
	private string Ⴈ()
	{
		return this.m_Ⴃ.Ⴀ;
	}

	[SpecialName]
	private void Ⴅ(string P_0)
	{
		this.m_Ⴃ.Ⴀ = P_0;
	}

	[SpecialName]
	private string Ⴃ()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		return this.m_Ⴐ;
	}

	[SpecialName]
	private void Ⴓ(string P_0)
	{
		this.m_Ⴐ = P_0;
	}

	public DxSpotBlockUpdate()
	{
		_Assembly assembly = FrmUpdateAvailable.ႷႥ(367, 257);
		Ⴅ(ReverseBeaconClient.Ⴗ(DownloadUrl2.ႥႤ(CtyInfo.Ⴐ((Assembly)assembly, 691, 648), '\u0308', '\u0364'), DownloadUrl2.Ⴅ(28, null, 2018867438, 6), 'ŕ', 'ĝ'));
		Ⴓ(Path.GetDirectoryName((assembly as Assembly).Location) + UtilsString.Ⴐ(null, 7, 192632151));
	}

	public void Download(string url)
	{
		try
		{
			int num = 3;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					DxSpotBlockUpdate.m_Ⴐ.Info(ReverseBeaconClient.Ⴗ(DownloadUrl2.Ⴅ(18, null, 2018867391, 8), url, '{', '3'));
					goto IL_0044;
				case 5:
					goto IL_0044;
				case 1:
					obj = new PrecisionTimer();
					goto case 0;
				case 0:
					(obj as PrecisionTimer).Start();
					break;
				case 4:
					break;
				}
				break;
				IL_0044:
				num = 1;
			}
			Component component = new WebClient();
			try
			{
				switch (3)
				{
				default:
					UtilsString.Ⴃ((WebClient)component, url, Ⴈ(), '\u0095', 135);
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
						num3 = ((!(component is WebClient)) ? 2 : 5);
						goto IL_00cb;
					case 3:
					case 5:
						((IDisposable)(component as WebClient)).Dispose();
						break;
					case 2:
					case 6:
						break;
					}
					break;
					IL_00cb:
					num2 = num3;
				}
			}
			switch (4)
			{
			default:
				(obj as PrecisionTimer).Stop();
				DxSpotBlockUpdate.m_Ⴐ.Info(DxAtlasData.Ⴄ((object)(obj as PrecisionTimer), (object)ႣႼ.Ⴜ(8, 365387578, 19), (object)url, 778, '\u0365'));
				break;
			case 0:
			case 2:
			case 3:
				break;
			}
		}
		catch (WebException ex)
		{
			DxSpotBlockUpdate.m_Ⴐ.Error(DxAtlasData.Ⴄ((object)PrecisionTimer.Ⴜ((Exception)ex, 737, 'ʼ'), (object)ႣႼ.Ⴜ(5, 365387131, 14), (object)UtilsLatLon.Ⴍ((Exception)(ex as WebException), (short)752, (short)754), 422, 'ǉ'));
		}
		catch (Exception ex2)
		{
			DxSpotBlockUpdate.m_Ⴐ.Error((ex2 as Exception).Message + ႣႼ.Ⴜ(0, 365387134, 28) + (ex2 as Exception).InnerException);
		}
		switch (4)
		{
		}
	}

	public bool VerifyCopyDelete()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		bool result = default(bool);
		try
		{
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((!Ⴐ()) ? 6 : (ⴃႭ[173] - 11198));
					continue;
				case 0:
				case 7:
					DgvFilterManager.ႭႣ(Ⴈ(), Ⴃ(), true, 610, 620);
					goto case 3;
				case 3:
					WwvSpotExt.Ⴀ(Ⴈ(), 139, 199);
					num = ⴃႣ[166] - 48248;
					continue;
				case 4:
				case 5:
					result = true;
					return result;
				case 6:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			DxSpotBlockUpdate.m_Ⴐ.Error(PrecisionTimer.Ⴜ(ex as Exception, 662, 'ˋ'));
		}
		switch (3)
		{
		default:
			return false;
		case 0:
		case 2:
		case 4:
			return result;
		}
	}

	private bool Ⴐ()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		FileSystemInfo fileSystemInfo = default(FileSystemInfo);
		while (true)
		{
			int num = (StringConstants.Ⴐ(Ⴈ(), 300, 291) ? 4 : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴐ[102] - 54928;
					continue;
				case 9:
					break;
				case 4:
					fileSystemInfo = new FileInfo(Ⴈ());
					num = (((FileInfo)fileSystemInfo == null) ? (ⴀ[114] - 58320) : (ⴐ[72] - 43488));
					continue;
				case 7:
					num = ((ServerIoCfg.ႤႷ((FileInfo)fileSystemInfo, '\u038b', 'φ') > 100) ? (ⴗ[122] - 32511) : 0);
					continue;
				case 1:
				{
					ICloneable cloneable = UtilsDate.Ⴓ(Ⴈ(), 'Ʀ', 443);
					num = (AutoUpdater.ႨႰ(cloneable as string, ႣႼ.ႥႭ(null, 624735591, 3, null), 217, '±') ? 8 : 0);
					continue;
				}
				case 8:
					return true;
				case 0:
					DxSpotBlockUpdate.m_Ⴐ.Error(UtilsString.Ⴐ(null, 7, 192631644));
					goto case 5;
				case 5:
				case 6:
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static DxSpotBlockUpdate()
	{
		UtilsIdentity.Ⴐ();
		DxSpotBlockUpdate.m_Ⴐ = ArcLogInRqstExt.Ⴍ(UtilsString.Ⴐ(null, 7, 192632176), 470, 393);
	}
}
