using System.ComponentModel;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating.Mail;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ConnectBlockCacheCfg
{
	private bool Ⴃ;

	private string Ⴄ;

	private SetDxFilterHelp.Ⴈ Ⴗ = new SetDxFilterHelp.Ⴈ();

	[Description("Flag to automatically update from the web every day")]
	public bool AutoDownload
	{
		get
		{
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	[Description("Flag to automatically reload the cache when the source text file changes")]
	public bool AutoReload
	{
		get
		{
			return Ⴗ.Ⴐ;
		}
		set
		{
			bool ⴐ = value;
			Ⴗ.Ⴐ = ⴐ;
			DirectoryBulletin.ႠႨ[106] = DirectoryBulletin.ႠႨ[106] & DirectoryBulletin.ႠႨ[23] & 0x6B;
		}
	}

	[Description("Download url")]
	public string Url
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

	public ConnectBlockCacheCfg()
	{
		AutoDownload = true;
		AutoReload = true;
		Url = CallBlockCacheCfg.Ⴅ(null, 6, 62062555, null);
	}

	public override string ToString()
	{
		string result = CallBlockCacheCfg.Ⴅ(null, 2, 62062570, null);
		SetAnnChatRooms.Ⴀ[141] = (char)((SetAnnChatRooms.Ⴀ[141] - IpLockoutCacheCfg.ႭႭ[269]) & 0xE7);
		return result;
	}
}
