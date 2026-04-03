using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using ArcShared.Forms;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using Ⴃ;

namespace ArcShared.ArcIo.Tcp;

public abstract class TcpClient : IIoClient
{
	private static readonly ILog Ⴀ = ArcLogInRqstExt.Ⴍ(ႣႼ.ႥႭ(null, 624736009, 5, null), 906, 981);

	private Socket Ⴅ;

	private IIoDeviceCfg Ⴅ;

	private int Ⴐ;

	private int Ⴄ;

	private DateTime Ⴀ;

	private UtilsSql.ႨႠ Ⴃ = new UtilsSql.ႨႠ();

	internal bool Ⴈ;

	[Browsable(false)]
	public ConnectionState ConnectionState
	{
		get
		{
			return Ⴃ.Ⴈ;
		}
		set
		{
			Ⴃ.Ⴈ = value;
		}
	}

	[Browsable(false)]
	public string EndPoint
	{
		get
		{
			string ⴃ = Ⴃ.Ⴃ;
			DataGridViewColumnSelector.Ⴐ[380] = (char)((DataGridViewColumnSelector.Ⴐ[380] - DataGridViewColumnSelector.Ⴐ[551]) & 0xE9);
			return ⴃ;
		}
		set
		{
			Ⴃ.Ⴃ = value as string;
		}
	}

