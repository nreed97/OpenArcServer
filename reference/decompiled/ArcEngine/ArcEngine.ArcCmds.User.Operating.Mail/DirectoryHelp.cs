using System.Data;
using System.Security;
using System.Xml;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class DirectoryHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 3;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267022838, typeof(ShowHamQthHelp)));
				num = 4;
				break;
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133315, 5, '\u0006'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(29, null, 1057162009, 1));
				num = 6;
				break;
			case 5:
			case 6:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(2, '\u0013', 952620080));
				goto case 1;
			case 1:
				obj = new Publisher();
				goto case 2;
			case 2:
				num = ⴀႨ[17] - 11468;
				break;
			case 0:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataTableCollection Ⴀ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DataSet
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႰ[203] - 59423;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႤ[415] - 210;
					continue;
				case 2:
					break;
				case 10:
					num2 = (((P_2 ^ P_1) - 125) ^ num) switch
					{
						0 => 9, 
						_ => 6, 
					};
					continue;
				case 3:
				case 6:
					obj = null;
					num2 = 5;
					continue;
				case 7:
				case 9:
					obj = P_0.Tables;
					num2 = 5;
					continue;
				case 5:
				{
					num++;
					int num3 = 446;
					int num4 = 134;
					num2 = ((223 >= num3 / 2 - num4) ? 1 : 10);
					continue;
				}
				case 1:
					return (DataTableCollection)obj;
				case 0:
				case 4:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, short P_3) where _0021_00210 : string where _0021_00211 : XmlNode
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				break;
			case 5:
				num = (((P_2 ^ P_3) - 4) ^ num2) switch
				{
					0 => 6, 
					_ => 9, 
				};
				break;
			case 9:
				num = 4;
				break;
			case 3:
			case 6:
				P_0.InnerXml = P_1;
				goto case 4;
			case 4:
				num2++;
				goto case 0;
			case 0:
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴐ[62] - ⴐ[10]) : 2);
				break;
			case 1:
			case 2:
				num = 5;
				break;
			case 8:
				return;
			}
		}
	}
}
