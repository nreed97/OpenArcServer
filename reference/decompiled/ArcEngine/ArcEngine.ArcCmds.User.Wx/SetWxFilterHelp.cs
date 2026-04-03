using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class SetWxFilterHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(5, null, 1267018832, typeof(ႥႤ)));
				num = ⴄႭ[5] - ⴄႭ[273];
				break;
			case 1:
			case 6:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132195, 0, '8'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(1, null, 1057164725, 3));
				num = 7;
				break;
			case 7:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(2, '\\', 952621547));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 6, 62054856, null));
				goto case 3;
			case 3:
			case 4:
				num = ⴄႤ[293] - 127;
				break;
			case 2:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(8, 7, 1217941586));
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(8, 10, 1217944681));
				num = 0;
				break;
			case 0:
			{
				object obj = new Publisher();
				(obj as Publisher).Process(cmd);
				Arc4ServerClient.ႠႣ[46] = (char)((Arc4ServerClient.ႠႣ[46] + Arc4ServerClient.ႠႣ[361]) & 4);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static double Ⴀ(double P_0, short P_1, short P_2)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		double result = default(double);
		while (true)
		{
			int num = 0;
			int num2 = 9;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 28) ^ num) switch
					{
						0 => 6, 
						1 => 5, 
						_ => 7, 
					};
					continue;
				case 7:
					result = P_0;
					num2 = 4;
					continue;
				case 6:
				case 8:
				case 10:
					result = Math.Acos(P_0);
					num2 = 4;
					continue;
				case 5:
					result = Math.Sqrt(P_0);
					num2 = 4;
					continue;
				case 4:
					num++;
					goto case 0;
				case 0:
				{
					int num3 = 90;
					int num4 = 26;
					num2 = ((45 < num3 / 2 - num4) ? 9 : (ⴄႷ[29] - 57769));
					continue;
				}
				case 3:
					return result;
				case 1:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}
}
