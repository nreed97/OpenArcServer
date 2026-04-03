using System;
using System.Globalization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.Talk;
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

namespace ArcEngine.ArcCmds.Dx;

public sealed class DxSpotArx : DxSpotBase, IArcCmd
{
	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216133525, 1, 'L'), 487, 506);

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		try
		{
			int num = 13;
			object obj = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 376, 313);
					ႰႰ.Ⴈ(SetStationBeepHelp.Ⴓ(742, 725), ShowSkimCtyHelp.Ⴍ(1216133523, 7, '\v'), 'ɐ', 624);
					goto case 0;
				case 0:
					num = ⴍႭ[89] - 16551;
					continue;
				case 5:
				{
					ShowDxOptionsHelp.Ⴍ(base.Dx, cmd.Rx.Msg, 931, 975);
					DateTime dateTime = TalkSpotHelp.Ⴈ(base.Dx, 438, 'Ǉ');
					base.Time = ShowAnnOptionsHelp.Ⴗ(ref dateTime, ႰႥ.Ⴅ(7, 'ô', 952619388), 334, 330);
					num = ⴃႰ[89] - 30446;
					continue;
				}
				case 8:
				{
					DateTime dateTime2 = TalkSpotHelp.Ⴈ(base.Dx, 29, 'l');
					base.Date = ShowAnnOptionsHelp.Ⴗ(ref dateTime2, CallBlockCacheCfg.Ⴅ(null, 1, 62057698, null), 618, 622);
					num = 1;
					continue;
				}
				case 1:
					cmd.Tx.MsgType = MsgType.Dx;
					flag = ProcessSpot(cmd);
					ByeHelp.Ⴄ(obj as PrecisionTimer, '\u001c', 79);
					num = 12;
					continue;
				case 12:
					num = ((!flag) ? (ⴃႥ[204] - 3271) : 11);
					continue;
				case 11:
				{
					ILog ⴅ2 = Ⴅ;
					Array array2 = new object[4];
					(array2 as object[])[0] = (PrecisionTimer)obj;
					((object[])array2)[1] = cmd.Ⴍ().Call;
					((object[])array2)[2] = SetStationClubHelp.Ⴍ(9, 4, 1747257860, null);
					((object[])array2)[3] = cmd.Tx.Msg[0];
					ⴅ2.Info(SetDxDefaultHelp.Ⴍ(array2 as object[], 'š', 264));
					num = 2;
					continue;
				}
				case 2:
				{
					object obj2 = new Publisher();
					(obj2 as Publisher).Process(cmd);
					num = ⴃႥ[142] - 54042;
					continue;
				}
				case 3:
					num = ((!SetAnnDefaultHelp.Ⴅ(base.Dx, 850, 875)) ? (ⴀႼ[113] * 5) : 15);
					continue;
				case 7:
				case 15:
					num = ((!SetAnnDefaultHelp.Ⴅ(base.Dx, 399, 438)) ? 4 : 14);
					continue;
				case 14:
					num = ((!cmd.Ⴍ().Ⴅ().Ⴍ()
						.AppLog.LogDxDupes) ? 4 : 10);
					continue;
				case 9:
				case 10:
				{
					ILog ⴅ = Ⴅ;
					Array array = new object[4];
					((object[])array)[0] = (PrecisionTimer)obj;
					(array as object[])[1] = cmd.Ⴍ().Call;
					((object[])array)[2] = SetStationClubHelp.Ⴍ(15, 4, 1747257860, null);
					(array as object[])[3] = cmd.Tx.Msg[0];
					ⴅ.Warn(SetDxDefaultHelp.Ⴍ(array as object[], 'ĝ', 372));
					break;
				}
				case 4:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ILog ⴅ3 = Ⴅ;
			object obj3 = new string[6];
			(obj3 as string[])[0] = SetStationQth.Ⴍ(null, 1687351434, 0, 30);
			((string[])obj3)[1] = cmd.Rx.Msg;
			(obj3 as string[])[2] = ReplyMail.Ⴅ(6, 7, 1217945258);
			((string[])obj3)[3] = CultureInfo.CurrentCulture.Name;
			((string[])obj3)[4] = ႰႥ.Ⴅ(2, 'C', 952620208);
			(obj3 as string[])[5] = ex.Message;
			ⴅ3.Warn(string.Concat((string[])obj3));
		}
		switch (1)
		{
		}
	}
}
