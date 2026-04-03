using System;
using System.IO;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationLatLonHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
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
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267016159, typeof(SetWxDefault)));
				goto case 6;
			case 6:
				num = ⴍႭ[239] - 12401;
				break;
			case 7:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129297, 5, 'õ'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(26, null, 1057166096, 4));
				num = 1;
				break;
			case 1:
			case 2:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(8, '\u0089', 952621570));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 5, 62055114, null));
				num = ⴀႨ[122] - 31853;
				break;
			case 4:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(0, '\\', 952620049));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 2, 62057751, null));
				num = ⴃႠ[67] - 9309;
				break;
			case 0:
			{
				object obj = new Publisher();
				(obj as Publisher).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static double Ⴍ(double P_0, double P_1, short P_2, int P_3)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		double result = default(double);
		int num3 = default(int);
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
					num2 = 1;
					continue;
				case 1:
					break;
				case 7:
					num2 = (((P_3 ^ P_2) - 55) ^ num) switch
					{
						0 => ⴀႳ[300] - 10813, 
						_ => ⴍႤ[307] - 52354, 
					};
					continue;
				case 11:
					result = 1.552131652241422;
					num2 = 3;
					continue;
				case 5:
					result = Math.Atan2(P_0, P_1);
					num2 = 3;
					continue;
				case 0:
				case 3:
					num++;
					goto case 6;
				case 6:
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 2;
					continue;
				case 2:
					num2 = ((num3 % 2 != 0) ? 7 : ⴐ[243]);
					continue;
				case 8:
					return result;
				case 9:
					num2 = ⴀႣ[321] - 33316;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static FileStream Ⴅ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[181] - 76;
					continue;
				case 1:
				case 6:
					break;
				case 2:
					num2 = (((P_1 ^ P_2) - 15) ^ num) switch
					{
						0 => 7, 
						_ => ⴀႨ[141] - 33431, 
					};
					continue;
				case 5:
					obj = null;
					goto case 10;
				case 10:
					num2 = ⴀႼ[96];
					continue;
				case 7:
				case 9:
					obj = File.Create(P_0);
					num2 = ⴄႤ[249] + 0;
					continue;
				case 4:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 != 0) ? 11 : 0);
					continue;
				case 11:
					num2 = 2;
					continue;
				case 0:
					return obj as FileStream;
				case 8:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}
}
