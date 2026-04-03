using System;
using System.Collections;
using System.Globalization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
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
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Dx;

public class DxSpotUser : DxSpotBase, IArcCmd
{
	private static readonly ILog Ⴄ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216134276, 4, '¶'), 457, 468);

	private void Ⴍ(NodeUserCmd P_0)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				if (base.IsEchoRequestOnly)
				{
					num = ⴍႤ[451] - 606;
					continue;
				}
				while (true)
				{
					P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetStationQth.Ⴍ(null, 1687354438, 7, 30), P_0.Rx.Msg, 549, 619));
					switch (ⴀႣ[325])
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 15403:
					case 15406:
					case 15407:
						break;
					case 15402:
					{
						IArcCmd arcCmd = new DxSpotUserHelp();
						((DxSpotUserHelp)arcCmd).Exec(P_0);
						return;
					}
					}
				}
			case 5:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetStationClubHelp.Ⴍ(0, 4, 1747262997, null), P_0.Rx.Msg, 945, 1023));
				goto case 3;
			case 3:
				num = 1;
				continue;
			case 1:
				obj = new DxTestHelp();
				break;
			case 0:
			case 2:
				break;
			}
			break;
		}
		((DxTestHelp)obj).Exec(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		try
		{
			int num = 17;
			object obj = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 79, 14);
					ႰႰ.Ⴈ(SetStationBeepHelp.Ⴓ(144, 163), ShowSkimCtyHelp.Ⴍ(1216134274, 2, 'õ'), '\u02c4', 740);
					num = 21;
					continue;
				case 21:
					num = ((!SetAnnDefault.Ⴍ(LogEntry.Ⴄ(cmd.Rx.Msg, 'Ƞ', 522), ShowSkimCtyHelp.Ⴍ(1216132986, 3, '÷'), 847, 797)) ? (ⴀႨ[125] - 14028) : 9);
					continue;
				case 9:
					base.IsEchoRequestOnly = true;
					goto case 16;
				case 16:
					num = ((!ByeHelp.Ⴍ(LogEntry.Ⴄ(SetDxFilter.Ⴀ(cmd.Rx.Msg, 110, '.'), 'ɰ', 602), ShowSkimCtyHelp.Ⴍ(1216132864, 2, '5'), 669, 762)) ? (ⴄႤ[131] - 191) : (ⴃႰ[73] - 48537));
					continue;
				case 10:
				{
					IArcCmd arcCmd = new DxHelp();
					(arcCmd as DxHelp).Exec(cmd);
					goto case 2;
				}
				case 2:
					num = 0;
					continue;
				case 11:
					num = (Ⴃ(cmd.Rx.Msg) ? 1 : 18);
					continue;
				case 1:
				{
					ShowDxOptionsHelp.Ⴍ(base.Dx, cmd.Ⴍ().Call, 388, 494);
					DateTime dateTime2 = ShowAnnHelp.Ⴅ('ʕ', 676);
					base.Date = ShowAnnOptionsHelp.Ⴗ(ref dateTime2, CallBlockCacheCfg.Ⴅ(null, 5, 62057702, null), 925, 921);
					num = ⴄႷ[23] - 32501;
					continue;
				}
				case 12:
				{
					DateTime dateTime = ShowAnnHelp.Ⴅ('Ϗ', 1022);
					base.Time = ShowAnnOptionsHelp.Ⴗ(ref dateTime, ႰႥ.Ⴅ(7, 'Ä', 952619388), 127, 123);
					num = ⴄႤ[111] - 232;
					continue;
				}
				case 8:
				{
					DxSpot dx = base.Dx;
					object obj3 = new string[5];
					((string[])obj3)[0] = base.Date;
					(obj3 as string[])[1] = SetTalkCount.Ⴗ(7, null, 1267022532, typeof(ႳႤ));
					((string[])obj3)[2] = SetTalkOutputHelp.Ⴍ(base.Time, 0, 2, 366, 317);
					(obj3 as string[])[3] = ShowSkimCtyHelp.Ⴍ(1216134124, 7, '0');
					((string[])obj3)[4] = Clear.Ⴄ(base.Time, 2, 'ϥ', 'ύ');
					ShowWx.Ⴅ(dx, SetAnnWrap.Ⴍ(ShowWwv.Ⴈ(obj3 as string[], 'Ʊ', 473), 390, 'ǉ'), 187, 143);
					num = ⴀႼ[51] - 158;
					continue;
				}
				case 6:
					DxClusterCacheCfg.Ⴗ(base.Dx, cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call, 932, 946);
						num = ⴐ[361] - ⴐ[100];
						continue;
					case 7:
						ShowQslInfoHelp.Ⴈ(base.Dx, qslinfoResponse.Ⴗ(cmd.Ⴍ().Call, CallBlockCacheCfg.Ⴅ(null, 3, 62058063, null), cmd.Ⴍ().Io.EndPoint, ReplyMail.Ⴅ(0, 7, 1217945008), 586, 'ȩ'), 636, 551);
						num = ⴍႭ[358] - 50455;
						continue;
					case 4:
						cmd.Tx.MsgType = MsgType.Dx;
						flag = ProcessSpot(cmd);
						ByeHelp.Ⴄ(obj as PrecisionTimer, 'ʦ', 757);
						num = ⴃႥ[215] - 7496;
						continue;
					case 13:
						num = ((!flag) ? 3 : 14);
						continue;
					case 14:
					{
						ILog ⴄ2 = Ⴄ;
						Array array2 = new object[4];
						(array2 as object[])[0] = (PrecisionTimer)obj;
						((object[])array2)[1] = cmd.Ⴍ().Call;
						(array2 as object[])[2] = SetStationClubHelp.Ⴍ(5, 6, 1747257862, null);
						((object[])array2)[3] = cmd.Tx.Msg[0];
						ⴄ2.Info(string.Concat((object[])array2));
						num = 20;
						continue;
					}
					case 15:
					case 20:
					{
						object obj2 = new Publisher();
						((Publisher)obj2).Process(cmd);
						num = 0;
						continue;
					}
					case 3:
					case 19:
					{
						ILog ⴄ = Ⴄ;
						Array array = new object[4];
						((object[])array)[0] = (PrecisionTimer)obj;
						((object[])array)[1] = cmd.Ⴍ().Call;
						(array as object[])[2] = SetStationClubHelp.Ⴍ(13, 7, 1747257863, null);
						(array as object[])[3] = cmd.Tx.Msg[0];
						ⴄ.Warn(string.Concat(array as object[]));
						num = 0;
						continue;
					}
					case 18:
						Ⴍ(cmd);
						break;
					case 0:
						break;
					}
					break;
				}
			}
			catch (Exception)
			{
				Ⴍ(cmd);
			}
			switch (4)
			{
			}
		}

		private bool Ⴃ(string P_0)
		{
			byte[] ⴐ = ႨႣ.Ⴐ;
			char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			char[] ⴀ = SetAnnChatRooms.Ⴀ;
			IEnumerable enumerable = default(IEnumerable);
			object obj = default(object);
			while (true)
			{
				P_0 = SetTalkDefault.Ⴃ(P_0, 213, 'ù');
				while (true)
				{
					IL_0088:
					string text = P_0;
					Array array = new char[1];
					(array as char[])[0] = ' ';
					Array array2 = Directory.Ⴓ(text, array as char[], 422, 496);
					int num = 7;
					while (true)
					{
						switch (num)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							num = 2;
							continue;
						case 2:
							break;
						case 11:
							goto IL_0088;
						case 7:
							num = ((SetDxArPc.Ⴈ((Array)(string[])array2, 0, 'ˊ', '\u02d3') <= 2) ? 16 : (ⴐ[131] - 177));
							continue;
						case 5:
							enumerable = (array2 as string[])[1];
							obj = ((string[])array2)[2];
							num = 0;
							continue;
						case 0:
						{
							int num3 = SetDxArPc.Ⴈ((Array)(string[])array2, 0, 'ß', 'Æ');
							ShowQrzHelp.ႤႤ[431] = (byte)((ShowQrzHelp.ႤႤ[431] * ShowQrzHelp.ႤႤ[24]) & 0x83);
							num = ((num3 <= 3) ? (ⴀႳ[180] - 40969) : 15);
							continue;
						}
						case 14:
						case 15:
						{
							int num2 = ShowNodes.Ⴄ(P_0, (string)obj, 459, 500);
							SetAnnDefaultHelp.Ⴀ(base.Dx, (num2 > -1) ? SetDxFilter.Ⴀ(Clear.Ⴄ(P_0, num2 + CallBlockCacheCfg.Ⴜ(obj as string, 133, 228), 'Ù', 'ñ'), 66, '\u0002') : string.Empty, '\u0379', '\u0319');
							goto case 6;
						}
						case 6:
							num = ((!ShowWwvHelp.Ⴗ(enumerable as string, 'ë', 207)) ? 12 : 3);
							continue;
						case 3:
							MircIo.Ⴐ(base.Dx, ShowGrayline.Ⴈ(enumerable as string, 456, 'ư'), 973, 923);
							num = 10;
							continue;
						case 10:
							base.Dx.Call = ((string)obj).ToUpper();
							return true;
						case 12:
							num = ((!UtilsNumeric.IsFloat((string)obj)) ? (ⴀ[279] - 14081) : (ⴄႷ[141] - 32621));
							continue;
						case 9:
							base.Dx.Freq = Convert.ToSingle(obj as string, new CultureInfo(SetStationClubHelp.Ⴍ(2, 7, 1747258246, null)));
							num = 4;
							continue;
						case 4:
						case 8:
							base.Dx.Call = ((string)enumerable).ToUpper();
							return true;
						case 1:
							return false;
						case 16:
							return false;
						}
						break;
					}
					break;
				}
			}
		}
	}
