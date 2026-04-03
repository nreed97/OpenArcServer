using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class IpLockoutCache
{
	private static readonly ILog m_Ⴅ;

	private static readonly object m_Ⴅ;

	private readonly List<string> Ⴗ;

	public IpLockoutCache()
	{
		Ⴗ = new List<string>();
		Init();
	}

	public bool Init()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool flag = false;
		object ⴅ = default(object);
		bool flag2;
		try
		{
			switch (2)
			{
			default:
				ႨႥ.Ⴍ(ⴅ = IpLockoutCache.m_Ⴅ, ref flag, 735, 726);
				try
				{
					int num = 0;
					ICustomAttributeProvider customAttributeProvider = default(ICustomAttributeProvider);
					IEquatable<string> equatable = default(IEquatable<string>);
					while (true)
					{
						switch (num)
						{
						default:
							Ⴗ.Clear();
							goto case 4;
						case 4:
							customAttributeProvider = ShowLog.Ⴍ(746, 'ˢ');
							goto case 6;
						case 6:
							equatable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(customAttributeProvider as Assembly, 123, 25), 254, 'ë'), ႰႥ.Ⴅ(4, '\a', 952622277), 131, 205);
							goto case 3;
						case 3:
							num = 5;
							continue;
						case 5:
							LoadConfigFile(equatable as string, SetStationClubHelp.Ⴍ(7, 3, 1747258602, null));
							num = 8;
							continue;
						case 8:
							equatable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)customAttributeProvider, 798, 892), 698, 'ʯ'), SetStationQth.Ⴍ(null, 1687353310, 6, 9), 155, 213);
							num = ⴃႰ[122] - 21837;
							continue;
						case 2:
							LoadConfigFile(equatable as string, SetTalkCount.Ⴗ(1, null, 1267021794, typeof(DirectoryBulletinHelp)));
							num = 1;
							continue;
						case 1:
							Ⴗ.TrimExcess();
							flag2 = true;
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					IpLockoutCache.m_Ⴅ.Error((ex as Exception).Message);
					flag2 = false;
				}
				break;
			}
		}
		finally
		{
			int num2 = 5;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 6 : 2);
					goto IL_01e7;
				case 1:
				case 2:
					Monitor.Exit(ⴅ);
					break;
				case 3:
				case 4:
				case 6:
					break;
				}
				break;
				IL_01e7:
				num2 = num3;
			}
		}
		return 0 switch
		{
			_ => flag2, 
		};
	}

	public void LoadConfigFile(string filePath, string fileName)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		if (!LogCacheCfg.Ⴗ(filePath, 157, 157))
		{
			return;
		}
		try
		{
			object obj = new PrecisionTimer();
			ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 553, 616);
			object obj2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			try
			{
				int num = 3;
				TextReader textReader = default(TextReader);
				IComparable<string> comparable = default(IComparable<string>);
				while (true)
				{
					switch (num)
					{
					default:
						textReader = new StreamReader((FileStream)obj2);
						goto case 8;
					case 8:
						comparable = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)textReader, '\u008a', 199);
						num = 6;
						continue;
					case 7:
						num = ((CallBlockCacheCfg.Ⴜ((string)comparable, 110, 15) <= 0) ? (ⴃႠ[292] - 56623) : (ⴀႣ[182] - 39500));
						continue;
					case 5:
						num = (SetAnnDefault.Ⴍ((string)comparable, ႰႥ.Ⴅ(3, 'p', 952620225), 24, 74) ? 2 : 0);
						continue;
					case 0:
						Ⴗ.Add(comparable as string);
						goto case 2;
					case 2:
						comparable = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)textReader, 'ˠ', 685);
						num = ⴃႰ[180] - 57774;
						continue;
					case 6:
					case 9:
					{
						string obj3 = comparable as string;
						AnnCacheCfg.ႠႼ[29] = (byte)((AnnCacheCfg.ႠႼ[29] * AnnCacheCfg.ႠႼ[93]) & 0x8E);
						num = ((obj3 != null) ? (ⴀႼ[40] - 169) : 4);
						continue;
					}
					case 1:
					case 4:
						break;
					}
					break;
				}
			}
			finally
			{
				int num2 = 0;
				while (true)
				{
					int num3;
					switch (num2)
					{
					default:
						num3 = (((FileStream)obj2 == null) ? 5 : 3);
						goto IL_01b0;
					case 2:
					case 3:
						((IDisposable)(FileStream)obj2).Dispose();
						break;
					case 4:
					case 5:
						break;
					}
					break;
					IL_01b0:
					num2 = num3;
				}
			}
			ByeHelp.Ⴄ((PrecisionTimer)obj, 'Ǘ', 388);
			ILog ⴅ = IpLockoutCache.m_Ⴅ;
			object obj4 = new object[6];
			((object[])obj4)[0] = obj as PrecisionTimer;
			(obj4 as object[])[1] = SetTalkCount.Ⴗ(3, null, 1267021782, typeof(ShowConnects.ႥႥ));
			((object[])obj4)[2] = fileName;
			(obj4 as object[])[3] = ShowSkimCtyHelp.Ⴍ(1216133806, 7, '\u0010');
			((object[])obj4)[4] = Ⴗ.Count;
			(obj4 as object[])[5] = ShowSkimCtyHelp.Ⴍ(1216133811, 5, 'Æ');
			ⴅ.Info(string.Concat((object[])obj4));
		}
		catch (Exception ex)
		{
			IpLockoutCache.m_Ⴅ.Error(ex.Message);
		}
	}

	internal bool Ⴅ(string P_0)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		bool flag = false;
		object ⴅ = default(object);
		bool result;
		try
		{
			ႨႥ.Ⴍ(ⴅ = IpLockoutCache.m_Ⴅ, ref flag, 181, 188);
			result = Ⴗ.Contains(Ⴓ(P_0));
		}
		finally
		{
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!flag) ? 4 : 2);
					goto IL_0091;
				case 1:
				case 2:
					DxCmdMsgExt.ႨႠ(ⴅ, 'Ύ', 1003);
					break;
				case 4:
					break;
				}
				break;
				IL_0091:
				num = num2;
			}
		}
		SetAnnMode.ႤႭ[288] = (byte)((SetAnnMode.ႤႭ[288] - SetAnnMode.ႤႭ[330]) & 0xC);
		return result;
	}

	private string Ⴓ(string P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		while (true)
		{
			int num = Clear.Ⴀ(P_0, ':', 'ȡ', 615);
			while (true)
			{
				IL_0047:
				int num2 = ((num > 0) ? 3 : (ⴅ[423] - 74));
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = 2;
						continue;
					case 2:
						break;
					case 1:
					case 4:
						goto IL_0047;
					case 6:
						return P_0;
					case 0:
					case 3:
						return P_0.Substring(0, num);
					}
					break;
				}
				break;
			}
		}
	}

	static IpLockoutCache()
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				IpLockoutCache.m_Ⴅ = SkimmerValidSpot.Ⴐ(ReplyMailHelp.Ⴄ(8, null, 1057163924, 1), 697, 676);
				break;
			case 4:
				break;
			case 3:
				IpLockoutCache.m_Ⴅ = new object();
				return;
			case 1:
				return;
			}
			num = 3;
		}
	}
}
