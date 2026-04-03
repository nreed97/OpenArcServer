using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Security;
using System.Windows.Forms;
using ArcInterfaces.Io;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using ArcShared.Forms;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.DgvUtils.DgvFilter.Implementations;

public class DgvTextBoxColumnFilter : DgvBaseColumnFilter
{
	internal new sealed class Ⴀ
	{
		internal DxCfg Ⴃ;

		internal WwvCfg Ⴐ;

		internal Ⴀ()
		{
		}
	}

	private TextBox Ⴅ;

	private UtilsSql.Ⴓ Ⴓ = new UtilsSql.Ⴓ();

	public ComboBox ComboBoxOperator => Ⴓ.Ⴃ;

	public TextBox TextBoxValue => Ⴅ;

	public DgvTextBoxColumnFilter()
	{
		ႨႨ();
		DgvFilterManager.Ⴍ<EventHandler, ListControl>(Ⴓ.Ⴃ, ႨႣ, 'Ǖ', 430);
		Ⴅ.TextChanged += ႨႣ;
	}

	protected override void OnFilterInitializing(object sender, CancelEventArgs e)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				base.OnFilterInitializing(sender, e);
				break;
			case 4:
				break;
			case 1:
			case 2:
				return;
			}
			if (!StationCfg.Ⴃ(e, 4, 22))
			{
				break;
			}
			num = 1;
		}
		while (true)
		{
			int num2 = ((!ObjectCopierExt.Ⴈ(base.ColumnDataType, typeof(string), '\u02ed', 'ˉ')) ? 6 : 0);
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					return;
				case 5:
					return;
				case 4:
				case 7:
					break;
				case 0:
				{
					ComboBox.ObjectCollection objectCollection2 = Ⴄ(Ⴓ.Ⴃ, '\u030e', 840);
					Array array2 = new object[5];
					((object[])array2)[0] = ႣႼ.ႥႭ(null, 624736252, 6, null);
					(array2 as object[])[1] = ArcLogInRqstExt.Ⴗ(1706507147, 2, 8);
					((object[])array2)[2] = ႣႼ.ႥႭ(null, 624736245, 7, null);
					(array2 as object[])[3] = ArcLogInRqstExt.Ⴗ(1706507145, 14, 1);
					((object[])array2)[4] = ႣႼ.ႥႭ(null, 624736222, 5, null);
					objectCollection2.AddRange(array2 as object[]);
					goto IL_0122;
				}
				case 1:
					goto IL_0122;
				case 6:
				{
					ComboBox.ObjectCollection objectCollection = Ⴄ(Ⴓ.Ⴃ, '\u0319', 863);
					Array array = new object[6];
					((object[])array)[0] = ႣႼ.ႥႭ(null, 624736252, 6, null);
					((object[])array)[1] = ArcLogInRqstExt.Ⴗ(1706507143, 27, 4);
					(array as object[])[2] = ArcLogInRqstExt.Ⴗ(1706507204, 1, 3);
					((object[])array)[3] = ႣႼ.ႥႭ(null, 624736214, 4, null);
					((object[])array)[4] = ArcLogInRqstExt.Ⴗ(1706507204, 27, 7);
					((object[])array)[5] = ႣႼ.ႥႭ(null, 624736212, 2, null);
					objectCollection.AddRange(array as object[]);
					goto case 3;
				}
				case 3:
					Ⴓ.Ⴃ.SelectedIndex = 0;
					base.FilterHost.RegisterComboBox(Ⴓ.Ⴃ);
					return;
				}
				break;
				IL_0122:
				num2 = 3;
			}
		}
	}

	protected override void OnFilterExpressionBuilding(object sender, CancelEventArgs e)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 3;
		IConvertible convertible2 = default(IConvertible);
		ICloneable cloneable = default(ICloneable);
		Array array = default(Array);
		while (true)
		{
			switch (num)
			{
			default:
				base.OnFilterExpressionBuilding(sender, e);
				goto case 4;
			case 4:
				if (StationCfg.Ⴃ(e, 649, 667))
				{
					break;
				}
				while (true)
				{
					IComparable comparable = string.Empty;
					object obj = base.OriginalDataGridViewColumnHeaderText;
					IConvertible convertible = FrmUpdateAvailable.ႷႷ((Control)Ⴅ, 'Χ', 964);
					int num2 = 30;
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 15:
							break;
						case 30:
							convertible2 = string.Empty;
							num2 = ((!FrmUpdating.ႠႥ(FrmUpdateAvailable.ႷႷ((Control)Ⴓ.Ⴃ, 'έ', 974), ႣႼ.Ⴜ(0, 365387200, 10), 724, 744)) ? (ⴗ[28] - 12117) : 23);
							continue;
						case 23:
							comparable = DgvBaseColumnFilter.GetNullCondition(UtilsSql.Ⴍ(base.DataGridViewColumn, 323, 368));
							num2 = 7;
							continue;
						case 7:
							num2 = ((!FrmUpdating.ႠႥ(FrmUpdateAvailable.ႷႷ((Control)Ⴓ.Ⴃ, '\u033f', 860), DownloadUrl2.Ⴅ(10, null, 2018867783, 6), 609, 605)) ? (ⴗ[141] - 5911) : (ⴃႣ[176] - 11022));
							continue;
						case 24:
							comparable = DgvBaseColumnFilter.GetNotNullCondition(UtilsSql.Ⴍ(base.DataGridViewColumn, 245, 198));
							num2 = 31;
							continue;
						case 31:
							num2 = ((!ColumnFilterEventArgs.Ⴀ((string)comparable, string.Empty, 730, 661)) ? (ⴐ[459] - 3862) : 22);
							continue;
						case 22:
							base.FilterExpression = (string)comparable;
							base.FilterCaption = UtilsEmail.Ⴀ((string)obj, DownloadUrl2.Ⴅ(24, null, 2018867784, 2), FrmUpdateAvailable.ႷႷ((Control)Ⴓ.Ⴃ, 'ϊ', 937), 543, 585);
							num2 = 2;
							continue;
						case 2:
							base.FilterManager.RebuildFilter();
							return;
						case 3:
							num2 = ((!ObjectCopierExt.Ⴈ(base.ColumnDataType, typeof(string), 'ϼ', 'Ϙ')) ? 18 : 27);
							continue;
						case 27:
							convertible = DgvBaseColumnFilter.StringEscape(convertible as string);
							num2 = (((cloneable = FrmUpdateAvailable.ႷႷ((Control)Ⴓ.Ⴃ, 'Ȧ', 581)) == null) ? (ⴃႣ[185] - 9483) : (ⴗ[117] - 12539));
							continue;
						case 0:
							num2 = (FrmUpdating.ႠႥ(cloneable as string, ႣႼ.ႥႭ(null, 624736245, 7, null), 215, 235) ? (ⴃႣ[174] - 9349) : (ⴃႣ[18] - 4814));
							continue;
						case 21:
							num2 = (FrmUpdating.ႠႥ(cloneable as string, ArcLogInRqstExt.Ⴗ(1706507149, 4, 5), 60, 0) ? (ⴃႤ[546] - 21637) : 6);
							continue;
						case 6:
							num2 = (FrmUpdating.ႠႥ((string)cloneable, ႣႼ.ႥႭ(null, 624736218, 1, null), 191, 131) ? 4 : 8);
							continue;
						case 8:
							num2 = ⴗ[58] - 1695;
							continue;
						case 13:
							comparable = HelpAboutServer.Ⴗ(UtilsSql.Ⴍ(base.DataGridViewColumn, 922, 937), ႣႼ.ႥႭ(null, 624736171, 3, null), (string)convertible, ArcLogInRqstExt.Ⴗ(1706507247, 17, 7), 1020, 'Β');
							goto case 26;
						case 26:
						case 32:
							num2 = 9;
							continue;
						case 9:
							obj = HelpAboutServer.Ⴗ((string)obj, ArcLogInRqstExt.Ⴗ(1706507248, 11, 5), convertible as string, ႣႼ.ႥႭ(null, 624736166, 1, null), 1006, '\u0380');
							num2 = ⴃႭ[85] - 1580;
							continue;
						case 29:
							comparable = HelpAboutServer.Ⴗ(UtilsSql.Ⴍ(base.DataGridViewColumn, 166, 149), ArcLogInRqstExt.Ⴗ(1706507256, 8, 5), convertible as string, ArcLogInRqstExt.Ⴗ(1706507232, 22, 8), 417, 'Ǐ');
							num2 = ⴃႤ[275] - 53794;
							continue;
						case 14:
						case 25:
							obj = HelpAboutServer.Ⴗ((string)obj, ႣႼ.ႥႭ(null, 624736157, 6, null), (string)convertible, ႣႼ.ႥႭ(null, 624736167, 0, null), 9, 'g');
							num2 = 19;
							continue;
						case 4:
							comparable = HelpAboutServer.Ⴗ(UtilsSql.Ⴍ(base.DataGridViewColumn, 49, 2), ႣႼ.ႥႭ(null, 624736174, 6, null), convertible as string, TelnetServerClient.Ⴄ(1945322701, '\u0098', 5), 310, 'Ř');
							num2 = 12;
							continue;
						case 12:
							obj = UtilsEmail.Ⴀ(obj as string, ArcLogInRqstExt.Ⴗ(1706507253, 24, 0), convertible as string, 675, 757);
							num2 = ⴃႣ[59] - 7239;
							continue;
						case 11:
							array = new string[6];
							((string[])array)[0] = UtilsSql.Ⴍ(base.DataGridViewColumn, 475, 488);
							num2 = ⴐ[89] - 28918;
							continue;
						case 28:
							(array as string[])[1] = ႣႼ.Ⴜ(1, 365387207, 10);
							(array as string[])[2] = FrmUpdateAvailable.ႷႷ((Control)Ⴓ.Ⴃ, 'ǽ', 414);
							num2 = 16;
							continue;
						case 16:
							((string[])array)[3] = TelnetServerClient.Ⴄ(1945322703, '\u0014', 7);
							((string[])array)[4] = convertible as string;
							num2 = ⴀ[144] - 46006;
							continue;
						case 17:
							(array as string[])[5] = TelnetServerClient.Ⴄ(1945322696, '\u008a', 0);
							comparable = string.Concat((string[])array);
							num2 = 10;
							continue;
						case 10:
							obj = (obj as string) + UtilsString.Ⴐ(null, 5, 192631502) + Ⴓ.Ⴃ.Text + (string)convertible;
							num2 = 19;
							continue;
						case 18:
							convertible2 = DgvBaseColumnFilter.FormatValue(convertible as string, base.ColumnDataType);
							num2 = ((!(convertible2 as string != string.Empty)) ? 19 : 20);
							continue;
						case 20:
							comparable = base.DataGridViewColumn.DataPropertyName + ႣႼ.Ⴜ(2, 365387204, 13) + Ⴓ.Ⴃ.Text + (string)convertible2;
							num2 = 1;
							continue;
						case 1:
							obj = (string)obj + UtilsString.Ⴐ(null, 6, 192631501) + Ⴓ.Ⴃ.Text + (convertible as string);
							num2 = 19;
							continue;
						case 19:
							num2 = ((!((string)comparable != string.Empty)) ? (ⴀ[166] - 10216) : 34);
							continue;
						case 34:
							base.FilterExpression = (string)comparable;
							base.FilterCaption = (string)obj;
							base.FilterManager.RebuildFilter();
							num2 = ⴐ[102] - 54932;
							continue;
						case 5:
							return;
						}
						break;
					}
				}
			case 0:
			case 1:
			case 2:
				base.FilterManager.RebuildFilter();
				return;
			}
			num = 1;
		}
	}

	private void ႨႣ(object P_0, EventArgs P_1)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				num = (base.FilterApplySoon ? 1 : (ⴃႤ[554] - 10976));
				break;
			case 1:
				if (!DgvFilterHost.ႥႥ((Control)this, 828, '\u0362'))
				{
					num = 2;
					break;
				}
				base.Active = true;
				FilterExpressionBuild();
				return;
			case 2:
			case 3:
				return;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? 5 : 6);
				continue;
			case 6:
				num = ((base.Ⴄ == null) ? (ⴗ[135] - 48376) : 0);
				continue;
			case 0:
			case 2:
				base.Ⴄ.Dispose();
				break;
			case 5:
				break;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void ႨႨ()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
			{
				Ⴅ = new TextBox();
				ListControl listControl = new ComboBox();
				Ⴓ.Ⴃ = listControl as ComboBox;
				num = 12;
				break;
			}
			case 12:
				AutoUpdater.Ⴜ((Control)this, 897, 'Λ');
				StringConstants.Ⴓ((Control)Ⴅ, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, 'ɇ', 585);
				goto case 6;
			case 6:
				num = 5;
				break;
			case 5:
				PrecisionTimer.Ⴗ((Control)Ⴅ, new Point(74, 3), 'ǭ', (short)453);
				LogFile.Ⴀ((Control)Ⴅ, UtilsString.Ⴐ(null, 7, 192631488), (short)647, (short)648);
				num = 7;
				break;
			case 7:
				ServerIoCfg.ႤႰ((Control)Ⴅ, new Size(87, 20), 'ˆ', (short)743);
				ObjectCopierExt.Ⴅ((Control)Ⴅ, 1, (short)512, 'Ȱ');
				num = 3;
				break;
			case 3:
				AutoUpdater.ႨႭ((ListControl)Ⴓ.Ⴃ, true, '\u0315', '\u0314');
				PrecisionTimer.Ⴗ((Control)Ⴓ.Ⴃ, new Point(13, 2), '\u0016', (short)62);
				num = 13;
				break;
			case 13:
				LogFile.Ⴀ((Control)Ⴓ.Ⴃ, UtilsString.Ⴐ(null, 2, 192631375), (short)671, (short)656);
				num = 8;
				break;
			case 8:
				ServerIoCfg.ႤႰ((Control)Ⴓ.Ⴃ, new Size(55, 21), 'ʹ', (short)853);
				num = ⴃႣ[23] - 17517;
				break;
			case 9:
				ObjectCopierExt.Ⴅ((Control)Ⴓ.Ⴃ, 3, (short)117, 'E');
				UtilsIdentity.Ⴃ((ContainerControl)this, new SizeF(6f, 13f), 'ʢ', (short)711);
				num = ⴃႤ[141] - 20927;
				break;
			case 1:
				base.AutoScaleMode = AutoScaleMode.Font;
				BackColor = Color.Transparent;
				base.Controls.Add(Ⴓ.Ⴃ);
				num = 0;
				break;
			case 0:
			case 2:
				base.Controls.Add(Ⴅ);
				base.Name = ႣႼ.Ⴜ(8, 365387218, 4);
				num = 10;
				break;
			case 10:
			case 11:
				base.Size = new Size(173, 28);
				ResumeLayout(performLayout: false);
				PerformLayout();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static DgvTextBoxColumnFilter()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal new static ComboBox.ObjectCollection Ⴄ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : ComboBox
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = default(object);
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
					num2 = ⴃႣ[72] - 41155;
					continue;
				case 9:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 70) ^ num) switch
					{
						0 => 5, 
						_ => 7, 
					};
					continue;
				case 7:
					obj = null;
					num2 = 1;
					continue;
				case 5:
				case 11:
					obj = P_0.Items;
					num2 = ⴗ[76] - 31068;
					continue;
				case 1:
				case 2:
					num++;
					goto case 10;
				case 10:
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 6 : 0);
					continue;
				case 0:
					num2 = 8;
					continue;
				case 6:
					return obj as ComboBox.ObjectCollection;
				case 4:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal new static string Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string where _0021_00211 : WebClient
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		IConvertible convertible = default(IConvertible);
		int num3 = default(int);
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
					num2 = ⴃႤ[402] - 56113;
					continue;
				case 0:
				case 11:
					break;
				case 7:
					num2 = (((P_3 ^ P_2) - 83) ^ num) switch
					{
						0 => 9, 
						_ => 2, 
					};
					continue;
				case 2:
					convertible = null;
					num2 = ⴃႤ[412] - 27505;
					continue;
				case 9:
					convertible = P_0.DownloadString(P_1);
					num2 = 4;
					continue;
				case 4:
				case 8:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 6;
					continue;
				case 6:
					num2 = ((num3 % 2 == 0) ? 1 : (ⴃႭ[98] - 39553));
					continue;
				case 1:
					return (string)convertible;
				case 5:
				case 10:
					num2 = ⴃႭ[260] - 31173;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Color Ⴐ(int P_0, char P_1)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		Color result = default(Color);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[192] - 7329;
					continue;
				case 6:
					break;
				case 2:
					num2 = (((P_0 ^ P_1) - 106) ^ num) switch
					{
						0 => ⴀ[38] - 40044, 
						_ => 3, 
					};
					continue;
				case 3:
					result = default(Color);
					num2 = ⴗ[71] - 6957;
					continue;
				case 7:
					result = Color.Transparent;
					num2 = 9;
					continue;
				case 9:
					num++;
					num3 = 3080;
					goto case 8;
				case 8:
				{
					int num4 = 259;
					num2 = ((770 < num3 / 4 - num4) ? 2 : 0);
					continue;
				}
				case 0:
				case 5:
					return result;
				case 1:
				case 10:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : WwvSpot where _0021_00211 : string
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 5;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 2;
				break;
			case 2:
				num = (((P_3 ^ P_2) - 11) ^ num3) switch
				{
					0 => 6, 
					_ => 9, 
				};
				break;
			case 9:
				num = ⴐ[307] - 61710;
				break;
			case 1:
			case 6:
				P_0.A = P_1;
				goto case 7;
			case 7:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 4;
				break;
			case 4:
			case 8:
				num = ((num2 % 2 != 0) ? (ⴗ[26] - 58714) : (ⴗ[8] - 15538));
				break;
			case 0:
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal new static void Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : OnIoClientRxEventHandler where _0021_00211 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 1;
				break;
			case 1:
				num = (((P_2 ^ P_3) - 56) ^ num2) switch
				{
					0 => ⴗ[59] - 8069, 
					_ => 9, 
				};
				break;
			case 9:
				num = ⴃႭ[56] - 15459;
				break;
			case 3:
				P_0(P_1);
				goto case 0;
			case 0:
			case 2:
			case 8:
			{
				num2++;
				int num3 = 78;
				int num4 = 762;
				num = ((6096 > num4 - num3 * 8) ? 7 : 6);
				break;
			}
			case 4:
			case 6:
				num = ⴗ[42] - 37005;
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ<_0021_00210>(ref DateTime P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		IEquatable<string> equatable = default(IEquatable<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[74] - 30229;
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
				case 8:
					DxCfg.Ⴗ[77] = (char)((DxCfg.Ⴗ[77] * P_3) & 0xAB);
					num2 = (((P_2 ^ P_3) - 67) ^ num) switch
					{
						0 => ⴃႤ[497] - 28056, 
						_ => 1, 
					};
					continue;
				case 1:
					equatable = null;
					num2 = 7;
					continue;
				case 4:
					equatable = P_0.ToString(P_1);
					num2 = 7;
					continue;
				case 7:
				case 11:
					num++;
					goto case 3;
				case 3:
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					num2 = 6;
					continue;
				case 0:
				case 6:
					num2 = ((num3 % 2 != 0) ? (ⴃႭ[132] - 40689) : (ⴃႭ[212] - 8906));
					continue;
				case 2:
					return (string)equatable;
				case 5:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : DataGridView where _0021_00211 : DataGridViewCellMouseEventHandler
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_2 ^ P_3) - 23) ^ num2) switch
				{
					0 => ⴃႤ[187] - 23460, 
					_ => 5, 
				};
				break;
			case 5:
				num = 0;
				break;
			case 2:
				P_0.CellMouseClick -= P_1;
				goto case 0;
			case 0:
			case 7:
			{
				num2++;
				int num3 = 6;
				int num4 = 362;
				num = ((2172 > num4 - num3 * 6) ? 1 : 6);
				break;
			}
			case 3:
			case 6:
				num = 4;
				break;
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႤ<_0021_00210>(_0021_00210 P_0, ToolStripGripStyle P_1, char P_2, char P_3) where _0021_00210 : ToolStrip
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				break;
			case 8:
				num = (((P_3 ^ P_2) - 125) ^ num2) switch
				{
					0 => ⴗ[134] - 54689, 
					_ => 6, 
				};
				break;
			case 6:
				num = ⴃႣ[80] - 5660;
				break;
			case 5:
				P_0.GripStyle = P_1;
				goto case 2;
			case 2:
				num2++;
				DataGridViewColumnSelector.Ⴐ[521] = (char)((DataGridViewColumnSelector.Ⴐ[521] | DxCfg.Ⴗ[129]) & 0x2A);
				num = (((P_3 * P_3 + P_3) % 2 != 0) ? 1 : (ⴃႭ[32] - 53235));
				break;
			case 1:
			case 7:
				num = 8;
				break;
			case 0:
			case 3:
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႷ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, int P_3) where _0021_00210 : CheckedListBox
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀ[343] - 36636;
				continue;
			case 4:
				num = (((P_3 ^ P_2) - 76) ^ num2) switch
				{
					0 => 2, 
					_ => 3, 
				};
				continue;
			case 3:
				num = ⴐ[36] - 7448;
				continue;
			case 2:
				P_0.CheckOnClick = P_1;
				goto case 0;
			case 0:
			case 5:
			case 6:
				num2++;
				break;
			case 1:
				break;
			case 8:
				return;
			}
			int num3 = 1336;
			int num4 = 620;
			num = ((668 < num3 / 2 - num4) ? 4 : 8);
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႠ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, char P_3) where _0021_00210 : DxSpot where _0021_00211 : string
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				continue;
			case 0:
				num = (((P_2 ^ P_3) - 115) ^ num2) switch
				{
					0 => ⴀ[250] - 26017, 
					_ => 8, 
				};
				continue;
			case 8:
				num = ⴀ[394] - 48404;
				continue;
			case 1:
			case 2:
				P_0.Comment = P_1;
				break;
			case 6:
				break;
			case 3:
			case 5:
				return;
			}
			num2++;
			int num3 = 1014;
			int num4 = 337;
			num = ((507 < num3 / 2 - num4) ? (ⴐ[308] - 49959) : 5);
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႰ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : ItemCheckEventHandler where _0021_00211 : CheckedListBox
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 0;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴃႣ[119] - 27087;
				break;
			case 1:
			case 6:
				num = (((P_3 ^ P_2) - 29) ^ num3) switch
				{
					0 => 4, 
					_ => 2, 
				};
				break;
			case 2:
				num = 8;
				break;
			case 4:
				P_0.ItemCheck += P_1;
				goto case 8;
			case 8:
				num3++;
				num2 = P_2 * P_2;
				goto case 7;
			case 7:
			case 9:
				num2 = P_2 + num2;
				num = 3;
				break;
			case 3:
				num = ((num2 % 2 != 0) ? 1 : 5);
				break;
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႭ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : DxSpot
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႤ[341] - 42368;
				break;
			case 10:
				num = (((P_2 ^ P_3) - 96) ^ num2) switch
				{
					0 => 2, 
					1 => ⴃႭ[158] - 9172, 
					_ => ⴃႣ[25] - 54623, 
				};
				break;
			case 3:
				num = ⴃႣ[119] - 27083;
				break;
			case 2:
				P_0.SpotterNode = P_1;
				num = 5;
				break;
			case 0:
			case 6:
				P_0.County = P_1;
				goto case 5;
			case 5:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴃႭ[182] - 27095) : 8);
				break;
			case 8:
			case 9:
				num = 10;
				break;
			case 7:
				return;
			}
		}
	}
}
