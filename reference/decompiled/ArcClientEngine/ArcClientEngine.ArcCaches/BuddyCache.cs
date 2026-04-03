using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security;
using System.Threading;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcShared.ArcUtils;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public sealed class BuddyCache
{
	private static readonly ILog Ⴄ;

	private static readonly object Ⴅ;

	private readonly List<string> Ⴗ;

	internal BuddyCache()
	{
		Ⴗ = new List<string>();
		Init();
	}

	public bool Init()
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		bool flag = false;
		object ⴅ2 = default(object);
		bool flag2;
		try
		{
			switch (1)
			{
			default:
				ႥႥ.ႤႨ(ⴅ2 = Ⴅ, ref flag, 759, 646);
				try
				{
					int num = 2;
					object obj2 = default(object);
					IEnumerable enumerable = default(IEnumerable);
					object obj3 = default(object);
					IComparable<string> comparable = default(IComparable<string>);
					while (true)
					{
						switch (num)
						{
						default:
							obj2 = new PrecisionTimer();
							MultimediaCfg.Ⴄ((PrecisionTimer)obj2, 217, 243);
							Ⴗ.Clear();
							num = 9;
							continue;
						case 9:
						{
							ICustomAttributeProvider customAttributeProvider = WxFilters.ႭႭ(961, 1002);
							enumerable = DxFilters.Ⴈ(HighlightCfg.ႳႳ(ႥႠ.Ⴅ((Assembly)customAttributeProvider, 77, 113), 'Ʋ', 478), WxFilters.Ⴀ(null, 3, 103388672), 533, 589);
							num = 5;
							continue;
						}
						case 5:
						{
							Stream stream = new FileStream(enumerable as string, FileMode.Open, FileAccess.Read);
							obj3 = new StreamReader(stream as FileStream);
							num = 7;
							continue;
						}
						case 7:
							comparable = HighlightItuZoneCfg.Ⴜ((TextReader)(StreamReader)obj3, (short)325, (short)272);
							num = ⴄ[219] - 35519;
							continue;
						case 12:
							num = ((ႳႳ.Ⴓ(comparable as string, 'ɍ', 619) <= 0) ? (ⴄ[243] - 58584) : 15);
							continue;
						case 15:
							num = (ႥႤ.Ⴍ((string)comparable, WxFilters.Ⴀ(null, 7, 103387686), 795, 801) ? (ⴅ[38] - 160) : (ⴗ[149] - 53677));
							continue;
						case 4:
							Ⴗ.Add(comparable as string);
							goto case 3;
						case 3:
							comparable = HighlightItuZoneCfg.Ⴜ((TextReader)(StreamReader)obj3, (short)354, (short)311);
							num = ⴄ[80] - 22731;
							continue;
						case 1:
							num = ((comparable is string) ? (ⴅ[120] - 104) : 0);
							continue;
						case 0:
							UserInfo.Ⴓ((TextReader)(obj3 as StreamReader), '\v', '\u0003');
							Ⴗ.TrimExcess();
							MultimediaCfg.Ⴈ(obj2 as PrecisionTimer, 756, 725);
							goto case 11;
						case 11:
						case 13:
							num = 10;
							continue;
						case 10:
						case 14:
						{
							ILog ⴄ2 = Ⴄ;
							object obj = new object[4];
							((object[])obj)[0] = obj2 as PrecisionTimer;
							(obj as object[])[1] = ႥႥ.Ⴅ(1673508438, null, 6);
							((object[])obj)[2] = Ⴗ.Count;
							((object[])obj)[3] = ႥႥ.Ⴍ(8, 1580609122, '\u0094', null);
							ⴄ2.Info(string.Concat(obj as object[]));
							num = ⴄ[84] - 3808;
							continue;
						}
						case 6:
							flag2 = true;
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Ⴄ.Error((ex as Exception).Message);
					flag2 = false;
				}
				break;
			}
		}
		finally
		{
			int num2 = 3;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? (ⴀႠ[64] - 42666) : 5);
					goto IL_037b;
				case 5:
					Monitor.Exit(ⴅ2);
					break;
				case 0:
				case 2:
				case 6:
					break;
				}
				break;
				IL_037b:
				num2 = num3;
			}
		}
		return 3 switch
		{
			_ => flag2, 
		};
	}

	internal bool Ⴈ(string P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		bool flag = false;
		object ⴅ2 = default(object);
		try
		{
			ႥႥ.ႤႨ(ⴅ2 = Ⴅ, ref flag, 440, 457);
			return Ⴗ.Contains(P_0);
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
					num2 = (flag ? (ⴀႠ[44] - 48723) : 0);
					goto IL_0093;
				case 1:
				case 2:
				case 4:
				case 5:
					DxFilters.Ⴍ(ⴅ2, 401, 503);
					break;
				case 0:
					break;
				}
				break;
				IL_0093:
				num = num2;
			}
		}
	}

	[SecuritySafeCritical]
	static BuddyCache()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				ArcClientConnectDat.Ⴍ();
				break;
			case 1:
			case 2:
				break;
			case 3:
				Ⴅ = new object();
				return;
			}
			Ⴄ = HighlightItuZoneCfg.Ⴓ(WxFilters.Ⴀ(null, 4, 103388710), 201, 249);
			num = ⴀႠ[113] - 43460;
		}
	}
}
