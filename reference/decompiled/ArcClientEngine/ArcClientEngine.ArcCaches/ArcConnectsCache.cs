using System;
using System.Collections;
using System.ComponentModel;
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

public sealed class ArcConnectsCache
{
	private static readonly ILog Ⴐ;

	private static readonly object Ⴍ;

	public readonly BindingList<ArcClientConnectDat> List;

	public ArcConnectsCache()
	{
		List = new BindingList<ArcClientConnectDat>();
		Init();
	}

	public bool Init()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		bool flag = false;
		object ⴍ = default(object);
		bool flag2;
		try
		{
			switch (1)
			{
			default:
				ႥႥ.ႤႨ(ⴍ = Ⴍ, ref flag, 33, 80);
				try
				{
					int num = 10;
					object obj = default(object);
					object obj2 = default(object);
					ICloneable cloneable = default(ICloneable);
					Stream stream = default(Stream);
					TextReader textReader = default(TextReader);
					IEnumerable enumerable = default(IEnumerable);
					while (true)
					{
						switch (num)
						{
						default:
							obj = new PrecisionTimer();
							MultimediaCfg.Ⴄ((PrecisionTimer)obj, 1015, 989);
							obj2 = WxFilters.ႭႭ(611, 584);
							num = 6;
							continue;
						case 6:
							cloneable = DxFilters.Ⴈ(HighlightCfg.ႳႳ(ႥႠ.Ⴅ(obj2 as Assembly, 618, 598), 'Ώ', 995), ClientCty.Ⴗ('\u0015', 2, 307012814), 523, 595);
							num = ⴗ[93] - 63514;
							continue;
						case 5:
							stream = new FileStream((string)cloneable, FileMode.Open, FileAccess.Read);
							goto case 9;
						case 9:
							textReader = new StreamReader((FileStream)stream);
							num = 11;
							continue;
						case 11:
							enumerable = HighlightItuZoneCfg.Ⴜ((TextReader)(textReader as StreamReader), (short)361, (short)316);
							num = 1;
							continue;
						case 3:
						case 13:
							num = ((ႳႳ.Ⴓ(enumerable as string, 'ś', 381) <= 0) ? 8 : 7);
							continue;
						case 7:
							num = (ႥႤ.Ⴍ((string)enumerable, WxFilters.Ⴀ(null, 6, 103387687), 68, 126) ? 8 : 0);
							continue;
						case 0:
							Ⴈ((string)enumerable);
							goto case 8;
						case 8:
							enumerable = (textReader as StreamReader).ReadLine();
							num = 1;
							continue;
						case 1:
						case 4:
							num = (((string)enumerable != null) ? 3 : 12);
							continue;
						case 12:
							(textReader as StreamReader).Close();
							(obj as PrecisionTimer).Stop();
							flag2 = true;
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Ⴐ.Error(ex.Message);
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
					num3 = ((!flag) ? (ⴅ[329] - 175) : (ⴗ[152] - 32164));
					goto IL_026a;
				case 2:
				case 3:
					Monitor.Exit(ⴍ);
					break;
				case 1:
					break;
				}
				break;
				IL_026a:
				num2 = num3;
			}
		}
		switch (4)
		{
		default:
		{
			bool result = flag2;
			UserCmd.Ⴅ[91] = (byte)((UserCmd.Ⴅ[91] | UserCmd.Ⴅ[20]) & 0xC2);
			return result;
		}
		}
	}

	private void Ⴈ(string P_0)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		try
		{
			int num = 7;
			object obj2 = default(object);
			object obj = default(object);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					P_0 = HighlightArrlSectionCfg.Ⴀ(P_0, '\t'.ToString(), ႥႥ.Ⴅ(1673508743, null, 7), '\u0303', 776);
					num = ⴄ[112] - 29256;
					continue;
				case 8:
				{
					string text = P_0;
					Array array = new char[1];
					(array as char[])[0] = ',';
					obj2 = ႳႳ.Ⴄ(text, (char[])array, 750, 'ʡ');
					num = 6;
					continue;
				}
				case 6:
				case 9:
					num = ((((string[])obj2).Length == 3) ? 1 : 3);
					continue;
				case 1:
				case 2:
					obj = new ArcClientConnectDat();
					num2 = SetDxExtension.Ⴈ(ShowDxFilter.Ⴍ(((string[])obj2)[2], 'ɝ', 624), 845, '\u0338');
					num = ⴀႠ[70] - 49244;
					continue;
				case 4:
				case 5:
					(obj as ArcClientConnectDat).Ⴐ(ShowDxFilter.Ⴍ((obj2 as string[])[0], 'ϟ', 1010), ShowDxFilter.Ⴍ((obj2 as string[])[1], 'ɵ', 600), num2);
					num = ⴄ[123] - 61741;
					continue;
				case 10:
					List.Add((ArcClientConnectDat)obj);
					break;
				case 3:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴐ.Error(P_0 + WxFilters.Ⴀ(null, 6, 103387425) + ex.Message);
		}
		switch (0)
		{
		}
	}

	[SecuritySafeCritical]
	static ArcConnectsCache()
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 3:
				Ⴍ = new object();
				return;
			case 0:
				return;
			}
			ArcClientConnectDat.Ⴍ();
			Ⴐ = HighlightItuZoneCfg.Ⴓ(WxFilters.Ⴀ(null, 8, 103387425), 938, 922);
			num = 3;
		}
	}
}
