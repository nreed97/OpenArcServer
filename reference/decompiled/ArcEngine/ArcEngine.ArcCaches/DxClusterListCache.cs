using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class DxClusterListCache
{
	private static readonly ILog Ⴄ;

	private static readonly object Ⴗ;

	private readonly Dictionary<string, DxClusterInfo> Ⴍ;

	private SetStationQthHelp.Ⴈ Ⴓ = new SetStationQthHelp.Ⴈ();

	public DxClusterListCache()
	{
		Ⴍ = new Dictionary<string, DxClusterInfo>();
		Init();
	}

	public bool Init()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		bool flag = false;
		object ⴗ = default(object);
		bool flag2 = default(bool);
		try
		{
			switch (0)
			{
			default:
				ႨႥ.Ⴍ(ⴗ = Ⴗ, ref flag, 366, 359);
				try
				{
					int num = 6;
					object obj4 = default(object);
					ICloneable cloneable = default(ICloneable);
					object obj3 = default(object);
					IComparable comparable = default(IComparable);
					while (true)
					{
						switch (num)
						{
						default:
						{
							int ⴍ2 = 0;
							Ⴓ.Ⴍ = ⴍ2;
							obj4 = new PrecisionTimer();
							ShowPrefixCallsHelp.Ⴗ(obj4 as PrecisionTimer, 814, 879);
							num = 5;
							continue;
						}
						case 0:
						case 5:
						{
							Ⴍ.Clear();
							ISerializable serializable = ShowLog.Ⴍ(306, 'ĺ');
							cloneable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(serializable as Assembly, 1000, 906), 657, 'ʄ'), ShowWxHelp.Ⴍ('T', 985808184, 4), 578, 524);
							num = ⴄႤ[76] - 88;
							continue;
						}
						case 2:
						{
							object obj = new FileStream(cloneable as string, FileMode.Open, FileAccess.Read);
							try
							{
								int num2 = 0;
								while (true)
								{
									int num6;
									switch (num2)
									{
									default:
										obj3 = new StreamReader((FileStream)obj);
										comparable = SetAnnModeHelp.Ⴐ((TextReader)(obj3 as StreamReader), '\u0080', 205);
										goto IL_0470;
									case 1:
									case 8:
									{
										int ⴍ = Ⴓ.Ⴍ + 1;
										Ⴓ.Ⴍ = ⴍ;
										num2 = ⴀႣ[335] - 40271;
										break;
									}
									case 2:
										if (CallBlockCacheCfg.Ⴜ(comparable as string, 594, 563) > 0)
										{
											num2 = 6;
											break;
										}
										goto IL_0434;
									case 3:
									case 6:
										if (!SetAnnDefault.Ⴍ(comparable as string, ႰႥ.Ⴅ(1, ':', 952620227), 226, 176))
										{
											num2 = 7;
											break;
										}
										goto IL_0434;
									case 7:
										{
											object dxClusterInfo = DxClusterInfo.GetDxClusterInfo(comparable as string);
											if (dxClusterInfo is DxClusterInfo)
											{
												try
												{
													int num3 = 5;
													while (true)
													{
														int num4;
														switch (num3)
														{
														default:
															if (ByeHelp.Ⴍ((dxClusterInfo as DxClusterInfo).Ⴐ(), SetStationQth.Ⴍ(null, 1687352256, 6, 25), 676, 716))
															{
																num4 = ⴍႭ[310] - 10464;
															}
															else
															{
																int num5 = ⴍႤ[263];
																ShowWwvOptionsHelp.ႣႥ[12] = (char)((ShowWwvOptionsHelp.ႣႥ[12] - ShowWwvOptionsHelp.ႣႥ[383]) & 0x2D);
																num4 = num5 - 61960;
															}
															goto IL_02aa;
														case 4:
														case 6:
															Ⴍ.Add((dxClusterInfo as DxClusterInfo).Ⴐ(), (DxClusterInfo)dxClusterInfo);
															break;
														case 1:
														case 3:
															break;
														}
														break;
														IL_02aa:
														num3 = num4;
													}
												}
												catch (Exception ex)
												{
													while (ByeHelp.Ⴍ(((DxClusterInfo)dxClusterInfo).Ⴐ(), SetStationQth.Ⴍ(null, 1687352312, 4, 3), 27, 115))
													{
														switch (1)
														{
														case 2:
															continue;
														case 0:
														case 3:
															goto end_IL_0302;
														}
														ILog ⴄ = Ⴄ;
														object obj2 = new object[8];
														((object[])obj2)[0] = SetTalkCount.Ⴗ(3, null, 1267023619, typeof(SkimmerCtyCoverageCache));
														(obj2 as object[])[1] = Ⴓ.Ⴍ;
														(obj2 as object[])[2] = ReplyMail.Ⴅ(6, 2, 1217945527);
														((object[])obj2)[3] = (dxClusterInfo as DxClusterInfo).Ⴐ();
														(obj2 as object[])[4] = ShowWxHelp.Ⴍ('\u0091', 985808152, 1);
														(obj2 as object[])[5] = comparable as string;
														(obj2 as object[])[6] = ႰႥ.Ⴅ(3, '\u0099', 952620209);
														((object[])obj2)[7] = SkimmerSpotBins.Ⴈ(ex as Exception, 636, 594);
														ⴄ.Error(SetDxDefaultHelp.Ⴍ((object[])obj2, 'ƀ', 489));
														break;
														continue;
														end_IL_0302:
														break;
													}
												}
											}
											goto IL_0434;
										}
										IL_0470:
										if ((string)comparable != null)
										{
											goto case 1;
										}
										num6 = 3;
										goto IL_0437;
										IL_0437:
										while (true)
										{
											switch (num6)
											{
											default:
												goto IL_045a;
											case 5:
												break;
											case 1:
											case 2:
											case 3:
											case 4:
												goto end_IL_0437;
											}
											goto IL_0470;
											IL_045a:
											comparable = SetAnnModeHelp.Ⴐ((TextReader)(obj3 as StreamReader), '\u0002', 79);
											num6 = 5;
											continue;
											end_IL_0437:
											break;
										}
										goto end_IL_0157;
										IL_0434:
										num6 = 6;
										goto IL_0437;
									}
									continue;
									end_IL_0157:
									break;
								}
							}
							finally
							{
								int num7 = 3;
								while (true)
								{
									int num8;
									switch (num7)
									{
									default:
										num8 = (((FileStream)obj == null) ? 2 : ⴄႤ[135]);
										goto IL_04b9;
									case 5:
										((IDisposable)(FileStream)obj).Dispose();
										break;
									case 2:
										break;
									}
									break;
									IL_04b9:
									num7 = num8;
								}
							}
							int num9 = 4;
							while (true)
							{
								switch (num9)
								{
								default:
								{
									ByeHelp.Ⴄ((PrecisionTimer)obj4, 'ɇ', 532);
									ILog ⴄ2 = Ⴄ;
									Array array = new object[4];
									(array as object[])[0] = (PrecisionTimer)obj4;
									(array as object[])[1] = ShowWxHelp.Ⴍ('\u008f', 985808130, 2);
									((object[])array)[2] = Ⴍ.Count;
									(array as object[])[3] = ႰႥ.Ⴅ(0, '\u00af', 952620946);
									ⴄ2.Info(string.Concat(array as object[]));
									break;
								}
								case 3:
								case 5:
									break;
								case 1:
									flag2 = true;
									goto end_IL_04cf;
								case 0:
									goto end_IL_04cf;
								}
								num9 = 1;
								continue;
								end_IL_04cf:
								break;
							}
							break;
						}
						}
						break;
					}
				}
				catch (Exception ex2)
				{
					Ⴄ.Error((ex2 as Exception).Message);
					flag2 = false;
				}
				break;
			}
		}
		finally
		{
			int num10 = 1;
			while (true)
			{
				int num11;
				switch (num10)
				{
				default:
					num11 = ((!flag) ? (ⴀႨ[40] - 39557) : 4);
					goto IL_05d0;
				case 4:
					Monitor.Exit(ⴗ);
					break;
				case 0:
				case 2:
				case 5:
					break;
				}
				break;
				IL_05d0:
				num10 = num11;
			}
		}
		return 3 switch
		{
			_ => flag2, 
		};
	}

	static DxClusterListCache()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 3:
				Ⴗ = new object();
				return;
			case 4:
				return;
			}
			Ⴄ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('Ì', 985808252, 5), 374, 363);
			num = 3;
		}
	}
}
