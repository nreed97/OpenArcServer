using System;
using System.Collections.Generic;
using System.Data;
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
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces.Io;
using ArcInterfaces.Spots;
using ArcShared;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class SetDxOutput : IArcCmd
{
	private static void Ⴃ(NodeUserCmd P_0)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 3;
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 0:
			{
				object obj = new SetDxOutputHelp();
				(obj as SetDxOutputHelp).Exec(P_0);
				obj2 = new Publisher();
				break;
			}
			case 1:
				break;
			case 2:
				return;
			}
			break;
			IL_0023:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(8, 8, 1157900159), P_0.Rx.Msg, 314, 372));
			num = ⴀႳ[259] - 12444;
		}
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		try
		{
			int num = 4;
			object obj = default(object);
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = ((cmd.Rx.Split.Length != 4) ? (ⴃႰ[177] - 20341) : 7);
					continue;
				case 7:
					obj = new Publisher();
					enumerable = SetDxFilter.Ⴀ(cmd.Rx.Split[3], 392, 'ǉ');
					goto case 6;
				case 6:
					num = 16;
					continue;
				case 16:
					num = (((obj2 = enumerable as string) == null) ? (ⴍႭ[263] - 23718) : (ⴀႣ[279] - 33216));
					continue;
				case 18:
					num = (ByeHelp.Ⴍ(obj2 as string, CallBlockCacheCfg.Ⴅ(null, 5, 62058146, null), 22, 113) ? 24 : (ⴀ[340] - 57676));
					continue;
				case 10:
					num = (ByeHelp.Ⴍ((string)obj2, ႨႨ.Ⴀ(0, 0, 1157903720), 477, 442) ? 2 : 21);
					continue;
				case 3:
				case 21:
					num = (ByeHelp.Ⴍ(obj2 as string, CallBlockCacheCfg.Ⴅ(null, 1, 62057509, null), 954, 989) ? (ⴐ[338] - 9) : (ⴀႨ[190] - 45572));
					continue;
				case 22:
					num = (ByeHelp.Ⴍ((string)obj2, CallBlockCacheCfg.Ⴅ(null, 6, 62055772, null), 120, 31) ? 13 : ⴄႤ[139]);
					continue;
				case 14:
					num = 12;
					continue;
				case 24:
					qslinfoRequest.Ⴄ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 940, 982), OutputType.Off, 131, 234);
					num = ⴃႰ[98] - 49488;
					continue;
				case 25:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267016918, typeof(SetTalkOutput)));
					num = ⴀ[521] - 7011;
					continue;
				case 17:
					((Publisher)obj).Process(cmd);
					num = ⴐ[330] - ⴐ[98];
					continue;
				case 2:
					qslinfoRequest.Ⴄ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 672, 730), OutputType.On, 156, 245);
					num = ⴀႼ[141] - 97;
					continue;
				case 20:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(8, 4, 1157900070));
					num = 0;
					continue;
				case 0:
					(obj as Publisher).Process(cmd);
					num = 1;
					continue;
				case 15:
					qslinfoRequest.Ⴄ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 129, 251), OutputType.AR17, 957, 980);
					goto case 9;
				case 9:
					num = 23;
					continue;
				case 23:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(5, 1, 1747263283, null));
					num = 5;
					continue;
				case 5:
					(obj as Publisher).Process(cmd);
					num = 1;
					continue;
				case 13:
					ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 80, 42).Output = OutputType.XML;
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					num = 11;
					continue;
				case 11:
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129259, 5, 'Û'));
					((Publisher)obj).Process(cmd);
					num = 1;
					continue;
				case 12:
					Ⴃ(cmd);
					num = 1;
					continue;
				case 19:
					Ⴃ(cmd);
					break;
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴃ(cmd);
		}
		switch (3)
		{
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, char P_3) where _0021_00210 : DataColumnCollection where _0021_00211 : DataColumn
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				break;
			case 6:
				DirectoryBulletin.ႠႨ[157] = (DirectoryBulletin.ႠႨ[157] ^ P_2) & 0x92;
				num = (((P_3 ^ P_2) - 0) ^ num2) switch
				{
					0 => 3, 
					_ => 9, 
				};
				break;
			case 7:
			case 9:
				num = ⴐ[254];
				break;
			case 3:
				P_0.Add(P_1);
				goto case 0;
			case 0:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴀႣ[422] - 53522) : ⴐ[367]);
				break;
			case 4:
			case 8:
				num = ⴍႭ[138] - 42609;
				break;
			case 2:
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Guid Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : ClientIoCfg
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		Guid result = default(Guid);
		while (true)
		{
			int num = 0;
			int num2 = 10;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
					break;
				case 1:
				case 10:
					num2 = (((P_1 ^ P_2) - 65) ^ num) switch
					{
						0 => 3, 
						_ => 0, 
					};
					continue;
				case 0:
					result = default(Guid);
					num2 = ⴀႨ[148] - 33948;
					continue;
				case 2:
				case 3:
					result = P_0.Id;
					num2 = ⴃႥ[94] - 31069;
					continue;
				case 7:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 6 : (ⴍႭ[266] - 51347));
					continue;
				case 4:
					num2 = ⴀ[172] - 3509;
					continue;
				case 6:
					return result;
				case 8:
				case 9:
					num2 = ⴀႳ[262] - 23911;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : CtyInfo
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		IConvertible convertible = default(IConvertible);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 55) ^ num) switch
					{
						0 => 0, 
						_ => ⴀ[415] - 23798, 
					};
					continue;
				case 7:
					convertible = null;
					num2 = ⴃႰ[188] - 63062;
					continue;
				case 0:
				case 8:
					convertible = P_0.Country;
					num2 = 2;
					continue;
				case 2:
					num++;
					goto case 11;
				case 11:
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴄႤ[81] / 4) : 5);
					continue;
				case 5:
					num2 = ⴄႷ[135] - 15688;
					continue;
				case 1:
				case 9:
					return convertible as string;
				case 6:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210>(_0021_00210 P_0, byte P_1, char P_2, char P_3) where _0021_00210 : DxSpot
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				break;
			case 0:
				num = (((P_3 ^ P_2) - 51) ^ num2) switch
				{
					0 => ⴄႤ[379] - 107, 
					_ => 6, 
				};
				break;
			case 6:
			case 9:
				num = 7;
				break;
			case 8:
				P_0.CqZone = P_1;
				goto case 7;
			case 7:
			{
				num2++;
				int num3 = 659;
				int num4 = 728;
				num = ((2184 > num4 - num3 * 3) ? 1 : 4);
				break;
			}
			case 2:
			case 4:
				num = 0;
				break;
			case 1:
			case 5:
				return;
			}
		}
	}
}
