using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Security;
using System.Xml;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class DxSpotBlockCacheCfg
{
	private bool Ⴐ;

	private bool Ⴅ;

	private string Ⴈ;

	[Description("Flag to automatically update from the web every day")]
	public bool AutoDownload
	{
		get
		{
			char[] ⴃႰ = SetWxOutput.ႣႰ;
			return Ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	[Description("Flag to automatically reload the cache when the source text file changes")]
	public bool AutoReload
	{
		get
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			return Ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	[Description("Download url")]
	public string Url
	{
		get
		{
			return Ⴈ;
		}
		set
		{
			Ⴈ = value;
		}
	}

	public DxSpotBlockCacheCfg()
	{
		AutoDownload = true;
		AutoReload = true;
		Url = CallBlockCacheCfg.Ⴅ(null, 3, 62055313, null);
	}

	public override string ToString()
	{
		string result = CallBlockCacheCfg.Ⴅ(null, 8, 62055332, null);
		SetAnnMode.ႤႭ[619] = (byte)((SetAnnMode.ႤႭ[619] * SetAnnMode.ႤႭ[448]) & 0x23);
		return result;
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : Assembly
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
				case 4:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 98) ^ num) switch
					{
						0 => ⴄႤ[280] - ⴄႤ[5], 
						_ => 5, 
					};
					continue;
				case 5:
					enumerable = null;
					num2 = ⴍႭ[171] - 30390;
					continue;
				case 10:
					enumerable = P_0.Location;
					num2 = 7;
					continue;
				case 7:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 6 : (ⴃႥ[312] - 23147));
					continue;
				case 8:
					num2 = 1;
					continue;
				case 3:
				case 6:
				case 11:
					return enumerable as string;
				case 9:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataRow[] Ⴄ<_0021_00210, _0021_00211, _0021_00212>(_0021_00211 P_0, _0021_00210 P_1, _0021_00212 P_2, char P_3, char P_4) where _0021_00210 : string where _0021_00211 : DataTable where _0021_00212 : string
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
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
					num2 = 7;
					continue;
				case 7:
					break;
				case 5:
					num2 = (((P_4 ^ P_3) - 71) ^ num) switch
					{
						0 => ⴀ[251] - 7816, 
						_ => ⴄႭ[103] - 103, 
					};
					continue;
				case 4:
					obj = null;
					num2 = ⴃႥ[427] - 64124;
					continue;
				case 9:
					obj = P_0.Select(P_1, P_2);
					num2 = ⴃႠ[81] - 52169;
					continue;
				case 1:
				case 6:
					num++;
					num3 = 1378;
					num4 = 186;
					goto case 2;
				case 2:
					num2 = ((689 < num3 / 2 - num4) ? 5 : (ⴀ[13] - 24976));
					continue;
				case 10:
					return obj as DataRow[];
				case 0:
				case 8:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : XmlNode
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		IComparable comparable = default(IComparable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 7;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 9:
					break;
				case 7:
					num2 = (((P_2 ^ P_1) - 127) ^ num) switch
					{
						0 => ⴍႭ[163] - 17755, 
						1 => ⴍႭ[217] - 18527, 
						_ => 5, 
					};
					continue;
				case 5:
					comparable = null;
					goto case 12;
				case 12:
					num2 = 0;
					continue;
				case 1:
				case 10:
					comparable = P_0.Name;
					goto case 8;
				case 8:
					num2 = 0;
					continue;
				case 6:
					comparable = P_0.InnerXml;
					num2 = 0;
					continue;
				case 0:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴐ[94] - 102;
					continue;
				case 2:
					num2 = ((num3 % 2 != 0) ? (ⴀႼ[89] - 175) : 11);
					continue;
				case 11:
					return (string)comparable;
				case 4:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}
}
