using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class SetDxModeHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 0;
			case 0:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267015442, typeof(ႨႥ)));
				goto case 4;
			case 4:
				num = 6;
				break;
			case 6:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216127347, 1, '\u0016'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(19, null, 1057166463, 4));
				num = ⴅ[118] - 57;
				break;
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(6, '/', 952616907));
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(0, '\u0014', 952620536));
				num = 7;
				break;
			case 7:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 5, 62057766, null));
				goto case 5;
			case 5:
				num = ⴀႼ[113];
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
	internal static int Ⴗ(ref DateTime P_0, int P_1, char P_2)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int result = default(int);
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
					num2 = 4;
					continue;
				case 4:
					break;
				case 10:
					num2 = (((P_2 ^ P_1) - 54) ^ num) switch
					{
						0 => ⴍႤ[381] - 31334, 
						_ => ⴃႰ[201] - 21667, 
					};
					continue;
				case 8:
					result = 1;
					goto case 6;
				case 6:
					num2 = 1;
					continue;
				case 7:
					result = P_0.Hour;
					num2 = 1;
					continue;
				case 0:
				case 1:
				case 5:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 3 : (ⴍႤ[307] - 52356));
					continue;
				case 9:
					num2 = 10;
					continue;
				case 3:
					return result;
				case 11:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}
}
