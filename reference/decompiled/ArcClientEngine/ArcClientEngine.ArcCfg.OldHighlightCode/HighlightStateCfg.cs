using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Arcx;
using ArcInterfaces.Spots;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using Ⴀ;

namespace ArcClientEngine.ArcCfg.OldHighlightCode;

public sealed class HighlightStateCfg
{
	internal sealed class Ⴄ
	{
		internal ArcClientObjMgr Ⴓ;

		internal Ⴄ()
		{
		}
	}

	private string Ⴀ;

	private Color Ⴓ;

	[XmlIgnore]
	internal Color Ⴈ
	{
		get
		{
			Color ⴓ = Ⴓ;
			UserCmd.Ⴅ[354] = (byte)((UserCmd.Ⴅ[354] | UserCmd.Ⴅ[17]) & 0xF8);
			return ⴓ;
		}
		set
		{
			Ⴓ = ⴓ;
		}
	}

	[Browsable(false)]
	internal string Ⴐ
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			string result = SetDxFilter.Ⴃ(this.Ⴈ, 724, 743);
			Bye.Ⴄ[215] = (char)(Bye.Ⴄ[215] & HighlightCtyCfg.ႠႠ[125] & 0x32);
			return result;
		}
		set
		{
			this.Ⴈ = HighlightArrlSectionCfg.Ⴓ(text, 434, 398);
			ႥႰ.Ⴗ[126] = (char)((ႥႰ.Ⴗ[126] - ႥႰ.Ⴗ[94]) & 0xA5);
		}
	}

	[SpecialName]
	internal string Ⴐ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		return Ⴀ;
	}

	[SpecialName]
	internal void Ⴈ(string P_0)
	{
		Ⴀ = P_0;
	}

	internal HighlightStateCfg()
	{
	}

	public override string ToString()
	{
		return WxFilters.Ⴀ(null, 4, 103388546);
	}

	[SecuritySafeCritical]
	static HighlightStateCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static bool Ⴗ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : WaitCallback
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 7;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄ[192] - 48336;
					continue;
				case 4:
					break;
				case 7:
				{
					int num4 = (P_3 ^ P_2) - 11;
					int num5 = num;
					Bye.Ⴄ[28] = (char)(Bye.Ⴄ[28] & P_2 & 0xD9);
					num2 = (num4 ^ num5) switch
					{
						0 => 2, 
						_ => ⴅ[28] - ⴅ[106], 
					};
					continue;
				}
				case 3:
					result = false;
					goto case 11;
				case 11:
					num2 = ⴀႠ[115] - 48712;
					continue;
				case 2:
					result = ThreadPool.QueueUserWorkItem(P_0, P_1);
					num2 = ⴀႠ[34] - 62559;
					continue;
				case 5:
					num++;
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					num2 = 0;
					continue;
				case 0:
				case 6:
					num2 = ((num3 % 2 != 0) ? (ⴀႠ[48] - 3654) : 9);
					continue;
				case 8:
				case 9:
					return result;
				case 1:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴜ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : WwvSpot
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		IEquatable<string> equatable = default(IEquatable<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[154] - 7297;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄ[296] - 33841;
					continue;
				case 7:
					break;
				case 8:
					num2 = (((P_1 ^ P_2) - 18) ^ num) switch
					{
						0 => ⴀႠ[104] - 61265, 
						1 => 6, 
						_ => 5, 
					};
					continue;
				case 5:
					equatable = null;
					goto case 9;
				case 9:
					num2 = 10;
					continue;
				case 2:
					equatable = P_0.Forecast;
					num2 = 10;
					continue;
				case 0:
				case 3:
				case 6:
					equatable = P_0.GetUserString();
					num2 = 10;
					continue;
				case 10:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 12;
					continue;
				case 12:
					num2 = ((num3 % 2 == 0) ? 1 : 8);
					continue;
				case 1:
					return equatable as string;
				case 4:
					num2 = ⴗ[93] - 63511;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႣႨ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : DataGridViewColumn where _0021_00211 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 9;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴀႠ[64] - 42664;
				break;
			case 8:
				num = (((P_2 ^ P_3) - 36) ^ num3) switch
				{
					0 => 1, 
					1 => ⴗ[111] - 41310, 
					_ => 2, 
				};
				break;
			case 2:
				num = 6;
				break;
			case 1:
			case 4:
				P_0.Name = P_1;
				num = 6;
				break;
			case 3:
				P_0.DataPropertyName = P_1;
				goto case 6;
			case 6:
			{
				int num4 = num3;
				Bye.Ⴄ[165] = (char)((Bye.Ⴄ[165] * Bye.Ⴄ[84]) & 0x88);
				num3 = num4 + 1;
				goto case 5;
			}
			case 5:
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 10;
				break;
			case 10:
				num = ((num2 % 2 != 0) ? 8 : 7);
				break;
			case 0:
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႣႣ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, char P_3) where _0021_00210 : DataGridViewColumn
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 7;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 3;
				break;
			case 0:
			case 3:
				num = (((P_3 ^ P_2) - 8) ^ num3) switch
				{
					0 => 2, 
					_ => 1, 
				};
				break;
			case 1:
			case 5:
				num = ⴄ[265] - 20895;
				break;
			case 2:
				P_0.Width = P_1;
				goto case 4;
			case 4:
			case 6:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = 8;
				break;
			case 8:
				num = ((num2 % 2 != 0) ? 3 : 9);
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႣႰ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, short P_3) where _0021_00210 : string where _0021_00211 : DxSpot
	{
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				break;
			case 0:
				num = (((P_3 ^ P_2) - 98) ^ num2) switch
				{
					0 => 1, 
					_ => 2, 
				};
				break;
			case 2:
				num = 9;
				break;
			case 1:
			case 7:
				P_0.DeserializeClient(P_1);
				goto case 5;
			case 5:
			case 6:
			case 9:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? 3 : 8);
				break;
			case 8:
				num = 0;
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႣႠ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : ArcLogInRqst
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 8;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_3 ^ P_2) - 57) ^ num2) switch
				{
					0 => ⴄ[86] - 24350, 
					_ => 3, 
				};
				break;
			case 0:
			case 3:
				num = 1;
				break;
			case 9:
				P_0.DeserializeNode(P_1);
				goto case 1;
			case 1:
				num2++;
				num3 = 85;
				num4 = 175;
				goto case 5;
			case 5:
				num = ((1400 > num4 - num3 * 8) ? (ⴅ[39] + ⴅ[115]) : (ⴄ[110] - 60794));
				break;
			case 2:
				num = 4;
				break;
			case 6:
			case 7:
				return;
			}
		}
	}
}
