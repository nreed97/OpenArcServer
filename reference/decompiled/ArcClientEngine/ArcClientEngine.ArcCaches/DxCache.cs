using System;
using System.ComponentModel;
using System.Data;
using System.Security;
using System.Threading;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public sealed class DxCache
{
	private static readonly ILog Ⴈ;

	private static readonly object Ⴐ;

	private static readonly object m_Ⴓ;

	private bool Ⴅ;

	private DataSet Ⴅ;

	private DxSpotRates Ⴈ;

	private ႳႳ.Ⴜ Ⴄ;

	public bool ScrollNeeded
	{
		get
		{
			return this.Ⴅ;
		}
		set
		{
			this.Ⴅ = value;
		}
	}

	public DataSet DataSet
	{
		get
		{
			byte[] ⴅ = UserCmd.Ⴅ;
			return Ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	public DxSpotRates DxSpotRates
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return Ⴈ;
		}
		set
		{
			Ⴈ = value;
		}
	}

	internal DxCache()
	{
		Ⴄ.Ⴄ = 1;
		base._002Ector();
		DxSpotRates = new DxSpotRates();
		DataSet = new DataSet();
		IListSource listSource = new DataSet();
		Ⴄ.Ⴐ = (DataSet)listSource;
		bool flag = false;
		object ⴐ = default(object);
		try
		{
			ႥႥ.ႤႨ(ⴐ = Ⴐ, ref flag, 238, 159);
			Ⴀ(DataSet);
		}
		finally
		{
			if (flag)
			{
				DxFilters.Ⴍ(ⴐ, 933, 963);
			}
		}
		bool flag2 = false;
		object ⴓ = default(object);
		try
		{
			ႥႥ.ႤႨ(ⴓ = DxCache.m_Ⴓ, ref flag2, 390, 503);
			Ⴀ(Ⴄ.Ⴐ);
		}
		finally
		{
			if (flag2)
			{
				Monitor.Exit(ⴓ);
			}
		}
	}

	private void Ⴀ(DataSet P_0)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 27;
		while (true)
		{
			switch (num)
			{
			default:
				TelnetServerCfg.Ⴃ(ႥႠ.Ⴓ(P_0, 501, 496), new DataTable(ClientCty.Ⴗ(']', 8, 307012914)), 'Ů', 332);
				num = 34;
				break;
			case 34:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 95, 90), 0, 468, 501), 660, 'ʝ'), new DataColumn(WxFilters.Ⴀ(null, 1, 103387733), typeof(int)), 830, 881);
				num = ⴗ[13] - 41488;
				break;
			case 10:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 137, 140), 0, 586, 619), 190, '·'), new DataColumn(WxFilters.Ⴀ(null, 4, 103387816), typeof(string)), 754, 701);
				num = 41;
				break;
			case 41:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 615, 610), 0, 245, 212), 831, '\u0336'), new DataColumn(ႥႥ.Ⴅ(1673508198, null, 1), typeof(string)), 915, 988);
				num = ⴅ[18] - 16;
				break;
			case 20:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 618, 623), 0, 649, 680), 196, 'Í'), new DataColumn(WxFilters.Ⴀ(null, 7, 103387653), typeof(string)), 517, 586);
				num = 22;
				break;
			case 22:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 395, 398), 0, 929, 896), 80, 'Y'), new DataColumn(ႥႥ.Ⴍ(8, 1580608608, 'Ó', null), typeof(string)), 218, 149);
				num = ⴗ[119] - 30759;
				break;
			case 38:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 508, 505), 0, 555, 522), 591, 'Ɇ'), new DataColumn(ႥႥ.Ⴅ(1673508681, null, 8), typeof(string)), 443, 500);
				num = ⴀႠ[97] - 34997;
				break;
			case 5:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 653, 648), 0, 153, 184), 772, '\u030d'), new DataColumn(ႥႥ.Ⴅ(1673508220, null, 5), typeof(string)), 846, 769);
				num = 23;
				break;
			case 23:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 715, 718), 0, 485, 452), 625, 'ɸ'), new DataColumn(ႥႥ.Ⴅ(1673508713, null, 8), typeof(string)), 465, 414);
				num = 32;
				break;
			case 32:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 627, 630), 0, 711, 742), 581, 'Ɍ'), new DataColumn(WxFilters.Ⴀ(null, 8, 103387652), typeof(string)), 168, 231);
				num = 25;
				break;
			case 25:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 544, 549), 0, 439, 406), 773, '\u030c'), new DataColumn(ClientCty.Ⴗ(']', 0, 307013630), typeof(string)), 37, 106);
				num = ⴅ[194];
				break;
			case 29:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 154, 159), 0, 211, 242), 565, 'ȼ'), new DataColumn(ႥႥ.Ⴅ(1673508104, null, 6), typeof(string)), 94, 17);
				num = 18;
				break;
			case 18:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 881, 884), 0, 891, 858), 283, 'Ē'), new DataColumn(ႥႥ.Ⴍ(3, 1580608610, 'ø', null), typeof(string)), 1017, 950);
				num = ⴗ[98] - 39613;
				break;
			case 33:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 894, 891), 0, 286, 319), 757, '\u02fc'), new DataColumn(ႥႥ.Ⴍ(2, 1580609012, 'Û', null), typeof(string)), 13, 66);
				num = ⴅ[85] - 101;
				break;
			case 28:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 411, 414), 0, 378, 347), 858, '\u0353'), new DataColumn(WxFilters.Ⴀ(null, 7, 103387234), typeof(string)), 512, 591);
				num = ⴗ[13] - 41474;
				break;
			case 24:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 938, 943), 0, 136, 169), 225, 'è'), new DataColumn(ႥႥ.Ⴍ(6, 1580608542, 'O', null), typeof(string)), 923, 980);
				num = ⴗ[129] - 40417;
				break;
			case 1:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 859, 862), 0, 404, 437), 999, 'Ϯ'), new DataColumn(ႥႥ.Ⴍ(5, 1580608735, 'ñ', null), typeof(string)), 209, 158);
				num = 8;
				break;
			case 8:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 601, 604), 0, 438, 407), 367, 'Ŧ'), new DataColumn(ClientCty.Ⴗ('¥', 6, 307013617), typeof(byte)), 966, 905);
				num = 19;
				break;
			case 19:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 89, 92), 0, 967, 998), 45, '$'), new DataColumn(WxFilters.Ⴀ(null, 3, 103387304), typeof(byte)), 952, 1015);
				num = ⴅ[25];
				break;
			case 2:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 113, 116), 0, 974, 1007), 1020, 'ϵ'), new DataColumn(ႥႥ.Ⴍ(7, 1580608525, 'ð', null), typeof(byte)), 329, 262);
				num = ⴗ[97] - 31937;
				break;
			case 31:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 971, 974), 0, 533, 564), 630, 'ɿ'), new DataColumn(ႥႥ.Ⴅ(1673508645, null, 7), typeof(byte)), 865, 814);
				num = ⴄ[237] - 13503;
				break;
			case 0:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 928, 933), 0, 887, 854), 911, 'Ά'), new DataColumn(ClientCty.Ⴗ('+', 1, 307013537), typeof(byte)), 449, 398);
				num = 3;
				break;
			case 3:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 706, 711), 0, 532, 565), 9, '\0'), new DataColumn(ႥႥ.Ⴍ(0, 1580608590, 'U', null), typeof(byte)), 341, 282);
				num = 46;
				break;
			case 46:
				ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 919, 914), 0, 989, 1020), 318, 'ķ'), new DataColumn(ႥႥ.Ⴍ(1, 1580608630, 'â', null), typeof(int)), 307, 380);
				num = 40;
				break;
			case 40:
				ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(P_0, 171, 174), 0, 790, 823), 258, 'ċ').Add(new DataColumn(ClientCty.Ⴗ('\'', 8, 307013606), typeof(double)));
				num = ⴅ[132] - 163;
				break;
			case 26:
				P_0.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴍ(6, 1580608969, 'Ü', null), typeof(double)));
				num = 42;
				break;
			case 42:
				P_0.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴅ(1673507904, null, 0), typeof(bool)));
				num = 44;
				break;
			case 44:
				P_0.Tables[0].Columns.Add(new DataColumn(WxFilters.Ⴀ(null, 2, 103387507), typeof(bool)));
				num = 45;
				break;
			case 45:
				P_0.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴍ(0, 1580609515, 'û', null), typeof(bool)));
				goto case 11;
			case 11:
			case 17:
				num = 9;
				break;
			case 9:
				P_0.Tables[0].Columns.Add(new DataColumn(ClientCty.Ⴗ('ç', 6, 307013584), typeof(bool)));
				num = 47;
				break;
			case 47:
				P_0.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴍ(3, 1580608639, 'ü', null), typeof(bool)));
				num = 7;
				break;
			case 7:
				P_0.Tables[0].Columns.Add(new DataColumn(ClientCty.Ⴗ('À', 5, 307013576), typeof(bool)));
				num = 37;
				break;
			case 37:
				P_0.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴍ(7, 1580609427, 'Y', null), typeof(bool)));
				num = ⴄ[234] - 24880;
				break;
			case 43:
				P_0.Tables[0].Columns.Add(new DataColumn(ClientCty.Ⴗ('\u0011', 6, 307013570), typeof(bool)));
				num = ⴄ[248] - 4562;
				break;
			case 12:
				P_0.Tables[0].Columns.Add(new DataColumn(ClientCty.Ⴗ('\u009b', 3, 307013484), typeof(bool)));
				num = ⴗ[127] - 17825;
				break;
			case 39:
				P_0.Tables[0].Columns.Add(new DataColumn(ClientCty.Ⴗ('<', 7, 307013550), typeof(bool)));
				num = 6;
				break;
			case 6:
				P_0.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴍ(7, 1580608604, '\u0081', null), typeof(bool)));
				num = ⴗ[23] - 52192;
				break;
			case 14:
				P_0.Tables[0].Columns.Add(new DataColumn(ClientCty.Ⴗ('\n', 4, 307013473), typeof(bool)));
				num = ⴀႠ[2] - 58304;
				break;
			case 4:
				P_0.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴍ(7, 1580608950, '"', null), typeof(bool)));
				num = 15;
				break;
			case 15:
				P_0.Tables[0].Columns.Add(new DataColumn(ClientCty.Ⴗ('¿', 4, 307013514), typeof(bool)));
				num = ⴗ[90] - 35228;
				break;
			case 36:
				P_0.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴍ(8, 1580608929, 'Ã', null), typeof(bool)));
				num = ⴅ[23];
				break;
			case 13:
			case 30:
				P_0.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴅ(1673507934, null, 1), typeof(bool)));
				num = ⴄ[240] - 48043;
				break;
			case 35:
				P_0.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴍ(7, 1580609005, 'w', null), typeof(bool)));
				num = 21;
				break;
			case 21:
				P_0.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴅ(1673507921, null, 7), typeof(bool)));
				num = 16;
				break;
			case 16:
				P_0.Tables[0].Columns.Add(new DataColumn(WxFilters.Ⴀ(null, 5, 103387706), typeof(DateTime)));
				return;
			}
		}
	}

	public bool AddSpot(DxSpot dx, bool isAtno, bool isBandMode)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		try
		{
			switch (0)
			{
			default:
			{
				bool flag = false;
				object ⴐ = default(object);
				try
				{
					int num = 49;
					object obj = default(object);
					object ⴓ = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							ႥႥ.ႤႨ(ⴐ = Ⴐ, ref flag, 667, 746);
							obj = ႥႠ.Ⴜ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 257, 260), 0, 447, 414), 437, 479);
							num = ⴗ[76] - 24770;
							continue;
						case 13:
						{
							DataRow obj2 = obj as DataRow;
							string text = WxFilters.Ⴀ(null, 8, 103387740);
							int ⴄ3;
							int ⴄ2 = (ⴄ3 = Ⴄ.Ⴄ) + 1;
							Ⴄ.Ⴄ = ⴄ2;
							HighlightCqZoneCfg.Ⴗ(obj2, text, (object)ⴄ3, (short)476, 452);
							num = ⴅ[4] * 2;
							continue;
						}
						case 16:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, WxFilters.Ⴀ(null, 7, 103387819), (object)FilterViewer.ႨႥ(dx, 425, 'Ɖ'), (short)858, 834);
							num = 15;
							continue;
						case 15:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ႥႥ.Ⴅ(1673508195, null, 4), (object)ႳႰ.Ⴈ(dx, 333, 283), (short)772, 796);
							num = ⴗ[54] - 48762;
							continue;
						case 37:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, WxFilters.Ⴀ(null, 2, 103387648), (object)ႳႰ.Ⴈ(dx, 505, 430), (short)358, 382);
							num = 5;
							continue;
						case 5:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ႥႥ.Ⴍ(5, 1580608621, 'F', null), (object)ႳႥ.ႥႥ(dx, 589, 630), (short)641, 665);
							num = ⴀႠ[6] - 62240;
							continue;
						case 11:
						case 36:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ႥႥ.Ⴅ(1673508678, null, 7), (object)ႳႰ.Ⴈ(dx, 303, 379), (short)553, 561);
							num = 17;
							continue;
						case 17:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ႥႥ.Ⴅ(1673508219, null, 2), (object)ႳႰ.Ⴈ(dx, 495, 442), (short)47, 55);
							num = 22;
							continue;
						case 22:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ႥႥ.Ⴅ(1673508706, null, 3), (object)FilterViewer.ႨႥ(dx, 25, '\a'), (short)559, 567);
							num = 32;
							continue;
						case 32:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, WxFilters.Ⴀ(null, 2, 103387662), (object)FilterViewer.ႨႣ(dx, 607, 'ȯ'), (short)470, 462);
							goto case 30;
						case 30:
							num = 10;
							continue;
						case 10:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ClientCty.Ⴗ('\u0011', 1, 307013631), (object)ႳႥ.ႥႥ(dx, 407, 426), (short)75, 83);
							num = 23;
							continue;
						case 23:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ႥႥ.Ⴅ(1673508105, null, 7), (object)ႳႰ.Ⴈ(dx, 7, 95), (short)686, 694);
							num = 18;
							continue;
						case 18:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ႥႥ.Ⴍ(3, 1580608610, 'ÿ', null), (object)FilterViewer.ႨႥ(dx, 695, 'ʨ'), (short)841, 849);
							num = ⴄ[47] - 24176;
							continue;
						case 25:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ႥႥ.Ⴍ(0, 1580609014, '\u008e', null), (object)FilterViewer.ႨႥ(dx, 709, 'ˤ'), (short)267, 275);
							num = ⴀႠ[30] - 50891;
							continue;
						case 38:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, WxFilters.Ⴀ(null, 0, 103387237), (object)ႳႥ.ႥႥ(dx, 1, 61), (short)559, 567);
							num = 21;
							continue;
						case 21:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ႥႥ.Ⴍ(6, 1580608542, 'V', null), (object)ႳႰ.Ⴈ(dx, 45, 126), (short)162, 186);
							num = ⴅ[297] - 239;
							continue;
						case 12:
						case 47:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ႥႥ.Ⴍ(1, 1580608731, 'T', null), (object)FilterViewer.ႨႥ(dx, 569, 'ț'), (short)1020, 996);
							num = 28;
							continue;
						case 28:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ClientCty.Ⴗ('^', 8, 307013631), (object)ClientCty.ႠႷ(dx, 1009, 900), (short)115, 107);
							num = 45;
							continue;
						case 45:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, WxFilters.Ⴀ(null, 7, 103387308), (object)UserInfo.ႥႥ(dx, 834, '\u0308'), (short)260, 284);
							num = ⴅ[56] / 2;
							continue;
						case 48:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ႥႥ.Ⴍ(4, 1580608526, 'ë', null), (object)ClientCty.ႠႷ(dx, 186, 204), (short)676, 700);
							num = 0;
							continue;
						case 0:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ႥႥ.Ⴅ(1673508650, null, 8), (object)UserInfo.ႥႥ(dx, 453, 'Ǝ'), (short)69, 93);
							num = 40;
							continue;
						case 40:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ClientCty.Ⴗ('È', 5, 307013541), (object)ႥႠ.ႭႭ(dx, 'ɋ', 532), (short)81, 73);
							num = 2;
							continue;
						case 2:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ႥႥ.Ⴍ(6, 1580608584, 'I', null), (object)ႥႠ.ႭႠ(dx, 837, '\u0355'), (short)151, 143);
							num = 4;
							continue;
						case 4:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ႥႥ.Ⴍ(8, 1580608639, '½', null), (object)ClientCty.ႠႷ(dx, 740, 659), (short)753, 745);
							num = 1;
							continue;
						case 1:
						{
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ClientCty.Ⴗ('H', 6, 307013608), (object)HighlightCqZoneCfg.ႣႣ(dx, 844, '\u030a'), (short)513, 537);
							char num4 = ⴗ[58];
							ႥႰ.Ⴗ[115] = (char)((ႥႰ.Ⴗ[115] ^ Bye.Ⴄ[44]) & 0x89);
							num = num4 - 20864;
							continue;
						}
						case 34:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ႥႥ.Ⴍ(7, 1580608968, 'L', null), (object)WxFilters.ႭႤ(dx, 137, 249), (short)635, 611);
							num = 8;
							continue;
						case 8:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ႥႥ.Ⴅ(1673507905, null, 1), (object)FilterPicker.ႥႤ(dx, 209, 185), (short)435, 427);
							num = 14;
							continue;
						case 14:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, WxFilters.Ⴀ(null, 8, 103387513), (object)FilterPicker.ႥႤ(dx, 362, 256), (short)273, 265);
							num = 6;
							continue;
						case 6:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, WxFilters.Ⴀ(null, 0, 103387468), (object)FilterEditor.ႷႰ(dx, 92, 22), (short)500, 492);
							num = ⴄ[219] - 35493;
							continue;
						case 27:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ClientCty.Ⴗ(',', 2, 307013588), (object)FilterPicker.ႥႤ(dx, 781, 870), (short)91, 67);
							num = 9;
							continue;
						case 9:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ႥႥ.Ⴍ(6, 1580608634, '³', null), (object)DxSpotRateGraph.Ⴈ(dx, 528, 525), (short)490, 498);
							num = ⴄ[243] - 58580;
							continue;
						case 7:
							(obj as DataRow)[ClientCty.Ⴗ('\u00a8', 0, 307013581)] = dx.Top100;
							num = ⴗ[149] - 53652;
							continue;
						case 29:
							(obj as DataRow)[ႥႥ.Ⴍ(2, 1580609430, 'ê', null)] = dx.Foc;
							num = ⴅ[38] - 144;
							continue;
						case 19:
							(obj as DataRow)[ClientCty.Ⴗ('¥', 6, 307013570)] = dx.Ham;
							num = ⴄ[80] - 22688;
							continue;
						case 44:
							(obj as DataRow)[ClientCty.Ⴗ('Ë', 6, 307013481)] = dx.Skimmer;
							num = 33;
							continue;
						case 33:
							((DataRow)obj)[ClientCty.Ⴗ('j', 4, 307013549)] = dx.SkimCq;
							num = ⴅ[120] - 81;
							continue;
						case 35:
							((DataRow)obj)[ႥႥ.Ⴍ(5, 1580608606, 'Ë', null)] = dx.SkimDupe;
							num = 20;
							continue;
						case 20:
							((DataRow)obj)[ClientCty.Ⴗ('p', 1, 307013476)] = dx.IsSkimValid;
							num = ⴄ[84] - 3811;
							continue;
						case 3:
							(obj as DataRow)[ႥႥ.Ⴍ(0, 1580608945, 'Z', null)] = dx.IsSkimQsy;
							num = 31;
							continue;
						case 31:
							(obj as DataRow)[ClientCty.Ⴗ('\u0096', 7, 307013513)] = dx.IsSkimBusted;
							num = ⴄ[275] - 45726;
							continue;
						case 43:
							(obj as DataRow)[ႥႥ.Ⴍ(5, 1580608940, '\u008f', null)] = dx.IsSkimUnknown;
							num = ⴀႠ[107] - 34871;
							continue;
						case 39:
							(obj as DataRow)[ႥႥ.Ⴅ(1673507927, null, 8)] = isAtno;
							num = 24;
							continue;
						case 24:
							(obj as DataRow)[ႥႥ.Ⴍ(0, 1580609002, '\f', null)] = isBandMode;
							num = ⴀႠ[64] - 42646;
							continue;
						case 26:
							(obj as DataRow)[ႥႥ.Ⴅ(1673507923, null, 5)] = dx.Buddy;
							num = ⴗ[88] - 27844;
							continue;
						case 41:
							(obj as DataRow)[WxFilters.Ⴀ(null, 6, 103387705)] = dx.Dts;
							num = 46;
							continue;
						case 46:
						{
							DataSet.Tables[0].Rows.Add(obj as DataRow);
							bool lockTaken = false;
							try
							{
								switch (0)
								{
								default:
									Monitor.Enter(ⴓ = DxCache.m_Ⴓ, ref lockTaken);
									Ⴄ.Ⴐ.Tables[0].ImportRow((DataRow)obj);
									break;
								}
							}
							finally
							{
								int num2 = 4;
								while (true)
								{
									int num3;
									switch (num2)
									{
									default:
										num3 = ((!lockTaken) ? 2 : 6);
										goto IL_0c54;
									case 1:
									case 3:
									case 6:
										Monitor.Exit(ⴓ);
										break;
									case 2:
										break;
									}
									break;
									IL_0c54:
									num2 = num3;
								}
							}
							switch (4)
							{
							}
							break;
						}
						}
						break;
					}
				}
				finally
				{
					int num5 = 6;
					while (true)
					{
						int num6;
						switch (num5)
						{
						default:
							num6 = ((!flag) ? 3 : (ⴀႠ[10] - 7242));
							goto IL_0cb7;
						case 0:
						case 4:
							Monitor.Exit(ⴐ);
							break;
						case 2:
						case 3:
							break;
						}
						break;
						IL_0cb7:
						num5 = num6;
					}
				}
				switch (1)
				{
				default:
					DxSpotRates.Ⴍ(dx);
					ScrollNeeded = true;
					break;
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			DxCache.Ⴈ.Error(ex.Message);
		}
		return 1 switch
		{
			_ => true, 
		};
	}

	public void PurgeOldSpots()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 0;
		IComparable<string> comparable = default(IComparable<string>);
		object ⴐ = default(object);
		object obj = default(object);
		Array array = default(Array);
		int num3 = default(int);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				string text = ႥႥ.Ⴍ(1, 1580608886, 'B', null);
				DateTime dateTime = FilterPicker.ႥႰ('Ϡ', 'ν');
				comparable = ႥႭ.ႳႣ((object)text, (object)TelnetServerCfg.Ⴈ(ref dateTime, -30.0, 951, 982), (object)WxFilters.Ⴀ(null, 8, 103387689), 'ƀ', 443);
				break;
			}
			case 3:
				break;
			case 2:
			case 4:
			{
				bool flag = false;
				try
				{
					int num2 = 9;
					while (true)
					{
						switch (num2)
						{
						default:
							ႥႥ.ႤႨ(ⴐ = Ⴐ, ref flag, 64, 49);
							goto case 1;
						case 1:
							obj = ႥႤ.Ⴈ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 399, 394), 0, 449, 480), (string)comparable, 'ĭ', 'ŀ');
							num2 = 5;
							continue;
						case 5:
							array = (DataRow[])obj;
							num3 = 0;
							num2 = 6;
							continue;
						case 3:
							obj2 = (array as DataRow[])[num3];
							goto case 2;
						case 2:
							ႥႠ.Ⴓ(DataSet, 227, 230)[0].Rows.Remove(obj2 as DataRow);
							goto case 8;
						case 8:
							num2 = 4;
							continue;
						case 4:
							num3++;
							num2 = ⴀႠ[128] - 34415;
							continue;
						case 6:
							num2 = ((num3 < ((DataRow[])array).Length) ? 3 : 0);
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					int num4 = 2;
					while (true)
					{
						int num5;
						switch (num4)
						{
						default:
							num5 = (flag ? 5 : 0);
							goto IL_01bf;
						case 5:
						case 6:
							Monitor.Exit(ⴐ);
							break;
						case 0:
						case 4:
							break;
						}
						break;
						IL_01bf:
						num4 = num5;
					}
				}
				switch (3)
				{
				}
				return;
			}
			}
			num = 2;
		}
	}

	internal bool Ⴓ(string P_0)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		bool flag = false;
		object ⴓ = default(object);
		bool result;
		try
		{
			int num = 0;
			Array array = default(Array);
			while (true)
			{
				switch (num)
				{
				default:
					ႥႥ.ႤႨ(ⴓ = DxCache.m_Ⴓ, ref flag, 421, 468);
					array = ႥႤ.Ⴈ(WxFilters.ႭႷ(ႥႠ.Ⴓ(Ⴄ.Ⴐ, 161, 164), 0, 149, 180), P_0, '\u034f', '\u0322');
					break;
				case 2:
					break;
				case 4:
				case 5:
					result = (array as DataRow[]).GetLength(0) > 0;
					goto end_IL_0034;
				}
				num = 4;
				continue;
				end_IL_0034:
				break;
			}
		}
		finally
		{
			int num2 = 4;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 2 : (ⴗ[140] - 60679));
					goto IL_00f4;
				case 6:
					Monitor.Exit(ⴓ);
					break;
				case 0:
				case 1:
				case 2:
				case 5:
					break;
				}
				break;
				IL_00f4:
				num2 = num3;
			}
		}
		switch (0)
		{
		default:
			ႥႰ.Ⴗ[133] = (char)((ႥႰ.Ⴗ[133] - ႥႰ.Ⴗ[26]) & 0x96);
			return result;
		}
	}

	internal void Ⴓ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		bool flag = false;
		object ⴓ = default(object);
		try
		{
			ႥႥ.ႤႨ(ⴓ = DxCache.m_Ⴓ, ref flag, 813, 860);
			WxFilters.ႭႷ(ႥႠ.Ⴓ(Ⴄ.Ⴐ, 634, 639), 0, 393, 424).Rows.Clear();
		}
		finally
		{
			int num = 1;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!flag) ? 5 : ⴅ[17]);
					goto IL_007f;
				case 0:
					Monitor.Exit(ⴓ);
					break;
				case 2:
				case 5:
					break;
				}
				break;
				IL_007f:
				num = num2;
			}
		}
	}

	public bool IsValidFilter(string sql)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		bool flag = false;
		object ⴐ = default(object);
		bool flag2 = default(bool);
		try
		{
			switch (4)
			{
			default:
				ႥႥ.ႤႨ(ⴐ = Ⴐ, ref flag, 154, 235);
				try
				{
					int num = 0;
					while (true)
					{
						switch (num)
						{
						default:
							HighlightCountyCfg.ႷႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 272, 277), 0, 708, 741), sql, ClientCty.Ⴗ('U', 6, 307013277), 246, 159);
							break;
						case 1:
							break;
						case 3:
							flag2 = true;
							goto end_IL_006a;
						case 4:
							goto end_IL_006a;
						}
						num = ⴀႠ[93] - 27762;
						continue;
						end_IL_006a:
						break;
					}
				}
				catch (Exception)
				{
					flag2 = false;
				}
				break;
			}
		}
		finally
		{
			int num2 = 4;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? (ⴀႠ[35] - 25314) : 2);
					goto IL_010e;
				case 2:
					Monitor.Exit(ⴐ);
					break;
				case 1:
				case 6:
					break;
				}
				break;
				IL_010e:
				num2 = num3;
			}
		}
		return 0 switch
		{
			_ => flag2, 
		};
	}

	public DataRow[] GetDataRows(string filter)
	{
		object obj = TelnetServerCfg.Ⴗ(filter, SqlFilterType.Dx, '\u0379', 859);
		return ႥႠ.Ⴓ(DataSet, 664, 669)[0].Select(obj as string);
	}

	[SecuritySafeCritical]
	static DxCache()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				ArcClientConnectDat.Ⴍ();
				DxCache.Ⴈ = HighlightItuZoneCfg.Ⴓ(WxFilters.Ⴀ(null, 8, 103387530), 845, 893);
				break;
			case 3:
				break;
			case 1:
			case 4:
				Ⴐ = new object();
				DxCache.m_Ⴓ = new object();
				return;
			}
			num = 1;
		}
	}
}
