using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnOutput : IArcCmd
{
	private static void Ⴈ(NodeUserCmd P_0)
	{
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 3:
				obj = new SetAnnOutputHelp();
				break;
			case 0:
			case 2:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(14, 3, 1157899931), P_0.Rx.Msg, 944, 1022));
			num = 3;
		}
		((SetAnnOutputHelp)obj).Exec(P_0);
		object obj2 = new Publisher();
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		try
		{
			int num = 17;
			object obj = default(object);
			IEquatable<string> equatable = default(IEquatable<string>);
			ICloneable cloneable = default(ICloneable);
			while (true)
			{
				switch (num)
				{
				default:
				{
					cmd.Tx.DistroType = DistroType.ToRequester;
					obj = new Publisher();
					int num2 = cmd.Rx.Split.Length;
					Arc4ServerClient.ႠႣ[287] = (char)((Arc4ServerClient.ႠႣ[287] * Arc4ServerClient.ႠႣ[162]) & 0x14);
					num = ((num2 != 4) ? 9 : (ⴀ[208] - 20756));
					continue;
				}
				case 5:
					equatable = SetDxFilter.Ⴀ(cmd.Rx.Split[3], 930, 'ϣ');
					num = 16;
					continue;
				case 16:
					num = (((cloneable = (string)equatable) == null) ? (ⴀႼ[128] / 3) : ⴐ[204]);
					continue;
				case 6:
					num = (ByeHelp.Ⴍ((string)cloneable, CallBlockCacheCfg.Ⴅ(null, 8, 62058159, null), 469, 434) ? 7 : 10);
					continue;
				case 10:
					num = (ByeHelp.Ⴍ(cloneable as string, ႨႨ.Ⴀ(8, 1, 1157903721), 226, 133) ? 1 : 13);
					continue;
				case 13:
					num = 14;
					continue;
				case 7:
					SetStationEmailHelp.Ⴍ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 868, 845), OutputType.Off, 271, 'ŵ');
					num = 11;
					continue;
				case 11:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(10, 5, 1157899852));
					num = 4;
					continue;
				case 4:
					((Publisher)obj).Process(cmd);
					num = 15;
					continue;
				case 1:
					SetStationEmailHelp.Ⴍ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 204, 229), OutputType.On, 346, 'Ġ');
					num = ⴄႷ[56] - 36245;
					continue;
				case 3:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ႰႥ.Ⴅ(0, 'r', 952621915));
					goto case 0;
				case 0:
					num = 18;
					continue;
				case 18:
					(obj as Publisher).Process(cmd);
					num = 15;
					continue;
				case 14:
					Ⴈ(cmd);
					num = ⴀႼ[110] - 208;
					continue;
				case 8:
				case 9:
					Ⴈ(cmd);
					break;
				case 2:
				case 15:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴈ(cmd);
		}
		switch (4)
		{
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : LotwUpdate
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		bool result = default(bool);
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
					num2 = 5;
					continue;
				case 5:
					break;
				case 2:
				case 8:
					num2 = (((P_2 ^ P_1) - 75) ^ num) switch
					{
						0 => 6, 
						_ => 4, 
					};
					continue;
				case 4:
					result = false;
					num2 = 3;
					continue;
				case 6:
					result = P_0.VerifyCopyDelete();
					num2 = 3;
					continue;
				case 3:
					num++;
					goto case 11;
				case 11:
				{
					int num3 = 7;
					int num4 = 103;
					num2 = ((824 > num4 - num3 * 8) ? (ⴃႰ[50] - 2571) : (ⴄႤ[51] / 3));
					continue;
				}
				case 9:
					num2 = ⴀႣ[429] - 25650;
					continue;
				case 1:
					return result;
				case 7:
					num2 = ⴅ[329] - 111;
					continue;
				}
				break;
			}
		}
	}
}
