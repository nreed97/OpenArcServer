using System.Collections;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class SetWxDefaultHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 3;
			case 3:
			case 5:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267017155, typeof(qslinfoSoapChannel)));
				num = ⴀႼ[80] / 3;
				break;
			case 0:
			case 7:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130001, 6, '-'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(12, null, 1057165354, 3));
				num = 6;
				break;
			case 6:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 7, 62057614, null));
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(3, 14, 1217944674));
				obj = new Publisher();
				num = ⴀႼ[96];
				break;
			case 4:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : Hashtable
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		bool result = default(bool);
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
					num2 = 8;
					continue;
				case 8:
					break;
				case 4:
					num2 = (((P_2 ^ P_3) - 26) ^ num) switch
					{
						0 => 6, 
						_ => 9, 
					};
					continue;
				case 5:
				case 9:
					result = false;
					num2 = 1;
					continue;
				case 6:
					result = P_0.ContainsKey(P_1);
					num2 = 1;
					continue;
				case 1:
					num++;
					goto case 7;
				case 7:
				{
					int num3 = 343;
					int num4 = 838;
					num2 = ((5866 > num4 - num3 * 7) ? ⴅ[6] : (ⴐ[393] - 65));
					continue;
				}
				case 2:
				case 10:
					num2 = ⴐ[179] - 42;
					continue;
				case 0:
					return result;
				case 3:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte Ⴄ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : DxSpot
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte result = default(byte);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႠ[242] - 57243;
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
				case 10:
					num2 = (((P_1 ^ P_2) - 88) ^ num) switch
					{
						0 => 8, 
						1 => ⴃႰ[125] - 57497, 
						_ => ⴃႠ[236] - 47795, 
					};
					continue;
				case 6:
					result = 28;
					num2 = 0;
					continue;
				case 3:
				case 8:
					result = P_0.SkimDb;
					num2 = ⴍႭ[77] - 45733;
					continue;
				case 4:
				case 5:
					result = P_0.Unique;
					num2 = 0;
					continue;
				case 0:
					num++;
					num4 = P_2 * P_2;
					num4 = P_2 + num4;
					goto case 9;
				case 9:
					num2 = ⴐ[121] - 242;
					continue;
				case 11:
				{
					int num3 = num4 % 2;
					IpLockoutCacheCfg.ႭႭ[363] = (char)(IpLockoutCacheCfg.ႭႭ[363] & P_2 & 0xAE);
					num2 = ((num3 != 0) ? 10 : (ⴃႠ[324] - 29382));
					continue;
				}
				case 12:
					return result;
				case 7:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}
}
