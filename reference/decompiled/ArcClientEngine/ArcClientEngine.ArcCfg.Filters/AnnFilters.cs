using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Filters;
using ArcInterfaces.Io;
using ArcShared;
using ArcShared.ArcIo.Tcp;
using ArcShared.ArcUtils;
using ZedGraph;
using Ⴀ;

namespace ArcClientEngine.ArcCfg.Filters;

public sealed class AnnFilters
{
	internal sealed class Ⴅ
	{
		internal Dictionary<string, CtyInfo> Ⴃ;

		internal int Ⴍ;

		internal Ⴅ()
		{
		}
	}

	private DxSpotRateGraph.Ⴍ m_Ⴅ = new DxSpotRateGraph.Ⴍ();

	[Description("List of announce filters")]
	public List<AnnFilter> List
	{
		get
		{
			return this.m_Ⴅ.Ⴄ;
		}
		set
		{
			this.m_Ⴅ.Ⴄ = value;
		}
	}

	[Description("Default announce filter name")]
	public string DefaultFilterName
	{
		get
		{
			string ⴍ = this.m_Ⴅ.Ⴍ;
			ႥႰ.Ⴗ[96] = (char)((ႥႰ.Ⴗ[96] | ႥႰ.Ⴗ[135]) & 0xBE);
			return ⴍ;
		}
		set
		{
			this.m_Ⴅ.Ⴍ = value as string;
			HighlightCtyCfg.ႠႠ[18] = (char)(HighlightCtyCfg.ႠႠ[18] & HighlightCtyCfg.ႠႠ[33] & 0xAA);
		}
	}

