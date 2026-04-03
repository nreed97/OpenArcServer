using System;
using System.Reflection;
using System.Security;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationNameHelp : IArcCmd
{
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
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267022095, typeof(DxSpotPc11)));
				num = 0;
				continue;
			case 0:
			case 2:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134123, 4, '6'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(17, null, 1057161695, 5));
				num = 3;
				continue;
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(1, 'x', 952620048));
				goto case 4;
			case 4:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 2, 62057751, null));
				num = 5;
				continue;
			case 5:
				obj = new Publisher();
				break;
			case 6:
				break;
			}
			break;
		}
		((Publisher)obj).Process(cmd);
		IpLockoutCacheCfg.ႭႭ[205] = (char)(IpLockoutCacheCfg.ႭႭ[205] & ႨႣ.Ⴐ[212] & 0x3D);
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : MemberInfo
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႼ[110] - 213;
					continue;
				case 10:
					break;
				case 5:
					num2 = (((P_2 ^ P_1) - 51) ^ num) switch
					{
						0 => 7, 
						_ => 1, 
					};
					continue;
				case 1:
					comparable = null;
					num2 = 8;
					continue;
				case 7:
					comparable = P_0.Name;
					num2 = 8;
					continue;
				case 6:
				case 8:
					num++;
					num3 = 113;
					goto case 2;
				case 2:
				{
					int num4 = 658;
					num2 = ((1974 > num4 - num3 * 3) ? 11 : (ⴍႤ[277] - 28934));
					continue;
				}
				case 9:
					num2 = 5;
					continue;
				case 11:
					return (string)comparable;
				case 4:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}
}
