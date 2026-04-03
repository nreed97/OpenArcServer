using System.Runtime.Serialization;
using System.Security;
using System.Text;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.Wwv;

public sealed class WwvSpotUserHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267019894, typeof(DirectoryBulletin)));
				num = 4;
				break;
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216135107, 6, '\u0085'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(0, null, 1057162436, 0));
				goto case 2;
			case 2:
			case 3:
				num = 0;
				break;
			case 0:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(8, 'U', 952619642));
				obj = new Publisher();
				num = ⴄႤ[494] - 131;
				break;
			case 6:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static StringBuilder Ⴍ<_0021_00210>(_0021_00210 P_0, float P_1, char P_2, short P_3) where _0021_00210 : StringBuilder
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		ISerializable serializable = default(ISerializable);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[257];
					continue;
				case 7:
					break;
				case 1:
				case 10:
					num2 = (((P_2 ^ P_3) - 71) ^ num) switch
					{
						0 => ⴃႠ[376] - 48179, 
						_ => 9, 
					};
					continue;
				case 9:
					serializable = null;
					num2 = ⴃႰ[13] - 37062;
					continue;
				case 3:
					serializable = P_0.Append(P_1);
					num2 = ⴄႤ[114] - 201;
					continue;
				case 6:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 != 0) ? (ⴍႤ[119] - 12902) : 0);
					continue;
				case 2:
				case 5:
					num2 = 1;
					continue;
				case 0:
				case 4:
					return (StringBuilder)serializable;
				case 11:
					num2 = ⴀႳ[77] - 50337;
					continue;
				}
				break;
			}
		}
	}
}
