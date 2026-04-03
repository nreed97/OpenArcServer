using System;
using System.Collections;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using ArcShared.ArcIo.Tcp;

namespace Ⴈ;

internal sealed class ႷႥ : TcpServerClient
{
	private ႰႨ.ႥႠ Ⴗ;

	internal ႷႥ()
	{
	}

	internal ႷႥ(IIoClient P_0, string P_1)
	{
		Ⴗ.Ⴄ = P_0;
		Ⴗ.Ⴈ = P_1;
	}

	public override bool Send(string P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		object obj2 = default(object);
		int num2 = default(int);
		IEnumerable enumerable = default(IEnumerable);
		object obj3 = default(object);
		object obj4 = default(object);
		Array array2 = default(Array);
		int num4 = default(int);
		while (true)
		{
			base.LastSendDts = ShowAnnHelp.Ⴅ('ʼ', 653);
			object obj = new char[1];
			(obj as char[])[0] = '\n';
			Array array = Directory.Ⴓ(P_0, obj as char[], 283, 333);
			int num = 6;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 13;
					continue;
				case 13:
					break;
				case 6:
					obj2 = array as string[];
					num2 = 0;
					num = 12;
					continue;
				case 11:
					enumerable = ((string[])obj2)[num2];
					num = ((CallBlockCacheCfg.Ⴜ((string)enumerable, 118, 23) <= 0) ? 7 : (ⴄႤ[81] - ⴄႤ[51]));
					continue;
				case 9:
					obj3 = Ⴗ.Ⴈ;
					obj3 = ShowUsersHelp.Ⴅ(obj3 as string, SetStationClubHelp.Ⴍ(5, 0, 1747263043, null), 924, 978);
					num = 19;
					continue;
				case 19:
					obj3 = ShowUsersHelp.Ⴅ(obj3 as string, SetStationQth.Ⴍ(null, 1687353045, 1, 26), 675, 749);
					num = 8;
					continue;
				case 8:
					obj3 = AnnHelp.Ⴈ((string)obj3, enumerable as string, ReplyMail.Ⴅ(6, 13, 1217944249), 797, '\u032a');
					num = 2;
					continue;
				case 2:
					obj4 = ႰႭ.Ⴀ(ShowUptime.Ⴗ(995, 941), obj3 as string, 569, 621);
					num = 4;
					continue;
				case 4:
					array2 = LotwCacheCfg.Ⴈ(CallBlockCacheCfg.Ⴜ((string)enumerable, 870, 775) + 1, 312, 322);
					num = 10;
					continue;
				case 10:
					num4 = 0;
					num = ⴀႨ[81] - 36072;
					continue;
				case 14:
					((byte[])obj4)[28 + num4] = ((byte[])array2)[num4];
					goto case 18;
				case 18:
					num = ⴀႼ[100] - ⴀႼ[139];
					continue;
				case 1:
					num4++;
					num = 0;
					continue;
				case 0:
					num = ((num4 < 4) ? 14 : (ⴄႤ[140] - 70));
					continue;
				case 16:
					Ⴗ.Ⴄ.Send((byte[])obj4);
					num = 7;
					continue;
				case 7:
				{
					int num3 = num2;
					ShowSunHelp.ႣႠ[171] = (char)((ShowSunHelp.ႣႠ[171] ^ ShowSunHelp.ႣႠ[289]) & 0xAB);
					num2 = num3 + 1;
					num = 12;
					continue;
				}
				case 12:
					num = ((num2 < (obj2 as string[]).Length) ? (ⴀႨ[191] - 2538) : ⴄႤ[270]);
					continue;
				case 17:
					return true;
				}
				break;
			}
		}
	}

	public override void Disconnect()
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 6;
		IComparable<string> comparable = default(IComparable<string>);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				base.LastSendDts = ShowAnnHelp.Ⴅ('ƈ', 441);
				comparable = Ⴗ.Ⴈ;
				num = 2;
				break;
			case 2:
				comparable = ShowUsersHelp.Ⴅ(comparable as string, SetStationQth.Ⴍ(null, 1687353040, 4, 29), 157, 211);
				num = ⴀ[444] - 32946;
				break;
			case 7:
				comparable = ShowUsersHelp.Ⴅ((string)comparable, SetStationQth.Ⴍ(null, 1687353042, 6, 4), 663, 729);
				num = ⴀႼ[7] - 74;
				break;
			case 0:
			case 3:
			case 5:
				obj = ႰႭ.Ⴀ(ShowUptime.Ⴗ(150, 216), comparable as string, 751, 699);
				num = 4;
				break;
			case 1:
			case 4:
				((byte[])obj)[4] = 100;
				Ⴗ.Ⴄ.Send(obj as byte[]);
				return;
			}
		}
	}
}
