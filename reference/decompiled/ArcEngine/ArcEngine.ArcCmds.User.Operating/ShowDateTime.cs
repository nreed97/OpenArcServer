using System;
using System.Collections.Generic;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowDateTime : IArcCmd
{
	internal sealed class Ⴓ
	{
		internal DirectoryMonitor Ⴈ;

		internal Ⴓ()
		{
		}
	}

	private static void Ⴐ(NodeUserCmd P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 4:
			{
				IArcCmd arcCmd = new ShowDateTimeHelp();
				(arcCmd as ShowDateTimeHelp).Exec(P_0);
				goto case 2;
			}
			case 2:
				obj = new Publisher();
				break;
			case 3:
				break;
			case 0:
				return;
			}
			break;
			IL_0023:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(1, 2, 1157898320), P_0.Rx.Msg, 53, 123));
			num = ⴃႥ[237] - 10176;
		}
		(obj as Publisher).Process(P_0);
		ShowWwvOptionsHelp.ႣႥ[298] = (char)((ShowWwvOptionsHelp.ႣႥ[298] - ShowWwvOptionsHelp.ႣႥ[152]) & 0x89);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		try
		{
			int num = 7;
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = ((cmd.Rx.Split.Length == 2) ? 1 : 5);
					continue;
				case 1:
				{
					List<string> msg = cmd.Tx.Msg;
					string text = SetStationQth.Ⴍ(null, 1687354775, 7, 0);
					DateTime dateTime = ShowAnnHelp.Ⴅ('Ϸ', 966);
					msg.Add(ShowUsersHelp.Ⴅ(text, ShowAnnOptionsHelp.Ⴗ(ref dateTime, SetTalkCount.Ⴗ(8, null, 1267014198, typeof(CallbookCfg)), 885, 881), 579, 525));
					num = ⴀႣ[317] - ⴀႣ[317];
					continue;
				}
				case 0:
				case 4:
				{
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					num = ⴃႠ[170] - 683;
					continue;
				}
				case 5:
					Ⴐ(cmd);
					break;
				case 3:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴐ(cmd);
		}
		switch (1)
		{
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴀ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : TalkCfg
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int result = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 4;
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
				case 4:
					num2 = (((P_2 ^ P_1) - 79) ^ num) switch
					{
						0 => ⴃႥ[83] - 54509, 
						_ => 0, 
					};
					continue;
				case 0:
					result = 15;
					num2 = 7;
					continue;
				case 3:
					result = P_0.NmbrSpots;
					num2 = ⴀ[464] - 29722;
					continue;
				case 7:
					num++;
					num3 = 2235;
					num4 = 619;
					goto case 8;
				case 8:
					num2 = ((745 < num3 / 3 - num4) ? ⴐ[367] : (ⴀႼ[108] - 155));
					continue;
				case 1:
					return result;
				case 2:
				case 10:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}
}
