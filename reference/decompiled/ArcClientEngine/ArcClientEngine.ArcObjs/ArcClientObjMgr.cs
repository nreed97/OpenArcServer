using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.ArcIo;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcShared.ArcIo.Tcp;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcObjs;

public sealed class ArcClientObjMgr
{
	private static readonly ILog Ⴐ;

	private static readonly ArcClientObjMgr m_Ⴈ;

	private ႳႣ Ⴗ;

	private ClientCfg m_Ⴅ;

	private ႥႭ Ⴐ;

	private Io m_Ⴍ;

	private ႥႷ m_Ⴈ;

	private ArcWebService m_Ⴄ;

	private SkimmerSpotRateGraph.ႤႥ m_Ⴓ;

	public CacheManager Caches
	{
		get
		{
			return this.m_Ⴓ.Ⴄ;
		}
		private set
		{
			this.m_Ⴓ.Ⴄ = cacheManager as CacheManager;
		}
	}

	public ClientCfg Cfg
	{
		get
		{
			char[] ⴗ = ႥႰ.Ⴗ;
			ClientCfg ⴅ = this.m_Ⴅ;
			Bye.Ⴄ[103] = (char)((Bye.Ⴄ[103] ^ Bye.Ⴄ[198]) & 0xC3);
			return ⴅ;
		}
		set
		{
			this.m_Ⴅ = value;
		}
	}

	public Io Io
	{
		get
		{
			return this.m_Ⴍ;
		}
		set
		{
			this.m_Ⴍ = value;
		}
	}

	public bool IsConnected => ႳႥ.ႥႰ((TcpClient)Io.ArxClients[0], 214, 133);

	public static ArcClientObjMgr Instance
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return ArcClientObjMgr.m_Ⴈ;
		}
	}

	[SpecialName]
	internal ႳႣ Ⴃ()
	{
		return Ⴗ;
	}

	[SpecialName]
	internal void Ⴀ(ႳႣ P_0)
	{
		Ⴗ = P_0;
	}

	[SpecialName]
	internal ႥႭ Ⴍ()
	{
		return Ⴐ;
	}

	[SpecialName]
	internal void Ⴓ(ႥႭ P_0)
	{
		Ⴐ = P_0;
	}

	[SpecialName]
	internal ႥႷ Ⴄ()
	{
		return this.m_Ⴈ;
	}

	[SpecialName]
	internal void Ⴃ(ႥႷ P_0)
	{
		this.m_Ⴈ = P_0;
	}

	[SpecialName]
	internal ႥႨ Ⴀ()
	{
		ႥႨ ⴍ = this.m_Ⴓ.Ⴍ;
		HighlightCtyCfg.ႠႠ[66] = (char)((HighlightCtyCfg.ႠႠ[66] * HighlightCtyCfg.ႠႠ[124]) & 0xF8);
		return ⴍ;
	}

	[SpecialName]
	internal void Ⴍ(ႥႨ P_0)
	{
		this.m_Ⴓ.Ⴍ = P_0;
	}

	[SpecialName]
	internal ArcWebService Ⴅ()
	{
		return this.m_Ⴄ;
	}

	[SpecialName]
	internal void Ⴈ(ArcWebService P_0)
	{
		this.m_Ⴄ = P_0;
	}

	[SecuritySafeCritical]
	static ArcClientObjMgr()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				ArcClientConnectDat.Ⴍ();
				break;
			case 3:
			case 4:
				break;
			case 2:
				ArcClientObjMgr.m_Ⴈ = new ArcClientObjMgr();
				return;
			}
			ArcClientObjMgr.Ⴐ = HighlightItuZoneCfg.Ⴓ(ႥႥ.Ⴍ(5, 1580609069, '^', null), 473, 489);
			num = 2;
		}
	}

	private ArcClientObjMgr()
	{
		this.m_Ⴓ.Ⴐ = 99;
		base._002Ector();
		try
		{
			ArcClientObjMgr.Ⴐ.Info(ClientCty.Ⴗ('\u0005', 5, 307013028));
			ႥႠ.Ⴗ();
			Cfg = ClientCfg.Init();
			Ⴓ(new ႥႭ());
			Caches = new CacheManager(Ⴍ());
			Ⴈ(new ArcWebService(this));
			Ⴅ().GetClientConnectList();
			Ⴀ(new ႳႣ(this));
			Io = new Io(this);
			Io.Ⴓ(Cfg);
			Io.Ⴐ();
			Ⴍ(new ႥႨ(this));
			Ⴃ(new ႥႷ(this));
			ႥႥ.ႤႭ(30, 114, 86);
		}
		catch (Exception ex)
		{
			ArcClientObjMgr.Ⴐ.Fatal(FilterCfg.Ⴍ(ex as Exception, 99, 109));
		}
	}

	public void ShutDown()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				HighlightCqZoneCfg.ႣႰ((TcpClient)Io.ArxClients[0], (short)980, (short)940);
				break;
			case 2:
				break;
			case 3:
				ArcClientObjMgr.Ⴐ.Info(ClientCty.Ⴗ('"', 2, 307013066));
				return;
			case 1:
			case 4:
				return;
			}
			Cfg.Ⴓ();
			num = 3;
		}
	}

	public void Housekeeping(string connectText)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 9;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num)
			{
			default:
				FilterEditor.ႷႳ(ႥႠ.ႭႳ(537, 580), new CultureInfo(ႥႥ.Ⴍ(8, 1580609230, '\u001b', null)), 'ʿ', 691);
				num = 7;
				break;
			case 7:
				Io.UiThreadProcessMsgs();
				goto case 4;
			case 4:
			case 8:
			{
				dateTime = UserInfo.ႥႤ('π', 974);
				int num2 = FilterEditor.ႷႥ(ref dateTime, 447, 480);
				int ⴐ2 = this.m_Ⴓ.Ⴐ;
				ႥႰ.Ⴗ[29] = (char)(ႥႰ.Ⴗ[29] & Bye.Ⴄ[150] & 0x40);
				num = ((num2 == ⴐ2) ? (ⴀႠ[112] - 45131) : (ⴗ[12] - 301));
				break;
			}
			case 0:
			{
				int ⴐ = FilterEditor.ႷႥ(ref dateTime, 736, 703);
				this.m_Ⴓ.Ⴐ = ⴐ;
				num = ⴀႠ[0] - 49952;
				break;
			}
			case 5:
				Caches.Dx.PurgeOldSpots();
				Caches.Ann.PurgeOldSpots();
				Caches.Wx.PurgeOldSpots();
				num = 1;
				break;
			case 1:
				num = ((!ႥႤ.Ⴍ(connectText, ႥႥ.Ⴍ(1, 1580609231, '\0', connectText), 598, 621)) ? 3 : 2);
				break;
			case 2:
			case 6:
				num = (Io.ArxClients[0].IsConnected ? 3 : 10);
				break;
			case 10:
				Io.ArxClients[0].Connect();
				return;
			case 3:
				return;
			}
		}
	}
}
