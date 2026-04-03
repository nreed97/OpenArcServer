using System.ComponentModel;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcServerConfig;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class UserLoginRegistrationCfg
{
	private bool Ⴄ;

	private bool Ⴃ;

	private bool Ⴐ;

	private DxSpotUserHelp.Ⴈ m_Ⴍ = new DxSpotUserHelp.Ⴈ();

	[Description("When a user logs in request a email address if none is set")]
	public bool RequestEmail
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

	[Description("When a user logs in request a homenode if none is set")]
	public bool RequestHomeNode
	{
		get
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			bool ⴃ = this.m_Ⴍ.Ⴃ;
			ShowQrzHelp.ႤႤ[460] = (byte)((ShowQrzHelp.ႤႤ[460] + ShowQrzHelp.ႤႤ[228]) & 0x14);
			return ⴃ;
		}
		set
		{
			bool ⴃ = value;
			this.m_Ⴍ.Ⴃ = ⴃ;
		}
	}

	[Description("When a user logs in request his Lat/Lon if none is set")]
	public bool RequestLatLon
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			return this.m_Ⴍ.Ⴄ;
		}
		set
		{
			bool ⴄ = value;
			this.m_Ⴍ.Ⴄ = ⴄ;
		}
	}

	[Description("When a user logs in request a name if none is set")]
	public bool RequestName
	{
		get
		{
			byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	[Description("When a user logs in request a phone number if none is set")]
	public bool RequestPhone
	{
		get
		{
			char[] ⴀ = SetAnnChatRooms.Ⴀ;
			return Ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	[Description("When a user logs in request his QTH if none is set")]
	public bool RequestQth
	{
		get
		{
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			bool ⴗ = this.m_Ⴍ.Ⴗ;
			DirectoryBulletin.ႠႨ[19] = (DirectoryBulletin.ႠႨ[19] - DirectoryBulletin.ႠႨ[125]) & 0xEC;
			return ⴗ;
		}
		set
		{
			bool ⴗ = value;
			this.m_Ⴍ.Ⴗ = ⴗ;
		}
	}

	public override string ToString()
	{
		string result = SetTalkCount.Ⴗ(2, null, 1267017381, typeof(SetStationGridHelp));
		SetTalkCountHelp.Ⴅ[233] = (byte)((SetTalkCountHelp.Ⴅ[233] + SetTalkCountHelp.Ⴅ[192]) & 0x2C);
		return result;
	}

	public void LoadDefaults()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				RequestEmail = false;
				RequestHomeNode = false;
				goto case 4;
			case 4:
				RequestLatLon = false;
				RequestName = false;
				break;
			case 2:
				break;
			case 0:
			case 1:
				RequestPhone = false;
				RequestQth = false;
				return;
			}
			num = ⴀႼ[80];
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : ServerIoCfg
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 10:
					break;
				case 4:
					num2 = (((P_2 ^ P_1) - 114) ^ num) switch
					{
						0 => 8, 
						_ => ⴀႨ[33] - 62155, 
					};
					continue;
				case 1:
					result = false;
					num2 = 5;
					continue;
				case 7:
				case 8:
					result = P_0.Enabled;
					num2 = ⴐ[264] - 132;
					continue;
				case 5:
				case 11:
					num++;
					goto case 0;
				case 0:
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 2 : (ⴐ[270] - ⴐ[73]));
					continue;
				case 3:
					num2 = 4;
					continue;
				case 2:
					return result;
				case 6:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, short P_3) where _0021_00210 : DxCommentExtCfg
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႥ[153] - 24218;
				break;
			case 3:
				num = (((P_2 ^ P_3) - 9) ^ num2) switch
				{
					0 => ⴄႭ[422] - 223, 
					_ => ⴃႠ[105] - ⴃႠ[105], 
				};
				break;
			case 0:
				num = 9;
				break;
			case 1:
			case 7:
				P_0.Loc = P_1;
				goto case 4;
			case 4:
			case 9:
			{
				num2++;
				int num3 = 470;
				int num4 = 489;
				num = ((1467 > num4 - num3 * 3) ? 2 : (ⴀႨ[56] - 34616));
				break;
			}
			case 6:
			case 8:
				num = ⴀႼ[101] - 38;
				break;
			case 2:
				return;
			}
		}
	}
}
