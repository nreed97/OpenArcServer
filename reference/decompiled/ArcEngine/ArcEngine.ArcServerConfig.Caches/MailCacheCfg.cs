using System.ComponentModel;
using System.Security;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class MailCacheCfg
{
	internal sealed class Ⴄ
	{
		internal bool Ⴓ;

		internal bool Ⴗ;

		internal string Ⴄ;

		internal Ⴄ()
		{
		}
	}

	private bool Ⴍ;

	private int Ⴐ;

	[Description("Flag to activate the automatic compacting of the database")]
	public bool AutoDbCompact
	{
		get
		{
			return Ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	[Description("Number of months of data to keep in the database after purge operations")]
	public int DbMonths
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			return Ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	public MailCacheCfg()
	{
		AutoDbCompact = true;
		DbMonths = 1;
	}

	public override string ToString()
	{
		return ReplyMailHelp.Ⴄ(13, null, 1057164401, 4);
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : DxSpot
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႳ[152] - 25343;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 1;
					continue;
				case 1:
					break;
				case 6:
					num2 = (((P_1 ^ P_2) - 113) ^ num) switch
					{
						0 => ⴃႰ[52] - ⴃႰ[52], 
						1 => 14, 
						2 => 11, 
						3 => 5, 
						_ => ⴀ[376] - 10264, 
					};
					continue;
				case 2:
					obj = null;
					num2 = ⴀႳ[135] - 41055;
					continue;
				case 0:
					obj = P_0.Cont;
					num2 = ⴃႠ[56] - 20632;
					continue;
				case 14:
					obj = P_0.State;
					num2 = 7;
					continue;
				case 3:
				case 11:
					obj = P_0.ArrlSection;
					num2 = 7;
					continue;
				case 5:
					obj = P_0.County;
					num2 = ⴃႰ[13] - 37061;
					continue;
				case 7:
				case 8:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႥ[17] - 43332) : 12);
					continue;
				case 12:
					num2 = 6;
					continue;
				case 9:
				case 10:
					return (string)obj;
				case 13:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, short P_3) where _0021_00210 : TalkCfg
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 2;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				break;
			case 4:
			case 5:
				num = (((P_2 ^ P_3) - 49) ^ num2) switch
				{
					0 => 0, 
					_ => 8, 
				};
				break;
			case 8:
			{
				byte num5 = ⴀႼ[0];
				ShowWwvOptionsHelp.ႣႥ[178] = (char)((ShowWwvOptionsHelp.ႣႥ[178] * P_3) & 0x7B);
				num = num5 / 7;
				break;
			}
			case 0:
				P_0.NmbrSpots = P_1;
				goto case 7;
			case 7:
				num2++;
				num3 = 233;
				num4 = 391;
				goto case 3;
			case 3:
				num = ((2737 > num4 - num3 * 7) ? 9 : (ⴀႣ[168] - 41411));
				break;
			case 1:
				num = ⴀႳ[302] - 61681;
				break;
			case 6:
			case 9:
				return;
			}
		}
	}
}
