using System.Data.Common;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnCountHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 3;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267015558, typeof(ႳႨ)));
				num = ⴃႥ[152] - 55228;
				break;
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216127437, 6, '¾'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(15, null, 1057168257, 4));
				num = 0;
				break;
			case 0:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 3, 62058363, null));
				num = ⴅ[223] - ⴅ[476];
				break;
			case 1:
			case 2:
			{
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(1, 11, 1217945181));
				obj = new Publisher();
				byte num2 = ⴄႤ[239];
				SetDxCountHelp.ႭႤ[483] = (SetDxCountHelp.ႭႤ[483] - SetDxCountHelp.ႭႤ[292]) & 0x3D;
				num = num2 / 4;
				break;
			}
			case 5:
			case 6:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴅ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DbCommand
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[73] - 59799;
			while (true)
			{
				switch (num2)
				{
				default:
				{
					/*OpCode not supported: LdMemberToken*/;
					int num5 = ⴍႤ[488];
					SetAnnChatRooms.Ⴀ[356] = (char)((SetAnnChatRooms.Ⴀ[356] * P_1) & 0xE8);
					num2 = num5 - 14200;
					continue;
				}
				case 0:
					break;
				case 2:
					num2 = (((P_2 ^ P_1) - 113) ^ num) switch
					{
						0 => ⴄႭ[134], 
						_ => ⴍႭ[81] - 9446, 
					};
					continue;
				case 10:
					result = 13;
					goto case 4;
				case 4:
					num2 = 7;
					continue;
				case 8:
					result = P_0.ExecuteNonQuery();
					num2 = 7;
					continue;
				case 1:
				case 5:
				case 7:
				{
					num++;
					int num3 = 736;
					int num4 = 159;
					num2 = ((184 < num3 / 4 - num4) ? 2 : (ⴃႰ[73] - 48541));
					continue;
				}
				case 6:
					return result;
				case 9:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : BandModeUpdate
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[392] - 235;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႣ[143] - 38512;
					continue;
				case 6:
					break;
				case 2:
					num2 = (((P_2 ^ P_1) - 62) ^ num) switch
					{
						0 => ⴄႤ[135], 
						_ => ⴀ[307] - 27828, 
					};
					continue;
				case 9:
					result = false;
					goto case 4;
				case 4:
				case 10:
					num2 = ⴀႼ[141] - 116;
					continue;
				case 5:
					result = P_0.VerifyCopyDelete();
					num2 = ⴀႼ[93] - 134;
					continue;
				case 1:
				case 7:
				{
					num++;
					int num3 = 2691;
					int num4 = 354;
					num2 = ((897 < num3 / 3 - num4) ? (ⴍႭ[163] - 17754) : 8);
					continue;
				}
				case 8:
					return result;
				case 0:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}
}
