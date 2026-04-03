using System;
using System.Collections;
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
using ArcShared.ExtensionMethods.Objects;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using Ⴃ;

namespace ArcShared.ArcIo.Telnet;

public class TelnetClient : TcpClient
{
	private static readonly ILog Ⴃ;

	private static readonly object Ⴐ;

	private string Ⴀ = string.Empty;

	private Timer Ⴀ;

	public TelnetClient(IIoDeviceCfg ioDeviceCfg)
		: base(ioDeviceCfg)
	{
		MulticastDelegate multicastDelegate = new TimerCallback(Ⴓ);
		Ⴀ = new Timer(multicastDelegate as TimerCallback, this, 500, 250);
	}

	public override void OnRx(string rxMsg)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		bool flag = false;
		object ⴐ = default(object);
		try
		{
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					DownloadUrl2.ႥႰ(ⴐ = Ⴐ, ref flag, 'Ġ', 'ā');
					goto case 4;
				case 4:
					this.Ⴀ = ReverseBeaconClient.Ⴗ(this.Ⴀ, rxMsg, 'ʳ', '\u02fb');
					goto case 1;
				case 1:
					num = 2;
					continue;
				case 2:
				{
					int num2 = UtilsCallsign.Ⴓ(this.Ⴀ, 868, 851);
					DataGridViewColumnSelector.Ⴐ[518] = (char)((DataGridViewColumnSelector.Ⴐ[518] ^ DataGridViewColumnSelector.Ⴐ[85]) & 0xD4);
					num = ((num2 <= 250000) ? 8 : 7);
					continue;
				}
				case 7:
				{
					ILog ⴃ = Ⴃ;
					object obj = new object[4];
					(obj as object[])[0] = UtilsString.Ⴐ(null, 7, 192632399);
					(obj as object[])[1] = UtilsCallsign.Ⴓ(this.Ⴀ, 341, 354);
					((object[])obj)[2] = DownloadUrl2.Ⴅ(28, null, 2018868043, 7);
					((object[])obj)[3] = base.ConnectInfo;
					ⴃ.Error(string.Concat((object[])obj));
					num = ⴃႣ[136] - 56829;
					continue;
				}
				case 6:
					this.Ⴀ = string.Empty;
					num = 8;
					continue;
				case 0:
				case 8:
					break;
				}
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
					num4 = (flag ? 1 : (ⴃႣ[13] - 37644));
					goto IL_0186;
				case 1:
				case 5:
				case 6:
					Monitor.Exit(ⴐ);
					break;
				case 3:
					break;
				}
				break;
				IL_0186:
				num3 = num4;
			}
		}
		switch (3)
		{
		}
	}

	private void Ⴓ(object P_0)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 2;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((!base.IsConnected) ? 1 : (ⴃႣ[237] - 17634));
				break;
			case 3:
			case 5:
				Ⴅ();
				return;
			case 0:
			case 1:
				return;
			}
			num = num2;
		}
	}

	private void Ⴅ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = new List<string>();
		bool flag = false;
		object ⴐ2 = default(object);
		try
		{
			int num = 7;
			int num2 = default(int);
			IEnumerable enumerable = default(IEnumerable);
			while (true)
			{
				switch (num)
				{
				default:
					DownloadUrl2.ႥႰ(ⴐ2 = Ⴐ, ref flag, 'Z', '{');
					num = ((UtilsCallsign.Ⴓ(this.Ⴀ, 149, 162) <= 0) ? (ⴃႭ[16] - 11723) : 2);
					continue;
				case 2:
				case 3:
					num = (Ⴈ ? 10 : 4);
					continue;
				case 4:
					this.Ⴀ = ScrubLogin(this.Ⴀ);
					num = 10;
					continue;
				case 10:
					this.Ⴀ = UtilsString.ScrubRxCommMsg(this.Ⴀ);
					num = 12;
					continue;
				case 5:
					num2 = ColumnFilterEventArgs.Ⴍ(this.Ⴀ, UtilsString.Ⴐ(null, 5, 192631502), 783, 778);
					goto case 0;
				case 0:
					num = ⴐ[474] - 43923;
					continue;
				case 11:
					enumerable = UtilsLatLon.Ⴜ(this.Ⴀ, 0, num2, 737, 705);
					this.Ⴀ = AutoUpdater.ႨႣ(this.Ⴀ, num2 + 1, 752, 695);
					num = ⴃႭ[78] - 59556;
					continue;
				case 6:
					(obj as List<string>).Add(enumerable as string);
					break;
				case 12:
					break;
				case 1:
				case 9:
					goto end_IL_0028;
				}
				num = (AutoUpdater.ႨႰ(this.Ⴀ, UtilsString.Ⴐ(null, 8, 192631491), 462, 'Ʀ') ? 5 : (ⴃႣ[130] - 18580));
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
					num4 = ((!flag) ? 4 : (ⴀ[294] - 42258));
					goto IL_01ee;
				case 1:
					UtilsString.Ⴜ(ⴐ2, 610, 'ɫ');
					break;
				case 0:
				case 4:
					break;
				}
				break;
				IL_01ee:
				num3 = num4;
			}
		}
		switch (2)
		{
		}
		List<string>.Enumerator enumerator = ((List<string>)obj).GetEnumerator();
		try
		{
			int num5 = 5;
			while (true)
			{
				switch (num5)
				{
				default:
					num5 = 1;
					continue;
				case 2:
				case 4:
				{
					ICloneable current = enumerator.Current;
					base.OnRx(current as string);
					break;
				}
				case 1:
					break;
				case 6:
				case 7:
					goto end_IL_0235;
				}
				int num7;
				if (!enumerator.MoveNext())
				{
					char num6 = ⴃႭ[141];
					TalkCfg.ႣႣ[150] = (char)(TalkCfg.ႣႣ[150] & TalkCfg.ႣႣ[166] & 0x1B);
					num7 = num6 - 61696;
				}
				else
				{
					num7 = 2;
				}
				num5 = num7;
				continue;
				end_IL_0235:
				break;
			}
		}
		finally
		{
			switch (4)
			{
			default:
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				break;
			case 0:
			case 1:
				break;
			}
		}
		switch (1)
		{
		}
	}

	public string ScrubLogin(string msg)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		while (true)
		{
			int num = ((!UtilsString.IsMsgRequestingLogin(msg)) ? (ⴃႭ[72] - 28227) : (ⴃႭ[198] - 52107));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 7;
					continue;
				case 7:
					break;
				case 1:
					msg = DgvFilterManager.ႭႭ(msg, UtilsString.Ⴐ(null, 5, 192632444), ႣႼ.Ⴜ(5, 365386851, 14), 233, 139);
					goto case 0;
				case 0:
					num = ⴃႣ[69] - 61593;
					continue;
				case 3:
				case 8:
					msg = DgvFilterManager.ႭႭ(msg, UtilsString.Ⴐ(null, 0, 192632331), ႣႼ.Ⴜ(7, 365386764, 13), 756, 662);
					num = 4;
					continue;
				case 2:
				case 4:
					Ⴈ = true;
					num = 6;
					continue;
				case 6:
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
			Array array = ႣႼ.ႰႳ(ObjectCopierExt.Ⴄ(373, 291), msg, 907, 'ϊ');
			int num = ⴃႤ[306] - 29330;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 5;
					continue;
				case 0:
				case 3:
				case 5:
					break;
				case 1:
				case 4:
					return Send((byte[])array);
				}
				break;
			}
		}
	}

	public override void Connect()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		bool flag = false;
		object ⴐ = default(object);
		try
		{
			DownloadUrl2.ႥႰ(ⴐ = Ⴐ, ref flag, 'ƚ', 'ƻ');
			this.Ⴀ = string.Empty;
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
					num2 = (flag ? (ⴃႤ[163] - 47486) : 0);
					goto IL_005f;
				case 3:
					UtilsString.Ⴜ(ⴐ, 177, '\u00b8');
					break;
				case 0:
				case 2:
					break;
				}
				break;
				IL_005f:
				num = num2;
			}
		}
		Ⴈ = false;
		base.Connect();
	}

	[SecuritySafeCritical]
	static TelnetClient()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				UtilsIdentity.Ⴐ();
				break;
			case 1:
			case 4:
				break;
			case 3:
				Ⴐ = new object();
				return;
			}
			Ⴃ = ArcLogInRqstExt.Ⴍ(ArcLogInRqstExt.Ⴗ(1706506865, 28, 7), 470, 393);
			num = 3;
		}
	}
}
