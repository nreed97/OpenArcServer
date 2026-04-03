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
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Node.Pc;

public sealed class DeleteUserPc17 : IArcCmd
{
	private static readonly ILog m_Ⴗ;

	private static string m_Ⴐ;

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		try
		{
			int num = 0;
			object obj = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 239, 174);
					flag = Ⴗ(cmd);
					num = ⴃႰ[52] - 57982;
					continue;
				case 5:
					ByeHelp.Ⴄ(obj as PrecisionTimer, '\u0344', 791);
					num = ((!flag) ? 4 : 6);
					continue;
				case 6:
				{
					ILog ⴗ2 = DeleteUserPc17.m_Ⴗ;
					object obj3 = new object[4];
					(obj3 as object[])[0] = (PrecisionTimer)obj;
					(obj3 as object[])[1] = cmd.Ⴍ().Call;
					(obj3 as object[])[2] = SetStationClubHelp.Ⴍ(3, 7, 1747257863, null);
					((object[])obj3)[3] = cmd.Rx.Msg;
					ⴗ2.Info(SetDxDefaultHelp.Ⴍ((object[])obj3, 'ƭ', 452));
					goto case 8;
				}
				case 8:
					num = 7;
					continue;
				case 7:
					cmd.Tx.Pcxx = cmd.Rx.Msg;
					cmd.Tx.DistroType = DistroType.ToPcxxNodes;
					num = ⴍႭ[169] - 60526;
					continue;
				case 1:
				{
					object obj2 = new Publisher();
					((Publisher)obj2).Process(cmd);
					goto case 9;
				}
				case 9:
					num = ⴄႷ[26] - 9158;
					continue;
				case 4:
				{
					ILog ⴗ = DeleteUserPc17.m_Ⴗ;
					Array array = new object[4];
					(array as object[])[0] = obj as PrecisionTimer;
					((object[])array)[1] = cmd.Ⴍ().Call;
					((object[])array)[2] = SetStationClubHelp.Ⴍ(4, 3, 1747257859, null);
					(array as object[])[3] = cmd.Rx.Msg;
					ⴗ.Warn(SetDxDefaultHelp.Ⴍ(array as object[], 'º', 211));
					break;
				}
				case 10:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ILog ⴗ3 = DeleteUserPc17.m_Ⴗ;
			object obj4 = new string[5];
			((string[])obj4)[0] = cmd.Ⴍ().Call;
			((string[])obj4)[1] = SetStationClubHelp.Ⴍ(15, 4, 1747257860, null);
			(obj4 as string[])[2] = cmd.Rx.Msg;
			(obj4 as string[])[3] = ႰႥ.Ⴅ(8, 'f', 952620218);
			(obj4 as string[])[4] = ex.Message;
			ⴗ3.Warn(string.Concat(obj4 as string[]));
		}
		switch (0)
		{
		}
	}

	private static bool Ⴗ(NodeUserCmd P_0)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		Array array = default(Array);
		IComparable comparable = default(IComparable);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		object obj = default(object);
		while (true)
		{
			int num = ((!Ⴐ(P_0)) ? 9 : 6);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 3:
				case 10:
					break;
				case 6:
					return false;
				case 9:
				{
					string msg = P_0.Rx.Msg;
					object obj2 = new char[1];
					((char[])obj2)[0] = '^';
					array = Directory.Ⴓ(msg, obj2 as char[], 652, 730);
					num = ⴀႼ[136];
					continue;
				}
				case 1:
				case 5:
					comparable = ((string[])array)[1];
					enumerable = (array as string[])[2];
					num = 4;
					continue;
				case 4:
					obj = P_0.Ⴍ().ႣႤ(enumerable as string);
					num = ((!(obj is ArcConnect)) ? 7 : 8);
					continue;
				case 8:
					(obj as ArcConnect).ႣႭ(comparable as string);
					goto case 0;
				case 0:
				case 7:
					return true;
				}
				break;
			}
		}
	}

	private static bool Ⴐ(NodeUserCmd P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		while (true)
		{
			object obj = LogEntry.Ⴄ(P_0.Rx.Msg, ';', 18);
			int num = ((!ByeHelp.Ⴍ(obj as string, DeleteUserPc17.m_Ⴐ, 843, 812)) ? 3 : (ⴀ[406] - 26251));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႠ[141] - 44678;
					continue;
				case 1:
				case 6:
					break;
				case 7:
					P_0.Rx.Msg = ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216133555, 6, 'Ê'), P_0.Rx.Msg, 942, 992);
					num = ⴍႤ[430] - ⴍႤ[430];
					continue;
				case 0:
				case 4:
					P_0.Tx.DistroType = DistroType.ToNil;
					return true;
				case 3:
					DeleteUserPc17.m_Ⴐ = (string)obj;
					return false;
				}
				break;
			}
		}
	}

	static DeleteUserPc17()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				DeleteUserPc17.m_Ⴗ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216132021, 4, 'I'), 328, 341);
				break;
			case 3:
				break;
			case 1:
			case 2:
				DeleteUserPc17.m_Ⴐ = string.Empty;
				return;
			case 4:
				return;
			}
			num = 2;
		}
	}
}
