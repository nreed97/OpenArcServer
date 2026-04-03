using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class MasterCallCache
{
	private static readonly ILog Ⴃ;

	private static readonly object Ⴗ;

	private CtyCacheCfg.Ⴓ m_Ⴍ = new CtyCacheCfg.Ⴓ();

	public MasterCallCache()
	{
		ICollection collection = new Hashtable();
		this.m_Ⴍ.Ⴈ = collection as Hashtable;
		Init();
	}

	public void Init()
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool flag = false;
		object ⴗ = default(object);
		try
		{
			switch (1)
			{
			default:
				ႨႥ.Ⴍ(ⴗ = Ⴗ, ref flag, 659, 666);
				try
				{
					int num = 6;
					object obj3 = default(object);
					IEnumerable<char> enumerable = default(IEnumerable<char>);
					object obj2 = default(object);
					IEquatable<string> equatable = default(IEquatable<string>);
					while (true)
					{
						switch (num)
						{
						default:
							obj3 = new PrecisionTimer();
							goto case 2;
						case 2:
							ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj3, 669, 732);
							ShowQrz.Ⴄ(this.m_Ⴍ.Ⴈ, 324, 376);
							goto case 0;
						case 0:
						case 1:
							num = 5;
							continue;
						case 5:
						{
							object obj5 = ShowLog.Ⴍ(522, 'Ȃ');
							enumerable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(obj5 as Assembly, 967, 933), 876, '\u0379'), SetStationQth.Ⴍ(null, 1687351799, 5, 1), 272, 350);
							num = 3;
							continue;
						}
						case 3:
						{
							object obj = new FileStream((string)enumerable, FileMode.Open, FileAccess.Read);
							try
							{
								int num2 = 2;
								while (true)
								{
									switch (num2)
									{
									default:
										obj2 = new StreamReader(obj as FileStream);
										equatable = SetAnnModeHelp.Ⴐ((TextReader)(obj2 as StreamReader), '\u0378', 821);
										goto case 10;
									case 10:
										num2 = 1;
										continue;
									case 4:
									case 7:
										num2 = ((CallBlockCacheCfg.Ⴜ((string)equatable, 268, 365) <= 0) ? 11 : 9);
										continue;
									case 9:
										num2 = (SetAnnDefault.Ⴍ(equatable as string, ႰႥ.Ⴅ(0, ']', 952620226), 592, 514) ? 11 : (ⴍႤ[322] - 63860));
										continue;
									case 0:
										num2 = (SetWxDefaultHelp.Ⴃ(this.m_Ⴍ.Ⴈ, (object)(equatable as string), 641, 667) ? (ⴄႭ[250] - ⴄႭ[82]) : 3);
										continue;
									case 3:
										HealthMonitorCfg.Ⴍ(this.m_Ⴍ.Ⴈ, (object)(string)equatable, (object)(string)equatable, (short)545, 'ȕ');
										goto case 11;
									case 11:
										equatable = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj2, 'ȭ', 608);
										num2 = ⴄႤ[148];
										continue;
									case 1:
										num2 = ((equatable is string) ? (ⴃႥ[408] - 41628) : 6);
										continue;
									case 6:
										break;
									}
									break;
								}
							}
							finally
							{
								int num3 = 4;
								while (true)
								{
									int num4;
									switch (num3)
									{
									default:
										num4 = ((!(obj is FileStream)) ? 6 : (ⴄႭ[394] - 81));
										goto IL_02cb;
									case 5:
										((IDisposable)(obj as FileStream)).Dispose();
										break;
									case 2:
									case 6:
										break;
									}
									break;
									IL_02cb:
									num3 = num4;
								}
							}
							switch (2)
							{
							default:
							{
								ByeHelp.Ⴄ((PrecisionTimer)obj3, 'Ę', 331);
								ILog ⴃ = Ⴃ;
								object obj4 = new object[4];
								((object[])obj4)[0] = obj3 as PrecisionTimer;
								(obj4 as object[])[1] = SetStationQth.Ⴍ(null, 1687351710, 8, 17);
								((object[])obj4)[2] = this.m_Ⴍ.Ⴈ.Count;
								(obj4 as object[])[3] = SetStationQth.Ⴍ(null, 1687351687, 6, 26);
								ⴃ.Info(string.Concat(obj4 as object[]));
								break;
							}
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
				}
				switch (2)
				{
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
					num6 = ((!flag) ? 2 : (ⴍႤ[450] - ⴍႤ[450]));
					goto IL_0401;
				case 0:
					Monitor.Exit(ⴗ);
					break;
				case 2:
					break;
				}
				break;
				IL_0401:
				num5 = num6;
			}
		}
		switch (0)
		{
		}
	}

	internal bool Ⴍ(string P_0)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		bool flag = false;
		bool flag2 = default(bool);
		object ⴗ = default(object);
		try
		{
			int num = 3;
			bool flag3 = default(bool);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					flag2 = flag3;
					goto end_IL_003b;
				case 2:
					goto end_IL_003b;
				}
				ႨႥ.Ⴍ(ⴗ = Ⴗ, ref flag, 697, 688);
				flag3 = DxSpotUserHelp.Ⴅ(this.m_Ⴍ.Ⴈ, (object)P_0, '©', (short)184);
				num = 0;
				continue;
				end_IL_003b:
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
					num3 = ((!flag) ? (ⴍႤ[194] - 53139) : (ⴀႣ[42] - 30803));
					goto IL_00cb;
				case 5:
				case 6:
					Monitor.Exit(ⴗ);
					break;
				case 3:
					break;
				}
				break;
				IL_00cb:
				num2 = num3;
			}
		}
		return 2 switch
		{
			_ => flag2, 
		};
	}

	static MasterCallCache()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴃ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(7, null, 1267022198, typeof(SetStationPhone)), 752, 749);
				break;
			case 3:
				break;
			case 1:
			case 2:
				Ⴗ = new object();
				return;
			case 4:
				return;
			}
			num = 1;
		}
	}
}
