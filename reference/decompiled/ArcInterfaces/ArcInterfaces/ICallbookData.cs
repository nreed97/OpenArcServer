namespace ArcInterfaces;

public interface ICallbookData
{
	string Call { get; set; }

	string FirstName { get; set; }

	string MiddleName { get; set; }

	string LastName { get; set; }

	string Address { get; set; }

	string City { get; set; }

	string State { get; set; }

	string Zip { get; set; }

	string LicenseClass { get; set; }

	string LicenseIssueDate { get; set; }

	string LicenseExpirationDate { get; set; }
}
