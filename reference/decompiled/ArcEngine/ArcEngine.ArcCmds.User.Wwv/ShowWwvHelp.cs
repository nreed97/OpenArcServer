using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wwv;

public sealed class ShowWwvHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 6;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267022709, typeof(ႨႤ)));
				num = 0;
				break;
			case 0:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133241, 7, 'Y'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(1, null, 1057162049, 1));
				goto case 3;
			case 3:
			case 4:
				num = 1;
				break;
			case 1:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(2, 's', 952620140));
				goto case 5;
			case 5:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 3, 62057793, null));
				num = ⴃႠ[17] - 62736;
				break;
			case 2:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		bool result = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႼ[96];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႣ[143] - 38513;
					continue;
				case 5:
					break;
				case 3:
				case 4:
					num2 = (((P_1 ^ P_2) - 36) ^ num) switch
					{
						0 => 0, 
						1 => 6, 
						2 => 1, 
						3 => 2, 
						_ => ⴄႤ[134] - 69, 
					};
					continue;
				case 7:
					result = false;
					num2 = 10;
					continue;
				case 0:
				case 11:
					result = UtilsNumeric.IsFloat(P_0);
					num2 = 10;
					continue;
				case 6:
					result = UtilsDate.IsDate(P_0);
					num2 = ⴐ[36] - 174;
					continue;
				case 1:
					result = UtilsCallsign.IsWebBrowserOrJunk(P_0);
					num2 = 10;
					continue;
				case 2:
					result = UtilsLatLon.IsValidQra(P_0);
					num2 = 10;
					continue;
				case 10:
					num++;
					num3 = 216;
					num4 = 47;
					goto case 8;
				case 8:
					num2 = ((72 < num3 / 3 - num4) ? 4 : 13);
					continue;
				case 13:
					return result;
				case 9:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}
}
