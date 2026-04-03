using System;
using System.ComponentModel;
using System.Data.Sql;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;

namespace ArcShared;

[XmlType("ServerIoDevice")]
public sealed class ServerIoCfg : IIoDeviceCfg
{
	private ServerIoType Ⴀ;

	private bool Ⴄ;

	private string Ⴗ;

	private int Ⴈ;

	private string Ⴀ;

	private string Ⴄ;

	private string Ⴈ;

	private string Ⴜ;

	private UtilsCallsign.Ⴄ ႳႤ = new UtilsCallsign.Ⴄ();

	[Browsable(false)]
	public Guid Id
	{
		get
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			return ႳႤ.Ⴅ;
		}
		set
		{
			ႳႤ.Ⴅ = value;
		}
	}

	public ServerIoType Type
	{
		get
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			return this.Ⴀ;
		}
		set
		{
			this.Ⴀ = value;
		}
	}

	public IoCategoryType Category => IoCategoryType.Server;

	public string Description
	{
		get
		{
			char[] ⴗ = DxCfg.Ⴗ;
			return ႳႤ.Ⴗ;
		}
		set
		{
			ႳႤ.Ⴗ = value;
		}
	}

	public bool Enabled
	{
		get
		{
			bool ⴄ = this.Ⴄ;
			DataGridViewColumnSelector.Ⴐ[293] = (char)((DataGridViewColumnSelector.Ⴐ[293] + DataGridViewColumnSelector.Ⴐ[158]) & 0xF9);
			return ⴄ;
		}
		set
		{
			this.Ⴄ = value;
		}
	}

	[XmlIgnore]
	[Browsable(false)]
	public string IpAddress
	{
		get
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			return Ⴗ;
		}
		set
		{
			Ⴗ = value;
		}
	}

	public int Port
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			return this.Ⴈ;
		}
		set
		{
			this.Ⴈ = value;
		}
	}

	[Browsable(false)]
	[XmlIgnore]
	public string ConnectTo
	{
		get
		{
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	[XmlIgnore]
	[Browsable(false)]
	public string ConnectAs
	{
		get
		{
			return ႳႤ.Ⴀ;
		}
		set
		{
			ႳႤ.Ⴀ = value;
		}
	}

	[XmlIgnore]
	[Browsable(false)]
	public string Password
	{
		get
		{
			string ⴄ = Ⴄ;
			DxCfg.Ⴗ[86] = (char)(DxCfg.Ⴗ[86] & DxCfg.Ⴗ[124] & 0xB0);
			return ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	[Description("Introduction login file requesting login")]
	public string IntroLoginFile
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			return ႳႤ.Ⴈ;
		}
		set
		{
			ႳႤ.Ⴈ = value;
			WxCfg.ႣႭ[181] = (char)((WxCfg.ႣႭ[181] - DataGridViewColumnSelector.Ⴐ[281]) & 0xCD);
		}
	}

	[Description("Login error message")]
	public string LoginErrorMsg
	{
		get
		{
			string ⴐ = ႳႤ.Ⴐ;
			UtilsNumeric.Ⴀ[312] = (char)((UtilsNumeric.Ⴀ[312] | UtilsNumeric.Ⴀ[290]) & 0xA3);
			return ⴐ;
		}
		set
		{
			ႳႤ.Ⴐ = value as string;
		}
	}

	[Description("Welcome login file sent after login")]
	public string WelcomeLoginFile
	{
		get
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			string ⴈ = Ⴈ;
			TalkCfg.ႣႣ[22] = (char)(TalkCfg.ႣႣ[22] & TalkCfg.ႣႣ[147] & 0xF5);
			return ⴈ;
		}
		set
		{
			Ⴈ = value;
		}
	}

	[Description("Logout message")]
	public string LogoutMsg
	{
		get
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			return ႳႤ.Ⴍ;
		}
		set
		{
			ႳႤ.Ⴍ = value;
		}
	}

	[Description("Default DX filter for new connections")]
	public string DefaultDxFilter
	{
		get
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			string ⴜ = Ⴜ;
			UtilsNumeric.Ⴀ[204] = (char)((UtilsNumeric.Ⴀ[204] ^ UtilsNumeric.Ⴀ[402]) & 0x1A);
			return ⴜ;
		}
		set
		{
			Ⴜ = value;
		}
	}

	[Description("Default Ann filter for new connections")]
	public string DefaultAnnFilter
	{
		get
		{
			return ႳႤ.Ⴄ;
		}
		set
		{
			ႳႤ.Ⴄ = value;
		}
	}

	[Description("Default WX filter for new connections")]
	public string DefaultWxFilter
	{
		get
		{
			return ႳႤ.Ⴃ;
		}
		set
		{
			ႳႤ.Ⴃ = value as string;
		}
	}

	public ServerIoCfg()
	{
		Id = StationCfg.Ⴍ('ϻ', 'Θ');
		DefaultDxFilter = string.Empty;
		DefaultAnnFilter = string.Empty;
		DefaultWxFilter = string.Empty;
		LogoutMsg = string.Empty;
	}

	public override string ToString()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		return Description;
	}

	[SecuritySafeCritical]
	static ServerIoCfg()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void ႤႰ<_0021_00210>(_0021_00210 P_0, Size P_1, char P_2, short P_3) where _0021_00210 : Control
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 10;
				break;
			case 10:
				num = (((P_2 ^ P_3) - 33) ^ num2) switch
				{
					0 => ⴗ[58] - 1697, 
					1 => ⴐ[125] - 11315, 
					_ => 5, 
				};
				break;
			case 5:
			case 7:
				num = 6;
				break;
			case 0:
			case 1:
			case 9:
				P_0.Size = P_1;
				num = ⴀ[158] - 56391;
				break;
			case 3:
				P_0.MinimumSize = P_1;
				goto case 6;
			case 6:
			{
				num2++;
				int num3 = 688;
				int num4 = 889;
				num = ((1778 > num4 - num3 * 2) ? 8 : 2);
				break;
			}
			case 2:
				num = ⴃႣ[33] - 33494;
				break;
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static SqlDataSourceEnumerator ႤႤ(char P_0, char P_1)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[85] - ⴗ[85];
					continue;
				case 0:
					break;
				case 8:
					num2 = (((P_0 ^ P_1) - 73) ^ num) switch
					{
						0 => 9, 
						_ => ⴐ[183] - 20613, 
					};
					continue;
				case 4:
					obj = null;
					num2 = 7;
					continue;
				case 2:
				case 9:
					obj = SqlDataSourceEnumerator.Instance;
					num2 = ⴃႤ[63] - 46138;
					continue;
				case 7:
				{
					num++;
					int num3 = 11;
					int num4 = 228;
					num2 = ((2280 <= num4 - num3 * 10) ? 1 : 5);
					continue;
				}
				case 1:
					num2 = 8;
					continue;
				case 5:
					return (SqlDataSourceEnumerator)obj;
				case 6:
					num2 = ⴃႤ[103] - 3405;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long ႤႷ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : FileInfo
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		long result = default(long);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[525] - 51302;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 4;
					continue;
				case 4:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 77) ^ num) switch
					{
						0 => ⴐ[361] - ⴐ[361], 
						_ => 7, 
					};
					continue;
				case 7:
					result = 10L;
					num2 = 6;
					continue;
				case 0:
				case 3:
					result = P_0.Length;
					num2 = ⴀ[102] - 65001;
					continue;
				case 6:
				{
					num++;
					int num3 = 384;
					int num4 = 955;
					num2 = ((1910 > num4 - num3 * 2) ? 5 : (ⴗ[5] - 11048));
					continue;
				}
				case 8:
				case 9:
					num2 = 1;
					continue;
				case 2:
				case 5:
					return result;
				case 11:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႤႨ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : MailAddress where _0021_00211 : MailMessage
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴐ[204] - 59681;
				break;
			case 2:
				num = (((P_3 ^ P_2) - 78) ^ num2) switch
				{
					0 => 5, 
					_ => 3, 
				};
				break;
			case 3:
				num = 9;
				break;
			case 5:
				P_0.From = P_1;
				goto case 9;
			case 9:
			{
				num2++;
				int num3 = 750;
				int num4 = 856;
				num = ((3424 > num4 - num3 * 4) ? 1 : 7);
				break;
			}
			case 7:
				num = ⴗ[80] - 32459;
				break;
			case 1:
			case 6:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႤႳ(int P_0, int P_1)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[55] - 6818;
					continue;
				case 10:
					break;
				case 8:
				case 11:
					num2 = (((P_0 ^ P_1) - 19) ^ num) switch
					{
						0 => 2, 
						_ => 1, 
					};
					continue;
				case 0:
				case 1:
					result = true;
					num2 = 6;
					continue;
				case 2:
				case 5:
					result = Environment.Is64BitProcess;
					num2 = ⴗ[93] - 711;
					continue;
				case 6:
				{
					num++;
					int num3 = 981;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? 3 : 9);
					continue;
				}
				case 9:
					num2 = 8;
					continue;
				case 3:
					return result;
				case 4:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႤႠ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : Font
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = default(object);
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
					num2 = 1;
					continue;
				case 1:
					break;
				case 2:
					num2 = (((P_1 ^ P_2) - 7) ^ num) switch
					{
						0 => ⴃႤ[527] - 61701, 
						_ => 4, 
					};
					continue;
				case 4:
					obj = null;
					num2 = ⴗ[42] - 37001;
					continue;
				case 3:
				case 7:
					obj = P_0.Name;
					num2 = 5;
					continue;
				case 5:
					num++;
					goto case 10;
				case 10:
				{
					int num3 = 1224;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? 8 : (ⴗ[139] - 41081));
					continue;
				}
				case 0:
				case 11:
					num2 = 2;
					continue;
				case 8:
					return (string)obj;
				case 6:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႤႭ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : Control
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[185] - 9483;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[43] - 34344;
					continue;
				case 6:
				case 10:
					break;
				case 11:
					num2 = (((P_1 ^ P_2) - 126) ^ num) switch
					{
						0 => ⴃႣ[228] - 10053, 
						_ => 9, 
					};
					continue;
				case 9:
					result = 7;
					num2 = 7;
					continue;
				case 5:
					result = P_0.Width;
					num2 = 7;
					continue;
				case 2:
				case 7:
				case 8:
				{
					num++;
					int num3 = 142;
					int num4 = 976;
					num2 = ((6832 > num4 - num3 * 7) ? 4 : 3);
					continue;
				}
				case 3:
					num2 = ⴃႭ[209] - 32125;
					continue;
				case 4:
					return result;
				case 1:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static IPHostEntry ႤႣ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object obj = default(object);
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
					num2 = ⴗ[55] - 6823;
					continue;
				case 5:
					break;
				case 3:
				case 11:
					num2 = (((P_1 ^ P_2) - 126) ^ num) switch
					{
						0 => 10, 
						_ => ⴃႣ[62] - ⴃႣ[62], 
					};
					continue;
				case 0:
					obj = null;
					goto case 4;
				case 4:
					num2 = ⴃႤ[320] - 20179;
					continue;
				case 10:
					obj = Dns.GetHostEntry(P_0);
					num2 = 6;
					continue;
				case 6:
					num++;
					goto case 9;
				case 9:
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴀ[18] - 58203) : 8);
					continue;
				case 8:
					num2 = 11;
					continue;
				case 7:
					return obj as IPHostEntry;
				case 2:
					num2 = ⴐ[275] - 24301;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႤႥ<_0021_00210>(_0021_00210 P_0, Rectangle P_1, char P_2, char P_3) where _0021_00210 : GraphicsPath
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 6;
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
				num = (((P_3 ^ P_2) - 107) ^ num2) switch
				{
					0 => 1, 
					_ => 9, 
				};
				break;
			case 9:
				num = 3;
				break;
			case 1:
				P_0.AddRectangle(P_1);
				goto case 3;
			case 3:
			case 4:
			{
				num2++;
				int num3 = P_3 * P_3;
				DataGridViewColumnSelector.Ⴐ[494] = (char)((DataGridViewColumnSelector.Ⴐ[494] - DataGridViewColumnSelector.Ⴐ[608]) & 0x12);
				num = (((num3 + P_3) % 2 == 0) ? 5 : (ⴐ[166] - 64382));
				break;
			}
			case 7:
			case 8:
				num = 0;
				break;
			case 5:
				return;
			}
		}
	}
}
