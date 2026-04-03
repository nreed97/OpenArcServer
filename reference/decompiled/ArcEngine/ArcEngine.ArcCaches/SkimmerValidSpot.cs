using System;
using System.IO;
using System.Security;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using log4net;
using log4net.Core;

namespace ArcEngine.ArcCaches;

public sealed class SkimmerValidSpot
{
	private string Ⴍ;

	private DxHelp.Ⴐ m_Ⴅ = new DxHelp.Ⴐ();

	public string Call
	{
		get
		{
			string ⴍ = Ⴍ;
			Arc4ServerClient.ႠႣ[122] = (char)((Arc4ServerClient.ႠႣ[122] * Arc4ServerClient.ႠႣ[254]) & 0x99);
			return ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	public int FreqHz
	{
		get
		{
			int ⴗ = this.m_Ⴅ.Ⴗ;
			SetTalkCountHelp.Ⴅ[72] = (byte)((SetTalkCountHelp.Ⴅ[72] ^ SetTalkCountHelp.Ⴅ[249]) & 3);
			return ⴗ;
		}
		set
		{
			this.m_Ⴅ.Ⴗ = value;
		}
	}

	public DateTime Dts
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			return this.m_Ⴅ.Ⴍ;
		}
		set
		{
			this.m_Ⴅ.Ⴍ = value;
		}
	}

	public SkimmerValidSpot(string call, int freq, DateTime dts)
	{
		Call = call;
		FreqHz = freq;
		Dts = dts;
	}

	public SkimmerValidSpot(string call, float freq, DateTime dts)
	{
		Call = call;
		FreqHz = ShowUsersHelp.Ⴓ(freq * 1000f, 464, 437);
		Dts = dts;
	}

	public override string ToString()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		while (true)
		{
			Array array = new object[5];
			while (true)
			{
				IL_004b:
				((object[])array)[0] = Call;
				(array as object[])[1] = SetTalkCount.Ⴗ(2, null, 1267022529, typeof(LoginMsgCache));
				char num = ⴀႳ[105];
				IpLockoutCacheCfg.ႭႭ[261] = (char)((IpLockoutCacheCfg.ႭႭ[261] * IpLockoutCacheCfg.ႭႭ[249]) & 0x36);
				int num2 = num - 23067;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = ⴃႰ[82] - 44763;
						continue;
					case 4:
						break;
					case 2:
						goto IL_004b;
					case 1:
					case 5:
						((object[])array)[2] = FreqHz;
						((object[])array)[3] = SetTalkCount.Ⴗ(4, null, 1267022535, typeof(WxFullUser));
						num2 = 6;
						continue;
					case 0:
					case 6:
						(array as object[])[4] = Dts;
						return SetDxDefaultHelp.Ⴍ(array as object[], 'ˤ', 653);
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ILog Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		ILoggerWrapper loggerWrapper = default(ILoggerWrapper);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႣ[13] - 52916;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 8;
					continue;
				case 8:
					break;
				case 7:
				case 11:
					num2 = (((P_2 ^ P_1) - 29) ^ num) switch
					{
						0 => ⴃႥ[140] - 53416, 
						_ => 0, 
					};
					continue;
				case 0:
				case 1:
					loggerWrapper = null;
					num2 = 6;
					continue;
				case 9:
					loggerWrapper = LogManager.GetLogger(P_0);
					num2 = ⴀႨ[98] - 41428;
					continue;
				case 6:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 10;
					continue;
				case 10:
					num2 = ((num3 % 2 != 0) ? (ⴍႤ[33] - 61822) : 4);
					continue;
				case 3:
				case 4:
					return (ILog)loggerWrapper;
				case 5:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 12;
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
				case 9:
				case 12:
					num2 = (((P_2 ^ P_1) - 116) ^ num) switch
					{
						0 => 3, 
						1 => 11, 
						_ => ⴍႭ[281] - 23359, 
					};
					continue;
				case 8:
					result = true;
					num2 = ⴃႠ[192] - 23550;
					continue;
				case 3:
					result = UtilsNumeric.IsNumeric(P_0);
					goto case 0;
				case 0:
					num2 = 4;
					continue;
				case 11:
					result = UtilsString.IsValidEmail(P_0);
					num2 = 4;
					continue;
				case 4:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 != 0) ? 1 : 7);
					continue;
				case 1:
					num2 = 12;
					continue;
				case 2:
				case 7:
					return result;
				case 6:
					num2 = ⴃႰ[155] - 30429;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, short P_3) where _0021_00210 : DxCfg
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 5;
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = ⴃႰ[80] - 24195;
				break;
			case 8:
				num = (((P_2 ^ P_3) - 74) ^ num4) switch
				{
					0 => 4, 
					_ => 0, 
				};
				break;
			case 0:
			case 7:
				num = ⴃႥ[79] - 4227;
				break;
			case 4:
				P_0.NmbrSpots = P_1;
				goto case 1;
			case 1:
			case 2:
				num4++;
				num3 = P_3 * P_3;
				num3 = P_3 + num3;
				num = 3;
				break;
			case 3:
			case 6:
			{
				int num2 = num3 % 2;
				SetAnnChatRooms.Ⴀ[403] = (char)((SetAnnChatRooms.Ⴀ[403] - P_1) & 0x73);
				num = ((num2 != 0) ? 8 : 9);
				break;
			}
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00211 : string
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[53] - ⴍႭ[53];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 4;
					continue;
				case 4:
					break;
				case 0:
				case 9:
					num2 = (((P_3 ^ P_2) - 127) ^ num) switch
					{
						0 => 8, 
						_ => 6, 
					};
					continue;
				case 6:
					equatable = null;
					goto case 2;
				case 2:
					num2 = ⴀႼ[112] - 205;
					continue;
				case 7:
				case 8:
					equatable = string.Format(P_0, P_1);
					num2 = 11;
					continue;
				case 11:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? 5 : 3);
					continue;
				case 3:
					num2 = 0;
					continue;
				case 5:
					return (string)equatable;
				case 1:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long Ⴄ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : Stream
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		long result = default(long);
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 6;
					continue;
				case 1:
				case 6:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 1) ^ num) switch
					{
						0 => 10, 
						_ => 11, 
					};
					continue;
				case 5:
				case 11:
					result = 8L;
					num2 = 4;
					continue;
				case 10:
					result = P_0.Length;
					num2 = ⴃႥ[318] - 47517;
					continue;
				case 4:
				{
					num++;
					int num3 = 67;
					int num4 = 142;
					num2 = ((994 > num4 - num3 * 7) ? 2 : 3);
					continue;
				}
				case 3:
				case 9:
					num2 = 0;
					continue;
				case 2:
					return result;
				case 8:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}
}
