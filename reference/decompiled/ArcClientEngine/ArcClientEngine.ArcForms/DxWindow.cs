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

public class DxWindow : DockContent
{
	internal DataGridView Ⴐ;

	private BindingSource Ⴗ;

	private static readonly object Ⴃ;

	private DxccCacheData.ႷႷ m_Ⴅ = new DxccCacheData.ႷႷ();

	public string Filter
	{
		get
		{
			string ⴈ = this.m_Ⴅ.Ⴈ;
			ႥႰ.Ⴗ[49] = (char)((ႥႰ.Ⴗ[49] - ႥႰ.Ⴗ[160]) & 0xA9);
			return ⴈ;
		}
		set
		{
			this.m_Ⴅ.Ⴈ = value as string;
		}
	}

	public string FilterName
	{
		get
		{
			return this.m_Ⴅ.Ⴍ;
		}
		set
		{
			this.m_Ⴅ.Ⴍ = value as string;
			Text = DxFilters.Ⴈ(WxFilters.Ⴀ(null, 5, 103387823), value, 632, 544);
		}
	}

	protected override void Dispose(bool disposing)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? (ⴗ[88] - 27880) : 4);
				continue;
			case 4:
				num = ((this.m_Ⴅ.Ⴀ == null) ? 5 : (ⴗ[118] - 65334));
				continue;
			case 2:
			case 6:
				this.m_Ⴅ.Ⴀ.Dispose();
				break;
			case 3:
			case 5:
				break;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void Ⴅ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 8;
		ICloneable cloneable2 = default(ICloneable);
		object obj2 = default(object);
		ICloneable cloneable = default(ICloneable);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cloneable2 = new DataGridViewCellStyle();
				obj2 = new DataGridViewCellStyle();
				cloneable = new DataGridViewCellStyle();
				obj = new DataGridViewCellStyle();
				Ⴐ = new DataGridView();
				num = 25;
				break;
			case 25:
				((ISupportInitialize)Ⴐ).BeginInit();
				AnnFilters.Ⴓ((Control)this, 'Ͱ', '\u036f');
				DxSpotRates.ႠႠ(Ⴐ, false, 882, 853);
				num = ⴀႠ[81] - 54659;
				break;
			case 21:
				DxSpotRates.ႠႠ(Ⴐ, false, 873, 833);
				ArcClientConnectDat.Ⴈ(Ⴐ, true, 717, '\u02c5');
				num = 22;
				break;
			case 22:
				DxSpotRates.ႠႠ(Ⴐ, false, 34, 11);
				ႳႰ.Ⴃ(cloneable2 as DataGridViewCellStyle, ClientCfg.Ⴍ(367, 259), 804, 881);
				num = 26;
				break;
			case 26:
				ႳႰ.Ⴃ((DataGridViewCellStyle)cloneable2, DxEmailCfg.Ⴍ(769, 886), 341, 259);
				num = 1;
				break;
			case 1:
				DxSpotRates.ႠႭ(Ⴐ, (DataGridViewCellStyle)cloneable2, 468, 458);
				HighlightCfg.ႳႰ((DataGridViewCellStyle)obj2, DataGridViewContentAlignment.MiddleLeft, 'Κ', 1019);
				num = ⴀႠ[111] - 49531;
				break;
			case 30:
				DxccCacheData.ႷႳ(obj2 as DataGridViewCellStyle, HighlightItuZoneCfg.ႳႷ(636, 536), 399, 'Ƭ');
				num = 33;
				break;
			case 33:
				DxSpotRateGraph.Ⴗ(obj2 as DataGridViewCellStyle, new Font(ClientCty.Ⴗ('~', 3, 307013387), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0), 'ɣ', 548);
				num = 19;
				break;
			case 19:
				DxSpotRates.ႠႨ((DataGridViewCellStyle)obj2, HighlightItuZoneCfg.ႳႷ(913, 1012), '\u033d', 870);
				num = ⴗ[161] - 4983;
				break;
			case 16:
				ႳႰ.Ⴃ((DataGridViewCellStyle)obj2, ClientCfg.Ⴍ(349, 305), 199, 146);
				num = 9;
				break;
			case 9:
				ႳႰ.Ⴃ(obj2 as DataGridViewCellStyle, DxEmailCfg.Ⴍ(983, 928), 2, 84);
				num = ⴗ[41] - 23781;
				break;
			case 23:
				ArcClientConnectDat.ႷႭ((DataGridViewCellStyle)obj2, DataGridViewTriState.True, 794, '\u0378');
				HighlightCountyCfg.ႷႠ(Ⴐ, (DataGridViewCellStyle)obj2, 634, 591);
				num = 27;
				break;
			case 27:
				ႳႳ.Ⴅ(Ⴐ, DataGridViewColumnHeadersHeightSizeMode.AutoSize, 'ŗ', 347);
				HighlightCfg.ႳႰ((DataGridViewCellStyle)cloneable, DataGridViewContentAlignment.MiddleLeft, 'ώ', 943);
				num = 13;
				break;
			case 13:
				DxccCacheData.ႷႳ((DataGridViewCellStyle)cloneable, HighlightCallCfg.Ⴄ(230, 224), 648, 'ʫ');
				num = ⴄ[295] - 49142;
				break;
			case 2:
				DxSpotRateGraph.Ⴗ(cloneable as DataGridViewCellStyle, new Font(ClientCty.Ⴗ('_', 4, 307013388), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0), 'Ͱ', 823);
				num = 6;
				break;
			case 6:
				DxSpotRates.ႠႨ((DataGridViewCellStyle)cloneable, HighlightItuZoneCfg.ႳႷ(568, 606), 'I', 18);
				num = ⴗ[62] - 59521;
				break;
			case 31:
				ႳႰ.Ⴃ((DataGridViewCellStyle)cloneable, ClientCfg.Ⴍ(998, 906), 138, 223);
				num = 18;
				break;
			case 18:
				ႳႰ.Ⴃ((DataGridViewCellStyle)cloneable, DxEmailCfg.Ⴍ(963, 948), 503, 417);
				num = ⴄ[92] - 14805;
				break;
			case 10:
				ArcClientConnectDat.ႷႭ((DataGridViewCellStyle)cloneable, DataGridViewTriState.False, 496, 'ƒ');
				HighlightCqZoneCfg.Ⴍ(Ⴐ, (DataGridViewCellStyle)cloneable, 822, 776);
				num = ⴀႠ[107] - 34899;
				break;
			case 11:
				MultimediaCache.Ⴄ((Control)Ⴐ, DockStyle.Fill, 988, (short)993);
				HighlightCountyCfg.Ⴜ((Control)Ⴐ, new Point(0, 0), 623, 572);
				num = ⴄ[176] - 2229;
				break;
			case 15:
				FilterEditor.ႷႤ(Ⴐ, false, 445, 500);
				ႥႤ.Ⴀ((Control)Ⴐ, ႥႥ.Ⴅ(1673508270, null, 7), '\u02e5', 'ʈ');
				num = ⴗ[158] - 28126;
				break;
			case 24:
				ArcClientConnectDat.Ⴈ(Ⴐ, true, 781, '\u0304');
				HighlightCfg.ႳႰ((DataGridViewCellStyle)obj, DataGridViewContentAlignment.MiddleLeft, '\u0360', 769);
				goto case 35;
			case 35:
				num = 29;
				break;
			case 29:
				DxccCacheData.ႷႳ(obj as DataGridViewCellStyle, HighlightItuZoneCfg.ႳႷ(682, 718), 487, 'Ǆ');
				num = 34;
				break;
			case 34:
				((DataGridViewCellStyle)obj).Font = new Font(ClientCty.Ⴗ('\f', 1, 307013385), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
				num = 3;
				break;
			case 3:
				(obj as DataGridViewCellStyle).ForeColor = SystemColors.WindowText;
				(obj as DataGridViewCellStyle).SelectionBackColor = Color.White;
				goto case 7;
			case 7:
				((DataGridViewCellStyle)obj).SelectionForeColor = Color.Black;
				num = 14;
				break;
			case 14:
				((DataGridViewCellStyle)obj).WrapMode = DataGridViewTriState.True;
				Ⴐ.RowHeadersDefaultCellStyle = (DataGridViewCellStyle)obj;
				Ⴐ.RowTemplate.Height = 24;
				num = ⴀႠ[112] - 45106;
				break;
			case 28:
				Ⴐ.Size = new Size(634, 273);
				Ⴐ.TabIndex = 2;
				num = 36;
				break;
			case 36:
				Ⴐ.CellContentClick += ႭႰ;
				Ⴐ.CellContentDoubleClick += ႭႨ;
				num = ⴅ[17];
				break;
			case 0:
				Ⴐ.CellFormatting += ႭႤ;
				Ⴐ.CellToolTipTextNeeded += ႭႥ;
				num = ⴅ[153] - 198;
				break;
			case 12:
				Ⴐ.DataError += ႭႠ;
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				num = ⴅ[182] - 148;
				break;
			case 17:
				base.AutoScaleMode = AutoScaleMode.Font;
				base.ClientSize = new Size(634, 273);
				base.Controls.Add(Ⴐ);
				num = 32;
				break;
			case 32:
				Font = new Font(ႥႥ.Ⴅ(1673508263, null, 2), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
				num = 4;
				break;
			case 4:
				base.Name = ClientCty.Ⴗ('®', 7, 307013383);
				Text = ႥႥ.Ⴍ(6, 1580608964, '\u009e', null);
				num = 5;
				break;
			case 5:
				base.FormClosing += ႭႭ;
				((ISupportInitialize)Ⴐ).EndInit();
				ResumeLayout(performLayout: false);
				return;
			case 20:
				return;
			}
		}
	}

	public DxWindow()
	{
		object empty = string.Empty;
		this.m_Ⴅ.Ⴍ = (string)empty;
		base._002Ector();
		Ⴅ();
		Filter = string.Empty;
	}

	public void Init(ArcClientObjMgr om)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		try
		{
			int num = 136;
			DataGridViewColumn dataGridViewColumn = default(DataGridViewColumn);
			object obj26 = default(object);
			object obj25 = default(object);
			DataGridViewColumn dataGridViewColumn20 = default(DataGridViewColumn);
			object obj24 = default(object);
			DataGridViewColumn dataGridViewColumn19 = default(DataGridViewColumn);
			DataGridViewColumn dataGridViewColumn18 = default(DataGridViewColumn);
			object obj23 = default(object);
			DataGridViewColumn dataGridViewColumn17 = default(DataGridViewColumn);
			DataGridViewColumn dataGridViewColumn16 = default(DataGridViewColumn);
			object obj22 = default(object);
			DataGridViewColumn dataGridViewColumn15 = default(DataGridViewColumn);
			DataGridViewColumn dataGridViewColumn14 = default(DataGridViewColumn);
			object obj21 = default(object);
			DataGridViewColumn dataGridViewColumn13 = default(DataGridViewColumn);
			object obj20 = default(object);
			object obj19 = default(object);
			object obj18 = default(object);
			DataGridViewColumn dataGridViewColumn12 = default(DataGridViewColumn);
			object obj17 = default(object);
			DataGridViewColumn dataGridViewColumn11 = default(DataGridViewColumn);
			object obj16 = default(object);
			object obj15 = default(object);
			object obj14 = default(object);
			DataGridViewColumn dataGridViewColumn10 = default(DataGridViewColumn);
			object obj13 = default(object);
			DataGridViewColumn dataGridViewColumn9 = default(DataGridViewColumn);
			DataGridViewColumn dataGridViewColumn8 = default(DataGridViewColumn);
			object obj12 = default(object);
			DataGridViewColumn dataGridViewColumn7 = default(DataGridViewColumn);
			object obj11 = default(object);
			DataGridViewColumn dataGridViewColumn6 = default(DataGridViewColumn);
			object obj10 = default(object);
			DataGridViewColumn dataGridViewColumn5 = default(DataGridViewColumn);
			object obj9 = default(object);
			object obj8 = default(object);
			DataGridViewColumn dataGridViewColumn4 = default(DataGridViewColumn);
			DataGridViewColumn dataGridViewColumn3 = default(DataGridViewColumn);
			object obj7 = default(object);
			object obj6 = default(object);
			object obj5 = default(object);
			object obj4 = default(object);
			object obj3 = default(object);
			DataGridViewColumn dataGridViewColumn2 = default(DataGridViewColumn);
			int num2 = default(int);
			ICollection collection = default(ICollection);
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
					this.m_Ⴅ.Ⴓ = om;
					ArcClientConnectDat.Ⴈ(Ⴐ, false, 414, 'Ɣ');
					num = 70;
					continue;
				case 70:
					dataGridViewColumn = new DataGridViewTextBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, WxFilters.Ⴀ(null, 7, 103387731), (short)630, 604);
					num = 213;
					continue;
				case 213:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, WxFilters.Ⴀ(null, 4, 103387728), (short)706, (short)742);
					num = 4;
					continue;
				case 4:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 3, 103387735), (short)617, (short)588);
					num = ⴄ[74] - 29912;
					continue;
				case 188:
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), ClientCty.Ⴗ(' ', 3, 307013430), (short)231, 204);
					num = ⴀႠ[24] - 40329;
					continue;
				case 85:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, 55, 549, 'ȭ');
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 419, 406), (DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, '\u030c', ';');
					num = 39;
					continue;
				case 39:
					obj26 = new DataGridViewTextBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj26 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673507916, null, 0), (short)106, 64);
					num = ⴅ[134] - 131;
					continue;
				case 61:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj26, ႥႥ.Ⴅ(1673507917, null, 1), (short)187, (short)159);
					num = 68;
					continue;
				case 68:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj26 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 1, 103387710), (short)215, (short)242);
					num = 11;
					continue;
				case 11:
					ShowUsers.Ⴀ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(obj26 as DataGridViewTextBoxColumn), (short)764, 'ʒ'), ClientCty.Ⴗ('\u009a', 6, 307013418), 965, 1006);
					num = ⴀႠ[110] - ⴀႠ[110];
					continue;
				case 0:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj26 as DataGridViewTextBoxColumn), 50, 158, '\u0096');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj26, ClientCty.Ⴗ('\u001d', 0, 307013412), (short)604, 631);
					num = ⴗ[103] - 55679;
					continue;
				case 12:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 418, 407), (DataGridViewColumn)(DataGridViewTextBoxColumn)obj26, 'Ŧ', 'Ĕ');
					num = 45;
					continue;
				case 45:
					obj25 = new DataGridViewLinkColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj25 as DataGridViewLinkColumn), WxFilters.Ⴀ(null, 0, 103387820), (short)905, 931);
					num = 142;
					continue;
				case 142:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewLinkColumn)obj25, WxFilters.Ⴀ(null, 6, 103387818), (short)120, (short)92);
					num = ⴀႠ[125] - 25984;
					continue;
				case 191:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewLinkColumn)obj25, WxFilters.Ⴀ(null, 5, 103387817), (short)963, (short)998);
					num = 71;
					continue;
				case 71:
					ႳႰ.Ⴓ(obj25 as DataGridViewLinkColumn, false, 625, 639);
					HighlightItuZoneCfg.ႳႣ((DataGridViewLinkColumn)obj25, ClientCfg.Ⴍ(834, 814), 311, 327);
					num = 120;
					continue;
				case 120:
					ArcClientConnectDat.ႷႷ(obj25 as DataGridViewLinkColumn, LinkBehavior.HoverUnderline, 'ǯ', 393);
					HighlightItuZoneCfg.ႳႣ(obj25 as DataGridViewLinkColumn, DxEmailCfg.Ⴍ(858, 812), 283, 362);
					num = 228;
					continue;
				case 228:
					WxFilters.ႭႰ((DataGridViewLinkColumn)obj25, true, 7, 50);
					ႥႥ.ႤႳ(obj25 as DataGridViewLinkColumn, ClientCfg.Ⴍ(562, 607), 'ͻ', 841);
					num = ⴄ[156] - 11543;
					continue;
				case 111:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewLinkColumn)obj25, 75, 317, 'ĵ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj25 as DataGridViewLinkColumn), WxFilters.Ⴀ(null, 3, 103387988), (short)740, 719);
					num = ⴅ[72];
					continue;
				case 92:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 318, 267), (DataGridViewColumn)(obj25 as DataGridViewLinkColumn), '\u0001', 's');
					num = 168;
					continue;
				case 168:
					dataGridViewColumn20 = new DataGridViewTextBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn20, ႥႥ.Ⴍ(1, 1580608974, '=', null), (short)559, 517);
					num = 132;
					continue;
				case 132:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn20, ႥႥ.Ⴍ(4, 1580608971, 'C', null), (short)90, (short)126);
					num = 7;
					continue;
				case 7:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn20, ႥႥ.Ⴍ(4, 1580608971, 'a', null), (short)135, (short)162);
					num = ⴀႠ[68] - 51623;
					continue;
				case 124:
					ShowUsers.Ⴀ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(dataGridViewColumn20 as DataGridViewTextBoxColumn), (short)314, 'Ŕ'), ႥႥ.Ⴅ(1673507913, null, 2), 560, 539);
					num = ⴗ[72] - 15813;
					continue;
				case 36:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(dataGridViewColumn20 as DataGridViewTextBoxColumn), (short)1020, 'Β'), DataGridViewContentAlignment.MiddleRight, 'ΐ', 1009);
					num = 108;
					continue;
				case 108:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(dataGridViewColumn20 as DataGridViewTextBoxColumn), 65, 115, '{');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn20, ClientCty.Ⴗ('¼', 8, 307013466), (short)962, 1001);
					num = ⴄ[169] - 10765;
					continue;
				case 174:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 594, 615), (DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn20, 'ɒ', 'Ƞ');
					num = ⴄ[290] - 49039;
					continue;
				case 112:
					obj24 = new DataGridViewLinkColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj24 as DataGridViewLinkColumn), ႥႥ.Ⴅ(1673508194, null, 5), (short)948, 926);
					num = ⴄ[62] - 13351;
					continue;
				case 176:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewLinkColumn)obj24, ႥႥ.Ⴅ(1673508194, null, 5), (short)353, (short)325);
					num = ⴅ[341] + ⴅ[2];
					continue;
				case 192:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj24 as DataGridViewLinkColumn), ႥႥ.Ⴅ(1673508194, null, 5), (short)351, (short)378);
					num = 159;
					continue;
				case 159:
					ႳႰ.Ⴓ(obj24 as DataGridViewLinkColumn, false, 946, 956);
					HighlightItuZoneCfg.ႳႣ((DataGridViewLinkColumn)obj24, ClientCfg.Ⴍ(830, 850), 756, 644);
					num = ⴗ[147] - 45684;
					continue;
				case 196:
					ArcClientConnectDat.ႷႷ((DataGridViewLinkColumn)obj24, LinkBehavior.HoverUnderline, '\u036e', 776);
					HighlightItuZoneCfg.ႳႣ((DataGridViewLinkColumn)obj24, DxEmailCfg.Ⴍ(260, 370), 186, 203);
					num = ⴗ[86] - 42585;
					continue;
				case 60:
					WxFilters.ႭႰ((DataGridViewLinkColumn)obj24, true, 676, 657);
					ႥႥ.ႤႳ((DataGridViewLinkColumn)obj24, ClientCfg.Ⴍ(938, 967), 'Ƽ', 398);
					num = ⴅ[171] - 176;
					continue;
				case 48:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj24 as DataGridViewLinkColumn), 75, 69, 'M');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj24 as DataGridViewLinkColumn), WxFilters.Ⴀ(null, 5, 103387975), (short)424, 387);
					num = ⴀႠ[35] - 25194;
					continue;
				case 121:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 423, 402), (DataGridViewColumn)(obj24 as DataGridViewLinkColumn), '\u02fa', 'ʈ');
					num = 99;
					continue;
				case 99:
					dataGridViewColumn19 = new DataGridViewTextBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn19, ႥႥ.Ⴍ(0, 1580609014, 'K', null), (short)230, 204);
					num = 87;
					continue;
				case 87:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn19, ႥႥ.Ⴍ(5, 1580609011, '.', null), (short)598, (short)626);
					num = 13;
					continue;
				case 13:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn19, ႥႥ.Ⴍ(8, 1580609022, '>', null), (short)926, (short)955);
					num = 200;
					continue;
				case 200:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(dataGridViewColumn19 as DataGridViewTextBoxColumn), 200, 657, 'ʙ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn19 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(6, 1580609018, '?', null), (short)714, 737);
					num = ⴄ[47] - 24135;
					continue;
				case 66:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 110, 91), (DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn19, 'ɋ', 'ȹ');
					num = 46;
					continue;
				case 46:
					dataGridViewColumn18 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn18 as DataGridViewCheckBoxColumn), ႥႥ.Ⴅ(1673508200, null, 0), (short)81, 123);
					num = ⴀႠ[101] - 46625;
					continue;
				case 50:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn18, ႥႥ.Ⴅ(1673508202, null, 2), (short)216, (short)252);
					num = 187;
					continue;
				case 187:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn18, ႥႥ.Ⴅ(1673507906, null, 2), (short)418, (short)391);
					num = 116;
					continue;
				case 116:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(DataGridViewCheckBoxColumn)dataGridViewColumn18, (short)128, 'î'), DataGridViewContentAlignment.MiddleCenter, 'ɲ', 531);
					num = ⴄ[239] - 49042;
					continue;
				case 93:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn18, 45, 10, '\u0002');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn18, ClientCty.Ⴗ('6', 3, 307013445), (short)574, 533);
					num = ⴅ[115] * 7;
					continue;
				case 28:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 478, 491), (DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn18, 'Ȕ', 'ɦ');
					num = 100;
					continue;
				case 100:
					obj23 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj23 as DataGridViewCheckBoxColumn), WxFilters.Ⴀ(null, 5, 103388020), (short)448, 490);
					num = 106;
					continue;
				case 106:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj23, ႥႥ.Ⴅ(1673507927, null, 8), (short)865, (short)837);
					num = 211;
					continue;
				case 211:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj23, ႥႥ.Ⴅ(1673507932, null, 3), (short)178, (short)151);
					num = 126;
					continue;
				case 126:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj23, 45, 689, 'ʹ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj23, WxFilters.Ⴀ(null, 2, 103388026), (short)740, 719);
					num = 129;
					continue;
				case 129:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 708, 753), (DataGridViewColumn)(obj23 as DataGridViewCheckBoxColumn), '\u0356', '\u0324');
					num = ⴅ[157] * 4;
					continue;
				case 84:
					dataGridViewColumn17 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn17 as DataGridViewCheckBoxColumn), ႥႥ.Ⴍ(6, 1580609004, '{', null), (short)84, 126);
					num = 234;
					continue;
				case 234:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn17, ႥႥ.Ⴍ(4, 1580609006, 'ï', null), (short)529, (short)565);
					num = ⴀႠ[6] - 62043;
					continue;
				case 208:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn17 as DataGridViewCheckBoxColumn), ႥႥ.Ⴍ(5, 1580609007, 'q', null), (short)506, (short)479);
					num = 90;
					continue;
				case 90:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(dataGridViewColumn17 as DataGridViewCheckBoxColumn), 45, 80, 'X');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn17 as DataGridViewCheckBoxColumn), ႥႥ.Ⴍ(1, 1580608913, '[', null), (short)349, 374);
					num = 33;
					continue;
				case 33:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 605, 616), (DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn17, '\u02f0', 'ʂ');
					num = ⴄ[141] - 4689;
					continue;
				case 117:
					dataGridViewColumn16 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn16 as DataGridViewCheckBoxColumn), ႥႥ.Ⴅ(1673507926, null, 0), (short)93, 119);
					num = 30;
					continue;
				case 30:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn16, ႥႥ.Ⴅ(1673507922, null, 4), (short)949, (short)913);
					num = 162;
					continue;
				case 162:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn16, ႥႥ.Ⴅ(1673507927, null, 1), (short)172, (short)137);
					num = ⴗ[106] - 22777;
					continue;
				case 86:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn16, 45, 258, 'Ċ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn16 as DataGridViewCheckBoxColumn), ႥႥ.Ⴅ(1673507946, null, 4), (short)778, 801);
					num = 230;
					continue;
				case 230:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 564, 513), (DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn16, '\u0006', 't');
					num = ⴗ[21] - 63686;
					continue;
				case 23:
					obj22 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj22, ClientCty.Ⴗ('\u008c', 5, 307013482), (short)981, 1023);
					num = 150;
					continue;
				case 150:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj22, ClientCty.Ⴗ('\u008c', 3, 307013484), (short)931, (short)903);
					num = 118;
					continue;
				case 118:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj22 as DataGridViewCheckBoxColumn), ClientCty.Ⴗ('¬', 4, 307013483), (short)893, (short)856);
					num = ⴀႠ[94] - 21788;
					continue;
				case 40:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(obj22 as DataGridViewCheckBoxColumn), (short)761, 'ʗ'), DataGridViewContentAlignment.MiddleCenter, 'ň', 297);
					num = ⴗ[97] - 31967;
					continue;
				case 1:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj22 as DataGridViewCheckBoxColumn), 50, 704, 'ˈ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj22, WxFilters.Ⴀ(null, 2, 103388013), (short)459, 480);
					num = ⴀႠ[0] - 49919;
					continue;
				case 38:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 577, 628), (DataGridViewColumn)(obj22 as DataGridViewCheckBoxColumn), 'ô', '\u0086');
					num = ⴅ[9] + 30;
					continue;
				case 149:
					dataGridViewColumn15 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn15, ႥႥ.Ⴍ(3, 1580608911, 'ï', null), (short)249, 211);
					num = 76;
					continue;
				case 76:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn15 as DataGridViewCheckBoxColumn), ClientCty.Ⴗ('q', 0, 307013477), (short)607, (short)635);
					num = ⴄ[278] - 56903;
					continue;
				case 74:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn15, ClientCty.Ⴗ('$', 7, 307013474), (short)156, (short)185);
					num = 62;
					continue;
				case 62:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(dataGridViewColumn15 as DataGridViewCheckBoxColumn), (short)435, 'ǝ'), DataGridViewContentAlignment.MiddleCenter, 'ί', 974);
					num = ⴄ[207] + 29;
					continue;
				case 210:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn15, 50, 256, 'Ĉ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn15 as DataGridViewCheckBoxColumn), ႥႥ.Ⴅ(1673507963, null, 1), (short)273, 314);
					num = ⴄ[263] - 60226;
					continue;
				case 161:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 725, 736), (DataGridViewColumn)(dataGridViewColumn15 as DataGridViewCheckBoxColumn), '\u0016', 'd');
					num = ⴄ[191] - 7512;
					continue;
				case 151:
					dataGridViewColumn14 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn14 as DataGridViewCheckBoxColumn), ClientCty.Ⴗ('0', 8, 307013521), (short)500, 478);
					num = ⴄ[116] - 53426;
					continue;
				case 57:
				case 177:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn14, ႥႥ.Ⴍ(7, 1580608950, 'H', null), (short)824, (short)796);
					num = 54;
					continue;
				case 54:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn14 as DataGridViewCheckBoxColumn), ႥႥ.Ⴍ(6, 1580608951, 'd', null), (short)835, (short)870);
					num = 160;
					continue;
				case 160:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(dataGridViewColumn14 as DataGridViewCheckBoxColumn), (short)91, '5'), DataGridViewContentAlignment.MiddleCenter, '\u008b', 234);
					num = 166;
					continue;
				case 166:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn14, 50, 11, '\u0003');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn14 as DataGridViewCheckBoxColumn), WxFilters.Ⴀ(null, 4, 103387930), (short)238, 197);
					num = 165;
					continue;
				case 165:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 476, 489), (DataGridViewColumn)(dataGridViewColumn14 as DataGridViewCheckBoxColumn), 'ȋ', 'ɹ');
					num = 130;
					continue;
				case 130:
					obj21 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj21 as DataGridViewCheckBoxColumn), ႥႥ.Ⴍ(4, 1580608931, 'Ò', null), (short)298, 256);
					num = 137;
					continue;
				case 137:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj21, ClientCty.Ⴗ(')', 1, 307013519), (short)202, (short)238);
					num = ⴀႠ[4] - 3229;
					continue;
				case 223:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj21 as DataGridViewCheckBoxColumn), ClientCty.Ⴗ('{', 6, 307013512), (short)431, (short)394);
					num = 56;
					continue;
				case 56:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(DataGridViewCheckBoxColumn)obj21, (short)776, '\u0366'), DataGridViewContentAlignment.MiddleCenter, '\u0352', 819);
					num = 37;
					continue;
				case 37:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj21, 50, 1002, 'Ϣ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj21 as DataGridViewCheckBoxColumn), ႥႥ.Ⴅ(1673507865, null, 7), (short)525, 550);
					num = 197;
					continue;
				case 197:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 479, 490), (DataGridViewColumn)(obj21 as DataGridViewCheckBoxColumn), 'ν', 'Ϗ');
					num = 44;
					continue;
				case 44:
					dataGridViewColumn13 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn13, ClientCty.Ⴗ('Ò', 4, 307013509), (short)318, 276);
					num = ⴀႠ[87] - 21035;
					continue;
				case 185:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn13 as DataGridViewCheckBoxColumn), ႥႥ.Ⴍ(7, 1580608942, 'Æ', null), (short)915, (short)951);
					num = ⴄ[155] - 44883;
					continue;
				case 154:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn13 as DataGridViewCheckBoxColumn), ႥႥ.Ⴍ(5, 1580608940, 'À', null), (short)414, (short)443);
					num = 114;
					continue;
				case 114:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(DataGridViewCheckBoxColumn)dataGridViewColumn13, (short)49, '_'), DataGridViewContentAlignment.MiddleCenter, 'ǫ', 394);
					num = ⴄ[294] - 26045;
					continue;
				case 113:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn13, 50, 480, 'Ǩ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn13 as DataGridViewCheckBoxColumn), WxFilters.Ⴀ(null, 3, 103387959), (short)320, 363);
					num = ⴀႠ[113] - 43382;
					continue;
				case 81:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 211, 230), (DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn13, 'ǔ', 'Ʀ');
					goto case 175;
				case 175:
					num = ⴄ[216] - 14721;
					continue;
				case 201:
					obj20 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj20 as DataGridViewCheckBoxColumn), ႥႥ.Ⴍ(7, 1580608604, 'ä', null), (short)164, 142);
					num = 122;
					continue;
				case 122:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj20, ႥႥ.Ⴍ(7, 1580608604, 'º', null), (short)144, (short)180);
					num = 205;
					continue;
				case 205:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj20 as DataGridViewCheckBoxColumn), ႥႥ.Ⴍ(8, 1580608595, '\u0094', null), (short)775, (short)802);
					num = ⴗ[140] - 60505;
					continue;
				case 180:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(DataGridViewCheckBoxColumn)obj20, (short)860, '\u0332'), DataGridViewContentAlignment.MiddleCenter, 'Ȟ', 639);
					num = 77;
					continue;
				case 77:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj20, 50, 424, 'Ơ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj20 as DataGridViewCheckBoxColumn), ႥႥ.Ⴅ(1673507883, null, 8), (short)235, 192);
					num = 232;
					continue;
				case 232:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 288, 277), (DataGridViewColumn)(DataGridViewCheckBoxColumn)obj20, '\u02e5', 'ʗ');
					num = 214;
					continue;
				case 214:
					obj19 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj19, ClientCty.Ⴗ('¥', 2, 307013552), (short)159, 181);
					num = ⴗ[152] - 31942;
					continue;
				case 224:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj19, ClientCty.Ⴗ('\u009a', 0, 307013554), (short)861, (short)889);
					num = ⴀႠ[115] - 48662;
					continue;
				case 55:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj19, ClientCty.Ⴗ('s', 7, 307013550), (short)696, (short)669);
					num = ⴀႠ[84] - 18722;
					continue;
				case 80:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(obj19 as DataGridViewCheckBoxColumn), (short)845, '\u0323'), DataGridViewContentAlignment.MiddleCenter, 'ɪ', 523);
					num = 155;
					continue;
				case 155:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj19, 50, 831, '\u0337');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj19 as DataGridViewCheckBoxColumn), WxFilters.Ⴀ(null, 4, 103388114), (short)180, 159);
					num = 65;
					continue;
				case 65:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 148, 161), (DataGridViewColumn)(DataGridViewCheckBoxColumn)obj19, 'ƅ', 'Ƿ');
					num = 127;
					continue;
				case 127:
					obj18 = new DataGridViewTextBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj18, ႥႥ.Ⴍ(8, 1580608582, '\u007f', null), (short)874, 832);
					num = 226;
					continue;
				case 226:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj18, ႥႥ.Ⴍ(6, 1580608584, '¹', null), (short)468, (short)496);
					num = 134;
					continue;
				case 134:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj18, ႥႥ.Ⴍ(7, 1580608585, 'ò', null), (short)877, (short)840);
					num = ⴄ[159] - 48343;
					continue;
				case 24:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(DataGridViewTextBoxColumn)obj18, (short)206, '\u00a0'), DataGridViewContentAlignment.MiddleCenter, 'χ', 934);
					num = ⴄ[146] - 18322;
					continue;
				case 231:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj18 as DataGridViewTextBoxColumn), 45, 484, 'Ǭ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj18, ႥႥ.Ⴅ(1673508055, null, 1), (short)322, 361);
					num = ⴄ[155] - 44854;
					continue;
				case 183:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 998, 979), (DataGridViewColumn)(DataGridViewTextBoxColumn)obj18, '\u0329', '\u035b');
					num = ⴄ[302] - 8842;
					continue;
				case 19:
					dataGridViewColumn12 = new DataGridViewTextBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn12 as DataGridViewTextBoxColumn), ClientCty.Ⴗ('>', 6, 307013542), (short)602, 624);
					num = ⴀႠ[89] - 12525;
					continue;
				case 145:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn12, ClientCty.Ⴗ('Ë', 3, 307013539), (short)487, (short)451);
					num = 29;
					continue;
				case 29:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn12 as DataGridViewTextBoxColumn), ClientCty.Ⴗ('t', 1, 307013537), (short)436, (short)401);
					num = 14;
					continue;
				case 14:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(DataGridViewTextBoxColumn)dataGridViewColumn12, (short)390, 'Ǩ'), DataGridViewContentAlignment.MiddleCenter, 'ͺ', 795);
					num = 178;
					continue;
				case 178:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(dataGridViewColumn12 as DataGridViewTextBoxColumn), 45, 3, '\v');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn12 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 8, 103388150), (short)566, 541);
					num = ⴅ[63];
					continue;
				case 195:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 127, 74), (DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn12, 'Ĵ', 'ņ');
					num = 95;
					continue;
				case 95:
					obj17 = new DataGridViewTextBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj17 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(1, 1580608630, '9', null), (short)745, 707);
					num = ⴗ[128] - 43353;
					continue;
				case 170:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj17 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(5, 1580608626, 'K', null), (short)489, (short)461);
					num = ⴅ[345] - 210;
					continue;
				case 42:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj17 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(3, 1580608628, 'À', null), (short)586, (short)623);
					num = 189;
					continue;
				case 189:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(obj17 as DataGridViewTextBoxColumn), (short)993, 'Ώ'), DataGridViewContentAlignment.MiddleCenter, 'ɽ', 540);
					num = 144;
					continue;
				case 144:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj17 as DataGridViewTextBoxColumn), 45, 541, 'ȕ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj17, ႥႥ.Ⴅ(1673508087, null, 1), (short)261, 302);
					num = 69;
					continue;
				case 69:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 344, 365), (DataGridViewColumn)(DataGridViewTextBoxColumn)obj17, 'ɰ', 'Ȃ');
					num = 43;
					continue;
				case 43:
					dataGridViewColumn11 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn11, ClientCty.Ⴗ('\0', 2, 307013588), (short)288, 266);
					num = 98;
					continue;
				case 98:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn11 as DataGridViewCheckBoxColumn), ClientCty.Ⴗ('Æ', 5, 307013587), (short)468, (short)496);
					num = 51;
					continue;
				case 51:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn11 as DataGridViewCheckBoxColumn), ClientCty.Ⴗ('\u0093', 7, 307013585), (short)393, (short)428);
					num = ⴅ[195] + 25;
					continue;
				case 32:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(DataGridViewCheckBoxColumn)dataGridViewColumn11, (short)635, 'ȕ'), DataGridViewContentAlignment.MiddleCenter, '\u031c', 893);
					num = ⴗ[70] - 33405;
					continue;
				case 89:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn11, 45, 233, 'á');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn11 as DataGridViewCheckBoxColumn), WxFilters.Ⴀ(null, 1, 103388054), (short)91, 112);
					num = 2;
					continue;
				case 2:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 483, 470), (DataGridViewColumn)(dataGridViewColumn11 as DataGridViewCheckBoxColumn), '\u02f5', 'ʇ');
					num = 169;
					continue;
				case 169:
					obj16 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj16 as DataGridViewCheckBoxColumn), ႥႥ.Ⴍ(1, 1580608637, '#', null), (short)652, 678);
					num = 104;
					continue;
				case 104:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj16, ႥႥ.Ⴍ(5, 1580608633, 'ä', null), (short)1009, (short)981);
					num = 221;
					continue;
				case 221:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj16, ႥႥ.Ⴍ(0, 1580608636, 'R', null), (short)299, (short)270);
					num = 204;
					continue;
				case 204:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(DataGridViewCheckBoxColumn)obj16, (short)317, 'œ'), DataGridViewContentAlignment.MiddleCenter, 'ɸ', 537);
					num = 133;
					continue;
				case 133:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj16 as DataGridViewCheckBoxColumn), 45, 684, 'ʤ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj16, ႥႥ.Ⴅ(1673507998, null, 4), (short)639, 596);
					num = ⴄ[288] - 36064;
					continue;
				case 125:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 676, 657), (DataGridViewColumn)(obj16 as DataGridViewCheckBoxColumn), '\u0352', '\u0320');
					num = ⴅ[311] - 143;
					continue;
				case 97:
					obj15 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj15 as DataGridViewCheckBoxColumn), ClientCty.Ⴗ('\u001c', 2, 307013583), (short)340, 382);
					num = 123;
					continue;
				case 123:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj15, ClientCty.Ⴗ('Ç', 0, 307013581), (short)829, (short)793);
					num = 199;
					continue;
				case 199:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj15 as DataGridViewCheckBoxColumn), ClientCty.Ⴗ('9', 7, 307013578), (short)123, (short)94);
					num = 182;
					continue;
				case 182:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(obj15 as DataGridViewCheckBoxColumn), (short)665, '\u02f7'), DataGridViewContentAlignment.MiddleCenter, 'Ŷ', 279);
					num = ⴗ[152] - 32047;
					continue;
				case 119:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj15 as DataGridViewCheckBoxColumn), 45, 449, 'ǉ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj15 as DataGridViewCheckBoxColumn), WxFilters.Ⴀ(null, 0, 103388095), (short)522, 545);
					num = 156;
					continue;
				case 156:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 511, 458), (DataGridViewColumn)(obj15 as DataGridViewCheckBoxColumn), '\u02d3', 'ʡ');
					num = 16;
					continue;
				case 16:
					obj14 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj14, ႥႥ.Ⴍ(5, 1580608610, 'x', null), (short)789, 831);
					num = ⴅ[36] + 1;
					continue;
				case 52:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)obj14, ႥႥ.Ⴍ(8, 1580608623, 'Æ', null), (short)940, (short)904);
					num = 5;
					continue;
				case 5:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj14 as DataGridViewCheckBoxColumn), ႥႥ.Ⴍ(1, 1580608614, '\n', null), (short)1009, (short)980);
					num = ⴀႠ[68] - 51522;
					continue;
				case 225:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(obj14 as DataGridViewCheckBoxColumn), (short)298, 'ń'), DataGridViewContentAlignment.MiddleCenter, 'Ψ', 969);
					num = 103;
					continue;
				case 103:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj14 as DataGridViewCheckBoxColumn), 45, 568, 'Ȱ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj14 as DataGridViewCheckBoxColumn), ႥႥ.Ⴅ(1673508685, null, 1), (short)884, 863);
					num = ⴅ[290] - 67;
					continue;
				case 171:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 23, 34), (DataGridViewColumn)(DataGridViewCheckBoxColumn)obj14, 'Ǣ', 'Ɛ');
					num = ⴄ[269] - 37359;
					continue;
				case 190:
					dataGridViewColumn10 = new DataGridViewCheckBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn10 as DataGridViewCheckBoxColumn), ClientCty.Ⴗ('`', 3, 307013575), (short)380, 342);
					num = 47;
					continue;
				case 47:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn10 as DataGridViewCheckBoxColumn), ClientCty.Ⴗ('h', 2, 307013574), (short)1019, (short)991);
					num = ⴅ[130] + 41;
					continue;
				case 72:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn10, ClientCty.Ⴗ('f', 6, 307013570), (short)608, (short)581);
					num = 157;
					continue;
				case 157:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(dataGridViewColumn10 as DataGridViewCheckBoxColumn), (short)167, 'É'), DataGridViewContentAlignment.MiddleCenter, 'ŋ', 298);
					num = ⴀႠ[34] - 62412;
					continue;
				case 152:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn10, 45, 325, 'ō');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn10, WxFilters.Ⴀ(null, 6, 103387230), (short)270, 293);
					num = 198;
					continue;
				case 198:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 924, 937), (DataGridViewColumn)(DataGridViewCheckBoxColumn)dataGridViewColumn10, 't', '\u0006');
					num = ⴄ[216] - 14912;
					continue;
				case 10:
				case 202:
					obj13 = new DataGridViewTextBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj13 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(4, 1580608613, '7', null), (short)38, 12);
					num = 83;
					continue;
				case 83:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj13 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(8, 1580608617, '÷', null), (short)399, (short)427);
					num = 27;
					continue;
				case 27:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj13, ႥႥ.Ⴍ(3, 1580608610, '\u0003', null), (short)918, (short)947);
					num = 194;
					continue;
				case 194:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj13 as DataGridViewTextBoxColumn), 75, 963, 'ϋ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj13, ႥႥ.Ⴍ(4, 1580608613, '\u001a', null), (short)354, 329);
					num = 110;
					continue;
				case 110:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 958, 907), (DataGridViewColumn)(obj13 as DataGridViewTextBoxColumn), 'ˊ', 'ʸ');
					num = ⴅ[105] - 91;
					continue;
				case 105:
					dataGridViewColumn9 = new DataGridViewTextBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn9 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673508678, null, 7), (short)944, 922);
					num = 209;
					continue;
				case 209:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn9, ႥႥ.Ⴅ(1673508681, null, 8), (short)631, (short)595);
					num = ⴀႠ[113] - 43322;
					continue;
				case 141:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn9, ႥႥ.Ⴅ(1673508672, null, 1), (short)564, (short)529);
					num = 163;
					continue;
				case 163:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn9, 75, 646, 'ʎ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn9 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673508697, null, 1), (short)217, 242);
					num = ⴅ[332] - ⴅ[154];
					continue;
				case 3:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 991, 1002), (DataGridViewColumn)(dataGridViewColumn9 as DataGridViewTextBoxColumn), 'q', '\u0003');
					num = ⴗ[93] - 63423;
					continue;
				case 96:
					dataGridViewColumn8 = new DataGridViewTextBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn8, ClientCty.Ⴗ('Ê', 3, 307013629), (short)434, 408);
					num = 101;
					continue;
				case 101:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn8, ClientCty.Ⴗ('\u009d', 1, 307013631), (short)561, (short)533);
					num = 217;
					continue;
				case 217:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn8, ClientCty.Ⴗ('\u0094', 4, 307013626), (short)352, (short)325);
					num = 147;
					continue;
				case 147:
					HighlightCfg.ႳႰ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(DataGridViewTextBoxColumn)dataGridViewColumn8, (short)589, 'ȣ'), DataGridViewContentAlignment.MiddleCenter, '\u0340', 801);
					num = 53;
					continue;
				case 53:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn8, 45, 354, 'Ū');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn8 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 4, 103387261), (short)11, 32);
					num = 67;
					continue;
				case 67:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 736, 725), (DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn8, 'ǉ', 'ƻ');
					num = 75;
					continue;
				case 75:
					obj12 = new DataGridViewTextBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj12, ႥႥ.Ⴍ(0, 1580608616, '¦', null), (short)503, 477);
					num = 34;
					continue;
				case 34:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj12 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(4, 1580608620, '\u00a0', null), (short)237, (short)201);
					num = 146;
					continue;
				case 146:
					HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj12, ႥႥ.Ⴍ(8, 1580608608, '°', null), (short)295, (short)258);
					num = 222;
					continue;
				case 222:
					HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj12 as DataGridViewTextBoxColumn), 45, 689, 'ʹ');
					ShowDxFilter.Ⴃ((DataGridViewColumn)(obj12 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(4, 1580608534, 'õ', null), (short)269, 294);
					num = 17;
					continue;
				case 17:
					ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴐ, 153, 172), (DataGridViewColumn)(DataGridViewTextBoxColumn)obj12, 'Ǯ', 'Ɯ');
					num = 73;
					continue;
				case 73:
					dataGridViewColumn7 = new DataGridViewTextBoxColumn();
					ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn7 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673508711, null, 6), (short)793, 819);
					num = 139;
					continue;
				case 139:
					((DataGridViewTextBoxColumn)dataGridViewColumn7).Name = ႥႥ.Ⴅ(1673508711, null, 6);
					((DataGridViewTextBoxColumn)dataGridViewColumn7).DataPropertyName = ႥႥ.Ⴅ(1673508707, null, 2);
					num = ⴄ[15] - 23858;
					continue;
				case 6:
					((DataGridViewTextBoxColumn)dataGridViewColumn7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					((DataGridViewTextBoxColumn)dataGridViewColumn7).Width = 45;
					((DataGridViewTextBoxColumn)dataGridViewColumn7).ToolTipText = ႥႥ.Ⴅ(1673508709, null, 4);
					num = ⴅ[175] + 83;
					continue;
				case 148:
					Ⴐ.Columns.Add((DataGridViewTextBoxColumn)dataGridViewColumn7);
					obj11 = new DataGridViewTextBoxColumn();
					((DataGridViewTextBoxColumn)obj11).HeaderText = WxFilters.Ⴀ(null, 3, 103387238);
					num = 9;
					continue;
				case 9:
					((DataGridViewTextBoxColumn)obj11).Name = WxFilters.Ⴀ(null, 8, 103387245);
					(obj11 as DataGridViewTextBoxColumn).DataPropertyName = WxFilters.Ⴀ(null, 7, 103387234);
					num = 82;
					continue;
				case 82:
					(obj11 as DataGridViewTextBoxColumn).Width = 85;
					(obj11 as DataGridViewTextBoxColumn).ToolTipText = WxFilters.Ⴀ(null, 7, 103387234);
					num = 18;
					continue;
				case 18:
					Ⴐ.Columns.Add((DataGridViewTextBoxColumn)obj11);
					dataGridViewColumn6 = new DataGridViewTextBoxColumn();
					((DataGridViewTextBoxColumn)dataGridViewColumn6).HeaderText = ႥႥ.Ⴍ(8, 1580608528, '\u0019', null);
					num = 25;
					continue;
				case 25:
					((DataGridViewTextBoxColumn)dataGridViewColumn6).Name = ႥႥ.Ⴍ(7, 1580608543, 'p', null);
					(dataGridViewColumn6 as DataGridViewTextBoxColumn).DataPropertyName = ႥႥ.Ⴍ(1, 1580608537, '\u007f', null);
					num = 59;
					continue;
				case 59:
					(dataGridViewColumn6 as DataGridViewTextBoxColumn).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					((DataGridViewTextBoxColumn)dataGridViewColumn6).Width = 45;
					((DataGridViewTextBoxColumn)dataGridViewColumn6).ToolTipText = ႥႥ.Ⴅ(1673508733, null, 4);
					num = 8;
					continue;
				case 8:
					Ⴐ.Columns.Add(dataGridViewColumn6 as DataGridViewTextBoxColumn);
					obj10 = new DataGridViewTextBoxColumn();
					((DataGridViewTextBoxColumn)obj10).HeaderText = ClientCty.Ⴗ('\a', 5, 307013618);
					num = 158;
					continue;
				case 158:
					((DataGridViewTextBoxColumn)obj10).Name = ClientCty.Ⴗ('ý', 5, 307013618);
					(obj10 as DataGridViewTextBoxColumn).DataPropertyName = ClientCty.Ⴗ('i', 5, 307013618);
					num = ⴅ[329] + 43;
					continue;
				case 219:
					((DataGridViewTextBoxColumn)obj10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					(obj10 as DataGridViewTextBoxColumn).Width = 45;
					((DataGridViewTextBoxColumn)obj10).ToolTipText = WxFilters.Ⴀ(null, 2, 103387152);
					num = 193;
					continue;
				case 193:
					Ⴐ.Columns.Add(obj10 as DataGridViewTextBoxColumn);
					dataGridViewColumn5 = new DataGridViewTextBoxColumn();
					((DataGridViewTextBoxColumn)dataGridViewColumn5).HeaderText = ႥႥ.Ⴍ(6, 1580608524, 'Ë', null);
					num = 206;
					continue;
				case 206:
					(dataGridViewColumn5 as DataGridViewTextBoxColumn).Name = ႥႥ.Ⴍ(7, 1580608525, '+', null);
					((DataGridViewTextBoxColumn)dataGridViewColumn5).DataPropertyName = ႥႥ.Ⴍ(2, 1580608520, '\n', null);
					num = ⴀႠ[116] - 60537;
					continue;
				case 49:
					((DataGridViewTextBoxColumn)dataGridViewColumn5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					(dataGridViewColumn5 as DataGridViewTextBoxColumn).Width = 45;
					(dataGridViewColumn5 as DataGridViewTextBoxColumn).ToolTipText = ႥႥ.Ⴅ(1673508608, null, 8);
					num = ⴀႠ[21];
					continue;
				case 64:
					Ⴐ.Columns.Add((DataGridViewTextBoxColumn)dataGridViewColumn5);
					obj9 = new DataGridViewTextBoxColumn();
					(obj9 as DataGridViewTextBoxColumn).HeaderText = ClientCty.Ⴗ('ó', 5, 307013611);
					num = ⴄ[293] - 38862;
					continue;
				case 31:
					((DataGridViewTextBoxColumn)obj9).Name = ClientCty.Ⴗ('Ô', 2, 307013612);
					(obj9 as DataGridViewTextBoxColumn).DataPropertyName = ClientCty.Ⴗ('Ì', 0, 307013614);
					num = 21;
					continue;
				case 21:
					(obj9 as DataGridViewTextBoxColumn).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					(obj9 as DataGridViewTextBoxColumn).Width = 45;
					(obj9 as DataGridViewTextBoxColumn).ToolTipText = ClientCty.Ⴗ('\u0094', 3, 307013613);
					num = 22;
					continue;
				case 22:
					Ⴐ.Columns.Add(obj9 as DataGridViewTextBoxColumn);
					obj8 = new DataGridViewTextBoxColumn();
					((DataGridViewTextBoxColumn)obj8).HeaderText = ႥႥ.Ⴍ(3, 1580608729, 'Ò', null);
					num = ⴅ[37] + 129;
					continue;
				case 184:
					((DataGridViewTextBoxColumn)obj8).Name = ႥႥ.Ⴍ(1, 1580608731, '¤', null);
					((DataGridViewTextBoxColumn)obj8).DataPropertyName = ႥႥ.Ⴍ(8, 1580608722, '9', null);
					num = 186;
					continue;
				case 186:
					(obj8 as DataGridViewTextBoxColumn).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					((DataGridViewTextBoxColumn)obj8).Width = 45;
					(obj8 as DataGridViewTextBoxColumn).ToolTipText = ႥႥ.Ⴍ(4, 1580608734, 'µ', null);
					num = 41;
					continue;
				case 41:
					Ⴐ.Columns.Add(obj8 as DataGridViewTextBoxColumn);
					dataGridViewColumn4 = new DataGridViewTextBoxColumn();
					((DataGridViewTextBoxColumn)dataGridViewColumn4).HeaderText = ႥႥ.Ⴅ(1673508111, null, 1);
					num = 179;
					continue;
				case 179:
					((DataGridViewTextBoxColumn)dataGridViewColumn4).Name = ႥႥ.Ⴅ(1673508108, null, 2);
					(dataGridViewColumn4 as DataGridViewTextBoxColumn).DataPropertyName = ႥႥ.Ⴅ(1673508107, null, 5);
					num = 79;
					continue;
				case 79:
					((DataGridViewTextBoxColumn)dataGridViewColumn4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					((DataGridViewTextBoxColumn)dataGridViewColumn4).Width = 55;
					(dataGridViewColumn4 as DataGridViewTextBoxColumn).ToolTipText = WxFilters.Ⴀ(null, 0, 103387319);
					num = 207;
					continue;
				case 207:
					Ⴐ.Columns.Add((DataGridViewTextBoxColumn)dataGridViewColumn4);
					dataGridViewColumn3 = new DataGridViewTextBoxColumn();
					((DataGridViewTextBoxColumn)dataGridViewColumn3).HeaderText = ႥႥ.Ⴅ(1673508222, null, 7);
					num = 140;
					continue;
				case 140:
					((DataGridViewTextBoxColumn)dataGridViewColumn3).Name = ႥႥ.Ⴅ(1673508220, null, 5);
					((DataGridViewTextBoxColumn)dataGridViewColumn3).DataPropertyName = ႥႥ.Ⴅ(1673508218, null, 3);
					num = ⴀႠ[128] - 34386;
					continue;
				case 35:
					(dataGridViewColumn3 as DataGridViewTextBoxColumn).Width = 55;
					((DataGridViewTextBoxColumn)dataGridViewColumn3).ToolTipText = ႥႥ.Ⴍ(6, 1580608672, 'ð', null);
					num = ⴀႠ[94] - 21693;
					continue;
				case 135:
					Ⴐ.Columns.Add(dataGridViewColumn3 as DataGridViewTextBoxColumn);
					obj7 = new DataGridViewTextBoxColumn();
					((DataGridViewTextBoxColumn)obj7).HeaderText = WxFilters.Ⴀ(null, 4, 103387656);
					num = 233;
					continue;
				case 233:
					((DataGridViewTextBoxColumn)obj7).Name = WxFilters.Ⴀ(null, 4, 103387656);
					(obj7 as DataGridViewTextBoxColumn).DataPropertyName = WxFilters.Ⴀ(null, 0, 103387660);
					num = 131;
					continue;
				case 131:
					(obj7 as DataGridViewTextBoxColumn).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					(obj7 as DataGridViewTextBoxColumn).Width = 55;
					((DataGridViewTextBoxColumn)obj7).ToolTipText = ClientCty.Ⴗ('\u00a8', 4, 307012712);
					num = ⴄ[179] - 31134;
					continue;
				case 218:
					Ⴐ.Columns.Add((DataGridViewTextBoxColumn)obj7);
					obj6 = new DataGridViewTextBoxColumn();
					(obj6 as DataGridViewTextBoxColumn).HeaderText = WxFilters.Ⴀ(null, 1, 103387306);
					num = ⴀႠ[58] - 24218;
					continue;
				case 115:
					(obj6 as DataGridViewTextBoxColumn).Name = WxFilters.Ⴀ(null, 5, 103387310);
					((DataGridViewTextBoxColumn)obj6).DataPropertyName = WxFilters.Ⴀ(null, 6, 103387309);
					num = 102;
					continue;
				case 102:
					((DataGridViewTextBoxColumn)obj6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					((DataGridViewTextBoxColumn)obj6).Width = 55;
					(obj6 as DataGridViewTextBoxColumn).ToolTipText = ႥႥ.Ⴍ(7, 1580609363, 'M', null);
					num = ⴄ[248] - 4431;
					continue;
				case 143:
					Ⴐ.Columns.Add(obj6 as DataGridViewTextBoxColumn);
					obj5 = new DataGridViewTextBoxColumn();
					(obj5 as DataGridViewTextBoxColumn).HeaderText = ႥႥ.Ⴅ(1673508643, null, 1);
					num = 173;
					continue;
				case 173:
					((DataGridViewTextBoxColumn)obj5).Name = ႥႥ.Ⴅ(1673508646, null, 4);
					((DataGridViewTextBoxColumn)obj5).DataPropertyName = ႥႥ.Ⴅ(1673508647, null, 5);
					num = 212;
					continue;
				case 212:
					((DataGridViewTextBoxColumn)obj5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					((DataGridViewTextBoxColumn)obj5).Width = 55;
					((DataGridViewTextBoxColumn)obj5).ToolTipText = ClientCty.Ⴗ('²', 1, 307012752);
					num = ⴗ[161] - 4890;
					continue;
				case 109:
					Ⴐ.Columns.Add((DataGridViewTextBoxColumn)obj5);
					obj4 = new DataGridViewCheckBoxColumn();
					(obj4 as DataGridViewCheckBoxColumn).HeaderText = WxFilters.Ⴀ(null, 1, 103387469);
					num = 91;
					continue;
				case 91:
					(obj4 as DataGridViewCheckBoxColumn).Name = WxFilters.Ⴀ(null, 0, 103387468);
					((DataGridViewCheckBoxColumn)obj4).DataPropertyName = WxFilters.Ⴀ(null, 5, 103387465);
					num = ⴄ[119] - 8825;
					continue;
				case 172:
					((DataGridViewCheckBoxColumn)obj4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					(obj4 as DataGridViewCheckBoxColumn).Width = 45;
					(obj4 as DataGridViewCheckBoxColumn).ToolTipText = ႥႥ.Ⴍ(7, 1580609349, 'Ç', null);
					num = ⴀႠ[34] - 62397;
					continue;
				case 167:
					Ⴐ.Columns.Add(obj4 as DataGridViewCheckBoxColumn);
					obj3 = new DataGridViewCheckBoxColumn();
					((DataGridViewCheckBoxColumn)obj3).HeaderText = ႥႥ.Ⴅ(1673508813, null, 8);
					num = ⴗ[128] - 43294;
					continue;
				case 229:
					(obj3 as DataGridViewCheckBoxColumn).Name = WxFilters.Ⴀ(null, 4, 103387509);
					((DataGridViewCheckBoxColumn)obj3).DataPropertyName = WxFilters.Ⴀ(null, 0, 103387505);
					num = ⴀႠ[70] - 49033;
					continue;
				case 215:
					(obj3 as DataGridViewCheckBoxColumn).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					(obj3 as DataGridViewCheckBoxColumn).Width = 45;
					((DataGridViewCheckBoxColumn)obj3).ToolTipText = ClientCty.Ⴗ('\u0015', 2, 307012796);
					num = ⴄ[123] - 61524;
					continue;
				case 227:
					Ⴐ.Columns.Add(obj3 as DataGridViewCheckBoxColumn);
					dataGridViewColumn2 = new DataGridViewLinkColumn();
					((DataGridViewLinkColumn)dataGridViewColumn2).HeaderText = WxFilters.Ⴀ(null, 6, 103387652);
					num = 203;
					continue;
				case 203:
					((DataGridViewLinkColumn)dataGridViewColumn2).Name = WxFilters.Ⴀ(null, 7, 103387653);
					(dataGridViewColumn2 as DataGridViewLinkColumn).DataPropertyName = WxFilters.Ⴀ(null, 6, 103387652);
					num = 216;
					continue;
				case 216:
					(dataGridViewColumn2 as DataGridViewLinkColumn).UseColumnTextForLinkValue = false;
					((DataGridViewLinkColumn)dataGridViewColumn2).ActiveLinkColor = Color.White;
					(dataGridViewColumn2 as DataGridViewLinkColumn).LinkBehavior = LinkBehavior.HoverUnderline;
					num = 107;
					continue;
				case 107:
					((DataGridViewLinkColumn)dataGridViewColumn2).LinkColor = Color.Blue;
					((DataGridViewLinkColumn)dataGridViewColumn2).TrackVisitedState = true;
					(dataGridViewColumn2 as DataGridViewLinkColumn).VisitedLinkColor = Color.YellowGreen;
					num = 78;
					continue;
				case 78:
					(dataGridViewColumn2 as DataGridViewLinkColumn).Width = 75;
					((DataGridViewLinkColumn)dataGridViewColumn2).ToolTipText = WxFilters.Ⴀ(null, 8, 103387507);
					num = 15;
					continue;
				case 15:
					Ⴐ.Columns.Add(dataGridViewColumn2 as DataGridViewLinkColumn);
					num2 = 0;
					num = 153;
					continue;
				case 220:
					Ⴐ.Columns[num2].SortMode = DataGridViewColumnSortMode.Programmatic;
					num2++;
					num = ⴀႠ[127] - 218;
					continue;
				case 153:
					num = ((num2 < Ⴐ.Columns.Count - 1) ? (ⴗ[77] - 56884) : (ⴀႠ[31] - 4522));
					continue;
				case 20:
					this.m_Ⴅ.Ⴓ.Caches.Dx.DataSet.Tables[0].Locale = CultureInfo.InvariantCulture;
					num = ⴅ[215] + 81;
					continue;
				case 164:
					collection = new DataView(this.m_Ⴅ.Ⴓ.Caches.Dx.DataSet.Tables[0]);
					num = ⴄ[269] - 37455;
					continue;
				case 94:
				{
					Component component = new BindingSource();
					(component as BindingSource).DataSource = collection as DataView;
					Ⴗ = (BindingSource)component;
					num = 88;
					continue;
				}
				case 88:
					enumerable = UtilsSql.FormatSqlFilter(Filter, SqlFilterType.Dx);
					Ⴗ.Filter = (string)enumerable;
					num = 181;
					continue;
				case 181:
				{
					Ⴐ.DataSource = Ⴗ;
					object obj2 = new DgvFilterManager(Ⴐ);
					this.m_Ⴅ.Ⴃ = obj2 as DgvFilterManager;
					num = ⴄ[116] - 53545;
					continue;
				}
				case 58:
					this.m_Ⴅ.Ⴃ.BaseFilter = enumerable as string;
					this.m_Ⴅ.Ⴃ[ႥႥ.Ⴅ(1673507916, null, 0)] = new DgvTextBoxColumnFilter();
					num = ⴅ[319];
					continue;
				case 138:
					this.m_Ⴅ.Ⴃ.FilterChanged += ႭႣ;
					this.m_Ⴅ.Ⴃ.FilterSaved += Ⴜ;
					num = 128;
					continue;
				case 128:
				{
					object obj = new DataGridViewColumnSelector(Ⴐ);
					((DataGridViewColumnSelector)obj).MaxHeight = 250;
					(obj as DataGridViewColumnSelector).Width = 110;
					num = 63;
					continue;
				}
				case 63:
					ႭႣ(null, Filter);
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			_ = ex.Message;
		}
		switch (1)
		{
		}
	}

	private void Ⴜ(object P_0, string P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_1 = ShowDxFilter.Ⴗ(P_1, 439, 'Ƌ');
				obj = new FilterEditor(this.m_Ⴅ.Ⴓ, FilterType.DX);
				goto case 5;
			case 5:
				num = ⴅ[374] - 32;
				break;
			case 3:
				((FilterEditor)obj).Filter = P_1;
				FilterPicker.ႥႷ((Form)(FilterEditor)obj, 'ŭ', (short)298);
				num = ⴅ[285] / 5;
				break;
			case 1:
				num = ((FilterPicker.ႥႷ((Form)(obj as FilterEditor), 'Ō', (short)260) != DialogResult.OK) ? (ⴀႠ[81] - 54676) : (ⴗ[93] - 63517));
				break;
			case 2:
			case 6:
				this.m_Ⴅ.Ⴓ.Cfg.Filters.Dx.List.Add(new DxFilter((obj as FilterEditor).FilterName, ((FilterEditor)obj).Filter));
				return;
			case 4:
				return;
			}
		}
	}

	private void ႭႣ(object P_0, string P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				P_1 = ShowDxFilter.Ⴗ(P_1, 472, 'Ǥ');
				Filter = P_1;
				goto case 2;
			case 2:
				if (ႳႳ.Ⴓ(FilterName, '\u001e', 56) > 0)
				{
					num = 1;
					break;
				}
				while (true)
				{
					int num2 = ((ႳႳ.Ⴓ(P_1, 'ɟ', 633) <= 0) ? (ⴀႠ[84] - 18795) : ⴅ[25]);
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 5:
							break;
						case 2:
							ႥႠ.ႭႤ((Control)this, DxFilters.Ⴈ(WxFilters.Ⴀ(null, 8, 103387810), P_1, 24, 64), 'ϥ', '\u0385');
							goto IL_0150;
						case 4:
							goto IL_0150;
						case 0:
							base.ToolTipText = WxFilters.Ⴀ(null, 4, 103387413) + P_1;
							return;
						case 1:
						case 7:
							Text = ႥႥ.Ⴍ(3, 1580608961, 'V', P_1);
							base.ToolTipText = ႥႥ.Ⴅ(1673508831, null, 6);
							return;
						}
						break;
						IL_0150:
						num2 = 0;
					}
				}
			case 1:
				ႥႠ.ႭႤ((Control)this, DxFilters.Ⴈ(WxFilters.Ⴀ(null, 8, 103387810), FilterName, 800, 888), '\u0352', '\u0332');
				num = 4;
				break;
			case 0:
			case 4:
				SetDxExtension.Ⴃ((DockContent)this, FilterPicker.ႥႠ(WxFilters.Ⴀ(null, 5, 103387502), FilterName, ႥႥ.Ⴅ(1673508806, null, 5), P_1, 607, 549), (short)73, '4');
				return;
			case 5:
				return;
			}
		}
	}

	private void ႭႭ(object P_0, FormClosingEventArgs P_1)
	{
		SaveGridState();
	}

	public void SaveGridState()
	{
		char[] ⴄ = Bye.Ⴄ;
		IList list = new StringCollection();
		int num = 0;
		object obj = DxSpotRateGraph.Ⴅ((BaseCollection)HighlightCountyCfg.ႷႣ(Ⴐ, 343, 354), (short)447, (short)412);
		try
		{
			int num2 = 4;
			object obj2 = default(object);
			while (true)
			{
				switch (num2)
				{
				case 0:
					obj2 = (DataGridViewColumn)(obj as IEnumerator).Current;
					goto case 1;
				case 1:
				case 6:
				{
					StringCollection obj3 = (StringCollection)list;
					string format = WxFilters.Ⴀ(null, 5, 103387417);
					Array array = new object[4];
					object[] obj4 = array as object[];
					int num3 = ShowUsers.Ⴈ((DataGridViewColumn)obj2, 318, 264);
					obj4[0] = HighlightArrlSectionCfg.Ⴅ(ref num3, ClientCty.Ⴗ('ã', 5, 307012780), 446, 401);
					((object[])array)[1] = ShowUsers.Ⴈ(obj2 as DataGridViewColumn, 858, 877);
					(array as object[])[2] = HighlightCqZoneCfg.Ⴜ((DataGridViewBand)(DataGridViewColumn)obj2, 198, (short)147);
					((object[])array)[3] = num++;
					obj3.Add(string.Format(format, (object[])array));
					num2 = ⴄ[277] - 52016;
					break;
				}
				default:
					num2 = ((!((IEnumerator)obj).MoveNext()) ? 5 : 0);
					break;
				case 5:
					return;
				}
			}
		}
		finally
		{
			int num4 = 4;
			object obj5 = default(object);
			while (true)
			{
				bool num5;
				switch (num4)
				{
				default:
					obj5 = (obj as IEnumerator) as IDisposable;
					num5 = obj5 is IDisposable;
					goto IL_019e;
				case 1:
				case 2:
				case 3:
				case 5:
					((IDisposable)obj5).Dispose();
					break;
				case 0:
					break;
				}
				break;
				IL_019e:
				num4 = (num5 ? 1 : 0);
			}
		}
	}

	public void AutoScrollGrid()
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 0:
				HighlightItuZoneCfg.ႳႤ(Ⴐ, SkimmerSpotRateGraph.ႤႤ(Ⴐ, 997, 'Κ') - 1, 681, '\u02f7');
				num = 2;
				continue;
			case 2:
			case 3:
				ShowUsers.Ⴄ(Ⴐ, 493, 'ǟ');
				ClientCfg.Ⴜ(Ⴐ, 'ɍ', 583)[Ⴐ.RowCount - 1].Selected = true;
				num = 5;
				continue;
			case 5:
				Ⴐ.ClearSelection();
				return;
			case 6:
				return;
			}
			int num3;
			if (SkimmerSpotRateGraph.ႤႤ(Ⴐ, 657, 'ˮ') > 0)
			{
				char num2 = ⴄ[163];
				HighlightCtyCfg.ႠႠ[12] = (char)((HighlightCtyCfg.ႠႠ[12] | HighlightCtyCfg.ႠႠ[116]) & 0x4E);
				num3 = num2 - 58296;
			}
			else
			{
				num3 = 6;
			}
			num = num3;
		}
	}

	private void ႭႨ(object P_0, DataGridViewCellEventArgs P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				UserInfo.Ⴜ((Control)this, HighlightSpotterCfg.Ⴗ('h', 60), (short)336, 'ń');
				break;
			case 0:
			case 4:
				break;
			case 1:
			case 2:
				return;
			}
			if (FilterViewer.ႨႤ(P_1, 994, 1008) >= 0)
			{
				break;
			}
			num = 2;
		}
		object obj = default(object);
		ICloneable cloneable = default(ICloneable);
		IComparable comparable2 = default(IComparable);
		IComparable noSsidCall2 = default(IComparable);
		IEnumerable<char> noSsidCall = default(IEnumerable<char>);
		while (true)
		{
			IComparable comparable = TelnetServerCfg.Ⴀ(SetDxFilter.Ⴍ(HighlightCountyCfg.ႷႣ(Ⴐ, 393, 444), HighlightCqZoneCfg.ႣႷ(P_1, '\u02f9', 'ʋ'), 102, '_'), 251, 'Ù');
			int num2 = ⴅ[98] - 65;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					return;
				case 13:
					break;
				case 12:
					obj = HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(Ⴐ, 'Ʒ', 445), FilterViewer.ႨႤ(P_1, 772, 790), '%', 'd');
					num2 = ⴅ[120] - 105;
					continue;
				case 11:
					num2 = (((cloneable = (string)comparable) == null) ? 1 : 6);
					continue;
				case 6:
					num2 = (DxCommentExtCfg.ႤႰ(cloneable as string, WxFilters.Ⴀ(null, 1, 103387821), '\u02f8', 734) ? (ⴗ[98] - 39644) : 3);
					continue;
				case 3:
					num2 = (DxCommentExtCfg.ႤႰ((string)cloneable, ႥႥ.Ⴅ(1673508207, null, 8), 'û', 221) ? 14 : 4);
					continue;
				case 0:
				case 4:
				{
					bool num3 = DxCommentExtCfg.ႤႰ((string)cloneable, WxFilters.Ⴀ(null, 3, 103387649), '\u036c', 842);
					Bye.Ⴄ[137] = (char)((Bye.Ⴄ[137] ^ Bye.Ⴄ[260]) & 0xC2);
					num2 = (num3 ? (ⴅ[256] - ⴅ[0]) : 9);
					continue;
				}
				case 9:
					num2 = 1;
					continue;
				case 2:
					comparable2 = ShowDxFilter.Ⴗ(FilterCfg.Ⴓ(AnnFilters.Ⴗ(DxSpotRates.ႠႳ(HighlightCallCfg.Ⴓ(obj as DataGridViewRow, 744, 'ʞ'), WxFilters.Ⴀ(null, 1, 103387821), 743, 652), 'g', 89), 925, 'ϳ'), 222, 'ã');
					num2 = ⴅ[105] - 191;
					continue;
				case 5:
					Process.Start(ႥႥ.Ⴍ(4, 1580609298, '\'', null) + (string)comparable2);
					num2 = 1;
					continue;
				case 14:
					noSsidCall2 = UtilsCallsign.GetNoSsidCall((obj as DataGridViewRow).Cells[ႥႥ.Ⴅ(1673508192, null, 7)].Value.ToString());
					num2 = 15;
					continue;
				case 10:
				case 15:
					Process.Start(ႥႥ.Ⴍ(8, 1580609310, 'Ó', null) + (noSsidCall2 as string));
					num2 = ⴀႠ[35] - 25314;
					continue;
				case 7:
				case 17:
					noSsidCall = UtilsCallsign.GetNoSsidCall(((DataGridViewRow)obj).Cells[WxFilters.Ⴀ(null, 8, 103387658)].Value.ToString());
					num2 = ⴀႠ[0] - 49949;
					continue;
				case 8:
					Process.Start(ႥႥ.Ⴍ(5, 1580609299, 'ê', null) + (string)noSsidCall);
					num2 = ⴄ[116] - 53602;
					continue;
				case 1:
					Cursor = Cursors.Default;
					return;
				}
				break;
			}
		}
	}

	internal void ႭႠ(object P_0, DataGridViewDataErrorEventArgs P_1)
	{
		HighlightItuZoneCfg.ႳႠ(P_1, false, 213, '\u0094');
	}

	private void ႭႤ(object P_0, DataGridViewCellFormattingEventArgs P_1)
	{
		ClientCty.ႠႨ((ConvertEventArgs)P_1, 407, (short)412);
	}

	private void ႭႰ(object P_0, DataGridViewCellEventArgs P_1)
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 3;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			switch (num)
			{
			default:
				num = ((FilterViewer.ႨႤ(P_1, 755, 737) < 0) ? (ⴗ[16] - 26637) : 2);
				break;
			case 2:
				num = ((FilterViewer.ႨႤ(P_1, 225, 243) >= DxSpotRates.ႠႤ(ClientCfg.Ⴜ(Ⴐ, '\u02f5', 767), 983, 924)) ? 4 : 0);
				break;
			case 0:
			case 6:
				num = ((HighlightCqZoneCfg.ႣႷ(P_1, 'Ǳ', 'ƃ') < 0) ? 4 : (ⴀႠ[112] - 45129));
				break;
			case 5:
				if (HighlightCqZoneCfg.ႣႷ(P_1, 'ˏ', 'ʽ') >= SkimmerSpotRateGraph.ႤႣ((BaseCollection)HighlightCountyCfg.ႷႣ(Ⴐ, 800, 789), '\u0344', 775))
				{
					num = 4;
					break;
				}
				while (true)
				{
					object obj = HighlightCallCfg.Ⴓ(HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(Ⴐ, '\u007f', 117), FilterViewer.ႨႤ(P_1, 607, 589), '\u033b', 'ͺ'), 279, 'š')[P_1.ColumnIndex] as DataGridViewLinkCell;
					int num2 = 9;
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 6:
							return;
						case 1:
							break;
						case 9:
						{
							DataGridViewLinkCell obj2 = obj as DataGridViewLinkCell;
							ႥႰ.Ⴗ[107] = (char)((ႥႰ.Ⴗ[107] + HighlightCtyCfg.ႠႠ[103]) & 0x2A);
							num2 = ((obj2 == null) ? (ⴄ[47] - 24196) : 0);
							continue;
						}
						case 0:
							equatable = (obj as DataGridViewLinkCell).Value.ToString();
							num2 = (((string)equatable == null) ? 5 : ⴅ[25]);
							continue;
						case 2:
						case 7:
							equatable = UtilsCallsign.GetNoSsidCall(equatable as string);
							equatable = UtilsCallsign.ScrubCall((string)equatable);
							num2 = (((equatable as string).Length <= 0) ? 5 : 4);
							continue;
						case 4:
							Process.Start(ႥႥ.Ⴍ(8, 1580609287, '\u0019', null) + (equatable as string));
							num2 = 5;
							continue;
						case 5:
							return;
						}
						break;
					}
				}
			case 4:
				return;
			}
		}
	}

	private void ႭႥ(object P_0, DataGridViewCellToolTipTextNeededEventArgs P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 7;
		ICloneable cloneable = default(ICloneable);
		IEquatable<string> equatable = default(IEquatable<string>);
		IComparable comparable = default(IComparable);
		IDisposable disposable = default(IDisposable);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			switch (num)
			{
			default:
				num = ((FilterViewer.ႨႤ((DataGridViewCellEventArgs)P_1, (short)824, (short)810) <= -1) ? 6 : (ⴅ[18] - 33));
				break;
			case 3:
				num = ((HighlightCqZoneCfg.ႣႷ((DataGridViewCellEventArgs)P_1, 'ï', '\u009d') != DxccCacheData.ႷႰ((DataGridViewBand)FilterPicker.ႥႭ(HighlightCountyCfg.ႷႣ(Ⴐ, 416, 405), WxFilters.Ⴀ(null, 3, 103387823), 553, 610), (short)638, 549)) ? (ⴀႠ[127] - 359) : 4);
				break;
			case 4:
				cloneable = FilterViewer.ႨႳ(HighlightCallCfg.Ⴓ(HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(Ⴐ, '\u001d', 23), FilterViewer.ႨႤ((DataGridViewCellEventArgs)P_1, (short)338, (short)320), 'É', '\u0088'), 918, 'Ϡ'), HighlightCqZoneCfg.ႣႷ((DataGridViewCellEventArgs)P_1, 'm', '\u001f'), 'ȴ', 'ɿ');
				num = ⴄ[213] - 64958;
				break;
			case 10:
				equatable = FilterCfg.Ⴓ(DxEmailCfg.Ⴃ(FilterViewer.ႨႳ(HighlightCallCfg.Ⴓ(HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(Ⴐ, 'È', 194), FilterViewer.ႨႤ((DataGridViewCellEventArgs)P_1, (short)2, (short)16), 'Ş', 'ğ'), 160, 'Ö'), HighlightCqZoneCfg.ႣႷ((DataGridViewCellEventArgs)P_1, 'Ǚ', 'ƫ'), '\u035d', '\u0316'), 633, 523), 86, '8');
				num = ⴗ[21] - 63698;
				break;
			case 11:
				comparable = HighlightCallCfg.Ⴓ(HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(Ⴐ, 'g', 109), FilterViewer.ႨႤ((DataGridViewCellEventArgs)P_1, (short)940, (short)958), '¢', 'ã'), 481, 'Ɨ')[ႥႥ.Ⴍ(6, 1580608622, '^', null)].FormattedValue.ToString();
				goto case 0;
			case 0:
				num = ⴀႠ[84] - 18793;
				break;
			case 9:
				((DataGridViewCell)cloneable).ToolTipText = this.m_Ⴅ.Ⴓ.Caches.Dxcc.GetToolTipInfo((string)comparable, equatable as string);
				goto case 12;
			case 12:
			case 13:
				num = ((P_1.ColumnIndex != Ⴐ.Columns[ႥႥ.Ⴍ(8, 1580608608, 'O', null)].Index) ? 6 : 5);
				break;
			case 1:
			case 5:
				disposable = Ⴐ.Rows[P_1.RowIndex].Cells[P_1.ColumnIndex];
				num = ⴗ[137] - 1362;
				break;
			case 8:
				enumerable = Ⴐ.Rows[P_1.RowIndex].Cells[P_1.ColumnIndex].FormattedValue.ToString();
				num = 2;
				break;
			case 2:
				((DataGridViewCell)disposable).ToolTipText = this.m_Ⴅ.Ⴓ.Caches.Dxcc.GetToolTipInfo((string)enumerable, string.Empty);
				return;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static DxWindow()
	{
		ArcClientConnectDat.Ⴍ();
		Ⴃ = new object();
	}
}
