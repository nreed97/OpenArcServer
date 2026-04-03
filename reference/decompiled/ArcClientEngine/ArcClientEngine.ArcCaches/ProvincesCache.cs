using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcShared.ArcUtils;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public sealed class ProvincesCache
{
	private static readonly ILog Ⴈ;

	internal readonly List<string> Ⴀ;

	internal ProvincesCache()
	{
		Ⴀ = new List<string>();
		Init();
	}

	public bool Init()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		bool flag = false;
		object ⴀ = default(object);
		bool flag2;
		try
		{
			switch (1)
			{
			default:
				ႥႥ.ႤႨ(ⴀ = Ⴀ, ref flag, 430, 479);
				try
				{
					int num = 5;
					object obj2 = default(object);
					ICloneable cloneable = default(ICloneable);
					object obj3 = default(object);
					object obj4 = default(object);
					while (true)
					{
						switch (num)
						{
						default:
							obj2 = new PrecisionTimer();
							MultimediaCfg.Ⴄ(obj2 as PrecisionTimer, 739, 713);
							Ⴀ.Clear();
							num = 3;
							continue;
						case 2:
						case 3:
						{
							ISerializable serializable = WxFilters.ႭႭ(136, 163);
							cloneable = DxFilters.Ⴈ(HighlightCfg.ႳႳ(ႥႠ.Ⴅ((Assembly)serializable, 815, 787), 'į', 323), ClientCty.Ⴗ('ú', 2, 307013096), 68, 28);
							num = ⴄ[290] - 49138;
							continue;
						}
						case 13:
						{
							Stream stream = new FileStream(cloneable as string, FileMode.Open, FileAccess.Read);
							obj3 = new StreamReader(stream as FileStream);
							num = 4;
							continue;
						}
						case 4:
							obj4 = HighlightItuZoneCfg.Ⴜ((TextReader)(obj3 as StreamReader), (short)302, (short)379);
							num = 12;
							continue;
						case 9:
							num = ((ႳႳ.Ⴓ((string)obj4, 'κ', 924) <= 0) ? 7 : 14);
							continue;
						case 14:
							num = ((!ႥႤ.Ⴍ((string)obj4, WxFilters.Ⴀ(null, 7, 103387686), 972, 1014)) ? 1 : 7);
							continue;
						case 1:
							Ⴀ.Add((string)obj4);
							goto case 7;
						case 7:
							obj4 = HighlightItuZoneCfg.Ⴜ((TextReader)(StreamReader)obj3, (short)505, (short)428);
							num = ⴗ[103] - 55679;
							continue;
						case 6:
						case 12:
						case 15:
							num = (((string)obj4 != null) ? (ⴗ[28] - 37799) : (ⴗ[122] - 26793));
							continue;
						case 8:
							UserInfo.Ⴓ((TextReader)(StreamReader)obj3, 'ʃ', 'ʋ');
							Ⴀ.TrimExcess();
							MultimediaCfg.Ⴈ(obj2 as PrecisionTimer, 191, 158);
							num = 11;
							continue;
						case 11:
						{
							ILog ⴈ = Ⴈ;
							object obj = new object[4];
							((object[])obj)[0] = obj2 as PrecisionTimer;
							(obj as object[])[1] = ႥႥ.Ⴍ(2, 1580609169, '\u001f', null);
							(obj as object[])[2] = Ⴀ.Count;
							((object[])obj)[3] = WxFilters.Ⴀ(null, 8, 103388833);
							ⴈ.Info(string.Concat(obj as object[]));
							num = 0;
							continue;
						}
						case 0:
							flag2 = true;
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Ⴈ.Error(ex.Message);
					flag2 = false;
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
					num3 = ((!flag) ? 1 : 6);
					goto IL_0358;
				case 6:
					Monitor.Exit(ⴀ as List<string>);
					break;
				case 1:
				case 5:
					break;
				}
				break;
				IL_0358:
				num2 = num3;
			}
		}
		return 1 switch
		{
			_ => flag2, 
		};
	}

	[SecuritySafeCritical]
	static ProvincesCache()
	{
		ArcClientConnectDat.Ⴍ();
		Ⴈ = HighlightItuZoneCfg.Ⴓ(ႥႥ.Ⴍ(6, 1580609161, '\u0087', null), 1017, 969);
	}
}
