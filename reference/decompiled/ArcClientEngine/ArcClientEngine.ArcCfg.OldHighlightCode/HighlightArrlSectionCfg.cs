using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcShared.ArcUtils;
using Ⴀ;

namespace ArcClientEngine.ArcCfg.OldHighlightCode;

public sealed class HighlightArrlSectionCfg
{
	private ႥႭ.ႳႰ m_Ⴈ;

	[XmlIgnore]
	internal Color Ⴈ
	{
		get
		{
			Color ⴍ = this.m_Ⴈ.Ⴍ;
			UserCmd.Ⴅ[299] = (byte)((UserCmd.Ⴅ[299] - UserCmd.Ⴅ[158]) & 0xAF);
			return ⴍ;
		}
		set
		{
			this.m_Ⴈ.Ⴍ = ⴍ;
		}
	}

	[Browsable(false)]
	internal string Ⴐ
	{
		get
		{
			return SetDxFilter.Ⴃ(Ⴈ, 117, 70);
		}
		set
		{
			Ⴈ = Ⴓ(text, 361, 341);
		}
	}

	[SpecialName]
	internal string Ⴄ()
	{
		return this.m_Ⴈ.Ⴐ;
	}

	[SpecialName]
	internal void Ⴃ(string P_0)
	{
		this.m_Ⴈ.Ⴐ = P_0;
	}

	internal HighlightArrlSectionCfg()
	{
	}

	public override string ToString()
	{
		return WxFilters.Ⴀ(null, 5, 103389782);
	}

	[SecuritySafeCritical]
	static HighlightArrlSectionCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210, _0021_00211, _0021_00212>(_0021_00212 P_0, _0021_00211 P_1, _0021_00210 P_2, char P_3, int P_4) where _0021_00210 : string where _0021_00211 : string where _0021_00212 : string
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 10:
					num2 = (((P_3 ^ P_4) - 11) ^ num) switch
					{
						0 => 2, 
						1 => ⴄ[50] - ⴄ[277], 
						_ => ⴄ[282] - 3996, 
					};
					continue;
				case 8:
					enumerable = null;
					num2 = 0;
					continue;
				case 2:
					enumerable = P_0.Replace(P_1, P_2);
					goto case 9;
				case 9:
				{
					char num3 = ⴄ[117];
					ႥႰ.Ⴗ[96] = (char)((ႥႰ.Ⴗ[96] - P_4) & 0xFF);
					num2 = num3 - 41901;
					continue;
				}
				case 1:
					enumerable = string.Concat(P_0, P_1, P_2);
					num2 = 0;
					continue;
				case 0:
					num++;
					goto case 5;
				case 5:
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? ⴅ[115] : (ⴅ[312] + 2));
					continue;
				case 6:
					num2 = 10;
					continue;
				case 4:
					return (string)enumerable;
				case 7:
				case 11:
					num2 = ⴄ[99] - 59558;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Color Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		Color result = default(Color);
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
					num2 = ⴗ[21] - 63707;
					continue;
				case 2:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 60) ^ num) switch
					{
						0 => ⴅ[240] - 206, 
						_ => ⴀႠ[61] - 26813, 
					};
					continue;
				case 8:
					result = default(Color);
					num2 = 6;
					continue;
				case 3:
				case 9:
					result = UtilsXml.DeserializeColor(P_0);
					num2 = 6;
					continue;
				case 6:
				case 7:
					num++;
					num3 = 636;
					goto case 0;
				case 0:
				{
					int num4 = 89;
					num2 = ((212 < num3 / 3 - num4) ? 1 : (ⴄ[16] - 31821));
					continue;
				}
				case 4:
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
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, short P_3, short P_4) where _0021_00210 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[16] - 26640;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႠ[10] - 7236;
					continue;
				case 10:
					break;
				case 1:
				case 6:
					num2 = (((P_3 ^ P_4) - 60) ^ num) switch
					{
						0 => 2, 
						_ => 3, 
					};
					continue;
				case 3:
					cloneable = null;
					goto case 0;
				case 0:
					num2 = ⴗ[58] - 20889;
					continue;
				case 2:
					cloneable = P_0.Substring(P_1, P_2);
					num2 = ⴅ[285] + ⴅ[115];
					continue;
				case 9:
				{
					num++;
					int num3 = 636;
					int num4 = 89;
					num2 = ((212 < num3 / 3 - num4) ? 1 : (ⴄ[24] - 38594));
					continue;
				}
				case 5:
					return cloneable as string;
				case 7:
				case 8:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210>(ref int P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		ICloneable cloneable = default(ICloneable);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 7;
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
				case 7:
				{
					int num5 = P_2 ^ P_3;
					Bye.Ⴄ[224] = (char)((Bye.Ⴄ[224] ^ P_2) & 0xBD);
					num2 = ((num5 - 47) ^ num) switch
					{
						0 => 4, 
						_ => 9, 
					};
					continue;
				}
				case 9:
					cloneable = null;
					goto case 5;
				case 5:
					num2 = 8;
					continue;
				case 4:
				case 6:
					cloneable = P_0.ToString(P_1);
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = 1683;
					num4 = 333;
					goto case 3;
				case 3:
					num2 = ((561 < num3 / 3 - num4) ? 7 : (ⴀႠ[126] - 21884));
					continue;
				case 10:
					return cloneable as string;
				case 2:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴜ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, short P_3) where _0021_00211 : BindingSource
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[2] - 60;
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
					num2 = (((P_2 ^ P_3) - 26) ^ num) switch
					{
						0 => ⴗ[22] - 14488, 
						_ => 4, 
					};
					continue;
				case 4:
					result = 1;
					num2 = ⴄ[240] - 48070;
					continue;
				case 3:
					result = P_0.Add(P_1);
					num2 = ⴀႠ[122] - 49002;
					continue;
				case 8:
					num++;
					goto case 11;
				case 11:
					num2 = (((P_2 * P_2 + P_2) % 2 != 0) ? 1 : 5);
					continue;
				case 1:
					num2 = ⴗ[154] - 7298;
					continue;
				case 0:
				case 5:
					return result;
				case 2:
				case 9:
					num2 = ⴗ[48] - 52954;
					continue;
				}
				break;
			}
		}
	}
}
