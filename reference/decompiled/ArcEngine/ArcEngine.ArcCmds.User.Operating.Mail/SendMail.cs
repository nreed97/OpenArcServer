using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class SendMail
{
	private static void Ⴈ(NodeUserCmd P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(4, 5, 1157903442), P_0.Rx.Msg, 476, 402));
				goto IL_0059;
			case 3:
				goto IL_0059;
			case 0:
			{
				IArcCmd arcCmd = new SendMailHelp();
				((SendMailHelp)arcCmd).Exec(P_0);
				obj = new Publisher();
				break;
			}
			case 1:
				break;
			case 2:
				return;
			}
			break;
			IL_0059:
			char num2 = ⴃႥ[433];
			char num3 = ⴃႥ[433];
			Arc4ServerClient.ႠႣ[420] = (char)((Arc4ServerClient.ႠႣ[420] - Arc4ServerClient.ႠႣ[277]) & 0x66);
			num = num2 - num3;
		}
		((Publisher)obj).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd, bool isPvt, bool isRtnRcpt)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		try
		{
			int num = 7;
			object obj2 = default(object);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = (isPvt ? (ⴀႳ[152] - 25344) : (ⴄႷ[2] - 23605));
					continue;
				case 1:
					num = (isRtnRcpt ? (ⴃႥ[335] - 32149) : (ⴀႨ[118] - 41563));
					continue;
				case 10:
					num = ((cmd.Rx.Split.Length != 2) ? 5 : 6);
					continue;
				case 6:
				case 9:
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130043, 7, ';'));
					obj2 = new Publisher();
					num = ⴀႨ[48] - 4739;
					continue;
				case 8:
					(obj2 as Publisher).Process(cmd);
					num = 13;
					continue;
				case 5:
					num = ((cmd.Rx.Split.Length < 1) ? 12 : (ⴀႳ[283] - 19817));
					continue;
				case 2:
					cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 3, 62061777, null));
					num = 4;
					continue;
				case 0:
				case 4:
					obj = new Publisher();
					goto case 11;
				case 11:
					((Publisher)obj).Process(cmd);
					num = ⴃႥ[113] - 53014;
					continue;
				case 12:
					Ⴈ(cmd);
					break;
				case 13:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴈ(cmd);
		}
		switch (2)
		{
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : DxSpot where _0021_00211 : string
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴅ[453] - ⴅ[53];
				break;
			case 7:
				num = (((P_2 ^ P_3) - 67) ^ num2) switch
				{
					0 => ⴀႨ[109] - 2194, 
					_ => 8, 
				};
				break;
			case 6:
			case 8:
				num = 5;
				break;
			case 4:
				P_0.SpotterCont = P_1;
				goto case 5;
			case 5:
				num2++;
				goto case 9;
			case 9:
				num = (((P_2 * P_2 + P_2) % 2 != 0) ? 1 : (ⴀႣ[29] - 12323));
				break;
			case 1:
				num = 7;
				break;
			case 2:
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte Ⴐ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DxSpot
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte result = default(byte);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[340] + 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႤ[129] / 7;
					continue;
				case 10:
					break;
				case 9:
					num2 = (((P_2 ^ P_1) - 67) ^ num) switch
					{
						0 => 6, 
						_ => ⴄႭ[94], 
					};
					continue;
				case 7:
					result = 28;
					goto case 0;
				case 0:
					num2 = ⴅ[20] - 6;
					continue;
				case 6:
					result = P_0.CqZone;
					num2 = 4;
					continue;
				case 1:
				case 3:
				case 4:
				{
					num++;
					int num3 = 291;
					int num4 = 377;
					num2 = ((754 > num4 - num3 * 2) ? (ⴀႨ[195] - 50773) : 11);
					continue;
				}
				case 11:
					num2 = 9;
					continue;
				case 2:
					return result;
				case 8:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}
}
