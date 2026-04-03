using System;
using System.Collections;
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

public class WxWindow : DockContent
{
	private ArcClientObjMgr Ⴗ;

	private BindingSource Ⴓ;

	private static readonly object Ⴐ;

	private IContainer Ⴀ;

	internal DataGridView Ⴈ;

	private WxFilters.ႭႨ m_Ⴅ = new WxFilters.ႭႨ();

	public string Filter
	{
		get
		{
			return this.m_Ⴅ.Ⴈ;
		}
		set
		{
			this.m_Ⴅ.Ⴈ = value;
		}
	}

	public string FilterName
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			return this.m_Ⴅ.Ⴍ;
		}
		set
		{
			this.m_Ⴅ.Ⴍ = value;
			Text = DxFilters.Ⴈ(ႥႥ.Ⴅ(1673508424, null, 7), value, 569, 609);
		}
	}

	public WxWindow()
	{
		IEquatable<string> empty = string.Empty;
		this.m_Ⴅ.Ⴍ = (string)empty;
		base._002Ector();
		ႳႥ();
	}

	public void Init(ArcClientObjMgr om)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 43;
		DataGridViewColumn dataGridViewColumn = default(DataGridViewColumn);
		DataGridViewColumn dataGridViewColumn4 = default(DataGridViewColumn);
		object obj6 = default(object);
		DataGridViewColumn dataGridViewColumn3 = default(DataGridViewColumn);
		object obj5 = default(object);
		object obj4 = default(object);
		DataGridViewColumn dataGridViewColumn2 = default(DataGridViewColumn);
		object obj3 = default(object);
		int num2 = default(int);
		ISupportInitialize supportInitialize2 = default(ISupportInitialize);
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			switch (num)
			{
			default:
				Ⴗ = om;
				ArcClientConnectDat.Ⴈ(Ⴈ, false, 684, 'ʦ');
				num = ⴅ[220] / 5;
				break;
			case 20:
				dataGridViewColumn = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, WxFilters.Ⴀ(null, 7, 103387731), (short)664, 690);
				num = ⴗ[93] - 63484;
				break;
			case 35:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, WxFilters.Ⴀ(null, 6, 103387730), (short)227, (short)199);
				num = 8;
				break;
			case 8:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 2, 103387734), (short)39, (short)2);
				num = ⴀႠ[63] - 29197;
				break;
			case 3:
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), ClientCty.Ⴗ('ñ', 5, 307013424), (short)177, 154);
				num = 9;
				break;
			case 9:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, 55, 794, '\u0312');
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴈ, 620, 601), (DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, 'ί', 'ϝ');
				num = 26;
				break;
			case 26:
				dataGridViewColumn4 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn4 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673508170, null, 6), (short)159, 181);
				num = ⴄ[259] - 4843;
				break;
			case 57:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn4, ႥႥ.Ⴅ(1673508169, null, 5), (short)194, (short)230);
				num = ⴗ[12] - 271;
				break;
			case 30:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn4 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673508175, null, 3), (short)654, (short)683);
				num = 50;
				break;
			case 50:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(dataGridViewColumn4 as DataGridViewTextBoxColumn), 50, 823, '\u033f');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn4 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673508171, null, 7), (short)898, 937);
				num = 27;
				break;
			case 27:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴈ, 619, 606), (DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn4, 'I', ';');
				num = 1;
				break;
			case 1:
				obj6 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj6 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 8, 103387664), (short)906, 928);
				num = 48;
				break;
			case 48:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj6 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 7, 103387679), (short)174, (short)138);
				num = 41;
				break;
			case 41:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj6 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 1, 103387673), (short)998, (short)963);
				num = ⴗ[106] - 22807;
				break;
			case 56:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj6 as DataGridViewTextBoxColumn), 600, 503, 'ǿ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj6 as DataGridViewTextBoxColumn), ClientCty.Ⴗ('\u0011', 1, 307012916), (short)496, 475);
				num = 32;
				break;
			case 32:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴈ, 377, 332), (DataGridViewColumn)(obj6 as DataGridViewTextBoxColumn), 'Z', '(');
				num = 44;
				break;
			case 44:
				dataGridViewColumn3 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn3, ႥႥ.Ⴅ(1673508109, null, 3), (short)501, 479);
				num = ⴗ[147] - 45831;
				break;
			case 49:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn3, ႥႥ.Ⴅ(1673508111, null, 1), (short)697, (short)669);
				num = 37;
				break;
			case 37:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn3 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673508105, null, 7), (short)852, (short)881);
				num = 33;
				break;
			case 33:
				HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(DataGridViewTextBoxColumn)dataGridViewColumn3, (short)140, 'â'), DataGridViewContentAlignment.MiddleCenter, 'Ȋ', 619);
				num = 45;
				break;
			case 45:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn3, 45, 183, '¿');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn3 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 8, 103387327), (short)701, 662);
				num = 52;
				break;
			case 52:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴈ, 599, 610), (DataGridViewColumn)(dataGridViewColumn3 as DataGridViewTextBoxColumn), 'Ô', '¦');
				num = 10;
				break;
			case 10:
				obj5 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj5, ႥႥ.Ⴅ(1673508216, null, 1), (short)822, 796);
				num = ⴗ[113] - 53658;
				break;
			case 19:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj5, ႥႥ.Ⴅ(1673508223, null, 6), (short)1016, (short)988);
				num = 12;
				break;
			case 12:
			case 23:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj5, ႥႥ.Ⴅ(1673508222, null, 7), (short)586, (short)623);
				num = 53;
				break;
			case 53:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj5 as DataGridViewTextBoxColumn), 45, 680, 'ʠ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj5 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(0, 1580608678, '@', null), (short)205, 230);
				num = 13;
				break;
			case 13:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴈ, 639, 586), (DataGridViewColumn)(obj5 as DataGridViewTextBoxColumn), 'Ǝ', 'Ǽ');
				num = ⴀႠ[126] - 21843;
				break;
			case 51:
				obj4 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj4, WxFilters.Ⴀ(null, 0, 103387660), (short)896, 938);
				num = 34;
				break;
			case 34:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj4, WxFilters.Ⴀ(null, 8, 103387652), (short)125, (short)89);
				num = ⴄ[143] - 48971;
				break;
			case 5:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj4, WxFilters.Ⴀ(null, 6, 103387658), (short)176, (short)149);
				num = ⴄ[273] - 10891;
				break;
			case 21:
				HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(DataGridViewTextBoxColumn)obj4, (short)505, 'Ɨ'), DataGridViewContentAlignment.MiddleCenter, 'ɫ', 522);
				num = ⴗ[48] - 52959;
				break;
			case 2:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj4 as DataGridViewTextBoxColumn), 45, 582, 'Ɏ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj4, ClientCty.Ⴗ('i', 8, 307012708), (short)500, 479);
				num = 36;
				break;
			case 36:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴈ, 701, 648), (DataGridViewColumn)(DataGridViewTextBoxColumn)obj4, '\u00b8', 'Ê');
				num = 47;
				break;
			case 47:
				dataGridViewColumn2 = new DataGridViewLinkColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn2 as DataGridViewLinkColumn), WxFilters.Ⴀ(null, 8, 103387658), (short)781, 807);
				num = ⴄ[169] - 10924;
				break;
			case 15:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn2 as DataGridViewLinkColumn), WxFilters.Ⴀ(null, 5, 103387655), (short)805, (short)769);
				num = 31;
				break;
			case 31:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewLinkColumn)dataGridViewColumn2, WxFilters.Ⴀ(null, 6, 103387652), (short)747, (short)718);
				num = 16;
				break;
			case 16:
				ႳႰ.Ⴓ((DataGridViewLinkColumn)dataGridViewColumn2, false, 458, 452);
				HighlightItuZoneCfg.ႳႣ(dataGridViewColumn2 as DataGridViewLinkColumn, ClientCfg.Ⴍ(532, 632), 414, 494);
				num = 25;
				break;
			case 25:
				ArcClientConnectDat.ႷႷ((DataGridViewLinkColumn)dataGridViewColumn2, LinkBehavior.HoverUnderline, 'Ȑ', 630);
				HighlightItuZoneCfg.ႳႣ((DataGridViewLinkColumn)dataGridViewColumn2, DxEmailCfg.Ⴍ(742, 656), 588, 573);
				num = 4;
				break;
			case 4:
			case 22:
				WxFilters.ႭႰ((DataGridViewLinkColumn)dataGridViewColumn2, true, 231, 210);
				ႥႥ.ႤႳ((DataGridViewLinkColumn)dataGridViewColumn2, ClientCfg.Ⴍ(584, 549), 'Ƥ', 406);
				num = ⴅ[390] - 187;
				break;
			case 7:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewLinkColumn)dataGridViewColumn2, 75, 780, '\u0304');
				((DataGridViewLinkColumn)dataGridViewColumn2).ToolTipText = ႥႥ.Ⴍ(7, 1580609535, 'Y', null);
				num = 28;
				break;
			case 28:
				Ⴈ.Columns.Add(dataGridViewColumn2 as DataGridViewLinkColumn);
				obj3 = new DataGridViewTextBoxColumn();
				(obj3 as DataGridViewTextBoxColumn).HeaderText = ႥႥ.Ⴅ(1673507914, null, 6);
				num = ⴀႠ[88] - 30666;
				break;
			case 40:
				((DataGridViewTextBoxColumn)obj3).Name = ႥႥ.Ⴅ(1673507916, null, 0);
				((DataGridViewTextBoxColumn)obj3).DataPropertyName = WxFilters.Ⴀ(null, 3, 103387708);
				num = 18;
				break;
			case 18:
				(obj3 as DataGridViewTextBoxColumn).DefaultCellStyle.Format = ClientCty.Ⴗ('É', 5, 307012902);
				(obj3 as DataGridViewTextBoxColumn).Width = 140;
				num = ⴅ[169] - 155;
				break;
			case 42:
				(obj3 as DataGridViewTextBoxColumn).ToolTipText = ClientCty.Ⴗ('Ð', 2, 307013414);
				Ⴈ.Columns.Add((DataGridViewTextBoxColumn)obj3);
				num = ⴗ[31] - 64562;
				break;
			case 54:
				num2 = 0;
				num = ⴗ[23] - 52148;
				break;
			case 11:
				Ⴈ.Columns[num2].SortMode = DataGridViewColumnSortMode.Programmatic;
				num2++;
				num = 58;
				break;
			case 58:
				num = ((num2 < Ⴈ.Columns.Count - 1) ? 11 : 24);
				break;
			case 24:
				Ⴗ.Caches.Wx.DataSet.Tables[0].Locale = CultureInfo.InvariantCulture;
				num = 17;
				break;
			case 17:
				supportInitialize2 = new DataView(Ⴗ.Caches.Wx.DataSet.Tables[0]);
				num = 0;
				break;
			case 0:
			{
				ISupportInitialize supportInitialize = new BindingSource();
				(supportInitialize as BindingSource).DataSource = (DataView)supportInitialize2;
				Ⴓ = (BindingSource)supportInitialize;
				num = ⴗ[159] - 58278;
				break;
			}
			case 6:
				cloneable = UtilsSql.FormatSqlFilter(Filter, SqlFilterType.AnnWx);
				Ⴓ.Filter = Filter;
				num = ⴗ[12] - 262;
				break;
			case 39:
			{
				Ⴈ.DataSource = Ⴓ;
				object obj2 = new DgvFilterManager(Ⴈ);
				this.m_Ⴅ.Ⴃ = obj2 as DgvFilterManager;
				num = ⴀႠ[34] - 62518;
				break;
			}
			case 46:
				this.m_Ⴅ.Ⴃ.BaseFilter = cloneable as string;
				goto case 38;
			case 38:
				this.m_Ⴅ.Ⴃ[ႥႥ.Ⴅ(1673507912, null, 4)] = new DgvTextBoxColumnFilter();
				num = 14;
				break;
			case 14:
				this.m_Ⴅ.Ⴃ.FilterChanged += Ⴜ;
				this.m_Ⴅ.Ⴃ.FilterSaved += Ⴅ;
				num = 55;
				break;
			case 55:
			{
				object obj = new DataGridViewColumnSelector(Ⴈ);
				((DataGridViewColumnSelector)obj).MaxHeight = 200;
				((DataGridViewColumnSelector)obj).Width = 110;
				num = ⴅ[194];
				break;
			}
			case 29:
				Ⴜ(null, Filter);
				return;
			}
		}
	}

	private void Ⴅ(object P_0, string P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_1 = ShowDxFilter.Ⴗ(P_1, 86, 'j');
				obj = new FilterEditor(Ⴗ, FilterType.Ann);
				goto case 1;
			case 1:
				num = 6;
				break;
			case 6:
				((FilterEditor)obj).Filter = P_1;
				FilterPicker.ႥႷ((Form)(obj as FilterEditor), '\u02fc', (short)699);
				num = 5;
				break;
			case 5:
				num = ((FilterPicker.ႥႷ((Form)(obj as FilterEditor), 'ƞ', (short)470) != DialogResult.OK) ? (ⴀႠ[71] - 18561) : ⴅ[115]);
				break;
			case 4:
				Ⴗ.Cfg.Filters.Wx.List.Add(new WxFilter(((FilterEditor)obj).FilterName, (obj as FilterEditor).Filter));
				return;
			case 2:
			case 7:
				return;
			}
		}
	}

	private void Ⴜ(object P_0, string P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				P_1 = ShowDxFilter.Ⴗ(P_1, 359, 'ś');
				goto case 1;
			case 1:
				if (global::Ⴀ.ႳႳ.Ⴓ(FilterName, '\u0353', 885) > 0)
				{
					num = ⴀႠ[35] - 25311;
					break;
				}
				while (true)
				{
					int num2 = ((global::Ⴀ.ႳႳ.Ⴓ(P_1, '\u0356', 880) <= 0) ? (ⴀႠ[70] - 49248) : (ⴅ[172] - 56));
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 3:
							break;
						case 7:
							goto IL_0139;
						case 6:
							base.ToolTipText = WxFilters.Ⴀ(null, 4, 103387413) + P_1;
							return;
						case 0:
							Text = ClientCty.Ⴗ('ê', 6, 307012950);
							goto case 1;
						case 1:
						case 5:
							base.ToolTipText = ႥႥ.Ⴅ(1673508831, null, 6);
							return;
						}
						break;
						IL_0139:
						ႥႠ.ႭႤ((Control)this, DxFilters.Ⴈ(ႥႥ.Ⴅ(1673508430, null, 1), P_1, 902, 990), 'Ǝ', 'Ǯ');
						num2 = 6;
					}
				}
			case 0:
			case 3:
			case 4:
				ႥႠ.ႭႤ((Control)this, DxFilters.Ⴈ(ႥႥ.Ⴅ(1673508427, null, 4), FilterName, 591, 535), 'ί', 'Ϗ');
				num = 2;
				break;
			case 2:
				SetDxExtension.Ⴃ((DockContent)this, FilterPicker.ႥႠ(WxFilters.Ⴀ(null, 0, 103387499), FilterName, ႥႥ.Ⴅ(1673508804, null, 7), P_1, 94, 36), (short)933, 'Ϙ');
				return;
			}
		}
	}

	private void ႳႷ(object P_0, FormClosingEventArgs P_1)
	{
		SaveGridState();
	}

	public void SaveGridState()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		ICollection collection = new StringCollection();
		int num = 0;
		object obj = DxSpotRateGraph.Ⴅ((BaseCollection)HighlightCountyCfg.ႷႣ(Ⴈ, 754, 711), (short)713, (short)746);
		try
		{
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 5:
				{
					IDisposable disposable = (DataGridViewColumn)((IEnumerator)obj).Current;
					StringCollection obj2 = (StringCollection)collection;
					string format = WxFilters.Ⴀ(null, 1, 103387421);
					object obj3 = new object[4];
					object[] obj4 = (object[])obj3;
					int num3 = ShowUsers.Ⴈ(disposable as DataGridViewColumn, 336, 358);
					obj4[0] = HighlightArrlSectionCfg.Ⴅ(ref num3, ClientCty.Ⴗ('w', 7, 307012782), 8, 39);
					(obj3 as object[])[1] = ShowUsers.Ⴈ((DataGridViewColumn)disposable, 124, 75);
					(obj3 as object[])[2] = HighlightCqZoneCfg.Ⴜ((DataGridViewBand)(disposable as DataGridViewColumn), 247, (short)162);
					(obj3 as object[])[3] = num++;
					obj2.Add(string.Format(format, obj3 as object[]));
					num2 = ⴀႠ[75] - 37476;
					break;
				}
				default:
					num2 = ((obj as IEnumerator).MoveNext() ? ⴅ[285] : 6);
					break;
				case 6:
					return;
				}
			}
		}
		finally
		{
			int num4 = 3;
			object obj5 = default(object);
			while (true)
			{
				int num5;
				switch (num4)
				{
				default:
					obj5 = ((IEnumerator)obj) as IDisposable;
					num5 = (((IDisposable)obj5 == null) ? 1 : 4);
					goto IL_0199;
				case 4:
					(obj5 as IDisposable).Dispose();
					break;
				case 1:
				case 2:
				case 5:
					break;
				}
				break;
				IL_0199:
				num4 = num5;
			}
		}
	}

	public void AutoScrollGrid()
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 6;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((SkimmerSpotRateGraph.ႤႤ(Ⴈ, 325, 'ĺ') <= 0) ? 2 : 7);
				break;
			case 7:
				HighlightItuZoneCfg.ႳႤ(Ⴈ, SkimmerSpotRateGraph.ႤႤ(Ⴈ, 378, 'ą') - 1, 464, 'Ǝ');
				num = 0;
				break;
			case 0:
				ShowUsers.Ⴄ(Ⴈ, 714, '\u02f8');
				ClientCfg.Ⴜ(Ⴈ, 'ȴ', 574)[Ⴈ.RowCount - 1].Selected = true;
				goto case 1;
			case 1:
			case 5:
				num = ⴄ[45] - 14534;
				break;
			case 3:
				Ⴈ.ClearSelection();
				return;
			case 2:
			case 4:
				return;
			}
		}
	}

	private void ႳႳ(object P_0, DataGridViewCellEventArgs P_1)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 2;
		object obj = default(object);
		object obj2 = default(object);
		IComparable noSsidCall2 = default(IComparable);
		object noSsidCall = default(object);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
			case 4:
				return;
			}
			UserInfo.Ⴜ((Control)this, HighlightSpotterCfg.Ⴗ('ǫ', 447), (short)532, 'Ȁ');
			if (FilterViewer.ႨႤ(P_1, 349, 335) < 0)
			{
				num = 0;
				continue;
			}
			while (true)
			{
				IComparable comparable = TelnetServerCfg.Ⴀ(SetDxFilter.Ⴍ(HighlightCountyCfg.ႷႣ(Ⴈ, 605, 616), HighlightCqZoneCfg.ႣႷ(P_1, '\u02f9', 'ʋ'), 394, 'Ƴ'), 121, '[');
				int num2 = ⴀႠ[6] - 62238;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 3:
					case 6:
						return;
					case 2:
						break;
					case 13:
						obj = HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(Ⴈ, 'à', 234), FilterViewer.ႨႤ(P_1, 11, 25), 'Ϋ', 'Ϫ');
						num2 = 7;
						continue;
					case 7:
						num2 = (((obj2 = (string)comparable) == null) ? 5 : (ⴀႠ[102] - ⴀႠ[102]));
						continue;
					case 0:
						num2 = (DxCommentExtCfg.ႤႰ(obj2 as string, ႥႥ.Ⴅ(1673508192, null, 7), 'ȍ', 555) ? 8 : 9);
						continue;
					case 9:
						num2 = ((!DxCommentExtCfg.ႤႰ(obj2 as string, WxFilters.Ⴀ(null, 5, 103387655), 'Ǫ', 460)) ? 1 : ⴅ[102]);
						continue;
					case 1:
						num2 = 5;
						continue;
					case 8:
						noSsidCall2 = UtilsCallsign.GetNoSsidCall(DxSpotRates.ႠႳ(HighlightCallCfg.Ⴓ(obj as DataGridViewRow, 210, '¤'), WxFilters.Ⴀ(null, 8, 103387812), 786, 889).Value.ToString());
						num2 = ⴗ[98] - 39632;
						continue;
					case 14:
						Process.Start(ႥႥ.Ⴍ(7, 1580609297, '\u0086', null) + (string)noSsidCall2);
						num2 = ⴅ[285];
						continue;
					case 10:
						noSsidCall = UtilsCallsign.GetNoSsidCall((obj as DataGridViewRow).Cells[ႥႥ.Ⴅ(1673508197, null, 2)].Value.ToString());
						num2 = ⴄ[127] - 363;
						continue;
					case 11:
						Process.Start(ႥႥ.Ⴍ(5, 1580609299, 'F', null) + (string)noSsidCall);
						num2 = ⴅ[285];
						continue;
					case 5:
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
		HighlightItuZoneCfg.ႳႠ(P_1, false, 143, 'Î');
	}

	private void ႳႤ(object P_0, DataGridViewCellFormattingEventArgs P_1)
	{
	}

	private void ႳႠ(object P_0, DataGridViewCellEventArgs P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 6;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			switch (num)
			{
			default:
				num = ((FilterViewer.ႨႤ(P_1, 934, 948) < 0) ? 1 : 2);
				break;
			case 2:
			case 7:
				num = ((FilterViewer.ႨႤ(P_1, 484, 502) >= DxSpotRates.ႠႤ(ClientCfg.Ⴜ(Ⴈ, 'ň', 322), 383, 308)) ? (ⴅ[115] / 4) : 0);
				break;
			case 0:
			case 5:
				num = ((HighlightCqZoneCfg.ႣႷ(P_1, '\u02e9', 'ʛ') < 0) ? 1 : (ⴄ[237] - 13499));
				break;
			case 4:
				if (HighlightCqZoneCfg.ႣႷ(P_1, 'Ǎ', 'ƿ') >= SkimmerSpotRateGraph.ႤႣ((BaseCollection)HighlightCountyCfg.ႷႣ(Ⴈ, 602, 623), 'é', 170))
				{
					num = 1;
					break;
				}
				while (true)
				{
					DataGridViewCell dataGridViewCell = HighlightCallCfg.Ⴓ(HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(Ⴈ, 'Q', 91), FilterViewer.ႨႤ(P_1, 470, 452), 'ʴ', '\u02f5'), 762, 'ʌ')[P_1.ColumnIndex] as DataGridViewLinkCell;
					int num2 = 7;
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 5:
							return;
						case 6:
						case 8:
							break;
						case 7:
							num2 = ((!(dataGridViewCell is DataGridViewLinkCell)) ? 1 : 2);
							continue;
						case 2:
							convertible = (dataGridViewCell as DataGridViewLinkCell).Value.ToString();
							num2 = ((!(convertible is string)) ? 1 : 4);
							continue;
						case 4:
							convertible = UtilsCallsign.GetNoSsidCall((string)convertible);
							convertible = UtilsCallsign.ScrubCall((string)convertible);
							num2 = ((((string)convertible).Length <= 0) ? 1 : 3);
							continue;
						case 3:
							Process.Start(ClientCty.Ⴗ('<', 7, 307012940) + (convertible as string));
							num2 = ⴄ[234] - 24922;
							continue;
						case 1:
							return;
						}
						break;
					}
				}
			case 1:
			case 3:
				return;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 6;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? 1 : 3);
				continue;
			case 3:
			case 4:
			case 5:
				num = ((Ⴀ == null) ? 1 : (ⴗ[127] - 17862));
				continue;
			case 2:
				Ⴀ.Dispose();
				break;
			case 1:
				break;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void ႳႥ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 17;
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
				Ⴈ = new DataGridView();
				num = 11;
				break;
			case 11:
				((ISupportInitialize)Ⴈ).BeginInit();
				AnnFilters.Ⴓ((Control)this, 'ϊ', 'ϕ');
				DxSpotRates.ႠႠ(Ⴈ, false, 270, 297);
				num = 1;
				break;
			case 1:
				DxSpotRates.ႠႠ(Ⴈ, false, 317, 277);
				ArcClientConnectDat.Ⴈ(Ⴈ, true, 537, 'ȑ');
				num = 10;
				break;
			case 10:
				DxSpotRates.ႠႠ(Ⴈ, false, 684, 645);
				ႳႰ.Ⴃ((DataGridViewCellStyle)obj3, ClientCfg.Ⴍ(531, 639), 657, 708);
				num = ⴀႠ[115] - 48695;
				break;
			case 22:
				ႳႰ.Ⴃ((DataGridViewCellStyle)obj3, DxEmailCfg.Ⴍ(850, 805), 340, 258);
				num = 18;
				break;
			case 18:
				DxSpotRates.ႠႭ(Ⴈ, (DataGridViewCellStyle)obj3, 775, 793);
				HighlightCfg.ႳႰ(cloneable as DataGridViewCellStyle, DataGridViewContentAlignment.MiddleLeft, '?', 94);
				num = 20;
				break;
			case 20:
				DxccCacheData.ႷႳ(cloneable as DataGridViewCellStyle, HighlightItuZoneCfg.ႳႷ(765, 665), 308, 'ė');
				num = ⴅ[71];
				break;
			case 25:
				DxSpotRateGraph.Ⴗ(cloneable as DataGridViewCellStyle, new Font(ႥႥ.Ⴅ(1673508262, null, 3), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), 'Ɔ', 449);
				goto case 26;
			case 26:
				num = ⴗ[120] - 5055;
				break;
			case 14:
			case 29:
				DxSpotRates.ႠႨ((DataGridViewCellStyle)cloneable, HighlightItuZoneCfg.ႳႷ(623, 522), 'Ǌ', 401);
				num = ⴄ[22] - 53087;
				break;
			case 31:
				ႳႰ.Ⴃ((DataGridViewCellStyle)cloneable, ClientCfg.Ⴍ(703, 723), 789, 832);
				num = 19;
				break;
			case 19:
				ႳႰ.Ⴃ(cloneable as DataGridViewCellStyle, DxEmailCfg.Ⴍ(904, 1023), 980, 898);
				num = 7;
				break;
			case 7:
				ArcClientConnectDat.ႷႭ((DataGridViewCellStyle)cloneable, DataGridViewTriState.True, 298, 'ň');
				HighlightCountyCfg.ႷႠ(Ⴈ, (DataGridViewCellStyle)cloneable, 1020, 969);
				num = 12;
				break;
			case 12:
				global::Ⴀ.ႳႳ.Ⴅ(Ⴈ, DataGridViewColumnHeadersHeightSizeMode.AutoSize, 'ȸ', 564);
				HighlightCfg.ႳႰ((DataGridViewCellStyle)obj2, DataGridViewContentAlignment.MiddleLeft, '\u0315', 884);
				num = 23;
				break;
			case 23:
				DxccCacheData.ႷႳ((DataGridViewCellStyle)obj2, HighlightCallCfg.Ⴄ(34, 36), 449, 'Ǣ');
				num = ⴀႠ[84] - 18797;
				break;
			case 5:
			{
				DxSpotRateGraph.Ⴗ((DataGridViewCellStyle)obj2, new Font(WxFilters.Ⴀ(null, 2, 103387623), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), 'Ļ', 380);
				byte num2 = ⴅ[78];
				Bye.Ⴄ[132] = (char)((Bye.Ⴄ[132] | ႥႰ.Ⴗ[7]) & 0xE7);
				num = num2 - 40;
				break;
			}
			case 6:
				DxSpotRates.ႠႨ(obj2 as DataGridViewCellStyle, HighlightItuZoneCfg.ႳႷ(953, 991), 'Ʌ', 542);
				num = 4;
				break;
			case 4:
				ႳႰ.Ⴃ((DataGridViewCellStyle)obj2, ClientCfg.Ⴍ(203, 167), 298, 383);
				num = 24;
				break;
			case 24:
				ႳႰ.Ⴃ((DataGridViewCellStyle)obj2, DxEmailCfg.Ⴍ(325, 306), 270, 344);
				num = 2;
				break;
			case 2:
				ArcClientConnectDat.ႷႭ((DataGridViewCellStyle)obj2, DataGridViewTriState.False, 937, 'ϋ');
				HighlightCqZoneCfg.Ⴍ(Ⴈ, (DataGridViewCellStyle)obj2, 116, 74);
				num = 27;
				break;
			case 27:
				MultimediaCache.Ⴄ((Control)Ⴈ, DockStyle.Fill, 38, (short)27);
				HighlightCountyCfg.Ⴜ((Control)Ⴈ, new Point(0, 0), 427, 504);
				goto case 30;
			case 30:
				num = 28;
				break;
			case 28:
				FilterEditor.ႷႤ(Ⴈ, false, 1018, 947);
				Ⴈ.Name = ClientCty.Ⴗ('\u0011', 1, 307012769);
				num = 0;
				break;
			case 0:
				Ⴈ.ReadOnly = true;
				(obj as DataGridViewCellStyle).SelectionBackColor = Color.White;
				(obj as DataGridViewCellStyle).SelectionForeColor = Color.Black;
				num = 8;
				break;
			case 8:
				Ⴈ.RowsDefaultCellStyle = (DataGridViewCellStyle)obj;
				Ⴈ.RowTemplate.Height = 24;
				num = 32;
				break;
			case 32:
				Ⴈ.Size = new Size(598, 273);
				Ⴈ.TabIndex = 3;
				num = ⴄ[52] - 25096;
				break;
			case 13:
				Ⴈ.CellContentClick += ႳႠ;
				Ⴈ.CellContentDoubleClick += ႳႳ;
				num = ⴄ[47] - 24185;
				break;
			case 16:
				Ⴈ.CellFormatting += ႳႤ;
				Ⴈ.DataError += ႳႣ;
				num = 21;
				break;
			case 21:
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				base.AutoScaleMode = AutoScaleMode.Font;
				base.ClientSize = new Size(598, 273);
				num = ⴀႠ[55] - 49878;
				break;
			case 15:
				base.Controls.Add(Ⴈ);
				Font = new Font(ႥႥ.Ⴅ(1673508258, null, 7), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
				num = ⴅ[346] - ⴅ[321];
				break;
			case 3:
				base.Name = WxFilters.Ⴀ(null, 3, 103387540);
				Text = ClientCty.Ⴗ('\0', 8, 307012952);
				num = ⴗ[28] - 37799;
				break;
			case 9:
				base.FormClosing += ႳႷ;
				((ISupportInitialize)Ⴈ).EndInit();
				ResumeLayout(performLayout: false);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static WxWindow()
	{
		ArcClientConnectDat.Ⴍ();
		Ⴐ = new object();
	}
}
