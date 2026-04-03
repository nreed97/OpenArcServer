using System;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class SunCalculations
{
	public static int SunRiseSet(int year, int month, int day, double lon, double lat, double altit, bool upperLimb, ref double trise, ref double tset)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		double num9 = default(double);
		double num6 = default(double);
		double num10 = default(double);
		double num8 = default(double);
		double num7 = default(double);
		while (true)
		{
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			int result = 0;
			double num4 = Ⴈ(year, month, day) + 0.5 - lon / 360.0;
			int num5 = 12;
			while (true)
			{
				switch (num5)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num5 = 5;
					continue;
				case 5:
					break;
				case 12:
					num9 = Ⴈ(Ⴀ(num4) + 180.0 + lon);
					Ⴈ(num4, ref num2, ref num3, ref num);
					num5 = ⴐ[324] - 219;
					continue;
				case 13:
					num6 = 12.0 - Ⴄ(num9 - num2) / 15.0;
					goto case 0;
				case 0:
					num10 = 0.2666 / num;
					goto case 1;
				case 1:
					num5 = ⴄႤ[141] - 239;
					continue;
				case 7:
					num5 = ((!upperLimb) ? 4 : 6);
					continue;
				case 6:
					altit -= num10;
					num5 = ⴃႠ[376] - 48178;
					continue;
				case 4:
					num8 = (SetDxArPc.Ⴃ(altit * (Math.PI / 180.0), 589, 527) - SetDxArPc.Ⴃ(lat * (Math.PI / 180.0), 64, 2) * SetDxArPc.Ⴃ(num3 * (Math.PI / 180.0), 779, 841)) / (SkimmerSpotBins.Ⴗ(lat * (Math.PI / 180.0), 752, 657) * SkimmerSpotBins.Ⴗ(num3 * (Math.PI / 180.0), 670, 767));
					num5 = ⴃႰ[13] - 37054;
					continue;
				case 14:
					num5 = ((!(num8 >= 1.0)) ? (ⴍႤ[119] - 12905) : (ⴄႤ[114] - 192));
					continue;
				case 15:
					result = -1;
					goto case 16;
				case 16:
					num7 = 0.0;
					num5 = 8;
					continue;
				case 2:
					num5 = ((!(num8 <= -1.0)) ? (ⴀႳ[77] - 50329) : 10);
					continue;
				case 10:
					result = 1;
					num7 = 12.0;
					num5 = 8;
					continue;
				case 9:
					num7 = 180.0 / Math.PI * SetWxFilterHelp.Ⴀ(num8, 629, 617) / 15.0;
					num5 = ⴃႠ[174] - 23699;
					continue;
				case 8:
					trise = num6 - num7;
					tset = num6 + num7;
					num5 = 11;
					continue;
				case 11:
					return result;
				}
				break;
			}
		}
	}

	private static double Ⴈ(int P_0, int P_1, int P_2)
	{
		long num = 367L * (long)P_0;
		int num2 = P_1 + 9;
		AnnCacheCfg.ႠႼ[106] = (byte)((AnnCacheCfg.ႠႼ[106] | SetTalkCountHelp.Ⴅ[192]) & 0xEF);
		return num - 7 * (P_0 + num2 / 12) / 4 + 275 * P_1 / 9 + P_2 - 730530;
	}

	private static void Ⴈ(double P_0, ref double P_1, ref double P_2, ref double P_3)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 2;
		double num5 = default(double);
		double num2 = default(double);
		double num3 = default(double);
		double num4 = default(double);
		double y = default(double);
		while (true)
		{
			switch (num)
			{
			default:
				num5 = 0.0;
				Ⴓ(P_0, ref num5, ref P_3);
				num2 = P_3 * SkimmerSpotBins.Ⴗ(num5 * (Math.PI / 180.0), 961, 928);
				num = 6;
				break;
			case 6:
				num3 = P_3 * SetDxArPc.Ⴃ(num5 * (Math.PI / 180.0), 902, 964);
				num = 7;
				break;
			case 7:
				num4 = 23.4393 - 3.563E-07 * P_0;
				goto case 1;
			case 1:
				y = num3 * SetDxArPc.Ⴃ(num4 * (Math.PI / 180.0), 175, 237);
				num = 4;
				break;
			case 4:
				num3 *= SkimmerSpotBins.Ⴗ(num4 * (Math.PI / 180.0), 640, 737);
				goto case 3;
			case 3:
				num = ⴃႰ[180] - 57772;
				break;
			case 8:
				P_1 = 180.0 / Math.PI * SetStationLatLonHelp.Ⴍ(num3, num2, 876, 859);
				num = ⴍႤ[33] - 61824;
				break;
			case 5:
				P_2 = 180.0 / Math.PI * Math.Atan2(y, Math.Sqrt(num2 * num2 + num3 * num3));
				return;
			case 0:
				return;
			}
		}
	}

	private static void Ⴓ(double P_0, ref double P_1, ref double P_2)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 5;
		double num2 = default(double);
		double num3 = default(double);
		double num4 = default(double);
		double num5 = default(double);
		double num8 = default(double);
		double num7 = default(double);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = Ⴈ(356.047 + 0.9856002585 * P_0);
				goto case 6;
			case 6:
				num3 = 282.9404 + 4.70935E-05 * P_0;
				num = ⴄႭ[56] / 3;
				break;
			case 9:
				num4 = 0.016709 - 1.151E-09 * P_0;
				num5 = num2 + num4 * (180.0 / Math.PI) * SetDxArPc.Ⴃ(num2 * (Math.PI / 180.0), 340, 278) * (1.0 + num4 * SkimmerSpotBins.Ⴗ(num2 * (Math.PI / 180.0), 831, 862));
				num = ⴍႭ[203] - 29760;
				break;
			case 0:
				num8 = SkimmerSpotBins.Ⴗ(num5 * (Math.PI / 180.0), 554, 587) - num4;
				num = 8;
				break;
			case 8:
				num7 = SetWxFilterHelp.Ⴀ(1.0 - num4 * num4, 125, 96) * SetDxArPc.Ⴃ(num5 * (Math.PI / 180.0), 512, 578);
				num = 1;
				break;
			case 1:
				P_2 = SetWxFilterHelp.Ⴀ(num8 * num8 + num7 * num7, 843, 854);
				num = ⴀႼ[101] - 38;
				break;
			case 3:
			case 7:
			{
				double num6 = 180.0 / Math.PI * SetStationLatLonHelp.Ⴍ(num7, num8, 79, 120);
				P_1 = num6 + num3;
				num = 10;
				break;
			}
			case 10:
				num = ((!(P_1 >= 360.0)) ? 11 : 2);
				break;
			case 2:
				P_1 -= 360.0;
				num = 11;
				break;
			case 11:
				return;
			}
		}
	}

	private static double Ⴈ(double P_0)
	{
		return P_0 - 360.0 * WwvHelp.Ⴍ(P_0 * (1.0 / 360.0), 'Ə', 'ƛ');
	}

	private static double Ⴄ(double P_0)
	{
		return P_0 - 360.0 * WwvHelp.Ⴍ(P_0 * (1.0 / 360.0) + 0.5, 'δ', 'Π');
	}

	private static double Ⴀ(double P_0)
	{
		return Ⴈ(818.9874 + 0.985647352 * P_0);
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : AnnWxSpot
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		IComparable comparable = default(IComparable);
		while (true)
		{
			int num = 0;
			byte num2 = ⴐ[84];
			SetDxCountHelp.ႭႤ[357] = (SetDxCountHelp.ႭႤ[357] * ShowWwvOptionsHelp.ႣႥ[379]) & 0x47;
			int num3 = num2 / 5;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = 2;
					continue;
				case 2:
					break;
				case 11:
					num3 = (((P_1 ^ P_2) - 73) ^ num) switch
					{
						0 => 0, 
						1 => 9, 
						_ => 12, 
					};
					continue;
				case 12:
					comparable = null;
					goto case 5;
				case 5:
					num3 = 10;
					continue;
				case 0:
				case 7:
					comparable = P_0.To;
					num3 = 10;
					continue;
				case 9:
					comparable = P_0.WxFlag;
					num3 = 10;
					continue;
				case 10:
					num++;
					goto case 4;
				case 4:
					num3 = (((P_1 * P_1 + P_1) % 2 != 0) ? 1 : 3);
					continue;
				case 1:
					num3 = ⴀႨ[221] - 55651;
					continue;
				case 3:
					return (string)comparable;
				case 6:
					num3 = ⴀႳ[82] - 25547;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : AnnCfg
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
		int num4 = default(int);
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
					num2 = ⴀႨ[44] - 6923;
					continue;
				case 8:
					break;
				case 1:
				case 2:
					num2 = (((P_1 ^ P_2) - 73) ^ num) switch
					{
						0 => ⴄႷ[126] - 39165, 
						_ => 6, 
					};
					continue;
				case 6:
					comparable = null;
					num2 = ⴄႭ[134] / 2;
					continue;
				case 5:
					comparable = P_0.Filter;
					num2 = 4;
					continue;
				case 4:
				case 9:
					num++;
					num3 = 2850;
					num4 = 43;
					goto case 7;
				case 7:
					num2 = ((950 < num3 / 3 - num4) ? (ⴀ[282] - 54204) : 0);
					continue;
				case 0:
				{
					string result = (string)comparable;
					ShowSunHelp.ႣႠ[380] = (char)((ShowSunHelp.ႣႠ[380] * Arc4ServerClient.ႠႣ[296]) & 0xF1);
					return result;
				}
				case 3:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, short P_3) where _0021_00210 : ClientIoCfg
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀ[249] - 56113;
				break;
			case 3:
			{
				int num5 = (P_2 ^ P_3) - 58;
				int num6 = num2;
				SetDxCountHelp.ႭႤ[363] = SetDxCountHelp.ႭႤ[363] & SetWxOutput.ႣႰ[58] & 0x36;
				num = (num5 ^ num6) switch
				{
					0 => ⴐ[367], 
					_ => ⴄႷ[45] - 37268, 
				};
				break;
			}
			case 2:
				num = 1;
				break;
			case 4:
				P_0.Enabled = P_1;
				goto case 1;
			case 1:
			case 8:
				num2++;
				goto case 9;
			case 9:
			{
				int num3 = 196;
				int num4 = 644;
				num = ((6440 > num4 - num3 * 10) ? 7 : 5);
				break;
			}
			case 5:
			case 6:
				num = 3;
				break;
			case 7:
				return;
			}
		}
	}
}
