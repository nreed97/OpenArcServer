using System;

namespace ArcInterfaces.Filters;

[Serializable]
public sealed class AnnFilter
{
	public Guid ID { get; set; }

	public string Name { get; set; }

	public string Filter { get; set; }

	public AnnFilter()
	{
		ID = Guid.NewGuid();
		Name = string.Empty;
		Filter = string.Empty;
	}

	public AnnFilter(string name, string filter)
	{
		ID = Guid.NewGuid();
		Name = name;
		Filter = filter;
	}
}
