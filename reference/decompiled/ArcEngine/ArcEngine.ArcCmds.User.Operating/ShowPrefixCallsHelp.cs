using System;
using System.Collections;
using System.IO;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowPrefixCallsHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int num = 5;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(1, null, 1267022832, typeof(SkimmerValidSpot)));
				num = 0;
				break;
			case 0:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133313, 7, 'G'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(28, null, 1057162012, 4));
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(0, '\u0003', 952620082));
				goto case 2;
			case 2:
				obj = new Publisher();
				num = 6;
				break;
			case 6:
				(obj as Publisher).Process(cmd);
				return;
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : PrecisionTimer
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 1;
				break;
			case 1:
			case 9:
				num = (((P_1 ^ P_2) - 65) ^ num2) switch
				{
					0 => 3, 
					_ => ⴃႠ[54] - 44887, 
				};
				break;
			case 2:
				num = 8;
				break;
			case 3:
			case 5:
				P_0.Start();
				goto case 4;
			case 4:
			case 8:
			{
				num2++;
				int num3 = 461;
				int num4 = 864;
				SetAnnMode.ႤႭ[528] = (byte)(SetAnnMode.ႤႭ[528] & P_2 & 0x4F);
				num = ((7776 > num4 - num3 * 9) ? 7 : 6);
				break;
			}
			case 6:
				num = ⴍႤ[178] - 3020;
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : AnnWxSpot
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		IEquatable<string> equatable = default(IEquatable<string>);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 12;
					continue;
				case 12:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 56) ^ num) switch
					{
						0 => 0, 
						1 => ⴃႥ[46] - 62979, 
						_ => 2, 
					};
					continue;
				case 2:
					equatable = null;
					num2 = 8;
					continue;
				case 0:
					equatable = P_0.Spotter;
					num2 = 8;
					continue;
				case 4:
				case 7:
					equatable = P_0.DupeKey;
					num2 = 8;
					continue;
				case 8:
					num++;
					goto case 5;
				case 5:
					num3 = 241;
					num4 = 956;
					goto case 10;
				case 10:
					num2 = ((4780 > num4 - num3 * 5) ? 11 : (ⴀ[286] - 24719));
					continue;
				case 1:
					num2 = ⴅ[354] - 118;
					continue;
				case 11:
					return equatable as string;
				case 3:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : DxSpot
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႤ[323] - 37;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႳ[117] - 34482;
					continue;
				case 2:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 20) ^ num) switch
					{
						0 => 9, 
						1 => ⴄႷ[60] - 11691, 
						2 => 10, 
						3 => 5, 
						_ => ⴀႣ[0] - 46439, 
					};
					continue;
				case 14:
					result = false;
					num2 = 3;
					continue;
				case 8:
				case 9:
					result = P_0.Skimmer;
					num2 = 3;
					continue;
				case 7:
					result = P_0.Lotw;
					num2 = 3;
					continue;
				case 10:
					result = P_0.Master;
					num2 = ⴄႷ[70] - 5436;
					continue;
				case 5:
					result = P_0.Foc;
					num2 = ⴀႼ[112] - 213;
					continue;
				case 3:
				case 13:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 1;
					continue;
				case 1:
					num2 = ((num3 % 2 != 0) ? 4 : (ⴃႥ[113] - 53021));
					continue;
				case 6:
					return result;
				case 0:
				case 11:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static StreamReader Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : FileInfo
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		object obj = default(object);
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
					num2 = ⴍႭ[12] - 46118;
					continue;
				case 6:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 114) ^ num) switch
					{
						0 => 11, 
						_ => ⴄႷ[49] - 17967, 
					};
					continue;
				case 5:
					obj = null;
					goto case 8;
				case 8:
					num2 = 1;
					continue;
				case 11:
					obj = P_0.OpenText();
					num2 = ⴃႰ[195] - 17184;
					continue;
				case 1:
					num++;
					goto case 4;
				case 4:
				{
					int num3 = 6;
					int num4 = 343;
					num2 = ((686 > num4 - num3 * 2) ? 7 : 0);
					continue;
				}
				case 0:
					num2 = 9;
					continue;
				case 7:
					return obj as StreamReader;
				case 10:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴐ(short P_0, short P_1)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		IEnumerable enumerable = default(IEnumerable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[370] - 25901;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[6];
					continue;
				case 0:
					break;
				case 11:
					num2 = (((P_0 ^ P_1) - 127) ^ num) switch
					{
						0 => 2, 
						_ => 4, 
					};
					continue;
				case 4:
				case 9:
				case 10:
					enumerable = null;
					num2 = 1;
					continue;
				case 2:
				case 7:
					enumerable = UtilsVersion.ShortVersion;
					num2 = ⴐ[303] - ⴐ[332];
					continue;
				case 1:
					num++;
					num3 = P_0 * P_0;
					num3 = P_0 + num3;
					num2 = ⴃႥ[153] - 24218;
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? (ⴀႨ[176] - 907) : 5);
					continue;
				case 5:
					return enumerable as string;
				case 6:
					num2 = ⴍႤ[326] - 33204;
					continue;
				}
				break;
			}
		}
	}
}
