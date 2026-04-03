using System;
using ArcEngine;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using log4net;

namespace Ⴈ;

internal sealed class ႷႣ
{
	private static readonly ILog Ⴍ;

	private readonly ObjectManager Ⴗ;

	internal readonly IIoServer Ⴃ;

	private static int Ⴈ;

	public ႷႣ(ObjectManager P_0, IIoDeviceCfg P_1)
	{
		Ⴍ.Info(SetWxCountHelp.Ⴗ((object)ႨႨ.Ⴀ(11, 8, 1157904495), (object)P_1, 824, (short)835));
		Ⴗ = P_0;
		P_1.IpAddress = ReplyMailHelp.Ⴄ(1, null, 1057164812, 5);
		Ⴃ = new ႷႭ(P_1);
		Ⴃ.OnConnectEvent += Ⴀ;
		Ⴃ.EofChar = string.Empty;
		Ⴃ.Start();
	}

	private void Ⴀ(IIoClient P_0)
	{
		int num = 6;
		Array array = default(Array);
		IConvertible convertible = default(IConvertible);
		object obj2 = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				array = new object[4];
				((object[])array)[0] = SetTalkCount.Ⴗ(1, null, 1267023130, typeof(MailManager));
				num = 1;
				break;
			case 1:
				((object[])array)[1] = P_0.IoCfg.Port;
				(array as object[])[2] = CallBlockCacheCfg.Ⴅ(null, 0, 62054443, null);
				num = 4;
				break;
			case 4:
				((object[])array)[3] = Ⴈ;
				goto case 2;
			case 2:
				convertible = SetDxDefaultHelp.Ⴍ(array as object[], 'ϲ', 923);
				num = 9;
				break;
			case 9:
				obj2 = new ArcConnect(Ⴗ, (string)convertible);
				(obj2 as ArcConnect).Io = P_0;
				num = 0;
				break;
			case 0:
				obj = (ArcConnect)obj2;
				goto case 7;
			case 7:
				P_0.OnRxEvent += ((ArcConnect)obj).OnRx;
				P_0.OnConnectEvent += ((ArcConnect)obj).OnConnect;
				num = 8;
				break;
			case 8:
				P_0.OnDisconnectEvent += (obj as ArcConnect).OnDisconnect;
				(obj as ArcConnect).Ⴓ(Ⴗ.Ⴓ());
				num = 5;
				break;
			case 5:
				((ArcConnect)obj).OnConnect(ShowSkimCtyHelp.Ⴍ(1216135071, 0, '0'));
				Ⴗ.Ⴓ().Ⴜ((ArcConnect)obj);
				return;
			}
		}
	}

	static ႷႣ()
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴍ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('\u00b4', 985806491, 4), 137, 148);
				break;
			case 0:
				break;
			case 1:
				Ⴈ = 0;
				return;
			}
			num = 1;
		}
	}
}
