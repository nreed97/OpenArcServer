using System;
using System.Collections;
using System.Data.Common;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Ui;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class Bye : IArcCmd
{
	private static void Ⴅ(NodeUserCmd P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 4;
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 0:
			case 2:
			{
				object obj = new ByeHelp();
				(obj as ByeHelp).Exec(P_0);
				goto case 1;
			}
			case 1:
				obj2 = new Publisher();
				break;
			case 3:
				break;
			}
			break;
			IL_0023:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(0, 0, 1157898604), P_0.Rx.Msg, 11, 69));
			char num2 = ⴍႭ[359];
			BandModeCacheCfg.ႠႳ[325] = (char)((BandModeCacheCfg.ႠႳ[325] | BandModeCacheCfg.ႠႳ[268]) & 0x12);
			num = num2 - 38863;
		}
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		object obj = Login.Ⴅ(cmd.Ⴍ());
		try
		{
			int num = 0;
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = ((cmd.Rx.Split.Length != 1) ? 7 : 2);
					continue;
				case 2:
					cmd.Ⴍ().ႠႰ(obj as string);
					cmd.Ⴍ().Ⴀ(false);
					SetWxOutputHelp.Ⴓ(cmd.Ⴍ().Cfg, ShowAnnHelp.Ⴅ('Σ', 914), '\u035e', 816);
					num = 1;
					continue;
				case 1:
					cmd.Ⴍ().ႳႳ();
					cmd.Ⴍ().ႳႨ();
					goto case 8;
				case 8:
					num = ⴐ[367];
					continue;
				case 7:
					Ⴅ(cmd);
					break;
				case 4:
				case 6:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴅ(cmd);
		}
		switch (4)
		{
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴄ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : StatusBarData
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int result = default(int);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 27) ^ num) switch
					{
						0 => 8, 
						_ => 4, 
					};
					continue;
				case 4:
					result = 11;
					num2 = 9;
					continue;
				case 5:
				case 8:
				case 11:
					result = P_0.DxRate;
					num2 = 9;
					continue;
				case 9:
					num++;
					ShowSunHelp.ႣႠ[272] = (char)((ShowSunHelp.ႣႠ[272] - ShowSunHelp.ႣႠ[260]) & 0x66);
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႠ[416] - 8141) : 10);
					continue;
				case 10:
					num2 = ⴍႭ[133] - 22333;
					continue;
				case 2:
					return result;
				case 1:
				case 7:
					num2 = ⴐ[204];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : StationCfg
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			int num = 0;
			int num2 = 12;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႣ[30] - 13981;
					continue;
				case 2:
				case 11:
					break;
				case 12:
					num2 = (((P_2 ^ P_1) - 88) ^ num) switch
					{
						0 => ⴐ[254], 
						1 => ⴀ[330] - 54203, 
						_ => ⴀႼ[33], 
					};
					continue;
				case 9:
					enumerable = null;
					num2 = ⴀႨ[81] - 36071;
					continue;
				case 0:
					enumerable = P_0.Name;
					goto case 6;
				case 6:
					num2 = 1;
					continue;
				case 7:
					enumerable = P_0.Email;
					num2 = 1;
					continue;
				case 1:
				{
					num++;
					int num3 = 346;
					int num4 = 425;
					num2 = ((850 > num4 - num3 * 2) ? (ⴀႳ[252] - 1337) : (ⴄႤ[204] - 76));
					continue;
				}
				case 3:
				case 10:
					num2 = 12;
					continue;
				case 4:
					return (string)enumerable;
				case 5:
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴈ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DbParameterCollection
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[254];
					continue;
				case 0:
					break;
				case 3:
				{
					int num5;
					switch (((P_1 ^ P_2) - 105) ^ num)
					{
					default:
					{
						int num6 = ⴀႨ[144];
						Arc4ServerClient.ႠႣ[427] = (char)(Arc4ServerClient.ႠႣ[427] & P_2 & 0xFC);
						num5 = num6 - 11821;
						break;
					}
					case 0:
						num5 = 9;
						break;
					}
					num2 = num5;
					continue;
				}
				case 7:
					result = P_2;
					num2 = 2;
					continue;
				case 9:
					result = P_0.Count;
					num2 = ⴄႤ[30] - ⴄႤ[57];
					continue;
				case 2:
				case 4:
				case 5:
				{
					num++;
					int num3 = 2616;
					int num4 = 111;
					num2 = ((654 < num3 / 4 - num4) ? 3 : (ⴍႤ[74] - 55098));
					continue;
				}
				case 6:
				case 10:
					return result;
				case 8:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}
}
