using System;
using System.Data;
using System.Data.Common;
using System.Security;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Arcx;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class AnnHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 6;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(5, null, 1267021882, typeof(AnnWxArx)));
				goto case 4;
			case 4:
				num = ⴄႷ[14] - 21594;
				break;
			case 0:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133361, 3, '£'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(5, null, 1057161923, 5));
				goto case 2;
			case 2:
				num = ⴀႳ[324] - 47326;
				break;
			case 1:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(2, '\u001c', 952620467));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 6, 62057954, null));
				num = ⴃႥ[239] - 50023;
				break;
			case 8:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(4, 5, 1217945051));
				goto case 7;
			case 7:
				cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(9, 3, 1747257902, null));
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687351559, 3, 15));
				num = 9;
				break;
			case 9:
				cmd.Tx.Msg.Add(ႨႨ.Ⴀ(0, 6, 1157903833));
				cmd.Tx.Msg.Add(ShowWxHelp.Ⴍ('Ý', 985808723, 0));
				num = 10;
				break;
			case 10:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(2, null, 1267021858, typeof(AnnLocalUser)));
				num = ⴃႠ[412] - 34628;
				break;
			case 5:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133289, 3, '\t'));
				obj = new Publisher();
				num = 11;
				break;
			case 11:
				(obj as Publisher).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ<_0021_00210, _0021_00211, _0021_00212>(_0021_00210 P_0, _0021_00212 P_1, _0021_00211 P_2, int P_3, char P_4) where _0021_00210 : string where _0021_00211 : string where _0021_00212 : string
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႳ[102] - 41660;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႳ[214] - 17000;
					continue;
				case 7:
				case 9:
					break;
				case 5:
					num2 = (((P_3 ^ P_4) - 55) ^ num) switch
					{
						0 => 10, 
						_ => ⴃႥ[321] - 16250, 
					};
					continue;
				case 0:
				case 3:
				case 6:
					obj = null;
					num2 = 8;
					continue;
				case 10:
					obj = string.Concat(P_0, P_1, P_2);
					num2 = ⴍႭ[136] - 20894;
					continue;
				case 8:
				{
					int num3 = num;
					SetDxCountHelp.ႭႤ[241] = (SetDxCountHelp.ႭႤ[241] ^ SetAnnChatRooms.Ⴀ[451]) & 0x5E;
					num = num3 + 1;
					int num4 = 141;
					int num5 = 542;
					num2 = ((1626 > num5 - num4 * 3) ? 2 : 4);
					continue;
				}
				case 4:
					num2 = ⴀႳ[110] - 42627;
					continue;
				case 2:
					return obj as string;
				case 11:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ParameterDirection Ⴃ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : DbParameter
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		ParameterDirection result = default(ParameterDirection);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႣ[332] - 29266;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႤ[374] - 16177;
					continue;
				case 2:
					break;
				case 3:
				case 10:
					num2 = (((P_1 ^ P_2) - 13) ^ num) switch
					{
						0 => ⴄႷ[129] - 22989, 
						_ => 6, 
					};
					continue;
				case 6:
					result = (ParameterDirection)0;
					goto case 0;
				case 0:
					num2 = ⴄႤ[297] - 98;
					continue;
				case 1:
				case 8:
					result = P_0.Direction;
					num2 = ⴀႳ[40] - 46793;
					continue;
				case 5:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 7 : 11);
					continue;
				case 11:
					num2 = ⴀႣ[281] - 27607;
					continue;
				case 7:
					return result;
				case 4:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, OutputType P_1, int P_2, int P_3) where _0021_00210 : WwvCfg
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 4;
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
				num = (((P_2 ^ P_3) - 121) ^ num2) switch
				{
					0 => ⴃႠ[409] - 30581, 
					_ => ⴀႳ[273] - 64069, 
				};
				break;
			case 6:
				num = 7;
				break;
			case 2:
				P_0.Output = P_1;
				goto case 1;
			case 1:
			case 7:
			{
				num2++;
				int num3 = 853;
				num = (((num3 * num3 + num3) % 2 == 0) ? (ⴀႼ[134] - 143) : (ⴀႣ[424] - 4365));
				break;
			}
			case 0:
			case 5:
			case 9:
				num = 3;
				break;
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : ArcLogInResp
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႤ[221] - 58728;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 1;
					continue;
				case 1:
				case 8:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 66) ^ num) switch
					{
						0 => 0, 
						_ => 9, 
					};
					continue;
				case 9:
					cloneable = null;
					num2 = 2;
					continue;
				case 0:
					cloneable = P_0.Call;
					num2 = ⴐ[316] - 29;
					continue;
				case 2:
				case 10:
				{
					num++;
					int num3 = 630;
					int num4 = 164;
					num2 = ((210 < num3 / 3 - num4) ? 4 : (ⴄႷ[26] - 9163));
					continue;
				}
				case 5:
					return cloneable as string;
				case 3:
				case 6:
					num2 = ⴀႣ[3] - 62780;
					continue;
				}
				break;
			}
		}
	}
}
