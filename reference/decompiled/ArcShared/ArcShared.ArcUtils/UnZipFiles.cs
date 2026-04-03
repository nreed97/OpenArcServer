using System;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;
using System.Xml;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.MaintenanceUpdates;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ArcShared.ArcUtils;

public sealed class UnZipFiles
{
	internal sealed class Ⴐ
	{
		internal string Ⴓ;

		internal string Ⴗ;

		internal Ⴐ()
		{
		}
	}

	public static string UnZip(string zipFile, string workPath)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		InflaterInputStream inflaterInputStream = new ZipInputStream(ArcLogInRqstExt.Ⴜ(zipFile, 941, 908));
		try
		{
			int num = 2;
			IEquatable<string> equatable2 = default(IEquatable<string>);
			object nextEntry = default(object);
			IEquatable<string> equatable = default(IEquatable<string>);
			object obj = default(object);
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				case 3:
					equatable2 = DownloadUrl2.ႥႤ(ColumnFilterEventArgs.Ⴅ(nextEntry as ZipEntry, 1006, 957), 'µ', 'Ù');
					goto case 7;
				case 7:
					num = ⴃႣ[215] - 32475;
					break;
				case 5:
					equatable = DgvDateColumnFilter.ႳႳ(ColumnFilterEventArgs.Ⴅ(nextEntry as ZipEntry, 380, 303), 595, 516);
					num = ⴃႣ[96] - 36626;
					break;
				case 6:
				case 8:
				{
					int num7 = UtilsCallsign.Ⴓ(equatable2 as string, 208, 231);
					WxCfg.ႣႭ[231] = (char)((WxCfg.ႣႭ[231] | WxCfg.ႣႭ[29]) & 0xD9);
					num = ((num7 > 0) ? 1 : 9);
					break;
				}
				case 1:
					DgvFilterManager.ႭႷ((string)equatable2, 'ʻ', 669);
					num = ⴃႣ[5] - 35951;
					break;
				case 9:
					if (ColumnFilterEventArgs.Ⴀ((string)equatable, string.Empty, 935, 1000))
					{
						num = 10;
						break;
					}
					goto default;
				case 10:
				{
					Stream stream = DirectoryMonitor.ႠႤ(ReverseBeaconClient.Ⴗ(workPath, ColumnFilterEventArgs.Ⴅ(nextEntry as ZipEntry, 221, 142), '\u0001', 'I'), 73, 'Q');
					try
					{
						int num2 = 8;
						while (true)
						{
							switch (num2)
							{
							default:
								obj = new byte[2048];
								num2 = ⴃႤ[227] - 15382;
								continue;
							case 2:
								num3 = DxSpotExt.Ⴈ((Stream)(ZipInputStream)inflaterInputStream, (byte[])obj, 0, (obj as byte[]).Length, 93, (short)106);
								goto case 0;
							case 0:
								num2 = 1;
								continue;
							case 1:
							case 6:
								num2 = ((num3 <= 0) ? (ⴗ[12] - 35088) : (ⴐ[64] - 42815));
								continue;
							case 7:
								((FileStream)stream).Write((byte[])obj, 0, num3);
								num2 = ⴀ[61] - 55678;
								continue;
							case 3:
								break;
							}
							break;
						}
					}
					finally
					{
						int num4 = 6;
						while (true)
						{
							int num5;
							switch (num4)
							{
							default:
								num5 = (((FileStream)stream == null) ? (ⴃႭ[153] - 46369) : (ⴃႤ[462] - 62255));
								goto IL_02d0;
							case 0:
							case 3:
							case 5:
								((IDisposable)(FileStream)stream).Dispose();
								break;
							case 1:
								break;
							}
							break;
							IL_02d0:
							num4 = num5;
						}
					}
					goto default;
				}
				default:
				{
					int num6 = 0;
					while (true)
					{
						switch (num6)
						{
						default:
							if ((nextEntry = ((ZipInputStream)inflaterInputStream).GetNextEntry()) == null)
							{
								goto IL_0325;
							}
							break;
						case 4:
							goto end_IL_02f4;
						}
						goto case 3;
						IL_0325:
						num6 = 4;
						continue;
						end_IL_02f4:
						break;
					}
					goto end_IL_006b;
				}
				}
				continue;
				end_IL_006b:
				break;
			}
		}
		finally
		{
			int num8 = 1;
			while (true)
			{
				int num9;
				switch (num8)
				{
				default:
					num9 = ((!(inflaterInputStream is ZipInputStream)) ? 4 : 6);
					goto IL_035b;
				case 6:
					((IDisposable)(ZipInputStream)inflaterInputStream).Dispose();
					break;
				case 0:
				case 4:
				case 5:
					break;
				}
				break;
				IL_035b:
				num8 = num9;
			}
		}
		return 0 switch
		{
			_ => UtilsString.Ⴐ(null, 3, 192632509), 
		};
	}

	[SecuritySafeCritical]
	static UnZipFiles()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, short P_3) where _0021_00210 : Font where _0021_00211 : Control
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
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
				num = (((P_2 ^ P_3) - 30) ^ num2) switch
				{
					0 => ⴃႭ[178] - 58288, 
					_ => 5, 
				};
				break;
			case 5:
				num = 7;
				break;
			case 0:
			case 1:
			case 2:
			case 3:
				P_0.Font = P_1;
				goto case 7;
			case 7:
			{
				num2++;
				int num3 = 70;
				int num4 = 261;
				num = ((1305 > num4 - num3 * 5) ? 6 : 8);
				break;
			}
			case 8:
				num = ⴃႭ[15] - 26127;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, byte[] P_1, int P_2, int P_3, char P_4, short P_5) where _0021_00210 : Stream
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 0;
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
				num = (((P_5 ^ P_4) - 11) ^ num2) switch
				{
					0 => 6, 
					_ => 3, 
				};
				break;
			case 3:
			case 5:
			case 9:
				num = 1;
				break;
			case 2:
			case 6:
				P_0.Write(P_1, P_2, P_3);
				goto case 1;
			case 1:
				num2++;
				num = (((P_5 * P_5 + P_5) % 2 == 0) ? (ⴐ[558] - 19593) : 7);
				break;
			case 7:
				num = 8;
				break;
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : XmlWriter
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 0;
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
				num = (((P_2 ^ P_1) - 99) ^ num2) switch
				{
					0 => 7, 
					_ => ⴐ[350] - 2763, 
				};
				break;
			case 1:
				num = ⴃႣ[36] - 35708;
				break;
			case 7:
				P_0.WriteEndElement();
				goto case 4;
			case 4:
			case 8:
				num2++;
				goto case 5;
			case 5:
			{
				int num3 = 91;
				int num4 = 227;
				num = ((454 > num4 - num3 * 2) ? 3 : 9);
				break;
			}
			case 9:
				num = ⴃႤ[550] - 2689;
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : string
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႭ[102] - 34725;
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
				case 0:
				case 9:
					num2 = (((P_3 ^ P_2) - 28) ^ num) switch
					{
						0 => ⴗ[115] - 18159, 
						_ => 2, 
					};
					continue;
				case 2:
					equatable = null;
					num2 = ⴐ[437] - 33223;
					continue;
				case 11:
					equatable = string.Format(P_0, P_1);
					num2 = 10;
					continue;
				case 10:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႤ[264] - 53640) : (ⴐ[41] - 59287));
					continue;
				case 5:
					num2 = 9;
					continue;
				case 1:
				case 4:
				case 8:
					return (string)equatable;
				case 3:
					num2 = ⴃႤ[111] - 29450;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, short P_3) where _0021_00210 : PictureBox where _0021_00211 : Image
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 0;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 7;
				break;
			case 7:
				num = (((P_3 ^ P_2) - 89) ^ num3) switch
				{
					0 => ⴀ[320] - 27691, 
					_ => ⴀ[21] - 21552, 
				};
				break;
			case 3:
				num = ⴃႤ[320] - 20184;
				break;
			case 5:
				P_0.InitialImage = P_1;
				goto case 1;
			case 1:
			case 8:
				num3++;
				num2 = P_3 * P_3;
				goto case 9;
			case 9:
				num2 = P_3 + num2;
				goto case 6;
			case 6:
				num = 2;
				break;
			case 2:
				num = ((num2 % 2 != 0) ? (ⴗ[101] - 49607) : 4);
				break;
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : ToolStripDropDown
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool result = default(bool);
		int num3 = default(int);
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
					num2 = (((P_2 ^ P_1) - 43) ^ num) switch
					{
						0 => 11, 
						_ => ⴗ[52] - 52157, 
					};
					continue;
				case 6:
					result = false;
					num2 = 0;
					continue;
				case 11:
					result = P_0.Visible;
					num2 = ⴀ[85] - 17506;
					continue;
				case 0:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 5;
				case 5:
					num2 = 1;
					continue;
				case 1:
					num2 = ((num3 % 2 != 0) ? 3 : 8);
					continue;
				case 2:
				case 8:
					return result;
				case 4:
				case 7:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}
}
