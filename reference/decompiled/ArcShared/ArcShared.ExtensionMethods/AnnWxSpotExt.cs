using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using ArcInterfaces.Io;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Pcxx;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.Constants;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods.Login;
using ArcShared.MaintenanceUpdates;
using DxAtlas;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.ExtensionMethods;

public static class AnnWxSpotExt
{
	internal sealed class Ⴈ
	{
		internal OnIoClientRxEventHandler Ⴓ;

		internal OnIoClientConnectEventHandler Ⴀ;

		internal OnIoClientDisconnectEventHandler Ⴃ;

		internal string Ⴍ;

		internal ArcInterfaces.Io.ConnectionState Ⴐ;

		internal DateTime Ⴄ;

		internal Ⴈ()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct ႤႰ
	{
		internal CustomLayer Ⴀ;

		internal float Ⴄ;
	}

	public static string SerializeNode(this AnnWxSpot annWxSpot)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		while (true)
		{
			XName name = Ⴍ(ႣႼ.Ⴜ(3, 365386086, 13), 'Ú', 154);
			Array array = new object[8];
			((object[])array)[0] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 1, 192633812), 'ϝ', 925), StationCfg.ႭႭ(annWxSpot, 'ɓ', 585));
			((object[])array)[1] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 4, 192633812), 'ʤ', 740), GlobalConst.Ⴓ(annWxSpot, 582, 'ɔ'));
			(array as object[])[2] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 0, 192632045), 'ϫ', 939), FrmUpdating.ႠႤ(annWxSpot, 'Μ', 924));
			((object[])array)[3] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 2, 192632037), 'ī', 363), FrmUpdating.ႠႤ(annWxSpot, 'Ǥ', 485));
			(array as object[])[4] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 7, 192633824), 'ȡ', 609), GlobalConst.Ⴓ(annWxSpot, 412, 'Ə'));
			((object[])array)[5] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 2, 192633849), 'ɉ', 521), annWxSpot.WxFlag);
			((object[])array)[6] = new XElement(UtilsString.Ⴐ(null, 3, 192632054), annWxSpot.Route);
			((object[])array)[7] = new XElement(UtilsString.Ⴐ(null, 3, 192631950), annWxSpot.Dts);
			object obj = new XElement(name, array as object[]);
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႤ[530] - 23111;
					continue;
				case 1:
				case 4:
					break;
				case 0:
				case 2:
				{
					string result = ((XElement)obj).ToString();
					NeedsCfg.ႣႤ[77] = (NeedsCfg.ႣႤ[77] ^ NeedsCfg.ႣႤ[412]) & 0xC7;
					return result;
				}
				}
				break;
			}
		}
	}

	public static void DeserializeNode(this AnnWxSpot annWxSpot, string msg)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = DgvCheckBoxColumnFilter.Ⴓ(msg, 'ϐ', 1019);
		object enumerator = ((XElement)obj).Elements().GetEnumerator();
		try
		{
			int num = 0;
			object current = default(object);
			IConvertible convertible = default(IConvertible);
			IEnumerable enumerable = default(IEnumerable);
			int value = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					num = ⴗ[82] - 54109;
					continue;
				case 7:
					current = ((IEnumerator<XElement>)enumerator).Current;
					convertible = DxCommentExtCfg.ႷႭ(UtilsXml.Ⴓ((XElement)current, 919, 'Ό'), 211, 209);
					num = ⴗ[42] - 36991;
					continue;
				case 15:
					num = (((enumerable = convertible as string) == null) ? 10 : (ⴐ[307] - ⴐ[433]));
					continue;
				case 4:
					num = ((ႰႣ.Ⴈ != null) ? (ⴃႭ[67] - 30147) : 2);
					continue;
				case 2:
					ႰႣ.Ⴈ = new Dictionary<string, int>(8)
					{
						{
							UtilsString.Ⴐ(null, 2, 192633815),
							0
						},
						{
							UtilsString.Ⴐ(null, 7, 192633815),
							1
						},
						{
							UtilsString.Ⴐ(null, 3, 192632046),
							2
						},
						{
							UtilsString.Ⴐ(null, 2, 192632037),
							3
						},
						{
							UtilsString.Ⴐ(null, 1, 192633830),
							4
						},
						{
							UtilsString.Ⴐ(null, 1, 192633850),
							5
						},
						{
							UtilsString.Ⴐ(null, 2, 192632055),
							6
						},
						{
							UtilsString.Ⴐ(null, 5, 192631944),
							7
						}
					};
					num = ⴐ[168] - 4246;
					continue;
				case 5:
					num = ((!ႰႣ.Ⴈ.TryGetValue(enumerable as string, out value)) ? (ⴃႤ[413] - 24174) : (ⴀ[370] - 60426));
					continue;
				case 11:
					num = value switch
					{
						0 => 21, 
						1 => 3, 
						2 => 1, 
						3 => 17, 
						4 => ⴃႣ[214] - 56052, 
						5 => 13, 
						6 => ⴀ[43] - 13269, 
						7 => 8, 
						_ => ⴃႤ[188] - 25839, 
					};
					continue;
				case 9:
					num = 10;
					continue;
				case 20:
				case 21:
					PcxxServerClient.Ⴗ(annWxSpot, FrmUpdating.ႠႭ(current as XElement, 962, 906), 153, 'î');
					goto case 6;
				case 6:
					num = ⴃႣ[176] - 11036;
					continue;
				case 3:
				case 16:
					StationCfg.ႭႤ(annWxSpot, FrmUpdating.ႠႭ(current as XElement, 758, 702), 829, '\u0343');
					num = ⴃႣ[2] - 5258;
					continue;
				case 1:
					UtilsIdentity.Ⴍ(annWxSpot, FrmUpdating.ႠႭ(current as XElement, 741, 685), 'A', '.');
					num = 10;
					continue;
				case 17:
					UtilsSql.ႨႭ(annWxSpot, FrmUpdating.ႠႭ(current as XElement, 618, 546), 441, 486);
					num = 10;
					continue;
				case 14:
					annWxSpot.SysopFlag = (current as XElement).Value;
					num = 10;
					continue;
				case 13:
					annWxSpot.WxFlag = ((XElement)current).Value;
					num = 10;
					continue;
				case 12:
					annWxSpot.Route = (current as XElement).Value;
					num = 10;
					continue;
				case 8:
					annWxSpot.Dts = Convert.ToDateTime((current as XElement).Value);
					break;
				case 10:
					break;
				case 19:
					goto end_IL_004f;
				}
				num = (((IEnumerator<XElement>)enumerator).MoveNext() ? 7 : 19);
				continue;
				end_IL_004f:
				break;
			}
		}
		finally
		{
			int num2 = 6;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = (((IEnumerator<XElement>)enumerator == null) ? 1 : 5);
					goto IL_0426;
				case 4:
				case 5:
					((IEnumerator<XElement>)enumerator).Dispose();
					break;
				case 0:
				case 1:
				case 2:
					break;
				}
				break;
				IL_0426:
				num2 = num3;
			}
		}
		switch (0)
		{
		}
	}

	public static string SerializeClient(this AnnWxSpot annWxSpot)
	{
		while (true)
		{
			XName name = Ⴍ(ArcLogInRqstExt.Ⴗ(1706507526, 1, 1), 'Ɵ', 479);
			Array array = new object[10];
			(array as object[])[0] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 5, 192633808), 'ϗ', 919), StationCfg.ႭႭ(annWxSpot, 'Κ', 896));
			((object[])array)[1] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 1, 192633809), 'ż', 316), GlobalConst.Ⴓ(annWxSpot, 111, '}'));
			((object[])array)[2] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 7, 192632042), '\u02e8', 680), FrmUpdating.ႠႤ(annWxSpot, 'ο', 959));
			(array as object[])[3] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 3, 192632036), 'Δ', 980), FrmUpdating.ႠႤ(annWxSpot, '\u0309', 776));
			((object[])array)[4] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 6, 192633825), 'ː', 656), GlobalConst.Ⴓ(annWxSpot, 497, 'Ǣ'));
			((object[])array)[5] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 2, 192633849), '\u02c5', 645), PrecisionTimer.ႤႼ(annWxSpot, 608, 559));
			(array as object[])[6] = new XElement(Ⴍ(TelnetServerClient.Ⴄ(1945322920, 'ø', 2), 'ȿ', 639), FrmUpdating.ႠႤ(annWxSpot, '\u0381', 899));
			((object[])array)[7] = new XElement(DownloadUrl2.Ⴅ(2, null, 2018868927, 7), annWxSpot.SpotterState);
			(array as object[])[8] = new XElement(ArcLogInRqstExt.Ⴗ(1706507769, 19, 8), annWxSpot.SpotterCont);
			(array as object[])[9] = new XElement(UtilsString.Ⴐ(null, 5, 192631944), annWxSpot.Dts);
			XContainer xContainer = new XElement(name, array as object[]);
			while (true)
			{
				IL_0253:
				int num = 2;
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
					case 3:
						goto IL_0253;
					case 1:
					case 2:
						return ((XElement)xContainer).ToString();
					}
					break;
				}
				break;
			}
		}
	}

	public static void DeserializeClient(this AnnWxSpot annWxSpot, string msg)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = DgvCheckBoxColumnFilter.Ⴓ(msg, 'ƍ', 422);
		object enumerator = (obj as XElement).Elements().GetEnumerator();
		try
		{
			int num = 4;
			XContainer current = default(XContainer);
			ICloneable cloneable = default(ICloneable);
			IComparable comparable = default(IComparable);
			int value = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					num = ⴐ[449] - 43496;
					continue;
				case 12:
					current = (enumerator as IEnumerator<XElement>).Current;
					cloneable = DxCommentExtCfg.ႷႭ(UtilsXml.Ⴓ(current as XElement, 215, 'Ì'), 356, 358);
					num = ⴗ[135] - 48367;
					continue;
				case 14:
					num = (((comparable = cloneable as string) == null) ? 7 : (ⴃႭ[32] - 53223));
					continue;
				case 15:
					num = ((ႰႣ.Ⴃ != null) ? 8 : 13);
					continue;
				case 13:
					ႰႣ.Ⴃ = new Dictionary<string, int>(10)
					{
						{
							UtilsString.Ⴐ(null, 2, 192633815),
							0
						},
						{
							UtilsString.Ⴐ(null, 4, 192633812),
							1
						},
						{
							UtilsString.Ⴐ(null, 7, 192632042),
							2
						},
						{
							UtilsString.Ⴐ(null, 4, 192632035),
							3
						},
						{
							UtilsString.Ⴐ(null, 7, 192633824),
							4
						},
						{
							UtilsString.Ⴐ(null, 3, 192633848),
							5
						},
						{
							TelnetServerClient.Ⴄ(1945322914, '\u0017', 8),
							6
						},
						{
							DownloadUrl2.Ⴅ(10, null, 2018868926, 6),
							7
						},
						{
							ArcLogInRqstExt.Ⴗ(1706507764, 6, 5),
							8
						},
						{
							UtilsString.Ⴐ(null, 8, 192631941),
							9
						}
					};
					num = 8;
					continue;
				case 8:
					num = ((!ႰႣ.Ⴃ.TryGetValue((string)comparable, out value)) ? 7 : 0);
					continue;
				case 0:
					num = value switch
					{
						0 => 3, 
						1 => ⴃႣ[102] - 27308, 
						2 => ⴀ[17] - 63638, 
						3 => 2, 
						4 => 23, 
						5 => 19, 
						6 => ⴐ[519] - 58352, 
						7 => 17, 
						8 => ⴐ[161] - 4784, 
						9 => 22, 
						_ => ⴀ[154] - 28009, 
					};
					continue;
				case 5:
				case 18:
					num = ⴀ[263] - 4036;
					continue;
				case 3:
					PcxxServerClient.Ⴗ(annWxSpot, FrmUpdating.ႠႭ(current as XElement, 618, 546), 893, '\u030a');
					num = ⴗ[155] - 49740;
					continue;
				case 21:
					StationCfg.ႭႤ(annWxSpot, FrmUpdating.ႠႭ(current as XElement, 975, 903), 457, 'Ʒ');
					num = 7;
					continue;
				case 6:
					UtilsIdentity.Ⴍ(annWxSpot, FrmUpdating.ႠႭ(current as XElement, 445, 501), 'ǘ', 'Ʒ');
					num = ⴀ[241] - 35027;
					continue;
				case 2:
					UtilsSql.ႨႭ(annWxSpot, FrmUpdating.ႠႭ(current as XElement, 177, 249), 216, 135);
					num = 7;
					continue;
				case 23:
					StationCfg.ႭႤ(annWxSpot, FrmUpdating.ႠႭ(current as XElement, 375, 319), 723, 'ʬ');
					num = 7;
					continue;
				case 19:
					annWxSpot.WxFlag = ((XElement)current).Value;
					num = 7;
					continue;
				case 10:
					annWxSpot.SpotterCty = ((XElement)current).Value;
					num = 7;
					continue;
				case 17:
					annWxSpot.SpotterState = (current as XElement).Value;
					num = 7;
					continue;
				case 9:
					annWxSpot.SpotterCont = ((XElement)current).Value;
					goto case 20;
				case 20:
					num = ⴗ[140] - 43353;
					continue;
				case 1:
				case 22:
					annWxSpot.Dts = Convert.ToDateTime(((XElement)current).Value);
					break;
				case 7:
					break;
				case 11:
					goto end_IL_0048;
				}
				num = ((enumerator as IEnumerator<XElement>).MoveNext() ? 12 : 11);
				continue;
				end_IL_0048:
				break;
			}
		}
		finally
		{
			int num2 = 2;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = (((IEnumerator<XElement>)enumerator == null) ? 6 : (ⴃႭ[95] - 32054));
					goto IL_04b6;
				case 4:
					(enumerator as IEnumerator<XElement>).Dispose();
					break;
				case 6:
					break;
				}
				break;
				IL_04b6:
				num2 = num3;
			}
		}
		switch (4)
		{
		}
	}

	public static string SerializeClientSpot(this AnnWxSpot annWxSpot)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			XName name = Ⴍ(DownloadUrl2.Ⴅ(16, null, 2018868906, 3), 'Ɵ', 479);
			object obj = new object[4];
			((object[])obj)[0] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 0, 192633813), 'ǒ', 402), StationCfg.ႭႭ(annWxSpot, 'ȟ', 517));
			((object[])obj)[1] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 1, 192632044), 'ű', 305), FrmUpdating.ႠႤ(annWxSpot, '@', 64));
			((object[])obj)[2] = new XElement(Ⴍ(UtilsString.Ⴐ(null, 3, 192633811), 'Ȗ', 598), GlobalConst.Ⴓ(annWxSpot, 701, 'ʯ'));
			((object[])obj)[3] = new XElement(UtilsString.Ⴐ(null, 4, 192633855), annWxSpot.WxFlag);
			object obj2 = new XElement(name, (object[])obj);
			char num = ⴗ[8];
			TalkCfg.ႣႣ[43] = (char)((TalkCfg.ႣႣ[43] * TalkCfg.ႣႣ[124]) & 0x8D);
			int num2 = num - 15537;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 4;
					continue;
				case 2:
				case 4:
				case 5:
					break;
				case 1:
					return (obj2 as XElement).ToString();
				}
				break;
			}
		}
	}

	public static void DeserializeClientSpot(this AnnWxSpot annWxSpot, string msg)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IXmlSerializable xmlSerializable = DgvCheckBoxColumnFilter.Ⴓ(msg, 'ɵ', 606);
		object enumerator = (xmlSerializable as XElement).Elements().GetEnumerator();
		try
		{
			int num = 13;
			IXmlSerializable current = default(IXmlSerializable);
			object obj = default(object);
			IEnumerable enumerable = default(IEnumerable);
			while (true)
			{
				switch (num)
				{
				default:
					num = ⴃႣ[93] - 25905;
					continue;
				case 0:
				case 1:
					current = ((IEnumerator<XElement>)enumerator).Current;
					obj = DxCommentExtCfg.ႷႭ(UtilsXml.Ⴓ(current as XElement, 151, '\u008c'), 970, 968);
					num = ⴃႤ[554] - 10975;
					continue;
				case 3:
				case 11:
					num = (((enumerable = (string)obj) == null) ? 16 : 6);
					continue;
				case 6:
					num = (FrmUpdating.ႠႥ((string)enumerable, UtilsString.Ⴐ(null, 4, 192633809), 655, 691) ? 10 : 2);
					continue;
				case 2:
					num = (FrmUpdating.ႠႥ((string)enumerable, UtilsString.Ⴐ(null, 3, 192632046), 607, 611) ? 7 : 8);
					continue;
				case 8:
					num = (FrmUpdating.ႠႥ(enumerable as string, UtilsString.Ⴐ(null, 2, 192633810), 448, 508) ? 17 : (ⴃႤ[222] - 57354));
					continue;
				case 5:
				{
					bool num2 = FrmUpdating.ႠႥ((string)enumerable, UtilsString.Ⴐ(null, 1, 192633850), 769, 829);
					TalkCfg.ႣႣ[139] = (char)((TalkCfg.ႣႣ[139] ^ TalkCfg.ႣႣ[207]) & 0xD9);
					num = (num2 ? 15 : 4);
					continue;
				}
				case 4:
					num = ⴗ[33] - 33375;
					continue;
				case 10:
					PcxxServerClient.Ⴗ(annWxSpot, FrmUpdating.ႠႭ(current as XElement, 912, 984), 687, '\u02d8');
					num = 16;
					continue;
				case 7:
					annWxSpot.Spotter = (current as XElement).Value;
					num = 16;
					continue;
				case 14:
				case 17:
					annWxSpot.Msg = (current as XElement).Value;
					num = 16;
					continue;
				case 15:
					annWxSpot.WxFlag = ((XElement)current).Value;
					break;
				case 16:
					break;
				case 12:
					goto end_IL_0042;
				}
				num = (((IEnumerator<XElement>)enumerator).MoveNext() ? 1 : (ⴐ[98] - 35668));
				continue;
				end_IL_0042:
				break;
			}
		}
		finally
		{
			int num3 = 5;
			while (true)
			{
				int num4;
				switch (num3)
				{
				default:
					num4 = (((IEnumerator<XElement>)enumerator == null) ? (ⴃႣ[174] - 9359) : 2);
					goto IL_02c9;
				case 2:
				case 6:
					(enumerator as IEnumerator<XElement>).Dispose();
					break;
				case 3:
					break;
				}
				break;
				IL_02c9:
				num3 = num4;
			}
		}
		switch (4)
		{
		}
	}

	public static string GetUserString(this AnnWxSpot annWx)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		Array array2 = default(Array);
		Array array = default(Array);
		while (true)
		{
			IComparable<string> comparable = string.Empty;
			int num = ((!FrmUpdating.ႠႥ(PrecisionTimer.ႤႼ(annWx, 488, 423), UtilsString.Ⴐ(null, 5, 192631418), 359, 347)) ? (ⴐ[77] - 8249) : 13);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴗ[8] - 15527;
					continue;
				case 11:
					break;
				case 13:
					array2 = new string[6];
					((string[])array2)[0] = TelnetServerClient.Ⴄ(1945322937, 'Ã', 6);
					num = 9;
					continue;
				case 9:
					(array2 as string[])[1] = FrmUpdating.ႠႤ(annWx, '=', 61);
					((string[])array2)[2] = TelnetServerClient.Ⴄ(1945322598, 'ý', 6);
					goto case 12;
				case 12:
				{
					char num2 = ⴗ[115];
					TalkCfg.ႣႣ[51] = (char)(TalkCfg.ႣႣ[51] & UtilsNumeric.Ⴀ[197] & 0x5C);
					num = num2 - 18156;
					continue;
				}
				case 14:
				{
					string[] obj = (string[])array2;
					DateTime dateTime = DxAtlasData.Ⴈ(252, 180);
					obj[3] = DgvTextBoxColumnFilter.Ⴈ(ref dateTime, ႣႼ.Ⴜ(7, 365386096, 16), 258, 321);
					num = 6;
					continue;
				}
				case 6:
					(array2 as string[])[4] = UtilsString.Ⴐ(null, 2, 192633840);
					((string[])array2)[5] = GlobalConst.Ⴓ(annWx, 762, '\u02e8');
					num = 2;
					continue;
				case 2:
					comparable = DgvDateColumnFilter.Ⴀ(array2 as string[], 'ȍ', 'Ȯ');
					num = ⴃႤ[515] - 50908;
					continue;
				case 4:
					array = new string[8];
					(array as string[])[0] = DownloadUrl2.Ⴅ(19, null, 2018869058, 3);
					num = 8;
					continue;
				case 8:
					((string[])array)[1] = StationCfg.ႭႭ(annWx, 'ç', 253);
					((string[])array)[2] = ႣႼ.Ⴜ(2, 365387275, 2);
					goto case 0;
				case 0:
					num = 10;
					continue;
				case 5:
				case 10:
					(array as string[])[3] = FrmUpdating.ႠႤ(annWx, 'υ', 965);
					(array as string[])[4] = TelnetServerClient.Ⴄ(1945322599, 'G', 7);
					num = 7;
					continue;
				case 7:
					(array as string[])[5] = DxAtlasData.Ⴈ(603, 531).ToString(ႣႼ.Ⴜ(5, 365386098, 16));
					num = 1;
					continue;
				case 1:
					(array as string[])[6] = UtilsString.Ⴐ(null, 2, 192633840);
					(array as string[])[7] = annWx.Msg;
					num = 15;
					continue;
				case 15:
					comparable = string.Concat(array as string[]);
					num = 3;
					continue;
				case 3:
					return (string)comparable;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static AnnWxSpotExt()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DataGridViewColumn
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		ICloneable cloneable = default(ICloneable);
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
					num2 = (((P_2 ^ P_1) - 41) ^ num) switch
					{
						0 => 7, 
						_ => 0, 
					};
					continue;
				case 0:
					cloneable = null;
					num2 = ⴃႤ[396] - 9916;
					continue;
				case 6:
				case 7:
					cloneable = P_0.HeaderText;
					num2 = ⴐ[54] - 45091;
					continue;
				case 3:
				case 10:
				{
					num++;
					int num3 = 2463;
					int num4 = 250;
					num2 = ((821 < num3 / 3 - num4) ? 1 : 5);
					continue;
				}
				case 2:
				case 5:
					return cloneable as string;
				case 4:
					num2 = ⴀ[225] - 22442;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : IWebProxy where _0021_00211 : WebRequest
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 5;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 6;
				break;
			case 6:
				num = (((P_3 ^ P_2) - 49) ^ num3) switch
				{
					0 => 7, 
					_ => 2, 
				};
				break;
			case 2:
				num = ⴃႣ[104] - 1865;
				break;
			case 7:
				P_0.Proxy = P_1;
				goto case 3;
			case 3:
				num3++;
				goto case 9;
			case 9:
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				goto case 8;
			case 8:
				num = 4;
				break;
			case 4:
				num = ((num2 % 2 == 0) ? 1 : (ⴗ[31] - 481));
				break;
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static IEnumerator Ⴃ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : InternalDataCollectionBase
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 3;
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
				case 3:
					num2 = (((P_1 ^ P_2) - 99) ^ num) switch
					{
						0 => ⴃႣ[19] - 59486, 
						_ => 6, 
					};
					continue;
				case 6:
					obj = null;
					num2 = ⴐ[320] - 49919;
					continue;
				case 5:
					obj = P_0.GetEnumerator();
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = ⴗ[1] - 50400;
					continue;
				case 4:
				case 9:
					num2 = ((num3 % 2 != 0) ? 3 : 0);
					continue;
				case 0:
				case 10:
					return obj as IEnumerator;
				case 11:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : string where _0021_00211 : ListControl
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 9;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 10;
				break;
			case 10:
				num = (((P_3 ^ P_2) - 61) ^ num3) switch
				{
					0 => ⴐ[196] - 11168, 
					1 => ⴐ[501] - 23263, 
					_ => 3, 
				};
				break;
			case 2:
			case 3:
				num = 0;
				break;
			case 6:
				P_0.ValueMember = P_1;
				num = ⴗ[50] - ⴗ[50];
				break;
			case 4:
			case 8:
				P_0.DisplayMember = P_1;
				goto case 0;
			case 0:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = ⴗ[23] - 59667;
				break;
			case 5:
				num = ((num2 % 2 != 0) ? 10 : (ⴗ[28] - 12117));
				break;
			case 1:
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴗ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DateTimePicker
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		DateTime result = default(DateTime);
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
					num2 = ⴐ[202] - 9419;
					continue;
				case 5:
					break;
				case 6:
					num2 = (((P_1 ^ P_2) - 46) ^ num) switch
					{
						0 => 0, 
						_ => 1, 
					};
					continue;
				case 1:
					result = default(DateTime);
					num2 = 9;
					continue;
				case 0:
				case 8:
					result = P_0.Value;
					num2 = ⴃႣ[214] - 56057;
					continue;
				case 3:
				case 9:
					num++;
					goto case 4;
				case 4:
				{
					int num3 = 1665;
					int num4 = 463;
					num2 = ((555 < num3 / 3 - num4) ? (ⴀ[342] - 32045) : (ⴀ[400] - 20047));
					continue;
				}
				case 10:
					return result;
				case 2:
					num2 = ⴃႭ[245] - 52420;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static char Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, int P_3) where _0021_00210 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char result = default(char);
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
					num2 = 7;
					continue;
				case 3:
				case 7:
					break;
				case 2:
					num2 = (((P_2 ^ P_3) - 59) ^ num) switch
					{
						0 => 5, 
						_ => ⴃႤ[500] - 25124, 
					};
					continue;
				case 8:
					result = '0';
					num2 = 10;
					continue;
				case 4:
				case 5:
					result = P_0[P_1];
					num2 = ⴃႤ[287] - 4283;
					continue;
				case 10:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴀ[134] - 27352) : 0);
					continue;
				case 0:
					num2 = ⴀ[114] - 58318;
					continue;
				case 9:
				case 11:
					return result;
				case 1:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴐ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : MemberInfo
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[212] - 7571;
			while (true)
			{
				switch (num2)
				{
				default:
				{
					/*OpCode not supported: LdMemberToken*/;
					char num5 = ⴃႭ[211];
					DataGridViewColumnSelector.Ⴐ[149] = (char)((DataGridViewColumnSelector.Ⴐ[149] - NeedsCfg.ႣႤ[314]) & 0xF4);
					num2 = num5 - 64276;
					continue;
				}
				case 2:
					break;
				case 3:
				case 10:
					num2 = (((P_1 ^ P_2) - 100) ^ num) switch
					{
						0 => 8, 
						_ => 7, 
					};
					continue;
				case 7:
					cloneable = null;
					num2 = 1;
					continue;
				case 8:
					cloneable = P_0.Name;
					num2 = ⴃႭ[153] - 46369;
					continue;
				case 0:
				case 1:
				{
					num++;
					int num3 = 2364;
					int num4 = 77;
					num2 = ((591 < num3 / 4 - num4) ? 10 : 5);
					continue;
				}
				case 5:
					return (string)cloneable;
				case 6:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static XName Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object obj = default(object);
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
					num2 = ⴃႣ[136] - 56827;
					continue;
				case 8:
					break;
				case 0:
					num2 = (((P_2 ^ P_1) - 64) ^ num) switch
					{
						0 => ⴀ[387] - 45963, 
						_ => 2, 
					};
					continue;
				case 2:
					obj = null;
					num2 = 6;
					continue;
				case 9:
					obj = (XName)P_0;
					num2 = 6;
					continue;
				case 6:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴗ[42] - 37001) : (ⴃႣ[176] - 11039));
					continue;
				case 7:
					num2 = ⴐ[169] - ⴐ[169];
					continue;
				case 4:
				case 5:
				case 11:
					return (XName)obj;
				case 3:
				case 10:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴜ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : WwvSpot
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
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
					num2 = ⴃႤ[158] - 42309;
					continue;
				case 1:
					break;
				case 8:
					num2 = (((P_1 ^ P_2) - 74) ^ num) switch
					{
						0 => ⴀ[387] - 45968, 
						_ => 10, 
					};
					continue;
				case 10:
					enumerable = null;
					goto case 9;
				case 9:
					num2 = ⴐ[168] - 4248;
					continue;
				case 4:
				{
					enumerable = P_0.K;
					int num5 = ⴃႤ[317];
					TalkCfg.ႣႣ[200] = (char)((TalkCfg.ႣႣ[200] + P_1) & 0x4F);
					num2 = num5 - 38171;
					continue;
				}
				case 3:
				case 5:
				{
					num++;
					int num3 = 990;
					int num4 = 103;
					num2 = ((495 < num3 / 2 - num4) ? (ⴐ[558] - 19589) : 6);
					continue;
				}
				case 6:
					return (string)enumerable;
				case 7:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static XmlNode ႤႠ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string where _0021_00211 : XmlNode
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
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
				{
					/*OpCode not supported: LdMemberToken*/;
					char num5 = ⴀ[63];
					WxCfg.ႣႭ[210] = (char)((WxCfg.ႣႭ[210] + P_2) & 0x84);
					num2 = num5 - 17143;
					continue;
				}
				case 10:
					break;
				case 1:
					num2 = (((P_2 ^ P_3) - 74) ^ num) switch
					{
						0 => ⴃႤ[550] - 2689, 
						_ => 11, 
					};
					continue;
				case 11:
					obj = null;
					num2 = ⴃႣ[131] - 64724;
					continue;
				case 2:
					obj = P_0.SelectSingleNode(P_1);
					num2 = ⴗ[68] - 17892;
					continue;
				case 4:
				{
					num++;
					int num3 = 39;
					int num4 = 214;
					num2 = ((1926 > num4 - num3 * 9) ? (ⴃႣ[215] - 32471) : 3);
					continue;
				}
				case 3:
					num2 = ⴐ[415] - 57869;
					continue;
				case 9:
					return obj as XmlNode;
				case 6:
				case 7:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly ႤႤ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : Type
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
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
					num2 = 0;
					continue;
				case 0:
					break;
				case 8:
				case 10:
					num2 = (((P_2 ^ P_1) - 64) ^ num) switch
					{
						0 => ⴐ[417] - 34248, 
						_ => 3, 
					};
					continue;
				case 3:
					obj = null;
					num2 = ⴐ[153] - 64106;
					continue;
				case 1:
				case 11:
					obj = P_0.Assembly;
					num2 = 2;
					continue;
				case 2:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴃႣ[21] - ⴃႣ[104]) : 9);
					continue;
				case 9:
					num2 = ⴃႤ[320] - 20175;
					continue;
				case 4:
					return obj as Assembly;
				case 5:
				case 6:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႤႣ<_0021_00210>(_0021_00210 P_0, byte[] P_1, char P_2, int P_3) where _0021_00210 : Encoding
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႤ[92] - 49887;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[13] - 37646;
					continue;
				case 1:
					break;
				case 10:
					num2 = (((P_3 ^ P_2) - 64) ^ num) switch
					{
						0 => 11, 
						_ => 0, 
					};
					continue;
				case 0:
				case 5:
					obj = null;
					num2 = 4;
					continue;
				case 3:
				case 11:
					obj = P_0.GetString(P_1);
					num2 = ⴗ[52] - 52159;
					continue;
				case 4:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 7 : 8);
					continue;
				case 2:
				case 8:
					num2 = ⴀ[85] - 17496;
					continue;
				case 7:
					return (string)obj;
				case 9:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႤႳ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : string where _0021_00211 : DxSpot
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 2;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 6;
				break;
			case 6:
				num = (((P_2 ^ P_3) - 100) ^ num3) switch
				{
					0 => 8, 
					1 => 3, 
					2 => 11, 
					_ => ⴃႣ[178] - 54146, 
				};
				break;
			case 4:
				num = 0;
				break;
			case 8:
				P_0.Call = P_1;
				num = ⴗ[24] - 30805;
				break;
			case 3:
			case 7:
				P_0.Grid = P_1;
				num = ⴀ[214] - 40461;
				break;
			case 11:
				P_0.Cty = P_1;
				goto case 0;
			case 0:
			case 5:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 1;
				break;
			case 1:
				num = ((num2 % 2 != 0) ? (ⴐ[225] - 26608) : (ⴃႭ[10] - 46793));
				break;
			case 9:
			case 10:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႤႷ<_0021_00210>(_0021_00210 P_0, DockStyle P_1, short P_2, int P_3) where _0021_00210 : Control
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 3;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 1;
				break;
			case 1:
			case 5:
				num = (((P_2 ^ P_3) - 49) ^ num3) switch
				{
					0 => ⴃႭ[216] - 27133, 
					_ => 4, 
				};
				break;
			case 4:
				num = 7;
				break;
			case 6:
				P_0.Dock = P_1;
				goto case 7;
			case 7:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				goto case 0;
			case 0:
			case 9:
				num = ⴗ[51] - 12332;
				break;
			case 2:
				num = ((num2 % 2 != 0) ? 1 : (ⴀ[166] - 10213));
				break;
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float ႤႥ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : PerformanceCounter
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		float result = default(float);
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
					num2 = ⴃႤ[532] - 51864;
					continue;
				case 2:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 5) ^ num) switch
					{
						0 => 11, 
						_ => 1, 
					};
					continue;
				case 1:
					result = 149f / 153f;
					num2 = ⴃႤ[305] - 20881;
					continue;
				case 11:
					result = P_0.NextValue();
					num2 = 0;
					continue;
				case 0:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 10 : (ⴃႭ[49] - 57583));
					continue;
				case 3:
				case 6:
					num2 = 4;
					continue;
				case 8:
				case 10:
					return result;
				case 5:
				case 9:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႤႨ<_0021_00210, _0021_00211, _0021_00212>(_0021_00210 P_0, _0021_00211 P_1, _0021_00212 P_2, short P_3, short P_4) where _0021_00210 : XmlSerializer where _0021_00211 : TextWriter
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴗ[45] - 54530;
				break;
			case 9:
				num = (((P_3 ^ P_4) - 83) ^ num2) switch
				{
					0 => ⴀ[332] - 59870, 
					_ => 5, 
				};
				break;
			case 0:
			case 5:
				num = 3;
				break;
			case 6:
				P_0.Serialize(P_1, P_2);
				goto case 3;
			case 3:
			case 7:
			case 8:
				num2++;
				num = (((P_4 * P_4 + P_4) % 2 != 0) ? 1 : (ⴀ[305] - 48557));
				break;
			case 1:
				num = ⴗ[140] - 43351;
				break;
			case 4:
				NeedsCfg.ႣႤ[545] = (NeedsCfg.ႣႤ[545] - P_3) & 0xAD;
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type ႤႭ(Guid P_0, short P_1, char P_2)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		IReflect reflect = default(IReflect);
		int num3 = default(int);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 90) ^ num) switch
					{
						0 => 8, 
						_ => ⴃႣ[196] - 52699, 
					};
					continue;
				case 1:
					reflect = typeof(ChatRoomPubUpdate);
					num2 = 2;
					continue;
				case 4:
				case 8:
					reflect = Type.GetTypeFromCLSID(P_0);
					num2 = 2;
					continue;
				case 2:
				case 11:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 5;
					continue;
				case 5:
					num2 = ((num3 % 2 != 0) ? 9 : (ⴗ[102] - 41108));
					continue;
				case 7:
					return (Type)reflect;
				case 0:
				case 10:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Brush ႤႼ(short P_0, char P_1)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		IDisposable disposable = default(IDisposable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[50] - 11835;
					continue;
				case 6:
					break;
				case 3:
					num2 = (((P_1 ^ P_0) - 6) ^ num) switch
					{
						0 => ⴃႣ[106] - 63629, 
						_ => ⴐ[276] - 59387, 
					};
					continue;
				case 0:
					disposable = null;
					goto case 10;
				case 10:
					num2 = 4;
					continue;
				case 9:
					disposable = Brushes.LightYellow;
					num2 = 4;
					continue;
				case 4:
					num++;
					num3 = 1419;
					goto case 8;
				case 8:
				{
					int num4 = 1;
					int num5 = num3 / 3 - num4;
					DxCfg.Ⴗ[66] = (char)((DxCfg.Ⴗ[66] ^ TalkCfg.ႣႣ[100]) & 0xE6);
					num2 = ((473 >= num5) ? 1 : (ⴃႭ[232] - 45204));
					continue;
				}
				case 1:
				case 7:
					return disposable as Brush;
				case 5:
					num2 = ⴐ[179] - 53083;
					continue;
				}
				break;
			}
		}
	}
}
