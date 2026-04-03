using System;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationEmail : IArcCmd
{
	private static void Ⴈ(NodeUserCmd P_0)
	{
		int num = 1;
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 4:
			{
				object obj = new SetStationEmailHelp();
				((SetStationEmailHelp)obj).Exec(P_0);
				obj2 = new Publisher();
				break;
			}
			case 0:
				break;
			case 3:
				return;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(11, 6, 1157904845), P_0.Rx.Msg, 698, 756));
			num = 4;
		}
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		try
		{
			int num = 7;
			ICloneable cloneable = default(ICloneable);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = ((cmd.Rx.Split.Length <= 3) ? (ⴀႳ[335] - 20587) : 2);
					continue;
				case 2:
					cloneable = LogEntry.Ⴄ(cmd.Rx.GetMsgEnd(3), 'ʾ', 660);
					goto case 6;
				case 6:
					num = ((!SkimmerValidSpot.Ⴈ(cloneable as string, 343, 290)) ? 3 : (ⴍႤ[297] - 13033));
					continue;
				case 9:
					ShowHamHelp.Ⴍ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 735, 713), (string)cloneable, '\u0335', 842);
					num = 11;
					continue;
				case 11:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetTalkCount.Ⴗ(6, null, 1267019607, typeof(PublishInfo)), (string)cloneable, 518, 584));
					goto case 5;
				case 5:
					num = ⴄႷ[31] - 42315;
					continue;
				case 8:
				{
					object obj = new Publisher();
					(obj as Publisher).Process(cmd);
					num = ⴍႭ[177] - 18116;
					continue;
				}
				case 3:
					cmd.Tx.Msg.Add(ႰႥ.Ⴅ(2, 'M', 952621122));
					Ⴈ(cmd);
					goto case 0;
				case 0:
					num = ⴀႨ[185] - 58119;
					continue;
				case 10:
					Ⴈ(cmd);
					break;
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴈ(cmd);
		}
		switch (2)
		{
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : WwvSpot
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႰ[105] - 25529;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႰ[132] - 63459;
					continue;
				case 7:
					break;
				case 4:
				case 11:
					num2 = (((P_1 ^ P_2) - 112) ^ num) switch
					{
						0 => 12, 
						1 => 2, 
						_ => 3, 
					};
					continue;
				case 3:
					equatable = null;
					goto case 6;
				case 6:
					num2 = ⴃႰ[139] - ⴃႰ[139];
					continue;
				case 12:
					equatable = P_0.A;
					num2 = 0;
					continue;
				case 2:
					equatable = P_0.DupeKey;
					num2 = 0;
					continue;
				case 0:
				{
					num++;
					int num3 = 61;
					int num4 = 141;
					num2 = ((1410 > num4 - num3 * 10) ? (ⴄႷ[23] - 32505) : 10);
					continue;
				}
				case 10:
					num2 = 11;
					continue;
				case 8:
					return (string)equatable;
				case 1:
				case 9:
					num2 = ⴃႠ[185] - 15217;
					continue;
				}
				break;
			}
		}
	}
}