	[Browsable(false)]
	public IIoDeviceCfg IoCfg
	{
		get
		{
			return Ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	[Description("IP Address and port")]
	[ReadOnly(true)]
	public string IpAddress => DxAtlasData.Ⴄ((object)IoCfg.IpAddress, (object)ArcLogInRqstExt.Ⴗ(1706506781, 11, 3), (object)IoCfg.Port, 251, '\u0094');

	[ReadOnly(true)]
	[Description("Date time of last sent packet")]
	public DateTime LastSendDts
	{
		get
		{
			return Ⴃ.Ⴍ;
		}
		set
		{
			Ⴃ.Ⴍ = value;
		}
	}

	[Browsable(false)]
	public int LastTenMinuteDxCnt
	{
		get
		{
			char[] ⴗ = DxCfg.Ⴗ;
			return Ⴃ.Ⴓ;
		}
		set
		{
			Ⴃ.Ⴓ = value;
		}
	}

	[Browsable(false)]
	public int LastTenMinuteDxDupeCnt
	{
		get
		{
			int ⴐ = Ⴐ;
			UtilsNumeric.Ⴀ[88] = (char)((UtilsNumeric.Ⴀ[88] | UtilsNumeric.Ⴀ[323]) & 0x7A);
			return ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	[Browsable(false)]
	public int TenMinuteDxCnt
	{
		get
		{
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	[Browsable(false)]
	public int TenMinuteDxDupeCnt
	{
		get
		{
			return Ⴃ.Ⴗ;
		}
		set
		{
			Ⴃ.Ⴗ = value;
		}
	}

	[ReadOnly(true)]
	[Description("Date time of connection")]
	public DateTime ConnectDts
	{
		get
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	[Browsable(false)]
	public double[] DxSpotRate
	{
		get
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			return Ⴃ.Ⴜ;
		}
		set
		{
			Ⴃ.Ⴜ = value as double[];
		}
	}

	[ReadOnly(true)]
	[Description("Connection status")]
	public bool IsConnected
	{
		get
		{
			while (true)
			{
				int num = ((this.Ⴅ == null) ? 2 : 5);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 0;
						continue;
					case 0:
					case 3:
					case 6:
						break;
					case 5:
						return UtilsIdentity.Ⴗ(this.Ⴅ, 368, 'Ņ');
					case 2:
						return false;
					}
					break;
				}
			}
		}
	}

	[ReadOnly(true)]
	[Description("Connection information")]
	public string ConnectInfo
	{
		get
		{
			char[] ⴗ = DxCfg.Ⴗ;
			char[] ⴀ = UtilsNumeric.Ⴀ;
			while (true)
			{
				object obj = new object[9];
				((object[])obj)[0] = AnnWxSpotExt.Ⴐ((MemberInfo)ႰႨ.ႨႨ((object)this, 'ɂ', 'ȗ'), '\u035a', 830);
				int num = 0;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴗ[155] - 49746;
						continue;
					case 1:
						break;
					case 0:
						((object[])obj)[1] = DownloadUrl2.Ⴅ(4, null, 2018868053, 0);
						num = ⴀ[241] - 35029;
						continue;
					case 5:
						(obj as object[])[2] = IoCfg.ConnectTo;
						(obj as object[])[3] = TelnetServerClient.Ⴄ(1945322692, 'ä', 8);
						num = 2;
						continue;
					case 2:
						(obj as object[])[4] = IoCfg.IpAddress;
						goto case 9;
					case 9:
						(obj as object[])[5] = ArcLogInRqstExt.Ⴗ(1706506777, 1, 7);
						num = 7;
						continue;
					case 4:
					case 7:
						((object[])obj)[6] = IoCfg.Port;
						(obj as object[])[7] = ႣႼ.Ⴜ(4, 365386918, 13);
						num = 8;
						continue;
					case 8:
						(obj as object[])[8] = IoCfg.Description;
						goto case 6;
					case 6:
						return string.Concat(obj as object[]);
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
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			char[] ⴀ = UtilsNumeric.Ⴀ;
			int num = 2;
			object obj = default(object);
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj = Ⴃ.Ⴄ;
					num = 1;
					break;
				case 1:
					multicastDelegate = (OnIoClientRxEventHandler)obj;
					obj2 = (OnIoClientRxEventHandler)UtilsIdentity.Ⴀ((Delegate)(OnIoClientRxEventHandler)multicastDelegate, (Delegate)value, 436, 'Ƌ');
					goto case 4;
				case 4:
				{
					int num2 = ⴃႤ[176];
					NeedsCfg.ႣႤ[77] = (NeedsCfg.ႣႤ[77] ^ NeedsCfg.ႣႤ[412]) & 0xC7;
					num = num2 - 54690;
					break;
				}
				case 6:
					obj = Interlocked.CompareExchange(ref Ⴃ.Ⴄ, (OnIoClientRxEventHandler)obj2, (OnIoClientRxEventHandler)multicastDelegate);
					num = ⴀ[218] - 52348;
					break;
				case 5:
					num = (((object)(OnIoClientRxEventHandler)obj != (OnIoClientRxEventHandler)multicastDelegate) ? 1 : (ⴃႤ[530] - 23109));
					break;
				case 3:
				case 7:
					return;
				}
			}
		}
		remove
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			int num = 6;
			object obj = default(object);
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					obj = Ⴃ.Ⴄ;
					num = ⴀ[403] - 52879;
					break;
				case 4:
					multicastDelegate = obj as OnIoClientRxEventHandler;
					goto case 2;
				case 2:
					multicastDelegate2 = (OnIoClientRxEventHandler)DownloadUrl2.Ⴜ((Delegate)(OnIoClientRxEventHandler)multicastDelegate, (Delegate)value, '\u008a', '°');
					goto case 3;
				case 3:
					num = 7;
					break;
				case 7:
					obj = Interlocked.CompareExchange(ref Ⴃ.Ⴄ, (OnIoClientRxEventHandler)multicastDelegate2, (OnIoClientRxEventHandler)multicastDelegate);
					num = 0;
					break;
				case 0:
					num = (((object)(obj as OnIoClientRxEventHandler) != multicastDelegate as OnIoClientRxEventHandler) ? 4 : 5);
					break;
				case 5:
					return;
				}
			}
		}
	}

