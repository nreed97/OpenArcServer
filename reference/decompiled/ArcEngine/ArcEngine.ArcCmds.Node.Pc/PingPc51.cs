using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Node.Pc;

public sealed class PingPc51 : IArcCmd
{
	private static readonly ILog Ⴍ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('\u0087', 985808351, 5), 582, 603);

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		try
		{
			int num = 12;
			object obj = default(object);
			object obj3 = default(object);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 832, 769);
					cmd.Tx.DistroType = DistroType.ToNode;
					num = ⴀ[200] - 61363;
					continue;
				case 3:
				{
					string msg = cmd.Rx.Msg;
					Array array2 = new char[1];
					(array2 as char[])[0] = '^';
					obj3 = Directory.Ⴓ(msg, array2 as char[], 880, 806);
					num = 7;
					continue;
				}
				case 4:
				case 7:
				{
					object obj4 = ((string[])obj3)[1];
					num = ((!ByeHelp.Ⴍ((string)obj4, cmd.Ⴍ().Io.IoCfg.ConnectAs, 163, 196)) ? 2 : 8);
					continue;
				}
				case 8:
					obj2 = new string[5];
					(obj2 as string[])[0] = ShowSkimCtyHelp.Ⴍ(1216133770, 1, 'o');
					goto case 11;
				case 11:
					num = ⴀႼ[2] - 17;
					continue;
				case 1:
					((string[])obj2)[1] = ((string[])obj3)[2];
					((string[])obj2)[2] = SetStationQth.Ⴍ(null, 1687351528, 7, 31);
					num = 6;
					continue;
				case 6:
					((string[])obj2)[3] = cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call;
					((string[])obj2)[4] = ShowSkimCtyHelp.Ⴍ(1216133780, 7, '\u00b8');
					num = 5;
					continue;
				case 5:
				{
					IComparable<string> comparable = ShowWwv.Ⴈ(obj2 as string[], 'Ʃ', 449);
					cmd.Tx.Msg.Add((string)comparable);
					goto case 10;
				}
				case 10:
					num = 0;
					continue;
				case 0:
				{
					ByeHelp.Ⴄ((PrecisionTimer)obj, 'ĸ', 363);
					ILog ⴍ = Ⴍ;
					Array array = new object[4];
					((object[])array)[0] = obj as PrecisionTimer;
					(array as object[])[1] = cmd.Ⴍ().Call;
					(array as object[])[2] = SetStationClubHelp.Ⴍ(5, 4, 1747257860, null);
					((object[])array)[3] = cmd.Tx.Msg[0];
					ⴍ.Info(SetDxDefaultHelp.Ⴍ((object[])array, 'ȶ', 607));
					break;
				}
				case 2:
					break;
				}
				break;
			}
			object obj5 = new Publisher();
			((Publisher)obj5).Process(cmd);
		}
		catch (Exception ex)
		{
			Ⴍ.Warn(SetStationQth.Ⴍ(null, 1687351426, 8, 29) + cmd.Rx.Msg + ႰႥ.Ⴅ(8, 'Ð', 952620218) + ex.Message);
		}
		switch (0)
		{
		}
	}
}
