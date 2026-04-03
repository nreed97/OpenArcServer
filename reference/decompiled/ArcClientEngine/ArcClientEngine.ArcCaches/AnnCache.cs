using System;
using System.Collections;
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

public sealed class AnnCache
{
	private static readonly ILog Ⴈ;

	private static readonly object Ⴄ;

	private int Ⴐ = 1;

	private DataSet Ⴗ;

	private DxccCacheData.ႷႭ Ⴃ = new DxccCacheData.ႷႭ();

	public bool ScrollNeeded
	{
		get
		{
			bool ⴐ = Ⴃ.Ⴐ;
			Bye.Ⴄ[8] = (char)((Bye.Ⴄ[8] * ႥႰ.Ⴗ[66]) & 0x8E);
			return ⴐ;
		}
		set
		{
			bool ⴐ = value;
			Ⴃ.Ⴐ = ⴐ;
		}
	}

	public DataSet DataSet
	{
		get
		{
			DataSet ⴗ = Ⴗ;
			Bye.Ⴄ[289] = (char)((Bye.Ⴄ[289] ^ UserCmd.Ⴅ[115]) & 0xDE);
			return ⴗ;
		}
		set
		{
			Ⴗ = value;
		}
	}

	public AnnCache()
	{
		DataSet = new DataSet();
		bool flag = false;
		object ⴄ = default(object);
		try
		{
			ႥႥ.ႤႨ(ⴄ = Ⴄ, ref flag, 694, 711);
			TelnetServerCfg.Ⴃ(ႥႠ.Ⴓ(DataSet, 631, 626), new DataTable(WxFilters.Ⴀ(null, 5, 103387735)), 'Ų', 336);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 389, 384), 0, 400, 433), 397, 'Ƅ'), new DataColumn(WxFilters.Ⴀ(null, 6, 103387730), typeof(int)), 576, 527);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 951, 946), 0, 833, 864), 54, '?'), new DataColumn(ႥႥ.Ⴅ(1673508168, null, 4), typeof(string)), 744, 679);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 599, 594), 0, 394, 427), 931, 'Ϊ'), new DataColumn(WxFilters.Ⴀ(null, 2, 103387674), typeof(string)), 635, 564);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 787, 790), 0, 769, 800), 49, '8'), new DataColumn(ႥႥ.Ⴅ(1673508195, null, 4), typeof(string)), 749, 674);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 704, 709), 0, 916, 949), 855, '\u035e'), new DataColumn(WxFilters.Ⴀ(null, 3, 103387649), typeof(string)), 770, 845);
			DataSet.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴅ(1673508222, null, 7), typeof(string)));
			DataSet.Tables[0].Columns.Add(new DataColumn(WxFilters.Ⴀ(null, 8, 103387652), typeof(string)));
			DataSet.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴅ(1673508106, null, 4), typeof(string)));
			DataSet.Tables[0].Columns.Add(new DataColumn(WxFilters.Ⴀ(null, 1, 103387710), typeof(DateTime)));
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(ⴄ);
			}
		}
	}

	internal bool Ⴀ(AnnWxSpot P_0)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		try
		{
			switch (0)
			{
			default:
			{
				bool flag = false;
				object ⴄ = default(object);
				try
				{
					int num = 7;
					object obj = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							ႥႥ.ႤႨ(ⴄ = Ⴄ, ref flag, 879, 798);
							obj = ႥႠ.Ⴜ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 795, 798), 0, 416, 385), 819, 857);
							num = 9;
							continue;
						case 9:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, WxFilters.Ⴀ(null, 4, 103387728), (object)Ⴐ++, (short)381, 357);
							num = ⴅ[115];
							continue;
						case 4:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ႥႥ.Ⴅ(1673508168, null, 4), (object)ArcClientConnectDat.Ⴗ(P_0, 'Ȼ', 573), (short)865, 889);
							num = ⴗ[152] - 32155;
							continue;
						case 11:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, WxFilters.Ⴀ(null, 7, 103387679), (object)ShowUsers.Ⴓ(P_0, 'E', 'w'), (short)53, 45);
							goto case 13;
						case 13:
							num = 12;
							continue;
						case 12:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ႥႥ.Ⴅ(1673508197, null, 2), (object)DxccCacheData.ႷႣ(P_0, 'ζ', '·'), (short)755, 747);
							num = ⴀႠ[115] - 48707;
							continue;
						case 10:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, WxFilters.Ⴀ(null, 0, 103387650), (object)DxccCacheData.ႷႣ(P_0, 'ʨ', 'ʚ'), (short)638, 614);
							num = 8;
							continue;
						case 8:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ႥႥ.Ⴅ(1673508223, null, 6), (object)DxccCacheData.ႷႣ(P_0, 'Z', 'i'), (short)302, 310);
							num = ⴅ[295] - 86;
							continue;
						case 14:
							((DataRow)obj)[WxFilters.Ⴀ(null, 7, 103387659)] = DxccCacheData.ႷႣ(P_0, '\u00b8', '\u008c');
							num = ⴀႠ[116] - 60585;
							continue;
						case 0:
						case 1:
							(obj as DataRow)[ႥႥ.Ⴅ(1673508110, null, 0)] = P_0.SpotterCont;
							num = 3;
							continue;
						case 3:
							((DataRow)obj)[WxFilters.Ⴀ(null, 0, 103387711)] = P_0.Dts;
							num = 5;
							continue;
						case 5:
							DataSet.Tables[0].Rows.Add(obj as DataRow);
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
							num3 = ((!flag) ? (ⴀႠ[26] - 10580) : 4);
							goto IL_0318;
						case 4:
							Monitor.Exit(ⴄ);
							break;
						case 1:
						case 3:
							break;
						}
						break;
						IL_0318:
						num2 = num3;
					}
				}
				switch (0)
				{
				default:
					ScrollNeeded = true;
					break;
				case 4:
					break;
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			Ⴈ.Error((ex as Exception).Message);
		}
		return 1 switch
		{
			_ => true, 
		};
	}

	public void PurgeOldSpots()
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 4;
		IEnumerable enumerable = default(IEnumerable);
		object ⴄ2 = default(object);
		object obj2 = default(object);
		object obj = default(object);
		int num3 = default(int);
		object obj3 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				string text = ႥႥ.Ⴍ(2, 1580608885, 'w', null);
				DateTime dateTime = FilterPicker.ႥႰ('ύ', 'ΐ');
				enumerable = ႥႭ.ႳႣ((object)text, (object)TelnetServerCfg.Ⴈ(ref dateTime, -24.0, 183, 215), (object)WxFilters.Ⴀ(null, 7, 103387686), 'ʊ', 689);
				break;
			}
			case 0:
				break;
			case 3:
			{
				bool flag = false;
				try
				{
					int num2 = 3;
					while (true)
					{
						switch (num2)
						{
						default:
							ႥႥ.ႤႨ(ⴄ2 = Ⴄ, ref flag, 332, 317);
							obj2 = ႥႤ.Ⴈ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 422, 419), 0, 926, 959), (string)enumerable, 'ʘ', '\u02f5');
							num2 = 8;
							continue;
						case 8:
							obj = obj2 as DataRow[];
							goto case 1;
						case 1:
							num3 = 0;
							num2 = 7;
							continue;
						case 5:
							obj3 = ((DataRow[])obj)[num3];
							goto case 4;
						case 4:
							ႥႠ.Ⴓ(DataSet, 406, 403)[0].Rows.Remove((DataRow)obj3);
							num2 = 6;
							continue;
						case 0:
						case 6:
							num3++;
							num2 = ⴄ[62] - 13520;
							continue;
						case 7:
							num2 = ((num3 < ((DataRow[])obj).Length) ? 5 : 9);
							continue;
						case 9:
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
							num5 = ((!flag) ? 4 : 3);
							goto IL_01d6;
						case 3:
							Monitor.Exit(ⴄ2);
							break;
						case 4:
						case 6:
							break;
						}
						break;
						IL_01d6:
						num4 = num5;
					}
				}
				switch (4)
				{
				}
				return;
			}
			}
			num = ⴗ[72] - 15846;
		}
	}

	internal bool Ⴓ(string P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		bool flag = false;
		bool flag2 = default(bool);
		object ⴄ = default(object);
		try
		{
			int num = 0;
			Array array = default(Array);
			while (true)
			{
				switch (num)
				{
				case 5:
					flag2 = ((DataRow[])array).GetLength(0) > 0;
					goto end_IL_0062;
				case 1:
					goto end_IL_0062;
				}
				ႥႥ.ႤႨ(ⴄ = Ⴄ, ref flag, 576, 561);
				array = ႥႤ.Ⴈ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 489, 492), 0, 873, 840), P_0, '×', 'º');
				num = 5;
				continue;
				end_IL_0062:
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
					num3 = ((!flag) ? (ⴀႠ[99] - 46020) : 0);
					goto IL_0110;
				case 0:
					Monitor.Exit(ⴄ);
					break;
				case 2:
				case 4:
				case 6:
					break;
				}
				break;
				IL_0110:
				num2 = num3;
			}
		}
		return 1 switch
		{
			_ => flag2, 
		};
	}

	public bool IsValidFilter(string sql)
	{
		char[] ⴄ = Bye.Ⴄ;
		bool flag = false;
		object ⴄ2 = default(object);
		bool flag2;
		try
		{
			switch (2)
			{
			default:
				ႥႥ.ႤႨ(ⴄ2 = Ⴄ, ref flag, 214, 167);
				try
				{
					int num = 5;
					while (true)
					{
						switch (num)
						{
						case 1:
						case 3:
							flag2 = true;
							goto end_IL_006a;
						}
						HighlightCountyCfg.ႷႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 711, 706), 0, 462, 495), sql, ClientCty.Ⴗ('\v', 3, 307013272), 773, 876);
						num = 1;
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
			int num2 = 2;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 4 : (ⴄ[234] - 24922));
					goto IL_0111;
				case 1:
				case 5:
					Monitor.Exit(ⴄ2);
					break;
				case 4:
					break;
				}
				break;
				IL_0111:
				num2 = num3;
			}
		}
		return 4 switch
		{
			_ => flag2, 
		};
	}

	public DataRow[] GetDataRows(string filter)
	{
		IEquatable<string> equatable = TelnetServerCfg.Ⴗ(filter, SqlFilterType.Dx, '\u02e9', 715);
		DataRow[] result = ႥႠ.Ⴓ(DataSet, 985, 988)[0].Select((string)equatable);
		Bye.Ⴄ[82] = (char)((Bye.Ⴄ[82] + Bye.Ⴄ[133]) & 0x53);
		return result;
	}

	[SecuritySafeCritical]
	static AnnCache()
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				ArcClientConnectDat.Ⴍ();
				break;
			case 1:
				break;
			case 2:
				Ⴄ = new object();
				return;
			case 0:
				return;
			}
			Ⴈ = HighlightItuZoneCfg.Ⴓ(WxFilters.Ⴀ(null, 8, 103387693), 595, 611);
			num = 2;
		}
	}
}
