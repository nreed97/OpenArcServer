using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.DgvUtils.DgvFilter.Implementations;

public class DgvCheckBoxColumnFilter : DgvBaseColumnFilter
{
	private Label Ⴍ;

	public CheckBox CheckBoxValue => base.Ⴃ;

	protected override void Dispose(bool disposing)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? 4 : (ⴃႤ[17] - 6858));
				continue;
			case 5:
				num = ((Ⴗ == null) ? 4 : 0);
				continue;
			case 0:
				Ⴗ.Dispose();
				break;
			case 3:
			case 4:
				break;
			case 6:
				return;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void ႠႥ()
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 13;
		while (true)
		{
			switch (num)
			{
			default:
				base.Ⴃ = new CheckBox();
				Ⴍ = new Label();
				AutoUpdater.Ⴜ((Control)this, 795, '\u0301');
				num = 7;
				break;
			case 7:
				DxSpotExt.Ⴀ((Control)base.Ⴃ, true, (short)266, 'Ĵ');
				PrecisionTimer.Ⴗ((Control)base.Ⴃ, new Point(67, 7), 'Ω', (short)897);
				num = 9;
				break;
			case 9:
				LogFile.Ⴀ((Control)base.Ⴃ, ႣႼ.Ⴜ(2, 365387211, 20), (short)901, (short)906);
				num = 0;
				break;
			case 0:
				ServerIoCfg.ႤႰ((Control)base.Ⴃ, new Size(15, 14), 'Ļ', (short)282);
				ObjectCopierExt.Ⴅ((Control)base.Ⴃ, 1, (short)226, 'Ò');
				num = 5;
				break;
			case 1:
			case 5:
				LogFile.Ⴄ((ButtonBase)base.Ⴃ, true, (short)353, 259);
				DxSpotExt.Ⴀ((Control)Ⴍ, true, (short)775, '\u0339');
				num = ⴗ[140] - 43352;
				break;
			case 8:
				PrecisionTimer.Ⴗ((Control)Ⴍ, new Point(26, 7), 'Ę', (short)304);
				LogFile.Ⴀ((Control)Ⴍ, UtilsString.Ⴐ(null, 4, 192631369), (short)500, (short)507);
				num = ⴐ[2] - 52869;
				break;
			case 10:
				ServerIoCfg.ႤႰ((Control)Ⴍ, new Size(40, 13), 'ˡ', (short)704);
				ObjectCopierExt.Ⴅ((Control)Ⴍ, 2, (short)389, 'Ƶ');
				num = 2;
				break;
			case 2:
				AnnCfg.Ⴗ((Control)Ⴍ, UtilsString.Ⴐ(null, 8, 192631361), (short)951, 'ΰ');
				num = 12;
				break;
			case 12:
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				base.AutoScaleMode = AutoScaleMode.Font;
				BackColor = Color.Transparent;
				num = ⴃႤ[334] - 39257;
				break;
			case 6:
			case 14:
				base.Controls.Add(Ⴍ);
				base.Controls.Add(base.Ⴃ);
				goto case 11;
			case 11:
				num = 3;
				break;
			case 3:
				base.Name = UtilsString.Ⴐ(null, 8, 192631368);
				base.Size = new Size(98, 28);
				num = 4;
				break;
			case 4:
				ResumeLayout(performLayout: false);
				PerformLayout();
				DxCfg.Ⴗ[137] = (char)((DxCfg.Ⴗ[137] ^ DxCfg.Ⴗ[145]) & 0x21);
				return;
			}
		}
	}

	public DgvCheckBoxColumnFilter()
	{
		ႠႥ();
		LegalCfg.Ⴃ<CheckBox, EventHandler>(base.Ⴃ, ႠႠ, 526, 612);
	}

	protected override void OnFilterInitializing(object sender, CancelEventArgs e)
	{
		base.OnFilterInitializing(sender, e);
		StationCfg.Ⴃ(e, 680, 698);
	}

	protected override void OnFilterExpressionBuilding(object sender, CancelEventArgs e)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				base.OnFilterExpressionBuilding(sender, e);
				goto case 1;
			case 1:
				if (StationCfg.Ⴃ(e, 253, 239))
				{
					break;
				}
				while (true)
				{
					IEnumerable enumerable = string.Empty;
					while (true)
					{
						IL_00b0:
						ICloneable cloneable = string.Empty;
						int num2 = ((!UtilsPerformance.Ⴐ(base.Ⴃ, '\u0304', 842)) ? 10 : 4);
						while (true)
						{
							switch (num2)
							{
							default:
								/*OpCode not supported: LdMemberToken*/;
								return;
							case 1:
								break;
							case 5:
								goto IL_00b0;
							case 4:
								enumerable = UtilsSql.Ⴍ(base.DataGridViewColumn, 45, 30);
								cloneable = base.OriginalDataGridViewColumnHeaderText;
								num2 = ⴃႣ[33] - 33495;
								continue;
							case 10:
								enumerable = ReverseBeaconClient.Ⴗ(ArcLogInRqstExt.Ⴗ(1706507142, 16, 2), UtilsSql.Ⴍ(base.DataGridViewColumn, 931, 912), '\u0307', '\u034f');
								num2 = 2;
								continue;
							case 2:
							case 3:
								cloneable = UtilsEmail.Ⴀ(cloneable as string, UtilsString.Ⴐ(null, 5, 192631407), base.OriginalDataGridViewColumnHeaderText, 113, 39);
								num2 = ⴀ[155] - 17773;
								continue;
							case 9:
								num2 = ((!(enumerable as string != string.Empty)) ? (ⴃႣ[116] - 21529) : (ⴃႤ[193] - 14813));
								continue;
							case 7:
								base.FilterExpression = (string)enumerable;
								goto case 8;
							case 8:
								base.FilterCaption = cloneable as string;
								base.FilterManager.RebuildFilter();
								num2 = 6;
								continue;
							case 6:
								return;
							}
							break;
						}
						break;
					}
				}
			case 3:
				base.FilterManager.RebuildFilter();
				return;
			}
			num = ⴗ[101] - 49611;
		}
	}

	private void ႠႠ(object P_0, EventArgs P_1)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!base.FilterApplySoon) ? (ⴗ[59] - 8070) : (ⴀ[126] - 16242));
				break;
			case 5:
				if (!DgvFilterHost.ႥႥ((Control)this, 608, 'Ⱦ'))
				{
					num = ⴗ[31] - 485;
					break;
				}
				base.Active = true;
				FilterExpressionBuild();
				return;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static DgvCheckBoxColumnFilter()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static int Ⴀ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, StringComparison P_2, int P_3, char P_4) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int result = default(int);
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
					num2 = ⴃႣ[105] - 52214;
					continue;
				case 10:
					break;
				case 0:
					num2 = (((P_3 ^ P_4) - 119) ^ num) switch
					{
						0 => 5, 
						_ => ⴃႣ[214] - 56065, 
					};
					continue;
				case 1:
					result = 5;
					num2 = ⴀ[43] - 13275;
					continue;
				case 5:
					result = P_0.IndexOf(P_1, P_2);
					num2 = 6;
					continue;
				case 6:
				case 9:
					num++;
					goto case 11;
				case 11:
					num2 = (((P_4 * P_4 + P_4) % 2 == 0) ? (ⴃႣ[176] - 11038) : 7);
					continue;
				case 7:
					num2 = ⴃႣ[91] - ⴃႣ[91];
					continue;
				case 4:
				case 8:
					return result;
				case 3:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static XElement Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : string
	{
		IXmlSerializable xmlSerializable = default(IXmlSerializable);
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
					num2 = 4;
					continue;
				case 4:
				case 9:
					break;
				case 2:
				case 8:
					num2 = (((P_1 ^ P_2) - 43) ^ num) switch
					{
						0 => 6, 
						_ => 3, 
					};
					continue;
				case 3:
					xmlSerializable = null;
					num2 = 11;
					continue;
				case 0:
				case 6:
					xmlSerializable = XElement.Parse(P_0);
					num2 = 11;
					continue;
				case 11:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 10 : 7);
					continue;
				case 7:
					num2 = 2;
					continue;
				case 10:
					return (XElement)xmlSerializable;
				case 5:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, Padding P_1, short P_2, short P_3) where _0021_00210 : ToolStripItem
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 0;
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
				num = (((P_2 ^ P_3) - 52) ^ num2) switch
				{
					0 => 7, 
					_ => 9, 
				};
				break;
			case 9:
				num = 3;
				break;
			case 2:
			case 7:
				P_0.Padding = P_1;
				goto case 3;
			case 3:
			case 8:
			{
				num2++;
				int num3 = 55;
				int num4 = 227;
				num = ((681 > num4 - num3 * 3) ? 6 : 5);
				break;
			}
			case 5:
				num = ⴐ[128] - 44713;
				break;
			case 1:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : Font
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		float result = default(float);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[26] - 482;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[58] - 1702;
					continue;
				case 4:
					break;
				case 6:
					num2 = (((P_1 ^ P_2) - 108) ^ num) switch
					{
						0 => ⴃႤ[288] - 44549, 
						_ => 3, 
					};
					continue;
				case 3:
					result = 0.4175058f;
					num2 = ⴃႤ[482] - 36624;
					continue;
				case 2:
				case 8:
					result = P_0.Size;
					num2 = 10;
					continue;
				case 10:
					num++;
					num3 = 1674;
					goto case 9;
				case 9:
				{
					int num4 = 221;
					num2 = ((558 < num3 / 3 - num4) ? (ⴀ[154] - 28008) : 7);
					continue;
				}
				case 0:
				case 7:
					return result;
				case 1:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal new static double Ⴃ(double P_0, double P_1, char P_2, short P_3)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		double result = default(double);
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
					num2 = 8;
					continue;
				case 5:
				case 8:
					break;
				case 0:
					num2 = (((P_2 ^ P_3) - 43) ^ num) switch
					{
						0 => 11, 
						_ => ⴐ[519] - 58358, 
					};
					continue;
				case 4:
				case 6:
					result = 1.003416677727551;
					num2 = ⴐ[161] - 4784;
					continue;
				case 11:
					result = Math.Atan2(P_0, P_1);
					num2 = 9;
					continue;
				case 9:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴗ[155] - 49745) : (ⴀ[263] - 4040));
					continue;
				case 3:
				case 7:
					num2 = 0;
					continue;
				case 2:
					return result;
				case 10:
					num2 = ⴀ[241] - 35034;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal new static double Ⴄ(double P_0, double P_1, int P_2, short P_3)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		double result = default(double);
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
					num2 = 7;
					continue;
				case 7:
					break;
				case 0:
					num2 = (((P_2 ^ P_3) - 108) ^ num) switch
					{
						0 => 5, 
						_ => ⴗ[105] - 4872, 
					};
					continue;
				case 3:
					result = P_0;
					num2 = ⴐ[455] - 58336;
					continue;
				case 5:
					result = Math.IEEERemainder(P_0, P_1);
					num2 = ⴗ[4] - 26303;
					continue;
				case 10:
				{
					num++;
					int num3 = 78;
					int num4 = 14;
					TalkCfg.ႣႣ[52] = (char)((TalkCfg.ႣႣ[52] | DxCfg.Ⴗ[21]) & 0x42);
					num2 = ((26 >= num3 / 3 - num4) ? (ⴐ[31] - 45326) : 0);
					continue;
				}
				case 1:
				case 2:
				case 4:
					return result;
				case 9:
					num2 = ⴃႤ[111] - ⴃႤ[111];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static uint Ⴐ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		uint result = default(uint);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႤ[465] - 61131;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 52) ^ num) switch
					{
						0 => 10, 
						_ => 3, 
					};
					continue;
				case 3:
					result = default(uint);
					num2 = ⴐ[318] - 52878;
					continue;
				case 10:
					result = Convert.ToUInt32(P_0);
					num2 = ⴃႤ[445] - 24889;
					continue;
				case 6:
				case 9:
					num++;
					goto case 8;
				case 8:
					num3 = 2325;
					goto case 7;
				case 7:
				{
					int num4 = 711;
					num2 = ((775 < num3 / 3 - num4) ? 1 : 5);
					continue;
				}
				case 5:
					return result;
				case 2:
					num2 = ⴃႤ[222] - 57358;
					continue;
				}
				break;
			}
		}
	}
}
