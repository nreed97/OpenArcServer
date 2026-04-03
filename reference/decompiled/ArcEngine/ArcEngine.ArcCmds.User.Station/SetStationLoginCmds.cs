using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationLoginCmds : IArcCmd
{
	private static void Ⴃ(NodeUserCmd P_0)
	{
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 3:
			case 4:
			{
				IArcCmd arcCmd = new SetStationLoginCmdsHelp();
				((SetStationLoginCmdsHelp)arcCmd).Exec(P_0);
				obj = new Publisher();
				break;
			}
			case 0:
			case 1:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(5, 5, 1157898899), P_0.Rx.Msg, 1018, 948));
			num = 4;
		}
		((Publisher)obj).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		try
		{
			int num = 8;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					goto case 3;
				case 3:
					obj = new Publisher();
					num = ((cmd.Rx.Split.Length == 3) ? 5 : 0);
					break;
				case 5:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					(obj as Publisher).Process(cmd);
					num = 2;
					break;
				case 0:
					num = ((cmd.Rx.Split.Length <= 3) ? 7 : (ⴄႷ[29] - 57766));
					break;
				case 1:
				case 6:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					((Publisher)obj).Process(cmd);
					num = ⴀႼ[113];
					break;
				case 7:
					Ⴃ(cmd);
					return;
				case 2:
				case 4:
					return;
				}
			}
		}
		catch (Exception)
		{
			Ⴃ(cmd);
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴀ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : string where _0021_00211 : string
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႭ[17] - 119;
					continue;
				case 1:
				case 7:
					break;
				case 6:
					num2 = (((P_2 ^ P_3) - 32) ^ num) switch
					{
						0 => 2, 
						_ => ⴀ[281] - 5624, 
					};
					continue;
				case 4:
					result = P_3;
					num2 = 11;
					continue;
				case 2:
				case 9:
					result = P_0.CompareTo(P_1);
					num2 = 11;
					continue;
				case 11:
				{
					num++;
					int num3 = 1091;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? (ⴄႭ[244] - 86) : 8);
					continue;
				}
				case 8:
					num2 = 6;
					continue;
				case 5:
				case 10:
					return result;
				case 3:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴓ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, short P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int result = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႤ[137] / 9;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႥ[205] - 24724;
					continue;
				case 0:
					break;
				case 11:
					num2 = (((P_2 ^ P_3) - 46) ^ num) switch
					{
						0 => ⴃႠ[304] - 2906, 
						_ => 6, 
					};
					continue;
				case 6:
					result = 14;
					goto case 3;
				case 3:
					num2 = 5;
					continue;
				case 1:
				case 4:
					result = P_0.LastIndexOf(P_1);
					num2 = 5;
					continue;
				case 5:
					num++;
					goto case 2;
				case 2:
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					num2 = ⴅ[429] - ⴅ[195];
					continue;
				case 7:
				{
					int num5;
					if (num3 % 2 == 0)
					{
						char num4 = ⴀ[517];
						AnnCacheCfg.ႠႼ[107] = (byte)((AnnCacheCfg.ႠႼ[107] + P_3) & 0xE5);
						num5 = num4 - 55867;
					}
					else
					{
						num5 = 11;
					}
					num2 = num5;
					continue;
				}
				case 10:
					return result;
				case 9:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, OutputType P_1, char P_2, int P_3) where _0021_00210 : WxCfg
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 0:
			case 4:
				num = (((P_2 ^ P_3) - 5) ^ num2) switch
				{
					0 => 6, 
					_ => ⴄႤ[251] / 7, 
				};
				break;
			case 9:
				num = ⴀႣ[203] - 42477;
				break;
			case 6:
				P_0.Output = P_1;
				goto case 3;
			case 3:
				num2++;
				goto case 5;
			case 5:
			case 8:
			{
				int num3 = 192;
				int num4 = 237;
				num = ((1659 > num4 - num3 * 7) ? (ⴅ[145] / 7) : 2);
				break;
			}
			case 2:
				num = 4;
				break;
			case 1:
				return;
			}
		}
	}
}
