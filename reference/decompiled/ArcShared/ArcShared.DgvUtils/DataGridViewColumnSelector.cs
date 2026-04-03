using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.Constants;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.MaintenanceUpdates;
using Ⴃ;

namespace ArcShared.DgvUtils;

public sealed class DataGridViewColumnSelector
{
	public int MaxHeight = 300;

	public int Width = 200;

	internal static ႰႰ Ⴃ/* Not supported: data(CD 43 86 03 8F CE 83 E4 F1 7F 50 A5 38 CF 22 77 6A 80 FB C5 57 83 5E BC C1 F6 1A 88 B6 86 1C 4D C9 C5 4A B3 2B 50 91 54 CD 4A 92 55 E6 52 38 B5 A2 0F B6 D4 E8 01 81 9A CB 06 F5 F7 B4 1E 0F B1 AA 00 1A 59 4D 5F 53 38 1E 1D CA 81 62 09 72 A2 58 9C 9C E7 89 3E A8 32 6E 9C 3A B2 B8 BE 66 FF DF 97 44 AF EE 92 61 08 D8 2F 57 B1 2D B0 3A EE 9F B0 56 19 E1 D4 39 AB 67 A3 B6 34 56 70 74 88 46 A7 47 D2 B4 BB A6 9D CD 28 63 4E FE 2F FF 43 E7 A9 B8 AD 38 B8 2F 63 08 17 3D 20 CA 18 66 5D FE 15 81 02 A2 02 86 57 06 65 53 16 36 81 51 4F EB A8 12 71 B3 87 C7 03 E7 AC 28 5E 0A FF A1 67 45 77 14 B6 60 8B 25 CA 85 F6 12 21 99 D6 7C 49 45 7F EF 4E 78 5E 1E 82 1E F9 FE 4C 31 D7 62 90 8C 00 7B 77 3B 95 E6 A0 14 32 D0 18 6D 23 F3 90 10 51 63 6C B9 F4 BA B7 AE C6 36 2C 16 97 BF 4B AD AE 96 50 E8 EB F3 60 DB 94 A3 4E DF 66 EA F4 E6 2B 24 B9 3F D8 17 16 D9 B7 16 FF 31 56 ED 5B DF 99 4F F7 3B 03 6C 35 EB C8 23 5E 8D 35 75 5E A7 92 6C FA 15 79 22 8A 57 2C DE 1E CC 82 0F 53 D7 B7 B9 12 70 D3 88 A8 14 61 3E 76 86 FB E8 B1 9B 10 50 A0 FF 74 EF 78 90 40 55 0D 19 D9 F8 51 31 16 CC 98 DA 1D 5E CF FB 28 AA 61 D2 82 89 50 09 1B 73 8D 4A CE 6E 9A 8C D5 BC DC 92 C8 08 0D 57 36 2F 85 3F 5E 1F A5 A6 2B A8 AD D8 FA A1 23 C8 FB 52 51 D0 24 9B 28 23 E9 9C BC E4 1D 51 85 52 21 1D 27 F0 73 8A 93 03 01 6D B3 14 2A 2C 56 E5 8F E6 82 7E 8D 9F D3 F2 A7 18 61 5A DC DE 33 BC D7 F6 67 97 42 5F BB 15 AF FA 33 51 26 88 68 F2 9D 38 FA 94 D3 A7 D7 DA 3C 37 5A 64 67 6B 5E 8F 6F F9 48 1B 79 6F AE CB 68 08 35 04 0C E9 82 1B 5B 12 08 39 15 BE A8 29 20 38 27 AE 7B B0 9A F7 74 F0 F0 DE 50 2C 81 05 7A 83 62 3A D6 57 ED CB 00 67 0B 96 F5 CA 06 D7 DF 6B 52 51 19 AE 35 81 1B 13 2F 10 64 F8 5E FB E7 EA 2D 11 CB B3 A2 F2 5B AD BF 44 60 02 A7 C0 1E 92 7D 5F 48 BA 76 8A 7E E4 38 B0 62 E9 4B 59 09 37 E6 65 E4 0B 0D BD 72 C3 8B A4 AD 64 5D 70 3F 3A 05 10 A3 AF 08 C0 EE 8A DF 3C 8D 15 F1 27 C3 B5 1C B4 B2 0C 47 DE 25 29 AE 3A 25 57 BA 3E 02 38 2F 97 CE 37 83 07 C3 DC 7E 3F 88 F3 A6 B9 EF 67 CD 55 2C 49 35 AC 4A 04 57 3A EC 37 5C 44 80 AD 6D 43 63 B7 56 9D 1C 95 57 41 B8 34 3F 54 F0 49 57 91 B3 D4 61 2F 86 A3 1B 0A 26 2E 5B FC C0 0D 2A CC 0A 85 43 2B BD 6D 2A 5C 9A 93 C0 FA 7C 1B FC F4 18 58 21 35 B3 F3 57 68 A6 23 6C 7A 30 7C 56 C7 C6 30 B8 E5 4A 81 CE BA 9D A8 AA F5 76 62 8F E2 92 BD 6B 49 CB 6A 26 C4 20 16 D4 5D A7 25 D1 4C 74 9F 20 37 4C B4 A8 0B 9F D7 55 50 D3 AF A2 BC D9 80 20 A0 3E E9 96 FE 8B 61 98 E0 B0 6E 47 5A 31 B2 2F DB 54 D9 6D 48 10 79 F2 52 8C 23 60 8F CC C9 2D 89 97 9E 2E 48 F5 90 56 56 DB DD 44 FA 79 0E E2 A6 E3 C9 85 EB 1F C4 87 6F B7 F0 70 DE E4 35 A8 C4 F4 39 7D 07 6C 0B E0 63 03 80 FA DC BA DA 83 0E F5 11 F1 3A 7F 84 39 DC C0 D1 81 4B 94 12 EC 24 DC 42 71 4C BE B2 A4 66 AD 2C 83 29 45 C2 F9 EF 1C EF A9 BA B4 17 2B 83 27 95 A9 42 78 EA E3 F9 88 12 68 B4 FD 19 0F 1A F4 82 EC 65 2A 08 9D C1 73 6D 71 80 61 44 EA A1 C5 75 40 32 21 D4 61 7C F1 D7 33 9E AB 2D 46 A2 B2 2C 40 CE FA 98 71 10 38 44 72 1C C3 73 59 C6 45 C5 8F 57 5C 78 4B CF 78 4F 9B 89 B0 C9 58 1C 84 32 85 F7 F7 A0 EF DC 46 44 21 F1 30 F8 3B AB 21 E3 5A 20 34 78 DC BC 88 E5 52 99 39 AA F3 F5 FD 14 32 47 31 CD 48 43 6D 1B 8C 07 D7 D6 81 66 29 F1 D0 42 57 FA E3 15 15 07 16 75 71 51 2A EB 8F 67 C8 B7 DD 4A 6C DF 3B FC BB 50 FF 5D 91 3A 0F D5 BE ED 4F 2B DD 23 3E A3 E6 B5 D0 DF F2 2C 56 AB 68 81 4D BA 46 08 6A BB 67 85 EB FF F7 29 AE 20 76 3A C6 E9 75 01 CA F5 4C E2 26 A3 0B 6D E9 CF 09 8D 4C 54 C0 2C 75 4D CD CB B7 F9 41 C3 32 E8 9F 92 39 6C AE 2E 3C DB F9 B3 43 C2 42 3C 00 61 64 CE 8D 68 AC 85 C8 BA 2A 48 C0 2F 28 E0 DC B7 E5 20 BE BD C5 C0 F5 66 89 5B C7 44 C2 F3 97 49 44 BD F3 54 34 15 9A 60 10 B3 7D DD 88 DF B0 88 0B F7 13 1E CA 28 2E 19 3D D0 BB 4D B4 6D 32 78 83 AC 75 A0 65 25 BF 78 7A 1D 43 B2 BE 85 49 5E 24) */;

