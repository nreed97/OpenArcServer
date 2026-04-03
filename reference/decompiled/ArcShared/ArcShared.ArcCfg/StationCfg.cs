using System;
using System.ComponentModel;
using System.Net.Mail;
using System.Security;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using WindowsFormsApplication1.ApplicationUpdates;

namespace ArcShared.ArcCfg;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class StationCfg
{
	internal sealed class ႭႣ
	{
		internal EventHandler Ⴈ;

		internal DgvBaseColumnFilter Ⴃ;

		internal ႭႣ()
		{
		}
	}

	private string Ⴅ;

	private string[] Ⴀ;

	private float Ⴀ;

	private string Ⴐ;

	private string Ⴓ;

	private FrmUpdating.ႠႨ m_Ⴍ = new FrmUpdating.ႠႨ();

	[Description("Turn on a optional beep (bell chracter) after each DX spot")]
	public bool Beep
	{
		get
		{
			return this.m_Ⴍ.Ⴀ;
		}
		set
		{
			bool ⴀ = value;
			this.m_Ⴍ.Ⴀ = ⴀ;
		}
	}

	[Description("Your name")]
	public string Name
	{
		get
		{
			return this.m_Ⴍ.Ⴓ;
		}
		set
		{
			this.m_Ⴍ.Ⴓ = value;
			TalkCfg.ႣႣ[123] = (char)((TalkCfg.ႣႣ[123] ^ TalkCfg.ႣႣ[105]) & 0x67);
		}
	}

	[Description("Optional email address.")]
	public string Email
	{
		get
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			return Ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	[Description("Macros are keyboard shortcurts based on the 0 thru 9 keys that expand into preset commands")]
	public string[] Macros
	{
		get
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			return this.Ⴀ;
		}
		set
		{
			this.Ⴀ = value;
		}
	}

	[Description("Your latitude.")]
	public float Lat
	{
		get
		{
			return this.m_Ⴍ.Ⴅ;
		}
		set
		{
			this.m_Ⴍ.Ⴅ = value;
			UtilsNumeric.Ⴀ[283] = (char)((UtilsNumeric.Ⴀ[283] - UtilsNumeric.Ⴀ[363]) & 0xA9);
		}
	}

