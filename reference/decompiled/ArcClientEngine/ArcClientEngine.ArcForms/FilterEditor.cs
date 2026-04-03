using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using Ⴀ;

namespace ArcClientEngine.ArcForms;

public class FilterEditor : Form
{
	internal sealed class ႷႼ
	{
		internal string Ⴐ;

		internal string Ⴓ;

		internal LegalCfg Ⴍ;

		internal ClientCty Ⴀ;

		internal bool Ⴃ;

		internal TelnetServerCfg Ⴈ;

		internal MultimediaCfg Ⴄ;

		internal ႷႼ()
		{
		}
	}

	private Label Ⴃ;

	private Button Ⴀ;

	private TextBox Ⴗ;

	private TextBox Ⴓ;

	private Label Ⴅ;

	private FilterType Ⴜ;

	private ႥႭ.ႳႨ m_ႷႠ = new ႥႭ.ႳႨ();

	public string FilterName
	{
		get
		{
			char[] ⴗ = ႥႰ.Ⴗ;
			return ArcClientConnectDat.ႷႠ((Control)Ⴗ, 948, (short)915);
		}
		set
		{
			ႥႠ.ႭႤ((Control)Ⴗ, value, 'ȯ', 'ɏ');
			ႥႰ.Ⴗ[131] = (char)((ႥႰ.Ⴗ[131] + ႥႰ.Ⴗ[126]) & 0x47);
		}
	}

