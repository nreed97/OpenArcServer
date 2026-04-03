using System;
using System.Collections;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnFilter : IArcCmd
{
	internal sealed class Ⴅ
	{
		internal DxSpotUniqueCacheWorker Ⴐ;

		internal DxSpotUniqueCacheWorker Ⴃ;

		internal DxSpotUniqueCacheWorker Ⴀ;

		internal DxSpotUniqueCacheWorker Ⴅ;

		internal Ⴅ()
		{
		}
	}

	private static void Ⴃ(NodeUserCmd P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 4:
				obj = new SetAnnFilterHelp();
				goto case 2;
			case 2:
				(obj as SetAnnFilterHelp).Exec(P_0);
				break;
			case 3:
				break;
			}
			break;
			IL_0023:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(9, 0, 1157898543), P_0.Rx.Msg, 171, 229));
			num = ⴃႠ[267] - 19280;
		}
		object obj2 = new Publisher();
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		cmd.Tx.DistroType = DistroType.ToRequester;
		try
		{
			int num = 3;
			object obj = default(object);
			IEnumerable enumerable = default(IEnumerable);
			IComparable comparable = default(IComparable);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new Publisher();
					goto case 8;
				case 8:
					num = ((cmd.Rx.Split.Length != 3) ? (ⴃႥ[17] - 43325) : (ⴀႣ[77] - 10992));
					continue;
				case 12:
					SetTalkOutput.Ⴍ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 458, 483), string.Empty, 817, '\u0319');
					num = ⴅ[131] - 60;
					continue;
				case 5:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130866, 6, 'Q'));
					num = 2;
					continue;
				case 2:
					(obj as Publisher).Process(cmd);
					goto case 6;
				case 6:
					num = 1;
					continue;
				case 16:
					num = ((cmd.Rx.Split.Length < 3) ? (ⴀ[200] - 61352) : (ⴀ[480] - 26868));
					continue;
				case 4:
					enumerable = SetStationGrid.Ⴍ(cmd.Rx.GetMsgEnd(3), 535, 'Ʌ');
					comparable = cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴄ()
						.FormatSqlFilter(enumerable as string);
					num = 7;
					continue;
				case 7:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴄ()
						.Ⴄ((string)comparable)) ? (ⴀႳ[38] - 44454) : ⴅ[46]);
					continue;
				case 17:
					SetTalkOutput.Ⴍ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 221, 244), comparable as string, 335, 'ŧ');
					goto case 9;
				case 9:
					num = ⴄႷ[68] - 14156;
					continue;
				case 15:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႰႥ.Ⴅ(0, '>', 952616585), (string)enumerable, 133, 203));
					num = 10;
					continue;
				case 0:
					cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(31, null, 1057166839, 5));
					num = 11;
					continue;
				case 11:
					cmd.Tx.Msg.Add(ႰႥ.Ⴅ(4, '\u0014', 952616608) + (string)enumerable);
					goto case 10;
				case 10:
					((Publisher)obj).Process(cmd);
					num = 1;
					continue;
				case 14:
					Ⴃ(cmd);
					break;
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴃ(cmd);
		}
		switch (4)
		{
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴐ(Guid P_0, Guid P_1, char P_2, int P_3)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[203] - 29752;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႨ[208] - 6505;
					continue;
				case 6:
					break;
				case 2:
				case 8:
					num2 = (((P_3 ^ P_2) - 17) ^ num) switch
					{
						0 => 3, 
						_ => ⴀႼ[100] - 14, 
					};
					continue;
				case 4:
					result = true;
					num2 = ⴀႳ[177] - 3855;
					continue;
				case 3:
					result = P_0 != P_1;
					num2 = ⴍႤ[178] - 3016;
					continue;
				case 0:
				case 5:
				case 9:
				{
					num++;
					int num3 = 247;
					int num4 = 677;
					num2 = ((2031 <= num4 - num3 * 3) ? 1 : 10);
					continue;
				}
				case 1:
					num2 = 8;
					continue;
				case 10:
					return result;
				case 11:
					num2 = ⴃႥ[105] - 37673;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, short P_3) where _0021_00210 : OnIoClientRxEventHandler where _0021_00211 : string
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 4;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴀ[95] - 5680;
				break;
			case 1:
				IpLockoutCacheCfg.ႭႭ[142] = (char)((IpLockoutCacheCfg.ႭႭ[142] - P_2) & 0xCA);
				num = (((P_2 ^ P_3) - 122) ^ num3) switch
				{
					0 => 7, 
					_ => 0, 
				};
				break;
			case 0:
			case 6:
				num = 3;
				break;
			case 5:
			case 7:
				P_0(P_1);
				goto case 3;
			case 3:
			case 8:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = 2;
				break;
			case 2:
				num = ((num2 % 2 != 0) ? 1 : 9);
				break;
			case 9:
				return;
			}
		}
	}
}
