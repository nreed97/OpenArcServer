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

public sealed class CallBlockUpdate
{
	private static readonly ILog Ⴃ;

	private UnZipFiles.Ⴐ Ⴗ = new UnZipFiles.Ⴐ();

	[SpecialName]
	private string Ⴈ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		return Ⴗ.Ⴓ;
	}

	[SpecialName]
	private void Ⴀ(string P_0)
	{
		Ⴗ.Ⴓ = P_0 as string;
		UtilsNumeric.Ⴀ[224] = (char)(UtilsNumeric.Ⴀ[224] & UtilsNumeric.Ⴀ[415] & 0x2E);
	}

	[SpecialName]
	private string Ⴅ()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		return Ⴗ.Ⴗ;
	}

	[SpecialName]
	private void Ⴄ(string P_0)
	{
		Ⴗ.Ⴗ = P_0;
	}

	public CallBlockUpdate()
	{
		IEvidenceFactory evidenceFactory = FrmUpdateAvailable.ႷႥ(756, 666);
		Ⴀ(ReverseBeaconClient.Ⴗ(DownloadUrl2.ႥႤ(CtyInfo.Ⴐ((Assembly)evidenceFactory, 363, 336), '\u0341', '\u032d'), DownloadUrl2.Ⴅ(1, null, 2018868280, 3), 'ų', 'Ļ'));
		Ⴄ(Path.GetDirectoryName((evidenceFactory as Assembly).Location) + UtilsString.Ⴐ(null, 5, 192632900));
	}

	public void Download(string url)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		try
		{
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					Ⴃ.Info(ReverseBeaconClient.Ⴗ(DownloadUrl2.Ⴅ(18, null, 2018868446, 2), url, 'Ƃ', 'Ǌ'));
					break;
				case 1:
				case 2:
					break;
				case 0:
				case 3:
				{
					object obj = new PrecisionTimer();
					((PrecisionTimer)obj).Start();
					Component component = new WebClient();
					try
					{
						switch (1)
						{
						default:
							UtilsString.Ⴃ(component as WebClient, url, Ⴈ(), 'h', 122);
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
								num3 = ((!(component is WebClient)) ? (ⴐ[14] - 34481) : 0);
								goto IL_00e3;
							case 0:
							case 2:
								((IDisposable)(component as WebClient)).Dispose();
								break;
							case 5:
							case 6:
								break;
							}
							break;
							IL_00e3:
							num2 = num3;
						}
					}
					switch (0)
					{
					default:
						(obj as PrecisionTimer).Stop();
						Ⴃ.Info(DxAtlasData.Ⴄ((object)(obj as PrecisionTimer), (object)ႣႼ.Ⴜ(7, 365385800, 12), (object)url, 649, '\u02e6'));
						break;
					case 1:
						break;
					}
					goto end_IL_0011;
				}
				}
				num = ⴃႤ[76] - 33766;
				continue;
				end_IL_0011:
				break;
			}
		}
		catch (WebException ex)
		{
			Ⴃ.Error(DxAtlasData.Ⴄ((object)PrecisionTimer.Ⴜ((Exception)(ex as WebException), 356, 'Ĺ'), (object)ႣႼ.Ⴜ(0, 365387134, 13), (object)UtilsLatLon.Ⴍ((Exception)(ex as WebException), (short)957, (short)959), 217, '¶'));
		}
		catch (Exception ex2)
		{
			Ⴃ.Error(ex2.Message + ႣႼ.Ⴜ(7, 365387129, 27) + ex2.InnerException);
		}
		switch (3)
		{
		}
	}

	public bool VerifyCopyDelete()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool result = default(bool);
		try
		{
			int num = 7;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((!Ⴐ()) ? 5 : 2);
					continue;
				case 1:
				case 2:
					DgvFilterManager.ႭႣ(Ⴈ(), Ⴅ(), true, 303, 289);
					WwvSpotExt.Ⴀ(Ⴈ(), 32, 108);
					num = ⴀ[270] - 15078;
					continue;
				case 4:
					result = true;
					return result;
				case 5:
				case 6:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴃ.Error(PrecisionTimer.Ⴜ(ex, 90, '\a'));
		}
		switch (2)
		{
		default:
			return false;
		case 1:
		case 4:
		case 5:
			return result;
		}
	}

	private bool Ⴐ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj2 = default(object);
		while (true)
		{
			int num = ((!StringConstants.Ⴐ(Ⴈ(), 690, 701)) ? 6 : (ⴃႤ[458] - 64769));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀ[61] - 55676;
					continue;
				case 4:
					break;
				case 0:
				case 7:
					obj2 = new FileInfo(Ⴈ());
					goto case 2;
				case 2:
					num = (((FileInfo)obj2 == null) ? 6 : (ⴃႭ[216] - 27131));
					continue;
				case 8:
					num = ((ServerIoCfg.ႤႷ(obj2 as FileInfo, 'ʊ', 'ˇ') <= 100) ? 6 : (ⴗ[28] - 12119));
					continue;
				case 5:
				{
					object obj = UtilsDate.Ⴓ(Ⴈ(), 'ʂ', 671);
					num = ((!AutoUpdater.ႨႰ(obj as string, ႣႼ.ႥႭ(null, 624735461, 7, null), 950, 'Ϟ')) ? 6 : (ⴃႣ[239] - 39449));
					continue;
				}
				case 3:
					return true;
				case 1:
				case 6:
					Ⴃ.Error(UtilsString.Ⴐ(null, 1, 192631642));
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static CallBlockUpdate()
	{
		UtilsIdentity.Ⴐ();
		Ⴃ = ArcLogInRqstExt.Ⴍ(UtilsString.Ⴐ(null, 3, 192632937), 978, 909);
	}
}
