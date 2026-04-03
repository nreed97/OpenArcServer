using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Security;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class MasterCallCacheCfg
{
	private MailCacheCfg.Ⴄ Ⴓ = new MailCacheCfg.Ⴄ();

	[Description("Flag to automatically update from the web every day")]
	public bool AutoDownload
	{
		get
		{
			return Ⴓ.Ⴓ;
		}
		set
		{
			bool ⴓ = value;
			Ⴓ.Ⴓ = ⴓ;
		}
	}

	[Description("Flag to automatically reload the cache when the source text file changes")]
	public bool AutoReload
	{
		get
		{
			byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
			return Ⴓ.Ⴗ;
		}
		set
		{
			bool ⴗ = value;
			Ⴓ.Ⴗ = ⴗ;
		}
	}

	[Description("Download url")]
	public string Url
	{
		get
		{
			return Ⴓ.Ⴄ;
		}
		set
		{
			Ⴓ.Ⴄ = value as string;
		}
	}

	public MasterCallCacheCfg()
	{
		AutoDownload = true;
		AutoReload = true;
		Url = CallBlockCacheCfg.Ⴅ(null, 7, 62062510, null);
	}

	public override string ToString()
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		return CallBlockCacheCfg.Ⴅ(null, 0, 62060671, null);
	}

	[SecuritySafeCritical]
	internal static ConnectionState Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DbConnection
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		ConnectionState result = default(ConnectionState);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႤ[164] - 80;
					continue;
				case 9:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 49) ^ num) switch
					{
						0 => ⴄႤ[180] - 24, 
						_ => 8, 
					};
					continue;
				case 8:
					result = ConnectionState.Closed;
					num2 = ⴄႤ[208] - 89;
					continue;
				case 6:
				case 11:
					result = P_0.State;
					num2 = 7;
					continue;
				case 7:
				{
					num++;
					num4 = 1426;
					int num5 = num4;
					num3 = num5 * num5;
					num2 = ⴀႳ[66] - 4074;
					continue;
				}
				case 4:
					num3 = num4 + num3;
					num2 = ((num3 % 2 != 0) ? (ⴄႤ[349] - ⴄႤ[17]) : (ⴐ[212] - 8));
					continue;
				case 5:
					return result;
				case 2:
				case 10:
					num2 = ⴀႨ[99] - 1057;
					continue;
				}
				break;
			}
		}
	}
}
