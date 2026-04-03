using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ArcShared.ArcIo.Tcp;
using Ⴀ;

namespace ArcClientEngine.ArcCfg.OldHighlightCode;

public sealed class HighlightCqZoneCfg
{
	private string Ⴈ;

	private Color Ⴄ;

	[XmlIgnore]
	internal Color Ⴐ
	{
		get
		{
			byte[] ⴅ = UserCmd.Ⴅ;
			return Ⴄ;
		}
		set
		{
			Ⴄ = ⴄ;
		}
	}

	[Browsable(false)]
	internal string Ⴀ
	{
		get
		{
			char[] ⴗ = ႥႰ.Ⴗ;
			return SetDxFilter.Ⴃ(Ⴐ, 330, 377);
		}
		set
		{
			Ⴐ = HighlightArrlSectionCfg.Ⴓ(text, 257, 317);
		}
	}

	[SpecialName]
	internal string Ⴀ()
	{
		return Ⴈ;
	}

	[SpecialName]
	internal void Ⴀ(string P_0)
	{
		Ⴈ = P_0;
	}

	internal HighlightCqZoneCfg()
	{
	}

	public override string ToString()
	{
		string result = WxFilters.Ⴀ(null, 2, 103387162);
		HighlightCtyCfg.ႠႠ[114] = (char)((HighlightCtyCfg.ႠႠ[114] - HighlightCtyCfg.ႠႠ[54]) & 0x29);
		return result;
	}

