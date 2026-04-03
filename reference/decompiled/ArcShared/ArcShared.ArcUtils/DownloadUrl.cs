using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using ArcShared.ArcCfg;
using ArcShared.DgvUtils;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.Forms;

namespace ArcShared.ArcUtils;

public sealed class DownloadUrl
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴃ
	{
		internal CancelEventHandler Ⴐ;

		internal DataGridViewColumn Ⴄ;

		internal DataView Ⴗ;

		internal Type Ⴈ;

		internal bool Ⴓ;

		internal bool Ⴀ;
	}

	public static XmlDocument DownloadToXmlDoc(string url, string proxyURL)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		MarshalByRefObject responseStream = default(MarshalByRefObject);
		while (true)
		{
			XmlNode xmlNode = new XmlDocument();
			while (true)
			{
				IL_0041:
				object obj = (HttpWebRequest)ArcLogInRespExt.Ⴀ(url, 242, 198);
				int num = ((UtilsCallsign.Ⴓ(proxyURL, 62, 9) > 0) ? 1 : 0);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 5;
						continue;
					case 2:
					case 5:
						break;
					case 4:
						goto IL_0041;
					case 1:
						AnnWxSpotExt.Ⴄ((WebRequest)(obj as HttpWebRequest), (IWebProxy)new WebProxy(proxyURL, BypassOnLocal: true), (short)238, 223);
						goto case 0;
					case 0:
					{
						ISerializable serializable = (HttpWebResponse)UtilsCopyright.Ⴅ((WebRequest)(obj as HttpWebRequest), 'ŗ', 331);
						responseStream = ((HttpWebResponse)serializable).GetResponseStream();
						num = ⴀ[80] - 15286;
						continue;
					}
					case 7:
						(xmlNode as XmlDocument).Load(responseStream as Stream);
						return (XmlDocument)xmlNode;
					}
					break;
				}
				break;
			}
		}
	}

	public static void DownloadToFile(string url, string filePath, string sProxy)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		Stream stream = ArcLogInRespExt.Ⴈ(filePath, 16384, 'ʣ', '\u02ed');
		try
		{
			object obj = default(object);
			switch (2)
			{
			default:
				obj = ArcLogInRespExt.Ⴀ(url, 644, 688);
				break;
			case 1:
			case 3:
				break;
			}
			object obj2 = UtilsCopyright.Ⴅ(obj as WebRequest, '£', 191);
			try
			{
				switch (2)
				{
				default:
				{
					object obj3 = UtilsXml.Ⴈ((WebResponse)obj2, 424, 'Ɩ');
					try
					{
						int num = 6;
						object obj4 = default(object);
						int num2 = default(int);
						while (true)
						{
							switch (num)
							{
							default:
								obj4 = new byte[16384];
								num = 8;
								continue;
							case 0:
							case 8:
								num2 = DxSpotExt.Ⴈ(obj3 as Stream, obj4 as byte[], 0, 16384, 247, 192);
								num = 5;
								continue;
							case 5:
								HelpAboutServer.Ⴜ((Stream)(stream as FileStream), (byte[])obj4, 0, num2, '\u02c2', 652);
								num = ⴃႤ[530] - 23110;
								continue;
							case 2:
								num = ((num2 > 0) ? 8 : 3);
								continue;
							case 1:
							case 3:
							case 4:
								break;
							}
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
								num4 = (((Stream)obj3 == null) ? 6 : 4);
								goto IL_0181;
							case 4:
								((IDisposable)(Stream)obj3).Dispose();
								break;
							case 2:
							case 3:
							case 6:
								break;
							}
							break;
							IL_0181:
							num3 = num4;
						}
					}
					switch (1)
					{
					}
					break;
				}
				}
			}
			finally
			{
				int num5 = 4;
				while (true)
				{
					int num6;
					switch (num5)
					{
					default:
						num6 = ((!(obj2 is WebResponse)) ? (ⴀ[336] - 2402) : 6);
						goto IL_01e3;
					case 6:
						((IDisposable)(obj2 as WebResponse)).Dispose();
						break;
					case 2:
						break;
					}
					break;
					IL_01e3:
					num5 = num6;
				}
			}
			switch (0)
			{
			}
		}
		finally
		{
			int num7 = 1;
			while (true)
			{
				int num8;
				switch (num7)
				{
				default:
					num8 = ((!(stream is FileStream)) ? (ⴃႭ[109] - 6060) : 0);
					goto IL_0252;
				case 0:
					((IDisposable)(stream as FileStream)).Dispose();
					break;
				case 5:
				case 6:
					break;
				}
				break;
				IL_0252:
				num7 = num8;
			}
		}
		switch (0)
		{
		}
	}

	[SecuritySafeCritical]
	static DownloadUrl()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static object Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : string where _0021_00211 : DataRow
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object result = default(object);
		int num3 = default(int);
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
					num2 = (((P_2 ^ P_3) - 33) ^ num) switch
					{
						0 => ⴐ[168] - 4241, 
						_ => ⴃႭ[67] - 30147, 
					};
					continue;
				case 5:
					result = null;
					num2 = ⴀ[370] - 60428;
					continue;
				case 10:
					result = P_0[P_1];
					num2 = ⴃႤ[413] - 24175;
					continue;
				case 9:
				case 11:
					num++;
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					num2 = ⴃႤ[188] - 25842;
					continue;
				case 6:
					num2 = ((num3 % 2 != 0) ? 2 : 7);
					continue;
				case 7:
					return result;
				case 0:
				case 4:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly Ⴄ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : ResolveEventArgs
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = default(object);
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 5:
					num2 = (((P_2 ^ P_1) - 65) ^ num) switch
					{
						0 => 4, 
						_ => ⴀ[43] - 13274, 
					};
					continue;
				case 7:
					obj = null;
					num2 = 1;
					continue;
				case 4:
					obj = P_0.RequestingAssembly;
					num2 = ⴃႣ[176] - 11045;
					continue;
				case 0:
				case 1:
					num++;
					goto case 6;
				case 6:
					num3 = P_1 * P_1;
					goto case 2;
				case 2:
					num3 = P_1 + num3;
					num2 = ⴃႣ[2] - 5257;
					continue;
				case 11:
					num2 = ((num3 % 2 != 0) ? 5 : 3);
					continue;
				case 3:
					return obj as Assembly;
				case 8:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Color Ⴐ(short P_0, short P_1)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		Color color = default(Color);
		Color result = default(Color);
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
					num2 = ⴃႤ[141] - 20927;
					continue;
				case 1:
					break;
				case 2:
					num2 = (((P_1 ^ P_0) - 55) ^ num) switch
					{
						0 => 6, 
						_ => 9, 
					};
					continue;
				case 9:
					color = default(Color);
					goto case 0;
				case 0:
					result = color;
					num2 = 3;
					continue;
				case 6:
					result = SystemColors.ControlLightLight;
					num2 = 3;
					continue;
				case 3:
					num++;
					goto case 7;
				case 7:
				{
					int num3 = 1107;
					int num4 = 240;
					num2 = ((369 < num3 / 3 - num4) ? 2 : 10);
					continue;
				}
				case 10:
					return result;
				case 4:
				case 8:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211, _0021_00212>(_0021_00211 P_0, _0021_00210 P_1, _0021_00212 P_2, char P_3, char P_4) where _0021_00210 : SendOrPostCallback where _0021_00211 : SynchronizationContext
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 9;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴗ[33] - 33387;
				break;
			case 4:
				num = (((P_3 ^ P_4) - 41) ^ num2) switch
				{
					0 => ⴃႣ[232] - 47278, 
					_ => 1, 
				};
				break;
			case 1:
				num = 8;
				break;
			case 5:
				P_0.Send(P_1, P_2);
				goto case 0;
			case 0:
			case 8:
				num2++;
				num3 = 289;
				goto case 6;
			case 6:
			{
				int num4 = 317;
				num = ((634 > num4 - num3 * 2) ? (ⴐ[320] - 49924) : 2);
				break;
			}
			case 2:
				num = 4;
				break;
			case 3:
				return;
			}
		}
	}
}
