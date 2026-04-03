using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Threading;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class LoginMsgCache
{
	private static readonly ILog Ⴃ;

	private static readonly object Ⴗ;

	private CtyCacheCfg.Ⴓ Ⴈ = new CtyCacheCfg.Ⴓ();

	public LoginMsgCache()
	{
		ICloneable cloneable = new Hashtable();
		Ⴈ.Ⴈ = cloneable as Hashtable;
	}

	public string GetLoginMsg(string file)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		file = LogEntry.Ⴄ(file, 'ƅ', 431);
		IEquatable<string> equatable = default(IEquatable<string>);
		try
		{
			switch (1)
			{
			default:
			{
				bool flag = false;
				object ⴗ = default(object);
				try
				{
					int num = 6;
					ICloneable cloneable = default(ICloneable);
					while (true)
					{
						switch (num)
						{
						default:
							ႨႥ.Ⴍ(ⴗ = Ⴗ, ref flag, 522, 515);
							cloneable = (string)ShowWwv.Ⴐ(Ⴈ.Ⴈ, (object)file, '²', '×');
							num = ⴃႠ[208] - 30319;
							continue;
						case 0:
						case 1:
							num = (((string)cloneable != null) ? (ⴀႣ[383] - 35214) : (ⴀ[393] - 25863));
							continue;
						case 2:
							cloneable = Ⴍ(file);
							HealthMonitorCfg.Ⴍ(Ⴈ.Ⴈ, (object)file, (object)(string)cloneable, (short)254, 'Ê');
							break;
						case 7:
							break;
						case 3:
							goto end_IL_0074;
						}
						equatable = cloneable as string;
						break;
						continue;
						end_IL_0074:
						break;
					}
				}
				finally
				{
					int num2 = 4;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = (flag ? 1 : 0);
							goto IL_0173;
						case 1:
						case 6:
							Monitor.Exit(ⴗ);
							break;
						case 0:
						case 5:
							break;
						}
						break;
						IL_0173:
						num2 = num3;
					}
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			Ⴃ.Error((ex as Exception).Message);
			goto IL_019a;
		}
		goto IL_01c2;
		IL_019a:
		switch (1)
		{
		default:
			return string.Empty;
		case 5:
			break;
		}
		goto IL_01c2;
		IL_01c2:
		return (string)equatable;
	}

	private string Ⴍ(string P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		IConvertible convertible = string.Empty;
		try
		{
			int num = 0;
			ICloneable cloneable = default(ICloneable);
			TextReader textReader = default(TextReader);
			IConvertible convertible2 = default(IConvertible);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
				{
					object obj = new FileStream(cloneable as string, FileMode.Open, FileAccess.Read);
					try
					{
						int num2 = 6;
						while (true)
						{
							switch (num2)
							{
							default:
								textReader = new StreamReader(obj as FileStream);
								convertible2 = SetAnnModeHelp.Ⴐ((TextReader)(textReader as StreamReader), '\u0003', 78);
								num2 = 5;
								continue;
							case 0:
								num2 = (SetAnnDefault.Ⴍ((string)convertible2, ႰႥ.Ⴅ(1, '\u0011', 952620227), 212, 134) ? 3 : (ⴄႤ[124] - 94));
								continue;
							case 1:
								num2 = (SetAnnDefault.Ⴍ(convertible2 as string, ShowWxHelp.Ⴍ(',', 985806360, 0), 292, 374) ? 7 : 4);
								continue;
							case 4:
								convertible2 = ShowUsersHelp.Ⴅ((string)convertible2, ReplyMail.Ⴅ(2, 11, 1217942098), 615, 553);
								num2 = 7;
								continue;
							case 7:
								convertible = (convertible as string) + (string)convertible2;
								num2 = 3;
								continue;
							case 3:
								convertible2 = (textReader as StreamReader).ReadLine();
								num2 = 5;
								continue;
							case 5:
							case 11:
							{
								string obj2 = convertible2 as string;
								BandModeCacheCfg.ႠႳ[109] = (char)(BandModeCacheCfg.ႠႳ[109] & ShowSunHelp.ႣႠ[259] & 0x56);
								num2 = ((obj2 == null) ? (ⴃႠ[416] - 8134) : 0);
								continue;
							}
							case 2:
							case 8:
							case 9:
								break;
							}
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
								num4 = ((obj is FileStream) ? 1 : (ⴐ[177] / 7));
								goto IL_0257;
							case 1:
							case 2:
								((IDisposable)(FileStream)obj).Dispose();
								break;
							case 5:
								break;
							}
							break;
							IL_0257:
							num3 = num4;
						}
					}
					switch (0)
					{
					}
					goto end_IL_0046;
				}
				}
				ICustomAttributeProvider customAttributeProvider = ShowLog.Ⴍ(1022, '϶');
				cloneable = AnnHelp.Ⴈ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)customAttributeProvider, 41, 75), 571, 'Ȯ'), CallBlockCacheCfg.Ⴅ(null, 7, 62056668, null), P_0, 963, 'ϴ');
				num = 2;
				continue;
				end_IL_0046:
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴃ.Error(ex.Message);
		}
		return 2 switch
		{
			_ => (string)convertible, 
		};
	}

	internal void Ⴀ(string P_0)
	{
		P_0 = LogEntry.Ⴄ(P_0, '\u02ef', 709);
		bool flag = false;
		object ⴗ = default(object);
		try
		{
			ႨႥ.Ⴍ(ⴗ = Ⴗ, ref flag, 672, 681);
			MailHelper.Ⴀ(Ⴈ.Ⴈ, (object)P_0, 'ϗ', 943);
		}
		finally
		{
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = (flag ? 1 : 2);
					goto IL_006f;
				case 0:
				case 1:
					Monitor.Exit(ⴗ);
					break;
				case 2:
				case 3:
					break;
				}
				break;
				IL_006f:
				num = num2;
			}
		}
	}

	static LoginMsgCache()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				Ⴗ = new object();
				return;
			case 0:
				return;
			}
			Ⴃ = SkimmerValidSpot.Ⴐ(ႰႥ.Ⴅ(0, ';', 952623088), 280, 261);
			num = ⴄႤ[202] - 22;
		}
	}
}
