using System;
using System.Collections.Generic;
using System.Security;
using ArcEngine.ArcCmds.NodeProcessor;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Talk;

public sealed class SetTalkOutput : IArcCmd
{
	private static void Ⴅ(NodeUserCmd P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 4:
			{
				IArcCmd arcCmd = new SetTalkOutputHelp();
				((SetTalkOutputHelp)arcCmd).Exec(P_0);
				break;
			}
			case 3:
				break;
			case 0:
				return;
			}
			break;
			IL_0023:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(4, 6, 1157906331), P_0.Rx.Msg, 692, 762));
			num = ⴍႤ[234] - 36328;
		}
		object obj = new Publisher();
		(obj as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		try
		{
			int num = 11;
			object obj = default(object);
			IComparable<string> comparable = default(IComparable<string>);
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 4) ? 1 : ⴄႭ[246]);
					continue;
				case 2:
					cmd.Tx.DistroType = DistroType.ToRequester;
					obj = new Publisher();
					comparable = SetDxFilter.Ⴀ(cmd.Rx.Split[3], 295, 'Ŧ');
					goto case 5;
				case 5:
					num = ⴐ[354] - 11;
					continue;
				case 6:
					num = (((enumerable = (string)comparable) == null) ? (ⴄႭ[152] - 142) : 18);
					continue;
				case 18:
					num = (ByeHelp.Ⴍ((string)enumerable, CallBlockCacheCfg.Ⴅ(null, 5, 62058146, null), 953, 990) ? 14 : 15);
					continue;
				case 15:
					num = (ByeHelp.Ⴍ((string)enumerable, SetStationClubHelp.Ⴍ(5, 2, 1747263474, null), 994, 901) ? (ⴀႼ[113] * 4) : (ⴀႣ[66] - 36075));
					continue;
				case 7:
				case 16:
					num = 13;
					continue;
				case 14:
					SetStationMacrosHelp.Ⴃ(NodeCmdCfg.Ⴗ(cmd.Ⴍ().Cfg, 1016, 946), OutputType.Off, '\u001c', '_');
					num = 4;
					continue;
				case 4:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(9, 5, 1157899402));
					num = 9;
					continue;
				case 9:
					((Publisher)obj).Process(cmd);
					num = 17;
					continue;
				case 8:
					SetStationMacrosHelp.Ⴃ(NodeCmdCfg.Ⴗ(cmd.Ⴍ().Cfg, 709, 655), OutputType.On, '¿', 'ü');
					num = 3;
					continue;
				case 3:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ႰႥ.Ⴅ(1, '^', 952621667));
					goto case 10;
				case 10:
					num = 0;
					continue;
				case 0:
					(obj as Publisher).Process(cmd);
					num = 17;
					continue;
				case 13:
					Ⴅ(cmd);
					num = ⴀႨ[211] - 16879;
					continue;
				case 1:
					Ⴅ(cmd);
					break;
				case 17:
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
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string where _0021_00211 : AnnCfg
	{
		int num = 5;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 6;
				break;
			case 6:
				num = (((P_2 ^ P_3) - 40) ^ num3) switch
				{
					0 => 9, 
					_ => 0, 
				};
				break;
			case 0:
				num = 4;
				break;
			case 9:
				P_0.Filter = P_1;
				goto case 4;
			case 4:
			case 7:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = 8;
				break;
			case 8:
				num = ((num2 % 2 == 0) ? 1 : 6);
				break;
			case 1:
			case 2:
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴗ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : ServerIoCfg
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int result = default(int);
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
					num2 = (((P_1 ^ P_2) - 80) ^ num) switch
					{
						0 => 8, 
						_ => 2, 
					};
					continue;
				case 2:
					result = 0;
					num2 = ⴃႠ[192] - 23549;
					continue;
				case 1:
				case 8:
					result = P_0.Port;
					num2 = ⴃႠ[160] - 12974;
					continue;
				case 0:
				case 5:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႥ[433] - 694) : 7);
					continue;
				case 7:
					num2 = ⴃႠ[250] - 46543;
					continue;
				case 6:
				case 9:
					return result;
				case 10:
					num2 = ⴄႷ[122] - 47403;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : NeedsCfg where _0021_00211 : string
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 1;
				break;
			case 1:
			{
				int num3 = P_2 ^ P_3;
				SetDxCountHelp.ႭႤ[213] = (SetDxCountHelp.ႭႤ[213] + SetWxOutput.ႣႰ[26]) & 0x5E;
				num = ((num3 - 14) ^ num2) switch
				{
					0 => 7, 
					_ => 6, 
				};
				break;
			}
			case 6:
				num = 9;
				break;
			case 3:
			case 4:
			case 7:
				P_0.Cw = P_1;
				goto case 0;
			case 0:
			case 9:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 8 : 5);
				break;
			case 5:
				num = ⴀႣ[331] - 13725;
				break;
			case 8:
				return;
			}
		}
	}
}
