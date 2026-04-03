using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ArcShared;
using Ⴀ;

namespace ArcClientEngine.ArcCfg;

public sealed class UserInfo
{
	private float Ⴗ;

	private string Ⴄ;

	private string Ⴃ;

	private ႥႤ.Ⴓ m_Ⴓ = new ႥႤ.Ⴓ();

	[Description("Latitude")]
	public float Latitude
	{
		get
		{
			char[] ⴗ = Ⴀ.ႥႰ.Ⴗ;
			return this.m_Ⴓ.Ⴗ;
		}
		set
		{
			this.m_Ⴓ.Ⴗ = value;
			HighlightCtyCfg.ႠႠ[80] = (char)((HighlightCtyCfg.ႠႠ[80] ^ HighlightCtyCfg.ႠႠ[52]) & 0x2A);
		}
	}

	[Description("Longitude")]
	public float Longitude
	{
		get
		{
			float ⴗ = Ⴗ;
			HighlightCtyCfg.ႠႠ[105] = (char)((HighlightCtyCfg.ႠႠ[105] + Bye.Ⴄ[284]) & 0x1D);
			return ⴗ;
		}
		set
		{
			Ⴗ = value;
		}
	}

	[Description("Cty")]
	public string Cty
	{
		get
		{
			return this.m_Ⴓ.Ⴓ;
		}
		set
		{
			this.m_Ⴓ.Ⴓ = value as string;
		}
	}

	[Description("Cont")]
	public string Cont
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	[Description("CqZone")]
	public string CqZone
	{
		get
		{
			return this.m_Ⴓ.Ⴃ;
		}
		set
		{
			this.m_Ⴓ.Ⴃ = value;
		}
	}