	[Description("Your longitude.")]
	public float Lon
	{
		get
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	[Description("Optional phone number.")]
	public string Phone
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

	[Description("Your madidenhead grid locator")]
	public string GridSq
	{
		get
		{
			string ⴓ = Ⴓ;
			TalkCfg.ႣႣ[8] = (char)((TalkCfg.ႣႣ[8] ^ TalkCfg.ႣႣ[46]) & 0x19);
			return ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	[Description("Your QTH (City, State)")]
	public string Qth
	{
		get
		{
			return this.m_Ⴍ.Ⴍ;
		}
		set
		{
			this.m_Ⴍ.Ⴍ = value;
			WxCfg.ႣႭ[53] = (char)((WxCfg.ႣႭ[53] * WxCfg.ႣႭ[156]) & 0x17);
		}
	}

	public StationCfg()
	{
		Email = string.Empty;
		Name = string.Empty;
		Phone = string.Empty;
		GridSq = string.Empty;
		Qth = string.Empty;
		Macros = new string[10];
	}

	public override string ToString()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		return UtilsString.Ⴐ(null, 7, 192631609);
	}

	[SecuritySafeCritical]
	static StationCfg()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static bool Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : CancelEventArgs
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[21] - 1872;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
				case 4:
					break;
				case 0:
					num2 = (((P_2 ^ P_1) - 18) ^ num) switch
					{
						0 => ⴗ[1] - 50402, 
						_ => 3, 
					};
					continue;
				case 3:
				case 5:
				case 8:
					result = false;
					num2 = 10;
					continue;
				case 7:
					result = P_0.Cancel;
					num2 = ⴃႣ[19] - 59481;
					continue;
				case 10:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 6 : 9);
					continue;
				case 9:
					num2 = ⴃႭ[88] - 34986;
					continue;
				case 6:
					return result;
				case 1:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Guid Ⴍ(char P_0, char P_1)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		Guid result = default(Guid);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[138] - 33613;
					continue;
				case 9:
					break;
				case 1:
				case 8:
					num2 = (((P_0 ^ P_1) - 99) ^ num) switch
					{
						0 => 7, 
						_ => 3, 
					};
					continue;
				case 3:
					result = default(Guid);
					goto case 4;
				case 4:
					num2 = 11;
					continue;
				case 7:
					result = Guid.NewGuid();
					num2 = 11;
					continue;
				case 11:
				{
					int num3 = num;
					TalkCfg.ႣႣ[233] = (char)((TalkCfg.ႣႣ[233] | TalkCfg.ႣႣ[79]) & 0x6A);
					num = num3 + 1;
					goto case 2;
				}
				case 2:
				{
					int num4 = 383;
					int num5 = 386;
					num2 = ((772 > num5 - num4 * 2) ? (ⴃႭ[246] - 52421) : 6);
					continue;
				}
				case 6:
					num2 = 8;
					continue;
				case 5:
					return result;
				case 0:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴄ<_0021_00210>(ref double P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[111] - 11662;
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
				case 3:
				case 4:
					num2 = (((P_3 ^ P_2) - 100) ^ num) switch
					{
						0 => ⴃႣ[187] - 55716, 
						_ => 8, 
					};
					continue;
				case 8:
				case 10:
					comparable = null;
					num2 = 9;
					continue;
				case 0:
					comparable = P_0.ToString(P_1);
					num2 = ⴀ[6] - 34701;
					continue;
				case 1:
				case 9:
				{
					num++;
					int num3 = 16;
					int num4 = 110;
					num2 = ((1100 > num4 - num3 * 10) ? 6 : 2);
					continue;
				}
				case 2:
					num2 = ⴃႣ[214] - 56062;
					continue;
				case 6:
					return comparable as string;
				case 5:
					num2 = ⴃႣ[130] - 18577;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : MailMessage
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 3;
				break;
			case 3:
				num = (((P_2 ^ P_3) - 123) ^ num2) switch
				{
					0 => 6, 
					_ => ⴃႣ[102] - 27325, 
				};
				break;
			case 4:
				num = ⴃႭ[184] - 49678;
				break;
			case 6:
				P_0.Body = P_1;
				goto case 7;
			case 7:
				num2++;
				goto case 0;
			case 0:
			case 5:
			{
				int num3 = (P_3 * P_3 + P_3) % 2;
				DxCfg.Ⴗ[60] = (char)((DxCfg.Ⴗ[60] - UtilsNumeric.Ⴀ[403]) & 0x3F);
				num = ((num3 == 0) ? (ⴐ[19] - 21647) : 8);
				break;
			}
			case 8:
				num = ⴗ[45] - 54536;
				break;
			case 1:
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႭႭ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : AnnWxSpot
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
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
				case 11:
					num2 = (((P_2 ^ P_1) - 26) ^ num) switch
					{
						0 => ⴃႣ[84] - 43850, 
						_ => ⴗ[69] - 49312, 
					};
					continue;
				case 4:
					comparable = null;
					num2 = ⴃႤ[286] - 53654;
					continue;
				case 9:
					comparable = P_0.To;
					num2 = 1;
					continue;
				case 1:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 8;
				case 8:
					num2 = ⴗ[152] - 36434;
					continue;
				case 10:
					num2 = ((num3 % 2 != 0) ? 11 : 7);
					continue;
				case 7:
					return comparable as string;
				case 2:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႭႤ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, char P_3) where _0021_00210 : AnnWxSpot where _0021_00211 : string
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 4;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				continue;
			case 3:
			case 6:
				num = (((P_2 ^ P_3) - 126) ^ num2) switch
				{
					0 => ⴃႤ[317] - ⴃႤ[317], 
					1 => 9, 
					_ => ⴃႭ[225] - 59541, 
				};
				continue;
			case 1:
				num = ⴃႭ[262] - 43408;
				continue;
			case 0:
				P_0.Msg = P_1;
				num = 7;
				continue;
			case 9:
				P_0.SysopFlag = P_1;
				goto case 7;
			case 7:
				num2++;
				num3 = 2010;
				break;
			case 5:
				break;
			case 8:
				return;
			}
			int num4 = 761;
			num = ((1005 < num3 / 2 - num4) ? 6 : 8);
		}
	}

	[SecuritySafeCritical]
	internal static short ႭႰ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		short result = default(short);
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
				case 1:
				case 9:
					num2 = (((P_1 ^ P_2) - 111) ^ num) switch
					{
						0 => 8, 
						_ => 2, 
					};
					continue;
				case 2:
					result = 5;
					goto case 4;
				case 4:
					num2 = ⴃႤ[273] - ⴃႤ[273];
					continue;
				case 8:
					result = Convert.ToInt16(P_0);
					num2 = ⴗ[19] - ⴗ[19];
					continue;
				case 0:
					num++;
					num3 = P_1 * P_1;
					goto case 3;
				case 3:
					num3 = P_1 + num3;
					num2 = 11;
					continue;
				case 11:
					num2 = ((num3 % 2 != 0) ? 9 : (ⴃႭ[132] - 40692));
					continue;
				case 5:
					return result;
				case 6:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}
}
