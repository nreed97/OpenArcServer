using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Io;
using ArcShared.ArcIo.Tcp;
using ZedGraph;
using Ⴀ;

namespace ArcClientEngine.ArcForms;

public class SkimmerSpotRateGraph : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2867)]
	private struct Ⴈ
	{
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct ႤႥ
	{
		internal int Ⴐ;

		internal CacheManager Ⴄ;

		internal ႥႨ Ⴍ;
	}

	private DxSpotRates Ⴗ;

	private IContainer Ⴃ;

	private ZedGraphControl Ⴓ;

	internal static Ⴈ Ⴀ/* Not supported: data(2F 79 C2 A6 DB 81 5F EF ED E3 A0 04 B4 AF 9B 27 99 03 35 A2 76 D0 59 BA C8 F8 05 4E 9F F0 0D 23 6B 29 03 74 0B F5 80 AD C8 C5 46 C4 6E 3A 94 A4 96 A9 93 E0 B7 34 14 67 47 0B 23 85 10 BD F6 DC 78 EB B8 F1 BD 33 94 44 2C FB D2 F1 30 4C 77 76 12 78 E3 D8 5D C2 D0 84 3A 9C B7 D6 00 1F 5F 5E 3C 1B 07 98 DF 81 16 C3 FC D4 98 51 A2 6F D2 E5 CB 41 DD C9 C8 CF C6 C7 50 C0 27 41 E8 EF 60 8D AC ED 7A 71 7A 37 59 B7 B4 7B B4 13 B1 CE 8E B6 84 AC 8E 28 BB C7 A6 07 A4 F2 02 AD A6 5F 9E D9 DD FD 72 2B DD C2 C2 E1 51 37 C9 BD 03 C9 DD A8 07 E6 D2 83 0D E1 6F B1 8F 95 EA D1 AC C5 B4 49 44 3B 74 E9 1B 74 E7 80 68 69 64 21 7E FB AD 6D A6 EB 38 C9 74 A7 61 67 65 39 CA 98 71 DF 55 C9 5F FE 1A 4D C8 50 C2 54 AD 13 6B 01 1E F5 CE 4E E9 46 6C 4E AE 45 2A 20 AD 03 1A 42 41 AB C8 1C BB 08 0A 99 24 C7 BB 25 37 16 72 08 20 29 56 2D C9 6B 13 B9 11 27 AA E5 36 D3 A3 20 F2 0A 1E 57 14 93 0A 1F E4 96 64 B5 08 DB 37 1A 12 20 62 0C E9 4B 33 99 17 05 00 E1 2B 23 22 08 01 1E B6 FB B8 92 7B E8 F8 4A 60 E1 84 D9 31 FA FE 0F 21 BC E0 A6 8F 3C 19 67 99 AC E2 4A C5 F0 E8 DC 14 5C AE 03 C4 01 90 57 57 99 4C DE DE F5 90 36 71 CD 89 8B F3 59 70 A8 C7 9B 64 27 89 AD D8 25 BB 29 BF 5E BA 92 A8 52 36 7D BD B0 20 BA B0 2F B0 CD AA 4B AA D7 08 CB 27 A4 92 A8 A2 AC AA 15 B2 84 E8 95 CE DA CE BE 9C 5E 04 80 02 C1 9D 1C E7 A5 D0 00 A4 3A DC C2 55 5C D8 88 5A 8D C5 A9 2B 67 E4 7F 66 9B 7B BF C3 C5 5D E9 36 20 7C 5F 07 6B 29 39 26 E4 03 26 C5 D5 51 FE 67 E5 7A 77 CE 08 14 5D 57 15 6E 2B AE 73 56 45 50 E1 D8 AF 6F 69 7C C3 BB A8 49 C0 06 09 4E 0E 90 A8 06 39 21 B7 1D 3E F1 B8 BE 34 DD 35 C8 02 76 07 30 D7 21 2C E6 21 2A A9 77 6E 26 B4 6A 40 88 89 12 18 B8 B7 CC 7E 14 3F C5 53 21 75 FC A1 16 54 42 03 9D F3 EF 97 18 48 F6 84 6C 94 44 19 C2 0A 84 FF 98 22 E0 F3 0D A1 D8 E9 26 F7 C6 CA B2 C8 D6 BF A0 EA 26 A6 4A F5 F5 CF D1 53 BF C6 42 BD B9 BF 38 5F A1 C3 D2 42 9B D7 46 50 55 61 D3 B5 37 2A 32 C8 DD FB 27 B4 88 16 43 C3 BE 8B 9E 2C A5 BE 7B 0D F0 72 BE B3 38 65 E9 BE 28 AC B1 91 5B AF AD 1C EC 55 DC 92 40 F7 C6 EF E4 BA 84 F1 A6 9C B6 98 56 1B A8 39 8C BF 95 5F 15 A1 32 29 90 8F EA BB 8C 0B E8 89 8C AF 85 CB 24 8F AA 86 72 7E 6E DD 70 4D 2A 7F 42 27 70 63 24 75 66 72 F5 2F 97 6C 6E 21 EB 1B C8 EB 72 4D 65 A9 E3 53 40 33 5F 5D 38 75 5A D9 EA C2 52 B1 7B 9B 12 60 C0 47 DA 4E 29 CB A5 CB 40 BF 44 60 04 7A 12 4B B8 3D 5B 3E 30 13 21 59 78 EE 34 37 A0 31 D7 71 39 EF 95 6D 2C 97 6A 30 68 2F B2 38 3C 23 29 B5 21 D3 5E 04 BC A5 DA 09 1A 52 1D 15 B4 3F 13 11 38 4A B6 1F 8D 6F AA 05 20 00 4C 85 DC 06 02 B9 0B FF 3A F6 FC AB ED F9 58 D8 F6 95 DB F3 12 3C B3 8F E8 27 9A D8 AA C0 5C E4 E2 71 E5 B5 E9 E1 60 A3 DF DD 5C DB BF D9 FA 87 D0 E5 FA E3 52 AC D1 CA 2E C3 EA 9B C0 69 E5 87 46 E8 94 C5 6A C1 A5 3F BC ED C6 2B AA 57 71 AF BD B5 74 D7 B3 B1 80 81 76 A6 64 2E F6 08 98 A1 86 65 C0 A3 B8 31 21 AD 9E 99 B4 F6 D3 81 D8 4E DC 92 DE 9C 90 57 10 0F BF AD EC 87 82 F6 84 1F 9A 01 81 EB 27 82 25 FF B7 7D 75 4B 74 39 7F 76 16 C9 B4 70 70 B1 48 AD 6D E1 13 64 FE 6B E4 64 82 24 64 23 64 4D 60 3B 40 5C 7C 28 5C 9B 5A 74 F8 4E F7 D3 53 77 55 43 2E 61 2C 4B 82 49 A8 0C DB 20 1A A1 40 45 D8 33 7E 3D DF 3B EE 96 A3 AC 2E C8 24 1B DF A6 28 DA 3C 8E 72 49 BE 8D CE 27 46 77 A6 23 04 0C 28 4F 14 85 08 BB 1A 7A 19 7C 5F A8 4E 93 A3 35 11 83 7B 15 CC D3 65 89 5A 87 B7 05 69 4A 02 49 49 FA BE B7 D6 FB A8 FB EC 90 76 27 BF 1E 57 B5 3E 8B EE ED CA EE E6 89 C4 87 C5 8C 72 66 E3 75 56 FB 5A F8 D5 BA 93 9B 80 45 B0 28 B3 95 72 A5 68 CF 5A B1 71 08 C7 69 7C FE 54 DC C8 F3 EB 00 5A FC A6 FD D5 04 BC F5 0A 53 A4 1B 2D B1 D2 9D F9 62 9F A1 0C 1F 8F AA 24 82 DF 23 1D 1B 26 F0 FC 5C B6 33 81 9B 9A D1 99 77 9A 49 D7 4E 55 95 90 37 4A 94 58 6A E8 6F 8A E7 D4 D9 B9 A3 82 49 80 BC 66 75 E6 DA 74 2B 33 1A 10 4F 44 F3 C3 B1 88 9D E9 16 2C 82 1A 79 40 66 2A 63 AC 5A DD BF 96 1F 1B 33 AA 80 BC 47 38 55 C2 A3 37 D3 E3 75 9D 67 5A BA 4C D8 6E E0 F1 32 26 66 21 5B 4E 21 DC 19 B1 FE A8 22 15 4A 96 39 4A E6 37 96 1F 28 51 66 68 75 BE 3A BC 6D AC 92 EA 4B FB C1 2C 71 FA 8D 2E 57 4E FD 0A 5F 51 15 5A 53 06 73 40 53 24 3C 0F 81 4C 62 41 63 6E 3D B6 2A 1D 63 7E BA CD 7D 79 36 BC 12 8A FD D0 F6 EE F2 3C 8D C8 9C 63 D7 ED 6D 38 82 EA A1 E1 B4 AA 31 78 CA EC 14 28 B8 B8 C0 12 64 8F 59 0A D1 C7 B4 55 0B CE EA E0 4F 7F 4D 39 4B BD 78 A7 49 C7 49 84 AA 89 03 E8 F6 73 0C 23 6E 28 03 34 B4 90 90 E0 C0 BE B1 B1 E5 F5 BF CC F9 25 A9 3B 35 A2 95 2A 87 22 10 84 9E 12 E8 E6 A8 96 99 9A 03 20 31 75 9F C2 4B 0C B5 9E 95 8F A3 EA BB 88 FA 5F A8 94 C5 01 3D E7 B2 E5 09 20 38 0E 39 F9 DF 73 75 D4 C2 F9 72 72 79 6E C5 67 6B AA 14 69 67 FE 4A 64 63 C4 64 60 7F E3 5D 5C 93 4C 59 58 96 54 55 94 09 52 51 98 44 4E 4D 2A 4A 4A 09 4A 22 09 B3 04 26 C6 46 74 BE 6C 7D 4B FA 44 33 A7 B5 31 A1 C8 E2 32 1A 7E 00 0E 76 2A 2A 3A E9 2E 0F 21 EF AC A2 3E C1 33 31 5E 5D 05 DB 1F 8D 19 D1 56 0C B4 18 86 10 D6 4F 1F AD 07 9F 0A CF 48 1E F6 44 BE 23 02 84 03 E9 AE FD 14 E5 F6 59 8C 36 B2 49 94 F1 F7 F2 56 92 DE BA DE BB E8 69 E8 A2 E5 ED 74 E4 0A E3 85 1F D9 DA F4 DC 90 58 DA 77 6E D5 BD C3 DC 27 83 EF 9E 21 87 CD 00 1B 53 EB D3 ED DD F3 CD D8 50 B8 CE 50 45 7B 9D BC 72 36 94 15 54 33 B0 B4 70 A8 A4 24 BD F5 B0 79 A8 ED A7 0B 41 91 93 FD 00 83 B6 BF 9A CF 1A 6B D1 CA 2E EE AC BD C2 B3 D8 D0 CE 54 CE 83 72 8B C1 FC EE 8E 30 1F 83 FD 01 4D DE 71 54 15 34 55 C8 2A 44 D7 76 61 72 76 BA EF 06 4C FC 6B 4E 39 6E 03 73 F5 64 0F 6A 45 30 BF 58 6E 5F 82 CA 5A 7D A2 4C A5 51 99 52 EE 41 5B AE 48 86 1D 5A E9 F0 47 46 A1 45 C3 68 67 42 D1 1F FD 01 3F 82 BE 38 77 C6 25 54 36 00 30 F0 50 26 7D 2C BF 9D A0 37 7F 6C 27 D2 B9 A9 40 89 6B 10 F5 1A 86 77 31 20 85 B2 FD 78 99 76 D9 C9 0A 0D F4 A3 0F 4C 78 80 D7 ED 14 28 C6 46 D4 69 17 E2 95 56 B5 69 6B 68 F2 E0 DD E2 6B EA D0 F6 ED E2 15 F4 AF AE A5 EC 23 C0 A7 17 60 ED 01 50 DF 85 1D D0 5B DD 99 D9 F4 16 CD 3C D2 7A 91 D5 5F C8 49 4D B3 0A 55 D0 47 C7 75 C4 85 C8 89 C0 A3 7E A3 31 BD DE B8 98 37 A9 3D C3 A0 F6 84 79 3B AB AD 5D 65 9F F9 F5 C7 26 45 A6 A3 72 F9 66 79 9C 0C 77 12 AA 19 EA 8A BE 02 15 E1 9C C1 9E E4 B3 9D 80 2B 56 D5 F1 5D 04 80 BE D3 2C 83 65 B3 7B 64 1F 7A 1A D5 EF 56 B9 1A 54 46 F2 6F 4A 3F 10 FA AE 6B A0 68 EB 62 7B 8D 61 C3 21 3F 69 79 0E D3 5E CF 99 01 D8 C3 A7 45 64 D2 20 87 6E EB 4F A8 CC 97 80 CB 05 40 8C C4 C4 D2 EF CE 6B 5F 10 3D B0 EB D6 B6 DC 9C 37 AC C9 BF BD FD 57 A8 AB 33 D6 C5 B4 39 31 4F 46 89 74 8F 23 78 BF 34 9E 04 D4 40 01 3D 2A 47 1C 7B 16 01 93 4D 2E 84 37 2B C4 32 04 6A 37 00 A4 94 6B CC 49 07 0A 2F B2 70 9E FB FB B9 F8 A7 F8 11 BB 42 74 F7 64 EC 0B AD F2 BB EC 8D AA B1 92 CD 76 CA FB 71 F5 1C DE EB 01 9B DF 93 D9 F7 A4 DA DA D3 2A BD 6C DD BE B7 FA 95 6A CD E0 C4 68 48 D3 7B F4 1F D6 BB 06 8B 62 BD 6C 7B B9 60 70 2E F3 B6 0A 87 6E A9 AA 9D 85 CB 59 BB 10 91 78 9B B2 DB C6 42 A5 23 1E EF 3C 97 B2 99 6A 17 B0 C5 88 91 96 35 BE CF 15 77 8D 9B 2A 85 E0 0D 86 85 90 8C 4A 41 69 7C 27 2F 26 49 2A E9 5D 76 D3 37 3D C4 5A 72 35 3E AC 6F 65 FF 4E 40 EA 50 26 8C 7A 65 76 E6 4F DF 7C FD 9C AA 50 71 03 3C 7B 05 46 ED 08 7A 3C 35 6A DD D8 5D 55 06 61 0E 06 4C 14 A3 3E F3 4B D3 BB 87 AB 86 F8 83 3D 30 3C 0E 3D 48 99 FF 30 5F 25 23 38 1F 89 AA DA 42 FE 25 46 A0 3F 21 23 4D 9F 6F 3C 0C 32 19 92 1C 16 95 21 41 7E 86 2F 09 26 09 4C 8B D8 8E E2 47 4F 03 04 53 08 01 1D BF 0D BC BC E5 96 BE B0 F0 1A D5 73 38 CB 70 ED 7F 04 19 EE 6C 38 E0 CA B7 60 57 D0 E6 F1 DB E1 C6 DB DD FC D4 DA F3 49 DE D6 7D 98 0E 12 EC D4 B7 BA 05 0C 7B 6B 49 B0 7A 3F DB 59 36 45 41 B2 0B 21 30 2C A3 9B A8 04 34 BB 21 B4 56 F2 79 B2 AB 0E 83 AC 2B A9 C1 05 6C 15 97 0D 58 B1 99 76 0A 43 7B 82 B0 A7 B9 23 29 BB 05 ED 83 52 91 85 9C D8 A5 7C 6A 1F EC 8B C2 8D 89 AC 78 85 81 82 57 3D 75 E8 78 B3 39 81 7F ED 74 74 97 FC A5 5C AB 0F 8B 30 FE AB 37 E7 71 4E 62 2E E3 36 3D DD 1E 5A 0F 16 A9 1B 5D 4A 41 56 D5 3C 52 D3 E8 50 4F 5E A1 4A 49 22 66 48 47 4B 65 EB C2 42 65 56 3F 1E 3D 4E 20 32 39 DB 27 36 0C 39 37 A2 80 30 2C 22 28 28 C5 28 25 50 27 FF 28 20 87 27 39 6C 3F B5 9C 1C 97 0C 79 D8 1F 9E 7B 34 13 F8 14 08 85 DB 4D 0C 4E 71 29 98 00 42 30 14 47 BF 28 1C 7A 7B 50 15 FD B7 3B 5A 56 1D C1 77 30 26 C5 50 F3 2E EC 50 EA C7 C8 F0 EC AE DE 85 D3 97 AC D2 CB B6 E7 D7 49 7B A9 4C 1B 44 E9 C6 B3 93 15 06 E7 05 F5 C6 BF 89 8B 9D D2 8E 8D 42 DB C8 E5 5D 01 10 AF A8 11 90 F8 E5 B4 89 AD 3E FA D7 91 A9 6D 90 BF 27 02 E1 83 7A 29 CA E2 A1 6A 30 D1 C8 AB BA 55 9D 8A B0 83 8A 73 62 BC 23 EC B1 2A BE E3 1B AB A5 21 AC FA CC E1 EA 21 0E 2F 52 30 B1 AF 6D 55 34 FD 60 3D 68 C9 16 2D 64 0A 2B 65 7E 87 44 FE CE 72 D2 F6 20 27 70 79 C4 B7 64 35 E1 45 5F 45 DC 62 9A 90 99 56 06 E5 85 53 0C F1 4C 29 3B B7 8E 0B B5 09 10 56 D6 45 42 71 01 C8 4D 3C 3F E5 96 39 71 EA 78 00 43 2F 64 0D C7 E7 D8 36 14 21 AC 2B 3B 69 91 22 A2 AC 84 24 0C 2D 20 05 06 15 F7 99 5E 15 0E A5 E4 95 1F 10 12 1F 16 8F F3 F2 F3 0B 0A) */;

	private HighlightStateCfg.Ⴄ m_Ⴅ = new HighlightStateCfg.Ⴄ();

	public SkimmerSpotRateGraph(ArcClientObjMgr om)
	{
		Ⴄ();
		this.m_Ⴅ.Ⴓ = om as ArcClientObjMgr;
		Ⴗ = this.m_Ⴅ.Ⴓ.Caches.Dx.DxSpotRates;
	}

	private void Ⴐ(object P_0, EventArgs P_1)
	{
		CreateChart(Ⴓ);
	}

	public void CreateChart(ZedGraphControl zgc)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 11;
		object obj = default(object);
		Array array = default(Array);
		int num2 = default(int);
		CurveItem curveItem = default(CurveItem);
		while (true)
		{
			switch (num)
			{
			default:
				obj = HighlightCountyCfg.Ⴓ(zgc, 769, 790);
				AnnFilters.Ⴀ(TelnetServerCfg.Ⴓ((PaneBase)(obj as GraphPane), (short)524, 567), ClientCty.Ⴗ('/', 1, 307011843), 572, 'ɰ');
				num = ⴄ[205] - 14645;
				break;
			case 2:
				AnnFilters.Ⴀ((ZedGraph.Label)TelnetServerCfg.Ⴍ((Axis)ႥႠ.Ⴃ((GraphPane)obj, 378, 364), (short)976, (short)971), ClientCty.Ⴗ('U', 7, 307013135), 96, ',');
				goto case 5;
			case 5:
				num = ⴗ[103] - 55674;
				break;
			case 17:
				AnnFilters.Ⴀ((ZedGraph.Label)TelnetServerCfg.Ⴍ((Axis)WxFilters.ႭႠ(obj as GraphPane, 220, 253), (short)379, (short)352), ClientCty.Ⴗ('\u0013', 2, 307013180), 490, 'Ʀ');
				num = 12;
				break;
			case 12:
				array = new double[30];
				num2 = 0;
				num = 14;
				break;
			case 7:
				((double[])array)[num2] = -30 + num2;
				num2++;
				num = 14;
				break;
			case 14:
				num = ((num2 < 30) ? 7 : 16);
				break;
			case 16:
				ShowUsers.Ⴃ(ႳႥ.ႥႣ(obj as GraphPane, 333, 360), new Fill(UserInfo.Ⴅ(255, 255, 245, 581, 603), UserInfo.Ⴅ(255, 255, 190, 259, 285), 90f), 423, 466);
				goto case 6;
			case 6:
				num = ⴗ[60] - 41544;
				break;
			case 19:
				curveItem = ClientCty.Ⴄ((GraphPane)obj, WxFilters.Ⴀ(null, 5, 103387757), array as double[], Ⴗ.SkimCount, HighlightItuZoneCfg.ႳႷ(255, 156), 854, '\u0330');
				num = 3;
				break;
			case 3:
				ႥႭ.ႳႳ(HighlightCountyCfg.Ⴅ(curveItem as LineItem, 420, 413), new Fill(ClientCfg.Ⴍ(68, 40)), '\u0329', 807);
				num = ⴅ[5] / 7;
				break;
			case 9:
			case 18:
				curveItem = ClientCty.Ⴄ(obj as GraphPane, WxFilters.Ⴀ(null, 1, 103388634), (double[])array, Ⴗ.Unique2, DxEmailCfg.Ⴍ(783, 889), 67, '%');
				num = 13;
				break;
			case 13:
				ႥႭ.ႳႳ(HighlightCountyCfg.Ⴅ(curveItem as LineItem, 363, 338), new Fill(ClientCfg.Ⴍ(771, 879)), '\u0335', 827);
				num = ⴗ[156] - 48826;
				break;
			case 4:
				curveItem = (obj as GraphPane).AddCurve(ClientCty.Ⴗ(']', 2, 307011885), (double[])array, Ⴗ.Unique3, Color.Blue);
				num = 15;
				break;
			case 15:
				(curveItem as LineItem).Symbol.Fill = new Fill(Color.White);
				curveItem = (obj as GraphPane).AddCurve(ႥႥ.Ⴅ(1673507615, null, 6), (double[])array, Ⴗ.Unique4, Color.DarkGreen);
				num = ⴅ[102];
				break;
			case 10:
				((LineItem)curveItem).Symbol.Fill = new Fill(Color.White);
				curveItem = ((GraphPane)obj).AddCurve(ႥႥ.Ⴍ(7, 1580608490, 'Ð', null), (double[])array, Ⴗ.NotSkimDupe, Color.Black);
				num = ⴗ[161] - 4991;
				break;
			case 8:
				((LineItem)curveItem).Symbol.Fill = new Fill(Color.White);
				((GraphPane)obj).XAxis.Scale.Min = -30.0;
				num = ⴄ[119] - 8996;
				break;
			case 1:
				((GraphPane)obj).XAxis.Scale.Max = 0.0;
				(obj as GraphPane).YAxis.MajorGrid.IsVisible = true;
				num = 0;
				break;
			case 0:
				(obj as GraphPane).YAxis.MinorGrid.IsVisible = true;
				zgc.AxisChange();
				return;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				num = (disposing ? 1 : 6);
				continue;
			case 1:
				num = ((Ⴃ == null) ? (ⴀႠ[9] - 28061) : 0);
				continue;
			case 0:
			case 4:
				Ⴃ.Dispose();
				break;
			case 6:
				break;
			case 2:
				return;
			}
			break;
		}
		base.Dispose(disposing);
	}

	private void Ⴄ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 12;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴓ = new ZedGraphControl();
				AnnFilters.Ⴓ((Control)this, 'ɷ', 'ɨ');
				MultimediaCache.Ⴄ((Control)Ⴓ, DockStyle.Fill, 972, (short)1009);
				num = ⴅ[17];
				break;
			case 0:
				HighlightCountyCfg.Ⴜ((Control)Ⴓ, new Point(0, 0), 982, 901);
				ႥႤ.Ⴀ((Control)Ⴓ, ႥႥ.Ⴅ(1673508439, null, 3), 'Ϥ', 'Ή');
				num = ⴄ[10] - 7008;
				break;
			case 11:
				Ⴜ(Ⴓ, 0.0, 628, 'ɉ');
				Ⴜ(Ⴓ, 0.0, 339, 'ŭ');
				num = 6;
				break;
			case 6:
				DxSpotRates.ႠႷ(Ⴓ, 0.0, 187, 252);
				DxSpotRates.ႠႷ(Ⴓ, 0.0, 722, 666);
				num = ⴗ[21] - 63702;
				break;
			case 1:
			case 7:
				DxSpotRates.ႠႷ(Ⴓ, 0.0, 332, 261);
				ႥႥ.ႤႣ(Ⴓ, 0.0, 316, 369);
				num = 10;
				break;
			case 10:
				ႥႥ.ႤႣ(Ⴓ, 0.0, 985, 919);
				ArcClientConnectDat.Ⴄ((Control)Ⴓ, new Size(688, 442), 'Ά', 987);
				num = 3;
				break;
			case 3:
				DxEmailCfg.Ⴈ((Control)Ⴓ, 0, (short)686, 'ʟ');
				ArcClientConnectDat.Ⴅ((ContainerControl)this, new SizeF(6f, 13f), 656, (short)641);
				num = 4;
				break;
			case 4:
				base.AutoScaleMode = AutoScaleMode.Font;
				base.ClientSize = new Size(688, 442);
				goto case 5;
			case 5:
			case 9:
				base.Controls.Add(Ⴓ);
				num = ⴗ[137] - 1362;
				break;
			case 8:
				base.Name = ClientCty.Ⴗ('7', 6, 307013188);
				base.StartPosition = FormStartPosition.CenterParent;
				num = 13;
				break;
			case 13:
				Text = ClientCty.Ⴗ(' ', 8, 307013240);
				base.Load += Ⴐ;
				num = 2;
				break;
			case 2:
				ResumeLayout(performLayout: false);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static SkimmerSpotRateGraph()
	{
		ArcClientConnectDat.Ⴍ();
	}

	internal static Assembly Ⴍ(object P_0, ResolveEventArgs P_1)
	{
		return (Assembly)Ⴅ(null, "ac58648c-295b-4318-8d10-1f8ef0fa51af", 112, 11L, P_1, null, 2867);
	}

	internal static object Ⴅ(SkimmerSpotRateGraph P_0, string P_1, int P_2, long P_3, object P_4, SkimmerSpotRateGraph P_5, int P_6)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		EventArgs e = default(EventArgs);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		object obj3 = default(object);
		object obj2 = default(object);
		object obj = default(object);
		int num2 = default(int);
		object obj4 = default(object);
		object obj6 = default(object);
		int num4 = default(int);
		ICustomAttributeProvider customAttributeProvider = default(ICustomAttributeProvider);
		object obj7 = default(object);
		int num8 = default(int);
		IEnumerable enumerable2 = default(IEnumerable);
		while (P_6 > 0)
		{
			int num = ⴀႠ[63] - 29186;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄ[187] - 15454;
					continue;
				case 15:
				case 16:
					break;
				case 14:
				{
					ISerializable serializable = ႥႠ.ႭႣ(478, 'ǀ');
					e = (ResolveEventArgs)P_4;
					num = ((!ShowUsers.ႥႥ(DxFilters.Ⴓ((ResolveEventArgs)e, 'ʱ', '\u02fc'), (Assembly)serializable, 'É', 183)) ? 5 : 6);
					continue;
				}
				case 6:
					return null;
				case 5:
					enumerable = ClientCfg.ႭႠ(P_1, ClientCty.Ⴗ('«', 3, 307011879), 478, 'ǭ');
					goto case 4;
				case 4:
					num = 1;
					continue;
				case 1:
					obj3 = FilterEditor.ႣႠ('ɽ', 'Ȇ');
					obj2 = (Dictionary<string, string>)HighlightCfg.ႳႤ(obj3 as AppDomain, P_1, 'ɂ', 535);
					num = ⴄ[66] - 59665;
					continue;
				case 11:
					goto IL_0151;
				case 3:
					obj2 = new Dictionary<string, string>();
					ႥႠ.ႭႥ((AppDomain)obj3, P_1, (object)(obj2 as Dictionary<string, string>), 900, 946);
					num = 0;
					continue;
				case 0:
					obj = new byte[2867]
					{
						47, 121, 194, 166, 219, 129, 95, 239, 237, 227,
						160, 4, 180, 175, 155, 39, 153, 3, 53, 162,
						118, 208, 89, 186, 200, 248, 5, 78, 159, 240,
						13, 35, 107, 41, 3, 116, 11, 245, 128, 173,
						200, 197, 70, 196, 110, 58, 148, 164, 150, 169,
						147, 224, 183, 52, 20, 103, 71, 11, 35, 133,
						16, 189, 246, 220, 120, 235, 184, 241, 189, 51,
						148, 68, 44, 251, 210, 241, 48, 76, 119, 118,
						18, 120, 227, 216, 93, 194, 208, 132, 58, 156,
						183, 214, 0, 31, 95, 94, 60, 27, 7, 152,
						223, 129, 22, 195, 252, 212, 152, 81, 162, 111,
						210, 229, 203, 65, 221, 201, 200, 207, 198, 199,
						80, 192, 39, 65, 232, 239, 96, 141, 172, 237,
						122, 113, 122, 55, 89, 183, 180, 123, 180, 19,
						177, 206, 142, 182, 132, 172, 142, 40, 187, 199,
						166, 7, 164, 242, 2, 173, 166, 95, 158, 217,
						221, 253, 114, 43, 221, 194, 194, 225, 81, 55,
						201, 189, 3, 201, 221, 168, 7, 230, 210, 131,
						13, 225, 111, 177, 143, 149, 234, 209, 172, 197,
						180, 73, 68, 59, 116, 233, 27, 116, 231, 128,
						104, 105, 100, 33, 126, 251, 173, 109, 166, 235,
						56, 201, 116, 167, 97, 103, 101, 57, 202, 152,
						113, 223, 85, 201, 95, 254, 26, 77, 200, 80,
						194, 84, 173, 19, 107, 1, 30, 245, 206, 78,
						233, 70, 108, 78, 174, 69, 42, 32, 173, 3,
						26, 66, 65, 171, 200, 28, 187, 8, 10, 153,
						36, 199, 187, 37, 55, 22, 114, 8, 32, 41,
						86, 45, 201, 107, 19, 185, 17, 39, 170, 229,
						54, 211, 163, 32, 242, 10, 30, 87, 20, 147,
						10, 31, 228, 150, 100, 181, 8, 219, 55, 26,
						18, 32, 98, 12, 233, 75, 51, 153, 23, 5,
						0, 225, 43, 35, 34, 8, 1, 30, 182, 251,
						184, 146, 123, 232, 248, 74, 96, 225, 132, 217,
						49, 250, 254, 15, 33, 188, 224, 166, 143, 60,
						25, 103, 153, 172, 226, 74, 197, 240, 232, 220,
						20, 92, 174, 3, 196, 1, 144, 87, 87, 153,
						76, 222, 222, 245, 144, 54, 113, 205, 137, 139,
						243, 89, 112, 168, 199, 155, 100, 39, 137, 173,
						216, 37, 187, 41, 191, 94, 186, 146, 168, 82,
						54, 125, 189, 176, 32, 186, 176, 47, 176, 205,
						170, 75, 170, 215, 8, 203, 39, 164, 146, 168,
						162, 172, 170, 21, 178, 132, 232, 149, 206, 218,
						206, 190, 156, 94, 4, 128, 2, 193, 157, 28,
						231, 165, 208, 0, 164, 58, 220, 194, 85, 92,
						216, 136, 90, 141, 197, 169, 43, 103, 228, 127,
						102, 155, 123, 191, 195, 197, 93, 233, 54, 32,
						124, 95, 7, 107, 41, 57, 38, 228, 3, 38,
						197, 213, 81, 254, 103, 229, 122, 119, 206, 8,
						20, 93, 87, 21, 110, 43, 174, 115, 86, 69,
						80, 225, 216, 175, 111, 105, 124, 195, 187, 168,
						73, 192, 6, 9, 78, 14, 144, 168, 6, 57,
						33, 183, 29, 62, 241, 184, 190, 52, 221, 53,
						200, 2, 118, 7, 48, 215, 33, 44, 230, 33,
						42, 169, 119, 110, 38, 180, 106, 64, 136, 137,
						18, 24, 184, 183, 204, 126, 20, 63, 197, 83,
						33, 117, 252, 161, 22, 84, 66, 3, 157, 243,
						239, 151, 24, 72, 246, 132, 108, 148, 68, 25,
						194, 10, 132, 255, 152, 34, 224, 243, 13, 161,
						216, 233, 38, 247, 198, 202, 178, 200, 214, 191,
						160, 234, 38, 166, 74, 245, 245, 207, 209, 83,
						191, 198, 66, 189, 185, 191, 56, 95, 161, 195,
						210, 66, 155, 215, 70, 80, 85, 97, 211, 181,
						55, 42, 50, 200, 221, 251, 39, 180, 136, 22,
						67, 195, 190, 139, 158, 44, 165, 190, 123, 13,
						240, 114, 190, 179, 56, 101, 233, 190, 40, 172,
						177, 145, 91, 175, 173, 28, 236, 85, 220, 146,
						64, 247, 198, 239, 228, 186, 132, 241, 166, 156,
						182, 152, 86, 27, 168, 57, 140, 191, 149, 95,
						21, 161, 50, 41, 144, 143, 234, 187, 140, 11,
						232, 137, 140, 175, 133, 203, 36, 143, 170, 134,
						114, 126, 110, 221, 112, 77, 42, 127, 66, 39,
						112, 99, 36, 117, 102, 114, 245, 47, 151, 108,
						110, 33, 235, 27, 200, 235, 114, 77, 101, 169,
						227, 83, 64, 51, 95, 93, 56, 117, 90, 217,
						234, 194, 82, 177, 123, 155, 18, 96, 192, 71,
						218, 78, 41, 203, 165, 203, 64, 191, 68, 96,
						4, 122, 18, 75, 184, 61, 91, 62, 48, 19,
						33, 89, 120, 238, 52, 55, 160, 49, 215, 113,
						57, 239, 149, 109, 44, 151, 106, 48, 104, 47,
						178, 56, 60, 35, 41, 181, 33, 211, 94, 4,
						188, 165, 218, 9, 26, 82, 29, 21, 180, 63,
						19, 17, 56, 74, 182, 31, 141, 111, 170, 5,
						32, 0, 76, 133, 220, 6, 2, 185, 11, 255,
						58, 246, 252, 171, 237, 249, 88, 216, 246, 149,
						219, 243, 18, 60, 179, 143, 232, 39, 154, 216,
						170, 192, 92, 228, 226, 113, 229, 181, 233, 225,
						96, 163, 223, 221, 92, 219, 191, 217, 250, 135,
						208, 229, 250, 227, 82, 172, 209, 202, 46, 195,
						234, 155, 192, 105, 229, 135, 70, 232, 148, 197,
						106, 193, 165, 63, 188, 237, 198, 43, 170, 87,
						113, 175, 189, 181, 116, 215, 179, 177, 128, 129,
						118, 166, 100, 46, 246, 8, 152, 161, 134, 101,
						192, 163, 184, 49, 33, 173, 158, 153, 180, 246,
						211, 129, 216, 78, 220, 146, 222, 156, 144, 87,
						16, 15, 191, 173, 236, 135, 130, 246, 132, 31,
						154, 1, 129, 235, 39, 130, 37, 255, 183, 125,
						117, 75, 116, 57, 127, 118, 22, 201, 180, 112,
						112, 177, 72, 173, 109, 225, 19, 100, 254, 107,
						228, 100, 130, 36, 100, 35, 100, 77, 96, 59,
						64, 92, 124, 40, 92, 155, 90, 116, 248, 78,
						247, 211, 83, 119, 85, 67, 46, 97, 44, 75,
						130, 73, 168, 12, 219, 32, 26, 161, 64, 69,
						216, 51, 126, 61, 223, 59, 238, 150, 163, 172,
						46, 200, 36, 27, 223, 166, 40, 218, 60, 142,
						114, 73, 190, 141, 206, 39, 70, 119, 166, 35,
						4, 12, 40, 79, 20, 133, 8, 187, 26, 122,
						25, 124, 95, 168, 78, 147, 163, 53, 17, 131,
						123, 21, 204, 211, 101, 137, 90, 135, 183, 5,
						105, 74, 2, 73, 73, 250, 190, 183, 214, 251,
						168, 251, 236, 144, 118, 39, 191, 30, 87, 181,
						62, 139, 238, 237, 202, 238, 230, 137, 196, 135,
						197, 140, 114, 102, 227, 117, 86, 251, 90, 248,
						213, 186, 147, 155, 128, 69, 176, 40, 179, 149,
						114, 165, 104, 207, 90, 177, 113, 8, 199, 105,
						124, 254, 84, 220, 200, 243, 235, 0, 90, 252,
						166, 253, 213, 4, 188, 245, 10, 83, 164, 27,
						45, 177, 210, 157, 249, 98, 159, 161, 12, 31,
						143, 170, 36, 130, 223, 35, 29, 27, 38, 240,
						252, 92, 182, 51, 129, 155, 154, 209, 153, 119,
						154, 73, 215, 78, 85, 149, 144, 55, 74, 148,
						88, 106, 232, 111, 138, 231, 212, 217, 185, 163,
						130, 73, 128, 188, 102, 117, 230, 218, 116, 43,
						51, 26, 16, 79, 68, 243, 195, 177, 136, 157,
						233, 22, 44, 130, 26, 121, 64, 102, 42, 99,
						172, 90, 221, 191, 150, 31, 27, 51, 170, 128,
						188, 71, 56, 85, 194, 163, 55, 211, 227, 117,
						157, 103, 90, 186, 76, 216, 110, 224, 241, 50,
						38, 102, 33, 91, 78, 33, 220, 25, 177, 254,
						168, 34, 21, 74, 150, 57, 74, 230, 55, 150,
						31, 40, 81, 102, 104, 117, 190, 58, 188, 109,
						172, 146, 234, 75, 251, 193, 44, 113, 250, 141,
						46, 87, 78, 253, 10, 95, 81, 21, 90, 83,
						6, 115, 64, 83, 36, 60, 15, 129, 76, 98,
						65, 99, 110, 61, 182, 42, 29, 99, 126, 186,
						205, 125, 121, 54, 188, 18, 138, 253, 208, 246,
						238, 242, 60, 141, 200, 156, 99, 215, 237, 109,
						56, 130, 234, 161, 225, 180, 170, 49, 120, 202,
						236, 20, 40, 184, 184, 192, 18, 100, 143, 89,
						10, 209, 199, 180, 85, 11, 206, 234, 224, 79,
						127, 77, 57, 75, 189, 120, 167, 73, 199, 73,
						132, 170, 137, 3, 232, 246, 115, 12, 35, 110,
						40, 3, 52, 180, 144, 144, 224, 192, 190, 177,
						177, 229, 245, 191, 204, 249, 37, 169, 59, 53,
						162, 149, 42, 135, 34, 16, 132, 158, 18, 232,
						230, 168, 150, 153, 154, 3, 32, 49, 117, 159,
						194, 75, 12, 181, 158, 149, 143, 163, 234, 187,
						136, 250, 95, 168, 148, 197, 1, 61, 231, 178,
						229, 9, 32, 56, 14, 57, 249, 223, 115, 117,
						212, 194, 249, 114, 114, 121, 110, 197, 103, 107,
						170, 20, 105, 103, 254, 74, 100, 99, 196, 100,
						96, 127, 227, 93, 92, 147, 76, 89, 88, 150,
						84, 85, 148, 9, 82, 81, 152, 68, 78, 77,
						42, 74, 74, 9, 74, 34, 9, 179, 4, 38,
						198, 70, 116, 190, 108, 125, 75, 250, 68, 51,
						167, 181, 49, 161, 200, 226, 50, 26, 126, 0,
						14, 118, 42, 42, 58, 233, 46, 15, 33, 239,
						172, 162, 62, 193, 51, 49, 94, 93, 5, 219,
						31, 141, 25, 209, 86, 12, 180, 24, 134, 16,
						214, 79, 31, 173, 7, 159, 10, 207, 72, 30,
						246, 68, 190, 35, 2, 132, 3, 233, 174, 253,
						20, 229, 246, 89, 140, 54, 178, 73, 148, 241,
						247, 242, 86, 146, 222, 186, 222, 187, 232, 105,
						232, 162, 229, 237, 116, 228, 10, 227, 133, 31,
						217, 218, 244, 220, 144, 88, 218, 119, 110, 213,
						189, 195, 220, 39, 131, 239, 158, 33, 135, 205,
						0, 27, 83, 235, 211, 237, 221, 243, 205, 216,
						80, 184, 206, 80, 69, 123, 157, 188, 114, 54,
						148, 21, 84, 51, 176, 180, 112, 168, 164, 36,
						189, 245, 176, 121, 168, 237, 167, 11, 65, 145,
						147, 253, 0, 131, 182, 191, 154, 207, 26, 107,
						209, 202, 46, 238, 172, 189, 194, 179, 216, 208,
						206, 84, 206, 131, 114, 139, 193, 252, 238, 142,
						48, 31, 131, 253, 1, 77, 222, 113, 84, 21,
						52, 85, 200, 42, 68, 215, 118, 97, 114, 118,
						186, 239, 6, 76, 252, 107, 78, 57, 110, 3,
						115, 245, 100, 15, 106, 69, 48, 191, 88, 110,
						95, 130, 202, 90, 125, 162, 76, 165, 81, 153,
						82, 238, 65, 91, 174, 72, 134, 29, 90, 233,
						240, 71, 70, 161, 69, 195, 104, 103, 66, 209,
						31, 253, 1, 63, 130, 190, 56, 119, 198, 37,
						84, 54, 0, 48, 240, 80, 38, 125, 44, 191,
						157, 160, 55, 127, 108, 39, 210, 185, 169, 64,
						137, 107, 16, 245, 26, 134, 119, 49, 32, 133,
						178, 253, 120, 153, 118, 217, 201, 10, 13, 244,
						163, 15, 76, 120, 128, 215, 237, 20, 40, 198,
						70, 212, 105, 23, 226, 149, 86, 181, 105, 107,
						104, 242, 224, 221, 226, 107, 234, 208, 246, 237,
						226, 21, 244, 175, 174, 165, 236, 35, 192, 167,
						23, 96, 237, 1, 80, 223, 133, 29, 208, 91,
						221, 153, 217, 244, 22, 205, 60, 210, 122, 145,
						213, 95, 200, 73, 77, 179, 10, 85, 208, 71,
						199, 117, 196, 133, 200, 137, 192, 163, 126, 163,
						49, 189, 222, 184, 152, 55, 169, 61, 195, 160,
						246, 132, 121, 59, 171, 173, 93, 101, 159, 249,
						245, 199, 38, 69, 166, 163, 114, 249, 102, 121,
						156, 12, 119, 18, 170, 25, 234, 138, 190, 2,
						21, 225, 156, 193, 158, 228, 179, 157, 128, 43,
						86, 213, 241, 93, 4, 128, 190, 211, 44, 131,
						101, 179, 123, 100, 31, 122, 26, 213, 239, 86,
						185, 26, 84, 70, 242, 111, 74, 63, 16, 250,
						174, 107, 160, 104, 235, 98, 123, 141, 97, 195,
						33, 63, 105, 121, 14, 211, 94, 207, 153, 1,
						216, 195, 167, 69, 100, 210, 32, 135, 110, 235,
						79, 168, 204, 151, 128, 203, 5, 64, 140, 196,
						196, 210, 239, 206, 107, 95, 16, 61, 176, 235,
						214, 182, 220, 156, 55, 172, 201, 191, 189, 253,
						87, 168, 171, 51, 214, 197, 180, 57, 49, 79,
						70, 137, 116, 143, 35, 120, 191, 52, 158, 4,
						212, 64, 1, 61, 42, 71, 28, 123, 22, 1,
						147, 77, 46, 132, 55, 43, 196, 50, 4, 106,
						55, 0, 164, 148, 107, 204, 73, 7, 10, 47,
						178, 112, 158, 251, 251, 185, 248, 167, 248, 17,
						187, 66, 116, 247, 100, 236, 11, 173, 242, 187,
						236, 141, 170, 177, 146, 205, 118, 202, 251, 113,
						245, 28, 222, 235, 1, 155, 223, 147, 217, 247,
						164, 218, 218, 211, 42, 189, 108, 221, 190, 183,
						250, 149, 106, 205, 224, 196, 104, 72, 211, 123,
						244, 31, 214, 187, 6, 139, 98, 189, 108, 123,
						185, 96, 112, 46, 243, 182, 10, 135, 110, 169,
						170, 157, 133, 203, 89, 187, 16, 145, 120, 155,
						178, 219, 198, 66, 165, 35, 30, 239, 60, 151,
						178, 153, 106, 23, 176, 197, 136, 145, 150, 53,
						190, 207, 21, 119, 141, 155, 42, 133, 224, 13,
						134, 133, 144, 140, 74, 65, 105, 124, 39, 47,
						38, 73, 42, 233, 93, 118, 211, 55, 61, 196,
						90, 114, 53, 62, 172, 111, 101, 255, 78, 64,
						234, 80, 38, 140, 122, 101, 118, 230, 79, 223,
						124, 253, 156, 170, 80, 113, 3, 60, 123, 5,
						70, 237, 8, 122, 60, 53, 106, 221, 216, 93,
						85, 6, 97, 14, 6, 76, 20, 163, 62, 243,
						75, 211, 187, 135, 171, 134, 248, 131, 61, 48,
						60, 14, 61, 72, 153, 255, 48, 95, 37, 35,
						56, 31, 137, 170, 218, 66, 254, 37, 70, 160,
						63, 33, 35, 77, 159, 111, 60, 12, 50, 25,
						146, 28, 22, 149, 33, 65, 126, 134, 47, 9,
						38, 9, 76, 139, 216, 142, 226, 71, 79, 3,
						4, 83, 8, 1, 29, 191, 13, 188, 188, 229,
						150, 190, 176, 240, 26, 213, 115, 56, 203, 112,
						237, 127, 4, 25, 238, 108, 56, 224, 202, 183,
						96, 87, 208, 230, 241, 219, 225, 198, 219, 221,
						252, 212, 218, 243, 73, 222, 214, 125, 152, 14,
						18, 236, 212, 183, 186, 5, 12, 123, 107, 73,
						176, 122, 63, 219, 89, 54, 69, 65, 178, 11,
						33, 48, 44, 163, 155, 168, 4, 52, 187, 33,
						180, 86, 242, 121, 178, 171, 14, 131, 172, 43,
						169, 193, 5, 108, 21, 151, 13, 88, 177, 153,
						118, 10, 67, 123, 130, 176, 167, 185, 35, 41,
						187, 5, 237, 131, 82, 145, 133, 156, 216, 165,
						124, 106, 31, 236, 139, 194, 141, 137, 172, 120,
						133, 129, 130, 87, 61, 117, 232, 120, 179, 57,
						129, 127, 237, 116, 116, 151, 252, 165, 92, 171,
						15, 139, 48, 254, 171, 55, 231, 113, 78, 98,
						46, 227, 54, 61, 221, 30, 90, 15, 22, 169,
						27, 93, 74, 65, 86, 213, 60, 82, 211, 232,
						80, 79, 94, 161, 74, 73, 34, 102, 72, 71,
						75, 101, 235, 194, 66, 101, 86, 63, 30, 61,
						78, 32, 50, 57, 219, 39, 54, 12, 57, 55,
						162, 128, 48, 44, 34, 40, 40, 197, 40, 37,
						80, 39, 255, 40, 32, 135, 39, 57, 108, 63,
						181, 156, 28, 151, 12, 121, 216, 31, 158, 123,
						52, 19, 248, 20, 8, 133, 219, 77, 12, 78,
						113, 41, 152, 0, 66, 48, 20, 71, 191, 40,
						28, 122, 123, 80, 21, 253, 183, 59, 90, 86,
						29, 193, 119, 48, 38, 197, 80, 243, 46, 236,
						80, 234, 199, 200, 240, 236, 174, 222, 133, 211,
						151, 172, 210, 203, 182, 231, 215, 73, 123, 169,
						76, 27, 68, 233, 198, 179, 147, 21, 6, 231,
						5, 245, 198, 191, 137, 139, 157, 210, 142, 141,
						66, 219, 200, 229, 93, 1, 16, 175, 168, 17,
						144, 248, 229, 180, 137, 173, 62, 250, 215, 145,
						169, 109, 144, 191, 39, 2, 225, 131, 122, 41,
						202, 226, 161, 106, 48, 209, 200, 171, 186, 85,
						157, 138, 176, 131, 138, 115, 98, 188, 35, 236,
						177, 42, 190, 227, 27, 171, 165, 33, 172, 250,
						204, 225, 234, 33, 14, 47, 82, 48, 177, 175,
						109, 85, 52, 253, 96, 61, 104, 201, 22, 45,
						100, 10, 43, 101, 126, 135, 68, 254, 206, 114,
						210, 246, 32, 39, 112, 121, 196, 183, 100, 53,
						225, 69, 95, 69, 220, 98, 154, 144, 153, 86,
						6, 229, 133, 83, 12, 241, 76, 41, 59, 183,
						142, 11, 181, 9, 16, 86, 214, 69, 66, 113,
						1, 200, 77, 60, 63, 229, 150, 57, 113, 234,
						120, 0, 67, 47, 100, 13, 199, 231, 216, 54,
						20, 33, 172, 43, 59, 105, 145, 34, 162, 172,
						132, 36, 12, 45, 32, 5, 6, 21, 247, 153,
						94, 21, 14, 165, 228, 149, 31, 16, 18, 31,
						22, 143, 243, 242, 243, 11, 10
					};
					num = 12;
					continue;
				case 12:
					num2 = P_6 - 1;
					num = 2;
					continue;
				case 10:
				case 13:
					((byte[])obj)[num2] ^= (byte)((num2 + P_6 - P_2) & 0xFF);
					num = ⴗ[52] - 21963;
					continue;
				case 7:
					num2--;
					num = 2;
					continue;
				case 2:
					num = ((num2 >= 0) ? 10 : 8);
					continue;
				case 8:
					goto IL_0226;
				}
				break;
				IL_0226:
				obj4 = new MemoryStream();
				object obj5 = new DeflateStream(new MemoryStream(obj as byte[]), CompressionMode.Decompress, leaveOpen: true);
				try
				{
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						default:
							obj6 = new byte[1024];
							goto case 3;
						case 3:
						case 4:
							num3 = ⴅ[17];
							continue;
						case 5:
							ႳႰ.ႭႣ(obj4 as Stream, obj6 as byte[], 0, num4, 334, 'Ĕ');
							break;
						case 0:
							break;
						case 6:
						case 7:
							goto end_IL_0245;
						}
						num3 = (((num4 = HighlightCountyCfg.ႷႼ(obj5 as Stream, obj6 as byte[], 0, ((byte[])obj6).Length, 557, 'ȭ')) > 0) ? 5 : 6);
						continue;
						end_IL_0245:
						break;
					}
				}
				finally
				{
					int num5 = 5;
					while (true)
					{
						int num6;
						switch (num5)
						{
						default:
							num6 = ((!(obj5 is Stream)) ? (ⴀႠ[44] - 48726) : 6);
							goto IL_030b;
						case 6:
							((IDisposable)(obj5 as Stream)).Dispose();
							break;
						case 2:
							break;
						}
						break;
						IL_030b:
						num5 = num6;
					}
				}
				int num7 = 14;
				goto IL_032d;
				IL_0466:
				customAttributeProvider = (Assembly)(obj3 as AppDomain).GetData(enumerable as string);
				num7 = ⴅ[93] - 146;
				goto IL_032d;
				IL_0151:
				if ((Dictionary<string, string>)obj2 == null)
				{
					num = ⴅ[390] - 191;
					continue;
				}
				goto IL_0466;
				IL_032d:
				while (true)
				{
					switch (num7)
					{
					default:
						customAttributeProvider = ႥႤ.Ⴜ(ႥႠ.ႭႼ((MemoryStream)(Stream)obj4, 'ϣ', 959), null, SecurityContextSource.CurrentAssembly, 'D', 'o');
						num7 = 5;
						continue;
					case 5:
						ႥႠ.ႭႥ(obj3 as AppDomain, enumerable as string, (object)(Assembly)customAttributeProvider, 171, 157);
						num7 = 9;
						continue;
					case 9:
						obj7 = DxCommentExtCfg.ႠႰ((Assembly)customAttributeProvider, 'Μ', 'ϸ');
						num8 = 0;
						num7 = ⴅ[96] - 203;
						continue;
					case 13:
						enumerable2 = (obj7 as string[])[num8];
						goto case 6;
					case 6:
						((Dictionary<string, string>)obj2)[(string)enumerable2] = (string)enumerable2;
						num7 = ⴀႠ[4] - 3450;
						continue;
					case 2:
						num8++;
						num7 = ⴅ[343] - 117;
						continue;
					case 3:
						num7 = ((num8 < ((string[])obj7).Length) ? 13 : 8);
						continue;
					case 8:
						num7 = 11;
						continue;
					case 0:
						break;
					case 1:
					case 11:
						num7 = ((!((Dictionary<string, string>)obj2).ContainsKey((e as ResolveEventArgs).Name)) ? ⴅ[115] : 10);
						continue;
					case 7:
					case 10:
						return customAttributeProvider as Assembly;
					case 4:
						goto end_IL_0081;
					}
					break;
				}
				goto IL_0466;
			}
			continue;
			end_IL_0081:
			break;
		}
		return null;
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210>(_0021_00210 P_0, double P_1, short P_2, char P_3) where _0021_00210 : ZedGraphControl
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴗ[28] - 37806;
				break;
			case 2:
				num = (((P_2 ^ P_3) - 61) ^ num2) switch
				{
					0 => 6, 
					1 => 5, 
					_ => ⴀႠ[103] - 38471, 
				};
				break;
			case 8:
				num = ⴄ[299] - 26001;
				break;
			case 6:
				P_0.ScrollGrace = P_1;
				num = 4;
				break;
			case 5:
				P_0.ScrollMaxX = P_1;
				goto case 4;
			case 4:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 9 : 0);
				break;
			case 0:
			case 10:
				num = 2;
				break;
			case 3:
			case 7:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႤႭ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : ImageList where _0021_00211 : ImageListStreamer
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 2;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄ[127] - 370;
				break;
			case 4:
				num = (((P_3 ^ P_2) - 82) ^ num2) switch
				{
					0 => 9, 
					_ => ⴀႠ[68] - 51740, 
				};
				break;
			case 7:
				num = 8;
				break;
			case 9:
				P_0.ImageStream = P_1;
				goto case 0;
			case 0:
			case 8:
				num2++;
				num3 = 238;
				goto case 5;
			case 5:
			{
				int num4 = 313;
				num = ((2817 > num4 - num3 * 9) ? 1 : 6);
				break;
			}
			case 6:
				num = 4;
				break;
			case 1:
				Bye.Ⴄ[103] = (char)((Bye.Ⴄ[103] + P_3) & 0xE4);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႤႤ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DataGridView
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[93] - 27759;
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
				case 5:
				case 6:
					num2 = (((P_2 ^ P_1) - 127) ^ num) switch
					{
						0 => 8, 
						_ => ⴅ[11] - 124, 
					};
					continue;
				case 7:
					result = 9;
					num2 = 11;
					continue;
				case 2:
				case 8:
					result = P_0.RowCount;
					num2 = 11;
					continue;
				case 11:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? ⴅ[115] : (ⴄ[151] - 41333));
					continue;
				case 3:
					num2 = 6;
					continue;
				case 4:
					return result;
				case 0:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႤႣ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : BaseCollection
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[273] - 10912;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[23] - 52197;
					continue;
				case 9:
					break;
				case 0:
					num2 = (((P_2 ^ P_1) - 67) ^ num) switch
					{
						0 => 1, 
						_ => 3, 
					};
					continue;
				case 3:
					result = P_2;
					num2 = ⴄ[205] - 14641;
					continue;
				case 1:
					result = P_0.Count;
					num2 = 6;
					continue;
				case 6:
				case 11:
				{
					num++;
					int num3 = 266;
					int num4 = 429;
					num2 = ((3861 > num4 - num3 * 9) ? 5 : (ⴄ[203] - 20729));
					continue;
				}
				case 4:
				case 8:
					num2 = 0;
					continue;
				case 2:
				case 5:
					return result;
				case 10:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႤႰ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : TcpClient where _0021_00211 : OnIoClientRxEventHandler
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 6;
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = ⴀႠ[115] - 48710;
				continue;
			case 7:
				num = (((P_2 ^ P_3) - 85) ^ num4) switch
				{
					0 => 1, 
					_ => ⴀႠ[108] - 45141, 
				};
				continue;
			case 2:
				num = ⴅ[115];
				continue;
			case 1:
				P_0.OnRxEvent += P_1;
				goto case 3;
			case 3:
			case 4:
				num4++;
				goto case 8;
			case 8:
			{
				num3 = 189;
				int num5 = num3;
				num2 = num5 * num5;
				num = ⴀႠ[99] - ⴀႠ[99];
				continue;
			}
			case 0:
				num2 = num3 + num2;
				break;
			case 9:
				break;
			case 5:
				return;
			}
			num = ((num2 % 2 != 0) ? 7 : 5);
		}
	}
}
