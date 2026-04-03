using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Security;
using System.Threading;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Node.Pc;
using ArcEngine.ArcCmds.NodeProcessor;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcCmds.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared;
using ArcShared.ArcCfg;

namespace Ⴈ;

internal sealed class ႰႰ
{
	public List<NodeCmdCfg> Ⴃ;

	public ႰႰ()
	{
		Ⴃ = new List<NodeCmdCfg>();
		Ⴍ();
	}

	private void Ⴍ()
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 13;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴃ.Add(new NodeCmdCfg(CallBlockCacheCfg.Ⴅ(null, 1, 62057509, null), ShowWxHelp.Ⴍ('B', 985808890, 7)));
				num = 10;
				break;
			case 10:
				Ⴃ.Add(new NodeCmdCfg(SetTalkCount.Ⴗ(6, null, 1267022353, typeof(ShowUptimeHelp)), ReplyMail.Ⴅ(4, 8, 1217944744)));
				num = 12;
				break;
			case 12:
				Ⴃ.Add(new NodeCmdCfg(SetStationClubHelp.Ⴍ(14, 5, 1747258054, null), ShowSkimCtyHelp.Ⴍ(1216133608, 6, '\u008e')));
				num = ⴍႤ[328] - 12752;
				break;
			case 1:
				Ⴃ.Add(new NodeCmdCfg(ReplyMailHelp.Ⴄ(27, null, 1057162231, 3), SetStationQth.Ⴍ(null, 1687351336, 7, 9)));
				goto case 16;
			case 16:
				num = 17;
				break;
			case 17:
				Ⴃ.Add(new NodeCmdCfg(ႨႨ.Ⴀ(0, 2, 1157903588), ႰႥ.Ⴅ(8, 'K', 952620263)));
				num = 4;
				break;
			case 4:
				Ⴃ.Add(new NodeCmdCfg(CallBlockCacheCfg.Ⴅ(null, 7, 62057508, null), ႰႥ.Ⴅ(6, '\u001d', 952620265)));
				num = 21;
				break;
			case 21:
				Ⴃ.Add(new NodeCmdCfg(SetTalkCount.Ⴗ(3, null, 1267022349, typeof(DirectoryOwn)), ReplyMail.Ⴅ(2, 14, 1217944738)));
				num = ⴄႤ[481] - 157;
				break;
			case 19:
				Ⴃ.Add(new NodeCmdCfg(SetStationClubHelp.Ⴍ(5, 0, 1747258106, null), ႰႥ.Ⴅ(4, 'Y', 952620267)));
				num = 20;
				break;
			case 20:
				Ⴃ.Add(new NodeCmdCfg(ReplyMailHelp.Ⴄ(29, null, 1057162224, 3), SetStationQth.Ⴍ(null, 1687351331, 0, 5)));
				num = 6;
				break;
			case 6:
				Ⴃ.Add(new NodeCmdCfg(ႨႨ.Ⴀ(3, 2, 1157903595), ႰႥ.Ⴅ(2, '4', 952620269)));
				num = 5;
				break;
			case 5:
				Ⴃ.Add(new NodeCmdCfg(CallBlockCacheCfg.Ⴅ(null, 0, 62057514, null), ShowWxHelp.Ⴍ('÷', 985808877, 5)));
				num = ⴄႤ[349] - 229;
				break;
			case 23:
				Ⴃ.Add(new NodeCmdCfg(SetTalkCount.Ⴗ(2, null, 1267022343, typeof(WwvSpotBase)), ReplyMail.Ⴅ(0, 3, 1217944656)));
				num = ⴀ[381] - 58140;
				break;
			case 9:
				Ⴃ.Add(new NodeCmdCfg(SetStationClubHelp.Ⴍ(9, 2, 1747258111, null), ShowSkimCtyHelp.Ⴍ(1216133509, 1, 'Ñ')));
				num = 15;
				break;
			case 15:
				Ⴃ.Add(new NodeCmdCfg(ReplyMailHelp.Ⴄ(27, null, 1057162122, 8), SetStationQth.Ⴍ(null, 1687351501, 3, 18)));
				num = 8;
				break;
			case 8:
				Ⴃ.Add(new NodeCmdCfg(ႨႨ.Ⴀ(7, 2, 1157903602), ႰႥ.Ⴅ(0, '{', 952620285)));
				num = 14;
				break;
			case 14:
				Ⴃ.Add(new NodeCmdCfg(CallBlockCacheCfg.Ⴅ(null, 5, 62057694, null), ShowWxHelp.Ⴍ('Î', 985808834, 3)));
				num = 7;
				break;
			case 7:
				Ⴃ.Add(new NodeCmdCfg(SetTalkCount.Ⴗ(4, null, 1267022584, typeof(SetStationBeepHelp)), ReplyMail.Ⴅ(1, 8, 1217944647)));
				num = 3;
				break;
			case 3:
				Ⴃ.Add(new NodeCmdCfg(SetStationClubHelp.Ⴍ(9, 3, 1747258103, null), ShowSkimCtyHelp.Ⴍ(1216133527, 3, 'µ')));
				num = 22;
				break;
			case 18:
			case 22:
				Ⴃ.Add(new NodeCmdCfg(ReplyMailHelp.Ⴄ(3, null, 1057162140, 5), SetStationQth.Ⴍ(null, 1687351543, 8, 26)));
				num = ⴅ[242] - 220;
				break;
			case 24:
				Ⴃ.Add(new NodeCmdCfg(ႨႨ.Ⴀ(10, 7, 1157903612), ႰႥ.Ⴅ(7, 'd', 952620175)));
				num = 11;
				break;
			case 11:
				Ⴃ.Add(new NodeCmdCfg(CallBlockCacheCfg.Ⴅ(null, 0, 62057666, null), ShowWxHelp.Ⴍ('z', 985808692, 2)));
				num = 0;
				break;
			case 0:
				Ⴃ.Add(new NodeCmdCfg(SetTalkCount.Ⴗ(8, null, 1267022587, typeof(InitTurnaroundPc20)), ReplyMail.Ⴅ(7, 8, 1217944688)));
				return;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : StationCfg
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		float result = default(float);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႨ[154] - 38605;
					continue;
				case 9:
					break;
				case 0:
				case 8:
				{
					int num4;
					switch (((P_2 ^ P_1) - 78) ^ num)
					{
					default:
					{
						byte num5 = ⴄႤ[514];
						SetWxOutput.ႣႰ[90] = (char)((SetWxOutput.ႣႰ[90] * P_1) & 0xBC);
						num4 = num5 - 127;
						break;
					}
					case 0:
						num4 = ⴀႼ[4] - 31;
						break;
					}
					num2 = num4;
					continue;
				}
				case 3:
					result = 2.268698f;
					goto case 4;
				case 4:
					num2 = 1;
					continue;
				case 6:
					result = P_0.Lat;
					num2 = 1;
					continue;
				case 1:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴃႥ[283] - 58289;
					continue;
				case 7:
					num2 = ((num3 % 2 != 0) ? (ⴀႨ[212] - 27978) : (ⴄႭ[204] - 112));
					continue;
				case 5:
					return result;
				case 10:
					num2 = ⴀႨ[23] - ⴀႨ[23];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : AnnWxSpot where _0021_00211 : string
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 0;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				continue;
			case 4:
				num = (((P_3 ^ P_2) - 121) ^ num2) switch
				{
					0 => 5, 
					_ => ⴄႭ[94], 
				};
				continue;
			case 7:
				num = 2;
				continue;
			case 5:
				P_0.WxFlag = P_1;
				goto case 1;
			case 1:
			case 2:
				num2++;
				num3 = 4020;
				num4 = 449;
				break;
			case 8:
				break;
			case 3:
			case 6:
				return;
			}
			num = ((1005 < num3 / 4 - num4) ? 4 : (ⴀႨ[72] - 30947));
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : Thread where _0021_00211 : string
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				break;
			case 6:
				num = (((P_3 ^ P_2) - 32) ^ num2) switch
				{
					0 => 4, 
					_ => ⴄႷ[121] - 57603, 
				};
				break;
			case 1:
				num = 0;
				break;
			case 4:
				P_0.Name = P_1;
				goto case 0;
			case 0:
				num2++;
				goto case 3;
			case 3:
			{
				int num3 = 401;
				int num4 = 553;
				num = ((2765 > num4 - num3 * 5) ? ⴐ[243] : 9);
				break;
			}
			case 9:
				num = 6;
				break;
			case 5:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : SqlCeEngine
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 7;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 4;
				break;
			case 3:
			case 4:
				num = (((P_2 ^ P_1) - 2) ^ num3) switch
				{
					0 => 1, 
					_ => 8, 
				};
				break;
			case 8:
				num = ⴀ[362] - 37254;
				break;
			case 1:
				P_0.Dispose();
				goto case 6;
			case 6:
				num3++;
				goto case 2;
			case 2:
				num2 = P_1 * P_1;
				num2 = P_1 + num2;
				num = ⴐ[84] - 50;
				break;
			case 0:
			case 5:
				num = ((num2 % 2 != 0) ? 4 : (ⴃႰ[19] - 63914));
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, char P_3) where _0021_00210 : ServerIoCfg
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 3:
			case 4:
				num = (((P_2 ^ P_3) - 111) ^ num2) switch
				{
					0 => 1, 
					_ => ⴀႣ[272] - 31600, 
				};
				break;
			case 9:
				num = ⴀႨ[12] - 29229;
				break;
			case 1:
				P_0.Enabled = P_1;
				goto case 5;
			case 5:
				num2++;
				goto case 6;
			case 6:
			{
				int num4;
				if ((P_3 * P_3 + P_3) % 2 != 0)
				{
					byte num3 = ⴄႭ[593];
					DirectoryBulletin.ႠႨ[32] = DirectoryBulletin.ႠႨ[32] & ShowSunHelp.ႣႠ[384] & 5;
					num4 = num3 / 8;
				}
				else
				{
					num4 = ⴃႠ[75] - 14925;
				}
				num = num4;
				break;
			}
			case 8:
				num = 4;
				break;
			case 0:
			case 7:
				return;
			}
		}
	}
}
