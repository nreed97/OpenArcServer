using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Security;
using System.Windows.Forms;
using System.Xml.Linq;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter.Extensions;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods.Login;
using ArcShared.Forms;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.ExtensionMethods;

public static class DxSpotExt
{
	public static string SerializeNode(this DxSpot dxSpot)
	{
		while (true)
		{
			XName name = AnnWxSpotExt.Ⴍ(ႣႼ.Ⴜ(2, 365386118, 31), '\u009d', 221);
			object obj = new object[7];
			((object[])obj)[0] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 7, 192632121), 'ɾ', 574), UtilsCopyright.Ⴐ(dxSpot, 'ȿ', 'ȅ'));
			((object[])obj)[1] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 0, 192633583), 'ľ', 382), ႣႼ.ႰႷ(dxSpot, 319, 293));
			((object[])obj)[2] = new XElement(AnnWxSpotExt.Ⴍ(ႣႼ.Ⴜ(8, 365386141, 19), 'ʛ', 731), ႣႼ.ႰႭ(dxSpot, 612, 606));
			((object[])obj)[3] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 5, 192632040), '\u0097', 215), UtilsCallsign.Ⴜ(dxSpot, 347, 279));
			((object[])obj)[4] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 2, 192632037), '=', 125), UtilsEmail.Ⴍ(dxSpot, 44, 'q'));
			((object[])obj)[5] = new XElement(UtilsString.Ⴐ(null, 4, 192632049), dxSpot.Route);
			((object[])obj)[6] = new XElement(UtilsString.Ⴐ(null, 7, 192631946), dxSpot.Dts);
			object obj2 = new XElement(name, (object[])obj);
			while (true)
			{
				IL_01b8:
				int num = 3;
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
						goto IL_01b8;
					case 3:
					{
						string result = (obj2 as XElement).ToString();
						WxCfg.ႣႭ[142] = (char)((WxCfg.ႣႭ[142] * DataGridViewColumnSelector.Ⴐ[93]) & 0xFA);
						return result;
					}
					}
					break;
				}
				break;
			}
		}
	}

	public static void DeserializeNode(this DxSpot dxSpot, string msg)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		XContainer xContainer = DgvCheckBoxColumnFilter.Ⴓ(msg, '\u02ef', 708);
		object enumerator = ((XElement)xContainer).Elements().GetEnumerator();
		try
		{
			int num = 18;
			object current = default(object);
			IConvertible convertible = default(IConvertible);
			int value = default(int);
			while (true)
			{
				switch (num)
				{
				case 5:
				{
					current = ((IEnumerator<XElement>)enumerator).Current;
					int num3;
					if ((convertible = DxCommentExtCfg.ႷႭ(UtilsXml.Ⴓ((XElement)current, 388, 'Ɵ'), 339, 337)) != null)
					{
						char num2 = ⴀ[132];
						WxCfg.ႣႭ[40] = (char)((WxCfg.ႣႭ[40] | WxCfg.ႣႭ[15]) & 0xC5);
						num3 = num2 - 32883;
					}
					else
					{
						num3 = 7;
					}
					num = num3;
					continue;
				}
				case 3:
				case 17:
					num = ((ႰႣ.Ⴓ != null) ? 13 : 10);
					continue;
				case 10:
					ႰႣ.Ⴓ = new Dictionary<string, int>(7)
					{
						{
							UtilsString.Ⴐ(null, 4, 192632122),
							0
						},
						{
							UtilsString.Ⴐ(null, 7, 192633576),
							1
						},
						{
							ႣႼ.Ⴜ(3, 365386134, 31),
							2
						},
						{
							UtilsString.Ⴐ(null, 0, 192632039),
							3
						},
						{
							UtilsString.Ⴐ(null, 6, 192632043),
							4
						},
						{
							UtilsString.Ⴐ(null, 2, 192632055),
							5
						},
						{
							UtilsString.Ⴐ(null, 5, 192631944),
							6
						}
					};
					num = ⴃႤ[315] - 16710;
					continue;
				case 2:
				case 13:
					num = ((!ႰႣ.Ⴓ.TryGetValue(convertible as string, out value)) ? (ⴃႤ[251] - 7362) : 15);
					continue;
				case 15:
					num = value switch
					{
						0 => ⴃႣ[28] - 41381, 
						1 => ⴃႤ[430] - 33414, 
						2 => ⴃႤ[286] - 53641, 
						3 => 12, 
						4 => ⴃႭ[60] - 19464, 
						5 => ⴃႣ[212] - 7573, 
						6 => 0, 
						_ => ⴃႭ[65] - 41716, 
					};
					continue;
				case 11:
					num = 7;
					continue;
				case 9:
					AnnWxSpotExt.ႤႳ(dxSpot, FrmUpdating.ႠႭ((XElement)current, 726, 670), '\u032c', '\u0348');
					num = ⴗ[139] - 41085;
					continue;
				case 1:
					AutoUpdater.ႨႥ(dxSpot, StringConstants.Ⴈ(FrmUpdating.ႠႭ((XElement)current, 119, 63), (IFormatProvider)new CultureInfo(ArcLogInRqstExt.Ⴗ(1706507950, 30, 1)), 932, 944), '\u0014', 40);
					goto case 16;
				case 16:
					num = 7;
					continue;
				case 14:
					DgvTextBoxColumnFilter.ႷႠ(dxSpot, FrmUpdating.ႠႭ(current as XElement, 866, 810), 267, 'Ÿ');
					num = ⴃႤ[222] - 57352;
					continue;
				case 12:
					dxSpot.SpotterNode = (current as XElement).Value;
					num = ⴃႭ[177] - 31774;
					continue;
				case 4:
					dxSpot.Spotter = (current as XElement).Value;
					num = ⴃႤ[129] - 5564;
					continue;
				case 8:
					dxSpot.Route = (current as XElement).Value;
					num = ⴃႣ[83] - 56477;
					continue;
				case 0:
					dxSpot.Dts = Convert.ToDateTime(((XElement)current).Value);
					break;
				case 6:
					return;
				}
				num = (((IEnumerator<XElement>)enumerator).MoveNext() ? 5 : 6);
			}
		}
		finally
		{
			int num4 = 1;
			while (true)
			{
				int num5;
				switch (num4)
				{
				default:
					num5 = (((IEnumerator<XElement>)enumerator == null) ? 4 : 5);
					goto IL_0407;
				case 0:
				case 2:
				case 5:
					(enumerator as IEnumerator<XElement>).Dispose();
					break;
				case 3:
				case 4:
					break;
				}
				break;
				IL_0407:
				num4 = num5;
			}
		}
	}

	public static string SerializeClient(this DxSpot dxSpot)
	{
		while (true)
		{
			XName name = AnnWxSpotExt.Ⴍ(ArcLogInRqstExt.Ⴗ(1706507735, 16, 3), '\u031e', 862);
			Array array = new object[40];
			(array as object[])[0] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 0, 192632126), 'Ñ', 145), UtilsCopyright.Ⴐ(dxSpot, 'ʔ', 'ʮ'));
			((object[])array)[1] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 1, 192633582), 'Ȏ', 590), ႣႼ.ႰႷ(dxSpot, 964, 990));
			(array as object[])[2] = new XElement(AnnWxSpotExt.Ⴍ(ႣႼ.Ⴜ(3, 365386134, 16), 'Ȳ', 626), ႣႼ.ႰႭ(dxSpot, 542, 548));
			((object[])array)[3] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 4, 192632041), 'ƛ', 475), UtilsCallsign.Ⴜ(dxSpot, 409, 469));
			(array as object[])[4] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 3, 192632036), 'đ', 337), UtilsEmail.Ⴍ(dxSpot, 106, '7'));
			(array as object[])[5] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 2, 192631951), '\u0097', 215), TelnetServerClient.ႥႭ(dxSpot, 522, 521));
			((object[])array)[6] = new XElement(AnnWxSpotExt.Ⴍ(ArcLogInRqstExt.Ⴗ(1706507748, 19, 1), 'ɞ', 542), UtilsSql.ႥႠ(dxSpot, 857, 788));
			((object[])array)[7] = new XElement(AnnWxSpotExt.Ⴍ(ArcLogInRqstExt.Ⴗ(1706507754, 24, 6), 'ο', 1023), UtilsSql.ႥႠ(dxSpot, 349, 275));
			((object[])array)[8] = new XElement(AnnWxSpotExt.Ⴍ(ArcLogInRqstExt.Ⴗ(1706507757, 31, 6), 'ɴ', 564), UtilsIdentity.ႤႠ(dxSpot, '\u031e', 773));
			(array as object[])[9] = new XElement(AnnWxSpotExt.Ⴍ(TelnetServerClient.Ⴄ(1945322900, '\u0080', 7), 'ˁ', 641), UtilsCopyright.Ⴐ(dxSpot, '\u0341', 'ͺ'));
			((object[])array)[10] = new XElement(AnnWxSpotExt.Ⴍ(DownloadUrl2.Ⴅ(12, null, 2018868915, 2), '\u02f5', 693), UtilsCopyright.Ⴐ(dxSpot, 'ɋ', 'ɷ'));
			((object[])array)[11] = new XElement(AnnWxSpotExt.Ⴍ(ႣႼ.ႥႭ(null, 624735455, 5, null), 'Ż', 315), UtilsCopyright.Ⴐ(dxSpot, 'ȝ', 'Ƞ'));
			((object[])array)[12] = new XElement(AnnWxSpotExt.Ⴍ(ႣႼ.Ⴜ(2, 365386069, 2), 'Ƣ', 482), ႣႼ.ႰႭ(dxSpot, 14, 53));
			((object[])array)[13] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 7, 192633494), '\u038d', 973), UtilsValidation.Ⴍ(dxSpot, 993, 'Ϋ'));
			(array as object[])[14] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 2, 192633514), 'ǚ', 410), HelpAboutServer.ႷႨ(dxSpot, '\u0090', 202));
			(array as object[])[15] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 5, 192633511), '\u008e', 206), DxAtlasData.ႷႤ(dxSpot, 194, 230));
			(array as object[])[16] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 4, 192633535), 'ß', 159), DxAtlasData.ႷႤ(dxSpot, 475, 510));
			((object[])array)[17] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 2, 192633524), 'É', 137), UtilsSql.ႥႨ(dxSpot, 539, 625));
			((object[])array)[18] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 1, 192633677), 'Į', 366), WwvCfg.Ⴃ(dxSpot, 129, 183));
			(array as object[])[19] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 8, 192633678), '\u008b', 203), ArcUserCfg.ႠႠ(dxSpot, 108, 23));
			((object[])array)[20] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 7, 192633694), 'ɾ', 574), UtilsValidation.Ⴍ(dxSpot, 786, '\u0359'));
			(array as object[])[21] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 7, 192633684), 'ǹ', 441), Ⴍ(dxSpot, 818, 824));
			(array as object[])[22] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 1, 192633701), '\u0322', 866), DxAtlasData.ႷႤ(dxSpot, 242, 212));
			((object[])array)[23] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 1, 192633726), 'ϸ', 952), UtilsSql.ႥႨ(dxSpot, 82, 57));
			((object[])array)[24] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 6, 192633717), '\u0011', 81), DxAtlasData.ႷႤ(dxSpot, 116, 83));
			(array as object[])[25] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 7, 192633602), 'ƌ', 460), UtilsSql.ႥႨ(dxSpot, 366, 258));
			(array as object[])[26] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 7, 192633631), 'Ƹ', 504), XmlSerializationHelper.Ⴍ(dxSpot, 588, 557));
			((object[])array)[27] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 8, 192633638), 'Ș', 600), dxSpot.Unique);
			(array as object[])[28] = new XElement(UtilsString.Ⴐ(null, 5, 192633636), dxSpot.Master);
			((object[])array)[29] = new XElement(UtilsString.Ⴐ(null, 5, 192633661), dxSpot.InCb);
			(array as object[])[30] = new XElement(UtilsString.Ⴐ(null, 4, 192633653), dxSpot.Top100);
			((object[])array)[31] = new XElement(UtilsString.Ⴐ(null, 0, 192633800), dxSpot.Ham);
			(array as object[])[32] = new XElement(UtilsString.Ⴐ(null, 1, 192633799), dxSpot.Foc);
			(array as object[])[33] = new XElement(UtilsString.Ⴐ(null, 8, 192633812), dxSpot.Band);
			((object[])array)[34] = new XElement(UtilsString.Ⴐ(null, 2, 192633836), dxSpot.Mode);
			((object[])array)[35] = new XElement(ArcLogInRqstExt.Ⴗ(1706507763, 24, 2), dxSpot.SpotterCont);
			((object[])array)[36] = new XElement(TelnetServerClient.Ⴄ(1945322922, '\u0095', 0), dxSpot.SpotterCty);
			((object[])array)[37] = new XElement(DownloadUrl2.Ⴅ(8, null, 2018868912, 8), dxSpot.SpotterState);
			((object[])array)[38] = new XElement(ႣႼ.ႥႭ(null, 624735440, 2, null), dxSpot.SpotterCqZone);
			(array as object[])[39] = new XElement(ႣႼ.ႥႭ(null, 624735426, 0, null), dxSpot.SpotterItuZone);
			XContainer xContainer = new XElement(name, (object[])array);
			while (true)
			{
				IL_08ab:
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 4;
						continue;
					case 1:
					case 3:
					case 4:
						break;
					case 0:
						goto IL_08ab;
					case 2:
						return ((XElement)xContainer).ToString();
					}
					break;
				}
				break;
			}
		}
	}

	public static void DeserializeClient(this DxSpot dxSpot, string msg)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = DgvCheckBoxColumnFilter.Ⴓ(msg, 'ǂ', 489);
		object enumerator = (obj as XElement).Elements().GetEnumerator();
		try
		{
			int num = 48;
			XContainer current = default(XContainer);
			object obj2 = default(object);
			int value = default(int);
			while (true)
			{
				switch (num)
				{
				case 36:
					current = ((IEnumerator<XElement>)enumerator).Current;
					num = (((obj2 = DxCommentExtCfg.ႷႭ(UtilsXml.Ⴓ(current as XElement, 1021, 'Ϧ'), 371, 369)) == null) ? (ⴃႤ[424] - 7498) : 10);
					continue;
				case 10:
					num = ((ႰႣ.Ⴍ != null) ? 3 : (ⴐ[36] - 7449));
					continue;
				case 5:
					ႰႣ.Ⴍ = new Dictionary<string, int>(40)
					{
						{
							UtilsString.Ⴐ(null, 2, 192632124),
							0
						},
						{
							UtilsString.Ⴐ(null, 5, 192633578),
							1
						},
						{
							ႣႼ.Ⴜ(6, 365386131, 10),
							2
						},
						{
							UtilsString.Ⴐ(null, 6, 192632033),
							3
						},
						{
							ArcLogInRqstExt.Ⴗ(1706507747, 19, 6),
							4
						},
						{
							ArcLogInRqstExt.Ⴗ(1706507748, 9, 8),
							5
						},
						{
							ArcLogInRqstExt.Ⴗ(1706507753, 15, 2),
							6
						},
						{
							TelnetServerClient.Ⴄ(1945322903, 'V', 4),
							7
						},
						{
							DownloadUrl2.Ⴅ(18, null, 2018868914, 3),
							8
						},
						{
							ႣႼ.ႥႭ(null, 624735442, 8, null),
							9
						},
						{
							ႣႼ.Ⴜ(1, 365386070, 28),
							10
						},
						{
							UtilsString.Ⴐ(null, 8, 192633497),
							11
						},
						{
							UtilsString.Ⴐ(null, 5, 192633517),
							12
						},
						{
							UtilsString.Ⴐ(null, 8, 192633514),
							13
						},
						{
							UtilsString.Ⴐ(null, 4, 192633535),
							14
						},
						{
							UtilsString.Ⴐ(null, 1, 192633527),
							15
						},
						{
							UtilsString.Ⴐ(null, 1, 192633677),
							16
						},
						{
							UtilsString.Ⴐ(null, 4, 192633696),
							17
						},
						{
							UtilsString.Ⴐ(null, 0, 192633683),
							18
						},
						{
							UtilsString.Ⴐ(null, 7, 192633665),
							19
						},
						{
							UtilsString.Ⴐ(null, 4, 192633693),
							20
						},
						{
							UtilsString.Ⴐ(null, 5, 192633722),
							21
						},
						{
							UtilsString.Ⴐ(null, 2, 192633713),
							22
						},
						{
							UtilsString.Ⴐ(null, 6, 192633603),
							23
						},
						{
							UtilsString.Ⴐ(null, 4, 192633628),
							24
						},
						{
							UtilsString.Ⴐ(null, 7, 192633641),
							25
						},
						{
							UtilsString.Ⴐ(null, 8, 192633641),
							26
						},
						{
							UtilsString.Ⴐ(null, 5, 192633661),
							27
						},
						{
							UtilsString.Ⴐ(null, 0, 192633649),
							28
						},
						{
							UtilsString.Ⴐ(null, 4, 192633804),
							29
						},
						{
							UtilsString.Ⴐ(null, 0, 192633798),
							30
						},
						{
							UtilsString.Ⴐ(null, 1, 192633821),
							31
						},
						{
							UtilsString.Ⴐ(null, 8, 192633830),
							32
						},
						{
							UtilsString.Ⴐ(null, 6, 192632043),
							33
						},
						{
							ArcLogInRqstExt.Ⴗ(1706507760, 26, 1),
							34
						},
						{
							TelnetServerClient.Ⴄ(1945322924, 'm', 6),
							35
						},
						{
							DownloadUrl2.Ⴅ(27, null, 2018868912, 8),
							36
						},
						{
							ႣႼ.ႥႭ(msg, 624735443, 1, null),
							37
						},
						{
							ႣႼ.ႥႭ(null, 624735428, 6, null),
							38
						},
						{
							UtilsString.Ⴐ(null, 3, 192631950),
							39
						}
					};
					num = ⴃႣ[131] - 64725;
					continue;
				case 3:
					num = ((!ႰႣ.Ⴍ.TryGetValue((string)obj2, out value)) ? (ⴐ[52] - 12228) : 11);
					continue;
				case 11:
					num = value switch
					{
						0 => 39, 
						1 => ⴀ[381] - 35935, 
						2 => ⴐ[443] - 42153, 
						3 => 37, 
						4 => 49, 
						5 => ⴀ[18] - 58203, 
						6 => ⴃႣ[19] - 59490, 
						7 => ⴀ[32] - 38544, 
						8 => 26, 
						9 => 15, 
						10 => 6, 
						11 => 33, 
						12 => 32, 
						13 => ⴗ[47] - 59003, 
						14 => 24, 
						15 => ⴀ[31] - 18937, 
						16 => 43, 
						17 => 17, 
						18 => ⴀ[317] - 4346, 
						19 => 2, 
						20 => ⴗ[144] - 45203, 
						21 => 12, 
						22 => ⴀ[122] - 49715, 
						23 => ⴗ[75] - 9519, 
						24 => ⴃႤ[159] - 6826, 
						25 => 38, 
						26 => 19, 
						27 => 44, 
						28 => 23, 
						29 => 22, 
						30 => ⴐ[344] - 34335, 
						31 => ⴀ[85] - 17488, 
						32 => ⴃႭ[54] - 54484, 
						33 => 30, 
						34 => ⴃႭ[32] - 53210, 
						35 => 50, 
						36 => 51, 
						37 => 45, 
						38 => ⴃႭ[285] - 39618, 
						39 => ⴃႭ[106] - 59636, 
						_ => ⴃႤ[221] - 30779, 
					};
					continue;
				case 35:
					num = ⴐ[519] - 58342;
					continue;
				case 39:
					AnnWxSpotExt.ႤႳ(dxSpot, FrmUpdating.ႠႭ((XElement)current, 834, 778), '\u0097', 'ó');
					num = ⴗ[121] - 2872;
					continue;
				case 46:
					AutoUpdater.ႨႥ(dxSpot, StringConstants.Ⴈ(FrmUpdating.ႠႭ(current as XElement, 397, 453), (IFormatProvider)new CultureInfo(ArcLogInRqstExt.Ⴗ(1706507948, 11, 3)), 98, 118), 'Ä', 248);
					num = 20;
					continue;
				case 9:
					DgvTextBoxColumnFilter.ႷႠ(dxSpot, FrmUpdating.ႠႭ((XElement)current, 481, 425), 20, 'g');
					num = 20;
					continue;
				case 37:
					DgvTextBoxColumnFilter.ႷႭ(dxSpot, FrmUpdating.ႠႭ((XElement)current, 479, 407), 47, 'O');
					num = ⴃႤ[340] - 34411;
					continue;
				case 49:
					UtilsSql.ႥႥ(dxSpot, FrmUpdating.ႠႭ(current as XElement, 435, 507), 'ʿ', 709);
					num = 20;
					continue;
				case 7:
					AnnWxSpotExt.ႤႳ(dxSpot, FrmUpdating.ႠႭ((XElement)current, 704, 648), 'ɫ', 'Ȏ');
					num = 20;
					continue;
				case 1:
					AnnWxSpotExt.ႤႳ(dxSpot, FrmUpdating.ႠႭ((XElement)current, 405, 477), 'š', 'ć');
					num = 20;
					continue;
				case 29:
					WwvSpotExt.Ⴄ(dxSpot, FrmUpdating.ႠႭ((XElement)current, 933, 1005), 133, '\u0099');
					num = 20;
					continue;
				case 26:
					DgvTextBoxColumnFilter.ႷႭ(dxSpot, FrmUpdating.ႠႭ(current as XElement, 364, 292), 506, 'ƛ');
					num = ⴐ[391] - 8300;
					continue;
				case 15:
					ArcUserCfg.ႠႣ(dxSpot, FrmUpdating.ႠႭ((XElement)current, 426, 482), 781, 'Ͱ');
					num = 20;
					continue;
				case 6:
					ArcUserCfg.ႠႣ(dxSpot, FrmUpdating.ႠႭ((XElement)current, 546, 618), 687, 'ˑ');
					num = 20;
					continue;
				case 33:
					ႣႼ.ႰႤ(dxSpot, AnnCfg.ႷႨ(FrmUpdating.ႠႭ(current as XElement, 614, 558), 663, 743), 551, 'ɿ');
					num = 20;
					continue;
				case 32:
					DgvFreqRangeColumnFilter.ႣႥ(dxSpot, AnnCfg.ႷႨ(FrmUpdating.ႠႭ((XElement)current, 185, 241), 592, 544), 719, '\u02f6');
					num = 20;
					continue;
				case 8:
					PrecisionTimer.ႷႤ(dxSpot, FrmUpdating.ႠႼ(FrmUpdating.ႠႭ(current as XElement, 449, 393), 559, 581), 113, 40);
					num = 20;
					continue;
				case 24:
					WwvCfg.Ⴜ(dxSpot, FrmUpdating.ႠႼ(FrmUpdating.ႠႭ(current as XElement, 665, 721), 118, 28), 81, '\u0014');
					num = 20;
					continue;
				case 40:
					ႰႣ.ႰႳ(dxSpot, FrmUpdating.ႠႼ(FrmUpdating.ႠႭ((XElement)current, 885, 829), 467, 441), 186, 244);
					num = 20;
					continue;
				case 43:
					CtyInfo.Ⴜ(dxSpot, FrmUpdating.ႠႼ(FrmUpdating.ႠႭ((XElement)current, 119, 63), 638, 532), 'ǥ', 447);
					num = 20;
					continue;
				case 17:
					DxAtlasData.ႷႷ(dxSpot, FrmUpdating.ႠႼ(FrmUpdating.ႠႭ((XElement)current, 583, 527), 827, 849), 925, 'σ');
					num = 20;
					continue;
				case 34:
					dxSpot.SkimDupe = Convert.ToBoolean(((XElement)current).Value);
					num = ⴗ[58] - 1686;
					continue;
				case 2:
					dxSpot.SkimDb = Convert.ToByte(((XElement)current).Value);
					num = 20;
					continue;
				case 42:
					dxSpot.SkimWpm = Convert.ToByte(((XElement)current).Value);
					num = ⴃႭ[60] - 19448;
					continue;
				case 12:
					dxSpot.IsSkimValid = Convert.ToBoolean((current as XElement).Value);
					num = ⴃႤ[431] - 43079;
					continue;
				case 4:
					dxSpot.IsSkimQsy = Convert.ToBoolean(((XElement)current).Value);
					num = 20;
					continue;
				case 14:
					dxSpot.IsSkimBusted = Convert.ToBoolean(((XElement)current).Value);
					num = ⴃႣ[53] - 65069;
					continue;
				case 25:
					dxSpot.IsSkimUnknown = Convert.ToBoolean(((XElement)current).Value);
					num = ⴃႤ[126] - 36857;
					continue;
				case 31:
				case 38:
					dxSpot.Unique = Convert.ToByte((current as XElement).Value);
					num = ⴃႭ[259] - 29845;
					continue;
				case 19:
					dxSpot.Master = Convert.ToBoolean(((XElement)current).Value);
					num = ⴃႣ[30] - 55076;
					continue;
				case 44:
					dxSpot.InCb = Convert.ToBoolean((current as XElement).Value);
					num = 20;
					continue;
				case 23:
					dxSpot.Top100 = Convert.ToBoolean((current as XElement).Value);
					num = ⴃႣ[3] - 24448;
					continue;
				case 22:
					dxSpot.Ham = Convert.ToBoolean(((XElement)current).Value);
					num = 20;
					continue;
				case 16:
					dxSpot.Foc = Convert.ToBoolean((current as XElement).Value);
					num = 20;
					continue;
				case 18:
					dxSpot.Band = Convert.ToSingle((current as XElement).Value, new CultureInfo(ArcLogInRqstExt.Ⴗ(1706507949, 2, 2)));
					num = ⴃႭ[182] - 27082;
					continue;
				case 0:
				case 21:
					dxSpot.Mode = ((XElement)current).Value;
					num = ⴐ[268] - 57283;
					continue;
				case 30:
					dxSpot.Spotter = ((XElement)current).Value;
					num = 20;
					continue;
				case 28:
					dxSpot.SpotterCont = (current as XElement).Value;
					num = 20;
					continue;
				case 50:
					dxSpot.SpotterCty = (current as XElement).Value;
					num = ⴗ[12] - 35071;
					continue;
				case 51:
					dxSpot.SpotterState = (current as XElement).Value;
					num = 20;
					continue;
				case 45:
					dxSpot.SpotterCqZone = Convert.ToByte(((XElement)current).Value);
					num = 20;
					continue;
				case 13:
				case 47:
					dxSpot.SpotterItuZone = Convert.ToByte(((XElement)current).Value);
					num = ⴃႣ[19] - 59471;
					continue;
				case 27:
					dxSpot.Dts = Convert.ToDateTime((current as XElement).Value);
					break;
				case 41:
					return;
				}
				num = (((IEnumerator<XElement>)enumerator).MoveNext() ? 36 : (ⴐ[24] - 3961));
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
					num3 = ((!(enumerator is IEnumerator<XElement>)) ? 4 : (ⴃႤ[383] - 20211));
					goto IL_0eaa;
				case 1:
				case 3:
					((IEnumerator<XElement>)enumerator).Dispose();
					break;
				case 4:
					break;
				}
				break;
				IL_0eaa:
				num2 = num3;
			}
		}
	}

	public static string SerializeClientSpot(this DxSpot dxSpot)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			XName name = AnnWxSpotExt.Ⴍ(DownloadUrl2.Ⴅ(6, null, 2018869071, 4), '\u0300', 832);
			Array array = new object[4];
			((object[])array)[0] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 1, 192632127), 'Ɲ', 477), UtilsCopyright.Ⴐ(dxSpot, 'Ǡ', 'ǚ'));
			((object[])array)[1] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 6, 192633577), 'ǽ', 445), ႣႼ.ႰႷ(dxSpot, 765, 743));
			(array as object[])[2] = new XElement(AnnWxSpotExt.Ⴍ(ႣႼ.Ⴜ(6, 365386131, 13), '\u033c', 892), ႣႼ.ႰႭ(dxSpot, 970, 1008));
			(array as object[])[3] = new XElement(UtilsString.Ⴐ(null, 5, 192632040), dxSpot.Spotter);
			object obj = new XElement(name, array as object[]);
			while (true)
			{
				IL_0143:
				int num = ⴗ[25] - 18236;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴀ[63] - 17152;
						continue;
					case 1:
					case 2:
					case 5:
						break;
					case 0:
						goto IL_0143;
					case 4:
						return ((XElement)obj).ToString();
					}
					break;
				}
				break;
			}
		}
	}

	public static void DeserializeClientSpot(this DxSpot dxSpot, string msg)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		XContainer xContainer = DgvCheckBoxColumnFilter.Ⴓ(msg, 'Ś', 369);
		object enumerator = ((XElement)xContainer).Elements().GetEnumerator();
		try
		{
			int num = 13;
			object current = default(object);
			IComparable comparable = default(IComparable);
			while (true)
			{
				switch (num)
				{
				case 11:
					current = (enumerator as IEnumerator<XElement>).Current;
					num = (((comparable = DxCommentExtCfg.ႷႭ(UtilsXml.Ⴓ((XElement)current, 935, 'μ'), 602, 600)) == null) ? (ⴐ[333] - 28063) : (ⴀ[132] - 32880));
					continue;
				case 6:
					num = (FrmUpdating.ႠႥ(comparable as string, UtilsString.Ⴐ(null, 0, 192632126), 1022, 962) ? (ⴐ[183] - 20602) : 8);
					continue;
				case 2:
				case 8:
					num = (FrmUpdating.ႠႥ((string)comparable, UtilsString.Ⴐ(null, 7, 192633576), 302, 274) ? 4 : 12);
					continue;
				case 12:
					num = (FrmUpdating.ႠႥ((string)comparable, ႣႼ.Ⴜ(0, 365386133, 15), 67, 127) ? 9 : (ⴃႤ[63] - 46142));
					continue;
				case 3:
				case 7:
					num = (FrmUpdating.ႠႥ(comparable as string, UtilsString.Ⴐ(null, 3, 192632046), 671, 675) ? 1 : 10);
					continue;
				case 10:
					num = ⴃႤ[103] - 3399;
					continue;
				case 15:
					AnnWxSpotExt.ႤႳ(dxSpot, FrmUpdating.ႠႭ(current as XElement, 140, 196), 'ʘ', '\u02fc');
					num = 14;
					continue;
				case 4:
					dxSpot.Freq = Convert.ToSingle(FrmUpdating.ႠႭ(current as XElement, 705, 649), new CultureInfo(ArcLogInRqstExt.Ⴗ(1706507943, 28, 8)));
					num = ⴗ[71] - 6952;
					continue;
				case 5:
				case 9:
					dxSpot.Comment = ((XElement)current).Value;
					num = 14;
					continue;
				case 1:
					dxSpot.Spotter = (current as XElement).Value;
					break;
				case 0:
					return;
				}
				num = (((IEnumerator<XElement>)enumerator).MoveNext() ? (ⴃႭ[225] - 59531) : (ⴃႣ[83] - 56484));
			}
		}
		finally
		{
			int num2 = 3;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!(enumerator is IEnumerator<XElement>)) ? 4 : 5);
					goto IL_02cd;
				case 1:
				case 5:
					(enumerator as IEnumerator<XElement>).Dispose();
					break;
				case 2:
				case 4:
					break;
				}
				break;
				IL_02cd:
				num2 = num3;
			}
		}
	}

	public static string GetUserString(this DxSpot dx)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			float num = ႣႼ.ႰႷ(dx, 187, 161);
			IComparable comparable = TelnetServerClient.ႥႳ(ref num, TelnetServerClient.Ⴄ(1945322931, '\u001f', 3), 'ȃ', 533);
			while (true)
			{
				IL_0083:
				int num2 = 4;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = ⴗ[5] - 11048;
						continue;
					case 9:
						break;
					case 8:
						goto IL_0083;
					case 4:
						cloneable = UtilsEmail.Ⴀ(ArcLogInRqstExt.Ⴗ(1706507541, 29, 6), UtilsCallsign.Ⴜ(dx, 951, 1019), ArcLogInRqstExt.Ⴗ(1706506774, 24, 8), 429, 507);
						num2 = 1;
						continue;
					case 1:
						cloneable = Ⴃ((string)cloneable, 24 - UtilsCallsign.Ⴓ((string)comparable, 974, 1017), ' ', 'Ā', 325);
						goto case 3;
					case 3:
						num2 = 2;
						continue;
					case 2:
						cloneable = HelpAboutServer.Ⴗ(cloneable as string, (string)comparable, ArcLogInRqstExt.Ⴗ(1706507554, 15, 6), UtilsCopyright.Ⴐ(dx, 'N', 't'), 518, 'ɨ');
						num2 = ⴃႣ[116] - 21528;
						continue;
					case 7:
						cloneable = ((string)cloneable).PadRight(39, ' ') + dx.Comment;
						cloneable = ((string)cloneable).PadRight(70, ' ') + dx.Dts.ToString(ႣႼ.Ⴜ(6, 365386097, 17));
						goto case 0;
					case 0:
						num2 = 5;
						continue;
					case 5:
						return (string)cloneable;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static DxSpotExt()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, char P_3) where _0021_00210 : Control
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 1;
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
			case 3:
				num = (((P_3 ^ P_2) - 62) ^ num2) switch
				{
					0 => 8, 
					_ => 7, 
				};
				break;
			case 7:
				num = 9;
				break;
			case 0:
			case 8:
				P_0.AutoSize = P_1;
				goto case 9;
			case 9:
				num2++;
				goto case 4;
			case 4:
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 6 : (ⴀ[138] - 33617));
				break;
			case 5:
				num = 2;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴈ<_0021_00210>(_0021_00210 P_0, byte[] P_1, int P_2, int P_3, int P_4, short P_5) where _0021_00210 : Stream
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[27] - 92;
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
				case 3:
					num2 = (((P_4 ^ P_5) - 55) ^ num) switch
					{
						0 => 2, 
						_ => ⴗ[55] - 6828, 
					};
					continue;
				case 0:
					result = 15;
					num2 = 9;
					continue;
				case 2:
				case 7:
					result = P_0.Read(P_1, P_2, P_3);
					num2 = 9;
					continue;
				case 5:
				case 9:
				case 10:
				{
					num++;
					int num3 = 562;
					int num4 = 217;
					num2 = ((281 < num3 / 2 - num4) ? (ⴗ[93] - 714) : 6);
					continue;
				}
				case 6:
					return result;
				case 1:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static AppDomain Ⴅ(char P_0, short P_1)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႤ[527] - 61700;
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
				case 8:
					num2 = (((P_1 ^ P_0) - 88) ^ num) switch
					{
						0 => 1, 
						_ => ⴗ[42] - 37006, 
					};
					continue;
				case 0:
					obj = null;
					num2 = ⴗ[139] - 41087;
					continue;
				case 1:
					obj = AppDomain.CurrentDomain;
					num2 = 5;
					continue;
				case 5:
					num++;
					num3 = 614;
					goto case 3;
				case 3:
				{
					int num4 = 143;
					num2 = ((307 < num3 / 2 - num4) ? 8 : 9);
					continue;
				}
				case 4:
				case 9:
					return (AppDomain)obj;
				case 2:
				case 6:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataTable Ⴄ<_0021_00210>(_0021_00210 P_0, bool P_1, string[] P_2, int P_3, short P_4) where _0021_00210 : DataView
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		ISerializable serializable = default(ISerializable);
		int num3 = default(int);
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
				case 10:
					num2 = (((P_3 ^ P_4) - 16) ^ num) switch
					{
						0 => ⴗ[8] - 15531, 
						_ => 8, 
					};
					continue;
				case 8:
					serializable = null;
					num2 = 3;
					continue;
				case 7:
				case 11:
					serializable = P_0.ToTable(P_1, P_2);
					num2 = 3;
					continue;
				case 2:
				case 3:
					num++;
					num3 = P_4 * P_4;
					num3 = P_4 + num3;
					goto case 5;
				case 5:
					num2 = 9;
					continue;
				case 9:
					num2 = ((num3 % 2 != 0) ? 10 : (ⴃႣ[228] - 10052));
					continue;
				case 6:
					return (DataTable)serializable;
				case 4:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, int P_3) where _0021_00210 : MailMessage
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀ[80] - 15287;
				continue;
			case 6:
				num = (((P_2 ^ P_3) - 86) ^ num2) switch
				{
					0 => 0, 
					_ => ⴐ[121] - 27746, 
				};
				continue;
			case 1:
				num = 7;
				continue;
			case 0:
			case 4:
				P_0.IsBodyHtml = P_1;
				break;
			case 5:
			case 7:
				break;
			case 2:
			case 8:
				return;
			}
			num2++;
			int num3 = 384;
			int num4 = 184;
			num = ((192 < num3 / 2 - num4) ? (ⴃႣ[203] - 38805) : (ⴃႤ[427] - 50434));
		}
	}

	[SecuritySafeCritical]
	internal static Graphics Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DataGridViewCellPaintingEventArgs
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		MarshalByRefObject marshalByRefObject = default(MarshalByRefObject);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႭ[161] - 54235;
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
				case 6:
					num2 = (((P_2 ^ P_1) - 64) ^ num) switch
					{
						0 => 2, 
						_ => 1, 
					};
					continue;
				case 1:
				case 7:
					marshalByRefObject = null;
					goto case 3;
				case 3:
					num2 = 0;
					continue;
				case 2:
					marshalByRefObject = P_0.Graphics;
					num2 = 0;
					continue;
				case 0:
				case 5:
				{
					num++;
					int num3 = 1932;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? 10 : (ⴃႤ[73] - 63805));
					continue;
				}
				case 4:
					num2 = 6;
					continue;
				case 10:
					return marshalByRefObject as Graphics;
				case 8:
					num2 = ⴗ[42] - 37000;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DxSpot
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool result = default(bool);
		int num3 = default(int);
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
					num2 = 7;
					continue;
				case 7:
					break;
				case 10:
					num2 = (((P_2 ^ P_1) - 10) ^ num) switch
					{
						0 => 1, 
						_ => 2, 
					};
					continue;
				case 2:
				case 8:
					result = false;
					num2 = ⴃႣ[67] - 59378;
					continue;
				case 1:
				case 6:
					result = P_0.SkimDupe;
					num2 = ⴗ[117] - 12536;
					continue;
				case 0:
				case 3:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴀ[370] - 60428;
					continue;
				case 9:
					num2 = ((num3 % 2 != 0) ? 10 : (ⴗ[75] - 9529));
					continue;
				case 4:
					return result;
				case 5:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Rectangle Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, bool P_3, int P_4, int P_5) where _0021_00210 : DataGridView
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		Rectangle result = default(Rectangle);
		int num4 = default(int);
		int num3 = default(int);
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
				case 1:
				case 4:
					num2 = (((P_5 ^ P_4) - 111) ^ num) switch
					{
						0 => ⴀ[4] - 23039, 
						_ => 0, 
					};
					continue;
				case 0:
					result = default(Rectangle);
					num2 = 2;
					continue;
				case 6:
					result = P_0.GetCellDisplayRectangle(P_1, P_2, P_3);
					num2 = 2;
					continue;
				case 2:
				{
					num++;
					num4 = 1960;
					int num5 = num4;
					num3 = num5 * num5;
					goto case 3;
				}
				case 3:
				case 11:
					num2 = 7;
					continue;
				case 7:
					num3 = num4 + num3;
					num2 = ((num3 % 2 != 0) ? 4 : (ⴐ[600] - 11807));
					continue;
				case 9:
					return result;
				case 8:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, char P_3, short P_4) where _0021_00210 : string
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[124] - 24221;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[277] - 547;
					continue;
				case 7:
					break;
				case 8:
					num2 = (((P_4 ^ P_3) - 69) ^ num) switch
					{
						0 => 9, 
						_ => ⴃႤ[446] - 63149, 
					};
					continue;
				case 4:
					convertible = null;
					goto case 6;
				case 6:
					num2 = ⴃႣ[58] - 44949;
					continue;
				case 9:
					convertible = P_0.PadRight(P_1, P_2);
					num2 = 5;
					continue;
				case 5:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 3 : 10);
					continue;
				case 10:
					num2 = ⴃႤ[322] - 16153;
					continue;
				case 2:
				case 3:
					return convertible as string;
				case 1:
				case 11:
					num2 = ⴐ[352] - 48419;
					continue;
				}
				break;
			}
		}
	}
}
