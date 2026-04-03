using System;
using System.Data.OleDb;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class SetDxExtensionHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(2, null, 1267018718, typeof(WwvCache)));
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131902, 3, '\u0095'));
				goto case 7;
			case 7:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(27, null, 1057165269, 5));
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(0, '\u0086', 952622840));
				goto case 4;
			case 4:
			case 6:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 3, 62056265, null));
				num = ⴀ[116] - 54177;
				break;
			case 5:
			{
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(1, 9, 1217943062));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 4, 62057767, null));
				char num2 = ⴀႳ[111];
				SetAnnChatRooms.Ⴀ[342] = (char)((SetAnnChatRooms.Ⴀ[342] ^ SetAnnChatRooms.Ⴀ[435]) & 0x56);
				num = num2 - 53580;
				break;
			}
			case 0:
			{
				object obj = new Publisher();
				(obj as Publisher).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, short P_3) where _0021_00210 : DxCommentExtCfg
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႠ[275] - 31807;
				continue;
			case 2:
			case 6:
				num = (((P_3 ^ P_2) - 88) ^ num2) switch
				{
					0 => ⴄႤ[34] - 82, 
					_ => 8, 
				};
				continue;
			case 8:
				num = 3;
				continue;
			case 5:
			case 7:
				P_0.Cty = P_1;
				break;
			case 0:
			case 3:
				break;
			case 4:
				return;
			}
			num2++;
			int num3 = 399;
			int num4 = 68;
			num = ((133 < num3 / 3 - num4) ? ⴄႭ[246] : ⴐ[367]);
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DxSpot
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႥ[276] - ⴃႥ[276];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႳ[282] - 35090;
					continue;
				case 11:
					break;
				case 0:
					num2 = (((P_2 ^ P_1) - 18) ^ num) switch
					{
						0 => ⴄႤ[302] - 137, 
						1 => 6, 
						2 => 5, 
						_ => 8, 
					};
					continue;
				case 8:
				case 10:
					comparable = null;
					num2 = 7;
					continue;
				case 1:
					comparable = P_0.Comment;
					num2 = 7;
					continue;
				case 6:
					comparable = P_0.SpotterCty;
					goto case 13;
				case 13:
					num2 = 7;
					continue;
				case 5:
					comparable = P_0.DupeKey;
					num2 = 7;
					continue;
				case 7:
				{
					num++;
					int num3 = 480;
					int num4 = 524;
					num2 = ((3144 > num4 - num3 * 6) ? ⴐ[367] : (ⴅ[372] - 50));
					continue;
				}
				case 9:
					num2 = 0;
					continue;
				case 4:
					return (string)comparable;
				case 2:
					num2 = ⴀႳ[70] - ⴀႳ[70];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static OleDbParameterCollection Ⴐ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : OleDbCommand
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႤ[121] - 178;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 5:
				case 10:
					num2 = (((P_2 ^ P_1) - 30) ^ num) switch
					{
						0 => 1, 
						_ => ⴀႨ[199] - 25199, 
					};
					continue;
				case 6:
					obj = null;
					num2 = ⴍႭ[377] - 1554;
					continue;
				case 1:
					obj = P_0.Parameters;
					num2 = 8;
					continue;
				case 8:
				case 9:
				{
					num++;
					int num3 = P_1 * P_1;
					SetAnnChatRooms.Ⴀ[150] = (char)(SetAnnChatRooms.Ⴀ[150] & DirectoryBulletin.ႠႨ[94] & 0x48);
					num2 = (((num3 + P_1) % 2 == 0) ? 2 : (ⴐ[8] - 43));
					continue;
				}
				case 4:
					num2 = ⴅ[20];
					continue;
				case 2:
					return obj as OleDbParameterCollection;
				case 3:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}
}
