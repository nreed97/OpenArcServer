using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.AnnWx;

public sealed class AnnWxArx : AnnWxSpotBase, IArcCmd
{
	private static readonly ILog Ⴃ = SkimmerValidSpot.Ⴐ(SetStationQth.Ⴍ(null, 1687351548, 3, 28), 614, 635);

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			int num = 3;
			object obj = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 351, 286);
					ShowTalkOptions.Ⴈ(AnnWx, cmd.Rx.Msg, 'ʏ', 642);
					num = ⴍႭ[25] - 22815;
					continue;
				case 1:
					flag = ProcessSpot(cmd);
					ByeHelp.Ⴄ(obj as PrecisionTimer, '\u009a', 201);
					num = ⴄႷ[128] - 3827;
					continue;
				case 9:
					num = ((!flag) ? (ⴀႼ[2] / 9) : 10);
					continue;
				case 10:
				{
					ILog ⴃ2 = Ⴃ;
					object obj2 = new object[4];
					(obj2 as object[])[0] = (PrecisionTimer)obj;
					((object[])obj2)[1] = cmd.Ⴍ().Call;
					(obj2 as object[])[2] = SetStationClubHelp.Ⴍ(3, 3, 1747257859, null);
					(obj2 as object[])[3] = cmd.Tx.Msg[0];
					ⴃ2.Info(SetDxDefaultHelp.Ⴍ(obj2 as object[], 'Ͼ', 919));
					num = 8;
					continue;
				}
				case 8:
				{
					object obj3 = new Publisher();
					(obj3 as Publisher).Process(cmd);
					goto case 5;
				}
				case 5:
					num = 0;
					continue;
				case 2:
					num = ((!qslinfoRequest.Ⴗ(AnnWx, 1008, 993)) ? 13 : 7);
					continue;
				case 7:
					num = (qslinfoRequest.Ⴗ(AnnWx, 693, 676) ? 6 : 0);
					continue;
				case 6:
				case 12:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
						.AppLog.LogAnnWxDupes) ? (ⴀႳ[324] - 47327) : 13);
					continue;
				case 13:
				{
					ILog ⴃ = Ⴃ;
					Array array = new object[4];
					((object[])array)[0] = (PrecisionTimer)obj;
					(array as object[])[1] = cmd.Ⴍ().Call;
					((object[])array)[2] = SetStationClubHelp.Ⴍ(10, 6, 1747257862, null);
					(array as object[])[3] = cmd.Tx.Msg[0];
					ⴃ.Warn(SetDxDefaultHelp.Ⴍ(array as object[], 'ϫ', 898));
					break;
				}
				case 0:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴃ.Warn(SetStationQth.Ⴍ(null, 1687351438, 4, 25) + cmd.Rx.Msg + ႰႥ.Ⴅ(6, ')', 952620212) + ex.Message);
		}
		switch (0)
		{
		}
	}
}
