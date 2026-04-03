using System;
using System.IO;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcIo.ReverseBeacon;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class WxHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(1, null, 1267018118, typeof(RevBcnSpotProcessor)));
				num = 10;
				break;
			case 10:
			{
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131761, 0, 'A'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(3, null, 1057164889, 1));
				char num2 = ⴃႰ[46];
				ShowQrzHelp.ႤႤ[533] = (byte)((ShowQrzHelp.ႤႤ[533] - SetDxCountHelp.ႭႤ[474]) & 0x32);
				num = num2 - 49484;
				break;
			}
			case 5:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(4, '¤', 952622911));
				goto case 0;
			case 0:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 8, 62054495, null));
				goto case 2;
			case 2:
				num = ⴅ[417] - 92;
				break;
			case 9:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(2, 2, 1217943352));
				cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(7, 1, 1747261850, null));
				num = ⴄႭ[94];
				break;
			case 7:
				cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687353902, 4, 17));
				num = 6;
				break;
			case 6:
				cmd.Tx.Msg.Add(ႨႨ.Ⴀ(9, 5, 1157904548));
				cmd.Tx.Msg.Add(ShowWxHelp.Ⴍ('L', 985806694, 5));
				num = ⴄႤ[111] - 236;
				break;
			case 4:
			case 8:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267019374, typeof(SetWwvOutput)));
				num = 3;
				break;
			case 3:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DxSpot
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႣ[96] - 54564;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 8;
					continue;
				case 8:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 29) ^ num) switch
					{
						0 => 9, 
						1 => ⴃႠ[175] - 62127, 
						_ => 5, 
					};
					continue;
				case 5:
					cloneable = null;
					num2 = 6;
					continue;
				case 2:
				case 9:
					cloneable = P_0.Call;
					num2 = ⴃႥ[216] - 63045;
					continue;
				case 3:
					cloneable = P_0.Grid;
					num2 = ⴅ[483] - 12;
					continue;
				case 6:
				{
					num++;
					int num3 = 235;
					int num4 = 592;
					num2 = ((4736 > num4 - num3 * 8) ? (ⴃႥ[214] - 49245) : 11);
					continue;
				}
				case 11:
					num2 = ⴄႷ[23] - 32512;
					continue;
				case 7:
					return (string)cloneable;
				case 0:
					num2 = ⴄႤ[148];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : string where _0021_00211 : DxSpot
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 1;
				break;
			case 1:
				num = (((P_2 ^ P_3) - 54) ^ num2) switch
				{
					0 => 5, 
					1 => 2, 
					_ => ⴀႼ[87] - 218, 
				};
				break;
			case 7:
				num = 10;
				break;
			case 5:
				P_0.State = P_1;
				num = ⴃႥ[32] - 37165;
				break;
			case 2:
			case 3:
				P_0.SkimQualityFlag = P_1;
				goto case 6;
			case 6:
			case 10:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? 9 : (ⴐ[189] - 116));
				break;
			case 0:
			case 8:
				num = 1;
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : BinaryReader
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		long result = default(long);
		int num3 = default(int);
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
					num2 = ⴀ[231] - 33758;
					continue;
				case 4:
				case 10:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 16) ^ num) switch
					{
						0 => ⴄႷ[68] - 14160, 
						_ => 5, 
					};
					continue;
				case 5:
					result = 0L;
					num2 = 2;
					continue;
				case 11:
					result = P_0.ReadInt64();
					num2 = 2;
					continue;
				case 2:
				case 9:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 0;
				case 0:
					num2 = ⴍႭ[18] - 56759;
					continue;
				case 8:
					num2 = ((num3 % 2 != 0) ? 1 : 7);
					continue;
				case 7:
					return result;
				case 3:
					num2 = ⴍႭ[6] - 37958;
					continue;
				}
				break;
			}
		}
	}
}
