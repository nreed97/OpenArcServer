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
using ArcClientEngine.ArcForms;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcShared;
using ArcShared.ArcUtils;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public sealed class CtyCache
{
	private static readonly ILog m_Ⴄ;

	private static readonly object m_Ⴃ;

	private int m_Ⴍ;

	private AnnFilters.Ⴅ m_Ⴀ = new AnnFilters.Ⴅ();

	public CtyCache()
	{
		object obj = new Dictionary<string, CtyInfo>();
		this.m_Ⴀ.Ⴃ = (Dictionary<string, CtyInfo>)obj;
		Init();
	}

	public void Init()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		bool flag = false;
		object ⴃ = default(object);
		try
		{
			switch (2)
			{
			default:
				ႥႥ.ႤႨ(ⴃ = CtyCache.m_Ⴃ, ref flag, 654, 767);
				try
				{
					int num = 5;
					object obj = default(object);
					object obj5 = default(object);
					IEnumerable<char> enumerable = default(IEnumerable<char>);
					object obj3 = default(object);
					TextReader textReader = default(TextReader);
					IComparable<string> comparable = default(IComparable<string>);
					while (true)
					{
						switch (num)
						{
						default:
						{
							obj = new PrecisionTimer();
							MultimediaCfg.Ⴄ(obj as PrecisionTimer, 478, 500);
							int ⴍ2 = 0;
							this.m_Ⴀ.Ⴍ = ⴍ2;
							num = 3;
							continue;
						}
						case 3:
							this.m_Ⴍ = 0;
							this.m_Ⴀ.Ⴃ.Clear();
							obj5 = WxFilters.ႭႭ(1002, 961);
							num = ⴅ[383] - 183;
							continue;
						case 19:
							enumerable = DxFilters.Ⴈ(HighlightCfg.ႳႳ(ႥႠ.Ⴅ(obj5 as Assembly, 575, 515), '\u0320', 844), ClientCty.Ⴗ('\u0018', 4, 307013265), 112, 40);
							goto case 17;
						case 17:
							num = ⴄ[169] - 10933;
							continue;
						case 6:
						{
							obj3 = new List<string>();
							object obj4 = new FileStream((string)enumerable, FileMode.Open, FileAccess.Read);
							textReader = new StreamReader(obj4 as FileStream);
							num = ⴄ[290] - 49150;
							continue;
						}
						case 1:
							comparable = HighlightItuZoneCfg.Ⴜ((TextReader)(textReader as StreamReader), (short)198, (short)147);
							num = ⴄ[62] - 13511;
							continue;
						case 13:
						{
							int ⴍ = this.m_Ⴀ.Ⴍ + 1;
							this.m_Ⴀ.Ⴍ = ⴍ;
							num = ⴅ[176];
							continue;
						}
						case 15:
							num = (ႥႤ.Ⴍ((string)comparable, WxFilters.Ⴀ(null, 0, 103387681), 11, 49) ? 18 : 10);
							continue;
						case 10:
							num = ((ႳႳ.Ⴓ((string)comparable, 'ŋ', 365) <= 1) ? 4 : (ⴄ[186] - 26692));
							continue;
						case 14:
							num = ((SetDxFilter.Ⴈ(comparable as string, 1, 177, 233) == ' ') ? 4 : 2);
							continue;
						case 2:
							num = ((((List<string>)obj3).Count <= 0) ? (ⴀႠ[20] - 33396) : 8);
							continue;
						case 0:
						case 8:
							Ⴐ((List<string>)obj3);
							((List<string>)obj3).Clear();
							goto case 4;
						case 4:
							(obj3 as List<string>).Add((string)comparable);
							goto case 18;
						case 18:
							comparable = HighlightItuZoneCfg.Ⴜ((TextReader)(StreamReader)textReader, (short)115, (short)38);
							num = 16;
							continue;
						case 16:
							num = ((comparable is string) ? 13 : 12);
							continue;
						case 12:
							UserInfo.Ⴓ((TextReader)(StreamReader)textReader, 'Ö', 'Þ');
							Ⴐ((List<string>)obj3);
							goto case 11;
						case 11:
							num = ⴅ[171] - 217;
							continue;
						case 7:
						{
							MultimediaCfg.Ⴈ((PrecisionTimer)obj, 625, 592);
							ILog ⴄ2 = CtyCache.m_Ⴄ;
							object obj2 = new object[6];
							(obj2 as object[])[0] = (PrecisionTimer)obj;
							(obj2 as object[])[1] = ႥႥ.Ⴅ(1673508116, null, 8);
							(obj2 as object[])[2] = this.m_Ⴍ.ToString();
							((object[])obj2)[3] = ClientCty.Ⴗ('±', 2, 307013307);
							((object[])obj2)[4] = this.m_Ⴀ.Ⴍ.ToString();
							(obj2 as object[])[5] = ႥႥ.Ⴅ(1673508114, null, 3);
							ⴄ2.Info(string.Concat((object[])obj2));
							break;
						}
						}
						break;
					}
				}
				catch (Exception ex)
				{
					CtyCache.m_Ⴄ.Error(ex.Message);
				}
				switch (0)
				{
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
					num3 = (flag ? (ⴄ[47] - 24197) : 0);
					goto IL_044e;
				case 4:
					Monitor.Exit(ⴃ);
					break;
				case 0:
				case 2:
				case 3:
				case 6:
					break;
				}
				break;
				IL_044e:
				num2 = num3;
			}
		}
		switch (0)
		{
		}
	}

	private void Ⴐ(IList<string> P_0)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		try
		{
			int num = 11;
			IConvertible convertible = default(IConvertible);
			object obj2 = default(object);
			int num2 = default(int);
			Array array = default(Array);
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					convertible = MultimediaCache.Ⴐ(P_0[0], 69, 'ˋ', 'ʨ');
					convertible = HighlightArrlSectionCfg.Ⴀ((string)convertible, ႥႥ.Ⴍ(3, 1580608894, '\n', null), string.Empty, '2', 57);
					num = ⴄ[209] - 1374;
					continue;
				case 16:
					num = ((SetDxFilter.Ⴈ((string)convertible, 0, 335, 279) != '*') ? 5 : (ⴄ[74] - 30087));
					continue;
				case 13:
					break;
				case 5:
					this.m_Ⴍ++;
					obj2 = new CtyInfo(P_0[0]);
					num = 9;
					continue;
				case 9:
					num = (this.m_Ⴀ.Ⴃ.ContainsKey(ShowUsers.Ⴅ((CtyInfo)obj2, 933, 958)) ? 17 : 14);
					continue;
				case 14:
					this.m_Ⴀ.Ⴃ.Add(ShowUsers.Ⴅ((CtyInfo)obj2, 624, 619), obj2 as CtyInfo);
					goto case 17;
				case 17:
					num2 = 1;
					num = 0;
					continue;
				case 3:
				{
					string text = ShowDxFilter.Ⴍ(P_0[num2], 'Ȟ', 563);
					object obj = new char[1];
					((char[])obj)[0] = ',';
					array = ႳႳ.Ⴄ(text, (char[])obj, 445, 'ǲ');
					goto case 8;
				}
				case 8:
					num = 18;
					continue;
				case 18:
					num3 = 0;
					goto case 10;
				case 10:
				case 15:
					num = 1;
					continue;
				case 7:
					num = ((ႳႳ.Ⴓ((array as string[])[num3], 'ʱ', 663) <= 0) ? 12 : 2);
					continue;
				case 2:
				{
					ICloneable cloneable = (array as string[])[num3];
					Ⴈ(cloneable as string, obj2 as CtyInfo);
					goto case 12;
				}
				case 12:
					num3++;
					num = ⴗ[106] - 22862;
					continue;
				case 1:
					num = ((num3 < (array as string[]).Length) ? (ⴗ[21] - 63702) : 6);
					continue;
				case 6:
					num2++;
					num = 0;
					continue;
				case 0:
					num = ((num2 < P_0.Count) ? (ⴀႠ[94] - 21825) : 4);
					continue;
				case 4:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			CtyCache.m_Ⴄ.Error(ex.Message);
		}
		switch (2)
		{
		}
	}

	private void Ⴈ(string P_0, CtyInfo P_1)
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!Ⴍ(P_0)) ? (ⴄ[110] - 60794) : 0);
				break;
			case 0:
			case 3:
			case 4:
				P_1 = Ⴃ(P_0, P_1);
				num = 2;
				break;
			case 2:
				P_0 = Ⴓ(P_0);
				try
				{
					int num2 = 3;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = (this.m_Ⴀ.Ⴃ.ContainsKey(P_0) ? (ⴄ[263] - 60386) : (ⴄ[207] - 181));
							break;
						case 0:
						case 5:
							this.m_Ⴀ.Ⴃ.Add(P_0, P_1);
							return;
						case 1:
							return;
						}
						num2 = num3;
					}
				}
				catch (Exception ex)
				{
					ILog ⴄ2 = CtyCache.m_Ⴄ;
					object obj = new object[8];
					(obj as object[])[0] = ႥႥ.Ⴅ(1673508288, null, 8);
					((object[])obj)[1] = this.m_Ⴀ.Ⴍ;
					(obj as object[])[2] = ႥႥ.Ⴍ(3, 1580608789, '-', P_0);
					((object[])obj)[3] = P_0;
					(obj as object[])[4] = WxFilters.Ⴀ(null, 4, 103387893);
					(obj as object[])[5] = ShowUsers.Ⴅ(P_1, 294, 317);
					((object[])obj)[6] = ႥႥ.Ⴅ(1673508291, null, 1);
					(obj as object[])[7] = FilterCfg.Ⴍ(ex, 301, 291);
					ⴄ2.Error(string.Concat((object[])obj));
					return;
				}
			}
		}
	}

	private string Ⴓ(string P_0)
	{
		while (true)
		{
			Array array = ႳႳ.Ⴄ(P_0, new char[6] { '(', '[', '{', '<', '~', ';' }, 698, '\u02f5');
			while (true)
			{
				IL_0054:
				int num = 6;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 5;
						continue;
					case 5:
						break;
					case 7:
						goto IL_0054;
					case 1:
					case 6:
						num = ((((string[])array).Length <= 1) ? 2 : 0);
						continue;
					case 0:
					case 3:
						return (array as string[])[0];
					case 2:
						return P_0;
					}
					break;
				}
				break;
			}
		}
	}

	private CtyInfo Ⴃ(string P_0, CtyInfo P_1)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		while (true)
		{
			object obj = new CtyInfo(P_1);
			obj = Ⴐ(P_0, obj as CtyInfo);
			obj = Ⴀ(P_0, obj as CtyInfo);
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႠ[50] - ⴀႠ[50];
					continue;
				case 0:
					break;
				case 3:
					obj = Ⴄ(P_0, (CtyInfo)obj);
					obj = Ⴗ(P_0, obj as CtyInfo);
					num = 4;
					continue;
				case 4:
					obj = Ⴓ(P_0, (CtyInfo)obj);
					goto case 2;
				case 2:
				case 5:
					return (CtyInfo)obj;
				}
				break;
			}
		}
	}

	private CtyInfo Ⴐ(string P_0, CtyInfo P_1)
	{
		while (true)
		{
			Array array = new char[2];
			((char[])array)[0] = '(';
			((char[])array)[1] = ')';
			object obj = ႳႳ.Ⴄ(P_0, array as char[], 476, 'Ɠ');
			while (true)
			{
				IL_0064:
				int num = 1;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 4;
						continue;
					case 4:
						break;
					case 2:
					case 3:
						goto IL_0064;
					case 1:
						num = ((((string[])obj).Length > 1) ? 7 : 0);
						continue;
					case 6:
					case 7:
						P_1.CqZone = HighlightCountyCfg.ႷႭ(((string[])obj)[0], '\u034a', '\u0323');
						goto case 0;
					case 0:
						return P_1;
					}
					break;
				}
				break;
			}
		}
	}

	private CtyInfo Ⴀ(string P_0, CtyInfo P_1)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		while (true)
		{
			object obj = new char[2];
			((char[])obj)[0] = '[';
			(obj as char[])[1] = ']';
			object obj2 = ႳႳ.Ⴄ(P_0, obj as char[], 967, 'Έ');
			int num = 7;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄ[99] - 59568;
					continue;
				case 0:
					break;
				case 4:
				case 7:
					num = ((((string[])obj2).Length <= 1) ? 6 : (ⴗ[140] - 60683));
					continue;
				case 2:
					P_1.ItuZone = HighlightCountyCfg.ႷႭ(((string[])obj2)[0], '\u031b', 'Ͳ');
					goto case 1;
				case 1:
				case 5:
				case 6:
					return P_1;
				}
				break;
			}
		}
	}

	private CtyInfo Ⴗ(string P_0, CtyInfo P_1)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		while (true)
		{
			Array array = new char[2];
			(array as char[])[0] = '<';
			(array as char[])[1] = '>';
			object obj = ႳႳ.Ⴄ(P_0, (char[])array, 627, 'ȼ');
			while (true)
			{
				IL_0079:
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴀႠ[84] - 18797;
						continue;
					case 5:
						break;
					case 4:
						goto IL_0079;
					case 2:
						num = (((obj as string[]).Length <= 1) ? 1 : 0);
						continue;
					case 0:
					case 7:
						UserInfo.Ⴈ(P_1, ShowUsers.Ⴍ(((string[])obj)[0], 663, 756), 968, 941);
						num = 6;
						continue;
					case 6:
						P_1.Longitude = CtyInfo.ScrubLon(((string[])obj)[0]);
						goto case 1;
					case 1:
					case 3:
						HighlightCtyCfg.ႠႠ[109] = (char)((HighlightCtyCfg.ႠႠ[109] - HighlightCtyCfg.ႠႠ[47]) & 0xC2);
						return P_1;
					}
					break;
				}
				break;
			}
		}
	}

	private CtyInfo Ⴄ(string P_0, CtyInfo P_1)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		while (true)
		{
			Array array = new char[2];
			((char[])array)[0] = '{';
			(array as char[])[1] = '}';
			object obj = ႳႳ.Ⴄ(P_0, (char[])array, 253, '²');
			int num = ⴗ[128] - 43521;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 7;
					continue;
				case 1:
				case 5:
				case 7:
					break;
				case 2:
					num = ((((string[])obj).Length <= 1) ? 6 : ⴅ[115]);
					continue;
				case 0:
				case 4:
					P_1.Continent = HighlightCfg.ႳႳ((obj as string[])[0], 'û', 150);
					goto case 6;
				case 6:
					return P_1;
				}
				break;
			}
		}
	}

	private CtyInfo Ⴓ(string P_0, CtyInfo P_1)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		while (true)
		{
			Array array = new char[2];
			((char[])array)[0] = '~';
			(array as char[])[1] = '~';
			object obj = ႳႳ.Ⴄ(P_0, array as char[], 452, 'Ƌ');
			int num = 7;
			while (true)
			{
				switch (num)
				{
				default:
				{
					/*OpCode not supported: LdMemberToken*/;
					char num2 = ⴀႠ[61];
					Bye.Ⴄ[189] = (char)((Bye.Ⴄ[189] * Bye.Ⴄ[282]) & 0x8B);
					num = num2 - 26821;
					continue;
				}
				case 0:
					break;
				case 7:
					num = (((obj as string[]).Length <= 1) ? 4 : (ⴅ[318] - 238));
					continue;
				case 3:
					P_1.TimeOffset = ShowDxFilter.Ⴗ(((string[])obj)[0], 439, 'ƍ');
					goto case 1;
				case 1:
				case 4:
				case 5:
				case 6:
					return P_1;
				}
				break;
			}
		}
	}

	private bool Ⴍ(string P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		while (true)
		{
			int num = (DxCommentExtCfg.ႤႰ(P_0, WxFilters.Ⴀ(null, 4, 103387896), 'Γ', 950) ? 2 : 6);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႠ[86] - 44444;
					continue;
				case 8:
					break;
				case 3:
				case 6:
				case 7:
				case 9:
					num = ((!DxCommentExtCfg.ႤႰ(P_0, ႥႥ.Ⴍ(5, 1580608818, '©', P_0), '!', 4)) ? 1 : (ⴅ[36] - 49));
					continue;
				case 1:
					num = (DxCommentExtCfg.ႤႰ(P_0, ႥႥ.Ⴅ(1673508305, null, 2), 'Ŋ', 367) ? (ⴀႠ[68] - 51745) : 5);
					continue;
				case 5:
					num = (DxCommentExtCfg.ႤႰ(P_0, ClientCty.Ⴗ('×', 1, 307013319), 'ǵ', 464) ? (ⴅ[115] / 2) : 4);
					continue;
				case 4:
					return P_0.Contains(WxFilters.Ⴀ(null, 7, 103387885));
				case 2:
					return true;
				}
				break;
			}
		}
	}

	public CtyInfo CtyInfoFromCall(string callsign)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		bool flag = false;
		object ⴃ = default(object);
		object obj = default(object);
		try
		{
			int num = 6;
			IEnumerable enumerable = default(IEnumerable);
			while (true)
			{
				switch (num)
				{
				default:
					ႥႥ.ႤႨ(ⴃ = CtyCache.m_Ⴃ, ref flag, 315, 330);
					enumerable = FilterViewer.ႨႷ(callsign, 52, 24);
					num = ⴅ[330] - ⴅ[113];
					continue;
				case 7:
					num = ((!this.m_Ⴀ.Ⴃ.ContainsKey((string)enumerable)) ? 10 : 11);
					continue;
				case 11:
					obj = this.m_Ⴀ.Ⴃ[enumerable as string];
					break;
				case 10:
					enumerable = ShowDxFilter.Ⴗ(enumerable as string, 769, '\u033a');
					num = ⴗ[134] - 12471;
					continue;
				case 4:
				case 8:
					num = ((!this.m_Ⴀ.Ⴃ.ContainsKey((string)enumerable)) ? (ⴗ[65] - ⴗ[65]) : (ⴗ[130] - 30830));
					continue;
				case 2:
					obj = this.m_Ⴀ.Ⴃ[enumerable as string];
					break;
				case 1:
				case 9:
					break;
				case 0:
					enumerable = HighlightArrlSectionCfg.Ⴍ((string)enumerable, 0, ႳႳ.Ⴓ(enumerable as string, 'ç', 193) - 1, 257, 317);
					num = ⴄ[193] - 25233;
					continue;
				case 12:
					num = (((enumerable as string).Length > 0) ? (ⴄ[290] - 49143) : 3);
					continue;
				case 3:
					goto IL_0217;
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
					num3 = ((!flag) ? 4 : 0);
					goto IL_0209;
				case 0:
					Monitor.Exit(ⴃ);
					break;
				case 4:
					break;
				}
				break;
				IL_0209:
				num2 = num3;
			}
		}
		goto IL_023b;
		IL_0217:
		switch (0)
		{
		default:
			return null;
		case 1:
		case 5:
			break;
		}
		goto IL_023b;
		IL_023b:
		return (CtyInfo)obj;
	}

	[SecuritySafeCritical]
	static CtyCache()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				ArcClientConnectDat.Ⴍ();
				goto case 0;
			case 0:
				CtyCache.m_Ⴄ = HighlightItuZoneCfg.Ⴓ(ႥႥ.Ⴍ(2, 1580608817, 'f', null), 417, 401);
				break;
			case 3:
				break;
			case 1:
			case 4:
				CtyCache.m_Ⴃ = new object();
				return;
			}
			num = ⴅ[241] - 74;
		}
	}
}
