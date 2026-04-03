using System.IO;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class DeleteMailHelp : IArcCmd
{
	internal sealed class Ⴈ
	{
		internal int Ⴐ;

		internal string Ⴄ;

		internal Ⴈ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 4;
			case 4:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267022839, typeof(ႷႳ)));
				goto case 2;
			case 2:
				num = 1;
				break;
			case 1:
			case 5:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133317, 3, 'c'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(9, null, 1057162011, 3));
				num = 6;
				break;
			case 6:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(6, 'ï', 952620084));
				obj = new Publisher();
				num = 3;
				break;
			case 3:
				(obj as Publisher).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, short P_3) where _0021_00210 : string where _0021_00211 : BinaryWriter
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 9;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 1;
				break;
			case 1:
				num = (((P_3 ^ P_2) - 68) ^ num3) switch
				{
					0 => 8, 
					_ => ⴐ[50] - ⴐ[257], 
				};
				break;
			case 5:
				num = ⴍႭ[34] - 15436;
				break;
			case 8:
				P_0.Write(P_1);
				goto case 2;
			case 2:
			case 7:
				num3++;
				num2 = P_3 * P_3;
				goto case 0;
			case 0:
				num2 = P_3 + num2;
				num = ⴀႳ[84] - 27441;
				break;
			case 3:
			case 4:
				num = ((num2 % 2 != 0) ? 1 : (ⴀ[162] - 41832));
				break;
			case 6:
				return;
			}
		}
	}
}
