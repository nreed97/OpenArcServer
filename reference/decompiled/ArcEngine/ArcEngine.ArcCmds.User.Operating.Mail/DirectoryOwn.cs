using System;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Ui;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class DirectoryOwn : IArcCmd
{
	private static void Ⴈ(NodeUserCmd P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(2, 3, 1157903444), P_0.Rx.Msg, 293, 363));
				goto IL_0059;
			case 1:
				goto IL_0059;
			case 0:
			{
				object obj = new DirectoryOwnHelp();
				((DirectoryOwnHelp)obj).Exec(P_0);
				break;
			}
			case 2:
				break;
			case 4:
				return;
			}
			break;
			IL_0059:
			num = ⴅ[6];
		}
		object obj2 = new Publisher();
		((Publisher)obj2).Process(P_0);
		ShowWwvOptionsHelp.ႣႥ[367] = (char)((ShowWwvOptionsHelp.ႣႥ[367] - ShowSunHelp.ႣႠ[307]) & 0xCE);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		try
		{
			int num = 0;
			IEquatable<string> equatable = default(IEquatable<string>);
			object obj = default(object);
			int nmbr = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					equatable = AnnHelp.Ⴈ(ႨႨ.Ⴀ(9, 1, 1157900030), cmd.Ⴍ().Ⴀ(), ႨႨ.Ⴀ(8, 2, 1157903559), 560, 'ȇ');
					num = 10;
					continue;
				case 10:
					obj = new Publisher();
					num = ((cmd.Rx.Split.Length != 2) ? 1 : 8);
					continue;
				case 8:
					MailHelper.ProcessDir(cmd, 20, equatable as string);
					((Publisher)obj).Process(cmd);
					num = ⴄႷ[12] - 43767;
					continue;
				case 1:
					num = ((cmd.Rx.Split.Length != 3) ? 5 : (ⴄႭ[492] / 3));
					continue;
				case 12:
					num = ((!SkimmerValidSpot.Ⴈ(cmd.Rx.Split[1], 849, 805)) ? 6 : 7);
					continue;
				case 2:
				case 7:
					nmbr = SetAnnWrap.Ⴐ(cmd.Rx.Split[1], 'ε', 972);
					goto case 4;
				case 4:
					num = 9;
					continue;
				case 9:
					MailHelper.ProcessDir(cmd, nmbr, (string)equatable);
					((Publisher)obj).Process(cmd);
					num = ⴃႠ[285] - 25096;
					continue;
				case 5:
					Ⴈ(cmd);
					break;
				case 6:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴈ(cmd);
		}
		switch (0)
		{
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210>(_0021_00210 P_0, ModeType P_1, int P_2, short P_3) where _0021_00210 : AnnCfg
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 8;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 2;
				break;
			case 2:
				num = (((P_2 ^ P_3) - 90) ^ num3) switch
				{
					0 => 4, 
					_ => 5, 
				};
				break;
			case 5:
				num = 7;
				break;
			case 4:
				P_0.Mode = P_1;
				goto case 7;
			case 7:
				num3++;
				goto case 9;
			case 9:
				num2 = P_3 * P_3;
				goto case 0;
			case 0:
				num2 = P_3 + num2;
				num = ⴍႤ[301] - 2693;
				break;
			case 3:
			case 6:
				num = ((num2 % 2 != 0) ? 2 : (ⴀ[330] - 54209));
				break;
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, TimeSpan P_1, int P_2, int P_3) where _0021_00210 : StatusBarData
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 3;
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = 7;
				break;
			case 7:
				BandModeCacheCfg.ႠႳ[161] = (char)((BandModeCacheCfg.ႠႳ[161] + P_3) & 0x1D);
				num = (((P_2 ^ P_3) - 83) ^ num4) switch
				{
					0 => 9, 
					_ => ⴀ[92] - 2233, 
				};
				break;
			case 5:
				num = 8;
				break;
			case 1:
			case 9:
				P_0.Uptime = P_1;
				goto case 8;
			case 8:
				num4++;
				num3 = 1395;
				goto case 0;
			case 0:
			{
				int num5 = num3;
				num2 = num5 * num5;
				num = 2;
				break;
			}
			case 2:
			case 4:
				num2 = num3 + num2;
				num = ((num2 % 2 != 0) ? 7 : (ⴀႨ[143] - 64085));
				break;
			case 6:
				return;
			}
		}
	}
}
