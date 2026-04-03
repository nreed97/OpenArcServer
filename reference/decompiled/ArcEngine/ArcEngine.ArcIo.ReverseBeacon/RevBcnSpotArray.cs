using System.Xml.Serialization;
using ArcEngine.ArcServerConfig.Caches;

namespace ArcEngine.ArcIo.ReverseBeacon;

[XmlRoot("root")]
public sealed class RevBcnSpotArray
{
	private ChatRoomPvtCfg.Ⴀ Ⴀ = new ChatRoomPvtCfg.Ⴀ();

	[XmlArray("data")]
	[XmlArrayItem("rs")]
	public RevBcnSpot[] Spots
	{
		get
		{
			return Ⴀ.Ⴗ;
		}
		set
		{
			Ⴀ.Ⴗ = value as RevBcnSpot[];
		}
	}
}
