using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class BadWordCache
{
	private static readonly ILog Ⴃ;

	private static readonly object Ⴗ;

	private readonly List<string> Ⴃ;

	public BadWordCache()
	{
		Ⴃ = new List<string>();
		Init();
	}

	public void Init()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		bool flag = false;
		object ⴗ = default(object);
		try
		{
			int num = 3;
			_Assembly assembly = default(_Assembly);
			IConvertible convertible = default(IConvertible);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴗ = Ⴗ, ref flag, 56, 49);
					Ⴃ.Clear();
					num = 2;
					continue;
				case 2:
					assembly = ShowLog.Ⴍ(818, '\u033a');
					convertible = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(assembly as Assembly, 873, 779), 231, 'ò'), ReplyMailHelp.Ⴄ(3, null, 1057166309, 3), 155, 213);
					goto case 6;
				case 6:
					num = 0;
					continue;
				case 0:
				case 5:
					LoadConfigFile(convertible as string, ReplyMail.Ⴅ(8, 6, 1217941852));
					convertible = SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)assembly, 715, 681), 152, '\u008d') + SetStationClubHelp.Ⴍ(6, 2, 1747263364, null);
					num = ⴀႳ[295] - 59872;
					continue;
				case 7:
					LoadConfigFile(convertible as string, ShowWxHelp.Ⴍ('\u0090', 985805871, 5));
					Ⴃ.TrimExcess();
					break;
				}
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
					num3 = ((!flag) ? 1 : (ⴃႰ[57] - 49579));
					goto IL_0176;
				case 0:
				case 2:
				case 4:
					Monitor.Exit(ⴗ);
					break;
				case 1:
				case 5:
					break;
				}
				break;
				IL_0176:
				num2 = num3;
			}
		}
		switch (3)
		{
		}
	}

	public void LoadConfigFile(string filePath, string fileName)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		if (!LogCacheCfg.Ⴗ(filePath, 321, 321))
		{
			return;
		}
		try
		{
			object obj = new PrecisionTimer();
			ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 941, 1004);
			Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			try
			{
				int num = 4;
				object obj2 = default(object);
				ICloneable cloneable = default(ICloneable);
				while (true)
				{
					int num2;
					switch (num)
					{
					default:
						obj2 = new StreamReader(stream as FileStream);
						goto case 3;
					case 3:
						cloneable = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj2, '\u0331', 892);
						goto case 0;
					case 1:
						if (CallBlockCacheCfg.Ⴜ((string)cloneable, 225, 128) > 0)
						{
							num = 2;
							break;
						}
						goto IL_012f;
					case 2:
					case 5:
						if (!SetAnnDefault.Ⴍ((string)cloneable, ႰႥ.Ⴅ(4, 'W', 952620230), 928, 1010))
						{
							try
							{
								Ⴃ.Add(LogEntry.Ⴄ(cloneable as string, '\u0083', 169));
							}
							catch (Exception ex)
							{
								BadWordCache.Ⴃ.Warn(ShowUsersHelp.Ⴅ(ReplyMail.Ⴅ(3, 12, 1217941833), SkimmerSpotBins.Ⴈ(ex as Exception, 296, 262), 785, 863));
							}
						}
						goto IL_012f;
					case 0:
						{
							if (cloneable is string)
							{
								goto case 1;
							}
							num2 = 0;
							goto IL_0132;
						}
						IL_0132:
						while (true)
						{
							switch (num2)
							{
							default:
								goto IL_0151;
							case 3:
								break;
							case 0:
							case 2:
								goto end_IL_0132;
							}
							goto case 0;
							IL_0151:
							cloneable = SetAnnModeHelp.Ⴐ((TextReader)(obj2 as StreamReader), '\u0087', 202);
							num2 = ⴀႳ[170] - 10002;
							continue;
							end_IL_0132:
							break;
						}
						goto end_IL_0043;
						IL_012f:
						num2 = 1;
						goto IL_0132;
					}
					continue;
					end_IL_0043:
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
						num4 = (((FileStream)stream == null) ? 5 : 2);
						goto IL_01b6;
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
					IL_01b6:
					num3 = num4;
				}
			}
			Ⴃ.TrimExcess();
			ByeHelp.Ⴄ((PrecisionTimer)obj, 'Ɇ', 533);
			ILog ⴃ = BadWordCache.Ⴃ;
			object obj3 = new object[6];
			(obj3 as object[])[0] = (PrecisionTimer)obj;
			((object[])obj3)[1] = ShowWxHelp.Ⴍ('»', 985805854, 4);
			(obj3 as object[])[2] = fileName;
			((object[])obj3)[3] = ShowSkimCtyHelp.Ⴍ(1216133801, 0, '\u0083');
			((object[])obj3)[4] = Ⴃ.Count;
			(obj3 as object[])[5] = ShowSkimCtyHelp.Ⴍ(1216133812, 2, '·');
			ⴃ.Info(string.Concat((object[])obj3));
		}
		catch (Exception ex2)
		{
			BadWordCache.Ⴃ.Error((ex2 as Exception).Message);
		}
	}

	internal bool Ⴈ(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		bool flag = false;
		object ⴗ = default(object);
		bool flag2 = default(bool);
		try
		{
			int num = 4;
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴗ = Ⴗ, ref flag, 237, 228);
					break;
				case 0:
					break;
				case 2:
				case 3:
				case 5:
				{
					List<string>.Enumerator enumerator = Ⴃ.GetEnumerator();
					try
					{
						int num2 = 2;
						while (true)
						{
							switch (num2)
							{
							default:
								num2 = 1;
								continue;
							case 4:
							{
								IEquatable<string> current = enumerator.Current;
								num3 = ShowNodes.Ⴄ(P_0, (string)current, 369, 334);
								goto case 3;
							}
							case 3:
								num2 = ⴃႥ[32] - 37168;
								continue;
							case 7:
								num2 = ((num3 < 0) ? 1 : (ⴀႣ[94] - 31863));
								continue;
							case 0:
							case 5:
							case 6:
								flag2 = false;
								goto end_IL_0056;
							case 1:
								num2 = (enumerator.MoveNext() ? (ⴀႣ[272] - 31605) : 9);
								continue;
							case 9:
								break;
							}
							break;
						}
					}
					finally
					{
						switch (0)
						{
						default:
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							break;
						case 1:
							break;
						}
					}
					switch (0)
					{
					default:
						flag2 = true;
						break;
					case 2:
					case 4:
						break;
					}
					goto end_IL_0056;
				}
				}
				P_0 = LogEntry.Ⴄ(P_0, '\u001a', 48);
				num = ⴀႼ[113];
				continue;
				end_IL_0056:
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
					num5 = ((!flag) ? 2 : 5);
					goto IL_01d0;
				case 3:
				case 4:
				case 5:
					Monitor.Exit(ⴗ);
					break;
				case 2:
					break;
				}
				break;
				IL_01d0:
				num4 = num5;
			}
		}
		return 0 switch
		{
			_ => flag2, 
		};
	}

	static BadWordCache()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 0:
				Ⴗ = new object();
				return;
			}
			BadWordCache.Ⴃ = SkimmerValidSpot.Ⴐ(ႨႨ.Ⴀ(4, 4, 1157906389), 534, 523);
			num = ⴅ[41] - 246;
		}
	}
}
