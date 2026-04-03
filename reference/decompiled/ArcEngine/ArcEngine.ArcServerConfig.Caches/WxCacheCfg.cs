using System.ComponentModel;
using System.Diagnostics;
using System.Security;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class WxCacheCfg
{
	private int Ⴓ;

	private SetStationQthHelp.Ⴈ Ⴀ = new SetStationQthHelp.Ⴈ();

	[Description("Number of days of data to keep in the database after purge operations")]
	public int DbDaysToKeep
	{
		get
		{
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			return Ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	[Description("Minutes of data to keep in the memory cache")]
	public int CacheMinutes
	{
		get
		{
			int ⴍ = Ⴀ.Ⴍ;
			Arc4ServerClient.ႠႣ[298] = (char)((Arc4ServerClient.ႠႣ[298] - Arc4ServerClient.ႠႣ[391]) & 0x2A);
			return ⴍ;
		}
		set
		{
			Ⴀ.Ⴍ = value;
		}
	}

	public WxCacheCfg()
	{
		CacheMinutes = 30;
		DbDaysToKeep = 30;
	}

	public override string ToString()
	{
		return ReplyMailHelp.Ⴄ(30, null, 1057166217, 6);
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : string where _0021_00211 : PerformanceCounter
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႠ[426] - 16010;
				break;
			case 3:
			case 5:
			{
				int num3 = P_2 ^ P_3;
				DirectoryBulletin.ႠႨ[88] = (DirectoryBulletin.ႠႨ[88] ^ ShowSunHelp.ႣႠ[393]) & 0x57;
				num = ((num3 - 116) ^ num2) switch
				{
					0 => 6, 
					_ => ⴀႳ[227] - 26064, 
				};
				break;
			}
			case 4:
			case 9:
				num = ⴀႼ[80];
				break;
			case 6:
				P_0.CounterName = P_1;
				goto case 0;
			case 0:
				num2++;
				goto case 7;
			case 7:
				num = (((P_2 * P_2 + P_2) % 2 != 0) ? 1 : (ⴃႰ[50] - 2564));
				break;
			case 1:
				num = 5;
				break;
			case 8:
				return;
			}
		}
	}
}
