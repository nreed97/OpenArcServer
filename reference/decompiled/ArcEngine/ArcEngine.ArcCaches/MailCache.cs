using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading;
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
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class MailCache
{
	private static readonly ILog m_Ⴅ;

	private static readonly object Ⴍ;

	private CallbookCfg.Ⴀ Ⴄ = new CallbookCfg.Ⴀ();

	[SpecialName]
	internal DataSet Ⴀ()
	{
		return Ⴄ.Ⴐ;
	}

	[SpecialName]
	private void Ⴐ(DataSet P_0)
	{
		Ⴄ.Ⴐ = P_0 as DataSet;
		SetTalkCountHelp.Ⴅ[98] = (byte)((SetTalkCountHelp.Ⴅ[98] - SetTalkCountHelp.Ⴅ[84]) & 0x9C);
	}

	public MailCache()
	{
		Ⴐ(Ⴅ());
	}

	private DataSet Ⴅ()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		while (true)
		{
			MarshalByValueComponent marshalByValueComponent = new DataSet();
			ByeHelp.Ⴈ(DirectoryHelp.Ⴀ(marshalByValueComponent as DataSet, 'r', '\u000f'), new DataTable(ႨႨ.Ⴀ(0, 4, 1157903558)), 298, 333);
			int num = ⴄႤ[383] - 224;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 17;
					continue;
				case 17:
					break;
				case 10:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)marshalByValueComponent, 'ò', '\u008f'), 0, '\u02f5', 673), 993, 962), new DataColumn(SetStationQth.Ⴍ(null, 1687351403, 7, 24), typeof(long)), 25, '\u0019');
					num = ⴄႤ[330] - 251;
					continue;
				case 2:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)marshalByValueComponent, 'ǐ', 'ƭ'), 0, 'ʬ', 760), 360, 331), new DataColumn(SetStationClubHelp.Ⴍ(11, 5, 1747258015, null), typeof(string)), 783, '\u030f');
					num = ⴀႳ[73] - 16657;
					continue;
				case 0:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)marshalByValueComponent, '±', 'Ì'), 0, '\u0330', 868), 342, 373), new DataColumn(ReplyMail.Ⴅ(7, 14, 1217944719), typeof(string)), 361, 'ũ');
					num = ⴃႰ[27] - 9159;
					continue;
				case 16:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)marshalByValueComponent, '\u033e', '\u0343'), 0, ')', 125), 753, 722), new DataColumn(CallBlockCacheCfg.Ⴅ(null, 2, 62057558, null), typeof(string)), 326, 'ņ');
					num = ⴄႤ[44] - 228;
					continue;
				case 6:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(marshalByValueComponent as DataSet, '\u009d', 'à'), 0, 's', 39), 989, 1022), new DataColumn(ႰႥ.Ⴅ(6, '\u0018', 952620224), typeof(string)), 883, 'ͳ');
					num = ⴃႰ[191] - 1766;
					continue;
				case 13:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(marshalByValueComponent as DataSet, 'ź', 'ć'), 0, 'ǿ', 427), 222, 253), new DataColumn(ReplyMailHelp.Ⴄ(25, null, 1057162192, 7), typeof(bool)), 967, 'χ');
					num = 1;
					continue;
				case 1:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(marshalByValueComponent as DataSet, '\u0327', '\u035a'), 0, 'Ǡ', 436), 313, 282), new DataColumn(ShowSkimCtyHelp.Ⴍ(1216133495, 7, '\u00ad'), typeof(bool)), 817, '\u0331');
					num = ⴃႠ[138] - 20525;
					continue;
				case 18:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(marshalByValueComponent as DataSet, '\u0328', '\u0355'), 0, 'Λ', 975), 248, 219), new DataColumn(SetTalkCount.Ⴗ(3, null, 1267022402, typeof(CtyCache)), typeof(bool)), 975, 'Ϗ');
					num = ⴀ[442] - 37338;
					continue;
				case 14:
					((DataSet)marshalByValueComponent).Tables[0].Columns.Add(new DataColumn(ShowWxHelp.Ⴍ('C', 985808770, 5), typeof(string)));
					goto case 3;
				case 3:
					num = 8;
					continue;
				case 8:
					(marshalByValueComponent as DataSet).Tables[0].Columns.Add(new DataColumn(ႨႨ.Ⴀ(1, 0, 1157903571), typeof(string)));
					num = ⴃႠ[271] - 23571;
					continue;
				case 12:
				{
					((DataSet)marshalByValueComponent).Tables[0].Columns.Add(new DataColumn(SetStationQth.Ⴍ(null, 1687351299, 4, 11), typeof(long)));
					char num2 = ⴀ[7];
					AnnCacheCfg.ႠႼ[9] = (byte)((AnnCacheCfg.ႠႼ[9] * ShowWwvOptionsHelp.ႣႥ[147]) & 0xED);
					num = num2 - 13468;
					continue;
				}
				case 19:
					((DataSet)marshalByValueComponent).Tables[0].Columns.Add(new DataColumn(SetStationClubHelp.Ⴍ(15, 5, 1747258032, null), typeof(byte)));
					goto case 4;
				case 4:
					num = ⴀႨ[146] - 22238;
					continue;
				case 9:
					(marshalByValueComponent as DataSet).Tables[0].Columns.Add(new DataColumn(ReplyMail.Ⴅ(0, 12, 1217944711), typeof(string)));
					goto case 5;
				case 5:
					num = 11;
					continue;
				case 11:
					((DataSet)marshalByValueComponent).Tables[0].Columns.Add(new DataColumn(CallBlockCacheCfg.Ⴅ(null, 5, 62057567, null), typeof(string)));
					num = ⴃႠ[54] - 44882;
					continue;
				case 7:
					(marshalByValueComponent as DataSet).Tables[0].Columns.Add(new DataColumn(ႰႥ.Ⴅ(3, 'u', 952620238), typeof(DateTime)));
					num = 20;
					continue;
				case 20:
					return (DataSet)marshalByValueComponent;
				}
				break;
			}
		}
	}

	public void AddLetter(Letter letter)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		Ⴃ(letter);
		try
		{
			switch (0)
			{
			default:
			{
				bool flag = false;
				object ⴍ = default(object);
				try
				{
					int num = 15;
					object obj = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							ႨႥ.Ⴍ(ⴍ = Ⴍ, ref flag, 704, 713);
							obj = NodeUserCmd.Ⴓ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴀ(), 'Ū', 'ė'), 0, 'u', 33), '¿', 'Ô');
							num = 20;
							continue;
						case 20:
							ArcConnectObj.Ⴓ((DataRow)obj, SetStationQth.Ⴍ(null, 1687351402, 6, 12), (object)ShowGraylineHelp.Ⴀ(letter, 215, 'â'), 'Ρ', 'β');
							num = ⴃႰ[17] - 56146;
							continue;
						case 4:
							ArcConnectObj.Ⴓ(obj as DataRow, SetStationClubHelp.Ⴍ(3, 8, 1747258002, null), (object)ႨႳ.Ⴐ(letter, 370, 256), '5', '&');
							num = ⴍႤ[206] - 40698;
							continue;
						case 1:
							ArcConnectObj.Ⴓ((DataRow)obj, ReplyMail.Ⴅ(3, 5, 1217944715), (object)SetStationClubHelp.Ⴗ(letter, 404, 478), 'ˠ', '\u02f3');
							num = 19;
							continue;
						case 19:
							ArcConnectObj.Ⴓ(obj as DataRow, CallBlockCacheCfg.Ⴅ(null, 3, 62057559, null), (object)WxFullHelp.Ⴓ(letter, 789, 799), '\u030f', '\u031c');
							goto case 3;
						case 3:
							num = 5;
							continue;
						case 5:
							ArcConnectObj.Ⴓ((DataRow)obj, ႰႥ.Ⴅ(8, 'c', 952620238), (object)SetStationPhoneHelp.Ⴈ(letter, 145, 'Æ'), 'ư', 'ƣ');
							num = ⴍႭ[26] - 7649;
							continue;
						case 2:
							ArcConnectObj.Ⴓ((DataRow)obj, ReplyMailHelp.Ⴄ(29, null, 1057162198, 1), (object)ShowHeadingHelp.Ⴍ(letter, 'Í', 178), 'ī', 'ĸ');
							num = 18;
							continue;
						case 18:
							ArcConnectObj.Ⴓ((DataRow)obj, ShowSkimCtyHelp.Ⴍ(1216133494, 6, 'p'), (object)ShowHeadingHelp.Ⴍ(letter, 'Ƅ', 260), 'ʗ', 'ʄ');
							num = 11;
							continue;
						case 11:
							ArcConnectObj.Ⴓ(obj as DataRow, SetTalkCount.Ⴗ(1, null, 1267022400, typeof(ShowWx)), (object)SetStationName.Ⴃ(letter, 659, 701), '\u02dc', 'ˏ');
							num = 13;
							continue;
						case 13:
							ArcConnectObj.Ⴓ((DataRow)obj, ShowWxHelp.Ⴍ('÷', 985808774, 1), (object)SetStationGrid.Ⴍ(WxFullHelp.Ⴓ(letter, 118, 125), 376, 'Ī'), 'Ȋ', 'ș');
							goto case 8;
						case 8:
							num = ⴀႨ[42] - 24442;
							continue;
						case 12:
							ArcConnectObj.Ⴓ(obj as DataRow, ႨႨ.Ⴀ(4, 1, 1157903570), (object)SetStationGrid.Ⴍ(ByeHelp.Ⴃ(letter, 389, 'Ƨ'), 934, 'ϴ'), 'Ė', 'ą');
							num = 0;
							continue;
						case 0:
							((DataRow)obj)[SetStationQth.Ⴍ(null, 1687351303, 0, 22)] = letter.Size;
							num = 14;
							continue;
						case 10:
						case 14:
							(obj as DataRow)[SetStationClubHelp.Ⴍ(1, 0, 1747258037, null)] = letter.Attempts;
							num = 6;
							continue;
						case 6:
							((DataRow)obj)[ReplyMail.Ⴅ(2, 0, 1217944709)] = letter.Status;
							num = 7;
							continue;
						case 7:
							((DataRow)obj)[CallBlockCacheCfg.Ⴅ(null, 2, 62057560, null)] = letter.ToHomeNode;
							num = 9;
							continue;
						case 9:
							(obj as DataRow)[ႰႥ.Ⴅ(2, '\u001d', 952620239)] = letter.Dts;
							num = ⴃႠ[275] - 31793;
							continue;
						case 16:
							Ⴀ().Tables[0].Rows.Add((DataRow)obj);
							break;
						}
						break;
					}
				}
				finally
				{
					int num2 = 0;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = ((!flag) ? 1 : ⴄႤ[135]);
							goto IL_04d5;
						case 5:
						case 6:
							Monitor.Exit(ⴍ);
							break;
						case 1:
							break;
						}
						break;
						IL_04d5:
						num2 = num3;
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
			MailCache.m_Ⴅ.Error(ShowSkimCtyHelp.Ⴍ(1216133376, 5, 'Þ') + (ex as Exception).Message);
		}
		switch (2)
		{
		}
	}

	private void Ⴃ(Letter P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				ShowWxHelp.Ⴄ(P_0, ShowAnnHelp.Ⴅ('Ǥ', 469), 60, 8);
				goto case 4;
			case 4:
				num = ((!ByeHelp.Ⴍ(ႨႳ.Ⴐ(P_0, 972, 958), ReplyMail.Ⴅ(3, 10, 1217944757), 541, 634)) ? (ⴃႥ[353] - 21462) : (ⴍႤ[260] - 30735));
				break;
			case 6:
				SetWxCount.Ⴐ(P_0, CallBlockCacheCfg.Ⴅ(null, 4, 62057598, null), 563, 'ɷ');
				num = 3;
				break;
			case 1:
				SetWxCount.Ⴐ(P_0, ႰႥ.Ⴅ(7, 'ù', 952620254), 320, 'Ą');
				goto case 3;
			case 3:
			case 5:
				P_0.Size = P_0.Body.Length;
				P_0.FromNode = ShowSkimCtyHelp.Ⴍ(1216133401, 6, 'ô');
				goto case 2;
			case 2:
				num = 7;
				break;
			case 7:
				P_0.MsgNum = Ⴈ();
				SetAnnMode.ႤႭ[100] = (byte)((SetAnnMode.ႤႭ[100] * SetAnnMode.ႤႭ[269]) & 0xA3);
				return;
			}
		}
	}

	private int Ⴈ()
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		bool flag = false;
		object ⴍ = default(object);
		Array array = default(Array);
		try
		{
			switch (4)
			{
			default:
				ႨႥ.Ⴍ(ⴍ = Ⴍ, ref flag, 719, 710);
				array = DxSpotBlockCacheCfg.Ⴄ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴀ(), 'Δ', 'ϩ'), 0, 'ɐ', 516), string.Empty, SetTalkCount.Ⴗ(5, null, 1267022382, typeof(ShowCluster.ႨႨ)), 'ȃ', 'Ʉ');
				break;
			case 2:
				break;
			}
		}
		finally
		{
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!flag) ? 3 : 2);
					goto IL_00e3;
				case 2:
					DxCmdMsgExt.ႨႠ(ⴍ, '\u035d', 824);
					break;
				case 0:
				case 1:
				case 3:
					break;
				}
				break;
				IL_00e3:
				num = num2;
			}
		}
		int num3 = 5;
		int result = default(int);
		while (true)
		{
			switch (num3)
			{
			default:
				num3 = (((array as DataRow[]).Length <= 0) ? (ⴃႠ[53] - 46731) : 3);
				break;
			case 3:
				result = 1 + Convert.ToInt32((array as DataRow[])[0][SetStationQth.Ⴍ(null, 1687351406, 2, 1)].ToString());
				goto case 6;
			case 6:
				num3 = 7;
				break;
			case 2:
			case 7:
				return result;
			case 1:
				return 1;
			}
		}
	}

	public bool DeleteLetter(string msgNum)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool flag = false;
		object ⴍ = default(object);
		bool flag2;
		try
		{
			int num = 0;
			Array array = default(Array);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴍ = Ⴍ, ref flag, 57, 48);
					array = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴀ(), 'ì', '\u0091'), 0, '\u02e8', 700), ShowUsersHelp.Ⴅ(SetStationClubHelp.Ⴍ(2, 5, 1747258066, null), msgNum, 5, 75), 'Ʃ', 404);
					goto case 6;
				case 6:
					num = 8;
					continue;
				case 8:
					num = (((array as DataRow[]).Length <= 0) ? (ⴃႥ[270] - 59305) : 4);
					continue;
				case 4:
				case 7:
					ArcConnectObj.Ⴓ(((DataRow[])array)[0], ReplyMail.Ⴅ(0, 1, 1217944711), (object)SetWxCountHelp.Ⴗ((object)SetTalkCount.Ⴗ(3, null, 1267022362, typeof(SetWxCount)), qslinfoSoapClient.Ⴓ((array as DataRow[])[0], ReplyMail.Ⴅ(1, 12, 1217944710), 384, 'ǎ'), 753, (short)650), 'Ƽ', 'Ư');
					num = 2;
					continue;
				case 2:
					flag2 = true;
					break;
				case 3:
					MailCache.m_Ⴅ.Error(CallBlockCacheCfg.Ⴅ(null, 7, 62057576, null));
					flag2 = false;
					break;
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
					num3 = ((!flag) ? (ⴍႤ[235] - 47096) : (ⴍႭ[73] - 34184));
					goto IL_01bc;
				case 1:
					Monitor.Exit(ⴍ);
					break;
				case 3:
				case 5:
					break;
				}
				break;
				IL_01bc:
				num2 = num3;
			}
		}
		return 2 switch
		{
			_ => flag2, 
		};
	}

	public void UpdateLetterRead(string letterId)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		bool flag = false;
		object ⴍ = default(object);
		try
		{
			int num = 5;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴍ = Ⴍ, ref flag, 914, 923);
					obj = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴀ(), 'ɚ', 'ȧ'), 0, 'W', 3), AnnHelp.Ⴈ(SetStationQth.Ⴍ(null, 1687351352, 0, 18), letterId, ႨႨ.Ⴀ(5, 2, 1157903559), 540, 'ȫ'), 'ʦ', 667);
					num = ⴄႤ[184] - ⴄႤ[6];
					continue;
				case 7:
					num = (((obj as DataRow[]).Length <= 0) ? 8 : 6);
					continue;
				case 6:
					ArcConnectObj.Ⴓ(((DataRow[])obj)[0], ReplyMailHelp.Ⴄ(22, null, 1057162193, 6), (object)true, 'Ʀ', 'Ƶ');
					num = 0;
					continue;
				case 8:
					MailCache.m_Ⴅ.Error(ShowSkimCtyHelp.Ⴍ(1216133413, 2, '\u009d'));
					break;
				case 0:
				case 1:
					break;
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
					num3 = ((!flag) ? 6 : (ⴀႳ[227] - 26070));
					goto IL_015e;
				case 3:
					Monitor.Exit(ⴍ);
					break;
				case 6:
					break;
				}
				break;
				IL_015e:
				num2 = num3;
			}
		}
		switch (3)
		{
		}
	}

	public void UpdateLetterAttempts(int letterId, int attempts)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		bool flag = false;
		object ⴍ = default(object);
		try
		{
			int num = 2;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴍ = Ⴍ, ref flag, 439, 446);
					obj = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴀ(), 'ϋ', 'ζ'), 0, '\u0011', 69), ShowPrefixCalls.Ⴃ((object)SetStationQth.Ⴍ(null, 1687351353, 1, 3), (object)letterId, (object)ႨႨ.Ⴀ(attempts, 0, 1157903557), '\u008e', 164), '±', 140);
					goto case 5;
				case 5:
					num = ⴀႳ[24] - 25563;
					continue;
				case 8:
					num = (((obj as DataRow[]).Length <= 0) ? (ⴀ[283] - 56623) : 4);
					continue;
				case 4:
					ArcConnectObj.Ⴓ(((DataRow[])obj)[0], SetStationClubHelp.Ⴍ(13, 3, 1747258038, null), (object)attempts, 'å', 'ö');
					goto case 6;
				case 6:
				case 7:
					num = 0;
					continue;
				case 3:
					MailCache.m_Ⴅ.Error(ShowSkimCtyHelp.Ⴍ(1216133413, 2, '0'));
					break;
				case 0:
					break;
				}
				break;
			}
		}
		finally
		{
			int num2 = 6;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 5 : 0);
					goto IL_015e;
				case 0:
					Monitor.Exit(ⴍ);
					break;
				case 1:
				case 3:
				case 5:
					break;
				}
				break;
				IL_015e:
				num2 = num3;
			}
		}
		switch (1)
		{
		}
	}

	internal DataRow[] Ⴀ(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool flag = false;
		object ⴍ = default(object);
		object obj;
		try
		{
			ႨႥ.Ⴍ(ⴍ = Ⴍ, ref flag, 440, 433);
			obj = DxSpotBlockCacheCfg.Ⴄ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴀ(), 'Æ', '»'), 0, 'á', 181), P_0, ႰႥ.Ⴅ(5, '1', 952620261), '\u034f', '\u0308');
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
					num2 = (flag ? 5 : 0);
					goto IL_00c1;
				case 5:
					Monitor.Exit(ⴍ);
					break;
				case 0:
				case 4:
					break;
				}
				break;
				IL_00c1:
				num = num2;
			}
		}
		return obj as DataRow[];
	}

	public void SaveToDb()
	{
		bool flag = false;
		object ⴍ = default(object);
		try
		{
			ႨႥ.Ⴍ(ⴍ = Ⴍ, ref flag, 347, 338);
		}
		finally
		{
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = (flag ? 1 : 5);
					goto IL_0042;
				case 0:
				case 1:
				case 4:
					Monitor.Exit(ⴍ);
					break;
				case 5:
					break;
				}
				break;
				IL_0042:
				num = num2;
			}
		}
	}

	static MailCache()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 4:
				Ⴍ = new object();
				return;
			}
			MailCache.m_Ⴅ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('=', 985808880, 1), 694, 683);
			num = 4;
		}
	}
}
