using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using ArcEngine;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArxWebService;
using ArcInterfaces;
using ArcInterfaces.Io;
using ArcInterfaces.Ui;
using ArcShared.ArcIo.Tcp;
using ArcShared.ArcUtils;
using log4net;

namespace Ⴈ;

internal sealed class ႷႭ : TcpClient, IIoServer
{
	private static readonly ILog m_Ⴍ;

	private static readonly object m_Ⴈ;

	private OnIoServerConnectEventHandler m_Ⴐ;

	private string m_Ⴄ;

	private ႷႰ.Ⴄ m_Ⴀ = new ႷႰ.Ⴄ();

	[SpecialName]
	public void add_OnConnectEvent(OnIoServerConnectEventHandler P_0)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 1;
		object obj = default(object);
		object obj2 = default(object);
		MulticastDelegate multicastDelegate = default(MulticastDelegate);
		while (true)
		{
			switch (num)
			{
			default:
				obj = this.m_Ⴐ;
				num = ⴀ[48] - ⴀ[48];
				break;
			case 0:
				obj2 = obj as OnIoServerConnectEventHandler;
				goto case 3;
			case 3:
				multicastDelegate = (OnIoServerConnectEventHandler)Clear.Ⴗ((Delegate)(OnIoServerConnectEventHandler)obj2, (Delegate)P_0, 328, 335);
				goto case 2;
			case 2:
				num = 5;
				break;
			case 5:
			{
				obj = Interlocked.CompareExchange(ref this.m_Ⴐ, (OnIoServerConnectEventHandler)multicastDelegate, obj2 as OnIoServerConnectEventHandler);
				int num2;
				if ((object)(OnIoServerConnectEventHandler)obj == (OnIoServerConnectEventHandler)obj2)
				{
					num2 = ⴀႼ[33] - 3;
				}
				else
				{
					int num3 = ⴍႤ[399];
					int num4 = ⴍႤ[399];
					SetTalkCountHelp.Ⴅ[159] = (byte)((SetTalkCountHelp.Ⴅ[159] * SetTalkCountHelp.Ⴅ[155]) & 0x24);
					num2 = num3 - num4;
				}
				num = num2;
				break;
			}
			case 4:
			case 6:
				return;
			}
		}
	}

	[SpecialName]
	public void remove_OnConnectEvent(OnIoServerConnectEventHandler P_0)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 3;
		MulticastDelegate multicastDelegate = default(MulticastDelegate);
		object obj = default(object);
		MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
		while (true)
		{
			switch (num)
			{
			default:
				multicastDelegate = this.m_Ⴐ;
				num = ⴀႼ[113];
				continue;
			case 2:
				obj = multicastDelegate as OnIoServerConnectEventHandler;
				multicastDelegate2 = (OnIoServerConnectEventHandler)ReadMail.Ⴈ((Delegate)(OnIoServerConnectEventHandler)obj, (Delegate)P_0, '\u0311', '\u035f');
				goto case 4;
			case 4:
				num = ⴄႭ[125] / 8;
				continue;
			case 6:
				multicastDelegate = Interlocked.CompareExchange(ref this.m_Ⴐ, multicastDelegate2 as OnIoServerConnectEventHandler, obj as OnIoServerConnectEventHandler);
				break;
			case 5:
				break;
			case 0:
				return;
			}
			num = (((object)(multicastDelegate as OnIoServerConnectEventHandler) != obj as OnIoServerConnectEventHandler) ? 2 : 0);
		}
	}

	[SpecialName]
	public IIoDeviceCfg get_IoDeviceCfg()
	{
		IIoDeviceCfg ⴀ = this.m_Ⴀ.Ⴀ;
		ShowWwvOptionsHelp.ႣႥ[372] = (char)((ShowWwvOptionsHelp.ႣႥ[372] + ShowWwvOptionsHelp.ႣႥ[382]) & 0x9F);
		return ⴀ;
	}

	[SpecialName]
	public void set_IoDeviceCfg(IIoDeviceCfg P_0)
	{
		this.m_Ⴀ.Ⴀ = P_0 as IIoDeviceCfg;
	}

	[SpecialName]
	public string get_EofChar()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		return this.m_Ⴄ;
	}

	[SpecialName]
	public void set_EofChar(string P_0)
	{
		this.m_Ⴄ = P_0;
	}

	internal ႷႭ()
	{
		IEnumerable empty = string.Empty;
		this.m_Ⴀ.Ⴈ = (string)empty;
		base._002Ector();
	}

	internal ႷႭ(IIoDeviceCfg P_0)
	{
		IComparable empty = string.Empty;
		this.m_Ⴀ.Ⴈ = empty as string;
		base._002Ector(P_0);
		set_IoDeviceCfg(P_0);
		base.OnConnectEvent += Ⴄ;
		base.OnRxEvent += Ⴗ;
	}

	public void Start()
	{
		this.m_Ⴐ = null;
		base.Connect();
	}

	public void Stop()
	{
		Disconnect();
	}

	private void Ⴄ(string P_0)
	{
		base.Send(Ⴓ());
	}

	private void Ⴗ(string P_0)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		try
		{
			switch (0)
			{
			default:
			{
				bool flag = false;
				object ⴈ = default(object);
				try
				{
					int num = 6;
					object obj = default(object);
					while (true)
					{
						switch (num)
						{
						default:
						{
							ႨႥ.Ⴍ(ⴈ = ႷႭ.m_Ⴈ, ref flag, 798, 791);
							IConvertible convertible = ShowUsersHelp.Ⴅ(this.m_Ⴀ.Ⴈ, P_0, 109, 35);
							this.m_Ⴀ.Ⴈ = (string)convertible;
							num = 7;
							continue;
						}
						case 4:
						case 7:
							obj = Ⴅ();
							num = 0;
							continue;
						case 2:
							Ⴀ(obj as string);
							obj = Ⴅ();
							num = 0;
							continue;
						case 0:
							num = ((!ႰႨ.ႥႥ(obj as string, '\u0016', '0')) ? 2 : 8);
							continue;
						case 8:
							break;
						}
						break;
					}
				}
				finally
				{
					int num2 = 5;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = ((!flag) ? 4 : (ⴄႷ[50] - 56636));
							goto IL_0114;
						case 3:
							DxCmdMsgExt.ႨႠ(ⴈ, 'Ǝ', 491);
							break;
						case 1:
						case 4:
						case 6:
							break;
						}
						break;
						IL_0114:
						num2 = num3;
					}
				}
				switch (2)
				{
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			ႷႭ.m_Ⴍ.Error((ex as Exception).Message);
		}
		switch (0)
		{
		}
	}

	private string Ⴅ()
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num2 = default(int);
		IEnumerable<char> ⴈ = default(IEnumerable<char>);
		object obj = default(object);
		while (true)
		{
			Array array = ႰႭ.Ⴀ(ShowUptime.Ⴗ(326, 264), this.m_Ⴀ.Ⴈ, 441, 493);
			int num = ⴄႭ[289] - 47;
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
					num = ((CallBlockCacheCfg.Ⴜ(this.m_Ⴀ.Ⴈ, 58, 91) <= 35) ? ⴐ[21] : (ⴃႥ[41] - 51144));
					continue;
				case 13:
					num2 = 36 + ((byte[])array)[28];
					num = ((CallBlockCacheCfg.Ⴜ(this.m_Ⴀ.Ⴈ, 246, 151) != num2) ? 4 : (ⴀ[210] - 9846));
					continue;
				case 9:
				{
					ⴈ = this.m_Ⴀ.Ⴈ;
					IComparable empty = string.Empty;
					this.m_Ⴀ.Ⴈ = (string)empty;
					num = 11;
					continue;
				}
				case 11:
					return ⴈ as string;
				case 4:
					num = ((CallBlockCacheCfg.Ⴜ(this.m_Ⴀ.Ⴈ, 309, 340) < num2) ? (ⴀႳ[2] - 30376) : 8);
					continue;
				case 8:
					obj = SetTalkOutputHelp.Ⴍ(this.m_Ⴀ.Ⴈ, 0, num2, 162, 241);
					goto case 7;
				case 7:
					num = 0;
					continue;
				case 0:
				case 5:
				{
					IConvertible convertible = this.m_Ⴀ.Ⴈ.Substring(num2);
					this.m_Ⴀ.Ⴈ = (string)convertible;
					num = 12;
					continue;
				}
				case 12:
					return obj as string;
				case 3:
				case 6:
					return string.Empty;
				}
				break;
			}
		}
	}

	private void Ⴀ(string P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 3;
		char c2 = default(char);
		char c = default(char);
		while (true)
		{
			ILog ⴍ;
			Array array;
			ILog ⴍ2;
			object obj;
			switch (num)
			{
			default:
				c2 = SetStationNeedsHelp.Ⴃ(P_0, 4, 85, 54);
				goto case 2;
			case 2:
				c = c2;
				goto case 1;
			case 1:
			case 5:
				if (c <= 'R')
				{
					num = 0;
					continue;
				}
				while (true)
				{
					int num2 = ((c == 'X') ? (ⴍႤ[391] - 44945) : 12);
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 14:
							break;
						case 12:
							num2 = ((c == 'd') ? 4 : 5);
							continue;
						case 5:
						case 7:
							return;
						case 2:
							goto end_IL_00de;
						case 9:
							goto IL_010e;
						case 8:
							ႷႭ.m_Ⴍ.Info(SetWxCountHelp.Ⴗ((object)get_IoDeviceCfg(), (object)ႰႥ.Ⴅ(5, 'm', 952620028), 560, (short)587));
							num2 = ⴀႣ[383] - 35221;
							continue;
						case 0:
							base.Send(Ⴄ());
							return;
						case 11:
							return;
						case 10:
							goto IL_022d;
						case 1:
							goto IL_029e;
						case 6:
							goto end_IL_001a;
						case 4:
							Ⴃ(P_0);
							return;
						case 3:
							return;
						}
						break;
					}
					continue;
					end_IL_00de:
					break;
				}
				goto IL_0107;
			case 0:
				switch (c)
				{
				case 'G':
					goto IL_022d;
				case 'C':
					goto IL_029e;
				case 'D':
					goto end_IL_001a;
				case 'E':
				case 'F':
					return;
				}
				num = 4;
				continue;
			case 4:
				if (c != 'R')
				{
					num = ⴍႭ[12] - 46118;
					continue;
				}
				goto IL_0107;
			case 6:
				return;
				IL_029e:
				Ⴅ(P_0);
				return;
				IL_022d:
				ⴍ = ႷႭ.m_Ⴍ;
				array = new object[4];
				(array as object[])[0] = get_IoDeviceCfg();
				((object[])array)[1] = ReplyMail.Ⴅ(7, 11, 1217944219);
				(array as object[])[2] = SetStationNeedsHelp.Ⴃ(P_0, 36, 91, 56);
				((object[])array)[3] = ShowWxHelp.Ⴍ('Ê', 985807614, 7);
				ⴍ.Info(string.Concat((object[])array));
				return;
				IL_0107:
				Ⴓ(P_0);
				goto IL_010e;
				IL_010e:
				ⴍ2 = ႷႭ.m_Ⴍ;
				obj = new object[5];
				((object[])obj)[0] = get_IoDeviceCfg();
				(obj as object[])[1] = ShowWxHelp.Ⴍ('½', 985807503, 0);
				(obj as object[])[2] = (byte)SetStationNeedsHelp.Ⴃ(P_0, 36, 663, 756) + 256 * (byte)SetStationNeedsHelp.Ⴃ(P_0, 37, 300, 335);
				(obj as object[])[3] = SetStationClubHelp.Ⴍ(6, 1, 1747257860, null);
				((object[])obj)[4] = (byte)SetStationNeedsHelp.Ⴃ(P_0, 40, 217, 186) + 256 * (byte)SetStationNeedsHelp.Ⴃ(P_0, 41, 28, 127);
				ⴍ2.Info(SetDxDefaultHelp.Ⴍ((object[])obj, 'ã', 138));
				return;
				end_IL_001a:
				break;
			}
			break;
		}
		Ⴐ(P_0);
	}

	private void Ⴃ(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 7;
		object instance = default(object);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		IConvertible convertible = default(IConvertible);
		object obj = default(object);
		int num2 = default(int);
		BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
		while (true)
		{
			switch (num)
			{
			default:
				instance = ObjectManager.Instance;
				enumerable = SetTalkOutputHelp.Ⴍ(P_0, 0, 4, 503, 420);
				num = ⴃႥ[83] - 54500;
				break;
			case 12:
				convertible = Ⴜ(SetTalkOutputHelp.Ⴍ(P_0, 8, 10, 568, 619));
				goto case 6;
			case 6:
				obj = Ⴜ(SetTalkOutputHelp.Ⴍ(P_0, 18, 10, 641, 722));
				num = 4;
				break;
			case 1:
			case 4:
			{
				ICloneable cloneable = Ⴜ(SetTalkOutputHelp.Ⴍ(P_0, 28, 4, 252, 175));
				num2 = SetStationNeedsHelp.Ⴃ(cloneable as string, 0, 433, 466);
				num = ⴀႨ[111] - 4748;
				break;
			}
			case 8:
				Ⴜ(SetTalkOutputHelp.Ⴍ(P_0, 36, num2, 886, 805));
				goto case 5;
			case 5:
				num = ((!ByeHelp.Ⴍ(obj as string, ((ObjectManager)instance).Ⴓ().Call, 61, 90)) ? (ⴅ[102] - ⴅ[319]) : 2);
				break;
			case 2:
				baseXmlSerializer = ((ObjectManager)instance).Ⴓ().ႣႷ(convertible as string);
				num = ((!(baseXmlSerializer is ArcConnect)) ? (ⴃႠ[165] - 47286) : (ⴄႭ[498] - 52));
				break;
			case 11:
				num = (((instance as ObjectManager).Ⴈ() == null) ? (ⴄႷ[100] - 20024) : (ⴀႣ[348] - 32282));
				break;
			case 13:
				((ObjectManager)instance).Ⴈ().DeleteLocalConnect((baseXmlSerializer as ArcConnect).Id);
				goto case 3;
			case 3:
				new LogEntry(get_IoDeviceCfg(), convertible as string, ႨႨ.Ⴀ(13, 1, 1157903344));
				num = ⴄႷ[33] - 18060;
				break;
			case 10:
				ႷႭ.m_Ⴍ.Info(CallBlockCacheCfg.Ⴅ(null, 8, 62055652, null) + (string)convertible);
				num = 0;
				break;
			case 0:
				((ObjectManager)instance).Ⴓ().ႣႳ(convertible as string);
				Ⴅ((string)convertible, enumerable as string);
				return;
			case 9:
				return;
			}
		}
	}

	private void Ⴐ(string P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 1;
		object instance = default(object);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		IComparable comparable = default(IComparable);
		IEnumerable enumerable3 = default(IEnumerable);
		int num2 = default(int);
		IEnumerable<char> enumerable2 = default(IEnumerable<char>);
		while (true)
		{
			switch (num)
			{
			default:
				instance = ObjectManager.Instance;
				enumerable = SetTalkOutputHelp.Ⴍ(P_0, 0, 4, 54, 101);
				num = 0;
				break;
			case 0:
				comparable = Ⴜ(SetTalkOutputHelp.Ⴍ(P_0, 8, 10, 768, 851));
				enumerable3 = Ⴜ(SetTalkOutputHelp.Ⴍ(P_0, 18, 10, 847, 796));
				num = 3;
				break;
			case 3:
			{
				IComparable comparable2 = Ⴜ(SetTalkOutputHelp.Ⴍ(P_0, 28, 4, 685, 766));
				num2 = SetStationNeedsHelp.Ⴃ((string)comparable2, 0, 150, 245);
				num = 6;
				break;
			}
			case 6:
				enumerable2 = Ⴜ(SetTalkOutputHelp.Ⴍ(P_0, 36, num2, 127, 44));
				goto case 2;
			case 2:
			case 8:
				if ((string)enumerable3 == (instance as ObjectManager).Ⴓ().Call)
				{
					num = 4;
					break;
				}
				return;
			case 4:
			case 5:
			{
				BaseXmlSerializer baseXmlSerializer = (instance as ObjectManager).Ⴓ().ႣႷ((string)comparable);
				if (!(baseXmlSerializer is ArcConnect))
				{
					num = ⴃႠ[132] - 10525;
					break;
				}
				((ArcConnect)baseXmlSerializer).OnRx(enumerable2 as string);
				return;
			}
			case 7:
				Ⴅ(comparable as string, (string)enumerable);
				return;
			}
		}
	}

	private void Ⴅ(string P_0, string P_1)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 2;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			switch (num)
			{
			default:
				enumerable = string.Empty;
				enumerable = P_1;
				goto case 3;
			case 3:
				enumerable = ShowUsersHelp.Ⴅ(enumerable as string, CallBlockCacheCfg.Ⴅ(null, 7, 62055557, null), 849, 799);
				num = ⴀ[346] - 40260;
				break;
			case 4:
				enumerable = ShowUsersHelp.Ⴅ((string)enumerable, PublishInfo.Ⴄ(ObjectManager.Instance.Ⴓ().Call, 10, '\0', 901, 934), 511, 433);
				goto case 8;
			case 8:
				num = ⴄႤ[148];
				break;
			case 1:
				enumerable = ShowUsersHelp.Ⴅ(enumerable as string, PublishInfo.Ⴄ(P_0, 10, '\0', 369, 338), 489, 423);
				num = ⴐ[254];
				break;
			case 0:
				enumerable = ShowUsersHelp.Ⴅ((string)enumerable, SetStationQth.Ⴍ(null, 1687353040, 4, 20), 1009, 959);
				num = 7;
				break;
			case 7:
				enumerable = (enumerable as string) + SetStationQth.Ⴍ(null, 1687353052, 8, 0);
				num = 5;
				break;
			case 5:
				base.Send(enumerable as string);
				return;
			case 6:
				return;
			}
		}
	}

	private void Ⴓ(string P_0)
	{
		int num = 3;
		object call = default(object);
		while (true)
		{
			switch (num)
			{
			case 1:
				base.Send(Ⴍ(call as string));
				return;
			case 0:
			case 2:
			case 4:
				return;
			}
			call = ObjectManager.Instance.Ⴓ().Call;
			base.Send(Ⴈ(call as string));
			num = 1;
		}
	}

	private void Ⴅ(string P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 16;
		object instance = default(object);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		object obj = default(object);
		object obj3 = default(object);
		int num2 = default(int);
		BaseXmlSerializer baseXmlSerializer2 = default(BaseXmlSerializer);
		BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
		object obj4 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				instance = ObjectManager.Instance;
				enumerable = SetTalkOutputHelp.Ⴍ(P_0, 0, 4, 1019, 936);
				num = 4;
				break;
			case 4:
				obj = Ⴜ(SetTalkOutputHelp.Ⴍ(P_0, 8, 10, 846, 797));
				obj3 = Ⴜ(SetTalkOutputHelp.Ⴍ(P_0, 18, 10, 576, 531));
				num = 14;
				break;
			case 14:
			{
				object obj2 = Ⴜ(SetTalkOutputHelp.Ⴍ(P_0, 28, 4, 543, 588));
				num2 = SetStationNeedsHelp.Ⴃ(obj2 as string, 0, 690, 721);
				num = ⴄႤ[451] - 146;
				break;
			}
			case 6:
				Ⴜ(SetTalkOutputHelp.Ⴍ(P_0, 36, num2, 187, 232));
				num = (ByeHelp.Ⴍ(obj3 as string, (instance as ObjectManager).Ⴓ().Call, 438, 465) ? 1 : 13);
				break;
			case 1:
				(instance as ObjectManager).Ⴓ().ႣႳ((string)obj);
				baseXmlSerializer2 = new ArcConnect(instance as ObjectManager, (string)obj);
				num = ⴃႥ[32] - 37164;
				break;
			case 11:
				(baseXmlSerializer2 as ArcConnect).Ⴓ((instance as ObjectManager).Ⴓ());
				goto case 2;
			case 2:
				((ArcConnect)baseXmlSerializer2).ConnectState = ConnectStateType.AgwBpqUser;
				num = 8;
				break;
			case 8:
				((ArcConnect)baseXmlSerializer2).Ⴀ(true);
				(baseXmlSerializer2 as ArcConnect).Ⴅ(true);
				(baseXmlSerializer2 as ArcConnect).Io = this;
				num = ⴍႤ[212] - 34339;
				break;
			case 0:
				(baseXmlSerializer2 as ArcConnect).Ⴍ(SetStationClubHelp.Ⴍ(8, 2, 1747258085, null));
				baseXmlSerializer = baseXmlSerializer2 as ArcConnect;
				num = ⴄႤ[135];
				break;
			case 5:
				((ArcConnect)baseXmlSerializer).Cfg = ((ObjectManager)instance).Ⴀ().ႨႣ().Ⴃ(baseXmlSerializer as ArcConnect);
				goto case 20;
			case 20:
				num = 10;
				break;
			case 10:
				obj4 = new LogEntry(((ArcConnect)baseXmlSerializer).Io.IoCfg, (string)obj3, ShowSkimCtyHelp.Ⴍ(1216135065, 6, '²'));
				num = 3;
				break;
			case 3:
				ႷႭ.m_Ⴍ.Info(ShowUsersHelp.Ⴅ(SetTalkCount.Ⴗ(2, null, 1267020089, typeof(SetStationLoginCmds)), (string)obj3, 165, 235));
				num = 7;
				break;
			case 7:
				ObjectManager.Instance.Ⴀ().Ⴐ().Add(obj4 as LogEntry);
				WsArxNode.Ⴍ((ArcConnect)baseXmlSerializer);
				((ObjectManager)instance).Ⴓ().Ⴜ(baseXmlSerializer as ArcConnect);
				num = 9;
				break;
			case 9:
				num = ((((ObjectManager)instance).Ⴈ() == null) ? (ⴃႥ[203] - 52424) : (ⴍႭ[6] - 37940));
				break;
			case 19:
				(instance as ObjectManager).Ⴈ().AddLocalConnect(new LocalConnect(((ArcConnect)baseXmlSerializer).Call, (baseXmlSerializer as ArcConnect).Id, UiConnectType.AgwBpqIn));
				goto case 12;
			case 12:
			case 17:
				((ArcConnect)baseXmlSerializer).Io = new ႷႥ(this, Ⴃ((string)enumerable, (string)obj));
				num = ⴍႤ[386] - 53427;
				break;
			case 18:
				((ArcConnect)baseXmlSerializer).Io.IoCfg = get_IoDeviceCfg();
				Login.Ⴃ(baseXmlSerializer as ArcConnect, (baseXmlSerializer as ArcConnect).Io.IoCfg);
				num = ⴐ[21] * 5;
				break;
			case 15:
				ႷႭ.m_Ⴍ.Info(ReplyMailHelp.Ⴄ(21, null, 1057162286, 0) + (obj as string));
				return;
			case 13:
				return;
			}
		}
	}

	private string Ⴃ(string P_0, string P_1)
	{
		while (true)
		{
			IComparable<string> empty = string.Empty;
			while (true)
			{
				IL_0034:
				empty = P_0;
				empty = ShowUsersHelp.Ⴅ(empty as string, SetStationQth.Ⴍ(null, 1687353033, 4, 3), 200, 134);
				while (true)
				{
					IL_0059:
					int num = 4;
					while (true)
					{
						switch (num)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							num = 1;
							continue;
						case 1:
						case 2:
							break;
						case 5:
							goto IL_0034;
						case 3:
							goto IL_0059;
						case 4:
							empty = ShowUsersHelp.Ⴅ(empty as string, PublishInfo.Ⴄ(ObjectManager.Instance.Ⴓ().Call, 10, '\0', 498, 465), 915, 989);
							num = 6;
							continue;
						case 6:
							empty = (string)empty + P_1.PadRight(10, '\0');
							return empty as string;
						}
						break;
					}
					break;
				}
				break;
			}
		}
	}

	internal string Ⴓ()
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		while (true)
		{
			IConvertible empty = string.Empty;
			empty = SetStationQth.Ⴍ(null, 1687353041, 5, 3);
			empty = ShowUsersHelp.Ⴅ((string)empty, ShowWxHelp.Ⴍ('¾', 985807578, 3), 1018, 948);
			int num = ⴄႭ[134];
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
				case 5:
				case 8:
					empty = ShowUsersHelp.Ⴅ(empty as string, SetStationQth.Ⴍ(null, 1687353026, 4, 7), 259, 333);
					num = ⴄႤ[251] / 7;
					continue;
				case 9:
					empty = ShowUsersHelp.Ⴅ(empty as string, SetStationQth.Ⴍ(null, 1687353029, 3, 22), 701, 755);
					num = ⴀႼ[80] * 3;
					continue;
				case 0:
					empty = ShowUsersHelp.Ⴅ((string)empty, SetStationQth.Ⴍ(null, 1687353045, 1, 18), 349, 275);
					goto case 3;
				case 3:
					num = ⴄႷ[44] - 49666;
					continue;
				case 2:
					empty = (string)empty + SetStationQth.Ⴍ(null, 1687353042, 6, 6);
					num = ⴀ[234] - 30305;
					continue;
				case 1:
					return empty as string;
				}
				break;
			}
		}
	}

	internal string Ⴈ(string P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			IComparable comparable = P_0;
			comparable = PublishInfo.Ⴄ((string)comparable, 10, '\0', 578, 609);
			int num = ⴐ[316] - 22;
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
				case 9:
					convertible = string.Empty;
					goto case 0;
				case 0:
					convertible = SetStationQth.Ⴍ(null, 1687353041, 5, 28);
					convertible = ShowUsersHelp.Ⴅ(convertible as string, ShowSkimCtyHelp.Ⴍ(1216134726, 7, '`'), 701, 755);
					num = ⴐ[407] - 110;
					continue;
				case 8:
					convertible = ShowUsersHelp.Ⴅ((string)convertible, comparable as string, 691, 765);
					convertible = ShowUsersHelp.Ⴅ((string)convertible, SetStationQth.Ⴍ(null, 1687353025, 7, 19), 934, 1000);
					num = 7;
					continue;
				case 7:
					convertible = ShowUsersHelp.Ⴅ((string)convertible, SetStationQth.Ⴍ(null, 1687353045, 1, 18), 436, 506);
					goto case 5;
				case 5:
					num = 4;
					continue;
				case 4:
					convertible = (string)convertible + SetStationQth.Ⴍ(null, 1687353052, 8, 25);
					goto case 1;
				case 1:
					num = 6;
					continue;
				case 6:
					return (string)convertible;
				}
				break;
			}
		}
	}

	internal string Ⴍ(string P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		IConvertible convertible2 = default(IConvertible);
		while (true)
		{
			IConvertible convertible = P_0;
			convertible = PublishInfo.Ⴄ(convertible as string, 10, '\0', 468, 503);
			int num = ⴄႷ[11] - 38826;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႨ[220] - 56036;
					continue;
				case 6:
					break;
				case 3:
					convertible2 = string.Empty;
					goto case 2;
				case 2:
					convertible2 = SetStationQth.Ⴍ(null, 1687353041, 5, 3);
					goto case 1;
				case 1:
					convertible2 = ShowUsersHelp.Ⴅ((string)convertible2, ReplyMailHelp.Ⴄ(22, null, 1057164227, 3), 707, 653);
					num = 9;
					continue;
				case 9:
					convertible2 = ShowUsersHelp.Ⴅ((string)convertible2, convertible as string, 748, 674);
					convertible2 = ShowUsersHelp.Ⴅ(convertible2 as string, SetStationQth.Ⴍ(null, 1687353027, 5, 10), 725, 667);
					num = ⴀႼ[124] - 16;
					continue;
				case 7:
					convertible2 = ShowUsersHelp.Ⴅ(convertible2 as string, SetStationQth.Ⴍ(null, 1687353040, 4, 8), 856, 790);
					goto case 5;
				case 5:
					num = 0;
					continue;
				case 0:
				{
					convertible2 = (convertible2 as string) + SetStationQth.Ⴍ(null, 1687353047, 3, 29);
					char num2 = ⴃႰ[101];
					ShowQrzHelp.ႤႤ[282] = SetAnnMode.ႤႭ[88];
					num = num2 - 32276;
					continue;
				}
				case 8:
					return (string)convertible2;
				}
				break;
			}
		}
	}

	private string Ⴄ()
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		while (true)
		{
			IEnumerable<char> empty = string.Empty;
			empty = SetStationQth.Ⴍ(null, 1687353052, 8, 24);
			empty = ShowUsersHelp.Ⴅ((string)empty, ReplyMailHelp.Ⴄ(23, null, 1057164255, 0), 543, 593);
			int num = ⴄႷ[91] - 7813;
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
				case 3:
				case 8:
					empty = ShowUsersHelp.Ⴅ((string)empty, SetStationQth.Ⴍ(null, 1687353029, 3, 14), 866, 812);
					num = ⴄႭ[246];
					continue;
				case 2:
					empty = ShowUsersHelp.Ⴅ((string)empty, SetStationQth.Ⴍ(null, 1687353029, 3, 22), 260, 330);
					num = ⴍႭ[238] - 48049;
					continue;
				case 7:
					empty = ShowUsersHelp.Ⴅ((string)empty, SetStationQth.Ⴍ(null, 1687353040, 4, 24), 259, 333);
					goto case 4;
				case 4:
					num = 1;
					continue;
				case 1:
					empty = (string)empty + SetStationQth.Ⴍ(null, 1687353040, 4, 13);
					num = ⴅ[6];
					continue;
				case 0:
					return empty as string;
				}
				break;
			}
		}
	}

	private static string Ⴜ(string P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num2 = default(int);
		while (true)
		{
			P_0 = ShowContestStationHelp.Ⴅ(P_0, ReplyMail.Ⴅ(2, 1, 1217944253), string.Empty, 785, '\u0349');
			int num = ⴀႣ[332] - 29262;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႤ[148];
					continue;
				case 1:
					break;
				case 2:
				case 7:
					num2 = Clear.Ⴀ(P_0, '\0', 'Φ', 992);
					goto case 3;
				case 3:
					num = ((num2 <= 0) ? (ⴄႭ[240] - ⴄႭ[51]) : (ⴀႣ[373] - 13253));
					continue;
				case 0:
				case 6:
					return P_0.Substring(0, num2);
				case 4:
				{
					string result = P_0;
					DirectoryBulletin.ႠႨ[149] = (DirectoryBulletin.ႠႨ[149] ^ DirectoryBulletin.ႠႨ[46]) & 0x89;
					return result;
				}
				}
				break;
			}
		}
	}

	static ႷႭ()
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 0:
				ႷႭ.m_Ⴈ = new object();
				return;
			case 1:
			case 3:
				return;
			}
			ႷႭ.m_Ⴍ = SkimmerValidSpot.Ⴐ(ReplyMailHelp.Ⴄ(26, null, 1057164254, 8), 721, 716);
			num = ⴍႭ[89] - ⴍႭ[89];
		}
	}
}
