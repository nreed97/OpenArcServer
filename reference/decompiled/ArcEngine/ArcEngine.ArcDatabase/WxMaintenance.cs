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

public sealed class WxMaintenance
{
	private static readonly ILog Ⴃ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('W', 985807786, 6), 902, 923);

	internal static void Purge(ArcServerCfg arcServerCfg)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		try
		{
			switch (2)
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
							ShowPrefixCallsHelp.Ⴗ(precisionTimer, 488, 425);
							string text = SetStationClubHelp.Ⴍ(11, 6, 1747257785, null);
							DateTime dateTime = ShowAnnHelp.Ⴅ('\\', 109);
							commandText = ShowPrefixCalls.Ⴃ((object)text, (object)SetAnnWrap.Ⴃ(ref dateTime, -arcServerCfg.Caches.Wx.DbDaysToKeep, 154, 198), (object)ႨႨ.Ⴀ(2, 0, 1157903557), 'ŷ', 349);
							num = 4;
							continue;
						}
						case 4:
						{
							SqlCeCommand sqlCeCommand = new SqlCeCommand(commandText, sqlCeConnection);
							SetAnnWrapHelp.Ⴀ((DbConnection)sqlCeConnection, 482, (short)481);
							SetAnnCountHelp.Ⴅ((DbCommand)sqlCeCommand, (short)938, 'ϛ');
							num = 0;
							continue;
						}
						case 0:
							ByeHelp.Ⴄ(precisionTimer, '\u0013', 64);
							break;
						case 3:
							break;
						case 1:
						case 5:
							goto end_IL_0039;
						}
						Ⴃ.Info(SetDxDefaultHelp.Ⴍ(new object[4]
						{
							precisionTimer,
							SetStationQth.Ⴍ(null, 1687352660, 0, 14),
							arcServerCfg.Caches.Wx.DbDaysToKeep,
							ShowSkimCtyHelp.Ⴍ(1216133502, 4, '¼')
						}, 'ɗ', 574));
						break;
						continue;
						end_IL_0039:
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
							num3 = ((sqlCeConnection == null) ? (ⴐ[254] / 8) : 2);
							goto IL_01a5;
						case 2:
							((IDisposable)sqlCeConnection).Dispose();
							break;
						case 0:
							break;
						}
						break;
						IL_01a5:
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
			Ⴃ.Warn(SetTalkCount.Ⴗ(8, null, 1267022420, typeof(ႰႭ)) + ex.Message);
		}
		switch (3)
		{
		}
	}
}
