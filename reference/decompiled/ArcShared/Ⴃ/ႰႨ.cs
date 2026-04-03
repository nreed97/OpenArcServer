using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Objects;

namespace Ⴃ;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class ႰႨ
{
	private static ResourceManager Ⴈ;

	private static CultureInfo Ⴐ;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager Ⴗ
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			while (true)
			{
				int num = (AnnCfg.Ⴜ<object, object>(Ⴈ, null, 89, 102) ? 2 : 0);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 5;
						continue;
					case 1:
					case 5:
						break;
					case 2:
					case 6:
					{
						object obj = new ResourceManager("Ⴃ.ႰႨ", AnnWxSpotExt.ႤႤ(typeof(ႰႨ), 'ż', 316));
						Ⴈ = (ResourceManager)obj;
						num = ⴃႤ[311] - 40927;
						continue;
					}
					case 0:
					case 3:
					{
						ResourceManager ⴈ = Ⴈ;
						UtilsNumeric.Ⴀ[92] = (char)((UtilsNumeric.Ⴀ[92] + UtilsNumeric.Ⴀ[56]) & 0xB5);
						return ⴈ;
					}
					}
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Ⴃ
	{
		get
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			return Ⴐ;
		}
		set
		{
			Ⴐ = ⴐ;
		}
	}

	internal ႰႨ()
	{
	}

	[SpecialName]
	internal static Bitmap Ⴍ()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		while (true)
		{
			object obj = ObjectCopierExt.Ⴜ(Ⴗ, UtilsString.Ⴐ(null, 4, 192631369), Ⴐ, 839, '\u0350');
			while (true)
			{
				IL_0064:
				int num = 4;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴐ[308] - ⴐ[308];
						continue;
					case 0:
						break;
					case 1:
					case 3:
					case 5:
						goto IL_0064;
					case 4:
					{
						Bitmap result = (Bitmap)obj;
						DataGridViewColumnSelector.Ⴐ[252] = (char)((DataGridViewColumnSelector.Ⴐ[252] + DataGridViewColumnSelector.Ⴐ[604]) & 0xA1);
						return result;
					}
					}
					break;
				}
				break;
			}
		}
	}

	[SpecialName]
	internal static Bitmap Ⴅ()
	{
		while (true)
		{
			object obj = ObjectCopierExt.Ⴜ(Ⴗ, UtilsString.Ⴐ(null, 2, 192631493), Ⴐ, 442, 'ƭ');
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
				case 5:
					break;
				case 2:
				case 3:
					return (Bitmap)obj;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static ႰႨ()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴜ(int P_0, char P_1, short P_2)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 5;
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
			case 3:
				num = (((P_2 ^ P_1) - 29) ^ num3) switch
				{
					0 => ⴗ[27] - ⴗ[27], 
					_ => ⴃႣ[194] - 48163, 
				};
				break;
			case 9:
				num = 8;
				break;
			case 0:
				Thread.Sleep(P_0);
				goto case 8;
			case 8:
				num3++;
				num2 = P_1 * P_1;
				goto case 4;
			case 4:
			case 7:
				num2 = P_1 + num2;
				num = ⴃႤ[192] - 53094;
				break;
			case 1:
			case 2:
				num = ((num2 % 2 != 0) ? 3 : (ⴗ[25] - 18234));
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႨႣ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : XmlReader
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 3;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				break;
			case 6:
				num = (((P_1 ^ P_2) - 126) ^ num2) switch
				{
					0 => ⴃႣ[189] - 34280, 
					_ => 8, 
				};
				break;
			case 7:
			case 8:
				num = ⴃႤ[340] - 34430;
				break;
			case 4:
				P_0.ReadEndElement();
				goto case 1;
			case 1:
				num2++;
				num3 = 431;
				num4 = 709;
				goto case 0;
			case 0:
				num = ((5672 > num4 - num3 * 8) ? 9 : 5);
				break;
			case 5:
				num = 6;
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type ႨႨ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		_Type type = default(_Type);
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
					num2 = 2;
					continue;
				case 2:
					break;
				case 4:
					num2 = (((P_2 ^ P_1) - 85) ^ num) switch
					{
						0 => ⴐ[461] - 60535, 
						_ => 9, 
					};
					continue;
				case 9:
					type = typeof(TelnetServer);
					num2 = 5;
					continue;
				case 7:
				case 10:
				case 11:
					type = P_0.GetType();
					num2 = 5;
					continue;
				case 5:
				{
					num++;
					int num3 = 153;
					int num4 = 171;
					num2 = ((513 > num4 - num3 * 3) ? (ⴗ[155] - 49739) : (ⴃႣ[152] - 2913));
					continue;
				}
				case 1:
					num2 = 4;
					continue;
				case 0:
				case 8:
					return type as Type;
				case 6:
					num2 = ⴀ[241] - 35030;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string[] ႨႥ<_0021_00210>(_0021_00210 P_0, char[] P_1, short P_2, int P_3) where _0021_00210 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[105] - 4865;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 2:
				case 7:
					break;
				case 10:
					num2 = (((P_2 ^ P_3) - 97) ^ num) switch
					{
						0 => ⴐ[455] - 58338, 
						_ => 0, 
					};
					continue;
				case 0:
				case 9:
					obj = null;
					num2 = ⴗ[4] - 26310;
					continue;
				case 8:
					obj = P_0.Split(P_1);
					num2 = ⴐ[31] - 45324;
					continue;
				case 3:
					num++;
					goto case 5;
				case 5:
				{
					int num3 = 34;
					int num4 = 251;
					num2 = ((1004 > num4 - num3 * 4) ? (ⴃႤ[120] - 14319) : 11);
					continue;
				}
				case 11:
					num2 = 10;
					continue;
				case 1:
					return obj as string[];
				case 4:
					num2 = ⴗ[117] - 12529;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႨႷ(object[] P_0, char P_1, int P_2)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
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
					num2 = (((P_2 ^ P_1) - 46) ^ num) switch
					{
						0 => 8, 
						_ => 0, 
					};
					continue;
				case 0:
					obj = null;
					num2 = ⴐ[351] - 17281;
					continue;
				case 7:
				case 8:
					obj = string.Concat(P_0);
					num2 = 4;
					continue;
				case 4:
					num++;
					goto case 2;
				case 2:
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴃႣ[93] - 25910) : 3);
					continue;
				case 3:
					num2 = ⴃႤ[554] - 10968;
					continue;
				case 9:
				case 11:
				{
					string result = (string)obj;
					NeedsCfg.ႣႤ[468] = (NeedsCfg.ႣႤ[468] * P_2) & 0x78;
					return result;
				}
				case 6:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float ႨႠ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		float result = default(float);
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
					num2 = 8;
					continue;
				case 8:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 30) ^ num) switch
					{
						0 => 6, 
						_ => ⴀ[168] - ⴀ[168], 
					};
					continue;
				case 0:
				case 5:
				case 10:
					result = 5.671698f;
					num2 = ⴃႭ[277] - 547;
					continue;
				case 6:
					result = Convert.ToSingle(P_0);
					num2 = 7;
					continue;
				case 7:
				{
					num++;
					int num3 = 558;
					int num4 = 822;
					num2 = ((3288 > num4 - num3 * 4) ? 4 : (ⴃႭ[82] - 56658));
					continue;
				}
				case 2:
				case 11:
					num2 = 1;
					continue;
				case 4:
					return result;
				case 3:
					num2 = ⴐ[415] - 57869;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႨႭ<_0021_00210>(_0021_00210 P_0, Padding P_1, int P_2, short P_3) where _0021_00210 : Control
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				continue;
			case 8:
				num = (((P_2 ^ P_3) - 80) ^ num2) switch
				{
					0 => ⴃႣ[187] - 55714, 
					_ => 1, 
				};
				continue;
			case 1:
				num = 5;
				continue;
			case 2:
				P_0.Padding = P_1;
				break;
			case 5:
			case 6:
				break;
			case 3:
			case 7:
				return;
			}
			num2++;
			int num3 = 494;
			int num4 = 119;
			num = ((247 < num3 / 2 - num4) ? 8 : 7);
		}
	}

	[SecuritySafeCritical]
	internal static string ႨႳ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DataGridView
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		IConvertible convertible = default(IConvertible);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႤ[106] - 49753;
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
					num2 = (((P_1 ^ P_2) - 36) ^ num) switch
					{
						0 => 11, 
						_ => 7, 
					};
					continue;
				case 7:
					convertible = null;
					num2 = 10;
					continue;
				case 11:
					convertible = P_0.DataMember;
					num2 = 10;
					continue;
				case 2:
				case 10:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 0;
				case 0:
				case 1:
					num2 = ⴀ[221] - 59523;
					continue;
				case 6:
					num2 = ((num3 % 2 != 0) ? (ⴃႭ[13] - 37432) : 5);
					continue;
				case 5:
					return (string)convertible;
				case 4:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}
}
