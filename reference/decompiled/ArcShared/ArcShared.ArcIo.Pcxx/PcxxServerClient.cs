using System;
using System.Drawing;
using System.Net.Mail;
using System.Security;
using System.Windows.Forms;
using System.Xml;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Tcp;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods.Objects;
using Ⴃ;

namespace ArcShared.ArcIo.Pcxx;

public sealed class PcxxServerClient : TcpServerClient
{
	public override bool Send(string msg)
	{
		while (true)
		{
			base.LastSendDts = DxAtlasData.Ⴈ(344, 272);
			while (true)
			{
				IL_003f:
				Array array = ႣႼ.ႰႳ(ObjectCopierExt.Ⴄ(926, 968), msg, 468, 'ƕ');
				int num = 1;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 3;
						continue;
					case 3:
					case 5:
						break;
					case 0:
						goto IL_003f;
					case 1:
						return HostTcpServer.Send(Socket, (byte[])array);
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static PcxxServerClient()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static bool Ⴀ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : XmlReader
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[372] - 61713;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႤ[192] - 53091;
					continue;
				case 5:
					break;
				case 10:
					num2 = (((P_2 ^ P_1) - 61) ^ num) switch
					{
						0 => 11, 
						_ => 6, 
					};
					continue;
				case 6:
					result = false;
					goto case 3;
				case 3:
					num2 = 4;
					continue;
				case 11:
					result = P_0.IsEmptyElement;
					num2 = ⴃႭ[213] - 38907;
					continue;
				case 0:
				case 4:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 != 0) ? 1 : (ⴃႣ[82] - 17730));
					continue;
				case 1:
					num2 = 10;
					continue;
				case 9:
					return result;
				case 2:
				case 7:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, char P_3) where _0021_00210 : ListControl
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 4;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 3;
				continue;
			case 3:
				num = (((P_2 ^ P_3) - 65) ^ num2) switch
				{
					0 => ⴗ[15] - 33631, 
					_ => 2, 
				};
				continue;
			case 2:
			case 7:
				num = 8;
				continue;
			case 0:
				P_0.SelectedIndex = P_1;
				goto case 8;
			case 8:
				num2++;
				num3 = 3042;
				break;
			case 6:
				break;
			case 5:
				return;
			}
			int num4 = 263;
			num = ((1014 < num3 / 3 - num4) ? 3 : (ⴗ[19] - 27389));
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : string where _0021_00211 : MailMessage
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
			{
				num2 = 0;
				int num3 = ⴃႤ[168];
				DxCfg.Ⴗ[83] = (char)((DxCfg.Ⴗ[83] - P_3) & 0x9F);
				num = num3 - 45759;
				continue;
			}
			case 0:
			case 2:
				num = (((P_2 ^ P_3) - 36) ^ num2) switch
				{
					0 => 1, 
					_ => ⴗ[148] - 25099, 
				};
				continue;
			case 7:
				num = ⴐ[506] - 14742;
				continue;
			case 1:
				P_0.Subject = P_1;
				goto case 3;
			case 3:
			case 4:
				num2++;
				break;
			case 6:
				break;
			case 8:
				return;
			}
			int num4 = 1536;
			int num5 = 332;
			num = ((512 < num4 / 3 - num5) ? 2 : 8);
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : string where _0021_00211 : WwvSpot
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 4;
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
				num = (((P_2 ^ P_3) - 45) ^ num2) switch
				{
					0 => 8, 
					1 => ⴗ[24] - 30803, 
					_ => 7, 
				};
				break;
			case 7:
				num = 1;
				break;
			case 8:
				P_0.Sfi = P_1;
				goto case 3;
			case 3:
				num = 1;
				break;
			case 2:
				P_0.Forecast = P_1;
				goto case 0;
			case 0:
			case 1:
				num2++;
				goto case 10;
			case 10:
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႭ[95] - 32053) : 9);
				break;
			case 9:
				num = 6;
				break;
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Size Ⴄ(Size P_0, Size P_1, short P_2, int P_3)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		Size result = default(Size);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[371] - 3274;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႤ[201] - 57961;
					continue;
				case 4:
				case 11:
					break;
				case 8:
					num2 = (((P_2 ^ P_3) - 45) ^ num) switch
					{
						0 => ⴗ[140] - 43350, 
						_ => ⴐ[366] - 50881, 
					};
					continue;
				case 6:
					result = P_0;
					num2 = ⴃႣ[56] - 56165;
					continue;
				case 10:
					result = Size.Add(P_0, P_1);
					num2 = 9;
					continue;
				case 9:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 5 : 7);
					continue;
				case 2:
				case 7:
					num2 = ⴃႤ[113] - 51659;
					continue;
				case 5:
					return result;
				case 1:
				case 3:
					num2 = ⴐ[72] - 43487;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : AnnWxSpot
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				continue;
			case 2:
				num = (((P_2 ^ P_3) - 119) ^ num2) switch
				{
					0 => 3, 
					_ => 1, 
				};
				continue;
			case 1:
			case 6:
				num = ⴀ[350] - 33803;
				continue;
			case 3:
				P_0.To = P_1;
				break;
			case 0:
			case 8:
				break;
			case 5:
			case 7:
				return;
			}
			num2++;
			int num3 = 2544;
			int num4 = 420;
			num = ((848 < num3 / 3 - num4) ? 2 : 5);
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : DataGridViewColumnEventHandler where _0021_00211 : DataGridView
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				break;
			case 5:
				num = (((P_2 ^ P_3) - 45) ^ num2) switch
				{
					0 => 1, 
					_ => 0, 
				};
				break;
			case 0:
				num = ⴐ[148] - 51429;
				break;
			case 1:
			case 8:
				P_0.ColumnAdded += P_1;
				goto case 3;
			case 3:
			case 6:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 7 : (ⴃႭ[145] - 60700));
				break;
			case 9:
				num = ⴃႣ[236] - 1747;
				break;
			case 2:
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : ToolStripDropDown
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 8;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_2 ^ P_1) - 78) ^ num3) switch
				{
					0 => 2, 
					_ => ⴃႣ[99] - 22234, 
				};
				break;
			case 0:
			case 6:
				num = 1;
				break;
			case 2:
			case 3:
				P_0.Close();
				goto case 1;
			case 1:
			case 7:
				num3++;
				num2 = P_1 * P_1;
				num2 = P_1 + num2;
				num = ⴃႤ[286] - 53646;
				break;
			case 9:
				num = ((num2 % 2 != 0) ? 4 : 5);
				break;
			case 5:
				return;
			}
		}
	}
}
