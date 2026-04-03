using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcInterfaces.Spots;
using ArcShared;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.ExtensionMethods.Login;
using Ⴃ;

namespace WindowsFormsApplication1.ApplicationUpdates;

public sealed class AutoUpdater
{
	private string m_Ⴈ;

	private string m_Ⴓ;

	private UtilsSql.ႨႥ m_Ⴀ = new UtilsSql.ႨႥ();

	[SpecialName]
	private string Ⴅ()
	{
		return this.m_Ⴀ.Ⴈ;
	}

	[SpecialName]
	private void Ⴃ(string P_0)
	{
		this.m_Ⴀ.Ⴈ = P_0 as string;
	}

	[SpecialName]
	private string Ⴗ()
	{
		return this.m_Ⴀ.Ⴄ;
	}

	[SpecialName]
	private void Ⴍ(string P_0)
	{
		this.m_Ⴀ.Ⴄ = P_0 as string;
	}

	[SpecialName]
	private string Ⴀ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		string ⴓ = this.m_Ⴀ.Ⴓ;
		TalkCfg.ႣႣ[29] = (char)((TalkCfg.ႣႣ[29] * TalkCfg.ႣႣ[150]) & 0x95);
		return ⴓ;
	}

	[SpecialName]
	private void Ⴄ(string P_0)
	{
		this.m_Ⴀ.Ⴓ = P_0 as string;
	}

	[SpecialName]
	private string Ⴈ()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		string ⴈ = this.m_Ⴈ;
		WxCfg.ႣႭ[5] = (char)((WxCfg.ႣႭ[5] * WxCfg.ႣႭ[145]) & 0x20);
		return ⴈ;
	}

	[SpecialName]
	private void Ⴐ(string P_0)
	{
		this.m_Ⴈ = P_0;
	}

	[SpecialName]
	private bool Ⴐ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		return this.m_Ⴀ.Ⴅ;
	}

	[SpecialName]
	private void Ⴗ(bool P_0)
	{
		bool ⴅ = P_0;
		this.m_Ⴀ.Ⴅ = ⴅ;
	}

	[SpecialName]
	private string Ⴍ()
	{
		return this.m_Ⴓ;
	}

	[SpecialName]
	private void Ⴓ(string P_0)
	{
		this.m_Ⴓ = P_0;
	}

	[SpecialName]
	private ႣႼ Ⴄ()
	{
		return this.m_Ⴀ.Ⴗ;
	}

	[SpecialName]
	private void Ⴅ(ႣႼ P_0)
	{
		this.m_Ⴀ.Ⴗ = P_0;
	}

	public AutoUpdater(string url, string appName)
	{
		Ⴃ(appName);
		Ⴍ(url);
		Ⴄ(string.Empty);
		Ⴐ(string.Empty);
		Ⴗ(false);
		Ⴓ(string.Empty);
	}

	public void Update(bool isbeta)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
			case 4:
				UtilsValidation.Ⴃ((Thread)obj, true, 433, 468);
				(obj as Thread).Start();
				return;
			}
			bool ⴐ = isbeta;
			this.m_Ⴀ.Ⴐ = ⴐ;
			obj = new Thread(Ⴃ);
			num = ⴃႭ[102] - 34730;
		}
	}

	private void Ⴃ()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 1;
		object obj = default(object);
		IEquatable<Version> version = default(IEquatable<Version>);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new ႣႼ();
				if (((ႣႼ)obj).Ⴗ(Ⴗ(), Ⴍ()))
				{
					num = 5;
					break;
				}
				return;
			case 5:
				version = UtilsVersion.Version;
				Ⴅ((ႣႼ)obj);
				if (this.m_Ⴀ.Ⴐ)
				{
					num = 3;
					break;
				}
				while (true)
				{
					switch ((!UtilsLatLon.ႷႰ(Ⴄ().Ⴄ(), version as Version, 940, 1006)) ? (ⴃႭ[234] - 663) : 2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 1:
					case 3:
						break;
					case 2:
						Ⴀ(Ⴄ().Ⴄ().ToString());
						return;
					case 5:
					case 6:
						return;
					}
				}
			case 2:
			case 3:
				if (UtilsLatLon.ႷႰ(Ⴄ().Ⴅ(), (Version)version, 886, 820))
				{
					num = 6;
					break;
				}
				return;
			case 6:
				Ⴀ(UtilsString.Ⴍ((object)Ⴄ().Ⴅ(), 'õ', 231));
				return;
			case 0:
				return;
			}
		}
	}

	private void Ⴀ(string P_0)
	{
		int num = 7;
		object obj2 = default(object);
		object obj = default(object);
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			switch (num)
			{
			default:
				obj2 = new FrmUpdateAvailable();
				(obj2 as FrmUpdateAvailable).AppName = Ⴅ();
				((FrmUpdateAvailable)obj2).UpdateVersion = P_0;
				num = 4;
				break;
			case 4:
				num = ((UtilsCallsign.Ⴅ((Form)(obj2 as FrmUpdateAvailable), (short)451, 494) != DialogResult.OK) ? 3 : 8);
				break;
			case 5:
			case 8:
				obj = new FrmUpdating();
				num = (this.m_Ⴀ.Ⴐ ? 1 : 2);
				break;
			case 0:
			case 1:
				(obj as FrmUpdating).Url = Ⴄ().Ⴃ();
				num = 9;
				break;
			case 2:
				((FrmUpdating)obj).Url = Ⴄ().Ⴐ();
				goto case 9;
			case 9:
				equatable = Ⴓ();
				goto case 10;
			case 10:
				(obj as FrmUpdating).WorkPath = (string)equatable;
				((FrmUpdating)obj).FilePath = Ⴈ((string)equatable);
				num = 6;
				break;
			case 6:
				(obj as FrmUpdating).ShowDialog();
				num = 3;
				break;
			case 3:
				return;
			}
		}
	}

	private string Ⴓ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj3 = default(object);
		object obj2 = default(object);
		while (true)
		{
			object obj = new DirectoryInfo(DownloadUrl2.ႥႤ(CtyInfo.Ⴐ(UtilsEmail.Ⴓ('%', 62), 639, 580), 'ˊ', 'ʦ'));
			int num = ⴐ[520] - 5396;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀ[294] - 42251;
					continue;
				case 5:
				case 8:
					break;
				case 1:
				case 4:
				case 11:
					obj3 = new object[4];
					(obj3 as object[])[0] = DgvBaseFilterHost.ႷႤ((FileSystemInfo)(obj as DirectoryInfo), '\u0328', 868);
					num = ⴃႭ[280] - 7106;
					continue;
				case 9:
					((object[])obj3)[1] = Path.DirectorySeparatorChar;
					((object[])obj3)[2] = ArcLogInRqstExt.Ⴗ(1706508003, 24, 2);
					num = 3;
					continue;
				case 3:
				{
					(obj3 as object[])[3] = Path.DirectorySeparatorChar;
					obj2 = ႰႨ.ႨႷ((object[])obj3, '\u001b', 53);
					char num2 = ⴀ[21];
					DxCfg.Ⴗ[21] = (char)((DxCfg.Ⴗ[21] ^ DxCfg.Ⴗ[53]) & 0x9E);
					num = num2 - 21545;
					continue;
				}
				case 10:
					num = ((!this.m_Ⴀ.Ⴐ) ? (ⴃႭ[253] - 35213) : 7);
					continue;
				case 7:
					obj2 = ReverseBeaconClient.Ⴗ((string)obj2, Ⴄ().Ⴈ(), '\u00b8', 'ð');
					num = 0;
					continue;
				case 2:
					obj2 = (obj2 as string) + Ⴄ().Ⴍ();
					num = 0;
					continue;
				case 0:
					Directory.CreateDirectory(obj2 as string);
					return (obj2 as string) + Path.DirectorySeparatorChar;
				}
				break;
			}
		}
	}

	private string Ⴈ(string P_0)
	{
		return ReverseBeaconClient.Ⴗ(P_0, ႣႼ.ႥႭ(null, 624735572, 3, null), 'Ü', '\u0094');
	}

	[SecuritySafeCritical]
	static AutoUpdater()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : Control
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 6;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 3;
				break;
			case 3:
				num = (((P_2 ^ P_1) - 26) ^ num2) switch
				{
					0 => 4, 
					_ => 9, 
				};
				break;
			case 9:
				num = 0;
				break;
			case 4:
				P_0.SuspendLayout();
				goto case 0;
			case 0:
			case 2:
				num2++;
				num3 = 107;
				num4 = 816;
				goto case 5;
			case 5:
				num = ((5712 <= num4 - num3 * 7) ? 1 : (ⴗ[68] - 17888));
				break;
			case 1:
			case 7:
				num = 3;
				break;
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႨႠ<_0021_00210>(_0021_00210 P_0, PictureBoxSizeMode P_1, int P_2, char P_3) where _0021_00210 : PictureBox
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
				num = 2;
				break;
			case 2:
				num = (((P_2 ^ P_3) - 104) ^ num2) switch
				{
					0 => 5, 
					_ => 9, 
				};
				break;
			case 0:
			case 4:
			case 9:
				num = 8;
				break;
			case 5:
				P_0.SizeMode = P_1;
				goto case 8;
			case 8:
			{
				num2++;
				int num3 = 59;
				int num4 = 131;
				num = ((1048 > num4 - num3 * 8) ? (ⴐ[517] - 53482) : 3);
				break;
			}
			case 3:
				num = 2;
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႨႨ<_0021_00210>(_0021_00210 P_0, Color P_1, short P_2, short P_3) where _0021_00210 : Control
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 7;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴃႣ[199] - 41516;
				break;
			case 2:
				num = (((P_2 ^ P_3) - 82) ^ num3) switch
				{
					0 => 5, 
					_ => 0, 
				};
				break;
			case 0:
				num = ⴃႣ[177] - 7941;
				break;
			case 5:
			case 8:
				P_0.ForeColor = P_1;
				goto case 3;
			case 3:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				goto case 4;
			case 4:
				num = 6;
				break;
			case 6:
				num = ((num2 % 2 == 0) ? 1 : (ⴃႭ[156] - 30522));
				break;
			case 1:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႨႭ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, char P_3) where _0021_00210 : ListControl
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႤ[481] - 29441;
				break;
			case 1:
			{
				int num3 = (P_3 ^ P_2) - 1;
				int num4 = num2;
				WxCfg.ႣႭ[268] = (char)((WxCfg.ႣႭ[268] | WxCfg.ႣႭ[36]) & 0x22);
				num = (num3 ^ num4) switch
				{
					0 => 8, 
					_ => ⴃႣ[196] - 52697, 
				};
				break;
			}
			case 3:
			case 7:
			case 9:
				num = 6;
				break;
			case 0:
			case 8:
				P_0.FormattingEnabled = P_1;
				goto case 6;
			case 6:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 2 : 4);
				break;
			case 4:
				num = ⴃႣ[72] - 41163;
				break;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႨႷ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : WaitHandle
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[152] - 36433;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[121] - 2886;
					continue;
				case 6:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 116) ^ num) switch
					{
						0 => 10, 
						_ => ⴃႭ[72] - 28233, 
					};
					continue;
				case 0:
					result = true;
					num2 = ⴐ[314] - 9525;
					continue;
				case 10:
					result = P_0.WaitOne();
					num2 = 5;
					continue;
				case 5:
				{
					num++;
					int num3 = P_1 * P_1 + P_1;
					UtilsNumeric.Ⴀ[204] = (char)((UtilsNumeric.Ⴀ[204] ^ UtilsNumeric.Ⴀ[307]) & 0xCF);
					num2 = ((num3 % 2 == 0) ? (ⴐ[166] - 64382) : 9);
					continue;
				}
				case 9:
					num2 = 11;
					continue;
				case 2:
				case 3:
				case 7:
				case 8:
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
	internal static bool ႨႰ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		bool result = default(bool);
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
					num2 = ⴃႣ[99] - 22232;
					continue;
				case 2:
					break;
				case 7:
					num2 = (((P_2 ^ P_3) - 104) ^ num) switch
					{
						0 => 1, 
						1 => 12, 
						_ => 3, 
					};
					continue;
				case 3:
				case 5:
					result = false;
					num2 = 8;
					continue;
				case 1:
					result = P_0.Contains(P_1);
					goto case 0;
				case 0:
					num2 = 8;
					continue;
				case 12:
					result = P_0.StartsWith(P_1);
					num2 = 8;
					continue;
				case 8:
				{
					int num3 = num;
					NeedsCfg.ႣႤ[78] = (NeedsCfg.ႣႤ[78] * TalkCfg.ႣႣ[115]) & 0x2C;
					num = num3 + 1;
					goto case 9;
				}
				case 9:
				{
					int num4 = 365;
					int num5 = 772;
					num2 = ((6176 > num5 - num4 * 8) ? (ⴃႤ[71] - 21229) : (ⴗ[27] - 89));
					continue;
				}
				case 6:
					num2 = 7;
					continue;
				case 10:
					return result;
				case 4:
					num2 = ⴗ[27] - 88;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႨႣ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, int P_3) where _0021_00210 : string
	{
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
					num2 = 0;
					continue;
				case 0:
					break;
				case 1:
				case 8:
					num2 = (((P_3 ^ P_2) - 71) ^ num) switch
					{
						0 => 5, 
						_ => 4, 
					};
					continue;
				case 4:
					obj = null;
					num2 = ⴃႤ[540] - 52288;
					continue;
				case 5:
					obj = P_0.Substring(P_1);
					num2 = 11;
					continue;
				case 7:
				case 11:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 3 : (ⴃႤ[557] - 53624));
					continue;
				case 10:
					num2 = 8;
					continue;
				case 3:
				case 6:
					return obj as string;
				case 9:
					num2 = ⴃႤ[446] - 63145;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly ႨႤ(byte[] P_0, byte[] P_1, SecurityContextSource P_2, short P_3, int P_4)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 0:
				case 10:
					break;
				case 4:
					num2 = (((P_4 ^ P_3) - 71) ^ num) switch
					{
						0 => 11, 
						_ => 9, 
					};
					continue;
				case 9:
					obj = null;
					num2 = 5;
					continue;
				case 6:
				case 11:
					obj = Assembly.Load(P_0, P_1, P_2);
					num2 = 5;
					continue;
				case 5:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? 7 : (ⴗ[42] - 36998));
					continue;
				case 8:
					num2 = 4;
					continue;
				case 1:
				case 7:
				{
					Assembly result = (Assembly)obj;
					DataGridViewColumnSelector.Ⴐ[337] = (char)((DataGridViewColumnSelector.Ⴐ[337] * WxCfg.ႣႭ[100]) & 0x2C);
					return result;
				}
				case 3:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ToolStripItemCollection ႨႳ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : ToolStrip
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				default:
				{
					/*OpCode not supported: LdMemberToken*/;
					char num5 = ⴗ[20];
					UtilsNumeric.Ⴀ[391] = (char)((UtilsNumeric.Ⴀ[391] ^ P_1) & 0xDA);
					num2 = num5 - 30042;
					continue;
				}
				case 1:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 104) ^ num) switch
					{
						0 => 2, 
						_ => 7, 
					};
					continue;
				case 7:
					obj = null;
					num2 = 6;
					continue;
				case 2:
				case 5:
					obj = P_0.Items;
					num2 = ⴃႭ[136] - 62991;
					continue;
				case 6:
				case 8:
				case 10:
				{
					num++;
					int num3 = 59;
					int num4 = 131;
					num2 = ((1048 > num4 - num3 * 8) ? (ⴗ[89] - 21004) : (ⴃႤ[76] - 33758));
					continue;
				}
				case 11:
					num2 = 4;
					continue;
				case 0:
					return (ToolStripItemCollection)obj;
				case 3:
					num2 = ⴃႭ[221] - 31245;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႨႥ<_0021_00210>(_0021_00210 P_0, float P_1, char P_2, int P_3) where _0021_00210 : DxSpot
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 6;
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
				num = (((P_3 ^ P_2) - 60) ^ num3) switch
				{
					0 => ⴃႤ[406] - 38146, 
					_ => 9, 
				};
				break;
			case 9:
				num = 8;
				break;
			case 4:
				P_0.Freq = P_1;
				goto case 1;
			case 1:
			case 8:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				goto case 5;
			case 5:
				num = 0;
				break;
			case 0:
				num = ((num2 % 2 != 0) ? 2 : 3);
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object ႨႼ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, char P_3) where _0021_00210 : XmlSerializer where _0021_00211 : Stream
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		object result = default(object);
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
					num2 = 5;
					continue;
				case 5:
					break;
				case 1:
				case 6:
					num2 = (((P_3 ^ P_2) - 5) ^ num) switch
					{
						0 => 0, 
						_ => 4, 
					};
					continue;
				case 4:
					result = null;
					num2 = ⴐ[325] - 52581;
					continue;
				case 0:
				case 10:
					result = P_0.Deserialize(P_1);
					num2 = ⴐ[481] - 29250;
					continue;
				case 2:
				{
					num++;
					int num3 = 28;
					int num4 = 65;
					num2 = ((585 > num4 - num3 * 9) ? 11 : (ⴃႣ[142] - 62649));
					continue;
				}
				case 7:
					num2 = ⴀ[230] - 37254;
					continue;
				case 11:
					return result;
				case 3:
				case 8:
					num2 = ⴗ[130] - 63632;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object ႭႠ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : Control where _0021_00211 : Delegate
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		object result = default(object);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 6:
					num2 = (((P_3 ^ P_2) - 122) ^ num) switch
					{
						0 => ⴃႣ[166] - 48251, 
						_ => ⴃႤ[386] - 28383, 
					};
					continue;
				case 4:
					result = null;
					num2 = 10;
					continue;
				case 2:
					result = P_0.Invoke(P_1);
					num2 = ⴀ[380] - 17911;
					continue;
				case 1:
				case 10:
				{
					int num3 = num;
					WxCfg.ႣႭ[55] = (char)((WxCfg.ႣႭ[55] ^ P_2) & 0xB);
					num = num3 + 1;
					goto case 9;
				}
				case 9:
				{
					int num4 = 12;
					int num5 = 3;
					num2 = ((4 < num4 / 3 - num5) ? (ⴃႤ[464] - 53301) : (ⴗ[23] - 59667));
					continue;
				}
				case 5:
					return result;
				case 0:
				case 7:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႭႨ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, short P_3) where _0021_00210 : ToolStripDropDown
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 6;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴀ[377] - 25999;
				break;
			case 3:
				num = (((P_3 ^ P_2) - 15) ^ num3) switch
				{
					0 => 7, 
					_ => 0, 
				};
				break;
			case 0:
			case 5:
				num = ⴀ[329] - 29354;
				break;
			case 7:
				P_0.AutoClose = P_1;
				goto case 4;
			case 4:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 9;
				break;
			case 9:
				num = ((num2 % 2 == 0) ? 1 : 3);
				break;
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataGridViewColumn ႭႭ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : DataGridViewColumnCollection where _0021_00211 : string
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		IComponent component = default(IComponent);
		int num3 = default(int);
		int num4 = default(int);
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
					num2 = 9;
					continue;
				case 9:
					break;
				case 1:
					num2 = (((P_3 ^ P_2) - 122) ^ num) switch
					{
						0 => 5, 
						_ => ⴃႭ[101] - 25682, 
					};
					continue;
				case 8:
					component = null;
					num2 = 10;
					continue;
				case 5:
					component = P_0[P_1];
					num2 = 10;
					continue;
				case 10:
					num++;
					num3 = 12;
					num4 = 3;
					goto case 4;
				case 4:
					num2 = ((4 < num3 / 3 - num4) ? (ⴗ[135] - 48380) : (ⴃႣ[237] - ⴃႣ[237]));
					continue;
				case 0:
				case 2:
				case 6:
					return (DataGridViewColumn)component;
				case 3:
					num2 = ⴃႣ[131] - 64727;
					continue;
				}
				break;
			}
		}
	}
}
