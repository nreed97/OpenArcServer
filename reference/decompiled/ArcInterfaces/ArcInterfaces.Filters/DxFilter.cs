using System;

namespace ArcInterfaces.Filters;

[Serializable]
public sealed class DxFilter
{
	public Guid ID { get; set; }

	public string Name { get; set; }

	public string Filter { get; set; }

	public DxFilter()
	{
		ID = Guid.NewGuid();
		Name = string.Empty;
		Filter = string.Empty;
	}

	public DxFilter(string name, string filter)
	{
		ID = Guid.NewGuid();
		Name = name;
		Filter = filter;
	}
}
