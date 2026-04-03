using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Security;
using System.Windows.Forms;
using ArcInterfaces.Io;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods.Login;
using ArcShared.Forms;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class UtilsSql
{
	internal sealed class Ⴓ
	{
		internal ComboBox Ⴃ;

		internal Ⴓ()
		{
		}
	}

	internal sealed class ႨႠ
	{
		internal OnIoClientRxEventHandler Ⴄ;

		internal OnIoClientConnectEventHandler Ⴀ;

		internal OnIoClientDisconnectEventHandler Ⴐ;

		internal byte[] Ⴅ;

		internal ConnectionState Ⴈ;

		internal string Ⴃ;

		internal DateTime Ⴍ;

		internal int Ⴓ;

		internal int Ⴗ;

		internal double[] Ⴜ;

		internal ႨႠ()
		{
		}
	}

	internal sealed class ႨႥ
	{
		internal bool Ⴐ;

		internal string Ⴈ;

		internal string Ⴄ;

		internal string Ⴓ;

		internal bool Ⴅ;

		internal ႣႼ Ⴗ;

		internal ႨႥ()
		{
		}
	}

	public static string ScrubSql(string msg)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		while (true)
		{
			msg = DgvFilterManager.ႭႭ(msg, TelnetServerClient.Ⴄ(1945322699, 'ò', 3), ႣႼ.Ⴜ(6, 365387211, 28), 899, 993);
			while (true)
			{
				IL_0061:
				int num = ⴀ[387] - 45968;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 1;
						continue;
					case 1:
					case 3:
						break;
					case 0:
						goto IL_0061;
					case 4:
						return msg;
					}
					break;
				}
				break;
			}
		}
	}

	public static string UnFormatSqlFilter(string sql)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		while (true)
		{
			sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506747, 28, 7), ႣႼ.ႥႭ(null, 624736162, 5, null), 856, 826);
			int num = ⴐ[558] - 19597;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 4;
					continue;
				case 4:
					break;
				case 0:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706507245, 20, 5), ႣႼ.ႥႭ(sql, 624736163, 4, null), 795, 889);
					num = 3;
					continue;
				case 3:
					sql = DgvFilterManager.ႭႭ(sql, TelnetServerClient.Ⴄ(1945322703, 'l', 7), string.Empty, 566, 596);
					num = 7;
					continue;
				case 7:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506750, 28, 7), UtilsString.Ⴐ(null, 2, 192632537), 414, 508);
					num = 5;
					continue;
				case 5:
					sql = sql.Replace(ArcLogInRqstExt.Ⴗ(1706506504, 27, 6), UtilsString.Ⴐ(null, 3, 192632531));
					num = 9;
					continue;
				case 6:
				case 9:
					sql = Ⴅ(sql);
					sql = UnScrubSqlToSqlSvrExpress(sql);
					goto case 1;
				case 1:
					return sql;
				}
				break;
			}
		}
	}

	public static string UnScrubSqlToSqlSvrExpress(string sql)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		while (true)
		{
			sql = UtilsString.ScrubSpaces(UtilsDate.Ⴓ(sql, '\u0382', 924));
			sql = DxAtlasData.Ⴄ((object)' ', (object)sql, (object)' ', 980, 'λ');
			int num = ⴐ[415] - 57862;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 10;
					continue;
				case 10:
					break;
				case 8:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506518, 4, 1), UtilsString.Ⴐ(null, 6, 192632552), 847, 813);
					num = 9;
					continue;
				case 9:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506531, 23, 6), UtilsString.Ⴐ(null, 3, 192632573), 60, 94);
					goto case 13;
				case 13:
					num = 26;
					continue;
				case 26:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506541, 4, 5), UtilsString.Ⴐ(null, 5, 192632456), 380, 286);
					num = 6;
					continue;
				case 6:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506544, 28, 2), UtilsString.Ⴐ(null, 3, 192632450), 709, 679);
					num = ⴗ[55] - 6825;
					continue;
				case 3:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506554, 14, 1), UtilsString.Ⴐ(null, 2, 192632472), 890, 792);
					num = 11;
					continue;
				case 11:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506572, 20, 4), UtilsString.Ⴐ(null, 4, 192632495), 132, 230);
					num = ⴗ[115] - 18165;
					continue;
				case 5:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506576, 28, 3), UtilsString.Ⴐ(null, 7, 192632500), 862, 828);
					num = ⴐ[437] - 33214;
					continue;
				case 19:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506594, 16, 8), UtilsString.Ⴐ(null, 2, 192632642), 477, 447);
					num = 37;
					continue;
				case 37:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506617, 4, 0), UtilsString.Ⴐ(null, 5, 192632662), 992, 898);
					num = ⴐ[41] - 59277;
					continue;
				case 15:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506378, 1, 4), UtilsString.Ⴐ(null, 3, 192632675), 1023, 925);
					num = ⴃႤ[264] - 53622;
					continue;
				case 22:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506391, 21, 7), UtilsString.Ⴐ(null, 2, 192632694), 601, 571);
					num = 4;
					continue;
				case 4:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506401, 7, 3), UtilsString.Ⴐ(null, 2, 192632578), 522, 616);
					num = ⴃႤ[111] - 29459;
					continue;
				case 0:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506419, 30, 1), UtilsString.Ⴐ(null, 1, 192632595), 974, 940);
					num = ⴃႣ[106] - 63620;
					continue;
				case 18:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506435, 9, 3), UtilsString.Ⴐ(null, 3, 192632609), 872, 778);
					num = 16;
					continue;
				case 16:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506449, 10, 2), UtilsString.Ⴐ(null, 6, 192632779), 726, 692);
					num = 38;
					continue;
				case 38:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506470, 26, 0), UtilsString.Ⴐ(null, 3, 192632771), 597, 567);
					num = 7;
					continue;
				case 7:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506485, 10, 1), UtilsString.Ⴐ(null, 2, 192632814), 35, 65);
					num = 32;
					continue;
				case 32:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506246, 10, 6), UtilsString.Ⴐ(null, 8, 192632810), 184, 218);
					num = ⴀ[21] - 21554;
					continue;
				case 1:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506258, 5, 4), UtilsString.Ⴐ(null, 5, 192632819), 431, 461);
					num = ⴀ[320] - 27667;
					continue;
				case 29:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506269, 20, 4), UtilsString.Ⴐ(null, 5, 192632716), 1013, 919);
					num = ⴃႤ[320] - 20158;
					continue;
				case 25:
				case 27:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506276, 3, 7), UtilsString.Ⴐ(null, 0, 192632705), 387, 481);
					num = 33;
					continue;
				case 33:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506294, 15, 2), UtilsString.Ⴐ(null, 1, 192632735), 785, 883);
					num = 39;
					continue;
				case 39:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506296, 25, 1), UtilsString.Ⴐ(null, 2, 192632721), 176, 210);
					num = ⴗ[101] - 49580;
					continue;
				case 34:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506308, 10, 8), UtilsString.Ⴐ(null, 6, 192632748), 237, 143);
					num = ⴐ[448] - 7379;
					continue;
				case 28:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506322, 30, 3), UtilsString.Ⴐ(null, 5, 192632762), 922, 1016);
					num = ⴃႤ[406] - 38129;
					continue;
				case 21:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506339, 21, 3), UtilsString.Ⴐ(null, 1, 192632755), 679, 709);
					num = 36;
					continue;
				case 36:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506353, 1, 4), UtilsString.Ⴐ(null, 2, 192631877), 390, 484);
					num = 30;
					continue;
				case 30:
					sql = sql.Replace(ArcLogInRqstExt.Ⴗ(1706506366, 9, 1), UtilsString.Ⴐ(null, 6, 192631897));
					num = ⴗ[23] - 59648;
					continue;
				case 24:
					sql = sql.Replace(ArcLogInRqstExt.Ⴗ(1706508168, 1, 1), UtilsString.Ⴐ(null, 3, 192631916));
					num = 20;
					continue;
				case 20:
					sql = sql.Replace(ArcLogInRqstExt.Ⴗ(1706508187, 29, 2), UtilsString.Ⴐ(null, 0, 192631808));
					num = ⴃႭ[43] - 34333;
					continue;
				case 12:
				case 17:
					sql = sql.Replace(ArcLogInRqstExt.Ⴗ(1706508202, 21, 5), UtilsString.Ⴐ(null, 2, 192631830));
					num = 35;
					continue;
				case 35:
					sql = sql.Replace(ArcLogInRqstExt.Ⴗ(1706508221, 19, 5), UtilsString.Ⴐ(null, 1, 192631844));
					num = 31;
					continue;
				case 31:
					sql = sql.Replace(ArcLogInRqstExt.Ⴗ(1706508224, 1, 3), UtilsString.Ⴐ(null, 7, 192631867));
					num = 23;
					continue;
				case 23:
					sql = sql.Replace(ArcLogInRqstExt.Ⴗ(1706508245, 27, 4), UtilsString.Ⴐ(null, 0, 192631856));
					num = ⴗ[52] - 52149;
					continue;
				case 14:
					return sql.Trim();
				}
				break;
			}
		}
	}

	public static string ScrubSqlToSqlSvrExpress(string sql)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			sql = UtilsString.ScrubSpaces(UtilsDate.Ⴓ(sql, 'ů', 369));
			sql = DxAtlasData.Ⴄ((object)' ', (object)sql, (object)' ', 483, 'ƌ');
			int num = ⴃႣ[93] - 25898;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႤ[135] - 4022;
					continue;
				case 37:
					break;
				case 13:
				case 23:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 1, 192632559), ArcLogInRqstExt.Ⴗ(1706506518, 0, 1), 786, 880);
					num = 36;
					continue;
				case 36:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 4, 192632570), ArcLogInRqstExt.Ⴗ(1706506534, 12, 3), 747, 649);
					num = 1;
					continue;
				case 1:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 3, 192632462), ArcLogInRqstExt.Ⴗ(1706506536, 15, 0), 628, 534);
					num = ⴃႤ[446] - 63145;
					continue;
				case 8:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 3, 192632450), ArcLogInRqstExt.Ⴗ(1706506546, 18, 0), 463, 429);
					num = ⴀ[23] - 47026;
					continue;
				case 31:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 2, 192632472), ArcLogInRqstExt.Ⴗ(1706506558, 25, 5), 873, 779);
					num = ⴀ[303] - 4120;
					continue;
				case 11:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 3, 192632488), ArcLogInRqstExt.Ⴗ(1706506568, 13, 0), 345, 315);
					num = 26;
					continue;
				case 26:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 7, 192632500), ArcLogInRqstExt.Ⴗ(1706506580, 28, 7), 185, 219);
					num = 38;
					continue;
				case 38:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 1, 192632641), ArcLogInRqstExt.Ⴗ(1706506601, 20, 3), 212, 182);
					num = ⴃႭ[216] - 27111;
					continue;
				case 28:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 3, 192632656), ArcLogInRqstExt.Ⴗ(1706506622, 11, 7), 837, 807);
					num = 7;
					continue;
				case 7:
				{
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 3, 192632675), ArcLogInRqstExt.Ⴗ(1706506382, 20, 0), 284, 382);
					char num2 = ⴗ[51];
					DataGridViewColumnSelector.Ⴐ[548] = (char)((DataGridViewColumnSelector.Ⴐ[548] | DataGridViewColumnSelector.Ⴐ[125]) & 0xFB);
					num = num2 - 12307;
					continue;
				}
				case 27:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 3, 192632695), ArcLogInRqstExt.Ⴗ(1706506392, 6, 8), 937, 971);
					num = ⴀ[166] - 10216;
					continue;
				case 5:
				case 16:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 2, 192632578), ArcLogInRqstExt.Ⴗ(1706506402, 2, 0), 318, 348);
					num = 20;
					continue;
				case 20:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 6, 192632596), ArcLogInRqstExt.Ⴗ(1706506423, 20, 5), 934, 964);
					num = 25;
					continue;
				case 25:
					sql = DgvFilterManager.ႭႭ(sql, ArcLogInRqstExt.Ⴗ(1706506440, 30, 8), UtilsString.Ⴐ(null, 8, 192632618), 259, 353);
					num = 3;
					continue;
				case 3:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 5, 192632776), ArcLogInRqstExt.Ⴗ(1706506450, 19, 1), 661, 759);
					num = 19;
					continue;
				case 19:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 6, 192632774), ArcLogInRqstExt.Ⴗ(1706506468, 0, 2), 477, 447);
					goto case 35;
				case 35:
					num = ⴃႭ[197] - 28501;
					continue;
				case 10:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 3, 192632815), ArcLogInRqstExt.Ⴗ(1706506492, 31, 8), 789, 887);
					num = ⴀ[110] - 48919;
					continue;
				case 21:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 3, 192632801), ArcLogInRqstExt.Ⴗ(1706506246, 31, 6), 492, 398);
					num = 24;
					continue;
				case 24:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 1, 192632823), ArcLogInRqstExt.Ⴗ(1706506262, 27, 0), 180, 214);
					num = 32;
					continue;
				case 32:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 3, 192632714), ArcLogInRqstExt.Ⴗ(1706506264, 19, 1), 231, 133);
					num = 33;
					continue;
				case 33:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 0, 192632705), ArcLogInRqstExt.Ⴗ(1706506283, 29, 8), 291, 321);
					num = 39;
					continue;
				case 39:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 7, 192632729), ArcLogInRqstExt.Ⴗ(1706506292, 3, 0), 625, 531);
					num = 30;
					continue;
				case 30:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 3, 192632720), ArcLogInRqstExt.Ⴗ(1706506289, 17, 8), 323, 289);
					num = 14;
					continue;
				case 14:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 6, 192632748), ArcLogInRqstExt.Ⴗ(1706506314, 13, 6), 348, 318);
					num = ⴃႤ[532] - 51844;
					continue;
				case 22:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 6, 192632761), ArcLogInRqstExt.Ⴗ(1706506329, 29, 8), 103, 5);
					num = 29;
					continue;
				case 29:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 8, 192632762), ArcLogInRqstExt.Ⴗ(1706506341, 4, 5), 400, 498);
					num = 17;
					continue;
				case 17:
					sql = DgvFilterManager.ႭႭ(sql, UtilsString.Ⴐ(null, 0, 192631879), ArcLogInRqstExt.Ⴗ(1706506352, 15, 5), 987, 953);
					num = 18;
					continue;
				case 18:
					sql = sql.Replace(UtilsString.Ⴐ(null, 3, 192631900), ArcLogInRqstExt.Ⴗ(1706506359, 4, 8));
					num = ⴃႤ[305] - 20866;
					continue;
				case 15:
					sql = sql.Replace(UtilsString.Ⴐ(null, 5, 192631914), ArcLogInRqstExt.Ⴗ(1706508161, 8, 8));
					num = 12;
					continue;
				case 12:
					sql = sql.Replace(UtilsString.Ⴐ(null, 2, 192631810), ArcLogInRqstExt.Ⴗ(1706508184, 0, 1));
					num = ⴃႭ[49] - 57555;
					continue;
				case 34:
					sql = sql.Replace(UtilsString.Ⴐ(null, 2, 192631830), ArcLogInRqstExt.Ⴗ(1706508205, 14, 2));
					num = 0;
					continue;
				case 0:
					sql = sql.Replace(UtilsString.Ⴐ(null, 0, 192631845), ArcLogInRqstExt.Ⴗ(1706508208, 31, 8));
					num = 6;
					continue;
				case 6:
					sql = sql.Replace(UtilsString.Ⴐ(null, 8, 192631860), ArcLogInRqstExt.Ⴗ(1706508229, 4, 6));
					num = 4;
					continue;
				case 4:
					sql = sql.Replace(UtilsString.Ⴐ(null, 4, 192631860), ArcLogInRqstExt.Ⴗ(1706508242, 10, 3));
					num = 9;
					continue;
				case 9:
					return sql.Trim();
				}
				break;
			}
		}
	}

	private static string Ⴅ(string P_0)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char c = default(char);
		object obj2 = default(object);
		int num2 = default(int);
		while (true)
		{
			object obj = ArcLogInRespExt.Ⴐ(UtilsXml.Ⴗ(P_0, 908, 'Ν'), 206, 143);
			int num = ⴗ[140] - 43350;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀ[305] - 48549;
					continue;
				case 5:
				case 12:
					break;
				case 10:
					c = ' ';
					obj2 = string.Empty;
					num2 = 0;
					num = 9;
					continue;
				case 6:
				case 11:
					num = (((obj as char[])[num2] != '#') ? (ⴃႣ[21] - 1865) : 4);
					continue;
				case 4:
				{
					int num4;
					if (c == '-')
					{
						char num3 = ⴃႭ[10];
						WxCfg.ႣႭ[284] = (char)((WxCfg.ႣႭ[284] - DataGridViewColumnSelector.Ⴐ[463]) & 0x3D);
						num4 = num3 - 46796;
					}
					else
					{
						num4 = ⴃႭ[122] - 60700;
					}
					num = num4;
					continue;
				}
				case 7:
					obj2 = ႰႣ.Ⴀ((object)(string)obj2, (object)((char[])obj)[num2], (short)687, 749);
					num = ⴃႣ[70] - 48564;
					continue;
				case 3:
				case 8:
					c = ((char[])obj)[num2];
					num = 1;
					continue;
				case 1:
					num2++;
					num = 9;
					continue;
				case 9:
					num = ((num2 < (obj as char[]).Length) ? 11 : 2);
					continue;
				case 2:
					return obj2 as string;
				}
				break;
			}
		}
	}

	public static string FormatSqlFilter(string sqlIn, SqlFilterType sqlFilterType)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num2 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		IConvertible convertible = default(IConvertible);
		int num7 = default(int);
		ICloneable cloneable = default(ICloneable);
		int num5 = default(int);
		while (true)
		{
			IComparable comparable = string.Empty;
			sqlIn = UtilsString.ScrubSpaces(sqlIn);
			sqlIn = Ⴐ(sqlIn);
			string text = sqlIn;
			Array array = new char[1];
			((char[])array)[0] = ' ';
			object obj = ႰႨ.ႨႥ(text, (char[])array, 50, 83);
			int num = 7;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 19;
					continue;
				case 19:
					break;
				case 7:
					num2 = 0;
					num = 40;
					continue;
				case 22:
					_ = (obj as string[])[num2];
					num = (Ⴐ(obj as string[], num2) ? 1 : 39);
					continue;
				case 1:
					num4 = 0;
					num = 5;
					continue;
				case 37:
					num = num4 switch
					{
						0 => 41, 
						1 => 41, 
						2 => ⴐ[6] - 53044, 
						3 => ⴃႤ[402] - 56071, 
						_ => ⴃႭ[36] - 6371, 
					};
					continue;
				case 8:
					num = 0;
					continue;
				case 41:
					comparable = DxAtlasData.Ⴄ((object)(comparable as string), (object)(obj as string[])[num2 + num4], (object)' ', 770, '\u036d');
					num = ⴐ[169] - 41040;
					continue;
				case 4:
					comparable = HelpAboutServer.Ⴗ(comparable as string, DownloadUrl2.Ⴅ(23, null, 2018868141, 4), ((string[])obj)[num2 + num4], ႣႼ.Ⴜ(2, 365387204, 17), 421, 'ǋ');
					num = ⴀ[259] - 39336;
					continue;
				case 42:
					comparable = HelpAboutServer.Ⴗ((string)comparable, ႣႼ.Ⴜ(5, 365387203, 25), ((string[])obj)[num2 + num4], ArcLogInRqstExt.Ⴗ(1706508261, 4, 0), 949, 'ϛ');
					num = 0;
					continue;
				case 0:
					num4++;
					num = ⴗ[157] - 44218;
					continue;
				case 5:
				{
					int num3 = num4;
					DataGridViewColumnSelector.Ⴐ[439] = (char)((DataGridViewColumnSelector.Ⴐ[439] + DataGridViewColumnSelector.Ⴐ[503]) & 0xD9);
					num = ((num3 >= 4) ? 46 : 13);
					continue;
				}
				case 13:
					num = ((num2 + num4 < (obj as string[]).Length) ? 37 : 46);
					continue;
				case 46:
				case 54:
					num2 += 3;
					num = ⴐ[284] - 7845;
					continue;
				case 39:
					num = ((!Ⴈ((string[])obj, num2, sqlFilterType)) ? (ⴗ[105] - 4831) : (ⴗ[141] - 5940));
					continue;
				case 2:
					num6 = 0;
					num = ⴃႭ[101] - 25667;
					continue;
				case 28:
					num = num6 switch
					{
						0 => 33, 
						1 => 38, 
						2 => 36, 
						_ => 31, 
					};
					continue;
				case 31:
					num = ⴃႭ[100] - 29741;
					continue;
				case 33:
					comparable = DxAtlasData.Ⴄ((object)(comparable as string), (object)(obj as string[])[num2 + num6], (object)' ', 17, '~');
					num = 45;
					continue;
				case 38:
					comparable = ReverseBeaconClient.Ⴗ((string)comparable, ArcLogInRqstExt.Ⴗ(1706508257, 22, 3), 'ē', 'ś');
					num = 45;
					continue;
				case 36:
					convertible = (obj as string[])[num2 + num6];
					convertible = DgvFilterManager.ႭႭ(convertible as string, ႣႼ.ႥႭ(null, 624736164, 3, null), ႣႼ.Ⴜ(0, 365387589, 21), 70, 36);
					num = ⴐ[226] - 17041;
					continue;
				case 6:
					comparable = HelpAboutServer.Ⴗ(comparable as string, DownloadUrl2.Ⴅ(24, null, 2018868137, 0), (string)convertible, ArcLogInRqstExt.Ⴗ(1706508260, 4, 1), 212, 'º');
					num = 45;
					continue;
				case 45:
					num6++;
					num = ⴗ[152] - 36421;
					continue;
				case 23:
					num = ((num6 >= 3) ? (ⴃႭ[164] - 42295) : (ⴃႭ[10] - 46769));
					continue;
				case 34:
					num = ((num2 + num6 < (obj as string[]).Length) ? 28 : 51);
					continue;
				case 51:
					num2 += 2;
					goto case 14;
				case 14:
					num = 27;
					continue;
				case 44:
					num = ((!Ⴐ((string[])obj, num2, sqlFilterType)) ? (ⴐ[14] - 34443) : 47);
					continue;
				case 47:
					num7 = 0;
					num = ⴀ[134] - 27313;
					continue;
				case 21:
					num = num7 switch
					{
						0 => ⴃႭ[161] - 54192, 
						1 => ⴃႣ[2] - 5244, 
						2 => ⴃႭ[17] - 6271, 
						_ => ⴃႭ[222] - 35843, 
					};
					continue;
				case 10:
					num = ⴃႤ[90] - 11425;
					continue;
				case 49:
					comparable = DxAtlasData.Ⴄ((object)(comparable as string), (object)((string[])obj)[num2 + num7], (object)' ', 161, 'Î');
					num = ⴀ[179] - 61926;
					continue;
				case 24:
					comparable = ReverseBeaconClient.Ⴗ(comparable as string, ႣႼ.Ⴜ(7, 365387614, 3), 'ǎ', 'Ɔ');
					num = 30;
					continue;
				case 48:
					cloneable = (obj as string[])[num2 + num7];
					cloneable = DgvFilterManager.ႭႭ((string)cloneable, ႣႼ.ႥႭ(null, 624736160, 7, null), ႣႼ.Ⴜ(4, 365387585, 12), 442, 472);
					num = ⴃႤ[210] - 27376;
					continue;
				case 20:
					comparable = HelpAboutServer.Ⴗ((string)comparable, DownloadUrl2.Ⴅ(23, null, 2018868129, 8), (string)cloneable, ArcLogInRqstExt.Ⴗ(1706508269, 29, 8), 494, 'ƀ');
					num = 30;
					continue;
				case 30:
					num7++;
					num = ⴃႭ[177] - 31731;
					continue;
				case 50:
					num = ((num7 >= 3) ? (ⴐ[237] - 23080) : 11);
					continue;
				case 11:
					num = ((num2 + num7 < ((string[])obj).Length) ? 21 : (ⴐ[520] - 5382));
					continue;
				case 15:
					num2 += 2;
					num = 27;
					continue;
				case 43:
					num = ((!Ⴀ(obj as string[], num2, sqlFilterType)) ? (ⴃႭ[216] - 27122) : 52);
					continue;
				case 52:
					num5 = 0;
					num = 12;
					continue;
				case 16:
					num = num5 switch
					{
						0 => 18, 
						1 => ⴃႣ[239] - 39434, 
						2 => 29, 
						_ => ⴗ[28] - 12121, 
					};
					continue;
				case 3:
					num = ⴐ[38] - 2349;
					continue;
				case 18:
					comparable = DxAtlasData.Ⴄ((object)(string)comparable, (object)(obj as string[])[num2 + num5], (object)' ', 281, 'Ŷ');
					num = 53;
					continue;
				case 29:
					comparable = HelpAboutServer.Ⴗ((string)comparable, DownloadUrl2.Ⴅ(27, null, 2018868129, 8), (obj as string[])[num2 + num5], ArcLogInRqstExt.Ⴗ(1706508261, 16, 0), 818, '\u035c');
					num = ⴗ[12] - 35038;
					continue;
				case 53:
					num5++;
					num = ⴐ[196] - 11162;
					continue;
				case 12:
					num = ((num5 >= 3) ? 32 : 25);
					continue;
				case 25:
					num = ((num2 + num5 < ((string[])obj).Length) ? (ⴃႤ[315] - 16707) : 32);
					continue;
				case 9:
				case 32:
					num2 += 2;
					num = 27;
					continue;
				case 17:
					comparable = (string)comparable + ((string[])obj)[num2] + ' ';
					num = ⴃႤ[251] - 7342;
					continue;
				case 27:
					num2++;
					num = ⴃႭ[65] - 41687;
					continue;
				case 40:
					num = ((num2 < (obj as string[]).Length) ? (ⴃႤ[430] - 33393) : (ⴃႣ[28] - 41355));
					continue;
				case 35:
					comparable = UtilsString.ScrubSpaces((string)comparable);
					comparable = Ⴀ(comparable as string);
					return (string)comparable;
				}
				break;
			}
		}
	}

	private static string Ⴀ(string P_0)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		while (true)
		{
			P_0 = DgvFilterManager.ႭႭ(P_0, UtilsString.Ⴐ(null, 1, 192631960), ႣႼ.ႥႭ(null, 624735737, 1, null), 611, 513);
			while (true)
			{
				IL_0067:
				int num = ⴃႤ[222];
				DataGridViewColumnSelector.Ⴐ[564] = (char)((DataGridViewColumnSelector.Ⴐ[564] + DataGridViewColumnSelector.Ⴐ[416]) & 0x57);
				int num2 = num - 57356;
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
					case 4:
						goto IL_0067;
					case 3:
						P_0 = DgvFilterManager.ႭႭ(P_0, UtilsString.Ⴐ(null, 2, 192631994), ႣႼ.Ⴜ(7, 365387616, 3), 601, 571);
						goto case 2;
					case 2:
						num2 = ⴃႭ[177] - 31776;
						continue;
					case 1:
					case 5:
						return P_0;
					}
					break;
				}
				break;
			}
		}
	}

	private static bool Ⴐ(string[] P_0, int P_1, SqlFilterType P_2)
	{
		while (true)
		{
			int num = ((!Ⴄ(P_0[P_1], P_2)) ? 2 : 4);
			while (true)
			{
				int result;
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 6;
					continue;
				case 6:
					break;
				case 4:
				{
					bool num2 = FrmUpdating.ႠႥ(P_0[P_1 + 1], ႣႼ.ႥႭ(null, 624736248, 2, null), 545, 541);
					NeedsCfg.ႣႤ[410] = (NeedsCfg.ႣႤ[410] + P_1) & 0x94;
					num = ((!num2) ? 2 : 3);
					continue;
				}
				case 0:
				case 3:
				case 5:
					result = (AutoUpdater.ႨႰ(P_0[P_1 + 2], ႣႼ.ႥႭ(null, 624736163, 4, null), 634, 'Ȓ') ? 1 : 0);
					goto IL_00b3;
				case 2:
				case 7:
					{
						result = 0;
						goto IL_00b3;
					}
					IL_00b3:
					return (byte)result != 0;
				}
				break;
			}
		}
	}

	private static bool Ⴈ(string[] P_0, int P_1, SqlFilterType P_2)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		bool result = default(bool);
		while (true)
		{
			bool num = Ⴄ(P_0[P_1], P_2);
			UtilsNumeric.Ⴀ[368] = (char)((UtilsNumeric.Ⴀ[368] | DxCfg.Ⴗ[16]) & 0xE);
			int num2 = (num ? (ⴃႣ[190] - 32278) : 0);
			while (true)
			{
				int result2;
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 4;
					continue;
				case 4:
					break;
				case 2:
					num2 = (FrmUpdating.ႠႥ(P_0[P_1 + 1], ArcLogInRqstExt.Ⴗ(1706507138, 0, 1), 486, 474) ? 6 : 0);
					continue;
				case 1:
				case 3:
				case 6:
					result2 = (AutoUpdater.ႨႰ(P_0[P_1 + 2], ႣႼ.ႥႭ(null, 624736162, 5, null), 679, 'ˏ') ? 1 : 0);
					goto IL_00c8;
				case 0:
					result2 = 0;
					goto IL_00c8;
				case 7:
					{
						return result;
					}
					IL_00c8:
					return (byte)result2 != 0;
				}
				break;
			}
		}
	}

	private static bool Ⴀ(string[] P_0, int P_1, SqlFilterType P_2)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		IComparable comparable2 = default(IComparable);
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			int num = ((P_1 + 2 < P_0.Length) ? (ⴃႤ[313] - 60969) : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 1;
					continue;
				case 1:
					break;
				case 5:
				case 7:
					comparable2 = UtilsDate.Ⴓ(P_0[P_1], '\u009e', 128);
					comparable = P_0[P_1 + 1];
					goto case 2;
				case 2:
					num = 3;
					continue;
				case 3:
					num = (Ⴄ((string)comparable2, P_2) ? (ⴃႣ[206] - 36150) : 0);
					continue;
				case 6:
				case 9:
					num = (Ⴗ((string)comparable) ? 4 : 0);
					continue;
				case 4:
					return true;
				case 0:
					return false;
				}
				break;
			}
		}
	}

	private static bool Ⴄ(string P_0, SqlFilterType P_1)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		while (true)
		{
			P_0 = UtilsDate.Ⴓ(P_0, 'Ĩ', 310);
			int num = P_1 switch
			{
				SqlFilterType.Dx => 7, 
				SqlFilterType.AnnWx => 0, 
				SqlFilterType.Wwv => ⴀ[227] - 8002, 
				SqlFilterType.Log => ⴗ[74] - 30196, 
				_ => 28, 
			};
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႭ[246] - 52416;
					continue;
				case 10:
					break;
				case 28:
					num = ⴀ[31] - 18953;
					continue;
				case 7:
					num = (FrmUpdating.ႠႥ(P_0, ႣႼ.Ⴜ(4, 365387550, 31), 305, 269) ? 32 : 43);
					continue;
				case 43:
					num = (FrmUpdating.ႠႥ(P_0, DownloadUrl2.Ⴅ(30, null, 2018867259, 7), 215, 235) ? 32 : (ⴀ[317] - 4355));
					continue;
				case 25:
					num = (FrmUpdating.ႠႥ(P_0, ArcLogInRqstExt.Ⴗ(1706508050, 30, 2), 157, 161) ? 32 : (ⴗ[144] - 45242));
					continue;
				case 3:
					num = (FrmUpdating.ႠႥ(P_0, ႣႼ.Ⴜ(1, 365387561, 17), 352, 348) ? (ⴗ[75] - 9501) : (ⴀ[122] - 49714));
					continue;
				case 5:
					num = (FrmUpdating.ႠႥ(P_0, DownloadUrl2.Ⴅ(21, null, 2018867239, 8), 340, 360) ? 32 : (ⴃႤ[159] - 6836));
					continue;
				case 15:
				case 44:
					num = (FrmUpdating.ႠႥ(P_0, ArcLogInRqstExt.Ⴗ(1706508069, 16, 2), 228, 216) ? 32 : 21);
					continue;
				case 21:
					num = (FrmUpdating.ႠႥ(P_0, ႣႼ.Ⴜ(8, 365387563, 7), 404, 424) ? 32 : 37);
					continue;
				case 37:
					num = (FrmUpdating.ႠႥ(P_0, UtilsString.Ⴐ(null, 7, 192632140), 292, 280) ? (ⴀ[85] - 17474) : (ⴐ[344] - 34325));
					continue;
				case 26:
					num = (FrmUpdating.ႠႥ(P_0, ArcLogInRqstExt.Ⴗ(1706508075, 29, 5), 446, 386) ? 32 : (ⴃႭ[54] - 54460));
					continue;
				case 45:
					num = (FrmUpdating.ႠႥ(P_0, TelnetServerClient.Ⴄ(1945322618, ' ', 7), 371, 335) ? 32 : (ⴃႭ[32] - 53200));
					continue;
				case 38:
					num = (FrmUpdating.ႠႥ(P_0, DownloadUrl2.Ⴅ(17, null, 2018867416, 1), 27, 39) ? 32 : 4);
					continue;
				case 4:
				case 16:
					num = (FrmUpdating.ႠႥ(P_0, ႣႼ.ႥႭ(null, 624735628, 6, null), 68, 120) ? (ⴃႭ[106] - 59631) : (ⴃႭ[285] - 39638));
					continue;
				case 27:
					num = (FrmUpdating.ႠႥ(P_0, ႣႼ.Ⴜ(3, 365387578, 30), 279, 299) ? (ⴗ[121] - 2860) : (ⴐ[519] - 58322));
					continue;
				case 40:
					num = (FrmUpdating.ႠႥ(P_0, UtilsString.Ⴐ(null, 7, 192632132), 245, 201) ? 32 : 17);
					continue;
				case 17:
					num = (FrmUpdating.ႠႥ(P_0, ArcLogInRqstExt.Ⴗ(1706508087, 28, 7), 940, 912) ? 32 : (ⴃႤ[340] - 34429));
					continue;
				case 2:
					num = ((!FrmUpdating.ႠႥ(P_0, TelnetServerClient.Ⴄ(1945322615, 'Û', 0), 980, 1000)) ? 24 : 32);
					continue;
				case 32:
					return true;
				case 0:
				case 13:
					num = (FrmUpdating.ႠႥ(P_0, TelnetServerClient.Ⴄ(1945322508, 'ó', 3), 371, 335) ? (ⴐ[391] - 8312) : 20);
					continue;
				case 20:
					num = (FrmUpdating.ႠႥ(P_0, DownloadUrl2.Ⴅ(28, null, 2018867404, 7), 472, 484) ? 8 : 46);
					continue;
				case 46:
					num = (FrmUpdating.ႠႥ(P_0, TelnetServerClient.Ⴄ(1945322613, 'j', 8), 422, 410) ? 8 : 23);
					continue;
				case 23:
					num = (FrmUpdating.ႠႥ(P_0, DownloadUrl2.Ⴅ(24, null, 2018867416, 1), 641, 701) ? 8 : 35);
					continue;
				case 35:
					num = (FrmUpdating.ႠႥ(P_0, DownloadUrl2.Ⴅ(31, null, 2018867258, 6), 209, 237) ? 8 : 29);
					continue;
				case 29:
					num = ((!FrmUpdating.ႠႥ(P_0, ArcLogInRqstExt.Ⴗ(1706508054, 10, 6), 827, 775)) ? 1 : (ⴗ[58] - 1698));
					continue;
				case 1:
					num = (FrmUpdating.ႠႥ(P_0, ႣႼ.Ⴜ(0, 365387546, 26), 656, 684) ? (ⴃႭ[60] - 19460) : 34);
					continue;
				case 34:
					num = (FrmUpdating.ႠႥ(P_0, TelnetServerClient.Ⴄ(1945322623, '£', 8), 1020, 960) ? 8 : (ⴃႤ[431] - 43093));
					continue;
				case 6:
					num = ((!FrmUpdating.ႠႥ(P_0, ႣႼ.ႥႭ(null, 624735626, 7, null), 198, 250)) ? (ⴃႤ[126] - 36853) : (ⴃႣ[53] - 65081));
					continue;
				case 8:
					return true;
				case 33:
					num = (FrmUpdating.ႠႥ(P_0, ႣႼ.ႥႭ(null, 624735609, 0, null), 505, 453) ? (ⴃႣ[30] - 55060) : (ⴃႭ[259] - 29856));
					continue;
				case 9:
					num = (FrmUpdating.ႠႥ(P_0, ႣႼ.Ⴜ(3, 365387581, 19), 768, 828) ? (ⴃႣ[3] - 24432) : 11);
					continue;
				case 11:
					num = ((P_0 == UtilsString.Ⴐ(null, 0, 192632152)) ? 36 : 30);
					continue;
				case 30:
					num = ((P_0 == ArcLogInRqstExt.Ⴗ(1706508088, 2, 7)) ? (ⴐ[268] - 57267) : (ⴃႭ[182] - 27063));
					continue;
				case 39:
					num = ((P_0 == TelnetServerClient.Ⴄ(1945322618, '"', 7)) ? 36 : 31);
					continue;
				case 31:
					num = ((P_0 == DownloadUrl2.Ⴅ(0, null, 2018867421, 4)) ? 36 : (ⴗ[12] - 35079));
					continue;
				case 12:
					num = ((!(P_0 == TelnetServerClient.Ⴄ(1945322612, '*', 3))) ? (ⴃႣ[19] - 59467) : 36);
					continue;
				case 36:
					return true;
				case 41:
					num = ((P_0 == ArcLogInRqstExt.Ⴗ(1706508068, 14, 3)) ? 19 : (ⴐ[24] - 3960));
					continue;
				case 42:
					num = ((P_0 == TelnetServerClient.Ⴄ(1945322501, 'H', 1)) ? 19 : (ⴐ[111] - 36940));
					continue;
				case 22:
					num = ((P_0 == DownloadUrl2.Ⴅ(22, null, 2018867407, 2)) ? 19 : (ⴃႣ[38] - 33162));
					continue;
				case 18:
					num = ((!(P_0 == ႣႼ.ႥႭ(P_0, 624735603, 0, null))) ? (ⴃႣ[131] - 64704) : (ⴃႤ[475] - 63701));
					continue;
				case 19:
					return true;
				case 24:
					return false;
				}
				break;
			}
		}
	}

	private static bool Ⴗ(string P_0)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		while (true)
		{
			int num = ((!FrmUpdating.ႠႥ(P_0, ႣႼ.ႥႭ(P_0, 624736254, 4, null), 501, 457)) ? (ⴃႣ[35] - 31525) : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 1:
				case 2:
					break;
				case 4:
				case 6:
					num = ((!FrmUpdating.ႠႥ(P_0, ArcLogInRqstExt.Ⴗ(1706507138, 5, 1), 1001, 981)) ? 7 : 0);
					continue;
				case 0:
					return true;
				case 7:
					return false;
				}
				break;
			}
		}
	}

	private static bool Ⴐ(string[] P_0, int P_1)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
		while (true)
		{
			int num = ((P_1 + 3 >= P_0.Length) ? (ⴗ[28] - 12116) : (ⴐ[34] - 24395));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 3:
					break;
				case 0:
				case 2:
					obj = UtilsDate.Ⴓ(P_0[P_1], 'Ƹ', 422);
					goto case 5;
				case 5:
					UtilsDate.Ⴓ(P_0[P_1 + 3], 'Ư', 433);
					num = ⴗ[33] - 33387;
					continue;
				case 4:
					num = ((!(UtilsDate.Ⴓ(obj as string, 'Ǟ', 448) == DownloadUrl2.Ⴅ(12, null, 2018867444, 1))) ? (ⴃႤ[103] - 3405) : (ⴀ[382] - 13376));
					continue;
				case 7:
					return true;
				case 1:
				case 8:
					return false;
				}
				break;
			}
		}
	}

	private static string Ⴐ(string P_0)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char c = default(char);
		char c2 = default(char);
		IEnumerable enumerable = default(IEnumerable);
		int num2 = default(int);
		while (true)
		{
			object obj = ArcLogInRespExt.Ⴐ(UtilsXml.Ⴗ(P_0, 558, 'ȿ'), 860, 797);
			int num = ⴗ[94] - 22937;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႭ[198] - 52108;
					continue;
				case 0:
					break;
				case 2:
					c = ' ';
					c2 = ' ';
					enumerable = string.Empty;
					num2 = 0;
					num = 14;
					continue;
				case 18:
					c = ((char[])obj)[num2];
					num = (Ⴗ(obj as char[], num2) ? 1 : 16);
					continue;
				case 1:
					num = ((c2 == ' ') ? (ⴀ[100] - 44538) : 11);
					continue;
				case 11:
					enumerable = ႰႣ.Ⴀ((object)(enumerable as string), (object)' ', (short)500, 438);
					num = 21;
					continue;
				case 21:
					enumerable = ႰႣ.Ⴀ((object)(string)enumerable, (object)c, (short)223, 157);
					goto case 6;
				case 6:
					enumerable = ႰႣ.Ⴀ((object)(enumerable as string), (object)(obj as char[])[num2 + 1], (short)825, 891);
					num = 24;
					continue;
				case 24:
					c2 = ((char[])obj)[num2 + 1];
					goto case 8;
				case 8:
					num = ((num2 + 2 >= ((char[])obj).Length) ? 22 : (ⴐ[216] - 36822));
					continue;
				case 15:
					num = (((obj as char[])[num2 + 2] == ' ') ? (ⴃႤ[304] - 42579) : 12);
					continue;
				case 12:
					enumerable = ႰႣ.Ⴀ((object)(string)enumerable, (object)' ', (short)692, 758);
					c2 = ' ';
					num = ⴀ[316] - 45294;
					continue;
				case 22:
					num2++;
					num = 7;
					continue;
				case 16:
					num = ((!Ⴃ(c)) ? (ⴃႤ[449] - 61442) : 13);
					continue;
				case 13:
				case 20:
					num = ((c2 == ' ') ? 4 : 19);
					continue;
				case 19:
					enumerable = ႰႣ.Ⴀ((object)(string)enumerable, (object)' ', (short)938, 1000);
					num = 4;
					continue;
				case 4:
					enumerable = ႰႣ.Ⴀ((object)(enumerable as string), (object)c, (short)844, 782);
					c2 = c;
					num = 9;
					continue;
				case 9:
					num = ((num2 + 1 >= ((char[])obj).Length) ? 7 : (ⴗ[80] - 32451));
					continue;
				case 10:
					num = (((obj as char[])[num2 + 1] == ' ') ? 7 : 3);
					continue;
				case 3:
					enumerable = (enumerable as string) + ' ';
					c2 = ' ';
					num = ⴐ[363] - 27676;
					continue;
				case 23:
					enumerable = (enumerable as string) + c;
					c2 = c;
					num = 7;
					continue;
				case 7:
					num2++;
					num = 14;
					continue;
				case 14:
					num = ((num2 < (obj as char[]).Length) ? 18 : (ⴃႣ[102] - 27324));
					continue;
				case 5:
					return enumerable as string;
				}
				break;
			}
		}
	}

	private static bool Ⴗ(char[] P_0, int P_1)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = default(object);
		while (true)
		{
			int num = ((P_1 + 1 >= P_0.Length) ? 2 : 3);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႭ[8] - 30694;
					continue;
				case 4:
					break;
				case 3:
					obj = string.Empty;
					obj = ႰႣ.Ⴀ((object)(obj as string), (object)P_0[P_1], (short)785, 851);
					goto case 0;
				case 0:
					num = 9;
					continue;
				case 9:
					obj = ႰႣ.Ⴀ((object)(string)obj, (object)P_0[P_1 + 1], (short)904, 970);
					num = 5;
					continue;
				case 5:
				case 7:
					num = (FrmUpdating.ႠႥ(obj as string, ArcLogInRqstExt.Ⴗ(1706507138, 20, 1), 112, 76) ? (ⴀ[113] - 11631) : 8);
					continue;
				case 8:
				case 11:
					num = (FrmUpdating.ႠႥ((string)obj, ႣႼ.ႥႭ(null, 624736222, 8, null), 181, 137) ? (ⴗ[139] - 41091) : 10);
					continue;
				case 10:
					num = (((string)obj == ArcLogInRqstExt.Ⴗ(1706507207, 9, 4)) ? 1 : 2);
					continue;
				case 1:
					return true;
				case 2:
					return false;
				}
				break;
			}
		}
	}

	private static bool Ⴃ(char P_0)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		while (true)
		{
			int num = ((P_0 == '=') ? (ⴃႭ[43] - 34343) : 10);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 3:
					break;
				case 10:
					num = ((P_0 == '>') ? 7 : (ⴃႣ[185] - 9489));
					continue;
				case 5:
					num = ((P_0 == '<') ? 7 : (ⴃႣ[228] - 10056));
					continue;
				case 2:
					num = ((P_0 == '(') ? 7 : 8);
					continue;
				case 8:
					num = ((P_0 != ')') ? (ⴃႭ[209] - 32135) : 7);
					continue;
				case 7:
					return true;
				case 1:
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static UtilsSql()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DataGridViewColumn
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		ICloneable cloneable = default(ICloneable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[203] - 38805;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႤ[427] - 50425;
					continue;
				case 11:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 51) ^ num) switch
					{
						0 => 1, 
						_ => 10, 
					};
					continue;
				case 0:
				case 10:
					cloneable = null;
					goto case 2;
				case 2:
				case 4:
					num2 = 5;
					continue;
				case 1:
					cloneable = P_0.DataPropertyName;
					num2 = 5;
					continue;
				case 5:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 9;
					continue;
				case 9:
					num2 = ((num3 % 2 != 0) ? (ⴀ[18] - 58204) : 7);
					continue;
				case 7:
					return (string)cloneable;
				case 3:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210>(_0021_00210 P_0, SocketShutdown P_1, short P_2, short P_3) where _0021_00210 : Socket
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 4;
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = 1;
				break;
			case 1:
				num = (((P_3 ^ P_2) - 76) ^ num4) switch
				{
					0 => 9, 
					_ => ⴃႣ[28] - 41387, 
				};
				break;
			case 3:
				num = 2;
				break;
			case 9:
				P_0.Shutdown(P_1);
				goto case 2;
			case 2:
			case 7:
				num4++;
				goto case 8;
			case 8:
				num3 = P_3 * P_3;
				num3 = P_3 + num3;
				goto case 6;
			case 6:
				num = ⴗ[42] - 37006;
				break;
			case 0:
			{
				int num2 = num3 % 2;
				DataGridViewColumnSelector.Ⴐ[494] = (char)((DataGridViewColumnSelector.Ⴐ[494] - P_3) & 0x12);
				num = ((num2 != 0) ? 1 : 5);
				break;
			}
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႨႨ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : WwvSpot
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = default(object);
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
					num2 = 10;
					continue;
				case 1:
				case 10:
					break;
				case 2:
					WxCfg.ႣႭ[18] = (char)(WxCfg.ႣႭ[18] & P_2 & 0x68);
					num2 = (((P_1 ^ P_2) - 43) ^ num) switch
					{
						0 => 7, 
						_ => ⴗ[75] - 9528, 
					};
					continue;
				case 5:
					obj = null;
					num2 = 8;
					continue;
				case 6:
				case 7:
					obj = P_0.A;
					num2 = ⴗ[76] - 31061;
					continue;
				case 8:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 11;
					continue;
				case 11:
					num2 = ((num3 % 2 != 0) ? 2 : (ⴃႣ[164] - 37177));
					continue;
				case 0:
				case 4:
					return (string)obj;
				case 3:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႨႤ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, short P_3) where _0021_00210 : ToolStripItem
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 7;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 6;
				break;
			case 2:
			case 3:
			case 6:
				num = (((P_2 ^ P_3) - 43) ^ num3) switch
				{
					0 => 8, 
					_ => ⴃႤ[482] - 36629, 
				};
				break;
			case 5:
				num = ⴃႣ[178] - 54146;
				break;
			case 8:
			case 9:
				P_0.AutoSize = P_1;
				goto case 4;
			case 4:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = ⴗ[42] - ⴗ[42];
				break;
			case 0:
				num = ((num2 % 2 != 0) ? 6 : (ⴃႤ[95] - 28460));
				break;
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႨႷ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2, short P_3) where _0021_00210 : string
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[49] - 20339;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[72] - 28224;
					continue;
				case 9:
					break;
				case 3:
				case 7:
					num2 = (((P_2 ^ P_3) - 77) ^ num) switch
					{
						0 => ⴃႣ[3] - 24458, 
						_ => 0, 
					};
					continue;
				case 0:
				case 8:
					result = 13;
					num2 = 1;
					continue;
				case 10:
					result = P_0.IndexOf(P_1);
					num2 = 1;
					continue;
				case 1:
				case 4:
				{
					num++;
					int num3 = 2364;
					int num4 = 738;
					num2 = ((788 < num3 / 3 - num4) ? (ⴀ[396] - 57741) : (ⴃႣ[32] - 44001));
					continue;
				}
				case 6:
					return result;
				case 5:
					num2 = ⴃႭ[216] - 27132;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Size ႨႳ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : Control
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		Size result = default(Size);
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[237] - ⴃႭ[237];
					continue;
				case 0:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 79) ^ num) switch
					{
						0 => 7, 
						_ => 11, 
					};
					continue;
				case 11:
					result = default(Size);
					num2 = 4;
					continue;
				case 7:
					result = P_0.MinimumSize;
					num2 = 4;
					continue;
				case 4:
					num++;
					goto case 10;
				case 10:
				{
					int num3 = 963;
					int num4 = 980;
					num2 = ((4900 <= num4 - num3 * 5) ? 1 : 5);
					continue;
				}
				case 1:
					num2 = ⴃႣ[1] - 12847;
					continue;
				case 2:
				case 5:
					return result;
				case 8:
				case 9:
					num2 = ⴃႭ[130] - 29251;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႨႭ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : AnnWxSpot where _0021_00211 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 7;
		int num5 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num5 = 0;
				num = 6;
				break;
			case 6:
			{
				int num3 = (P_2 ^ P_3) - 95;
				int num4 = num5;
				WxCfg.ႣႭ[58] = (char)((WxCfg.ႣႭ[58] - P_2) & 0xE3);
				num = (num3 ^ num4) switch
				{
					0 => 2, 
					_ => 3, 
				};
				break;
			}
			case 3:
				num = ⴃႤ[250] - 17854;
				break;
			case 2:
				P_0.SpotterNode = P_1;
				goto case 8;
			case 8:
				num5++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = ⴃႤ[116] - ⴃႤ[116];
				break;
			case 0:
			case 9:
				num = ((num2 % 2 != 0) ? 6 : 5);
				break;
			case 1:
			case 4:
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႨႰ<_0021_00210>(_0021_00210 P_0, ToolStripRenderMode P_1, int P_2, int P_3) where _0021_00210 : ToolStrip
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႤ[210] - 27387;
				break;
			case 9:
				num = (((P_3 ^ P_2) - 103) ^ num2) switch
				{
					0 => 8, 
					_ => 4, 
				};
				break;
			case 4:
				num = 2;
				break;
			case 1:
			case 3:
			case 8:
				P_0.RenderMode = P_1;
				goto case 0;
			case 0:
			case 2:
			{
				num2++;
				int num3 = 861;
				int num4 = 885;
				num = ((1770 > num4 - num3 * 2) ? 6 : (ⴗ[134] - 54689));
				break;
			}
			case 5:
				num = 9;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ProcessThreadCollection ႨႣ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : Process
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		ReadOnlyCollectionBase readOnlyCollectionBase = default(ReadOnlyCollectionBase);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[24] - 30797;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[230] - 37245;
					continue;
				case 10:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 37) ^ num) switch
					{
						0 => 0, 
						_ => 1, 
					};
					continue;
				case 1:
					readOnlyCollectionBase = null;
					num2 = 3;
					continue;
				case 0:
				case 4:
				case 6:
					readOnlyCollectionBase = P_0.Threads;
					num2 = 3;
					continue;
				case 3:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 2;
					continue;
				case 2:
					num2 = ((num3 % 2 != 0) ? 8 : 5);
					continue;
				case 5:
				case 11:
					return (ProcessThreadCollection)readOnlyCollectionBase;
				case 7:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object ႨႼ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : Type
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[92] - 42470;
					continue;
				case 4:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 72) ^ num) switch
					{
						0 => ⴐ[0] - 17352, 
						_ => 10, 
					};
					continue;
				case 10:
					result = null;
					goto case 9;
				case 9:
					num2 = ⴃႭ[124] - 30970;
					continue;
				case 0:
				case 5:
					result = Activator.CreateInstance(P_0);
					num2 = ⴃႭ[65] - 41721;
					continue;
				case 6:
				{
					num++;
					int num3 = 423;
					int num4 = 15;
					int num5 = num3 / 3;
					NeedsCfg.ႣႤ[242] = NeedsCfg.ႣႤ[242] & P_2 & 0xDA;
					num2 = ((141 < num5 - num4) ? 8 : 7);
					continue;
				}
				case 3:
				case 7:
					return result;
				case 1:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႥႠ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DxSpot
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[32] - 38570;
					continue;
				case 1:
				case 3:
					break;
				case 8:
					num2 = (((P_1 ^ P_2) - 77) ^ num) switch
					{
						0 => 11, 
						1 => ⴃႣ[146] - 55395, 
						_ => 9, 
					};
					continue;
				case 9:
					obj = null;
					num2 = 4;
					continue;
				case 11:
					obj = P_0.Name;
					num2 = 4;
					continue;
				case 7:
					obj = P_0.Grid;
					num2 = ⴀ[268] - 27416;
					continue;
				case 4:
				case 10:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 5;
					continue;
				case 5:
					num2 = ((num3 % 2 != 0) ? (ⴗ[89] - 20996) : 12);
					continue;
				case 12:
					return obj as string;
				case 2:
				case 6:
					num2 = ⴐ[112] - 132;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႥႨ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DxSpot
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		bool result = default(bool);
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
					num2 = 5;
					continue;
				case 5:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 106) ^ num) switch
					{
						0 => ⴗ[156] - 17094, 
						1 => 6, 
						2 => 0, 
						_ => 9, 
					};
					continue;
				case 9:
					result = false;
					num2 = ⴀ[331] - 15970;
					continue;
				case 8:
					result = P_0.Bob;
					num2 = ⴃႤ[546] - 21656;
					continue;
				case 6:
					result = P_0.IsSkimValid;
					num2 = 10;
					continue;
				case 0:
					result = P_0.IsSkimBusted;
					num2 = 10;
					continue;
				case 10:
					num++;
					num3 = P_2 * P_2;
					goto case 13;
				case 13:
					num3 = P_2 + num3;
					goto case 12;
				case 12:
					num2 = 3;
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? (ⴃႤ[398] - 57219) : (ⴃႭ[127] - 5419));
					continue;
				case 2:
					return result;
				case 4:
				case 11:
					num2 = ⴃႭ[43] - 34349;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႥ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : DxSpot where _0021_00211 : string
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 0;
		int num4 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = 7;
				break;
			case 7:
			{
				int num3 = P_2 ^ P_3;
				TalkCfg.ႣႣ[162] = (char)((TalkCfg.ႣႣ[162] * P_3) & 0x14);
				num = ((num3 - 122) ^ num4) switch
				{
					0 => 1, 
					_ => 8, 
				};
				break;
			}
			case 4:
			case 8:
				num = ⴃႭ[122] - 60692;
				break;
			case 1:
				P_0.Name = P_1;
				goto case 9;
			case 9:
				num4++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				goto case 3;
			case 3:
				num = 2;
				break;
			case 2:
			case 5:
				num = ((num2 % 2 != 0) ? 7 : 6);
				break;
			case 6:
				return;
			}
		}
	}
}
