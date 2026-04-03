using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class Top100Cache
{
	private static readonly ILog Ⴍ;

	private static readonly object Ⴃ;

	private readonly List<string> Ⴃ;

	public Top100Cache()
	{
		Ⴃ = new List<string>();
		Init();
	}

	public bool Init()
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		bool flag = false;
		object ⴃ = default(object);
		bool flag2;
		try
		{
			switch (3)
			{
			default:
				ႨႥ.Ⴍ(ⴃ = Top100Cache.Ⴃ, ref flag, 991, 982);
				try
				{
					int num = 2;
					object obj2 = default(object);
					IEquatable<string> equatable = default(IEquatable<string>);
					TextReader textReader = default(TextReader);
					IEquatable<string> equatable2 = default(IEquatable<string>);
					while (true)
					{
						switch (num)
						{
						default:
							obj2 = new PrecisionTimer();
							ShowPrefixCallsHelp.Ⴗ(obj2 as PrecisionTimer, 901, 964);
							Ⴃ.Clear();
							goto case 3;
						case 3:
						case 5:
							num = 6;
							continue;
						case 6:
						{
							ISerializable serializable = ShowLog.Ⴍ(292, 'Ĭ');
							equatable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)serializable, 549, 583), 381, 'Ũ'), SetStationClubHelp.Ⴍ(13, 3, 1747261947, null), 155, 213);
							goto case 0;
						}
						case 0:
							num = ⴄႭ[276] - 187;
							continue;
						case 4:
						{
							object obj = new FileStream(equatable as string, FileMode.Open, FileAccess.Read);
							try
							{
								int num2 = 9;
								while (true)
								{
									switch (num2)
									{
									default:
										textReader = new StreamReader(obj as FileStream);
										goto case 5;
									case 5:
										equatable2 = SetAnnModeHelp.Ⴐ((TextReader)(textReader as StreamReader), 'i', 36);
										num2 = ⴄႤ[168] - 58;
										continue;
									case 1:
										num2 = ((CallBlockCacheCfg.Ⴜ((string)equatable2, 488, 393) <= 0) ? 7 : 3);
										continue;
									case 3:
										num2 = (SetAnnDefault.Ⴍ(equatable2 as string, ႰႥ.Ⴅ(2, 'è', 952620224), 954, 1000) ? 7 : 10);
										continue;
									case 10:
									{
										IConvertible convertible = Ⴗ(equatable2 as string);
										Ⴃ.Add((string)convertible);
										goto case 7;
									}
									case 7:
										equatable2 = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)textReader, 'ǈ', 389);
										num2 = 8;
										continue;
									case 8:
										num2 = ((equatable2 is string) ? ⴄႤ[148] : 0);
										continue;
									case 0:
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
										num4 = ((!(obj is FileStream)) ? (ⴃႠ[420] - 35535) : 0);
										goto IL_0295;
									case 0:
									case 5:
										((IDisposable)(obj as FileStream)).Dispose();
										break;
									case 1:
									case 4:
										break;
									}
									break;
									IL_0295:
									num3 = num4;
								}
							}
							int num5 = 3;
							while (true)
							{
								switch (num5)
								{
								default:
									Ⴃ.TrimExcess();
									goto case 5;
								case 5:
									ByeHelp.Ⴄ(obj2 as PrecisionTimer, 'Ģ', 369);
									break;
								case 0:
									break;
								case 1:
									flag2 = true;
									goto end_IL_02b8;
								}
								ILog ⴍ = Ⴍ;
								Array array = new object[4];
								(array as object[])[0] = (PrecisionTimer)obj2;
								(array as object[])[1] = ReplyMail.Ⴅ(2, 4, 1217941743);
								((object[])array)[2] = Ⴃ.Count;
								((object[])array)[3] = CallBlockCacheCfg.Ⴅ(null, 4, 62054422, null);
								ⴍ.Info(string.Concat(array as object[]));
								num5 = ⴀႣ[166] - 45411;
								continue;
								end_IL_02b8:
								break;
							}
							break;
						}
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Ⴍ.Error(ex.Message);
					flag2 = false;
				}
				break;
			}
		}
		finally
		{
			int num6 = 3;
			while (true)
			{
				int num7;
				switch (num6)
				{
				default:
					num7 = ((!flag) ? (ⴍႤ[219] - 25314) : 5);
					goto IL_03ca;
				case 1:
				case 5:
					Monitor.Exit(ⴃ);
					break;
				case 0:
				case 2:
					break;
				}
				break;
				IL_03ca:
				num6 = num7;
			}
		}
		return 1 switch
		{
			_ => flag2, 
		};
	}

	private string Ⴗ(string P_0)
	{
		while (true)
		{
			Array array = new char[1];
			(array as char[])[0] = ' ';
			Array array2 = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, array as char[], 55, 97);
			while (true)
			{
				IL_004c:
				int num = 4;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 1;
						continue;
					case 1:
						break;
					case 0:
					case 2:
						goto IL_004c;
					case 3:
					case 4:
						return (array2 as string[])[1];
					}
					break;
				}
				break;
			}
		}
	}

	internal bool Ⴐ(string P_0)
	{
		bool flag = false;
		object ⴃ = default(object);
		try
		{
			ႨႥ.Ⴍ(ⴃ = Top100Cache.Ⴃ, ref flag, 426, 419);
			return Ⴃ.Contains(P_0);
		}
		finally
		{
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!flag) ? 2 : 5);
					goto IL_0077;
				case 0:
				case 5:
					DxCmdMsgExt.ႨႠ(ⴃ, 'Ǜ', 446);
					break;
				case 2:
					break;
				}
				break;
				IL_0077:
				num = num2;
			}
		}
	}

	static Top100Cache()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 3:
				Top100Cache.Ⴃ = new object();
				return;
			case 0:
				return;
			}
			Ⴍ = SkimmerValidSpot.Ⴐ(ReplyMailHelp.Ⴄ(12, null, 1057165150, 3), 13, 16);
			num = ⴅ[292] - ⴅ[91];
		}
	}
}
