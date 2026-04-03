using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.Constants;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Extensions;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using ArcShared.Forms;
using ArcShared.MaintenanceUpdates;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.SplashScreen;

public class SplashScreen : Form
{
	private sealed class ႰႨ
	{
		public Form Ⴓ;

		public void Ⴀ()
		{
			UtilsCallsign.Ⴈ((Form)Ⴗ, Ⴓ, 422, 'Ǌ');
		}

		[SecuritySafeCritical]
		static ႰႨ()
		{
			UtilsIdentity.Ⴐ();
		}
	}

	private sealed class ႰႭ
	{
		public SplashScreen Ⴀ;

		public string Ⴀ;

		public void Ⴅ()
		{
			this.Ⴀ.ႨႳ(Ⴀ);
		}

		[SecuritySafeCritical]
		static ႰႭ()
		{
			UtilsIdentity.Ⴐ();
		}
	}

	private sealed class ႰႣ
	{
		public SplashScreen Ⴀ;

		public Form Ⴃ;

		public void Ⴀ()
		{
			this.Ⴀ.SetOwnerCrossThread(Ⴃ);
		}

		[SecuritySafeCritical]
		static ႰႣ()
		{
			UtilsIdentity.Ⴐ();
		}
	}

	private IContainer Ⴄ;

	private Panel Ⴅ;

	private Label Ⴐ;

	private static SplashScreen Ⴗ;

	private static Thread Ⴈ;

	private static string Ⴜ;

	private double ႳႠ;

	private bool ႳႰ;

	private bool ႳႨ;

	private int ႳႭ;

	private int ႳႣ;

	private ArrayList ႳႼ;

	private static bool ႥႳ;

	private DgvDateColumnFilter.Ⴃ ႣႷ;

	public static SplashScreen SplashForm
	{
		get
		{
			SplashScreen ⴗ = Ⴗ;
			TalkCfg.ႣႣ[137] = (char)(TalkCfg.ႣႣ[137] & TalkCfg.ႣႣ[169] & 0x2C);
			return ⴗ;
		}
	}

