using System;
using System.Collections;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Xml.Linq;
using ArcEngine.ArcCaches;
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
using ArcEngine.ArcCmds.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using ArcInterfaces.Spots;
using HtmlAgilityPack;
using Meebey.SmartIrc4net;
using Ⴈ;

namespace ArcEngine.ArcIo.Mirc;

public sealed class MircIo : IIoClient
{
	[StructLayout(LayoutKind.Auto)]
	internal struct ႠႭ
	{
		internal ObjectManager Ⴀ;

		internal int Ⴈ;

		internal int Ⴅ;
	}

	private OnIoClientRxEventHandler Ⴄ;

	private OnIoClientConnectEventHandler m_Ⴍ;

	private OnIoClientDisconnectEventHandler m_Ⴀ;

	private IrcClient m_Ⴃ;

	private ConnectionState m_Ⴃ;

	private int Ⴓ;

	private ReplyMailHelp.Ⴅ m_Ⴈ = new ReplyMailHelp.Ⴅ();

	public ConnectionState ConnectionState
	{
		get
		{
			return this.m_Ⴃ;
		}
		set
		{
			this.m_Ⴃ = value;
		}
	}

	public string EndPoint
	{
		get
		{
			char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
			return this.m_Ⴈ.Ⴈ;
		}
		set
		{
			this.m_Ⴈ.Ⴈ = value as string;
			SetAnnChatRooms.Ⴀ[62] = (char)((SetAnnChatRooms.Ⴀ[62] - SetAnnChatRooms.Ⴀ[162]) & 0x50);
		}
	}

	public DateTime LastSendDts
	{
		get
		{
			return this.m_Ⴈ.Ⴀ;
		}
		set
		{
			this.m_Ⴈ.Ⴀ = value;
		}
	}

	public int LastTenMinuteDxCnt
	{
		get
		{
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			return this.m_Ⴈ.Ⴗ;
		}
		set
		{
			this.m_Ⴈ.Ⴗ = value;
		}
	}

	public int LastTenMinuteDxDupeCnt
	{
		get
		{
			char[] ⴃႰ = SetWxOutput.ႣႰ;
			return this.m_Ⴈ.Ⴍ;
		}
		set
		{
			this.m_Ⴈ.Ⴍ = value;
		}
	}

