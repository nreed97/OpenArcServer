using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcShared;
using ArcShared.ArcUtils;
using ZedGraph;
using Ⴀ;

namespace ArcClientEngine.ArcCfg.OldHighlightCode;

public sealed class HighlightCountyCfg
{
	private Color m_Ⴍ;

	private MultimediaCfg.Ⴍ Ⴄ = new MultimediaCfg.Ⴍ();

	[XmlIgnore]
	internal Color Ⴈ
	{
		get
		{
			Color ⴍ = this.m_Ⴍ;
			HighlightCtyCfg.ႠႠ[124] = (char)((HighlightCtyCfg.ႠႠ[124] + Bye.Ⴄ[260]) & 4);
			return ⴍ;
		}
		set
		{
			this.m_Ⴍ = ⴍ;
		}
	}

	[Browsable(false)]
	internal string Ⴐ
	{
		get
		{
			return SetDxFilter.Ⴃ(Ⴈ, 127, 76);
		}
		set
		{
			Ⴈ = HighlightArrlSectionCfg.Ⴓ(text, 190, 130);
		}
	}

	[SpecialName]
	internal string Ⴍ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		return Ⴄ.Ⴍ;
	}

	[SpecialName]
	internal void Ⴐ(string P_0)
	{
		Ⴄ.Ⴍ = P_0;
		Bye.Ⴄ[106] = (char)((Bye.Ⴄ[106] | Bye.Ⴄ[188]) & 0x75);
	}

	internal HighlightCountyCfg()
	{
	}

	public override string ToString()
	{
		char[] ⴄ = Bye.Ⴄ;
		return WxFilters.Ⴀ(null, 3, 103388539);
	}

	[SecuritySafeCritical]
	static HighlightCountyCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static GraphPane Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : ZedGraphControl
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		PaneBase paneBase = default(PaneBase);
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
					num2 = 1;
					continue;
				case 1:
				case 8:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 23) ^ num) switch
					{
						0 => 10, 
						_ => ⴗ[154] - 7303, 
					};
					continue;
				case 2:
					paneBase = null;
					num2 = 7;
					continue;
				case 10:
					paneBase = P_0.GraphPane;
					num2 = 7;
					continue;
				case 6:
				case 7:
				{
					num++;
					int num3 = 148;
					int num4 = 28;
					num2 = ((37 < num3 / 4 - num4) ? 9 : 4);
					continue;
				}
				case 3:
				case 4:
					return paneBase as GraphPane;
				case 0:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Symbol Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : LineItem
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		ISerializable serializable = default(ISerializable);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[103] - 55686;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 0:
				case 10:
					break;
				case 5:
					num2 = (((P_1 ^ P_2) - 57) ^ num) switch
					{
						0 => ⴄ[141] - 4802, 
						_ => 7, 
					};
					continue;
				case 7:
					serializable = null;
					num2 = 8;
					continue;
				case 2:
				case 4:
					serializable = P_0.Symbol;
					num2 = 8;
					continue;
				case 8:
				{
					num++;
					int num4 = 1332;
					int num5 = 271;
					num2 = ((333 < num4 / 4 - num5) ? (ⴄ[210] - 42787) : 6);
					continue;
				}
				case 3:
				case 6:
					return (Symbol)serializable;
				case 9:
				{
					char num3 = ⴗ[98];
					UserCmd.Ⴅ[349] = (byte)((UserCmd.Ⴅ[349] * P_2) & 0x82);
					num2 = num3 - 39641;
					continue;
				}
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210>(_0021_00210 P_0, Point P_1, int P_2, int P_3) where _0021_00210 : Control
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				break;
			case 2:
				num = (((P_3 ^ P_2) - 83) ^ num2) switch
				{
					0 => ⴗ[122] - 26792, 
					_ => 0, 
				};
				break;
			case 0:
				num = ⴅ[86] - 20;
				break;
			case 1:
			case 4:
			case 9:
				P_0.Location = P_1;
				goto case 3;
			case 3:
			case 5:
			{
				num2++;
				int num3 = 214;
				int num4 = 690;
				num = ((3450 > num4 - num3 * 5) ? (ⴅ[196] - 52) : 8);
				break;
			}
			case 8:
				num = 2;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte ႷႭ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		byte result = default(byte);
		int num4 = default(int);
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
					num2 = ⴀႠ[92] - 62196;
					continue;
				case 7:
					break;
				case 0:
				case 6:
					num2 = (((P_2 ^ P_1) - 105) ^ num) switch
					{
						0 => 9, 
						_ => 2, 
					};
					continue;
				case 2:
					result = 15;
					num2 = 3;
					continue;
				case 9:
				case 11:
					result = CtyInfo.ScrubZone(P_0);
					num2 = 3;
					continue;
				case 3:
					num++;
					goto case 4;
				case 4:
					num4 = P_1 * P_1;
					num4 = P_1 + num4;
					num2 = 10;
					continue;
				case 10:
				{
					int num3 = num4;
					HighlightCtyCfg.ႠႠ[3] = (char)(HighlightCtyCfg.ႠႠ[3] & Bye.Ⴄ[79] & 0xCB);
					num2 = ((num3 % 2 == 0) ? 1 : (ⴗ[149] - 53675));
					continue;
				}
				case 1:
					return result;
				case 5:
					num2 = ⴄ[62] - 13521;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataRow[] ႷႷ<_0021_00210, _0021_00211, _0021_00212>(_0021_00210 P_0, _0021_00212 P_1, _0021_00211 P_2, short P_3, short P_4) where _0021_00210 : DataTable where _0021_00211 : string where _0021_00212 : string
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[176] / 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 2:
				case 11:
					break;
				case 5:
					num2 = (((P_3 ^ P_4) - 105) ^ num) switch
					{
						0 => 9, 
						_ => ⴄ[295] - 49143, 
					};
					continue;
				case 1:
					obj = null;
					num2 = 8;
					continue;
				case 9:
					obj = P_0.Select(P_1, P_2);
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = P_4 * P_4;
					goto case 6;
				case 6:
					num3 = P_4 + num3;
					goto case 4;
				case 4:
					num2 = ⴅ[396] - ⴅ[48];
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? (ⴀႠ[68] - 51742) : (ⴗ[84] - 7156));
					continue;
				case 0:
					return (DataRow[])obj;
				case 7:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႠ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : DataGridViewCellStyle where _0021_00211 : DataGridView
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 6;
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
				num = (((P_2 ^ P_3) - 53) ^ num2) switch
				{
					0 => ⴀႠ[102] - 35216, 
					_ => 0, 
				};
				continue;
			case 0:
				num = 3;
				continue;
			case 2:
			case 7:
				P_0.ColumnHeadersDefaultCellStyle = P_1;
				goto case 3;
			case 3:
				num2++;
				num3 = 1095;
				num4 = 300;
				break;
			case 1:
				break;
			case 4:
			case 8:
				return;
			}
			num = ((365 < num3 / 3 - num4) ? (ⴗ[37] - 54916) : 4);
		}
	}

	[SecuritySafeCritical]
	internal static DataGridViewColumnCollection ႷႣ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DataGridView
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		IList list = default(IList);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[77] - 57101;
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
				case 0:
				case 3:
				case 5:
				{
					int num5 = P_1 ^ P_2;
					Bye.Ⴄ[64] = (char)((Bye.Ⴄ[64] + P_1) & 0x2F);
					num2 = ((num5 - 53) ^ num) switch
					{
						0 => 1, 
						_ => 4, 
					};
					continue;
				}
				case 4:
					list = null;
					num2 = ⴀႠ[0] - 49947;
					continue;
				case 1:
				case 9:
					list = P_0.Columns;
					num2 = 10;
					continue;
				case 10:
				{
					num++;
					int num3 = 22;
					int num4 = 61;
					num2 = ((549 > num4 - num3 * 9) ? 6 : 11);
					continue;
				}
				case 11:
					num2 = ⴗ[55] - 30982;
					continue;
				case 6:
					return list as DataGridViewColumnCollection;
				case 7:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataGridViewRow ႷႳ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, char P_3) where _0021_00210 : DataGridViewRowCollection
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		DataGridViewBand dataGridViewBand = default(DataGridViewBand);
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
					num2 = 9;
					continue;
				case 4:
				case 9:
				case 11:
					break;
				case 10:
					num2 = (((P_2 ^ P_3) - 65) ^ num) switch
					{
						0 => 2, 
						_ => ⴄ[230] - 23682, 
					};
					continue;
				case 0:
				{
					dataGridViewBand = null;
					char num4 = ⴄ[266];
					ႥႰ.Ⴗ[81] = (char)((ႥႰ.Ⴗ[81] | P_1) & 0xF7);
					num2 = num4 - 23480;
					continue;
				}
				case 2:
					dataGridViewBand = P_0[P_1];
					num2 = 3;
					continue;
				case 3:
					num++;
					goto case 1;
				case 1:
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					num2 = ⴅ[78] - 40;
					continue;
				case 6:
					num2 = ((num3 % 2 != 0) ? 10 : 8);
					continue;
				case 8:
					return (DataGridViewRow)dataGridViewBand;
				case 7:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႤ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, char P_3) where _0021_00210 : DataGridViewButtonColumn
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 1;
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴄ[179] - 31349;
				break;
			case 3:
				num = (((P_2 ^ P_3) - 101) ^ num3) switch
				{
					0 => ⴗ[154] - 7301, 
					_ => ⴀႠ[68] - 51738, 
				};
				break;
			case 9:
				num = 8;
				break;
			case 4:
				P_0.UseColumnTextForButtonValue = P_1;
				goto case 5;
			case 5:
			case 7:
			case 8:
			{
				int num2 = num3;
				ႥႰ.Ⴗ[43] = (char)((ႥႰ.Ⴗ[43] | P_2) & 0xEC);
				num3 = num2 + 1;
				num4 = 648;
				num5 = 910;
				goto case 2;
			}
			case 2:
				num = ((8190 > num5 - num4 * 9) ? 6 : 0);
				break;
			case 0:
				num = 3;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႷႥ(char P_0, short P_1)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		IComparable comparable = default(IComparable);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[288] - 36181;
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
				case 8:
					num2 = (((P_0 ^ P_1) - 80) ^ num) switch
					{
						0 => ⴄ[260] - 22971, 
						_ => 4, 
					};
					continue;
				case 4:
					comparable = null;
					num2 = ⴀႠ[101] - 46668;
					continue;
				case 0:
				case 5:
					comparable = UtilsVersion.ShortVersion;
					num2 = 7;
					continue;
				case 7:
				case 10:
					num++;
					num2 = (((P_0 * P_0 + P_0) % 2 == 0) ? (ⴅ[390] - 193) : (ⴀႠ[55] - 49890));
					continue;
				case 3:
					num2 = ⴅ[4];
					continue;
				case 1:
					return comparable as string;
				case 6:
					num2 = ⴗ[125] - 55790;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႷႰ(char P_0, short P_1, char P_2)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		bool result = default(bool);
		int num3 = default(int);
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
					num2 = 0;
					continue;
				case 0:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 101) ^ num) switch
					{
						0 => 6, 
						_ => 1, 
					};
					continue;
				case 1:
					result = false;
					num2 = ⴀႠ[0] - 49948;
					continue;
				case 6:
				case 7:
					result = char.IsLower(P_0);
					num2 = ⴅ[219] - 223;
					continue;
				case 9:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 10;
				case 10:
					num2 = 5;
					continue;
				case 5:
					num2 = ((num3 % 2 != 0) ? 4 : 8);
					continue;
				case 8:
					return result;
				case 11:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႨ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : System.Timers.Timer where _0021_00211 : ElapsedEventHandler
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 2;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_2 ^ P_3) - 78) ^ num3) switch
				{
					0 => 0, 
					_ => ⴅ[213] - 239, 
				};
				break;
			case 1:
			case 6:
				num = ⴄ[265] - 20893;
				break;
			case 0:
				P_0.Elapsed += P_1;
				goto case 8;
			case 8:
				num3++;
				num2 = P_2 * P_2;
				goto case 5;
			case 5:
			case 7:
				num2 = P_2 + num2;
				num = ⴄ[179] - 31343;
				break;
			case 9:
				num = ((num2 % 2 != 0) ? 4 : 3);
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႷႼ<_0021_00210>(_0021_00210 P_0, byte[] P_1, int P_2, int P_3, int P_4, char P_5) where _0021_00210 : Stream
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[93] - 27762;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄ[202] - 17182;
					continue;
				case 10:
					break;
				case 3:
					num2 = (((P_5 ^ P_4) - 0) ^ num) switch
					{
						0 => ⴅ[4] / 2, 
						_ => 8, 
					};
					continue;
				case 8:
					result = 7;
					num2 = 7;
					continue;
				case 4:
					result = P_0.Read(P_1, P_2, P_3);
					num2 = 7;
					continue;
				case 0:
				case 5:
				case 7:
				{
					num++;
					int num3 = 3924;
					int num4 = 582;
					num2 = ((981 < num3 / 4 - num4) ? 3 : (ⴅ[327] - 220));
					continue;
				}
				case 1:
					return result;
				case 9:
					num2 = ⴗ[120] - 5081;
					continue;
				}
				break;
			}
		}
	}
}
