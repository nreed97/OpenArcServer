using System;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class SetWxOutput : IArcCmd
{
	internal static ႥႣ ႣႷ/* Not supported: data(41 34 00 04 12 98 40 86 BF 14 F1 37 60 1E D1 2B 02 AF 85 EE C9 8C 0D C9 E0 8D CC 90 74 07 9D B6 CC 78 56 DB 4A 34 B3 F9 94 77 C0 66 50 ED 61 D6 28 3B DE 1F 8F 3E D7 23 B4 AC 2D 0A F4 7B 44 C2 62 04 AA 4A 78 44 A2 0C D7 CB 84 D2 46 29 A6 76 89 3F F0 02 27 EC FB 33 F2 1F 79 72 51 C1 8B 8C F6 74 A5 81 0C 0A 89 B3 83 E2 99 76 C3 5C 80 CD AF 16 AF C1 18 4B E0 F4 61 F9 88 FA 1C 7F D4 A4 91 72 83 CA AB C4 35 43 54 4C D0 FA C5 EA 46 A6 10 B2 A3 BD 29 BA A3 74 97 7A 54 B9 6F B6 AE C8 8B 5E 02 B2 DF AE 0F 2B 21 00 69 C8 BF DF C7 8D E5 ED F6 76 F2 F5 28 0A 6C 87 65 34 43 7D FF 44 D3 83 52 47 69 C1 6D 55 CC AD 1C 7E 36 40 24 7A DF 96 C4 63 79 01 E0 24 6E BC 1F E8 E9 52 5A 5D 3F 0B 69 82 54 96 5E 47 A8 4B 0D 54 B3 A4 26 AA C3 EA E3 36 4F 55 5D D5 DE 04 9D E0 DA 1E AA 7D 5F 40 29 75 CF F0 45 33 EA F7 02 61 E1 1A 6E E0 CC 71 BB 34 2F 94 5B 9C EF C6 DF BA 58 D1 C6 05 0D 24 98 98 E7 FE 02 05 0F 9E E5 35 55 F9 C5 2F 9E A2 42 17 A9 6A E9 76 CC 28 D8 6A 45 75 40 B6 EA 44 CE 83 80 E4 44 47 4F F7 A3 1F 6E 65 3B AA 88 67 E5 B5 91 D5 ED 16 DD BF 57 08 35 E3 E3 2F 8A 65 88 4F 50 B1 45 6C B4 E1 D7 19 9A DF 79 0A D3 7B 09 C1 A6 90 A7 E0 58 F6 F6 A3 A1 B7 F3 06 74 BF ED DD 71 57 21 43 5E D6 13 8A 76 0E 69 04 29 33 AB 54 79 9D 29 E8 53 60 68 E2 E7 6F 46 9A 0B 34 C5 3A) */;

	internal static char[] ႣႰ;

	private static void Ⴍ(NodeUserCmd P_0)
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(0, 3, 1157905918), P_0.Rx.Msg, 602, 532));
				goto IL_0052;
			case 3:
				goto IL_0052;
			case 1:
			{
				object obj = new SetWxOutputHelp();
				((SetWxOutputHelp)obj).Exec(P_0);
				break;
			}
			case 0:
				break;
			}
			break;
			IL_0052:
			num = 1;
		}
		object obj2 = new Publisher();
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႰ = ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			int num = 5;
			object obj = default(object);
			IConvertible convertible = default(IConvertible);
			ICloneable cloneable = default(ICloneable);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 4) ? (ⴄႷ[16] - 11912) : 14);
					continue;
				case 14:
					cmd.Tx.DistroType = DistroType.ToRequester;
					obj = new Publisher();
					convertible = SetDxFilter.Ⴀ(cmd.Rx.Split[3], 761, 'ʸ');
					num = ⴅ[210];
					continue;
				case 8:
					num = (((cloneable = convertible as string) != null) ? 4 : 0);
					continue;
				case 4:
					num = (ByeHelp.Ⴍ((string)cloneable, CallBlockCacheCfg.Ⴅ(null, 2, 62058149, null), 589, 554) ? 3 : 12);
					continue;
				case 12:
					num = (ByeHelp.Ⴍ((string)cloneable, ႨႨ.Ⴀ(3, 4, 1157903724), 799, 888) ? (ⴃႰ[170] - 54660) : 7);
					continue;
				case 7:
					num = 0;
					continue;
				case 3:
					SetStationLoginCmds.Ⴗ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 486, 466), OutputType.Off, 'ǌ', 457);
					num = 11;
					continue;
				case 11:
				case 18:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ႨႨ.Ⴀ(6, 5, 1157905838));
					num = 17;
					continue;
				case 10:
				case 17:
					((Publisher)obj).Process(cmd);
					num = 1;
					continue;
				case 13:
					SetStationLoginCmds.Ⴗ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 902, 946), OutputType.On, '\u0095', 144);
					num = 16;
					continue;
				case 16:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ႰႥ.Ⴅ(1, 'x', 952622568));
					num = ⴍႤ[193] - 9325;
					continue;
				case 2:
					(obj as Publisher).Process(cmd);
					num = ⴀႳ[126] - 41117;
					continue;
				case 0:
					Ⴍ(cmd);
					num = 1;
					continue;
				case 9:
					Ⴍ(cmd);
					break;
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴍ(cmd);
		}
		switch (3)
		{
		}
	}
}
