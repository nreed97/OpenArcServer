using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Talk;

public sealed class ShowTalkOptionsHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 5;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(0, null, 1267014065, typeof(ShowQrzHelp)));
				num = ⴀႼ[96];
				break;
			case 4:
			case 6:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130681, 5, 'Y'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(25, null, 1057166571, 2));
				num = 0;
				break;
			case 0:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(6, '\u008e', 952616547));
				obj = new Publisher();
				num = 3;
				break;
			case 2:
			case 3:
				(obj as Publisher).Process(cmd);
				ႨႣ.Ⴐ[265] = SetAnnMode.ႤႭ[76];
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : WwvSpot
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႤ[47] / 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 10:
					break;
				case 4:
					num2 = (((P_2 ^ P_1) - 7) ^ num) switch
					{
						0 => ⴄႤ[47] - 9, 
						_ => 11, 
					};
					continue;
				case 11:
					obj = null;
					num2 = 1;
					continue;
				case 3:
					obj = P_0.Sfi;
					num2 = ⴃႰ[41] - 751;
					continue;
				case 1:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 8 : 0);
					continue;
				case 0:
					num2 = 4;
					continue;
				case 2:
				case 6:
				case 8:
					return (string)obj;
				case 7:
				case 9:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : WwvSpot
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		bool result = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 3;
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
					num2 = (((P_1 ^ P_2) - 23) ^ num) switch
					{
						0 => 2, 
						_ => ⴀႣ[431] - 41552, 
					};
					continue;
				case 8:
					result = true;
					num2 = ⴄႭ[94];
					continue;
				case 2:
				case 6:
					result = P_0.IsDupe;
					num2 = 7;
					continue;
				case 7:
					num++;
					num3 = 90;
					num4 = 14;
					goto case 5;
				case 5:
					num2 = ((30 >= num3 / 3 - num4) ? 1 : 3);
					continue;
				case 1:
				case 9:
					return result;
				case 4:
					num2 = ⴅ[481] - ⴅ[185];
					continue;
				}
				break;
			}
		}
	}
}
