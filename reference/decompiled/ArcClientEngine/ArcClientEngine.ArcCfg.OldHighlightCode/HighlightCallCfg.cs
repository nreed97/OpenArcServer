using System.Collections;
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
using Ⴀ;

namespace ArcClientEngine.ArcCfg.OldHighlightCode;

public sealed class HighlightCallCfg
{
	private string Ⴗ;

	private Color Ⴃ;

	[XmlIgnore]
	internal Color Ⴐ
	{
		get
		{
			Color ⴃ = Ⴃ;
			UserCmd.Ⴅ[310] = (byte)(UserCmd.Ⴅ[310] & ႥႰ.Ⴗ[86] & 0xDE);
			return ⴃ;
		}
		set
		{
			Ⴃ = ⴃ;
		}
	}

	[Browsable(false)]
	internal string Ⴀ
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			return SetDxFilter.Ⴃ(Ⴐ, 789, 806);
		}
		set
		{
			Ⴐ = HighlightArrlSectionCfg.Ⴓ(text, 983, 1003);
		}
	}

	[SpecialName]
	internal string Ⴈ()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		return Ⴗ;
	}

	[SpecialName]
	internal void Ⴍ(string P_0)
	{
		Ⴗ = P_0;
	}

	internal HighlightCallCfg()
	{
	}

	public override string ToString()
	{
		return WxFilters.Ⴀ(null, 2, 103387162);
	}

	[SecuritySafeCritical]
	static HighlightCallCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static Color Ⴄ(short P_0, int P_1)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		Color result = default(Color);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 12;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄ[290] - 49148;
					continue;
				case 3:
					break;
				case 12:
					num2 = (((P_1 ^ P_0) - 5) ^ num) switch
					{
						0 => 2, 
						1 => 8, 
						_ => 10, 
					};
					continue;
				case 10:
					result = default(Color);
					num2 = 6;
					continue;
				case 2:
					result = Color.Transparent;
					num2 = 6;
					continue;
				case 8:
					result = SystemColors.Window;
					num2 = ⴗ[103] - 55685;
					continue;
				case 4:
				case 6:
					num++;
					num3 = 47;
					goto case 1;
				case 1:
				{
					int num4 = 850;
					num2 = ((7650 > num4 - num3 * 9) ? (ⴗ[28] - 37803) : (ⴗ[122] - 26794));
					continue;
				}
				case 7:
					num2 = 12;
					continue;
				case 5:
					return result;
				case 9:
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataGridViewCellCollection Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : DataGridViewRow
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		IEnumerable enumerable = default(IEnumerable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 11;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႠ[44] - 48726;
					continue;
				case 2:
					break;
				case 11:
					num2 = (((P_1 ^ P_2) - 118) ^ num) switch
					{
						0 => 0, 
						_ => 4, 
					};
					continue;
				case 4:
					enumerable = null;
					num2 = ⴀႠ[61] - 26820;
					continue;
				case 0:
					enumerable = P_0.Cells;
					num2 = ⴄ[217] - 54990;
					continue;
				case 1:
					num++;
					num3 = 73;
					goto case 3;
				case 3:
				{
					int num4 = 322;
					num2 = ((1932 > num4 - num3 * 6) ? (ⴄ[277] - 52011) : (ⴄ[134] - 3656));
					continue;
				}
				case 6:
				case 10:
					num2 = 11;
					continue;
				case 5:
				case 7:
					return (DataGridViewCellCollection)enumerable;
				case 9:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}
}
