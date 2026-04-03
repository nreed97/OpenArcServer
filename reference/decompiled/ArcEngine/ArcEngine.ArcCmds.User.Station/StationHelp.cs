using System.Data.SqlServerCe;
using System.Security;
using ArcEngine.ArcCmds.Node.Pc;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcServerConfig.Io;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class StationHelp : IArcCmd
{
	internal sealed class Ⴐ
	{
		internal CacheCfgManager Ⴅ;

		internal HealthMonitorCfg Ⴓ;

		internal IoDevicesCfg Ⴍ;

		internal LegalCfg Ⴀ;

		internal LogFileCfg Ⴃ;

		internal AppLogCfg Ⴈ;

		internal Ⴐ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 6;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(8, null, 1267016662, typeof(ႨႼ)));
				goto case 7;
			case 7:
				num = ⴀႣ[4] - 32457;
				break;
			case 11:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132699, 0, '2'));
				goto case 10;
			case 10:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(15, null, 1057164321, 2));
				num = ⴍႭ[357] - 4267;
				break;
			case 2:
			{
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(5, 'Z', 952621704));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 6, 62054940, null));
				char num2 = ⴃႰ[2];
				BandModeCacheCfg.ႠႳ[244] = (char)((BandModeCacheCfg.ႠႳ[244] ^ BandModeCacheCfg.ႠႳ[36]) & 0x7B);
				num = num2 - 38929;
				break;
			}
			case 1:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(1, 14, 1217941902));
				cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(1, 4, 1747263099, null));
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687354574, 6, 24));
				num = 9;
				break;
			case 9:
				cmd.Tx.Msg.Add(ႨႨ.Ⴀ(3, 8, 1157899466));
				cmd.Tx.Msg.Add(ShowWxHelp.Ⴍ('S', 985806035, 8));
				num = 4;
				break;
			case 4:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267016628, typeof(InitPc18)));
				num = ⴀ[477] - ⴀ[477];
				break;
			case 0:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132615, 8, 'Á'));
				obj = new Publisher();
				goto case 5;
			case 5:
				num = 8;
				break;
			case 8:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : WxCfg
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[85] - 6783;
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
				case 4:
					num2 = (((P_1 ^ P_2) - 4) ^ num) switch
					{
						0 => 7, 
						_ => 1, 
					};
					continue;
				case 1:
					result = 12;
					num2 = 11;
					continue;
				case 7:
					result = P_0.NmbrSpots;
					num2 = ⴃႠ[118] - 6788;
					continue;
				case 11:
				{
					num++;
					int num3 = P_1 * P_1;
					ႨႣ.Ⴐ[280] = (byte)(ႨႣ.Ⴐ[280] & P_2 & 0x84);
					num2 = (((num3 + P_1) % 2 == 0) ? (ⴄႷ[110] - 20063) : 9);
					continue;
				}
				case 0:
				case 8:
				case 9:
					num2 = 4;
					continue;
				case 10:
					return result;
				case 2:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static OutputType Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : WwvCfg
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		OutputType result = default(OutputType);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[273] - 92;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 51) ^ num) switch
					{
						0 => 10, 
						_ => ⴄႷ[70] - 5430, 
					};
					continue;
				case 9:
					result = OutputType.Off;
					num2 = 7;
					continue;
				case 1:
				case 10:
					result = P_0.Output;
					num2 = 7;
					continue;
				case 7:
				case 8:
					num++;
					num3 = 1376;
					goto case 4;
				case 4:
				{
					int num4 = 180;
					num2 = ((344 < num3 / 4 - num4) ? (ⴀႼ[100] - 12) : (ⴃႠ[411] - 51480));
					continue;
				}
				case 3:
					return result;
				case 2:
					num2 = ⴅ[67] - 162;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : SqlCeDataAdapter where _0021_00211 : SqlCeCommand
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 7;
				continue;
			case 5:
			case 7:
				num = (((P_3 ^ P_2) - 66) ^ num2) switch
				{
					0 => 3, 
					_ => ⴀ[425] - 43495, 
				};
				continue;
			case 6:
				num = 1;
				continue;
			case 0:
			case 3:
				P_0.DeleteCommand = P_1;
				break;
			case 1:
				break;
			case 2:
			case 4:
				return;
			}
			num2++;
			int num3 = 1371;
			int num4 = 427;
			num = ((457 < num3 / 3 - num4) ? (ⴄႷ[140] - 62813) : 2);
		}
	}

	[SecuritySafeCritical]
	internal static float Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : DxSpot
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		float result = default(float);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႠ[234] - 19129;
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
					num2 = (((P_2 ^ P_1) - 45) ^ num) switch
					{
						0 => 8, 
						_ => ⴄႤ[135], 
					};
					continue;
				case 5:
					result = 0.09168444f;
					goto case 1;
				case 1:
					num2 = 7;
					continue;
				case 8:
				case 10:
					result = P_0.Band;
					num2 = ⴀႨ[118] - 41566;
					continue;
				case 2:
				case 7:
				{
					num++;
					int num3 = 1470;
					int num4 = 549;
					num2 = ((735 < num3 / 2 - num4) ? 3 : (ⴀႳ[26] - 61922));
					continue;
				}
				case 6:
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
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, char P_3) where _0021_00210 : AnnCfg
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 1;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_2 ^ P_3) - 55) ^ num3) switch
				{
					0 => ⴀႨ[212] - 27978, 
					_ => 6, 
				};
				break;
			case 2:
			case 6:
				num = 3;
				break;
			case 0:
				P_0.NmbrSpots = P_1;
				goto case 3;
			case 3:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = 8;
				break;
			case 8:
				num = ((num2 % 2 != 0) ? (ⴃႠ[212] - 12388) : 7);
				break;
			case 5:
			case 7:
			case 9:
				return;
			}
		}
	}
}
