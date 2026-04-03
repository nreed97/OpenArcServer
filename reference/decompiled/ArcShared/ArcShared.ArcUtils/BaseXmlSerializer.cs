using System;
using System.IO;
using System.Security;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.MaintenanceUpdates;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using Ⴃ;

namespace ArcShared.ArcUtils;

[Serializable]
[XmlRoot("ArcStringConfig", Namespace = "AB5K", IsNullable = false)]
public class BaseXmlSerializer
{
	private static readonly ILog _log;

	public static object LoadFromFile(Type type, string fileName)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		FileStream fileStream = null;
		object result = default(object);
		try
		{
			fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			XmlSerializer xmlSerializer = new XmlSerializer(type);
			result = AutoUpdater.ႨႼ(xmlSerializer, (Stream)fileStream, 891, ';');
			return result;
		}
		catch (Exception ex)
		{
			_log.Error(PrecisionTimer.Ⴜ(ex, 908, 'ϑ'));
		}
		finally
		{
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((fileStream == null) ? (ⴗ[80] - 32460) : 0);
					goto IL_009d;
				case 0:
				case 3:
					fileStream.Close();
					break;
				case 1:
				case 2:
					break;
				}
				break;
				IL_009d:
				num = num2;
			}
		}
		switch (0)
		{
		default:
			return null;
		case 1:
		case 3:
		case 4:
			return result;
		}
	}

	public static object LoadFromXml(Type type, string xml)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		StringReader stringReader = null;
		object obj = default(object);
		try
		{
			stringReader = new StringReader(xml);
			XmlSerializer xmlSerializer = new XmlSerializer(type);
			obj = ReverseBeaconClient.Ⴅ(xmlSerializer, (TextReader)stringReader, 'æ', 182);
			return obj;
		}
		catch (Exception ex)
		{
			_log.Error(PrecisionTimer.Ⴜ(ex, 367, 'Ĳ'));
		}
		finally
		{
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((stringReader == null) ? 4 : 3);
					goto IL_00a8;
				case 1:
				case 3:
					stringReader.Close();
					break;
				case 4:
					break;
				}
				break;
				IL_00a8:
				num = num2;
			}
		}
		return 0 switch
		{
			4 => obj, 
			_ => null, 
		};
	}

	public void SaveToFile(string fileName)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		FileStream fileStream = null;
		try
		{
			fileStream = new FileStream(fileName, FileMode.Create);
			SaveToFile(fileStream);
		}
		catch (Exception ex)
		{
			_log.Error(PrecisionTimer.Ⴜ(ex, 666, 'ˇ'));
		}
		finally
		{
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((fileStream == null) ? (ⴐ[603] - 46153) : (ⴃႭ[209] - 32134));
					goto IL_0071;
				case 0:
				case 2:
				case 5:
					fileStream.Close();
					break;
				case 4:
					break;
				}
				break;
				IL_0071:
				num = num2;
			}
		}
	}

	public void SaveToFile(Stream stream)
	{
		try
		{
			int num = 5;
			XmlSerializer xmlSerializer = default(XmlSerializer);
			XmlTextWriter xmlTextWriter = default(XmlTextWriter);
			while (true)
			{
				switch (num)
				{
				default:
				{
					Type type = ႰႨ.ႨႨ((object)this, 'ū', 'ľ');
					xmlSerializer = new XmlSerializer(type);
					goto IL_003a;
				}
				case 1:
					goto IL_003a;
				case 2:
					DirectoryMonitor.ႠႭ(xmlTextWriter, Formatting.Indented, 'ğ', 303);
					break;
				case 0:
				case 4:
					break;
				}
				break;
				IL_003a:
				xmlTextWriter = new XmlTextWriter(stream, new UTF8Encoding());
				num = 2;
			}
			FrmUpdating.ႠႰ(xmlSerializer, (XmlWriter)xmlTextWriter, (object)this, ' ', 'd');
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
		switch (2)
		{
		}
	}

	public string ToXml()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		StringWriter stringWriter = new StringWriter();
		try
		{
			int num = 3;
			Type type = default(Type);
			while (true)
			{
				switch (num)
				{
				default:
					type = ႰႨ.ႨႨ((object)this, 'Z', '\u000f');
					goto case 4;
				case 4:
				{
					XmlSerializer xmlSerializer = new XmlSerializer(type);
					AnnWxSpotExt.ႤႨ(xmlSerializer, (TextWriter)stringWriter, (object)this, (short)353, (short)306);
					break;
				}
				case 5:
					break;
				case 1:
					UtilsString.Ⴍ((object)stringWriter, '\u001c', 14);
					goto end_IL_0045;
				}
				num = 1;
				continue;
				end_IL_0045:
				break;
			}
		}
		catch (Exception ex)
		{
			_log.Error(ex.Message);
		}
		return 2 switch
		{
			_ => stringWriter.ToString(), 
		};
	}

	[SecuritySafeCritical]
	static BaseXmlSerializer()
	{
		UtilsIdentity.Ⴐ();
		_log = ArcLogInRqstExt.Ⴍ(ႣႼ.Ⴜ(3, 365385842, 0), 434, 493);
	}
}
