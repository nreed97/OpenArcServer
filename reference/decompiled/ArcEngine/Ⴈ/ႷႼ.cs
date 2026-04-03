using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using System.Timers;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using log4net;

namespace Ⴈ;

internal sealed class ႷႼ : IIoClient
{
	private static readonly ILog m_Ⴐ = SkimmerValidSpot.Ⴐ(CallBlockCacheCfg.Ⴅ(null, 6, 62055022, null), 138, 151);

	private OnIoClientConnectEventHandler Ⴅ;

	private ConnectionState m_Ⴀ;

	private string Ⴗ;

	private IIoDeviceCfg m_Ⴀ;

	private PrintDxFilters.Ⴀ Ⴜ = new PrintDxFilters.Ⴀ();

	[SpecialName]
	public void add_OnRxEvent(OnIoClientRxEventHandler P_0)
	{
		int num = 6;
		MulticastDelegate multicastDelegate = default(MulticastDelegate);
		MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
		MulticastDelegate multicastDelegate3 = default(MulticastDelegate);
		while (true)
		{
			switch (num)
			{
			default:
				multicastDelegate = Ⴜ.Ⴄ;
				num = 1;
				break;
			case 1:
			case 5:
				multicastDelegate2 = (OnIoClientRxEventHandler)multicastDelegate;
				multicastDelegate3 = (OnIoClientRxEventHandler)Clear.Ⴗ((Delegate)(OnIoClientRxEventHandler)multicastDelegate2, (Delegate)P_0, 99, 100);
				num = 7;
				break;
			case 7:
				multicastDelegate = Interlocked.CompareExchange(ref Ⴜ.Ⴄ, (OnIoClientRxEventHandler)multicastDelegate3, (OnIoClientRxEventHandler)multicastDelegate2);
				num = 0;
				break;
			case 0:
			case 2:
				num = (((object)(OnIoClientRxEventHandler)multicastDelegate != (OnIoClientRxEventHandler)multicastDelegate2) ? 1 : 3);
				break;
			case 3:
				return;
			}
		}
	}

