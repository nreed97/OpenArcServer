using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcDatabase;

public sealed class DxMaintenance
{
	private static readonly ILog Ⴗ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(2, null, 1267014353, typeof(ႰႥ)), 487, 506);

	internal static void Purge(ArcServerCfg arcServerCfg)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			switch (3)
			{
			default:
			{
				SqlCeConnection sqlCeConnection = new SqlCeConnection(arcServerCfg.Configuration.DbConnect);
				try
				{
					int num = 3;
					PrecisionTimer precisionTimer = default(PrecisionTimer);
					string commandText = default(string);
					while (true)
					{
						switch (num)
						{
						default:
							precisionTimer = new PrecisionTimer();
							goto case 1;
						case 1:
						case 2:
						{
							ShowPrefixCallsHelp.Ⴗ(precisionTimer, 714, 651);
							string text = SetStationClubHelp.Ⴍ(15, 7, 1747262741, null);
							DateTime dateTime = ShowAnnHelp.Ⴅ('[', 106);
							commandText = ShowPrefixCalls.Ⴃ((object)text, (object)SetAnnWrap.Ⴃ(ref dateTime, -arcServerCfg.Caches.Dx.DbDaysToKeep, 495, 435), (object)ႨႨ.Ⴀ(12, 7, 1157903554), 'ź', 336);
							num = ⴄႭ[455] - 14;
							continue;
						}
						case 5:
						case 6:
						{
							SqlCeCommand sqlCeCommand = new SqlCeCommand(commandText, sqlCeConnection);
							SetAnnWrapHelp.Ⴀ((DbConnection)sqlCeConnection, 799, (short)796);
							SetAnnCountHelp.Ⴅ((DbCommand)sqlCeCommand, (short)605, 'Ȭ');
							num = ⴀႳ[240] - 19669;
							continue;
						}
						case 4:
							ByeHelp.Ⴄ(precisionTimer, 'Ǳ', 418);
							Ⴗ.Info(SetDxDefaultHelp.Ⴍ(new object[4]
							{
								precisionTimer,
								SetStationQth.Ⴍ(null, 1687354786, 6, 22),
								arcServerCfg.Caches.Dx.DbDaysToKeep,
								ShowSkimCtyHelp.Ⴍ(1216133499, 1, '$')
							}, '{', 18));
							break;
						}
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
							num3 = ((sqlCeConnection != null) ? 1 : (ⴅ[116] - ⴅ[310]));
							goto IL_01c8;
						case 1:
							((IDisposable)sqlCeConnection).Dispose();
							break;
						case 3:
						case 4:
						case 5:
							break;
						}
						break;
						IL_01c8:
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
			Ⴗ.Warn(SetTalkCount.Ⴗ(6, null, 1267022426, typeof(WxFullHelp)) + ex.Message);
		}
		switch (0)
		{
		}
	}

	internal static void Ⴐ(ArcServerCfg P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 0;
		try
		{
			int num2 = 5;
			ISupportInitializeNotification supportInitializeNotification = default(ISupportInitializeNotification);
			DbDataAdapter dbDataAdapter = default(DbDataAdapter);
			IEnumerable enumerable = default(IEnumerable);
			while (true)
			{
				switch (num2)
				{
				default:
					supportInitializeNotification = new DataSet();
					goto case 11;
				case 11:
				{
					IEquatable<string> equatable = SetStationClubHelp.Ⴍ(14, 8, 1747262773, null);
					dbDataAdapter = new SqlCeDataAdapter((string)equatable, P_0.Configuration.DbConnect);
					num2 = 6;
					continue;
				}
				case 6:
				case 12:
					ShowDxFilter.Ⴄ((DbDataAdapter)(dbDataAdapter as SqlCeDataAdapter), supportInitializeNotification as DataSet, SetStationClubHelp.Ⴍ(11, 0, 1747257822, null), 'Ɵ', 'ǅ');
					num2 = ⴅ[128] - 53;
					continue;
				case 3:
					enumerable = UserCacheCfg.Ⴃ(Top100CacheCfg.Ⴈ(qslinfoRequestBody.Ⴍ(ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(supportInitializeNotification as DataSet, 'ģ', 'Ş'), 0, '\u02db', 655), 'β', 946), 0, 'ˠ', 711), 0, 215, '\u0097'), '\u0344', 815);
					num2 = ⴀႳ[32] - 3203;
					continue;
				case 4:
					num2 = (SkimmerValidSpot.Ⴈ(enumerable as string, 89, 45) ? 1 : 7);
					continue;
				case 1:
					num = ShowVersion.Ⴄ(enumerable as string, 'Ñ', 'ã');
					num2 = ((num <= P_0.Caches.Dx.DbMaxSpots) ? 7 : (ⴀႨ[223] - 54342));
					continue;
				case 2:
				case 10:
					Ⴗ.Warn(ShowPrefixCalls.Ⴃ((object)SetStationClubHelp.Ⴍ(13, 2, 1747262809, null), (object)P_0.Caches.Dx.DbMaxSpots, (object)ReplyMailHelp.Ⴄ(11, null, 1057167193, 6), 'ȹ', 531));
					num2 = 13;
					continue;
				case 13:
					num2 = ((P_0.Caches.Dx.DbDaysToKeep <= 4) ? (ⴃႰ[10] - 36032) : (ⴃႠ[214] - 31375));
					continue;
				case 0:
					P_0.Caches.Dx.DbDaysToKeep--;
					Ⴗ.Warn(ReplyMail.Ⴅ(0, 14, 1217942309) + P_0.Caches.Dx.DbDaysToKeep);
					break;
				case 9:
					break;
				case 7:
					goto end_IL_0028;
				}
				Purge(P_0);
				break;
				continue;
				end_IL_0028:
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴗ.Error(ex.Message);
		}
		switch (3)
		{
		}
	}
}
