using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
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

public sealed class Arc4Client : TcpClient
{
	private static readonly ILog Ⴈ;

	private static readonly object Ⴄ;

	private string m_Ⴅ = string.Empty;

	private Timer Ⴃ;

	public Arc4Client(IIoDeviceCfg ioDeviceCfg)
		: base(ioDeviceCfg)
	{
		MulticastDelegate multicastDelegate = new TimerCallback(Ⴅ);
		Ⴃ = new Timer(multicastDelegate as TimerCallback, this, 500, 250);
	}

	public override void OnRx(string rxMsg)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		bool flag = false;
		object ⴄ = default(object);
		try
		{
			ႨႥ.Ⴍ(ⴄ = Ⴄ, ref flag, 13, 4);
			this.m_Ⴅ = ShowUsersHelp.Ⴅ(this.m_Ⴅ, rxMsg, 786, 860);
		}
		finally
		{
			int num = 1;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!flag) ? (ⴀ[92] - 2235) : (ⴃႰ[179] - 27713));
					goto IL_0070;
				case 2:
				case 4:
					Monitor.Exit(ⴄ);
					break;
				case 3:
				case 5:
					break;
				}
				break;
				IL_0070:
				num = num2;
			}
		}
	}

	private void Ⴅ(object P_0)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 4;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((!base.IsConnected) ? 5 : (ⴃႰ[99] - 21869));
				break;
			case 0:
			case 3:
				ProcessRxMessages();
				return;
			case 5:
				return;
			}
			num = num2;
		}
	}

	public void ProcessRxMessages()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		try
		{
			switch (0)
			{
			default:
				{
					object obj = new List<string>();
					bool flag = false;
					object ⴄ = default(object);
					try
					{
						int num = 20;
						bool flag2 = default(bool);
						object obj2 = default(object);
						object obj5 = default(object);
						object obj6 = default(object);
						object obj4 = default(object);
						IConvertible convertible2 = default(IConvertible);
						IEquatable<string> equatable = default(IEquatable<string>);
						IConvertible convertible = default(IConvertible);
						IEnumerable enumerable = default(IEnumerable);
						while (true)
						{
							switch (num)
							{
							default:
								ႨႥ.Ⴍ(ⴄ = Ⴄ, ref flag, 48, 57);
								flag2 = true;
								num = 28;
								continue;
							case 19:
							case 23:
							{
								string ⴅ2 = this.m_Ⴅ;
								object obj3 = new char[1];
								(obj3 as char[])[0] = '^';
								obj2 = ShowPrefix.Ⴃ(ⴅ2, (char[])obj3, 5, 700, 739);
								num = ⴀႳ[303] - 34408;
								continue;
							}
							case 14:
								num = ((((string[])obj2).Length != 5) ? 28 : (ⴀႳ[93] - 46470));
								continue;
							case 18:
								obj5 = (obj2 as string[])[0];
								obj6 = ((string[])obj2)[1];
								num = ⴃႠ[25] - 907;
								continue;
							case 6:
								obj4 = (obj2 as string[])[2];
								convertible2 = ((string[])obj2)[3];
								num = 24;
								continue;
							case 24:
								num = ((CallBlockCacheCfg.Ⴜ((obj2 as string[])[4], 409, 504) < ShowVersion.Ⴄ((string)convertible2, '¤', '\u0096')) ? (ⴀႨ[195] - 50772) : (ⴃႥ[37] - ⴃႥ[37]));
								continue;
							case 0:
								equatable = SetTalkOutputHelp.Ⴍ(((string[])obj2)[4], 0, ShowVersion.Ⴄ(convertible2 as string, '\u0018', '*'), 600, 523);
								num = 5;
								continue;
							case 5:
								this.m_Ⴅ = Clear.Ⴄ(this.m_Ⴅ, CallBlockCacheCfg.Ⴜ((string)obj5, 233, 136) + CallBlockCacheCfg.Ⴜ((string)obj6, 629, 532) + CallBlockCacheCfg.Ⴜ(obj4 as string, 928, 961) + CallBlockCacheCfg.Ⴜ(convertible2 as string, 964, 933) + CallBlockCacheCfg.Ⴜ((string)equatable, 237, 140) + 4, 'ˉ', 'ˡ');
								num = 8;
								continue;
							case 8:
								num = ((!ByeHelp.Ⴍ((string)obj6, base.IoCfg.ConnectAs, 249, 158)) ? 28 : (ⴀႳ[284] - 5511));
								continue;
							case 22:
								num = (((convertible = obj5 as string) == null) ? 29 : 27);
								continue;
							case 27:
								num = (ByeHelp.Ⴍ(convertible as string, SetStationQth.Ⴍ(null, 1687354582, 5, 8), 552, 591) ? 2 : (ⴀႣ[189] - 62573));
								continue;
							case 17:
								num = (ByeHelp.Ⴍ((string)convertible, ShowSkimCtyHelp.Ⴍ(1216133030, 2, '®'), 479, 440) ? (ⴅ[363] / 5) : (ⴀႼ[54] - 71));
								continue;
							case 7:
								num = (ByeHelp.Ⴍ(convertible as string, ႨႨ.Ⴀ(12, 6, 1157905262), 867, 772) ? (ⴍႤ[305] - 10560) : (ⴃႠ[110] - 60956));
								continue;
							case 13:
								num = ⴃႠ[326] - 32464;
								continue;
							case 2:
								enumerable = V4NodeParser.GetInstance.Parse(base.IoCfg.ConnectAs, equatable as string);
								num = ((enumerable is string) ? 26 : (ⴍႤ[328] - 12743));
								continue;
							case 10:
								this.m_Ⴅ = string.Empty;
								Ⴈ.Warn(ႰႥ.Ⴅ(3, '²', 952621353));
								goto end_IL_0052;
							case 4:
							case 26:
								enumerable = SetTalkOutputHelp.Ⴍ((string)enumerable, 0, CallBlockCacheCfg.Ⴜ((string)enumerable, 397, 492) - 1, 942, 1021);
								num = 9;
								continue;
							case 9:
								num = (SetAnnDefault.Ⴍ(enumerable as string, ႨႨ.Ⴀ(5, 6, 1157904772), 793, 843) ? (ⴀႳ[278] - 16224) : 25);
								continue;
							case 25:
								num = ((!SetAnnDefault.Ⴍ(enumerable as string, ႨႨ.Ⴀ(4, 8, 1157905627), 997, 951)) ? (ⴃႰ[34] - 17507) : (ⴄႷ[68] - 14155));
								continue;
							case 16:
								(obj as List<string>).Add((string)enumerable);
								goto case 12;
							case 12:
								num = 28;
								continue;
							case 21:
								Ⴈ.Warn(SetTalkCount.Ⴗ(5, null, 1267016457, typeof(SetStationGridHelp)));
								this.m_Ⴅ = string.Empty;
								num = ⴍႭ[256] - 30573;
								continue;
							case 29:
								Ⴈ.Warn(ႨႨ.Ⴀ(12, 6, 1157905268));
								this.m_Ⴅ = string.Empty;
								num = 28;
								continue;
							case 3:
								flag2 = false;
								num = 28;
								continue;
							case 28:
								num = (flag2 ? 1 : (ⴃႰ[80] - 24188));
								continue;
							case 1:
								num = ((this.m_Ⴅ.Length > 10) ? 19 : 15);
								continue;
							case 15:
								break;
							}
							break;
						}
					}
					finally
					{
						int num2 = 1;
						while (true)
						{
							int num3;
							switch (num2)
							{
							default:
								num3 = (flag ? 3 : 0);
								goto IL_061d;
							case 3:
								Monitor.Exit(ⴄ);
								break;
							case 0:
							case 2:
								break;
							}
							break;
							IL_061d:
							num2 = num3;
						}
					}
					switch (3)
					{
					default:
					{
						List<string>.Enumerator enumerator = ((List<string>)obj).GetEnumerator();
						try
						{
							int num4 = 5;
							while (true)
							{
								switch (num4)
								{
								default:
									num4 = 7;
									continue;
								case 0:
								case 2:
								{
									object current = enumerator.Current;
									base.OnRx(current as string);
									break;
								}
								case 4:
								case 7:
									break;
								case 1:
								case 3:
									goto end_IL_065a;
								}
								num4 = ((!enumerator.MoveNext()) ? (ⴍႤ[171] - 24352) : 0);
								continue;
								end_IL_065a:
								break;
							}
						}
						finally
						{
							switch (1)
							{
							default:
								((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
								break;
							case 3:
								break;
							}
						}
						switch (1)
						{
						}
						break;
					}
					}
					break;
				}
				end_IL_0052:
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴈ.Warn(ShowWxHelp.Ⴍ('Í', 985806073, 2) + (ex as Exception).Message);
			this.m_Ⴅ = string.Empty;
		}
		switch (3)
		{
		}
	}

	public override bool Send(string msg)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		Array array2 = default(Array);
		object obj2 = default(object);
		Array array = default(Array);
		object obj = default(object);
		while (true)
		{
			int num = (SetAnnDefault.Ⴍ(msg, ႰႥ.Ⴅ(4, '\u0006', 952621538), 352, 306) ? 8 : 10);
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
				case 10:
					num = ((!SetAnnDefault.Ⴍ(msg, ShowSkimCtyHelp.Ⴍ(1216133024, 4, '\0'), 989, 911)) ? ⴅ[145] : 8);
					continue;
				case 8:
				{
					bool result = base.Send(msg);
					ShowQrzHelp.ႤႤ[292] = (byte)((ShowQrzHelp.ႤႤ[292] - ShowQrzHelp.ႤႤ[511]) & 0xD9);
					return result;
				}
				case 7:
					array2 = new string[5];
					((string[])array2)[0] = ႰႥ.Ⴅ(7, '\u008c', 952621537);
					num = 14;
					continue;
				case 14:
					((string[])array2)[1] = base.IoCfg.ConnectTo;
					((string[])array2)[2] = SetStationQth.Ⴍ(null, 1687351533, 2, 24);
					num = ⴀႨ[60] - 55453;
					continue;
				case 6:
					(array2 as string[])[3] = base.IoCfg.ConnectAs;
					((string[])array2)[4] = SetStationQth.Ⴍ(null, 1687351527, 8, 13);
					num = 11;
					continue;
				case 11:
					obj = ShowWwv.Ⴈ(array2 as string[], 'ϱ', 921);
					goto case 2;
				case 2:
					obj2 = obj as string;
					num = ⴐ[358] - 134;
					continue;
				case 1:
					array = new object[4];
					(array as object[])[0] = obj2;
					((object[])array)[1] = CallBlockCacheCfg.Ⴜ(msg, 876, 781);
					num = ⴍႤ[252] - 52528;
					continue;
				case 5:
					((object[])array)[2] = SetStationQth.Ⴍ(null, 1687351532, 3, 27);
					goto case 13;
				case 13:
					num = 9;
					continue;
				case 9:
					(array as object[])[3] = V4NodeParser.GetInstance.Parse(base.IoCfg.ConnectTo, msg);
					num = ⴍႭ[39] - ⴍႭ[308];
					continue;
				case 12:
				{
					obj = string.Concat(array as object[]);
					object bytes = Encoding.ASCII.GetBytes(obj as string);
					return Send(bytes as byte[]);
				}
				}
				break;
			}
		}
	}

	static Arc4Client()
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				Ⴄ = new object();
				return;
			case 2:
				return;
			}
			Ⴈ = SkimmerValidSpot.Ⴐ(ReplyMailHelp.Ⴄ(4, null, 1057164333, 3), 278, 267);
			num = 4;
		}
	}
}
