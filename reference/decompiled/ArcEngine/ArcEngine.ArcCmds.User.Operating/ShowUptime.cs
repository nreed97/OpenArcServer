using System;
using System.Security;
using System.Text;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowUptime : IArcCmd
{
	private static void Ⴃ(NodeUserCmd P_0)
	{
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(9, 8, 1157900102), P_0.Rx.Msg, 481, 431));
				goto IL_0053;
			case 4:
				goto IL_0053;
			case 2:
			{
				IArcCmd arcCmd = new ShowUptimeHelp();
				((ShowUptimeHelp)arcCmd).Exec(P_0);
				obj = new Publisher();
				break;
			}
			case 1:
			case 3:
				break;
			}
			break;
			IL_0053:
			num = 2;
		}
		((Publisher)obj).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		int num = 5;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				if (cmd.Rx.Split.Length == 2)
				{
					num = 2;
					continue;
				}
				Ⴃ(cmd);
				return;
			case 2:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(Ⴍ(cmd));
				num = 1;
				continue;
			case 1:
			case 3:
				obj = new Publisher();
				break;
			case 4:
				break;
			case 0:
				return;
			}
			break;
		}
		((Publisher)obj).Process(cmd);
	}

	private static string Ⴍ(NodeUserCmd P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		while (true)
		{
			TimeSpan timeSpan = P_0.Ⴍ().Ⴅ().Ⴐ()
				.Ⴅ();
			while (true)
			{
				IL_0067:
				IEquatable<string> equatable = timeSpan.ToString();
				int num = 0;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴍႤ[312] - 37286;
						continue;
					case 2:
					case 7:
						break;
					case 3:
						goto IL_0067;
					case 0:
						equatable = SetTalkOutputHelp.Ⴍ((string)equatable, 0, CallBlockCacheCfg.Ⴜ((string)equatable, 869, 772) - 8, 875, 824);
						num = ⴃႰ[200] - 13089;
						continue;
					case 8:
					{
						int num2 = CallBlockCacheCfg.Ⴜ((string)equatable, 253, 156);
						SetWxOutput.ႣႰ[54] = (char)((SetWxOutput.ႣႰ[54] ^ SetWxOutput.ႣႰ[85]) & 0x6E);
						num = ((num2 != 8) ? (ⴃႰ[32] - 1117) : 6);
						continue;
					}
					case 6:
						equatable = ShowUsersHelp.Ⴅ(SetTalkCount.Ⴗ(3, null, 1267016728, typeof(DirectorySubject)), (string)equatable, 227, 173);
						num = 5;
						continue;
					case 1:
					case 5:
						return ReplyMailHelp.Ⴄ(29, null, 1057165520, 0) + (equatable as string);
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : CtyInfo
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte result = default(byte);
		int num4 = default(int);
		int num3 = default(int);
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
					num2 = 5;
					continue;
				case 5:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 43) ^ num) switch
					{
						0 => ⴃႥ[329] - 21281, 
						_ => 3, 
					};
					continue;
				case 3:
					result = 29;
					goto case 7;
				case 7:
					num2 = ⴀႳ[262] - ⴀႳ[262];
					continue;
				case 2:
					result = P_0.CqZone;
					num2 = ⴐ[254] / 8;
					continue;
				case 0:
				case 10:
				{
					num++;
					num4 = 1327;
					int num5 = num4;
					num3 = num5 * num5;
					num2 = 6;
					continue;
				}
				case 6:
					num3 = num4 + num3;
					goto case 11;
				case 11:
					num2 = ((num3 % 2 != 0) ? 1 : 8);
					continue;
				case 8:
					return result;
				case 4:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, byte P_1, char P_2, int P_3) where _0021_00210 : DxSpot
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
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
				num = (((P_3 ^ P_2) - 32) ^ num3) switch
				{
					0 => ⴍႭ[184] - ⴍႭ[184], 
					_ => ⴀႳ[263] - 11618, 
				};
				break;
			case 7:
			case 8:
				num = ⴍႤ[326] - 33211;
				break;
			case 0:
				P_0.SpotterCqZone = P_1;
				goto case 4;
			case 4:
				num3++;
				num2 = P_1 * P_1;
				num2 = P_1 + num2;
				num = ⴃႠ[146] - 42164;
				break;
			case 2:
			case 3:
				num = ((num2 % 2 != 0) ? 1 : 5);
				break;
			case 5:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Encoding Ⴗ(short P_0, short P_1)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 3:
					num2 = (((P_0 ^ P_1) - 78) ^ num) switch
					{
						0 => ⴀႨ[100] - 1188, 
						_ => 5, 
					};
					continue;
				case 5:
					obj = null;
					num2 = 4;
					continue;
				case 8:
				case 10:
					obj = Encoding.ASCII;
					num2 = 4;
					continue;
				case 4:
					num++;
					num3 = 838;
					num4 = 975;
					goto case 7;
				case 7:
					num2 = ((3900 > num4 - num3 * 4) ? 1 : 0);
					continue;
				case 0:
					num2 = 3;
					continue;
				case 1:
					return (Encoding)obj;
				case 2:
				case 9:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}
}
