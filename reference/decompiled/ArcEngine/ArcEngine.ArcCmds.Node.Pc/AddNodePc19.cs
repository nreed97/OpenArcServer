using System;
using System.Collections;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Node.Pc;

public sealed class AddNodePc19 : IArcCmd
{
	private static readonly ILog Ⴗ;

	private static string Ⴗ;

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
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
					ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 312, 377);
					flag = Ⴀ(cmd);
					goto case 2;
				case 2:
					num = ⴄႤ[132] - 110;
					continue;
				case 8:
					ByeHelp.Ⴄ(obj as PrecisionTimer, 'ǂ', 401);
					goto case 1;
				case 1:
					num = ((!flag) ? (ⴀႼ[139] - 7) : (ⴃႠ[126] - ⴃႠ[126]));
					continue;
				case 0:
				{
					ILog ⴗ2 = AddNodePc19.Ⴗ;
					Array array2 = new object[4];
					(array2 as object[])[0] = obj as PrecisionTimer;
					((object[])array2)[1] = cmd.Ⴍ().Call;
					(array2 as object[])[2] = SetStationClubHelp.Ⴍ(4, 3, 1747257859, null);
					(array2 as object[])[3] = cmd.Rx.Msg;
					ⴗ2.Info(SetDxDefaultHelp.Ⴍ((object[])array2, 'ω', 928));
					num = 5;
					continue;
				}
				case 5:
					cmd.Tx.Pcxx = cmd.Rx.Msg;
					cmd.Tx.DistroType = DistroType.ToPcxxNodes;
					goto case 9;
				case 9:
					num = 7;
					continue;
				case 7:
				{
					object obj2 = new Publisher();
					((Publisher)obj2).Process(cmd);
					num = 6;
					continue;
				}
				case 10:
				{
					ILog ⴗ = AddNodePc19.Ⴗ;
					Array array = new object[4];
					((object[])array)[0] = (PrecisionTimer)obj;
					(array as object[])[1] = cmd.Ⴍ().Call;
					(array as object[])[2] = SetStationClubHelp.Ⴍ(5, 3, 1747257859, null);
					((object[])array)[3] = cmd.Rx.Msg;
					ⴗ.Warn(SetDxDefaultHelp.Ⴍ(array as object[], 'Ģ', 331));
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
			ILog ⴗ3 = AddNodePc19.Ⴗ;
			Array array3 = new string[5];
			(array3 as string[])[0] = cmd.Ⴍ().Call;
			(array3 as string[])[1] = SetStationClubHelp.Ⴍ(10, 3, 1747257859, null);
			((string[])array3)[2] = cmd.Rx.Msg;
			((string[])array3)[3] = ႰႥ.Ⴅ(5, 'ß', 952620215);
			((string[])array3)[4] = (ex as Exception).Message;
			ⴗ3.Warn(string.Concat((string[])array3));
		}
		switch (3)
		{
		}
	}

	private static bool Ⴀ(NodeUserCmd P_0)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		Array array = default(Array);
		int num2 = default(int);
		IComparable<string> comparable3 = default(IComparable<string>);
		IConvertible convertible = default(IConvertible);
		IComparable<string> comparable = default(IComparable<string>);
		IComparable comparable2 = default(IComparable);
		object obj2 = default(object);
		while (true)
		{
			int num = ((!Ⴓ(P_0)) ? 6 : (ⴅ[278] - 38));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႷ[49] - 17971;
					continue;
				case 1:
					break;
				case 9:
				case 16:
					return false;
				case 4:
				case 6:
				{
					string msg = P_0.Rx.Msg;
					object obj = new char[1];
					(obj as char[])[0] = '^';
					array = Directory.Ⴓ(msg, obj as char[], 357, 307);
					num = 17;
					continue;
				}
				case 17:
					num2 = 1;
					num = 10;
					continue;
				case 15:
					comparable3 = (array as string[])[num2];
					convertible = ((string[])array)[num2 + 1];
					num = ⴀႣ[164] - 50241;
					continue;
				case 20:
					comparable = ((string[])array)[num2 + 2];
					comparable2 = (array as string[])[num2 + 3];
					num = 7;
					continue;
				case 7:
					num = ((!ByeHelp.Ⴍ(convertible as string, P_0.Ⴍ().Call, 71, 32)) ? (ⴄႤ[394] - ⴄႤ[270]) : (ⴅ[193] - 185));
					continue;
				case 11:
					P_0.Ⴍ().ConnectState = ConnectStateType.PcxxNode;
					P_0.Ⴍ().Here = comparable3 as string;
					P_0.Ⴍ().Ⴄ(comparable as string);
					num = 3;
					continue;
				case 3:
					P_0.Ⴍ().SwVersion = comparable2 as string;
					num = ⴀႳ[204] - 27639;
					continue;
				case 0:
				{
					object obj3 = P_0.Ⴍ().ႣႤ((string)convertible);
					num = ((obj3 is ArcConnect) ? 13 : 14);
					continue;
				}
				case 14:
					obj2 = new ArcConnect(P_0.Ⴍ().Ⴅ(), (string)convertible);
					(obj2 as ArcConnect).Here = comparable3 as string;
					num = ⴀႼ[81] - 30;
					continue;
				case 19:
					((ArcConnect)obj2).Ⴄ((string)comparable);
					goto case 12;
				case 12:
					((ArcConnect)obj2).SwVersion = comparable2 as string;
					num = ⴄႤ[135];
					continue;
				case 5:
					(obj2 as ArcConnect).Ⴓ(P_0.Ⴍ());
					((ArcConnect)obj2).ConnectState = ConnectStateType.PcxxNode;
					(obj2 as ArcConnect).Ⴅ(true);
					num = ⴅ[177] / 8;
					continue;
				case 18:
				{
					((ArcConnect)obj2).Ⴀ(true);
					BaseXmlSerializer baseXmlSerializer = obj2 as ArcConnect;
					P_0.Ⴍ().Ⴜ(baseXmlSerializer as ArcConnect);
					goto case 13;
				}
				case 13:
					num2 += 4;
					num = ⴐ[308] - 97;
					continue;
				case 10:
					num = ((num2 < (array as string[]).Length - 2) ? 15 : 2);
					continue;
				case 2:
					return true;
				}
				break;
			}
		}
	}

	private static bool Ⴓ(NodeUserCmd P_0)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		while (true)
		{
			IEnumerable enumerable = LogEntry.Ⴄ(P_0.Rx.Msg, 'ǭ', 452);
			int num = ((!ByeHelp.Ⴍ(enumerable as string, Ⴗ, 831, 856)) ? 3 : (ⴃႥ[94] - 31076));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႰ[201] - 21673;
					continue;
				case 1:
				case 2:
				case 6:
					break;
				case 0:
					P_0.Rx.Msg = ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216133565, 8, 'æ'), P_0.Rx.Msg, 186, 244);
					num = ⴍႭ[93] - 2061;
					continue;
				case 5:
					P_0.Tx.DistroType = DistroType.ToNil;
					return true;
				case 3:
				case 7:
					Ⴗ = enumerable as string;
					IpLockoutCacheCfg.ႭႭ[224] = (char)((IpLockoutCacheCfg.ႭႭ[224] * IpLockoutCacheCfg.ႭႭ[356]) & 0x41);
					return false;
				}
				break;
			}
		}
	}

	static AddNodePc19()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				AddNodePc19.Ⴗ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216132936, 4, '5'), 186, 167);
				break;
			case 2:
				break;
			case 3:
				Ⴗ = string.Empty;
				return;
			case 1:
			case 4:
				return;
			}
			num = ⴀႨ[121] - 387;
		}
	}
}
