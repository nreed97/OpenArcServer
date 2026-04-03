using System;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Runtime.Serialization;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods;
using ZedGraph;
using Ⴀ;

namespace ArcClientEngine.ArcCfg;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class TelnetServerCfg
{
	private bool Ⴄ;

	private int Ⴅ;

	[Description("Enable the telnet server")]
	public bool Enabled
	{
		get
		{
			char[] ⴗ = ႥႰ.Ⴗ;
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	[Description("Set the telnet server port")]
	public int Port
	{
		get
		{
			int ⴅ = Ⴅ;
			ႥႰ.Ⴗ[45] = (char)(ႥႰ.Ⴗ[45] & ႥႰ.Ⴗ[151] & 0xEF);
			return ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	public TelnetServerCfg()
	{
		Port = 7000;
		Enabled = true;
	}

	public override string ToString()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		return ႥႥ.Ⴅ(1673508588, null, 5);
	}

	[SecuritySafeCritical]
	static TelnetServerCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210>(_0021_00210 P_0, SqlFilterType P_1, char P_2, short P_3) where _0021_00210 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
				{
					/*OpCode not supported: LdMemberToken*/;
					char num5 = ⴗ[60];
					Bye.Ⴄ[183] = (char)((Bye.Ⴄ[183] - UserCmd.Ⴅ[58]) & 0xDD);
					num2 = num5 - 41554;
					continue;
				}
				case 9:
					break;
				case 1:
				case 8:
					num2 = (((P_3 ^ P_2) - 34) ^ num) switch
					{
						0 => 3, 
						_ => ⴅ[17], 
					};
					continue;
				case 0:
					equatable = null;
					num2 = 4;
					continue;
				case 3:
				case 6:
					equatable = UtilsSql.FormatSqlFilter(P_0, P_1);
					num2 = 4;
					continue;
				case 4:
				case 5:
				{
					num++;
					int num3 = 1640;
					int num4 = 307;
					num2 = ((410 < num3 / 4 - num4) ? 8 : 2);
					continue;
				}
				case 2:
					return equatable as string;
				case 10:
					num2 = ⴗ[22] - 14483;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ZedGraph.Label Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : PaneBase
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		ICloneable cloneable = default(ICloneable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[107] - 34909;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[137] - 1365;
					continue;
				case 5:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 59) ^ num) switch
					{
						0 => 4, 
						_ => 11, 
					};
					continue;
				case 11:
					cloneable = null;
					num2 = 9;
					continue;
				case 3:
				case 4:
				case 7:
					cloneable = P_0.Title;
					num2 = 9;
					continue;
				case 9:
					num++;
					num3 = P_1 * P_1;
					goto case 6;
				case 6:
					num3 = P_1 + num3;
					num2 = ⴅ[25];
					continue;
				case 2:
					num2 = ((num3 % 2 != 0) ? (ⴄ[4] - 10471) : ⴅ[17]);
					continue;
				case 0:
					return (ZedGraph.Label)cloneable;
				case 10:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : DataTableCollection where _0021_00211 : DataTable
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႠ[96] - 2579;
				break;
			case 6:
				num = (((P_2 ^ P_3) - 34) ^ num2) switch
				{
					0 => 9, 
					_ => 0, 
				};
				break;
			case 0:
				num = ⴀႠ[34] - 62556;
				break;
			case 3:
			case 9:
				P_0.Add(P_1);
				goto case 8;
			case 8:
			{
				num2++;
				int num3 = 592;
				int num4 = 768;
				num = ((4608 > num4 - num3 * 6) ? 1 : 4);
				break;
			}
			case 4:
			case 7:
				num = 6;
				break;
			case 1:
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static AxisLabel Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : Axis
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		ISerializable serializable = default(ISerializable);
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
					num2 = 7;
					continue;
				case 7:
					break;
				case 11:
					num2 = (((P_1 ^ P_2) - 27) ^ num) switch
					{
						0 => ⴗ[48] - 52956, 
						_ => 2, 
					};
					continue;
				case 2:
					serializable = null;
					goto case 6;
				case 6:
					num2 = ⴄ[248] - 4574;
					continue;
				case 5:
					serializable = P_0.Title;
					num2 = ⴗ[24] - 32650;
					continue;
				case 0:
				case 3:
				{
					num++;
					int num3 = 592;
					int num4 = 768;
					num2 = ((4608 > num4 - num3 * 6) ? 4 : (ⴗ[37] - 54920));
					continue;
				}
				case 1:
					num2 = 11;
					continue;
				case 4:
					return (AxisLabel)serializable;
				case 10:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴈ(ref DateTime P_0, double P_1, int P_2, int P_3)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		DateTime dateTime = default(DateTime);
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
					num2 = 0;
					continue;
				case 0:
					break;
				case 11:
				{
					int num4 = P_3 ^ P_2;
					Bye.Ⴄ[103] = (char)((Bye.Ⴄ[103] ^ P_3) & 0xC3);
					num2 = ((num4 - 96) ^ num) switch
					{
						0 => 1, 
						1 => ⴅ[318] - ⴅ[219], 
						_ => 4, 
					};
					continue;
				}
				case 4:
					dateTime = default(DateTime);
					goto case 10;
				case 10:
					result = dateTime;
					num2 = ⴗ[119] - 30790;
					continue;
				case 1:
					result = P_0.AddHours(P_1);
					goto case 6;
				case 6:
					num2 = 7;
					continue;
				case 9:
					result = P_0.AddMinutes(P_1);
					num2 = 7;
					continue;
				case 7:
				{
					num++;
					int num3 = 905;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? ⴅ[285] : (ⴅ[36] - 39));
					continue;
				}
				case 12:
					num2 = 11;
					continue;
				case 5:
					return result;
				case 2:
				case 3:
					num2 = ⴗ[6] - 61622;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210>(_0021_00210 P_0, DialogResult P_1, int P_2, short P_3) where _0021_00210 : Form
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴅ[332] - ⴅ[185];
				continue;
			case 5:
			case 7:
				num = (((P_2 ^ P_3) - 23) ^ num2) switch
				{
					0 => ⴗ[6] - 61625, 
					_ => 4, 
				};
				continue;
			case 4:
				num = ⴄ[244] - 46903;
				continue;
			case 8:
				P_0.DialogResult = P_1;
				break;
			case 3:
				break;
			case 1:
			case 2:
				return;
			}
			num2++;
			int num3 = 1704;
			int num4 = 168;
			num = ((426 < num3 / 4 - num4) ? 5 : (ⴄ[193] - 25243));
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DataGridViewColumn
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		IConvertible convertible = default(IConvertible);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[107] - 34903;
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
				case 7:
					num2 = (((P_1 ^ P_2) - 34) ^ num) switch
					{
						0 => ⴅ[25], 
						_ => 6, 
					};
					continue;
				case 1:
				case 6:
					convertible = null;
					num2 = 4;
					continue;
				case 2:
					convertible = P_0.DataPropertyName;
					num2 = ⴗ[140] - 60681;
					continue;
				case 4:
					num++;
					goto case 8;
				case 8:
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 10;
				case 10:
					num2 = 5;
					continue;
				case 5:
					num2 = ((num3 % 2 != 0) ? 7 : (ⴗ[66] - 45151));
					continue;
				case 3:
					return convertible as string;
				case 11:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, char P_3) where _0021_00210 : AnnWxSpot where _0021_00211 : string
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 6;
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
				num = (((P_3 ^ P_2) - 50) ^ num2) switch
				{
					0 => 1, 
					_ => ⴅ[115], 
				};
				break;
			case 4:
				num = ⴄ[205] - 14638;
				break;
			case 1:
			case 3:
				P_0.DeserializeClient(P_1);
				goto case 7;
			case 7:
			case 9:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 != 0) ? (ⴄ[294] - 26153) : 0);
				break;
			case 5:
				num = 2;
				break;
			case 0:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႳႷ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : SoundPlayer
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႠ[128] - 34412;
				break;
			case 9:
				num = (((P_1 ^ P_2) - 22) ^ num2) switch
				{
					0 => ⴀႠ[112] - 45130, 
					_ => 6, 
				};
				break;
			case 6:
				num = ⴀႠ[0] - 49949;
				break;
			case 4:
			case 7:
				P_0.PlaySync();
				goto case 2;
			case 2:
			case 8:
				num2++;
				goto case 1;
			case 1:
				num = (((P_1 * P_1 + P_1) % 2 != 0) ? 5 : 0);
				break;
			case 5:
				num = 9;
				break;
			case 0:
				return;
			}
		}
	}
}
