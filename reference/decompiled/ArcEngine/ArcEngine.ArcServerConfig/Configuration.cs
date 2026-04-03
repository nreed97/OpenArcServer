using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcCmds.Wwv;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcServerConfig;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class Configuration
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴈ
	{
		internal Dictionary<char, string> Ⴃ;
	}

	private string Ⴓ;

	private string Ⴗ;

	private string Ⴄ;

	private bool Ⴄ;

	private WwvSpotUser.Ⴓ Ⴀ;

	[Description("Call of your ARC4 node.  Allows a ARC6 node to take over ARC4 passive connections without the end nodes changing the connect callsign.")]
	public string Alias
	{
		get
		{
			return Ⴀ.Ⴈ;
		}
		set
		{
			Ⴀ.Ⴈ = value;
			SetDxCountHelp.ႭႤ[302] = SetDxCountHelp.ႭႤ[302] & SetDxCountHelp.ႭႤ[327] & 0x64;
		}
	}

	[Description("The GMT hour when the database maintenance will be done")]
	public int ScheduledMaintenanceHour
	{
		get
		{
			int ⴓ = Ⴀ.Ⴓ;
			DirectoryBulletin.ႠႨ[37] = (DirectoryBulletin.ႠႨ[37] | DirectoryBulletin.ႠႨ[131]) & 0x7A;
			return ⴓ;
		}
		set
		{
			Ⴀ.Ⴓ = value;
		}
	}

	[Description("Database connection")]
	public string DbConnect
	{
		get
		{
			return Ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	[Description("Local database connection (user data)")]
	public string LocalDbConnect
	{
		get
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			string ⴗ = Ⴗ;
			ShowWwvOptionsHelp.ႣႥ[35] = (char)((ShowWwvOptionsHelp.ႣႥ[35] * ShowWwvOptionsHelp.ႣႥ[120]) & 0xF3);
			return ⴗ;
		}
		set
		{
			Ⴗ = value;
		}
	}

	[Description("Continent")]
	[ReadOnly(true)]
	public string Cont
	{
		get
		{
			return this.Ⴄ;
		}
		set
		{
			this.Ⴄ = value;
		}
	}

	[ReadOnly(true)]
	[Description("Country")]
	public string Cty
	{
		get
		{
			return Ⴀ.Ⴗ;
		}
		set
		{
			Ⴀ.Ⴗ = value as string;
			SetAnnChatRooms.Ⴀ[352] = (char)((SetAnnChatRooms.Ⴀ[352] + ႨႣ.Ⴐ[231]) & 0x51);
		}
	}

	[Description("State")]
	[ReadOnly(true)]
	public string State
	{
		get
		{
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			string ⴄ = Ⴀ.Ⴄ;
			ShowWwvOptionsHelp.ႣႥ[222] = (char)((ShowWwvOptionsHelp.ႣႥ[222] * ShowWwvOptionsHelp.ႣႥ[264]) & 0xEA);
			return ⴄ;
		}
		set
		{
			Ⴀ.Ⴄ = value as string;
		}
	}

	[Description("Lazy Load on startup")]
	public bool LazyLoad
	{
		get
		{
			char[] ⴃႰ = SetWxOutput.ႣႰ;
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	[Description("Automatically process the US-FCC and VE callsign databases every week.")]
	public bool AutoFccVeCallsignDB
	{
		get
		{
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			return Ⴀ.Ⴃ;
		}
		set
		{
			bool ⴃ = value;
			Ⴀ.Ⴃ = ⴃ;
		}
	}

	public HamQthCfg HamQth
	{
		get
		{
			HamQthCfg ⴐ = Ⴀ.Ⴐ;
			ShowQrzHelp.ႤႤ[400] = (byte)((ShowQrzHelp.ႤႤ[400] ^ ShowQrzHelp.ႤႤ[449]) & 5);
			return ⴐ;
		}
		set
		{
			Ⴀ.Ⴐ = value;
			ႨႣ.Ⴐ[192] = (byte)((ႨႣ.Ⴐ[192] * ႨႣ.Ⴐ[176]) & 0x1E);
		}
	}

	public Configuration()
	{
		DbConnect = SetTalkCount.Ⴗ(8, null, 1267023316, typeof(HealthMonitorCfg));
		LocalDbConnect = CallBlockCacheCfg.Ⴅ(null, 4, 62057012, null);
		ScheduledMaintenanceHour = 8;
		Alias = string.Empty;
		Cont = string.Empty;
		Cty = string.Empty;
		State = string.Empty;
		LazyLoad = true;
		AutoFccVeCallsignDB = true;
		HamQth = new HamQthCfg();
	}

	public override string ToString()
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		return ႨႨ.Ⴀ(3, 0, 1157902512);
	}

	[SecuritySafeCritical]
	internal static byte[] Ⴃ<_0021_00210>(_0021_00210 P_0, byte[] P_1, char P_2, int P_3) where _0021_00210 : HashAlgorithm
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		Array array = default(Array);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႷ[21] - 64078;
					continue;
				case 10:
					break;
				case 2:
					num2 = (((P_2 ^ P_3) - 99) ^ num) switch
					{
						0 => 4, 
						_ => ⴄႤ[155] / 5, 
					};
					continue;
				case 9:
					array = null;
					num2 = ⴄႤ[302] - 132;
					continue;
				case 4:
					array = P_0.ComputeHash(P_1);
					num2 = 6;
					continue;
				case 0:
				case 6:
					num++;
					goto case 8;
				case 8:
					num3 = 423;
					num4 = 94;
					goto case 1;
				case 1:
					num2 = ((141 < num3 / 3 - num4) ? 2 : 5);
					continue;
				case 5:
					return (byte[])array;
				case 3:
					num2 = ⴀႼ[113];
					continue;
				}
				break;
			}
		}
	}
}
