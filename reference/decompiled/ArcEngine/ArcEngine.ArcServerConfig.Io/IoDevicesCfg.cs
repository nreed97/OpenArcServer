using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcInterfaces.Ui;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Io;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class IoDevicesCfg
{
	internal sealed class Ⴈ
	{
		internal string Ⴗ;

		internal string Ⴍ;

		internal string Ⴓ;

		internal DateTime Ⴀ;

		internal Ⴈ()
		{
		}
	}

	private IoClientDevicesCfg Ⴄ;

	private SetStationQth.Ⴃ m_Ⴃ = new SetStationQth.Ⴃ();

	[Description("Client I/O connects are how you connect to other nodes or skimmers.  The most common usage is connecting into another AR-Cluster node.")]
	public IoClientDevicesCfg Client
	{
		get
		{
			IoClientDevicesCfg ⴄ = Ⴄ;
			SetAnnChatRooms.Ⴀ[17] = (char)((SetAnnChatRooms.Ⴀ[17] ^ SetAnnChatRooms.Ⴀ[296]) & 0xE6);
			return ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	[Description("Server I/O connects allow other users and nodes to connect to you.  The most common usage is to setup a Telnet Server so users can telnet into the node.")]
	public IoServerDevicesCfg Server
	{
		get
		{
			return this.m_Ⴃ.Ⴍ;
		}
		set
		{
			this.m_Ⴃ.Ⴍ = value;
		}
	}

	public IoDevicesCfg()
	{
		Client = new IoClientDevicesCfg();
		Server = new IoServerDevicesCfg();
	}

	public void LoadDefaults(string nodeCall)
	{
		Client.LoadDefaults(nodeCall);
		Server.LoadDefaults();
		ShowWwvOptionsHelp.ႣႥ[137] = (char)((ShowWwvOptionsHelp.ႣႥ[137] | ShowWwvOptionsHelp.ႣႥ[160]) & 0x74);
	}

	public override string ToString()
	{
		return ႰႥ.Ⴅ(1, ';', 952621861);
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : WwvSpot
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		DateTime result = default(DateTime);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[273] - 106;
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
				case 2:
					num2 = (((P_1 ^ P_2) - 66) ^ num) switch
					{
						0 => 10, 
						_ => 3, 
					};
					continue;
				case 3:
				case 8:
					result = default(DateTime);
					num2 = 1;
					continue;
				case 6:
				case 10:
					result = P_0.Dts;
					num2 = 1;
					continue;
				case 1:
				{
					num++;
					int num3 = 763;
					int num4 = 791;
					num2 = ((4746 > num4 - num3 * 6) ? 11 : 5);
					continue;
				}
				case 5:
					num2 = 2;
					continue;
				case 11:
					return result;
				case 4:
				case 7:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DataRow
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 7;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				break;
			case 8:
				num = (((P_2 ^ P_1) - 120) ^ num2) switch
				{
					0 => 0, 
					_ => ⴃႥ[451] - 59524, 
				};
				break;
			case 1:
				num = 5;
				break;
			case 0:
				P_0.Delete();
				goto case 5;
			case 5:
			case 6:
				num2++;
				goto case 3;
			case 3:
				num3 = 162;
				num4 = 251;
				goto case 9;
			case 9:
				num = ((2008 > num4 - num3 * 8) ? 2 : (ⴃႥ[322] - 34461));
				break;
			case 4:
				num = ⴀႨ[221] - 55654;
				break;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, char P_3) where _0021_00210 : StatusBarData
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 9;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 4;
				break;
			case 2:
			case 4:
				num = (((P_3 ^ P_2) - 41) ^ num3) switch
				{
					0 => 1, 
					_ => ⴃႠ[48] - 38910, 
				};
				break;
			case 8:
				num = 5;
				break;
			case 1:
				P_0.AlertDxRate = P_1;
				goto case 5;
			case 5:
				num3++;
				num2 = P_3 * P_3;
				goto case 3;
			case 3:
				num2 = P_3 + num2;
				num = ⴀႳ[130] - 25456;
				break;
			case 6:
			case 7:
				num = ((num2 % 2 != 0) ? (ⴄႷ[50] - 56635) : 0);
				break;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : NeedsCfg
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 27) ^ num) switch
					{
						0 => 1, 
						_ => 5, 
					};
					continue;
				case 5:
					enumerable = null;
					num2 = ⴍႭ[278] - 27793;
					continue;
				case 1:
				case 7:
				case 8:
				case 9:
					enumerable = P_0.Cw;
					num2 = 6;
					continue;
				case 6:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 2 : (ⴃႰ[191] - 1775));
					continue;
				case 4:
					num2 = ⴍႤ[233] - 49480;
					continue;
				case 2:
					return enumerable as string;
				case 3:
					num2 = ⴀႼ[80];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, RepairOption P_2, short P_3, char P_4) where _0021_00210 : SqlCeEngine where _0021_00211 : string
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႣ[213] - 57124;
				break;
			case 5:
			case 7:
				num = (((P_4 ^ P_3) - 71) ^ num2) switch
				{
					0 => 6, 
					_ => 1, 
				};
				break;
			case 1:
				num = ⴀ[73] - 59797;
				break;
			case 6:
			case 9:
				P_0.Repair(P_1, P_2);
				goto case 4;
			case 4:
				num2++;
				num = (((P_4 * P_4 + P_4) % 2 == 0) ? ⴅ[210] : 2);
				break;
			case 0:
			case 2:
				num = 7;
				break;
			case 8:
				return;
			}
		}
	}
}
