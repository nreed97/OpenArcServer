using System;
using System.Globalization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Wwv;

public sealed class WwvSpotPc27 : WwvSpotBase, IArcCmd
{
	private static readonly ILog Ⴃ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('ó', 985805678, 3), 1, 28);

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		try
		{
			int num = 12;
			Array array = default(Array);
			IEquatable<string> equatable = default(IEquatable<string>);
			ICloneable cloneable = default(ICloneable);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
				{
					string msg = cmd.Rx.Msg;
					object obj3 = new char[1];
					(obj3 as char[])[0] = '^';
					array = Directory.Ⴓ(msg, (char[])obj3, 228, 178);
					num = 4;
					continue;
				}
				case 4:
					num = ((((string[])array).Length == 11) ? 1 : 9);
					continue;
				case 1:
					equatable = (array as string[])[1];
					cloneable = (array as string[])[2];
					num = 7;
					continue;
				case 7:
					obj2 = new CultureInfo(SetTalkCount.Ⴗ(0, null, 1267022539, typeof(ShowStationHelp)), useUserOverride: true);
					goto case 0;
				case 0:
					num = ⴃႠ[213] - 47854;
					continue;
				case 6:
					ShowHeading.Ⴄ(Wwv, SetStationNeeds.Ⴓ(AnnHelp.Ⴈ(equatable as string, SetTalkCount.Ⴗ(2, null, 1267022529, typeof(SetDxModeHelp)), (string)cloneable, 764, 'ˋ'), (IFormatProvider)obj2, 'ȵ', 596), 595, 599);
					num = 14;
					continue;
				case 14:
					ShowHamHelp.Ⴃ(Wwv, ((string[])array)[3], 'ʈ', 687);
					num = ⴀႳ[226] - 25849;
					continue;
				case 11:
					SetStationHereHelp.Ⴀ(Wwv, ((string[])array)[4], 878, '\u032d');
					num = ⴄႷ[28] - 45674;
					continue;
				case 8:
					ShowQslInfoHelp.Ⴍ(Wwv, ((string[])array)[5], 789, 885);
					goto case 3;
				case 3:
					num = ⴄႤ[47] / 6;
					continue;
				case 2:
					ႰႥ.Ⴐ(Wwv, ((string[])array)[6], 665, 'ʳ');
					num = ⴄႤ[135];
					continue;
				case 5:
					SetStationHereHelp.Ⴀ(Wwv, ((string[])array)[7], 163, 'ç');
					num = ⴄႷ[65] - 27964;
					continue;
				case 10:
				{
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					num = ⴀႨ[27] - 10511;
					continue;
				}
				case 9:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴃ.Warn(SetStationQth.Ⴍ(null, 1687351426, 8, 11) + cmd.Rx.Msg + ႰႥ.Ⴅ(2, '\u0086', 952620208) + ex.Message);
		}
		switch (3)
		{
		}
	}
}
