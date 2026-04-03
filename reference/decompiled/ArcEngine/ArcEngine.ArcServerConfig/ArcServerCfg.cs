using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
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
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcServerConfig.Io;
using ArcEngine.ArxWebService;
using ArcEngine.QslInfo;
using ArcInterfaces.Io;
using ArcShared;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcServerConfig;

[XmlRoot("ArcServer")]
public sealed class ArcServerCfg : BaseXmlSerializer
{
	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(SetStationQth.Ⴍ(null, 1687352553, 3, 9), 131, 158);

	private string Ⴍ;

	private Configuration Ⴀ;

	private PublishInfo Ⴍ;

	private PcxxCfg Ⴍ;

	private SpotProcessingCfg m_Ⴃ;

	private UserLoginRegistrationCfg m_Ⴃ;

	private StationHelp.Ⴐ Ⴄ = new StationHelp.Ⴐ();

	[Description("AR-Cluster configuration version")]
	[ReadOnly(true)]
	public string ArcCfgVersion
	{
		get
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			return this.Ⴍ;
		}
		set
		{
			this.Ⴍ = value;
		}
	}

	public CacheCfgManager Caches
	{
		get
		{
			char[] ⴀ = SetAnnChatRooms.Ⴀ;
			return Ⴄ.Ⴅ;
		}
		set
		{
			Ⴄ.Ⴅ = value;
			DirectoryBulletin.ႠႨ[194] = (DirectoryBulletin.ႠႨ[194] ^ ShowWwvOptionsHelp.ႣႥ[366]) & 7;
		}
	}

	public Configuration Configuration
	{
		get
		{
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	public HealthMonitorCfg HealthMonitor
	{
		get
		{
			return Ⴄ.Ⴓ;
		}
		set
		{
			Ⴄ.Ⴓ = value as HealthMonitorCfg;
		}
	}

	public IoDevicesCfg IoDevices
	{
		get
		{
			return Ⴄ.Ⴍ;
		}
		set
		{
			Ⴄ.Ⴍ = value;
		}
	}

	public LegalCfg Legal
	{
		get
		{
			char[] ⴃႰ = SetWxOutput.ႣႰ;
			LegalCfg ⴀ = Ⴄ.Ⴀ;
			SetTalkCountHelp.Ⴅ[4] = (byte)((SetTalkCountHelp.Ⴅ[4] ^ SetTalkCountHelp.Ⴅ[260]) & 0x8A);
			return ⴀ;
		}
		set
		{
			Ⴄ.Ⴀ = value;
		}
	}

	public LogFileCfg LogFile
	{
		get
		{
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			return Ⴄ.Ⴃ;
		}
		set
		{
			Ⴄ.Ⴃ = value as LogFileCfg;
			BandModeCacheCfg.ႠႳ[309] = (char)((BandModeCacheCfg.ႠႳ[309] ^ BandModeCacheCfg.ႠႳ[347]) & 0xE9);
		}
	}

	public PublishInfo PublishInfo
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			return this.Ⴍ;
		}
		set
		{
			this.Ⴍ = value;
		}
	}

	public PcxxCfg PcxxCfg
	{
		get
		{
			PcxxCfg ⴍ = Ⴍ;
			IpLockoutCacheCfg.ႭႭ[345] = (char)(IpLockoutCacheCfg.ႭႭ[345] & IpLockoutCacheCfg.ႭႭ[58] & 0x2D);
			return ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	public SpotProcessingCfg SpotProcessing
	{
		get
		{
			SpotProcessingCfg ⴃ = this.m_Ⴃ;
			IpLockoutCacheCfg.ႭႭ[352] = (char)((IpLockoutCacheCfg.ႭႭ[352] | IpLockoutCacheCfg.ႭႭ[377]) & 0x37);
			return ⴃ;
		}
		set
		{
			this.m_Ⴃ = value;
		}
	}

	public UserLoginRegistrationCfg LogIn
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			return this.m_Ⴃ;
		}
		set
		{
			this.m_Ⴃ = value;
		}
	}

	[XmlIgnore]
	public AppLogCfg AppLog
	{
		get
		{
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			return Ⴄ.Ⴈ;
		}
		set
		{
			Ⴄ.Ⴈ = value as AppLogCfg;
		}
	}

	public ArcServerCfg()
	{
		ArcCfgVersion = BadWordCacheCfg.Ⴍ(644, 749);
		Caches = new CacheCfgManager();
		Configuration = new Configuration();
		IoDevices = new IoDevicesCfg();
		LogIn = new UserLoginRegistrationCfg();
		LogFile = new LogFileCfg();
		Legal = new LegalCfg();
		SpotProcessing = new SpotProcessingCfg();
		PublishInfo = new PublishInfo();
		HealthMonitor = new HealthMonitorCfg();
		PcxxCfg = new PcxxCfg();
		AppLog = new AppLogCfg();
	}

	public static ArcServerCfg Init(string nodeCall)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		object obj = default(object);
		while (true)
		{
			ISerializable serializable = ShowLog.Ⴍ(134, '\u008e');
			IEquatable<string> equatable = SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(serializable as Assembly, 504, 410), 238, 'û');
			int num = ⴄႭ[447] - 74;
			while (true)
			{
				switch (num)
				{
				default:
				{
					/*OpCode not supported: LdMemberToken*/;
					char num2 = ⴄႷ[31];
					AnnCacheCfg.ႠႼ[101] = SetAnnMode.ႤႭ[333];
					num = num2 - 42314;
					continue;
				}
				case 9:
					break;
				case 1:
				case 4:
					enumerable = ShowUsersHelp.Ⴅ(equatable as string, ႰႥ.Ⴅ(2, 'Ê', 952619399), 472, 406);
					num = 5;
					continue;
				case 5:
					obj = new ArcServerCfg();
					num = ((!LogCacheCfg.Ⴗ(enumerable as string, 827, 827)) ? 12 : 0);
					continue;
				case 0:
					obj = (ArcServerCfg)ShowHamHelp.Ⴗ(SetAnnModeHelp.Ⴓ((object)(ArcServerCfg)obj, 743, 'ʭ'), enumerable as string, 'Ϝ', 930);
					num = ⴀႨ[176] - 908;
					continue;
				case 10:
					num = ((!ByeHelp.Ⴍ((obj as ArcServerCfg).ArcCfgVersion, BadWordCacheCfg.Ⴍ(901, 1004), 412, 500)) ? (ⴃႥ[321] - 16242) : 3);
					continue;
				case 3:
					((ArcServerCfg)obj).ArcCfgVersion = BadWordCacheCfg.Ⴍ(193, 168);
					((ArcServerCfg)obj).SaveToFile((string)enumerable);
					num = ⴃႥ[26] - 3093;
					continue;
				case 6:
					Ⴅ.Info(ႰႥ.Ⴅ(1, 'Å', 952619420) + (obj as ArcServerCfg).ArcCfgVersion);
					num = 11;
					continue;
				case 12:
					((ArcServerCfg)obj).Ⴃ(nodeCall);
					goto case 2;
				case 2:
					(obj as ArcServerCfg).SaveToFile(enumerable as string);
					goto case 11;
				case 11:
					Ⴅ.Info(ႰႥ.Ⴅ(8, 's', 952619354));
					return obj as ArcServerCfg;
				}
				break;
			}
		}
	}

	public void Save(bool saveToWebService)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 3;
		IComparable<string> comparable2 = default(IComparable<string>);
		while (true)
		{
			switch (num)
			{
			default:
			{
				object obj = ShowLog.Ⴍ(16, '\u0018');
				comparable2 = SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)obj, 304, 338), 74, '_');
				num = ⴄႭ[246];
				break;
			}
			case 2:
			{
				IComparable<string> comparable = (comparable2 as string) + ႰႥ.Ⴅ(8, '#', 952619405);
				SaveToFile(comparable as string);
				num = ⴅ[452] - 52;
				break;
			}
			case 1:
				num = ((!saveToWebService) ? 5 : 6);
				break;
			case 6:
				WsArxNode.Registration();
				return;
			case 5:
				return;
			}
		}
	}

	private void Ⴃ(string P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				IoDevices.LoadDefaults(P_0);
				SpotProcessing.LoadDefaults();
				break;
			case 4:
				break;
			case 1:
			case 3:
				PcxxCfg.LoadDefaults();
				return;
			}
			LogIn.LoadDefaults();
			num = ⴍႤ[267] - 50391;
		}
	}

	public List<string> GetTelnetServerPorts()
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		object obj = new List<string>();
		using (List<ServerIoCfg>.Enumerator enumerator = IoDevices.Server.List.GetEnumerator())
		{
			int num = 5;
			IIoDeviceCfg current = default(IIoDeviceCfg);
			while (true)
			{
				switch (num)
				{
				case 7:
					current = enumerator.Current;
					num = ((ReadMail.Ⴃ((ServerIoCfg)current, 89, 22) != ServerIoType.Telnet) ? 3 : (ⴀ[1] - 4018));
					continue;
				case 0:
				case 2:
				case 4:
				case 6:
					num = ((!UserLoginRegistrationCfg.Ⴈ(current as ServerIoCfg, 'ɿ', 'ȍ')) ? (ⴀႣ[42] - 30805) : 8);
					continue;
				case 8:
					((List<string>)obj).Add(SetTalkOutput.Ⴗ((ServerIoCfg)current, 92, 12).ToString());
					break;
				case 1:
					goto end_IL_0055;
				}
				num = ((!enumerator.MoveNext()) ? 1 : 7);
				continue;
				end_IL_0055:
				break;
			}
		}
		return obj as List<string>;
	}

	public List<string> GetTelnetClients()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		object obj = new List<string>();
		using (List<ClientIoCfg>.Enumerator enumerator = IoDevices.Client.List.GetEnumerator())
		{
			int num = 7;
			object current = default(object);
			while (true)
			{
				switch (num)
				{
				case 3:
					current = enumerator.Current;
					num = ((BaseCmd.Ⴓ(current as ClientIoCfg, '\u02dc', 749) == ClientIoType.Telnet) ? 5 : 2);
					continue;
				case 0:
				case 2:
				case 8:
					num = ((BaseCmd.Ⴓ(current as ClientIoCfg, 'ū', 346) != ClientIoType.TelnetExtComment) ? (ⴍႤ[122] - 64375) : (ⴀႼ[90] - 131));
					continue;
				case 5:
					num = ((!Directory.Ⴗ(current as ClientIoCfg, 587, 541)) ? (ⴍႤ[348] - 40050) : (ⴃႰ[111] - 23892));
					continue;
				case 4:
				case 6:
				{
					List<string> obj2 = (List<string>)obj;
					object obj3 = new string[5];
					(obj3 as string[])[0] = qslinfoRequest.Ⴀ(current as ClientIoCfg, 832, 791);
					(obj3 as string[])[1] = ShowWxHelp.Ⴍ('À', 985807876, 5);
					(obj3 as string[])[2] = PcxxCfg.Ⴅ((ClientIoCfg)current, 863, '\u0316').ToString();
					((string[])obj3)[3] = ShowWxHelp.Ⴍ('Q', 985807873, 0);
					(obj3 as string[])[4] = (current as ClientIoCfg).IpAddress;
					obj2.Add(string.Concat(obj3 as string[]));
					break;
				}
				case 9:
					goto end_IL_006a;
				}
				num = (enumerator.MoveNext() ? ⴐ[21] : (ⴍႭ[377] - 1553));
				continue;
				end_IL_006a:
				break;
			}
		}
		return obj as List<string>;
	}
}
