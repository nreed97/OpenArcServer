using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Runtime.CompilerServices;
using System.Threading;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcCmds.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class WwvCache
{
	private static readonly ILog m_Ⴅ;

	private static readonly object Ⴍ;

	private ႨႳ.Ⴈ m_Ⴀ = new ႨႳ.Ⴈ();

	[SpecialName]
	internal DataSet Ⴅ()
	{
		return this.m_Ⴀ.Ⴃ;
	}

	[SpecialName]
	private void Ⴐ(DataSet P_0)
	{
		this.m_Ⴀ.Ⴃ = P_0 as DataSet;
	}

	public WwvCache(ArcServerCfg arcServerCfg)
	{
		this.m_Ⴀ.Ⴓ = arcServerCfg;
		Ⴐ(Ⴀ());
		WwvCache.m_Ⴅ.Info(ႨႨ.Ⴀ(4, 7, 1157899704));
	}

	public void Maintenance()
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				return;
			}
			if (ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴅ(), '\u02f6', 'ʋ'), 0, 'ɳ', 551), '\u0383', 899).Count == 0)
			{
				num = ⴀႣ[235] - ⴀႣ[235];
				continue;
			}
			SaveToDb();
			return;
		}
	}

	private DataSet Ⴀ()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		while (true)
		{
			ISupportInitializeNotification supportInitializeNotification = new DataSet();
			ByeHelp.Ⴈ(DirectoryHelp.Ⴀ(supportInitializeNotification as DataSet, 'ʔ', '\u02e9'), new DataTable(ShowWxHelp.Ⴍ('\u0012', 985805701, 7)), 974, 937);
			int num = 14;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 13;
					continue;
				case 13:
					break;
				case 14:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(supportInitializeNotification as DataSet, '\u02dd', 'ʠ'), 0, '\u02e8', 700), 112, 83), new DataColumn(SetStationQth.Ⴍ(null, 1687351660, 3, 18), typeof(string)), 942, 'ή');
					num = ⴃႥ[19] - 30653;
					continue;
				case 12:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitializeNotification, 'Ċ', 'ŷ'), 0, 'ˁ', 661), 161, 130), new DataColumn(CallBlockCacheCfg.Ⴅ(null, 7, 62057838, null), typeof(string)), 580, 'Ʉ');
					num = 1;
					continue;
				case 1:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitializeNotification, '\u0097', 'ê'), 0, 'æ', 178), 177, 146), new DataColumn(ReplyMailHelp.Ⴄ(8, null, 1057162200, 3), typeof(string)), 509, 'ǽ');
					num = 2;
					continue;
				case 2:
				case 4:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(supportInitializeNotification as DataSet, 'ĝ', 'Š'), 0, 'ď', 347), 805, 774), new DataColumn(ႨႨ.Ⴀ(13, 0, 1157903485), typeof(string)), 488, 'Ǩ');
					num = 6;
					continue;
				case 6:
				case 7:
					HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(supportInitializeNotification as DataSet, 'ε', 'ψ'), 0, 'Ħ', 370), 149, 182).Add(new DataColumn(ReplyMailHelp.Ⴄ(23, null, 1057162066, 0), typeof(string)));
					num = ⴅ[91] - 107;
					continue;
				case 3:
				case 9:
					(supportInitializeNotification as DataSet).Tables[0].Columns.Add(new DataColumn(CallBlockCacheCfg.Ⴅ(null, 7, 62057996, null), typeof(string)));
					num = 11;
					continue;
				case 11:
					(supportInitializeNotification as DataSet).Tables[0].Columns.Add(new DataColumn(ShowSkimCtyHelp.Ⴍ(1216133140, 0, '8'), typeof(string)));
					num = ⴀႣ[313] - 23351;
					continue;
				case 10:
					((DataSet)supportInitializeNotification).Tables[0].Columns.Add(new DataColumn(ShowWxHelp.Ⴍ('T', 985808423, 0), typeof(string)));
					num = ⴄႤ[345] - 127;
					continue;
				case 0:
					((DataSet)supportInitializeNotification).Tables[0].Columns.Add(new DataColumn(ႰႥ.Ⴅ(1, '\u008f', 952620236), typeof(DateTime)));
					num = 8;
					continue;
				case 8:
					return (DataSet)supportInitializeNotification;
				}
				break;
			}
		}
	}

	public bool AddSpot(WwvSpot wwv)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		bool result = default(bool);
		try
		{
			switch (0)
			{
			default:
			{
				bool flag = false;
				object ⴍ = default(object);
				try
				{
					int num = 12;
					bool flag2 = default(bool);
					object obj = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							ႨႥ.Ⴍ(ⴍ = Ⴍ, ref flag, 71, 78);
							flag2 = Ⴃ(wwv);
							num = 13;
							continue;
						case 13:
							num = (flag2 ? (ⴃႰ[150] - 63823) : 10);
							continue;
						case 10:
							obj = NodeUserCmd.Ⴓ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴅ(), 'ñ', '\u008c'), 0, 'ȑ', 581), 'Ȍ', 'ɧ');
							num = ⴄႷ[70] - 5428;
							continue;
						case 11:
							ArcConnectObj.Ⴓ((DataRow)obj, SetStationQth.Ⴍ(null, 1687351655, 8, 12), (object)ShowTalkOptionsHelp.Ⴅ(wwv, 879, '\u0368'), ';', '\u036d');
							num = 0;
							continue;
						case 0:
						case 14:
							ArcConnectObj.Ⴓ((DataRow)obj, CallBlockCacheCfg.Ⴅ(null, 3, 62057834, null), (object)SetStationEmail.Ⴍ(wwv, 314, 330), 'Í', 'Þ');
							num = 9;
							continue;
						case 9:
							ArcConnectObj.Ⴓ(obj as DataRow, ReplyMailHelp.Ⴄ(28, null, 1057162195, 8), (object)WwvSpotUser.Ⴈ(wwv, 'ώ', 991), 'ǐ', 'ǃ');
							num = 1;
							continue;
						case 1:
							ArcConnectObj.Ⴓ(obj as DataRow, ႨႨ.Ⴀ(3, 1, 1157903484), (object)ShowQslInfoHelp.Ⴃ(wwv, 385, 443), 'ʤ', 'ʷ');
							num = 17;
							continue;
						case 15:
						case 17:
							ArcConnectObj.Ⴓ(obj as DataRow, ReplyMailHelp.Ⴄ(11, null, 1057162070, 4), (object)ႨႨ.Ⴃ(wwv, 'ˇ', 657), '\u0345', '\u0356');
							num = 5;
							continue;
						case 5:
							ArcConnectObj.Ⴓ((DataRow)obj, CallBlockCacheCfg.Ⴅ(null, 6, 62057997, null), (object)ShowLogHelp.Ⴃ(wwv, 'ƶ', 427), 'ʿ', 'ʬ');
							num = 7;
							continue;
						case 7:
						case 8:
							(obj as DataRow)[ShowSkimCtyHelp.Ⴍ(1216133137, 5, 'B')] = wwv.Route;
							num = ⴀ[0] - 1709;
							continue;
						case 2:
							((DataRow)obj)[ShowWxHelp.Ⴍ('\u008c', 985808431, 8)] = wwv.DupeKey;
							num = 3;
							continue;
						case 3:
							(obj as DataRow)[SetStationQth.Ⴍ(null, 1687351812, 2, 17)] = wwv.Dts;
							num = ⴃႰ[140] - 50923;
							continue;
						case 4:
							Ⴅ().Tables[0].Rows.Add((DataRow)obj);
							break;
						case 6:
							break;
						}
						break;
					}
					result = flag2;
					return result;
				}
				finally
				{
					int num2 = 4;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = ((!flag) ? (ⴐ[243] / 8) : 3);
							goto IL_0354;
						case 3:
						case 6:
							Monitor.Exit(ⴍ);
							break;
						case 0:
						case 1:
						case 5:
							break;
						}
						break;
						IL_0354:
						num2 = num3;
					}
				}
			}
			}
		}
		catch (Exception ex)
		{
			WwvCache.m_Ⴅ.Error((ex as Exception).Message);
		}
		switch (2)
		{
		default:
			return true;
		case 0:
		case 1:
		case 3:
		case 5:
			return result;
		}
	}

	private bool Ⴃ(WwvSpot P_0)
	{
		while (true)
		{
			object obj = SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴅ(), 'ɐ', 'ȭ'), 0, 'Ę', 332).Select(SetStationQth.Ⴍ(null, 1687354714, 8, 28) + SetStationEmail.Ⴍ(P_0, 543, 622) + ႨႨ.Ⴀ(7, 8, 1157903565));
			while (true)
			{
				IL_0084:
				int num = 5;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 1;
						continue;
					case 1:
					case 4:
						break;
					case 3:
						goto IL_0084;
					case 5:
						return (obj as DataRow[]).Length > 0;
					}
					break;
				}
				break;
			}
		}
	}

	public void SaveToDb()
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool flag = false;
		object ⴍ = default(object);
		try
		{
			switch (3)
			{
			default:
				ႨႥ.Ⴍ(ⴍ = Ⴍ, ref flag, 728, 721);
				try
				{
					switch (1)
					{
					default:
					{
						DbConnection dbConnection = new SqlCeConnection(this.m_Ⴀ.Ⴓ.Configuration.DbConnect);
						try
						{
							int num = 13;
							object obj = default(object);
							object obj2 = default(object);
							ICloneable cloneable = default(ICloneable);
							int num2 = default(int);
							while (true)
							{
								switch (num)
								{
								default:
									obj = new PrecisionTimer();
									ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 249, 184);
									SetAnnWrapHelp.Ⴀ((DbConnection)(dbConnection as SqlCeConnection), 483, (short)480);
									goto case 10;
								case 10:
									num = 2;
									continue;
								case 2:
									obj2 = new SqlCeDataAdapter();
									cloneable = new SqlCeCommand(ReplyMailHelp.Ⴄ(10, null, 1057165911, 2), dbConnection as SqlCeConnection);
									num = ⴐ[204];
									continue;
								case 4:
								case 6:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable as SqlCeCommand, 600, 559), ShowWxHelp.Ⴍ('\u0090', 985805701, 1), SqlDbType.NVarChar, 5, SetStationQth.Ⴍ(null, 1687351662, 1, 8), 428, 397);
									num = ⴐ[373] - ⴐ[179];
									continue;
								case 5:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable as SqlCeCommand, 24, 111), CallBlockCacheCfg.Ⴅ(null, 3, 62055052, null), SqlDbType.NVarChar, 5, CallBlockCacheCfg.Ⴅ(null, 5, 62057836, null), 510, 479);
									num = 0;
									continue;
								case 0:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 976, 935), ShowWxHelp.Ⴍ('\u0099', 985805701, 8), SqlDbType.NVarChar, 5, ReplyMailHelp.Ⴄ(4, null, 1057162207, 4), 715, 746);
									num = 8;
									continue;
								case 8:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 661, 738), CallBlockCacheCfg.Ⴅ(null, 1, 62055093, null), SqlDbType.NVarChar, 100, ႨႨ.Ⴀ(0, 1, 1157903484), 865, 832);
									goto case 1;
								case 1:
									num = 15;
									continue;
								case 15:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 180, 195), ReplyMailHelp.Ⴄ(29, null, 1057161851, 3), SqlDbType.NVarChar, 12, ReplyMailHelp.Ⴄ(6, null, 1057162074, 8), 749, 716);
									num = ⴀႨ[144] - 11817;
									continue;
								case 11:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 589, 570), SetStationQth.Ⴍ(null, 1687351867, 2, 12), SqlDbType.NVarChar, 12, CallBlockCacheCfg.Ⴅ(null, 3, 62057992, null), 665, 696);
									num = 9;
									continue;
								case 9:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable as SqlCeCommand, 152, 239), ReplyMailHelp.Ⴄ(15, null, 1057161735, 0), SqlDbType.NVarChar, 255, ShowSkimCtyHelp.Ⴍ(1216133143, 3, '\u0093'), 145, 176);
									num = 14;
									continue;
								case 14:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 228, 147), CallBlockCacheCfg.Ⴅ(null, 1, 62058001, null), SqlDbType.DateTime, 0, ႰႥ.Ⴅ(1, '\u0085', 952620236), 17, 48);
									num = ⴃႰ[17] - 56147;
									continue;
								case 3:
									qslinfoSoapClient.Ⴄ((SqlCeDataAdapter)obj2, cloneable as SqlCeCommand, 'Ϭ', 959);
									num2 = ((SqlCeDataAdapter)obj2).Update(Ⴅ().Tables[0]);
									num = 7;
									continue;
								case 7:
								{
									((PrecisionTimer)obj).Stop();
									ILog ⴅ = WwvCache.m_Ⴅ;
									Array array = new object[4];
									(array as object[])[0] = (PrecisionTimer)obj;
									((object[])array)[1] = ShowSkimCtyHelp.Ⴍ(1216129445, 4, 'R');
									(array as object[])[2] = num2;
									((object[])array)[3] = SetStationQth.Ⴍ(null, 1687351834, 1, 11);
									ⴅ.Info(string.Concat((object[])array));
									break;
								}
								}
								break;
							}
						}
						finally
						{
							int num3 = 2;
							while (true)
							{
								int num4;
								switch (num3)
								{
								default:
									num4 = ((!(dbConnection is SqlCeConnection)) ? (ⴀႨ[185] - 58115) : 4);
									goto IL_04a7;
								case 4:
								case 6:
									((IDisposable)(dbConnection as SqlCeConnection)).Dispose();
									break;
								case 0:
								case 5:
									break;
								}
								break;
								IL_04a7:
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
					WwvCache.m_Ⴅ.Error(ex.Message);
				}
				switch (2)
				{
				}
				break;
			}
		}
		finally
		{
			int num5 = 2;
			while (true)
			{
				int num6;
				switch (num5)
				{
				default:
					num6 = ((!flag) ? (ⴐ[307] - 218) : (ⴄႷ[61] - 8215));
					goto IL_0556;
				case 6:
					Monitor.Exit(ⴍ);
					break;
				case 1:
					break;
				}
				break;
				IL_0556:
				num5 = num6;
			}
		}
		switch (2)
		{
		}
	}

	public DataTable GetDataTable(string sql, int nmbrDesired)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		ISupportInitializeNotification supportInitializeNotification = default(ISupportInitializeNotification);
		try
		{
			int num = 9;
			IEnumerable enumerable = default(IEnumerable);
			ISupportInitializeNotification supportInitializeNotification2 = default(ISupportInitializeNotification);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					SaveToDb();
					enumerable = ShowPrefixCalls.Ⴃ((object)ReplyMailHelp.Ⴄ(7, null, 1057161785, 5), (object)nmbrDesired, (object)ႨႨ.Ⴀ(nmbrDesired, 5, 1157899607), 'Ǉ', 493);
					num = 5;
					continue;
				case 5:
					num = ((CallBlockCacheCfg.Ⴜ(sql, 179, 210) > 0) ? 1 : (ⴀႨ[219] - 45727));
					continue;
				case 1:
					enumerable = AnnHelp.Ⴈ((string)enumerable, ႰႥ.Ⴅ(7, '¿', 952620688), LogEntry.Ⴄ(sql, 's', 89), 801, '\u0316');
					num = 2;
					continue;
				case 2:
				case 6:
					enumerable = ShowUsersHelp.Ⴅ(enumerable as string, ႰႥ.Ⴅ(5, 'Â', 952622469), 526, 576);
					num = 7;
					continue;
				case 7:
					supportInitializeNotification2 = new DataSet();
					obj = new SqlCeDataAdapter((string)enumerable, this.m_Ⴀ.Ⴓ.Configuration.DbConnect);
					goto case 10;
				case 10:
					num = 0;
					continue;
				case 0:
					ShowDxFilter.Ⴄ((DbDataAdapter)(SqlCeDataAdapter)obj, (DataSet)supportInitializeNotification2, ShowWxHelp.Ⴍ('\u0085', 985805702, 4), 'ɚ', 'Ȁ');
					num = ⴍႤ[88] - 21892;
					continue;
				case 4:
				case 8:
					supportInitializeNotification = DirectoryHelp.Ⴀ(supportInitializeNotification2 as DataSet, 'ʷ', 'ˊ')[0];
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			WwvCache.m_Ⴅ.Error((ex as Exception).Message + ႰႥ.Ⴅ(6, 'K', 952620212) + sql);
			goto IL_01c7;
		}
		goto IL_01eb;
		IL_01c7:
		switch (3)
		{
		default:
			return null;
		case 5:
			break;
		}
		goto IL_01eb;
		IL_01eb:
		return supportInitializeNotification as DataTable;
	}

	public string FormatSqlFilter(string cmdMsgSql)
	{
		object obj = string.Empty;
		try
		{
			obj = ႰႠ.Ⴗ(cmdMsgSql, SqlFilterType.Wwv, 796, 893);
		}
		catch (Exception ex)
		{
			WwvCache.m_Ⴅ.Error(SkimmerSpotBins.Ⴈ(ex, 907, 933));
		}
		string result = (string)obj;
		SetAnnChatRooms.Ⴀ[412] = (char)((SetAnnChatRooms.Ⴀ[412] | Arc4ServerClient.ႠႣ[152]) & 0xDC);
		return result;
	}

	public DataRow GetLatestWwv()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		while (true)
		{
			ISupportInitializeNotification dataTable = GetDataTable(string.Empty, 1);
			int num = ((DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ((DataTable)dataTable, 'G', 71), (short)920, (short)965) <= 0) ? (ⴃႰ[122] - 21833) : 2);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
				case 1:
					break;
				case 2:
					return ((DataTable)dataTable).Rows[0];
				case 6:
					return null;
				}
				break;
			}
		}
	}

	static WwvCache()
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				Ⴍ = new object();
				return;
			case 0:
			case 4:
				return;
			}
			WwvCache.m_Ⴅ = SkimmerValidSpot.Ⴐ(ႨႨ.Ⴀ(1, 4, 1157899609), 617, 628);
			num = 2;
		}
	}
}
