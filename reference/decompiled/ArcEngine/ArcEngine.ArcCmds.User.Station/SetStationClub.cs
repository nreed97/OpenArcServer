using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationClub : IArcCmd
{
	private static void Ⴍ(NodeUserCmd P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(15, 8, 1157899320), P_0.Rx.Msg, 972, 898));
				break;
			case 2:
				break;
			case 3:
			case 4:
			{
				object obj = new SetStationClubHelp();
				(obj as SetStationClubHelp).Exec(P_0);
				object obj2 = new Publisher();
				(obj2 as Publisher).Process(P_0);
				return;
			}
			case 0:
				return;
			}
			num = ⴐ[367];
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		try
		{
			int num = 5;
			object obj = default(object);
			IConvertible msgEnd = default(IConvertible);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					obj = new Publisher();
					num = ((cmd.Rx.Split.Length != 3) ? 9 : 6);
					continue;
				case 6:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ReplyMail.Ⴅ(3, 3, 1217942270));
					num = ⴀႣ[157] - 1478;
					continue;
				case 4:
					((Publisher)obj).Process(cmd);
					num = 1;
					continue;
				case 9:
					num = ((cmd.Rx.Split.Length <= 3) ? 12 : (ⴍႤ[410] - 46367));
					continue;
				case 2:
					cmd.Tx.DistroType = DistroType.ToRequester;
					msgEnd = cmd.Rx.GetMsgEnd(3);
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					goto case 10;
				case 10:
					num = 7;
					continue;
				case 7:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ShowWxHelp.Ⴍ('h', 985805758, 4), (string)msgEnd, 228, 170));
					num = 11;
					continue;
				case 3:
				case 11:
					(obj as Publisher).Process(cmd);
					num = 1;
					continue;
				case 12:
					Ⴍ(cmd);
					break;
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴍ(cmd);
		}
		switch (3)
		{
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : FocUpdate
	{
		int num = 6;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				continue;
			case 8:
				num = (((P_2 ^ P_3) - 75) ^ num2) switch
				{
					0 => 3, 
					_ => 2, 
				};
				continue;
			case 1:
			case 2:
				num = 5;
				continue;
			case 3:
				P_0.Download(P_1);
				goto case 5;
			case 5:
				num2++;
				num3 = 1632;
				num4 = 136;
				break;
			case 7:
				break;
			case 4:
				return;
			}
			num = ((544 < num3 / 3 - num4) ? 8 : 4);
		}
	}

	[SecuritySafeCritical]
	internal static DxCommentExtCfg Ⴗ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DxCfg
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		object obj = default(object);
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
					num2 = 4;
					continue;
				case 4:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 65) ^ num) switch
					{
						0 => ⴀ[441] - 32452, 
						_ => ⴀႳ[119] - 55418, 
					};
					continue;
				case 5:
				case 8:
					obj = null;
					goto case 10;
				case 10:
					num2 = 3;
					continue;
				case 0:
					obj = P_0.CommentExt;
					num2 = 3;
					continue;
				case 3:
				{
					num++;
					int num3 = 1448;
					int num4 = 290;
					int num5 = num3 / 2;
					SetTalkCountHelp.Ⴅ[294] = (byte)((SetTalkCountHelp.Ⴅ[294] + ႨႣ.Ⴐ[152]) & 0xE8);
					num2 = ((724 >= num5 - num4) ? 1 : 7);
					continue;
				}
				case 1:
					return obj as DxCommentExtCfg;
				case 2:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴄ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DxCommentExtCfg
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
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
					num2 = ⴍႤ[228] - 16931;
					continue;
				case 10:
					break;
				case 7:
					num2 = (((P_2 ^ P_1) - 69) ^ num) switch
					{
						0 => ⴀႼ[96] + 7, 
						1 => ⴀႣ[390] - ⴀႣ[390], 
						2 => ⴅ[140] - ⴅ[363], 
						_ => ⴀႳ[204] - 27650, 
					};
					continue;
				case 1:
				case 2:
					result = true;
					goto case 9;
				case 9:
					num2 = 8;
					continue;
				case 4:
				case 11:
					result = P_0.Section;
					num2 = ⴀႨ[146] - 22239;
					continue;
				case 0:
					result = P_0.CqZone;
					num2 = 8;
					continue;
				case 5:
					result = P_0.ItuZone;
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴀႼ[66] - 52;
					continue;
				case 12:
					num2 = ((num3 % 2 != 0) ? 7 : 6);
					continue;
				case 6:
					return result;
				case 3:
					num2 = ⴀႳ[229] - 53850;
					continue;
				}
				break;
			}
		}
	}
}
