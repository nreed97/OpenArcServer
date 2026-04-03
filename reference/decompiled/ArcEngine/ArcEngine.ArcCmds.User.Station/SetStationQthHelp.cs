using System.Data;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcServerConfig.Io;
using ArcShared;
using ArcShared.ArcCfg;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationQthHelp : IArcCmd
{
	internal sealed class Ⴈ
	{
		internal int Ⴍ;

		internal Ⴈ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 6;
			case 6:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(3, null, 1267015816, typeof(IoDevicesCfg)));
				num = 0;
				break;
			case 0:
			case 1:
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129367, 4, 'ö'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(11, null, 1057166200, 6));
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(6, 'Û', 952620055));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 2, 62057751, null));
				num = 5;
				break;
			case 5:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴄ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : Top100Update
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႳ[311] - 62253;
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
				case 3:
					num2 = (((P_1 ^ P_2) - 62) ^ num) switch
					{
						0 => 6, 
						_ => ⴐ[204] / 6, 
					};
					continue;
				case 1:
					result = true;
					num2 = ⴀႳ[150] - 6826;
					continue;
				case 6:
					result = P_0.VerifyCopyDelete();
					num2 = 11;
					continue;
				case 11:
					num++;
					goto case 4;
				case 4:
				case 5:
				case 8:
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴃႥ[315] - 42391) : 10);
					continue;
				case 10:
					num2 = 3;
					continue;
				case 9:
					return result;
				case 2:
					num2 = ⴃႥ[73] - 11825;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : ArcUserCfg
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴍႭ[163] - 17755;
				break;
			case 1:
				num = (((P_3 ^ P_2) - 93) ^ num2) switch
				{
					0 => 6, 
					_ => ⴄႤ[516] - ⴄႤ[50], 
				};
				break;
			case 3:
			case 8:
				num = 4;
				break;
			case 2:
			case 6:
				P_0.Call = P_1;
				goto case 4;
			case 4:
				num2++;
				goto case 7;
			case 7:
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴐ[302] - 131) : 5);
				break;
			case 5:
				num = 1;
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataColumn Ⴗ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : DataColumnCollection where _0021_00211 : string
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[15] - 41650;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႤ[135];
					continue;
				case 5:
					break;
				case 10:
					num2 = (((P_3 ^ P_2) - 26) ^ num) switch
					{
						0 => 1, 
						_ => 9, 
					};
					continue;
				case 9:
					obj = null;
					num2 = ⴃႥ[284] - 40966;
					continue;
				case 1:
					obj = P_0.Add(P_1);
					num2 = ⴅ[210];
					continue;
				case 8:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 2;
					continue;
				case 2:
				case 3:
				case 4:
					num2 = ((num3 % 2 != 0) ? (ⴍႭ[266] - 51341) : (ⴃႠ[26] - ⴃႠ[26]));
					continue;
				case 0:
					return (DataColumn)obj;
				case 6:
				case 11:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : ServerIoCfg where _0021_00211 : string
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 4;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
			{
				num2 = 0;
				char num4 = ⴄႷ[22];
				SetDxCountHelp.ႭႤ[338] = (SetDxCountHelp.ႭႤ[338] ^ P_3) & 0x57;
				num = num4 - 7326;
				continue;
			}
			case 6:
				num = (((P_2 ^ P_3) - 77) ^ num2) switch
				{
					0 => ⴀ[282] - 54201, 
					1 => 2, 
					_ => 0, 
				};
				continue;
			case 0:
				num = ⴀ[516] - 31182;
				continue;
			case 5:
				P_0.IntroLoginFile = P_1;
				goto case 1;
			case 1:
				num = ⴄႭ[624] - ⴄႭ[386];
				continue;
			case 2:
				P_0.DefaultDxFilter = P_1;
				goto case 3;
			case 3:
				num2++;
				goto case 7;
			case 7:
				num3 = 3484;
				break;
			case 9:
				break;
			case 8:
				return;
			}
			int num5 = 397;
			num = ((871 < num3 / 4 - num5) ? 6 : 8);
		}
	}
}
