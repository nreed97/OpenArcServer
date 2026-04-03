using System;
using System.Collections;
using System.Data;
using System.Security;
using System.Threading;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public sealed class WxCache
{
	private static readonly ILog Ⴍ;

	private static readonly object Ⴐ;

	private bool Ⴗ;

	private DataSet Ⴈ;

	private DxCommentExtCfg.ႤႠ m_Ⴅ = new DxCommentExtCfg.ႤႠ();

	public bool ScrollNeeded
	{
		get
		{
			bool ⴗ = Ⴗ;
			HighlightCtyCfg.ႠႠ[67] = (char)((HighlightCtyCfg.ႠႠ[67] ^ ႥႰ.Ⴗ[55]) & 0x92);
			return ⴗ;
		}
		set
		{
			Ⴗ = value;
		}
	}

	public DataSet DataSet
	{
		get
		{
			return Ⴈ;
		}
		set
		{
			Ⴈ = value;
		}
	}

	internal WxCache()
	{
		this.m_Ⴅ.Ⴍ = 1;
		base._002Ector();
		DataSet = new DataSet();
		bool flag = false;
		object ⴐ = default(object);
		try
		{
			ႥႥ.ႤႨ(ⴐ = Ⴐ, ref flag, 510, 399);
			TelnetServerCfg.Ⴃ(ႥႠ.Ⴓ(DataSet, 496, 501), new DataTable(ႥႥ.Ⴅ(1673507039, null, 3)), '\u030a', 808);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 693, 688), 0, 285, 316), 265, 'Ā'), new DataColumn(WxFilters.Ⴀ(null, 5, 103387729), typeof(int)), 506, 437);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 904, 909), 0, 760, 729), 890, 'ͳ'), new DataColumn(ႥႥ.Ⴅ(1673508172, null, 0), typeof(string)), 205, 130);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 122, 127), 0, 373, 340), 46, '\''), new DataColumn(WxFilters.Ⴀ(null, 6, 103387678), typeof(string)), 112, 63);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 330, 335), 0, 424, 393), 722, '\u02db'), new DataColumn(ႥႥ.Ⴅ(1673508192, null, 7), typeof(string)), 940, 995);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 608, 613), 0, 463, 494), 311, 'ľ'), new DataColumn(WxFilters.Ⴀ(null, 3, 103387649), typeof(string)), 18, 93);
			DataSet.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴅ(1673508222, null, 7), typeof(string)));
			DataSet.Tables[0].Columns.Add(new DataColumn(WxFilters.Ⴀ(null, 6, 103387658), typeof(string)));
			DataSet.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴅ(1673508108, null, 2), typeof(string)));
			DataSet.Tables[0].Columns.Add(new DataColumn(WxFilters.Ⴀ(null, 3, 103387708), typeof(DateTime)));
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(ⴐ);
			}
		}
	}

	internal bool Ⴃ(AnnWxSpot P_0)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		try
		{
			switch (2)
			{
			default:
			{
				bool flag = false;
				object ⴐ = default(object);
				try
				{
					int num = 9;
					object obj = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							ႥႥ.ႤႨ(ⴐ = Ⴐ, ref flag, 27, 106);
							obj = ႥႠ.Ⴜ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 230, 227), 0, 617, 584), 632, 530);
							num = 1;
							continue;
						case 1:
						{
							DataRow obj2 = (DataRow)obj;
							string text = WxFilters.Ⴀ(null, 1, 103387733);
							int ⴍ2;
							int ⴍ = (ⴍ2 = this.m_Ⴅ.Ⴍ) + 1;
							this.m_Ⴅ.Ⴍ = ⴍ;
							HighlightCqZoneCfg.Ⴗ(obj2, text, (object)ⴍ2, (short)813, 821);
							goto case 5;
						}
						case 5:
							num = 8;
							continue;
						case 8:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ႥႥ.Ⴅ(1673508164, null, 8), (object)ArcClientConnectDat.Ⴗ(P_0, 'ʷ', 689), (short)539, 515);
							num = 12;
							continue;
						case 12:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, WxFilters.Ⴀ(null, 2, 103387674), (object)ShowUsers.Ⴓ(P_0, ')', '\u001b'), (short)811, 819);
							num = 6;
							continue;
						case 6:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ႥႥ.Ⴅ(1673508193, null, 6), (object)DxccCacheData.ႷႣ(P_0, '\u032b', '\u031a'), (short)264, 272);
							num = 13;
							continue;
						case 13:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, WxFilters.Ⴀ(null, 2, 103387648), (object)DxccCacheData.ႷႣ(P_0, 'ư', 'Ƃ'), (short)898, 922);
							num = 10;
							continue;
						case 10:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, ႥႥ.Ⴅ(1673508216, null, 1), (object)DxccCacheData.ႷႣ(P_0, '\v', '8'), (short)18, 10);
							num = 7;
							continue;
						case 7:
							(obj as DataRow)[WxFilters.Ⴀ(null, 4, 103387656)] = DxccCacheData.ႷႣ(P_0, 'ϸ', 'ό');
							goto case 3;
						case 3:
							num = ⴀႠ[86] - 44438;
							continue;
						case 14:
							((DataRow)obj)[ႥႥ.Ⴅ(1673508102, null, 8)] = P_0.SpotterCont;
							num = 4;
							continue;
						case 4:
							((DataRow)obj)[WxFilters.Ⴀ(null, 0, 103387711)] = P_0.Dts;
							num = 0;
							continue;
						case 0:
							DataSet.Tables[0].Rows.Add(obj as DataRow);
							break;
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
							num3 = ((!flag) ? (ⴄ[39] - 46469) : (ⴄ[4] - 10468));
							goto IL_02ff;
						case 4:
							Monitor.Exit(ⴐ);
							break;
						case 1:
							break;
						}
						break;
						IL_02ff:
						num2 = num3;
					}
				}
				switch (1)
				{
				default:
					ScrollNeeded = true;
					break;
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			Ⴍ.Error(ex.Message);
		}
		return 4 switch
		{
			_ => true, 
		};
	}

	public void PurgeOldSpots()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 4;
		IEnumerable enumerable = default(IEnumerable);
		object ⴐ = default(object);
		Array array = default(Array);
		object obj = default(object);
		int num3 = default(int);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				string text = ႥႥ.Ⴍ(4, 1580608883, 'Z', null);
				DateTime dateTime = FilterPicker.ႥႰ('\a', 'Z');
				enumerable = ႥႭ.ႳႣ((object)text, (object)TelnetServerCfg.Ⴈ(ref dateTime, -24.0, 804, 836), (object)WxFilters.Ⴀ(null, 3, 103387682), '\u0016', 45);
				break;
			}
			case 0:
			case 2:
				break;
			case 1:
			{
				bool flag = false;
				try
				{
					int num2 = 0;
					while (true)
					{
						switch (num2)
						{
						default:
							ႥႥ.ႤႨ(ⴐ = Ⴐ, ref flag, 554, 603);
							array = ႥႤ.Ⴈ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 900, 897), 0, 95, 126), (string)enumerable, '\u000e', 'c');
							num2 = 5;
							continue;
						case 5:
							obj = array as DataRow[];
							num3 = 0;
							num2 = ⴗ[72] - 15840;
							continue;
						case 2:
						case 8:
							obj2 = (obj as DataRow[])[num3];
							goto case 4;
						case 4:
							ႥႠ.Ⴓ(DataSet, 138, 143)[0].Rows.Remove(obj2 as DataRow);
							num2 = ⴅ[213] - 239;
							continue;
						case 6:
							num3++;
							num2 = 9;
							continue;
						case 3:
						case 9:
							num2 = ((num3 < ((DataRow[])obj).Length) ? 8 : (ⴄ[39] - 46469));
							continue;
						case 1:
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
							num5 = ((!flag) ? 1 : 2);
							goto IL_01dc;
						case 2:
							Monitor.Exit(ⴐ);
							break;
						case 1:
						case 4:
							break;
						}
						break;
						IL_01dc:
						num4 = num5;
					}
				}
				switch (0)
				{
				}
				return;
			}
			}
			num = ⴀႠ[126] - 21893;
		}
	}

	internal bool Ⴅ(string P_0)
	{
		bool flag = false;
		object ⴐ = default(object);
		bool flag2;
		try
		{
			int num = 4;
			Array array = default(Array);
			while (true)
			{
				switch (num)
				{
				default:
					ႥႥ.ႤႨ(ⴐ = Ⴐ, ref flag, 952, 969);
					break;
				case 1:
					break;
				case 2:
				case 3:
					flag2 = (array as DataRow[]).GetLength(0) > 0;
					goto end_IL_002d;
				}
				array = ႥႤ.Ⴈ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 41, 44), 0, 94, 127), P_0, 'γ', 'Ϟ');
				num = 3;
				continue;
				end_IL_002d:
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
					num3 = (flag ? 5 : 0);
					goto IL_00cf;
				case 1:
				case 5:
				case 6:
					Monitor.Exit(ⴐ);
					break;
				case 0:
					break;
				}
				break;
				IL_00cf:
				num2 = num3;
			}
		}
		return 4 switch
		{
			_ => flag2, 
		};
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
				ႥႥ.ႤႨ(ⴐ = Ⴐ, ref flag, 735, 686);
				try
				{
					int num = 5;
					while (true)
					{
						switch (num)
						{
						case 0:
						case 2:
							flag2 = true;
							goto end_IL_006a;
						case 4:
							goto end_IL_006a;
						}
						HighlightCountyCfg.ႷႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 858, 863), 0, 747, 714), sql, ClientCty.Ⴗ('L', 7, 307013276), 99, 10);
						num = 0;
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
			int num2 = 0;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 1 : (ⴀႠ[78] - 14984));
					goto IL_0108;
				case 6:
					Monitor.Exit(ⴐ);
					break;
				case 1:
					break;
				}
				break;
				IL_0108:
				num2 = num3;
			}
		}
		return 2 switch
		{
			_ => flag2, 
		};
	}

	public DataRow[] GetDataRows(string filter)
	{
		ICloneable cloneable = TelnetServerCfg.Ⴗ(filter, SqlFilterType.Dx, 'P', 114);
		return ႥႠ.Ⴓ(DataSet, 402, 407)[0].Select(cloneable as string);
	}

	[SecuritySafeCritical]
	static WxCache()
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				ArcClientConnectDat.Ⴍ();
				goto case 3;
			case 3:
				Ⴍ = HighlightItuZoneCfg.Ⴓ(WxFilters.Ⴀ(null, 4, 103388443), 702, 654);
				break;
			case 0:
			case 2:
				break;
			case 1:
				Ⴐ = new object();
				return;
			}
			num = 1;
		}
	}
}
