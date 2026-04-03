using System.IO;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wwv;

public sealed class SetWwvCountHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 3;
			case 3:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(8, null, 1267017536, typeof(ႨႰ)));
				num = 7;
				break;
			case 7:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129454, 1, 'V'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(15, null, 1057165747, 4));
				goto case 4;
			case 4:
				num = ⴃႠ[97] - 45517;
				break;
			case 6:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(3, 'H', 952621965));
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(3, '\u009e', 952621297));
				goto case 2;
			case 2:
				num = 0;
				break;
			case 0:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 2, 62057792, null));
				num = 1;
				break;
			case 1:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				TxNodeUserCmd.ႤႷ[108] = (char)((TxNodeUserCmd.ႤႷ[108] ^ TxNodeUserCmd.ႤႷ[73]) & 0xCC);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : string where _0021_00211 : ClientIoCfg
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 5;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႰ[99] - 21867;
				continue;
			case 2:
				num = (((P_3 ^ P_2) - 106) ^ num2) switch
				{
					0 => 4, 
					_ => 1, 
				};
				continue;
			case 1:
				num = 0;
				continue;
			case 4:
				P_0.ConnectTo = P_1;
				goto case 0;
			case 0:
			case 3:
				num2++;
				num3 = 3568;
				break;
			case 7:
			case 8:
				break;
			case 6:
				return;
			}
			int num4 = 281;
			num = ((892 < num3 / 4 - num4) ? (ⴃႥ[207] - 24063) : (ⴍႭ[250] - 12376));
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, long P_1, int P_2, short P_3) where _0021_00210 : BinaryWriter
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 3;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴍႭ[14] - 22033;
				continue;
			case 1:
				num = (((P_2 ^ P_3) - 118) ^ num2) switch
				{
					0 => 0, 
					_ => ⴀႨ[99] - 1056, 
				};
				continue;
			case 4:
			case 5:
				num = 8;
				continue;
			case 0:
			case 2:
				P_0.Write(P_1);
				goto case 8;
			case 8:
				num2++;
				num3 = 3063;
				break;
			case 6:
				break;
			case 7:
				return;
			}
			int num4 = 732;
			num = ((1021 < num3 / 3 - num4) ? 1 : 7);
		}
	}
}
