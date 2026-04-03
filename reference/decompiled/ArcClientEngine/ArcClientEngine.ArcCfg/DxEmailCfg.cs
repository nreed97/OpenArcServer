using System.ComponentModel;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using Ⴀ;

namespace ArcClientEngine.ArcCfg;

public sealed class DxEmailCfg
{
	private string Ⴅ;

	private string Ⴓ;

	private MultimediaCache.Ⴓ m_Ⴈ = new MultimediaCache.Ⴓ();

	[Description("DxAlertEnabled")]
	public bool DxAlertEnabled
	{
		get
		{
			char[] ⴗ = ႥႰ.Ⴗ;
			return this.m_Ⴈ.Ⴐ;
		}
		set
		{
			bool ⴐ = value;
			this.m_Ⴈ.Ⴐ = ⴐ;
		}
	}

	[Description("DxAlertFilter")]
	public string Filter
	{
		get
		{
			string ⴅ = Ⴅ;
			HighlightCtyCfg.ႠႠ[129] = (char)((HighlightCtyCfg.ႠႠ[129] ^ HighlightCtyCfg.ႠႠ[112]) & 0x9E);
			return ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	[Description("MailFrom")]
	public string MailFrom
	{
		get
		{
			string ⴄ = this.m_Ⴈ.Ⴄ;
			ႥႰ.Ⴗ[20] = (char)((ႥႰ.Ⴗ[20] - HighlightCtyCfg.ႠႠ[62]) & 0xFD);
			return ⴄ;
		}
		set
		{
			this.m_Ⴈ.Ⴄ = value;
		}
	}

	[Description("MailTo")]
	public string MailTo
	{
		get
		{
			return this.m_Ⴈ.Ⴍ;
		}
		set
		{
			this.m_Ⴈ.Ⴍ = value;
		}
	}

	[Description("MailServer")]
	public string MailServer
	{
		get
		{
			return Ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	public DxEmailCfg()
	{
		MailFrom = string.Empty;
		MailTo = string.Empty;
		Filter = string.Empty;
		MailServer = string.Empty;
	}

	internal void Ⴗ()
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 4:
				Filter = WxFilters.Ⴀ(null, 0, 103388863);
				MailServer = ႥႥ.Ⴅ(1673508526, null, 8);
				return;
			case 2:
				return;
			}
			MailFrom = WxFilters.Ⴀ(null, 6, 103388801);
			MailTo = ႥႥ.Ⴅ(1673508504, null, 0);
			num = 4;
		}
	}

	[SecuritySafeCritical]
	static DxEmailCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static Color Ⴍ(short P_0, int P_1)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		Color result = default(Color);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[24] - 32647;
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
					num2 = (((P_1 ^ P_0) - 118) ^ num) switch
					{
						0 => ⴄ[4] - 10461, 
						1 => 12, 
						_ => 2, 
					};
					continue;
				case 1:
				case 2:
					result = default(Color);
					num2 = ⴅ[17];
					continue;
				case 11:
					result = Color.Blue;
					num2 = ⴀႠ[112] - ⴀႠ[112];
					continue;
				case 8:
				case 12:
					result = Color.Black;
					num2 = ⴗ[114] - 15475;
					continue;
				case 0:
					num++;
					num2 = (((P_0 * P_0 + P_0) % 2 == 0) ? 4 : (ⴀႠ[10] - 7236));
					continue;
				case 5:
				case 10:
					num2 = ⴀႠ[111] - 49558;
					continue;
				case 4:
					return result;
				case 7:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, char P_3) where _0021_00210 : Control
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 0;
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
				continue;
			case 4:
				num = (((P_2 ^ P_3) - 49) ^ num2) switch
				{
					0 => ⴄ[105] - 59711, 
					_ => ⴗ[59] - 33053, 
				};
				continue;
			case 2:
				num = ⴅ[217] - 53;
				continue;
			case 1:
			case 6:
				P_0.TabIndex = P_1;
				goto case 3;
			case 3:
			case 7:
				num2++;
				num3 = 2288;
				num4 = 443;
				break;
			case 5:
				break;
			case 8:
				return;
			}
			num = ((572 < num3 / 4 - num4) ? (ⴗ[48] - 52957) : 8);
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴃ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DataGridViewCell
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 11;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄ[117] - ⴄ[117];
					continue;
				case 0:
					break;
				case 11:
					num2 = (((P_1 ^ P_2) - 114) ^ num) switch
					{
						0 => ⴄ[256] - 65033, 
						_ => 8, 
					};
					continue;
				case 1:
				case 8:
					result = null;
					num2 = ⴅ[318] - ⴅ[75];
					continue;
				case 4:
				case 7:
					result = P_0.FormattedValue;
					num2 = ⴗ[119] - 30794;
					continue;
				case 3:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 5 : 6);
					continue;
				case 6:
					num2 = ⴅ[36] - 40;
					continue;
				case 5:
				case 10:
					return result;
				case 2:
					num2 = ⴅ[374] - 24;
					continue;
				}
				break;
			}
		}
	}
}
