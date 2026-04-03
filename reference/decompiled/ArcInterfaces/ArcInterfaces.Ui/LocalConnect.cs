using System;

namespace ArcInterfaces.Ui;

public sealed class LocalConnect
{
	public string Call { get; set; }

	public Guid Id { get; set; }

	public UiConnectType Type { get; set; }

	public LocalConnect(string call, Guid id, UiConnectType type)
	{
		Call = call;
		Id = id;
		Type = type;
	}
}
