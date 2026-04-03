using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Meebey.SmartIrc4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class DirectorySubject : IArcCmd
{
	internal sealed class Ⴃ
	{
		internal string Ⴅ;

		internal bool Ⴃ;

		internal string Ⴍ;

		internal string Ⴄ;

		internal string Ⴓ;

		internal string Ⴀ;

		internal Ⴃ()
		{
		}
	}

	private static void Ⴍ(NodeUserCmd P_0)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 3;
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 1:
				obj = new DirectorySubjectHelp();
				goto case 0;
			case 0:
			case 2:
				((DirectorySubjectHelp)obj).Exec(P_0);
				obj2 = new Publisher();
				break;
			case 4:
				break;
			}
			break;
			IL_0023:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(8, 1, 1157903446), P_0.Rx.Msg, 144, 222));
			num = ⴀႳ[119] - 55425;
		}
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		try
		{
			int num = 3;
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length <= 2) ? 8 : (ⴀႨ[27] - 10518));
					continue;
				case 2:
				{
					IEnumerable msgEnd = cmd.Rx.GetMsgEnd(2);
					enumerable = AnnHelp.Ⴈ(SetStationQth.Ⴍ(null, 1687351656, 1, 28), (string)msgEnd, ႰႥ.Ⴅ(3, ']', 952620483), 337, 'Ŧ');
					num = 1;
					continue;
				}
				case 1:
					MailHelper.ProcessDir(cmd, 20, (string)enumerable);
					obj = new Publisher();
					goto case 5;
				case 5:
				case 7:
					((Publisher)obj).Process(cmd);
					num = 6;
					continue;
				case 8:
					Ⴍ(cmd);
					break;
				case 4:
				case 6:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴍ(cmd);
		}
		switch (0)
		{
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : IrcConnection
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
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
					num2 = 6;
					continue;
				case 6:
					break;
				case 8:
				case 9:
					num2 = (((P_1 ^ P_2) - 54) ^ num) switch
					{
						0 => 2, 
						_ => 5, 
					};
					continue;
				case 5:
					result = false;
					num2 = ⴀႣ[271] - 32453;
					continue;
				case 2:
					result = P_0.IsConnected;
					num2 = 11;
					continue;
				case 4:
				case 11:
				{
					num++;
					int num3 = 262;
					int num4 = 425;
					int num5 = num3 * 5;
					ShowSunHelp.ႣႠ[258] = (char)((ShowSunHelp.ႣႠ[258] ^ P_2) & 0xCA);
					num2 = ((2125 > num4 - num5) ? 1 : 0);
					continue;
				}
				case 0:
					num2 = 8;
					continue;
				case 1:
					return result;
				case 3:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}
}
