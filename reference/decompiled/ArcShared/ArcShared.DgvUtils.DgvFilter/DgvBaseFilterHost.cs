using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net.Sockets;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Pcxx;
using ArcShared.ArcUtils;
using ArcShared.Constants;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods.Login;
using ArcShared.Forms;
using ArcShared.MaintenanceUpdates;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.DgvUtils.DgvFilter;

public class DgvBaseFilterHost : UserControl
{
	private ToolStripDropDown Ⴐ;

	private DgvFilterManager Ⴃ;

	private Size Ⴍ;

	private StationCfg.ႭႣ m_Ⴅ = new StationCfg.ႭႣ();

	internal ToolStripButton Ⴄ;

	internal Panel Ⴗ;

	internal ToolStripButton Ⴀ;

	internal Panel Ⴈ;

	internal ToolStripButton Ⴜ;

	public virtual Control FilterClientArea
	{
		get
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			return this;
		}
	}

	public ToolStripDropDown Popup
	{
		get
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			char[] ⴃႭ = WxCfg.ႣႭ;
			char[] ⴗ = DxCfg.Ⴗ;
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			ToolStripItem toolStripItem = default(ToolStripItem);
			while (true)
			{
				int num = ((Ⴐ != null) ? (ⴃႭ[126] - 42171) : 4);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႣ[56] - 56167;
						continue;
					case 7:
					case 8:
						break;
					case 2:
					case 4:
						Ⴐ = new ToolStripDropDown();
						toolStripItem = new ToolStripControlHost(this);
						DgvCheckBoxColumnFilter.Ⴅ((ToolStripItem)(ToolStripControlHost)toolStripItem, Padding.Empty, (short)1006, (short)986);
						num = ⴗ[23] - 59667;
						continue;
					case 5:
						DirectoryMonitor.ႠႨ((ToolStripItem)(toolStripItem as ToolStripControlHost), Padding.Empty, 887, '\u0350');
						UtilsSql.ႨႤ((ToolStripItem)(ToolStripControlHost)toolStripItem, false, '\u0089', (short)162);
						num = ⴃႤ[282] - ⴃႤ[282];
						continue;
					case 0:
						ႰႨ.ႨႭ((Control)Ⴐ, Padding.Empty, 231, (short)183);
						Ⴐ.Items.Add((ToolStripControlHost)toolStripItem);
						num = ⴃႭ[156] - 30518;
						continue;
					case 1:
					case 6:
						Ⴐ.Region = base.Region;
						goto case 3;
					case 3:
						return Ⴐ;
					}
					break;
				}
			}
		}
	}

	public DgvFilterManager FilterManager
	{
		get
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	public DgvBaseColumnFilter CurrentColumnFilter
	{
		get
		{
			return this.m_Ⴅ.Ⴃ;
		}
		set
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			int num = 6;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((!AnnCfg.ႷႥ(Ⴍ, Size.Empty, 'ˋ', 694)) ? 9 : 5);
					continue;
				case 5:
					Ⴍ = StringConstants.Ⴗ(HelpAboutClient.ႷႳ((Control)this, '3', '4'), WwvCfg.Ⴍ(FilterClientArea, 'ŝ', 296), 303, 'ũ');
					goto case 2;
				case 2:
					num = 1;
					continue;
				case 1:
					ServerIoCfg.ႤႰ((Control)this, HelpAboutClient.ႷႳ((Control)this, '\t', '\u000e'), 'ƌ', (short)430);
					goto case 9;
				case 9:
					num = ((this.m_Ⴅ.Ⴃ == null) ? (ⴀ[390] - 35176) : 8);
					continue;
				case 8:
					ArcLogInRqstExt.Ⴐ((Control)this.m_Ⴅ.Ⴃ, false, 941, (short)908);
					goto case 7;
				case 7:
					this.m_Ⴅ.Ⴃ = value as DgvBaseColumnFilter;
					DoAutoFit();
					goto case 3;
				case 3:
					num = 11;
					continue;
				case 11:
					num = ((this.m_Ⴅ.Ⴈ == null) ? 10 : (ⴐ[41] - 59292));
					continue;
				case 0:
				case 4:
				{
					object obj = new EventArgs();
					this.m_Ⴅ.Ⴈ(this, obj as EventArgs);
					break;
				}
				case 10:
					break;
				}
				break;
			}
			this.m_Ⴅ.Ⴃ.Visible = true;
		}
	}

	public Size SizeDifference
	{
		get
		{
			Size ⴍ = Ⴍ;
			TalkCfg.ႣႣ[27] = (char)((TalkCfg.ႣႣ[27] * TalkCfg.ႣႣ[200]) & 0xC7);
			return ⴍ;
		}
	}

	public event EventHandler CurrentColumnFilterChanged
	{
		add
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			char[] ⴀ = UtilsNumeric.Ⴀ;
			int num = 4;
			object obj = default(object);
			object obj2 = default(object);
			object obj3 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj = this.m_Ⴅ.Ⴈ;
					num = ⴃႤ[458] - 64771;
					break;
				case 5:
					obj2 = obj as EventHandler;
					goto case 6;
				case 6:
					obj3 = (EventHandler)UtilsIdentity.Ⴀ((Delegate)(EventHandler)obj2, (Delegate)value, 165, '\u009a');
					num = 1;
					break;
				case 1:
				{
					obj = Interlocked.CompareExchange(ref this.m_Ⴅ.Ⴈ, obj3 as EventHandler, (EventHandler)obj2);
					char num2 = ⴀ[51];
					char num3 = ⴀ[51];
					UtilsNumeric.Ⴀ[251] = (char)((UtilsNumeric.Ⴀ[251] ^ UtilsNumeric.Ⴀ[413]) & 0x8D);
					num = num2 - num3;
					break;
				}
				case 0:
				case 7:
					num = (((object)(obj as EventHandler) != (EventHandler)obj2) ? 5 : 2);
					break;
				case 2:
				case 3:
					return;
				}
			}
		}
		remove
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			char[] ⴗ = DxCfg.Ⴗ;
			int num = 4;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj = default(object);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = this.m_Ⴅ.Ⴈ;
					num = 0;
					break;
				case 0:
					obj = multicastDelegate as EventHandler;
					goto case 7;
				case 7:
					obj2 = (EventHandler)DownloadUrl2.Ⴜ((Delegate)(obj as EventHandler), (Delegate)value, 'ʆ', 'ʼ');
					num = 3;
					break;
				case 3:
					multicastDelegate = Interlocked.CompareExchange(ref this.m_Ⴅ.Ⴈ, (EventHandler)obj2, (EventHandler)obj);
					goto case 2;
				case 2:
					num = 6;
					break;
				case 6:
					num = (((object)(multicastDelegate as EventHandler) != (EventHandler)obj) ? (ⴗ[93] - ⴗ[93]) : (ⴃႣ[91] - 47965));
					break;
				case 5:
					return;
				}
			}
		}
	}

	protected virtual void DoAutoFit()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 2;
		Size size = default(Size);
		while (true)
		{
			switch (num)
			{
			default:
				size = PcxxServerClient.Ⴄ(Ⴍ, WwvCfg.Ⴍ((Control)this.m_Ⴅ.Ⴃ, '¶', 195), 912, 957);
				num = 6;
				break;
			case 6:
			{
				int num2 = WwvCfg.Ⴀ(ref size, 'Κ', 926);
				Size size2 = UtilsSql.ႨႳ((Control)this, (short)756, 'ʻ');
				GlobalConst.Ⴗ(ref size, DgvBaseColumnFilter.ႨႨ(num2, WwvCfg.Ⴀ(ref size2, 'Ϩ', 1004), 865, '\u030c'), 793, 823);
				goto case 0;
			}
			case 0:
				num = ⴐ[140] - 47064;
				break;
			case 1:
			case 4:
				size.Height = Math.Max(size.Height, MinimumSize.Height);
				num = 5;
				break;
			case 5:
				base.Size = size;
				FilterClientArea.Size = Size.Subtract(size, Ⴍ);
				goto case 3;
			case 3:
				num = ⴀ[39] - 63117;
				break;
			case 7:
				AlignFilter();
				return;
			}
		}
	}

	protected void AlignFilter()
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 8;
		int num2 = default(int);
		int num3 = default(int);
		VFilterAlignment vFilterAlignment = default(VFilterAlignment);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num3 = 0;
				vFilterAlignment = this.m_Ⴅ.Ⴃ.VFilterAlignment;
				num = 11;
				break;
			case 11:
				num = vFilterAlignment switch
				{
					VFilterAlignment.Right => ⴀ[286] - 50409, 
					VFilterAlignment.Center => 2, 
					_ => ⴗ[92] - 39174, 
				};
				break;
			case 10:
				num = 9;
				break;
			case 6:
				num2 = ServerIoCfg.ႤႭ(FilterClientArea, 969, 'η') - ServerIoCfg.ႤႭ((Control)this.m_Ⴅ.Ⴃ, 380, 'Ă');
				num = ⴐ[300] - 16231;
				break;
			case 0:
			case 2:
			case 5:
				num2 = (ServerIoCfg.ႤႭ(FilterClientArea, 143, 'ñ') - ServerIoCfg.ႤႭ((Control)this.m_Ⴅ.Ⴃ, 222, '\u00a0')) / 2;
				num = 9;
				break;
			case 9:
				num = this.m_Ⴅ.Ⴃ.HFilterAlignment switch
				{
					HFilterAlignment.Bottom => ⴃႭ[16] - 11712, 
					HFilterAlignment.Middle => ⴗ[1] - 50408, 
					_ => ⴃႣ[214] - 56063, 
				};
				break;
			case 3:
				num = 7;
				break;
			case 12:
				num3 = AnnCfg.ႷႤ(FilterClientArea, 532, 'ȼ') - AnnCfg.ႷႤ((Control)this.m_Ⴅ.Ⴃ, 407, 'ƿ');
				num = 7;
				break;
			case 1:
				num3 = (AnnCfg.ႷႤ(FilterClientArea, 341, 'Ž') - this.m_Ⴅ.Ⴃ.Height) / 2;
				num = 7;
				break;
			case 7:
				this.m_Ⴅ.Ⴃ.Location = new Point(num2, num3);
				return;
			case 4:
				return;
			}
		}
	}

	public static Region BitmapToRegion(Bitmap bitmap, Color transparencyColor)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num3 = default(int);
		int num5 = default(int);
		MarshalByRefObject marshalByRefObject = default(MarshalByRefObject);
		int num2 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			int num = ((bitmap != null) ? 14 : (ⴃႤ[352] - 35952));
			while (true)
			{
				switch (num)
				{
				default:
				{
					/*OpCode not supported: LdMemberToken*/;
					char num7 = ⴐ[185];
					UtilsNumeric.Ⴀ[415] = (char)((UtilsNumeric.Ⴀ[415] | UtilsNumeric.Ⴀ[387]) & 0xE4);
					num = num7 - 36202;
					continue;
				}
				case 9:
					break;
				case 4:
					throw new ArgumentNullException(ArcLogInRqstExt.Ⴗ(1706507902, 7, 4), UtilsString.Ⴐ(null, 0, 192633419));
				case 14:
					num3 = UtilsPerformance.Ⴀ((Image)bitmap, 606, 639);
					num5 = UtilsCallsign.ႰႤ((Image)bitmap, (short)392, 'Ɗ');
					num = 5;
					continue;
				case 5:
				case 8:
					marshalByRefObject = new GraphicsPath();
					num2 = 0;
					num = 11;
					continue;
				case 10:
					num4 = 0;
					num = ⴃႤ[471] - 21716;
					continue;
				case 2:
					num = (LogFile.Ⴍ(UtilsPerformance.Ⴈ(bitmap, num4, num2, 865, 793), transparencyColor, 'ϭ', 993) ? 17 : 12);
					continue;
				case 12:
					num6 = num4;
					num = ⴃႤ[599] - 5481;
					continue;
				case 0:
					num4++;
					num = 6;
					continue;
				case 6:
				case 15:
					num = ((num4 >= num5) ? 16 : 18);
					continue;
				case 18:
					num = (FrmUpdating.ႠႣ(UtilsPerformance.Ⴈ(bitmap, num4, num2, 874, 786), transparencyColor, ';', 772) ? (ⴃႭ[198] - 52108) : 16);
					continue;
				case 16:
					ServerIoCfg.ႤႥ(marshalByRefObject as GraphicsPath, new Rectangle(num6, num2, num4 - num6, 1), 'ƒ', 'ǹ');
					goto case 17;
				case 17:
					num4++;
					num = 19;
					continue;
				case 19:
					num = ((num4 >= num5) ? 1 : 2);
					continue;
				case 1:
					num2++;
					num = 11;
					continue;
				case 11:
					num = ((num2 < num3) ? (ⴃႤ[391] - 25117) : 13);
					continue;
				case 13:
					disposable = new Region(marshalByRefObject as GraphicsPath);
					goto case 7;
				case 7:
					(marshalByRefObject as GraphicsPath).Dispose();
					return disposable as Region;
				}
				break;
			}
		}
	}

	public void RegisterComboBox(ComboBox comboBox)
	{
		DownloadUrl2.ႥႷ<ComboBox, EventHandler>(comboBox, Ⴄ, 993, '\u0384');
		comboBox.DropDownClosed += Ⴅ;
	}

	private void Ⴄ(object P_0, EventArgs P_1)
	{
		AutoUpdater.ႭႨ(Popup, false, 34, 45);
	}

	private void Ⴅ(object P_0, EventArgs P_1)
	{
		AutoUpdater.ႭႨ(Popup, true, 860, 851);
		NeedsCfg.ႣႤ[14] = (NeedsCfg.ႣႤ[14] + NeedsCfg.ႣႤ[570]) & 0x49;
	}

	[SecuritySafeCritical]
	static DgvBaseFilterHost()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : System.Threading.Timer
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 2;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				continue;
			case 4:
			case 5:
				num = (((P_1 ^ P_2) - 104) ^ num2) switch
				{
					0 => ⴃႭ[26] - 58118, 
					_ => ⴀ[367] - 40515, 
				};
				continue;
			case 1:
			case 7:
				num = 8;
				continue;
			case 0:
				P_0.Dispose();
				goto case 8;
			case 8:
				num2++;
				num3 = 2204;
				num4 = 90;
				break;
			case 3:
				break;
			case 6:
				return;
			}
			int num5 = num3;
			UtilsNumeric.Ⴀ[119] = (char)((UtilsNumeric.Ⴀ[119] | UtilsNumeric.Ⴀ[345]) & 0x4F);
			num = ((551 < num5 / 4 - num4) ? 5 : (ⴗ[114] - 41140));
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, short P_3) where _0021_00210 : Socket
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
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
				num = (((P_2 ^ P_3) - 55) ^ num2) switch
				{
					0 => 9, 
					_ => ⴃႣ[2] - 5260, 
				};
				break;
			case 8:
				num = 3;
				break;
			case 1:
			case 2:
			case 9:
				P_0.NoDelay = P_1;
				goto case 3;
			case 3:
			{
				num2++;
				int num3 = (P_3 * P_3 + P_3) % 2;
				WxCfg.ႣႭ[281] = (char)((WxCfg.ႣႭ[281] ^ P_2) & 0x18);
				num = ((num3 == 0) ? 6 : (ⴃႭ[188] - 1893));
				break;
			}
			case 7:
				num = 4;
				break;
			case 5:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210, _0021_00211, _0021_00212, _0021_00213>(_0021_00212 P_0, _0021_00211 P_1, _0021_00210 P_2, _0021_00213 P_3, short P_4, int P_5) where _0021_00211 : TextWriter where _0021_00212 : XmlSerializer where _0021_00213 : XmlSerializerNamespaces
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႤ[459] - 45429;
				break;
			case 5:
			case 7:
				num = (((P_4 ^ P_5) - 68) ^ num2) switch
				{
					0 => 4, 
					_ => ⴃႣ[143] - 63371, 
				};
				break;
			case 2:
				num = ⴗ[115] - 18167;
				break;
			case 4:
				P_0.Serialize(P_1, P_2, P_3);
				goto case 3;
			case 3:
			{
				num2++;
				int num3 = 594;
				int num4 = 759;
				num = ((3036 <= num4 - num3 * 4) ? 8 : 0);
				break;
			}
			case 8:
				num = 7;
				break;
			case 0:
			case 9:
				WxCfg.ႣႭ[121] = (char)((WxCfg.ႣႭ[121] ^ DataGridViewColumnSelector.Ⴐ[429]) & 0xCC);
				return;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႷႤ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : FileSystemInfo
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		IEquatable<string> equatable = default(IEquatable<string>);
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
					num2 = 0;
					continue;
				case 0:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 76) ^ num) switch
					{
						0 => 4, 
						_ => 10, 
					};
					continue;
				case 10:
					equatable = null;
					num2 = 8;
					continue;
				case 4:
					equatable = P_0.FullName;
					num2 = ⴀ[6] - 34702;
					continue;
				case 1:
				case 8:
					num++;
					num3 = P_1 * P_1;
					goto case 11;
				case 11:
					num3 = P_1 + num3;
					num2 = ⴃႤ[597] - 64621;
					continue;
				case 5:
					num2 = ((num3 % 2 != 0) ? (ⴃႤ[438] - 63512) : 3);
					continue;
				case 3:
					return (string)equatable;
				case 2:
				case 6:
					num2 = ⴃႣ[20] - 44805;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႷႷ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : ReadOnlyCollectionBase
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[15] - 19738;
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
				case 2:
				case 10:
					num2 = (((P_2 ^ P_1) - 68) ^ num) switch
					{
						0 => 1, 
						_ => 4, 
					};
					continue;
				case 4:
					result = P_2;
					num2 = 6;
					continue;
				case 1:
					result = P_0.Count;
					num2 = 6;
					continue;
				case 3:
				case 6:
				{
					num++;
					int num3 = (P_1 * P_1 + P_1) % 2;
					WxCfg.ႣႭ[3] = (char)((WxCfg.ႣႭ[3] - P_1) & 0x26);
					num2 = ((num3 == 0) ? 9 : (ⴃႭ[119] - 58717));
					continue;
				}
				case 8:
					num2 = 2;
					continue;
				case 9:
					return result;
				case 5:
				case 7:
					num2 = ⴗ[148] - 25104;
					continue;
				}
				break;
			}
		}
	}
}
