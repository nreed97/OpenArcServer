using System;
using System.IO;
using System.Reflection;
using System.Security;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.Constants;
using ArcShared.DgvUtils;
using ArcShared.ExtensionMethods.Login;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using Ⴃ;

namespace ArcShared.ArcDatabase;

public sealed class LogFileMaintenance
{
	private static readonly ILog Ⴄ;

	public static void ScrubLogs(int dbDaysToKeep)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		try
		{
			int num = 14;
			object obj = default(object);
			object obj6 = default(object);
			object obj5 = default(object);
			ICloneable cloneable = default(ICloneable);
			Array array = default(Array);
			int num2 = default(int);
			object obj4 = default(object);
			DateTime dateTime = default(DateTime);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					((PrecisionTimer)obj).Start();
					obj6 = FrmUpdateAvailable.ႷႥ(37, 75);
					num = ⴃႭ[51] - 22351;
					continue;
				case 10:
					obj5 = DownloadUrl2.ႥႤ(CtyInfo.Ⴐ((Assembly)obj6, 54, 13), 'ĸ', 'Ŕ');
					num = 3;
					continue;
				case 3:
					cloneable = ReverseBeaconClient.Ⴗ((string)obj5, UtilsString.Ⴐ(null, 2, 192631338), 'Š', 'Ĩ');
					num = 0;
					continue;
				case 0:
				case 7:
				case 13:
				{
					object obj3 = new DirectoryInfo(cloneable as string);
					array = UtilsXml.Ⴀ((DirectoryInfo)obj3, 0, 32);
					num = ⴃႭ[72] - 28231;
					continue;
				}
				case 2:
				case 8:
					num2 = 0;
					num = 12;
					continue;
				case 4:
					obj4 = ((FileInfo[])array)[num2];
					dateTime = TelnetServerClient.Ⴃ(PrecisionTimer.Ⴈ((FileSystemInfo)(FileInfo)obj4, (short)208, 'ø'), new TimeSpan(dbDaysToKeep, 0, 0, 0), 'N', 32);
					num = 6;
					continue;
				case 6:
					num = ((GlobalConst.Ⴈ(dateTime, AnnCfg.Ⴓ(904, 'Ϸ'), 'δ', 'ϫ') >= 0) ? 5 : (ⴐ[124] - 50853));
					continue;
				case 9:
					UtilsValidation.Ⴅ((FileSystemInfo)(FileInfo)obj4, (short)343, (short)354);
					goto case 5;
				case 5:
					num2++;
					num = 12;
					continue;
				case 12:
					num = ((num2 >= (array as FileInfo[]).Length) ? 1 : 4);
					continue;
				case 1:
				{
					((PrecisionTimer)obj).Stop();
					ILog ⴄ = Ⴄ;
					object obj2 = new object[4];
					((object[])obj2)[0] = (PrecisionTimer)obj;
					(obj2 as object[])[1] = UtilsString.Ⴐ(null, 6, 192631333);
					(obj2 as object[])[2] = dbDaysToKeep;
					((object[])obj2)[3] = ArcLogInRqstExt.Ⴗ(1706507210, 0, 2);
					ⴄ.Info(string.Concat((object[])obj2));
					break;
				}
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴄ.Error(ႣႼ.ႥႭ(null, 624736205, 6, null) + (ex as Exception).Message);
		}
		switch (3)
		{
		}
	}

	[SecuritySafeCritical]
	static LogFileMaintenance()
	{
		UtilsIdentity.Ⴐ();
		Ⴄ = ArcLogInRqstExt.Ⴍ(ArcLogInRqstExt.Ⴗ(1706507227, 20, 8), 409, 454);
	}
}
