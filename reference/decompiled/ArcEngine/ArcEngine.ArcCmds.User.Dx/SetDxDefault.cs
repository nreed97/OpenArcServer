using System;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces;
using ArcShared.ArcCfg;
using Meebey.SmartIrc4net;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class SetDxDefault : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 13;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 0;
			case 0:
				SetStationBeepHelp.Ⴅ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 355, 281), string.Empty, 177, 248);
				goto case 5;
			case 5:
				num = 2;
				break;
			case 2:
				DxClusterCacheCfg.Ⴅ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 806, 860), DxModeType.Filter, 85, 60);
				num = 12;
				break;
			case 12:
				qslinfoRequest.Ⴄ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 138, 240), OutputType.On, 851, 826);
				num = 1;
				break;
			case 1:
				SkimmerValidSpot.Ⴀ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 956, 966), 20, 'Ī', 352);
				num = ⴀ[71] - 58808;
				break;
			case 8:
				SetDxFilter.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 966, 956), 516, 'Ʌ'), false, 15, 23);
				num = ⴃႰ[170] - 54669;
				break;
			case 4:
				SetDxExtensionHelp.Ⴃ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 830, 836), 47, 'n'), false, 721, 649);
				num = ⴀႳ[116] - 39962;
				break;
			case 6:
				SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 445, 455), 840, '\u0309').Section = false;
				num = 9;
				break;
			case 9:
				cmd.Ⴍ().Cfg.Dx.CommentExt.County = false;
				cmd.Ⴍ().Cfg.Dx.CommentExt.ItuZone = false;
				num = 10;
				break;
			case 10:
				cmd.Ⴍ().Cfg.Dx.CommentExt.CqZone = false;
				goto case 11;
			case 11:
				cmd.Ⴍ().Cfg.Dx.CommentExt.Name = false;
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(1, null, 1057161322, 1));
				num = ⴃႠ[278] - 2738;
				break;
			case 7:
			{
				object obj = new ShowDxOptions();
				(obj as ShowDxOptions).Exec(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : CallbookData
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
					break;
				case 1:
				case 5:
					num2 = (((P_2 ^ P_1) - 113) ^ num) switch
					{
						0 => 3, 
						_ => ⴀႼ[136] + ⴀႼ[113], 
					};
					continue;
				case 7:
					cloneable = null;
					num2 = 4;
					continue;
				case 3:
				case 11:
					cloneable = P_0.City;
					num2 = ⴃႰ[190] - 47005;
					continue;
				case 4:
				{
					num++;
					int num3 = 20;
					int num4 = 109;
					num2 = ((327 > num4 - num3 * 3) ? (ⴃႰ[75] - 29853) : (ⴍႤ[112] - 2561));
					continue;
				}
				case 0:
				case 10:
					num2 = ⴀ[351] - 58089;
					continue;
				case 6:
					return (string)cloneable;
				case 9:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211, _0021_00212, _0021_00213>(_0021_00210 P_0, _0021_00212 P_1, _0021_00211 P_2, int P_3, _0021_00213 P_4, char P_5, char P_6) where _0021_00210 : IrcClient where _0021_00211 : string where _0021_00212 : string where _0021_00213 : string
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႠ[382] - 33405;
				continue;
			case 0:
			case 1:
				num = (((P_5 ^ P_6) - 68) ^ num2) switch
				{
					0 => 7, 
					_ => 8, 
				};
				continue;
			case 4:
			case 8:
				num = 3;
				continue;
			case 7:
				P_0.Login(P_1, P_2, P_3, P_4);
				break;
			case 3:
			case 6:
				break;
			case 2:
				return;
			}
			num2++;
			int num3 = 2589;
			int num4 = 331;
			num = ((863 < num3 / 3 - num4) ? 1 : (ⴃႥ[401] - 25397));
		}
	}
}
