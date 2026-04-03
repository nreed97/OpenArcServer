using System;
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
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Wwv;

public sealed class WwvSpotPc23 : WwvSpotBase, IArcCmd
{
	private static readonly ILog Ⴄ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('e', 985808755, 1), 649, 660);

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		try
		{
			int num = 8;
			object obj = default(object);
			object obj2 = default(object);
			IEquatable<string> equatable = default(IEquatable<string>);
			IConvertible convertible = default(IConvertible);
			object obj3 = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
				{
					obj = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 539, 602);
					string msg = cmd.Rx.Msg;
					Array array3 = new char[1];
					((char[])array3)[0] = '^';
					obj2 = Directory.Ⴓ(msg, array3 as char[], 920, 974);
					num = ⴃႠ[1] - 1385;
					continue;
				}
				case 17:
					num = ((((string[])obj2).Length != 11) ? 11 : 19);
					continue;
				case 19:
					equatable = SetDxFilter.Ⴀ(((string[])obj2)[1], 920, 'Ϙ');
					convertible = SetDxFilter.Ⴀ(((string[])obj2)[2], 25, 'Y');
					num = ⴀႼ[37];
					continue;
				case 25:
					obj3 = new CultureInfo(SetTalkCount.Ⴗ(5, null, 1267022542, typeof(ShowSkimmer.ႥႨ)), useUserOverride: true);
					num = ⴃႥ[408] - 41611;
					continue;
				case 24:
					ShowHeading.Ⴄ(Wwv, SetStationNeeds.Ⴓ(qslinfoResponse.Ⴗ(equatable as string, SetTalkCount.Ⴗ(7, null, 1267022532, typeof(ႷႭ)), convertible as string, SetStationClubHelp.Ⴍ(15, 3, 1747257869, null), 435, 'ǐ'), (IFormatProvider)obj3, 'ʳ', 722), 432, 436);
					num = 0;
					continue;
				case 0:
					ShowHamHelp.Ⴃ(Wwv, SetDxFilter.Ⴀ(((string[])obj2)[3], 282, 'Ś'), '\u0316', 817);
					num = ⴀ[428] - 53747;
					continue;
				case 10:
					SetStationHereHelp.Ⴀ(Wwv, SetDxFilter.Ⴀ(((string[])obj2)[4], 808, '\u0368'), 975, 'Ό');
					num = ⴅ[177] - ⴅ[195];
					continue;
				case 15:
					ShowQslInfoHelp.Ⴍ(Wwv, SetDxFilter.Ⴀ(((string[])obj2)[5], 219, '\u009b'), 975, 943);
					goto case 2;
				case 2:
					num = 6;
					continue;
				case 6:
					ႰႥ.Ⴐ(Wwv, (obj2 as string[])[6], 203, 'á');
					num = 14;
					continue;
				case 14:
					SetStationHereHelp.Ⴀ(Wwv, ((string[])obj2)[7], 77, '\t');
					num = ⴀႼ[2];
					continue;
				case 18:
					ႰႥ.Ⴐ(Wwv, (obj2 as string[])[8], 653, 'ʦ');
					goto case 1;
				case 1:
					num = 9;
					continue;
				case 9:
					ShowHam.Ⴗ(Wwv, cmd.Ⴍ().Call, 190, 240);
					cmd.Tx.Pcxx = cmd.Rx.Msg;
					goto case 7;
				case 7:
					num = 16;
					continue;
				case 16:
					flag = ProcessSpot(cmd);
					ByeHelp.Ⴄ((PrecisionTimer)obj, 'í', 190);
					num = 20;
					continue;
				case 20:
					num = ((!flag) ? (ⴀႳ[190] - 51868) : (ⴍႭ[34] - 15417));
					continue;
				case 21:
				{
					ILog ⴄ2 = Ⴄ;
					Array array2 = new object[4];
					((object[])array2)[0] = obj as PrecisionTimer;
					((object[])array2)[1] = cmd.Ⴍ().Call;
					(array2 as object[])[2] = SetStationClubHelp.Ⴍ(8, 5, 1747257861, null);
					(array2 as object[])[3] = cmd.Tx.Msg[0];
					ⴄ2.Info(SetDxDefaultHelp.Ⴍ((object[])array2, 'ɞ', 567));
					num = ⴄႭ[568];
					continue;
				}
				case 12:
				{
					object obj4 = new Publisher();
					(obj4 as Publisher).Process(cmd);
					num = 23;
					continue;
				}
				case 22:
					num = ((!ShowTalkOptionsHelp.Ⴍ(Wwv, 'ϱ', 998)) ? 13 : 5);
					continue;
				case 5:
					num = ((!ShowTalkOptionsHelp.Ⴍ(Wwv, 'õ', 226)) ? 23 : (ⴀႨ[122] - 31854));
					continue;
				case 3:
				{
					bool logWwvDupes = cmd.Ⴍ().Ⴅ().Ⴍ()
						.AppLog.LogWwvDupes;
					ShowWwvOptionsHelp.ႣႥ[35] = (char)((ShowWwvOptionsHelp.ႣႥ[35] * ShowWwvOptionsHelp.ႣႥ[120]) & 0x46);
					num = ((!logWwvDupes) ? 23 : (ⴀႨ[148] - 33942));
					continue;
				}
				case 13:
				{
					ILog ⴄ = Ⴄ;
					Array array = new object[4];
					((object[])array)[0] = obj as PrecisionTimer;
					((object[])array)[1] = cmd.Ⴍ().Call;
					((object[])array)[2] = SetStationClubHelp.Ⴍ(12, 5, 1747257861, null);
					((object[])array)[3] = cmd.Tx.Msg[0];
					ⴄ.Warn(string.Concat(array as object[]));
					num = 23;
					continue;
				}
				case 11:
					Ⴄ.Info(cmd.Rx.Msg);
					break;
				case 23:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴄ.Warn(SetStationQth.Ⴍ(null, 1687351433, 3, 8) + cmd.Rx.Msg + ႰႥ.Ⴅ(6, 'Ü', 952620212) + ex.Message);
		}
		switch (4)
		{
		}
	}
}
