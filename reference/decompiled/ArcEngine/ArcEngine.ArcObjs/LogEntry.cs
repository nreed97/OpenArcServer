using System;
using System.Runtime.CompilerServices;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcServerConfig.Io;
using ArcInterfaces;
using ArcInterfaces.Io;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcObjs;

public sealed class LogEntry
{
	private string m_Ⴈ;

	private IoDevicesCfg.Ⴈ m_Ⴍ = new IoDevicesCfg.Ⴈ();

	[SpecialName]
	internal string Ⴗ()
	{
		string ⴗ = this.m_Ⴍ.Ⴗ;
		SetAnnChatRooms.Ⴀ[365] = (char)((SetAnnChatRooms.Ⴀ[365] ^ SetAnnChatRooms.Ⴀ[360]) & 0xD0);
		return ⴗ;
	}

	[SpecialName]
	internal void Ⴗ(string P_0)
	{
		this.m_Ⴍ.Ⴗ = P_0 as string;
	}

	[SpecialName]
	internal string Ⴍ()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		return this.m_Ⴍ.Ⴍ;
	}

	[SpecialName]
	internal void Ⴍ(string P_0)
	{
		this.m_Ⴍ.Ⴍ = P_0;
	}

	[SpecialName]
	internal string Ⴈ()
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		return this.m_Ⴈ;
	}

	[SpecialName]
	internal void Ⴓ(string P_0)
	{
		this.m_Ⴈ = P_0;
	}

	[SpecialName]
	internal string Ⴃ()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		return this.m_Ⴍ.Ⴓ;
	}

	[SpecialName]
	internal void Ⴀ(string P_0)
	{
		this.m_Ⴍ.Ⴓ = P_0 as string;
	}

	[SpecialName]
	internal DateTime Ⴐ()
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		return this.m_Ⴍ.Ⴀ;
	}

	[SpecialName]
	internal void Ⴐ(DateTime P_0)
	{
		this.m_Ⴍ.Ⴀ = P_0;
		SetTalkCountHelp.Ⴅ[468] = (byte)((SetTalkCountHelp.Ⴅ[468] - SetTalkCountHelp.Ⴅ[66]) & 0xC2);
	}

	internal LogEntry(IIoDeviceCfg P_0, string P_1)
	{
		Ⴗ(P_0.ConnectTo);
		Ⴍ(P_0.Description);
		Ⴓ(P_1);
		Ⴀ(ShowPrefixCalls.Ⴃ((object)P_0.IpAddress, (object)ShowSkimCtyHelp.Ⴍ(1216134115, 8, 'G'), (object)P_0.Port, 'ǫ', 449));
		Ⴐ(DateTime.UtcNow);
	}

	internal LogEntry(IIoDeviceCfg P_0, string P_1, string P_2)
	{
		Ⴗ(P_1);
		Ⴍ(P_0.Description);
		Ⴓ(P_2);
		Ⴀ(ShowPrefixCalls.Ⴃ((object)P_0.IpAddress, (object)ShowSkimCtyHelp.Ⴍ(1216134125, 6, '¹'), (object)P_0.Port, '\u0313', 825));
		Ⴐ(DateTime.UtcNow);
	}

	[SecuritySafeCritical]
	internal static string Ⴄ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			int num = 0;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 14;
					continue;
				case 14:
					break;
				case 2:
				case 11:
					num2 = (((P_2 ^ P_1) - 41) ^ num) switch
					{
						0 => 12, 
						1 => ⴃႰ[181] - 6607, 
						2 => ⴍႤ[482] - 28460, 
						3 => ⴃႠ[243] - 16802, 
						4 => 5, 
						5 => 0, 
						_ => 3, 
					};
					continue;
				case 3:
					comparable = null;
					num2 = ⴄႤ[231] - 54;
					continue;
				case 12:
					comparable = UtilsString.StripHop(P_0);
					num2 = 10;
					continue;
				case 8:
					comparable = P_0.ToLower();
					num2 = 10;
					continue;
				case 13:
				case 16:
					comparable = UtilsMacros.ExpandDxFilterMacros(P_0);
					num2 = ⴃႠ[333] - 47342;
					continue;
				case 6:
					comparable = UtilsSql.UnFormatSqlFilter(P_0);
					num2 = ⴍႤ[137] - 14894;
					continue;
				case 5:
					comparable = UtilsXml.GetFirstTag(P_0);
					num2 = 10;
					continue;
				case 0:
				case 9:
					comparable = UtilsCallsign.CallsignNormalization(P_0);
					num2 = 10;
					continue;
				case 10:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 7 : (ⴍႤ[267] - 50379));
					continue;
				case 15:
					num2 = 2;
					continue;
				case 7:
					return comparable as string;
				case 4:
					num2 = ⴄႷ[77] - 61882;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴜ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : CallbookData
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		IEquatable<string> equatable = default(IEquatable<string>);
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
					num2 = 0;
					continue;
				case 0:
				case 10:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 66) ^ num) switch
					{
						0 => 6, 
						_ => ⴐ[387] + ⴐ[204], 
					};
					continue;
				case 9:
					equatable = null;
					goto case 5;
				case 5:
					num2 = ⴃႠ[302] - 12489;
					continue;
				case 4:
				case 6:
					equatable = P_0.Zip;
					num2 = 11;
					continue;
				case 11:
				{
					num++;
					int num3 = 23;
					int num4 = 222;
					num2 = ((2220 > num4 - num3 * 10) ? ⴄႤ[148] : 8);
					continue;
				}
				case 8:
					num2 = ⴀႳ[262] - 23918;
					continue;
				case 1:
					return equatable as string;
				case 2:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}
}
