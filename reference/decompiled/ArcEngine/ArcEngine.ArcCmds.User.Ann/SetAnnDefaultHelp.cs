using System.Runtime.InteropServices;
using System.Security;
using System.Xml;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnDefaultHelp : IArcCmd
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴄ
	{
		internal AnnCacheCfg Ⴍ;

		internal BandModeCacheCfg Ⴃ;

		internal ChatRoomPvtCfg Ⴀ;

		internal ChatRoomPubCfg Ⴈ;

		internal CtyCacheCfg Ⴓ;

		internal DxCacheCfg Ⴗ;

		internal FocCacheCfg Ⴐ;

		internal IpLockoutCacheCfg Ⴄ;

		internal LotwCacheCfg Ⴅ;

		internal MasterCallCacheCfg Ⴜ;

		internal Top100CacheCfg ႣႭ;

		internal UserCacheCfg ႣႣ;

		internal WwvCacheCfg ႣႠ;

		internal WxCacheCfg ႣႨ;
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(5, null, 1267016980, typeof(SetWxFilter)));
				num = 4;
				break;
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129890, 7, '\u001f'));
				goto case 7;
			case 7:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(9, null, 1057165434, 5));
				num = 1;
				break;
			case 1:
			{
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 4, 62058364, null));
				char num2 = ⴀႳ[180];
				SetAnnChatRooms.Ⴀ[361] = (char)((SetAnnChatRooms.Ⴀ[361] ^ SetAnnChatRooms.Ⴀ[508]) & 0x1D);
				num = num2 - 40975;
				break;
			}
			case 0:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(3, 12, 1217945183));
				goto case 5;
			case 5:
				obj = new Publisher();
				num = 3;
				break;
			case 3:
			case 6:
				(obj as Publisher).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : DxSpot where _0021_00211 : string
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 12;
				break;
			case 9:
			case 12:
				BandModeCacheCfg.ႠႳ[185] = (char)((BandModeCacheCfg.ႠႳ[185] ^ SetTalkCountHelp.Ⴅ[172]) & 0x55);
				num = (((P_3 ^ P_2) - 95) ^ num2) switch
				{
					0 => ⴀ[257] - 37055, 
					1 => 6, 
					2 => 4, 
					3 => 10, 
					_ => ⴅ[210], 
				};
				break;
			case 8:
				num = ⴍႭ[163] - 17755;
				break;
			case 11:
				P_0.Call = P_1;
				num = ⴄႤ[148];
				break;
			case 6:
				P_0.Comment = P_1;
				num = 1;
				break;
			case 4:
				P_0.SpotterCty = P_1;
				num = ⴄႷ[116] - 52931;
				break;
			case 10:
				P_0.DeserializeClientSpot(P_1);
				goto case 1;
			case 1:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 7 : (ⴄႷ[2] - 23604));
				break;
			case 0:
			case 2:
				num = 12;
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DxSpot
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 11;
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
				case 11:
				{
					int num4;
					switch (((P_2 ^ P_1) - 57) ^ num)
					{
					default:
						num4 = 3;
						break;
					case 0:
					{
						byte num5 = ⴅ[235];
						byte num6 = ⴅ[235];
						ႨႣ.Ⴐ[170] = (byte)((ႨႣ.Ⴐ[170] - P_2) & 0x10);
						num4 = num5 - num6;
						break;
					}
					case 1:
						num4 = ⴃႰ[140] - 50915;
						break;
					}
					num2 = num4;
					continue;
				}
				case 3:
					result = true;
					goto case 1;
				case 1:
					num2 = ⴄႤ[415] - 208;
					continue;
				case 0:
					result = P_0.IsDupe;
					num2 = ⴃႰ[165] - 8095;
					continue;
				case 5:
				case 12:
					result = P_0.SkimCq;
					num2 = 4;
					continue;
				case 4:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴀႣ[186] - 23871;
					continue;
				case 6:
					num2 = ((num3 % 2 != 0) ? 11 : 2);
					continue;
				case 2:
				case 10:
					return result;
				case 9:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, char P_3) where _0021_00210 : StationCfg
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 2;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 3;
				break;
			case 3:
				num = (((P_2 ^ P_3) - 78) ^ num3) switch
				{
					0 => 9, 
					_ => 8, 
				};
				break;
			case 8:
				num = ⴀ[191] - 52039;
				break;
			case 4:
			case 9:
				P_0.Beep = P_1;
				goto case 1;
			case 1:
				num3++;
				num2 = P_2 * P_2;
				goto case 6;
			case 6:
				num2 = P_2 + num2;
				num = ⴀႨ[141] - 33429;
				break;
			case 7:
				num = ((num2 % 2 != 0) ? (ⴍႤ[341] - 16483) : 5);
				break;
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static XmlElement Ⴓ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, short P_3) where _0021_00210 : XmlDocument where _0021_00211 : string
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		object obj = default(object);
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
					num2 = ⴀႳ[135] - 41062;
					continue;
				case 0:
				case 11:
					break;
				case 5:
					num2 = (((P_2 ^ P_3) - 110) ^ num) switch
					{
						0 => 2, 
						_ => 1, 
					};
					continue;
				case 1:
					obj = null;
					num2 = ⴄႭ[398] - 214;
					continue;
				case 2:
					obj = P_0.CreateElement(P_1);
					num2 = 3;
					continue;
				case 3:
				case 8:
				{
					num++;
					int num4;
					if ((P_3 * P_3 + P_3) % 2 != 0)
					{
						char num3 = ⴃႥ[420];
						SetDxCountHelp.ႭႤ[332] = (SetDxCountHelp.ႭႤ[332] + BandModeCacheCfg.ႠႳ[113]) & 0xF4;
						num4 = num3 - 8220;
					}
					else
					{
						num4 = 9;
					}
					num2 = num4;
					continue;
				}
				case 10:
					num2 = 5;
					continue;
				case 9:
					return obj as XmlElement;
				case 7:
					num2 = ⴀ[483] - 55415;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴗ(char P_0, int P_1, int P_2)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		bool result = default(bool);
		int num3 = default(int);
		int num4 = default(int);
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
					num2 = ⴍႤ[70] - 3996;
					continue;
				case 9:
					break;
				case 3:
					num2 = (((P_2 ^ P_1) - 79) ^ num) switch
					{
						0 => ⴍႭ[371] - 49259, 
						_ => 5, 
					};
					continue;
				case 5:
				case 10:
					result = true;
					num2 = ⴀႣ[306] - 43951;
					continue;
				case 7:
					result = UtilsNumeric.IsNumeric(P_0);
					num2 = ⴍႤ[141] - 19081;
					continue;
				case 4:
					num++;
					goto case 1;
				case 1:
					num3 = 1635;
					num4 = 362;
					goto case 0;
				case 0:
					num2 = ((545 < num3 / 3 - num4) ? 3 : 2);
					continue;
				case 2:
					return result;
				case 8:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}
}