	[Description("ItuZone")]
	public string ItuZone
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	internal void Ⴍ()
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Latitude = 30.88f;
				Longitude = -97.4f;
				goto case 3;
			case 3:
				Cty = string.Empty;
				break;
			case 4:
				break;
			case 1:
				CqZone = string.Empty;
				ItuZone = string.Empty;
				return;
			}
			Cont = string.Empty;
			num = ⴄ[101] - 33648;
		}
	}

	[SecuritySafeCritical]
	static UserInfo()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static Color Ⴅ(int P_0, int P_1, int P_2, short P_3, int P_4)
	{
		char[] ⴗ = Ⴀ.ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		Color result = default(Color);
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
					num2 = 11;
					continue;
				case 11:
					break;
				case 7:
					num2 = (((P_4 ^ P_3) - 30) ^ num) switch
					{
						0 => 10, 
						_ => ⴗ[37] - 54916, 
					};
					continue;
				case 2:
				case 5:
					result = default(Color);
					goto case 6;
				case 6:
					num2 = 0;
					continue;
				case 10:
					result = Color.FromArgb(P_0, P_1, P_2);
					num2 = 0;
					continue;
				case 0:
				{
					num++;
					num3 = P_3 * P_3;
					int num4 = num3;
					HighlightCtyCfg.ႠႠ[80] = (char)((HighlightCtyCfg.ႠႠ[80] ^ HighlightCtyCfg.ႠႠ[28]) & 0xE5);
					num3 = P_3 + num4;
					num2 = 9;
					continue;
				}
				case 9:
					num2 = ((num3 % 2 != 0) ? (ⴗ[62] - 59545) : (ⴗ[37] - 54917));
					continue;
				case 4:
					return result;
				case 1:
				case 8:
					num2 = ⴅ[39] + 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : TextReader
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 9;
				break;
			case 9:
				num = (((P_2 ^ P_1) - 8) ^ num2) switch
				{
					0 => 5, 
					_ => 3, 
				};
				break;
			case 3:
				num = 2;
				break;
			case 4:
			case 5:
				P_0.Close();
				goto case 2;
			case 2:
				num2++;
				goto case 1;
			case 1:
				num = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴄ[134] - 3666) : 6);
				break;
			case 6:
				num = 9;
				break;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, float P_1, int P_2, int P_3) where _0021_00210 : CtyInfo
	{
		char[] ⴗ = Ⴀ.ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 3;
				break;
			case 3:
				num = (((P_3 ^ P_2) - 101) ^ num2) switch
				{
					0 => 0, 
					1 => ⴗ[55] - 30978, 
					_ => 9, 
				};
				break;
			case 9:
				num = 10;
				break;
			case 0:
			case 8:
				P_0.Latitude = P_1;
				num = 10;
				break;
			case 5:
			case 7:
				P_0.Heading = P_1;
				goto case 6;
			case 6:
			case 10:
			{
				num2++;
				int num3 = 575;
				int num4 = 792;
				num = ((7128 > num4 - num3 * 9) ? 1 : (ⴀႠ[94] - 21824));
				break;
			}
			case 4:
				num = ⴀႠ[87] - 21217;
				break;
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : Cursor where _0021_00211 : Control
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 1;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴀႠ[31] - 4533;
				break;
			case 9:
				num = (((P_3 ^ P_2) - 20) ^ num3) switch
				{
					0 => 3, 
					_ => 8, 
				};
				break;
			case 8:
				num = 7;
				break;
			case 3:
				P_0.Cursor = P_1;
				goto case 2;
			case 2:
			case 7:
				num3++;
				goto case 0;
			case 0:
				num2 = P_3 * P_3;
				goto case 6;
			case 6:
				num2 = P_3 + num2;
				num = 4;
				break;
			case 4:
				num = ((num2 % 2 != 0) ? (ⴀႠ[21] - 55) : 5);
				break;
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႣ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, short P_3) where _0021_00210 : Control
	{
		char[] ⴗ = Ⴀ.ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 1;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴗ[55] - 30978;
				break;
			case 5:
			case 7:
				num = (((P_3 ^ P_2) - 101) ^ num2) switch
				{
					0 => ⴅ[259] - 70, 
					_ => 8, 
				};
				break;
			case 8:
				num = 3;
				break;
			case 9:
				P_0.AutoSize = P_1;
				goto case 3;
			case 3:
			case 4:
				num2++;
				num3 = 393;
				goto case 2;
			case 2:
			{
				int num4 = 712;
				num = ((1424 > num4 - num3 * 2) ? (ⴀႠ[108] - 45137) : (ⴗ[134] - 12483));
				break;
			}
			case 0:
				num = ⴗ[90] - 35257;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte ႥႥ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DxSpot
	{
		char[] ⴗ = Ⴀ.ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		byte result = default(byte);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[4] - 3442;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[61] - 17143;
					continue;
				case 1:
				case 11:
					break;
				case 10:
					num2 = (((P_1 ^ P_2) - 74) ^ num) switch
					{
						0 => 9, 
						1 => ⴀႠ[92] - 62203, 
						_ => 7, 
					};
					continue;
				case 7:
					result = 29;
					num2 = 5;
					continue;
				case 9:
				case 12:
					result = P_0.SpotterCqZone;
					goto case 4;
				case 4:
					num2 = ⴗ[98] - 39641;
					continue;
				case 0:
					result = P_0.SpotterItuZone;
					num2 = 5;
					continue;
				case 5:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 6;
					continue;
				case 6:
					num2 = ((num3 % 2 != 0) ? (ⴅ[194] - 19) : 3);
					continue;
				case 3:
					return result;
				case 8:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႰ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, int P_3) where _0021_00210 : ServerIoCfg
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄ[86] - 24352;
				break;
			case 7:
				num = (((P_2 ^ P_3) - 124) ^ num2) switch
				{
					0 => 6, 
					_ => 8, 
				};
				break;
			case 8:
			case 9:
				num = 0;
				break;
			case 3:
			case 6:
				P_0.Port = P_1;
				goto case 0;
			case 0:
			{
				num2++;
				int num3 = 176;
				int num4 = 625;
				num = ((3750 > num4 - num3 * 6) ? 5 : (ⴄ[269] - 37548));
				break;
			}
			case 1:
			case 4:
				num = 7;
				break;
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime ႥႤ(char P_0, short P_1)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = Ⴀ.ႥႰ.Ⴗ;
		DateTime result = default(DateTime);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 5:
					num2 = (((P_1 ^ P_0) - 14) ^ num) switch
					{
						0 => ⴄ[263] - 60384, 
						_ => ⴄ[127] - 373, 
					};
					continue;
				case 1:
					result = default(DateTime);
					num2 = ⴀႠ[0] - 49957;
					continue;
				case 3:
				case 9:
					result = DateTime.Now;
					num2 = 0;
					continue;
				case 0:
					num++;
					num4 = P_0 * P_0;
					num4 = P_0 + num4;
					num2 = ⴅ[4];
					continue;
				case 6:
				case 8:
					num2 = ((num4 % 2 != 0) ? 5 : (ⴗ[145] - 59481));
					continue;
				case 4:
				case 7:
					return result;
				case 10:
				{
					char num3 = ⴄ[159];
					Ⴀ.ႥႰ.Ⴗ[135] = (char)((Ⴀ.ႥႰ.Ⴗ[135] - P_1) & 0xE);
					num2 = num3 - 48362;
					continue;
				}
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႷ(int P_0, short P_1, short P_2)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 0;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				continue;
			case 2:
				num = (((P_1 ^ P_2) - 29) ^ num2) switch
				{
					0 => 3, 
					_ => 1, 
				};
				continue;
			case 1:
			case 5:
				num = ⴅ[234] - ⴅ[56];
				continue;
			case 3:
			case 6:
				Thread.Sleep(P_0);
				goto case 7;
			case 7:
				num2++;
				num3 = 2961;
				break;
			case 8:
				break;
			case 4:
				return;
			}
			int num4 = 711;
			num = ((987 < num3 / 3 - num4) ? 2 : ⴅ[115]);
		}
	}
}
