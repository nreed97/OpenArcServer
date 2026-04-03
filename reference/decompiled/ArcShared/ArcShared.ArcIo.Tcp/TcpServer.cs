using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Threading;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.Constants;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Extensions;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.Forms;
using ArcShared.MaintenanceUpdates;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using Ⴃ;

namespace ArcShared.ArcIo.Tcp;

public abstract class TcpServer : IIoServer
{
	private static readonly ILog Ⴃ = ArcLogInRqstExt.Ⴍ(ArcLogInRqstExt.Ⴗ(1706507134, 16, 0), 320, 287);

	private OnIoServerConnectEventHandler m_Ⴐ;

	private readonly int m_Ⴀ;

	protected readonly ArrayList _connectedClients;

	protected readonly ConcurrentQueue<TcpServerClient> Queue = new ConcurrentQueue<TcpServerClient>();

	private readonly Thread[] m_Ⴀ;

	private readonly AutoResetEvent[] Ⴅ;

	private IIoDeviceCfg m_Ⴐ;

	private LogFile.Ⴈ Ⴓ = new LogFile.Ⴈ();

	public IIoDeviceCfg IoDeviceCfg
	{
		get
		{
			return this.m_Ⴐ;
		}
		set
		{
			this.m_Ⴐ = value;
		}
	}

	public string EofChar
	{
		get
		{
			string ⴐ = Ⴓ.Ⴐ;
			WxCfg.ႣႭ[37] = (char)((WxCfg.ႣႭ[37] + WxCfg.ႣႭ[252]) & 0xBC);
			return ⴐ;
		}
		set
		{
			Ⴓ.Ⴐ = value;
		}
	}

