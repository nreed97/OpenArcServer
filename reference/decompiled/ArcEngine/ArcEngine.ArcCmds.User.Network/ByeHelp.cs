using System;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ByeHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 3;
			case 3:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267013868, typeof(ObjectManager)));
				num = ⴃႰ[34] - 17523;
				break;
			case 5:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130109, 4, 'j'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(12, null, 1057166928, 1));
				num = ⴀႣ[357] - 31389;
				break;
			case 6:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(6, '\u0092', 952620562));
				goto case 2;
			case 2:
			case 4:
				obj = new Publisher();
				num = 1;
				break;
			case 1:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : DataTable where _0021_00211 : DataTableCollection
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				break;
			case 7:
			case 8:
				num = (((P_2 ^ P_3) - 103) ^ num2) switch
				{
					0 => ⴄႤ[135], 
					_ => 4, 
				};
				break;
			case 4:
				num = ⴃႰ[74] - 47651;
				break;
			case 5:
				P_0.Add(P_1);
				goto case 1;
			case 1:
			case 6:
			{
				num2++;
				int num3 = 158;
				int num4 = 461;
				num = ((2305 > num4 - num3 * 5) ? (ⴀ[27] - 20740) : (ⴀႳ[8] - ⴀႳ[8]));
				break;
			}
			case 0:
			case 3:
				num = 8;
				break;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : PrecisionTimer
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 8;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 1;
				continue;
			case 1:
				num = (((P_1 ^ P_2) - 83) ^ num2) switch
				{
					0 => ⴀ[171] - 43183, 
					_ => ⴀႼ[0] - 46, 
				};
				continue;
			case 3:
				num = ⴄႤ[180] - ⴄႤ[50];
				continue;
			case 0:
			case 5:
				P_0.Stop();
				goto case 6;
			case 6:
				num2++;
				num3 = 2108;
				num4 = 32;
				break;
			case 4:
				break;
			case 2:
			case 7:
				return;
			}
			num = ((527 < num3 / 4 - num4) ? 1 : 7);
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[37] - 43356;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[208] - 20756;
					continue;
				case 5:
					break;
				case 1:
				case 7:
					num2 = (((P_2 ^ P_3) - 103) ^ num) switch
					{
						0 => 6, 
						1 => 11, 
						_ => ⴄႷ[69] - ⴄႷ[69], 
					};
					continue;
				case 0:
					result = false;
					num2 = ⴍႤ[254] - 62936;
					continue;
				case 6:
					result = P_0 == P_1;
					num2 = 10;
					continue;
				case 3:
				case 4:
				case 11:
					result = P_0 != P_1;
					num2 = 10;
					continue;
				case 10:
				{
					num++;
					int num3 = 133;
					int num4 = 352;
					num2 = ((1408 > num4 - num3 * 4) ? ⴄႭ[134] : 12);
					continue;
				}
				case 12:
					num2 = 1;
					continue;
				case 8:
					return result;
				case 2:
					num2 = ⴀႨ[23] - 24028;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float Ⴅ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : StationCfg
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		float result = default(float);
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
					num2 = 3;
					continue;
				case 3:
				case 7:
					break;
				case 10:
				{
					int num5 = P_1 ^ P_2;
					AnnCacheCfg.ႠႼ[91] = (byte)((AnnCacheCfg.ႠႼ[91] | P_2) & 0xAF);
					num2 = ((num5 - 65) ^ num) switch
					{
						0 => ⴄႷ[77] - 61876, 
						_ => ⴄႭ[56] / 3, 
					};
					continue;
				}
				case 9:
					result = 1.6887417f;
					goto case 1;
				case 1:
					num2 = ⴄႷ[4] - 30650;
					continue;
				case 8:
					result = P_0.Lon;
					num2 = ⴃႠ[229] - 45263;
					continue;
				case 2:
				{
					num++;
					int num3 = 966;
					int num4 = 417;
					num2 = ((483 < num3 / 2 - num4) ? 10 : 0);
					continue;
				}
				case 0:
					return result;
				case 4:
				case 6:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : Letter
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		ICloneable cloneable = default(ICloneable);
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
					num2 = 11;
					continue;
				case 11:
					break;
				case 4:
					Arc4ServerClient.ႠႣ[17] = (char)((Arc4ServerClient.ႠႣ[17] ^ P_1) & 0xF4);
					num2 = (((P_2 ^ P_1) - 34) ^ num) switch
					{
						0 => 2, 
						_ => 10, 
					};
					continue;
				case 8:
				case 10:
					cloneable = null;
					num2 = 5;
					continue;
				case 2:
					cloneable = P_0.Body;
					num2 = 5;
					continue;
				case 5:
				case 9:
				{
					num++;
					int num3 = 162;
					int num4 = 767;
					num2 = ((3835 > num4 - num3 * 5) ? 3 : 6);
					continue;
				}
				case 6:
					num2 = ⴅ[448] - 197;
					continue;
				case 3:
					return (string)cloneable;
				case 0:
				case 7:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, short P_3) where _0021_00210 : PerformanceCounter where _0021_00211 : string
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				continue;
			case 4:
				num = (((P_2 ^ P_3) - 38) ^ num2) switch
				{
					0 => 8, 
					_ => ⴃႥ[116] - 45454, 
				};
				continue;
			case 1:
			case 5:
				num = 3;
				continue;
			case 6:
			case 8:
				P_0.MachineName = P_1;
				break;
			case 0:
			case 3:
				break;
			case 2:
				return;
			}
			num2++;
			int num3 = 840;
			int num4 = 319;
			num = ((420 < num3 / 2 - num4) ? 4 : (ⴄႤ[451] - 150));
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : DataTable where _0021_00211 : DbDataAdapter
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
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
					num2 = 6;
					continue;
				case 6:
					break;
				case 4:
					num2 = (((P_2 ^ P_3) - 17) ^ num) switch
					{
						0 => ⴀႼ[35] - 127, 
						_ => ⴀႣ[273] - 59523, 
					};
					continue;
				case 7:
					result = P_2;
					goto case 10;
				case 10:
					num2 = ⴅ[92];
					continue;
				case 1:
				case 2:
					result = P_0.Update(P_1);
					num2 = 11;
					continue;
				case 11:
					num++;
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					goto case 9;
				case 9:
					num2 = ⴀႼ[1] - 216;
					continue;
				case 8:
					num2 = ((num3 % 2 != 0) ? 4 : 0);
					continue;
				case 0:
					return result;
				case 3:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}
}
