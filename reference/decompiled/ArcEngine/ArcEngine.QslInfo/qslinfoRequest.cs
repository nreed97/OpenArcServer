using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Security;
using System.ServiceModel;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Arcx;
using ArcInterfaces.Io;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.QslInfo;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(IsWrapped = false)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class qslinfoRequest
{
	internal sealed class Ⴈ
	{
		internal int Ⴈ;

		internal int Ⴄ;

		internal int Ⴀ;

		internal Ⴈ()
		{
		}
	}

	[MessageBodyMember(Name = "qslinfo", Namespace = "http://www.qslinfo.de", Order = 0)]
	public qslinfoRequestBody Body;

	public qslinfoRequest()
	{
	}

	public qslinfoRequest(qslinfoRequestBody Body)
	{
		this.Body = Body;
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : ClientIoCfg
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		IEnumerable enumerable = default(IEnumerable);
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
					num2 = ⴄႷ[28] - 45676;
					continue;
				case 6:
				case 8:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 87) ^ num) switch
					{
						0 => 7, 
						_ => 1, 
					};
					continue;
				case 1:
					enumerable = null;
					num2 = ⴃႠ[186] - 40481;
					continue;
				case 7:
					enumerable = P_0.ConnectTo;
					num2 = ⴀႨ[176] - 914;
					continue;
				case 4:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 2 : (ⴀႨ[209] - 44070));
					continue;
				case 0:
				case 3:
					num2 = ⴍႭ[271] - 6818;
					continue;
				case 2:
					return (string)enumerable;
				case 9:
				case 10:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : AnnWxSpot
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool result = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[35] - 5039;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 9:
				case 10:
					break;
				case 7:
					num2 = (((P_2 ^ P_1) - 17) ^ num) switch
					{
						0 => 3, 
						_ => ⴐ[367], 
					};
					continue;
				case 4:
					result = true;
					num2 = ⴃႠ[245] - 54780;
					continue;
				case 3:
					result = P_0.IsDupe;
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = 2466;
					num4 = 637;
					goto case 0;
				case 0:
					num2 = ((822 < num3 / 3 - num4) ? (ⴄႤ[38] / 8) : (ⴅ[265] - 217));
					continue;
				case 5:
					return result;
				case 2:
				case 6:
					num2 = ⴃႥ[136] - 30628;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : string where _0021_00211 : string
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		IEnumerable enumerable = default(IEnumerable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[358] - 50447;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႤ[310] - ⴄႤ[12];
					continue;
				case 2:
					break;
				case 12:
					num2 = (((P_3 ^ P_2) - 49) ^ num) switch
					{
						0 => 6, 
						1 => 0, 
						_ => ⴀႨ[212] - 27967, 
					};
					continue;
				case 10:
				case 11:
					enumerable = null;
					num2 = 1;
					continue;
				case 6:
					enumerable = UtilsString.GetArcId(P_0, P_1);
					num2 = ⴃႠ[212] - 12391;
					continue;
				case 0:
				case 8:
					enumerable = UtilsMacros.ExpandDxFilterMacros(P_0, P_1);
					num2 = 1;
					continue;
				case 1:
					num++;
					num3 = 723;
					goto case 7;
				case 7:
				{
					int num4 = 984;
					num2 = ((9840 > num4 - num3 * 10) ? 9 : 5);
					continue;
				}
				case 5:
					num2 = ⴄႷ[129] - 22978;
					continue;
				case 9:
					return enumerable as string;
				case 4:
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, OutputType P_1, short P_2, short P_3) where _0021_00210 : DxCfg
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				continue;
			case 6:
				num = (((P_3 ^ P_2) - 105) ^ num2) switch
				{
					0 => ⴄႷ[71] - 34094, 
					_ => 8, 
				};
				continue;
			case 8:
				num = 3;
				continue;
			case 1:
			case 4:
				P_0.Output = P_1;
				break;
			case 2:
			case 3:
			case 7:
				break;
			case 5:
				return;
			}
			num2++;
			int num3 = 2204;
			int num4 = 219;
			num = ((551 < num3 / 4 - num4) ? 6 : 5);
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴓ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : DataSet where _0021_00211 : DataAdapter
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႤ[144] / 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 9:
					break;
				case 11:
					num2 = (((P_2 ^ P_3) - 95) ^ num) switch
					{
						0 => ⴄႤ[57] - 202, 
						_ => ⴀႼ[96], 
					};
					continue;
				case 4:
					result = 10;
					num2 = 10;
					continue;
				case 0:
					result = P_0.Fill(P_1);
					num2 = 10;
					continue;
				case 1:
				case 10:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? 7 : (ⴀႨ[16] - 34728));
					continue;
				case 8:
					num2 = 11;
					continue;
				case 3:
				case 6:
				case 7:
					return result;
				case 5:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : DataRow where _0021_00211 : DataRowCollection
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 0;
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
				num = (((P_2 ^ P_3) - 20) ^ num2) switch
				{
					0 => 6, 
					_ => ⴄႭ[524] - ⴄႭ[219], 
				};
				break;
			case 8:
				num = 1;
				break;
			case 6:
				P_0.Remove(P_1);
				goto case 1;
			case 1:
				num2++;
				goto case 2;
			case 2:
			{
				int num3 = 18;
				int num4 = 370;
				num = ((3700 > num4 - num3 * 10) ? (ⴄႷ[35] - 5042) : (ⴀႳ[250] - 48318));
				break;
			}
			case 5:
				num = 3;
				break;
			case 4:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : ArcLogInRqst
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[118] - 56552;
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
				case 11:
					num2 = (((P_1 ^ P_2) - 76) ^ num) switch
					{
						0 => 7, 
						_ => 4, 
					};
					continue;
				case 4:
					convertible = null;
					num2 = ⴀႣ[294] - 59097;
					continue;
				case 6:
				case 7:
					convertible = P_0.Call;
					num2 = 9;
					continue;
				case 9:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 10 : (ⴀ[196] - 16137));
					continue;
				case 0:
				case 2:
					num2 = 11;
					continue;
				case 10:
					return convertible as string;
				case 3:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}
}
