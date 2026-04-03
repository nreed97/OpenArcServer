using System;
using System.Collections;
using System.Data;
using System.Security;
using System.Xml.Serialization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces.Io;
using ArcShared;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wwv;

public sealed class ShowWwv : IArcCmd
{
	private enum ႥႣ
	{

	}

	private static void Ⴃ(NodeUserCmd P_0)
	{
		int num = 3;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 1:
			case 4:
				obj = new ShowWwvHelp();
				break;
			case 0:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(5, 3, 1157903444), P_0.Rx.Msg, 722, 668));
			num = 1;
		}
		(obj as ShowWwvHelp).Exec(P_0);
		IpLockoutCacheCfg.ႭႭ[87] = (char)((IpLockoutCacheCfg.ႭႭ[87] | IpLockoutCacheCfg.ႭႭ[58]) & 0x6E);
	}

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		try
		{
			int num = 10;
			ႥႣ ⴅႣ = default(ႥႣ);
			int num2 = default(int);
			IEnumerable enumerable = default(IEnumerable);
			object obj2 = default(object);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					ⴅႣ = (ႥႣ)0;
					cmd.Tx.DistroType = DistroType.ToRequester;
					num2 = WwvHelp.Ⴃ(ShowHeading.Ⴅ(cmd.Ⴍ().Cfg, 432, 436), 1009, 'Δ');
					num = 3;
					continue;
				case 3:
					enumerable = string.Empty;
					num = ((cmd.Rx.Split.Length < 3) ? (ⴍႤ[245] - 17879) : 6);
					continue;
				case 6:
					enumerable = cmd.Rx.GetMsgEnd(2);
					num = ⴄႷ[61] - 8213;
					continue;
				case 8:
					num = ((CallBlockCacheCfg.Ⴜ((string)enumerable, 653, 748) <= 0) ? 5 : 14);
					continue;
				case 14:
				{
					string obj3 = (string)enumerable;
					Array array = new char[1];
					(array as char[])[0] = ' ';
					obj2 = Directory.Ⴓ(obj3, (char[])array, 648, 734);
					num = 9;
					continue;
				}
				case 9:
					num = (((obj2 as string[]).Length <= 0) ? 5 : (ⴄႤ[110] - 226));
					continue;
				case 0:
					num = ((!SkimmerValidSpot.Ⴈ(((string[])obj2)[0], 340, 288)) ? 5 : (ⴀႣ[257] - 51102));
					continue;
				case 12:
					num2 = ShowVersion.Ⴄ(((string[])obj2)[0], 'ɂ', 'ɰ');
					enumerable = ShowContestStationHelp.Ⴅ(enumerable as string, (obj2 as string[])[0], string.Empty, 921, 'ρ');
					num = ⴄႷ[16] - 11916;
					continue;
				case 5:
					num = ((ShowNodes.Ⴄ(enumerable as string, ႰႥ.Ⴅ(2, '½', 952620224), 221, 226) <= -1) ? 15 : (ⴃႰ[203] - 59432));
					continue;
				case 1:
					ⴅႣ = (ႥႣ)1;
					enumerable = ShowContestStationHelp.Ⴅ(enumerable as string, ႰႥ.Ⴅ(2, '\u00a8', 952620224), string.Empty, 649, 'ˑ');
					num = ⴃႠ[154] - 63943;
					continue;
				case 15:
					enumerable = cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴍ()
						.FormatSqlFilter(enumerable as string);
					Ⴍ(cmd, (string)enumerable, num2, ⴅႣ);
					num = ⴄႭ[94];
					continue;
				case 7:
					cmd.Ⴀ();
					goto case 11;
				case 11:
					obj = new Publisher();
					break;
				case 4:
					break;
				}
				break;
			}
			((Publisher)obj).Process(cmd);
		}
		catch (Exception)
		{
			Ⴃ(cmd);
		}
		switch (3)
		{
		}
	}

	private static void Ⴍ(NodeUserCmd P_0, string P_1, int P_2, ႥႣ P_3)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 1;
		int num4 = default(int);
		IXmlSerializable dataTable = default(IXmlSerializable);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				goto case 3;
			case 3:
			case 6:
				dataTable = P_0.Ⴍ().Ⴅ().Ⴀ()
					.Ⴍ()
					.GetDataTable(P_1, P_2);
				num = ⴐ[367];
				break;
			case 4:
				num = ((dataTable is DataTable) ? 5 : 0);
				break;
			case 5:
				if (DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(dataTable as DataTable, 'Ǝ', 398), (short)256, (short)349) == 0)
				{
					num = ⴄႷ[44] - ⴄႷ[44];
					break;
				}
				while (true)
				{
					int num2 = ((DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ((DataTable)dataTable, '5', 53), (short)12, (short)81) <= P_2) ? 3 : 10);
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 1:
							break;
						case 4:
						case 10:
							num4 = DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(dataTable as DataTable, 'ɕ', 597), (short)594, (short)527) - P_2;
							num2 = ⴃႠ[30] - 58865;
							continue;
						case 3:
							P_0.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687351640, 2, 12));
							num2 = 2;
							continue;
						case 0:
						case 2:
							num3 = num4;
							num2 = 11;
							continue;
						case 9:
							num2 = P_3 switch
							{
								(ႥႣ)0 => 7, 
								(ႥႣ)1 => 13, 
								_ => ⴀႣ[271] - 32452, 
							};
							continue;
						case 12:
							num2 = ⴐ[80];
							continue;
						case 6:
						case 7:
							P_0.Tx.Msg.Add(GetWwvSpot(qslinfoRequestBody.Ⴍ(ShowHeading.Ⴗ((DataTable)dataTable, 'Ɉ', 584), num3, 'U', 114)));
							num2 = ⴀႣ[323] - 12054;
							continue;
						case 13:
							P_0.Tx.Msg.Add(Ⴅ((dataTable as DataTable).Rows[num3]));
							goto case 14;
						case 14:
							num3++;
							num2 = 11;
							continue;
						case 11:
							num2 = ((num3 < (dataTable as DataTable).Rows.Count) ? 9 : (ⴀ[381] - 58144));
							continue;
						case 5:
							return;
						}
						break;
					}
				}
			case 0:
				P_0.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687351474, 1, 27));
				return;
			case 2:
				return;
			}
		}
	}

	public static string GetWwvSpot(DataRow row)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		IEquatable<string> equatable = default(IEquatable<string>);
		IConvertible convertible = default(IConvertible);
		Array array = default(Array);
		while (true)
		{
			DateTime dateTime = (DateTime)qslinfoSoapClient.Ⴓ(row, ႰႥ.Ⴅ(8, '¦', 952620229), 871, '\u0329');
			int num = 9;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 10;
					continue;
				case 10:
					break;
				case 9:
					equatable = ShowAnnOptionsHelp.Ⴗ(ref dateTime, ShowWxHelp.Ⴍ('\u00a8', 985808760, 4), 523, 527);
					num = ⴍႤ[223] - 31736;
					continue;
				case 14:
					equatable = ShowPrefixCalls.Ⴃ((object)(equatable as string), (object)ShowSkimCtyHelp.Ⴍ(1216133130, 7, 'Z'), qslinfoSoapClient.Ⴓ(row, SetStationQth.Ⴍ(null, 1687351661, 2, 21), 587, 'ȅ'), '"', 8);
					num = 5;
					continue;
				case 5:
					equatable = SetWxCountHelp.Ⴗ((object)PublishInfo.Ⴄ((string)equatable, 24, ' ', 984, 1019), qslinfoSoapClient.Ⴓ(row, CallBlockCacheCfg.Ⴅ(null, 7, 62057838, null), 309, 'Ż'), 817, (short)842);
					num = ⴀႨ[28] - 17451;
					continue;
				case 0:
				case 4:
					equatable = SetWxCountHelp.Ⴗ((object)PublishInfo.Ⴄ(equatable as string, 28, ' ', 392, 427), qslinfoSoapClient.Ⴓ(row, ReplyMailHelp.Ⴄ(12, null, 1057162202, 1), 318, 'Ű'), 234, (short)145);
					num = ⴐ[204];
					continue;
				case 6:
					convertible = UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(row, ႨႨ.Ⴀ(14, 5, 1157903480), 510, 'ư'), 'ǝ', 438);
					num = ⴄႭ[340] - 40;
					continue;
				case 15:
				{
					int num2 = CallBlockCacheCfg.Ⴜ(convertible as string, 151, 246);
					BandModeCacheCfg.ႠႳ[248] = (char)((BandModeCacheCfg.ႠႳ[248] * BandModeCacheCfg.ႠႳ[214]) & 0x86);
					num = ((num2 <= 38) ? 12 : 13);
					continue;
				}
				case 13:
					convertible = SetTalkOutputHelp.Ⴍ((string)convertible, 0, 38, 1019, 936);
					num = 12;
					continue;
				case 12:
					equatable = PublishInfo.Ⴄ(equatable as string, 32, ' ', 125, 94) + (string)convertible;
					num = 2;
					continue;
				case 2:
					array = new object[4];
					(array as object[])[0] = (equatable as string).PadRight(69, ' ');
					num = 16;
					continue;
				case 16:
					((object[])array)[1] = ႰႥ.Ⴅ(8, 'ð', 952620039);
					(array as object[])[2] = row[ReplyMailHelp.Ⴄ(22, null, 1057162070, 4)];
					goto case 8;
				case 8:
					num = 3;
					continue;
				case 3:
					(array as object[])[3] = ReplyMail.Ⴅ(0, 14, 1217944639);
					goto case 11;
				case 11:
					equatable = string.Concat((object[])array);
					num = 1;
					continue;
				case 1:
					return (string)equatable;
				}
				break;
			}
		}
	}

	private static string Ⴅ(DataRow P_0)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			DateTime dateTime = (DateTime)qslinfoSoapClient.Ⴓ(P_0, ႰႥ.Ⴅ(0, '\u0097', 952620237), 469, 'ƛ');
			while (true)
			{
				IL_006a:
				int num = 5;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 7;
						continue;
					case 7:
						break;
					case 2:
						goto IL_006a;
					case 5:
						equatable = ShowAnnOptionsHelp.Ⴗ(ref dateTime, SetTalkCount.Ⴗ(8, null, 1267022665, typeof(UserCacheCfg)), 255, 251);
						num = ⴀႳ[119] - 55420;
						continue;
					case 6:
						equatable = ShowPrefixCalls.Ⴃ((object)(string)equatable, (object)ReplyMailHelp.Ⴄ(0, null, 1057162092, 8), qslinfoSoapClient.Ⴓ(P_0, ReplyMailHelp.Ⴄ(23, null, 1057162070, 4), 422, 'Ǩ'), 'Ȉ', 546);
						num = 4;
						continue;
					case 0:
					case 4:
						equatable = (equatable as string) + ReplyMail.Ⴅ(2, 12, 1217944633) + UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(P_0, ShowSkimCtyHelp.Ⴍ(1216133141, 1, 'Ù'), 323, 'č'), '²', 217).Replace(SetStationClubHelp.Ⴍ(5, 3, 1747257862, null), ShowSkimCtyHelp.Ⴍ(1216133147, 7, '\u001f'));
						num = ⴀႣ[228] - 55256;
						continue;
					case 3:
					case 8:
						return (string)equatable;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DxModeType Ⴗ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DxCfg
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		DxModeType result = default(DxModeType);
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
					num2 = ⴀႼ[80] / 2;
					continue;
				case 0:
					break;
				case 8:
				case 10:
					num2 = (((P_1 ^ P_2) - 23) ^ num) switch
					{
						0 => 1, 
						_ => 2, 
					};
					continue;
				case 2:
					result = DxModeType.Open;
					num2 = ⴀႣ[48] - 51178;
					continue;
				case 1:
					result = P_0.Mode;
					num2 = 4;
					continue;
				case 4:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴃႠ[314] - 64652) : (ⴃႥ[312] - 23144));
					continue;
				case 6:
				case 11:
					num2 = 8;
					continue;
				case 7:
					return result;
				case 3:
				case 9:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ(string[] P_0, char P_1, int P_2)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		IEnumerable enumerable = default(IEnumerable);
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
					num2 = 1;
					continue;
				case 1:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 104) ^ num) switch
					{
						0 => ⴍႭ[157] - 60997, 
						_ => 3, 
					};
					continue;
				case 3:
					enumerable = null;
					goto case 8;
				case 8:
					num2 = 5;
					continue;
				case 7:
					enumerable = string.Concat(P_0);
					num2 = 5;
					continue;
				case 5:
					num++;
					num3 = 2586;
					goto case 0;
				case 0:
					num4 = 47;
					goto case 2;
				case 2:
					num2 = ((862 < num3 / 3 - num4) ? (ⴀႨ[217] - 34473) : 9);
					continue;
				case 9:
					return enumerable as string;
				case 4:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴐ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : Hashtable
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		object result = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[180] - 191;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
					break;
				case 2:
					num2 = (((P_3 ^ P_2) - 101) ^ num) switch
					{
						0 => 1, 
						_ => ⴍႭ[103] - 29777, 
					};
					continue;
				case 5:
				case 6:
				{
					result = null;
					int num5 = ⴀႨ[70];
					ShowWwvOptionsHelp.ႣႥ[365] = (char)((ShowWwvOptionsHelp.ႣႥ[365] * ShowWwvOptionsHelp.ႣႥ[155]) & 0xAF);
					num2 = num5 - 57250;
					continue;
				}
				case 1:
					result = P_0[P_1];
					num2 = 0;
					continue;
				case 0:
				case 8:
					num++;
					num3 = 840;
					goto case 9;
				case 9:
				{
					int num4 = 249;
					num2 = ((280 < num3 / 3 - num4) ? 2 : 7);
					continue;
				}
				case 7:
					return result;
				case 4:
					num2 = ⴀႳ[310] - 28731;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, ServerIoType P_1, char P_2, short P_3) where _0021_00210 : ServerIoCfg
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 8;
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
				num = (((P_2 ^ P_3) - 45) ^ num2) switch
				{
					0 => 0, 
					_ => 4, 
				};
				continue;
			case 4:
				num = ⴃႠ[62] - 44666;
				continue;
			case 0:
				P_0.Type = P_1;
				break;
			case 1:
			case 6:
				break;
			case 5:
			case 7:
				return;
			}
			num2++;
			int num3 = 2598;
			int num4 = 273;
			num = ((866 < num3 / 3 - num4) ? 3 : 5);
		}
	}
}