	[SecuritySafeCritical]
	static HighlightCqZoneCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211, _0021_00212>(_0021_00211 P_0, _0021_00212 P_1, _0021_00210 P_2, short P_3, int P_4) where _0021_00211 : DataRow where _0021_00212 : string
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄ[191] - 7658;
				break;
			case 5:
				num = (((P_4 ^ P_3) - 24) ^ num2) switch
				{
					0 => 9, 
					_ => 7, 
				};
				break;
			case 2:
			case 7:
				num = 1;
				break;
			case 6:
			case 9:
				P_0[P_1] = P_2;
				goto case 1;
			case 1:
				num2++;
				goto case 4;
			case 4:
			{
				int num3 = 204;
				int num4 = 411;
				num = ((2466 <= num4 - num3 * 6) ? (ⴀႠ[111] - 49558) : 0);
				break;
			}
			case 3:
				num = 5;
				break;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static TreeNodeCollection Ⴅ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : TreeView
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[173] - ⴅ[9];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 2:
				case 7:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 31) ^ num) switch
					{
						0 => 3, 
						_ => ⴗ[16] - 26632, 
					};
					continue;
				case 9:
					enumerable = null;
					num2 = ⴅ[4];
					continue;
				case 3:
					enumerable = P_0.Nodes;
					num2 = ⴀႠ[106] - 51670;
					continue;
				case 8:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 4 : 5);
					continue;
				case 5:
					num2 = 11;
					continue;
				case 0:
				case 4:
					return (TreeNodeCollection)enumerable;
				case 6:
				case 10:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : DataGridViewCellStyle where _0021_00211 : DataGridView
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴗ[89] - 46817;
				continue;
			case 3:
			case 5:
			case 6:
				num = (((P_3 ^ P_2) - 62) ^ num2) switch
				{
					0 => 7, 
					_ => 2, 
				};
				continue;
			case 2:
			case 8:
				num = 0;
				continue;
			case 7:
				P_0.DefaultCellStyle = P_1;
				break;
			case 0:
				break;
			case 4:
				return;
			}
			num2++;
			int num3 = 1404;
			int num4 = 419;
			num = ((702 < num3 / 2 - num4) ? 5 : 4);
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴜ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DataGridViewBand
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		bool result = default(bool);
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
					num2 = ⴀႠ[108] - 45142;
					continue;
				case 1:
					break;
				case 11:
					num2 = (((P_1 ^ P_2) - 85) ^ num) switch
					{
						0 => 7, 
						_ => 0, 
					};
					continue;
				case 0:
					result = true;
					num2 = ⴄ[169] - 10930;
					continue;
				case 5:
				case 6:
				case 7:
					result = P_0.Visible;
					num2 = ⴄ[80] - 22723;
					continue;
				case 9:
				{
					num++;
					int num3 = 2;
					int num4 = 4;
					num2 = ((12 > num4 - num3 * 3) ? 2 : 4);
					continue;
				}
				case 4:
					num2 = ⴅ[191] - 158;
					continue;
				case 2:
				case 3:
					return result;
				case 8:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႣႷ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DataGridViewCellEventArgs
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		int result = default(int);
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
					num2 = (((P_2 ^ P_1) - 114) ^ num) switch
					{
						0 => ⴗ[161] - 4994, 
						_ => ⴗ[113] - 53670, 
					};
					continue;
				case 7:
					result = 8;
					goto case 8;
				case 8:
					num2 = ⴄ[92] - 14813;
					continue;
				case 5:
					result = P_0.ColumnIndex;
					num2 = 2;
					continue;
				case 1:
				case 2:
				{
					num++;
					int num3 = 3928;
					int num4 = 866;
					num2 = ((982 < num3 / 4 - num4) ? (ⴄ[207] - 171) : 9);
					continue;
				}
				case 4:
				case 9:
					return result;
				case 6:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float ႣႣ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : DxSpot
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		float result = default(float);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[92] - 14807;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄ[290] - 49147;
					continue;
				case 4:
					break;
				case 0:
				case 8:
					num2 = (((P_1 ^ P_2) - 70) ^ num) switch
					{
						0 => 6, 
						_ => ⴄ[187] - 15460, 
					};
					continue;
				case 10:
					result = 0.40938988f;
					num2 = ⴅ[25];
					continue;
				case 1:
				case 6:
					result = P_0.Band;
					num2 = 2;
					continue;
				case 2:
				case 7:
				{
					num++;
					int num3 = 1826;
					int num4 = 123;
					num2 = ((913 < num3 / 2 - num4) ? 8 : (ⴗ[41] - 23799));
					continue;
				}
				case 5:
					return result;
				case 9:
					num2 = ⴄ[13] - 20652;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႣႰ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : TcpClient
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 1;
				break;
			case 1:
				num = (((P_1 ^ P_2) - 120) ^ num2) switch
				{
					0 => 0, 
					_ => ⴀႠ[38] - 28691, 
				};
				break;
			case 3:
			case 6:
				num = 7;
				break;
			case 0:
			case 9:
				P_0.Disconnect();
				goto case 5;
			case 5:
			case 7:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 8 : 2);
				break;
			case 2:
				num = ⴄ[144] - 33083;
				break;
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႣႨ(ref DateTime P_0, short P_1, short P_2)
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[210] - 42781;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
				case 3:
					break;
				case 11:
				{
					int num5;
					switch (((P_2 ^ P_1) - 110) ^ num)
					{
					default:
					{
						byte num6 = ⴅ[213];
						byte num7 = ⴅ[75];
						ႥႰ.Ⴗ[133] = (char)((ႥႰ.Ⴗ[133] ^ P_1) & 0xF9);
						num5 = num6 - num7;
						break;
					}
					case 0:
						num5 = 9;
						break;
					}
					num2 = num5;
					continue;
				}
				case 7:
					result = 13;
					num2 = 10;
					continue;
				case 1:
				case 9:
					result = P_0.Second;
					num2 = ⴀႠ[35] - 25305;
					continue;
				case 5:
				case 10:
				{
					num++;
					int num3 = 28;
					int num4 = 77;
					num2 = ((308 > num4 - num3 * 4) ? 6 : 8);
					continue;
				}
				case 8:
					num2 = ⴀႠ[61] - 26810;
					continue;
				case 6:
					return result;
				case 2:
					num2 = ⴀႠ[127] - 360;
					continue;
				}
				break;
			}
		}
	}
}
