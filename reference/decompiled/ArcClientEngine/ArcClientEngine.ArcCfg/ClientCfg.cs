using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using Ⴀ;

namespace ArcClientEngine.ArcCfg;

[XmlRoot("ArcClient")]
public sealed class ClientCfg : BaseXmlSerializer
{
	private UserInfo Ⴈ;

	private FilterCfg Ⴃ;

	private DxEmailCfg Ⴈ;

	private FilterEditor.ႷႼ m_Ⴄ = new FilterEditor.ႷႼ();

	[Description("Callsign")]
	public string Call
	{
		get
		{
			byte[] ⴅ = UserCmd.Ⴅ;
			return this.m_Ⴄ.Ⴐ;
		}
		set
		{
			this.m_Ⴄ.Ⴐ = value as string;
		}
	}

	[Description("Alias")]
	public string Alias
	{
		get
		{
			string ⴓ = this.m_Ⴄ.Ⴓ;
			ႥႰ.Ⴗ[30] = (char)((ႥႰ.Ⴗ[30] * ႥႰ.Ⴗ[112]) & 0xF3);
			return ⴓ;
		}
		set
		{
			this.m_Ⴄ.Ⴓ = value;
		}
	}

	[Description("Copyright info")]
	public LegalCfg Legal
	{
		get
		{
			byte[] ⴅ = UserCmd.Ⴅ;
			return this.m_Ⴄ.Ⴍ;
		}
		set
		{
			this.m_Ⴄ.Ⴍ = value;
		}
	}

