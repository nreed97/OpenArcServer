using System;
using System.Data.Common;
using System.Data.SqlServerCe;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcDatabase;

public sealed class LogMaintenance
{
	private static readonly ILog Ⴈ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('ú', 985805694, 0), 259, 286);

	internal static void Purge(ArcServerCfg arcServerCfg)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		try
		{
			switch (0)
			{
			default:
			{
				SqlCeConnection sqlCeConnection = new SqlCeConnection(arcServerCfg.Configuration.DbConnect);
				try
				{
					int num = 1;
					PrecisionTimer precisionTimer = default(PrecisionTimer);
					string commandText = default(string);
					SqlCeCommand sqlCeCommand = default(SqlCeCommand);
					while (true)
					{
						switch (num)
						{
						default:
						{
							precisionTimer = new PrecisionTimer();
							ShowPrefixCallsHelp.Ⴗ(precisionTimer, 977, 912);
							string text = SetStationClubHelp.Ⴍ(15, 3, 1747262862, null);
							DateTime dateTime = ShowAnnHelp.Ⴅ('ģ', 274);
							commandText = ShowPrefixCalls.Ⴃ((object)text, (object)SetAnnWrap.Ⴃ(ref dateTime, -arcServerCfg.Caches.Log.DbDaysToKeep, 405, 457), (object)ႨႨ.Ⴀ(13, 0, 1157903557), 'ǟ', 501);
							num = 3;
							continue;
						}
						case 3:
							sqlCeCommand = new SqlCeCommand(commandText, sqlCeConnection);
							goto case 5;
						case 5:
							SetAnnWrapHelp.Ⴀ((DbConnection)sqlCeConnection, 85, (short)86);
							SetAnnCountHelp.Ⴅ((DbCommand)sqlCeCommand, (short)1015, 'Ά');
							num = 4;
							continue;
						case 4:
							ByeHelp.Ⴄ(precisionTimer, 'ϧ', 948);
							break;
						case 6:
							break;
						case 0:
							goto end_IL_0039;
						}
						Ⴈ.Info(SetDxDefaultHelp.Ⴍ(new object[4]
						{
							precisionTimer,
							SetStationQth.Ⴍ(null, 1687354878, 2, 18),
							arcServerCfg.Caches.Log.DbDaysToKeep,
							ShowSkimCtyHelp.Ⴍ(1216133502, 4, '9')
						}, 'Ë', 162));
						break;
						continue;
						end_IL_0039:
						break;
					}
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
							num3 = ((sqlCeConnection == null) ? 2 : (ⴍႤ[188] - 53874));
							goto IL_01b6;
						case 0:
						case 5:
							((IDisposable)sqlCeConnection).Dispose();
							break;
						case 2:
							break;
						}
						break;
						IL_01b6:
						num2 = num3;
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
			Ⴈ.Warn(SetTalkCount.Ⴗ(5, null, 1267022425, typeof(ႳႰ)) + ex.Message);
		}
		switch (4)
		{
		}
	}
}
