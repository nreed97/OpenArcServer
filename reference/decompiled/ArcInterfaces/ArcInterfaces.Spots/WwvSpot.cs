using System;

namespace ArcInterfaces.Spots;

[Serializable]
public sealed class WwvSpot
{
	public string Sfi { get; set; }

	public string A { get; set; }

	public string K { get; set; }

	public string Forecast { get; set; }

	public string Spotter { get; set; }

	public string SpotterNode { get; set; }

	public string Route { get; set; }

	public string DupeKey { get; set; }

	public DateTime Dts { get; set; }

	public bool IsDupe { get; set; }

	public WwvSpot()
	{
		Sfi = string.Empty;
		A = string.Empty;
		K = string.Empty;
		Forecast = string.Empty;
		Spotter = string.Empty;
		SpotterNode = string.Empty;
		Route = string.Empty;
		DupeKey = string.Empty;
	}

	public WwvSpot(string sfi, string a, string k, string forecast, string spotter, string spotterNode, string route, string dupeKey, DateTime dts)
	{
		Sfi = sfi;
		A = a;
		K = k;
		Forecast = forecast;
		Spotter = spotter;
		SpotterNode = spotterNode;
		Route = route;
		DupeKey = dupeKey;
		Dts = dts;
	}
}
