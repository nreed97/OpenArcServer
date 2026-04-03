using System;
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

public sealed class IpLockoutUpdate
{
	private static readonly ILog Ⴅ;

	private UnZipFiles.Ⴐ Ⴃ = new UnZipFiles.Ⴐ();

	[SpecialName]
	private string Ⴄ()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		return Ⴃ.Ⴓ;
	}

	[SpecialName]
	private void Ⴐ(string P_0)
	{
		Ⴃ.Ⴓ = P_0;
		NeedsCfg.ႣႤ[437] = (NeedsCfg.ႣႤ[437] + NeedsCfg.ႣႤ[568]) & 0x26;
	}

	[SpecialName]
	private string Ⴀ()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		return Ⴃ.Ⴗ;
	}

	[SpecialName]
	private void Ⴀ(string P_0)
	{
		Ⴃ.Ⴗ = P_0 as string;
		TalkCfg.ႣႣ[238] = (char)((TalkCfg.ႣႣ[238] - TalkCfg.ႣႣ[15]) & 0x99);
	}

	public IpLockoutUpdate()
	{
		ICustomAttributeProvider customAttributeProvider = FrmUpdateAvailable.ႷႥ(174, 192);
		Ⴐ(ReverseBeaconClient.Ⴗ(DownloadUrl2.ႥႤ(CtyInfo.Ⴐ(customAttributeProvider as Assembly, 552, 531), '>', 'R'), DownloadUrl2.Ⴅ(12, null, 2018867909, 0), 'ɱ', 'ȹ'));
		Ⴀ(Path.GetDirectoryName(((Assembly)customAttributeProvider).Location) + UtilsString.Ⴐ(null, 1, 192631562));
	}

	public void Download(string url)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		try
		{
			int num = 3;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					Ⴅ.Info(ReverseBeaconClient.Ⴗ(DownloadUrl2.Ⴅ(13, null, 2018867945, 7), url, 'ě', 'œ'));
					goto IL_0051;
				case 5:
					goto IL_0051;
				case 0:
				case 1:
					obj = new PrecisionTimer();
					(obj as PrecisionTimer).Start();
					break;
				case 2:
					break;
				}
				break;
				IL_0051:
				char num2 = ⴐ[520];
				char num3 = ⴐ[520];
				TalkCfg.ႣႣ[223] = (char)((TalkCfg.ႣႣ[223] - TalkCfg.ႣႣ[198]) & 0x20);
				num = num2 - num3;
			}
			object obj2 = new WebClient();
			try
			{
				switch (1)
				{
				default:
					UtilsString.Ⴃ((WebClient)obj2, url, Ⴄ(), 'ʇ', 661);
					break;
				}
			}
			finally
			{
				int num4 = 0;
				while (true)
				{
					int num5;
					switch (num4)
					{
					default:
						num5 = (((WebClient)obj2 == null) ? 1 : 2);
						goto IL_0110;
					case 2:
					case 4:
						((IDisposable)(WebClient)obj2).Dispose();
						break;
					case 1:
					case 3:
						break;
					}
					break;
					IL_0110:
					num4 = num5;
				}
			}
			switch (4)
			{
			default:
				((PrecisionTimer)obj).Stop();
				Ⴅ.Info(DxAtlasData.Ⴄ((object)(PrecisionTimer)obj, (object)ႣႼ.Ⴜ(4, 365387120, 22), (object)url, 140, 'ã'));
				break;
			case 3:
				break;
			}
		}
		catch (WebException ex)
		{
			Ⴅ.Error(DxAtlasData.Ⴄ((object)PrecisionTimer.Ⴜ((Exception)ex, 308, 'ũ'), (object)ႣႼ.Ⴜ(3, 365387133, 27), (object)UtilsLatLon.Ⴍ((Exception)(ex as WebException), (short)1019, (short)1017), 574, 'ɑ'));
		}
		catch (Exception ex2)
		{
			Ⴅ.Error((ex2 as Exception).Message + ႣႼ.Ⴜ(8, 365387126, 0) + (ex2 as Exception).InnerException);
		}
		switch (1)
		{
		}
	}

	public bool VerifyCopyDelete()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		bool flag = default(bool);
		try
		{
			int num = 6;
			while (true)
			{
				switch (num)
				{
				default:
					num = (Ⴈ() ? 1 : (ⴀ[270] - 15080));
					continue;
				case 1:
				case 5:
					DgvFilterManager.ႭႣ(Ⴄ(), Ⴀ(), true, 880, 894);
					WwvSpotExt.Ⴀ(Ⴄ(), 652, 704);
					goto case 3;
				case 3:
				case 7:
					num = ⴃႣ[83] - 56480;
					continue;
				case 4:
					flag = true;
					return flag;
				case 2:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴅ.Error(PrecisionTimer.Ⴜ(ex, 651, '\u02d6'));
		}
		return 2 switch
		{
			5 => flag, 
			_ => false, 
		};
	}

	private bool Ⴈ()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		FileSystemInfo fileSystemInfo = default(FileSystemInfo);
		while (true)
		{
			int num = ((!StringConstants.Ⴐ(Ⴄ(), 768, 783)) ? (ⴃႭ[234] - 662) : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2:
				case 5:
					break;
				case 0:
					fileSystemInfo = new FileInfo(Ⴄ());
					goto case 1;
				case 1:
					num = ((!(fileSystemInfo is FileInfo)) ? 7 : 3);
					continue;
				case 3:
					num = ((ServerIoCfg.ႤႷ(fileSystemInfo as FileInfo, '½', 'ð') <= 100) ? (ⴀ[13] - 62459) : (ⴐ[162] - 54120));
					continue;
				case 6:
				case 8:
				{
					IConvertible convertible = UtilsDate.Ⴓ(Ⴄ(), 'ſ', 354);
					num = ((!AutoUpdater.ႨႰ((string)convertible, ႣႼ.ႥႭ(null, 624736092, 2, null), 173, 'Å')) ? 7 : 9);
					continue;
				}
				case 9:
					return true;
				case 7:
					Ⴅ.Error(UtilsString.Ⴐ(null, 6, 192631645));
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static IpLockoutUpdate()
	{
		UtilsIdentity.Ⴐ();
		Ⴅ = ArcLogInRqstExt.Ⴍ(UtilsString.Ⴐ(null, 2, 192631598), 440, 487);
	}
}
