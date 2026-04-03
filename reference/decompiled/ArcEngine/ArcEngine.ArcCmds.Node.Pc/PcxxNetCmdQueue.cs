using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wwv;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Node.Pc;

public sealed class PcxxNetCmdQueue : IArcCmd
{
	private static readonly ILog Ⴓ = SkimmerValidSpot.Ⴐ(ႰႥ.Ⴅ(5, '1', 952620266), 225, 252);

	public void Exec(NodeUserCmd cmd)
	{
		try
		{
			cmd.Ⴍ().Ⴅ().Ⴀ()
				.Ⴗ()
				.Ⴀ(cmd);
		}
		catch (Exception ex)
		{
			ILog ⴓ = Ⴓ;
			Array array = new string[5];
			(array as string[])[0] = cmd.Ⴍ().Call;
			((string[])array)[1] = SetStationClubHelp.Ⴍ(14, 3, 1747257859, null);
			(array as string[])[2] = cmd.Rx.Msg;
			((string[])array)[3] = ႰႥ.Ⴅ(2, 'y', 952620208);
			((string[])array)[4] = SkimmerSpotBins.Ⴈ(ex as Exception, 408, 438);
			ⴓ.Warn(ShowWwv.Ⴈ((string[])array, 'ʎ', 742));
		}
	}
}
