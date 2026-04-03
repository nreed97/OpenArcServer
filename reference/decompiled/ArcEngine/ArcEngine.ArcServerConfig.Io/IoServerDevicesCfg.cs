using System.Collections.Generic;
using System.ComponentModel;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using ArcShared;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Io;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class IoServerDevicesCfg
{
	private ႰႥ.ႳႥ Ⴐ = new ႰႥ.ႳႥ();

	[Description("Server Devices - Setup a TCP server so that others can connect directly to you.  To apply the changes, restart the app.")]
	public List<ServerIoCfg> List
	{
		get
		{
			char[] ⴀ = SetAnnChatRooms.Ⴀ;
			List<ServerIoCfg> ⴈ = Ⴐ.Ⴈ;
			TxNodeUserCmd.ႤႷ[88] = (char)((TxNodeUserCmd.ႤႷ[88] ^ TxNodeUserCmd.ႤႷ[47]) & 0x3A);
			return ⴈ;
		}
		set
		{
			Ⴐ.Ⴈ = value as List<ServerIoCfg>;
		}
	}

	public IoServerDevicesCfg()
	{
		List = new List<ServerIoCfg>();
	}

	public void LoadDefaults()
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 7;
		while (true)
		{
			switch (num)
			{
			default:
			{
				List<ServerIoCfg> list7 = List;
				object obj5 = new ServerIoCfg();
				ShowWwv.Ⴓ((ServerIoCfg)obj5, ServerIoType.Telnet, '\u030a', 807);
				ႳႠ.ႰႥ(obj5 as ServerIoCfg, SetStationClubHelp.Ⴍ(6, 1, 1747260152, null), 775, 801);
				ႰႰ.Ⴓ((ServerIoCfg)obj5, false, 946, 'ϝ');
				ႷႳ.Ⴓ((ServerIoCfg)obj5, 23, '»', 'ñ');
				SetStationQthHelp.Ⴐ(obj5 as ServerIoCfg, SetTalkCount.Ⴗ(4, null, 1267023754, typeof(AnnWxArx)), 914, 991);
				ႳႠ.ႰႥ((ServerIoCfg)obj5, ReplyMailHelp.Ⴄ(17, null, 1057166684, 4), 336, 375);
				ႷႳ.Ⴅ((ServerIoCfg)obj5, ReplyMailHelp.Ⴄ(31, null, 1057161234, 5), '\u02eb', 641);
				ႷႳ.Ⴅ(obj5 as ServerIoCfg, SetTalkCount.Ⴗ(3, null, 1267014091, typeof(ShowUsers.ႨႭ)), 'ř', 306);
				SetStationQthHelp.Ⴐ((ServerIoCfg)obj5, CallBlockCacheCfg.Ⴅ(null, 5, 62062203, null), 181, 251);
				list7.Add(obj5 as ServerIoCfg);
				goto case 6;
			}
			case 6:
				num = 5;
				break;
			case 5:
			{
				List<ServerIoCfg> list6 = List;
				object obj4 = new ServerIoCfg();
				ShowWwv.Ⴓ((ServerIoCfg)obj4, ServerIoType.Telnet, 'ȷ', 538);
				ႳႠ.ႰႥ(obj4 as ServerIoCfg, ShowWxHelp.Ⴍ('3', 985805230, 3), 57, 31);
				ႰႰ.Ⴓ((ServerIoCfg)obj4, false, 188, 'Ó');
				ႷႳ.Ⴓ((ServerIoCfg)obj4, 7373, 'Ā', 'Ŋ');
				SetStationQthHelp.Ⴐ((ServerIoCfg)obj4, ShowSkimCtyHelp.Ⴍ(1216134502, 0, 'ð'), 174, 227);
				ႳႠ.ႰႥ((ServerIoCfg)obj4, ReplyMailHelp.Ⴄ(31, null, 1057166680, 0), 122, 93);
				ႷႳ.Ⴅ(obj4 as ServerIoCfg, ႰႥ.Ⴅ(1, '¥', 952620870), '\u009e', 244);
				ႷႳ.Ⴅ((ServerIoCfg)obj4, SetTalkCount.Ⴗ(4, null, 1267014092, typeof(ႷႰ.ႥႤ)), 'ŝ', 310);
				SetStationQthHelp.Ⴐ(obj4 as ServerIoCfg, string.Empty, 407, 473);
				list6.Add(obj4 as ServerIoCfg);
				num = ⴄႷ[21] - 64088;
				break;
			}
			case 0:
			{
				List<ServerIoCfg> list5 = List;
				object obj3 = new ServerIoCfg();
				ShowWwv.Ⴓ((ServerIoCfg)obj3, ServerIoType.ArxNode, 'J', 103);
				ႳႠ.ႰႥ((ServerIoCfg)obj3, ReplyMailHelp.Ⴄ(17, null, 1057166715, 1), 434, 404);
				ႰႰ.Ⴓ(obj3 as ServerIoCfg, false, 947, 'Ϝ');
				ႷႳ.Ⴓ(obj3 as ServerIoCfg, 3607, 'Ɯ', 'ǖ');
				SetStationQthHelp.Ⴐ(obj3 as ServerIoCfg, string.Empty, 119, 57);
				ႳႠ.ႰႰ((ServerIoCfg)obj3, string.Empty, 'Ȧ', 'ɚ');
				ႳႠ.ႰႥ(obj3 as ServerIoCfg, string.Empty, 55, 31);
				list5.Add((ServerIoCfg)obj3);
				num = 4;
				break;
			}
			case 4:
			{
				List<ServerIoCfg> list4 = List;
				object obj2 = new ServerIoCfg();
				ShowWwv.Ⴓ(obj2 as ServerIoCfg, ServerIoType.ArxClient, 'ɓ', 638);
				ႳႠ.ႰႥ(obj2 as ServerIoCfg, SetStationQth.Ⴍ(null, 1687355224, 0, 3), 846, 872);
				ႰႰ.Ⴓ((ServerIoCfg)obj2, false, 499, 'Ɯ');
				ႷႳ.Ⴓ(obj2 as ServerIoCfg, 3608, '\u035a', '\u0310');
				SetStationQthHelp.Ⴐ((ServerIoCfg)obj2, string.Empty, 305, 383);
				ႳႠ.ႰႰ(obj2 as ServerIoCfg, string.Empty, 'Ȑ', 'ɬ');
				ႳႠ.ႰႥ((ServerIoCfg)obj2, string.Empty, 951, 927);
				list4.Add((ServerIoCfg)obj2);
				num = ⴀႨ[8] - 49078;
				break;
			}
			case 8:
			{
				List<ServerIoCfg> list3 = List;
				IIoDeviceCfg ioDeviceCfg2 = new ServerIoCfg();
				(ioDeviceCfg2 as ServerIoCfg).Type = ServerIoType.PCxx;
				(ioDeviceCfg2 as ServerIoCfg).Description = ReplyMailHelp.Ⴄ(0, null, 1057166621, 1);
				(ioDeviceCfg2 as ServerIoCfg).Enabled = false;
				(ioDeviceCfg2 as ServerIoCfg).Port = 9000;
				((ServerIoCfg)ioDeviceCfg2).DefaultDxFilter = string.Empty;
				(ioDeviceCfg2 as ServerIoCfg).DefaultAnnFilter = string.Empty;
				((ServerIoCfg)ioDeviceCfg2).DefaultWxFilter = string.Empty;
				list3.Add(ioDeviceCfg2 as ServerIoCfg);
				goto case 2;
			}
			case 2:
				num = 9;
				break;
			case 9:
			{
				List<ServerIoCfg> list2 = List;
				IIoDeviceCfg ioDeviceCfg = new ServerIoCfg();
				(ioDeviceCfg as ServerIoCfg).Type = ServerIoType.Arc4Active;
				(ioDeviceCfg as ServerIoCfg).Description = SetStationQth.Ⴍ(null, 1687355260, 2, 0);
				(ioDeviceCfg as ServerIoCfg).Enabled = false;
				(ioDeviceCfg as ServerIoCfg).Port = 3605;
				(ioDeviceCfg as ServerIoCfg).DefaultDxFilter = string.Empty;
				(ioDeviceCfg as ServerIoCfg).DefaultAnnFilter = string.Empty;
				(ioDeviceCfg as ServerIoCfg).DefaultWxFilter = string.Empty;
				list2.Add(ioDeviceCfg as ServerIoCfg);
				num = 1;
				break;
			}
			case 1:
			{
				List<ServerIoCfg> list = List;
				object obj = new ServerIoCfg();
				(obj as ServerIoCfg).Type = ServerIoType.Arc4Passive;
				(obj as ServerIoCfg).Description = ReplyMailHelp.Ⴄ(8, null, 1057166633, 4);
				(obj as ServerIoCfg).Enabled = false;
				(obj as ServerIoCfg).Port = 3606;
				(obj as ServerIoCfg).DefaultDxFilter = string.Empty;
				((ServerIoCfg)obj).DefaultAnnFilter = string.Empty;
				(obj as ServerIoCfg).DefaultWxFilter = string.Empty;
				list.Add((ServerIoCfg)obj);
				return;
			}
			case 3:
				return;
			}
		}
	}

	public override string ToString()
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		return ShowSkimCtyHelp.Ⴍ(1216130635, 0, '-');
	}
}
