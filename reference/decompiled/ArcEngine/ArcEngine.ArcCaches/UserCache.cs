using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
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
using ArcEngine.ArcDatabase;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcServerConfig.Io;
using ArcEngine.ContestProcessing;
using ArcEngine.QslInfo;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class UserCache
{
	private static readonly ILog m_Ⴍ;

	private static readonly object m_Ⴃ;

	internal DataSet Ⴗ;

	private ObjectManager m_Ⴍ = ObjectManager.Instance;

	private SetDxFilterHelp.Ⴈ m_Ⴓ = new SetDxFilterHelp.Ⴈ();

	public UserCache()
	{
		this.Ⴗ = new DataSet();
		ByeHelp.Ⴈ(DirectoryHelp.Ⴀ(this.Ⴗ, '\u009e', 'ã'), new DataTable(ႰႥ.Ⴅ(1, '\\', 952620248)), 166, 193);
		bool ⴐ = false;
		this.m_Ⴓ.Ⴐ = ⴐ;
		SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.Ⴗ, 'Ų', 'ď'), 0, 'ȱ', 613), 757, 726), new DataColumn(SetTalkCount.Ⴗ(0, null, 1267022179, typeof(SetStationGridHelp)), typeof(string)), 200, 'È');
		SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.Ⴗ, 'ĉ', 'Ŵ'), 0, 'ϓ', 903), 578, 609), new DataColumn(CallBlockCacheCfg.Ⴅ(null, 1, 62058105, null), typeof(string)), 920, 'Θ');
		SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.Ⴗ, 'ä', '\u0099'), 0, 'ɋ', 543), 134, 165), new DataColumn(ႰႥ.Ⴅ(0, '&', 952620237), typeof(DateTime)), 177, '±');
		bool flag = false;
		object ⴃ = default(object);
		try
		{
			ႨႥ.Ⴍ(ⴃ = UserCache.m_Ⴃ, ref flag, 520, 513);
			try
			{
				object obj = new PrecisionTimer();
				ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 594, 531);
				DbDataAdapter dbDataAdapter = new SqlCeDataAdapter(ShowWxHelp.Ⴍ('a', 985808540, 5), this.m_Ⴍ.Ⴍ().Configuration.LocalDbConnect);
				ShowDxFilter.Ⴄ((DbDataAdapter)(dbDataAdapter as SqlCeDataAdapter), this.Ⴗ, ႰႥ.Ⴅ(1, 'V', 952620248), '\u02d7', 'ʍ');
				ByeHelp.Ⴄ(obj as PrecisionTimer, 'J', 25);
				ILog ⴍ = UserCache.m_Ⴍ;
				object obj2 = new object[4];
				(obj2 as object[])[0] = obj as PrecisionTimer;
				(obj2 as object[])[1] = ReplyMailHelp.Ⴄ(8, null, 1057161823, 1);
				(obj2 as object[])[2] = this.Ⴗ.Tables[0].Rows.Count;
				(obj2 as object[])[3] = SetStationQth.Ⴍ(null, 1687351686, 7, 3);
				ⴍ.Info(string.Concat(obj2 as object[]));
			}
			catch (Exception ex)
			{
				UserCache.m_Ⴍ.Error(ex.Message);
			}
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(ⴃ);
			}
		}
	}

	internal void Ⴐ(ArcConnect P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		bool flag = false;
		object ⴃ = default(object);
		try
		{
			int num = 0;
			Array array = default(Array);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
				{
					ႨႥ.Ⴍ(ⴃ = UserCache.m_Ⴃ, ref flag, 864, 873);
					bool ⴐ = true;
					this.m_Ⴓ.Ⴐ = ⴐ;
					goto case 2;
				}
				case 2:
					num = ⴃႥ[371] - 56157;
					continue;
				case 6:
					array = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.Ⴗ, 'ũ', 'Ĕ'), 0, '϶', 930), AnnHelp.Ⴈ(ႨႨ.Ⴀ(3, 0, 1157903805), P_0.Call, ႨႨ.Ⴀ(8, 6, 1157903555), 749, '\u02da'), '\n', 55);
					num = ⴄႷ[79] - 55486;
					continue;
				case 7:
					num = (((array as DataRow[]).Length <= 0) ? (ⴀႼ[113] * 4) : (ⴍႭ[325] - 18840));
					continue;
				case 1:
					Ⴐ((array as DataRow[])[0], P_0);
					goto case 9;
				case 9:
					num = 5;
					continue;
				case 8:
					obj = SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.Ⴗ, 'z', '\a'), 0, 'Â', 150).NewRow();
					num = 3;
					continue;
				case 3:
					Ⴐ(obj as DataRow, P_0);
					this.Ⴗ.Tables[0].Rows.Add((DataRow)obj);
					break;
				case 5:
					break;
				}
				break;
			}
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
					num3 = ((!flag) ? 6 : 3);
					goto IL_01c0;
				case 2:
				case 3:
					Monitor.Exit(ⴃ);
					break;
				case 6:
					break;
				}
				break;
				IL_01c0:
				num2 = num3;
			}
		}
		switch (2)
		{
		}
	}

	private static void Ⴐ(DataRow P_0, ArcConnect P_1)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				ArcConnectObj.Ⴓ(P_0, SetTalkCount.Ⴗ(5, null, 1267022182, typeof(DxSpotMirc)), (object)P_1.Call, 'ˇ', '\u02d4');
				num = ⴄႭ[304] - 235;
				break;
			case 3:
				ArcConnectObj.Ⴓ(P_0, CallBlockCacheCfg.Ⴅ(null, 2, 62058106, null), (object)P_1.Cfg.Serialize(), '\u008b', '\u0098');
				goto case 0;
			case 0:
				num = ⴀႣ[245] - 18182;
				break;
			case 2:
			case 4:
				P_0[ႰႥ.Ⴅ(7, 'º', 952620234)] = DateTime.UtcNow;
				return;
			case 1:
				return;
			}
		}
	}

	internal ArcUserCfg Ⴃ(ArcConnect P_0)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		bool flag = false;
		object ⴃ = default(object);
		object obj2 = default(object);
		try
		{
			int num = 9;
			object obj = default(object);
			Array array = default(Array);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴃ = UserCache.m_Ⴃ, ref flag, 633, 624);
					obj = new ArcUserCfg();
					num = 0;
					continue;
				case 0:
					SetStationBeepHelp.Ⴅ(ShowAnnOptionsHelp.Ⴃ((ArcUserCfg)obj, 18, 104), Ⴅ(P_0), 693, 764);
					num = 5;
					continue;
				case 5:
					SetTalkOutput.Ⴍ(TalkHelp.Ⴃ(obj as ArcUserCfg, 836, 877), Ⴓ(P_0), 674, 'ʊ');
					num = 4;
					continue;
				case 4:
				case 8:
					CallHistoryOverride.Ⴍ(SetStationEmailHelp.Ⴈ(obj as ArcUserCfg, 604, 616), Ⴍ(P_0), 'ɭ', 516);
					num = ⴀႣ[275] - 22527;
					continue;
				case 6:
					SetStationQthHelp.Ⴀ((ArcUserCfg)obj, P_0.Call, 214, '\u008b');
					array = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.Ⴗ, 'Œ', 'į'), 0, '\u031a', 846), AnnHelp.Ⴈ(ႨႨ.Ⴀ(2, 2, 1157903807), P_0.Call, ႨႨ.Ⴀ(13, 2, 1157903559), 500, 'ǃ'), 'à', 221);
					goto case 10;
				case 10:
					num = 3;
					continue;
				case 3:
					if (((DataRow[])array).Length > 0)
					{
						num = 7;
						continue;
					}
					break;
				case 7:
				{
					IComparable<string> comparable = ((DataRow[])array)[0][CallBlockCacheCfg.Ⴅ(null, 3, 62058107, null)].ToString();
					try
					{
						switch (4)
						{
						default:
							obj = ((string)comparable).Deserialize<ArcUserCfg>();
							break;
						case 1:
						case 2:
							break;
						}
					}
					catch (Exception ex)
					{
						UserCache.m_Ⴍ.Error((ex as Exception).Message);
					}
					switch (3)
					{
					default:
						obj2 = obj as ArcUserCfg;
						goto end_IL_0036;
					case 5:
						goto end_IL_0036;
					case 2:
						break;
					case 4:
						goto end_IL_0036;
					}
					break;
				}
				}
				obj2 = obj as ArcUserCfg;
				break;
				continue;
				end_IL_0036:
				break;
			}
		}
		finally
		{
			int num2 = 6;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 2 : 5);
					goto IL_028e;
				case 5:
					Monitor.Exit(ⴃ);
					break;
				case 2:
				case 4:
					break;
				}
				break;
				IL_028e:
				num2 = num3;
			}
		}
		return 4 switch
		{
			_ => obj2 as ArcUserCfg, 
		};
	}

	internal bool Ⴀ(string P_0)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		bool flag = false;
		object ⴃ = default(object);
		bool flag2;
		try
		{
			int num = 1;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴃ = UserCache.m_Ⴃ, ref flag, 58, 51);
					obj = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.Ⴗ, 'p', '\r'), 0, 'ǵ', 417), AnnHelp.Ⴈ(ႰႥ.Ⴅ(2, '\u0018', 952620293), P_0, ႨႨ.Ⴀ(4, 1, 1157903556), 547, 'Ȕ'), '\u035c', 865);
					break;
				case 4:
					break;
				case 2:
					flag2 = ((DataRow[])obj).Length > 0;
					goto end_IL_003b;
				}
				num = ⴐ[166] - 214;
				continue;
				end_IL_003b:
				break;
			}
		}
		finally
		{
			int num2 = 5;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? (ⴄႷ[100] - 20023) : 0);
					goto IL_0111;
				case 0:
				case 3:
					Monitor.Exit(ⴃ);
					break;
				case 4:
				case 6:
					break;
				}
				break;
				IL_0111:
				num2 = num3;
			}
		}
		return 3 switch
		{
			_ => flag2, 
		};
	}

	public void SaveToDb()
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 3;
		object ⴃ = default(object);
		object obj = default(object);
		object obj2 = default(object);
		ICloneable cloneable = default(ICloneable);
		DbCommand dbCommand2 = default(DbCommand);
		DbCommand dbCommand = default(DbCommand);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_Ⴓ.Ⴐ)
				{
					goto IL_0058;
				}
				break;
			case 0:
			{
				bool ⴐ = false;
				this.m_Ⴓ.Ⴐ = ⴐ;
				goto case 4;
			}
			case 4:
			{
				bool flag = false;
				try
				{
					switch (2)
					{
					default:
						ႨႥ.Ⴍ(ⴃ = UserCache.m_Ⴃ, ref flag, 723, 730);
						try
						{
							switch (4)
							{
							default:
							{
								DbConnection dbConnection = new SqlCeConnection(this.m_Ⴍ.Ⴍ().Configuration.LocalDbConnect);
								try
								{
									int num2 = 11;
									while (true)
									{
										switch (num2)
										{
										default:
											obj = new PrecisionTimer();
											ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 51, 114);
											goto case 5;
										case 5:
											SetAnnWrapHelp.Ⴀ((DbConnection)(dbConnection as SqlCeConnection), 79, (short)76);
											num2 = 13;
											continue;
										case 13:
										{
											obj2 = new SqlCeDataAdapter();
											cloneable = new SqlCeCommand(SetStationQth.Ⴍ(null, 1687351733, 4, 13), dbConnection as SqlCeConnection);
											char num4 = ⴀႳ[111];
											ShowQrzHelp.ႤႤ[25] = (byte)((ShowQrzHelp.ႤႤ[25] | ShowQrzHelp.ႤႤ[115]) & 0xB);
											num2 = num4 - 53577;
											continue;
										}
										case 3:
											NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 568, 591), CallBlockCacheCfg.Ⴅ(null, 6, 62058094, null), SqlDbType.NVarChar, 12, SetTalkCount.Ⴗ(4, null, 1267022183, typeof(ShowSun)), 985, 1016);
											num2 = ⴀႼ[96] * 4;
											continue;
										case 16:
											NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 693, 706), ShowWxHelp.Ⴍ('Ð', 985808631, 5), SqlDbType.NVarChar, 4000, CallBlockCacheCfg.Ⴅ(null, 5, 62058109, null), 986, 1019);
											num2 = 14;
											continue;
										case 1:
										case 14:
											NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 802, 853), CallBlockCacheCfg.Ⴅ(null, 0, 62058000, null), SqlDbType.DateTime, 0, ႰႥ.Ⴅ(1, 'C', 952620236), 270, 303);
											num2 = ⴄႭ[261] - 87;
											continue;
										case 9:
											qslinfoSoapClient.Ⴄ(obj2 as SqlCeDataAdapter, (SqlCeCommand)cloneable, 'ǻ', 424);
											goto case 0;
										case 0:
											dbCommand2 = new SqlCeCommand(ႰႥ.Ⴅ(5, '\u0018', 952620309), (SqlCeConnection)dbConnection);
											num2 = 7;
											continue;
										case 7:
											NodeUserCmd.Ⴈ(ShowStation.Ⴓ(dbCommand2 as SqlCeCommand, 587, 572), CallBlockCacheCfg.Ⴅ(null, 7, 62058095, null), SqlDbType.NVarChar, 12, SetTalkCount.Ⴗ(6, null, 1267022181, typeof(ShowQrzHelp)), 1005, 972);
											num2 = 15;
											continue;
										case 15:
											NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)dbCommand2, 191, 200), ShowWxHelp.Ⴍ('\a', 985808627, 1), SqlDbType.NVarChar, 4000, CallBlockCacheCfg.Ⴅ(null, 1, 62058105, null), 876, 845);
											num2 = 8;
											continue;
										case 8:
											NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)dbCommand2, 353, 278), CallBlockCacheCfg.Ⴅ(null, 5, 62058005, null), SqlDbType.DateTime, 0, ႰႥ.Ⴅ(3, 'J', 952620238), 881, 848);
											num2 = 12;
											continue;
										case 12:
											DirectoryBulletinHelp.Ⴄ((SqlCeDataAdapter)obj2, (SqlCeCommand)dbCommand2, 966, 982);
											dbCommand = new SqlCeCommand(ShowWxHelp.Ⴍ('\u0093', 985808617, 8), dbConnection as SqlCeConnection);
											num2 = 2;
											continue;
										case 2:
											NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)dbCommand, 655, 760), CallBlockCacheCfg.Ⴅ(null, 2, 62058090, null), SqlDbType.NVarChar, 12, SetTalkCount.Ⴗ(3, null, 1267022176, typeof(DirectorySubject)), 993, 960);
											num2 = ⴀ[48] - 49713;
											continue;
										case 6:
											StationHelp.Ⴍ(obj2 as SqlCeDataAdapter, (SqlCeCommand)dbCommand, 'Ϝ', 926);
											num3 = ((SqlCeDataAdapter)obj2).Update(this.Ⴗ.Tables[0]);
											num2 = ⴀႣ[140] - 24887;
											continue;
										case 4:
										{
											((PrecisionTimer)obj).Stop();
											ILog ⴍ = UserCache.m_Ⴍ;
											Array array = new object[4];
											(array as object[])[0] = obj as PrecisionTimer;
											(array as object[])[1] = ႰႥ.Ⴅ(6, 'S', 952620763);
											((object[])array)[2] = num3;
											((object[])array)[3] = SetStationQth.Ⴍ(null, 1687351833, 2, 2);
											ⴍ.Info(string.Concat(array as object[]));
											break;
										}
										}
										break;
									}
								}
								finally
								{
									int num5 = 0;
									while (true)
									{
										int num6;
										switch (num5)
										{
										default:
											num6 = ((!(dbConnection is SqlCeConnection)) ? (ⴃႠ[3] - 45662) : 3);
											goto IL_0566;
										case 1:
										case 3:
										case 6:
											((IDisposable)(dbConnection as SqlCeConnection)).Dispose();
											break;
										case 2:
											break;
										}
										break;
										IL_0566:
										num5 = num6;
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
							UserCache.m_Ⴍ.Error(ex.Message);
						}
						switch (2)
						{
						}
						break;
					}
				}
				finally
				{
					int num7 = 1;
					while (true)
					{
						int num8;
						switch (num7)
						{
						default:
							num8 = ((!flag) ? (ⴀႣ[271] - 32459) : 2);
							goto IL_0607;
						case 2:
							Monitor.Exit(ⴃ);
							break;
						case 5:
						case 6:
							break;
						}
						break;
						IL_0607:
						num7 = num8;
					}
				}
				break;
			}
			}
			break;
			IL_0058:
			num = 0;
		}
		switch (0)
		{
		}
	}

	private string Ⴅ(ArcConnect P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		IComparable<string> comparable = default(IComparable<string>);
		object obj = default(object);
		while (true)
		{
			int num = ((P_0.Io != null) ? ⴅ[145] : 5);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႨ[39] - 33473;
					continue;
				case 2:
				case 6:
					break;
				case 5:
					return string.Empty;
				case 7:
					comparable = P_0.Io.IoCfg.DefaultDxFilter;
					comparable = qslinfoRequest.Ⴃ(comparable as string, P_0.Call, 796, 814);
					num = 3;
					continue;
				case 3:
					obj = P_0.Ⴅ().Ⴀ().Ⴃ()
						.FormatSqlFilter(comparable as string);
					goto case 1;
				case 1:
					return (string)obj;
				}
				break;
			}
		}
	}

	private string Ⴓ(ArcConnect P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			int num = ((P_0.Io != null) ? (ⴀႨ[202] - ⴀႨ[202]) : (ⴃႠ[275] - 31802));
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
				case 7:
					return string.Empty;
				case 0:
				case 1:
				{
					IConvertible defaultAnnFilter = P_0.Io.IoCfg.DefaultAnnFilter;
					comparable = P_0.Ⴅ().Ⴀ().Ⴄ()
						.FormatSqlFilter((string)defaultAnnFilter);
					num = 2;
					continue;
				}
				case 2:
				case 3:
				case 6:
					return comparable as string;
				}
				break;
			}
		}
	}

	private string Ⴍ(ArcConnect P_0)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		object defaultWxFilter = default(object);
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			int num = ((P_0.Io == null) ? (ⴃႥ[421] - 8496) : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႣ[235] - 11080;
					continue;
				case 4:
				case 5:
					break;
				case 7:
					return string.Empty;
				case 0:
				case 1:
					defaultWxFilter = P_0.Io.IoCfg.DefaultWxFilter;
					goto case 2;
				case 2:
					equatable = P_0.Ⴅ().Ⴀ().Ⴄ()
						.FormatSqlFilter(defaultWxFilter as string);
					num = 3;
					continue;
				case 3:
					return equatable as string;
				}
				break;
			}
		}
	}

	public void ValidateCfg()
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		object obj = new PrecisionTimer();
		ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 831, 894);
		bool flag = false;
		object ⴃ = default(object);
		try
		{
			switch (1)
			{
			default:
				ႨႥ.Ⴍ(ⴃ = UserCache.m_Ⴃ, ref flag, 162, 171);
				try
				{
					int num = 2;
					object obj4 = default(object);
					object obj3 = default(object);
					int num3 = default(int);
					object obj2 = default(object);
					IEnumerable enumerable = default(IEnumerable);
					while (true)
					{
						int num2;
						switch (num)
						{
						default:
							obj4 = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.Ⴗ, '\u0337', '\u034a'), 0, 'ċ', 351), SetStationClubHelp.Ⴍ(2, 0, 1747258264, null), 'ʪ', 663);
							num = 0;
							continue;
						case 0:
							obj3 = obj4 as DataRow[];
							num3 = 0;
							goto case 7;
						case 3:
						case 6:
							break;
						case 5:
						{
							IConvertible convertible = UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(obj2 as DataRow, SetTalkCount.Ⴗ(6, null, 1267022181, typeof(AccessHelper)), 366, 'Ġ'), 'ª', 193);
							try
							{
								switch (1)
								{
								default:
									(enumerable as string).Deserialize<ArcUserCfg>();
									break;
								}
							}
							catch (Exception)
							{
								IoDevicesCfg.Ⴃ((DataRow)obj2, 504, 'ƀ');
								bool ⴐ = true;
								this.m_Ⴓ.Ⴐ = ⴐ;
								UserCache.m_Ⴍ.Warn(ShowUsersHelp.Ⴅ(ShowWxHelp.Ⴍ('¢', 985808579, 3), (string)convertible, 454, 392));
							}
							num2 = 5;
							goto IL_01ec;
						}
						case 7:
							{
								if (num3 < ((DataRow[])obj3).Length)
								{
									break;
								}
								num2 = 2;
								goto IL_01ec;
							}
							IL_01ec:
							while (true)
							{
								switch (num2)
								{
								default:
									goto IL_020f;
								case 1:
								case 3:
									break;
								case 2:
								case 4:
								case 6:
									goto end_IL_01ec;
								}
								goto case 7;
								IL_020f:
								num3++;
								num2 = ⴄႤ[51] / 9;
								continue;
								end_IL_01ec:
								break;
							}
							goto end_IL_0066;
						}
						obj2 = (obj3 as DataRow[])[num3];
						enumerable = UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ((DataRow)obj2, CallBlockCacheCfg.Ⴅ(null, 7, 62058111, null), 811, '\u0365'), '\u02e5', 654);
						num = 5;
						continue;
						end_IL_0066:
						break;
					}
				}
				catch (Exception)
				{
				}
				switch (2)
				{
				}
				break;
			}
		}
		finally
		{
			int num4 = 4;
			while (true)
			{
				int num5;
				switch (num4)
				{
				default:
					num5 = ((!flag) ? 3 : (ⴍႭ[281] - 23365));
					goto IL_0293;
				case 2:
					Monitor.Exit(ⴃ);
					break;
				case 3:
					break;
				}
				break;
				IL_0293:
				num4 = num5;
			}
		}
		int num6 = 3;
		while (true)
		{
			switch (num6)
			{
			default:
				(obj as PrecisionTimer).Stop();
				UserCache.m_Ⴍ.Info(string.Concat(obj as PrecisionTimer, ReplyMail.Ⴅ(3, 3, 1217945002), this.Ⴗ.Tables[0].Rows.Count));
				break;
			case 1:
				break;
			case 2:
			case 5:
				SaveToDb();
				return;
			case 4:
				return;
			}
			num6 = 5;
		}
	}

	internal List<string> Ⴗ()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		ValidateCfg();
		object obj = new List<string>();
		bool flag = false;
		object ⴃ = default(object);
		try
		{
			switch (1)
			{
			default:
				ႨႥ.Ⴍ(ⴃ = UserCache.m_Ⴃ, ref flag, 68, 77);
				try
				{
					int num = 1;
					Array array = default(Array);
					object obj2 = default(object);
					int num2 = default(int);
					object obj4 = default(object);
					IEquatable<string> equatable = default(IEquatable<string>);
					while (true)
					{
						switch (num)
						{
						default:
							array = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.Ⴗ, 'ƺ', 'Ǉ'), 0, 'Ú', 142), SetStationClubHelp.Ⴍ(0, 6, 1747258270, null), 'ν', 896);
							num = 10;
							continue;
						case 10:
							obj2 = (DataRow[])array;
							num2 = 0;
							goto case 8;
						case 8:
							num = ⴐ[81] - 126;
							continue;
						case 3:
							obj4 = ((DataRow[])obj2)[num2];
							goto case 4;
						case 4:
							equatable = UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(obj4 as DataRow, CallBlockCacheCfg.Ⴅ(null, 3, 62058107, null), 656, '\u02de'), '\u0357', 828);
							num = ⴅ[213] - 248;
							continue;
						case 6:
						{
							object obj3 = ((string)equatable).Deserialize<ArcUserCfg>();
							(obj as List<string>).Add(ShowSkimmerHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ((ArcUserCfg)obj3, 169, 211), 324, 342));
							goto case 5;
						}
						case 5:
							num = 7;
							continue;
						case 7:
							num2++;
							num = 9;
							continue;
						case 9:
							num = ((num2 < (obj2 as DataRow[]).Length) ? (ⴅ[162] - 83) : (ⴃႠ[84] - 58613));
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					UserCache.m_Ⴍ.Error(ex as Exception);
				}
				switch (3)
				{
				}
				break;
			}
		}
		finally
		{
			int num3 = 6;
			while (true)
			{
				int num4;
				switch (num3)
				{
				default:
					num4 = ((!flag) ? (ⴄႷ[50] - 56634) : (ⴄႤ[144] - 51));
					goto IL_0261;
				case 0:
				case 4:
					Monitor.Exit(ⴃ);
					break;
				case 3:
				case 5:
					break;
				}
				break;
				IL_0261:
				num3 = num4;
			}
		}
		return 2 switch
		{
			_ => obj as List<string>, 
		};
	}

	static UserCache()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				UserCache.m_Ⴃ = new object();
				return;
			}
			UserCache.m_Ⴍ = SkimmerValidSpot.Ⴐ(ႨႨ.Ⴀ(8, 1, 1157903689), 577, 604);
			num = 1;
		}
	}
}
