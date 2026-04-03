using System.Runtime.CompilerServices;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.Callbook;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class CacheManager
{
	private static readonly ILog m_Ⴀ = SkimmerValidSpot.Ⴐ(ReplyMail.Ⴅ(2, 13, 1217942199), 97, 124);

	private WwvCache m_Ⴍ;

	private DxTestHelp.Ⴀ m_Ⴓ = new DxTestHelp.Ⴀ();

	public UsVeCallbook UsVeCallbook => this.m_Ⴓ.Ⴄ.Ⴗ();

	[SpecialName]
	internal DxCache Ⴃ()
	{
		return this.m_Ⴓ.Ⴅ;
	}

	[SpecialName]
	private void Ⴐ(DxCache P_0)
	{
		this.m_Ⴓ.Ⴅ = P_0;
	}

	[SpecialName]
	internal AnnCache Ⴄ()
	{
		return this.m_Ⴓ.Ⴗ;
	}

	[SpecialName]
	private void Ⴃ(AnnCache P_0)
	{
		this.m_Ⴓ.Ⴗ = P_0;
		BandModeCacheCfg.ႠႳ[223] = (char)(BandModeCacheCfg.ႠႳ[223] & SetAnnChatRooms.Ⴀ[193] & 0x9C);
	}

	[SpecialName]
	internal WxCache Ⴈ()
	{
		return this.m_Ⴓ.Ⴃ;
	}

	[SpecialName]
	private void Ⴀ(WxCache P_0)
	{
		this.m_Ⴓ.Ⴃ = P_0 as WxCache;
	}

	[SpecialName]
	internal WwvCache Ⴍ()
	{
		return this.m_Ⴍ;
	}

	[SpecialName]
	private void Ⴅ(WwvCache P_0)
	{
		this.m_Ⴍ = P_0;
	}

	[SpecialName]
	internal TalkCache Ⴅ()
	{
		TalkCache ⴀ = this.m_Ⴓ.Ⴀ;
		ShowSunHelp.ႣႠ[310] = (char)(ShowSunHelp.ႣႠ[310] & ShowSunHelp.ႣႠ[90] & 0xD3);
		return ⴀ;
	}

	[SpecialName]
	private void Ⴓ(TalkCache P_0)
	{
		this.m_Ⴓ.Ⴀ = P_0 as TalkCache;
	}

	[SpecialName]
	internal LogCache Ⴐ()
	{
		return this.m_Ⴓ.Ⴍ;
	}

	[SpecialName]
	private void Ⴍ(LogCache P_0)
	{
		this.m_Ⴓ.Ⴍ = P_0;
	}

	[SpecialName]
	internal ႰႷ Ⴗ()
	{
		return this.m_Ⴓ.Ⴓ;
	}

	[SpecialName]
	private void Ⴈ(ႰႷ P_0)
	{
		this.m_Ⴓ.Ⴓ = P_0 as ႰႷ;
	}

	internal CacheManager(ObjectManager P_0)
	{
		CacheManager.m_Ⴀ.Info(ReplyMail.Ⴅ(0, 15, 1217942160));
		object obj = P_0.Ⴗ();
		this.m_Ⴓ.Ⴄ = (ႷႠ)obj;
		Ⴐ(new DxCache(P_0.Ⴍ()));
		Ⴃ(new AnnCache(P_0.Ⴍ()));
		Ⴀ(new WxCache(P_0.Ⴍ()));
		Ⴅ(new WwvCache(P_0.Ⴍ()));
		Ⴓ(new TalkCache(P_0.Ⴍ()));
		Ⴍ(new LogCache(P_0.Ⴍ()));
		Ⴈ(new ႰႷ(P_0));
	}

	internal void Ⴓ()
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				ႤႤ();
				goto case 5;
			case 5:
				ႤႨ();
				goto case 3;
			case 3:
				ႤႷ();
				Ⴜ();
				num = 0;
				break;
			case 0:
				ႤႭ();
				ႨႭ();
				goto case 1;
			case 1:
				ႤႣ();
				ႤႼ();
				num = 4;
				break;
			case 4:
				ႨႥ();
				ႤႥ();
				ႤႰ();
				return;
			}
		}
	}

	[SpecialName]
	internal ConnectsCache Ⴀ()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		return this.m_Ⴓ.Ⴄ.Ⴍ();
	}

	[SpecialName]
	internal DxClusterListCache Ⴜ()
	{
		return this.m_Ⴓ.Ⴄ.ႭႠ();
	}

	[SpecialName]
	internal LotwCache ႤႣ()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		return this.m_Ⴓ.Ⴄ.Ⴐ();
	}

	[SpecialName]
	internal BadWordCache ႤႤ()
	{
		return this.m_Ⴓ.Ⴄ.Ⴈ();
	}

	[SpecialName]
	internal BandModeCache ႤႨ()
	{
		return this.m_Ⴓ.Ⴄ.Ⴀ();
	}

	[SpecialName]
	internal DxSpotBlockCache ႤႭ()
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		return this.m_Ⴓ.Ⴄ.Ⴅ();
	}

	[SpecialName]
	internal CallBlockCache ႤႥ()
	{
		return this.m_Ⴓ.Ⴄ.Ⴓ();
	}

	[SpecialName]
	internal ConnectBlockCache ႤႰ()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		return this.m_Ⴓ.Ⴄ.Ⴄ();
	}

	[SpecialName]
	internal CtyCache ႤႷ()
	{
		CtyCache result = this.m_Ⴓ.Ⴄ.Ⴜ();
		Arc4ServerClient.ႠႣ[60] = (char)(Arc4ServerClient.ႠႣ[60] & Arc4ServerClient.ႠႣ[335] & 0xF9);
		return result;
	}

	[SpecialName]
	internal ChatRoomPvtCache ႤႳ()
	{
		return this.m_Ⴓ.Ⴄ.ႭႣ();
	}

	[SpecialName]
	internal ChatRoomPubCache ႤႠ()
	{
		return this.m_Ⴓ.Ⴄ.ႭႭ();
	}

	[SpecialName]
	internal MasterCallCache ႤႼ()
	{
		return this.m_Ⴓ.Ⴄ.ႭႰ();
	}

	[SpecialName]
	internal UserCache ႨႣ()
	{
		return this.m_Ⴓ.Ⴄ.Ⴃ();
	}

	[SpecialName]
	internal DxSpotUniqueCache ႨႤ()
	{
		return this.m_Ⴓ.Ⴄ.ႭႨ();
	}

	[SpecialName]
	internal MailCache ႨႨ()
	{
		return this.m_Ⴓ.Ⴄ.ႭႥ();
	}

	[SpecialName]
	internal IpLockoutCache ႨႭ()
	{
		return this.m_Ⴓ.Ⴄ.ႭႳ();
	}

	[SpecialName]
	internal Top100Cache ႨႥ()
	{
		Top100Cache result = this.m_Ⴓ.Ⴄ.ႭႤ();
		SetDxCountHelp.ႭႤ[96] = (SetDxCountHelp.ႭႤ[96] | SetWxOutput.ႣႰ[171]) & 0x2B;
		return result;
	}

	[SpecialName]
	internal LoginMsgCache ႨႰ()
	{
		LoginMsgCache result = this.m_Ⴓ.Ⴄ.ႭႷ();
		ShowSunHelp.ႣႠ[266] = (char)((ShowSunHelp.ႣႠ[266] ^ ShowSunHelp.ႣႠ[149]) & 0x86);
		return result;
	}

	[SpecialName]
	internal FocCache ႨႷ()
	{
		FocCache result = this.m_Ⴓ.Ⴄ.ႭႼ();
		ShowQrzHelp.ႤႤ[232] = (byte)(ShowQrzHelp.ႤႤ[232] & ShowQrzHelp.ႤႤ[289] & 0x7F);
		return result;
	}

	[SpecialName]
	internal SkimmerCt1bohCache ႨႳ()
	{
		return this.m_Ⴓ.Ⴄ.ႰႣ();
	}

	internal void ႨႠ()
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴄ().SaveToDb();
				Ⴃ().SaveToDb();
				break;
			case 0:
			case 1:
				break;
			case 4:
				Ⴈ().SaveToDb();
				ႨႣ().SaveToDb();
				Ⴐ().SaveToDb();
				return;
			case 2:
				return;
			}
			Ⴅ().SaveToDb();
			Ⴍ().SaveToDb();
			num = 4;
		}
	}
}
