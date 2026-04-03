using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
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

public sealed class BadWordUpdate
{
	private static readonly ILog m_Ⴗ;

	private string m_Ⴃ;

	private DxCommentExtCfg.ႷႰ Ⴅ;

	[SpecialName]
	private string Ⴄ()
	{
		return Ⴅ.Ⴀ;
	}

	[SpecialName]
	private void Ⴀ(string P_0)
	{
		Ⴅ.Ⴀ = P_0;
	}

	[SpecialName]
	private string Ⴗ()
	{
		return this.m_Ⴃ;
	}

	[SpecialName]
	private void Ⴃ(string P_0)
	{
		this.m_Ⴃ = P_0;
	}

	public BadWordUpdate()
	{
		ISerializable serializable = FrmUpdateAvailable.ႷႥ(712, 678);
		Ⴀ(ReverseBeaconClient.Ⴗ(DownloadUrl2.ႥႤ(CtyInfo.Ⴐ(serializable as Assembly, 338, 361), 'ɒ', 'Ⱦ'), DownloadUrl2.Ⴅ(15, null, 2018868857, 1), 'ɣ', 'ȫ'));
		Ⴃ(Path.GetDirectoryName((serializable as Assembly).Location) + UtilsString.Ⴐ(null, 0, 192633426));
	}

	public void Download(string url)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		try
		{
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					BadWordUpdate.m_Ⴗ.Info(ReverseBeaconClient.Ⴗ(DownloadUrl2.Ⴅ(6, null, 2018868737, 2), url, 'Ü', '\u0094'));
					break;
				case 2:
				case 4:
					break;
				case 3:
				case 5:
				{
					object obj = new PrecisionTimer();
					(obj as PrecisionTimer).Start();
					object obj2 = new WebClient();
					try
					{
						switch (0)
						{
						default:
							UtilsString.Ⴃ(obj2 as WebClient, url, Ⴄ(), 'ŝ', 335);
							break;
						case 2:
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
								num3 = (((WebClient)obj2 == null) ? (ⴀ[287] - 5922) : 3);
								goto IL_00eb;
							case 3:
								((IDisposable)(obj2 as WebClient)).Dispose();
								break;
							case 2:
								break;
							}
							break;
							IL_00eb:
							num2 = num3;
						}
					}
					switch (2)
					{
					default:
						(obj as PrecisionTimer).Stop();
						break;
					case 3:
					case 4:
						break;
					case 0:
						goto end_IL_0011;
					}
					BadWordUpdate.m_Ⴗ.Info(DxAtlasData.Ⴄ((object)(obj as PrecisionTimer), (object)ႣႼ.Ⴜ(2, 365387281, 22), (object)url, 45, 'B'));
					goto end_IL_0011;
				}
				}
				num = ⴃႭ[249] - 12439;
				continue;
				end_IL_0011:
				break;
			}
		}
		catch (WebException ex)
		{
			BadWordUpdate.m_Ⴗ.Error(DxAtlasData.Ⴄ((object)PrecisionTimer.Ⴜ((Exception)(ex as WebException), 869, '\u0338'), (object)ႣႼ.Ⴜ(1, 365387135, 1), (object)UtilsLatLon.Ⴍ((Exception)ex, (short)560, (short)562), 868, '\u030b'));
		}
		catch (Exception ex2)
		{
			BadWordUpdate.m_Ⴗ.Error(ex2.Message + ႣႼ.Ⴜ(3, 365387133, 9) + ex2.InnerException);
		}
		switch (4)
		{
		}
	}

	public bool VerifyCopyDelete()
	{
		bool result = default(bool);
		try
		{
			int num = 6;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((!Ⴀ()) ? 2 : 0);
					continue;
				case 0:
					DgvFilterManager.ႭႣ(Ⴄ(), Ⴗ(), true, 27, 21);
					WwvSpotExt.Ⴀ(Ⴄ(), 184, 244);
					num = 3;
					continue;
				case 3:
					result = true;
					return result;
				case 7:
					break;
				case 2:
				case 5:
					goto IL_008e;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			BadWordUpdate.m_Ⴗ.Error(PrecisionTimer.Ⴜ(ex, 220, '\u0081'));
			goto IL_008e;
		}
		goto IL_00b2;
		IL_008e:
		switch (5)
		{
		default:
			return false;
		case 2:
			break;
		}
		goto IL_00b2;
		IL_00b2:
		return result;
	}

	private bool Ⴀ()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = default(object);
		while (true)
		{
			int num = (StringConstants.Ⴐ(Ⴄ(), 24, 23) ? 1 : 6);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႤ[482] - 36631;
					continue;
				case 0:
				case 3:
					break;
				case 1:
					obj = new FileInfo(Ⴄ());
					num = ((!(obj is FileInfo)) ? 6 : 5);
					continue;
				case 5:
					num = ((ServerIoCfg.ႤႷ(obj as FileInfo, 'Ȭ', 'ɡ') <= 100) ? 6 : (ⴀ[64] - 39824));
					continue;
				case 7:
				{
					IComparable<string> comparable = UtilsDate.Ⴓ(Ⴄ(), 'ƈ', 405);
					num = ((!AutoUpdater.ႨႰ((string)comparable, ႣႼ.ႥႭ(null, 624735476, 8, null), 488, 'ƀ')) ? (ⴃႭ[124] - 30970) : (ⴃႣ[127] - 15238));
					continue;
				}
				case 4:
					return true;
				case 6:
					BadWordUpdate.m_Ⴗ.Error(UtilsString.Ⴐ(null, 0, 192631643));
					goto case 8;
				case 8:
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static BadWordUpdate()
	{
		UtilsIdentity.Ⴐ();
		BadWordUpdate.m_Ⴗ = ArcLogInRqstExt.Ⴍ(UtilsString.Ⴐ(null, 5, 192633456), 361, 310);
	}
}
