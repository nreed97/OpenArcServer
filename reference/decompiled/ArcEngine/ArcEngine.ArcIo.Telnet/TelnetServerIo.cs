using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces;
using ArcInterfaces.Io;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using log4net;

namespace ArcEngine.ArcIo.Telnet;

public sealed class TelnetServerIo
{
	private static readonly ILog Ⴃ;

	private readonly ObjectManager Ⴍ;

	internal readonly IIoServer Ⴅ;

	private static int Ⴐ;

	public TelnetServerIo(ObjectManager om, IIoDeviceCfg ioDeviceCfg)
	{
		Ⴍ = om;
		Ⴅ = new TelnetServer(ioDeviceCfg);
		Ⴅ.OnConnectEvent += Ⴗ;
		Ⴅ.EofChar = SetStationClubHelp.Ⴍ(12, 6, 1747258081, null);
		Ⴅ.Start();
		Ⴃ.Info(SetWxCountHelp.Ⴗ((object)SetStationQth.Ⴍ(null, 1687354217, 4, 8), (object)ioDeviceCfg, 603, (short)544));
	}

	private void Ⴗ(IIoClient P_0)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 9;
		Array array = default(Array);
		IComparable comparable = default(IComparable);
		BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				Ⴐ++;
				array = new object[4];
				(array as object[])[0] = SetTalkCount.Ⴗ(0, null, 1267023131, typeof(SetDxModeHelp));
				num = ⴀႳ[12] - 3795;
				break;
			case 6:
				((object[])array)[1] = P_0.IoCfg.Port;
				((object[])array)[2] = CallBlockCacheCfg.Ⴅ(null, 0, 62054443, null);
				num = 4;
				break;
			case 4:
				(array as object[])[3] = Ⴐ;
				comparable = SetDxDefaultHelp.Ⴍ((object[])array, 'v', 31);
				num = 5;
				break;
			case 5:
				baseXmlSerializer = new ArcConnect(Ⴍ, (string)comparable);
				((ArcConnect)baseXmlSerializer).Io = P_0;
				num = ⴍႤ[273] - 160;
				break;
			case 1:
			case 8:
				(baseXmlSerializer as ArcConnect).ConnectState = ConnectStateType.TelnetUser;
				obj = baseXmlSerializer as ArcConnect;
				P_0.OnRxEvent += ((ArcConnect)obj).OnRx;
				num = ⴄႷ[139] - 44123;
				break;
			case 3:
				P_0.OnConnectEvent += ((ArcConnect)obj).OnConnect;
				P_0.OnDisconnectEvent += (obj as ArcConnect).OnDisconnect;
				num = 2;
				break;
			case 0:
			case 2:
				(obj as ArcConnect).Ⴓ(Ⴍ.Ⴓ());
				((ArcConnect)obj).OnConnect(ShowSkimCtyHelp.Ⴍ(1216135065, 6, 'ö'));
				num = ⴃႥ[379] - 3028;
				break;
			case 7:
				Ⴍ.Ⴓ().Ⴜ((ArcConnect)obj);
				return;
			case 10:
				return;
			}
		}
	}

	static TelnetServerIo()
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴃ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('©', 985806339, 4), 345, 324);
				break;
			case 2:
				break;
			case 1:
				Ⴐ = 0;
				return;
			case 0:
				return;
			}
			num = 1;
		}
	}
}
