using System.Diagnostics;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.Arc4;
using ArcInterfaces.Io;

namespace ArcEngine.ArcCmds;

public sealed class BaseCmd
{
	public void Publish(NodeUserCmd cmd)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((cmd.Tx.DistroType == DistroType.ToNil) ? (ⴄႭ[85] - 168) : 4);
				break;
			case 0:
			case 4:
			{
				object obj = new Publisher();
				(obj as Publisher).Process(cmd);
				num = ⴄႭ[14] - 182;
				break;
			}
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ClientIoType Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : ClientIoCfg
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		ClientIoType result = default(ClientIoType);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႭ[384] / 7;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 7:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 49) ^ num) switch
					{
						0 => 3, 
						_ => 8, 
					};
					continue;
				case 8:
					result = ClientIoType.Ar6Node;
					num2 = 9;
					continue;
				case 3:
					result = P_0.Type;
					num2 = 9;
					continue;
				case 6:
				case 9:
					num++;
					goto case 1;
				case 1:
					num3 = 143;
					goto case 10;
				case 10:
				{
					int num4 = 173;
					num2 = ((519 <= num4 - num3 * 3) ? 4 : 0);
					continue;
				}
				case 4:
					num2 = 11;
					continue;
				case 0:
					return result;
				case 2:
					num2 = ⴅ[92];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, char P_3) where _0021_00210 : PerformanceCounter
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 5;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 1;
				break;
			case 1:
				num = (((P_3 ^ P_2) - 78) ^ num3) switch
				{
					0 => ⴀႣ[361] - 48465, 
					_ => 9, 
				};
				break;
			case 9:
				num = ⴃႠ[415] - 56643;
				break;
			case 4:
				P_0.ReadOnly = P_1;
				goto case 3;
			case 3:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				goto case 8;
			case 8:
				num = ⴀႣ[50] - 11224;
				break;
			case 2:
			case 6:
			case 7:
				num = ((num2 % 2 != 0) ? 1 : 0);
				break;
			case 0:
				return;
			}
		}
	}
}
