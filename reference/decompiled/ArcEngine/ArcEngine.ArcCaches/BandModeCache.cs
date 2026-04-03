using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
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
using ArcEngine.ArcDatabase;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArxWebService;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class BandModeCache
{
	private static readonly ILog Ⴄ;

	private static readonly object Ⴃ;

	private CallbookCfg.Ⴀ Ⴍ = new CallbookCfg.Ⴀ();

	public BandModeCache()
	{
		MarshalByValueComponent marshalByValueComponent = new DataSet();
		Ⴍ.Ⴐ = marshalByValueComponent as DataSet;
		ႷႷ.Ⴅ(DirectoryHelp.Ⴀ(Ⴍ.Ⴐ, '\u0347', '\u033a'), CallBlockCacheCfg.Ⴅ(null, 7, 62056991, null), 85, 2);
		SetStationQthHelp.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴍ.Ⴐ, 'ʠ', '\u02dd'), 0, '\u030e', 858), 77, 110), SetTalkCount.Ⴗ(4, null, 1267023345, typeof(WsArxNode)), 'ʙ', 643);
		SetStationQthHelp.Ⴗ(HealthMonitorCfg.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴍ.Ⴐ, 'a', '\u001c'), 0, 'Β', 966), 634, 601), SetStationClubHelp.Ⴍ(6, 4, 1747257420, null), '\u00a8', 178);
		DirectoryHelp.Ⴀ(Ⴍ.Ⴐ, 'ō', 'İ')[0].Columns.Add(ReplyMailHelp.Ⴄ(31, null, 1057162895, 7), typeof(int));
		Ⴍ.Ⴐ.Tables[0].Columns.Add(ႨႨ.Ⴀ(0, 3, 1157902507), typeof(int));
		Init();
	}

	public void Init()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		bool flag = false;
		object ⴃ = default(object);
		try
		{
			switch (3)
			{
			default:
				ႨႥ.Ⴍ(ⴃ = Ⴃ, ref flag, 907, 898);
				try
				{
					int num = 1;
					object obj2 = default(object);
					ISerializable serializable = default(ISerializable);
					IEnumerable<char> enumerable = default(IEnumerable<char>);
					TextReader textReader = default(TextReader);
					IComparable<string> comparable = default(IComparable<string>);
					while (true)
					{
						switch (num)
						{
						default:
							obj2 = new PrecisionTimer();
							ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj2, 560, 625);
							ShowSun.Ⴗ(Ⴍ.Ⴐ, 'ɶ', 'ɝ');
							num = 4;
							continue;
						case 0:
						case 4:
							serializable = ShowLog.Ⴍ(9, '\u0001');
							goto case 2;
						case 2:
						case 5:
							enumerable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(serializable as Assembly, 623, 525), 681, 'ʼ'), SetStationQth.Ⴍ(null, 1687352362, 3, 22), 95, 17);
							num = ⴍႤ[399] - 48106;
							continue;
						case 3:
						{
							object obj = new FileStream((string)enumerable, FileMode.Open, FileAccess.Read);
							try
							{
								int num2 = 9;
								while (true)
								{
									switch (num2)
									{
									default:
										textReader = new StreamReader(obj as FileStream);
										goto case 8;
									case 8:
										comparable = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)textReader, '\u0091', 220);
										num2 = ⴍႤ[72] - 6269;
										continue;
									case 2:
										num2 = ((CallBlockCacheCfg.Ⴜ((string)comparable, 699, 730) <= 0) ? 3 : (ⴃႠ[126] - 12068));
										continue;
									case 4:
										num2 = ((!SetAnnDefault.Ⴍ(comparable as string, ႰႥ.Ⴅ(5, 'ò', 952620231), 135, 213)) ? 1 : 3);
										continue;
									case 1:
										ProcessLine(comparable as string);
										goto case 3;
									case 3:
										comparable = SetAnnModeHelp.Ⴐ((TextReader)(textReader as StreamReader), 'ɀ', 525);
										num2 = 0;
										continue;
									case 0:
									case 5:
									case 10:
										num2 = ((comparable is string) ? (ⴃႥ[200] - 30021) : (ⴄႷ[2] - 23600));
										continue;
									case 6:
										break;
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
										num4 = ((!(obj is FileStream)) ? 4 : (ⴄႤ[475] - 131));
										goto IL_028d;
									case 2:
									case 5:
									case 6:
										((IDisposable)(obj as FileStream)).Dispose();
										break;
									case 3:
									case 4:
										break;
									}
									break;
									IL_028d:
									num3 = num4;
								}
							}
							switch (4)
							{
							default:
								ByeHelp.Ⴄ(obj2 as PrecisionTimer, 'Ȣ', 625);
								break;
							case 0:
								break;
							}
							ILog ⴄ = Ⴄ;
							Array array = new object[4];
							(array as object[])[0] = obj2 as PrecisionTimer;
							((object[])array)[1] = ႰႥ.Ⴅ(5, '0', 952619507);
							(array as object[])[2] = Ⴍ.Ⴐ.Tables[0].Rows.Count;
							(array as object[])[3] = ႰႥ.Ⴅ(8, '^', 952619499);
							ⴄ.Info(string.Concat(array as object[]));
							break;
						}
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Ⴄ.Error(ex.Message);
				}
				switch (1)
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
					num6 = ((!flag) ? (ⴀႳ[289] - 38446) : 4);
					goto IL_03c1;
				case 4:
					Monitor.Exit(ⴃ);
					break;
				case 2:
					break;
				}
				break;
				IL_03c1:
				num5 = num6;
			}
		}
		switch (0)
		{
		}
	}

	public void ProcessLine(string line)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 7;
		object obj3 = default(object);
		object obj2 = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				line = SetTalkDefault.Ⴃ(line, 737, 'ˍ');
				string text = line;
				object obj4 = new char[1];
				(obj4 as char[])[0] = ' ';
				obj3 = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(text, (char[])obj4, 665, 719);
				num = 5;
				break;
			}
			case 5:
				if ((obj3 as string[]).Length == 4)
				{
					num = 2;
					break;
				}
				Ⴄ.Warn(SetStationQth.Ⴍ(null, 1687352521, 6, 24));
				return;
			case 2:
				obj2 = new ႰႳ();
				if (((ႰႳ)obj2).Ⴍ(obj3 as string[]))
				{
					num = 3;
					break;
				}
				return;
			case 3:
				obj = NodeUserCmd.Ⴓ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴍ.Ⴐ, 'Ü', '¡'), 0, 'Η', 963), '\u0382', 'ϩ');
				num = 1;
				break;
			case 1:
				ArcConnectObj.Ⴓ((DataRow)obj, SetTalkCount.Ⴗ(6, null, 1267023347, typeof(SetDxCountHelp)), (object)((ႰႳ)obj2).Ⴄ, 'ǫ', 'Ǹ');
				goto case 0;
			case 0:
				num = 10;
				break;
			case 10:
				ArcConnectObj.Ⴓ(obj as DataRow, SetStationClubHelp.Ⴍ(7, 2, 1747257418, null), (object)((ႰႳ)obj2).Ⴍ, 'ʘ', 'ʋ');
				num = ⴀႨ[211] - 16888;
				break;
			case 8:
				ArcConnectObj.Ⴓ(obj as DataRow, ReplyMailHelp.Ⴄ(18, null, 1057162889, 1), (object)(obj2 as ႰႳ).Ⴀ.ToString(), 'ɝ', 'Ɏ');
				num = 11;
				break;
			case 11:
				((DataRow)obj)[ႨႨ.Ⴀ(14, 6, 1157902510)] = ((ႰႳ)obj2).Ⴈ.ToString();
				goto case 6;
			case 6:
				num = 4;
				break;
			case 4:
				Ⴍ.Ⴐ.Tables[0].Rows.Add(obj as DataRow);
				return;
			}
		}
	}

	public void GetBandMode(double freq, ref float band, ref string mode)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool flag = false;
		object ⴃ = default(object);
		try
		{
			switch (1)
			{
			default:
				ႨႥ.Ⴍ(ⴃ = Ⴃ, ref flag, 560, 569);
				try
				{
					int num = 3;
					object obj2 = default(object);
					object obj = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							obj2 = new object[4];
							goto case 8;
						case 8:
							((object[])obj2)[0] = freq;
							(obj2 as object[])[1] = SetTalkCount.Ⴗ(0, null, 1267023340, typeof(DirectoryHelp));
							num = ⴄႷ[37] - 43348;
							continue;
						case 9:
							(obj2 as object[])[2] = freq;
							(obj2 as object[])[3] = CallBlockCacheCfg.Ⴅ(null, 7, 62056964, null);
							num = ⴃႠ[32] - 19210;
							continue;
						case 1:
						case 2:
						{
							IComparable comparable = SetDxDefaultHelp.Ⴍ(obj2 as object[], '\u0378', 785);
							obj = SetTalkOutputHelp.Ⴅ(SkimmerSpotBins.Ⴀ(DirectoryHelp.Ⴀ(Ⴍ.Ⴐ, '\u0017', 'j'), 0, '\u02fa', 686), comparable as string, '\u034f', 882);
							num = 4;
							continue;
						}
						case 4:
							num = ((((DataRow[])obj).Length <= 0) ? 10 : (ⴀႼ[66] - 57));
							continue;
						case 7:
							band = ShowGrayline.Ⴈ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ((obj as DataRow[])[0], SetTalkCount.Ⴗ(0, null, 1267023349, typeof(DxMaintenance)), 837, '\u030b'), 'Ƌ', 480), 955, 'σ');
							num = 5;
							continue;
						case 5:
							mode = ((DataRow[])obj)[0][SetStationClubHelp.Ⴍ(4, 0, 1747257416, null)].ToString();
							num = ⴃႰ[192] - 49002;
							continue;
						case 10:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Ⴄ.Error((ex as Exception).Message);
				}
				switch (2)
				{
				}
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
					num3 = ((!flag) ? 5 : 6);
					goto IL_026d;
				case 6:
					Monitor.Exit(ⴃ);
					break;
				case 5:
					break;
				}
				break;
				IL_026d:
				num2 = num3;
			}
		}
		switch (1)
		{
		}
	}

	static BandModeCache()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴄ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216134195, 7, 'Ú'), 77, 80);
				break;
			case 0:
				break;
			case 2:
			case 3:
			case 4:
				Ⴃ = new object();
				return;
			}
			num = ⴀႼ[126] - 234;
		}
	}
}
