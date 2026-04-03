using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Xml;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcWeb;

public sealed class YahooGeoRef
{
	public class GeoRefResults
	{
		private string Ⴍ;

		private ShowWx.Ⴀ Ⴄ = new ShowWx.Ⴀ();

		public string Result
		{
			get
			{
				byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
				string ⴍ = Ⴍ;
				SetAnnMode.ႤႭ[601] = (byte)((SetAnnMode.ႤႭ[601] | SetAnnMode.ႤႭ[120]) & 0x82);
				return ⴍ;
			}
			set
			{
				Ⴍ = value;
			}
		}

		public string Lat
		{
			get
			{
				return Ⴄ.Ⴈ;
			}
			set
			{
				Ⴄ.Ⴈ = value as string;
			}
		}

		public string Lon
		{
			get
			{
				return Ⴄ.Ⴓ;
			}
			set
			{
				Ⴄ.Ⴓ = value;
			}
		}

		public GeoRefResults()
		{
			Lon = string.Empty;
			Lat = string.Empty;
			Result = string.Empty;
		}
	}

	private static readonly ILog Ⴀ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216129792, 6, '+'), 634, 615);

	private readonly string Ⴓ = string.Empty;

	public YahooGeoRef(string proxy)
	{
		Ⴓ = proxy;
	}

	public GeoRefResults Run(string queryString)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		ICloneable cloneable = default(ICloneable);
		object obj = default(object);
		while (true)
		{
			IEnumerable<char> enumerable = ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(10, 3, 1157898381), queryString, 115, 61);
			int num = ⴀႣ[259] - 48456;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 0:
				case 3:
					break;
				case 1:
				case 6:
					cloneable = Ⴃ(enumerable as string, Ⴓ);
					goto case 4;
				case 4:
					obj = Ⴃ((string)cloneable);
					num = ⴃႠ[99] - 39696;
					continue;
				case 2:
					return (GeoRefResults)obj;
				}
				break;
			}
		}
	}

	private static GeoRefResults Ⴃ(string P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		object obj3 = default(object);
		XmlNode xmlNode = default(XmlNode);
		object obj2 = default(object);
		ICloneable cloneable = default(ICloneable);
		IEnumerable enumerable = default(IEnumerable);
		object obj5 = default(object);
		while (CallBlockCacheCfg.Ⴜ(P_0, 231, 134) > 0)
		{
			int num = ⴄႷ[68] - 14169;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 6;
					continue;
				case 6:
					break;
				case 2:
					obj3 = new GeoRefResults();
					xmlNode = new XmlDocument();
					goto case 0;
				case 0:
					DirectoryHelp.Ⴓ((XmlNode)(XmlDocument)xmlNode, P_0, (short)956, (short)952);
					num = ⴄႤ[146] - 158;
					continue;
				case 8:
				{
					object obj = xmlNode as XmlDocument;
					obj2 = TalkCacheCfg.Ⴗ((XmlNode)(obj as XmlDocument), SetStationClubHelp.Ⴍ(10, 8, 1747262851, null), 741, 'ʸ');
					num = ⴀႨ[196] - 23281;
					continue;
				}
				case 4:
				case 5:
					goto IL_010f;
				case 3:
					goto IL_0122;
				}
				break;
				IL_0122:
				object obj4 = FocCacheCfg.Ⴍ(obj2 as XmlNodeList, 'C', 'J');
				try
				{
					int num2 = 2;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = 4;
							continue;
						case 11:
							cloneable = (XmlNode)((IEnumerator)obj4).Current;
							goto case 6;
						case 6:
							num2 = (((enumerable = DxSpotBlockCacheCfg.Ⴗ(cloneable as XmlNode, 942, 977)) == null) ? (ⴅ[99] / 4) : (ⴄႷ[105] - 22528));
							continue;
						case 12:
							num2 = (ByeHelp.Ⴍ((string)enumerable, ShowWxHelp.Ⴍ('a', 985805683, 4), 995, 900) ? 14 : 8);
							continue;
						case 8:
							num2 = (ByeHelp.Ⴍ(enumerable as string, ႰႥ.Ⴅ(3, '|', 952616033), 808, 847) ? (ⴍႤ[41] - 39304) : (ⴍႭ[256] - 30592));
							continue;
						case 5:
						case 9:
							num2 = (ByeHelp.Ⴍ(enumerable as string, SetStationQth.Ⴍ(null, 1687354829, 5, 8), 42, 77) ? (ⴄႭ[66] * 8) : 10);
							continue;
						case 10:
							num2 = 4;
							continue;
						case 14:
							(obj3 as GeoRefResults).Result = OperatingHelp.Ⴃ((XmlNode)cloneable, 'ɧ', 591);
							num2 = ⴍႤ[37] - 12665;
							continue;
						case 3:
							(obj3 as GeoRefResults).Lat = (cloneable as XmlNode).InnerText;
							num2 = ⴀႼ[124] - 19;
							continue;
						case 0:
						case 7:
							((GeoRefResults)obj3).Lon = (cloneable as XmlNode).InnerText;
							break;
						case 4:
							break;
						case 1:
							goto end_IL_0136;
						}
						num2 = ((!(obj4 as IEnumerator).MoveNext()) ? 1 : 11);
						continue;
						end_IL_0136:
						break;
					}
				}
				finally
				{
					int num3 = 1;
					while (true)
					{
						int num4;
						switch (num3)
						{
						default:
							obj5 = (obj4 as IEnumerator) as IDisposable;
							goto case 6;
						case 6:
							num4 = (((IDisposable)obj5 == null) ? 4 : ⴄႭ[246]);
							goto IL_0344;
						case 2:
							(obj5 as IDisposable).Dispose();
							break;
						case 0:
						case 4:
							break;
						}
						break;
						IL_0344:
						num3 = num4;
					}
				}
				goto IL_0358;
				IL_010f:
				if ((XmlNodeList)obj2 != null)
				{
					num = 3;
					continue;
				}
				goto IL_0358;
				IL_0358:
				switch (4)
				{
				default:
					return (GeoRefResults)obj3;
				case 1:
				case 2:
				case 3:
					break;
				}
				goto end_IL_0070;
			}
			continue;
			end_IL_0070:
			break;
		}
		return null;
	}

	private static string Ⴃ(string P_0, string P_1)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		IComparable<string> comparable = string.Empty;
		try
		{
			int num = 2;
			ISerializable serializable = default(ISerializable);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					serializable = SetTalkDefaultHelp.Ⴗ(P_0, 333, 'ĩ');
					num = ((CallBlockCacheCfg.Ⴜ(P_1, 16, 113) <= 0) ? (ⴀႣ[5] - ⴀႣ[5]) : (ⴐ[360] - ⴐ[271]));
					continue;
				case 1:
					obj2 = new WebProxy(P_1, BypassOnLocal: true);
					goto case 4;
				case 4:
					ShowPrefix.Ⴀ(obj2 as WebProxy, ShowSun.ႰႷ('7', 100), 531, 516);
					num = 3;
					continue;
				case 3:
				{
					object obj = obj2 as WebProxy;
					DirectorySubjectHelp.Ⴓ((WebRequest)serializable, (IWebProxy)(obj as WebProxy), 784, '\u030b');
					break;
				}
				case 0:
				case 5:
					break;
				}
				break;
			}
			WebResponse webResponse = LotwCacheCfg.Ⴅ((WebRequest)serializable, 538, 541) as HttpWebResponse;
			try
			{
				int num2 = 2;
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = (((HttpWebResponse)webResponse == null) ? 6 : (ⴀႣ[301] - 4355));
						continue;
					case 0:
					case 4:
					{
						object obj3 = new StreamReader(DxClusterCacheCfg.Ⴐ((WebResponse)(webResponse as HttpWebResponse), 548, (short)583));
						comparable = (obj3 as StreamReader).ReadToEnd();
						num2 = 6;
						continue;
					}
					case 1:
					case 6:
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
						num4 = ((!(webResponse is HttpWebResponse)) ? 4 : (ⴀႼ[87] - ⴀႼ[1]));
						goto IL_01c5;
					case 1:
						((IDisposable)(HttpWebResponse)webResponse).Dispose();
						break;
					case 4:
						break;
					}
					break;
					IL_01c5:
					num3 = num4;
				}
			}
			switch (0)
			{
			}
		}
		catch (Exception ex)
		{
			Ⴀ.Warn(ex.Message);
		}
		return 0 switch
		{
			_ => comparable as string, 
		};
	}
}
