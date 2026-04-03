using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.ExtensionMethods;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class UtilsPerformance
{
	public static string GetAppPerformance()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		Component component2 = default(Component);
		double num3 = default(double);
		double num4 = default(double);
		int num2 = default(int);
		object obj2 = default(object);
		while (true)
		{
			object obj = XmlSerializationHelper.Ⴄ(558, 588);
			while (true)
			{
				IL_0072:
				Component component = new PerformanceCounter(ႣႼ.Ⴜ(8, 365385935, 14), ႣႼ.ႥႭ(null, 624735371, 5, null), StringConstants.Ⴍ((Process)obj, 957, 'ϭ'));
				int num = 11;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 13;
						continue;
					case 4:
					case 13:
						break;
					case 9:
						goto IL_0072;
					case 11:
						component2 = new PerformanceCounter(ႣႼ.Ⴜ(1, 365385926, 0), TelnetServerClient.Ⴄ(1945323206, '1', 7), StringConstants.Ⴍ((Process)obj, 466, 'Ƃ'));
						num = 0;
						continue;
					case 0:
						ႰႨ.Ⴜ(500, 'ȋ', 534);
						num3 = AnnWxSpotExt.ႤႥ(component as PerformanceCounter, 856, 861);
						num = ⴃႭ[10] - 46800;
						continue;
					case 3:
						num3 = num3 / 1024.0 / 1024.0;
						num4 = AnnWxSpotExt.ႤႥ((PerformanceCounter)component2, 137, 140);
						goto case 6;
					case 6:
						num = ⴐ[225] - 26606;
						continue;
					case 8:
						num2 = DgvBaseFilterHost.ႷႷ((ReadOnlyCollectionBase)UtilsSql.ႨႣ(obj as Process, 318, 283), (short)447, 507);
						num = ⴃႤ[438] - 63514;
						continue;
					case 5:
						obj2 = new object[6];
						((object[])obj2)[0] = TelnetServerClient.Ⴄ(1945323247, 'L', 3);
						num = ⴃႭ[10] - 46791;
						continue;
					case 12:
						((object[])obj2)[1] = num4;
						(obj2 as object[])[2] = ႣႼ.ႥႭ(null, 624735356, 4, null);
						num = 10;
						continue;
					case 10:
						(obj2 as object[])[3] = num3.ToString(ႣႼ.Ⴜ(0, 365387669, 5));
						num = 7;
						continue;
					case 7:
						((object[])obj2)[4] = ႣႼ.Ⴜ(6, 365385943, 7);
						(obj2 as object[])[5] = num2.ToString();
						num = ⴐ[334] - 25409;
						continue;
					case 2:
						return string.Concat(obj2 as object[]);
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static UtilsPerformance()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static bool Ⴐ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : CheckBox
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[166] - 10210;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[51] - 12332;
					continue;
				case 2:
					break;
				case 5:
				case 11:
					num2 = (((P_2 ^ P_1) - 78) ^ num) switch
					{
						0 => 10, 
						_ => 6, 
					};
					continue;
				case 6:
					result = true;
					num2 = 4;
					continue;
				case 10:
					result = P_0.Checked;
					num2 = 4;
					continue;
				case 4:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 0;
				case 0:
					num2 = ⴃႭ[197] - 28508;
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? 11 : (ⴀ[110] - 48939));
					continue;
				case 1:
					return result;
				case 7:
				case 8:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴗ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : Thread
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
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
					num2 = ⴃႤ[305] - 20878;
					continue;
				case 3:
				case 7:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 124) ^ num) switch
					{
						0 => 10, 
						_ => ⴃႭ[49] - 57589, 
					};
					continue;
				case 0:
					result = true;
					num2 = 4;
					continue;
				case 10:
					result = P_0.IsAlive;
					num2 = 4;
					continue;
				case 4:
					num++;
					goto case 6;
				case 6:
				case 8:
				{
					int num3 = 756;
					int num4 = 134;
					num2 = ((378 < num3 / 2 - num4) ? (ⴃႭ[103] - 40154) : 5);
					continue;
				}
				case 5:
					return result;
				case 9:
					num2 = ⴃႤ[232] - 11097;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, char P_3) where _0021_00210 : Socket where _0021_00211 : EndPoint
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				break;
			case 0:
				num = (((P_3 ^ P_2) - 64) ^ num2) switch
				{
					0 => 9, 
					_ => ⴃႤ[233] - 8933, 
				};
				break;
			case 4:
				num = 7;
				break;
			case 9:
				P_0.Connect(P_1);
				goto case 7;
			case 7:
			{
				num2++;
				int num3 = 308;
				int num4 = 725;
				num = ((5075 > num4 - num3 * 7) ? 3 : (ⴃႤ[548] - 17352));
				break;
			}
			case 1:
			case 2:
				num = 0;
				break;
			case 3:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static IAsyncResult Ⴍ<_0021_00210, _0021_00211, _0021_00212>(_0021_00210 P_0, byte[] P_1, int P_2, int P_3, SocketFlags P_4, _0021_00211 P_5, _0021_00212 P_6, int P_7, short P_8) where _0021_00210 : Socket where _0021_00211 : AsyncCallback
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
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
					num2 = ⴃႣ[131] - 64723;
					continue;
				case 5:
					break;
				case 1:
					num2 = (((P_7 ^ P_8) - 3) ^ num) switch
					{
						0 => 4, 
						_ => 2, 
					};
					continue;
				case 2:
					obj = null;
					num2 = 10;
					continue;
				case 4:
				case 7:
					obj = P_0.BeginReceive(P_1, P_2, P_3, P_4, P_5, P_6);
					num2 = 10;
					continue;
				case 10:
				{
					num++;
					int num3 = 78;
					int num4 = 762;
					num2 = ((6096 > num4 - num3 * 8) ? (ⴗ[102] - 41115) : 3);
					continue;
				}
				case 3:
					num2 = 1;
					continue;
				case 0:
					return obj as IAsyncResult;
				case 8:
				case 11:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static AddressFamily Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : IPAddress
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		AddressFamily result = default(AddressFamily);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 2:
					num2 = (((P_2 ^ P_1) - 41) ^ num) switch
					{
						0 => ⴃႣ[184] - 34380, 
						_ => 4, 
					};
					continue;
				case 4:
					result = AddressFamily.Unspecified;
					goto case 10;
				case 10:
					num2 = ⴀ[230] - 37249;
					continue;
				case 0:
				case 9:
					result = P_0.AddressFamily;
					num2 = 6;
					continue;
				case 6:
				case 8:
				{
					num++;
					int num3 = 498;
					int num4 = 967;
					num2 = ((9670 > num4 - num3 * 10) ? 1 : (ⴃႤ[344] - 26223));
					continue;
				}
				case 11:
					num2 = ⴃႣ[106] - 63636;
					continue;
				case 1:
					return result;
				case 5:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : Image
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int result = default(int);
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
					num2 = ⴃႤ[164] - 58852;
					continue;
				case 10:
					break;
				case 4:
				case 5:
					num2 = (((P_2 ^ P_1) - 33) ^ num) switch
					{
						0 => ⴃႭ[81] - 32190, 
						_ => 0, 
					};
					continue;
				case 0:
					result = P_1;
					num2 = 3;
					continue;
				case 6:
				case 7:
					result = P_0.Height;
					num2 = 3;
					continue;
				case 3:
				{
					num++;
					int num3 = 1245;
					int num4 = 291;
					num2 = ((415 < num3 / 3 - num4) ? 5 : 9);
					continue;
				}
				case 9:
					return result;
				case 1:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : ItemCheckEventArgs
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[50] - 11835;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 4;
					continue;
				case 4:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 33) ^ num) switch
					{
						0 => 7, 
						_ => 10, 
					};
					continue;
				case 10:
					result = P_1;
					num2 = ⴐ[169] - 41037;
					continue;
				case 5:
				case 7:
					result = P_0.Index;
					num2 = ⴀ[259] - 39333;
					continue;
				case 3:
				{
					num++;
					int num3 = 1245;
					int num4 = 291;
					NeedsCfg.ႣႤ[184] = (NeedsCfg.ႣႤ[184] - UtilsNumeric.Ⴀ[77]) & 0x96;
					num2 = ((415 < num3 / 3 - num4) ? (ⴗ[157] - 44217) : 9);
					continue;
				}
				case 9:
					return result;
				case 0:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Color Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, short P_3, short P_4) where _0021_00210 : Bitmap
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		Color color = default(Color);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 6;
					continue;
				case 2:
				case 6:
					break;
				case 8:
					num2 = (((P_4 ^ P_3) - 120) ^ num) switch
					{
						0 => ⴐ[408] - 38790, 
						_ => 9, 
					};
					continue;
				case 0:
				case 9:
					color = default(Color);
					num2 = ⴃႭ[101] - 25680;
					continue;
				case 3:
					color = P_0.GetPixel(P_1, P_2);
					num2 = 10;
					continue;
				case 10:
				{
					num++;
					int num3 = 1042;
					int num4 = 104;
					num2 = ((521 >= num3 / 2 - num4) ? 1 : 8);
					continue;
				}
				case 1:
				{
					Color result = color;
					DxCfg.Ⴗ[79] = (char)((DxCfg.Ⴗ[79] - UtilsNumeric.Ⴀ[9]) & 0x92);
					return result;
				}
				case 7:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}
}
