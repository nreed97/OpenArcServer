using System.Security;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Meebey.SmartIrc4net;

namespace ArcEngine.ArcCmds.User.Wwv;

public sealed class SetWwvDefault : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 2;
		IArcCmd arcCmd = default(IArcCmd);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				AnnHelp.Ⴍ(ShowHeading.Ⴅ(cmd.Ⴍ().Cfg, 754, 758), OutputType.On, 273, 360);
				num = ⴃႥ[257] - ⴃႥ[257];
				continue;
			case 0:
				AnnFullHelp.Ⴃ(ShowHeading.Ⴅ(cmd.Ⴍ().Cfg, 998, 994), 10, 313, 340);
				num = 4;
				continue;
			case 4:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(2, 15, 1217941864));
				arcCmd = new ShowWwvOptions();
				num = ⴀႳ[206] - 51397;
				continue;
			case 5:
				(arcCmd as ShowWwvOptions).Exec(cmd);
				goto case 6;
			case 6:
				obj = new Publisher();
				break;
			case 3:
				break;
			case 1:
				return;
			}
			break;
		}
		(obj as Publisher).Process(cmd);
	}

	[SecuritySafeCritical]
	internal static IrcMessageData Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : IrcEventArgs
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 10;
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
				case 10:
					num2 = (((P_1 ^ P_2) - 58) ^ num) switch
					{
						0 => ⴃႰ[203] - 59428, 
						_ => 9, 
					};
					continue;
				case 9:
					obj = null;
					num2 = ⴅ[407] - 95;
					continue;
				case 5:
					obj = P_0.Data;
					num2 = 7;
					continue;
				case 7:
					num++;
					num3 = 141;
					num4 = 354;
					goto case 1;
				case 1:
					num2 = ((2478 > num4 - num3 * 7) ? (ⴀ[144] - 15832) : 4);
					continue;
				case 2:
				case 4:
					num2 = 10;
					continue;
				case 8:
					return (IrcMessageData)obj;
				case 6:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}
}
