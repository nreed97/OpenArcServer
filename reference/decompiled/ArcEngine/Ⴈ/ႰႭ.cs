using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;

namespace Ⴈ;

internal sealed class ႰႭ
{
	private string m_Ⴍ;

	private string m_Ⴐ;

	private string m_Ⴄ;

	[SpecialName]
	internal string Ⴍ()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		return this.m_Ⴍ;
	}

	[SpecialName]
	internal void Ⴐ(string P_0)
	{
		this.m_Ⴍ = P_0;
	}

	[SpecialName]
	internal string Ⴅ()
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		return this.m_Ⴐ;
	}

	[SpecialName]
	internal void Ⴓ(string P_0)
	{
		this.m_Ⴐ = P_0;
	}

	[SpecialName]
	internal string Ⴄ()
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		return this.m_Ⴄ;
	}

	[SpecialName]
	internal void Ⴍ(string P_0)
	{
		this.m_Ⴄ = P_0;
	}

	[SecuritySafeCritical]
	internal static byte[] Ⴀ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, short P_3) where _0021_00210 : string where _0021_00211 : Encoding
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		Array array = default(Array);
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
					num2 = ⴍႤ[314] - 34777;
					continue;
				case 0:
					break;
				case 3:
					num2 = (((P_3 ^ P_2) - 84) ^ num) switch
					{
						0 => ⴀႳ[119] - 55418, 
						_ => 9, 
					};
					continue;
				case 9:
					array = null;
					goto case 11;
				case 11:
					num2 = 1;
					continue;
				case 8:
					array = P_0.GetBytes(P_1);
					num2 = ⴍႤ[281] - 58267;
					continue;
				case 1:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? ⴄႭ[31] : 5);
					continue;
				case 5:
				case 7:
					num2 = 3;
					continue;
				case 6:
				case 10:
					return array as byte[];
				case 4:
					num2 = ⴃႠ[292] - 56622;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : Stream
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႨ[176] - 915;
				break;
			case 3:
			{
				int num4;
				switch (((P_1 ^ P_2) - 81) ^ num2)
				{
				default:
					num4 = ⴅ[51] - 179;
					break;
				case 0:
				{
					int num3 = ⴍႤ[99];
					SetTalkCountHelp.Ⴅ[106] = (byte)((SetTalkCountHelp.Ⴅ[106] | SetTalkCountHelp.Ⴅ[164]) & 0x29);
					num4 = num3 - 21279;
					break;
				}
				}
				num = num4;
				break;
			}
			case 9:
				num = ⴄႭ[484] - 11;
				break;
			case 8:
				P_0.Close();
				goto case 1;
			case 1:
			case 5:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴀႨ[6] - 30084) : 4);
				break;
			case 0:
			case 4:
				num = ⴍႭ[354] - 45586;
				break;
			case 2:
			case 6:
				return;
			}
		}
	}
}
