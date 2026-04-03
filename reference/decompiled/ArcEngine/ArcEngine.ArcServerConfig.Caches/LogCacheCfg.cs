using System.ComponentModel;
using System.IO;
using System.Security;
using System.Xml;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcInterfaces.Io;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class LogCacheCfg
{
	private int Ⴀ;

	private int Ⴈ;

	[Description("Number of days of data to keep in the database after purge operations")]
	public int DbDaysToKeep
	{
		get
		{
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	[Description("Minutes of data to keep in the memory cache")]
	public int CacheMinutes
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

	public LogCacheCfg()
	{
		DbDaysToKeep = 30;
		CacheMinutes = 30;
	}

	public override string ToString()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		return ReplyMailHelp.Ⴄ(22, null, 1057162882, 2);
	}

	[SecuritySafeCritical]
	internal static bool Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
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
					num2 = ⴄႷ[135] - 15689;
					continue;
				case 3:
					break;
				case 4:
					num2 = (((P_2 ^ P_1) - 0) ^ num) switch
					{
						0 => 6, 
						1 => 1, 
						_ => 11, 
					};
					continue;
				case 11:
					result = false;
					goto case 0;
				case 0:
					num2 = 9;
					continue;
				case 6:
					result = File.Exists(P_0);
					num2 = ⴀႳ[252] - 1332;
					continue;
				case 1:
					result = UtilsNumeric.IsDouble(P_0);
					num2 = 9;
					continue;
				case 9:
				{
					num++;
					int num3 = 1886;
					int num4 = 34;
					int num5 = num3 / 2 - num4;
					Arc4ServerClient.ႠႣ[358] = (char)((Arc4ServerClient.ႠႣ[358] | SetDxCountHelp.ႭႤ[170]) & 0xFD);
					num2 = ((943 < num5) ? 4 : (ⴃႰ[136] - 29124));
					continue;
				}
				case 2:
				case 8:
				case 10:
					return result;
				case 7:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : string where _0021_00211 : OnIoClientDisconnectEventHandler
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 1;
				continue;
			case 1:
				num = (((P_2 ^ P_3) - 18) ^ num2) switch
				{
					0 => ⴄႤ[408] - 86, 
					_ => ⴀႨ[82] - 5765, 
				};
				continue;
			case 7:
				num = 2;
				continue;
			case 6:
				P_0(P_1);
				break;
			case 0:
			case 2:
			case 4:
				break;
			case 3:
			case 8:
				return;
			}
			num2++;
			int num3 = 2136;
			int num4 = 221;
			num = ((534 < num3 / 4 - num4) ? (ⴀႳ[126] - 41117) : 8);
		}
	}

	[SecuritySafeCritical]
	internal static XmlElement Ⴐ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : XmlDocument
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		XmlLinkedNode xmlLinkedNode = default(XmlLinkedNode);
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
					num2 = ⴃႥ[63] - 62907;
					continue;
				case 1:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 89) ^ num) switch
					{
						0 => ⴀႣ[235] - 11074, 
						_ => 10, 
					};
					continue;
				case 10:
					xmlLinkedNode = null;
					num2 = 3;
					continue;
				case 5:
				case 11:
					xmlLinkedNode = P_0.DocumentElement;
					num2 = ⴐ[21];
					continue;
				case 3:
				{
					num++;
					int num3 = 18;
					int num4 = 208;
					num2 = ((1040 > num4 - num3 * 5) ? 2 : 7);
					continue;
				}
				case 7:
					num2 = 8;
					continue;
				case 0:
				case 2:
				case 4:
					return xmlLinkedNode as XmlElement;
				case 6:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}
}
