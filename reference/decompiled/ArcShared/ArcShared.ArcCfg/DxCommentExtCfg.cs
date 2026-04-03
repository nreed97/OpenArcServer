using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using System.Xml.Linq;
using ArcInterfaces.Io;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.ExtensionMethods.Objects;

namespace ArcShared.ArcCfg;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class DxCommentExtCfg
{
	[StructLayout(LayoutKind.Auto)]
	internal struct ႷႰ
	{
		internal string Ⴀ;
	}

	private bool Ⴐ;

	private bool Ⴈ;

	private bool Ⴃ;

	private bool Ⴓ;

	private bool Ⴍ;

	private bool Ⴗ;

	private bool Ⴀ;

	private bool Ⴄ;

	private bool Ⴜ;

	private bool ႰႨ;

	private bool ႰႳ;

	private bool ႰႭ;

	private ObjectCopierExt.Ⴃ ႥႷ = new ObjectCopierExt.Ⴃ();

	[Description("Optional display of the CqZone in the spot comment if there is room.")]
	public bool CqZone
	{
		get
		{
			return ႥႷ.Ⴅ;
		}
		set
		{
			bool ⴅ = value;
			ႥႷ.Ⴅ = ⴅ;
			NeedsCfg.ႣႤ[246] = (NeedsCfg.ႣႤ[246] | UtilsNumeric.Ⴀ[258]) & 0x2B;
		}
	}

	[Description("Optional display of CTY (country prefix) in the spot comment if there is room.")]
	public bool Cty
	{
		get
		{
			return Ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	[Description("Optional display of state in the spot comment if there is room.")]
	public bool State
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

	[Description("Optional display of cty/state in the spot comment if there is room.")]
	public bool Loc
	{
		get
		{
			bool ⴃ = Ⴃ;
			DxCfg.Ⴗ[106] = (char)((DxCfg.Ⴗ[106] | DxCfg.Ⴗ[67]) & 0xF3);
			return ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	[Description("Optional display of the county in the spot comment if there is room.")]
	public bool County
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

	[Description("Optional display of the grid square in the spot comment if there is room.")]
	public bool Grid
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

	[Description("Optional display of the ITU zone in the spot comment if there is room.")]
	public bool ItuZone
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

	[Description("Optional display of LOTW participation (+ or -) in the spot comment if there is room.")]
	public bool Lotw
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

	[Description("Optional display of the name in the spot comment if there is room.")]
	public bool Name
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

	[Description("Optional display of the ARRL section in the spot comment if there is room.")]
	public bool Section
	{
		get
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			bool ⴜ = Ⴜ;
			DataGridViewColumnSelector.Ⴐ[335] = (char)((DataGridViewColumnSelector.Ⴐ[335] - DataGridViewColumnSelector.Ⴐ[238]) & 0xCD);
			return ⴜ;
		}
		set
		{
			Ⴜ = value;
		}
	}

	[Description("Optional display spotter CTY (country prefix) in the spot comment if there is room.")]
	public bool SpotterCty
	{
		get
		{
			bool ⴀ = ႥႷ.Ⴀ;
			TalkCfg.ႣႣ[51] = (char)((TalkCfg.ႣႣ[51] ^ TalkCfg.ႣႣ[155]) & 0x5C);
			return ⴀ;
		}
		set
		{
			bool ⴀ = value;
			ႥႷ.Ⴀ = ⴀ;
		}
	}

	[Description("Optional display spotter state in the spot comment if there is room.")]
	public bool SpotterState
	{
		get
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			return ႥႷ.Ⴗ;
		}
		set
		{
			bool ⴗ = value;
			ႥႷ.Ⴗ = ⴗ;
		}
	}

	[Description("Optional display spotter CTY/state in the spot comment if there is room.")]
	public bool SpotterLoc
	{
		get
		{
			return ႰႨ;
		}
		set
		{
			ႰႨ = value;
		}
	}

	[Description("Optional display spotter Continent in the spot comment if there is room.")]
	public bool SpotterCont
	{
		get
		{
			bool ⴐ = ႥႷ.Ⴐ;
			DxCfg.Ⴗ[126] = (char)((DxCfg.Ⴗ[126] + DxCfg.Ⴗ[53]) & 0x97);
			return ⴐ;
		}
		set
		{
			bool ⴐ = value;
			ႥႷ.Ⴐ = ⴐ;
		}
	}

	[Description("Optional display skimmer quality flag in the spot comment if there is room.")]
	public bool SkimmerQuality
	{
		get
		{
			return ႰႳ;
		}
		set
		{
			ႰႳ = value;
		}
	}

	[Description("Optional display skimmer cty count in the spot comment if there is room.")]
	public bool Eos
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			return ႰႭ;
		}
		set
		{
			ႰႭ = value;
		}
	}

