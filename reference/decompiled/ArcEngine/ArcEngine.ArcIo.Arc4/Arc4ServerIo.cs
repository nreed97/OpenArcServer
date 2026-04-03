using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcIo.Arc4;

public sealed class Arc4ServerIo
{
	internal readonly IIoServer Ⴓ;

	private static int Ⴈ = 0;

	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('Z', 985806427, 1), 10, 23);

	private SetDxCount.Ⴃ Ⴀ;

	public Arc4ServerIo(ObjectManager om, IIoDeviceCfg ioDeviceCfg)
	{
		Ⴀ.Ⴐ = om as ObjectManager;
		Ⴓ = new Arc4Server(ioDeviceCfg);
		Ⴓ.OnConnectEvent += Ⴍ;
		Ⴓ.EofChar = string.Empty;
		Ⴓ.Start();
		Ⴅ.Info(SetWxCountHelp.Ⴗ((object)ႨႨ.Ⴀ(1, 8, 1157904734), (object)ioDeviceCfg, 666, (short)737));
	}

	private void Ⴍ(IIoClient P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 8;
		Array array = default(Array);
		IComparable comparable = default(IComparable);
		BaseXmlSerializer baseXmlSerializer2 = default(BaseXmlSerializer);
		BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
		while (true)
		{
			switch (num)
			{
			default:
				Ⴈ++;
				array = new object[4];
				((object[])array)[0] = SetTalkCount.Ⴗ(0, null, 1267023131, typeof(ႰႼ));
				num = ⴅ[20] / 2;
				break;
			case 5:
				(array as object[])[1] = P_0.IoCfg.Port;
				((object[])array)[2] = CallBlockCacheCfg.Ⴅ(null, 2, 62054441, null);
				num = 4;
				break;
			case 4:
				(array as object[])[3] = Ⴈ;
				comparable = SetDxDefaultHelp.Ⴍ((object[])array, 'ǆ', 431);
				goto case 2;
			case 2:
				num = ⴃႠ[92] - 52168;
				break;
			case 9:
				baseXmlSerializer2 = new ArcConnect(Ⴀ.Ⴐ, (string)comparable);
				((ArcConnect)baseXmlSerializer2).Io = P_0;
				goto case 1;
			case 1:
				num = ⴍႤ[197] - 5313;
				break;
			case 10:
				baseXmlSerializer = (ArcConnect)baseXmlSerializer2;
				P_0.OnRxEvent += (baseXmlSerializer as ArcConnect).OnRx;
				goto case 6;
			case 6:
				P_0.OnConnectEvent += ((ArcConnect)baseXmlSerializer).OnConnect;
				num = 7;
				break;
			case 7:
				P_0.OnDisconnectEvent += (baseXmlSerializer as ArcConnect).OnDisconnect;
				((ArcConnect)baseXmlSerializer).Ⴓ(Ⴀ.Ⴐ.Ⴓ());
				num = ⴅ[256] - 97;
				break;
			case 3:
				(baseXmlSerializer as ArcConnect).Ⴍ(SetStationClubHelp.Ⴍ(5, 8, 1747258095, null));
				((ArcConnect)baseXmlSerializer).OnConnect(ShowSkimCtyHelp.Ⴍ(1216135063, 8, 'H'));
				num = 0;
				break;
			case 0:
				Ⴀ.Ⴐ.Ⴓ().Ⴜ(baseXmlSerializer as ArcConnect);
				return;
			}
		}
	}
}
