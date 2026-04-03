using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.Constants;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods.Objects;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class UtilsIdentity
{
	private static bool Ⴈ;

	public static string GetFingerPrint()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		while (true)
		{
			IComparable<string> externalIpAddress = GetExternalIpAddress();
			externalIpAddress = UtilsEmail.Ⴀ((string)externalIpAddress, UtilsString.Ⴐ(null, 6, 192631493), GetUserName(), 661, 707);
			int num = 2;
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
				case 2:
					externalIpAddress = UtilsEmail.Ⴀ(externalIpAddress as string, UtilsString.Ⴐ(null, 5, 192631494), GetUserDomainName(), 937, 1023);
					goto case 5;
				case 5:
					num = ⴀ[134] - 27355;
					continue;
				case 8:
					externalIpAddress = UtilsEmail.Ⴀ((string)externalIpAddress, UtilsString.Ⴐ(null, 1, 192631490), GetProcCount(), 543, 585);
					goto case 7;
				case 7:
					num = ⴀ[114] - 58311;
					continue;
				case 9:
					externalIpAddress = UtilsEmail.Ⴀ(externalIpAddress as string, UtilsString.Ⴐ(null, 8, 192631499), GetMachineName(), 1020, 938);
					num = 0;
					continue;
				case 0:
				case 1:
					externalIpAddress = UtilsEmail.Ⴀ(externalIpAddress as string, UtilsString.Ⴐ(null, 8, 192631499), GetLogicalDrives(), 581, 531);
					num = ⴗ[136] - 24118;
					continue;
				case 6:
					externalIpAddress = (string)externalIpAddress + UtilsString.Ⴐ(null, 4, 192631495) + GetMacAddress();
					num = ⴃႭ[43] - 34340;
					continue;
				case 10:
					return (string)externalIpAddress;
				}
				break;
			}
		}
	}

	public static string GetUserName()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		return DgvBaseColumnFilter.Ⴀ(85, 69);
	}

	public static string GetUserDomainName()
	{
		return TelnetServerClient.Ⴀ('Ϝ', 'Β');
	}

	public static string GetProcCount()
	{
		return CtyInfo.Ⴍ('ɒ', 'ɫ').ToString();
	}

	public static string GetMachineName()
	{
		return GlobalConst.Ⴅ(743, 744);
	}

	public static string GetLogicalDrives()
	{
		string result = UtilsLatLon.Ⴗ('È', 'ý').Length.ToString();
		TalkCfg.ႣႣ[60] = (char)((TalkCfg.ႣႣ[60] ^ TalkCfg.ႣႣ[130]) & 0xEE);
		return result;
	}

	public static string GetExternalIpAddress()
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num2 = default(int);
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			IComparable<string> comparable = DgvTextBoxColumnFilter.Ⴗ(new WebClient(), ႣႼ.ႥႭ(null, 624736144, 2, null), 906, 'ϙ');
			int num = ⴗ[50] - 11840;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2:
					break;
				case 1:
					num2 = DgvCheckBoxColumnFilter.Ⴀ(comparable as string, ႣႼ.ႥႭ(null, 624736123, 4, null), StringComparison.OrdinalIgnoreCase, 335, 'ĸ') + 2;
					goto case 0;
				case 0:
				case 5:
					num = ⴗ[144] - 45242;
					continue;
				case 3:
					convertible = ((string)comparable).Substring(num2, ObjectCopierExt.Ⴓ(comparable as string, DownloadUrl2.Ⴅ(22, null, 2018867786, 7), num2, StringComparison.OrdinalIgnoreCase, 691, 644) - num2);
					num = ⴃႭ[178] - 58282;
					continue;
				case 7:
				{
					string result = (string)convertible;
					NeedsCfg.ႣႤ[362] = NeedsCfg.ႣႤ[362] & NeedsCfg.ႣႤ[357] & 0xB1;
					return result;
				}
				}
				break;
			}
		}
	}

	public static string GetMacAddress()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj2 = default(object);
		while (true)
		{
			IEnumerable enumerable = string.Empty;
			while (true)
			{
				IL_0057:
				object obj = DownloadUrl2.ႥႥ('Ő', 'Ū');
				int num = 0;
				int num2 = ⴀ[387] - 45966;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = 3;
						continue;
					case 0:
					case 3:
						break;
					case 2:
						goto IL_0057;
					case 1:
						obj2 = ((NetworkInterface[])obj)[num];
						num2 = ((Ⴄ((NetworkInterface)obj2, 120, '.') != OperationalStatus.Up) ? (ⴃႤ[317] - 38170) : (ⴐ[168] - 4244));
						continue;
					case 7:
					case 8:
						enumerable = ReverseBeaconClient.Ⴗ((string)enumerable, UtilsString.Ⴍ((object)XmlSerializationHelper.Ⴀ(obj2 as NetworkInterface, 402, 476), 'ˆ', 724), 'ˊ', 'ʂ');
						num2 = 9;
						continue;
					case 4:
						num++;
						num2 = ⴐ[558] - 19591;
						continue;
					case 6:
						num2 = ((num < (obj as NetworkInterface[]).Length) ? 1 : 9);
						continue;
					case 9:
						return (string)enumerable;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static UtilsIdentity()
	{
		Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴐ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				if (Ⴈ)
				{
					return;
				}
				break;
			case 3:
			case 4:
			{
				IReflect typeFromHandle;
				Monitor.Enter(typeFromHandle = typeof(UtilsIdentity));
				try
				{
					int num2 = 0;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = (Ⴈ ? (ⴀ[256] - 37546) : 2);
							continue;
						case 2:
							Ⴈ = true;
							break;
						case 5:
							break;
						case 1:
						case 3:
						case 4:
							goto end_IL_0045;
						}
						AppDomain.CurrentDomain.ResourceResolve += LogFile.Ⴐ;
						num2 = ⴀ[63] - 17152;
						continue;
						end_IL_0045:
						break;
					}
				}
				finally
				{
					Monitor.Exit((Type)typeFromHandle);
				}
				int num3 = 1;
				while (true)
				{
					switch (num3)
					{
					default:
						num3 = 5;
						break;
					case 0:
					case 3:
						/*OpCode not supported: LdMemberToken*/;
						num3 = 5;
						break;
					case 2:
					case 5:
						return;
					}
				}
			}
			}
			num = 3;
		}
	}

	[SecuritySafeCritical]
	internal static Delegate Ⴀ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, char P_3) where _0021_00210 : Delegate where _0021_00211 : Delegate
	{
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = default(object);
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
					num2 = 7;
					continue;
				case 7:
					break;
				case 1:
				case 3:
				case 6:
					num2 = (((P_2 ^ P_3) - 63) ^ num) switch
					{
						0 => 5, 
						_ => 4, 
					};
					continue;
				case 4:
					obj = null;
					num2 = 2;
					continue;
				case 5:
					obj = Delegate.Combine(P_0, P_1);
					num2 = 2;
					continue;
				case 2:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴗ[55] - 6818) : 8);
					continue;
				case 8:
					num2 = 1;
					continue;
				case 10:
				case 11:
					return obj as Delegate;
				case 0:
					num2 = ⴗ[115] - 18169;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static OperationalStatus Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : NetworkInterface
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		OperationalStatus result = default(OperationalStatus);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[106] - 63627;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႤ[111] - 29457;
					continue;
				case 2:
					break;
				case 11:
					num2 = (((P_1 ^ P_2) - 86) ^ num) switch
					{
						0 => 5, 
						_ => 7, 
					};
					continue;
				case 7:
					result = (OperationalStatus)0;
					num2 = 0;
					continue;
				case 5:
					result = P_0.OperationalStatus;
					num2 = 0;
					continue;
				case 0:
					num++;
					num3 = 389;
					num4 = 635;
					goto case 4;
				case 4:
					num2 = ((3175 > num4 - num3 * 5) ? (ⴀ[320] - 27693) : (ⴀ[21] - 21546));
					continue;
				case 9:
					num2 = ⴃႤ[320] - 20174;
					continue;
				case 1:
				case 3:
					return result;
				case 6:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, SizeF P_1, char P_2, short P_3) where _0021_00210 : ContainerControl
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 8;
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
				num = (((P_3 ^ P_2) - 101) ^ num2) switch
				{
					0 => ⴃႣ[176] - 11041, 
					_ => ⴀ[211] - 35367, 
				};
				continue;
			case 7:
				num = 4;
				continue;
			case 5:
				P_0.AutoScaleDimensions = P_1;
				goto case 4;
			case 4:
				num2++;
				break;
			case 2:
				break;
			case 6:
				return;
			}
			int num3 = 1912;
			int num4 = 443;
			num = ((956 >= num3 / 2 - num4) ? 6 : 0);
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : ICredentials where _0021_00211 : WebProxy
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
			{
				num2 = 0;
				char num4 = ⴗ[140];
				DxCfg.Ⴗ[77] = (char)((DxCfg.Ⴗ[77] ^ P_3) & 0x6F);
				num = num4 - 43355;
				break;
			}
			case 5:
				num = (((P_3 ^ P_2) - 12) ^ num2) switch
				{
					0 => ⴃႤ[582] - 44354, 
					_ => ⴃႤ[600] - 48675, 
				};
				break;
			case 1:
			case 9:
				num = ⴃႭ[285] - 39657;
				break;
			case 0:
				P_0.Credentials = P_1;
				goto case 3;
			case 3:
			case 8:
				num2++;
				goto case 6;
			case 6:
			{
				int num3 = 1050;
				num = (((num3 * num3 + num3) % 2 == 0) ? 7 : 2);
				break;
			}
			case 2:
				num = ⴗ[24] - 30800;
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : Socket
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႭ[216] - 27139;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[519] - 58361;
					continue;
				case 1:
				case 10:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 53) ^ num) switch
					{
						0 => ⴗ[51] - 12328, 
						_ => 8, 
					};
					continue;
				case 8:
					result = false;
					num2 = ⴀ[166] - 10212;
					continue;
				case 2:
				case 6:
					result = P_0.Connected;
					num2 = 9;
					continue;
				case 4:
				case 9:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 5 : 7);
					continue;
				case 7:
					num2 = 0;
					continue;
				case 5:
					return result;
				case 3:
					num2 = ⴃႭ[197] - 28511;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : Stream
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
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
				num = 6;
				continue;
			case 6:
				num = (((P_2 ^ P_1) - 97) ^ num2) switch
				{
					0 => ⴃႤ[532] - 51862, 
					_ => 1, 
				};
				continue;
			case 1:
				num = 0;
				continue;
			case 3:
			case 4:
				P_0.Close();
				goto case 0;
			case 0:
				num2++;
				goto case 8;
			case 8:
				num3 = 712;
				num4 = 23;
				break;
			case 7:
				break;
			case 5:
				return;
			}
			num = ((356 < num3 / 2 - num4) ? 6 : 5);
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : AnnWxSpot where _0021_00211 : string
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴐ[112] - 131;
				break;
			case 9:
				num = (((P_3 ^ P_2) - 111) ^ num2) switch
				{
					0 => ⴗ[139] - 41090, 
					_ => ⴀ[191] - 61999, 
				};
				break;
			case 7:
				num = ⴀ[305] - 48558;
				break;
			case 2:
				P_0.Spotter = P_1;
				goto case 3;
			case 3:
				num2++;
				goto case 4;
			case 4:
			{
				int num3 = 124;
				int num4 = 353;
				num = ((1412 > num4 - num3 * 4) ? 8 : (ⴗ[140] - 43354));
				break;
			}
			case 6:
				num = 9;
				break;
			case 1:
			case 5:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴜ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : WwvSpot
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		DateTime result = default(DateTime);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[86] - 41775;
					continue;
				case 4:
					break;
				case 5:
					num2 = (((P_1 ^ P_2) - 18) ^ num) switch
					{
						0 => 9, 
						_ => ⴃႣ[70] - 48569, 
					};
					continue;
				case 3:
				case 6:
					result = default(DateTime);
					goto case 8;
				case 8:
					num2 = 2;
					continue;
				case 9:
					result = P_0.Dts;
					num2 = 2;
					continue;
				case 2:
				case 7:
				{
					num++;
					int num3 = 324;
					int num4 = 5;
					num2 = ((162 < num3 / 2 - num4) ? 5 : 0);
					continue;
				}
				case 0:
					return result;
				case 10:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႤႠ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : DxSpot
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[230] - 37247;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[184] - 34376;
					continue;
				case 4:
					break;
				case 8:
					num2 = (((P_1 ^ P_2) - 27) ^ num) switch
					{
						0 => ⴃႤ[344] - 26227, 
						_ => 9, 
					};
					continue;
				case 9:
					obj = null;
					num2 = 5;
					continue;
				case 7:
					obj = P_0.Cty;
					num2 = ⴃႣ[106] - 63633;
					continue;
				case 5:
					num++;
					goto case 11;
				case 11:
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 2 : 10);
					continue;
				case 1:
				case 10:
					num2 = 8;
					continue;
				case 0:
				case 2:
					return obj as string;
				case 6:
					num2 = ⴃႭ[232] - 45199;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object ႤႤ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DataGridView
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႭ[209] - 32128;
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
				case 8:
					num2 = (((P_2 ^ P_1) - 43) ^ num) switch
					{
						0 => 1, 
						_ => 3, 
					};
					continue;
				case 3:
					result = null;
					goto case 0;
				case 0:
					num2 = 7;
					continue;
				case 1:
				case 9:
					result = P_0.DataSource;
					num2 = ⴀ[198] - 33773;
					continue;
				case 7:
				{
					num++;
					int num3 = 346;
					int num4 = 887;
					num2 = ((2661 > num4 - num3 * 3) ? (ⴃႤ[402] - 56108) : (ⴐ[6] - 53046));
					continue;
				}
				case 2:
					num2 = 8;
					continue;
				case 4:
				case 5:
					return result;
				case 11:
					num2 = ⴐ[169] - 41032;
					continue;
				}
				break;
			}
		}
	}
}