	public string Filter
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return ArcClientConnectDat.ႷႠ((Control)Ⴓ, 378, (short)349);
		}
		set
		{
			ႥႠ.ႭႤ((Control)Ⴓ, value, 'Ņ', 'ĥ');
		}
	}

	protected override void Dispose(bool disposing)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? ⴅ[17] : 6);
				continue;
			case 6:
				num = ((this.m_ႷႠ.Ⴀ == null) ? (ⴗ[23] - 52206) : (ⴗ[31] - 64611));
				continue;
			case 5:
				this.m_ႷႠ.Ⴀ.Dispose();
				break;
			case 0:
			case 4:
				break;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void ႷႠ()
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 16;
		while (true)
		{
			switch (num)
			{
			default:
			{
				Ⴃ = new Label();
				object obj = new Button();
				this.m_ႷႠ.Ⴗ = obj as Button;
				num = 6;
				break;
			}
			case 6:
			{
				Ⴀ = new Button();
				Ⴗ = new TextBox();
				Control control = new Label();
				this.m_ႷႠ.Ⴃ = (Label)control;
				num = 14;
				break;
			}
			case 14:
				Ⴓ = new TextBox();
				Ⴅ = new Label();
				AnnFilters.Ⴓ((Control)this, 'ϑ', 'ώ');
				goto case 13;
			case 13:
				num = 11;
				break;
			case 11:
				UserInfo.ႥႣ((Control)Ⴃ, true, (short)282, (short)383);
				HighlightCountyCfg.Ⴜ((Control)Ⴃ, new Point(12, 8), 914, 961);
				num = 15;
				break;
			case 15:
				ႥႤ.Ⴀ((Control)Ⴃ, ႥႥ.Ⴅ(1673508422, null, 3), 'Α', 'ϼ');
				num = ⴄ[123] - 61744;
				break;
			case 7:
				ArcClientConnectDat.Ⴄ((Control)Ⴃ, new Size(35, 13), 'ķ', 362);
				DxEmailCfg.Ⴈ((Control)Ⴃ, 0, (short)333, 'ż');
				num = 30;
				break;
			case 30:
				ႥႠ.ႭႤ((Control)Ⴃ, ႥႥ.Ⴍ(7, 1580608614, '\u0093', null), '®', 'Î');
				num = 19;
				break;
			case 19:
				HighlightCountyCfg.Ⴜ((Control)this.m_ႷႠ.Ⴗ, new Point(234, 123), 823, 868);
				num = 25;
				break;
			case 25:
				ႥႤ.Ⴀ((Control)this.m_ႷႠ.Ⴗ, ႥႥ.Ⴅ(1673508257, null, 8), 'Ŧ', 'ċ');
				num = 17;
				break;
			case 17:
				ArcClientConnectDat.Ⴄ((Control)this.m_ႷႠ.Ⴗ, new Size(75, 23), '\u02ea', 695);
				num = ⴅ[37] - 21;
				break;
			case 34:
				DxEmailCfg.Ⴈ((Control)this.m_ႷႠ.Ⴗ, 1, (short)309, 'Ą');
				ႥႠ.ႭႤ((Control)this.m_ႷႠ.Ⴗ, ႥႥ.Ⴅ(1673508416, null, 1), 'ƞ', 'Ǿ');
				num = 22;
				break;
			case 22:
				ArcClientConnectDat.Ⴜ((ButtonBase)this.m_ႷႠ.Ⴗ, true, 420, (short)437);
				FilterViewer.ႨႨ<EventHandler, Control>(this.m_ႷႠ.Ⴗ, ႷႣ, 'ǜ', 448);
				num = ⴀႠ[70] - 49210;
				break;
			case 38:
				HighlightCountyCfg.Ⴜ((Control)Ⴀ, new Point(392, 123), 500, 423);
				ႥႤ.Ⴀ((Control)Ⴀ, ClientCty.Ⴗ('õ', 2, 307013188), 'Ǥ', 'Ɖ');
				goto case 31;
			case 31:
				num = 20;
				break;
			case 20:
				ArcClientConnectDat.Ⴄ((Control)Ⴀ, new Size(75, 23), '\u035a', 775);
				DxEmailCfg.Ⴈ((Control)Ⴀ, 2, (short)932, 'Ε');
				num = ⴄ[194] - 58443;
				break;
			case 28:
				ႥႠ.ႭႤ((Control)Ⴀ, ClientCty.Ⴗ('m', 7, 307013017), 'ě', 'Ż');
				num = 26;
				break;
			case 26:
				ArcClientConnectDat.Ⴜ((ButtonBase)Ⴀ, true, 789, (short)772);
				FilterViewer.ႨႨ<EventHandler, Control>(Ⴀ, ႷႷ, 'ώ', 978);
				num = ⴅ[102];
				break;
			case 10:
				HighlightCountyCfg.Ⴜ((Control)Ⴗ, new Point(53, 7), 430, 509);
				ႥႤ.Ⴀ((Control)Ⴗ, ClientCty.Ⴗ('\'', 8, 307013021), 'ċ', 'Ŧ');
				num = ⴅ[18];
				break;
			case 36:
				ArcClientConnectDat.Ⴄ((Control)Ⴗ, new Size(121, 20), 'ɍ', 528);
				DxEmailCfg.Ⴈ((Control)Ⴗ, 3, (short)688, 'ʁ');
				num = ⴀႠ[75] - 37465;
				break;
			case 12:
				UserInfo.ႥႣ((Control)this.m_ႷႠ.Ⴃ, true, (short)379, (short)286);
				HighlightCountyCfg.Ⴜ((Control)this.m_ႷႠ.Ⴃ, new Point(12, 43), 553, 634);
				num = 33;
				break;
			case 33:
				ႥႤ.Ⴀ((Control)this.m_ႷႠ.Ⴃ, ႥႥ.Ⴅ(1673508445, null, 5), 'Ǘ', 'ƺ');
				num = ⴅ[51] - 225;
				break;
			case 23:
				ArcClientConnectDat.Ⴄ((Control)this.m_ႷႠ.Ⴃ, new Size(29, 13), '/', 114);
				num = ⴗ[149] - 53646;
				break;
			case 35:
				DxEmailCfg.Ⴈ((Control)this.m_ႷႠ.Ⴃ, 6, (short)54, '\a');
				ႥႠ.ႭႤ((Control)this.m_ႷႠ.Ⴃ, ႥႥ.Ⴍ(3, 1580609437, 'Y', null), 'ȯ', 'ɏ');
				goto case 5;
			case 5:
				num = 27;
				break;
			case 27:
				HighlightCountyCfg.Ⴜ((Control)Ⴓ, new Point(53, 43), 607, 524);
				ႥႥ.ႤႰ((TextBoxBase)Ⴓ, true, 'ͻ', (short)841);
				num = 37;
				break;
			case 37:
				ႥႤ.Ⴀ((Control)Ⴓ, ႥႥ.Ⴅ(1673508435, null, 7), 'Ő', 'Ľ');
				num = 0;
				break;
			case 0:
				ArcClientConnectDat.Ⴄ((Control)Ⴓ, new Size(636, 71), 'ˤ', 697);
				DxEmailCfg.Ⴈ((Control)Ⴓ, 7, (short)314, 'ċ');
				num = ⴀႠ[31] - 4524;
				break;
			case 18:
				UserInfo.ႥႣ((Control)Ⴅ, true, (short)1, (short)100);
				Ⴅ.ForeColor = Color.Red;
				num = 3;
				break;
			case 3:
				Ⴅ.Location = new Point(194, 9);
				Ⴅ.Name = WxFilters.Ⴀ(null, 0, 103387528);
				num = 9;
				break;
			case 9:
				Ⴅ.Size = new Size(103, 13);
				Ⴅ.TabIndex = 8;
				num = 24;
				break;
			case 24:
				Ⴅ.Text = ႥႥ.Ⴍ(8, 1580609423, '\t', null);
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				num = ⴀႠ[6] - 62249;
				break;
			case 2:
				base.AutoScaleMode = AutoScaleMode.Font;
				base.ClientSize = new Size(701, 158);
				base.Controls.Add(Ⴅ);
				num = ⴅ[4];
				break;
			case 8:
				base.Controls.Add(Ⴓ);
				base.Controls.Add(this.m_ႷႠ.Ⴃ);
				num = ⴗ[31] - 64584;
				break;
			case 32:
				base.Controls.Add(Ⴗ);
				base.Controls.Add(Ⴀ);
				num = ⴅ[194];
				break;
			case 29:
				base.Controls.Add(this.m_ႷႠ.Ⴗ);
				base.Controls.Add(Ⴃ);
				num = ⴀႠ[6] - 62247;
				break;
			case 4:
				base.Name = WxFilters.Ⴀ(null, 8, 103387524);
				base.StartPosition = FormStartPosition.CenterParent;
				num = 21;
				break;
			case 21:
				Text = WxFilters.Ⴀ(null, 1, 103387582);
				ResumeLayout(performLayout: false);
				num = ⴀႠ[97] - 35001;
				break;
			case 1:
				PerformLayout();
				return;
			}
		}
	}

	public FilterEditor()
	{
		ႷႠ();
	}

	public FilterEditor(ArcClientObjMgr om, FilterType type)
		: this()
	{
		this.m_ႷႠ.Ⴍ = om as ArcClientObjMgr;
		Ⴜ = type;
		ႥႠ.ႭႤ((Control)Ⴅ, string.Empty, 'μ', 'Ϝ');
		Text = ႥႤ.Ⴗ(Ⴜ, ArcClientConnectDat.ႷႠ((Control)this, 850, (short)885));
	}

	private void ႷႷ(object P_0, EventArgs P_1)
	{
		ႥႷ.Ⴄ((Form)this, 756, 'ˣ');
	}

	private void ႷႣ(object P_0, EventArgs P_1)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 5;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = (ႷႭ() ? (ⴗ[125] - 55794) : 0);
				goto IL_0038;
			case 3:
			case 4:
				TelnetServerCfg.Ⴐ((Form)this, DialogResult.OK, 241, (short)230);
				break;
			case 2:
				break;
			case 0:
				return;
			}
			break;
			IL_0038:
			num = num2;
		}
		Close();
	}

	private bool ႷႭ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		while (true)
		{
			int num = ((ႳႳ.Ⴓ(ArcClientConnectDat.ႷႠ((Control)Ⴗ, 626, (short)597), 'λ', 925) != 0) ? 2 : (ⴀႠ[62] - 58864));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 9;
					continue;
				case 9:
					break;
				case 8:
					ႥႠ.ႭႤ((Control)Ⴅ, WxFilters.Ⴀ(null, 8, 103388761), 'ʑ', '\u02f1');
					num = 3;
					continue;
				case 3:
				case 5:
					return false;
				case 2:
					num = ((!ႷႨ()) ? 1 : (ⴄ[234] - 24916));
					continue;
				case 1:
					Ⴅ.Text = ႥႥ.Ⴍ(8, 1580609465, 'A', null);
					goto case 0;
				case 0:
					return false;
				case 7:
					return true;
				}
				break;
			}
		}
	}

	private bool ႷႨ()
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		while (true)
		{
			IEnumerable enumerable = string.Empty;
			FilterType ⴜ = Ⴜ;
			while (true)
			{
				IL_0071:
				int num = ⴜ switch
				{
					FilterType.DX => ⴗ[90] - 35256, 
					FilterType.Ann => ⴅ[102], 
					FilterType.WX => ⴄ[240] - 48067, 
					_ => ⴗ[70] - 33493, 
				};
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴄ[236] - 11652;
						continue;
					case 6:
						break;
					case 0:
						goto IL_0071;
					case 1:
					case 7:
					case 9:
						num = 3;
						continue;
					case 8:
						enumerable = TelnetServerCfg.Ⴗ(ArcClientConnectDat.ႷႠ((Control)Ⴓ, 714, (short)749), SqlFilterType.Dx, '[', 121);
						num = 5;
						continue;
					case 5:
						return this.m_ႷႠ.Ⴍ.Caches.Dx.IsValidFilter((string)enumerable);
					case 10:
						enumerable = TelnetServerCfg.Ⴗ(ArcClientConnectDat.ႷႠ((Control)Ⴓ, 587, (short)620), SqlFilterType.AnnWx, 'Q', 115);
						num = 4;
						continue;
					case 4:
						return this.m_ႷႠ.Ⴍ.Caches.Ann.IsValidFilter(ArcClientConnectDat.ႷႠ((Control)Ⴓ, 252, (short)219));
					case 11:
						enumerable = UtilsSql.FormatSqlFilter(ArcClientConnectDat.ႷႠ((Control)Ⴓ, 391, (short)416), SqlFilterType.AnnWx);
						return this.m_ႷႠ.Ⴍ.Caches.Wx.IsValidFilter(Ⴓ.Text);
					case 3:
						return false;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static FilterEditor()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static void ႷႤ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, short P_3) where _0021_00210 : DataGridView
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 8;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႠ[115] - 48714;
				continue;
			case 3:
				num = (((P_2 ^ P_3) - 73) ^ num2) switch
				{
					0 => 2, 
					_ => 0, 
				};
				continue;
			case 0:
				num = ⴅ[297] - 244;
				continue;
			case 2:
				P_0.MultiSelect = P_1;
				goto case 6;
			case 6:
			case 7:
				num2++;
				num3 = 1518;
				break;
			case 1:
				break;
			case 4:
			case 5:
				return;
			}
			int num4 = 258;
			num = ((506 < num3 / 3 - num4) ? (ⴅ[389] - 57) : 5);
		}
	}

	[SecuritySafeCritical]
	internal static bool ႷႰ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DxSpot
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[79] - 32752;
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
				case 4:
					num2 = (((P_1 ^ P_2) - 73) ^ num) switch
					{
						0 => 8, 
						1 => ⴀႠ[110] - 48487, 
						_ => 2, 
					};
					continue;
				case 2:
					result = false;
					num2 = 12;
					continue;
				case 5:
				case 8:
					result = P_0.IsSkimQsy;
					num2 = 12;
					continue;
				case 1:
				case 3:
				case 11:
					result = P_0.Cq;
					num2 = ⴅ[115] * 3;
					continue;
				case 12:
				{
					num++;
					int num3 = 298;
					int num4 = 524;
					num2 = ((3144 > num4 - num3 * 6) ? (ⴄ[16] - 31819) : 10);
					continue;
				}
				case 10:
					num2 = 4;
					continue;
				case 6:
					return result;
				case 9:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႳ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, short P_3) where _0021_00210 : CultureInfo where _0021_00211 : Thread
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 3;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				continue;
			case 0:
				num = (((P_2 ^ P_3) - 12) ^ num2) switch
				{
					0 => ⴀႠ[30] - 50925, 
					_ => ⴗ[24] - 32642, 
				};
				continue;
			case 8:
				num = 2;
				continue;
			case 4:
				P_0.CurrentCulture = P_1;
				goto case 2;
			case 2:
				num2++;
				num3 = 1588;
				break;
			case 5:
				break;
			case 1:
			case 6:
			case 7:
				return;
			}
			int num4 = 155;
			num = ((397 >= num3 / 4 - num4) ? (ⴅ[297] - 245) : 0);
		}
	}

	[SecuritySafeCritical]
	internal static int ႷႥ(ref DateTime P_0, short P_1, short P_2)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[22] - 14484;
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
				case 7:
					num2 = (((P_2 ^ P_1) - 95) ^ num) switch
					{
						0 => ⴗ[149] - 53680, 
						_ => 0, 
					};
					continue;
				case 0:
					result = 9;
					num2 = ⴅ[25];
					continue;
				case 1:
					result = P_0.Minute;
					num2 = 2;
					continue;
				case 2:
				case 9:
				{
					num++;
					int num4 = 408;
					int num5 = 67;
					num2 = ((102 < num4 / 4 - num5) ? 7 : 3);
					continue;
				}
				case 3:
				case 4:
					return result;
				case 5:
				case 10:
				{
					byte num3 = ⴅ[343];
					UserCmd.Ⴅ[299] = (byte)((UserCmd.Ⴅ[299] - P_1) & 0x4B);
					num2 = num3 - 113;
					continue;
				}
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static AppDomain ႣႠ(char P_0, char P_1)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		_AppDomain appDomain = default(_AppDomain);
		int num3 = default(int);
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
					num2 = 11;
					continue;
				case 11:
					break;
				case 3:
					num2 = (((P_1 ^ P_0) - 123) ^ num) switch
					{
						0 => 7, 
						_ => 8, 
					};
					continue;
				case 8:
					appDomain = null;
					num2 = ⴀႠ[44] - 48724;
					continue;
				case 7:
					appDomain = AppDomain.CurrentDomain;
					num2 = 4;
					continue;
				case 0:
				case 4:
				case 9:
				case 10:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 5;
					continue;
				case 5:
					num2 = ((num3 % 2 != 0) ? 3 : 6);
					continue;
				case 6:
					return appDomain as AppDomain;
				case 1:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}
}