	[Description("Default announce filter")]
	public string DefaultFilter
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return this.m_Ⴅ.Ⴀ;
		}
		set
		{
			this.m_Ⴅ.Ⴀ = value;
		}
	}

	public AnnFilters()
	{
		List = new List<AnnFilter>();
		DefaultFilterName = string.Empty;
		DefaultFilter = string.Empty;
	}

	internal void Ⴈ()
	{
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new AnnFilter(WxFilters.Ⴀ(null, 0, 103387775), string.Empty);
				List.Add((AnnFilter)obj);
				num = 6;
				break;
			case 6:
				obj = new AnnFilter(ClientCty.Ⴗ('¾', 6, 307011994), ႥႥ.Ⴅ(1673508173, null, 4));
				goto case 2;
			case 2:
				num = 1;
				break;
			case 1:
				List.Add((AnnFilter)obj);
				obj = new AnnFilter(ႥႥ.Ⴅ(1673507735, null, 2), ႥႥ.Ⴍ(8, 1580608862, '\u0097', null));
				num = 5;
				break;
			case 5:
				List.Add(obj as AnnFilter);
				return;
			case 3:
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static AnnFilters()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : ZedGraph.Label
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴅ[321] - 230;
				break;
			case 9:
				num = (((P_3 ^ P_2) - 76) ^ num2) switch
				{
					0 => 2, 
					_ => ⴀႠ[103] - 38476, 
				};
				break;
			case 3:
				num = ⴀႠ[31] - 4535;
				break;
			case 1:
			case 2:
				P_0.Text = P_1;
				goto case 0;
			case 0:
			case 7:
			{
				num2++;
				int num3 = 246;
				int num4 = 712;
				num = ((3560 > num4 - num3 * 5) ? 6 : ⴅ[115]);
				break;
			}
			case 4:
				num = 9;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : Control
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 7;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				break;
			case 5:
			case 6:
				num = (((P_1 ^ P_2) - 31) ^ num2) switch
				{
					0 => 0, 
					_ => 9, 
				};
				break;
			case 2:
			case 9:
				num = ⴗ[106] - 22859;
				break;
			case 0:
				P_0.SuspendLayout();
				goto case 4;
			case 4:
				num2++;
				num3 = 141;
				goto case 8;
			case 8:
			{
				int num4 = 221;
				num = ((2210 > num4 - num3 * 10) ? 1 : (ⴀႠ[112] - 45131));
				break;
			}
			case 3:
				num = ⴗ[136] - 30459;
				break;
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static IIoDeviceCfg Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : TcpClient
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[116] - 60576;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 4;
					continue;
				case 4:
				case 9:
					break;
				case 10:
					num2 = (((P_1 ^ P_2) - 28) ^ num) switch
					{
						0 => 1, 
						_ => 11, 
					};
					continue;
				case 11:
					obj = null;
					goto case 5;
				case 5:
				case 8:
					num2 = ⴄ[92] - 14813;
					continue;
				case 1:
					obj = P_0.IoCfg;
					num2 = ⴗ[136] - 30462;
					continue;
				case 2:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴅ[213] - 242) : 7);
					continue;
				case 7:
					num2 = 10;
					continue;
				case 3:
					return (IIoDeviceCfg)obj;
				case 6:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static double Ⴍ(ref TimeSpan P_0, short P_1, char P_2)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		double result = default(double);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[121] - 89;
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
				case 1:
				case 4:
					num2 = (((P_1 ^ P_2) - 115) ^ num) switch
					{
						0 => ⴗ[145] - 59477, 
						_ => 2, 
					};
					continue;
				case 2:
					result = 0.34756922921226074;
					num2 = 10;
					continue;
				case 8:
					result = P_0.TotalSeconds;
					num2 = 10;
					continue;
				case 10:
					num++;
					goto case 9;
				case 9:
				{
					int num3 = 640;
					int num4 = 681;
					num2 = ((2724 > num4 - num3 * 4) ? (ⴗ[154] - 7302) : 11);
					continue;
				}
				case 11:
					num2 = 4;
					continue;
				case 3:
					return result;
				case 0:
					num2 = ⴅ[115];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : DataGridViewCell
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		object result = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[239] - 49130;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄ[277] - 52017;
					continue;
				case 1:
					break;
				case 0:
				case 5:
					num2 = (((P_2 ^ P_1) - 62) ^ num) switch
					{
						0 => ⴀႠ[125] - 26171, 
						_ => 11, 
					};
					continue;
				case 11:
					result = null;
					num2 = ⴗ[127] - 17856;
					continue;
				case 4:
					result = P_0.Value;
					num2 = 8;
					continue;
				case 8:
					num++;
					goto case 9;
				case 9:
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 3;
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? (ⴗ[145] - 59480) : (ⴀႠ[34] - 62558));
					continue;
				case 2:
				case 6:
					return result;
				case 7:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : DataGridViewButtonColumn where _0021_00211 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 2;
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 7;
				break;
			case 7:
				num = (((P_2 ^ P_3) - 32) ^ num3) switch
				{
					0 => ⴀႠ[125] - 26167, 
					_ => ⴗ[37] - 54918, 
				};
				break;
			case 3:
				num = 0;
				break;
			case 5:
			case 8:
				P_0.Text = P_1;
				goto case 0;
			case 0:
			{
				int num2 = num3;
				ႥႰ.Ⴗ[36] = (char)((ႥႰ.Ⴗ[36] * UserCmd.Ⴅ[202]) & 0x9F);
				num3 = num2 + 1;
				int num4 = 139;
				int num5 = 362;
				num = ((3258 > num5 - num4 * 9) ? 1 : 6);
				break;
			}
			case 4:
			case 6:
				num = 7;
				break;
			case 1:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႰႥ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, short P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[134] - 12482;
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
					num2 = (((P_3 ^ P_2) - 109) ^ num) switch
					{
						0 => 9, 
						1 => ⴅ[176] - 11, 
						_ => 3, 
					};
					continue;
				case 3:
					comparable = null;
					num2 = ⴄ[162] - 34564;
					continue;
				case 9:
					comparable = UtilsString.GetArcId(P_0, P_1);
					num2 = ⴄ[214] - 20665;
					continue;
				case 4:
					comparable = UtilsMacros.ExpandDxFilterMacros(P_0, P_1);
					num2 = ⴀႠ[99] - 46018;
					continue;
				case 0:
				case 6:
				case 7:
					num++;
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					goto case 10;
				case 10:
					num2 = ⴄ[2] - 13952;
					continue;
				case 2:
					num2 = ((num3 % 2 != 0) ? 1 : 5);
					continue;
				case 5:
					return (string)comparable;
				case 11:
					num2 = ⴅ[212] - 11;
					continue;
				}
				break;
			}
		}
	}
}
