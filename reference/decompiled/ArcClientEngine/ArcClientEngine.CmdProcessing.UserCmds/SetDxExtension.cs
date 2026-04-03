using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using WeifenLuo.WinFormsUI.Docking;
using Ⴀ;

namespace ArcClientEngine.CmdProcessing.UserCmds;

public sealed class SetDxExtension : ႥႳ
{
	public void OnError(UserCmd cmd)
	{
		cmd.Ⴈ().ႳႷ(ႥႥ.Ⴍ(0, 1580608560, '\u008d', null));
		HighlightCtyCfg.ႠႠ[73] = (char)((HighlightCtyCfg.ႠႠ[73] - HighlightCtyCfg.ႠႠ[84]) & 0xAC);
	}

	public UserCmd Process(UserCmd cmd)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		try
		{
			int num = 12;
			int num2 = default(int);
			IEquatable<string> equatable = default(IEquatable<string>);
			IComparable<string> comparable = default(IComparable<string>);
			int value = default(int);
			ICloneable cloneable = default(ICloneable);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Split.Length <= 2) ? 28 : (ⴀႠ[97] - 34992));
					continue;
				case 10:
					Ⴐ(cmd);
					goto case 13;
				case 13:
					num2 = 3;
					num = ⴄ[92] - 14783;
					continue;
				case 15:
					equatable = ShowDxFilter.Ⴍ(FilterViewer.ႨႷ(cmd.Split[num2], 526, 549), '\u02f8', 725);
					num = 5;
					continue;
				case 5:
					num = (((comparable = equatable as string) == null) ? (ⴄ[207] - 177) : 22);
					continue;
				case 22:
					num = ((ႳႰ.Ⴅ != null) ? (ⴅ[96] - 186) : 33);
					continue;
				case 33:
					ႳႰ.Ⴅ = new Dictionary<string, int>(16)
					{
						{
							WxFilters.Ⴀ(null, 0, 103387186),
							0
						},
						{
							WxFilters.Ⴀ(null, 7, 103387186),
							1
						},
						{
							WxFilters.Ⴀ(null, 8, 103387191),
							2
						},
						{
							WxFilters.Ⴀ(null, 1, 103387174),
							3
						},
						{
							WxFilters.Ⴀ(null, 1, 103387176),
							4
						},
						{
							WxFilters.Ⴀ(null, 3, 103387348),
							5
						},
						{
							WxFilters.Ⴀ(null, 7, 103387355),
							6
						},
						{
							WxFilters.Ⴀ(null, 1, 103387334),
							7
						},
						{
							WxFilters.Ⴀ(null, 5, 103387337),
							8
						},
						{
							WxFilters.Ⴀ(null, 4, 103387390),
							9
						},
						{
							ClientCty.Ⴗ('\u0087', 5, 307013602),
							10
						},
						{
							ႥႥ.Ⴅ(1673508611, null, 0),
							11
						},
						{
							ႥႥ.Ⴍ(5, 1580608704, '\u0087', null),
							12
						},
						{
							WxFilters.Ⴀ(null, 5, 103387384),
							13
						},
						{
							ClientCty.Ⴗ('°', 8, 307012626),
							14
						},
						{
							ႥႥ.Ⴅ(1673508630, null, 4),
							15
						}
					};
					num = ⴀႠ[85] - 36629;
					continue;
				case 20:
					num = ((!ႳႰ.Ⴅ.TryGetValue(comparable as string, out value)) ? (ⴄ[34] - 61629) : ⴅ[71]);
					continue;
				case 25:
					num = value switch
					{
						0 => ⴄ[92] - 14789, 
						1 => ⴄ[187] - 15449, 
						2 => 14, 
						3 => ⴅ[281] - 87, 
						4 => 19, 
						5 => 7, 
						6 => 1, 
						7 => 2, 
						8 => 24, 
						9 => 0, 
						10 => ⴅ[15] - 118, 
						11 => 9, 
						12 => ⴅ[176] + ⴅ[25], 
						13 => ⴀႠ[4] - 3434, 
						14 => 31, 
						15 => 8, 
						_ => ⴄ[290] - 49135, 
					};
					continue;
				case 16:
					num = 4;
					continue;
				case 26:
					cmd.Ⴈ().Ⴄ().Lotw = true;
					num = ⴄ[244] - 46902;
					continue;
				case 21:
					cmd.Ⴈ().Ⴄ().Cty = true;
					num = 4;
					continue;
				case 14:
					cmd.Ⴈ().Ⴄ().State = true;
					num = 4;
					continue;
				case 11:
					cmd.Ⴈ().Ⴄ().Loc = true;
					num = 4;
					continue;
				case 19:
					cmd.Ⴈ().Ⴄ().Section = true;
					num = 4;
					continue;
				case 7:
					cmd.Ⴈ().Ⴄ().County = true;
					num = ⴅ[115];
					continue;
				case 1:
					cmd.Ⴈ().Ⴄ().Grid = true;
					num = 4;
					continue;
				case 2:
					cmd.Ⴈ().Ⴄ().CqZone = true;
					num = 4;
					continue;
				case 24:
					cmd.Ⴈ().Ⴄ().ItuZone = true;
					num = 4;
					continue;
				case 0:
					cmd.Ⴈ().Ⴄ().Name = true;
					num = 4;
					continue;
				case 6:
				case 23:
					cmd.Ⴈ().Ⴄ().SpotterCty = true;
					num = 4;
					continue;
				case 9:
					cmd.Ⴈ().Ⴄ().SpotterState = true;
					num = ⴗ[154] - 7301;
					continue;
				case 17:
					cmd.Ⴈ().Ⴄ().SpotterLoc = true;
					num = ⴀႠ[61] - 26817;
					continue;
				case 18:
					cmd.Ⴈ().Ⴄ().SpotterCont = true;
					num = ⴀႠ[70] - 49244;
					continue;
				case 31:
					cmd.Ⴈ().Ⴄ().SkimmerQuality = true;
					num = 4;
					continue;
				case 8:
					cmd.Ⴈ().Ⴄ().Eos = true;
					goto case 4;
				case 4:
					num2++;
					num = ⴗ[52] - 21938;
					continue;
				case 32:
					num = ((num2 < cmd.Split.Length) ? 15 : (ⴄ[284] - 37899));
					continue;
				case 3:
					cloneable = Ⴄ(cmd);
					goto case 30;
				case 30:
					cmd.Ⴈ().ႳႷ((string)cloneable);
					num = 29;
					continue;
				case 28:
					OnError(cmd);
					break;
				case 29:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			OnError(cmd);
		}
		return 3 switch
		{
			_ => cmd, 
		};
	}

	private static void Ⴐ(UserCmd P_0)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 9;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Ⴈ().Ⴄ().Lotw = false;
				P_0.Ⴈ().Ⴄ().Cty = false;
				num = 6;
				break;
			case 6:
				P_0.Ⴈ().Ⴄ().State = false;
				P_0.Ⴈ().Ⴄ().Loc = false;
				num = ⴅ[25];
				break;
			case 2:
			case 7:
				P_0.Ⴈ().Ⴄ().Section = false;
				P_0.Ⴈ().Ⴄ().County = false;
				num = 8;
				break;
			case 8:
				P_0.Ⴈ().Ⴄ().CqZone = false;
				goto case 1;
			case 1:
				P_0.Ⴈ().Ⴄ().ItuZone = false;
				num = ⴀႠ[127] - 368;
				break;
			case 3:
				P_0.Ⴈ().Ⴄ().Grid = false;
				P_0.Ⴈ().Ⴄ().Name = false;
				num = 5;
				break;
			case 5:
				P_0.Ⴈ().Ⴄ().SpotterCty = false;
				P_0.Ⴈ().Ⴄ().SpotterState = false;
				num = ⴅ[17];
				break;
			case 0:
				P_0.Ⴈ().Ⴄ().SpotterLoc = false;
				P_0.Ⴈ().Ⴄ().SpotterCont = false;
				num = 4;
				break;
			case 4:
				P_0.Ⴈ().Ⴄ().SkimmerQuality = false;
				P_0.Ⴈ().Ⴄ().Eos = false;
				return;
			}
		}
	}

	private static string Ⴄ(UserCmd P_0)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		while (true)
		{
			IEquatable<string> equatable = string.Empty;
			int num = ((!P_0.Ⴈ().Ⴄ().Lotw) ? (ⴗ[137] - 1340) : (ⴅ[298] - 198));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴗ[147] - 45873;
					continue;
				case 7:
					break;
				case 19:
					equatable = DxFilters.Ⴈ(equatable as string, ClientCty.Ⴗ('À', 8, 307012609), 144, 200);
					num = ⴗ[103] - 55661;
					continue;
				case 30:
					num = ((!P_0.Ⴈ().Ⴄ().Cty) ? 23 : 8);
					continue;
				case 8:
					equatable = DxFilters.Ⴈ((string)equatable, ႥႥ.Ⴍ(6, 1580608752, '?', null), 321, 281);
					num = ⴀႠ[125] - 26152;
					continue;
				case 23:
					num = ((!P_0.Ⴈ().Ⴄ().State) ? 11 : 20);
					continue;
				case 20:
					equatable = DxFilters.Ⴈ(equatable as string, ClientCty.Ⴗ('U', 4, 307012613), 592, 520);
					num = 11;
					continue;
				case 11:
					num = ((!P_0.Ⴈ().Ⴄ().Loc) ? (ⴅ[225] / 9) : (ⴄ[156] - 11622));
					continue;
				case 32:
					equatable = DxFilters.Ⴈ((string)equatable, ႥႥ.Ⴍ(8, 1580608761, 'Ì', null), 108, 52);
					num = 17;
					continue;
				case 17:
					num = ((!P_0.Ⴈ().Ⴄ().Section) ? (ⴀႠ[115] - ⴀႠ[115]) : 21);
					continue;
				case 21:
					equatable = DxFilters.Ⴈ((string)equatable, ClientCty.Ⴗ('ä', 7, 307012671), 909, 981);
					num = ⴀႠ[68] - 51747;
					continue;
				case 0:
					num = ((!P_0.Ⴈ().Ⴄ().County) ? 36 : (ⴗ[72] - 15833));
					continue;
				case 16:
					equatable = DxFilters.Ⴈ(equatable as string, ႥႥ.Ⴍ(0, 1580608760, 'Ï', null), 612, 572);
					num = ⴄ[169] - 10903;
					continue;
				case 36:
					num = ((!P_0.Ⴈ().Ⴄ().Grid) ? (ⴄ[62] - 13489) : (ⴄ[290] - 49148));
					continue;
				case 3:
				case 12:
					equatable = DxFilters.Ⴈ((string)equatable, ClientCty.Ⴗ('6', 3, 307012654), 390, 478);
					num = ⴅ[8];
					continue;
				case 38:
					num = ((!P_0.Ⴈ().Ⴄ().CqZone) ? 6 : 31);
					continue;
				case 31:
					equatable = DxFilters.Ⴈ(equatable as string, ႥႥ.Ⴍ(4, 1580608746, '\u008a', null), 713, 657);
					num = ⴄ[186] - 26700;
					continue;
				case 6:
				case 14:
					num = ((!P_0.Ⴈ().Ⴄ().ItuZone) ? 4 : 33);
					continue;
				case 33:
					equatable = DxFilters.Ⴈ(equatable as string, ClientCty.Ⴗ('\a', 5, 307012640), 962, 922);
					num = 4;
					continue;
				case 4:
					num = ((!P_0.Ⴈ().Ⴄ().Name) ? (ⴀႠ[20] - 33399) : 9);
					continue;
				case 9:
					equatable = DxFilters.Ⴈ((string)equatable, ႥႥ.Ⴍ(5, 1580608657, 'ý', null), 557, 629);
					num = 1;
					continue;
				case 1:
					num = ((!P_0.Ⴈ().Ⴄ().SpotterCty) ? 2 : 22);
					continue;
				case 22:
					equatable = DxFilters.Ⴈ((string)equatable, ClientCty.Ⴗ('i', 5, 307012703), 458, 402);
					num = ⴅ[25];
					continue;
				case 2:
					num = ((!P_0.Ⴈ().Ⴄ().SpotterState) ? (ⴗ[137] - 1352) : 26);
					continue;
				case 26:
					equatable = DxFilters.Ⴈ((string)equatable, ႥႥ.Ⴍ(2, 1580608670, 'Ã', null), 1, 89);
					num = 18;
					continue;
				case 18:
					num = ((!P_0.Ⴈ().Ⴄ().SpotterLoc) ? 5 : 27);
					continue;
				case 27:
					equatable = DxFilters.Ⴈ(equatable as string, ClientCty.Ⴗ('Ó', 7, 307012683), 466, 394);
					num = ⴄ[47] - 24196;
					continue;
				case 5:
					num = ((!P_0.Ⴈ().Ⴄ().SpotterCont) ? (ⴀႠ[101] - 46650) : 13);
					continue;
				case 13:
					equatable = DxFilters.Ⴈ(equatable as string, ႥႥ.Ⴍ(1, 1580608653, 'R', null), 674, 762);
					num = 25;
					continue;
				case 25:
					num = ((!P_0.Ⴈ().Ⴄ().SkimmerQuality) ? (ⴄ[239] - 49125) : 15);
					continue;
				case 15:
					equatable = (equatable as string) + ClientCty.Ⴗ('÷', 0, 307012734);
					num = ⴅ[102];
					continue;
				case 10:
					num = ((!P_0.Ⴈ().Ⴄ().Eos) ? 28 : 24);
					continue;
				case 24:
					equatable = (equatable as string) + ႥႥ.Ⴍ(5, 1580608698, 'ó', null);
					num = 28;
					continue;
				case 28:
					num = (((equatable as string).Length != 0) ? 35 : 37);
					continue;
				case 34:
				case 37:
					equatable = ႥႥ.Ⴅ(1673508650, null, 2);
					num = 35;
					continue;
				case 35:
				{
					string result = WxFilters.Ⴀ(null, 7, 103387368) + (equatable as string);
					Bye.Ⴄ[104] = (char)((Bye.Ⴄ[104] ^ Bye.Ⴄ[128]) & 0x23);
					return result;
				}
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static SetDxExtension()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static int Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int result = default(int);
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
					num2 = ⴀႠ[10] - 7243;
					continue;
				case 3:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 117) ^ num) switch
					{
						0 => 10, 
						_ => 9, 
					};
					continue;
				case 9:
					result = P_1;
					num2 = 11;
					continue;
				case 10:
					result = Convert.ToInt32(P_0);
					num2 = 11;
					continue;
				case 11:
					num++;
					goto case 8;
				case 8:
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 7;
				case 7:
					num2 = 0;
					continue;
				case 0:
				case 4:
					num2 = ((num3 % 2 != 0) ? (ⴅ[240] - 208) : 5);
					continue;
				case 5:
					return result;
				case 2:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ImageList.ImageCollection Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : ImageList
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		ICollection collection = default(ICollection);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[0] - 49948;
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
				case 9:
					num2 = (((P_2 ^ P_1) - 113) ^ num) switch
					{
						0 => 10, 
						_ => ⴅ[17], 
					};
					continue;
				case 0:
					collection = null;
					num2 = 11;
					continue;
				case 5:
				case 10:
					collection = P_0.Images;
					num2 = 11;
					continue;
				case 11:
				{
					num++;
					num4 = 1114;
					int num5 = num4;
					num3 = num5 * num5;
					num2 = ⴗ[59] - 33048;
					continue;
				}
				case 7:
					num3 = num4 + num3;
					num2 = ((num3 % 2 != 0) ? 9 : 6);
					continue;
				case 6:
				case 8:
					return (ImageList.ImageCollection)collection;
				case 1:
				case 2:
					num2 = ⴗ[38] - 31031;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, char P_3) where _0021_00210 : DockContent where _0021_00211 : string
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄ[210] - 42791;
				break;
			case 1:
			{
				int num3 = (P_3 ^ P_2) - 125;
				int num4 = num2;
				ႥႰ.Ⴗ[91] = (char)((ႥႰ.Ⴗ[91] * P_2) & 0x65);
				num = (num3 ^ num4) switch
				{
					0 => 6, 
					_ => 5, 
				};
				break;
			}
			case 5:
				num = 4;
				break;
			case 6:
				P_0.ToolTipText = P_1;
				goto case 2;
			case 2:
			case 4:
				num2++;
				goto case 0;
			case 0:
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴄ[155] - 45030) : (ⴀႠ[87] - 21212));
				break;
			case 8:
				num = 1;
				break;
			case 3:
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		bool result = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 9;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 9) ^ num) switch
					{
						0 => 7, 
						_ => 3, 
					};
					continue;
				case 3:
					result = false;
					num2 = ⴗ[152] - 32161;
					continue;
				case 7:
					result = string.IsNullOrEmpty(P_0);
					num2 = ⴀႠ[115] - 48712;
					continue;
				case 5:
					num++;
					goto case 8;
				case 8:
					num3 = 437;
					num4 = 518;
					goto case 4;
				case 4:
				case 6:
					num2 = ((2590 > num4 - num3 * 5) ? 1 : (ⴀႠ[84] - 18792));
					continue;
				case 10:
					num2 = 9;
					continue;
				case 1:
					return result;
				case 11:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}
}
