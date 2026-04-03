using System.Collections.Generic;

namespace ArcInterfaces;

public sealed class CallbookData : ICallbookData
{
	public string Call { get; set; }

	public string FirstName { get; set; }

	public string MiddleName { get; set; }

	public string LastName { get; set; }

	public string Address { get; set; }

	public string City { get; set; }

	public string State { get; set; }

	public string Zip { get; set; }

	public string LicenseClass { get; set; }

	public string LicenseIssueDate { get; set; }

	public string LicenseExpirationDate { get; set; }

	public string ArrlSection { get; set; }

	public string County { get; set; }

	public string Grid { get; set; }

	public float Lat { get; set; }

	public float Lon { get; set; }

	public CallbookData(string call, string firstName, string middleName, string lastName, string address, string city, string state, string zip, string licenseClass, string licenseIssueDate, string licenseExpirationDate)
	{
		Call = call;
		FirstName = ScrubLine(firstName);
		MiddleName = middleName;
		LastName = ScrubLine(lastName);
		Address = ScrubLine(address);
		Address = Address.Replace("Po Box", "PO Box");
		City = ScrubLine(city);
		State = state;
		Zip = zip;
		LicenseClass = licenseClass;
		LicenseIssueDate = licenseIssueDate;
		LicenseExpirationDate = licenseExpirationDate;
		ArrlSection = string.Empty;
		County = string.Empty;
	}

	public CallbookData(string call, string firstName, string lastName, string address, string city, string state, string zip)
	{
		Call = call;
		FirstName = firstName;
		LastName = lastName;
		Address = address;
		City = city;
		State = state;
		Zip = zip;
		MiddleName = string.Empty;
		LicenseClass = string.Empty;
		LicenseIssueDate = string.Empty;
		LicenseExpirationDate = string.Empty;
		ArrlSection = string.Empty;
		County = string.Empty;
	}

	public List<string> GetFullDescription()
	{
		List<string> list = new List<string>();
		list.Add("Call: " + Call + "  Class:" + LicenseClass + " Expires:" + LicenseExpirationDate);
		list.Add(FirstName + ' ' + MiddleName + ' ' + LastName + ", " + Address + ", " + City + ", " + State + ", " + Zip);
		return list;
	}

	private string ScrubLine(string val)
	{
		string text = string.Empty;
		val = val.Replace("  ", " ");
		val = val.Replace("  ", " ");
		val = val.Replace("  ", " ");
		string[] array = val.Split(' ');
		for (int i = 0; i < array.Length; i++)
		{
			text = text + ForceCase(array[i]) + " ";
		}
		return text.Trim();
	}

	internal string ForceCase(string val)
	{
		if (val.Length > 1)
		{
			return val.Substring(0, 1).ToUpper() + val.Substring(1).ToLower();
		}
		return val.ToUpper();
	}
}
