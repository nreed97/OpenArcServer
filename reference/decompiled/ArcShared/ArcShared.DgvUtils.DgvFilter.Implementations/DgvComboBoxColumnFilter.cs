using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Pcxx;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils.DgvFilter.Extensions;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using ArcShared.MaintenanceUpdates;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.DgvUtils.DgvFilter.Implementations;

public class DgvComboBoxColumnFilter : DgvBaseColumnFilter
{
	private ComboBox Ⴅ;

	private new LegalCfg.Ⴓ Ⴀ = new LegalCfg.Ⴓ();

	public ComboBox ComboBoxOperator
	{
		get
		{
			ComboBox ⴅ = Ⴅ;
			DxCfg.Ⴗ[87] = (char)((DxCfg.Ⴗ[87] * DxCfg.Ⴗ[145]) & 0x4B);
			return ⴅ;
		}
	}

	public ComboBox ComboBoxValue
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			return Ⴀ.Ⴈ;
		}
	}

	public DgvComboBoxColumnFilter()
	{
		ႣႣ();
		DgvFilterManager.Ⴍ<EventHandler, ListControl>(Ⴅ, ႣႷ, 'Ư', 468);
		Ⴀ.Ⴈ.SelectedValueChanged += ႣႷ;
	}

	protected override void OnFilterInitializing(object sender, CancelEventArgs e)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				base.OnFilterInitializing(sender, e);
				break;
			case 2:
				break;
			case 3:
			case 4:
				return;
			}
			if (!StationCfg.Ⴃ(e, 46, 60))
			{
				break;
			}
			num = 3;
		}
		while (true)
		{
			ComboBox.ObjectCollection objectCollection = DgvTextBoxColumnFilter.Ⴄ(Ⴅ, 'ƌ', 458);
			Array array = new object[4];
			((object[])array)[0] = ႣႼ.ႥႭ(null, 624736248, 2, null);
			(array as object[])[1] = ArcLogInRqstExt.Ⴗ(1706507136, 7, 3);
			(array as object[])[2] = ႣႼ.Ⴜ(3, 365387203, 30);
			((object[])array)[3] = DownloadUrl2.Ⴅ(20, null, 2018867781, 4);
			objectCollection.AddRange(array as object[]);
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					return;
				case 10:
					break;
				case 8:
					PcxxServerClient.Ⴃ((ListControl)Ⴅ, 0, (short)413, 'ǜ');
					num2 = ((base.DataGridViewColumn is DataGridViewComboBoxColumn) ? (ⴃႤ[303] - 32034) : 0);
					continue;
				case 1:
				case 4:
					AnnWxSpotExt.Ⴓ((ListControl)Ⴀ.Ⴈ, ႣႼ.ႰႰ((DataGridViewComboBoxColumn)base.DataGridViewColumn, '\u0306', 820), 'Ϩ', 'ϕ');
					num2 = ⴃႣ[184] - 34375;
					continue;
				case 5:
				case 6:
					AnnWxSpotExt.Ⴓ((ListControl)Ⴀ.Ⴈ, WwvSpotExt.Ⴈ((DataGridViewComboBoxColumn)base.DataGridViewColumn, 587, 554), 'Ñ', 'ï');
					num2 = ⴃႤ[320] - 20176;
					continue;
				case 9:
					DxAtlasData.Ⴍ(Ⴀ.Ⴈ, DirectoryMonitor.Ⴜ((DataGridViewComboBoxColumn)base.DataGridViewColumn, '\u0363', 895), 99, '\u0015');
					goto case 3;
				case 3:
					num2 = 7;
					continue;
				case 0:
					Ⴀ.Ⴈ.ValueMember = base.DataGridViewColumn.DataPropertyName;
					Ⴀ.Ⴈ.DisplayMember = base.DataGridViewColumn.DataPropertyName;
					num2 = 11;
					continue;
				case 11:
					RefreshValues();
					goto case 7;
				case 7:
					base.FilterHost.RegisterComboBox(Ⴅ);
					base.FilterHost.RegisterComboBox(Ⴀ.Ⴈ);
					return;
				}
				break;
			}
		}
	}

	public void RefreshValues()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 6;
		ISupportInitializeNotification supportInitializeNotification = default(ISupportInitializeNotification);
		while (true)
		{
			switch (num)
			{
			default:
				num = ((base.DataGridViewColumn is DataGridViewComboBoxColumn) ? (ⴀ[211] - 35371) : 0);
				break;
			case 0:
			case 7:
			{
				DataView boundDataView = base.BoundDataView;
				object obj = new string[1];
				((string[])obj)[0] = UtilsSql.Ⴍ(base.DataGridViewColumn, 887, 836);
				supportInitializeNotification = DxSpotExt.Ⴄ(boundDataView, true, obj as string[], 769, 785);
				goto case 5;
			}
			case 5:
				num = ⴃႣ[176] - 11045;
				break;
			case 1:
				ArcLogInRespExt.Ⴗ((DataTable)supportInitializeNotification, 'ʙ', '\u02d5').Sort = base.DataGridViewColumn.DataPropertyName;
				num = 2;
				break;
			case 2:
			case 4:
				Ⴀ.Ⴈ.DataSource = supportInitializeNotification as DataTable;
				return;
			case 3:
				return;
			}
		}
	}

	protected override void OnFilterExpressionBuilding(object sender, CancelEventArgs e)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 4;
		object obj2 = default(object);
		IEnumerable enumerable2 = default(IEnumerable);
		IEnumerable<char> enumerable3 = default(IEnumerable<char>);
		object obj5 = default(object);
		object obj4 = default(object);
		Array array = default(Array);
		while (true)
		{
			switch (num)
			{
			default:
				base.OnFilterExpressionBuilding(sender, e);
				if (StationCfg.Ⴃ(e, 661, 647))
				{
					break;
				}
				while (true)
				{
					IEnumerable<char> enumerable = string.Empty;
					object obj = base.OriginalDataGridViewColumnHeaderText;
					int num2 = ((!FrmUpdating.ႠႥ(FrmUpdateAvailable.ႷႷ((Control)Ⴅ, 'Ľ', 350), ႣႼ.Ⴜ(2, 365387202, 17), 917, 937)) ? (ⴐ[225] - 26604) : (ⴃႭ[10] - 46800));
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 1:
							break;
						case 3:
							enumerable = DgvBaseColumnFilter.GetNullCondition(UtilsSql.Ⴍ(base.DataGridViewColumn, 366, 349));
							num2 = ⴃႤ[438] - 63509;
							continue;
						case 10:
							num2 = ((!FrmUpdating.ႠႥ(FrmUpdateAvailable.ႷႷ((Control)Ⴅ, 'Ϭ', 911), DownloadUrl2.Ⴅ(20, null, 2018867776, 1), 65, 125)) ? 8 : (ⴃႭ[10] - 46774));
							continue;
						case 29:
							enumerable = DgvBaseColumnFilter.GetNotNullCondition(UtilsSql.Ⴍ(base.DataGridViewColumn, 862, 877));
							num2 = 8;
							continue;
						case 8:
							num2 = ((!ColumnFilterEventArgs.Ⴀ(enumerable as string, string.Empty, 967, 904)) ? 15 : (ⴐ[334] - 25387));
							continue;
						case 24:
							base.FilterExpression = (string)enumerable;
							base.FilterCaption = UtilsEmail.Ⴀ((string)obj, DownloadUrl2.Ⴅ(20, null, 2018867784, 2), FrmUpdateAvailable.ႷႷ((Control)Ⴅ, '\u032d', 846), 525, 603);
							num2 = ⴀ[203] - 51123;
							continue;
						case 14:
						case 18:
							base.FilterManager.RebuildFilter();
							return;
						case 15:
							obj2 = DgvFreqRangeColumnFilter.Ⴈ((ListControl)Ⴀ.Ⴈ, 330, (short)327);
							enumerable2 = string.Empty;
							num2 = ⴃႣ[228] - 10033;
							continue;
						case 25:
							num2 = ((!ObjectCopierExt.Ⴈ(base.ColumnDataType, typeof(string), 'ʻ', 'ʟ')) ? (ⴃႭ[95] - 32053) : (ⴀ[51] - 42978));
							continue;
						case 26:
							enumerable3 = DgvBaseColumnFilter.StringEscape(UtilsString.Ⴍ(obj2, 'Ƹ', 426));
							obj5 = new string[6];
							num2 = ⴀ[166] - 10200;
							continue;
						case 21:
							((string[])obj5)[0] = UtilsSql.Ⴍ(base.DataGridViewColumn, 394, 441);
							num2 = 23;
							continue;
						case 6:
						case 23:
							((string[])obj5)[1] = ႣႼ.Ⴜ(7, 365387201, 26);
							((string[])obj5)[2] = FrmUpdateAvailable.ႷႷ((Control)Ⴅ, '\u031b', 888);
							num2 = 12;
							continue;
						case 12:
							(obj5 as string[])[3] = TelnetServerClient.Ⴄ(1945322700, 'I', 4);
							(obj5 as string[])[4] = enumerable3 as string;
							num2 = 2;
							continue;
						case 2:
							(obj5 as string[])[5] = TelnetServerClient.Ⴄ(1945322698, '\u0097', 2);
							enumerable = DgvDateColumnFilter.Ⴀ((string[])obj5, 'λ', 'Θ');
							num2 = 19;
							continue;
						case 19:
						{
							IComparable comparable = (string)obj;
							obj4 = new string[5];
							((string[])obj4)[0] = comparable as string;
							num2 = ⴃႭ[197] - 28502;
							continue;
						}
						case 9:
							(obj4 as string[])[1] = UtilsString.Ⴐ(null, 5, 192631502);
							((string[])obj4)[2] = FrmUpdateAvailable.ႷႷ((Control)Ⴅ, '\u0319', 890);
							num2 = ⴀ[110] - 48910;
							continue;
						case 30:
							(obj4 as string[])[3] = ႣႼ.Ⴜ(3, 365387205, 10);
							(obj4 as string[])[4] = FrmUpdateAvailable.ႷႷ((Control)Ⴀ.Ⴈ, 'Ǯ', 397);
							num2 = 22;
							continue;
						case 11:
						case 22:
							obj = DgvDateColumnFilter.Ⴀ(obj4 as string[], 'Á', 'â');
							num2 = 27;
							continue;
						case 5:
							enumerable2 = DgvBaseColumnFilter.FormatValue(obj2, base.ColumnDataType);
							num2 = ((!ColumnFilterEventArgs.Ⴀ(enumerable2 as string, string.Empty, 217, 150)) ? 27 : 0);
							continue;
						case 0:
							enumerable = UtilsSql.Ⴍ(base.DataGridViewColumn, 901, 950) + ႣႼ.Ⴜ(5, 365387203, 30) + Ⴅ.Text + (enumerable2 as string);
							num2 = 4;
							continue;
						case 4:
						{
							object obj3 = (string)obj;
							array = new string[5];
							(array as string[])[0] = (string)obj3;
							num2 = 28;
							continue;
						}
						case 28:
							(array as string[])[1] = UtilsString.Ⴐ(null, 6, 192631501);
							((string[])array)[2] = Ⴅ.Text;
							num2 = ⴃႤ[532] - 51853;
							continue;
						case 13:
							((string[])array)[3] = ႣႼ.Ⴜ(5, 365387203, 4);
							(array as string[])[4] = Ⴀ.Ⴈ.Text;
							num2 = 20;
							continue;
						case 20:
							obj = string.Concat((string[])array);
							num2 = 27;
							continue;
						case 27:
							num2 = ((!((string)enumerable != string.Empty)) ? (ⴃႤ[305] - 20864) : 16);
							continue;
						case 16:
							base.FilterExpression = enumerable as string;
							base.FilterCaption = obj as string;
							base.FilterManager.RebuildFilter();
							num2 = 17;
							continue;
						case 17:
							return;
						}
						break;
					}
				}
			case 2:
			case 3:
				base.FilterManager.RebuildFilter();
				return;
			case 1:
				return;
			}
			num = ⴃႤ[111] - 29457;
		}
	}

	private void ႣႷ(object P_0, EventArgs P_1)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
			{
				int num3;
				if (base.FilterApplySoon)
				{
					char num2 = ⴃႭ[103];
					WxCfg.ႣႭ[121] = (char)((WxCfg.ႣႭ[121] ^ WxCfg.ႣႭ[7]) & 0x6F);
					num3 = num2 - 40154;
				}
				else
				{
					num3 = ⴃႤ[232] - 11095;
				}
				num = num3;
				break;
			}
			case 0:
			case 1:
			case 4:
				if (!DgvFilterHost.ႥႥ((Control)this, 791, '\u0349'))
				{
					num = 3;
					break;
				}
				base.Active = true;
				FilterExpressionBuild();
				return;
			case 3:
			case 5:
				return;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				num = (disposing ? 1 : 0);
				continue;
			case 1:
				num = ((Ⴀ.Ⴃ != null) ? 2 : 0);
				continue;
			case 2:
			case 6:
				Ⴀ.Ⴃ.Dispose();
				break;
			case 0:
			case 5:
				break;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void ႣႣ()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 12;
		while (true)
		{
			switch (num)
			{
			default:
			{
				Ⴅ = new ComboBox();
				object obj = new ComboBox();
				Ⴀ.Ⴈ = obj as ComboBox;
				num = ⴃႤ[279] - 51471;
				break;
			}
			case 2:
				AutoUpdater.Ⴜ((Control)this, 761, 'ˣ');
				AutoUpdater.ႨႭ((ListControl)Ⴅ, true, 'ʞ', 'ʟ');
				num = 0;
				break;
			case 0:
				PrecisionTimer.Ⴗ((Control)Ⴅ, new Point(3, 3), 'ƽ', (short)405);
				LogFile.Ⴀ((Control)Ⴅ, UtilsString.Ⴐ(null, 0, 192631495), (short)948, (short)955);
				num = 11;
				break;
			case 11:
				ServerIoCfg.ႤႰ((Control)Ⴅ, new Size(49, 21), 'ʇ', (short)678);
				ObjectCopierExt.Ⴅ((Control)Ⴅ, 0, (short)259, 'ĳ');
				num = ⴃႣ[196] - 52690;
				break;
			case 10:
				StringConstants.Ⴓ((Control)Ⴀ.Ⴈ, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right, '\u0307', 777);
				AutoUpdater.ႨႭ((ListControl)Ⴀ.Ⴈ, true, 'Ę', 'ę');
				num = 5;
				break;
			case 5:
				PrecisionTimer.Ⴗ((Control)Ⴀ.Ⴈ, new Point(58, 3), 'Ǵ', (short)476);
				num = 6;
				break;
			case 6:
				LogFile.Ⴀ((Control)Ⴀ.Ⴈ, UtilsString.Ⴐ(null, 3, 192631374), (short)704, (short)719);
				num = 3;
				break;
			case 3:
				ServerIoCfg.ႤႰ((Control)Ⴀ.Ⴈ, new Size(215, 21), 'Ƥ', (short)389);
				num = 4;
				break;
			case 4:
				ObjectCopierExt.Ⴅ((Control)Ⴀ.Ⴈ, 1, (short)853, '\u0365');
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				num = ⴗ[102] - 41102;
				break;
			case 8:
			case 13:
				base.AutoScaleMode = AutoScaleMode.Font;
				BackColor = Color.Transparent;
				base.Controls.Add(Ⴀ.Ⴈ);
				num = 9;
				break;
			case 9:
				base.Controls.Add(Ⴅ);
				base.Name = ArcLogInRqstExt.Ⴗ(1706506895, 19, 5);
				num = 1;
				break;
			case 1:
			case 7:
				base.Size = new Size(276, 30);
				ResumeLayout(performLayout: false);
				return;
			case 14:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static DgvComboBoxColumnFilter()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211, _0021_00212>(_0021_00210 P_0, _0021_00212 P_1, _0021_00211 P_2, char P_3, char P_4) where _0021_00210 : XmlSerializerNamespaces where _0021_00211 : string where _0021_00212 : string
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 5;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴃႣ[164] - 37175;
				break;
			case 2:
				num = (((P_4 ^ P_3) - 85) ^ num3) switch
				{
					0 => ⴀ[230] - 37246, 
					_ => ⴃႣ[184] - 34380, 
				};
				break;
			case 0:
				num = 3;
				break;
			case 9:
				P_0.Add(P_1, P_2);
				goto case 3;
			case 3:
				num3++;
				goto case 6;
			case 6:
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = ⴃႤ[344] - 26233;
				break;
			case 1:
				num = ((num2 % 2 != 0) ? (ⴃႣ[106] - 63636) : 4);
				break;
			case 4:
			case 7:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal new static string Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : TextReader
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		IComparable<string> comparable = default(IComparable<string>);
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
					num2 = ⴃႭ[81] - 32195;
					continue;
				case 2:
					break;
				case 5:
				case 9:
					num2 = (((P_1 ^ P_2) - 66) ^ num) switch
					{
						0 => 4, 
						_ => 11, 
					};
					continue;
				case 11:
					comparable = null;
					num2 = 7;
					continue;
				case 1:
				case 4:
					comparable = P_0.ReadToEnd();
					num2 = 7;
					continue;
				case 7:
				case 8:
				{
					num++;
					int num3 = 529;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? (ⴃႭ[36] - 6373) : 0);
					continue;
				}
				case 0:
					num2 = 9;
					continue;
				case 6:
					return (string)comparable;
				case 10:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static double Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : Form
	{
		char[] ⴗ = DxCfg.Ⴗ;
		double result = default(double);
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
					num2 = 7;
					continue;
				case 7:
					break;
				case 2:
				case 11:
					num2 = (((P_1 ^ P_2) - 66) ^ num) switch
					{
						0 => 8, 
						_ => 6, 
					};
					continue;
				case 6:
					result = 1.3949426067259487;
					goto case 3;
				case 3:
					num2 = 5;
					continue;
				case 8:
					result = P_0.Opacity;
					num2 = 5;
					continue;
				case 5:
				{
					num++;
					int num3 = 1319;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? 9 : (ⴗ[157] - 44223));
					continue;
				}
				case 0:
					num2 = 2;
					continue;
				case 4:
				case 9:
					return result;
				case 1:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal new static DataTableCollection Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DataSet
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		InternalDataCollectionBase internalDataCollectionBase = default(InternalDataCollectionBase);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[408] - 38789;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[256] - 37305;
					continue;
				case 8:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 38) ^ num) switch
					{
						0 => 9, 
						_ => ⴃႭ[101] - 25683, 
					};
					continue;
				case 7:
					internalDataCollectionBase = null;
					num2 = 6;
					continue;
				case 9:
					internalDataCollectionBase = P_0.Tables;
					num2 = 6;
					continue;
				case 1:
				case 6:
				case 10:
				{
					num++;
					int num3 = 77;
					int num4 = 362;
					num2 = ((1810 > num4 - num3 * 5) ? (ⴃႭ[100] - 29783) : 11);
					continue;
				}
				case 11:
					num2 = 4;
					continue;
				case 2:
				case 3:
					return internalDataCollectionBase as DataTableCollection;
				case 0:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}
}
