using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcInterfaces.Spots;
using ArcShared;
using ArcShared.ExtensionMethods;
using ZedGraph;
using Ⴀ;

namespace ArcClientEngine.CmdProcessing.UserCmds;

public sealed class ShowUsers : ႥႳ
{
	public UserCmd Process(UserCmd cmd)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num2 = default(int);
		object obj = default(object);
		object current = default(object);
		while (true)
		{
			cmd.Ⴈ().ႳႷ(DxFilters.Ⴈ(global::Ⴀ.ႥႥ.Ⴍ(2, 1580607661, '\u0012', null), cmd.Ⴈ().Ⴐ(), 285, 325));
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴗ[76] - 24783;
					continue;
				case 0:
				case 5:
					break;
				case 1:
				case 4:
					num2 = 0;
					obj = string.Empty;
					goto case 3;
				case 3:
				{
					List<ႥႼ>.Enumerator enumerator = cmd.Ⴈ().Ⴃ().Io.TelnetServer.Ⴈ().GetEnumerator();
					try
					{
						int num3 = 13;
						while (true)
						{
							switch (num3)
							{
							default:
								num3 = ⴀႠ[78] - 14979;
								continue;
							case 12:
								current = enumerator.Current;
								num3 = ((!((ႥႼ)current).Ⴀ()) ? 9 : 4);
								continue;
							case 4:
								num3 = ((num2 != 0) ? 3 : (ⴗ[24] - 32644));
								continue;
							case 6:
								obj = DxFilters.Ⴈ(obj as string, global::Ⴀ.ႥႥ.Ⴍ(5, 1580608380, 'v', null), 519, 607);
								num3 = ⴅ[176] / 5;
								continue;
							case 3:
								obj = DxFilters.Ⴈ(obj as string, MultimediaCache.Ⴐ((current as ႥႼ).Ⴗ(), 13, 'Ɩ', 'ǲ'), 1019, 931);
								goto case 2;
							case 2:
								num3 = 0;
								continue;
							case 0:
								num2++;
								num3 = 9;
								continue;
							case 8:
							case 9:
								num3 = ((num2 >= 7) ? 1 : (ⴄ[151] - 41325));
								continue;
							case 1:
								cmd.Ⴈ().ႳႷ((string)obj);
								num2 = 0;
								obj = string.Empty;
								num3 = 11;
								continue;
							case 11:
								num3 = (enumerator.MoveNext() ? 12 : (ⴄ[0] - 30352));
								continue;
							case 10:
								break;
							}
							break;
						}
					}
					finally
					{
						switch (3)
						{
						default:
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							break;
						case 0:
						case 2:
							break;
						}
					}
					int num4 = 1;
					while (true)
					{
						int num5;
						switch (num4)
						{
						default:
							num5 = (((obj as string).Length > 0) ? 2 : 0);
							goto IL_0275;
						case 2:
						case 3:
							cmd.Ⴈ().ႳႷ((string)obj);
							break;
						case 0:
							break;
						}
						break;
						IL_0275:
						num4 = num5;
					}
					return cmd;
				}
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static ShowUsers()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, short P_3) where _0021_00210 : Chart where _0021_00211 : Fill
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႠ[127] - 369;
				break;
			case 2:
				num = (((P_2 ^ P_3) - 117) ^ num2) switch
				{
					0 => ⴄ[123] - 61745, 
					_ => 0, 
				};
				break;
			case 0:
			case 5:
			case 8:
				num = ⴀႠ[99] - 46020;
				break;
			case 3:
			case 6:
				P_0.Fill = P_1;
				goto case 4;
			case 4:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? 9 : (ⴅ[200] - 33));
				break;
			case 7:
				num = 2;
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : CtyInfo
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
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
					num2 = 8;
					continue;
				case 1:
				case 8:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 27) ^ num) switch
					{
						0 => 2, 
						_ => 3, 
					};
					continue;
				case 3:
					obj = null;
					num2 = ⴄ[71] - 57828;
					continue;
				case 2:
				case 11:
					obj = P_0.Cty;
					num2 = 9;
					continue;
				case 9:
				{
					num++;
					int num3 = 375;
					int num4 = 776;
					num2 = ((4656 > num4 - num3 * 6) ? 5 : (ⴀႠ[64] - ⴀႠ[64]));
					continue;
				}
				case 0:
					num2 = 4;
					continue;
				case 5:
				case 6:
				{
					string result = obj as string;
					Bye.Ⴄ[140] = (char)((Bye.Ⴄ[140] | P_2) & 0xA1);
					return result;
				}
				case 10:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : AnnWxSpot
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
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
					num2 = ⴀႠ[99] - 46020;
					continue;
				case 4:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 50) ^ num) switch
					{
						0 => 6, 
						1 => 11, 
						_ => ⴗ[70] - 33485, 
					};
					continue;
				case 9:
					convertible = null;
					num2 = 8;
					continue;
				case 6:
					convertible = P_0.Msg;
					num2 = ⴅ[4];
					continue;
				case 11:
					convertible = P_0.GetUserString();
					num2 = ⴅ[282] - ⴅ[8];
					continue;
				case 1:
				case 5:
				case 8:
				{
					num++;
					int num3 = 1560;
					int num4 = 472;
					num2 = ((780 < num3 / 2 - num4) ? 7 : 2);
					continue;
				}
				case 2:
					return convertible as string;
				case 0:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		float result = default(float);
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
					num2 = 7;
					continue;
				case 7:
					break;
				case 3:
					num2 = (((P_2 ^ P_1) - 99) ^ num) switch
					{
						0 => 4, 
						_ => 6, 
					};
					continue;
				case 1:
				case 6:
					result = 0.83051336f;
					num2 = 5;
					continue;
				case 4:
					result = CtyInfo.ScrubLat(P_0);
					num2 = 5;
					continue;
				case 5:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = ⴗ[55] - 30974;
					continue;
				case 11:
					num2 = ((num3 % 2 != 0) ? 3 : (ⴀႠ[63] - 29192));
					continue;
				case 8:
					return result;
				case 2:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210>(_0021_00210 P_0, AnchorStyles P_1, char P_2, int P_3) where _0021_00210 : Control
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄ[101] - 33645;
				break;
			case 4:
				num = (((P_3 ^ P_2) - 48) ^ num2) switch
				{
					0 => 1, 
					_ => 9, 
				};
				break;
			case 9:
				num = 3;
				break;
			case 1:
			case 5:
				P_0.Anchor = P_1;
				goto case 3;
			case 3:
			{
				num2++;
				int num3 = 353;
				int num4 = 708;
				num = ((2124 <= num4 - num3 * 3) ? 2 : 0);
				break;
			}
			case 2:
			case 8:
				num = ⴀႠ[84] - 18798;
				break;
			case 0:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, Color P_1, char P_2, int P_3) where _0021_00210 : ImageList
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
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
				num = (((P_3 ^ P_2) - 105) ^ num2) switch
				{
					0 => ⴅ[115], 
					_ => 6, 
				};
				continue;
			case 3:
			case 6:
				num = ⴄ[242] - 18685;
				continue;
			case 4:
				P_0.TransparentColor = P_1;
				break;
			case 1:
			case 5:
				break;
			case 7:
			case 8:
				return;
			}
			num2++;
			int num3 = 1054;
			int num4 = 373;
			num = ((527 >= num3 / 2 - num4) ? 7 : 0);
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : DataGridViewCellStyle where _0021_00211 : string
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 2;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴅ[119] - 116;
				continue;
			case 6:
				num = (((P_2 ^ P_3) - 43) ^ num2) switch
				{
					0 => 0, 
					_ => ⴀႠ[62] - 58864, 
				};
				continue;
			case 8:
				num = 7;
				continue;
			case 0:
				P_0.Format = P_1;
				goto case 7;
			case 7:
				num2++;
				num3 = 2940;
				num4 = 825;
				break;
			case 1:
			case 4:
				break;
			case 3:
			case 5:
				return;
			}
			num = ((980 < num3 / 3 - num4) ? (ⴗ[23] - 52200) : 3);
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DataGridViewColumn
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int result = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[195] - 4;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 12;
					continue;
				case 12:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 54) ^ num) switch
					{
						0 => ⴀႠ[10] - 7240, 
						1 => 1, 
						_ => 0, 
					};
					continue;
				case 0:
				case 9:
					result = 14;
					num2 = ⴅ[182] - ⴅ[28];
					continue;
				case 6:
					result = P_0.DisplayIndex;
					num2 = 7;
					continue;
				case 1:
					result = P_0.Width;
					num2 = ⴀႠ[104] - 61260;
					continue;
				case 7:
					num++;
					num3 = 735;
					num4 = 773;
					goto case 5;
				case 5:
					num2 = ((3865 > num4 - num3 * 5) ? (ⴄ[237] - 13499) : 11);
					continue;
				case 11:
					num2 = ⴄ[171] - 40008;
					continue;
				case 4:
					return result;
				case 10:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DataGridView
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 7;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 6;
				break;
			case 6:
				num = (((P_2 ^ P_1) - 50) ^ num3) switch
				{
					0 => ⴀႠ[24] - 40410, 
					_ => 0, 
				};
				break;
			case 0:
				num = 8;
				break;
			case 4:
				P_0.ClearSelection();
				goto case 1;
			case 1:
			case 8:
			{
				int num4 = num3;
				ႥႰ.Ⴗ[40] = (char)((ႥႰ.Ⴗ[40] ^ P_1) & 0x61);
				num3 = num4 + 1;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				goto case 5;
			}
			case 5:
				num = 3;
				break;
			case 3:
				num = ((num2 % 2 != 0) ? 6 : (ⴄ[112] - 29262));
				break;
			case 2:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210, _0021_00211, _0021_00212>(_0021_00211 P_0, _0021_00210 P_1, _0021_00212 P_2, char P_3, short P_4) where _0021_00211 : Hashtable
	{
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
				num = (((P_4 ^ P_3) - 77) ^ num2) switch
				{
					0 => 2, 
					_ => 6, 
				};
				break;
			case 6:
				num = 1;
				break;
			case 2:
				P_0.Add(P_1, P_2);
				goto case 1;
			case 1:
			case 8:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 != 0) ? 5 : 0);
				break;
			case 5:
				num = 9;
				break;
			case 0:
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႣ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : Thread where _0021_00211 : string
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 1;
				break;
			case 1:
				num = (((P_2 ^ P_3) - 126) ^ num2) switch
				{
					0 => ⴄ[196] - 35765, 
					_ => ⴀႠ[112] - 45131, 
				};
				break;
			case 3:
				num = 7;
				break;
			case 5:
				P_0.Name = P_1;
				goto case 4;
			case 4:
			case 7:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 8 : 9);
				break;
			case 0:
			case 9:
				num = ⴗ[52] - 21969;
				break;
			case 2:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႥႥ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : Assembly where _0021_00211 : Assembly
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		bool result = default(bool);
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
					num2 = ⴗ[66] - 45145;
					continue;
				case 9:
					break;
				case 3:
				{
					int num5;
					switch (((P_2 ^ P_3) - 126) ^ num)
					{
					default:
					{
						byte num6 = ⴅ[17];
						UserCmd.Ⴅ[149] = (byte)((UserCmd.Ⴅ[149] | P_3) & 0x94);
						num5 = num6 / 8;
						break;
					}
					case 0:
						num5 = 4;
						break;
					}
					num2 = num5;
					continue;
				}
				case 0:
					result = true;
					num2 = 6;
					continue;
				case 4:
				case 8:
					result = P_0 != P_1;
					num2 = ⴅ[92] - 238;
					continue;
				case 6:
					num++;
					goto case 2;
				case 2:
				{
					int num3 = 1934;
					int num4 = 477;
					num2 = ((967 >= num3 / 2 - num4) ? 1 : (ⴅ[7] - 107));
					continue;
				}
				case 1:
				case 7:
					return result;
				case 10:
					num2 = ⴅ[318] - 238;
					continue;
				}
				break;
			}
		}
	}
}
