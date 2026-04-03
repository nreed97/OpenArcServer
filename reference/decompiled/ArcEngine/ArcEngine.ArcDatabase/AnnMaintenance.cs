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
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcDatabase;

public sealed class AnnMaintenance
{
	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('\u0013', 985805925, 7), 820, 809);

	internal static void Purge(ArcServerCfg arcServerCfg)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
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
					while (true)
					{
						switch (num)
						{
						default:
						{
							precisionTimer = new PrecisionTimer();
							ShowPrefixCallsHelp.Ⴗ(precisionTimer, 550, 615);
							string text = SetStationClubHelp.Ⴍ(1, 6, 1747263446, null);
							DateTime dateTime = ShowAnnHelp.Ⴅ('\u02f5', 708);
							commandText = ShowPrefixCalls.Ⴃ((object)text, (object)SetAnnWrap.Ⴃ(ref dateTime, -arcServerCfg.Caches.Ann.DbDaysToKeep, 623, 563), (object)ႨႨ.Ⴀ(4, 2, 1157903559), '\u0325', 783);
							num = ⴃႰ[105] - 25538;
							continue;
						}
						case 2:
						{
							SqlCeCommand sqlCeCommand = new SqlCeCommand(commandText, sqlCeConnection);
							SetAnnWrapHelp.Ⴀ((DbConnection)sqlCeConnection, 989, (short)990);
							SetAnnCountHelp.Ⴅ((DbCommand)sqlCeCommand, (short)317, 'Ō');
							num = ⴀ[451] - 7733;
							continue;
						}
						case 1:
						case 5:
						case 6:
							ByeHelp.Ⴄ(precisionTimer, '\u02c4', 663);
							Ⴅ.Info(SetDxDefaultHelp.Ⴍ(new object[4]
							{
								precisionTimer,
								SetStationQth.Ⴍ(null, 1687354527, 0, 28),
								arcServerCfg.Caches.Ann.DbDaysToKeep,
								ShowSkimCtyHelp.Ⴍ(1216133502, 4, '\u0012')
							}, 'τ', 941));
							break;
						case 3:
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
							num3 = ((sqlCeConnection == null) ? (ⴄႤ[81] - 32) : (ⴃႠ[384] - 36015));
							goto IL_01e6;
						case 3:
						case 5:
							((IDisposable)sqlCeConnection).Dispose();
							break;
						case 4:
							break;
						}
						break;
						IL_01e6:
						num2 = num3;
					}
				}
				switch (0)
				{
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			Ⴅ.Warn(SetTalkCount.Ⴗ(8, null, 1267022420, typeof(Top100CacheCfg)) + ex.Message);
		}
		switch (2)
		{
		}
	}
}