	[SpecialName]
	public void remove_OnRxEvent(OnIoClientRxEventHandler P_0)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 4;
		MulticastDelegate multicastDelegate = default(MulticastDelegate);
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				multicastDelegate = Ⴜ.Ⴄ;
				num = 6;
				break;
			case 6:
				obj = multicastDelegate as OnIoClientRxEventHandler;
				obj2 = (OnIoClientRxEventHandler)ReadMail.Ⴈ((Delegate)(OnIoClientRxEventHandler)obj, (Delegate)P_0, 'ʃ', 'ˍ');
				num = ⴀႣ[357] - 31392;
				break;
			case 1:
			case 3:
			case 5:
				multicastDelegate = Interlocked.CompareExchange(ref Ⴜ.Ⴄ, (OnIoClientRxEventHandler)obj2, (OnIoClientRxEventHandler)obj);
				num = 7;
				break;
			case 0:
			case 7:
				num = (((object)(OnIoClientRxEventHandler)multicastDelegate != obj as OnIoClientRxEventHandler) ? (ⴃႠ[416] - 8137) : 2);
				break;
			case 2:
				return;
			}
		}
	}

	[SpecialName]
	public void add_OnConnectEvent(OnIoClientConnectEventHandler P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 6;
		MulticastDelegate multicastDelegate = default(MulticastDelegate);
		MulticastDelegate multicastDelegate3 = default(MulticastDelegate);
		MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
		while (true)
		{
			switch (num)
			{
			default:
			{
				multicastDelegate = Ⴅ;
				byte num2 = ⴐ[73];
				ႨႣ.Ⴐ[261] = (byte)((ႨႣ.Ⴐ[261] | ႨႣ.Ⴐ[200]) & 0xF9);
				num = num2 - 218;
				break;
			}
			case 2:
			case 5:
				multicastDelegate3 = multicastDelegate as OnIoClientConnectEventHandler;
				multicastDelegate2 = (OnIoClientConnectEventHandler)Clear.Ⴗ((Delegate)(OnIoClientConnectEventHandler)multicastDelegate3, (Delegate)P_0, 393, 398);
				goto case 3;
			case 3:
				num = 1;
				break;
			case 1:
				multicastDelegate = Interlocked.CompareExchange(ref Ⴅ, multicastDelegate2 as OnIoClientConnectEventHandler, multicastDelegate3 as OnIoClientConnectEventHandler);
				num = (((object)(multicastDelegate as OnIoClientConnectEventHandler) != multicastDelegate3 as OnIoClientConnectEventHandler) ? 5 : ⴄႭ[66]);
				break;
			case 0:
				return;
			}
		}
	}

	[SpecialName]
	public void remove_OnConnectEvent(OnIoClientConnectEventHandler P_0)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
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
				multicastDelegate = Ⴅ;
				num = ⴄႭ[381] - 232;
				break;
			case 4:
				obj2 = multicastDelegate as OnIoClientConnectEventHandler;
				obj = (OnIoClientConnectEventHandler)ReadMail.Ⴈ((Delegate)(obj2 as OnIoClientConnectEventHandler), (Delegate)P_0, 'Ī', 'Ť');
				goto case 2;
			case 2:
				num = 1;
				break;
			case 1:
				multicastDelegate = Interlocked.CompareExchange(ref Ⴅ, obj as OnIoClientConnectEventHandler, obj2 as OnIoClientConnectEventHandler);
				num = (((object)(multicastDelegate as OnIoClientConnectEventHandler) != obj2 as OnIoClientConnectEventHandler) ? 4 : (ⴀႨ[129] - 39315));
				break;
			case 3:
			case 6:
				return;
			}
		}
	}

	[SpecialName]
	public void add_OnDisconnectEvent(OnIoClientDisconnectEventHandler P_0)
	{
		int num = 7;
		MulticastDelegate multicastDelegate = default(MulticastDelegate);
		object obj = default(object);
		MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
		while (true)
		{
			switch (num)
			{
			default:
				multicastDelegate = Ⴜ.Ⴀ;
				num = 3;
				break;
			case 3:
				obj = (OnIoClientDisconnectEventHandler)multicastDelegate;
				multicastDelegate2 = (OnIoClientDisconnectEventHandler)Clear.Ⴗ((Delegate)(OnIoClientDisconnectEventHandler)obj, (Delegate)P_0, 551, 544);
				num = 2;
				break;
			case 2:
				multicastDelegate = Interlocked.CompareExchange(ref Ⴜ.Ⴀ, (OnIoClientDisconnectEventHandler)multicastDelegate2, (OnIoClientDisconnectEventHandler)obj);
				goto case 6;
			case 6:
				num = 4;
				break;
			case 4:
				num = (((object)(OnIoClientDisconnectEventHandler)multicastDelegate != (OnIoClientDisconnectEventHandler)obj) ? 3 : 5);
				break;
			case 5:
				return;
			}
		}
	}

	[SpecialName]
	public void remove_OnDisconnectEvent(OnIoClientDisconnectEventHandler P_0)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 2;
		object obj = default(object);
		object obj2 = default(object);
		MulticastDelegate multicastDelegate = default(MulticastDelegate);
		while (true)
		{
			switch (num)
			{
			default:
				obj = Ⴜ.Ⴀ;
				num = ⴀႣ[348] - 32294;
				break;
			case 1:
			case 3:
				obj2 = (OnIoClientDisconnectEventHandler)obj;
				multicastDelegate = (OnIoClientDisconnectEventHandler)ReadMail.Ⴈ((Delegate)(OnIoClientDisconnectEventHandler)obj2, (Delegate)P_0, 'Ɇ', 'Ȉ');
				goto case 5;
			case 5:
				num = 4;
				break;
			case 4:
				obj = Interlocked.CompareExchange(ref Ⴜ.Ⴀ, multicastDelegate as OnIoClientDisconnectEventHandler, obj2 as OnIoClientDisconnectEventHandler);
				num = ⴀႳ[4] - ⴀႳ[4];
				break;
			case 0:
				num = (((object)(OnIoClientDisconnectEventHandler)obj != (OnIoClientDisconnectEventHandler)obj2) ? (ⴃႥ[338] - 3853) : (ⴀႣ[327] - 61015));
				break;
			case 6:
				return;
			}
		}
	}

	[SpecialName]
	public ConnectionState get_ConnectionState()
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		return this.m_Ⴀ;
	}

	[SpecialName]
	public void set_ConnectionState(ConnectionState P_0)
	{
		this.m_Ⴀ = P_0;
	}

	[SpecialName]
	public string get_EndPoint()
	{
		return Ⴗ;
	}

	[SpecialName]
	public void set_EndPoint(string P_0)
	{
		Ⴗ = P_0;
	}

	[SpecialName]
	public DateTime get_LastSendDts()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		return Ⴜ.Ⴓ;
	}

	[SpecialName]
	public void set_LastSendDts(DateTime P_0)
	{
		Ⴜ.Ⴓ = P_0;
	}

	[SpecialName]
	public int Ⴄ()
	{
		return Ⴜ.Ⴐ;
	}

	[SpecialName]
	public void Ⴓ(int P_0)
	{
		Ⴜ.Ⴐ = P_0;
	}

	[SpecialName]
	public int get_LastTenMinuteDxDupeCnt()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		return Ⴜ.Ⴈ;
	}

	[SpecialName]
	public void set_LastTenMinuteDxDupeCnt(int P_0)
	{
		Ⴜ.Ⴈ = P_0;
	}

	[SpecialName]
	public int Ⴀ()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		return Ⴜ.Ⴍ;
	}

	[SpecialName]
	public void Ⴄ(int P_0)
	{
		Ⴜ.Ⴍ = P_0;
	}

	[SpecialName]
	public int get_TenMinuteDxDupeCnt()
	{
		return Ⴜ.Ⴅ;
	}

	[SpecialName]
	public void set_TenMinuteDxDupeCnt(int P_0)
	{
		Ⴜ.Ⴅ = P_0;
	}

	[SpecialName]
	public DateTime get_ConnectDts()
	{
		return Ⴜ.Ⴜ;
	}

	[SpecialName]
	public void set_ConnectDts(DateTime P_0)
	{
		Ⴜ.Ⴜ = P_0;
	}

	[SpecialName]
	public double[] get_DxSpotRate()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		return Ⴜ.ႠႤ;
	}

	[SpecialName]
	public void set_DxSpotRate(double[] P_0)
	{
		Ⴜ.ႠႤ = P_0 as double[];
	}

	[SpecialName]
	public IIoDeviceCfg get_IoCfg()
	{
		return this.m_Ⴀ;
	}

	[SpecialName]
	public void set_IoCfg(IIoDeviceCfg P_0)
	{
		this.m_Ⴀ = P_0;
	}

	[SpecialName]
	public bool get_IsConnected()
	{
		ShowWwvOptionsHelp.ႣႥ[54] = (char)((ShowWwvOptionsHelp.ႣႥ[54] * ShowWwvOptionsHelp.ႣႥ[63]) & 0x93);
		return true;
	}

	public ႷႼ()
	{
		set_DxSpotRate(new double[60]);
		set_ConnectDts(DateTime.MinValue);
		object obj = new ႳႰ();
		Ⴜ.Ⴗ = obj as ႳႰ;
		Component component = new System.Timers.Timer(15000.0);
		Ⴜ.Ⴃ = component as System.Timers.Timer;
		TalkHelp.Ⴈ<System.Timers.Timer, ElapsedEventHandler>(Ⴜ.Ⴃ, Ⴄ, 394, 441);
	}

	public void Connect()
	{
		DxCacheCfg.Ⴓ(Ⴜ.Ⴃ, true, 161, 'û');
		AnnCacheCfg.ႠႼ[135] = (byte)((AnnCacheCfg.ႠႼ[135] * AnnCacheCfg.ႠႼ[57]) & 0xF8);
	}

	public void Disconnect()
	{
		DxCacheCfg.Ⴓ(Ⴜ.Ⴃ, false, 71, '\u001d');
	}

	private void Ⴄ(object P_0, ElapsedEventArgs P_1)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 1;
		CriticalFinalizerObject criticalFinalizerObject = default(CriticalFinalizerObject);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				criticalFinalizerObject = new Thread(Ⴐ);
				TalkCacheCfg.Ⴀ(criticalFinalizerObject as Thread, ThreadPriority.BelowNormal, 569, 537);
				num = 4;
				continue;
			case 4:
			{
				ႰႰ.Ⴈ((Thread)criticalFinalizerObject, ShowWxHelp.Ⴍ('4', 985805967, 3), '\u02d8', 760);
				byte num2 = ⴐ[303];
				AnnCacheCfg.ႠႼ[62] = (byte)((AnnCacheCfg.ႠႼ[62] | AnnCacheCfg.ႠႼ[39]) & 0x8B);
				num = num2 - 110;
				continue;
			}
			case 2:
				obj = criticalFinalizerObject as Thread;
				goto case 5;
			case 5:
				(obj as Thread).IsBackground = true;
				break;
			case 3:
				break;
			}
			break;
		}
		(obj as Thread).Start();
	}

	private void Ⴐ()
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				return;
			}
			IConvertible convertible = Ⴜ.Ⴗ.Ⴀ();
			if (ႰႨ.ႥႥ(convertible as string, 'ǅ', 'ǣ'))
			{
				num = 3;
				continue;
			}
			OnRx((string)convertible);
			return;
		}
	}

	public bool Send(byte[] P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		return true;
	}

	public bool Send(string P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		long num2 = default(long);
		while (true)
		{
			set_LastSendDts(ShowAnnHelp.Ⴅ('Ⱥ', 523));
			while (true)
			{
				IL_004d:
				int num = (ႰႨ.ႥႥ(P_0, 'ʊ', 'ʬ') ? (ⴄႤ[47] / 2) : 2);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 3;
						continue;
					case 3:
						break;
					case 1:
					case 7:
						goto IL_004d;
					case 2:
						num = ((!SkimmerValidSpot.Ⴈ(P_0, 353, 277)) ? 6 : 4);
						continue;
					case 4:
						num2 = NodeUserCmd.Ⴜ(P_0, 518, 599);
						goto case 5;
					case 5:
						Ⴜ.Ⴗ.Ⴅ(num2);
						goto case 6;
					case 6:
						DirectoryBulletin.ႠႨ[138] = (DirectoryBulletin.ႠႨ[138] | DirectoryBulletin.ႠႨ[0]) & 0x32;
						return true;
					}
					break;
				}
				break;
			}
		}
	}

	public void OnConnect(string P_0)
	{
		_ = Ⴅ;
	}

	public void OnDisconnect(string P_0)
	{
		_ = Ⴜ.Ⴀ;
	}

	public void OnRx(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 3;
		while (true)
		{
			int num3;
			switch (num)
			{
			default:
				if (Ⴜ.Ⴄ != null)
				{
					char num2 = ⴃႥ[278];
					SetTalkCountHelp.Ⴅ[388] = (byte)((SetTalkCountHelp.Ⴅ[388] - SetTalkCountHelp.Ⴅ[135]) & 0x10);
					num3 = num2 - 35276;
				}
				else
				{
					num3 = ⴄႤ[148];
				}
				break;
			case 0:
				SetAnnFilter.Ⴀ(Ⴜ.Ⴄ, P_0, 179, 201);
				return;
			case 1:
			case 5:
				return;
			}
			num = num3;
		}
	}
}
