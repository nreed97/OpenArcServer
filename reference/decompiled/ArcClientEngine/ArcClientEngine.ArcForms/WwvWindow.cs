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
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using WeifenLuo.WinFormsUI.Docking;
using Ⴀ;

namespace ArcClientEngine.ArcForms;

public class WwvWindow : DockContent
{
	private IContainer Ⴀ;

	internal DataGridView Ⴓ;

	private ArcClientObjMgr Ⴃ;

	private BindingSource Ⴍ;

	private static readonly object Ⴈ;

	private DgvFilterManager Ⴄ;

	protected override void Dispose(bool disposing)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? 5 : 3);
				continue;
			case 0:
			case 3:
			{
				int num3;
				if (Ⴀ != null)
				{
					char num2 = ⴀႠ[104];
					ႥႰ.Ⴗ[53] = (char)((ႥႰ.Ⴗ[53] | HighlightCtyCfg.ႠႠ[90]) & 0xD6);
					num3 = num2 - 61263;
				}
				else
				{
					num3 = ⴗ[103] - 55686;
				}
				num = num3;
				continue;
			}
			case 1:
			case 4:
				Ⴀ.Dispose();
				break;
			case 5:
			case 6:
				break;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void Ⴗ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 19;
		ICloneable cloneable4 = default(ICloneable);
		ICloneable cloneable3 = default(ICloneable);
		ICloneable cloneable2 = default(ICloneable);
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			switch (num)
			{
			default:
				cloneable4 = new DataGridViewCellStyle();
				cloneable3 = new DataGridViewCellStyle();
				cloneable2 = new DataGridViewCellStyle();
				cloneable = new DataGridViewCellStyle();
				Ⴓ = new DataGridView();
				num = 2;
				break;
			case 2:
				((ISupportInitialize)Ⴓ).BeginInit();
				AnnFilters.Ⴓ((Control)this, 'Ł', 'Ş');
				DxSpotRates.ႠႠ(Ⴓ, false, 900, 931);
				num = ⴅ[132] - ⴅ[0];
				break;
			case 27:
				DxSpotRates.ႠႠ(Ⴓ, false, 615, 591);
				ArcClientConnectDat.Ⴈ(Ⴓ, true, 450, 'Ǌ');
				num = 28;
				break;
			case 28:
				DxSpotRates.ႠႠ(Ⴓ, false, 446, 407);
				ႳႰ.Ⴃ(cloneable4 as DataGridViewCellStyle, ClientCfg.Ⴍ(698, 726), 312, 365);
				num = 21;
				break;
			case 21:
				ႳႰ.Ⴃ((DataGridViewCellStyle)cloneable4, DxEmailCfg.Ⴍ(830, 841), 753, 679);
				num = 20;
				break;
			case 20:
				DxSpotRates.ႠႭ(Ⴓ, cloneable4 as DataGridViewCellStyle, 211, 205);
				HighlightCfg.ႳႰ((DataGridViewCellStyle)cloneable3, DataGridViewContentAlignment.MiddleLeft, '\u02c4', 677);
				num = ⴗ[152] - 32142;
				break;
			case 24:
				DxccCacheData.ႷႳ((DataGridViewCellStyle)cloneable3, HighlightItuZoneCfg.ႳႷ(806, 834), 738, 'ˁ');
				num = ⴀႠ[104] - 61256;
				break;
			case 11:
				DxSpotRateGraph.Ⴗ((DataGridViewCellStyle)cloneable3, new Font(ႥႥ.Ⴅ(1673508263, null, 2), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), '\u0380', 967);
				num = 5;
				break;
			case 5:
				DxSpotRates.ႠႨ(cloneable3 as DataGridViewCellStyle, HighlightItuZoneCfg.ႳႷ(863, 826), 'ʞ', 709);
				num = ⴄ[13] - 20635;
				break;
			case 25:
				ႳႰ.Ⴃ((DataGridViewCellStyle)cloneable3, ClientCfg.Ⴍ(175, 195), 553, 636);
				num = 22;
				break;
			case 22:
				ႳႰ.Ⴃ((DataGridViewCellStyle)cloneable3, DxEmailCfg.Ⴍ(975, 952), 913, 967);
				num = ⴅ[194] - 17;
				break;
			case 12:
				ArcClientConnectDat.ႷႭ(cloneable3 as DataGridViewCellStyle, DataGridViewTriState.True, 13, 'o');
				HighlightCountyCfg.ႷႠ(Ⴓ, cloneable3 as DataGridViewCellStyle, 966, 1011);
				num = 30;
				break;
			case 30:
				ႳႳ.Ⴅ(Ⴓ, DataGridViewColumnHeadersHeightSizeMode.AutoSize, 'ƾ', 434);
				HighlightCfg.ႳႰ((DataGridViewCellStyle)cloneable2, DataGridViewContentAlignment.MiddleLeft, 'ɛ', 570);
				num = ⴄ[180] - 27665;
				break;
			case 31:
				DxccCacheData.ႷႳ((DataGridViewCellStyle)cloneable2, HighlightCallCfg.Ⴄ(857, 863), 519, 'Ȥ');
				num = 6;
				break;
			case 6:
				DxSpotRateGraph.Ⴗ(cloneable2 as DataGridViewCellStyle, new Font(WxFilters.Ⴀ(null, 8, 103387629), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), 'ȗ', 592);
				num = 17;
				break;
			case 17:
				DxSpotRates.ႠႨ(cloneable2 as DataGridViewCellStyle, HighlightItuZoneCfg.ႳႷ(466, 436), 'ƚ', 449);
				num = 23;
				break;
			case 23:
				ႳႰ.Ⴃ((DataGridViewCellStyle)cloneable2, ClientCfg.Ⴍ(237, 129), 113, 36);
				num = 9;
				break;
			case 9:
				ႳႰ.Ⴃ((DataGridViewCellStyle)cloneable2, DxEmailCfg.Ⴍ(931, 980), 2, 84);
				num = ⴀႠ[127] - 339;
				break;
			case 32:
				ArcClientConnectDat.ႷႭ((DataGridViewCellStyle)cloneable2, DataGridViewTriState.False, 328, 'Ī');
				HighlightCqZoneCfg.Ⴍ(Ⴓ, (DataGridViewCellStyle)cloneable2, 147, 173);
				num = 33;
				break;
			case 33:
				MultimediaCache.Ⴄ((Control)Ⴓ, DockStyle.Fill, 119, (short)74);
				HighlightCountyCfg.Ⴜ((Control)Ⴓ, new Point(0, 0), 361, 314);
				num = 16;
				break;
			case 16:
				FilterEditor.ႷႤ(Ⴓ, false, 800, 873);
				ႥႤ.Ⴀ((Control)Ⴓ, ႥႥ.Ⴅ(1673508433, null, 5), 'Ģ', 'ŏ');
				num = ⴅ[18] / 2;
				break;
			case 18:
				ArcClientConnectDat.Ⴈ(Ⴓ, true, 19, '\u001a');
				HighlightCfg.ႳႰ((DataGridViewCellStyle)cloneable, DataGridViewContentAlignment.MiddleLeft, 'Ƚ', 604);
				num = 4;
				break;
			case 4:
				((DataGridViewCellStyle)cloneable).BackColor = HighlightItuZoneCfg.ႳႷ(380, 280);
				(cloneable as DataGridViewCellStyle).Font = new Font(ႥႥ.Ⴅ(1673508261, null, 0), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
				num = 10;
				break;
			case 10:
				(cloneable as DataGridViewCellStyle).ForeColor = SystemColors.WindowText;
				(cloneable as DataGridViewCellStyle).SelectionBackColor = Color.White;
				goto case 8;
			case 8:
				((DataGridViewCellStyle)cloneable).SelectionForeColor = Color.Black;
				num = ⴅ[194];
				break;
			case 29:
				((DataGridViewCellStyle)cloneable).WrapMode = DataGridViewTriState.True;
				Ⴓ.RowHeadersDefaultCellStyle = (DataGridViewCellStyle)cloneable;
				Ⴓ.RowTemplate.Height = 24;
				goto case 34;
			case 34:
				num = 26;
				break;
			case 26:
				Ⴓ.Size = new Size(634, 273);
				Ⴓ.TabIndex = 2;
				num = 15;
				break;
			case 15:
				Ⴓ.CellContentClick += ႷႷ;
				Ⴓ.CellContentDoubleClick += Ⴅ;
				num = ⴀႠ[31] - 4535;
				break;
			case 7:
				Ⴓ.CellFormatting += ႷႠ;
				Ⴓ.DataError += Ⴜ;
				num = 1;
				break;
			case 1:
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				base.AutoScaleMode = AutoScaleMode.Font;
				base.ClientSize = new Size(634, 273);
				num = 0;
				break;
			case 0:
				base.Controls.Add(Ⴓ);
				Font = new Font(ႥႥ.Ⴅ(1673508263, null, 2), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
				num = 13;
				break;
			case 13:
				base.Name = ႥႥ.Ⴅ(1673507591, null, 8);
				Text = ClientCty.Ⴗ('»', 7, 307011813);
				num = 14;
				break;
			case 3:
			case 14:
				base.FormClosing += Ⴐ;
				((ISupportInitialize)Ⴓ).EndInit();
				ResumeLayout(performLayout: false);
				return;
			}
		}
	}

	public WwvWindow()
	{
		Ⴗ();
	}

	public void Init(ArcClientObjMgr om)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 45;
		DataGridViewColumn dataGridViewColumn = default(DataGridViewColumn);
		object obj6 = default(object);
		object obj5 = default(object);
		DataGridViewColumn dataGridViewColumn4 = default(DataGridViewColumn);
		DataGridViewColumn dataGridViewColumn3 = default(DataGridViewColumn);
		object obj4 = default(object);
		object obj3 = default(object);
		DataGridViewColumn dataGridViewColumn2 = default(DataGridViewColumn);
		int num2 = default(int);
		object obj2 = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				Ⴃ = om;
				ArcClientConnectDat.Ⴈ(Ⴓ, false, 753, '\u02fb');
				num = 46;
				break;
			case 46:
				dataGridViewColumn = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 8, 103387740), (short)219, 241);
				num = 24;
				break;
			case 24:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, WxFilters.Ⴀ(null, 8, 103387740), (short)114, (short)86);
				num = ⴗ[24] - 32607;
				break;
			case 43:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, WxFilters.Ⴀ(null, 0, 103387732), (short)834, (short)871);
				num = 29;
				break;
			case 29:
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, ClientCty.Ⴗ('\u009d', 3, 307013430), (short)440, 403);
				num = ⴗ[47] - 42955;
				break;
			case 50:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), 55, 130, '\u008a');
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴓ, 121, 76), (DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), '\u0010', 'b');
				num = 28;
				break;
			case 28:
				obj6 = new DataGridViewTextBoxColumn();
				goto case 5;
			case 5:
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj6 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673507915, null, 7), (short)318, 276);
				num = ⴄ[247] - 48898;
				break;
			case 8:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj6 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673507919, null, 3), (short)868, (short)832);
				num = 40;
				break;
			case 40:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj6, WxFilters.Ⴀ(null, 5, 103387706), (short)399, (short)426);
				num = ⴀႠ[16] - 39523;
				break;
			case 42:
				ShowUsers.Ⴀ(DxSpotRateGraph.Ⴀ((DataGridViewBand)(obj6 as DataGridViewTextBoxColumn), (short)627, 'ȝ'), ClientCty.Ⴗ('R', 8, 307012907), 888, 851);
				num = ⴄ[13] - 20607;
				break;
			case 53:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj6, 75, 363, 'ţ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj6 as DataGridViewTextBoxColumn), ClientCty.Ⴗ('n', 7, 307013411), (short)454, 493);
				num = 39;
				break;
			case 39:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴓ, 25, 44), (DataGridViewColumn)(DataGridViewTextBoxColumn)obj6, 'ɩ', 'ț');
				num = 27;
				break;
			case 27:
				obj5 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj5 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673507588, null, 7), (short)921, 947);
				num = 0;
				break;
			case 0:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj5, ႥႥ.Ⴅ(1673508662, null, 5), (short)161, (short)133);
				num = 16;
				break;
			case 16:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj5, ႥႥ.Ⴅ(1673508663, null, 4), (short)934, (short)899);
				num = 26;
				break;
			case 26:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj5, 50, 420, 'Ƭ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj5 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(2, 1580608458, '®', null), (short)623, 580);
				num = 18;
				break;
			case 18:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴓ, 105, 92), (DataGridViewColumn)(obj5 as DataGridViewTextBoxColumn), '\u0301', 'ͳ');
				num = 12;
				break;
			case 12:
				dataGridViewColumn4 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn4 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 7, 103387482), (short)832, 874);
				num = 47;
				break;
			case 47:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn4, WxFilters.Ⴀ(null, 0, 103387485), (short)348, (short)376);
				num = 25;
				break;
			case 25:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn4, WxFilters.Ⴀ(null, 4, 103387481), (short)790, (short)819);
				num = 55;
				break;
			case 55:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn4, 50, 707, 'ˋ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn4 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(7, 1580608480, 'M', null), (short)309, 286);
				num = 38;
				break;
			case 38:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴓ, 367, 346), (DataGridViewColumn)(dataGridViewColumn4 as DataGridViewTextBoxColumn), 'Ú', '\u00a8');
				num = ⴀႠ[111] - 49542;
				break;
			case 19:
				dataGridViewColumn3 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn3, ႥႥ.Ⴅ(1673508813, null, 4), (short)955, 913);
				num = ⴀႠ[24] - 40384;
				break;
			case 30:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn3 as DataGridViewTextBoxColumn), ႥႥ.Ⴅ(1673508812, null, 5), (short)272, (short)308);
				num = 1;
				break;
			case 1:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn3, ႥႥ.Ⴅ(1673508812, null, 5), (short)720, (short)757);
				num = 3;
				break;
			case 3:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn3, 50, 257, 'ĉ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn3, ClientCty.Ⴗ('\u0012', 2, 307011870), (short)226, 201);
				num = 31;
				break;
			case 31:
			case 52:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴓ, 465, 484), (DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn3, 'ϱ', '\u0383');
				num = ⴅ[230] - ⴅ[17];
				break;
			case 7:
				obj4 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj4 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 5, 103387460), (short)108, 70);
				num = ⴅ[336] - 127;
				break;
			case 44:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj4 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 4, 103387461), (short)490, (short)462);
				num = 9;
				break;
			case 9:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj4 as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 2, 103387459), (short)333, (short)360);
				num = 34;
				break;
			case 34:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj4 as DataGridViewTextBoxColumn), 350, 393, 'Ɓ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj4, WxFilters.Ⴀ(null, 4, 103387461), (short)835, 872);
				num = ⴄ[174] - 46415;
				break;
			case 4:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(Ⴓ, 261, 304), (DataGridViewColumn)(DataGridViewTextBoxColumn)obj4, 'ǹ', 'Ƌ');
				num = ⴄ[2] - 13937;
				break;
			case 17:
				obj3 = new DataGridViewLinkColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj3 as DataGridViewLinkColumn), ႥႥ.Ⴅ(1673508198, null, 1), (short)399, 421);
				num = ⴅ[330] - 17;
				break;
			case 20:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj3 as DataGridViewLinkColumn), ႥႥ.Ⴅ(1673508195, null, 4), (short)465, (short)501);
				num = 54;
				break;
			case 54:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewLinkColumn)obj3, ႥႥ.Ⴅ(1673508207, null, 8), (short)781, (short)808);
				num = ⴅ[343] - ⴅ[7];
				break;
			case 10:
				ႳႰ.Ⴓ(obj3 as DataGridViewLinkColumn, false, 702, 688);
				HighlightItuZoneCfg.ႳႣ(obj3 as DataGridViewLinkColumn, ClientCfg.Ⴍ(336, 316), 256, 368);
				num = 23;
				break;
			case 23:
				ArcClientConnectDat.ႷႷ(obj3 as DataGridViewLinkColumn, LinkBehavior.HoverUnderline, 'Ǔ', 437);
				HighlightItuZoneCfg.ႳႣ((DataGridViewLinkColumn)obj3, DxEmailCfg.Ⴍ(909, 1019), 729, 680);
				num = ⴀႠ[9] - 28065;
				break;
			case 2:
			case 51:
				(obj3 as DataGridViewLinkColumn).TrackVisitedState = true;
				(obj3 as DataGridViewLinkColumn).VisitedLinkColor = Color.YellowGreen;
				((DataGridViewLinkColumn)obj3).Width = 75;
				num = ⴗ[156] - 48782;
				break;
			case 48:
				(obj3 as DataGridViewLinkColumn).ToolTipText = ႥႥ.Ⴅ(1673508207, null, 8);
				Ⴓ.Columns.Add(obj3 as DataGridViewLinkColumn);
				num = 11;
				break;
			case 11:
				dataGridViewColumn2 = new DataGridViewLinkColumn();
				(dataGridViewColumn2 as DataGridViewLinkColumn).HeaderText = WxFilters.Ⴀ(null, 2, 103387648);
				num = 36;
				break;
			case 36:
				(dataGridViewColumn2 as DataGridViewLinkColumn).Name = WxFilters.Ⴀ(null, 6, 103387652);
				((DataGridViewLinkColumn)dataGridViewColumn2).DataPropertyName = WxFilters.Ⴀ(null, 6, 103387652);
				num = 14;
				break;
			case 14:
				(dataGridViewColumn2 as DataGridViewLinkColumn).UseColumnTextForLinkValue = false;
				(dataGridViewColumn2 as DataGridViewLinkColumn).ActiveLinkColor = Color.White;
				((DataGridViewLinkColumn)dataGridViewColumn2).LinkBehavior = LinkBehavior.HoverUnderline;
				num = 21;
				break;
			case 21:
				(dataGridViewColumn2 as DataGridViewLinkColumn).LinkColor = Color.Blue;
				((DataGridViewLinkColumn)dataGridViewColumn2).TrackVisitedState = true;
				((DataGridViewLinkColumn)dataGridViewColumn2).VisitedLinkColor = Color.YellowGreen;
				num = 6;
				break;
			case 6:
				((DataGridViewLinkColumn)dataGridViewColumn2).Width = 75;
				((DataGridViewLinkColumn)dataGridViewColumn2).ToolTipText = WxFilters.Ⴀ(null, 8, 103387507);
				num = 33;
				break;
			case 33:
				Ⴓ.Columns.Add((DataGridViewLinkColumn)dataGridViewColumn2);
				num2 = 0;
				num = ⴄ[299] - 25970;
				break;
			case 13:
				Ⴓ.Columns[num2].SortMode = DataGridViewColumnSortMode.Programmatic;
				num2++;
				num = 35;
				break;
			case 35:
				num = ((num2 < Ⴓ.Columns.Count - 1) ? (ⴀႠ[127] - 358) : 15);
				break;
			case 15:
				Ⴃ.Caches.Wwv.DataSet.Tables[0].Locale = CultureInfo.InvariantCulture;
				num = ⴅ[56] / 3;
				break;
			case 32:
				obj2 = new DataView(Ⴃ.Caches.Wwv.DataSet.Tables[0]);
				num = ⴗ[25] - 16778;
				break;
			case 49:
			{
				IList list = new BindingSource();
				((BindingSource)list).DataSource = obj2 as DataView;
				Ⴍ = list as BindingSource;
				num = ⴗ[128] - 43501;
				break;
			}
			case 22:
				Ⴓ.DataSource = Ⴍ;
				Ⴄ = new DgvFilterManager(Ⴓ);
				num = 41;
				break;
			case 41:
				Ⴄ[ႥႥ.Ⴅ(1673507916, null, 0)] = new DgvTextBoxColumnFilter();
				obj = new DataGridViewColumnSelector(Ⴓ);
				num = ⴅ[330];
				break;
			case 37:
				((DataGridViewColumnSelector)obj).MaxHeight = 200;
				(obj as DataGridViewColumnSelector).Width = 110;
				return;
			}
		}
	}

	private void Ⴐ(object P_0, FormClosingEventArgs P_1)
	{
		SaveGridState();
	}

	public void SaveGridState()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		object obj = new StringCollection();
		int num = 0;
		object obj2 = DxSpotRateGraph.Ⴅ((BaseCollection)HighlightCountyCfg.ႷႣ(Ⴓ, 838, 883), (short)161, (short)130);
		try
		{
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 1:
				case 3:
				case 6:
				{
					DataGridViewBand dataGridViewBand = (DataGridViewColumn)(obj2 as IEnumerator).Current;
					StringCollection obj3 = (StringCollection)obj;
					string format = WxFilters.Ⴀ(null, 4, 103387416);
					object obj4 = new object[4];
					object[] obj5 = (object[])obj4;
					int num5 = ShowUsers.Ⴈ((DataGridViewColumn)dataGridViewBand, 73, 127);
					obj5[0] = HighlightArrlSectionCfg.Ⴅ(ref num5, ClientCty.Ⴗ('¿', 3, 307012778), 379, 340);
					(obj4 as object[])[1] = ShowUsers.Ⴈ(dataGridViewBand as DataGridViewColumn, 16, 39);
					((object[])obj4)[2] = HighlightCqZoneCfg.Ⴜ((DataGridViewBand)(dataGridViewBand as DataGridViewColumn), 106, (short)63);
					((object[])obj4)[3] = num++;
					obj3.Add(string.Format(format, (object[])obj4));
					num2 = 4;
					break;
				}
				default:
				{
					int num3;
					if (!((IEnumerator)obj2).MoveNext())
					{
						num3 = ⴅ[25];
					}
					else
					{
						char num4 = ⴀႠ[94];
						HighlightCtyCfg.ႠႠ[118] = (char)((HighlightCtyCfg.ႠႠ[118] | HighlightCtyCfg.ႠႠ[74]) & 0xE7);
						num3 = num4 - 21822;
					}
					num2 = num3;
					break;
				}
				case 2:
					return;
				}
			}
		}
		finally
		{
			int num6 = 0;
			object obj6 = default(object);
			while (true)
			{
				int num7;
				switch (num6)
				{
				default:
					obj6 = ((IEnumerator)obj2) as IDisposable;
					goto case 2;
				case 2:
				case 5:
					num7 = (((IDisposable)obj6 != null) ? 1 : (ⴀႠ[84] - 18798));
					goto IL_01b3;
				case 1:
				case 3:
					(obj6 as IDisposable).Dispose();
					break;
				case 4:
					break;
				}
				break;
				IL_01b3:
				num6 = num7;
			}
		}
	}

	private void Ⴅ(object P_0, DataGridViewCellEventArgs P_1)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				UserInfo.Ⴜ((Control)this, HighlightSpotterCfg.Ⴗ('ŏ', 283), (short)393, 'Ɲ');
				break;
			case 4:
				break;
			case 2:
				return;
			}
			if (FilterViewer.ႨႤ(P_1, 731, 713) >= 0)
			{
				break;
			}
			num = 2;
		}
		DataGridViewBand dataGridViewBand = default(DataGridViewBand);
		ICloneable cloneable = default(ICloneable);
		IComparable noSsidCall2 = default(IComparable);
		object noSsidCall = default(object);
		while (true)
		{
			IEnumerable enumerable = TelnetServerCfg.Ⴀ(SetDxFilter.Ⴍ(HighlightCountyCfg.ႷႣ(Ⴓ, 982, 995), HighlightCqZoneCfg.ႣႷ(P_1, 'ɥ', 'ȗ'), 471, 'Ǯ'), 284, 'ľ');
			int num2 = ⴗ[16] - 26633;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					return;
				case 11:
					break;
				case 2:
				case 8:
					dataGridViewBand = HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(Ⴓ, 'W', 93), FilterViewer.ႨႤ(P_1, 106, 120), '¢', 'ã');
					num2 = 1;
					continue;
				case 1:
					num2 = (((cloneable = (string)enumerable) == null) ? (ⴄ[16] - 31819) : (ⴀႠ[38] - 28693));
					continue;
				case 4:
					num2 = (DxCommentExtCfg.ႤႰ((string)cloneable, ႥႥ.Ⴅ(1673508193, null, 6), 'Ɉ', 622) ? 10 : (ⴄ[109] - 56961));
					continue;
				case 7:
				{
					bool num3 = DxCommentExtCfg.ႤႰ((string)cloneable, WxFilters.Ⴀ(null, 1, 103387651), 'ɸ', 606);
					Bye.Ⴄ[183] = (char)((Bye.Ⴄ[183] * Bye.Ⴄ[225]) & 0x75);
					num2 = (num3 ? 14 : (ⴀႠ[107] - 34905));
					continue;
				}
				case 5:
					num2 = 6;
					continue;
				case 10:
				case 12:
					noSsidCall2 = UtilsCallsign.GetNoSsidCall(DxSpotRates.ႠႳ(HighlightCallCfg.Ⴓ((DataGridViewRow)dataGridViewBand, 859, '\u032d'), ႥႥ.Ⴅ(1673508199, null, 0), 732, 695).Value.ToString());
					num2 = 13;
					continue;
				case 13:
					Process.Start(ႥႥ.Ⴍ(7, 1580609297, '«', null) + (noSsidCall2 as string));
					num2 = ⴀႠ[108] - 45137;
					continue;
				case 14:
					noSsidCall = UtilsCallsign.GetNoSsidCall(((DataGridViewRow)dataGridViewBand).Cells[WxFilters.Ⴀ(null, 4, 103387654)].Value.ToString());
					num2 = 3;
					continue;
				case 3:
				case 9:
					Process.Start(ႥႥ.Ⴍ(3, 1580609301, '^', null) + (noSsidCall as string));
					num2 = ⴅ[106] - 149;
					continue;
				case 6:
					Cursor = Cursors.Default;
					return;
				}
				break;
			}
		}
	}

	internal void Ⴜ(object P_0, DataGridViewDataErrorEventArgs P_1)
	{
		HighlightItuZoneCfg.ႳႠ(P_1, false, 602, 'ț');
	}

	private void ႷႠ(object P_0, DataGridViewCellFormattingEventArgs P_1)
	{
	}

	private void ႷႷ(object P_0, DataGridViewCellEventArgs P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 3;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			switch (num)
			{
			default:
				num = ((FilterViewer.ႨႤ(P_1, 27, 9) < 0) ? 2 : 5);
				break;
			case 5:
				num = ((FilterViewer.ႨႤ(P_1, 811, 825) >= DxSpotRates.ႠႤ(ClientCfg.Ⴜ(Ⴓ, '\u0321', 811), 323, 264)) ? 2 : 4);
				break;
			case 4:
			case 6:
				num = ((HighlightCqZoneCfg.ႣႷ(P_1, 'ư', 'ǂ') >= 0) ? 1 : 2);
				break;
			case 1:
				if (HighlightCqZoneCfg.ႣႷ(P_1, '\u0382', 'ϰ') >= SkimmerSpotRateGraph.ႤႣ((BaseCollection)HighlightCountyCfg.ႷႣ(Ⴓ, 62, 11), '\u0012', 81))
				{
					num = 2;
					break;
				}
				while (true)
				{
					DataGridViewCell dataGridViewCell = HighlightCallCfg.Ⴓ(HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(Ⴓ, 'ϲ', 1016), FilterViewer.ႨႤ(P_1, 90, 72), '\u0365', '\u0324'), 91, '-')[P_1.ColumnIndex] as DataGridViewLinkCell;
					while (true)
					{
						IL_0150:
						int num2 = ⴅ[87] - ⴅ[113];
						while (true)
						{
							switch (num2)
							{
							default:
								/*OpCode not supported: LdMemberToken*/;
								return;
							case 6:
								break;
							case 8:
								goto IL_0150;
							case 1:
								num2 = (((DataGridViewLinkCell)dataGridViewCell == null) ? 9 : 4);
								continue;
							case 4:
								cloneable = (dataGridViewCell as DataGridViewLinkCell).Value.ToString();
								num2 = ((!(cloneable is string)) ? 9 : 7);
								continue;
							case 7:
								cloneable = UtilsCallsign.GetNoSsidCall(cloneable as string);
								goto case 0;
							case 0:
								cloneable = UtilsCallsign.ScrubCall((string)cloneable);
								num2 = ((((string)cloneable).Length <= 0) ? (ⴅ[265] - 172) : 3);
								continue;
							case 3:
							case 5:
								Process.Start(ClientCty.Ⴗ('Ø', 4, 307012943) + (string)cloneable);
								num2 = 9;
								continue;
							case 9:
								return;
							}
							break;
						}
						break;
					}
				}
			case 2:
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static WwvWindow()
	{
		ArcClientConnectDat.Ⴍ();
		Ⴈ = new object();
	}
}
