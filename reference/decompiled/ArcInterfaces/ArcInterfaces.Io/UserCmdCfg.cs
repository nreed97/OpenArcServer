namespace ArcInterfaces.Io;

public sealed class UserCmdCfg
{
	public string Definition { get; set; }

	public string ClassName { get; set; }

	public UserCmdCfg()
	{
	}

	public UserCmdCfg(string definition, string codeName)
	{
		Definition = definition;
		ClassName = codeName;
	}
}
