using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Reflection;
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

public sealed class LotwUpdate
{
	private static readonly ILog Ⴀ;

	private string Ⴃ;

	private DxCommentExtCfg.ႷႰ Ⴄ;

	public LotwUpdate()
	{
		IEvidenceFactory evidenceFactory = FrmUpdateAvailable.ႷႥ(778, 868);
		IComparable comparable = ReverseBeaconClient.Ⴗ(DownloadUrl2.ႥႤ(CtyInfo.Ⴐ(evidenceFactory as Assembly, 341, 366), '\u0017', '{'), ႣႼ.Ⴜ(6, 365386793, 28), '\u0095', 'Ý');
		Ⴄ.Ⴀ = (string)comparable;
		Ⴃ = Path.GetDirectoryName((evidenceFactory as Assembly).Location) + ႣႼ.ႥႭ(null, 624735978, 7, null);
	}

	public void Download(string url)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		try
		{
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					Ⴀ.Info(ReverseBeaconClient.Ⴗ(ႣႼ.Ⴜ(8, 365387724, 18), url, '\u030a', '\u0342'));
					break;
				case 1:
				case 5:
					break;
				case 0:
				case 2:
				{
					object obj = new PrecisionTimer();
					((PrecisionTimer)obj).Start();
					Component component = new WebClient();
					try
					{
						switch (3)
						{
						default:
							UtilsString.Ⴃ(component as WebClient, url, Ⴄ.Ⴀ, 'ˡ', 755);
							break;
						case 1:
						case 2:
						case 4:
							break;
						}
					}
					finally
					{
						int num2 = 5;
						while (true)
						{
							int num3;
							switch (num2)
							{
							default:
								num3 = ((component is WebClient) ? 1 : (ⴃႣ[119] - 27086));
								goto IL_00dc;
							case 1:
							case 6:
								((IDisposable)(WebClient)component).Dispose();
								break;
							case 2:
								break;
							}
							break;
							IL_00dc:
							num2 = num3;
						}
					}
					switch (0)
					{
					default:
						((PrecisionTimer)obj).Stop();
						break;
					case 2:
						break;
					case 4:
						goto end_IL_000a;
					}
					Ⴀ.Info(DxAtlasData.Ⴄ((object)(obj as PrecisionTimer), (object)ArcLogInRqstExt.Ⴗ(1706506714, 19, 8), (object)url, 752, 'ʟ'));
					goto end_IL_000a;
				}
				}
				num = 0;
				continue;
				end_IL_000a:
				break;
			}
		}
		catch (WebException ex)
		{
			Ⴀ.Error(DxAtlasData.Ⴄ((object)PrecisionTimer.Ⴜ((Exception)(ex as WebException), 422, 'ǻ'), (object)ႣႼ.Ⴜ(5, 365387131, 14), (object)UtilsLatLon.Ⴍ((Exception)ex, (short)610, (short)608), 139, 'ä'));
		}
		catch (Exception ex2)
		{
			Ⴀ.Error(ex2.Message + ႣႼ.Ⴜ(0, 365387134, 28) + ex2.InnerException);
		}
		switch (0)
		{
		}
	}

	public bool VerifyCopyDelete()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		bool result = default(bool);
		try
		{
			int num = 6;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((!Ⴐ()) ? 3 : 4);
					continue;
				case 4:
				{
					DgvFilterManager.ႭႣ(Ⴄ.Ⴀ, Ⴃ, true, 662, 664);
					int num2 = ⴃႤ[457];
					DataGridViewColumnSelector.Ⴐ[612] = (char)((DataGridViewColumnSelector.Ⴐ[612] + DataGridViewColumnSelector.Ⴐ[104]) & 0xB7);
					num = num2 - 56250;
					continue;
				}
				case 0:
				case 5:
					WwvSpotExt.Ⴀ(Ⴄ.Ⴀ, 291, 367);
					result = true;
					return result;
				case 2:
				case 3:
				case 7:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴀ.Error(PrecisionTimer.Ⴜ(ex, 907, 'ϖ'));
		}
		switch (2)
		{
		default:
			return false;
		case 0:
		case 1:
			return result;
		}
	}

	private bool Ⴐ()
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = default(object);
		while (true)
		{
			int num = ((!StringConstants.Ⴐ(Ⴄ.Ⴀ, 436, 443)) ? (ⴃႣ[204] - 46601) : (ⴃႣ[36] - 35705));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴗ[135] - 48377;
					continue;
				case 4:
					break;
				case 7:
					obj = new FileInfo(Ⴄ.Ⴀ);
					goto case 5;
				case 5:
				case 9:
					num = (((FileInfo)obj == null) ? 6 : 3);
					continue;
				case 3:
					num = ((ServerIoCfg.ႤႷ((FileInfo)obj, '±', 'ü') <= 100) ? 6 : 0);
					continue;
				case 0:
				case 1:
				{
					IEnumerable enumerable = UtilsDate.Ⴓ(Ⴄ.Ⴀ, 'ǋ', 470);
					num = ((!AutoUpdater.ႨႰ(enumerable as string, ႣႼ.Ⴜ(3, 365387175, 26), 141, 'å')) ? 6 : 2);
					continue;
				}
				case 2:
					return true;
				case 6:
					Ⴀ.Error(UtilsString.Ⴐ(null, 7, 192631644));
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static LotwUpdate()
	{
		UtilsIdentity.Ⴐ();
		Ⴀ = ArcLogInRqstExt.Ⴍ(TelnetServerClient.Ⴄ(1945322687, '¬', 2), 511, 416);
	}
}
