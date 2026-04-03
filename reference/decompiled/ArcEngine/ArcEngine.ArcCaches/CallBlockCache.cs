using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Threading;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class CallBlockCache
{
	private static readonly ILog Ⴍ;

	private static readonly object Ⴐ;

	private CtyCacheCfg.Ⴓ Ⴃ = new CtyCacheCfg.Ⴓ();

	public CallBlockCache()
	{
		object obj = new Hashtable();
		Ⴃ.Ⴈ = (Hashtable)obj;
		Init();
	}

	public void Init()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		bool flag = false;
		object ⴐ = default(object);
		try
		{
			switch (0)
			{
			default:
				ႨႥ.Ⴍ(ⴐ = Ⴐ, ref flag, 106, 99);
				try
				{
					int num = 3;
					object obj = default(object);
					IComparable comparable = default(IComparable);
					while (true)
					{
						switch (num)
						{
						default:
							ShowQrz.Ⴄ(Ⴃ.Ⴈ, 887, 843);
							goto case 1;
						case 1:
							obj = ShowLog.Ⴍ(576, 'Ɉ');
							num = 2;
							continue;
						case 2:
							comparable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)obj, 857, 827), 696, 'ʭ'), ShowWxHelp.Ⴍ('\f', 985808327, 0), 748, 674);
							goto case 6;
						case 6:
							num = ⴅ[6];
							continue;
						case 0:
							LoadConfigFile(comparable as string, ShowSkimCtyHelp.Ⴍ(1216133786, 3, 'H'));
							comparable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(obj as Assembly, 236, 142), 74, '_'), ReplyMail.Ⴅ(6, 10, 1217945482), 696, 758);
							goto case 5;
						case 5:
							num = 7;
							continue;
						case 7:
							LoadConfigFile((string)comparable, SetStationQth.Ⴍ(null, 1687352285, 5, 9));
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Ⴍ.Error((ex as Exception).Message);
				}
				switch (4)
				{
				}
				break;
			}
		}
		finally
		{
			int num2 = 0;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 1 : 6);
					goto IL_01b9;
				case 2:
				case 6:
					Monitor.Exit(ⴐ);
					break;
				case 1:
				case 5:
					break;
				}
				break;
				IL_01b9:
				num2 = num3;
			}
		}
		switch (2)
		{
		}
	}

	public void LoadConfigFile(string filePath, string fileName)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		if (!LogCacheCfg.Ⴗ(filePath, 74, 74))
		{
			return;
		}
		try
		{
			object obj = new PrecisionTimer();
			ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 684, 749);
			object obj2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			try
			{
				int num = 7;
				object obj4 = default(object);
				object obj3 = default(object);
				while (true)
				{
					switch (num)
					{
					default:
						obj4 = new StreamReader(obj2 as FileStream);
						obj3 = SetAnnModeHelp.Ⴐ((TextReader)(obj4 as StreamReader), 'ɼ', 561);
						num = 8;
						continue;
					case 3:
						num = ((CallBlockCacheCfg.Ⴜ(obj3 as string, 40, 73) > 0) ? (ⴃႥ[153] - 24217) : 0);
						continue;
					case 2:
					case 4:
					case 6:
					{
						bool num2 = SetAnnDefault.Ⴍ((string)obj3, ႰႥ.Ⴅ(8, '\u008a', 952620234), 292, 374);
						ShowSunHelp.ႣႠ[280] = (char)((ShowSunHelp.ႣႠ[280] + ShowSunHelp.ႣႠ[134]) & 0xE5);
						num = ((!num2) ? 1 : (ⴃႠ[284] - ⴃႠ[284]));
						continue;
					}
					case 1:
					case 10:
						num = ((!SetWxDefaultHelp.Ⴃ(Ⴃ.Ⴈ, (object)LogEntry.Ⴄ(obj3 as string, 'Β', 952), 331, 337)) ? 5 : 0);
						continue;
					case 5:
						HealthMonitorCfg.Ⴍ(Ⴃ.Ⴈ, (object)SetDxFilter.Ⴀ(LogEntry.Ⴄ(obj3 as string, '\u0329', 771), 148, 'Ô'), (object)SetDxFilter.Ⴀ(LogEntry.Ⴄ(obj3 as string, 'Ȫ', 512), 769, '\u0341'), (short)212, 'à');
						goto case 0;
					case 0:
						obj3 = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj4, 'Ɠ', 478);
						num = 8;
						continue;
					case 8:
						num = ((obj3 is string) ? 3 : 9);
						continue;
					case 9:
						break;
					}
					break;
				}
			}
			finally
			{
				int num3 = 4;
				while (true)
				{
					int num4;
					switch (num3)
					{
					default:
						num4 = ((!(obj2 is FileStream)) ? (ⴍႭ[269] - 41217) : 0);
						goto IL_0236;
					case 0:
					case 1:
						((IDisposable)(FileStream)obj2).Dispose();
						break;
					case 5:
						break;
					}
					break;
					IL_0236:
					num3 = num4;
				}
			}
			ByeHelp.Ⴄ((PrecisionTimer)obj, 'ˡ', 690);
			ILog ⴍ = Ⴍ;
			Array array = new object[6];
			((object[])array)[0] = (PrecisionTimer)obj;
			(array as object[])[1] = ReplyMailHelp.Ⴄ(31, null, 1057161372, 5);
			(array as object[])[2] = fileName;
			(array as object[])[3] = ShowSkimCtyHelp.Ⴍ(1216133801, 0, 'æ');
			((object[])array)[4] = Ⴃ.Ⴈ.Count;
			(array as object[])[5] = ShowSkimCtyHelp.Ⴍ(1216133822, 8, '\u009d');
			ⴍ.Info(string.Concat((object[])array));
		}
		catch (Exception ex)
		{
			Ⴍ.Error(ex.Message);
		}
	}

	public bool IsBlocked(string call)
	{
		bool flag = false;
		object ⴐ = default(object);
		try
		{
			ႨႥ.Ⴍ(ⴐ = Ⴐ, ref flag, 724, 733);
			return DxSpotUserHelp.Ⴅ(Ⴃ.Ⴈ, (object)LogEntry.Ⴄ(call, '%', 15), 'α', (short)928);
		}
		finally
		{
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!flag) ? 1 : 5);
					goto IL_008f;
				case 5:
					Monitor.Exit(ⴐ);
					break;
				case 0:
				case 1:
				case 3:
					break;
				}
				break;
				IL_008f:
				num = num2;
			}
		}
	}

	static CallBlockCache()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴍ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216134465, 0, 'Ö'), 280, 261);
				break;
			case 2:
			case 4:
				break;
			case 1:
			case 3:
				Ⴐ = new object();
				return;
			}
			num = 3;
		}
	}
}
