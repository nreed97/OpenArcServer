using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Security;
using System.Security.Cryptography;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using Meebey.SmartIrc4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public static class MailHelper
{
	public static void ProcessDir(NodeUserCmd cmd, int nmbr, string sql)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 0;
		Array array = default(Array);
		int num2 = default(int);
		object obj = default(object);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num)
			{
			default:
				array = cmd.Ⴍ().Ⴅ().Ⴀ()
					.ႨႨ()
					.Ⴀ(sql);
				if (((DataRow[])array).Length > 0)
				{
					num = ⴃႠ[384] - 36018;
					break;
				}
				cmd.Tx.Msg.Add(ႨႨ.Ⴀ(6, 4, 1157898576));
				return;
			case 2:
				num = ((nmbr <= (array as DataRow[]).Length) ? (ⴐ[198] - ⴐ[53]) : ⴄႭ[31]);
				break;
			case 3:
			case 10:
				nmbr = ((DataRow[])array).Length;
				num = 1;
				break;
			case 1:
				cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(6, 5, 1747260048, null));
				num = ⴍႤ[23] - 41752;
				break;
			case 8:
			case 12:
				num2 = 0;
				num = 9;
				break;
			case 5:
				obj = ((DataRow[])array)[num2];
				dateTime = SetAnnWrap.Ⴍ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ((DataRow)obj, ႰႥ.Ⴅ(7, '\u009b', 952620234), 981, 'Λ'), '\u030e', 869), 322, 'č');
				num = 6;
				break;
			case 4:
			case 6:
			{
				List<string> msg = cmd.Tx.Msg;
				Array array2 = new object[8];
				((object[])array2)[0] = ႰႥ.Ⴜ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ((DataRow)obj, SetStationQth.Ⴍ(null, 1687351401, 5, 26), 576, 'Ȏ'), 'ɘ', 563), 5, '\u0337', 771);
				((object[])array2)[1] = ႰႥ.Ⴜ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ((DataRow)obj, SetStationQth.Ⴍ(null, 1687351301, 2, 27), 855, '\u0319'), '\u0010', 123), 7, '\u0098', 172);
				((object[])array2)[2] = ႰႥ.Ⴜ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ((DataRow)obj, SetStationClubHelp.Ⴍ(13, 6, 1747258012, null), 444, 'ǲ'), '\u0361', 778), 10, '\u0337', 771);
				((object[])array2)[3] = ႰႥ.Ⴜ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(obj as DataRow, ReplyMail.Ⴅ(2, 8, 1217944714), 44, 'b'), 'Ȱ', 603), 10, 'ˌ', 760);
				((object[])array2)[4] = CallBlockCacheCfg.Ⴅ(null, 3, 62058416, null);
				(array2 as object[])[5] = dateTime.ToString(ShowWxHelp.Ⴍ('b', 985808356, 5));
				((object[])array2)[6] = CallBlockCacheCfg.Ⴅ(null, 3, 62058416, null);
				(array2 as object[])[7] = ((DataRow)obj)[ShowWxHelp.Ⴍ('\u008f', 985808769, 6)];
				msg.Add(string.Concat(array2 as object[]));
				num = ⴍႭ[127] - 24345;
				break;
			}
			case 11:
				num2++;
				num = ⴃႰ[127] - 32161;
				break;
			case 9:
				num = ((num2 < nmbr) ? (ⴃႠ[10] - 41650) : (ⴍႭ[18] - 56760));
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴅ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : Type where _0021_00211 : Type
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႨ[111] - 4754;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[162] - 80;
					continue;
				case 6:
					break;
				case 2:
				case 10:
					num2 = (((P_2 ^ P_3) - 52) ^ num) switch
					{
						0 => 9, 
						_ => ⴀႳ[291] - 40783, 
					};
					continue;
				case 1:
					result = true;
					goto case 7;
				case 7:
					num2 = 11;
					continue;
				case 9:
					result = P_0 == P_1;
					num2 = 11;
					continue;
				case 3:
				case 11:
				{
					num++;
					int num3 = 185;
					int num4 = 270;
					num2 = ((1890 > num4 - num3 * 7) ? 8 : (ⴍႭ[276] - 13144));
					continue;
				}
				case 5:
					num2 = 2;
					continue;
				case 8:
					return result;
				case 0:
					num2 = ⴃႰ[82] - 44765;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : CryptoStream
	{
		int num = 8;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 1;
				continue;
			case 1:
			case 5:
				num = (((P_2 ^ P_1) - 60) ^ num2) switch
				{
					0 => 2, 
					_ => 0, 
				};
				continue;
			case 0:
			case 6:
				num = 3;
				continue;
			case 2:
				P_0.FlushFinalBlock();
				goto case 3;
			case 3:
				num2++;
				num3 = 1455;
				break;
			case 7:
				break;
			case 4:
				return;
			}
			int num4 = 185;
			num = ((485 < num3 / 3 - num4) ? 1 : 4);
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : IrcEventHandler where _0021_00211 : IrcClient
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀ[247] - 8232;
				break;
			case 5:
				num = (((P_2 ^ P_3) - 32) ^ num2) switch
				{
					0 => 2, 
					_ => 0, 
				};
				break;
			case 0:
			case 7:
			case 9:
				num = 4;
				break;
			case 2:
				P_0.OnChannelMessage += P_1;
				goto case 4;
			case 4:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴀႣ[373] - 13258) : (ⴄႷ[103] - 22417));
				break;
			case 3:
				num = ⴀႨ[39] - 33474;
				break;
			case 1:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00211 : Hashtable
	{
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
				num = 2;
				break;
			case 2:
			case 5:
				num = (((P_2 ^ P_3) - 120) ^ num2) switch
				{
					0 => ⴀႳ[129] - ⴀႳ[129], 
					_ => ⴀႳ[75] - 14326, 
				};
				break;
			case 8:
				num = 9;
				break;
			case 0:
				P_0.Remove(P_1);
				goto case 9;
			case 9:
				num2++;
				goto case 1;
			case 1:
			case 6:
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 7 : ⴀႼ[96]);
				break;
			case 4:
				num = 2;
				break;
			case 7:
				return;
			}
		}
	}
}
