using System;
using System.Security;
using System.Xml;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class DirectoryOwnHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 5;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(2, null, 1267022835, typeof(ႥႨ)));
				num = 3;
				break;
			case 3:
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133317, 3, '9'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(10, null, 1057162010, 2));
				num = ⴀႨ[160] - 46645;
				break;
			case 0:
			case 1:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(8, 'Ò', 952620090));
				goto case 2;
			case 2:
				obj = new Publisher();
				num = 6;
				break;
			case 6:
				(obj as Publisher).Process(cmd);
				SetTalkCountHelp.Ⴅ[7] = (byte)((SetTalkCountHelp.Ⴅ[7] - SetTalkCountHelp.Ⴅ[358]) & 0x85);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static XmlNode Ⴐ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : XmlNode where _0021_00211 : XmlNode
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႥ[223] - 25458;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 9:
					break;
				case 7:
					num2 = (((P_3 ^ P_2) - 87) ^ num) switch
					{
						0 => ⴀႨ[179] - 27570, 
						_ => 3, 
					};
					continue;
				case 3:
					cloneable = null;
					num2 = 5;
					continue;
				case 1:
					cloneable = P_0.AppendChild(P_1);
					num2 = 5;
					continue;
				case 5:
					num++;
					goto case 4;
				case 4:
				case 6:
				{
					int num3 = 424;
					int num4 = 860;
					num2 = ((6020 > num4 - num3 * 7) ? (ⴀႼ[34] - 239) : (ⴀႼ[113] * 4));
					continue;
				}
				case 8:
					num2 = 7;
					continue;
				case 10:
					return cloneable as XmlNode;
				case 0:
				case 11:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}
}
