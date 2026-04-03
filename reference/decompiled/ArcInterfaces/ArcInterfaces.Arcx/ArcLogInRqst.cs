using System;

namespace ArcInterfaces.Arcx;

[Serializable]
public sealed class ArcLogInRqst
{
	public string Call { get; set; }

	public string Message { get; set; }

	public string Type { get; set; }

	public ArcLogInRqst()
	{
	}

	public ArcLogInRqst(string call, string msg, string type)
	{
		Call = call;
		Message = msg;
		Type = type;
	}
}
