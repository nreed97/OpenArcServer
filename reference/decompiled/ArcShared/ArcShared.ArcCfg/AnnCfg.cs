using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using Microsoft.VisualBasic.PowerPacks;
using Ⴃ;

namespace ArcShared.ArcCfg;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class AnnCfg
{
	internal sealed class ႷႷ
	{
		internal Button Ⴅ;

		internal Label Ⴗ;

		internal Label Ⴈ;

		internal Label Ⴍ;

		internal Label Ⴃ;

		internal Label Ⴐ;

		internal PictureBox Ⴀ;

		internal LineShape Ⴓ;

		internal string Ⴄ;

		internal string Ⴜ;

		internal ႷႷ()
		{
		}
	}

	private ModeType Ⴀ;

	private int Ⴄ;

	private OutputType Ⴅ;

	private bool Ⴈ;

	private DxCommentExtCfg.ႷႰ m_Ⴗ;

	[Description("Set the announce spot filter.  The most common filter is one to limit spots to geographic region, for North America that would be SpotterCont=NA.  You can filter by anthing in the spot. See the docs for more information.")]
	public string Filter
	{
		get
		{
			return this.m_Ⴗ.Ⴀ;
		}
		set
		{
			this.m_Ⴗ.Ⴀ = value as string;
			NeedsCfg.ႣႤ[312] = (NeedsCfg.ႣႤ[312] - NeedsCfg.ႣႤ[347]) & 0xDA;
		}
	}

