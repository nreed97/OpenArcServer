using System;
using System.Collections;
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
using ArcInterfaces;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Node.Pc;

public sealed class AddUserPc16 : IArcCmd
{
	private static readonly ILog Ⴓ;

	private static string Ⴈ;

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		try
		{
			int num = 4;
			object obj = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					goto case 2;
				case 2:
					ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 189, 252);
					flag = Ⴃ(cmd);
					goto case 5;
				case 5:
					num = 0;
					continue;
				case 0:
					ByeHelp.Ⴄ(obj as PrecisionTimer, ' ', 115);
					num = ((!flag) ? 6 : 3);
					continue;
				case 3:
				{
					ILog ⴓ2 = Ⴓ;
					Array array2 = new object[4];
					((object[])array2)[0] = (PrecisionTimer)obj;
					((object[])array2)[1] = cmd.Ⴍ().Call;
					((object[])array2)[2] = SetStationClubHelp.Ⴍ(8, 0, 1747257856, null);
					(array2 as object[])[3] = cmd.Rx.Msg;
					ⴓ2.Info(SetDxDefaultHelp.Ⴍ(array2 as object[], 'ɺ', 531));
					num = ⴃႠ[198] - 47722;
					continue;
				}
				case 8:
					cmd.Tx.Pcxx = cmd.Rx.Msg;
					cmd.Tx.DistroType = DistroType.ToPcxxNodes;
					num = 1;
					continue;
				case 1:
				{
					object obj2 = new Publisher();
					(obj2 as Publisher).Process(cmd);
					num = ⴄႭ[224] / 2;
					continue;
				}
				case 6:
				case 9:
				{
					ILog ⴓ = Ⴓ;
					Array array = new object[4];
					((object[])array)[0] = (PrecisionTimer)obj;
					(array as object[])[1] = cmd.Ⴍ().Call;
					((object[])array)[2] = SetStationClubHelp.Ⴍ(9, 2, 1747257858, null);
					(array as object[])[3] = cmd.Rx.Msg;
					ⴓ.Warn(SetDxDefaultHelp.Ⴍ(array as object[], 'ϭ', 900));
					break;
				}
				case 7:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ILog ⴓ3 = Ⴓ;
			Array array3 = new string[5];
			((string[])array3)[0] = cmd.Ⴍ().Call;
			(array3 as string[])[1] = SetStationClubHelp.Ⴍ(5, 4, 1747257860, null);
			(array3 as string[])[2] = cmd.Rx.Msg;
			(array3 as string[])[3] = ႰႥ.Ⴅ(4, '\v', 952620214);
			(array3 as string[])[4] = ex.Message;
			ⴓ3.Warn(string.Concat(array3 as string[]));
		}
		switch (2)
		{
		}
	}

	private static bool Ⴃ(NodeUserCmd P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		object obj = default(object);
		IComparable comparable2 = default(IComparable);
		object obj2 = default(object);
		BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
		int num2 = default(int);
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
		IEnumerable enumerable = default(IEnumerable);
		IEnumerable enumerable2 = default(IEnumerable);
		object obj4 = default(object);
		object obj3 = default(object);
		while (true)
		{
			int num = ((!Ⴅ(P_0)) ? (ⴅ[79] - 223) : 2);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 19;
					continue;
				case 19:
					break;
				case 2:
					return false;
				case 9:
				{
					string msg = P_0.Rx.Msg;
					object obj5 = new char[1];
					((char[])obj5)[0] = '^';
					obj = Directory.Ⴓ(msg, (char[])obj5, 734, 648);
					goto case 1;
				}
				case 1:
					num = 11;
					continue;
				case 11:
					comparable2 = (obj as string[])[1];
					obj2 = P_0.Ⴍ().ႣႤ(comparable2 as string);
					num = ⴀႨ[190] - 45586;
					continue;
				case 8:
					num = ((obj2 is ArcConnect) ? (ⴃႠ[376] - 48182) : (ⴀ[442] - 37338));
					continue;
				case 14:
					baseXmlSerializer = new ArcConnect(P_0.Ⴍ().Ⴅ(), (string)comparable2);
					(baseXmlSerializer as ArcConnect).Ⴓ(P_0.Ⴍ());
					goto case 22;
				case 22:
					num = 5;
					continue;
				case 5:
					((ArcConnect)baseXmlSerializer).ConnectState = ConnectStateType.PcxxNode;
					((ArcConnect)baseXmlSerializer).Ⴅ(true);
					((ArcConnect)baseXmlSerializer).Ⴀ(true);
					num = ⴀ[267] - 4767;
					continue;
				case 13:
					obj2 = (ArcConnect)baseXmlSerializer;
					P_0.Ⴍ().Ⴜ((ArcConnect)obj2);
					goto case 0;
				case 0:
					num2 = 2;
					num = 18;
					continue;
				case 15:
					comparable = (obj as string[])[num2];
					num3 = ShowNodes.Ⴄ((string)comparable, ႰႥ.Ⴅ(0, '\u008b', 952620210), 716, 755);
					num = 4;
					continue;
				case 4:
				{
					int num4;
					if (num2 > 0)
					{
						num4 = 10;
					}
					else
					{
						char num5 = ⴍႭ[89];
						SetAnnChatRooms.Ⴀ[47] = (char)((SetAnnChatRooms.Ⴀ[47] | SetAnnChatRooms.Ⴀ[265]) & 0x10);
						num4 = num5 - 16549;
					}
					num = num4;
					continue;
				}
				case 10:
					enumerable = SetTalkOutputHelp.Ⴍ(comparable as string, 0, num3, 506, 425);
					enumerable2 = Clear.Ⴄ((string)comparable, num3 + 3, '\u0338', '\u0310');
					num = ⴀ[305] - 12649;
					continue;
				case 20:
					obj4 = new ArcConnect(P_0.Ⴍ().Ⴅ(), (string)enumerable);
					(obj4 as ArcConnect).Here = (string)enumerable2;
					num = 12;
					continue;
				case 12:
					((ArcConnect)obj4).Ⴓ(obj2 as ArcConnect);
					(obj4 as ArcConnect).ConnectState = ConnectStateType.PcxxUser;
					((ArcConnect)obj4).Ⴅ(true);
					num = ⴄႤ[24] - 151;
					continue;
				case 17:
					(obj4 as ArcConnect).Ⴀ(true);
					obj3 = (ArcConnect)obj4;
					(obj2 as ArcConnect).ႣႭ(((ArcConnect)obj3).Call);
					num = ⴄႭ[120] - 82;
					continue;
				case 21:
					(obj2 as ArcConnect).Ⴜ(obj3 as ArcConnect);
					goto case 7;
				case 7:
					num2++;
					num = ⴄႷ[38] - 46331;
					continue;
				case 18:
					num = ((num2 < (obj as string[]).Length - 2) ? 15 : 16);
					continue;
				case 16:
					return true;
				}
				break;
			}
		}
	}

	private static bool Ⴅ(NodeUserCmd P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		while (true)
		{
			object obj = LogEntry.Ⴄ(P_0.Rx.Msg, 'ĩ', 256);
			int num = ((!ByeHelp.Ⴍ(obj as string, Ⴈ, 612, 515)) ? 6 : (ⴀႨ[212] - 27971));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 3:
					break;
				case 7:
					P_0.Rx.Msg = ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216133557, 0, 'G'), P_0.Rx.Msg, 213, 155);
					num = 5;
					continue;
				case 5:
					P_0.Tx.DistroType = DistroType.ToNil;
					return true;
				case 6:
					Ⴈ = obj as string;
					goto case 1;
				case 1:
				case 4:
					return false;
				}
				break;
			}
		}
	}

	static AddUserPc16()
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴓ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216134004, 0, '\u0087'), 829, 800);
				break;
			case 3:
			case 4:
				break;
			case 0:
			case 1:
				Ⴈ = string.Empty;
				return;
			}
			num = 1;
		}
	}
}