	protected override void Dispose(bool disposing)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				num = (disposing ? 1 : 5);
				continue;
			case 0:
			case 1:
				num = ((Ⴄ == null) ? 5 : (ⴃႤ[334] - 39268));
				continue;
			case 3:
				Ⴄ.Dispose();
				break;
			case 5:
				break;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void ႨႠ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 6;
		while (true)
		{
			switch (num)
			{
			default:
			{
				Ⴄ = new Container();
				Control control = new Label();
				ႣႷ.Ⴈ = (Label)control;
				goto case 18;
			}
			case 18:
				num = ⴀ[141] - 59648;
				break;
			case 19:
			{
				Ⴅ = new Panel();
				Component component = new System.Windows.Forms.Timer(Ⴄ);
				ႣႷ.Ⴃ = (System.Windows.Forms.Timer)component;
				num = ⴀ[298] - 688;
				break;
			}
			case 20:
				Ⴐ = new Label();
				goto case 22;
			case 22:
				AutoUpdater.Ⴜ((Control)this, 339, 'ŉ');
				UtilsLatLon.ႷႭ((Control)ႣႷ.Ⴈ, DgvTextBoxColumnFilter.Ⴐ(446, 'ǔ'), 212, 150);
				num = ⴐ[91] - 964;
				break;
			case 3:
				PrecisionTimer.Ⴗ((Control)ႣႷ.Ⴈ, new Point(112, 169), '·', (short)159);
				num = ⴀ[403] - 52882;
				break;
			case 1:
				LogFile.Ⴀ((Control)ႣႷ.Ⴈ, TelnetServerClient.Ⴄ(1945322735, '\u0080', 5), (short)820, (short)827);
				num = 21;
				break;
			case 21:
				ServerIoCfg.ႤႰ((Control)ႣႷ.Ⴈ, new Size(279, 16), 'Ô', (short)245);
				num = 0;
				break;
			case 0:
				ObjectCopierExt.Ⴅ((Control)ႣႷ.Ⴈ, 4, (short)1006, 'Ϟ');
				AnnCfg.Ⴗ((Control)ႣႷ.Ⴈ, UtilsString.Ⴐ(null, 0, 192632208), (short)326, 'Ł');
				num = 13;
				break;
			case 13:
				UtilsLatLon.ႷႭ((Control)Ⴅ, DgvTextBoxColumnFilter.Ⴐ(727, 'ʽ'), 363, 297);
				num = 7;
				break;
			case 7:
				PrecisionTimer.Ⴗ((Control)Ⴅ, new Point(112, 138), 'ϗ', (short)1023);
				LogFile.Ⴀ((Control)Ⴅ, UtilsString.Ⴐ(null, 3, 192631492), (short)607, (short)592);
				num = ⴐ[276] - 59373;
				break;
			case 14:
				ServerIoCfg.ႤႰ((Control)Ⴅ, new Size(279, 24), 'Ǥ', (short)453);
				ObjectCopierExt.Ⴅ((Control)Ⴅ, 3, (short)694, 'ʆ');
				num = 12;
				break;
			case 12:
				HelpAboutClient.ႷႷ<EventHandler, System.Windows.Forms.Timer>(ႣႷ.Ⴃ, ႨႤ, 'Ψ', 'ί');
				num = ⴃႤ[110] - 56229;
				break;
			case 4:
				UtilsLatLon.ႷႭ((Control)Ⴐ, DgvTextBoxColumnFilter.Ⴐ(84, '>'), 639, 573);
				num = ⴃႭ[91] - 28858;
				break;
			case 10:
				PrecisionTimer.Ⴗ((Control)Ⴐ, new Point(113, 114), 'ʦ', (short)654);
				LogFile.Ⴀ((Control)Ⴐ, DownloadUrl2.Ⴅ(21, null, 2018867831, 7), (short)338, (short)349);
				num = ⴃႣ[116] - 21526;
				break;
			case 9:
				ServerIoCfg.ႤႰ((Control)Ⴐ, new Size(279, 14), 'ȟ', (short)574);
				Ⴐ.TabIndex = 5;
				num = 8;
				break;
			case 8:
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				base.AutoScaleMode = AutoScaleMode.Font;
				BackgroundImage = Ⴃ.ႰႨ.Ⴅ();
				num = 16;
				break;
			case 16:
				base.ClientSize = new Size(421, 221);
				base.Controls.Add(Ⴐ);
				num = 2;
				break;
			case 2:
				base.Controls.Add(ႣႷ.Ⴈ);
				base.Controls.Add(Ⴅ);
				num = 15;
				break;
			case 15:
				base.FormBorderStyle = FormBorderStyle.None;
				base.Name = UtilsString.Ⴐ(null, 2, 192632225);
				num = ⴐ[168] - 4234;
				break;
			case 17:
				base.StartPosition = FormStartPosition.CenterScreen;
				Text = UtilsString.Ⴐ(null, 3, 192632224);
				num = 11;
				break;
			case 5:
			case 11:
				ResumeLayout(performLayout: false);
				return;
			}
		}
	}

	public SplashScreen()
	{
		ႣႷ.Ⴐ = 0.05;
		ႣႷ.Ⴄ = 0.08;
		ႳႠ = 0.015;
		ႳႭ = 1;
		ICollection collection = new ArrayList();
		ႣႷ.Ⴀ = (ArrayList)collection;
		base._002Ector();
		ႨႠ();
		DxCommentExtCfg.ႷႳ((Form)this, 0.0, '\u00b8', (short)147);
		DgvDateColumnFilter.Ⴍ(ႣႷ.Ⴃ, 50, 194, 'Ü');
		DgvFreqRangeColumnFilter.Ⴜ(ႣႷ.Ⴃ, 313, 267);
		if (ႥႳ)
		{
			ReverseBeaconClient.Ⴓ((Control)this, (Image)Ⴃ.ႰႨ.Ⴅ(), 'ů', 350);
		}
		else
		{
			ReverseBeaconClient.Ⴓ((Control)this, (Image)Ⴃ.ႰႨ.Ⴍ(), 'ʚ', 683);
		}
		base.ClientSize = BackgroundImage.Size;
		ႣႷ.Ⴈ.Text = string.Empty;
	}

	public static void ShowSplashScreen(bool isServer)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				ႥႳ = isServer;
				break;
			case 4:
				break;
			case 0:
				return;
			}
			if (Ⴗ == null)
			{
				break;
			}
			num = ⴀ[156] - 26369;
		}
		while (true)
		{
			Ⴈ = new Thread(ႨႨ);
			UtilsValidation.Ⴃ(Ⴈ, true, 270, 363);
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					return;
				case 1:
				case 9:
					break;
				case 3:
					DirectoryMonitor.ႠႳ(Ⴈ, ApartmentState.STA, 'ğ', 303);
					UtilsValidation.Ⴗ(Ⴈ, 'H', 32);
					num2 = 4;
					continue;
				case 0:
				case 6:
					Thread.Sleep(50);
					goto case 2;
				case 2:
				case 4:
					num2 = ((Ⴗ == null) ? 6 : 5);
					continue;
				case 5:
					num2 = ((!Ⴗ.IsHandleCreated) ? 6 : 8);
					continue;
				case 8:
					return;
				}
				break;
			}
		}
	}

	private static void ႨႨ()
	{
		Ⴗ = new SplashScreen();
		DgvFreqRangeColumnFilter.Ⴅ((Form)Ⴗ, (short)680, 'ʽ');
	}

	public static void CloseForm(Form in_parentForm)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 4;
		object obj2 = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj2 = new ႰႨ();
				goto case 0;
			case 0:
				((ႰႨ)obj2).Ⴓ = in_parentForm;
				obj = new MethodInvoker((obj2 as ႰႨ).Ⴀ);
				num = ⴃႣ[2] - 5266;
				continue;
			case 2:
				num = ((Ⴗ == null) ? 6 : 7);
				continue;
			case 7:
			{
				SplashScreen ⴗ = Ⴗ;
				double ⴐ = 0.0 - Ⴗ.ႣႷ.Ⴄ;
				ⴗ.ႣႷ.Ⴐ = ⴐ;
				num = 1;
				continue;
			}
			case 1:
				num = ((!DgvFilterHost.ႥႣ((Control)Ⴗ, (short)306, (short)329)) ? 3 : 8);
				continue;
			case 5:
			case 8:
				AutoUpdater.ႭႠ((Control)Ⴗ, (Delegate)(obj as MethodInvoker), (short)193, 187);
				num = 6;
				continue;
			case 3:
				(obj as MethodInvoker)();
				break;
			case 6:
			case 9:
				break;
			}
			break;
		}
		Ⴈ = null;
		Ⴗ = null;
	}

	public static void CloseForm()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((Ⴗ == null) ? (ⴃႤ[141] - 20926) : 6);
				continue;
			case 6:
				num = (DgvFilterHost.ႥႣ((Control)Ⴗ, (short)13, (short)113) ? 2 : 5);
				continue;
			case 5:
			{
				SplashScreen ⴗ = Ⴗ;
				double ⴐ = 0.0 - Ⴗ.ႣႷ.Ⴄ;
				ⴗ.ႣႷ.Ⴐ = ⴐ;
				num = 2;
				continue;
			}
			case 0:
			case 2:
				Ⴈ = null;
				break;
			case 3:
				break;
			case 1:
				return;
			}
			break;
		}
		Ⴗ = null;
	}

	public static void SetStatus(string newStatus)
	{
		SetStatus(newStatus, setReference: true);
	}

	public static void SetStatus(string newStatus, bool setReference)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴜ = newStatus;
				break;
			case 1:
			case 4:
				break;
			case 0:
				return;
			}
			if (Ⴗ != null)
			{
				break;
			}
			num = 0;
		}
		while (true)
		{
			switch (setReference ? 1 : (ⴗ[33] - 33386))
			{
			default:
				/*OpCode not supported: LdMemberToken*/;
				return;
			case 2:
				return;
			case 3:
			case 4:
				break;
			case 1:
			case 6:
				Ⴗ.ႨႭ();
				return;
			case 5:
				return;
			}
		}
	}

	public static void SetReferencePoint()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			}
			if (Ⴗ == null)
			{
				num = ⴃႣ[215] - 32477;
				continue;
			}
			Ⴗ.ႨႭ();
			return;
		}
	}

	private void ႨႭ()
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!ႳႨ) ? (ⴗ[144] - 45237) : 0);
				continue;
			case 8:
			{
				ႳႨ = true;
				DateTime ⴍ = AnnCfg.Ⴓ(921, 'Ϧ');
				ႣႷ.Ⴍ = ⴍ;
				num = ⴗ[112] - 6793;
				continue;
			}
			case 4:
				ႨႰ();
				goto case 0;
			case 0:
			{
				double num3 = ႨႷ();
				DgvFreqRangeColumnFilter.Ⴄ(ႣႷ.Ⴀ, (object)num3, (short)933, (short)993);
				num = ⴗ[12] - 35082;
				continue;
			}
			case 9:
			{
				double ⴓ2 = ႣႷ.Ⴓ;
				ႣႷ.Ⴗ = ⴓ2;
				num = ⴃႤ[125] - 39734;
				continue;
			}
			case 5:
			case 6:
				if (ႳႼ != null)
				{
					num = 2;
					continue;
				}
				break;
			case 2:
				if (ႳႭ < UtilsDate.Ⴄ(ႳႼ, 801, 865))
				{
					num = 3;
					continue;
				}
				break;
			case 3:
			case 10:
			{
				ArrayList ⴓႼ = ႳႼ;
				int ⴓႭ;
				int num2 = (ⴓႭ = ႳႭ);
				WxCfg.ႣႭ[28] = (char)((WxCfg.ႣႭ[28] | WxCfg.ႣႭ[25]) & 0x63);
				ႳႭ = num2 + 1;
				double ⴓ = (double)HelpAboutClient.Ⴄ(ⴓႼ, ⴓႭ, '\u001c', 73);
				ႣႷ.Ⴓ = ⴓ;
				return;
			}
			}
			break;
		}
		double ⴓ3 = ((ႳႭ > 0) ? 1 : 0);
		ႣႷ.Ⴓ = ⴓ3;
	}

	private double ႨႷ()
	{
		while (true)
		{
			TimeSpan timeSpan = UtilsCopyright.Ⴈ(AnnCfg.Ⴓ(21, 'j'), ႣႷ.Ⴍ, 1005, 937);
			while (true)
			{
				IL_004e:
				int num = 1;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 0;
						continue;
					case 0:
						break;
					case 2:
					case 5:
						goto IL_004e;
					case 1:
					case 3:
						return timeSpan.TotalMilliseconds;
					}
					break;
				}
				break;
			}
		}
	}

	private void ႨႰ()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 9;
		double ⴓႠ = default(double);
		IEnumerable<char> empty = default(IEnumerable<char>);
		object obj = default(object);
		int num2 = default(int);
		double num3 = default(double);
		while (true)
		{
			switch (num)
			{
			default:
			{
				ICloneable cloneable = UtilsString.Ⴐ(null, 1, 192632241);
				num = ((!PrecisionTimer.ႤႥ(cloneable as string, NumberStyles.Float, (IFormatProvider)WwvSpotExt.Ⴗ(1010, 'Ͼ'), ref ⴓႠ, 258, 257)) ? 8 : 0);
				break;
			}
			case 0:
				ႳႠ = ⴓႠ;
				num = 6;
				break;
			case 8:
				ႳႠ = 0.0015;
				num = 6;
				break;
			case 6:
				empty = string.Empty;
				if (ColumnFilterEventArgs.Ⴀ((string)empty, string.Empty, 190, 241))
				{
					num = ⴃႣ[53] - 65077;
					break;
				}
				ႳႰ = true;
				ႨႳ(string.Empty);
				return;
			case 12:
				obj = Ⴃ.ႰႨ.ႨႥ((string)empty, null, 193, 160);
				goto case 1;
			case 1:
				ႳႼ = new ArrayList();
				num = ⴀ[210] - 35504;
				break;
			case 3:
			case 7:
				num2 = 0;
				num = ⴗ[72] - 50233;
				break;
			case 5:
				num = ((!PrecisionTimer.ႤႥ(((string[])obj)[num2], NumberStyles.Float, (IFormatProvider)WwvSpotExt.Ⴗ(31, '\u0013'), ref num3, 236, 239)) ? 14 : 2);
				break;
			case 2:
				DgvFreqRangeColumnFilter.Ⴄ(ႳႼ, (object)num3, (short)321, (short)261);
				num = ⴀ[19] - 12902;
				break;
			case 14:
				ႳႼ.Add(1.0);
				num = 4;
				break;
			case 4:
				num2++;
				num = 10;
				break;
			case 10:
				num = ((num2 < (obj as string[]).Length) ? (ⴀ[28] - 35531) : 11);
				break;
			case 11:
			case 13:
				return;
			}
		}
	}

	private void ႨႣ()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 6;
		object obj = default(object);
		double num3 = default(double);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				obj = string.Empty;
				num3 = ႨႷ();
				num2 = 0;
				num = ⴐ[403] - 62071;
				break;
			case 0:
				obj = UtilsEmail.Ⴀ(obj as string, ((double)HelpAboutClient.Ⴄ(ႣႷ.Ⴀ, num2, 'Ɯ', 457) / num3).ToString(ႣႼ.Ⴜ(2, 365387290, 5), WwvSpotExt.Ⴗ(54, ':')), ႣႼ.Ⴜ(8, 365387214, 4), 976, 902);
				num = ⴗ[59] - 8065;
				break;
			case 4:
			case 7:
				num2++;
				num = 2;
				break;
			case 2:
				num = ((num2 >= UtilsDate.Ⴄ(ႣႷ.Ⴀ, 939, 1003)) ? (ⴗ[141] - 5939) : 0);
				break;
			case 3:
				ႳႠ = 1.0 / (double)ႳႣ;
				return;
			case 1:
				return;
			}
		}
	}

	private void ႨႤ(object P_0, EventArgs P_1)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 10;
		int num5 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		IDeviceContext deviceContext = default(IDeviceContext);
		object obj = default(object);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				AnnCfg.Ⴗ((Control)Ⴐ, Ⴜ, (short)1011, 'ϴ');
				num = ((!(ႣႷ.Ⴐ > 0.0)) ? (ⴐ[508] - 64994) : (ⴀ[42] - 37426));
				break;
			case 4:
				ႳႣ++;
				goto case 7;
			case 7:
				num = ((!(DgvComboBoxColumnFilter.Ⴐ((Form)this, 870, 804) < 1.0)) ? 22 : 0);
				break;
			case 0:
				DxCommentExtCfg.ႷႳ((Form)this, DgvComboBoxColumnFilter.Ⴐ((Form)this, 125, 63) + ႣႷ.Ⴐ, '\u009c', (short)183);
				num = ⴃႭ[136] - 62975;
				break;
			case 19:
				num = ((!(DgvComboBoxColumnFilter.Ⴐ((Form)this, 479, 413) > 0.0)) ? 1 : (ⴐ[481] - 29240));
				break;
			case 12:
				DxCommentExtCfg.ႷႳ((Form)this, DgvComboBoxColumnFilter.Ⴐ((Form)this, 652, 718) + ႣႷ.Ⴐ, 'ş', (short)372);
				num = 22;
				break;
			case 1:
				ႨႣ();
				GlobalConst.Ⴃ(ႣႷ.Ⴃ, 'ɑ', 519);
				num = 17;
				break;
			case 17:
				DgvFreqRangeColumnFilter.Ⴅ((Form)this, (short)503, 'ǣ');
				goto case 22;
			case 22:
			case 25:
				if (!ႳႰ)
				{
					num = 13;
					break;
				}
				return;
			case 13:
				if (ႣႷ.Ⴗ < ႣႷ.Ⴓ)
				{
					num = 5;
					break;
				}
				return;
			case 5:
			{
				double ⴗ2 = ႣႷ.Ⴗ + ႳႠ;
				ႣႷ.Ⴗ = ⴗ2;
				num = ⴃႣ[187] - 55705;
				break;
			}
			case 11:
			{
				Rectangle rectangle4 = UtilsCopyright.Ⴄ((Control)Ⴅ, (short)520, (short)596);
				num5 = (int)XmlSerializationHelper.Ⴗ((double)CtyInfo.Ⴄ(ref rectangle4, 'ɲ', 542) * ႣႷ.Ⴗ, 874, 895);
				num = 3;
				break;
			}
			case 3:
			{
				Rectangle rectangle3 = UtilsCopyright.Ⴄ((Control)Ⴅ, (short)969, (short)917);
				num6 = CtyInfo.Ⴄ(ref rectangle3, 'θ', 981);
				num = 14;
				break;
			}
			case 14:
			{
				Rectangle rectangle2 = UtilsCopyright.Ⴄ((Control)Ⴅ, (short)226, (short)190);
				num3 = Ⴃ.ႰႣ.ႰႰ(ref rectangle2, 'α', 996);
				num = 6;
				break;
			}
			case 6:
			{
				Rectangle rectangle = UtilsCopyright.Ⴄ((Control)Ⴅ, (short)862, (short)770);
				num4 = PrecisionTimer.ႷႰ(ref rectangle, 963, 902);
				num = 2;
				break;
			}
			case 2:
				if (num5 > 0)
				{
					num = 20;
					break;
				}
				return;
			case 20:
				if (num6 > 0)
				{
					num = ⴃႭ[74] - 34498;
					break;
				}
				return;
			case 21:
			case 24:
			{
				Rectangle ⴅ = new Rectangle(num3, num4, num5, num6);
				ႣႷ.Ⴅ = ⴅ;
				num = 18;
				break;
			}
			case 18:
				num = (DgvFilterHost.ႥႣ((Control)Ⴅ, (short)101, (short)25) ? 15 : (ⴃႤ[243] - 32130));
				break;
			case 8:
				deviceContext = FrmUpdateAvailable.ႷႰ((Control)Ⴅ, (short)1000, (short)913);
				obj = new LinearGradientBrush(ႣႷ.Ⴅ, Color.FromArgb(58, 96, 151), Color.FromArgb(181, 237, 254), LinearGradientMode.Horizontal);
				num = 23;
				break;
			case 23:
				((Graphics)deviceContext).FillRectangle((LinearGradientBrush)obj, ႣႷ.Ⴅ);
				(deviceContext as Graphics).Dispose();
				goto case 15;
			case 15:
				num2 = 1 + (int)(50.0 * ((1.0 - ႣႷ.Ⴗ) / ႳႠ)) / 1000;
				num = 16;
				break;
			case 16:
				if (num2 == 1)
				{
					num = ⴗ[50] - 11832;
					break;
				}
				ႨႳ(string.Format(ArcLogInRqstExt.Ⴗ(1706507879, 9, 3), num2));
				return;
			case 9:
				ႨႳ(string.Format(ArcLogInRqstExt.Ⴗ(1706507852, 9, 3)));
				return;
			}
		}
	}

	private void ႨႳ(string P_0)
	{
		int num = 2;
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = null;
				goto case 3;
			case 3:
				obj2 = new ႰႭ();
				((ႰႭ)obj2).Ⴀ = P_0;
				(obj2 as ႰႭ).Ⴀ = this;
				num = 5;
				break;
			case 5:
				if (base.InvokeRequired)
				{
					num = 0;
					break;
				}
				ႣႷ.Ⴈ.Text = ((ႰႭ)obj2).Ⴀ;
				return;
			case 0:
			case 1:
			case 4:
				if ((MethodInvoker)obj == null)
				{
					obj = new MethodInvoker((obj2 as ႰႭ).Ⴅ);
				}
				UtilsEmail.Ⴐ((Control)this, (Delegate)(MethodInvoker)obj, (short)528, (short)532);
				return;
			}
		}
	}

	public void SetOwnerCrossThread(Form frmParent)
	{
		int num = 0;
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = null;
				goto case 2;
			case 2:
				obj2 = new ႰႣ();
				(obj2 as ႰႣ).Ⴃ = frmParent;
				(obj2 as ႰႣ).Ⴀ = this;
				num = 1;
				break;
			case 1:
				if (base.InvokeRequired)
				{
					num = 3;
					break;
				}
				SplashForm.Owner = (obj2 as ႰႣ).Ⴃ;
				return;
			case 3:
			case 5:
				if ((MethodInvoker)obj == null)
				{
					obj = new MethodInvoker(((ႰႣ)obj2).Ⴀ);
				}
				UtilsEmail.Ⴐ((Control)this, (Delegate)(obj as MethodInvoker), (short)370, (short)374);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static SplashScreen()
	{
		UtilsIdentity.Ⴐ();
		Ⴗ = null;
		Ⴈ = null;
	}
}
