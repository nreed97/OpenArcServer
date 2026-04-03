using System;
using System.ComponentModel;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcInterfaces;
using ArcShared.ArcUtils;
using Meebey.SmartIrc4net;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class BadWordCacheCfg
{
	private bool Ⴃ;

	private ႰႼ.Ⴈ Ⴐ;

	[Description("Flag to automatically update from the web every day")]
	public bool AutoDownload
	{
		get
		{
			byte[] ⴅ = SetTalkCountHelp.Ⴅ;
			return Ⴐ.Ⴓ;
		}
		set
		{
			bool ⴓ = value;
			Ⴐ.Ⴓ = ⴓ;
		}
	}

	[Description("Flag to automatically reload the cache when the source text file changes")]
	public bool AutoReload
	{
		get
		{
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	[Description("Download url")]
	public string Url
	{
		get
		{
			return Ⴐ.Ⴃ;
		}
		set
		{
			Ⴐ.Ⴃ = value as string;
		}
	}

	public BadWordCacheCfg()
	{
		AutoDownload = true;
		AutoReload = true;
		Url = CallBlockCacheCfg.Ⴅ(null, 5, 62057104, null);
	}

	public override string ToString()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		return CallBlockCacheCfg.Ⴅ(null, 5, 62057150, null);
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : CallbookData
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[76] - ⴐ[141];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႷ[48] - 38966;
					continue;
				case 1:
					break;
				case 5:
					num2 = (((P_1 ^ P_2) - 105) ^ num) switch
					{
						0 => 4, 
						_ => 3, 
					};
					continue;
				case 3:
					equatable = null;
					goto case 2;
				case 2:
					num2 = ⴀႨ[122] - 31849;
					continue;
				case 4:
					equatable = P_0.State;
					num2 = 8;
					continue;
				case 8:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 11 : 0);
					continue;
				case 0:
					num2 = 5;
					continue;
				case 7:
				case 9:
				case 11:
					return (string)equatable;
				case 6:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ(short P_0, int P_1)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		IConvertible convertible = default(IConvertible);
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
					num2 = ⴄႤ[174] - 51;
					continue;
				case 5:
					break;
				case 0:
					num2 = (((P_0 ^ P_1) - 105) ^ num) switch
					{
						0 => 1, 
						_ => 7, 
					};
					continue;
				case 7:
					convertible = null;
					num2 = 8;
					continue;
				case 1:
					convertible = UtilsVersion.LongVersion;
					num2 = ⴃႥ[238] - 8378;
					continue;
				case 8:
					num++;
					goto case 11;
				case 11:
					num2 = (((P_0 * P_0 + P_0) % 2 == 0) ? (ⴅ[310] - 178) : 9);
					continue;
				case 6:
				case 9:
					num2 = 0;
					continue;
				case 2:
					return convertible as string;
				case 4:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ReceiveType Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : IrcMessageData
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		ReceiveType result = default(ReceiveType);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႭ[56] / 3;
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
				case 9:
					num2 = (((P_1 ^ P_2) - 113) ^ num) switch
					{
						0 => ⴃႰ[73] - 48546, 
						_ => 6, 
					};
					continue;
				case 6:
					result = ReceiveType.Info;
					num2 = 2;
					continue;
				case 1:
				case 5:
					result = P_0.Type;
					num2 = 2;
					continue;
				case 2:
				case 4:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႰ[20] - 30601) : 3);
					continue;
				case 3:
				case 10:
					num2 = 9;
					continue;
				case 11:
					return result;
				case 8:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}
}
