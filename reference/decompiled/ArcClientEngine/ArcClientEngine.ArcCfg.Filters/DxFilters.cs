using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Security;
using System.Threading;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Filters;
using ArcInterfaces.Spots;
using Ⴀ;

namespace ArcClientEngine.ArcCfg.Filters;

public sealed class DxFilters
{
	private DxCommentExtCfg.ႤႼ m_Ⴄ = new DxCommentExtCfg.ႤႼ();

	[Description("List of DX filters")]
	public List<DxFilter> List
	{
		get
		{
			char[] ⴗ = ႥႰ.Ⴗ;
			return this.m_Ⴄ.Ⴅ;
		}
		set
		{
			this.m_Ⴄ.Ⴅ = value;
		}
	}

	[Description("Default DX filter name")]
	public string DefaultFilterName
	{
		get
		{
			return this.m_Ⴄ.Ⴄ;
		}
		set
		{
			this.m_Ⴄ.Ⴄ = value;
		}
	}

	[Description("Default DX filter")]
	public string DefaultFilter
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			return this.m_Ⴄ.Ⴗ;
		}
		set
		{
			this.m_Ⴄ.Ⴗ = value;
			ႥႰ.Ⴗ[5] = (char)((ႥႰ.Ⴗ[5] ^ UserCmd.Ⴅ[119]) & 0xAD);
		}
	}

	public DxFilters()
	{
		List = new List<DxFilter>();
		DefaultFilterName = string.Empty;
		DefaultFilter = string.Empty;
	}

	internal void Ⴗ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new DxFilter(WxFilters.Ⴀ(null, 2, 103387773), string.Empty);
				List.Add(obj as DxFilter);
				num = ⴀႠ[10] - 7240;
				break;
			case 6:
				obj = new DxFilter(ClientCty.Ⴗ('\u0082', 0, 307015193), WxFilters.Ⴀ(null, 8, 103388855));
				goto case 0;
			case 0:
				num = 5;
				break;
			case 5:
				List.Add((DxFilter)obj);
				goto case 7;
			case 7:
				obj = new DxFilter(ႥႥ.Ⴅ(1673507410, null, 4), ႥႥ.Ⴅ(1673508161, null, 8));
				num = 1;
				break;
			case 1:
				List.Add((DxFilter)obj);
				obj = new DxFilter(ႥႥ.Ⴍ(8, 1580608070, 'Ý', null), ႥႥ.Ⴍ(1, 1580608855, ')', null));
				num = ⴅ[351] - 50;
				break;
			case 3:
				List.Add((DxFilter)obj);
				obj = new DxFilter(WxFilters.Ⴀ(null, 4, 103388593), ClientCty.Ⴗ('`', 8, 307015172));
				num = ⴄ[91] - 47808;
				break;
			case 8:
			case 9:
				List.Add(obj as DxFilter);
				obj = new DxFilter(ClientCty.Ⴗ('-', 1, 307015205), ႥႥ.Ⴅ(1673507452, null, 4));
				num = 2;
				break;
			case 2:
				List.Add(obj as DxFilter);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static DxFilters()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static string Ⴈ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : string where _0021_00211 : string
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 1:
					num2 = (((P_3 ^ P_2) - 88) ^ num) switch
					{
						0 => ⴗ[32] - 52746, 
						_ => ⴅ[62] - 204, 
					};
					continue;
				case 2:
					obj = null;
					goto case 5;
				case 5:
					num2 = ⴗ[86] - 42638;
					continue;
				case 4:
					obj = string.Concat(P_0, P_1);
					num2 = 7;
					continue;
				case 7:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 9;
					continue;
				case 9:
					num2 = ((num3 % 2 != 0) ? (ⴀႠ[68] - 51746) : ⴅ[17]);
					continue;
				case 0:
				case 3:
				case 8:
					return (string)obj;
				case 10:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 7;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 1;
				break;
			case 1:
				num = (((P_1 ^ P_2) - 102) ^ num3) switch
				{
					0 => 0, 
					_ => 9, 
				};
				break;
			case 2:
			case 9:
				num = ⴅ[4];
				break;
			case 0:
				Monitor.Exit(P_0);
				goto case 8;
			case 8:
				num3++;
				goto case 6;
			case 6:
				num2 = P_1 * P_1;
				goto case 4;
			case 4:
				num2 = P_1 + num2;
				num = ⴅ[285];
				break;
			case 5:
				num = ((num2 % 2 != 0) ? (ⴀႠ[48] - 3660) : (ⴄ[47] - 24198));
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴄ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : DxSpot
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 8;
					continue;
				case 8:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 110) ^ num) switch
					{
						0 => ⴀႠ[93] - 27754, 
						1 => ⴅ[11] - 124, 
						_ => 2, 
					};
					continue;
				case 2:
					result = true;
					num2 = 3;
					continue;
				case 11:
					result = P_0.IsSkimValid;
					goto case 4;
				case 4:
					num2 = 3;
					continue;
				case 7:
				case 9:
				case 12:
					result = P_0.SkimDupe;
					num2 = 3;
					continue;
				case 3:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? ⴅ[285] : (ⴄ[151] - 41330));
					continue;
				case 6:
					num2 = 1;
					continue;
				case 5:
					return result;
				case 10:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴐ(ref TimeSpan P_0, int P_1, int P_2)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[273] - 10912;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[23] - 52197;
					continue;
				case 9:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 80) ^ num) switch
					{
						0 => 1, 
						_ => 3, 
					};
					continue;
				case 3:
					result = 4;
					num2 = ⴄ[205] - 14641;
					continue;
				case 1:
				case 11:
					result = P_0.Seconds;
					num2 = 6;
					continue;
				case 6:
				{
					num++;
					int num3 = 2028;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? 5 : (ⴄ[203] - 20729));
					continue;
				}
				case 4:
				case 8:
					num2 = 0;
					continue;
				case 2:
				case 5:
					return result;
				case 10:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210>(_0021_00210 P_0, ThreadPriority P_1, char P_2, char P_3) where _0021_00210 : Thread
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႠ[115] - 48710;
				break;
			case 7:
				num = (((P_2 ^ P_3) - 77) ^ num2) switch
				{
					0 => 1, 
					_ => ⴀႠ[108] - 45141, 
				};
				break;
			case 2:
				num = ⴅ[115];
				break;
			case 1:
				P_0.Priority = P_1;
				goto case 3;
			case 3:
			case 4:
				num2++;
				goto case 8;
			case 8:
			{
				int num3 = 127;
				int num4 = 374;
				num = ((3740 > num4 - num3 * 10) ? 5 : (ⴀႠ[99] - ⴀႠ[99]));
				break;
			}
			case 0:
			case 9:
				num = 7;
				break;
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : ResolveEventArgs
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		ICustomAttributeProvider customAttributeProvider = default(ICustomAttributeProvider);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[102];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 6;
					continue;
				case 6:
					break;
				case 10:
					num2 = (((P_1 ^ P_2) - 77) ^ num) switch
					{
						0 => ⴗ[93] - 63511, 
						_ => 0, 
					};
					continue;
				case 0:
					customAttributeProvider = null;
					goto case 5;
				case 5:
					num2 = ⴗ[21] - 63698;
					continue;
				case 8:
					customAttributeProvider = P_0.RequestingAssembly;
					num2 = 11;
					continue;
				case 2:
				case 11:
				{
					num++;
					int num3 = 127;
					int num4 = 374;
					num2 = ((3740 > num4 - num3 * 10) ? 3 : (ⴗ[111] - 41304));
					continue;
				}
				case 9:
					num2 = ⴗ[97] - 31958;
					continue;
				case 3:
					return customAttributeProvider as Assembly;
				case 4:
					num2 = ⴄ[80] - 22722;
					continue;
				}
				break;
			}
		}
	}
}
