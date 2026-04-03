using System;
using System.Diagnostics;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wwv;

public sealed class SetWwvCount : IArcCmd
{
	private static void Ⴐ(NodeUserCmd P_0)
	{
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 0:
				obj = new SetWwvCountHelp();
				break;
			case 3:
				break;
			case 4:
				return;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(2, 5, 1157903442), P_0.Rx.Msg, 31, 81));
			num = 0;
		}
		(obj as SetWwvCountHelp).Exec(P_0);
		object obj2 = new Publisher();
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		try
		{
			int num = 9;
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 4) ? (ⴃႰ[187] - 57496) : 13);
					continue;
				case 13:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = ((!SkimmerValidSpot.Ⴈ(cmd.Rx.Split[3], 617, 541)) ? (ⴄႭ[358] - ⴄႭ[422]) : ⴐ[204]);
					continue;
				case 6:
					num2 = ShowVersion.Ⴄ(cmd.Rx.Split[3], '\u0081', '³');
					num = 7;
					continue;
				case 7:
					num = ((num2 <= cmd.Ⴍ().Ⴅ().Ⴍ()
						.SpotProcessing.MaxNmbrWwvSpots) ? (ⴀႼ[42] - 129) : (ⴀႳ[14] - 33584));
					continue;
				case 14:
					AnnFullHelp.Ⴃ(ShowHeading.Ⴅ(cmd.Ⴍ().Cfg, 744, 748), cmd.Ⴍ().Ⴅ().Ⴍ()
						.SpotProcessing.MaxNmbrWwvSpots, 596, 569);
					num = ⴍႭ[100] - 30193;
					continue;
				case 11:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(SetWxCountHelp.Ⴗ((object)ႰႥ.Ⴅ(1, '\u0003', 952621982), (object)WwvHelp.Ⴃ(ShowHeading.Ⴅ(cmd.Ⴍ().Cfg, 470, 466), 63, 'Z'), 566, (short)589));
					num = ⴀႳ[267] - 51813;
					continue;
				case 10:
					AnnFullHelp.Ⴃ(ShowHeading.Ⴅ(cmd.Ⴍ().Cfg, 617, 621), ShowVersion.Ⴄ(cmd.Rx.Split[3], '\u0329', '\u031b'), 50, 95);
					goto case 8;
				case 8:
					num = 1;
					continue;
				case 1:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(6, 8, 1157900002) + cmd.Ⴍ().Cfg.Wwv.NmbrSpots);
					goto case 5;
				case 5:
				{
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					goto case 12;
				}
				case 12:
					num = 2;
					continue;
				case 3:
				case 4:
					Ⴐ(cmd);
					num = 2;
					continue;
				case 15:
					Ⴐ(cmd);
					break;
				case 2:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴐ(cmd);
		}
		switch (3)
		{
		}
	}

	[SecuritySafeCritical]
	internal static float Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : CtyInfo
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		float result = default(float);
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
					num2 = (((P_2 ^ P_1) - 54) ^ num) switch
					{
						0 => 8, 
						_ => 10, 
					};
					continue;
				case 10:
					result = 0.3897415f;
					num2 = ⴀႨ[178] - 32268;
					continue;
				case 8:
				case 9:
					result = P_0.Longitude;
					num2 = 1;
					continue;
				case 1:
				{
					num++;
					int num3 = 3656;
					int num4 = 464;
					ShowQrzHelp.ႤႤ[367] = (byte)((ShowQrzHelp.ႤႤ[367] - IpLockoutCacheCfg.ႭႭ[177]) & 0x2C);
					num2 = ((914 < num3 / 4 - num4) ? 6 : ⴄႭ[66]);
					continue;
				}
				case 0:
					return result;
				case 5:
				case 7:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, long P_1, char P_2, short P_3) where _0021_00210 : PerformanceCounter
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
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
			case 0:
			case 8:
				num = (((P_2 ^ P_3) - 33) ^ num2) switch
				{
					0 => 5, 
					_ => 4, 
				};
				break;
			case 3:
			case 4:
				num = ⴄႷ[70] - 5437;
				break;
			case 5:
				P_0.RawValue = P_1;
				goto case 2;
			case 2:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 1 : 9);
				break;
			case 9:
				num = 8;
				break;
			case 1:
			case 6:
				return;
			}
		}
	}
}
