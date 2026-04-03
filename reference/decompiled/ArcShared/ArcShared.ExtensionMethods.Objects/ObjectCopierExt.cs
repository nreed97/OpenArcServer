using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Text;
using System.Windows.Forms;
using ArcInterfaces.Arcx;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using Ⴃ;

namespace ArcShared.ExtensionMethods.Objects;

public static class ObjectCopierExt
{
	internal sealed class Ⴃ
	{
		internal bool Ⴅ;

		internal bool Ⴀ;

		internal bool Ⴗ;

		internal bool Ⴐ;

		internal Ⴃ()
		{
		}
	}

	public static T Clone<T>(this T source)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		T result = default(T);
		while (true)
		{
			int num = (UtilsDate.Ⴅ(typeof(T), 177, '\u0085') ? (ⴀ[342] - 32047) : 3);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴐ[7] - 30491;
					continue;
				case 7:
					break;
				case 3:
					throw new ArgumentException(ႣႼ.ႥႭ(null, 624735920, 1, null), DownloadUrl2.Ⴅ(24, null, 2018868216, 1));
				case 4:
					num = ((!AnnCfg.Ⴜ<object, object>(source, null, 243, 204)) ? (ⴀ[221] - ⴀ[221]) : (ⴃႭ[245] - 52425));
					continue;
				case 1:
				case 8:
					result = default(T);
					goto case 5;
				case 5:
					return result;
				case 0:
				case 2:
				{
					object obj = new BinaryFormatter();
					IDisposable disposable = new MemoryStream();
					IDisposable disposable2 = (Stream)disposable;
					T val;
					try
					{
						int num2 = 0;
						while (true)
						{
							switch (num2)
							{
							default:
								((IFormatter)obj).Serialize((Stream)disposable, source);
								PrecisionTimer.ႤႷ(disposable as Stream, 0L, SeekOrigin.Begin, 237, '½');
								break;
							case 1:
								break;
							case 2:
								val = (T)((IFormatter)obj).Deserialize(disposable as Stream);
								goto end_IL_010f;
							}
							num2 = 2;
							continue;
							end_IL_010f:
							break;
						}
					}
					finally
					{
						int num3 = 0;
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								num4 = (((Stream)disposable2 == null) ? (ⴃႣ[21] - ⴃႣ[104]) : 5);
								goto IL_01ac;
							case 5:
								((IDisposable)(disposable2 as Stream)).Dispose();
								break;
							case 1:
							case 4:
								break;
							}
							break;
							IL_01ac:
							num3 = num4;
						}
					}
					return 4 switch
					{
						_ => val, 
					};
				}
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static ObjectCopierExt()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static bool Ⴈ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : Type where _0021_00211 : Type
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool result = default(bool);
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
					num2 = ⴃႤ[45] - 35083;
					continue;
				case 4:
					break;
				case 0:
					num2 = (((P_3 ^ P_2) - 36) ^ num) switch
					{
						0 => 2, 
						_ => ⴗ[23] - 59671, 
					};
					continue;
				case 1:
				case 6:
					result = false;
					num2 = ⴃႭ[97] - 35149;
					continue;
				case 2:
				case 8:
				case 10:
					result = P_0 == P_1;
					num2 = 7;
					continue;
				case 7:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴀ[281] - 58258;
					continue;
				case 9:
					num2 = ((num3 % 2 == 0) ? 3 : 0);
					continue;
				case 3:
					return result;
				case 5:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, char P_3) where _0021_00210 : Control
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 7;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 3;
				break;
			case 3:
				num = (((P_3 ^ P_2) - 48) ^ num3) switch
				{
					0 => ⴃႭ[29] - 40513, 
					_ => 4, 
				};
				break;
			case 4:
				num = 2;
				break;
			case 6:
			case 9:
				P_0.TabIndex = P_1;
				goto case 2;
			case 2:
			case 8:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = ⴃႣ[194] - 48167;
				break;
			case 5:
				num = ((num2 % 2 != 0) ? (ⴃႤ[575] - 8475) : 0);
				break;
			case 0:
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211, _0021_00212>(_0021_00210 P_0, _0021_00211 P_1, _0021_00212 P_2, char P_3, char P_4) where _0021_00210 : CancelEventHandler where _0021_00212 : CancelEventArgs
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 9;
				break;
			case 9:
				num = (((P_4 ^ P_3) - 19) ^ num2) switch
				{
					0 => 6, 
					_ => 5, 
				};
				break;
			case 5:
			case 7:
				num = ⴃႭ[178] - 58285;
				break;
			case 2:
			case 3:
			case 6:
				P_0(P_1, P_2);
				goto case 4;
			case 4:
			{
				num2++;
				int num3 = 336;
				int num4 = 938;
				num = ((9380 <= num4 - num3 * 10) ? 8 : 0);
				break;
			}
			case 8:
				num = 9;
				break;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴓ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, StringComparison P_3, short P_4, int P_5) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int result = default(int);
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
					num2 = (((P_4 ^ P_5) - 55) ^ num) switch
					{
						0 => ⴐ[558] - 19589, 
						_ => 2, 
					};
					continue;
				case 0:
				case 2:
					result = 2;
					num2 = 1;
					continue;
				case 8:
					result = P_0.IndexOf(P_1, P_2, P_3);
					num2 = 1;
					continue;
				case 1:
					num++;
					num2 = (((P_4 * P_4 + P_4) % 2 == 0) ? 11 : 6);
					continue;
				case 4:
				case 6:
					num2 = ⴗ[45] - 54530;
					continue;
				case 11:
					return result;
				case 3:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴗ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : AppDomain where _0021_00211 : string
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[131] - 64727;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 8;
					continue;
				case 8:
				case 10:
					break;
				case 1:
				case 4:
					num2 = (((P_2 ^ P_3) - 75) ^ num) switch
					{
						0 => 11, 
						_ => ⴗ[68] - 17891, 
					};
					continue;
				case 5:
					result = null;
					num2 = ⴃႣ[215] - 32477;
					continue;
				case 11:
					result = P_0.GetData(P_1);
					num2 = ⴐ[415] - 57867;
					continue;
				case 3:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 != 0) ? 2 : 0);
					continue;
				case 2:
					num2 = 1;
					continue;
				case 0:
				case 6:
					return result;
				case 9:
					num2 = ⴗ[55] - 6827;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴍ<_0021_00210>(_0021_00210 P_0, byte[] P_1, int P_2, int P_3, int P_4, char P_5) where _0021_00210 : Stream
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int result = default(int);
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
					num2 = ⴃႤ[515] - 50911;
					continue;
				case 0:
				case 2:
					break;
				case 1:
				case 11:
					num2 = (((P_5 ^ P_4) - 47) ^ num) switch
					{
						0 => ⴐ[417] - 34239, 
						_ => 7, 
					};
					continue;
				case 7:
					result = 2;
					num2 = ⴐ[153] - 64105;
					continue;
				case 10:
					result = P_0.Read(P_1, P_2, P_3);
					num2 = 3;
					continue;
				case 3:
				{
					num++;
					int num3 = 22;
					int num4 = 36;
					num2 = ((324 > num4 - num3 * 9) ? (ⴃႣ[184] - 34375) : 8);
					continue;
				}
				case 8:
					num2 = ⴃႤ[320] - 20184;
					continue;
				case 5:
					return result;
				case 4:
				case 9:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Encoding Ⴄ(short P_0, int P_1)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[13] - 37647;
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
					num2 = (((P_0 ^ P_1) - 86) ^ num) switch
					{
						0 => 9, 
						_ => ⴃႤ[92] - 49896, 
					};
					continue;
				case 1:
					obj = null;
					num2 = 4;
					continue;
				case 9:
					obj = Encoding.ASCII;
					num2 = 4;
					continue;
				case 4:
					num++;
					num3 = 3116;
					num4 = 561;
					goto case 3;
				case 3:
				case 5:
					num2 = ((779 >= num3 / 4 - num4) ? (ⴗ[52] - 52157) : 0);
					continue;
				case 6:
					return obj as Encoding;
				case 8:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : ArcLogInResp
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[178] - 54146;
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
				case 4:
					num2 = (((P_1 ^ P_2) - 112) ^ num) switch
					{
						0 => 5, 
						_ => 2, 
					};
					continue;
				case 1:
				case 2:
					enumerable = null;
					num2 = 6;
					continue;
				case 5:
				case 11:
					enumerable = P_0.Alias;
					num2 = 6;
					continue;
				case 6:
					num++;
					num3 = 668;
					goto case 0;
				case 0:
				{
					int num4 = 841;
					num2 = ((7569 > num4 - num3 * 9) ? (ⴀ[214] - 40458) : (ⴗ[24] - 30798));
					continue;
				}
				case 7:
					num2 = 4;
					continue;
				case 3:
					return (string)enumerable;
				case 10:
					num2 = ⴃႭ[10] - 46799;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴜ<_0021_00210, _0021_00211, _0021_00212>(_0021_00211 P_0, _0021_00212 P_1, _0021_00210 P_2, short P_3, char P_4) where _0021_00210 : CultureInfo where _0021_00211 : ResourceManager where _0021_00212 : string
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		object result = default(object);
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
					num2 = 2;
					continue;
				case 2:
					break;
				case 6:
					num2 = (((P_3 ^ P_4) - 23) ^ num) switch
					{
						0 => ⴀ[303] - 4123, 
						_ => ⴀ[23] - 47054, 
					};
					continue;
				case 3:
				case 4:
					result = null;
					goto case 5;
				case 5:
					num2 = 11;
					continue;
				case 8:
					result = P_0.GetObject(P_1, P_2);
					num2 = 11;
					continue;
				case 11:
				{
					num++;
					int num3 = 257;
					int num4 = 341;
					num2 = ((682 > num4 - num3 * 2) ? 1 : (ⴃႭ[216] - 27130));
					continue;
				}
				case 9:
					num2 = ⴗ[51] - 12328;
					continue;
				case 1:
					return result;
				case 0:
				case 10:
					num2 = ⴀ[166] - 10215;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႥႨ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : ArcLogInRqst
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		IComparable comparable = default(IComparable);
		int num3 = default(int);
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
				case 10:
					break;
				case 11:
					num2 = (((P_1 ^ P_2) - 23) ^ num) switch
					{
						0 => 9, 
						_ => 1, 
					};
					continue;
				case 1:
					comparable = null;
					num2 = 4;
					continue;
				case 9:
					comparable = P_0.Message;
					num2 = 4;
					continue;
				case 4:
					num++;
					num3 = 126;
					goto case 0;
				case 0:
				{
					int num4 = 445;
					num2 = ((1780 > num4 - num3 * 4) ? 3 : (ⴃႤ[532] - 51861));
					continue;
				}
				case 5:
					num2 = 11;
					continue;
				case 3:
				case 6:
				{
					string result = (string)comparable;
					DxCfg.Ⴗ[78] = (char)(DxCfg.Ⴗ[78] & P_1 & 0x17);
					return result;
				}
				case 8:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}
}
