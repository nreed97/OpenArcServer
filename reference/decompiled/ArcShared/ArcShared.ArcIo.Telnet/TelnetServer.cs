using System;
using System.Security;
using System.Threading;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Tcp;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.ExtensionMethods.Login;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;

namespace ArcShared.ArcIo.Telnet;

public class TelnetServer : TcpServer
{
	private static readonly ILog Ⴓ;

	private UtilsValidation.Ⴐ m_Ⴀ = new UtilsValidation.Ⴐ();

	public TelnetServer(IIoDeviceCfg ioDeviceCfg)
		: base(ioDeviceCfg)
	{
		MulticastDelegate multicastDelegate = new TimerCallback(Ⴀ);
		MarshalByRefObject marshalByRefObject = new Timer((TimerCallback)multicastDelegate, this, 500, 250);
		this.m_Ⴀ.Ⴐ = (Timer)marshalByRefObject;
	}

	private void Ⴀ(object P_0)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 4;
		TcpServerClient result = default(TcpServerClient);
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
			case 7:
				Queue.TryDequeue(out result);
				num = ((result == null) ? (ⴃႣ[199] - 41515) : 6);
				continue;
			case 6:
				Ⴐ(result);
				break;
			case 0:
			case 1:
				return;
			}
			num = ((Queue.Count > 0) ? (ⴐ[196] - 11167) : 0);
		}
	}

	public override void Stop()
	{
		DgvBaseFilterHost.Ⴀ(this.m_Ⴀ.Ⴐ, 'ϑ', 'ι');
		base.Stop();
	}

	private void Ⴐ(TcpServerClient P_0)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		bool flag = false;
		object locker = default(object);
		try
		{
			int num = 7;
			int num2 = default(int);
			IComparable comparable = default(IComparable);
			while (true)
			{
				switch (num)
				{
				default:
					DownloadUrl2.ႥႰ(locker = P_0.Locker, ref flag, 'ɗ', 'ɶ');
					goto case 9;
				case 9:
					num2 = ColumnFilterEventArgs.Ⴍ(P_0.RxBuffer, base.EofChar, 661, 656);
					num = ⴃႣ[130] - 18569;
					continue;
				case 10:
				case 11:
					comparable = UtilsLatLon.Ⴜ(P_0.RxBuffer, 0, num2, 470, 502);
					comparable = DgvFilterManager.ႭႭ(comparable as string, UtilsString.Ⴐ(null, 7, 192631500), string.Empty, 99, 1);
					num = ⴃႤ[500] - 25132;
					continue;
				case 0:
					comparable = DgvFilterManager.ႭႭ(comparable as string, UtilsString.Ⴐ(null, 7, 192632147), string.Empty, 998, 900);
					num = 3;
					continue;
				case 3:
					P_0.RxBuffer = AutoUpdater.ႨႣ(P_0.RxBuffer, num2 + 1, 432, 503);
					num = ⴃႭ[209] - 32130;
					continue;
				case 6:
					num = ((UtilsCallsign.Ⴓ(comparable as string, 855, 864) <= 0) ? 1 : 4);
					continue;
				case 4:
					P_0.OnRx(comparable as string);
					goto case 1;
				case 1:
					num2 = P_0.RxBuffer.IndexOf(base.EofChar);
					num = 12;
					continue;
				case 12:
				{
					int num3;
					if (num2 <= -1)
					{
						num3 = ⴃႭ[189] - 55207;
					}
					else
					{
						char num4 = ⴃႣ[119];
						WxCfg.ႣႭ[255] = (char)((WxCfg.ႣႭ[255] ^ WxCfg.ႣႭ[198]) & 0x87);
						num3 = num4 - 27077;
					}
					num = num3;
					continue;
				}
				case 2:
				case 5:
					break;
				}
				break;
			}
		}
		finally
		{
			int num5 = 0;
			while (true)
			{
				int num6;
				switch (num5)
				{
				default:
					num6 = ((!flag) ? (ⴀ[342] - 32047) : (ⴀ[400] - 20051));
					goto IL_0226;
				case 6:
					Monitor.Exit(locker);
					break;
				case 4:
					break;
				}
				break;
				IL_0226:
				num5 = num6;
			}
		}
		switch (0)
		{
		}
	}

	protected override TcpServerClient GetClientObject()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		return new TelnetServerClient();
	}

	[SecuritySafeCritical]
	static TelnetServer()
	{
		UtilsIdentity.Ⴐ();
		Ⴓ = ArcLogInRqstExt.Ⴍ(DownloadUrl2.Ⴅ(18, null, 2018867447, 8), 897, 990);
	}
}
