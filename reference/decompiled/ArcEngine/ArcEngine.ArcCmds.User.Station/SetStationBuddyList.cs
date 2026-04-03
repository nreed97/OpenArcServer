using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationBuddyList : IArcCmd
{
	private static void Ⴗ(NodeUserCmd P_0)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 2:
			case 3:
			case 4:
			{
				object obj = new SetStationBuddyListHelp();
				(obj as SetStationBuddyListHelp).Exec(P_0);
				break;
			}
			case 1:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(3, 0, 1157899746), P_0.Rx.Msg, 302, 352));
			num = 3;
		}
		object obj2 = new Publisher();
		(obj2 as Publisher).Process(P_0);
		ShowWwvOptionsHelp.ႣႥ[130] = (char)((ShowWwvOptionsHelp.ႣႥ[130] ^ ShowWwvOptionsHelp.ႣႥ[86]) & 0x68);
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		object obj = new Publisher();
		try
		{
			int num = 3;
			IComparable comparable = default(IComparable);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					goto case 7;
				case 7:
					num = ((cmd.Rx.Split.Length != 3) ? 11 : ⴄႤ[135]);
					continue;
				case 5:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ReplyMail.Ⴅ(6, 6, 1217942252));
					num = ⴃႰ[71] - 42565;
					continue;
				case 1:
					((Publisher)obj).Process(cmd);
					num = 8;
					continue;
				case 11:
					num = ((cmd.Rx.Split.Length < 4) ? (ⴃႰ[85] - 51295) : 6);
					continue;
				case 6:
					comparable = SetDxFilter.Ⴀ(cmd.Rx.GetMsgEnd(3), 124, '=');
					num = ((!Ⴐ(comparable as string)) ? (ⴃႰ[141] - 47835) : ⴅ[6]);
					continue;
				case 0:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					goto case 9;
				case 9:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetTalkCount.Ⴗ(5, null, 1267017226, typeof(ႥႭ)), comparable as string, 505, 439));
					num = ⴀႣ[16] - 8156;
					continue;
				case 13:
					((Publisher)obj).Process(cmd);
					num = ⴍႤ[145] - 19847;
					continue;
				case 4:
					Ⴗ(cmd);
					num = 8;
					continue;
				case 2:
				case 10:
					Ⴗ(cmd);
					break;
				case 8:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴗ(cmd);
		}
		switch (4)
		{
		}
	}

	private static bool Ⴐ(string P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		object obj = default(object);
		int num2 = default(int);
		while (true)
		{
			int num = ((CallBlockCacheCfg.Ⴜ(P_0, 999, 902) <= 0) ? 7 : 4);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴍႤ[145] - 19849;
					continue;
				case 6:
				case 9:
					break;
				case 4:
				{
					Array array = new char[1];
					(array as char[])[0] = ',';
					obj = Directory.Ⴓ(P_0, array as char[], 840, 798);
					num = 3;
					continue;
				}
				case 3:
					num2 = 0;
					num = ⴀႳ[4] - 24696;
					continue;
				case 5:
				case 8:
					num = (ႷႷ.Ⴍ(((string[])obj)[num2], 546, 'ȯ') ? 2 : (ⴃႥ[340] - 59154));
					continue;
				case 0:
					return false;
				case 2:
					num2++;
					num = ⴄႷ[66] - 17241;
					continue;
				case 1:
					num = ((num2 < ((string[])obj).Length) ? 5 : (ⴍႤ[337] - 1138));
					continue;
				case 7:
				case 11:
					return true;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static double Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		double result = default(double);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[121] - 246;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႭ[217] - 87;
					continue;
				case 3:
				case 5:
					break;
				case 0:
				case 7:
					num2 = (((P_1 ^ P_2) - 33) ^ num) switch
					{
						0 => 4, 
						_ => ⴍႤ[250] - 64095, 
					};
					continue;
				case 1:
				case 9:
					result = 0.4664599619884727;
					num2 = 2;
					continue;
				case 4:
					result = Convert.ToDouble(P_0);
					num2 = 2;
					continue;
				case 2:
				{
					num++;
					int num3 = 440;
					int num4 = 720;
					num2 = ((2880 > num4 - num3 * 4) ? 11 : 6);
					continue;
				}
				case 6:
					num2 = 7;
					continue;
				case 11:
					return result;
				case 10:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ<_0021_00210>(ref int P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : string
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[88] - 64335;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 10:
					break;
				case 8:
					num2 = (((P_3 ^ P_2) - 66) ^ num) switch
					{
						0 => ⴍႤ[445] - 61564, 
						_ => 5, 
					};
					continue;
				case 5:
					cloneable = null;
					num2 = 0;
					continue;
				case 2:
					cloneable = P_0.ToString(P_1);
					num2 = 0;
					continue;
				case 0:
				{
					num++;
					int num3 = 1260;
					int num4 = 106;
					num2 = ((315 < num3 / 4 - num4) ? (ⴀ[345] - 20394) : 6);
					continue;
				}
				case 4:
				case 6:
				case 7:
				case 9:
					return (string)cloneable;
				case 3:
					num2 = ⴃႰ[75] - 29851;
					continue;
				}
				break;
			}
		}
	}
}
