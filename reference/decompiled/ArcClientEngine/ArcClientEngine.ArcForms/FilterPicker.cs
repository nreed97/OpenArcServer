using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ZedGraph;
using Ⴀ;

namespace ArcClientEngine.ArcForms;

public class FilterPicker : Form
{
	[StructLayout(LayoutKind.Auto)]
	internal struct ႥႣ
	{
		internal IContainer Ⴗ;

		internal ZedGraphControl Ⴍ;
	}

	private Button Ⴈ;

	private string Ⴅ;

	private HighlightItuZoneCfg.ႳႥ m_Ⴜ = new HighlightItuZoneCfg.ႳႥ();

	public string FilterName
	{
		get
		{
			return this.m_Ⴜ.Ⴍ;
		}
		private set
		{
			this.m_Ⴜ.Ⴍ = text;
		}
	}

	public string Filter
	{
		get
		{
			return Ⴅ;
		}
		private set
		{
			Ⴅ = ⴅ;
		}
	}

	protected override void Dispose(bool disposing)
	{
		char[] ⴗ = Ⴀ.ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? 2 : (ⴗ[136] - 30461));
				continue;
			case 3:
				num = ((this.m_Ⴜ.Ⴈ == null) ? 2 : (ⴅ[200] - 40));
				continue;
			case 0:
				this.m_Ⴜ.Ⴈ.Dispose();
				break;
			case 2:
				break;
			case 1:
			case 6:
				return;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void Ⴜ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = Ⴀ.ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 15;
		object obj3 = default(object);
		object obj2 = default(object);
		ICloneable cloneable = default(ICloneable);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj3 = new DataGridViewCellStyle();
				obj2 = new DataGridViewCellStyle();
				cloneable = new DataGridViewCellStyle();
				obj = new DataGridViewCellStyle();
				goto case 31;
			case 31:
			{
				ISupportInitialize supportInitialize = new DataGridView();
				this.m_Ⴜ.Ⴓ = supportInitialize as DataGridView;
				num = 25;
				break;
			}
			case 25:
			{
				Ⴈ = new Button();
				Control control = new System.Windows.Forms.Label();
				this.m_Ⴜ.Ⴐ = (System.Windows.Forms.Label)control;
				num = 28;
				break;
			}
			case 28:
				((ISupportInitialize)this.m_Ⴜ.Ⴓ).BeginInit();
				AnnFilters.Ⴓ((Control)this, 'ˈ', '\u02d7');
				num = 5;
				break;
			case 5:
				ႳႰ.Ⴃ(obj3 as DataGridViewCellStyle, ClientCfg.Ⴍ(879, 771), 1011, 934);
				num = 46;
				break;
			case 46:
				ႳႰ.Ⴃ((DataGridViewCellStyle)obj3, DxEmailCfg.Ⴍ(752, 647), 103, 49);
				num = 35;
				break;
			case 35:
				DxSpotRates.ႠႭ(this.m_Ⴜ.Ⴓ, obj3 as DataGridViewCellStyle, 68, 90);
				num = ⴀႠ[26] - 10563;
				break;
			case 18:
				ShowUsers.Ⴐ((Control)this.m_Ⴜ.Ⴓ, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right, 'π', 1008);
				HighlightCfg.ႳႰ(obj2 as DataGridViewCellStyle, DataGridViewContentAlignment.MiddleLeft, '\u0311', 880);
				num = ⴗ[132] - 17431;
				break;
			case 27:
			case 34:
				DxccCacheData.ႷႳ((DataGridViewCellStyle)obj2, HighlightItuZoneCfg.ႳႷ(807, 835), 89, 'z');
				num = 9;
				break;
			case 9:
				DxSpotRateGraph.Ⴗ(obj2 as DataGridViewCellStyle, new Font(Ⴀ.ႥႥ.Ⴅ(1673508261, null, 0), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), 'ɝ', 538);
				num = ⴀႠ[81] - 54660;
				break;
			case 20:
				DxSpotRates.ႠႨ((DataGridViewCellStyle)obj2, HighlightItuZoneCfg.ႳႷ(620, 521), '!', 122);
				num = ⴅ[18];
				break;
			case 36:
				ႳႰ.Ⴃ((DataGridViewCellStyle)obj2, ClientCfg.Ⴍ(1009, 925), 805, 880);
				num = 45;
				break;
			case 45:
				ႳႰ.Ⴃ((DataGridViewCellStyle)obj2, DxEmailCfg.Ⴍ(227, 148), 148, 194);
				num = 1;
				break;
			case 1:
				ArcClientConnectDat.ႷႭ((DataGridViewCellStyle)obj2, DataGridViewTriState.True, 60, '^');
				HighlightCountyCfg.ႷႠ(this.m_Ⴜ.Ⴓ, (DataGridViewCellStyle)obj2, 337, 356);
				num = 42;
				break;
			case 42:
				ႳႳ.Ⴅ(this.m_Ⴜ.Ⴓ, DataGridViewColumnHeadersHeightSizeMode.AutoSize, 'X', 84);
				HighlightCfg.ႳႰ(cloneable as DataGridViewCellStyle, DataGridViewContentAlignment.MiddleLeft, 'Ƥ', 453);
				num = ⴗ[140] - 60666;
				break;
			case 19:
				DxccCacheData.ႷႳ(cloneable as DataGridViewCellStyle, HighlightCallCfg.Ⴄ(879, 873), 130, '¡');
				num = 16;
				break;
			case 16:
				DxSpotRateGraph.Ⴗ((DataGridViewCellStyle)cloneable, new Font(Ⴀ.ႥႥ.Ⴅ(1673508256, null, 5), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), 'œ', 276);
				num = 29;
				break;
			case 29:
				DxSpotRates.ႠႨ((DataGridViewCellStyle)cloneable, HighlightItuZoneCfg.ႳႷ(998, 896), 'ɩ', 562);
				num = 30;
				break;
			case 30:
				ႳႰ.Ⴃ(cloneable as DataGridViewCellStyle, ClientCfg.Ⴍ(204, 160), 412, 457);
				num = ⴄ[15] - 23840;
				break;
			case 24:
				ႳႰ.Ⴃ(cloneable as DataGridViewCellStyle, DxEmailCfg.Ⴍ(755, 644), 225, 183);
				num = 38;
				break;
			case 38:
				ArcClientConnectDat.ႷႭ((DataGridViewCellStyle)cloneable, DataGridViewTriState.False, 767, 'ʝ');
				HighlightCqZoneCfg.Ⴍ(this.m_Ⴜ.Ⴓ, (DataGridViewCellStyle)cloneable, 924, 930);
				num = ⴀႠ[107] - ⴀႠ[107];
				break;
			case 0:
				HighlightCountyCfg.Ⴜ((Control)this.m_Ⴜ.Ⴓ, new Point(0, 0), 497, 418);
				num = ⴗ[130] - 30795;
				break;
			case 37:
				Ⴀ.ႥႤ.Ⴀ((Control)this.m_Ⴜ.Ⴓ, Ⴀ.ႥႥ.Ⴅ(1673508265, null, 0), 'ʢ', 'ˏ');
				num = ⴀႠ[64] - 42664;
				break;
			case 8:
			{
				ArcClientConnectDat.Ⴈ(this.m_Ⴜ.Ⴓ, true, 789, '\u031c');
				HighlightCfg.ႳႰ(obj as DataGridViewCellStyle, DataGridViewContentAlignment.MiddleLeft, '\u0325', 836);
				char num2 = ⴗ[66];
				Ⴀ.ႥႰ.Ⴗ[139] = (char)((Ⴀ.ႥႰ.Ⴗ[139] ^ HighlightCtyCfg.ႠႠ[103]) & 0x83);
				num = num2 - 45144;
				break;
			}
			case 10:
				DxccCacheData.ႷႳ(obj as DataGridViewCellStyle, HighlightItuZoneCfg.ႳႷ(17, 117), 636, 'ɟ');
				num = ⴀႠ[86] - 44446;
				break;
			case 6:
			case 12:
				DxSpotRateGraph.Ⴗ((DataGridViewCellStyle)obj, new Font(Ⴀ.ႥႥ.Ⴅ(1673508269, null, 8), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), '\u033d', 890);
				num = 33;
				break;
			case 33:
				DxSpotRates.ႠႨ(obj as DataGridViewCellStyle, HighlightItuZoneCfg.ႳႷ(260, 353), '\u0338', 867);
				num = ⴅ[213] - 205;
				break;
			case 40:
				ႳႰ.Ⴃ(obj as DataGridViewCellStyle, ClientCfg.Ⴍ(131, 239), 405, 448);
				num = ⴗ[130] - 30806;
				break;
			case 26:
				ႳႰ.Ⴃ(obj as DataGridViewCellStyle, DxEmailCfg.Ⴍ(323, 308), 233, 191);
				num = 11;
				break;
			case 11:
				ArcClientConnectDat.ႷႭ((DataGridViewCellStyle)obj, DataGridViewTriState.True, 603, 'ȹ');
				DxSpotRates.ႠႭ(this.m_Ⴜ.Ⴓ, (DataGridViewCellStyle)obj, 322, 349);
				num = 43;
				break;
			case 43:
				ArcClientConnectDat.Ⴄ((Control)this.m_Ⴜ.Ⴓ, new Size(687, 198), 'F', 27);
				num = 23;
				break;
			case 23:
				DxEmailCfg.Ⴈ((Control)this.m_Ⴜ.Ⴓ, 0, (short)395, 'ƺ');
				ClientCty.ႠႠ<DataGridView, DataGridViewCellMouseEventHandler>(this.m_Ⴜ.Ⴓ, ႥႳ, 509, 463);
				num = 2;
				break;
			case 2:
				ShowUsers.Ⴐ((Control)Ⴈ, AnchorStyles.Bottom | AnchorStyles.Right, 'κ', 906);
				Ⴈ.Location = new Point(612, 204);
				num = ⴄ[84] - 3801;
				break;
			case 13:
				Ⴈ.Name = ClientCty.Ⴗ('g', 3, 307012771);
				Ⴈ.Size = new Size(75, 23);
				num = 4;
				break;
			case 4:
				Ⴈ.TabIndex = 1;
				Ⴈ.Text = ClientCty.Ⴗ('d', 2, 307013020);
				num = 3;
				break;
			case 3:
				Ⴈ.UseVisualStyleBackColor = true;
				Ⴈ.Click += ႥႥ;
				num = ⴀႠ[93] - 27743;
				break;
			case 22:
				this.m_Ⴜ.Ⴐ.AutoSize = true;
				this.m_Ⴜ.Ⴐ.Location = new Point(12, 209);
				num = 44;
				break;
			case 44:
				this.m_Ⴜ.Ⴐ.Name = ClientCty.Ⴗ('$', 7, 307013010);
				num = 21;
				break;
			case 21:
				this.m_Ⴜ.Ⴐ.Size = new Size(278, 13);
				this.m_Ⴜ.Ⴐ.TabIndex = 2;
				num = 7;
				break;
			case 7:
				this.m_Ⴜ.Ⴐ.Text = Ⴀ.ႥႥ.Ⴅ(1673508450, null, 5);
				num = 32;
				break;
			case 32:
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				base.AutoScaleMode = AutoScaleMode.Font;
				base.ClientSize = new Size(687, 233);
				num = 14;
				break;
			case 14:
				base.Controls.Add(this.m_Ⴜ.Ⴐ);
				base.Controls.Add(Ⴈ);
				num = 17;
				break;
			case 17:
				base.Controls.Add(this.m_Ⴜ.Ⴓ);
				base.Name = Ⴀ.ႥႥ.Ⴍ(8, 1580609043, '½', null);
				num = 41;
				break;
			case 41:
				base.StartPosition = FormStartPosition.CenterParent;
				Text = Ⴀ.ႥႥ.Ⴍ(4, 1580609038, '\u0091', null);
				num = 39;
				break;
			case 39:
				((ISupportInitialize)this.m_Ⴜ.Ⴓ).EndInit();
				ResumeLayout(performLayout: false);
				PerformLayout();
				return;
			}
		}
	}

	public FilterPicker(ArcClientObjMgr om, FilterType type)
	{
		this.m_Ⴜ.Ⴅ = om;
		this.m_Ⴜ.Ⴃ = type;
		Ⴜ();
		Ⴀ.ႥႠ.ႭႤ((Control)this, Ⴀ.ႥႤ.Ⴗ(this.m_Ⴜ.Ⴃ, ArcClientConnectDat.ႷႠ((Control)this, 548, (short)515)), '|', '\u001c');
		this.m_Ⴜ.Ⴐ.Text = Ⴀ.ႥႤ.Ⴗ(this.m_Ⴜ.Ⴃ, this.m_Ⴜ.Ⴐ.Text);
		ႥႨ();
	}

	private void ႥႨ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = Ⴀ.ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 17;
		object obj = default(object);
		DataGridViewColumn dataGridViewColumn = default(DataGridViewColumn);
		object obj2 = default(object);
		int num2 = default(int);
		FilterType ⴃ = default(FilterType);
		while (true)
		{
			switch (num)
			{
			default:
				Ⴀ.ႥႠ.ႭႤ((Control)this, Ⴀ.ႥႤ.Ⴗ(this.m_Ⴜ.Ⴃ, ArcClientConnectDat.ႷႠ((Control)this, 610, (short)581)), 'ź', 'Ě');
				num = 5;
				continue;
			case 5:
				ArcClientConnectDat.Ⴈ(this.m_Ⴜ.Ⴓ, false, 638, 'ɴ');
				obj = new DataGridViewTextBoxColumn();
				num = 6;
				continue;
			case 6:
				ShowDxFilter.Ⴃ((DataGridViewColumn)(obj as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 0, 103388895), (short)23, 61);
				num = 2;
				continue;
			case 2:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj, WxFilters.Ⴀ(null, 2, 103388893), (short)374, (short)338);
				num = 24;
				continue;
			case 24:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj, WxFilters.Ⴀ(null, 8, 103388887), (short)173, (short)136);
				num = ⴀႠ[71] - 18562;
				continue;
			case 1:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj as DataGridViewTextBoxColumn), 125, 992, 'Ϩ');
				ClientCfg.ႭႷ((DataGridViewBand)(DataGridViewTextBoxColumn)obj, false, '\u038b', 'Γ');
				num = 9;
				continue;
			case 9:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(this.m_Ⴜ.Ⴓ, 886, 835), (DataGridViewColumn)(DataGridViewTextBoxColumn)obj, 'ŕ', 'ħ');
				num = ⴅ[280] - 222;
				continue;
			case 28:
				dataGridViewColumn = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), Ⴀ.ႥႥ.Ⴍ(3, 1580608610, '¾', null), (short)312, 274);
				num = 18;
				continue;
			case 18:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, Ⴀ.ႥႥ.Ⴍ(0, 1580608609, '6', null), (short)717, (short)745);
				num = 27;
				continue;
			case 27:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), Ⴀ.ႥႥ.Ⴍ(3, 1580608610, 'Á', null), (short)397, (short)424);
				num = ⴀႠ[122] - 49003;
				continue;
			case 7:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), 174, 523, 'ȃ');
				goto case 10;
			case 10:
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), ClientCty.Ⴗ('¾', 0, 307013003), (short)86, 125);
				num = ⴗ[90] - 35256;
				continue;
			case 8:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(this.m_Ⴜ.Ⴓ, 88, 109), (DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), 'ά', 'Ϟ');
				num = ⴀႠ[89] - 12655;
				continue;
			case 15:
				obj2 = new DataGridViewTextBoxColumn();
				goto case 25;
			case 25:
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj2, Ⴀ.ႥႥ.Ⴍ(2, 1580609436, 'Û', null), (short)227, 201);
				num = 20;
				continue;
			case 13:
			case 20:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj2 as DataGridViewTextBoxColumn), Ⴀ.ႥႥ.Ⴍ(5, 1580609435, '£', null), (short)435, (short)407);
				num = 3;
				continue;
			case 3:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj2 as DataGridViewTextBoxColumn), Ⴀ.ႥႥ.Ⴍ(3, 1580609437, '½', null), (short)714, (short)751);
				num = 23;
				continue;
			case 23:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj2, 470, 381, 'ŵ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj2, Ⴀ.ႥႥ.Ⴍ(4, 1580609434, '\t', null), (short)423, 396);
				num = ⴀႠ[33] - 39840;
				continue;
			case 30:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(this.m_Ⴜ.Ⴓ, 289, 276), (DataGridViewColumn)(DataGridViewTextBoxColumn)obj2, 'r', '\0');
				num = 22;
				continue;
			case 22:
				num2 = 0;
				num = ⴄ[259] - 4886;
				continue;
			case 0:
				ClientCfg.ႭႭ(SetDxFilter.Ⴍ(HighlightCountyCfg.ႷႣ(this.m_Ⴜ.Ⴓ, 774, 819), num2, 1008, 'ω'), DataGridViewColumnSortMode.Programmatic, 'ƾ', 'Ǝ');
				num = 21;
				continue;
			case 21:
				num2++;
				num = 14;
				continue;
			case 14:
				num = ((num2 >= this.m_Ⴜ.Ⴓ.Columns.Count - 1) ? (ⴗ[103] - 55672) : 0);
				continue;
			case 19:
			{
				IList list = new BindingSource();
				this.m_Ⴜ.Ⴄ = (BindingSource)list;
				ⴃ = this.m_Ⴜ.Ⴃ;
				num = 16;
				continue;
			}
			case 16:
				num = ⴃ switch
				{
					FilterType.DX => 4, 
					FilterType.Ann => 26, 
					FilterType.WX => 29, 
					_ => 12, 
				};
				continue;
			case 12:
				num = ⴄ[167] - 39501;
				continue;
			case 4:
				this.m_Ⴜ.Ⴄ.DataSource = this.m_Ⴜ.Ⴅ.Cfg.Filters.Dx.List;
				num = 11;
				continue;
			case 26:
				this.m_Ⴜ.Ⴄ.DataSource = this.m_Ⴜ.Ⴅ.Cfg.Filters.Ann.List;
				num = ⴄ[293] - 38882;
				continue;
			case 29:
				this.m_Ⴜ.Ⴄ.DataSource = this.m_Ⴜ.Ⴅ.Cfg.Filters.Wx.List;
				break;
			case 11:
				break;
			}
			break;
		}
		this.m_Ⴜ.Ⴓ.DataSource = this.m_Ⴜ.Ⴄ;
	}

	private void ႥႥ(object P_0, EventArgs P_1)
	{
		Ⴀ.ႥႷ.Ⴄ((Form)this, 123, 'l');
	}

	private void ႥႳ(object P_0, DataGridViewCellMouseEventArgs P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((Ⴀ.ႥႠ.ႭႨ(P_1, 114, 18) == -1) ? 3 : 0);
				break;
			case 0:
			case 2:
				TelnetServerCfg.Ⴐ((Form)this, DialogResult.OK, 983, (short)960);
				goto case 5;
			case 5:
				FilterName = FilterViewer.ႨႳ(HighlightCallCfg.Ⴓ(HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(this.m_Ⴜ.Ⴓ, 'ï', 229), Ⴀ.ႥႠ.ႭႨ(P_1, 219, 187), 'ʼ', '\u02fd'), 672, '\u02d6'), 1, 'ˠ', 'ʫ').FormattedValue.ToString();
				num = ⴅ[169] - 191;
				break;
			case 6:
				Filter = this.m_Ⴜ.Ⴓ.Rows[P_1.RowIndex].Cells[2].FormattedValue.ToString();
				return;
			case 3:
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static FilterPicker()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static DateTime ႥႰ(char P_0, char P_1)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = Ⴀ.ႥႰ.Ⴗ;
		DateTime result = default(DateTime);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 11;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄ[213] - 64961;
					continue;
				case 7:
					break;
				case 5:
				case 11:
					num2 = (((P_0 ^ P_1) - 93) ^ num) switch
					{
						0 => ⴀႠ[10] - 7245, 
						_ => 2, 
					};
					continue;
				case 2:
					result = default(DateTime);
					num2 = 0;
					continue;
				case 1:
					result = DateTime.UtcNow;
					num2 = ⴗ[79] - 32756;
					continue;
				case 0:
				{
					int num3 = num;
					Bye.Ⴄ[34] = Ⴀ.ႥႰ.Ⴗ[6];
					num = num3 + 1;
					num4 = 90;
					num5 = 417;
					goto case 4;
				}
				case 4:
					num2 = ((2919 > num5 - num4 * 7) ? 10 : 6);
					continue;
				case 6:
					num2 = 11;
					continue;
				case 10:
					return result;
				case 9:
					num2 = ⴀႠ[62] - 58861;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႥႤ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DxSpot
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 7:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 104) ^ num) switch
					{
						0 => 2, 
						1 => 13, 
						2 => 10, 
						3 => ⴅ[115], 
						_ => ⴅ[8] - 30, 
					};
					continue;
				case 8:
				case 9:
					result = true;
					num2 = ⴀႠ[30] - 50917;
					continue;
				case 2:
				case 11:
					result = P_0.Lotw;
					num2 = ⴀႠ[125] - 26163;
					continue;
				case 13:
					result = P_0.IsSkimBusted;
					num2 = ⴀႠ[58] - 24321;
					continue;
				case 10:
					result = P_0.Bob;
					num2 = 12;
					continue;
				case 4:
					result = P_0.Master;
					num2 = 12;
					continue;
				case 12:
				{
					num++;
					int num3 = 1840;
					int num4 = 343;
					num2 = ((460 < num3 / 4 - num4) ? (ⴀႠ[125] - 26172) : (ⴄ[163] - ⴄ[163]));
					continue;
				}
				case 0:
					return result;
				case 1:
				case 5:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DialogResult ႥႷ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : Form
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		DialogResult dialogResult = default(DialogResult);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[26] - 10571;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႠ[115] - 48714;
					continue;
				case 3:
				case 5:
					break;
				case 10:
					num2 = (((P_2 ^ P_1) - 71) ^ num) switch
					{
						0 => ⴀႠ[30] - 50927, 
						1 => 6, 
						_ => 12, 
					};
					continue;
				case 4:
				case 12:
					dialogResult = DialogResult.None;
					num2 = 9;
					continue;
				case 2:
					dialogResult = P_0.ShowDialog();
					num2 = 9;
					continue;
				case 6:
				case 11:
					dialogResult = P_0.DialogResult;
					num2 = 9;
					continue;
				case 9:
				{
					num++;
					int num3 = 827;
					int num4 = 950;
					num2 = ((3800 > num4 - num3 * 4) ? (ⴀႠ[30] - 50928) : 8);
					continue;
				}
				case 8:
					num2 = 10;
					continue;
				case 1:
				{
					DialogResult result = dialogResult;
					Bye.Ⴄ[208] = (char)((Bye.Ⴄ[208] - HighlightCtyCfg.ႠႠ[116]) & 0x4B);
					return result;
				}
				case 0:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႥႠ<_0021_00210, _0021_00211, _0021_00212, _0021_00213>(_0021_00212 P_0, _0021_00211 P_1, _0021_00210 P_2, _0021_00213 P_3, short P_4, int P_5) where _0021_00210 : string where _0021_00211 : string where _0021_00212 : string where _0021_00213 : string
	{
		char[] ⴗ = Ⴀ.ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 9;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[98] - 39641;
					continue;
				case 5:
				case 10:
					break;
				case 7:
				case 9:
					num2 = (((P_4 ^ P_5) - 122) ^ num) switch
					{
						0 => 3, 
						_ => 2, 
					};
					continue;
				case 2:
					comparable = null;
					num2 = ⴄ[300] - 46370;
					continue;
				case 3:
					comparable = string.Concat(P_0, P_1, P_2, P_3);
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = 82;
					num4 = 905;
					goto case 0;
				case 0:
					num2 = ((9050 <= num4 - num3 * 10) ? 1 : 4);
					continue;
				case 1:
					num2 = ⴄ[54] - 40520;
					continue;
				case 4:
					return comparable as string;
				case 6:
					num2 = ⴀႠ[75] - 37468;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataGridViewColumn ႥႭ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : string where _0021_00211 : DataGridViewColumnCollection
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = Ⴀ.ႥႰ.Ⴗ;
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[4] - 3452;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 9:
					break;
				case 0:
					num2 = (((P_2 ^ P_3) - 75) ^ num) switch
					{
						0 => ⴄ[129] - 52896, 
						_ => 3, 
					};
					continue;
				case 3:
					disposable = null;
					num2 = ⴅ[285];
					continue;
				case 11:
					disposable = P_0[P_1];
					num2 = ⴄ[163] - 58291;
					continue;
				case 5:
				case 6:
				case 10:
				{
					num++;
					int num3 = 135;
					int num4 = 345;
					num2 = ((1725 > num4 - num3 * 5) ? (ⴗ[127] - 17862) : 8);
					continue;
				}
				case 8:
					num2 = ⴀႠ[4] - 3452;
					continue;
				case 2:
				case 4:
					return (DataGridViewColumn)disposable;
				case 7:
					num2 = ⴗ[0] - ⴗ[0];
					continue;
				}
				break;
			}
		}
	}
}
