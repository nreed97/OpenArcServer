using System;

namespace ArcInterfaces.Arcx;

[Serializable]
public sealed class ArcLogInResp
{
	public string Call { get; set; }

	public string Alias { get; set; }

	public string Message { get; set; }

	public string Type { get; set; }

	public ArcLogInResp()
	{
	}

	public ArcLogInResp(string call, string alias, string msg, string type)
	{
		Call = call;
		Alias = alias;
		Message = msg;
		Type = type;
	}
}
