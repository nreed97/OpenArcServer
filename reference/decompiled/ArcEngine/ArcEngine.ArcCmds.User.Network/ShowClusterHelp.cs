using System;
using System.Security;
using System.Text;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcInterfaces.Ui;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ShowClusterHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(1, null, 1267019579, typeof(SetStationNeedsHelp)));
				goto case 0;
			case 0:
				num = 4;
				break;
			case 4:
			case 5:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132403, 4, 'à'));
				goto case 6;
			case 6:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(30, null, 1057164831, 2));
				num = 1;
				break;
			case 1:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(6, 'é', 952620562));
				obj = new Publisher();
				num = 3;
				break;
			case 3:
				(obj as Publisher).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : StringBuilder
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 76) ^ num) switch
					{
						0 => ⴃႥ[83] - 54501, 
						_ => 1, 
					};
					continue;
				case 1:
					result = P_1;
					num2 = 3;
					continue;
				case 8:
				case 11:
					result = P_0.Length;
					num2 = 3;
					continue;
				case 3:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 10 : 2);
					continue;
				case 2:
					num2 = 6;
					continue;
				case 10:
					return result;
				case 7:
				case 9:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴃ(ref TimeSpan P_0, int P_1, char P_2)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 11;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[243];
					continue;
				case 8:
					break;
				case 5:
				case 11:
					num2 = (((P_2 ^ P_1) - 37) ^ num) switch
					{
						0 => 6, 
						_ => 3, 
					};
					continue;
				case 3:
					result = P_1;
					num2 = ⴄႷ[56] - 36248;
					continue;
				case 6:
				case 9:
					result = P_0.Seconds;
					num2 = ⴍႤ[461] - 37952;
					continue;
				case 0:
				case 7:
				{
					num++;
					int num3 = 53;
					int num4 = 673;
					num2 = ((1346 > num4 - num3 * 2) ? (ⴄႤ[293] - 119) : (ⴃႥ[132] - 23972));
					continue;
				}
				case 2:
					num2 = 11;
					continue;
				case 10:
					return result;
				case 4:
					num2 = ⴃႥ[13] - 37071;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, char P_3) where _0021_00210 : StatusBarData
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 10;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				break;
			case 8:
				num = (((P_3 ^ P_2) - 9) ^ num2) switch
				{
					0 => 0, 
					1 => 2, 
					_ => ⴃႰ[207] - 39489, 
				};
				break;
			case 5:
				num = 6;
				break;
			case 0:
			case 4:
				P_0.UserCnt = P_1;
				num = 6;
				break;
			case 2:
				P_0.NodeCnt = P_1;
				goto case 6;
			case 6:
				num2++;
				goto case 9;
			case 9:
			{
				int num3 = 77;
				int num4 = 92;
				num = ((644 <= num4 - num3 * 7) ? 1 : (ⴃႠ[77] - 34792));
				break;
			}
			case 1:
				num = 8;
				break;
			case 3:
				return;
			}
		}
	}
}
