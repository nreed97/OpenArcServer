using System;
using System.Data.OleDb;
using System.Net;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Talk;

public sealed class SetTalkDefaultHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 3;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(2, null, 1267015899, typeof(SetWwvDefault)));
				num = 5;
				break;
			case 5:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132798, 2, '2'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(24, null, 1057166161, 3));
				num = ⴄႤ[459] - ⴄႤ[274];
				break;
			case 2:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(4, 'ó', 952621693));
				obj = new Publisher();
				goto case 0;
			case 0:
				num = 1;
				break;
			case 1:
				(obj as Publisher).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : DirectoryMonitor
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				break;
			case 0:
			{
				int num5 = (P_2 ^ P_1) - 44;
				int num6 = num2;
				SetTalkCountHelp.Ⴅ[21] = (byte)((SetTalkCountHelp.Ⴅ[21] + DirectoryBulletin.ႠႨ[24]) & 0x3A);
				num = (num5 ^ num6) switch
				{
					0 => ⴀ[338] - 25695, 
					_ => 8, 
				};
				break;
			}
			case 8:
				num = 3;
				break;
			case 5:
				P_0.Start();
				goto case 3;
			case 3:
			{
				num2++;
				int num3 = 323;
				int num4 = 656;
				num = ((4592 > num4 - num3 * 7) ? (ⴀႣ[255] - 430) : (ⴃႥ[334] - 56888));
				break;
			}
			case 4:
				num = 0;
				break;
			case 1:
			case 2:
			case 6:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, int P_3) where _0021_00210 : DxCommentExtCfg
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄႷ[124] - 47739;
				break;
			case 9:
				num = (((P_2 ^ P_3) - 108) ^ num2) switch
				{
					0 => 8, 
					_ => ⴀႣ[335] - 40272, 
				};
				break;
			case 1:
				num = 7;
				break;
			case 8:
				P_0.CqZone = P_1;
				goto case 0;
			case 0:
			case 7:
				num2++;
				goto case 3;
			case 3:
			{
				int num3 = 1226;
				num = (((num3 * num3 + num3) % 2 == 0) ? (ⴃႰ[32] - 1120) : 4);
				break;
			}
			case 4:
			case 6:
				num = 9;
				break;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴈ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : string where _0021_00211 : string
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		bool result = default(bool);
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
					num2 = 1;
					continue;
				case 1:
					break;
				case 8:
					num2 = (((P_3 ^ P_2) - 108) ^ num) switch
					{
						0 => 10, 
						_ => ⴀႨ[94] - 43552, 
					};
					continue;
				case 3:
					result = true;
					num2 = ⴄႷ[11] - 38827;
					continue;
				case 10:
					result = P_0.EndsWith(P_1);
					num2 = 2;
					continue;
				case 2:
					num++;
					num3 = 995;
					goto case 5;
				case 5:
				{
					int num4 = num3;
					num2 = (((num4 * num4 + num3) % 2 == 0) ? 11 : 6);
					continue;
				}
				case 6:
					num2 = 8;
					continue;
				case 9:
				case 11:
					return result;
				case 0:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : OleDbCommand
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႠ[429] - 37102;
				continue;
			case 1:
			case 3:
			case 5:
				SetWxOutput.ႣႰ[94] = (char)((SetWxOutput.ႣႰ[94] * P_1) & 0xE0);
				num = (((P_1 ^ P_2) - 57) ^ num2) switch
				{
					0 => ⴅ[365] / 6, 
					_ => ⴀ[193] - 155, 
				};
				continue;
			case 0:
				num = ⴃႥ[64] - 26224;
				continue;
			case 2:
				OleDbCommandBuilder.DeriveParameters(P_0);
				break;
			case 8:
				break;
			case 7:
				return;
			}
			num2++;
			int num3 = 1452;
			int num4 = 224;
			num = ((484 < num3 / 3 - num4) ? (ⴀႳ[38] - 44453) : (ⴀႳ[233] - 50826));
		}
	}

	[SecuritySafeCritical]
	internal static WebRequest Ⴗ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		MarshalByRefObject marshalByRefObject = default(MarshalByRefObject);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 9;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 100) ^ num) switch
					{
						0 => ⴃႰ[114] - 38480, 
						_ => ⴃႥ[83] - 54509, 
					};
					continue;
				case 3:
					marshalByRefObject = null;
					num2 = 0;
					continue;
				case 4:
					marshalByRefObject = WebRequest.Create(P_0);
					num2 = 0;
					continue;
				case 0:
					num++;
					num3 = P_2 * P_2;
					goto case 5;
				case 5:
				case 6:
					num3 = P_2 + num3;
					num2 = 11;
					continue;
				case 11:
					num2 = ((num3 % 2 != 0) ? 9 : (ⴍႤ[81] - 29118));
					continue;
				case 1:
				case 10:
					return marshalByRefObject as WebRequest;
				case 8:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		DateTime result = default(DateTime);
		while (true)
		{
			int num = 0;
			int num2 = 9;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႳ[305] - 41983;
					continue;
				case 10:
					break;
				case 6:
				case 9:
					num2 = (((P_2 ^ P_1) - 69) ^ num) switch
					{
						0 => ⴐ[390] - 52, 
						_ => ⴍႭ[139] - 7128, 
					};
					continue;
				case 3:
				case 4:
					result = default(DateTime);
					goto case 0;
				case 0:
					num2 = ⴅ[145];
					continue;
				case 2:
					result = DateTime.Parse(P_0);
					num2 = 7;
					continue;
				case 7:
				{
					num++;
					int num3 = 84;
					int num4 = 10;
					num2 = ((28 < num3 / 3 - num4) ? 9 : 8);
					continue;
				}
				case 8:
					return result;
				case 1:
					num2 = ⴄႭ[507] - 74;
					continue;
				}
				break;
			}
		}
	}
}
