using System;
using System.Collections.Generic;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowVersion : IArcCmd
{
	private static void Ⴍ(NodeUserCmd P_0)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(5, 1, 1157899664), P_0.Rx.Msg, 1008, 958));
				break;
			case 0:
				break;
			case 3:
			case 4:
			{
				object obj = new ShowVersionHelp();
				((ShowVersionHelp)obj).Exec(P_0);
				object obj2 = new Publisher();
				(obj2 as Publisher).Process(P_0);
				ShowSunHelp.ႣႠ[303] = (char)((ShowSunHelp.ႣႠ[303] | Arc4ServerClient.ႠႣ[402]) & 0x14);
				return;
			}
			case 1:
				return;
			}
			num = 3;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		try
		{
			int num = 1;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					goto case 4;
				case 4:
					num = ((cmd.Rx.Split.Length != 2) ? (ⴐ[98] - 229) : 0);
					continue;
				case 0:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetStationQth.Ⴍ(null, 1687354545, 6, 12), ShowPrefixCallsHelp.Ⴐ(276, 363), 308, 378));
					num = 3;
					continue;
				case 3:
				case 6:
				case 7:
					cmd.Tx.Msg.Add(ShowVersionHelp.Ⴓ('ǡ', 413));
					obj = new Publisher();
					num = 9;
					continue;
				case 9:
					((Publisher)obj).Process(cmd);
					num = 8;
					continue;
				case 5:
					Ⴍ(cmd);
					break;
				case 8:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴍ(cmd);
		}
		switch (3)
		{
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴄ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int result = default(int);
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
					num2 = 6;
					continue;
				case 3:
				case 6:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 50) ^ num) switch
					{
						0 => ⴃႥ[52] - 46698, 
						_ => ⴃႰ[97] - 18248, 
					};
					continue;
				case 10:
					result = 9;
					num2 = 4;
					continue;
				case 1:
				case 2:
					result = Convert.ToInt32(P_0);
					num2 = ⴅ[386] - ⴅ[231];
					continue;
				case 4:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 8 : (ⴄႭ[579] - ⴄႭ[319]));
					continue;
				case 5:
					num2 = 0;
					continue;
				case 8:
					return result;
				case 11:
					num2 = ⴄႷ[49] - ⴄႷ[49];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DxSpot
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			int num = 0;
			int num2 = 12;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႨ[7] - 41575;
					continue;
				case 5:
					break;
				case 6:
				case 12:
					num2 = (((P_1 ^ P_2) - 124) ^ num) switch
					{
						0 => 9, 
						1 => ⴀႣ[213] - 57123, 
						2 => ⴀႨ[42] - 24447, 
						_ => 11, 
					};
					continue;
				case 11:
					enumerable = null;
					num2 = 2;
					continue;
				case 9:
					enumerable = P_0.Spotter;
					num2 = ⴄႷ[50] - 56637;
					continue;
				case 8:
					enumerable = P_0.Cty;
					num2 = ⴀႨ[46] - 49131;
					continue;
				case 4:
				case 7:
					enumerable = P_0.Mode;
					num2 = 2;
					continue;
				case 1:
				case 2:
				{
					num++;
					int num3 = 2208;
					int num4 = 183;
					num2 = ((736 < num3 / 3 - num4) ? 12 : 0);
					continue;
				}
				case 0:
					return (string)enumerable;
				case 3:
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}
}
