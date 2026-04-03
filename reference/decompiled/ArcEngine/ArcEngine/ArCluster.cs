using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
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
using ArcInterfaces;
using ArcInterfaces.Io;
using ArcInterfaces.Spots;
using ArcInterfaces.Ui;
using ArcShared;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.DxAtlas;
using log4net;
using Ⴈ;

namespace ArcEngine;

public sealed class ArCluster
{
	private static readonly ILog Ⴅ;

	private static readonly ArCluster Ⴍ;

	private SetDxCount.Ⴃ Ⴈ;

	public string Call
	{
		get
		{
			char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
			string call = Ⴈ.Ⴐ.Ⴓ().Call;
			SetAnnMode.ႤႭ[427] = (byte)((SetAnnMode.ႤႭ[427] * ႨႣ.Ⴐ[3]) & 0x4E);
			return call;
		}
	}

	public Guid Id
	{
		get
		{
			Guid id = Ⴈ.Ⴐ.Ⴓ().Id;
			TxNodeUserCmd.ႤႷ[133] = (char)(TxNodeUserCmd.ႤႷ[133] & Arc4ServerClient.ႠႣ[111] & 0x8A);
			return id;
		}
	}

	public IUi Ui
	{
		get
		{
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			return Ⴈ.Ⴐ.Ⴈ();
		}
		set
		{
			Ⴈ.Ⴐ.Ⴄ(value);
		}
	}

	public static ArCluster Instance => Ⴍ;