	internal static char[] Ⴐ;

	private StringConstants.Ⴀ Ⴅ = new StringConstants.Ⴀ();

	public DataGridView DataGridView
	{
		get
		{
			return Ⴅ.Ⴃ;
		}
		set
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((Ⴅ.Ⴃ == null) ? (ⴃႭ[178] - 58283) : 7);
					break;
				case 7:
					DgvTextBoxColumnFilter.Ⴜ<DataGridView, DataGridViewCellMouseEventHandler>(Ⴅ.Ⴃ, Ⴄ, 'ƹ', 'Ʈ');
					goto case 6;
				case 6:
					Ⴅ.Ⴃ = value;
					goto case 2;
				case 2:
					num = ((Ⴅ.Ⴃ == null) ? 1 : 5);
					break;
				case 5:
					Ⴅ.Ⴃ.CellMouseClick += Ⴄ;
					return;
				case 1:
					return;
				}
			}
		}
	}

	private void Ⴄ(object P_0, DataGridViewCellMouseEventArgs P_1)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 2;
		object obj2 = default(object);
		int num6 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
			{
				MouseButtons num7 = ArcLogInRqstExt.Ⴄ((MouseEventArgs)P_1, 941, (short)908);
				WxCfg.ႣႭ[150] = (char)(WxCfg.ႣႭ[150] & WxCfg.ႣႭ[153] & 0x7B);
				if (num7 == MouseButtons.Right)
				{
					num = 5;
					break;
				}
				return;
			}
			case 1:
			case 4:
			case 5:
				if (ColumnFilterEventArgs.Ⴓ(P_1, 138, 217) == -1)
				{
					num = ⴀ[264] - 5865;
					break;
				}
				return;
			case 6:
				if (ColumnFilterEventArgs.Ⴓ(P_1, 116, 32) == -1)
				{
					num = 0;
					break;
				}
				return;
			case 0:
			{
				UtilsCallsign.ႰႳ(Ⴅ.Ⴍ, 208, 129).Clear();
				object obj = PrecisionTimer.ႤႭ((BaseCollection)DgvFilterManager.ႭႰ(Ⴅ.Ⴃ, 'ʻ', 669), (short)998, 998);
				try
				{
					int num2 = 3;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = 7;
							continue;
						case 1:
						{
							IDisposable disposable = (DataGridViewColumn)((IEnumerator)obj).Current;
							UtilsCallsign.ႰႳ(Ⴅ.Ⴍ, 933, 1012).Add(AnnWxSpotExt.Ⴀ(disposable as DataGridViewColumn, 865, 840), GlobalConst.Ⴍ((DataGridViewBand)(DataGridViewColumn)disposable, (short)1010, 988));
							num2 = 7;
							continue;
						}
						case 7:
							num2 = ((obj as IEnumerator).MoveNext() ? 1 : 0);
							continue;
						case 0:
						case 2:
							break;
						}
						break;
					}
				}
				finally
				{
					int num3 = 0;
					while (true)
					{
						int num4;
						switch (num3)
						{
						default:
							obj2 = (obj as IEnumerator) as IDisposable;
							num4 = (((IDisposable)obj2 == null) ? 3 : 5);
							goto IL_01e4;
						case 2:
						case 5:
							(obj2 as IDisposable).Dispose();
							break;
						case 3:
							break;
						}
						break;
						IL_01e4:
						num3 = num4;
					}
				}
				int num5 = 1;
				while (true)
				{
					switch (num5)
					{
					default:
						num6 = UtilsCallsign.ႰႳ(Ⴅ.Ⴍ, 611, 562).Count * 16 + 7;
						goto IL_0242;
					case 0:
					case 3:
						goto IL_0242;
					case 6:
						Ⴅ.Ⴍ.Height = ((num6 < MaxHeight) ? num6 : MaxHeight);
						break;
					case 4:
						break;
					case 2:
						return;
					}
					break;
					IL_0242:
					num5 = 6;
				}
				Ⴅ.Ⴍ.Width = Width;
				Ⴅ.Ⴄ.Show(Ⴅ.Ⴃ.PointToScreen(new Point(P_1.X, P_1.Y)));
				return;
			}
			}
		}
	}

	public DataGridViewColumnSelector()
	{
		object obj = new CheckedListBox();
		Ⴅ.Ⴍ = obj as CheckedListBox;
		DgvTextBoxColumnFilter.ႷႷ(Ⴅ.Ⴍ, true, 241, 189);
		DgvTextBoxColumnFilter.ႷႰ<ItemCheckEventHandler, CheckedListBox>(Ⴅ.Ⴍ, Ⴀ, '\u02f1', 748);
		object obj2 = new ToolStripControlHost(Ⴅ.Ⴍ);
		DgvCheckBoxColumnFilter.Ⴅ((ToolStripItem)(ToolStripControlHost)obj2, Padding.Empty, (short)178, (short)134);
		DirectoryMonitor.ႠႨ((ToolStripItem)(obj2 as ToolStripControlHost), Padding.Empty, 563, 'Ȕ');
		UtilsSql.ႨႤ((ToolStripItem)(ToolStripControlHost)obj2, false, 'Ƽ', (short)407);
		ToolStrip toolStrip = new ToolStripDropDown();
		Ⴅ.Ⴄ = toolStrip as ToolStripDropDown;
		Ⴅ.Ⴄ.Padding = Padding.Empty;
		Ⴅ.Ⴄ.Items.Add((ToolStripControlHost)obj2);
	}

	public DataGridViewColumnSelector(DataGridView dgv)
		: this()
	{
		DataGridView = dgv;
	}

	private void Ⴀ(object P_0, ItemCheckEventArgs P_1)
	{
		UtilsCallsign.ႰႷ(DgvFilterManager.ႭႰ(Ⴅ.Ⴃ, 'ŕ', 371), UtilsPerformance.Ⴄ(P_1, 606, 639), 830, '\u033c').Visible = P_1.NewValue == CheckState.Checked;
	}
}
