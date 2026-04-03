using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Dx;
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
using ArcEngine.ArxWebService;
using ArcEngine.QslInfo;
using ArcInterfaces;
using ArcInterfaces.Arcx;
using ArcInterfaces.Spots;
using ArcInterfaces.Ui;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcObjs;

public static class ArxProtocol
{
	private static readonly ILog Ⴓ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216131022, 1, 'Ü'), 228, 249);

	public static void OnRx(ArcConnect arcBase, string msg)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		try
		{
			int num = 5;
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
				{
					IEnumerable enumerable2 = LogEntry.Ⴄ(msg, 'Ⱦ', 531);
					num = (((enumerable = enumerable2 as string) == null) ? 10 : (ⴄႭ[376] - 95));
					break;
				}
				case 2:
				case 9:
					num = (ByeHelp.Ⴍ(enumerable as string, SetTalkCount.Ⴗ(5, null, 1267014114, typeof(ShowWxOptions)), 530, 629) ? (ⴃႰ[187] - 57510) : (ⴍႭ[226] - 11083));
					break;
				case 7:
					num = (ByeHelp.Ⴍ((string)enumerable, ႰႥ.Ⴅ(3, 'ó', 952616636), 403, 500) ? (ⴀ[115] - 47501) : 3);
					break;
				case 3:
					num = 10;
					break;
				case 1:
					OnRxArcLogInRqst(arcBase, msg);
					num = ⴍႭ[43] - 57284;
					break;
				case 0:
				case 4:
					OnRxArcLogInResp(arcBase, msg);
					goto case 6;
				case 6:
					num = ⴍႤ[72] - 6261;
					break;
				case 10:
				{
					object obj = new ႨႭ(arcBase.Ⴅ());
					(obj as ႨႭ).Ⴓ(msg, arcBase);
					return;
				}
				case 8:
					return;
				}
			}
		}
		catch (Exception)
		{
			Ⴓ.Warn(arcBase.Io.IoCfg.Description + ShowSkimCtyHelp.Ⴍ(1216134121, 2, '¬') + arcBase.Call);
		}
	}

	public static void OnRxArcLogInRqst(ArcConnect arcBase, string xml)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 4;
		object obj3 = default(object);
		object obj2 = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj3 = new ArcLogInRqst();
				ShowNodesHelp.Ⴀ(obj3 as ArcLogInRqst, xml, 196, 217);
				arcBase.Call = qslinfoRequest.Ⴍ(obj3 as ArcLogInRqst, 'Ϳ', 819);
				num = 10;
				break;
			case 10:
				SetStationQthHelp.Ⴀ(arcBase.Cfg, qslinfoRequest.Ⴍ(obj3 as ArcLogInRqst, 'Ģ', 366), 879, '\u0332');
				num = 5;
				break;
			case 5:
				arcBase.Ⴀ(true);
				arcBase.Ⴅ(true);
				Ⴓ.Info(AnnHelp.Ⴈ(arcBase.Io.IoCfg.Description, ShowSkimCtyHelp.Ⴍ(1216134120, 3, '8'), arcBase.Call, 261, 'Ĳ'));
				num = ⴃႰ[136] - 29123;
				break;
			case 9:
				obj2 = new LogEntry(arcBase.Io.IoCfg, arcBase.Call, ShowSkimCtyHelp.Ⴍ(1216135071, 0, 'ò'));
				num = 0;
				break;
			case 0:
			case 3:
				arcBase.Ⴅ().Ⴀ().Ⴐ()
					.Add((LogEntry)obj2);
				num = ((arcBase.Ⴅ().Ⴈ() == null) ? 2 : 7);
				break;
			case 7:
				arcBase.Ⴅ().Ⴈ().AddLocalConnect(new LocalConnect(arcBase.Call, arcBase.Id, UiConnectType.Arc6NodeOut));
				goto case 2;
			case 2:
				obj = new ArcLogInResp(arcBase.Ⴅ().Ⴓ().Call, string.Empty, ShowSkimCtyHelp.Ⴍ(1216132523, 1, 'M'), SetStationClubHelp.Ⴍ(4, 2, 1747263192, null));
				num = ⴃႰ[46] - 49481;
				break;
			case 1:
			case 8:
			{
				IComparable<string> comparable = ((ArcLogInResp)obj).SerializeNode();
				arcBase.ႠႰ(comparable as string);
				return;
			}
			}
		}
	}

	public static void OnRxArcLogInResp(ArcConnect arcBase, string xml)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 11;
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new ArcLogInResp();
				ShowPrefix.Ⴗ((ArcLogInResp)obj, xml, 'Ț', 594);
				arcBase.Call = AnnHelp.Ⴓ((ArcLogInResp)obj, 180, 246);
				goto case 7;
			case 7:
				num = ⴅ[482] - ⴅ[77];
				continue;
			case 1:
				SetStationQthHelp.Ⴀ(arcBase.Cfg, AnnHelp.Ⴓ((ArcLogInResp)obj, 326, 260), 7, 'Z');
				num = 4;
				continue;
			case 4:
				arcBase.Ⴐ(ႰႨ.ႥႳ(obj as ArcLogInResp, 952, 914));
				arcBase.Ⴀ(true);
				goto case 6;
			case 6:
				num = ⴀႣ[208] - 49327;
				continue;
			case 2:
			{
				arcBase.Ⴅ(true);
				Ⴓ.Info(AnnHelp.Ⴈ(arcBase.Io.IoCfg.Description, ShowSkimCtyHelp.Ⴍ(1216134125, 6, '\u0011'), arcBase.Call, 832, 'ͷ'));
				byte num2 = ⴐ[21];
				BandModeCacheCfg.ႠႳ[286] = (char)((BandModeCacheCfg.ႠႳ[286] + BandModeCacheCfg.ႠႳ[60]) & 0x5D);
				num = num2 * 3;
				continue;
			}
			case 9:
				obj2 = new LogEntry(arcBase.Io.IoCfg, arcBase.Call, ShowSkimCtyHelp.Ⴍ(1216135064, 7, 'L'));
				num = 3;
				continue;
			case 3:
				arcBase.Ⴅ().Ⴀ().Ⴐ()
					.Add((LogEntry)obj2);
				goto case 5;
			case 5:
				if (arcBase.ConnectState == ConnectStateType.ArxClient)
				{
					num = 8;
					continue;
				}
				while (true)
				{
					switch ((arcBase.Ⴅ().Ⴈ() == null) ? (ⴀႳ[226] - 25855) : (ⴍႭ[188] - 38427))
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 3:
						break;
					case 2:
						arcBase.Ⴅ().Ⴈ().AddLocalConnect(new LocalConnect(arcBase.Call, arcBase.Id, UiConnectType.Arc6NodeIn));
						return;
					case 5:
						return;
					}
				}
			case 8:
				WsArxNode.Ⴍ(arcBase);
				num = ((arcBase.Ⴅ().Ⴈ() == null) ? (ⴀႨ[122] - 31847) : 0);
				continue;
			case 0:
				arcBase.Ⴅ().Ⴈ().AddLocalConnect(new LocalConnect(arcBase.Call, arcBase.Id, UiConnectType.Arc6ClientIn));
				break;
			case 10:
				break;
			}
			break;
		}
		Ⴍ(arcBase);
	}

	private static void Ⴍ(ArcConnect P_0)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		try
		{
			int num = 8;
			ISerializable dataTable = default(ISerializable);
			int num2 = default(int);
			object obj2 = default(object);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					dataTable = P_0.Ⴅ().Ⴀ().Ⴍ()
						.GetDataTable(SetStationClubHelp.Ⴍ(1, 6, 1747258270, null), 5);
					num = 0;
					continue;
				case 0:
					num = (((DataTable)dataTable == null) ? (ⴀႨ[195] - 50770) : (ⴀ[293] - 65027));
					continue;
				case 11:
					num = ((DxSpotUserHelp.Ⴃ((InternalDataCollectionBase)ShowHeading.Ⴗ((DataTable)dataTable, '\u009b', 155), (short)904, (short)981) <= 0) ? 5 : (ⴃႥ[41] - 51153));
					continue;
				case 4:
					num2 = 0;
					num = 3;
					continue;
				case 1:
					obj2 = qslinfoRequestBody.Ⴍ(ShowHeading.Ⴗ(dataTable as DataTable, 'Κ', 922), num2, '\u0338', 799);
					goto case 12;
				case 12:
					num = ⴃႥ[162] - 54110;
					continue;
				case 2:
				case 9:
					obj = new WwvSpot(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ((DataRow)obj2, SetStationQth.Ⴍ(null, 1687351657, 6, 29), 709, 'ʋ'), 'ŵ', 286), UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(obj2 as DataRow, CallBlockCacheCfg.Ⴅ(null, 2, 62057835, null), 499, 'ƽ'), 'f', 13), UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ((DataRow)obj2, ReplyMailHelp.Ⴄ(18, null, 1057162206, 5), 955, 'ϵ'), 'Χ', 972), UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(obj2 as DataRow, ႨႨ.Ⴀ(6, 3, 1157903486), 600, 'Ȗ'), '\u02dd', 694), UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ((DataRow)obj2, ReplyMailHelp.Ⴄ(18, null, 1057162070, 4), 139, 'Å'), '\u0084', 239), ((DataRow)obj2)[CallBlockCacheCfg.Ⴅ(null, 4, 62057999, null)].ToString(), string.Empty, string.Empty, Convert.ToDateTime((obj2 as DataRow)[SetStationQth.Ⴍ(null, 1687351808, 6, 18)].ToString()));
					goto case 7;
				case 7:
					num = 6;
					continue;
				case 6:
				{
					IEnumerable<char> enumerable = (obj as WwvSpot).SerializeUser();
					P_0.ႠႰ((string)enumerable);
					num2++;
					num = ⴄႷ[90] - 34330;
					continue;
				}
				case 3:
					num = ((num2 < (dataTable as DataTable).Rows.Count) ? 1 : (ⴃႰ[1] - 1019));
					continue;
				case 5:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴓ.Warn(ex.Message);
		}
		switch (4)
		{
		}
	}
}
