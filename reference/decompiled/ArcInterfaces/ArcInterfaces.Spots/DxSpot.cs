using System;

namespace ArcInterfaces.Spots;

[Serializable]
public sealed class DxSpot
{
	public int Id { get; set; }

	public string Call { get; set; }

	public string Spotter { get; set; }

	public string SpotterNode { get; set; }

	public string Cty { get; set; }

	public string SpotterCty { get; set; }

	public string State { get; set; }

	public string SpotterState { get; set; }

	public string Cont { get; set; }

	public string SpotterCont { get; set; }

	public string Name { get; set; }

	public string Comment { get; set; }

	public string County { get; set; }

	public string ArrlSection { get; set; }

	public string Mode { get; set; }

	public string Grid { get; set; }

	public string DupeKey { get; set; }

	public string Route { get; set; }

	public byte CqZone { get; set; }

	public byte SpotterCqZone { get; set; }

	public byte ItuZone { get; set; }

	public byte SpotterItuZone { get; set; }

	public byte SkimWpm { get; set; }

	public byte SkimDb { get; set; }

	public byte Unique { get; set; }

	public float Band { get; set; }

	public float Freq { get; set; }

	public float SkimFreqQsyPercent { get; set; }

	public bool Lotw { get; set; }

	public bool Bob { get; set; }

	public bool Cq { get; set; }

	public bool Master { get; set; }

	public bool InCb { get; set; }

	public bool Skimmer { get; set; }

	public bool SkimCq { get; set; }

	public bool SkimDupe { get; set; }

	public bool Top100 { get; set; }

	public bool Ham { get; set; }

	public bool Foc { get; set; }

	public bool IsDupe { get; set; }

	public bool IsSkimUnknown { get; set; }

	public bool IsSkimValid { get; set; }

	public bool IsSkimQsy { get; set; }

	public bool IsSkimBusted { get; set; }

	public int SkimCtyCnt { get; set; }

	public string SkimQualityFlag { get; set; }

	public bool Buddy { get; set; }

	public bool Atno { get; set; }

	public bool BndMode { get; set; }

	public DateTime Dts { get; set; }

	public DateTime DtsRx { get; set; }

	public DxSpot()
	{
		Call = string.Empty;
		Spotter = string.Empty;
		SpotterNode = string.Empty;
		Cty = string.Empty;
		SpotterCty = string.Empty;
		State = string.Empty;
		Cont = string.Empty;
		SpotterCont = string.Empty;
		SpotterState = string.Empty;
		Name = string.Empty;
		Comment = string.Empty;
		County = string.Empty;
		ArrlSection = string.Empty;
		Mode = string.Empty;
		DupeKey = string.Empty;
		Route = string.Empty;
	}

	public override string ToString()
	{
		return Call + " " + Spotter + " " + Freq + " " + Dts;
	}
}
