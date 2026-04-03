using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using ArcShared.ArcIo.Tcp;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcIo.Arc4;

public sealed class Arc4Server : TcpServer
{
	private static readonly ILog Ⴍ = SkimmerValidSpot.Ⴐ(ReplyMailHelp.Ⴄ(4, null, 1057165616, 1), 56, 37);

	private Timer Ⴅ;

	public Arc4Server(IIoDeviceCfg ioDeviceCfg)
		: base(ioDeviceCfg)
	{
		MulticastDelegate multicastDelegate = new TimerCallback(Ⴀ);
		Ⴅ = new Timer((TimerCallback)multicastDelegate, this, 500, 250);
	}

	public override void Stop()
	{
		SetWxDefault.Ⴃ(Ⴅ, 313, 270);
		base.Stop();
		ShowWwvOptionsHelp.ႣႥ[361] = (char)((ShowWwvOptionsHelp.ႣႥ[361] | ShowWwvOptionsHelp.ႣႥ[123]) & 0xF9);
	}

	private void Ⴀ(object P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 6;
		TcpServerClient result = default(TcpServerClient);
		while (true)
		{
			switch (num)
			{
			case 7:
			{
				Queue.TryDequeue(out result);
				int num2;
				if (result != null)
				{
					num2 = 0;
				}
				else
				{
					byte num3 = ⴄႤ[121];
					ShowQrzHelp.ႤႤ[485] = (byte)((ShowQrzHelp.ႤႤ[485] ^ ShowQrzHelp.ႤႤ[515]) & 0xE7);
					num2 = num3 - 184;
				}
				num = num2;
				continue;
			}
			case 0:
			case 3:
				ProcessMsgs(result);
				break;
			case 2:
				return;
			}
			num = ((Queue.Count > 0) ? 7 : (ⴄႤ[30] - ⴄႤ[57]));
		}
	}