	public int TenMinuteDxCnt
	{
		get
		{
			byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
			int ⴓ = Ⴓ;
			SetWxOutput.ႣႰ[102] = (char)(SetWxOutput.ႣႰ[102] & SetWxOutput.ႣႰ[87] & 0xA7);
			return ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	public int TenMinuteDxDupeCnt
	{
		get
		{
			return this.m_Ⴈ.Ⴐ;
		}
		set
		{
			this.m_Ⴈ.Ⴐ = value;
			SetWxOutput.ႣႰ[96] = (char)((SetWxOutput.ႣႰ[96] - value) & 0xC0);
		}
	}

	public DateTime ConnectDts
	{
		get
		{
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			return this.m_Ⴈ.Ⴄ;
		}
		set
		{
			this.m_Ⴈ.Ⴄ = value;
		}
	}

	public double[] DxSpotRate
	{
		get
		{
			double[] ⴅ = this.m_Ⴈ.Ⴅ;
			ShowSunHelp.ႣႠ[401] = (char)(ShowSunHelp.ႣႠ[401] & ShowSunHelp.ႣႠ[213] & 0xB4);
			return ⴅ;
		}
		set
		{
			this.m_Ⴈ.Ⴅ = value;
		}
	}

	public IIoDeviceCfg IoCfg
	{
		get
		{
			IIoDeviceCfg ⴃ = this.m_Ⴈ.Ⴃ;
			SetAnnMode.ႤႭ[326] = (byte)((SetAnnMode.ႤႭ[326] - SetAnnMode.ႤႭ[29]) & 0x5B);
			return ⴃ;
		}
		set
		{
			this.m_Ⴈ.Ⴃ = value as IIoDeviceCfg;
		}
	}

	public bool IsConnected
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			while (true)
			{
				int num = ((this.m_Ⴃ == null) ? (ⴃႥ[366] - 28054) : 0);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႥ[243] - 40668;
						continue;
					case 3:
					case 4:
						break;
					case 0:
					case 5:
						return DirectorySubject.Ⴄ((IrcConnection)this.m_Ⴃ, 583, (short)625);
					case 2:
					case 6:
						return false;
					}
					break;
				}
			}
		}
	}

	public event OnIoClientRxEventHandler OnRxEvent
	{
		add
		{
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			int[] ⴀႨ = DirectoryBulletin.ႠႨ;
			int num = 5;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj2 = default(object);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = Ⴄ;
					num = ⴀႣ[248] - 37920;
					continue;
				case 2:
				case 6:
					obj2 = multicastDelegate as OnIoClientRxEventHandler;
					obj = (OnIoClientRxEventHandler)Clear.Ⴗ((Delegate)(OnIoClientRxEventHandler)obj2, (Delegate)value, 41, 46);
					num = ⴀႨ[14] - 1834;
					continue;
				case 1:
					multicastDelegate = Interlocked.CompareExchange(ref Ⴄ, obj as OnIoClientRxEventHandler, (OnIoClientRxEventHandler)obj2);
					break;
				case 4:
					break;
				case 3:
					return;
				}
				num = (((object)(OnIoClientRxEventHandler)multicastDelegate != (OnIoClientRxEventHandler)obj2) ? 2 : 3);
			}
		}
		remove
		{
			byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
			int num = 6;
			object obj = default(object);
			object obj3 = default(object);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj = Ⴄ;
					num = 4;
					break;
				case 4:
					obj3 = obj as OnIoClientRxEventHandler;
					obj2 = (OnIoClientRxEventHandler)ReadMail.Ⴈ((Delegate)(OnIoClientRxEventHandler)obj3, (Delegate)value, 'Ʊ', 'ǿ');
					goto case 5;
				case 5:
					num = ⴀႼ[65] - 17;
					break;
				case 0:
				case 3:
					obj = Interlocked.CompareExchange(ref Ⴄ, obj2 as OnIoClientRxEventHandler, (OnIoClientRxEventHandler)obj3);
					num = (((object)(OnIoClientRxEventHandler)obj != obj3 as OnIoClientRxEventHandler) ? 4 : 2);
					break;
				case 2:
					return;
				}
			}
		}
	}

	public event OnIoClientConnectEventHandler OnConnectEvent
	{
		add
		{
			byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
			int[] ⴀႨ = DirectoryBulletin.ႠႨ;
			int num = 5;
			object obj = default(object);
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj = this.m_Ⴍ;
					num = 6;
					break;
				case 6:
					multicastDelegate = (OnIoClientConnectEventHandler)obj;
					goto case 2;
				case 2:
					obj2 = (OnIoClientConnectEventHandler)Clear.Ⴗ((Delegate)(OnIoClientConnectEventHandler)multicastDelegate, (Delegate)value, 78, 73);
					num = 3;
					break;
				case 3:
					obj = Interlocked.CompareExchange(ref this.m_Ⴍ, (OnIoClientConnectEventHandler)obj2, (OnIoClientConnectEventHandler)multicastDelegate);
					num = (((object)(OnIoClientConnectEventHandler)obj != multicastDelegate as OnIoClientConnectEventHandler) ? (ⴀႨ[121] - 384) : (ⴄႤ[50] / 6));
					break;
				case 4:
					return;
				}
			}
		}
		remove
		{
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			byte[] ⴅ = SetTalkCountHelp.Ⴅ;
			int num = 1;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			MulticastDelegate multicastDelegate3 = default(MulticastDelegate);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = this.m_Ⴍ;
					num = ⴍႤ[201] - 14716;
					break;
				case 6:
					multicastDelegate3 = (OnIoClientConnectEventHandler)multicastDelegate;
					multicastDelegate2 = (OnIoClientConnectEventHandler)ReadMail.Ⴈ((Delegate)(OnIoClientConnectEventHandler)multicastDelegate3, (Delegate)value, 'Ȣ', 'ɬ');
					goto case 3;
				case 3:
					num = 0;
					break;
				case 0:
				case 2:
					multicastDelegate = Interlocked.CompareExchange(ref this.m_Ⴍ, multicastDelegate2 as OnIoClientConnectEventHandler, multicastDelegate3 as OnIoClientConnectEventHandler);
					num = (((object)(OnIoClientConnectEventHandler)multicastDelegate != multicastDelegate3 as OnIoClientConnectEventHandler) ? (ⴅ[325] - 21) : 4);
					break;
				case 4:
					return;
				}
			}
		}
	}

	public event OnIoClientDisconnectEventHandler OnDisconnectEvent
	{
		add
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			int num = 3;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = this.m_Ⴀ;
					num = 5;
					break;
				case 2:
				case 5:
					multicastDelegate2 = multicastDelegate as OnIoClientDisconnectEventHandler;
					goto case 6;
				case 6:
					obj = (OnIoClientDisconnectEventHandler)Clear.Ⴗ((Delegate)(multicastDelegate2 as OnIoClientDisconnectEventHandler), (Delegate)value, 405, 402);
					goto case 0;
				case 0:
					num = ⴄႷ[52] - 60818;
					break;
				case 4:
					multicastDelegate = Interlocked.CompareExchange(ref this.m_Ⴀ, obj as OnIoClientDisconnectEventHandler, multicastDelegate2 as OnIoClientDisconnectEventHandler);
					num = (((object)(OnIoClientDisconnectEventHandler)multicastDelegate == (OnIoClientDisconnectEventHandler)multicastDelegate2) ? 1 : 5);
					break;
				case 1:
					return;
				}
			}
		}
		remove
		{
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
			int num = 3;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			MulticastDelegate multicastDelegate3 = default(MulticastDelegate);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = this.m_Ⴀ;
					num = 5;
					continue;
				case 2:
				case 5:
					multicastDelegate3 = (OnIoClientDisconnectEventHandler)multicastDelegate;
					multicastDelegate2 = (OnIoClientDisconnectEventHandler)ReadMail.Ⴈ((Delegate)(multicastDelegate3 as OnIoClientDisconnectEventHandler), (Delegate)value, 'Č', 'ł');
					num = 1;
					continue;
				case 0:
				case 1:
					multicastDelegate = Interlocked.CompareExchange(ref this.m_Ⴀ, (OnIoClientDisconnectEventHandler)multicastDelegate2, (OnIoClientDisconnectEventHandler)multicastDelegate3);
					break;
				case 4:
					break;
				case 6:
					return;
				}
				num = (((object)(multicastDelegate as OnIoClientDisconnectEventHandler) != multicastDelegate3 as OnIoClientDisconnectEventHandler) ? (ⴀႼ[51] - 159) : (ⴍႤ[159] - 11931));
			}
		}
	}

	public MircIo(IIoDeviceCfg ioDeviceCfg)
	{
		IoCfg = ioDeviceCfg;
		DxSpotRate = new double[60];
		ConnectDts = DateTime.MinValue;
		this.m_Ⴃ = new IrcClient();
		OperatingHelp.Ⴅ<EventHandler, IrcConnection>(this.m_Ⴃ, Ⴃ, 744, '\u02fd');
		MailHelper.Ⴍ<IrcEventHandler, IrcClient>(this.m_Ⴃ, Ⴀ, 'ƚ', 442);
		this.m_Ⴃ.OnDisconnected += Ⴍ;
	}

	public void Connect()
	{
		ConnectDts = DateTime.MinValue;
		try
		{
			WwvSpotUser.Ⴃ((IrcConnection)this.m_Ⴃ, IoCfg.IpAddress, IoCfg.Port, 539, 522);
		}
		catch (Exception)
		{
		}
	}

	private void Ⴍ(object P_0, EventArgs P_1)
	{
		OnDisconnect(ShowWxHelp.Ⴍ('Ã', 985806439, 0));
	}

	private void Ⴃ(object P_0, EventArgs P_1)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		try
		{
			int num = 1;
			CriticalFinalizerObject criticalFinalizerObject = default(CriticalFinalizerObject);
			while (true)
			{
				switch (num)
				{
				default:
					OnConnect(ShowSkimCtyHelp.Ⴍ(1216135064, 7, 'q'));
					SetDxDefault.Ⴓ(this.m_Ⴃ, IoCfg.ConnectAs, IoCfg.ConnectAs, 0, IoCfg.ConnectAs, 'Ǐ', 'Ƌ');
					num = ⴍႭ[358] - 50455;
					continue;
				case 4:
					ႰႨ.ႥႣ((IrcCommands)this.m_Ⴃ, IoCfg.ConnectTo, (short)263, 276);
					criticalFinalizerObject = new Thread(this.m_Ⴃ.Listen);
					num = 5;
					continue;
				case 3:
				case 5:
					TalkCacheCfg.Ⴀ(criticalFinalizerObject as Thread, ThreadPriority.BelowNormal, 473, 505);
					goto case 7;
				case 7:
					ႰႰ.Ⴈ(criticalFinalizerObject as Thread, SetWxCountHelp.Ⴗ((object)SetStationClubHelp.Ⴍ(5, 0, 1747263184, null), (object)IoCfg.Port, 468, (short)431), 'Œ', 370);
					num = 0;
					continue;
				case 0:
				{
					object obj = criticalFinalizerObject as Thread;
					((Thread)obj).IsBackground = true;
					(obj as Thread).Start();
					break;
				}
				}
				break;
			}
		}
		catch (Exception ex)
		{
			OnDisconnect((ex as Exception).Message);
		}
		switch (0)
		{
		}
	}

	private void Ⴀ(object P_0, IrcEventArgs P_1)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!ByeHelp.Ⴍ(UserCacheCfg.Ⴃ((object)BadWordCacheCfg.Ⴗ(SetWwvDefault.Ⴃ(P_1, 825, '\u0303'), 831, '\u034e'), 'Ȳ', 601), ShowSkimCtyHelp.Ⴍ(1216132176, 2, 'ò'), 181, 210)) ? 7 : (ⴀႳ[308] - 13032));
				break;
			case 3:
			case 4:
				num = ((!(CacheCfgManager.Ⴜ(SetWwvDefault.Ⴃ(P_1, 294, 'Ĝ'), 911, 970) == IoCfg.ConnectTo)) ? ⴄႭ[94] : 6);
				break;
			case 6:
				num = ((!(P_1.Data.Nick == ႨႨ.Ⴀ(11, 1, 1157904751))) ? (ⴍႤ[402] - 27285) : (ⴐ[0] - 48));
				break;
			case 1:
				OnRx(P_1.Data.Message);
				return;
			case 0:
			case 2:
			case 7:
				return;
			}
		}
	}

	public bool Send(byte[] data)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		LastSendDts = ShowAnnHelp.Ⴅ('Ü', 237);
		return true;
	}

	public bool Send(string msg)
	{
		LastSendDts = ShowAnnHelp.Ⴅ('ɲ', 579);
		return true;
	}

	public void Disconnect()
	{
		ShowLogHelp.Ⴄ((IrcConnection)this.m_Ⴃ, 771, 800);
	}

	public void OnConnect(string msg)
	{
		int num = 2;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((this.m_Ⴍ != null) ? 5 : 0);
				break;
			case 4:
			case 5:
				SkimDupeDat.Ⴓ(this.m_Ⴍ, msg, 433, 412);
				return;
			case 0:
			case 3:
				return;
			}
			num = num2;
		}
	}

	public void OnDisconnect(string msg)
	{
		int num = 0;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((this.m_Ⴀ != null) ? 1 : 3);
				break;
			case 1:
				LogCacheCfg.Ⴍ(this.m_Ⴀ, msg, 863, 845);
				return;
			case 2:
			case 3:
			case 4:
			case 5:
				return;
			}
			num = num2;
		}
	}

	public void OnRx(string msg)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 5;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((Ⴄ == null) ? (ⴀႣ[264] - 37763) : (ⴍႭ[366] - 19218));
				break;
			case 2:
			case 3:
			case 4:
				SetAnnFilter.Ⴀ(Ⴄ, msg, 197, 191);
				ShowSunHelp.ႣႠ[218] = (char)((ShowSunHelp.ႣႠ[218] - SetAnnChatRooms.Ⴀ[347]) & 0xBD);
				return;
			case 1:
				return;
			}
			num = num2;
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210>(_0021_00210 P_0, float P_1, int P_2, int P_3) where _0021_00210 : DxSpot
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				continue;
			case 5:
			case 6:
				num = (((P_2 ^ P_3) - 86) ^ num2) switch
				{
					0 => ⴍႭ[331] - 20129, 
					1 => ⴃႠ[293] - 12945, 
					_ => 0, 
				};
				continue;
			case 0:
				num = 3;
				continue;
			case 4:
				P_0.Freq = P_1;
				num = 3;
				continue;
			case 2:
			case 8:
				P_0.Band = P_1;
				break;
			case 3:
				break;
			case 1:
				return;
			}
			num2++;
			int num3 = 448;
			int num4 = 150;
			num = ((224 >= num3 / 2 - num4) ? 1 : 6);
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DxSpot
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		IComparable comparable = default(IComparable);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 7;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[6];
					continue;
				case 0:
					break;
				case 7:
					num2 = (((P_2 ^ P_1) - 65) ^ num) switch
					{
						0 => 2, 
						_ => 4, 
					};
					continue;
				case 4:
					comparable = null;
					num2 = 6;
					continue;
				case 2:
				case 8:
					comparable = P_0.SpotterState;
					num2 = ⴃႰ[176] - 25988;
					continue;
				case 6:
					num++;
					num3 = 1704;
					num4 = 274;
					goto case 10;
				case 10:
					num2 = ((852 < num3 / 2 - num4) ? ⴐ[257] : 3);
					continue;
				case 3:
				case 5:
					return comparable as string;
				case 9:
					num2 = ⴀႣ[430] - 15572;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴜ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : XName
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			int num = 0;
			int num2 = 9;
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
				case 9:
					num2 = (((P_2 ^ P_1) - 14) ^ num) switch
					{
						0 => 1, 
						_ => 0, 
					};
					continue;
				case 0:
				case 3:
					enumerable = null;
					num2 = ⴄႭ[246];
					continue;
				case 1:
					enumerable = P_0.LocalName;
					num2 = ⴐ[243] / 4;
					continue;
				case 2:
				case 4:
				{
					num++;
					int num3 = 50;
					int num4 = 359;
					num2 = ((2154 > num4 - num3 * 6) ? 8 : 6);
					continue;
				}
				case 6:
					num2 = ⴃႥ[234] - 38047;
					continue;
				case 8:
					return enumerable as string;
				case 10:
					num2 = ⴀႣ[260] - 55969;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႠႠ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : HtmlNode
	{
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = 10;
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
				case 10:
					num2 = (((P_1 ^ P_2) - 84) ^ num) switch
					{
						0 => 8, 
						_ => 3, 
					};
					continue;
				case 3:
					convertible = null;
					num2 = 7;
					continue;
				case 8:
				case 9:
					convertible = P_0.Name;
					num2 = 7;
					continue;
				case 2:
				case 7:
				{
					num++;
					int num3 = 688;
					int num4 = 133;
					num2 = ((172 >= num3 / 4 - num4) ? 1 : 10);
					continue;
				}
				case 1:
					return convertible as string;
				case 4:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}
}
