using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcShared;
using ArcShared.ArcUtils;
using Ⴀ;

namespace ArcClientEngine.ArcCfg.OldHighlightCode;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class HighlightCfg
{
	private sealed class ႭႭ
	{
		[SecuritySafeCritical]
		static ႭႭ()
		{
			ArcClientConnectDat.Ⴍ();
		}
	}

	private sealed class ႭႠ
	{
		[SecuritySafeCritical]
		static ႭႠ()
		{
			ArcClientConnectDat.Ⴍ();
		}
	}

	private sealed class ႭႳ
	{
		[SecuritySafeCritical]
		static ႭႳ()
		{
			ArcClientConnectDat.Ⴍ();
		}
	}

	private sealed class ႭႨ
	{
		[SecuritySafeCritical]
		static ႭႨ()
		{
			ArcClientConnectDat.Ⴍ();
		}
	}

	private sealed class ႭႷ
	{
		[SecuritySafeCritical]
		static ႭႷ()
		{
			ArcClientConnectDat.Ⴍ();
		}
	}

	private sealed class ႭႰ
	{
		[SecuritySafeCritical]
		static ႭႰ()
		{
			ArcClientConnectDat.Ⴍ();
		}
	}

	private sealed class ႭႣ
	{
		[SecuritySafeCritical]
		static ႭႣ()
		{
			ArcClientConnectDat.Ⴍ();
		}
	}

	private sealed class ႭႥ
	{
		[SecuritySafeCritical]
		static ႭႥ()
		{
			ArcClientConnectDat.Ⴍ();
		}
	}

	internal sealed class ႳႷ
	{
		internal ArcClientObjMgr Ⴍ;

		internal string Ⴗ;

		internal ႳႷ()
		{
		}
	}

	private List<HighlightArrlSectionCfg> m_Ⴅ;

	private List<HighlightCallCfg> m_Ⴅ;

	private List<HighlightCountyCfg> m_Ⴍ;

	private List<HighlightSpotterCfg> m_Ⴍ;

	private List<HighlightStateCfg> m_Ⴈ;

	private static Func<HighlightCallCfg, Color> m_Ⴍ;

	private static Func<HighlightCtyCfg, Color> m_Ⴐ;

	private static Func<HighlightSpotterCfg, Color> m_Ⴄ;

	private static Func<HighlightStateCfg, Color> m_Ⴐ;

	private static Func<HighlightCountyCfg, Color> m_Ⴃ;

	private static Func<HighlightArrlSectionCfg, Color> m_Ⴅ;

	private static Func<HighlightCqZoneCfg, Color> m_Ⴃ;

	private static Func<HighlightItuZoneCfg, Color> m_Ⴃ;

	private DxSpotRates.ႠႣ m_Ⴀ = new DxSpotRates.ႠႣ();

	[SpecialName]
	internal List<HighlightArrlSectionCfg> Ⴐ()
	{
		return this.m_Ⴅ;
	}

	[SpecialName]
	internal void Ⴐ(List<HighlightArrlSectionCfg> P_0)
	{
		this.m_Ⴅ = P_0;
	}

