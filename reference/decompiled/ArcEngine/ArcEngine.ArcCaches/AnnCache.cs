using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
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

public sealed class AnnCache
{
	private static readonly ILog m_Ⴍ;

	private static readonly object Ⴅ;

	private static readonly object Ⴃ;

	private readonly DataSet m_Ⴗ;

	private ႨႳ.Ⴈ m_Ⴄ = new ႨႳ.Ⴈ();

	public DataSet DataSet
	{
		get
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			return this.m_Ⴄ.Ⴃ;
		}
		private set
		{
			this.m_Ⴄ.Ⴃ = dataSet;
		}
	}

	public AnnCache(ArcServerCfg arcServerCfg)
	{
		this.m_Ⴄ.Ⴓ = arcServerCfg;
		DataSet = Ⴗ();
		this.m_Ⴗ = Ⴗ();
		AnnCache.m_Ⴍ.Info(SetStationClubHelp.Ⴍ(3, 0, 1747262614, null));
	}

	public void Init()
	{
	}

	public void Maintenance()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 2;
		object obj = default(object);
		object ⴅ = default(object);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
			case 3:
			case 4:
				return;
			}
			int num2 = DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, '\u0356', '\u032b'), 0, 'ū', 319), 'ȓ', 531), (short)27, (short)70);
			SetAnnMode.ႤႭ[480] = (byte)(SetAnnMode.ႤႭ[480] & SetAnnMode.ႤႭ[33] & 0x93);
			if (num2 == 0)
			{
				num = ⴄႤ[148];
				continue;
			}
			SaveToDb();
			bool flag = false;
			try
			{
				int num3 = 0;
				while (true)
				{
					switch (num3)
					{
					default:
						goto IL_00ef;
					case 3:
						(obj as PrecisionTimer).Start();
						Ⴍ();
						break;
					case 4:
						break;
					case 2:
						goto end_IL_00d0;
					}
					((PrecisionTimer)obj).Stop();
					AnnCache.m_Ⴍ.Info(obj as PrecisionTimer);
					break;
					IL_00ef:
					ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 131, 138);
					obj = new PrecisionTimer();
					num3 = 3;
					continue;
					end_IL_00d0:
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
						num5 = ((!flag) ? (ⴃႥ[176] - 54706) : 0);
						goto IL_016a;
					case 0:
						Monitor.Exit(ⴅ);
						break;
					case 1:
					case 6:
						break;
					}
					break;
					IL_016a:
					num4 = num5;
				}
			}
			switch (1)
			{
			}
			return;
		}
	}

	internal void Ⴍ()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		try
		{
			int num = 5;
			IEquatable<string> equatable = default(IEquatable<string>);
			Array array2 = default(Array);
			Array array = default(Array);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
				{
					string text = SetStationClubHelp.Ⴍ(10, 7, 1747255925, null);
					DateTime dateTime = ShowAnnHelp.Ⴅ('τ', 1013);
					equatable = ShowPrefixCalls.Ⴃ((object)text, (object)ReadMailHelp.Ⴍ(ref dateTime, -this.m_Ⴄ.Ⴓ.Caches.Ann.CacheMinutes, 581, 581), (object)ႰႥ.Ⴅ(6, 'e', 952620228), '>', 20);
					num = ⴀႳ[78] - 933;
					continue;
				}
				case 9:
					array2 = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, '\u02c5', 'ʸ'), 0, 'ͷ', 803), (string)equatable, 'ɬ', 593);
					goto case 1;
				case 1:
					num = 2;
					continue;
				case 2:
					array = array2 as DataRow[];
					goto case 7;
				case 7:
					num2 = 0;
					num = 3;
					continue;
				case 6:
				{
					object obj = ((DataRow[])array)[num2];
					DirectoryHelp.Ⴀ(DataSet, '\u001b', 'f')[0].Rows.Remove((DataRow)obj);
					num = ⴀႼ[37] - 21;
					continue;
				}
				case 4:
					num2++;
					num = ⴍႭ[153] - 64906;
					continue;
				case 3:
					num = ((num2 < (array as DataRow[]).Length) ? 6 : (ⴃႥ[79] - 4228));
					continue;
				case 0:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			AnnCache.m_Ⴍ.Error(ex.Message);
		}
		switch (4)
		{
		}
	}

	private DataSet Ⴗ()
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		while (true)
		{
			object obj = new DataSet();
			ByeHelp.Ⴈ(DirectoryHelp.Ⴀ((DataSet)obj, 'ž', 'ă'), new DataTable(ShowSkimCtyHelp.Ⴍ(1216129797, 5, '\u00a8')), 662, 753);
			int num = ⴍႭ[159] - 34487;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 6;
					continue;
				case 6:
					break;
				case 4:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)obj, 'ƍ', 'ǰ'), 0, 'Ȁ', 596), 682, 649), new DataColumn(SetStationClubHelp.Ⴍ(2, 3, 1747258009, null), typeof(string)), 244, 'ô');
					num = ⴀႨ[191] - 2541;
					continue;
				case 8:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(obj as DataSet, '\u035f', '\u0322'), 0, '\u007f', 43), 94, 125), new DataColumn(SetStationClubHelp.Ⴍ(13, 6, 1747258265, null), typeof(string)), 9, '\t');
					goto case 2;
				case 2:
					num = 17;
					continue;
				case 17:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(obj as DataSet, 'ů', 'Ē'), 0, 'ĥ', 369), 369, 338), new DataColumn(ReplyMailHelp.Ⴄ(12, null, 1057162074, 8), typeof(string)), 220, 'Ü');
					num = 16;
					continue;
				case 16:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)obj, 'Ė', 'ū'), 0, 'Ź', 301), 925, 958), new DataColumn(CallBlockCacheCfg.Ⴅ(null, 2, 62057993, null), typeof(string)), 385, 'Ɓ');
					num = ⴀ[169] - 58869;
					continue;
				case 14:
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(obj as DataSet, 'Ϡ', 'Ν'), 0, 'Ĉ', 348), 660, 695), new DataColumn(ShowWxHelp.Ⴍ('¿', 985807329, 7), typeof(string)), 47, '/');
					num = ⴄႷ[100] - 20018;
					continue;
				case 9:
				{
					SetDxOutput.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(obj as DataSet, 'e', '\u0018'), 0, 'ǎ', 410), 281, 314), new DataColumn(SetStationQth.Ⴍ(null, 1687353322, 6, 13), typeof(string)), 136, '\u0088');
					int num2 = ⴀႨ[48];
					ႨႣ.Ⴐ[249] = (byte)((ႨႣ.Ⴐ[249] - ႨႣ.Ⴐ[269]) & 0x69);
					num = num2 - 4736;
					continue;
				}
				case 11:
					SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ((DataSet)obj, 'ė', 'Ū'), 0, '\u035a', 782).Columns.Add(new DataColumn(ReplyMail.Ⴅ(0, 6, 1217944518), typeof(string)));
					num = ⴄႤ[47];
					continue;
				case 12:
					(obj as DataSet).Tables[0].Columns.Add(new DataColumn(ႰႥ.Ⴅ(2, 'ð', 952620239), typeof(DateTime)));
					num = ⴅ[319] - 197;
					continue;
				case 15:
					(obj as DataSet).Tables[0].Columns.Add(new DataColumn(ReplyMailHelp.Ⴄ(4, null, 1057165312, 2), typeof(string)));
					num = ⴄႷ[12] - 43763;
					continue;
				case 10:
					((DataSet)obj).Tables[0].Columns.Add(new DataColumn(ShowSkimCtyHelp.Ⴍ(1216133143, 3, '='), typeof(string)));
					num = 0;
					continue;
				case 0:
					((DataSet)obj).Tables[0].Columns.Add(new DataColumn(ႰႥ.Ⴅ(2, 'ç', 952619264), typeof(int)));
					num = 3;
					continue;
				case 1:
				case 3:
					((DataSet)obj).Tables[0].Columns.Add(new DataColumn(ShowWxHelp.Ⴍ('A', 985808416, 7), typeof(string)));
					num = 5;
					continue;
				case 5:
				case 13:
					return obj as DataSet;
				}
				break;
			}
		}
	}

	public bool AddSpot(AnnWxSpot annWx)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		bool flag3 = default(bool);
		try
		{
			switch (0)
			{
			default:
			{
				bool flag = false;
				object ⴅ = default(object);
				try
				{
					int num = 10;
					bool flag2 = default(bool);
					object obj = default(object);
					object ⴃ = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 220, 213);
							flag2 = Ⴓ(annWx);
							num = ⴀႨ[118] - 41570;
							continue;
						case 3:
							if (!flag2)
							{
								num = 6;
								continue;
							}
							break;
						case 6:
							obj = NodeUserCmd.Ⴓ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, '\u0381', 'ϼ'), 0, ' ', 116), 'ŏ', 'Ĥ');
							num = 4;
							continue;
						case 4:
							ArcConnectObj.Ⴓ(obj as DataRow, SetStationClubHelp.Ⴍ(12, 5, 1747258015, null), (object)SunCalculations.Ⴍ(annWx, 48, 121), 'ǒ', 'ǁ');
							num = 18;
							continue;
						case 18:
						{
							ArcConnectObj.Ⴓ((DataRow)obj, SetStationClubHelp.Ⴍ(7, 7, 1747258264, null), (object)SetStationGrid.Ⴍ(LotwCacheCfg.Ⴀ(annWx, 714, 'ʼ'), 522, 'ɘ'), 'ɮ', 'ɽ');
							char num4 = ⴃႥ[185];
							AnnCacheCfg.ႠႼ[115] = (byte)((AnnCacheCfg.ႠႼ[115] * SetDxCountHelp.ႭႤ[341]) & 0xFA);
							num = num4 - 8953;
							continue;
						}
						case 7:
							ArcConnectObj.Ⴓ(obj as DataRow, ReplyMailHelp.Ⴄ(14, null, 1057162069, 7), (object)ShowPrefixCallsHelp.Ⴍ(annWx, '\u0014', 44), '\u0310', '\u0303');
							num = ⴀႨ[20] - 47573;
							continue;
						case 1:
							ArcConnectObj.Ⴓ(obj as DataRow, ShowWxHelp.Ⴍ('\u0017', 985807331, 5), (object)qslinfoRequestBody.Ⴐ(annWx, 12, 54), 'ϊ', 'ϙ');
							num = ⴃႥ[152] - 55216;
							continue;
						case 11:
						case 16:
							ArcConnectObj.Ⴓ((DataRow)obj, SetStationQth.Ⴍ(null, 1687353321, 5, 14), (object)SetWxCountHelp.Ⴈ(annWx, 'ɨ', 'Ȗ'), 'ϣ', 'ϰ');
							goto case 17;
						case 17:
							num = 9;
							continue;
						case 9:
							ArcConnectObj.Ⴓ((DataRow)obj, ReplyMail.Ⴅ(5, 13, 1217944515), (object)LotwCacheCfg.Ⴀ(annWx, 976, 'Ψ'), '¡', '²');
							num = 8;
							continue;
						case 8:
							ArcConnectObj.Ⴓ((DataRow)obj, CallBlockCacheCfg.Ⴅ(null, 3, 62057992, null), (object)WxFullHelp.Ⴍ(annWx, 652, 712), 'Χ', 'δ');
							num = 14;
							continue;
						case 14:
							ArcConnectObj.Ⴓ((DataRow)obj, ReplyMailHelp.Ⴄ(17, null, 1057165313, 3), (object)LotwCacheCfg.Ⴀ(annWx, 734, 'ʩ'), 'ė', 'Ą');
							num = ⴀႳ[342] - 46507;
							continue;
						case 5:
							ArcConnectObj.Ⴓ((DataRow)obj, ShowSkimCtyHelp.Ⴍ(1216133148, 8, '1'), (object)qslinfoRequestBody.Ⴐ(annWx, 383, 324), '\u0343', '\u0350');
							num = 0;
							continue;
						case 0:
							(obj as DataRow)[ShowWxHelp.Ⴍ('¢', 985808419, 4)] = annWx.DupeKey;
							num = 12;
							continue;
						case 12:
							(obj as DataRow)[ႰႥ.Ⴅ(2, '\u0095', 952619264)] = annWx.Id;
							goto case 13;
						case 13:
							num = ⴀႳ[16] - 43952;
							continue;
						case 2:
							(obj as DataRow)[SetStationQth.Ⴍ(null, 1687351810, 4, 12)] = annWx.Dts;
							num = ⴐ[265] - 169;
							continue;
						case 15:
						{
							DataSet.Tables[0].Rows.Add(obj as DataRow);
							bool lockTaken = false;
							try
							{
								switch (4)
								{
								default:
									Monitor.Enter(ⴃ = Ⴃ, ref lockTaken);
									this.m_Ⴗ.Tables[0].ImportRow((DataRow)obj);
									break;
								case 0:
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
										num3 = (lockTaken ? 1 : (ⴀႼ[108] - ⴀႼ[134]));
										goto IL_04aa;
									case 1:
										Monitor.Exit(ⴃ);
										break;
									case 0:
									case 5:
										break;
									}
									break;
									IL_04aa:
									num2 = num3;
								}
							}
							break;
						}
						}
						break;
					}
					switch (0)
					{
					default:
						flag3 = flag2;
						return flag3;
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
							num6 = ((!flag) ? 1 : 3);
							goto IL_0516;
						case 0:
						case 3:
							Monitor.Exit(ⴅ);
							break;
						case 1:
						case 2:
							break;
						}
						break;
						IL_0516:
						num5 = num6;
					}
				}
			}
			}
		}
		catch (Exception ex)
		{
			AnnCache.m_Ⴍ.Error(ex.Message);
		}
		return 5 switch
		{
			1 => flag3, 
			_ => true, 
		};
	}

	private bool Ⴓ(AnnWxSpot P_0)
	{
		bool flag = false;
		object ⴅ = default(object);
		bool flag2;
		try
		{
			int num = 3;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 244, 253);
					obj = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, 'ţ', 'Ğ'), 0, 'ě', 335), AnnHelp.Ⴈ(SetStationQth.Ⴍ(null, 1687354706, 0, 26), ShowPrefixCallsHelp.Ⴍ(P_0, 'ϳ', 970), ႨႨ.Ⴀ(10, 2, 1157903559), 301, 'Ě'), 'Ƚ', 512);
					break;
				case 4:
					break;
				case 1:
					flag2 = ((DataRow[])obj).Length > 0;
					goto end_IL_002d;
				}
				num = 1;
				continue;
				end_IL_002d:
				break;
			}
		}
		finally
		{
			int num2 = 1;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 3 : 5);
					goto IL_0113;
				case 5:
				case 6:
					Monitor.Exit(ⴅ);
					break;
				case 3:
					break;
				}
				break;
				IL_0113:
				num2 = num3;
			}
		}
		return 3 switch
		{
			_ => flag2, 
		};
	}

	internal bool Ⴗ(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool flag = false;
		bool flag2;
		object ⴅ = default(object);
		try
		{
			int num = 4;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
				case 5:
					flag2 = ((DataRow[])obj).Length > 0;
					goto end_IL_0034;
				}
				ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 988, 981);
				obj = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, 'P', '-'), 0, '\u031a', 846), P_0, 'Æ', 251);
				num = 1;
				continue;
				end_IL_0034:
				break;
			}
		}
		finally
		{
			int num2 = 1;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? (ⴃႥ[109] - 17160) : 6);
					goto IL_00d8;
				case 6:
					Monitor.Exit(ⴅ);
					break;
				case 0:
				case 2:
					break;
				}
				break;
				IL_00d8:
				num2 = num3;
			}
		}
		return 2 switch
		{
			_ => flag2, 
		};
	}

	public void CleanTempCache(int id)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		try
		{
			bool flag = false;
			object ⴃ = default(object);
			try
			{
				ႨႥ.Ⴍ(ⴃ = Ⴃ, ref flag, 917, 924);
				object obj = SetDxOutputHelp.Ⴍ((InternalDataCollectionBase)ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.m_Ⴗ, '\u001f', 'b'), 0, '£', 247), 'Ϳ', 895), 'Ȓ', 523);
				try
				{
					int num = 6;
					object obj2 = default(object);
					while (true)
					{
						switch (num)
						{
						case 7:
							obj2 = (DataRow)((IEnumerator)obj).Current;
							num = ((id != (int)qslinfoSoapClient.Ⴓ((DataRow)obj2, ႰႥ.Ⴅ(4, 'F', 952619270), 834, '\u030c')) ? (ⴀ[95] - 5680) : 4);
							break;
						case 0:
						case 4:
							qslinfoRequest.Ⴅ(ShowHeading.Ⴗ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(this.m_Ⴗ, 'ʿ', '\u02c2'), 0, 'Ͻ', 937), 'ɰ', 624), (DataRow)obj2, '\u0314', '\u0300');
							num = ⴐ[232] - 116;
							break;
						default:
							num = (((IEnumerator)obj).MoveNext() ? (ⴀႨ[176] - 911) : (ⴃႰ[150] - 63824));
							break;
						case 3:
						case 5:
							return;
						}
					}
				}
				finally
				{
					int num2 = 4;
					object obj3 = default(object);
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							obj3 = (obj as IEnumerator) as IDisposable;
							goto case 2;
						case 2:
							num3 = (((IDisposable)obj3 == null) ? 3 : (ⴐ[224] - 244));
							goto IL_01c9;
						case 1:
							(obj3 as IDisposable).Dispose();
							break;
						case 0:
						case 3:
							break;
						}
						break;
						IL_01c9:
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
						num5 = ((!flag) ? 3 : 4);
						goto IL_0205;
					case 0:
					case 4:
					case 5:
						Monitor.Exit(ⴃ);
						break;
					case 3:
						break;
					}
					break;
					IL_0205:
					num4 = num5;
				}
			}
		}
		catch (Exception ex)
		{
			AnnCache.m_Ⴍ.Error(id + ႰႥ.Ⴅ(1, 'h', 952620211) + ex.Message);
		}
	}

	public void SaveToDb()
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		bool flag = false;
		object ⴅ2 = default(object);
		try
		{
			switch (0)
			{
			default:
				ႨႥ.Ⴍ(ⴅ2 = Ⴅ, ref flag, 816, 825);
				try
				{
					switch (0)
					{
					default:
					{
						object obj = new SqlCeConnection(this.m_Ⴄ.Ⴓ.Configuration.DbConnect);
						try
						{
							int num = 6;
							object obj2 = default(object);
							DbDataAdapter dbDataAdapter = default(DbDataAdapter);
							DbCommand dbCommand = default(DbCommand);
							int num2 = default(int);
							while (true)
							{
								switch (num)
								{
								default:
									obj2 = new PrecisionTimer();
									ShowPrefixCallsHelp.Ⴗ(obj2 as PrecisionTimer, 589, 524);
									SetAnnWrapHelp.Ⴀ((DbConnection)(obj as SqlCeConnection), 900, (short)903);
									num = 7;
									continue;
								case 7:
									dbDataAdapter = new SqlCeDataAdapter();
									dbCommand = new SqlCeCommand(SetStationClubHelp.Ⴍ(9, 6, 1747262595, null), obj as SqlCeConnection);
									num = 16;
									continue;
								case 16:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(dbCommand as SqlCeCommand, 111, 24), ReplyMailHelp.Ⴄ(3, null, 1057161834, 8), SqlDbType.NVarChar, 12, SetStationClubHelp.Ⴍ(3, 0, 1747258010, null), 347, 378);
									num = 13;
									continue;
								case 13:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)dbCommand, 893, 778), SetStationQth.Ⴍ(null, 1687351816, 8, 12), SqlDbType.NVarChar, 200, SetStationClubHelp.Ⴍ(2, 3, 1747258268, null), 602, 635);
									num = 12;
									continue;
								case 9:
								case 12:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(dbCommand as SqlCeCommand, 762, 653), ReplyMailHelp.Ⴄ(25, null, 1057161853, 5), SqlDbType.NVarChar, 12, ReplyMailHelp.Ⴄ(26, null, 1057162071, 5), 305, 272);
									num = 1;
									continue;
								case 1:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ((SqlCeCommand)dbCommand, 90, 45), SetStationQth.Ⴍ(null, 1687353572, 3, 16), SqlDbType.NVarChar, 5, ShowWxHelp.Ⴍ('\u0099', 985807329, 7), 856, 889);
									num = ⴄႭ[323] - 177;
									continue;
								case 14:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(dbCommand as SqlCeCommand, 711, 688), ReplyMailHelp.Ⴄ(1, null, 1057163523, 4), SqlDbType.NVarChar, 2, SetStationQth.Ⴍ(null, 1687353322, 6, 8), 710, 743);
									num = 2;
									continue;
								case 2:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(dbCommand as SqlCeCommand, 951, 960), SetStationQth.Ⴍ(null, 1687353501, 4, 21), SqlDbType.NVarChar, 2, ReplyMail.Ⴅ(0, 6, 1217944518), 912, 945);
									num = 11;
									continue;
								case 11:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(dbCommand as SqlCeCommand, 937, 990), SetStationQth.Ⴍ(null, 1687351870, 7, 20), SqlDbType.NVarChar, 12, CallBlockCacheCfg.Ⴅ(null, 5, 62057998, null), 873, 840);
									num = ⴅ[6];
									continue;
								case 0:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(dbCommand as SqlCeCommand, 405, 482), ႨႨ.Ⴀ(0, 7, 1157898490), SqlDbType.NVarChar, 1, ReplyMailHelp.Ⴄ(15, null, 1057165317, 7), 1008, 977);
									num = 8;
									continue;
								case 8:
								{
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(dbCommand as SqlCeCommand, 599, 544), ReplyMailHelp.Ⴄ(26, null, 1057161735, 0), SqlDbType.NVarChar, 255, ShowSkimCtyHelp.Ⴍ(1216133142, 2, '\u0084'), 247, 214);
									char num3 = ⴍႭ[169];
									Arc4ServerClient.ႠႣ[212] = (char)(Arc4ServerClient.ႠႣ[212] & SetTalkCountHelp.Ⴅ[244] & 0x43);
									num = num3 - 60522;
									continue;
								}
								case 3:
								case 5:
									NodeUserCmd.Ⴈ(ShowStation.Ⴓ(dbCommand as SqlCeCommand, 724, 675), CallBlockCacheCfg.Ⴅ(null, 2, 62058002, null), SqlDbType.DateTime, 0, ႰႥ.Ⴅ(4, 'Æ', 952620233), 955, 922);
									goto case 15;
								case 15:
									num = 4;
									continue;
								case 4:
									(dbDataAdapter as SqlCeDataAdapter).InsertCommand = (SqlCeCommand)dbCommand;
									num2 = ((SqlCeDataAdapter)dbDataAdapter).Update(DataSet.Tables[0]);
									num = 10;
									continue;
								case 10:
								{
									(obj2 as PrecisionTimer).Stop();
									ILog ⴍ = AnnCache.m_Ⴍ;
									Array array = new object[4];
									(array as object[])[0] = (PrecisionTimer)obj2;
									(array as object[])[1] = ReplyMail.Ⴅ(2, 2, 1217942516);
									(array as object[])[2] = num2;
									((object[])array)[3] = SetStationQth.Ⴍ(null, 1687351833, 2, 4);
									ⴍ.Info(string.Concat(array as object[]));
									break;
								}
								}
								break;
							}
						}
						finally
						{
							int num4 = 4;
							while (true)
							{
								int num5;
								switch (num4)
								{
								default:
									num5 = (((SqlCeConnection)obj == null) ? 5 : (ⴐ[257] / 7));
									goto IL_055d;
								case 1:
								case 3:
									((IDisposable)(SqlCeConnection)obj).Dispose();
									break;
								case 5:
								case 6:
									break;
								}
								break;
								IL_055d:
								num4 = num5;
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
					AnnCache.m_Ⴍ.Error(ex.Message);
				}
				switch (0)
				{
				}
				break;
			}
		}
		finally
		{
			int num6 = 6;
			while (true)
			{
				int num7;
				switch (num6)
				{
				default:
					num7 = ((!flag) ? 3 : ⴄႭ[246]);
					goto IL_05fc;
				case 1:
				case 2:
					Monitor.Exit(ⴅ2);
					break;
				case 3:
				case 4:
					break;
				}
				break;
				IL_05fc:
				num6 = num7;
			}
		}
		switch (2)
		{
		}
	}

	public DataTable GetDataTable(string sql, int nmbrDesired)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		bool flag = false;
		object ⴅ = default(object);
		object obj = default(object);
		try
		{
			switch (2)
			{
			default:
				ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 866, 875);
				break;
			case 4:
				break;
			case 3:
				goto end_IL_004e;
			}
			obj = DxSpotBlockCacheCfg.Ⴄ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, 'Â', '¿'), 0, 'Ŗ', 258), sql, SetStationQth.Ⴍ(null, 1687351822, 8, 22), 'ų', 'Ĵ');
			end_IL_004e:;
		}
		finally
		{
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!flag) ? 5 : 6);
					goto IL_00f6;
				case 2:
				case 6:
					DxCmdMsgExt.ႨႠ(ⴅ, 'ȩ', 588);
					break;
				case 5:
					break;
				}
				break;
				IL_00f6:
				num = num2;
			}
		}
		int num3 = 9;
		ISupportInitializeNotification supportInitializeNotification = default(ISupportInitializeNotification);
		object obj2 = default(object);
		int num4 = default(int);
		ICloneable cloneable2 = default(ICloneable);
		MarshalByValueComponent marshalByValueComponent = default(MarshalByValueComponent);
		ICloneable cloneable = default(ICloneable);
		IListSource listSource = default(IListSource);
		while (true)
		{
			switch (num3)
			{
			case 0:
			case 10:
				supportInitializeNotification = ShowSkimmerHelp.Ⴈ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, '\u0081', 'ü'), 0, '\u0014', 64), 'ȁ', 619);
				num3 = ⴀႨ[44] - 6926;
				continue;
			case 5:
				obj2 = obj as DataRow[];
				num4 = 0;
				num3 = 4;
				continue;
			case 2:
			{
				object obj3 = (obj2 as DataRow[])[num4];
				SetAnnModeHelp.Ⴍ((DataTable)supportInitializeNotification, obj3 as DataRow, ' ', 105);
				goto case 8;
			}
			case 8:
				num3 = 3;
				continue;
			case 3:
				num4++;
				num3 = 4;
				continue;
			case 4:
				num3 = ((num4 < (obj2 as DataRow[]).Length) ? 2 : (ⴀႣ[337] - 62467));
				continue;
			case 1:
				return supportInitializeNotification as DataTable;
			}
			if (((DataRow[])obj).Length >= nmbrDesired)
			{
				num3 = ⴍႭ[308] - 22560;
				continue;
			}
			try
			{
				int num5 = 8;
				while (true)
				{
					switch (num5)
					{
					default:
						SaveToDb();
						goto case 0;
					case 0:
						cloneable2 = ShowPrefixCalls.Ⴃ((object)ReplyMailHelp.Ⴄ(5, null, 1057161787, 7), (object)nmbrDesired, (object)SetStationClubHelp.Ⴍ(12, 3, 1747262875, null), 'Ή', 931);
						num5 = ⴄႤ[529] + ⴄႤ[148];
						continue;
					case 3:
						num5 = ((CallBlockCacheCfg.Ⴜ(sql, 507, 410) <= 0) ? 5 : 6);
						continue;
					case 6:
						cloneable2 = AnnHelp.Ⴈ((string)cloneable2, ႰႥ.Ⴅ(8, 'Î', 952620703), LogEntry.Ⴄ(sql, 'd', 78), 549, 'Ȓ');
						num5 = 5;
						continue;
					case 5:
						cloneable2 = ShowUsersHelp.Ⴅ(cloneable2 as string, ႰႥ.Ⴅ(1, '²', 952622465), 370, 316);
						goto case 4;
					case 4:
						num5 = ⴍႤ[178] - 3014;
						continue;
					case 7:
						marshalByValueComponent = new DataSet();
						cloneable = new SqlCeDataAdapter(cloneable2 as string, this.m_Ⴄ.Ⴓ.Configuration.DbConnect);
						goto case 2;
					case 2:
						num5 = 10;
						continue;
					case 10:
						(cloneable as SqlCeDataAdapter).Fill((DataSet)marshalByValueComponent, ShowSkimCtyHelp.Ⴍ(1216129796, 4, '\u0012'));
						num5 = 9;
						continue;
					case 9:
						listSource = ((DataSet)marshalByValueComponent).Tables[0];
						break;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				AnnCache.m_Ⴍ.Error((ex as Exception).Message + ႰႥ.Ⴅ(2, 'þ', 952620208) + sql);
				goto IL_03d4;
			}
			goto IL_03f8;
			IL_03f8:
			return (DataTable)listSource;
			IL_03d4:
			switch (0)
			{
			default:
				return null;
			case 2:
			case 5:
				break;
			}
			goto IL_03f8;
		}
	}

	internal bool Ⴄ(string P_0)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		object ⴅ = default(object);
		bool flag2 = default(bool);
		while (true)
		{
			int num = ((!ByeHelp.Ⴍ(P_0, SetStationClubHelp.Ⴍ(6, 5, 1747258269, null), 887, 784)) ? 5 : 3);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 6;
					continue;
				case 1:
				case 6:
					break;
				case 3:
					return true;
				case 2:
				case 5:
				{
					bool flag = false;
					try
					{
						switch (3)
						{
						default:
							ႨႥ.Ⴍ(ⴅ = Ⴅ, ref flag, 151, 158);
							try
							{
								int num2 = 3;
								while (true)
								{
									switch (num2)
									{
									case 0:
									case 5:
										flag2 = true;
										goto end_IL_00a2;
									case 2:
										goto end_IL_00a2;
									}
									DxSpotBlockCacheCfg.Ⴄ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(DataSet, 'Ώ', 'ϲ'), 0, '\u0010', 68), P_0, SetStationQth.Ⴍ(null, 1687351812, 2, 25), '\u00af', 'è');
									num2 = 5;
									continue;
									end_IL_00a2:
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
						int num3 = 0;
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								num4 = ((!flag) ? (ⴄႭ[394] - 83) : ⴀႼ[113]);
								goto IL_013b;
							case 2:
							case 4:
								Monitor.Exit(ⴅ);
								break;
							case 3:
							case 5:
								break;
							}
							break;
							IL_013b:
							num3 = num4;
						}
					}
					return 4 switch
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
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		IConvertible convertible = string.Empty;
		try
		{
			convertible = ႰႠ.Ⴗ(sql, SqlFilterType.AnnWx, 257, 352);
		}
		catch (Exception ex)
		{
			AnnCache.m_Ⴍ.Error(SkimmerSpotBins.Ⴈ(ex, 864, 846));
		}
		return convertible as string;
	}

	static AnnCache()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				Ⴅ = new object();
				Ⴃ = new object();
				return;
			case 3:
				return;
			}
			AnnCache.m_Ⴍ = SkimmerValidSpot.Ⴐ(ReplyMailHelp.Ⴄ(3, null, 1057165331, 5), 536, 517);
			num = ⴀႳ[167] - 16005;
		}
	}
}
