using System;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;

namespace Ⴈ;

internal sealed class ႰႠ
{
	public static void Ⴅ(ArcConnect P_0, NodeUserCmd P_1)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 3;
		object obj2 = default(object);
		bool flag = default(bool);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				return;
			}
			if (SetStationHereHelp.Ⴄ(SetStationEmailHelp.Ⴈ(P_0.Cfg, 500, 448), 349, 'ń') == OutputType.Off)
			{
				num = 1;
				continue;
			}
			while (true)
			{
				int num2 = ((SkimmerSpotBins.Ⴅ(SetStationEmailHelp.Ⴈ(P_0.Cfg, 29, 41), 803, 813) == ModeType.Filter) ? 21 : (ⴀႼ[113] * 5));
				while (true)
				{
					string text;
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 12:
						break;
					case 10:
						num2 = ((ShowWwv.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Cfg, 29, 103), 330, 349) != DxModeType.Debug) ? 13 : 21);
						continue;
					case 21:
						obj2 = ShowPrefixCalls.Ⴃ((object)CallBlockCacheCfg.Ⴅ(null, 5, 62057684, null), (object)P_1.Tx.Id, (object)ReplyMail.Ⴅ(8, 0, 1217944659), '\u02f8', 722);
						num2 = ⴍႭ[370] - 25906;
						continue;
					case 6:
						num2 = ((CallBlockCacheCfg.Ⴜ(PcxxCfg.Ⴃ(SetStationEmailHelp.Ⴈ(P_0.Cfg, 755, 711), 'Û', 'Ã'), 659, 754) <= 0) ? 5 : 19);
						continue;
					case 19:
						obj2 = qslinfoResponse.Ⴗ((string)obj2, ShowSkimCtyHelp.Ⴍ(1216133629, 6, '\u009e'), PcxxCfg.Ⴃ(SetStationEmailHelp.Ⴈ(P_0.Cfg, 241, 197), 'j', 'r'), ReplyMailHelp.Ⴄ(14, null, 1057162121, 3), 17, 'r');
						num2 = ⴐ[180] - 188;
						continue;
					case 5:
						flag = P_1.Ⴍ().Ⴅ().Ⴀ()
							.Ⴈ()
							.Ⴀ(obj2 as string);
						num2 = 0;
						continue;
					case 13:
						flag = true;
						num2 = ⴍႭ[77] - ⴍႭ[77];
						continue;
					case 0:
						num2 = ((!ByeHelp.Ⴍ(P_0.Call, P_1.Ⴍ().Call, 149, 242)) ? 22 : 14);
						continue;
					case 14:
						flag = true;
						num2 = 22;
						continue;
					case 22:
						num2 = (flag ? 8 : 2);
						continue;
					case 1:
					case 2:
						num2 = ((SkimmerSpotBins.Ⴅ(SetStationEmailHelp.Ⴈ(P_0.Cfg, 704, 756), 291, 301) == ModeType.Debug) ? (ⴃႰ[63] - 42188) : (ⴄႭ[620] - ⴄႭ[84]));
						continue;
					case 18:
						return;
					case 8:
						obj = string.Empty;
						goto case 11;
					case 11:
						num2 = ((P_0.Cfg.Wx.Mode != ModeType.Debug) ? (ⴍႭ[325] - 18834) : (ⴄႷ[79] - 55484));
						continue;
					case 9:
						num2 = (flag ? (ⴄႷ[118] - 56543) : ⴀႼ[96]);
						continue;
					case 4:
						text = ReplyMailHelp.Ⴄ(12, null, 1057162112, 6);
						goto IL_037e;
					case 20:
						text = ShowWxHelp.Ⴍ(':', 985808853, 8);
						goto IL_037e;
					case 7:
					{
						OutputType output = P_0.Cfg.Wx.Output;
						num2 = ((output == OutputType.On) ? 17 : 3);
						continue;
					}
					case 3:
						return;
					case 17:
						{
							P_0.ႠႰ((obj as string) + P_1.Tx.Msg[0]);
							return;
						}
						IL_037e:
						obj = text;
						num2 = ⴃႠ[107] - 2808;
						continue;
					}
					break;
				}
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210>(_0021_00210 P_0, SqlFilterType P_1, int P_2, short P_3) where _0021_00210 : string
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 10;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႳ[167] - 15999;
					continue;
				case 8:
					break;
				case 10:
					num2 = (((P_2 ^ P_3) - 97) ^ num) switch
					{
						0 => 3, 
						_ => 9, 
					};
					continue;
				case 9:
					comparable = null;
					goto case 11;
				case 11:
					num2 = ⴃႠ[202] - 30739;
					continue;
				case 1:
				case 3:
					comparable = UtilsSql.FormatSqlFilter(P_0, P_1);
					num2 = 4;
					continue;
				case 4:
				{
					num++;
					num3 = P_3 * P_3;
					int num4 = num3;
					Arc4ServerClient.ႠႣ[216] = (char)((Arc4ServerClient.ႠႣ[216] + SetWxOutput.ႣႰ[198]) & 0x84);
					num3 = P_3 + num4;
					goto case 7;
				}
				case 7:
					num2 = ⴍႤ[59] - 53751;
					continue;
				case 6:
					num2 = ((num3 % 2 != 0) ? 10 : 2);
					continue;
				case 2:
					return comparable as string;
				case 0:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}
}
