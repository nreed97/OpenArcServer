using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;

namespace Ⴃ;

internal sealed class ႣႼ
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2994)]
	private struct ႥႳ
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1878)]
	private struct ႥႼ
	{
	}

	private string m_Ⴃ;

	private ArcUserCfg.Ⴜ m_Ⴗ = new ArcUserCfg.Ⴜ();

	private static readonly object ႥႨ;

	private static readonly Array ႥႥ;

	private static readonly object ႥႰ;

	internal static ႥႳ ႥႷ/* Not supported: data(A4 66 A5 66 A4 66 8C 64 B4 09 B6 09 B5 09 57 39 81 04 99 AB 9A AB 9B AB 65 98 97 98 C6 87 ED E4 EC E4 EE E4 7E CE BC 78 AA 78 B8 78 45 6A 6A 52 3C 5F 14 48 C7 75 DE 4B FC 4B B3 54 42 6A 63 52 27 5F 3B 48 D6 75 F7 4B D0 4B AA 54 4F 6A 6A 52 1C 5F 0E 48 C9 75 DC 4B 76 68 39 68 73 68 13 5B 21 44 BF 7A 84 42 A2 4F D7 58 00 65 72 5B 21 5B 73 44 92 7A A9 42 ED 4F DC 58 0C 65 31 5B 3D 5B 40 44 D0 7A 97 42 C3 4F 92 58 50 65 63 5B 68 5B 26 44 DD 7A E8 42 A2 4F 8A 58 5D 65 6B 5B 69 5B 34 44 D4 7A A6 42 AA 4F 92 58 10 65 3A 5B 3F 5B 7D 44 8F 7A BC 42 F2 4F DD 58 27 65 2D D3 21 D3 2B D3 2A FF D4 C1 FB F9 B1 F4 C9 E3 51 DE 66 E0 6A E0 3C FF D4 C1 FB F9 8F F4 AB D8 AF D8 AC D8 6B CA 2D F2 1D FF 2E E8 4B 4F 45 4F 43 4F 76 63 F4 5D 8E 65 CF 68 C6 7F 2B 42 0A 7C 13 7C 5B 63 A5 5D AB 65 CF 68 EC 7F 0D 42 47 8E 45 8E 4E 8E B9 A9 8E BE 8A E4 C0 E4 80 E4 8E D7 C9 D7 87 C8 73 F6 5F CE 5E C3 2A D4 FD E9 CA D7 C5 D7 87 C8 6D F6 57 CE 09 C3 21 D4 FC E9 8E D7 8D D7 9C C8 60 F6 5D CE 50 C3 7E D4 A8 E9 9F D7 D4 D7 87 C8 55 F6 11 CE 5E C3 2B D4 F4 E9 C7 D7 C2 D7 C8 C8 31 F6 09 CE 4F C3 6E D4 E8 E9 C1 D7 F0 D7 3E A5 3D A5 35 A5 7C 89 98 B7 AD 8F 38 0F 77 0F 34 0F 3C 3C 7B 3C 35 23 C1 1D ED 25 EC 28 98 3F 4F 02 78 3C 77 3C 35 23 DF 1D E5 25 BB 28 93 3F 4E 02 3C 3C 3F 3C 2E 23 D2 1D EF 25 E2 28 88 3F 5F 02 73 3C 7D 3C 39 23 DC 1D C7 25 BC 28 B5 3F 02 02 3C 3C 73 3C 36 23 DA 1D ED 25 EC 28 88 3F 5F 02 73 3C 7D 3C 39 23 DC 1D C7 25 BC 28 B5 3F 53 A4 59 A4 5E A4 AC B6 83 8E C2 83 F9 94 2F A9 18 97 3E 97 52 88 AA B6 A1 8E C3 09 C7 09 CD 09 50 23 45 2E 68 39 F1 04 7A 2F 7C 2F 75 2F AA 3D E9 05 AE 08 9E 1F 48 22 63 1C 5D 02 58 02 4D 02 8D 10 CE 28 89 25 B9 32 72 0F CC 9B C8 9B DD 9B 24 B1 18 BC 28 AB E3 96 2D 54 2E 54 3F 54 B2 64 1F 59 34 67 AE 42 A8 42 BD 42 7A 65 4A 72 9C 4F AA 71 DB 71 F1 6E 2C 9D 29 9D 38 9D F8 BA C8 AD 1E 90 53 AE 3F AE 90 77 94 77 85 77 74 47 A2 7A EF 44 83 44 90 0F 93 0F 86 0F 94 3C E5 3C CF 23 11 AA 17 AA 06 AA 58 A7 08 99 1F 99 53 86 BA B8 82 80 AD 03 A8 03 B5 03 E4 0E B4 30 A3 30 EF 2F 06 11 F2 18 F6 18 EB 18 8D 2B E1 2B B0 34 59 0A 4D 50 4E 50 57 50 74 7C FB 42 DE 7A 11 14 1A 14 0A 14 D1 3E 8A 33 A7 24 60 19 54 27 72 27 00 38 F6 06 CB 3E 91 33 80 24 E8 D9 EA D9 F4 D9 DA D4 91 EA B9 1B A1 1B A4 1B 2A 31 22 3C 09 2B 8B 16 FA 28 F9 28 B2 37 46 09 69 31 28 3C 13 2B C5 16 F2 28 F4 28 FB 37 5C 09 65 31 24 3C 09 2B DB 16 F8 28 F4 28 A3 37 77 09 E9 5C E2 5C F7 5C 0D 6C C1 51 A3 6F A8 6F E2 70 16 4E 2A 76 78 7B 4E 6C 83 51 88 6F 6A D0 79 D0 75 D0 6E E3 7E E3 65 FC 8E C2 AB FA F8 F7 8E E0 1C DD 2B E3 30 E3 6B FC 84 C2 B7 FA F0 F7 C1 E0 1B DD 3D E3 2D E3 4C FC F6 60 E6 60 D6 60 08 47 5E 50 88 6D B3 53 BB 53 B4 4C 0F 72 30 4A 6D 47 4B 50 C4 6D A0 53 BD 53 E0 4C 13 72 20 4A 9A EE 9D EE BB EE 1B FC 13 C4 00 C9 37 DE EF E3 D1 DD D8 DD 9A D6 9B D6 B8 D6 A6 DB CC CC C4 CC EF CC 56 E6 4C EB 61 FC BC C1 C5 FF D6 FF 98 E0 6F DE 85 1B 8D 1B A1 1B 82 28 93 37 67 09 54 31 5C 3C 73 2B A4 16 89 28 10 E1 54 E1 35 E1 06 CD FA F3 C7 CB CA C6 A7 D1 70 EC 51 D2 4D D2 27 CD EC F3 D7 CB 8B C6 98 D1 5E EC 40 D2 50 D2 17 CD EF F3 CD CB 8B C6 97 D1 5E EC 47 D2 5A D2 13 CD F4 F3 CF CB 8A C6 A3 D1 6D EC 70 D2 62 D2 15 CD FD F3 E0 CB B8 C6 06 A4 1A A4 20 A4 AD B6 8F 8E 9F 83 AD 94 66 A9 44 97 08 97 01 88 E1 B6 DC 8E 94 83 E2 94 43 A9 76 97 67 97 28 88 AD B6 D2 8E 9C 83 AB 94 70 A9 43 97 47 97 08 88 E3 B6 C2 8E 9D 83 86 94 74 DE 39 DE 53 DE DF CC AA F4 EF F9 C2 EE 00 D3 70 ED 3E ED 73 F2 9B CC A6 F4 EF F9 DC EE 08 D3 27 ED 35 ED 72 F2 DF CC EE F4 F4 F9 D1 EE 02 D3 7E ED 3F ED 72 F2 90 CC 8A F4 E4 F9 DE EE 07 D3 12 ED 72 ED 36 F2 9A CC AB F4 E9 F9 D6 EE 46 D3 35 ED 3E ED 79 F2 B2 CC A3 F4 EE F9 D1 EE 24 D3 07 30 04 30 2F 30 C3 17 ED 00 25 3D 73 04 78 04 5A 04 41 09 30 37 33 37 78 28 8C 16 A1 2E E3 23 C7 34 34 09 7E 37 78 37 42 DC 47 DC 68 DC 6A D1 03 EF 01 EF 41 F0 87 CE AE 88 BF 88 85 88 57 9A 78 A2 2C AF 18 B8 D9 85 D9 BB A0 BB BE A4 40 9A 69 A2 29 AF 1F B8 D0 85 C9 BB AD BB 9E A4 64 9A E2 E6 E3 E6 CE E6 D5 EB A7 42 A3 42 8A 42 C6 71 C2 71 8C 6E 60 50 72 E1 7F E1 5C E1 20 D2 2B D2 47 CD A6 F3 A4 CB E2 C6 D9 D1 2E EC 09 D2 17 D2 25 CD BB F3 80 CB 25 A6 21 A6 0A A6 36 95 06 8A 8E B4 BA 8C 85 9A 84 9A B5 9A 58 BD E7 3E F4 3E D6 3E 98 33 AC 0D AA 0D AB 12 00 2C 3D 14 72 19 4E 0E 92 33 83 0D A2 0D B0 12 0E 2C 35 14 6A 19 51 0E 87 33 A6 0D BD 0D 10 E5 18 E5 22 E5 92 CF 94 C2 BD D5 6B E8 5B D6 4E D6 1D C9 D2 F7 7F 5E 74 5E 4C 5E CF 6E 03 53 34 6D 32 6D 6F 72 91 4C B8 74 FF 79 D4 6E 1D 53 28 6D A0 D0 A6 D0 94 D0 2D F7 10 E0 DC DD F1 E3 E1 E3 A1 FC A4 E4 A7 E4 91 E4 CF E9 F4 D7 E9 D7 82 32 86 32 B4 32 D2 01 C2 01 8F 1E 6A 20 13 EF 12 EF 24 EF C1 C5 22 FA 71 FA 1A FA C6 CA 5D F7 69 C9 7E C9 26 D6 89 E8 F5 D0 B3 DD 82 CA 51 F7 69 C9 60 C9 2E D6 DE E8 FE D0 B2 DD C6 CA 19 F7 72 C9 6D C9 24 D6 87 E8 FA D0 B5 DD 89 CA 5C F7 44 C9 78 C9 2F D6 D9 E8 C2 D0 AE DD A2 CA 18 F7 26 C9 69 C9 2C D6 C0 E8 F7 D0 F6 DD 8D CA 53 F7 69 C9 60 C9 02 D6 DD E8 FE D0 A6 DD B5 CA 48 F7 42 C9 88 01 86 01 B1 01 19 26 2B 31 FB 0C C1 32 EF 32 86 2D 62 13 52 2B 08 26 25 31 F4 0C E5 32 88 32 49 3D 40 E1 47 E1 7A E1 96 F3 C2 CB CC C6 F6 D1 13 EC 4B D2 35 D2 CA 5F C4 5F F1 5F D8 73 32 4D 1C 75 6C 78 60 6F B1 52 89 6C 8B 6C E4 73 1E 4D 32 75 0B 78 4C 6F 99 52 2A 18 3A 18 16 18 56 15 61 2B 6D 2B 3B 34 D3 0A FC 32 88 3F 8B 28 4B 15 6F 2B 61 2B 24 34 C4 0A CB 32 F1 3F C1 28 1D BF 11 BF 20 BF 55 8C 41 8C 2A 93 F3 AD DD 95 88 98 BC 8F 63 B2 5C 8C 61 8C 50 93 B9 AD C1 FE D0 FE FF FE 1E D4 47 D9 50 CE A0 F3 80 CD 9B CD CC D2 04 EC 17 D4 46 D9 64 CE B6 F3 89 CD 8A CD F1 D2 65 EC 5D D4 93 33 9E 33 AC 33 4E 19 08 14 3E 03 F2 3E C5 00 D8 00 A7 1F 79 21 54 19 02 14 15 03 AE 3E 98 00 5F 31 56 31 1F 31 17 02 03 02 68 1D B5 23 98 1B CE 16 D9 01 62 3C 54 02 20 14 2E 14 61 14 5E 19 76 27 5B 27 31 38 CE 06 E7 3E BB 33 AA 24 53 19 70 27 6B 27 00 38 84 06 BC 3E 49 44 4D 44 0B 44 4D 77 02 77 4F 68 E2 56 9D 20 9A 20 DE 20 20 10 FC 2D C8 13 DE 13 96 0C 7D 32 5D 0A B8 CD BE CD FC CD 6F EA 5F FD 89 C0 BF FE B8 FE EA E1 F5 3C BE 3C B0 3C C7 31 BC 0F B4 0F E5 10 18 2E 66 16 65 1B 54 0C 83 31 B0 0F B4 0F FB 10 10 2E 31 16 6E 1B 55 0C C7 31 F8 0F AF 0F F6 10 1A 2E 68 16 65 1B 43 0C 88 31 86 0F BF 0F F6 10 3C 2E 6E 16 21 1B 54 0C 8B 31 B8 0F BD 0F B7 10 1A 2E 34 16 6E 1B 66 0C 83 31 B0 0F 99 0F F5 13 FB 13 B3 13 45 23 94 1E A0 20 89 20 F9 3F 17 01 21 39 6E 34 7D 23 B8 1E 9A 20 EE 20 D5 3F 3F 01 4B 21 5D 21 0C 21 D1 06 E0 11 30 2C 1B 12 04 12 5B 0D B5 33 9F 0B D6 06 E9 11 37 2C 00 12 26 12 09 0D B3 33 9C 0B DA 06 EA 11 17 2C 4F 12 3D 12 6D 0D C4 F7 CB F7 8C F7 32 E5 44 DD 4B D0 3A C7 AB FA D2 C4 91 C4 9C DB 32 E5 46 DD 4B D0 3A C7 AB FA D0 C4 91 C4 B8 75 BE 75 F1 75 B9 59 5A 67 67 5F 2D 52 08 45 E3 78 A7 12 AB 12 ED 12 54 00 50 38 0C 35 06 22 D1 1F EC 21 C7 21 9A 3E 67 00 21 38 11 35 22 22 B9 98 BE 98 F2 98 E3 AB B5 B4 57 8A 67 B2 20 BF 12 A8 E8 95 4C 9B 19 9B 00 9B 42 A8 43 B7 A8 89 8D B1 DE BC A8 AB 3A 96 0D A8 06 A8 4F B7 A8 89 93 B1 D6 BC FF AB 31 96 0C A8 42 A8 07 B7 B3 89 9E B1 DC BC A6 AB 35 96 0B A8 0D A8 42 B7 85 89 8B B1 DB BC ED AB 30 96 06 A8 0D A8 6D B7 EF 89 DF B1 DD BC E4 AB 37 96 0E A8 42 A8 45 B7 A4 89 90 B1 D4 BC CA AB 2A 96 0B A8 07 A8 40 B7 A9 89 90 B1 FB BC E1 86 EA 86 AC 86 04 94 3D AC 7C A1 51 B6 90 8B A0 B5 9C B5 EF AA 18 94 20 AC 54 A1 2E C3 21 C3 60 C3 78 F0 1B EF CB D1 F3 E9 9B E4 B5 F3 59 CE 6E F0 6F F0 02 EF FA D1 D6 E9 EF E4 A8 F3 7D CE 04 C1 01 C1 4B C1 70 F2 0B ED E2 D3 FF EB B8 E6 7F 37 72 37 2F 37 23 04 78 1B 80 25 A0 1D E2 10 FD 07 4D 3A 3E 04 27 04 72 1B 99 25 A9 1D D9 10 26 AA 21 AA 77 AA 51 A7 65 99 69 99 29 86 E4 B8 BB 80 76 9D 8B 79 8F 79 D9 79 E4 4A EA 4A 9A 55 74 6B 01 9B 03 9B 52 9B CF 89 9D B1 A8 36 AC 36 FC 36 55 1C 1F 11 2E 06 95 3B 68 FE 79 FE 3D FE 11 CD 6B CD 24 D2 BF EC FB D4 B3 D9 95 CE 57 F3 7C CD 1C CD 27 D2 A2 EC A1 D4 B1 D9 CD CE 24 F3 17 CD C9 FF CD FF 9F FF D0 CC 9D D3 74 ED 4C D5 50 7C 57 7C 07 7C 31 71 07 4F 1B 4F 51 50 B4 6E 91 56 F4 5B 18 BC 17 BC 40 BC CC 9B E6 8C 79 B1 58 8F 57 8F 1F 90 E1 AE C3 96 B8 9B FC 8C 2A B1 07 8F 74 8F 37 90 B3 AE 86 E7 9C E7 DF E7 CC D4 C5 D4 91 CB 61 F5 5A CD 31 C0 3A D7 FB EA E0 D4 C3 D4 87 CB 68 F5 5D CD 31 C0 35 D7 F1 EA CB D4 FE D4 80 CB 64 F5 47 CD 35 C0 23 D7 E0 EA C3 D4 EC D4 A9 D2 B1 D2 F3 D2 29 F5 0C E2 DF DF A3 E1 F5 E1 AE FE 56 C0 69 F8 28 F5 01 E2 F8 DF F5 E1 C3 E1 97 FE 52 C0 6F F8 29 F5 08 E2 E8 DF D1 E1 E0 E1 AD FE 61 C0 46 F8 FE 19 BF 19 A5 19 F0 2A F1 35 1A 0B 3F 33 6C 3E 1A 29 98 14 A9 2A B9 2A F0 35 55 0B 3F 33 6F 3E 4E 29 9F 14 AF 2A BC 2A DF 35 58 0B 15 33 4E 3E 1A 29 8B 14 B4 2A B9 2A F8 35 14 0B 22 33 66 3E 54 29 9B 14 B5 2A 94 2A CF FF 80 FF 93 FF FD F2 86 CC 8E CC DF D3 22 ED 5C D5 5F D8 6E CF B9 F2 8A CC 8E CC C1 D3 2A ED 0B D5 54 D8 6F CF FD F2 C2 CC 95 CC CC D3 20 ED 52 D5 50 D8 68 CF B2 F2 87 CC A3 CC C1 D3 28 ED 1D D5 78 D8 23 CF FD F2 8E CC 8D CC C4 D3 22 ED 5C D5 50 D8 68 CF B2 F2 87 CC A3 CC C1 D3 28 ED 1D D5 78 D8 3C 44 2D 44 61 44 C5 56 EA 6E B2 63 91 74 42 49 79 77 7B 77 2C 68 D2 56 DC 6E A4 63 95 74 76 49 7D 77 61 77 3F 68 F5 56 4B C6 41 C6 15 C6 FB F6 37 CB 0A F5 0C F5 45 EA 83 D4 80 EC C7 E1 EC F6 09 CB) */;

	private static readonly object ႥႣ;

	private static readonly Array ႥႤ = new char[939]
	{
		'證', '譈', '證', '鈈', 'ⓘ', 'ⓙ', 'ⓙ', 'Ʌ', '홣', '홦',
		'홡', '\uf089', 'ﺬ', '싌', '첇', '켵', '遧', '適', '遤', '鿏',
		'뛃', '룬', '蒇', '諅', '襖', '谊', '꒜', '龆', '뚀', '뢲',
		'蓓', '誛', '襢', '\udf9a', '\udf9e', '\udf9e', '魯', '\uf754', '쬶', '씵',
		'鎣', '鎢', '鎦', '諣', '\uf3c3', '\uf3c1', '\uf3c5', 'ﰲ', '픽', '播',
		'撳', '撪', '偑', '欒', '䈈', '䱭', '瀉', '繎', '緱', '磪',
		'倞', '欍', '䉍', '䱦', '瀎', '繁', '綳', '磯', '倄', '欓',
		'䈎', '䱲', '灀', '繆', '綾', '磤', '倅', '欑', '䈈', '䱢',
		'瀘', '繭', '㖄', '㖌', '㖌', '⼤', 'ⳟ', '⦄', 'ĝ', '㨃',
		'ግ', 'ᵤ', 'Ⅹ', '쩑', '쩐', '쩘', '얷', '唱', '唵', '唻',
		'珑', '綠', '䇜', '侾', '⿂', '\u2fd8', '⿉', '㕨', '㛓', '㎍',
		'᭽', '†', 'ॱ', '܀', '㭫', '㔩', '㛇', '㎆', 'ᬰ', '⁾',
		'५', '܅', '㭬', '㔢', '㛖', '㎁', 'ᬱ', '‡', 'स', 'ܞ',
		'㭻', '㔳', '㛖', '稘', '稚', '稔', '令', '痮', 'ད', 'བྷ',
		'ཛྷ', 'ጅ', '㯵', 'ø', '⧅', '⟓', 'ସ', 'ṱ', 'ṱ', 'ṿ',
		'彙', '归', '彖', '䙤', '䌼', '毗', '僚', '秒', '矕', '䯜',
		'䖈', '䙷', '䌶', '毋', '旀', '旎', '旐', '缱', '糏', '禉',
		'兰', '橸', '䍵', '䴃', '煦', '缦', '糓', '禬', '儼', '橜',
		'䍉', '랱', '랻', '랠', '茟', '렘', '鄇', '齯', 'ꌙ', '굧',
		'꺵', '\uabe9', '茎', '렭', '\ueb41', '\ueb50', '\ueb53', '\ufff8', '\uf1a5', '\uf259',
		'\uf74f', '\udffa', '\ue4e2', '췍', '쎙', '\uffff', '\uf1a1', '\uf269', '\uf73d', '\udfee',
		'\ue4ea', '췮', '쎡', '\uffd0', '緼', '緬', '緯', '牞', '孓', '唹',
		'楅', '朘', '擲', '憩', '䥇', '牙', '孚', '唾', '楞', '机',
		'撠', '憄', '䥤', '澱', '澻', '澥', '筜', '畩', '盽', '玡',
		'孝', '恍', '䥁', '䜳', '筌', '畯', 'Ή', 'ῂ', '\u1fde', '⭣',
		'\u1069', '㥮', '㜎', '୪', 'ԍ', 'ۇ', 'Έ', '⭃', '壙', '壋',
		'壏', '瀛', '䱻', '䈵', '䇑', '䒘', '汷', '坠', '繾', '瀜',
		'䱲', '䈲', '䇊', '䒺', '氥', '坾', '繵', '瀔', '䱀', '暬',
		'暴', '暻', '刄', '椁', '䀈', '丮', '爒', '籛', '羵', '竿',
		'別', '椗', '䀘', '乯', '爭', '籵', '羠', '竹', '刄', '椅',
		'䀿', '乜', '爆', '籏', '羓', '竐', '밬', '밼', '밴', 'ꛌ',
		'ꔤ', 'ꁭ', '袔', '뎐', '骹', '铬', 'ꢍ', 'ꛈ', 'ꔓ', 'ꁾ',
		'袕', '뎔', '骟', '铡', 'ꢬ', '槒', '槑', '構', '疰', '嵝',
		'晍', '帋', '帕', '帑', '䝙', '䉎', '檻', '冥', '碪', '盝',
		'䪯', '䓢', '䜖', '䉂', '檥', '冢', '碸', '皇', '䪣', '䓬',
		'䝗', '䉟', '檤', '冲', '碦', '皇', '䪣', '䓾', '䜎', '䉟',
		'櫷', '冢', '碣', '盳', '戱', '戧', '截', '磚', '笢', '繸',
		'嚙', '涜', '䒃', '䫨', '皛', '磝', '笫', '繿', '嚂', '涾',
		'䓑', '䫸', '皟', '磚', '笸', '繾', '嚃', '涓', '䒰', '쓈',
		'쐌', '쓔', '\udd9a', '\ud886', '\uf07b', '쭭', '\ue27c', '\uec05', '큩', '\ude21',
		'\uddd5', '\ud89c', '\uf067', '쭪', '\ue261', '\uec44', '큠', '\ude25', '\uddc0', '\ud8c8',
		'\uf073', '쭪', '\ue261', '\uec16', '큰', '\ude29', '\udd94', '\ud89b', '\uf07f', '쭷',
		'\ue269', '\uec10', '퀥', '\ude3f', '\uddd1', '\ud880', '\uf060', '쭫', '\ue228', '\uec0b',
		'큡', '\ude6d', '\udddb', '\ud89c', '\uf034', '쭶', '\ue26d', '\uec10', '큰', '\ude3d',
		'\uddd9', '\ud887', '\uf077', '쬤', '\ue27a', '\uec11', '큪', '\ude34', '\udd94', '\ud88d',
		'\uf067', '쭱', '\ue228', '\uec0a', '큤', '\ude2e', '\udd94', '\ud89d', '\uf07b', '쭝',
		'\ue228', '\uec44', '퀫', '\ude3e', '\uddd1', '\ud89c', '\uf061', '쭪', '\ue261', '\uec09',
		'퀥', '\ude21', '\uddd5', '\ud89a', '\uf071', '쭲', '\ue26d', '\uec17', '퀥', '\ude28',
		'\udddf', '\ud889', '\uf060', '쬤', '\ue271', '\uec05', '큨', '\ude6d', '\uddc7', '\ud881',
		'\uf07c', '쭐', '嚙', '嚔', '嚄', '俅', '䪃', '戢', '夻', '瀰',
		'繑', '䈵', '䱳', '侉', '䫗', '戲', '夺', '瀝', '4', '7',
		'*', '㒪', '\u0fb5', '⛔', '譌', '譍', '譓', '龩', '鐹', '鐿',
		'鐙', '볹', '肑', '軟', '贫', '衸', 'ꂦ', 'ﰿ', 'ﰽ', 'ﰞ',
		'\uf5f4', '\uf0a8', '诞', '诐', '诼', '鄾', '鋅', '鞟', '뽯', '葛',
		'괰', 'ꌞ', '齶', '鄵', '鋌', '鞋', '뽄', '葡', '굪', '킵',
		'킿', '킖', '\ue458', '\udf1c', '\uf605', '\uf878', '쐐', '쩣', '즬', '쳻',
		'\ue400', '\udf15', 'ᗘ', 'ᗓ', 'ᗼ', '㍿', '㴚', 'ż', '༩', '\u0cc5',
		'জ', 'ⅴ', 'ᩁ', '㍵', '㴆', 'œ', '茳', '茢', '茖', '騡',
		'齼', '랆', '貋', 'ꖒ', '\uabed', '鞋', '駑', '騦', '齵', '랁',
		'貐', 'ꖰ', 'ꮿ', '鞨', '駡', '騘', '䂓', '䂑', '䂵', '众',
		'昛', '쨆', '쨂', '쨡', '\uecfb', '\ue2e1', '\udeeb', '킯', '㙠', '㙭',
		'㙈', 'დ', 'ẩ', '⋙', 'Ⲅ', '⽨', '⨓', 'ʜ', '㧈', 'Ⴥ',
		'Ẹ', '⋄', 'ⲋ', '⽉', '५', '९', '\u0942', '↢', '\u1dc2', 'ᎁ',
		'ၺ', '佫', '佢', '佁', '匬', '篖', '䃋', '槍', '枷', '寉',
		'喝', '噮', '匸', '傛', '傘', '傰', '弾', '瘽', '硄', '盹',
		'盰', '盕', '氏', '濶', '檼', '䉗', '祑', '偝', '帴', '扄',
		'氕', '䎴', '䎲', '䎙', '圤', '夃', '媰', '忦', '眩', '䰣',
		'\uf471', '\uf474', '\uf45f', '\ue085', '\ueec1', '\ued3f', '\ue81d', '샽', '呯', '呫',
		'呀', '享', '䵝', '䡺', '惸', '筮', '筣', '筞', '憛', '扻',
		'朴', '侜', '瓐', '巋', '厴', '濑', '憎', '扁', '札', '俀',
		'瓣', 'Ｖ', 'Ｕ', '＇', '\ue37f', '쮙', '\uf082', '녧', '녡', '녕',
		'\ua825', '굱', '藘', '뻙', '韆', '駫', '삮', '삪', '삝', '\udc84',
		'\uf478', '콨', '\ue664', 'ギ', 'ガ', '\u309a', 'ᙤ', '᠈', '曊', '曈',
		'替', '籈', '羱', '藮', '藧', '藘', '詆', 'ꍇ', '괮', '酂',
		'鼝', '鳿', '馧', '녙', '詑', '歾', '歭', '歉', '䎡', '翖',
		'熟', '牰', '眻', '忥', '撒', '䷇', '䎠', '翁', '熞', '牖',
		'睾', '徏', '撒', '䷵', '䏧', '翱', '熺', '쯽', '쯹', '쯅',
		'\udf0d', '텆', '튡', 'ퟗ', '澷', '澳', '澎', '畐', '皤', '珸',
		'嬉', '퐺', '퐾', '퐀', '촢', '졶', '\ue089', '\udbb4', '痉', '痈',
		'痲', '博', '㖘', '㖝', '㖤', '፪', 'ᴇ', 'Ⅷ', '⽖', 'Ⲵ',
		'醓', '醖', '醮', '뜶', '륋', '蔿', '譢', '袼', '鿣', '鿮',
		'鿝', '륆', '뜡', '譁', '蔼', '蛮', '莀', 'ꭍ', '遊', '륗',
		'뜻', '譁', '蔖', '蛌', '\udeea', '\udee4', '\uded5', '텃', '\uf844', '\uf629',
		'쩽', '쐚', '쟢', '슃', '\uea44', '텃', '\uf85e', '\uf632', '쩈', '쐟',
		'쟅', '쨞', '쨖', '쩞', '팇', '홈', 'ﺭ', '얿', '\uecbb', '\ue2e0',
		'\udea0', '탯', '짣', '짮', '즢', '탭', '햦', '﵋', '왃', '\uef4a',
		'\ue129', '\udd0e', '팃', '탩', '햬', 'ﵒ', '왊', '\uef71', '鮈', '鮌',
		'鯊', '蟰', '꼐', '鐌', '봛', '緗', '緖', '綔', '啔', '荱',
		'荳', '茵', '驟', '齾', '䶻', '䶰', '䷾', '礓', '䈒', '欨',
		'攷', '夑', '坐', '咮', '凰', '礕', '䈘', '欬', '䦁', '䦈',
		'䧇', '嵬', '匾', '傰', '嗠', '紏', '䙭', '潡', '愈', '嵬',
		'\ue28c', '\ue296', '\ue2cb', 'ﻂ', '혽', '\ued35', '쐠', '쩏', '\uf602', '\uf871',
		'ﮟ', 'ﻮ', '혿', '\ued22', '쐡', '쩏', '\uf602', '\uf87e', 'ﮕ', 'ﻅ',
		'혆', '\ued24', '쐥', '쩒', '\uf606', '\uf868', 'ﮄ', 'ﻍ', '혔'
	};

	private static readonly object ႥႠ;

	internal static ႥႼ ႰႨ/* Not supported: data(49 8B 48 8B 49 8B 08 92 D8 24 D9 24 D9 24 45 02 63 D6 66 D6 61 D6 89 F0 AC FE CC C2 87 CC 35 CF 67 90 69 90 64 90 CF 9F C3 B6 EC B8 87 84 C5 8A 56 89 0A 8C 9C A4 86 9F 80 B6 B2 B8 D3 84 9B 8A 62 89 9A DF 9E DF 9E DF 39 F9 54 F7 36 CB 35 C5 A3 93 A2 93 A6 93 E3 8A C3 F3 C1 F3 C5 F3 32 FC 3D D5 AD 64 B3 64 AA 64 51 50 12 6B 08 42 6D 4C 09 70 4E 7E F1 7D EA 78 1E 50 0D 6B 4D 42 66 4C 0E 70 41 7E B3 7D EF 78 04 50 13 6B 0E 42 72 4C 40 70 46 7E BE 7D E4 78 05 50 11 6B 08 42 62 4C 18 70 6D 7E 84 35 8C 35 8C 35 24 2F DF 2C 84 29 1D 01 03 3A 0D 13 64 1D 69 21 51 CA 50 CA 58 CA B7 C5 31 55 35 55 3B 55 D1 73 A0 7D DC 41 BE 4F C2 2F D8 2F C9 2F 68 35 D3 36 8D 33 7D 1B 20 20 71 09 00 07 6B 3B 29 35 C7 36 86 33 30 1B 7E 20 6B 09 05 07 6C 3B 22 35 D6 36 81 33 31 1B 21 20 38 09 1E 07 7B 3B 33 35 D6 36 18 7A 1A 7A 14 7A E4 4E EE 75 51 0F 57 0F 5C 0F 05 13 F5 3B F8 00 C5 29 D3 27 38 0B 71 1E 71 1E 7F 1E 59 5F 52 5F 56 5F 64 46 3C 43 D7 6B DA 50 D2 79 D5 77 DC 4B 88 45 77 46 36 43 CB 6B C0 65 CE 65 D0 65 31 7F CF 7C 89 79 70 51 78 6A 75 43 03 4D 66 71 26 7F D3 7C AC 79 3C 51 5C 6A 49 43 B1 B7 BB B7 A0 B7 1F 83 18 B8 07 91 6F 9F 19 A3 67 AD B5 AE E9 AB 0E 83 2D B8 41 EB 50 EB 53 EB F8 FF A5 F1 59 F2 4F F7 FA DF E2 E4 CD CD 99 C3 FF FF A1 F1 69 F2 3D F7 EE DF EA E4 EE CD A1 C3 D0 FF FC 7D EC 7D EF 7D 5E 72 53 5B 39 55 45 69 18 67 F2 64 A9 61 47 49 59 72 5A 5B 3E 55 5E 69 3A 67 A0 64 84 61 64 49 B1 6F BB 6F A5 6F 5C 7B 69 75 FD 76 A1 73 5D 5B 4D 60 41 49 33 47 4C 7B 6F 75 CB 1F C2 1F DE 1F 63 2B 69 10 6E 39 0E 37 6A 0B 0D 05 C7 06 88 03 43 2B D9 58 CB 58 CF 58 1B 70 7B 4C 35 42 D1 41 98 44 77 6C 60 57 7E 7E 1C 70 72 4C 32 42 CA 41 BA 44 25 6C 7E 57 75 7E 14 70 40 4C AC 66 B4 66 BB 66 04 52 01 69 08 40 2E 4E 12 72 5B 7C B5 7F FF 7A 25 52 17 69 18 40 6F 4E 2D 72 75 7C A0 7F F9 7A 04 52 05 69 3F 40 5C 4E 06 72 4F 7C 93 7F D0 7A 2C BC 3C BC 34 BC CC A6 24 A5 6D A0 94 88 90 B3 B9 9A EC 94 8D A8 C8 A6 13 A5 7E A0 95 88 94 B3 9F 9A E1 94 AC A8 D2 69 D1 69 CB 69 B0 75 5D 5D 4D 66 0B 5E 15 5E 11 5E 59 47 4E 42 BB 6A A5 51 AA 78 DD 76 AF 4A E2 44 16 47 42 42 A5 6A A2 51 B8 78 87 76 A3 4A EC 44 57 47 5F 42 A4 6A B2 51 A6 78 87 76 A3 4A FE 44 0E 47 5F 42 F7 6A A2 51 A3 78 F3 76 31 62 27 62 2A 62 DA 78 22 7B 78 7E 99 56 9C 6D 83 44 E8 4A 9B 76 DD 78 2B 7B 7F 7E 82 56 BE 6D D1 44 F8 4A 9F 76 DA 78 38 7B 7E 7E 83 56 93 6D B0 44 C8 C4 0C C4 D4 C4 9A DD 86 D8 7B F0 6D CB 7C E2 05 EC 69 D0 21 DE D5 DD 9C D8 67 F0 6A CB 61 E2 44 EC 60 D0 25 DE C0 DD C8 D8 73 F0 6A CB 61 E2 16 EC 70 D0 29 DE 94 DD 9B D8 7F F0 77 CB 69 E2 10 EC 25 D0 3F DE D1 DD 80 D8 60 F0 6B CB 28 E2 0B EC 61 D0 6D DE DB DD 9C D8 34 F0 76 CB 6D E2 10 EC 70 D0 3D DE D9 DD 87 D8 77 F0 24 CB 7A E2 11 EC 6A D0 34 DE 94 DD 8D D8 67 F0 71 CB 28 E2 0A EC 64 D0 2E DE 94 DD 9D D8 7B F0 5D CB 28 E2 44 EC 2B D0 3E DE D1 DD 9C D8 61 F0 6A CB 61 E2 09 EC 25 D0 21 DE D5 DD 9A D8 71 F0 72 CB 6D E2 17 EC 25 D0 28 DE DF DD 89 D8 60 F0 24 CB 71 E2 05 EC 68 D0 6D DE C7 DD 81 D8 7C F0 50 CB 99 56 94 56 84 56 C5 4F 83 4A 22 62 3B 59 30 70 51 7E 35 42 73 4C 89 4F D7 4A 32 62 3A 59 1D 70 34 00 37 00 2A 00 AA 34 B5 0F D4 26 4C 8B 4D 8B 53 8B A9 9F 39 94 3F 94 19 94 F9 BC 91 80 DF 8E 2B 8D 78 88 A6 A0 3F FC 3D FC 1E FC F4 F5 A8 F0 DE 8B D0 8B FC 8B 3E 91 C5 92 9F 97 6F BF 5B 84 30 AD 1E A3 76 9F 35 91 CC 92 8B 97 44 BF 61 84 6A AD B5 D0 BF D0 96 D0 58 E4 1C DF 05 F6 78 F8 10 C4 63 CA AC C9 FB CC 00 E4 15 DF D8 15 D3 15 FC 15 7F 33 1A 3D 7C 01 29 0F C5 0C 9C 09 74 21 41 1A 75 33 06 3D 53 01 33 83 22 83 16 83 21 9A 7C 9F 86 B7 8B 8C 92 A5 ED AB 8B 97 D1 99 26 9A 75 9F 81 B7 90 8C B0 A5 BF AB A8 97 E1 99 18 9A 93 40 91 40 B5 40 17 4F 1B 66 06 CA 02 CA 21 CA FB EC E1 E2 EB DE AF D0 60 36 6D 36 48 36 D3 10 A9 1E D9 22 84 2C 68 2F 13 2A 9C 02 C8 39 C5 10 B8 1E C4 22 8B 2C 49 2F 6B 09 6F 09 42 09 A2 21 C2 1D 81 13 7A 10 6B 4F 62 4F 41 4F 2C 53 D6 7B CB 40 CD 69 B7 67 C9 5B 9D 55 6E 56 38 53 9B 50 98 50 B0 50 3E 5F 3D 76 44 78 F9 76 F0 76 D5 76 0F 6C F6 6F BC 6A 57 42 51 79 5D 50 34 5E 44 62 15 6C B4 43 B2 43 99 43 24 57 03 59 B0 5A E6 5F 29 77 23 4C 71 F4 74 F4 5F F4 85 E0 C1 EE 3F ED 1D E8 FD C0 6F 54 6B 54 40 54 AB 4E 5D 4D 7A 48 F8 60 6E 7B 63 7B 5E 7B 9B 61 7B 62 34 67 9C 4F D0 74 CB 5D B4 53 D1 6F 8E 61 41 62 2D 67 C0 4F E3 74 36 FF 35 FF 07 FF 7F E3 99 CB 82 F0 67 B1 61 B1 55 B1 25 A8 71 AD D8 85 D9 BE C6 97 EB 99 AE C0 AA C0 9D C0 84 DC 78 F4 68 CF 64 E6 AE 30 AC 30 9A 30 64 16 08 18 CA 66 C8 66 FF 66 48 7C B1 7F EE 85 E7 85 D8 85 46 8A 47 A3 2E AD 42 91 1D 9F FF 9C A7 99 59 B1 51 8A 7E 6B 6D 6B 49 6B A1 43 D6 7F 9F 71 70 72 3B 77 E5 5F 92 64 C7 4D A0 43 C1 7F 9E 71 56 72 7E 77 8F 5F 92 64 F5 4D E7 43 F1 7F BA 71 FD CB F9 CB C5 CB 0D DF 46 D1 A1 D2 D7 D7 B7 6F B3 6F 8E 6F 50 75 A4 76 F8 73 09 5B 3A D4 3E D4 00 D4 22 CD 76 C8 89 E0 B4 DB C9 75 C8 75 F2 75 5A 53 98 35 9D 35 A4 35 6A 13 07 1D 67 21 56 2F B4 2C 93 91 96 91 AE 91 36 B7 4B B9 3F 85 62 8B BC 88 E3 9F EE 9F DD 9F 46 B9 21 B7 41 8B 3C 85 EE 86 80 83 4D AB 4A 90 57 B9 3B B7 41 8B 16 85 CC 86 EA DE E4 DE D5 DE 43 D1 44 F8 29 F6 7D CA 1A C4 E2 C7 83 C2 44 EA 43 D1 5E F8 32 F6 48 CA 1F C4 C5 C7 1E CA 16 CA 5E CA 07 D3 48 D6 AD FE BF C5 BB EC E0 E2 A0 DE EF D0 E3 C9 EE C9 A2 C9 ED D0 A6 D5 4B FD 43 C6 4A EF 29 E1 0E DD 03 D3 E9 D0 AC D5 52 FD 4A C6 71 EF 88 9B 8C 9B CA 9B F0 87 10 AF 0C 94 1B BD D7 7D D6 7D 94 7D 54 55 71 83 73 83 35 83 5F 9A 7E 9F BB 4D B0 4D FE 4D 13 79 12 42 28 6B 37 65 11 59 50 57 AE 54 F0 51 15 79 18 42 2C 6B 81 49 88 49 C7 49 6C 5D 3E 53 B0 50 E0 55 0F 7D 6D 46 61 6F 08 61 6C 5D 8C E2 96 E2 CB E2 C2 FE 3D D6 35 ED 20 C4 4F CA 02 F6 71 F8 9F FB EE FE 3F D6 22 ED 21 C4 4F CA 02 F6 7E F8 95 FB C5 FE 06 D6 24 ED 25 C4 52 CA 06 F6 68 F8 84 FB CD FE 14 D6) */;

	[SpecialName]
	public Version Ⴄ()
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		while (true)
		{
			string text = Ⴍ();
			DataGridViewColumnSelector.Ⴐ[575] = (char)((DataGridViewColumnSelector.Ⴐ[575] - DataGridViewColumnSelector.Ⴐ[579]) & 0x2D);
			int num = ((text == null) ? (ⴀ[42] - 37426) : (ⴗ[135] - 48376));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 0:
				case 3:
					break;
				case 5:
					return new Version(Ⴍ());
				case 4:
					return null;
				}
				break;
			}
		}
	}

	[SpecialName]
	public Version Ⴅ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		while (true)
		{
			int num = ((Ⴈ() == null) ? (ⴃႤ[471] - 21732) : (ⴀ[203] - 51137));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 6;
					continue;
				case 2:
				case 6:
					break;
				case 1:
				case 4:
					return new Version(Ⴈ());
				case 3:
					return null;
				}
				break;
			}
		}
	}

	[SpecialName]
	public string Ⴍ()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		string ⴀ = this.m_Ⴗ.Ⴀ;
		TalkCfg.ႣႣ[46] = (char)((TalkCfg.ႣႣ[46] | TalkCfg.ႣႣ[6]) & 0xDF);
		return ⴀ;
	}

	[SpecialName]
	public void Ⴀ(string P_0)
	{
		this.m_Ⴗ.Ⴀ = P_0 as string;
	}

	[SpecialName]
	public string Ⴐ()
	{
		return this.m_Ⴗ.Ⴃ;
	}

	[SpecialName]
	public void Ⴈ(string P_0)
	{
		this.m_Ⴗ.Ⴃ = P_0;
	}

	[SpecialName]
	public string Ⴓ()
	{
		char[] ⴗ = DxCfg.Ⴗ;
		return this.m_Ⴃ;
	}

	[SpecialName]
	public void Ⴍ(string P_0)
	{
		this.m_Ⴃ = P_0;
	}

	[SpecialName]
	public string Ⴈ()
	{
		return this.m_Ⴗ.Ⴓ;
	}

	[SpecialName]
	public void Ⴗ(string P_0)
	{
		this.m_Ⴗ.Ⴓ = P_0;
	}

	[SpecialName]
	public string Ⴃ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		return this.m_Ⴗ.Ⴅ;
	}

	[SpecialName]
	public void Ⴐ(string P_0)
	{
		this.m_Ⴗ.Ⴅ = P_0;
	}

	[SpecialName]
	public string Ⴀ()
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		return this.m_Ⴗ.Ⴄ;
	}

	[SpecialName]
	public void Ⴃ(string P_0)
	{
		this.m_Ⴗ.Ⴄ = P_0 as string;
	}

	public ႣႼ()
	{
		Ⴀ(string.Empty);
		Ⴈ(string.Empty);
		Ⴍ(string.Empty);
		Ⴗ(string.Empty);
		Ⴐ(string.Empty);
		Ⴃ(string.Empty);
	}

	public bool Ⴗ(string P_0, string P_1)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		try
		{
			int num = 3;
			object obj2 = default(object);
			object obj4 = default(object);
			object obj3 = default(object);
			ICloneable cloneable2 = default(ICloneable);
			ICloneable cloneable = default(ICloneable);
			object obj = default(object);
			IEnumerable enumerable = default(IEnumerable);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = DownloadUrl.DownloadToXmlDoc(P_0, P_1);
					obj4 = AnnWxSpotExt.ႤႠ((XmlNode)(obj2 as XmlDocument), Ⴜ(2, 365387414, 24), (short)191, 'õ');
					num = 10;
					continue;
				case 10:
					Ⴀ(UtilsEmail.Ⴗ(obj4 as XmlNode, 62, 105));
					obj3 = AnnWxSpotExt.ႤႠ((XmlNode)(obj2 as XmlDocument), Ⴜ(0, 365387449, 26), (short)256, 'Ŋ');
					goto case 0;
				case 0:
					num = ⴀ[79] - 6382;
					continue;
				case 6:
					Ⴈ(UtilsEmail.Ⴗ(obj3 as XmlNode, 216, 143));
					cloneable2 = AnnWxSpotExt.ႤႠ((XmlNode)(obj2 as XmlDocument), Ⴜ(3, 365387445, 6), (short)380, 'Ķ');
					num = ⴃႤ[228] - 17966;
					continue;
				case 5:
					Ⴍ(UtilsEmail.Ⴗ((XmlNode)cloneable2, 724, 643));
					cloneable = AnnWxSpotExt.ႤႠ((XmlNode)(XmlDocument)obj2, Ⴜ(3, 365387353, 7), (short)253, '·');
					num = ⴃႣ[143] - 63371;
					continue;
				case 2:
					Ⴗ(UtilsEmail.Ⴗ((XmlNode)cloneable, 52, 99));
					goto case 1;
				case 1:
					obj = AnnWxSpotExt.ႤႠ((XmlNode)(XmlDocument)obj2, Ⴜ(6, 365387372, 10), (short)276, 'Ş');
					num = 7;
					continue;
				case 7:
					Ⴐ(UtilsEmail.Ⴗ(obj as XmlNode, 315, 364));
					enumerable = ((XmlDocument)obj2).SelectSingleNode(Ⴜ(8, 365387374, 14));
					num = ⴃႣ[119] - 27079;
					continue;
				case 9:
					Ⴃ((enumerable as XmlNode).InnerText);
					break;
				case 4:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			_ = ArcLogInRqstExt.Ⴗ(1706507962, 19, 1) + P_0;
			return false;
		}
		switch (5)
		{
		default:
			return true;
		case 2:
		case 4:
		{
			bool result = default(bool);
			return result;
		}
		}
	}

	[SecuritySafeCritical]
	static ႣႼ()
	{
		char[] array = new char[8];
		array[3] = '㓜';
		array[1] = '⛀';
		array[7] = 'ᓍ';
		array[5] = '\u197c';
		array[6] = '᪅';
		array[0] = '⢬';
		array[2] = '࿌';
		array[4] = 'ᰠ';
		ႥႠ = new string[72];
		ႥႣ = array;
		ႥႥ = new char[1497]
		{
			'暤', '暥', '暤', '撌', '\u09b4', 'শ', '\u09b5', '㥗', 'ҁ', 'ꮙ',
			'ꮚ', 'ꮛ', '顥', '颗', '蟆', '\ue4ed', '\ue4ec', '\ue4ee', '칾', '碼',
			'碪', '碸', '橅', '剪', '弼', '䠔', '症', '䯞', '䯼', '咳',
			'橂', '剣', '弧', '䠻', '痖', '䯷', '䯐', '咪', '橏', '剪',
			'弜', '䠎', '痉', '䯜', '桶', '根', '桳', '嬓', '䐡', '窿',
			'䊄', '侢', '壗', '攀', '孲', '嬡', '䑳', '窒', '䊩', '俭',
			'壜', '攌', '嬱', '嬽', '䑀', '竐', '䊗', '促', '墒', '敐',
			'季', '孨', '䐦', '竝', '䋨', '侢', '墊', '敝', '孫', '孩',
			'䐴', '竔', '䊦', '侪', '墒', '攐', '嬺', '嬿', '䑽', '窏',
			'䊼', '俲', '壝', '攧', '팭', '팡', '팫', 'Ｊ', '쇔', '炙',
			'\uf4b1', '\ue3c9', '\ude51', '\ue066', '\ue06a', '＼', '쇔', '炙', '\uf48f', '\ud8ab',
			'\ud8af', '\ud8ac', '쩫', '\uf22d', '＝', '\ue82e', '佋', '佅', '佃', '捶',
			'巴', '斎', '棏', '翆', '䈫', '簊', '簓', '捛', '嶥', '斫',
			'棏', '翬', '䈍', '蹇', '蹅', '蹎', '\ua9b9', '뺎', '\ue48a', '\ue4c0',
			'\ue480', '힎', '\ud7c9', '좇', '\uf673', '칟', '썞', '퐪', '\ue9fd', '\ud7ca',
			'ퟅ', '좇', '\uf66d', '칗', '쌉', '퐡', '\ue9fc', '힎', '힍', '좜',
			'\uf660', '칝', '썐', '푾', '\ue9a8', '힟', 'ퟔ', '좇', '\uf655', '츑',
			'썞', '퐫', '\ue9f4', '\ud7c7', 'ퟂ', '죈', '\uf631', '츉', '썏', '푮',
			'\ue9e8', 'ퟁ', 'ퟰ', 'ꔾ', 'ꔽ', 'ꔵ', '襼', '래', '辭', '༸',
			'\u0f77', '༴', '㰼', '㱻', '⌵', '\u1dc1', '◭', '⣬', '㾘', 'ɏ',
			'㱸', '㱷', '⌵', '\u1ddf', '◥', '⢻', '㾓', 'Ɏ', '㰼', '㰿',
			'⌮', '\u1dd2', '◯', '⣢', '㾈', 'ɟ', '㱳', '㱽', '⌹', '\u1ddc',
			'◇', '⢼', '㾵', 'Ȃ', '㰼', '㱳', '⌶', '\u1dda', '◭', '⣬',
			'㾈', 'ɟ', '㱳', '㱽', '⌹', '\u1ddc', '◇', '⢼', '㾵', 'ꑓ',
			'ꑙ', 'ꑞ', '뚬', '躃', '菂', '铹', '꤯', '霘', '霾', '衒',
			'뚪', '躡', '\u09c3', '\u09c7', '\u09cd', '⍐', '⹅', '㥨', 'ӱ', '⽺',
			'⽼', '⽵', '㶪', 'ש', 'ࢮ', 'ᾞ', '≈', 'ᱣ', 'ɝ', 'ɘ',
			'ɍ', '\u108d', '⣎', '▉', '㊹', '\u0f72', '鯌', '鯈', '鯝', '네',
			'반', 'ꬨ', '難', '吭', '吮', '吿', '撲', '够', '朴', '䊮',
			'䊨', '䊽', '敺', '牊', '侜', '熪', '燛', '滱', '鴬', '鴩',
			'鴸', '뫸', '귈', '逞', '깓', '긿', '瞐', '瞔', '瞅', '䝴',
			'窢', '䓯', '䒃', '\u0f90', '\u0f93', '\u0f86', '㲔', '㳥', '⏏', 'ꨑ',
			'ꨗ', 'ꨆ', 'Ꝙ', '餈', '餟', '虓', '뢺', '肂', 'έ', 'Ψ',
			'ε', '\u0ee4', 'ゴ', 'ィ', '\u2fef', 'ᄆ', 'ᣲ', '\u18f6', 'ᣫ', '⮍',
			'⯡', '㒰', 'ਖ਼', '偍', '偎', '偗', '籴', '䋻', '竞', 'ᐑ',
			'ᐚ', 'ᐊ', '㻑', '㎊', '⒧', 'ᥠ', '❔', '❲', '㠀', '۶',
			'㻋', '㎑', '⒀', '\ud9e8', '\ud9ea', '\ud9f4', '퓚', '\uea91', '᮹', '\u1ba1',
			'\u1ba4', 'ㄪ', '㰢', '⬉', 'ᚋ', '⣺', '⣹', '㞲', '\u0946', 'ㅩ',
			'㰨', '⬓', 'ᛅ', '⣲', '⣴', '㟻', 'ड़', 'ㅥ', '㰤', '⬉',
			'ᛛ', '⣸', '⣴', '㞣', 'ॷ', '峩', '峢', '峷', '氍', '凁',
			'澣', '澨', '烢', '世', '瘪', '筸', '汎', '冃', '澈', '큪',
			'큹', '큵', '\ue36e', '\ue37e', 'ﱥ', '슎', '磌', '\uf7f8', '\ue08e', '\udd1c',
			'\ue32b', '\ue330', 'ﱫ', '슄', '覆', '\uf7f0', '\ue0c1', '\udd1b', '\ue33d', '\ue32d',
			'ﱌ', '惶', '惦', '惖', '䜈', '偞', '消', '厳', '去', '䲴',
			'爏', '䨰', '䝭', '偋', '淄', '厠', '厽', '䳠', '爓', '䨠',
			'\uee9a', '\uee9d', '\ueebb', 'ﰛ', '쐓', '준', '\ude37', '\ue3ef', '\uddd1', '\uddd8',
			'횚', '횛', '횸', '\udba6', '쳌', '쳄', '쳯', '\ue656', '\ueb4c', 'ﱡ',
			'솼', 'ￅ', 'ￖ', '\ue098', '\ude6f', 'ᮅ', 'ᮍ', '\u1ba1', '⢂', '㞓',
			'१', 'ㅔ', '㱜', '⭳', 'ᚤ', '⢉', '\ue110', '\ue154', '\ue135', '촆',
			'\uf3fa', '쯇', '웊', '톧', '\uec70', '퉑', '퉍', '촧', '\uf3ec', '쯗',
			'욋', '톘', '\uec5e', '퉀', '퉐', '촗', '\uf3ef', '쯍', '욋', '톗',
			'\uec5e', '퉇', '퉚', '촓', '\uf3f4', '쯏', '욊', '톣', '\uec6d', '퉰',
			'퉢', '촕', '\uf3fd', '쯠', '울', 'ꐆ', 'ꐚ', 'ꐠ', '뚭', '躏',
			'莟', '钭', 'ꥦ', '靄', '霈', '蠁', '뛡', '軜', '莔', '铢',
			'ꥃ', '靶', '靧', '蠨', '뚭', '軒', '莜', '钫', 'ꥰ', '靃',
			'靇', '蠈', '뛣', '軂', '莝', '钆', '\ude74', '\ude39', '\ude53', '쳟',
			'\uf4aa', '璘', '\ueec2', '팀', '\ued70', '\ued3e', '\uf273', '첛', '\uf4a6', '璘',
			'\ueedc', '팈', '\ued27', '\ued35', '\uf272', '쳟', '\uf4ee', '林', '\ueed1', '팂',
			'\ued7e', '\ued3f', '\uf272', '첐', '\uf48a', '理', '\ueede', '팇', '\ued12', '\ued72',
			'\uf236', '첚', '\uf4ab', '里', '\ueed6', '퍆', '\ued35', '\ued3e', '\uf279', '첲',
			'\uf4a3', '燐', '\ueed1', '팤', '〇', '〄', '\u302f', '\u17c3', 'í', '㴥',
			'ѳ', 'Ѹ', 'њ', '\u0941', '㜰', '㜳', '⡸', 'ᚌ', '⺡', '⏣',
			'㓇', 'ऴ', '㝾', '㝸', '\udc42', '\udc47', '\udc68', '텪', '\uef03', '\uef01',
			'\uf041', '캇', '袮', '袿', '袅', '驗', 'ꉸ', '꼬', '렘', '藙',
			'믙', '뮠', '꒾', '驀', 'ꉩ', '꼩', '렟', '藐', '믉', '뮭',
			'꒞', '驤', '\ue6e2', '\ue6e3', '\ue6ce', '\uebd5', '䊧', '䊣', '䊊', '燆',
			'燂', '溌', '偠', '\ue172', '\ue17f', '\ue15c', '툠', '툫', '쵇', '\uf3a6',
			'쮤', '웢', '퇙', '\uec2e', '툉', '툗', '촥', '\uf3bb', '쮀', '꘥',
			'꘡', 'ꘊ', '锶', '訆', '뒎', '貺', '骅', '骄', '骵', '뵘',
			'㻧', '㻴', '㻖', '㎘', 'ඬ', 'ඪ', 'ካ', 'Ⰰ', 'ᐽ', 'ᥲ',
			'\u0e4e', '㎒', '\u0d83', 'ජ', 'ኰ', 'Ⰾ', 'ᐵ', 'ᥪ', '๑', '㎇',
			'ඦ', 'ල', '\ue510', '\ue518', '\ue522', '쾒', '슔', '햽', '\ue86b', '홛',
			'홎', '줝', '\uf7d2', '广', '年', '幌', '滏', '匃', '洴', '洲',
			'牯', '䲑', '璸', '秿', '滔', '匝', '洨', '킠', '킦', '킔',
			'\uf72d', '\ue010', '\udddc', '\ue3f1', '\ue3e1', 'ﲡ', '\ue4a4', '\ue4a7', '\ue491', '\ue9cf',
			'ퟴ', 'ퟩ', '㊂', '㊆', '㊴', 'ǒ', 'ǂ', 'ẏ', '\u206a', '\uef13',
			'\uef12', '\uef24', '엁', '諸', '况', '祥', '쫆', '\uf75d', '쥩', '쥾',
			'혦', '\ue889', '탵', '\uddb3', '쪂', '\uf751', '쥩', '쥠', '혮', '\ue8de',
			'탾', '\uddb2', '쫆', '\uf719', '쥲', '쥭', '혤', '\ue887', '탺', '\uddb5',
			'쪉', '\uf75c', '쥄', '쥸', '혯', '\ue8d9', '탂', '\uddae', '쪢', '\uf718',
			'줦', '쥩', '혬', '\ue8c0', '탷', '\uddf6', '쪍', '\uf753', '쥩', '쥠',
			'혂', '\ue8dd', '탾', '\udda6', '쪵', '\uf748', '쥂', 'ƈ', 'Ɔ', 'Ʊ',
			'☙', 'ㄫ', '\u0cfb', '㋁', '㋯', 'ⶆ', '።', '⭒', '☈', 'ㄥ',
			'\u0cf4', '㋥', '㊈', '㵉', '\ue140', '\ue147', '\ue17a', '\uf396', '쯂', '워',
			'퇶', '\uec13', '퉋', '툵', '忊', '忄', '忱', '珘', '䴲', '甜',
			'硬', '潠', '励', '沉', '沋', '珤', '䴞', '甲', '砋', '潌',
			'劙', 'ᠪ', 'ᠺ', '᠖', 'ᕖ', '⭡', '⭭', '㐻', '\u0ad3', '㋼',
			'㾈', '⢋', 'ᕋ', '⭯', '⭡', '㐤', '\u0ac4', '㋋', '㿱', '⣁',
			'뼝', '뼑', '뼠', '豕', '豁', '錪', '귳', '闝', '颈', '込',
			'뉣', '豜', '象', '鍐', '궹', 'ﻁ', 'ﻐ', '\ufeff', '퐞', '\ud947',
			'칐', '\uf3a0', '춀', '춛', '틌', '\uec04', '퐗', '\ud946', '칤', '\uf3b6',
			'춉', '춊', '틱', '\uec65', '푝', '㎓', '㎞', '㎬', '᥎', 'ᐈ',
			'\u033e', '㻲', 'Å', 'Ø', 'ᾧ', 'ⅹ', 'ᥔ', 'ᐂ', '\u0315', '㺮',
			'\u0098', 'ㅟ', 'ㅖ', 'ㄟ', 'ȗ', 'ȃ', 'ᵨ', '⎵', 'ᮘ', 'ᛎ',
			'Ǚ', '㱢', 'ɔ', 'ᐠ', 'ᐮ', 'ᑡ', 'ᥞ', '❶', '❛', '㠱',
			'ێ', '㻧', '㎻', '⒪', 'ᥓ', '❰', '❫', '㠀', 'ڄ', '㺼',
			'䑉', '䑍', '䐋', '睍', '眂', '桏', '团', '\u209d', 'ₚ', '\u20de',
			'ဠ', '\u2dfc', 'Ꮘ', 'Ꮮ', 'ಖ', '㉽', '\u0a5d', '춸', '춾', '췼',
			'\uea6f', 'ﵟ', '삉', 'ﺿ', 'ﺸ', '\ue1ea', '㳵', '㲾', '㲰', '㇇',
			'\u0fbc', '\u0fb4', 'ქ', '⸘', 'ᙦ', '᭥', '\u0c54', 'ㆃ', '\u0fb0', '\u0fb4',
			'჻', '⸐', 'ᘱ', '\u1b6e', '\u0c55', '㇇', '\u0ff8', '\u0faf', 'ჶ', '⸚',
			'ᙨ', '᭥', '\u0c43', 'ㆈ', '\u0f86', '྿', 'ჶ', '⸼', '᙮', 'ᬡ',
			'\u0c54', 'ㆋ', '\u0fb8', '\u0fbd', 'Ⴗ', '⸚', 'ᘴ', '\u1b6e', '౦', 'ㆃ',
			'\u0fb0', '\u0f99', 'Ᏽ', 'ᏻ', 'Ꮃ', '⍅', 'Ẕ', '₠', '₉', '㿹',
			'ė', '㤡', '㑮', '⍽', 'Ẹ', 'ₚ', '\u20ee', '㿕', 'Ŀ', '⅋',
			'⅝', 'ℌ', 'ۑ', 'ᇠ', 'ⰰ', 'ማ', 'ሄ', '൛', '㎵', 'ட',
			'\u06d6', 'ᇩ', 'ⰷ', 'ሀ', 'ሦ', 'ഉ', '㎳', 'ஜ', '\u06da', 'ᇪ',
			'Ⱇ', '\u124f', 'ሽ', '൭', '\uf7c4', '\uf7cb', '\uf78c', '\ue532', '\udd44', '큋',
			'윺', '磌', '쓒', '쒑', '\udb9c', '\ue532', '\udd46', '큋', '윺', '磌',
			'쓐', '쒑', '疸', '疾', '痱', '妹', '杚', '彧', '刭', '䔈',
			'磣', 'ኧ', 'ካ', 'ይ', 'T', '㡐', '㔌', '∆', 'ῑ', '⇬',
			'⇇', '㺚', 'g', '㠡', '㔑', '∢', '颹', '颾', '飲', '\uabe3',
			'뒵', '詗', '뉧', '뼠', 'ꠒ', '门', '魌', '鬙', '鬀', 'ꡂ',
			'띃', '覨', '농', '볞', 'ꮨ', '阺', 'ꠍ', '\ua806', '띏', '覨',
			'놓', '볖', '\uabff', '阱', 'ꠌ', 'ꡂ', '뜇', '観', '놞', '볜',
			'ꮦ', '阵', '\ua80b', 'ꠍ', '띂', '覅', '놋', '볛', '\uabed', '阰',
			'\ua806', 'ꠍ', '띭', '觯', '뇟', '볝', '\uabe4', '阷', 'ꠎ', 'ꡂ',
			'띅', '覤', '놐', '볔', 'ꯊ', '阪', '\ua80b', 'ꠇ', '띀', '覩',
			'놐', '볻', '蛡', '蛪', '蚬', '鐄', '갽', 'ꅼ', '뙑', '讐',
			'떠', '떜', '\uaaef', '鐘', '갠', 'ꅔ', '쌮', '쌡', '썠', '\uf078',
			'\uef1b', '퇋', '\ue9f3', '\ue49b', '\uf3b5', '칙', '\uf06e', '\uf06f', '\uef02', '퇺',
			'\ue9d6', '\ue4ef', '\uf3a8', '칽', '섄', '섁', '셋', '\uf270', '\ued0b', '폢',
			'\uebff', '\ue6b8', '㝿', '㝲', '㜯', 'У', '᭸', '▀', 'ᶠ', 'ტ',
			'\u07fd', '㩍', 'о', 'Ч', '\u1b72', '▙', 'ᶩ', 'კ', 'ꨦ', 'ꨡ',
			'꩷', 'ꝑ', '饥', '饩', '蘩', '룤', '肻', '鵶', '禋', '福',
			'秙', '䫤', '䫪', '喚', '歴', '鬁', '鬃', '魒', '觏', '놝',
			'㚨', '㚬', '㛼', '᱕', 'ᄟ', 'خ', '㮕', '﹨', 'ﹹ', '︽',
			'촑', '쵫', '툤', '\uecbf', '퓻', '\ud9b3', '캕', '\uf357', '쵼', '촜',
			'툧', '\ueca2', '풡', '\ud9b1', '컍', '\uf324', '촗', '\uffc9', 'ￍ', 'ﾟ',
			'쳐', '펝', '\ued74', '핌', '籐', '籗', '簇', '焱', '伇', '伛',
			'偑', '溴', '嚑', '寴', '반', '밗', '뱀', '鯌', '賦', '녹',
			'轘', '轗', '速', '껡', '雃', '鮸', '購', '넪', '輇', '轴',
			'逷', '꺳', '\ue786', '\ue79c', '\ue7df', '퓌', '퓅', '쮑', '\uf561', '쵚',
			'쀱', '휺', '\ueafb', '퓠', '퓃', '쮇', '\uf568', '쵝', '쀱', '휵',
			'\ueaf1', '퓋', '퓾', '쮀', '\uf564', '쵇', '쀵', '휣', '\ueae0', '퓃',
			'퓬', '튩', '튱', '틳', '\uf529', '\ue20c', '\udfdf', '\ue1a3', '\ue1f5', 'ﺮ',
			'쁖', '\uf869', '\uf528', '\ue201', '\udff8', '\ue1f5', '\ue1c3', 'ﺗ', '쁒', '\uf86f',
			'\uf529', '\ue208', '\udfe8', '\ue1d1', '\ue1e0', 'ﺭ', '쁡', '\uf846', '᧾', 'ᦿ',
			'ᦥ', '⫰', '㗱', 'ଚ', '㌿', '㹬', '⤚', 'ᒘ', '⪩', '⪹',
			'㗰', '\u0b55', '㌿', '㹯', '⥎', 'ᒟ', '⪯', '⪼', '㗟', '\u0b58',
			'㌕', '㹎', '⤚', 'ᒋ', '⪴', '⪹', '㗸', 'ଔ', '㌢', '㹦',
			'⥔', 'ᒛ', '⪵', '⪔', 'ￏ', 'ﾀ', 'ﾓ', '\uf2fd', '첆', '첎',
			'폟', '\ued22', '한', '\ud85f', '콮', '\uf2b9', '첊', '첎', '폁', '\ued2a',
			'픋', '\ud854', '콯', '\uf2fd', '쳂', '첕', '폌', '\ued20', '핒', '\ud850',
			'콨', '\uf2b2', '첇', '첣', '폁', '\ued28', '픝', '\ud878', '켣', '\uf2fd',
			'첎', '첍', '폄', '\ued22', '한', '\ud850', '콨', '\uf2b2', '첇', '첣',
			'폁', '\ued28', '픝', '\ud878', '䐼', '䐭', '䑡', '囅', '滪', '掲',
			'璑', '䥂', '睹', '睻', '栬', '囒', '滜', '掤', '璕', '䥶',
			'睽', '睡', '栿', '囵', '왋', '왁', '옕', '\uf6fb', '쬷', '\uf50a',
			'\uf50c', '\uea45', '풃', '\uec80', '\ue1c7', '\uf6ec', '쬉'
		};
		char[] array2 = new char[8];
		array2[2] = 'ツ';
		array2[1] = 'ഒ';
		array2[6] = 'Ɫ';
		array2[0] = '㌤';
		array2[4] = '⪳';
		array2[7] = '㌮';
		array2[3] = '⟴';
		array2[5] = 'ኋ';
		ႥႰ = new string[95];
		ႥႨ = array2;
		UtilsIdentity.Ⴐ();
	}

	internal static string Ⴜ(int P_0, int P_1, byte P_2)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		int num6 = default(int);
		object obj6 = default(object);
		object obj3 = default(object);
		object obj2 = default(object);
		char c = default(char);
		int num7 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = P_1 ^ 0x15C75DC9 ^ P_0;
			object ⴅႥ = ႥႥ;
			while (true)
			{
				IL_0081:
				char[] obj = (char[])ⴅႥ;
				int num2 = obj[num];
				num2 = obj[num + 2] ^ num2;
				int num3 = 5;
				while (true)
				{
					switch (num3)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num3 = 2;
						continue;
					case 2:
						break;
					case 12:
						goto IL_0081;
					case 5:
						num3 = (((enumerable = ((string[])ႥႰ)[num2]) == null) ? 3 : 7);
						continue;
					case 7:
						return enumerable as string;
					case 3:
					{
						char[] obj4 = (char[])ⴅႥ;
						char[] obj5 = (char[])ႥႨ;
						num6 = num;
						obj6 = obj5;
						obj3 = obj4;
						num3 = 15;
						continue;
					}
					case 15:
						obj2 = new StringBuilder();
						goto case 14;
					case 14:
						c = (obj3 as char[])[num6];
						num7 = (obj3 as char[])[num6 + 1] ^ c;
						num3 = ⴃႤ[280] - 457;
						continue;
					case 10:
						num6 += 3;
						num5 = (num7 & 0x1F) | ((num7 & 0xFFC0) >> 1);
						num3 = 6;
						continue;
					case 6:
						num3 = (((num7 & 0x20) == 0) ? (ⴃႭ[36] - 6368) : 16);
						continue;
					case 16:
					{
						int num9 = num5;
						DxCfg.Ⴗ[153] = (char)((DxCfg.Ⴗ[153] | P_0) & 0xB5);
						num5 = (num9 << 15) | ((obj3 as char[])[num6++] ^ c);
						num3 = 11;
						continue;
					}
					case 11:
						num8 = (obj6 as char[]).Length;
						num4 = 1;
						num3 = ⴃႭ[64] - 60307;
						continue;
					case 4:
						((StringBuilder)obj2).Append((char)(c ^ ((char[])obj3)[num6 + num5 - num4] ^ ((char[])obj6)[(num4 + num6 + 17) % num8]));
						num3 = ⴃႭ[97] - 35148;
						continue;
					case 8:
						num4++;
						num3 = 17;
						continue;
					case 17:
						num3 = ((num4 <= num5) ? 4 : (ⴃႭ[95] - 32045));
						continue;
					case 0:
					case 13:
						enumerable = (obj2 as StringBuilder).ToString();
						((string[])ႥႰ)[num2] = enumerable as string;
						num3 = ⴗ[69] - 49315;
						continue;
					case 1:
						return enumerable as string;
					}
					break;
				}
				break;
			}
		}
	}

	internal static string ႥႭ(string P_0, int P_1, int P_2, ႣႼ P_3)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IComparable comparable = default(IComparable);
		int num6 = default(int);
		object obj6 = default(object);
		Array array = default(Array);
		object obj2 = default(object);
		char c = default(char);
		int num8 = default(int);
		int num5 = default(int);
		int num9 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = P_1 ^ 0x253CB7FA ^ P_2;
			object ⴅႤ = ႥႤ;
			while (true)
			{
				IL_0090:
				char[] obj = (char[])ⴅႤ;
				int num2 = obj[num];
				num2 = obj[num + 2] ^ num2;
				int num3 = 11;
				while (true)
				{
					switch (num3)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num3 = 9;
						continue;
					case 9:
					case 15:
						break;
					case 7:
						goto IL_0090;
					case 11:
						num3 = (((comparable = ((string[])ႥႠ)[num2]) == null) ? (ⴗ[36] - 32132) : (ⴗ[42] - 36990));
						continue;
					case 16:
						return comparable as string;
					case 2:
					case 10:
					{
						char[] obj4 = (char[])ⴅႤ;
						char[] obj5 = (char[])ႥႣ;
						num6 = num;
						obj6 = obj5;
						array = obj4;
						num3 = 12;
						continue;
					}
					case 12:
					{
						obj2 = new StringBuilder();
						c = (array as char[])[num6];
						char[] obj3 = (char[])array;
						int num7 = num6;
						DataGridViewColumnSelector.Ⴐ[55] = (char)((DataGridViewColumnSelector.Ⴐ[55] ^ P_2) & 0xAD);
						num8 = obj3[num7 + 1] ^ c;
						num3 = 13;
						continue;
					}
					case 13:
						num6 += 3;
						num5 = (num8 & 0x1F) | ((num8 & 0xFFC0) >> 1);
						num3 = 6;
						continue;
					case 6:
						num3 = (((num8 & 0x20) == 0) ? (ⴀ[20] - 26052) : 17);
						continue;
					case 17:
						num5 = (num5 << 15) | (((char[])array)[num6++] ^ c);
						num3 = ⴃႣ[36] - 35708;
						continue;
					case 4:
						num9 = ((char[])obj6).Length;
						num4 = 1;
						num3 = ⴃႤ[315] - 16722;
						continue;
					case 3:
						((StringBuilder)obj2).Append((char)(c ^ ((char[])array)[num6 + num5 - num4] ^ (obj6 as char[])[(num4 + num6 + 17) % num9]));
						num3 = 5;
						continue;
					case 5:
						num4++;
						num3 = ⴐ[64] - 42821;
						continue;
					case 1:
						num3 = ((num4 <= num5) ? 3 : 0);
						continue;
					case 0:
						comparable = (obj2 as StringBuilder).ToString();
						((string[])ႥႠ)[num2] = comparable as string;
						num3 = ⴃႤ[364] - 11220;
						continue;
					case 8:
						return (string)comparable;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႰႥ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : PictureBox where _0021_00211 : Image
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႭ[100] - 29783;
				continue;
			case 3:
				num = (((P_2 ^ P_3) - 10) ^ num2) switch
				{
					0 => ⴀ[186] - 9565, 
					_ => 4, 
				};
				continue;
			case 4:
				num = 5;
				continue;
			case 8:
				P_0.Image = P_1;
				break;
			case 1:
			case 5:
			case 6:
				break;
			case 2:
			case 7:
				return;
			}
			num2++;
			int num3 = 2002;
			int num4 = 224;
			num = ((1001 < num3 / 2 - num4) ? 3 : 2);
		}
	}

	[SecuritySafeCritical]
	internal static string ႰႰ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : DataGridViewComboBoxColumn
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		IConvertible convertible = default(IConvertible);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[285] - 19062;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[21] - 1868;
					continue;
				case 4:
					break;
				case 5:
					num2 = (((P_1 ^ P_2) - 50) ^ num) switch
					{
						0 => 6, 
						_ => 7, 
					};
					continue;
				case 7:
					convertible = null;
					num2 = 3;
					continue;
				case 6:
					convertible = P_0.ValueMember;
					num2 = ⴃႣ[127] - 15239;
					continue;
				case 3:
					num++;
					goto case 0;
				case 0:
					num3 = 496;
					num4 = 711;
					goto case 11;
				case 11:
					num2 = ((1422 > num4 - num3 * 2) ? (ⴃႤ[427] - 50435) : (ⴃႭ[89] - 23647));
					continue;
				case 2:
					num2 = 5;
					continue;
				case 1:
					return convertible as string;
				case 9:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] ႰႳ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, char P_3) where _0021_00210 : Encoding where _0021_00211 : string
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		Array array = default(Array);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[147] - 1167;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[67] - 59378;
					continue;
				case 3:
					break;
				case 2:
				case 9:
					num2 = (((P_3 ^ P_2) - 65) ^ num) switch
					{
						0 => 1, 
						_ => ⴀ[271] - 42985, 
					};
					continue;
				case 8:
				case 11:
					array = null;
					num2 = 5;
					continue;
				case 1:
					array = P_0.GetBytes(P_1);
					num2 = ⴃႣ[189] - 34279;
					continue;
				case 5:
				{
					num++;
					int num3 = 335;
					int num4 = 522;
					num2 = ((4698 > num4 - num3 * 9) ? (ⴐ[258] - 20696) : 4);
					continue;
				}
				case 4:
					num2 = 9;
					continue;
				case 0:
				case 6:
					return (byte[])array;
				case 7:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float ႰႷ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DxSpot
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
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
					num2 = 1;
					continue;
				case 1:
					break;
				case 3:
					num2 = (((P_2 ^ P_1) - 26) ^ num) switch
					{
						0 => ⴀ[26] - 24310, 
						_ => 6, 
					};
					continue;
				case 6:
					result = (float)Math.PI * 107f / 327f;
					num2 = ⴃႭ[43] - 34342;
					continue;
				case 5:
					result = P_0.Freq;
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = 116;
					goto case 0;
				case 0:
				{
					int num4 = 474;
					num2 = ((1422 > num4 - num3 * 3) ? (ⴐ[262] - 54840) : (ⴀ[22] - 19608));
					continue;
				}
				case 9:
					num2 = ⴃႤ[157] - 29925;
					continue;
				case 2:
				case 10:
					return result;
				case 7:
					num2 = ⴃႭ[216] - 27136;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႰႭ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DxSpot
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႤ[126] - 36866;
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
				case 11:
					num2 = (((P_1 ^ P_2) - 58) ^ num) switch
					{
						0 => 5, 
						1 => 10, 
						_ => ⴃႤ[452] - 24071, 
					};
					continue;
				case 3:
					obj = null;
					goto case 6;
				case 6:
					num2 = 2;
					continue;
				case 5:
					obj = P_0.Comment;
					num2 = ⴀ[174] - 24226;
					continue;
				case 10:
				case 12:
					obj = P_0.ArrlSection;
					num2 = 2;
					continue;
				case 2:
				case 4:
				{
					num++;
					int num3 = 1375;
					num2 = (((num3 * num3 + num3) % 2 == 0) ? 8 : (ⴃႣ[20] - 44812));
					continue;
				}
				case 0:
					num2 = 11;
					continue;
				case 8:
					return (string)obj;
				case 1:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႰႣ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DataGridViewCellPaintingEventArgs
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int result = default(int);
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
					num2 = (((P_1 ^ P_2) - 42) ^ num) switch
					{
						0 => ⴃႣ[84] - 43854, 
						_ => ⴗ[139] - 41091, 
					};
					continue;
				case 1:
					result = 10;
					num2 = 8;
					continue;
				case 5:
					result = P_0.ColumnIndex;
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = P_2 * P_2;
					goto case 2;
				case 2:
				case 6:
					num3 = P_2 + num3;
					goto case 10;
				case 10:
					num2 = 11;
					continue;
				case 11:
					num2 = ((num3 % 2 != 0) ? 3 : 0);
					continue;
				case 0:
					return result;
				case 4:
					num2 = ⴃႣ[199] - 41515;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႰႤ<_0021_00210>(_0021_00210 P_0, byte P_1, short P_2, char P_3) where _0021_00210 : DxSpot
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 2;
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
				num = (((P_3 ^ P_2) - 88) ^ num2) switch
				{
					0 => 6, 
					_ => ⴗ[1] - 50409, 
				};
				break;
			case 0:
				num = 7;
				break;
			case 6:
				P_0.CqZone = P_1;
				goto case 3;
			case 3:
			case 7:
			{
				num2++;
				int num3 = P_1 * P_1 + P_1;
				NeedsCfg.ႣႤ[182] = (NeedsCfg.ႣႤ[182] - P_2) & 0x6D;
				num = ((num3 % 2 == 0) ? 8 : (ⴃႤ[145] - 47530));
				break;
			}
			case 1:
				num = 5;
				break;
			case 8:
			case 9:
				return;
			}
		}
	}
}
