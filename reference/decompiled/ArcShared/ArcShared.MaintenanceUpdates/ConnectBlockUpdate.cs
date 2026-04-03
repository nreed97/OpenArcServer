using System;
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
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using Ⴃ;

namespace ArcShared.MaintenanceUpdates;

public sealed class ConnectBlockUpdate
{
	private static readonly ILog Ⴅ;

	private string m_Ⴃ;

	private DxCommentExtCfg.ႷႰ Ⴍ;

	[SpecialName]
	private string Ⴃ()
	{
		string ⴀ = Ⴍ.Ⴀ;
		DataGridViewColumnSelector.Ⴐ[4] = (char)((DataGridViewColumnSelector.Ⴐ[4] * DataGridViewColumnSelector.Ⴐ[536]) & 0x4B);
		return ⴀ;
	}

	[SpecialName]
	private void Ⴀ(string P_0)
	{
		Ⴍ.Ⴀ = P_0;
	}

	[SpecialName]
	private string Ⴈ()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		return this.m_Ⴃ;
	}

	[SpecialName]
	private void Ⴓ(string P_0)
	{
		this.m_Ⴃ = P_0;
	}

	public ConnectBlockUpdate()
	{
		ISerializable serializable = FrmUpdateAvailable.ႷႥ(6, 104);
		Ⴀ(ReverseBeaconClient.Ⴗ(DownloadUrl2.ႥႤ(CtyInfo.Ⴐ(serializable as Assembly, 649, 690), 'Ĉ', 'Ť'), DownloadUrl2.Ⴅ(12, null, 2018868779, 7), 'ν', 'ϵ'));
		Ⴓ(Path.GetDirectoryName((serializable as Assembly).Location) + UtilsString.Ⴐ(null, 0, 192633572));
	}

	public void Download(string url)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		try
		{
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					object obj = new PrecisionTimer();
					((PrecisionTimer)obj).Start();
					Component component = new WebClient();
					try
					{
						switch (1)
						{
						default:
							UtilsString.Ⴃ(component as WebClient, url, Ⴃ(), 'į', 317);
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
								num3 = (((WebClient)component != null) ? 1 : 3);
								goto IL_00e5;
							case 1:
							case 4:
								((IDisposable)(component as WebClient)).Dispose();
								break;
							case 0:
							case 3:
							case 6:
								break;
							}
							break;
							IL_00e5:
							num2 = num3;
						}
					}
					switch (3)
					{
					default:
						((PrecisionTimer)obj).Stop();
						Ⴅ.Info(DxAtlasData.Ⴄ((object)(PrecisionTimer)obj, (object)ႣႼ.Ⴜ(7, 365386152, 28), (object)url, 32, 'O'));
						break;
					case 4:
						break;
					}
					goto end_IL_000a;
				}
				}
				Ⴅ.Info(ReverseBeaconClient.Ⴗ(DownloadUrl2.Ⴅ(27, null, 2018868985, 3), url, 'Ù', '\u0091'));
				num = ⴃႤ[608] - 18935;
				continue;
				end_IL_000a:
				break;
			}
		}
		catch (WebException ex)
		{
			Ⴅ.Error(DxAtlasData.Ⴄ((object)PrecisionTimer.Ⴜ((Exception)(ex as WebException), 90, '\a'), (object)ႣႼ.Ⴜ(1, 365387135, 11), (object)UtilsLatLon.Ⴍ((Exception)(ex as WebException), (short)701, (short)703), 650, '\u02e5'));
		}
		catch (Exception ex2)
		{
			Ⴅ.Error((ex2 as Exception).Message + ႣႼ.Ⴜ(5, 365387131, 11) + (ex2 as Exception).InnerException);
		}
		switch (2)
		{
		}
	}

	public bool VerifyCopyDelete()
	{
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
				{
					bool num2 = Ⴓ();
					UtilsNumeric.Ⴀ[297] = (char)((UtilsNumeric.Ⴀ[297] | UtilsNumeric.Ⴀ[200]) & 0xA7);
					num = ((!num2) ? 3 : 5);
					continue;
				}
				case 5:
					DgvFilterManager.ႭႣ(Ⴃ(), Ⴈ(), true, 671, 657);
					WwvSpotExt.Ⴀ(Ⴃ(), 990, 914);
					num = ⴃႣ[30] - 55092;
					continue;
				case 4:
					result = true;
					return result;
				case 6:
				case 7:
					break;
				case 0:
				case 3:
					goto IL_00d0;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴅ.Error(PrecisionTimer.Ⴜ(ex as Exception, 978, 'Ώ'));
			goto IL_00d0;
		}
		goto IL_00f4;
		IL_00d0:
		switch (5)
		{
		default:
			return false;
		case 1:
			break;
		}
		goto IL_00f4;
		IL_00f4:
		return result;
	}

	private bool Ⴓ()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		FileSystemInfo fileSystemInfo = default(FileSystemInfo);
		while (true)
		{
			int num = ((!StringConstants.Ⴐ(Ⴃ(), 917, 922)) ? 5 : (ⴃႭ[260] - 31177));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 4;
					continue;
				case 1:
				case 4:
					break;
				case 2:
				case 3:
					fileSystemInfo = new FileInfo(Ⴃ());
					num = (((FileInfo)fileSystemInfo == null) ? 5 : 9);
					continue;
				case 9:
					num = ((ServerIoCfg.ႤႷ(fileSystemInfo as FileInfo, 'ɓ', 'Ȟ') <= 100) ? 5 : 0);
					continue;
				case 0:
				case 7:
				{
					IComparable comparable = UtilsDate.Ⴓ(Ⴃ(), 'Í', 208);
					num = ((!AutoUpdater.ႨႰ((string)comparable, ႣႼ.ႥႭ(null, 624735461, 7, null), 534, 'ɾ')) ? 5 : 6);
					continue;
				}
				case 6:
					return true;
				case 5:
					Ⴅ.Error(UtilsString.Ⴐ(null, 3, 192631640));
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static ConnectBlockUpdate()
	{
		UtilsIdentity.Ⴐ();
		Ⴅ = ArcLogInRqstExt.Ⴍ(UtilsString.Ⴐ(null, 3, 192633481), 776, 855);
	}
}
