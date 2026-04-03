using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.Reflection;
using System.Security;
using System.Threading;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using log4net;
using Ⴃ;

namespace ArcShared.ArcIo.Tcp;

public abstract class TcpServerClient : IIoClient
{
	public const int BufferSize = 1024;

	private static readonly ILog Ⴃ;

	public readonly object Locker = new object();

	public string RxBuffer = string.Empty;

	public TcpServer HostTcpServer;

	public Socket Socket;

	public byte[] Buffer = new byte[1024];

	private IIoDeviceCfg Ⴗ;

	private string Ⴅ;

	private int Ⴅ;

	private int Ⴗ;

	private int Ⴀ;

	private int Ⴈ;

	private DateTime Ⴐ;

	private double[] Ⴄ;

	private AnnWxSpotExt.Ⴈ Ⴓ = new AnnWxSpotExt.Ⴈ();

	[Description("End point IP address and port")]
	[ReadOnly(true)]
	public string EndPoint
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			return Ⴓ.Ⴍ;
		}
		set
		{
			Ⴓ.Ⴍ = value;
		}
	}

	[Browsable(false)]
	public IIoDeviceCfg IoCfg
	{
		get
		{
			IIoDeviceCfg ⴗ = this.Ⴗ;
			TalkCfg.ႣႣ[157] = (char)((TalkCfg.ႣႣ[157] | WxCfg.ႣႭ[101]) & 0x4F);
			return ⴗ;
		}
		set
		{
			this.Ⴗ = value;
		}
	}

	[Description("Connection information")]
	[ReadOnly(true)]
	public string ConnectInfo
	{
		get
		{
			char[] ⴗ = DxCfg.Ⴗ;
			char[] ⴃႭ = WxCfg.ႣႭ;
			while (true)
			{
				Array array = new string[5];
				(array as string[])[0] = AnnWxSpotExt.Ⴐ((MemberInfo)ႰႨ.ႨႨ((object)this, 'â', '·'), ']', 57);
				int num = ⴃႭ[117] - 15378;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴗ[117] - 12539;
						continue;
					case 0:
						break;
					case 4:
					case 7:
						(array as string[])[1] = TelnetServerClient.Ⴄ(1945322660, 'Á', 4);
						goto case 6;
					case 6:
						(array as string[])[2] = IoCfg.IpAddress;
						num = 1;
						continue;
					case 1:
						(array as string[])[3] = ႣႼ.Ⴜ(3, 365386913, 4);
						goto case 2;
					case 2:
						(array as string[])[4] = IoCfg.Description;
						num = ⴗ[31] - 482;
						continue;
					case 5:
						return string.Concat(array as string[]);
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public string IpAddress
	{
		get
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			return this.Ⴅ;
		}
		set
		{
			this.Ⴅ = value;
		}
	}

	[Browsable(false)]
	public ConnectionState ConnectionState
	{
		get
		{
			ConnectionState ⴐ = Ⴓ.Ⴐ;
			TalkCfg.ႣႣ[44] = (char)((TalkCfg.ႣႣ[44] | TalkCfg.ႣႣ[119]) & 0xAE);
			return ⴐ;
		}
		set
		{
			Ⴓ.Ⴐ = value;
		}
	}

	[Browsable(false)]
	public int LastTenMinuteDxCnt
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

	[Browsable(false)]
	public int LastTenMinuteDxDupeCnt
	{
		get
		{
			return Ⴗ;
		}
		set
		{
			Ⴗ = value;
		}
	}

	[Browsable(false)]
	public int TenMinuteDxCnt
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

	[Browsable(false)]
	public int TenMinuteDxDupeCnt
	{
		get
		{
			return Ⴈ;
		}
		set
		{
			Ⴈ = value;
		}
	}

	[ReadOnly(true)]
	[Description("Date time of connection")]
	public DateTime ConnectDts
	{
		get
		{
			return Ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	[Browsable(false)]
	public double[] DxSpotRate
	{
		get
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	[Description("Date time of last sent packet")]
	[ReadOnly(true)]
	public DateTime LastSendDts
	{
		get
		{
			return Ⴓ.Ⴄ;
		}
		set
		{
			Ⴓ.Ⴄ = value;
			WxCfg.ႣႭ[238] = (char)((WxCfg.ႣႭ[238] | WxCfg.ႣႭ[260]) & 0x55);
		}
	}

	public bool IsConnected
	{
		get
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			char[] ⴃႭ = WxCfg.ႣႭ;
			while (true)
			{
				int num = ((Socket == null) ? (ⴃႭ[85] - 1594) : (ⴀ[249] - ⴀ[249]));
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 2;
						continue;
					case 2:
						break;
					case 0:
					case 1:
					case 4:
						return UtilsIdentity.Ⴗ(Socket, 429, 'Ƙ');
					case 5:
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
			char[] ⴃႣ = TalkCfg.ႣႣ;
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			char[] ⴗ = DxCfg.Ⴗ;
			int num = 0;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			MulticastDelegate multicastDelegate3 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = Ⴓ.Ⴓ;
					num = ⴃႣ[106] - 63636;
					break;
				case 2:
					multicastDelegate2 = multicastDelegate as OnIoClientRxEventHandler;
					goto case 5;
				case 5:
					multicastDelegate3 = (OnIoClientRxEventHandler)UtilsIdentity.Ⴀ((Delegate)(OnIoClientRxEventHandler)multicastDelegate2, (Delegate)value, 185, '\u0086');
					goto case 1;
				case 1:
					num = ⴃႤ[484] - 51199;
					break;
				case 4:
					multicastDelegate = Interlocked.CompareExchange(ref Ⴓ.Ⴓ, (OnIoClientRxEventHandler)multicastDelegate3, multicastDelegate2 as OnIoClientRxEventHandler);
					goto case 7;
				case 7:
					num = 3;
					break;
				case 3:
					num = (((object)(multicastDelegate as OnIoClientRxEventHandler) != (OnIoClientRxEventHandler)multicastDelegate2) ? (ⴗ[85] - 5448) : 6);
					break;
				case 6:
					return;
				}
			}
		}
		remove
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			char[] ⴃႭ = WxCfg.ႣႭ;
			int num = 5;
			object obj = default(object);
			object obj2 = default(object);
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					obj = Ⴓ.Ⴓ;
					num = 6;
					break;
				case 6:
					obj2 = (OnIoClientRxEventHandler)obj;
					multicastDelegate = (OnIoClientRxEventHandler)DownloadUrl2.Ⴜ((Delegate)(obj2 as OnIoClientRxEventHandler), (Delegate)value, '«', '\u0091');
					num = 3;
					break;
				case 3:
					obj = Interlocked.CompareExchange(ref Ⴓ.Ⴓ, multicastDelegate as OnIoClientRxEventHandler, (OnIoClientRxEventHandler)obj2);
					num = ⴃႤ[98] - 34302;
					break;
				case 1:
				case 7:
					num = (((object)(obj as OnIoClientRxEventHandler) != obj2 as OnIoClientRxEventHandler) ? (ⴃႭ[136] - 62991) : 2);
					break;
				case 0:
				case 2:
				case 4:
					return;
				}
			}
		}
	}

	public event OnIoClientConnectEventHandler OnConnectEvent
	{
		add
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			char[] ⴗ = DxCfg.Ⴗ;
			char[] ⴃႣ = TalkCfg.ႣႣ;
			int num = 6;
			object obj = default(object);
			object obj2 = default(object);
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					obj = Ⴓ.Ⴀ;
					num = 1;
					break;
				case 1:
					obj2 = obj as OnIoClientConnectEventHandler;
					goto case 2;
				case 2:
					multicastDelegate = (OnIoClientConnectEventHandler)UtilsIdentity.Ⴀ((Delegate)(obj2 as OnIoClientConnectEventHandler), (Delegate)value, 67, '|');
					num = 0;
					break;
				case 0:
					obj = Interlocked.CompareExchange(ref Ⴓ.Ⴀ, (OnIoClientConnectEventHandler)multicastDelegate, (OnIoClientConnectEventHandler)obj2);
					num = ⴐ[537] - 59040;
					break;
				case 3:
				case 7:
					num = (((object)(OnIoClientConnectEventHandler)obj != (OnIoClientConnectEventHandler)obj2) ? (ⴃႣ[180] - 10733) : (ⴗ[111] - 11661));
					break;
				case 4:
				case 5:
					return;
				}
			}
		}
		remove
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			char[] ⴃႭ = WxCfg.ႣႭ;
			int num = 5;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = Ⴓ.Ⴀ;
					num = ⴀ[28] - 35536;
					break;
				case 0:
					multicastDelegate2 = (OnIoClientConnectEventHandler)multicastDelegate;
					obj = (OnIoClientConnectEventHandler)DownloadUrl2.Ⴜ((Delegate)(multicastDelegate2 as OnIoClientConnectEventHandler), (Delegate)value, '\u035b', '\u0361');
					goto case 1;
				case 1:
					num = 7;
					break;
				case 4:
				case 7:
					multicastDelegate = Interlocked.CompareExchange(ref Ⴓ.Ⴀ, obj as OnIoClientConnectEventHandler, multicastDelegate2 as OnIoClientConnectEventHandler);
					goto case 3;
				case 3:
					num = 2;
					break;
				case 2:
					num = (((object)(OnIoClientConnectEventHandler)multicastDelegate != (OnIoClientConnectEventHandler)multicastDelegate2) ? (ⴃႭ[249] - 12442) : 6);
					break;
				case 6:
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
			int num = 4;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			MulticastDelegate multicastDelegate3 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = Ⴓ.Ⴃ;
					num = 7;
					break;
				case 0:
				case 7:
					multicastDelegate2 = multicastDelegate as OnIoClientDisconnectEventHandler;
					multicastDelegate3 = (OnIoClientDisconnectEventHandler)UtilsIdentity.Ⴀ((Delegate)(multicastDelegate2 as OnIoClientDisconnectEventHandler), (Delegate)value, 220, 'ã');
					goto case 3;
				case 3:
					num = 6;
					break;
				case 1:
				case 6:
					multicastDelegate = Interlocked.CompareExchange(ref Ⴓ.Ⴃ, multicastDelegate3 as OnIoClientDisconnectEventHandler, multicastDelegate2 as OnIoClientDisconnectEventHandler);
					num = 2;
					break;
				case 2:
					num = (((object)(multicastDelegate as OnIoClientDisconnectEventHandler) != multicastDelegate2 as OnIoClientDisconnectEventHandler) ? (ⴐ[400] - 21716) : 5);
					break;
				case 5:
					return;
				}
			}
		}
		remove
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			int num = 5;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = Ⴓ.Ⴃ;
					num = 1;
					break;
				case 1:
				case 3:
				case 6:
					multicastDelegate2 = multicastDelegate as OnIoClientDisconnectEventHandler;
					obj = (OnIoClientDisconnectEventHandler)DownloadUrl2.Ⴜ((Delegate)(multicastDelegate2 as OnIoClientDisconnectEventHandler), (Delegate)value, 'é', 'Ó');
					num = 7;
					break;
				case 7:
					multicastDelegate = Interlocked.CompareExchange(ref Ⴓ.Ⴃ, obj as OnIoClientDisconnectEventHandler, (OnIoClientDisconnectEventHandler)multicastDelegate2);
					num = ⴐ[225] - 26614;
					break;
				case 0:
				case 2:
					num = (((object)(multicastDelegate as OnIoClientDisconnectEventHandler) != (OnIoClientDisconnectEventHandler)multicastDelegate2) ? 1 : (ⴃႤ[119] - 17051));
					break;
				case 4:
					return;
				}
			}
		}
	}

	public TcpServerClient()
	{
		DxSpotRate = new double[60];
		ConnectDts = DateTime.MinValue;
	}

	public bool Send(byte[] data)
	{
		LastSendDts = DxAtlasData.Ⴈ(1002, 930);
		return true;
	}

	public virtual bool Send(string msg)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		while (true)
		{
			object obj = ႣႼ.ႰႳ(ObjectCopierExt.Ⴄ(137, 223), msg, 757, 'ʴ');
			while (true)
			{
				IL_0063:
				int num = ⴐ[464] - 29631;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႭ[163] - 38780;
						continue;
					case 4:
						break;
					case 5:
						goto IL_0063;
					case 2:
					case 3:
						LastSendDts = DxAtlasData.Ⴈ(60, 116);
						goto case 1;
					case 1:
						return HostTcpServer.Send(Socket, obj as byte[]);
					}
					break;
				}
				break;
			}
		}
	}

	public void Connect()
	{
	}

	public virtual void Disconnect()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 2;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((Socket == null) ? (ⴃႣ[23] - 17522) : 3);
				break;
			case 1:
			case 3:
				TelnetServerClient.Ⴜ(Socket, 696, 652);
				return;
			case 4:
				return;
			}
			num = num2;
		}
	}

	public void OnConnect(string msg)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 5;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((Ⴓ.Ⴀ == null) ? (ⴃႣ[11] - 31094) : 3);
				break;
			case 1:
			case 3:
				DxCommentExtCfg.ႷႥ(Ⴓ.Ⴀ, msg, 783, 825);
				return;
			case 0:
			case 4:
				return;
			}
			num = num2;
		}
	}

	public void OnDisconnect(string msg)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 4;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((Ⴓ.Ⴃ == null) ? (ⴃႤ[591] - 38525) : 0);
				break;
			case 0:
			case 5:
				UtilsXml.Ⴍ(Ⴓ.Ⴃ, msg, 332, 256);
				return;
			case 2:
				return;
			}
			num = num2;
		}
	}

	public void OnRx(string msg)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((Ⴓ.Ⴓ == null) ? 2 : (ⴃႣ[56] - 56169));
				break;
			case 0:
			case 1:
			case 5:
			case 6:
				num = ((!IsConnected) ? 2 : 3);
				break;
			case 3:
				DgvTextBoxColumnFilter.Ⴃ(Ⴓ.Ⴓ, msg, 468, 492);
				return;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static TcpServerClient()
	{
		UtilsIdentity.Ⴐ();
		Ⴃ = ArcLogInRqstExt.Ⴍ(UtilsString.Ⴐ(null, 8, 192631222), 299, 372);
	}
}
