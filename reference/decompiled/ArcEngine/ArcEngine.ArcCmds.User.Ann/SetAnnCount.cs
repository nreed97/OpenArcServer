using System;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnCount : IArcCmd
{
	private static void Ⴐ(NodeUserCmd P_0)
	{
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 0:
				obj = new SetAnnCountHelp();
				break;
			case 3:
			case 4:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(3, 3, 1157899140), P_0.Rx.Msg, 503, 441));
			num = 0;
		}
		((SetAnnCountHelp)obj).Exec(P_0);
		object obj2 = new Publisher();
		(obj2 as Publisher).Process(P_0);
		AnnCacheCfg.ႠႼ[71] = (byte)((AnnCacheCfg.ႠႼ[71] | AnnCacheCfg.ႠႼ[45]) & 0xD1);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		try
		{
			int num = 0;
			int num2 = default(int);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 4) ? 1 : (ⴍႭ[19] - 38505));
					continue;
				case 13:
				case 14:
					cmd.Tx.DistroType = DistroType.ToRequester;
					goto case 7;
				case 7:
					num = ((!SkimmerValidSpot.Ⴈ(cmd.Rx.Split[3], 913, 997)) ? 10 : 3);
					continue;
				case 3:
					num2 = ShowVersion.Ⴄ(cmd.Rx.Split[3], 'Ė', 'Ĥ');
					num = ⴀႼ[67] - 228;
					continue;
				case 6:
					num = ((num2 <= cmd.Ⴍ().Ⴅ().Ⴍ()
						.SpotProcessing.MaxNmbrAnnSpots) ? 15 : 8);
					continue;
				case 8:
					StationHelp.Ⴈ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 60, 21), cmd.Ⴍ().Ⴅ().Ⴍ()
						.SpotProcessing.MaxNmbrAnnSpots, 522, 'Ƚ');
					num = 5;
					continue;
				case 5:
				case 12:
					cmd.Tx.Msg.Add(SetWxCountHelp.Ⴗ((object)ႨႨ.Ⴀ(13, 3, 1157899188), (object)ShowNodesHelp.Ⴍ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 579, 618), 134, '¹'), 0, (short)123));
					num = ⴀ[36] - 64299;
					continue;
				case 15:
					StationHelp.Ⴈ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 939, 898), ShowVersion.Ⴄ(cmd.Rx.Split[3], 'İ', 'Ă'), 136, '¿');
					num = 16;
					continue;
				case 16:
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216127459, 4, '¡') + TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 831, 790).NmbrSpots);
					goto case 4;
				case 4:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					obj = new Publisher();
					num = ⴍႤ[259] - 27501;
					continue;
				case 9:
					(obj as Publisher).Process(cmd);
					num = ⴃႰ[203] - 59431;
					continue;
				case 10:
					Ⴐ(cmd);
					num = 2;
					continue;
				case 1:
					Ⴐ(cmd);
					break;
				case 2:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴐ(cmd);
		}
		switch (2)
		{
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴍ(float P_0, short P_1, char P_2)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		bool result = default(bool);
		int num3 = default(int);
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
					num2 = 0;
					continue;
				case 0:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 61) ^ num) switch
					{
						0 => ⴀ[385] - 61645, 
						_ => ⴅ[398] - 32, 
					};
					continue;
				case 7:
					result = true;
					num2 = 5;
					continue;
				case 10:
					result = float.IsNaN(P_0);
					num2 = 5;
					continue;
				case 1:
				case 5:
					num++;
					num3 = P_1 * P_1;
					goto case 11;
				case 11:
					num3 = P_1 + num3;
					num2 = 2;
					continue;
				case 2:
				case 9:
					num2 = ((num3 % 2 != 0) ? (ⴄႭ[630] - 144) : 4);
					continue;
				case 4:
					return result;
				case 3:
					num2 = ⴀႼ[70] - 119;
					continue;
				}
				break;
			}
		}
	}
}
