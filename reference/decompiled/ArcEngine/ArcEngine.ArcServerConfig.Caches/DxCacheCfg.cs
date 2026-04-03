using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Security;
using System.Timers;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class DxCacheCfg
{
	private int Ⴃ;

	private double Ⴃ;

	private int Ⴗ;

	private SetStationQthHelp.Ⴈ m_Ⴀ = new SetStationQthHelp.Ⴈ();

	[Description("Number of days of data to keep in the database after purge operations")]
	public int DbDaysToKeep
	{
		get
		{
			return this.Ⴃ;
		}
		set
		{
			this.Ⴃ = value;
		}
	}

	[Description("Minutes of data to keep in the memory cache")]
	public int CacheMinutes
	{
		get
		{
			return this.m_Ⴀ.Ⴍ;
		}
		set
		{
			this.m_Ⴀ.Ⴍ = value;
		}
	}

	[Description("Dupe spots frequency bounds +- KHz bounds.  Ex: 0.110")]
	public double DupeFrequencyRange
	{
		get
		{
			char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	[Description("Max spots in the database for the auto-purge trigger")]
	public int DbMaxSpots
	{
		get
		{
			return Ⴗ;
		}
		set
		{
			Ⴗ = value;
		}
	}

	public DxCacheCfg()
	{
		DbDaysToKeep = 30;
		CacheMinutes = 20;
		DupeFrequencyRange = 0.3;
		DbMaxSpots = 250000;
	}

	public override string ToString()
	{
		return SetStationClubHelp.Ⴍ(2, 2, 1747257736, null);
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, int P_3) where _0021_00210 : string
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		IComparable comparable = default(IComparable);
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 8:
					num2 = (((P_3 ^ P_2) - 80) ^ num) switch
					{
						0 => 3, 
						_ => ⴃႠ[99] - 39691, 
					};
					continue;
				case 7:
				case 9:
					comparable = null;
					num2 = 2;
					continue;
				case 3:
				case 11:
					comparable = UtilsString.ScrubLength(P_0, P_1);
					num2 = ⴀ[383] - 19838;
					continue;
				case 2:
				{
					num++;
					int num3 = 294;
					int num4 = 724;
					SetDxCountHelp.ႭႤ[179] = (SetDxCountHelp.ႭႤ[179] + P_3) & 0xA1;
					num2 = ((1448 <= num4 - num3 * 2) ? 1 : 4);
					continue;
				}
				case 1:
					num2 = 8;
					continue;
				case 4:
					return comparable as string;
				case 0:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴈ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DxCommentExtCfg
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		bool result = default(bool);
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
					num2 = 4;
					continue;
				case 4:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 7) ^ num) switch
					{
						0 => 3, 
						_ => 9, 
					};
					continue;
				case 9:
					result = true;
					num2 = ⴍႤ[195] - 62523;
					continue;
				case 3:
					result = P_0.State;
					num2 = 11;
					continue;
				case 1:
				case 11:
				{
					int num3 = num;
					SetTalkCountHelp.Ⴅ[343] = (byte)((SetTalkCountHelp.Ⴅ[343] ^ P_1) & 0x27);
					num = num3 + 1;
					int num4 = 293;
					int num5 = 294;
					num2 = ((1176 > num5 - num4 * 4) ? (ⴄႭ[31] / 2) : 0);
					continue;
				}
				case 0:
					num2 = 8;
					continue;
				case 2:
				case 5:
				case 7:
					return result;
				case 6:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static OleDbDataReader Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : OleDbCommand
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		object obj = default(object);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႠ[157] - 60701;
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
				case 10:
					num2 = (((P_1 ^ P_2) - 24) ^ num) switch
					{
						0 => ⴀႼ[1] - ⴀႼ[112], 
						_ => 11, 
					};
					continue;
				case 11:
					obj = null;
					num2 = 4;
					continue;
				case 8:
					obj = P_0.ExecuteReader();
					num2 = 4;
					continue;
				case 0:
				case 3:
				case 4:
				{
					num++;
					num4 = 1280;
					int num5 = num4;
					num3 = num5 * num5;
					num2 = ⴃႥ[146] - 5440;
					continue;
				}
				case 7:
					num3 = num4 + num3;
					num2 = ((num3 % 2 != 0) ? (ⴐ[197] - 112) : (ⴐ[2] - 103));
					continue;
				case 5:
				case 6:
					return (OleDbDataReader)obj;
				case 9:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, char P_3) where _0021_00210 : Timer
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				break;
			case 0:
			case 5:
				num = (((P_3 ^ P_2) - 90) ^ num2) switch
				{
					0 => ⴃႠ[212] - 12385, 
					_ => 6, 
				};
				break;
			case 6:
				num = ⴍႭ[327] - 18877;
				break;
			case 7:
				P_0.Enabled = P_1;
				goto case 9;
			case 9:
			{
				num2++;
				int num3 = 6;
				int num4 = 134;
				num = ((670 <= num4 - num3 * 5) ? 1 : (ⴐ[316] - 29));
				break;
			}
			case 1:
			case 3:
				num = ⴍႤ[59] - 53752;
				break;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2, char P_3, char P_4) where _0021_00210 : string
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int result = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႤ[189] - 29619;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႭ[43] - 57285;
					continue;
				case 7:
					break;
				case 4:
					num2 = (((P_3 ^ P_4) - 104) ^ num) switch
					{
						0 => 10, 
						_ => ⴍႤ[287] - 10688, 
					};
					continue;
				case 2:
					result = P_2;
					num2 = ⴅ[143] - 176;
					continue;
				case 10:
					result = P_0.LastIndexOf(P_1, P_2);
					num2 = 1;
					continue;
				case 1:
				case 6:
					num++;
					goto case 0;
				case 0:
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					num2 = 8;
					continue;
				case 8:
					num2 = ((num3 % 2 != 0) ? (ⴀႼ[113] + 2) : 11);
					continue;
				case 11:
					return result;
				case 5:
				case 9:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}
}
