using System;
using System.ComponentModel;
using System.Reflection;
using System.Security;
using System.Xml;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter.Implementations;

namespace ArcShared.ArcCfg;

public sealed class ArcUserCfg
{
	internal sealed class Ⴜ
	{
		internal string Ⴀ;

		internal string Ⴃ;

		internal string Ⴓ;

		internal string Ⴅ;

		internal string Ⴄ;

		internal Ⴜ()
		{
		}
	}

	private string Ⴀ;

	private AnnCfg Ⴍ;

	private StationCfg Ⴀ;

	private TalkCfg Ⴃ;

	private WxCfg Ⴄ;

	private DateTime Ⴓ;

	private bool Ⴗ;

	private DgvTextBoxColumnFilter.Ⴀ m_Ⴈ = new DgvTextBoxColumnFilter.Ⴀ();

	[Description("Your amateur radio callsign.  This is the callsign used to log into the DX-Cluster.  You can also use a options SSID (like K5ABC-5) where you can save other profiles.")]
	[Category("Callsign")]
	public string Call
	{
		get
		{
			return this.Ⴀ;
		}
		set
		{
			this.Ⴀ = value;
		}
	}

	public AnnCfg Ann
	{
		get
		{
			return Ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	public DxCfg Dx
	{
		get
		{
			DxCfg ⴃ = this.m_Ⴈ.Ⴃ;
			DxCfg.Ⴗ[37] = (char)((DxCfg.Ⴗ[37] | DxCfg.Ⴗ[91]) & 0xA8);
			return ⴃ;
		}
		set
		{
			this.m_Ⴈ.Ⴃ = value as DxCfg;
			TalkCfg.ႣႣ[108] = (char)((TalkCfg.ႣႣ[108] ^ TalkCfg.ႣႣ[3]) & 0x7A);
		}
	}

	public StationCfg Station
	{
		get
		{
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	public TalkCfg Talk
	{
		get
		{
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	public WxCfg Wx
	{
		get
		{
			WxCfg ⴄ = Ⴄ;
			DxCfg.Ⴗ[14] = (char)((DxCfg.Ⴗ[14] - DxCfg.Ⴗ[35]) & 0xF);
			return ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	public WwvCfg Wwv
	{
		get
		{
			return this.m_Ⴈ.Ⴐ;
		}
		set
		{
			this.m_Ⴈ.Ⴐ = value as WwvCfg;
		}
	}

	[Browsable(false)]
	public DateTime LogoutDateTime
	{
		get
		{
			return Ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	[Browsable(false)]
	public bool LoginAnnouncements
	{
		get
		{
			return Ⴗ;
		}
		set
		{
			Ⴗ = value;
		}
	}

	public ArcUserCfg()
	{
		Ann = new AnnCfg();
		Dx = new DxCfg();
		Station = new StationCfg();
		Talk = new TalkCfg();
		Wx = new WxCfg();
		Wwv = new WwvCfg();
	}

	[SecuritySafeCritical]
	static ArcUserCfg()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static bool Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : XmlReader
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႭ[95] - 32047;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 0:
				case 7:
					break;
				case 2:
				case 10:
				case 11:
					num2 = (((P_2 ^ P_1) - 45) ^ num) switch
					{
						0 => ⴃႤ[178] - 25811, 
						_ => ⴃႣ[21] - 1868, 
					};
					continue;
				case 4:
					result = true;
					num2 = 8;
					continue;
				case 1:
					result = P_0.Read();
					num2 = ⴐ[89] - 28938;
					continue;
				case 8:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = ⴀ[302] - 55858;
					continue;
				case 5:
					num2 = ((num3 % 2 != 0) ? (ⴃႣ[15] - 18739) : (ⴃႣ[19] - 59485));
					continue;
				case 6:
					return result;
				case 3:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime ႠႳ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		DateTime result = default(DateTime);
		int num3 = default(int);
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
					num2 = ⴀ[235] - 17182;
					continue;
				case 5:
					break;
				case 6:
					num2 = (((P_1 ^ P_2) - 86) ^ num) switch
					{
						0 => 8, 
						_ => ⴐ[29] - 63468, 
					};
					continue;
				case 3:
				case 9:
					result = default(DateTime);
					num2 = 0;
					continue;
				case 8:
				{
					result = DateTime.Parse(P_0);
					int num5 = ⴃႤ[106];
					int num6 = ⴃႤ[106];
					DataGridViewColumnSelector.Ⴐ[406] = (char)((DataGridViewColumnSelector.Ⴐ[406] ^ NeedsCfg.ႣႤ[545]) & 0x7A);
					num2 = num5 - num6;
					continue;
				}
				case 0:
					num++;
					num3 = 67;
					goto case 4;
				case 4:
				{
					int num4 = 219;
					num2 = ((1752 > num4 - num3 * 8) ? (ⴃႭ[241] - 11618) : 11);
					continue;
				}
				case 1:
				case 11:
					num2 = ⴃႤ[11] - 38447;
					continue;
				case 10:
					return result;
				case 2:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte ႠႠ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DxSpot
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
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
					num2 = ⴃႤ[192] - 53091;
					continue;
				case 5:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 123) ^ num) switch
					{
						0 => 6, 
						_ => ⴗ[75] - ⴗ[75], 
					};
					continue;
				case 0:
					result = 11;
					num2 = ⴐ[84] - 25860;
					continue;
				case 6:
					result = P_0.SkimDb;
					num2 = 2;
					continue;
				case 1:
				case 2:
				case 9:
					num++;
					goto case 8;
				case 8:
				{
					int num3 = 1524;
					int num4 = 613;
					num2 = ((762 < num3 / 2 - num4) ? (ⴃႣ[214] - 56059) : 4);
					continue;
				}
				case 4:
					return result;
				case 10:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႣ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, char P_3) where _0021_00210 : DxSpot where _0021_00211 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 9;
				break;
			case 9:
				num = (((P_2 ^ P_3) - 125) ^ num2) switch
				{
					0 => 2, 
					1 => 6, 
					_ => 10, 
				};
				break;
			case 10:
				num = 7;
				break;
			case 1:
			case 2:
			case 8:
				P_0.State = P_1;
				num = ⴃႤ[428] - 59855;
				break;
			case 3:
			case 6:
				P_0.ArrlSection = P_1;
				goto case 7;
			case 7:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? 4 : (ⴐ[527] - ⴐ[527]));
				break;
			case 0:
				num = 9;
				break;
			case 4:
				DxCfg.Ⴗ[13] = (char)((DxCfg.Ⴗ[13] | P_2) & 0xA4);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type ႠႭ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		MemberInfo memberInfo = default(MemberInfo);
		int num4 = default(int);
		int num3 = default(int);
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
					num2 = 2;
					continue;
				case 2:
					break;
				case 6:
					num2 = (((P_1 ^ P_2) - 122) ^ num) switch
					{
						0 => 8, 
						_ => 4, 
					};
					continue;
				case 4:
					memberInfo = typeof(DgvFilterHost);
					num2 = 5;
					continue;
				case 7:
				case 8:
				{
					memberInfo = P_0.GetType();
					char num6 = ⴃႣ[127];
					NeedsCfg.ႣႤ[112] = (NeedsCfg.ႣႤ[112] - P_2) & 0xC8;
					num2 = num6 - 15237;
					continue;
				}
				case 5:
				case 10:
					num++;
					goto case 11;
				case 11:
				{
					num4 = 1000;
					int num5 = num4;
					num3 = num5 * num5;
					num2 = 9;
					continue;
				}
				case 9:
					num3 = num4 + num3;
					num2 = ((num3 % 2 != 0) ? 6 : (ⴐ[27] - 39552));
					continue;
				case 1:
					return memberInfo as Type;
				case 0:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}
}
