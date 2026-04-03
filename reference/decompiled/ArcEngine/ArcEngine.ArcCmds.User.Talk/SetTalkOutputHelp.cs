using System.Data;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Talk;

public sealed class SetTalkOutputHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 5;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(2, null, 1267015706, typeof(SetAnnWrapHelp)));
				goto case 3;
			case 3:
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132769, 3, '\u001e'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(29, null, 1057166153, 1));
				goto case 6;
			case 6:
				num = ⴅ[371] - 122;
				break;
			case 1:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(3, 'k', 952621759));
				obj = new Publisher();
				num = 0;
				break;
			case 0:
				((Publisher)obj).Process(cmd);
				return;
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, int P_3, int P_4) where _0021_00210 : string
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႭ[219] - 190;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 9:
				case 10:
					break;
				case 0:
				case 5:
					num2 = (((P_4 ^ P_3) - 83) ^ num) switch
					{
						0 => 1, 
						_ => ⴀႼ[2] / 3, 
					};
					continue;
				case 4:
				case 6:
					obj = null;
					num2 = 7;
					continue;
				case 1:
					obj = P_0.Substring(P_1, P_2);
					num2 = 7;
					continue;
				case 7:
				{
					num++;
					int num3 = 290;
					int num4 = 20;
					num2 = ((145 < num3 / 2 - num4) ? (ⴐ[278] - ⴐ[208]) : 8);
					continue;
				}
				case 8:
					return (string)obj;
				case 3:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataRow[] Ⴅ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : string where _0021_00211 : DataTable
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		object obj = default(object);
		int num3 = default(int);
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
					num2 = ⴄႷ[0] - 19551;
					continue;
				case 7:
					break;
				case 8:
					num2 = (((P_2 ^ P_3) - 61) ^ num) switch
					{
						0 => 0, 
						_ => 3, 
					};
					continue;
				case 3:
					obj = null;
					num2 = 6;
					continue;
				case 0:
				case 1:
				case 9:
					obj = P_0.Select(P_1);
					num2 = 6;
					continue;
				case 6:
					num++;
					goto case 2;
				case 2:
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴀ[431] - 3484;
					continue;
				case 5:
					num2 = ((num3 % 2 != 0) ? 8 : 11);
					continue;
				case 11:
					return (DataRow[])obj;
				case 10:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}
}
