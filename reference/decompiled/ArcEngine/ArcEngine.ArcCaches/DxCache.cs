using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.Talk;
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
using ArcEngine.ArcDatabase;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcIo.Mirc;
using ArcEngine.ArcIo.ReverseBeacon;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcServerConfig.Io;
using ArcEngine.ArcWeb;
using ArcEngine.QslInfo;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class DxCache
{
	private static readonly ILog m_Ⴄ = SkimmerValidSpot.Ⴐ(ႰႥ.Ⴅ(5, 'Æ', 952622480), 591, 594);

	private DateTime m_Ⴅ = PrintDxFilters.Ⴄ('\u035f', '\u033c');

	private readonly DataSet m_Ⴍ;

	private readonly ArcServerCfg m_Ⴍ;

	private static ConcurrentDictionary<string, DateTime> m_Ⴀ;

	private static ConcurrentDictionary<string, SkimDupeDat> m_Ⴍ;

	private DataSet Ⴐ;

	private AnnFullHelp.Ⴄ m_Ⴗ = new AnnFullHelp.Ⴄ();

	public static ConcurrentDictionary<string, DateTime> _dupeCache
	{
		get
		{
			byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
			return DxCache.m_Ⴀ;
		}
		set
		{
			DxCache.m_Ⴀ = value;
		}
	}

	public static ConcurrentDictionary<string, SkimDupeDat> _skimDupeCache
	{
		get
		{
			byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
			return DxCache.m_Ⴍ;
		}
		set
		{
			DxCache.m_Ⴍ = value;
		}
	}

	public DataSet DataSet
	{
		get
		{
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			DataSet ⴐ = Ⴐ;
			DirectoryBulletin.ႠႨ[169] = (DirectoryBulletin.ႠႨ[169] | IpLockoutCacheCfg.ႭႭ[91]) & 0xFC;
			return ⴐ;
		}
		private set
		{
			Ⴐ = ⴐ;
		}
	}

	[SpecialName]
	internal ႨႤ Ⴀ()
	{
		return this.m_Ⴗ.Ⴍ;
	}

	[SpecialName]
	internal void Ⴗ(ႨႤ P_0)
	{
		this.m_Ⴗ.Ⴍ = P_0;
	}

	public DxCache(ArcServerCfg arcServerCfg)
	{
		try
		{
			Ⴗ(new ႨႤ());
			_dupeCache = new ConcurrentDictionary<string, DateTime>();
			_skimDupeCache = new ConcurrentDictionary<string, SkimDupeDat>();
			this.m_Ⴍ = arcServerCfg;
			this.m_Ⴍ = Ⴓ();
			DataSet = Ⴓ();
			DxCache.m_Ⴄ.Info(SetStationClubHelp.Ⴍ(3, 2, 1747258390, null));
		}
		catch (Exception ex)
		{
			DxCache.m_Ⴄ.Error(SkimmerSpotBins.Ⴈ(ex as Exception, 545, 527));
		}
	}

	public void Init()
	{
	}

	private DataSet Ⴓ()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		while (true)
		{
			ISerializable serializable = new DataSet();
			ByeHelp.Ⴈ(DirectoryHelp.Ⴀ((DataSet)serializable, 'Š', 'ĝ'), new DataTable(SetStationClubHelp.Ⴍ(7, 7, 1747257817, null)), 983, 944);
			int num = ⴃႰ[188] - 63035;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 52;
					continue;
				case 52:
					break;
				case 29:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, '5', 'H'), 0, 'I', 29), 806, 773), new DataColumn(SetTalkCount.Ⴗ(0, null, 1267022179, typeof(DxSpotUniqueCacheWorker)), typeof(string)), 674, 'ʢ');
					num = 4;
					continue;
				case 4:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(serializable as DataSet, '\u0012', 'o'), 0, 'ľ', 362), 247, 212), new DataColumn(ReplyMailHelp.Ⴄ(3, null, 1057162064, 2), typeof(string)), 473, 'Ǚ');
					num = 7;
					continue;
				case 7:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(serializable as DataSet, 'Ǽ', 'Ɓ'), 0, 'Ʀ', 498), 869, 838), new DataColumn(CallBlockCacheCfg.Ⴅ(null, 7, 62057996, null), typeof(string)), 1015, 'Ϸ');
					num = ⴀႳ[32] - 3168;
					continue;
				case 39:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, 'Ů', 'ē'), 0, '\u0359', 781), 236, 207), new DataColumn(ShowSkimCtyHelp.Ⴍ(1216131550, 6, '$'), typeof(string)), 835, '\u0343');
					num = 37;
					continue;
				case 37:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(serializable as DataSet, '\u02d7', 'ʪ'), 0, 'ā', 341), 751, 716), new DataColumn(SetTalkCount.Ⴗ(3, null, 1267021739, typeof(CallbookCfg)), typeof(string)), 498, 'ǲ');
					num = ⴍႤ[403] - 60797;
					continue;
				case 44:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(serializable as DataSet, 'Ŧ', 'ě'), 0, 'Ę', 332), 592, 627), new DataColumn(ShowWxHelp.Ⴍ('m', 985807342, 8), typeof(string)), 573, 'Ƚ');
					num = 48;
					continue;
				case 48:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, 'ů', 'Ē'), 0, 'Č', 344), 299, 264), new DataColumn(ႨႨ.Ⴀ(0, 6, 1157905507), typeof(string)), 1001, 'ϩ');
					num = 11;
					continue;
				case 11:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(serializable as DataSet, 'ɲ', 'ȏ'), 0, '\u00b8', 236), 577, 610), new DataColumn(SetStationQth.Ⴍ(null, 1687353320, 4, 3), typeof(string)), 624, 'ɰ');
					num = 27;
					continue;
				case 27:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, 'Ǜ', 'Ʀ'), 0, 'Ź', 301), 851, 880), new DataColumn(SetStationClubHelp.Ⴍ(1, 0, 1747258426, null), typeof(string)), 810, '\u032a');
					num = 43;
					continue;
				case 43:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(serializable as DataSet, '\u0344', '\u0339'), 0, 'Ĩ', 380), 348, 383), new DataColumn(ReplyMail.Ⴅ(5, 10, 1217944515), typeof(string)), 263, 'ć');
					num = ⴄႷ[122] - 47369;
					continue;
				case 38:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(serializable as DataSet, 'Ɇ', 'Ȼ'), 0, '\u007f', 43), 733, 766), new DataColumn(CallBlockCacheCfg.Ⴅ(null, 6, 62055905, null), typeof(string)), 297, 'ĩ');
					num = 25;
					continue;
				case 25:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(serializable as DataSet, 'Ħ', 'ś'), 0, 'Þ', 138), 29, 62), new DataColumn(ႰႥ.Ⴅ(7, 'u', 952622299), typeof(string)), 411, 'ƛ');
					num = ⴄႷ[7] - 54208;
					continue;
				case 32:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, '\u0342', '\u033f'), 0, '|', 40), 110, 77), new DataColumn(ReplyMailHelp.Ⴄ(25, null, 1057163952, 6), typeof(string)), 486, 'Ǧ');
					num = ⴅ[126] - 64;
					continue;
				case 36:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, '\u0343', '\u033e'), 0, '\u033a', 878), 617, 586), new DataColumn(ShowSkimCtyHelp.Ⴍ(1216131551, 1, 'Ú'), typeof(string)), 744, '\u02e8');
					num = 30;
					continue;
				case 30:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, 'ƪ', 'Ǘ'), 0, '\u0093', 199), 273, 306), new DataColumn(SetStationClubHelp.Ⴍ(1, 0, 1747257416, null), typeof(string)), 697, 'ʹ');
					num = ⴀႳ[280] - 57483;
					continue;
				case 45:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, 'b', '\u001f'), 0, '¿', 235), 836, 871), new DataColumn(ShowSkimCtyHelp.Ⴍ(1216133143, 3, 'x'), typeof(string)), 271, 'ď');
					num = ⴍႤ[281] - 58242;
					continue;
				case 26:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, 'Ώ', 'ϲ'), 0, '\u0081', 213), 575, 540), new DataColumn(ShowWxHelp.Ⴍ('\u0092', 985808431, 8), typeof(string)), 64, '@');
					num = 1;
					continue;
				case 1:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, 'Ν', 'Ϡ'), 0, 'Ǳ', 421), 989, 1022), new DataColumn(SetStationQth.Ⴍ(null, 1687353237, 8, 12), typeof(SqlByte)), 346, 'Ś');
					num = 3;
					continue;
				case 3:
				case 46:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(serializable as DataSet, 'ϖ', 'Ϋ'), 0, 'Ɛ', 452), 904, 939), new DataColumn(SetStationClubHelp.Ⴍ(9, 4, 1747258425, null), typeof(SqlByte)), 315, 'Ļ');
					num = ⴄႭ[7];
					continue;
				case 47:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, 'ɍ', 'Ȱ'), 0, 'ĝ', 329), 308, 279), new DataColumn(ReplyMail.Ⴅ(2, 2, 1217944566), typeof(SqlByte)), 229, 'å');
					num = 20;
					continue;
				case 20:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, 'Ě', 'ŧ'), 0, '\u0338', 876), 132, 167), new DataColumn(CallBlockCacheCfg.Ⴅ(null, 0, 62055918, null), typeof(SqlByte)), 585, 'ɉ');
					num = 49;
					continue;
				case 49:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, '\u009e', 'ã'), 0, '(', 124), 782, 813), new DataColumn(ႰႥ.Ⴅ(2, 'Ï', 952622312), typeof(SqlByte)), 620, 'ɬ');
					num = ⴃႠ[179] - 55519;
					continue;
				case 28:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(serializable as DataSet, 'ˣ', 'ʞ'), 0, 'Ü', 136), 419, 384), new DataColumn(ReplyMailHelp.Ⴄ(24, null, 1057163849, 6), typeof(SqlByte)), 637, 'ɽ');
					num = ⴀႣ[223] - 44355;
					continue;
				case 2:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(serializable as DataSet, 'J', '7'), 0, 'ʑ', 709), 134, 165), new DataColumn(ShowSkimCtyHelp.Ⴍ(1216131563, 7, 'v'), typeof(int)), 347, 'ś');
					num = ⴀႨ[142] - 64993;
					continue;
				case 14:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)serializable, 'Ã', '¾'), 0, 'ƺ', 494), 441, 410), new DataColumn(ႰႥ.Ⴅ(7, 'Ð', 952619269), typeof(int)), 81, 'Q');
					num = ⴅ[231];
					continue;
				case 40:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(serializable as DataSet, 'ɮ', 'ȓ'), 0, 'Ω', 1021), 477, 510), new DataColumn(SetTalkCount.Ⴗ(3, null, 1267023350, typeof(UsVeCallbookUpdate)), typeof(double)), 412, 'Ɯ');
					num = ⴍႤ[416] - 738;
					continue;
				case 53:
					DirectoryHelp.Ⴀ(serializable as DataSet, ')', 'T')[0].Columns.Add(new DataColumn(ႨႨ.Ⴀ(11, 3, 1157905518), typeof(double)));
					num = 22;
					continue;
				case 22:
					(serializable as DataSet).Tables[0].Columns.Add(new DataColumn(SetStationQth.Ⴍ(null, 1687353233, 5, 17), typeof(double)));
					num = 17;
					continue;
				case 17:
					(serializable as DataSet).Tables[0].Columns.Add(new DataColumn(SetStationClubHelp.Ⴍ(9, 0, 1747258413, null), typeof(bool)));
					num = 16;
					continue;
				case 16:
					(serializable as DataSet).Tables[0].Columns.Add(new DataColumn(ReplyMail.Ⴅ(5, 12, 1217944555), typeof(bool)));
					num = ⴅ[365] + 22;
					continue;
				case 34:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(CallBlockCacheCfg.Ⴅ(null, 4, 62055835, null), typeof(bool)));
					num = 15;
					continue;
				case 15:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(ႰႥ.Ⴅ(8, '\0', 952622328), typeof(bool)));
					num = 18;
					continue;
				case 18:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(ReplyMailHelp.Ⴄ(0, null, 1057163846, 6), typeof(bool)));
					num = ⴀႨ[42] - 24449;
					continue;
				case 5:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(ShowSkimCtyHelp.Ⴍ(1216131581, 8, 'º'), typeof(bool)));
					num = ⴀႨ[39] - 33437;
					continue;
				case 42:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(SetTalkCount.Ⴗ(8, null, 1267021735, typeof(Bye)), typeof(bool)));
					num = 12;
					continue;
				case 12:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(ShowWxHelp.Ⴍ('£', 985807319, 6), typeof(bool)));
					goto case 51;
				case 51:
					num = 33;
					continue;
				case 33:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(ႨႨ.Ⴀ(7, 8, 1157905532), typeof(bool)));
					num = ⴀ[169] - 58842;
					continue;
				case 41:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(SetStationQth.Ⴍ(null, 1687353217, 7, 29), typeof(bool)));
					num = 19;
					continue;
				case 19:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(SetStationClubHelp.Ⴍ(5, 5, 1747258401, null), typeof(bool)));
					num = 10;
					continue;
				case 10:
					(serializable as DataSet).Tables[0].Columns.Add(new DataColumn(ReplyMail.Ⴅ(8, 1, 1217944556), typeof(bool)));
					num = ⴃႰ[72] - 45561;
					continue;
				case 23:
					(serializable as DataSet).Tables[0].Columns.Add(new DataColumn(CallBlockCacheCfg.Ⴅ(null, 6, 62055810, null), typeof(bool)));
					num = 6;
					continue;
				case 6:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(ႰႥ.Ⴅ(8, 'U', 952622321), typeof(bool)));
					num = ⴄႤ[50];
					continue;
				case 24:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(ReplyMailHelp.Ⴄ(1, null, 1057163869, 2), typeof(bool)));
					num = ⴃႰ[202] - ⴃႰ[202];
					continue;
				case 0:
					(serializable as DataSet).Tables[0].Columns.Add(new DataColumn(ShowSkimCtyHelp.Ⴍ(1216131579, 5, 'Í'), typeof(bool)));
					num = ⴄႭ[387] - 126;
					continue;
				case 13:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(SetTalkCount.Ⴗ(0, null, 1267021733, typeof(LogMaintenance)), typeof(bool)));
					goto case 31;
				case 31:
					num = 8;
					continue;
				case 8:
					(serializable as DataSet).Tables[0].Columns.Add(new DataColumn(ShowWxHelp.Ⴍ('\t', 985807324, 3), typeof(int)));
					num = 35;
					continue;
				case 35:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(ႰႥ.Ⴅ(7, 'Í', 952620234), typeof(DateTime)));
					num = 50;
					continue;
				case 50:
					((DataSet)serializable).Tables[0].Columns.Add(new DataColumn(SetStationQth.Ⴍ(null, 1687353267, 8, 27), typeof(DateTime)));
					num = 21;
					continue;
				case 21:
					return serializable as DataSet;
				}
				break;
			}
		}
	}

	public bool AddSpot(DxSpot dx)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		bool flag = true;
		try
		{
			switch (1)
			{
			default:
			{
				bool flag2 = false;
				object obj2 = default(object);
				try
				{
					int num = 45;
					object obj = default(object);
					object syncRoot = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							ႨႥ.Ⴍ(obj2 = IoClientDevicesCfg.Ⴐ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, '\u02f3', 'ʎ'), 0, 'Ʉ', 528), 'ž', 382), 'b', (short)113), ref flag2, 787, 794);
							num = 1;
							continue;
						case 1:
							flag = Ⴃ(dx);
							if (!flag)
							{
								num = 54;
								continue;
							}
							break;
						case 54:
							Ⴀ().Ⴃ()[10]++;
							num = 57;
							continue;
						case 57:
							num = ((!ShowPrefixCallsHelp.Ⴈ(dx, 'Ƴ', 423)) ? 6 : (ⴀႣ[416] - 19721));
							continue;
						case 22:
							SetWwvOutputHelp.Ⴍ(dx, Ⴄ(dx), 327, 349);
							goto case 6;
						case 6:
							obj = NodeUserCmd.Ⴓ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, '\u0315', '\u0368'), 0, 'q', 37), 'Ɓ', 'Ǫ');
							num = 35;
							continue;
						case 35:
							ArcConnectObj.Ⴓ(obj as DataRow, SetTalkCount.Ⴗ(6, null, 1267022181, typeof(ႰႥ)), (object)WxHelp.Ⴀ(dx, 274, 271), 'Đ', 'ă');
							num = 58;
							continue;
						case 58:
							ArcConnectObj.Ⴓ((DataRow)obj, ႨႨ.Ⴀ(10, 0, 1157905517), (object)HealthMonitorCfg.Ⴓ(dx, 312, 287), 'ɐ', 'Ƀ');
							num = 41;
							continue;
						case 41:
							ArcConnectObj.Ⴓ((DataRow)obj, SetStationClubHelp.Ⴍ(12, 7, 1747257423, null), (object)ShowVersion.Ⴐ(dx, 6, 120), '_', 'L');
							num = 14;
							continue;
						case 14:
							ArcConnectObj.Ⴓ((DataRow)obj, SetStationClubHelp.Ⴍ(14, 0, 1747258413, null), (object)ShowPrefixCallsHelp.Ⴈ(dx, 'κ', 943), 'Æ', 'Õ');
							num = ⴍႤ[312] - 37260;
							continue;
						case 33:
							ArcConnectObj.Ⴓ((DataRow)obj, ShowSkimCtyHelp.Ⴍ(1216131549, 5, '&'), (object)ShowVersion.Ⴐ(dx, 523, 630), 'Ĝ', 'ď');
							num = 15;
							continue;
						case 15:
							ArcConnectObj.Ⴓ((DataRow)obj, ႨႨ.Ⴀ(7, 1, 1157905508), (object)MailCacheCfg.Ⴅ(dx, 284, 'Ů'), '\u030a', '\u0319');
							num = ⴀ[164] - 7644;
							continue;
						case 20:
							ArcConnectObj.Ⴓ((DataRow)obj, ReplyMailHelp.Ⴄ(16, null, 1057163953, 7), (object)MailCacheCfg.Ⴅ(dx, 596, 'Ƞ'), 'ƫ', 'Ƹ');
							num = ⴄႤ[337] - 21;
							continue;
						case 32:
							ArcConnectObj.Ⴓ(obj as DataRow, ShowSkimCtyHelp.Ⴍ(1216131545, 7, '\u0011'), (object)MailCacheCfg.Ⴅ(dx, 536, 'ɫ'), 'Ư', 'Ƽ');
							num = 31;
							continue;
						case 31:
							ArcConnectObj.Ⴓ(obj as DataRow, CallBlockCacheCfg.Ⴅ(null, 1, 62055910, null), (object)ShowNodesHelp.Ⴓ(dx, 685, 'ʪ'), 'Ǖ', 'ǆ');
							goto case 29;
						case 29:
							num = ⴃႥ[397] - 30633;
							continue;
						case 13:
							ArcConnectObj.Ⴓ(obj as DataRow, SetTalkCount.Ⴗ(1, null, 1267021737, typeof(RevBcnSpotProcessor)), (object)WxHelp.Ⴀ(dx, 257, 287), 'ˍ', '\u02de');
							num = ⴄႷ[2] - 23598;
							continue;
						case 8:
							ArcConnectObj.Ⴓ((DataRow)obj, ႰႥ.Ⴅ(8, 'Ò', 952622292), (object)SetStationGrid.Ⴍ(SetDxExtensionHelp.Ⴍ(dx, 'ϼ', 'Ϯ'), 294, 'Ŵ'), 'ί', 'μ');
							num = ⴄႭ[299];
							continue;
						case 34:
							ArcConnectObj.Ⴓ(obj as DataRow, SetStationClubHelp.Ⴍ(10, 1, 1747258427, null), (object)MailCacheCfg.Ⴅ(dx, 359, 'Ė'), 'Υ', 'ζ');
							num = ⴀႣ[4] - 32449;
							continue;
						case 19:
							ArcConnectObj.Ⴓ((DataRow)obj, SetStationQth.Ⴍ(null, 1687353237, 8, 2), (object)SendMail.Ⴐ(dx, 381, 'ľ'), 'ʇ', 'ʔ');
							num = ⴀႣ[27] - 42954;
							continue;
						case 3:
							ArcConnectObj.Ⴓ(obj as DataRow, ReplyMail.Ⴅ(2, 14, 1217944566), (object)SetStationGridHelp.Ⴓ(dx, 681, 714), 'ʾ', 'ʭ');
							num = ⴄႤ[65];
							continue;
						case 48:
							ArcConnectObj.Ⴓ((DataRow)obj, SetTalkCount.Ⴗ(8, null, 1267023357, typeof(WwvSpotUser)), (object)StationHelp.Ⴗ(dx, 'ʠ', 653), '\u02e9', '\u02fa');
							num = 25;
							continue;
						case 25:
							ArcConnectObj.Ⴓ(obj as DataRow, ShowWxHelp.Ⴍ('Û', 985807318, 7), (object)ShowPrefixCallsHelp.Ⴈ(dx, 'ţ', 375), 'ʨ', 'ʻ');
							num = 9;
							continue;
						case 9:
							ArcConnectObj.Ⴓ((DataRow)obj, SetStationQth.Ⴍ(null, 1687353217, 7, 1), (object)ShowDxFilter.Ⴅ(dx, 136, '\u0083'), '·', 'Δ');
							num = ⴍႤ[300] - 58924;
							continue;
						case 27:
							ArcConnectObj.Ⴓ(obj as DataRow, ReplyMailHelp.Ⴄ(2, null, 1057163850, 5), (object)SetWxDefaultHelp.Ⴄ(dx, '\u02eb', 691), 'ē', 'Ā');
							num = ⴐ[44] - 34;
							continue;
						case 23:
							ArcConnectObj.Ⴓ(obj as DataRow, ႰႥ.Ⴅ(6, '|', 952622316), (object)SetWwvOutputHelp.Ⴀ(dx, 'ʢ', 645), 'ƒ', 'Ɓ');
							num = 26;
							continue;
						case 26:
							ArcConnectObj.Ⴓ((DataRow)obj, ႨႨ.Ⴀ(2, 6, 1157905522), (object)SetAnnDefaultHelp.Ⴅ(dx, 968, 1010), 'ū', 'Ÿ');
							num = 0;
							continue;
						case 0:
							ArcConnectObj.Ⴓ((DataRow)obj, ShowSkimCtyHelp.Ⴍ(1216131567, 3, '¥'), (object)SetWxDefaultHelp.Ⴄ(dx, 'Ů', 311), 'Ŀ', 'Ĭ');
							num = 11;
							continue;
						case 11:
							ArcConnectObj.Ⴓ(obj as DataRow, ႰႥ.Ⴅ(0, '¹', 952622320), (object)ShowPrefixCallsHelp.Ⴈ(dx, 'x', 110), 'ϣ', 'ϰ');
							num = 36;
							continue;
						case 36:
							ArcConnectObj.Ⴓ((DataRow)obj, ReplyMailHelp.Ⴄ(27, null, 1057163841, 1), (object)TalkHelp.Ⴀ(dx, 791, '\u0312'), 'ρ', 'ϒ');
							num = ⴄႷ[52] - 60815;
							continue;
						case 7:
							ArcConnectObj.Ⴓ((DataRow)obj, ShowSkimCtyHelp.Ⴍ(1216131572, 1, 'ù'), (object)ShowAnn.Ⴗ(dx, 'Ȝ', 518), 'ā', 'Ē');
							num = ⴄႤ[413] - 3;
							continue;
						case 17:
						case 28:
							ArcConnectObj.Ⴓ((DataRow)obj, SetTalkCount.Ⴗ(4, null, 1267021739, typeof(ႳႣ)), (object)ShowPrefixCallsHelp.Ⴈ(dx, 'Α', 902), '\u02fc', '\u02ef');
							num = ⴐ[338];
							continue;
						case 24:
							ArcConnectObj.Ⴓ(obj as DataRow, ReplyMailHelp.Ⴄ(26, null, 1057162064, 2), (object)ShowVersion.Ⴐ(dx, 832, 828), 'ʨ', 'ʻ');
							num = 10;
							continue;
						case 10:
							ArcConnectObj.Ⴓ(obj as DataRow, CallBlockCacheCfg.Ⴅ(null, 6, 62057997, null), (object)ShowPrefix.Ⴍ(dx, 973, 1022), 'ɉ', 'ɚ');
							num = ⴀႳ[57] - 52663;
							continue;
						case 16:
							ArcConnectObj.Ⴓ((DataRow)obj, ShowWxHelp.Ⴍ('ÿ', 985807332, 2), (object)SetDxExtensionHelp.Ⴍ(dx, '\u0375', '\u0366'), 'ʗ', 'ʄ');
							num = ⴀႳ[26] - 61923;
							continue;
						case 5:
							ArcConnectObj.Ⴓ(obj as DataRow, SetStationQth.Ⴍ(null, 1687353324, 0, 18), (object)MircIo.Ⴈ(dx, 'ː', 'ʑ'), '\u02ed', '\u02fe');
							num = 4;
							continue;
						case 4:
							ArcConnectObj.Ⴓ(obj as DataRow, ReplyMail.Ⴅ(5, 1, 1217944515), (object)ShowAnn.Ⴄ(dx, 'ň', 307), 'Ŝ', 'ŏ');
							num = 30;
							continue;
						case 30:
							(obj as DataRow)[SetStationClubHelp.Ⴍ(8, 5, 1747258424, null)] = dx.SpotterCqZone;
							num = 2;
							continue;
						case 2:
							((DataRow)obj)[CallBlockCacheCfg.Ⴅ(null, 7, 62055913, null)] = dx.SpotterItuZone;
							num = 12;
							continue;
						case 12:
							(obj as DataRow)[ReplyMail.Ⴅ(0, 5, 1217944558)] = dx.Bob;
							num = 18;
							continue;
						case 18:
							((DataRow)obj)[CallBlockCacheCfg.Ⴅ(null, 7, 62055832, null)] = dx.Cq;
							num = 51;
							continue;
						case 51:
							(obj as DataRow)[ႰႥ.Ⴅ(2, 'W', 952620239)] = dx.Dts;
							num = ⴃႠ[90] - 63057;
							continue;
						case 47:
							(obj as DataRow)[SetStationClubHelp.Ⴍ(3, 3, 1747258407, null)] = dx.IsSkimUnknown;
							num = 38;
							continue;
						case 38:
							((DataRow)obj)[ReplyMail.Ⴅ(4, 1, 1217944544)] = dx.IsSkimValid;
							num = 56;
							continue;
						case 56:
							((DataRow)obj)[CallBlockCacheCfg.Ⴅ(null, 5, 62055809, null)] = dx.IsSkimQsy;
							num = 49;
							continue;
						case 49:
							((DataRow)obj)[ႰႥ.Ⴅ(4, '\u000e', 952622333)] = dx.IsSkimBusted;
							num = 39;
							continue;
						case 39:
							((DataRow)obj)[SetStationQth.Ⴍ(null, 1687353237, 1, 8)] = dx.SkimFreqQsyPercent;
							num = ⴄႤ[406] / 4;
							continue;
						case 50:
							((DataRow)obj)[ShowWxHelp.Ⴍ('s', 985807321, 6)] = dx.SkimCtyCnt;
							num = ⴍႤ[325] - 51976;
							continue;
						case 55:
							((DataRow)obj)[ShowSkimCtyHelp.Ⴍ(1216133136, 4, '\u0019')] = dx.Route;
							num = ⴍႭ[285] - 5765;
							continue;
						case 40:
							(obj as DataRow)[ႰႥ.Ⴅ(8, '?', 952619274)] = dx.Id;
							num = 37;
							continue;
						case 37:
							((DataRow)obj)[ShowWxHelp.Ⴍ('ý', 985808420, 3)] = dx.DupeKey;
							goto case 43;
						case 43:
							num = 53;
							continue;
						case 53:
							(obj as DataRow)[SetStationQth.Ⴍ(null, 1687353273, 2, 31)] = dx.DtsRx;
							num = 52;
							continue;
						case 52:
							DataSet.Tables[0].Rows.Add((DataRow)obj);
							num = ((!dx.Skimmer) ? (ⴄႭ[279] - 45) : (ⴄႤ[74] - 163));
							continue;
						case 44:
							num = ((!dx.SkimDupe) ? 42 : 21);
							continue;
						case 21:
							((DataRow)obj).AcceptChanges();
							goto case 42;
						case 42:
						{
							bool lockTaken = false;
							try
							{
								int num2 = 3;
								while (true)
								{
									switch (num2)
									{
									case 0:
										this.m_Ⴍ.Tables[0].ImportRow(obj as DataRow);
										goto end_IL_0dba;
									}
									Monitor.Enter(syncRoot = this.m_Ⴍ.Tables[0].Rows.SyncRoot, ref lockTaken);
									num2 = ⴀႼ[80];
									continue;
									end_IL_0dba:
									break;
								}
							}
							finally
							{
								int num3 = 5;
								while (true)
								{
									int num4;
									switch (num3)
									{
									default:
										num4 = ((!lockTaken) ? 1 : (ⴃႠ[325] - 17541));
										goto IL_0e5c;
									case 0:
									case 2:
									case 4:
										Monitor.Exit(syncRoot);
										break;
									case 1:
									case 3:
										break;
									}
									break;
									IL_0e5c:
									num3 = num4;
								}
							}
							break;
						}
						}
						break;
					}
					switch (0)
					{
					}
				}
				finally
				{
					int num5 = 4;
					while (true)
					{
						int num6;
						switch (num5)
						{
						default:
							num6 = ((!flag2) ? 3 : (ⴀႣ[113] - 24818));
							goto IL_0ebf;
						case 1:
						case 2:
						case 5:
						case 6:
							Monitor.Exit(obj2);
							break;
						case 3:
							break;
						}
						break;
						IL_0ebf:
						num5 = num6;
					}
				}
				switch (1)
				{
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			DxCache.m_Ⴄ.Error(ex.Message);
		}
		return 0 switch
		{
			_ => flag, 
		};
	}

	internal bool Ⴄ(DxSpot P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		SkimDupeDat value = default(SkimDupeDat);
		TimeSpan timeSpan = default(TimeSpan);
		double num2 = default(double);
		double num3 = default(double);
		while (true)
		{
			bool result = false;
			object obj = SetWxCountHelp.Ⴗ((object)WxHelp.Ⴀ(P_0, 49, 44), (object)StationHelp.Ⴗ(P_0, ')', 4), 819, (short)840);
			while (true)
			{
				IL_00d2:
				int num = 7;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴄႤ[150] - 97;
						continue;
					case 16:
						break;
					case 12:
						goto IL_00d2;
					case 7:
						value = new SkimDupeDat(SetWxCountHelp.Ⴍ(P_0, '\u036d', 876), HealthMonitorCfg.Ⴓ(P_0, 474, 509));
						num = 11;
						continue;
					case 11:
						num = (_skimDupeCache.TryAdd((string)obj, value) ? (ⴀႳ[167] - 16001) : (ⴀႳ[38] - 44445));
						continue;
					case 9:
						num = ((!_skimDupeCache.TryGetValue(obj as string, out value)) ? 6 : 0);
						continue;
					case 0:
						timeSpan = SetWxMode.Ⴃ(SetWxCountHelp.Ⴍ(P_0, '\u0365', 868), value.Ⴍ(), 708, 650);
						goto case 10;
					case 10:
						num = ⴃႠ[17] - 62734;
						continue;
					case 4:
						num2 = (double)value.Ⴀ() + this.m_Ⴍ.Caches.Dx.DupeFrequencyRange;
						num = ⴃႰ[136] - 29129;
						continue;
					case 3:
						num3 = (double)value.Ⴀ() - this.m_Ⴍ.Caches.Dx.DupeFrequencyRange;
						num = ⴅ[198] - 189;
						continue;
					case 2:
						num = ((ShowNodes.Ⴍ(ref timeSpan, 813, '\u031f') >= 10) ? 1 : (ⴀႨ[172] - 21866));
						continue;
					case 8:
						num = ((!((double)HealthMonitorCfg.Ⴓ(P_0, 932, 899) > num3)) ? (ⴀႣ[388] - 36007) : 14);
						continue;
					case 14:
						num = ((!((double)P_0.Freq < num2)) ? (ⴃႥ[116] - 45458) : 15);
						continue;
					case 15:
						result = true;
						num = ⴀႼ[1] - 218;
						continue;
					case 1:
					{
						object obj2 = new SkimDupeDat(P_0.DtsRx, P_0.Freq);
						_skimDupeCache.TryUpdate(obj as string, obj2 as SkimDupeDat, value);
						num = ⴄႷ[26] - 9162;
						continue;
					}
					case 5:
					case 6:
						return result;
					}
					break;
				}
				break;
			}
		}
	}

	private bool Ⴃ(DxSpot P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		while (true)
		{
			int num = ((!Ⴍ(SetDxExtensionHelp.Ⴍ(P_0, '\u02f8', 'ˬ'), TalkSpotHelp.Ⴈ(P_0, 37, 'T'))) ? (ⴀႣ[333] - 23431) : ⴄႤ[148]);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
					break;
				case 1:
					return true;
				case 2:
				case 4:
					return !_dupeCache.TryAdd(SetDxExtensionHelp.Ⴍ(P_0, 'ɢ', 'ɶ') + TalkSpotHelp.Ⴈ(P_0, 143, 'þ').ToString(ႰႥ.Ⴅ(1, '\u0082', 952619386)), P_0.DtsRx);
				}
				break;
			}
		}
	}

	internal bool Ⴍ(string P_0, DateTime P_1)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		while (true)
		{
			bool result = false;
			int num = ((!_dupeCache.ContainsKey(ShowUsersHelp.Ⴅ(P_0, ShowAnnOptionsHelp.Ⴗ(ref P_1, ႰႥ.Ⴅ(0, '\u009d', 952619387), 376, 380), 599, 537))) ? 3 : ⴐ[243]);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႷ[66] - 17237;
					continue;
				case 5:
					break;
				case 8:
					return true;
				case 3:
				case 6:
				{
					ConcurrentDictionary<string, DateTime> dupeCache = _dupeCache;
					DateTime dateTime = ReadMailHelp.Ⴍ(ref P_1, 1.0, 492, 492);
					num = ((!dupeCache.ContainsKey(ShowUsersHelp.Ⴅ(P_0, ShowAnnOptionsHelp.Ⴗ(ref dateTime, ႰႥ.Ⴅ(4, '\u0014', 952619391), 202, 206), 75, 5))) ? (ⴐ[369] - 146) : 4);
					continue;
				}
				case 0:
				case 4:
				case 7:
					return true;
				case 1:
					num = ((!_dupeCache.ContainsKey(P_0 + ReadMailHelp.Ⴍ(ref P_1, -1.0, 987, 987).ToString(ႰႥ.Ⴅ(3, '"', 952619384)))) ? 9 : 10);
					continue;
				case 10:
					return true;
				case 9:
					return result;
				}
				break;
			}
		}
	}

	internal bool Ⴍ(string P_0)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		bool flag2;
		try
		{
			switch (3)
			{
			default:
			{
				bool flag = false;
				object obj = default(object);
				try
				{
					int num = 4;
					Array array = default(Array);
					while (true)
					{
						switch (num)
						{
						default:
							ႨႥ.Ⴍ(obj = IoClientDevicesCfg.Ⴐ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.m_Ⴍ, 'Ĥ', 'ř'), 0, 'ƶ', 482), 'Ǐ', 463), 'Ƶ', (short)422), ref flag, 732, 725);
							num = 0;
							continue;
						case 0:
						case 5:
							array = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.m_Ⴍ, 'Ζ', 'ϫ'), 0, 'Ť', 304), P_0, '|', 65);
							num = ⴀႣ[335] - 40270;
							continue;
						case 1:
						case 3:
						case 6:
							flag2 = (array as DataRow[]).Length > 0;
							break;
						}
						break;
					}
				}
				finally
				{
					int num2 = 3;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = ((!flag) ? (ⴍႤ[282] - 26275) : ⴀႼ[113]);
							goto IL_013b;
						case 2:
							Monitor.Exit(obj);
							break;
						case 1:
							break;
						}
						break;
						IL_013b:
						num2 = num3;
					}
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			DxCache.m_Ⴄ.Error((ex as Exception).Message);
			flag2 = false;
		}
		return 4 switch
		{
			_ => flag2, 
		};
	}

	public void CleanTempCache(int id)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		try
		{
			switch (0)
			{
			default:
			{
				bool flag = false;
				object obj4 = default(object);
				try
				{
					int num = 5;
					object obj2 = default(object);
					object obj3 = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							ႨႥ.Ⴍ(obj4 = IoClientDevicesCfg.Ⴐ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.m_Ⴍ, 'Š', 'ĝ'), 0, 'u', 33), 'ʢ', 674), 'Ȯ', (short)573), ref flag, 135, 142);
							break;
						case 0:
							break;
						case 1:
						case 4:
						{
							object obj = SetDxOutputHelp.Ⴍ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.m_Ⴍ, '\u0003', '~'), 0, 'P', 4), '\u02e8', 744), 'ȡ', 568);
							try
							{
								int num2 = 3;
								while (true)
								{
									switch (num2)
									{
									default:
										num2 = ⴅ[210];
										continue;
									case 2:
										obj2 = (DataRow)(obj as IEnumerator).Current;
										num2 = ((id != (int)qslinfoSoapClient.Ⴓ((DataRow)obj2, ႰႥ.Ⴅ(5, '\u007f', 952619271), 361, 'ħ')) ? (ⴄႷ[105] - 22532) : 6);
										continue;
									case 6:
									case 7:
										ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.m_Ⴍ, '\u030b', 'Ͷ'), 0, '9', 109), '¥', 165).Remove((DataRow)obj2);
										num2 = ⴄႷ[45] - 37265;
										continue;
									case 0:
									case 8:
										num2 = (((IEnumerator)obj).MoveNext() ? 2 : (ⴃႰ[181] - 6610));
										continue;
									case 5:
										break;
									}
									break;
								}
							}
							finally
							{
								int num3 = 0;
								while (true)
								{
									int num4;
									switch (num3)
									{
									default:
										obj3 = (obj as IEnumerator) as IDisposable;
										goto case 3;
									case 3:
										num4 = ((!(obj3 is IDisposable)) ? 1 : 2);
										goto IL_021c;
									case 2:
										(obj3 as IDisposable).Dispose();
										break;
									case 1:
									case 5:
										break;
									}
									break;
									IL_021c:
									num3 = num4;
								}
							}
							switch (3)
							{
							}
							goto end_IL_0038;
						}
						}
						num = 1;
						continue;
						end_IL_0038:
						break;
					}
				}
				finally
				{
					int num5 = 5;
					while (true)
					{
						int num6;
						switch (num5)
						{
						default:
							num6 = (flag ? 1 : 0);
							goto IL_027a;
						case 1:
						case 2:
							Monitor.Exit(obj4);
							break;
						case 0:
						case 3:
						case 6:
							break;
						}
						break;
						IL_027a:
						num5 = num6;
					}
				}
				switch (3)
				{
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			DxCache.m_Ⴄ.Error(id + ႰႥ.Ⴅ(5, 'Ã', 952620215) + ex.Message);
		}
		switch (1)
		{
		}
	}

	public void SaveToDb()
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		bool flag = false;
		object obj = default(object);
		try
		{
			switch (4)
			{
			default:
				ႨႥ.Ⴍ(obj = IoClientDevicesCfg.Ⴐ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, '\u0364', '\u0319'), 0, 'E', 17), 'ʕ', 661), 'ɫ', (short)632), ref flag, 836, 845);
				try
				{
					switch (3)
					{
					default:
					{
						object obj2 = new SqlCeConnection(this.m_Ⴍ.Configuration.DbConnect);
						try
						{
							int num = 28;
							object obj3 = default(object);
							ICloneable cloneable = default(ICloneable);
							ICloneable cloneable2 = default(ICloneable);
							int num2 = default(int);
							while (true)
							{
								switch (num)
								{
								default:
									obj3 = new PrecisionTimer();
									ShowPrefixCallsHelp.Ⴗ(obj3 as PrecisionTimer, 543, 606);
									SetAnnWrapHelp.Ⴀ((DbConnection)(obj2 as SqlCeConnection), 277, (short)278);
									num = 27;
									continue;
								case 27:
								case 32:
									cloneable = new SqlCeDataAdapter();
									goto case 37;
								case 37:
									cloneable2 = new SqlCeCommand(ReplyMail.Ⴅ(8, 13, 1217944397), (SqlCeConnection)obj2);
									num = ⴀႣ[369] - 29069;
									continue;
								case 20:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 645, 754), CallBlockCacheCfg.Ⴅ(null, 4, 62058092, null), SqlDbType.NVarChar, 12, SetTalkCount.Ⴗ(6, null, 1267022181, typeof(ReadMail)), 154, 187);
									num = 33;
									continue;
								case 13:
								case 33:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 546, 597), SetStationQth.Ⴍ(null, 1687353554, 0, 27), SqlDbType.Real, 0, ႨႨ.Ⴀ(5, 6, 1157905515), 455, 486);
									num = 10;
									continue;
								case 10:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 294, 337), ReplyMailHelp.Ⴄ(6, null, 1057163607, 5), SqlDbType.NVarChar, 4, SetStationClubHelp.Ⴍ(4, 6, 1747257422, null), 131, 162);
									num = ⴄႭ[134] * 5;
									continue;
								case 40:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable2 as SqlCeCommand, 437, 450), SetStationQth.Ⴍ(null, 1687353547, 1, 3), SqlDbType.NVarChar, 5, ShowSkimCtyHelp.Ⴍ(1216131544, 0, '§'), 964, 997);
									num = 24;
									continue;
								case 24:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable2 as SqlCeCommand, 1017, 910), ReplyMailHelp.Ⴄ(13, null, 1057163624, 2), SqlDbType.NVarChar, 6, SetTalkCount.Ⴗ(0, null, 1267021736, typeof(ShowWwv)), 201, 232);
									num = 14;
									continue;
								case 14:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable2 as SqlCeCommand, 941, 986), SetStationQth.Ⴍ(null, 1687353540, 7, 3), SqlDbType.NVarChar, 2, ႨႨ.Ⴀ(5, 7, 1157905506), 316, 285);
									num = ⴄႷ[16] - 11905;
									continue;
								case 16:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 950, 961), ReplyMailHelp.Ⴄ(31, null, 1057163623, 5), SqlDbType.NVarChar, 30, ႰႥ.Ⴅ(0, '4', 952622300), 923, 954);
									num = 35;
									continue;
								case 35:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 961, 950), SetStationQth.Ⴍ(null, 1687353593, 3, 15), SqlDbType.NVarChar, 2, SetStationClubHelp.Ⴍ(11, 5, 1747258431, null), 831, 798);
									num = 36;
									continue;
								case 36:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 2, 117), ReplyMailHelp.Ⴄ(16, null, 1057163645, 8), SqlDbType.TinyInt, 0, SetStationQth.Ⴍ(null, 1687353240, 5, 18), 780, 813);
									num = 26;
									continue;
								case 26:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 551, 592), SetStationQth.Ⴍ(null, 1687353587, 1, 14), SqlDbType.TinyInt, 0, ReplyMail.Ⴅ(3, 2, 1217944567), 331, 362);
									num = 19;
									continue;
								case 19:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 764, 651), ReplyMailHelp.Ⴄ(21, null, 1057163530, 5), SqlDbType.Real, 0, SetTalkCount.Ⴗ(4, null, 1267023345, typeof(UsVeCallbookUpdate)), 261, 292);
									num = 6;
									continue;
								case 6:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable2 as SqlCeCommand, 900, 1011), ReplyMailHelp.Ⴄ(10, null, 1057161850, 2), SqlDbType.NVarChar, 12, ReplyMailHelp.Ⴄ(31, null, 1057162065, 3), 404, 437);
									num = ⴄႤ[144] - 38;
									continue;
								case 17:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 138, 253), SetStationQth.Ⴍ(null, 1687351866, 3, 15), SqlDbType.NVarChar, 12, CallBlockCacheCfg.Ⴅ(null, 2, 62057993, null), 226, 195);
									num = 30;
									continue;
								case 30:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 923, 1004), SetStationQth.Ⴍ(null, 1687353575, 0, 15), SqlDbType.NVarChar, 5, ShowWxHelp.Ⴍ('!', 985807328, 6), 477, 508);
									num = 41;
									continue;
								case 41:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 15, 120), ReplyMailHelp.Ⴄ(22, null, 1057163521, 6), SqlDbType.NVarChar, 2, SetStationQth.Ⴍ(null, 1687353327, 3, 6), 45, 12);
									num = 4;
									continue;
								case 4:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable2 as SqlCeCommand, 965, 946), SetStationQth.Ⴍ(null, 1687353497, 0, 25), SqlDbType.NVarChar, 2, ReplyMail.Ⴅ(4, 15, 1217944514), 355, 322);
									num = ⴃႥ[334] - 56861;
									continue;
								case 31:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 420, 467), ReplyMailHelp.Ⴄ(18, null, 1057163542, 1), SqlDbType.Bit, 0, ReplyMail.Ⴅ(0, 4, 1217944558), 718, 751);
									num = 1;
									continue;
								case 1:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable2 as SqlCeCommand, 99, 20), SetStationQth.Ⴍ(null, 1687353487, 5, 14), SqlDbType.Bit, 0, SetStationClubHelp.Ⴍ(8, 3, 1747258414, null), 939, 906);
									num = 3;
									continue;
								case 3:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable2 as SqlCeCommand, 171, 220), ReplyMailHelp.Ⴄ(2, null, 1057161728, 7), SqlDbType.NVarChar, 255, ShowSkimCtyHelp.Ⴍ(1216133148, 8, 'z'), 711, 742);
									num = 23;
									continue;
								case 23:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable2 as SqlCeCommand, 1015, 896), CallBlockCacheCfg.Ⴅ(null, 1, 62058001, null), SqlDbType.DateTime, 0, ႰႥ.Ⴅ(5, '\u0085', 952620232), 305, 272);
									num = ⴄႤ[384] - ⴄႤ[495];
									continue;
								case 15:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 516, 627), ReplyMailHelp.Ⴄ(7, null, 1057163573, 0), SqlDbType.NVarChar, 24, ReplyMailHelp.Ⴄ(1, null, 1057163955, 5), 801, 768);
									num = 11;
									continue;
								case 11:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 176, 199), SetStationQth.Ⴍ(null, 1687353477, 7, 28), SqlDbType.NVarChar, 3, ShowSkimCtyHelp.Ⴍ(1216131551, 1, '\u0091'), 281, 312);
									num = 12;
									continue;
								case 12:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable2 as SqlCeCommand, 377, 270), ReplyMailHelp.Ⴄ(8, null, 1057163470, 1), SqlDbType.Bit, 0, CallBlockCacheCfg.Ⴅ(null, 3, 62055836, null), 463, 494);
									num = ⴀႨ[23] - 23995;
									continue;
								case 34:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 183, 192), SetStationQth.Ⴍ(null, 1687353531, 8, 28), SqlDbType.DateTime, 0, SetStationQth.Ⴍ(null, 1687353277, 6, 7), 203, 234);
									num = ⴀႨ[222] - 27476;
									continue;
								case 21:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable2, 930, 981), ReplyMailHelp.Ⴄ(10, null, 1057163463, 2), SqlDbType.TinyInt, 0, SetStationClubHelp.Ⴍ(11, 0, 1747258429, null), 211, 242);
									num = 9;
									continue;
								case 9:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable2 as SqlCeCommand, 659, 740), SetStationQth.Ⴍ(null, 1687353513, 3, 23), SqlDbType.TinyInt, 0, CallBlockCacheCfg.Ⴅ(null, 2, 62055916, null), 875, 842);
									num = 39;
									continue;
								case 39:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable2 as SqlCeCommand, 285, 362), ReplyMailHelp.Ⴄ(22, null, 1057163478, 0), SqlDbType.Bit, 0, ႰႥ.Ⴅ(4, 'ñ', 952622324), 213, 244);
									num = ⴍႤ[73] - 60495;
									continue;
								case 18:
									ShowStation.Ⴓ(cloneable2 as SqlCeCommand, 536, 623).Add(SetStationQth.Ⴍ(null, 1687353680, 8, 13), SqlDbType.TinyInt, 0, ShowSkimCtyHelp.Ⴍ(1216131556, 8, '\u0088'));
									num = 38;
									continue;
								case 38:
									(cloneable2 as SqlCeCommand).Parameters.Add(ReplyMailHelp.Ⴄ(31, null, 1057163498, 2), SqlDbType.Bit, 0, ShowSkimCtyHelp.Ⴍ(1216131572, 1, '*'));
									num = ⴃႥ[21] - 7883;
									continue;
								case 25:
									((SqlCeCommand)cloneable2).Parameters.Add(SetStationQth.Ⴍ(null, 1687353677, 3, 31), SqlDbType.Bit, 0, SetTalkCount.Ⴗ(3, null, 1267021740, typeof(YahooGeoRef)));
									num = 29;
									continue;
								case 29:
									((SqlCeCommand)cloneable2).Parameters.Add(ReplyMailHelp.Ⴄ(1, null, 1057163416, 6), SqlDbType.NVarChar, 25, CallBlockCacheCfg.Ⴅ(null, 8, 62055919, null));
									num = 7;
									continue;
								case 7:
									((SqlCeCommand)cloneable2).Parameters.Add(SetStationQth.Ⴍ(null, 1687353679, 8, 26), SqlDbType.Bit, 0, ReplyMailHelp.Ⴄ(7, null, 1057163840, 0));
									num = 8;
									continue;
								case 8:
									(cloneable2 as SqlCeCommand).Parameters.Add(ReplyMailHelp.Ⴄ(17, null, 1057163410, 4), SqlDbType.Bit, 0, ShowWxHelp.Ⴍ('\u009b', 985807318, 7));
									num = 5;
									continue;
								case 5:
									(cloneable2 as SqlCeCommand).Parameters.Add(SetStationQth.Ⴍ(null, 1687353720, 7, 19), SqlDbType.Bit, 0, ႨႨ.Ⴀ(6, 3, 1157905527));
									num = 0;
									continue;
								case 0:
									(cloneable as SqlCeDataAdapter).InsertCommand = cloneable2 as SqlCeCommand;
									num2 = (cloneable as SqlCeDataAdapter).Update(DataSet.Tables[0]);
									num = ⴄႷ[38] - 46347;
									continue;
								case 2:
								{
									this.m_Ⴅ = DateTime.Now;
									((PrecisionTimer)obj3).Stop();
									ILog ⴄ = DxCache.m_Ⴄ;
									Array array = new object[4];
									(array as object[])[0] = obj3 as PrecisionTimer;
									((object[])array)[1] = ႨႨ.Ⴀ(12, 1, 1157905730);
									(array as object[])[2] = num2;
									(array as object[])[3] = SetStationQth.Ⴍ(null, 1687351837, 6, 6);
									ⴄ.Info(string.Concat(array as object[]));
									break;
								}
								}
								break;
							}
						}
						finally
						{
							int num3 = 6;
							while (true)
							{
								int num4;
								switch (num3)
								{
								default:
									num4 = ((!(obj2 is SqlCeConnection)) ? ⴀႼ[96] : 3);
									goto IL_0cf2;
								case 3:
									((IDisposable)(SqlCeConnection)obj2).Dispose();
									break;
								case 1:
								case 4:
									break;
								}
								break;
								IL_0cf2:
								num3 = num4;
							}
						}
						switch (1)
						{
						}
						break;
					}
					}
				}
				catch (Exception ex)
				{
					DxCache.m_Ⴄ.Error((ex as Exception).Message);
				}
				switch (2)
				{
				}
				break;
			}
		}
		finally
		{
			int num5 = 4;
			while (true)
			{
				int num6;
				switch (num5)
				{
				default:
					num6 = ((!flag) ? (ⴐ[258] - 72) : 5);
					goto IL_0d8e;
				case 3:
				case 5:
					Monitor.Exit(obj);
					break;
				case 1:
				case 6:
					break;
				}
				break;
				IL_0d8e:
				num5 = num6;
			}
		}
		switch (3)
		{
		}
	}

	public DataTable GetDataTable(string sql, int nmbrDesired)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		ISupportInitializeNotification supportInitializeNotification;
		try
		{
			switch (1)
			{
			default:
			{
				bool flag = false;
				object obj2 = default(object);
				object obj;
				try
				{
					int num = 1;
					while (true)
					{
						switch (num)
						{
						default:
							ႨႥ.Ⴍ(obj2 = IoClientDevicesCfg.Ⴐ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, 'Š', 'ĝ'), 0, 'Ţ', 310), 'm', 109), 'ŏ', (short)348), ref flag, 99, 106);
							break;
						case 0:
							break;
						case 5:
							obj = DxSpotBlockCacheCfg.Ⴄ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, 'ć', 'ź'), 0, 'Ϭ', 952), sql, SetStationQth.Ⴍ(null, 1687351822, 8, 16), 'ϖ', 'Α');
							goto end_IL_004e;
						}
						num = ⴃႰ[196] - 54873;
						continue;
						end_IL_004e:
						break;
					}
				}
				finally
				{
					int num2 = 2;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = ((!flag) ? (ⴀႨ[176] - 915) : (ⴀႨ[203] - 48783));
							goto IL_0148;
						case 0:
						case 1:
							DxCmdMsgExt.ႨႠ(obj2, 'ϭ', 904);
							break;
						case 3:
						case 5:
							break;
						}
						break;
						IL_0148:
						num2 = num3;
					}
				}
				int num4 = 11;
				object obj4 = default(object);
				Array array = default(Array);
				int num6 = default(int);
				IEnumerable enumerable = default(IEnumerable);
				ISupportInitializeNotification supportInitializeNotification2 = default(ISupportInitializeNotification);
				ICloneable cloneable = default(ICloneable);
				while (true)
				{
					switch (num4)
					{
					default:
						num4 = (((obj as DataRow[]).Length < nmbrDesired) ? 15 : 3);
						continue;
					case 3:
						obj4 = ShowSkimmerHelp.Ⴈ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, 'ģ', 'Ş'), 0, 'Ⱦ', 618), '\u030c', 870);
						num4 = 18;
						continue;
					case 18:
						array = (DataRow[])obj;
						num6 = 0;
						num4 = ⴄႷ[33] - 18070;
						continue;
					case 5:
					case 7:
					{
						object obj3 = ((DataRow[])array)[num6];
						SetAnnModeHelp.Ⴍ((DataTable)obj4, obj3 as DataRow, 'Ź', 304);
						num4 = 16;
						continue;
					}
					case 16:
						num6++;
						num4 = 0;
						continue;
					case 0:
					case 12:
						num4 = ((num6 < (array as DataRow[]).Length) ? 7 : (ⴀ[432] - 58359));
						continue;
					case 6:
						supportInitializeNotification = (DataTable)obj4;
						break;
					case 15:
						SaveToDb();
						enumerable = ShowPrefixCalls.Ⴃ((object)ReplyMailHelp.Ⴄ(30, null, 1057161780, 8), (object)nmbrDesired, (object)ShowWxHelp.Ⴍ('\u0093', 985806852, 7), 'z', 80);
						num4 = 8;
						continue;
					case 8:
						num4 = ((CallBlockCacheCfg.Ⴜ(sql, 37, 68) <= 0) ? 2 : (ⴃႠ[299] - 20911));
						continue;
					case 17:
					{
						enumerable = AnnHelp.Ⴈ((string)enumerable, ႰႥ.Ⴅ(6, '\u0005', 952620689), LogEntry.Ⴄ(sql, '\u00af', 133), 225, 'Ö');
						char num5 = ⴀႣ[332];
						TxNodeUserCmd.ႤႷ[93] = (char)((TxNodeUserCmd.ႤႷ[93] ^ nmbrDesired) & 0xEF);
						num4 = num5 - 29267;
						continue;
					}
					case 2:
						enumerable = ShowUsersHelp.Ⴅ(enumerable as string, ႰႥ.Ⴅ(3, '½', 952622467), 770, 844);
						num4 = ⴃႠ[418] - 6302;
						continue;
					case 10:
						enumerable = (enumerable as string).Replace(ShowSkimCtyHelp.Ⴍ(1216131097, 6, 'O'), SetStationClubHelp.Ⴍ(9, 2, 1747255879, null));
						num4 = ⴀႨ[94] - 43542;
						continue;
					case 13:
						supportInitializeNotification2 = new DataSet();
						cloneable = new SqlCeDataAdapter(enumerable as string, this.m_Ⴍ.Configuration.DbConnect);
						num4 = 4;
						continue;
					case 4:
						((SqlCeDataAdapter)cloneable).Fill(supportInitializeNotification2 as DataSet, SetStationClubHelp.Ⴍ(7, 3, 1747257821, null));
						num4 = 14;
						continue;
					case 1:
					case 14:
						supportInitializeNotification = ((DataSet)supportInitializeNotification2).Tables[0];
						break;
					}
					break;
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			DxCache.m_Ⴄ.Warn(ex.Message + ႰႥ.Ⴅ(6, 'l', 952620212) + sql);
			supportInitializeNotification = null;
		}
		return 3 switch
		{
			_ => (DataTable)supportInitializeNotification, 
		};
	}

	internal bool Ⴅ(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		object obj = default(object);
		bool flag2 = default(bool);
		while (true)
		{
			int num = ((!ByeHelp.Ⴍ(P_0, string.Empty, 564, 595)) ? 2 : (ⴃႥ[200] - 30019));
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
				case 4:
					return true;
				case 0:
				case 2:
					P_0 = AnnHelp.Ⴈ(ShowSkimCtyHelp.Ⴍ(1216131118, 8, 'w'), P_0, ReplyMailHelp.Ⴄ(12, null, 1057162122, 0), 9, '>');
					num = 7;
					continue;
				case 7:
				{
					bool flag = false;
					try
					{
						switch (1)
						{
						default:
							ႨႥ.Ⴍ(obj = IoClientDevicesCfg.Ⴐ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, 'Ɗ', 'Ƿ'), 0, 'χ', 915), '\t', 9), 'ɘ', (short)587), ref flag, 810, 803);
							try
							{
								switch (0)
								{
								default:
									DataSet.Tables[0].Select(P_0);
									break;
								case 4:
									break;
								case 1:
									goto end_IL_010a;
								}
								flag2 = true;
								end_IL_010a:;
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
						int num2 = 5;
						while (true)
						{
							int num3;
							switch (num2)
							{
							default:
								num3 = (flag ? 1 : 4);
								goto IL_0173;
							case 0:
							case 1:
								Monitor.Exit(obj);
								break;
							case 4:
								break;
							}
							break;
							IL_0173:
							num2 = num3;
						}
					}
					return 0 switch
					{
						_ => flag2, 
					};
				}
				}
				break;
			}
		}
	}

	public string FormatSqlFilter(string sql)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		object obj = string.Empty;
		try
		{
			obj = ႰႠ.Ⴗ(sql, SqlFilterType.Dx, 278, 375);
			obj = SkimmerSpot.Ⴈ(obj as string, 5, '\u0013');
		}
		catch (Exception ex)
		{
			DxCache.m_Ⴄ.Error((ex as Exception).Message);
		}
		return obj as string;
	}

	public void Maintenance()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				return;
			}
			if (DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, 'ƍ', 'ǰ'), 0, 'Ɉ', 540), 'ë', 235), (short)746, (short)695) == 0)
			{
				num = ⴅ[438] - ⴅ[177];
				continue;
			}
			while (true)
			{
				SaveToDb();
				object obj = new PrecisionTimer();
				ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 112, 49);
				int num2 = 5;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 1:
						return;
					case 3:
						break;
					case 5:
					case 6:
						Ⴗ();
						SkimerDupeMaint();
						goto IL_00d3;
					case 4:
						goto IL_00d3;
					case 2:
						DxCache.m_Ⴄ.Info((PrecisionTimer)obj);
						return;
					}
					break;
					IL_00d3:
					FastFilterMaint();
					DupeCacheMaint();
					(obj as PrecisionTimer).Stop();
					num2 = 2;
				}
			}
		}
	}

	internal void Ⴗ()
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		try
		{
			switch (2)
			{
			default:
			{
				bool flag = false;
				object obj2 = default(object);
				try
				{
					int num = 8;
					IEnumerable<char> enumerable = default(IEnumerable<char>);
					object obj3 = default(object);
					object obj = default(object);
					int num2 = default(int);
					object obj4 = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							ႨႥ.Ⴍ(obj2 = IoClientDevicesCfg.Ⴐ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, 'ˀ', 'ʽ'), 0, '\u0003', 87), 'ɖ', 598), 'ō', (short)350), ref flag, 184, 177);
							num = 6;
							continue;
						case 6:
						{
							string text = SetStationClubHelp.Ⴍ(12, 1, 1747255923, null);
							DateTime dateTime = ShowAnnHelp.Ⴅ('ɂ', 627);
							enumerable = ShowPrefixCalls.Ⴃ((object)text, (object)ReadMailHelp.Ⴍ(ref dateTime, -this.m_Ⴍ.Caches.Dx.CacheMinutes, 168, 168), (object)ႰႥ.Ⴅ(1, 'é', 952620227), 'Ʉ', 622);
							num = ⴃႥ[109] - 17162;
							continue;
						}
						case 0:
							obj3 = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, 'ˉ', 'ʴ'), 0, 'Τ', 1008), enumerable as string, 'i', 84);
							num = 2;
							continue;
						case 2:
							obj = (DataRow[])obj3;
							num2 = 0;
							goto case 10;
						case 10:
							num = 1;
							continue;
						case 4:
						case 9:
							obj4 = ((DataRow[])obj)[num2];
							goto case 3;
						case 3:
							DataSet.Tables[0].Rows.Remove((DataRow)obj4);
							num = ⴀ[256] - 7746;
							continue;
						case 7:
							num2++;
							num = 1;
							continue;
						case 1:
							num = ((num2 < (obj as DataRow[]).Length) ? 4 : ⴀႼ[136]);
							continue;
						case 5:
							break;
						}
						break;
					}
				}
				finally
				{
					int num3 = 0;
					while (true)
					{
						int num4;
						switch (num3)
						{
						default:
							num4 = ((!flag) ? 5 : (ⴐ[98] - 233));
							goto IL_0240;
						case 1:
						case 2:
						case 4:
							Monitor.Exit(obj2);
							break;
						case 5:
							break;
						}
						break;
						IL_0240:
						num3 = num4;
					}
				}
				switch (4)
				{
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			DxCache.m_Ⴄ.Error((ex as Exception).Message);
		}
		switch (1)
		{
		}
	}

	public void SkimerDupeMaint()
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 2;
		int num3 = default(int);
		DateTime dateTime = default(DateTime);
		KeyValuePair<string, SkimDupeDat> current = default(KeyValuePair<string, SkimDupeDat>);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				goto case 1;
			case 1:
			{
				DateTime dateTime2 = ShowAnnHelp.Ⴅ('ǒ', 483);
				dateTime = ReadMailHelp.Ⴍ(ref dateTime2, -11.0, 564, 564);
				break;
			}
			case 0:
			case 4:
				break;
			case 3:
			{
				object enumerator = _skimDupeCache.GetEnumerator();
				try
				{
					int num2 = 6;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = 4;
							continue;
						case 0:
							current = ((IEnumerator<KeyValuePair<string, SkimDupeDat>>)enumerator).Current;
							goto case 5;
						case 5:
							num2 = ((!SetStationLoginCmdsHelp.Ⴀ(current.Value.Ⴍ(), dateTime, '\u02ef', 'ˎ')) ? 4 : (ⴄႷ[70] - 5436));
							continue;
						case 3:
						{
							num3++;
							_skimDupeCache.TryRemove(current.Key, out var _);
							num2 = ⴐ[367];
							continue;
						}
						case 1:
						case 4:
							num2 = ((!((IEnumerator<KeyValuePair<string, SkimDupeDat>>)enumerator).MoveNext()) ? ⴅ[210] : 0);
							continue;
						case 8:
							break;
						}
						break;
					}
				}
				finally
				{
					int num4 = 0;
					while (true)
					{
						int num5;
						switch (num4)
						{
						default:
							num5 = (((IEnumerator<KeyValuePair<string, SkimDupeDat>>)enumerator == null) ? (ⴍႤ[226] - 61474) : (ⴀႣ[274] - 22514));
							goto IL_0176;
						case 6:
							(enumerator as IEnumerator<KeyValuePair<string, SkimDupeDat>>).Dispose();
							break;
						case 2:
						case 4:
							break;
						}
						break;
						IL_0176:
						num4 = num5;
					}
				}
				switch (1)
				{
				}
				return;
			}
			}
			num = 3;
		}
	}

	public void FastFilterMaint()
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 2;
		IEnumerable enumerable = default(IEnumerable);
		object obj2 = default(object);
		Array array = default(Array);
		object obj = default(object);
		int num3 = default(int);
		object obj3 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				string text = ShowSkimCtyHelp.Ⴍ(1216131134, 7, '\u0092');
				DateTime dateTime = ShowAnnHelp.Ⴅ('¬', 157);
				enumerable = ShowPrefixCalls.Ⴃ((object)text, (object)ReadMailHelp.Ⴍ(ref dateTime, -1.0, 1, 1), (object)ႰႥ.Ⴅ(0, 'd', 952620226), 'g', 77);
				break;
			}
			case 1:
				break;
			case 3:
			{
				bool flag = false;
				try
				{
					int num2 = 8;
					while (true)
					{
						switch (num2)
						{
						default:
							ႨႥ.Ⴍ(obj2 = IoClientDevicesCfg.Ⴐ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.m_Ⴍ, ' ', ']'), 0, 'Ͷ', 802), 'ʺ', 698), 'Ȅ', (short)535), ref flag, 872, 865);
							num2 = 10;
							continue;
						case 10:
							array = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.m_Ⴍ, '\f', 'q'), 0, 'ʝ', 713), (string)enumerable, '\u0306', 827);
							num2 = ⴍႤ[143] - 46819;
							continue;
						case 7:
							obj = (DataRow[])array;
							num3 = 0;
							goto case 2;
						case 2:
							num2 = 4;
							continue;
						case 0:
							obj3 = ((DataRow[])obj)[num3];
							goto case 1;
						case 1:
							this.m_Ⴍ.Tables[0].Rows.Remove(obj3 as DataRow);
							num2 = 9;
							continue;
						case 9:
							num3++;
							num2 = 4;
							continue;
						case 4:
							num2 = ((num3 >= ((DataRow[])obj).Length) ? (ⴄႤ[376] - 66) : 0);
							continue;
						case 5:
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
							num5 = ((!flag) ? 4 : 5);
							goto IL_0200;
						case 0:
						case 1:
						case 5:
						case 6:
							Monitor.Exit(obj2);
							break;
						case 4:
							break;
						}
						break;
						IL_0200:
						num4 = num5;
					}
				}
				switch (1)
				{
				}
				return;
			}
			}
			num = 3;
		}
	}

	public void DupeCacheMaint()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 3;
		int num3 = default(int);
		DateTime dateTime = default(DateTime);
		KeyValuePair<string, DateTime> current = default(KeyValuePair<string, DateTime>);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				goto case 1;
			case 1:
			{
				DateTime dateTime2 = ShowAnnHelp.Ⴅ('ƃ', 434);
				dateTime = ReadMailHelp.Ⴍ(ref dateTime2, -this.m_Ⴍ.Caches.Dx.CacheMinutes, 237, 237);
				break;
			}
			case 0:
			case 2:
				break;
			case 4:
			{
				object enumerator = _dupeCache.GetEnumerator();
				try
				{
					int num2 = 6;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = ⴃႥ[349] - 62670;
							continue;
						case 0:
						{
							current = ((IEnumerator<KeyValuePair<string, DateTime>>)enumerator).Current;
							DateTime value = current.Value;
							num2 = ((!SetStationLoginCmdsHelp.Ⴀ(value, dateTime, 'ɱ', 'ɐ')) ? 2 : 4);
							continue;
						}
						case 3:
						case 4:
						case 5:
						{
							num3++;
							_dupeCache.TryRemove(current.Key, out var _);
							num2 = 2;
							continue;
						}
						case 2:
							num2 = ((!((IEnumerator<KeyValuePair<string, DateTime>>)enumerator).MoveNext()) ? 1 : 0);
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				finally
				{
					int num4 = 5;
					while (true)
					{
						int num5;
						switch (num4)
						{
						default:
							num5 = ((!(enumerator is IEnumerator<KeyValuePair<string, DateTime>>)) ? 4 : 3);
							goto IL_014d;
						case 3:
							(enumerator as IEnumerator<KeyValuePair<string, DateTime>>).Dispose();
							break;
						case 0:
						case 1:
						case 4:
							break;
						}
						break;
						IL_014d:
						num4 = num5;
					}
				}
				switch (0)
				{
				}
				return;
			}
			}
			num = 4;
		}
	}
}
