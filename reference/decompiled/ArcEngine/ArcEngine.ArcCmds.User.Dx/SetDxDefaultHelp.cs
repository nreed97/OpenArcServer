using System.Collections;
using System.IO;
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
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class SetDxDefaultHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(3, null, 1267023212, typeof(ShowWxHelp)));
				goto case 0;
			case 0:
			case 5:
				num = ⴃႠ[149] - 18451;
				break;
			case 6:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134571, 5, '±'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(31, null, 1057163132, 1));
				num = ⴄႤ[139] / 7;
				break;
			case 2:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(3, '*', 952620539));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 8, 62057771, null));
				num = 1;
				break;
			case 1:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ(object[] P_0, char P_1, short P_2)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		IEnumerable enumerable = default(IEnumerable);
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
					num2 = 8;
					continue;
				case 8:
					break;
				case 9:
					num2 = (((P_1 ^ P_2) - 105) ^ num) switch
					{
						0 => 1, 
						_ => ⴅ[429] - 131, 
					};
					continue;
				case 5:
				case 6:
					enumerable = null;
					num2 = 2;
					continue;
				case 1:
					enumerable = string.Concat(P_0);
					num2 = 2;
					continue;
				case 2:
				{
					num++;
					int num3 = 1;
					int num4 = 85;
					num2 = ((255 > num4 - num3 * 3) ? (ⴀႼ[60] - 78) : 7);
					continue;
				}
				case 7:
				case 10:
					num2 = 9;
					continue;
				case 3:
				case 11:
					return (string)enumerable;
				case 4:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : string where _0021_00211 : StationCfg
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 6;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴐ[257];
				break;
			case 7:
				num = (((P_3 ^ P_2) - 24) ^ num3) switch
				{
					0 => ⴅ[315] - 196, 
					_ => ⴄႤ[47] / 4, 
				};
				break;
			case 3:
				num = ⴄႷ[38] - 46341;
				break;
			case 1:
				P_0.Name = P_1;
				goto case 0;
			case 0:
			case 5:
			case 8:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = ⴀႳ[130] - 25459;
				break;
			case 4:
				num = ((num2 % 2 != 0) ? 7 : 9);
				break;
			case 2:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long Ⴃ<_0021_00210>(_0021_00210 P_0, long P_1, SeekOrigin P_2, short P_3, int P_4) where _0021_00210 : Stream
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		long result = default(long);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႭ[363] - ⴄႭ[338];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႤ[488] - 14198;
					continue;
				case 2:
					break;
				case 11:
					num2 = (((P_4 ^ P_3) - 22) ^ num) switch
					{
						0 => ⴃႰ[139] - 40020, 
						_ => ⴀႨ[152] - 10544, 
					};
					continue;
				case 4:
				case 5:
					result = P_1;
					num2 = 3;
					continue;
				case 7:
				case 8:
				case 10:
					result = P_0.Seek(P_1, P_2);
					num2 = ⴀႣ[281] - 27607;
					continue;
				case 3:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? 9 : 0);
					continue;
				case 0:
					num2 = ⴄႤ[278] - 21;
					continue;
				case 9:
					return result;
				case 6:
				{
					byte num3 = ⴅ[265];
					TxNodeUserCmd.ႤႷ[67] = (char)((TxNodeUserCmd.ႤႷ[67] ^ AnnCacheCfg.ႠႼ[91]) & 0xC8);
					num2 = num3 - 211;
					continue;
				}
				}
				break;
			}
		}
	}
}
