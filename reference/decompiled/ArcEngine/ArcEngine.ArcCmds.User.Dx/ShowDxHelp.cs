using System.Data.Common;
using System.Security;
using System.Threading;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcDatabase;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class ShowDxHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int num = 6;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 5;
			case 5:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(5, null, 1267018152, typeof(ႥႳ)));
				num = 1;
				break;
			case 1:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131746, 1, '\u000e'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(23, null, 1057164990, 5));
				goto case 0;
			case 0:
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(2, 'N', 952622874));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 8, 62056324, null));
				num = 2;
				break;
			case 2:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ(int P_0, int P_1, short P_2)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 2;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 1;
				break;
			case 1:
				num = (((P_2 ^ P_1) - 50) ^ num2) switch
				{
					0 => ⴅ[20], 
					1 => 3, 
					_ => ⴀ[450] - 56818, 
				};
				break;
			case 7:
				num = ⴀ[139] - 30227;
				break;
			case 10:
				Thread.Sleep(P_0);
				num = ⴃႥ[239] - 50025;
				break;
			case 3:
			case 4:
				LogFileMaintenance.ScrubLogs(P_0);
				goto case 6;
			case 6:
				num2++;
				num3 = 294;
				goto case 5;
			case 5:
			{
				int num4 = 463;
				num = ((2315 <= num4 - num3 * 5) ? 9 : 0);
				break;
			}
			case 9:
				num = 1;
				break;
			case 0:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, char P_3) where _0021_00210 : DbParameterCollection
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 0;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				continue;
			case 2:
				num = (((P_2 ^ P_3) - 107) ^ num2) switch
				{
					0 => 8, 
					_ => 3, 
				};
				continue;
			case 3:
				num = 1;
				continue;
			case 8:
				P_0.RemoveAt(P_1);
				goto case 1;
			case 1:
			case 7:
				num2++;
				num3 = 172;
				break;
			case 4:
			case 6:
				break;
			case 5:
				return;
			}
			int num4 = 1;
			num = ((43 < num3 / 4 - num4) ? 2 : (ⴃႥ[454] - 12504));
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : string
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႼ[6] / 9;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 120) ^ num) switch
					{
						0 => ⴃႠ[131] - 13668, 
						_ => ⴄႤ[193] - 81, 
					};
					continue;
				case 11:
					result = true;
					num2 = ⴃႰ[53] - 30359;
					continue;
				case 5:
				case 6:
					result = UtilsString.IsMsgRequestingLogin(P_0);
					num2 = ⴀႼ[113];
					continue;
				case 2:
					num++;
					goto case 0;
				case 0:
				{
					num3 = P_1 * P_1;
					int num4 = num3;
					ShowWwvOptionsHelp.ႣႥ[160] = (char)((ShowWwvOptionsHelp.ႣႥ[160] ^ P_1) & 0x30);
					num3 = P_1 + num4;
					num2 = ⴄႤ[147] - ⴄႤ[164];
					continue;
				}
				case 4:
					num2 = ((num3 % 2 != 0) ? (ⴀႳ[258] - 27283) : 10);
					continue;
				case 10:
					return result;
				case 1:
				case 9:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}
}
