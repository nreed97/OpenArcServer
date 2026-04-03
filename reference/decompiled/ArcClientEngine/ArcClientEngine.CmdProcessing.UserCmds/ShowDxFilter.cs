using System;
using System.Collections.Generic;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcShared;
using ArcShared.ArcUtils;
using Ⴀ;

namespace ArcClientEngine.CmdProcessing.UserCmds;

public sealed class ShowDxFilter : ႥႳ
{
	public UserCmd Process(UserCmd cmd)
	{
		while (true)
		{
			cmd.Ⴈ().ႳႷ(DxFilters.Ⴈ(ႥႥ.Ⴍ(8, 1580609315, 'O', null), Ⴗ(cmd.Ⴈ().Ⴅ(), 890, '\u0346'), 796, 836));
			while (true)
			{
				IL_006c:
				int num = 0;
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
					case 3:
					case 5:
						goto IL_006c;
					case 0:
						Bye.Ⴄ[255] = (char)((Bye.Ⴄ[255] | Bye.Ⴄ[68]) & 0x7B);
						return cmd;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static ShowDxFilter()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 2;
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
				case 2:
					num2 = (((P_1 ^ P_2) - 45) ^ num) switch
					{
						0 => ⴅ[345] - 243, 
						_ => ⴗ[128] - 43516, 
					};
					continue;
				case 7:
					obj = null;
					goto case 5;
				case 5:
					num2 = 8;
					continue;
				case 9:
					obj = P_0.Trim();
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = 368;
					num4 = 672;
					goto case 4;
				case 4:
				case 6:
					num2 = ((3360 > num4 - num3 * 5) ? 10 : 0);
					continue;
				case 0:
					num2 = 2;
					continue;
				case 10:
					return obj as string;
				case 3:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : string
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[311] - 234;
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
				case 6:
					num2 = (((P_1 ^ P_2) - 58) ^ num) switch
					{
						0 => 14, 
						1 => 2, 
						2 => ⴗ[152] - 32153, 
						3 => 10, 
						4 => 3, 
						_ => 9, 
					};
					continue;
				case 9:
					enumerable = null;
					num2 = ⴅ[36] - 51;
					continue;
				case 14:
					enumerable = CtyInfo.ScrubTimeOffset(P_0);
					goto case 15;
				case 15:
					num2 = 0;
					continue;
				case 2:
					enumerable = UtilsCallsign.CallsignNormalization(P_0);
					num2 = ⴀႠ[106] - ⴀႠ[106];
					continue;
				case 7:
				case 13:
					enumerable = UtilsSql.UnFormatSqlFilter(P_0);
					num2 = ⴀႠ[113] - ⴀႠ[113];
					continue;
				case 10:
					enumerable = UtilsCallsign.GetNoSsidCall(P_0);
					goto case 8;
				case 8:
					num2 = ⴀႠ[68] - 51747;
					continue;
				case 3:
					enumerable = UtilsSql.ScrubSql(P_0);
					num2 = 0;
					continue;
				case 0:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴄ[269] - 37544) : (ⴅ[290] - 226));
					continue;
				case 12:
					num2 = 6;
					continue;
				case 5:
					return enumerable as string;
				case 4:
					num2 = ⴅ[267] - ⴅ[9];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : DataGridViewColumn where _0021_00211 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 5;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 10;
				break;
			case 6:
			case 10:
				num = (((P_3 ^ P_2) - 42) ^ num3) switch
				{
					0 => 8, 
					1 => ⴀႠ[113] - 43462, 
					_ => ⴀႠ[33] - 39863, 
				};
				break;
			case 7:
				num = 0;
				break;
			case 8:
				P_0.HeaderText = P_1;
				num = ⴅ[17];
				break;
			case 1:
			case 4:
				P_0.ToolTipText = P_1;
				goto case 0;
			case 0:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				goto case 3;
			case 3:
				num = 9;
				break;
			case 9:
				num = ((num2 % 2 != 0) ? 10 : (ⴗ[93] - 63517));
				break;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ(object[] P_0, short P_1, short P_2)
	{
		char[] ⴄ = Bye.Ⴄ;
		IComparable comparable = default(IComparable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 10;
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
				case 10:
					num2 = (((P_1 ^ P_2) - 69) ^ num) switch
					{
						0 => 9, 
						_ => 1, 
					};
					continue;
				case 1:
					comparable = null;
					num2 = 0;
					continue;
				case 7:
				case 8:
				case 9:
					comparable = string.Concat(P_0);
					num2 = ⴄ[50] - 52019;
					continue;
				case 0:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					goto case 11;
				case 11:
					num2 = 3;
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? 10 : 2);
					continue;
				case 2:
					return (string)comparable;
				case 6:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}
}
