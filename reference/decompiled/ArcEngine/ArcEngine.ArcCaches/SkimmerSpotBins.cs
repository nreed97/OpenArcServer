using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Security;
using System.Xml.Serialization;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class SkimmerSpotBins
{
	public List<SkimmerSpot> Spots;

	public SkimmerSpotBins()
	{
		Spots = new List<SkimmerSpot>();
	}

	[SecuritySafeCritical]
	internal static DataTable Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, short P_3) where _0021_00210 : DataTableCollection
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		IXmlSerializable xmlSerializable = default(IXmlSerializable);
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
					num2 = 0;
					continue;
				case 0:
					break;
				case 6:
					num2 = (((P_2 ^ P_3) - 84) ^ num) switch
					{
						0 => 4, 
						_ => ⴍႭ[177] - 18116, 
					};
					continue;
				case 1:
					xmlSerializable = null;
					num2 = ⴄႷ[28] - 45679;
					continue;
				case 4:
					xmlSerializable = P_0[P_1];
					num2 = 3;
					continue;
				case 3:
					num++;
					goto case 10;
				case 10:
					num3 = 656;
					goto case 11;
				case 11:
				{
					int num4 = 1012;
					num2 = ((6072 > num4 - num3 * 6) ? (ⴀႨ[147] - 30830) : 5);
					continue;
				}
				case 5:
					num2 = 6;
					continue;
				case 7:
					return (DataTable)xmlSerializable;
				case 2:
				case 9:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ModeType Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : WxCfg
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		ModeType result = default(ModeType);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႤ[148] * 4;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[212] - ⴐ[243];
					continue;
				case 1:
				case 5:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 14) ^ num) switch
					{
						0 => 0, 
						_ => ⴃႰ[63] - 42194, 
					};
					continue;
				case 2:
					result = ModeType.Open;
					num2 = 3;
					continue;
				case 0:
					result = P_0.Mode;
					num2 = 3;
					continue;
				case 3:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 8 : 10);
					continue;
				case 6:
				case 10:
					num2 = 4;
					continue;
				case 8:
					return result;
				case 11:
					num2 = ⴀႼ[96];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : Exception
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		IEnumerable enumerable = default(IEnumerable);
		int num3 = default(int);
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
					num2 = ⴀ[4] - 45084;
					continue;
				case 2:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 46) ^ num) switch
					{
						0 => 5, 
						_ => 9, 
					};
					continue;
				case 9:
				case 10:
					enumerable = null;
					num2 = 6;
					continue;
				case 4:
				case 5:
					enumerable = P_0.Message;
					num2 = 6;
					continue;
				case 6:
					num++;
					num3 = 1320;
					goto case 7;
				case 7:
				{
					int num4 = 127;
					int num5 = num3 / 2;
					SetAnnMode.ႤႭ[55] = (byte)((SetAnnMode.ႤႭ[55] - P_1) & 0x16);
					num2 = ((660 < num5 - num4) ? ⴀႼ[80] : ⴄႭ[134]);
					continue;
				}
				case 8:
					return enumerable as string;
				case 1:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႥ[228] - 40977;
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
					num2 = (((P_2 ^ P_1) - 98) ^ num) switch
					{
						0 => 5, 
						_ => 7, 
					};
					continue;
				case 7:
					result = true;
					num2 = ⴀ[186] - 63464;
					continue;
				case 1:
				case 2:
				case 5:
					result = PerformanceCounterCategory.Exists(P_0);
					num2 = ⴀႼ[67] - 228;
					continue;
				case 6:
				{
					num++;
					int num3 = 278;
					int num4 = 313;
					num2 = ((3130 > num4 - num3 * 10) ? 3 : 4);
					continue;
				}
				case 4:
					num2 = ⴃႥ[194] - 55724;
					continue;
				case 3:
				case 8:
					return result;
				case 10:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static double Ⴗ(double P_0, short P_1, int P_2)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		double result = default(double);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
				case 5:
					break;
				case 1:
				case 2:
					num2 = (((P_1 ^ P_2) - 97) ^ num) switch
					{
						0 => 9, 
						_ => 7, 
					};
					continue;
				case 7:
					result = 1.238116778634619;
					num2 = 3;
					continue;
				case 9:
					result = Math.Cos(P_0);
					num2 = 3;
					continue;
				case 3:
				{
					num++;
					int num3 = 3144;
					int num4 = 38;
					num2 = ((786 < num3 / 4 - num4) ? (ⴀႼ[136] - 4) : 4);
					continue;
				}
				case 4:
					return result;
				case 6:
				case 10:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}
}
