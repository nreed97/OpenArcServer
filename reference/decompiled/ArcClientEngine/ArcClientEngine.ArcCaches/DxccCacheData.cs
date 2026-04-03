using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ArcShared;
using ArcShared.DgvUtils.DgvFilter;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public sealed class DxccCacheData
{
	internal sealed class ႷႭ
	{
		internal bool Ⴐ;

		internal ႷႭ()
		{
		}
	}

	internal sealed class ႷႷ
	{
		internal IContainer Ⴀ;

		internal ArcClientObjMgr Ⴓ;

		internal DgvFilterManager Ⴃ;

		internal string Ⴍ;

		internal string Ⴈ;

		internal ႷႷ()
		{
		}
	}

	private string m_Ⴅ;

	private string m_Ⴈ;

	private string m_Ⴗ;

	private string m_ႭႭ;

	private string m_ႭႤ;

	private string m_ႭႨ;

	private string m_ႭႰ;

	private string m_ႭႷ;

	private DxCommentExtCfg.ႤႭ ႣႨ = new DxCommentExtCfg.ႤႭ();

	[SpecialName]
	internal void Ⴍ(string P_0)
	{
		this.m_Ⴅ = P_0;
	}

	[SpecialName]
	internal string Ⴗ()
	{
		string ⴅ = this.m_Ⴅ;
		HighlightCtyCfg.ႠႠ[17] = (char)((HighlightCtyCfg.ႠႠ[17] - ႥႰ.Ⴗ[156]) & 0x47);
		return ⴅ;
	}

	[SpecialName]
	internal void Ⴀ(string P_0)
	{
		ႣႨ.Ⴈ = P_0;
	}

	[SpecialName]
	internal string Ⴀ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		return ႣႨ.Ⴈ;
	}

	[SpecialName]
	internal void Ⴈ(string P_0)
	{
		ႣႨ.Ⴅ = P_0 as string;
	}

	[SpecialName]
	internal string Ⴅ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		return ႣႨ.Ⴅ;
	}

	[SpecialName]
	internal void Ⴐ(string P_0)
	{
		this.m_Ⴈ = P_0;
	}

	[SpecialName]
	internal string Ⴍ()
	{
		return this.m_Ⴈ;
	}

	[SpecialName]
	internal void Ⴄ(string P_0)
	{
		ႣႨ.Ⴀ = P_0 as string;
	}

	[SpecialName]
	internal string Ⴈ()
	{
		char[] ⴄ = Bye.Ⴄ;
		return ႣႨ.Ⴀ;
	}

	[SpecialName]
	internal void Ⴃ(string P_0)
	{
		ႣႨ.Ⴍ = P_0 as string;
	}

	[SpecialName]
	internal string Ⴐ()
	{
		char[] ⴄ = Bye.Ⴄ;
		return ႣႨ.Ⴍ;
	}

	[SpecialName]
	internal void Ⴅ(string P_0)
	{
		ႣႨ.Ⴗ = P_0;
	}

	[SpecialName]
	internal string Ⴃ()
	{
		return ႣႨ.Ⴗ;
	}

	[SpecialName]
	internal void Ⴓ(string P_0)
	{
		this.m_Ⴗ = P_0;
	}

	[SpecialName]
	internal string Ⴓ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		return this.m_Ⴗ;
	}

	[SpecialName]
	internal void Ⴜ(string P_0)
	{
		ႣႨ.Ⴃ = P_0 as string;
	}

	[SpecialName]
	internal string Ⴄ()
	{
		return ႣႨ.Ⴃ;
	}

	[SpecialName]
	internal void ႭႷ(string P_0)
	{
		ႣႨ.Ⴓ = P_0 as string;
	}

	[SpecialName]
	internal string Ⴜ()
	{
		return ႣႨ.Ⴓ;
	}

	[SpecialName]
	internal void ႭႭ(string P_0)
	{
		ႣႨ.Ⴐ = P_0;
	}

	[SpecialName]
	internal string ႠႷ()
	{
		return ႣႨ.Ⴐ;
	}

	[SpecialName]
	internal void ႭႠ(string P_0)
	{
		this.m_ႭႭ = P_0;
	}

	[SpecialName]
	internal string ႠႠ()
	{
		return this.m_ႭႭ;
	}

	[SpecialName]
	internal void ႭႨ(string P_0)
	{
		this.m_ႭႤ = P_0;
	}

	[SpecialName]
	internal string ႠႥ()
	{
		string ⴍႤ = this.m_ႭႤ;
		HighlightCtyCfg.ႠႠ[95] = (char)((HighlightCtyCfg.ႠႠ[95] + HighlightCtyCfg.ႠႠ[10]) & 0xA9);
		return ⴍႤ;
	}

	[SpecialName]
	internal void ႭႰ(string P_0)
	{
		this.m_ႭႨ = P_0;
	}

	[SpecialName]
	internal string ႠႭ()
	{
		string ⴍႨ = this.m_ႭႨ;
		UserCmd.Ⴅ[289] = (byte)((UserCmd.Ⴅ[289] * UserCmd.Ⴅ[200]) & 0xD4);
		return ⴍႨ;
	}

	[SpecialName]
	internal void ႭႤ(string P_0)
	{
		ႣႨ.Ⴄ = P_0;
	}

	[SpecialName]
	internal string ႠႨ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		return ႣႨ.Ⴄ;
	}

	[SpecialName]
	internal void ႭႣ(string P_0)
	{
		this.m_ႭႰ = P_0;
	}

	[SpecialName]
	internal string ႠႰ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		string ⴍႰ = this.m_ႭႰ;
		UserCmd.Ⴅ[227] = (byte)((UserCmd.Ⴅ[227] | UserCmd.Ⴅ[200]) & 0x47);
		return ⴍႰ;
	}

	[SpecialName]
	internal void ႭႥ(string P_0)
	{
		ႣႨ.Ⴜ = P_0 as string;
	}

	[SpecialName]
	internal string ႠႣ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		return ႣႨ.Ⴜ;
	}

	[SpecialName]
	internal void ႭႳ(string P_0)
	{
		this.m_ႭႷ = P_0;
	}

	[SpecialName]
	internal string ႠႳ()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		return this.m_ႭႷ;
	}

	internal DxccCacheData(string P_0)
	{
		Ⴍ(ShowDxFilter.Ⴍ(HighlightArrlSectionCfg.Ⴍ(P_0, 0, 31, 1008, 972), 'ϻ', 982));
		Ⴀ(FilterViewer.ႨႷ(ShowDxFilter.Ⴍ(HighlightArrlSectionCfg.Ⴍ(P_0, 32, 6, 949, 905), 'ɤ', 585), 365, 326));
		Ⴀ(HighlightArrlSectionCfg.Ⴀ(Ⴀ(), ClientCty.Ⴗ('À', 6, 307012838), ႥႥ.Ⴍ(4, 1580608070, '\u008f', P_0), '°', 187));
		Ⴈ(HighlightArrlSectionCfg.Ⴍ(P_0, 45, 1, 750, 722));
		Ⴐ(HighlightArrlSectionCfg.Ⴍ(P_0, 52, 1, 368, 332));
		Ⴄ(HighlightArrlSectionCfg.Ⴍ(P_0, 58, 1, 256, 316));
		Ⴃ(HighlightArrlSectionCfg.Ⴍ(P_0, 64, 1, 997, 985));
		Ⴅ(HighlightArrlSectionCfg.Ⴍ(P_0, 70, 1, 954, 902));
		Ⴓ(HighlightArrlSectionCfg.Ⴍ(P_0, 76, 1, 675, 671));
		Ⴜ(HighlightArrlSectionCfg.Ⴍ(P_0, 81, 1, 701, 641));
		ႭႷ(HighlightArrlSectionCfg.Ⴍ(P_0, 86, 1, 464, 492));
		ႭႭ(HighlightArrlSectionCfg.Ⴍ(P_0, 91, 1, 439, 395));
		ႭႠ(P_0.Substring(96, 1));
		ႭႨ(P_0.Substring(101, 1));
		ႭႰ(P_0.Substring(106, 1));
		ႭႤ(P_0.Substring(111, 1));
		ႭႣ(P_0.Substring(116, 1));
		ႭႥ(P_0.Substring(121, 1));
		ႭႳ(P_0.Substring(126, 1));
	}

	internal string ႭႼ(string P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		object obj = default(object);
		Array array = default(Array);
		while (true)
		{
			IConvertible convertible = string.Empty;
			int num = ((ႳႳ.Ⴓ(P_0, 'ò', 212) <= 0) ? 23 : (ⴗ[16] - 26620));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႠ[40] - 10974;
					continue;
				case 9:
					break;
				case 21:
					convertible = DxFilters.Ⴈ(P_0, WxFilters.Ⴀ(null, 8, 103387439), 846, 790);
					num = 23;
					continue;
				case 23:
				{
					object obj2 = convertible as string;
					obj = new string[5];
					((string[])obj)[0] = obj2 as string;
					num = ⴗ[54] - 48786;
					continue;
				}
				case 13:
					((string[])obj)[1] = FilterViewer.ႨႷ(Ⴀ(), 278, 314);
					num = 25;
					continue;
				case 25:
					(obj as string[])[2] = ClientCty.Ⴗ('?', 0, 307011938);
					((string[])obj)[3] = Ⴗ();
					num = 10;
					continue;
				case 10:
					(obj as string[])[4] = ႥႥ.Ⴍ(3, 1580609502, 'z', P_0);
					num = ⴄ[114];
					continue;
				case 22:
					convertible = ႳႰ.Ⴜ((string[])obj, 180, 210);
					convertible = DxFilters.Ⴈ(convertible as string, ႥႥ.Ⴅ(1673507821, null, 5), 195, 155);
					num = 24;
					continue;
				case 24:
				{
					IEnumerable enumerable = (string)convertible;
					array = new string[28];
					((string[])array)[0] = enumerable as string;
					num = 8;
					continue;
				}
				case 8:
					((string[])array)[1] = Ⴍ();
					(array as string[])[2] = WxFilters.Ⴀ(null, 2, 103388544);
					goto case 14;
				case 14:
					num = 12;
					continue;
				case 12:
					((string[])array)[3] = Ⴈ();
					(array as string[])[4] = WxFilters.Ⴀ(null, 4, 103388550);
					num = ⴗ[13] - 41483;
					continue;
				case 15:
					(array as string[])[5] = Ⴐ();
					(array as string[])[6] = WxFilters.Ⴀ(null, 1, 103388547);
					num = 16;
					continue;
				case 16:
					((string[])array)[7] = Ⴃ();
					((string[])array)[8] = WxFilters.Ⴀ(null, 7, 103388549);
					num = ⴗ[154] - 7299;
					continue;
				case 6:
					((string[])array)[9] = Ⴄ();
					((string[])array)[10] = WxFilters.Ⴀ(null, 3, 103388545);
					num = 4;
					continue;
				case 4:
					((string[])array)[11] = Ⴜ();
					((string[])array)[12] = WxFilters.Ⴀ(null, 0, 103388546);
					num = ⴀႠ[104] - 61241;
					continue;
				case 26:
					((string[])array)[13] = ႠႷ();
					(array as string[])[14] = WxFilters.Ⴀ(null, 7, 103388549);
					num = 18;
					continue;
				case 0:
				case 18:
					(array as string[])[15] = ႠႠ();
					(array as string[])[16] = WxFilters.Ⴀ(null, 6, 103388548);
					num = 5;
					continue;
				case 5:
					(array as string[])[17] = ႠႥ();
					(array as string[])[18] = WxFilters.Ⴀ(null, 0, 103388546);
					num = 11;
					continue;
				case 11:
					(array as string[])[19] = ႠႭ();
					(array as string[])[20] = WxFilters.Ⴀ(null, 2, 103388544);
					num = 3;
					continue;
				case 3:
					(array as string[])[21] = ႠႨ();
					(array as string[])[22] = WxFilters.Ⴀ(null, 7, 103388549);
					num = 1;
					continue;
				case 1:
					((string[])array)[23] = ႠႰ();
					((string[])array)[24] = WxFilters.Ⴀ(null, 7, 103388549);
					goto case 17;
				case 17:
					num = 2;
					continue;
				case 2:
					(array as string[])[25] = ႠႣ();
					((string[])array)[26] = WxFilters.Ⴀ(null, 5, 103388551);
					num = 7;
					continue;
				case 7:
					(array as string[])[27] = ႠႳ();
					convertible = string.Concat(array as string[]);
					num = ⴗ[93] - 63500;
					continue;
				case 19:
					return convertible as string;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static DxccCacheData()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static string ႷႣ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : AnnWxSpot
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[111] - 41304;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
					break;
				case 9:
				{
					int num5 = P_2 ^ P_1;
					Bye.Ⴄ[42] = (char)((Bye.Ⴄ[42] * Bye.Ⴄ[103]) & 0x64);
					num2 = ((num5 - 49) ^ num) switch
					{
						0 => 4, 
						1 => 14, 
						2 => 13, 
						3 => 3, 
						_ => 2, 
					};
					continue;
				}
				case 2:
				case 8:
					obj = null;
					num2 = 7;
					continue;
				case 4:
					obj = P_0.Spotter;
					num2 = 7;
					continue;
				case 14:
					obj = P_0.SpotterNode;
					num2 = 7;
					continue;
				case 13:
					obj = P_0.SpotterCty;
					num2 = ⴅ[413] - ⴅ[22];
					continue;
				case 1:
				case 3:
					obj = P_0.SpotterState;
					num2 = ⴄ[163] - 58289;
					continue;
				case 6:
				case 7:
				{
					num++;
					int num3 = 194;
					int num4 = 512;
					num2 = ((2048 <= num4 - num3 * 4) ? 10 : 0);
					continue;
				}
				case 10:
					num2 = ⴅ[364] - 206;
					continue;
				case 0:
					return obj as string;
				case 11:
					num2 = ⴄ[304] - 28897;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႳ<_0021_00210>(_0021_00210 P_0, Color P_1, short P_2, char P_3) where _0021_00210 : DataGridViewCellStyle
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 9;
				break;
			case 9:
				num = (((P_2 ^ P_3) - 35) ^ num2) switch
				{
					0 => 3, 
					_ => 6, 
				};
				break;
			case 1:
			case 6:
				num = ⴀႠ[94] - 21826;
				break;
			case 3:
				P_0.BackColor = P_1;
				goto case 2;
			case 2:
			{
				num2++;
				int num3 = 13;
				int num4 = 192;
				num = ((1728 > num4 - num3 * 9) ? 5 : 7);
				break;
			}
			case 7:
				num = 9;
				break;
			case 4:
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႷႨ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : WwvSpot
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		ICloneable cloneable = default(ICloneable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[86] - 24352;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
					break;
				case 7:
					num2 = (((P_2 ^ P_1) - 52) ^ num) switch
					{
						0 => ⴄ[110] - 60790, 
						1 => ⴅ[285], 
						2 => ⴄ[156] - 11642, 
						_ => 10, 
					};
					continue;
				case 10:
					cloneable = null;
					num2 = 8;
					continue;
				case 6:
					cloneable = P_0.Sfi;
					num2 = ⴅ[4];
					continue;
				case 5:
					cloneable = P_0.A;
					num2 = ⴅ[4];
					continue;
				case 12:
				case 13:
					cloneable = P_0.Spotter;
					num2 = ⴗ[78] - 57614;
					continue;
				case 8:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					goto case 4;
				case 4:
					num2 = 9;
					continue;
				case 9:
					num2 = ((num3 % 2 != 0) ? (ⴗ[66] - 45147) : 0);
					continue;
				case 0:
					return (string)cloneable;
				case 1:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႷႠ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : CtyInfo
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[119] - 30787;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 9:
					break;
				case 10:
					num2 = (((P_1 ^ P_2) - 111) ^ num) switch
					{
						0 => ⴗ[156] - 48828, 
						_ => 3, 
					};
					continue;
				case 3:
					comparable = null;
					goto case 11;
				case 11:
					num2 = 1;
					continue;
				case 2:
					comparable = P_0.Continent;
					num2 = ⴅ[25] / 2;
					continue;
				case 1:
				case 7:
					num++;
					goto case 0;
				case 0:
				{
					int num3 = 74;
					int num4 = 325;
					num2 = ((2275 > num4 - num3 * 7) ? 6 : 5);
					continue;
				}
				case 5:
					num2 = ⴅ[102];
					continue;
				case 6:
					return comparable as string;
				case 8:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float ႷႤ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : CtyInfo
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		float result = default(float);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[294] - 26155;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 7:
				case 12:
					break;
				case 3:
					num2 = (((P_2 ^ P_1) - 109) ^ num) switch
					{
						0 => 0, 
						1 => 8, 
						_ => 9, 
					};
					continue;
				case 9:
					result = 0.26685745f;
					num2 = ⴀႠ[24] - 40410;
					continue;
				case 0:
					result = P_0.Latitude;
					num2 = ⴀႠ[103] - 38475;
					continue;
				case 8:
					result = P_0.Longitude;
					num2 = 4;
					continue;
				case 4:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 != 0) ? 1 : 5);
					continue;
				case 1:
				case 6:
					num2 = ⴗ[21] - 63706;
					continue;
				case 5:
					return result;
				case 2:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႷႰ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DataGridViewBand
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[197] - 45878;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[115];
					continue;
				case 4:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 91) ^ num) switch
					{
						0 => ⴀႠ[84] - 18801, 
						_ => ⴗ[129] - 40416, 
					};
					continue;
				case 2:
				case 6:
					result = 1;
					num2 = 11;
					continue;
				case 1:
				case 3:
					result = P_0.Index;
					num2 = 11;
					continue;
				case 10:
				case 11:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴀႠ[96] - 2578) : 8);
					continue;
				case 8:
					num2 = 9;
					continue;
				case 7:
					return result;
				case 0:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}
}
