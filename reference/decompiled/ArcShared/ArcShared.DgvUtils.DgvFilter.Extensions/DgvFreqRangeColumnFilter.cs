using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Security;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Arx;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.DgvUtils.DgvFilter.Extensions;

public class DgvFreqRangeColumnFilter : DgvBaseColumnFilter
{
	private new Label Ⴗ;

	private ArxServerClient.Ⴈ m_Ⴈ = new ArxServerClient.Ⴈ();

	public TextBox TextBoxValue
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			TextBox ⴓ = this.m_Ⴈ.Ⴓ;
			UtilsNumeric.Ⴀ[391] = (char)((UtilsNumeric.Ⴀ[391] * UtilsNumeric.Ⴀ[308]) & 0xDE);
			return ⴓ;
		}
	}

	public TextBox TextBoxValue2 => this.m_Ⴈ.Ⴄ;

	protected override void Dispose(bool disposing)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? (ⴃႭ[117] - 15378) : 5);
				continue;
			case 5:
			case 6:
				num = ((this.m_Ⴈ.Ⴅ == null) ? 4 : (ⴃႭ[198] - 52105));
				continue;
			case 3:
				this.m_Ⴈ.Ⴅ.Dispose();
				break;
			case 4:
				break;
			case 0:
			case 1:
				return;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void ႣႠ()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
			{
				TextBoxBase textBoxBase = new TextBox();
				this.m_Ⴈ.Ⴓ = textBoxBase as TextBox;
				TextBoxBase textBoxBase2 = new TextBox();
				this.m_Ⴈ.Ⴄ = textBoxBase2 as TextBox;
				num = 1;
				break;
			}
			case 1:
				Ⴗ = new Label();
				goto case 2;
			case 2:
				AutoUpdater.Ⴜ((Control)this, 245, 'ï');
				PrecisionTimer.Ⴗ((Control)this.m_Ⴈ.Ⴓ, new Point(64, 3), 'Ϯ', (short)966);
				num = ⴃႤ[530] - 23109;
				break;
			case 3:
				LogFile.Ⴀ((Control)this.m_Ⴈ.Ⴓ, ႣႼ.Ⴜ(4, 365387213, 5), (short)321, (short)334);
				num = 17;
				break;
			case 17:
				ServerIoCfg.ႤႰ((Control)this.m_Ⴈ.Ⴓ, new Size(71, 20), 'ʜ', (short)701);
				num = 16;
				break;
			case 12:
			case 16:
				ObjectCopierExt.Ⴅ((Control)this.m_Ⴈ.Ⴓ, 1, (short)363, 'ś');
				PrecisionTimer.Ⴗ((Control)this.m_Ⴈ.Ⴄ, new Point(64, 29), 'ϗ', (short)1023);
				num = 0;
				break;
			case 0:
				LogFile.Ⴀ((Control)this.m_Ⴈ.Ⴄ, DownloadUrl2.Ⴅ(16, null, 2018867829, 5), (short)607, (short)592);
				num = 13;
				break;
			case 13:
				ServerIoCfg.ႤႰ((Control)this.m_Ⴈ.Ⴄ, new Size(71, 20), 'Ǥ', (short)453);
				num = 10;
				break;
			case 10:
			{
				ObjectCopierExt.Ⴅ((Control)this.m_Ⴈ.Ⴄ, 2, (short)694, 'ʆ');
				DxSpotExt.Ⴀ((Control)Ⴗ, true, (short)202, 'ô');
				char num2 = ⴃႭ[49];
				WxCfg.ႣႭ[193] = (char)(WxCfg.ႣႭ[193] & WxCfg.ႣႭ[65] & 0x70);
				num = num2 - 57581;
				break;
			}
			case 8:
				PrecisionTimer.Ⴗ((Control)Ⴗ, new Point(14, 6), 'Ǯ', (short)454);
				LogFile.Ⴀ((Control)Ⴗ, DownloadUrl2.Ⴅ(18, null, 2018867681, 5), (short)62, (short)49);
				goto case 15;
			case 15:
				num = 9;
				break;
			case 9:
				ServerIoCfg.ႤႰ((Control)Ⴗ, new Size(19, 13), 'ū', (short)330);
				ObjectCopierExt.Ⴅ((Control)Ⴗ, 3, (short)216, 'è');
				num = ⴐ[91] - 953;
				break;
			case 14:
				AnnCfg.Ⴗ((Control)Ⴗ, ႣႼ.ႥႭ(null, 624736209, 7, null), (short)305, 'Ķ');
				num = ⴀ[403] - 52872;
				break;
			case 11:
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				base.AutoScaleMode = AutoScaleMode.Font;
				BackColor = Color.Transparent;
				num = 5;
				break;
			case 5:
				base.Controls.Add(Ⴗ);
				base.Controls.Add(this.m_Ⴈ.Ⴄ);
				num = 6;
				break;
			case 6:
				base.Controls.Add(this.m_Ⴈ.Ⴓ);
				base.Name = TelnetServerClient.Ⴄ(1945322989, '\u0017', 0);
				num = 7;
				break;
			case 7:
				base.Size = new Size(139, 54);
				ResumeLayout(performLayout: false);
				PerformLayout();
				return;
			}
		}
	}

	public DgvFreqRangeColumnFilter()
	{
		ႣႠ();
		UtilsCopyright.Ⴃ<Control, EventHandler>(this.m_Ⴈ.Ⴓ, ႣႣ, 183, 189);
		this.m_Ⴈ.Ⴄ.TextChanged += ႣႣ;
	}

	protected override void OnFilterInitializing(object sender, CancelEventArgs e)
	{
		base.OnFilterInitializing(sender, e);
		StationCfg.Ⴃ(e, 52, 38);
	}

	protected override void OnFilterExpressionBuilding(object sender, CancelEventArgs e)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 1;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			switch (num)
			{
			default:
				base.OnFilterExpressionBuilding(sender, e);
				goto case 3;
			case 3:
				if (StationCfg.Ⴃ(e, 350, 332))
				{
					break;
				}
				while (true)
				{
					IComparable empty = string.Empty;
					int num2 = ((!ColumnFilterEventArgs.Ⴀ(empty as string, string.Empty, 372, 315)) ? (ⴐ[339] - 16172) : 0);
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 13:
							break;
						case 0:
							base.FilterExpression = (string)empty;
							base.FilterCaption = ReverseBeaconClient.Ⴗ(base.OriginalDataGridViewColumnHeaderText, ႣႼ.ႥႭ(null, 624735495, 2, null), 'Ψ', 'Ϡ');
							num2 = 7;
							continue;
						case 7:
							base.FilterManager.RebuildFilter();
							return;
						case 8:
							enumerable = DgvBaseColumnFilter.FormatValue(FrmUpdateAvailable.ႷႷ((Control)this.m_Ⴈ.Ⴓ, ']', 62), base.ColumnDataType);
							num2 = 9;
							continue;
						case 9:
							DgvBaseColumnFilter.FormatValue(FrmUpdateAvailable.ႷႷ((Control)this.m_Ⴈ.Ⴄ, 'Ȝ', 639), base.ColumnDataType);
							num2 = 1;
							continue;
						case 1:
						case 11:
							num2 = ((!ColumnFilterEventArgs.Ⴀ((string)enumerable, string.Empty, 745, 678)) ? 3 : (ⴃႣ[214] - 56061));
							continue;
						case 5:
							base.FilterExpression = UtilsEmail.Ⴀ(UtilsSql.Ⴍ(base.DataGridViewColumn, 338, 353), ArcLogInRqstExt.Ⴗ(1706507896, 6, 4), enumerable as string, 574, 616);
							num2 = ⴀ[43] - 13271;
							continue;
						case 10:
							base.FilterCaption = base.OriginalDataGridViewColumnHeaderText + DownloadUrl2.Ⴅ(25, null, 2018868854, 1) + this.m_Ⴈ.Ⴓ.Text;
							num2 = 4;
							continue;
						case 4:
						case 12:
							base.FilterManager.RebuildFilter();
							num2 = 3;
							continue;
						case 2:
						case 3:
							return;
						}
						break;
					}
				}
			case 2:
				base.FilterManager.RebuildFilter();
				return;
			}
			num = ⴀ[48] - 14605;
		}
	}

	private void ႣႣ(object P_0, EventArgs P_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				num = (base.FilterApplySoon ? 4 : 0);
				break;
			case 3:
			case 4:
			case 5:
				if (!DgvFilterHost.ႥႥ((Control)this, 611, 'Ƚ'))
				{
					num = 0;
					break;
				}
				base.Active = true;
				FilterExpressionBuild();
				return;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static DgvFreqRangeColumnFilter()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static bool Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, int P_3, char P_4) where _0021_00210 : System.Threading.Timer
	{
		char[] ⴗ = DxCfg.Ⴗ;
		bool result = default(bool);
		int num3 = default(int);
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
					num2 = 6;
					continue;
				case 6:
					break;
				case 9:
					num2 = (((P_3 ^ P_4) - 73) ^ num) switch
					{
						0 => 3, 
						_ => 2, 
					};
					continue;
				case 2:
					result = false;
					num2 = ⴗ[156] - 17091;
					continue;
				case 3:
					result = P_0.Change(P_1, P_2);
					num2 = 11;
					continue;
				case 0:
				case 11:
					num++;
					goto case 8;
				case 8:
					num3 = P_4 * P_4;
					goto case 5;
				case 5:
					num3 = P_4 + num3;
					num2 = 1;
					continue;
				case 1:
					num2 = ((num3 % 2 != 0) ? 9 : 4);
					continue;
				case 4:
					return result;
				case 10:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : Form
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႣ[232] - 47279;
				break;
			case 4:
				num = (((P_1 ^ P_2) - 20) ^ num2) switch
				{
					0 => 2, 
					1 => ⴐ[320] - 49920, 
					_ => 0, 
				};
				break;
			case 0:
				num = 10;
				break;
			case 1:
			case 2:
				P_0.Close();
				num = 10;
				break;
			case 7:
				Application.Run(P_0);
				goto case 10;
			case 10:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴗ[115] - 18162) : (ⴀ[371] - 3279));
				break;
			case 3:
				num = ⴗ[135] - 48377;
				break;
			case 6:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal new static int Ⴄ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, short P_3) where _0021_00211 : ArrayList
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int result = default(int);
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 9:
					num2 = (((P_3 ^ P_2) - 68) ^ num) switch
					{
						0 => 2, 
						_ => ⴃႭ[51] - 22361, 
					};
					continue;
				case 0:
					result = 14;
					goto case 1;
				case 1:
					num2 = 3;
					continue;
				case 2:
				case 7:
					result = P_0.Add(P_1);
					num2 = ⴃႭ[72] - 28230;
					continue;
				case 3:
					num++;
					num3 = 91;
					num4 = 227;
					goto case 11;
				case 11:
					num2 = ((454 > num4 - num3 * 2) ? 8 : 5);
					continue;
				case 5:
					num2 = ⴐ[124] - 50853;
					continue;
				case 8:
					return result;
				case 4:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3, int P_4) where _0021_00210 : Array where _0021_00211 : Array
	{
		int num = 8;
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = 9;
				continue;
			case 3:
			case 5:
			case 9:
				num = (((P_3 ^ P_4) - 106) ^ num4) switch
				{
					0 => 6, 
					_ => 7, 
				};
				continue;
			case 7:
				num = 1;
				continue;
			case 6:
				Array.Copy(P_0, P_1, P_2);
				goto case 1;
			case 1:
			{
				num4++;
				num3 = 40;
				int num5 = num3;
				num2 = num5 * num5;
				num = 0;
				continue;
			}
			case 0:
				num2 = num3 + num2;
				break;
			case 2:
				break;
			case 4:
				return;
			}
			num = ((num2 % 2 != 0) ? 9 : 4);
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : ListControl
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		object result = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[270] - 64625;
					continue;
				case 10:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 13) ^ num) switch
					{
						0 => ⴀ[210] - 35509, 
						_ => ⴃႣ[53] - 65083, 
					};
					continue;
				case 6:
					result = null;
					num2 = ⴗ[72] - 50242;
					continue;
				case 2:
					result = P_0.SelectedValue;
					num2 = 1;
					continue;
				case 1:
				case 4:
					num++;
					goto case 8;
				case 8:
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 5;
					continue;
				case 5:
					num2 = ((num3 % 2 == 0) ? (ⴀ[19] - 12897) : 0);
					continue;
				case 3:
				case 9:
					return result;
				case 11:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : System.Windows.Forms.Timer
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႤ[134] - 5902;
				break;
			case 3:
				num = (((P_1 ^ P_2) - 50) ^ num2) switch
				{
					0 => 8, 
					_ => ⴗ[36] - 32125, 
				};
				break;
			case 9:
				num = 6;
				break;
			case 8:
				P_0.Start();
				goto case 6;
			case 6:
				num2++;
				goto case 4;
			case 4:
			{
				int num3 = 17;
				int num4 = 432;
				num = ((3024 <= num4 - num3 * 7) ? 1 : 7);
				break;
			}
			case 1:
				num = 3;
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႣႳ<_0021_00210, _0021_00211, _0021_00212>(_0021_00212 P_0, _0021_00210 P_1, _0021_00211 P_2, int P_3, int P_4) where _0021_00210 : string where _0021_00211 : string where _0021_00212 : string
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			char num2 = ⴃႣ[93];
			DxCfg.Ⴗ[78] = (char)((DxCfg.Ⴗ[78] | DxCfg.Ⴗ[56]) & 0xBF);
			int num3 = num2 - 25918;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = 1;
					continue;
				case 1:
					break;
				case 3:
					num3 = (((P_3 ^ P_4) - 50) ^ num) switch
					{
						0 => 9, 
						_ => ⴃႤ[554] - 10976, 
					};
					continue;
				case 2:
					cloneable = null;
					goto case 7;
				case 7:
					num3 = 0;
					continue;
				case 9:
					cloneable = Regex.Replace(P_0, P_1, P_2);
					num3 = 0;
					continue;
				case 0:
				case 8:
					num++;
					goto case 5;
				case 5:
				{
					int num4 = 1761;
					int num5 = 154;
					num3 = ((587 < num4 / 3 - num5) ? 3 : 6);
					continue;
				}
				case 6:
					return cloneable as string;
				case 4:
					num3 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႣႥ<_0021_00210>(_0021_00210 P_0, byte P_1, short P_2, char P_3) where _0021_00210 : DxSpot
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 8;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_2 ^ P_3) - 57) ^ num2) switch
				{
					0 => 0, 
					_ => 1, 
				};
				break;
			case 1:
			case 2:
			case 9:
				num = 7;
				break;
			case 0:
				P_0.ItuZone = P_1;
				goto case 7;
			case 7:
				num2++;
				num3 = 53;
				goto case 3;
			case 3:
			{
				int num4 = 240;
				num = ((1920 > num4 - num3 * 8) ? 5 : (ⴃႭ[119] - 58719));
				break;
			}
			case 6:
				num = ⴃႭ[29] - 40515;
				break;
			case 5:
				return;
			}
		}
	}
}
