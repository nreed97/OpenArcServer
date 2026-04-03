using System;

namespace ArcInterfaces.Spots;

[Serializable]
public sealed class AnnWxSpot
{
	public string To { get; set; }

	public string Msg { get; set; }

	public string Spotter { get; set; }

	public string SpotterCty { get; set; }

	public string SpotterState { get; set; }

	public string SpotterCont { get; set; }

	public string SpotterNode { get; set; }

	public string SysopFlag { get; set; }

	public string WxFlag { get; set; }

	public string Route { get; set; }

	public string DupeKey { get; set; }

	public bool IsDupe { get; set; }

	public int Id { get; set; }

	public DateTime Dts { get; set; }

	public AnnWxSpot()
	{
		Msg = string.Empty;
		Spotter = string.Empty;
		SpotterNode = string.Empty;
		SysopFlag = string.Empty;
		WxFlag = string.Empty;
		SpotterCty = string.Empty;
		SpotterState = string.Empty;
		SpotterCont = string.Empty;
		Route = string.Empty;
		DupeKey = string.Empty;
	}
}
