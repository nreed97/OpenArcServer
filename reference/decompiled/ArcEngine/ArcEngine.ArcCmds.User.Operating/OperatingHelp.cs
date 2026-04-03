using System;
using System.Security;
using System.Xml;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Meebey.SmartIrc4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class OperatingHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(8, null, 1267023388, typeof(TalkCache)));
				num = 6;
				break;
			case 6:
			{
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133728, 7, '¦'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(25, null, 1057161473, 1));
				char num2 = ⴀ[464];
				ႨႣ.Ⴐ[192] = (byte)((ႨႣ.Ⴐ[192] * ႨႣ.Ⴐ[176]) & 0x1E);
				num = num2 - 29727;
				break;
			}
			case 2:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(4, 'M', 952620629));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 1, 62058461, null));
				goto case 10;
			case 10:
				num = ⴃႠ[378] - 16191;
				break;
			case 8:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(6, 6, 1217945206));
				cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(6, 6, 1747258288, null));
				num = ⴍႤ[417] - 41796;
				break;
			case 3:
				cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687351943, 1, 23));
				num = ⴄႭ[189] - ⴄႭ[101];
				break;
			case 9:
				cmd.Tx.Msg.Add(ႨႨ.Ⴀ(8, 5, 1157904049));
				cmd.Tx.Msg.Add(ShowWxHelp.Ⴍ('½', 985808509, 7));
				num = ⴃႰ[155] - 30436;
				break;
			case 5:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(1, null, 1267023517, typeof(SkimmerValidSpot)));
				num = 7;
				break;
			case 7:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133656, 7, 'G'));
				goto case 4;
			case 4:
				obj = new Publisher();
				num = ⴍႤ[481] - 37710;
				break;
			case 1:
			case 11:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : XmlNode
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		IComparable comparable = default(IComparable);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႣ[308] - 11281;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႥ[410] - 10986;
					continue;
				case 9:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 40) ^ num) switch
					{
						0 => 10, 
						_ => 3, 
					};
					continue;
				case 3:
					comparable = null;
					num2 = ⴅ[210] / 2;
					continue;
				case 7:
				case 10:
					comparable = P_0.InnerText;
					num2 = ⴃႠ[352] - 20324;
					continue;
				case 4:
				{
					num++;
					int num3 = 1436;
					int num4 = 84;
					num2 = ((718 < num3 / 2 - num4) ? (ⴍႭ[326] - 31894) : 2);
					continue;
				}
				case 2:
				case 5:
					return comparable as string;
				case 0:
				case 1:
					num2 = ⴀႣ[370] - 44214;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : EventHandler where _0021_00211 : IrcConnection
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 7;
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
				num = (((P_3 ^ P_2) - 21) ^ num2) switch
				{
					0 => ⴐ[37] - 177, 
					_ => ⴄႷ[52] - 60821, 
				};
				break;
			case 1:
				num = ⴍႭ[322] - 40084;
				break;
			case 2:
				P_0.OnConnected += P_1;
				goto case 0;
			case 0:
			case 9:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? 4 : 3);
				break;
			case 3:
				num = 8;
				break;
			case 4:
			case 5:
			case 6:
				return;
			}
		}
	}
}
