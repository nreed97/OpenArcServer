using System.Collections;
using System.ComponentModel;
using ArcEngine.ArcCmds.User.Operating.Mail;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class CtyCacheCfg
{
	internal sealed class Ⴓ
	{
		internal Hashtable Ⴈ;

		internal Ⴓ()
		{
		}
	}

	private MailCacheCfg.Ⴄ Ⴗ = new MailCacheCfg.Ⴄ();

	[Description("Flag to automatically update from the web every day")]
	public bool AutoDownload
	{
		get
		{
			return Ⴗ.Ⴓ;
		}
		set
		{
			bool ⴓ = value;
			Ⴗ.Ⴓ = ⴓ;
		}
	}

	[Description("Flag to automatically reload the cache when the source text file changes")]
	public bool AutoReload
	{
		get
		{
			int[] ⴀႨ = DirectoryBulletin.ႠႨ;
			return Ⴗ.Ⴗ;
		}
		set
		{
			bool ⴗ = value;
			Ⴗ.Ⴗ = ⴗ;
		}
	}

	[Description("Download url")]
	public string Url
	{
		get
		{
			return Ⴗ.Ⴄ;
		}
		set
		{
			Ⴗ.Ⴄ = value as string;
		}
	}

	public CtyCacheCfg()
	{
		AutoDownload = true;
		AutoReload = true;
		Url = CallBlockCacheCfg.Ⴅ(null, 5, 62054792, null);
	}

	public override string ToString()
	{
		return CallBlockCacheCfg.Ⴅ(null, 1, 62055006, null);
	}
}
