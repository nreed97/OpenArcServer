using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Security;
using ArcEngine.ArcCmds.Node.Pc;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wwv;

public sealed class SetWwvDefaultHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int num = 6;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 1;
			case 1:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(5, null, 1267015791, typeof(InitTurnaroundPc20)));
				num = 0;
				break;
			case 0:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132736, 3, 'ô'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(17, null, 1057166244, 6));
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(7, '2', 952621301));
				goto case 3;
			case 3:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 0, 62057794, null));
				num = 4;
				break;
			case 4:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : IFormatProvider where _0021_00211 : string
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		float result = default(float);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႳ[282] - 35092;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
					break;
				case 9:
					num2 = (((P_2 ^ P_3) - 125) ^ num) switch
					{
						0 => ⴍႭ[262] - ⴍႭ[262], 
						_ => ⴍႭ[159] - 34486, 
					};
					continue;
				case 5:
				case 10:
					result = 0.27069646f;
					goto case 6;
				case 6:
					num2 = ⴃႰ[140] - 50924;
					continue;
				case 0:
					result = Convert.ToSingle(P_0, P_1);
					num2 = ⴃႥ[282] - 34436;
					continue;
				case 3:
				{
					num++;
					int num3 = 65;
					int num4 = 128;
					num2 = ((768 > num4 - num3 * 6) ? (ⴀႼ[127] - 32) : (ⴀႼ[47] - 145));
					continue;
				}
				case 11:
					num2 = 9;
					continue;
				case 1:
				case 7:
					return result;
				case 8:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴄ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DbConnection
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 9:
					break;
				case 1:
				{
					int num5 = P_1 ^ P_2;
					SetAnnChatRooms.Ⴀ[497] = (char)((SetAnnChatRooms.Ⴀ[497] * Arc4ServerClient.ႠႣ[315]) & 0xFB);
					num2 = ((num5 - 10) ^ num) switch
					{
						0 => ⴍႤ[193] - 9322, 
						_ => ⴀ[338] - 25694, 
					};
					continue;
				}
				case 6:
					enumerable = null;
					num2 = ⴀႳ[308] - 13033;
					continue;
				case 5:
					enumerable = P_0.ConnectionString;
					num2 = ⴀႨ[44] - 6928;
					continue;
				case 0:
				case 3:
				case 4:
				{
					num++;
					int num3 = 475;
					int num4 = 923;
					num2 = ((9230 > num4 - num3 * 10) ? 2 : ⴅ[92]);
					continue;
				}
				case 10:
				case 11:
					num2 = 1;
					continue;
				case 2:
					return (string)enumerable;
				case 8:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}
}
