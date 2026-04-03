using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Security;
using System.Windows.Forms;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using Ⴃ;

namespace ArcShared.ArcCfg;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class WwvCfg
{
	internal sealed class Ⴓ
	{
		internal DgvBaseFilterHost Ⴈ;

		internal BindingSource Ⴅ;

		internal string Ⴐ;

		internal bool Ⴓ;

		internal bool Ⴗ;

		internal ColumnFilterEventHandler Ⴍ;

		internal ColumnFilterEventHandler Ⴃ;

		internal ColumnFilterEventHandler Ⴄ;

		internal FilterSavedEventHandler Ⴀ;

		internal bool Ⴜ;

		internal Ⴓ()
		{
		}
	}

	private int Ⴄ;

	private UtilsCallsign.Ⴀ m_Ⴓ = new UtilsCallsign.Ⴀ();

	[Description("Sets the WWV output to On (normal user display) OFF(no spots are displayed)")]
	public OutputType Output
	{
		get
		{
			OutputType ⴍ = this.m_Ⴓ.Ⴍ;
			DataGridViewColumnSelector.Ⴐ[174] = (char)((DataGridViewColumnSelector.Ⴐ[174] * DataGridViewColumnSelector.Ⴐ[553]) & 0x44);
			return ⴍ;
		}
		set
		{
			this.m_Ⴓ.Ⴍ = value;
		}
	}

	[Description("Sets the number of spots displayed with the Show WWV command")]
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

	public WwvCfg()
	{
		NmbrSpots = 5;
		Output = OutputType.On;
	}

	public override string ToString()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		return ႣႼ.ႥႭ(null, 624735677, 7, null);
	}

	[SecuritySafeCritical]
	static WwvCfg()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, char P_3) where _0021_00210 : Socket
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႣ[59] - 7257;
				break;
			case 1:
				num = (((P_2 ^ P_3) - 95) ^ num2) switch
				{
					0 => 4, 
					_ => ⴗ[101] - 49608, 
				};
				break;
			case 6:
				num = 8;
				break;
			case 4:
			case 7:
				P_0.Listen(P_1);
				goto case 2;
			case 2:
			case 8:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴐ[419] - 34753) : 5);
				break;
			case 5:
				num = 1;
				break;
			case 3:
				TalkCfg.ႣႣ[133] = (char)((TalkCfg.ႣႣ[133] | P_1) & 0x21);
				return;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : Control where _0021_00211 : Cursor
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 5;
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
			case 7:
				num = (((P_2 ^ P_3) - 117) ^ num2) switch
				{
					0 => 0, 
					_ => ⴀ[266] - 12624, 
				};
				break;
			case 1:
			case 2:
				num = 3;
				break;
			case 0:
				P_0.Cursor = P_1;
				goto case 3;
			case 3:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 9 : (ⴗ[134] - 54690));
				break;
			case 4:
				num = ⴀ[398] - 36375;
				break;
			case 8:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Size Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : Control
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		Size size = default(Size);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[206] - 36156;
					continue;
				case 0:
					break;
				case 5:
					num2 = (((P_2 ^ P_1) - 117) ^ num) switch
					{
						0 => ⴃႤ[597] - 64615, 
						_ => ⴀ[6] - 34700, 
					};
					continue;
				case 10:
					size = default(Size);
					num2 = 4;
					continue;
				case 11:
					size = P_0.Size;
					num2 = ⴃႤ[438] - 63515;
					continue;
				case 3:
				case 4:
					num++;
					num3 = 343;
					num4 = 575;
					goto case 1;
				case 1:
					num2 = ((1725 > num4 - num3 * 3) ? 6 : (ⴃႣ[20] - 44810));
					continue;
				case 2:
					num2 = 5;
					continue;
				case 6:
				case 7:
				{
					Size result = size;
					WxCfg.ႣႭ[248] = (char)((WxCfg.ႣႭ[248] | DxCfg.Ⴗ[148]) & 0xEA);
					return result;
				}
				case 9:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴀ(ref Size P_0, char P_1, short P_2)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int result = default(int);
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
					num2 = ⴃႭ[119] - 58718;
					continue;
				case 7:
					break;
				case 3:
					num2 = (((P_2 ^ P_1) - 4) ^ num) switch
					{
						0 => ⴗ[148] - 25095, 
						_ => 5, 
					};
					continue;
				case 5:
					result = 10;
					num2 = 10;
					continue;
				case 4:
				case 11:
					result = P_0.Width;
					num2 = 10;
					continue;
				case 9:
				case 10:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴀ[299] - 27019;
					continue;
				case 8:
					num2 = ((num3 % 2 != 0) ? 3 : (ⴃႣ[203] - 38805));
					continue;
				case 1:
				case 6:
					return result;
				case 0:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : DataGridView where _0021_00211 : DataGridViewColumnEventHandler
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 6;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴃႭ[93] - 22807;
				break;
			case 4:
				num = (((P_3 ^ P_2) - 4) ^ num3) switch
				{
					0 => 5, 
					_ => ⴃႭ[81] - 32195, 
				};
				break;
			case 2:
				num = ⴐ[104] - 32578;
				break;
			case 5:
				P_0.ColumnRemoved += P_1;
				goto case 3;
			case 3:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				goto case 7;
			case 7:
				num = 1;
				break;
			case 1:
				num = ((num2 % 2 != 0) ? (ⴃႤ[252] - 30966) : (ⴀ[179] - 61948));
				break;
			case 0:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DxSpot
	{
		bool result = default(bool);
		int num3 = default(int);
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 9:
					num2 = (((P_1 ^ P_2) - 54) ^ num) switch
					{
						0 => 7, 
						_ => 1, 
					};
					continue;
				case 1:
				case 3:
					result = false;
					num2 = 5;
					continue;
				case 7:
					result = P_0.Skimmer;
					num2 = 5;
					continue;
				case 4:
				case 5:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 0;
					continue;
				case 0:
					num2 = ((num3 % 2 != 0) ? 9 : 2);
					continue;
				case 2:
				case 8:
					return result;
				case 11:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, char P_3) where _0021_00210 : DxSpot
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 8;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴐ[212] - 257;
				break;
			case 2:
				num = (((P_2 ^ P_3) - 69) ^ num2) switch
				{
					0 => 7, 
					_ => 9, 
				};
				break;
			case 9:
				num = 6;
				break;
			case 7:
				P_0.Cq = P_1;
				goto case 6;
			case 6:
				num2++;
				goto case 3;
			case 3:
				num3 = 808;
				num4 = 849;
				goto case 5;
			case 5:
				num = ((8490 > num4 - num3 * 10) ? 1 : (ⴃႭ[223] - 29626));
				break;
			case 0:
			case 4:
				num = 2;
				break;
			case 1:
				return;
			}
		}
	}
}
