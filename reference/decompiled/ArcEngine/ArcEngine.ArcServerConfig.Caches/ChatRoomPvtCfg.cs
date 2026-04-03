using System.ComponentModel;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.ReverseBeacon;
using ArcInterfaces.Spots;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ChatRoomPvtCfg
{
	internal sealed class Ⴀ
	{
		internal RevBcnSpot[] Ⴗ;

		internal Ⴀ()
		{
		}
	}

	internal sealed class Ⴓ
	{
		internal int Ⴃ;

		internal int Ⴅ;

		internal Ⴓ()
		{
		}
	}

	private bool Ⴃ;

	[Description("Flag to automatically reload the cache when the source text file changes")]
	public bool AutoReload
	{
		get
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	public ChatRoomPvtCfg()
	{
		AutoReload = true;
	}

	public override string ToString()
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		return SetTalkCount.Ⴗ(6, null, 1267022462, typeof(ChatRoomPvtCache));
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string where _0021_00211 : AnnWxSpot
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 3;
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = 6;
				continue;
			case 6:
			{
				int num2 = (P_2 ^ P_3) - 8;
				int num3 = num4;
				BandModeCacheCfg.ႠႳ[166] = (char)((BandModeCacheCfg.ႠႳ[166] - P_2) & 0x5A);
				num = (num2 ^ num3) switch
				{
					0 => ⴀႨ[39] - 33478, 
					_ => 7, 
				};
				continue;
			}
			case 7:
				num = 8;
				continue;
			case 1:
			case 4:
				P_0.Msg = P_1;
				break;
			case 8:
				break;
			case 2:
			case 5:
				return;
			}
			num4++;
			int num5 = 1696;
			int num6 = 96;
			num = ((424 < num5 / 4 - num6) ? 6 : (ⴃႠ[385] - 29502));
		}
	}
}
