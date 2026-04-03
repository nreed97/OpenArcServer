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
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcDatabase;

public sealed class WwvMaintenance
{
	private static readonly ILog Ⴃ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('*', 985806504, 0), 428, 433);

	internal static void Purge(ArcServerCfg arcServerCfg)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		try
		{
			switch (2)
			{
			default:
			{
				SqlCeConnection sqlCeConnection = new SqlCeConnection(arcServerCfg.Configuration.DbConnect);
				try
				{
					int num = 4;
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
							ShowPrefixCallsHelp.Ⴗ(precisionTimer, 498, 435);
							string text = SetStationClubHelp.Ⴍ(7, 3, 1747261926, null);
							DateTime dateTime = ShowAnnHelp.Ⴅ('K', 122);
							commandText = ShowPrefixCalls.Ⴃ((object)text, (object)SetAnnWrap.Ⴃ(ref dateTime, -arcServerCfg.Caches.Wwv.DbDaysToKeep, 863, 771), (object)ႨႨ.Ⴀ(9, 4, 1157903553), 'ͳ', 857);
							num = 2;
							continue;
						}
						case 0:
						case 2:
							sqlCeCommand = new SqlCeCommand(commandText, sqlCeConnection);
							SetAnnWrapHelp.Ⴀ((DbConnection)sqlCeConnection, 209, (short)210);
							goto case 3;
						case 3:
							SetAnnCountHelp.Ⴅ((DbCommand)sqlCeCommand, (short)435, 'ǂ');
							num = 6;
							continue;
						case 6:
							ByeHelp.Ⴄ(precisionTimer, 'Ƌ', 472);
							break;
						case 1:
							break;
						}
						break;
					}
					Ⴃ.Info(SetDxDefaultHelp.Ⴍ(new object[4]
					{
						precisionTimer,
						SetStationQth.Ⴍ(null, 1687354103, 5, 21),
						arcServerCfg.Caches.Wwv.DbDaysToKeep,
						ShowSkimCtyHelp.Ⴍ(1216133499, 1, '3')
					}, 'Λ', 1010));
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
							num3 = ((sqlCeConnection == null) ? 6 : (ⴃႥ[85] - 8294));
							goto IL_01b2;
						case 0:
						case 3:
							((IDisposable)sqlCeConnection).Dispose();
							break;
						case 6:
							break;
						}
						break;
						IL_01b2:
						num2 = num3;
					}
				}
				switch (2)
				{
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			Ⴃ.Warn(SetTalkCount.Ⴗ(4, null, 1267022424, typeof(SetDxExtensionHelp)) + ex.Message);
		}
		switch (2)
		{
		}
	}
}
