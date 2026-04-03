namespace ArcInterfaces;

public sealed class CallbookExtensionDat
{
	public string Zip { get; set; }

	public string ArrlSection { get; set; }

	public string County { get; set; }

	public string GridSquare { get; set; }

	public float Lat { get; set; }

	public float Lon { get; set; }

	public CallbookExtensionDat()
	{
	}

	public CallbookExtensionDat(string line)
	{
		string[] array = line.Split(',');
		if (array.Length > 2)
		{
			Zip = array[0];
			ArrlSection = array[1];
			County = array[2];
			GridSquare = array[3];
			Lat = 0f;
			Lon = 0f;
		}
	}
}