	public bool IsConnected
	{
		get
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			UtilsNumeric.Ⴀ[247] = (char)(UtilsNumeric.Ⴀ[247] & UtilsNumeric.Ⴀ[34] & 2);
			return true;
		}
	}

	public event OnIoServerConnectEventHandler OnConnectEvent
	{
		add
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			int num = 2;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj = default(object);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = this.m_Ⴐ;
					num = ⴃႣ[19] - 59488;
					break;
				case 3:
					obj = (OnIoServerConnectEventHandler)multicastDelegate;
					multicastDelegate2 = (OnIoServerConnectEventHandler)UtilsIdentity.Ⴀ((Delegate)(obj as OnIoServerConnectEventHandler), (Delegate)value, 796, '\u0323');
					goto case 0;
				case 0:
					num = 1;
					break;
				case 1:
					multicastDelegate = Interlocked.CompareExchange(ref this.m_Ⴐ, (OnIoServerConnectEventHandler)multicastDelegate2, obj as OnIoServerConnectEventHandler);
					num = (((object)(OnIoServerConnectEventHandler)multicastDelegate != obj as OnIoServerConnectEventHandler) ? 3 : (ⴃႣ[56] - 56170));
					break;
				case 4:
				case 6:
					return;
				}
			}
		}
		remove
		{
			char[] ⴗ = DxCfg.Ⴗ;
			int num = 0;
			object obj = default(object);
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj = this.m_Ⴐ;
					num = 2;
					break;
				case 2:
				case 3:
				case 5:
					multicastDelegate = (OnIoServerConnectEventHandler)obj;
					obj2 = (OnIoServerConnectEventHandler)DownloadUrl2.Ⴜ((Delegate)(multicastDelegate as OnIoServerConnectEventHandler), (Delegate)value, 'ƛ', 'ơ');
					num = ⴗ[30] - 17778;
					break;
				case 6:
					obj = Interlocked.CompareExchange(ref this.m_Ⴐ, (OnIoServerConnectEventHandler)obj2, multicastDelegate as OnIoServerConnectEventHandler);
					num = (((object)(OnIoServerConnectEventHandler)obj == multicastDelegate as OnIoServerConnectEventHandler) ? 1 : 2);
					break;
				case 1:
					return;
				}
			}
		}
	}

	public TcpServer(IIoDeviceCfg ioDeviceCfg)
	{
		object obj = new ManualResetEvent[2];
		Ⴓ.Ⴗ = (ManualResetEvent[])obj;
		this.m_Ⴀ = new Thread[2];
		Ⴅ = new AutoResetEvent[2];
		base._002Ector();
		IoDeviceCfg = ioDeviceCfg;
		this.m_Ⴀ = 1000;
		_connectedClients = new ArrayList(this.m_Ⴀ);
	}

	public void Start()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 7;
		int num2 = default(int);
		object obj3 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀ[350] - 33805;
				break;
			case 5:
			case 9:
				Ⴓ.Ⴗ[num2] = new ManualResetEvent(initialState: false);
				Ⴅ[num2] = new AutoResetEvent(initialState: false);
				num = 0;
				break;
			case 0:
				num2++;
				num = ⴀ[96] - 22798;
				break;
			case 6:
				num = ((num2 < 2) ? (ⴃႭ[78] - 59557) : 10);
				break;
			case 10:
			{
				object obj4 = new ThreadStart(Ⴀ);
				Thread[] ⴀ3 = this.m_Ⴀ;
				_Thread thread = new Thread((ThreadStart)obj4);
				UtilsValidation.Ⴃ((Thread)thread, true, 512, 613);
				AnnCfg.Ⴍ(thread as Thread, ႰႣ.Ⴀ((object)ႣႼ.Ⴜ(8, 365387189, 20), (object)IoDeviceCfg.Port, (short)824, 890), 559, 'ɚ');
				ⴀ3[0] = (Thread)thread;
				goto case 3;
			}
			case 3:
				num = ⴃႭ[98] - 39558;
				break;
			case 2:
				UtilsValidation.Ⴗ(this.m_Ⴀ[0], '\v', 99);
				obj3 = new ThreadStart(StartListeningIPv6);
				goto case 8;
			case 8:
				num = 4;
				break;
			case 4:
			{
				Thread[] ⴀ2 = this.m_Ⴀ;
				CriticalFinalizerObject criticalFinalizerObject = new Thread(obj3 as ThreadStart);
				UtilsValidation.Ⴃ((Thread)criticalFinalizerObject, true, 62, 91);
				AnnCfg.Ⴍ(criticalFinalizerObject as Thread, ႰႣ.Ⴀ((object)TelnetServerClient.Ⴄ(1945322725, 'U', 6), (object)IoDeviceCfg.Port, (short)1002, 936), 89, ',');
				ⴀ2[1] = (Thread)criticalFinalizerObject;
				num = 1;
				break;
			}
			case 1:
			{
				this.m_Ⴀ[1].Start();
				object obj = new TimerCallback(Ⴐ);
				object obj2 = new Timer(obj as TimerCallback, null, 300000, 300000);
				Ⴓ.Ⴈ = obj2 as Timer;
				return;
			}
			}
		}
	}

	public virtual void Stop()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 1;
		int num2 = default(int);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				DgvBaseFilterHost.Ⴀ(Ⴓ.Ⴈ, '4', '\\');
				object obj3 = null;
				Ⴓ.Ⴈ = (Timer)obj3;
				num = ⴀ[380] - 17921;
				break;
			}
			case 0:
				num2 = 0;
				num = 10;
				break;
			case 9:
			case 13:
				num = (UtilsPerformance.Ⴗ(this.m_Ⴀ[num2], 654, 754) ? (ⴃႤ[600] - 48673) : 7);
				break;
			case 7:
				PrecisionTimer.Ⴃ((EventWaitHandle)Ⴅ[num2], 'ć', 310);
				num = 11;
				break;
			case 11:
				num2++;
				num = 10;
				break;
			case 10:
				num = ((num2 < 2) ? 9 : 14);
				break;
			case 14:
			{
				bool ⴍ = true;
				Ⴓ.Ⴍ = ⴍ;
				obj2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				num = 8;
				break;
			}
			case 8:
			{
				object obj = new IPEndPoint(IPAddress.Loopback, IoDeviceCfg.Port);
				UtilsPerformance.Ⴅ(obj2 as Socket, (EndPoint)(IPEndPoint)obj, 872, '\u0328');
				num = ⴀ[324] - 43627;
				break;
			}
			case 6:
				num2 = 0;
				goto case 5;
			case 5:
			case 12:
				num = 3;
				break;
			case 4:
				Ⴅ[num2].WaitOne(100, exitContext: false);
				num2++;
				num = 3;
				break;
			case 3:
				num = ((num2 < 2) ? 4 : (ⴐ[381] - 53539));
				break;
			case 2:
				return;
			}
		}
	}

	private void Ⴐ(object P_0)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		DgvFreqRangeColumnFilter.Ⴀ(Ⴓ.Ⴈ, -1, -1, 648, 'ˁ');
		try
		{
			try
			{
				switch (0)
				{
				default:
				{
					bool flag = false;
					object obj = default(object);
					try
					{
						int num = 10;
						int num2 = default(int);
						IIoClient ioClient = default(IIoClient);
						while (true)
						{
							switch (num)
							{
							default:
								DownloadUrl2.ႥႰ(obj = DownloadUrl2.ႥႭ(_connectedClients, 'Ǭ', 498), ref flag, 'ɔ', 'ɵ');
								num = 2;
								continue;
							case 2:
								num2 = UtilsDate.Ⴄ(_connectedClients, 725, 661) - 1;
								num = 3;
								continue;
							case 9:
								ioClient = (TcpServerClient)HelpAboutClient.Ⴄ(_connectedClients, num2, 'ɩ', 572);
								num = (((ioClient as TcpServerClient).Socket != null) ? (ⴃႭ[30] - 23954) : 11);
								continue;
							case 11:
								num = (DgvFilterManager.Ⴜ(_connectedClients, (object)(TcpServerClient)ioClient, 'ʚ', '\u02c3') ? 1 : 6);
								continue;
							case 1:
								DgvFilterHost.ႥႳ(_connectedClients, (object)(ioClient as TcpServerClient), '\u0314', '\u0311');
								goto case 0;
							case 0:
								DownloadUrl2.ႥႳ(ref Ⴓ.Ⴀ, 169, '\u0099');
								num = ⴃႣ[205] - 60457;
								continue;
							case 4:
							case 6:
								num2--;
								num = 3;
								continue;
							case 3:
							case 8:
								num = ((num2 == 0) ? 9 : 7);
								continue;
							case 7:
								break;
							}
							break;
						}
					}
					finally
					{
						int num3 = 6;
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								num4 = ((!flag) ? (ⴐ[37] - 33223) : (ⴀ[244] - 39600));
								goto IL_01e8;
							case 1:
							case 4:
								Monitor.Exit(obj);
								break;
							case 3:
							case 5:
								break;
							}
							break;
							IL_01e8:
							num3 = num4;
						}
					}
					switch (0)
					{
					}
					break;
				}
				}
			}
			catch (Exception ex)
			{
				Ⴃ.Error((ex as Exception).Message);
			}
			switch (0)
			{
			}
		}
		finally
		{
			switch (4)
			{
			default:
				Ⴓ.Ⴈ.Change(300000, 300000);
				break;
			case 2:
				break;
			}
		}
		switch (0)
		{
		}
	}

	private void Ⴀ()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = new IPEndPoint(IPAddress.Any, IoDeviceCfg.Port);
		object obj2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		try
		{
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					GlobalConst.Ⴐ(obj2 as Socket, (EndPoint)(obj as IPEndPoint), (short)363, 302);
					goto case 7;
				case 7:
					WwvCfg.Ⴗ(obj2 as Socket, 1000, 's', ',');
					num = ⴐ[443] - 42158;
					continue;
				case 2:
					PrecisionTimer.Ⴃ((EventWaitHandle)Ⴓ.Ⴗ[0], 'ɛ', 617);
					num = ⴃႣ[83] - 56475;
					continue;
				case 3:
				case 9:
					UtilsXml.Ⴅ<object, Socket, AsyncCallback>((Socket)obj2, Ⴄ, obj2 as Socket, '/', 59);
					num = ⴗ[150] - 53143;
					continue;
				case 6:
				case 8:
					AutoUpdater.ႨႷ((WaitHandle)Ⴓ.Ⴗ[0], 'S', '\'');
					num = 4;
					continue;
				case 4:
					num = (Ⴓ.Ⴍ ? 1 : (ⴐ[435] - 14722));
					continue;
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴅ[0].Set();
		}
		switch (2)
		{
		}
	}

	private void StartListeningIPv6()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 1;
		IPEndPoint iPEndPoint = default(IPEndPoint);
		while (true)
		{
			switch (num)
			{
			default:
				if (StringConstants.Ⴄ(296, 'ă'))
				{
					goto IL_0045;
				}
				break;
			case 3:
				iPEndPoint = new IPEndPoint(IPAddress.IPv6Any, IoDeviceCfg.Port);
				goto case 0;
			case 0:
			case 4:
			{
				Socket socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
				try
				{
					int num2 = 1;
					while (true)
					{
						switch (num2)
						{
						default:
							GlobalConst.Ⴐ(socket, (EndPoint)iPEndPoint, (short)187, 254);
							WwvCfg.Ⴗ(socket, 1000, 'Ċ', 'ŕ');
							num2 = 10;
							continue;
						case 10:
							Ⴃ.Info(DownloadUrl2.Ⴅ(24, null, 2018867825, 5));
							goto case 0;
						case 0:
							num2 = ⴃႣ[228] - 10055;
							continue;
						case 5:
						case 7:
						case 9:
							PrecisionTimer.Ⴃ((EventWaitHandle)Ⴓ.Ⴗ[1], 'Æ', 244);
							num2 = 4;
							continue;
						case 4:
							UtilsXml.Ⴅ<object, Socket, AsyncCallback>(socket, Ⴄ, socket, 'Ⱦ', 554);
							num2 = ⴃႭ[89] - 23643;
							continue;
						case 6:
							AutoUpdater.ႨႷ((WaitHandle)Ⴓ.Ⴗ[1], 'ˎ', 'ʺ');
							num2 = ⴗ[74] - 30234;
							continue;
						case 3:
							num2 = ((!Ⴓ.Ⴍ) ? 7 : (ⴃႭ[78] - 59554));
							continue;
						case 8:
							break;
						}
						break;
					}
				}
				catch (Exception)
				{
					Ⴅ[1].Set();
				}
				break;
			}
			}
			break;
			IL_0045:
			num = 3;
		}
		switch (4)
		{
		}
	}

	protected abstract TcpServerClient GetClientObject();

	private void Ⴄ(IAsyncResult P_0)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 5;
		object obj3 = default(object);
		object obj2 = default(object);
		IIoClient ioClient = default(IIoClient);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj3 = (Socket)P_0.AsyncState;
				goto case 8;
			case 8:
				obj2 = ႰႣ.Ⴄ(obj3 as Socket, P_0, 251, '²');
				num = 3;
				break;
			case 3:
				num = ((FrmUpdating.ႠႠ(obj2 as Socket, 292, 'ŧ') != AddressFamily.InterNetworkV6) ? 7 : (ⴐ[115] - 41186));
				break;
			case 4:
				PrecisionTimer.Ⴃ((EventWaitHandle)Ⴓ.Ⴗ[1], '\u00a8', 153);
				num = ⴃႭ[119] - 58719;
				break;
			case 1:
			case 7:
				PrecisionTimer.Ⴃ((EventWaitHandle)Ⴓ.Ⴗ[0], 'Θ', 937);
				num = ⴃႭ[81] - 32191;
				break;
			case 0:
			case 6:
				ioClient = GetClientObject();
				(ioClient as TcpServerClient).Socket = (Socket)obj2;
				((TcpServerClient)ioClient).HostTcpServer = this;
				num = 2;
				break;
			case 2:
				((TcpServerClient)ioClient).IoCfg = IoDeviceCfg;
				DgvBaseFilterHost.Ⴓ((ioClient as TcpServerClient).Socket, true, 133, 178);
				try
				{
					switch (3)
					{
					default:
						DownloadUrl2.ႥႳ(ref Ⴓ.Ⴀ, 180, '\u0085');
						break;
					case 2:
					case 4:
						break;
					}
					bool flag = false;
					try
					{
						int num2 = 0;
						while (true)
						{
							switch (num2)
							{
							default:
								DownloadUrl2.ႥႰ(obj = DownloadUrl2.ႥႭ(_connectedClients, 'ʯ', 689), ref flag, '\u031f', '\u033e');
								num2 = 2;
								continue;
							case 2:
								DgvFreqRangeColumnFilter.Ⴄ(_connectedClients, (object)(ioClient as TcpServerClient), (short)590, (short)522);
								(ioClient as TcpServerClient).ConnectionState = ConnectionState.CallsignRequest;
								num2 = 1;
								continue;
							case 1:
							case 4:
							case 6:
								((TcpServerClient)ioClient).RxBuffer = string.Empty;
								break;
							}
							break;
						}
					}
					finally
					{
						int num3 = 3;
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								num4 = ((!flag) ? 4 : 2);
								goto IL_0240;
							case 0:
							case 2:
							case 5:
								UtilsString.Ⴜ(obj, 146, '\u009b');
								break;
							case 4:
								break;
							}
							break;
							IL_0240:
							num3 = num4;
						}
					}
					int num5 = 4;
					while (true)
					{
						switch (num5)
						{
						default:
							((TcpServerClient)ioClient).EndPoint = UtilsString.Ⴍ((object)UtilsEmail.Ⴈ((IPEndPoint)ColumnFilterEventArgs.Ⴗ((ioClient as TcpServerClient).Socket, 'ɜ', 586), 920, 985), '\u030f', 797);
							goto case 0;
						case 0:
							num5 = 8;
							continue;
						case 8:
							((TcpServerClient)ioClient).IoCfg.IpAddress = ((IPEndPoint)ColumnFilterEventArgs.Ⴗ(obj2 as Socket, 'š', 375)).Address.ToString();
							num5 = 2;
							continue;
						case 2:
							((Socket)obj2).BeginReceive(((TcpServerClient)ioClient).Buffer, 0, 1024, SocketFlags.None, ReceiveCallback, (TcpServerClient)ioClient);
							num5 = 5;
							continue;
						case 5:
						{
							int ⴀ = Ⴓ.Ⴀ;
							int ⴀ2 = this.m_Ⴀ;
							DataGridViewColumnSelector.Ⴐ[188] = (char)((DataGridViewColumnSelector.Ⴐ[188] - DataGridViewColumnSelector.Ⴐ[232]) & 0xD6);
							num5 = ((ⴀ <= ⴀ2) ? 3 : 9);
							continue;
						}
						case 9:
							RemoveSocket((TcpServerClient)ioClient);
							goto case 6;
						case 6:
							ioClient = null;
							num5 = 3;
							continue;
						case 3:
							OnConnect(ioClient as TcpServerClient);
							break;
						case 7:
							break;
						}
						break;
					}
				}
				catch (SocketException)
				{
					RemoveSocket(ioClient as TcpServerClient);
				}
				catch (Exception)
				{
					RemoveSocket((TcpServerClient)ioClient);
				}
				switch (2)
				{
				}
				return;
			}
		}
	}

	public void OnConnect(IIoClient arcObject)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 5;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((this.m_Ⴐ != null) ? (ⴃႣ[144] - 42516) : 0);
				break;
			case 1:
			case 2:
				UtilsLatLon.ႷႥ(this.m_Ⴐ, arcObject, 60, '&');
				return;
			case 0:
				return;
			}
			num = num2;
		}
	}

	protected void ReceiveCallback(IAsyncResult ar)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = (TcpServerClient)ar.AsyncState;
		object socket = (obj as TcpServerClient).Socket;
		try
		{
			int num = 4;
			int num6 = default(int);
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			object locker = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num6 = FrmUpdateAvailable.ႷႠ(socket as Socket, ar, 984, 'ί');
					if (num6 > 0)
					{
						num = 0;
						continue;
					}
					break;
				case 0:
				case 6:
					enumerable = PrecisionTimer.ႤႰ(UtilsValidation.Ⴓ(113, 60), (obj as TcpServerClient).Buffer, 0, num6, 'ŉ', 'ģ');
					goto case 2;
				case 2:
					num = ⴃႭ[216] - 27134;
					continue;
				case 5:
					{
						bool flag = false;
						try
						{
							int num2 = 2;
							while (true)
							{
								switch (num2)
								{
								default:
									DownloadUrl2.ႥႰ(locker = (obj as TcpServerClient).Locker, ref flag, 'ƪ', 'Ƌ');
									break;
								case 1:
									break;
								case 4:
								case 5:
								{
									TcpServerClient obj2 = obj as TcpServerClient;
									obj2.RxBuffer = ReverseBeaconClient.Ⴗ(obj2.RxBuffer, (string)enumerable, 'Ā', 'ň');
									goto end_IL_00b0;
								}
								}
								num2 = ⴃႣ[118] - 49861;
								continue;
								end_IL_00b0:
								break;
							}
						}
						finally
						{
							int num3 = 2;
							while (true)
							{
								int num4;
								switch (num3)
								{
								default:
									num4 = ((!flag) ? 4 : 5);
									goto IL_0150;
								case 5:
								case 6:
									UtilsString.Ⴜ(locker, 896, 'Ή');
									break;
								case 4:
									break;
								}
								break;
								IL_0150:
								num3 = num4;
							}
						}
						int num5 = 3;
						while (true)
						{
							switch (num5)
							{
							default:
								Queue.Enqueue((TcpServerClient)obj);
								UtilsPerformance.Ⴍ<Socket, AsyncCallback, object>((Socket)socket, (obj as TcpServerClient).Buffer, 0, 1024, SocketFlags.None, ReceiveCallback, (TcpServerClient)obj, 510, 509);
								goto IL_01da;
							case 4:
								goto IL_01da;
							case 6:
								break;
							case 0:
							case 5:
								goto end_IL_016c;
							}
							goto end_IL_002b;
							IL_01da:
							num5 = 0;
							continue;
							end_IL_016c:
							break;
						}
						goto end_IL_0029;
					}
					end_IL_002b:
					break;
				}
				RemoveSocket((TcpServerClient)obj);
				break;
				continue;
				end_IL_0029:
				break;
			}
		}
		catch (SocketException ex)
		{
			while (true)
			{
				RemoveSocket((TcpServerClient)obj);
				if (FrmUpdateAvailable.ႷႨ((ExternalException)ex, 'Ư', 408) != 64)
				{
					switch (2)
					{
					case 3:
						continue;
					case 0:
					case 1:
					case 4:
						goto end_IL_01f2;
					}
					Ⴃ.Warn(ReverseBeaconClient.Ⴗ(UtilsString.Ⴐ(null, 5, 192631550), PrecisionTimer.Ⴜ((Exception)(ex as SocketException), 405, 'ǈ'), 'ì', '¤'));
				}
				break;
				continue;
				end_IL_01f2:
				break;
			}
		}
		catch (Exception ex2)
		{
			while (true)
			{
				IL_0278:
				RemoveSocket((TcpServerClient)obj);
				while (ex2.GetType().FullName != UtilsString.Ⴐ(null, 7, 192631442))
				{
					switch (0)
					{
					case 2:
						break;
					case 3:
						continue;
					default:
						Ⴃ.Warn(TelnetServerClient.Ⴄ(1945322633, 'V', 5) + (ex2 as Exception).Message);
						goto end_IL_0284;
					case 4:
						goto end_IL_0284;
					}
					goto IL_0278;
					continue;
					end_IL_0284:
					break;
				}
				break;
			}
		}
		switch (1)
		{
		}
	}

	public bool Send(Socket sock, byte[] byteData)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		if (byteData.Length > 0)
		{
			try
			{
				DirectoryMonitor.Ⴈ<object, AsyncCallback, Socket>(sock, byteData, 0, byteData.Length, SocketFlags.None, SendCallback, sock, 'Ƴ', 'ƛ');
			}
			catch (Exception ex)
			{
				Ⴃ.Warn(PrecisionTimer.Ⴜ(ex, 743, 'ʺ'));
				return false;
			}
		}
		bool flag = default(bool);
		return 4 switch
		{
			2 => flag, 
			_ => true, 
		};
	}

	protected void SendCallback(IAsyncResult ar)
	{
		object obj = (Socket)ar.AsyncState;
		try
		{
			WwvSpotExt.Ⴃ((Socket)obj, ar, 812, '\u0350');
		}
		catch (Exception)
		{
		}
	}

	public void RemoveSocket(TcpServerClient client)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		if (client != null)
		{
			try
			{
				switch (1)
				{
				default:
					client.OnDisconnect(ArcLogInRqstExt.Ⴗ(1706507117, 29, 2));
					break;
				case 0:
					break;
				}
				bool flag = false;
				object obj = default(object);
				try
				{
					int num = 6;
					while (true)
					{
						switch (num)
						{
						default:
							DownloadUrl2.ႥႰ(obj = DownloadUrl2.ႥႭ(_connectedClients, 'ŀ', 350), ref flag, 'π', 'ϡ');
							goto case 4;
						case 4:
							num = ⴗ[63] - 23264;
							continue;
						case 0:
							num = (DgvFilterManager.Ⴜ(_connectedClients, (object)client, '^', '\a') ? 1 : (ⴃႭ[241] - 11623));
							continue;
						case 1:
						case 7:
							DgvFilterHost.ႥႳ(_connectedClients, (object)client, '\u0308', '\u030d');
							DownloadUrl2.ႥႳ(ref Ⴓ.Ⴀ, 371, 'Ń');
							num = 5;
							continue;
						case 5:
							break;
						}
						break;
					}
				}
				finally
				{
					int num2 = 6;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = ((!flag) ? 5 : 4);
							goto IL_013a;
						case 4:
							UtilsString.Ⴜ(obj, 642, 'ʋ');
							break;
						case 2:
						case 5:
							break;
						}
						break;
						IL_013a:
						num2 = num3;
					}
				}
				int num4 = 2;
				while (true)
				{
					switch (num4)
					{
					default:
						num4 = ((client.Socket == null) ? 5 : (ⴐ[212] - ⴐ[212]));
						continue;
					case 0:
					case 6:
						num4 = ((!UtilsIdentity.Ⴗ(client.Socket, 500, 'ǁ')) ? 8 : (ⴗ[26] - 58709));
						continue;
					case 4:
					case 7:
						UtilsSql.Ⴜ(client.Socket, SocketShutdown.Both, 512, 588);
						client.Socket.Close();
						break;
					case 3:
					case 8:
						break;
					case 5:
						goto end_IL_0155;
					}
					client.Socket = null;
					num4 = 5;
					continue;
					end_IL_0155:
					break;
				}
			}
			catch (Exception ex)
			{
				Ⴃ.Warn((ex as Exception).Message.Replace(ႣႼ.Ⴜ(0, 365387084, 24), ႣႼ.ႥႭ(null, 624736104, 1, null)));
			}
		}
		switch (2)
		{
		}
	}
}
