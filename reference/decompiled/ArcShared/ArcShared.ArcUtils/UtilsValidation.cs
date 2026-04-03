using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using WindowsFormsApplication1.ApplicationUpdates;

namespace ArcShared.ArcUtils;

public static class UtilsValidation
{
	internal sealed class Ⴐ
	{
		internal System.Threading.Timer Ⴐ;

		internal Ⴐ()
		{
		}
	}

	public static bool CurrentCallbookPresent()
	{
		while (true)
		{
			ICustomAttributeProvider customAttributeProvider = FrmUpdateAvailable.ႷႥ(932, 970);
			IEnumerable<char> enumerable = DownloadUrl2.ႥႤ(CtyInfo.Ⴐ((Assembly)customAttributeProvider, 532, 559), '\u0384', 'Ϩ');
			while (true)
			{
				IL_0061:
				int num = 1;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 2;
						continue;
					case 0:
					case 2:
						break;
					case 5:
						goto IL_0061;
					case 1:
					case 4:
					{
						IComparable<string> comparable = (enumerable as string) + UtilsString.Ⴐ(null, 0, 192631519);
						return File.Exists((string)comparable);
					}
					}
					break;
				}
				break;
			}
		}
	}

	public static bool NewCallbookPresent()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		while (true)
		{
			IEvidenceFactory evidenceFactory = FrmUpdateAvailable.ႷႥ(812, 834);
			IComparable<string> comparable = DownloadUrl2.ႥႤ(CtyInfo.Ⴐ((Assembly)evidenceFactory, 288, 283), '\u0361', '\u030d');
			int num = ⴃႭ[101] - 25687;
			while (true)
			{
				switch (num)
				{
				default:
				{
					/*OpCode not supported: LdMemberToken*/;
					char num2 = ⴐ[408];
					WxCfg.ႣႭ[63] = (char)((WxCfg.ႣႭ[63] | WxCfg.ႣႭ[56]) & 8);
					num = num2 - 38793;
					continue;
				}
				case 0:
				case 2:
				case 4:
					break;
				case 1:
				case 3:
				{
					IConvertible convertible = (string)comparable + ArcLogInRqstExt.Ⴗ(1706507008, 9, 7);
					return File.Exists(convertible as string);
				}
				}
				break;
			}
		}
	}

	public static bool LicenseFilePresent()
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		while (true)
		{
			_Assembly assembly = FrmUpdateAvailable.ႷႥ(484, 394);
			object obj = DownloadUrl2.ႥႤ(CtyInfo.Ⴐ((Assembly)assembly, 363, 336), 'ɼ', 'Ȑ');
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴐ[267] - 1736;
					continue;
				case 0:
				case 2:
					break;
				case 3:
				case 5:
				{
					object obj2 = (obj as string) + TelnetServerClient.Ⴄ(1945322689, 'z', 5);
					return File.Exists((string)obj2);
				}
				}
				break;
			}
		}
	}

	public static bool SqlSvrExpressFound()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj2 = default(object);
		IComparable comparable = default(IComparable);
		bool result = default(bool);
		object obj3 = default(object);
		while (true)
		{
			DbDataSourceEnumerator dbDataSourceEnumerator = ServerIoCfg.ႤႤ('+', 'b');
			MarshalByValueComponent marshalByValueComponent = AnnCfg.Ⴐ((DbDataSourceEnumerator)(dbDataSourceEnumerator as SqlDataSourceEnumerator), 524, (short)611);
			int num = ⴃႤ[304] - 42596;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
					break;
				case 2:
				case 3:
				case 5:
				{
					object obj = AnnWxSpotExt.Ⴃ((InternalDataCollectionBase)PrecisionTimer.Ⴀ(marshalByValueComponent as DataTable, '\u031a', 815), '\u0329', (short)842);
					try
					{
						int num2 = 9;
						while (true)
						{
							switch (num2)
							{
							default:
								num2 = ⴃႣ[2] - 5263;
								continue;
							case 2:
								obj2 = (DataRow)(obj as IEnumerator).Current;
								goto case 6;
							case 6:
								comparable = UtilsString.Ⴍ(DownloadUrl.Ⴍ(obj2 as DataRow, TelnetServerClient.Ⴄ(1945322714, '4', 1), 'ʴ', 'ʕ'), 'Ş', 332);
								num2 = ⴃႭ[17] - 6318;
								continue;
							case 1:
							case 7:
								num2 = ((!FrmUpdating.ႠႥ(comparable as string, ArcLogInRqstExt.Ⴗ(1706507055, 24, 3), 917, 937)) ? (ⴐ[64] - 42817) : (ⴃႤ[235] - ⴃႤ[235]));
								continue;
							case 0:
								result = true;
								return result;
							case 5:
								num2 = (((IEnumerator)obj).MoveNext() ? (ⴃႭ[197] - 28509) : 3);
								continue;
							case 3:
								break;
							}
							break;
						}
					}
					finally
					{
						int num3 = 1;
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								obj3 = ((IEnumerator)obj) as IDisposable;
								num4 = (((IDisposable)obj3 == null) ? 4 : (ⴃႭ[177] - 31778));
								goto IL_01fb;
							case 2:
							case 3:
							case 5:
								((IDisposable)obj3).Dispose();
								break;
							case 0:
							case 4:
								break;
							}
							break;
							IL_01fb:
							num3 = num4;
						}
					}
					switch (2)
					{
					default:
						return false;
					case 1:
					case 4:
					case 5:
						return result;
					}
				}
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static UtilsValidation()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : FileSystemInfo
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 3;
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
				num = (((P_1 ^ P_2) - 53) ^ num2) switch
				{
					0 => 9, 
					_ => ⴃႣ[239] - 39451, 
				};
				break;
			case 1:
			case 8:
				num = ⴐ[38] - 2398;
				break;
			case 7:
			case 9:
				P_0.Delete();
				goto case 4;
			case 4:
				num2++;
				num = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴗ[12] - 35089) : 5);
				break;
			case 5:
				num = ⴐ[196] - 11174;
				break;
			case 2:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, bool P_1, short P_2, short P_3) where _0021_00210 : Thread
	{
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				break;
			case 8:
				num = (((P_2 ^ P_3) - 101) ^ num2) switch
				{
					0 => 5, 
					_ => 1, 
				};
				break;
			case 1:
				num = 6;
				break;
			case 5:
				P_0.IsBackground = P_1;
				goto case 6;
			case 6:
			case 7:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 != 0) ? 9 : 0);
				break;
			case 3:
			case 9:
				num = 8;
				break;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : Thread
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 4;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴐ[338] - 47161;
				break;
			case 8:
				num = (((P_1 ^ P_2) - 104) ^ num3) switch
				{
					0 => 2, 
					_ => 6, 
				};
				break;
			case 6:
				num = 3;
				break;
			case 2:
				P_0.Start();
				goto case 3;
			case 3:
				num3++;
				goto case 1;
			case 1:
				num2 = P_1 * P_1;
				num2 = P_1 + num2;
				goto case 7;
			case 7:
				num = ⴃႭ[188] - 1900;
				break;
			case 0:
				num = ((num2 % 2 != 0) ? (ⴃႣ[212] - 7573) : (ⴃႭ[60] - 19463));
				break;
			case 5:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Encoding Ⴓ(short P_0, short P_1)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		ICloneable cloneable = default(ICloneable);
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
					num2 = ⴗ[122] - 32507;
					continue;
				case 5:
					break;
				case 7:
					num2 = (((P_1 ^ P_0) - 77) ^ num) switch
					{
						0 => 6, 
						_ => 0, 
					};
					continue;
				case 0:
				case 11:
					cloneable = null;
					num2 = 2;
					continue;
				case 6:
					cloneable = Encoding.Default;
					num2 = 2;
					continue;
				case 2:
				case 9:
					num++;
					num2 = (((P_0 * P_0 + P_0) % 2 == 0) ? 4 : 3);
					continue;
				case 3:
					num2 = ⴗ[88] - 34715;
					continue;
				case 4:
					return (Encoding)cloneable;
				case 1:
				case 10:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210>(_0021_00210 P_0, Color P_1, short P_2, short P_3) where _0021_00210 : ToolStripItem
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႣ[176] - 11040;
				break;
			case 1:
			case 6:
				num = (((P_2 ^ P_3) - 101) ^ num2) switch
				{
					0 => 2, 
					_ => 5, 
				};
				break;
			case 5:
			case 9:
				num = 7;
				break;
			case 2:
				P_0.ImageTransparentColor = P_1;
				goto case 7;
			case 7:
			{
				num2++;
				int num3 = P_3 * P_3;
				NeedsCfg.ႣႤ[66] = (NeedsCfg.ႣႤ[66] - P_2) & 0xFF;
				num = (((num3 + P_3) % 2 == 0) ? 3 : 8);
				break;
			}
			case 8:
				num = 6;
				break;
			case 3:
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : DxSpot
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		byte result = default(byte);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[275] - 40473;
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
					num2 = (((P_1 ^ P_2) - 74) ^ num) switch
					{
						0 => ⴃႤ[424] - 7512, 
						1 => ⴐ[36] - 7452, 
						_ => ⴃႣ[134] - 14879, 
					};
					continue;
				case 7:
					result = 2;
					num2 = 5;
					continue;
				case 6:
					result = P_0.CqZone;
					num2 = ⴃႣ[131] - 64723;
					continue;
				case 2:
				case 9:
					result = P_0.SkimWpm;
					num2 = 5;
					continue;
				case 5:
				{
					num++;
					int num3 = 123;
					int num4 = 944;
					num2 = ((7552 > num4 - num3 * 8) ? (ⴃႤ[221] - 30814) : (ⴐ[52] - 12237));
					continue;
				}
				case 11:
					num2 = 10;
					continue;
				case 0:
					return result;
				case 3:
				case 8:
					num2 = ⴀ[381] - 35971;
					continue;
				}
				break;
			}
		}
	}
}
