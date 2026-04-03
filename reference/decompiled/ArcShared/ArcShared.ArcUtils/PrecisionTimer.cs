using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ArcInterfaces.Arcx;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.DgvUtils;
using ArcShared.Forms;
using Ⴃ;

namespace ArcShared.ArcUtils;

public sealed class PrecisionTimer
{
	private long Ⴅ;

	private HelpAboutServer.ႷႠ m_Ⴀ = new HelpAboutServer.ႷႠ();

	public double Duration
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			return (double)(Ⴅ - this.m_Ⴀ.Ⴗ) / (double)this.m_Ⴀ.Ⴃ;
		}
	}

	[DllImport("Kernel32.dll", EntryPoint = "QueryPerformanceCounter")]
	private static extern bool Ⴓ(out long P_0);

	[DllImport("Kernel32.dll", EntryPoint = "QueryPerformanceFrequency")]
	private static extern bool Ⴐ(out long P_0);

	public PrecisionTimer()
	{
		if (!Ⴐ(out this.m_Ⴀ.Ⴃ))
		{
			throw new Win32Exception();
		}
	}

	public void Start()
	{
		ႰႨ.Ⴜ(0, 'Ç', 218);
		Ⴓ(out this.m_Ⴀ.Ⴗ);
	}

	public void Stop()
	{
		Ⴓ(out Ⴅ);
	}

	public override string ToString()
	{
		double duration = Duration;
		return StationCfg.Ⴄ(ref duration, ႣႼ.ႥႭ(null, 624736017, 2, null), 311, 339);
	}

	[SecuritySafeCritical]
	static PrecisionTimer()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, Point P_1, char P_2, short P_3) where _0021_00210 : Control
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				break;
			case 2:
			case 8:
				num = (((P_3 ^ P_2) - 40) ^ num2) switch
				{
					0 => 9, 
					_ => 0, 
				};
				break;
			case 0:
				num = 4;
				break;
			case 9:
				P_0.Location = P_1;
				goto case 4;
			case 4:
				num2++;
				goto case 1;
			case 1:
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႭ[49] - 57583) : 3);
				break;
			case 3:
				num = 2;
				break;
			case 5:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴈ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : FileSystemInfo
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		DateTime result = default(DateTime);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 40) ^ num) switch
					{
						0 => ⴐ[85] - 5710, 
						_ => 10, 
					};
					continue;
				case 7:
				case 10:
					result = default(DateTime);
					num2 = 8;
					continue;
				case 5:
				case 9:
					result = P_0.LastWriteTime;
					num2 = ⴀ[155] - 17774;
					continue;
				case 8:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႣ[116] - 21524) : (ⴃႤ[193] - 14814));
					continue;
				case 2:
				case 6:
					num2 = 1;
					continue;
				case 11:
					return result;
				case 4:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataRowCollection Ⴀ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : DataTable
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		InternalDataCollectionBase internalDataCollectionBase = default(InternalDataCollectionBase);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[105] - 4872;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[48] - 14596;
					continue;
				case 11:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 53) ^ num) switch
					{
						0 => 8, 
						_ => ⴃႣ[105] - 52218, 
					};
					continue;
				case 6:
				case 10:
					internalDataCollectionBase = null;
					num2 = ⴃႣ[214] - 56059;
					continue;
				case 8:
					internalDataCollectionBase = P_0.Rows;
					num2 = 7;
					continue;
				case 5:
				case 7:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = ⴀ[43] - 13280;
					continue;
				case 1:
					num2 = ((num3 % 2 != 0) ? 3 : 9);
					continue;
				case 0:
				case 9:
					return (DataRowCollection)internalDataCollectionBase;
				case 2:
					num2 = ⴃႣ[176] - 11043;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴃ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : EventWaitHandle
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		bool result = default(bool);
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
					num2 = ⴃႣ[234] - 20660;
					continue;
				case 6:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 49) ^ num) switch
					{
						0 => 12, 
						1 => 10, 
						_ => 0, 
					};
					continue;
				case 0:
					result = false;
					num2 = 8;
					continue;
				case 12:
					result = P_0.Set();
					goto case 7;
				case 7:
					num2 = 8;
					continue;
				case 10:
				case 11:
					result = P_0.Reset();
					num2 = 8;
					continue;
				case 8:
					num++;
					goto case 4;
				case 4:
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 3 : 9);
					continue;
				case 9:
					num2 = 1;
					continue;
				case 3:
					return result;
				case 5:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴜ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : Exception
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[136] - 25389;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[67] - 30146;
					continue;
				case 1:
				case 6:
					break;
				case 7:
				case 10:
					num2 = (((P_2 ^ P_1) - 93) ^ num) switch
					{
						0 => ⴃႭ[246] - 52423, 
						_ => 0, 
					};
					continue;
				case 0:
					convertible = null;
					num2 = ⴀ[371] - 3280;
					continue;
				case 3:
					convertible = P_0.Message;
					num2 = ⴗ[115] - 18168;
					continue;
				case 2:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႭ[32] - 53234) : (ⴗ[135] - 48370));
					continue;
				case 11:
					num2 = 10;
					continue;
				case 4:
				case 5:
					return convertible as string;
				case 9:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႤႰ<_0021_00210>(_0021_00210 P_0, byte[] P_1, int P_2, int P_3, char P_4, char P_5) where _0021_00210 : Encoding
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object obj = default(object);
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
					num2 = ⴃႭ[51] - 22351;
					continue;
				case 10:
					break;
				case 9:
					num2 = (((P_4 ^ P_5) - 106) ^ num) switch
					{
						0 => ⴃႭ[72] - 28231, 
						_ => 0, 
					};
					continue;
				case 0:
					obj = null;
					goto case 1;
				case 1:
				case 7:
					num2 = 3;
					continue;
				case 2:
					obj = P_0.GetString(P_1, P_2, P_3);
					num2 = 3;
					continue;
				case 3:
					num++;
					goto case 4;
				case 4:
				{
					int num3 = 3688;
					int num4 = 270;
					num2 = ((922 < num3 / 4 - num4) ? 9 : (ⴐ[124] - 50857));
					continue;
				}
				case 5:
					return obj as string;
				case 8:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static AssemblyName ႤႤ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : Assembly
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 127) ^ num) switch
					{
						0 => 6, 
						_ => 8, 
					};
					continue;
				case 8:
					obj = null;
					num2 = 5;
					continue;
				case 6:
					obj = P_0.GetName();
					num2 = ⴃႤ[608] - 18932;
					continue;
				case 3:
				case 5:
					num++;
					num3 = 254;
					num4 = 106;
					goto case 7;
				case 7:
					num2 = ((127 < num3 / 2 - num4) ? 4 : 9);
					continue;
				case 1:
				case 9:
					return obj as AssemblyName;
				case 2:
					num2 = ⴀ[241] - 35030;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long ႤႷ<_0021_00210>(_0021_00210 P_0, long P_1, SeekOrigin P_2, int P_3, char P_4) where _0021_00210 : Stream
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		long result = default(long);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[105] - 4865;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 2:
				case 7:
					break;
				case 10:
					num2 = (((P_3 ^ P_4) - 80) ^ num) switch
					{
						0 => ⴐ[455] - 58338, 
						_ => 0, 
					};
					continue;
				case 0:
				case 9:
					result = 10L;
					num2 = ⴗ[4] - 26310;
					continue;
				case 8:
					result = P_0.Seek(P_1, P_2);
					num2 = ⴐ[31] - 45324;
					continue;
				case 3:
					num++;
					goto case 5;
				case 5:
				{
					int num3 = 84;
					int num4 = 382;
					num2 = ((1528 > num4 - num3 * 4) ? (ⴃႤ[120] - 14319) : 11);
					continue;
				}
				case 11:
					num2 = 10;
					continue;
				case 1:
					return result;
				case 4:
					num2 = ⴗ[117] - 12529;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႤႨ<_0021_00210>(_0021_00210 P_0, byte[] P_1, char P_2, char P_3) where _0021_00210 : Socket
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 10;
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
				case 10:
					num2 = (((P_2 ^ P_3) - 106) ^ num) switch
					{
						0 => 8, 
						_ => 0, 
					};
					continue;
				case 0:
					num3 = 2;
					num2 = ⴐ[351] - 17281;
					continue;
				case 8:
					num3 = P_0.Send(P_1);
					num2 = 4;
					continue;
				case 4:
				case 7:
					num++;
					num4 = P_2 * P_2;
					num4 = P_2 + num4;
					goto case 2;
				case 2:
					num2 = 3;
					continue;
				case 3:
					num2 = ((num4 % 2 != 0) ? (ⴃႤ[554] - 10968) : (ⴃႣ[93] - 25910));
					continue;
				case 9:
				case 11:
				{
					int result = num3;
					NeedsCfg.ႣႤ[468] = (NeedsCfg.ႣႤ[468] * NeedsCfg.ႣႤ[246]) & 0x78;
					return result;
				}
				case 6:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႤႳ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : ArcLogInRqst
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IComparable comparable = default(IComparable);
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
					num2 = 8;
					continue;
				case 8:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 80) ^ num) switch
					{
						0 => 6, 
						_ => ⴀ[168] - ⴀ[168], 
					};
					continue;
				case 0:
				case 5:
				case 10:
					comparable = null;
					num2 = ⴃႭ[277] - 547;
					continue;
				case 6:
					comparable = P_0.Call;
					num2 = 7;
					continue;
				case 7:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴃႭ[82] - 56658;
					continue;
				case 2:
				case 11:
					num2 = ((num3 % 2 != 0) ? 1 : 4);
					continue;
				case 4:
					return comparable as string;
				case 3:
					num2 = ⴐ[415] - 57869;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႤႠ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : ArcLogInResp
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				continue;
			case 8:
				num = (((P_3 ^ P_2) - 40) ^ num2) switch
				{
					0 => ⴃႣ[187] - 55714, 
					_ => 1, 
				};
				continue;
			case 1:
				num = 5;
				continue;
			case 2:
				P_0.Call = P_1;
				break;
			case 5:
			case 6:
				break;
			case 3:
			case 7:
				return;
			}
			num2++;
			int num3 = 3428;
			int num4 = 344;
			num = ((857 < num3 / 4 - num4) ? 8 : 7);
		}
	}

	[SecuritySafeCritical]
	internal static IEnumerator ႤႭ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : BaseCollection
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႤ[106] - 49753;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 9:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 0) ^ num) switch
					{
						0 => 11, 
						_ => 7, 
					};
					continue;
				case 7:
					obj = null;
					num2 = 10;
					continue;
				case 2:
				case 11:
					obj = P_0.GetEnumerator();
					num2 = 10;
					continue;
				case 10:
					num++;
					goto case 1;
				case 1:
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 5 : (ⴀ[221] - 59523));
					continue;
				case 0:
				case 6:
					num2 = ⴃႭ[13] - 37432;
					continue;
				case 5:
					return (IEnumerator)obj;
				case 4:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static IPAddress[] ႤႣ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : IPHostEntry
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		Array array = default(Array);
		int num3 = default(int);
		int num4 = default(int);
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
					num2 = ⴗ[71] - 6965;
					continue;
				case 1:
				case 5:
					break;
				case 2:
					num2 = (((P_1 ^ P_2) - 83) ^ num) switch
					{
						0 => ⴃႣ[206] - 36152, 
						_ => ⴐ[140] - 47058, 
					};
					continue;
				case 7:
					array = null;
					num2 = 6;
					continue;
				case 4:
				case 9:
					array = P_0.AddressList;
					num2 = 6;
					continue;
				case 6:
					num++;
					num3 = 68;
					num4 = 8;
					goto case 0;
				case 0:
					num2 = ((34 < num3 / 2 - num4) ? (ⴃႤ[396] - 9924) : 10);
					continue;
				case 10:
					return array as IPAddress[];
				case 3:
					num2 = ⴐ[54] - 45099;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႤႥ<_0021_00210, _0021_00211>(_0021_00211 P_0, NumberStyles P_1, _0021_00210 P_2, ref double P_3, int P_4, int P_5) where _0021_00210 : IFormatProvider where _0021_00211 : string
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[24] - 3995;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 9:
					break;
				case 7:
				{
					int num5 = (P_5 ^ P_4) - 3;
					int num6 = num;
					TalkCfg.ႣႣ[44] = (char)((TalkCfg.ႣႣ[44] * P_4) & 0x6C);
					num2 = (num5 ^ num6) switch
					{
						0 => 3, 
						_ => ⴀ[181] - 42555, 
					};
					continue;
				}
				case 2:
					result = false;
					num2 = 1;
					continue;
				case 3:
					result = double.TryParse(P_0, P_1, P_2, out P_3);
					num2 = ⴗ[31] - 486;
					continue;
				case 1:
					num++;
					num3 = 1902;
					goto case 8;
				case 8:
				{
					int num4 = num3;
					num2 = (((num4 * num4 + num3) % 2 == 0) ? 10 : 11);
					continue;
				}
				case 11:
					num2 = 7;
					continue;
				case 10:
					return result;
				case 0:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႤႼ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : AnnWxSpot
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[2] - 5257;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[65] - 41725;
					continue;
				case 2:
					break;
				case 10:
				case 11:
					DxCfg.Ⴗ[13] = (char)((DxCfg.Ⴗ[13] * UtilsNumeric.Ⴀ[353]) & 0xF8);
					num2 = (((P_1 ^ P_2) - 79) ^ num) switch
					{
						0 => 9, 
						_ => 3, 
					};
					continue;
				case 3:
				case 8:
					comparable = null;
					num2 = 6;
					continue;
				case 9:
					comparable = P_0.WxFlag;
					num2 = ⴃႭ[220] - 42481;
					continue;
				case 1:
				case 6:
				{
					num++;
					int num3 = 101;
					int num4 = 196;
					num2 = ((1568 > num4 - num3 * 8) ? (ⴗ[144] - 45240) : 4);
					continue;
				}
				case 4:
					num2 = ⴐ[15] - 19729;
					continue;
				case 5:
					return comparable as string;
				case 0:
					num2 = ⴃႣ[42] - 15423;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႷႰ(ref Rectangle P_0, short P_1, short P_2)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int result = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႭ[173] - 11202;
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
				case 3:
					num2 = (((P_1 ^ P_2) - 69) ^ num) switch
					{
						0 => ⴃႤ[123] - 21533, 
						_ => ⴃႣ[103] - 47725, 
					};
					continue;
				case 4:
				case 5:
					result = 15;
					num2 = 9;
					continue;
				case 6:
					result = P_0.Y;
					num2 = ⴀ[298] - 699;
					continue;
				case 0:
				case 9:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 7;
					continue;
				case 7:
					num2 = ((num3 % 2 != 0) ? (ⴀ[400] - 20054) : (ⴃႣ[214] - 56064));
					continue;
				case 2:
				case 8:
					return result;
				case 1:
					num2 = ⴀ[342] - 32048;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႤ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, int P_3) where _0021_00210 : DxSpot
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 8;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႤ[232] - 11098;
				continue;
			case 0:
			{
				int num4 = (P_3 ^ P_2) - 89;
				int num5 = num2;
				DataGridViewColumnSelector.Ⴐ[414] = (char)(DataGridViewColumnSelector.Ⴐ[414] & P_2 & 0xEB);
				num = (num4 ^ num5) switch
				{
					0 => ⴃႣ[96] - 36627, 
					_ => ⴗ[141] - 5941, 
				};
				continue;
			}
			case 1:
				num = 2;
				continue;
			case 7:
				P_0.Lotw = P_1;
				goto case 2;
			case 2:
			case 6:
				num2++;
				num3 = 1060;
				break;
			case 4:
				break;
			case 3:
			case 5:
				return;
			}
			int num6 = 256;
			num = ((530 < num3 / 2 - num6) ? (ⴃႣ[93] - ⴃႣ[93]) : 3);
		}
	}
}
