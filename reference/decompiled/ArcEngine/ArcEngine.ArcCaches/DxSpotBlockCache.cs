using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class DxSpotBlockCache
{
	private static readonly ILog Ⴍ;

	private static readonly object Ⴈ;

	private readonly Hashtable Ⴓ;

	public DxSpotBlockCache()
	{
		Ⴓ = new Hashtable();
		Init();
	}

	public void Init()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		bool flag = false;
		object ⴈ = default(object);
		try
		{
			int num = 0;
			object obj = default(object);
			IConvertible convertible = default(IConvertible);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴈ = Ⴈ, ref flag, 29, 20);
					ShowQrz.Ⴄ(Ⴓ, 969, 1013);
					num = ⴀ[52] - 59010;
					continue;
				case 6:
					obj = ShowLog.Ⴍ(996, 'Ϭ');
					convertible = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(obj as Assembly, 205, 175), 618, 'ɿ'), ReplyMailHelp.Ⴄ(25, null, 1057167231, 4), 41, 103);
					num = ⴀႳ[263] - 11619;
					continue;
				case 4:
				case 7:
					LoadConfigFile(convertible as string, ReplyMail.Ⴅ(3, 9, 1217940673));
					goto case 1;
				case 1:
				case 3:
					convertible = SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)obj, 954, 984), 750, '\u02fb') + SetStationClubHelp.Ⴍ(9, 3, 1747262785, null);
					num = ⴄႷ[12] - 43771;
					continue;
				case 2:
					LoadConfigFile(convertible as string, ShowWxHelp.Ⴍ('Â', 985805475, 3));
					break;
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
					num3 = ((!flag) ? (ⴄႭ[58] - 243) : (ⴀႨ[112] - 20953));
					goto IL_019b;
				case 5:
					Monitor.Exit(ⴈ);
					break;
				case 1:
				case 6:
					break;
				}
				break;
				IL_019b:
				num2 = num3;
			}
		}
		switch (1)
		{
		}
	}

	public void LoadConfigFile(string filePath, string fileName)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		try
		{
			int num = 2;
			object obj = default(object);
			TextReader textReader = default(TextReader);
			IConvertible convertible = default(IConvertible);
			while (true)
			{
				switch (num)
				{
				default:
					if (LogCacheCfg.Ⴗ(filePath, 695, 695))
					{
						goto IL_0041;
					}
					return;
				case 4:
					obj = new PrecisionTimer();
					goto case 3;
				case 3:
					ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 498, 435);
					break;
				case 0:
				case 1:
					break;
				}
				object obj2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
				try
				{
					int num2 = 9;
					while (true)
					{
						switch (num2)
						{
						default:
							textReader = new StreamReader((FileStream)obj2);
							goto case 10;
						case 10:
							convertible = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)textReader, 'ū', 294);
							num2 = 0;
							continue;
						case 2:
							num2 = (SetAnnDefault.Ⴍ((string)convertible, ႰႥ.Ⴅ(3, ']', 952620225), 267, 345) ? 5 : (ⴀႣ[42] - 30801));
							continue;
						case 7:
							num2 = ((CallBlockCacheCfg.Ⴜ(convertible as string, 150, 247) <= 0) ? 5 : 3);
							continue;
						case 3:
						case 8:
							num2 = ((!SetWxDefaultHelp.Ⴃ(Ⴓ, (object)(string)convertible, 252, 230)) ? 1 : 5);
							continue;
						case 1:
							HealthMonitorCfg.Ⴍ(Ⴓ, (object)(convertible as string), (object)(string)convertible, (short)117, 'A');
							goto case 4;
						case 4:
						case 5:
							convertible = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)textReader, 'Ƴ', 510);
							num2 = 0;
							continue;
						case 0:
							num2 = (((string)convertible != null) ? (ⴄႤ[47] / 6) : 6);
							continue;
						case 6:
							break;
						}
						break;
					}
				}
				finally
				{
					int num3 = 1;
					while (true)
					{
						int num4;
						switch (num3)
						{
						default:
							num4 = ((!(obj2 is FileStream)) ? 4 : 3);
							goto IL_01d4;
						case 0:
						case 3:
							((IDisposable)(FileStream)obj2).Dispose();
							break;
						case 4:
						case 5:
							break;
						}
						break;
						IL_01d4:
						num3 = num4;
					}
				}
				switch (4)
				{
				default:
					ByeHelp.Ⴄ((PrecisionTimer)obj, 'Ʀ', 501);
					break;
				case 0:
					break;
				case 1:
				case 2:
				case 3:
					return;
				}
				ILog ⴍ = Ⴍ;
				Array array = new object[6];
				((object[])array)[0] = (PrecisionTimer)obj;
				(array as object[])[1] = ReplyMail.Ⴅ(8, 9, 1217940708);
				(array as object[])[2] = fileName;
				(array as object[])[3] = ShowSkimCtyHelp.Ⴍ(1216133807, 6, '¬');
				(array as object[])[4] = Ⴓ.Count;
				((object[])array)[5] = ShowSkimCtyHelp.Ⴍ(1216133811, 5, '\u009e');
				ⴍ.Info(string.Concat((object[])array));
				break;
				IL_0041:
				num = ⴄႤ[148] * 4;
			}
		}
		catch (Exception ex)
		{
			Ⴍ.Error(ex.Message);
		}
	}

	internal bool Ⴃ(string P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		bool flag = false;
		bool flag2;
		object ⴈ = default(object);
		try
		{
			int num = 5;
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				case 0:
					flag2 = enumerable is string;
					goto end_IL_004b;
				}
				ႨႥ.Ⴍ(ⴈ = Ⴈ, ref flag, 675, 682);
				enumerable = (string)ShowWwv.Ⴐ(Ⴓ, (object)P_0, 'ΰ', 'ϕ');
				num = 0;
				continue;
				end_IL_004b:
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
					num3 = ((!flag) ? (ⴃႥ[239] - 50026) : (ⴐ[99] - 73));
					goto IL_00e3;
				case 0:
				case 1:
				case 3:
					Monitor.Exit(ⴈ);
					break;
				case 5:
					break;
				}
				break;
				IL_00e3:
				num2 = num3;
			}
		}
		return 4 switch
		{
			_ => flag2, 
		};
	}

	static DxSpotBlockCache()
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴍ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(2, null, 1267017773, typeof(ShowConnects.ႥႥ)), 26, 7);
				break;
			case 3:
			case 4:
				break;
			case 0:
				Ⴈ = new object();
				return;
			}
			num = 0;
		}
	}
}
