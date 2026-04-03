using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Filters;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using WeifenLuo.WinFormsUI.Docking;
using Ⴀ;

namespace ArcClientEngine.ArcForms;

public class AnnWindow : DockContent
{
	private BindingSource Ⴅ;

	private static readonly object Ⴀ;

	private string Ⴗ = string.Empty;

	internal DataGridView Ⴓ;

	private string Ⴐ;

	private ႥႤ.Ⴄ m_Ⴄ = new ႥႤ.Ⴄ();

	public string Filter
	{
		get
		{
			byte[] ⴅ = UserCmd.Ⴅ;
			return Ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	public string FilterName
	{
		get
		{
			return Ⴗ;
		}
		set
		{
			Ⴗ = value;
			Text = DxFilters.Ⴈ(WxFilters.Ⴀ(null, 1, 103388795), value, 235, 179);
		}
	}

	public AnnWindow()
	{
		ႳႷ();
	}

	public void Init(ArcClientObjMgr om)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 26;
		DataGridViewColumn dataGridViewColumn = default(DataGridViewColumn);
		object obj6 = default(object);
		DataGridViewColumn dataGridViewColumn4 = default(DataGridViewColumn);
		object obj5 = default(object);
		DataGridViewColumn dataGridViewColumn3 = default(DataGridViewColumn);
		object obj4 = default(object);
		object obj3 = default(object);
		DataGridViewColumn dataGridViewColumn2 = default(DataGridViewColumn);
		int num2 = default(int);
		ISupportInitialize supportInitialize = default(ISupportInitialize);
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			switch (num)
			{
			default:
				this.m_Ⴄ.Ⴐ = om as ArcClientObjMgr;
				ArcClientConnectDat.Ⴈ(Ⴓ, false, 277, 'ğ');
				num = ⴀႠ[96] - 2550;
				break;
			case 35:
				dataGridViewColumn = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 6, 103387730), (short)741, 719);
				num = 54;
				break;
			case 54:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, WxFilters.Ⴀ(null, 6, 103387730), (short)187, (short)159);
				num = ⴗ[140] - 60642;
				break;
			case 43:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, WxFilters.Ⴀ(null, 6, 103387730), (short)860, (short)889);
				num = 23;
				break;
			case 23:
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, ClientCty.Ⴗ('\u0015', 7, 307013426), (short)669, 694);
				num = 13;
				break;
			case 13:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), 55, 845, '\u0345');
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴓ, 574, 523), (DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, '\u033f', '\u034d');
				num = 31;
				break;
			case 31:
				obj6 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj6 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673508168, null, 4), (short)180, 158);
				num = ⴄ[15] - 23813;
				break;
			case 51:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj6, ႥႥ.Ⴅ(1673508168, null, 4), (short)133, (short)161);
				num = 27;
				break;
			case 27:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj6 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673508172, null, 0), (short)416, (short)389);
				num = ⴀႠ[20] - 33353;
				break;
			case 47:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj6 as DataGridViewTextBoxColumn), 50, 874, '\u0362');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj6 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 3, 103388798), (short)496, 475);
				num = 10;
				break;
			case 10:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴓ, 893, 840), (DataGridViewColumn)(DataGridViewTextBoxColumn)obj6, 'Î', '¼');
				num = 4;
				break;
			case 4:
				dataGridViewColumn4 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn4, WxFilters.Ⴀ(null, 5, 103387677), (short)934, 908);
				num = ⴀႠ[64] - 42636;
				break;
			case 36:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn4 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 6, 103387678), (short)448, (short)484);
				num = ⴗ[66] - 45116;
				break;
			case 7:
			case 38:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn4, WxFilters.Ⴀ(null, 0, 103387672), (short)359, (short)322);
				num = ⴀႠ[86] - 44433;
				break;
			case 19:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(dataGridViewColumn4 as DataGridViewTextBoxColumn), 600, 979, 'ϛ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn4 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(8, 1580609143, '"', null), (short)809, 770);
				num = 8;
				break;
			case 8:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴓ, 623, 602), (DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn4, 'ǃ', 'Ʊ');
				num = ⴅ[25];
				break;
			case 2:
				obj5 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj5, ႥႥ.Ⴅ(1673508108, null, 2), (short)401, 443);
				num = ⴄ[139] - 9584;
				break;
			case 48:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj5, ႥႥ.Ⴅ(1673508104, null, 6), (short)418, (short)390);
				num = 11;
				break;
			case 11:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj5, ႥႥ.Ⴅ(1673508106, null, 4), (short)830, (short)795);
				num = 40;
				break;
			case 40:
				HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(obj5 as DataGridViewTextBoxColumn), (short)3, 'm'), DataGridViewContentAlignment.MiddleCenter, 'ɗ', 566);
				num = ⴗ[134] - 12441;
				break;
			case 42:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj5, 45, 74, 'B');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj5 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 0, 103387319), (short)308, 287);
				num = 44;
				break;
			case 44:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴓ, 732, 745), (DataGridViewColumn)(obj5 as DataGridViewTextBoxColumn), 'Ǎ', 'ƿ');
				num = 46;
				break;
			case 46:
				dataGridViewColumn3 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn3, ႥႥ.Ⴅ(1673508209, null, 8), (short)623, 581);
				num = ⴄ[114];
				break;
			case 22:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn3 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673508222, null, 7), (short)965, (short)993);
				num = 15;
				break;
			case 15:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn3 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673508222, null, 7), (short)569, (short)540);
				num = 39;
				break;
			case 39:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn3, 45, 541, 'ȕ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn3 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(6, 1580608672, 'J', null), (short)261, 302);
				num = ⴗ[103] - 55674;
				break;
			case 17:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴓ, 344, 365), (DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn3, 'ɰ', 'Ȃ');
				num = 37;
				break;
			case 37:
				obj4 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj4 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 6, 103387658), (short)288, 266);
				num = 6;
				break;
			case 6:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj4, WxFilters.Ⴀ(null, 4, 103387656), (short)468, (short)496);
				num = ⴀႠ[93] - 27713;
				break;
			case 52:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj4 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 5, 103387657), (short)393, (short)428);
				num = 33;
				break;
			case 33:
				HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(DataGridViewTextBoxColumn)obj4, (short)635, 'ȕ'), DataGridViewContentAlignment.MiddleCenter, '\u031c', 893);
				num = 30;
				break;
			case 30:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj4, 45, 233, 'á');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj4, ClientCty.Ⴗ('>', 2, 307012718), (short)91, 112);
				num = 55;
				break;
			case 55:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴓ, 483, 470), (DataGridViewColumn)(obj4 as DataGridViewTextBoxColumn), '\u02f5', 'ʇ');
				num = 0;
				break;
			case 0:
				obj3 = new DataGridViewLinkColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewLinkColumn)obj3, WxFilters.Ⴀ(null, 5, 103387655), (short)652, 678);
				num = 3;
				break;
			case 3:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewLinkColumn)obj3, WxFilters.Ⴀ(null, 1, 103387651), (short)1009, (short)981);
				num = 9;
				break;
			case 9:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewLinkColumn)obj3, WxFilters.Ⴀ(null, 3, 103387649), (short)299, (short)270);
				num = 49;
				break;
			case 49:
				global::Ⴀ.ႳႰ.Ⴓ(obj3 as DataGridViewLinkColumn, false, 307, 317);
				HighlightItuZoneCfg.ႳႣ(obj3 as DataGridViewLinkColumn, ClientCfg.Ⴍ(629, 537), 684, 732);
				num = 56;
				break;
			case 56:
				ArcClientConnectDat.ႷႷ(obj3 as DataGridViewLinkColumn, LinkBehavior.HoverUnderline, 'ș', 639);
				HighlightItuZoneCfg.ႳႣ((DataGridViewLinkColumn)obj3, DxEmailCfg.Ⴍ(657, 743), 850, 803);
				num = ⴀႠ[103] - 38450;
				break;
			case 29:
				WxFilters.ႭႰ((DataGridViewLinkColumn)obj3, true, 340, 353);
				ႥႥ.ႤႳ((DataGridViewLinkColumn)obj3, ClientCfg.Ⴍ(884, 793), 'l', 94);
				num = 53;
				break;
			case 53:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewLinkColumn)obj3, 75, 665, 'ʑ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewLinkColumn)obj3, ႥႥ.Ⴍ(8, 1580609520, '@', null), (short)279, 316);
				num = 34;
				break;
			case 34:
				Ⴓ.Columns.Add(obj3 as DataGridViewLinkColumn);
				dataGridViewColumn2 = new DataGridViewTextBoxColumn();
				(dataGridViewColumn2 as DataGridViewTextBoxColumn).HeaderText = ႥႥ.Ⴅ(1673507918, null, 2);
				num = 32;
				break;
			case 32:
				((DataGridViewTextBoxColumn)dataGridViewColumn2).Name = ႥႥ.Ⴅ(1673507914, null, 6);
				((DataGridViewTextBoxColumn)dataGridViewColumn2).DataPropertyName = WxFilters.Ⴀ(null, 0, 103387711);
				num = 57;
				break;
			case 57:
				((DataGridViewTextBoxColumn)dataGridViewColumn2).DefaultCellStyle.Format = ClientCty.Ⴗ('Ç', 4, 307012903);
				(dataGridViewColumn2 as DataGridViewTextBoxColumn).Width = 140;
				num = 14;
				break;
			case 14:
				(dataGridViewColumn2 as DataGridViewTextBoxColumn).ToolTipText = ClientCty.Ⴗ('\u0016', 7, 307013411);
				Ⴓ.Columns.Add(dataGridViewColumn2 as DataGridViewTextBoxColumn);
				num = 16;
				break;
			case 16:
				num2 = 0;
				num = 45;
				break;
			case 1:
				Ⴓ.Columns[num2].SortMode = DataGridViewColumnSortMode.Programmatic;
				num2++;
				num = 45;
				break;
			case 45:
				num = ((num2 < Ⴓ.Columns.Count - 1) ? (ⴄ[91] - 47816) : 18);
				break;
			case 18:
				this.m_Ⴄ.Ⴐ.Caches.Ann.DataSet.Tables[0].Locale = CultureInfo.InvariantCulture;
				num = ⴀႠ[127] - 350;
				break;
			case 21:
				supportInitialize = new DataView(this.m_Ⴄ.Ⴐ.Caches.Ann.DataSet.Tables[0]);
				num = 12;
				break;
			case 12:
			{
				IList list = new BindingSource();
				((BindingSource)list).DataSource = (DataView)supportInitialize;
				Ⴅ = (BindingSource)list;
				num = ⴀႠ[90] - 47313;
				break;
			}
			case 58:
				convertible = UtilsSql.FormatSqlFilter(Filter, SqlFilterType.AnnWx);
				Ⴅ.Filter = Filter;
				num = 28;
				break;
			case 28:
			{
				Ⴓ.DataSource = Ⴅ;
				object obj2 = new DgvFilterManager(Ⴓ);
				this.m_Ⴄ.Ⴄ = (DgvFilterManager)obj2;
				goto case 5;
			}
			case 5:
				num = 50;
				break;
			case 50:
				this.m_Ⴄ.Ⴄ.BaseFilter = convertible as string;
				this.m_Ⴄ.Ⴄ[ႥႥ.Ⴅ(1673507918, null, 2)] = new DgvTextBoxColumnFilter();
				num = 20;
				break;
			case 20:
				this.m_Ⴄ.Ⴄ.FilterChanged += Ⴜ;
				this.m_Ⴄ.Ⴄ.FilterSaved += Ⴄ;
				num = 25;
				break;
			case 25:
			{
				object obj = new DataGridViewColumnSelector(Ⴓ);
				((DataGridViewColumnSelector)obj).MaxHeight = 200;
				(obj as DataGridViewColumnSelector).Width = 110;
				goto case 24;
			}
			case 24:
				num = 41;
				break;
			case 41:
				Ⴜ(null, Filter);
				return;
			}
		}
	}

	private void Ⴄ(object P_0, string P_1)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_1 = ShowDxFilter.Ⴗ(P_1, 509, 'ǁ');
				obj = new FilterEditor(this.m_Ⴄ.Ⴐ, FilterType.DX);
				goto case 4;
			case 4:
				num = ⴀႠ[4] - 3449;
				break;
			case 3:
				(obj as FilterEditor).Filter = P_1;
				FilterPicker.ႥႷ((Form)(obj as FilterEditor), 'Ȋ', (short)589);
				num = 7;
				break;
			case 7:
				num = ((FilterPicker.ႥႷ((Form)(FilterEditor)obj, 'Ǌ', (short)386) != DialogResult.OK) ? 5 : (ⴀႠ[78] - 14990));
				break;
			case 0:
			case 6:
				this.m_Ⴄ.Ⴐ.Cfg.Filters.Ann.List.Add(new AnnFilter(((FilterEditor)obj).FilterName, (obj as FilterEditor).Filter));
				return;
			case 2:
			case 5:
				return;
			}
		}
	}

	private void Ⴜ(object P_0, string P_1)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 5:
				ႥႠ.ႭႤ((Control)this, DxFilters.Ⴈ(WxFilters.Ⴀ(null, 0, 103388794), FilterName, 904, 976), 'ϔ', 'δ');
				goto case 2;
			case 2:
				num = 4;
				continue;
			case 0:
			case 4:
				SetDxExtension.Ⴃ((DockContent)this, FilterPicker.ႥႠ(WxFilters.Ⴀ(null, 2, 103387497), FilterName, ႥႥ.Ⴅ(1673508807, null, 4), P_1, 336, 298), (short)969, 'δ');
				return;
			case 1:
				return;
			}
			P_1 = ShowDxFilter.Ⴗ(P_1, 751, '\u02d3');
			if (global::Ⴀ.ႳႳ.Ⴓ(FilterName, '\u0315', 819) > 0)
			{
				num = 5;
				continue;
			}
			while (true)
			{
				int num2 = ((global::Ⴀ.ႳႳ.Ⴓ(P_1, 'ȸ', 542) <= 0) ? 5 : (ⴀႠ[38] - 28691));
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 0:
					case 3:
					case 4:
						break;
					case 6:
						goto IL_0124;
					case 1:
					case 2:
						base.ToolTipText = WxFilters.Ⴀ(null, 2, 103387411) + P_1;
						return;
					case 5:
						Text = ClientCty.Ⴗ('b', 2, 307013011);
						base.ToolTipText = ႥႥ.Ⴅ(1673508831, null, 6);
						return;
					}
					break;
					IL_0124:
					ႥႠ.ႭႤ((Control)this, DxFilters.Ⴈ(WxFilters.Ⴀ(null, 4, 103388798), P_1, 884, 812), '"', 'B');
					num2 = 2;
				}
			}
		}
	}

	private void ႳႨ(object P_0, FormClosingEventArgs P_1)
	{
		SaveGridState();
	}

	public void SaveGridState()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		IEnumerable enumerable = new StringCollection();
		int num = 0;
		object obj = DxSpotRateGraph.Ⴅ((BaseCollection)HighlightCountyCfg.ႷႣ(Ⴓ, 471, 482), (short)351, (short)380);
		try
		{
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 5:
				{
					IComponent component = (DataGridViewColumn)((IEnumerator)obj).Current;
					StringCollection obj2 = (StringCollection)enumerable;
					string format = WxFilters.Ⴀ(null, 7, 103387419);
					Array array = new object[4];
					object[] obj3 = array as object[];
					int num3 = ShowUsers.Ⴈ(component as DataGridViewColumn, 1001, 991);
					obj3[0] = HighlightArrlSectionCfg.Ⴅ(ref num3, ClientCty.Ⴗ('\u0083', 8, 307012769), 618, 581);
					((object[])array)[1] = ShowUsers.Ⴈ(component as DataGridViewColumn, 144, 167);
					(array as object[])[2] = HighlightCqZoneCfg.Ⴜ((DataGridViewBand)(component as DataGridViewColumn), 383, (short)298);
					((object[])array)[3] = num++;
					obj2.Add(string.Format(format, (object[])array));
					num2 = 0;
					break;
				}
				default:
					num2 = ((obj as IEnumerator).MoveNext() ? (ⴄ[34] - 61632) : (ⴀႠ[38] - 28695));
					break;
				case 2:
				case 3:
					return;
				}
			}
		}
		finally
		{
			int num4 = 4;
			object obj4 = default(object);
			while (true)
			{
				int num5;
				switch (num4)
				{
				default:
					obj4 = ((IEnumerator)obj) as IDisposable;
					goto case 3;
				case 3:
					num5 = ((obj4 is IDisposable) ? 2 : 0);
					goto IL_01ac;
				case 1:
				case 2:
				case 5:
					(obj4 as IDisposable).Dispose();
					break;
				case 0:
					break;
				}
				break;
				IL_01ac:
				num4 = num5;
			}
		}
	}

	public void AutoScrollGrid()
	{
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
			{
				int num2 = SkimmerSpotRateGraph.ႤႤ(Ⴓ, 325, 'ĺ');
				Bye.Ⴄ[12] = (char)((Bye.Ⴄ[12] - Bye.Ⴄ[267]) & 0x53);
				num = ((num2 <= 0) ? 6 : 2);
				break;
			}
			case 2:
				HighlightItuZoneCfg.ႳႤ(Ⴓ, SkimmerSpotRateGraph.ႤႤ(Ⴓ, 270, 'ű') - 1, 1015, 'Ω');
				goto case 3;
			case 3:
				num = 1;
				break;
			case 0:
			case 1:
				ShowUsers.Ⴄ(Ⴓ, 116, 'F');
				ClientCfg.Ⴜ(Ⴓ, ',', 38)[Ⴓ.RowCount - 1].Selected = true;
				num = 4;
				break;
			case 4:
			case 7:
				Ⴓ.ClearSelection();
				return;
			case 6:
				return;
			}
		}
	}

	private void ႳႳ(object P_0, DataGridViewCellEventArgs P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 2;
		DataGridViewBand dataGridViewBand = default(DataGridViewBand);
		IEquatable<string> equatable = default(IEquatable<string>);
		IEnumerable<char> noSsidCall2 = default(IEnumerable<char>);
		ICloneable noSsidCall = default(ICloneable);
		while (true)
		{
			switch (num)
			{
			case 0:
				return;
			}
			UserInfo.Ⴜ((Control)this, HighlightSpotterCfg.Ⴗ('ƫ', 511), (short)947, 'Χ');
			if (FilterViewer.ႨႤ(P_1, 963, 977) < 0)
			{
				num = ⴀႠ[21] - ⴀႠ[21];
				continue;
			}
			while (true)
			{
				IComparable comparable = TelnetServerCfg.Ⴀ(SetDxFilter.Ⴍ(HighlightCountyCfg.ႷႣ(Ⴓ, 343, 354), HighlightCqZoneCfg.ႣႷ(P_1, '\u038b', 'Ϲ'), 755, 'ˊ'), 914, 'ΰ');
				int num2 = 6;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 1:
						break;
					case 6:
						dataGridViewBand = HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(Ⴓ, 'ə', 595), FilterViewer.ႨႤ(P_1, 529, 515), 'ˇ', 'ʆ');
						num2 = 14;
						continue;
					case 14:
						num2 = (((equatable = comparable as string) == null) ? (ⴅ[175] - 54) : 4);
						continue;
					case 4:
						num2 = (DxCommentExtCfg.ႤႰ((string)equatable, ႥႥ.Ⴅ(1673508195, null, 4), 'Ù', 255) ? 5 : 2);
						continue;
					case 2:
						num2 = (DxCommentExtCfg.ႤႰ((string)equatable, WxFilters.Ⴀ(null, 8, 103387658), 'Ϫ', 972) ? (ⴀႠ[62] - 58860) : (ⴄ[167] - 39502));
						continue;
					case 10:
						num2 = 11;
						continue;
					case 5:
					case 7:
						noSsidCall2 = UtilsCallsign.GetNoSsidCall(DxSpotRates.ႠႳ(HighlightCallCfg.Ⴓ(dataGridViewBand as DataGridViewRow, 7, 'q'), WxFilters.Ⴀ(null, 2, 103387822), 473, 434).Value.ToString());
						num2 = 13;
						continue;
					case 13:
						Process.Start(ႥႥ.Ⴍ(8, 1580609310, 'n', null) + (string)noSsidCall2);
						num2 = ⴀႠ[86] - 44441;
						continue;
					case 12:
						noSsidCall = UtilsCallsign.GetNoSsidCall(((DataGridViewRow)dataGridViewBand).Cells[ႥႥ.Ⴅ(1673508199, null, 0)].Value.ToString());
						num2 = ⴄ[262] - 58204;
						continue;
					case 8:
						Process.Start(ႥႥ.Ⴍ(3, 1580609301, 'x', null) + (noSsidCall as string));
						num2 = ⴄ[10] - 7008;
						continue;
					case 0:
					case 11:
						Cursor = Cursors.Default;
						return;
					}
					break;
				}
			}
		}
	}

	private void ႳႣ(object P_0, DataGridViewDataErrorEventArgs P_1)
	{
		HighlightItuZoneCfg.ႳႠ(P_1, false, 596, 'ȕ');
	}

	private void ႳႠ(object P_0, DataGridViewCellFormattingEventArgs P_1)
	{
	}

	private void ႳႰ(object P_0, DataGridViewCellEventArgs P_1)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 7;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			switch (num)
			{
			default:
				num = ((FilterViewer.ႨႤ(P_1, 325, 343) < 0) ? 6 : (ⴅ[71] / 5));
				break;
			case 4:
			case 5:
				num = ((FilterViewer.ႨႤ(P_1, 589, 607) >= DxSpotRates.ႠႤ(ClientCfg.Ⴜ(Ⴓ, '\u032b', 801), 297, 354)) ? 6 : (ⴅ[8] - 35));
				break;
			case 3:
				num = ((HighlightCqZoneCfg.ႣႷ(P_1, '\v', 'y') < 0) ? 6 : 2);
				break;
			case 0:
			case 1:
			case 2:
				if (HighlightCqZoneCfg.ႣႷ(P_1, '\u02d5', 'ʧ') >= SkimmerSpotRateGraph.ႤႣ((BaseCollection)HighlightCountyCfg.ႷႣ(Ⴓ, 508, 457), 'Ƿ', 436))
				{
					num = ⴅ[95] - 187;
					break;
				}
				while (true)
				{
					DataGridViewCell dataGridViewCell = HighlightCallCfg.Ⴓ(HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(Ⴓ, 'Ã', 201), FilterViewer.ႨႤ(P_1, 258, 272), '\u02f0', 'ʱ'), 379, 'č')[P_1.ColumnIndex] as DataGridViewLinkCell;
					int num2 = 5;
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 7:
							break;
						case 5:
							num2 = ((!(dataGridViewCell is DataGridViewLinkCell)) ? 3 : (ⴀႠ[125] - 26169));
							continue;
						case 6:
							cloneable = (dataGridViewCell as DataGridViewLinkCell).Value.ToString();
							num2 = ((!(cloneable is string)) ? 3 : 4);
							continue;
						case 4:
						case 8:
							cloneable = UtilsCallsign.GetNoSsidCall((string)cloneable);
							goto case 2;
						case 2:
							cloneable = UtilsCallsign.ScrubCall(cloneable as string);
							num2 = (((cloneable as string).Length <= 0) ? (ⴗ[0] - 29156) : (ⴗ[12] - 300));
							continue;
						case 1:
							Process.Start(ClientCty.Ⴗ('9', 2, 307012937) + (string)cloneable);
							num2 = ⴅ[160] - ⴅ[93];
							continue;
						case 3:
						case 9:
							return;
						}
						break;
					}
				}
			case 6:
				return;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? 6 : 2);
				continue;
			case 0:
			case 2:
				num = ((this.m_Ⴄ.Ⴈ == null) ? (ⴄ[143] - 48970) : 4);
				continue;
			case 4:
				this.m_Ⴄ.Ⴈ.Dispose();
				break;
			case 5:
			case 6:
				break;
			case 3:
				return;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void ႳႷ()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 30;
		object obj3 = default(object);
		ICloneable cloneable = default(ICloneable);
		object obj2 = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj3 = new DataGridViewCellStyle();
				cloneable = new DataGridViewCellStyle();
				obj2 = new DataGridViewCellStyle();
				obj = new DataGridViewCellStyle();
				Ⴓ = new DataGridView();
				num = 21;
				break;
			case 21:
				((ISupportInitialize)Ⴓ).BeginInit();
				AnnFilters.Ⴓ((Control)this, '³', '¬');
				DxSpotRates.ႠႠ(Ⴓ, false, 494, 457);
				num = ⴗ[106] - 22860;
				break;
			case 3:
				DxSpotRates.ႠႠ(Ⴓ, false, 793, 817);
				ArcClientConnectDat.Ⴈ(Ⴓ, true, 395, 'ƃ');
				num = ⴗ[98] - 39623;
				break;
			case 23:
				DxSpotRates.ႠႠ(Ⴓ, false, 365, 324);
				global::Ⴀ.ႳႰ.Ⴃ((DataGridViewCellStyle)obj3, ClientCfg.Ⴍ(288, 332), 484, 433);
				goto case 5;
			case 5:
				num = 25;
				break;
			case 25:
				global::Ⴀ.ႳႰ.Ⴃ(obj3 as DataGridViewCellStyle, DxEmailCfg.Ⴍ(30, 105), 800, 886);
				num = 13;
				break;
			case 13:
				DxSpotRates.ႠႭ(Ⴓ, (DataGridViewCellStyle)obj3, 844, 850);
				HighlightCfg.ႳႰ(cloneable as DataGridViewCellStyle, DataGridViewContentAlignment.MiddleLeft, 'Ʉ', 549);
				num = 24;
				break;
			case 24:
				DxccCacheData.ႷႳ((DataGridViewCellStyle)cloneable, HighlightItuZoneCfg.ႳႷ(45, 73), 636, 'ɟ');
				num = ⴄ[300] - 46351;
				break;
			case 27:
				DxSpotRateGraph.Ⴗ(cloneable as DataGridViewCellStyle, new Font(ႥႥ.Ⴅ(1673508257, null, 4), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), '_', 24);
				num = 1;
				break;
			case 1:
				DxSpotRates.ႠႨ(cloneable as DataGridViewCellStyle, HighlightItuZoneCfg.ႳႷ(896, 997), 'Ţ', 313);
				num = 32;
				break;
			case 32:
				global::Ⴀ.ႳႰ.Ⴃ((DataGridViewCellStyle)cloneable, ClientCfg.Ⴍ(496, 412), 264, 349);
				num = 22;
				break;
			case 22:
				global::Ⴀ.ႳႰ.Ⴃ(cloneable as DataGridViewCellStyle, DxEmailCfg.Ⴍ(401, 486), 877, 827);
				goto case 19;
			case 19:
				num = ⴄ[54] - 40500;
				break;
			case 29:
				ArcClientConnectDat.ႷႭ((DataGridViewCellStyle)cloneable, DataGridViewTriState.True, 147, 'ñ');
				HighlightCountyCfg.ႷႠ(Ⴓ, cloneable as DataGridViewCellStyle, 676, 657);
				num = ⴀႠ[75] - 37463;
				break;
			case 14:
				global::Ⴀ.ႳႳ.Ⴅ(Ⴓ, DataGridViewColumnHeadersHeightSizeMode.AutoSize, 'ϥ', 1001);
				HighlightCfg.ႳႰ((DataGridViewCellStyle)obj2, DataGridViewContentAlignment.MiddleLeft, 'ʖ', 759);
				num = ⴗ[54] - 48784;
				break;
			case 15:
				DxccCacheData.ႷႳ((DataGridViewCellStyle)obj2, HighlightCallCfg.Ⴄ(493, 491), 612, 'ɇ');
				num = 9;
				break;
			case 9:
				DxSpotRateGraph.Ⴗ(obj2 as DataGridViewCellStyle, new Font(WxFilters.Ⴀ(null, 1, 103387620), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), '/', 104);
				num = ⴀႠ[99] - 46016;
				break;
			case 8:
				DxSpotRates.ႠႨ((DataGridViewCellStyle)obj2, HighlightItuZoneCfg.ႳႷ(310, 336), 'Ϣ', 953);
				num = 4;
				break;
			case 4:
				global::Ⴀ.ႳႰ.Ⴃ((DataGridViewCellStyle)obj2, ClientCfg.Ⴍ(464, 444), 761, 684);
				num = ⴀႠ[4] - 3434;
				break;
			case 18:
				global::Ⴀ.ႳႰ.Ⴃ(obj2 as DataGridViewCellStyle, DxEmailCfg.Ⴍ(95, 40), 217, 143);
				num = 7;
				break;
			case 7:
				ArcClientConnectDat.ႷႭ(obj2 as DataGridViewCellStyle, DataGridViewTriState.False, 445, 'ǟ');
				goto case 28;
			case 28:
				HighlightCqZoneCfg.Ⴍ(Ⴓ, obj2 as DataGridViewCellStyle, 772, 826);
				num = ⴄ[129] - 52881;
				break;
			case 26:
				MultimediaCache.Ⴄ((Control)Ⴓ, DockStyle.Fill, 100, (short)89);
				HighlightCountyCfg.Ⴜ((Control)Ⴓ, new Point(0, 0), 760, 683);
				num = ⴅ[17];
				break;
			case 0:
				FilterEditor.ႷႤ(Ⴓ, false, 178, 251);
				Ⴓ.Name = ႥႥ.Ⴅ(1673508437, null, 1);
				num = ⴄ[163] - 58294;
				break;
			case 2:
				Ⴓ.ReadOnly = true;
				(obj as DataGridViewCellStyle).SelectionBackColor = Color.White;
				((DataGridViewCellStyle)obj).SelectionForeColor = Color.Black;
				num = 6;
				break;
			case 6:
				Ⴓ.RowsDefaultCellStyle = (DataGridViewCellStyle)obj;
				Ⴓ.RowTemplate.Height = 24;
				num = ⴗ[127] - 17844;
				break;
			case 20:
				Ⴓ.Size = new Size(598, 273);
				Ⴓ.TabIndex = 3;
				num = ⴀႠ[4] - 3435;
				break;
			case 17:
				Ⴓ.CellContentClick += ႳႰ;
				Ⴓ.CellContentDoubleClick += ႳႳ;
				num = ⴗ[158] - 28119;
				break;
			case 31:
				Ⴓ.CellFormatting += ႳႠ;
				Ⴓ.DataError += ႳႣ;
				num = ⴀႠ[86] - 44441;
				break;
			case 11:
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				base.AutoScaleMode = AutoScaleMode.Font;
				base.ClientSize = new Size(598, 273);
				num = ⴀႠ[86] - 44440;
				break;
			case 12:
				base.Controls.Add(Ⴓ);
				Font = new Font(ႥႥ.Ⴅ(1673508258, null, 7), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
				num = 16;
				break;
			case 16:
				base.Name = WxFilters.Ⴀ(null, 7, 103388688);
				Text = ClientCty.Ⴗ('j', 5, 307013012);
				num = 10;
				break;
			case 10:
				base.FormClosing += ႳႨ;
				((ISupportInitialize)Ⴓ).EndInit();
				ResumeLayout(performLayout: false);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static AnnWindow()
	{
		ArcClientConnectDat.Ⴍ();
		Ⴀ = new object();
	}
}
