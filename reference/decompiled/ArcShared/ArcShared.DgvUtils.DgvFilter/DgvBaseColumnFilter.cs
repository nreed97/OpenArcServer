using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using Ⴃ;

namespace ArcShared.DgvUtils.DgvFilter;

public class DgvBaseColumnFilter : UserControl
{
	private CancelEventHandler Ⴅ;

	private VFilterAlignment Ⴍ = VFilterAlignment.Center;

	private HFilterAlignment Ⴐ = HFilterAlignment.Middle;

	private DgvBaseFilterHost Ⴓ;

	private DgvFilterManager Ⴈ;

	private string Ⴜ;

	private string ႥႭ;

	private string ႥႰ;

	private DownloadUrl.Ⴃ ႤႠ;

	internal IContainer Ⴄ;

	internal IContainer Ⴗ;

	internal CheckBox Ⴃ;

	public bool FilterApplySoon
	{
		get
		{
			bool ⴀ = ႤႠ.Ⴀ;
			UtilsNumeric.Ⴀ[90] = (char)((UtilsNumeric.Ⴀ[90] ^ UtilsNumeric.Ⴀ[281]) & 0xD3);
			return ⴀ;
		}
		set
		{
			bool ⴀ = value;
			ႤႠ.Ⴀ = ⴀ;
		}
	}

	public string FilterExpression
	{
		get
		{
			return ႥႭ;
		}
		set
		{
			ႥႭ = value;
		}
	}

