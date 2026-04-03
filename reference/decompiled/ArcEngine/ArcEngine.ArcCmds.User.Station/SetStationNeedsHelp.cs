using System.Security;
using System.Text;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationNeedsHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 5;
			case 5:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(2, null, 1267018002, typeof(DxSpotUserHelp)));
				num = 4;
				continue;
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131806, 4, '\\'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(17, null, 1057165030, 4));
				num = 3;
				continue;
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(1, 'e', 952622959));
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(8, '\u0080', 952620057));
				num = ⴃႰ[72] - 45582;
				continue;
			case 2:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 5, 62057744, null));
				num = 7;
				continue;
			case 6:
			case 7:
				obj = new Publisher();
				break;
			case 1:
				break;
			}
			break;
		}
		((Publisher)obj).Process(cmd);
	}

	[SecuritySafeCritical]
	internal static StringBuilder Ⴐ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : StringBuilder
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႰ[118] - 42158;
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
				case 5:
				case 8:
					num2 = (((P_2 ^ P_3) - 2) ^ num) switch
					{
						0 => ⴃႠ[418] - 6301, 
						_ => 9, 
					};
					continue;
				case 9:
					obj = null;
					goto case 3;
				case 3:
					num2 = ⴄႭ[246];
					continue;
				case 10:
				case 11:
					obj = P_0.Append(P_1);
					num2 = 2;
					continue;
				case 2:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴃႥ[176] - 54701;
					continue;
				case 6:
					num2 = ((num3 % 2 != 0) ? 5 : (ⴃႥ[121] - 43218));
					continue;
				case 0:
					return (StringBuilder)obj;
				case 4:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static char Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, int P_3) where _0021_00210 : string
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char result = default(char);
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
					num2 = ⴄႷ[129] - 22983;
					continue;
				case 7:
					break;
				case 1:
					num2 = (((P_3 ^ P_2) - 99) ^ num) switch
					{
						0 => ⴀႨ[64] - 60333, 
						_ => 2, 
					};
					continue;
				case 2:
					result = '3';
					num2 = ⴀႼ[43] - 205;
					continue;
				case 8:
					result = P_0[P_1];
					num2 = 3;
					continue;
				case 3:
				case 11:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴅ[17] / 6;
					continue;
				case 4:
				case 5:
				case 10:
					num2 = ((num3 % 2 != 0) ? (ⴀ[129] - 7030) : (ⴐ[96] - ⴐ[96]));
					continue;
				case 0:
					return result;
				case 9:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : StationCfg where _0021_00211 : string
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 0;
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = ⴀႼ[136];
				break;
			case 5:
				num = (((P_2 ^ P_3) - 94) ^ num4) switch
				{
					0 => ⴍႭ[153] - 64906, 
					_ => 6, 
				};
				break;
			case 6:
				num = ⴄႷ[69] - 16543;
				break;
			case 3:
				P_0.Qth = P_1;
				goto case 4;
			case 4:
				num4++;
				goto case 7;
			case 7:
			case 9:
			{
				num3 = 947;
				int num5 = num3;
				num2 = num5 * num5;
				num = 2;
				break;
			}
			case 2:
				num2 = num3 + num2;
				num = ((num2 % 2 != 0) ? ⴀႼ[136] : (ⴀ[226] - 13865));
				break;
			case 1:
			case 8:
				return;
			}
		}
	}
}
