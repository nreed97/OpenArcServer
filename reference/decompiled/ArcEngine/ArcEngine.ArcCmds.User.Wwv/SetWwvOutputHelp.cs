using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wwv;

public sealed class SetWwvOutputHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(0, null, 1267019475, typeof(SetStationPhoneHelp)));
				num = 6;
				break;
			case 6:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131077, 2, 'Ñ'));
				goto case 5;
			case 5:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(23, null, 1057163560, 6));
				goto case 3;
			case 3:
				num = ⴍႤ[424] - 59085;
				break;
			case 1:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(4, '»', 952621302));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 5, 62057799, null));
				num = ⴄႭ[246];
				break;
			case 2:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, short P_3) where _0021_00210 : DxSpot
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 7;
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
			case 8:
				num = (((P_2 ^ P_3) - 25) ^ num2) switch
				{
					0 => ⴍႤ[337] - 1136, 
					1 => 5, 
					_ => ⴍႤ[282] - ⴍႤ[282], 
				};
				continue;
			case 0:
				num = 3;
				continue;
			case 4:
			case 9:
				P_0.Ham = P_1;
				num = 3;
				continue;
			case 5:
				P_0.SkimDupe = P_1;
				break;
			case 3:
				break;
			case 1:
			case 2:
				return;
			}
			int num3 = num2;
			ShowQrzHelp.ႤႤ[215] = (byte)((ShowQrzHelp.ႤႤ[215] * SetAnnChatRooms.Ⴀ[276]) & 0x31);
			num2 = num3 + 1;
			int num4 = 3500;
			int num5 = 2;
			num = ((875 >= num4 / 4 - num5) ? 1 : 6);
		}
	}

	[SecuritySafeCritical]
	internal static byte Ⴀ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : DxSpot
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte result = default(byte);
		int num3 = default(int);
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
					num2 = 6;
					continue;
				case 6:
					break;
				case 11:
					num2 = (((P_1 ^ P_2) - 39) ^ num) switch
					{
						0 => ⴃႠ[389] - 46738, 
						_ => ⴀႼ[34] - 248, 
					};
					continue;
				case 1:
				case 4:
					result = 16;
					goto case 9;
				case 9:
					num2 = ⴀ[228] - 47200;
					continue;
				case 7:
					result = P_0.SkimWpm;
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 10;
				case 10:
					num2 = ⴀ[208] - 20756;
					continue;
				case 5:
					num2 = ((num3 % 2 != 0) ? (ⴃႥ[388] - 30627) : 2);
					continue;
				case 2:
					return result;
				case 0:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		bool result = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႠ[355] - 31866;
					continue;
				case 7:
					break;
				case 8:
					num2 = (((P_1 ^ P_2) - 17) ^ num) switch
					{
						0 => 1, 
						_ => ⴍႤ[137] - 14895, 
					};
					continue;
				case 6:
				case 9:
					result = true;
					num2 = ⴀႨ[219] - 45724;
					continue;
				case 1:
					result = UtilsString.DxFilterContainsCt1boh(P_0);
					num2 = 5;
					continue;
				case 5:
					num++;
					goto case 3;
				case 3:
					num3 = 432;
					num4 = 521;
					goto case 2;
				case 2:
					num2 = ((5210 > num4 - num3 * 10) ? 4 : 10);
					continue;
				case 10:
					num2 = 8;
					continue;
				case 4:
					return result;
				case 11:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}
}
