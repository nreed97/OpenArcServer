using System;
using System.Security;
using System.Timers;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using log4net;

namespace Ⴀ;

internal sealed class ႳႣ
{
	private static readonly ILog m_Ⴃ;

	private readonly DateTime m_Ⴗ = FilterPicker.ႥႰ('\u0309', '\u0354');

	private FilterCfg.Ⴐ m_Ⴄ = new FilterCfg.Ⴐ();

	internal ႳႣ(ArcClientObjMgr P_0)
	{
		this.m_Ⴄ.Ⴅ = 99;
		this.m_Ⴄ.Ⴐ = 99;
		base._002Ector();
		this.m_Ⴄ.Ⴀ = P_0;
		object obj = new Timer();
		HighlightCountyCfg.ႷႨ<Timer, ElapsedEventHandler>(obj as Timer, Ⴅ, 'σ', '\u038d');
		((Timer)obj).Interval = 1000.0;
		(obj as Timer).Enabled = true;
	}

	private void Ⴅ(object P_0, ElapsedEventArgs P_1)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 6;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num)
			{
			default:
				dateTime = FilterPicker.ႥႰ('Þ', '\u0083');
				num = ((FilterEditor.ႷႥ(ref dateTime, 353, 318) == this.m_Ⴄ.Ⴅ) ? 7 : 9);
				break;
			case 9:
				num = ((HighlightCqZoneCfg.ႣႨ(ref dateTime, 950, 984) >= 30) ? 7 : 3);
				break;
			case 3:
			{
				int ⴅ = FilterEditor.ႷႥ(ref dateTime, 543, 576);
				this.m_Ⴄ.Ⴅ = ⴅ;
				num = ⴀႠ[63] - 29190;
				break;
			}
			case 10:
				Ⴀ(FilterEditor.ႷႥ(ref dateTime, 347, 260));
				goto case 7;
			case 7:
				num = ((FilterEditor.ႷႥ(ref dateTime, 443, 484) == this.m_Ⴄ.Ⴐ) ? 5 : 4);
				break;
			case 4:
				num = ((dateTime.Second < 30) ? 5 : (ⴀႠ[81] - 54672));
				break;
			case 0:
			case 8:
			{
				int minute = dateTime.Minute;
				this.m_Ⴄ.Ⴐ = minute;
				Ⴓ(dateTime.Minute);
				return;
			}
			case 5:
				return;
			}
		}
	}

	private void Ⴀ(int P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 3:
				P_0 -= 10;
				num = 10;
				continue;
			default:
				num = ((P_0 > 9) ? (ⴄ[217] - 54988) : (ⴀႠ[101] - 46657));
				continue;
			case 2:
			case 18:
				num = P_0 switch
				{
					0 => 9, 
					1 => 11, 
					2 => 13, 
					3 => 6, 
					4 => 7, 
					5 => ⴀႠ[88] - 30694, 
					6 => ⴅ[4], 
					7 => 14, 
					8 => ⴀႠ[2] - 58293, 
					9 => ⴅ[341] - 120, 
					_ => 1, 
				};
				continue;
			case 1:
				num = ⴄ[47] - 24185;
				continue;
			case 9:
				Ⴃ();
				Ⴍ();
				num = 16;
				continue;
			case 11:
				Ⴓ();
				Ⴗ();
				num = 16;
				continue;
			case 13:
				Ⴈ();
				Ⴍ();
				num = 16;
				continue;
			case 6:
				Ⴀ();
				Ⴗ();
				num = 16;
				continue;
			case 7:
				Ⴄ();
				Ⴍ();
				num = ⴄ[249] - 5076;
				continue;
			case 12:
				Ⴐ();
				Ⴗ();
				num = 16;
				continue;
			case 8:
			case 17:
				Ⴅ();
				Ⴍ();
				num = 16;
				continue;
			case 14:
				Ⴜ();
				Ⴗ();
				num = 16;
				continue;
			case 15:
				ႷႭ();
				Ⴍ();
				goto case 0;
			case 0:
				num = 16;
				continue;
			case 5:
				ႷႷ();
				Ⴗ();
				break;
			case 16:
				break;
			}
			break;
		}
		this.m_Ⴄ.Ⴀ.Caches.Dx.DxSpotRates.Ⴃ();
	}

	private static void Ⴓ(int P_0)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 5:
				P_0 -= 10;
				num = ⴅ[154] - 212;
				break;
			default:
				num = ((P_0 > 9) ? (ⴀႠ[61] - 26816) : 4);
				break;
			case 0:
			case 4:
				switch (P_0)
				{
				default:
					num = 3;
					break;
				case 0:
					ႷႣ();
					return;
				case 1:
					ႷႳ();
					return;
				case 2:
					ႷႨ();
					return;
				case 3:
					ႷႠ();
					return;
				case 4:
					ႷႤ();
					return;
				case 5:
					ႷႰ();
					return;
				case 6:
					ႷႥ();
					return;
				case 7:
					ႷႼ();
					return;
				case 8:
					ႣႭ();
					return;
				case 9:
					ႣႷ();
					return;
				}
				break;
			case 3:
				return;
			}
		}
	}

	private void Ⴍ()
	{
	}

	private static void Ⴗ()
	{
	}

	private void Ⴃ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 0;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num)
			{
			default:
				dateTime = FilterPicker.ႥႰ('\u034a', '\u0317');
				num = ((FilterEditor.ႷႥ(ref dateTime, 391, 472) == 0) ? 8 : 4);
				break;
			case 4:
				num = ((FilterEditor.ႷႥ(ref dateTime, 659, 716) != 30) ? (ⴀႠ[50] - 49524) : 8);
				break;
			case 2:
			case 3:
			case 8:
				ႣႳ();
				goto case 5;
			case 5:
				num = ((dateTime.Minute != 0) ? 7 : 6);
				break;
			case 6:
				ႣႣ();
				return;
			case 7:
				return;
			}
		}
	}

	private void Ⴓ()
	{
		this.m_Ⴄ.Ⴀ.Caches.Ⴀ().Ⴍ();
	}

	private static void Ⴈ()
	{
	}

	private static void Ⴀ()
	{
	}

	private static void Ⴄ()
	{
	}

	private static void Ⴐ()
	{
	}

	private static void Ⴅ()
	{
	}

	private static void Ⴜ()
	{
	}

	private static void ႷႭ()
	{
	}

	private static void ႷႷ()
	{
	}

	private static void ႷႣ()
	{
	}

	private static void ႷႳ()
	{
	}

	private static void ႷႨ()
	{
	}

	private static void ႷႠ()
	{
	}

	private static void ႷႤ()
	{
	}

	private static void ႷႰ()
	{
	}

	private static void ႷႥ()
	{
	}

	private static void ႷႼ()
	{
	}

	private static void ႣႭ()
	{
	}

	private static void ႣႷ()
	{
	}

	private static void ႣႣ()
	{
	}

	private static void ႣႳ()
	{
	}

	[SecuritySafeCritical]
	static ႳႣ()
	{
		ArcClientConnectDat.Ⴍ();
		ႳႣ.m_Ⴃ = HighlightItuZoneCfg.Ⴓ(ႥႥ.Ⴅ(1673507351, null, 7), 445, 397);
	}
}
