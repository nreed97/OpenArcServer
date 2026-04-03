using System.Security;
using System.Xml.Linq;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowPerformance : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				break;
			case 1:
				break;
			case 2:
			case 4:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
			cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetTalkCount.Ⴗ(4, null, 1267021903, typeof(AnnWxArx)), SetTalkDefault.Ⴅ('ʖ', 688), 275, 349));
			num = ⴐ[243] / 4;
		}
	}

	[SecuritySafeCritical]
	internal static XElement Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : string
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		XContainer xContainer = default(XContainer);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႤ[178] - 19;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 1;
					continue;
				case 1:
					break;
				case 4:
				case 7:
				case 10:
				{
					int num3 = P_1 ^ P_2;
					SetAnnMode.ႤႭ[253] = (byte)((SetAnnMode.ႤႭ[253] - AnnCacheCfg.ႠႼ[35]) & 0x90);
					num2 = ((num3 - 72) ^ num) switch
					{
						0 => ⴀႨ[62] - 24116, 
						_ => 5, 
					};
					continue;
				}
				case 5:
					xContainer = null;
					num2 = 3;
					continue;
				case 9:
					xContainer = XElement.Parse(P_0);
					num2 = 3;
					continue;
				case 3:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴄႷ[26] - 9166) : (ⴄႭ[238] - 150));
					continue;
				case 11:
					num2 = 4;
					continue;
				case 2:
					return (XElement)xContainer;
				case 8:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}
}
