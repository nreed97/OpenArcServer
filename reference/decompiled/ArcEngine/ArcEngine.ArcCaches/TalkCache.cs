using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Runtime.CompilerServices;
using System.Threading;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.Talk;
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
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class TalkCache
{
	private static readonly ILog Ⴐ;

	private static readonly object m_Ⴄ;

	private readonly ArcServerCfg Ⴓ;

	private CallbookCfg.Ⴀ Ⴗ = new CallbookCfg.Ⴀ();

	[SpecialName]
	internal DataSet Ⴃ()
	{
		return Ⴗ.Ⴐ;
	}

	[SpecialName]
	private void Ⴄ(DataSet P_0)
	{
		Ⴗ.Ⴐ = P_0 as DataSet;
		ShowQrzHelp.ႤႤ[315] = (byte)((ShowQrzHelp.ႤႤ[315] * AnnCacheCfg.ႠႼ[129]) & 0xB8);
	}

	public TalkCache(ArcServerCfg arcServerCfg)
	{
		Ⴓ = arcServerCfg;
		Ⴄ(Ⴅ());
		Ⴐ.Info(CallBlockCacheCfg.Ⴅ(null, 1, 62058014, null));
	}

	private DataSet Ⴅ()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		while (true)
		{
			ISupportInitialize supportInitialize = new DataSet();
			while (true)
			{
				IL_0061:
				ByeHelp.Ⴈ(DirectoryHelp.Ⴀ(supportInitialize as DataSet, 'ņ', 'Ļ'), new DataTable(ႨႨ.Ⴀ(7, 8, 1157903708)), 576, 551);
				int num = ⴀႳ[37] - 40170;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 4;
						continue;
					case 4:
						break;
					case 3:
						goto IL_0061;
					case 13:
						SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitialize, '\u02e7', 'ʚ'), 0, 'İ', 356), 585, 618), new DataColumn(SetStationClubHelp.Ⴍ(0, 4, 1747258014, null), typeof(string)), 407, 'Ɨ');
						num = 0;
						continue;
					case 0:
						SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(supportInitialize as DataSet, '\u032d', '\u0350'), 0, 'ɶ', 546), 975, 1004), new DataColumn(SetStationClubHelp.Ⴍ(4, 6, 1747258265, null), typeof(string)), 592, 'ɐ');
						num = 6;
						continue;
					case 6:
						SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitialize, '1', 'L'), 0, 'É', 157), 10, 41), new DataColumn(ReplyMailHelp.Ⴄ(16, null, 1057162067, 1), typeof(string)), 281, 'ę');
						num = 9;
						continue;
					case 9:
						SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitialize, 'ȇ', 'ɺ'), 0, 'ĥ', 369), 94, 125), new DataColumn(CallBlockCacheCfg.Ⴅ(null, 0, 62057995, null), typeof(string)), 518, 'Ȇ');
						num = ⴃႥ[324] - 2917;
						continue;
					case 2:
					case 11:
						HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitialize, 'Ǽ', 'Ɓ'), 0, 'ʂ', 726), 131, 160).Add(new DataColumn(ႰႥ.Ⴅ(1, 'Ë', 952620781), typeof(string)));
						num = 7;
						continue;
					case 7:
						(supportInitialize as DataSet).Tables[0].Columns.Add(new DataColumn(ReplyMailHelp.Ⴄ(28, null, 1057161838, 2), typeof(string)));
						num = 1;
						continue;
					case 1:
						((DataSet)supportInitialize).Tables[0].Columns.Add(new DataColumn(ShowSkimCtyHelp.Ⴍ(1216133136, 4, '·'), typeof(string)));
						num = 5;
						continue;
					case 5:
					case 12:
						((DataSet)supportInitialize).Tables[0].Columns.Add(new DataColumn(ႰႥ.Ⴅ(6, '×', 952620235), typeof(DateTime)));
						num = 10;
						continue;
					case 10:
						(supportInitialize as DataSet).Tables[0].Columns.Add(new DataColumn(ShowWxHelp.Ⴍ(';', 985808423, 0), typeof(string)));
						num = 8;
						continue;
					case 8:
						return supportInitialize as DataSet;
					}
					break;
				}
				break;
			}
		}
	}

	public void AddSpot(TalkSpot talk)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		try
		{
			switch (3)
			{
			default:
			{
				bool flag = false;
				object ⴄ = default(object);
				try
				{
					int num = 8;
					object obj = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							ႨႥ.Ⴍ(ⴄ = TalkCache.m_Ⴄ, ref flag, 434, 443);
							obj = NodeUserCmd.Ⴓ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴃ(), 'ʰ', 'ˍ'), 0, 'ǥ', 433), 'ș', 'ɲ');
							num = 12;
							continue;
						case 11:
						case 12:
							ArcConnectObj.Ⴓ((DataRow)obj, SetStationClubHelp.Ⴍ(0, 6, 1747258012, null), (object)talk.To, 'Ê', 'Ù');
							num = 3;
							continue;
						case 3:
							ArcConnectObj.Ⴓ((DataRow)obj, SetStationClubHelp.Ⴍ(8, 2, 1747258269, null), (object)talk.Msg, '\u0019', '\n');
							num = ⴀႼ[2] / 2;
							continue;
						case 9:
							ArcConnectObj.Ⴓ(obj as DataRow, ReplyMailHelp.Ⴄ(1, null, 1057162070, 4), (object)talk.Spotter, 'Þ', 'Í');
							num = ⴄႷ[23] - 32511;
							continue;
						case 2:
							ArcConnectObj.Ⴓ(obj as DataRow, CallBlockCacheCfg.Ⴅ(null, 3, 62057992, null), (object)talk.SpotterNode, 'ʯ', 'ʼ');
							num = 14;
							continue;
						case 14:
							ArcConnectObj.Ⴓ(obj as DataRow, ႰႥ.Ⴅ(3, 't', 952620783), (object)talk.BellFlag, 'Ç', 'Ô');
							num = ⴄႭ[520] - 128;
							continue;
						case 13:
							ArcConnectObj.Ⴓ(obj as DataRow, ReplyMailHelp.Ⴄ(19, null, 1057161828, 8), (object)talk.RelayToCall, 'Ƨ', 'ƴ');
							num = 4;
							continue;
						case 4:
							ArcConnectObj.Ⴓ(obj as DataRow, ShowSkimCtyHelp.Ⴍ(1216133143, 3, 's'), (object)talk.Route, 'ǂ', 'Ǒ');
							num = 6;
							continue;
						case 6:
							(obj as DataRow)[SetStationQth.Ⴍ(null, 1687351811, 5, 13)] = talk.Dts;
							goto case 0;
						case 0:
							num = ⴀႨ[65] - 5869;
							continue;
						case 1:
							(obj as DataRow)[ShowWxHelp.Ⴍ('\u0096', 985808431, 8)] = talk.DupeKey;
							num = ⴃႰ[32] - 1112;
							continue;
						case 10:
							Ⴃ().Tables[0].Rows.Add((DataRow)obj);
							break;
						}
						break;
					}
				}
				finally
				{
					int num2 = 2;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = ((!flag) ? 1 : (ⴄႭ[568] / 2));
							goto IL_0306;
						case 0:
						case 6:
							Monitor.Exit(ⴄ);
							break;
						case 1:
							break;
						}
						break;
						IL_0306:
						num2 = num3;
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
			Ⴐ.Error(ex.Message);
		}
		switch (0)
		{
		}
	}

	internal bool Ⴈ(TalkSpot P_0)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		bool flag = false;
		object ⴄ = default(object);
		bool flag2 = default(bool);
		try
		{
			int num = 3;
			Array array = default(Array);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴄ = TalkCache.m_Ⴄ, ref flag, 739, 746);
					goto case 2;
				case 2:
					array = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴃ(), '\u02fe', 'ʃ'), 0, '\u0002', 86), AnnHelp.Ⴈ(CallBlockCacheCfg.Ⴅ(null, 0, 62058041, null), P_0.DupeKey, ႨႨ.Ⴀ(10, 4, 1157903553), 297, 'Ğ'), 'Ƞ', 541);
					break;
				case 5:
					break;
				case 1:
					flag2 = ((DataRow[])array).Length > 0;
					goto end_IL_0045;
				case 0:
					goto end_IL_0045;
				}
				num = 1;
				continue;
				end_IL_0045:
				break;
			}
		}
		finally
		{
			int num2 = 0;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? (ⴀႳ[321] - 61743) : 3);
					goto IL_0119;
				case 1:
				case 3:
					Monitor.Exit(ⴄ);
					break;
				case 2:
				case 4:
				case 5:
					break;
				}
				break;
				IL_0119:
				num2 = num3;
			}
		}
		return 4 switch
		{
			_ => flag2, 
		};
	}

	public void SaveToDb()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 4;
		object ⴄ = default(object);
		object obj = default(object);
		DbDataAdapter dbDataAdapter = default(DbDataAdapter);
		ICloneable cloneable = default(ICloneable);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				return;
			}
			if (DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴃ(), '\u02d5', 'ʨ'), 0, 'Ȇ', 594), '\u0005', 5), (short)560, (short)621) == 0)
			{
				num = 1;
				continue;
			}
			bool flag = false;
			try
			{
				switch (2)
				{
				default:
					ႨႥ.Ⴍ(ⴄ = TalkCache.m_Ⴄ, ref flag, 309, 316);
					try
					{
						switch (4)
						{
						default:
						{
							DbConnection dbConnection = new SqlCeConnection(Ⴓ.Configuration.DbConnect);
							try
							{
								int num2 = 1;
								while (true)
								{
									switch (num2)
									{
									default:
										obj = new PrecisionTimer();
										ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 1015, 950);
										SetAnnWrapHelp.Ⴀ((DbConnection)(dbConnection as SqlCeConnection), 637, (short)638);
										goto case 10;
									case 10:
										num2 = 11;
										continue;
									case 11:
										dbDataAdapter = new SqlCeDataAdapter();
										cloneable = new SqlCeCommand(ReplyMail.Ⴅ(3, 6, 1217944904), dbConnection as SqlCeConnection);
										num2 = 7;
										continue;
									case 7:
										NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 236, 155), ReplyMailHelp.Ⴄ(2, null, 1057161834, 8), SqlDbType.NVarChar, 12, SetStationClubHelp.Ⴍ(2, 1, 1747258011, null), 913, 944);
										num2 = 0;
										continue;
									case 0:
										NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 231, 144), SetStationQth.Ⴍ(null, 1687351810, 2, 13), SqlDbType.NVarChar, 255, SetStationClubHelp.Ⴍ(2, 1, 1747258270, null), 485, 452);
										num2 = 14;
										continue;
									case 14:
										NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 632, 527), ReplyMailHelp.Ⴄ(10, null, 1057161855, 7), SqlDbType.NVarChar, 12, ReplyMailHelp.Ⴄ(10, null, 1057162068, 6), 643, 674);
										num2 = 2;
										continue;
									case 2:
										NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 134, 241), SetStationQth.Ⴍ(null, 1687351868, 5, 5), SqlDbType.NVarChar, 12, CallBlockCacheCfg.Ⴅ(null, 6, 62057997, null), 742, 711);
										num2 = ⴃႥ[405] - 45698;
										continue;
									case 5:
										NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable as SqlCeCommand, 196, 179), ReplyMailHelp.Ⴄ(1, null, 1057161851, 8), SqlDbType.NVarChar, 1, ႰႥ.Ⴅ(8, 'U', 952620772), 217, 248);
										num2 = ⴍႤ[461] - 37943;
										continue;
									case 9:
										NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 402, 485), SetStationQth.Ⴍ(null, 1687351853, 7, 22), SqlDbType.NVarChar, 12, ReplyMailHelp.Ⴄ(14, null, 1057161833, 5), 949, 916);
										num2 = 3;
										continue;
									case 3:
										NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable as SqlCeCommand, 887, 768), ReplyMailHelp.Ⴄ(10, null, 1057161729, 6), SqlDbType.NVarChar, 255, ShowSkimCtyHelp.Ⴍ(1216133138, 6, 'r'), 279, 310);
										num2 = ⴄႭ[217] / 6;
										continue;
									case 15:
										NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 843, 828), CallBlockCacheCfg.Ⴅ(null, 5, 62058005, null), SqlDbType.DateTime, 0, ႰႥ.Ⴅ(1, '¬', 952620236), 385, 416);
										num2 = 8;
										continue;
									case 8:
										((SqlCeDataAdapter)dbDataAdapter).InsertCommand = (SqlCeCommand)cloneable;
										num3 = (dbDataAdapter as SqlCeDataAdapter).Update(Ⴃ().Tables[0]);
										num2 = 13;
										continue;
									case 13:
									{
										((PrecisionTimer)obj).Stop();
										ILog ⴐ = Ⴐ;
										object obj2 = new object[4];
										(obj2 as object[])[0] = (PrecisionTimer)obj;
										((object[])obj2)[1] = CallBlockCacheCfg.Ⴅ(null, 2, 62058162, null);
										((object[])obj2)[2] = num3;
										((object[])obj2)[3] = SetStationQth.Ⴍ(null, 1687351832, 3, 26);
										ⴐ.Info(string.Concat((object[])obj2));
										break;
									}
									case 4:
									case 6:
										break;
									}
									break;
								}
							}
							finally
							{
								int num4 = 6;
								while (true)
								{
									int num5;
									switch (num4)
									{
									default:
										num5 = ((!(dbConnection is SqlCeConnection)) ? ⴄႤ[135] : (ⴃႰ[200] - 13093));
										goto IL_055f;
									case 4:
										((IDisposable)(dbConnection as SqlCeConnection)).Dispose();
										break;
									case 5:
										break;
									}
									break;
									IL_055f:
									num4 = num5;
								}
							}
							switch (4)
							{
							}
							break;
						}
						}
					}
					catch (Exception ex)
					{
						Ⴐ.Error(ex.Message);
					}
					switch (3)
					{
					}
					break;
				}
			}
			finally
			{
				int num6 = 2;
				while (true)
				{
					int num7;
					switch (num6)
					{
					default:
						num7 = ((!flag) ? (ⴀႨ[193] - 56085) : 0);
						goto IL_05fe;
					case 0:
						Monitor.Exit(ⴄ);
						break;
					case 5:
						break;
					}
					break;
					IL_05fe:
					num6 = num7;
				}
			}
			switch (3)
			{
			}
			return;
		}
	}

	public DataRow[] GetDataRow(string sql, int nmbrDesired)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		bool flag = false;
		object ⴄ = default(object);
		Array array = default(Array);
		try
		{
			switch (4)
			{
			default:
				ႨႥ.Ⴍ(ⴄ = TalkCache.m_Ⴄ, ref flag, 382, 375);
				break;
			case 0:
				break;
			case 3:
				goto end_IL_005e;
			}
			array = DxSpotBlockCacheCfg.Ⴄ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴃ(), 'ɏ', 'Ȳ'), 0, '\u0326', 882), sql, SetStationQth.Ⴍ(null, 1687351812, 2, 1), '\u0324', '\u0363');
			end_IL_005e:;
		}
		finally
		{
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!flag) ? (ⴍႤ[330] - 8439) : 4);
					goto IL_0105;
				case 4:
					DxCmdMsgExt.ႨႠ(ⴄ, '©', 204);
					break;
				case 0:
				case 6:
					break;
				}
				break;
				IL_0105:
				num = num2;
			}
		}
		switch (3)
		{
		default:
			if ((array as DataRow[]).Length < nmbrDesired)
			{
				try
				{
					int num3 = 12;
					ICloneable cloneable = default(ICloneable);
					ISupportInitializeNotification supportInitializeNotification = default(ISupportInitializeNotification);
					int num5 = default(int);
					int num4 = default(int);
					while (true)
					{
						switch (num3)
						{
						default:
							SaveToDb();
							cloneable = ShowPrefixCalls.Ⴃ((object)ReplyMailHelp.Ⴄ(12, null, 1057161789, 1), (object)nmbrDesired, (object)SetStationClubHelp.Ⴍ(14, 3, 1747258258, null), 'ɮ', 580);
							num3 = 11;
							continue;
						case 11:
							num3 = ((CallBlockCacheCfg.Ⴜ(sql, 441, 472) <= 0) ? 14 : 6);
							continue;
						case 6:
							cloneable = AnnHelp.Ⴈ((string)cloneable, ႰႥ.Ⴅ(1, 'G', 952620694), LogEntry.Ⴄ(sql, 'Â', 232), 222, 'é');
							num3 = 14;
							continue;
						case 14:
							cloneable = ShowContestStationHelp.Ⴅ(cloneable as string, SetTalkCount.Ⴗ(0, null, 1267022170, typeof(WwvSpotArx)), ReplyMail.Ⴅ(6, nmbrDesired, 1217945223), 852, '\u030c');
							num3 = 13;
							continue;
						case 13:
						{
							supportInitializeNotification = new DataSet();
							DbDataAdapter dbDataAdapter = new SqlCeDataAdapter(sql, Ⴓ.Configuration.DbConnect);
							ShowDxFilter.Ⴄ((DbDataAdapter)(SqlCeDataAdapter)dbDataAdapter, Ⴃ(), ႨႨ.Ⴀ(nmbrDesired, 0, 1157903700), 'ǲ', 'ƨ');
							num3 = ⴀႣ[133] - 13711;
							continue;
						}
						case 0:
						case 7:
							num5 = DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitializeNotification, 'γ', 'ώ'), 0, 'Ƣ', 502), '¥', 165), (short)875, (short)822);
							num3 = ⴍႤ[71] - 50967;
							continue;
						case 1:
						case 4:
							array = new DataRow[num5];
							num4 = 0;
							num3 = ⴄႤ[333] - 238;
							continue;
						case 2:
						{
							object obj = ((DataSet)supportInitializeNotification).Tables[0].Rows[num4];
							(array as DataRow[])[num4] = obj as DataRow;
							num3 = ⴀႣ[105] - 53604;
							continue;
						}
						case 9:
							num4++;
							num3 = ⴃႠ[307] - 24455;
							continue;
						case 8:
							num3 = ((num4 < num5) ? (ⴃႥ[159] - 11631) : 3);
							continue;
						case 3:
						case 5:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Ⴐ.Error((ex as Exception).Message + ႰႥ.Ⴅ(1, '°', 952620211) + sql);
				}
			}
			return 2 switch
			{
				_ => (DataRow[])array, 
			};
		}
	}

	static TalkCache()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴐ = SkimmerValidSpot.Ⴐ(ReplyMail.Ⴅ(8, 8, 1217945264), 508, 481);
				break;
			case 4:
				break;
			case 1:
			case 2:
				TalkCache.m_Ⴄ = new object();
				return;
			case 3:
				return;
			}
			num = 1;
		}
	}
}
