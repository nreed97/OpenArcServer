using System.ComponentModel;
using ArcEngine.ArcCmds.User.Operating.Mail;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class WwvCacheCfg
{
	private int Ⴄ;

	private int Ⴀ;

	[Description("Number of days of data to keep in the database after purge operations")]
	public int DbDaysToKeep
	{
		get
		{
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	[Description("Days of data to keep in the memory cache")]
	public int CacheDays
	{
		get
		{
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	public WwvCacheCfg()
	{
		DbDaysToKeep = 90;
		CacheDays = 30;
	}

	public override string ToString()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		return ReplyMailHelp.Ⴄ(12, null, 1057166231, 3);
	}
}
