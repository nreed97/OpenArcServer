using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class ChatRoomPubCache
{
	private static readonly ILog m_Ⴍ;

	private static readonly object Ⴅ;

	private SetWxCount.Ⴃ Ⴃ = new SetWxCount.Ⴃ();

	public ChatRoomPubCache()
	{
		object obj = new List<string>();
		Ⴃ.Ⴅ = obj as List<string>;
		Init();
	}

	public bool Init()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		bool flag = false;
		object ⴅ2 = default(object);
		bool flag2 = default(bool);
		try
		{
			switch (2)
			{
			default:
				ႨႥ.Ⴍ(ⴅ2 = Ⴅ, ref flag, 170, 163);
				try
				{
					int num = 4;
					object obj3 = default(object);
					ICloneable cloneable = default(ICloneable);
					object obj2 = default(object);
					IComparable<string> comparable = default(IComparable<string>);
					while (true)
					{
						switch (num)
						{
						default:
							obj3 = new PrecisionTimer();
							ShowPrefixCallsHelp.Ⴗ(obj3 as PrecisionTimer, 498, 435);
							goto case 2;
						case 2:
						case 5:
							Ⴃ.Ⴅ.Clear();
							num = 6;
							continue;
						case 3:
						case 6:
						{
							_Assembly assembly = ShowLog.Ⴍ(122, 'r');
							cloneable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(assembly as Assembly, 865, 771), 883, '\u0366'), SetStationQth.Ⴍ(null, 1687354469, 4, 16), 209, 159);
							num = ⴄႤ[148];
							continue;
						}
						case 1:
						{
							object obj = new FileStream((string)cloneable, FileMode.Open, FileAccess.Read);
							try
							{
								int num2 = 9;
								while (true)
								{
									switch (num2)
									{
									default:
										obj2 = new StreamReader((FileStream)obj);
										comparable = SetAnnModeHelp.Ⴐ((TextReader)(obj2 as StreamReader), 'Ǿ', 435);
										num2 = ⴐ[367];
										continue;
									case 1:
									case 5:
										num2 = ((CallBlockCacheCfg.Ⴜ(comparable as string, 472, 441) <= 0) ? (ⴅ[23] - ⴅ[121]) : (ⴍႭ[285] - 5798));
										continue;
									case 7:
										num2 = (SetAnnDefault.Ⴍ((string)comparable, ႰႥ.Ⴅ(5, '\u0096', 952620231), 928, 1010) ? (ⴀႼ[6] - 70) : 6);
										continue;
									case 6:
										Ⴃ.Ⴅ.Add(LogEntry.Ⴄ((string)comparable, 'Ƭ', 390));
										goto case 0;
									case 0:
									case 2:
										comparable = SetAnnModeHelp.Ⴐ((TextReader)(obj2 as StreamReader), 'ɹ', 564);
										num2 = 4;
										continue;
									case 3:
									case 4:
										num2 = (((string)comparable != null) ? (ⴃႠ[389] - 46740) : 10);
										continue;
									case 10:
										break;
									}
									break;
								}
							}
							finally
							{
								int num3 = 6;
								while (true)
								{
									int num4;
									switch (num3)
									{
									default:
										num4 = ((!(obj is FileStream)) ? 3 : 4);
										goto IL_02ce;
									case 2:
									case 4:
										((IDisposable)(obj as FileStream)).Dispose();
										break;
									case 0:
									case 3:
										break;
									}
									break;
									IL_02ce:
									num3 = num4;
								}
							}
							int num5 = 1;
							while (true)
							{
								switch (num5)
								{
								default:
								{
									ByeHelp.Ⴄ(obj3 as PrecisionTimer, 'Ή', 986);
									ILog ⴍ = ChatRoomPubCache.m_Ⴍ;
									Array array = new object[4];
									(array as object[])[0] = obj3 as PrecisionTimer;
									(array as object[])[1] = ShowWxHelp.Ⴍ('.', 985806273, 5);
									((object[])array)[2] = Ⴃ.Ⴅ.Count;
									(array as object[])[3] = ႰႥ.Ⴅ(1, 'y', 952619490);
									ⴍ.Info(string.Concat(array as object[]));
									break;
								}
								case 2:
								case 3:
									break;
								case 5:
									flag2 = true;
									goto end_IL_02e4;
								case 4:
									goto end_IL_02e4;
								}
								num5 = ⴄႷ[38] - 46344;
								continue;
								end_IL_02e4:
								break;
							}
							break;
						}
						}
						break;
					}
				}
				catch (Exception ex)
				{
					ChatRoomPubCache.m_Ⴍ.Error((ex as Exception).Message);
					flag2 = false;
				}
				break;
			}
		}
		finally
		{
			int num6 = 0;
			while (true)
			{
				int num7;
				switch (num6)
				{
				default:
					num7 = ((!flag) ? (ⴀႳ[181] - 60274) : 4);
					goto IL_03ee;
				case 4:
					Monitor.Exit(ⴅ2);
					break;
				case 2:
				case 3:
					break;
				}
				break;
				IL_03ee:
				num6 = num7;
			}
		}
		return 2 switch
		{
			_ => flag2, 
		};
	}

	internal bool Ⴍ(string P_0)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		bool flag = false;
		object ⴅ = default(object);
		try
		{
			ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 708, 717);
			return Ⴃ.Ⴅ.Contains(LogEntry.Ⴄ(P_0, 'Ʉ', 622));
		}
		finally
		{
			int num = 1;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!flag) ? 2 : ⴀႼ[80]);
					goto IL_0096;
				case 0:
					Monitor.Exit(ⴅ);
					break;
				case 2:
				case 3:
				case 5:
					break;
				}
				break;
				IL_0096:
				num = num2;
			}
		}
	}

	static ChatRoomPubCache()
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 4:
				Ⴅ = new object();
				return;
			case 3:
				return;
			}
			ChatRoomPubCache.m_Ⴍ = SkimmerValidSpot.Ⴐ(SetStationClubHelp.Ⴍ(0, 2, 1747255406, null), 34, 63);
			num = 4;
		}
	}
}
