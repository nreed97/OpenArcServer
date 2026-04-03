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
using Ⴃ;

namespace ArcShared.ArcIo.Pcxx;

public sealed class PcxxServer : TcpServer
{
	private static readonly ILog Ⴃ;

	private Timer Ⴐ;

	public PcxxServer(IIoDeviceCfg ioDeviceCfg)
		: base(ioDeviceCfg)
	{
		MulticastDelegate multicastDelegate = new TimerCallback(Ⴅ);
		Ⴐ = new Timer((TimerCallback)multicastDelegate, this, 500, 250);
	}

	public override void Stop()
	{
		DgvBaseFilterHost.Ⴀ(Ⴐ, 'Ά', 'Ϯ');
		base.Stop();
	}

	private void Ⴅ(object P_0)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 2;
		TcpServerClient result = default(TcpServerClient);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
			case 7:
				Queue.TryDequeue(out result);
				num = ((result != null) ? 3 : 0);
				continue;
			case 3:
				Ⴗ(result);
				break;
			case 6:
				return;
			}
			int num3;
			if (Queue.Count <= 0)
			{
				int num2 = ⴃႤ[482];
				TalkCfg.ႣႣ[111] = (char)((TalkCfg.ႣႣ[111] ^ NeedsCfg.ႣႤ[487]) & 0x4C);
				num3 = num2 - 36628;
			}
			else
			{
				num3 = 5;
			}
			num = num3;
		}
	}

	private void Ⴗ(TcpServerClient P_0)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		bool flag = false;
		object locker = default(object);
		try
		{
			int num = 6;
			int num2 = default(int);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					DownloadUrl2.ႥႰ(locker = P_0.Locker, ref flag, 'Þ', 'ÿ');
					num2 = ColumnFilterEventArgs.Ⴍ(P_0.RxBuffer, base.EofChar, 105, 108);
					num = 5;
					continue;
				case 1:
					obj = UtilsLatLon.Ⴜ(P_0.RxBuffer, 0, num2, 362, 330);
					P_0.RxBuffer = AutoUpdater.ႨႣ(P_0.RxBuffer, num2 + 1, 213, 146);
					goto case 2;
				case 2:
					num = 0;
					continue;
				case 0:
					P_0.OnRx((string)obj);
					num2 = P_0.RxBuffer.IndexOf(base.EofChar);
					num = 5;
					continue;
				case 5:
					num = ((num2 > -1) ? 1 : (ⴐ[519] - 58355));
					continue;
				case 7:
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
					num4 = ((!flag) ? (ⴗ[155] - 49747) : (ⴀ[263] - 4038));
					goto IL_0132;
				case 2:
				case 5:
					Monitor.Exit(locker);
					break;
				case 0:
					break;
				}
				break;
				IL_0132:
				num3 = num4;
			}
		}
		switch (4)
		{
		}
	}

	protected override TcpServerClient GetClientObject()
	{
		PcxxServerClient result = new PcxxServerClient();
		DxCfg.Ⴗ[11] = (char)((DxCfg.Ⴗ[11] | DxCfg.Ⴗ[70]) & 0x93);
		return result;
	}

	[SecuritySafeCritical]
	static PcxxServer()
	{
		UtilsIdentity.Ⴐ();
		Ⴃ = ArcLogInRqstExt.Ⴍ(ႣႼ.ႥႭ(null, 624736075, 4, null), 313, 358);
	}
}
