using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Security;
using System.Xml.Serialization;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcInterfaces;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class Top100CacheCfg
{
	private bool Ⴃ;

	private ႰႼ.Ⴈ Ⴀ;

	[Description("Flag to automatically update from the web every day")]
	public bool AutoDownload
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

	[Description("Flag to automatically reload the cache when the source text file changes")]
	public bool AutoReload
	{
		get
		{
			bool ⴓ = Ⴀ.Ⴓ;
			SetAnnChatRooms.Ⴀ[62] = (char)(SetAnnChatRooms.Ⴀ[62] & ShowQrzHelp.ႤႤ[428] & 0x9C);
			return ⴓ;
		}
		set
		{
			bool ⴓ = value;
			Ⴀ.Ⴓ = ⴓ;
		}
	}

	[Description("Download url")]
	public string Url
	{
		get
		{
			return Ⴀ.Ⴃ;
		}
		set
		{
			Ⴀ.Ⴃ = value as string;
		}
	}

	public Top100CacheCfg()
	{
		AutoDownload = true;
		AutoReload = true;
		Url = CallBlockCacheCfg.Ⴅ(null, 5, 62062208, null);
	}

	public override string ToString()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		return CallBlockCacheCfg.Ⴅ(null, 8, 62062431, null);
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211, _0021_00212>(_0021_00211 P_0, _0021_00210 P_1, _0021_00212 P_2, short P_3, short P_4) where _0021_00210 : Stream where _0021_00211 : XmlSerializer
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				break;
			case 0:
			case 5:
				num = (((P_3 ^ P_4) - 89) ^ num2) switch
				{
					0 => ⴀ[218] - 62880, 
					_ => 1, 
				};
				break;
			case 1:
				num = ⴄႤ[337] - 44;
				break;
			case 6:
				P_0.Serialize(P_1, P_2);
				goto case 4;
			case 4:
			case 9:
				num2++;
				num = (((P_4 * P_4 + P_4) % 2 == 0) ? ⴄႭ[134] : (ⴍႤ[381] - 31338));
				break;
			case 3:
				num = 0;
				break;
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : CallbookData
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = 9;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႥ[239] - 50020;
					continue;
				case 6:
				case 11:
					break;
				case 9:
				{
					int num5 = P_1 ^ P_2;
					ShowWwvOptionsHelp.ႣႥ[10] = (char)(ShowWwvOptionsHelp.ႣႥ[10] & P_2 & 0x74);
					num2 = ((num5 - 59) ^ num) switch
					{
						0 => 3, 
						1 => ⴀႨ[150] - 6186, 
						_ => 2, 
					};
					continue;
				}
				case 2:
				case 10:
					cloneable = null;
					goto case 7;
				case 7:
					num2 = 0;
					continue;
				case 3:
					cloneable = P_0.FirstName;
					num2 = 0;
					continue;
				case 12:
					cloneable = P_0.MiddleName;
					num2 = 0;
					continue;
				case 0:
				{
					num++;
					int num3 = 331;
					int num4 = 941;
					num2 = ((4705 > num4 - num3 * 5) ? (ⴍႭ[200] - 53510) : 4);
					continue;
				}
				case 4:
					num2 = 9;
					continue;
				case 5:
					return (string)cloneable;
				case 8:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : OleDbConnection where _0021_00211 : OleDbCommand
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 2;
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 9;
				break;
			case 4:
			case 9:
				num = (((P_3 ^ P_2) - 95) ^ num3) switch
				{
					0 => 5, 
					_ => ⴀႳ[183] - 43496, 
				};
				break;
			case 7:
				num = ⴍႭ[331] - 20133;
				break;
			case 5:
				P_0.Connection = P_1;
				goto case 0;
			case 0:
			case 1:
			case 8:
			{
				int num2 = num3;
				ႨႣ.Ⴐ[39] = (byte)((ႨႣ.Ⴐ[39] | P_2) & 0xE);
				num3 = num2 + 1;
				int num4 = 77;
				int num5 = 252;
				num = ((756 > num5 - num4 * 3) ? 6 : 3);
				break;
			}
			case 3:
				num = ⴄႤ[177] / 8;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, char P_3) where _0021_00210 : DataRow
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႳ[258] - 27280;
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
				case 11:
					num2 = (((P_3 ^ P_2) - 64) ^ num) switch
					{
						0 => 0, 
						_ => 8, 
					};
					continue;
				case 7:
				case 8:
					result = null;
					num2 = 6;
					continue;
				case 0:
					result = P_0[P_1];
					num2 = ⴄႷ[128] - 3830;
					continue;
				case 6:
				case 9:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? 1 : 3);
					continue;
				case 3:
					num2 = ⴄႭ[615] / 6;
					continue;
				case 1:
				case 5:
					return result;
				case 4:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}
}
