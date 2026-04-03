using System.ComponentModel;
using System.Security;
using System.Text;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcShared.ArcUtils;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ChatRoomPubCfg
{
	private bool Ⴓ;

	private SetDxFilterHelp.Ⴈ m_Ⴍ = new SetDxFilterHelp.Ⴈ();

	[Description("Flag to automatically update from the web every day")]
	public bool AutoDownload
	{
		get
		{
			return this.m_Ⴍ.Ⴐ;
		}
		set
		{
			bool ⴐ = value;
			this.m_Ⴍ.Ⴐ = ⴐ;
		}
	}

	[Description("Flag to automatically reload the cache when the source text file changes")]
	public bool AutoReload
	{
		get
		{
			bool ⴓ = Ⴓ;
			ShowSunHelp.ႣႠ[201] = (char)((ShowSunHelp.ႣႠ[201] - SetDxCountHelp.ႭႤ[156]) & 0x22);
			return ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	public ChatRoomPubCfg()
	{
		AutoDownload = true;
		AutoReload = true;
	}

	public override string ToString()
	{
		return ReplyMailHelp.Ⴄ(8, null, 1057166534, 8);
	}

	[SecuritySafeCritical]
	internal static bool Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : BadWordUpdate
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		bool result = default(bool);
		int num3 = default(int);
		int num4 = default(int);
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
					num2 = ⴄႷ[141] - 32626;
					continue;
				case 4:
					break;
				case 9:
					num2 = (((P_1 ^ P_2) - 45) ^ num) switch
					{
						0 => ⴍႤ[267] - 50391, 
						_ => 10, 
					};
					continue;
				case 10:
					result = false;
					num2 = ⴍႤ[262] - 41196;
					continue;
				case 3:
				case 6:
					result = P_0.VerifyCopyDelete();
					num2 = 1;
					continue;
				case 1:
					num++;
					num3 = 1839;
					num4 = 84;
					goto case 2;
				case 2:
				case 7:
					num2 = ((613 < num3 / 3 - num4) ? (ⴄႤ[155] / 5) : (ⴄႤ[210] - 19));
					continue;
				case 8:
					return result;
				case 0:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴐ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : CallBlockUpdate
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[52] - 60819;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
				case 7:
				case 10:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 111) ^ num) switch
					{
						0 => 4, 
						_ => 6, 
					};
					continue;
				case 6:
					result = true;
					num2 = 1;
					continue;
				case 4:
					result = P_0.VerifyCopyDelete();
					num2 = ⴐ[281] - ⴐ[76];
					continue;
				case 1:
				case 9:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? ⴄႤ[135] : ⴐ[243]);
					continue;
				case 8:
					num2 = 3;
					continue;
				case 5:
					return result;
				case 11:
					num2 = ⴀ[281] - 5625;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : string
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			byte num2 = ⴄႤ[54];
			SetTalkCountHelp.Ⴅ[445] = (byte)((SetTalkCountHelp.Ⴅ[445] ^ P_1) & 0xFA);
			int num3 = num2 - 34;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = 5;
					continue;
				case 5:
					break;
				case 6:
					num3 = (((P_1 ^ P_2) - 64) ^ num) switch
					{
						0 => 3, 
						_ => 8, 
					};
					continue;
				case 8:
					result = 9;
					num3 = ⴀ[384] - 11769;
					continue;
				case 3:
					result = UtilsCallsign.GetFirstNumberFromCall(P_0);
					num3 = 1;
					continue;
				case 1:
				case 4:
					num++;
					goto case 0;
				case 0:
				case 10:
				{
					int num4 = 61;
					int num5 = 409;
					num3 = ((1636 > num5 - num4 * 4) ? 11 : 7);
					continue;
				}
				case 7:
					num3 = ⴃႰ[58] - 19218;
					continue;
				case 11:
					return result;
				case 2:
					num3 = ⴀႣ[0] - 46447;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Encoding Ⴗ(short P_0, char P_1)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႨ[12] - 29224;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 6;
					continue;
				case 6:
					break;
				case 10:
					num2 = (((P_0 ^ P_1) - 103) ^ num) switch
					{
						0 => ⴍႤ[410] - 46366, 
						_ => 11, 
					};
					continue;
				case 11:
					obj = null;
					num2 = ⴀ[442] - 37344;
					continue;
				case 3:
				case 9:
					obj = Encoding.Default;
					num2 = 8;
					continue;
				case 8:
					num++;
					goto case 0;
				case 0:
				{
					int num3 = 230;
					int num4 = 595;
					num2 = ((1785 > num4 - num3 * 3) ? (ⴀႨ[45] - 15631) : 5);
					continue;
				}
				case 5:
					num2 = 10;
					continue;
				case 2:
				case 7:
					return (Encoding)obj;
				case 1:
					num2 = ⴍႤ[190] - 43809;
					continue;
				}
				break;
			}
		}
	}
}
