using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ArcEngine.ArcCmds;
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
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class SkimmerBandProcessor
{
	private static readonly ILog Ⴅ;

	private static readonly object m_Ⴍ;

	private readonly ConcurrentDictionary<string, SkimmerValidSpot> m_Ⴈ;

	private readonly int Ⴄ;

	private readonly int m_Ⴈ;

	public readonly SkimmerCtyCoverageCache SkimCtyCoverageCache;

	private static Func<SkimmerSpot, DateTime> m_Ⴗ;

	private ShowGrayline.Ⴃ Ⴓ = new ShowGrayline.Ⴃ();

	public SkimmerBandProcessor(int baseFreq, int maxFreq)
	{
		Ⴓ.Ⴀ = baseFreq;
		Ⴄ = maxFreq;
		this.m_Ⴈ = (Ⴄ - Ⴓ.Ⴀ) * 10;
		Array array = new SkimmerSpotBins[this.m_Ⴈ];
		Ⴓ.Ⴍ = (SkimmerSpotBins[])array;
		for (int i = 0; i < this.m_Ⴈ; i++)
		{
			Ⴓ.Ⴍ[i] = new SkimmerSpotBins();
		}
		this.m_Ⴈ = new ConcurrentDictionary<string, SkimmerValidSpot>();
		SkimCtyCoverageCache = new SkimmerCtyCoverageCache();
	}

	public SkimmerCt1bohCache.SkimmerQualityType ProcessCt1boh(DxSpot dx, out int skimCoverage, out string bustedKeyCall)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		object obj2 = default(object);
		object obj = default(object);
		int num2 = default(int);
		object current2 = default(object);
		TimeSpan timeSpan = default(TimeSpan);
		int num9 = default(int);
		int num4 = default(int);
		object current = default(object);
		while (true)
		{
			SkimmerCt1bohCache.SkimmerQualityType skimmerQualityType = SkimmerCt1bohCache.SkimmerQualityType.Unknown;
			bustedKeyCall = string.Empty;
			while (true)
			{
				IL_007f:
				skimCoverage = SkimCtyCoverageCache.UpdateAndReturnCnt(dx);
				while (true)
				{
					IL_008d:
					int num = ⴄႭ[28] - 126;
					while (true)
					{
						switch (num)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							num = 1;
							continue;
						case 1:
							break;
						case 4:
							goto IL_007f;
						case 3:
							goto IL_008d;
						case 6:
							obj2 = new SkimmerSpot(WxHelp.Ⴀ(dx, 263, 282), ShowVersion.Ⴐ(dx, 414, 482), HealthMonitorCfg.Ⴓ(dx, 1008, 983), SetWxCountHelp.Ⴍ(dx, '\u0080', 129));
							num = 2;
							continue;
						case 2:
							obj = Ⴗ((SkimmerSpot)obj2, 3);
							num2 = 0;
							goto case 5;
						case 5:
						{
							List<SkimmerSpot> source = obj as List<SkimmerSpot>;
							if (SkimmerBandProcessor.m_Ⴗ == null)
							{
								SkimmerBandProcessor.m_Ⴗ = Ⴃ;
							}
							object obj3 = source.OrderByDescending(SkimmerBandProcessor.m_Ⴗ);
							object enumerator = (obj3 as IOrderedEnumerable<SkimmerSpot>).GetEnumerator();
							try
							{
								int num3 = 10;
								while (true)
								{
									int num8;
									switch (num3)
									{
									case 0:
										current2 = (enumerator as IEnumerator<SkimmerSpot>).Current;
										timeSpan = SetWxMode.Ⴃ(ShowAnnHelp.Ⴅ('\u02e9', 728), ((SkimmerSpot)current2).DtsRx, 658, 732);
										num3 = 1;
										break;
									case 1:
										if (ShowNodes.Ⴍ(ref timeSpan, 941, 'Ο') <= 26)
										{
											num3 = ⴐ[41] - 30;
											break;
										}
										goto end_IL_0133;
									case 13:
										num3 = ((!ByeHelp.Ⴍ((obj2 as SkimmerSpot).Call, (current2 as SkimmerSpot).Call, 17, 118)) ? 2 : (ⴀႳ[32] - 3198));
										break;
									case 9:
										num2++;
										if (num2 == 2)
										{
											num3 = 4;
											break;
										}
										goto default;
									case 4:
										skimmerQualityType = SkimmerCt1bohCache.SkimmerQualityType.Valid;
										Ⴍ(dx, (SkimmerSpot)obj2);
										goto end_IL_0133;
									case 2:
										if ((current2 as SkimmerSpot).QualityFlag == SkimmerCt1bohCache.SkimmerQualityType.Valid)
										{
											num3 = 6;
											break;
										}
										goto default;
									case 3:
									case 6:
										if (ShowSkimmerHelp.Ⴅ(((SkimmerSpot)obj2).FreqHz - ((SkimmerSpot)current2).FreqHz, 20, '*') < 110)
										{
											num3 = ⴀႨ[42] - 24447;
											break;
										}
										goto default;
									case 7:
										num9 = LevenshteinDistance.Compute3((obj2 as SkimmerSpot).Call, (current2 as SkimmerSpot).Call);
										goto case 8;
									case 8:
										if (num9 > 50)
										{
											num3 = ⴅ[365];
											break;
										}
										goto default;
									case 12:
									{
										num4 = 0;
										object enumerator2 = ((IOrderedEnumerable<SkimmerSpot>)obj3).GetEnumerator();
										try
										{
											int num5 = 4;
											while (true)
											{
												switch (num5)
												{
												default:
													num5 = 0;
													continue;
												case 2:
												case 6:
													current = (enumerator2 as IEnumerator<SkimmerSpot>).Current;
													goto case 5;
												case 5:
													num5 = ((!ByeHelp.Ⴍ((current as SkimmerSpot).Call, (obj2 as SkimmerSpot).Call, 1011, 916)) ? (ⴀ[224] - ⴀ[224]) : 3);
													continue;
												case 3:
												case 7:
													num4++;
													num5 = ((num4 == 2) ? (ⴃႰ[97] - 18257) : 0);
													continue;
												case 0:
													num5 = ((enumerator2 as IEnumerator<SkimmerSpot>).MoveNext() ? (ⴅ[365] / 2) : (ⴅ[137] - 48));
													continue;
												case 1:
													break;
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
													num7 = (((IEnumerator<SkimmerSpot>)enumerator2 == null) ? (ⴄႷ[66] - 17239) : 4);
													goto IL_03d8;
												case 1:
												case 4:
												case 5:
													(enumerator2 as IEnumerator<SkimmerSpot>).Dispose();
													break;
												case 3:
													break;
												}
												break;
												IL_03d8:
												num6 = num7;
											}
										}
										num8 = 5;
										goto IL_03f9;
									}
									default:
										{
											if ((enumerator as IEnumerator<SkimmerSpot>).MoveNext())
											{
												goto case 0;
											}
											num8 = 3;
											goto IL_03f9;
										}
										IL_03f9:
										while (true)
										{
											switch (num8)
											{
											default:
												bustedKeyCall = ShowPrefixCalls.Ⴃ((object)'(', (object)((SkimmerSpot)current2).Call, (object)')', 'ǣ', 457);
												goto case 2;
											case 2:
												num8 = 0;
												continue;
											case 0:
											case 1:
											case 9:
												num8 = ((num4 != 2) ? (ⴄႷ[126] - 39163) : (ⴀ[0] - 1707));
												continue;
											case 4:
												skimmerQualityType = SkimmerCt1bohCache.SkimmerQualityType.BustedOverride;
												num8 = ⴃႠ[402] - 22724;
												continue;
											case 7:
												skimmerQualityType = SkimmerCt1bohCache.SkimmerQualityType.Busted;
												num8 = 3;
												continue;
											case 8:
												break;
											case 3:
												goto end_IL_03f9;
											}
											goto default;
											continue;
											end_IL_03f9:
											break;
										}
										goto end_IL_0133;
									}
									continue;
									end_IL_0133:
									break;
								}
							}
							finally
							{
								int num10 = 2;
								while (true)
								{
									int num11;
									switch (num10)
									{
									default:
										num11 = ((!(enumerator is IEnumerator<SkimmerSpot>)) ? 4 : (ⴃႠ[270] - 17702));
										goto IL_04f1;
									case 1:
										((IEnumerator<SkimmerSpot>)enumerator).Dispose();
										break;
									case 4:
									case 6:
										break;
									}
									break;
									IL_04f1:
									num10 = num11;
								}
							}
							int num12 = 5;
							while (true)
							{
								switch (num12)
								{
								default:
									num12 = ((skimmerQualityType == SkimmerCt1bohCache.SkimmerQualityType.Unknown) ? 1 : (ⴀ[26] - 7204));
									break;
								case 1:
								case 7:
									num12 = ((!this.m_Ⴈ.ContainsKey(dx.Call)) ? (ⴀႨ[27] - 10517) : 4);
									break;
								case 4:
									skimmerQualityType = SkimmerCt1bohCache.SkimmerQualityType.Qsy;
									num12 = ⴍႭ[11] - 42760;
									break;
								case 3:
									((SkimmerSpot)obj2).QualityFlag = skimmerQualityType;
									Ⴗ(obj2 as SkimmerSpot);
									return skimmerQualityType;
								}
							}
						}
						}
						break;
					}
					break;
				}
				break;
			}
		}
	}

	private List<SkimmerSpot> Ⴗ(SkimmerSpot P_0, int P_1)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num5 = default(int);
		int num3 = default(int);
		object obj = default(object);
		int num4 = default(int);
		object ⴍ = default(object);
		object current = default(object);
		while (true)
		{
			int num = P_0.FreqHz / 100 - Ⴓ.Ⴀ;
			int num2 = 5;
			while (true)
			{
				int num6;
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 4;
					continue;
				case 4:
				case 6:
					break;
				case 5:
					num5 = num - P_1;
					num2 = ((num5 >= 0) ? 10 : 2);
					continue;
				case 2:
					num5 = 0;
					num2 = 10;
					continue;
				case 10:
					num3 = num + P_1;
					num2 = ((num3 <= this.m_Ⴈ) ? (ⴃႰ[201] - 21672) : 8);
					continue;
				case 7:
				case 8:
					num3 = this.m_Ⴈ - 1;
					Ⴅ.Error(ShowUsersHelp.Ⴅ(ReplyMail.Ⴅ(3, 10, 1217943457), UserCacheCfg.Ⴃ((object)P_0, 'ˌ', 679), 540, 594));
					goto case 3;
				case 3:
					obj = new List<SkimmerSpot>();
					goto case 1;
				case 1:
					num4 = num5;
					goto IL_02af;
				case 0:
					{
						bool flag = false;
						try
						{
							switch (2)
							{
							default:
								ႨႥ.Ⴍ(ⴍ = SkimmerBandProcessor.m_Ⴍ, ref flag, 369, 376);
								break;
							case 1:
							case 3:
								break;
							}
							List<SkimmerSpot>.Enumerator enumerator = Ⴓ.Ⴍ[num4].Spots.GetEnumerator();
							try
							{
								int num7 = 3;
								while (true)
								{
									switch (num7)
									{
									default:
										num7 = ⴄႷ[91] - 7811;
										continue;
									case 1:
									case 4:
										current = enumerator.Current;
										goto case 2;
									case 2:
										((List<SkimmerSpot>)obj).Add(current as SkimmerSpot);
										break;
									case 5:
										break;
									case 7:
										goto end_IL_0160;
									}
									num7 = (enumerator.MoveNext() ? (ⴀႨ[219] - 45725) : 7);
									continue;
									end_IL_0160:
									break;
								}
							}
							finally
							{
								switch (4)
								{
								default:
									((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
									break;
								case 1:
								case 2:
									break;
								}
							}
							switch (3)
							{
							}
						}
						finally
						{
							int num8 = 1;
							while (true)
							{
								int num9;
								switch (num8)
								{
								default:
									num9 = ((!flag) ? (ⴃႰ[181] - ⴃႰ[181]) : (ⴄႭ[87] - ⴄႭ[219]));
									goto IL_0255;
								case 4:
									DxCmdMsgExt.ႨႠ(ⴍ, 'ʖ', 755);
									break;
								case 0:
								case 6:
									break;
								}
								break;
								IL_0255:
								num8 = num9;
							}
						}
						num6 = 2;
						goto IL_0281;
					}
					IL_02af:
					if (num4 <= num3)
					{
						goto case 0;
					}
					num6 = ⴀႣ[392] - 3452;
					goto IL_0281;
					IL_0281:
					while (true)
					{
						switch (num6)
						{
						default:
							goto IL_02a4;
						case 0:
						case 1:
						case 3:
						case 6:
							break;
						case 4:
							return obj as List<SkimmerSpot>;
						}
						break;
						IL_02a4:
						num4++;
						num6 = 3;
					}
					goto IL_02af;
				}
				break;
			}
		}
	}

	private void Ⴗ(SkimmerSpot P_0)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 1;
		int num2 = default(int);
		object ⴍ = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = P_0.FreqHz / 100 - Ⴓ.Ⴀ;
				goto case 0;
			case 0:
				num = 4;
				continue;
			case 4:
				if (num2 >= 0)
				{
					num = ⴍႤ[137] - 14898;
					continue;
				}
				break;
			case 2:
			case 6:
				if (num2 < this.m_Ⴈ)
				{
					num = ⴀႼ[136];
					continue;
				}
				break;
			case 5:
			{
				bool flag = false;
				try
				{
					switch (2)
					{
					default:
						ႨႥ.Ⴍ(ⴍ = SkimmerBandProcessor.m_Ⴍ, ref flag, 521, 512);
						break;
					case 1:
						break;
					case 3:
						return;
					}
					Ⴓ.Ⴍ[num2].Spots.Add(P_0);
					return;
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
							num4 = ((!flag) ? (ⴄႭ[477] - 174) : (ⴃႰ[75] - 29855));
							goto IL_0117;
						case 2:
						case 4:
							DxCmdMsgExt.ႨႠ(ⴍ, 'ł', 295);
							break;
						case 1:
							break;
						}
						break;
						IL_0117:
						num3 = num4;
					}
				}
			}
			}
			break;
		}
		switch (0)
		{
		case 5:
			return;
		}
		Ⴅ.Error(ႨႨ.Ⴀ(15, 6, 1157905962) + P_0.ToString());
	}

	private void Ⴍ(DxSpot P_0, SkimmerSpot P_1)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 6;
		SkimmerValidSpot value = default(SkimmerValidSpot);
		int num6 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num2 = default(int);
		object ⴍ = default(object);
		Array array = default(Array);
		int num8 = default(int);
		object obj = default(object);
		while (true)
		{
			int num5;
			switch (num)
			{
			default:
				this.m_Ⴈ.TryGetValue(WxHelp.Ⴀ(P_0, 931, 958), out value);
				goto case 4;
			case 4:
				num = ⴐ[50];
				continue;
			case 12:
				num = ((value != null) ? (ⴐ[44] - 46) : 2);
				continue;
			case 2:
				this.m_Ⴈ.TryAdd(WxHelp.Ⴀ(P_0, 167, 186), new SkimmerValidSpot(WxHelp.Ⴀ(P_0, 88, 69), HealthMonitorCfg.Ⴓ(P_0, 702, 665), ShowAnnHelp.Ⴅ('ʾ', 655)));
				break;
			case 11:
				if (ShowSkimmerHelp.Ⴅ(P_1.FreqHz - value.FreqHz, 393, 'Ʒ') > 400)
				{
					num = ⴀႳ[37] - 40173;
					continue;
				}
				goto IL_034e;
			case 10:
				num6 = value.FreqHz / 100 - Ⴓ.Ⴀ;
				num = 3;
				continue;
			case 3:
				num3 = num6 - 3;
				num = ((num3 >= 0) ? 1 : 7);
				continue;
			case 7:
				num3 = 0;
				num = ⴀ[15] - 10941;
				continue;
			case 1:
				num4 = num6 + 3;
				num = ((num4 <= this.m_Ⴈ) ? 5 : 0);
				continue;
			case 0:
				num4 = this.m_Ⴈ - 1;
				num = 5;
				continue;
			case 5:
				num2 = num3;
				goto case 13;
			case 8:
			{
				bool flag = false;
				try
				{
					int num7 = 0;
					while (true)
					{
						switch (num7)
						{
						default:
							ႨႥ.Ⴍ(ⴍ = SkimmerBandProcessor.m_Ⴍ, ref flag, 694, 703);
							array = Ⴓ.Ⴍ[num2].Spots.ToArray();
							num7 = 3;
							continue;
						case 2:
						case 3:
							num8 = 0;
							num7 = 1;
							continue;
						case 4:
						case 7:
							obj = (array as SkimmerSpot[])[num8];
							num7 = ((!ByeHelp.Ⴍ(WxHelp.Ⴀ(P_0, 117, 104), ((SkimmerSpot)obj).Call, 493, 394)) ? 6 : (ⴀႳ[302] - 61676));
							continue;
						case 10:
							Ⴓ.Ⴍ[num2].Spots.Remove(obj as SkimmerSpot);
							num7 = ⴀႳ[139] - 4370;
							continue;
						case 6:
							num8++;
							num7 = ⴃႥ[283] - 58295;
							continue;
						case 1:
						case 8:
							num7 = ((num8 < ((SkimmerSpot[])array).Length) ? 4 : (ⴐ[212] - ⴐ[367]));
							continue;
						case 9:
							break;
						}
						break;
					}
				}
				finally
				{
					int num9 = 5;
					while (true)
					{
						int num10;
						switch (num9)
						{
						default:
							num10 = (flag ? 4 : 0);
							goto IL_02fd;
						case 4:
							Monitor.Exit(ⴍ);
							break;
						case 0:
						case 3:
						case 6:
							break;
						}
						break;
						IL_02fd:
						num9 = num10;
					}
				}
				num5 = 1;
				goto IL_030f;
			}
			case 13:
				if (num2 <= num4)
				{
					goto case 8;
				}
				num5 = 0;
				goto IL_030f;
			case 9:
				break;
				IL_030f:
				while (true)
				{
					switch (num5)
					{
					default:
						num2++;
						num5 = 5;
						continue;
					case 5:
						break;
					case 0:
						goto IL_034e;
					case 4:
						goto IL_035a;
					case 2:
					case 7:
						goto end_IL_0021;
					}
					break;
				}
				goto case 13;
				IL_034e:
				value.FreqHz = P_1.FreqHz;
				goto IL_035a;
				IL_035a:
				value.Dts = DateTime.UtcNow;
				break;
				end_IL_0021:
				break;
			}
			break;
		}
		P_1.QualityFlag = SkimmerCt1bohCache.SkimmerQualityType.Valid;
	}

	internal void Ⴃ()
	{
		Ⴍ(25);
		Ⴈ(25);
		SkimCtyCoverageCache.Ⴄ(25);
	}

	private void Ⴍ(int P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 7;
		Array array = default(Array);
		int num2 = default(int);
		KeyValuePair<string, SkimmerValidSpot> keyValuePair = default(KeyValuePair<string, SkimmerValidSpot>);
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			switch (num)
			{
			default:
				_ = this.m_Ⴈ.Count;
				array = this.m_Ⴈ.ToArray();
				num2 = 0;
				num = 8;
				break;
			case 0:
				keyValuePair = ((KeyValuePair<string, SkimmerValidSpot>[])array)[num2];
				timeSpan = SetWxMode.Ⴃ(ShowAnnHelp.Ⴅ('\u0317', 806), keyValuePair.Value.Dts, 53, 123);
				num = 1;
				break;
			case 1:
				num = ((ShowNodes.Ⴍ(ref timeSpan, 511, 'Ǎ') <= P_0) ? (ⴍႭ[366] - 19216) : 5);
				break;
			case 2:
			case 5:
			{
				this.m_Ⴈ.TryRemove(keyValuePair.Key, out var _);
				num = ⴀႼ[96];
				break;
			}
			case 3:
			case 4:
				num2++;
				num = 8;
				break;
			case 8:
				num = ((num2 >= (array as KeyValuePair<string, SkimmerValidSpot>[]).Length) ? (ⴄႷ[47] - 19220) : 0);
				break;
			case 6:
			case 9:
				return;
			}
		}
	}

	private void Ⴈ(int P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		bool flag = false;
		object ⴍ = default(object);
		try
		{
			int num = 11;
			int num2 = default(int);
			Array array = default(Array);
			int num3 = default(int);
			object obj = default(object);
			TimeSpan timeSpan = default(TimeSpan);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴍ = SkimmerBandProcessor.m_Ⴍ, ref flag, 890, 883);
					num2 = 0;
					num = ⴄႤ[169] - ⴄႤ[72];
					continue;
				case 13:
					array = Ⴓ.Ⴍ[num2].Spots.ToArray();
					num3 = 0;
					num = ⴐ[122] - ⴐ[62];
					continue;
				case 6:
					obj = (array as SkimmerSpot[])[num3];
					timeSpan = SetWxMode.Ⴃ(ShowAnnHelp.Ⴅ('Ή', 952), ((SkimmerSpot)obj).DtsRx, 582, 520);
					num = ⴃႠ[276] - 27084;
					continue;
				case 3:
					num = ((ShowNodes.Ⴍ(ref timeSpan, 452, 'Ƕ') <= P_0) ? 4 : 10);
					continue;
				case 10:
					Ⴓ.Ⴍ[num2].Spots.Remove((SkimmerSpot)obj);
					num = 4;
					continue;
				case 4:
				case 5:
					num3++;
					num = ⴄႤ[30] - 196;
					continue;
				case 8:
					num = ((num3 < (array as SkimmerSpot[]).Length) ? 6 : 7);
					continue;
				case 7:
					num2++;
					num = 9;
					continue;
				case 2:
				case 9:
					num = ((num2 < this.m_Ⴈ) ? 13 : 12);
					continue;
				case 12:
					break;
				}
				break;
			}
		}
		finally
		{
			int num4 = 6;
			while (true)
			{
				int num5;
				switch (num4)
				{
				default:
					num5 = ((!flag) ? 5 : 4);
					goto IL_01c4;
				case 4:
					Monitor.Exit(ⴍ);
					break;
				case 1:
				case 2:
				case 5:
					break;
				}
				break;
				IL_01c4:
				num4 = num5;
			}
		}
		switch (4)
		{
		}
	}

	private static DateTime Ⴃ(SkimmerSpot P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		DateTime dtsRx = P_0.DtsRx;
		DirectoryBulletin.ႠႨ[114] = DirectoryBulletin.ႠႨ[114] & DirectoryBulletin.ႠႨ[187] & 0xD3;
		return dtsRx;
	}

	static SkimmerBandProcessor()
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴅ = SkimmerValidSpot.Ⴐ(SetStationClubHelp.Ⴍ(0, 1, 1747255312, null), 745, 756);
				break;
			case 1:
				break;
			case 2:
				SkimmerBandProcessor.m_Ⴍ = new object();
				return;
			}
			num = 2;
		}
	}
}
