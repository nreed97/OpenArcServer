using System;
using System.Collections.Generic;
using System.Data;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces.Io;
using ArcShared;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class ReadMail : IArcCmd
{
	private static void Ⴍ(NodeUserCmd P_0)
	{
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 1:
				obj = new ReadMailHelp();
				break;
			case 3:
			case 4:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(8, 4, 1157903443), P_0.Rx.Msg, 962, 908));
			num = 1;
		}
		((ReadMailHelp)obj).Exec(P_0);
		object obj2 = new Publisher();
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		try
		{
			int num = 7;
			IEquatable<string> equatable = default(IEquatable<string>);
			Array array = default(Array);
			object obj2 = default(object);
			DateTime dateTime = default(DateTime);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 2) ? 19 : (ⴄႷ[47] - 19224));
					continue;
				case 2:
					num = ((!SkimmerValidSpot.Ⴈ(cmd.Rx.Split[1], 766, 650)) ? (ⴀႨ[42] - 24435) : 17);
					continue;
				case 17:
					equatable = ShowUsersHelp.Ⴅ(SetStationClubHelp.Ⴍ(5, 3, 1747258068, null), cmd.Rx.Split[1], 1018, 948);
					num = ⴃႠ[3] - 45663;
					continue;
				case 1:
					array = cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႨ()
						.Ⴀ((string)equatable);
					goto case 3;
				case 3:
					num = (((array as DataRow[]).Length <= 0) ? 5 : 16);
					continue;
				case 16:
					obj2 = (array as DataRow[])[0];
					num = (ByeHelp.Ⴍ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ((DataRow)obj2, SetStationClubHelp.Ⴍ(10, 4, 1747258014, null), 575, 'ɱ'), '®', 197), ReplyMail.Ⴅ(3, 7, 1217944757), 527, 616) ? (ⴐ[324] - ⴐ[105]) : (ⴄႭ[537] - ⴄႭ[17]));
					continue;
				case 9:
					num = (ByeHelp.Ⴍ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(obj2 as DataRow, SetStationClubHelp.Ⴍ(4, 5, 1747258015, null), 611, 'ȭ'), 'ɼ', 535), cmd.Ⴍ().Ⴀ(), 864, 775) ? 11 : 10);
					continue;
				case 10:
					num = (ByeHelp.Ⴍ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(obj2 as DataRow, ReplyMail.Ⴅ(0, 8, 1217944712), 1009, 'ο'), 'Ŧ', 269), cmd.Ⴍ().Ⴀ(), 114, 21) ? 11 : (ⴀႣ[174] - ⴀႣ[174]));
					continue;
				case 0:
					num = ((!ByeHelp.Ⴍ(cmd.Ⴍ().Ⴀ(), ReplyMailHelp.Ⴄ(29, null, 1057167298, 4), 11, 108)) ? 4 : 11);
					continue;
				case 11:
					dateTime = SetAnnWrap.Ⴍ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(obj2 as DataRow, ႰႥ.Ⴅ(8, '8', 952620229), 8, 'F'), 'r', 25), 913, 'Ϟ');
					num = 14;
					continue;
				case 14:
				{
					List<string> msg = cmd.Tx.Msg;
					object obj3 = new object[8];
					(obj3 as object[])[0] = ShowSkimCtyHelp.Ⴍ(1216129928, 4, 'W');
					((object[])obj3)[1] = cmd.Rx.Split[1];
					(obj3 as object[])[2] = SetStationQth.Ⴍ(null, 1687354799, 0, 18);
					((object[])obj3)[3] = qslinfoSoapClient.Ⴓ((DataRow)obj2, ReplyMail.Ⴅ(1, 12, 1217944713), 672, 'ˮ');
					(obj3 as object[])[4] = ShowSkimCtyHelp.Ⴍ(1216129942, 2, 'Ð');
					((object[])obj3)[5] = ShowAnnOptionsHelp.Ⴗ(ref dateTime, ShowWxHelp.Ⴍ('ý', 985808356, 5), 380, 376);
					((object[])obj3)[6] = SetStationClubHelp.Ⴍ(12, 5, 1747262888, null);
					((object[])obj3)[7] = qslinfoSoapClient.Ⴓ((DataRow)obj2, ShowWxHelp.Ⴍ('æ', 985808769, 6), 380, 'Ĳ');
					msg.Add(string.Concat((object[])obj3));
					num = 6;
					continue;
				}
				case 6:
					cmd.Tx.Msg.Add(((DataRow)obj2)[ႨႨ.Ⴀ(3, 1, 1157903570)].ToString());
					num = ⴀႨ[10] - 37128;
					continue;
				case 4:
					cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 0, 62061808, null));
					num = 15;
					continue;
				case 5:
				case 8:
					cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(11, 6, 1747257919, null));
					goto case 15;
				case 15:
				{
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					num = ⴄႷ[85] - 6774;
					continue;
				}
				case 18:
				case 19:
					Ⴍ(cmd);
					break;
				case 13:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴍ(cmd);
		}
		switch (4)
		{
		}
	}

	[SecuritySafeCritical]
	internal static ServerIoType Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : ServerIoCfg
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		ServerIoType result = default(ServerIoType);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႣ[422] - 53522;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႨ[181] - 3881;
					continue;
				case 11:
					break;
				case 5:
				case 10:
					num2 = (((P_2 ^ P_1) - 79) ^ num) switch
					{
						0 => 2, 
						_ => ⴃႰ[41] - ⴃႰ[41], 
					};
					continue;
				case 0:
					result = ServerIoType.Telnet;
					num2 = 1;
					continue;
				case 2:
					result = P_0.Type;
					num2 = 1;
					continue;
				case 1:
				{
					num++;
					int num3 = 219;
					int num4 = 953;
					num2 = ((4765 > num4 - num3 * 5) ? (ⴃႰ[91] - 2597) : (ⴅ[112] - 108));
					continue;
				}
				case 4:
				case 6:
					num2 = 5;
					continue;
				case 3:
					return result;
				case 9:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Delegate Ⴈ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : Delegate where _0021_00211 : Delegate
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		ICloneable cloneable = default(ICloneable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 7;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 9:
					break;
				case 7:
					num2 = (((P_2 ^ P_3) - 78) ^ num) switch
					{
						0 => ⴃႥ[136] - 30630, 
						_ => ⴀႳ[180] - 40972, 
					};
					continue;
				case 3:
					cloneable = null;
					num2 = 4;
					continue;
				case 5:
					cloneable = Delegate.Remove(P_0, P_1);
					num2 = ⴍႭ[74] - 63173;
					continue;
				case 4:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 1;
					continue;
				case 1:
					num2 = ((num3 % 2 != 0) ? 7 : 11);
					continue;
				case 0:
				case 11:
					return cloneable as Delegate;
				case 6:
				case 8:
					num2 = ⴀ[391] - 53753;
					continue;
				}
				break;
			}
		}
	}
}
