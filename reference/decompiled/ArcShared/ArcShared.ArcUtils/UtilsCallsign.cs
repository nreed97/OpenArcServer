using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Extensions;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.Forms;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class UtilsCallsign
{
	internal sealed class Ⴄ
	{
		internal Guid Ⴅ;

		internal string Ⴗ;

		internal string Ⴀ;

		internal string Ⴈ;

		internal string Ⴐ;

		internal string Ⴍ;

		internal string Ⴄ;

		internal string Ⴃ;

		internal Ⴄ()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴗ
	{
		internal IContainer Ⴄ;
	}

	internal sealed class Ⴀ
	{
		internal OutputType Ⴍ;

		internal Ⴀ()
		{
		}
	}

	public static bool IsValidCall(string call)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		while (true)
		{
			int num = ((Ⴓ(call, 97, 86) < 3) ? (ⴀ[179] - 61942) : (ⴃႤ[90] - 11451));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴐ[36] - 7443;
					continue;
				case 10:
				case 11:
					break;
				case 4:
					num = ((Ⴓ(call, 93, 106) <= 12) ? (ⴃႤ[210] - 27370) : 14);
					continue;
				case 14:
					return false;
				case 26:
					num = ((AnnWxSpotExt.Ⴅ(call, 0, 206, 245) == '-') ? (ⴃႭ[177] - 31780) : 23);
					continue;
				case 23:
					num = ((AnnWxSpotExt.Ⴅ(call, 0, 470, 493) == 'Q') ? 1 : (ⴐ[237] - 23082));
					continue;
				case 1:
					return false;
				case 13:
					num = ((!UtilsNumeric.IsNumeric(call)) ? 21 : (ⴐ[520] - 5390));
					continue;
				case 7:
					return false;
				case 21:
					num = ((Ⴓ(call, 212, 227) != 8) ? 24 : 3);
					continue;
				case 3:
					num = ((!FrmUpdating.ႠႥ(UtilsLatLon.Ⴜ(call, 0, 4, 183, 151), UtilsLatLon.Ⴜ(call, 4, 4, 820, 788), 201, 245)) ? 24 : (ⴃႭ[216] - 27122));
					continue;
				case 17:
					return false;
				case 24:
					num = ((Ⴓ(call, 1006, 985) != 10) ? 20 : (ⴗ[28] - 12109));
					continue;
				case 15:
					num = ((!FrmUpdating.ႠႥ(UtilsLatLon.Ⴜ(call, 0, 5, 321, 353), UtilsLatLon.Ⴜ(call, 5, 5, 701, 669), 343, 363)) ? 20 : (ⴃႣ[239] - 39433));
					continue;
				case 19:
					return false;
				case 20:
					num = ((!AutoUpdater.ႨႰ(call, ႣႼ.ႥႭ(call, 624735388, 2, null), 958, 'ϗ')) ? 5 : (ⴐ[38] - 2384));
					continue;
				case 12:
				case 18:
					return false;
				case 5:
					num = ((!call.StartsWith(ArcLogInRqstExt.Ⴗ(1706507596, 16, 5))) ? (ⴐ[196] - 11168) : (ⴗ[12] - 35066));
					continue;
				case 25:
					return false;
				case 6:
					num = ((!call.StartsWith(ႣႼ.ႥႭ(null, 624735378, 3, null))) ? 8 : 9);
					continue;
				case 9:
					return false;
				case 8:
					num = ((!Regex.IsMatch(call, ArcLogInRqstExt.Ⴗ(1706507606, 30, 7))) ? (ⴃႤ[315] - 16723) : 16);
					continue;
				case 16:
					return !Regex.IsMatch(call, TelnetServerClient.Ⴄ(1945322769, '<', 4));
				case 0:
					return false;
				}
				break;
			}
		}
	}

	public static string GetNoSsidCall(string call)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			int num = ColumnFilterEventArgs.Ⴍ(call, DownloadUrl2.Ⴅ(4, null, 2018868053, 0), 602, 607);
			while (true)
			{
				IL_0069:
				int num2 = ⴗ[25] - 18239;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = ⴃႭ[249] - 12438;
						continue;
					case 4:
						break;
					case 7:
						goto IL_0069;
					case 1:
						num2 = ((num <= 0) ? 6 : (ⴃႭ[173] - 11200));
						continue;
					case 0:
					case 3:
					case 5:
						return UtilsLatLon.Ⴜ(call, 0, num, 453, 485);
					case 6:
						return call;
					}
					break;
				}
				break;
			}
		}
	}

	public static bool CallHasSsid(string call)
	{
		while (true)
		{
			int num = ColumnFilterEventArgs.Ⴍ(call, DownloadUrl2.Ⴅ(16, null, 2018868048, 5), 688, 694);
			while (true)
			{
				IL_0049:
				int num2 = 4;
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
					case 2:
					case 5:
						goto IL_0049;
					case 3:
					case 4:
						return num > 0;
					}
					break;
				}
				break;
			}
		}
	}

	public static string CallsignNormalization(string call)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IEquatable<string> equatable = default(IEquatable<string>);
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			call = ScrubCall(call);
			int num = ColumnFilterEventArgs.Ⴍ(call, ႣႼ.ႥႭ(call, 624735377, 0, null), 207, 202);
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 7:
				case 9:
					break;
				case 5:
					num2 = ((num <= -1) ? 11 : 10);
					continue;
				case 10:
					equatable = UtilsLatLon.Ⴜ(call, 0, num, 494, 462);
					cloneable = UtilsLatLon.Ⴜ(call, num + 1, Ⴓ(call, 62, 9) - num - 1, 330, 362);
					num2 = 0;
					continue;
				case 0:
					num2 = ((Ⴓ((string)cloneable, 216, 239) <= 0) ? 12 : (ⴀ[13] - 62460));
					continue;
				case 4:
				case 6:
					num2 = (((equatable as string).Length <= ((string)cloneable).Length) ? 12 : 8);
					continue;
				case 8:
					num2 = (UtilsNumeric.IsNumeric(cloneable as string) ? (ⴀ[225] - 22431) : (ⴐ[132] - 38105));
					continue;
				case 2:
				case 3:
					return (string)cloneable;
				case 12:
					return (string)equatable;
				case 11:
					return call;
				}
				break;
			}
		}
	}

	public static string ScrubCall(string call)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		while (true)
		{
			int num = ((ColumnFilterEventArgs.Ⴍ(call, ႣႼ.ႥႭ(null, 624735382, 7, null), 307, 310) <= -1) ? 7 : 6);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 3:
					break;
				case 6:
					num = ((!HelpAboutServer.ႷႰ(call, DownloadUrl2.Ⴅ(11, null, 2018869098, 2), 724, 667)) ? 24 : 20);
					continue;
				case 20:
					return UtilsLatLon.Ⴜ(call, 0, Ⴓ(call, 183, 128) - 2, 52, 20);
				case 24:
					num = ((!HelpAboutServer.ႷႰ(call, TelnetServerClient.Ⴄ(1945322789, '=', 1), 350, 273)) ? 8 : 5);
					continue;
				case 5:
					return UtilsLatLon.Ⴜ(call, 0, Ⴓ(call, 315, 268) - 2, 936, 904);
				case 8:
					num = ((!HelpAboutServer.ႷႰ(call, ArcLogInRqstExt.Ⴗ(1706507618, 30, 1), 62, 113)) ? 22 : (ⴃႤ[33] - 51704));
					continue;
				case 4:
					return UtilsLatLon.Ⴜ(call, 0, Ⴓ(call, 639, 584) - 2, 678, 646);
				case 22:
					num = ((!HelpAboutServer.ႷႰ(call, UtilsString.Ⴐ(null, 1, 192633738), 338, 285)) ? (ⴗ[152] - 36434) : 23);
					continue;
				case 23:
					return UtilsLatLon.Ⴜ(call, 0, Ⴓ(call, 574, 521) - 2, 611, 579);
				case 10:
				case 15:
					num = ((!HelpAboutServer.ႷႰ(call, ႣႼ.Ⴜ(3, 365386029, 9), 220, 147)) ? (ⴃႤ[492] - 44140) : 28);
					continue;
				case 25:
				case 28:
					return UtilsLatLon.Ⴜ(call, 0, Ⴓ(call, 349, 362) - 2, 45, 13);
				case 11:
				case 26:
					num = ((!HelpAboutServer.ႷႰ(call, ႣႼ.ႥႭ(call, 624735382, 3, null), 869, 810)) ? 27 : 14);
					continue;
				case 14:
					return UtilsLatLon.Ⴜ(call, 0, Ⴓ(call, 560, 519) - 2, 868, 836);
				case 27:
					num = ((!HelpAboutServer.ႷႰ(call, DownloadUrl2.Ⴅ(24, null, 2018869009, 2), 27, 84)) ? (ⴃႣ[142] - 62647) : 12);
					continue;
				case 12:
					return UtilsLatLon.Ⴜ(call, 0, Ⴓ(call, 184, 143) - 2, 220, 252);
				case 9:
					num = ((!call.EndsWith(TelnetServerClient.Ⴄ(1945322785, 'Ô', 0))) ? 13 : 0);
					continue;
				case 0:
					return call.Substring(0, call.Length - 2);
				case 13:
					num = ((!call.EndsWith(ArcLogInRqstExt.Ⴗ(1706507627, 6, 3))) ? 17 : 2);
					continue;
				case 2:
					return call.Substring(0, call.Length - 3);
				case 17:
					num = ((!call.EndsWith(UtilsString.Ⴐ(null, 3, 192633733))) ? (ⴃႭ[160] - 23637) : 16);
					continue;
				case 16:
					return call.Substring(0, call.Length - 4);
				case 21:
					num = (call.EndsWith(ႣႼ.Ⴜ(2, 365386023, 24)) ? 1 : 19);
					continue;
				case 1:
					return call.Substring(0, call.Length - 4);
				case 19:
					return call;
				case 7:
					return call;
				}
				break;
			}
		}
	}

	public static string ScrubTelnetControlChars(string msg)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		while (true)
		{
			object obj = DgvFreqRangeColumnFilter.ႣႳ(msg, ႣႼ.Ⴜ(3, 365386041, 30), string.Empty, 792, 810);
			while (true)
			{
				IL_0068:
				int num = ⴃႭ[17] - 6316;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴗ[155] - ⴗ[155];
						continue;
					case 0:
					case 2:
						break;
					case 4:
						goto IL_0068;
					case 1:
					case 3:
						return (string)obj;
					}
					break;
				}
				break;
			}
		}
	}

	public static int GetFirstNumberFromCall(string call)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char c = default(char);
		while (true)
		{
			int num = 0;
			while (true)
			{
				IL_005d:
				int num2 = ⴃႤ[221] - 30811;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = ⴀ[35] - 1097;
						continue;
					case 0:
					case 7:
						break;
					case 5:
						goto IL_005d;
					case 4:
						c = AnnWxSpotExt.Ⴅ(call, num, 434, 393);
						num2 = ((!UtilsNumeric.IsNumeric(c)) ? (ⴀ[381] - 35972) : 8);
						continue;
					case 1:
					case 8:
					{
						IConvertible convertible = ႰႣ.Ⴀ((object)string.Empty, (object)c, (short)62, 124);
						return StationCfg.ႭႰ((string)convertible, 493, 'Ƃ');
					}
					case 9:
						num++;
						num2 = ⴐ[443] - 42159;
						continue;
					case 3:
						num2 = ((num < call.Length) ? 4 : 2);
						continue;
					case 2:
						return 0;
					}
					break;
				}
				break;
			}
		}
	}

	public static bool IsWebBrowserOrJunk(string call)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			int num = ((!AutoUpdater.ႨႰ(call, ArcLogInRqstExt.Ⴗ(1706507634, 5, 4), 0, 'h')) ? 6 : 2);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 4;
					continue;
				case 4:
				case 8:
					break;
				case 2:
					num = ((!AutoUpdater.ႨႰ(call, TelnetServerClient.Ⴄ(1945322811, '\u0085', 5), 737, 'ʉ')) ? 6 : (ⴗ[94] - 22934));
					continue;
				case 5:
					return true;
				case 6:
					num = (AutoUpdater.ႨႰ(call, ႣႼ.Ⴜ(5, 365385931, 18), 268, 'Ť') ? 7 : 3);
					continue;
				case 3:
					num = ((!call.Contains(UtilsString.Ⴐ(null, 7, 192633752))) ? (ⴗ[47] - 59001) : 7);
					continue;
				case 0:
				case 7:
					return true;
				case 10:
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static UtilsCallsign()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static int Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[122] - 49711;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[102] - 41114;
					continue;
				case 1:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 55) ^ num) switch
					{
						0 => ⴃႤ[159] - 6842, 
						_ => ⴗ[75] - 9526, 
					};
					continue;
				case 7:
				case 11:
					result = P_1;
					num2 = 0;
					continue;
				case 3:
				case 9:
					result = P_0.Length;
					num2 = 0;
					continue;
				case 0:
				{
					num++;
					int num3 = 52;
					int num4 = 207;
					num2 = ((1035 > num4 - num3 * 5) ? 10 : 2);
					continue;
				}
				case 2:
				case 5:
					num2 = 8;
					continue;
				case 10:
					return result;
				case 6:
					num2 = ⴐ[344] - 34343;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴐ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00211 : Type
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
				{
					/*OpCode not supported: LdMemberToken*/;
					char num3 = ⴃႣ[203];
					TalkCfg.ႣႣ[158] = (char)((TalkCfg.ႣႣ[158] - P_3) & 0xD8);
					num2 = num3 - 38804;
					continue;
				}
				case 7:
					break;
				case 8:
					num2 = (((P_2 ^ P_3) - 92) ^ num) switch
					{
						0 => ⴃႣ[234] - 20663, 
						_ => 11, 
					};
					continue;
				case 11:
					result = null;
					num2 = ⴃႭ[106] - 59653;
					continue;
				case 3:
					result = Convert.ChangeType(P_0, P_1);
					num2 = ⴐ[519] - 58352;
					continue;
				case 2:
				case 10:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? 5 : (ⴗ[53] - ⴗ[53]));
					continue;
				case 0:
					num2 = ⴀ[331] - 15972;
					continue;
				case 5:
				case 6:
				case 9:
					return result;
				case 1:
					num2 = ⴃႣ[166] - 48245;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Thread Ⴍ(int P_0, char P_1)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object obj = default(object);
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
					num2 = ⴃႤ[371] - 32788;
					continue;
				case 9:
					break;
				case 2:
					num2 = (((P_0 ^ P_1) - 32) ^ num) switch
					{
						0 => ⴃႭ[237] - 11580, 
						_ => ⴗ[59] - 8068, 
					};
					continue;
				case 4:
				case 6:
					obj = null;
					num2 = ⴐ[413] - 17624;
					continue;
				case 1:
					obj = Thread.CurrentThread;
					num2 = ⴐ[201] - 20813;
					continue;
				case 5:
				{
					num++;
					int num3 = 2958;
					int num4 = 143;
					num2 = ((986 < num3 / 3 - num4) ? (ⴐ[478] - 64204) : 10);
					continue;
				}
				case 10:
					return (Thread)obj;
				case 7:
				case 8:
					num2 = ⴃႤ[300] - 12199;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : Form where _0021_00211 : Form
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 6;
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴐ[268] - 57299;
				break;
			case 4:
				num = (((P_3 ^ P_2) - 108) ^ num3) switch
				{
					0 => 7, 
					_ => 9, 
				};
				break;
			case 9:
				num = ⴗ[12] - 35086;
				break;
			case 7:
				P_0.Owner = P_1;
				goto case 3;
			case 3:
			case 5:
			{
				int num2 = num3;
				DataGridViewColumnSelector.Ⴐ[389] = (char)((DataGridViewColumnSelector.Ⴐ[389] | P_2) & 0x40);
				num3 = num2 + 1;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? 2 : 8);
				break;
			}
			case 8:
				num = ⴃႣ[19] - 59487;
				break;
			case 0:
			case 1:
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Cursor Ⴃ(int P_0, char P_1)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[25] - 18240;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[63] - 17149;
					continue;
				case 2:
				case 4:
					break;
				case 0:
					num2 = (((P_0 ^ P_1) - 25) ^ num) switch
					{
						0 => 8, 
						_ => ⴐ[68] - 10440, 
					};
					continue;
				case 5:
					obj = null;
					num2 = ⴀ[144] - 46013;
					continue;
				case 8:
					obj = Cursors.Default;
					num2 = 10;
					continue;
				case 9:
				case 10:
				{
					num++;
					int num3 = 624;
					int num4 = 221;
					num2 = ((312 < num3 / 2 - num4) ? (ⴀ[132] - 32886) : (ⴃႭ[161] - 54234));
					continue;
				}
				case 3:
				case 7:
					return (Cursor)obj;
				case 1:
					num2 = ⴐ[333] - 28077;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DialogResult Ⴅ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : Form
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		DialogResult result = default(DialogResult);
		while (true)
		{
			int num = 0;
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[260] - 31180;
					continue;
				case 0:
					break;
				case 3:
				case 4:
					num2 = (((P_1 ^ P_2) - 45) ^ num) switch
					{
						0 => 7, 
						_ => 9, 
					};
					continue;
				case 5:
				case 9:
					result = DialogResult.None;
					num2 = ⴗ[71] - 6956;
					continue;
				case 7:
					result = P_0.ShowDialog();
					num2 = 10;
					continue;
				case 10:
				{
					int num3 = num;
					NeedsCfg.ႣႤ[14] = (NeedsCfg.ႣႤ[14] * WxCfg.ႣႭ[35]) & 0x66;
					num = num3 + 1;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴃႭ[225] - 59540) : (ⴃႣ[83] - 56476));
					continue;
				}
				case 8:
					num2 = ⴃႤ[364] - 11224;
					continue;
				case 2:
					return result;
				case 11:
					num2 = ⴃႤ[232] - 11094;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴜ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DxSpot
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 11;
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
				case 11:
					num2 = (((P_2 ^ P_1) - 76) ^ num) switch
					{
						0 => 4, 
						_ => ⴀ[383] - 63906, 
					};
					continue;
				case 5:
					obj = null;
					num2 = ⴃႣ[116] - 21525;
					continue;
				case 2:
				case 3:
				case 4:
					obj = P_0.Spotter;
					num2 = 10;
					continue;
				case 10:
				{
					num++;
					int num3 = P_2 * P_2 + P_2;
					NeedsCfg.ႣႤ[519] = (NeedsCfg.ႣႤ[519] ^ WxCfg.ႣႭ[277]) & 0x6E;
					num2 = ((num3 % 2 == 0) ? (ⴃႤ[304] - 42600) : (ⴀ[390] - ⴀ[390]));
					continue;
				}
				case 0:
				case 8:
					num2 = ⴀ[316] - 45305;
					continue;
				case 1:
					return obj as string;
				case 9:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static CheckedListBox.ObjectCollection ႰႳ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : CheckedListBox
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[363] - 27682;
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
				case 1:
					num2 = (((P_2 ^ P_1) - 81) ^ num) switch
					{
						0 => 8, 
						_ => 11, 
					};
					continue;
				case 11:
					obj = null;
					num2 = ⴃႣ[102] - 27329;
					continue;
				case 8:
					obj = P_0.Items;
					num2 = 0;
					continue;
				case 0:
				case 7:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 3;
				case 3:
					num2 = 4;
					continue;
				case 4:
					num2 = ((num3 % 2 != 0) ? (ⴐ[245] - 13575) : 2);
					continue;
				case 2:
				case 9:
					return obj as CheckedListBox.ObjectCollection;
				case 6:
					num2 = ⴐ[363] - 27682;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႰႰ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : ToolStripDropDownClosedEventHandler where _0021_00211 : ToolStripDropDown
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 0;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				continue;
			case 1:
			case 4:
				num = (((P_3 ^ P_2) - 45) ^ num2) switch
				{
					0 => ⴀ[113] - 11629, 
					_ => 5, 
				};
				continue;
			case 5:
				num = 6;
				continue;
			case 3:
				P_0.Closed += P_1;
				goto case 6;
			case 6:
				num2++;
				num3 = 992;
				break;
			case 7:
				break;
			case 8:
				return;
			}
			int num4 = 30;
			num = ((496 < num3 / 2 - num4) ? 4 : (ⴗ[139] - 41084));
		}
	}

	[SecuritySafeCritical]
	internal static int ႰႤ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : Image
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int result = default(int);
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
					num2 = 1;
					continue;
				case 1:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 2) ^ num) switch
					{
						0 => 0, 
						_ => ⴗ[8] - 15536, 
					};
					continue;
				case 2:
					result = 13;
					num2 = 6;
					continue;
				case 0:
				case 8:
					result = P_0.Width;
					num2 = 6;
					continue;
				case 6:
				{
					num++;
					int num3 = 2487;
					int num4 = 420;
					num2 = ((829 < num3 / 3 - num4) ? 7 : (ⴃႣ[228] - 10048));
					continue;
				}
				case 10:
					return result;
				case 4:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataGridViewColumn ႰႷ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, char P_3) where _0021_00210 : DataGridViewColumnCollection
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		DataGridViewBand dataGridViewBand = default(DataGridViewBand);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[74] - 30233;
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
				case 4:
					num2 = (((P_2 ^ P_3) - 2) ^ num) switch
					{
						0 => ⴃႤ[427] - 50426, 
						_ => 1, 
					};
					continue;
				case 1:
					dataGridViewBand = null;
					num2 = ⴃႣ[203] - 38802;
					continue;
				case 6:
				case 10:
					dataGridViewBand = P_0[P_1];
					num2 = 9;
					continue;
				case 9:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 0;
					continue;
				case 0:
					num2 = ((num3 % 2 != 0) ? 4 : 7);
					continue;
				case 7:
				case 8:
					return dataGridViewBand as DataGridViewColumn;
				case 3:
				case 5:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}
}
