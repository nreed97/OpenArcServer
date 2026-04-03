using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Security;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Pcxx;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods.Login;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.ArcUtils;

[XmlRoot("dictionary")]
public class SerializableConcurrentDictionary<TKey, TValue> : ConcurrentDictionary<TKey, TValue>, IXmlSerializable
{
	protected virtual string ItemTagName
	{
		get
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			return ႣႼ.Ⴜ(0, 365387046, 9);
		}
	}

	protected virtual string KeyTagName
	{
		get
		{
			string result = UtilsString.Ⴐ(null, 6, 192631744);
			NeedsCfg.ႣႤ[422] = (NeedsCfg.ႣႤ[422] | NeedsCfg.ႣႤ[105]) & 0xE;
			return result;
		}
	}

	protected virtual string ValueTagName => ArcLogInRqstExt.Ⴗ(1706506924, 3, 0);

	public XmlSchema GetSchema()
	{
		return null;
	}

	public void ReadXml(XmlReader reader)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 2;
		object obj = default(object);
		object obj2 = default(object);
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new XmlSerializer(typeof(TKey));
				obj2 = new XmlSerializer(typeof(TValue));
				flag = PcxxServerClient.Ⴀ(reader, 'Ð', 237);
				num = ⴃႭ[64] - 60323;
				continue;
			case 1:
				ArcUserCfg.Ⴈ(reader, 'ǋ', 'Ǧ');
				break;
			case 3:
			case 5:
				break;
			case 0:
			case 4:
				return;
			}
			bool num2 = flag;
			DxCfg.Ⴗ[133] = (char)((DxCfg.Ⴗ[133] - DxCfg.Ⴗ[143]) & 0x4A);
			if (!num2)
			{
				break;
			}
			num = 0;
		}
		TKey key = default(TKey);
		TValue value = default(TValue);
		while (true)
		{
			int num3 = ((reader.NodeType != XmlNodeType.EndElement) ? (ⴗ[69] - 49316) : 3);
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					return;
				case 0:
				case 4:
					DxAtlasData.Ⴗ(reader, ItemTagName, 'ŝ', 372);
					DxAtlasData.Ⴗ(reader, KeyTagName, 'Ȭ', 517);
					goto case 5;
				case 5:
					num3 = ⴃႤ[447] - 55112;
					continue;
				case 8:
					key = (TKey)XmlSerializationHelper.Ⴃ((XmlSerializer)obj, reader, 'Ȫ', 'ɱ');
					ႰႨ.ႨႣ(reader, 133, 251);
					num3 = ⴃႭ[232] - 45201;
					continue;
				case 6:
					DxAtlasData.Ⴗ(reader, ValueTagName, 'Ņ', 364);
					value = (TValue)XmlSerializationHelper.Ⴃ(obj2 as XmlSerializer, reader, 'Ď', 'ŕ');
					num3 = ⴃႤ[320] - 20178;
					continue;
				case 7:
					reader.ReadEndElement();
					TryAdd(key, value);
					reader.ReadEndElement();
					goto case 1;
				case 1:
					reader.MoveToContent();
					num3 = ⴃႭ[36] - 6377;
					continue;
				case 2:
					break;
				case 3:
					reader.ReadEndElement();
					return;
				}
				break;
			}
		}
	}

	public void WriteXml(XmlWriter writer)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object obj = new XmlSerializer(typeof(TKey));
		object obj2 = new XmlSerializer(typeof(TValue));
		object enumerator = base.Keys.GetEnumerator();
		try
		{
			int num = 5;
			TKey current = default(TKey);
			while (true)
			{
				switch (num)
				{
				default:
					num = 1;
					continue;
				case 3:
					current = (enumerator as IEnumerator<TKey>).Current;
					DgvFilterHost.ႥႷ(writer, ItemTagName, 'ƽ', 443);
					num = 0;
					continue;
				case 0:
					DgvFilterHost.ႥႷ(writer, KeyTagName, 'ʇ', 641);
					FrmUpdating.ႠႰ(obj as XmlSerializer, writer, (object)current, 'ȯ', 'ɫ');
					goto case 2;
				case 2:
					num = ⴐ[2] - 52871;
					continue;
				case 8:
					UnZipFiles.Ⴃ(writer, 590, 557);
					DgvFilterHost.ႥႷ(writer, ValueTagName, 'η', 945);
					num = ⴐ[17] - 45887;
					continue;
				case 11:
				{
					TValue val = base[current];
					((XmlSerializer)obj2).Serialize(writer, val);
					num = 7;
					continue;
				}
				case 7:
					writer.WriteEndElement();
					writer.WriteEndElement();
					break;
				case 1:
					break;
				case 6:
				case 9:
					goto end_IL_003e;
				}
				num = ((enumerator as IEnumerator<TKey>).MoveNext() ? 3 : 6);
				continue;
				end_IL_003e:
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
					num3 = ((!(enumerator is IEnumerator<TKey>)) ? 2 : (ⴃႭ[270] - 64634));
					goto IL_01a3;
				case 1:
					((IEnumerator<TKey>)enumerator).Dispose();
					break;
				case 2:
				case 6:
					break;
				}
				break;
				IL_01a3:
				num2 = num3;
			}
		}
		switch (1)
		{
		}
	}

	[SecuritySafeCritical]
	static SerializableConcurrentDictionary()
	{
		UtilsIdentity.Ⴐ();
	}
}
