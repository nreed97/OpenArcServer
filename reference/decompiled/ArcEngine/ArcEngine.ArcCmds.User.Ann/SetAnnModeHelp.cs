using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Security;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnModeHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267022230, typeof(AnnWxCmdType)));
				num = 4;
				break;
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134058, 0, 'U'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(22, null, 1057161637, 1));
				num = 6;
				break;
			case 5:
			case 6:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(3, '8', 952620702));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 5, 62058365, null));
				num = ⴀႼ[128] / 6;
				break;
			case 7:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(3, 15, 1217945183));
				obj = new Publisher();
				num = 3;
				break;
			case 3:
				(obj as Publisher).Process(cmd);
				DirectoryBulletin.ႠႨ[218] = (DirectoryBulletin.ႠႨ[218] ^ DirectoryBulletin.ႠႨ[194]) & 0x32;
				return;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴐ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : TextReader
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
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
					num2 = ⴍႤ[392] - 10969;
					continue;
				case 6:
				case 10:
					break;
				case 5:
					num2 = (((P_1 ^ P_2) - 77) ^ num) switch
					{
						0 => ⴀႼ[96], 
						_ => ⴍႭ[296] - 40615, 
					};
					continue;
				case 2:
					enumerable = null;
					num2 = 7;
					continue;
				case 4:
					enumerable = P_0.ReadLine();
					num2 = 7;
					continue;
				case 7:
					num++;
					goto case 8;
				case 8:
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴄႭ[80] - ⴄႭ[386]) : 3);
					continue;
				case 3:
					num2 = ⴀႳ[295] - 59874;
					continue;
				case 11:
					return enumerable as string;
				case 0:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		MemberInfo memberInfo = default(MemberInfo);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႭ[321] - 60440;
					continue;
				case 7:
					break;
				case 3:
					BandModeCacheCfg.ႠႳ[323] = (char)((BandModeCacheCfg.ႠႳ[323] ^ P_1) & 0xF5);
					num2 = (((P_2 ^ P_1) - 74) ^ num) switch
					{
						0 => ⴃႠ[426] - 16014, 
						_ => ⴅ[195] - 120, 
					};
					continue;
				case 9:
					memberInfo = typeof(SetStationNeedsHelp);
					goto case 10;
				case 10:
					num2 = 2;
					continue;
				case 1:
					memberInfo = P_0.GetType();
					num2 = ⴃႠ[265] - 24964;
					continue;
				case 2:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 0;
				case 0:
					num2 = 8;
					continue;
				case 8:
					num2 = ((num3 % 2 != 0) ? (ⴃႠ[219] - 22415) : (ⴃႰ[174] - 58160));
					continue;
				case 5:
				case 11:
					return memberInfo as Type;
				case 4:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : DataRow where _0021_00211 : DataTable
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 3;
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
				num = (((P_3 ^ P_2) - 73) ^ num2) switch
				{
					0 => 8, 
					_ => ⴀႣ[362] - 30519, 
				};
				break;
			case 9:
				num = ⴐ[70] - ⴐ[317];
				break;
			case 2:
			case 8:
				P_0.ImportRow(P_1);
				goto case 1;
			case 1:
			case 4:
				num2++;
				goto case 0;
			case 0:
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴀႼ[89] - 175) : (ⴀႳ[291] - 40779));
				break;
			case 5:
				num = 6;
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte Ⴅ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : string
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte result = default(byte);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 8;
					continue;
				case 8:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 93) ^ num) switch
					{
						0 => ⴅ[92], 
						_ => 4, 
					};
					continue;
				case 4:
					result = 15;
					num2 = 6;
					continue;
				case 11:
					result = CtyInfo.ScrubZone(P_0);
					num2 = ⴍႭ[281] - 23361;
					continue;
				case 6:
					num++;
					goto case 10;
				case 10:
					num3 = 199;
					goto case 7;
				case 7:
				{
					int num4 = 383;
					num2 = ((2681 > num4 - num3 * 7) ? 5 : 9);
					continue;
				}
				case 9:
					num2 = ⴍႤ[185] - 5419;
					continue;
				case 0:
				case 5:
					return result;
				case 2:
					num2 = ⴀ[119] - 4867;
					continue;
				}
				break;
			}
		}
	}
}
