using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using ArcShared.ArcIo.Arx;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcIo.Arx;

public sealed class ArxServerIo
{
	internal readonly IIoServer Ⴈ;

	private static int Ⴀ = 0;

	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('p', 985805956, 6), 969, 980);

	private SetDxCount.Ⴃ Ⴗ;

	public ArxServerIo(ObjectManager om, IIoDeviceCfg ioDeviceCfg)
	{
		Ⴗ.Ⴐ = om;
		Ⴈ = new ArxServer(ioDeviceCfg);
		Ⴈ.OnConnectEvent += Ⴓ;
		Ⴈ.EofChar = string.Empty;
		Ⴈ.Start();
		Ⴅ.Info(SetWxCountHelp.Ⴗ((object)ႨႨ.Ⴀ(12, 3, 1157905235), (object)ioDeviceCfg, 761, (short)642));
	}

	private void Ⴓ(IIoClient P_0)
	{
		int num = 1;
		IComparable<string> comparable = default(IComparable<string>);
		object obj = default(object);
		BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
		while (true)
		{
			switch (num)
			{
			default:
				Ⴀ++;
				comparable = SetWxCountHelp.Ⴗ((object)CallBlockCacheCfg.Ⴅ(null, 0, 62055035, null), (object)Ⴀ, 55, (short)76);
				num = 2;
				break;
			case 2:
				obj = new ArcConnect(Ⴗ.Ⴐ, comparable as string);
				(obj as ArcConnect).Io = P_0;
				num = 4;
				break;
			case 4:
				baseXmlSerializer = (ArcConnect)obj;
				goto case 6;
			case 6:
				P_0.OnRxEvent += ((ArcConnect)baseXmlSerializer).OnRx;
				goto case 3;
			case 3:
				P_0.OnConnectEvent += ((ArcConnect)baseXmlSerializer).OnConnect;
				num = 7;
				break;
			case 5:
			case 7:
				P_0.OnDisconnectEvent += ((ArcConnect)baseXmlSerializer).OnDisconnect;
				(baseXmlSerializer as ArcConnect).OnConnect(ShowSkimCtyHelp.Ⴍ(1216135071, 0, 'à'));
				num = 0;
				break;
			case 0:
				(baseXmlSerializer as ArcConnect).Ⴓ(Ⴗ.Ⴐ.Ⴓ());
				Ⴗ.Ⴐ.Ⴓ().Ⴜ((ArcConnect)baseXmlSerializer);
				return;
			}
		}
	}
}
