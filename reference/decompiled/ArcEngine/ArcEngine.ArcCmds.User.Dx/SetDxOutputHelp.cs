using System.Collections;
using System.Data;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class SetDxOutputHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(5, null, 1267016725, typeof(ShowCluster.ႨႨ)));
				num = ⴀႼ[66] - 61;
				break;
			case 3:
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129246, 8, '\u009f'));
				goto case 2;
			case 2:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(20, null, 1057165566, 8));
				num = ⴄႭ[66] * 2;
				break;
			case 0:
			case 6:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(4, 'Ö', 952620540));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 5, 62057766, null));
				num = 5;
				break;
			case 5:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static IEnumerator Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : InternalDataCollectionBase
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			byte num2 = ⴄႤ[131];
			SetAnnMode.ႤႭ[555] = (byte)((SetAnnMode.ႤႭ[555] ^ SetWxOutput.ႣႰ[128]) & 0xF7);
			int num3 = num2 - 202;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = ⴄႤ[148] * 6;
					continue;
				case 6:
					break;
				case 0:
					num3 = (((P_2 ^ P_1) - 25) ^ num) switch
					{
						0 => ⴀႳ[301] - 36926, 
						_ => 2, 
					};
					continue;
				case 2:
					obj = null;
					goto case 3;
				case 3:
					num3 = 11;
					continue;
				case 1:
				case 4:
					obj = P_0.GetEnumerator();
					num3 = 11;
					continue;
				case 10:
				case 11:
					num++;
					num3 = (((P_1 * P_1 + P_1) % 2 == 0) ? 9 : 5);
					continue;
				case 5:
					num3 = ⴀႣ[168] - 41412;
					continue;
				case 9:
					return obj as IEnumerator;
				case 8:
					num3 = 0;
					continue;
				}
				break;
			}
		}
	}
}
