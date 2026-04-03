using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using ZedGraph;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public sealed class DxSpotRates
{
	internal sealed class ႠႥ
	{
		internal Button Ⴃ;

		internal ImageList Ⴍ;

		internal ႠႥ()
		{
		}
	}

	internal sealed class ႠႣ
	{
		internal List<HighlightCtyCfg> Ⴗ;

		internal List<HighlightCqZoneCfg> Ⴃ;

		internal List<HighlightItuZoneCfg> Ⴐ;

		internal ႠႣ()
		{
		}
	}

	private double[] Ⴈ;

	private double[] Ⴗ;

	private double[] Ⴓ;

	private double[] Ⴀ;

	private double[] m_Ⴍ;

	private double[] Ⴅ;

	private double[] m_Ⴃ;

	private ႥႠ.ႭႰ ႤႥ;

	public double[] DxCount
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return ႤႥ.Ⴗ;
		}
		set
		{
			ႤႥ.Ⴗ = value as double[];
		}
	}

	public double[] SkimCount
	{
		get
		{
			return ႤႥ.Ⴓ;
		}
		set
		{
			ႤႥ.Ⴓ = value as double[];
		}
	}

	public double[] NotSkimDupe
	{
		get
		{
			double[] ⴈ = Ⴈ;
			HighlightCtyCfg.ႠႠ[54] = (char)((HighlightCtyCfg.ႠႠ[54] ^ HighlightCtyCfg.ႠႠ[9]) & 0x99);
			return ⴈ;
		}
		set
		{
			Ⴈ = value;
		}
	}

	public double[] Lotw
	{
		get
		{
			return Ⴗ;
		}
		set
		{
			Ⴗ = value;
		}
	}

	public double[] Master
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

	public double[] InCb
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

	public double[] Unique1
	{
		get
		{
			return this.m_Ⴍ;
		}
		set
		{
			this.m_Ⴍ = value;
		}
	}

	public double[] Unique2
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			return Ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	public double[] Unique3
	{
		get
		{
			return this.m_Ⴃ;
		}
		set
		{
			this.m_Ⴃ = value;
		}
	}

	public double[] Unique4
	{
		get
		{
			return ႤႥ.Ⴐ;
		}
		set
		{
			ႤႥ.Ⴐ = value;
		}
	}

	internal DxSpotRates()
	{
		DxCount = new double[30];
		SkimCount = new double[30];
		NotSkimDupe = new double[30];
		Lotw = new double[30];
		Master = new double[30];
		InCb = new double[30];
		Unique1 = new double[30];
		Unique2 = new double[30];
		Unique3 = new double[30];
		Unique4 = new double[30];
	}

	internal void Ⴍ(DxSpot P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 8;
		while (true)
		{
			switch (num)
			{
			default:
				DxCount[29] += 1.0;
				num = ((!DxSpotRateGraph.Ⴈ(P_0, 314, 292)) ? 20 : 7);
				break;
			case 7:
				SkimCount[29] += 1.0;
				num = 20;
				break;
			case 20:
				num = ((!DxFilters.Ⴄ(P_0, 'Ĕ', 379)) ? 1 : (ⴀႠ[31] - 4539));
				break;
			case 1:
				NotSkimDupe[29] += 1.0;
				num = 3;
				break;
			case 3:
				num = ((!FilterPicker.ႥႤ(P_0, 607, 567)) ? (ⴗ[72] - 15843) : 17);
				break;
			case 17:
				Lotw[29] += 1.0;
				num = 6;
				break;
			case 2:
			case 6:
				num = ((!FilterPicker.ႥႤ(P_0, 636, 535)) ? 4 : 14);
				break;
			case 14:
				Master[29] += 1.0;
				num = ⴗ[26] - 21709;
				break;
			case 4:
				num = ((!DxSpotRateGraph.Ⴈ(P_0, 930, 959)) ? 5 : (ⴄ[176] - 2229));
				break;
			case 15:
				InCb[29] += 1.0;
				num = 5;
				break;
			case 5:
				num = ((ClientCty.ႠႷ(P_0, 400, 487) == 1) ? (ⴄ[205] - 14638) : 0);
				break;
			case 9:
				Unique1[29] += 1.0;
				num = 0;
				break;
			case 0:
				num = ((ClientCty.ႠႷ(P_0, 434, 453) <= 1) ? 11 : 21);
				break;
			case 21:
			{
				ref double reference = ref Unique2[29];
				double num2 = reference;
				ႥႰ.Ⴗ[141] = (char)((ႥႰ.Ⴗ[141] | HighlightCtyCfg.ႠႠ[122]) & 0x86);
				reference = num2 + 1.0;
				num = 11;
				break;
			}
			case 11:
				num = ((ClientCty.ႠႷ(P_0, 553, 606) <= 2) ? 13 : 12);
				break;
			case 12:
			case 18:
				Unique3[29] += 1.0;
				num = ⴀႠ[68] - 51734;
				break;
			case 13:
				num = ((P_0.Unique <= 3) ? (ⴗ[28] - 37792) : 19);
				break;
			case 19:
				Unique4[29] += 1.0;
				num = 16;
				break;
			case 10:
			case 16:
				return;
			}
		}
	}

	internal void Ⴃ()
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 14;
				break;
			case 18:
				DxCount[num2] = DxCount[num2 + 1];
				num = ⴄ[171] - 39996;
				break;
			case 15:
				SkimCount[num2] = SkimCount[num2 + 1];
				num = 8;
				break;
			case 8:
				NotSkimDupe[num2] = NotSkimDupe[num2 + 1];
				num = 16;
				break;
			case 16:
				Lotw[num2] = Lotw[num2 + 1];
				goto case 5;
			case 5:
				num = ⴄ[92] - 14808;
				break;
			case 7:
				Master[num2] = Master[num2 + 1];
				num = ⴗ[0] - 29149;
				break;
			case 10:
				InCb[num2] = InCb[num2 + 1];
				num = 20;
				break;
			case 20:
				Unique1[num2] = Unique1[num2 + 1];
				num = 17;
				break;
			case 3:
			case 17:
				Unique2[num2] = Unique2[num2 + 1];
				num = 0;
				break;
			case 0:
				Unique3[num2] = Unique3[num2 + 1];
				num = ⴗ[55] - 30981;
				break;
			case 4:
				Unique4[num2] = Unique4[num2 + 1];
				num = 9;
				break;
			case 1:
			case 9:
				num2++;
				num = 14;
				break;
			case 14:
				num = ((num2 < 29) ? (ⴅ[0] - 144) : ⴅ[23]);
				break;
			case 13:
				DxCount[29] = 0.0;
				SkimCount[29] = 0.0;
				num = ⴄ[277] - 52016;
				break;
			case 2:
				NotSkimDupe[29] = 0.0;
				Lotw[29] = 0.0;
				num = 12;
				break;
			case 12:
				Master[29] = 0.0;
				InCb[29] = 0.0;
				num = ⴗ[69] - 62794;
				break;
			case 11:
				Unique1[29] = 0.0;
				Unique2[29] = 0.0;
				num = ⴄ[180] - 27677;
				break;
			case 19:
				Unique3[29] = 0.0;
				Unique4[29] = 0.0;
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static DxSpotRates()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static void ႠႷ<_0021_00210>(_0021_00210 P_0, double P_1, short P_2, int P_3) where _0021_00210 : ZedGraphControl
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 0;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 9;
				break;
			case 9:
				num = (((P_3 ^ P_2) - 71) ^ num3) switch
				{
					0 => 4, 
					1 => 5, 
					2 => 10, 
					_ => ⴀႠ[24] - 40403, 
				};
				break;
			case 11:
				num = 3;
				break;
			case 4:
				P_0.ScrollMaxY = P_1;
				num = 3;
				break;
			case 1:
			case 5:
				P_0.ScrollMaxY2 = P_1;
				num = ⴗ[140] - 60682;
				break;
			case 10:
				P_0.ScrollMinX = P_1;
				goto case 3;
			case 3:
				num3++;
				num2 = P_2 * P_2;
				goto case 2;
			case 2:
				num2 = P_2 + num2;
				num = 8;
				break;
			case 8:
				num = ((num2 % 2 != 0) ? (ⴀႠ[58] - 24324) : (ⴅ[107] - ⴅ[171]));
				break;
			case 6:
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႠ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, short P_3) where _0021_00210 : DataGridView
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 8;
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
				num = (((P_3 ^ P_2) - 39) ^ num2) switch
				{
					0 => ⴀႠ[16] - 39558, 
					1 => 9, 
					2 => 6, 
					_ => ⴀႠ[55] - 49883, 
				};
				break;
			case 10:
				num = 4;
				break;
			case 5:
			case 7:
				P_0.AllowUserToAddRows = P_1;
				num = 4;
				break;
			case 9:
				P_0.AllowUserToDeleteRows = P_1;
				goto case 0;
			case 0:
				num = ⴀႠ[44] - 48724;
				break;
			case 6:
				P_0.AllowUserToResizeRows = P_1;
				goto case 4;
			case 4:
				num2++;
				goto case 3;
			case 3:
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴗ[6] - 61631) : (ⴗ[136] - 30453));
				break;
			case 11:
				num = 1;
				break;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႭ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : DataGridView where _0021_00211 : DataGridViewCellStyle
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 9;
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
				UserCmd.Ⴅ[1] = (byte)((UserCmd.Ⴅ[1] | ႥႰ.Ⴗ[91]) & 9);
				num = (((P_2 ^ P_3) - 30) ^ num3) switch
				{
					0 => 10, 
					1 => 3, 
					_ => ⴅ[157] / 3, 
				};
				break;
			case 7:
				num = ⴗ[128] - 43521;
				break;
			case 1:
			case 10:
				P_0.AlternatingRowsDefaultCellStyle = P_1;
				num = 2;
				break;
			case 3:
				P_0.RowHeadersDefaultCellStyle = P_1;
				goto case 2;
			case 2:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 5;
				break;
			case 4:
			case 5:
				num = ((num2 % 2 != 0) ? (ⴀႠ[127] - 365) : (ⴗ[103] - 55683));
				break;
			case 0:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႨ<_0021_00210>(_0021_00210 P_0, Color P_1, char P_2, short P_3) where _0021_00210 : DataGridViewCellStyle
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 0;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴀႠ[89] - 12664;
				break;
			case 6:
				num = (((P_3 ^ P_2) - 91) ^ num3) switch
				{
					0 => 1, 
					_ => 4, 
				};
				break;
			case 4:
				num = 8;
				break;
			case 1:
			case 5:
				P_0.ForeColor = P_1;
				goto case 8;
			case 8:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				goto case 3;
			case 3:
				num = ⴅ[25];
				break;
			case 2:
				num = ((num2 % 2 != 0) ? 6 : 7);
				break;
			case 7:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႰ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : TreeView where _0021_00211 : ImageList
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴗ[109] - ⴗ[109];
				continue;
			case 0:
				num = (((P_3 ^ P_2) - 14) ^ num2) switch
				{
					0 => 2, 
					_ => ⴗ[146] - 39756, 
				};
				continue;
			case 4:
			case 6:
				num = 5;
				continue;
			case 2:
			case 3:
				P_0.ImageList = P_1;
				break;
			case 5:
				break;
			case 1:
			case 7:
				return;
			}
			num2++;
			int num3 = 1995;
			int num4 = 353;
			num = ((665 >= num3 / 3 - num4) ? 1 : (ⴄ[114] - ⴄ[114]));
		}
	}

	[SecuritySafeCritical]
	internal static DataGridViewCell ႠႳ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : string where _0021_00211 : DataGridViewCellCollection
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[127] - 362;
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
				case 9:
					num2 = (((P_2 ^ P_3) - 107) ^ num) switch
					{
						0 => 1, 
						_ => 2, 
					};
					continue;
				case 2:
					disposable = null;
					num2 = ⴅ[173] - 119;
					continue;
				case 1:
					disposable = P_0[P_1];
					num2 = ⴅ[327] - 210;
					continue;
				case 11:
					num++;
					goto case 3;
				case 3:
				case 8:
				{
					int num3 = 320;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? (ⴗ[120] - 5079) : 0);
					continue;
				}
				case 0:
					num2 = 9;
					continue;
				case 5:
				case 6:
				{
					DataGridViewCell result = (DataGridViewCell)disposable;
					UserCmd.Ⴅ[350] = (byte)(UserCmd.Ⴅ[350] & HighlightCtyCfg.ႠႠ[83] & 0x10);
					return result;
				}
				case 4:
					num2 = ⴄ[83] - 37151;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႠႤ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DataGridViewRowCollection
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[25];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[28] - 37808;
					continue;
				case 0:
					break;
				case 2:
					num2 = (((P_1 ^ P_2) - 75) ^ num) switch
					{
						0 => ⴅ[394] - 42, 
						_ => 5, 
					};
					continue;
				case 5:
					result = 0;
					goto case 7;
				case 7:
					num2 = 11;
					continue;
				case 1:
				case 8:
					result = P_0.Count;
					num2 = 11;
					continue;
				case 10:
				case 11:
				{
					num++;
					int num3 = 149;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? 9 : 4);
					continue;
				}
				case 4:
					num2 = 2;
					continue;
				case 9:
					return result;
				case 3:
					num2 = ⴄ[127] - 372;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႠႼ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[145] - 59477;
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
				case 8:
					num2 = (((P_1 ^ P_2) - 28) ^ num) switch
					{
						0 => 9, 
						1 => ⴀႠ[87] - 21220, 
						_ => 11, 
					};
					continue;
				case 11:
					result = false;
					num2 = ⴗ[41] - 23794;
					continue;
				case 9:
				case 12:
					result = UtilsCallsign.IsValidCall(P_0);
					num2 = 10;
					continue;
				case 0:
					result = File.Exists(P_0);
					num2 = ⴄ[282] - 3994;
					continue;
				case 1:
				case 10:
					num++;
					num3 = 139;
					goto case 3;
				case 3:
				{
					int num4 = 879;
					num2 = ((3516 > num4 - num3 * 4) ? (ⴗ[47] - 43003) : 5);
					continue;
				}
				case 5:
					num2 = 8;
					continue;
				case 2:
					return result;
				case 7:
					num2 = ⴄ[247] - 48898;
					continue;
				}
				break;
			}
		}
	}
}