	public string FilterCaption
	{
		get
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			char[] ⴃႣ = TalkCfg.ႣႣ;
			while (true)
			{
				int num = ((!ႤႠ.Ⴓ) ? 2 : 7);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴀ[43] - 13275;
						continue;
					case 6:
						break;
					case 7:
						num = (ColumnFilterEventArgs.Ⴀ(ႥႭ, string.Empty, 474, 405) ? (ⴃႣ[2] - 5265) : (ⴃႣ[176] - 11044));
						continue;
					case 1:
					case 2:
						return Ⴜ;
					case 3:
					case 5:
						return ႥႰ;
					}
					break;
				}
			}
		}
		set
		{
			ႥႰ = value;
		}
	}

	public bool Active
	{
		get
		{
			return ႤႠ.Ⴓ;
		}
		set
		{
			bool ⴓ = value;
			ႤႠ.Ⴓ = ⴓ;
		}
	}

	public HFilterAlignment HFilterAlignment
	{
		get
		{
			return Ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	public VFilterAlignment VFilterAlignment
	{
		get
		{
			char[] ⴗ = DxCfg.Ⴗ;
			return Ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	public DataView BoundDataView => ႤႠ.Ⴗ;

	public DgvBaseFilterHost FilterHost
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			return Ⴓ;
		}
	}

	public DgvFilterManager FilterManager
	{
		get
		{
			DgvFilterManager ⴈ = Ⴈ;
			WxCfg.ႣႭ[14] = (char)((WxCfg.ႣႭ[14] | DataGridViewColumnSelector.Ⴐ[75]) & 0xF4);
			return ⴈ;
		}
	}

	public DataGridViewColumn DataGridViewColumn => ႤႠ.Ⴄ;

	public Type ColumnDataType => ႤႠ.Ⴈ;

	public string OriginalDataGridViewColumnHeaderText
	{
		get
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			return Ⴜ;
		}
	}

	public event CancelEventHandler FilterExpressionBuilding
	{
		add
		{
			int num = 3;
			object obj = default(object);
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj = ႤႠ.Ⴐ;
					num = 2;
					break;
				case 2:
					multicastDelegate = obj as CancelEventHandler;
					obj2 = (CancelEventHandler)UtilsIdentity.Ⴀ((Delegate)(CancelEventHandler)multicastDelegate, (Delegate)value, 699, 'ʄ');
					num = 1;
					break;
				case 1:
					obj = Interlocked.CompareExchange(ref ႤႠ.Ⴐ, obj2 as CancelEventHandler, (CancelEventHandler)multicastDelegate);
					num = 7;
					break;
				case 4:
				case 7:
					num = (((object)(CancelEventHandler)obj != (CancelEventHandler)multicastDelegate) ? 2 : 0);
					break;
				case 0:
				case 5:
					return;
				}
			}
		}
		remove
		{
			int num = 0;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj = default(object);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = ႤႠ.Ⴐ;
					num = 3;
					break;
				case 3:
					obj = multicastDelegate as CancelEventHandler;
					goto case 4;
				case 4:
					multicastDelegate2 = (CancelEventHandler)DownloadUrl2.Ⴜ((Delegate)(obj as CancelEventHandler), (Delegate)value, 'ʲ', 'ʈ');
					num = 1;
					break;
				case 1:
					multicastDelegate = Interlocked.CompareExchange(ref ႤႠ.Ⴐ, (CancelEventHandler)multicastDelegate2, (CancelEventHandler)obj);
					num = 7;
					break;
				case 2:
				case 6:
				case 7:
					num = (((object)(CancelEventHandler)multicastDelegate != obj as CancelEventHandler) ? 3 : 5);
					break;
				case 5:
					return;
				}
			}
		}
	}

	public event CancelEventHandler FilterInitializing
	{
		add
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			char[] ⴃႣ = TalkCfg.ႣႣ;
			int num = 1;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj2 = default(object);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = Ⴅ;
					num = 4;
					break;
				case 4:
					obj2 = multicastDelegate as CancelEventHandler;
					goto case 3;
				case 3:
					obj = (CancelEventHandler)UtilsIdentity.Ⴀ((Delegate)(CancelEventHandler)obj2, (Delegate)value, 635, 'Ʉ');
					goto case 2;
				case 2:
				{
					char num2 = ⴃႭ[109];
					NeedsCfg.ႣႤ[86] = NeedsCfg.ႣႤ[86] & NeedsCfg.ႣႤ[50] & 0x73;
					num = num2 - 6066;
					break;
				}
				case 0:
					multicastDelegate = Interlocked.CompareExchange(ref Ⴅ, obj as CancelEventHandler, (CancelEventHandler)obj2);
					num = (((object)(CancelEventHandler)multicastDelegate != obj2 as CancelEventHandler) ? (ⴃႣ[116] - 21531) : (ⴃႤ[193] - 14814));
					break;
				case 5:
				case 6:
					return;
				}
			}
		}
		remove
		{
			char[] ⴗ = DxCfg.Ⴗ;
			int num = 1;
			object obj = default(object);
			object obj2 = default(object);
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					obj = Ⴅ;
					num = ⴗ[31] - 482;
					break;
				case 2:
				case 5:
					obj2 = (CancelEventHandler)obj;
					goto case 3;
				case 3:
				case 6:
					multicastDelegate = (CancelEventHandler)DownloadUrl2.Ⴜ((Delegate)(CancelEventHandler)obj2, (Delegate)value, '\u0091', '«');
					num = 0;
					break;
				case 0:
					obj = Interlocked.CompareExchange(ref Ⴅ, multicastDelegate as CancelEventHandler, obj2 as CancelEventHandler);
					num = (((object)(obj as CancelEventHandler) != obj2 as CancelEventHandler) ? 5 : 4);
					break;
				case 4:
					return;
				}
			}
		}
	}

	public void Init(DgvFilterManager FilterManager, DgvBaseFilterHost FilterHost, DataGridViewColumn gridColumn, DataView boundDataView)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴈ = FilterManager;
				Ⴓ = FilterHost;
				ႤႠ.Ⴄ = gridColumn as DataGridViewColumn;
				num = 2;
				break;
			case 2:
				ႤႠ.Ⴗ = boundDataView;
				Ⴜ = AnnWxSpotExt.Ⴀ(gridColumn, 489, 448);
				goto case 6;
			case 6:
				num = 4;
				break;
			case 4:
			case 7:
				num = (ColumnFilterEventArgs.Ⴀ(UtilsSql.Ⴍ(gridColumn, 288, 275), string.Empty, 834, 781) ? 9 : 0);
				break;
			case 9:
			{
				_Type type = ReverseBeaconClient.Ⴀ(LegalCfg.Ⴅ(LogFile.Ⴅ(ColumnFilterEventArgs.Ⴈ(boundDataView, 226, 160), 946, 'ξ'), UtilsSql.Ⴍ(gridColumn, 893, 846), '\u0085', 213), 64, 99);
				ႤႠ.Ⴈ = (Type)type;
				num = ⴐ[461] - 60541;
				break;
			}
			case 0:
			{
				MemberInfo typeFromHandle = typeof(string);
				ႤႠ.Ⴈ = typeFromHandle as Type;
				num = 5;
				break;
			}
			case 5:
				FilterHost.FilterClientArea.Controls.Add(this);
				FilterHost.Location = new Point(0, 0);
				num = 1;
				break;
			case 1:
			{
				base.Visible = false;
				object obj = new CancelEventArgs(cancel: false);
				OnFilterInitializing(this, (CancelEventArgs)obj);
				return;
			}
			}
		}
	}

	protected virtual void OnFilterInitializing(object sender, CancelEventArgs e)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 0;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((Ⴅ == null) ? 3 : (ⴗ[155] - 49746));
				break;
			case 1:
			case 5:
				ObjectCopierExt.Ⴐ(Ⴅ, sender, e, '}', 'n');
				return;
			case 2:
			case 3:
			case 4:
				return;
			}
			num = num2;
		}
	}

	public void FilterExpressionBuild()
	{
		object obj = new CancelEventArgs(cancel: false);
		OnFilterExpressionBuilding(this, (CancelEventArgs)obj);
	}

	protected virtual void OnFilterExpressionBuilding(object sender, CancelEventArgs e)
	{
		int num = 4;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((ႤႠ.Ⴐ == null) ? 3 : 0);
				break;
			case 0:
			case 1:
				ObjectCopierExt.Ⴐ(ႤႠ.Ⴐ, sender, e, '\u035e', '\u034d');
				return;
			case 3:
			case 5:
				return;
			}
			num = num2;
		}
	}

	public static string StringEscape(string s)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj3 = default(object);
		int num2 = default(int);
		char c = default(char);
		char c2 = default(char);
		while (true)
		{
			object obj = ArcLogInRespExt.Ⴐ(s, 329, 264);
			object obj2 = new StringBuilder(UtilsCallsign.Ⴓ(s, 1018, 973) * 2);
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 4;
					continue;
				case 4:
					break;
				case 5:
					obj3 = obj as char[];
					num2 = 0;
					goto case 14;
				case 14:
					num = ⴀ[19] - 12898;
					continue;
				case 15:
					c = (obj3 as char[])[num2];
					c2 = c;
					num = c2 switch
					{
						'%' => 7, 
						'&' => 11, 
						'\'' => ⴀ[28] - 35536, 
						_ => 10, 
					};
					continue;
				case 3:
				case 10:
					num = ((c2 == '*') ? 7 : (ⴃႭ[154] - 9359));
					continue;
				case 6:
				{
					int num3;
					switch (c2)
					{
					default:
						num3 = 13;
						break;
					case '[':
						num3 = ⴃႣ[32] - 44000;
						break;
					case '\\':
					{
						char num4 = ⴃႣ[184];
						TalkCfg.ႣႣ[137] = (char)((TalkCfg.ႣႣ[137] + UtilsNumeric.Ⴀ[161]) & 0x8E);
						num3 = num4 - 34369;
						break;
					}
					case ']':
						num3 = 7;
						break;
					}
					num = num3;
					continue;
				}
				case 13:
					num = 11;
					continue;
				case 7:
					DgvFilterHost.ႥႨ(obj2 as StringBuilder, DxAtlasData.Ⴄ((object)TelnetServerClient.Ⴄ(1945322697, 'v', 5), (object)c, (object)ႣႼ.ႥႭ(null, 624736250, 4, null), 445, 'ǒ'), 1013, 'ϕ');
					num = 2;
					continue;
				case 0:
					DgvFilterHost.ႥႨ(obj2 as StringBuilder, ႣႼ.Ⴜ(6, 365387211, 16), 114, 'R');
					goto case 9;
				case 9:
					num = 2;
					continue;
				case 11:
					((StringBuilder)obj2).Append(c);
					num = 2;
					continue;
				case 2:
					num2++;
					num = ⴃႭ[79] - 47128;
					continue;
				case 8:
					num = ((num2 >= (obj3 as char[]).Length) ? 1 : 15);
					continue;
				case 1:
					return ((StringBuilder)obj2).ToString();
				}
				break;
			}
		}
	}

	public static string FormatValue(object value, Type targetType)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		while (ObjectCopierExt.Ⴈ(targetType, typeof(string), 'Ĝ', 'ĸ'))
		{
			int num = ⴃႤ[103] - ⴃႤ[103];
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 4;
					continue;
				case 4:
				case 5:
					break;
				case 0:
				case 2:
					return UtilsEmail.Ⴀ(TelnetServerClient.Ⴄ(1945322701, 'k', 5), UtilsString.Ⴍ(value, '\u0353', 833), TelnetServerClient.Ⴄ(1945322696, '\u001c', 0), 422, 496);
				}
				break;
			}
		}
		IComparable<string> empty = default(IComparable<string>);
		try
		{
			value = UtilsCallsign.Ⴐ(value, targetType, '¡', 253);
		}
		catch
		{
			empty = string.Empty;
			goto IL_01c5;
		}
		int num2 = 9;
		while (true)
		{
			switch (num2)
			{
			default:
				num2 = ((!ObjectCopierExt.Ⴈ(targetType, typeof(bool), 'ȃ', 'ȧ')) ? 6 : 8);
				continue;
			case 8:
				num2 = ((!(bool)value) ? 1 : (ⴐ[98] - 35680));
				continue;
			case 1:
			case 10:
				return UtilsString.Ⴐ(null, 2, 192631393);
			case 0:
				return UtilsString.Ⴐ(null, 6, 192631417);
			case 6:
				num2 = ((!ObjectCopierExt.Ⴈ(targetType, typeof(DateTime), 'ˣ', 'ˇ')) ? 5 : 7);
				continue;
			case 2:
			case 7:
				return TelnetServerClient.Ⴄ(1945322701, '?', 5) + ((DateTime)value).ToString(ႣႼ.ႥႭ(null, 624736236, 6, null)) + TelnetServerClient.Ⴄ(1945322696, '§', 0);
			case 3:
			case 5:
				return ((IFormattable)value).ToString(null, NumberFormatInfo.InvariantInfo);
			case 4:
				break;
			}
			break;
		}
		goto IL_01c5;
		IL_01c5:
		return (string)empty;
	}

	public static string GetNullCondition(string DataColumnName)
	{
		return UtilsEmail.Ⴀ(DownloadUrl2.Ⴅ(11, null, 2018867798, 5), DataColumnName, UtilsString.Ⴐ(null, 4, 192631423), 629, 547);
	}

	public static string GetNotNullCondition(string DataColumnName)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		return UtilsEmail.Ⴀ(DownloadUrl2.Ⴅ(9, null, 2018867796, 7), DataColumnName, ArcLogInRqstExt.Ⴗ(1706507156, 7, 3), 17, 71);
	}

	public DgvBaseColumnFilter()
	{
		ႤႠ.Ⴀ = true;
		ႥႭ = string.Empty;
		ႥႰ = string.Empty;
		base._002Ector();
	}

	[SecuritySafeCritical]
	static DgvBaseColumnFilter()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static string Ⴀ(short P_0, int P_1)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		ICloneable cloneable = default(ICloneable);
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
					num2 = 2;
					continue;
				case 2:
					break;
				case 1:
					num2 = (((P_0 ^ P_1) - 16) ^ num) switch
					{
						0 => ⴃႣ[2] - 5261, 
						_ => 6, 
					};
					continue;
				case 6:
					cloneable = null;
					num2 = ⴃႣ[114] - 1584;
					continue;
				case 7:
				case 8:
					cloneable = Environment.UserName;
					num2 = 11;
					continue;
				case 11:
					num++;
					num3 = P_0 * P_0;
					num3 = P_0 + num3;
					num2 = ⴐ[241] - 18678;
					continue;
				case 3:
				case 10:
					num2 = ((num3 % 2 != 0) ? 1 : 4);
					continue;
				case 4:
					return cloneable as string;
				case 5:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႨႠ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : Version
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[221] - 59522;
					continue;
				case 7:
					break;
				case 2:
				case 6:
					NeedsCfg.ႣႤ[88] = (NeedsCfg.ႣႤ[88] + P_2) & 0x74;
					num2 = (((P_1 ^ P_2) - 103) ^ num) switch
					{
						0 => 4, 
						_ => ⴃႭ[13] - 37426, 
					};
					continue;
				case 9:
					result = P_2;
					goto case 0;
				case 0:
					num2 = 5;
					continue;
				case 4:
				case 8:
					result = P_0.Build;
					num2 = 5;
					continue;
				case 5:
				{
					num++;
					int num3 = 368;
					int num4 = 124;
					num2 = ((184 < num3 / 2 - num4) ? 6 : 3);
					continue;
				}
				case 3:
					return result;
				case 10:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႨႨ(int P_0, int P_1, int P_2, char P_3)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int result = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			char num2 = ⴀ[145];
			WxCfg.ႣႭ[252] = (char)((WxCfg.ႣႭ[252] - P_2) & 0x6B);
			int num3 = num2 - 39610;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = 5;
					continue;
				case 5:
					break;
				case 11:
					num3 = (((P_3 ^ P_2) - 109) ^ num) switch
					{
						0 => 3, 
						_ => 6, 
					};
					continue;
				case 0:
				case 6:
					result = P_0;
					num3 = 2;
					continue;
				case 3:
					result = Math.Max(P_0, P_1);
					num3 = 2;
					continue;
				case 2:
				case 9:
					num++;
					num4 = P_3 * P_3;
					num4 = P_3 + num4;
					num3 = 8;
					continue;
				case 7:
				case 8:
					num3 = ((num4 % 2 != 0) ? 11 : 10);
					continue;
				case 10:
					return result;
				case 4:
					num3 = ⴃႤ[557] - 53623;
					continue;
				}
				break;
			}
		}
	}
}
