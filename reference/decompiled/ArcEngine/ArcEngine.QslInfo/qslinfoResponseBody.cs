using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data.SqlServerCe;
using System.IO;
using System.Runtime.Serialization;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;

namespace ArcEngine.QslInfo;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DataContract(Namespace = "http://www.qslinfo.de")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
public class qslinfoResponseBody
{
	[DataMember(EmitDefaultValue = false, Order = 0)]
	public string qslinfoResult;

	public qslinfoResponseBody()
	{
	}

	public qslinfoResponseBody(string qslinfoResult)
	{
		this.qslinfoResult = qslinfoResult;
	}

	[SecuritySafeCritical]
	internal static byte[] Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : MemoryStream
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 6;
					continue;
				case 6:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 24) ^ num) switch
					{
						0 => ⴀႼ[35] - 127, 
						_ => ⴀႣ[273] - 59523, 
					};
					continue;
				case 7:
					obj = null;
					goto case 10;
				case 10:
					num2 = ⴅ[92];
					continue;
				case 1:
				case 2:
					obj = P_0.ToArray();
					num2 = 11;
					continue;
				case 11:
					num++;
					num3 = 300;
					num4 = 979;
					goto case 9;
				case 9:
					num2 = ((3916 <= num4 - num3 * 4) ? (ⴀႼ[1] - 216) : 0);
					continue;
				case 8:
					num2 = 4;
					continue;
				case 0:
					return obj as byte[];
				case 3:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : Letter where _0021_00211 : string
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴅ[210];
				break;
			case 8:
				num = (((P_3 ^ P_2) - 14) ^ num2) switch
				{
					0 => ⴀႣ[254] - 29332, 
					_ => 7, 
				};
				break;
			case 7:
				num = ⴄႤ[50] - 21;
				break;
			case 9:
				P_0.To = P_1;
				goto case 0;
			case 0:
			case 3:
				num2++;
				goto case 1;
			case 1:
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? 6 : 2);
				break;
			case 2:
				num = ⴃႰ[80] - 24195;
				break;
			case 4:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : string where _0021_00211 : SqlCeEngine
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 3;
				continue;
			case 3:
			case 5:
				num = (((P_3 ^ P_2) - 70) ^ num2) switch
				{
					0 => 4, 
					_ => 7, 
				};
				continue;
			case 7:
				num = ⴄႷ[103] - 22420;
				continue;
			case 4:
				P_0.Compact(P_1);
				break;
			case 0:
			case 1:
				break;
			case 2:
				return;
			}
			num2++;
			int num3 = 746;
			int num4 = 28;
			num = ((373 < num3 / 2 - num4) ? (ⴀႣ[347] - 48133) : (ⴀႨ[62] - 24123));
		}
	}
}
