using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wwv;

public sealed class SetWwvOutput : IArcCmd
{
	private static void Ⴄ(NodeUserCmd P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 4:
			{
				object obj = new SetWwvOutputHelp();
				((SetWwvOutputHelp)obj).Exec(P_0);
				object obj2 = new Publisher();
				((Publisher)obj2).Process(P_0);
				return;
			}
			case 3:
				return;
			}
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(9, 8, 1157904399), P_0.Rx.Msg, 68, 10));
			num = ⴍႤ[352] - 48306;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		try
		{
			int num = 15;
			object obj = default(object);
			object obj2 = default(object);
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length == 4) ? (ⴃႠ[19] - 31727) : 0);
					continue;
				case 7:
					cmd.Tx.DistroType = DistroType.ToRequester;
					obj = new Publisher();
					goto case 12;
				case 12:
					obj2 = SetDxFilter.Ⴀ(cmd.Rx.Split[3], 90, '\u001b');
					num = 13;
					continue;
				case 6:
				case 13:
					num = (((enumerable = (string)obj2) == null) ? 18 : 17);
					continue;
				case 17:
					num = ((!ByeHelp.Ⴍ(enumerable as string, CallBlockCacheCfg.Ⴅ(null, 7, 62058144, null), 997, 898)) ? 1 : ⴅ[20]);
					continue;
				case 1:
					num = (ByeHelp.Ⴍ(enumerable as string, ႨႨ.Ⴀ(11, 8, 1157903712), 877, 778) ? (ⴀႣ[307] - 30948) : 16);
					continue;
				case 16:
					num = ⴄႭ[455] - 2;
					continue;
				case 10:
					AnnHelp.Ⴍ(ShowHeading.Ⴅ(cmd.Ⴍ().Cfg, 452, 448), OutputType.Off, 554, 595);
					num = ⴄႷ[102] - 5052;
					continue;
				case 3:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(2, 3, 1157904433));
					num = 11;
					continue;
				case 9:
				case 11:
					((Publisher)obj).Process(cmd);
					num = 2;
					continue;
				case 4:
					AnnHelp.Ⴍ(ShowHeading.Ⴅ(cmd.Ⴍ().Cfg, 49, 53), OutputType.On, 493, 404);
					num = ⴄႤ[135] + 3;
					continue;
				case 8:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ႰႥ.Ⴅ(3, 'Æ', 952621227));
					num = ⴄႭ[249] - 249;
					continue;
				case 5:
					((Publisher)obj).Process(cmd);
					num = ⴃႥ[335] - 32152;
					continue;
				case 18:
					Ⴄ(cmd);
					num = 2;
					continue;
				case 0:
					Ⴄ(cmd);
					break;
				case 2:
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
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, int P_3) where _0021_00210 : DxSpot
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႨ[229] - 36010;
				break;
			case 7:
			{
				int num3 = (P_2 ^ P_3) - 117;
				int num4 = num2;
				SetWxOutput.ႣႰ[96] = (char)((SetWxOutput.ႣႰ[96] * P_3) & 0x2F);
				num = (num3 ^ num4) switch
				{
					0 => ⴐ[8] - 42, 
					_ => 1, 
				};
				break;
			}
			case 1:
			case 8:
				num = 2;
				break;
			case 5:
				P_0.Lotw = P_1;
				goto case 2;
			case 2:
				num2++;
				goto case 4;
			case 4:
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 9 : (ⴀႨ[4] - 27038));
				break;
			case 6:
				num = 7;
				break;
			case 3:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 7;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 3;
				continue;
			case 3:
			case 4:
				num = (((P_1 ^ P_2) - 1) ^ num2) switch
				{
					0 => 2, 
					_ => ⴃႰ[169] - 46559, 
				};
				continue;
			case 6:
				num = ⴀႼ[124] - 23;
				continue;
			case 2:
				File.Delete(P_0);
				goto case 0;
			case 0:
				num2++;
				goto case 1;
			case 1:
				num3 = 1760;
				break;
			case 8:
				break;
			case 5:
				return;
			}
			int num4 = 110;
			num = ((880 < num3 / 2 - num4) ? (ⴃႰ[98] - 49510) : (ⴀႨ[196] - 23281));
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴗ(ref DateTime P_0, double P_1, char P_2, int P_3)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		DateTime result = default(DateTime);
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
					num2 = ⴐ[213] - 162;
					continue;
				case 6:
				case 11:
					break;
				case 0:
					num2 = (((P_3 ^ P_2) - 70) ^ num) switch
					{
						0 => ⴄႭ[94], 
						_ => ⴀ[447] - 45814, 
					};
					continue;
				case 10:
					result = default(DateTime);
					num2 = 8;
					continue;
				case 7:
					result = P_0.AddSeconds(P_1);
					num2 = ⴄႷ[14] - 21586;
					continue;
				case 8:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 1 : 3);
					continue;
				case 3:
					num2 = ⴃႠ[146] - 42167;
					continue;
				case 1:
				case 5:
					return result;
				case 4:
				case 9:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}
}
