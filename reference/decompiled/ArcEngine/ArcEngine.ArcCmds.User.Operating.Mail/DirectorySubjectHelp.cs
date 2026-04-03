using System.Net;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class DirectorySubjectHelp : IArcCmd
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
				goto case 6;
			case 6:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(1, null, 1267022832, typeof(ႥႭ)));
				goto case 1;
			case 1:
			case 4:
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133317, 3, 'w'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(0, null, 1057162012, 4));
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(2, '|', 952620080));
				obj = new Publisher();
				num = ⴅ[6];
				break;
			case 0:
				(obj as Publisher).Process(cmd);
				DirectoryBulletin.ႠႨ[37] = DirectoryBulletin.ႠႨ[37] & DirectoryBulletin.ႠႨ[36] & 0xFD;
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : string where _0021_00211 : StationCfg
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 6;
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
				num = (((P_2 ^ P_3) - 82) ^ num2) switch
				{
					0 => ⴃႰ[80] - 24199, 
					_ => 3, 
				};
				break;
			case 3:
				num = ⴀႼ[0] - ⴀႼ[128];
				break;
			case 1:
			case 4:
			case 9:
				P_0.Phone = P_1;
				goto case 7;
			case 7:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 2 : (ⴀ[391] - 53755));
				break;
			case 0:
			case 5:
				num = 8;
				break;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, char P_3) where _0021_00210 : WebRequest where _0021_00211 : IWebProxy
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 4;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				break;
			case 2:
			{
				int num5 = (P_2 ^ P_3) - 27;
				int num6 = num2;
				SetAnnChatRooms.Ⴀ[454] = (char)((SetAnnChatRooms.Ⴀ[454] + P_2) & 0xE2);
				num = (num5 ^ num6) switch
				{
					0 => 7, 
					_ => ⴀႣ[260] - 55977, 
				};
				break;
			}
			case 1:
				num = 5;
				break;
			case 7:
				P_0.Proxy = P_1;
				goto case 5;
			case 5:
				num2++;
				goto case 8;
			case 8:
				num3 = 128;
				num4 = 309;
				goto case 6;
			case 6:
				num = ((1854 > num4 - num3 * 6) ? (ⴀႨ[216] - ⴀႨ[216]) : 3);
				break;
			case 3:
				num = ⴀ[283] - 56624;
				break;
			case 0:
				return;
			}
		}
	}
}
