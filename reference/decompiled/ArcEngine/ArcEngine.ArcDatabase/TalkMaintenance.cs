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

public sealed class TalkMaintenance
{
	private static readonly ILog Ⴍ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('\u0096', 985808786, 3), 780, 785);

	internal static void Purge(ArcServerCfg arcServerCfg)
	{
		try
		{
			switch (1)
			{
			default:
			{
				SqlCeConnection sqlCeConnection = new SqlCeConnection(arcServerCfg.Configuration.DbConnect);
				try
				{
					int num = 6;
					PrecisionTimer precisionTimer = default(PrecisionTimer);
					string commandText = default(string);
					while (true)
					{
						switch (num)
						{
						default:
						{
							precisionTimer = new PrecisionTimer();
							ShowPrefixCallsHelp.Ⴗ(precisionTimer, 607, 542);
							string text = SetStationClubHelp.Ⴍ(2, 8, 1747258011, null);
							DateTime dateTime = ShowAnnHelp.Ⴅ('ß', 238);
							commandText = ShowPrefixCalls.Ⴃ((object)text, (object)SetAnnWrap.Ⴃ(ref dateTime, -arcServerCfg.Caches.Talk.DbDaysToKeep, 271, 339), (object)ႨႨ.Ⴀ(0, 2, 1157903559), 'a', 75);
							num = 2;
							continue;
						}
						case 2:
						case 3:
						case 5:
						{
							SqlCeCommand sqlCeCommand = new SqlCeCommand(commandText, sqlCeConnection);
							SetAnnWrapHelp.Ⴀ((DbConnection)sqlCeConnection, 686, (short)685);
							SetAnnCountHelp.Ⴅ((DbCommand)sqlCeCommand, (short)569, 'Ɉ');
							num = 4;
							continue;
						}
						case 4:
							ByeHelp.Ⴄ(precisionTimer, '\u0349', 794);
							Ⴍ.Info(SetDxDefaultHelp.Ⴍ(new object[4]
							{
								precisionTimer,
								SetStationQth.Ⴍ(null, 1687351403, 8, 2),
								arcServerCfg.Caches.Talk.DbDaysToKeep,
								ShowSkimCtyHelp.Ⴍ(1216133501, 7, 'Ú')
							}, 'Ȃ', 619));
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
							num3 = ((sqlCeConnection == null) ? 5 : 4);
							goto IL_01a2;
						case 3:
						case 4:
							((IDisposable)sqlCeConnection).Dispose();
							break;
						case 5:
							break;
						}
						break;
						IL_01a2:
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
			Ⴍ.Warn(SetTalkCount.Ⴗ(4, null, 1267022424, typeof(ႥႭ)) + ex.Message);
		}
		switch (3)
		{
		}
	}
}
