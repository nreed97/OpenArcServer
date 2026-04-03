using System;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class SkimmerCt1bohCache
{
	public enum SkimmerQualityType
	{
		Unknown,
		Valid,
		Qsy,
		Busted,
		BustedOverride
	}

	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(ReplyMail.Ⴅ(1, 10, 1217943365), 215, 202);

	public SkimmerBandProcessor Skim160Processor;

	public SkimmerBandProcessor Skim80Processor;

	public SkimmerBandProcessor Skim40Processor;

	public SkimmerBandProcessor Skim30Processor;

	public SkimmerBandProcessor Skim20Processor;

	public SkimmerBandProcessor Skim17Processor;

	public SkimmerBandProcessor Skim15Processor;

	public SkimmerBandProcessor Skim12Processor;

	public SkimmerBandProcessor Skim10Processor;

	public SkimmerBandProcessor Skim6Processor;

	public SkimmerServerCache SkimmerServerDataCache;

	public string GetCt1bohFlag(SkimmerQualityType quality)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		while (true)
		{
			int num = quality switch
			{
				SkimmerQualityType.Unknown => ⴀႨ[179] - 27571, 
				SkimmerQualityType.Valid => 7, 
				SkimmerQualityType.Qsy => ⴍႭ[347] - 58760, 
				SkimmerQualityType.Busted => 9, 
				SkimmerQualityType.BustedOverride => ⴃႠ[146] - 42162, 
				_ => 1, 
			};
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႨ[47] - 22485;
					continue;
				case 3:
					break;
				case 1:
					num = ⴍႤ[73] - 60507;
					continue;
				case 0:
				case 8:
					return ShowWxHelp.Ⴍ('?', 985807918, 6);
				case 7:
				case 10:
				{
					string result = SetTalkCount.Ⴗ(0, null, 1267019722, typeof(ShowPrefixCallsHelp));
					ႨႣ.Ⴐ[405] = (byte)((ႨႣ.Ⴐ[405] ^ DirectoryBulletin.ႠႨ[199]) & 0x81);
					return result;
				}
				case 11:
					return ShowWxHelp.Ⴍ('\u0083', 985806117, 7);
				case 9:
					return ReplyMail.Ⴅ(3, 11, 1217941954);
				case 2:
				case 5:
					return SetStationClubHelp.Ⴍ(11, 8, 1747257869, null);
				case 6:
					return ShowWxHelp.Ⴍ('«', 985807912, 0);
				}
				break;
			}
		}
	}

	public SkimmerCt1bohCache()
	{
		SkimmerServerDataCache = new SkimmerServerCache();
		Skim160Processor = new SkimmerBandProcessor(18000, 19000);
		Skim80Processor = new SkimmerBandProcessor(35000, 38000);
		Skim40Processor = new SkimmerBandProcessor(70000, 71100);
		Skim30Processor = new SkimmerBandProcessor(101000, 101500);
		Skim20Processor = new SkimmerBandProcessor(140000, 141000);
		Skim17Processor = new SkimmerBandProcessor(180680, 181100);
		Skim15Processor = new SkimmerBandProcessor(210000, 212000);
		Skim12Processor = new SkimmerBandProcessor(248900, 289300);
		Skim10Processor = new SkimmerBandProcessor(280000, 283000);
		Skim6Processor = new SkimmerBandProcessor(500000, 501200);
	}

	public SkimmerQualityType GetSkimmerQualityCt1boh(DxSpot dx, out float freqQsyPercent, out int skimCtyCnt, out string bustedKeyCall)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		SkimmerQualityType skimmerQualityType = SkimmerQualityType.Unknown;
		skimCtyCnt = 0;
		bustedKeyCall = string.Empty;
		try
		{
			int num = 0;
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					num2 = ShowUsersHelp.Ⴓ(StationHelp.Ⴗ(dx, 'ɟ', 626), 708, 673);
					num = 5;
					continue;
				case 5:
					num = ((num2 > 20) ? 4 : 18);
					continue;
				case 18:
					num = ((num2 > 12) ? (ⴀႼ[54] - 49) : (ⴄႤ[312] - 207));
					continue;
				case 6:
					num = ((num2 == 6) ? 3 : 11);
					continue;
				case 2:
				case 11:
					num = num2 switch
					{
						10 => 21, 
						11 => 27, 
						12 => ⴃႥ[183] - 11644, 
						_ => ⴅ[99], 
					};
					continue;
				case 16:
					num = 27;
					continue;
				case 29:
				{
					int num3 = num2;
					SetAnnMode.ႤႭ[543] = (byte)((SetAnnMode.ႤႭ[543] ^ SetAnnMode.ႤႭ[72]) & 0x99);
					num = (num3 - 15) switch
					{
						0 => 12, 
						1 => 27, 
						2 => 15, 
						_ => ⴍႤ[322] - 63841, 
					};
					continue;
				}
				case 19:
					num = ((num2 == 20) ? 24 : 13);
					continue;
				case 13:
					num = 27;
					continue;
				case 4:
					num = ((num2 > 40) ? 7 : 23);
					continue;
				case 23:
					num = ((num2 == 30) ? 8 : 26);
					continue;
				case 26:
					num = ((num2 == 40) ? 9 : ⴄႤ[310]);
					continue;
				case 28:
					num = 27;
					continue;
				case 7:
					num = ((num2 == 80) ? 10 : ⴐ[156]);
					continue;
				case 20:
				case 25:
					num = ((num2 != 160) ? (ⴀႳ[81] - 60540) : (ⴃႥ[451] - 59524));
					continue;
				case 1:
					skimmerQualityType = Skim160Processor.ProcessCt1boh(dx, out skimCtyCnt, out bustedKeyCall);
					num = 27;
					continue;
				case 10:
					skimmerQualityType = Skim80Processor.ProcessCt1boh(dx, out skimCtyCnt, out bustedKeyCall);
					num = 27;
					continue;
				case 9:
					skimmerQualityType = Skim40Processor.ProcessCt1boh(dx, out skimCtyCnt, out bustedKeyCall);
					num = 27;
					continue;
				case 8:
				case 22:
					skimmerQualityType = Skim30Processor.ProcessCt1boh(dx, out skimCtyCnt, out bustedKeyCall);
					num = 27;
					continue;
				case 24:
					skimmerQualityType = Skim20Processor.ProcessCt1boh(dx, out skimCtyCnt, out bustedKeyCall);
					num = 27;
					continue;
				case 15:
					skimmerQualityType = Skim17Processor.ProcessCt1boh(dx, out skimCtyCnt, out bustedKeyCall);
					num = ⴃႰ[193] - 56786;
					continue;
				case 12:
					skimmerQualityType = Skim15Processor.ProcessCt1boh(dx, out skimCtyCnt, out bustedKeyCall);
					num = ⴄႷ[141] - 32603;
					continue;
				case 17:
					skimmerQualityType = Skim12Processor.ProcessCt1boh(dx, out skimCtyCnt, out bustedKeyCall);
					num = ⴃႥ[311] - 3518;
					continue;
				case 21:
					skimmerQualityType = Skim10Processor.ProcessCt1boh(dx, out skimCtyCnt, out bustedKeyCall);
					num = ⴃႰ[116] - 19341;
					continue;
				case 3:
					skimmerQualityType = Skim6Processor.ProcessCt1boh(dx, out skimCtyCnt, out bustedKeyCall);
					num = 27;
					continue;
				case 27:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴅ.Error(SkimmerSpotBins.Ⴈ(ex as Exception, 333, 355));
		}
		switch (3)
		{
		default:
			freqQsyPercent = SkimmerServerDataCache.Update(dx.Spotter, skimmerQualityType);
			break;
		case 2:
		case 4:
			break;
		}
		return skimmerQualityType;
	}

	public void OneMinMaint(ObjectManager om)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!om.Ⴍ().SpotProcessing.EnableCt1bohProcessing) ? (ⴀ[516] - 31178) : 9);
				break;
			case 9:
			{
				obj = new PrecisionTimer();
				ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 231, 166);
				Skim160Processor.Ⴃ();
				char num2 = ⴀႣ[235];
				SetWxOutput.ႣႰ[90] = (char)((SetWxOutput.ႣႰ[90] - SetAnnMode.ႤႭ[545]) & 0xFD);
				num = num2 - 11081;
				break;
			}
			case 4:
				Skim80Processor.Ⴃ();
				Skim40Processor.Ⴃ();
				Skim30Processor.Ⴃ();
				Skim20Processor.Ⴃ();
				goto case 8;
			case 8:
				num = 3;
				break;
			case 3:
				Skim17Processor.Ⴃ();
				Skim15Processor.Ⴃ();
				Skim12Processor.Ⴃ();
				Skim10Processor.Ⴃ();
				num = 5;
				break;
			case 5:
				Skim6Processor.Ⴃ();
				SkimmerServerDataCache.OneMinMaint();
				goto case 6;
			case 6:
				ByeHelp.Ⴄ((PrecisionTimer)obj, 'Ⱥ', 617);
				num = 1;
				break;
			case 1:
				Ⴅ.Info((PrecisionTimer)obj);
				return;
			case 7:
				return;
			}
		}
	}
}
