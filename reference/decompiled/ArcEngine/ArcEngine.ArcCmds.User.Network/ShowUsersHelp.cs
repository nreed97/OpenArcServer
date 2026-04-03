using System;
using System.Collections.Generic;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ShowUsersHelp : IArcCmd
{
	internal sealed class Ⴄ
	{
		internal Dictionary<string, CtyInfo> Ⴗ;

		internal Dictionary<string, CtyInfo> Ⴐ;

		internal int Ⴈ;

		internal int Ⴀ;

		internal Ⴄ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(5, null, 1267017703, typeof(ShowHamQthHelp)));
				num = 6;
				break;
			case 6:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129123, 4, '7'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(19, null, 1057165662, 0));
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(8, ']', 952620572));
				goto case 4;
			case 4:
				obj = new Publisher();
				num = 5;
				break;
			case 5:
				((Publisher)obj).Process(cmd);
				BandModeCacheCfg.ႠႳ[309] = (char)((BandModeCacheCfg.ႠႳ[309] * BandModeCacheCfg.ႠႳ[19]) & 0x93);
				return;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႥ[15] - 9479;
					continue;
				case 7:
					break;
				case 8:
					num2 = (((P_3 ^ P_2) - 78) ^ num) switch
					{
						0 => 10, 
						_ => 3, 
					};
					continue;
				case 3:
					obj = null;
					num2 = ⴐ[355] - 70;
					continue;
				case 0:
				case 10:
					obj = string.Concat(P_0, P_1);
					num2 = 2;
					continue;
				case 2:
				case 9:
				{
					num++;
					int num3 = 3620;
					int num4 = 627;
					num2 = ((905 < num3 / 4 - num4) ? 8 : (ⴄႷ[28] - 45681));
					continue;
				}
				case 1:
					return obj as string;
				case 6:
					num2 = ⴍႤ[200] - 56024;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴓ(float P_0, short P_1, short P_2)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 7;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[393] - 58;
					continue;
				case 9:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 101) ^ num) switch
					{
						0 => 4, 
						_ => ⴅ[162] - 81, 
					};
					continue;
				case 5:
					result = 13;
					goto case 1;
				case 1:
					num2 = 2;
					continue;
				case 4:
					result = Convert.ToInt32(P_0);
					num2 = ⴅ[476] - 112;
					continue;
				case 2:
					num++;
					goto case 8;
				case 8:
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴍႭ[92] - 9990) : (ⴀႨ[142] - 65004));
					continue;
				case 3:
				case 11:
					num2 = ⴃႠ[306] - 23243;
					continue;
				case 6:
					return result;
				case 10:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}
}
