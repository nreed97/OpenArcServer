using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.ReverseBeacon;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using log4net;

namespace Ⴈ;

internal sealed class ႰႤ
{
	private static readonly ILog m_Ⴐ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('I', 985807802, 3), 433, 428);

	private SetDxMode.Ⴅ m_Ⴄ = new SetDxMode.Ⴅ();

	[SpecialName]
	public string Ⴃ()
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		return this.m_Ⴄ.Ⴃ;
	}

	[SpecialName]
	public void Ⴍ(string P_0)
	{
		this.m_Ⴄ.Ⴃ = P_0 as string;
	}

	[SpecialName]
	public string Ⴅ()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		return this.m_Ⴄ.Ⴄ;
	}

	[SpecialName]
	public void Ⴐ(string P_0)
	{
		this.m_Ⴄ.Ⴄ = P_0 as string;
	}

	[SpecialName]
	public Guid Ⴀ()
	{
		return this.m_Ⴄ.Ⴍ;
	}

	[SpecialName]
	public void Ⴄ(Guid P_0)
	{
		this.m_Ⴄ.Ⴍ = P_0;
	}

	internal bool Ⴈ()
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		bool result = default(bool);
		try
		{
			int num = 7;
			object obj3 = default(object);
			ICloneable cloneable = default(ICloneable);
			bool flag = default(bool);
			object obj2 = default(object);
			ICloneable cloneable2 = default(ICloneable);
			IComparable innerText = default(IComparable);
			while (true)
			{
				switch (num)
				{
				default:
					obj3 = Ⴗ();
					if (obj3 is XmlDocument)
					{
						num = 6;
						continue;
					}
					break;
				case 6:
					cloneable = AnnFullHelp.Ⴈ((XmlNode)(XmlDocument)obj3, '\u035e', 'ͼ');
					Ⴍ(OperatingHelp.Ⴃ((XmlNode)ShowContestStation.Ⴐ((XmlNode)cloneable, SetTalkCount.Ⴗ(8, null, 1267022187, typeof(ႨႣ)), 425, 497), 'Ƙ', 432));
					num = ⴃႥ[311] - ⴃႥ[311];
					continue;
				case 0:
					Ⴍ(SetDxFilter.Ⴀ(Ⴃ(), 73, '\b'));
					goto case 3;
				case 3:
					flag = false;
					num = ⴐ[105] - 216;
					continue;
				case 4:
				case 5:
				{
					object obj = ShowPrefix.Ⴅ((XmlNode)cloneable, 'ó', 141);
					try
					{
						int num2 = 8;
						while (true)
						{
							switch (num2)
							{
							default:
								num2 = ⴀႳ[59] - 63498;
								continue;
							case 3:
							{
								IEnumerable enumerable = (XmlNode)((IEnumerator)obj).Current;
								num2 = ((!ByeHelp.Ⴍ(DxSpotBlockCacheCfg.Ⴗ(enumerable as XmlNode, 104, 23), ShowWxHelp.Ⴍ('s', 985807974, 0), 693, 722)) ? (ⴃႠ[134] - 19257) : 4);
								continue;
							}
							case 4:
								flag = true;
								goto case 7;
							case 7:
								num2 = 1;
								continue;
							case 0:
							case 2:
								num2 = ((!((IEnumerator)obj).MoveNext()) ? 1 : (ⴀႨ[10] - 37140));
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					finally
					{
						int num3 = 2;
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								obj2 = ((IEnumerator)obj) as IDisposable;
								goto case 0;
							case 0:
								num4 = ((!(obj2 is IDisposable)) ? 4 : 6);
								goto IL_0226;
							case 6:
								(obj2 as IDisposable).Dispose();
								break;
							case 1:
							case 3:
							case 4:
								break;
							}
							break;
							IL_0226:
							num3 = num4;
						}
					}
					int num5 = 5;
					while (true)
					{
						switch (num5)
						{
						default:
							num5 = ((!flag) ? 12 : (ⴄႷ[11] - 38818));
							continue;
						case 8:
						case 11:
							Ⴐ(ReplyMailHelp.Ⴄ(24, null, 1057162836, 0));
							Ⴄ(RevBcnSpot.ႰႭ(758, 'ʎ'));
							num5 = 6;
							continue;
						case 3:
						case 6:
						case 9:
						{
							_Assembly assembly = ShowLog.Ⴍ(743, '\u02ef');
							cloneable2 = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)assembly, 128, 226), 535, 'Ȃ'), ShowWxHelp.Ⴍ('·', 985807959, 6), 634, 564);
							num5 = 1;
							continue;
						}
						case 1:
							Ⴀ((string)cloneable2);
							num5 = ⴍႤ[223] - 31748;
							continue;
						case 12:
							Ⴐ((cloneable as XmlNode)[ShowWxHelp.Ⴍ('ª', 985807938, 0)].InnerText);
							num5 = ⴀႼ[121] - 87;
							continue;
						case 7:
							innerText = ((XmlNode)cloneable)[ႰႥ.Ⴅ(8, '#', 952619274)].InnerText;
							num5 = 10;
							continue;
						case 10:
							Ⴄ(new Guid((string)innerText));
							break;
						case 2:
							break;
						case 0:
							goto end_IL_023d;
						}
						result = true;
						return result;
						continue;
						end_IL_023d:
						break;
					}
					break;
				}
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ႰႤ.m_Ⴐ.Error(ႨႨ.Ⴀ(10, 3, 1157902461) + ex);
		}
		switch (1)
		{
		default:
			return false;
		case 0:
		case 2:
		case 4:
			return result;
		}
	}

	public void Ⴀ(string P_0)
	{
		object obj = Ⴍ();
		Ⴀ((XmlDocument)obj, P_0);
	}

	private static XmlDocument Ⴗ()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		TextReader textReader = default(TextReader);
		IComparable comparable2 = default(IComparable);
		Array array = default(Array);
		Array array2 = default(Array);
		TripleDES tripleDES = default(TripleDES);
		IComparable<string> comparable = default(IComparable<string>);
		object obj2 = default(object);
		int num2 = default(int);
		while (true)
		{
			ISerializable serializable = ShowLog.Ⴍ(298, 'Ģ');
			IEquatable<string> equatable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)serializable, 1010, 912), 117, '`'), ShowWxHelp.Ⴍ('ì', 985807959, 6), 775, 841);
			while (true)
			{
				IL_00a9:
				int num = ⴃႥ[294] - 39532;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 11;
						continue;
					case 0:
					case 11:
						break;
					case 7:
						goto IL_00a9;
					case 6:
						textReader = new StreamReader((string)equatable);
						comparable2 = qslinfoSoapClient.Ⴃ((TextReader)(textReader as StreamReader), (short)555, (short)568);
						num = 5;
						continue;
					case 5:
						ShowQrz.Ⴅ((TextReader)(textReader as StreamReader), '3', '/');
						array = SetWxMode.Ⴗ(comparable2 as string, 'Τ', 973);
						num = 1;
						continue;
					case 1:
					{
						MD5 mD = new MD5CryptoServiceProvider();
						array2 = Configuration.Ⴃ((HashAlgorithm)(MD5CryptoServiceProvider)mD, ႰႭ.Ⴀ(ShowUptime.Ⴗ(185, 247), ႨႨ.Ⴀ(14, 5, 1157902364), 231, 179), ' ', 67);
						num = ⴀ[258] - 1957;
						continue;
					}
					case 9:
						tripleDES = new TripleDESCryptoServiceProvider();
						goto case 8;
					case 8:
						SetAnnWrapHelp.Ⴈ((SymmetricAlgorithm)(tripleDES as TripleDESCryptoServiceProvider), (byte[])array2, 293, 351);
						num = 13;
						continue;
					case 13:
						ႨႤ.Ⴈ((SymmetricAlgorithm)(TripleDESCryptoServiceProvider)tripleDES, CipherMode.ECB, '©', 'Æ');
						comparable = Encoding.ASCII.GetString((tripleDES as TripleDESCryptoServiceProvider).CreateDecryptor().TransformFinalBlock((byte[])array, 0, ((byte[])array).Length));
						num = 10;
						continue;
					case 10:
						obj2 = new XmlDocument();
						num2 = ((string)comparable).IndexOf(ShowWxHelp.Ⴍ('*', 985807944, 0));
						num = 12;
						continue;
					case 12:
						num = ((num2 <= 0) ? 4 : 2);
						continue;
					case 2:
					{
						object obj = (comparable as string).Substring(0, num2 + 6);
						(obj2 as XmlDocument).InnerXml = obj as string;
						goto case 4;
					}
					case 4:
						return (XmlDocument)obj2;
					}
					break;
				}
				break;
			}
		}
	}

	private XmlDocument Ⴍ()
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		object obj2 = default(object);
		XmlLinkedNode xmlLinkedNode2 = default(XmlLinkedNode);
		object obj = default(object);
		while (true)
		{
			XmlNode xmlNode = new XmlDocument();
			XmlLinkedNode xmlLinkedNode = SetAnnDefaultHelp.Ⴓ((XmlDocument)xmlNode, ShowWxHelp.Ⴍ('O', 985807799, 0), 979, 957);
			int num = ⴄႭ[66];
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
				case 0:
				case 8:
					DirectoryOwnHelp.Ⴐ((XmlNode)(XmlDocument)xmlNode, (XmlNode)(xmlLinkedNode as XmlElement), (short)486, 'Ʊ');
					obj2 = SetAnnDefaultHelp.Ⴓ(xmlNode as XmlDocument, SetTalkCount.Ⴗ(5, null, 1267022182, typeof(SetAnnCount)), 998, 904);
					num = 9;
					continue;
				case 9:
					SetStationLoginCmdsHelp.Ⴅ((XmlNode)(XmlElement)obj2, LogEntry.Ⴄ(Ⴃ(), '\u02fc', 726), 405, (short)489);
					num = ⴅ[406] - 232;
					continue;
				case 1:
					DirectoryOwnHelp.Ⴐ((XmlNode)(XmlElement)xmlLinkedNode, (XmlNode)(XmlElement)obj2, (short)847, '\u0318');
					xmlLinkedNode2 = SetAnnDefaultHelp.Ⴓ((XmlDocument)xmlNode, ShowWxHelp.Ⴍ('K', 985807938, 0), 198, 168);
					num = 6;
					continue;
				case 3:
				case 6:
					SetStationLoginCmdsHelp.Ⴅ((XmlNode)(xmlLinkedNode2 as XmlElement), Ⴅ(), 588, (short)560);
					((XmlElement)xmlLinkedNode).AppendChild(xmlLinkedNode2 as XmlElement);
					num = 4;
					continue;
				case 4:
					obj = (xmlNode as XmlDocument).CreateElement(ႰႥ.Ⴅ(5, 'e', 952619271));
					(obj as XmlElement).InnerText = Ⴀ().ToString();
					num = ⴐ[391] - 84;
					continue;
				case 7:
					(xmlLinkedNode as XmlElement).AppendChild(obj as XmlElement);
					return xmlNode as XmlDocument;
				}
				break;
			}
		}
	}

	private static void Ⴀ(XmlDocument P_0, string P_1)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 5;
		IEquatable<string> equatable = default(IEquatable<string>);
		object obj3 = default(object);
		TripleDES tripleDES = default(TripleDES);
		object obj2 = default(object);
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			switch (num)
			{
			default:
				equatable = DxSpotBlockCacheCfg.Ⴗ((XmlNode)P_0, 679, (short)551);
				num = ⴐ[43] / 2;
				break;
			case 0:
				equatable = ShowUsersHelp.Ⴅ(equatable as string, SetTalkOutputHelp.Ⴍ(ႨႨ.Ⴀ(7, 3, 1157902362), 8, 40, 920, 971), 812, 866);
				num = 11;
				break;
			case 11:
				num = ((CallBlockCacheCfg.Ⴜ((string)equatable, 317, 348) >= 65535) ? 7 : 0);
				break;
			case 7:
			{
				MD5 mD = new MD5CryptoServiceProvider();
				obj3 = Configuration.Ⴃ((HashAlgorithm)(MD5CryptoServiceProvider)mD, ႰႭ.Ⴀ(ShowUptime.Ⴗ(390, 456), ႨႨ.Ⴀ(14, 0, 1157902361), 418, 502), '\u0343', 800);
				goto case 1;
			}
			case 1:
				num = 3;
				break;
			case 3:
			case 10:
				tripleDES = new TripleDESCryptoServiceProvider();
				SetAnnWrapHelp.Ⴈ((SymmetricAlgorithm)(tripleDES as TripleDESCryptoServiceProvider), obj3 as byte[], 237, 151);
				num = ⴐ[243];
				break;
			case 8:
				ႨႤ.Ⴈ((SymmetricAlgorithm)(tripleDES as TripleDESCryptoServiceProvider), CipherMode.ECB, 'Â', '\u00ad');
				obj2 = ႰႭ.Ⴀ(ShowUptime.Ⴗ(128, 206), equatable as string, 49, 101);
				num = 2;
				break;
			case 2:
				convertible = Convert.ToBase64String(((TripleDESCryptoServiceProvider)tripleDES).CreateEncryptor().TransformFinalBlock((byte[])obj2, 0, ((byte[])obj2).Length));
				num = 4;
				break;
			case 4:
				num = ((!string.IsNullOrEmpty(P_1)) ? 12 : 6);
				break;
			case 6:
			{
				ICustomAttributeProvider executingAssembly = Assembly.GetExecutingAssembly();
				P_1 = Path.GetDirectoryName(((Assembly)executingAssembly).Location) + ShowWxHelp.Ⴍ('A', 985807954, 3);
				num = 12;
				break;
			}
			case 9:
			case 12:
			{
				object obj = new StreamWriter(P_1);
				(obj as StreamWriter).Write(convertible as string);
				((StreamWriter)obj).Close();
				return;
			}
			}
		}
	}
}
