using System;
using System.Collections;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.IO;
using System.Reflection;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcServerConfig.Io;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcObjs.ArcUtils;

public static class UtilsDatabase
{
	private static readonly ILog Ⴃ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216130412, 7, 'Ï'), 804, 825);

	public static void Compact(string connectString)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		try
		{
			int num = 4;
			object obj2 = default(object);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj2 as PrecisionTimer, 173, 236);
					obj = new SqlCeEngine(connectString);
					goto case 3;
				case 3:
					num = 1;
					continue;
				case 1:
					qslinfoResponseBody.Ⴅ((SqlCeEngine)obj, connectString, '\u02e8', 'ʮ');
					ႰႰ.Ⴗ((SqlCeEngine)obj, 976, 978);
					num = ⴅ[351] - 32;
					continue;
				case 6:
					obj = null;
					ByeHelp.Ⴄ(obj2 as PrecisionTimer, '[', 8);
					break;
				case 2:
				case 5:
					break;
				}
				break;
			}
			Ⴃ.Info(ShowPrefixCalls.Ⴃ((object)(PrecisionTimer)obj2, (object)ႰႥ.Ⴅ(4, 'Y', 952616322), (object)connectString, 'Ο', 949));
		}
		catch (Exception)
		{
			Ⴃ.Warn(SetStationQth.Ⴍ(null, 1687354953, 3, 16) + connectString);
		}
		switch (1)
		{
		}
	}

	public static void VerifyAndRepair(string connectString)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		try
		{
			int num = 8;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
				{
					object obj2 = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj2, 273, 336);
					obj = new SqlCeEngine(connectString);
					goto case 1;
				}
				case 1:
					num = ⴀႳ[183] - 43496;
					continue;
				case 7:
					num = (SetWxCount.Ⴀ((SqlCeEngine)obj, 73, 121) ? 6 : 9);
					continue;
				case 4:
				case 9:
					Ⴃ.Warn(ShowUsersHelp.Ⴅ(SetTalkCount.Ⴗ(2, null, 1267014337, typeof(SetStationQthHelp)), connectString, 526, 576));
					num = 0;
					continue;
				case 0:
				case 5:
					IoDevicesCfg.Ⴓ<SqlCeEngine, string>(obj as SqlCeEngine, null, RepairOption.RecoverCorruptedRows, 728, 'ʟ');
					Ⴃ.Info(ShowUsersHelp.Ⴅ(ShowWxHelp.Ⴍ('\u0017', 985805468, 8), connectString, 195, 141));
					num = ⴐ[21];
					continue;
				case 6:
					Ⴃ.Info(ShowUsersHelp.Ⴅ(ReplyMailHelp.Ⴄ(17, null, 1057167131, 3), connectString, 218, 148));
					break;
				case 3:
					break;
				}
				break;
			}
			((SqlCeEngine)obj).Dispose();
			obj = null;
		}
		catch (Exception)
		{
			Ⴃ.Warn(CallBlockCacheCfg.Ⴅ(null, 0, 62061922, null) + connectString);
		}
		switch (0)
		{
		}
	}

	public static void IfNotExistsCreateLocalDb()
	{
		int num = 6;
		ICustomAttributeProvider customAttributeProvider = default(ICustomAttributeProvider);
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			switch (num)
			{
			default:
				customAttributeProvider = ShowLog.Ⴍ(503, 'ǿ');
				goto case 5;
			case 5:
				enumerable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)customAttributeProvider, 93, 63), 743, '\u02f2'), SetStationClubHelp.Ⴍ(0, 5, 1747262824, null), 774, 840);
				num = 4;
				break;
			case 1:
			case 4:
				num = ((!File.Exists((string)enumerable)) ? 2 : 0);
				break;
			case 2:
			case 3:
				Ⴀ(CallBlockCacheCfg.Ⴅ(null, 8, 62057016, null));
				return;
			case 0:
				return;
			}
		}
	}

	private static void Ⴀ(string P_0)
	{
		try
		{
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
				{
					IDisposable disposable = new SqlCeEngine(P_0);
					ႨႼ.Ⴓ(disposable as SqlCeEngine, 'Ȅ', 544);
					ႰႰ.Ⴗ(disposable as SqlCeEngine, 497, 499);
					break;
				}
				case 1:
					break;
				case 5:
				{
					IDisposable disposable = null;
					goto end_IL_0003;
				}
				case 2:
					goto end_IL_0003;
				}
				num = 5;
				continue;
				end_IL_0003:
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴃ.Error(ShowUsersHelp.Ⴅ(ShowWxHelp.Ⴍ('\u0082', 985805455, 1), SkimmerSpotBins.Ⴈ(ex, 205, 227), 748, 674));
		}
		try
		{
			switch (0)
			{
			default:
			{
				DbConnection dbConnection = new SqlCeConnection(P_0);
				try
				{
					int num2 = 0;
					object obj = default(object);
					while (true)
					{
						switch (num2)
						{
						default:
							obj = new SqlCeCommand(ShowWxHelp.Ⴍ('\u009e', 985805535, 0), dbConnection as SqlCeConnection);
							SetAnnWrapHelp.Ⴀ((DbConnection)(dbConnection as SqlCeConnection), 649, (short)650);
							break;
						case 2:
							break;
						case 5:
							SetAnnCountHelp.Ⴅ((DbCommand)(obj as SqlCeCommand), (short)77, '<');
							goto end_IL_00c5;
						case 3:
							goto end_IL_00c5;
						}
						num2 = 5;
						continue;
						end_IL_00c5:
						break;
					}
				}
				finally
				{
					int num3 = 3;
					while (true)
					{
						int num4;
						switch (num3)
						{
						default:
							num4 = ((!(dbConnection is SqlCeConnection)) ? 2 : 0);
							goto IL_015b;
						case 0:
							((IDisposable)(SqlCeConnection)dbConnection).Dispose();
							break;
						case 2:
						case 5:
							break;
						}
						break;
						IL_015b:
						num3 = num4;
					}
				}
				switch (4)
				{
				}
				break;
			}
			}
		}
		catch (Exception ex2)
		{
			Ⴃ.Error(ReplyMail.Ⴅ(1, 7, 1217940619) + ex2.Message);
		}
		switch (1)
		{
		}
	}
}
