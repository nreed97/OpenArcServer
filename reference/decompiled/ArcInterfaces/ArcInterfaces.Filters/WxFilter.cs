using System;

namespace ArcInterfaces.Filters;

[Serializable]
public sealed class WxFilter
{
	public Guid ID { get; set; }

	public string Name { get; set; }

	public string Filter { get; set; }

	public WxFilter()
	{
		ID = Guid.NewGuid();
		Name = string.Empty;
		Filter = string.Empty;
	}

	public WxFilter(string name, string filter)
	{
		ID = Guid.NewGuid();
		Name = name;
		Filter = filter;
	}
}
