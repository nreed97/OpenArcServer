using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security;
using System.Threading;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcShared;
using ArcShared.ArcUtils;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public sealed class CtyHdgDistCache
{
	private static readonly ILog m_Ⴃ;

	private static readonly object m_Ⴃ;

	private readonly Dictionary<string, CtyInfo> Ⴗ;

	internal readonly SortedDictionary<string, CtyInfo> Ⴍ;

	internal readonly SortedDictionary<string, CtyInfo> Ⴗ;

	internal readonly SortedDictionary<string, CtyInfo> Ⴃ;

	internal readonly SortedDictionary<string, CtyInfo> Ⴓ;

	internal readonly SortedDictionary<string, CtyInfo> Ⴈ;

	internal CtyHdgDistCache()
	{
		this.Ⴗ = new Dictionary<string, CtyInfo>();
		Ⴍ = new SortedDictionary<string, CtyInfo>();
		Ⴗ = new SortedDictionary<string, CtyInfo>();
		this.Ⴃ = new SortedDictionary<string, CtyInfo>();
		Ⴓ = new SortedDictionary<string, CtyInfo>();
		Ⴈ = new SortedDictionary<string, CtyInfo>();
		Init();
	}

	public void Init()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		bool flag = false;
		object ⴃ = default(object);
		try
		{
			switch (1)
			{
			default:
				ႥႥ.ႤႨ(ⴃ = CtyHdgDistCache.m_Ⴃ, ref flag, 357, 276);
				try
				{
					int num = 2;
					object obj4 = default(object);
					object obj3 = default(object);
					TextReader textReader = default(TextReader);
					IComparable<string> comparable = default(IComparable<string>);
					while (true)
					{
						switch (num)
						{
						default:
							obj4 = new PrecisionTimer();
							goto case 7;
						case 7:
							MultimediaCfg.Ⴄ(obj4 as PrecisionTimer, 896, 938);
							goto case 3;
						case 3:
							this.Ⴗ.Clear();
							num = 4;
							continue;
						case 4:
							Ⴍ.Clear();
							Ⴗ.Clear();
							this.Ⴃ.Clear();
							Ⴓ.Clear();
							num = 0;
							continue;
						case 0:
							Ⴈ.Clear();
							goto case 5;
						case 5:
						{
							IEvidenceFactory evidenceFactory = WxFilters.ႭႭ(578, 617);
							obj3 = DxFilters.Ⴈ(HighlightCfg.ႳႳ(ႥႠ.Ⴅ(evidenceFactory as Assembly, 156, 160), 'Ɯ', 496), ႥႥ.Ⴍ(7, 1580609266, '\u001e', null), 755, 683);
							num = 6;
							continue;
						}
						case 6:
						{
							object obj = new List<string>();
							object obj2 = new FileStream(obj3 as string, FileMode.Open, FileAccess.Read);
							try
							{
								int num2 = 0;
								while (true)
								{
									switch (num2)
									{
									default:
										textReader = new StreamReader(obj2 as FileStream);
										comparable = HighlightItuZoneCfg.Ⴜ((TextReader)(textReader as StreamReader), (short)225, (short)180);
										num2 = 6;
										continue;
									case 1:
									{
										char num3 = SetDxFilter.Ⴈ((string)comparable, 1, 767, 679);
										HighlightCtyCfg.ႠႠ[123] = (char)((HighlightCtyCfg.ႠႠ[123] + UserCmd.Ⴅ[35]) & 0x1F);
										num2 = ((num3 == ' ') ? (ⴀႠ[112] - 45127) : 10);
										continue;
									}
									case 10:
										num2 = ((((List<string>)obj).Count <= 0) ? (ⴗ[66] - 45147) : 5);
										continue;
									case 4:
									case 5:
										Ⴃ(obj as List<string>);
										(obj as List<string>).Clear();
										goto case 7;
									case 7:
										((List<string>)obj).Add(comparable as string);
										goto case 2;
									case 2:
										comparable = HighlightItuZoneCfg.Ⴜ((TextReader)(textReader as StreamReader), (short)924, (short)969);
										num2 = 6;
										continue;
									case 6:
										num2 = ((comparable is string) ? (ⴅ[359] - 189) : 3);
										continue;
									case 3:
									case 9:
										break;
									}
									break;
								}
							}
							finally
							{
								int num4 = 3;
								while (true)
								{
									int num5;
									switch (num4)
									{
									default:
										num5 = ((!(obj2 is FileStream)) ? ⴅ[285] : 0);
										goto IL_02bf;
									case 0:
									case 2:
									case 4:
										((IDisposable)(FileStream)obj2).Dispose();
										break;
									case 5:
										break;
									}
									break;
									IL_02bf:
									num4 = num5;
								}
							}
							int num6 = 1;
							while (true)
							{
								switch (num6)
								{
								default:
									Ⴃ((List<string>)obj);
									break;
								case 3:
									break;
								case 0:
								case 2:
								case 5:
								{
									ILog ⴃ2 = CtyHdgDistCache.m_Ⴃ;
									Array array = new object[4];
									(array as object[])[0] = (PrecisionTimer)obj4;
									((object[])array)[1] = ႥႥ.Ⴅ(1673508120, null, 4);
									((object[])array)[2] = this.Ⴗ.Count;
									(array as object[])[3] = ႥႥ.Ⴅ(1673508534, null, 4);
									ⴃ2.Info(string.Concat((object[])array));
									goto end_IL_02dd;
								}
								}
								MultimediaCfg.Ⴈ(obj4 as PrecisionTimer, 464, 497);
								num6 = ⴗ[32] - 52748;
								continue;
								end_IL_02dd:
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
					CtyHdgDistCache.m_Ⴃ.Error((ex as Exception).Message);
				}
				switch (4)
				{
				}
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
					num8 = ((!flag) ? (ⴗ[12] - 296) : 4);
					goto IL_0403;
				case 4:
					Monitor.Exit(ⴃ);
					break;
				case 2:
				case 5:
					break;
				}
				break;
				IL_0403:
				num7 = num8;
			}
		}
		switch (1)
		{
		}
	}

	private void Ⴃ(IList<string> P_0)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 5;
		IEnumerable enumerable = default(IEnumerable);
		IEnumerable enumerable2 = default(IEnumerable);
		while (true)
		{
			switch (num)
			{
			default:
				enumerable = MultimediaCache.Ⴐ(P_0[0], 69, 'ʬ', 'ˏ');
				enumerable = HighlightArrlSectionCfg.Ⴀ((string)enumerable, ႥႥ.Ⴍ(0, 1580608893, 'ç', null), string.Empty, '\u031e', 789);
				goto case 4;
			case 4:
				num = 3;
				break;
			case 0:
			case 3:
				if (SetDxFilter.Ⴈ((string)enumerable, 0, 836, 796) == '*')
				{
					num = 1;
					break;
				}
				while (true)
				{
					object obj = new CtyInfo(P_0[0]);
					this.Ⴗ.Add((string)enumerable, new CtyInfo(P_0[0]));
					int num2 = ⴅ[234] - 100;
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 9:
							break;
						case 3:
							num2 = (((enumerable2 = DxccCacheData.ႷႠ((CtyInfo)obj, 697, 726)) == null) ? (ⴀႠ[34] - 62551) : (ⴗ[82] - 57050));
							continue;
						case 11:
							num2 = (DxCommentExtCfg.ႤႰ(enumerable2 as string, ႥႥ.Ⴅ(1673507160, null, 7), 'ŝ', 379) ? (ⴅ[2] - 51) : 17);
							continue;
						case 6:
						case 17:
							num2 = (DxCommentExtCfg.ႤႰ(enumerable2 as string, ႥႥ.Ⴍ(1, 1580609213, '%', null), 'F', 96) ? (ⴀႠ[128] - 34413) : (ⴀႠ[0] - 49945));
							continue;
						case 12:
							num2 = ((!DxCommentExtCfg.ႤႰ((string)enumerable2, WxFilters.Ⴀ(null, 0, 103388994), 'ƺ', 412)) ? 1 : 14);
							continue;
						case 1:
							num2 = (DxCommentExtCfg.ႤႰ(enumerable2 as string, ClientCty.Ⴗ('\u0016', 3, 307012106), 'Ǹ', 478) ? (ⴀႠ[48] - 3646) : (ⴗ[113] - 53675));
							continue;
						case 2:
							num2 = (DxCommentExtCfg.ႤႰ(enumerable2 as string, ႥႥ.Ⴅ(1673507159, null, 3), 'ŗ', 369) ? (ⴀႠ[61] - 26817) : (ⴗ[52] - 21960));
							continue;
						case 10:
							return;
						case 16:
							Ⴍ.Add((string)enumerable, obj as CtyInfo);
							return;
						case 5:
							return;
						case 8:
							Ⴗ.Add(enumerable as string, obj as CtyInfo);
							return;
						case 14:
							this.Ⴃ.Add((string)enumerable, (CtyInfo)obj);
							return;
						case 7:
						case 15:
							Ⴓ.Add((string)enumerable, (CtyInfo)obj);
							return;
						case 4:
							Ⴈ.Add((string)enumerable, (CtyInfo)obj);
							return;
						case 13:
							return;
						}
						break;
					}
				}
			case 1:
				return;
			}
		}
	}

	public void UpdateHeadingRange(double myLat, double myLon)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		bool flag = false;
		object ⴃ = default(object);
		try
		{
			switch (2)
			{
			default:
				ႥႥ.ႤႨ(ⴃ = CtyHdgDistCache.m_Ⴃ, ref flag, 480, 401);
				break;
			case 0:
			case 3:
				break;
			}
			Dictionary<string, CtyInfo>.Enumerator enumerator = this.Ⴗ.GetEnumerator();
			try
			{
				int num = 2;
				KeyValuePair<string, CtyInfo> current = default(KeyValuePair<string, CtyInfo>);
				float num2 = default(float);
				float num3 = default(float);
				while (true)
				{
					switch (num)
					{
					default:
						num = 5;
						continue;
					case 8:
						current = enumerator.Current;
						num2 = 0f;
						num3 = 0f;
						ClientCty.ႠႭ(myLat, myLon, DxccCacheData.ႷႤ(current.Value, 610, 527), 0f - DxccCacheData.ႷႤ(current.Value, 638, 528), ref num2, ref num3, 473, 'ǈ');
						goto case 0;
					case 0:
						num = ⴗ[145] - 59482;
						continue;
					case 3:
						ႥႥ.ႤႠ(current.Value, num2, 114, 86);
						goto case 1;
					case 1:
						UserInfo.Ⴈ(current.Value, num3, 940, 970);
						break;
					case 5:
					case 6:
						break;
					case 4:
						goto end_IL_0057;
					}
					num = (enumerator.MoveNext() ? (ⴀႠ[43] - 35178) : 4);
					continue;
					end_IL_0057:
					break;
				}
			}
			finally
			{
				switch (1)
				{
				default:
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					break;
				case 0:
				case 2:
					break;
				}
			}
			switch (4)
			{
			}
		}
		finally
		{
			int num4 = 1;
			while (true)
			{
				int num5;
				switch (num4)
				{
				default:
					num5 = (flag ? (ⴗ[23] - 52202) : 0);
					goto IL_01bc;
				case 4:
					Monitor.Exit(ⴃ);
					break;
				case 0:
					break;
				}
				break;
				IL_01bc:
				num4 = num5;
			}
		}
		switch (4)
		{
		}
	}

	[SecuritySafeCritical]
	static CtyHdgDistCache()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				ArcClientConnectDat.Ⴍ();
				goto case 2;
			case 2:
				CtyHdgDistCache.m_Ⴃ = HighlightItuZoneCfg.Ⴓ(ClientCty.Ⴗ('(', 7, 307012099), 227, 211);
				break;
			case 1:
				break;
			case 4:
				CtyHdgDistCache.m_Ⴃ = new object();
				return;
			}
			num = ⴀႠ[107] - 34906;
		}
	}
}
