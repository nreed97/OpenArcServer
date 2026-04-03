using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.QslInfo;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Node.Pc;

public sealed class InitCompletePc22 : IArcCmd
{
	private static readonly ILog Ⴍ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(2, null, 1267014719, typeof(SetStationEmail)), 869, 888);

	public void Exec(NodeUserCmd cmd)
	{
		try
		{
			ShowDxHelp.Ⴄ(30000, 551, 533);
			ILog ⴍ = Ⴍ;
			object obj = new string[6];
			((string[])obj)[0] = SetStationQth.Ⴍ(null, 1687353100, 7, 29);
			((string[])obj)[1] = cmd.Ⴍ().Call;
			((string[])obj)[2] = SetStationClubHelp.Ⴍ(14, 8, 1747257864, null);
			(obj as string[])[3] = cmd.Rx.Msg;
			(obj as string[])[4] = ReplyMail.Ⴅ(4, 3, 1217941216);
			((string[])obj)[5] = cmd.Ⴍ().Call;
			ⴍ.Info(ShowWwv.Ⴈ(obj as string[], 'ʂ', 746));
		}
		catch (Exception ex)
		{
			Ⴍ.Warn(ex.Message);
		}
	}

	public static void Send(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			case 3:
				num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
					.PcxxCfg.LogOutboundNodeUser) ? 4 : (ⴀႣ[30] - 13987));
				continue;
			case 0:
			case 5:
				Ⴍ.Info(qslinfoResponse.Ⴗ(SetStationQth.Ⴍ(null, 1687353100, 7, 23), cmd.Ⴍ().Call, ReplyMail.Ⴅ(4, 0, 1217944104), obj as string, 947, 'ϐ'));
				return;
			case 1:
			case 4:
				return;
			}
			obj = ႨႨ.Ⴀ(1, 7, 1157899110);
			cmd.Tx.Msg.Add((string)obj);
			num = ⴄႤ[334] - ⴄႤ[63];
		}
	}
}
