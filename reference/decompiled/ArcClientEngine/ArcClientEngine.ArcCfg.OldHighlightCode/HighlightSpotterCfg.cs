using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ArcShared.ExtensionMethods;
using Ⴀ;

namespace ArcClientEngine.ArcCfg.OldHighlightCode;

public sealed class HighlightSpotterCfg
{
	[StructLayout(LayoutKind.Auto)]
	internal struct ႤႰ
	{
		internal ArcClientObjMgr Ⴍ;

		internal string Ⴃ;

		internal string Ⴐ;

		internal string Ⴅ;

		internal DateTime Ⴈ;

		internal DxSpot Ⴓ;
	}

	private Color Ⴈ;

	private MultimediaCfg.Ⴍ m_Ⴀ = new MultimediaCfg.Ⴍ();

	[XmlIgnore]
	internal Color Ⴐ
	{
		get
		{
			return Ⴈ;
		}
		set
		{
			Ⴈ = ⴈ;
		}
	}

	[Browsable(false)]
	internal string Ⴀ
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return SetDxFilter.Ⴃ(Ⴐ, 232, 219);
		}
		set
		{
			Ⴐ = HighlightArrlSectionCfg.Ⴓ(text, 717, 753);
		}
	}

	[SpecialName]
	internal string Ⴄ()
	{
		return this.m_Ⴀ.Ⴍ;
	}

	[SpecialName]
	internal void Ⴍ(string P_0)
	{
		this.m_Ⴀ.Ⴍ = P_0;
	}

	internal HighlightSpotterCfg()
	{
	}

	public override string ToString()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		return WxFilters.Ⴀ(null, 2, 103388485);
	}

	[SecuritySafeCritical]
	static HighlightSpotterCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static int Ⴓ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, short P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 0;
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
				case 0:
					num2 = (((P_2 ^ P_3) - 49) ^ num) switch
					{
						0 => ⴀႠ[90] - 47360, 
						_ => ⴀႠ[117] - 64732, 
					};
					continue;
				case 3:
					result = 8;
					num2 = ⴅ[240] - 203;
					continue;
				case 2:
				case 11:
					result = P_0.IndexOf(P_1);
					num2 = 6;
					continue;
				case 6:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴀႠ[97] - 34993) : 4);
					continue;
				case 4:
				case 10:
					num2 = ⴅ[17];
					continue;
				case 9:
					return result;
				case 5:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Cursor Ⴗ(char P_0, int P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		IDisposable disposable = default(IDisposable);
		int num3 = default(int);
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
					num2 = ⴅ[157] / 3;
					continue;
				case 7:
					break;
				case 5:
				case 8:
					num2 = (((P_1 ^ P_0) - 84) ^ num) switch
					{
						0 => 4, 
						_ => ⴄ[193] - 25244, 
					};
					continue;
				case 1:
					disposable = null;
					num2 = 11;
					continue;
				case 4:
					disposable = Cursors.WaitCursor;
					num2 = ⴄ[195] - 44476;
					continue;
				case 0:
				case 11:
					num++;
					num3 = P_0 * P_0;
					num3 = P_0 + num3;
					num2 = 10;
					continue;
				case 9:
				case 10:
					num2 = ((num3 % 2 != 0) ? 8 : 6);
					continue;
				case 6:
					return disposable as Cursor;
				case 3:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : WwvSpot where _0021_00211 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 7;
				break;
			case 7:
				num = (((P_2 ^ P_3) - 3) ^ num2) switch
				{
					0 => 6, 
					_ => ⴗ[132] - 17455, 
				};
				break;
			case 3:
				num = ⴅ[285];
				break;
			case 6:
				P_0.DeserializeUser(P_1);
				goto case 4;
			case 4:
			case 5:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴅ[154] - 217) : 2);
				break;
			case 2:
			case 9:
				num = ⴅ[220] - 93;
				break;
			case 1:
				return;
			}
		}
	}
}