	[SpecialName]
	internal List<HighlightCallCfg> Ⴍ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		return this.m_Ⴅ;
	}

	[SpecialName]
	internal void Ⴄ(List<HighlightCallCfg> P_0)
	{
		this.m_Ⴅ = P_0;
	}

	[SpecialName]
	internal List<HighlightCtyCfg> Ⴈ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		return this.m_Ⴀ.Ⴗ;
	}

	[SpecialName]
	internal void Ⴈ(List<HighlightCtyCfg> P_0)
	{
		this.m_Ⴀ.Ⴗ = P_0;
	}

	[SpecialName]
	internal List<HighlightCountyCfg> Ⴃ()
	{
		return this.m_Ⴍ;
	}

	[SpecialName]
	internal void Ⴓ(List<HighlightCountyCfg> P_0)
	{
		this.m_Ⴍ = P_0;
	}

	[SpecialName]
	internal List<HighlightCqZoneCfg> Ⴀ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		return this.m_Ⴀ.Ⴃ;
	}

	[SpecialName]
	internal void Ⴀ(List<HighlightCqZoneCfg> P_0)
	{
		this.m_Ⴀ.Ⴃ = P_0 as List<HighlightCqZoneCfg>;
		HighlightCtyCfg.ႠႠ[76] = (char)((HighlightCtyCfg.ႠႠ[76] + HighlightCtyCfg.ႠႠ[34]) & 1);
	}

	[SpecialName]
	internal List<HighlightItuZoneCfg> Ⴓ()
	{
		char[] ⴄ = Bye.Ⴄ;
		return this.m_Ⴀ.Ⴐ;
	}

	[SpecialName]
	internal void Ⴍ(List<HighlightItuZoneCfg> P_0)
	{
		this.m_Ⴀ.Ⴐ = P_0;
	}

	[SpecialName]
	internal List<HighlightSpotterCfg> Ⴅ()
	{
		return this.m_Ⴍ;
	}

	[SpecialName]
	internal void Ⴅ(List<HighlightSpotterCfg> P_0)
	{
		this.m_Ⴍ = P_0;
	}

	[SpecialName]
	internal List<HighlightStateCfg> Ⴗ()
	{
		char[] ⴄ = Bye.Ⴄ;
		List<HighlightStateCfg> ⴈ = this.m_Ⴈ;
		UserCmd.Ⴅ[391] = (byte)((UserCmd.Ⴅ[391] + UserCmd.Ⴅ[18]) & 0xEF);
		return ⴈ;
	}

	[SpecialName]
	internal void Ⴃ(List<HighlightStateCfg> P_0)
	{
		this.m_Ⴈ = P_0;
	}

	internal HighlightCfg()
	{
		Ⴐ(new List<HighlightArrlSectionCfg>());
		Ⴄ(new List<HighlightCallCfg>());
		Ⴈ(new List<HighlightCtyCfg>());
		Ⴓ(new List<HighlightCountyCfg>());
		Ⴀ(new List<HighlightCqZoneCfg>());
		Ⴍ(new List<HighlightItuZoneCfg>());
		Ⴅ(new List<HighlightSpotterCfg>());
		Ⴃ(new List<HighlightStateCfg>());
	}

	public override string ToString()
	{
		return ႥႥ.Ⴅ(1673508768, null, 4);
	}

	private static Color Ⴜ(HighlightCallCfg P_0)
	{
		return P_0.Ⴐ;
	}

	private static Color ႤႰ(HighlightCtyCfg P_0)
	{
		return P_0.Ⴐ;
	}

	private static Color ႤႤ(HighlightSpotterCfg P_0)
	{
		return P_0.Ⴐ;
	}

	private static Color ႤႨ(HighlightStateCfg P_0)
	{
		Color result = P_0.Ⴈ;
		UserCmd.Ⴅ[360] = (byte)((UserCmd.Ⴅ[360] * UserCmd.Ⴅ[106]) & 0x2B);
		return result;
	}

	private static Color ႤႷ(HighlightCountyCfg P_0)
	{
		Color result = P_0.Ⴈ;
		HighlightCtyCfg.ႠႠ[105] = (char)((HighlightCtyCfg.ႠႠ[105] | HighlightCtyCfg.ႠႠ[33]) & 0xEC);
		return result;
	}

	private static Color ႤႳ(HighlightArrlSectionCfg P_0)
	{
		Color result = P_0.Ⴈ;
		ႥႰ.Ⴗ[112] = (char)((ႥႰ.Ⴗ[112] * UserCmd.Ⴅ[115]) & 0xCD);
		return result;
	}

	private static Color ႤႠ(HighlightCqZoneCfg P_0)
	{
		Color result = P_0.Ⴐ;
		ႥႰ.Ⴗ[121] = (char)((ႥႰ.Ⴗ[121] - ႥႰ.Ⴗ[35]) & 0x78);
		return result;
	}

	private static Color ႤႭ(HighlightItuZoneCfg P_0)
	{
		return P_0.Ⴈ;
	}

	[SecuritySafeCritical]
	static HighlightCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static string ႳႳ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[104] - 48546;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄ[1] - 1262;
					continue;
				case 6:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 108) ^ num) switch
					{
						0 => 10, 
						1 => ⴄ[21] - 62599, 
						2 => 3, 
						_ => 8, 
					};
					continue;
				case 8:
					comparable = null;
					num2 = 7;
					continue;
				case 10:
					comparable = Path.GetDirectoryName(P_0);
					num2 = ⴗ[137] - 1363;
					continue;
				case 0:
				case 11:
					comparable = CtyInfo.ScrubInfo(P_0);
					num2 = ⴀႠ[34] - 62557;
					continue;
				case 3:
					comparable = UtilsCallsign.ScrubTelnetControlChars(P_0);
					num2 = 7;
					continue;
				case 7:
				{
					num++;
					int num3 = 517;
					int num4 = 938;
					num2 = ((7504 > num4 - num3 * 8) ? 2 : 4);
					continue;
				}
				case 4:
					num2 = ⴗ[132] - 17457;
					continue;
				case 2:
				case 12:
					return (string)comparable;
				case 5:
					num2 = ⴄ[203] - 20732;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႳႰ<_0021_00210>(_0021_00210 P_0, DataGridViewContentAlignment P_1, char P_2, short P_3) where _0021_00210 : DataGridViewCellStyle
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 8;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴄ[34] - 61629;
				break;
			case 4:
			case 7:
				num = (((P_2 ^ P_3) - 97) ^ num3) switch
				{
					0 => 6, 
					_ => 1, 
				};
				break;
			case 1:
				num = ⴅ[46] - 128;
				break;
			case 6:
				P_0.Alignment = P_1;
				goto case 0;
			case 0:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				goto case 5;
			case 5:
				num = ⴗ[138] - 38284;
				break;
			case 3:
				num = ((num2 % 2 != 0) ? 4 : (ⴀႠ[20] - 33391));
				break;
			case 2:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႳႣ(DateTime P_0, DateTime P_1, short P_2, short P_3)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 4;
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
				case 4:
					num2 = (((P_3 ^ P_2) - 58) ^ num) switch
					{
						0 => ⴄ[154] - 60836, 
						_ => ⴅ[25] / 2, 
					};
					continue;
				case 1:
				case 9:
					result = false;
					num2 = 5;
					continue;
				case 6:
				case 7:
					result = P_0 < P_1;
					num2 = 5;
					continue;
				case 0:
				case 5:
				{
					num++;
					int num3 = 1152;
					int num4 = 287;
					num2 = ((288 < num3 / 4 - num4) ? 4 : 8);
					continue;
				}
				case 8:
					return result;
				case 3:
					num2 = ⴅ[115];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object ႳႤ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : string where _0021_00211 : AppDomain
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[25];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 1:
				case 10:
					break;
				case 2:
					num2 = (((P_2 ^ P_3) - 85) ^ num) switch
					{
						0 => 8, 
						_ => ⴗ[6] - 61630, 
					};
					continue;
				case 3:
					result = null;
					num2 = ⴗ[114] - 15466;
					continue;
				case 8:
					result = P_0.GetData(P_1);
					num2 = 9;
					continue;
				case 0:
				case 7:
				case 9:
				{
					num++;
					int num3 = 156;
					int num4 = 419;
					num2 = ((2514 > num4 - num3 * 6) ? (ⴗ[69] - 62801) : 11);
					continue;
				}
				case 11:
					num2 = ⴅ[25];
					continue;
				case 4:
					return result;
				case 5:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}
}
