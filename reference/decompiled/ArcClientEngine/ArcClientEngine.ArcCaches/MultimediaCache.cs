using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public sealed class MultimediaCache
{
	internal sealed class Ⴗ
	{
		internal string Ⴈ;

		internal int Ⴃ;

		internal Ⴗ()
		{
		}
	}

	internal sealed class Ⴓ
	{
		internal bool Ⴐ;

		internal string Ⴄ;

		internal string Ⴍ;

		internal Ⴓ()
		{
		}
	}

	internal sealed class Ⴀ
	{
		internal UserCmdLookup Ⴈ;

		internal Ⴀ()
		{
		}
	}

	private ConcurrentDictionary<string, DateTime> m_Ⴃ;

	[SpecialName]
	private ConcurrentDictionary<string, DateTime> Ⴃ()
	{
		return this.m_Ⴃ;
	}

	[SpecialName]
	private void Ⴅ(ConcurrentDictionary<string, DateTime> P_0)
	{
		this.m_Ⴃ = P_0;
	}

	internal MultimediaCache()
	{
		Ⴅ(new ConcurrentDictionary<string, DateTime>());
	}

	internal bool Ⴍ(DxSpot P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		bool result = default(bool);
		while (true)
		{
			IEquatable<string> equatable = ႥႭ.ႳႣ((object)FilterViewer.ႨႥ(P_0, 775, '\u0327'), (object)HighlightCqZoneCfg.ႣႣ(P_0, 789, '\u0353'), (object)FilterViewer.ႨႥ(P_0, 92, '~'), 'ě', 288);
			int num = ⴀႠ[10] - ⴀႠ[10];
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
					return !Ⴃ().TryAdd(equatable as string, DateTime.UtcNow);
				case 5:
					return result;
				}
				break;
			}
		}
	}

	internal void Ⴍ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 1;
		int num4 = default(int);
		DateTime dateTime = default(DateTime);
		KeyValuePair<string, DateTime> current = default(KeyValuePair<string, DateTime>);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				goto case 2;
			case 2:
			case 3:
			{
				DateTime dateTime2 = FilterPicker.ႥႰ('ʮ', '\u02f3');
				dateTime = TelnetServerCfg.Ⴈ(ref dateTime2, -10.0, 950, 983);
				break;
			}
			case 0:
				break;
			case 4:
			{
				object enumerator = Ⴃ().GetEnumerator();
				try
				{
					int num2 = 8;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = 2;
							continue;
						case 4:
						{
							current = ((IEnumerator<KeyValuePair<string, DateTime>>)enumerator).Current;
							DateTime value = current.Value;
							num2 = ((!HighlightCfg.ႳႣ(value, dateTime, 288, 282)) ? (ⴄ[2] - 13952) : (ⴄ[174] - 46418));
							continue;
						}
						case 1:
							num4++;
							goto case 3;
						case 3:
						{
							Ⴃ().TryRemove(current.Key, out var _);
							num2 = ⴅ[115] / 2;
							continue;
						}
						case 2:
						{
							bool num3 = (enumerator as IEnumerator<KeyValuePair<string, DateTime>>).MoveNext();
							Bye.Ⴄ[164] = (char)((Bye.Ⴄ[164] ^ HighlightCtyCfg.ႠႠ[57]) & 0x90);
							num2 = (num3 ? 4 : (ⴄ[290] - 49145));
							continue;
						}
						case 6:
							break;
						}
						break;
					}
				}
				finally
				{
					int num5 = 5;
					while (true)
					{
						int num6;
						switch (num5)
						{
						default:
							num6 = ((!(enumerator is IEnumerator<KeyValuePair<string, DateTime>>)) ? (ⴀႠ[96] - 2584) : 2);
							goto IL_019d;
						case 2:
						case 4:
						case 6:
							(enumerator as IEnumerator<KeyValuePair<string, DateTime>>).Dispose();
							break;
						case 1:
							break;
						}
						break;
						IL_019d:
						num5 = num6;
					}
				}
				switch (0)
				{
				}
				return;
			}
			}
			num = ⴄ[187] - 15466;
		}
	}

	[SecuritySafeCritical]
	static MultimediaCache()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static string Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, char P_3) where _0021_00210 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		IComparable comparable = default(IComparable);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 1;
					continue;
				case 1:
				case 9:
					break;
				case 6:
				{
					int num5;
					switch (((P_2 ^ P_3) - 99) ^ num)
					{
					default:
						num5 = 8;
						break;
					case 0:
					{
						char num6 = ⴀႠ[24];
						UserCmd.Ⴅ[268] = (byte)((UserCmd.Ⴅ[268] ^ P_1) & 0xF1);
						num5 = num6 - 40403;
						break;
					}
					case 1:
						num5 = 5;
						break;
					}
					num2 = num5;
					continue;
				}
				case 8:
					comparable = null;
					goto case 0;
				case 0:
					num2 = 3;
					continue;
				case 11:
					comparable = P_0.Substring(P_1);
					num2 = ⴅ[152] - 62;
					continue;
				case 5:
				case 10:
					comparable = P_0.PadLeft(P_1);
					num2 = 3;
					continue;
				case 3:
				{
					num++;
					int num3 = 345;
					int num4 = 815;
					num2 = ((1630 > num4 - num3 * 2) ? 4 : (ⴗ[125] - 55796));
					continue;
				}
				case 2:
					num2 = 6;
					continue;
				case 4:
					return (string)comparable;
				case 12:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, DockStyle P_1, int P_2, short P_3) where _0021_00210 : Control
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				break;
			case 6:
				num = (((P_3 ^ P_2) - 61) ^ num2) switch
				{
					0 => ⴗ[152] - 32165, 
					_ => ⴄ[159] - 48360, 
				};
				break;
			case 7:
				num = ⴅ[115];
				break;
			case 1:
			case 2:
			case 8:
				P_0.Dock = P_1;
				goto case 3;
			case 3:
			case 4:
			{
				num2++;
				int num3 = 66;
				int num4 = 185;
				num = ((370 <= num4 - num3 * 2) ? 5 : 0);
				break;
			}
			case 5:
				num = ⴄ[13] - 20654;
				break;
			case 0:
				return;
			}
		}
	}
}
