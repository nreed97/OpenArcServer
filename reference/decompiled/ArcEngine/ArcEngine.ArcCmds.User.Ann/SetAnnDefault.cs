using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnDefault : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 7;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 0;
			case 0:
			case 5:
				SetTalkOutput.Ⴍ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 451, 490), string.Empty, 642, 'ʪ');
				num = 1;
				break;
			case 1:
				DirectoryOwn.Ⴐ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 445, 404), ModeType.Filter, 999, 957);
				num = 8;
				break;
			case 2:
			case 8:
				SetStationEmailHelp.Ⴍ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 324, 365), OutputType.On, 776, 'Ͳ');
				num = 3;
				break;
			case 3:
				StationHelp.Ⴈ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 634, 595), 20, 452, 'ǳ');
				num = ⴍႭ[266] - 51345;
				break;
			case 6:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(6, '3', 952616088));
				obj = new ShowAnnOptions();
				num = 4;
				break;
			case 4:
			{
				((ShowAnnOptions)obj).Exec(cmd);
				object obj2 = new Publisher();
				(obj2 as Publisher).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴍ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : string where _0021_00211 : string
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		bool result = default(bool);
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
					num2 = ⴄႭ[576] - 93;
					continue;
				case 3:
					break;
				case 8:
					num2 = (((P_2 ^ P_3) - 82) ^ num) switch
					{
						0 => ⴍႤ[378] - 55438, 
						_ => 11, 
					};
					continue;
				case 11:
					result = false;
					num2 = ⴄႷ[115] - 21754;
					continue;
				case 7:
					result = P_0.StartsWith(P_1);
					num2 = ⴄႷ[124] - 47746;
					continue;
				case 2:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 5;
					continue;
				case 5:
				case 6:
				case 10:
					num2 = ((num3 % 2 != 0) ? ⴅ[210] : (ⴍႤ[167] - ⴍႤ[167]));
					continue;
				case 0:
				case 9:
					return result;
				case 1:
					num2 = ⴄႭ[405] - 231;
					continue;
				}
				break;
			}
		}
	}
}
