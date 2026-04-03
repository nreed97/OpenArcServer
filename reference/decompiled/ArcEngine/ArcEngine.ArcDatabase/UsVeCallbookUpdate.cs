using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.AnnWx;
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
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.Callbook;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcDatabase;

public sealed class UsVeCallbookUpdate
{
	private static readonly ILog Ⴄ = SkimmerValidSpot.Ⴐ(CallBlockCacheCfg.Ⴅ(null, 3, 62055939, null), 602, 583);

	internal void Process(string fccUrl, string veUrl, bool processArc4Db)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 7;
		string text = default(string);
		string text2 = default(string);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			default:
			{
				Assembly assembly = ShowLog.Ⴍ(899, '\u038b');
				text = SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(assembly, 993, 899), 1010, 'ϧ');
				num = ⴍႤ[84] - 23386;
				break;
			}
			case 1:
			case 3:
				text2 = ShowUsersHelp.Ⴅ(text, SetStationClubHelp.Ⴍ(10, 6, 1747258766, null), 542, 592);
				goto case 0;
			case 0:
				num = ⴄႷ[110] - 20068;
				break;
			case 5:
				flag2 = ProcessFcc(fccUrl, text2);
				flag = ProcessVe(veUrl, text2, text);
				num = ⴀ[104] - 39233;
				break;
			case 2:
			case 4:
				if (flag2)
				{
					num = 6;
					break;
				}
				return;
			case 6:
			{
				if (!flag)
				{
					return;
				}
				try
				{
					int num2 = 5;
					while (true)
					{
						switch (num2)
						{
						default:
							Ⴃ(text2);
							Ⴄ.Info(ReplyMailHelp.Ⴄ(21, null, 1057163857, 7));
							num2 = ⴐ[257];
							continue;
						case 7:
							ShowPrefixCalls.Ⴄ(ShowUsersHelp.Ⴅ(text, ႰႥ.Ⴅ(0, '¹', 952622108), 588, 514), ShowUsersHelp.Ⴅ(text, CallBlockCacheCfg.Ⴅ(null, 0, 62055841, null), 462, 384), true, 'Ͱ', 786);
							num2 = 4;
							continue;
						case 4:
							ShowPrefixCalls.Ⴄ(ShowUsersHelp.Ⴅ(text, ShowSkimCtyHelp.Ⴍ(1216131456, 8, '\r'), 633, 567), ShowUsersHelp.Ⴅ(text, ReplyMailHelp.Ⴄ(6, null, 1057163794, 5), 395, 453), true, '\u0335', 855);
							goto case 11;
						case 11:
							num2 = 12;
							continue;
						case 12:
							ShowPrefixCalls.Ⴄ(ShowUsersHelp.Ⴅ(text, ShowWxHelp.Ⴍ('\u0091', 985807000, 8), 17, 95), ShowUsersHelp.Ⴅ(text, SetTalkCount.Ⴗ(7, null, 1267020875, typeof(ႨႭ.ႨႷ)), 433, 511), true, 'ǫ', 393);
							num2 = ⴄႷ[110] - 20067;
							continue;
						case 6:
							ShowPrefixCalls.Ⴄ(ShowUsersHelp.Ⴅ(text, SetStationQth.Ⴍ(null, 1687353266, 1, 19), 848, 798), ShowUsersHelp.Ⴅ(text, ႨႨ.Ⴀ(3, 3, 1157905534), 706, 652), true, '5', 87);
							num2 = 0;
							continue;
						case 0:
							ShowPrefixCalls.Ⴄ(ShowUsersHelp.Ⴅ(text, ReplyMail.Ⴅ(3, 11, 1217944475), 347, 277), ShowUsersHelp.Ⴅ(text, SetStationClubHelp.Ⴍ(9, 6, 1747258832, null), 969, 903), true, '\u0019', 123);
							num2 = 3;
							continue;
						case 3:
							ShowPrefixCalls.Ⴄ(ShowUsersHelp.Ⴅ(text, ႰႥ.Ⴅ(1, '\v', 952622528), 491, 421), ShowUsersHelp.Ⴅ(text, CallBlockCacheCfg.Ⴅ(null, 0, 62056004, null), 45, 99), true, 'ɘ', 570);
							goto case 8;
						case 8:
							num2 = 2;
							continue;
						case 2:
							File.Copy(ShowUsersHelp.Ⴅ(text, ShowSkimCtyHelp.Ⴍ(1216131501, 0, '\0'), 625, 575), text + ReplyMailHelp.Ⴄ(18, null, 1057163832, 2), overwrite: true);
							goto case 9;
						case 9:
							num2 = 10;
							continue;
						case 10:
							File.Copy(text + ShowWxHelp.Ⴍ('g', 985807103, 4), text + SetTalkCount.Ⴗ(0, null, 1267021051, typeof(SkimmerValidSpot)), overwrite: true);
							num2 = ⴀႨ[133] - 16024;
							continue;
						case 13:
							File.Copy(text + SetStationQth.Ⴍ(null, 1687353411, 8, 15), text + ႨႨ.Ⴀ(15, 3, 1157905436), overwrite: true);
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Ⴄ.Error(ex.Message);
				}
				int num3 = 4;
				while (true)
				{
					switch (num3)
					{
					case 6:
						num3 = ((!processArc4Db) ? 7 : (ⴀႨ[82] - 5767));
						continue;
					case 5:
						ProcessArc4();
						return;
					case 7:
						return;
					}
					Ⴄ.Info(ReplyMailHelp.Ⴄ(12, null, 1057163737, 1));
					ObjectManager.Instance.Ⴀ().UsVeCallbook.Restart();
					num3 = 6;
				}
			}
			}
		}
	}

	private bool ProcessFcc(string fccUrl, string baseFilePath)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		bool flag = default(bool);
		try
		{
			int num = 4;
			DateTime dateTime = default(DateTime);
			string text = default(string);
			CallBookExtCache callBookExtCache = default(CallBookExtCache);
			UsCallbook usCallbook = default(UsCallbook);
			TimeSpan timeSpan = default(TimeSpan);
			while (true)
			{
				switch (num)
				{
				default:
					new List<string>(SkimmerSpot.Ⴐ(baseFilePath, 'b', 29)).ForEach(File.Delete);
					num = ⴀႣ[400] - ⴀႣ[400];
					break;
				case 0:
				case 2:
					dateTime = PrintDxFilters.Ⴄ('Ư', 'ǌ');
					Ⴄ.Info(SetStationQth.Ⴍ(null, 1687353449, 8, 21));
					num = ⴐ[243];
					break;
				case 8:
					text = ShowUsersHelp.Ⴅ(baseFilePath, ႨႨ.Ⴀ(9, 2, 1157905469), 402, 476);
					num = 7;
					break;
				case 7:
					DeleteMail.Ⴅ(fccUrl, text, string.Empty, 617, 'Ɏ');
					Ⴄ.Info(SetStationClubHelp.Ⴍ(11, 6, 1747258631, null));
					num = ⴀႳ[116] - 39962;
					break;
				case 6:
					SetStationEmailHelp.Ⴅ(ShowUsersHelp.Ⴅ(baseFilePath, ႨႨ.Ⴀ(5, 1, 1157905470), 718, 640), baseFilePath, 'Ș', 601);
					num = 1;
					break;
				case 1:
					callBookExtCache = new CallBookExtCache();
					goto case 9;
				case 9:
					Ⴄ.Info(ReplyMail.Ⴅ(6, 4, 1217944502));
					usCallbook = new UsCallbook(callBookExtCache, SetStationClubHelp.Ⴍ(2, 4, 1747258764, null));
					num = ⴄႤ[135];
					break;
				case 5:
					usCallbook.BuildIndexes();
					goto case 3;
				case 3:
					usCallbook.WriteIndexFiles();
					timeSpan = SetWxMode.Ⴃ(PrintDxFilters.Ⴄ('\u0356', '\u0335'), dateTime, 969, 903);
					num = 11;
					break;
				case 11:
					Ⴄ.Info(SetStationQth.Ⴍ(null, 1687353402, 5, 21) + timeSpan.Minutes + CallBlockCacheCfg.Ⴅ(null, 6, 62056060, null));
					num = ⴀႨ[99] - 1048;
					break;
				case 12:
					flag = true;
					return flag;
				}
			}
		}
		catch (Exception ex)
		{
			Ⴄ.Error(ex.Message);
		}
		return 3 switch
		{
			2 => flag, 
			_ => false, 
		};
	}

	private bool ProcessVe(string veUrl, string baseFilePath, string rootFilePath)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		bool result = default(bool);
		try
		{
			int num = 1;
			DateTime dateTime = default(DateTime);
			string text = default(string);
			VeCallbook veCallbook = default(VeCallbook);
			TimeSpan timeSpan = default(TimeSpan);
			while (true)
			{
				switch (num)
				{
				default:
					dateTime = PrintDxFilters.Ⴄ('ͳ', '\u0310');
					Ⴄ.Info(SetTalkCount.Ⴗ(8, null, 1267021004, typeof(SetDxCount)));
					num = 3;
					break;
				case 3:
					text = ShowUsersHelp.Ⴅ(baseFilePath, ShowSkimCtyHelp.Ⴍ(1216131152, 5, '\u009c'), 27, 85);
					num = 2;
					break;
				case 2:
					DeleteMail.Ⴅ(veUrl, text, string.Empty, 13, '*');
					Ⴄ.Info(ShowWxHelp.Ⴍ('\u00a8', 985807049, 8));
					goto case 6;
				case 6:
					num = 5;
					break;
				case 5:
					SetStationEmailHelp.Ⴅ(ShowUsersHelp.Ⴅ(baseFilePath, ShowSkimCtyHelp.Ⴍ(1216131157, 0, '\u00ad'), 163, 237), baseFilePath, 'ȇ', 582);
					num = ⴃႰ[8] - 44792;
					break;
				case 10:
					Ⴄ.Info(ReplyMailHelp.Ⴄ(4, null, 1057163760, 4));
					veCallbook = new VeCallbook(SetStationClubHelp.Ⴍ(13, 7, 1747258767, null));
					num = 0;
					break;
				case 0:
					veCallbook.BuildIndex();
					veCallbook.WriteIndexFile();
					goto case 8;
				case 8:
					timeSpan = SetWxMode.Ⴃ(PrintDxFilters.Ⴄ('b', '\u0001'), dateTime, 337, 287);
					goto case 4;
				case 4:
					num = ⴍႭ[33] - 21315;
					break;
				case 11:
					Ⴄ.Info(ReplyMailHelp.Ⴄ(26, null, 1057163694, 1) + ShowClusterHelp.Ⴃ(ref timeSpan, 771, '\u0326') + ShowWxHelp.Ⴍ('Í', 985806870, 0));
					num = 9;
					break;
				case 9:
					result = true;
					return result;
				}
			}
		}
		catch (Exception ex)
		{
			Ⴄ.Error(ex.Message);
		}
		switch (2)
		{
		default:
			return false;
		case 0:
		case 4:
			return result;
		}
	}

	private void ProcessArc4()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		try
		{
			int num = 5;
			DateTime dateTime = default(DateTime);
			TimeSpan timeSpan = default(TimeSpan);
			while (true)
			{
				switch (num)
				{
				default:
					dateTime = PrintDxFilters.Ⴄ('o', '\f');
					Ⴄ.Info(ShowSkimCtyHelp.Ⴍ(1216131173, 6, '3'));
					goto case 1;
				case 1:
					num = 6;
					continue;
				case 2:
				case 6:
					ObjectManager.Instance.Ⴀ().UsVeCallbook.Arc4CallbookBuild();
					timeSpan = SetWxMode.Ⴃ(PrintDxFilters.Ⴄ('ǳ', 'Ɛ'), dateTime, 491, 421);
					num = ⴀႨ[62] - 24121;
					continue;
				case 0:
				case 4:
					Ⴄ.Info(ႨႨ.Ⴀ(6, 7, 1157905871) + ShowNodes.Ⴍ(ref timeSpan, 863, '\u036d') + CallBlockCacheCfg.Ⴅ(null, 0, 62056058, null));
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴄ.Error(ex.Message);
		}
		switch (2)
		{
		}
	}

	private void Ⴃ(string P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				DeleteFile(ShowUsersHelp.Ⴅ(P_0, ReplyMailHelp.Ⴄ(1, null, 1057163587, 3), 245, 187));
				num = 7;
				break;
			case 7:
				DeleteFile(ShowUsersHelp.Ⴅ(P_0, ႨႨ.Ⴀ(5, 4, 1157905899), 734, 656));
				goto case 9;
			case 9:
				num = ⴅ[210];
				break;
			case 8:
			case 11:
				DeleteFile(ShowUsersHelp.Ⴅ(P_0, CallBlockCacheCfg.Ⴅ(null, 8, 62056037, null), 307, 381));
				num = ⴀ[42] - ⴀ[296];
				break;
			case 10:
				DeleteFile(ShowUsersHelp.Ⴅ(P_0, ႨႨ.Ⴀ(5, 6, 1157905465), 373, 315));
				num = 0;
				break;
			case 0:
				DeleteFile(ShowUsersHelp.Ⴅ(P_0, SetStationClubHelp.Ⴍ(1, 0, 1747258730, null), 277, 347));
				num = ⴅ[365] / 3;
				break;
			case 4:
				DeleteFile(ShowUsersHelp.Ⴅ(P_0, ReplyMailHelp.Ⴄ(25, null, 1057163611, 2), 506, 436));
				num = 6;
				break;
			case 6:
				DeleteFile(ShowUsersHelp.Ⴅ(P_0, ႨႨ.Ⴀ(11, 3, 1157905911), 469, 411));
				num = 12;
				break;
			case 12:
				DeleteFile(ShowUsersHelp.Ⴅ(P_0, ShowSkimCtyHelp.Ⴍ(1216131165, 8, 'k'), 999, 937));
				num = 2;
				break;
			case 2:
				DeleteFile(P_0 + SetTalkCount.Ⴗ(6, null, 1267021167, typeof(WxLocalUser.WxLocalHelp)));
				num = ⴀႨ[60] - 55458;
				break;
			case 1:
				DeleteFile(P_0 + SetStationClubHelp.Ⴍ(11, 2, 1747255960, null));
				return;
			case 5:
				return;
			}
		}
	}

	private static void DeleteFile(string filePath)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		try
		{
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!LogCacheCfg.Ⴗ(filePath, 55, 55)) ? (ⴍႤ[228] - 16939) : 0);
					break;
				case 0:
				case 3:
				case 4:
					SetWwvOutput.Ⴍ(filePath, 'ň', 329);
					return;
				case 2:
					return;
				}
				num = num2;
			}
		}
		catch (Exception ex)
		{
			Ⴄ.Error(CallBlockCacheCfg.Ⴅ(null, 8, 62055966, null) + filePath + ႰႥ.Ⴅ(0, 'Ý', 952620210) + ex.Message);
		}
	}
}
