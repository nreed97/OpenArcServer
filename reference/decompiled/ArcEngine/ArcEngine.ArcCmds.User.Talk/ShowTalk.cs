using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.NodeProcessor;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Talk;

public sealed class ShowTalk : IArcCmd
{
	private enum ႥႠ
	{

	}

	private static void Ⴅ(NodeUserCmd P_0)
	{
		P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(4, 7, 1157903440), P_0.Rx.Msg, 671, 721));
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		try
		{
			int num = 1;
			ႥႠ ⴅႠ = default(ႥႠ);
			int num2 = default(int);
			IConvertible convertible = default(IConvertible);
			object obj2 = default(object);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					ⴅႠ = (ႥႠ)0;
					num2 = ShowDateTime.Ⴀ(NodeCmdCfg.Ⴗ(cmd.Ⴍ().Cfg, 614, 556), 'Ú', '\u0095');
					num = 0;
					continue;
				case 0:
					convertible = AnnHelp.Ⴈ(ReplyMailHelp.Ⴄ(12, null, 1057162924, 2), cmd.Ⴍ().Ⴀ(), ႰႥ.Ⴅ(0, 'P', 952620480), 959, 'Έ');
					num = 15;
					continue;
				case 15:
				{
					int num3 = cmd.Rx.Split.Length;
					SetWxOutput.ႣႰ[134] = (char)((SetWxOutput.ႣႰ[134] | ShowQrzHelp.ႤႤ[465]) & 0x6D);
					num = ((num3 < 3) ? 10 : ⴄႭ[246]);
					continue;
				}
				case 2:
					convertible = AnnHelp.Ⴈ(cmd.Rx.GetMsgEnd(2), SetStationQth.Ⴍ(null, 1687352478, 5, 7), (string)convertible, 23, ' ');
					num = 10;
					continue;
				case 10:
					num = ((CallBlockCacheCfg.Ⴜ((string)convertible, 255, 158) <= 0) ? 8 : 14);
					continue;
				case 14:
				{
					string obj3 = convertible as string;
					object obj4 = new char[1];
					(obj4 as char[])[0] = ' ';
					obj2 = Directory.Ⴓ(obj3, (char[])obj4, 485, 435);
					num = 12;
					continue;
				}
				case 12:
					num = ((((string[])obj2).Length <= 0) ? (ⴀႳ[55] - 32492) : 11);
					continue;
				case 11:
					num = ((!SkimmerValidSpot.Ⴈ(((string[])obj2)[0], 778, 894)) ? (ⴀႣ[275] - 22525) : 4);
					continue;
				case 4:
				case 6:
					num2 = ShowVersion.Ⴄ((obj2 as string[])[0], 'Ǒ', 'ǣ');
					goto case 7;
				case 7:
					convertible = ShowContestStationHelp.Ⴅ((string)convertible, ((string[])obj2)[0], string.Empty, 524, 'ɔ');
					num = 8;
					continue;
				case 8:
					num = ((ShowNodes.Ⴄ((string)convertible, ႰႥ.Ⴅ(2, '\u0019', 952620224), 566, 521) <= -1) ? (ⴐ[98] - ⴐ[105]) : 5);
					continue;
				case 5:
					ⴅႠ = (ႥႠ)1;
					convertible = (convertible as string).Replace(ႰႥ.Ⴅ(0, '\u007f', 952620226), string.Empty);
					num = 13;
					continue;
				case 13:
					Ⴃ(cmd, convertible as string, num2, ⴅႠ);
					cmd.Ⴀ();
					obj = new Publisher();
					goto case 3;
				case 3:
					num = 16;
					continue;
				case 16:
					((Publisher)obj).Process(cmd);
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴅ(cmd);
		}
		switch (1)
		{
		}
	}

	private static void Ⴃ(NodeUserCmd P_0, string P_1, int P_2, ႥႠ P_3)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 1;
		int num4 = default(int);
		object dataRow = default(object);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				goto case 0;
			case 0:
				dataRow = P_0.Ⴍ().Ⴅ().Ⴀ()
					.Ⴅ()
					.GetDataRow(P_1, P_2);
				num = 2;
				break;
			case 2:
				num = ((!(dataRow is DataRow[])) ? (ⴄႤ[280] - 177) : 3);
				break;
			case 3:
			case 6:
				if (((DataRow[])dataRow).Length == 0)
				{
					num = ⴃႥ[326] - 9871;
					break;
				}
				while (true)
				{
					int num2 = ((((DataRow[])dataRow).Length <= P_2) ? 1 : 4);
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 8:
							return;
						case 13:
							break;
						case 4:
						{
							int num5 = ((DataRow[])dataRow).Length;
							AnnCacheCfg.ႠႼ[41] = (byte)((AnnCacheCfg.ႠႼ[41] - P_2) & 0xC9);
							num4 = num5 - P_2;
							num2 = 1;
							continue;
						}
						case 1:
							num3 = num4;
							num2 = ⴐ[166] - 205;
							continue;
						case 2:
							num2 = P_3 switch
							{
								(ႥႠ)0 => 10, 
								(ႥႠ)1 => ⴀႨ[201] - 17322, 
								_ => 3, 
							};
							continue;
						case 3:
							num2 = ⴍႤ[449] - 32160;
							continue;
						case 6:
						case 10:
							P_0.Tx.Msg.Add(Ⴃ((dataRow as DataRow[])[num3]));
							goto case 9;
						case 9:
							num2 = 7;
							continue;
						case 5:
							P_0.Tx.Msg.Add(Ⴍ(((DataRow[])dataRow)[num3]));
							goto case 7;
						case 7:
							num3++;
							num2 = 11;
							continue;
						case 11:
							num2 = ((num3 < ((DataRow[])dataRow).Length) ? 2 : 0);
							continue;
						case 0:
							return;
						}
						break;
					}
				}
			case 4:
				P_0.Tx.Msg.Add(ShowWxHelp.Ⴍ('\u000e', 985807875, 6));
				return;
			}
		}
	}

	private static string Ⴃ(DataRow P_0)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			DateTime dateTime = (DateTime)qslinfoSoapClient.Ⴓ(P_0, ႰႥ.Ⴅ(3, '|', 952620238), 794, '\u0354');
			while (true)
			{
				IL_0060:
				int num = 1;
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
					case 2:
					case 4:
						goto IL_0060;
					case 1:
						enumerable = ShowAnnOptionsHelp.Ⴗ(ref dateTime, ShowWxHelp.Ⴍ('#', 985808352, 1), 6, 2);
						num = 5;
						continue;
					case 0:
					case 5:
						enumerable = SetWxCountHelp.Ⴗ((object)PublishInfo.Ⴄ(enumerable as string, 13, ' ', 42, 9), qslinfoSoapClient.Ⴓ(P_0, ReplyMailHelp.Ⴄ(10, null, 1057162067, 1), 594, 'Ȝ'), 405, (short)494);
						num = ⴀႳ[291] - 40776;
						continue;
					case 8:
						enumerable = (enumerable as string).PadRight(25, ' ') + P_0[SetStationClubHelp.Ⴍ(12, 1, 1747258270, null)];
						num = 6;
						continue;
					case 6:
						return enumerable as string;
					}
					break;
				}
				break;
			}
		}
	}

	private static string Ⴍ(DataRow P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		IComparable comparable = default(IComparable);
		while (true)
		{
			DateTime dateTime = (DateTime)qslinfoSoapClient.Ⴓ(P_0, ႰႥ.Ⴅ(4, 'p', 952620233), 5, 'K');
			while (true)
			{
				IL_0060:
				int num = ⴅ[435] - 24;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 2;
						continue;
					case 2:
						break;
					case 1:
						goto IL_0060;
					case 3:
						comparable = ShowAnnOptionsHelp.Ⴗ(ref dateTime, SetTalkCount.Ⴗ(7, null, 1267022662, typeof(ShowSun)), 383, 379);
						num = ⴄႷ[90] - 34333;
						continue;
					case 0:
					case 4:
						comparable = ShowPrefixCalls.Ⴃ((object)(string)comparable, (object)ReplyMailHelp.Ⴄ(18, null, 1057162087, 3), qslinfoSoapClient.Ⴓ(P_0, ReplyMailHelp.Ⴄ(25, null, 1057162074, 8), 535, 'ə'), 'ŭ', 327);
						num = 7;
						continue;
					case 7:
						comparable = (comparable as string) + ReplyMail.Ⴅ(3, 9, 1217944632) + UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(P_0, ShowSkimCtyHelp.Ⴍ(1216133148, 8, ','), 103, ')'), '\u03a2', 969).Replace(SetStationClubHelp.Ⴍ(5, 2, 1747257863, null), ShowSkimCtyHelp.Ⴍ(1216133144, 4, '\u009c'));
						num = 6;
						continue;
					case 5:
					case 6:
						return comparable as string;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴀ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, char P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႰ[112] - 2876;
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
				case 3:
					num2 = (((P_2 ^ P_3) - 97) ^ num) switch
					{
						0 => 4, 
						_ => ⴐ[341] - 65, 
					};
					continue;
				case 5:
					result = false;
					num2 = ⴍႤ[401] - 53836;
					continue;
				case 4:
					result = P_0.Contains(P_1);
					num2 = ⴀႣ[166] - 45405;
					continue;
				case 6:
				case 7:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴃႠ[39] - 15400) : (ⴐ[356] - 226));
					continue;
				case 1:
				case 10:
					num2 = ⴐ[337] - 115;
					continue;
				case 0:
				case 11:
					return result;
				case 8:
					num2 = ⴃႥ[120] - 25359;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴈ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DbCommand
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႤ[146] - 161;
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
				case 5:
					num2 = (((P_2 ^ P_1) - 110) ^ num) switch
					{
						0 => ⴃႥ[204] - 3273, 
						_ => 4, 
					};
					continue;
				case 4:
					result = null;
					num2 = 0;
					continue;
				case 1:
				case 8:
					result = P_0.ExecuteScalar();
					num2 = 0;
					continue;
				case 0:
				{
					num++;
					int num3 = 1;
					int num4 = 434;
					num2 = ((868 > num4 - num3 * 2) ? 10 : 6);
					continue;
				}
				case 6:
				case 9:
					num2 = ⴀႼ[136];
					continue;
				case 10:
				case 11:
					return result;
				case 2:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}
}
