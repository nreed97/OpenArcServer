using System;
using System.Runtime.CompilerServices;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;

namespace ArcEngine.ArcCaches;

public class SkimDupeDat
{
	private DateTime Ⴄ;

	private float Ⴄ;

	[SpecialName]
	internal DateTime Ⴍ()
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		DateTime ⴄ = this.Ⴄ;
		SetTalkCountHelp.Ⴅ[402] = (byte)((SetTalkCountHelp.Ⴅ[402] | SetTalkCountHelp.Ⴅ[2]) & 0xF2);
		return ⴄ;
	}

	[SpecialName]
	internal void Ⴀ(DateTime P_0)
	{
		this.Ⴄ = P_0;
	}

	[SpecialName]
	internal float Ⴀ()
	{
		return Ⴄ;
	}

	[SpecialName]
	internal void Ⴅ(float P_0)
	{
		Ⴄ = P_0;
	}

	internal SkimDupeDat(DateTime P_0, float P_1)
	{
		Ⴀ(P_0);
		Ⴅ(P_1);
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, char P_3) where _0021_00210 : DxCommentExtCfg
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_3 ^ P_2) - 26) ^ num2) switch
				{
					0 => ⴃႠ[75] - 14923, 
					_ => ⴀ[257] - 37061, 
				};
				break;
			case 5:
				num = 6;
				break;
			case 7:
			case 9:
				P_0.State = P_1;
				goto case 1;
			case 1:
			case 6:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 2 : 3);
				break;
			case 3:
				num = 4;
				break;
			case 2:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DxCommentExtCfg
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
					break;
				case 8:
					num2 = (((P_1 ^ P_2) - 87) ^ num) switch
					{
						0 => 9, 
						_ => 6, 
					};
					continue;
				case 6:
					result = false;
					num2 = 7;
					continue;
				case 9:
				case 10:
					result = P_0.Name;
					num2 = 7;
					continue;
				case 3:
				case 7:
					num++;
					goto case 4;
				case 4:
				{
					int num3 = 1788;
					int num4 = 268;
					num2 = ((894 < num3 / 2 - num4) ? ⴅ[210] : 0);
					continue;
				}
				case 0:
					return result;
				case 1:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static NeedsCfg Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DxCfg
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[290] - 15310;
					continue;
				case 6:
					break;
				case 5:
				{
					int num3 = (P_2 ^ P_1) - 62;
					int num4 = num;
					ShowQrzHelp.ႤႤ[230] = (byte)((ShowQrzHelp.ႤႤ[230] * IpLockoutCacheCfg.ႭႭ[280]) & 0x5A);
					num2 = (num3 ^ num4) switch
					{
						0 => ⴃႠ[10] - 41654, 
						_ => 11, 
					};
					continue;
				}
				case 11:
					obj = null;
					num2 = ⴀ[42] - ⴀ[296];
					continue;
				case 1:
					obj = P_0.Needs;
					num2 = 10;
					continue;
				case 9:
				case 10:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 3 : (ⴃႠ[82] - ⴃႠ[82]));
					continue;
				case 0:
					num2 = 5;
					continue;
				case 3:
				case 7:
					return (NeedsCfg)obj;
				case 2:
				case 8:
					num2 = ⴀႣ[294] - 59101;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : string where _0021_00211 : OnIoClientConnectEventHandler
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				break;
			case 2:
				num = (((P_2 ^ P_3) - 45) ^ num2) switch
				{
					0 => ⴃႥ[11] - 1995, 
					_ => 9, 
				};
				break;
			case 9:
				num = ⴍႤ[417] - 41796;
				break;
			case 0:
			case 5:
				P_0(P_1);
				goto case 3;
			case 3:
			case 8:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴄႤ[278] - 28) : 7);
				break;
			case 7:
				num = 2;
				break;
			case 1:
			case 4:
				return;
			}
		}
	}
}
