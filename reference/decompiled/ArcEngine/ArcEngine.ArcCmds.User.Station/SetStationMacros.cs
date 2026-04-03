using System;
using System.Collections.Generic;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationMacros : IArcCmd
{
	internal sealed class Ⴓ
	{
		internal List<string> Ⴃ;

		internal string Ⴄ;

		internal Ⴓ()
		{
		}
	}

	private static void Ⴃ(NodeUserCmd P_0)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 4;
		IArcCmd arcCmd = default(IArcCmd);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 0:
			case 1:
			case 2:
				arcCmd = new SetStationMacrosHelp();
				break;
			case 3:
				break;
			}
			break;
			IL_0023:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(13, 7, 1157903651), P_0.Rx.Msg, 612, 554));
			num = ⴄႷ[47] - 19224;
		}
		((SetStationMacrosHelp)arcCmd).Exec(P_0);
		object obj = new Publisher();
		((Publisher)obj).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		try
		{
			int num = 19;
			object obj = default(object);
			int num3 = default(int);
			int num2 = default(int);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					obj = new Publisher();
					num = ((cmd.Rx.Split.Length != 4) ? (ⴄႷ[61] - 8209) : 22);
					continue;
				case 22:
					num = ((CallBlockCacheCfg.Ⴜ(cmd.Rx.Split[3], 933, 964) != 1) ? (ⴐ[296] - 63) : (ⴀႳ[259] - 12436));
					continue;
				case 8:
					num = ((!SkimmerValidSpot.Ⴈ(cmd.Rx.Split[3], 557, 601)) ? (ⴃႰ[163] - 18232) : 3);
					continue;
				case 3:
					num3 = ShowVersion.Ⴄ(cmd.Rx.Split[3], 'ι', '\u038b');
					num = ⴃႠ[409] - 30579;
					continue;
				case 1:
				case 4:
					ႷႷ.Ⴀ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 204, 218), 'ɪ', 624)[num3] = string.Empty;
					num = 7;
					continue;
				case 7:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(SkimmerValidSpot.Ⴅ(ShowWxHelp.Ⴍ('U', 985808411, 4), (object)num3, 1018, (short)901));
					num = ⴀႣ[424] - 4350;
					continue;
				case 20:
					(obj as Publisher).Process(cmd);
					num = ⴀႼ[113];
					continue;
				case 12:
					num = ((cmd.Rx.Split.Length <= 4) ? 16 : 14);
					continue;
				case 14:
					num = ((CallBlockCacheCfg.Ⴜ(cmd.Rx.Split[3], 193, 160) != 1) ? (ⴃႰ[204] - 24650) : 10);
					continue;
				case 10:
					num = ((!SkimmerValidSpot.Ⴈ(cmd.Rx.Split[3], 283, 367)) ? 9 : (ⴀႳ[24] - 25556));
					continue;
				case 15:
					num2 = ShowVersion.Ⴄ(cmd.Rx.Split[3], ')', '\u001b');
					num = 13;
					continue;
				case 13:
					obj2 = cmd.Rx.GetMsgEnd(4);
					num = ((CallBlockCacheCfg.Ⴜ((string)obj2, 279, 374) <= 200) ? 5 : (ⴍႤ[221] - 58711));
					continue;
				case 21:
					obj2 = SetTalkOutputHelp.Ⴍ((string)obj2, 0, 200, 617, 570);
					num = 5;
					continue;
				case 5:
					ႷႷ.Ⴀ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 498, 484), 'ͱ', 875)[num2] = obj2 as string;
					num = 6;
					continue;
				case 6:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(string.Format(CallBlockCacheCfg.Ⴅ(null, 8, 62058314, null), num2) + (obj2 as string));
					num = ⴐ[254];
					continue;
				case 0:
					((Publisher)obj).Process(cmd);
					goto case 17;
				case 17:
					num = 2;
					continue;
				case 9:
					Ⴃ(cmd);
					num = 2;
					continue;
				case 16:
					Ⴃ(cmd);
					break;
				case 2:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴃ(cmd);
		}
		switch (2)
		{
		}
	}

	[SecuritySafeCritical]
	internal static byte Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : CtyInfo
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte result = default(byte);
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
					num2 = ⴅ[180] - 20;
					continue;
				case 9:
					break;
				case 2:
				case 11:
					num2 = (((P_2 ^ P_1) - 71) ^ num) switch
					{
						0 => 5, 
						_ => 6, 
					};
					continue;
				case 6:
					result = 31;
					num2 = ⴄႭ[31];
					continue;
				case 5:
					result = P_0.ItuZone;
					num2 = 10;
					continue;
				case 10:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴄႭ[333] - 40) : 4);
					continue;
				case 4:
					num2 = 2;
					continue;
				case 1:
				case 8:
					return result;
				case 3:
					num2 = ⴐ[206] - 195;
					continue;
				}
				break;
			}
		}
	}
}
