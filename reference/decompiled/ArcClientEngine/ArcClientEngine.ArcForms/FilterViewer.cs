using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcIo;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Filters;
using ArcInterfaces.Spots;
using ArcShared.ArcIo.Arx;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods;
using Ⴀ;

namespace ArcClientEngine.ArcForms;

public class FilterViewer : Form
{
	[StructLayout(LayoutKind.Auto)]
	internal struct ႨႠ
	{
		internal TelnetServerWrapper Ⴐ;

		internal List<ArxClient> Ⴄ;

		internal ClientCfg Ⴍ;

		internal ႥႣ Ⴃ;
	}

	internal sealed class ႨႭ
	{
		internal DataSet Ⴈ;

		internal ႨႭ()
		{
		}
	}

	private Button Ⴃ;

	private Button Ⴍ;

	private FilterType Ⴄ;

	private MultimediaCfg.Ⴀ m_Ⴅ = new MultimediaCfg.Ⴀ();

	protected override void Dispose(bool disposing)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? 4 : 2);
				continue;
			case 2:
			{
				int num3;
				if (this.m_Ⴅ.Ⴐ != null)
				{
					char num2 = ⴀႠ[87];
					Bye.Ⴄ[221] = (char)(Bye.Ⴄ[221] & Bye.Ⴄ[44] & 1);
					num3 = num2 - 21219;
				}
				else
				{
					num3 = 4;
				}
				num = num3;
				continue;
			}
			case 1:
				this.m_Ⴅ.Ⴐ.Dispose();
				break;
			case 0:
			case 4:
				break;
			case 6:
				return;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void Ⴓ()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 17;
		object obj3 = default(object);
		object obj2 = default(object);
		ICloneable cloneable = default(ICloneable);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				obj3 = new DataGridViewCellStyle();
				obj2 = new DataGridViewCellStyle();
				cloneable = new DataGridViewCellStyle();
				obj = new DataGridViewCellStyle();
				ISupportInitialize supportInitialize = new DataGridView();
				this.m_Ⴅ.Ⴓ = supportInitialize as DataGridView;
				num = 23;
				break;
			}
			case 23:
				Ⴃ = new Button();
				Ⴍ = new Button();
				((ISupportInitialize)this.m_Ⴅ.Ⴓ).BeginInit();
				num = 3;
				break;
			case 3:
				AnnFilters.Ⴓ((Control)this, 'Ł', 'Ş');
				ႳႰ.Ⴃ(obj3 as DataGridViewCellStyle, ClientCfg.Ⴍ(1000, 900), 615, 562);
				num = 30;
				break;
			case 30:
				ႳႰ.Ⴃ((DataGridViewCellStyle)obj3, DxEmailCfg.Ⴍ(450, 437), 446, 488);
				num = ⴗ[128] - 43517;
				break;
			case 6:
				DxSpotRates.ႠႭ(this.m_Ⴅ.Ⴓ, obj3 as DataGridViewCellStyle, 712, 726);
				num = 37;
				break;
			case 37:
				ShowUsers.Ⴐ((Control)this.m_Ⴅ.Ⴓ, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right, 'ĸ', 264);
				HighlightCfg.ႳႰ(obj2 as DataGridViewCellStyle, DataGridViewContentAlignment.MiddleLeft, '\u035f', 830);
				num = ⴗ[158] - 28150;
				break;
			case 0:
				DxccCacheData.ႷႳ((DataGridViewCellStyle)obj2, HighlightItuZoneCfg.ႳႷ(661, 753), 238, 'Í');
				num = 22;
				break;
			case 22:
				DxSpotRateGraph.Ⴗ((DataGridViewCellStyle)obj2, new Font(ႥႥ.Ⴅ(1673508258, null, 7), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), 'ˢ', 677);
				num = 19;
				break;
			case 19:
				DxSpotRates.ႠႨ((DataGridViewCellStyle)obj2, HighlightItuZoneCfg.ႳႷ(807, 834), 'ˁ', 666);
				num = ⴄ[6] - 43959;
				break;
			case 27:
				ႳႰ.Ⴃ(obj2 as DataGridViewCellStyle, ClientCfg.Ⴍ(939, 967), 826, 879);
				goto case 33;
			case 33:
				num = ⴗ[6] - 61623;
				break;
			case 10:
				ႳႰ.Ⴃ(obj2 as DataGridViewCellStyle, DxEmailCfg.Ⴍ(670, 745), 195, 149);
				num = ⴗ[82] - 57050;
				break;
			case 11:
				ArcClientConnectDat.ႷႭ((DataGridViewCellStyle)obj2, DataGridViewTriState.True, 553, 'ɋ');
				HighlightCountyCfg.ႷႠ(this.m_Ⴅ.Ⴓ, (DataGridViewCellStyle)obj2, 1018, 975);
				num = 1;
				break;
			case 1:
				Ⴀ.ႳႳ.Ⴅ(this.m_Ⴅ.Ⴓ, DataGridViewColumnHeadersHeightSizeMode.AutoSize, 'Α', 925);
				HighlightCfg.ႳႰ(cloneable as DataGridViewCellStyle, DataGridViewContentAlignment.MiddleLeft, 'l', 13);
				num = 4;
				break;
			case 4:
				DxccCacheData.ႷႳ((DataGridViewCellStyle)cloneable, HighlightCallCfg.Ⴄ(1011, 1013), 413, 'ƾ');
				num = ⴄ[236] - 11632;
				break;
			case 26:
				DxSpotRateGraph.Ⴗ((DataGridViewCellStyle)cloneable, new Font(ႥႥ.Ⴅ(1673508261, null, 0), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), 'ɽ', 570);
				num = ⴗ[146] - 39729;
				break;
			case 31:
				DxSpotRates.ႠႨ(cloneable as DataGridViewCellStyle, HighlightItuZoneCfg.ႳႷ(831, 857), 'Ȥ', 639);
				num = 40;
				break;
			case 40:
				ႳႰ.Ⴃ((DataGridViewCellStyle)cloneable, ClientCfg.Ⴍ(572, 592), 436, 481);
				num = 5;
				break;
			case 5:
				ႳႰ.Ⴃ(cloneable as DataGridViewCellStyle, DxEmailCfg.Ⴍ(410, 493), 129, 215);
				num = ⴅ[18];
				break;
			case 36:
				ArcClientConnectDat.ႷႭ((DataGridViewCellStyle)cloneable, DataGridViewTriState.False, 113, '\u0013');
				HighlightCqZoneCfg.Ⴍ(this.m_Ⴅ.Ⴓ, (DataGridViewCellStyle)cloneable, 931, 925);
				num = 2;
				break;
			case 2:
				HighlightCountyCfg.Ⴜ((Control)this.m_Ⴅ.Ⴓ, new Point(0, 0), 2, 81);
				num = 38;
				break;
			case 38:
				ႥႤ.Ⴀ((Control)this.m_Ⴅ.Ⴓ, ClientCty.Ⴗ('ý', 6, 307013011), 'ĥ', 'ň');
				num = 7;
				break;
			case 7:
				ArcClientConnectDat.Ⴈ(this.m_Ⴅ.Ⴓ, true, 147, '\u009a');
				HighlightCfg.ႳႰ(obj as DataGridViewCellStyle, DataGridViewContentAlignment.MiddleLeft, '\u0016', 119);
				num = 14;
				break;
			case 14:
				DxccCacheData.ႷႳ(obj as DataGridViewCellStyle, HighlightItuZoneCfg.ႳႷ(269, 361), 842, '\u0369');
				num = ⴀႠ[81] - 54638;
				break;
			case 42:
				DxSpotRateGraph.Ⴗ(obj as DataGridViewCellStyle, new Font(ႥႥ.Ⴅ(1673508269, null, 8), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), 'Ĉ', 335);
				num = 41;
				break;
			case 41:
				DxSpotRates.ႠႨ(obj as DataGridViewCellStyle, HighlightItuZoneCfg.ႳႷ(118, 19), 'ɜ', 519);
				num = 44;
				break;
			case 44:
				ႳႰ.Ⴃ((DataGridViewCellStyle)obj, ClientCfg.Ⴍ(372, 280), 753, 676);
				num = ⴗ[86] - 42602;
				break;
			case 43:
				ႳႰ.Ⴃ(obj as DataGridViewCellStyle, DxEmailCfg.Ⴍ(219, 172), 86, 0);
				num = 12;
				break;
			case 12:
				ArcClientConnectDat.ႷႭ((DataGridViewCellStyle)obj, DataGridViewTriState.True, 871, '\u0305');
				DxSpotRates.ႠႭ(this.m_Ⴅ.Ⴓ, (DataGridViewCellStyle)obj, 423, 440);
				num = ⴅ[157];
				break;
			case 21:
				ArcClientConnectDat.Ⴄ((Control)this.m_Ⴅ.Ⴓ, new Size(852, 198), '\u0082', 223);
				num = 29;
				break;
			case 29:
				DxEmailCfg.Ⴈ((Control)this.m_Ⴅ.Ⴓ, 0, (short)125, 'L');
				this.m_Ⴅ.Ⴓ.CellContentClick += Ⴜ;
				num = ⴀႠ[126] - 21862;
				break;
			case 32:
				Ⴃ.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
				Ⴃ.Location = new Point(777, 204);
				num = ⴅ[10] - 161;
				break;
			case 16:
				Ⴃ.Name = ႥႥ.Ⴅ(1673508417, null, 4);
				Ⴃ.Size = new Size(75, 23);
				num = ⴀႠ[84] - 18774;
				break;
			case 28:
				Ⴃ.TabIndex = 1;
				Ⴃ.Text = ႥႥ.Ⴅ(1673508845, null, 6);
				num = ⴄ[109] - 56929;
				break;
			case 39:
				Ⴃ.UseVisualStyleBackColor = true;
				Ⴃ.Click += ႳႷ;
				num = ⴗ[156] - 48806;
				break;
			case 18:
			case 24:
				Ⴍ.Location = new Point(3, 204);
				Ⴍ.Name = ClientCty.Ⴗ('ü', 2, 307012774);
				num = 15;
				break;
			case 15:
			case 25:
				Ⴍ.Size = new Size(85, 23);
				Ⴍ.TabIndex = 2;
				num = ⴄ[247] - 48861;
				break;
			case 45:
				Ⴍ.Text = ClientCty.Ⴗ('\f', 5, 307012151);
				Ⴍ.UseVisualStyleBackColor = true;
				num = ⴗ[23] - 52197;
				break;
			case 9:
				Ⴍ.Click += ႳႳ;
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				num = 20;
				break;
			case 20:
				base.AutoScaleMode = AutoScaleMode.Font;
				base.ClientSize = new Size(852, 233);
				base.Controls.Add(Ⴍ);
				num = 13;
				break;
			case 13:
				base.Controls.Add(Ⴃ);
				base.Controls.Add(this.m_Ⴅ.Ⴓ);
				num = ⴄ[118] - 10065;
				break;
			case 8:
				base.Name = WxFilters.Ⴀ(null, 2, 103389051);
				base.StartPosition = FormStartPosition.CenterParent;
				num = ⴗ[47] - 42970;
				break;
			case 35:
				Text = ႥႥ.Ⴍ(8, 1580609026, 'Í', null);
				((ISupportInitialize)this.m_Ⴅ.Ⴓ).EndInit();
				num = ⴄ[130] - 31358;
				break;
			case 34:
				ResumeLayout(performLayout: false);
				return;
			}
		}
	}

	public FilterViewer(ArcClientObjMgr om, FilterType type)
	{
		this.m_Ⴅ.Ⴍ = om;
		Ⴄ = type;
		Ⴓ();
		Ⴅ();
	}

	private void Ⴅ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 43;
		DataGridViewColumn dataGridViewColumn = default(DataGridViewColumn);
		DataGridViewColumn dataGridViewColumn5 = default(DataGridViewColumn);
		object obj2 = default(object);
		object obj = default(object);
		DataGridViewColumn dataGridViewColumn4 = default(DataGridViewColumn);
		DataGridViewColumn dataGridViewColumn3 = default(DataGridViewColumn);
		DataGridViewColumn dataGridViewColumn2 = default(DataGridViewColumn);
		int num2 = default(int);
		FilterType ⴄ2 = default(FilterType);
		while (true)
		{
			switch (num)
			{
			default:
				ႥႠ.ႭႤ((Control)this, ႥႤ.Ⴗ(Ⴄ, ArcClientConnectDat.ႷႠ((Control)this, 16, (short)55)), 'ľ', 'Ş');
				num = 7;
				continue;
			case 7:
				ArcClientConnectDat.Ⴈ(this.m_Ⴅ.Ⴓ, false, 832, '\u034a');
				dataGridViewColumn = new DataGridViewTextBoxColumn();
				num = ⴅ[161] - 206;
				continue;
			case 14:
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), WxFilters.Ⴀ(null, 6, 103388889), (short)426, 384);
				num = 42;
				continue;
			case 42:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, WxFilters.Ⴀ(null, 8, 103388887), (short)599, (short)627);
				num = ⴅ[285];
				continue;
			case 5:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, WxFilters.Ⴀ(null, 8, 103388887), (short)886, (short)851);
				num = 38;
				continue;
			case 38:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn, 125, 363, 'ţ');
				ClientCfg.ႭႷ((DataGridViewBand)(DataGridViewTextBoxColumn)dataGridViewColumn, false, 'Ǟ', 'ǆ');
				num = ⴅ[328] - ⴅ[169];
				continue;
			case 45:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(this.m_Ⴅ.Ⴓ, 25, 44), (DataGridViewColumn)(dataGridViewColumn as DataGridViewTextBoxColumn), 'ɩ', 'ț');
				num = 4;
				continue;
			case 4:
				dataGridViewColumn5 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn5 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(0, 1580608609, '\\', null), (short)921, 947);
				num = ⴗ[37] - 54913;
				continue;
			case 8:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)dataGridViewColumn5, ႥႥ.Ⴍ(5, 1580608612, 'á', null), (short)161, (short)133);
				num = 16;
				continue;
			case 16:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(dataGridViewColumn5 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(3, 1580608610, 'ª', null), (short)934, (short)899);
				num = ⴗ[149] - 53661;
				continue;
			case 20:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(dataGridViewColumn5 as DataGridViewTextBoxColumn), 145, 420, 'Ƭ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn5 as DataGridViewTextBoxColumn), ClientCty.Ⴗ('R', 8, 307012995), (short)623, 580);
				num = ⴗ[32] - 52709;
				continue;
			case 41:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(this.m_Ⴅ.Ⴓ, 105, 92), (DataGridViewColumn)(dataGridViewColumn5 as DataGridViewTextBoxColumn), '\u0301', 'ͳ');
				num = 13;
				continue;
			case 13:
				obj2 = new DataGridViewTextBoxColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj2, ႥႥ.Ⴍ(7, 1580609433, 'n', null), (short)832, 874);
				goto case 47;
			case 47:
				num = ⴄ[295] - 49118;
				continue;
			case 26:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj2, ႥႥ.Ⴍ(7, 1580609433, '\u009b', null), (short)348, (short)376);
				num = 29;
				continue;
			case 29:
				HighlightStateCfg.ႣႨ((DataGridViewColumn)(obj2 as DataGridViewTextBoxColumn), ႥႥ.Ⴍ(4, 1580609434, 'N', null), (short)790, (short)819);
				num = 10;
				continue;
			case 10:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj2, 484, 707, 'ˋ');
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewTextBoxColumn)obj2, ႥႥ.Ⴍ(6, 1580609432, 'É', null), (short)309, 286);
				goto case 2;
			case 2:
				num = 24;
				continue;
			case 24:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(this.m_Ⴅ.Ⴓ, 367, 346), (DataGridViewColumn)(DataGridViewTextBoxColumn)obj2, 'Ú', '\u00a8');
				num = 18;
				continue;
			case 18:
				obj = new DataGridViewButtonColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewButtonColumn)obj, ClientCty.Ⴗ('u', 0, 307012133), (short)955, 913);
				num = 15;
				continue;
			case 15:
				AnnFilters.Ⴜ((DataGridViewButtonColumn)obj, ႥႥ.Ⴍ(7, 1580609214, 'M', null), 'Đ', 304);
				num = 39;
				continue;
			case 39:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(obj as DataGridViewButtonColumn), 45, 505, 'Ǳ');
				HighlightCountyCfg.ႷႤ((DataGridViewButtonColumn)obj, true, 231, '\u0082');
				num = ⴅ[160] - ⴅ[15];
				continue;
			case 19:
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewButtonColumn)obj, ClientCty.Ⴗ('§', 4, 307012191), (short)127, 84);
				num = 12;
				continue;
			case 12:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(this.m_Ⴅ.Ⴓ, 353, 340), (DataGridViewColumn)(obj as DataGridViewButtonColumn), '\'', 'U');
				num = 36;
				continue;
			case 36:
				dataGridViewColumn4 = new DataGridViewButtonColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn4 as DataGridViewButtonColumn), ႥႥ.Ⴅ(1673507156, null, 5), (short)63, 21);
				num = 11;
				continue;
			case 11:
				AnnFilters.Ⴜ((DataGridViewButtonColumn)dataGridViewColumn4, ႥႥ.Ⴍ(2, 1580609211, '\u0012', null), 'ů', 335);
				num = 21;
				continue;
			case 21:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(dataGridViewColumn4 as DataGridViewButtonColumn), 45, 393, 'Ɓ');
				HighlightCountyCfg.ႷႤ((DataGridViewButtonColumn)dataGridViewColumn4, true, 702, '\u02db');
				num = 27;
				continue;
			case 27:
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn4 as DataGridViewButtonColumn), ႥႥ.Ⴅ(1673507173, null, 5), (short)995, 968);
				goto case 40;
			case 40:
				num = 28;
				continue;
			case 28:
				ClientCfg.Ⴅ(HighlightCountyCfg.ႷႣ(this.m_Ⴅ.Ⴓ, 592, 613), (DataGridViewColumn)(DataGridViewButtonColumn)dataGridViewColumn4, 'Ǯ', 'Ɯ');
				num = 17;
				continue;
			case 17:
				dataGridViewColumn3 = new DataGridViewButtonColumn();
				ShowDxFilter.Ⴃ((DataGridViewColumn)(dataGridViewColumn3 as DataGridViewButtonColumn), ႥႥ.Ⴍ(4, 1580609189, 'G', null), (short)318, 276);
				num = 34;
				continue;
			case 34:
				AnnFilters.Ⴜ(dataGridViewColumn3 as DataGridViewButtonColumn, ClientCty.Ⴗ('*', 4, 307012247), '}', 93);
				num = 23;
				continue;
			case 23:
				HighlightStateCfg.ႣႣ((DataGridViewColumn)(DataGridViewButtonColumn)dataGridViewColumn3, 45, 106, 'b');
				HighlightCountyCfg.ႷႤ(dataGridViewColumn3 as DataGridViewButtonColumn, true, 134, 'ã');
				num = 37;
				continue;
			case 37:
				ShowDxFilter.Ⴃ((DataGridViewColumn)(DataGridViewButtonColumn)dataGridViewColumn3, ႥႥ.Ⴍ(4, 1580607831, 'þ', null), (short)584, 611);
				num = 3;
				continue;
			case 3:
				HighlightCountyCfg.ႷႣ(this.m_Ⴅ.Ⴓ, 589, 632).Add((DataGridViewButtonColumn)dataGridViewColumn3);
				num = ⴄ[195] - 44457;
				continue;
			case 30:
				dataGridViewColumn2 = new DataGridViewButtonColumn();
				(dataGridViewColumn2 as DataGridViewButtonColumn).HeaderText = WxFilters.Ⴀ(null, 8, 103389024);
				num = ⴀႠ[128] - 34375;
				continue;
			case 46:
				(dataGridViewColumn2 as DataGridViewButtonColumn).Text = ႥႥ.Ⴅ(1673507115, null, 2);
				((DataGridViewButtonColumn)dataGridViewColumn2).Width = 45;
				num = ⴅ[4] + ⴅ[18];
				continue;
			case 44:
				(dataGridViewColumn2 as DataGridViewButtonColumn).UseColumnTextForButtonValue = true;
				(dataGridViewColumn2 as DataGridViewButtonColumn).ToolTipText = WxFilters.Ⴀ(null, 6, 103388958);
				num = 22;
				continue;
			case 22:
				this.m_Ⴅ.Ⴓ.Columns.Add((DataGridViewButtonColumn)dataGridViewColumn2);
				num2 = 0;
				num = ⴗ[62] - 59546;
				continue;
			case 31:
				this.m_Ⴅ.Ⴓ.Columns[num2].SortMode = DataGridViewColumnSortMode.Programmatic;
				num2++;
				num = 6;
				continue;
			case 6:
				num = ((num2 < this.m_Ⴅ.Ⴓ.Columns.Count - 1) ? 31 : 33);
				continue;
			case 33:
			{
				IBindingList bindingList = new BindingSource();
				this.m_Ⴅ.Ⴀ = bindingList as BindingSource;
				ⴄ2 = Ⴄ;
				num = ⴄ[196] - 35735;
				continue;
			}
			case 35:
				num = ⴄ2 switch
				{
					FilterType.DX => 32, 
					FilterType.Ann => 9, 
					FilterType.WX => ⴗ[52] - 21945, 
					_ => 1, 
				};
				continue;
			case 1:
				num = 0;
				continue;
			case 32:
				this.m_Ⴅ.Ⴀ.DataSource = this.m_Ⴅ.Ⴍ.Cfg.Filters.Dx.List;
				num = ⴀႠ[30] - 50929;
				continue;
			case 9:
				this.m_Ⴅ.Ⴀ.DataSource = this.m_Ⴅ.Ⴍ.Cfg.Filters.Ann.List;
				num = 0;
				continue;
			case 25:
				this.m_Ⴅ.Ⴀ.DataSource = this.m_Ⴅ.Ⴍ.Cfg.Filters.Wx.List;
				break;
			case 0:
				break;
			}
			break;
		}
		this.m_Ⴅ.Ⴓ.DataSource = this.m_Ⴅ.Ⴀ;
	}

	private void Ⴜ(object P_0, DataGridViewCellEventArgs P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 14;
		IConvertible convertible = default(IConvertible);
		IEquatable<string> equatable = default(IEquatable<string>);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				num = ((HighlightCqZoneCfg.ႣႷ(P_1, '\u032d', '\u035f') != 3) ? 6 : 11);
				break;
			case 11:
				convertible = FilterCfg.Ⴓ(DxEmailCfg.Ⴃ(ႨႳ(HighlightCallCfg.Ⴓ(HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(this.m_Ⴅ.Ⴓ, 'ʽ', 695), ႨႤ(P_1, 539, 521), 'Z', '\u001b'), 861, '\u032b'), 1, '\u032b', '\u0360'), 378, 264), 432, 'Ǟ');
				num = ⴅ[92] - 237;
				break;
			case 7:
			case 15:
				equatable = FilterCfg.Ⴓ(DxEmailCfg.Ⴃ(ႨႳ(HighlightCallCfg.Ⴓ(HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(this.m_Ⴅ.Ⴓ, 'Έ', 898), ႨႤ(P_1, 11, 25), 'S', '\u0012'), 910, 'ϸ'), 2, 'Z', '\u0011'), 854, 804), 45, 'C');
				num = 8;
				break;
			case 8:
				ႳႣ(convertible as string, (string)equatable);
				goto case 6;
			case 6:
				num = ((HighlightCqZoneCfg.ႣႷ(P_1, 'ɛ', 'ȩ') != 4) ? 5 : (ⴅ[17] / 3));
				break;
			case 0:
				this.m_Ⴅ.Ⴍ.Cfg.Multimedia.MultimediaFilterName = FilterCfg.Ⴓ(DxEmailCfg.Ⴃ(ႨႳ(HighlightCallCfg.Ⴓ(HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(this.m_Ⴅ.Ⴓ, '\u038b', 897), ႨႤ(P_1, 126, 108), '"', 'c'), 249, '\u008f'), 1, 'ω', '\u0382'), 94, 44), 127, '\u0011');
				goto case 3;
			case 3:
			case 4:
				num = ⴗ[59] - 33046;
				break;
			case 9:
				this.m_Ⴅ.Ⴍ.Cfg.Multimedia.MultimediaFilter = FilterCfg.Ⴓ(DxEmailCfg.Ⴃ(ႨႳ(HighlightCallCfg.Ⴓ(HighlightCountyCfg.ႷႳ(ClientCfg.Ⴜ(this.m_Ⴅ.Ⴓ, 'ϔ', 990), ႨႤ(P_1, 686, 700), '\u031e', '\u035f'), 700, 'ˊ'), 2, '\n', 'A'), 34, 80), 407, 'ǹ');
				num = 10;
				break;
			case 10:
				this.m_Ⴅ.Ⴍ.Io.Multimedia.Init();
				goto case 5;
			case 5:
				num = ((P_1.ColumnIndex != 5) ? (ⴀႠ[38] - 28678) : 16);
				break;
			case 16:
				obj = new FilterEditor(this.m_Ⴅ.Ⴍ, Ⴄ);
				((FilterEditor)obj).FilterName = this.m_Ⴅ.Ⴓ.Rows[P_1.RowIndex].Cells[1].FormattedValue.ToString();
				num = 2;
				break;
			case 2:
				((FilterEditor)obj).Filter = this.m_Ⴅ.Ⴓ.Rows[P_1.RowIndex].Cells[2].FormattedValue.ToString();
				num = ⴄ[114] - 21;
				break;
			case 1:
				(obj as FilterEditor).ShowDialog();
				num = ((((FilterEditor)obj).DialogResult != DialogResult.OK) ? (ⴗ[103] - 55672) : 12);
				break;
			case 12:
				this.m_Ⴅ.Ⴓ.Rows[P_1.RowIndex].Cells[1].Value = (obj as FilterEditor).FilterName;
				num = 17;
				break;
			case 17:
				this.m_Ⴅ.Ⴓ.Rows[P_1.RowIndex].Cells[2].Value = ((FilterEditor)obj).Filter;
				goto case 19;
			case 19:
				num = ((P_1.ColumnIndex != 6) ? (ⴅ[189] - 175) : 18);
				break;
			case 18:
				this.m_Ⴅ.Ⴀ.RemoveAt(P_1.RowIndex);
				return;
			case 13:
				return;
			}
		}
	}

	private void ႳႷ(object P_0, EventArgs P_1)
	{
		ႥႷ.Ⴄ((Form)this, 702, 'ʩ');
	}

	private void ႳႳ(object P_0, EventArgs P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new FilterEditor(this.m_Ⴅ.Ⴍ, Ⴄ);
				FilterPicker.ႥႷ((Form)(FilterEditor)obj, 'ǌ', (short)395);
				goto case 5;
			case 5:
				num = ⴅ[25];
				break;
			case 2:
				if (FilterPicker.ႥႷ((Form)(FilterEditor)obj, '\u02f4', (short)700) == DialogResult.OK)
				{
					num = ⴄ[43] - 7773;
					break;
				}
				return;
			case 3:
			case 4:
				switch (Ⴄ)
				{
				default:
					num = ⴄ[199] - 65147;
					goto end_IL_0011;
				case FilterType.DX:
					HighlightArrlSectionCfg.Ⴜ(this.m_Ⴅ.Ⴀ, (object)new DxFilter((obj as FilterEditor).FilterName, ((FilterEditor)obj).Filter), 'ř', (short)323);
					return;
				case FilterType.Ann:
					break;
				case FilterType.WX:
					{
						while (true)
						{
							this.m_Ⴅ.Ⴀ.Add(new WxFilter((obj as FilterEditor).FilterName, ((FilterEditor)obj).Filter));
							switch (5)
							{
							default:
								/*OpCode not supported: LdMemberToken*/;
								return;
							case 1:
								break;
							case 0:
								return;
							case 2:
								goto end_IL_009b;
							case 6:
							case 7:
								return;
							case 3:
								continue;
							case 5:
								return;
							}
							break;
						}
						goto case FilterType.DX;
					}
					end_IL_009b:
					break;
				}
				HighlightArrlSectionCfg.Ⴜ(this.m_Ⴅ.Ⴀ, (object)new AnnFilter((obj as FilterEditor).FilterName, (obj as FilterEditor).Filter), 'Ŭ', (short)374);
				return;
			case 6:
				return;
				end_IL_0011:
				break;
			}
		}
	}

	private void ႳႣ(string P_0, string P_1)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 2;
		FilterType ⴄ2 = default(FilterType);
		while (true)
		{
			switch (num)
			{
			default:
				ⴄ2 = Ⴄ;
				break;
			case 0:
				break;
			case 1:
			case 4:
				return;
			}
			switch (ⴄ2)
			{
			case FilterType.DX:
				goto end_IL_0010;
			case FilterType.Ann:
				goto IL_00e4;
			case FilterType.WX:
				goto IL_0177;
			}
			num = 4;
			continue;
			end_IL_0010:
			break;
		}
		goto IL_0081;
		IL_004b:
		int num2;
		switch (num2)
		{
		default:
			/*OpCode not supported: LdMemberToken*/;
			return;
		case 8:
			break;
		case 0:
		case 9:
			ႨႼ(DxFilters.Ⴈ(ClientCty.Ⴗ('å', 6, 307012234), P_0, 738, 698), ႥႥ.Ⴍ(0, 1580607822, 'x', P_1), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 516, 'ȼ');
			return;
		case 6:
			return;
		case 2:
		case 5:
			goto IL_00e4;
		case 7:
			ႨႼ(DxFilters.Ⴈ(ႥႥ.Ⴍ(6, 1580607865, 'ª', P_0), P_0, 364, 308), ႥႥ.Ⴍ(0, 1580607822, 'á', null), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 1011, 'ϋ');
			return;
		case 3:
			goto IL_0177;
		case 1:
			MessageBox.Show(ClientCty.Ⴗ('Z', 4, 307012370) + P_0, ႥႥ.Ⴍ(3, 1580607821, '\u0081', null), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		goto IL_0081;
		IL_0081:
		this.m_Ⴅ.Ⴍ.Io.TelnetServer.SetDefaultDxFilter(P_0, P_1);
		num2 = 0;
		goto IL_004b;
		IL_00e4:
		this.m_Ⴅ.Ⴍ.Io.TelnetServer.SetDefaultAnnFilter(P_0, P_1);
		char num3 = ⴄ[159];
		HighlightCtyCfg.ႠႠ[60] = (char)((HighlightCtyCfg.ႠႠ[60] ^ HighlightCtyCfg.ႠႠ[49]) & 0x50);
		num2 = num3 - 48360;
		goto IL_004b;
		IL_0177:
		this.m_Ⴅ.Ⴍ.Io.TelnetServer.SetDefaultWxFilter(P_0, P_1);
		num2 = ⴗ[93] - 63518;
		goto IL_004b;
	}

	[SecuritySafeCritical]
	static FilterViewer()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static string ႨႷ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[65] - 47728;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 6;
					continue;
				case 6:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 43) ^ num) switch
					{
						0 => 7, 
						1 => 5, 
						2 => ⴄ[4] - 10463, 
						_ => 0, 
					};
					continue;
				case 0:
					cloneable = null;
					num2 = 8;
					continue;
				case 4:
				case 7:
					cloneable = P_0.ToLower();
					num2 = ⴀႠ[87] - 21212;
					continue;
				case 5:
					cloneable = P_0.ToUpper();
					num2 = ⴄ[52] - 25101;
					continue;
				case 9:
					cloneable = UtilsMacros.ExpandRepeatableFilterMacros(P_0);
					num2 = ⴅ[4];
					continue;
				case 8:
					num++;
					goto case 2;
				case 2:
				{
					int num3 = 1318;
					int num4 = 637;
					num2 = ((659 < num3 / 2 - num4) ? (ⴗ[119] - 30796) : 10);
					continue;
				}
				case 10:
					return cloneable as string;
				case 3:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႨႨ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : EventHandler where _0021_00211 : Control
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 5;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴄ[85] - 12103;
				break;
			case 9:
				num = (((P_3 ^ P_2) - 28) ^ num3) switch
				{
					0 => ⴄ[269] - 37541, 
					_ => ⴄ[92] - ⴄ[92], 
				};
				break;
			case 0:
				num = 7;
				break;
			case 1:
			case 8:
				P_0.Click += P_1;
				goto case 7;
			case 7:
				num3++;
				goto case 6;
			case 6:
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 4;
				break;
			case 4:
				num = ((num2 % 2 != 0) ? (ⴀႠ[117] - 64726) : 2);
				break;
			case 2:
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႨႥ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : DxSpot
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			int num = 0;
			int num2 = 12;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
					break;
				case 12:
					num2 = (((P_1 ^ P_2) - 30) ^ num) switch
					{
						0 => 13, 
						1 => 7, 
						2 => 8, 
						3 => 6, 
						4 => 1, 
						_ => ⴀႠ[0] - 49948, 
					};
					continue;
				case 9:
					enumerable = null;
					num2 = 14;
					continue;
				case 13:
					enumerable = P_0.State;
					num2 = 14;
					continue;
				case 7:
					enumerable = P_0.Name;
					num2 = 14;
					continue;
				case 8:
					enumerable = P_0.Call;
					num2 = ⴗ[103] - 55677;
					continue;
				case 6:
					enumerable = P_0.Comment;
					num2 = 14;
					continue;
				case 1:
				case 10:
					enumerable = P_0.Mode;
					num2 = 14;
					continue;
				case 5:
				case 14:
				{
					num++;
					int num3 = 3236;
					int num4 = 339;
					num2 = ((809 < num3 / 4 - num4) ? 12 : 0);
					continue;
				}
				case 0:
					return (string)enumerable;
				case 11:
					num2 = ⴅ[25] * 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႨႣ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : DxSpot
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = 7;
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
				case 7:
					num2 = (((P_2 ^ P_1) - 112) ^ num) switch
					{
						0 => ⴅ[102], 
						1 => ⴗ[134] - 12482, 
						_ => ⴅ[85] - 123, 
					};
					continue;
				case 6:
					cloneable = null;
					num2 = 2;
					continue;
				case 3:
				case 10:
				case 11:
					cloneable = P_0.SpotterState;
					num2 = 2;
					continue;
				case 1:
					cloneable = P_0.GetUserString();
					num2 = ⴀႠ[86] - 44450;
					continue;
				case 2:
				{
					num++;
					int num3 = 2892;
					int num4 = 474;
					num2 = ((964 < num3 / 3 - num4) ? (ⴀႠ[97] - 34995) : (ⴀႠ[92] - 62203));
					continue;
				}
				case 0:
					return (string)cloneable;
				case 4:
				case 8:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႨႤ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DataGridViewCellEventArgs
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 18) ^ num) switch
					{
						0 => 4, 
						_ => ⴄ[143] - 48969, 
					};
					continue;
				case 6:
				case 7:
					result = 13;
					num2 = ⴀႠ[92] - 62203;
					continue;
				case 4:
					result = P_0.RowIndex;
					num2 = 0;
					continue;
				case 0:
				case 1:
				{
					int num3 = num;
					Bye.Ⴄ[222] = (char)(Bye.Ⴄ[222] & P_1 & 0x14);
					num = num3 + 1;
					goto case 3;
				}
				case 3:
				{
					int num4 = 1132;
					int num5 = 265;
					num2 = ((566 < num4 / 2 - num5) ? 8 : 5);
					continue;
				}
				case 5:
					return result;
				case 10:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataGridViewCell ႨႳ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, char P_3) where _0021_00210 : DataGridViewCellCollection
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[129] - 52905;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[109] - 53707;
					continue;
				case 7:
					break;
				case 2:
					num2 = (((P_3 ^ P_2) - 75) ^ num) switch
					{
						0 => 5, 
						_ => 4, 
					};
					continue;
				case 3:
				case 4:
					obj = null;
					num2 = 0;
					continue;
				case 5:
					obj = P_0[P_1];
					num2 = ⴀႠ[85] - ⴀႠ[85];
					continue;
				case 0:
					num++;
					goto case 1;
				case 1:
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴗ[145] - 59479;
					continue;
				case 6:
					num2 = ((num3 % 2 != 0) ? (ⴗ[152] - 32164) : 9);
					continue;
				case 9:
					return (DataGridViewCell)obj;
				case 11:
					num2 = ⴀႠ[20] - 33398;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႨႰ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : FileSystemEventArgs
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		IComparable comparable = default(IComparable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[89] - 12667;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 3:
					num2 = (((P_2 ^ P_1) - 77) ^ num) switch
					{
						0 => 4, 
						_ => 5, 
					};
					continue;
				case 5:
					comparable = null;
					num2 = 6;
					continue;
				case 0:
				case 4:
					comparable = P_0.Name;
					num2 = ⴅ[48] / 9;
					continue;
				case 6:
				case 8:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 9;
					continue;
				case 9:
					num2 = ((num3 % 2 != 0) ? (ⴄ[269] - 37546) : 2);
					continue;
				case 2:
				case 7:
					return (string)comparable;
				case 10:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DialogResult ႨႼ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, MessageBoxButtons P_2, MessageBoxIcon P_3, short P_4, char P_5) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		DialogResult result = default(DialogResult);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[111] - 41303;
					continue;
				case 10:
					break;
				case 1:
					num2 = (((P_4 ^ P_5) - 56) ^ num) switch
					{
						0 => ⴄ[230] - 23682, 
						_ => 3, 
					};
					continue;
				case 3:
					result = DialogResult.None;
					num2 = 6;
					continue;
				case 0:
				case 7:
					result = MessageBox.Show(P_0, P_1, P_2, P_3);
					num2 = ⴗ[158] - 28144;
					continue;
				case 6:
					num++;
					goto case 9;
				case 9:
				case 11:
				{
					int num3 = 516;
					int num4 = 687;
					num2 = ((4122 > num4 - num3 * 6) ? 4 : 5);
					continue;
				}
				case 5:
					num2 = 1;
					continue;
				case 4:
					return result;
				case 8:
					num2 = ⴗ[41] - 23803;
					continue;
				}
				break;
			}
		}
	}
}
