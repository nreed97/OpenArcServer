namespace ArcInterfaces.Spots;

public sealed class DxSpotRate
{
	public string Call { get; set; }

	public double[] DxRate { get; set; }

	public DxSpotRate(string call, double[] dxRate)
	{
		Call = call;
		DxRate = dxRate;
	}
}
