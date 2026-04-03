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

public sealed class BandModeUpdate
{
	private static readonly ILog Ⴀ;

	private string Ⴓ;

	private DxCommentExtCfg.ႷႰ Ⴐ;

	[SpecialName]
	private string Ⴗ()
	{
		string ⴀ = Ⴐ.Ⴀ;
		NeedsCfg.ႣႤ[318] = (NeedsCfg.ႣႤ[318] | NeedsCfg.ႣႤ[341]) & 0x8E;
		return ⴀ;
	}

	[SpecialName]
	private void Ⴃ(string P_0)
	{
		Ⴐ.Ⴀ = P_0 as string;
		NeedsCfg.ႣႤ[244] = (NeedsCfg.ႣႤ[244] * NeedsCfg.ႣႤ[202]) & 0xA4;
	}

	[SpecialName]
	private string Ⴃ()
	{
		return Ⴓ;
	}

	[SpecialName]
	private void Ⴈ(string P_0)
	{
		Ⴓ = P_0;
	}

	public BandModeUpdate()
	{
		IEvidenceFactory evidenceFactory = FrmUpdateAvailable.ႷႥ(367, 257);
		Ⴃ(ReverseBeaconClient.Ⴗ(DownloadUrl2.ႥႤ(CtyInfo.Ⴐ(evidenceFactory as Assembly, 691, 648), '\u0308', '\u0364'), DownloadUrl2.Ⴅ(28, null, 2018868089, 6), 'ŕ', 'ĝ'));
		Ⴈ(Path.GetDirectoryName((evidenceFactory as Assembly).Location) + UtilsString.Ⴐ(null, 7, 192632353));
	}

	public void Download(string url)
	{
		try
		{
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					Ⴀ.Info(ReverseBeaconClient.Ⴗ(DownloadUrl2.Ⴅ(18, null, 2018868002, 8), url, '{', '3'));
					break;
				case 3:
					break;
				case 0:
				{
					object obj = new PrecisionTimer();
					(obj as PrecisionTimer).Start();
					Component component = new WebClient();
					try
					{
						switch (1)
						{
						default:
							UtilsString.Ⴃ((WebClient)component, url, Ⴗ(), '\u0095', 135);
							break;
						}
					}
					finally
					{
						int num2 = 2;
						while (true)
						{
							int num3;
							switch (num2)
							{
							default:
								num3 = (((WebClient)component == null) ? 5 : 6);
								goto IL_00cb;
							case 0:
							case 3:
							case 6:
								((IDisposable)(component as WebClient)).Dispose();
								break;
							case 4:
							case 5:
								break;
							}
							break;
							IL_00cb:
							num2 = num3;
						}
					}
					switch (3)
					{
					default:
						((PrecisionTimer)obj).Stop();
						break;
					case 0:
						break;
					}
					Ⴀ.Info(DxAtlasData.Ⴄ((object)(PrecisionTimer)obj, (object)ႣႼ.Ⴜ(8, 365387757, 19), (object)url, 778, '\u0365'));
					goto end_IL_0003;
				}
				}
				num = 0;
				continue;
				end_IL_0003:
				break;
			}
		}
		catch (WebException ex)
		{
			Ⴀ.Error(DxAtlasData.Ⴄ((object)PrecisionTimer.Ⴜ((Exception)(ex as WebException), 737, 'ʼ'), (object)ႣႼ.Ⴜ(5, 365387131, 14), (object)UtilsLatLon.Ⴍ((Exception)(ex as WebException), (short)752, (short)754), 422, 'ǉ'));
		}
		catch (Exception ex2)
		{
			Ⴀ.Error(ex2.Message + ႣႼ.Ⴜ(0, 365387134, 28) + ex2.InnerException);
		}
		switch (2)
		{
		}
	}

	public bool VerifyCopyDelete()
	{
		bool result = default(bool);
		try
		{
			int num = 0;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((!Ⴈ()) ? 2 : 6);
					continue;
				case 6:
					DgvFilterManager.ႭႣ(Ⴗ(), Ⴃ(), true, 610, 620);
					WwvSpotExt.Ⴀ(Ⴗ(), 139, 199);
					num = 5;
					continue;
				case 5:
				case 7:
					result = true;
					return result;
				case 2:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴀ.Error(PrecisionTimer.Ⴜ(ex as Exception, 662, 'ˋ'));
		}
		switch (5)
		{
		default:
			return false;
		case 1:
		case 3:
			return result;
		}
	}

	private bool Ⴈ()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = default(object);
		while (true)
		{
			int num = ((!StringConstants.Ⴐ(Ⴗ(), 300, 291)) ? (ⴃႤ[427] - 50427) : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႤ[26] - 59782;
					continue;
				case 6:
					break;
				case 0:
				case 7:
					obj = new FileInfo(Ⴗ());
					num = (((FileInfo)obj == null) ? (ⴐ[90] - 34730) : 2);
					continue;
				case 2:
					num = ((ServerIoCfg.ႤႷ(obj as FileInfo, '\u038b', 'φ') <= 100) ? 9 : (ⴗ[28] - 12121));
					continue;
				case 3:
				{
					IComparable comparable = UtilsDate.Ⴓ(Ⴗ(), 'Ʀ', 443);
					num = (AutoUpdater.ႨႰ((string)comparable, ႣႼ.ႥႭ(null, 624735932, 3, null), 217, '±') ? 1 : (ⴗ[93] - 708));
					continue;
				}
				case 1:
					return true;
				case 5:
				case 9:
					Ⴀ.Error(UtilsString.Ⴐ(null, 7, 192631644));
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static BandModeUpdate()
	{
		UtilsIdentity.Ⴐ();
		Ⴀ = ArcLogInRqstExt.Ⴍ(UtilsString.Ⴐ(null, 7, 192632527), 470, 393);
	}
}
