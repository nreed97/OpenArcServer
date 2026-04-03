using System;
using System.Collections;
using System.IO;
using System.Security;
using ArcShared.ArcCfg;
using ArcShared.DgvUtils;

namespace ArcShared.ArcUtils;

public static class UtilsDate
{
	public static bool IsDate(string strDate)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		bool result = true;
		try
		{
			ArcUserCfg.ႠႳ(strDate, 'á', 183);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	[SecuritySafeCritical]
	static UtilsDate()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static int Ⴄ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : ArrayList
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[385] - ⴐ[385];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 64) ^ num) switch
					{
						0 => 1, 
						_ => 2, 
					};
					continue;
				case 2:
					result = 12;
					num2 = 6;
					continue;
				case 1:
				case 4:
					result = P_0.Count;
					num2 = 6;
					continue;
				case 6:
					num++;
					goto case 7;
				case 7:
				case 9:
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 10 : 8);
					continue;
				case 8:
					num2 = ⴗ[55] - 6828;
					continue;
				case 10:
					return result;
				case 5:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		IComparable<string> comparable = default(IComparable<string>);
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
					num2 = ⴃႤ[264] - 53644;
					continue;
				case 0:
				case 12:
					break;
				case 10:
					num2 = (((P_1 ^ P_2) - 29) ^ num) switch
					{
						0 => ⴃႣ[106] - 63637, 
						1 => 2, 
						_ => ⴃႤ[111] - 29456, 
					};
					continue;
				case 3:
				case 8:
					comparable = null;
					num2 = 9;
					continue;
				case 1:
					comparable = File.ReadAllText(P_0);
					num2 = 9;
					continue;
				case 2:
					comparable = P_0.ToLower();
					num2 = 9;
					continue;
				case 9:
				{
					num++;
					int num3 = 339;
					int num4 = 673;
					num2 = ((4711 > num4 - num3 * 7) ? (ⴀ[320] - 27691) : (ⴀ[21] - 21551));
					continue;
				}
				case 4:
					num2 = ⴃႤ[320] - 20175;
					continue;
				case 5:
					return (string)comparable;
				case 6:
				case 11:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : Type
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႤ[92] - 49887;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[13] - 37646;
					continue;
				case 1:
					break;
				case 10:
					num2 = (((P_2 ^ P_1) - 52) ^ num) switch
					{
						0 => 11, 
						_ => 0, 
					};
					continue;
				case 0:
					result = false;
					goto case 5;
				case 5:
					num2 = 4;
					continue;
				case 3:
				case 11:
					result = P_0.IsSerializable;
					num2 = ⴗ[52] - 52159;
					continue;
				case 4:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 8;
					continue;
				case 2:
				case 8:
					num2 = ((num3 % 2 != 0) ? (ⴀ[85] - 17496) : 7);
					continue;
				case 7:
					return result;
				case 9:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}
}
