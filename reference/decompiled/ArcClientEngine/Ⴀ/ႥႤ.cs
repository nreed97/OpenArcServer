using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Io;
using ArcShared.DgvUtils.DgvFilter;

namespace Ⴀ;

internal sealed class ႥႤ
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴐ
	{
		internal bool Ⴈ;

		internal bool Ⴗ;

		internal bool Ⴄ;

		internal bool Ⴀ;

		internal bool Ⴓ;

		internal bool Ⴐ;
	}

	internal sealed class Ⴄ
	{
		internal ArcClientObjMgr Ⴐ;

		internal DgvFilterManager Ⴄ;

		internal IContainer Ⴈ;

		internal Ⴄ()
		{
		}
	}

	internal sealed class Ⴃ
	{
		internal string Ⴀ;

		internal int Ⴓ;

		internal string Ⴃ;

		internal bool Ⴍ;

		internal bool Ⴅ;

		internal long Ⴗ;

		internal string Ⴈ;

		internal Ⴃ()
		{
		}
	}

	internal sealed class Ⴓ
	{
		internal float Ⴗ;

		internal string Ⴓ;

		internal string Ⴃ;

		internal Ⴓ()
		{
		}
	}

	internal static string Ⴗ(FilterType P_0, string P_1)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		while (true)
		{
			while (true)
			{
				IL_0055:
				int num = P_0 switch
				{
					FilterType.DX => 4, 
					FilterType.Ann => 5, 
					FilterType.WX => 9, 
					_ => ⴄ[158] - 30784, 
				};
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴄ[278] - 56974;
						continue;
					case 3:
						break;
					case 7:
						goto IL_0055;
					case 2:
						num = 6;
						continue;
					case 4:
						P_1 = HighlightArrlSectionCfg.Ⴀ(P_1, WxFilters.Ⴀ(null, 3, 103388508), ႥႥ.Ⴍ(3, 1580608961, ' ', P_1), '\u0362', 873);
						num = 6;
						continue;
					case 1:
					case 5:
						P_1 = HighlightArrlSectionCfg.Ⴀ(P_1, WxFilters.Ⴀ(null, 8, 103388503), ClientCty.Ⴗ('R', 0, 307011799), 'ń', 335);
						num = ⴄ[175] - 59447;
						continue;
					case 0:
					case 9:
						P_1 = P_1.Replace(WxFilters.Ⴀ(null, 1, 103388510), ClientCty.Ⴗ('Z', 1, 307012945));
						num = ⴀႠ[125] - 26169;
						continue;
					case 6:
						return P_1;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static ႥႤ()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static bool Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[145] - 59479;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 4;
					continue;
				case 4:
					break;
				case 6:
					num2 = (((P_2 ^ P_3) - 58) ^ num) switch
					{
						0 => ⴗ[152] - 32157, 
						1 => ⴀႠ[20] - 33400, 
						_ => 12, 
					};
					continue;
				case 12:
					result = false;
					num2 = 11;
					continue;
				case 9:
					result = P_0.StartsWith(P_1);
					num2 = 11;
					continue;
				case 0:
				case 3:
					result = P_0 != P_1;
					num2 = 11;
					continue;
				case 11:
				{
					num++;
					int num3 = 310;
					int num4 = 383;
					num2 = ((1149 > num4 - num3 * 3) ? (ⴄ[201] - 44573) : (ⴗ[60] - 41556));
					continue;
				}
				case 5:
				case 7:
					num2 = 6;
					continue;
				case 2:
					return result;
				case 10:
					num2 = ⴀႠ[44] - 48722;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : Control where _0021_00211 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 7;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 8;
				break;
			case 8:
				num = (((P_2 ^ P_3) - 109) ^ num3) switch
				{
					0 => 5, 
					_ => 0, 
				};
				break;
			case 0:
				num = 1;
				break;
			case 3:
			case 5:
				P_0.Name = P_1;
				goto case 1;
			case 1:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				goto case 4;
			case 4:
				num = 9;
				break;
			case 9:
				num = ((num2 % 2 != 0) ? (ⴗ[62] - 59544) : (ⴗ[111] - 41311));
				break;
			case 2:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataRow[] Ⴈ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : DataTable where _0021_00211 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[93] - 63514;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
					break;
				case 5:
					num2 = (((P_2 ^ P_3) - 109) ^ num) switch
					{
						0 => 11, 
						_ => ⴅ[346] - 233, 
					};
					continue;
				case 9:
					obj = null;
					num2 = ⴅ[102];
					continue;
				case 6:
				case 11:
					obj = P_0.Select(P_1);
					num2 = 10;
					continue;
				case 10:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴅ[4] / 4;
					continue;
				case 2:
				case 8:
					num2 = ((num3 % 2 != 0) ? (ⴄ[37] - 39518) : 4);
					continue;
				case 4:
				case 7:
					return (DataRow[])obj;
				case 1:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : UserCmdCfg
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[240] - 208;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[285];
					continue;
				case 5:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 55) ^ num) switch
					{
						0 => 6, 
						1 => 9, 
						_ => ⴄ[187] - 15462, 
					};
					continue;
				case 8:
					obj = null;
					num2 = 12;
					continue;
				case 6:
					obj = P_0.ClassName;
					num2 = 12;
					continue;
				case 9:
					obj = P_0.Definition;
					num2 = ⴀႠ[86] - 44440;
					continue;
				case 3:
				case 12:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 11 : 2);
					continue;
				case 2:
					num2 = ⴀႠ[78] - 14989;
					continue;
				case 11:
					return (string)obj;
				case 0:
				case 4:
				case 7:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly Ⴜ(byte[] P_0, byte[] P_1, SecurityContextSource P_2, char P_3, char P_4)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		IEvidenceFactory evidenceFactory = default(IEvidenceFactory);
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 1;
					continue;
				case 1:
					break;
				case 3:
					num2 = (((P_3 ^ P_4) - 43) ^ num) switch
					{
						0 => ⴄ[34] - 61625, 
						_ => 4, 
					};
					continue;
				case 4:
					evidenceFactory = null;
					num2 = ⴀႠ[90] - 47364;
					continue;
				case 8:
					evidenceFactory = Assembly.Load(P_0, P_1, P_2);
					num2 = 7;
					continue;
				case 7:
					num++;
					goto case 10;
				case 10:
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? 5 : 11);
					continue;
				case 11:
					num2 = 3;
					continue;
				case 5:
					return (Assembly)evidenceFactory;
				case 0:
				case 9:
					num2 = ⴄ[258] - 52755;
					continue;
				}
				break;
			}
		}
	}
}
