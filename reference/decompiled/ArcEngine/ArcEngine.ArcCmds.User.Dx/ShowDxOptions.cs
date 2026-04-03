using System;
using ArcEngine.ArcCmds.Node.Pc;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class ShowDxOptions : IArcCmd
{
	private static void Ⴐ(NodeUserCmd P_0)
	{
		int num = 3;
		IArcCmd arcCmd = default(IArcCmd);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 0:
				arcCmd = new ShowDxOptionsHelp();
				goto case 4;
			case 4:
				((ShowDxOptionsHelp)arcCmd).Exec(P_0);
				goto case 1;
			case 1:
				obj = new Publisher();
				break;
			case 2:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(2, 0, 1157903281), P_0.Rx.Msg, 436, 506));
			num = 0;
		}
		(obj as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		try
		{
			int num = 3;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = ((cmd.Rx.Split.Length != 3) ? ⴄႭ[66] : (ⴄႷ[20] - 44136));
					continue;
				case 6:
					cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(1, null, 1267021404, typeof(ShowPrefixHelp)));
					num = ⴍႭ[136] - 20892;
					continue;
				case 10:
					cmd.Tx.Msg.Add(SetWxCountHelp.Ⴗ((object)ႨႨ.Ⴀ(4, 0, 1157903711), (object)ShowQslInfoHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 886, 780), 'ĭ', 273), 175, (short)212));
					num = 7;
					continue;
				case 7:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႰႥ.Ⴅ(3, '^', 952619950), LogEntry.Ⴄ(ShowSkimmerHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 804, 862), 224, 242), '0', 28), 96, 46));
					num = 9;
					continue;
				case 9:
					Ⴄ(cmd);
					Ⴀ(cmd);
					Ⴈ(cmd);
					obj = new Publisher();
					goto case 4;
				case 4:
				case 5:
					(obj as Publisher).Process(cmd);
					num = ⴍႤ[71] - 50960;
					continue;
				case 0:
					Ⴐ(cmd);
					break;
				case 8:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴐ(cmd);
		}
		switch (3)
		{
		}
	}

	private static void Ⴀ(NodeUserCmd P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 5;
		object obj = default(object);
		OutputType outputType = default(OutputType);
		while (true)
		{
			switch (num)
			{
			default:
				obj = ShowWxHelp.Ⴍ('Í', 985808425, 4);
				outputType = ႷႷ.Ⴃ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 77, 55), 'Ǉ', 418);
				num = 4;
				break;
			case 4:
				num = outputType switch
				{
					OutputType.Off => ⴍႤ[108] - 27966, 
					OutputType.On => 7, 
					OutputType.AR17 => ⴅ[53] - ⴅ[142], 
					OutputType.XML => ⴃႰ[75] - 29859, 
					_ => 6, 
				};
				break;
			case 6:
				num = ⴀႼ[113];
				break;
			case 9:
			case 10:
				obj = ShowUsersHelp.Ⴅ(obj as string, CallBlockCacheCfg.Ⴅ(null, 6, 62058145, null), 441, 503);
				num = ⴃႥ[204] - 3272;
				break;
			case 7:
				obj = ShowUsersHelp.Ⴅ((string)obj, ႨႨ.Ⴀ(2, 8, 1157903712), 203, 133);
				num = 2;
				break;
			case 3:
				obj = ShowUsersHelp.Ⴅ(obj as string, CallBlockCacheCfg.Ⴅ(null, 4, 62057504, null), 336, 286);
				num = ⴄႤ[147] - 91;
				break;
			case 0:
				obj = (obj as string) + CallBlockCacheCfg.Ⴅ(null, 0, 62055770, null);
				num = ⴅ[95] - 174;
				break;
			case 1:
			case 2:
			case 8:
				P_0.Tx.Msg.Add((string)obj);
				return;
			}
		}
	}

	private static void Ⴄ(NodeUserCmd P_0)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 2;
		object obj = default(object);
		DxModeType dxModeType = default(DxModeType);
		while (true)
		{
			switch (num)
			{
			default:
				obj = SetTalkCount.Ⴗ(6, null, 1267021372, typeof(DeleteUserPc17));
				goto case 5;
			case 5:
				dxModeType = ShowWwv.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 640, 762), 40, 63);
				goto case 9;
			case 9:
				num = 10;
				break;
			case 4:
			case 10:
				num = dxModeType switch
				{
					DxModeType.Open => 0, 
					DxModeType.Filter => 6, 
					DxModeType.Needs => ⴀႳ[239] - 27209, 
					DxModeType.Debug => ⴃႠ[312] - 44886, 
					_ => ⴄႭ[387] - 136, 
				};
				break;
			case 3:
				num = ⴀႳ[27] - 42058;
				break;
			case 0:
				obj = ShowUsersHelp.Ⴅ((string)obj, ႰႥ.Ⴅ(2, '\u001f', 952620620), 19, 93);
				num = ⴅ[347] - 46;
				break;
			case 6:
				obj = ShowUsersHelp.Ⴅ(obj as string, SetStationClubHelp.Ⴍ(15, 4, 1747258301, null), 163, 237);
				num = 1;
				break;
			case 8:
				obj = ShowUsersHelp.Ⴅ(obj as string, ShowSkimCtyHelp.Ⴍ(1216134694, 6, 'k'), 68, 10);
				num = 1;
				break;
			case 7:
				obj = (obj as string) + ShowWxHelp.Ⴍ('è', 985808500, 6);
				num = 1;
				break;
			case 1:
				P_0.Tx.Msg.Add(obj as string);
				return;
			}
		}
	}

	private static void Ⴈ(NodeUserCmd P_0)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 28;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = ShowSkimCtyHelp.Ⴍ(1216134703, 7, '\u0011');
				num = ((!HamQthCfg.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 417, 475), 443, 'Ǻ'), '\u0301', '\u0340')) ? (ⴃႰ[52] - 57979) : (ⴀႳ[163] - 30412));
				break;
			case 32:
				obj = ShowUsersHelp.Ⴅ((string)obj, SetStationClubHelp.Ⴍ(2, 5, 1747259305, null), 985, 919);
				num = ⴀႣ[218] - 43537;
				break;
			case 8:
				num = ((!SetWxCountHelp.Ⴀ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 131, 249), 735, 'ʞ'), 934, 1018)) ? (ⴀႨ[146] - 22223) : (ⴍႭ[103] - 29768));
				break;
			case 15:
				obj = ShowUsersHelp.Ⴅ(obj as string, SetStationClubHelp.Ⴍ(12, 2, 1747259302, null), 577, 527);
				num = ⴐ[338];
				break;
			case 24:
				num = ((!DxCacheCfg.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 954, 960), 408, 'Ǚ'), 1016, 1023)) ? 27 : 33);
				break;
			case 33:
				obj = ShowUsersHelp.Ⴅ(obj as string, SetStationClubHelp.Ⴍ(14, 5, 1747259354, null), 56, 118);
				num = ⴄႷ[44] - 49641;
				break;
			case 27:
				num = ((!HamQthDotComLookupExt.Ⴀ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 337, 299), 228, '¥'), 64, 88)) ? 3 : (ⴃႠ[53] - 46721));
				break;
			case 11:
				obj = ShowUsersHelp.Ⴅ((string)obj, SetStationClubHelp.Ⴍ(3, 2, 1747259350, null), 935, 1001);
				num = 3;
				break;
			case 3:
				num = ((!SetStationClub.Ⴄ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 132, 254), 244, 'µ'), 97, 36)) ? 9 : 5);
				break;
			case 5:
				obj = ShowUsersHelp.Ⴅ(obj as string, SetStationClubHelp.Ⴍ(9, 2, 1747259341, null), 650, 708);
				num = 9;
				break;
			case 9:
				num = ((!HamQthDotComLookupExt.Ⴀ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 535, 621), 511, 'ƾ'), 430, 439)) ? 20 : (ⴍႤ[99] - 21286));
				break;
			case 1:
				obj = ShowUsersHelp.Ⴅ((string)obj, SetStationClubHelp.Ⴍ(12, 8, 1747259378, null), 224, 174);
				num = ⴀႨ[155] - 785;
				break;
			case 20:
				num = ((!HamQthCfg.Ⴈ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 532, 622), 207, '\u008e'), 'ʝ', '\u02df')) ? ⴄႤ[12] : (ⴃႥ[420] - 8224));
				break;
			case 6:
			case 7:
				obj = ShowUsersHelp.Ⴅ((string)obj, SetStationClubHelp.Ⴍ(8, 5, 1747259381, null), 906, 964);
				num = ⴐ[112];
				break;
			case 26:
				num = ((!SetStationClub.Ⴄ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 832, 826), 82, '\u0013'), 763, 701)) ? 2 : ⴀႼ[80]);
				break;
			case 0:
				obj = ShowUsersHelp.Ⴅ((string)obj, SetStationClubHelp.Ⴍ(0, 0, 1747259368, null), 450, 396);
				num = ⴃႥ[379] - 3033;
				break;
			case 2:
				num = ((!SetStationClub.Ⴄ(SetStationClub.Ⴗ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 226, 152), 526, 'ɏ'), 848, 791)) ? 12 : 22);
				break;
			case 22:
				obj = (obj as string) + SetStationClubHelp.Ⴍ(5, 0, 1747259366, null);
				num = 12;
				break;
			case 12:
				num = ((!P_0.Ⴍ().Cfg.Dx.CommentExt.Name) ? 31 : (ⴀႳ[153] - 12579));
				break;
			case 14:
				obj = (obj as string) + SetStationClubHelp.Ⴍ(7, 6, 1747259163, null);
				num = ⴍႤ[115] - 61422;
				break;
			case 31:
				num = ((!P_0.Ⴍ().Cfg.Dx.CommentExt.SpotterCty) ? 13 : (ⴍႤ[305] - 10572));
				break;
			case 16:
				obj = (string)obj + SetStationClubHelp.Ⴍ(8, 2, 1747259159, null);
				num = 13;
				break;
			case 13:
				num = ((!P_0.Ⴍ().Cfg.Dx.CommentExt.SpotterState) ? (ⴀႳ[2] - 30356) : 21);
				break;
			case 21:
				obj = (string)obj + SetStationClubHelp.Ⴍ(1, 1, 1747259142, null);
				num = 23;
				break;
			case 23:
			case 29:
				num = ((!P_0.Ⴍ().Cfg.Dx.CommentExt.SpotterLoc) ? 19 : 30);
				break;
			case 30:
				obj = (string)obj + SetStationClubHelp.Ⴍ(2, 6, 1747259185, null);
				num = ⴄႤ[495] / 3;
				break;
			case 19:
				num = ((!P_0.Ⴍ().Cfg.Dx.CommentExt.SpotterCont) ? 18 : 17);
				break;
			case 17:
				obj = (obj as string) + SetStationClubHelp.Ⴍ(2, 3, 1747259170, null);
				num = ⴀႣ[248] - 37904;
				break;
			case 10:
			case 18:
				num = ((!P_0.Ⴍ().Cfg.Dx.CommentExt.Eos) ? (ⴀႳ[239] - 27192) : 4);
				break;
			case 4:
				obj = (string)obj + SetStationClubHelp.Ⴍ(11, 3, 1747259219, null);
				num = 25;
				break;
			case 25:
				P_0.Tx.Msg.Add(obj as string);
				return;
			}
		}
	}
}
