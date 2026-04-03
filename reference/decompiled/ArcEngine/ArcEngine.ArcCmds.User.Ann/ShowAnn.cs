using System;
using System.ComponentModel;
using System.Data;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
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
using ArcShared;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class ShowAnn : IArcCmd
{
	private enum ႨႰ
	{

	}

	private static void Ⴅ(NodeUserCmd P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(6, 1, 1157904354), P_0.Rx.Msg, 568, 630));
				break;
			case 1:
				break;
			case 2:
			case 4:
			{
				object obj = new ShowAnnHelp();
				(obj as ShowAnnHelp).Exec(P_0);
				ShowWwvOptionsHelp.ႣႥ[233] = (char)((ShowWwvOptionsHelp.ႣႥ[233] | SetTalkCountHelp.Ⴅ[427]) & 9);
				return;
			}
			}
			num = ⴍႭ[112] - 37919;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		try
		{
			int num = 13;
			ႨႰ ⴈႰ = default(ႨႰ);
			int num2 = default(int);
			ICloneable cloneable = default(ICloneable);
			Array array = default(Array);
			while (true)
			{
				switch (num)
				{
				default:
					ⴈႰ = (ႨႰ)0;
					cmd.Tx.DistroType = DistroType.ToRequester;
					num2 = ShowNodesHelp.Ⴍ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 81, 120), 618, 'ɕ');
					goto case 10;
				case 10:
					num = ⴀႳ[230] - 17610;
					continue;
				case 0:
					cloneable = string.Empty;
					num = ((cmd.Rx.Split.Length < 3) ? 11 : ⴐ[257]);
					continue;
				case 7:
					cloneable = cmd.Rx.GetMsgEnd(2);
					num = 11;
					continue;
				case 11:
					num = ((CallBlockCacheCfg.Ⴜ((string)cloneable, 311, 342) <= 0) ? 6 : (ⴍႭ[361] - 1993));
					continue;
				case 5:
				{
					string obj2 = (string)cloneable;
					object obj3 = new char[1];
					((char[])obj3)[0] = ' ';
					array = Directory.Ⴓ(obj2, (char[])obj3, 588, 538);
					num = ⴐ[296] - 73;
					continue;
				}
				case 2:
					num = ((((string[])array).Length <= 0) ? (ⴃႰ[163] - 18238) : 3);
					continue;
				case 3:
					num = ((!SkimmerValidSpot.Ⴈ((array as string[])[0], 41, 93)) ? 6 : (ⴃႠ[409] - 30579));
					continue;
				case 4:
					num2 = ShowVersion.Ⴄ(((string[])array)[0], 'b', 'P');
					goto case 8;
				case 8:
				case 15:
					cloneable = ShowContestStationHelp.Ⴅ(cloneable as string, (array as string[])[0], string.Empty, 648, 'ː');
					num = ⴀႣ[424] - 4364;
					continue;
				case 6:
					num = ((ShowNodes.Ⴄ((string)cloneable, ႰႥ.Ⴅ(3, '\u0097', 952620225), 992, 991) <= -1) ? 12 : (ⴀႼ[134] - 137));
					continue;
				case 14:
					ⴈႰ = (ႨႰ)1;
					cloneable = ShowContestStationHelp.Ⴅ(cloneable as string, ႰႥ.Ⴅ(5, '\u001c', 952620231), string.Empty, 165, 'ý');
					num = ⴃႰ[204] - 24647;
					continue;
				case 12:
					cloneable = cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴄ()
						.FormatSqlFilter(cloneable as string);
					Ⴍ(cmd, (string)cloneable, num2, ⴈႰ);
					num = ⴀႳ[24] - 25570;
					continue;
				case 1:
				{
					cmd.Ⴀ();
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					break;
				}
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴅ(cmd);
		}
		switch (0)
		{
		}
	}

	private static void Ⴍ(NodeUserCmd P_0, string P_1, int P_2, ႨႰ P_3)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 11;
		int num4 = default(int);
		object obj = default(object);
		ISupportInitializeNotification dataTable = default(ISupportInitializeNotification);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = ((!ByeHelp.Ⴍ(P_1, ReplyMailHelp.Ⴄ(10, null, 1057162118, 0), 991, 952)) ? (ⴀႣ[3] - 62775) : (ⴀႳ[344] - 9705));
				break;
			case 10:
				obj = SetDxFilter.Ⴀ(ShowContestStationHelp.Ⴅ(P_1, ReplyMailHelp.Ⴄ(5, null, 1057162119, 1), string.Empty, 722, 'ʊ'), 520, 'Ɉ');
				num = ⴀ[517] - 55872;
				break;
			case 9:
			case 14:
				num = ((CallBlockCacheCfg.Ⴜ(SunCalculations.Ⴃ(TalkHelp.Ⴃ(P_0.Ⴍ().Cfg, 737, 712), 391, 462), 1005, 908) > 0) ? 1 : 4);
				break;
			case 1:
				num = ((CallBlockCacheCfg.Ⴜ(P_1, 900, 997) <= 0) ? 4 : ⴐ[204]);
				break;
			case 6:
				obj = qslinfoResponse.Ⴗ(SetStationClubHelp.Ⴍ(8, 3, 1747258347, null), SunCalculations.Ⴃ(TalkHelp.Ⴃ(P_0.Ⴍ().Cfg, 7, 46), 295, 366), ReplyMailHelp.Ⴄ(26, null, 1057161348, 3), P_1, 644, '\u02e7');
				num = 5;
				break;
			case 4:
				num = ((CallBlockCacheCfg.Ⴜ(P_1, 328, 297) > 0) ? (ⴄႭ[134] / 4) : 0);
				break;
			case 2:
				obj = P_1;
				num = ⴃႥ[384] - 50481;
				break;
			case 0:
				obj = SunCalculations.Ⴃ(TalkHelp.Ⴃ(P_0.Ⴍ().Cfg, 44, 5), 770, 843);
				num = 5;
				break;
			case 5:
				dataTable = P_0.Ⴍ().Ⴅ().Ⴀ()
					.Ⴄ()
					.GetDataTable(obj as string, P_2);
				goto case 12;
			case 12:
				num = ⴀႳ[106] - 34483;
				break;
			case 8:
				num = ((!(dataTable is DataTable)) ? 13 : (ⴀ[389] - 31302));
				break;
			case 3:
				if (DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(dataTable as DataTable, 'ˀ', 704), (short)304, (short)365) == 0)
				{
					num = 13;
					break;
				}
				while (true)
				{
					int num2 = ((ShowHeading.Ⴗ((DataTable)dataTable, 'o', 111).Count <= P_2) ? 11 : (ⴃႰ[135] - 57444));
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 0:
							break;
						case 4:
						case 10:
							num4 = ((DataTable)dataTable).Rows.Count - P_2;
							num2 = 11;
							continue;
						case 11:
							num3 = num4;
							num2 = ⴀႨ[148] - 33949;
							continue;
						case 13:
							num2 = P_3 switch
							{
								(ႨႰ)0 => 9, 
								(ႨႰ)1 => 12, 
								_ => ⴍႭ[356] - 15179, 
							};
							continue;
						case 2:
						case 3:
							num2 = ⴃႥ[15] - 9485;
							continue;
						case 5:
						case 9:
							P_0.Tx.Msg.Add(Ⴓ(((DataTable)dataTable).Rows[num3]));
							num2 = 1;
							continue;
						case 12:
							P_0.Tx.Msg.Add(Ⴍ(((DataTable)dataTable).Rows[num3]));
							goto case 1;
						case 1:
							num3++;
							num2 = 6;
							continue;
						case 6:
							num2 = ((num3 < (dataTable as DataTable).Rows.Count) ? (ⴄႭ[137] - 226) : 8);
							continue;
						case 8:
							return;
						}
						break;
					}
				}
			case 7:
			case 13:
				P_0.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687352118, 7, 19));
				return;
			}
		}
	}

	private static string Ⴓ(DataRow P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		Array array = default(Array);
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			DateTime dateTime = (DateTime)qslinfoSoapClient.Ⴓ(P_0, ႰႥ.Ⴅ(1, 'ª', 952620236), 704, 'ʎ');
			while (true)
			{
				IL_006d:
				int num = ⴐ[243];
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 3;
						continue;
					case 3:
						break;
					case 7:
						goto IL_006d;
					case 1:
					case 8:
						equatable = ShowPrefixCalls.Ⴃ((object)ShowAnnOptionsHelp.Ⴗ(ref dateTime, ShowWxHelp.Ⴍ('×', 985808359, 6), 240, 244), (object)ShowWxHelp.Ⴍ('\u0097', 985808346, 8), qslinfoSoapClient.Ⴓ(P_0, ReplyMailHelp.Ⴄ(0, null, 1057162065, 3), 623, 'ȡ'), 'ŭ', 327);
						num = 2;
						continue;
					case 2:
					{
						object obj = (string)equatable;
						array = new object[4];
						(array as object[])[0] = obj;
						num = 6;
						continue;
					}
					case 4:
					case 6:
						((object[])array)[1] = SetStationClubHelp.Ⴍ(8, 2, 1747258351, null);
						num = 5;
						continue;
					case 5:
						(array as object[])[2] = qslinfoSoapClient.Ⴓ(P_0, SetStationClubHelp.Ⴍ(4, 8, 1747258263, null), 456, 'Ɔ');
						num = 9;
						continue;
					case 9:
						((object[])array)[3] = SetTalkCount.Ⴗ(5, null, 1267022534, typeof(ShowSkimmer.ႥႨ));
						num = ⴐ[384] - 146;
						continue;
					case 10:
						equatable = string.Concat((object[])array);
						return equatable as string;
					}
					break;
				}
				break;
			}
		}
	}

	private static string Ⴍ(DataRow P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			DateTime dateTime = (DateTime)qslinfoSoapClient.Ⴓ(P_0, ႰႥ.Ⴅ(1, '\u0004', 952620236), 194, '\u008c');
			while (true)
			{
				IL_007a:
				int num = 8;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႠ[192] - 23549;
						continue;
					case 5:
						break;
					case 1:
						goto IL_007a;
					case 8:
						cloneable = ShowAnnOptionsHelp.Ⴗ(ref dateTime, SetTalkCount.Ⴗ(7, null, 1267022662, typeof(SetStationLoginCmdsHelp)), 706, 710);
						num = 7;
						continue;
					case 7:
						cloneable = ShowPrefixCalls.Ⴃ((object)(cloneable as string), (object)ReplyMailHelp.Ⴄ(1, null, 1057162085, 1), qslinfoSoapClient.Ⴓ(P_0, ReplyMailHelp.Ⴄ(17, null, 1057162064, 2), 148, 'Ú'), 'Ʌ', 623);
						goto case 6;
					case 6:
						num = ⴍႭ[356] - 15179;
						continue;
					case 3:
						cloneable = (string)cloneable + ReplyMail.Ⴅ(0, 6, 1217944635) + UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(P_0, ShowSkimCtyHelp.Ⴍ(1216133136, 4, 'Å'), 35, 'm'), '0', 91).Replace(SetStationClubHelp.Ⴍ(5, 5, 1747257856, null), ShowSkimCtyHelp.Ⴍ(1216133144, 4, 'Ï'));
						goto case 0;
					case 0:
						num = ⴍႤ[0] - 24006;
						continue;
					case 2:
						return cloneable as string;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴄ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : DxSpot
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		IComparable comparable = default(IComparable);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႠ[170] - 676;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႼ[33];
					continue;
				case 9:
					break;
				case 10:
					num2 = (((P_2 ^ P_1) - 122) ^ num) switch
					{
						0 => 2, 
						1 => 7, 
						_ => 6, 
					};
					continue;
				case 6:
					comparable = null;
					num2 = 4;
					continue;
				case 2:
					comparable = P_0.Route;
					num2 = ⴐ[367];
					continue;
				case 7:
				case 8:
					comparable = P_0.SpotterCont;
					num2 = 4;
					continue;
				case 4:
				{
					num++;
					int num3 = 654;
					int num4 = 307;
					num2 = ((327 < num3 / 2 - num4) ? 10 : 5);
					continue;
				}
				case 5:
					return (string)comparable;
				case 1:
				case 3:
					num2 = ⴀႼ[6] - 62;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : CtyInfo
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		float result = default(float);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႥ[23] - ⴃႥ[23];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႥ[123] - 57508;
					continue;
				case 3:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 116) ^ num) switch
					{
						0 => ⴄႷ[139] - 44122, 
						_ => 10, 
					};
					continue;
				case 10:
					result = 0.28967065f;
					num2 = 9;
					continue;
				case 1:
				case 4:
				case 8:
					result = P_0.Latitude;
					num2 = 9;
					continue;
				case 9:
				{
					num++;
					int num3 = 351;
					int num4 = 612;
					num2 = ((1836 > num4 - num3 * 3) ? (ⴃႥ[255] - 28923) : (ⴀႨ[8] - 49084));
					continue;
				}
				case 2:
				case 5:
					num2 = ⴀႨ[64] - ⴀႨ[64];
					continue;
				case 7:
					return result;
				case 6:
					num2 = ⴀႣ[94] - 31868;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : DxSpot
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႠ[325] - 17536;
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
				case 5:
					num2 = (((P_1 ^ P_2) - 26) ^ num) switch
					{
						0 => 4, 
						_ => 7, 
					};
					continue;
				case 7:
					result = true;
					num2 = 10;
					continue;
				case 4:
					result = P_0.Top100;
					num2 = 10;
					continue;
				case 2:
				case 10:
					num++;
					num3 = 182;
					goto case 11;
				case 11:
				{
					int num4 = 906;
					num2 = ((5436 > num4 - num3 * 6) ? 6 : (ⴀ[21] - 28073));
					continue;
				}
				case 9:
					num2 = ⴀႣ[224] - 51414;
					continue;
				case 6:
				case 8:
					return result;
				case 3:
					num2 = ⴄႷ[7] - 54235;
					continue;
				}
				break;
			}
		}
	}
}
