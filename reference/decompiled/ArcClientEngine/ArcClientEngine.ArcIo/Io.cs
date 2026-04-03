using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Arcx;
using ArcInterfaces.Io;
using ArcInterfaces.Spots;
using ArcShared;
using ArcShared.ArcIo.Arx;
using ArcShared.ArcIo.Tcp;
using ArcShared.ExtensionMethods;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcIo;

public sealed class Io
{
	private static readonly ILog m_Ⴈ;

	private ArcClientObjMgr m_Ⴈ;

	private readonly ConcurrentQueue<string> m_Ⴐ = new ConcurrentQueue<string>();

	private MultimediaIo m_Ⴐ;

	private FilterViewer.ႨႠ Ⴅ;

	public TelnetServerWrapper TelnetServer
	{
		get
		{
			return Ⴅ.Ⴐ;
		}
		set
		{
			Ⴅ.Ⴐ = value;
		}
	}

	public List<ArxClient> ArxClients
	{
		get
		{
			List<ArxClient> ⴄ = Ⴅ.Ⴄ;
			ႥႰ.Ⴗ[53] = (char)((ႥႰ.Ⴗ[53] - ႥႰ.Ⴗ[50]) & 0x89);
			return ⴄ;
		}
		set
		{
			Ⴅ.Ⴄ = value as List<ArxClient>;
		}
	}

