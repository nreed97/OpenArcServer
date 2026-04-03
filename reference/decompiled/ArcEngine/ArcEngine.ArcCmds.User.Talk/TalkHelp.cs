using System.Runtime.InteropServices;
using System.Security;
using System.Timers;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Talk;

public sealed class TalkHelp : IArcCmd
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴐ
	{
		internal string Ⴅ;

		internal string Ⴃ;

		internal DxCmdMsgExt Ⴐ;

		internal DistroType Ⴍ;

		internal MsgType Ⴗ;
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(8, null, 1267023023, typeof(SetStationName)));
				goto case 3;
			case 3:
			case 5:
				num = 4;
				break;
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134528, 3, 'N'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(24, null, 1057163089, 6));
				num = ⴀ[46] - ⴀ[46];
				break;
			case 0:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static AnnCfg Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : ArcUserCfg
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		object obj = default(object);
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
				case 8:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 41) ^ num) switch
					{
						0 => ⴄႤ[174] - 56, 
						_ => 11, 
					};
					continue;
				case 11:
					obj = null;
					num2 = 9;
					continue;
				case 0:
				case 5:
					obj = P_0.Ann;
					num2 = ⴐ[166] - 207;
					continue;
				case 2:
				case 9:
					num++;
					goto case 10;
				case 10:
				{
					int num3 = 669;
					int num4 = 998;
					num2 = ((6986 > num4 - num3 * 7) ? 4 : (ⴄႷ[85] - 6781));
					continue;
				}
				case 6:
					num2 = ⴄႭ[94];
					continue;
				case 4:
					return obj as AnnCfg;
				case 1:
					num2 = ⴀႳ[123] - 17553;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DxSpot
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႨ[7] - 41572;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 5) ^ num) switch
					{
						0 => 1, 
						_ => ⴀႼ[96], 
					};
					continue;
				case 4:
					result = false;
					num2 = ⴄႷ[78] - 48378;
					continue;
				case 1:
					result = P_0.InCb;
					num2 = 2;
					continue;
				case 2:
				case 3:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 6 : ⴐ[257]);
					continue;
				case 0:
				case 7:
					num2 = 8;
					continue;
				case 6:
				case 9:
					return result;
				case 11:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : Timer where _0021_00211 : ElapsedEventHandler
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႨ[159] - 46049;
				continue;
			case 6:
				num = (((P_3 ^ P_2) - 51) ^ num2) switch
				{
					0 => 8, 
					_ => 7, 
				};
				continue;
			case 7:
				num = 0;
				continue;
			case 2:
			case 5:
			case 8:
				P_0.Elapsed += P_1;
				break;
			case 0:
				break;
			case 1:
			case 4:
				return;
			}
			num2++;
			int num3 = 1887;
			int num4 = 33;
			num = ((629 < num3 / 3 - num4) ? 6 : (ⴍႭ[15] - 41656));
		}
	}
}
