using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Security;
using System.ServiceModel;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.QslInfo;

[MessageContract(IsWrapped = false)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
public class qslinfoResponse
{
	[MessageBodyMember(Name = "qslinfoResponse", Namespace = "http://www.qslinfo.de", Order = 0)]
	public qslinfoResponseBody Body;

	public qslinfoResponse()
	{
	}

	public qslinfoResponse(qslinfoResponseBody Body)
	{
		this.Body = Body;
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210, _0021_00211, _0021_00212, _0021_00213>(_0021_00213 P_0, _0021_00210 P_1, _0021_00212 P_2, _0021_00211 P_3, short P_4, char P_5) where _0021_00210 : string where _0021_00211 : string where _0021_00212 : string where _0021_00213 : string
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႨ[190] - 45583;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႣ[426] - 54245;
					continue;
				case 0:
					break;
				case 11:
					num2 = (((P_4 ^ P_5) - 99) ^ num) switch
					{
						0 => 9, 
						_ => 7, 
					};
					continue;
				case 7:
					convertible = null;
					num2 = ⴀႼ[7] - 76;
					continue;
				case 9:
				case 10:
					convertible = string.Concat(P_0, P_1, P_2, P_3);
					num2 = 1;
					continue;
				case 1:
					num++;
					goto case 6;
				case 6:
					num2 = (((P_4 * P_4 + P_4) % 2 == 0) ? 3 : (ⴅ[389] - 96));
					continue;
				case 4:
					num2 = 11;
					continue;
				case 3:
				case 5:
					return convertible as string;
				case 8:
					num2 = ⴃႥ[255] - 28919;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : AnnWxSpot where _0021_00211 : string
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 7;
				continue;
			case 7:
				IpLockoutCacheCfg.ႭႭ[106] = (char)(IpLockoutCacheCfg.ႭႭ[106] & IpLockoutCacheCfg.ႭႭ[118] & 0x23);
				num = (((P_2 ^ P_3) - 72) ^ num2) switch
				{
					0 => ⴅ[6] * 6, 
					_ => ⴐ[265] - 182, 
				};
				continue;
			case 2:
				num = 3;
				continue;
			case 0:
			case 4:
				P_0.Route = P_1;
				break;
			case 3:
				break;
			case 5:
			case 6:
			case 8:
				return;
			}
			num2++;
			int num3 = 580;
			int num4 = 64;
			num = ((145 < num3 / 4 - num4) ? 7 : (ⴀႳ[194] - 22417));
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, char P_3) where _0021_00210 : DxSpot
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				break;
			case 0:
				num = (((P_2 ^ P_3) - 90) ^ num2) switch
				{
					0 => ⴀႨ[162] - 10146, 
					_ => 1, 
				};
				break;
			case 1:
				num = ⴃႰ[116] - 19361;
				break;
			case 2:
			case 3:
			case 6:
				P_0.Id = P_1;
				goto case 7;
			case 7:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴄႤ[138] - 61) : 5);
				break;
			case 4:
			case 5:
				num = 0;
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, short P_3, char P_4) where _0021_00210 : string
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႣ[238] - 19037;
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
				case 9:
					num2 = (((P_4 ^ P_3) - 63) ^ num) switch
					{
						0 => 1, 
						_ => ⴀ[255] - 57051, 
					};
					continue;
				case 10:
					comparable = null;
					num2 = 8;
					continue;
				case 1:
					comparable = P_0.PadLeft(P_1, P_2);
					num2 = ⴄႤ[134] - 68;
					continue;
				case 0:
				case 7:
				case 8:
					num++;
					goto case 2;
				case 2:
					num2 = (((P_4 * P_4 + P_4) % 2 == 0) ? 11 : (ⴄႭ[246] * 3));
					continue;
				case 6:
					num2 = ⴄႭ[498] / 7;
					continue;
				case 11:
					return comparable as string;
				case 3:
					num2 = ⴅ[215] - 51;
					continue;
				}
				break;
			}
		}
	}
}
