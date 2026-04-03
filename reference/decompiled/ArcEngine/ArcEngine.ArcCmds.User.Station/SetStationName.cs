using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationName : IArcCmd
{
	private static void Ⴗ(NodeUserCmd P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(2, 8, 1157903730), P_0.Rx.Msg, 783, 833));
				goto IL_0059;
			case 1:
				goto IL_0059;
			case 0:
			{
				object obj = new SetStationNameHelp();
				((SetStationNameHelp)obj).Exec(P_0);
				break;
			}
			case 2:
			case 4:
				break;
			}
			break;
			IL_0059:
			num = ⴃႥ[136] - 30635;
		}
		object obj2 = new Publisher();
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			int num = 7;
			object msgEnd = default(object);
			while (true)
			{
				switch (num)
				{
				default:
				{
					cmd.Tx.DistroType = DistroType.ToRequester;
					int num2 = cmd.Rx.Split.Length;
					SetAnnChatRooms.Ⴀ[136] = (char)((SetAnnChatRooms.Ⴀ[136] * Arc4ServerClient.ႠႣ[330]) & 0xAA);
					num = ((num2 <= 3) ? 3 : (ⴄႷ[139] - 44118));
					continue;
				}
				case 8:
				case 9:
					msgEnd = cmd.Rx.GetMsgEnd(3);
					SetDxDefaultHelp.Ⴓ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 119, 97), msgEnd as string, 493, 501);
					goto case 6;
				case 6:
					num = ⴀ[55] - 39160;
					continue;
				case 4:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(CallBlockCacheCfg.Ⴅ(null, 0, 62058322, null), msgEnd as string, 753, 703));
					num = 5;
					continue;
				case 5:
				{
					object obj = new Publisher();
					(obj as Publisher).Process(cmd);
					num = ⴀႳ[106] - 34489;
					continue;
				}
				case 3:
					Ⴗ(cmd);
					break;
				case 0:
				case 2:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴗ(cmd);
		}
		switch (3)
		{
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : Letter
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႠ[172] - 24990;
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
				case 6:
				case 7:
					num2 = (((P_2 ^ P_1) - 46) ^ num) switch
					{
						0 => ⴍႤ[359] - 6546, 
						_ => 0, 
					};
					continue;
				case 0:
				case 11:
					result = true;
					num2 = ⴍႤ[226] - 61475;
					continue;
				case 8:
					result = P_0.RtnRcptFlag;
					num2 = ⴃႥ[237] - 10177;
					continue;
				case 3:
				case 5:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = ⴄႤ[57] - 198;
					continue;
				case 4:
					num2 = ((num3 % 2 != 0) ? 6 : 2);
					continue;
				case 2:
					return result;
				case 10:
					num2 = ⴍႭ[308] - 22564;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴅ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : AnnCfg
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		bool result = default(bool);
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
					num2 = 2;
					continue;
				case 2:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 28) ^ num) switch
					{
						0 => 9, 
						_ => ⴀႼ[96], 
					};
					continue;
				case 4:
					result = false;
					num2 = 6;
					continue;
				case 1:
				case 5:
				case 9:
					result = P_0.Wrap;
					num2 = 6;
					continue;
				case 3:
				case 6:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = ⴄႤ[257] - 237;
					continue;
				case 8:
					num2 = ((num3 % 2 != 0) ? (ⴄႷ[50] - 56632) : (ⴃႠ[233] - 58631));
					continue;
				case 11:
					return result;
				case 10:
					num2 = ⴐ[257];
					continue;
				}
				break;
			}
		}
	}
}
