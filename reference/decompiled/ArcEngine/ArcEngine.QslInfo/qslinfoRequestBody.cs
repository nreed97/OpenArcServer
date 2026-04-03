using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.Serialization;
using System.Security;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Wx;
using ArcInterfaces.Spots;

namespace ArcEngine.QslInfo;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DataContract(Namespace = "http://www.qslinfo.de")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
public class qslinfoRequestBody
{
	[DataMember(EmitDefaultValue = false, Order = 0)]
	public string callsign;

	[DataMember(EmitDefaultValue = false, Order = 1)]
	public string ClientInformation;

	public qslinfoRequestBody()
	{
	}

	public qslinfoRequestBody(string callsign, string ClientInformation)
	{
		this.callsign = callsign;
		this.ClientInformation = ClientInformation;
	}

	[SecuritySafeCritical]
	internal static DataRow Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, int P_3) where _0021_00210 : DataRowCollection
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		object obj = default(object);
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
					num2 = ⴄႭ[299] - 31;
					continue;
				case 3:
					break;
				case 4:
					num2 = (((P_3 ^ P_2) - 39) ^ num) switch
					{
						0 => 11, 
						_ => 8, 
					};
					continue;
				case 7:
				case 8:
					obj = null;
					num2 = 9;
					continue;
				case 11:
					obj = P_0[P_1];
					num2 = 9;
					continue;
				case 9:
				{
					num++;
					int num3 = 457;
					int num4 = 737;
					num2 = ((1474 > num4 - num3 * 2) ? 2 : 10);
					continue;
				}
				case 10:
					num2 = 4;
					continue;
				case 2:
					return obj as DataRow;
				case 5:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴐ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : AnnWxSpot
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႰ[162] - 58484;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႤ[91] - 37904;
					continue;
				case 7:
					break;
				case 12:
					num2 = (((P_1 ^ P_2) - 58) ^ num) switch
					{
						0 => 8, 
						1 => 3, 
						_ => 4, 
					};
					continue;
				case 4:
					enumerable = null;
					num2 = 2;
					continue;
				case 8:
					enumerable = P_0.SpotterCty;
					num2 = 2;
					continue;
				case 3:
					enumerable = P_0.Route;
					num2 = ⴍႤ[397] - 4813;
					continue;
				case 2:
				case 6:
				{
					num++;
					int num3 = 462;
					int num4 = 832;
					num2 = ((2496 > num4 - num3 * 3) ? 5 : (ⴀ[56] - 27720));
					continue;
				}
				case 1:
				case 9:
					num2 = 12;
					continue;
				case 0:
				case 5:
					return enumerable as string;
				case 10:
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}
}