	public MultimediaIo Multimedia
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			MultimediaIo ⴐ = this.m_Ⴐ;
			Bye.Ⴄ[30] = (char)((Bye.Ⴄ[30] - Bye.Ⴄ[39]) & 0xE4);
			return ⴐ;
		}
		set
		{
			this.m_Ⴐ = value;
		}
	}

	[SpecialName]
	internal ClientCfg Ⴗ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		return Ⴅ.Ⴍ;
	}

	[SpecialName]
	internal void Ⴓ(ClientCfg P_0)
	{
		Ⴅ.Ⴍ = P_0 as ClientCfg;
	}

	[SpecialName]
	internal ႥႣ Ⴃ()
	{
		ႥႣ ⴃ = Ⴅ.Ⴃ;
		ႥႰ.Ⴗ[8] = (char)((ႥႰ.Ⴗ[8] + ႥႰ.Ⴗ[118]) & 0x4C);
		return ⴃ;
	}

	[SpecialName]
	internal void Ⴃ(ႥႣ P_0)
	{
		Ⴅ.Ⴃ = P_0 as ႥႣ;
	}

	internal Io(ArcClientObjMgr P_0)
	{
		this.m_Ⴈ = P_0;
		ArxClients = new List<ArxClient>();
		object obj = new ClientIoCfg();
		ArxClients.Add(new ArxClient(obj as ClientIoCfg));
		Multimedia = new MultimediaIo(this.m_Ⴈ);
		Multimedia.Init();
		Ⴃ(new ႥႣ(this.m_Ⴈ));
		Ⴃ().Ⴄ();
	}

	internal void Ⴐ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 7;
		IIoDeviceCfg ioDeviceCfg = default(IIoDeviceCfg);
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!Ⴗ().TelnetServer.Enabled) ? 1 : (ⴅ[267] - 119));
				continue;
			case 6:
				ioDeviceCfg = new ServerIoCfg();
				UserInfo.ႥႰ(ioDeviceCfg as ServerIoCfg, this.m_Ⴈ.Cfg.TelnetServer.Port, 464, 428);
				num = ⴀႠ[122] - 49008;
				continue;
			case 2:
			case 3:
				TelnetServer = new TelnetServerWrapper(ioDeviceCfg as ServerIoCfg, this.m_Ⴈ.Cfg.Call, this.m_Ⴈ);
				num = ⴗ[90] - 35259;
				continue;
			case 0:
			case 5:
				ႳႥ.ႥႭ((TcpServer)TelnetServer, 'Ď', 275);
				break;
			case 1:
			case 4:
				break;
			}
			break;
		}
		List<ArxClient>.Enumerator enumerator = ArxClients.GetEnumerator();
		try
		{
			int num2 = 3;
			object current = default(object);
			while (true)
			{
				switch (num2)
				{
				default:
					num2 = 1;
					continue;
				case 4:
				case 5:
					current = enumerator.Current;
					goto case 0;
				case 0:
					SkimmerSpotRateGraph.ႤႰ<TcpClient, OnIoClientRxEventHandler>(current as ArxClient, Ⴄ, 716, 665);
					break;
				case 1:
				case 2:
					break;
				case 6:
					goto end_IL_0102;
				}
				num2 = (enumerator.MoveNext() ? (ⴀႠ[81] - 54676) : (ⴅ[159] - 155));
				continue;
				end_IL_0102:
				break;
			}
		}
		finally
		{
			switch (4)
			{
			default:
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				break;
			}
		}
		switch (0)
		{
		}
	}

	private void Ⴄ(string P_0)
	{
		this.m_Ⴐ.Enqueue(P_0);
	}

	public void UiThreadProcessMsgs()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 6;
		string result = default(string);
		while (true)
		{
			switch (num)
			{
			case 7:
				this.m_Ⴐ.TryDequeue(out result);
				goto case 0;
			case 0:
				num = ((result != null) ? 1 : 4);
				continue;
			case 1:
				UiThreadProcessMsg(result);
				break;
			case 3:
			case 5:
				return;
			}
			num = ((this.m_Ⴐ.Count > 0) ? (ⴗ[146] - 39753) : (ⴅ[175] - 60));
		}
	}

	public void UiThreadProcessMsg(string msg)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 1;
		object obj2 = default(object);
		bool isAtno = default(bool);
		bool isBandMode = default(bool);
		IConvertible convertible = default(IConvertible);
		object obj3 = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				if (ႳႳ.Ⴓ(msg, 'ė', 305) > 15)
				{
					goto IL_0051;
				}
				break;
			case 3:
			case 4:
				if (!ႥႤ.Ⴍ(msg, ႥႥ.Ⴅ(1673508396, null, 8), 507, 449))
				{
					break;
				}
				try
				{
					int num2 = 15;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = ((!ႥႤ.Ⴍ(msg, ClientCty.Ⴗ('P', 4, 307013049), 560, 522)) ? 18 : 12);
							continue;
						case 12:
							obj2 = new DxSpot();
							goto case 2;
						case 2:
							HighlightStateCfg.ႣႰ(obj2 as DxSpot, msg, 34, 64);
							WxFilters.ႭႣ(obj2 as DxSpot, this.m_Ⴈ.Caches.Ⴗ().Ⴈ(FilterViewer.ႨႥ((DxSpot)obj2, 450, 'Ǣ')), 'ǣ', 'ƫ');
							num2 = ⴗ[146] - 39752;
							continue;
						case 8:
						case 21:
							isAtno = this.m_Ⴈ.Caches.Dxcc.Ⴄ(ႳႥ.ႥႥ(obj2 as DxSpot, 947, 904));
							num2 = ⴄ[146] - 18546;
							continue;
						case 7:
						{
							DxccCache dxcc = this.m_Ⴈ.Caches.Dxcc;
							string text = ႳႥ.ႥႥ(obj2 as DxSpot, 963, 1016);
							float num3 = HighlightCqZoneCfg.ႣႣ((DxSpot)obj2, 292, 'Ţ');
							isBandMode = dxcc.Ⴐ(text, SetDxFilter.Ⴄ(ref num3, ႥႥ.Ⴅ(1673508405, null, 8), 533, 611), FilterViewer.ႨႥ((DxSpot)obj2, 359, 'Ņ'));
							num2 = 3;
							continue;
						}
						case 3:
							this.m_Ⴈ.Caches.Dx.AddSpot((DxSpot)obj2, isAtno, isBandMode);
							num2 = 4;
							continue;
						case 4:
							convertible = FilterViewer.ႨႣ((DxSpot)obj2, 801, '\u0350');
							TelnetServer.Ⴐ((string)convertible, (DxSpot)obj2);
							num2 = ⴀႠ[86] - 44435;
							continue;
						case 17:
							Multimedia.Ⴓ(obj2 as DxSpot);
							Ⴃ().Ⴅ((string)convertible);
							num2 = ⴄ[114];
							continue;
						case 22:
							this.m_Ⴈ.Caches.Dx.Ⴓ();
							goto case 18;
						case 18:
							num2 = (ႥႤ.Ⴍ(msg, ႥႥ.Ⴅ(1673508414, null, 7), 344, 354) ? 5 : 0);
							continue;
						case 5:
						{
							object obj4 = new ArcLogInRqst();
							HighlightStateCfg.ႣႠ((ArcLogInRqst)obj4, msg, 395, 'Ʋ');
							goto case 19;
						}
						case 19:
							Ⴈ(this.m_Ⴈ, ArxClients[0]);
							goto case 0;
						case 0:
							num2 = ((!ႥႤ.Ⴍ(msg, WxFilters.Ⴀ(null, 5, 103388869), 343, 365)) ? (ⴄ[10] - 7013) : 13);
							continue;
						case 13:
							obj3 = new WwvSpot();
							HighlightSpotterCfg.Ⴜ((WwvSpot)obj3, msg, 998, 997);
							this.m_Ⴈ.Caches.Wwv.Ⴅ(obj3 as WwvSpot);
							num2 = 16;
							continue;
						case 16:
							TelnetServer.Ⴜ(obj3 as WwvSpot);
							goto case 6;
						case 6:
							num2 = ((!ႥႤ.Ⴍ(msg, WxFilters.Ⴀ(null, 3, 103388916), 344, 354)) ? (ⴅ[281] / 7) : 9);
							continue;
						case 9:
							obj = new AnnWxSpot();
							TelnetServerCfg.Ⴜ((AnnWxSpot)obj, msg, 583, 'ɵ');
							((AnnWxSpot)obj).GetUserString();
							num2 = 20;
							continue;
						case 20:
							num2 = ((!((obj as AnnWxSpot).WxFlag == ႥႥ.Ⴅ(1673508414, null, 3))) ? (ⴅ[285] / 5) : (ⴗ[0] - 29149));
							continue;
						case 10:
							this.m_Ⴈ.Caches.Ann.Ⴀ((AnnWxSpot)obj);
							TelnetServer.Ⴍ(obj as AnnWxSpot);
							num2 = 14;
							continue;
						case 1:
							this.m_Ⴈ.Caches.Wx.Ⴃ(obj as AnnWxSpot);
							TelnetServer.Ⴀ(obj as AnnWxSpot);
							break;
						case 14:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Io.m_Ⴈ.WarnFormat((ex as Exception).Message + WxFilters.Ⴀ(null, 3, 103387428) + msg.Substring(0, 20));
				}
				break;
			}
			break;
			IL_0051:
			num = ⴅ[407] - 231;
		}
		switch (0)
		{
		}
	}

	private static void Ⴈ(ArcClientObjMgr P_0, ArxClient P_1)
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 2;
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 1:
				obj = ClientCty.ႠႥ(obj2 as ArcLogInResp, 644, 760);
				break;
			case 4:
				break;
			case 0:
			case 3:
				return;
			}
			break;
			IL_0023:
			obj2 = new ArcLogInResp(P_0.Cfg.Call, P_0.Cfg.Alias, WxFilters.Ⴀ(null, 6, 103388910), ClientCty.Ⴗ('\u008d', 0, 307013035));
			num = ⴄ[171] - 40010;
		}
		P_1.Send((string)obj);
	}

	public void Disconnect()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 2;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num2 = ((!ႳႥ.ႥႰ((TcpClient)ArxClients[0], 752, 675)) ? (ⴀႠ[44] - 48728) : 4);
				break;
			case 3:
			case 4:
				HighlightCqZoneCfg.ႣႰ((TcpClient)ArxClients[0], (short)89, (short)33);
				Thread.Sleep(250);
				return;
			case 0:
			case 1:
				return;
			}
			num = num2;
		}
	}

	public void Connect(ArcClientConnectDat arcServerConnect)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				num = (DxSpotRates.ႠႼ(arcServerConnect.Call, 'Μ', '\u0380') ? ⴅ[285] : (ⴗ[0] - 29155));
				break;
			case 4:
			case 6:
			case 7:
				num = ((!DxCommentExtCfg.ႤႰ(FilterViewer.ႨႷ(arcServerConnect.Call, 617, 578), ႥႥ.Ⴍ(0, 1580609060, 'M', null), '\u00a0', 133)) ? 9 : 5);
				break;
			case 5:
				AnnFilters.Ⴃ((TcpClient)ArxClients[0], (short)856, (short)836).ConnectTo = arcServerConnect.Call;
				num = 8;
				break;
			case 8:
				AnnFilters.Ⴃ((TcpClient)ArxClients[0], (short)105, (short)117).IpAddress = arcServerConnect.Url;
				num = ⴀႠ[115] - 48716;
				break;
			case 1:
				AnnFilters.Ⴃ((TcpClient)ArxClients[0], (short)579, (short)607).ConnectAs = this.m_Ⴈ.Cfg.Call;
				num = ⴀႠ[26] - 10579;
				break;
			case 2:
				ArxClients[0].IoCfg.Port = arcServerConnect.Port;
				ArxClients[0].Connect();
				return;
			case 3:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static Io()
	{
		ArcClientConnectDat.Ⴍ();
		Io.m_Ⴈ = HighlightItuZoneCfg.Ⴓ(WxFilters.Ⴀ(null, 6, 103388804), 890, 842);
	}
}
