using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class SetDxFilter : IArcCmd
{
	private static void Ⴄ(NodeUserCmd P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 4:
			{
				IArcCmd arcCmd = new SetDxFilterHelp();
				((SetDxFilterHelp)arcCmd).Exec(P_0);
				return;
			}
			}
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(14, 3, 1157899227), P_0.Rx.Msg, 326, 264));
			num = ⴍႤ[87] - 30926;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		cmd.Tx.DistroType = DistroType.ToRequester;
		try
		{
			int num = 18;
			IEquatable<string> equatable = default(IEquatable<string>);
			IComparable comparable = default(IComparable);
			object obj2 = default(object);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 3) ? 7 : (ⴃႰ[172] - 49107));
					continue;
				case 10:
					SetStationBeepHelp.Ⴅ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 75, 49), string.Empty, 280, 337);
					num = 20;
					continue;
				case 20:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ReplyMail.Ⴅ(0, 10, 1217941247));
					num = 2;
					continue;
				case 2:
				{
					object obj3 = new Publisher();
					((Publisher)obj3).Process(cmd);
					num = 19;
					continue;
				}
				case 7:
					num = ((cmd.Rx.Split.Length < 3) ? 5 : (ⴄႭ[14] - 183));
					continue;
				case 4:
					equatable = SetStationGrid.Ⴍ(cmd.Rx.GetMsgEnd2(3), 185, 'ë');
					equatable = qslinfoRequest.Ⴃ(equatable as string, cmd.Ⴍ().Call, 679, 661);
					num = 12;
					continue;
				case 12:
					equatable = Ⴀ(equatable as string, 870, '\u0322');
					comparable = cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴃ()
						.FormatSqlFilter(equatable as string);
					goto case 25;
				case 25:
					num = 24;
					continue;
				case 24:
					num = (cmd.Ⴍ().Ⴅ().Ⴍ()
						.SpotProcessing.EnableCt1bohProcessing ? 11 : 23);
					continue;
				case 23:
					num = ((!SetWwvOutputHelp.Ⴓ(comparable as string, '\u02d2', 707)) ? (ⴃႠ[304] - 2896) : (ⴀႣ[297] - 350));
					continue;
				case 1:
					cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(5, null, 1267019707, typeof(ShowAnnHelp)));
					num = ⴍႭ[19] - 38506;
					continue;
				case 13:
					cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(1, null, 1057166389, 5));
					num = ⴀႼ[18] / 5;
					continue;
				case 16:
					cmd.Tx.Msg.Add(ႰႥ.Ⴅ(6, '\u008c', 952616862));
					obj2 = new Publisher();
					num = 0;
					continue;
				case 0:
					((Publisher)obj2).Process(cmd);
					num = 19;
					continue;
				case 11:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴃ()
						.Ⴅ(comparable as string)) ? 17 : 6);
					continue;
				case 6:
					SetStationBeepHelp.Ⴅ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 866, 792), (string)comparable, 787, 858);
					num = 15;
					continue;
				case 15:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetStationClubHelp.Ⴍ(0, 6, 1747260310, null), LogEntry.Ⴄ((string)comparable, 'Ŕ', 376), 963, 909));
					num = 22;
					continue;
				case 22:
					obj = new Publisher();
					goto case 8;
				case 8:
					((Publisher)obj).Process(cmd);
					num = ⴀႼ[102] - 24;
					continue;
				case 17:
					cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(11, 8, 1747260301, null));
					num = 21;
					continue;
				case 21:
					cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687355327, 6, 24) + (equatable as string));
					num = 14;
					continue;
				case 14:
					Ⴄ(cmd);
					num = ⴀ[447] - 45805;
					continue;
				case 5:
					Ⴄ(cmd);
					break;
				case 19:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴄ(cmd);
		}
		switch (4)
		{
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 2:
					num2 = (((P_2 ^ P_1) - 64) ^ num) switch
					{
						0 => ⴍႭ[177] - 18105, 
						1 => 13, 
						2 => ⴄႷ[28] - 45672, 
						3 => 1, 
						4 => 6, 
						_ => 11, 
					};
					continue;
				case 11:
					obj = null;
					num2 = ⴀႨ[147] - 30828;
					continue;
				case 12:
					obj = P_0.Trim();
					num2 = 9;
					continue;
				case 13:
					obj = P_0.ToUpper();
					num2 = 9;
					continue;
				case 5:
				case 10:
					obj = UtilsCallsign.ScrubCall(P_0);
					goto case 14;
				case 14:
					num2 = 9;
					continue;
				case 1:
					obj = UtilsXml.ConvertToLine(P_0);
					num2 = 9;
					continue;
				case 6:
					obj = UtilsMacros.ExpandRepeatableFilterMacros(P_0);
					num2 = ⴐ[275] - ⴐ[8];
					continue;
				case 9:
				{
					num++;
					int num3 = 1818;
					int num4 = 553;
					num2 = ((606 < num3 / 3 - num4) ? 2 : (ⴀ[33] - 16123));
					continue;
				}
				case 7:
				case 8:
					return obj as string;
				case 4:
					num2 = ⴄႷ[22] - 7330;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, short P_3) where _0021_00210 : DxCommentExtCfg
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 10;
				break;
			case 10:
				num = (((P_2 ^ P_3) - 24) ^ num2) switch
				{
					0 => 1, 
					1 => ⴀ[281] - 5626, 
					_ => 9, 
				};
				break;
			case 9:
				num = 0;
				break;
			case 1:
			case 3:
				P_0.Lotw = P_1;
				num = 0;
				break;
			case 2:
			case 4:
				P_0.ItuZone = P_1;
				goto case 0;
			case 0:
			{
				num2++;
				int num3 = 149;
				int num4 = 658;
				num = ((2632 > num4 - num3 * 4) ? (ⴀႨ[203] - 48779) : (ⴃႰ[201] - 21669));
				break;
			}
			case 6:
			case 7:
				num = 10;
				break;
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႥ[63] - 62908;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
				case 11:
					break;
				case 0:
					num2 = (((P_2 ^ P_1) - 117) ^ num) switch
					{
						0 => ⴅ[145], 
						_ => 6, 
					};
					continue;
				case 3:
				case 6:
					obj = null;
					num2 = 4;
					continue;
				case 7:
					obj = CtyInfo.ScrubTimeOffset(P_0);
					num2 = ⴄႭ[304] - 234;
					continue;
				case 4:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					goto case 2;
				case 2:
					num2 = 8;
					continue;
				case 8:
					num2 = ((num3 % 2 == 0) ? 9 : 0);
					continue;
				case 9:
					return (string)obj;
				case 1:
					num2 = ⴃႠ[185] - 15228;
					continue;
				}
				break;
			}
		}
	}
}
