using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public class ArcClientConnectDat
{
	private string Ⴀ;

	private static bool Ⴃ;

	private MultimediaCache.Ⴗ m_Ⴄ = new MultimediaCache.Ⴗ();

	public string Call
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	public string Url
	{
		get
		{
			byte[] ⴅ = UserCmd.Ⴅ;
			return this.m_Ⴄ.Ⴈ;
		}
		set
		{
			this.m_Ⴄ.Ⴈ = value;
		}
	}

	public int Port
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			return this.m_Ⴄ.Ⴃ;
		}
		set
		{
			this.m_Ⴄ.Ⴃ = value;
		}
	}

	[SecuritySafeCritical]
	static ArcClientConnectDat()
	{
		Ⴍ();
	}

	[SecuritySafeCritical]
	internal static void Ⴍ()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				if (Ⴃ)
				{
					return;
				}
				break;
			case 0:
			case 3:
			case 4:
			{
				_Type typeFromHandle;
				Monitor.Enter(typeFromHandle = typeof(ArcClientConnectDat));
				try
				{
					int num2 = 2;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = (Ⴃ ? 4 : 3);
							continue;
						case 3:
							Ⴃ = true;
							AppDomain.CurrentDomain.ResourceResolve += SkimmerSpotRateGraph.Ⴍ;
							break;
						case 1:
							break;
						case 0:
						case 4:
						case 5:
							goto end_IL_0054;
						}
						num2 = 4;
						continue;
						end_IL_0054:
						break;
					}
				}
				finally
				{
					Monitor.Exit(typeFromHandle as Type);
				}
				int num3 = 2;
				while (true)
				{
					switch (num3)
					{
					default:
						num3 = ⴗ[61] - 17140;
						break;
					case 0:
					case 1:
						/*OpCode not supported: LdMemberToken*/;
						num3 = ⴀႠ[84] - 18798;
						break;
					case 4:
						return;
					}
				}
			}
			}
			num = ⴀႠ[81] - 54677;
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : AnnWxSpot
	{
		char[] ⴄ = Bye.Ⴄ;
		IComparable<string> comparable = default(IComparable<string>);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 7:
					num2 = (((P_2 ^ P_1) - 6) ^ num) switch
					{
						0 => ⴄ[300] - 46372, 
						_ => 9, 
					};
					continue;
				case 9:
					comparable = null;
					num2 = 2;
					continue;
				case 0:
				case 4:
				case 6:
					comparable = P_0.To;
					num2 = 2;
					continue;
				case 2:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 10 : 11);
					continue;
				case 8:
				case 11:
					num2 = 7;
					continue;
				case 10:
					return (string)comparable;
				case 1:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, Size P_1, char P_2, int P_3) where _0021_00210 : Control
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄ[37] - 39515;
				continue;
			case 8:
				num = (((P_3 ^ P_2) - 93) ^ num2) switch
				{
					0 => 1, 
					_ => 3, 
				};
				continue;
			case 3:
			case 6:
				num = 7;
				continue;
			case 0:
			case 1:
			case 4:
				P_0.Size = P_1;
				break;
			case 7:
				break;
			case 2:
				return;
			}
			num2++;
			int num3 = 936;
			int num4 = 436;
			num = ((468 < num3 / 2 - num4) ? (ⴄ[101] - 33641) : (ⴗ[103] - 55689));
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, SizeF P_1, int P_2, short P_3) where _0021_00210 : ContainerControl
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_2 ^ P_3) - 17) ^ num2) switch
				{
					0 => 3, 
					_ => ⴅ[17], 
				};
				break;
			case 0:
				num = ⴗ[54] - 48792;
				break;
			case 1:
			case 3:
			case 8:
				P_0.AutoScaleDimensions = P_1;
				goto case 7;
			case 7:
			{
				num2++;
				int num3 = 162;
				int num4 = 503;
				num = ((1006 > num4 - num3 * 2) ? 6 : (ⴗ[98] - 39644));
				break;
			}
			case 2:
				num = 4;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, char P_3) where _0021_00210 : DataGridView
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 1;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 2;
				break;
			case 2:
				num = (((P_3 ^ P_2) - 8) ^ num3) switch
				{
					0 => ⴗ[6] - 61627, 
					1 => ⴄ[66] - 59668, 
					2 => ⴅ[66] - 120, 
					_ => 11, 
				};
				break;
			case 11:
				num = 5;
				break;
			case 6:
				P_0.AllowUserToOrderColumns = P_1;
				num = ⴗ[118] - 65331;
				break;
			case 8:
			case 10:
				P_0.ReadOnly = P_1;
				goto case 0;
			case 0:
				num = ⴅ[285];
				break;
			case 4:
				P_0.AutoGenerateColumns = P_1;
				goto case 5;
			case 5:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				goto case 3;
			case 3:
				num = 7;
				break;
			case 7:
				num = ((num2 % 2 != 0) ? 2 : 9);
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, short P_3) where _0021_00210 : ButtonBase
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 5;
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
				num = (((P_2 ^ P_3) - 17) ^ num2) switch
				{
					0 => 4, 
					_ => 7, 
				};
				break;
			case 7:
				num = 9;
				break;
			case 4:
				P_0.UseVisualStyleBackColor = P_1;
				goto case 0;
			case 0:
			case 9:
			{
				num2++;
				int num3 = 162;
				int num4 = 503;
				num = ((1006 > num4 - num3 * 2) ? ⴅ[25] : (ⴗ[0] - 29158));
				break;
			}
			case 1:
				num = 6;
				break;
			case 2:
			case 3:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႭ<_0021_00210>(_0021_00210 P_0, DataGridViewTriState P_1, short P_2, char P_3) where _0021_00210 : DataGridViewCellStyle
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 8;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄ[0] - 30357;
				break;
			case 5:
				num = (((P_3 ^ P_2) - 98) ^ num2) switch
				{
					0 => 6, 
					_ => ⴗ[28] - 37804, 
				};
				break;
			case 4:
				num = ⴅ[154] - ⴅ[364];
				break;
			case 6:
				P_0.WrapMode = P_1;
				goto case 0;
			case 0:
			case 3:
			case 7:
				num2++;
				num3 = 716;
				goto case 9;
			case 9:
			{
				int num4 = 939;
				num = ((6573 > num4 - num3 * 7) ? 1 : (ⴅ[4] / 4));
				break;
			}
			case 2:
				num = 5;
				break;
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႷ<_0021_00210>(_0021_00210 P_0, LinkBehavior P_1, char P_2, short P_3) where _0021_00210 : DataGridViewLinkColumn
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				break;
			case 2:
				num = (((P_2 ^ P_3) - 102) ^ num2) switch
				{
					0 => 5, 
					_ => ⴄ[196] - 35769, 
				};
				break;
			case 1:
				num = ⴄ[201] - 44567;
				break;
			case 4:
			case 5:
			case 7:
				P_0.LinkBehavior = P_1;
				goto case 8;
			case 8:
			case 9:
			{
				num2++;
				int num3 = 205;
				int num4 = 439;
				num = ((2634 <= num4 - num3 * 6) ? 6 : 0);
				break;
			}
			case 6:
				num = ⴀႠ[62] - 58870;
				break;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႷႠ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : Control
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 9:
					break;
				case 3:
					num2 = (((P_2 ^ P_1) - 39) ^ num) switch
					{
						0 => ⴀႠ[64] - 42666, 
						_ => 2, 
					};
					continue;
				case 2:
					comparable = null;
					num2 = 0;
					continue;
				case 6:
					comparable = P_0.Text;
					num2 = ⴀႠ[90] - 47371;
					continue;
				case 0:
				case 4:
					num++;
					num3 = 2886;
					num4 = 578;
					goto case 1;
				case 1:
					num2 = ((962 < num3 / 3 - num4) ? 3 : 5);
					continue;
				case 5:
				case 7:
					return (string)comparable;
				case 8:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႷႣ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : string where _0021_00211 : FileSystemWatcher
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 5;
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = ⴗ[88] - 27882;
				continue;
			case 3:
				num = (((P_2 ^ P_3) - 127) ^ num4) switch
				{
					0 => 8, 
					_ => 1, 
				};
				continue;
			case 1:
			case 9:
				num = ⴅ[17];
				continue;
			case 8:
				P_0.Path = P_1;
				goto case 0;
			case 0:
			{
				num4++;
				num3 = 225;
				int num5 = num3;
				num2 = num5 * num5;
				num = ⴗ[82] - 57054;
				continue;
			}
			case 7:
				num2 = num3 + num2;
				break;
			case 2:
				break;
			case 4:
			case 6:
				return;
			}
			num = ((num2 % 2 != 0) ? (ⴅ[4] - 5) : 6);
		}
	}
}
