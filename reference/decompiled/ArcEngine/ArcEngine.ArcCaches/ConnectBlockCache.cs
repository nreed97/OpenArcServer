using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class ConnectBlockCache
{
	private static readonly ILog Ⴗ;

	private static readonly object Ⴅ;

	private CtyCacheCfg.Ⴓ Ⴍ = new CtyCacheCfg.Ⴓ();

	public ConnectBlockCache()
	{
		ISerializable serializable = new Hashtable();
		Ⴍ.Ⴈ = serializable as Hashtable;
		Init();
	}

	public void Init()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool flag = false;
		object ⴅ = default(object);
		try
		{
			switch (3)
			{
			default:
				ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 45, 36);
				try
				{
					int num = 4;
					IEvidenceFactory evidenceFactory = default(IEvidenceFactory);
					object obj = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							ShowQrz.Ⴄ(Ⴍ.Ⴈ, 604, 608);
							goto case 1;
						case 1:
						case 7:
							evidenceFactory = ShowLog.Ⴍ(352, 'Ũ');
							num = 3;
							continue;
						case 3:
							obj = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)evidenceFactory, 680, 714), 96, 'u'), ShowWxHelp.Ⴍ('Á', 985806479, 1), 121, 55);
							num = 5;
							continue;
						case 5:
							LoadConfigFile((string)obj, ShowSkimCtyHelp.Ⴍ(1216132559, 5, '\u000f'));
							goto case 2;
						case 2:
							obj = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(evidenceFactory as Assembly, 126, 28), 991, 'ϊ'), ReplyMail.Ⴅ(2, 9, 1217941660), 360, 294);
							num = 6;
							continue;
						case 6:
							LoadConfigFile(obj as string, SetStationQth.Ⴍ(null, 1687354007, 0, 19));
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Ⴗ.Error(ex.Message);
				}
				switch (1)
				{
				}
				break;
			}
		}
		finally
		{
			int num2 = 4;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 5 : (ⴃႰ[3] - 34366));
					goto IL_01b6;
				case 2:
				case 3:
					Monitor.Exit(ⴅ);
					break;
				case 5:
				case 6:
					break;
				}
				break;
				IL_01b6:
				num2 = num3;
			}
		}
		switch (1)
		{
		}
	}

	public void LoadConfigFile(string filePath, string fileName)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		if (!LogCacheCfg.Ⴗ(filePath, 81, 81))
		{
			return;
		}
		try
		{
			object obj = new PrecisionTimer();
			ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 603, 538);
			Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			try
			{
				int num = 2;
				object obj3 = default(object);
				object obj2 = default(object);
				while (true)
				{
					switch (num)
					{
					default:
						obj3 = new StreamReader((FileStream)stream);
						obj2 = SetAnnModeHelp.Ⴐ((TextReader)(obj3 as StreamReader), 'λ', 1014);
						num = 8;
						continue;
					case 1:
					case 4:
						num = ((CallBlockCacheCfg.Ⴜ(obj2 as string, 297, 328) <= 0) ? 3 : 10);
						continue;
					case 10:
						num = (SetAnnDefault.Ⴍ(obj2 as string, ႰႥ.Ⴅ(0, '\u0089', 952620226), 765, 687) ? (ⴀႨ[39] - 33476) : (ⴍႤ[152] - 62687));
						continue;
					case 0:
					case 9:
						num = (SetWxDefaultHelp.Ⴃ(Ⴍ.Ⴈ, (object)LogEntry.Ⴄ((string)obj2, 'ů', 325), 198, 220) ? (ⴀႣ[113] - 24821) : 6);
						continue;
					case 6:
						HealthMonitorCfg.Ⴍ(Ⴍ.Ⴈ, (object)SetDxFilter.Ⴀ(LogEntry.Ⴄ((string)obj2, 'ʴ', 670), 262, 'ņ'), (object)SetDxFilter.Ⴀ(LogEntry.Ⴄ((string)obj2, '/', 5), 767, 'ʿ'), (short)122, 'N');
						goto case 3;
					case 3:
						obj2 = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj3, 'ȳ', 638);
						num = ⴄႷ[129] - 22982;
						continue;
					case 7:
					case 8:
						num = (((string)obj2 != null) ? (ⴄႤ[477] - 98) : 5);
						continue;
					case 5:
						break;
					}
					break;
				}
			}
			finally
			{
				int num2 = 1;
				while (true)
				{
					int num3;
					switch (num2)
					{
					default:
						num3 = (((FileStream)stream != null) ? (ⴀႳ[66] - 4076) : 0);
						goto IL_023e;
					case 2:
					case 3:
					case 4:
						((IDisposable)(FileStream)stream).Dispose();
						break;
					case 0:
					case 5:
						break;
					}
					break;
					IL_023e:
					num2 = num3;
				}
			}
			ByeHelp.Ⴄ((PrecisionTimer)obj, 'ȅ', 598);
			ILog ⴗ = Ⴗ;
			object obj4 = new object[6];
			(obj4 as object[])[0] = obj as PrecisionTimer;
			(obj4 as object[])[1] = ReplyMailHelp.Ⴄ(9, null, 1057164832, 8);
			((object[])obj4)[2] = fileName;
			(obj4 as object[])[3] = ShowSkimCtyHelp.Ⴍ(1216133804, 5, '\u009e');
			(obj4 as object[])[4] = Ⴍ.Ⴈ.Count;
			(obj4 as object[])[5] = ShowSkimCtyHelp.Ⴍ(1216133810, 4, '1');
			ⴗ.Info(string.Concat((object[])obj4));
		}
		catch (Exception ex)
		{
			Ⴗ.Error((ex as Exception).Message);
		}
	}

	public bool IsBlocked(string call)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		bool flag = false;
		object ⴅ = default(object);
		try
		{
			ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 989, 980);
			return DxSpotUserHelp.Ⴅ(Ⴍ.Ⴈ, (object)LogEntry.Ⴄ(call, '\u032a', 768), 'ʷ', (short)678);
		}
		finally
		{
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!flag) ? 4 : (ⴀႨ[70] - 57248));
					goto IL_00b7;
				case 1:
				case 2:
				case 3:
					Monitor.Exit(ⴅ);
					break;
				case 0:
				case 4:
					break;
				}
				break;
				IL_00b7:
				num = num2;
			}
		}
	}

	static ConnectBlockCache()
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴗ = SkimmerValidSpot.Ⴐ(ReplyMailHelp.Ⴄ(26, null, 1057165233, 0), 5, 24);
				break;
			case 0:
				break;
			case 1:
				Ⴅ = new object();
				return;
			case 4:
				return;
			}
			num = 1;
		}
	}
}
