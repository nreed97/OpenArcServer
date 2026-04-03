using System.Collections;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Mirc;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.Dx;

public class DxTestHelp : IArcCmd
{
	internal sealed class Ⴀ
	{
		internal ႷႠ Ⴄ;

		internal DxCache Ⴅ;

		internal AnnCache Ⴗ;

		internal WxCache Ⴃ;

		internal TalkCache Ⴀ;

		internal LogCache Ⴍ;

		internal ႰႷ Ⴓ;

		internal Ⴀ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(8, null, 1267019050, typeof(MircIo)));
				num = ⴃႥ[272] - 34069;
				break;
			case 2:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132946, 8, '>'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(26, null, 1057164532, 6));
				goto case 3;
			case 3:
				num = ⴃႥ[231] - 57240;
				break;
			case 4:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 7, 62057764, null));
				num = 0;
				break;
			case 0:
			{
				object obj = new Publisher();
				(obj as Publisher).Process(cmd);
				return;
			}
			case 1:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211, _0021_00212>(_0021_00212 P_0, _0021_00210 P_1, _0021_00211 P_2, char P_3, short P_4) where _0021_00212 : Hashtable
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 7;
				break;
			case 7:
				num = (((P_3 ^ P_4) - 101) ^ num2) switch
				{
					0 => ⴀႨ[4] - 27042, 
					_ => ⴃႥ[149] - ⴃႥ[149], 
				};
				break;
			case 0:
			case 4:
				num = ⴀႳ[73] - 16654;
				break;
			case 2:
			case 9:
				P_0[P_1] = P_2;
				goto case 3;
			case 3:
			{
				num2++;
				int num3 = (P_3 * P_3 + P_3) % 2;
				SetDxCountHelp.ႭႤ[423] = (SetDxCountHelp.ႭႤ[423] - P_4) & 0x7E;
				num = ((num3 == 0) ? 1 : 6);
				break;
			}
			case 6:
			case 8:
				num = 7;
				break;
			case 1:
				return;
			}
		}
	}
}
