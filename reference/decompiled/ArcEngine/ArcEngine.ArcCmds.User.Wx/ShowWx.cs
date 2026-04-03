using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Security;
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
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class ShowWx : IArcCmd
{
	private enum ႨႤ
	{

	}

	internal sealed class Ⴀ
	{
		internal string Ⴈ;

		internal string Ⴓ;

		internal Ⴀ()
		{
		}
	}

	private static void Ⴗ(NodeUserCmd P_0)
	{
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 3:
			case 4:
				obj = new ShowWxHelp();
				break;
			case 0:
				break;
			case 2:
				return;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(1, 4, 1157898276), P_0.Rx.Msg, 550, 616));
			num = 3;
		}
		(obj as ShowWxHelp).Exec(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		try
		{
			int num = 6;
			ႨႤ ⴈႤ = default(ႨႤ);
			int num2 = default(int);
			IEnumerable enumerable = default(IEnumerable);
			Array array = default(Array);
			while (true)
			{
				switch (num)
				{
				default:
					ⴈႤ = (ႨႤ)0;
					cmd.Tx.DistroType = DistroType.ToRequester;
					num2 = ShowNodesHelp.Ⴍ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 26, 51), 757, 'ˊ');
					num = ⴄႭ[73] / 3;
					continue;
				case 13:
				case 14:
					enumerable = string.Empty;
					num = ((cmd.Rx.Split.Length < 3) ? (ⴃႠ[314] - ⴃႠ[314]) : (ⴄႭ[475] / 4));
					continue;
				case 15:
					enumerable = cmd.Rx.GetMsgEnd(2);
					num = 0;
					continue;
				case 0:
					num = ((CallBlockCacheCfg.Ⴜ((string)enumerable, 643, 738) <= 0) ? (ⴀႣ[300] - 62487) : (ⴃႠ[367] - 63075));
					continue;
				case 1:
				case 8:
				{
					string obj2 = enumerable as string;
					object obj3 = new char[1];
					((char[])obj3)[0] = ' ';
					array = Directory.Ⴓ(obj2, obj3 as char[], 575, 617);
					num = ⴄႷ[141] - 32619;
					continue;
				}
				case 11:
					num = ((((string[])array).Length <= 0) ? 5 : 4);
					continue;
				case 4:
					num = ((!SkimmerValidSpot.Ⴈ(((string[])array)[0], 135, 243)) ? 5 : (ⴀ[464] - 29727));
					continue;
				case 2:
					num2 = ShowVersion.Ⴄ(((string[])array)[0], 'ǘ', 'Ǫ');
					enumerable = ShowContestStationHelp.Ⴅ(enumerable as string, ((string[])array)[0], string.Empty, 613, 'Ƚ');
					num = ⴄႭ[613] - 14;
					continue;
				case 5:
					num = ((ShowNodes.Ⴄ((string)enumerable, ႰႥ.Ⴅ(8, ' ', 952620234), 321, 382) <= -1) ? 10 : 9);
					continue;
				case 9:
					ⴈႤ = (ႨႤ)1;
					enumerable = ShowContestStationHelp.Ⴅ((string)enumerable, ႰႥ.Ⴅ(1, 'a', 952620227), string.Empty, 900, 'Ϝ');
					num = 10;
					continue;
				case 10:
				case 12:
					enumerable = cmd.Ⴍ().Ⴅ().Ⴀ()
						.Ⴄ()
						.FormatSqlFilter(enumerable as string);
					Ⴐ(cmd, (string)enumerable, num2, ⴈႤ);
					num = 7;
					continue;
				case 7:
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
			Ⴗ(cmd);
		}
		switch (4)
		{
		}
	}

	private static void Ⴐ(NodeUserCmd P_0, string P_1, int P_2, ႨႤ P_3)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 13;
		int num4 = default(int);
		IConvertible convertible = default(IConvertible);
		ISupportInitialize dataTable = default(ISupportInitialize);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				goto case 12;
			case 12:
				num = ((!ByeHelp.Ⴍ(P_1, ReplyMailHelp.Ⴄ(10, null, 1057162118, 0), 168, 207)) ? 14 : (ⴄႤ[47] / 4));
				break;
			case 3:
				convertible = SetDxFilter.Ⴀ(ShowContestStationHelp.Ⴅ(P_1, ReplyMailHelp.Ⴄ(28, null, 1057162113, 7), string.Empty, 32, 'x'), 668, '\u02dc');
				num = 5;
				break;
			case 2:
			case 14:
				num = ((CallBlockCacheCfg.Ⴜ(PcxxCfg.Ⴃ(SetStationEmailHelp.Ⴈ(P_0.Ⴍ().Cfg, 134, 178), '¾', '¦'), 387, 482) <= 0) ? 8 : 10);
				break;
			case 10:
				num = ((CallBlockCacheCfg.Ⴜ(P_1, 876, 781) <= 0) ? 8 : (ⴃႰ[50] - 2572));
				break;
			case 0:
				convertible = qslinfoResponse.Ⴗ(SetStationClubHelp.Ⴍ(P_2, 5, 1747258349, null), PcxxCfg.Ⴃ(SetStationEmailHelp.Ⴈ(P_0.Ⴍ().Cfg, 622, 602), '\u02d3', 'ˋ'), ReplyMailHelp.Ⴄ(3, null, 1057161344, 7), P_1, 521, 'ɪ');
				num = 5;
				break;
			case 8:
				num = ((CallBlockCacheCfg.Ⴜ(P_1, 514, 611) <= 0) ? 6 : 11);
				break;
			case 11:
				convertible = P_1;
				num = 5;
				break;
			case 6:
				convertible = PcxxCfg.Ⴃ(SetStationEmailHelp.Ⴈ(P_0.Ⴍ().Cfg, 540, 552), 'Ȟ', 'Ȇ');
				num = 5;
				break;
			case 5:
				dataTable = P_0.Ⴍ().Ⴅ().Ⴀ()
					.Ⴈ()
					.GetDataTable(convertible as string, P_2);
				goto case 1;
			case 1:
				num = ⴃႥ[216] - 63042;
				break;
			case 9:
				num = ((!(dataTable is DataTable)) ? 7 : 4);
				break;
			case 4:
				if (DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(dataTable as DataTable, 'ɹ', 633), (short)471, (short)394) == 0)
				{
					num = 7;
					break;
				}
				while (true)
				{
					int num2 = ((ShowHeading.Ⴗ((DataTable)dataTable, '[', 91).Count <= P_2) ? 2 : 3);
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 5:
						case 12:
							break;
						case 3:
							num4 = (dataTable as DataTable).Rows.Count - P_2;
							num2 = ⴐ[54] - 122;
							continue;
						case 2:
							num3 = num4;
							num2 = ⴄႷ[60] - 11688;
							continue;
						case 4:
						case 6:
							num2 = P_3 switch
							{
								(ႨႤ)0 => ⴄႷ[48] - 38959, 
								(ႨႤ)1 => ⴀႣ[30] - 13992, 
								_ => 11, 
							};
							continue;
						case 11:
							num2 = 13;
							continue;
						case 8:
							P_0.Tx.Msg.Add(Ⴍ(((DataTable)dataTable).Rows[num3]));
							num2 = ⴃႰ[198] - 3689;
							continue;
						case 0:
							P_0.Tx.Msg.Add(Ⴈ((dataTable as DataTable).Rows[num3]));
							goto case 13;
						case 13:
							num3++;
							num2 = ⴄႭ[525] - 137;
							continue;
						case 10:
							num2 = ((num3 < (dataTable as DataTable).Rows.Count) ? 4 : (ⴍႭ[159] - 34484));
							continue;
						case 1:
						case 7:
							return;
						}
						break;
					}
				}
			case 7:
				P_0.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687354977, 4, 15));
				return;
			}
		}
	}

	private static string Ⴍ(DataRow P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		object obj = default(object);
		Array array = default(Array);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			DateTime dateTime = (DateTime)qslinfoSoapClient.Ⴓ(P_0, ႰႥ.Ⴅ(8, '[', 952620229), 288, 'Ů');
			int num = 0;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႨ[46] - 49124;
					continue;
				case 9:
					break;
				case 0:
					enumerable = ShowPrefixCalls.Ⴃ((object)ShowAnnOptionsHelp.Ⴗ(ref dateTime, ShowWxHelp.Ⴍ('R', 985808352, 1), 982, 978), (object)ShowWxHelp.Ⴍ('\u00a8', 985808343, 5), qslinfoSoapClient.Ⴓ(P_0, ReplyMailHelp.Ⴄ(29, null, 1057162074, 8), 319, 'ű'), '\u0016', 60);
					num = 1;
					continue;
				case 1:
				case 4:
					obj = enumerable as string;
					array = new object[4];
					goto case 3;
				case 3:
					(array as object[])[0] = obj;
					num = 5;
					continue;
				case 5:
					(array as object[])[1] = SetStationClubHelp.Ⴍ(15, 4, 1747258345, null);
					num = 7;
					continue;
				case 6:
				case 7:
					(array as object[])[2] = qslinfoSoapClient.Ⴓ(P_0, SetStationClubHelp.Ⴍ(11, 1, 1747258270, null), 688, '\u02fe');
					num = 2;
					continue;
				case 2:
					(array as object[])[3] = SetTalkCount.Ⴗ(4, null, 1267022535, typeof(ႰႥ));
					num = ⴀႼ[47] - 146;
					continue;
				case 10:
					enumerable = string.Concat((object[])array);
					return (string)enumerable;
				}
				break;
			}
		}
	}

	private static string Ⴈ(DataRow P_0)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		IComparable comparable = default(IComparable);
		while (true)
		{
			DateTime dateTime = (DateTime)qslinfoSoapClient.Ⴓ(P_0, ႰႥ.Ⴅ(1, 'ù', 952620236), 50, '|');
			int num = ⴀႳ[348] - 48483;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
					break;
				case 7:
					comparable = ShowAnnOptionsHelp.Ⴗ(ref dateTime, SetTalkCount.Ⴗ(6, null, 1267022663, typeof(SetAnnChatRoomsHelp)), 82, 86);
					num = 8;
					continue;
				case 8:
					comparable = ShowPrefixCalls.Ⴃ((object)(comparable as string), (object)ReplyMailHelp.Ⴄ(29, null, 1057162081, 5), qslinfoSoapClient.Ⴓ(P_0, ReplyMailHelp.Ⴄ(27, null, 1057162066, 0), 455, 'Ɖ'), 'ǖ', 508);
					goto case 2;
				case 2:
					num = 6;
					continue;
				case 3:
				case 6:
					comparable = (comparable as string) + ReplyMail.Ⴅ(8, 3, 1217944627) + UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(P_0, ShowSkimCtyHelp.Ⴍ(1216133148, 8, '¡'), 228, 'ª'), '\u0001', 106).Replace(SetStationClubHelp.Ⴍ(12, 8, 1747257869, null), ShowSkimCtyHelp.Ⴍ(1216133147, 7, '\u0016'));
					num = ⴍႤ[345] - 45607;
					continue;
				case 5:
					return comparable as string;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, DateTime P_1, int P_2, int P_3) where _0021_00210 : DxSpot
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 1;
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = 5;
				break;
			case 5:
				num = (((P_3 ^ P_2) - 52) ^ num4) switch
				{
					0 => 3, 
					_ => 9, 
				};
				break;
			case 9:
				num = ⴍႤ[217] - 2331;
				break;
			case 3:
				P_0.Dts = P_1;
				goto case 2;
			case 2:
			case 6:
			{
				num4++;
				num3 = 339;
				int num5 = num3;
				num2 = num5 * num5;
				num = 7;
				break;
			}
			case 7:
			case 8:
				num2 = num3 + num2;
				num = ((num2 % 2 != 0) ? (ⴀႣ[300] - 62487) : 4);
				break;
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static OleDbConnection Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : OleDbTransaction
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႣ[65] - 28711;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 10:
					break;
				case 5:
					num2 = (((P_1 ^ P_2) - 112) ^ num) switch
					{
						0 => ⴅ[201] - 72, 
						_ => ⴍႤ[447] - 10157, 
					};
					continue;
				case 9:
					disposable = null;
					goto case 3;
				case 3:
					num2 = ⴍႤ[347] - 1872;
					continue;
				case 6:
					disposable = P_0.Connection;
					num2 = 2;
					continue;
				case 2:
				case 4:
				{
					num++;
					int num3 = 1794;
					int num4 = 335;
					num2 = ((598 < num3 / 3 - num4) ? 5 : 0);
					continue;
				}
				case 0:
				case 8:
					return (OleDbConnection)disposable;
				case 1:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}
}
