using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcShared.ArcUtils;
using Ⴀ;

namespace ArcClientEngine.CmdProcessing.UserCmds;

public sealed class SetDxFilter : ႥႳ
{
	internal sealed class Ⴗ
	{
		internal Delegate Ⴓ;

		internal object[] Ⴀ;

		internal object Ⴅ;

		internal Ⴗ()
		{
		}
	}

	public UserCmd Process(UserCmd cmd)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		try
		{
			int num = 8;
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			IEnumerable<char> enumerable2 = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Split.Length != 3) ? (ⴄ[139] - 9627) : 9);
					continue;
				case 9:
					cmd.Ⴈ().Ⴃ(string.Empty);
					cmd.Ⴈ().ႳႷ(ႥႥ.Ⴅ(1673507744, null, 1));
					num = 1;
					continue;
				case 5:
					num = ((cmd.Split.Length < 3) ? 1 : 12);
					continue;
				case 12:
					enumerable = ShowDxFilter.Ⴗ(cmd.GetMsgEnd(3), 22, '(');
					enumerable = AnnFilters.ႰႥ((string)enumerable, cmd.Ⴈ().Ⴗ(), 'ř', 311);
					num = 3;
					continue;
				case 3:
					enumerable = FilterViewer.ႨႷ(enumerable as string, 272, 317);
					enumerable2 = TelnetServerCfg.Ⴗ((string)enumerable, SqlFilterType.Dx, 'ę', 315);
					num = ⴗ[60] - 41553;
					continue;
				case 7:
				case 10:
					num = ((!cmd.Ⴈ().Ⴃ().Caches.Dx.IsValidFilter((string)enumerable2)) ? ⴅ[115] : 2);
					continue;
				case 2:
					cmd.Ⴈ().Ⴃ((string)enumerable2);
					goto case 11;
				case 11:
					cmd.Ⴈ().ႳႷ(DxFilters.Ⴈ(ႥႥ.Ⴅ(1673508760, null, 7), ShowDxFilter.Ⴗ(enumerable2 as string, 548, 'Ș'), 67, 27));
					num = 1;
					continue;
				case 4:
					cmd.Ⴈ().ႳႷ(ClientCty.Ⴗ('@', 3, 307012029));
					cmd.Ⴈ().ႳႷ(ClientCty.Ⴗ('\u0084', 8, 307012090) + (enumerable as string));
					break;
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			cmd.Ⴈ().ႳႷ(ႥႥ.Ⴅ(1673507407, null, 1));
		}
		return 4 switch
		{
			_ => cmd, 
		};
	}

	[SecuritySafeCritical]
	static SetDxFilter()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static char Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, int P_3) where _0021_00210 : string
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char result = default(char);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[58] - ⴀႠ[58];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄ[179] - 31343;
					continue;
				case 9:
					break;
				case 0:
					num2 = (((P_3 ^ P_2) - 88) ^ num) switch
					{
						0 => 6, 
						_ => 5, 
					};
					continue;
				case 5:
					result = 'u';
					num2 = ⴀႠ[9] - 28060;
					continue;
				case 4:
				case 6:
					result = P_0[P_1];
					num2 = 7;
					continue;
				case 7:
				case 10:
				case 11:
				{
					num++;
					int num3 = 52;
					int num4 = 404;
					UserCmd.Ⴅ[335] = (byte)((UserCmd.Ⴅ[335] * P_2) & 0x16);
					num2 = ((808 > num4 - num3 * 2) ? 2 : (ⴄ[294] - 26150));
					continue;
				}
				case 8:
					num2 = 0;
					continue;
				case 2:
					return result;
				case 1:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴃ(Color P_0, short P_1, int P_2)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		IEquatable<string> equatable = default(IEquatable<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[21] - 63702;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 10:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 51) ^ num) switch
					{
						0 => 4, 
						_ => 3, 
					};
					continue;
				case 3:
					equatable = null;
					num2 = 2;
					continue;
				case 4:
					equatable = UtilsXml.SerializeColor(P_0);
					num2 = ⴗ[137] - 1368;
					continue;
				case 2:
					num++;
					num3 = P_1 * P_1;
					goto case 6;
				case 6:
					num3 = P_1 + num3;
					num2 = 8;
					continue;
				case 8:
					num2 = ((num3 % 2 != 0) ? 7 : 11);
					continue;
				case 1:
				case 11:
					return (string)equatable;
				case 0:
				case 5:
					num2 = ⴀႠ[70] - 49241;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataGridViewColumn Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, char P_3) where _0021_00210 : DataGridViewColumnCollection
	{
		char[] ⴄ = Bye.Ⴄ;
		DataGridViewBand dataGridViewBand = default(DataGridViewBand);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[171] - 40001;
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
					num2 = (((P_2 ^ P_3) - 57) ^ num) switch
					{
						0 => 1, 
						_ => 7, 
					};
					continue;
				case 7:
					dataGridViewBand = null;
					num2 = 4;
					continue;
				case 1:
					dataGridViewBand = P_0[P_1];
					num2 = 4;
					continue;
				case 4:
				case 9:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 != 0) ? 11 : 0);
					continue;
				case 11:
					num2 = 10;
					continue;
				case 0:
				case 3:
				case 5:
					return dataGridViewBand as DataGridViewColumn;
				case 2:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴄ<_0021_00210>(ref float P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႠ[34] - 62563;
					continue;
				case 1:
				case 3:
					break;
				case 5:
					num2 = (((P_3 ^ P_2) - 118) ^ num) switch
					{
						0 => 2, 
						_ => ⴄ[180] - 27689, 
					};
					continue;
				case 4:
				case 7:
					equatable = null;
					num2 = 8;
					continue;
				case 0:
				case 2:
					equatable = P_0.ToString(P_1);
					num2 = ⴀႠ[68] - 51739;
					continue;
				case 8:
				{
					num++;
					int num3 = 3006;
					int num4 = 111;
					num2 = ((1002 < num3 / 3 - num4) ? ⴅ[285] : 6);
					continue;
				}
				case 6:
					return equatable as string;
				case 9:
					num2 = ⴗ[52] - 21965;
					continue;
				}
				break;
			}
		}
	}
}
