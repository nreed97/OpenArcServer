using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using ArcShared.ArcIo.Pcxx;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcIo.Pcxx;

public sealed class PcxxServerIo
{
	internal readonly IIoServer Ⴍ;

	private static int Ⴓ = 0;

	private static readonly ILog Ⴈ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('\\', 985806453, 3), 499, 494);

	private SetDxCount.Ⴃ m_Ⴅ;

	public PcxxServerIo(ObjectManager om, IIoDeviceCfg ioDeviceCfg)
	{
		this.m_Ⴅ.Ⴐ = om as ObjectManager;
		Ⴍ = new PcxxServer(ioDeviceCfg);
		Ⴍ.OnConnectEvent += Ⴅ;
		Ⴍ.EofChar = SetStationClubHelp.Ⴍ(4, 5, 1747258082, null);
		Ⴍ.Start();
		Ⴈ.Info(SetWxCountHelp.Ⴗ((object)ႨႨ.Ⴀ(6, 0, 1157904830), (object)ioDeviceCfg, 171, (short)208));
	}

	private void Ⴅ(IIoClient P_0)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 4;
		object obj2 = default(object);
		IComparable comparable = default(IComparable);
		BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				Ⴓ++;
				obj2 = new object[4];
				((object[])obj2)[0] = SetTalkCount.Ⴗ(1, null, 1267023130, typeof(SetStationQthHelp));
				num = ⴀႣ[158] - 19858;
				break;
			case 1:
			case 9:
				(obj2 as object[])[1] = P_0.IoCfg.Port;
				(obj2 as object[])[2] = CallBlockCacheCfg.Ⴅ(null, 6, 62054445, null);
				num = 3;
				break;
			case 3:
				(obj2 as object[])[3] = Ⴓ;
				comparable = SetDxDefaultHelp.Ⴍ(obj2 as object[], 'Ǩ', 385);
				num = ⴍႤ[72] - 6261;
				break;
			case 8:
				baseXmlSerializer = new ArcConnect(this.m_Ⴅ.Ⴐ, comparable as string);
				(baseXmlSerializer as ArcConnect).Io = P_0;
				num = 7;
				break;
			case 2:
			case 7:
				obj = (ArcConnect)baseXmlSerializer;
				P_0.OnRxEvent += ((ArcConnect)obj).OnRx;
				P_0.OnConnectEvent += ((ArcConnect)obj).OnConnect;
				num = ⴀႼ[57] - 159;
				break;
			case 6:
				P_0.OnDisconnectEvent += (obj as ArcConnect).OnDisconnect;
				goto case 5;
			case 5:
				((ArcConnect)obj).Ⴓ(this.m_Ⴅ.Ⴐ.Ⴓ());
				num = 0;
				break;
			case 0:
				(obj as ArcConnect).OnConnect(ShowSkimCtyHelp.Ⴍ(1216135066, 5, 't'));
				this.m_Ⴅ.Ⴐ.Ⴓ().Ⴜ(obj as ArcConnect);
				return;
			}
		}
	}
}
