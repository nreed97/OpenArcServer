using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public sealed class WwvCache
{
	private static readonly ILog m_Ⴈ;

	private static readonly object Ⴄ;

	private int m_Ⴅ = 1;

	private DataSet Ⴍ;

	private DxccCacheData.ႷႭ Ⴃ = new DxccCacheData.ႷႭ();

	public DataSet DataSet
	{
		get
		{
			return Ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	[SpecialName]
	internal bool Ⴀ()
	{
		bool ⴐ = Ⴃ.Ⴐ;
		HighlightCtyCfg.ႠႠ[15] = (char)((HighlightCtyCfg.ႠႠ[15] + HighlightCtyCfg.ႠႠ[127]) & 0xC5);
		return ⴐ;
	}

	[SpecialName]
	internal void Ⴈ(bool P_0)
	{
		bool ⴐ = P_0;
		Ⴃ.Ⴐ = ⴐ;
	}

	internal WwvCache()
	{
		DataSet = new DataSet();
		bool flag = false;
		object ⴄ = default(object);
		try
		{
			ႥႥ.ႤႨ(ⴄ = Ⴄ, ref flag, 33, 80);
			TelnetServerCfg.Ⴃ(ႥႠ.Ⴓ(DataSet, 669, 664), new DataTable(WxFilters.Ⴀ(null, 4, 103387487)), 'Ƚ', 543);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 644, 641), 0, 990, 1023), 713, 'ˀ'), new DataColumn(WxFilters.Ⴀ(null, 1, 103387733), typeof(int)), 617, 550);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 977, 980), 0, 803, 770), 775, '\u030e'), new DataColumn(ႥႥ.Ⴅ(1673508667, null, 8), typeof(string)), 177, 254);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 500, 497), 0, 374, 343), 953, 'ΰ'), new DataColumn(WxFilters.Ⴀ(null, 8, 103387477), typeof(string)), 894, 817);
			ႥႷ.Ⴓ(ႥႭ.ႳႷ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 846, 843), 0, 946, 915), 111, 'f'), new DataColumn(ႥႥ.Ⴅ(1673508810, null, 3), typeof(string)), 883, 828);
			WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 452, 449), 0, 251, 218).Columns.Add(new DataColumn(WxFilters.Ⴀ(null, 0, 103387457), typeof(string)));
			DataSet.Tables[0].Columns.Add(new DataColumn(ႥႥ.Ⴅ(1673508195, null, 4), typeof(string)));
			DataSet.Tables[0].Columns.Add(new DataColumn(WxFilters.Ⴀ(null, 0, 103387650), typeof(string)));
			DataSet.Tables[0].Columns.Add(new DataColumn(WxFilters.Ⴀ(null, 7, 103387704), typeof(DateTime)));
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(ⴄ);
			}
		}
	}

	internal bool Ⴅ(WwvSpot P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		try
		{
			switch (0)
			{
			default:
			{
				bool flag = false;
				object ⴄ2 = default(object);
				try
				{
					int num = 7;
					object obj = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							ႥႥ.ႤႨ(ⴄ2 = Ⴄ, ref flag, 398, 511);
							obj = ႥႠ.Ⴜ(WxFilters.ႭႷ(ႥႠ.Ⴓ(DataSet, 558, 555), 0, 688, 657), 28, 118);
							num = ⴀႠ[34] - 62564;
							continue;
						case 0:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, WxFilters.Ⴀ(null, 8, 103387740), (object)this.m_Ⴅ++, (short)632, 608);
							num = ⴗ[128] - 43519;
							continue;
						case 4:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ႥႥ.Ⴅ(1673508658, null, 1), (object)DxccCacheData.ႷႨ(P_0, 'ŉ', 381), (short)43, 51);
							num = ⴀႠ[70] - 49238;
							continue;
						case 10:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, WxFilters.Ⴀ(null, 1, 103387484), (object)DxccCacheData.ႷႨ(P_0, 'ɛ', 622), (short)974, 982);
							num = ⴄ[123] - 61746;
							continue;
						case 5:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ႥႥ.Ⴅ(1673508810, null, 3), (object)HighlightItuZoneCfg.ႳႳ(P_0, 990, 985), (short)228, 252);
							num = 2;
							continue;
						case 1:
						case 2:
							HighlightCqZoneCfg.Ⴗ((DataRow)obj, WxFilters.Ⴀ(null, 7, 103387462), (object)HighlightStateCfg.Ⴜ(P_0, 'Ɣ', 390), (short)713, 721);
							num = 13;
							continue;
						case 13:
							HighlightCqZoneCfg.Ⴗ(obj as DataRow, ႥႥ.Ⴅ(1673508198, null, 1), (object)DxccCacheData.ႷႨ(P_0, 'ȭ', 539), (short)458, 466);
							num = 11;
							continue;
						case 11:
							(obj as DataRow)[WxFilters.Ⴀ(null, 5, 103387655)] = P_0.SpotterNode;
							num = 8;
							continue;
						case 8:
						case 9:
							(obj as DataRow)[WxFilters.Ⴀ(null, 4, 103387707)] = P_0.Dts;
							num = 12;
							continue;
						case 12:
							DataSet.Tables[0].Rows.Add(obj as DataRow);
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
							num3 = ((!flag) ? (ⴄ[74] - 30099) : 3);
							goto IL_02e8;
						case 3:
						case 5:
							Monitor.Exit(ⴄ2);
							break;
						case 1:
							break;
						}
						break;
						IL_02e8:
						num2 = num3;
					}
				}
				switch (0)
				{
				default:
					Ⴈ(true);
					break;
				case 2:
					break;
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			WwvCache.m_Ⴈ.Error((ex as Exception).Message);
		}
		return 2 switch
		{
			_ => true, 
		};
	}

	public DataRow[] GetDataRows(string filter)
	{
		IEnumerable enumerable = TelnetServerCfg.Ⴗ(filter, SqlFilterType.Dx, '\u0001', 35);
		DataRow[] result = ႥႠ.Ⴓ(DataSet, 471, 466)[0].Select((string)enumerable);
		UserCmd.Ⴅ[197] = (byte)(UserCmd.Ⴅ[197] & UserCmd.Ⴅ[363] & 0xC);
		return result;
	}

	[SecuritySafeCritical]
	static WwvCache()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				ArcClientConnectDat.Ⴍ();
				break;
			case 1:
			case 4:
				break;
			case 2:
			case 3:
				Ⴄ = new object();
				return;
			}
			WwvCache.m_Ⴈ = HighlightItuZoneCfg.Ⴓ(ClientCty.Ⴗ('\u0087', 5, 307012761), 674, 658);
			num = ⴀႠ[103] - 38476;
		}
	}
}
