using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Pcxx;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods.Login;
using ArcShared.Forms;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.ExtensionMethods;

public static class WwvSpotExt
{
	public static string SerializeNode(this WwvSpot wwvSpot)
	{
		while (true)
		{
			XName name = AnnWxSpotExt.Ⴍ(ႣႼ.Ⴜ(3, 365387613, 30), 'ż', 316);
			Array array = new object[8];
			(array as object[])[0] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 6, 192632012), 'á', 161), UtilsVersion.Ⴀ(wwvSpot, '`', 27));
			((object[])array)[1] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 7, 192632007), '\u0350', 784), UtilsSql.ႨႨ(wwvSpot, '\u0089', 162));
			(array as object[])[2] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 7, 192632027), 'ɸ', 568), AnnWxSpotExt.Ⴜ(wwvSpot, 894, '\u0334'));
			(array as object[])[3] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 8, 192632016), 'õ', 181), UtilsEmail.Ⴄ(wwvSpot, 62, 105));
			((object[])array)[4] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 5, 192632040), 'Ŋ', 266), UtilsVersion.Ⴀ(wwvSpot, 'Ŋ', 310));
			(array as object[])[5] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 8, 192632047), '\u02d4', 660), wwvSpot.SpotterNode);
			(array as object[])[6] = new XElement(UtilsString.Ⴐ(null, 5, 192632048), wwvSpot.Route);
			((object[])array)[7] = new XElement(UtilsString.Ⴐ(null, 5, 192631944), wwvSpot.Dts);
			XContainer xContainer = new XElement(name, (object[])array);
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 4;
					continue;
				case 2:
				case 3:
				case 4:
					break;
				case 5:
					return ((XElement)xContainer).ToString();
				}
				break;
			}
		}
	}

	public static void DeserializeNode(this WwvSpot wwvSpot, string msg)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		XContainer xContainer = DgvCheckBoxColumnFilter.Ⴓ(msg, 'Ź', 338);
		object enumerator = ((XElement)xContainer).Elements().GetEnumerator();
		try
		{
			int num = 2;
			XContainer current = default(XContainer);
			IEnumerable enumerable = default(IEnumerable);
			IConvertible convertible = default(IConvertible);
			int value = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					num = 13;
					continue;
				case 15:
					current = ((IEnumerator<XElement>)enumerator).Current;
					enumerable = DxCommentExtCfg.ႷႭ(UtilsXml.Ⴓ(current as XElement, 27, '\0'), 42, 40);
					num = 20;
					continue;
				case 20:
					num = (((convertible = (string)enumerable) == null) ? 13 : (ⴃႤ[355] - 17411));
					continue;
				case 14:
					num = ((ႰႣ.Ⴅ != null) ? (ⴗ[85] - 5439) : 21);
					continue;
				case 12:
				case 21:
					ႰႣ.Ⴅ = new Dictionary<string, int>(8)
					{
						{
							UtilsString.Ⴐ(null, 4, 192632014),
							0
						},
						{
							UtilsString.Ⴐ(null, 0, 192632000),
							1
						},
						{
							UtilsString.Ⴐ(null, 7, 192632027),
							2
						},
						{
							UtilsString.Ⴐ(null, 3, 192632027),
							3
						},
						{
							UtilsString.Ⴐ(null, 7, 192632042),
							4
						},
						{
							UtilsString.Ⴐ(null, 7, 192632032),
							5
						},
						{
							UtilsString.Ⴐ(null, 2, 192632055),
							6
						},
						{
							UtilsString.Ⴐ(null, 6, 192631947),
							7
						}
					};
					num = ⴗ[88] - 34711;
					continue;
				case 11:
				{
					int num2;
					if (ႰႣ.Ⴅ.TryGetValue((string)convertible, out value))
					{
						num2 = 6;
					}
					else
					{
						char num3 = ⴃႣ[106];
						TalkCfg.ႣႣ[54] = (char)(TalkCfg.ႣႣ[54] & TalkCfg.ႣႣ[17] & 6);
						num2 = num3 - 63625;
					}
					num = num2;
					continue;
				}
				case 6:
					num = value switch
					{
						0 => 18, 
						1 => 1, 
						2 => ⴃႭ[232] - 45198, 
						3 => ⴐ[179] - 53083, 
						4 => ⴃႤ[258] - 46893, 
						5 => 17, 
						6 => ⴃႭ[81] - 32193, 
						7 => 16, 
						_ => 0, 
					};
					continue;
				case 0:
					num = 13;
					continue;
				case 5:
				case 18:
					PcxxServerClient.Ⴅ(wwvSpot, FrmUpdating.ႠႭ(current as XElement, 254, 182), 912, 957);
					num = 13;
					continue;
				case 1:
					DgvTextBoxColumnFilter.Ⴍ(wwvSpot, FrmUpdating.ႠႭ((XElement)current, 145, 217), 595, 600);
					num = 13;
					continue;
				case 9:
					DgvFilterManager.ႭႤ(wwvSpot, FrmUpdating.ႠႭ((XElement)current, 152, 208), '\u0001', 39);
					num = 13;
					continue;
				case 3:
					PcxxServerClient.Ⴅ(wwvSpot, FrmUpdating.ႠႭ((XElement)current, 805, 877), 239, 193);
					goto case 7;
				case 7:
					num = 13;
					continue;
				case 19:
					wwvSpot.Spotter = ((XElement)current).Value;
					num = ⴃႭ[36] - 6366;
					continue;
				case 17:
					wwvSpot.SpotterNode = ((XElement)current).Value;
					num = 13;
					continue;
				case 4:
					wwvSpot.Route = (current as XElement).Value;
					num = 13;
					continue;
				case 16:
					wwvSpot.Dts = Convert.ToDateTime(((XElement)current).Value);
					break;
				case 13:
					break;
				case 8:
					goto end_IL_004f;
				}
				num = ((enumerator as IEnumerator<XElement>).MoveNext() ? (ⴃႤ[402] - 56098) : (ⴐ[6] - 53040));
				continue;
				end_IL_004f:
				break;
			}
		}
		finally
		{
			int num4 = 3;
			while (true)
			{
				int num5;
				switch (num4)
				{
				default:
					num5 = ((!(enumerator is IEnumerator<XElement>)) ? (ⴗ[92] - 39182) : (ⴀ[110] - 48935));
					goto IL_042d;
				case 5:
					((IEnumerator<XElement>)enumerator).Dispose();
					break;
				case 2:
					break;
				}
				break;
				IL_042d:
				num4 = num5;
			}
		}
		switch (1)
		{
		}
	}

	public static string SerializeUser(this WwvSpot wwvSpot)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		while (true)
		{
			XName name = AnnWxSpotExt.Ⴍ(ArcLogInRqstExt.Ⴗ(1706508274, 10, 7), 'ɨ', 552);
			Array array = new object[7];
			((object[])array)[0] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 1, 192632011), '\r', 77), UtilsVersion.Ⴀ(wwvSpot, 'Ν', 998));
			(array as object[])[1] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 1, 192632001), 'Υ', 997), UtilsSql.ႨႨ(wwvSpot, '\u034a', 865));
			(array as object[])[2] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 6, 192632026), 'I', 9), AnnWxSpotExt.Ⴜ(wwvSpot, 32, 'j'));
			(array as object[])[3] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 6, 192632030), 'Ű', 304), UtilsEmail.Ⴄ(wwvSpot, 988, 907));
			((object[])array)[4] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 6, 192632043), 'Ȧ', 614), UtilsVersion.Ⴀ(wwvSpot, 'ʬ', 720));
			(array as object[])[5] = new XElement(UtilsString.Ⴐ(null, 3, 192632036), wwvSpot.SpotterNode);
			((object[])array)[6] = new XElement(UtilsString.Ⴐ(null, 5, 192631944), wwvSpot.Dts);
			XContainer xContainer = new XElement(name, array as object[]);
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႭ[101] - 25687;
					continue;
				case 3:
					break;
				case 4:
				case 5:
					return ((XElement)xContainer).ToString();
				}
				break;
			}
		}
	}

	public static void DeserializeUser(this WwvSpot wwvSpot, string msg)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IXmlSerializable xmlSerializable = DgvCheckBoxColumnFilter.Ⴓ(msg, 'ˠ', 715);
		object enumerator = (xmlSerializable as XElement).Elements().GetEnumerator();
		try
		{
			int num = 19;
			IXmlSerializable current = default(IXmlSerializable);
			object obj = default(object);
			IComparable<string> comparable = default(IComparable<string>);
			int value = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					num = 17;
					continue;
				case 12:
					current = (enumerator as IEnumerator<XElement>).Current;
					obj = DxCommentExtCfg.ႷႭ(UtilsXml.Ⴓ(current as XElement, 435, 'ƨ'), 795, 793);
					goto case 4;
				case 4:
					num = 9;
					continue;
				case 9:
					num = (((comparable = (string)obj) == null) ? 17 : 6);
					continue;
				case 6:
					num = ((ႰႣ.Ⴐ != null) ? (ⴀ[234] - 32542) : 8);
					continue;
				case 8:
					ႰႣ.Ⴐ = new Dictionary<string, int>(7)
					{
						{
							UtilsString.Ⴐ(null, 1, 192632011),
							0
						},
						{
							UtilsString.Ⴐ(null, 5, 192632005),
							1
						},
						{
							UtilsString.Ⴐ(null, 2, 192632030),
							2
						},
						{
							UtilsString.Ⴐ(null, 7, 192632031),
							3
						},
						{
							UtilsString.Ⴐ(null, 3, 192632046),
							4
						},
						{
							UtilsString.Ⴐ(null, 1, 192632038),
							5
						},
						{
							UtilsString.Ⴐ(null, 4, 192631945),
							6
						}
					};
					num = 14;
					continue;
				case 14:
					num = ((!ႰႣ.Ⴐ.TryGetValue(comparable as string, out value)) ? (ⴗ[155] - 49730) : 11);
					continue;
				case 11:
					num = value switch
					{
						0 => ⴃႤ[256] - 610, 
						1 => 5, 
						2 => ⴃႭ[161] - 54223, 
						3 => ⴃႣ[2] - 5248, 
						4 => ⴃႭ[17] - 6304, 
						5 => ⴃႤ[90] - 11454, 
						6 => ⴀ[179] - 61953, 
						_ => 16, 
					};
					continue;
				case 16:
					num = 17;
					continue;
				case 2:
					PcxxServerClient.Ⴅ(wwvSpot, FrmUpdating.ႠႭ(current as XElement, 990, 918), 900, 937);
					num = ⴃႤ[210] - 27379;
					continue;
				case 5:
					DgvTextBoxColumnFilter.Ⴍ(wwvSpot, FrmUpdating.ႠႭ((XElement)current, 954, 1010), 611, 616);
					num = 17;
					continue;
				case 18:
					DgvFilterManager.ႭႤ(wwvSpot, FrmUpdating.ႠႭ((XElement)current, 214, 158), '\u001c', 58);
					num = ⴃႭ[177] - 31764;
					continue;
				case 20:
					wwvSpot.Forecast = FrmUpdating.ႠႭ((XElement)current, 555, 611);
					num = 17;
					continue;
				case 15:
					wwvSpot.Spotter = ((XElement)current).Value;
					goto case 0;
				case 0:
					num = ⴐ[237] - 23078;
					continue;
				case 1:
					wwvSpot.SpotterNode = ((XElement)current).Value;
					num = ⴐ[520] - 5380;
					continue;
				case 3:
					wwvSpot.Dts = Convert.ToDateTime((current as XElement).Value);
					break;
				case 17:
					break;
				case 10:
				case 13:
					goto end_IL_0050;
				}
				num = (((IEnumerator<XElement>)enumerator).MoveNext() ? 12 : 13);
				continue;
				end_IL_0050:
				break;
			}
		}
		finally
		{
			int num2 = 0;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!(enumerator is IEnumerator<XElement>)) ? (ⴗ[116] - 43243) : 2);
					goto IL_03e9;
				case 2:
					(enumerator as IEnumerator<XElement>).Dispose();
					break;
				case 3:
				case 4:
				case 5:
					break;
				}
				break;
				IL_03e9:
				num2 = num3;
			}
		}
		switch (2)
		{
		}
	}

	public static string GetUserString(this WwvSpot wwv)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		IEquatable<string> equatable2 = default(IEquatable<string>);
		Array array = default(Array);
		while (true)
		{
			string text = DownloadUrl2.Ⴅ(15, null, 2018868142, 2);
			string text2 = UtilsVersion.Ⴀ(wwv, 'Ɔ', 506);
			string text3 = TelnetServerClient.Ⴄ(1945322597, '\u0080', 5);
			DateTime dateTime = UtilsIdentity.Ⴜ(wwv, 339, 321);
			IEquatable<string> equatable = HelpAboutServer.Ⴗ(text, text2, text3, DgvTextBoxColumnFilter.Ⴈ(ref dateTime, ႣႼ.ႥႭ(null, 624735661, 3, null), 394, 457), 88, '6');
			int num = 8;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 10;
					continue;
				case 10:
					break;
				case 8:
					equatable2 = (string)equatable;
					goto case 5;
				case 5:
					array = new string[9];
					(array as string[])[0] = (string)equatable2;
					num = 2;
					continue;
				case 2:
					(array as string[])[1] = UtilsString.Ⴐ(null, 8, 192631939);
					goto case 0;
				case 0:
					(array as string[])[2] = UtilsVersion.Ⴀ(wwv, 'Ϋ', 976);
					num = 4;
					continue;
				case 4:
					(array as string[])[3] = ႣႼ.Ⴜ(7, 365387625, 30);
					goto case 6;
				case 6:
					(array as string[])[4] = UtilsSql.ႨႨ(wwv, 'π', 1003);
					num = 1;
					continue;
				case 1:
					((string[])array)[5] = ႣႼ.ႥႭ(null, 624735655, 4, null);
					num = ⴀ[132] - 32875;
					continue;
				case 11:
					(array as string[])[6] = AnnWxSpotExt.Ⴜ(wwv, 958, 'ϴ');
					(array as string[])[7] = DownloadUrl2.Ⴅ(2, null, 2018867288, 2);
					num = 9;
					continue;
				case 9:
					(array as string[])[8] = wwv.Forecast;
					equatable = string.Concat((string[])array);
					num = 3;
					continue;
				case 3:
					return equatable as string;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static WwvSpotExt()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static NumberFormatInfo Ⴗ(int P_0, char P_1)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		ICloneable cloneable = default(ICloneable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[25] - 18230;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[249] - 12435;
					continue;
				case 7:
					break;
				case 10:
					num2 = (((P_1 ^ P_0) - 12) ^ num) switch
					{
						0 => 5, 
						_ => ⴃႭ[173] - 11199, 
					};
					continue;
				case 6:
					cloneable = null;
					num2 = ⴃႣ[166] - 48245;
					continue;
				case 2:
				case 5:
					cloneable = NumberFormatInfo.InvariantInfo;
					num2 = ⴃႤ[286] - 53647;
					continue;
				case 8:
				case 11:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 3;
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? (ⴃႣ[212] - 7571) : (ⴃႭ[60] - 19467));
					continue;
				case 1:
					return (NumberFormatInfo)cloneable;
				case 9:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႤ[129] - 5570;
				break;
			case 1:
				num = (((P_2 ^ P_1) - 76) ^ num2) switch
				{
					0 => 5, 
					_ => ⴃႣ[83] - 56478, 
				};
				break;
			case 6:
			case 9:
				num = 7;
				break;
			case 5:
				File.Delete(P_0);
				goto case 7;
			case 7:
			{
				num2++;
				int num3 = 55;
				int num4 = 102;
				num = ((408 > num4 - num3 * 4) ? 4 : (ⴃႭ[158] - 9175));
				break;
			}
			case 2:
			case 3:
				num = 1;
				break;
			case 0:
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, char P_3) where _0021_00210 : Socket where _0021_00211 : IAsyncResult
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int result = default(int);
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
					num2 = 6;
					continue;
				case 6:
					break;
				case 4:
					num2 = (((P_3 ^ P_2) - 124) ^ num) switch
					{
						0 => 2, 
						_ => 8, 
					};
					continue;
				case 8:
					result = 9;
					num2 = ⴃႣ[104] - ⴃႣ[104];
					continue;
				case 2:
				case 9:
					result = P_0.EndSend(P_1);
					num2 = 0;
					continue;
				case 0:
				case 11:
					num++;
					num3 = 448;
					goto case 10;
				case 10:
				{
					int num4 = 524;
					num2 = ((3144 > num4 - num3 * 6) ? (ⴃႤ[33] - 51701) : (ⴀ[176] - 47804));
					continue;
				}
				case 1:
					num2 = 4;
					continue;
				case 7:
					return result;
				case 5:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DataGridViewComboBoxColumn
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = default(object);
		int num4 = default(int);
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
					num2 = ⴀ[211] - 35370;
					continue;
				case 4:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 97) ^ num) switch
					{
						0 => ⴃႣ[206] - 36145, 
						_ => 3, 
					};
					continue;
				case 3:
					obj = null;
					num2 = 10;
					continue;
				case 11:
					obj = P_0.DisplayMember;
					num2 = 10;
					continue;
				case 10:
					num++;
					goto case 9;
				case 9:
				{
					num4 = 1899;
					int num5 = num4;
					num3 = num5 * num5;
					num2 = 7;
					continue;
				}
				case 7:
					num3 = num4 + num3;
					goto case 8;
				case 8:
					num2 = ((num3 % 2 != 0) ? 1 : (ⴃႭ[160] - 23652));
					continue;
				case 0:
				case 6:
					return obj as string;
				case 2:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] Ⴅ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : MemoryStream
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[20] - 30036;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[89] - 20993;
					continue;
				case 11:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 38) ^ num) switch
					{
						0 => 6, 
						_ => ⴃႣ[0] - 54037, 
					};
					continue;
				case 0:
					obj = null;
					num2 = 10;
					continue;
				case 6:
					obj = P_0.ToArray();
					num2 = 10;
					continue;
				case 10:
					num++;
					num3 = 408;
					num4 = 957;
					goto case 3;
				case 3:
					num2 = ((3828 <= num4 - num3 * 4) ? 1 : (ⴃႣ[20] - 44810));
					continue;
				case 1:
					num2 = ⴃႤ[221] - 30807;
					continue;
				case 2:
					return obj as byte[];
				case 8:
				case 9:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, char P_3) where _0021_00210 : Thread where _0021_00211 : CultureInfo
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				continue;
			case 2:
				num = (((P_2 ^ P_3) - 42) ^ num2) switch
				{
					0 => 7, 
					_ => ⴃႤ[285] - 63761, 
				};
				continue;
			case 0:
			case 5:
				num = 1;
				continue;
			case 3:
			case 7:
				P_0.CurrentUICulture = P_1;
				break;
			case 1:
			case 6:
				break;
			case 8:
				return;
			}
			num2++;
			int num3 = 1384;
			int num4 = 79;
			num = ((346 < num3 / 4 - num4) ? (ⴗ[94] - 22937) : 8);
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2, int P_3) where _0021_00210 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[144] - 45236;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[71] - 6956;
					continue;
				case 3:
				case 10:
					break;
				case 4:
				case 9:
					num2 = (((P_2 ^ P_3) - 82) ^ num) switch
					{
						0 => ⴀ[122] - 49712, 
						_ => 1, 
					};
					continue;
				case 1:
					result = 8;
					num2 = ⴗ[75] - 9533;
					continue;
				case 7:
					result = P_0.LastIndexOf(P_1);
					num2 = ⴃႤ[457] - ⴃႤ[457];
					continue;
				case 0:
				{
					num++;
					int num3 = 678;
					int num4 = 61;
					int num5 = num3 / 3 - num4;
					WxCfg.ႣႭ[148] = (char)((WxCfg.ႣႭ[148] - P_3) & 0xEC);
					num2 = ((226 < num5) ? (ⴐ[361] - 22506) : 2);
					continue;
				}
				case 2:
				case 5:
					return result;
				case 6:
					num2 = ⴃႣ[166] - 48244;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Rectangle Ⴐ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DataGridViewCellPaintingEventArgs
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		Rectangle result = default(Rectangle);
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
					num2 = 4;
					continue;
				case 4:
				case 6:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 59) ^ num) switch
					{
						0 => 11, 
						_ => 10, 
					};
					continue;
				case 10:
					result = default(Rectangle);
					num2 = 8;
					continue;
				case 11:
					result = P_0.CellBounds;
					num2 = 8;
					continue;
				case 8:
					num++;
					goto case 2;
				case 2:
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႭ[285] - 39662) : 5);
					continue;
				case 5:
					num2 = ⴃႭ[106] - 59654;
					continue;
				case 3:
				case 7:
					return result;
				case 0:
					num2 = ⴐ[519] - 58353;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string where _0021_00211 : DxSpot
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႣ[166] - 48249;
				break;
			case 4:
				num = (((P_2 ^ P_3) - 28) ^ num2) switch
				{
					0 => 0, 
					_ => 5, 
				};
				break;
			case 5:
				num = 6;
				break;
			case 0:
			case 2:
			case 7:
				P_0.Cont = P_1;
				goto case 6;
			case 6:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 1 : (ⴀ[296] - 64740));
				break;
			case 3:
			case 9:
				num = ⴐ[391] - 8316;
				break;
			case 1:
				return;
			}
		}
	}
}
