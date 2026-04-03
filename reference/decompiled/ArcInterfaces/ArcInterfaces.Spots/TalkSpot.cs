using System;

namespace ArcInterfaces.Spots;

[Serializable]
public sealed class TalkSpot
{
	public string To { get; set; }

	public string Spotter { get; set; }

	public string SpotterNode { get; set; }

	public string Msg { get; set; }

	public string BellFlag { get; set; }

	public string RelayToCall { get; set; }

	public string Route { get; set; }

	public DateTime Dts { get; set; }

	public TalkSpot()
	{
		Spotter = string.Empty;
		SpotterNode = string.Empty;
		Msg = string.Empty;
		Spotter = string.Empty;
		BellFlag = string.Empty;
		RelayToCall = string.Empty;
		Route = string.Empty;
	}
}
