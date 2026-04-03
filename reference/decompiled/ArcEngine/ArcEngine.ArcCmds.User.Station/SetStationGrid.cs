using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationGrid : IArcCmd
{
	private static void Ⴓ(NodeUserCmd P_0)
	{
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 0:
			case 3:
			{
				IArcCmd arcCmd = new SetStationGridHelp();
				((SetStationGridHelp)arcCmd).Exec(P_0);
				obj = new Publisher();
				break;
			}
			case 4:
				break;
			case 2:
				return;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(11, 6, 1157899344), P_0.Rx.Msg, 895, 817));
			num = 3;
		}
		(obj as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			int num = 7;
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length <= 3) ? 4 : (ⴀ[451] - 7729));
					continue;
				case 9:
					cmd.Tx.DistroType = DistroType.ToRequester;
					enumerable = SetDxFilter.Ⴀ(cmd.Rx.GetMsgEnd(3), 184, 'ù');
					num = 8;
					continue;
				case 5:
				case 8:
					num = ((!ShowWwvHelp.Ⴗ(enumerable as string, '\u02e7', 704)) ? 12 : (ⴍႭ[101] - 40606));
					continue;
				case 10:
					SetTalkCount.ႤႷ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 453, 467), enumerable as string, 992, 1001);
					num = 0;
					continue;
				case 0:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetTalkCount.Ⴗ(7, null, 1267016175, typeof(TxNodeUserCmd)), enumerable as string, 372, 314));
					num = ⴀႳ[227] - 26070;
					continue;
				case 3:
				{
					object obj = new Publisher();
					(obj as Publisher).Process(cmd);
					goto case 11;
				}
				case 11:
					num = 2;
					continue;
				case 12:
					Ⴓ(cmd);
					num = 2;
					continue;
				case 4:
					Ⴓ(cmd);
					break;
				case 2:
				case 6:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴓ(cmd);
		}
		switch (0)
		{
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = 5;
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
				case 5:
					num2 = (((P_2 ^ P_1) - 82) ^ num) switch
					{
						0 => 9, 
						1 => 2, 
						_ => ⴀႣ[48] - 51176, 
					};
					continue;
				case 6:
					convertible = null;
					num2 = 10;
					continue;
				case 9:
					convertible = UtilsSql.ScrubSql(P_0);
					num2 = ⴄႷ[24] - 27218;
					continue;
				case 2:
					convertible = UtilsCallsign.ScrubTelnetControlChars(P_0);
					num2 = 10;
					continue;
				case 0:
				case 10:
				{
					num++;
					int num3 = P_2 * P_2;
					SetAnnChatRooms.Ⴀ[107] = (char)((SetAnnChatRooms.Ⴀ[107] | P_1) & 0x74);
					num2 = (((num3 + P_2) % 2 == 0) ? 11 : ⴄႤ[47]);
					continue;
				}
				case 4:
				case 12:
					num2 = 5;
					continue;
				case 11:
					return convertible as string;
				case 8:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, char P_3) where _0021_00210 : DxSpot
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
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
				num = 2;
				break;
			case 2:
				num = (((P_3 ^ P_2) - 0) ^ num2) switch
				{
					0 => ⴀႳ[55] - 32493, 
					_ => ⴄႤ[296] - 92, 
				};
				break;
			case 6:
				num = 4;
				break;
			case 1:
			case 7:
				P_0.InCb = P_1;
				goto case 4;
			case 4:
			case 5:
				num2++;
				num3 = 306;
				num4 = 352;
				goto case 3;
			case 3:
			{
				int num5 = num4 - num3 * 9;
				DirectoryBulletin.ႠႨ[126] = (DirectoryBulletin.ႠႨ[126] | SetTalkCountHelp.Ⴅ[83]) & 0xAC;
				num = ((3168 > num5) ? 8 : 9);
				break;
			}
			case 9:
				num = ⴄႤ[191] - ⴄႤ[149];
				break;
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴄ(Guid P_0, Guid P_1, int P_2, short P_3)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		bool result = default(bool);
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
					num2 = 7;
					continue;
				case 7:
					break;
				case 0:
					num2 = (((P_2 ^ P_3) - 7) ^ num) switch
					{
						0 => ⴅ[351] - 33, 
						_ => 3, 
					};
					continue;
				case 3:
				case 9:
					result = false;
					num2 = 2;
					continue;
				case 5:
					result = P_0 == P_1;
					num2 = ⴀႼ[113];
					continue;
				case 2:
				case 6:
				case 8:
				{
					num++;
					int num3 = 1774;
					int num4 = 829;
					num2 = ((887 >= num3 / 2 - num4) ? 1 : 0);
					continue;
				}
				case 1:
					return result;
				case 10:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : WebClient where _0021_00211 : string
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		IComparable comparable = default(IComparable);
		while (true)
		{
			int num = 0;
			int num2 = 5;
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
				case 5:
					num2 = (((P_3 ^ P_2) - 15) ^ num) switch
					{
						0 => 11, 
						_ => 8, 
					};
					continue;
				case 8:
					comparable = null;
					num2 = ⴐ[254];
					continue;
				case 11:
					comparable = P_0.DownloadString(P_1);
					num2 = 0;
					continue;
				case 0:
				case 4:
				case 6:
					num++;
					goto case 2;
				case 2:
				{
					int num3 = 19;
					int num4 = 50;
					num2 = ((350 > num4 - num3 * 7) ? 1 : 7);
					continue;
				}
				case 7:
					num2 = ⴅ[362] - 187;
					continue;
				case 1:
					return comparable as string;
				case 9:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static FileStream Ⴃ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : string
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		Stream stream = default(Stream);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႤ[395] - 14301;
					continue;
				case 7:
				case 9:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 96) ^ num) switch
					{
						0 => 0, 
						_ => ⴄႷ[45] - 37259, 
					};
					continue;
				case 3:
				case 11:
					stream = null;
					num2 = 2;
					continue;
				case 0:
				case 5:
					stream = File.OpenRead(P_0);
					num2 = ⴄႭ[246];
					continue;
				case 2:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 4;
					continue;
				case 4:
				{
					int num4;
					if (num3 % 2 == 0)
					{
						num4 = 6;
					}
					else
					{
						char num5 = ⴀႣ[422];
						SetDxCountHelp.ႭႤ[103] = (SetDxCountHelp.ႭႤ[103] * Arc4ServerClient.ႠႣ[217]) & 0xE7;
						num4 = num5 - 53519;
					}
					num2 = num4;
					continue;
				}
				case 6:
					return stream as FileStream;
				case 1:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}
}
