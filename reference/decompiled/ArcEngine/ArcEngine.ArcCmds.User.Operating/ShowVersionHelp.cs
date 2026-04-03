using System.Collections;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowVersionHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 5;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267017459, typeof(WxCacheCfg)));
				num = ⴀ[376] - 10260;
				break;
			case 6:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129419, 5, '«'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(24, null, 1057165899, 7));
				goto case 2;
			case 2:
				num = ⴃႰ[61] - 64135;
				break;
			case 1:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(5, '(', 952620894));
				goto case 4;
			case 4:
				obj = new Publisher();
				num = 3;
				break;
			case 0:
			case 3:
				(obj as Publisher).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : NeedsCfg
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 6;
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
				num = (((P_3 ^ P_2) - 63) ^ num2) switch
				{
					0 => ⴄႤ[223] - 33, 
					_ => 7, 
				};
				break;
			case 7:
				num = ⴀႳ[25] - 26726;
				break;
			case 2:
				P_0.Ssb = P_1;
				goto case 0;
			case 0:
			case 5:
				num2++;
				goto case 8;
			case 8:
			{
				int num3 = 200;
				int num4 = 931;
				num = ((2793 > num4 - num3 * 3) ? 9 : 4);
				break;
			}
			case 4:
				num = 1;
				break;
			case 3:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ(char P_0, int P_1)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			int num = 0;
			int num2 = 4;
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
					num2 = (((P_1 ^ P_0) - 124) ^ num) switch
					{
						0 => 5, 
						1 => 0, 
						_ => 11, 
					};
					continue;
				case 11:
					enumerable = null;
					num2 = 9;
					continue;
				case 5:
					enumerable = UtilsCopyright.Copyright;
					goto case 7;
				case 7:
					num2 = ⴀ[503] - 21603;
					continue;
				case 0:
				case 3:
					enumerable = UtilsVersion.VeryShortVersion;
					num2 = 9;
					continue;
				case 9:
				{
					num++;
					int num3 = 3704;
					int num4 = 283;
					num2 = ((926 < num3 / 4 - num4) ? (ⴃႠ[213] - 47856) : (ⴐ[53] - 166));
					continue;
				}
				case 2:
					return (string)enumerable;
				case 8:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}
}
