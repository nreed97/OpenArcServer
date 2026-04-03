using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class DxSpotUniqueCache
{
	private static readonly ILog m_Ⴀ = SkimmerValidSpot.Ⴐ(ႨႨ.Ⴀ(5, 8, 1157906408), 742, 763);

	private readonly DxSpotUniqueCacheWorker Ⴅ;

	private readonly DxSpotUniqueCacheWorker Ⴗ;

	private readonly DxSpotUniqueCacheWorker Ⴃ;

	private SetAnnFilter.Ⴅ Ⴈ = new SetAnnFilter.Ⴅ();

	internal DxSpotUniqueCache()
	{
		object obj = new DxSpotUniqueCacheWorker();
		Ⴈ.Ⴐ = (DxSpotUniqueCacheWorker)obj;
		Ⴅ = new DxSpotUniqueCacheWorker();
		object obj2 = new DxSpotUniqueCacheWorker();
		Ⴈ.Ⴃ = (DxSpotUniqueCacheWorker)obj2;
		object obj3 = new DxSpotUniqueCacheWorker();
		Ⴈ.Ⴀ = obj3 as DxSpotUniqueCacheWorker;
		Ⴗ = new DxSpotUniqueCacheWorker();
		Ⴃ = new DxSpotUniqueCacheWorker();
		object obj4 = new DxSpotUniqueCacheWorker();
		Ⴈ.Ⴅ = (DxSpotUniqueCacheWorker)obj4;
	}

	internal byte Ⴀ(string P_0, double P_1, string P_2)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		while (true)
		{
			int num = SetDxMode.Ⴍ(P_1, 'ħ', 323);
			byte result = 1;
			int num2 = num;
			int num3 = ⴅ[62] - 164;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = ⴅ[248] - 234;
					continue;
				case 15:
				case 16:
					break;
				case 1:
					num3 = ((num2 > 20) ? 19 : (ⴃႥ[272] - 34071));
					continue;
				case 0:
					num3 = ((num2 == 10) ? 14 : (ⴃႠ[362] - 26046));
					continue;
				case 20:
					num3 = ((num2 == 15) ? (ⴍႭ[40] - 40870) : (ⴀႣ[347] - 48132));
					continue;
				case 4:
					num3 = ((num2 == 20) ? 6 : 10);
					continue;
				case 10:
					num3 = ⴀႳ[103] - 14948;
					continue;
				case 19:
					num3 = ((num2 == 40) ? (ⴀႼ[127] - 31) : (ⴅ[332] - 219));
					continue;
				case 2:
					num3 = ((num2 == 80) ? 5 : 18);
					continue;
				case 18:
					num3 = ((num2 != 160) ? (ⴐ[113] - 30) : (ⴍႭ[200] - 53503));
					continue;
				case 12:
					result = Ⴈ.Ⴐ.Ⴃ(P_0, P_2);
					num3 = ⴃႰ[57] - 49580;
					continue;
				case 5:
					result = Ⴅ.Ⴃ(P_0, P_2);
					num3 = ⴀႼ[101] - 38;
					continue;
				case 8:
					result = Ⴈ.Ⴃ.Ⴃ(P_0, P_2);
					num3 = 3;
					continue;
				case 6:
					result = Ⴈ.Ⴀ.Ⴃ(P_0, P_2);
					num3 = ⴀ[42] - 50093;
					continue;
				case 7:
					result = Ⴗ.Ⴃ(P_0, P_2);
					num3 = ⴍႭ[226] - 11087;
					continue;
				case 9:
				case 14:
				case 17:
					result = Ⴃ.Ⴃ(P_0, P_2);
					num3 = 3;
					continue;
				case 11:
					result = Ⴈ.Ⴅ.Ⴃ(SetWxCountHelp.Ⴗ((object)P_0, (object)P_1, 898, (short)1017), P_2);
					num3 = ⴍႤ[326] - 33212;
					continue;
				case 3:
					return result;
				}
				break;
			}
		}
	}

	internal void Ⴐ()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴈ.Ⴐ.Ⴈ();
				Ⴅ.Ⴈ();
				goto case 0;
			case 0:
			case 3:
				Ⴈ.Ⴃ.Ⴈ();
				num = ⴀႼ[113];
				break;
			case 2:
				Ⴈ.Ⴀ.Ⴈ();
				Ⴗ.Ⴈ();
				Ⴃ.Ⴈ();
				goto case 1;
			case 1:
				num = 5;
				break;
			case 5:
				Ⴈ.Ⴅ.Ⴈ();
				return;
			}
		}
	}
}
