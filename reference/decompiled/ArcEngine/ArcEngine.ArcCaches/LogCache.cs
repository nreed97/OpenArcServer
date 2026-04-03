using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Runtime.CompilerServices;
using System.Threading;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.AnnWx;
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
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class LogCache
{
	private static readonly ILog Ⴈ;

	private static readonly object Ⴅ;

	private DataSet Ⴍ;

	private Publisher.ႣႣ Ⴀ = new Publisher.ႣႣ();

	[SpecialName]
	internal DataSet Ⴐ()
	{
		return Ⴍ;
	}

	[SpecialName]
	private void Ⴄ(DataSet P_0)
	{
		Ⴍ = P_0;
	}

	public LogCache(ArcServerCfg arcServerCfg)
	{
		Ⴀ.Ⴈ = arcServerCfg;
		Ⴄ(Ⴃ());
		Ⴈ.Info(ႨႨ.Ⴀ(6, 8, 1157898988));
	}

	public void Maintenance()
	{
		int num = 0;
		object ⴅ = default(object);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				return;
			}
			if (DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴐ(), 'Ϡ', 'Ν'), 0, 'Ǥ', 432), '\u0351', 849), (short)586, (short)535) == 0)
			{
				num = 1;
				continue;
			}
			SaveToDb();
			bool lockTaken = false;
			try
			{
				Monitor.Enter(ⴅ = Ⴅ, ref lockTaken);
				Ⴐ().Clear();
				return;
			}
			finally
			{
				int num2 = 1;
				while (true)
				{
					int num3;
					switch (num2)
					{
					default:
						num3 = ((!lockTaken) ? 4 : 5);
						goto IL_00d4;
					case 2:
					case 3:
					case 5:
						Monitor.Exit(ⴅ);
						break;
					case 4:
						break;
					}
					break;
					IL_00d4:
					num2 = num3;
				}
			}
		}
	}

	private DataSet Ⴃ()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		while (true)
		{
			object obj = new DataSet();
			ByeHelp.Ⴈ(DirectoryHelp.Ⴀ((DataSet)obj, 'Ǯ', 'Ɠ'), new DataTable(ShowWxHelp.Ⴍ('é', 985805227, 0)), 127, 24);
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႳ[209] - 53221;
					continue;
				case 6:
					break;
				case 5:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)obj, 'ɋ', 'ȶ'), 0, 'ʅ', 721), 597, 630), new DataColumn(SetTalkCount.Ⴗ(5, null, 1267022182, typeof(SetAnnModeHelp)), typeof(string)), 117, 'u');
					goto case 3;
				case 3:
					num = ⴄႷ[129] - 22989;
					continue;
				case 1:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)obj, 'ͼ', '\u0301'), 0, '\u0352', 774), 971, 1000), new DataColumn(ShowWxHelp.Ⴍ('¦', 985805644, 3), typeof(string)), 639, 'ɿ');
					num = 8;
					continue;
				case 8:
					HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(obj as DataSet, '#', '^'), 0, 'ċ', 351), 436, 407).Add(new DataColumn(ShowWxHelp.Ⴍ('é', 985805632, 7), typeof(string)));
					num = 2;
					continue;
				case 2:
				case 4:
					((DataSet)obj).Tables[0].Columns.Add(new DataColumn(ShowWxHelp.Ⴍ('å', 985805488, 4), typeof(string)));
					num = 7;
					continue;
				case 7:
					(obj as DataSet).Tables[0].Columns.Add(new DataColumn(ႰႥ.Ⴅ(4, 'ä', 952620233), typeof(DateTime)));
					goto case 0;
				case 0:
					num = 10;
					continue;
				case 10:
					return obj as DataSet;
				}
				break;
			}
		}
	}

	public void Add(LogEntry log)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		try
		{
			switch (1)
			{
			default:
			{
				bool flag = false;
				object ⴅ = default(object);
				try
				{
					int num = 3;
					object obj = default(object);
					while (true)
					{
						switch (num)
						{
						default:
						{
							ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 443, 434);
							obj = NodeUserCmd.Ⴓ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴐ(), 'Ά', 'ϻ'), 0, 'Ȓ', 582), 'τ', 'ί');
							char num2 = ⴀႣ[404];
							SetTalkCountHelp.Ⴅ[57] = (byte)((SetTalkCountHelp.Ⴅ[57] ^ SetTalkCountHelp.Ⴅ[22]) & 0x1A);
							num = num2 - 52044;
							continue;
						}
						case 0:
						case 7:
							ArcConnectObj.Ⴓ(obj as DataRow, SetTalkCount.Ⴗ(7, null, 1267022180, typeof(ႷႭ)), (object)log.Ⴗ(), 'ǒ', 'ǁ');
							num = 4;
							continue;
						case 4:
							ArcConnectObj.Ⴓ(obj as DataRow, ShowWxHelp.Ⴍ('\u0006', 985805644, 3), (object)log.Ⴍ(), '\u036d', ';');
							goto case 1;
						case 1:
						case 8:
							num = 9;
							continue;
						case 9:
							ArcConnectObj.Ⴓ(obj as DataRow, ShowWxHelp.Ⴍ('Ì', 985805632, 7), (object)log.Ⴈ(), 'ˁ', '\u02d2');
							num = 10;
							continue;
						case 10:
							ArcConnectObj.Ⴓ(obj as DataRow, ShowWxHelp.Ⴍ('\u009f', 985805488, 4), (object)log.Ⴃ(), '\u0301', '\u0312');
							num = 2;
							continue;
						case 2:
							(obj as DataRow)[ႰႥ.Ⴅ(8, '\u00ad', 952620229)] = log.Ⴐ();
							num = 6;
							continue;
						case 6:
							Ⴐ().Tables[0].Rows.Add((DataRow)obj);
							break;
						}
						break;
					}
				}
				finally
				{
					int num3 = 3;
					while (true)
					{
						int num4;
						switch (num3)
						{
						default:
							num4 = ((!flag) ? (ⴀ[242] - 62370) : 6);
							goto IL_022d;
						case 6:
							Monitor.Exit(ⴅ);
							break;
						case 0:
						case 1:
						case 2:
							break;
						}
						break;
						IL_022d:
						num3 = num4;
					}
				}
				switch (3)
				{
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			Ⴈ.Error(ex.Message);
		}
		switch (3)
		{
		}
	}

	public void SaveToDb()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool flag = false;
		object ⴅ = default(object);
		try
		{
			switch (0)
			{
			default:
				ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 444, 437);
				try
				{
					switch (0)
					{
					default:
					{
						DbConnection dbConnection = new SqlCeConnection(Ⴀ.Ⴈ.Configuration.DbConnect);
						try
						{
							int num = 4;
							object obj = default(object);
							object obj2 = default(object);
							DbCommand dbCommand = default(DbCommand);
							int num2 = default(int);
							while (true)
							{
								switch (num)
								{
								default:
									obj = new PrecisionTimer();
									goto case 8;
								case 8:
									ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 646, 711);
									SetAnnWrapHelp.Ⴀ((DbConnection)(SqlCeConnection)dbConnection, 83, (short)80);
									goto case 9;
								case 9:
									num = 11;
									continue;
								case 11:
									obj2 = new SqlCeDataAdapter();
									dbCommand = new SqlCeCommand(ShowSkimCtyHelp.Ⴍ(1216131036, 1, 'F'), (SqlCeConnection)dbConnection);
									num = ⴀႨ[203] - 48778;
									continue;
								case 6:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(dbCommand as SqlCeCommand, 1022, 905), CallBlockCacheCfg.Ⴅ(null, 8, 62058080, null), SqlDbType.NVarChar, 12, SetTalkCount.Ⴗ(7, null, 1267022180, typeof(CtyCacheCfg)), 683, 650);
									goto case 12;
								case 12:
									num = ⴀႳ[303] - 34420;
									continue;
								case 2:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)dbCommand, 237, 154), ႰႥ.Ⴅ(5, '\u00a0', 952616521), SqlDbType.NVarChar, 30, ShowWxHelp.Ⴍ('í', 985805647, 0), 516, 549);
									num = 5;
									continue;
								case 5:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(dbCommand as SqlCeCommand, 898, 1013), ႨႨ.Ⴀ(1, 0, 1157899003), SqlDbType.NVarChar, 15, ShowWxHelp.Ⴍ('Ã', 985805638, 1), 259, 290);
									num = 3;
									continue;
								case 3:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(dbCommand as SqlCeCommand, 623, 536), ႰႥ.Ⴅ(3, 's', 952616539), SqlDbType.NVarChar, 35, ShowWxHelp.Ⴍ('.', 985805493, 1), 870, 839);
									num = ⴍႤ[209] - 50539;
									continue;
								case 10:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)dbCommand, 817, 838), CallBlockCacheCfg.Ⴅ(null, 3, 62058003, null), SqlDbType.DateTime, 0, ႰႥ.Ⴅ(6, '*', 952620235), 941, 908);
									num = ⴀႼ[80];
									continue;
								case 0:
									qslinfoSoapClient.Ⴄ(obj2 as SqlCeDataAdapter, dbCommand as SqlCeCommand, 'Ȩ', 635);
									num2 = ByeHelp.Ⴗ((DbDataAdapter)(obj2 as SqlCeDataAdapter), SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴐ(), 'ʴ', 'ˉ'), 0, 'ƺ', 494), 683, (short)698);
									num = ⴃႰ[13] - 37061;
									continue;
								case 7:
								{
									ByeHelp.Ⴄ(obj as PrecisionTimer, 'ć', 340);
									ILog ⴈ = Ⴈ;
									Array array = new object[4];
									(array as object[])[0] = obj as PrecisionTimer;
									((object[])array)[1] = ReplyMail.Ⴅ(6, 9, 1217940747);
									((object[])array)[2] = num2;
									(array as object[])[3] = SetStationQth.Ⴍ(null, 1687351833, 2, 20);
									ⴈ.Info(string.Concat(array as object[]));
									break;
								}
								}
								break;
							}
						}
						finally
						{
							int num3 = 5;
							while (true)
							{
								int num4;
								switch (num3)
								{
								default:
									num4 = ((!(dbConnection is SqlCeConnection)) ? 6 : 3);
									goto IL_03f5;
								case 1:
								case 3:
									((IDisposable)(SqlCeConnection)dbConnection).Dispose();
									break;
								case 2:
								case 6:
									break;
								}
								break;
								IL_03f5:
								num3 = num4;
							}
						}
						switch (1)
						{
						}
						break;
					}
					}
				}
				catch (Exception ex)
				{
					Ⴈ.Error((ex as Exception).Message);
				}
				switch (4)
				{
				}
				break;
			}
		}
		finally
		{
			int num5 = 1;
			while (true)
			{
				int num6;
				switch (num5)
				{
				default:
					num6 = ((!flag) ? 5 : (ⴃႰ[2] - 38927));
					goto IL_0496;
				case 3:
					Monitor.Exit(ⴅ);
					break;
				case 5:
				case 6:
					break;
				}
				break;
				IL_0496:
				num5 = num6;
			}
		}
		switch (4)
		{
		}
	}

	public DataRow[] GetDataRow(string sql, int nmbrDesired)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		bool flag = false;
		object ⴅ = default(object);
		Array array;
		try
		{
			switch (1)
			{
			default:
				ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 736, 745);
				break;
			case 3:
				break;
			}
			array = DxSpotBlockCacheCfg.Ⴄ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴐ(), 'ǧ', 'ƚ'), 0, 'ə', 525), sql, SetStationQth.Ⴍ(null, 1687351810, 4, 3), 'ɂ', 'ȅ');
		}
		finally
		{
			int num = 5;
			while (true)
			{
				bool num2;
				switch (num)
				{
				default:
					num2 = !flag;
					goto IL_00e7;
				case 0:
				case 3:
					DxCmdMsgExt.ႨႠ(ⴅ, '\u0090', 245);
					break;
				case 1:
				case 4:
					break;
				}
				break;
				IL_00e7:
				num = (num2 ? 1 : 0);
			}
		}
		switch (1)
		{
		default:
			if (((DataRow[])array).Length < nmbrDesired)
			{
				try
				{
					int num3 = 13;
					IConvertible convertible = default(IConvertible);
					ISupportInitializeNotification supportInitializeNotification = default(ISupportInitializeNotification);
					DbDataAdapter dbDataAdapter = default(DbDataAdapter);
					int num5 = default(int);
					int num4 = default(int);
					while (true)
					{
						switch (num3)
						{
						default:
							SaveToDb();
							convertible = ShowPrefixCalls.Ⴃ((object)ReplyMailHelp.Ⴄ(1, null, 1057161786, 6), (object)nmbrDesired, (object)SetStationClubHelp.Ⴍ(nmbrDesired, 0, 1747260115, null), '\u0349', 867);
							goto case 7;
						case 7:
							num3 = 9;
							continue;
						case 9:
							num3 = ((CallBlockCacheCfg.Ⴜ(sql, 50, 83) <= 0) ? 4 : (ⴄႭ[631] - 225));
							continue;
						case 3:
							convertible = AnnHelp.Ⴈ((string)convertible, ႰႥ.Ⴅ(2, '`', 952620693), LogEntry.Ⴄ(sql, 'ő', 379), 463, 'Ǹ');
							num3 = 4;
							continue;
						case 4:
							convertible = ShowContestStationHelp.Ⴅ(convertible as string, SetTalkCount.Ⴗ(4, null, 1267022174, typeof(WxLocalUser.WxLocalHelp)), ReplyMail.Ⴅ(6, nmbrDesired, 1217945223), 723, 'ʋ');
							num3 = 2;
							continue;
						case 2:
							supportInitializeNotification = new DataSet();
							dbDataAdapter = new SqlCeDataAdapter(convertible as string, Ⴀ.Ⴈ.Configuration.DbConnect);
							num3 = ⴄႭ[616] - 149;
							continue;
						case 11:
							ShowDxFilter.Ⴄ((DbDataAdapter)(SqlCeDataAdapter)dbDataAdapter, supportInitializeNotification as DataSet, ShowWxHelp.Ⴍ('\u008c', 985805226, 1), 'ζ', 'Ϭ');
							num3 = ⴄႭ[343] - ⴄႭ[498];
							continue;
						case 12:
							num5 = DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitializeNotification, 'Έ', 'ϵ'), 0, 'ă', 343), '\u0383', 899), (short)710, (short)667);
							num3 = ⴐ[80];
							continue;
						case 14:
							array = new DataRow[num5];
							num4 = 0;
							num3 = 0;
							continue;
						case 5:
						{
							object obj = (supportInitializeNotification as DataSet).Tables[0].Rows[num4];
							((DataRow[])array)[num4] = (DataRow)obj;
							num3 = ⴍႭ[331] - 20123;
							continue;
						}
						case 10:
							num4++;
							num3 = 0;
							continue;
						case 0:
							num3 = ((num4 < num5) ? 5 : 6);
							continue;
						case 6:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Ⴈ.Error(ex.Message + ႰႥ.Ⴅ(1, '6', 952620211) + sql);
				}
			}
			return 1 switch
			{
				_ => array as DataRow[], 
			};
		}
	}

	public string FormatSqlFilter(string sql)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		object obj = string.Empty;
		try
		{
			obj = ႰႠ.Ⴗ(sql, SqlFilterType.Log, 113, 16);
		}
		catch (Exception ex)
		{
			Ⴈ.Error(SkimmerSpotBins.Ⴈ(ex, 242, 220));
		}
		return obj as string;
	}

	static LogCache()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
				Ⴅ = new object();
				return;
			}
			Ⴈ = SkimmerValidSpot.Ⴐ(SetStationClubHelp.Ⴍ(6, 2, 1747260096, null), 557, 560);
			num = ⴃႥ[33] - 47788;
		}
	}
}
