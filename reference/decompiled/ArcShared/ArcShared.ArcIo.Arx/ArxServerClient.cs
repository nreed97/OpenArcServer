using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Tcp;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using Ⴃ;

namespace ArcShared.ArcIo.Arx;

public sealed class ArxServerClient : TcpServerClient
{
	internal sealed class Ⴈ
	{
		internal IContainer Ⴅ;

		internal TextBox Ⴓ;

		internal TextBox Ⴄ;

		internal Ⴈ()
		{
		}
	}

	public override bool Send(string msg)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		object obj2 = default(object);
		while (true)
		{
			base.LastSendDts = DxAtlasData.Ⴈ(855, 799);
			object obj = new ByteAppend<byte>();
			(obj as ByteAppend<byte>).Add(ႣႼ.ႰႳ(ObjectCopierExt.Ⴄ(496, 422), ႣႼ.ႥႭ(null, 624735596, 3, null), 610, 'ȣ'));
			while (true)
			{
				IL_0097:
				int num = ⴀ[114] - 58314;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႣ[70] - 48570;
						continue;
					case 2:
						break;
					case 0:
						goto IL_0097;
					case 6:
						(obj as ByteAppend<byte>).Add(UtilsComp.Ⴅ(msg));
						(obj as ByteAppend<byte>).Add(ObjectCopierExt.Ⴄ(221, 139).GetBytes(ArcLogInRqstExt.Ⴗ(1706508100, 28, 6)));
						num = 4;
						continue;
					case 4:
						obj2 = ((ByteAppend<byte>)obj).ToArray();
						goto case 5;
					case 5:
						return HostTcpServer.Send(Socket, obj2 as byte[]);
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static ArxServerClient()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, int P_3) where _0021_00210 : TextBoxBase
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴐ[71] - 17404;
				break;
			case 3:
			case 8:
				num = (((P_3 ^ P_2) - 77) ^ num2) switch
				{
					0 => ⴃႭ[153] - 46363, 
					_ => ⴃႤ[462] - 62255, 
				};
				break;
			case 2:
			case 5:
				num = 1;
				break;
			case 7:
				P_0.Multiline = P_1;
				goto case 1;
			case 1:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 6 : 4);
				break;
			case 0:
			case 4:
				num = ⴃႤ[118] - 1970;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : FileSystemWatcher where _0021_00211 : string
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႣ[136] - 56832;
				break;
			case 3:
				num = (((P_3 ^ P_2) - 15) ^ num2) switch
				{
					0 => 5, 
					_ => 2, 
				};
				break;
			case 2:
				num = ⴀ[387] - 45971;
				break;
			case 5:
			case 6:
			case 7:
				P_0.Path = P_1;
				goto case 1;
			case 1:
			{
				num2++;
				int num3 = 84;
				int num4 = 611;
				num = ((4277 > num4 - num3 * 7) ? 9 : 4);
				break;
			}
			case 4:
				num = ⴃႣ[176] - 11043;
				break;
			case 8:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static MailAddressCollection Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : MailMessage
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
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
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[237] - 23092;
					continue;
				case 3:
					break;
				case 4:
					num2 = (((P_2 ^ P_1) - 15) ^ num) switch
					{
						0 => 0, 
						_ => 8, 
					};
					continue;
				case 8:
					obj = null;
					goto case 10;
				case 10:
					num2 = ⴗ[42] - 37005;
					continue;
				case 0:
					obj = P_0.To;
					num2 = ⴃႭ[209] - 32135;
					continue;
				case 1:
				case 5:
				case 7:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 6 : (ⴃႤ[356] - 34563));
					continue;
				case 11:
					num2 = 4;
					continue;
				case 6:
					return (MailAddressCollection)obj;
				case 2:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, DialogResult P_1, short P_2, int P_3) where _0021_00210 : Form
	{
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				continue;
			case 0:
				num = (((P_3 ^ P_2) - 5) ^ num2) switch
				{
					0 => 8, 
					_ => 7, 
				};
				continue;
			case 3:
			case 7:
				num = 5;
				continue;
			case 8:
				P_0.DialogResult = P_1;
				goto case 5;
			case 5:
				num2++;
				break;
			case 6:
				break;
			case 1:
			case 4:
				return;
			}
			int num3 = 372;
			int num4 = 40;
			num = ((186 >= num3 / 2 - num4) ? 4 : 0);
		}
	}

	[SecuritySafeCritical]
	internal static byte Ⴅ(ref Color P_0, short P_1, int P_2)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		byte result = default(byte);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[131] - 64720;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႤ[550] - 2681;
					continue;
				case 10:
					break;
				case 7:
				case 8:
					num2 = (((P_2 ^ P_1) - 29) ^ num) switch
					{
						0 => 0, 
						1 => ⴃႣ[215] - 32474, 
						_ => ⴗ[68] - 17887, 
					};
					continue;
				case 9:
					result = 14;
					num2 = ⴐ[415] - 57867;
					continue;
				case 0:
					result = P_0.A;
					goto case 1;
				case 1:
				case 4:
					num2 = 3;
					continue;
				case 6:
					result = P_0.G;
					num2 = 3;
					continue;
				case 3:
				{
					num++;
					int num3 = 1899;
					int num4 = 331;
					num2 = ((633 < num3 / 3 - num4) ? (ⴗ[55] - 6820) : 11);
					continue;
				}
				case 11:
					return result;
				case 5:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211, _0021_00212>(_0021_00211 P_0, _0021_00212 P_1, _0021_00210 P_2, int P_3, char P_4) where _0021_00211 : SynchronizationContext where _0021_00212 : SendOrPostCallback
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴐ[41] - 59292;
				break;
			case 0:
			case 5:
				num = (((P_4 ^ P_3) - 71) ^ num2) switch
				{
					0 => 7, 
					_ => ⴃႤ[264] - 53643, 
				};
				break;
			case 1:
				num = ⴃႤ[111] - 29457;
				break;
			case 4:
			case 7:
				P_0.Post(P_1, P_2);
				goto case 2;
			case 2:
				num2++;
				num = (((P_4 * P_4 + P_4) % 2 == 0) ? 8 : (ⴃႣ[106] - 63635));
				break;
			case 3:
				num = 0;
				break;
			case 8:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Color Ⴄ(short P_0, char P_1)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		Color result = default(Color);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[15] - 18746;
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
				case 4:
					num2 = (((P_1 ^ P_0) - 38) ^ num) switch
					{
						0 => 1, 
						_ => ⴃႣ[1] - 12847, 
					};
					continue;
				case 3:
					result = default(Color);
					num2 = 7;
					continue;
				case 0:
				case 1:
					result = Color.Magenta;
					num2 = 7;
					continue;
				case 7:
				case 9:
					num++;
					goto case 8;
				case 8:
				{
					int num3 = 244;
					int num4 = 31;
					num2 = ((61 < num3 / 4 - num4) ? 4 : (ⴗ[23] - 59662));
					continue;
				}
				case 10:
					return result;
				case 2:
					num2 = ⴃႭ[43] - 34346;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataTable Ⴃ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : string where _0021_00211 : DataTableCollection
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		IXmlSerializable xmlSerializable = default(IXmlSerializable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 0;
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
				case 0:
					num2 = (((P_3 ^ P_2) - 4) ^ num) switch
					{
						0 => ⴃႤ[600] - 48675, 
						_ => ⴗ[140] - 43355, 
					};
					continue;
				case 5:
					xmlSerializable = null;
					num2 = ⴃႤ[582] - 44343;
					continue;
				case 9:
					xmlSerializable = P_0[P_1];
					num2 = ⴃႭ[285] - 39654;
					continue;
				case 11:
					num++;
					goto case 10;
				case 10:
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 7;
					continue;
				case 7:
					num2 = ((num3 % 2 == 0) ? 1 : (ⴗ[24] - 30805));
					continue;
				case 1:
					return (DataTable)xmlSerializable;
				case 8:
					num2 = ⴀ[214] - 40461;
					continue;
				}
				break;
			}
		}
	}
}
