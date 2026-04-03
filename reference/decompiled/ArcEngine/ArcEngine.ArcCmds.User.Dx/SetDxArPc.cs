using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class SetDxArPc : IArcCmd
{
	private static void Ⴅ(NodeUserCmd P_0)
	{
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 2:
			case 4:
				obj = new SetDxOutputHelp();
				break;
			case 0:
			case 3:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(3, 0, 1157903980), P_0.Rx.Msg, 467, 413));
			num = 2;
		}
		((SetDxOutputHelp)obj).Exec(P_0);
		object obj2 = new Publisher();
		(obj2 as Publisher).Process(P_0);
		SetTalkCountHelp.Ⴅ[311] = (byte)(SetTalkCountHelp.Ⴅ[311] & SetTalkCountHelp.Ⴅ[91] & 0x23);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			int num = 14;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					obj = new Publisher();
					num = ((cmd.Rx.Split.Length != 4) ? 13 : 2);
					continue;
				case 2:
					num = ((!ByeHelp.Ⴍ(SetDxFilter.Ⴀ(cmd.Rx.Split[3], 638, 'ȿ'), ႨႨ.Ⴀ(15, 5, 1157903725), 401, 502)) ? 11 : (ⴃႠ[151] - 42616));
					continue;
				case 0:
					qslinfoRequest.Ⴄ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 961, 955), OutputType.AR17, 113, 24);
					num = 6;
					continue;
				case 6:
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133884, 5, '\u0099'));
					cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(2, null, 1057161451, 0));
					num = 9;
					continue;
				case 9:
					cmd.Tx.Msg.Add(ႰႥ.Ⴅ(6, '?', 952620997));
					goto case 8;
				case 8:
				case 10:
					cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 4, 62058428, null));
					num = ⴍႭ[9] - 4947;
					continue;
				case 3:
					cmd.Tx.Msg.Add(ReplyMail.Ⴅ(3, 3, 1217945536));
					cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(3, 3, 1747258314, null));
					num = ⴀႼ[96];
					continue;
				case 4:
					cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687352184, 7, 5));
					num = 7;
					continue;
				case 7:
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(15, 5, 1157903901));
					cmd.Tx.Msg.Add(ShowWxHelp.Ⴍ('$', 985808307, 3));
					num = ⴅ[77] - 248;
					continue;
				case 5:
					((Publisher)obj).Process(cmd);
					num = ⴀႳ[106] - 34480;
					continue;
				case 1:
				case 13:
					Ⴅ(cmd);
					break;
				case 11:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴅ(cmd);
		}
		switch (1)
		{
		}
	}

	[SecuritySafeCritical]
	internal static double Ⴃ(double P_0, int P_1, short P_2)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		double result = default(double);
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
					num2 = ⴄႷ[33] - 18068;
					continue;
				case 2:
					break;
				case 8:
					num2 = (((P_1 ^ P_2) - 65) ^ num) switch
					{
						0 => ⴃႠ[275] - 31799, 
						1 => ⴄႭ[475] / 5, 
						_ => 7, 
					};
					continue;
				case 7:
					result = 0.26437582671641285;
					num2 = 11;
					continue;
				case 0:
				case 1:
				case 10:
					result = UtilsLatLon.GetLongPathBrg(P_0);
					num2 = ⴍႭ[359] - 38854;
					continue;
				case 12:
					result = Math.Sin(P_0);
					num2 = 11;
					continue;
				case 11:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 9 : 4);
					continue;
				case 4:
					num2 = ⴍႭ[115] - 12350;
					continue;
				case 9:
					return result;
				case 3:
				case 5:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, char P_3) where _0021_00210 : Array
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[296] - ⴍႭ[101];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 4:
				case 7:
					break;
				case 1:
					num2 = (((P_2 ^ P_3) - 25) ^ num) switch
					{
						0 => 3, 
						_ => ⴍႭ[178] - 6014, 
					};
					continue;
				case 2:
					result = P_1;
					num2 = ⴄႭ[258] - 232;
					continue;
				case 3:
					result = P_0.GetLength(P_1);
					num2 = ⴃႥ[329] - 21274;
					continue;
				case 0:
				case 8:
				case 9:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 6 : (ⴀႼ[18] / 8));
					continue;
				case 10:
					num2 = 1;
					continue;
				case 6:
					return result;
				case 11:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}
}
