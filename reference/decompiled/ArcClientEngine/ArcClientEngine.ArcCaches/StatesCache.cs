using System;
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

public sealed class StatesCache
{
	private static readonly ILog Ⴗ;

	internal readonly List<string> Ⴍ;

	internal StatesCache()
	{
		Ⴍ = new List<string>();
		Init();
	}

	public bool Init()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		bool flag = false;
		object ⴍ = default(object);
		bool flag2;
		try
		{
			switch (3)
			{
			default:
				ႥႥ.ႤႨ(ⴍ = Ⴍ, ref flag, 93, 44);
				try
				{
					int num = 4;
					object obj2 = default(object);
					IComparable comparable = default(IComparable);
					object obj3 = default(object);
					TextReader textReader = default(TextReader);
					ICloneable cloneable = default(ICloneable);
					while (true)
					{
						switch (num)
						{
						default:
							obj2 = new PrecisionTimer();
							MultimediaCfg.Ⴄ(obj2 as PrecisionTimer, 127, 85);
							Ⴍ.Clear();
							num = 12;
							continue;
						case 12:
						{
							IEvidenceFactory evidenceFactory = WxFilters.ႭႭ(1013, 990);
							comparable = DxFilters.Ⴈ(HighlightCfg.ႳႳ(ႥႠ.Ⴅ((Assembly)evidenceFactory, 658, 686), '\u035f', 819), ClientCty.Ⴗ('\v', 7, 307011911), 714, 658);
							num = 11;
							continue;
						}
						case 11:
							obj3 = new FileStream(comparable as string, FileMode.Open, FileAccess.Read);
							goto case 13;
						case 13:
							textReader = new StreamReader((FileStream)obj3);
							num = 8;
							continue;
						case 8:
							cloneable = HighlightItuZoneCfg.Ⴜ((TextReader)(StreamReader)textReader, (short)10, (short)95);
							num = ⴀႠ[106] - 51671;
							continue;
						case 15:
							num = ((ႳႳ.Ⴓ(cloneable as string, 'P', 118) <= 0) ? 9 : 5);
							continue;
						case 1:
						case 5:
							num = (ႥႤ.Ⴍ(cloneable as string, WxFilters.Ⴀ(null, 5, 103387684), 429, 407) ? 9 : 2);
							continue;
						case 2:
							Ⴍ.Add(cloneable as string);
							goto case 9;
						case 9:
							cloneable = HighlightItuZoneCfg.Ⴜ((TextReader)(StreamReader)textReader, (short)702, (short)747);
							num = 7;
							continue;
						case 7:
							num = (((string)cloneable != null) ? (ⴄ[92] - 14800) : 14);
							continue;
						case 14:
							UserInfo.Ⴓ((TextReader)(textReader as StreamReader), 'ǌ', 'Ǆ');
							Ⴍ.TrimExcess();
							MultimediaCfg.Ⴈ(obj2 as PrecisionTimer, 725, 756);
							num = ⴗ[114] - ⴗ[114];
							continue;
						case 0:
						{
							ILog ⴗ2 = Ⴗ;
							object obj = new object[4];
							(obj as object[])[0] = obj2 as PrecisionTimer;
							(obj as object[])[1] = ႥႥ.Ⴍ(7, 1580608420, '\u001f', null);
							((object[])obj)[2] = Ⴍ.Count;
							((object[])obj)[3] = WxFilters.Ⴀ(null, 0, 103388652);
							ⴗ2.Info(string.Concat(obj as object[]));
							num = ⴗ[136] - 30454;
							continue;
						}
						case 6:
						case 10:
							flag2 = true;
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Ⴗ.Error((ex as Exception).Message);
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
					num3 = ((!flag) ? ⴅ[25] : 0);
					goto IL_0350;
				case 0:
				case 1:
					Monitor.Exit((List<string>)ⴍ);
					break;
				case 2:
					break;
				}
				break;
				IL_0350:
				num2 = num3;
			}
		}
		return 3 switch
		{
			_ => flag2, 
		};
	}

	[SecuritySafeCritical]
	static StatesCache()
	{
		ArcClientConnectDat.Ⴍ();
		Ⴗ = HighlightItuZoneCfg.Ⴓ(ႥႥ.Ⴍ(1, 1580608081, 'ò', null), 648, 696);
	}
}
