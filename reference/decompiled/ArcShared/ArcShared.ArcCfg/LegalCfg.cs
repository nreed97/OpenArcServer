using System;
using System.ComponentModel;
using System.Data;
using System.Security;
using System.Windows.Forms;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using Ⴃ;

namespace ArcShared.ArcCfg;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class LegalCfg
{
	internal sealed class Ⴓ
	{
		internal IContainer Ⴃ;

		internal ComboBox Ⴈ;

		internal Ⴓ()
		{
		}
	}

	private string Ⴈ;

	private string Ⴗ;

	private UnZipFiles.Ⴐ m_Ⴃ = new UnZipFiles.Ⴐ();

	[ReadOnly(true)]
	[Description("AR-Cluster version")]
	public string Version
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			return this.m_Ⴃ.Ⴓ;
		}
		set
		{
			this.m_Ⴃ.Ⴓ = value;
		}
	}

	[ReadOnly(true)]
	[Description("AR-Cluster author")]
	public string Author
	{
		get
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			return this.m_Ⴃ.Ⴗ;
		}
		set
		{
			this.m_Ⴃ.Ⴗ = value;
		}
	}

	[ReadOnly(true)]
	[Description("AR-Cluster company")]
	public string Company
	{
		get
		{
			return Ⴈ;
		}
		set
		{
			Ⴈ = value;
		}
	}

	[ReadOnly(true)]
	[Description("AR-Cluster copywrite")]
	public string Copyright
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

	public LegalCfg()
	{
		Version = UtilsVersion.ShortVersion;
		Author = ႣႼ.ႥႭ(null, 624735504, 3, null);
		Company = UtilsString.Ⴐ(null, 8, 192632200);
		Copyright = UtilsCopyright.Copyright;
	}

	public override string ToString()
	{
		return TelnetServerClient.Ⴄ(1945322958, 'ö', 7);
	}

	[SecuritySafeCritical]
	static LegalCfg()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : CheckBox where _0021_00211 : EventHandler
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႣ[28] - 41385;
				continue;
			case 5:
				num = (((P_3 ^ P_2) - 106) ^ num2) switch
				{
					0 => 2, 
					_ => 3, 
				};
				continue;
			case 3:
				num = 0;
				continue;
			case 2:
				P_0.CheckStateChanged += P_1;
				break;
			case 0:
			case 7:
				break;
			case 4:
			case 6:
			case 8:
				return;
			}
			num2++;
			int num3 = 1502;
			int num4 = 408;
			num = ((751 < num3 / 2 - num4) ? (ⴃႣ[12] - 27345) : (ⴃႣ[181] - 42043));
		}
	}

	[SecuritySafeCritical]
	internal static DataColumn Ⴅ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : string where _0021_00211 : DataColumnCollection
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		MarshalByValueComponent marshalByValueComponent = default(MarshalByValueComponent);
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
					num2 = ⴗ[93] - 708;
					continue;
				case 9:
					break;
				case 2:
					num2 = (((P_3 ^ P_2) - 80) ^ num) switch
					{
						0 => 10, 
						_ => 7, 
					};
					continue;
				case 3:
				case 7:
					marshalByValueComponent = null;
					num2 = ⴐ[320] - 49926;
					continue;
				case 10:
					marshalByValueComponent = P_0[P_1];
					num2 = 1;
					continue;
				case 1:
				case 6:
				{
					num++;
					int num3 = 3552;
					int num4 = 434;
					num2 = ((888 < num3 / 4 - num4) ? (ⴀ[371] - 3280) : 8);
					continue;
				}
				case 5:
				case 8:
					return marshalByValueComponent as DataColumn;
				case 0:
					num2 = ⴗ[115] - 18168;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, ToolStripItemAlignment P_1, char P_2, short P_3) where _0021_00210 : ToolStripItem
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 3;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				break;
			case 5:
				num = (((P_3 ^ P_2) - 61) ^ num2) switch
				{
					0 => 9, 
					_ => 0, 
				};
				break;
			case 0:
			{
				char num5 = ⴀ[154];
				UtilsNumeric.Ⴀ[14] = (char)((UtilsNumeric.Ⴀ[14] - UtilsNumeric.Ⴀ[383]) & 0xBB);
				num = num5 - 28010;
				break;
			}
			case 9:
				P_0.Alignment = P_1;
				goto case 4;
			case 4:
			case 7:
				num2++;
				num3 = 308;
				goto case 2;
			case 2:
			case 8:
			{
				int num4 = 725;
				num = ((5075 > num4 - num3 * 7) ? (ⴃႣ[102] - 27328) : 6);
				break;
			}
			case 6:
				num = ⴀ[17] - 63639;
				break;
			case 1:
				return;
			}
		}
	}
}
