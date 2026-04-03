using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Wwv;

public sealed class WwvSpotArx : WwvSpotBase, IArcCmd
{
	private static readonly ILog Ⴍ = SkimmerValidSpot.Ⴐ(ႰႥ.Ⴅ(5, '\u008d', 952620173), 323, 350);

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		try
		{
			int num = 8;
			object obj2 = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = new PrecisionTimer();
					goto case 4;
				case 4:
					ShowPrefixCallsHelp.Ⴗ(obj2 as PrecisionTimer, 227, 162);
					ShowHamHelp.Ⴃ(Wwv, cmd.Rx.Msg, 'ʐ', 696);
					num = 7;
					continue;
				case 7:
					flag = ProcessSpot(cmd);
					ByeHelp.Ⴄ(obj2 as PrecisionTimer, 'ư', 483);
					goto case 13;
				case 13:
					num = ⴀႣ[127] - 63449;
					continue;
				case 12:
					num = (flag ? 1 : 5);
					continue;
				case 1:
				{
					ILog ⴍ2 = Ⴍ;
					object obj4 = new object[4];
					(obj4 as object[])[0] = (PrecisionTimer)obj2;
					((object[])obj4)[1] = cmd.Ⴍ().Call;
					((object[])obj4)[2] = SetStationClubHelp.Ⴍ(9, 5, 1747257861, null);
					((object[])obj4)[3] = cmd.Tx.Msg[0];
					ⴍ2.Info(SetDxDefaultHelp.Ⴍ((object[])obj4, 'ɒ', 571));
					num = ⴃႥ[243] - 40668;
					continue;
				}
				case 3:
				{
					object obj3 = new Publisher();
					(obj3 as Publisher).Process(cmd);
					goto case 10;
				}
				case 10:
					num = ⴅ[6];
					continue;
				case 5:
					num = ((!ShowTalkOptionsHelp.Ⴍ(Wwv, '\u035c', 843)) ? 2 : (ⴄႷ[21] - 64079));
					continue;
				case 9:
					num = ((!ShowTalkOptionsHelp.Ⴍ(Wwv, 'ϩ', 1022)) ? (ⴃႠ[105] - ⴃႠ[105]) : 11);
					continue;
				case 11:
					num = (cmd.Ⴍ().Ⴅ().Ⴍ()
						.AppLog.LogWwvDupes ? 2 : 0);
					continue;
				case 2:
				{
					ILog ⴍ = Ⴍ;
					object obj = new object[4];
					(obj as object[])[0] = (PrecisionTimer)obj2;
					(obj as object[])[1] = cmd.Ⴍ().Call;
					(obj as object[])[2] = SetStationClubHelp.Ⴍ(3, 2, 1747257858, null);
					(obj as object[])[3] = cmd.Tx.Msg[0];
					ⴍ.Warn(SetDxDefaultHelp.Ⴍ((object[])obj, '\u0382', 1003));
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
			Ⴍ.Warn(SetStationQth.Ⴍ(null, 1687351426, 8, 9) + cmd.Rx.Msg + ႰႥ.Ⴅ(2, '0', 952620208) + ex.Message);
		}
		switch (1)
		{
		}
	}
}
