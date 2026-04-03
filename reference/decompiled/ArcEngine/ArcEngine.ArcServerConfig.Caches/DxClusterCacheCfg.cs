using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class DxClusterCacheCfg
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴈ
	{
		internal bool Ⴄ;

		internal bool Ⴀ;

		internal bool Ⴗ;

		internal bool Ⴃ;

		internal bool Ⴓ;
	}

	private bool Ⴀ;

	private ႰႼ.Ⴈ m_Ⴅ;

	[Description("Flag to automatically update from the web every day")]
	public bool AutoDownload
	{
		get
		{
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			return this.m_Ⴅ.Ⴓ;
		}
		set
		{
			bool ⴓ = value;
			this.m_Ⴅ.Ⴓ = ⴓ;
		}
	}

	[Description("Flag to automatically reload the cache when the source text file changes")]
	public bool AutoReload
	{
		get
		{
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	[Description("Download url")]
	public string Url
	{
		get
		{
			string ⴃ = this.m_Ⴅ.Ⴃ;
			ShowWwvOptionsHelp.ႣႥ[7] = (char)((ShowWwvOptionsHelp.ႣႥ[7] ^ ShowWwvOptionsHelp.ႣႥ[225]) & 0x8E);
			return ⴃ;
		}
		set
		{
			this.m_Ⴅ.Ⴃ = value as string;
		}
	}

	public DxClusterCacheCfg()
	{
		AutoDownload = true;
		AutoReload = true;
		Url = CallBlockCacheCfg.Ⴅ(null, 7, 62062288, null);
	}

	public override string ToString()
	{
		return CallBlockCacheCfg.Ⴅ(null, 2, 62062306, null);
	}

	[SecuritySafeCritical]
	internal static bool Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DxSpotBlockUpdate
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႭ[307] - ⴄႭ[145];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[375] - ⴅ[67];
					continue;
				case 6:
					break;
				case 0:
				case 11:
					num2 = (((P_2 ^ P_1) - 49) ^ num) switch
					{
						0 => 10, 
						_ => 7, 
					};
					continue;
				case 7:
					result = true;
					num2 = 4;
					continue;
				case 10:
					result = P_0.VerifyCopyDelete();
					num2 = ⴀႼ[96];
					continue;
				case 2:
				case 4:
				case 9:
				{
					num++;
					int num3 = 556;
					int num4 = 625;
					num2 = ((5625 > num4 - num3 * 9) ? (ⴀႼ[126] - 237) : (ⴃႥ[234] - 38048));
					continue;
				}
				case 8:
					num2 = ⴀႼ[33] + ⴀႼ[113];
					continue;
				case 1:
					return result;
				case 5:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : string where _0021_00211 : DxSpot
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႣ[131] - 13170;
				break;
			case 6:
			case 8:
				num = (((P_2 ^ P_3) - 22) ^ num2) switch
				{
					0 => ⴀႼ[33], 
					1 => ⴀႣ[70] - 49504, 
					2 => 10, 
					_ => 0, 
				};
				break;
			case 0:
				num = 5;
				break;
			case 9:
				P_0.SpotterNode = P_1;
				num = 5;
				break;
			case 4:
				P_0.Mode = P_1;
				num = ⴅ[318] - 25;
				break;
			case 2:
			case 10:
				P_0.SpotterState = P_1;
				goto case 5;
			case 5:
			{
				num2++;
				int num3 = 313;
				int num4 = 639;
				num = ((6390 > num4 - num3 * 10) ? (ⴃႠ[402] - 22724) : (ⴃႥ[401] - 25398));
				break;
			}
			case 1:
				num = ⴀႳ[181] - 60268;
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, DxModeType P_1, int P_2, int P_3) where _0021_00210 : DxCfg
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄႭ[134];
				break;
			case 8:
				num = (((P_3 ^ P_2) - 105) ^ num2) switch
				{
					0 => 6, 
					_ => 1, 
				};
				break;
			case 1:
				num = 4;
				break;
			case 6:
				P_0.Mode = P_1;
				goto case 4;
			case 4:
			{
				num2++;
				int num3 = 27;
				int num4 = 28;
				num = ((56 > num4 - num3 * 2) ? (ⴃႥ[46] - 62984) : (ⴀ[513] - 5084));
				break;
			}
			case 3:
				num = 8;
				break;
			case 2:
			case 5:
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႣ[85] - 26269;
					continue;
				case 5:
				case 9:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 65) ^ num) switch
					{
						0 => ⴐ[252] - 59, 
						_ => 2, 
					};
					continue;
				case 2:
					obj = typeof(CacheManager);
					num2 = 0;
					continue;
				case 3:
					obj = P_0.GetType();
					num2 = ⴃႰ[195] - ⴃႰ[195];
					continue;
				case 0:
				case 1:
				case 7:
				{
					num++;
					int num3 = 1509;
					int num4 = 1;
					num2 = ((503 < num3 / 3 - num4) ? (ⴄႷ[79] - 55487) : (ⴀႨ[14] - 1827));
					continue;
				}
				case 8:
					return obj as Type;
				case 10:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Stream Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : WebResponse
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		MarshalByRefObject marshalByRefObject = default(MarshalByRefObject);
		int num3 = default(int);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 5:
					num2 = (((P_2 ^ P_1) - 99) ^ num) switch
					{
						0 => ⴄႷ[121] - 57596, 
						_ => 0, 
					};
					continue;
				case 0:
					marshalByRefObject = null;
					goto case 1;
				case 1:
					num2 = ⴃႰ[11] - 51465;
					continue;
				case 8:
					marshalByRefObject = P_0.GetResponseStream();
					num2 = 4;
					continue;
				case 2:
				case 4:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 9;
					continue;
				case 9:
					num2 = ((num3 % 2 != 0) ? 5 : (ⴃႰ[85] - 51295));
					continue;
				case 10:
				case 11:
				{
					Stream result = (Stream)marshalByRefObject;
					IpLockoutCacheCfg.ႭႭ[141] = (char)((IpLockoutCacheCfg.ႭႭ[141] - SetAnnMode.ႤႭ[384]) & 0x9C);
					return result;
				}
				case 7:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}
}
