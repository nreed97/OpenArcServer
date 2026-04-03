using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Node.Pc;
using ArcEngine.ArcCmds.NodeProcessor;
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
using ArcEngine.ArcIo.Arx;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.Callbook;
using ArcEngine.QslInfo;
using ArcInterfaces.Io;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Io;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class IoClientDevicesCfg
{
	private sealed class ႥႰ
	{
		public Guid Ⴍ;

		public bool Ⴍ(ClientIoCfg P_0)
		{
			return SetDxOutput.Ⴍ(P_0, 728, 665).Equals(this.Ⴍ);
		}
	}

	private List<ClientIoCfg> Ⴍ;

	[Description("Client Devices - Set up TCP client outbound connections to connect to others.  To apply the changes, restart the app.  A better approach to managing client connections is via the Config Clients Connects menu.")]
	public List<ClientIoCfg> List
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			return Ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	public IoClientDevicesCfg()
	{
		List = new List<ClientIoCfg>();
	}

	public void LoadDefaults(string nodeCall)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 4;
		IEnumerable<char> empty = default(IEnumerable<char>);
		while (true)
		{
			switch (num)
			{
			default:
				empty = string.Empty;
				List.Add(new ClientIoCfg(ClientIoType.Telnet, ႰႥ.Ⴅ(5, 'Ï', 952622223), enabled: false, ShowWxHelp.Ⴍ('\u0096', 985807305, 3), 7000, ReplyMail.Ⴅ(7, 7, 1217944019), nodeCall, empty as string));
				goto case 20;
			case 20:
				num = ⴅ[365];
				break;
			case 12:
				List.Add(new ClientIoCfg(ClientIoType.TelnetExtComment, ႰႥ.Ⴅ(6, 'l', 952622234), enabled: false, ShowWxHelp.Ⴍ('õ', 985807148, 8), 7000, ShowWxHelp.Ⴍ('5', 985807104, 1), nodeCall, (string)empty));
				num = 16;
				break;
			case 16:
				List.Add(new ClientIoCfg(ClientIoType.Mirc, ႰႥ.Ⴅ(5, 'õ', 952622248), enabled: false, ShowWxHelp.Ⴍ('\u009a', 985807116, 3), 6667, ShowWxHelp.Ⴍ('ñ', 985807205, 6), nodeCall, empty as string));
				num = 26;
				break;
			case 26:
				List.Add(new ClientIoCfg(ClientIoType.Ar6Node, ႰႥ.Ⴅ(2, '\u0019', 952622269), enabled: false, ShowWxHelp.Ⴍ('G', 985807215, 4), 3607, CallBlockCacheCfg.Ⴅ(null, 0, 62057727, null), nodeCall, (string)empty));
				num = 21;
				break;
			case 21:
				List.Add(new ClientIoCfg(ClientIoType.Ar6Node, ႰႥ.Ⴅ(6, 'P', 952622160), enabled: false, ShowWxHelp.Ⴍ('£', 985807191, 2), 3607, ShowWxHelp.Ⴍ('ã', 985807170, 7), nodeCall, (string)empty));
				num = ⴃႠ[344] - 10994;
				break;
			case 9:
			case 11:
			{
				List.Add(new ClientIoCfg(ClientIoType.Ar6Node, ႰႥ.Ⴅ(7, '\u0010', 952622187), enabled: false, ShowWxHelp.Ⴍ('\u00a8', 985807182, 2), 3607, ShowWxHelp.Ⴍ('\u0005', 985807011, 1), nodeCall, empty as string));
				byte num2 = ⴀႼ[54];
				Arc4ServerClient.ႠႣ[302] = (char)((Arc4ServerClient.ႠႣ[302] ^ SetWxOutput.ႣႰ[61]) & 0xBD);
				num = num2 - 76;
				break;
			}
			case 2:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, ႰႥ.Ⴅ(3, '\u0018', 952622084), enabled: false, ShowWxHelp.Ⴍ('\u000f', 985807016, 3), 23, SetStationClubHelp.Ⴍ(4, 6, 1747258448, null), nodeCall, empty as string));
				num = ⴍႤ[56] - 14310;
				break;
			case 5:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(0, null, 1267021725, typeof(SetStationLatLonHelp)), enabled: false, SetStationClubHelp.Ⴍ(4, 8, 1747258433, null), 7300, SetStationClubHelp.Ⴍ(11, 4, 1747258490, null), nodeCall, empty as string));
				num = 23;
				break;
			case 23:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(1, null, 1267021702, typeof(SetStationClub)), enabled: false, SetStationClubHelp.Ⴍ(1, 0, 1747258486, null), 7300, SetStationClubHelp.Ⴍ(5, 5, 1747258469, null), nodeCall, empty as string));
				num = 27;
				break;
			case 27:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(4, null, 1267020901, typeof(PcxxNetCmdQueue)), enabled: false, SetStationClubHelp.Ⴍ(12, 3, 1747258779, null), 7300, SetStationClubHelp.Ⴍ(4, 5, 1747258798, null), nodeCall, (string)empty));
				num = 25;
				break;
			case 25:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(5, null, 1267020850, typeof(SkimmerCtyCoverageCache)), enabled: false, SetStationClubHelp.Ⴍ(8, 8, 1747258792, null), 7300, SetStationClubHelp.Ⴍ(14, 0, 1747258864, null), nodeCall, empty as string));
				num = 18;
				break;
			case 18:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(7, null, 1267020821, typeof(ArxServerIo)), enabled: false, SetStationClubHelp.Ⴍ(15, 4, 1747258861, null), 7300, SetStationClubHelp.Ⴍ(8, 0, 1747258649, null), nodeCall, (string)empty));
				num = ⴀႨ[161] - 7149;
				break;
			case 17:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(2, null, 1267021017, typeof(ChatRoomPubCfg)), enabled: false, SetStationClubHelp.Ⴍ(13, 5, 1747258645, null), 7300, SetTalkCount.Ⴗ(4, null, 1267023121, typeof(FocCache)), nodeCall, empty as string));
				num = 10;
				break;
			case 10:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(0, null, 1267020966, typeof(qslinfoSoap)), enabled: false, SetStationClubHelp.Ⴍ(8, 7, 1747258705, null), 7300, SetStationClubHelp.Ⴍ(3, 4, 1747258690, null), nodeCall, empty as string));
				num = ⴀႼ[18] - 72;
				break;
			case 8:
			case 19:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(7, null, 1267020935, typeof(FocCacheCfg)), enabled: false, SetStationClubHelp.Ⴍ(14, 4, 1747258746, null), 7300, SetStationClubHelp.Ⴍ(14, 0, 1747258723, null), nodeCall, empty as string));
				num = ⴃႰ[71] - 42544;
				break;
			case 22:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(5, null, 1267021149, typeof(DirectoryBulletin)), enabled: false, SetStationClubHelp.Ⴍ(1, 3, 1747255956, null), 7300, SetStationQth.Ⴍ(null, 1687352312, 4, 28), nodeCall, empty as string));
				num = 3;
				break;
			case 3:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(3, null, 1267021122, typeof(UsCallbook.IndexRecord)), enabled: false, SetStationClubHelp.Ⴍ(1, 4, 1747255938, null), 7300, SetStationClubHelp.Ⴍ(14, 3, 1747255984, null), nodeCall, empty as string));
				num = ⴐ[343] - 213;
				break;
			case 15:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(2, null, 1267021102, typeof(ShowNodesHelp)), enabled: false, SetStationClubHelp.Ⴍ(8, 5, 1747255981, null), 7300, SetStationClubHelp.Ⴍ(11, 7, 1747256028, null), nodeCall, empty as string));
				num = ⴍႤ[66] - 29518;
				break;
			case 6:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(6, null, 1267021072, typeof(SetDxHelp)), enabled: false, SetStationClubHelp.Ⴍ(11, 6, 1747256021, null), 7300, SetStationClubHelp.Ⴍ(3, 6, 1747256006, null), nodeCall, empty as string));
				num = 14;
				break;
			case 14:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(3, null, 1267021308, typeof(SetDxCountHelp)), enabled: false, SetStationClubHelp.Ⴍ(11, 3, 1747256056, null), 7300, SetStationClubHelp.Ⴍ(5, 5, 1747256047, null), nodeCall, empty as string));
				num = 13;
				break;
			case 13:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(3, null, 1267021275, typeof(global::_003CModule_003E)), enabled: false, SetStationClubHelp.Ⴍ(9, 3, 1747256046, null), 7300, SetStationClubHelp.Ⴍ(7, 2, 1747255839, null), nodeCall, empty as string));
				num = 0;
				break;
			case 0:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(0, null, 1267021186, typeof(ႰႳ)), enabled: false, SetStationClubHelp.Ⴍ(12, 3, 1747255830, null), 7300, SetStationClubHelp.Ⴍ(14, 3, 1747255815, null), nodeCall, empty as string));
				num = 24;
				break;
			case 24:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(0, null, 1267018347, typeof(ႳႥ)), enabled: false, SetStationClubHelp.Ⴍ(15, 0, 1747255871, null), 7337, SetStationClubHelp.Ⴍ(3, 2, 1747255849, null), nodeCall, empty as string));
				num = 1;
				break;
			case 1:
				List.Add(new ClientIoCfg(ClientIoType.Telnet, SetTalkCount.Ⴗ(5, null, 1267018335, typeof(SetStationNeeds)), enabled: false, SetStationClubHelp.Ⴍ(12, 8, 1747255863, null), 7300, SetStationClubHelp.Ⴍ(6, 1, 1747255845, null), nodeCall, empty as string));
				num = ⴀႳ[121] - 35628;
				break;
			case 7:
				List.Add(new ClientIoCfg(ClientIoType.PCxx, SetTalkCount.Ⴗ(1, null, 1267018314, typeof(NodeCmdCfg)), enabled: false, SetStationClubHelp.Ⴍ(3, 7, 1747255896, null), 6300, SetStationClubHelp.Ⴍ(6, 6, 1747255883, null), nodeCall, empty as string));
				return;
			}
		}
	}

	public void EnableDisableClient(Guid id, bool enabled)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		using List<ClientIoCfg>.Enumerator enumerator = List.GetEnumerator();
		int num = 1;
		object current = default(object);
		while (true)
		{
			switch (num)
			{
			case 5:
				current = enumerator.Current;
				num = ((!SetStationGrid.Ⴄ(SetDxOutput.Ⴍ((ClientIoCfg)current, 829, 892), id, 232, 239)) ? ⴀႼ[96] : (ⴍႤ[209] - 50547));
				break;
			case 2:
				SunCalculations.Ⴅ(current as ClientIoCfg, enabled, 258, 312);
				num = ⴃႰ[34] - ⴃႰ[34];
				break;
			default:
				num = (enumerator.MoveNext() ? (ⴐ[317] - 196) : 0);
				break;
			case 0:
			case 3:
				return;
			}
		}
	}

	public override string ToString()
	{
		string result = ReplyMailHelp.Ⴄ(22, null, 1057163494, 4);
		ShowWwvOptionsHelp.ႣႥ[377] = (char)((ShowWwvOptionsHelp.ႣႥ[377] - SetTalkCountHelp.Ⴅ[301]) & 0xB1);
		return result;
	}

	public void Remove(Guid id)
	{
		object obj = new ႥႰ();
		(obj as ႥႰ).Ⴍ = id;
		List.RemoveAll(((ႥႰ)obj).Ⴍ);
	}

	public void UpdateClientConnect(ClientIoCfg newCfg)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		List<ClientIoCfg>.Enumerator enumerator = List.GetEnumerator();
		try
		{
			int num = 2;
			object current = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = 12;
					continue;
				case 1:
					current = enumerator.Current;
					goto case 7;
				case 7:
					num = ((!SetStationGrid.Ⴄ(SetDxOutput.Ⴍ((ClientIoCfg)current, 780, 845), SetDxOutput.Ⴍ(newCfg, 567, 630), 785, 790)) ? 12 : (ⴅ[121] - 181));
					continue;
				case 10:
					Directory.Ⴄ(current as ClientIoCfg, BaseCmd.Ⴓ(newCfg, '\u0090', 161), 'Q', 'D');
					num = 8;
					continue;
				case 8:
					SetWwvCountHelp.Ⴗ(current as ClientIoCfg, qslinfoRequest.Ⴀ(newCfg, 491, 444), 519, 621);
					num = 0;
					continue;
				case 0:
					SetDxExtension.Ⴗ((ClientIoCfg)current, SetAnnChatRoomsHelp.Ⴓ(newCfg, 4, '2'), 108, '`');
					num = 5;
					continue;
				case 5:
					(current as ClientIoCfg).Description = newCfg.Description;
					((ClientIoCfg)current).IpAddress = newCfg.IpAddress;
					num = 4;
					continue;
				case 4:
				case 6:
					(current as ClientIoCfg).Port = newCfg.Port;
					goto case 3;
				case 3:
					((ClientIoCfg)current).Password = newCfg.Password;
					num = 11;
					continue;
				case 12:
					num = (enumerator.MoveNext() ? 1 : (ⴍႭ[184] - 40017));
					continue;
				case 11:
					break;
				}
				break;
			}
		}
		finally
		{
			switch (0)
			{
			default:
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				break;
			case 1:
				break;
			}
		}
		switch (0)
		{
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴐ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : InternalDataCollectionBase
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[198] - 166;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႭ[64] - 11936;
					continue;
				case 1:
					break;
				case 3:
					DirectoryBulletin.ႠႨ[36] = (DirectoryBulletin.ႠႨ[36] ^ P_2) & 0xF9;
					num2 = (((P_1 ^ P_2) - 19) ^ num) switch
					{
						0 => ⴃႥ[21] - 7898, 
						_ => 0, 
					};
					continue;
				case 0:
					result = null;
					num2 = 4;
					continue;
				case 10:
					result = P_0.SyncRoot;
					num2 = 4;
					continue;
				case 2:
				case 4:
					num++;
					goto case 5;
				case 5:
				{
					int num3 = 17;
					int num4 = 248;
					num2 = ((992 > num4 - num3 * 4) ? (ⴃႠ[52] - 36453) : ⴐ[257]);
					continue;
				}
				case 7:
					num2 = 3;
					continue;
				case 6:
				case 11:
					return result;
				case 9:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}
}
