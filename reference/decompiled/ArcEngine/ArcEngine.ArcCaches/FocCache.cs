using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class FocCache
{
	private static readonly ILog Ⴅ;

	private static readonly object Ⴅ;

	private SetAnnChatRoomsHelp.Ⴈ Ⴀ;

	public FocCache()
	{
		object obj = new List<string>();
		Ⴀ.Ⴅ = obj as List<string>;
		Init();
	}

	public bool Init()
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		bool flag = false;
		object ⴅ = default(object);
		bool flag2 = default(bool);
		try
		{
			switch (4)
			{
			default:
				ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 977, 984);
				try
				{
					int num = 5;
					object obj4 = default(object);
					IEnumerable enumerable = default(IEnumerable);
					object obj2 = default(object);
					ICloneable cloneable = default(ICloneable);
					while (true)
					{
						switch (num)
						{
						default:
							obj4 = new PrecisionTimer();
							ShowPrefixCallsHelp.Ⴗ(obj4 as PrecisionTimer, 73, 8);
							Ⴀ.Ⴅ.Clear();
							num = 3;
							continue;
						case 3:
						{
							ISerializable serializable = ShowLog.Ⴍ(180, '¼');
							enumerable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(serializable as Assembly, 837, 807), 1016, 'ϭ'), SetStationQth.Ⴍ(null, 1687354729, 7, 15), 721, 671);
							goto case 1;
						}
						case 1:
							num = 4;
							continue;
						case 2:
						case 4:
						{
							object obj = new FileStream(enumerable as string, FileMode.Open, FileAccess.Read);
							try
							{
								int num2 = 3;
								while (true)
								{
									switch (num2)
									{
									default:
										obj2 = new StreamReader(obj as FileStream);
										goto case 7;
									case 7:
										cloneable = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj2, 'Ƙ', 469);
										num2 = 9;
										continue;
									case 2:
										num2 = ((CallBlockCacheCfg.Ⴜ(cloneable as string, 269, 364) <= 0) ? (ⴄႤ[241] - 122) : (ⴀႣ[203] - 42479));
										continue;
									case 1:
										num2 = (SetAnnDefault.Ⴍ(cloneable as string, ႰႥ.Ⴅ(1, '\u0095', 952620227), 510, 428) ? (ⴄႷ[139] - 44118) : 4);
										continue;
									case 4:
										Ⴀ.Ⴅ.Add((string)cloneable);
										goto case 6;
									case 6:
									case 8:
										cloneable = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj2, 'ƙ', 468);
										num2 = ⴀ[22] - 41825;
										continue;
									case 9:
										num2 = ((cloneable is string) ? 2 : 5);
										continue;
									case 5:
										break;
									}
									break;
								}
							}
							finally
							{
								int num3 = 3;
								while (true)
								{
									int num4;
									switch (num3)
									{
									default:
										num4 = (((FileStream)obj == null) ? (ⴀ[414] - 9003) : 6);
										goto IL_02a9;
									case 2:
									case 6:
										((IDisposable)(obj as FileStream)).Dispose();
										break;
									case 1:
									case 4:
									case 5:
										break;
									}
									break;
									IL_02a9:
									num3 = num4;
								}
							}
							int num5 = 6;
							while (true)
							{
								switch (num5)
								{
								default:
									Ⴀ.Ⴅ.TrimExcess();
									ByeHelp.Ⴄ(obj4 as PrecisionTimer, 'Ξ', 973);
									num5 = ⴄႤ[495] - 53;
									continue;
								case 4:
								{
									ILog ⴅ2 = FocCache.Ⴅ;
									object obj3 = new object[4];
									(obj3 as object[])[0] = (PrecisionTimer)obj4;
									(obj3 as object[])[1] = CallBlockCacheCfg.Ⴅ(null, 0, 62055255, null);
									(obj3 as object[])[2] = Ⴀ.Ⴅ.Count;
									((object[])obj3)[3] = CallBlockCacheCfg.Ⴅ(null, 4, 62055232, null);
									ⴅ2.Info(string.Concat(obj3 as object[]));
									goto case 1;
								}
								case 1:
									num5 = ⴀ[402] - 55670;
									continue;
								case 2:
								case 5:
									flag2 = true;
									break;
								case 3:
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
					FocCache.Ⴅ.Error(ex.Message);
					flag2 = false;
				}
				break;
			}
		}
		finally
		{
			int num6 = 6;
			while (true)
			{
				int num7;
				switch (num6)
				{
				default:
					num7 = ((!flag) ? (ⴐ[358] - 130) : 3);
					goto IL_03fc;
				case 3:
					Monitor.Exit(ⴅ);
					break;
				case 0:
				case 1:
				case 5:
					break;
				}
				break;
				IL_03fc:
				num6 = num7;
			}
		}
		return 3 switch
		{
			_ => flag2, 
		};
	}

	internal bool Ⴈ(string P_0)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		bool flag = false;
		object ⴅ = default(object);
		try
		{
			ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 803, 810);
			return Ⴀ.Ⴅ.Contains(P_0);
		}
		finally
		{
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!flag) ? ⴀႼ[96] : 0);
					goto IL_0094;
				case 0:
				case 3:
				case 5:
					DxCmdMsgExt.ႨႠ(ⴅ, 'ν', 984);
					break;
				case 4:
					break;
				}
				break;
				IL_0094:
				num = num2;
			}
		}
	}

	static FocCache()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
			case 2:
				Ⴅ = new object();
				return;
			case 4:
				return;
			}
			FocCache.Ⴅ = SkimmerValidSpot.Ⴐ(CallBlockCacheCfg.Ⴅ(null, 0, 62056340, null), 472, 453);
			num = ⴃႥ[90] - 55688;
		}
	}
}
