using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Runtime.CompilerServices;
using System.Threading;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Dx;
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
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class WxCache
{
	private static readonly ILog Ⴅ;

	private static readonly object Ⴗ;

	private static readonly object m_Ⴍ;

	private readonly DataSet m_Ⴃ;

	private readonly ArcServerCfg Ⴗ;

	private DataSet Ⴅ;

	[SpecialName]
	internal DataSet Ⴍ()
	{
		return Ⴅ;
	}

	[SpecialName]
	private void Ⴍ(DataSet P_0)
	{
		Ⴅ = P_0;
	}

	public WxCache(ArcServerCfg arcServerCfg)
	{
		Ⴗ = arcServerCfg;
		Ⴍ(Ⴀ());
		this.m_Ⴃ = Ⴀ();
		WxCache.Ⴅ.Info(ShowSkimCtyHelp.Ⴍ(1216129654, 1, 'E'));
	}

	public void Maintenance()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 3;
		object ⴗ = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
			case 4:
				return;
			}
			if (DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴍ(), 'Œ', 'į'), 0, 'ʱ', 741), 'ɦ', 614), (short)466, (short)399) == 0)
			{
				num = 1;
				continue;
			}
			SaveToDb();
			bool flag = false;
			try
			{
				int num2 = 2;
				while (true)
				{
					switch (num2)
					{
					default:
						ႨႥ.Ⴍ(ⴗ = WxCache.Ⴗ, ref flag, 197, 204);
						goto IL_00d7;
					case 3:
						goto IL_00d7;
					case 5:
						((PrecisionTimer)obj).Start();
						goto case 1;
					case 1:
						Ⴃ();
						break;
					case 0:
						break;
					}
					break;
					IL_00d7:
					obj = new PrecisionTimer();
					num2 = 5;
				}
				(obj as PrecisionTimer).Stop();
				WxCache.Ⴅ.Info(obj as PrecisionTimer);
			}
			finally
			{
				int num3 = 3;
				while (true)
				{
					int num4;
					switch (num3)
					{
					default:
						num4 = ((!flag) ? (ⴀႼ[122] - 47) : 6);
						goto IL_013a;
					case 6:
						Monitor.Exit(ⴗ);
						break;
					case 0:
					case 1:
					case 2:
						break;
					}
					break;
					IL_013a:
					num3 = num4;
				}
			}
			switch (0)
			{
			}
			return;
		}
	}

	internal void Ⴃ()
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		try
		{
			int num = 3;
			object obj3 = default(object);
			object obj2 = default(object);
			object obj = default(object);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
				{
					string text = SetStationClubHelp.Ⴍ(4, 3, 1747255921, null);
					DateTime dateTime = ShowAnnHelp.Ⴅ('ʱ', 640);
					obj3 = ShowPrefixCalls.Ⴃ((object)text, (object)ReadMailHelp.Ⴍ(ref dateTime, -Ⴗ.Caches.Wx.CacheMinutes, 474, 474), (object)ႰႥ.Ⴅ(5, 'ã', 952620231), 'ǘ', 498);
					num = 6;
					continue;
				}
				case 6:
					obj2 = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴍ(), '\u009e', 'ã'), 0, 'ř', 269), obj3 as string, '\u0344', 889);
					num = ⴄႭ[25] - 133;
					continue;
				case 1:
					obj = obj2 as DataRow[];
					num2 = 0;
					goto case 2;
				case 2:
					num = 7;
					continue;
				case 8:
				{
					object obj4 = ((DataRow[])obj)[num2];
					DirectoryHelp.Ⴀ(Ⴍ(), '\u032c', '\u0351')[0].Rows.Remove((DataRow)obj4);
					num = ⴍႤ[447] - 10157;
					continue;
				}
				case 9:
				case 10:
					num2++;
					num = ⴍႭ[95] - 30657;
					continue;
				case 7:
					num = ((num2 < ((DataRow[])obj).Length) ? 8 : 4);
					continue;
				case 4:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			WxCache.Ⴅ.Error(ex.Message);
		}
		switch (4)
		{
		}
	}

	private DataSet Ⴀ()
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		while (true)
		{
			ISupportInitializeNotification supportInitializeNotification = new DataSet();
			ByeHelp.Ⴈ(DirectoryHelp.Ⴀ(supportInitializeNotification as DataSet, 'Ê', '·'), new DataTable(CallBlockCacheCfg.Ⴅ(null, 7, 62061922, null)), 683, 716);
			int num = 15;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႷ[91] - 7810;
					continue;
				case 6:
					break;
				case 15:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(supportInitializeNotification as DataSet, 'Ĕ', 'ũ'), 0, 'Ǟ', 394), 1005, 974), new DataColumn(SetStationClubHelp.Ⴍ(5, 3, 1747258009, null), typeof(string)), 278, 'Ė');
					num = 10;
					continue;
				case 10:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(supportInitializeNotification as DataSet, 'ƀ', 'ǽ'), 0, 'ǝ', 393), 200, 235), new DataColumn(SetStationClubHelp.Ⴍ(10, 3, 1747258268, null), typeof(string)), 299, 'ī');
					num = 7;
					continue;
				case 7:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitializeNotification, ';', 'F'), 0, 'ê', 190), 504, 475), new DataColumn(ReplyMailHelp.Ⴄ(27, null, 1057162064, 2), typeof(string)), 510, 'Ǿ');
					num = 16;
					continue;
				case 16:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitializeNotification, 'ʶ', 'ˋ'), 0, 'Ǧ', 434), 941, 910), new DataColumn(CallBlockCacheCfg.Ⴅ(null, 2, 62057993, null), typeof(string)), 311, 'ķ');
					num = 3;
					continue;
				case 3:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitializeNotification, '\u008b', 'ö'), 0, 'ʋ', 735), 442, 409), new DataColumn(ShowWxHelp.Ⴍ('\u0011', 985807342, 8), typeof(string)), 262, 'Ć');
					num = 9;
					continue;
				case 9:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(supportInitializeNotification as DataSet, 'ʏ', '\u02f2'), 0, '\u00ad', 249), 361, 330), new DataColumn(SetStationQth.Ⴍ(null, 1687353327, 3, 14), typeof(string)), 577, 'Ɂ');
					num = 13;
					continue;
				case 5:
				case 13:
					SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)supportInitializeNotification, 'ɝ', 'Ƞ'), 0, 'Ȁ', 596).Columns.Add(new DataColumn(ReplyMail.Ⴅ(4, 3, 1217944514), typeof(string)));
					num = ⴀႣ[230] - 15827;
					continue;
				case 11:
				{
					((DataSet)supportInitializeNotification).Tables[0].Columns.Add(new DataColumn(ReplyMailHelp.Ⴄ(4, null, 1057165318, 4), typeof(string)));
					byte num2 = ⴀႼ[18];
					SetWxOutput.ႣႰ[129] = (char)((SetWxOutput.ႣႰ[129] * SetWxOutput.ႣႰ[104]) & 0xED);
					num = num2 - 68;
					continue;
				}
				case 12:
					(supportInitializeNotification as DataSet).Tables[0].Columns.Add(new DataColumn(ShowSkimCtyHelp.Ⴍ(1216133136, 4, '6'), typeof(string)));
					num = 2;
					continue;
				case 2:
					((DataSet)supportInitializeNotification).Tables[0].Columns.Add(new DataColumn(ႰႥ.Ⴅ(1, 'J', 952619267), typeof(int)));
					goto case 17;
				case 17:
					num = 1;
					continue;
				case 1:
				case 8:
					((DataSet)supportInitializeNotification).Tables[0].Columns.Add(new DataColumn(ShowWxHelp.Ⴍ('ð', 985808420, 3), typeof(string)));
					num = 4;
					continue;
				case 4:
					(supportInitializeNotification as DataSet).Tables[0].Columns.Add(new DataColumn(ႰႥ.Ⴅ(4, ')', 952620233), typeof(DateTime)));
					num = 0;
					continue;
				case 0:
					return supportInitializeNotification as DataSet;
				}
				break;
			}
		}
	}

	public bool AddSpot(AnnWxSpot annWx)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		bool result = default(bool);
		try
		{
			switch (2)
			{
			default:
			{
				bool flag = false;
				object ⴗ = default(object);
				try
				{
					int num = 14;
					bool flag2 = default(bool);
					object obj = default(object);
					object ⴍ = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							ႨႥ.Ⴍ(ⴗ = WxCache.Ⴗ, ref flag, 345, 336);
							flag2 = Ⴃ(annWx);
							num = 10;
							continue;
						case 10:
						case 17:
							if (!flag2)
							{
								num = 0;
								continue;
							}
							break;
						case 0:
							obj = NodeUserCmd.Ⴓ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴍ(), 'Ő', 'ĭ'), 0, 'ɇ', 531), 'ě', 'Ű');
							num = ⴐ[44] - 41;
							continue;
						case 16:
							ArcConnectObj.Ⴓ((DataRow)obj, SetStationClubHelp.Ⴍ(6, 7, 1747258013, null), (object)SunCalculations.Ⴍ(annWx, 340, 285), 'o', '|');
							num = ⴃႰ[38] - 10558;
							continue;
						case 8:
							ArcConnectObj.Ⴓ((DataRow)obj, SetStationClubHelp.Ⴍ(8, 2, 1747258269, null), (object)SetStationGrid.Ⴍ(LotwCacheCfg.Ⴀ(annWx, 708, 'ʲ'), 504, 'ƪ'), 'ŷ', 'Ť');
							num = ⴄႤ[184] - 207;
							continue;
						case 4:
						case 15:
							ArcConnectObj.Ⴓ(obj as DataRow, ReplyMailHelp.Ⴄ(22, null, 1057162066, 0), (object)ShowPrefixCallsHelp.Ⴍ(annWx, 'Ǯ', 470), 'ʘ', 'ʋ');
							num = ⴀ[424] - 41945;
							continue;
						case 1:
							ArcConnectObj.Ⴓ((DataRow)obj, ShowWxHelp.Ⴍ('y', 985807328, 6), (object)qslinfoRequestBody.Ⴐ(annWx, 902, 956), '!', '2');
							num = ⴃႥ[203] - 52427;
							continue;
						case 9:
							ArcConnectObj.Ⴓ((DataRow)obj, SetStationQth.Ⴍ(null, 1687353321, 5, 29), (object)SetWxCountHelp.Ⴈ(annWx, '\u035b', '\u0325'), 'Ϥ', 'Ϸ');
							num = ⴀႼ[113];
							continue;
						case 2:
							ArcConnectObj.Ⴓ((DataRow)obj, ReplyMail.Ⴅ(6, 14, 1217944512), (object)LotwCacheCfg.Ⴀ(annWx, 38, '^'), 'ʩ', 'ʺ');
							num = ⴃႥ[13] - 37063;
							continue;
						case 19:
							ArcConnectObj.Ⴓ(obj as DataRow, CallBlockCacheCfg.Ⴅ(null, 8, 62057987, null), (object)WxFullHelp.Ⴍ(annWx, 492, 424), '϶', 'ϥ');
							num = ⴀႨ[17] - 11462;
							continue;
						case 6:
							ArcConnectObj.Ⴓ((DataRow)obj, ReplyMailHelp.Ⴄ(19, null, 1057165318, 4), (object)LotwCacheCfg.Ⴀ(annWx, 711, 'ʰ'), 'ϊ', 'ϙ');
							num = 7;
							continue;
						case 7:
							ArcConnectObj.Ⴓ(obj as DataRow, ShowSkimCtyHelp.Ⴍ(1216133141, 1, 'í'), (object)qslinfoRequestBody.Ⴐ(annWx, 19, 40), 'Ɋ', 'ə');
							num = 5;
							continue;
						case 5:
						case 11:
							(obj as DataRow)[ShowWxHelp.Ⴍ('D', 985808417, 6)] = annWx.DupeKey;
							num = 18;
							continue;
						case 18:
							(obj as DataRow)[ႰႥ.Ⴅ(2, 'Û', 952619264)] = annWx.Id;
							num = ⴀ[383] - 19828;
							continue;
						case 12:
							(obj as DataRow)[SetStationQth.Ⴍ(null, 1687351809, 7, 11)] = annWx.Dts;
							num = ⴀ[159] - 3558;
							continue;
						case 3:
						{
							Ⴍ().Tables[0].Rows.Add(obj as DataRow);
							bool lockTaken = false;
							try
							{
								switch (3)
								{
								default:
									Monitor.Enter(ⴍ = WxCache.m_Ⴍ, ref lockTaken);
									break;
								case 1:
									break;
								}
								this.m_Ⴃ.Tables[0].ImportRow((DataRow)obj);
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
										num3 = ((!lockTaken) ? 1 : 5);
										goto IL_04b2;
									case 5:
										Monitor.Exit(ⴍ);
										break;
									case 1:
										break;
									}
									break;
									IL_04b2:
									num2 = num3;
								}
							}
							break;
						}
						}
						break;
					}
					switch (2)
					{
					default:
						result = flag2;
						return result;
					case 0:
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
							num5 = ((!flag) ? (ⴅ[118] - 59) : 5);
							goto IL_0511;
						case 3:
						case 5:
							Monitor.Exit(ⴗ);
							break;
						case 1:
							break;
						}
						break;
						IL_0511:
						num4 = num5;
					}
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			WxCache.Ⴅ.Error(ex.Message);
			goto IL_0541;
		}
		goto IL_0565;
		IL_0541:
		switch (5)
		{
		default:
			return true;
		case 0:
		case 2:
		case 4:
			break;
		}
		goto IL_0565;
		IL_0565:
		return result;
	}

	private bool Ⴃ(AnnWxSpot P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		while (true)
		{
			Array array = SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴍ(), '\u0366', '\u031b'), 0, 'Õ', 129).Select(SetStationQth.Ⴍ(null, 1687354708, 6, 10) + ShowPrefixCallsHelp.Ⴍ(P_0, '\u009a', 163) + ႨႨ.Ⴀ(11, 0, 1157903557));
			int num = ⴍႭ[370] - 25912;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2:
				case 3:
					break;
				case 0:
				case 1:
				case 4:
				{
					bool result = ((DataRow[])array).Length > 0;
					SetAnnChatRooms.Ⴀ[177] = (char)((SetAnnChatRooms.Ⴀ[177] | SetAnnChatRooms.Ⴀ[235]) & 0xA9);
					return result;
				}
				}
				break;
			}
		}
	}

	internal bool Ⴀ(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool flag = false;
		object ⴗ = default(object);
		bool flag2 = default(bool);
		try
		{
			int num = 3;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴗ = WxCache.Ⴗ, ref flag, 403, 410);
					obj = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴍ(), 'τ', 'ι'), 0, 'h', 60), P_0, '&', 27);
					break;
				case 2:
					break;
				case 5:
					flag2 = ((DataRow[])obj).Length > 0;
					goto end_IL_0034;
				case 0:
					goto end_IL_0034;
				}
				num = 5;
				continue;
				end_IL_0034:
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
					num3 = ((!flag) ? 1 : (ⴃႥ[95] - 43820));
					goto IL_00dc;
				case 0:
					Monitor.Exit(ⴗ);
					break;
				case 1:
				case 4:
					break;
				}
				break;
				IL_00dc:
				num2 = num3;
			}
		}
		return 3 switch
		{
			_ => flag2, 
		};
	}

	internal void Ⴈ(int P_0)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			bool flag = false;
			object ⴍ = default(object);
			try
			{
				ႨႥ.Ⴍ(ⴍ = WxCache.m_Ⴍ, ref flag, 63, 54);
				object obj = SetDxOutputHelp.Ⴍ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.m_Ⴃ, 'ƍ', 'ǰ'), 0, '\u02ed', 697), '\u032b', 811), '0', 41);
				try
				{
					int num = 6;
					object obj2 = default(object);
					while (true)
					{
						switch (num)
						{
						case 3:
						case 5:
							obj2 = (DataRow)((IEnumerator)obj).Current;
							num = ((P_0 != (int)qslinfoSoapClient.Ⴓ((DataRow)obj2, ႰႥ.Ⴅ(1, '$', 952619267), 981, 'Λ')) ? (ⴀ[389] - 31303) : (ⴀႨ[232] - 7517));
							break;
						case 7:
							qslinfoRequest.Ⴅ(ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.m_Ⴃ, '\u0318', '\u0365'), 0, 'ʹ', 800), 'Π', 928), (DataRow)obj2, 'Ÿ', 'Ŭ');
							num = ⴄႤ[495] - ⴄႤ[15];
							break;
						default:
							num = ((obj as IEnumerator).MoveNext() ? (ⴀႳ[24] - 25568) : (ⴅ[365] / 3));
							break;
						case 4:
							return;
						}
					}
				}
				finally
				{
					int num2 = 1;
					object obj3 = default(object);
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							obj3 = ((IEnumerator)obj) as IDisposable;
							num3 = ((obj3 is IDisposable) ? (ⴃႰ[195] - 17183) : 0);
							goto IL_01dd;
						case 2:
						case 5:
							(obj3 as IDisposable).Dispose();
							break;
						case 0:
							break;
						}
						break;
						IL_01dd:
						num2 = num3;
					}
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
						num5 = ((!flag) ? 5 : 4);
						goto IL_0219;
					case 0:
					case 3:
					case 4:
						Monitor.Exit(ⴍ);
						break;
					case 1:
					case 5:
						break;
					}
					break;
					IL_0219:
					num4 = num5;
				}
			}
		}
		catch (Exception ex)
		{
			WxCache.Ⴅ.Error(P_0 + ႰႥ.Ⴅ(2, '\u008c', 952620208) + (ex as Exception).Message);
		}
	}

	public void SaveToDb()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		bool flag = false;
		object ⴗ = default(object);
		try
		{
			switch (0)
			{
			default:
				ႨႥ.Ⴍ(ⴗ = WxCache.Ⴗ, ref flag, 825, 816);
				try
				{
					switch (2)
					{
					default:
					{
						DbConnection dbConnection = new SqlCeConnection(Ⴗ.Configuration.DbConnect);
						try
						{
							int num = 15;
							object obj = default(object);
							DbDataAdapter dbDataAdapter = default(DbDataAdapter);
							ICloneable cloneable = default(ICloneable);
							int num2 = default(int);
							while (true)
							{
								switch (num)
								{
								default:
									obj = new PrecisionTimer();
									ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 252, 189);
									SetAnnWrapHelp.Ⴀ((DbConnection)(dbConnection as SqlCeConnection), 58, (short)57);
									num = ⴍႤ[199] - 19075;
									continue;
								case 1:
									dbDataAdapter = new SqlCeDataAdapter();
									cloneable = new SqlCeCommand(ShowSkimCtyHelp.Ⴍ(1216129550, 7, 'ß'), (SqlCeConnection)dbConnection);
									goto case 11;
								case 11:
									num = 9;
									continue;
								case 9:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 415, 488), ReplyMailHelp.Ⴄ(18, null, 1057161827, 1), SqlDbType.NVarChar, 12, SetStationClubHelp.Ⴍ(15, 2, 1747258008, null), 702, 671);
									num = 4;
									continue;
								case 4:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable as SqlCeCommand, 206, 185), SetStationQth.Ⴍ(null, 1687351811, 3, 7), SqlDbType.NVarChar, 200, SetStationClubHelp.Ⴍ(5, 2, 1747258269, null), 668, 701);
									goto case 14;
								case 14:
									num = ⴃႥ[334] - 56876;
									continue;
								case 16:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable as SqlCeCommand, 627, 516), ReplyMailHelp.Ⴄ(26, null, 1057161840, 8), SqlDbType.NVarChar, 12, ReplyMailHelp.Ⴄ(15, null, 1057162071, 5), 259, 290);
									num = 8;
									continue;
								case 8:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 617, 542), SetStationQth.Ⴍ(null, 1687353571, 4, 6), SqlDbType.NVarChar, 5, ShowWxHelp.Ⴍ('\u009b', 985807334, 0), 622, 591);
									num = 10;
									continue;
								case 10:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable as SqlCeCommand, 930, 981), ReplyMailHelp.Ⴄ(11, null, 1057163535, 8), SqlDbType.NVarChar, 2, SetStationQth.Ⴍ(null, 1687353321, 5, 21), 618, 587);
									num = 2;
									continue;
								case 2:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 917, 994), SetStationQth.Ⴍ(null, 1687353499, 2, 9), SqlDbType.NVarChar, 2, ReplyMail.Ⴅ(8, 0, 1217944526), 683, 650);
									goto case 0;
								case 0:
									num = ⴄႭ[568];
									continue;
								case 12:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 305, 326), SetStationQth.Ⴍ(null, 1687351868, 5, 5), SqlDbType.NVarChar, 12, CallBlockCacheCfg.Ⴅ(null, 0, 62057995, null), 807, 774);
									num = 5;
									continue;
								case 5:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable as SqlCeCommand, 685, 730), ႨႨ.Ⴀ(9, 8, 1157898485), SqlDbType.NVarChar, 1, ReplyMailHelp.Ⴄ(11, null, 1057165312, 2), 187, 154);
									num = 3;
									continue;
								case 3:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(cloneable as SqlCeCommand, 130, 245), ReplyMailHelp.Ⴄ(27, null, 1057161732, 3), SqlDbType.NVarChar, 255, ShowSkimCtyHelp.Ⴍ(1216133140, 0, 'Á'), 765, 732);
									num = ⴐ[171] - 156;
									continue;
								case 13:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)cloneable, 768, 887), CallBlockCacheCfg.Ⴅ(null, 8, 62058008, null), SqlDbType.DateTime, 0, ႰႥ.Ⴅ(3, ' ', 952620238), 410, 443);
									num = 7;
									continue;
								case 7:
									((SqlCeDataAdapter)dbDataAdapter).InsertCommand = cloneable as SqlCeCommand;
									num2 = ((SqlCeDataAdapter)dbDataAdapter).Update(Ⴍ().Tables[0]);
									num = ⴄႭ[129] - 94;
									continue;
								case 6:
								{
									(obj as PrecisionTimer).Stop();
									ILog ⴅ = WxCache.Ⴅ;
									object obj2 = new object[4];
									(obj2 as object[])[0] = obj as PrecisionTimer;
									((object[])obj2)[1] = ReplyMailHelp.Ⴄ(14, null, 1057167281, 5);
									(obj2 as object[])[2] = num2;
									(obj2 as object[])[3] = SetStationQth.Ⴍ(null, 1687351827, 8, 30);
									ⴅ.Info(string.Concat(obj2 as object[]));
									break;
								}
								}
								break;
							}
						}
						finally
						{
							int num3 = 1;
							while (true)
							{
								int num4;
								switch (num3)
								{
								default:
									num4 = (((SqlCeConnection)dbConnection == null) ? (ⴀႳ[250] - 48320) : (ⴀ[234] - 30306));
									goto IL_056f;
								case 0:
								case 2:
								case 4:
									((IDisposable)(dbConnection as SqlCeConnection)).Dispose();
									break;
								case 3:
									break;
								}
								break;
								IL_056f:
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
					WxCache.Ⴅ.Error(ex.Message);
				}
				switch (3)
				{
				}
				break;
			}
		}
		finally
		{
			int num5 = 0;
			while (true)
			{
				int num6;
				switch (num5)
				{
				default:
					num6 = ((!flag) ? 5 : (ⴄႤ[345] - 123));
					goto IL_061e;
				case 4:
					Monitor.Exit(ⴗ);
					break;
				case 5:
					break;
				}
				break;
				IL_061e:
				num5 = num6;
			}
		}
		switch (0)
		{
		}
	}

	public DataTable GetDataTable(string sql, int nmbrDesired)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool flag = false;
		object ⴗ = default(object);
		Array array;
		try
		{
			switch (4)
			{
			default:
				ႨႥ.Ⴍ(ⴗ = WxCache.Ⴗ, ref flag, 348, 341);
				break;
			case 2:
				break;
			}
			array = DxSpotBlockCacheCfg.Ⴄ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴍ(), 'Ư', 'ǒ'), 0, 'ş', 267), sql, SetStationQth.Ⴍ(null, 1687351822, 8, 0), 'ă', 'ń');
		}
		finally
		{
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!flag) ? 5 : (ⴀ[436] - 2472));
					goto IL_0108;
				case 2:
					DxCmdMsgExt.ႨႠ(ⴗ, 'ö', 147);
					break;
				case 5:
					break;
				}
				break;
				IL_0108:
				num = num2;
			}
		}
		int num3 = 5;
		object obj = default(object);
		Array array2 = default(Array);
		int num4 = default(int);
		IEquatable<string> equatable = default(IEquatable<string>);
		object obj4 = default(object);
		object obj5 = default(object);
		object obj3 = default(object);
		while (true)
		{
			switch (num3)
			{
			case 6:
				obj = ShowSkimmerHelp.Ⴈ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴍ(), '\u02f5', 'ʈ'), 0, '\u001d', 73), 'Ť', 270);
				num3 = 4;
				continue;
			case 4:
			case 9:
				array2 = array as DataRow[];
				goto case 2;
			case 2:
				num4 = 0;
				num3 = 10;
				continue;
			case 3:
			{
				object obj2 = (array2 as DataRow[])[num4];
				SetAnnModeHelp.Ⴍ((DataTable)obj, obj2 as DataRow, 'Ή', 960);
				num3 = 8;
				continue;
			}
			case 7:
			case 8:
				num4++;
				num3 = ⴀႨ[27] - 10510;
				continue;
			case 10:
				num3 = ((num4 < (array2 as DataRow[]).Length) ? 3 : 0);
				continue;
			case 0:
				return obj as DataTable;
			}
			int num5 = ((DataRow[])array).Length;
			ShowSunHelp.ႣႠ[152] = (char)((ShowSunHelp.ႣႠ[152] ^ nmbrDesired) & 0xCD);
			if (num5 >= nmbrDesired)
			{
				num3 = 6;
				continue;
			}
			try
			{
				int num6 = 2;
				while (true)
				{
					switch (num6)
					{
					default:
						SaveToDb();
						goto case 1;
					case 1:
						equatable = ShowPrefixCalls.Ⴃ((object)ReplyMailHelp.Ⴄ(6, null, 1057161787, 7), (object)nmbrDesired, (object)ReplyMailHelp.Ⴄ(25, null, 1057167182, 7), 'ȇ', 557);
						num6 = 4;
						continue;
					case 3:
					case 4:
						num6 = ((CallBlockCacheCfg.Ⴜ(sql, 649, 744) <= 0) ? 7 : 6);
						continue;
					case 6:
						equatable = AnnHelp.Ⴈ(equatable as string, ႰႥ.Ⴅ(6, '\u008a', 952620689), LogEntry.Ⴄ(sql, 'Ύ', 932), 827, '\u030c');
						num6 = 7;
						continue;
					case 7:
						equatable = ShowUsersHelp.Ⴅ(equatable as string, ႰႥ.Ⴅ(1, 'ç', 952622465), 1005, 931);
						goto case 5;
					case 5:
						num6 = ⴄႷ[38] - 46341;
						continue;
					case 8:
						obj4 = new DataSet();
						obj5 = new SqlCeDataAdapter((string)equatable, Ⴗ.Configuration.DbConnect);
						num6 = 10;
						continue;
					case 10:
						(obj5 as SqlCeDataAdapter).Fill((DataSet)obj4, CallBlockCacheCfg.Ⴅ(null, 8, 62061933, null));
						num6 = ⴃႥ[258] - 32718;
						continue;
					case 0:
						obj3 = ((DataSet)obj4).Tables[0];
						break;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				WxCache.Ⴅ.Error(ex.Message + ႰႥ.Ⴅ(1, '£', 952620211) + sql);
				goto IL_03e7;
			}
			goto IL_040b;
			IL_040b:
			return obj3 as DataTable;
			IL_03e7:
			switch (4)
			{
			default:
				return null;
			case 5:
				break;
			}
			goto IL_040b;
		}
	}

	internal bool Ⴓ(string P_0)
	{
		object ⴗ = default(object);
		while (true)
		{
			bool num = ByeHelp.Ⴍ(P_0, SetStationClubHelp.Ⴍ(9, 7, 1747258271, null), 205, 170);
			SetDxCountHelp.ႭႤ[373] = (SetDxCountHelp.ႭႤ[373] | SetDxCountHelp.ႭႤ[26]) & 0xEB;
			int num2 = ((!num) ? 6 : 2);
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
				case 2:
				case 3:
					return true;
				case 0:
				case 6:
				{
					bool flag = false;
					bool flag2;
					try
					{
						switch (4)
						{
						default:
							ႨႥ.Ⴍ(ⴗ = WxCache.Ⴗ, ref flag, 198, 207);
							try
							{
								int num3 = 3;
								while (true)
								{
									switch (num3)
									{
									default:
										DxSpotBlockCacheCfg.Ⴄ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴍ(), 'γ', 'ώ'), 0, 'ƈ', 476), P_0, SetStationQth.Ⴍ(null, 1687351815, 1, 13), '\u0320', '\u0367');
										break;
									case 2:
										break;
									case 1:
									case 4:
										flag2 = true;
										goto end_IL_00ba;
									}
									num3 = 4;
									continue;
									end_IL_00ba:
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
						int num4 = 3;
						while (true)
						{
							int num5;
							switch (num4)
							{
							default:
								num5 = (flag ? 6 : 0);
								goto IL_0155;
							case 2:
							case 4:
							case 6:
								Monitor.Exit(ⴗ);
								break;
							case 0:
							case 1:
								break;
							}
							break;
							IL_0155:
							num4 = num5;
						}
					}
					return 2 switch
					{
						_ => flag2, 
					};
				}
				}
				break;
			}
		}
	}

	static WxCache()
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				WxCache.Ⴗ = new object();
				WxCache.m_Ⴍ = new object();
				return;
			case 2:
				return;
			}
			WxCache.Ⴅ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(1, null, 1267014398, typeof(ArcServerCfg)), 674, 703);
			num = ⴍႤ[259] - ⴍႤ[259];
		}
	}
}
