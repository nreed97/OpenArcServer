using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
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

public sealed class CtyUpdate
{
	private static readonly ILog Ⴈ;

	private string m_Ⴀ;

	private DxCommentExtCfg.ႷႰ m_Ⴐ;

	[SpecialName]
	private string Ⴀ()
	{
		return this.m_Ⴐ.Ⴀ;
	}

	[SpecialName]
	private void Ⴓ(string P_0)
	{
		this.m_Ⴐ.Ⴀ = P_0 as string;
	}

	[SpecialName]
	private string Ⴓ()
	{
		return this.m_Ⴀ;
	}

	[SpecialName]
	private void Ⴐ(string P_0)
	{
		this.m_Ⴀ = P_0;
	}

	public CtyUpdate()
	{
		object obj = FrmUpdateAvailable.ႷႥ(367, 257);
		Ⴓ(ReverseBeaconClient.Ⴗ(DownloadUrl2.ႥႤ(CtyInfo.Ⴐ((Assembly)obj, 691, 648), '\u0308', '\u0364'), DownloadUrl2.Ⴅ(28, null, 2018867291, 6), 'ŕ', 'ĝ'));
		Ⴐ(Path.GetDirectoryName(((Assembly)obj).Location) + UtilsString.Ⴐ(null, 7, 192631955));
	}

	public bool Download(string url)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		bool result = default(bool);
		try
		{
			int num = 4;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					Ⴈ.Info(ReverseBeaconClient.Ⴗ(DownloadUrl2.Ⴅ(18, null, 2018867309, 8), url, '{', '3'));
					goto IL_0059;
				case 1:
					goto IL_0059;
				case 3:
					obj = new PrecisionTimer();
					(obj as PrecisionTimer).Start();
					break;
				case 5:
					break;
				}
				break;
				IL_0059:
				num = ⴃႭ[188] - 1897;
			}
			Component component = new WebClient();
			try
			{
				switch (3)
				{
				default:
					UtilsString.Ⴃ(component as WebClient, url, Ⴀ(), '\u0095', 135);
					break;
				}
			}
			finally
			{
				int num2 = 3;
				while (true)
				{
					int num3;
					switch (num2)
					{
					default:
						num3 = ((!(component is WebClient)) ? (ⴀ[218] - 52348) : (ⴃႤ[176] - 54694));
						goto IL_00fa;
					case 2:
						((IDisposable)(component as WebClient)).Dispose();
						break;
					case 4:
					case 5:
						break;
					}
					break;
					IL_00fa:
					num2 = num3;
				}
			}
			int num4 = 0;
			while (true)
			{
				switch (num4)
				{
				default:
					(obj as PrecisionTimer).Stop();
					ႰႨ.Ⴜ(10, '\u030a', 791);
					break;
				case 2:
					break;
				case 3:
				case 4:
					result = true;
					return result;
				}
				Ⴈ.Info(DxAtlasData.Ⴄ((object)(obj as PrecisionTimer), (object)DownloadUrl2.Ⴅ(19, null, 2018867208, 8), (object)url, 737, 'ʎ'));
				num4 = 3;
			}
		}
		catch (WebException ex)
		{
			Ⴈ.Error(DxAtlasData.Ⴄ((object)PrecisionTimer.Ⴜ((Exception)(ex as WebException), 752, 'ʭ'), (object)ႣႼ.Ⴜ(5, 365387131, 14), (object)UtilsLatLon.Ⴍ((Exception)ex, (short)422, (short)420), 610, 'ȍ'));
		}
		catch (Exception ex2)
		{
			Ⴈ.Error((ex2 as Exception).Message + ႣႼ.Ⴜ(0, 365387134, 28) + (ex2 as Exception).InnerException);
		}
		switch (4)
		{
		default:
			return false;
		case 0:
		case 1:
		case 5:
			return result;
		}
	}

	public bool VerifyCopyDelete()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		bool flag = default(bool);
		try
		{
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((!Ⴅ()) ? (ⴗ[51] - 12330) : (ⴃႤ[273] - 19693));
					continue;
				case 1:
					DgvFilterManager.ႭႣ(Ⴀ(), Ⴓ(), true, 139, 133);
					WwvSpotExt.Ⴀ(Ⴀ(), 662, 730);
					goto case 2;
				case 2:
					num = ⴃႭ[43] - 34347;
					continue;
				case 3:
					flag = true;
					break;
				case 6:
					break;
				case 0:
				case 4:
					goto IL_00cd;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴈ.Error(PrecisionTimer.Ⴜ(ex as Exception, 291, 'ž'));
			goto IL_00cd;
		}
		goto IL_00f1;
		IL_00cd:
		switch (2)
		{
		default:
			return false;
		case 1:
		case 5:
			break;
		}
		goto IL_00f1;
		IL_00f1:
		bool result = flag;
		NeedsCfg.ႣႤ[490] = NeedsCfg.ႣႤ[490] & DxCfg.Ⴗ[104] & 0x3A;
		return result;
	}

	private bool Ⴅ()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		FileSystemInfo fileSystemInfo = default(FileSystemInfo);
		while (true)
		{
			int num = ((!StringConstants.Ⴐ(Ⴀ(), 900, 907)) ? 6 : (ⴃႣ[116] - 21526));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႤ[193] - 14820;
					continue;
				case 0:
					break;
				case 9:
					fileSystemInfo = new FileInfo(Ⴀ());
					goto case 3;
				case 3:
					num = ((fileSystemInfo is FileInfo) ? 1 : 6);
					continue;
				case 1:
					num = ((ServerIoCfg.ႤႷ(fileSystemInfo as FileInfo, 'ƻ', 'Ƕ') <= 100) ? (ⴐ[168] - 4245) : 2);
					continue;
				case 2:
				{
					IEquatable<string> equatable = UtilsDate.Ⴓ(Ⴀ(), '¬', 177);
					num = ((!AutoUpdater.ႨႰ((string)equatable, ႣႼ.ႥႭ(null, 624735641, 3, null), 446, 'ǖ')) ? 6 : 7);
					continue;
				}
				case 7:
				case 8:
					return true;
				case 6:
					Ⴈ.Error(UtilsString.Ⴐ(null, 7, 192631644));
					goto case 4;
				case 4:
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static CtyUpdate()
	{
		UtilsIdentity.Ⴐ();
		Ⴈ = ArcLogInRqstExt.Ⴍ(UtilsString.Ⴐ(null, 7, 192631984), 229, 186);
	}
}
