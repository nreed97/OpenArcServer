using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
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
using ArcInterfaces.Spots;
using ZedGraph;
using Ⴀ;

namespace ArcClientEngine.ArcForms;

public class DxSpotRateGraph : Form
{
	internal sealed class Ⴍ
	{
		internal List<AnnFilter> Ⴄ;

		internal string Ⴍ;

		internal string Ⴀ;

		internal Ⴍ()
		{
		}
	}

	private ArcClientObjMgr Ⴐ;

	private DxSpotRates Ⴓ;

	private FilterPicker.ႥႣ m_Ⴃ;

	public DxSpotRateGraph(ArcClientObjMgr om)
	{
		Ⴃ();
		Ⴐ = om;
		Ⴓ = Ⴐ.Caches.Dx.DxSpotRates;
	}

	private void Ⴄ(object P_0, EventArgs P_1)
	{
		CreateChart(this.m_Ⴃ.Ⴍ);
	}

	public void CreateChart(ZedGraphControl zgc)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 18;
		ICloneable cloneable = default(ICloneable);
		Array array = default(Array);
		int num2 = default(int);
		ISerializable serializable = default(ISerializable);
		while (true)
		{
			switch (num)
			{
			default:
				cloneable = HighlightCountyCfg.Ⴓ(zgc, 106, 125);
				AnnFilters.Ⴀ(TelnetServerCfg.Ⴓ((PaneBase)(cloneable as GraphPane), (short)30, 37), ClientCty.Ⴗ('©', 8, 307013143), 40, 'd');
				num = 13;
				break;
			case 13:
				AnnFilters.Ⴀ((ZedGraph.Label)TelnetServerCfg.Ⴍ((Axis)ႥႠ.Ⴃ(cloneable as GraphPane, 688, 678), (short)331, (short)336), ClientCty.Ⴗ('\a', 6, 307013134), 384, 'ǌ');
				num = 8;
				break;
			case 8:
				AnnFilters.Ⴀ((ZedGraph.Label)TelnetServerCfg.Ⴍ((Axis)WxFilters.ႭႠ((GraphPane)cloneable, 400, 433), (short)405, (short)398), ClientCty.Ⴗ('å', 4, 307013178), 65, '\r');
				num = ⴗ[28] - 37803;
				break;
			case 5:
				array = new double[30];
				num2 = 0;
				num = ⴅ[122] - 35;
				break;
			case 12:
				((double[])array)[num2] = -30 + num2;
				num2++;
				num = ⴄ[237] - 13492;
				break;
			case 11:
				num = ((num2 < 30) ? 12 : (ⴄ[47] - 24185));
				break;
			case 16:
				ShowUsers.Ⴃ(ႳႥ.ႥႣ((GraphPane)cloneable, 473, 508), new Fill(UserInfo.Ⴅ(255, 255, 245, 63, 33), UserInfo.Ⴅ(255, 255, 190, 679, 697), 90f), 960, 949);
				num = 1;
				break;
			case 1:
				serializable = ClientCty.Ⴄ(cloneable as GraphPane, ႥႥ.Ⴍ(2, 1580608859, '\b', null), (double[])array, Ⴓ.DxCount, HighlightItuZoneCfg.ႳႷ(1016, 923), 334, 'Ĩ');
				num = 0;
				break;
			case 0:
				ႥႭ.ႳႳ(HighlightCountyCfg.Ⴅ((LineItem)serializable, 765, 708), new Fill(ClientCfg.Ⴍ(871, 779)), 'Ǳ', 511);
				num = ⴅ[62] - 197;
				break;
			case 9:
				serializable = ClientCty.Ⴄ(cloneable as GraphPane, WxFilters.Ⴀ(null, 8, 103387744), array as double[], Ⴓ.SkimCount, DxEmailCfg.Ⴍ(90, 44), 302, 'ň');
				num = ⴗ[161] - 4996;
				break;
			case 3:
				ႥႭ.ႳႳ(HighlightCountyCfg.Ⴅ(serializable as LineItem, 664, 673), new Fill(ClientCfg.Ⴍ(212, 184)), 'ϊ', 964);
				goto case 14;
			case 14:
				num = ⴀႠ[62] - 58857;
				break;
			case 15:
				serializable = (cloneable as GraphPane).AddCurve(ClientCty.Ⴗ('Ü', 8, 307013211), (double[])array, Ⴓ.Master, Color.DarkGreen);
				num = 7;
				break;
			case 7:
				((LineItem)serializable).Symbol.Fill = new Fill(Color.White);
				serializable = ((GraphPane)cloneable).AddCurve(ႥႥ.Ⴅ(1673508204, null, 4), array as double[], Ⴓ.Lotw, Color.Purple);
				num = 19;
				break;
			case 17:
			case 19:
				((LineItem)serializable).Symbol.Fill = new Fill(Color.White);
				serializable = (cloneable as GraphPane).AddCurve(ႥႥ.Ⴍ(7, 1580608843, '\u008b', null), array as double[], Ⴓ.InCb, Color.Black);
				num = 10;
				break;
			case 4:
			case 10:
				(serializable as LineItem).Symbol.Fill = new Fill(Color.White);
				((GraphPane)cloneable).XAxis.Scale.Min = -30.0;
				num = 6;
				break;
			case 6:
				((GraphPane)cloneable).XAxis.Scale.Max = 0.0;
				(cloneable as GraphPane).YAxis.MajorGrid.IsVisible = true;
				num = 2;
				break;
			case 2:
				((GraphPane)cloneable).YAxis.MinorGrid.IsVisible = true;
				zgc.AxisChange();
				return;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 6;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? (ⴄ[239] - 49132) : ⴅ[285]);
				continue;
			case 5:
				num = ((this.m_Ⴃ.Ⴗ == null) ? (ⴀႠ[68] - 51744) : (ⴗ[72] - 15848));
				continue;
			case 1:
				this.m_Ⴃ.Ⴗ.Dispose();
				break;
			case 3:
				break;
			case 0:
				return;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void Ⴃ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
			{
				UserControl userControl = new ZedGraphControl();
				this.m_Ⴃ.Ⴍ = (ZedGraphControl)userControl;
				AnnFilters.Ⴓ((Control)this, 'ƚ', 'ƅ');
				num = ⴅ[295] - 88;
				break;
			}
			case 12:
				MultimediaCache.Ⴄ((Control)this.m_Ⴃ.Ⴍ, DockStyle.Fill, 477, (short)480);
				HighlightCountyCfg.Ⴜ((Control)this.m_Ⴃ.Ⴍ, new Point(0, 0), 959, 1004);
				num = ⴀႠ[116] - 60576;
				break;
			case 8:
			case 10:
				ႥႤ.Ⴀ((Control)this.m_Ⴃ.Ⴍ, ClientCty.Ⴗ('\u008b', 1, 307013191), 'ʘ', '\u02f5');
				num = 9;
				break;
			case 0:
			case 9:
				SkimmerSpotRateGraph.Ⴜ(this.m_Ⴃ.Ⴍ, 0.0, 852, '\u0369');
				SkimmerSpotRateGraph.Ⴜ(this.m_Ⴃ.Ⴍ, 0.0, 884, '\u034a');
				num = 14;
				break;
			case 14:
				DxSpotRates.ႠႷ(this.m_Ⴃ.Ⴍ, 0.0, 745, 686);
				DxSpotRates.ႠႷ(this.m_Ⴃ.Ⴍ, 0.0, 595, 539);
				num = 2;
				break;
			case 2:
				DxSpotRates.ႠႷ(this.m_Ⴃ.Ⴍ, 0.0, 326, 271);
				ႥႥ.ႤႣ(this.m_Ⴃ.Ⴍ, 0.0, 792, 853);
				num = 6;
				break;
			case 6:
				ႥႥ.ႤႣ(this.m_Ⴃ.Ⴍ, 0.0, 799, 849);
				ArcClientConnectDat.Ⴄ((Control)this.m_Ⴃ.Ⴍ, new Size(688, 442), 'ç', 186);
				num = 1;
				break;
			case 1:
				DxEmailCfg.Ⴈ((Control)this.m_Ⴃ.Ⴍ, 0, (short)639, 'Ɏ');
				ArcClientConnectDat.Ⴅ((ContainerControl)this, new SizeF(6f, 13f), 37, (short)52);
				num = 11;
				break;
			case 11:
				base.AutoScaleMode = AutoScaleMode.Font;
				base.ClientSize = new Size(688, 442);
				base.Controls.Add(this.m_Ⴃ.Ⴍ);
				num = ⴗ[85] - 18001;
				break;
			case 13:
				base.Name = ClientCty.Ⴗ('u', 2, 307013184);
				base.StartPosition = FormStartPosition.CenterParent;
				goto case 4;
			case 4:
				num = ⴀႠ[26] - 10574;
				break;
			case 7:
				Text = ClientCty.Ⴗ('Ú', 3, 307013235);
				base.Load += Ⴄ;
				num = 5;
				break;
			case 5:
				ResumeLayout(performLayout: false);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static DxSpotRateGraph()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, short P_3) where _0021_00210 : Font where _0021_00211 : DataGridViewCellStyle
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				break;
			case 2:
				num = (((P_2 ^ P_3) - 71) ^ num2) switch
				{
					0 => ⴀႠ[48] - 3652, 
					_ => 7, 
				};
				break;
			case 7:
				num = ⴄ[138] - 8073;
				break;
			case 9:
				P_0.Font = P_1;
				goto case 4;
			case 4:
				num2++;
				goto case 3;
			case 3:
			{
				int num3 = 373;
				int num4 = 1015;
				num = ((9135 > num4 - num3 * 9) ? 8 : (ⴅ[172] - 63));
				break;
			}
			case 0:
			case 1:
				num = 2;
				break;
			case 6:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataGridViewCellStyle Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DataGridViewBand
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		object obj = default(object);
		int num3 = default(int);
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
					num2 = ⴀႠ[110] - ⴀႠ[110];
					continue;
				case 0:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 110) ^ num) switch
					{
						0 => ⴄ[109] - 56961, 
						_ => 10, 
					};
					continue;
				case 3:
				case 10:
					obj = null;
					num2 = ⴅ[5] - ⴅ[313];
					continue;
				case 7:
					obj = P_0.DefaultCellStyle;
					num2 = ⴗ[122] - 26795;
					continue;
				case 6:
				case 11:
				{
					int num4 = num;
					Bye.Ⴄ[73] = (char)((Bye.Ⴄ[73] | HighlightCtyCfg.ႠႠ[68]) & 0x20);
					num = num4 + 1;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 4;
					continue;
				}
				case 4:
					num2 = ((num3 % 2 != 0) ? 1 : (ⴗ[129] - 40410));
					continue;
				case 8:
					return (DataGridViewCellStyle)obj;
				case 2:
				case 9:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static IEnumerator Ⴅ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : BaseCollection
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 10;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[104] - 48545;
					continue;
				case 2:
					break;
				case 10:
					num2 = (((P_1 ^ P_2) - 35) ^ num) switch
					{
						0 => ⴅ[36] - 43, 
						_ => 5, 
					};
					continue;
				case 5:
				case 7:
					obj = null;
					num2 = 4;
					continue;
				case 3:
				case 6:
				case 8:
					obj = P_0.GetEnumerator();
					num2 = ⴅ[115] + ⴅ[17];
					continue;
				case 4:
				{
					num++;
					int num3 = 141;
					int num4 = 176;
					num2 = ((704 <= num4 - num3 * 4) ? 1 : (ⴅ[176] - 4));
					continue;
				}
				case 1:
					num2 = 10;
					continue;
				case 11:
					return obj as IEnumerator;
				case 0:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DxSpot
	{
		char[] ⴄ = Bye.Ⴄ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 10;
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
				case 10:
					num2 = (((P_1 ^ P_2) - 29) ^ num) switch
					{
						0 => ⴄ[39] - 46462, 
						1 => 6, 
						_ => ⴄ[129] - 52903, 
					};
					continue;
				case 4:
					result = false;
					num2 = 5;
					continue;
				case 8:
					result = P_0.InCb;
					num2 = ⴄ[191] - 7658;
					continue;
				case 6:
				case 11:
					result = P_0.Skimmer;
					num2 = 5;
					continue;
				case 5:
					num++;
					goto case 1;
				case 1:
				case 12:
				{
					int num3 = 622;
					int num4 = 777;
					num2 = ((7770 > num4 - num3 * 10) ? (ⴄ[248] - 4565) : 2);
					continue;
				}
				case 2:
					num2 = ⴄ[239] - 49125;
					continue;
				case 9:
					return result;
				case 3:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}
}
