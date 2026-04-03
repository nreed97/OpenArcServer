using System;
using System.Collections.Generic;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Node.Pc;

public sealed class DeleteNodePc21 : IArcCmd
{
	private static readonly ILog Ⴀ;

	private static string Ⴅ;

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		try
		{
			int num = 7;
			object obj = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 799, 862);
					flag = Ⴃ(cmd);
					goto case 4;
				case 4:
					num = ⴀ[451] - 7735;
					continue;
				case 3:
					ByeHelp.Ⴄ((PrecisionTimer)obj, 'Ǽ', 431);
					num = ((!flag) ? 5 : 9);
					continue;
				case 1:
				case 9:
				case 10:
				{
					ILog ⴀ3 = Ⴀ;
					Array array2 = new object[4];
					((object[])array2)[0] = obj as PrecisionTimer;
					((object[])array2)[1] = cmd.Ⴍ().Call;
					((object[])array2)[2] = SetStationClubHelp.Ⴍ(3, 8, 1747257864, null);
					(array2 as object[])[3] = cmd.Rx.Msg;
					ⴀ3.Info(SetDxDefaultHelp.Ⴍ((object[])array2, 'ŏ', 294));
					num = 2;
					continue;
				}
				case 2:
					cmd.Tx.Pcxx = cmd.Rx.Msg;
					cmd.Tx.DistroType = DistroType.ToPcxxNodes;
					num = 8;
					continue;
				case 8:
				{
					object obj2 = new Publisher();
					(obj2 as Publisher).Process(cmd);
					num = 6;
					continue;
				}
				case 5:
				{
					ILog ⴀ2 = Ⴀ;
					Array array = new object[4];
					((object[])array)[0] = (PrecisionTimer)obj;
					(array as object[])[1] = cmd.Ⴍ().Call;
					(array as object[])[2] = SetStationClubHelp.Ⴍ(15, 7, 1747257863, null);
					((object[])array)[3] = cmd.Rx.Msg;
					ⴀ2.Warn(SetDxDefaultHelp.Ⴍ(array as object[], 'ʙ', 752));
					break;
				}
				case 6:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ILog ⴀ4 = Ⴀ;
			Array array3 = new string[5];
			((string[])array3)[0] = cmd.Ⴍ().Call;
			((string[])array3)[1] = SetStationClubHelp.Ⴍ(6, 7, 1747257863, null);
			(array3 as string[])[2] = cmd.Rx.Msg;
			(array3 as string[])[3] = ႰႥ.Ⴅ(8, '\u0088', 952620218);
			(array3 as string[])[4] = ex.Message;
			ⴀ4.Warn(string.Concat(array3 as string[]));
		}
		switch (2)
		{
		}
	}

	private static bool Ⴃ(NodeUserCmd P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		Array array2 = default(Array);
		object obj = default(object);
		while (true)
		{
			int num = ((!Ⴄ(P_0)) ? 7 : 6);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 5;
					continue;
				case 5:
					break;
				case 6:
					return false;
				case 7:
				{
					string msg = P_0.Rx.Msg;
					Array array = new char[1];
					(array as char[])[0] = '^';
					array2 = Directory.Ⴓ(msg, (char[])array, 207, 153);
					num = ⴃႠ[49] - 27487;
					continue;
				}
				case 4:
				{
					IEnumerable<char> enumerable = ((string[])array2)[1];
					obj = P_0.Ⴍ().ႣႤ((string)enumerable);
					num = 1;
					continue;
				}
				case 1:
				case 9:
					num = ((!(obj is ArcConnect)) ? (ⴀႳ[300] - 10818) : (ⴍႭ[225] - 31547));
					continue;
				case 10:
					((ArcConnect)obj).Ⴍ().ႣႼ(((ArcConnect)obj).Id);
					num = ⴀ[57] - 22272;
					continue;
				case 0:
					return true;
				}
				break;
			}
		}
	}

	private static bool Ⴄ(NodeUserCmd P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		while (true)
		{
			IComparable<string> comparable = LogEntry.Ⴄ(P_0.Rx.Msg, 'Ġ', 265);
			int num = ((!ByeHelp.Ⴍ(comparable as string, Ⴅ, 812, 843)) ? (ⴅ[332] - 220) : (ⴀႨ[45] - 15627));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴐ[21];
					continue;
				case 3:
					break;
				case 6:
					P_0.Rx.Msg = ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216133565, 8, 'ß'), P_0.Rx.Msg, 586, 516);
					num = ⴀႨ[82] - 5765;
					continue;
				case 7:
					P_0.Tx.DistroType = DistroType.ToNil;
					return true;
				case 1:
				case 2:
					Ⴅ = comparable as string;
					goto case 0;
				case 0:
				case 5:
					return false;
				}
				break;
			}
		}
	}

	static DeleteNodePc21()
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴀ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216132476, 7, '\v'), 297, 308);
				break;
			case 3:
				break;
			case 4:
				Ⴅ = string.Empty;
				return;
			case 0:
			case 1:
				return;
			}
			num = ⴄႷ[1] - 43577;
		}
	}
}
