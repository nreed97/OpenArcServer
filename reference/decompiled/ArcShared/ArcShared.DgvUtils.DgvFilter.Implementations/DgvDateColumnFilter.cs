using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using ArcInterfaces.Arcx;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Pcxx;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using ArcShared.Forms;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.DgvUtils.DgvFilter.Implementations;

public class DgvDateColumnFilter : DgvBaseColumnFilter
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴅ
	{
		internal PictureBox Ⴈ;
	}

	[StructLayout(LayoutKind.Auto)]
	internal new struct Ⴃ
	{
		internal Label Ⴈ;

		internal Timer Ⴃ;

		internal double Ⴐ;

		internal double Ⴄ;

		internal double Ⴓ;

		internal Rectangle Ⴅ;

		internal double Ⴗ;

		internal DateTime Ⴍ;

		internal ArrayList Ⴀ;
	}

	private ComboBox Ⴓ;

	private new DateTimePicker Ⴄ;

	private UtilsCallsign.Ⴗ Ⴈ;

	public ComboBox ComboBoxOperator
	{
		get
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			return Ⴓ;
		}
	}

	public DateTimePicker DateTimePickerValue
	{
		get
		{
			DateTimePicker ⴄ = Ⴄ;
			TalkCfg.ႣႣ[139] = (char)((TalkCfg.ႣႣ[139] ^ TalkCfg.ႣႣ[207]) & 0xD9);
			return ⴄ;
		}
	}

	protected override void Dispose(bool disposing)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? (ⴗ[59] - 8067) : (ⴐ[403] - 62067));
				continue;
			case 6:
				num = ((Ⴈ.Ⴄ == null) ? (ⴗ[141] - 5937) : 0);
				continue;
			case 0:
			case 1:
				Ⴈ.Ⴄ.Dispose();
				break;
			case 3:
			case 5:
				break;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void ႥႷ()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴓ = new ComboBox();
				Ⴄ = new DateTimePicker();
				AutoUpdater.Ⴜ((Control)this, 607, 'Ʌ');
				num = 8;
				break;
			case 8:
				AutoUpdater.ႨႭ((ListControl)Ⴓ, true, '\u030e', '\u030f');
				PrecisionTimer.Ⴗ((Control)Ⴓ, new Point(3, 3), 'ʕ', (short)701);
				num = ⴃႭ[62] - 64033;
				break;
			case 4:
				LogFile.Ⴀ((Control)Ⴓ, TelnetServerClient.Ⴄ(1945322733, '=', 7), (short)189, (short)178);
				num = 1;
				break;
			case 1:
			case 11:
				ServerIoCfg.ႤႰ((Control)Ⴓ, new Size(49, 21), 'ǘ', (short)505);
				ObjectCopierExt.Ⴅ((Control)Ⴓ, 0, (short)686, 'ʞ');
				num = 7;
				break;
			case 7:
				UtilsCopyright.Ⴗ(Ⴄ, DateTimePickerFormat.Short, '\u02c5', 716);
				goto case 10;
			case 10:
				PrecisionTimer.Ⴗ((Control)Ⴄ, new Point(58, 3), 'ł', (short)362);
				num = 2;
				break;
			case 2:
				LogFile.Ⴀ((Control)Ⴄ, UtilsString.Ⴐ(null, 1, 192631550), (short)147, (short)156);
				num = ⴐ[98] - 35667;
				break;
			case 13:
				ServerIoCfg.ႤႰ((Control)Ⴄ, new Size(127, 20), '£', (short)130);
				ObjectCopierExt.Ⴅ((Control)Ⴄ, 1, (short)986, 'Ϫ');
				goto case 5;
			case 5:
				num = 6;
				break;
			case 6:
				UtilsIdentity.Ⴃ((ContainerControl)this, new SizeF(6f, 13f), 'f', (short)3);
				base.AutoScaleMode = AutoScaleMode.Font;
				num = 9;
				break;
			case 9:
				BackColor = Color.Transparent;
				base.Controls.Add(Ⴄ);
				base.Controls.Add(Ⴓ);
				num = 3;
				break;
			case 3:
				base.Name = DownloadUrl2.Ⴅ(14, null, 2018867883, 8);
				base.Size = new Size(194, 28);
				num = 12;
				break;
			case 12:
				ResumeLayout(performLayout: false);
				return;
			}
		}
	}

	public DgvDateColumnFilter()
	{
		ႥႷ();
		DgvFilterManager.Ⴍ<EventHandler, ListControl>(Ⴓ, ႥႳ, 'Ŷ', 269);
		Ⴄ.TextChanged += ႥႳ;
	}

	protected override void OnFilterInitializing(object sender, CancelEventArgs e)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				base.OnFilterInitializing(sender, e);
				break;
			case 2:
			case 3:
				break;
			case 1:
			case 4:
				return;
			}
			if (!StationCfg.Ⴃ(e, 612, 630))
			{
				break;
			}
			num = 1;
		}
		while (true)
		{
			ComboBox.ObjectCollection objectCollection = DgvTextBoxColumnFilter.Ⴄ(Ⴓ, '*', 108);
			Array array = new object[8];
			((object[])array)[0] = ႣႼ.ႥႭ(null, 624736249, 3, null);
			((object[])array)[1] = ArcLogInRqstExt.Ⴗ(1706507142, 1, 5);
			((object[])array)[2] = ArcLogInRqstExt.Ⴗ(1706507215, 15, 8);
			((object[])array)[3] = ႣႼ.ႥႭ(null, 624736218, 8, null);
			((object[])array)[4] = ArcLogInRqstExt.Ⴗ(1706507204, 8, 7);
			((object[])array)[5] = ႣႼ.ႥႭ(null, 624736212, 2, null);
			(array as object[])[6] = ႣႼ.Ⴜ(0, 365387200, 10);
			((object[])array)[7] = DownloadUrl2.Ⴅ(15, null, 2018867777, 0);
			objectCollection.AddRange((object[])array);
			switch (2)
			{
			default:
				/*OpCode not supported: LdMemberToken*/;
				return;
			case 5:
				return;
			case 0:
				break;
			case 2:
				PcxxServerClient.Ⴃ((ListControl)Ⴓ, 0, (short)677, 'ˤ');
				base.FilterHost.RegisterComboBox(Ⴓ);
				DataGridViewColumnSelector.Ⴐ[178] = (char)(DataGridViewColumnSelector.Ⴐ[178] & DataGridViewColumnSelector.Ⴐ[241] & 0xB4);
				return;
			}
		}
	}

	protected override void OnFilterExpressionBuilding(object sender, CancelEventArgs e)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 0;
		object value = default(object);
		IComparable comparable3 = default(IComparable);
		Array array = default(Array);
		while (true)
		{
			switch (num)
			{
			default:
				base.OnFilterExpressionBuilding(sender, e);
				goto case 2;
			case 2:
			case 3:
				if (StationCfg.Ⴃ(e, 269, 287))
				{
					break;
				}
				while (true)
				{
					ICloneable cloneable = string.Empty;
					IComparable comparable = base.OriginalDataGridViewColumnHeaderText;
					int num2 = ((!FrmUpdating.ႠႥ(FrmUpdateAvailable.ႷႷ((Control)Ⴓ, '\u02c3', 672), ႣႼ.Ⴜ(0, 365387200, 20), 813, 785)) ? 18 : 17);
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 1:
							break;
						case 17:
							cloneable = DgvBaseColumnFilter.GetNullCondition(UtilsSql.Ⴍ(base.DataGridViewColumn, 567, 516));
							num2 = ⴐ[143] - 23515;
							continue;
						case 18:
							num2 = ((!FrmUpdating.ႠႥ(FrmUpdateAvailable.ႷႷ((Control)Ⴓ, '\u0338', 859), DownloadUrl2.Ⴅ(5, null, 2018867780, 5), 446, 386)) ? 6 : 9);
							continue;
						case 9:
							cloneable = DgvBaseColumnFilter.GetNotNullCondition(UtilsSql.Ⴍ(base.DataGridViewColumn, 962, 1009));
							num2 = ⴐ[396] - 45274;
							continue;
						case 6:
							num2 = ((!ColumnFilterEventArgs.Ⴀ((string)cloneable, string.Empty, 234, 165)) ? (ⴐ[59] - 43829) : (ⴐ[8] - 32874));
							continue;
						case 0:
							base.FilterExpression = (string)cloneable;
							base.FilterCaption = UtilsEmail.Ⴀ(comparable as string, DownloadUrl2.Ⴅ(16, null, 2018867788, 6), FrmUpdateAvailable.ႷႷ((Control)Ⴓ, '>', 93), 614, 560);
							num2 = 19;
							continue;
						case 15:
						case 19:
							base.FilterManager.RebuildFilter();
							return;
						case 4:
							value = AnnWxSpotExt.Ⴗ(Ⴄ, 441, 'Ɨ');
							comparable3 = string.Empty;
							num2 = 10;
							continue;
						case 10:
							comparable3 = DgvBaseColumnFilter.FormatValue(value, base.ColumnDataType);
							num2 = ((!ColumnFilterEventArgs.Ⴀ(comparable3 as string, string.Empty, 127, 48)) ? 3 : 16);
							continue;
						case 16:
							cloneable = HelpAboutServer.Ⴗ(UtilsSql.Ⴍ(base.DataGridViewColumn, 146, 161), ႣႼ.Ⴜ(7, 365387201, 14), FrmUpdateAvailable.ႷႷ((Control)Ⴓ, 'Ϯ', 909), comparable3 as string, 125, '\u0013');
							num2 = 13;
							continue;
						case 13:
						{
							IComparable comparable2 = (string)comparable;
							array = new string[5];
							(array as string[])[0] = comparable2 as string;
							num2 = ⴀ[148] - 39176;
							continue;
						}
						case 11:
							((string[])array)[1] = UtilsString.Ⴐ(null, 2, 192631497);
							(array as string[])[2] = Ⴓ.Text;
							num2 = 5;
							continue;
						case 5:
							((string[])array)[3] = ႣႼ.Ⴜ(6, 365387200, 25);
							(array as string[])[4] = Ⴄ.Text;
							goto case 7;
						case 7:
							num2 = 12;
							continue;
						case 12:
							comparable = string.Concat(array as string[]);
							num2 = 3;
							continue;
						case 3:
						case 20:
							num2 = ((!((string)cloneable != string.Empty)) ? (ⴗ[31] - 485) : (ⴐ[382] - 29764));
							continue;
						case 8:
							base.FilterExpression = cloneable as string;
							base.FilterCaption = (string)comparable;
							base.FilterManager.RebuildFilter();
							num2 = 2;
							continue;
						case 2:
							return;
						}
						break;
					}
				}
			case 1:
			case 4:
				base.FilterManager.RebuildFilter();
				return;
			}
			num = ⴀ[145] - 39617;
		}
	}

	private void ႥႳ(object P_0, EventArgs P_1)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!base.FilterApplySoon) ? (ⴐ[497] - 8515) : (ⴗ[102] - 41113));
				break;
			case 0:
			case 2:
			case 4:
				if (!DgvFilterHost.ႥႥ((Control)this, 745, 'ʷ'))
				{
					num = 1;
					break;
				}
				base.Active = true;
				FilterExpressionBuild();
				return;
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static DgvDateColumnFilter()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211, _0021_00212>(_0021_00212 P_0, _0021_00211 P_1, _0021_00210 P_2, short P_3, char P_4) where _0021_00211 : string where _0021_00212 : AppDomain
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 7;
				break;
			case 7:
				UtilsNumeric.Ⴀ[415] = (char)(UtilsNumeric.Ⴀ[415] & P_3 & 0xA2);
				num = (((P_4 ^ P_3) - 11) ^ num2) switch
				{
					0 => 2, 
					_ => 4, 
				};
				break;
			case 4:
				num = ⴗ[30] - 17779;
				break;
			case 2:
				P_0.SetData(P_1, P_2);
				goto case 1;
			case 1:
			case 5:
			case 8:
			{
				num2++;
				int num3 = 145;
				int num4 = 293;
				num = ((586 <= num4 - num3 * 2) ? 6 : 0);
				break;
			}
			case 6:
				num = 7;
				break;
			case 0:
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴀ(string[] P_0, char P_1, char P_2)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		ICloneable cloneable = default(ICloneable);
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
					num2 = ⴗ[28] - 12121;
					continue;
				case 3:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 35) ^ num) switch
					{
						0 => ⴗ[93] - 707, 
						_ => 7, 
					};
					continue;
				case 7:
					cloneable = null;
					num2 = ⴃႣ[103] - 47726;
					continue;
				case 2:
				case 10:
					cloneable = string.Concat(P_0);
					num2 = ⴃႤ[123] - 21535;
					continue;
				case 4:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					goto case 8;
				case 8:
					num2 = 1;
					continue;
				case 1:
					num2 = ((num3 % 2 == 0) ? (ⴀ[298] - 697) : 0);
					continue;
				case 11:
					return cloneable as string;
				case 5:
					num2 = ⴃႣ[214] - 56066;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, char P_3) where _0021_00210 : Timer
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 3;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 1;
				break;
			case 1:
				num = (((P_2 ^ P_3) - 30) ^ num3) switch
				{
					0 => ⴃႭ[109] - 6062, 
					_ => ⴀ[250] - 26014, 
				};
				break;
			case 2:
			case 5:
				num = ⴗ[141] - 5934;
				break;
			case 0:
			case 4:
				P_0.Interval = P_1;
				goto case 8;
			case 8:
			case 9:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = ⴃႣ[96] - 36627;
				break;
			case 7:
				num = ((num2 % 2 != 0) ? 1 : 6);
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal new static string Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : ArcLogInResp
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[134] - 27354;
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
					num2 = (((P_1 ^ P_2) - 87) ^ num) switch
					{
						0 => 2, 
						_ => ⴀ[114] - 58316, 
					};
					continue;
				case 4:
					obj = null;
					goto case 8;
				case 8:
					num2 = ⴗ[136] - 24117;
					continue;
				case 2:
					obj = P_0.Message;
					num2 = ⴃႭ[43] - 34343;
					continue;
				case 7:
				{
					num++;
					int num3 = 85;
					int num4 = 174;
					num2 = ((348 > num4 - num3 * 2) ? (ⴃႭ[97] - 35150) : 0);
					continue;
				}
				case 0:
					num2 = 9;
					continue;
				case 1:
				case 5:
				case 6:
					return (string)obj;
				case 11:
					num2 = ⴀ[281] - 58258;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte Ⴜ(ref Color P_0, char P_1, int P_2)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		byte result = default(byte);
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
					num2 = ⴀ[182] - 17967;
					continue;
				case 1:
				case 4:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 11) ^ num) switch
					{
						0 => 0, 
						_ => 10, 
					};
					continue;
				case 10:
					result = 5;
					num2 = 5;
					continue;
				case 0:
				case 6:
					result = P_0.R;
					num2 = ⴀ[329] - 29353;
					continue;
				case 5:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = ⴃႣ[49] - 50434;
					continue;
				case 7:
					num2 = ((num3 % 2 != 0) ? 3 : (ⴀ[387] - 45961));
					continue;
				case 11:
					return result;
				case 2:
				case 8:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႳႰ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : Control
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴗ[80] - 32456;
				break;
			case 5:
				num = (((P_2 ^ P_1) - 69) ^ num2) switch
				{
					0 => 1, 
					_ => ⴃႭ[8] - 30696, 
				};
				break;
			case 2:
				num = 8;
				break;
			case 1:
			case 9:
				P_0.SuspendLayout();
				goto case 8;
			case 8:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 3 : 7);
				break;
			case 4:
			case 7:
				num = 5;
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႳႳ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		int num4 = default(int);
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
					num2 = ⴗ[155] - 49740;
					continue;
				case 7:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 87) ^ num) switch
					{
						0 => ⴐ[558] - 19589, 
						_ => 2, 
					};
					continue;
				case 2:
					enumerable = null;
					goto case 0;
				case 0:
					num2 = 1;
					continue;
				case 8:
					enumerable = Path.GetFileName(P_0);
					num2 = 1;
					continue;
				case 1:
				{
					num++;
					num4 = 1844;
					int num5 = num4;
					num3 = num5 * num5;
					num2 = 6;
					continue;
				}
				case 4:
				case 6:
					num3 = num4 + num3;
					num2 = ((num3 % 2 != 0) ? (ⴗ[45] - 54530) : 11);
					continue;
				case 11:
					return (string)enumerable;
				case 3:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}
}
