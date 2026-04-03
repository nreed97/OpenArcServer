using System.ComponentModel;
using System.Security;
using System.Threading;
using System.Xml;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wx;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class TalkCacheCfg
{
	private ChatRoomPvtCfg.Ⴓ Ⴍ = new ChatRoomPvtCfg.Ⴓ();

	[Description("Number of days of data to keep in the database after purge operations")]
	public int DbDaysToKeep
	{
		get
		{
			return Ⴍ.Ⴃ;
		}
		set
		{
			Ⴍ.Ⴃ = value;
		}
	}

	[Description("Minutes of data to keep in the memory cache")]
	public int CacheMinutes
	{
		get
		{
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			return Ⴍ.Ⴅ;
		}
		set
		{
			Ⴍ.Ⴅ = value;
		}
	}

	public TalkCacheCfg()
	{
		DbDaysToKeep = 30;
		CacheMinutes = 30;
	}

	public override string ToString()
	{
		return ReplyMailHelp.Ⴄ(26, null, 1057165612, 6);
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210>(_0021_00210 P_0, ThreadPriority P_1, short P_2, short P_3) where _0021_00210 : Thread
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 1;
				break;
			case 1:
				num = (((P_2 ^ P_3) - 32) ^ num2) switch
				{
					0 => 6, 
					_ => ⴄႷ[48] - 38965, 
				};
				break;
			case 2:
				num = ⴄႭ[66];
				break;
			case 6:
				P_0.Priority = P_1;
				goto case 0;
			case 0:
			case 4:
			case 8:
				num2++;
				goto case 7;
			case 7:
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? 3 : 9);
				break;
			case 9:
				num = ⴄႭ[616] - 159;
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static XmlNodeList Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : XmlNode
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
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
					num2 = ⴃႰ[108] - 48235;
					continue;
				case 3:
					break;
				case 5:
					num2 = (((P_2 ^ P_3) - 93) ^ num) switch
					{
						0 => ⴄႤ[495] - 51, 
						_ => 7, 
					};
					continue;
				case 7:
					obj = null;
					goto case 11;
				case 11:
					num2 = ⴀႨ[141] - 33427;
					continue;
				case 6:
					obj = P_0.SelectNodes(P_1);
					num2 = ⴀႳ[348] - 48481;
					continue;
				case 9:
					num++;
					goto case 4;
				case 4:
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴄႤ[361] - 245) : 2);
					continue;
				case 2:
					num2 = 5;
					continue;
				case 0:
					return obj as XmlNodeList;
				case 8:
				case 10:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}
}