	[Description("Set announce mode. Annoucne spots have three modes:  Open (filter is not appled), Filter (filter is applied) and Debug (All spots are displayed and a + or a - is displayed in front of the spot indicating if it passed or was rejected by the filter.")]
	public ModeType Mode
	{
		get
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	[Description("Sets the number of spots displayed with the Show Announce command")]
	public int NmbrSpots
	{
		get
		{
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	[Description("Sets the announce output to On (normal user display) OFF(no spots are displayed)")]
	public OutputType Output
	{
		get
		{
			return Ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	[Description("Turns on the option that wraps long Announce lines.")]
	public bool Wrap
	{
		get
		{
			bool ⴈ = Ⴈ;
			WxCfg.ႣႭ[242] = (char)((WxCfg.ႣႭ[242] * WxCfg.ႣႭ[275]) & 0x64);
			return ⴈ;
		}
		set
		{
			Ⴈ = value;
		}
	}

	public AnnCfg()
	{
		Filter = string.Empty;
		Mode = ModeType.Filter;
		NmbrSpots = 20;
		Output = OutputType.On;
	}

	public override string ToString()
	{
		char[] ⴗ = DxCfg.Ⴗ;
		return ႣႼ.ႥႭ(null, 624735902, 8, null);
	}

	[SecuritySafeCritical]
	static AnnCfg()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴓ(int P_0, char P_1)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		DateTime result = default(DateTime);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 5:
				case 11:
					num2 = (((P_0 ^ P_1) - 127) ^ num) switch
					{
						0 => ⴗ[140] - 43352, 
						_ => 0, 
					};
					continue;
				case 0:
					result = default(DateTime);
					goto case 6;
				case 6:
					num2 = 7;
					continue;
				case 4:
				case 8:
					result = DateTime.Now;
					num2 = 7;
					continue;
				case 7:
				{
					num++;
					int num3 = 126;
					int num4 = 884;
					num2 = ((5304 > num4 - num3 * 6) ? (ⴃႤ[590] - 59438) : (ⴀ[293] - 15930));
					continue;
				}
				case 10:
					num2 = 11;
					continue;
				case 9:
					return result;
				case 2:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string where _0021_00211 : Control
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 9;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႤ[448] - 13802;
				break;
			case 0:
			case 8:
				num = (((P_2 ^ P_3) - 7) ^ num2) switch
				{
					0 => 3, 
					_ => ⴗ[134] - 54692, 
				};
				break;
			case 2:
				num = 7;
				break;
			case 3:
				P_0.Text = P_1;
				goto case 7;
			case 7:
				num2++;
				num3 = 38;
				goto case 5;
			case 5:
			{
				int num4 = 147;
				int num6;
				if (1029 <= num4 - num3 * 7)
				{
					char num5 = ⴃႣ[72];
					TalkCfg.ႣႣ[27] = (char)((TalkCfg.ႣႣ[27] + P_2) & 0x9E);
					num6 = num5 - 41163;
				}
				else
				{
					num6 = 4;
				}
				num = num6;
				break;
			}
			case 1:
				num = ⴃႤ[37] - ⴃႤ[37];
				break;
			case 4:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataTable Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DbDataSourceEnumerator
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		ISupportInitializeNotification supportInitializeNotification = default(ISupportInitializeNotification);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[265] - 12570;
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
				case 7:
					num2 = (((P_2 ^ P_1) - 111) ^ num) switch
					{
						0 => 10, 
						_ => 11, 
					};
					continue;
				case 2:
				case 11:
					supportInitializeNotification = null;
					num2 = ⴃႣ[2] - 5259;
					continue;
				case 10:
					supportInitializeNotification = P_0.GetDataSources();
					num2 = 9;
					continue;
				case 5:
				case 9:
				{
					int num4 = num;
					TalkCfg.ႣႣ[60] = (char)((TalkCfg.ႣႣ[60] + P_1) & 0xFE);
					num = num4 + 1;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 3;
					continue;
				}
				case 0:
				case 3:
					num2 = ((num3 % 2 != 0) ? 7 : (ⴗ[25] - 18232));
					continue;
				case 8:
					return (DataTable)supportInitializeNotification;
				case 4:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string where _0021_00211 : Thread
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				break;
			case 6:
				num = (((P_2 ^ P_3) - 117) ^ num2) switch
				{
					0 => 4, 
					_ => 0, 
				};
				break;
			case 0:
				num = ⴃႭ[46] - 55840;
				break;
			case 4:
				P_0.Name = P_1;
				goto case 3;
			case 3:
			case 5:
				num2++;
				goto case 9;
			case 9:
			{
				int num3 = 114;
				int num4 = 277;
				num = ((1108 > num4 - num3 * 4) ? (ⴗ[130] - 63631) : 7);
				break;
			}
			case 7:
				num = ⴀ[288] - 12634;
				break;
			case 1:
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : Assembly where _0021_00211 : Assembly
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[267] - 9745;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[262] - 54838;
					continue;
				case 4:
					break;
				case 3:
					num2 = (((P_3 ^ P_2) - 66) ^ num) switch
					{
						0 => ⴀ[303] - 4125, 
						_ => ⴐ[98] - 35673, 
					};
					continue;
				case 7:
				case 10:
					result = true;
					num2 = 9;
					continue;
				case 6:
					result = P_0 != P_1;
					num2 = ⴃႭ[8] - 30689;
					continue;
				case 9:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 1;
					continue;
				case 1:
					num2 = ((num3 % 2 != 0) ? (ⴃႭ[65] - 41724) : (ⴃႤ[166] - 54275));
					continue;
				case 0:
				case 2:
					return result;
				case 5:
				case 8:
					num2 = ⴀ[246] - 23130;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴜ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool result = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[304] - 61113;
					continue;
				case 7:
					break;
				case 3:
					num2 = (((P_3 ^ P_2) - 63) ^ num) switch
					{
						0 => 1, 
						_ => 2, 
					};
					continue;
				case 2:
					result = true;
					num2 = 11;
					continue;
				case 1:
					result = object.ReferenceEquals(P_0, P_1);
					num2 = ⴃႤ[458] - 64765;
					continue;
				case 11:
					num++;
					goto case 0;
				case 0:
				{
					num4 = 1083;
					int num5 = num4;
					num3 = num5 * num5;
					num2 = 6;
					continue;
				}
				case 5:
				case 6:
					num3 = num4 + num3;
					goto case 4;
				case 4:
					num2 = ((num3 % 2 != 0) ? 3 : (ⴀ[249] - 38329));
					continue;
				case 8:
					return result;
				case 9:
					num2 = ⴐ[31] - 45324;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႳ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : FileSystemWatcher where _0021_00211 : FileSystemEventHandler
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 3;
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
				num = (((P_2 ^ P_3) - 11) ^ num2) switch
				{
					0 => 9, 
					_ => 8, 
				};
				break;
			case 6:
			case 8:
				num = ⴃႣ[45] - 41391;
				break;
			case 7:
			case 9:
				P_0.Changed += P_1;
				goto case 1;
			case 1:
			case 5:
			{
				num2++;
				int num3 = 558;
				int num4 = 822;
				num = ((3288 <= num4 - num3 * 4) ? 4 : 0);
				break;
			}
			case 4:
				num = 2;
				break;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static double ႷႠ(ref TimeSpan P_0, char P_1, char P_2)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		double result = default(double);
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
					num2 = ⴀ[372] - ⴀ[372];
					continue;
				case 0:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 61) ^ num) switch
					{
						0 => ⴃႤ[89] - 51952, 
						_ => ⴀ[63] - 17149, 
					};
					continue;
				case 4:
					result = 0.12207762512929436;
					num2 = ⴐ[475] - 17956;
					continue;
				case 2:
				case 8:
					result = P_0.TotalMilliseconds;
					num2 = ⴐ[411] - 22151;
					continue;
				case 1:
				case 9:
				{
					num++;
					int num3 = 249;
					int num4 = 702;
					int num5 = num3 * 10;
					UtilsNumeric.Ⴀ[363] = (char)((UtilsNumeric.Ⴀ[363] * NeedsCfg.ႣႤ[518]) & 0x98);
					num2 = ((7020 > num4 - num5) ? 7 : (ⴐ[318] - 52882));
					continue;
				}
				case 5:
					num2 = 11;
					continue;
				case 7:
					return result;
				case 6:
				case 10:
					num2 = ⴐ[369] - 52854;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႷႥ(Size P_0, Size P_1, char P_2, short P_3)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		bool result = default(bool);
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
					num2 = 7;
					continue;
				case 7:
					break;
				case 2:
				case 10:
					num2 = (((P_2 ^ P_3) - 125) ^ num) switch
					{
						0 => 3, 
						_ => 6, 
					};
					continue;
				case 6:
					result = true;
					num2 = ⴗ[93] - 716;
					continue;
				case 3:
				case 9:
					result = P_0 == P_1;
					num2 = 1;
					continue;
				case 1:
				case 11:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 5 : (ⴃႤ[439] - 3936));
					continue;
				case 8:
					num2 = ⴐ[140] - 47063;
					continue;
				case 5:
					return result;
				case 0:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႷႤ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : Control
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[452] - 10111;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 9:
					break;
				case 4:
					num2 = (((P_2 ^ P_1) - 40) ^ num) switch
					{
						0 => ⴀ[379] - 40949, 
						_ => ⴐ[318] - 52886, 
					};
					continue;
				case 1:
					result = 15;
					num2 = ⴃႣ[3] - 24463;
					continue;
				case 2:
				case 6:
					result = P_0.Height;
					num2 = 5;
					continue;
				case 5:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 11 : (ⴃႭ[200] - 35125));
					continue;
				case 7:
					num2 = 4;
					continue;
				case 0:
				case 11:
					return result;
				case 3:
				case 10:
					num2 = ⴐ[300] - 16236;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႰ<_0021_00210>(_0021_00210 P_0, Size P_1, short P_2, char P_3) where _0021_00210 : ToolStripItem
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴐ[261] - 25215;
				break;
			case 4:
				num = (((P_2 ^ P_3) - 117) ^ num2) switch
				{
					0 => 0, 
					_ => 2, 
				};
				break;
			case 2:
				num = 7;
				break;
			case 0:
				P_0.Size = P_1;
				goto case 7;
			case 7:
				num2++;
				goto case 6;
			case 6:
			{
				int num3 = 70;
				int num4 = 261;
				int num5 = num4 - num3 * 5;
				DxCfg.Ⴗ[123] = (char)((DxCfg.Ⴗ[123] | NeedsCfg.ႣႤ[346]) & 0x87);
				num = ((1305 > num5) ? 8 : 5);
				break;
			}
			case 5:
				num = ⴐ[99] - 51745;
				break;
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႷႭ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DataGridViewCellPaintingEventArgs
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int result = default(int);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 7:
				case 10:
					num2 = (((P_1 ^ P_2) - 20) ^ num) switch
					{
						0 => 1, 
						_ => 4, 
					};
					continue;
				case 4:
					result = 7;
					num2 = 9;
					continue;
				case 1:
					result = P_0.RowIndex;
					num2 = 9;
					continue;
				case 9:
					num++;
					goto case 5;
				case 5:
					num3 = 3904;
					num4 = 956;
					goto case 0;
				case 0:
					num2 = ((976 < num3 / 4 - num4) ? (ⴃႭ[42] - 25328) : 2);
					continue;
				case 2:
					return result;
				case 8:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte ႷႨ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		byte result = default(byte);
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
					num2 = 3;
					continue;
				case 3:
				case 5:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 112) ^ num) switch
					{
						0 => ⴐ[2] - 52873, 
						_ => 1, 
					};
					continue;
				case 1:
					result = 31;
					num2 = 4;
					continue;
				case 6:
					result = Convert.ToByte(P_0);
					num2 = 4;
					continue;
				case 4:
				{
					num++;
					int num3 = 1748;
					int num4 = 576;
					num2 = ((874 < num3 / 2 - num4) ? (ⴃႤ[418] - 42618) : (ⴃႣ[103] - 47722));
					continue;
				}
				case 2:
				case 8:
				case 10:
					return result;
				case 9:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}
}
