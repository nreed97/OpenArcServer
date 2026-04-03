using System;
using System.Collections;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class ShowWxOptions : IArcCmd
{
	private static void Ⴐ(NodeUserCmd P_0)
	{
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 2:
				obj = new ShowWxOptionsHelp();
				break;
			case 1:
			case 3:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(5, 2, 1157903445), P_0.Rx.Msg, 517, 587));
			num = 2;
		}
		(obj as ShowWxOptionsHelp).Exec(P_0);
		object obj2 = new Publisher();
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		try
		{
			int num = 0;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 3) ? (ⴍႤ[130] - 9859) : 9);
					continue;
				case 9:
					cmd.Tx.DistroType = DistroType.ToRequester;
					cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(5, null, 1267014497, typeof(PcxxCfg)));
					num = ⴀႣ[316] - 54632;
					continue;
				case 3:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(14, 7, 1157903704), StationHelp.Ⴓ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 782, 826), 'K', 79).ToString(), 118, 56));
					num = 4;
					continue;
				case 4:
				case 6:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႰႥ.Ⴅ(8, 'Ó', 952619941), LogEntry.Ⴄ(PcxxCfg.Ⴃ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 386, 438), 'Ϫ', 'ϲ'), '¥', 137), 524, 578));
					num = 2;
					continue;
				case 2:
				{
					Ⴄ(cmd);
					Ⴀ(cmd);
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					num = 5;
					continue;
				}
				case 8:
					Ⴐ(cmd);
					break;
				case 5:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴐ(cmd);
		}
		switch (4)
		{
		}
	}

	private static void Ⴀ(NodeUserCmd P_0)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 4;
		IConvertible convertible = default(IConvertible);
		OutputType outputType = default(OutputType);
		while (true)
		{
			switch (num)
			{
			default:
				convertible = ShowWxHelp.Ⴍ('\u0080', 985808430, 3);
				outputType = ႷႷ.Ⴃ(ShowAnnOptionsHelp.Ⴃ(P_0.Ⴍ().Cfg, 774, 892), 'ύ', 936);
				num = 7;
				break;
			case 7:
				num = outputType switch
				{
					OutputType.Off => ⴀႣ[244] - 40673, 
					OutputType.On => ⴅ[147] / 9, 
					_ => 1, 
				};
				break;
			case 1:
				num = 5;
				break;
			case 3:
				convertible = ShowUsersHelp.Ⴅ((string)convertible, CallBlockCacheCfg.Ⴅ(null, 7, 62058144, null), 1009, 959);
				goto case 6;
			case 6:
				num = 5;
				break;
			case 2:
				convertible = (string)convertible + ႨႨ.Ⴀ(13, 3, 1157903723);
				num = 5;
				break;
			case 0:
			case 5:
				P_0.Tx.Msg.Add(convertible as string);
				return;
			}
		}
	}

	private static void Ⴄ(NodeUserCmd P_0)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 5;
		IEquatable<string> equatable = default(IEquatable<string>);
		ModeType modeType = default(ModeType);
		while (true)
		{
			switch (num)
			{
			default:
				equatable = SetTalkCount.Ⴗ(6, null, 1267021372, typeof(SetStationQth));
				modeType = SkimmerSpotBins.Ⴅ(SetStationEmailHelp.Ⴈ(P_0.Ⴍ().Cfg, 596, 608), 835, 845);
				goto case 3;
			case 3:
				num = 6;
				break;
			case 1:
			case 6:
				num = modeType switch
				{
					ModeType.Open => ⴀႳ[229] - 53853, 
					ModeType.Filter => 2, 
					ModeType.Debug => 8, 
					_ => 0, 
				};
				break;
			case 0:
				num = ⴀ[68] - 39866;
				break;
			case 4:
				equatable = ShowUsersHelp.Ⴅ((string)equatable, ႰႥ.Ⴅ(4, 'Z', 952620618), 555, 613);
				num = ⴀႳ[141] - 58297;
				break;
			case 2:
				equatable = ShowUsersHelp.Ⴅ((string)equatable, SetStationClubHelp.Ⴍ(5, 4, 1747258301, null), 134, 200);
				num = ⴀ[4] - 45079;
				break;
			case 8:
			case 9:
				equatable = (string)equatable + ShowWxHelp.Ⴍ('\u0004', 985808496, 2);
				num = ⴀႣ[297] - 344;
				break;
			case 7:
				P_0.Tx.Msg.Add(equatable as string);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : CallbookData
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		IEnumerable enumerable = default(IEnumerable);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 9;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
					break;
				case 9:
					num2 = (((P_1 ^ P_2) - 19) ^ num) switch
					{
						0 => 3, 
						_ => ⴀႣ[6] - 36792, 
					};
					continue;
				case 5:
					enumerable = null;
					goto case 8;
				case 8:
					num2 = 1;
					continue;
				case 3:
					enumerable = P_0.LicenseExpirationDate;
					num2 = 1;
					continue;
				case 0:
				case 1:
					num++;
					num3 = 1116;
					num4 = 77;
					goto case 7;
				case 7:
					num2 = ((558 < num3 / 2 - num4) ? 9 : (ⴄႭ[195] - ⴄႭ[125]));
					continue;
				case 4:
				{
					string result = (string)enumerable;
					Arc4ServerClient.ႠႣ[282] = (char)((Arc4ServerClient.ႠႣ[282] - P_1) & 0xE);
					return result;
				}
				case 6:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}
}
