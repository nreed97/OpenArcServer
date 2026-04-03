using System.ComponentModel;
using System.Security;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;

namespace ArcEngine.ArcServerConfig;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class PcxxCfg
{
	private bool Ⴄ;

	private SetDxFilterHelp.Ⴈ Ⴐ = new SetDxFilterHelp.Ⴈ();

	[Description("Ignore node (PC19, PC21) and user (PC16, PC17) protocol")]
	public bool IgnoreNodeUserProtocol
	{
		get
		{
			char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
			return Ⴐ.Ⴐ;
		}
		set
		{
			bool ⴐ = value;
			Ⴐ.Ⴐ = ⴐ;
		}
	}

	[Description("Log outbound node and user protocol (PC18, PC19, PC16, PC17, PC21, PC20 and PC22)")]
	public bool LogOutboundNodeUser
	{
		get
		{
			int[] ⴀႨ = DirectoryBulletin.ႠႨ;
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	public override string ToString()
	{
		return ReplyMailHelp.Ⴄ(27, null, 1057165722, 1);
	}

	public void LoadDefaults()
	{
		IgnoreNodeUserProtocol = false;
		LogOutboundNodeUser = false;
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : WxCfg
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[125] / 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႭ[272] - 36007;
					continue;
				case 3:
				case 5:
					break;
				case 9:
					num2 = (((P_1 ^ P_2) - 24) ^ num) switch
					{
						0 => ⴃႥ[154] - 46849, 
						_ => 1, 
					};
					continue;
				case 1:
					obj = null;
					num2 = 2;
					continue;
				case 8:
					obj = P_0.Filter;
					num2 = 2;
					continue;
				case 2:
				{
					num++;
					int num3 = 440;
					int num4 = 532;
					num2 = ((2128 > num4 - num3 * 4) ? 7 : 11);
					continue;
				}
				case 11:
					num2 = 9;
					continue;
				case 7:
					return (string)obj;
				case 0:
				case 4:
					num2 = ⴀႣ[276] - 14069;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : ClientIoCfg
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int result = default(int);
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
					num2 = 1;
					continue;
				case 1:
					break;
				case 2:
				case 4:
				case 5:
					num2 = (((P_2 ^ P_1) - 73) ^ num) switch
					{
						0 => 3, 
						_ => 10, 
					};
					continue;
				case 6:
				case 10:
					result = P_1;
					num2 = 8;
					continue;
				case 3:
					result = P_0.Port;
					num2 = ⴀ[311] - 60440;
					continue;
				case 8:
				{
					num++;
					int num3 = 1562;
					int num4 = 223;
					num2 = ((781 < num3 / 2 - num4) ? 5 : (ⴃႥ[408] - 41635));
					continue;
				}
				case 0:
					return result;
				case 7:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}
}
