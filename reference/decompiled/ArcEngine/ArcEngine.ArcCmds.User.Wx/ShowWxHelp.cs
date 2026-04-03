using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class ShowWxHelp : IArcCmd
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 7574)]
	private struct Ⴐ
	{
	}

	private static readonly Array Ⴗ;

	private static readonly Array Ⴓ;

	private static readonly Array Ⴃ;

	internal static Ⴐ Ⴅ/* Not supported: data(17 B1 08 B1 17 B1 C0 AD 59 BA 5A 87 72 8E EE AA B8 B6 28 90 8D 82 DB AD 71 BA 78 87 35 8E D6 AA FE B6 0F 90 AF 82 E8 AD 64 BA 46 87 28 8E D6 AA E8 B6 1E 90 A2 82 E8 AD 55 BA 4A 87 3B 8E C3 AA CE B6 36 90 48 89 47 89 49 89 50 A8 F0 BA B6 95 28 82 27 BF 66 B6 8E 92 BC 8E 5C A8 F2 BA 95 95 22 82 25 BF 62 B6 AE 92 5A AF 5D AF 58 AF 9C B4 A3 A8 42 8E EB 9C A8 B3 2E A4 08 99 26 5B 27 5B 25 5B 9A 47 4A 97 43 97 4E 97 9D 8C B8 90 54 B6 F0 A4 99 8B 27 9C 22 A1 60 A8 B5 8C 3B A2 31 A2 3E A2 94 91 C4 BE 4A A9 69 94 08 9D CD B9 96 A5 77 83 92 91 EA BE 9D E4 8D E4 9B E4 4A FF 73 E3 85 C5 2A D7 7D F8 F1 EF F3 D2 95 DB 5B FF 6E E3 8E C5 0F D7 3F F8 AE EF FF D2 86 DB AA BF AB BF AD BF 11 A3 A5 C6 B5 C6 AD C6 4B C1 BD E7 10 F5 59 DA C1 CD F0 F0 9A F9 78 DD 4F C1 8B E7 06 F5 71 DA 9D CD 9D F0 9C F9 56 DD 3A 37 36 37 33 37 33 16 8F 04 CF 2B 52 3C 57 01 32 08 FC 2C CF 30 37 16 B2 04 D2 2B 7F 3C C2 F5 D0 F5 C8 F5 A7 FE A6 C3 FD CA 02 EE 39 F2 CB D4 4A C6 72 E9 B0 FE A6 C3 EA CA 19 EE 2E F2 DA D4 5D C6 72 E9 8C FE 8A C3 49 A7 5C A7 42 A7 68 AC 65 91 22 98 A6 BC AB A0 51 86 F6 94 B7 BB 01 AC 65 91 43 98 A0 BC F3 A0 50 86 F7 94 AD BB 2B AC 2D 91 68 98 9E BC 81 A0 07 18 0C 18 0B 18 7F 27 87 03 FE 1F 2A 39 A8 2B F8 04 76 13 55 2E 3A 27 C2 03 CA 1F 87 47 89 47 8A 47 CE 71 84 78 15 5C 64 40 83 66 25 74 6E 5B AB 4C CB 71 81 78 78 5C 30 40 9E 66 38 74 01 CB 5B CB 0F CB F5 CC 33 EA FA F8 BD D7 66 C0 66 FD 05 F4 93 D0 A1 CC 08 EA AF F8 E1 D7 74 C0 75 FD 25 F4 93 D0 FD CC 13 EA FA F8 F4 D7 70 C0 79 FD 3E F4 93 D0 FE CC 14 EA AE F8 B1 D7 74 C0 65 FD 19 F4 93 D0 B6 CC 5C EA FA F8 B1 D7 74 C0 75 FD 3A F4 C7 D0 EE CC 33 EA FA F8 F4 D7 63 C0 6E FD 3F F4 DC D0 F5 CC 12 EA 9B F8 B1 D7 74 C0 45 FD 19 F4 93 D0 BB CC 5C EA 55 87 57 87 5A 87 9D 9B 00 8C F4 17 F1 17 E4 17 3A 0B C7 1C C4 21 FC 28 16 0C 03 47 17 47 12 47 5F 4C 70 71 2D 78 C2 5C CC 40 25 66 F8 74 DE 5B 4D 4C 50 71 0E 78 91 5C B3 40 5E 66 8C 74 D0 5B 47 4C 4E 71 0D 78 E2 5C 4C 25 42 25 5E 25 B2 39 22 2E 24 13 73 1A 9F 3E A4 22 44 04 F0 16 B5 39 2B 2E 23 13 68 1A BD 3E 96 22 28 61 36 61 3B 61 9F 52 D4 7D 48 6A 6A 57 23 5E A7 7A DE 66 39 40 92 52 FB 7D 09 6A 6C 57 31 5E DF 7A FA 66 02 40 D3 52 E5 7D 5B 6A 4C 57 10 5E CF 7A E9 66 75 40 B6 52 EC 7D 6C 6A 65 57 26 5E DE 7A 2B CD 35 CD 3F CD 76 EC CA FE D5 D1 45 C6 43 FB 14 F2 F8 D6 C3 CA 23 EC 97 FE D2 D1 4C C6 44 FB 0F F2 FA D6 91 CA 24 EC 95 FE C8 D1 5F C6 0A FB 04 F2 FC D6 C5 CA 35 EC 95 FE C9 D1 58 C6 45 FB 23 F2 AB 58 AC 58 BE 58 60 43 54 5F 9D 79 15 6B 4B 44 DF 53 EE 6E 92 19 99 19 84 19 CF 38 73 2A 76 05 E6 12 E3 2F AD 26 55 02 47 1E CF 38 69 2A 22 05 78 9D 6A 9D 6F 9D 57 96 1D AB 56 A2 B8 86 83 9A 60 BC CF AE 8B 81 59 96 04 AB 03 A2 B1 86 C2 9A 6A BC D1 AE 8B 81 18 96 34 AB 80 CF 85 CF 98 CF C6 C4 D4 F9 89 F0 77 D4 5E C8 DD F1 8A F1 C4 F1 63 C2 29 ED B3 FA B2 C7 B6 CE 0A EA 2F F6 D4 D0 26 C2 3F ED B3 FA BA C7 B6 CE 0A EA 2A F6 C9 D0 72 C2 3D ED A9 FA FC C7 F3 CE 07 EA 33 F6 80 D0 75 C2 3A ED B3 FA B4 C7 C5 CE 4F EA 6A F6 80 D0 26 C2 6D ED FC FA FC C7 B6 CE 4F EA 67 F6 80 D0 63 C2 20 ED B5 FA A8 C7 C6 CE 3A EA 67 F6 D7 D0 69 C2 05 ED 8F FA FC C7 B6 CE 4F EA 67 F6 76 92 FA 92 6C 92 C9 8E 03 99 19 A4 58 AD AD 89 80 95 48 B3 CE A1 94 8E 36 99 03 A4 4E AD A1 89 98 95 6A B3 E1 A1 C9 8E 41 99 05 A4 58 AD 92 89 8F 95 79 B3 EC A1 C9 8E 04 99 12 A4 4E AD A5 89 89 95 67 B3 C8 A1 B4 8E 14 99 05 A4 7C AD EB 89 9E 95 6E B3 D9 A1 95 8E 02 99 1B A4 7E AD B6 89 AD 95 24 B3 D9 A1 83 8E 19 99 59 A4 56 AD F1 89 8E 95 6A B3 83 A1 96 8E 03 99 11 A4 12 AD EB 89 D6 95 7B B3 D9 A1 80 8E 57 99 4D A4 49 AD A5 89 CC 95 7F B3 C3 A1 83 8E 1E 99 1B A4 7E AD BE 36 B2 36 A5 36 E5 3D D2 00 98 09 44 2D 6C 31 E3 17 28 05 63 2A F2 3D 92 00 91 09 68 2D D8 BB DD BB C4 BB F9 B0 BC 8D F7 84 4A A0 62 BC 9D BF 95 BF 80 BF D1 9E 73 8C 6E A3 CC B4 FB 89 B8 80 46 A4 57 B8 45 15 5D 15 5B 15 7A 2A 96 0E BB 12 16 34 F5 26 B6 09 2B 1E 28 23 4C 2A 9B 0E B3 12 59 34 DD 26 89 09 34 1E 31 23 7A 2A 92 0E 8C 12 64 34 F9 26 B3 09 07 1E 18 23 14 20 0C 20 0B 20 F0 3C 74 2B 71 16 71 1F D4 3B EB 27 1D 01 BC 13 F1 3C 79 2B 56 16 27 1F E2 3B D2 27 19 01 BA 13 F0 3C 70 2B 46 16 03 1F C1 3B E8 27 2A 01 93 13 7C 2F 7A 2F 5C 2F 9A 1C 89 33 13 24 14 19 7B 10 EE 34 DF C3 CB C3 FE C3 6F DF BB C8 B6 F5 F7 FC 0C D8 26 C4 82 E2 70 F0 3C DF B7 C8 92 F5 E6 FC 08 D8 31 C4 D1 E2 71 F0 23 DF 9D C8 A6 F5 D0 FC D1 9A C3 9A F3 9A FF A5 0B 81 28 9D CD BB 49 A9 35 86 A3 91 B9 AC D6 A5 11 81 2E 9D D8 BB 79 A9 34 86 BC 91 93 AC E2 A5 27 81 C6 B1 D6 B1 E5 B1 33 AD AF BA A4 87 EC 8E 37 AA 28 B6 C3 90 58 82 3D AD A8 BA A8 87 CF 8E 18 AA 30 B6 DA 90 5E 82 4E 27 41 27 6A 27 56 06 F6 14 B0 3B 2E 2C 21 11 60 18 88 3C BA 20 5A 06 F4 14 93 3B 3D 2C 2A 11 76 18 A9 3C EF 0E FE 0E CA 0E 9A 38 C5 31 39 15 5B 09 F7 2F 59 3D 10 12 8D 05 82 38 C1 31 0A 15 04 09 E2 2F 76 3D 08 12 89 05 AF 38 25 7C A6 7C 03 7C EB 67 9F 7B 78 5D DE 4F 95 60 04 77 04 4A 4E 43 B7 67 D0 7B 2D 5D A6 4F DE 60 14 77 16 4A 04 43 A2 67 CE 7B 2C 5D C9 4F 88 60 52 77 1B 4A 06 43 F4 67 CB 7B 39 5D 89 4F 9A 60 49 77 4B 4A 0D 43 B9 67 DA 7B 3A 5D 8B 4F C1 60 51 77 4B 4A 17 43 B9 67 C8 7B 2F 5D 89 4F 9A 60 0B 77 1E 4A 1E 43 E3 67 CB 7B 30 5D DE 4F 95 60 1E 77 50 4A 0F 43 B7 67 D0 7B 35 5D 9B 4F F1 60 04 77 04 4A 4E 43 B7 67 9F 7B 24 5D F6 91 EF 91 D1 91 46 8D DA 9A D7 A7 E0 AE 30 8A 02 96 EE B0 40 A2 0B 8D 98 9A 94 A7 9D AE 20 8A 0D 96 E9 B0 76 A2 46 8D 93 9A 92 A7 C9 AE 27 8A 09 96 E1 B0 48 A2 34 8D 34 52 2A 52 1C 52 CF 61 89 4E 15 59 68 64 1C 6D EF 49 DC 55 2C 73 82 61 D1 4E 5B 59 15 64 13 6D EA 49 CF 55 69 73 83 61 C8 4E 54 59 56 64 24 6D A6 49 CA 55 2C 73 9B 61 C7 4E 50 59 5F 64 1A 6D D4 49 5C A2 5D A2 75 A2 28 9D F2 52 E2 52 D8 52 16 4E 9D 59 96 64 D0 6D 2C 49 2B 55 FD 73 4C 61 14 4E 81 59 96 64 EA 6D 38 49 10 55 EC 73 79 61 AD 5D AC 5D 86 5D 63 46 82 0E 95 0E AE 0E AA 38 AD 31 5E 15 6D 09 90 2F 3F 3D 32 12 F0 05 E7 38 BB 31 5F 15 7B 09 9A 2F 2B 3D 32 12 E8 05 EF 38 A8 31 44 15 38 09 90 2F 37 3D 3A 12 79 4A 7B 4A 54 4A 8D 4D 6B 6B 2C 79 26 79 02 79 C5 65 59 72 44 4F 0B 46 F7 62 D4 7E 30 58 87 4A DD 65 6E 72 1F F9 13 F9 30 F9 6A F2 6C CF 35 C6 83 E2 E0 FE 11 D8 AA CA EA E5 7D F2 77 CF 18 C6 F1 E2 63 D9 64 D9 53 D9 D6 EA 9C C5 0B D2 11 EF 5A E6 B4 C2 AF DE AA C7 AC C7 9B C7 E9 E6 12 F4 48 DB EA CC 84 F1 DD F8 60 E2 63 E2 52 E2 93 FE 13 E9 20 D4 B4 7D BF 7D 87 7D D0 4B 93 42 6F 66 68 7A AC 5C 1C 4E 4A 61 D0 76 D6 4B 96 42 4A 66 30 3F 34 3F 04 3F 0B 00 EE 24 CF 38 05 1E 2D FE 20 FE 18 FE 03 C1 FC E5 D9 F9 31 DF 98 CD D8 E2 58 F5 42 C8 0F C1 FE E5 FA F9 28 DF A1 CD AD E5 A7 E5 9B E5 A4 C4 18 D6 48 F9 C3 EE EF D3 9E DA 5B FE 43 E2 B5 C4 25 D6 6D 58 66 58 5A 58 89 44 19 53 1C 6E 52 67 AA 43 B8 5F 68 79 F2 6B 89 44 09 53 3F 6E B7 6F B9 6F 8F 6F 1C 5C 4B 73 D3 64 FE 59 88 50 6B 74 58 68 A5 4E 2F 5C 5F 73 F2 64 C2 59 99 50 56 74 E2 11 F2 11 DB 11 20 0A 14 16 FA 30 71 22 06 0D 8F 1A 96 27 C8 2E 36 0A 1D 16 DB 30 41 22 36 0D 97 1A 86 27 FA 2E A4 8B B0 8B 9E 8B 4C 8C BC AA 0B B8 5A 97 D0 80 CA BD AC B4 73 90 5D 8C B7 AA 1E B8 59 97 D7 80 CA BD 89 B4 64 90 5B 8C 89 AA 07 B8 70 97 6C A5 67 A5 57 A5 C5 96 99 B9 1E AE 38 93 4B 9A B2 BE 83 A2 57 84 D9 96 92 B9 2C AE C6 0F CA 0F FA 0F 24 13 A2 04 B3 39 E1 30 1D 14 1A 08 D5 2E 73 3C 17 13 B3 04 A2 39 DE 30 DF AD D4 AD E2 AD AE 9B F8 92 08 B6 0D AA CC 8C 6A 9E 0E B1 A9 A6 B1 9B FC 92 3E B6 D2 03 DC 03 EC 03 A3 08 BF 35 FC 3C 28 18 2D 04 CB 22 66 30 0F 1F BD 08 BD 35 D8 3C 14 18 2D 04 FC 22 09 07 03 07 36 07 CF 1C FD 00 01 26 BD 34 DA 1B 70 0C 5F 31 36 38 DE 1C C0 00 F5 21 F3 21 B5 21 C6 1E 10 3A 18 26 E7 00 46 12 36 3D AE D5 A0 D5 EF D5 DF E3 89 EA 79 CE 7C D2 A7 F4 1B E6 4B C9 C0 DE EC E3 9D EA 4B CE 40 D2 B6 F4 26 E6 CD 77 CA 77 8F 77 2B 6B BB 7C 9B 41 F1 48 10 6C 3F 70 E3 56 27 54 23 54 64 54 06 5F 06 62 66 6B 98 4F B4 AC BE AC F0 AC 68 B7 47 AB AE 8D 00 9F 68 B0 E9 A7 D2 9A 99 93 45 B7 72 AB 3B 19 29 19 7E 19 90 2A C7 05 5F 12 72 2F 03 26 E7 02 CE 1E 2F 38 94 2A DB 05 75 12 4C 2F 07 26 DE 02 D6 1E 29 38 88 2A F8 05 07 60 17 60 41 60 C6 7B F2 67 08 41 BF 53 F6 7C 4B 6B 68 56 23 5F DC 7B E9 67 1B 41 A8 53 C4 7C 72 6B 63 56 1F 5F 05 09 0E 09 42 09 16 28 B1 3A FC 15 70 02 65 3F 3A 36 E4 12 E8 0E 17 28 B6 3A C6 15 DD CA D6 CA 95 CA 6D D6 B2 C1 B3 FC FF F5 1C D1 35 CD C5 EB 50 F9 6D D6 F1 C1 FC FC 54 93 52 93 1D 93 FC A0 B0 8F 27 98 3A A5 6F AC C6 88 F5 0E E1 0E BF 0E 15 12 98 05 91 38 F6 31 29 15 00 09 C4 2F 5A 3D 04 12 B8 05 9A 38 D1 31 2E 15 1B 09 E9 2F 5A 3D 36 12 80 05 91 38 ED 31 CF 2A CB 2A 84 2A CE 21 CE 1C 84 15 2F 31 BA 05 B5 05 F6 05 11 36 46 19 DE 0E F3 33 9F 3A 67 1E 49 02 B3 24 00 36 5E 19 E8 0E CC 33 9E 3A 60 1E 73 02 E4 BB F4 BB A9 BB 2A A0 5E BC B9 9A 1F 88 54 A7 C5 B0 C5 8D 8F 84 76 A0 5E BC B9 9A 1F 88 08 A7 C5 B0 C5 8D 8F 84 F6 8E FD 8E B8 8E EC AF 43 BD 0F 92 93 85 96 B8 D8 B1 0C 95 1B 89 E4 AF 45 BD 35 92 08 85 02 85 47 85 6C 8E 64 B3 2A BA CE 9E E2 82 20 A4 A4 B6 F7 99 61 8E 5A B3 B2 78 A1 78 E2 78 D7 47 64 63 4D 7F BD 59 08 4B 47 64 DF 73 D0 4E D9 47 73 63 45 7F A0 59 06 4B 50 64 93 73 C7 4E 98 47 68 63 6B 7F 55 99 43 99 04 99 24 AF 72 A6 82 82 87 9E 46 B8 E1 AA AC 85 20 92 35 AF 6A A6 B4 82 BB 9E 5B B8 EB AA B1 85 3A 92 3B AF 5D A6 90 82 A0 9E 40 B8 DD AA 59 5D 5C 5D 0B 5D 2A 6B 73 62 8E 46 AF 5A 67 7C 2C F4 25 F4 7F F4 22 D5 92 C7 D8 E8 42 FF 63 C2 10 CB F1 EF DE F3 02 D5 3B DD 30 DD 6F DD DB C1 56 D6 5F EB 38 E2 E2 C6 D3 DA 29 FC 97 EE DF C1 5F D6 74 EB 90 97 9D 97 C5 97 70 8B FD 9C F4 A1 93 A8 51 8C 6F 90 89 B6 24 A4 4E 8B E6 9C FE A1 B3 A8 71 8C E3 E0 EA E0 B5 E0 28 FB 0D E7 DD C1 4B D3 0B FC A6 EB 96 D6 CD DF 02 FB 4E 31 44 31 19 31 F7 02 B1 2D 0D 3A 37 07 41 0E 93 2A 9A 36 47 10 F0 02 8D 2D 30 DE 37 DE 68 DE DA D9 28 FF 8E ED E2 C2 45 D5 54 E8 28 E1 65 42 77 42 3C 42 C5 5E 56 49 07 74 7E 7D B3 59 91 45 6D 63 D1 71 87 5E 05 49 0A 74 5C 7D A2 59 AB 45 6C 63 D7 71 9B 5E 2D 49 10 42 18 42 4A 42 FC 45 1A 63 9C 71 EF 5E 5F 49 65 74 3E 7D F1 59 6D 15 67 15 36 15 84 09 18 1E 2F 23 54 2A BA 0E 83 12 64 34 D9 26 8D 09 3F 1E 49 83 4E 83 15 83 46 A2 F7 B0 B4 9F 25 88 21 B5 69 BC A8 98 B7 D6 BD D6 EA D6 C2 DD D8 E0 BF E9 7C CD 59 D1 89 F7 01 E5 4E CA DD DD E5 E0 31 82 2A 82 6F 82 0E BD E6 99 C5 85 62 A3 84 B1 CE 9E 53 89 51 B4 1F BD C1 99 CE 85 3F A3 98 B1 C4 9E 46 89 55 B4 28 BD AD 99 D9 85 29 A3 9E B1 D2 9E 45 89 5C B4 39 BD F1 99 EA 85 53 A4 4B A4 0C A4 B7 B8 37 AF 3C 92 36 9B 8F BF A6 A3 4D 85 E9 97 A6 B8 30 AF 37 92 6B 9B 93 BF AC A3 58 85 ED 97 B1 B8 7C AF 26 92 7D 9B 8F BF A5 A3 4B 85 FC 97 8A 9E 8D 9E EA 9E B9 BF 12 AD 58 82 B9 95 DD A8 84 A1 6A 85 E9 4B F8 4B 88 4B 8F 7D D0 74 34 50 5D 4C E0 6A 53 78 11 57 8B 40 87 7D CB 74 3F 50 12 4C E6 6A 1C 78 1A 57 9A 40 81 7D B8 3B BD 3B DA 3B E1 0D B7 04 5B 20 61 3C E6 1A D2 38 D9 38 B1 38 51 23 66 3F 9F 19 27 0B 7A 24 E5 33 E2 0E B7 07 52 23 71 3F 9E 19 AA D2 A7 D2 CE D2 6C C9 55 D5 B9 F3 5F E1 62 CE F9 D9 F1 E4 D8 ED 4F C9 1E D5 B4 F3 09 E1 5E CE 05 25 03 25 60 25 7A 1A 9A 3E DE 22 28 04 E7 16 C2 39 6C 4C 63 4C 0A 4C 19 47 08 7A 49 73 F0 57 8E 4B 64 6D C3 7F 92 50 08 47 1D 7A 09 73 BA 57 99 4B 26 6D D9 7F 28 C0 2C C0 4F C0 6D F6 2C FF AD DB FC C7 A4 67 AC 67 CC 67 12 54 5B 7B C6 6C 8B 51 9D 58 7A 7C 0D 60 B2 46 5B D9 19 D9 32 D9 2E EF 71 E6 8D C2 EF DE 48 F8 C5 EA 97 C5 31 D2 35 EF 7F E6 8B C2 AD DE 4A F8 E1 EA 88 C5 3F D2 0C EF 63 E6 BC C2 9D DE 55 F8 E4 EA AA C5 35 D2 36 EF 7E E6 9E C2 AE DE 62 F8 DC EA AC C5 3C D2 19 EF 4C E6 D5 B2 92 B2 BF B2 31 AE AC B9 A0 84 B0 8D 15 A9 3A B5 CD 93 7A 81 24 AE B9 B9 B5 84 C2 8D 0C A9 20 B5 C7 93 6C 81 29 AE B8 B9 B5 84 DD 8D 02 A9 19 B5 DB 93 5B 81 19 AE A7 B9 B0 84 FF 8D 08 A9 23 B5 C6 93 79 81 2A AE 90 B9 88 84 F9 8D 01 A9 0C B5 F4 93 DA AB 8A AB B1 AB 2B AC C8 8A 6E 98 28 B7 B7 A0 B7 9D F0 94 2B B0 25 AC F1 8A 72 98 1F B7 87 A0 A8 9D F5 94 09 B0 2F AC CB 8A 6F 98 3D B7 B4 A0 9F 9D CD 94 0F B0 26 AC E4 8A 5D 98 6A B7 B4 A0 AF 9D B1 94 0D B0 2C AC CE 8A 67 98 6A B7 9E A0 8D 9D B1 94 0F B0 2E AC CE 8A 71 98 3A B7 B2 A0 81 9D FF 94 3D B0 38 EF 30 EF 54 EF 4A D9 17 D0 E4 F4 CD E8 26 CE 86 DC DB F3 19 E4 DE BA D5 BA B3 BA 14 A1 00 BD 83 9B 48 89 01 A6 8D B1 99 8C B5 85 46 A1 64 BD 8A 9B B4 52 AB 52 DA 52 95 64 CF 6D 36 49 1E 55 F9 73 5C 61 04 4E 89 59 95 64 8E 6D 63 49 5C 55 8F 73 4F 61 60 4E FB 59 F4 64 DF 6D 36 49 1E 55 FE 73 5E 61 04 4E 8B 59 95 64 8E 6D 63 49 5C 55 8F 73 4F 61 04 4E D1 B3 85 B3 BE B3 90 8C 6E A8 32 B4 D8 92 63 80 37 AF B9 B8 A4 85 F9 8C 22 A8 6B B4 CA 92 65 80 61 AF A4 B8 A2 85 FB 8C 0B A8 08 B4 8C 92 79 80 24 AF B9 B8 A4 85 F3 8C 17 A8 25 B4 E9 92 25 80 02 AF 93 B8 88 85 DE 8C 43 A8 6B B4 8C 92 2A 80 61 AF F0 B8 F0 85 BA 8C 43 A8 6B B4 8C 92 2A 80 61 AF F0 B8 F0 85 BA 8C 43 A8 6B B4 8C 92 EB 82 E5 82 9B 82 CA B4 9A BD 2A 99 1F 85 F9 A3 59 B1 0F 9E 8B 89 9E B4 F3 BD 79 99 05 85 F9 A3 64 B1 9C 06 8E 06 ED 06 26 01 DB 27 34 35 78 1A F2 0D ED 30 84 39 4B 1D 6E 01 82 27 26 35 4F 1A BD 0D E9 30 B8 39 7A 1D 26 01 C1 27 BB 2C BF 2C C9 2C 9F 0D 34 1F 7F 30 E8 27 6F 76 6C 76 1C 76 D1 6A 5E 7D 5D 40 87 50 84 50 F3 50 A8 66 FC 6F 04 4B A5 0F A7 0F D0 0F 11 08 8F 2E CC 29 C9 29 BA 29 33 2E C5 08 76 1A 28 35 BE 22 64 8A 62 8A 13 8A B3 91 90 8D 76 AB C5 B9 85 96 06 81 C9 F4 C5 F4 B1 F4 36 F3 C0 D5 73 C7 2D E8 BB FF BA C2 E7 CB 0F EF 27 F3 DB D5 62 C7 2A E8 80 46 9F 46 F9 46 EB 79 08 5D 7E 41 93 67 3A 75 7D 5A EC 4D EE 70 A8 79 12 5D 2F 41 85 67 3F 75 60 5A EE 4D A1 70 AC 79 5C 5D 73 41 89 67 2E 75 73 5A E4 4D F9 70 AE 79 12 5D 68 41 92 67 29 75 62 5A C4 4D F6 75 FF 75 8C 75 1F 46 57 69 94 7E A7 43 C5 4A 13 6E 02 72 E5 54 6C 46 50 6A 44 6A 2B 6A 8E 76 14 61 01 5C 54 55 C2 71 F0 6D 42 4B FF 59 E0 76 25 61 34 5C 68 55 C2 71 AF 6D 49 4B E4 59 AD 76 71 61 09 5C 4C 55 2A D7 2C D7 56 D7 D1 E4 80 CB 4E DC 46 E1 00 E8 D6 CC 9B 4A 98 4A E6 4A BA 41 A0 7C 8D 75 BB 85 BF 85 C5 85 F8 B3 A3 BA 5A 9E 0C 82 24 F4 70 F4 5B F4 01 CB D9 EF 9E F3 75 D5 99 C7 D2 E8 6A FF 05 C2 55 CB E2 EF CB F3 29 D5 8B C7 C1 E8 4A FF 05 C2 09 CB F9 EF 9E F3 3C D5 8F C7 CD E8 51 FF 05 C2 0A CB FE EF CA F3 79 D5 8B C7 D1 E8 76 FF 05 C2 42 CB B6 EF 9E F3 79 D5 8B C7 C1 E8 55 FF 51 C2 1A CB D9 EF 9E F3 01 D5 A8 C7 94 E8 51 FF 60 C2 3C CB B6 EF 9E F3 79 D5 24 11 21 11 A4 11 4F 2E B6 0A 8E 16 77 30 CF 22 A0 6A A9 6A 21 6A 42 59 01 76 D3 61 E0 5C 93 55 45 71 54 6D B3 4B 3A 59 44 8C 4A 8C C6 8C 5C AD FC BF BA 90 24 87 2B BA 6A B3 82 97 B0 8B 50 AD FE BF 99 90 33 87 32 BA 58 B3 CF B9 C1 B9 4C B9 3A BE FB 98 66 8A 3A A5 B8 B2 BC 8F E1 86 2E A2 24 BE C2 98 56 8A 28 A5 A9 B2 8F 8F 2D 80 36 80 A9 80 82 B3 DC 9C 48 8B 02 B6 0D BF FC 9B D8 87 3C A1 B4 B3 C9 9C 4F 8B 49 B6 08 BF F1 9B D8 87 13 A1 AA B3 CD 9C 59 8B 58 B6 03 BF CC 9B EB 87 37 A1 90 B3 FE 9C 70 8B 24 56 25 56 A1 56 47 69 5D B2 52 B2 DB B2 22 B9 02 84 48 8D DF A9 99 B5 15 93 D8 81 FC AE 02 B9 6D 84 48 8D D7 A9 F6 B5 72 93 C7 81 AD 53 BB 53 2A 53 1D 4F 96 58 C1 65 89 6C 6D 48 51 54 F0 72 18 60 52 4F C5 58 D8 65 85 6C 7A 48 59 54 BE 72 19 60 5E 4F 8C 58 D4 65 9E 6C 5C 48 67 54 EA 4C FF 4C 62 4C 40 50 85 47 84 7A C8 73 2C 57 11 4B F3 6D 58 7F 16 50 8A 47 9D 7A 81 73 2A 57 15 4B E3 6D 5D 7F 13 50 AD 47 CB 7A F9 73 1C 57 2F 9D 29 9D A6 9D D4 AE DA 81 4A 96 0E AB 1C A2 F9 86 88 8C 8E 8C 02 8C CF AD 3D BF 71 90 EE 87 E6 BA AF B3 E0 03 EE 03 6B 03 15 04 D4 22 49 30 15 1F 97 08 93 35 CE 3C 01 18 0E 04 F8 22 55 30 1C 1F 84 08 B5 35 B9 E4 B5 E4 35 E4 AB C5 2B D7 5B F8 DD EF CE D2 80 DB 6E FF 70 E3 BC C5 1A D7 4A F8 E8 EF 0A 35 18 35 87 35 6F 3E 6E 03 35 0A DB 2E F5 32 19 14 BF 06 F5 29 68 3E 78 03 28 0A FC 2E B0 32 2F 14 95 06 CB 29 48 3E 28 03 14 42 18 42 9A 42 7A 74 16 7D D4 59 EB 45 1F 63 BD 71 E1 5E 46 49 21 74 3C 7D D4 59 CF 45 52 23 14 23 DD 23 73 28 69 15 7D 1C 8E 38 A9 24 42 02 E4 10 AD 3F 30 28 73 15 71 1C 94 38 99 24 62 02 C8 10 8A 3F 73 28 24 15 76 1C 88 38 9B 24 0F 02 EE 10 AC 3F 3A 28 20 15 6A 1C 85 38 AB 24 40 02 FB 10 B2 3F 73 28 21 15 76 1C 92 38 BA 24 6A 02 B0 EF BE EF 20 EF 00 F3 8B E4 D4 D9 95 D0 6D F4 70 E8 ED CE 4B DC 75 F3 E5 E4 F8 D9 DB D0 22 F4 0A E8 3D 8E 2D 8E AC 8E 87 89 7A AF 96 BD C4 92 66 85 1C B8 05 B1 FC 95 C2 89 32 AF 82 BD C9 92 7D 85 1C B8 56 B1 AF 95 80 92 88 92 12 92 A1 A4 F1 AD 7E 89 49 95 AC B3 7B A1 30 8E A1 99 AD 7C A2 7C 3E 7C 1D 60 96 77 D8 4A 83 43 6C 67 51 7B B6 5D 39 4F 1D 60 EF 77 F8 4A B3 43 3F 67 17 7B F0 5D FD A9 F5 A9 69 A9 01 AE E9 88 42 9A 0C B5 A3 A2 8E 9F D2 96 2E B2 C2 0B C5 0B 57 0B FA 34 00 10 2D 0C D4 2A 76 38 3D 17 AF 00 CD 53 DA 53 5B 53 EC 58 A9 65 EE 6C 1C 48 36 54 D3 72 36 60 3E 4F A5 58 A0 65 E4 6C 0A 48 27 54 90 72 7B 60 32 4F A3 58 BE 65 AB 6C 0B 48 36 54 D8 72 55 60 E6 8E E7 8E 71 8E 2D 89 1D 22 1C 22 85 22 52 29 52 B1 54 B1 CB B1 E2 AD 69 BA 3F 87 75 8E 81 AA 8B B6 08 44 01 44 92 44 C2 5F F6 43 1C 65 FD 77 F3 58 56 4F 6A 72 20 7B DC 5F 2A 8C 21 8C B1 8C 77 AD CC BF 9A 90 5F 87 59 BA 00 B3 EC 97 E3 8B 77 AD DC BF 9A 90 0D AF 1B AF 91 AF B0 A8 4D 8E 85 9C C9 B3 48 A4 2C 99 12 90 FA B4 C4 A8 50 8E A2 9C E8 B3 63 A4 6E 99 07 90 9F B4 F2 A8 04 8E B7 9C F9 B3 7C A4 59 99 1A E2 19 E2 87 E2 E6 D1 A6 FE 3C E9 FD E8 6E E8 63 E8 D2 E3 98 DE D3 D7 24 F3 04 EF EF C9 4A DB 0F F4 DC E3 99 DE C4 D7 2E F3 47 EF F3 C9 4A DB 01 F4 9D E3 9F DE 96 D7 2A F3 14 EF E5 C9 4E DB 19 F4 DC E3 91 DE D9 D7 3D F3 01 EF A0 C9 55 DB 19 F4 93 E3 8C DE E5 D7 6F F3 47 EF AE C9 55 DB 1F F4 99 E3 8F DE C3 D7 2D F3 06 EF A0 C9 54 DB 08 F4 88 E3 8F DE C3 D7 23 F3 04 EF A0 C9 40 DB 02 F4 DC E3 88 DE C5 D7 26 F3 0B EF A0 C9 67 DB 4D F4 D1 E3 DC DE C2 D7 3C F3 0E EF CC C9 06 DB 06 F4 9F E3 93 DE DA D7 0D F3 47 EF EC C9 4A DB 0C F4 BF E3 DC DE 95 D7 0A 1D 01 1D 95 1D 2E 22 F1 06 E2 1A 12 3C A7 2E E8 01 6E 16 58 2B 39 22 CA 06 D1 1A A1 53 A7 53 01 53 CE 65 89 6C 51 48 4D 54 B9 72 28 60 AF BE B7 BE 0E BE 54 8D 05 A2 C0 B5 C1 88 8D 81 69 A5 45 B9 B7 9F 17 8D 47 A2 EB B5 8E 88 C9 81 3D A5 41 B9 BC 9F 11 8D 56 A2 C2 B5 ED 88 D0 81 7E A5 47 B9 93 9F B7 9A B5 9A 15 9A 8E AC CD A5 99 84 D7 84 3A 84 EA 8F FD B2 B0 BB 46 9F 76 83 8A A5 62 B7 6C 98 F6 8F F7 B2 BA BB 5B 9F 23 83 96 A5 37 B7 66 98 E1 8F B8 B2 A6 BB 4E 9F 50 83 C4 A5 6F B7 29 98 B8 8F FD B2 BC BB 44 9F 4B 83 B4 A5 62 B7 67 98 F7 8F F1 B2 A6 BB 4A 9F 77 83 B7 A5 62 B7 7D 98 DD 8F CB B2 F2 BB 0B 9F 23 83 C4 A5 9B 2E 96 2E 3F 2E EE 25 FB 18 B4 11 07 35 65 29 94 0F 2F 1D 5C 32 FE 25 FB 18 92 11 50 35 4C 29 E3 98 A6 98 46 98 C2 93 D8 AE C5 A7 3E 83 0B 9F F8 B9 18 AB 17 84 87 93 86 AE C9 A7 3E 83 15 9F BE B9 15 AB 53 84 87 93 8A AE CB A7 30 83 1A 9F BE B9 18 AB 16 84 8A 93 81 AE C9 A7 32 83 59 9F FA B9 4A AB 1C 84 95 93 C2 AE CC A7 30 83 3B 9F A5 33 AB 33 03 33 50 2F C7 38 CA 05 8F 0C 79 28 5A 34 AC 12 10 00 5C 2F C5 38 E9 05 80 0C 79 28 7E 34 C7 2C D7 2C 60 2C 2F 2B D5 0D 6F 1F 24 30 A3 27 A5 1A E3 13 07 37 0D 2B DE 0D 71 1F 14 30 A3 27 A2 1A E3 13 3B 37 3E 54 2F 54 96 54 1F 5F 05 62 1A 6B F8 4F 84 53 37 75 80 67 DD 48 1F 5F 5A 62 11 6B F9 4F D0 53 2A 75 91 67 CF 48 73 5F 0C D9 01 D9 A5 D9 2D D2 37 EF 28 E6 CA C2 B6 DE 05 F8 B2 EA EF C5 2D D2 6F EF 32 E6 D2 C2 D5 DE 85 29 90 29 2F 29 A4 22 BE 1F A1 16 43 32 3F 2E 8C 08 3B 1A 66 35 A4 22 E1 1F AA 16 42 32 6B 2E 91 08 39 1A 7B 35 EB 22 C8 1F EE 16 17 32 3F 2E 56 B3 55 B3 FD B3 6B 8C 93 A8 9B B4 1B 83 1F 83 B7 83 C0 98 E7 84 35 A2 80 B0 EC 25 EE 25 41 25 7C 16 3C 39 AA A5 A5 A5 04 A5 10 A2 ED 84 14 96 54 B9 C4 AE F1 93 C1 9A 49 BE 73 A2 F7 84 51 96 1A B9 8B AE 8B 93 C1 9A C0 BF CD BF 6F BF 2A B8 C8 9E 70 8C 3F A3 AE B4 8D 89 EF 80 1F A4 19 B8 D8 9E 7F 8C 3F A3 8F B4 6D 04 20 04 DD 04 D9 03 77 25 D8 37 94 18 0F 0F 02 32 5F 3B AC 1F DA 03 75 25 E4 37 DD 18 40 0F 08 32 48 3B AA 1F 98 03 76 25 96 37 89 18 03 0F 02 32 06 3B B8 1F 96 03 64 25 96 37 99 18 01 0F 2F 32 54 3B BE 1F D7 03 3D 25 96 37 89 18 02 0F 09 32 4F 3B B3 1F B4 03 24 25 D5 37 8F 18 2D 0F A5 52 A8 52 14 52 71 55 97 73 5E 61 0F 4E D0 59 D1 64 9E 6D 63 49 4A 55 97 73 5E 61 15 4E 84 59 9F 7A 95 7A 2D 7A 39 66 AC 71 FD 4C 84 45 59 61 6A 7D 92 5B 17 49 77 66 DA 71 ED 48 E2 48 5E 48 F2 69 53 7B 2A 54 82 43 8F 7E E4 77 29 53 12 4F C2 69 42 7B 12 54 9C 43 BF 7E DE 77 1B 53 19 B8 1F B8 AD B8 F7 BF 08 99 B7 8B FA A4 7D B3 4A 8E 0E 09 00 09 BB 09 D9 12 F7 0E 1D 28 B4 3A F0 15 6A 02 7B 3F 2B 36 D5 12 F5 0E 3E 28 B2 3A F1 15 43 02 28 4A 23 4A 9E 4A 62 6B C1 79 DB 56 79 41 5D 7C 0C 75 EA 51 E1 4D 23 6B 84 79 EF 56 62 05 67 05 D5 05 22 24 D5 36 9E 19 02 0E 00 33 D4 16 D1 16 6C 16 DD 37 61 25 21 0A A3 1D 90 20 5C FD 54 FD E5 FD 72 C2 8D E6 AF FA 57 DC E2 CE 88 E1 32 F6 14 CB B2 97 BB 97 08 97 1A A4 51 8B D6 9C C1 A1 9D A8 64 8C 69 90 BF B6 20 A4 D9 CE C8 CE 62 CE E6 F1 0A D5 27 C9 8A EF 69 FD 2A D2 B7 C5 B4 F8 D0 F1 1F D5 2C C9 D4 EF 51 FD 31 D2 9C C5 A1 F8 DF F1 1D 12 0E 12 A1 12 A7 15 5A 33 A2 21 E8 0E 6E 19 75 24 37 2D DF 09 E2 15 12 33 E6 21 E8 0E 6F 19 7D 24 34 2D CE 09 F3 15 01 33 82 21 33 26 7F 26 8E 26 6E 07 C5 15 83 3A 50 2D 76 10 14 19 E0 3D CA 21 21 07 A4 15 D1 3A 57 2D 46 10 0B 19 F4 3D C5 21 0D 07 9A 15 E2 3A 12 2D 5E 10 19 19 E2 3D C6 21 22 07 C8 15 C4 3A 5C 2D 5B 10 0C 19 E0 3D CC 21 3C 07 8B 15 83 3A 5C 2D 5D 10 11 19 F5 3D D9 21 2B 07 8B 15 DB 3A 77 2D 9E A4 56 A4 20 A4 FC 9B 60 BF 48 A3 B6 85 0B 97 2E B8 FA AF F2 92 BC 9B 58 BF 61 A3 97 85 24 97 6A B8 BF AF C2 92 A6 9B 58 BF 40 A3 B8 85 65 97 22 B8 D3 AF D3 92 80 9B 62 BF 24 A3 CA 85 75 97 3E B8 AF AF AB 92 FD 9B 5E BF 65 A3 8B 85 26 97 7C B8 FE AF E9 92 BB 9B 0C BF 59 A3 8D 85 2A 97 67 B8 EB AF FE 92 A7 9B 59 BF 63 A3 8A 85 23 97 60 B8 F0 AF DC 92 8E 9B 0C BF 28 A3 AF 85 09 97 5B B8 D1 AF BF 92 FC 9B 1E BF 35 A3 CB 85 37 97 6F B8 F7 AF FC 92 A7 9B 4D BF 72 A3 8D 85 65 97 53 B8 F3 AF F3 92 B4 9B 6F BF 5F A3 CB 85 65 97 53 B8 ED AF FA 92 A6 9B 79 BF 5F A3 C3 85 00 97 42 B8 DD AF DE 92 81 9B 0C BF 41 A3 B7 85 04 97 4B B8 CD AF DC 92 CE 6A C5 6A 71 6A 74 6D C1 4B 70 59 2A 76 BC 61 BA 5C E9 55 3F 71 79 6D E1 4B 54 59 31 B4 3A B4 F1 B4 97 87 F7 A8 67 BF 67 82 2E 8B D0 AF EE B3 18 95 AB 87 ED A8 4B BF 7F 6F 66 6F BE 6F 14 50 F7 74 8B 68 6D 4E CD 5C 9C 73 0C 64 1B 59 62 50 ED 74 97 68 67 4E D0 5C 9C 73 0B 64 12 59 77 50 E0 74 B7 68 43 4E FA 5C D7 73 4F 64 3D 59 64 50 3E B0 38 B0 FC B0 61 86 4C 8F B5 AB 90 B7 76 91 BB 83 0A 26 09 26 C9 26 DF 3D FF 21 3B 07 52 9A 45 9A 96 9A 60 AC 2E A5 D3 81 FF 9D 0F BB FD A9 B0 86 3C 91 03 AC 39 A5 92 81 AD 9D 59 BB FB A9 A7 86 00 91 73 AC 6D A5 85 81 A6 9D 43 BB EC A9 96 86 7A BD 72 BD BF BD 89 8E CA A1 3F B6 35 8B 70 82 E8 A6 C9 BA 20 9C B5 F4 BC F4 73 F4 8C CB 62 EF 43 F3 BD D5 0A C7 40 E8 DC FF D7 C2 AD CB CD 56 DD 56 0A 56 7D 4A F6 5D B8 60 F3 69 0F 4D 23 51 C5 77 79 65 7D 4A A7 5D A0 60 E7 69 2B 4D 77 51 90 77 36 65 99 5A 9A 5A 51 5A B8 6C F2 65 11 41 BA 65 33 65 73 65 86 44 41 56 42 79 E8 6E 9B 53 D1 5A 32 7E 53 62 A6 44 41 56 5E 79 D5 6E DE 53 82 5A 28 7E 45 62 A5 44 41 56 44 79 DA 6E D8 53 D1 5A 6D 7E 43 62 A9 44 14 56 45 79 D5 6E D5 53 B0 5A 28 7E 57 62 A8 44 29 56 79 79 9B 6E 81 53 A9 5A 4D 7E 00 62 E7 44 4D 56 03 79 D7 6E DA 53 9F 5A 67 7E 49 62 B3 44 11 56 45 79 9B 6E DE 53 83 5A 69 7E 00 62 B4 44 13 56 4F 79 CF 6E CF 53 94 5A 64 7E 00 62 E7 44 41 56 0A 79 9B 6E 9B 53 D1 5A 28 7E 00 62 E7 44 6F 28 7B 28 A5 28 BE 1B F2 34 0A 23 00 1E 51 17 B2 33 93 2F 32 09 C0 1B 90 34 00 23 4E 1E 4A 17 BA 33 9C 2F 61 09 D8 1B 93 34 0F 23 2D 1E) */;

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(3, null, 1267014466, typeof(ႨႨ)));
				goto case 7;
			case 7:
				num = ⴀႨ[127] - 47100;
				break;
			case 3:
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130323, 2, '\u0098'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(14, null, 1057167049, 6));
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(0, '\u009e', 952616345));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 6, 62061882, null));
				num = 6;
				break;
			case 6:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(6, 1, 1217940549));
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(7, 7, 1217944678));
				num = 0;
				break;
			case 0:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	internal static string Ⴍ(char P_0, int P_1, int P_2)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		IEnumerable enumerable = default(IEnumerable);
		int num6 = default(int);
		Array array = default(Array);
		object obj2 = default(object);
		ISerializable serializable = default(ISerializable);
		char c = default(char);
		int num7 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = P_1 ^ 0x3AC23FB3 ^ P_2;
			object ⴓ = Ⴓ;
			char[] obj = (char[])ⴓ;
			int num2 = obj[num];
			num2 = obj[num + 2] ^ num2;
			int num3 = 3;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = 6;
					continue;
				case 6:
				case 9:
					break;
				case 3:
					num3 = (((enumerable = ((string[])Ⴃ)[num2]) == null) ? 14 : (ⴄႤ[189] - 14));
					continue;
				case 16:
					return enumerable as string;
				case 14:
				{
					char[] obj3 = (char[])ⴓ;
					char[] obj4 = (char[])Ⴗ;
					num6 = num;
					array = obj4;
					obj2 = obj3;
					num3 = 7;
					continue;
				}
				case 0:
				case 7:
					serializable = new StringBuilder();
					c = (obj2 as char[])[num6];
					num7 = (obj2 as char[])[num6 + 1] ^ c;
					num3 = 11;
					continue;
				case 11:
					num6 += 3;
					num5 = (num7 & 0x1F) | ((num7 & 0xFFC0) >> 1);
					num3 = 5;
					continue;
				case 5:
					num3 = (((num7 & 0x20) == 0) ? 1 : 2);
					continue;
				case 2:
					num5 = (num5 << 15) | (((char[])obj2)[num6++] ^ c);
					num3 = ⴍႭ[225] - 31556;
					continue;
				case 1:
					num8 = (array as char[]).Length;
					num4 = 1;
					num3 = 10;
					continue;
				case 15:
					((StringBuilder)serializable).Append((char)(c ^ ((char[])obj2)[num6 + num5 - num4] ^ (array as char[])[(num4 + num6 + 17) % num8]));
					num3 = 4;
					continue;
				case 4:
					num4++;
					num3 = ⴄႷ[60] - 11688;
					continue;
				case 10:
				case 12:
					num3 = ((num4 <= num5) ? 15 : 13);
					continue;
				case 13:
					enumerable = (serializable as StringBuilder).ToString();
					((string[])Ⴃ)[num2] = (string)enumerable;
					num3 = ⴄႷ[12] - 43765;
					continue;
				case 8:
					return enumerable as string;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, DateTime P_1, int P_2, int P_3) where _0021_00210 : Letter
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄႭ[134];
				break;
			case 8:
			case 9:
				num = (((P_2 ^ P_3) - 52) ^ num2) switch
				{
					0 => ⴀႣ[182] - 39504, 
					_ => 4, 
				};
				break;
			case 4:
			case 7:
				num = ⴀႣ[264] - 37762;
				break;
			case 1:
				P_0.Dts = P_1;
				goto case 2;
			case 2:
			case 5:
			{
				num2++;
				int num3 = 329;
				int num4 = 419;
				num = ((1257 > num4 - num3 * 3) ? (ⴍႤ[159] - 11934) : 6);
				break;
			}
			case 6:
				num = 8;
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, char P_3) where _0021_00210 : DxSpot
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 2;
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
			case 9:
				num = (((P_3 ^ P_2) - 91) ^ num3) switch
				{
					0 => 6, 
					_ => 4, 
				};
				break;
			case 4:
				num = 5;
				break;
			case 6:
				P_0.Bob = P_1;
				goto case 5;
			case 5:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 7;
				break;
			case 7:
				num = ((num2 % 2 == 0) ? 1 : (ⴃႰ[203] - 59430));
				break;
			case 1:
			case 8:
				return;
			}
		}
	}

	static ShowWxHelp()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 2;
		Array array = default(Array);
		while (true)
		{
			switch (num)
			{
			default:
				Ⴓ = new char[3787]
				{
					'넗', '너', '넗', '귀', '멙', '蝚', '蹲', '\uaaee', '뚸', '逨',
					'芍', '귛', '멱', '蝸', '踵', '\uaad6', '뛾', '透', '芯', '귨',
					'멤', '蝆', '踨', '\uaad6', '뛨', '逞', '芢', '귨', '멕', '蝊',
					'踻', '\uaac3', '뛎', '逶', '襈', '襇', '襉', 'ꡐ', '뫰', '閶',
					'舨', '뼧', '뙦', '銎', '躼', 'ꡜ', '뫲', '閕', '舢', '뼥',
					'뙢', '銮', '꽚', '꽝', '꽘', '뒜', 'ꢣ', '蹂', '鳫', '뎨',
					'ꐮ', '餈', '嬦', '嬧', '嬥', '䞚', '靊', '靃', '靎', '貝',
					'邸', '뙔', 'ꓰ', '讙', '鰧', 'ꄢ', 'ꡠ', '貵', 'ꈻ', 'ꈱ',
					'ꈾ', '醔', '뻄', '\ua94a', '鑩', '鴈', '맍', 'ꖖ', '荷', '醒',
					'뻪', '\ue49d', '\ue48d', '\ue49b', 'ｊ', '\ue373', '얅', '휪', '\uf87d', '\ueff1',
					'틳', '\udb95', '｛', '\ue36e', '얎', '휏', '\uf83f', '\uefae', '틿', '\udb86',
					'뾪', '뾫', '뾭', 'ꌑ', '욥', '욵', '욭', '셋', '\ue7bd', '\uf510',
					'\uda59', '췁', '\uf0f0', '連', '\udd78', '셏', '\ue78b', '\uf506', '\uda71', '춝',
					'\uf09d', '列', '\udd56', '㜺', '㜶', '㜳', 'ᘳ', 'ҏ', '⯏', '㱒',
					'ŗ', '࠲', '⳼', 'ハ', 'ᘷ', 'Ҳ', '⯒', '㱿', '\uf5c2', '\uf5d0',
					'\uf5c8', 'ﺧ', '쎦', '쫽', '\uee02', '\uf239', '퓋', '왊', '\ue972', 'ﺰ',
					'쎦', '쫪', '\uee19', '\uf22e', '퓚', '왝', '\ue972', 'ﺌ', '쎊', 'ꝉ',
					'Ꝝ', 'Ꝃ', '걨', '酥', '頢', '벦', 'ꂫ', '虑', '银', '뮷',
					'각', '酥', '顃', '베', 'ꃳ', '虐', '铷', '뮭', '갫', '鄭',
					'顨', '벞', 'ꂁ', '᠇', '\u180c', '\u180b', '❿', '·', '\u1ffe', '㤪',
					'⮨', 'Ӹ', '፶', '⹕', '✺', 'ς', 'Ὴ', '䞇', '䞉', '䞊',
					'燎', '碄', '尕', '䁤', '暃', '琥', '孮', '䲫', '燋', '碁',
					'屸', '䀰', '暞', '琸', '쬁', '쭛', '쬏', '쳵', '\uea33', '\uf8fa',
					'ힽ', '쁦', 'ﵦ', '\uf405', '킓', '첡', '\uea08', '\uf8af', 'ퟡ', '쁴',
					'ﵵ', '\uf425', '킓', '쳽', '\uea13', '\uf8fa', 'ퟴ', '쁰', 'ﵹ', '\uf43e',
					'킓', '쳾', '\uea14', '\uf8ae', 'ힱ', '쁴', 'ﵥ', '\uf419', '킓', '첶',
					'\uea5c', '\uf8fa', 'ힱ', '쁴', 'ﵵ', '\uf43a', '탇', '쳮', '\uea33', '\uf8fa',
					'ퟴ', '쁣', 'ﵮ', '\uf43f', '태', '쳵', '\uea12', '\uf89b', 'ힱ', '쁴',
					'﵅', '\uf419', '킓', '첻', '\uea5c', '蝕', '蝗', '蝚', '鮝', '谀',
					'៴', '៱', '៤', '\u0b3a', '᳇', '⇄', '⣼', 'ఖ', '䜃', '䜗',
					'䜒', '䱟', '煰', '砭', '峂', '䃌', '春', '瓸', '寞', '䱍',
					'煐', '砎', '岑', '䂳', '晞', '璌', '寐', '䱇', '煎', '砍',
					'峢', '╌', '╂', '╞', '㦲', '⸢', 'ጤ', '\u1a73', '㺟', '⊤',
					'ф', 'ᛰ', '㦵', '⸫', 'ጣ', '\u1a68', '㺽', '⊖', '愨', '愶',
					'愻', '功', '緔', '橈', '坪', '帣', '窧', '曞', '䀹', '劒',
					'緻', '樉', '坬', '帱', '竟', '曺', '䀂', '勓', '緥', '橛',
					'坌', '帐', '竏', '曩', '䁵', '劶', '緬', '橬', '坥', '带',
					'竞', '촫', '촵', '촿', '\uec76', 'ﻊ', '퇕', '왅', 'ףּ', '\uf214',
					'훸', '쫃', '\uec23', 'ﺗ', '퇒', '왌', 'פּ', '\uf20f', '훺', '쪑',
					'\uec24', 'ﺕ', '퇈', '왟', '\ufb0a', '\uf204', '훼', '쫅', '\uec35', 'ﺕ',
					'퇉', '왘', '\ufb45', '\uf223', '墫', '墬', '墾', '䍠', '彔', '禝',
					'欕', '䑋', '叟', '滮', 'ᦒ', 'ᦙ', 'ᦄ', '㣏', '⩳', 'ն',
					'ዦ', '\u2fe3', '⚭', 'ɕ', 'ṇ', '㣏', '⩩', 'Ԣ', '鵸', '鵪',
					'鵯', '陗', '\uab1d', 'ꉖ', '蚸', '骃', '뱠', '껏', '膋', '陙',
					'ꬄ', 'ꈃ', '蚱', '髂', '뱪', '껑', '膋', '阘', 'ꬴ', '쾀',
					'쾅', '쾘', '쓆', '倫', '\uf089', '푷', '졞', '\uf1dd', '\uf18a', '\uf1c4',
					'쉣', '\ued29', '荒', '잲', '캶', '\uea0a', '\uf62f', '탔', '숦', '\ued3f',
					'荒', '잺', '캶', '\uea0a', '\uf62a', '탉', '쉲', '\ued3d', '睊', '쟼',
					'컳', '\uea07', '\uf633', '킀', '쉵', '\ued3a', '荒', '잴', '컅', '\uea4f',
					'\uf66a', '킀', '숦', '\ued6d', '\ufafc', '쟼', '캶', '\uea4f', '\uf667', '킀',
					'쉣', '\ued20', '蝹', '잨', '컆', '\uea3a', '\uf667', '탗', '쉩', '\ued05',
					'摒', '쟼', '캶', '\uea4f', '\uf667', '鉶', '鋺', '鉬', '軉', '餃',
					'ꐙ', '굘', '覭', '門', '덈', 'ꇎ', '躔', '餶', 'ꐃ', '굎',
					'覡', '閘', '덪', 'ꇡ', '軉', '饁', 'ꐅ', '굘', '覒', '閏',
					'덹', 'ꇬ', '軉', '餄', 'ꐒ', '굎', '覥', '閉', '덧', 'ꇈ',
					'躴', '餔', 'ꐅ', '굼', '觫', '閞', '덮', 'ꇙ', '躕', '餂',
					'ꐛ', '굾', '覶', '閭', '댤', 'ꇙ', '躃', '餙', 'ꑙ', '굖',
					'觱', '閎', '덪', 'ꆃ', '躖', '餃', 'ꐑ', '괒', '觫', '闖',
					'덻', 'ꇙ', '躀', '饗', 'ꑍ', '굉', '覥', '闌', '덿', 'ꇃ',
					'躃', '餞', 'ꐛ', '굾', '㚾', '㚲', '㚥', '㷥', 'Ò', 'ঘ',
					'ⵄ', 'ㅬ', '៣', 'Ԩ', '⩣', '㷲', '\u0092', '\u0991', '\u2d68', '믘',
					'믝', '믄', '냹', '趼', '蓷', 'ꁊ', '뱢', '뾝', '뾕', '뾀',
					'黑', '豳', 'ꍮ', '듌', '觻', '肸', 'ꑆ', '롗', 'ᕅ', 'ᕝ',
					'ᕛ', '⩺', 'ຖ', 'ኻ', '㐖', '⛵', 'শ', 'ḫ', '⌨', '⩌',
					'ປ', 'ኳ', '㑙', '⛝', 'উ', 'Ḵ', '⌱', '⩺', 'ຒ', 'ኌ',
					'㑤', '⛹', '\u09b3', 'ḇ', '⌘', '—', '\u200c', '\u200b', '㳰', '\u2b74',
					'ᙱ', 'ά', '㯔', '⟫', 'ĝ', 'Ꮌ', '㳱', '⭹', 'ᙖ', 'ἧ',
					'㯢', '⟒', 'ę', 'Ꮊ', '㳰', '⭰', 'ᙆ', 'ἃ', '㯁', '⟨',
					'Ī', '᎓', '⽼', '⽺', '⽜', 'Ლ', '㎉', '␓', 'ᤔ', 'ၻ',
					'㓮', '쏟', '쏋', '쏾', '\udf6f', '좻', '\uf5b6', 'ﳷ', '\ud80c', '쐦',
					'\ue282', '\uf070', '\udf3c', '좷', '\uf592', 'ﳦ', '\ud808', '쐱', '\ue2d1', '\uf071',
					'\udf23', '좝', '\uf5a6', 'ﳐ', '髑', '髃', '髳', 'ꗿ', '脋', '鴨',
					'믍', '\ua949', '蘵', '醣', '겹', 'ꗖ', '脑', '鴮', '믘', 'ꥹ',
					'蘴', '醼', '겓', 'ꗢ', '脧', '뇆', '뇖', '뇥', '괳', '몯',
					'螤', '軬', '\uaa37', '똨', '郃', '艘', '괽', '모', '螨', '軏',
					'ꨘ', '똰', '郚', '艞', '❎', '❁', '❪', '\u0656', 'ᓶ', '㮰',
					'Ⱞ', 'ᄡ', 'ᡠ', '㲈', '₺', '\u065a', 'ᓴ', '㮓', 'ⰽ', 'ᄪ',
					'ᡶ', '㲩', '\u0eef', '\u0efe', '\u0eca', '㢚', '㇅', 'ᔹ', 'ज़', '⿷',
					'㵙', 'ሐ', '֍', '㢂', '㇁', 'ᔊ', 'ऄ', '\u2fe2', '㵶', 'ለ',
					'։', '㢯', '簥', '粦', '簃', '柫', '箟', '嵸', '俞', '悕',
					'眄', '䨄', '䍎', '枷', '篐', '崭', '侦', '惞', '眔', '䨖',
					'䌄', '枢', '篎', '崬', '俉', '悈', '睒', '䨛', '䌆', '柴',
					'篋', '崹', '侉', '悚', '睉', '䩋', '䌍', '枹', '篚', '崺',
					'例', '惁', '睑', '䩋', '䌗', '枹', '篈', '崯', '侉', '悚',
					'看', '䨞', '䌞', '柣', '篋', '崰', '俞', '悕', '眞', '䩐',
					'䌏', '枷', '篐', '崵', '供', '惱', '眄', '䨄', '䍎', '枷',
					'箟', '崤', '釶', '釯', '金', '赆', '髚', 'ꟗ', '껠', '訰',
					'阂', '냮', 'ꉀ', '贋', '骘', 'ꞔ', '꺝', '訠', '阍', '냩',
					'ꉶ', '赆', '骓', 'Ꞓ', '껉', '訧', '阉', '냡', 'ꉈ', '贴',
					'刴', '刪', '刜', '懏', '争', '夕', '摨', '洜', '䧯', '嗜',
					'猬', '憂', '仑', '奛', '搕', '洓', '䧪', '嗏', '獩', '憃',
					'仈', '奔', '摖', '洤', '䦦', '嗊', '猬', '憛', '仇', '奐',
					'摟', '洚', '䧔', 'ꉜ', 'ꉝ', 'ꉵ', '鴨', '勲', '勢', '勘',
					'世', '妝', '撖', '淐', '䤬', '唫', '珽', '慌', '且', '妁',
					'撖', '淪', '䤸', '唐', '珬', '慹', '嶭', '嶬', '嶆', '䙣',
					'ຂ', 'ຕ', 'ຮ', '㢪', 'ㆭ', 'ᕞ', '७', '⾐', '㴿', 'ሲ',
					'װ', '㣧', 'ㆻ', 'ᕟ', 'ॻ', '⾚', '㴫', 'ሲ', 'ר', '㣯',
					'ㆨ', 'ᕄ', 'स', '⾐', '㴷', 'ሺ', '䩹', '䩻', '䩔', '䶍',
					'歫', '礬', '礦', '礂', '旅', '牙', '佄', '䘋', '拷', '绔',
					'堰', '䪇', '旝', '牮', '蘭', '邏', '擄', '\uf26a', '콬', '옵',
					'\ue283', 'ﻠ', '\ud811', '쪪', '\ue5ea', '\uf27d', '콷', '옘', '\ue2f1', '\ud963',
					'\ud964', '\ud953', '\uead6', '얜', '툋', '\uef11', '\ue65a', '슴', '\udeaf', '잪',
					'재', '잛', '\ue6e9', '\uf412', '\udb48', '쳪', '\uf184', '\uf8dd', '\ue260', '\ue263',
					'\ue252', 'ﺓ', '\ue913', '퐠', '綴', '綿', '綇', '䯐', '䊓', '景',
					'穨', '岬', '东', '慊', '盐', '䯖', '䊖', '晊', '㼰', '㼴',
					'㼄', '\v', '⓮', '㣏', 'ḅ', '\ufe2d', '\ufe20', '︘', '섃', '\ue5fc',
					'慄', '\udf31', '춘', '\ue2d8', '\uf558', '졂', '섏', '\ue5fe', '狀', '\udf28',
					'춡', '\ue5ad', '\ue5a7', '\ue59b', '쒤', '혘', '賂', '\ueec3', '폯', '\uda9e',
					'﹛', '\ue243', '쒵', '혥', '塭', '塦', '塚', '䒉', '匙', '渜',
					'杒', '䎪', '徸', '票', '毲', '䒉', '匉', '渿', '澷', '澹',
					'澏', '尜', '獋', '擓', '姾', '傈', '瑫', '桘', '亥', '尯',
					'獟', '擲', '姂', '備', '瑖', 'ᇢ', 'ᇲ', 'ᇛ', 'ਠ', 'ᘔ',
					'ヺ', '≱', 'ആ', '\u1a8f', '➖', '⻈', 'ਸ਼', 'ᘝ', 'ホ', '≁',
					'ശ', '᪗', '➆', '\u2efa', '认', '记', '讞', '豌', 'ꪼ', '렋',
					'靚', '胐', '뷊', '뒬', '遳', '豝', '\uaab7', '렞', '静', '胗',
					'뷊', '뒉', '遤', '豛', 'ꪉ', '렇', '靰', 'ꕬ', 'ꕧ', 'ꕗ',
					'雅', '릙', '긞', '錸', '驋', '뺲', 'ꊃ', '著', '雙', '릒',
					'긬', '\u0fc6', '࿊', '\u0ffa', 'ጤ', 'Ң', '㦳', 'メ', 'ᐝ', 'ࠚ',
					'⻕', '㱳', '\u1317', 'ҳ', '㦢', 'マ', '귟', '귔', '귢', '鮮',
					'鋸', '똈', 'ꨍ', '賌', '鹪', '넎', 'ꚩ', '鮱', '鋼', '똾',
					'ϒ', 'Ϝ', 'Ϭ', 'ࢣ', '㖿', '㳼', 'ᠨ', 'Э', '⋋', 'て',
					'Ἇ', 'ࢽ', '㖽', '㳘', '᠔', 'Э', '⋼', '܉', '܃', '\u0736',
					'\u1ccf', 'ý', '☁', '㒽', 'ᯚ', '\u0c70', 'ㅟ', '㠶', '\u1cde', 'À',
					'⇵', '⇳', '↵', 'Ệ', '㨐', '☘', 'ç', 'ቆ', '㴶', '햮',
					'햠', '헯', '\ue3df', '\uea89', '칹', '퉼', '\uf4a7', '\ue61b', '쥋', '\udec0',
					'\ue3ec', '\uea9d', '칋', '퉀', '\uf4b6', '\ue626', '矍', '矊', '瞏', '欫',
					'粻', '䆛', '䣱', '氐', '瀿', '団', '吧', '吣', '呤', '弆',
					'戆', '武', '侘', '겴', '겾', '곰', '띨', 'ꭇ', '趮', '鼀',
					'끨', '\ua7e9', '髒', '鎙', '띅', 'ꭲ', '\u193b', '\u1929', '\u197e', '⪐',
					'\u05c7', '\u125f', '⽲', '☃', '\u02e7', 'Ỏ', '㠯', '⪔', 'כ', 'ት',
					'⽌', '☇', '\u02de', 'Ỗ', '㠩', '⪈', '\u05f8', '怇', '怗', '恁',
					'篆', '柲', '䄈', '县', '糶', '歋', '器', '弣', '篜', '柩',
					'䄛', '厨', '糄', '歲', '噣', '弟', 'अ', 'ऎ', '\u0942', '⠖',
					'㪱', 'ᗼ', 'ɰ', '㽥', '㘺', 'ዤ', '\u0ee8', '⠗', '㪶', 'ᗆ',
					'쫝', '쫖', '쪕', '홭', '솲', 'ﲳ', '\uf5ff', '턜', '촵', '\uebc5',
					'縷', '홭', '쇱', 'ﳼ', '鍔', '鍒', '錝', 'ꃼ', '辰', '頧',
					'ꔺ', '걯', '裆', '\u0ef5', '\u0ee1', '\u0ebf', 'ሕ', '\u0598', '㢑', 'ㇶ',
					'ᔩ', '\u0900', '⿄', '㵚', 'ሄ', '\u05b8', '㢚', '㇑', 'ᔮ', 'छ',
					'\u2fe9', '㵚', 'ሶ', 'ր', '㢑', '\u31ed', '⫏', '⫋', '⪄', '⇎',
					'\u1cce', 'ᖄ', 'ㄯ', '\u05ba', '\u05b5', '\u05f6', '㘑', '᥆', 'ໞ', '㏳',
					'㪟', 'ṧ', 'ɉ', '⒳', '㘀', 'ᥞ', '\u0ee8', '㏌', '㪞', 'Ṡ',
					'ɳ', '믤', '믴', '뮩', 'ꀪ', '뱞', '骹', '蠟', 'Ꝕ', '냅',
					'跅', '蒏', 'ꁶ', '뱞', '骹', '蠟', '\ua708', '냅', '跅', '蒏',
					'軶', '軽', '躸', '꿬', '뵃', '鈏', '薓', '뢖', '뇘', '锌',
					'褛', '꿤', '뵅', '鈵', '蔈', '蔂', '蕇', '蹬', '덤', '먪',
					'黎', '苢', 'ꐠ', '뚤', '駷', '蹡', '덚', '碲', '碡', '磢',
					'䟗', '捤', '罍', '妽', '䬈', '摇', '珟', '仐', '䟙', '捳',
					'罅', '妠', '䬆', '摐', '玓', '仇', '䞘', '捨', '罫', '饕',
					'饃', '餄', '꼤', '\ua672', '节', '麇', '롆', 'ꫡ', '薬', '鈠',
					'꼵', 'Ꙫ', '芴', '麻', '롛', '\uaaeb', '薱', '鈺', '꼻', 'ꙝ',
					'芐', '麠', '례', 'ꫝ', '嵙', '嵜', '崋', '欪', '扳', '䚎',
					'媯', '籧', '\uf42c', '\uf425', '\uf47f', '픢', '잒', '\ue8d8', 'ｂ', '쉣',
					'쬐', '\ueff1', '\uf3de', '픂', '\udd3b', '\udd30', '\udd6f', '쇛', '홖', '\ueb5f',
					'\ue238', '웢', '\udad3', 'ﰩ', '\uee97', '쇟', '홟', '\ueb74', '鞐', '鞝',
					'韅', '議', '鳽', 'ꇴ', 'ꢓ', '豑', '遯', '뚉', 'ꐤ', '譎',
					'鳦', 'ꇾ', 'ꢳ', '豱', '\ue0e3', '\ue0ea', '\ue0b5', 'ﬨ', '\ue70d', '쇝',
					'퍋', 'ﰋ', '\ueba6', '횖', '\udfcd', 'ﬂ', 'ㅎ', 'ㅄ', 'ㄙ', '\u02f7',
					'ⶱ', '㨍', '\u0737', 'แ', '⪓', '㚚', '၇', '\u02f0', 'ⶍ', '\ude30',
					'\ude37', '\ude68', '\ud9da', 'Ｈ', '\ued8e', '싢', '핅', '\ue854', '\ue128', '䉥',
					'䉷', '䈼', '廅', '䥖', '琇', '絾', '妳', '䖑', '捭', '燑',
					'庇', '䤅', '琊', '絜', '妢', '䖫', '捬', '燗', '庛', '䤭',
					'䈐', '䈘', '䉊', '䗼', '挚', '熜', '廯', '䥟', '瑥', '紾',
					'姱', 'ᕭ', 'ᕧ', 'ᔶ', '\u0984', 'Ḙ', '⌯', '⩔', '\u0eba', 'ኃ',
					'㑤', '⛙', '\u098d', 'ḿ', '草', '荎', '茕', 'ꉆ', '냷', '龴',
					'蠥', '딡', '뱩', '風', '횷', '횽', '훪', '\uddc2', '\ue0d8', '\ue9bf',
					'쵼', '텙', '\uf789', '\ue501', '쩎', '\udddd', '\ue0e5', '舱', '航', '良',
					'봎', '駦', '藅', 'ꍢ', '놄', '黎', '襓', '둑', '봟', '駁',
					'藎', 'ꌿ', '놘', '黄', '襆', '둕', '봨', '馭', '藙', 'ꌩ',
					'놞', '黒', '襅', '둜', '봹', '駱', '藪', 'ꑓ', 'ꑋ', 'ꐌ',
					'뢷', '꼷', '鈼', '鬶', '뾏', 'ꎦ', '蕍', '韩', '뢦', '꼰',
					'鈷', '魫', '뾓', 'ꎬ', '蕘', '韭', '뢱', '꽼', '鈦', '魽',
					'뾏', 'ꎥ', '蕋', '韼', '麊', '麍', '黪', '뾹', '괒', '艘',
					'閹', '\ua8dd', 'ꆄ', '蕪', '䯩', '䯸', '䮈', '綏', '瓐', '倴',
					'䱝', '櫠', '硓', '圑', '䂋', '綇', '瓋', '倿', '䰒', '櫦',
					'砜', '圚', '䂚', '綁', '㮸', '㮽', '㯚', '\u0de1', 'ҷ', '⁛',
					'㱡', '\u1ae6', '㣒', '㣙', '㢱', '⍑', '㽦', 'ᦟ', 'ଧ', '⑺',
					'㏥', '\u0ee2', '\u07b7', '⍒', '㽱', 'ᦞ', '튪', '튧', '틎', '쥬',
					'핕', '\uf3b9', '\ue15f', '칢', '\ud9f9', '\ue4f1', '\uedd8', '쥏', '픞', '\uf3b4',
					'\ue109', '칞', '┅', '┃', '╠', '\u1a7a', '㺚', '⋞', 'Ш', 'ᛧ',
					'㧂', '䱬', '䱣', '䰊', '䜙', '稈', '獉', '埰', '䮎', '浤',
					'翃', '傒', '䜈', '稝', '猉', '垺', '䮙', '洦', '翙', '쀨',
					'쀬', '쁏', '\uf66d', 'Ｌ', '\udbad', '쟼', '枤', '枬', '柌', '吒',
					'筛', '泆', '冋', '墝', '籺', '怍', '䚲', '\ud95b', '\ud919', '\ud932',
					'\uef2e', '\ue671', '슍', '\udeef', '\uf848', '\ueac5', '얗', '툱', '\uef35', '\ue67f',
					'슋', '\udead', '\uf84a', '\ueae1', '얈', '툿', '\uef0c', '\ue663', '슼', '\ude9d',
					'\uf855', '\ueae4', '얪', '툵', '\uef36', '\ue67e', '슞', '\udeae', '\uf862', '\ueadc',
					'얬', '툼', '\uef19', '\ue64c', '닕', '늒', '늿', '긱', '리', '蒠',
					'趰', 'ꤕ', '딺', '鏍', '腺', '긤', '릹', '蒵', '跂', 'ꤌ',
					'딠', '鏇', '腬', '긩', '릸', '蒵', '距', '꤂', '딙', '鏛',
					'腛', '긙', '릧', '蒰', '跿', '꤈', '딣', '鏆', '腹', '긪',
					'릐', '蒈', '跹', '꤁', '딌', '鏴', 'ꯚ', 'ꮊ', 'ꮱ', '갫',
					'諈', '顮', '뜨', 'ꂷ', '鶷', '铰', '뀫', '갥', '諱', '顲',
					'뜟', 'ꂇ', '鶨', '铵', '뀉', '갯', '請', '顯', '뜽', 'ꂴ',
					'鶟', '铍', '뀏', '갦', '諤', '顝', '띪', 'ꂴ', '鶯', '钱',
					'뀍', '갬', '諎', '顧', '띪', 'ꂞ', '鶍', '钱', '뀏', '갮',
					'諎', '顱', '뜺', 'ꂲ', '鶁', '铿', '뀽', '\uef38', '\uef30', '\uef54',
					'\ud94a', '퀗', '\uf4e4', '\ue8cd', '츦', '\udc86', '\uf3db', '\ue419', '뫞', '뫕',
					'몳', 'ꄔ', '봀', '鮃', '襈', 'ꘁ', '농', '貙', '薵', 'ꅆ',
					'뵤', '鮊', '労', '劫', '勚', '撕', '淏', '䤶', '唞', '珹',
					'慜', '丄', '妉', '撕', '涎', '䥣', '啜', '玏', '慏', '习',
					'姻', '擴', '淟', '䤶', '唞', '現', '慞', '丄', '妋', '撕',
					'涎', '䥣', '啜', '玏', '慏', '丄', '돑', '뎅', '뎾', '貐',
					'ꡮ', '됲', '鋘', '聣', '꼷', '뢹', '薤', '賹', 'ꠢ', '둫',
					'鋊', '聥', '꽡', '뢤', '薢', '賻', '\ua80b', '됈', '銌', '聹',
					'꼤', '뢹', '薤', '賳', 'ꠗ', '됥', '鋩', '耥', '꼂', '뢓',
					'薈', '賞', 'ꡃ', '둫', '銌', '耪', '꽡', '룰', '藰', '貺',
					'ꡃ', '둫', '銌', '耪', '꽡', '룰', '藰', '貺', 'ꡃ', '둫',
					'銌', '苫', '若', '芛', '듊', '붚', '餪', '蔟', 'ꏹ', '녙',
					'鸏', '見', '뒞', '뷳', '饹', '蔅', 'ꏹ', '녤', 'ڜ', 'ڎ',
					'\u06ed', 'Ħ', '⟛', '㔴', '\u1a78', '\u0df2', 'ロ', '㦄', 'ᵋ', 'Ů',
					'➂', '㔦', 'ᩏ', 'ල', 'ラ', '㦸', 'ᵺ', 'Ħ', '⟁', 'ⲻ',
					'ⲿ', 'ⳉ', 'ඟ', 'ἴ', 'み', '⟨', '癯', '癬', '瘜', '櫑',
					'絞', '䁝', '傇', '傄', '僳', '暨', '濼', '䬄', '\u0fa5', '\u0fa7',
					'࿐', 'ࠑ', '⺏', '⧌', '⧉', '⦺', '⸳', 'ࣅ', '\u1a76', '㔨',
					'⊾', '詤', '詢', '訓', '醳', '趐', 'ꭶ', '맅', '隅', '脆',
					'\uf4c9', '\uf4c5', '\uf4b1', '\uf336', '헀', '읳', '\ue82d', 'ﾻ', '슺', '쯧',
					'\uef0f', '\uf327', '헛', '읢', '\ue82a', '䚀', '䚟', '䛹', '秫', '崈',
					'䅾', '枓', '町', '婽', '䷬', '烮', '禨', '崒', '䄯', '枅',
					'甿', '婠', '䷮', '炡', '禬', '嵜', '䅳', '枉', '甮', '婳',
					'䷤', '烹', '禮', '崒', '䅨', '枒', '甩', '婢', '䷄', '痶',
					'痿', '疌', '䘟', '楗', '纔', '䎧', '䫅', '渓', '爂', '哥',
					'䙬', '橐', '橄', '樫', '皎', '愔', '封', '啔', '燂', '淰',
					'䭂', '姿', '盠', '愥', '尴', '啨', '燂', '涯', '䭉', '姤',
					'皭', '慱', '尉', '啌', '휪', '휬', '흖', '\ue4d1', '쮀', '\udc4e',
					'\ue146', '\ue800', '쳖', '䪛', '䪘', '䫦', '䆺', '粠', '疍', '薻',
					'薿', '藅', '돸', '몣', '鹚', '舌', '\uf424', '\uf470', '\uf45b', '쬁',
					'\uefd9', '\uf39e', '핵', '잙', '\ue8d2', 'ｪ', '숅', '쭕', '\uefe2', '\uf3cb',
					'픩', '잋', '\ue8c1', 'ｊ', '숅', '쬉', '\ueff9', '\uf39e', '피', '잏',
					'\ue8cd', 'ｑ', '숅', '쬊', '\ueffe', '\uf3ca', '핹', '잋', '\ue8d1', 'ｶ',
					'숅', '쭂', '\uefb6', '\uf39e', '핹', '잋', '\ue8c1', 'ｕ', '쉑', '쬚',
					'\uefd9', '\uf39e', '픁', '잨', '\ue894', 'ｑ', '쉠', '쬼', '\uefb6', '\uf39e',
					'핹', 'ᄤ', 'ᄡ', 'ᆤ', '⹏', 'શ', 'ᚎ', 'ぷ', '⋏', '檠',
					'檩', '模', '奂', '瘁', '懓', '峠', '喓', '煅', '浔', '䮳',
					'夺', '豄', '豊', '賆', '굜', '뿼', '邺', '蜤', '먫', '덪',
					'鞂', '记', '교', '뿾', '邙', '蜳', '먲', '던', '맏', '링',
					'륌', '븺', '飻', '試', 'ꔺ', '늸', '込', '蛡', 'ꈮ', '븤',
					'飂', '詖', 'ꔨ', '늩', '辏', '耭', '耶', '肩', '뎂', '鳜',
					'譈', '똂', '뼍', '鯼', '蟘', 'ꄼ', '뎴', '鳉', '譏', '뙉',
					'뼈', '鯱', '蟘', 'ꄓ', '뎪', '鳍', '譙', '뙘', '뼃', '鯌',
					'蟫', 'ꄷ', '뎐', '鳾', '議', '嘤', '嘥', '嚡', '楇', '뉝',
					'뉒', '닛', '뤢', '萂', '赈', '꧟', '떙', '錕', '臘', '껼',
					'뤂', '葭', '赈', '꧗', '뗶', '鍲', '臇', '厭', '去', '匪',
					'伝', '墖', '旁', '沉', '䡭', '呑', '狰', '怘', '佒', '壅',
					'旘', '沅', '䡺', '呙', '犾', '怙', '佞', '墌', '旔', '沞',
					'䡜', '呧', '䳪', '䳿', '䱢', '偀', '䞅', '窄', '珈', '圬',
					'䬑', '淳', '罘', '倖', '䞊', '窝', '玁', '圪', '䬕', '淣',
					'罝', '倓', '䞭', '立', '珹', '圜', '鴯', '鴩', '鶦', '껔',
					'臚', '陊', 'ꬎ', 'ꈜ', '蛹', '貈', '貎', '谂', '귏', '뼽',
					'遱', '蟮', '뫦', '뎯', 'Ϡ', 'Ϯ', '\u036b', 'Е', '⋔', 'ぉ',
					'ἕ', '\u0897', '㖓', '㳎', '᠁', 'Ў', '⋸', 'さ', 'Ἔ', 'ࢄ',
					'㖵', '\ue4b9', '\ue4b5', '\ue435', '얫', '휫', '\uf85b', '\uefdd', '틎', '\udb80',
					'ｮ', '\ue370', '얼', '휚', '\uf84a', '\uefe8', '㔊', '㔘', '㖇', '㹯',
					'\u036e', 'ਵ', '⻛', '㋵', 'ᐙ', 'ڿ', '⧵', '㹨', '\u0378', 'ਨ',
					'\u2efc', '㊰', 'ᐯ', 'ڕ', '⧋', '㹈', '\u0328', '䈔', '䈘', '䊚',
					'瑺', '紖', '委', '䗫', '挟', '熽', '廡', '䥆', '琡', '紼',
					'委', '䗏', '⍒', '⌔', '⏝', '⡳', 'ᕩ', 'ᱽ', '㢎', '⒩',
					'ɂ', 'ფ', '㾭', '⠰', 'ᕳ', 'ᱱ', '㢔', '⒙', 'ɢ', '\u10c8',
					'㾊', '⡳', 'ᔤ', 'ᱶ', '㢈', '⒛', 'ȏ', 'ხ', '㾬', '⠺',
					'ᔠ', 'ᱪ', '㢅', '⒫', 'ɀ', '჻', '㾲', '⡳', 'ᔡ', 'ᱶ',
					'㢒', 'Ⓔ', 'ɪ', '\uefb0', '\uefbe', '\uef20', '\uf300', '\ue48b', '\ud9d4', '킕',
					'\uf46d', '\ue870', '컭', '\udc4b', '\uf375', '\ue4e5', '\ud9f8', '탛', '\uf422', '\ue80a',
					'踽', '踭', '躬', '覇', '꽺', '붖', '鋄', '蕦', '렜', '넅',
					'闼', '观', '꼲', '붂', '鋉', '蕽', '렜', '녖', '閯', '銀',
					'銈', '鈒', '꒡', '귱', '襾', '镉', '뎬', 'ꅻ', '踰', '馡',
					'粭', '粢', '簾', '思', '瞖', '䫘', '䎃', '杬', '筑', '嶶',
					'伹', '思', '矯', '䫸', '䎳', '朿', '笗', '巰', 'ꧽ', '꧵',
					'ꥩ', '긁', '裩', '驂', '딌', 'ꊣ', '龎', '雒', '눮', '\u0bc2',
					'\u0bc5', '\u0b57', '㓺', 'က', 'భ', '⫔', '㡶', '\u173d', '\u00af', '反',
					'叚', '卛', '壬', '斩', '泮', '䠜', '吶', '狓', '怶', '伾',
					'墥', '斠', '泤', '䠊', '吧', '犐', '恻', '伲', '墣', '斾',
					'沫', '䠋', '吶', '狘', '恕', '軦', '軧', '蹱', '褭', '∝',
					'∜', '⊅', '⥒', '녒', '녔', '뇋', '귢', '멩', '蜿', '蹵',
					'ꪁ', '뚋', '䐈', '䐁', '䒒', '忂', '䏶', '攜', '矽', '壳',
					'佖', '牪', '笠', '応', '谪', '谡', '貱', '굷', '뿌', '邚',
					'蝟', '멙', '대', '韬', '诣', '굷', '뿜', '邚', '꼍', '꼛',
					'꾑', 'ꢰ', '蹍', '鲅', '돉', 'ꑈ', '餬', '递', '듺', '\ua8c4',
					'蹐', '鲢', '돨', 'ꑣ', '饮', '逇', '뒟', 'ꣲ', '踄', '鲷',
					'돹', 'ꑼ', '饙', '\ue21a', '\ue219', '\ue287', '퇦', 'ﺦ', '\ue93c', '\ue8fd',
					'\ue86e', '\ue863', '\ue3d2', '\ude98', 'ퟓ', '\uf324', '\uef04', '짯', '\udb4a', '\uf40f',
					'\ue3dc', '\ude99', 'ퟄ', '\uf32e', '\uef47', '짳', '\udb4a', '\uf401', '\ue39d', '\ude9f',
					'힖', '\uf32a', '\uef14', '짥', '\udb4e', '\uf419', '\ue3dc', '\ude91', 'ퟙ', '\uf33d',
					'\uef01', '즠', '\udb55', '\uf419', '\ue393', '\ude8c', 'ퟥ', '\uf36f', '\uef47', '즮',
					'\udb55', '\uf41f', '\ue399', '\ude8f', 'ퟃ', '\uf32d', '\uef06', '즠', '\udb54', '\uf408',
					'\ue388', '\ude8f', 'ퟃ', '\uf323', '\uef04', '즠', '\udb40', '\uf402', '\ue3dc', '\ude88',
					'ퟅ', '\uf326', '\uef0b', '즠', '\udb67', '\uf44d', '\ue3d1', '\udedc', 'ퟂ', '\uf33c',
					'\uef0e', '짌', '\udb06', '\uf406', '\ue39f', '\ude93', 'ퟚ', '\uf30d', '\uef47', '짬',
					'\udb4a', '\uf40c', '\ue3bf', '\udedc', '힕', 'ᴊ', 'ᴁ', 'ᶕ', '∮', '۱',
					'\u1ae2', '㰒', '⺧', 'Ǩ', '᙮', '⭘', '∹', 'ۊ', '\u1ad1', '厡',
					'厧', '匁', '旎', '沉', '䡑', '呍', '犹', '怨', '뺯', '뺷',
					'븎', '赔', 'ꈅ', '뗀', '裁', '膍', 'ꕩ', '륅', '龷', '贗',
					'ꉇ', '뗫', '袎', '臉', 'ꔽ', '륁', '龼', '贑', 'ꉖ', '뗂',
					'裭', '臐', 'ꕾ', '륇', '龓', '骷', '骵', '騕', '겎', 'ꗍ',
					'蒙', '蓗', '萺', '迪', '닽', '뮰', '齆', '荶', 'ꖊ', '띢',
					'顬', '迶', '닷', '뮺', '齛', '茣', 'ꖖ', '뜷', '顦', '迡',
					'늸', '뮦', '齎', '荐', 'ꗄ', '띯', '頩', '辸', '닽', '뮼',
					'齄', '荋', 'ꖴ', '띢', '顧', '迷', '닱', '뮦', '齊', '荷',
					'ꖷ', '띢', '顽', '违', '닋', '믲', '鼋', '茣', 'ꗄ', '⺛',
					'⺖', '⸿', '◮', '\u18fb', 'ᆴ', '㔇', '⥥', '\u0f94', 'ᴯ', '㉜',
					'◾', '\u18fb', 'ᆒ', '㕐', '⥌', '飣', '颦', '顆', '鏂', '께',
					'Ʂ', '茾', '鼋', '맸', '\uab18', '萗', '鎇', '꺆', 'Ꟊ', '茾',
					'鼕', '릾', 'ꬕ', '葓', '鎇', '꺊', '\ua7cb', '茰', '鼚', '릾',
					'\uab18', '萖', '鎊', '꺁', 'Ꟊ', '茲', '齙', '맺', 'ꭊ', '萜',
					'鎕', '껂', '\ua7cc', '茰', '鼻', '㎥', '㎫', '㌃', '⽐', '㣇',
					'\u05ca', 'ಏ', '⡹', '㑚', 'ኬ', '\u0010', '⽜', '㣅', 'ש', 'ಀ',
					'⡹', '㑾', 'ⳇ', 'ⳗ', 'Ⱡ', '⬯', '\u0dd5', 'Ὧ', '〤', '➣',
					'᪥', 'Ꮳ', '㜇', '⬍', '\u0dde', 'ά', '〔', '➣', '᪢', 'Ꮳ',
					'㜻', '吾', '启', '咖', '弟', '戅', '欚', '俸', '厄', '男',
					'枀', '䣝', '弟', '扚', '欑', '俹', '叐', '甪', '枑', '䣏',
					'彳', '\ud90c', '\ud901', '\ud9a5', '툭', '\uef37', '\ue628', '싊', '\udeb6', '\uf805',
					'\ueab2', '엯', '툭', '\uef6f', '\ue632', '싒', '\uded5', '⦅', '⦐', '⤯',
					'⊤', 'ι', 'ᚡ', '㉃', '⸿', 'ࢌ', 'ᨻ', '㕦', '⊤', 'ῡ',
					'ᚪ', '㉂', '\u2e6b', '\u0891', 'ᨹ', '㕻', '⋫', 'Ὲ', 'ᛮ', '㈗',
					'⸿', '덖', '덕', '돽', '豫', 'ꢓ', '뒛', '茛', '茟', '获',
					'飀', '蓧', 'ꈵ', '낀', '◬', '◮', '╁', 'ᙼ', '㤼', 'ꖪ',
					'ꖥ', 'ꔄ', 'ꈐ', '蓭', '阔', '륔', '껄', '鏱', '髁', '빉',
					'ꉳ', '蓷', '陑', '뤚', '꺋', '鎋', '髁', '뿀', '뿍', '뽯',
					'렪', '黈', '豰', 'ꌿ', '뒮', '覍', '胯', 'ꐟ', '렙', '默',
					'豿', 'ꌿ', '뒏', 'ѭ', 'Р', 'ӝ', 'ϙ', '╷', '㟘', 'ᢔ',
					'༏', '㈂', '㭟', 'ᾬ', 'Ϛ', '╵', '㟤', 'ᣝ', 'ཀ', '㈈',
					'㭈', 'ᾪ', 'Θ', '╶', '㞖', 'ᢉ', '༃', '㈂', '㬆', 'Ᾰ',
					'Ζ', '╤', '㞖', 'ᢙ', '༁', '㈯', '㭔', 'ι', 'ϗ', '┽',
					'㞖', 'ᢉ', '༂', '㈉', '㭏', 'ᾳ', 'δ', '┤', '㟕', 'ᢏ',
					'༭', '劥', '动', '刔', '啱', '玗', '慞', '丏', '姐', '擑',
					'涞', '䥣', '啊', '玗', '慞', '丕', '妄', '窟', '窕', '稭',
					'昹', '熬', '䳽', '䖄', '慙', '絪', '宒', '䤗', '晷', '燚',
					'䣭', '䣢', '䡞', '槲', '筓', '吪', '䎂', '纏', '矤', '匩',
					'伒', '槂', '筂', '吒', '䎜', '线', '矞', '匛', '렙', '렟',
					'뢭', '뿷', '餈', '讷', 'ꓺ', '덽', '蹊', 'ऎ', '\u0900', '\u09bb',
					'ዙ', '\u0ef7', '⠝', '㪴', 'ᗰ', 'ɪ', '㽻', '㘫', 'ዕ', '\u0ef5',
					'⠾', '㪲', 'ᗱ', 'Ƀ', '䨨', '䨣', '䪞', '止', '私', '四',
					'䅹', '籝', '甌', '凪', '䷡', '欣', '禄', '囯', 'բ', 'է',
					'ו', '␢', '㛕', 'ᦞ', 'ข', '㌀', 'ᛔ', 'ᛑ', 'ᙬ', '㟝',
					'╡', 'ਡ', 'ᶣ', 'ₐ', 'ﵜ', 'ﵔ', '\ufde5', '쉲', '\ue68d', '絛',
					'\udc57', '컢', '\ue188', '\uf632', '쬔', '鞲', '鞻', '霈', 'ꐚ', '譑',
					'鳖', 'ꇁ', 'ꢝ', '豤', '適', '뚿', 'ꐠ', '컙', '컈', '칢',
					'\uf1e6', '픊', '줧', '\uef8a', 'ﵩ', '툪', '얷', '\uf8b4', '\uf1d0', '픟',
					'줬', '\uefd4', 'ﵑ', '툱', '얜', '\uf8a1', '\uf1df', 'ም', 'ሎ', 'ኡ',
					'ᖧ', '㍚', '↢', '\u0ee8', '\u196e', '⑵', 'ⴷ', 'য়', 'ᗢ', '㌒',
					'⇦', '\u0ee8', '\u196f', '⑽', 'ⴴ', 'ৎ', 'ᗳ', '㌁', 'ↂ', '☳',
					'♿', '⚎', 'ݮ', 'ᗅ', '㪃', 'ⵐ', 'ၶ', 'ᤔ', '㷠', '⇊',
					'ܡ', 'ᖤ', '㫑', 'ⵗ', '၆', 'ᤋ', '㷴', '⇅', '܍', 'ᖚ',
					'㫢', 'ⴒ', '\u105e', 'ᤙ', '㷢', '⇆', 'ܢ', 'ᗈ', '㫄', 'ⵜ',
					'ၛ', 'ᤌ', '㷠', '⇌', '\u073c', 'ᖋ', '㪃', 'ⵜ', 'ၝ', 'ᤑ',
					'㷵', '⇙', 'ܫ', 'ᖋ', '㫛', '\u2d77', '꒞', 'ꑖ', 'ꐠ', '鯼',
					'뽠', 'ꍈ', '薶', '霋', '렮', '꿺', '鋲', '鮼', '뽘', 'ꍡ',
					'薗', '霤', '롪', '꾿', '鋂', '鮦', '뽘', 'ꍀ', '薸', '靥',
					'렢', '꿓', '鋓', '鮀', '뽢', 'ꌤ', '藊', '靵', '렾', '꾯',
					'銫', '鯽', '뽞', 'ꍥ', '薋', '霦', '롼', '꿾', '鋩', '鮻',
					'뼌', 'ꍙ', '薍', '霪', '롧', '꿫', '鋾', '鮧', '뽙', 'ꍣ',
					'薊', '霣', '론', '꿰', '鋜', '鮎', '뼌', 'ꌨ', '薯', '霉',
					'롛', '꿑', '銿', '鯼', '뼞', 'ꌵ', '藋', '霷', '롯', '꿷',
					'鋼', '鮧', '뽍', 'ꍲ', '薍', '靥', '롓', '꿳', '鋳', '鮴',
					'뽯', 'ꍟ', '藋', '靥', '롓', '꿭', '鋺', '鮦', '뽹', 'ꍟ',
					'藃', '需', '롂', '꿝', '鋞', '鮁', '뼌', 'ꍁ', '薷', '霄',
					'롋', '꿍', '鋜', '櫎', '櫅', '橱', '浴', '䯁', '奰', '瘪',
					'憼', '岺', '嗩', '焿', '浹', '䯡', '奔', '됱', '됺', '등',
					'螗', 'ꣷ', '뽧', '艧', '謮', '꿐', '돮', '锘', '螫', '\ua8ed',
					'뽋', '潿', '潦', '澾', '倔', '瓷', '梋', '乭', '峍', '玜',
					'搌', '夛', '偢', '瓭', '梗', '乧', '峐', '玜', '搋', '夒',
					'偷', '瓠', '梷', '乃', '峺', '珗', '摏', '夽', '偤', '뀾',
					'뀸', '냼', '虡', '轌', 'ꮵ', '랐', '酶', '莻', '☊', '☉',
					'⛉', '㷟', '⇿', '\u073b', '驒', '驅', '骖', '걠', 'ꔮ', '臓',
					'鷿', '묏', 'ꧽ', '蚰', '鄼', '갃', 'ꔹ', '膒', '鶭', '뭙',
					'ꧻ', '蚧', '鄀', '걳', 'ꕭ', '膅', '鶦', '뭃', 'ꧬ', '蚖',
					'뵺', '뵲', '붿', '躉', 'ꇊ', '똿', '謵', '艰', 'ꛨ', '뫉',
					'鰠', '\uf4b5', '\uf4bc', '\uf473', '쮌', '\uef62', '\uf343', '햽', '윊', '\ue840',
					'ￜ', '싗', '쮭', '囍', '囝', '嘊', '䩽', '巶', '悸', '槳',
					'䴏', '儣', '矅', '敹', '䩽', '嶧', '悠', '槧', '䴫', '具',
					'瞐', '收', '媙', '媚', '婑', '沸', '旲', '䄑', '斺', '攳',
					'敳', '䒆', '噁', '祂', '滨', '厛', '嫑', '縲', '打', '䒦',
					'噁', '神', '滕', '叞', '媂', '縨', '扅', '䒥', '噁', '祄',
					'滚', '变', '嫑', '繭', '扃', '䒩', '嘔', '祅', '滕', '叕',
					'媰', '縨', '扗', '䒨', '嘩', '祹', '溛', '厁', '媩', '繍',
					'戀', '䓧', '噍', '礃', '滗', '叚', '媟', '繧', '扉', '䒳',
					'嘑', '祅', '溛', '叞', '媃', '繩', '戀', '䒴', '嘓', '祏',
					'滏', '叏', '媔', '繤', '戀', '䓧', '噁', '礊', '溛', '厛',
					'嫑', '縨', '戀', '䓧', '⡯', '⡻', '⢥', 'ᮾ', '㓲', '⌊',
					'Ḁ', 'ᝑ', '㎲', '⾓', 'ल', 'ᯀ', '㒐', '⌀', 'Ṏ', 'ᝊ',
					'㎺', '⾜', 'ॡ', 'ᯘ', '㒓', '⌏', 'ḭ'
				};
				array = new char[8];
				(array as char[])[0] = '㽋';
				goto case 1;
			case 1:
				num = 5;
				break;
			case 4:
			case 5:
				(array as char[])[6] = 'ޚ';
				(array as char[])[4] = '㏛';
				goto case 0;
			case 0:
				num = 3;
				break;
			case 3:
				(array as char[])[1] = '㘁';
				(array as char[])[3] = 'Ა';
				num = ⴃႥ[16] - 27791;
				break;
			case 6:
				((char[])array)[7] = '᮲';
				((char[])array)[2] = '\u0b01';
				num = 7;
				break;
			case 7:
				((char[])array)[5] = 'ⅽ';
				Ⴃ = new string[203];
				Ⴗ = (char[])array;
				return;
			}
		}
	}
}
