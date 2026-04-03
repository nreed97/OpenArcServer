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
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using Ⴃ;

namespace ArcShared.MaintenanceUpdates;

public sealed class Top100Update
{
	private static readonly ILog Ⴅ;

	private string Ⴄ;

	private DxCommentExtCfg.ႷႰ m_Ⴐ;

	[SpecialName]
	private string Ⴐ()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		return Ⴄ;
	}

	[SpecialName]
	private void Ⴀ(string P_0)
	{
		Ⴄ = P_0;
	}

	[SpecialName]
	private string Ⴓ()
	{
		string ⴀ = this.m_Ⴐ.Ⴀ;
		DxCfg.Ⴗ[9] = (char)((DxCfg.Ⴗ[9] * DxCfg.Ⴗ[16]) & 0xF6);
		return ⴀ;
	}

	[SpecialName]
	private void Ⴃ(string P_0)
	{
		this.m_Ⴐ.Ⴀ = P_0;
	}

	public Top100Update()
	{
		ICustomAttributeProvider customAttributeProvider = FrmUpdateAvailable.ႷႥ(155, 245);
		Ⴀ(ReverseBeaconClient.Ⴗ(DownloadUrl2.ႥႤ(CtyInfo.Ⴐ((Assembly)customAttributeProvider, 57, 2), 'Ι', 'ϵ'), DownloadUrl2.Ⴅ(24, null, 2018867819, 7), 'r', ':'));
		Ⴃ(Path.GetDirectoryName((customAttributeProvider as Assembly).Location) + UtilsString.Ⴐ(null, 6, 192631474));
	}

	public void Download(string url)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		try
		{
			int num = 2;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					Ⴅ.Info(ReverseBeaconClient.Ⴗ(DownloadUrl2.Ⴅ(13, null, 2018867774, 5), url, 'Ĝ', 'Ŕ'));
					goto IL_0051;
				case 4:
					goto IL_0051;
				case 3:
					obj = new PrecisionTimer();
					((PrecisionTimer)obj).Start();
					break;
				case 5:
					break;
				}
				break;
				IL_0051:
				num = 3;
			}
			Component component = new WebClient();
			try
			{
				switch (4)
				{
				default:
					UtilsString.Ⴃ(component as WebClient, url, Ⴐ(), 'Ǟ', 460);
					break;
				case 0:
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
						num3 = ((!(component is WebClient)) ? 6 : (ⴃႤ[446] - 63148));
						goto IL_00e5;
					case 4:
					case 5:
						((IDisposable)(WebClient)component).Dispose();
						break;
					case 6:
						break;
					}
					break;
					IL_00e5:
					num2 = num3;
				}
			}
			switch (2)
			{
			default:
				(obj as PrecisionTimer).Stop();
				break;
			case 0:
			case 3:
				break;
			}
			Ⴅ.Info(DxAtlasData.Ⴄ((object)(PrecisionTimer)obj, (object)ႣႼ.Ⴜ(8, 365387083, 21), (object)url, 695, '\u02d8'));
		}
		catch (WebException ex)
		{
			Ⴅ.Error(DxAtlasData.Ⴄ((object)PrecisionTimer.Ⴜ((Exception)ex, 515, 'ɞ'), (object)ႣႼ.Ⴜ(2, 365387132, 24), (object)UtilsLatLon.Ⴍ((Exception)(ex as WebException), (short)772, (short)774), 45, 'B'));
		}
		catch (Exception ex2)
		{
			Ⴅ.Error((ex2 as Exception).Message + ႣႼ.Ⴜ(2, 365387132, 15) + ex2.InnerException);
		}
		switch (4)
		{
		}
	}

	public bool VerifyCopyDelete()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		bool result = default(bool);
		try
		{
			int num = 7;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((!Ⴀ()) ? 6 : (ⴃႤ[163] - 47489));
					continue;
				case 0:
				case 2:
					DgvFilterManager.ႭႣ(Ⴐ(), Ⴓ(), true, 850, 860);
					goto case 4;
				case 4:
					WwvSpotExt.Ⴀ(Ⴐ(), 885, 825);
					num = 5;
					continue;
				case 1:
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
			Ⴅ.Error(PrecisionTimer.Ⴜ(ex as Exception, 793, '\u0344'));
		}
		switch (0)
		{
		default:
			return false;
		case 3:
		case 4:
			return result;
		}
	}

	private bool Ⴀ()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = default(object);
		while (true)
		{
			int num = ((!StringConstants.Ⴐ(Ⴐ(), 375, 376)) ? 8 : 4);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႭ[138] - 10814;
					continue;
				case 3:
					break;
				case 4:
					obj = new FileInfo(Ⴐ());
					goto case 0;
				case 0:
					num = (((FileInfo)obj == null) ? 8 : (ⴃႣ[28] - 41385));
					continue;
				case 5:
					num = ((ServerIoCfg.ႤႷ(obj as FileInfo, 'ΐ', 'ϝ') <= 100) ? 8 : 9);
					continue;
				case 7:
				case 9:
				{
					ICloneable cloneable = UtilsDate.Ⴓ(Ⴐ(), 'Ό', 913);
					num = ((!AutoUpdater.ႨႰ((string)cloneable, ႣႼ.ႥႭ(null, 624736106, 6, null), 728, 'ʰ')) ? 8 : (ⴃႣ[28] - 41388));
					continue;
				}
				case 2:
					return true;
				case 8:
					Ⴅ.Error(UtilsString.Ⴐ(null, 3, 192631640));
					goto case 1;
				case 1:
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static Top100Update()
	{
		UtilsIdentity.Ⴐ();
		Ⴅ = ArcLogInRqstExt.Ⴍ(UtilsString.Ⴐ(null, 7, 192631677), 163, 252);
	}
}
