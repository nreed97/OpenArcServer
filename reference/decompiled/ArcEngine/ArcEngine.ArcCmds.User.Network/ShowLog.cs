using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces.Spots;
using ArcShared.ExtensionMethods;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ShowLog : IArcCmd
{
	private static void Ⴀ(NodeUserCmd P_0)
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(5, 6, 1157898360), P_0.Rx.Msg, 86, 24));
				break;
			case 2:
				break;
			case 1:
			{
				object obj = new ShowLogHelp();
				((ShowLogHelp)obj).Exec(P_0);
				return;
			}
			case 0:
			case 3:
				return;
			}
			num = 1;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		cmd.Tx.DistroType = DistroType.ToRequester;
		try
		{
			int num = 6;
			IComparable comparable = default(IComparable);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length == 2) ? 1 : 8);
					break;
				case 0:
				case 1:
					Ⴓ(cmd, AnnHelp.Ⴈ(CallBlockCacheCfg.Ⴅ(null, 8, 62054497, null), cmd.Ⴍ().Call, ႨႨ.Ⴀ(3, 6, 1157903555), 434, 'ƅ'));
					num = 10;
					break;
				case 8:
					num = ((!ByeHelp.Ⴍ(SetDxFilter.Ⴀ(cmd.Rx.Split[2], 182, 'ö'), CallBlockCacheCfg.Ⴅ(null, 3, 62057915, null), 131, 228)) ? 9 : (ⴀႣ[243] - 26577));
					break;
				case 7:
					Ⴓ(cmd, SetStationClubHelp.Ⴍ(8, 7, 1747258271, null));
					num = ⴀႣ[276] - 14068;
					break;
				case 2:
				case 9:
					comparable = cmd.Rx.GetMsgEnd(2);
					num = ((!ႷႷ.Ⴍ(SetDxFilter.Ⴀ((string)comparable, 588, 'ȍ'), 707, 'ˎ')) ? (ⴅ[120] / 5) : (ⴃႠ[192] - 23551));
					break;
				case 3:
				case 5:
					comparable = ShowUsersHelp.Ⴅ(ShowWxHelp.Ⴍ('ê', 985805661, 2), (string)comparable, 138, 196);
					num = ⴍႭ[371] - 49262;
					break;
				case 4:
					comparable = cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴐ()
						.FormatSqlFilter((string)comparable);
					Ⴓ(cmd, comparable as string);
					return;
				case 10:
					return;
				}
			}
		}
		catch (Exception)
		{
			Ⴀ(cmd);
		}
	}

	private static void Ⴓ(NodeUserCmd P_0, string P_1)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 16;
		Array dataRow = default(Array);
		int num3 = default(int);
		int num2 = default(int);
		DateTime dateTime = default(DateTime);
		object obj4 = default(object);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		IComparable comparable = default(IComparable);
		ICloneable cloneable = default(ICloneable);
		object obj3 = default(object);
		object obj2 = default(object);
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			switch (num)
			{
			default:
				dataRow = P_0.Ⴍ().Ⴅ().Ⴀ()
					.Ⴐ()
					.GetDataRow(P_1, 25);
				num = ((((DataRow[])dataRow).Length != 0) ? 6 : (ⴃႰ[32] - 1109));
				break;
			case 13:
				P_0.Tx.Msg.Add(ReplyMail.Ⴅ(5, 9, 1217942497));
				num = ⴀ[287] - 59328;
				break;
			case 6:
			case 10:
				num3 = 0;
				num = (((dataRow as DataRow[]).Length <= 25) ? 5 : 4);
				break;
			case 4:
				num3 = ((DataRow[])dataRow).Length - 25;
				num = ⴀႨ[198] - 25771;
				break;
			case 5:
				num2 = num3;
				num = ⴃႰ[15] - 46735;
				break;
			case 21:
				dateTime = (DateTime)qslinfoSoapClient.Ⴓ((dataRow as DataRow[])[num2], ႰႥ.Ⴅ(0, '\u00a8', 952620237), 547, 'ɭ');
				num = ⴃႥ[26] - 3098;
				break;
			case 1:
				obj4 = ShowAnnOptionsHelp.Ⴗ(ref dateTime, CallBlockCacheCfg.Ⴅ(null, 2, 62061699, null), 562, 566);
				num = ⴀႼ[12] - 223;
				break;
			case 20:
				enumerable = (string)qslinfoSoapClient.Ⴓ((dataRow as DataRow[])[num2], SetTalkCount.Ⴗ(5, null, 1267022182, typeof(SetTalkDefaultHelp)), 266, 'ń');
				num = ⴄႤ[511] - 127;
				break;
			case 8:
				comparable = (string)qslinfoSoapClient.Ⴓ(((DataRow[])dataRow)[num2], ShowWxHelp.Ⴍ('Ò', 985805647, 8), 847, '\u0301');
				num = 19;
				break;
			case 19:
				cloneable = (string)qslinfoSoapClient.Ⴓ(((DataRow[])dataRow)[num2], ShowWxHelp.Ⴍ('û', 985805641, 6), 350, 'Đ');
				num = 3;
				break;
			case 3:
				obj3 = (string)qslinfoSoapClient.Ⴓ(((DataRow[])dataRow)[num2], ShowWxHelp.Ⴍ('{', 985805500, 8), 425, 'ǧ');
				num = 0;
				break;
			case 0:
				obj2 = new string[7];
				((string[])obj2)[0] = ႨႨ.Ⴀ(13, 8, 1157902558);
				num = 11;
				break;
			case 11:
				((string[])obj2)[1] = obj4 as string;
				(obj2 as string[])[2] = ShowAnnHelp.Ⴀ((string)enumerable, 11, 724, 642);
				num = 2;
				break;
			case 2:
				((string[])obj2)[3] = ShowAnnHelp.Ⴀ(comparable as string, 14, 102, 48);
				num = 18;
				break;
			case 18:
				(obj2 as string[])[4] = (string)cloneable;
				((string[])obj2)[5] = ႰႥ.Ⴅ(3, '¤', 952620209);
				num = 9;
				break;
			case 9:
			case 15:
				(obj2 as string[])[6] = obj3 as string;
				equatable = ShowWwv.Ⴈ(obj2 as string[], 'ˑ', 697);
				num = 12;
				break;
			case 12:
				P_0.Tx.Msg.Add(equatable as string);
				goto case 7;
			case 7:
				num2++;
				num = ⴃႥ[64] - 26218;
				break;
			case 14:
				num = ((num2 < ((DataRow[])dataRow).Length) ? (ⴀႳ[38] - 44433) : (ⴀႳ[233] - 50816));
				break;
			case 17:
			{
				P_0.Ⴀ();
				object obj = new Publisher();
				(obj as Publisher).Process(P_0);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly Ⴍ(short P_0, char P_1)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		_Assembly assembly = default(_Assembly);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[140] - 30856;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
					break;
				case 6:
					num2 = (((P_1 ^ P_0) - 8) ^ num) switch
					{
						0 => 7, 
						_ => 3, 
					};
					continue;
				case 3:
					assembly = null;
					num2 = 1;
					continue;
				case 7:
					assembly = Assembly.GetExecutingAssembly();
					num2 = 1;
					continue;
				case 1:
					num++;
					goto case 8;
				case 8:
					num3 = 58;
					num4 = 113;
					goto case 5;
				case 5:
				{
					int num5 = num4 - num3 * 10;
					Arc4ServerClient.ႠႣ[377] = (char)(Arc4ServerClient.ႠႣ[377] & P_0 & 0x2A);
					num2 = ((1130 > num5) ? 10 : 11);
					continue;
				}
				case 11:
					num2 = ⴃႥ[83] - 54506;
					continue;
				case 9:
				case 10:
					return (Assembly)assembly;
				case 2:
					num2 = ⴃႰ[114] - 38478;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string where _0021_00211 : AnnWxSpot
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 1;
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
				num = (((P_3 ^ P_2) - 12) ^ num2) switch
				{
					0 => ⴍႭ[139] - 7123, 
					1 => ⴐ[254], 
					2 => ⴍႤ[474] - 65087, 
					3 => ⴅ[92], 
					_ => 9, 
				};
				continue;
			case 9:
				num = 5;
				continue;
			case 8:
				P_0.Spotter = P_1;
				num = 5;
				continue;
			case 0:
				P_0.SpotterState = P_1;
				num = 5;
				continue;
			case 6:
				P_0.DupeKey = P_1;
				num = ⴄႭ[507] - 78;
				continue;
			case 11:
				P_0.DeserializeClientSpot(P_1);
				break;
			case 2:
			case 5:
			case 10:
				break;
			case 4:
			case 7:
				return;
			}
			num2++;
			int num3 = 1182;
			int num4 = 60;
			num = ((394 < num3 / 3 - num4) ? 3 : (ⴀႣ[128] - 26880));
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : AnnWxSpot where _0021_00211 : string
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 6;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴀ[451] - 7738;
				break;
			case 0:
				num = (((P_3 ^ P_2) - 76) ^ num3) switch
				{
					0 => 8, 
					_ => 3, 
				};
				break;
			case 1:
			case 3:
				num = ⴍႭ[101] - 40614;
				break;
			case 8:
				P_0.SpotterCty = P_1;
				goto case 2;
			case 2:
			case 5:
			case 9:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 4;
				break;
			case 4:
				num = ((num2 % 2 != 0) ? (ⴀႳ[227] - 26073) : 7);
				break;
			case 7:
				SetAnnChatRooms.Ⴀ[110] = (char)((SetAnnChatRooms.Ⴀ[110] * P_3) & 0x10);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static StringBuilder Ⴅ<_0021_00210, _0021_00211, _0021_00212>(_0021_00212 P_0, _0021_00210 P_1, _0021_00211 P_2, int P_3, char P_4) where _0021_00210 : string where _0021_00211 : string where _0021_00212 : StringBuilder
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		object obj = default(object);
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
					num2 = 3;
					continue;
				case 3:
				case 9:
					break;
				case 11:
					num2 = (((P_3 ^ P_4) - 112) ^ num) switch
					{
						0 => ⴍႤ[254] - 62938, 
						_ => 7, 
					};
					continue;
				case 7:
					obj = null;
					num2 = ⴄႷ[12] - 43771;
					continue;
				case 8:
					obj = P_0.Replace(P_1, P_2);
					num2 = 2;
					continue;
				case 2:
				{
					num++;
					num3 = P_4 * P_4;
					int num4 = num3;
					BandModeCacheCfg.ႠႳ[205] = (char)((BandModeCacheCfg.ႠႳ[205] + AnnCacheCfg.ႠႼ[128]) & 0xA2);
					num3 = P_4 + num4;
					num2 = ⴀႨ[221] - 55658;
					continue;
				}
				case 4:
					num2 = ((num3 % 2 == 0) ? 1 : 11);
					continue;
				case 1:
					return (StringBuilder)obj;
				case 5:
				case 6:
					num2 = ⴀႣ[30] - 13981;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴃ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2, short P_3) where _0021_00210 : string
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int result = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႤ[479] - 63051;
					continue;
				case 3:
					break;
				case 0:
					num2 = (((P_3 ^ P_2) - 25) ^ num) switch
					{
						0 => ⴃႥ[185] - 8952, 
						_ => 11, 
					};
					continue;
				case 1:
				case 11:
					result = 3;
					num2 = 9;
					continue;
				case 2:
				case 8:
					result = P_0.LastIndexOf(P_1);
					num2 = 9;
					continue;
				case 9:
					num++;
					num3 = 350;
					num4 = 910;
					goto case 6;
				case 6:
					num2 = ((5460 > num4 - num3 * 6) ? 7 : (ⴀႣ[318] - 54973));
					continue;
				case 10:
					num2 = 0;
					continue;
				case 7:
					return result;
				case 4:
					num2 = ⴄႤ[191] - ⴄႤ[155];
					continue;
				}
				break;
			}
		}
	}
}
