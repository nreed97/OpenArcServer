using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class SetWxCount : IArcCmd
{
	internal sealed class Ⴃ
	{
		internal List<string> Ⴅ;

		internal Ⴃ()
		{
		}
	}

	private static void Ⴈ(NodeUserCmd P_0)
	{
		int num = 3;
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(2, 3, 1157903510), P_0.Rx.Msg, 532, 602));
				goto IL_0052;
			case 2:
				goto IL_0052;
			case 0:
			{
				object obj = new SetWxCountHelp();
				(obj as SetWxCountHelp).Exec(P_0);
				obj2 = new Publisher();
				break;
			}
			case 4:
				break;
			}
			break;
			IL_0052:
			num = 0;
		}
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		try
		{
			int num = 8;
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length == 4) ? 1 : ⴄႭ[246]);
					continue;
				case 1:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = ((!SkimmerValidSpot.Ⴈ(cmd.Rx.Split[3], 448, 436)) ? 15 : 12);
					continue;
				case 12:
					num2 = ShowVersion.Ⴄ(cmd.Rx.Split[3], 'ʏ', 'ʽ');
					num = 0;
					continue;
				case 0:
					num = ((num2 <= cmd.Ⴍ().Ⴅ().Ⴍ()
						.SpotProcessing.MaxNmbrWxSpots) ? (ⴄႷ[33] - 18067) : 6);
					continue;
				case 6:
					ႰႨ.ႥႤ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 418, 406), cmd.Ⴍ().Ⴅ().Ⴍ()
						.SpotProcessing.MaxNmbrWxSpots, 85, 98);
					goto case 10;
				case 10:
					num = ⴄႷ[39] - 54266;
					continue;
				case 13:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(SetWxCountHelp.Ⴗ((object)ႰႥ.Ⴅ(0, '\f', 952620101), (object)StationHelp.Ⴓ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 797, 809), 'ʾ', 698), 896, (short)1019));
					goto case 5;
				case 5:
					num = 7;
					continue;
				case 3:
				case 11:
					ႰႨ.ႥႤ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 73, 125), ShowVersion.Ⴄ(cmd.Rx.Split[3], 'Ʃ', 'ƛ'), 251, 204);
					num = ⴃႰ[111] - 23884;
					continue;
				case 14:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(10, 6, 1157903429) + cmd.Ⴍ().Cfg.Wx.NmbrSpots);
					goto case 7;
				case 7:
				{
					object obj = new Publisher();
					(obj as Publisher).Process(cmd);
					num = ⴄႤ[413] - 27;
					continue;
				}
				case 15:
					Ⴈ(cmd);
					num = 4;
					continue;
				case 2:
					Ⴈ(cmd);
					break;
				case 4:
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
	internal static void Ⴐ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, char P_3) where _0021_00210 : Letter where _0021_00211 : string
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				break;
			case 7:
			case 8:
				num = (((P_3 ^ P_2) - 68) ^ num2) switch
				{
					0 => 9, 
					_ => 3, 
				};
				break;
			case 3:
				num = ⴀႳ[305] - 41991;
				break;
			case 1:
			case 9:
				P_0.Status = P_1;
				goto case 2;
			case 2:
			{
				num2++;
				int num3 = 40;
				int num4 = 143;
				num = ((1430 > num4 - num3 * 10) ? (ⴃႥ[262] - 48622) : 5);
				break;
			}
			case 5:
				num = 8;
				break;
			case 0:
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : SqlCeEngine
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႨ[145] - 20388;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႤ[293] - 9291;
					continue;
				case 2:
					break;
				case 11:
					num2 = (((P_1 ^ P_2) - 48) ^ num) switch
					{
						0 => 8, 
						_ => ⴐ[182] - 21, 
					};
					continue;
				case 1:
				{
					result = false;
					char num3 = ⴄႷ[5];
					Arc4ServerClient.ႠႣ[288] = (char)(Arc4ServerClient.ႠႣ[288] & Arc4ServerClient.ႠႣ[351] & 0xBE);
					num2 = num3 - 20858;
					continue;
				}
				case 3:
				case 8:
					result = P_0.Verify();
					num2 = ⴀႼ[33];
					continue;
				case 9:
				case 10:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 != 0) ? (ⴀႳ[335] - 20592) : 0);
					continue;
				case 5:
					num2 = ⴄႤ[356] - 23;
					continue;
				case 0:
					return result;
				case 7:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}
}
