using System;
using System.Threading;
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
using ArcEngine.ArcObjs.ArcUtils;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.MaintenanceUpdates;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcDatabase;

public sealed class ArcNodeMaintenance
{
	private static readonly ILog Ⴍ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216133951, 0, 'Û'), 673, 700);

	private readonly ObjectManager Ⴅ;

	internal ArcNodeMaintenance(ObjectManager P_0)
	{
		Ⴅ = P_0;
	}

	public void Process()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 1;
		DateTime dateTime = default(DateTime);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				dateTime = ShowAnnHelp.Ⴅ('ƺ', 395);
				goto case 3;
			case 3:
			{
				if (SetDxModeHelp.Ⴗ(ref dateTime, 395, 'ƽ') == Ⴅ.Ⴍ().Configuration.ScheduledMaintenanceHour)
				{
					goto IL_0060;
				}
				MulticastDelegate multicastDelegate = new WaitCallback(DxPurgeTask);
				ThreadPool.QueueUserWorkItem((WaitCallback)multicastDelegate, Ⴅ);
				return;
			}
			case 4:
				obj = new WaitCallback(NodeMaintTask);
				break;
			case 0:
				break;
			}
			break;
			IL_0060:
			num = ⴀႼ[96];
		}
		DeleteMail.Ⴃ(obj as WaitCallback, (object)Ⴅ, 305, 'Ŷ');
		AnnCacheCfg.ႠႼ[135] = (byte)(AnnCacheCfg.ႠႼ[135] & AnnCacheCfg.ႠႼ[70] & 0xC5);
	}

	private static void DxPurgeTask(object _om)
	{
		try
		{
			ObjectManager objectManager = (ObjectManager)_om;
			DxMaintenance.Ⴐ(objectManager.Ⴍ());
		}
		catch (Exception ex)
		{
			Ⴍ.Error(SkimmerSpotBins.Ⴈ(ex, 127, 81));
		}
	}

	private static void NodeMaintTask(object _om)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		try
		{
			int num = 49;
			ObjectManager objectManager = default(ObjectManager);
			CtyUpdate ctyUpdate = default(CtyUpdate);
			LotwUpdate lotwUpdate = default(LotwUpdate);
			MasterCallUpdate masterCallUpdate = default(MasterCallUpdate);
			BandModeUpdate bandModeUpdate = default(BandModeUpdate);
			FocUpdate focUpdate = default(FocUpdate);
			Top100Update top100Update = default(Top100Update);
			BadWordUpdate badWordUpdate = default(BadWordUpdate);
			DxSpotBlockUpdate dxSpotBlockUpdate = default(DxSpotBlockUpdate);
			IpLockoutUpdate ipLockoutUpdate = default(IpLockoutUpdate);
			CallBlockUpdate callBlockUpdate = default(CallBlockUpdate);
			ConnectBlockUpdate connectBlockUpdate = default(ConnectBlockUpdate);
			while (true)
			{
				switch (num)
				{
				default:
					objectManager = (ObjectManager)_om;
					Ⴍ.Info(ReplyMailHelp.Ⴄ(22, null, 1057161755, 3));
					num = ⴍႤ[482] - 28430;
					continue;
				case 46:
					DxMaintenance.Purge(objectManager.Ⴍ());
					AnnMaintenance.Purge(objectManager.Ⴍ());
					LogMaintenance.Purge(objectManager.Ⴍ());
					TalkMaintenance.Purge(objectManager.Ⴍ());
					goto case 57;
				case 57:
					num = 55;
					continue;
				case 55:
					UserMaintenance.Purge(objectManager.Ⴍ());
					WwvMaintenance.Purge(objectManager.Ⴍ());
					WxMaintenance.Purge(objectManager.Ⴍ());
					ShowDxHelp.Ⴄ(objectManager.Ⴍ().Caches.Log.DbDaysToKeep, 890, 841);
					num = 45;
					continue;
				case 45:
					UtilsDatabase.VerifyAndRepair(objectManager.Ⴍ().Configuration.DbConnect);
					UtilsDatabase.VerifyAndRepair(objectManager.Ⴍ().Configuration.LocalDbConnect);
					num = ⴍႤ[386] - 53421;
					continue;
				case 24:
					UtilsDatabase.Compact(objectManager.Ⴍ().Configuration.DbConnect);
					UtilsDatabase.Compact(objectManager.Ⴍ().Configuration.LocalDbConnect);
					num = 3;
					continue;
				case 3:
					ShowContestStation.Ⴃ(objectManager.Ⴄ().Ⴅ(), false, 851, '\u0348');
					num = (objectManager.Ⴍ().Caches.Cty.AutoDownload ? (ⴀႣ[85] - 26260) : 0);
					continue;
				case 18:
					ctyUpdate = new CtyUpdate();
					ClearHelp.Ⴗ(ctyUpdate, objectManager.Ⴍ().Caches.Cty.Url, 328, 310);
					num = 30;
					continue;
				case 30:
					num = (FocCacheCfg.Ⴓ(ctyUpdate, 835, 869) ? (ⴃႠ[426] - 15987) : 0);
					continue;
				case 28:
					objectManager.Ⴀ().ႤႷ().Init();
					goto case 0;
				case 0:
					num = ((!objectManager.Ⴍ().Caches.Lotw.AutoDownload) ? (ⴐ[141] - 89) : 47);
					continue;
				case 47:
					lotwUpdate = new LotwUpdate();
					ShowGrayline.Ⴀ(lotwUpdate, objectManager.Ⴍ().Caches.Lotw.Url, 207, 162);
					num = 2;
					continue;
				case 2:
					num = ((!SetAnnOutput.Ⴍ(lotwUpdate, 'Ɲ', 470)) ? 9 : 19);
					continue;
				case 19:
					objectManager.Ⴀ().ႤႣ().Init();
					num = ⴀႼ[33];
					continue;
				case 9:
					num = ((!objectManager.Ⴍ().Caches.MasterCall.AutoDownload) ? 13 : 15);
					continue;
				case 15:
					masterCallUpdate = new MasterCallUpdate();
					ShowConnectsHelp.Ⴀ(masterCallUpdate, objectManager.Ⴍ().Caches.MasterCall.Url, 1021, 'Ξ');
					num = ⴅ[369] + 7;
					continue;
				case 8:
					num = ((!ShowGraylineHelp.Ⴅ(masterCallUpdate, 668, 760)) ? 13 : (ⴃႰ[38] - 10527));
					continue;
				case 39:
					objectManager.Ⴀ().ႤႼ().Init();
					goto case 13;
				case 13:
					num = ((!objectManager.Ⴍ().Caches.BandMode.AutoDownload) ? 48 : 12);
					continue;
				case 12:
					bandModeUpdate = new BandModeUpdate();
					SkimmerSpot.Ⴗ(bandModeUpdate, objectManager.Ⴍ().Caches.BandMode.Url, 'ȹ', 554);
					num = ⴍႤ[487] - 38043;
					continue;
				case 5:
					num = ((!SetAnnCountHelp.Ⴃ(bandModeUpdate, 259, 'Ľ')) ? 48 : 21);
					continue;
				case 21:
					objectManager.Ⴀ().ႤႨ().Init();
					goto case 48;
				case 48:
					num = ((!objectManager.Ⴍ().Caches.Foc.AutoDownload) ? 25 : ⴀႼ[77]);
					continue;
				case 22:
					focUpdate = new FocUpdate();
					SetStationClub.Ⴅ(focUpdate, objectManager.Ⴍ().Caches.Foc.Url, 314, 'ű');
					num = 50;
					continue;
				case 50:
					num = ((!SetTalkCount.Ⴐ(focUpdate, '\u02fe', 727)) ? 25 : (ⴀႨ[20] - 47531));
					continue;
				case 43:
					objectManager.Ⴀ().ႨႷ().Init();
					num = ⴃႠ[54] - 44864;
					continue;
				case 25:
					num = ((!objectManager.Ⴍ().Caches.Top100.AutoDownload) ? 20 : 16);
					continue;
				case 16:
					top100Update = new Top100Update();
					ShowUptimeHelp.Ⴄ(top100Update, objectManager.Ⴍ().Caches.Top100.Url, '\u033a', 827);
					num = 34;
					continue;
				case 34:
					num = ((!SetStationQthHelp.Ⴄ(top100Update, 'Ͳ', '\u034c')) ? (ⴍႤ[178] - 3001) : 35);
					continue;
				case 35:
					objectManager.Ⴀ().ႨႥ().Init();
					num = 20;
					continue;
				case 20:
					num = ((!objectManager.Ⴍ().Caches.BadWord.AutoDownload) ? (ⴃႠ[229] - 45209) : (ⴃႠ[404] - 53543));
					continue;
				case 33:
					badWordUpdate = new BadWordUpdate();
					ShowConnectsHelp.Ⴈ(badWordUpdate, objectManager.Ⴍ().Caches.BadWord.Url, 671, 714);
					num = 23;
					continue;
				case 23:
					num = ((!ChatRoomPubCfg.Ⴍ(badWordUpdate, 'ī', 262)) ? (ⴍႤ[387] - 63428) : 31);
					continue;
				case 31:
					objectManager.Ⴀ().ႤႤ().Init();
					goto case 56;
				case 56:
					num = ((!objectManager.Ⴍ().Caches.DxSpotBlock.AutoDownload) ? 52 : (ⴄႭ[335] - ⴄႭ[18]));
					continue;
				case 1:
					dxSpotBlockUpdate = new DxSpotBlockUpdate();
					SendMailHelp.Ⴄ(dxSpotBlockUpdate, objectManager.Ⴍ().Caches.DxSpotBlock.Url, 102, '\a');
					num = 6;
					continue;
				case 6:
					num = ((!DxClusterCacheCfg.Ⴓ(dxSpotBlockUpdate, 369, 320)) ? 52 : 51);
					continue;
				case 51:
					objectManager.Ⴀ().ႤႭ().Init();
					goto case 52;
				case 52:
					num = ((!objectManager.Ⴍ().Caches.IpLockout.AutoDownload) ? (ⴀ[478] - 14732) : 54);
					continue;
				case 54:
					ipLockoutUpdate = new IpLockoutUpdate();
					SetStationBuddyListHelp.Ⴃ(ipLockoutUpdate, objectManager.Ⴍ().Caches.IpLockout.Url, '\u008a', 240);
					num = 41;
					continue;
				case 41:
					num = ((!qslinfoSoapClient.Ⴗ(ipLockoutUpdate, 355, 'ĳ')) ? (ⴃႥ[46] - 62949) : 36);
					continue;
				case 36:
					objectManager.Ⴀ().ႨႭ().Init();
					num = 37;
					continue;
				case 37:
					num = ((!objectManager.Ⴍ().Caches.CallBlock.AutoDownload) ? 53 : 11);
					continue;
				case 11:
					callBlockUpdate = new CallBlockUpdate();
					SetStationGridHelp.Ⴐ(callBlockUpdate, objectManager.Ⴍ().Caches.CallBlock.Url, 486, 430);
					num = ⴀ[286] - 24680;
					continue;
				case 40:
					num = ((!ChatRoomPubCfg.Ⴐ(callBlockUpdate, 'ϭ', 898)) ? (ⴅ[354] - 71) : 38);
					continue;
				case 38:
					objectManager.Ⴀ().ႤႥ().Init();
					goto case 53;
				case 53:
					num = ((!objectManager.Ⴍ().Caches.ConnectBlock.AutoDownload) ? (ⴃႠ[313] - 23459) : 4);
					continue;
				case 4:
					connectBlockUpdate = new ConnectBlockUpdate();
					NodeUserCmd.Ⴐ(connectBlockUpdate, objectManager.Ⴍ().Caches.ConnectBlock.Url, 937, 'Φ');
					num = 14;
					continue;
				case 14:
					num = ((!connectBlockUpdate.VerifyCopyDelete()) ? (ⴄႤ[323] - 9) : (ⴃႠ[144] - 36929));
					continue;
				case 42:
					objectManager.Ⴀ().ႤႰ().Init();
					goto case 32;
				case 32:
					objectManager.Ⴀ().ႨႣ().ValidateCfg();
					objectManager.Ⴄ().Ⴅ().Enable = true;
					Ⴍ.Info(ႰႥ.Ⴅ(1, '\u0084', 952620794));
					num = ⴀႣ[0] - 46427;
					continue;
				case 26:
				case 29:
					num = ((!objectManager.Ⴍ().Configuration.AutoFccVeCallsignDB) ? (ⴄႷ[60] - 11671) : 44);
					continue;
				case 44:
					num = ((!(DateTime.Now.DayOfWeek.ToString() == ReplyMail.Ⴅ(3, 0, 1217945227))) ? 27 : 7);
					continue;
				case 7:
				{
					UsVeCallbookUpdate usVeCallbookUpdate = new UsVeCallbookUpdate();
					usVeCallbookUpdate.Process(objectManager.Ⴍ().Caches.Callbook.FccUrl, objectManager.Ⴍ().Caches.Callbook.VeUrl, objectManager.Ⴍ().Caches.Callbook.BuildArc4Callbook);
					break;
				}
				case 27:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴍ.Error(ex.Message);
		}
		switch (0)
		{
		}
	}
}
