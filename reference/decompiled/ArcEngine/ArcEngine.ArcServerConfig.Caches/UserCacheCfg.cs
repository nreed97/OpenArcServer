using System.ComponentModel;
using System.Diagnostics;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcInterfaces.Spots;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class UserCacheCfg
{
	private SetStationQthHelp.Ⴈ m_Ⴃ = new SetStationQthHelp.Ⴈ();

	[Description("Number of years of data to keep in the database after purge operations")]
	public int DbYears
	{
		get
		{
			byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
			int ⴍ = this.m_Ⴃ.Ⴍ;
			Arc4ServerClient.ႠႣ[116] = (char)((Arc4ServerClient.ႠႣ[116] - Arc4ServerClient.ႠႣ[84]) & 0xB6);
			return ⴍ;
		}
		set
		{
			this.m_Ⴃ.Ⴍ = value;
		}
	}

	public UserCacheCfg()
	{
		DbYears = 3;
	}

	public override string ToString()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		return SetTalkCount.Ⴗ(8, null, 1267017577, typeof(ChatRoomPvtCache));
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႰ[177] - 20350;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
					break;
				case 10:
					num2 = (((P_2 ^ P_1) - 107) ^ num) switch
					{
						0 => 7, 
						_ => 1, 
					};
					continue;
				case 1:
					obj = null;
					goto case 4;
				case 4:
					num2 = 8;
					continue;
				case 7:
					obj = P_0.ToString();
					num2 = 8;
					continue;
				case 8:
				{
					num++;
					int num3 = 410;
					int num4 = 698;
					num2 = ((4188 > num4 - num3 * 6) ? 9 : 5);
					continue;
				}
				case 5:
					num2 = 10;
					continue;
				case 2:
				case 9:
				case 11:
					return (string)obj;
				case 3:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, byte P_1, short P_2, int P_3) where _0021_00210 : DxSpot
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴍႭ[331] - 20126;
				break;
			case 7:
			case 9:
				num = (((P_2 ^ P_3) - 125) ^ num2) switch
				{
					0 => 0, 
					_ => 5, 
				};
				break;
			case 5:
				num = ⴀႨ[82] - 5764;
				break;
			case 0:
				P_0.SpotterItuZone = P_1;
				goto case 3;
			case 3:
			case 8:
				num2++;
				goto case 2;
			case 2:
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 4 : (ⴄႤ[131] - 196));
				break;
			case 6:
				num = 7;
				break;
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long Ⴀ<_0021_00210>(_0021_00210 P_0, long P_1, char P_2, int P_3) where _0021_00210 : PerformanceCounter
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		long result = default(long);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[358] - 50454;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
					break;
				case 2:
				case 5:
					num2 = (((P_3 ^ P_2) - 62) ^ num) switch
					{
						0 => 6, 
						_ => ⴃႥ[215] - 7500, 
					};
					continue;
				case 9:
					result = P_1;
					num2 = 4;
					continue;
				case 6:
					result = P_0.IncrementBy(P_1);
					num2 = 4;
					continue;
				case 4:
				{
					num++;
					int num3 = 238;
					int num4 = 27;
					num2 = ((119 < num3 / 2 - num4) ? 5 : 8);
					continue;
				}
				case 1:
				case 8:
					return result;
				case 0:
				case 10:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}
}
