using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class SetWxMode : IArcCmd
{
	private static void Ⴓ(NodeUserCmd P_0)
	{
		int num = 4;
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 0:
			{
				object obj = new SetWxModeHelp();
				(obj as SetWxModeHelp).Exec(P_0);
				obj2 = new Publisher();
				break;
			}
			case 2:
				break;
			case 3:
				return;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(1, 3, 1157906423), P_0.Rx.Msg, 906, 964));
			num = 0;
		}
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		try
		{
			int num = 9;
			object obj = default(object);
			IConvertible convertible = default(IConvertible);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					obj = new Publisher();
					num = ((cmd.Rx.Split.Length != 4) ? 3 : 6);
					continue;
				case 6:
					convertible = SetDxFilter.Ⴀ(cmd.Rx.Split[3], 817, 'Ͱ');
					num = ⴍႭ[249] - 48866;
					continue;
				case 13:
					num = (((obj2 = convertible as string) == null) ? (ⴄႷ[91] - 7796) : (ⴀႣ[264] - 37757));
					continue;
				case 7:
					num = (ByeHelp.Ⴍ(obj2 as string, ႰႥ.Ⴅ(3, '~', 952620621), 278, 369) ? (ⴀႳ[179] - 2222) : (ⴄႭ[289] - ⴄႭ[83]));
					continue;
				case 4:
					num = (ByeHelp.Ⴍ(obj2 as string, SetStationClubHelp.Ⴍ(5, 6, 1747258303, null), 228, 131) ? 10 : (ⴃႰ[74] - 47656));
					continue;
				case 1:
					num = (ByeHelp.Ⴍ(obj2 as string, ShowWxHelp.Ⴍ('V', 985808497, 3), 363, 268) ? 18 : 5);
					continue;
				case 5:
					num = 20;
					continue;
				case 19:
					WwvSpotUser.Ⴗ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 182, 130), ModeType.Open, 1018, 'Ϩ');
					num = ⴀႣ[373] - 13248;
					continue;
				case 11:
					cmd.Tx.Msg.Add(ShowWxHelp.Ⴍ('K', 985806615, 7));
					(obj as Publisher).Process(cmd);
					goto case 17;
				case 17:
					num = ⴄႭ[240] - ⴄႭ[134];
					continue;
				case 10:
					WwvSpotUser.Ⴗ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 266, 318), ModeType.Filter, 788, '\u0306');
					num = 16;
					continue;
				case 16:
					cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(7, null, 1057165070, 8));
					num = 0;
					continue;
				case 0:
					((Publisher)obj).Process(cmd);
					num = 15;
					continue;
				case 18:
					SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 820, 768).Mode = ModeType.Debug;
					cmd.Tx.Msg.Add(ReplyMail.Ⴅ(1, 15, 1217943408));
					goto case 14;
				case 14:
					num = 12;
					continue;
				case 8:
				case 12:
					((Publisher)obj).Process(cmd);
					num = 15;
					continue;
				case 20:
					Ⴓ(cmd);
					num = ⴀႼ[87] - 210;
					continue;
				case 3:
					Ⴓ(cmd);
					break;
				case 15:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴓ(cmd);
		}
		switch (0)
		{
		}
	}

	[SecuritySafeCritical]
	internal static TimeSpan Ⴃ(DateTime P_0, DateTime P_1, int P_2, int P_3)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		TimeSpan result = default(TimeSpan);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[357] - 4268;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 8;
					continue;
				case 8:
					break;
				case 1:
					num2 = (((P_3 ^ P_2) - 78) ^ num) switch
					{
						0 => 4, 
						_ => 5, 
					};
					continue;
				case 5:
					result = default(TimeSpan);
					goto case 6;
				case 6:
					num2 = 9;
					continue;
				case 0:
				case 4:
					result = P_0 - P_1;
					num2 = ⴃႰ[147] - 1273;
					continue;
				case 9:
				{
					num++;
					int num3 = 1089;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? (ⴃႰ[38] - 10556) : (ⴍႭ[282] - 33570));
					continue;
				}
				case 2:
					num2 = 1;
					continue;
				case 10:
					return result;
				case 3:
				case 7:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : string
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		Array array = default(Array);
		while (true)
		{
			int num = 0;
			int num2 = 4;
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
					num2 = (((P_1 ^ P_2) - 105) ^ num) switch
					{
						0 => 5, 
						_ => ⴅ[308] - 248, 
					};
					continue;
				case 6:
					array = null;
					goto case 9;
				case 9:
					num2 = 10;
					continue;
				case 5:
					array = Convert.FromBase64String(P_0);
					num2 = ⴐ[367] + ⴐ[204];
					continue;
				case 0:
				case 10:
					num++;
					goto case 3;
				case 3:
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 7 : (ⴍႭ[40] - 40866));
					continue;
				case 11:
					num2 = 4;
					continue;
				case 7:
					return (byte[])array;
				case 2:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}
}
