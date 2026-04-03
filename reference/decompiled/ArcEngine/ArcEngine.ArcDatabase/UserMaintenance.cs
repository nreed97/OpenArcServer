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
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcDatabase;

public sealed class UserMaintenance
{
	private static readonly ILog Ⴐ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('T', 985808192, 1), 102, 123);

	internal static void Purge(ArcServerCfg arcServerCfg)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		try
		{
			switch (4)
			{
			default:
			{
				SqlCeConnection sqlCeConnection = new SqlCeConnection(arcServerCfg.Configuration.LocalDbConnect);
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
							goto case 2;
						case 2:
						{
							ShowPrefixCallsHelp.Ⴗ(precisionTimer, 523, 586);
							string text = SetStationClubHelp.Ⴍ(7, 8, 1747258350, null);
							DateTime dateTime = ShowAnnHelp.Ⴅ('\u0334', 773);
							commandText = ShowPrefixCalls.Ⴃ((object)text, (object)SetStationPhoneHelp.Ⴄ(ref dateTime, -arcServerCfg.Caches.User.DbYears, 904, 976), (object)ႨႨ.Ⴀ(3, 1, 1157903556), 'Κ', 944);
							num = ⴀႼ[136];
							continue;
						}
						case 5:
						{
							SqlCeCommand sqlCeCommand = new SqlCeCommand(commandText, sqlCeConnection);
							SetAnnWrapHelp.Ⴀ((DbConnection)sqlCeConnection, 824, (short)827);
							SetAnnCountHelp.Ⴅ((DbCommand)sqlCeCommand, (short)651, '\u02fa');
							num = 1;
							continue;
						}
						case 1:
							ByeHelp.Ⴄ(precisionTimer, 'Ħ', 373);
							break;
						case 4:
							break;
						}
						break;
					}
					Ⴐ.Info(SetDxDefaultHelp.Ⴍ(new object[4]
					{
						precisionTimer,
						SetStationClubHelp.Ⴍ(10, 7, 1747258114, null),
						arcServerCfg.Caches.User.DbYears,
						SetTalkCount.Ⴗ(2, null, 1267023829, typeof(ShowNodes))
					}, 'ǔ', 445));
				}
				finally
				{
					int num2 = 3;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = ((sqlCeConnection == null) ? ⴐ[204] : (ⴀႣ[231] - 27015));
							goto IL_01d7;
						case 4:
							((IDisposable)sqlCeConnection).Dispose();
							break;
						case 2:
						case 5:
						case 6:
							break;
						}
						break;
						IL_01d7:
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
			Ⴐ.Warn(SetTalkCount.Ⴗ(0, null, 1267022428, typeof(SkimmerServerCache)) + ex.Message);
		}
		switch (1)
		{
		}
	}
}