	[Description("User Configuration")]
	public UserInfo Info
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return this.Ⴈ;
		}
		set
		{
			this.Ⴈ = value;
		}
	}

	[Description("Spot filters.")]
	public FilterCfg Filters
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	[Description("Email")]
	public DxEmailCfg DxEmail
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			DxEmailCfg ⴈ = Ⴈ;
			Bye.Ⴄ[150] = (char)((Bye.Ⴄ[150] * Bye.Ⴄ[19]) & 0xE5);
			return ⴈ;
		}
		set
		{
			Ⴈ = value;
		}
	}

	[Description("Cty")]
	public ClientCty Cty
	{
		get
		{
			return this.m_Ⴄ.Ⴀ;
		}
		set
		{
			this.m_Ⴄ.Ⴀ = value;
		}
	}

	[Description("Automatically update node connection list")]
	public bool AutoUpdateConnects
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return this.m_Ⴄ.Ⴃ;
		}
		set
		{
			bool ⴃ = value;
			this.m_Ⴄ.Ⴃ = ⴃ;
		}
	}

	[Description("Telnet server for connection from your DX and contesting programs.")]
	public TelnetServerCfg TelnetServer
	{
		get
		{
			char[] ⴗ = ႥႰ.Ⴗ;
			TelnetServerCfg ⴈ = this.m_Ⴄ.Ⴈ;
			ႥႰ.Ⴗ[64] = (char)((ႥႰ.Ⴗ[64] - ႥႰ.Ⴗ[74]) & 0xC4);
			return ⴈ;
		}
		set
		{
			this.m_Ⴄ.Ⴈ = value as TelnetServerCfg;
		}
	}

	[Description("Multimedia")]
	public MultimediaCfg Multimedia
	{
		get
		{
			MultimediaCfg ⴄ = this.m_Ⴄ.Ⴄ;
			ႥႰ.Ⴗ[33] = (char)((ႥႰ.Ⴗ[33] - ႥႰ.Ⴗ[58]) & 0x63);
			return ⴄ;
		}
		set
		{
			this.m_Ⴄ.Ⴄ = value as MultimediaCfg;
		}
	}

	public ClientCfg()
	{
		Alias = string.Empty;
		Cty = new ClientCty();
		Legal = new LegalCfg();
		Filters = new FilterCfg();
		Info = new UserInfo();
		TelnetServer = new TelnetServerCfg();
		Multimedia = new MultimediaCfg();
		DxEmail = new DxEmailCfg();
		AutoUpdateConnects = false;
	}

	public static ClientCfg Init()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		object obj = default(object);
		BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
		while (true)
		{
			_Assembly assembly = WxFilters.ႭႭ(768, 811);
			IComparable comparable = HighlightCfg.ႳႳ(ႥႠ.Ⴅ((Assembly)assembly, 308, 264), 'ư', 476);
			int num = ⴅ[17] * 5;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴗ[143] - 39698;
					continue;
				case 6:
				case 7:
					break;
				case 0:
					obj = DxFilters.Ⴈ((string)comparable, ClientCty.Ⴗ('Ë', 5, 307011920), 898, 986);
					num = 1;
					continue;
				case 1:
					baseXmlSerializer = new ClientCfg();
					num = ((!DxSpotRates.ႠႼ((string)obj, '\u0016', '\v')) ? (ⴗ[28] - 37806) : 4);
					continue;
				case 4:
					baseXmlSerializer = (ClientCfg)BaseXmlSerializer.LoadFromFile((baseXmlSerializer as ClientCfg).GetType(), obj as string);
					num = 3;
					continue;
				case 2:
				case 9:
					((ClientCfg)baseXmlSerializer).Ⴀ();
					goto case 8;
				case 8:
					(baseXmlSerializer as ClientCfg).SaveToFile((string)obj);
					goto case 3;
				case 3:
					return baseXmlSerializer as ClientCfg;
				}
				break;
			}
		}
	}

	private void Ⴀ()
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				Call = ႥႥ.Ⴍ(6, 1580608444, '\u0086', null);
				Info.Ⴍ();
				goto IL_003e;
			case 3:
				goto IL_003e;
			case 2:
				Filters.Ⴄ();
				break;
			case 4:
				break;
			case 0:
				return;
			}
			break;
			IL_003e:
			num = 2;
		}
		Multimedia.Ⴐ();
		DxEmail.Ⴗ();
		Cty.Ⴍ();
	}

	internal void Ⴓ()
	{
		int num = 2;
		IConvertible convertible = default(IConvertible);
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001e;
			case 1:
			case 3:
				convertible = (string)equatable + ClientCty.Ⴗ('Ê', 0, 307011925);
				break;
			case 0:
			case 4:
				break;
			}
			break;
			IL_001e:
			_Assembly assembly = WxFilters.ႭႭ(57, 18);
			equatable = HighlightCfg.ႳႳ(ႥႠ.Ⴅ(assembly as Assembly, 964, 1016), 'Z', 54);
			num = 3;
		}
		SaveToFile((string)convertible);
	}

	[SecuritySafeCritical]
	static ClientCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static Color Ⴍ(int P_0, int P_1)
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		Color result = default(Color);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[123] - 61747;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 7:
				case 9:
					break;
				case 4:
					num2 = (((P_0 ^ P_1) - 108) ^ num) switch
					{
						0 => 2, 
						1 => 6, 
						_ => 8, 
					};
					continue;
				case 8:
					result = default(Color);
					num2 = 1;
					continue;
				case 2:
				case 5:
					result = Color.White;
					num2 = 1;
					continue;
				case 6:
				{
					result = Color.YellowGreen;
					byte num5 = ⴅ[173];
					ႥႰ.Ⴗ[4] = (char)((ႥႰ.Ⴗ[4] - P_0) & 0x35);
					num2 = num5 - 129;
					continue;
				}
				case 1:
				case 11:
				{
					num++;
					int num3 = 194;
					int num4 = 17;
					num2 = ((97 < num3 / 2 - num4) ? 4 : 10);
					continue;
				}
				case 10:
					return result;
				case 0:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : TreeNodeCollection
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 5;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴗ[37] - 54917;
				break;
			case 4:
				num = (((P_1 ^ P_2) - 74) ^ num2) switch
				{
					0 => ⴄ[239] - 49129, 
					_ => 0, 
				};
				break;
			case 0:
				num = 2;
				break;
			case 6:
				P_0.Clear();
				goto case 2;
			case 2:
				num2++;
				goto case 8;
			case 8:
				num3 = 98;
				goto case 7;
			case 7:
			{
				int num4 = 129;
				num = ((903 > num4 - num3 * 7) ? (ⴄ[214] - 20668) : 9);
				break;
			}
			case 1:
			case 9:
				num = 4;
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴅ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : DataGridViewColumnCollection where _0021_00211 : DataGridViewColumn
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int result = default(int);
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
					num2 = 1;
					continue;
				case 1:
					break;
				case 10:
					num2 = (((P_3 ^ P_2) - 114) ^ num) switch
					{
						0 => 3, 
						_ => ⴄ[236] - 11654, 
					};
					continue;
				case 4:
					result = 3;
					num2 = 0;
					continue;
				case 3:
					result = P_0.Add(P_1);
					num2 = ⴀႠ[97] - 35002;
					continue;
				case 0:
					num++;
					num3 = 652;
					goto case 5;
				case 5:
				{
					int num4 = 921;
					num2 = ((4605 > num4 - num3 * 5) ? (ⴄ[287] - 27264) : 2);
					continue;
				}
				case 2:
				case 6:
					num2 = 10;
					continue;
				case 9:
					return result;
				case 7:
				case 8:
					num2 = ⴀႠ[58] - 24323;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataGridViewRowCollection Ⴜ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : DataGridView
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[116] - 60583;
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
				case 3:
					HighlightCtyCfg.ႠႠ[77] = (char)((HighlightCtyCfg.ႠႠ[77] | P_2) & 0x8A);
					num2 = (((P_1 ^ P_2) - 10) ^ num) switch
					{
						0 => ⴅ[17], 
						_ => 8, 
					};
					continue;
				case 8:
					obj = null;
					num2 = 4;
					continue;
				case 0:
					obj = P_0.Rows;
					num2 = 4;
					continue;
				case 4:
					num++;
					goto case 6;
				case 6:
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 2 : 10);
					continue;
				case 7:
				case 10:
					num2 = ⴅ[157] / 7;
					continue;
				case 2:
					return (DataGridViewRowCollection)obj;
				case 1:
				case 11:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႭႷ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, char P_3) where _0021_00210 : DataGridViewBand
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႠ[78] - 14985;
				break;
			case 5:
				num = (((P_2 ^ P_3) - 24) ^ num2) switch
				{
					0 => ⴄ[249] - 5085, 
					_ => 6, 
				};
				break;
			case 6:
			case 8:
				num = 1;
				break;
			case 2:
			case 7:
				P_0.Visible = P_1;
				goto case 1;
			case 1:
			case 4:
			{
				num2++;
				int num3 = 37;
				int num4 = 862;
				Bye.Ⴄ[200] = (char)((Bye.Ⴄ[200] + HighlightCtyCfg.ႠႠ[105]) & 0xAB);
				num = ((3448 > num4 - num3 * 4) ? 3 : (ⴄ[110] - 60796));
				break;
			}
			case 0:
				num = 5;
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႭႭ<_0021_00210>(_0021_00210 P_0, DataGridViewColumnSortMode P_1, char P_2, char P_3) where _0021_00210 : DataGridViewColumn
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 0;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴀႠ[108] - 45134;
				break;
			case 9:
				num = (((P_2 ^ P_3) - 48) ^ num3) switch
				{
					0 => 3, 
					_ => 6, 
				};
				break;
			case 6:
				num = 1;
				break;
			case 2:
			case 3:
				P_0.SortMode = P_1;
				goto case 1;
			case 1:
				num3++;
				goto case 8;
			case 8:
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 5;
				break;
			case 5:
				num = ((num2 % 2 != 0) ? (ⴅ[154] - 209) : 4);
				break;
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႭႠ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		IEquatable<string> equatable = default(IEquatable<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[147] - 45879;
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
				case 1:
					num2 = (((P_2 ^ P_3) - 51) ^ num) switch
					{
						0 => ⴄ[250] - 29555, 
						_ => 5, 
					};
					continue;
				case 5:
					equatable = null;
					num2 = ⴄ[201] - 44569;
					continue;
				case 9:
					equatable = string.Concat(P_0, P_1);
					num2 = 6;
					continue;
				case 6:
					num++;
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					goto case 7;
				case 7:
					num2 = ⴗ[130] - 30828;
					continue;
				case 4:
				case 11:
					num2 = ((num3 % 2 != 0) ? (ⴄ[154] - 60842) : (ⴄ[277] - 52010));
					continue;
				case 8:
					return equatable as string;
				case 0:
				case 2:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}
}
