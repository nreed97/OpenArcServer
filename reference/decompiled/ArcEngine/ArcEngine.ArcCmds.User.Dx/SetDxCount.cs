using System;
using System.Runtime.InteropServices;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class SetDxCount : IArcCmd
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴃ
	{
		internal ObjectManager Ⴐ;
	}

	private static void Ⴅ(NodeUserCmd P_0)
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 1:
			case 2:
			{
				object obj = new SetDxCountHelp();
				((SetDxCountHelp)obj).Exec(P_0);
				break;
			}
			case 0:
			case 3:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(1, 7, 1157903440), P_0.Rx.Msg, 323, 269));
			num = 1;
		}
		object obj2 = new Publisher();
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			int num = 15;
			int num2 = default(int);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 4) ? 8 : 5);
					continue;
				case 5:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = (SkimmerValidSpot.Ⴈ(cmd.Rx.Split[3], 215, 163) ? ⴐ[50] : 0);
					continue;
				case 12:
					num2 = ShowVersion.Ⴄ(cmd.Rx.Split[3], 'Į', 'Ĝ');
					num = ⴀ[464] - 29722;
					continue;
				case 7:
					num = ((num2 <= cmd.Ⴍ().Ⴅ().Ⴍ()
						.SpotProcessing.MaxNmbrDxSpots) ? 4 : 3);
					continue;
				case 3:
					SkimmerValidSpot.Ⴀ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 698, 704), cmd.Ⴍ().Ⴅ().Ⴍ()
						.SpotProcessing.MaxNmbrDxSpots, 'ʲ', 760);
					num = 13;
					continue;
				case 13:
					cmd.Tx.Msg.Add(SetWxCountHelp.Ⴗ((object)ႨႨ.Ⴀ(11, 6, 1157903421), (object)ShowQslInfoHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 716, 694), 'Ä', 248), 682, (short)721));
					num = ⴀႳ[77] - 50327;
					continue;
				case 4:
					SkimmerValidSpot.Ⴀ(ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 358, 284), num2, 'n', 36);
					goto case 14;
				case 14:
					num = 6;
					continue;
				case 6:
					cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 1, 62057928, null) + ShowAnnOptionsHelp.Ⴃ(cmd.Ⴍ().Cfg, 31, 101).NmbrSpots);
					goto case 11;
				case 11:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					obj = new Publisher();
					num = 10;
					continue;
				case 10:
					((Publisher)obj).Process(cmd);
					goto case 16;
				case 16:
					num = 2;
					continue;
				case 0:
					Ⴅ(cmd);
					num = 2;
					continue;
				case 8:
					Ⴅ(cmd);
					break;
				case 2:
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
}
