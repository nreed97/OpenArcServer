using System;
using System.Collections.Generic;
using ArcEngine;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces.Io;
using ArcShared;
using log4net;

namespace Ⴈ;

internal sealed class ႷႨ
{
	private static readonly ILog Ⴗ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(0, null, 1267019270, typeof(ႳႰ)), 306, 303);

	public static void Ⴃ(ObjectManager P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		DateTime dateTime = ShowAnnHelp.Ⴅ('Â', 243);
		object enumerator = P_0.Ⴓ().ArcConnects.GetEnumerator();
		try
		{
			int num = 0;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			TimeSpan timeSpan = default(TimeSpan);
			while (true)
			{
				switch (num)
				{
				default:
					num = ⴍႭ[374] - 54480;
					continue;
				case 6:
				case 8:
					current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
					num = ((!current.Value.Io.IsConnected) ? 10 : 2);
					continue;
				case 2:
					timeSpan = DirectoryBulletinHelp.Ⴓ(ref dateTime, current.Value.Io.LastSendDts, 601, 'ɮ');
					num = ⴄႷ[71] - 34089;
					continue;
				case 9:
					num = ((!(Publisher.Ⴜ(ref timeSpan, 't', 20) > 110.0)) ? 10 : 5);
					continue;
				case 1:
				case 4:
				case 5:
					Ⴀ(current.Value);
					break;
				case 10:
					break;
				case 3:
					goto end_IL_0032;
				}
				num = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).MoveNext() ? 6 : 3);
				continue;
				end_IL_0032:
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
					num3 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 6 : 0);
					goto IL_014b;
				case 0:
				case 4:
					(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
					break;
				case 6:
					break;
				}
				break;
				IL_014b:
				num2 = num3;
			}
		}
		switch (4)
		{
		}
	}

	private static void Ⴀ(ArcConnect P_0)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 4;
		IoCategoryType category = default(IoCategoryType);
		while (true)
		{
			switch (num)
			{
			default:
				category = P_0.Io.IoCfg.Category;
				break;
			case 0:
			case 1:
				break;
			case 2:
			case 3:
				return;
			}
			switch (category)
			{
			case IoCategoryType.Server:
				goto end_IL_0018;
			case IoCategoryType.Client:
				goto IL_0198;
			}
			num = 3;
			continue;
			end_IL_0018:
			break;
		}
		goto IL_00b1;
		IL_00b1:
		int num2 = ((!MailHelper.Ⴅ(SetAnnModeHelp.Ⴓ((object)P_0.Io.IoCfg, 346, 'Đ'), typeof(ServerIoCfg), 603, 623)) ? 11 : 16);
		goto IL_005b;
		IL_0198:
		num2 = ((!MailHelper.Ⴅ(SetAnnModeHelp.Ⴓ((object)P_0.Io.IoCfg, 233, '£'), typeof(ClientIoCfg), 842, 894)) ? 11 : 5);
		goto IL_005b;
		IL_005b:
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			switch (num2)
			{
			default:
				/*OpCode not supported: LdMemberToken*/;
				return;
			case 4:
				break;
			case 16:
				num2 = ReadMail.Ⴃ((ServerIoCfg)P_0.Io.IoCfg, 4, 75) switch
				{
					ServerIoType.Telnet => 14, 
					ServerIoType.ArxNode => 13, 
					ServerIoType.ArxClient => 13, 
					_ => 15, 
				};
				continue;
			case 15:
				return;
			case 14:
				num2 = ((!P_0.Ⴃ()) ? (ⴃႰ[207] - 39483) : 12);
				continue;
			case 0:
			case 6:
			case 12:
				comparable = qslinfoRequest.Ⴃ(P_0.Call, P_0.Ⴍ().Call, 378, 331);
				num2 = 10;
				continue;
			case 10:
				P_0.ႠႰ(comparable as string);
				return;
			case 13:
				P_0.ႠႰ(string.Empty);
				return;
			case 3:
				goto IL_0198;
			case 5:
				num2 = ((ClientIoCfg)P_0.Io.IoCfg).Type switch
				{
					ClientIoType.Ar6Node => 9, 
					ClientIoType.Arc4Active => 9, 
					ClientIoType.Arc4Passive => ⴀႣ[28] - 32352, 
					ClientIoType.PCxx => 7, 
					ClientIoType.Telnet => 7, 
					ClientIoType.TelnetExtComment => ⴄႷ[120] - 46466, 
					_ => 17, 
				};
				continue;
			case 2:
			case 17:
				return;
			case 9:
				P_0.ႠႰ(string.Empty);
				return;
			case 7:
				num2 = ((!P_0.Ⴃ()) ? 11 : 8);
				continue;
			case 8:
				P_0.ႠႰ(string.Empty);
				return;
			case 11:
				return;
			}
			break;
		}
		goto IL_00b1;
	}
}
