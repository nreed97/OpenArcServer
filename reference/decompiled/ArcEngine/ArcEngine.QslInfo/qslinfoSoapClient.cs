using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Security;
using System.ServiceModel;
using System.ServiceModel.Channels;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.QslInfo;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class qslinfoSoapClient : ClientBase<qslinfoSoap>, qslinfoSoap
{
	public qslinfoSoapClient()
	{
	}

	public qslinfoSoapClient(string endpointConfigurationName)
		: base(endpointConfigurationName)
	{
	}

	public qslinfoSoapClient(string endpointConfigurationName, string remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

	public qslinfoSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

	public qslinfoSoapClient(Binding binding, EndpointAddress remoteAddress)
		: base(binding, remoteAddress)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private qslinfoResponse Ⴅ(qslinfoRequest P_0)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		return base.Channel.qslinfo(P_0);
	}

	qslinfoResponse qslinfoSoap.qslinfo(qslinfoRequest P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Ⴅ
		return this.Ⴅ(P_0);
	}

	public string qslinfo(string callsign, string ClientInformation)
	{
		object obj2 = default(object);
		while (true)
		{
			object obj = new qslinfoRequest();
			((qslinfoRequest)obj).Body = new qslinfoRequestBody();
			((qslinfoRequest)obj).Body.callsign = callsign;
			int num = 6;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2:
					break;
				case 6:
					(obj as qslinfoRequest).Body.ClientInformation = ClientInformation;
					obj2 = ((qslinfoSoap)this).qslinfo(obj as qslinfoRequest);
					goto case 3;
				case 3:
					num = 5;
					continue;
				case 5:
				{
					string qslinfoResult = (obj2 as qslinfoResponse).Body.qslinfoResult;
					AnnCacheCfg.ႠႼ[36] = (byte)(AnnCacheCfg.ႠႼ[36] & Arc4ServerClient.ႠႣ[189] & 0x49);
					return qslinfoResult;
				}
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : CtyInfo
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႤ[478] - 23604;
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
				case 3:
				case 6:
					num2 = (((P_1 ^ P_2) - 25) ^ num) switch
					{
						0 => ⴄႷ[7] - 54229, 
						_ => 5, 
					};
					continue;
				case 5:
					enumerable = null;
					goto case 10;
				case 10:
					num2 = 7;
					continue;
				case 11:
					enumerable = P_0.Cty;
					num2 = 7;
					continue;
				case 7:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 0;
					continue;
				case 0:
					num2 = ((num3 % 2 != 0) ? (ⴃႠ[388] - 45215) : (ⴄႷ[120] - 46465));
					continue;
				case 8:
					return enumerable as string;
				case 1:
				case 2:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴓ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : DataRow
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		object result = default(object);
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
					num2 = 8;
					continue;
				case 2:
				case 8:
					break;
				case 7:
					num2 = (((P_2 ^ P_3) - 78) ^ num) switch
					{
						0 => ⴍႤ[41] - 39307, 
						_ => ⴃႰ[169] - 46556, 
					};
					continue;
				case 9:
					result = null;
					num2 = ⴍႭ[73] - 34180;
					continue;
				case 0:
					result = P_0[P_1];
					num2 = 5;
					continue;
				case 5:
					num++;
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					num2 = 4;
					continue;
				case 4:
					num2 = ((num3 % 2 != 0) ? ⴐ[257] : (ⴅ[354] - 121));
					continue;
				case 3:
					return result;
				case 6:
				case 10:
					num2 = ⴄႤ[249] + 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴗ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : IpLockoutUpdate
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႼ[101] - ⴀႼ[127];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[354] - 12;
					continue;
				case 5:
					break;
				case 2:
					num2 = (((P_2 ^ P_1) - 80) ^ num) switch
					{
						0 => ⴄႭ[66], 
						_ => ⴀ[126] - 56577, 
					};
					continue;
				case 1:
				case 7:
				case 8:
					result = false;
					num2 = ⴀႼ[93] - 126;
					continue;
				case 0:
					result = P_0.VerifyCopyDelete();
					num2 = 9;
					continue;
				case 9:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? ⴄႭ[31] : 11);
					continue;
				case 4:
				case 11:
					num2 = 2;
					continue;
				case 10:
					return result;
				case 6:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : SqlCeCommand where _0021_00211 : SqlCeDataAdapter
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 1;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 7;
				continue;
			case 7:
				num = (((P_2 ^ P_3) - 83) ^ num2) switch
				{
					0 => ⴃႠ[304] - 2901, 
					_ => 4, 
				};
				continue;
			case 0:
			case 4:
				num = 3;
				continue;
			case 6:
				P_0.InsertCommand = P_1;
				goto case 3;
			case 3:
				num2++;
				num3 = 1860;
				break;
			case 5:
				break;
			case 2:
			case 8:
				return;
			}
			int num4 = 256;
			num = ((620 < num3 / 3 - num4) ? (ⴀ[484] - 19254) : 2);
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : TextReader
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		IComparable comparable = default(IComparable);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 19) ^ num) switch
					{
						0 => 0, 
						_ => 2, 
					};
					continue;
				case 2:
					comparable = null;
					num2 = ⴀ[103] - 25552;
					continue;
				case 0:
				case 4:
					comparable = P_0.ReadToEnd();
					num2 = 5;
					continue;
				case 5:
				case 9:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴃႠ[21] - 39056;
					continue;
				case 8:
					num2 = ((num3 % 2 != 0) ? 7 : 10);
					continue;
				case 10:
				case 11:
					return comparable as string;
				case 6:
					num2 = ⴅ[145];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Hashtable Ⴐ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : Hashtable
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[21];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႭ[240] - 18;
					continue;
				case 5:
				case 6:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 13) ^ num) switch
					{
						0 => 10, 
						_ => 8, 
					};
					continue;
				case 8:
					obj = null;
					num2 = 7;
					continue;
				case 10:
					obj = Hashtable.Synchronized(P_0);
					num2 = 7;
					continue;
				case 1:
				case 7:
					num++;
					num3 = P_1 * P_1;
					goto case 0;
				case 0:
					num3 = P_1 + num3;
					num2 = ⴀႣ[335] - 40262;
					continue;
				case 11:
					num2 = ((num3 % 2 != 0) ? 3 : (ⴅ[397] / 7));
					continue;
				case 2:
					return obj as Hashtable;
				case 4:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}
}
