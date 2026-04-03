using System;
using System.Collections.Generic;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcDatabase;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcIo.Arx;
using ArcEngine.ArcIo.Mirc;
using ArcEngine.ArcIo.Pcxx;
using ArcEngine.ArcIo.Telnet;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces;
using ArcInterfaces.Io;
using ArcShared;
using ArcShared.ArcIo.Arx;
using ArcShared.ArcIo.Pcxx;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcIo;

public sealed class IoDevices
{
	private static readonly ILog Ⴃ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216133542, 6, '¤'), 411, 390);

	private readonly ObjectManager m_Ⴐ;

	internal List<TelnetServerIo> Ⴄ;

	internal List<PcxxServerIo> Ⴓ;

	internal List<Arc4ServerIo> Ⴈ;

	internal List<ArxServerIo> Ⴅ;

	internal List<TelnetServerIo> Ⴗ;

	internal List<TelnetServerIo> Ⴀ;

	internal List<TelnetServerIo> Ⴃ;

	internal List<ႷႣ> Ⴀ;

	public IoDevices(ObjectManager om)
	{
		this.m_Ⴐ = om;
		Ⴄ = new List<TelnetServerIo>();
		Ⴓ = new List<PcxxServerIo>();
		Ⴈ = new List<Arc4ServerIo>();
		Ⴅ = new List<ArxServerIo>();
		this.Ⴗ = new List<TelnetServerIo>();
		this.Ⴀ = new List<TelnetServerIo>();
		Ⴃ = new List<TelnetServerIo>();
		Ⴀ = new List<ႷႣ>();
		foreach (ServerIoCfg item in om.Ⴍ().IoDevices.Server.List)
		{
			if (UserLoginRegistrationCfg.Ⴈ(item, 'Ό', 'Ͼ'))
			{
				Ⴍ(item, om);
			}
		}
		foreach (ClientIoCfg item2 in om.Ⴍ().IoDevices.Client.List)
		{
			if (Directory.Ⴗ(item2, 603, 525))
			{
				Ⴗ(item2, om);
			}
		}
		IoDevices.Ⴃ.Info(ShowWxHelp.Ⴍ('\u0089', 985808687, 8));
	}

	private void Ⴍ(ServerIoCfg P_0, ObjectManager P_1)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 4;
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
			case 3:
				return;
			}
			if (!UserLoginRegistrationCfg.Ⴈ(P_0, 'ϧ', 'Ε'))
			{
				num = 1;
				continue;
			}
			while (true)
			{
				switch (ReadMail.Ⴃ(P_0, 375, 312) switch
				{
					ServerIoType.Telnet => ⴍႤ[19] - 36143, 
					ServerIoType.ArxNode => 8, 
					ServerIoType.ArxClient => 8, 
					ServerIoType.PCxx => 10, 
					ServerIoType.AgwBpqTcp => 1, 
					ServerIoType.Arc4Active => ⴅ[6] * 4, 
					ServerIoType.Arc4Passive => ⴀႣ[301] - 4355, 
					_ => ⴄႤ[245] - ⴄႤ[134], 
				})
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					return;
				case 3:
				case 4:
					break;
				case 7:
					return;
				case 2:
				{
					object obj5 = new TelnetServerIo(P_1, P_0);
					Ⴄ.Add(obj5 as TelnetServerIo);
					return;
				}
				case 10:
				{
					object obj4 = new PcxxServerIo(P_1, P_0);
					Ⴓ.Add(obj4 as PcxxServerIo);
					return;
				}
				case 6:
				case 8:
				{
					object obj3 = new ArxServerIo(P_1, P_0);
					Ⴅ.Add((ArxServerIo)obj3);
					return;
				}
				case 1:
					obj2 = new ႷႣ(P_1, P_0);
					goto case 5;
				case 5:
					Ⴀ.Add(obj2 as ႷႣ);
					return;
				case 0:
				{
					object obj = new Arc4ServerIo(P_1, P_0);
					Ⴈ.Add((Arc4ServerIo)obj);
					return;
				}
				}
			}
		}
	}

	internal void Ⴗ(ClientIoCfg P_0, ObjectManager P_1)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 2;
		ClientIoType clientIoType = default(ClientIoType);
		while (true)
		{
			switch (num)
			{
			default:
				clientIoType = BaseCmd.Ⴓ(P_0, 'Ϟ', 1007);
				break;
			case 4:
				break;
			case 1:
			case 3:
				return;
			}
			switch (clientIoType)
			{
			case ClientIoType.Arc4Active:
			case ClientIoType.Arc4Passive:
				goto end_IL_0049;
			case ClientIoType.Ar6Node:
				goto IL_02f1;
			case ClientIoType.TelnetExtComment:
				goto IL_0459;
			case ClientIoType.Telnet:
				goto IL_0581;
			case ClientIoType.ReverseBeaconWeb:
				goto IL_06a5;
			case ClientIoType.Mirc:
				goto IL_07de;
			case ClientIoType.PCxx:
				goto IL_091b;
			}
			num = 1;
			continue;
			end_IL_0049:
			break;
		}
		goto IL_0179;
		IL_0581:
		object obj = new ArcConnect(P_1, qslinfoRequest.Ⴀ(P_0, 103, 48));
		(obj as ArcConnect).Io = new TelnetClient(P_0);
		int num2 = ⴍႭ[26] - 7608;
		goto IL_00a7;
		IL_091b:
		BaseXmlSerializer baseXmlSerializer = new ArcConnect(P_1, P_0.ConnectTo);
		((ArcConnect)baseXmlSerializer).Io = new PcxxClient(P_0);
		num2 = 14;
		goto IL_00a7;
		IL_0179:
		SetDxExtension.Ⴗ(P_0, P_1.Ⴓ().Call, 645, 'ʉ');
		BaseXmlSerializer baseXmlSerializer2 = new ArcConnect(P_1, qslinfoRequest.Ⴀ(P_0, 579, 532));
		num2 = ⴀႣ[424] - 4368;
		goto IL_00a7;
		IL_07de:
		object obj2 = new ArcConnect(P_1, qslinfoRequest.Ⴀ(P_0, 193, 150));
		((ArcConnect)obj2).Io = new MircIo(P_0);
		num2 = ⴀႼ[18] / 8;
		goto IL_00a7;
		IL_00a7:
		object obj6 = default(object);
		object obj9 = default(object);
		object obj5 = default(object);
		object obj4 = default(object);
		BaseXmlSerializer baseXmlSerializer3 = default(BaseXmlSerializer);
		object obj8 = default(object);
		BaseXmlSerializer baseXmlSerializer5 = default(BaseXmlSerializer);
		object obj7 = default(object);
		BaseXmlSerializer baseXmlSerializer4 = default(BaseXmlSerializer);
		object obj3 = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				/*OpCode not supported: LdMemberToken*/;
				return;
			case 27:
				break;
			case 2:
				((ArcConnect)baseXmlSerializer2).Io = new Arc4Client(P_0);
				((ArcConnect)baseXmlSerializer2).Ⴓ(P_1.Ⴓ());
				num2 = 29;
				continue;
			case 29:
				(baseXmlSerializer2 as ArcConnect).ConnectState = ConnectStateType.PcxxNode;
				obj6 = (ArcConnect)baseXmlSerializer2;
				(obj6 as ArcConnect).Ⴍ(SetStationClubHelp.Ⴍ(9, 3, 1747258084, null));
				num2 = 6;
				continue;
			case 6:
				((ArcConnect)obj6).Io.OnConnectEvent += ((ArcConnect)obj6).OnConnect;
				((ArcConnect)obj6).Io.OnDisconnectEvent += (obj6 as ArcConnect).OnDisconnect;
				num2 = ⴍႭ[134] - 36301;
				continue;
			case 1:
			case 32:
				((ArcConnect)obj6).Io.OnRxEvent += (obj6 as ArcConnect).OnRx;
				P_1.Ⴓ().Ⴜ((ArcConnect)obj6);
				num2 = 3;
				continue;
			case 3:
				num2 = ((!Directory.Ⴗ(P_0, 442, 492)) ? (ⴀႣ[271] - 32447) : 20);
				continue;
			case 20:
				(obj6 as ArcConnect).Io.Connect();
				return;
			case 23:
				goto IL_02f1;
			case 28:
				((ArcConnect)obj9).Io = new ArxClient(P_0);
				((ArcConnect)obj9).Ⴓ(P_1.Ⴓ());
				num2 = 24;
				continue;
			case 24:
				(obj9 as ArcConnect).ConnectState = ConnectStateType.ArxNode;
				obj5 = (ArcConnect)obj9;
				(obj5 as ArcConnect).Ⴍ(string.Empty);
				num2 = ⴀႳ[116] - 39933;
				continue;
			case 35:
				((ArcConnect)obj5).Io.OnConnectEvent += (obj5 as ArcConnect).OnConnect;
				(obj5 as ArcConnect).Io.OnDisconnectEvent += (obj5 as ArcConnect).OnDisconnect;
				num2 = ⴀႨ[193] - 56086;
				continue;
			case 4:
				((ArcConnect)obj5).Io.OnRxEvent += (obj5 as ArcConnect).OnRx;
				P_1.Ⴓ().Ⴜ((ArcConnect)obj5);
				num2 = ⴃႥ[265] - 5752;
				continue;
			case 30:
				num2 = ((!Directory.Ⴗ(P_0, 670, 712)) ? 17 : 21);
				continue;
			case 21:
				(obj5 as ArcConnect).Io.Connect();
				return;
			case 41:
				goto IL_0459;
			case 47:
				(obj4 as ArcConnect).Ⴓ(P_1.Ⴓ());
				((ArcConnect)obj4).ConnectState = ConnectStateType.RcvOnly;
				baseXmlSerializer3 = obj4 as ArcConnect;
				num2 = 38;
				continue;
			case 38:
				(baseXmlSerializer3 as ArcConnect).Io.OnConnectEvent += ((ArcConnect)baseXmlSerializer3).OnConnect;
				(baseXmlSerializer3 as ArcConnect).Io.OnDisconnectEvent += (baseXmlSerializer3 as ArcConnect).OnDisconnect;
				num2 = ⴃႰ[17] - 56138;
				continue;
			case 12:
				(baseXmlSerializer3 as ArcConnect).Io.OnRxEvent += ((ArcConnect)baseXmlSerializer3).OnRx;
				P_1.Ⴓ().Ⴜ((ArcConnect)baseXmlSerializer3);
				num2 = ⴍႤ[206] - 40692;
				continue;
			case 7:
				num2 = ((!Directory.Ⴗ(P_0, 46, 120)) ? 17 : 37);
				continue;
			case 37:
				(baseXmlSerializer3 as ArcConnect).Io.Connect();
				return;
			case 11:
				goto IL_0581;
			case 43:
				(obj as ArcConnect).Ⴓ(P_1.Ⴓ());
				((ArcConnect)obj).ConnectState = ConnectStateType.RcvOnly;
				obj8 = obj as ArcConnect;
				num2 = 22;
				continue;
			case 22:
				((ArcConnect)obj8).Io.OnConnectEvent += (obj8 as ArcConnect).OnConnect;
				(obj8 as ArcConnect).Io.OnDisconnectEvent += (obj8 as ArcConnect).OnDisconnect;
				num2 = 34;
				continue;
			case 34:
				(obj8 as ArcConnect).Io.OnRxEvent += (obj8 as ArcConnect).OnRx;
				P_1.Ⴓ().Ⴜ(obj8 as ArcConnect);
				num2 = 5;
				continue;
			case 5:
				num2 = ((!Directory.Ⴗ(P_0, 449, 407)) ? 17 : (ⴀႨ[42] - 24435));
				continue;
			case 19:
				(obj8 as ArcConnect).Io.Connect();
				return;
			case 44:
				goto IL_06a5;
			case 39:
				baseXmlSerializer5 = new ArcConnect(P_1, SetTalkCount.Ⴗ(3, null, 1267022552, typeof(UserMaintenance)));
				goto case 36;
			case 36:
				num2 = 18;
				continue;
			case 18:
				((ArcConnect)baseXmlSerializer5).Io = new ႷႼ();
				(baseXmlSerializer5 as ArcConnect).Ⴓ(P_1.Ⴓ());
				obj7 = (ArcConnect)baseXmlSerializer5;
				num2 = 48;
				continue;
			case 48:
				((ArcConnect)obj7).Io.IoCfg = P_0;
				(obj7 as ArcConnect).Ⴍ(string.Empty);
				((ArcConnect)obj7).Io.OnRxEvent += ((ArcConnect)obj7).OnRx;
				num2 = ⴃႠ[275] - 31800;
				continue;
			case 9:
				P_1.Ⴓ().Ⴜ(obj7 as ArcConnect);
				num2 = ((!Directory.Ⴗ(P_0, 628, 546)) ? 17 : (ⴀႨ[58] - 5734));
				continue;
			case 31:
				(obj7 as ArcConnect).Io.Connect();
				return;
			case 25:
				goto IL_07de;
			case 10:
				((ArcConnect)obj2).Ⴓ(P_1.Ⴓ());
				((ArcConnect)obj2).ConnectState = ConnectStateType.RcvOnly;
				baseXmlSerializer4 = (ArcConnect)obj2;
				num2 = 16;
				continue;
			case 16:
				(baseXmlSerializer4 as ArcConnect).Io.OnConnectEvent += ((ArcConnect)baseXmlSerializer4).OnConnect;
				((ArcConnect)baseXmlSerializer4).Io.OnDisconnectEvent += (baseXmlSerializer4 as ArcConnect).OnDisconnect;
				num2 = ⴀႣ[301] - 4355;
				continue;
			case 0:
				((ArcConnect)baseXmlSerializer4).Io.OnRxEvent += (baseXmlSerializer4 as ArcConnect).OnRx;
				(baseXmlSerializer4 as ArcConnect).Ⴍ(string.Empty);
				num2 = 45;
				continue;
			case 45:
				P_1.Ⴓ().Ⴜ((ArcConnect)baseXmlSerializer4);
				num2 = ((!Directory.Ⴗ(P_0, 109, 59)) ? 17 : 8);
				continue;
			case 8:
				((ArcConnect)baseXmlSerializer4).Io.Connect();
				return;
			case 42:
				goto IL_091b;
			case 14:
				((ArcConnect)baseXmlSerializer).Ⴓ(P_1.Ⴓ());
				((ArcConnect)baseXmlSerializer).ConnectState = ConnectStateType.PcxxNode;
				obj3 = baseXmlSerializer as ArcConnect;
				num2 = 46;
				continue;
			case 46:
				(obj3 as ArcConnect).Io.OnConnectEvent += ((ArcConnect)obj3).OnConnect;
				(obj3 as ArcConnect).Io.OnDisconnectEvent += (obj3 as ArcConnect).OnDisconnect;
				num2 = 26;
				continue;
			case 26:
				(obj3 as ArcConnect).Io.OnRxEvent += ((ArcConnect)obj3).OnRx;
				P_1.Ⴓ().Ⴜ((ArcConnect)obj3);
				num2 = 13;
				continue;
			case 13:
				num2 = ((!P_0.Enabled) ? 17 : (ⴅ[143] - 137));
				continue;
			case 15:
			case 40:
				(obj3 as ArcConnect).Io.Connect();
				return;
			case 17:
				return;
			}
			break;
		}
		goto IL_0179;
		IL_06a5:
		num2 = ((!ShowTalk.Ⴀ(P_1.Ⴓ().Call, CallBlockCacheCfg.Ⴅ(null, 3, 62057724, null), 371, 'Ē')) ? 17 : 39);
		goto IL_00a7;
		IL_02f1:
		SetDxExtension.Ⴗ(P_0, P_1.Ⴓ().Call, 304, 'ļ');
		obj9 = new ArcConnect(P_1, qslinfoRequest.Ⴀ(P_0, 34, 117));
		num2 = 28;
		goto IL_00a7;
		IL_0459:
		obj4 = new ArcConnect(P_1, qslinfoRequest.Ⴀ(P_0, 183, 224));
		((ArcConnect)obj4).Io = new ReverseBeaconClient(P_0);
		num2 = 47;
		goto IL_00a7;
	}

	internal void Ⴐ()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			using (List<TelnetServerIo>.Enumerator enumerator = Ⴄ.GetEnumerator())
			{
				int num = 2;
				object current = default(object);
				while (true)
				{
					switch (num)
					{
					case 4:
						current = enumerator.Current;
						goto case 5;
					case 5:
						((TelnetServerIo)current).Ⴅ.Stop();
						break;
					case 6:
						goto end_IL_002c;
					}
					num = (enumerator.MoveNext() ? 4 : (ⴀႳ[50] - 26834));
					continue;
					end_IL_002c:
					break;
				}
			}
			using (List<PcxxServerIo>.Enumerator enumerator2 = Ⴓ.GetEnumerator())
			{
				int num2 = 0;
				object current2 = default(object);
				while (true)
				{
					switch (num2)
					{
					case 5:
						current2 = enumerator2.Current;
						goto case 3;
					case 3:
						(current2 as PcxxServerIo).Ⴍ.Stop();
						break;
					case 1:
					case 4:
						goto end_IL_00a4;
					}
					num2 = ((!enumerator2.MoveNext()) ? 1 : 5);
					continue;
					end_IL_00a4:
					break;
				}
			}
			using (List<ArxServerIo>.Enumerator enumerator3 = Ⴅ.GetEnumerator())
			{
				int num3 = 6;
				object current3 = default(object);
				while (true)
				{
					switch (num3)
					{
					case 0:
						current3 = enumerator3.Current;
						goto case 2;
					case 2:
						(current3 as ArxServerIo).Ⴈ.Stop();
						break;
					case 1:
					case 3:
						goto end_IL_0112;
					}
					num3 = ((!enumerator3.MoveNext()) ? 1 : 0);
					continue;
					end_IL_0112:
					break;
				}
			}
			using (List<Arc4ServerIo>.Enumerator enumerator4 = Ⴈ.GetEnumerator())
			{
				int num4 = 2;
				object current4 = default(object);
				while (true)
				{
					switch (num4)
					{
					case 1:
						current4 = enumerator4.Current;
						goto case 0;
					case 0:
					case 6:
						(current4 as Arc4ServerIo).Ⴓ.Stop();
						break;
					case 4:
					case 5:
						goto end_IL_0180;
					}
					num4 = (enumerator4.MoveNext() ? 1 : (ⴄႤ[47] / 3));
					continue;
					end_IL_0180:
					break;
				}
			}
			using List<ႷႣ>.Enumerator enumerator5 = Ⴀ.GetEnumerator();
			int num5 = 6;
			object current5 = default(object);
			while (true)
			{
				switch (num5)
				{
				case 0:
				case 5:
					current5 = enumerator5.Current;
					goto case 1;
				case 1:
					((ႷႣ)current5).Ⴃ.Stop();
					break;
				case 2:
				case 3:
					goto end_IL_01f4;
				}
				num5 = ((!enumerator5.MoveNext()) ? (ⴍႭ[207] - 35457) : 0);
				continue;
				end_IL_01f4:
				break;
			}
		}
		catch (Exception ex)
		{
			SkimmerSpotBins.Ⴈ(ex as Exception, 216, 246);
		}
		try
		{
			object enumerator6 = this.m_Ⴐ.Ⴓ().ArcConnects.GetEnumerator();
			try
			{
				int num6 = 1;
				KeyValuePair<Guid, ArcConnect> current6 = default(KeyValuePair<Guid, ArcConnect>);
				while (true)
				{
					switch (num6)
					{
					case 3:
					case 7:
						current6 = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator6).Current;
						goto case 0;
					case 0:
					case 4:
						num6 = ((!current6.Value.Io.IsConnected) ? 5 : (ⴃႰ[114] - 38482));
						continue;
					case 2:
						current6.Value.Io.Disconnect();
						break;
					case 6:
						return;
					}
					num6 = ((enumerator6 as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? 3 : 6);
				}
			}
			finally
			{
				int num7 = 3;
				while (true)
				{
					int num8;
					switch (num7)
					{
					default:
						num8 = ((!(enumerator6 is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 4 : 0);
						goto IL_034c;
					case 0:
						(enumerator6 as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
						break;
					case 1:
					case 4:
					case 5:
						break;
					}
					break;
					IL_034c:
					num7 = num8;
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
