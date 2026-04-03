using System;
using System.Collections.Generic;
using System.Security;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class UtilsMacros
{
	private static readonly ILog Ⴀ;

	public static string ExpandDxFilterMacros(string sql, string loginCall)
	{
		while (true)
		{
			sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 2, 192631774), loginCall, 286, 380);
			while (true)
			{
				IL_004b:
				int num = 5;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 0;
						continue;
					case 0:
						break;
					case 3:
					case 4:
						goto IL_004b;
					case 5:
						sql = ExpandDxFilterMacros(sql);
						goto case 1;
					case 1:
						return sql;
					}
					break;
				}
				break;
			}
		}
	}

	public static string ExpandDxFilterMacros(string sql)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		while (true)
		{
			sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506930, 0, 6), ႣႼ.ႥႭ(null, 624736255, 5, null), 31, 125);
			int num = ⴃႭ[229] - 32487;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 8;
					continue;
				case 8:
					break;
				case 3:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506940, 8, 2), UtilsString.Ⴐ(null, 0, 192631789), 650, 744);
					goto case 10;
				case 10:
					num = ⴃႤ[371] - 32791;
					continue;
				case 0:
				case 6:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506945, 18, 2), UtilsString.Ⴐ(null, 6, 192631691), 989, 959);
					goto case 9;
				case 9:
					num = 11;
					continue;
				case 11:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506964, 22, 3), UtilsString.Ⴐ(null, 6, 192631700), 1014, 916);
					num = 7;
					continue;
				case 7:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506977, 28, 5), UtilsString.Ⴐ(null, 2, 192630852), 875, 777);
					num = 5;
					continue;
				case 5:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506986, 15, 2), UtilsString.Ⴐ(null, 4, 192630911), 690, 720);
					num = 1;
					continue;
				case 1:
					sql = sql.Replace(ArcLogInRqstExt.Ⴗ(1706506758, 12, 3), UtilsString.Ⴐ(null, 5, 192631115));
					num = 4;
					continue;
				case 4:
					return sql;
				}
				break;
			}
		}
	}

	public static string ExpandRepeatableFilterMacros(string sql)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		while (true)
		{
			sql = DxAtlasData.Ⴄ((object)' ', (object)sql, (object)' ', 482, 'ƍ');
			int num = ⴐ[464] - 29628;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႭ[118] - 33303;
					continue;
				case 8:
					break;
				case 0:
				case 5:
					sql = Ⴈ(sql);
					goto case 4;
				case 4:
					num = 3;
					continue;
				case 6:
					sql = Ⴅ(sql);
					num = ⴃႤ[557] - 53631;
					continue;
				case 1:
				case 3:
					num = (AutoUpdater.ႨႰ(sql, UtilsString.Ⴐ(null, 8, 192631189), 685, '\u02c5') ? (ⴃႣ[215] - 32474) : 2);
					continue;
				case 2:
					return sql.Trim();
				}
				break;
			}
		}
	}

	private static string Ⴅ(string P_0)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			IConvertible convertible = string.Empty;
			ICloneable cloneable = string.Empty;
			IEnumerable<char> empty = string.Empty;
			int num = ColumnFilterEventArgs.Ⴍ(P_0, UtilsString.Ⴐ(null, 8, 192631189), 551, 546);
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[127] - 49522;
					continue;
				case 4:
					break;
				case 0:
					num2 = ((num <= 0) ? 9 : 17);
					continue;
				case 17:
					num3 = num;
					num2 = 8;
					continue;
				case 7:
				case 14:
					num2 = ((AnnWxSpotExt.Ⴅ(P_0, num3, 532, 559) != ']') ? (ⴐ[538] - 53413) : (ⴃႭ[64] - 60312));
					continue;
				case 12:
					num2 = 15;
					continue;
				case 10:
					num--;
					num2 = 15;
					continue;
				case 15:
					num2 = ((num <= 0) ? 5 : (ⴀ[218] - 52342));
					continue;
				case 11:
					num2 = ((AnnWxSpotExt.Ⴅ(P_0, num - 1, 516, 575) != ' ') ? 1 : 5);
					continue;
				case 1:
					num2 = ((AnnWxSpotExt.Ⴅ(P_0, num - 1, 261, 318) != '(') ? 10 : (ⴐ[3] - 58494));
					continue;
				case 5:
					num4 = num3;
					goto case 3;
				case 3:
					convertible = UtilsLatLon.Ⴜ(P_0, 0, num, 897, 929);
					num2 = ⴀ[347] - 16100;
					continue;
				case 13:
					cloneable = UtilsLatLon.Ⴜ(P_0, num, num4 - num, 422, 390);
					num2 = 2;
					continue;
				case 2:
					empty = AutoUpdater.ႨႣ(P_0, num4 + 1, 215, 144);
					P_0 = (string)convertible + Ⴐ((string)cloneable) + (empty as string);
					num2 = 9;
					continue;
				case 16:
				case 18:
					num3++;
					num2 = ⴐ[289] - 14556;
					continue;
				case 8:
					num2 = ((num3 < P_0.Length) ? 14 : 9);
					continue;
				case 9:
					return P_0;
				}
				break;
			}
		}
	}

	private static string Ⴐ(string P_0)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num2 = default(int);
		object obj2 = default(object);
		while (true)
		{
			IConvertible convertible = string.Empty;
			object obj = ႰႨ.ႨႥ(P_0, new char[3] { '=', '[', ',' }, 762, 667);
			while (true)
			{
				IL_009b:
				int num = 13;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 0;
						continue;
					case 0:
						break;
					case 1:
						goto IL_009b;
					case 13:
						num = (((obj as string[]).Length <= 2) ? (ⴐ[135] - 62688) : 5);
						continue;
					case 5:
						num2 = 0;
						num = 6;
						continue;
					case 7:
						num = ((UtilsCallsign.Ⴓ(convertible as string, 684, 667) <= 0) ? 2 : 9);
						continue;
					case 9:
						convertible = ReverseBeaconClient.Ⴗ(convertible as string, ႣႼ.Ⴜ(1, 365387060, 28), 'Ɵ', 'Ǘ');
						num = 2;
						continue;
					case 2:
					{
						object obj3 = (string)convertible;
						obj2 = new object[4];
						((object[])obj2)[0] = obj3;
						num = 4;
						continue;
					}
					case 4:
						((object[])obj2)[1] = ((string[])obj)[0];
						(obj2 as object[])[2] = '=';
						goto case 3;
					case 3:
						num = ⴃႣ[6] - 35261;
						continue;
					case 8:
					case 11:
						((object[])obj2)[3] = (obj as string[])[num2 + 2];
						num = ⴃႤ[500] - 25118;
						continue;
					case 14:
						convertible = ႰႨ.ႨႷ((object[])obj2, 'ψ', 998);
						num2++;
						num = ⴀ[130] - 52331;
						continue;
					case 6:
						num = ((num2 < ((string[])obj).Length - 2) ? 7 : (ⴗ[27] - 85));
						continue;
					case 10:
						convertible = (convertible as string).Trim();
						return ArcLogInRqstExt.Ⴗ(1706506777, 20, 8) + (string)convertible + ')';
					}
					break;
				}
				break;
			}
		}
	}

	private static string Ⴈ(string P_0)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		while (true)
		{
			P_0 = DgvFilterManager.ႭႭ(P_0, ႣႼ.Ⴜ(8, 365386946, 16), UtilsString.Ⴐ(null, 1, 192631196), 721, 691);
			int num = 16;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴗ[150] - 53138;
					continue;
				case 11:
					break;
				case 16:
					P_0 = DgvFilterManager.ႭႭ(P_0, ႣႼ.Ⴜ(1, 365386948, 15), UtilsString.Ⴐ(null, 0, 192631197), 513, 611);
					num = ⴃႣ[151] - 9084;
					continue;
				case 3:
					P_0 = DgvFilterManager.ႭႭ(P_0, ႣႼ.Ⴜ(7, 365386970, 15), UtilsString.Ⴐ(null, 5, 192631192), 414, 508);
					goto case 8;
				case 8:
					num = 15;
					continue;
				case 15:
					P_0 = DgvFilterManager.ႭႭ(P_0, ႣႼ.Ⴜ(2, 365386960, 21), UtilsString.Ⴐ(null, 4, 192631193), 863, 829);
					num = 7;
					continue;
				case 7:
					P_0 = DgvFilterManager.ႭႭ(P_0, ႣႼ.Ⴜ(7, 365386991, 31), UtilsString.Ⴐ(null, 5, 192631192), 954, 984);
					num = 4;
					continue;
				case 4:
					P_0 = DgvFilterManager.ႭႭ(P_0, ႣႼ.Ⴜ(0, 365386979, 16), UtilsString.Ⴐ(null, 0, 192631197), 698, 728);
					num = ⴗ[28] - ⴗ[28];
					continue;
				case 0:
					P_0 = DgvFilterManager.ႭႭ(P_0, ႣႼ.Ⴜ(1, 365387002, 31), UtilsString.Ⴐ(null, 6, 192631195), 453, 423);
					num = 14;
					continue;
				case 14:
					P_0 = DgvFilterManager.ႭႭ(P_0, ႣႼ.Ⴜ(1, 365386993, 26), UtilsString.Ⴐ(null, 6, 192631195), 313, 347);
					goto case 13;
				case 13:
					num = ⴃႤ[531] - 14158;
					continue;
				case 6:
					P_0 = DgvFilterManager.ႭႭ(P_0, ႣႼ.Ⴜ(3, 365386997, 30), UtilsString.Ⴐ(null, 7, 192631194), 95, 61);
					num = 2;
					continue;
				case 1:
				case 2:
					P_0 = DgvFilterManager.ႭႭ(P_0, ႣႼ.Ⴜ(1, 365386880, 1), UtilsString.Ⴐ(null, 6, 192631195), 158, 252);
					num = ⴃႭ[154] - 9360;
					continue;
				case 5:
					P_0 = P_0.Replace(ႣႼ.Ⴜ(6, 365386911, 12), UtilsString.Ⴐ(null, 3, 192631198));
					num = 9;
					continue;
				case 9:
					P_0 = P_0.Replace(ႣႼ.Ⴜ(3, 365386909, 9), UtilsString.Ⴐ(null, 0, 192631197));
					num = 12;
					continue;
				case 12:
					return P_0;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static UtilsMacros()
	{
		UtilsIdentity.Ⴐ();
		Ⴀ = ArcLogInRqstExt.Ⴍ(ႣႼ.Ⴜ(4, 365386896, 6), 321, 286);
	}
}
