using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using System.Xml;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Arx;
using ArcShared.ArcIo.Pcxx;
using ArcShared.DgvUtils;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class UtilsEmail
{
	public static void SendEmail(string address, string subject, string message)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 6;
		IComparable comparable = default(IComparable);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		object obj2 = default(object);
		object obj3 = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				comparable = ႣႼ.Ⴜ(3, 365387640, 30);
				goto case 7;
			case 7:
				enumerable = ႣႼ.Ⴜ(6, 365387527, 28);
				num = ⴃႤ[372] - 12614;
				break;
			case 4:
			case 8:
				obj2 = new NetworkCredential((string)comparable, (string)enumerable);
				obj3 = new MailMessage();
				obj = new SmtpClient(ArcLogInRqstExt.Ⴗ(1706508032, 28, 7), 587);
				num = ⴃႭ[138] - 10814;
				break;
			case 3:
				ServerIoCfg.ႤႨ(obj3 as MailMessage, new MailAddress(comparable as string), 691, 765);
				ArxServerClient.Ⴓ((MailMessage)obj3, 'ɢ', 621).Add(new MailAddress(address));
				num = 0;
				break;
			case 0:
				PcxxServerClient.Ⴓ((MailMessage)obj3, subject, 383, 347);
				StationCfg.Ⴜ(obj3 as MailMessage, message, 86, '-');
				goto case 2;
			case 2:
				num = 1;
				break;
			case 1:
				DxSpotExt.Ⴗ(obj3 as MailMessage, true, 'ǒ', 388);
				(obj as SmtpClient).EnableSsl = true;
				num = 5;
				break;
			case 5:
				(obj as SmtpClient).UseDefaultCredentials = false;
				(obj as SmtpClient).Credentials = (NetworkCredential)obj2;
				((SmtpClient)obj).Send(obj3 as MailMessage);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static UtilsEmail()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210, _0021_00211, _0021_00212>(_0021_00211 P_0, _0021_00210 P_1, _0021_00212 P_2, int P_3, short P_4) where _0021_00210 : string where _0021_00211 : string where _0021_00212 : string
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		IConvertible convertible = default(IConvertible);
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
					num2 = ⴃႭ[46] - 55838;
					continue;
				case 5:
					break;
				case 7:
				case 8:
					num2 = (((P_4 ^ P_3) - 86) ^ num) switch
					{
						0 => 1, 
						_ => ⴐ[197] - ⴐ[197], 
					};
					continue;
				case 0:
					convertible = null;
					num2 = ⴗ[112] - 6786;
					continue;
				case 1:
					convertible = string.Concat(P_0, P_1, P_2);
					num2 = ⴀ[11] - 54421;
					continue;
				case 11:
					num++;
					num2 = (((P_4 * P_4 + P_4) % 2 == 0) ? 2 : 10);
					continue;
				case 10:
					num2 = 7;
					continue;
				case 2:
				case 6:
				{
					string result = (string)convertible;
					DataGridViewColumnSelector.Ⴐ[109] = (char)((DataGridViewColumnSelector.Ⴐ[109] * P_3) & 0xA7);
					return result;
				}
				case 3:
				case 4:
					num2 = ⴐ[124] - 50855;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static IPAddress Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : IPEndPoint
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 10;
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
				case 10:
					num2 = (((P_1 ^ P_2) - 65) ^ num) switch
					{
						0 => 9, 
						_ => ⴃႭ[167] - 37745, 
					};
					continue;
				case 6:
				case 8:
					obj = null;
					num2 = 5;
					continue;
				case 9:
				case 11:
					obj = P_0.Address;
					num2 = 5;
					continue;
				case 5:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴃႭ[276] - 32036;
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? (ⴗ[152] - 36434) : 7);
					continue;
				case 7:
					return (IPAddress)obj;
				case 2:
					num2 = ⴃႣ[11] - 31084;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ICredentials Ⴅ(char P_0, int P_1)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[446] - 17695;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 6;
					continue;
				case 6:
					break;
				case 10:
				{
					int num5 = (P_1 ^ P_0) - 118;
					int num6 = num;
					NeedsCfg.ႣႤ[72] = NeedsCfg.ႣႤ[72] & WxCfg.ႣႭ[72] & 0x4D;
					num2 = (num5 ^ num6) switch
					{
						0 => ⴀ[221] - 59525, 
						_ => ⴀ[383] - 63900, 
					};
					continue;
				}
				case 11:
					obj = null;
					num2 = 3;
					continue;
				case 4:
				case 9:
					obj = CredentialCache.DefaultCredentials;
					num2 = ⴀ[287] - 5921;
					continue;
				case 3:
				{
					num++;
					int num3 = 531;
					int num4 = 760;
					num2 = ((3040 <= num4 - num3 * 4) ? 1 : 7);
					continue;
				}
				case 1:
					num2 = 10;
					continue;
				case 5:
				case 7:
					return obj as ICredentials;
				case 0:
				case 8:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : WwvSpot
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
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
					num2 = 0;
					continue;
				case 0:
					break;
				case 8:
				case 11:
					num2 = (((P_2 ^ P_1) - 87) ^ num) switch
					{
						0 => 9, 
						_ => ⴗ[117] - 12534, 
					};
					continue;
				case 5:
					obj = null;
					num2 = ⴃႭ[91] - 28858;
					continue;
				case 9:
					obj = P_0.Forecast;
					num2 = ⴀ[39] - 63114;
					continue;
				case 4:
				case 10:
				{
					num++;
					int num3 = 138;
					int num4 = 695;
					num2 = ((4170 > num4 - num3 * 6) ? 6 : 3);
					continue;
				}
				case 3:
					num2 = 11;
					continue;
				case 6:
					return obj as string;
				case 1:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : XmlNode
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		int num3 = default(int);
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
					num2 = ⴃႤ[215] - 58926;
					continue;
				case 3:
					break;
				case 5:
					num2 = (((P_2 ^ P_1) - 87) ^ num) switch
					{
						0 => ⴃႣ[187] - 55706, 
						_ => 11, 
					};
					continue;
				case 11:
					enumerable = null;
					num2 = 4;
					continue;
				case 10:
					enumerable = P_0.InnerText;
					num2 = 4;
					continue;
				case 4:
					num++;
					goto case 2;
				case 2:
					num3 = 138;
					goto case 8;
				case 8:
				{
					int num4 = 695;
					num2 = ((4170 > num4 - num3 * 6) ? 1 : 9);
					continue;
				}
				case 9:
					num2 = ⴐ[363] - 27678;
					continue;
				case 1:
					return (string)enumerable;
				case 0:
				case 7:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly Ⴓ(char P_0, short P_1)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 8:
					num2 = (((P_0 ^ P_1) - 27) ^ num) switch
					{
						0 => ⴃႭ[163] - 38780, 
						_ => ⴃႤ[426] - 19024, 
					};
					continue;
				case 3:
					obj = null;
					num2 = ⴗ[33] - 33384;
					continue;
				case 4:
					obj = Assembly.GetEntryAssembly();
					num2 = 7;
					continue;
				case 5:
				case 7:
					num++;
					goto case 1;
				case 1:
				{
					int num3 = 1408;
					int num4 = 109;
					num2 = ((352 < num3 / 4 - num4) ? 8 : (ⴀ[259] - ⴀ[259]));
					continue;
				}
				case 0:
					return obj as Assembly;
				case 6:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : DxSpot
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[408] - 38785;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႤ[456] - 29179;
					continue;
				case 2:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 93) ^ num) switch
					{
						0 => ⴃႭ[88] - 34985, 
						_ => 4, 
					};
					continue;
				case 4:
					obj = null;
					goto case 5;
				case 5:
					num2 = 10;
					continue;
				case 1:
				case 7:
					obj = P_0.SpotterNode;
					num2 = ⴃႣ[93] - 25911;
					continue;
				case 10:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 3 : (ⴃႣ[47] - 35626));
					continue;
				case 11:
					num2 = 8;
					continue;
				case 0:
				case 3:
					return obj as string;
				case 9:
					num2 = ⴐ[22] - 21214;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴐ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : Control where _0021_00211 : Delegate
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object result = default(object);
		int num3 = default(int);
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
					num2 = ⴀ[409] - 4049;
					continue;
				case 2:
					break;
				case 1:
				case 11:
					num2 = (((P_3 ^ P_2) - 4) ^ num) switch
					{
						0 => ⴗ[74] - 30234, 
						_ => 4, 
					};
					continue;
				case 4:
					result = null;
					num2 = ⴀ[234] - 32548;
					continue;
				case 3:
					result = P_0.Invoke(P_1);
					num2 = 8;
					continue;
				case 8:
				case 10:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 9;
					continue;
				case 9:
					num2 = ((num3 % 2 != 0) ? (ⴐ[53] - 45388) : 5);
					continue;
				case 5:
					return result;
				case 7:
					num2 = ⴐ[113] - 30576;
					continue;
				}
				break;
			}
		}
	}
}
