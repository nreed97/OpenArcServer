using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationGridHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 3;
			case 3:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267016004, typeof(ShowDxHelp)));
				num = 0;
				break;
			case 0:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129393, 7, 'J'));
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(5, 'H', 952620052));
				num = ⴀႣ[106] - 1384;
				break;
			case 2:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 6, 62057747, null));
				goto case 4;
			case 4:
				num = 5;
				break;
			case 5:
			{
				object obj = new Publisher();
				(obj as Publisher).Process(cmd);
				return;
			}
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : string where _0021_00211 : CallBlockUpdate
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 5;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 3;
				break;
			case 3:
				num = (((P_3 ^ P_2) - 72) ^ num2) switch
				{
					0 => ⴍႭ[297] - 58543, 
					_ => ⴍႭ[322] - ⴍႭ[322], 
				};
				break;
			case 0:
				num = 8;
				break;
			case 7:
				P_0.Download(P_1);
				goto case 8;
			case 8:
			case 9:
				num2++;
				num3 = 111;
				num4 = 339;
				goto case 2;
			case 2:
				num = ((2034 > num4 - num3 * 6) ? 1 : (ⴃႠ[377] - 15389));
				break;
			case 4:
				num = 3;
				break;
			case 1:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DxSpot
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte result = default(byte);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[6];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 8;
					continue;
				case 3:
				case 8:
					break;
				case 0:
					num2 = (((P_2 ^ P_1) - 99) ^ num) switch
					{
						0 => 6, 
						_ => ⴀႼ[54] - 67, 
					};
					continue;
				case 11:
					result = 29;
					goto case 1;
				case 1:
					num2 = ⴐ[220] - 73;
					continue;
				case 6:
					result = P_0.ItuZone;
					num2 = ⴐ[21] * 3;
					continue;
				case 4:
				case 9:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 2;
					continue;
				case 2:
					num2 = ((num3 % 2 == 0) ? 5 : 0);
					continue;
				case 5:
					return result;
				case 7:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}
}
