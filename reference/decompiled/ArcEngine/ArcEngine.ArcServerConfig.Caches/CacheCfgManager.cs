using System.ComponentModel;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using Meebey.SmartIrc4net;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class CacheCfgManager
{
	private BadWordCacheCfg Ⴄ;

	private CallbookCfg Ⴄ;

	private CallBlockCacheCfg Ⴅ;

	private ConnectBlockCacheCfg Ⴓ;

	private DxClusterCacheCfg Ⴃ;

	private DxSpotBlockCacheCfg Ⴃ;

	private LogCacheCfg Ⴍ;

	private MailCacheCfg Ⴀ;

	private NodeCacheCfg Ⴄ;

	private TalkCacheCfg Ⴍ;

	private SetAnnDefaultHelp.Ⴄ m_Ⴜ;

	public AnnCacheCfg Ann
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			return this.m_Ⴜ.Ⴍ;
		}
		set
		{
			this.m_Ⴜ.Ⴍ = value as AnnCacheCfg;
		}
	}

	public BadWordCacheCfg BadWord
	{
		get
		{
			BadWordCacheCfg ⴄ = this.Ⴄ;
			IpLockoutCacheCfg.ႭႭ[30] = (char)((IpLockoutCacheCfg.ႭႭ[30] * IpLockoutCacheCfg.ႭႭ[292]) & 0xF9);
			return ⴄ;
		}
		set
		{
			this.Ⴄ = value;
		}
	}

	public BandModeCacheCfg BandMode
	{
		get
		{
			byte[] ⴐ = ႨႣ.Ⴐ;
			return this.m_Ⴜ.Ⴃ;
		}
		set
		{
			this.m_Ⴜ.Ⴃ = value as BandModeCacheCfg;
		}
	}

	public CallbookCfg Callbook
	{
		get
		{
			return this.Ⴄ;
		}
		set
		{
			this.Ⴄ = value;
		}
	}

	public ChatRoomPvtCfg ChatRoomPvt
	{
		get
		{
			return this.m_Ⴜ.Ⴀ;
		}
		set
		{
			this.m_Ⴜ.Ⴀ = value as ChatRoomPvtCfg;
		}
	}

	public ChatRoomPubCfg ChatRoomPub
	{
		get
		{
			char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
			return this.m_Ⴜ.Ⴈ;
		}
		set
		{
			this.m_Ⴜ.Ⴈ = value as ChatRoomPubCfg;
		}
	}

	public CtyCacheCfg Cty
	{
		get
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			return this.m_Ⴜ.Ⴓ;
		}
		set
		{
			this.m_Ⴜ.Ⴓ = value as CtyCacheCfg;
		}
	}

	public CallBlockCacheCfg CallBlock
	{
		get
		{
			CallBlockCacheCfg ⴅ = Ⴅ;
			AnnCacheCfg.ႠႼ[29] = (byte)((AnnCacheCfg.ႠႼ[29] ^ AnnCacheCfg.ႠႼ[16]) & 0x99);
			return ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	public ConnectBlockCacheCfg ConnectBlock
	{
		get
		{
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			return Ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	public DxCacheCfg Dx
	{
		get
		{
			DxCacheCfg ⴗ = this.m_Ⴜ.Ⴗ;
			TxNodeUserCmd.ႤႷ[106] = (char)((TxNodeUserCmd.ႤႷ[106] + TxNodeUserCmd.ႤႷ[102]) & 0xA9);
			return ⴗ;
		}
		set
		{
			this.m_Ⴜ.Ⴗ = value;
		}
	}

	public DxClusterCacheCfg DxCluster
	{
		get
		{
			return this.Ⴃ;
		}
		set
		{
			this.Ⴃ = value;
		}
	}

	public DxSpotBlockCacheCfg DxSpotBlock
	{
		get
		{
			byte[] ⴅ = SetTalkCountHelp.Ⴅ;
			DxSpotBlockCacheCfg ⴃ = Ⴃ;
			ႨႣ.Ⴐ[83] = (byte)((ႨႣ.Ⴐ[83] * ႨႣ.Ⴐ[272]) & 0x3D);
			return ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	public FocCacheCfg Foc
	{
		get
		{
			return this.m_Ⴜ.Ⴐ;
		}
		set
		{
			this.m_Ⴜ.Ⴐ = value as FocCacheCfg;
		}
	}

	public IpLockoutCacheCfg IpLockout
	{
		get
		{
			return this.m_Ⴜ.Ⴄ;
		}
		set
		{
			this.m_Ⴜ.Ⴄ = value;
		}
	}

	public LogCacheCfg Log
	{
		get
		{
			return this.Ⴍ;
		}
		set
		{
			this.Ⴍ = value;
		}
	}

	public LotwCacheCfg Lotw
	{
		get
		{
			return this.m_Ⴜ.Ⴅ;
		}
		set
		{
			this.m_Ⴜ.Ⴅ = value as LotwCacheCfg;
		}
	}

	public MailCacheCfg Mail
	{
		get
		{
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	public MasterCallCacheCfg MasterCall
	{
		get
		{
			return this.m_Ⴜ.Ⴜ;
		}
		set
		{
			this.m_Ⴜ.Ⴜ = value;
		}
	}

	public NodeCacheCfg Node
	{
		get
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	public TalkCacheCfg Talk
	{
		get
		{
			return Ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	public Top100CacheCfg Top100
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			return this.m_Ⴜ.ႣႭ;
		}
		set
		{
			this.m_Ⴜ.ႣႭ = value;
		}
	}

	public UserCacheCfg User
	{
		get
		{
			UserCacheCfg ⴃႣ = this.m_Ⴜ.ႣႣ;
			ShowWwvOptionsHelp.ႣႥ[372] = (char)(ShowWwvOptionsHelp.ႣႥ[372] & ShowWwvOptionsHelp.ႣႥ[360] & 0x88);
			return ⴃႣ;
		}
		set
		{
			this.m_Ⴜ.ႣႣ = value;
		}
	}

	public WwvCacheCfg Wwv
	{
		get
		{
			return this.m_Ⴜ.ႣႠ;
		}
		set
		{
			this.m_Ⴜ.ႣႠ = value;
		}
	}

	public WxCacheCfg Wx
	{
		get
		{
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			return this.m_Ⴜ.ႣႨ;
		}
		set
		{
			this.m_Ⴜ.ႣႨ = value as WxCacheCfg;
		}
	}

	public CacheCfgManager()
	{
		Ann = new AnnCacheCfg();
		BadWord = new BadWordCacheCfg();
		BandMode = new BandModeCacheCfg();
		Callbook = new CallbookCfg();
		ChatRoomPvt = new ChatRoomPvtCfg();
		ChatRoomPub = new ChatRoomPubCfg();
		Cty = new CtyCacheCfg();
		DxCluster = new DxClusterCacheCfg();
		DxSpotBlock = new DxSpotBlockCacheCfg();
		Dx = new DxCacheCfg();
		Foc = new FocCacheCfg();
		IpLockout = new IpLockoutCacheCfg();
		Log = new LogCacheCfg();
		Lotw = new LotwCacheCfg();
		Mail = new MailCacheCfg();
		MasterCall = new MasterCallCacheCfg();
		Node = new NodeCacheCfg();
		Talk = new TalkCacheCfg();
		Top100 = new Top100CacheCfg();
		CallBlock = new CallBlockCacheCfg();
		ConnectBlock = new ConnectBlockCacheCfg();
		User = new UserCacheCfg();
		Wwv = new WwvCacheCfg();
		Wx = new WxCacheCfg();
	}

	public override string ToString()
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		return SetStationClubHelp.Ⴍ(9, 6, 1747263403, null);
	}

	[SecuritySafeCritical]
	internal static string Ⴜ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : IrcMessageData
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
					break;
				case 0:
				case 2:
					num2 = (((P_2 ^ P_1) - 69) ^ num) switch
					{
						0 => ⴃႥ[83] - 54511, 
						_ => ⴀ[451] - 7735, 
					};
					continue;
				case 3:
					obj = null;
					num2 = 8;
					continue;
				case 1:
					obj = P_0.Channel;
					num2 = 8;
					continue;
				case 6:
				case 8:
				{
					num++;
					int num3 = (P_1 * P_1 + P_1) % 2;
					SetTalkCountHelp.Ⴅ[16] = (byte)((SetTalkCountHelp.Ⴅ[16] * SetWxOutput.ႣႰ[41]) & 0xFF);
					num2 = ((num3 == 0) ? (ⴀႳ[180] - 40971) : 10);
					continue;
				}
				case 10:
					num2 = ⴃႥ[136] - 30633;
					continue;
				case 4:
					return obj as string;
				case 11:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}
}
