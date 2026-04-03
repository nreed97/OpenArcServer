using System;
using System.Collections.Generic;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using HtmlAgilityPack;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wwv;

public sealed class WwvHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 7;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267014149, typeof(ShowLogHelp)));
				num = 4;
				break;
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129965, 3, 'f'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(16, null, 1057167348, 4));
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(0, 'E', 952616387));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 1, 62061758, null));
				goto case 5;
			case 5:
				num = 1;
				break;
			case 1:
			case 6:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(7, 6, 1217942422));
				goto case 3;
			case 3:
				cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(4, 1, 1747262937, null));
				num = ⴃႠ[46] - 40103;
				break;
			case 0:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : WwvCfg
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int result = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 4;
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
				case 4:
				{
					int num4 = (P_2 ^ P_1) - 101;
					int num5 = num;
					ShowQrzHelp.ႤႤ[210] = SetAnnMode.ႤႭ[56];
					num2 = (num4 ^ num5) switch
					{
						0 => 8, 
						_ => 7, 
					};
					continue;
				}
				case 7:
					result = 3;
					num2 = ⴍႭ[333] - 17133;
					continue;
				case 8:
					result = P_0.NmbrSpots;
					num2 = ⴍႭ[47] - 63729;
					continue;
				case 0:
				case 1:
				case 10:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 6;
					continue;
				case 3:
				case 6:
					num2 = ((num3 % 2 != 0) ? 4 : (ⴀႨ[80] - 46765));
					continue;
				case 11:
					return result;
				case 9:
					num2 = ⴄႤ[361] - 241;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : HtmlNode
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[480] - 26871;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 10:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 48) ^ num) switch
					{
						0 => ⴍႭ[229] - 26054, 
						_ => ⴀႼ[136], 
					};
					continue;
				case 5:
					enumerable = null;
					num2 = ⴀႼ[7] / 7;
					continue;
				case 3:
				case 4:
				case 8:
					enumerable = P_0.InnerText;
					num2 = 11;
					continue;
				case 11:
					num++;
					num3 = 704;
					num4 = 927;
					goto case 9;
				case 9:
					num2 = ((2781 > num4 - num3 * 3) ? 6 : 7);
					continue;
				case 7:
					num2 = 1;
					continue;
				case 6:
					return (string)enumerable;
				case 0:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : DxSpot where _0021_00211 : string
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
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
				num = ⴍႭ[11] - 42756;
				break;
			case 7:
				num = (((P_3 ^ P_2) - 63) ^ num2) switch
				{
					0 => 1, 
					_ => 3, 
				};
				break;
			case 3:
				num = 4;
				break;
			case 1:
				P_0.Cty = P_1;
				goto case 4;
			case 4:
				num2++;
				goto case 8;
			case 8:
				num3 = 2;
				num4 = 60;
				goto case 9;
			case 9:
				num = ((120 > num4 - num3 * 2) ? (ⴀႣ[375] - 21698) : 5);
				break;
			case 5:
				num = ⴍႤ[345] - 45605;
				break;
			case 2:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static double Ⴍ(double P_0, char P_1, char P_2)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		double result = default(double);
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
				case 9:
					num2 = (((P_1 ^ P_2) - 20) ^ num) switch
					{
						0 => 4, 
						_ => 7, 
					};
					continue;
				case 7:
					result = 1.08663206165034;
					num2 = 2;
					continue;
				case 4:
					result = Math.Floor(P_0);
					num2 = 2;
					continue;
				case 2:
					num++;
					num3 = P_2 * P_2;
					goto case 6;
				case 6:
					num3 = P_2 + num3;
					num2 = ⴍႤ[129] - 30345;
					continue;
				case 0:
					num2 = ((num3 % 2 != 0) ? 1 : 10);
					continue;
				case 10:
				case 11:
					return result;
				case 5:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}
}
