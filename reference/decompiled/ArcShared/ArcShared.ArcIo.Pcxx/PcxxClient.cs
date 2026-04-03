using System;
using System.Collections.Generic;
using System.Security;
using System.Threading;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Tcp;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using Ⴃ;

namespace ArcShared.ArcIo.Pcxx;

public sealed class PcxxClient : TcpClient
{
	private new static readonly ILog Ⴈ;

	private static readonly object Ⴗ;

	private new Timer Ⴈ;

	private ArcLogInRqstExt.ႠႷ Ⴀ = new ArcLogInRqstExt.ႠႷ();

	public PcxxClient(IIoDeviceCfg ioDeviceCfg)
	{
		object empty = string.Empty;
		Ⴀ.Ⴄ = (string)empty;
		base._002Ector(ioDeviceCfg);
		MulticastDelegate multicastDelegate = new TimerCallback(Ⴄ);
		Ⴈ = new Timer((TimerCallback)multicastDelegate, this, 500, 250);
	}

	public override void OnRx(string rxMsg)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool flag = false;
		object ⴗ = default(object);
		try
		{
			DownloadUrl2.ႥႰ(ⴗ = Ⴗ, ref flag, 'I', 'h');
			IConvertible convertible = ReverseBeaconClient.Ⴗ(Ⴀ.Ⴄ, rxMsg, 'ʉ', 'ˁ');
			Ⴀ.Ⴄ = convertible as string;
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
					num2 = ((!flag) ? 4 : (ⴀ[132] - 32885));
					goto IL_007d;
				case 1:
				case 3:
					Monitor.Exit(ⴗ);
					break;
				case 0:
				case 2:
				case 4:
					break;
				}
				break;
				IL_007d:
				num = num2;
			}
		}
	}

	private void Ⴄ(object P_0)
	{
		int num = 1;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((!base.IsConnected) ? 5 : 2);
				break;
			case 2:
			case 3:
			case 4:
				Ⴄ();
				return;
			case 5:
				return;
			}
			num = num2;
		}
	}

	private void Ⴄ()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = new List<string>();
		bool flag = false;
		object ⴗ2 = default(object);
		try
		{
			int num = 6;
			int num2 = default(int);
			IComparable<string> comparable = default(IComparable<string>);
			while (true)
			{
				switch (num)
				{
				default:
					DownloadUrl2.ႥႰ(ⴗ2 = Ⴗ, ref flag, 'Ņ', 'Ť');
					goto case 11;
				case 11:
					num = ((UtilsCallsign.Ⴓ(Ⴀ.Ⴄ, 957, 906) <= 0) ? 9 : 8);
					continue;
				case 2:
				case 8:
					num = (Ⴀ.Ⴅ ? 13 : (ⴃႤ[430] - 33411));
					continue;
				case 4:
				{
					object obj3 = ScrubLogin(Ⴀ.Ⴄ);
					Ⴀ.Ⴄ = obj3 as string;
					num = 13;
					continue;
				}
				case 13:
				{
					object obj2 = UtilsString.ScrubRxCommMsg(Ⴀ.Ⴄ);
					Ⴀ.Ⴄ = obj2 as string;
					num = ⴃႣ[166] - 48253;
					continue;
				}
				case 10:
					num2 = ColumnFilterEventArgs.Ⴍ(Ⴀ.Ⴄ, UtilsString.Ⴐ(null, 3, 192631496), 220, 217);
					num = ⴃႤ[286] - 53650;
					continue;
				case 5:
					comparable = UtilsLatLon.Ⴜ(Ⴀ.Ⴄ, 0, num2, 303, 271);
					num = 3;
					continue;
				case 3:
				{
					ICloneable cloneable = AutoUpdater.ႨႣ(Ⴀ.Ⴄ, num2 + 1, 32, 103);
					Ⴀ.Ⴄ = (string)cloneable;
					num = ⴃႭ[60] - 19461;
					continue;
				}
				case 7:
					num = ((UtilsCallsign.Ⴓ(comparable as string, 90, 109) > 0) ? (ⴃႣ[212] - 7567) : 0);
					continue;
				case 12:
				case 14:
					(obj as List<string>).Add(comparable as string);
					break;
				case 0:
					break;
				case 9:
					goto end_IL_0028;
				}
				num = (AutoUpdater.ႨႰ(Ⴀ.Ⴄ, UtilsString.Ⴐ(null, 0, 192631499), 725, 'ʽ') ? (ⴗ[139] - 41082) : 9);
				continue;
				end_IL_0028:
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
					num4 = ((!flag) ? (ⴃႣ[83] - 56478) : (ⴃႤ[129] - 5567));
					goto IL_028e;
				case 4:
					Monitor.Exit(ⴗ2);
					break;
				case 6:
					break;
				}
				break;
				IL_028e:
				num3 = num4;
			}
		}
		switch (3)
		{
		}
		List<string>.Enumerator enumerator = ((List<string>)obj).GetEnumerator();
		try
		{
			int num5 = 3;
			ICloneable current = default(ICloneable);
			while (true)
			{
				switch (num5)
				{
				default:
					num5 = 2;
					continue;
				case 0:
					current = enumerator.Current;
					goto case 7;
				case 7:
					base.OnRx((string)current);
					break;
				case 2:
				case 5:
					break;
				case 6:
					goto end_IL_02d5;
				}
				num5 = ((!enumerator.MoveNext()) ? 6 : 0);
				continue;
				end_IL_02d5:
				break;
			}
		}
		finally
		{
			switch (3)
			{
			default:
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				break;
			}
		}
		switch (3)
		{
		}
	}

	public string ScrubLogin(string msg)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		while (true)
		{
			int num = ((!UtilsString.IsMsgRequestingLogin(msg)) ? 7 : 9);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
					break;
				case 9:
					msg = DgvFilterManager.ႭႭ(msg, UtilsString.Ⴐ(null, 3, 192632442), ႣႼ.Ⴜ(7, 365386849, 27), 744, 650);
					goto case 5;
				case 5:
					num = 4;
					continue;
				case 3:
				case 4:
					msg = DgvFilterManager.ႭႭ(msg, UtilsString.Ⴐ(null, 7, 192632332), ႣႼ.Ⴜ(1, 365386762, 11), 765, 671);
					num = ⴀ[22] - 19616;
					continue;
				case 1:
					msg = DgvFilterManager.ႭႭ(msg, ArcLogInRqstExt.Ⴗ(1706507818, 11, 5), UtilsString.Ⴐ(null, 7, 192632947), 956, 990);
					goto case 8;
				case 8:
					num = 6;
					continue;
				case 6:
				{
					bool ⴅ = true;
					Ⴀ.Ⴅ = ⴅ;
					num = 7;
					continue;
				}
				case 7:
					return msg;
				}
				break;
			}
		}
	}

	public override bool Send(string msg)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		while (true)
		{
			object obj = ႣႼ.ႰႳ(ObjectCopierExt.Ⴄ(900, 978), msg, 922, 'ϛ');
			while (true)
			{
				IL_005c:
				int num = 5;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႤ[313] - 60973;
						continue;
					case 1:
					case 4:
						break;
					case 3:
						goto IL_005c;
					case 0:
					case 5:
						return Send(obj as byte[]);
					}
					break;
				}
				break;
			}
		}
	}

	public override void Connect()
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
			{
				object empty = string.Empty;
				Ⴀ.Ⴄ = empty as string;
				bool ⴅ = false;
				Ⴀ.Ⴅ = ⴅ;
				break;
			}
			case 0:
			case 3:
				break;
			case 1:
				base.Connect();
				return;
			case 4:
				return;
			}
			num = 1;
		}
	}

	[SecuritySafeCritical]
	static PcxxClient()
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				UtilsIdentity.Ⴐ();
				goto case 1;
			case 1:
				PcxxClient.Ⴈ = ArcLogInRqstExt.Ⴍ(ႣႼ.Ⴜ(3, 365385734, 12), 595, 524);
				break;
			case 3:
				break;
			case 0:
				Ⴗ = new object();
				return;
			case 2:
				return;
			}
			num = 0;
		}
	}
}
