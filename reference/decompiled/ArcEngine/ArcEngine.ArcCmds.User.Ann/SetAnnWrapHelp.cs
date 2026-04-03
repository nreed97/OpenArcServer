using System.Data.Common;
using System.Security;
using System.Security.Cryptography;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcServerConfig.Caches;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnWrapHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 3;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(1, null, 1267018778, typeof(ShowWwv)));
				goto case 1;
			case 1:
			case 4:
			case 7:
				num = ⴃႥ[405] - 45701;
				break;
			case 2:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132115, 8, '5'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(27, null, 1057164579, 6));
				num = ⴀႼ[80];
				break;
			case 0:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 7, 62058367, null));
				num = ⴀႳ[334] - 33628;
				break;
			case 6:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(4, 10, 1217945176));
				obj = new Publisher();
				num = 5;
				break;
			case 5:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DbConnection
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 9;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 7;
				break;
			case 7:
				num = (((P_2 ^ P_1) - 3) ^ num3) switch
				{
					0 => ⴅ[210], 
					_ => 4, 
				};
				break;
			case 4:
				num = 6;
				break;
			case 8:
				P_0.Open();
				goto case 3;
			case 3:
			case 6:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = ⴄႷ[122] - 47405;
				break;
			case 2:
				num = ((num2 % 2 == 0) ? 1 : 7);
				break;
			case 0:
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, byte[] P_1, int P_2, int P_3) where _0021_00210 : SymmetricAlgorithm
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 2;
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = 7;
				continue;
			case 1:
			case 7:
				ShowQrzHelp.ႤႤ[282] = SetAnnMode.ႤႭ[88];
				num = (((P_2 ^ P_3) - 122) ^ num4) switch
				{
					0 => 8, 
					_ => 5, 
				};
				continue;
			case 5:
				num = ⴃႠ[82] - 35497;
				continue;
			case 8:
				P_0.Key = P_1;
				goto case 6;
			case 6:
			case 9:
			{
				num4++;
				num3 = 418;
				int num5 = num3;
				num2 = num5 * num5;
				num = ⴍႭ[236] - 49242;
				continue;
			}
			case 0:
				num2 = num3 + num2;
				break;
			case 4:
				break;
			case 3:
				return;
			}
			num = ((num2 % 2 != 0) ? 7 : 3);
		}
	}
}
