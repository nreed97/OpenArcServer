using System.Collections.Generic;
using System.Security;
using System.Text;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnFilterHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int num = 7;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267013952, typeof(ReplyMailHelp)));
				num = 5;
				break;
			case 0:
			case 5:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130942, 0, '~'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(28, null, 1057166790, 0));
				num = 1;
				break;
			case 1:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(6, '\u00b4', 952616677));
				goto case 2;
			case 2:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 8, 62054854, null));
				goto case 6;
			case 6:
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(1, 13, 1217940854));
				obj = new Publisher();
				num = 4;
				break;
			case 4:
				(obj as Publisher).Process(cmd);
				BandModeCacheCfg.ႠႳ[134] = (char)((BandModeCacheCfg.ႠႳ[134] | Arc4ServerClient.ႠႣ[279]) & 0x29);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, byte[] P_1, int P_2, int P_3, int P_4, short P_5) where _0021_00210 : Encoding
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[17] - 26;
					continue;
				case 4:
					break;
				case 5:
				case 8:
					num2 = (((P_4 ^ P_5) - 58) ^ num) switch
					{
						0 => 10, 
						_ => 2, 
					};
					continue;
				case 2:
					enumerable = null;
					num2 = ⴀႳ[66] - 4075;
					continue;
				case 0:
				case 10:
					enumerable = P_0.GetString(P_1, P_2, P_3);
					num2 = 3;
					continue;
				case 1:
				case 3:
				{
					num++;
					int num3 = 890;
					int num4 = 175;
					num2 = ((445 < num3 / 2 - num4) ? ⴀႼ[136] : 6);
					continue;
				}
				case 6:
					return (string)enumerable;
				case 7:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}
}
