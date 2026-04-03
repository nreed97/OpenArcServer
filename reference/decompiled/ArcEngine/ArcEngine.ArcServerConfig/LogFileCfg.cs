using System.ComponentModel;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;

namespace ArcEngine.ArcServerConfig;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class LogFileCfg
{
	private SetStationQthHelp.Ⴈ Ⴅ = new SetStationQthHelp.Ⴈ();

	[Description("Days to keep the log files.  They will be automatically purged if older than this")]
	public int DaysToKeep
	{
		get
		{
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			return Ⴅ.Ⴍ;
		}
		set
		{
			Ⴅ.Ⴍ = value;
		}
	}

	public LogFileCfg()
	{
		DaysToKeep = 10;
	}

	public override string ToString()
	{
		return SetTalkCount.Ⴗ(2, null, 1267017598, typeof(ShowWwvOptionsHelp));
	}
}
