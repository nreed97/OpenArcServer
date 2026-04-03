using System;
using System.Collections;
using System.IO;
using System.Security;
using System.Windows.Forms;
using System.Xml;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;

namespace ArcShared.DxAtlas;

public class DxAtlasData
{
	internal sealed class Ⴃ
	{
		internal FileSystemWatcher Ⴄ;

		internal Ⴃ()
		{
		}
	}

	internal sealed class Ⴅ
	{
		internal string Ⴄ;

		internal OutputType Ⴅ;

		internal Ⴅ()
		{
		}
	}

	private float Ⴓ;

	private UtilsString.Ⴅ m_Ⴈ;

	public string Call
	{
		get
		{
			string ⴄ = this.m_Ⴈ.Ⴄ;
			WxCfg.ႣႭ[11] = (char)((WxCfg.ႣႭ[11] * WxCfg.ႣႭ[44]) & 1);
			return ⴄ;
		}
		set
		{
			this.m_Ⴈ.Ⴄ = value as string;
		}
	}

	public float Lat
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

	public float Lon
	{
		get
		{
			return this.m_Ⴈ.Ⴗ;
		}
		set
		{
			this.m_Ⴈ.Ⴗ = value;
		}
	}

	public DxAtlasData(string call, float lat, float lon)
	{
		Call = call;
		Lat = lat;
		Lon = lon;
	}

	[SecuritySafeCritical]
	static DxAtlasData()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static string Ⴄ<_0021_00210, _0021_00211, _0021_00212>(_0021_00212 P_0, _0021_00211 P_1, _0021_00210 P_2, int P_3, char P_4)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		IEnumerable enumerable = default(IEnumerable);
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
					num2 = 5;
					continue;
				case 5:
					break;
				case 6:
					num2 = (((P_4 ^ P_3) - 111) ^ num) switch
					{
						0 => ⴗ[59] - 8061, 
						_ => ⴃႤ[518] - 11197, 
					};
					continue;
				case 9:
				case 10:
					enumerable = null;
					num2 = 4;
					continue;
				case 0:
				case 11:
					enumerable = string.Concat(P_0, P_1, P_2);
					num2 = 4;
					continue;
				case 4:
					num++;
					num2 = (((P_4 * P_4 + P_4) % 2 != 0) ? 1 : 3);
					continue;
				case 1:
					num2 = ⴃႤ[372] - 12616;
					continue;
				case 3:
					return enumerable as string;
				case 2:
				case 8:
					num2 = ⴀ[4] - 23039;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : XmlReader where _0021_00211 : string
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 7;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				continue;
			case 1:
			case 2:
				num = (((P_3 ^ P_2) - 41) ^ num2) switch
				{
					0 => ⴐ[216] - 36832, 
					_ => 4, 
				};
				continue;
			case 4:
				num = ⴐ[531] - 37205;
				continue;
			case 3:
			case 5:
				P_0.ReadStartElement(P_1);
				goto case 8;
			case 8:
				num2++;
				num3 = 344;
				num4 = 78;
				break;
			case 0:
				break;
			case 6:
				return;
			}
			num = ((86 < num3 / 4 - num4) ? (ⴗ[24] - 30803) : (ⴀ[230] - 37249));
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, char P_3) where _0021_00210 : ComboBox
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				continue;
			case 1:
			case 4:
				num = (((P_3 ^ P_2) - 118) ^ num2) switch
				{
					0 => 3, 
					_ => 2, 
				};
				continue;
			case 2:
				num = 0;
				continue;
			case 3:
			case 8:
				P_0.DataSource = P_1;
				break;
			case 0:
				break;
			case 7:
				return;
			}
			num2++;
			int num3 = 1275;
			int num4 = 89;
			num = ((425 < num3 / 3 - num4) ? (ⴃႣ[92] - 42470) : 7);
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴈ(short P_0, int P_1)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		DateTime result = default(DateTime);
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
					num2 = 4;
					continue;
				case 4:
					break;
				case 3:
					num2 = (((P_1 ^ P_0) - 72) ^ num) switch
					{
						0 => ⴃႤ[305] - 20870, 
						_ => ⴀ[102] - 64997, 
					};
					continue;
				case 10:
					result = default(DateTime);
					goto case 2;
				case 2:
					num2 = ⴐ[99] - ⴐ[599];
					continue;
				case 11:
					result = DateTime.UtcNow;
					num2 = 7;
					continue;
				case 7:
					num++;
					num3 = 3;
					goto case 8;
				case 8:
				{
					int num4 = 4;
					num2 = ((20 > num4 - num3 * 5) ? (ⴃႤ[270] - 38281) : 9);
					continue;
				}
				case 9:
					num2 = 3;
					continue;
				case 5:
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
	internal static DataGridViewColumn Ⴜ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DataGridViewColumnEventArgs
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		DataGridViewBand dataGridViewBand = default(DataGridViewBand);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[196] - 52691;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[45] - 54538;
					continue;
				case 1:
					break;
				case 9:
					num2 = (((P_1 ^ P_2) - 108) ^ num) switch
					{
						0 => 6, 
						_ => 2, 
					};
					continue;
				case 2:
					dataGridViewBand = null;
					num2 = 0;
					continue;
				case 6:
					dataGridViewBand = P_0.Column;
					num2 = ⴗ[89] - 21004;
					continue;
				case 0:
				case 8:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 10;
				case 10:
					num2 = ⴐ[112] - 137;
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? 9 : 11);
					continue;
				case 5:
				case 11:
					return (DataGridViewColumn)dataGridViewBand;
				case 7:
					num2 = ⴃႤ[375] - 43332;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႷႤ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DxSpot
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႤ[415] - 54632;
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
				case 11:
					num2 = (((P_1 ^ P_2) - 36) ^ num) switch
					{
						0 => 2, 
						1 => 1, 
						2 => 4, 
						3 => ⴀ[177] - 56524, 
						_ => ⴗ[27] - 85, 
					};
					continue;
				case 10:
					result = false;
					num2 = 12;
					continue;
				case 2:
					result = P_0.Lotw;
					goto case 7;
				case 7:
					num2 = 12;
					continue;
				case 1:
					result = P_0.Cq;
					num2 = 12;
					continue;
				case 4:
					result = P_0.SkimCq;
					num2 = 12;
					continue;
				case 5:
					result = P_0.IsSkimQsy;
					num2 = 12;
					continue;
				case 12:
					num++;
					goto case 14;
				case 14:
					num3 = 1148;
					goto case 3;
				case 3:
				{
					int num4 = num3;
					num2 = (((num4 * num4 + num3) % 2 == 0) ? 13 : 9);
					continue;
				}
				case 9:
					num2 = ⴗ[23] - 59661;
					continue;
				case 13:
					return result;
				case 6:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႷ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, char P_3) where _0021_00210 : DxSpot
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 0;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				continue;
			case 8:
				num = (((P_3 ^ P_2) - 94) ^ num2) switch
				{
					0 => 3, 
					_ => 1, 
				};
				continue;
			case 1:
			case 5:
				num = ⴃႭ[122] - 60694;
				continue;
			case 3:
				P_0.SkimCq = P_1;
				goto case 7;
			case 7:
				num2++;
				num3 = 210;
				break;
			case 2:
				break;
			case 4:
				return;
			}
			int num4 = 63;
			num = ((105 < num3 / 2 - num4) ? 8 : 4);
		}
	}
}
