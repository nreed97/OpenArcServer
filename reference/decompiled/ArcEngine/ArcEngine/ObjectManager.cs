using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcDatabase;
using ArcEngine.ArcIo;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcIo.Mirc;
using ArcEngine.ArcObjs;
using ArcEngine.ArcObjs.ArcUtils;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArxWebService;
using ArcEngine.ContestProcessing;
using ArcEngine.QslInfo;
using ArcInterfaces;
using ArcInterfaces.Io;
using ArcInterfaces.Spots;
using ArcInterfaces.Ui;
using ArcShared;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine;

public sealed class ObjectManager
{
	private static readonly ILog m_Ⴍ;

	private static readonly ObjectManager m_Ⴄ;

	private CacheManager m_Ⴈ;

	private IoDevices m_Ⴈ;

	private IUi m_Ⴐ;

	private ႷႰ m_Ⴀ;

	private ClearHelp.Ⴍ m_Ⴅ;

	public static ObjectManager Instance => ObjectManager.m_Ⴄ;

	[SpecialName]
	internal ႷႠ Ⴗ()
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		return this.m_Ⴅ.Ⴅ;
	}

	[SpecialName]
	private void Ⴍ(ႷႠ P_0)
	{
		this.m_Ⴅ.Ⴅ = P_0;
	}

	[SpecialName]
	internal ArcServerCfg Ⴍ()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		ArcServerCfg ⴍ = this.m_Ⴅ.Ⴍ;
		BandModeCacheCfg.ႠႳ[162] = (char)((BandModeCacheCfg.ႠႳ[162] | BandModeCacheCfg.ႠႳ[85]) & 0x25);
		return ⴍ;
	}

	[SpecialName]
	internal void Ⴓ(ArcServerCfg P_0)
	{
		this.m_Ⴅ.Ⴍ = P_0 as ArcServerCfg;
	}

	[SpecialName]
	internal ArcConnect Ⴓ()
	{
		return this.m_Ⴅ.Ⴗ;
	}

	[SpecialName]
	internal void Ⴃ(ArcConnect P_0)
	{
		this.m_Ⴅ.Ⴗ = P_0 as ArcConnect;
	}

	[SpecialName]
	internal CacheManager Ⴀ()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		return this.m_Ⴈ;
	}

	[SpecialName]
	private void Ⴀ(CacheManager P_0)
	{
		this.m_Ⴈ = P_0;
	}

	[SpecialName]
	internal ႳႭ Ⴐ()
	{
		return this.m_Ⴅ.Ⴄ;
	}

	[SpecialName]
	internal void Ⴈ(ႳႭ P_0)
	{
		this.m_Ⴅ.Ⴄ = P_0 as ႳႭ;
		ShowSunHelp.ႣႠ[211] = (char)((ShowSunHelp.ႣႠ[211] * ShowSunHelp.ႣႠ[210]) & 0xCF);
	}

	[SpecialName]
	internal IoDevices Ⴅ()
	{
		return this.m_Ⴈ;
	}

	[SpecialName]
	internal void Ⴅ(IoDevices P_0)
	{
		this.m_Ⴈ = P_0;
	}

	[SpecialName]
	internal ႰႼ Ⴄ()
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		ႰႼ ⴃ = this.m_Ⴅ.Ⴃ;
		DirectoryBulletin.ႠႨ[91] = (DirectoryBulletin.ႠႨ[91] + DirectoryBulletin.ႠႨ[15]) & 4;
		return ⴃ;
	}

	[SpecialName]
	internal void Ⴗ(ႰႼ P_0)
	{
		this.m_Ⴅ.Ⴃ = P_0;
	}

	[SpecialName]
	internal string Ⴃ()
	{
		return this.m_Ⴅ.Ⴓ;
	}

	[SpecialName]
	internal void Ⴐ(string P_0)
	{
		this.m_Ⴅ.Ⴓ = P_0 as string;
	}

	[SpecialName]
	internal IUi Ⴈ()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		return this.m_Ⴐ;
	}

	[SpecialName]
	internal void Ⴄ(IUi P_0)
	{
		this.m_Ⴐ = P_0;
	}

	[SpecialName]
	internal ႷႰ Ⴜ()
	{
		return this.m_Ⴀ;
	}

	[SpecialName]
	internal void Ⴜ(ႷႰ P_0)
	{
		this.m_Ⴀ = P_0;
	}

	static ObjectManager()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 4:
				ObjectManager.m_Ⴄ = new ObjectManager();
				return;
			}
			ObjectManager.m_Ⴍ = SkimmerValidSpot.Ⴐ(SetStationQth.Ⴍ(null, 1687353923, 2, 22), 713, 724);
			num = 4;
		}
	}

	private ObjectManager()
	{
		object obj = null;
		base._002Ector();
		try
		{
			UtilsDatabase.IfNotExistsCreateLocalDb();
			ႰႨ.Ⴍ();
			ႷႤ.Ⴈ();
			object obj2 = new ႰႤ();
			if (ႨႰ.Ⴄ(352, 312) && ((ႰႤ)obj2).Ⴈ())
			{
				Ⴍ(new ႷႠ());
				Ⴓ(ArcServerCfg.Init(((ႰႤ)obj2).Ⴃ()));
				Ⴀ(new CacheManager(this));
				if (ႰႨ.ႥႥ(Ⴍ().Configuration.Cont, 's', 'U'))
				{
					Ⴃ(new ArcConnect(this, ((ႰႤ)obj2).Ⴃ()));
					Ⴍ().Configuration.Cont = Ⴓ().Cont;
					Ⴍ().Configuration.Cty = Ⴓ().Cty;
					Ⴍ().Configuration.State = Ⴓ().State;
					Ⴍ().Save(saveToWebService: false);
				}
				else
				{
					Ⴃ(new ArcConnect(this, (obj2 as ႰႤ).Ⴃ(), Ⴍ().Configuration.Cont, Ⴍ().Configuration.Cty, Ⴍ().Configuration.State));
				}
				Ⴓ().ConnectState = ConnectStateType.ArxNode;
				Ⴓ().Ⴅ(true);
				Ⴓ().Id = ((ႰႤ)obj2).Ⴀ();
				Ⴜ(new ႷႰ(this));
				Ⴈ(new ႳႭ(this));
				if (!Ⴍ().Configuration.LazyLoad)
				{
					ႭႰ();
				}
				Ⴗ(new ႰႼ(this));
				WsArxNode.Ⴅ();
				ႭႳ();
				TaskFactory taskFactory = PublishInfo.Ⴅ(431, 500);
				if (!(obj is Action<object>))
				{
					obj = new Action<object>(ႳႠ);
				}
				taskFactory.StartNew((Action<object>)obj, TaskCreationOptions.None);
			}
			else
			{
				ObjectManager.m_Ⴍ.Fatal(ႰႥ.Ⴅ(2, '\u009f', 952622616));
			}
		}
		catch (Exception ex)
		{
			ObjectManager.m_Ⴍ.Fatal((ex as Exception).Message);
		}
	}

	private void ႭႷ()
	{
		Ⴓ().IpAddress = ShowHamHelp.Ⴈ(538, 'Ș');
	}

	internal void ႭႭ()
	{
		Ⴅ(new IoDevices(this));
	}

	private void ႭႳ()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				if (!ႰႨ.ႥႥ(Ⴍ().Configuration.Alias, 'ʛ', 'ʽ'))
				{
					Ⴐ(Ⴍ().Configuration.Alias);
					return;
				}
				break;
			case 1:
			case 4:
				Ⴐ(Ⴓ().Call);
				return;
			case 2:
				return;
			}
			num = 1;
		}
	}

	internal void ႭႠ()
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴍ().Save(saveToWebService: false);
				num = ((Ⴐ() == null) ? (ⴀႣ[264] - 37759) : (ⴃႠ[53] - 46724));
				break;
			case 8:
				Ⴐ().ႷႰ();
				goto case 5;
			case 5:
			case 6:
				num = ((Ⴅ() == null) ? 3 : 9);
				break;
			case 9:
				Ⴅ().Ⴐ();
				goto case 3;
			case 3:
				num = ((Ⴀ() != null) ? 7 : 0);
				break;
			case 4:
			case 7:
				Ⴀ().ႨႠ();
				return;
			case 0:
				return;
			}
		}
	}

	public void CmdTest(string call, string cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		try
		{
			int num = 5;
			object obj = default(object);
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					obj = Ⴓ().ႣႨ(call);
					goto case 0;
				case 0:
				{
					if ((ArcConnect)obj != null)
					{
						num2 = ⴍႭ[314] - 35350;
						break;
					}
					char num3 = ⴀႣ[325];
					IpLockoutCacheCfg.ႭႭ[352] = (char)((IpLockoutCacheCfg.ႭႭ[352] * IpLockoutCacheCfg.ႭႭ[206]) & 0x99);
					num2 = num3 - 15399;
					break;
				}
				case 2:
					(obj as ArcConnect).OnRx(cmd);
					return;
				case 1:
				case 3:
				case 4:
					return;
				}
				num = num2;
			}
		}
		catch (Exception)
		{
		}
	}

	public List<string> GetTelnetServerPorts()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		while (true)
		{
			int num = ((Ⴍ() == null) ? 1 : 4);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႼ[80];
					continue;
				case 0:
					break;
				case 4:
					return Ⴍ().GetTelnetServerPorts();
				case 1:
				case 2:
				case 6:
					return null;
				}
				break;
			}
		}
	}

	public List<string> GetTelnetClients()
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		while (true)
		{
			int num = ((Ⴍ() != null) ? 1 : 5);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႷ[50] - 56636;
					continue;
				case 2:
				case 3:
					break;
				case 1:
					return Ⴍ().GetTelnetClients();
				case 5:
				case 6:
					return null;
				}
				break;
			}
		}
	}

	public void Test1()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		object obj = new N1mmCallHist();
		((N1mmCallHist)obj).Process(this);
		int num = 0;
		try
		{
			int num2 = 1;
			object obj3 = default(object);
			TextReader textReader = default(TextReader);
			IComparable<string> comparable = default(IComparable<string>);
			while (true)
			{
				switch (num2)
				{
				default:
				{
					ICustomAttributeProvider customAttributeProvider = ShowLog.Ⴍ(463, 'Ǉ');
					obj3 = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(customAttributeProvider as Assembly, 649, 747), 546, 'ȷ'), ShowSkimCtyHelp.Ⴍ(1216131677, 5, '/'), 81, 31);
					break;
				}
				case 5:
					break;
				case 2:
				{
					DateTime dateTime = ShowAnnHelp.Ⴅ('\u0321', 784);
					object obj2 = new FileStream((string)obj3, FileMode.Open, FileAccess.Read);
					try
					{
						int num3 = 0;
						while (true)
						{
							switch (num3)
							{
							default:
								textReader = new StreamReader((FileStream)obj2);
								comparable = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)textReader, '\u030b', 838);
								goto case 1;
							case 1:
								num3 = ⴀႼ[113] * 3;
								continue;
							case 6:
								comparable = SetAnnModeHelp.Ⴐ((TextReader)(textReader as StreamReader), 'Ǳ', 444);
								num3 = ⴄႷ[4] - 30644;
								continue;
							case 9:
								num++;
								Ⴍ((string)comparable, dateTime, num);
								goto case 7;
							case 7:
								num3 = 4;
								continue;
							case 4:
								ShowDxHelp.Ⴄ(250, 441, 395);
								comparable = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)textReader, 'ϗ', 922);
								num3 = 8;
								continue;
							case 8:
								num3 = ((comparable is string) ? 9 : (ⴄႤ[57] - 199));
								continue;
							case 3:
								break;
							}
							break;
						}
					}
					finally
					{
						int num4 = 4;
						while (true)
						{
							int num5;
							switch (num4)
							{
							default:
								num5 = (((FileStream)obj2 == null) ? (ⴅ[330] - 77) : 6);
								goto IL_01f0;
							case 0:
							case 6:
								((IDisposable)(FileStream)obj2).Dispose();
								break;
							case 2:
							case 3:
								break;
							}
							break;
							IL_01f0:
							num4 = num5;
						}
					}
					switch (2)
					{
					default:
						num = 0;
						break;
					case 0:
					case 3:
					case 4:
						break;
					}
					goto end_IL_0033;
				}
				}
				num2 = 2;
				continue;
				end_IL_0033:
				break;
			}
		}
		catch (Exception ex)
		{
			ObjectManager.m_Ⴍ.Error((ex as Exception).Message + ႰႥ.Ⴅ(3, 'S', 952620209) + num);
		}
		switch (3)
		{
		}
	}

	private bool Ⴍ(string P_0, DateTime P_1, int P_2)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		Array array3 = default(Array);
		object obj2 = default(object);
		IComparable<string> comparable = default(IComparable<string>);
		object obj3 = default(object);
		SkimmerCt1bohCache.SkimmerQualityType skimmerQualityCt1boh = default(SkimmerCt1bohCache.SkimmerQualityType);
		IComparable<string> ct1bohFlag = default(IComparable<string>);
		Array array = default(Array);
		while (true)
		{
			object obj = new PrecisionTimer();
			ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 590, 527);
			_ = 29;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 17;
					continue;
				case 17:
					break;
				case 5:
				case 9:
				{
					Array array2 = new char[1];
					((char[])array2)[0] = ',';
					array3 = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, (char[])array2, 971, 925);
					num = 20;
					continue;
				}
				case 20:
					num = ((((string[])array3).Length != 6) ? 1 : (ⴀႣ[203] - 42467));
					continue;
				case 13:
					obj2 = new DxSpot();
					SetAnnDefaultHelp.Ⴀ((DxSpot)obj2, (array3 as string[])[1], 'υ', 'Κ');
					num = ⴅ[102] - ⴅ[142];
					continue;
				case 4:
					ShowDxOptionsHelp.Ⴍ((DxSpot)obj2, (array3 as string[])[4], 579, 553);
					num = ⴄႭ[224];
					continue;
				case 14:
					MircIo.Ⴐ((DxSpot)obj2, ShowGrayline.Ⴈ(((string[])array3)[2], 840, '\u0330'), 983, 897);
					num = 10;
					continue;
				case 10:
				case 11:
				{
					MircIo.Ⴐ((DxSpot)obj2, 20f, 872, 831);
					DxSpot obj5 = obj2 as DxSpot;
					DateTime dateTime2 = ShowAnnHelp.Ⴅ('ΐ', 929);
					ShowWx.Ⴅ(obj5, SetWwvOutput.Ⴗ(ref dateTime2, P_2, '\u00b8', 254), 161, 149);
					num = ⴃႠ[165] - 47283;
					continue;
				}
				case 12:
				{
					DxSpot obj4 = (DxSpot)obj2;
					DateTime dateTime = ShowAnnHelp.Ⴅ('ɥ', 596);
					NodeCacheCfg.Ⴄ(obj4, SetWwvOutput.Ⴗ(ref dateTime, P_2, 'Ƚ', 635), 530, 533);
					num = ⴀႣ[348] - 32295;
					continue;
				}
				case 0:
					comparable = ShowQslInfoHelp.Ⴓ(WxHelp.Ⴀ(obj2 as DxSpot, 426, 439), 58, 'I');
					num = ⴄႷ[100] - 20020;
					continue;
				case 7:
					obj3 = Ⴀ().ႤႷ().CtyInfoFromCall(comparable as string);
					num = (((CtyInfo)obj3 == null) ? 8 : (ⴄႷ[33] - 18049));
					continue;
				case 21:
				{
					WwvHelp.Ⴐ((DxSpot)obj2, qslinfoSoapClient.Ⴈ(obj3 as CtyInfo, 'ƌ', 405), 'έ', 914);
					byte num2 = ⴄႤ[487];
					byte num3 = ⴄႤ[251];
					TxNodeUserCmd.ႤႷ[17] = (char)((TxNodeUserCmd.ႤႷ[17] ^ P_2) & 9);
					num = num2 - num3;
					continue;
				}
				case 2:
					AnnSpotHelp.Ⴃ((DxSpot)obj2, SetStationMacros.Ⴐ((CtyInfo)obj3, 382, 'Ĺ'), 452, 'Ǎ');
					goto case 8;
				case 8:
				{
					string bustedKeyCall = string.Empty;
					skimmerQualityCt1boh = Ⴀ().ႨႳ().GetSkimmerQualityCt1boh(obj2 as DxSpot, out var _, out var _, out bustedKeyCall);
					num = 15;
					continue;
				}
				case 15:
					ct1bohFlag = Ⴀ().ႨႳ().GetCt1bohFlag(skimmerQualityCt1boh);
					(obj as PrecisionTimer).Stop();
					array = new object[5];
					num = 3;
					continue;
				case 3:
					((object[])array)[0] = P_2;
					(array as object[])[1] = ႰႥ.Ⴅ(4, '\u00af', 952620214);
					num = 6;
					continue;
				case 6:
					((object[])array)[2] = (obj2 as DxSpot).Call;
					(array as object[])[3] = ႰႥ.Ⴅ(8, '~', 952620218);
					goto case 16;
				case 16:
					num = 18;
					continue;
				case 18:
					(array as object[])[4] = ct1bohFlag as string;
					Console.WriteLine(string.Concat((object[])array));
					goto case 1;
				case 1:
					return false;
				}
				break;
			}
		}
	}

	public void Test2()
	{
	}

	internal CallbookData ႳႭ(string P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		return Ⴀ().UsVeCallbook.Search(P_0);
	}

	private void ႭႰ()
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				ObjectManager.m_Ⴍ.Info(SetStationClubHelp.Ⴍ(3, 3, 1747255355, null));
				break;
			case 1:
				break;
			case 0:
			case 2:
				Ⴀ().UsVeCallbook.Ⴓ();
				ObjectManager.m_Ⴍ.Info(CallBlockCacheCfg.Ⴅ(null, 2, 62056216, null));
				SetAnnChatRooms.Ⴀ[520] = (char)((SetAnnChatRooms.Ⴀ[520] + SetAnnMode.ႤႭ[607]) & 0xE9);
				return;
			case 3:
				return;
			}
			Ⴀ().Ⴓ();
			num = 0;
		}
	}

	public void StartFccVeCallsignUpdate()
	{
		object obj = new WaitCallback(ႳႳ);
		DeleteMail.Ⴃ(obj as WaitCallback, (object)this, 399, 'ǈ');
		SetWxOutput.ႣႰ[68] = (char)(SetWxOutput.ႣႰ[68] & SetWxOutput.ႣႰ[20] & 0x18);
	}

	private static void ႳႳ(object P_0)
	{
		object obj = new UsVeCallbookUpdate();
		(obj as UsVeCallbookUpdate).Process(((ObjectManager)P_0).Ⴍ().Caches.Callbook.FccUrl, ((ObjectManager)P_0).Ⴍ().Caches.Callbook.VeUrl, ((ObjectManager)P_0).Ⴍ().Caches.Callbook.BuildArc4Callbook);
	}

	internal void ႳႣ(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 12;
		BaseXmlSerializer baseXmlSerializer2 = default(BaseXmlSerializer);
		BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				Ⴀ().UsVeCallbook.Search(CallBlockCacheCfg.Ⴅ(null, 1, 62057726, null));
				num = 0;
				break;
			case 0:
				Ⴀ().UsVeCallbook.Search(ႰႥ.Ⴅ(5, '#', 952622644));
				num = 8;
				break;
			case 8:
				Ⴀ().UsVeCallbook.Search(ႨႨ.Ⴀ(13, 5, 1157906371));
				num = ⴃႥ[194] - 55714;
				break;
			case 10:
			case 11:
				Ⴀ().UsVeCallbook.Search(ႰႥ.Ⴅ(2, '<', 952622650));
				num = ⴄႤ[135];
				break;
			case 5:
				Ⴀ().UsVeCallbook.Search(ႨႨ.Ⴀ(0, 2, 1157906379));
				goto case 3;
			case 3:
				num = 13;
				break;
			case 13:
				Ⴀ().ႤႷ().CtyInfoFromCall(CallBlockCacheCfg.Ⴅ(null, 5, 62057722, null));
				num = 7;
				break;
			case 7:
				baseXmlSerializer2 = new ArcConnect(this, P_0);
				(baseXmlSerializer2 as ArcConnect).Here = ReplyMail.Ⴅ(5, 6, 1217944965);
				num = 6;
				break;
			case 6:
				((ArcConnect)baseXmlSerializer2).Ⴄ(ႨႨ.Ⴀ(10, 7, 1157905967));
				((ArcConnect)baseXmlSerializer2).SwVersion = ႰႥ.Ⴅ(0, 'õ', 952623043);
				num = 9;
				break;
			case 2:
			case 9:
				((ArcConnect)baseXmlSerializer2).Ⴓ(Ⴓ());
				(baseXmlSerializer2 as ArcConnect).ConnectState = ConnectStateType.PcxxNode;
				((ArcConnect)baseXmlSerializer2).Ⴅ(true);
				num = ⴍႭ[6] - 37955;
				break;
			case 4:
			{
				(baseXmlSerializer2 as ArcConnect).Ⴀ(true);
				baseXmlSerializer = (ArcConnect)baseXmlSerializer2;
				obj = new ClientIoCfg(ClientIoType.Arc4Passive, SetStationClubHelp.Ⴍ(6, 3, 1747255381, null), enabled: false, SetStationClubHelp.Ⴍ(6, 5, 1747255412, null), 3606, CallBlockCacheCfg.Ⴅ(null, 8, 62057719, null), P_0, string.Empty);
				char num2 = ⴃႥ[203];
				ShowQrzHelp.ႤႤ[303] = (byte)((ShowQrzHelp.ႤႤ[303] * ShowWwvOptionsHelp.ႣႥ[85]) & 0x43);
				num = num2 - 52435;
				break;
			}
			case 1:
				(baseXmlSerializer as ArcConnect).Io = new Arc4Client((IIoDeviceCfg)obj);
				Ⴓ().Ⴜ((ArcConnect)baseXmlSerializer);
				return;
			}
		}
	}

	private void ႳႠ(object P_0)
	{
		ႭႷ();
	}
}
