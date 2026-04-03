using System;
using System.Collections.Generic;
using System.Security;
using System.Threading;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Tcp;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.ExtensionMethods.Login;
using log4net;
using Ⴃ;

namespace ArcShared.ArcIo.Arx;

public sealed class ArxServer : TcpServer
{
	private static readonly ILog m_Ⴗ;

	private UtilsValidation.Ⴐ Ⴃ = new UtilsValidation.Ⴐ();

	public ArxServer(IIoDeviceCfg ioDeviceCfg)
		: base(ioDeviceCfg)
	{
		MulticastDelegate multicastDelegate = new TimerCallback(Ⴄ);
		object obj = new Timer(multicastDelegate as TimerCallback, this, 500, 250);
		Ⴃ.Ⴐ = obj as Timer;
	}

	public override void Stop()
	{
		DgvBaseFilterHost.Ⴀ(Ⴃ.Ⴐ, 'E', '-');
		base.Stop();
	}

	private void Ⴄ(object P_0)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 7;
		TcpServerClient result = default(TcpServerClient);
		while (true)
		{
			switch (num)
			{
			case 1:
				Queue.TryDequeue(out result);
				num = ((result == null) ? 3 : (ⴐ[59] - 43829));
				continue;
			case 0:
			case 4:
				Ⴗ(result);
				break;
			case 5:
				return;
			}
			num = ((Queue.Count > 0) ? 1 : 5);
		}
	}

	private void Ⴗ(TcpServerClient P_0)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		bool flag = false;
		object locker = default(object);
		try
		{
			int num = 0;
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
					DownloadUrl2.ႥႰ(locker = P_0.Locker, ref flag, '\u0344', '\u0365');
					goto case 3;
				case 3:
					enumerable = Ⴀ(P_0);
					goto case 2;
				case 2:
					num = 4;
					break;
				case 5:
				case 6:
					P_0.OnRx((string)enumerable);
					enumerable = Ⴀ(P_0);
					num = ⴐ[382] - 29768;
					break;
				case 4:
					num = ((UtilsCallsign.Ⴓ((string)enumerable, 560, 519) > 0) ? 6 : (ⴗ[31] - 486));
					break;
				case 1:
					return;
				}
			}
		}
		finally
		{
			int num2 = 2;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? (ⴃႭ[245] - 52426) : (ⴀ[387] - 45971));
					goto IL_00f0;
				case 1:
				case 3:
				case 5:
					Monitor.Exit(locker);
					break;
				case 0:
					break;
				}
				break;
				IL_00f0:
				num2 = num3;
			}
		}
	}

	private static string Ⴀ(TcpServerClient P_0)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			IComparable<string> comparable = Ⴐ(P_0);
			int num = (StringConstants.Ⴐ((string)comparable, 884, 868) ? 2 : (ⴗ[136] - ⴗ[136]));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 1;
					continue;
				case 1:
				case 5:
					break;
				case 0:
				{
					string result = (string)comparable;
					WxCfg.ႣႭ[18] = (char)((WxCfg.ႣႭ[18] - WxCfg.ႣႭ[56]) & 0x4A);
					return result;
				}
				case 2:
				case 6:
					comparable = Ⴍ(P_0);
					goto case 4;
				case 4:
					num = (StringConstants.Ⴐ(comparable as string, 11, 27) ? 8 : (ⴗ[30] - 17781));
					continue;
				case 3:
					return (string)comparable;
				case 8:
					return string.Empty;
				}
				break;
			}
		}
	}

	private static string Ⴐ(TcpServerClient P_0)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num3 = default(int);
		object bytes = default(object);
		while (true)
		{
			IComparable comparable = string.Empty;
			while (true)
			{
				IL_0066:
				int num = ColumnFilterEventArgs.Ⴍ(P_0.RxBuffer, ႣႼ.ႥႭ(null, 624735594, 5, null), 189, 184);
				int num2 = ⴃႣ[179] - 62087;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = 1;
						continue;
					case 1:
						break;
					case 4:
					case 11:
						goto IL_0066;
					case 6:
						num3 = ColumnFilterEventArgs.Ⴍ(P_0.RxBuffer, ArcLogInRqstExt.Ⴗ(1706508103, 10, 5), 217, 220);
						num2 = ⴐ[361] - 22508;
						continue;
					case 7:
						num2 = ((num <= -1) ? 2 : (ⴐ[48] - 38869));
						continue;
					case 10:
						num2 = ((num3 <= 0) ? (ⴗ[93] - 715) : 3);
						continue;
					case 3:
						comparable = UtilsLatLon.Ⴜ(P_0.RxBuffer, num + 6, num3 - num - 6, 23, 55);
						goto case 9;
					case 9:
						num2 = ⴃႣ[103] - 47725;
						continue;
					case 5:
						bytes = UtilsValidation.Ⴓ(556, 609).GetBytes(ArcLogInRespExt.Ⴐ((string)comparable, 468, 405));
						num2 = ⴃႤ[123] - 21539;
						continue;
					case 0:
						comparable = UtilsComp.Ⴃ(bytes as byte[]);
						P_0.RxBuffer = P_0.RxBuffer.Substring(num3 + 7);
						num2 = 2;
						continue;
					case 2:
						return (string)comparable;
					}
					break;
				}
				break;
			}
		}
	}

	private static string Ⴍ(TcpServerClient P_0)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num3 = default(int);
		while (true)
		{
			ICloneable cloneable = string.Empty;
			int num = ColumnFilterEventArgs.Ⴍ(P_0.RxBuffer, UtilsString.Ⴐ(null, 5, 192632098), 389, 384);
			int num2 = ⴃႤ[456] - 29173;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႤ[518] - 11200;
					continue;
				case 3:
				case 4:
				case 7:
					break;
				case 8:
					num3 = ColumnFilterEventArgs.Ⴍ(P_0.RxBuffer, ႣႼ.Ⴜ(5, 365387406, 6), 364, 361);
					num2 = 2;
					continue;
				case 2:
					num2 = ((num <= -1) ? (ⴀ[250] - 26018) : 5);
					continue;
				case 5:
					num2 = ((num3 <= 0) ? (ⴗ[141] - 5941) : (ⴃႭ[109] - 6060));
					continue;
				case 6:
					cloneable = UtilsLatLon.Ⴜ(P_0.RxBuffer, num + 6, num3 - num - 6, 14, 46);
					num2 = ⴃႣ[96] - 36624;
					continue;
				case 10:
					P_0.RxBuffer = P_0.RxBuffer.Substring(num3 + 7);
					num2 = 1;
					continue;
				case 1:
					return (string)cloneable;
				}
				break;
			}
		}
	}

	protected override TcpServerClient GetClientObject()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		return new ArxServerClient();
	}

	[SecuritySafeCritical]
	static ArxServer()
	{
		UtilsIdentity.Ⴐ();
		ArxServer.m_Ⴗ = ArcLogInRqstExt.Ⴍ(UtilsString.Ⴐ(null, 3, 192633350), 491, 436);
	}
}
