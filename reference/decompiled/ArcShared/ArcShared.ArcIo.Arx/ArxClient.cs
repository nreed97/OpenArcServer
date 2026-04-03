using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security;
using System.Threading;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Tcp;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using log4net;
using Ⴃ;

namespace ArcShared.ArcIo.Arx;

public sealed class ArxClient : TcpClient
{
	private static readonly ILog m_Ⴄ;

	private static readonly object m_Ⴗ;

	private string m_Ⴐ = string.Empty;

	private UtilsValidation.Ⴐ Ⴓ = new UtilsValidation.Ⴐ();

	public ArxClient()
	{
	}

	public ArxClient(IIoDeviceCfg ioDeviceCfg)
		: base(ioDeviceCfg)
	{
		MulticastDelegate multicastDelegate = new TimerCallback(Ⴈ);
		IDisposable disposable = new Timer(multicastDelegate as TimerCallback, this, 500, 250);
		Ⴓ.Ⴐ = disposable as Timer;
	}

	public override void OnRx(string rxMsg)
	{
		bool flag = false;
		object ⴗ = default(object);
		try
		{
			DownloadUrl2.ႥႰ(ⴗ = ArxClient.m_Ⴗ, ref flag, '\f', '-');
			this.m_Ⴐ = ReverseBeaconClient.Ⴗ(this.m_Ⴐ, rxMsg, 'ơ', 'ǩ');
		}
		finally
		{
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!flag) ? 3 : 0);
					goto IL_0056;
				case 0:
				case 1:
					Monitor.Exit(ⴗ);
					break;
				case 3:
				case 4:
					break;
				}
				break;
				IL_0056:
				num = num2;
			}
		}
	}

	private new void Ⴈ(object P_0)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				WwvSpotExt.Ⴓ(UtilsCallsign.Ⴍ(285, 'Ľ'), new CultureInfo(ArcLogInRqstExt.Ⴗ(1706507944, 13, 7)), 370, 'Ř');
				num = ⴃႣ[177] - 7938;
				break;
			case 6:
			{
				UtilsCallsign.Ⴍ(1000, 'ψ').CurrentCulture = new CultureInfo(ArcLogInRqstExt.Ⴗ(1706507950, 14, 1));
				char num2 = ⴀ[126];
				NeedsCfg.ႣႤ[367] = (NeedsCfg.ႣႤ[367] | NeedsCfg.ႣႤ[572]) & 0x23;
				num = num2 - 16245;
				break;
			}
			case 2:
				num = ((!base.IsConnected) ? (ⴐ[329] - 22271) : 4);
				break;
			case 4:
			case 7:
				ProcessRxMessages();
				return;
			case 1:
			case 5:
				return;
			}
		}
	}

	public void ProcessRxMessages()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object obj = new List<string>();
		bool flag = false;
		object ⴗ = default(object);
		try
		{
			switch (1)
			{
			default:
				DownloadUrl2.ႥႰ(ⴗ = ArxClient.m_Ⴗ, ref flag, 'ǵ', 'ǔ');
				try
				{
					int num = 0;
					ICloneable cloneable = default(ICloneable);
					while (true)
					{
						switch (num)
						{
						default:
							cloneable = Ⴐ();
							num = ⴃႣ[144] - 42510;
							continue;
						case 2:
							(obj as List<string>).Add(cloneable as string);
							goto case 5;
						case 5:
						case 6:
							cloneable = Ⴐ();
							num = ⴃႣ[155] - 46129;
							continue;
						case 7:
							num = ((UtilsCallsign.Ⴓ((string)cloneable, 162, 149) > 0) ? 2 : (ⴐ[605] - 33652));
							continue;
						case 4:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					ArxClient.m_Ⴄ.Warn(ReverseBeaconClient.Ⴗ(DownloadUrl2.Ⴅ(15, null, 2018867588, 2), PrecisionTimer.Ⴜ(ex as Exception, 632, 'ȥ'), 'Ȗ', 'ɞ'));
					this.m_Ⴐ = string.Empty;
				}
				switch (1)
				{
				}
				break;
			}
		}
		finally
		{
			int num2 = 0;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 3 : 4);
					goto IL_0182;
				case 4:
				case 5:
					UtilsString.Ⴜ(ⴗ, 647, 'ʎ');
					break;
				case 1:
				case 3:
					break;
				}
				break;
				IL_0182:
				num2 = num3;
			}
		}
		switch (0)
		{
		}
		List<string>.Enumerator enumerator = ((List<string>)obj).GetEnumerator();
		try
		{
			int num4 = 7;
			while (true)
			{
				switch (num4)
				{
				default:
					num4 = 4;
					continue;
				case 0:
				case 3:
				{
					object current = enumerator.Current;
					base.OnRx(current as string);
					break;
				}
				case 1:
				case 4:
					break;
				case 2:
					goto end_IL_01c9;
				}
				num4 = (enumerator.MoveNext() ? (ⴐ[382] - 29769) : 2);
				continue;
				end_IL_01c9:
				break;
			}
		}
		finally
		{
			switch (0)
			{
			default:
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				break;
			case 4:
				break;
			}
		}
		switch (4)
		{
		}
	}

	private string Ⴐ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			IEnumerable enumerable = Ⴄ();
			while (true)
			{
				IL_004a:
				int num = ((!StringConstants.Ⴐ(enumerable as string, 816, 800)) ? 8 : 0);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 1;
						continue;
					case 1:
						break;
					case 2:
						goto IL_004a;
					case 8:
						return (string)enumerable;
					case 0:
						enumerable = Ⴗ();
						goto case 5;
					case 5:
						num = (StringConstants.Ⴐ((string)enumerable, 113, 97) ? (ⴗ[116] - 43239) : (ⴀ[320] - 27690));
						continue;
					case 6:
						return enumerable as string;
					case 7:
						return string.Empty;
					}
					break;
				}
				break;
			}
		}
	}

	private string Ⴄ()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num3 = default(int);
		object bytes = default(object);
		while (true)
		{
			ICloneable cloneable = string.Empty;
			int num = ColumnFilterEventArgs.Ⴍ(this.m_Ⴐ, ႣႼ.ႥႭ(null, 624735594, 5, null), 88, 93);
			while (true)
			{
				IL_0083:
				int num2 = ⴃႭ[108] - 41246;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = 6;
						continue;
					case 6:
						break;
					case 4:
						goto IL_0083;
					case 0:
						num3 = ColumnFilterEventArgs.Ⴍ(this.m_Ⴐ, ArcLogInRqstExt.Ⴗ(1706508102, 10, 4), 240, 245);
						goto case 5;
					case 5:
						num2 = 8;
						continue;
					case 8:
						num2 = ((num <= -1) ? (ⴀ[203] - 51138) : (ⴃႭ[198] - 52099));
						continue;
					case 9:
						num2 = ((num3 <= 0) ? 3 : 2);
						continue;
					case 2:
					case 10:
						cloneable = UtilsLatLon.Ⴜ(this.m_Ⴐ, num + 6, num3 - num - 6, 493, 461);
						num2 = ⴃႣ[90] - 40891;
						continue;
					case 1:
						bytes = UtilsValidation.Ⴓ(212, 153).GetBytes(ArcLogInRespExt.Ⴐ((string)cloneable, 246, 183));
						num2 = 7;
						continue;
					case 7:
						cloneable = UtilsComp.Ⴃ(bytes as byte[]);
						this.m_Ⴐ = this.m_Ⴐ.Substring(num3 + 7);
						num2 = ⴃႤ[439] - 3941;
						continue;
					case 3:
						return (string)cloneable;
					}
					break;
				}
				break;
			}
		}
	}

	private string Ⴗ()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num3 = default(int);
		while (true)
		{
			object obj = string.Empty;
			int num = ColumnFilterEventArgs.Ⴍ(this.m_Ⴐ, UtilsString.Ⴐ(null, 8, 192632111), 817, 820);
			while (true)
			{
				IL_0091:
				int num2 = ⴀ[400] - 20049;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = ⴐ[588] - 38892;
						continue;
					case 7:
						break;
					case 2:
						goto IL_0091;
					case 8:
						num3 = ColumnFilterEventArgs.Ⴍ(this.m_Ⴐ, ႣႼ.Ⴜ(7, 365387404, 30), 240, 245);
						num2 = ⴐ[133] - 20128;
						continue;
					case 3:
					case 10:
						num2 = ((num <= -1) ? 6 : 5);
						continue;
					case 5:
						num2 = ((num3 <= 0) ? (ⴀ[21] - 21549) : (ⴃႣ[174] - 9353));
						continue;
					case 1:
					case 9:
						obj = UtilsLatLon.Ⴜ(this.m_Ⴐ, num + 6, num3 - num - 6, 1006, 974);
						num2 = ⴃႤ[566] - 54720;
						continue;
					case 4:
						this.m_Ⴐ = this.m_Ⴐ.Substring(num3 + 7);
						num2 = 6;
						continue;
					case 6:
						return obj as string;
					}
					break;
				}
				break;
			}
		}
	}

	public override bool Send(string msg)
	{
		while (true)
		{
			object obj = new ByteAppend<byte>();
			while (true)
			{
				IL_0034:
				(obj as ByteAppend<byte>).Add(ႣႼ.ႰႳ(ObjectCopierExt.Ⴄ(279, 321), ႣႼ.ႥႭ(msg, 624735595, 4, null), 701, '\u02fc'));
				while (true)
				{
					IL_006a:
					int num = 4;
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
						case 1:
							goto IL_0034;
						case 3:
							goto IL_006a;
						case 4:
							(obj as ByteAppend<byte>).Add(UtilsComp.Ⴅ(msg));
							((ByteAppend<byte>)obj).Add(ObjectCopierExt.Ⴄ(317, 363).GetBytes(ArcLogInRqstExt.Ⴗ(1706508098, 4, 0)));
							num = 0;
							continue;
						case 0:
						{
							Array array = ((ByteAppend<byte>)obj).ToArray();
							return Send((byte[])array);
						}
						}
						break;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static ArxClient()
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				UtilsIdentity.Ⴐ();
				goto case 2;
			case 2:
				ArxClient.m_Ⴄ = ArcLogInRqstExt.Ⴍ(ArcLogInRqstExt.Ⴗ(1706507954, 16, 5), 983, 904);
				break;
			case 1:
				break;
			case 3:
				ArxClient.m_Ⴗ = new object();
				return;
			case 0:
				return;
			}
			num = 3;
		}
	}
}
