using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowHeadingHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267022964, typeof(ႥႭ)));
				goto case 6;
			case 6:
				num = ⴄႭ[246] / 2;
				break;
			case 1:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134435, 7, '\v'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(23, null, 1057163251, 3));
				goto case 4;
			case 4:
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(2, '\u0001', 952620889));
				goto case 2;
			case 2:
				obj = new Publisher();
				num = 5;
				break;
			case 5:
				(obj as Publisher).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : Letter
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[126] - 39164;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 1;
					continue;
				case 1:
					break;
				case 6:
					num2 = (((P_1 ^ P_2) - 127) ^ num) switch
					{
						0 => 5, 
						1 => 11, 
						_ => ⴍႤ[110] - 58442, 
					};
					continue;
				case 0:
					result = false;
					num2 = 3;
					continue;
				case 5:
					result = P_0.ReadFlag;
					num2 = ⴀႳ[349] - 20131;
					continue;
				case 7:
				case 11:
					result = P_0.PvtFlag;
					num2 = ⴐ[21];
					continue;
				case 3:
					num++;
					goto case 10;
				case 10:
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 9 : 12);
					continue;
				case 12:
					num2 = 6;
					continue;
				case 9:
					return result;
				case 8:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}
}
