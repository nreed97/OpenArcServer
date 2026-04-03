using System;
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
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class LotwCache
{
	private static readonly ILog Ⴈ;

	private static readonly object m_Ⴃ;

	private NetworkHelp.Ⴅ Ⴗ = new NetworkHelp.Ⴅ();

	public LotwCache()
	{
		object obj = new List<string>();
		Ⴗ.Ⴃ = (List<string>)obj;
		Init();
	}

	public bool Init()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool flag = false;
		object ⴃ = default(object);
		bool flag2;
		try
		{
			switch (2)
			{
			default:
				ႨႥ.Ⴍ(ⴃ = LotwCache.m_Ⴃ, ref flag, 550, 559);
				try
				{
					int num = 3;
					object obj4 = default(object);
					ICloneable cloneable = default(ICloneable);
					object obj3 = default(object);
					object obj2 = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							obj4 = new PrecisionTimer();
							goto case 1;
						case 1:
							ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj4, 999, 934);
							Ⴗ.Ⴃ.Clear();
							goto case 5;
						case 5:
							num = 2;
							continue;
						case 2:
						{
							object obj5 = ShowLog.Ⴍ(656, 'ʘ');
							cloneable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)obj5, 608, 514), 331, 'Ş'), SetStationQth.Ⴍ(null, 1687352250, 3, 25), 794, 852);
							num = ⴃႰ[143] - 1474;
							continue;
						}
						case 4:
						{
							object obj = new FileStream((string)cloneable, FileMode.Open, FileAccess.Read);
							try
							{
								int num2 = 3;
								while (true)
								{
									switch (num2)
									{
									default:
										obj3 = new StreamReader((FileStream)obj);
										obj2 = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj3, 'ɻ', 566);
										num2 = 1;
										continue;
									case 10:
										num2 = ((CallBlockCacheCfg.Ⴜ((string)obj2, 392, 489) <= 0) ? 8 : (ⴀႨ[175] - 60070));
										continue;
									case 9:
										num2 = (SetAnnDefault.Ⴍ(obj2 as string, ႰႥ.Ⴅ(3, 'Y', 952620225), 960, 914) ? 8 : 5);
										continue;
									case 5:
										Ⴗ.Ⴃ.Add(obj2 as string);
										goto case 2;
									case 2:
									case 8:
										obj2 = SetAnnModeHelp.Ⴐ((TextReader)(obj3 as StreamReader), 'Ǡ', 429);
										num2 = ⴄႤ[180] - 29;
										continue;
									case 1:
									case 7:
										num2 = (((string)obj2 != null) ? (ⴐ[351] - 118) : ⴀႼ[80]);
										continue;
									case 0:
									case 6:
										break;
									}
									break;
								}
							}
							finally
							{
								int num3 = 0;
								while (true)
								{
									int num4;
									switch (num3)
									{
									default:
										num4 = ((!(obj is FileStream)) ? (ⴀႨ[94] - 43554) : (ⴃႰ[168] - 26499));
										goto IL_02c0;
									case 4:
									case 5:
										((IDisposable)(obj as FileStream)).Dispose();
										break;
									case 1:
										break;
									}
									break;
									IL_02c0:
									num3 = num4;
								}
							}
							int num5 = 3;
							while (true)
							{
								switch (num5)
								{
								default:
									Ⴗ.Ⴃ.TrimExcess();
									ByeHelp.Ⴄ((PrecisionTimer)obj4, '\u0347', 788);
									goto case 6;
								case 6:
								{
									byte num6 = ⴅ[310];
									SetAnnMode.ႤႭ[147] = (byte)((SetAnnMode.ႤႭ[147] - BandModeCacheCfg.ႠႳ[260]) & 0x88);
									num5 = num6 - 176;
									continue;
								}
								case 4:
								{
									ILog ⴈ = Ⴈ;
									Array array = new object[4];
									((object[])array)[0] = obj4 as PrecisionTimer;
									((object[])array)[1] = CallBlockCacheCfg.Ⴅ(null, 8, 62056462, null);
									((object[])array)[2] = Ⴗ.Ⴃ.Count;
									(array as object[])[3] = CallBlockCacheCfg.Ⴅ(null, 1, 62056501, null);
									ⴈ.Info(string.Concat((object[])array));
									goto case 2;
								}
								case 2:
									num5 = 1;
									continue;
								case 1:
								case 5:
									flag2 = true;
									break;
								}
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
					Ⴈ.Error(ex.Message);
					flag2 = false;
				}
				break;
			}
		}
		finally
		{
			int num7 = 1;
			while (true)
			{
				int num8;
				switch (num7)
				{
				default:
					num8 = ((!flag) ? (ⴃႰ[58] - 19221) : (ⴀႳ[10] - 22693));
					goto IL_043b;
				case 4:
				case 5:
					Monitor.Exit(ⴃ);
					break;
				case 2:
				case 3:
				case 6:
					break;
				}
				break;
				IL_043b:
				num7 = num8;
			}
		}
		return 0 switch
		{
			_ => flag2, 
		};
	}

	internal bool Ⴃ(string P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		bool flag = false;
		object ⴃ = default(object);
		try
		{
			ႨႥ.Ⴍ(ⴃ = LotwCache.m_Ⴃ, ref flag, 264, 257);
			return Ⴗ.Ⴃ.Contains(P_0);
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
					num2 = ((!flag) ? (ⴃႠ[138] - 20541) : 3);
					goto IL_0097;
				case 0:
				case 3:
				case 5:
					DxCmdMsgExt.ႨႠ(ⴃ, 'ά', 969);
					break;
				case 2:
					break;
				}
				break;
				IL_0097:
				num = num2;
			}
		}
	}

	static LotwCache()
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴈ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(5, null, 1267023815, typeof(ႳႠ.ႷႥ)), 417, 444);
				break;
			case 0:
			case 4:
				break;
			case 1:
			case 3:
				LotwCache.m_Ⴃ = new object();
				return;
			}
			num = ⴀႣ[70] - 49507;
		}
	}
}
