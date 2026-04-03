using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowQslInfoHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267014427, typeof(SetStationBeepHelp)));
				num = 5;
				break;
			case 5:
			case 6:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130335, 0, 'x'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(23, null, 1057167062, 4));
				goto case 0;
			case 0:
				num = ⴀႣ[223] - 44354;
				break;
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(8, 'ù', 952620883));
				obj = new Publisher();
				num = 2;
				break;
			case 1:
			case 2:
				(obj as Publisher).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, short P_3) where _0021_00210 : string where _0021_00211 : WwvSpot
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 9;
				break;
			case 9:
				num = (((P_3 ^ P_2) - 96) ^ num2) switch
				{
					0 => 7, 
					_ => 0, 
				};
				break;
			case 0:
				num = 1;
				break;
			case 2:
			case 7:
				P_0.K = P_1;
				goto case 1;
			case 1:
				num2++;
				goto case 4;
			case 4:
			case 8:
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? 6 : 3);
				break;
			case 3:
				num = ⴄႤ[51] / 3;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : WwvSpot
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		IComparable comparable = default(IComparable);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႰ[107] - 9437;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႼ[108] - 149;
					continue;
				case 7:
					break;
				case 3:
				case 5:
					num2 = (((P_2 ^ P_1) - 58) ^ num) switch
					{
						0 => ⴀႼ[112] - 210, 
						_ => 9, 
					};
					continue;
				case 9:
					comparable = null;
					num2 = 8;
					continue;
				case 6:
					comparable = P_0.Forecast;
					num2 = ⴀႳ[53] - 34755;
					continue;
				case 4:
				case 8:
				{
					num++;
					num5 = 1103;
					int num6 = num5;
					num4 = num6 * num6;
					num2 = 2;
					continue;
				}
				case 2:
					num4 = num5 + num4;
					num2 = ((num4 % 2 != 0) ? 3 : (ⴄႭ[66] * 2));
					continue;
				case 0:
				case 10:
					return comparable as string;
				case 11:
				{
					byte num3 = ⴀႼ[63];
					SetAnnMode.ႤႭ[290] = (byte)((SetAnnMode.ႤႭ[290] - SetWxOutput.ႣႰ[192]) & 0x66);
					num2 = num3 - 71;
					continue;
				}
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴀ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : DxCfg
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int result = default(int);
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
					num2 = ⴃႠ[378] - 16196;
					continue;
				case 3:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 60) ^ num) switch
					{
						0 => 9, 
						_ => 4, 
					};
					continue;
				case 4:
					result = 11;
					goto case 5;
				case 5:
					num2 = 0;
					continue;
				case 8:
				case 9:
					result = P_0.NmbrSpots;
					num2 = ⴄႷ[50] - ⴄႷ[50];
					continue;
				case 0:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴄႤ[241] - 120) : (ⴄႭ[492] / 6));
					continue;
				case 6:
					num2 = ⴀႣ[398] - 375;
					continue;
				case 2:
				case 10:
					return result;
				case 11:
					num2 = ⴀႳ[229] - 53850;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, short P_3) where _0021_00210 : string where _0021_00211 : DxSpot
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				break;
			case 8:
				num = (((P_3 ^ P_2) - 91) ^ num2) switch
				{
					0 => ⴅ[20], 
					1 => 6, 
					_ => ⴀႣ[27] - 42954, 
				};
				break;
			case 0:
			case 3:
			case 7:
				num = 9;
				break;
			case 10:
				P_0.Route = P_1;
				num = ⴀႨ[116] - 13784;
				break;
			case 4:
			case 6:
				P_0.DupeKey = P_1;
				goto case 9;
			case 9:
			{
				num2++;
				int num3 = 93;
				int num4 = 836;
				num = ((2508 > num4 - num3 * 3) ? (ⴍႤ[168] - 61368) : 2);
				break;
			}
			case 2:
				num = ⴀႼ[33] - 1;
				break;
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		IEnumerable enumerable = default(IEnumerable);
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
					num2 = ⴃႠ[203] - 62333;
					continue;
				case 12:
					break;
				case 7:
				case 9:
					num2 = (((P_2 ^ P_1) - 115) ^ num) switch
					{
						0 => 6, 
						1 => 4, 
						_ => 10, 
					};
					continue;
				case 10:
					enumerable = null;
					num2 = ⴀႳ[178] - 52520;
					continue;
				case 6:
					enumerable = UtilsCallsign.GetNoSsidCall(P_0);
					num2 = 2;
					continue;
				case 4:
				case 8:
					enumerable = UtilsString.FileFromFilePath(P_0);
					num2 = 2;
					continue;
				case 2:
				{
					num++;
					int num3 = 54;
					int num4 = 168;
					num2 = ((336 > num4 - num3 * 2) ? (ⴃႥ[278] - 35271) : (ⴅ[146] - ⴅ[9]));
					continue;
				}
				case 0:
				case 3:
					num2 = 7;
					continue;
				case 5:
					return (string)enumerable;
				case 1:
					num2 = ⴐ[196] / 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, int P_3) where _0021_00210 : DxSpot
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 3;
				continue;
			case 3:
			case 7:
				num = (((P_2 ^ P_3) - 31) ^ num2) switch
				{
					0 => ⴐ[191] - 0, 
					_ => ⴃႥ[381] - 36895, 
				};
				continue;
			case 4:
				num = 5;
				continue;
			case 2:
				P_0.IsSkimUnknown = P_1;
				break;
			case 5:
			case 6:
			case 8:
				break;
			case 1:
				return;
			}
			num2++;
			int num3 = 160;
			int num4 = 26;
			num = ((40 < num3 / 4 - num4) ? (ⴀႨ[30] - 823) : (ⴀႣ[322] - 54335));
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210>(_0021_00210 P_0, CommandType P_1, char P_2, char P_3) where _0021_00210 : DbCommand
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 8;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႼ[96];
				break;
			case 4:
				num = (((P_2 ^ P_3) - 19) ^ num2) switch
				{
					0 => ⴄႷ[66] - 17235, 
					_ => ⴄႭ[56] / 9, 
				};
				break;
			case 0:
			case 3:
				num = 9;
				break;
			case 7:
				P_0.CommandType = P_1;
				goto case 9;
			case 9:
				num2++;
				num3 = 494;
				goto case 2;
			case 2:
			{
				int num4 = 629;
				num = ((3774 > num4 - num3 * 6) ? 5 : 6);
				break;
			}
			case 6:
				num = ⴍႭ[297] - 58546;
				break;
			case 1:
			case 5:
				return;
			}
		}
	}
}
