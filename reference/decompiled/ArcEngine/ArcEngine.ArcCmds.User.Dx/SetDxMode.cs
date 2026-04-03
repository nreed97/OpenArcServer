using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class SetDxMode : IArcCmd
{
	internal sealed class Ⴅ
	{
		internal string Ⴃ;

		internal string Ⴄ;

		internal Guid Ⴍ;

		internal Ⴅ()
		{
		}
	}

	private static void Ⴃ(NodeUserCmd P_0)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 4:
			{
				object obj = new SetDxModeHelp();
				((SetDxModeHelp)obj).Exec(P_0);
				break;
			}
			case 0:
			case 2:
			case 3:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(3, 6, 1157898780), P_0.Rx.Msg, 838, 776));
			num = 4;
		}
		object obj2 = new Publisher();
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		try
		{
			int num = 23;
			object obj = default(object);
			IComparable comparable = default(IComparable);
			IEquatable<string> equatable = default(IEquatable<string>);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					obj = new Publisher();
					num = ((cmd.Rx.Split.Length != 4) ? 2 : 5);
					continue;
				case 3:
				case 5:
					comparable = SetDxFilter.Ⴀ(cmd.Rx.Split[3], 676, '\u02e5');
					num = 20;
					continue;
				case 20:
					num = (((equatable = comparable as string) == null) ? 12 : 22);
					continue;
				case 22:
					num = ((!ByeHelp.Ⴍ(equatable as string, ႰႥ.Ⴅ(4, '\u008c', 952620618), 32, 71)) ? 1 : 21);
					continue;
				case 1:
					num = (ByeHelp.Ⴍ((string)equatable, SetStationClubHelp.Ⴍ(2, 1, 1747258296, null), 29, 122) ? 19 : (ⴃႠ[385] - 29480));
					continue;
				case 24:
					num = (ByeHelp.Ⴍ(equatable as string, ShowSkimCtyHelp.Ⴍ(1216134695, 7, '\u0018'), 359, 256) ? (ⴄႷ[44] - 49658) : ⴐ[80]);
					continue;
				case 14:
					num = (ByeHelp.Ⴍ((string)equatable, ShowWxHelp.Ⴍ('\u00a8', 985808496, 2), 747, 652) ? 15 : (ⴍႭ[328] - 34963));
					continue;
				case 13:
					num = 12;
					continue;
				case 0:
				case 21:
					DxClusterCacheCfg.Ⴅ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 768, 890), DxModeType.Open, 130, 235);
					num = 18;
					continue;
				case 18:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(0, null, 1267015635, typeof(DirectoryBulletin)));
					num = 11;
					continue;
				case 11:
					(obj as Publisher).Process(cmd);
					num = 4;
					continue;
				case 19:
					DxClusterCacheCfg.Ⴅ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 754, 648), DxModeType.Filter, 958, 983);
					num = ⴀႼ[0] - 32;
					continue;
				case 17:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(15, 3, 1157899200));
					num = 7;
					continue;
				case 7:
					(obj as Publisher).Process(cmd);
					num = ⴄႭ[465] - 65;
					continue;
				case 10:
					DxClusterCacheCfg.Ⴅ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 988, 934), DxModeType.Needs, 865, 776);
					num = 16;
					continue;
				case 16:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(13, 6, 1747260014, null));
					num = ⴀႳ[152] - 25343;
					continue;
				case 6:
					((Publisher)obj).Process(cmd);
					num = 4;
					continue;
				case 15:
					ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 939, 977).Mode = DxModeType.Debug;
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					num = ⴃႥ[122] - 48731;
					continue;
				case 25:
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216127250, 2, '*'));
					((Publisher)obj).Process(cmd);
					num = ⴅ[291] - 28;
					continue;
				case 12:
					Ⴃ(cmd);
					num = 4;
					continue;
				case 2:
					Ⴃ(cmd);
					break;
				case 4:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴃ(cmd);
		}
		switch (2)
		{
		}
	}

	[SecuritySafeCritical]
	internal static OleDbDataReader Ⴐ<_0021_00210>(_0021_00210 P_0, CommandBehavior P_1, int P_2, short P_3) where _0021_00210 : OleDbCommand
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		DbDataReader dbDataReader = default(DbDataReader);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႭ[94];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႷ[0] - 19552;
					continue;
				case 6:
					break;
				case 7:
					num2 = (((P_3 ^ P_2) - 38) ^ num) switch
					{
						0 => 5, 
						_ => ⴀႣ[35] - 33556, 
					};
					continue;
				case 3:
				case 4:
					dbDataReader = null;
					num2 = ⴄႤ[62] - 224;
					continue;
				case 5:
					dbDataReader = P_0.ExecuteReader(P_1);
					num2 = ⴄႤ[139] - 5;
					continue;
				case 9:
					num++;
					num3 = 43;
					goto case 10;
				case 10:
				{
					int num4 = 1016;
					num2 = ((3048 > num4 - num3 * 3) ? 1 : (ⴍႭ[213] - 31583));
					continue;
				}
				case 2:
					num2 = 7;
					continue;
				case 1:
					return (OleDbDataReader)dbDataReader;
				case 8:
					num2 = ⴀ[500] - 18574;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴍ(double P_0, char P_1, int P_2)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int result = default(int);
		int num3 = default(int);
		int num4 = default(int);
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
					num2 = ⴀႣ[106] - 1381;
					continue;
				case 5:
					break;
				case 0:
					num2 = (((P_2 ^ P_1) - 100) ^ num) switch
					{
						0 => 10, 
						_ => 3, 
					};
					continue;
				case 3:
					result = P_2;
					num2 = 4;
					continue;
				case 2:
				case 10:
					result = Convert.ToInt32(P_0);
					num2 = 4;
					continue;
				case 4:
					num++;
					num3 = 2634;
					num4 = 693;
					goto case 7;
				case 7:
					num2 = ((878 < num3 / 3 - num4) ? (ⴀႨ[73] - ⴀႨ[73]) : 9);
					continue;
				case 9:
					return result;
				case 1:
				case 6:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}
}
