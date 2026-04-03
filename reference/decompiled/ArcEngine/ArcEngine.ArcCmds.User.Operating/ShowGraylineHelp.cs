using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowGraylineHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267022837, typeof(SetStationGrid)));
				num = 5;
				break;
			case 5:
			case 6:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133326, 8, 'g'));
				goto case 0;
			case 0:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(12, null, 1057162012, 4));
				num = ⴀႣ[361] - 48465;
				break;
			case 1:
			case 4:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(8, 'U', 952620090));
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
	internal static long Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : Letter
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		long result = default(long);
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
					num2 = ⴍႭ[238] - 48052;
					continue;
				case 4:
					break;
				case 1:
					num2 = (((P_1 ^ P_2) - 53) ^ num) switch
					{
						0 => ⴍႭ[327] - ⴍႭ[145], 
						_ => 9, 
					};
					continue;
				case 9:
					result = 7L;
					num2 = ⴃႥ[369] - 3608;
					continue;
				case 6:
					result = P_0.MsgNum;
					num2 = ⴐ[204] / 3;
					continue;
				case 2:
				case 11:
				{
					int num3 = num;
					AnnCacheCfg.ႠႼ[32] = (byte)((AnnCacheCfg.ႠႼ[32] | AnnCacheCfg.ႠႼ[31]) & 0xB9);
					num = num3 + 1;
					goto case 10;
				}
				case 10:
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 8 : (ⴀႳ[241] - 40507));
					continue;
				case 5:
					num2 = ⴍႤ[345] - 45611;
					continue;
				case 8:
					return result;
				case 3:
					num2 = ⴀႣ[411] - 60778;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴅ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : MasterCallUpdate
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		bool result = default(bool);
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
					num2 = 4;
					continue;
				case 4:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 100) ^ num) switch
					{
						0 => ⴐ[250] - 216, 
						_ => ⴍႤ[193] - 9324, 
					};
					continue;
				case 3:
					result = true;
					num2 = 8;
					continue;
				case 11:
					result = P_0.VerifyCopyDelete();
					num2 = 8;
					continue;
				case 2:
				case 8:
					num++;
					goto case 7;
				case 7:
					num2 = (((P_2 * P_2 + P_2) % 2 != 0) ? 1 : (ⴀႣ[128] - 26887));
					continue;
				case 1:
					num2 = 6;
					continue;
				case 0:
				case 5:
					return result;
				case 9:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}
}