	public event OnIoClientConnectEventHandler OnConnectEvent
	{
		add
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
					obj = Ⴃ.Ⴀ;
					num = 3;
					break;
				case 3:
				case 7:
					multicastDelegate = obj as OnIoClientConnectEventHandler;
					obj2 = (OnIoClientConnectEventHandler)UtilsIdentity.Ⴀ((Delegate)(OnIoClientConnectEventHandler)multicastDelegate, (Delegate)value, 503, 'ǈ');
					num = 2;
					break;
				case 1:
				case 2:
				case 5:
					obj = Interlocked.CompareExchange(ref Ⴃ.Ⴀ, obj2 as OnIoClientConnectEventHandler, (OnIoClientConnectEventHandler)multicastDelegate);
					num = ⴗ[33] - 33385;
					break;
				case 6:
					num = (((object)(OnIoClientConnectEventHandler)obj != (OnIoClientConnectEventHandler)multicastDelegate) ? 3 : 4);
					break;
				case 4:
					return;
				}
			}
		}
		remove
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			int num = 3;
			object obj = default(object);
			object obj2 = default(object);
			object obj3 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj = Ⴃ.Ⴀ;
					num = 6;
					break;
				case 6:
					obj2 = (OnIoClientConnectEventHandler)obj;
					goto case 2;
				case 2:
					obj3 = (OnIoClientConnectEventHandler)DownloadUrl2.Ⴜ((Delegate)(OnIoClientConnectEventHandler)obj2, (Delegate)value, '\u02c4', '\u02fe');
					goto case 5;
				case 5:
					num = 0;
					break;
				case 0:
					obj = Interlocked.CompareExchange(ref Ⴃ.Ⴀ, (OnIoClientConnectEventHandler)obj3, (OnIoClientConnectEventHandler)obj2);
					num = 1;
					break;
				case 1:
					num = (((object)(obj as OnIoClientConnectEventHandler) != obj2 as OnIoClientConnectEventHandler) ? 6 : (ⴐ[168] - 4247));
					break;
				case 4:
				case 7:
					return;
				}
			}
		}
	}

	public event OnIoClientDisconnectEventHandler OnDisconnectEvent
	{
		add
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			int num = 6;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = Ⴃ.Ⴐ;
					num = ⴐ[599] - 51740;
					break;
				case 2:
				case 3:
					multicastDelegate2 = multicastDelegate as OnIoClientDisconnectEventHandler;
					goto case 7;
				case 7:
					obj = (OnIoClientDisconnectEventHandler)UtilsIdentity.Ⴀ((Delegate)(multicastDelegate2 as OnIoClientDisconnectEventHandler), (Delegate)value, 593, 'ɮ');
					goto case 4;
				case 4:
					num = 5;
					break;
				case 5:
					multicastDelegate = Interlocked.CompareExchange(ref Ⴃ.Ⴐ, (OnIoClientDisconnectEventHandler)obj, multicastDelegate2 as OnIoClientDisconnectEventHandler);
					num = 1;
					break;
				case 1:
					num = (((object)(multicastDelegate as OnIoClientDisconnectEventHandler) != (OnIoClientDisconnectEventHandler)multicastDelegate2) ? 2 : 0);
					break;
				case 0:
					return;
				}
			}
		}
		remove
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			char[] ⴃႣ = TalkCfg.ႣႣ;
			int num = 0;
			object obj = default(object);
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					obj = Ⴃ.Ⴐ;
					num = ⴃႤ[612] - 53372;
					break;
				case 4:
					multicastDelegate = obj as OnIoClientDisconnectEventHandler;
					multicastDelegate2 = (OnIoClientDisconnectEventHandler)DownloadUrl2.Ⴜ((Delegate)(OnIoClientDisconnectEventHandler)multicastDelegate, (Delegate)value, 'ʽ', 'ʇ');
					num = 7;
					break;
				case 7:
					obj = Interlocked.CompareExchange(ref Ⴃ.Ⴐ, multicastDelegate2 as OnIoClientDisconnectEventHandler, multicastDelegate as OnIoClientDisconnectEventHandler);
					num = 1;
					break;
				case 1:
				case 3:
				case 6:
					num = (((object)(OnIoClientDisconnectEventHandler)obj != (OnIoClientDisconnectEventHandler)multicastDelegate) ? 4 : (ⴃႣ[214] - 56064));
					break;
				case 2:
				case 5:
					return;
				}
			}
		}
	}

	public TcpClient()
	{
		Array array = new byte[8192];
		Ⴃ.Ⴅ = array as byte[];
		base._002Ector();
		DxSpotRate = new double[60];
		ConnectDts = DateTime.MinValue;
	}

	public TcpClient(IIoDeviceCfg ioDeviceCfg)
		: this()
	{
		IoCfg = ioDeviceCfg;
	}

	public virtual void Connect()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		if (!IsConnected)
		{
			try
			{
				try
				{
					int num = 6;
					while (true)
					{
						switch (num)
						{
						default:
							num = ((this.Ⴅ == null) ? (ⴗ[105] - 4875) : 2);
							continue;
						case 2:
						case 5:
							num = (UtilsIdentity.Ⴗ(this.Ⴅ, 337, 'Ť') ? (ⴐ[455] - 58346) : 8);
							continue;
						case 1:
						case 8:
							UtilsSql.Ⴜ(this.Ⴅ, SocketShutdown.Both, 559, 611);
							ႰႨ.Ⴜ(10, 'ȣ', 574);
							num = ⴗ[4] - 26310;
							continue;
						case 3:
							TelnetServerClient.Ⴜ(this.Ⴅ, 901, 945);
							break;
						case 0:
							break;
						}
						break;
					}
				}
				catch (Exception)
				{
				}
				int num2 = 6;
				object obj2 = default(object);
				UriHostNameType uriHostNameType = default(UriHostNameType);
				object obj = default(object);
				EndPoint endPoint = default(EndPoint);
				MulticastDelegate multicastDelegate = default(MulticastDelegate);
				while (true)
				{
					switch (num2)
					{
					default:
						obj2 = IoCfg.IpAddress;
						uriHostNameType = HelpAboutServer.ႷႤ(obj2 as string, 'ǭ', 434);
						num2 = ⴗ[24] - 30793;
						continue;
					case 12:
						num2 = ((uriHostNameType != UriHostNameType.Dns) ? 4 : (ⴃႤ[474] - 24563));
						continue;
					case 10:
						obj2 = UtilsWeb.DnsLookup((string)obj2);
						num2 = 4;
						continue;
					case 4:
						obj = TelnetServerClient.ႥႤ((string)obj2, 'ì', 'À');
						num2 = ((!(obj is IPAddress)) ? (ⴃႭ[79] - 47135) : 7);
						continue;
					case 7:
						endPoint = new IPEndPoint((IPAddress)obj, IoCfg.Port);
						this.Ⴅ = new Socket(UtilsPerformance.Ⴓ((IPAddress)obj, 783, 806), SocketType.Stream, ProtocolType.Tcp);
						goto case 8;
					case 8:
						num2 = 9;
						continue;
					case 9:
						DgvBaseFilterHost.Ⴓ(this.Ⴅ, true, 342, 353);
						TcpClient.Ⴀ.Info(ReverseBeaconClient.Ⴗ(ArcLogInRqstExt.Ⴗ(1706506770, 10, 8), ConnectInfo, '!', 'i'));
						num2 = 11;
						continue;
					case 11:
						DxCommentExtCfg.ႷႷ(this.Ⴅ, false, '\n', '&');
						goto case 0;
					case 0:
						multicastDelegate = new AsyncCallback(OnConnect);
						goto case 3;
					case 3:
						num2 = 2;
						continue;
					case 2:
						this.Ⴅ.BeginConnect(endPoint as IPEndPoint, (AsyncCallback)multicastDelegate, this.Ⴅ);
						num2 = ⴃႣ[93] - 25920;
						continue;
					case 1:
						break;
					}
					break;
				}
			}
			catch (Exception ex2)
			{
				TcpClient.Ⴀ.Error(ArcLogInRqstExt.Ⴗ(1706506821, 16, 1) + ConnectInfo + ႣႼ.Ⴜ(7, 365387129, 17) + (ex2 as Exception).Message);
			}
		}
		switch (2)
		{
		}
	}

	public void OnConnect(IAsyncResult ar)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = (Socket)ar.AsyncState;
		try
		{
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((!UtilsIdentity.Ⴗ((Socket)obj, 72, '}')) ? 4 : (ⴗ[33] - 33391));
					continue;
				case 0:
				case 7:
					TcpClient.Ⴀ.Info(ReverseBeaconClient.Ⴗ(TelnetServerClient.Ⴄ(1945322647, '\u0014', 0), ConnectInfo, 'Ƒ', 'Ǚ'));
					num = 8;
					continue;
				case 8:
					SetupRecieveCallback((Socket)obj);
					goto case 3;
				case 3:
					OnConnect(ArcLogInRqstExt.Ⴗ(1706506838, 27, 8));
					num = 2;
					continue;
				case 4:
					TcpClient.Ⴀ.Info(ReverseBeaconClient.Ⴗ(DownloadUrl2.Ⴅ(17, null, 2018868058, 3), ConnectInfo, 'ν', 'ϵ'));
					break;
				case 2:
				case 6:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			TcpClient.Ⴀ.Warn(ႣႼ.Ⴜ(1, 365386936, 14) + ConnectInfo + ႣႼ.Ⴜ(6, 365387128, 9) + ex.Message);
		}
		switch (4)
		{
		}
	}

	public void SetupRecieveCallback(Socket sock)
	{
		try
		{
			object obj = new AsyncCallback(OnRecievedData);
			UtilsPerformance.Ⴍ(sock, Ⴃ.Ⴅ, 0, Ⴃ.Ⴅ.Length, SocketFlags.None, obj as AsyncCallback, (object)sock, 439, (short)436);
		}
		catch (Exception ex)
		{
			TcpClient.Ⴀ.Error(ႣႼ.Ⴜ(0, 365386818, 18) + ConnectInfo + ႣႼ.Ⴜ(4, 365387130, 8) + PrecisionTimer.Ⴜ(ex as Exception, 235, '¶'));
		}
	}

	public void OnRecievedData(IAsyncResult ar)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = (Socket)ar.AsyncState;
		try
		{
			int num = 5;
			int num2 = default(int);
			ICloneable cloneable = default(ICloneable);
			while (true)
			{
				switch (num)
				{
				default:
					num2 = FrmUpdateAvailable.ႷႠ(obj as Socket, ar, 503, 'ƀ');
					num = ((num2 <= 0) ? (ⴐ[415] - 57870) : 2);
					continue;
				case 2:
					cloneable = PrecisionTimer.ႤႰ(UtilsValidation.Ⴓ(536, 597), Ⴃ.Ⴅ, 0, num2, 'ά', 'φ');
					num = ⴃႭ[136] - 62991;
					continue;
				case 3:
				case 6:
					OnRx((string)cloneable);
					goto case 8;
				case 8:
					SetupRecieveCallback((Socket)obj);
					num = ⴐ[481] - 29245;
					continue;
				case 0:
					Disconnect();
					break;
				case 7:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			TcpClient.Ⴀ.Warn(UtilsString.Ⴐ(null, 2, 192631194) + ConnectInfo + ႣႼ.Ⴜ(3, 365387133, 6) + ex.Message);
			Disconnect();
		}
		switch (0)
		{
		}
	}

	public void OnConnect(string msg)
	{
		int num = 0;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((Ⴃ.Ⴀ == null) ? 2 : 4);
				break;
			case 3:
			case 4:
				DxCommentExtCfg.ႷႥ(Ⴃ.Ⴀ, msg, 929, 919);
				return;
			case 2:
			case 5:
				return;
			}
			num = num2;
		}
	}

	public void Disconnect()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				OnDisconnect(ArcLogInRqstExt.Ⴗ(1706507115, 22, 4));
				goto case 4;
			case 4:
			{
				Socket ⴅ = this.Ⴅ;
				DataGridViewColumnSelector.Ⴐ[139] = (char)((DataGridViewColumnSelector.Ⴐ[139] - DxCfg.Ⴗ[115]) & 0x40);
				num = ((ⴅ == null) ? 3 : (ⴐ[155] - 35361));
				break;
			}
			case 1:
			case 2:
			case 5:
				if (!UtilsIdentity.Ⴗ(this.Ⴅ, 836, 'ͱ'))
				{
					num = ⴃႤ[243] - 32135;
					break;
				}
				while (true)
				{
					UtilsSql.Ⴜ(this.Ⴅ, SocketShutdown.Both, 860, 784);
					this.Ⴅ.Close();
					switch (0)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 2:
						return;
					case 1:
						break;
					case 0:
						this.Ⴅ = null;
						return;
					case 3:
						return;
					}
				}
			case 3:
				return;
			}
		}
	}

	public void OnDisconnect(string msg)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				TcpClient.Ⴀ.Warn(ReverseBeaconClient.Ⴗ(ႣႼ.Ⴜ(4, 365386836, 31), ConnectInfo, 'ȯ', 'ɧ'));
				num = 6;
				break;
			case 3:
			case 6:
				num = ((Ⴃ.Ⴐ != null) ? (ⴀ[211] - 35372) : 0);
				break;
			case 1:
			case 2:
				Ⴃ.Ⴐ(msg);
				return;
			case 0:
			case 4:
				return;
			}
		}
	}

	public virtual bool Send(byte[] byteData)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		bool result = default(bool);
		while (true)
		{
			LastSendDts = DxAtlasData.Ⴈ(80, 24);
			while (true)
			{
				IL_0052:
				Socket ⴅ = this.Ⴅ;
				NeedsCfg.ႣႤ[477] = NeedsCfg.ႣႤ[477] & NeedsCfg.ႣႤ[244] & 0x54;
				int num = ((ⴅ == null) ? (ⴃႣ[212] - 7578) : 2);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 6;
						continue;
					case 6:
						break;
					case 0:
						goto IL_0052;
					case 2:
						goto IL_0093;
					case 1:
					case 3:
					case 5:
						return false;
					}
					break;
					IL_0093:
					if (!UtilsIdentity.Ⴗ(this.Ⴅ, 68, 'q'))
					{
						num = 3;
						continue;
					}
					goto IL_00ad;
				}
				break;
				IL_00ad:
				try
				{
					int num2 = 1;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = ((byteData.Length <= 0) ? (ⴗ[130] - 63629) : (ⴃႭ[98] - 39560));
							continue;
						case 0:
						case 2:
						case 5:
							PrecisionTimer.ႤႨ(this.Ⴅ, byteData, 'ʽ', '\u02d7');
							num2 = 4;
							continue;
						case 4:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					TcpClient.Ⴀ.Error((ex as Exception).Message);
					return false;
				}
				switch (0)
				{
				default:
					return true;
				case 1:
				case 3:
				case 4:
					return result;
				}
			}
		}
	}

	public virtual bool Send(string msg)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object obj = default(object);
		bool flag = default(bool);
		while (true)
		{
			LastSendDts = DxAtlasData.Ⴈ(291, 363);
			while (true)
			{
				IL_0060:
				int num = ((this.Ⴅ == null) ? (ⴐ[59] - 43829) : (ⴐ[8] - 32868));
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴐ[396] - 45275;
						continue;
					case 2:
					case 5:
						break;
					case 3:
						goto IL_0060;
					case 0:
					case 6:
						goto IL_0083;
					case 4:
						return false;
					}
					break;
					IL_0083:
					if (!UtilsIdentity.Ⴗ(this.Ⴅ, 446, 'Ƌ'))
					{
						num = 4;
						continue;
					}
					goto IL_00a4;
				}
				break;
				IL_00a4:
				try
				{
					int num2 = 0;
					while (true)
					{
						switch (num2)
						{
						default:
							obj = ႣႼ.ႰႳ(ObjectCopierExt.Ⴄ(342, 256), msg, 896, 'ρ');
							goto case 3;
						case 3:
							num2 = 6;
							continue;
						case 6:
							num2 = ((((byte[])obj).Length > 0) ? 1 : (ⴃႣ[221] - 58069));
							continue;
						case 1:
							PrecisionTimer.ႤႨ(this.Ⴅ, (byte[])obj, 'Y', '3');
							num2 = ⴃႣ[180] - 10732;
							continue;
						case 2:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					TcpClient.Ⴀ.Error(ex.Message);
					return false;
				}
				return 4 switch
				{
					5 => flag, 
					_ => true, 
				};
			}
		}
	}

	public virtual void OnRx(string msg)
	{
		int num = 3;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((Ⴃ.Ⴄ != null) ? 1 : 5);
				break;
			case 1:
			case 2:
				DgvTextBoxColumnFilter.Ⴃ(Ⴃ.Ⴄ, msg, 453, 509);
				NeedsCfg.ႣႤ[199] = (NeedsCfg.ႣႤ[199] + NeedsCfg.ႣႤ[127]) & 0x2A;
				return;
			case 5:
				return;
			}
			num = num2;
		}
	}
}
