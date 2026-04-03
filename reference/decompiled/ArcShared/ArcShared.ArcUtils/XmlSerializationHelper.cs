using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Security;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class XmlSerializationHelper
{
	public static string Serialize<T>(this T value)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			object obj = new XmlSerializer(typeof(T));
			object obj2 = new StringWriter();
			object obj3 = new XmlSerializerNamespaces();
			DgvComboBoxColumnFilter.Ⴓ(obj3 as XmlSerializerNamespaces, ႣႼ.ႥႭ(null, 624735558, 1, null), DownloadUrl2.Ⴅ(13, null, 2018867640, 6), 'ľ', 'ū');
			while (true)
			{
				IL_0083:
				int num = ⴗ[121] - 2886;
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
						goto IL_0083;
					case 4:
					case 6:
						DgvBaseFilterHost.Ⴜ(obj as XmlSerializer, (TextWriter)(StringWriter)obj2, (object)value, (XmlSerializerNamespaces)obj3, (short)821, 881);
						num = 5;
						continue;
					case 5:
						return (obj2 as StringWriter).ToString();
					}
					break;
				}
				break;
			}
		}
	}

	public static T Deserialize<T>(this string rawValue)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		while (true)
		{
			object obj = new XmlSerializer(typeof(T));
			while (true)
			{
				IL_0043:
				TextReader textReader = new StringReader(rawValue);
				while (true)
				{
					IL_004a:
					T result = (T)ReverseBeaconClient.Ⴅ((XmlSerializer)obj, (TextReader)(textReader as StringReader), '\u02dc', 652);
					int num = ⴀ[12] - 15405;
					while (true)
					{
						switch (num)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							num = 1;
							continue;
						case 1:
							break;
						case 0:
							goto IL_0043;
						case 5:
							goto IL_004a;
						case 4:
							return result;
						}
						break;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static XmlSerializationHelper()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static PhysicalAddress Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : NetworkInterface
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[142] - 62648;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႤ[211] - 10162;
					continue;
				case 6:
					break;
				case 8:
					num2 = (((P_1 ^ P_2) - 78) ^ num) switch
					{
						0 => 2, 
						_ => ⴃႣ[166] - 48244, 
					};
					continue;
				case 0:
				case 9:
					obj = null;
					num2 = ⴗ[27] - 88;
					continue;
				case 2:
				case 10:
					obj = P_0.GetPhysicalAddress();
					num2 = ⴃႣ[215] - 32473;
					continue;
				case 1:
				case 7:
				{
					num++;
					int num3 = 667;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? 3 : 11);
					continue;
				}
				case 11:
					num2 = ⴃႭ[196] - 49764;
					continue;
				case 3:
					return obj as PhysicalAddress;
				case 5:
					num2 = ⴃႭ[221] - 31241;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : XmlSerializer where _0021_00211 : XmlReader
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[19] - 27385;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
					break;
				case 9:
					num2 = (((P_3 ^ P_2) - 91) ^ num) switch
					{
						0 => ⴀ[63] - 17146, 
						_ => 2, 
					};
					continue;
				case 2:
					result = null;
					num2 = 8;
					continue;
				case 5:
				case 7:
					result = P_0.Deserialize(P_1);
					num2 = ⴐ[179] - 53078;
					continue;
				case 8:
				{
					num++;
					int num3 = 86;
					int num4 = 256;
					num2 = ((768 > num4 - num3 * 3) ? 11 : (ⴃႭ[6] - 63050));
					continue;
				}
				case 4:
				case 10:
					num2 = 9;
					continue;
				case 11:
					return result;
				case 1:
				case 6:
					num2 = ⴗ[139] - 41083;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : FileSystemWatcher where _0021_00211 : FileSystemEventHandler
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 2;
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = 7;
				break;
			case 7:
				num = (((P_2 ^ P_3) - 28) ^ num4) switch
				{
					0 => ⴗ[80] - 32456, 
					_ => 3, 
				};
				break;
			case 3:
			case 4:
				num = 6;
				break;
			case 5:
				P_0.Created += P_1;
				goto case 1;
			case 1:
			case 6:
			{
				num4++;
				num3 = 1794;
				int num5 = num3;
				num2 = num5 * num5;
				num = ⴃႭ[222] - 35845;
				break;
			}
			case 8:
				num2 = num3 + num2;
				num = ((num2 % 2 != 0) ? 7 : 9);
				break;
			case 0:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static TimeSpan Ⴅ(ref DateTime P_0, DateTime P_1, int P_2, int P_3)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		TimeSpan result = default(TimeSpan);
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 0:
					num2 = (((P_3 ^ P_2) - 20) ^ num) switch
					{
						0 => 3, 
						_ => ⴀ[12] - 15408, 
					};
					continue;
				case 1:
				case 8:
				case 9:
					result = default(TimeSpan);
					num2 = ⴗ[92] - 39178;
					continue;
				case 3:
					result = P_0.Subtract(P_1);
					num2 = ⴃႭ[138] - 10811;
					continue;
				case 6:
				{
					num++;
					int num3 = 1600;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? 4 : (ⴃႣ[119] - 27086));
					continue;
				}
				case 2:
					num2 = 0;
					continue;
				case 4:
				case 11:
					return result;
				case 7:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Process Ⴄ(short P_0, int P_1)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[302] - 55861;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[0] - 54027;
					continue;
				case 10:
				case 11:
					break;
				case 2:
					num2 = (((P_1 ^ P_0) - 98) ^ num) switch
					{
						0 => 3, 
						_ => 7, 
					};
					continue;
				case 7:
					obj = null;
					num2 = 5;
					continue;
				case 0:
				case 3:
					obj = Process.GetCurrentProcess();
					num2 = ⴃႣ[166] - 48248;
					continue;
				case 5:
				{
					num++;
					int num3 = 149;
					int num4 = 951;
					num2 = ((6657 <= num4 - num3 * 7) ? 1 : 9);
					continue;
				}
				case 1:
				case 6:
					num2 = ⴀ[55] - 33062;
					continue;
				case 9:
					return obj as Process;
				case 4:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static double Ⴗ(double P_0, int P_1, int P_2)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		double result = default(double);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[25] - 18238;
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
				case 2:
					num2 = (((P_2 ^ P_1) - 20) ^ num) switch
					{
						0 => ⴃႭ[117] - 15374, 
						1 => ⴃႤ[388] - 10745, 
						_ => 10, 
					};
					continue;
				case 10:
					result = 4.125116777418282;
					goto case 11;
				case 11:
					num2 = 7;
					continue;
				case 5:
				case 8:
					result = Math.Sqrt(P_0);
					num2 = ⴃႣ[65] - 110;
					continue;
				case 9:
					result = Math.Floor(P_0);
					num2 = 7;
					continue;
				case 7:
					num++;
					goto case 3;
				case 3:
				{
					int num3 = 494;
					int num4 = 119;
					num2 = ((247 < num3 / 2 - num4) ? 2 : (ⴃႣ[35] - 31527));
					continue;
				}
				case 4:
					return result;
				case 0:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DxSpot
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool result = default(bool);
		int num3 = default(int);
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
					num2 = ⴃႣ[181] - 42045;
					continue;
				case 6:
				case 8:
					break;
				case 5:
					num2 = (((P_1 ^ P_2) - 97) ^ num) switch
					{
						0 => 1, 
						_ => ⴃႤ[557] - 53632, 
					};
					continue;
				case 2:
				case 10:
					result = false;
					num2 = ⴃႣ[215] - 32471;
					continue;
				case 1:
					result = P_0.IsSkimUnknown;
					num2 = 9;
					continue;
				case 9:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = ⴀ[82] - 29950;
					continue;
				case 3:
				case 7:
					num2 = ((num3 % 2 != 0) ? 5 : (ⴀ[341] - 32413));
					continue;
				case 4:
					return result;
				case 11:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, char P_3, char P_4) where _0021_00210 : DataGridView
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႭ[122] - 60699;
				continue;
			case 0:
			case 2:
				num = (((P_3 ^ P_4) - 18) ^ num2) switch
				{
					0 => 5, 
					_ => 6, 
				};
				continue;
			case 6:
			case 7:
				num = 4;
				continue;
			case 5:
				P_0.InvalidateCell(P_1, P_2);
				break;
			case 3:
			case 4:
				break;
			case 1:
				return;
			}
			num2++;
			int num3 = 1983;
			int num4 = 657;
			num = ((661 < num3 / 3 - num4) ? (ⴐ[538] - 53427) : (ⴃႭ[64] - 60323));
		}
	}
}
