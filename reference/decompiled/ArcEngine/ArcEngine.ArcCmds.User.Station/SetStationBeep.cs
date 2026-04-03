using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcServerConfig.Io;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationBeep : IArcCmd
{
	internal sealed class Ⴀ
	{
		internal string Ⴗ;

		internal int Ⴍ;

		internal DateTime Ⴈ;

		internal Ⴀ()
		{
		}
	}

	private static void Ⴃ(NodeUserCmd P_0)
	{
		int num = 0;
		IArcCmd arcCmd = default(IArcCmd);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 3:
				arcCmd = new SetStationBeepHelp();
				goto case 4;
			case 4:
				(arcCmd as SetStationBeepHelp).Exec(P_0);
				break;
			case 1:
				break;
			case 2:
				return;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(9, 5, 1157902415), P_0.Rx.Msg, 241, 191));
			num = 3;
		}
		object obj = new Publisher();
		((Publisher)obj).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		try
		{
			int num = 5;
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 4) ? (ⴀႨ[64] - 60339) : 7);
					continue;
				case 7:
					cmd.Tx.DistroType = DistroType.ToRequester;
					enumerable = SetDxFilter.Ⴀ(cmd.Rx.Split[3], 530, 'ɓ');
					goto case 16;
				case 16:
					num = 13;
					continue;
				case 13:
					num = ((!ByeHelp.Ⴍ(enumerable as string, SetDxFilter.Ⴀ(ShowWxHelp.Ⴍ('\u00a0', 985807968, 3), 471, 'Ɩ'), 772, 867)) ? 8 : (ⴀႳ[317] - 4091));
					continue;
				case 10:
					SetAnnDefaultHelp.Ⴈ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 545, 567), true, 'ʈ', 'ˆ');
					num = ⴃႰ[71] - 42560;
					continue;
				case 6:
				case 15:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134363, 5, '\u009f'));
					num = ⴀႳ[139] - 4375;
					continue;
				case 1:
				{
					object obj2 = new Publisher();
					((Publisher)obj2).Process(cmd);
					num = 4;
					continue;
				}
				case 8:
					num = ((!ByeHelp.Ⴍ((string)enumerable, SetDxFilter.Ⴀ(ႨႨ.Ⴀ(6, 0, 1157902452), 311, 'Ŷ'), 758, 657)) ? (ⴄႷ[45] - 37258) : 3);
					continue;
				case 3:
					SetAnnDefaultHelp.Ⴈ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 184, 174), false, '\u0085', 'Ë');
					num = 9;
					continue;
				case 9:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(1, null, 1267020317, typeof(IoServerDevicesCfg)));
					num = 14;
					continue;
				case 14:
				{
					object obj = new Publisher();
					(obj as Publisher).Process(cmd);
					num = 4;
					continue;
				}
				case 12:
					Ⴃ(cmd);
					num = 4;
					continue;
				case 2:
					Ⴃ(cmd);
					break;
				case 4:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴃ(cmd);
		}
		switch (4)
		{
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : TextWriter where _0021_00211 : string
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 9;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				break;
			case 0:
				SetDxCountHelp.ႭႤ[271] = (SetDxCountHelp.ႭႤ[271] + P_2) & 0x9B;
				num = (((P_3 ^ P_2) - 3) ^ num2) switch
				{
					0 => 7, 
					_ => ⴀႣ[403] - 3202, 
				};
				break;
			case 3:
				num = ⴄႭ[331] - 162;
				break;
			case 7:
				P_0.WriteLine(P_1);
				goto case 1;
			case 1:
			case 2:
				num2++;
				num3 = 501;
				goto case 6;
			case 6:
			{
				int num4 = 950;
				num = ((2850 > num4 - num3 * 3) ? (ⴃႰ[188] - 63059) : (ⴀႨ[229] - 36009));
				break;
			}
			case 4:
			case 8:
				num = ⴄႷ[52] - ⴄႷ[52];
				break;
			case 5:
				return;
			}
		}
	}
}