	static ArCluster()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 3:
				Ⴍ = new ArCluster();
				return;
			case 1:
				return;
			}
			Ⴅ = SkimmerValidSpot.Ⴐ(ReplyMailHelp.Ⴄ(24, null, 1057161392, 4), 13, 16);
			num = 3;
		}
	}

	private ArCluster()
	{
		Ⴅ.Info(AnnHelp.Ⴈ(SetStationQth.Ⴍ(null, 1687352288, 5, 11), BadWordCacheCfg.Ⴍ(57, 80), SetStationQth.Ⴍ(null, 1687352204, 4, 25), 703, 'ʈ'));
		object instance = ObjectManager.Instance;
		Ⴈ.Ⴐ = instance as ObjectManager;
		Ⴅ.Info(ReplyMail.Ⴅ(5, 1, 1217945438) + Ⴈ.Ⴐ.Ⴓ().Call);
	}

	public void InitIoDevices()
	{
		Ⴈ.Ⴐ.ႭႭ();
	}

	public void ShutDown()
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴅ.Info(AnnHelp.Ⴈ(SetStationQth.Ⴍ(null, 1687352292, 1, 6), BadWordCacheCfg.Ⴍ(950, 991), SetTalkCount.Ⴗ(4, null, 1267023847, typeof(SetAnnFilter)), 146, '¥'));
				break;
			case 4:
				break;
			case 0:
			case 1:
				Ⴈ.Ⴐ.ႭႠ();
				return;
			}
			num = ⴄႷ[58] - 48429;
		}
	}

	public bool DisconnectById(Guid id)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		while (true)
		{
			object obj = Ⴈ.Ⴐ.Ⴓ().ႣႠ(id);
			int num = (((ArcConnect)obj == null) ? 6 : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႭ[246];
					continue;
				case 2:
					break;
				case 0:
					((ArcConnect)obj).ႳႨ();
					goto case 3;
				case 3:
					return true;
				case 1:
				case 4:
				case 6:
					return false;
				}
				break;
			}
		}
	}

	public ArcConnect GetArcBaseById(Guid id)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		ArcConnect result = Ⴈ.Ⴐ.Ⴓ().ႣႠ(id);
		SetDxCountHelp.ႭႤ[248] = (SetDxCountHelp.ႭႤ[248] + SetDxCountHelp.ႭႤ[113]) & 0x9A;
		return result;
	}

	public void CmdTest(string call, string cmd)
	{
		Ⴈ.Ⴐ.CmdTest(call, cmd);
	}

	public void Test1()
	{
		Ⴈ.Ⴐ.Test1();
	}

	public void Test2()
	{
		Ⴈ.Ⴐ.Test2();
	}

	public CallbookData CallbookSearch(string call)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		CallbookData result = Ⴈ.Ⴐ.ႳႭ(call);
		IpLockoutCacheCfg.ႭႭ[222] = (char)((IpLockoutCacheCfg.ႭႭ[222] - IpLockoutCacheCfg.ႭႭ[250]) & 0x54);
		return result;
	}

	public List<string> GetTelnetServerPorts()
	{
		return Ⴈ.Ⴐ.GetTelnetServerPorts();
	}

	public BindingList<IIoClient> GetActiveServerClients(string filter)
	{
		return Ⴈ.Ⴐ.Ⴀ().Ⴀ().Ⴄ(Ⴈ.Ⴐ.Ⴓ(), filter);
	}

	public void AddClientIoProviderCfg(ClientIoCfg cfg)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
				Ⴈ.Ⴐ.Ⴍ().Save(saveToWebService: false);
				ShowWwvOptionsHelp.ႣႥ[56] = (char)(ShowWwvOptionsHelp.ႣႥ[56] & ShowWwvOptionsHelp.ႣႥ[27] & 0xEC);
				return;
			case 1:
				return;
			}
			Ⴈ.Ⴐ.Ⴍ().IoDevices.Client.List.Add(cfg);
			num = 0;
		}
	}

	public void EnableClientConnect(ClientIoCfg device)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 0:
				Ⴈ.Ⴐ.Ⴍ().Save(saveToWebService: false);
				Ⴈ.Ⴐ.Ⴅ().Ⴗ(device, Ⴈ.Ⴐ);
				return;
			case 1:
			case 2:
				return;
			}
			Ⴈ.Ⴐ.Ⴍ().IoDevices.Client.EnableDisableClient(SetDxOutput.Ⴍ(device, 284, 349), enabled: true);
			num = ⴐ[21] - 3;
		}
	}

	public void DisableClientConnect(Guid id)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴈ.Ⴐ.Ⴍ().IoDevices.Client.EnableDisableClient(id, enabled: false);
				break;
			case 0:
				break;
			case 1:
			case 2:
			case 3:
				Ⴈ.Ⴐ.Ⴍ().Save(saveToWebService: false);
				Ⴈ.Ⴐ.Ⴓ().ႣႰ(id);
				return;
			}
			num = ⴍႤ[286] - 3316;
		}
	}

	public void DisconnectClientConnect(Guid ioId)
	{
		BaseXmlSerializer baseXmlSerializer = Ⴈ.Ⴐ.Ⴓ().ႣႣ(ioId);
		((ArcConnect)baseXmlSerializer).Io.Disconnect();
		Arc4ServerClient.ႠႣ[336] = (char)(Arc4ServerClient.ႠႣ[336] & Arc4ServerClient.ႠႣ[23] & 0x7D);
	}

	public BindingList<IIoClient> GetEnabledClients()
	{
		return Ⴈ.Ⴐ.Ⴀ().Ⴀ().Ⴍ(Ⴈ.Ⴐ.Ⴓ());
	}

	public BindingList<ClientIoCfg> GetDisabledClientCfgs()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		return Ⴈ.Ⴐ.Ⴀ().Ⴀ().Ⴀ(Ⴈ.Ⴐ);
	}

	public ArcServerCfg GetArcServerCfg()
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		return Ⴈ.Ⴐ.Ⴍ();
	}

	public List<DxSpotRate> GetDxSpotRate()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		return Ⴈ.Ⴐ.Ⴀ().Ⴀ().Ⴈ(Ⴈ.Ⴐ.Ⴓ());
	}

	public void RemoveClientConnect(Guid id)
	{
		Ⴈ.Ⴐ.Ⴍ().IoDevices.Client.Remove(id);
	}

	public void UpdateClientConnect(ClientIoCfg clientIoProviderCfg)
	{
		Ⴈ.Ⴐ.Ⴍ().IoDevices.Client.UpdateClientConnect(clientIoProviderCfg);
	}

	public StatusBarData GetStatusBarData()
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		return ႷႷ.Ⴓ(Ⴈ.Ⴐ);
	}

	public bool IsValidDxFilter(string filter, out string newFilter)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		IEquatable<string> equatable = default(IEquatable<string>);
		bool flag = default(bool);
		while (true)
		{
			newFilter = string.Empty;
			IConvertible convertible = SetStationGrid.Ⴍ(filter, 390, 'ǔ');
			while (true)
			{
				IL_0084:
				convertible = LogEntry.Ⴄ(convertible as string, 'ζ', 925);
				int num = ⴀႼ[136] + 4;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴀႳ[350] - 4116;
						continue;
					case 0:
					case 8:
						break;
					case 7:
						goto IL_0084;
					case 9:
						equatable = Ⴈ.Ⴐ.Ⴀ().Ⴃ().FormatSqlFilter((string)convertible);
						goto case 2;
					case 2:
						num = 1;
						continue;
					case 1:
						flag = Ⴈ.Ⴐ.Ⴀ().Ⴃ().Ⴅ(equatable as string);
						num = ⴄႤ[514] - 124;
						continue;
					case 6:
						num = ((!flag) ? (ⴍႤ[81] - 29125) : 5);
						continue;
					case 5:
						newFilter = equatable as string;
						num = ⴃႰ[122] - 21836;
						continue;
					case 3:
						return flag;
					}
					break;
				}
				break;
			}
		}
	}

	public bool IsValidAnnFilter(string filter, out string newFilter)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		bool flag = default(bool);
		while (true)
		{
			newFilter = string.Empty;
			while (true)
			{
				IL_0054:
				IEnumerable enumerable = SetStationGrid.Ⴍ(filter, 46, '|');
				object obj = Ⴈ.Ⴐ.Ⴀ().Ⴄ().FormatSqlFilter(enumerable as string);
				int num = 7;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 8;
						continue;
					case 8:
						break;
					case 6:
						goto IL_0054;
					case 4:
					case 7:
						flag = Ⴈ.Ⴐ.Ⴀ().Ⴄ().Ⴄ(obj as string);
						num = ⴀႨ[64] - 60336;
						continue;
					case 5:
					{
						bool num2 = flag;
						BandModeCacheCfg.ႠႳ[224] = (char)((BandModeCacheCfg.ႠႳ[224] + SetAnnMode.ႤႭ[549]) & 0xEA);
						num = ((!num2) ? (ⴃႥ[396] - 28317) : 3);
						continue;
					}
					case 3:
						newFilter = obj as string;
						num = ⴀႳ[122] - 25885;
						continue;
					case 1:
						return flag;
					}
					break;
				}
				break;
			}
		}
	}

	public bool IsValidWxFilter(string filter, out string newFilter)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool flag = default(bool);
		while (true)
		{
			newFilter = string.Empty;
			IEnumerable<char> enumerable = SetStationGrid.Ⴍ(filter, 524, 'ɞ');
			while (true)
			{
				IL_0073:
				IEquatable<string> equatable = Ⴈ.Ⴐ.Ⴀ().Ⴄ().FormatSqlFilter((string)enumerable);
				int num = ⴀႨ[116] - 13793;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴐ[243];
						continue;
					case 8:
						break;
					case 5:
						goto IL_0073;
					case 0:
						flag = Ⴈ.Ⴐ.Ⴀ().Ⴈ().Ⴓ((string)equatable);
						num = ⴄႤ[76] - 86;
						continue;
					case 4:
						num = ((!flag) ? 2 : (ⴃႰ[147] - 1275));
						continue;
					case 7:
						newFilter = equatable as string;
						num = 2;
						continue;
					case 2:
					case 3:
						return flag;
					}
					break;
				}
				break;
			}
		}
	}

	public void UpdateUserConfig(Guid id, ArcUserCfg _clonedArcUserCfg)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 4;
		BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				baseXmlSerializer = Ⴈ.Ⴐ.Ⴓ().ႣႠ(id);
				num2 = (((ArcConnect)baseXmlSerializer == null) ? (ⴀႼ[50] - 99) : 2);
				break;
			case 2:
			case 5:
				(baseXmlSerializer as ArcConnect).Cfg = _clonedArcUserCfg;
				Ⴈ.Ⴐ.Ⴀ().ႨႣ().Ⴐ((ArcConnect)baseXmlSerializer);
				return;
			case 1:
				return;
			}
			num = num2;
		}
	}

	public void StartFccVeCallsignUpdate()
	{
		Ⴈ.Ⴐ.StartFccVeCallsignUpdate();
	}

	public List<DxAtlasData> GetDxAtlasConnectData()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		return Ⴈ.Ⴐ.Ⴀ().Ⴀ().Ⴓ(Ⴈ.Ⴐ.Ⴓ());
	}

	public void AddPcxxNode(string nodeCall)
	{
		Ⴈ.Ⴐ.ႳႣ(nodeCall);
	}

	public void LogDxDupes(bool action)
	{
		Ⴈ.Ⴐ.Ⴍ().AppLog.LogDxDupes = action;
	}

	public void LogTelnetInboundTraffic(bool action)
	{
		Ⴈ.Ⴐ.Ⴍ().AppLog.LogTelnetInboundTraffic = action;
	}

	public void LogTelnetOutboundTraffic(bool action)
	{
		Ⴈ.Ⴐ.Ⴍ().AppLog.LogTelnetOutboundTraffic = action;
	}

	public void LogArc6NodeTraffic(bool action)
	{
		Ⴈ.Ⴐ.Ⴍ().AppLog.LogArc6NodeTraffic = action;
		ShowSunHelp.ႣႠ[247] = (char)((ShowSunHelp.ႣႠ[247] + ShowSunHelp.ႣႠ[246]) & 0xC9);
	}

	public void LogArc6ClientTraffic(bool action)
	{
		Ⴈ.Ⴐ.Ⴍ().AppLog.LogArc6ClientTraffic = action;
	}

	public void LogAgwBpqTraffic(bool action)
	{
		Ⴈ.Ⴐ.Ⴍ().AppLog.LogAgwBpqTraffic = action;
	}

	public void LogPcxxTraffic(bool action)
	{
		Ⴈ.Ⴐ.Ⴍ().AppLog.LogPcxxTraffic = action;
	}

	public void LogAnnWxDupes(bool action)
	{
		Ⴈ.Ⴐ.Ⴍ().AppLog.LogAnnWxDupes = action;
	}

	public void LogWwvDupes(bool action)
	{
		Ⴈ.Ⴐ.Ⴍ().AppLog.LogWwvDupes = action;
	}

	public CtyInfo CtyInfoFromCall(string callsign)
	{
		return Ⴈ.Ⴐ.Ⴀ().ႤႷ().CtyInfoFromCall(callsign);
	}

	public DataTable QueryDxCache(string sql, int nmbrSpots)
	{
		throw new NotImplementedException();
	}
}
