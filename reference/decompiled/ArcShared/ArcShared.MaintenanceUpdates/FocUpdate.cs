using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.Forms;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using Ⴃ;

namespace ArcShared.MaintenanceUpdates;

public sealed class FocUpdate
{
	private static readonly ILog Ⴀ;

	private string Ⴀ;

	private string m_Ⴃ;

	[SpecialName]
	private string Ⴃ()
	{
		char[] ⴗ = DxCfg.Ⴗ;
		return Ⴀ;
	}

	[SpecialName]
	private void Ⴅ(string P_0)
	{
		Ⴀ = P_0;
	}

	[SpecialName]
	private string Ⴍ()
	{
		return this.m_Ⴃ;
	}

	[SpecialName]
	private void Ⴓ(string P_0)
	{
		this.m_Ⴃ = P_0;
	}

	public FocUpdate()
	{
		ISerializable serializable = FrmUpdateAvailable.ႷႥ(229, 139);
		Ⴅ(ReverseBeaconClient.Ⴗ(DownloadUrl2.ႥႤ(CtyInfo.Ⴐ(serializable as Assembly, 662, 685), 'ŏ', 'ģ'), DownloadUrl2.Ⴅ(0, null, 2018867532, 4), '\u038b', 'σ'));
		Ⴓ(Path.GetDirectoryName(((Assembly)serializable).Location) + UtilsString.Ⴐ(null, 7, 192632068));
	}

	public void Download(string url)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		try
		{
			int num = 1;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					goto IL_0030;
				case 4:
					obj = new PrecisionTimer();
					(obj as PrecisionTimer).Start();
					break;
				case 0:
				case 5:
					break;
				}
				break;
				IL_0030:
				FocUpdate.Ⴀ.Info(HelpAboutServer.Ⴗ(DownloadUrl2.Ⴅ(26, null, 2018867475, 3), url, DownloadUrl2.Ⴅ(8, null, 2018867493, 7), Ⴃ(), 469, 'ƻ'));
				num = ⴐ[560] - 29992;
			}
			Component component = new WebClient();
			try
			{
				switch (2)
				{
				default:
					UtilsString.Ⴃ(component as WebClient, url, Ⴃ(), '±', 163);
					break;
				}
			}
			finally
			{
				int num2 = 6;
				while (true)
				{
					int num3;
					switch (num2)
					{
					default:
						num3 = (((WebClient)component == null) ? 2 : (ⴗ[117] - 12539));
						goto IL_0109;
					case 0:
						((IDisposable)(component as WebClient)).Dispose();
						break;
					case 2:
						break;
					}
					break;
					IL_0109:
					num2 = num3;
				}
			}
			switch (3)
			{
			default:
				(obj as PrecisionTimer).Stop();
				break;
			case 0:
				break;
			case 1:
				goto end_IL_000e;
			}
			FocUpdate.Ⴀ.Info(DxAtlasData.Ⴄ((object)(obj as PrecisionTimer), (object)ArcLogInRqstExt.Ⴗ(1706508114, 27, 6), (object)url, 470, 'ƹ'));
			end_IL_000e:;
		}
		catch (WebException ex)
		{
			FocUpdate.Ⴀ.Error(DxAtlasData.Ⴄ((object)PrecisionTimer.Ⴜ((Exception)(ex as WebException), 229, '\u00b8'), (object)ႣႼ.Ⴜ(3, 365387133, 3), (object)UtilsLatLon.Ⴍ((Exception)(ex as WebException), (short)511, (short)509), 663, '\u02f8'));
		}
		catch (Exception ex2)
		{
			FocUpdate.Ⴀ.Error((ex2 as Exception).Message + ႣႼ.Ⴜ(1, 365387135, 24) + ex2.InnerException);
		}
		switch (4)
		{
		}
	}

	public bool VerifyCopyDelete()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool result = default(bool);
		try
		{
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((!Ⴄ()) ? (ⴀ[225] - 22439) : 6);
					continue;
				case 6:
					DgvFilterManager.ႭႣ(Ⴃ(), Ⴍ(), true, 512, 526);
					goto case 2;
				case 2:
				case 3:
					WwvSpotExt.Ⴀ(Ⴃ(), 347, 279);
					goto case 7;
				case 7:
					num = 5;
					continue;
				case 5:
					result = true;
					return result;
				case 4:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			FocUpdate.Ⴀ.Error(PrecisionTimer.Ⴜ(ex, 924, 'ρ'));
		}
		switch (4)
		{
		default:
			return false;
		case 1:
		case 2:
		case 3:
			return result;
		}
	}

	private bool Ⴄ()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		object obj = default(object);
		while (true)
		{
			int num = ((!StringConstants.Ⴐ(Ⴃ(), 910, 897)) ? (ⴐ[505] - 21216) : 2);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႭ[232] - 45204;
					continue;
				case 3:
				case 9:
					break;
				case 2:
				case 7:
					obj = new FileInfo(Ⴃ());
					num = ((!(obj is FileInfo)) ? 5 : 4);
					continue;
				case 4:
					num = ((ServerIoCfg.ႤႷ(obj as FileInfo, 'ϙ', 'Δ') <= 100) ? (ⴗ[89] - 20999) : (ⴃႭ[89] - 23648));
					continue;
				case 1:
				{
					IEnumerable enumerable = UtilsDate.Ⴓ(Ⴃ(), 'Ȁ', 541);
					num = ((!AutoUpdater.ႨႰ((string)enumerable, ႣႼ.ႥႭ(null, 624735578, 6, null), 155, 'ó')) ? (ⴀ[256] - 37542) : 8);
					continue;
				}
				case 8:
					return true;
				case 5:
					FocUpdate.Ⴀ.Error(UtilsString.Ⴐ(null, 6, 192631645));
					goto case 0;
				case 0:
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static FocUpdate()
	{
		UtilsIdentity.Ⴐ();
		FocUpdate.Ⴀ = ArcLogInRqstExt.Ⴍ(ArcLogInRqstExt.Ⴗ(1706508154, 19, 3), 89, 6);
	}
}
