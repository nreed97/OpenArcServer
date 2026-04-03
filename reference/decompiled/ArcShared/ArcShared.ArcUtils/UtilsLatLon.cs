using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Windows.Forms;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using ArcShared.MaintenanceUpdates;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class UtilsLatLon
{
	public static bool IsValidLatLon(string sLatLon)
	{
		return ColumnFilterEventArgs.Ⴀ(sLatLon, UtilsString.Ⴐ(null, 5, 192633372), 589, 541);
	}

	public static bool IsValidQra(string sLatLon)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		return ColumnFilterEventArgs.Ⴀ(sLatLon, ArcLogInRqstExt.Ⴗ(1706507669, 10, 4), 163, 243);
	}

	public static string LatLonToMaidenHeadGrid(double lat, double lon)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		double num3 = default(double);
		double num2 = default(double);
		byte b2 = default(byte);
		byte b = default(byte);
		Array array3 = default(Array);
		object obj4 = default(object);
		Array array2 = default(Array);
		object obj3 = default(object);
		object obj2 = default(object);
		while (true)
		{
			object obj = string.Empty;
			int num = ((lat != 0.0) ? (ⴃႤ[95] - ⴃႤ[95]) : 14);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 17;
					continue;
				case 17:
					break;
				case 14:
					num = ((lon == 0.0) ? (ⴃႤ[530] - 23111) : 0);
					continue;
				case 0:
					num3 = lon / 20.0 + 9.0;
					num2 = lat / 10.0 + 9.0;
					num = 10;
					continue;
				case 10:
					b2 = (byte)num3;
					b = (byte)num2;
					goto case 2;
				case 2:
					array3 = new byte[2];
					((byte[])array3)[0] = (byte)(b2 + 65);
					num = 15;
					continue;
				case 15:
					((byte[])array3)[1] = (byte)(b + 65);
					obj4 = (byte[])array3;
					num = 8;
					continue;
				case 8:
					obj = AnnWxSpotExt.ႤႣ(ObjectCopierExt.Ⴄ(15, 89), obj4 as byte[], 'ż', 316);
					num = 7;
					continue;
				case 7:
					num3 = (num3 - (double)(int)b2) * 10.0;
					num2 = (num2 - (double)(int)b) * 10.0;
					num = 12;
					continue;
				case 12:
					b2 = (byte)num3;
					b = (byte)num2;
					array2 = new byte[2];
					(array2 as byte[])[0] = (byte)(b2 + 48);
					num = ⴃႭ[49] - 57580;
					continue;
				case 9:
					((byte[])array2)[1] = (byte)(b + 48);
					obj3 = array2 as byte[];
					num = 4;
					continue;
				case 4:
				{
					obj = ReverseBeaconClient.Ⴗ(obj as string, AnnWxSpotExt.ႤႣ(ObjectCopierExt.Ⴄ(183, 225), (byte[])obj3, '÷', 183), '½', 'õ');
					char num4 = ⴐ[91];
					NeedsCfg.ႣႤ[56] = (NeedsCfg.ႣႤ[56] - TalkCfg.ႣႣ[185]) & 0xCF;
					num = num4 - 962;
					continue;
				}
				case 5:
					obj2 = new byte[2];
					((byte[])obj2)[0] = (byte)((num3 - (double)(int)b2) * 24.0 + 65.0);
					num = ⴀ[403] - 52877;
					continue;
				case 3:
				case 6:
					(obj2 as byte[])[1] = (byte)((num2 - (double)(int)b) * 24.0 + 65.0);
					num = 11;
					continue;
				case 11:
				case 13:
				{
					Array array = (byte[])obj2;
					obj = (string)obj + Encoding.ASCII.GetString(array as byte[]);
					num = 1;
					continue;
				}
				case 1:
					return (string)obj;
				}
				break;
			}
		}
	}

	public static float LatLonStringToFloat(string latLon, bool isLat)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		double num2 = default(double);
		while (true)
		{
			Array array = new char[1];
			(array as char[])[0] = ' ';
			object obj = ႰႨ.ႨႥ(latLon, array as char[], 955, 986);
			int num = 10;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 9;
					continue;
				case 9:
					break;
				case 10:
					num = ((!isLat) ? (ⴀ[215] - 2679) : 12);
					continue;
				case 7:
				case 12:
					num2 = DirectoryMonitor.ႠႷ((obj as string[])[0], 237, 'Ê');
					goto case 0;
				case 0:
					num2 += DirectoryMonitor.ႠႷ(((string[])obj)[1], 383, 'Ř') / 60.0;
					num = ⴗ[42] - 36995;
					continue;
				case 11:
					num = ((!FrmUpdating.ႠႥ((obj as string[])[2], ႣႼ.ႥႭ(null, 624735462, 8, null), 214, 234)) ? (ⴗ[31] - 483) : (ⴐ[161] - 4792));
					continue;
				case 1:
					num2 = 0.0 - num2;
					num = 4;
					continue;
				case 6:
					num2 = DirectoryMonitor.ႠႷ((obj as string[])[3], 806, '\u0301');
					num2 += DirectoryMonitor.ႠႷ((obj as string[])[4], 383, 'Ř') / 60.0;
					num = 3;
					continue;
				case 2:
				case 3:
					num = ((!((obj as string[])[5] == UtilsString.Ⴐ(null, 8, 192633563))) ? 4 : 8);
					continue;
				case 8:
					num2 = 0.0 - num2;
					num = 4;
					continue;
				case 4:
					return (float)num2;
				}
				break;
			}
		}
	}

	public static double MilesToKm(double miles)
	{
		return miles * 1.609344;
	}

	public static double GetLongPathBrg(double heading)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		while (true)
		{
			heading += 180.0;
			while (true)
			{
				IL_0049:
				int num = ((!(heading > 360.0)) ? (ⴃႣ[96] - ⴃႣ[96]) : 3);
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
					case 4:
						goto IL_0049;
					case 3:
						heading -= 360.0;
						num = ⴃႤ[371] - ⴃႤ[371];
						continue;
					case 0:
					case 6:
						return heading;
					}
					break;
				}
				break;
			}
		}
	}

	public static bool IsNonZeroLatLon(double lat, double lon)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		while (true)
		{
			int num = ((lat != 0.0) ? 2 : (ⴀ[43] - 13280));
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
				case 1:
				case 4:
					return lon != 0.0;
				case 0:
				case 2:
				case 6:
					return true;
				}
				break;
			}
		}
	}

	public static void CalcGeodesic(double latA, double lonA, double latB, double lonB, ref float rng, ref float brg)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 8;
		float[] array = default(float[]);
		float[] array2 = default(float[]);
		while (true)
		{
			switch (num)
			{
			default:
				latA *= Math.PI / 180.0;
				lonA *= Math.PI / 180.0;
				latB *= Math.PI / 180.0;
				num = 1;
				break;
			case 1:
				lonB *= Math.PI / 180.0;
				array = new float[2];
				array2 = new float[2];
				num = 3;
				break;
			case 3:
			case 5:
				Ⴐ(latA, lonA, latB, lonB, ref rng, ref array, ref array2);
				goto case 0;
			case 0:
			case 2:
				brg = (float)Ⴄ(array[0], array[1]);
				num = ⴐ[558] - 19590;
				break;
			case 7:
				brg = (float)((double)brg * (180.0 / Math.PI));
				num = ((!((double)brg < 0.0)) ? 4 : 6);
				break;
			case 6:
				brg = (float)(360.0 + (double)brg);
				num = 4;
				break;
			case 4:
				rng = (float)((double)rng * 0.0006213712);
				return;
			}
		}
	}

	private static void Ⴐ(double P_0, double P_1, double P_2, double P_3, ref float P_4, ref float[] P_5, ref float[] P_6)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 12;
		float[] array = default(float[]);
		float[] array4 = default(float[]);
		float[] array5 = default(float[]);
		float[] array3 = default(float[]);
		float[] array2 = default(float[]);
		float num3 = default(float);
		float num2 = default(float);
		while (true)
		{
			switch (num)
			{
			default:
				array = new float[3];
				array4 = new float[3];
				array5 = new float[3];
				array3 = new float[3];
				goto case 6;
			case 6:
				num = ⴃႣ[28] - 41381;
				break;
			case 9:
				array2 = new float[3];
				Ⴀ(P_0, P_1, ref array);
				Ⴀ(P_2, P_3, ref array4);
				num = 8;
				break;
			case 8:
				num3 = Ⴀ(array, array4);
				Ⴅ(array, array4, ref array5);
				num2 = Ⴀ(array5, array5);
				num = 3;
				break;
			case 3:
				num2 = (float)XmlSerializationHelper.Ⴗ(num2, 183, 163);
				P_4 = (float)Ⴄ(num2, num3);
				num = 11;
				break;
			case 11:
				P_4 += Ⴃ(array[2], array4[2], num2, num3, P_4);
				num = ⴃႣ[181] - 42046;
				break;
			case 5:
				P_4 *= 6378137f;
				if ((double)num2 > 3.919639857218495E-06)
				{
					num = ⴃႣ[12] - 27348;
					break;
				}
				while (true)
				{
					P_4 = 0f;
					P_5[1] = 1f;
					P_5[0] = 0f;
					switch (4)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 2:
						break;
					case 4:
						P_6[1] = 1f;
						P_6[0] = 0f;
						return;
					case 0:
					case 1:
						return;
					}
				}
			case 1:
			case 2:
				Ⴃ(array, ref array3, ref array2);
				P_5[1] = Ⴀ(array4, array3) / num2;
				num = 4;
				break;
			case 4:
				P_5[0] = Ⴀ(array4, array2) / num2;
				Ⴃ(array4, ref array3, ref array2);
				num = ⴃႣ[131] - 64721;
				break;
			case 7:
				P_6[1] = (0f - Ⴀ(array, array3)) / num2;
				num = ⴃႣ[194] - 48162;
				break;
			case 10:
				P_6[0] = (0f - Ⴀ(array, array2)) / num2;
				return;
			}
		}
	}

	private static void Ⴀ(double P_0, double P_1, ref float[] P_2)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 4;
		float num2 = default(float);
		float num3 = default(float);
		float num5 = default(float);
		float num4 = default(float);
		float num6 = default(float);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0f;
				num3 = 0f;
				goto case 6;
			case 6:
				num5 = 0f;
				num4 = 0f;
				goto case 1;
			case 1:
				num6 = (float)P_0;
				num = ⴐ[405] - ⴐ[405];
				break;
			case 0:
				Ⴓ(num6, ref num2, ref num3);
				num6 = (float)P_1;
				Ⴓ(num6, ref num5, ref num4);
				num = ⴃႤ[452] - 24071;
				break;
			case 3:
				P_2[0] = num3 * num4;
				P_2[1] = num3 * num5;
				num = ⴗ[135] - 48376;
				break;
			case 5:
				P_2[2] = num2;
				return;
			case 2:
				return;
			}
		}
	}

	private static void Ⴃ(float[] P_0, ref float[] P_1, ref float[] P_2)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 9;
		float num2 = default(float);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 1f - P_0[2] * P_0[2];
				num = ⴃႤ[340] - 34423;
				break;
			case 8:
				num = (((double)num2 < 0.0) ? 1 : 6);
				break;
			case 1:
				num2 = 0f;
				num = 7;
				break;
			case 6:
				num2 = (float)XmlSerializationHelper.Ⴗ(num2, 820, 800);
				num = ⴃႭ[51] - 22354;
				break;
			case 7:
				if ((double)num2 < 3.919639857218495E-06)
				{
					num = 2;
					break;
				}
				while (true)
				{
					P_2[0] = (0f - P_0[1]) / num2;
					int num3 = ⴃႭ[125] - 56417;
					while (true)
					{
						switch (num3)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 4:
						case 6:
							break;
						case 1:
						case 2:
							P_2[1] = P_0[0] / num2;
							goto case 7;
						case 7:
							P_2[2] = 0f;
							num3 = 3;
							continue;
						case 3:
							P_1[0] = (0f - P_2[1]) * P_0[2];
							num3 = 5;
							continue;
						case 5:
							P_1[1] = P_2[0] * P_0[2];
							num3 = 0;
							continue;
						case 0:
							P_1[2] = num2;
							return;
						}
						break;
					}
				}
			case 2:
				P_2[0] = 1f;
				goto case 3;
			case 3:
				P_2[1] = 0f;
				num = 0;
				break;
			case 0:
				P_2[2] = 0f;
				P_1[0] = 0f;
				goto case 10;
			case 10:
				num = ⴃႭ[72] - 28229;
				break;
			case 4:
			case 5:
				P_1[1] = P_0[2];
				P_1[2] = 0f;
				return;
			}
		}
	}

	private static float Ⴃ(float P_0, float P_1, float P_2, float P_3, float P_4)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		float num3 = default(float);
		float num2 = default(float);
		while (true)
		{
			int num = ((!(P_2 > 0.0029043553f)) ? (ⴃႭ[124] - 30972) : 0);
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
				{
					float num4 = P_0 + P_1;
					num3 = num4 * num4 / (1f + P_3);
					goto case 8;
				}
				case 8:
					num = 3;
					continue;
				case 3:
				case 7:
				{
					float num4 = P_0 - P_1;
					num2 = num4 * num4 / (1f - P_3);
					num = ⴗ[140] - 43358;
					continue;
				}
				case 2:
				{
					float num4 = num3;
					num3 = num4 + num2;
					num2 = num4 - num2;
					num = 9;
					continue;
				}
				case 9:
					return 0.0033528106f * ((3f * num2 * P_2 - num3 * P_4) / 4f);
				case 4:
				case 6:
					return 0f;
				}
				break;
			}
		}
	}

	private static double Ⴄ(double P_0, double P_1)
	{
		return Ⴈ(P_0, P_1);
	}

	private static float Ⴀ(float[] P_0, float[] P_1)
	{
		return P_0[0] * P_1[0] + P_0[1] * P_1[1] + P_0[2] * P_1[2];
	}

	private static void Ⴅ(float[] P_0, float[] P_1, ref float[] P_2)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 1;
		double num3 = default(double);
		double num2 = default(double);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = P_0[1];
				num2 = P_0[2];
				num = ⴀ[28] - 35531;
				break;
			case 5:
				P_2[0] = (float)(num3 * (double)P_1[2] - num2 * (double)P_1[1]);
				num = ⴃႭ[154] - 9362;
				break;
			case 3:
			case 4:
				num3 = P_0[0];
				P_2[1] = (float)(num2 * (double)P_1[0] - num3 * (double)P_1[2]);
				num = 2;
				break;
			case 2:
				num2 = P_0[1];
				P_2[2] = (float)(num3 * (double)P_1[1] - num2 * (double)P_1[0]);
				return;
			case 6:
				return;
			}
		}
	}

	private static void Ⴓ(float P_0, ref float P_1, ref float P_2)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 4;
		float num2 = default(float);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = P_0;
				break;
			case 1:
			case 2:
				break;
			case 0:
				P_2 = (float)UtilsCopyright.Ⴍ(num2, 724, 765);
				return;
			}
			P_1 = (float)UtilsCopyright.Ⴍ(num2, 216, 240);
			num = ⴃႣ[178] - ⴃႣ[178];
		}
	}

	private static double Ⴈ(double P_0, double P_1)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		double num2 = default(double);
		while (true)
		{
			int num = ((P_1 != 0.0) ? (ⴐ[351] - 17279) : 10);
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
				case 10:
					num = ((P_0 != 0.0) ? 7 : 12);
					continue;
				case 12:
					return 0.0;
				case 7:
					num = ((!(P_0 > 0.0)) ? (ⴃႤ[554] - 10974) : (ⴃႣ[93] - 25921));
					continue;
				case 0:
					return Math.PI / 2.0;
				case 4:
					return -Math.PI / 2.0;
				case 6:
				case 8:
					num2 = P_0 / P_1;
					num2 = DgvCheckBoxColumnFilter.Ⴃ(num2, 1.0, '÷', 220);
					goto case 3;
				case 3:
					num = 5;
					continue;
				case 5:
					num = ((!(P_1 < 0.0)) ? 13 : 9);
					continue;
				case 9:
					num2 += Math.PI;
					goto case 11;
				case 11:
					num2 = Ⴐ(num2);
					num = 13;
					continue;
				case 13:
					return num2;
				}
				break;
			}
		}
	}

	private static double Ⴐ(double P_0)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		while (true)
		{
			double num = DgvCheckBoxColumnFilter.Ⴄ(P_0, Math.PI * 2.0, 492, 384);
			while (true)
			{
				IL_0056:
				int num2 = ((num > Math.PI) ? (ⴃႭ[62] - 64034) : 0);
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = 8;
						continue;
					case 4:
					case 7:
					case 8:
						break;
					case 6:
						goto IL_0056;
					case 3:
						return num - Math.PI * 2.0;
					case 0:
						num2 = ((!(num <= -Math.PI)) ? 1 : 2);
						continue;
					case 2:
						return num + Math.PI * 2.0;
					case 1:
						return num;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static UtilsLatLon()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static string[] Ⴗ(char P_0, char P_1)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႭ[136] - 62988;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[199] - 9121;
					continue;
				case 0:
				case 4:
					break;
				case 9:
					num2 = (((P_0 ^ P_1) - 53) ^ num) switch
					{
						0 => 3, 
						_ => ⴐ[481] - 29244, 
					};
					continue;
				case 8:
					obj = null;
					num2 = 11;
					continue;
				case 3:
					obj = Environment.GetLogicalDrives();
					num2 = 11;
					continue;
				case 11:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 1;
					continue;
				case 1:
					num2 = ((num3 % 2 != 0) ? (ⴃႣ[187] - 55707) : 6);
					continue;
				case 6:
					return (string[])obj;
				case 5:
				case 7:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Exception Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : Exception
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		ISerializable serializable = default(ISerializable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[300] - 16238;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[180] - ⴐ[180];
					continue;
				case 0:
				case 11:
					break;
				case 2:
					num2 = (((P_2 ^ P_1) - 2) ^ num) switch
					{
						0 => ⴐ[447] - 63937, 
						_ => 9, 
					};
					continue;
				case 9:
					serializable = null;
					goto case 5;
				case 5:
					num2 = ⴗ[115] - 18166;
					continue;
				case 1:
					serializable = P_0.InnerException;
					num2 = 4;
					continue;
				case 4:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 7;
				case 7:
					num2 = 3;
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? 2 : (ⴃႤ[515] - 50901));
					continue;
				case 10:
					return (Exception)serializable;
				case 6:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴜ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, short P_3, short P_4) where _0021_00210 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		IComparable comparable = default(IComparable);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 5:
					num2 = (((P_4 ^ P_3) - 32) ^ num) switch
					{
						0 => 2, 
						_ => ⴃႤ[615] - 35718, 
					};
					continue;
				case 0:
					comparable = null;
					num2 = 4;
					continue;
				case 2:
					comparable = P_0.Substring(P_1, P_2);
					num2 = 4;
					continue;
				case 4:
				case 11:
				{
					num++;
					int num3 = 140;
					int num4 = 145;
					num2 = ((1160 > num4 - num3 * 8) ? (ⴃႣ[83] - 56477) : (ⴃႭ[173] - 11197));
					continue;
				}
				case 8:
					num2 = 5;
					continue;
				case 7:
				case 9:
					return comparable as string;
				case 6:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႥ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : IIoClient where _0021_00211 : OnIoServerConnectEventHandler
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 0;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				break;
			case 5:
				num = (((P_2 ^ P_3) - 26) ^ num2) switch
				{
					0 => 4, 
					_ => 1, 
				};
				break;
			case 1:
				num = 3;
				break;
			case 4:
				P_0(P_1);
				goto case 3;
			case 3:
				num2++;
				num3 = 88;
				goto case 7;
			case 7:
			case 9:
			{
				int num4 = 296;
				num = ((592 > num4 - num3 * 2) ? (ⴐ[54] - 45095) : (ⴃႤ[396] - 9918));
				break;
			}
			case 2:
			case 8:
				num = 5;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly ႷႷ(int P_0, short P_1)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
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
					num2 = 6;
					continue;
				case 6:
					break;
				case 2:
					num2 = (((P_1 ^ P_0) - 97) ^ num) switch
					{
						0 => 3, 
						_ => ⴃႣ[104] - 1861, 
					};
					continue;
				case 7:
					obj = null;
					num2 = 4;
					continue;
				case 3:
				case 5:
				{
					obj = Assembly.GetExecutingAssembly();
					char num5 = ⴗ[31];
					TalkCfg.ႣႣ[44] = (char)((TalkCfg.ႣႣ[44] * P_0) & 0x6C);
					num2 = num5 - 483;
					continue;
				}
				case 4:
				case 11:
				{
					num++;
					int num3 = 286;
					int num4 = 307;
					num2 = ((614 <= num4 - num3 * 2) ? 1 : 8);
					continue;
				}
				case 1:
					num2 = 2;
					continue;
				case 8:
					return obj as Assembly;
				case 9:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] ႷႠ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : MemoryStream
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		Array array = default(Array);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[33] - 33386;
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
				case 5:
					num2 = (((P_2 ^ P_1) - 32) ^ num) switch
					{
						0 => 11, 
						_ => 10, 
					};
					continue;
				case 10:
					array = null;
					num2 = ⴃႤ[330] - 30399;
					continue;
				case 4:
				case 11:
					array = P_0.ToArray();
					num2 = 9;
					continue;
				case 9:
					num++;
					goto case 6;
				case 6:
				{
					int num3 = 140;
					int num4 = 145;
					num2 = ((1160 > num4 - num3 * 8) ? (ⴗ[30] - 17782) : 8);
					continue;
				}
				case 8:
					num2 = 5;
					continue;
				case 2:
				case 3:
					return (byte[])array;
				case 0:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႨ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, char P_3) where _0021_00210 : FileSystemWatcher
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				break;
			case 5:
				num = (((P_3 ^ P_2) - 82) ^ num2) switch
				{
					0 => 8, 
					1 => ⴃႣ[179] - 62086, 
					_ => ⴗ[25] - 18236, 
				};
				break;
			case 4:
				num = ⴐ[361] - 22515;
				break;
			case 8:
				P_0.EnableRaisingEvents = P_1;
				num = ⴐ[48] - 38879;
				break;
			case 7:
				P_0.IncludeSubdirectories = P_1;
				goto case 0;
			case 0:
			case 10:
			{
				num2++;
				int num3 = 750;
				int num4 = 856;
				num = ((3424 > num4 - num3 * 4) ? 1 : 6);
				break;
			}
			case 6:
				num = ⴗ[93] - 712;
				break;
			case 1:
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႷႰ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : Version where _0021_00211 : Version
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[7] - 30490;
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
					num2 = (((P_2 ^ P_3) - 66) ^ num) switch
					{
						0 => ⴀ[342] - 32048, 
						_ => 2, 
					};
					continue;
				case 2:
					result = false;
					num2 = ⴃႭ[245] - 52416;
					continue;
				case 3:
				case 4:
					result = P_0 > P_1;
					num2 = ⴀ[250] - 26009;
					continue;
				case 1:
				case 5:
				case 10:
				{
					num++;
					int num3 = 990;
					int num4 = 103;
					num2 = ((495 < num3 / 2 - num4) ? (ⴗ[141] - 5934) : (ⴃႭ[109] - 6059));
					continue;
				}
				case 7:
					return result;
				case 0:
					num2 = ⴃႣ[96] - 36626;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႭ<_0021_00210>(_0021_00210 P_0, Color P_1, int P_2, int P_3) where _0021_00210 : Control
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 5;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				continue;
			case 0:
			case 4:
				num = (((P_3 ^ P_2) - 66) ^ num2) switch
				{
					0 => 6, 
					_ => ⴐ[431] - 33753, 
				};
				continue;
			case 1:
				num = ⴃႣ[70] - 48569;
				continue;
			case 6:
				P_0.BackColor = P_1;
				goto case 3;
			case 3:
				num2++;
				num3 = 288;
				num4 = 23;
				break;
			case 7:
				break;
			case 8:
				return;
			}
			num = ((96 >= num3 / 3 - num4) ? (ⴀ[114] - 58312) : 0);
		}
	}
}
