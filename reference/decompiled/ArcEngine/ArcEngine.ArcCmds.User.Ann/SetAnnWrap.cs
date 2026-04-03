using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnWrap : IArcCmd
{
	private static void Ⴄ(NodeUserCmd P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 4;
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 2:
			{
				object obj = new SetAnnWrapHelp();
				((SetAnnWrapHelp)obj).Exec(P_0);
				goto case 0;
			}
			case 0:
				obj2 = new Publisher();
				break;
			case 1:
				break;
			}
			break;
			IL_0023:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(14, 3, 1157904668), P_0.Rx.Msg, 203, 133));
			num = ⴃႠ[233] - 58640;
		}
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		try
		{
			int num = 17;
			IComparable<string> comparable = default(IComparable<string>);
			IConvertible convertible = default(IConvertible);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 4) ? 2 : 13);
					continue;
				case 13:
					cmd.Tx.DistroType = DistroType.ToRequester;
					comparable = LogEntry.Ⴄ(cmd.Rx.Split[3], 'ɡ', 587);
					num = 15;
					continue;
				case 15:
					num = (((convertible = (string)comparable) == null) ? (ⴃႰ[145] - 39053) : 5);
					continue;
				case 5:
				case 6:
					num = (ByeHelp.Ⴍ(convertible as string, SetStationQth.Ⴍ(null, 1687354347, 3, 3), 617, 526) ? (ⴄႷ[24] - 27214) : 3);
					continue;
				case 3:
					num = (ByeHelp.Ⴍ((string)convertible, ShowWxHelp.Ⴍ('7', 985807969, 2), 696, 735) ? 14 : 7);
					continue;
				case 7:
					num = (ByeHelp.Ⴍ(convertible as string, ႰႥ.Ⴅ(5, '\u008b', 952621475), 838, 801) ? 1 : (ⴐ[102] - 97));
					continue;
				case 19:
					num = (ByeHelp.Ⴍ((string)convertible, ႨႨ.Ⴀ(15, 2, 1157902454), 286, 377) ? (ⴍႭ[239] - 12407) : 4);
					continue;
				case 4:
					num = 11;
					continue;
				case 14:
					ShowAnnOptions.Ⴓ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 677, 652), true, 179, 134);
					num = ⴀႨ[122] - 31841;
					continue;
				case 16:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(9, 3, 1157905101));
					num = ⴃႠ[67] - 9300;
					continue;
				case 1:
					ShowAnnOptions.Ⴓ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 694, 671), false, 140, 185);
					num = 0;
					continue;
				case 0:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ReplyMail.Ⴅ(5, 4, 1217941631));
					num = 9;
					continue;
				case 11:
					Ⴄ(cmd);
					goto case 9;
				case 9:
				case 18:
					obj = new Publisher();
					goto case 12;
				case 12:
					(obj as Publisher).Process(cmd);
					num = 10;
					continue;
				case 2:
					Ⴄ(cmd);
					break;
				case 10:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴄ(cmd);
		}
		switch (3)
		{
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴃ(ref DateTime P_0, double P_1, short P_2, short P_3)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		DateTime result = default(DateTime);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႰ[172] - 49116;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႨ[172] - 21865;
					continue;
				case 9:
					break;
				case 1:
				case 4:
					num2 = (((P_2 ^ P_3) - 92) ^ num) switch
					{
						0 => 5, 
						_ => 2, 
					};
					continue;
				case 2:
					result = default(DateTime);
					num2 = ⴀ[33] - 16120;
					continue;
				case 3:
				case 5:
					result = P_0.AddDays(P_1);
					num2 = 11;
					continue;
				case 11:
					num++;
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					num2 = ⴀႨ[42] - 24447;
					continue;
				case 7:
					num2 = ((num3 % 2 != 0) ? (ⴄႭ[476] - 86) : 0);
					continue;
				case 0:
				case 6:
					return result;
				case 8:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : string
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		DateTime dateTime = default(DateTime);
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
					num2 = ⴅ[332] - 215;
					continue;
				case 6:
					break;
				case 7:
					num2 = (((P_2 ^ P_1) - 79) ^ num) switch
					{
						0 => ⴃႥ[265] - 5772, 
						_ => ⴀႳ[155] - 21201, 
					};
					continue;
				case 5:
					dateTime = default(DateTime);
					num2 = 9;
					continue;
				case 2:
				case 10:
					dateTime = Convert.ToDateTime(P_0);
					num2 = 9;
					continue;
				case 1:
				case 9:
				{
					num++;
					int num3 = 1004;
					int num4 = 99;
					num2 = ((251 < num3 / 4 - num4) ? 7 : (ⴄႤ[406] - 200));
					continue;
				}
				case 0:
				case 3:
				{
					DateTime result = dateTime;
					SetAnnChatRooms.Ⴀ[422] = (char)((SetAnnChatRooms.Ⴀ[422] ^ P_1) & 0xE2);
					return result;
				}
				case 4:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static short Ⴐ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : string
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		short result = default(short);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႠ[210] - 4850;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႨ[204] - 2034;
					continue;
				case 10:
					break;
				case 4:
					num2 = (((P_2 ^ P_1) - 121) ^ num) switch
					{
						0 => ⴀႨ[181] - 3887, 
						_ => 8, 
					};
					continue;
				case 8:
					result = 9;
					num2 = ⴀႳ[263] - 11623;
					continue;
				case 5:
					result = Convert.ToInt16(P_0);
					num2 = 3;
					continue;
				case 1:
				case 3:
				{
					num++;
					int num3 = 79;
					int num4 = 257;
					num2 = ((2056 > num4 - num3 * 8) ? (ⴄႤ[358] - 136) : 7);
					continue;
				}
				case 7:
					num2 = 4;
					continue;
				case 0:
				case 6:
				case 11:
					return result;
				case 9:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}
}
