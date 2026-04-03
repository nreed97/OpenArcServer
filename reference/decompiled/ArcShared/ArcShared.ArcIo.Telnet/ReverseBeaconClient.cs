using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;

namespace ArcShared.ArcIo.Telnet;

public sealed class ReverseBeaconClient : TelnetClient
{
	public ReverseBeaconClient(IIoDeviceCfg ioDeviceCfg)
		: base(ioDeviceCfg)
	{
	}

	[SecuritySafeCritical]
	static ReverseBeaconClient()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		IEquatable<string> equatable = default(IEquatable<string>);
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
					num2 = 11;
					continue;
				case 4:
				case 11:
					break;
				case 2:
					num2 = (((P_3 ^ P_2) - 72) ^ num) switch
					{
						0 => ⴐ[214] - 10764, 
						1 => ⴀ[361] - 23646, 
						_ => ⴐ[202] - 9423, 
					};
					continue;
				case 1:
					equatable = null;
					num2 = 6;
					continue;
				case 8:
					equatable = string.Concat(P_0, P_1);
					num2 = ⴃႤ[210] - 27390;
					continue;
				case 0:
				case 5:
					equatable = string.Concat(P_0, P_1);
					num2 = 6;
					continue;
				case 6:
				case 9:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? 12 : 10);
					continue;
				case 10:
					num2 = ⴗ[134] - 54692;
					continue;
				case 12:
					return (string)equatable;
				case 3:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DataColumn
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		MemberInfo memberInfo = default(MemberInfo);
		int num3 = default(int);
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
					num2 = ⴃႭ[286] - 63491;
					continue;
				case 5:
					break;
				case 2:
				case 7:
					num2 = (((P_2 ^ P_1) - 35) ^ num) switch
					{
						0 => 8, 
						_ => ⴃႣ[214] - 56060, 
					};
					continue;
				case 6:
					memberInfo = typeof(TelnetClient);
					num2 = ⴃႣ[36] - 35703;
					continue;
				case 8:
				case 11:
					memberInfo = P_0.DataType;
					num2 = ⴐ[489] - 39750;
					continue;
				case 9:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = ⴃႤ[466] - 65297;
					continue;
				case 4:
					num2 = ((num3 % 2 == 0) ? 1 : 7);
					continue;
				case 1:
				{
					Type result = memberInfo as Type;
					UtilsNumeric.Ⴀ[123] = (char)(UtilsNumeric.Ⴀ[123] & P_2 & 0x4F);
					return result;
				}
				case 0:
					num2 = ⴗ[24] - 30798;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, int P_3) where _0021_00210 : TextBoxBase
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 2;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႣ[62] - 18493;
				break;
			case 3:
				num = (((P_3 ^ P_2) - 23) ^ num2) switch
				{
					0 => 9, 
					_ => 8, 
				};
				break;
			case 8:
				num = 4;
				break;
			case 1:
			case 6:
			case 9:
				P_0.ReadOnly = P_1;
				goto case 4;
			case 4:
				num2++;
				num3 = 615;
				goto case 7;
			case 7:
			{
				int num4 = 650;
				num = ((5850 <= num4 - num3 * 9) ? (ⴀ[29] - 14207) : 0);
				break;
			}
			case 5:
				num = 3;
				break;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal new static string Ⴈ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, short P_3) where _0021_00210 : ResourceManager where _0021_00211 : string
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		IComparable comparable = default(IComparable);
		while (true)
		{
			int num = 0;
			char num2 = ⴀ[356];
			UtilsNumeric.Ⴀ[330] = (char)((UtilsNumeric.Ⴀ[330] | WxCfg.ႣႭ[61]) & 0x7E);
			int num3 = num2 - 16266;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = ⴀ[114] - 58313;
					continue;
				case 7:
					break;
				case 10:
					num3 = (((P_3 ^ P_2) - 76) ^ num) switch
					{
						0 => ⴃႤ[270] - 38278, 
						_ => 6, 
					};
					continue;
				case 4:
				case 6:
					comparable = null;
					num3 = 11;
					continue;
				case 9:
					comparable = P_0.GetString(P_1);
					num3 = 11;
					continue;
				case 11:
					num++;
					num3 = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴗ[19] - 27394) : (ⴐ[431] - 33753));
					continue;
				case 1:
				case 5:
				case 8:
					num3 = 10;
					continue;
				case 0:
					return comparable as string;
				case 2:
					num3 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴅ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : XmlSerializer where _0021_00211 : TextReader
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object result = default(object);
		int num3 = default(int);
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
					num2 = ⴗ[8] - 15538;
					continue;
				case 0:
					break;
				case 8:
					num2 = (((P_2 ^ P_3) - 80) ^ num) switch
					{
						0 => 10, 
						_ => ⴀ[411] - 55800, 
					};
					continue;
				case 2:
				case 9:
					result = null;
					goto case 6;
				case 6:
					num2 = ⴃႣ[23] - 17525;
					continue;
				case 10:
				case 11:
					result = P_0.Deserialize(P_1);
					num2 = ⴃႤ[76] - 33768;
					continue;
				case 1:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 7;
					continue;
				case 7:
					num2 = ((num3 % 2 != 0) ? 8 : 5);
					continue;
				case 5:
					return result;
				case 4:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : Control where _0021_00211 : Image
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 0;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 9;
				break;
			case 3:
			case 9:
				num = (((P_3 ^ P_2) - 49) ^ num3) switch
				{
					0 => 1, 
					_ => 7, 
				};
				break;
			case 7:
				num = 8;
				break;
			case 1:
				P_0.BackgroundImage = P_1;
				goto case 8;
			case 8:
				num3++;
				num2 = P_2 * P_2;
				goto case 6;
			case 6:
				num2 = P_2 + num2;
				goto case 4;
			case 4:
				num = ⴃႭ[127] - 5419;
				break;
			case 2:
				num = ((num2 % 2 != 0) ? (ⴃႭ[43] - 34341) : (ⴃႤ[398] - 57215));
				break;
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, Rectangle P_1, DataGridViewPaintParts P_2, char P_3, short P_4) where _0021_00210 : DataGridViewCellPaintingEventArgs
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 3;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 7;
				break;
			case 7:
				num = (((P_3 ^ P_4) - 112) ^ num3) switch
				{
					0 => ⴐ[34] - 24388, 
					_ => 2, 
				};
				break;
			case 2:
				num = ⴐ[27] - 39547;
				break;
			case 9:
				P_0.Paint(P_1, P_2);
				goto case 6;
			case 6:
				num3++;
				num2 = P_4 * P_4;
				goto case 5;
			case 5:
				num2 = P_4 + num2;
				num = 4;
				break;
			case 4:
				num = ((num2 % 2 != 0) ? 7 : 8);
				break;
			case 1:
			case 8:
				return;
			}
		}
	}
}
