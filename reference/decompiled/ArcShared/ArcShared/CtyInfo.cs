using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.ExtensionMethods.Login;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared;

public sealed class CtyInfo
{
	private string Ⴀ;

	private byte Ⴀ;

	private byte Ⴈ;

	private float Ⴅ;

	private float Ⴗ;

	private string Ⴃ;

	private string Ⴈ;

	private float Ⴀ;

	private float Ⴈ;

	private DxCommentExtCfg.ႷႰ m_Ⴐ;

	public string Cty
	{
		get
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			return this.m_Ⴐ.Ⴀ;
		}
		set
		{
			this.m_Ⴐ.Ⴀ = value;
		}
	}

	public string Country
	{
		get
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			return this.Ⴀ;
		}
		set
		{
			this.Ⴀ = value;
		}
	}

	public byte CqZone
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

	public byte ItuZone
	{
		get
		{
			return this.Ⴈ;
		}
		set
		{
			this.Ⴈ = value;
		}
	}

	public float Latitude
	{
		get
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			return Ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	public float Longitude
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

	public string Continent
	{
		get
		{
			string ⴃ = Ⴃ;
			DxCfg.Ⴗ[81] = (char)((DxCfg.Ⴗ[81] + DxCfg.Ⴗ[0]) & 0x1F);
			return ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	public string TimeOffset
	{
		get
		{
			return this.Ⴈ;
		}
		set
		{
			this.Ⴈ = value;
		}
	}

	public float Heading
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

	public float Range
	{
		get
		{
			char[] ⴗ = DxCfg.Ⴗ;
			return Ⴈ;
		}
		set
		{
			Ⴈ = value;
		}
	}

	public CtyInfo(string firstLine)
	{
		Country = ScrubInfo(UtilsLatLon.Ⴜ(firstLine, 0, 25, 868, 836));
		CqZone = ScrubZone(UtilsLatLon.Ⴜ(firstLine, 26, 5, 341, 373));
		ItuZone = ScrubZone(UtilsLatLon.Ⴜ(firstLine, 31, 5, 123, 91));
		Continent = ScrubInfo(UtilsLatLon.Ⴜ(firstLine, 36, 5, 149, 181));
		TimeOffset = ScrubInfo(UtilsLatLon.Ⴜ(firstLine, 60, 8, 778, 810));
		Cty = ScrubInfo(AutoUpdater.ႨႣ(firstLine, 68, 737, 678));
		TimeOffset = ScrubTimeOffset(TimeOffset);
		object obj = ScrubInfo(UtilsLatLon.Ⴜ(firstLine, 41, 9, 752, 720));
		Latitude = ScrubLat(obj as string);
		IEnumerable<char> enumerable = ScrubInfo(firstLine.Substring(50, 9));
		Longitude = 0f - ScrubLon((string)enumerable);
	}

	public CtyInfo(CtyInfo defaultCtyInfo)
	{
		Country = defaultCtyInfo.Country;
		CqZone = defaultCtyInfo.CqZone;
		ItuZone = defaultCtyInfo.ItuZone;
		Continent = defaultCtyInfo.Continent;
		TimeOffset = defaultCtyInfo.TimeOffset;
		Cty = defaultCtyInfo.Cty;
		Latitude = defaultCtyInfo.Latitude;
		Longitude = defaultCtyInfo.Longitude;
	}

	public static byte ScrubZone(string val)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			IEnumerable<char> enumerable = DgvFilterManager.ႭႭ(UtilsXml.Ⴗ(val, 511, 'Ǯ'), ArcLogInRqstExt.Ⴗ(1706506778, 0, 4), string.Empty, 757, 663);
			int num = ⴗ[76] - 31062;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 0:
				case 3:
					break;
				case 4:
				case 7:
					num = ((!UtilsNumeric.IsNumeric(enumerable as string)) ? 1 : 2);
					continue;
				case 2:
				case 5:
					return Convert.ToByte((string)enumerable);
				case 1:
					return 0;
				}
				break;
			}
		}
	}

	public static string ScrubInfo(string val)
	{
		string result = UtilsXml.Ⴗ(val, 512, 'ȑ').Replace(ArcLogInRqstExt.Ⴗ(1706506777, 13, 7), string.Empty);
		TalkCfg.ႣႣ[162] = (char)((TalkCfg.ႣႣ[162] ^ TalkCfg.ႣႣ[127]) & 0x8B);
		return result;
	}

	public static string ScrubTimeOffset(string time)
	{
		while (true)
		{
			bool num = AutoUpdater.ႨႰ(time, DownloadUrl2.Ⴅ(28, null, 2018868050, 7), 1013, 'Μ');
			DataGridViewColumnSelector.Ⴐ[233] = (char)((DataGridViewColumnSelector.Ⴐ[233] * DataGridViewColumnSelector.Ⴐ[365]) & 0x74);
			int num2 = ((!num) ? 1 : 6);
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
					break;
				case 1:
					return ႰႣ.Ⴀ((object)'-', (object)time, (short)897, 963);
				case 4:
				case 6:
					return time.Replace(DownloadUrl2.Ⴅ(21, null, 2018868055, 2), string.Empty);
				}
				break;
			}
		}
	}

	public static float ScrubLat(string lat)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		while (true)
		{
			int num = (UtilsNumeric.IsFloat(lat) ? (ⴃႭ[192] - 7329) : (ⴃႤ[190] - 21436));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 4;
					continue;
				case 4:
					break;
				case 0:
				case 2:
				case 3:
					return 0f;
				case 1:
				case 6:
					return ႰႨ.ႨႠ(lat, 'ż', 'Ţ');
				}
				break;
			}
		}
	}

	public static float ScrubLon(string lon)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			int num = (UtilsNumeric.IsFloat(lon) ? 6 : 4);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴗ[71] - 6963;
					continue;
				case 0:
				case 3:
					break;
				case 4:
					return 0f;
				case 2:
				case 6:
					return ႰႨ.ႨႠ(lon, 'á', 'ÿ');
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static CtyInfo()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static string Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : Assembly
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
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
					num2 = 4;
					continue;
				case 1:
				case 4:
					break;
				case 5:
					num2 = (((P_2 ^ P_1) - 59) ^ num) switch
					{
						0 => ⴐ[13] - ⴐ[13], 
						_ => 3, 
					};
					continue;
				case 3:
					comparable = null;
					num2 = ⴃႣ[77] - 39418;
					continue;
				case 0:
					comparable = P_0.Location;
					num2 = 9;
					continue;
				case 9:
				{
					int num4 = num;
					UtilsNumeric.Ⴀ[260] = (char)((UtilsNumeric.Ⴀ[260] + DataGridViewColumnSelector.Ⴐ[221]) & 0x2D);
					num = num4 + 1;
					num3 = P_2 * P_2;
					goto case 11;
				}
				case 11:
					num3 = P_2 + num3;
					num2 = 8;
					continue;
				case 8:
					num2 = ((num3 % 2 != 0) ? (ⴐ[34] - 24392) : 2);
					continue;
				case 2:
				case 10:
					return comparable as string;
				case 6:
					num2 = ⴗ[26] - 58711;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴍ(char P_0, char P_1)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[56] - 15453;
					continue;
				case 8:
					break;
				case 0:
				case 9:
					num2 = (((P_0 ^ P_1) - 57) ^ num) switch
					{
						0 => ⴗ[42] - 37004, 
						_ => 11, 
					};
					continue;
				case 11:
					result = 10;
					num2 = ⴃႤ[361] - 49742;
					continue;
				case 2:
					result = Environment.ProcessorCount;
					num2 = 4;
					continue;
				case 1:
				case 4:
				{
					num++;
					int num3 = 336;
					int num4 = 416;
					num2 = ((3744 > num4 - num3 * 9) ? 3 : 6);
					continue;
				}
				case 6:
					num2 = 0;
					continue;
				case 3:
					return result;
				case 7:
				case 10:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : Stream
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int result = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႭ[160] - 23649;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[270] - 15078;
					continue;
				case 4:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 11) ^ num) switch
					{
						0 => 8, 
						_ => 10, 
					};
					continue;
				case 10:
					result = P_1;
					num2 = 3;
					continue;
				case 8:
					result = P_0.ReadByte();
					num2 = 3;
					continue;
				case 3:
					num++;
					goto case 2;
				case 2:
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴀ[145] - 39610;
					continue;
				case 11:
					num2 = ((num3 % 2 != 0) ? (ⴃႤ[187] - 23453) : (ⴗ[64] - 62028));
					continue;
				case 1:
					return result;
				case 5:
				case 7:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴄ(ref Rectangle P_0, char P_1, short P_2)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[134] - 54687;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႤ[599] - 5476;
					continue;
				case 11:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 108) ^ num) switch
					{
						0 => 0, 
						1 => ⴃႭ[32] - 53236, 
						_ => ⴃႣ[80] - 5661, 
					};
					continue;
				case 1:
					result = 4;
					num2 = 12;
					continue;
				case 0:
					result = P_0.Width;
					goto case 3;
				case 3:
				case 10:
					num2 = ⴃႤ[438] - 63507;
					continue;
				case 2:
					result = P_0.Height;
					num2 = ⴃႤ[196] - 53314;
					continue;
				case 12:
				{
					num++;
					int num3 = 1;
					int num4 = 180;
					num2 = ((1260 > num4 - num3 * 7) ? 8 : 6);
					continue;
				}
				case 5:
				case 6:
					num2 = 7;
					continue;
				case 8:
					return result;
				case 4:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, short P_3) where _0021_00210 : DxSpot
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴗ[116] - 43239;
				continue;
			case 7:
			{
				int num3;
				switch (((P_2 ^ P_3) - 90) ^ num2)
				{
				default:
				{
					int num4 = ⴃႤ[183];
					UtilsNumeric.Ⴀ[388] = (char)((UtilsNumeric.Ⴀ[388] + P_3) & 0x69);
					num3 = num4 - 52709;
					break;
				}
				case 0:
					num3 = 3;
					break;
				}
				num = num3;
				continue;
			}
			case 4:
				num = ⴃႣ[232] - 47275;
				continue;
			case 3:
				P_0.Skimmer = P_1;
				goto case 8;
			case 8:
				num2++;
				break;
			case 0:
			case 5:
				break;
			case 1:
			case 2:
				return;
			}
			int num5 = 512;
			int num6 = 233;
			num = ((256 < num5 / 2 - num6) ? (ⴗ[53] - 64143) : (ⴃႤ[584] - 2572));
		}
	}
}
