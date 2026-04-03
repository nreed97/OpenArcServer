using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net;
using System.Security;
using System.Windows.Forms;
using System.Xml.Linq;
using ArcInterfaces.Arcx;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods.Objects;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.ExtensionMethods.Login;

public static class ArcLogInRespExt
{
	public static string SerializeNode(this ArcLogInResp arcLogInResp)
	{
		while (true)
		{
			XName name = AnnWxSpotExt.Ⴍ(ႣႼ.Ⴜ(5, 365387392, 30), 'q', 49);
			Array array = new object[4];
			(array as object[])[0] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 3, 192632125), '\u009b', 219), DownloadUrl2.ႥႣ(arcLogInResp, '\u02db', '\u02d7'));
			((object[])array)[1] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 8, 192632127), 'ģ', 355), ObjectCopierExt.Ⴀ(arcLogInResp, 'È', 184));
			((object[])array)[2] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 5, 192632266), 'Ũ', 296), DgvDateColumnFilter.Ⴗ(arcLogInResp, 328, 287));
			(array as object[])[3] = new XElement(UtilsString.Ⴐ(null, 8, 192632265), arcLogInResp.Type);
			object obj = new XElement(name, (object[])array);
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2:
				case 4:
				case 5:
					break;
				case 1:
					return ((XElement)obj).ToString();
				}
				break;
			}
		}
	}

	public static void DeserializeNode(this ArcLogInResp arcLogInResp, string strXml)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object obj = DgvCheckBoxColumnFilter.Ⴓ(strXml, '\u030a', 801);
		object enumerator = ((XElement)obj).Elements().GetEnumerator();
		try
		{
			int num = 5;
			XContainer current = default(XContainer);
			object obj2 = default(object);
			IEquatable<string> equatable = default(IEquatable<string>);
			while (true)
			{
				switch (num)
				{
				default:
					num = 7;
					continue;
				case 14:
					current = ((IEnumerator<XElement>)enumerator).Current;
					obj2 = DxCommentExtCfg.ႷႭ(UtilsXml.Ⴓ((XElement)current, 294, 'Ľ'), 410, 408);
					num = ⴃႤ[226] - 48306;
					continue;
				case 3:
					num = (((equatable = obj2 as string) == null) ? 7 : 17);
					continue;
				case 17:
					num = (FrmUpdating.ႠႥ(equatable as string, UtilsString.Ⴐ(null, 7, 192632121), 425, 405) ? (ⴗ[25] - 18228) : (ⴀ[216] - 9805));
					continue;
				case 16:
					num = (FrmUpdating.ႠႥ(equatable as string, UtilsString.Ⴐ(null, 7, 192632112), 208, 236) ? 11 : (ⴀ[190] - ⴀ[190]));
					continue;
				case 0:
					num = (FrmUpdating.ႠႥ((string)equatable, UtilsString.Ⴐ(null, 4, 192632267), 841, 885) ? 2 : 8);
					continue;
				case 8:
					num = (FrmUpdating.ႠႥ((string)equatable, UtilsString.Ⴐ(null, 0, 192632257), 323, 383) ? (ⴐ[503] - 56436) : (ⴃႭ[170] - 55332));
					continue;
				case 10:
					num = 7;
					continue;
				case 12:
				case 15:
				{
					PrecisionTimer.ႤႠ(arcLogInResp, FrmUpdating.ႠႭ(current as XElement, 264, 320), 290, 'Ċ');
					char num2 = ⴗ[8];
					DataGridViewColumnSelector.Ⴐ[4] = (char)((DataGridViewColumnSelector.Ⴐ[4] ^ DataGridViewColumnSelector.Ⴐ[182]) & 0x5D);
					num = num2 - 15531;
					continue;
				}
				case 11:
					arcLogInResp.Alias = (current as XElement).Value;
					goto case 1;
				case 1:
					num = 7;
					continue;
				case 2:
				case 6:
					arcLogInResp.Message = ((XElement)current).Value;
					num = ⴃႭ[253] - 35208;
					continue;
				case 4:
					arcLogInResp.Type = (current as XElement).Value;
					break;
				case 7:
					break;
				case 13:
					goto end_IL_0048;
				}
				num = ((enumerator as IEnumerator<XElement>).MoveNext() ? 14 : 13);
				continue;
				end_IL_0048:
				break;
			}
		}
		finally
		{
			int num3 = 4;
			while (true)
			{
				int num4;
				switch (num3)
				{
				default:
					num4 = ((enumerator is IEnumerator<XElement>) ? 5 : 0);
					goto IL_02ed;
				case 2:
				case 5:
					((IEnumerator<XElement>)enumerator).Dispose();
					break;
				case 0:
					break;
				}
				break;
				IL_02ed:
				num3 = num4;
			}
		}
		switch (3)
		{
		}
	}

	[SecuritySafeCritical]
	static ArcLogInRespExt()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static char[] Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		Array array = default(Array);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[271] - 13741;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
				case 4:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 65) ^ num) switch
					{
						0 => 2, 
						_ => 7, 
					};
					continue;
				case 7:
					array = null;
					num2 = 10;
					continue;
				case 2:
					array = P_0.ToCharArray();
					num2 = 10;
					continue;
				case 9:
				case 10:
				{
					num++;
					int num3 = 382;
					int num4 = 901;
					num2 = ((9010 > num4 - num3 * 10) ? 8 : 11);
					continue;
				}
				case 11:
					num2 = 1;
					continue;
				case 3:
				case 8:
					return (char[])array;
				case 6:
					num2 = ⴐ[517] - 53488;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static WebRequest Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		MarshalByRefObject marshalByRefObject = default(MarshalByRefObject);
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
					num2 = 2;
					continue;
				case 2:
					break;
				case 8:
					num2 = (((P_1 ^ P_2) - 52) ^ num) switch
					{
						0 => ⴃႣ[144] - 42516, 
						_ => ⴀ[191] - 62000, 
					};
					continue;
				case 6:
					marshalByRefObject = null;
					goto case 4;
				case 4:
				case 5:
					num2 = ⴀ[154] - 28004;
					continue;
				case 1:
					marshalByRefObject = WebRequest.Create(P_0);
					num2 = ⴐ[506] - 14735;
					continue;
				case 3:
				case 10:
				{
					num++;
					int num3 = 527;
					int num4 = 572;
					num2 = ((4004 > num4 - num3 * 7) ? 9 : 11);
					continue;
				}
				case 11:
					num2 = ⴃႤ[125] - 39732;
					continue;
				case 9:
					return marshalByRefObject as WebRequest;
				case 0:
					num2 = ⴃႤ[481] - 29434;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static FileStream Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, char P_3) where _0021_00210 : string
	{
		object obj = default(object);
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
					num2 = 8;
					continue;
				case 8:
					break;
				case 2:
					num2 = (((P_2 ^ P_3) - 78) ^ num) switch
					{
						0 => 1, 
						_ => 3, 
					};
					continue;
				case 3:
					obj = null;
					num2 = 5;
					continue;
				case 1:
				case 4:
				case 9:
					obj = File.Create(P_0, P_1);
					num2 = 5;
					continue;
				case 5:
					num++;
					num3 = 1395;
					num4 = 350;
					goto case 10;
				case 10:
					num2 = ((465 < num3 / 3 - num4) ? 2 : 6);
					continue;
				case 6:
				{
					FileStream result = (FileStream)obj;
					TalkCfg.ႣႣ[159] = (char)(TalkCfg.ႣႣ[159] & WxCfg.ႣႭ[245] & 0xBE);
					return result;
				}
				case 7:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataView Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DataTable
	{
		char[] ⴗ = DxCfg.Ⴗ;
		ISupportInitializeNotification supportInitializeNotification = default(ISupportInitializeNotification);
		int num3 = default(int);
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
					num2 = 8;
					continue;
				case 8:
					break;
				case 6:
					num2 = (((P_1 ^ P_2) - 76) ^ num) switch
					{
						0 => 7, 
						_ => 10, 
					};
					continue;
				case 4:
				case 10:
					supportInitializeNotification = null;
					num2 = 1;
					continue;
				case 7:
					supportInitializeNotification = P_0.DefaultView;
					num2 = ⴗ[28] - 12123;
					continue;
				case 1:
					num++;
					goto case 5;
				case 5:
					num3 = 1292;
					goto case 2;
				case 2:
				{
					int num4 = 100;
					num2 = ((323 < num3 / 4 - num4) ? 6 : 9);
					continue;
				}
				case 9:
					return supportInitializeNotification as DataView;
				case 0:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, char P_3) where _0021_00210 : ToolStripItem where _0021_00211 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 3;
				continue;
			case 3:
				num = (((P_3 ^ P_2) - 32) ^ num2) switch
				{
					0 => 6, 
					_ => 5, 
				};
				continue;
			case 5:
				num = ⴗ[25] - 18236;
				continue;
			case 2:
			case 6:
			case 7:
				P_0.ToolTipText = P_1;
				goto case 4;
			case 4:
				num2++;
				break;
			case 8:
				break;
			case 1:
				return;
			}
			int num3 = 188;
			int num4 = 92;
			num = ((94 < num3 / 2 - num4) ? 3 : (ⴃႭ[229] - 32489));
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : EventHandler where _0021_00211 : ToolStripItem
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 2;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴗ[85] - 5442;
				continue;
			case 8:
				num = (((P_3 ^ P_2) - 41) ^ num2) switch
				{
					0 => 0, 
					_ => 4, 
				};
				continue;
			case 1:
			case 4:
				num = ⴃႤ[284] - 37539;
				continue;
			case 0:
				P_0.Click += P_1;
				goto case 3;
			case 3:
				num2++;
				num3 = 1446;
				break;
			case 6:
				break;
			case 5:
				return;
			}
			int num4 = 66;
			num = ((723 < num3 / 2 - num4) ? 8 : 5);
		}
	}
}
