using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcCmds.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Arcx;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;
using Meebey.SmartIrc4net;

namespace Ⴈ;

internal static class ႰႨ
{
	[StructLayout(LayoutKind.Auto)]
	internal struct ႥႠ
	{
		internal string Ⴈ;

		internal IIoClient Ⴄ;
	}

	public static void Ⴍ()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 3;
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			switch (num)
			{
			default:
			{
				object obj = ShowLog.Ⴍ(333, 'Ņ');
				enumerable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)obj, 406, 500), 699, 'ʮ'), CallBlockCacheCfg.Ⴅ(null, 8, 62056659, null), 550, 616);
				num = 0;
				break;
			}
			case 0:
				Ⴃ((string)enumerable);
				Ⴍ((string)enumerable);
				Ⴐ((string)enumerable);
				Ⴈ(enumerable as string);
				num = ⴀႳ[55] - 32496;
				break;
			case 1:
			case 4:
			case 5:
				Ⴀ((string)enumerable);
				return;
			}
		}
	}

	private static void Ⴃ(string P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				P_0 = ShowUsersHelp.Ⴅ(P_0, ShowWxHelp.Ⴍ('\u0085', 985808063, 8), 669, 723);
				num = 6;
				break;
			case 6:
				num = (LogCacheCfg.Ⴗ(P_0, 875, 875) ? (ⴃႠ[123] - 19752) : 5);
				break;
			case 1:
			case 5:
				Ⴅ(P_0);
				return;
			case 0:
			case 2:
				return;
			}
		}
	}

	private static void Ⴍ(string P_0)
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				P_0 = ShowUsersHelp.Ⴅ(P_0, SetTalkCount.Ⴗ(6, null, 1267023752, typeof(ႰႳ)), 576, 526);
				goto case 5;
			case 5:
				num = 1;
				break;
			case 1:
				num = ((!LogCacheCfg.Ⴗ(P_0, 418, 418)) ? 6 : 0);
				break;
			case 3:
			case 6:
				Ⴓ(P_0);
				return;
			case 0:
			case 2:
				return;
			}
		}
	}

	private static void Ⴐ(string P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				P_0 = ShowUsersHelp.Ⴅ(P_0, ShowSkimCtyHelp.Ⴍ(1216134503, 1, '9'), 211, 157);
				num = 3;
				break;
			case 0:
			case 1:
			case 3:
				num = (LogCacheCfg.Ⴗ(P_0, 914, 914) ? 2 : (ⴍႤ[359] - 6550));
				break;
			case 4:
				Ⴄ(P_0);
				return;
			case 2:
			case 6:
				return;
			}
		}
	}

	private static void Ⴈ(string P_0)
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				P_0 = ShowUsersHelp.Ⴅ(P_0, ReplyMailHelp.Ⴄ(19, null, 1057161236, 3), 829, 883);
				goto case 6;
			case 6:
				num = 1;
				break;
			case 1:
				num = (LogCacheCfg.Ⴗ(P_0, 779, 779) ? 5 : 0);
				break;
			case 0:
			case 2:
			case 3:
				Ⴗ(P_0);
				return;
			case 5:
				return;
			}
		}
	}

	private static void Ⴀ(string P_0)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				P_0 = ShowUsersHelp.Ⴅ(P_0, ႰႥ.Ⴅ(5, '6', 952620866), 288, 366);
				goto case 6;
			case 6:
				num = 3;
				break;
			case 3:
				num = ((!LogCacheCfg.Ⴗ(P_0, 8, 8)) ? 1 : 5);
				break;
			case 1:
				Ⴜ(P_0);
				return;
			case 4:
			case 5:
				return;
			}
		}
	}

	private static void Ⴅ(string P_0)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 0;
		TextWriter textWriter = default(TextWriter);
		while (true)
		{
			switch (num)
			{
			default:
				textWriter = new StreamWriter(P_0);
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ShowSkimCtyHelp.Ⴍ(1216134520, 0, '¡'), 277, 278);
				num = 1;
				break;
			case 1:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, ႰႥ.Ⴅ(5, 'l', 952620231), 594, 593);
				goto case 6;
			case 6:
				num = ⴄႭ[157] - 248;
				break;
			case 4:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ႰႥ.Ⴅ(0, '@', 952620226), 394, 393);
				num = 5;
				break;
			case 5:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), CallBlockCacheCfg.Ⴅ(null, 5, 62056652, null), 155, 152);
				num = 8;
				break;
			case 8:
				(textWriter as StreamWriter).WriteLine(ReplyMail.Ⴅ(5, 13, 1217945352));
				(textWriter as StreamWriter).WriteLine(SetStationClubHelp.Ⴍ(14, 0, 1747258145, null));
				num = 3;
				break;
			case 2:
			case 3:
			case 7:
				((StreamWriter)textWriter).Close();
				return;
			}
		}
	}

	private static void Ⴓ(string P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 6;
		TextWriter textWriter = default(TextWriter);
		while (true)
		{
			switch (num)
			{
			default:
				textWriter = new StreamWriter(P_0);
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, ReplyMailHelp.Ⴄ(22, null, 1057161255, 4), 924, 927);
				num = 14;
				break;
			case 14:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ႰႥ.Ⴅ(5, '\u007f', 952620231), 317, 318);
				num = 11;
				break;
			case 11:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ႰႥ.Ⴅ(7, '\u0094', 952620229), 946, 945);
				num = 4;
				break;
			case 4:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, ReplyMail.Ⴅ(2, 6, 1217943756), 604, 607);
				num = 3;
				break;
			case 3:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, SetStationClubHelp.Ⴍ(4, 1, 1747257494, null), 681, 682);
				num = 10;
				break;
			case 10:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), SetStationQth.Ⴍ(null, 1687352409, 7, 4), 803, 800);
				num = 7;
				break;
			case 7:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ႨႨ.Ⴀ(3, 0, 1157904284), 434, 433);
				num = 23;
				break;
			case 23:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), SetStationClubHelp.Ⴍ(9, 5, 1747257490, null), 21, 22);
				num = 15;
				break;
			case 15:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), SetTalkCount.Ⴗ(3, null, 1267022902, typeof(SetStationLatLonHelp)), 523, 520);
				num = 13;
				break;
			case 13:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, SetStationClubHelp.Ⴍ(9, 5, 1747257490, null), 302, 301);
				num = ⴍႭ[82] - 37554;
				break;
			case 12:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, ReplyMailHelp.Ⴄ(12, null, 1057163161, 0), 823, 820);
				num = 21;
				break;
			case 21:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ႰႥ.Ⴅ(1, 'ß', 952620819), 70, 69);
				num = 16;
				break;
			case 16:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), SetStationClubHelp.Ⴍ(8, 2, 1747257493, null), 863, 860);
				num = ⴄႤ[300] - 243;
				break;
			case 1:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ReplyMail.Ⴅ(4, 13, 1217943680), 35, 32);
				num = 18;
				break;
			case 18:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, SetStationClubHelp.Ⴍ(0, 4, 1747257549, null), 79, 76);
				num = 20;
				break;
			case 20:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, SetStationClubHelp.Ⴍ(9, 6, 1747257489, null), 284, 287);
				num = 8;
				break;
			case 8:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ႨႨ.Ⴀ(1, 0, 1157904230), 378, 377);
				goto case 2;
			case 2:
				num = ⴍႤ[159] - 11937;
				break;
			case 0:
			case 17:
				(textWriter as StreamWriter).WriteLine(ShowWxHelp.Ⴍ('Î', 985808040, 3));
				(textWriter as StreamWriter).WriteLine(SetTalkCount.Ⴗ(1, null, 1267023082, typeof(SetAnnOutput)));
				num = 9;
				break;
			case 9:
				(textWriter as StreamWriter).WriteLine(SetStationClubHelp.Ⴍ(10, 2, 1747257493, null));
				(textWriter as StreamWriter).WriteLine(ReplyMail.Ⴅ(1, 3, 1217943759));
				num = 22;
				break;
			case 22:
				((StreamWriter)textWriter).WriteLine(ႰႥ.Ⴅ(3, 'í', 952619247));
				(textWriter as StreamWriter).WriteLine(CallBlockCacheCfg.Ⴅ(null, 2, 62056682, null));
				num = 5;
				break;
			case 5:
			case 19:
				((StreamWriter)textWriter).Close();
				return;
			}
		}
	}

	private static void Ⴄ(string P_0)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 6;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new StreamWriter(P_0);
				SetStationBeep.Ⴄ((TextWriter)(obj as StreamWriter), ReplyMailHelp.Ⴄ(19, null, 1057161255, 4), 691, 688);
				num = ⴄႭ[562] - 194;
				break;
			case 13:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)obj, ႰႥ.Ⴅ(1, 'm', 952620227), 323, 320);
				num = 8;
				break;
			case 8:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)obj, ႰႥ.Ⴅ(5, '8', 952620231), 380, 383);
				num = 3;
				break;
			case 3:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)obj, ReplyMail.Ⴅ(0, 2, 1217943758), 500, 503);
				num = 22;
				break;
			case 22:
				SetStationBeep.Ⴄ((TextWriter)(obj as StreamWriter), SetStationClubHelp.Ⴍ(12, 4, 1747257491, null), 497, 498);
				num = ⴀႼ[126] - ⴀႼ[21];
				break;
			case 1:
			case 12:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)obj, SetStationQth.Ⴍ(null, 1687352415, 1, 18), 549, 550);
				goto case 17;
			case 17:
				num = 4;
				break;
			case 4:
				SetStationBeep.Ⴄ((TextWriter)(obj as StreamWriter), ႨႨ.Ⴀ(4, 6, 1157904282), 97, 98);
				num = ⴅ[361] - 172;
				break;
			case 15:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)obj, SetStationClubHelp.Ⴍ(1, 2, 1747257493, null), 204, 207);
				num = 23;
				break;
			case 23:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)obj, SetTalkCount.Ⴗ(3, null, 1267022902, typeof(ShowSun)), 985, 986);
				num = 18;
				break;
			case 18:
				SetStationBeep.Ⴄ((TextWriter)(obj as StreamWriter), SetStationClubHelp.Ⴍ(8, 0, 1747257495, null), 177, 178);
				num = ⴄႷ[100] - 20016;
				break;
			case 11:
				SetStationBeep.Ⴄ((TextWriter)(obj as StreamWriter), ႰႥ.Ⴅ(1, ' ', 952619189), 172, 175);
				num = 5;
				break;
			case 5:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)obj, CallBlockCacheCfg.Ⴅ(null, 8, 62056579, null), 13, 14);
				num = ⴃႠ[204] - 17755;
				break;
			case 16:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)obj, SetStationClubHelp.Ⴍ(13, 7, 1747257488, null), 869, 870);
				num = 2;
				break;
			case 2:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)obj, ReplyMail.Ⴅ(4, 10, 1217943680), 501, 502);
				num = 0;
				break;
			case 0:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)obj, SetStationClubHelp.Ⴍ(0, 2, 1747257547, null), 988, 991);
				num = ⴅ[387] / 7;
				break;
			case 10:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)obj, SetStationClubHelp.Ⴍ(14, 4, 1747257491, null), 245, 246);
				num = 9;
				break;
			case 9:
				SetStationBeep.Ⴄ((TextWriter)(obj as StreamWriter), ႨႨ.Ⴀ(3, 8, 1157904238), 386, 385);
				goto case 21;
			case 21:
				num = ⴄႤ[15] - 34;
				break;
			case 19:
				((StreamWriter)obj).WriteLine(ShowWxHelp.Ⴍ('Â', 985808046, 5));
				((StreamWriter)obj).WriteLine(SetTalkCount.Ⴗ(8, null, 1267023075, typeof(WwvSpotArx)));
				num = ⴅ[145];
				break;
			case 7:
				((StreamWriter)obj).WriteLine(SetStationClubHelp.Ⴍ(14, 3, 1747257492, null));
				(obj as StreamWriter).WriteLine(ReplyMail.Ⴅ(7, 11, 1217943753));
				num = 14;
				break;
			case 14:
				(obj as StreamWriter).WriteLine(ႰႥ.Ⴅ(3, '\u0094', 952619247));
				((StreamWriter)obj).WriteLine(CallBlockCacheCfg.Ⴅ(null, 2, 62056682, null));
				num = 20;
				break;
			case 20:
				((StreamWriter)obj).Close();
				return;
			}
		}
	}

	private static void Ⴗ(string P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 8;
		TextWriter textWriter = default(TextWriter);
		while (true)
		{
			switch (num)
			{
			default:
				textWriter = new StreamWriter(P_0);
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, CallBlockCacheCfg.Ⴅ(null, 2, 62056819, null), 687, 684);
				num = 9;
				break;
			case 9:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ႰႥ.Ⴅ(2, 'h', 952620224), 784, 787);
				goto case 5;
			case 5:
				num = ⴃႠ[155] - 34034;
				break;
			case 10:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, ႰႥ.Ⴅ(3, 'þ', 952620225), 339, 336);
				num = ⴃႥ[200] - 30021;
				break;
			case 2:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), SetStationClubHelp.Ⴍ(12, 4, 1747258268, null), 753, 754);
				num = ⴀ[172] - 3515;
				break;
			case 4:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, CallBlockCacheCfg.Ⴅ(null, 3, 62056650, null), 843, 840);
				num = ⴀ[330] - 54207;
				break;
			case 3:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ReplyMail.Ⴅ(2, 5, 1217945359), 919, 916);
				num = ⴀႳ[261] - 25317;
				break;
			case 12:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), SetStationClubHelp.Ⴍ(5, 0, 1747258264, null), 116, 119);
				num = ⴃႠ[243] - 16807;
				break;
			case 1:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ShowSkimCtyHelp.Ⴍ(1216134552, 6, '_'), 647, 644);
				num = ⴃႰ[112] - 2879;
				break;
			case 0:
				(textWriter as StreamWriter).WriteLine(SetStationClubHelp.Ⴍ(2, 5, 1747258269, null));
				goto case 6;
			case 6:
				(textWriter as StreamWriter).WriteLine(ႰႥ.Ⴅ(4, '²', 952619130));
				num = 11;
				break;
			case 7:
			case 11:
				(textWriter as StreamWriter).WriteLine(CallBlockCacheCfg.Ⴅ(null, 1, 62056737, null));
				((StreamWriter)textWriter).Close();
				return;
			}
		}
	}

	private static void Ⴜ(string P_0)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 12;
		TextWriter textWriter = default(TextWriter);
		while (true)
		{
			switch (num)
			{
			default:
				textWriter = new StreamWriter(P_0);
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, CallBlockCacheCfg.Ⴅ(null, 8, 62056825, null), 351, 348);
				num = ⴄႭ[66];
				break;
			case 0:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, ႰႥ.Ⴅ(8, '$', 952620234), 273, 274);
				num = 3;
				break;
			case 3:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ႰႥ.Ⴅ(3, '\u0019', 952620225), 618, 617);
				num = 10;
				break;
			case 10:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, SetStationClubHelp.Ⴍ(6, 4, 1747258268, null), 141, 142);
				num = 2;
				break;
			case 2:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, CallBlockCacheCfg.Ⴅ(null, 7, 62056654, null), 50, 49);
				goto case 9;
			case 9:
				num = 5;
				break;
			case 5:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, ReplyMail.Ⴅ(8, 14, 1217945349), 793, 794);
				num = ⴍႭ[103] - 29777;
				break;
			case 6:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, SetStationClubHelp.Ⴍ(13, 2, 1747258266, null), 700, 703);
				num = ⴃႰ[2] - 38923;
				break;
			case 7:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ShowSkimCtyHelp.Ⴍ(1216134552, 6, '\u008b'), 3, 0);
				num = 4;
				break;
			case 4:
				((StreamWriter)textWriter).WriteLine(SetStationClubHelp.Ⴍ(8, 5, 1747258269, null));
				(textWriter as StreamWriter).WriteLine(ႰႥ.Ⴅ(5, '\u0013', 952619131));
				goto case 8;
			case 8:
			case 11:
				num = ⴃႰ[77] - 47443;
				break;
			case 1:
				((StreamWriter)textWriter).WriteLine(CallBlockCacheCfg.Ⴅ(null, 2, 62056738, null));
				((StreamWriter)textWriter).Close();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႤ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, int P_3) where _0021_00210 : WxCfg
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴍႭ[107] - 31421;
				break;
			case 4:
			case 6:
				num = (((P_3 ^ P_2) - 55) ^ num2) switch
				{
					0 => 7, 
					_ => ⴀႼ[80] * 8, 
				};
				break;
			case 0:
				num = ⴄႷ[135] - 15684;
				break;
			case 7:
				P_0.NmbrSpots = P_1;
				goto case 8;
			case 8:
				num2++;
				AnnCacheCfg.ႠႼ[20] = (byte)((AnnCacheCfg.ႠႼ[20] + SetAnnChatRooms.Ⴀ[250]) & 0xA);
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴀႳ[116] - 39966) : 5);
				break;
			case 5:
			case 9:
				num = 4;
				break;
			case 2:
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႥႥ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 2:
					num2 = (((P_2 ^ P_1) - 38) ^ num) switch
					{
						0 => 5, 
						_ => 8, 
					};
					continue;
				case 8:
					result = false;
					goto case 4;
				case 4:
					num2 = ⴀႳ[329] - ⴀႳ[329];
					continue;
				case 5:
					result = string.IsNullOrEmpty(P_0);
					num2 = 0;
					continue;
				case 0:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 10;
					continue;
				case 10:
					num2 = ((num3 % 2 != 0) ? (ⴃႰ[75] - 29857) : (ⴍႤ[112] - 2570));
					continue;
				case 1:
				case 7:
					return result;
				case 6:
					num2 = ⴀ[351] - 58088;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ICryptoTransform ႥႷ<_0021_00210>(_0021_00210 P_0, byte[] P_1, byte[] P_2, char P_3, short P_4) where _0021_00210 : SymmetricAlgorithm
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
					break;
				case 6:
					ShowQrzHelp.ႤႤ[218] = (byte)((ShowQrzHelp.ႤႤ[218] - P_4) & 0x10);
					num2 = (((P_3 ^ P_4) - 62) ^ num) switch
					{
						0 => 10, 
						1 => ⴀ[197] - 6384, 
						_ => 7, 
					};
					continue;
				case 7:
				case 8:
					obj = null;
					num2 = ⴀႣ[424] - 4358;
					continue;
				case 10:
					obj = P_0.CreateEncryptor(P_1, P_2);
					goto case 1;
				case 1:
					num2 = 12;
					continue;
				case 9:
					obj = P_0.CreateDecryptor(P_1, P_2);
					num2 = 12;
					continue;
				case 4:
				case 12:
				{
					num++;
					int num3 = 728;
					int num4 = 846;
					num2 = ((8460 > num4 - num3 * 10) ? 5 : 2);
					continue;
				}
				case 2:
					num2 = ⴃႥ[15] - 9480;
					continue;
				case 5:
					return (ICryptoTransform)obj;
				case 0:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႣ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : string where _0021_00211 : IrcCommands
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 7;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴃႰ[72] - 45578;
				break;
			case 6:
			case 8:
				num = (((P_3 ^ P_2) - 19) ^ num3) switch
				{
					0 => 5, 
					_ => ⴅ[62] - ⴅ[59], 
				};
				break;
			case 0:
			case 1:
				num = 4;
				break;
			case 5:
				P_0.RfcJoin(P_1);
				goto case 4;
			case 4:
				num3++;
				goto case 3;
			case 3:
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 9;
				break;
			case 9:
				num = ((num2 % 2 != 0) ? 6 : 2);
				break;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static OutputType ႥႭ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : AnnCfg
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		OutputType result = default(OutputType);
		while (true)
		{
			int num = 0;
			int num2 = 11;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 6;
					continue;
				case 6:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 6) ^ num) switch
					{
						0 => 1, 
						_ => 3, 
					};
					continue;
				case 0:
				case 3:
					result = OutputType.Off;
					num2 = 9;
					continue;
				case 1:
					result = P_0.Output;
					num2 = 9;
					continue;
				case 4:
				case 9:
				{
					num++;
					int num3 = 481;
					int num4 = 818;
					num2 = ((4090 > num4 - num3 * 5) ? ⴐ[243] : (ⴀ[201] - 60560));
					continue;
				}
				case 2:
					num2 = ⴄႤ[491] / 4;
					continue;
				case 8:
				case 10:
					return result;
				case 7:
					num2 = ⴅ[315] - 186;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႥႳ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : ArcLogInResp
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		IEnumerable enumerable = default(IEnumerable);
		int num3 = default(int);
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 42) ^ num) switch
					{
						0 => ⴄႤ[138] - 63, 
						_ => ⴅ[360] - 193, 
					};
					continue;
				case 3:
					enumerable = null;
					goto case 0;
				case 0:
					num2 = ⴍႤ[488] - 14195;
					continue;
				case 7:
				case 8:
					enumerable = P_0.Alias;
					num2 = ⴄႭ[450] - 225;
					continue;
				case 5:
					num++;
					num3 = 2115;
					goto case 2;
				case 2:
				{
					int num4 = 683;
					num2 = ((705 < num3 / 3 - num4) ? (ⴀႳ[256] - 20167) : 9);
					continue;
				}
				case 9:
					return (string)enumerable;
				case 4:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}
}
