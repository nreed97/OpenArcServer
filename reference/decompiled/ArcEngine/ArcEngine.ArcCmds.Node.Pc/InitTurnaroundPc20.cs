using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.QslInfo;
using log4net;

namespace ArcEngine.ArcCmds.Node.Pc;

public sealed class InitTurnaroundPc20 : IArcCmd
{
	private static readonly ILog Ⴓ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('ð', 985807233, 7), 801, 828);

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		try
		{
			int num = 0;
			object obj2 = default(object);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					Ⴓ.Info(qslinfoResponse.Ⴗ(ReplyMailHelp.Ⴄ(14, null, 1057164020, 7), cmd.Ⴍ().Call, SetStationClubHelp.Ⴍ(4, 7, 1747257863, null), cmd.Rx.Msg, 282, 'Ź'));
					num = 3;
					continue;
				case 3:
					obj2 = new PcxxNodeUser();
					goto case 4;
				case 4:
				case 6:
					((PcxxNodeUser)obj2).BuildAndSend(cmd);
					InitCompletePc22.Send(cmd);
					cmd.Tx.DistroType = DistroType.ToNode;
					num = ⴄႷ[71] - 34093;
					continue;
				case 5:
					obj = new Publisher();
					break;
				case 2:
					break;
				}
				break;
			}
			(obj as Publisher).Process(cmd);
		}
		catch (Exception ex)
		{
			Ⴓ.Warn(SkimmerSpotBins.Ⴈ(ex, 764, 722));
		}
		switch (1)
		{
		}
	}
}
