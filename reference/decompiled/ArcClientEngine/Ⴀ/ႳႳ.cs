using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;

namespace Ⴀ;

internal sealed class ႳႳ
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴜ
	{
		internal DataSet Ⴐ;

		internal int Ⴄ;
	}

	internal sealed class ႤႰ
	{
		internal Dictionary<string, DxccCacheData> Ⴄ;

		internal ႤႰ()
		{
		}
	}

	private SetDxFilter.Ⴗ m_Ⴈ = new SetDxFilter.Ⴗ();

	[SpecialName]
	public object Ⴃ()
	{
		object ⴅ = this.m_Ⴈ.Ⴅ;
		UserCmd.Ⴅ[222] = (byte)((UserCmd.Ⴅ[222] + UserCmd.Ⴅ[361]) & 0xCF);
		return ⴅ;
	}

	[SpecialName]
	private void Ⴈ(object P_0)
	{
		this.m_Ⴈ.Ⴅ = P_0;
		ႥႰ.Ⴗ[29] = (char)((ႥႰ.Ⴗ[29] + ႥႰ.Ⴗ[99]) & 2);
	}

	public ႳႳ(Delegate P_0, object[] P_1)
	{
		this.m_Ⴈ.Ⴓ = P_0;
		this.m_Ⴈ.Ⴀ = P_1;
	}

	public void Ⴍ()
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴈ(FilterCfg.Ⴈ(this.m_Ⴈ.Ⴓ, this.m_Ⴈ.Ⴀ, 361, 355));
				break;
			case 4:
				break;
			case 0:
				_ = Ⴃ() is ႳႳ;
				UserCmd.Ⴅ[32] = (byte)((UserCmd.Ⴅ[32] - UserCmd.Ⴅ[366]) & 0xE9);
				return;
			case 2:
				return;
			}
			num = 0;
		}
	}

	[SecuritySafeCritical]
	static ႳႳ()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static string[] Ⴄ<_0021_00210>(_0021_00210 P_0, char[] P_1, int P_2, char P_3) where _0021_00210 : string
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		Array array = default(Array);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄ[290] - 49146;
					continue;
				case 5:
					break;
				case 8:
					num2 = (((P_2 ^ P_3) - 79) ^ num) switch
					{
						0 => 1, 
						_ => 4, 
					};
					continue;
				case 4:
					array = null;
					num2 = 3;
					continue;
				case 1:
					array = P_0.Split(P_1);
					num2 = 3;
					continue;
				case 3:
				case 7:
					num++;
					goto case 2;
				case 2:
				{
					int num3 = 3752;
					int num4 = 622;
					num2 = ((938 < num3 / 4 - num4) ? (ⴀႠ[126] - 21886) : 6);
					continue;
				}
				case 6:
				case 10:
					return array as string[];
				case 9:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႠ[34] - 62553;
					continue;
				case 11:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 38) ^ num) switch
					{
						0 => 0, 
						_ => 7, 
					};
					continue;
				case 4:
				case 7:
					result = 13;
					num2 = 2;
					continue;
				case 0:
				case 5:
					result = P_0.Length;
					num2 = 2;
					continue;
				case 2:
					num++;
					goto case 10;
				case 10:
				{
					int num3 = 485;
					int num4 = 888;
					num2 = ((2664 > num4 - num3 * 3) ? 1 : 3);
					continue;
				}
				case 3:
					num2 = 6;
					continue;
				case 1:
					return result;
				case 8:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, DataGridViewColumnHeadersHeightSizeMode P_1, char P_2, int P_3) where _0021_00210 : DataGridView
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 3;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				continue;
			case 5:
				num = (((P_3 ^ P_2) - 12) ^ num2) switch
				{
					0 => ⴀႠ[103] - 38472, 
					_ => ⴀႠ[92] - 62201, 
				};
				continue;
			case 2:
				num = 6;
				continue;
			case 7:
				P_0.ColumnHeadersHeightSizeMode = P_1;
				goto case 4;
			case 4:
			case 6:
				num2++;
				num3 = 1064;
				num4 = 239;
				break;
			case 1:
				break;
			case 8:
				return;
			}
			num = ((266 < num3 / 4 - num4) ? (ⴀႠ[85] - 36644) : 8);
		}
	}
}