	public void ProcessMsgs(TcpServerClient client)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool flag = false;
		object locker = default(object);
		try
		{
			int num = 1;
			bool flag2 = default(bool);
			int num2 = default(int);
			object obj = default(object);
			IEnumerable enumerable3 = default(IEnumerable);
			IEquatable<string> equatable = default(IEquatable<string>);
			IEnumerable enumerable2 = default(IEnumerable);
			IEnumerable enumerable = default(IEnumerable);
			IComparable comparable = default(IComparable);
			IConvertible convertible = default(IConvertible);
			IEnumerable<char> enumerable4 = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(locker = client.Locker, ref flag, 905, 896);
					flag2 = true;
					num = 6;
					continue;
				case 14:
					num = (SetAnnDefault.Ⴍ(client.RxBuffer, ႨႨ.Ⴀ(14, 0, 1157904770), 597, 519) ? 33 : (ⴃႠ[160] - 12952));
					continue;
				case 27:
					num2 = ShowNodes.Ⴄ(client.RxBuffer, ႨႨ.Ⴀ(12, 6, 1157904772), 694, 649);
					num = 26;
					continue;
				case 26:
				case 28:
					num = ((num2 > -1) ? (ⴀႣ[23] - 53153) : 24);
					continue;
				case 24:
					client.RxBuffer = string.Empty;
					break;
				case 33:
				{
					string rxBuffer = client.RxBuffer;
					Array array = new char[1];
					((char[])array)[0] = '^';
					obj = ShowPrefix.Ⴃ(rxBuffer, (char[])array, 5, 977, 910);
					num = 9;
					continue;
				}
				case 9:
					num = ((((string[])obj).Length >= 5) ? 39 : 3);
					continue;
				case 3:
					break;
				case 39:
					enumerable3 = (obj as string[])[0];
					equatable = (obj as string[])[1];
					num = ⴅ[231];
					continue;
				case 40:
					enumerable2 = ((string[])obj)[2];
					enumerable = (obj as string[])[3];
					num = ⴀႳ[280] - 57521;
					continue;
				case 7:
				{
					int num3;
					if (!SkimmerValidSpot.Ⴈ(enumerable as string, 780, 888))
					{
						num3 = 16;
					}
					else
					{
						char num4 = ⴀ[488];
						TxNodeUserCmd.ႤႷ[43] = (char)((TxNodeUserCmd.ႤႷ[43] + IpLockoutCacheCfg.ႭႭ[26]) & 0x44);
						num3 = num4 - 62051;
					}
					num = num3;
					continue;
				}
				case 16:
					client.RxBuffer = string.Empty;
					Ⴍ.Warn(ReplyMail.Ⴅ(8, 5, 1217942113));
					break;
				case 31:
					num = ((CallBlockCacheCfg.Ⴜ((obj as string[])[4], 1005, 908) < ShowVersion.Ⴄ(enumerable as string, '\u0098', 'ª')) ? (ⴃႰ[72] - 45547) : 15);
					continue;
				case 15:
					comparable = SetTalkOutputHelp.Ⴍ((obj as string[])[4], 0, ShowVersion.Ⴄ((string)enumerable, 'ô', 'Æ'), 947, 992);
					num = 5;
					continue;
				case 5:
					client.RxBuffer = Clear.Ⴄ(client.RxBuffer, CallBlockCacheCfg.Ⴜ(enumerable3 as string, 476, 445) + CallBlockCacheCfg.Ⴜ(equatable as string, 800, 833) + CallBlockCacheCfg.Ⴜ((string)enumerable2, 674, 707) + CallBlockCacheCfg.Ⴜ((string)enumerable, 467, 434) + CallBlockCacheCfg.Ⴜ(comparable as string, 459, 426) + 4, '\u00b4', '\u009c');
					num = ⴀ[470] - 21319;
					continue;
				case 12:
					num = ((!ByeHelp.Ⴍ(equatable as string, ObjectManager.Instance.Ⴃ(), 806, 833)) ? 6 : (ⴄႤ[98] - 21));
					continue;
				case 19:
					num = (((convertible = (string)enumerable3) == null) ? 13 : (ⴍႤ[33] - 61821));
					continue;
				case 8:
					num = (ByeHelp.Ⴍ(convertible as string, SetStationQth.Ⴍ(null, 1687354580, 7, 5), 836, 803) ? 30 : 23);
					continue;
				case 23:
					num = (ByeHelp.Ⴍ((string)convertible, ShowSkimCtyHelp.Ⴍ(1216133028, 0, 'g'), 199, 160) ? 6 : (ⴐ[408] - 131));
					continue;
				case 21:
					num = (ByeHelp.Ⴍ(convertible as string, ႨႨ.Ⴀ(3, 5, 1157905261), 665, 766) ? 6 : 10);
					continue;
				case 10:
					num = 13;
					continue;
				case 30:
					enumerable4 = V4NodeParser.GetInstance.Parse(ObjectManager.Instance.Ⴃ(), (string)comparable);
					num = ((CallBlockCacheCfg.Ⴜ((string)enumerable4, 148, 245) >= 2) ? 4 : 11);
					continue;
				case 11:
					break;
				case 4:
					enumerable4 = SetTalkOutputHelp.Ⴍ((string)enumerable4, 0, CallBlockCacheCfg.Ⴜ((string)enumerable4, 107, 10) - 1, 646, 725);
					num = ⴍႤ[157] - 37361;
					continue;
				case 0:
					num = ((CallBlockCacheCfg.Ⴜ((string)enumerable4, 797, 892) != 0) ? (ⴀႨ[178] - 32237) : 18);
					continue;
				case 18:
					break;
				case 32:
					num = (SetAnnDefault.Ⴍ((string)enumerable4, ႨႨ.Ⴀ(9, 6, 1157904772), 733, 655) ? 22 : (ⴃႰ[72] - 45567));
					continue;
				case 17:
				case 38:
					num = ((!(enumerable4 as string).StartsWith(ႨႨ.Ⴀ(9, 2, 1157905617))) ? ⴀႼ[37] : 22);
					continue;
				case 22:
					client.OnRx((string)enumerable4);
					num = ⴃႥ[22] - 3445;
					continue;
				case 25:
					num = ((!((string)enumerable4 == SetStationClubHelp.Ⴍ(14, 5, 1747258082, null))) ? ⴐ[271] : 34);
					continue;
				case 34:
					((Arc4ServerClient)client).ToCall = (string)enumerable2;
					client.OnRx(ႨႨ.Ⴀ(14, 5, 1157904770) + (enumerable2 as string));
					num = ⴃႥ[333] - 50864;
					continue;
				case 36:
					Ⴍ.Warn(ShowSkimCtyHelp.Ⴍ(1216129043, 5, 'L'));
					client.RxBuffer = string.Empty;
					num = 6;
					continue;
				case 13:
					Ⴍ.Warn(ShowWxHelp.Ⴍ('«', 985805776, 6));
					client.RxBuffer = string.Empty;
					num = 6;
					continue;
				case 2:
				case 37:
					flag2 = false;
					num = ⴀႼ[63] - 68;
					continue;
				case 6:
					num = ((!flag2) ? (ⴀႼ[90] - 107) : (ⴀႳ[8] - 32463));
					continue;
				case 35:
					num = ((client.RxBuffer.Length > 10) ? 14 : 29);
					continue;
				case 29:
					break;
				}
				break;
			}
		}
		finally
		{
			int num5 = 6;
			while (true)
			{
				int num6;
				switch (num5)
				{
				default:
					num6 = ((!flag) ? 4 : 5);
					goto IL_0773;
				case 5:
					Monitor.Exit(locker);
					break;
				case 4:
					break;
				}
				break;
				IL_0773:
				num5 = num6;
			}
		}
		switch (1)
		{
		}
	}

	protected override TcpServerClient GetClientObject()
	{
		return new Arc4ServerClient();
	}
}
