using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arx;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowContestStationHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 3;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 2;
			case 2:
			case 4:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(5, null, 1267015221, typeof(ArxServerIo)));
				num = ⴀႳ[155] - ⴀႳ[155];
				break;
			case 0:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130614, 1, '\u0003'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(28, null, 1057166464, 2));
				num = 1;
				break;
			case 1:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(8, 'Ô', 952620883));
				obj = new Publisher();
				num = ⴅ[488] - 220;
				break;
			case 5:
			case 6:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210, _0021_00211, _0021_00212>(_0021_00212 P_0, _0021_00210 P_1, _0021_00211 P_2, int P_3, char P_4) where _0021_00210 : string where _0021_00211 : string where _0021_00212 : string
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		IConvertible convertible = default(IConvertible);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[20];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
					break;
				case 2:
				case 10:
					num2 = (((P_4 ^ P_3) - 88) ^ num) switch
					{
						0 => ⴐ[90] - 46, 
						_ => 0, 
					};
					continue;
				case 0:
					convertible = null;
					num2 = 5;
					continue;
				case 7:
					convertible = P_0.Replace(P_1, P_2);
					num2 = ⴄႤ[135];
					continue;
				case 5:
					num++;
					num3 = 768;
					num4 = 106;
					goto case 6;
				case 6:
				case 8:
					num2 = ((192 < num3 / 4 - num4) ? 10 : 4);
					continue;
				case 4:
					return convertible as string;
				case 1:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, int P_3) where _0021_00210 : DxSpot
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 4:
			case 6:
				num = (((P_2 ^ P_3) - 96) ^ num2) switch
				{
					0 => 9, 
					_ => 8, 
				};
				break;
			case 8:
				num = 5;
				break;
			case 9:
				P_0.IsSkimValid = P_1;
				goto case 5;
			case 5:
			{
				num2++;
				int num3 = 125;
				num = (((num3 * num3 + num3) % 2 != 0) ? 1 : (ⴃႰ[125] - 57499));
				break;
			}
			case 1:
				num = ⴍႤ[482] - 28472;
				break;
			case 0:
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : DirectoryMonitor where _0021_00211 : FileSystemEvent
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_2 ^ P_3) - 58) ^ num2) switch
				{
					0 => 3, 
					_ => ⴀႼ[33], 
				};
				break;
			case 9:
				num = ⴍႭ[53] - 47904;
				break;
			case 3:
				P_0.Change += P_1;
				goto case 6;
			case 6:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? ⴄႤ[135] : (ⴍႭ[203] - ⴍႭ[203]));
				break;
			case 0:
				num = 4;
				break;
			case 1:
			case 5:
			case 7:
				return;
			}
		}
	}
}
