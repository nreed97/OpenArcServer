using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;

namespace ArcEngine.ArcCmds.Dx;

public class DxSpotUserHelp : IArcCmd
{
	internal sealed class Ⴈ
	{
		internal bool Ⴃ;

		internal bool Ⴄ;

		internal bool Ⴗ;

		internal Ⴈ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267019105, typeof(DxPerformanceCounter)));
				num = 0;
				continue;
			case 0:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216135104, 5, '{'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(5, null, 1057162439, 3));
				goto case 1;
			case 1:
				num = ⴄႤ[1] - 151;
				continue;
			case 5:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 3, 62057760, null));
				num = ⴃႠ[192] - 23551;
				continue;
			case 3:
				obj = new Publisher();
				break;
			case 6:
				break;
			}
			break;
		}
		((Publisher)obj).Process(cmd);
	}

	[SecuritySafeCritical]
	internal static int Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : InternalDataCollectionBase
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int result = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[419] - 56;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႣ[235] - 11075;
					continue;
				case 10:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 93) ^ num) switch
					{
						0 => 1, 
						_ => 9, 
					};
					continue;
				case 9:
					result = 5;
					num2 = 6;
					continue;
				case 1:
					result = P_0.Count;
					num2 = ⴀႨ[16] - 34730;
					continue;
				case 6:
					num++;
					goto case 7;
				case 7:
					num3 = 349;
					num4 = 578;
					goto case 4;
				case 4:
					num2 = ((2890 > num4 - num3 * 5) ? (ⴃႥ[309] - 45453) : (ⴃႥ[235] - ⴃႥ[235]));
					continue;
				case 0:
					num2 = 11;
					continue;
				case 3:
				case 8:
					return result;
				case 2:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴅ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : Hashtable
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 10;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 6;
					continue;
				case 6:
					break;
				case 10:
					num2 = (((P_2 ^ P_3) - 17) ^ num) switch
					{
						0 => ⴀႨ[60] - 55455, 
						_ => 7, 
					};
					continue;
				case 7:
					result = true;
					num2 = 3;
					continue;
				case 0:
				case 4:
				case 5:
					result = P_0.Contains(P_1);
					num2 = ⴃႥ[331] - 12901;
					continue;
				case 3:
				{
					num++;
					num3 = P_3 * P_3;
					int num4 = num3;
					SetAnnMode.ႤႭ[223] = (byte)((SetAnnMode.ႤႭ[223] | P_3) & 0x58);
					num3 = P_3 + num4;
					num2 = 2;
					continue;
				}
				case 2:
					num2 = ((num3 % 2 != 0) ? 10 : 11);
					continue;
				case 11:
					return result;
				case 8:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴀ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : FileSystemInfo
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		DateTime result = default(DateTime);
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
					num2 = 9;
					continue;
				case 9:
					break;
				case 7:
					num2 = (((P_2 ^ P_1) - 124) ^ num) switch
					{
						0 => ⴄႤ[297] - 97, 
						_ => 8, 
					};
					continue;
				case 8:
					result = default(DateTime);
					num2 = 4;
					continue;
				case 1:
				case 2:
				case 6:
					result = P_0.LastWriteTime;
					num2 = ⴀႨ[17] - 11464;
					continue;
				case 4:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 11 : ⴄႭ[66]);
					continue;
				case 0:
					num2 = 7;
					continue;
				case 3:
				case 11:
					return result;
				case 5:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ModeType Ⴗ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : AnnCfg
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		ModeType result = default(ModeType);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[270] - 25184;
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
				case 6:
				case 10:
					num2 = (((P_2 ^ P_1) - 84) ^ num) switch
					{
						0 => 0, 
						_ => ⴀႼ[126] - 234, 
					};
					continue;
				case 4:
				case 11:
					result = ModeType.Open;
					num2 = 2;
					continue;
				case 0:
					result = P_0.Mode;
					num2 = ⴀႳ[4] - 24695;
					continue;
				case 2:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 7 : 5);
					continue;
				case 5:
					num2 = 6;
					continue;
				case 7:
					return result;
				case 3:
					num2 = ⴄႭ[435] - 228;
					continue;
				}
				break;
			}
		}
	}
}
