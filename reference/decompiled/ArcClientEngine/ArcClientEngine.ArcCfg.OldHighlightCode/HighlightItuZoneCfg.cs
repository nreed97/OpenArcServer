using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcForms;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcCfg.OldHighlightCode;

public sealed class HighlightItuZoneCfg
{
	internal sealed class ႳႥ
	{
		internal IContainer Ⴈ;

		internal DataGridView Ⴓ;

		internal Label Ⴐ;

		internal ArcClientObjMgr Ⴅ;

		internal FilterType Ⴃ;

		internal BindingSource Ⴄ;

		internal string Ⴍ;

		internal ႳႥ()
		{
		}
	}

	internal sealed class ႳႰ
	{
		internal bool Ⴐ;

		internal bool Ⴓ;

		internal string Ⴍ;

		internal ႳႰ()
		{
		}
	}

	private Color Ⴐ;

	private MultimediaCfg.Ⴍ m_Ⴀ = new MultimediaCfg.Ⴍ();

	[XmlIgnore]
	internal Color Ⴈ
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return Ⴐ;
		}
		set
		{
			Ⴐ = ⴐ;
		}
	}

	[Browsable(false)]
	internal string Ⴀ
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			return SetDxFilter.Ⴃ(this.Ⴈ, 768, 819);
		}
		set
		{
			this.Ⴈ = HighlightArrlSectionCfg.Ⴓ(text, 371, 335);
		}
	}

	[SpecialName]
	internal string Ⴅ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		return this.m_Ⴀ.Ⴍ;
	}

	[SpecialName]
	internal void Ⴈ(string P_0)
	{
		this.m_Ⴀ.Ⴍ = P_0;
	}

	internal HighlightItuZoneCfg()
	{
	}

	public override string ToString()
	{
		string result = WxFilters.Ⴀ(null, 1, 103388998);
		HighlightCtyCfg.ႠႠ[7] = (char)((HighlightCtyCfg.ႠႠ[7] + HighlightCtyCfg.ႠႠ[5]) & 0x1D);
		return result;
	}

	[SecuritySafeCritical]
	static HighlightItuZoneCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static ILog Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[10] - 7240;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
				case 4:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 48) ^ num) switch
					{
						0 => ⴄ[277] - 52008, 
						_ => 9, 
					};
					continue;
				case 9:
					obj = null;
					num2 = ⴄ[187] - 15459;
					continue;
				case 8:
				case 10:
					obj = LogManager.GetLogger(P_0);
					num2 = 11;
					continue;
				case 11:
					num++;
					goto case 2;
				case 2:
				{
					int num3 = 246;
					int num4 = 394;
					num2 = ((1576 > num4 - num3 * 4) ? 1 : (ⴄ[155] - 45032));
					continue;
				}
				case 5:
					num2 = 6;
					continue;
				case 1:
					return (ILog)obj;
				case 0:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴜ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : TextReader
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[38] - 160;
					continue;
				case 3:
					break;
				case 1:
				case 2:
					num2 = (((P_2 ^ P_1) - 85) ^ num) switch
					{
						0 => 4, 
						_ => ⴀႠ[10] - 7239, 
					};
					continue;
				case 7:
					obj = null;
					num2 = 5;
					continue;
				case 0:
				case 4:
					obj = P_0.ReadLine();
					num2 = 5;
					continue;
				case 5:
				case 8:
				{
					num++;
					int num3 = 409;
					int num4 = 819;
					num2 = ((1638 > num4 - num3 * 2) ? (ⴀႠ[2] - 58297) : 6);
					continue;
				}
				case 6:
					num2 = 1;
					continue;
				case 11:
					return obj as string;
				case 9:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Color ႳႷ(short P_0, int P_1)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		Color result = default(Color);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[26] - 10577;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[32] - 52741;
					continue;
				case 9:
					break;
				case 4:
				case 8:
					num2 = (((P_0 ^ P_1) - 99) ^ num) switch
					{
						0 => 14, 
						1 => 0, 
						2 => ⴅ[25] + 1, 
						3 => 6, 
						_ => 5, 
					};
					continue;
				case 5:
					result = default(Color);
					num2 = 10;
					continue;
				case 14:
					result = Color.Red;
					num2 = 10;
					continue;
				case 0:
					result = SystemColors.Control;
					num2 = ⴀႠ[38] - 28687;
					continue;
				case 3:
					result = SystemColors.WindowText;
					num2 = 10;
					continue;
				case 2:
				case 6:
					result = SystemColors.ControlText;
					num2 = ⴅ[102];
					continue;
				case 10:
				case 12:
				{
					int num3 = num;
					Bye.Ⴄ[59] = (char)((Bye.Ⴄ[59] ^ HighlightCtyCfg.ႠႠ[92]) & 0x2E);
					num = num3 + 1;
					int num4 = 572;
					int num5 = 852;
					num2 = ((8520 > num5 - num4 * 10) ? (ⴗ[143] - 39704) : 7);
					continue;
				}
				case 7:
					num2 = 4;
					continue;
				case 1:
					return result;
				case 13:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႳႳ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : WwvSpot
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[55] - 30980;
					continue;
				case 5:
					break;
				case 2:
					num2 = (((P_2 ^ P_1) - 7) ^ num) switch
					{
						0 => 0, 
						_ => 11, 
					};
					continue;
				case 11:
					cloneable = null;
					num2 = 6;
					continue;
				case 0:
				case 10:
					cloneable = P_0.K;
					num2 = ⴅ[109] - 219;
					continue;
				case 6:
				case 7:
				case 9:
				{
					num++;
					int num3 = 178;
					int num4 = 842;
					num2 = ((5894 > num4 - num3 * 7) ? (ⴀႠ[92] - 62199) : (ⴅ[390] - 191));
					continue;
				}
				case 3:
					num2 = 2;
					continue;
				case 4:
					return cloneable as string;
				case 8:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႳႣ<_0021_00210>(_0021_00210 P_0, Color P_1, int P_2, short P_3) where _0021_00210 : DataGridViewLinkColumn
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				continue;
			case 6:
				num = (((P_3 ^ P_2) - 112) ^ num2) switch
				{
					0 => 0, 
					1 => ⴗ[76] - 24775, 
					_ => 9, 
				};
				continue;
			case 9:
				num = ⴄ[162] - 34569;
				continue;
			case 0:
			case 2:
			case 4:
				P_0.ActiveLinkColor = P_1;
				goto case 3;
			case 3:
				num = 1;
				continue;
			case 8:
				P_0.LinkColor = P_1;
				break;
			case 1:
				break;
			case 5:
				return;
			}
			num2++;
			int num3 = 1136;
			int num4 = 253;
			int num5;
			if (284 >= num3 / 4 - num4)
			{
				num5 = 5;
			}
			else
			{
				char num6 = ⴀႠ[26];
				UserCmd.Ⴅ[6] = (byte)(UserCmd.Ⴅ[6] & P_2 & 0x22);
				num5 = num6 - 10575;
			}
			num = num5;
		}
	}

	[SecuritySafeCritical]
	internal static void ႳႤ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, char P_3) where _0021_00210 : DataGridView
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 7;
				break;
			case 7:
				num = (((P_2 ^ P_3) - 94) ^ num2) switch
				{
					0 => 9, 
					_ => 8, 
				};
				break;
			case 6:
			case 8:
				num = ⴀႠ[108] - 45139;
				break;
			case 9:
				P_0.FirstDisplayedScrollingRowIndex = P_1;
				goto case 4;
			case 4:
				num2++;
				goto case 3;
			case 3:
			{
				int num3 = P_3 * P_3 + P_3;
				ႥႰ.Ⴗ[33] = (char)((ႥႰ.Ⴗ[33] + P_2) & 0x9C);
				num = ((num3 % 2 == 0) ? (ⴀႠ[10] - 7244) : 0);
				break;
			}
			case 0:
				num = 7;
				break;
			case 1:
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႳႠ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, char P_3) where _0021_00210 : DataGridViewDataErrorEventArgs
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႠ[127] - 366;
				break;
			case 5:
			case 9:
				num = (((P_2 ^ P_3) - 65) ^ num2) switch
				{
					0 => 4, 
					_ => 7, 
				};
				break;
			case 7:
				num = 6;
				break;
			case 1:
			case 4:
				P_0.ThrowException = P_1;
				goto case 6;
			case 6:
				num2++;
				goto case 8;
			case 8:
			{
				int num3 = 424;
				int num4 = 874;
				int num5 = num4 - num3 * 9;
				Bye.Ⴄ[227] = (char)(Bye.Ⴄ[227] & P_2 & 0xA4);
				num = ((7866 > num5) ? (ⴗ[24] - 32650) : 3);
				break;
			}
			case 3:
				num = 5;
				break;
			case 0:
				return;
			}
		}
	}
}
