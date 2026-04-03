using System.ComponentModel;
using System.Data;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class CallbookCfg
{
	internal sealed class Ⴀ
	{
		internal DataSet Ⴐ;

		internal Ⴀ()
		{
		}
	}

	internal sealed class Ⴅ
	{
		internal ႨႷ Ⴅ;

		internal Ⴅ()
		{
		}
	}

	private string Ⴃ;

	private bool Ⴄ;

	private SkimmerServerData.Ⴜ m_Ⴀ;

	[Description("FCC download url")]
	public string FccUrl
	{
		get
		{
			byte[] ⴐ = ႨႣ.Ⴐ;
			return this.m_Ⴀ.Ⴍ;
		}
		set
		{
			this.m_Ⴀ.Ⴍ = value as string;
			SetAnnMode.ႤႭ[341] = (byte)(SetAnnMode.ႤႭ[341] & SetAnnMode.ႤႭ[37] & 0xF8);
		}
	}

	[Description("VE download url")]
	public string VeUrl
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

	[Description("Automatically built ARC4 callbook")]
	public bool BuildArc4Callbook
	{
		get
		{
			char[] ⴃႰ = SetWxOutput.ႣႰ;
			bool ⴄ = Ⴄ;
			BandModeCacheCfg.ႠႳ[314] = (char)((BandModeCacheCfg.ႠႳ[314] | BandModeCacheCfg.ႠႳ[275]) & 0xC0);
			return ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	public CallbookCfg()
	{
		FccUrl = SetStationClubHelp.Ⴍ(13, 2, 1747257409, null);
		VeUrl = SetTalkCount.Ⴗ(5, null, 1267023266, typeof(DirectoryOwn));
		BuildArc4Callbook = false;
	}

	public override string ToString()
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		return CallBlockCacheCfg.Ⴅ(null, 4, 62057175, null);
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, char P_3) where _0021_00210 : WwvSpot
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 5;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				continue;
			case 2:
				num = (((P_3 ^ P_2) - 113) ^ num2) switch
				{
					0 => 0, 
					_ => ⴍႤ[347] - 1868, 
				};
				continue;
			case 6:
				num = ⴃႰ[208] - 13315;
				continue;
			case 0:
			case 1:
				P_0.IsDupe = P_1;
				goto case 7;
			case 7:
			case 8:
				num2++;
				num3 = 520;
				num4 = 246;
				break;
			case 4:
				break;
			case 3:
				return;
			}
			num = ((260 < num3 / 2 - num4) ? (ⴐ[80] / 7) : 3);
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, short P_3) where _0021_00210 : string where _0021_00211 : Letter
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 1;
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 0;
				continue;
			case 0:
				num = (((P_3 ^ P_2) - 56) ^ num3) switch
				{
					0 => ⴐ[204], 
					_ => 3, 
				};
				continue;
			case 3:
				num = 4;
				continue;
			case 6:
				P_0.Subject = P_1;
				goto case 4;
			case 4:
			{
				int num2 = num3;
				DirectoryBulletin.ႠႨ[200] = (DirectoryBulletin.ႠႨ[200] + P_3) & 0xD2;
				num3 = num2 + 1;
				break;
			}
			case 7:
				break;
			case 2:
			case 8:
				return;
			}
			int num4 = 838;
			int num5 = 283;
			num = ((419 >= num4 / 2 - num5) ? 8 : 0);
		}
	}
}
