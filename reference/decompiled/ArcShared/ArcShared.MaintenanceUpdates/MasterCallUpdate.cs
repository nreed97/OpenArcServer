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

public sealed class MasterCallUpdate
{
	private static readonly ILog Ⴐ;

	private string Ⴐ;

	private DxCommentExtCfg.ႷႰ Ⴃ;

	[SpecialName]
	private string Ⴄ()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		string ⴐ = Ⴐ;
		UtilsNumeric.Ⴀ[193] = (char)((UtilsNumeric.Ⴀ[193] ^ UtilsNumeric.Ⴀ[71]) & 0x6E);
		return ⴐ;
	}

	[SpecialName]
	private void Ⴗ(string P_0)
	{
		Ⴐ = P_0;
	}

	public MasterCallUpdate()
	{
		object obj = FrmUpdateAvailable.ႷႥ(733, 691);
		IComparable comparable = ReverseBeaconClient.Ⴗ(DownloadUrl2.ႥႤ(CtyInfo.Ⴐ(obj as Assembly, 868, 863), 'Ĺ', 'ŕ'), ArcLogInRqstExt.Ⴗ(1706506627, 28, 6), '{', '3');
		Ⴃ.Ⴀ = (string)comparable;
		Ⴗ(Path.GetDirectoryName((obj as Assembly).Location) + UtilsString.Ⴐ(null, 7, 192632325));
	}

	public void Download(string url)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		try
		{
			int num = 5;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					goto IL_0030;
				case 3:
					obj = new PrecisionTimer();
					goto case 4;
				case 4:
					(obj as PrecisionTimer).Start();
					break;
				case 0:
					break;
				}
				break;
				IL_0030:
				MasterCallUpdate.Ⴐ.Info(ReverseBeaconClient.Ⴗ(ArcLogInRqstExt.Ⴗ(1706506661, 18, 8), url, '\u0095', 'Ý'));
				num = ⴀ[305] - 48558;
			}
			object obj2 = new WebClient();
			try
			{
				switch (0)
				{
				default:
					UtilsString.Ⴃ(obj2 as WebClient, url, Ⴃ.Ⴀ, '\u030a', 792);
					break;
				case 1:
				case 2:
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
						num3 = ((!(obj2 is WebClient)) ? (ⴐ[383] - 8345) : 2);
						goto IL_00f0;
					case 2:
					case 3:
						((IDisposable)(WebClient)obj2).Dispose();
						break;
					case 1:
					case 4:
					case 6:
						break;
					}
					break;
					IL_00f0:
					num2 = num3;
				}
			}
			switch (1)
			{
			default:
				(obj as PrecisionTimer).Stop();
				MasterCallUpdate.Ⴐ.Info(DxAtlasData.Ⴄ((object)(obj as PrecisionTimer), (object)DownloadUrl2.Ⴅ(19, null, 2018867977, 8), (object)url, 737, 'ʎ'));
				break;
			case 0:
			case 2:
				break;
			}
		}
		catch (WebException ex)
		{
			MasterCallUpdate.Ⴐ.Error(DxAtlasData.Ⴄ((object)PrecisionTimer.Ⴜ((Exception)(ex as WebException), 752, 'ʭ'), (object)ႣႼ.Ⴜ(5, 365387131, 14), (object)UtilsLatLon.Ⴍ((Exception)ex, (short)422, (short)420), 610, 'ȍ'));
		}
		catch (Exception ex2)
		{
			MasterCallUpdate.Ⴐ.Error((ex2 as Exception).Message + ႣႼ.Ⴜ(0, 365387134, 28) + (ex2 as Exception).InnerException);
		}
		switch (0)
		{
		}
	}

	public bool VerifyCopyDelete()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		bool result = default(bool);
		try
		{
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((!Ⴀ()) ? 7 : (ⴐ[481] - 29249));
					continue;
				case 3:
					DgvFilterManager.ႭႣ(Ⴃ.Ⴀ, Ⴄ(), true, 139, 133);
					num = ⴃႭ[71] - 17818;
					continue;
				case 1:
					WwvSpotExt.Ⴀ(Ⴃ.Ⴀ, 662, 730);
					break;
				case 0:
				case 2:
					break;
				case 7:
					goto end_IL_0010;
				}
				result = true;
				return result;
				continue;
				end_IL_0010:
				break;
			}
		}
		catch (Exception ex)
		{
			MasterCallUpdate.Ⴐ.Error(PrecisionTimer.Ⴜ(ex as Exception, 291, 'ž'));
		}
		switch (2)
		{
		default:
			return false;
		case 0:
		case 5:
			return result;
		}
	}

	private bool Ⴀ()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = default(object);
		while (true)
		{
			int num = ((!StringConstants.Ⴐ(Ⴃ.Ⴀ, 900, 907)) ? (ⴃႭ[234] - 663) : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႤ[438] - 63511;
					continue;
				case 8:
					break;
				case 0:
				case 4:
					obj = new FileInfo(Ⴃ.Ⴀ);
					num = (((FileInfo)obj == null) ? 6 : 2);
					continue;
				case 2:
					num = ((ServerIoCfg.ႤႷ((FileInfo)obj, 'ƻ', 'Ƕ') > 100) ? 1 : 6);
					continue;
				case 1:
				case 7:
				{
					IEquatable<string> equatable = UtilsDate.Ⴓ(Ⴃ.Ⴀ, '¬', 177);
					num = ((!AutoUpdater.ႨႰ(equatable as string, ႣႼ.Ⴜ(3, 365387175, 26), 446, 'ǖ')) ? (ⴃႤ[497] - 28054) : (ⴃႣ[216] - 57477));
					continue;
				}
				case 3:
				case 9:
					return true;
				case 6:
					MasterCallUpdate.Ⴐ.Error(UtilsString.Ⴐ(null, 7, 192631644));
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static MasterCallUpdate()
	{
		UtilsIdentity.Ⴐ();
		MasterCallUpdate.Ⴐ = ArcLogInRqstExt.Ⴍ(ႣႼ.ႥႭ(null, 624735946, 2, null), 229, 186);
	}
}
