using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Runtime.CompilerServices;
using System.Security;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared;
using ArcShared.MaintenanceUpdates;
using Common.Logging;
using Ⴈ;

namespace ArcEngine.ArcCmds;

public sealed class NodeUserCmd
{
	internal sealed class Ⴃ
	{
		internal long Ⴈ;

		internal long Ⴄ;

		internal Ⴃ()
		{
		}
	}

	private SetWxCountHelp.Ⴐ m_Ⴓ = new SetWxCountHelp.Ⴐ();

	public RxNodeUserCmd Rx
	{
		get
		{
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			return this.m_Ⴓ.Ⴃ;
		}
		set
		{
			this.m_Ⴓ.Ⴃ = value;
		}
	}

	public TxNodeUserCmd Tx
	{
		get
		{
			TxNodeUserCmd ⴀ = this.m_Ⴓ.Ⴀ;
			IpLockoutCacheCfg.ႭႭ[78] = (char)((IpLockoutCacheCfg.ႭႭ[78] + IpLockoutCacheCfg.ႭႭ[179]) & 0xA7);
			return ⴀ;
		}
		set
		{
			this.m_Ⴓ.Ⴀ = value as TxNodeUserCmd;
		}
	}

	[SpecialName]
	internal ArcConnect Ⴍ()
	{
		return this.m_Ⴓ.Ⴄ;
	}

	[SpecialName]
	internal void Ⴍ(ArcConnect P_0)
	{
		this.m_Ⴓ.Ⴄ = P_0 as ArcConnect;
	}

	internal NodeUserCmd(ArcConnect P_0)
	{
		Ⴍ(P_0);
		Rx = new RxNodeUserCmd();
		Tx = new TxNodeUserCmd();
	}

	public void Send(string msg)
	{
	}

	public void Send(string msg, bool addId)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!addId) ? 5 : 4);
				break;
			case 2:
			case 3:
			case 4:
				msg += qslinfoRequest.Ⴃ(Ⴍ().Call, Ⴍ().Ⴅ().Ⴓ().Call, 1014, 967);
				num = ⴄႭ[482] - ⴄႭ[58];
				break;
			case 0:
			case 5:
				return;
			}
		}
	}

	internal void Ⴀ()
	{
		Tx.Msg.Add(qslinfoRequest.Ⴃ(Ⴍ().Call, Ⴍ().Ⴅ().Ⴓ().Call, 416, 401));
	}

	[SecuritySafeCritical]
	internal static DataRow Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DataTable
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႤ[137] / 9;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 107) ^ num) switch
					{
						0 => 0, 
						_ => 2, 
					};
					continue;
				case 2:
				case 4:
				case 8:
					obj = null;
					num2 = ⴅ[419] - 61;
					continue;
				case 0:
					obj = P_0.NewRow();
					num2 = ⴀႨ[227] - 31313;
					continue;
				case 6:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 3;
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? (ⴄႤ[80] - 139) : 7);
					continue;
				case 7:
					return (DataRow)obj;
				case 1:
				case 10:
					num2 = ⴄႤ[519] - 37;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ILog Ⴗ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		object obj = default(object);
		int num3 = default(int);
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
					num2 = 2;
					continue;
				case 2:
					break;
				case 6:
				case 9:
					num2 = (((P_2 ^ P_1) - 109) ^ num) switch
					{
						0 => 1, 
						_ => 0, 
					};
					continue;
				case 0:
					obj = null;
					num2 = 10;
					continue;
				case 1:
					obj = LogManager.GetLogger(P_0);
					num2 = 10;
					continue;
				case 5:
				case 10:
					num++;
					goto case 3;
				case 3:
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 11;
					continue;
				case 11:
					num2 = ((num3 % 2 != 0) ? (ⴃႥ[270] - 59299) : (ⴃႠ[57] - 36028));
					continue;
				case 8:
					return obj as ILog;
				case 7:
					num2 = ⴄႭ[549] + 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, char P_3) where _0021_00210 : ConnectBlockUpdate where _0021_00211 : string
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 3;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 0;
				break;
			case 0:
			case 5:
				num = (((P_3 ^ P_2) - 15) ^ num3) switch
				{
					0 => 2, 
					_ => ⴃႥ[140] - 53419, 
				};
				break;
			case 6:
				num = ⴍႤ[301] - 2698;
				break;
			case 2:
				P_0.Download(P_1);
				goto case 1;
			case 1:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 4;
				break;
			case 4:
			case 7:
			case 9:
				num = ((num2 % 2 != 0) ? (ⴄႷ[58] - 48429) : (ⴄႤ[3] - 103));
				break;
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static SqlCeParameter Ⴈ<_0021_00210, _0021_00211, _0021_00212>(_0021_00212 P_0, _0021_00210 P_1, SqlDbType P_2, int P_3, _0021_00211 P_4, int P_5, short P_6) where _0021_00210 : string where _0021_00211 : string where _0021_00212 : SqlCeParameterCollection
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		DbParameter dbParameter = default(DbParameter);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႳ[350] - 4112;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[424] - 41943;
					continue;
				case 3:
					break;
				case 4:
					num2 = (((P_5 ^ P_6) - 33) ^ num) switch
					{
						0 => 7, 
						_ => 0, 
					};
					continue;
				case 0:
					dbParameter = null;
					goto case 5;
				case 5:
					num2 = ⴀႣ[313] - 23350;
					continue;
				case 7:
					dbParameter = P_0.Add(P_1, P_2, P_3, P_4);
					num2 = ⴃႠ[23] - 54148;
					continue;
				case 9:
				case 11:
					num++;
					num3 = P_6 * P_6;
					num3 = P_6 + num3;
					num2 = 1;
					continue;
				case 1:
					num2 = ((num3 % 2 != 0) ? (ⴍႭ[52] - 71) : (ⴄႷ[48] - 38959));
					continue;
				case 8:
				case 10:
					return dbParameter as SqlCeParameter;
				case 6:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long Ⴜ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		long result = default(long);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႣ[332] - 29266;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႳ[234] - 2331;
					continue;
				case 11:
					break;
				case 3:
					num2 = (((P_2 ^ P_1) - 81) ^ num) switch
					{
						0 => ⴅ[479] - 229, 
						_ => 6, 
					};
					continue;
				case 4:
				case 6:
					result = 12L;
					num2 = 2;
					continue;
				case 7:
					result = Convert.ToInt64(P_0);
					num2 = 2;
					continue;
				case 1:
				case 2:
				case 10:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴄႤ[65] / 6) : 9);
					continue;
				case 9:
					num2 = 3;
					continue;
				case 8:
					return result;
				case 5:
					num2 = ⴐ[47] + 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float ႳႠ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : string
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		float result = default(float);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႼ[138] - 62;
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
				case 6:
					num2 = (((P_1 ^ P_2) - 121) ^ num) switch
					{
						0 => 1, 
						_ => 3, 
					};
					continue;
				case 3:
					result = 0.3010336f;
					num2 = 8;
					continue;
				case 1:
				case 4:
					result = CtyInfo.ScrubLat(P_0);
					num2 = ⴀႼ[109] - ⴀႼ[89];
					continue;
				case 8:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 11 : ⴄႭ[66]);
					continue;
				case 0:
				case 2:
					num2 = 6;
					continue;
				case 11:
					return result;
				case 10:
					num2 = ⴀ[116] - 54176;
					continue;
				}
				break;
			}
		}
	}
}
