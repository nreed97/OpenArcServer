using System;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.VisualBasic.PowerPacks;

namespace ArcShared.DgvUtils.DgvFilter;

public sealed class ColumnFilterEventArgs : EventArgs
{
	private DataGridViewColumn Ⴄ;

	private DgvBaseColumnFilter Ⴃ;

	private bool Ⴐ;

	public DataGridViewColumn Column
	{
		get
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			return Ⴄ;
		}
	}

	public DgvBaseColumnFilter ColumnFilter
	{
		get
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	public bool Handled
	{
		get
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			return Ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	public ColumnFilterEventArgs(DataGridViewColumn Column, DgvBaseColumnFilter ColumnFilter)
	{
		Ⴄ = Column;
		Ⴃ = ColumnFilter;
		Ⴐ = Handled;
	}

	[SecuritySafeCritical]
	static ColumnFilterEventArgs()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static bool Ⴀ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႭ[197] - 28505;
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
				case 6:
					num2 = (((P_2 ^ P_3) - 79) ^ num) switch
					{
						0 => ⴃႤ[210] - 27394, 
						1 => ⴃႤ[532] - 51861, 
						_ => ⴀ[181] - ⴀ[181], 
					};
					continue;
				case 0:
					result = false;
					num2 = 4;
					continue;
				case 2:
					result = P_0 != P_1;
					num2 = 4;
					continue;
				case 3:
				case 5:
					result = Regex.IsMatch(P_0, P_1);
					num2 = 4;
					continue;
				case 4:
				{
					num++;
					int num3 = 845;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? 9 : (ⴃႤ[305] - 20870));
					continue;
				}
				case 11:
					num2 = ⴃႭ[49] - 57583;
					continue;
				case 1:
				case 9:
					return result;
				case 10:
				case 12:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataTable Ⴈ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DataView
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		IXmlSerializable xmlSerializable = default(IXmlSerializable);
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
					num2 = ⴃႣ[90] - 40891;
					continue;
				case 1:
					break;
				case 6:
				case 10:
					num2 = (((P_2 ^ P_1) - 66) ^ num) switch
					{
						0 => 8, 
						_ => 2, 
					};
					continue;
				case 2:
				case 4:
					xmlSerializable = null;
					goto case 9;
				case 9:
					num2 = ⴗ[139] - 41092;
					continue;
				case 8:
					xmlSerializable = P_0.Table;
					num2 = ⴀ[411] - ⴀ[411];
					continue;
				case 0:
				{
					num++;
					int num3 = 636;
					int num4 = 52;
					num2 = ((212 < num3 / 3 - num4) ? (ⴃႭ[125] - 56408) : 5);
					continue;
				}
				case 5:
					return xmlSerializable as DataTable;
				case 7:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int result = default(int);
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
					num2 = ⴀ[221] - 59519;
					continue;
				case 10:
					break;
				case 6:
				case 9:
					num2 = (((P_2 ^ P_3) - 5) ^ num) switch
					{
						0 => 2, 
						1 => 3, 
						_ => 0, 
					};
					continue;
				case 0:
					result = P_3;
					num2 = 7;
					continue;
				case 1:
				case 2:
					result = P_0.IndexOf(P_1);
					num2 = 7;
					continue;
				case 3:
					result = P_0.LastIndexOf(P_1);
					num2 = 7;
					continue;
				case 7:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႣ[196] - 52696) : 12);
					continue;
				case 12:
					num2 = 9;
					continue;
				case 4:
					return result;
				case 8:
				case 11:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static EndPoint Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : Socket
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[181] - 42050;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 0:
				case 5:
				case 9:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 22) ^ num) switch
					{
						0 => 10, 
						_ => ⴗ[42] - 36999, 
					};
					continue;
				case 7:
					obj = null;
					goto case 2;
				case 2:
					num2 = 8;
					continue;
				case 10:
					obj = P_0.RemoteEndPoint;
					num2 = 8;
					continue;
				case 8:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴀ[230] - 37252) : (ⴃႣ[184] - 34376));
					continue;
				case 4:
					num2 = 1;
					continue;
				case 3:
					return (EndPoint)obj;
				case 11:
					num2 = ⴃႤ[344] - 26233;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DataGridViewCellMouseEventArgs
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int result = default(int);
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
					num2 = ⴃႭ[167] - 37748;
					continue;
				case 5:
					break;
				case 1:
				case 3:
				case 7:
				{
					int num5 = P_1 ^ P_2;
					WxCfg.ႣႭ[41] = (char)((WxCfg.ႣႭ[41] - P_2) & 0xCF);
					num2 = ((num5 - 83) ^ num) switch
					{
						0 => ⴗ[148] - 25095, 
						1 => ⴃႭ[209] - 32127, 
						_ => 8, 
					};
					continue;
				}
				case 8:
					result = P_1;
					num2 = 0;
					continue;
				case 11:
					result = P_0.RowIndex;
					num2 = 0;
					continue;
				case 9:
					result = P_0.ColumnIndex;
					num2 = 0;
					continue;
				case 0:
					num++;
					num3 = 2600;
					goto case 2;
				case 2:
				{
					int num4 = 226;
					num2 = ((650 < num3 / 4 - num4) ? (ⴐ[6] - 53047) : (ⴀ[198] - 33770));
					continue;
				}
				case 10:
					return result;
				case 4:
					num2 = ⴃႤ[402] - 56112;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : ZipEntry
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		IEquatable<string> equatable = default(IEquatable<string>);
		int num3 = default(int);
		int num4 = default(int);
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
					num2 = 7;
					continue;
				case 7:
					break;
				case 9:
					num2 = (((P_1 ^ P_2) - 83) ^ num) switch
					{
						0 => 1, 
						_ => 4, 
					};
					continue;
				case 4:
				case 5:
					equatable = null;
					num2 = 0;
					continue;
				case 1:
					equatable = P_0.Name;
					num2 = ⴐ[408] - 38793;
					continue;
				case 0:
				case 2:
					num++;
					num3 = 68;
					num4 = 107;
					goto case 10;
				case 10:
					num2 = ((535 > num4 - num3 * 5) ? 6 : (ⴃႭ[101] - 25682));
					continue;
				case 8:
					num2 = 9;
					continue;
				case 6:
					return equatable as string;
				case 11:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, short P_3) where _0021_00210 : Shape where _0021_00211 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 6;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴃႤ[76] - 33766;
				break;
			case 3:
				num = (((P_2 ^ P_3) - 123) ^ num3) switch
				{
					0 => ⴀ[234] - 32551, 
					_ => ⴃႤ[240] - 1521, 
				};
				break;
			case 4:
				num = 0;
				break;
			case 1:
			case 5:
			case 8:
				P_0.Name = P_1;
				goto case 0;
			case 0:
				num3++;
				goto case 2;
			case 2:
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = 9;
				break;
			case 9:
				num = ((num2 % 2 != 0) ? 3 : 7);
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႨႠ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : BindingSource
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[36] - 7447;
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
				case 10:
				case 11:
					num2 = (((P_2 ^ P_1) - 60) ^ num) switch
					{
						0 => ⴀ[179] - 61955, 
						_ => ⴃႤ[90] - 11452, 
					};
					continue;
				case 3:
					comparable = null;
					num2 = 9;
					continue;
				case 1:
					comparable = P_0.Filter;
					num2 = ⴃႤ[210] - 27387;
					continue;
				case 4:
				case 9:
				{
					num++;
					int num3 = 241;
					int num4 = 780;
					num2 = ((2340 > num4 - num3 * 3) ? (ⴃႭ[177] - 31781) : 2);
					continue;
				}
				case 2:
					num2 = 7;
					continue;
				case 0:
					return comparable as string;
				case 8:
					num2 = ⴐ[237] - 23088;
					continue;
				}
				break;
			}
		}
	}
}
