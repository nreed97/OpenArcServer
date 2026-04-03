using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
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

public sealed class ChatRoomPvtCache
{
	private static readonly ILog Ⴃ;

	private static readonly object Ⴗ;

	private readonly List<ႰႣ> Ⴍ;

	public ChatRoomPvtCache()
	{
		Ⴍ = new List<ႰႣ>();
		Init();
	}

	public bool Init()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		bool flag = false;
		object ⴗ = default(object);
		bool flag2 = default(bool);
		try
		{
			switch (3)
			{
			default:
				ႨႥ.Ⴍ(ⴗ = Ⴗ, ref flag, 311, 318);
				try
				{
					int num = 2;
					object obj2 = default(object);
					object obj4 = default(object);
					IComparable comparable = default(IComparable);
					TextReader textReader = default(TextReader);
					IComparable comparable2 = default(IComparable);
					while (true)
					{
						switch (num)
						{
						default:
							obj2 = new PrecisionTimer();
							goto case 6;
						case 6:
							ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj2, 331, 266);
							Ⴍ.Clear();
							num = ⴃႠ[414] - 54161;
							continue;
						case 3:
							obj4 = ShowLog.Ⴍ(267, 'ă');
							goto case 0;
						case 0:
							comparable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)obj4, 651, 745), 71, 'R'), SetStationClubHelp.Ⴍ(15, 3, 1747257344, null), 825, 887);
							num = ⴀႨ[221] - 55657;
							continue;
						case 5:
						{
							object obj = new FileStream(comparable as string, FileMode.Open, FileAccess.Read);
							try
							{
								int num2 = 1;
								while (true)
								{
									switch (num2)
									{
									default:
										textReader = new StreamReader(obj as FileStream);
										comparable2 = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)textReader, 'ż', 305);
										num2 = ⴀႣ[70] - 49504;
										continue;
									case 5:
									case 8:
										num2 = ((CallBlockCacheCfg.Ⴜ((string)comparable2, 766, 671) <= 0) ? 2 : 3);
										continue;
									case 3:
										num2 = (SetAnnDefault.Ⴍ(comparable2 as string, ႰႥ.Ⴅ(2, '¬', 952620224), 42, 120) ? 2 : 9);
										continue;
									case 9:
									case 11:
										comparable2 = SetDxFilter.Ⴀ(SetDxFilter.Ⴀ(comparable2 as string, 789, '\u0355'), 934, 'ϧ');
										goto case 7;
									case 7:
									{
										char num3 = ⴃႠ[414];
										char num4 = ⴃႠ[414];
										SetAnnMode.ႤႭ[629] = (byte)((SetAnnMode.ႤႭ[629] + SetAnnMode.ႤႭ[48]) & 0xF2);
										num2 = num3 - num4;
										continue;
									}
									case 0:
										Ⴄ((string)comparable2);
										num2 = 2;
										continue;
									case 2:
										comparable2 = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)textReader, 'Ŏ', 259);
										num2 = ⴍႭ[177] - 18113;
										continue;
									case 4:
										num2 = (((string)comparable2 != null) ? 8 : 6);
										continue;
									case 6:
										break;
									}
									break;
								}
							}
							finally
							{
								int num5 = 6;
								while (true)
								{
									int num6;
									switch (num5)
									{
									default:
										num6 = (((FileStream)obj == null) ? 5 : 4);
										goto IL_02fe;
									case 3:
									case 4:
										((IDisposable)(FileStream)obj).Dispose();
										break;
									case 5:
										break;
									}
									break;
									IL_02fe:
									num5 = num6;
								}
							}
							int num7 = 4;
							while (true)
							{
								switch (num7)
								{
								default:
									ByeHelp.Ⴄ((PrecisionTimer)obj2, 'ȉ', 602);
									break;
								case 0:
									break;
								case 3:
									flag2 = true;
									goto end_IL_0314;
								case 1:
									goto end_IL_0314;
								}
								ILog ⴃ = Ⴃ;
								object obj3 = new object[4];
								((object[])obj3)[0] = obj2 as PrecisionTimer;
								(obj3 as object[])[1] = CallBlockCacheCfg.Ⴅ(null, 3, 62057062, null);
								((object[])obj3)[2] = Ⴍ.Count;
								(obj3 as object[])[3] = ႰႥ.Ⴅ(1, '\u0019', 952619490);
								ⴃ.Info(string.Concat((object[])obj3));
								num7 = 3;
								continue;
								end_IL_0314:
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
					Ⴃ.Error(ex.Message);
					flag2 = false;
				}
				break;
			}
		}
		finally
		{
			int num8 = 3;
			while (true)
			{
				int num9;
				switch (num8)
				{
				default:
					num9 = ((!flag) ? 5 : (ⴅ[304] - 104));
					goto IL_0419;
				case 2:
				case 4:
				case 6:
					Monitor.Exit(ⴗ);
					break;
				case 5:
					break;
				}
				break;
				IL_0419:
				num8 = num9;
			}
		}
		return 1 switch
		{
			_ => flag2, 
		};
	}

	private bool Ⴄ(string P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		while (true)
		{
			object obj = new ႰႣ();
			int num = ((!(obj as ႰႣ).Ⴃ(P_0)) ? (ⴃႠ[426] - 16013) : 3);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴐ[254];
					continue;
				case 0:
				case 4:
					break;
				case 3:
				case 6:
					Ⴍ.Add((ႰႣ)obj);
					goto case 1;
				case 1:
					return true;
				case 2:
					return false;
				}
				break;
			}
		}
	}

	internal bool Ⴀ(string P_0)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		bool flag = false;
		object ⴗ = default(object);
		try
		{
			ႨႥ.Ⴍ(ⴗ = Ⴗ, ref flag, 607, 598);
			return true;
		}
		finally
		{
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = (flag ? ⴀႼ[96] : 0);
					goto IL_0077;
				case 3:
				case 4:
				case 5:
					DxCmdMsgExt.ႨႠ(ⴗ, 'Ƥ', 449);
					break;
				case 0:
				case 1:
					break;
				}
				break;
				IL_0077:
				num = num2;
			}
		}
	}

	static ChatRoomPvtCache()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				Ⴗ = new object();
				return;
			case 4:
				return;
			}
			Ⴃ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216134185, 8, '%'), 384, 413);
			num = ⴀႳ[254] - 26740;
		}
	}
}