	public override string ToString()
	{
		char[] ⴗ = DxCfg.Ⴗ;
		return TelnetServerClient.Ⴄ(1945322677, 'U', 7);
	}

	[SecuritySafeCritical]
	static DxCommentExtCfg()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void ႷႷ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, char P_3) where _0021_00210 : Socket
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
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
			case 9:
				num = (((P_2 ^ P_3) - 44) ^ num2) switch
				{
					0 => 2, 
					_ => ⴃႭ[249] - 12436, 
				};
				break;
			case 6:
				num = 3;
				break;
			case 2:
				P_0.Blocking = P_1;
				goto case 3;
			case 3:
				num2++;
				goto case 0;
			case 0:
			case 8:
			{
				int num3 = 88;
				int num4 = 296;
				num = ((592 > num4 - num3 * 2) ? (ⴃႣ[142] - 62649) : 5);
				break;
			}
			case 5:
				num = 1;
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႥ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : OnIoClientConnectEventHandler where _0021_00211 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 9;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 2;
				break;
			case 2:
				num = (((P_2 ^ P_3) - 54) ^ num3) switch
				{
					0 => 7, 
					_ => 6, 
				};
				break;
			case 6:
				num = ⴃႤ[480] - 44704;
				break;
			case 5:
			case 7:
				P_0(P_1);
				goto case 3;
			case 3:
				num3++;
				num2 = P_2 * P_2;
				goto case 0;
			case 0:
				num2 = P_2 + num2;
				num = 4;
				break;
			case 4:
				num = ((num2 % 2 != 0) ? (ⴃႭ[130] - 29252) : 8);
				break;
			case 1:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႷႭ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : XName
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		IConvertible convertible = default(IConvertible);
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
					num2 = ⴃႭ[95] - 32051;
					continue;
				case 7:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 2) ^ num) switch
					{
						0 => 8, 
						_ => ⴃႣ[5] - 35960, 
					};
					continue;
				case 0:
					convertible = null;
					num2 = ⴐ[544] - 27143;
					continue;
				case 8:
				case 9:
					convertible = P_0.LocalName;
					num2 = ⴃႭ[223] - 29629;
					continue;
				case 1:
				case 2:
				{
					num++;
					int num3 = 8;
					int num4 = 17;
					num2 = ((85 > num4 - num3 * 5) ? (ⴃႤ[499] - 53076) : 11);
					continue;
				}
				case 11:
					num2 = ⴃႣ[45] - 41388;
					continue;
				case 3:
				case 10:
					return (string)convertible;
				case 5:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႳ<_0021_00210>(_0021_00210 P_0, double P_1, char P_2, short P_3) where _0021_00210 : Form
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 6;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 8;
				break;
			case 8:
				num = (((P_3 ^ P_2) - 43) ^ num3) switch
				{
					0 => ⴃႤ[429] - 36291, 
					_ => 0, 
				};
				break;
			case 0:
				num = ⴃႣ[131] - 64723;
				break;
			case 4:
				P_0.Opacity = P_1;
				goto case 2;
			case 2:
			case 3:
			case 5:
				num3++;
				num2 = P_2 * P_2;
				goto case 7;
			case 7:
				num2 = P_2 + num2;
				num = ⴃႭ[200] - 35131;
				break;
			case 1:
				num = ((num2 % 2 != 0) ? 8 : (ⴗ[52] - 52154));
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႠ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : DataGridViewCellMouseEventHandler where _0021_00211 : DataGridView
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 4;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				continue;
			case 2:
				num = (((P_2 ^ P_3) - 2) ^ num2) switch
				{
					0 => 5, 
					_ => ⴃႭ[30] - 23954, 
				};
				continue;
			case 6:
				num = 3;
				continue;
			case 5:
				P_0.CellMouseClick += P_1;
				goto case 1;
			case 1:
			case 3:
				num2++;
				num3 = 986;
				break;
			case 0:
				break;
			case 7:
			case 8:
				return;
			}
			int num4 = 207;
			num = ((493 < num3 / 2 - num4) ? 2 : 8);
		}
	}
}
