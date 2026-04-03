using System;
using System.Globalization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcIo.Mirc;
using ArcEngine.ArcIo.ReverseBeacon;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Dx;

public sealed class DxSpotRevBcnWeb : DxSpotBase
{
	private static readonly ILog Ⴄ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('N', 985805568, 1), 590, 595);

	public bool Process(NodeUserCmd cmd, RevBcnSpot spot)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		bool flag = false;
		bool result = default(bool);
		try
		{
			int num = 6;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 585, 520);
					num = (LogCacheCfg.Ⴗ(spot.Freq, 98, 99) ? 7 : (ⴀ[512] - 58707));
					continue;
				case 11:
					result = true;
					return result;
				case 7:
					SetAnnDefaultHelp.Ⴀ(base.Dx, spot.Call, 'ʄ', '\u02db');
					ShowDxOptionsHelp.Ⴍ(base.Dx, ShowUsersHelp.Ⴅ(spot.Spotter, ႨႨ.Ⴀ(8, 7, 1157903734), 649, 711), 303, 325);
					num = 9;
					continue;
				case 9:
					MircIo.Ⴐ(base.Dx, SetWwvDefaultHelp.Ⴗ(spot.Freq, (IFormatProvider)new CultureInfo(SetStationClubHelp.Ⴍ(11, 8, 1747258249, null)), 343, 'Ī'), 141, 219);
					num = 8;
					continue;
				case 8:
					DxClusterCacheCfg.Ⴗ(base.Dx, ႰႥ.Ⴅ(6, 'á', 952616018), 456, 478);
					num = 18;
					continue;
				case 18:
				{
					DxSpot dx2 = base.Dx;
					Array array4 = new string[5];
					(array4 as string[])[0] = spot.Snr;
					(array4 as string[])[1] = SetStationQth.Ⴍ(null, 1687354555, 4, 1);
					(array4 as string[])[2] = spot.Wpm;
					((string[])array4)[3] = ShowSkimCtyHelp.Ⴍ(1216132753, 8, '¤');
					(array4 as string[])[4] = spot.T;
					SetAnnDefaultHelp.Ⴀ(dx2, ShowWwv.Ⴈ((string[])array4, '\u02d6', 702), 'û', '\u009b');
					num = ⴀ[282] - 54190;
					continue;
				}
				case 16:
				{
					string text = Clear.Ⴄ(spot.Utc, 6, 'ǂ', 'Ǫ');
					string text2 = SetTalkCount.Ⴗ(0, null, 1267022531, typeof(ႳႠ.ႷႥ));
					DateTime dateTime = ShowAnnHelp.Ⴅ('Ƒ', 416);
					base.Date = ShowPrefixCalls.Ⴃ((object)text, (object)text2, (object)SetAnnChatRoomsHelp.Ⴄ(ref dateTime, 467, 490), 'ɶ', 604);
					num = ⴄႷ[66] - 17232;
					continue;
				}
				case 10:
					base.Time = SetTalkOutputHelp.Ⴍ(spot.Utc, 0, 4, 547, 624);
					num = ⴀႣ[355] - 29155;
					continue;
				case 13:
				{
					DxSpot dx = base.Dx;
					Array array3 = new string[5];
					(array3 as string[])[0] = base.Date;
					(array3 as string[])[1] = SetTalkCount.Ⴗ(3, null, 1267022528, typeof(AnnCache));
					((string[])array3)[2] = SetTalkOutputHelp.Ⴍ(base.Time, 0, 2, 860, 783);
					((string[])array3)[3] = ShowSkimCtyHelp.Ⴍ(1216134124, 7, 'Ö');
					(array3 as string[])[4] = Clear.Ⴄ(base.Time, 2, '\u0083', '«');
					ShowWx.Ⴅ(dx, SetAnnWrap.Ⴍ(ShowWwv.Ⴈ((string[])array3, '\u02f7', 671), 7, 'H'), 291, 279);
					num = 5;
					continue;
				}
				case 5:
				{
					ShowQslInfoHelp.Ⴈ(base.Dx, ShowWxHelp.Ⴍ('È', 985805966, 2), 285, 326);
					byte num2 = ⴅ[423];
					DirectoryBulletin.ႠႨ[187] = (DirectoryBulletin.ႠႨ[187] + DirectoryBulletin.ႠႨ[3]) & 0x4B;
					num = num2 - 79;
					continue;
				}
				case 1:
					cmd.Tx.MsgType = MsgType.DxLocal;
					goto case 14;
				case 14:
					flag = ProcessSpot(cmd);
					ByeHelp.Ⴄ(obj as PrecisionTimer, 'Ɂ', 530);
					num = 2;
					continue;
				case 0:
				case 2:
					num = ((!flag) ? 15 : (ⴀႼ[54] - 66));
					continue;
				case 12:
				{
					ILog ⴄ2 = Ⴄ;
					Array array2 = new object[4];
					(array2 as object[])[0] = obj as PrecisionTimer;
					((object[])array2)[1] = cmd.Ⴍ().Call;
					(array2 as object[])[2] = SetStationClubHelp.Ⴍ(12, 5, 1747257861, null);
					(array2 as object[])[3] = cmd.Tx.Msg[0];
					ⴄ2.Info(SetDxDefaultHelp.Ⴍ((object[])array2, 'Ͻ', 916));
					num = 3;
					continue;
				}
				case 15:
				{
					ILog ⴄ = Ⴄ;
					Array array = new object[4];
					(array as object[])[0] = (PrecisionTimer)obj;
					(array as object[])[1] = cmd.Ⴍ().Call;
					(array as object[])[2] = SetStationClubHelp.Ⴍ(6, 0, 1747257856, null);
					((object[])array)[3] = cmd.Tx.Msg[0];
					ⴄ.Warn(string.Concat((object[])array));
					break;
				}
				case 3:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ILog ⴄ3 = Ⴄ;
			object obj2 = new string[6];
			((string[])obj2)[0] = SetStationQth.Ⴍ(null, 1687351437, 7, 24);
			((string[])obj2)[1] = cmd.Rx.Msg;
			((string[])obj2)[2] = ReplyMail.Ⴅ(2, 5, 1217945262);
			((string[])obj2)[3] = CultureInfo.CurrentCulture.Name;
			((string[])obj2)[4] = ႰႥ.Ⴅ(0, '\u0011', 952620210);
			((string[])obj2)[5] = ex.Message;
			ⴄ3.Warn(string.Concat((string[])obj2));
		}
		switch (5)
		{
		default:
			return flag;
		case 0:
		case 2:
			return result;
		}
	}
}
