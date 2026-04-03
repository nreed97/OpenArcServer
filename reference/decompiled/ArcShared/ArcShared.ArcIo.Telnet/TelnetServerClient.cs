using System;
using System.Net;
using System.Net.Sockets;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Windows.Forms;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Tcp;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods.Objects;
using Ⴃ;

namespace ArcShared.ArcIo.Telnet;

public sealed class TelnetServerClient : TcpServerClient
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1206)]
	private struct Ⴓ
	{
	}

	private static readonly Array Ⴅ;

	private static readonly Array Ⴍ = new char[603]
	{
		'哩', '哨', '哩', '䘹', '沝', '沜', '沜', '憨', '䐠', '䐬',
		'䐢', '睰', '睼', '栣', '嚅', '滶', '控', '璊', '䥗', '睧',
		'睧', '栎', '囷', '\uf868', '\uf864', '\uf86b', '쬣', '푧', '\uea82', '튕',
		'\udff9', '죏', '\uf514', '쬭', '쬲', '푹', '\uea8d', '튒', '﨟', '羽',
		'福', '쵘', '\udf8e', '\udf8c', '\udf8b', '\uec8a', '\uecf6', '䋿', '䋱', '䋹',
		'侲', '燭', '熧', '滭', '倽', '栾', '敮', '牍', '侟', '熾',
		'熂', '滭', '倗', '栘', '咊', '咒', '咍', '縙', '獄', '搠',
		'姷', '柇', '某', '碘', '䙤', '繚', '猆', '搋', '妸', '柅',
		'柇', '碉', '䙣', '繕', '猒', '搯', '姛', '柊', '柅', '碍',
		'䙓', '뎻', '뎵', '뎳', 'ꄐ', '餲', '鐠', '茋', '뺉', '胻',
		'胰', '龭', 'ꅓ', '饭', '鐡', '茑', '뻆', '胜', '䮦', '䮤',
		'䮯', '笹', '䚙', '직', '짋', '짋', '慠', '\ue5d7', '\udb2b', '\ue316',
		'\uee45', '縷', '쒤', '晴', '婢', '\ue5ef', '榑', '榌', '榚', '嫑',
		'䖜', '筳', '䍖', '丄', '大', '擶', '嫒', '嫖', '䖕', '筴',
		'䍍', '並', '奵', '擷', '嫛', '嫚', '䖞', '筷', '䍍', '並',
		'奵', '擷', '嫚', '嫏', '䖠', '笺', '䍺', '両', '턡', '턠',
		'턭', '\ue669', '쫣', '쫡', '쫮', '\ue962', '\ue97a', '\u0bc8', '\u0bca', '\u0bc6',
		'৳', '㇌', '\uf7dc', '\uf7de', '\uf7d3', '윤', '\ufaee', '倊', '倍', '倚',
		'立', '瞛', '悺', '嵬', '捁', '捔', '簛', '\ueb2f', '\ueb2a', '\ueb3e',
		'쇹', '첯', '\udb9e', '\ue652', '\ud879', '\udd86', '\udd84', '\udd94', '탻', '\ueed6',
		'H', '@', '[', '⪞', '⟟', 'ュ', 'ബ', '㌉', '㌂', 'ⱅ',
		'ኪ', '惣', '惢', '惷', '叫', '伂', '伎', '众', '籂', '按',
		'差', '旞', '梚', '翦', '䉵', '籕', '籍', '挅', '工', '旡',
		'Ꝓ', 'Ꝙ', 'Ꝅ', '趕', '胈', '韵', '\uaa39', '鐂', '鐟', '譝',
		'떰', '越', '胕', 'ﳲ', 'ﳽ', 'ﳥ', '탤', '\uee17', '혤', '\udb6f',
		'챚', '\uf1a3', '쾢', '쾩', '탿', '\uee1b', '혀', '\udb76', '챚', '\uf185',
		'쾞', '樻', '樢', '樣', '媐', '杏', '奱', '奼', '䙹', '磄',
		'䃠', '䶨', '媖', '杛', '奦', '奥', '䘶', '磓', '䂨', '䶫',
		'媑', '杈', '夿', '奧', '䘶', '磘', '䃼', '䶺', '媾', 'Ҫ',
		'Ҳ', 'ҳ', 'ᙓ', '\u2e7c', '〉', '㐂', '\u09d1', '㟈', '㟪', '⢥',
		'ᙔ', '\u2e75', '⌱', '㐭', 'ঢ়', '㟩', '㟪', '⢩', 'ᙳ', '\u2e68',
		'⌻', '㐜', '\u09fe', '㟸', '㟣', '⢌', '௩', '௹', '௳', '㢣',
		'㢨', '⟢', 'ᤖ', '℻', 'Ɐ', '㭘', 'ڜ', '㢤', '㢡', '⟥',
		'ᤍ', 'ℙ', 'ⰽ', '㭵', 'ڬ', '櫘', '櫞', '櫃', '柶', '姜',
		'姖', '䚰', '硞', '䁕', 'ꅱ', 'ꅵ', 'ꅭ', '鉩', '鉕', '贞',
		'도', '駂', '駆', '駟', 'ꪘ', '뗎', '謦', '댲', '喇', '喍',
		'喙', '罍', '爇', '攀', '壧', '曆', '曝', '禑', '䝣', '罄',
		'爠', 'ꆌ', 'ꆊ', 'ꆓ', '댧', '譚', '蘜', '酨', '곆', '鋿',
		'\u0bbd', '\u0bbf', '\u0b9d', '㭈', '۩', 'ࢉ', 'ࢃ', 'ࢨ', '㮖', '⒛',
		'\u1a6b', '≈', '⼉', '㠞', '\u05f7', '㯂', '㯈', '⒟', '꺪', '꺭',
		'꺈', 'ꏝ', '鷩', '鷥', '芥', '뱨', '萷', '駢', 'ㅄ', 'ㅂ',
		'ㅧ', 'ǥ', '㰠', 'ȁ', 'ȹ', 'ᵕ', '⎻', '涤', '涴', '涀',
		'缞', '䝹', '䨿', '崔', '惂', '廵', '廈', '䆶', '罆', '䝥',
		'䨤', '崳', '惚', '廯', '廥', '䆲', 'ꈫ', 'ꈬ', 'ꈎ', '酠',
		'踮', '냁', '裵', '薖', '鋁', '뾉', '䄋', '䄀', '䄭', '召',
		'比', '暾', '熪', '䱯', '牀', '版', '洌', '叒', '毋', '暋',
		'䴃', '䴉', '䴤', '綫', '䁽', '繆', '縍', '愄', '忾', '柟',
		'檚', '綢', '䁃', '뀆', '뀊', '뀮', '봰', '茋', '茂', '鰹',
		'ꊠ', '骚', '鞨', '胯', '뵕', '荹', '茀', '鰺', 'ﰄ', 'ﰆ',
		'ﰭ', '퀶', '\ueea0', '숙', '숛', '숳', '\ue5a0', '\uf2f2', '폨', '포',
		'폃', '\ue37c', '\udeae', '\ue098', '\ue08e', '쳯', '쳾', '쳃', '\ue0e8', '\ude10',
		'\ue63d', '\ueb7f', 'ﱛ', '솨', 'ﾩ', 'ﾴ', '\ue0dd', '\ude09', '\ue633', '\ueb74',
		'ﱹ', '솉', 'ﾪ', 'ﾩ', '\ue0ce', '톛', '톋', '톶', '\udcec', '\ue2d2',
		'\ue2dc', 'ﶭ', '쌰', 'ﭚ', '\uf600', '\ue12c', '\udcfa', '\ue2da', '\ue2d6', 'ﶖ',
		'썢', 'ﭸ', '\uf64f', '\ue17a', 'ﭮ', 'ﭫ', 'נּ', '\uf65c', '조', '정',
		'흜', '\ue9a6', '䯝', '䯔', '䯲', '奶', '慔', '汚', '筪', '䚪',
		'碋', '碗', '柛', '夗', '닟', '늛', '닯', '顝', '锝', '舫',
		'뿺', '臉', '膰', '麏', 'ꁣ', '顝', '锓', '舫', '뿸', '臖',
		'臇', '麍', 'ꀗ', '顕', '锆', '舨', '뾎', '臊', '臅', '麐',
		'ꀒ', '類', '镭', '舫', '뿠', '臃', '臉', '黻', 'ꁭ', '頩',
		'错', '航', '뾏'
	};

	private static readonly Array Ⴐ;

	internal static Ⴓ Ⴈ/* Not supported: data(E9 54 E8 54 E9 54 39 46 9D 6C 9C 6C 9C 6C A8 61 20 44 2C 44 22 44 70 77 7C 77 23 68 85 56 F6 6E A7 63 8A 74 57 49 67 77 67 77 0E 68 F7 56 68 F8 64 F8 6B F8 23 CB 67 D4 82 EA 95 D2 F9 DF CF C8 14 F5 2D CB 32 CB 79 D4 8D EA 92 D2 1F FA 1E FA 1B FA 58 CD 8E DF 8C DF 8B DF 8A EC F6 EC FF 42 F1 42 F9 42 B2 4F ED 71 A7 71 ED 6E 3D 50 3E 68 6E 65 4D 72 9F 4F BE 71 82 71 ED 6E 17 50 18 68 8A 54 92 54 8D 54 19 7E 44 73 20 64 F7 59 C7 67 D0 67 98 78 64 46 5A 7E 06 73 0B 64 B8 59 C5 67 C7 67 89 78 63 46 55 7E 12 73 2F 64 DB 59 CA 67 C5 67 8D 78 53 46 BB B3 B5 B3 B3 B3 10 A1 32 99 20 94 0B 83 89 BE FB 80 F0 80 AD 9F 53 A1 6D 99 21 94 11 83 C6 BE DC 80 A6 4B A4 4B AF 4B 39 7B 99 46 C1 C9 CB C9 CB C9 8A FA D7 E5 2B DB 16 E3 45 EE 50 F9 A4 C4 91 FA 80 FA EF E5 91 69 8C 69 9A 69 D1 5A 9C 45 73 7B 56 43 04 4E 27 59 F6 64 D2 5A D6 5A 95 45 74 7B 4D 43 26 4E 75 59 F7 64 DB 5A DA 5A 9E 45 77 7B 4D 43 26 4E 75 59 F7 64 DA 5A CF 5A A0 45 3A 7B 7A 43 21 4E 21 D1 20 D1 2D D1 69 E6 E3 CA E1 CA EE CA 62 E9 7A E9 C8 0B CA 0B C6 0B F3 09 CC 31 DC F7 DE F7 D3 F7 24 C7 EE FA 0A 50 0D 50 1A 50 CB 7A 9B 77 BA 60 6C 5D 41 63 54 63 1B 7C 2F EB 2A EB 3E EB F9 C1 AF CC 9E DB 52 E6 79 D8 86 DD 84 DD 94 DD FB D0 D6 EE 48 00 40 00 5B 00 9E 2A DF 27 E5 30 2C 0D 09 33 02 33 45 2C AA 12 E3 60 E2 60 F7 60 EB 53 02 4F 0E 4F 17 4F 42 7C 09 63 EE 5D DE 65 9A 68 E6 7F 75 42 55 7C 4D 7C 05 63 E5 5D E1 65 52 A7 58 A7 44 A7 95 8D C8 80 F5 97 39 AA 02 94 1F 94 5D 8B B0 B5 8A 8D D5 80 F2 FC FD FC E5 FC E4 D0 17 EE 24 D6 6F DB 5A CC A3 F1 A2 CF A9 CF FF D0 1B EE 00 D6 76 DB 5A CC 85 F1 9E CF 3B 6A 22 6A 23 6A 90 5A 4F 67 71 59 7C 59 79 46 C4 78 E0 40 A8 4D 96 5A 5B 67 66 59 65 59 36 46 D3 78 A8 40 AB 4D 91 5A 48 67 3F 59 67 59 36 46 D8 78 FC 40 BA 4D BE 5A AA 04 B2 04 B3 04 53 16 7C 2E 2A 23 02 34 D1 09 C8 37 EA 37 A5 28 54 16 75 2E 31 23 2D 34 DD 09 E9 37 EA 37 A9 28 73 16 68 2E 3B 23 1C 34 FE 09 F8 37 E3 37 8C 28 E9 0B F9 0B F3 0B A3 38 A8 38 E2 27 16 19 3B 21 6F 2C 58 3B 9C 06 A4 38 A1 38 E5 27 0D 19 19 21 3D 2C 75 3B AC 06 D8 6A DE 6A C3 6A F6 67 DC 59 D6 59 B0 46 5E 78 55 40 71 A1 75 A1 6D A1 69 92 55 92 1E 8D C4 B3 C2 99 C6 99 DF 99 98 AA CE B5 26 8B 32 B3 87 55 8D 55 99 55 4D 7F 07 72 00 65 E7 58 C6 66 DD 66 91 79 63 47 44 7F 20 72 8C A1 8A A1 93 A1 27 B3 5A 8B 1C 86 68 91 C6 AC FF 92 BD 0B BF 0B 9D 0B 48 3B E9 06 89 08 83 08 A8 08 96 3B 9B 24 6B 1A 48 22 09 2F 1E 38 F7 05 C2 3B C8 3B 9F 24 AA AE AD AE 88 AE DD A3 E9 9D E5 9D A5 82 68 BC 37 84 E2 99 44 31 42 31 67 31 E5 01 20 3C 01 02 39 02 55 1D BB 23 A4 6D B4 6D 80 6D 1E 7F 79 47 3F 4A 14 5D C2 60 F5 5E C8 5E B6 41 46 7F 65 47 24 4A 33 5D DA 60 EF 5E E5 5E B2 41 2B A2 2C A2 0E A2 60 91 2E 8E C1 B0 F5 88 96 85 C1 92 89 BF 0B 41 00 41 2D 41 EC 53 D4 6B BE 66 AA 71 6F 4C 40 72 48 72 0C 6D D2 53 CB 6B 8B 66 03 4D 09 4D 24 4D AB 7D 7D 40 46 7E 0D 7E 04 61 FE 5F DF 67 9A 6A A2 7D 43 40 06 B0 0A B0 2E B0 30 BD 0B 83 02 83 39 9C A0 A2 9A 9A A8 97 EF 80 55 BD 79 83 00 83 3A 9C 04 FC 06 FC 2D FC 36 D0 A0 EE 19 C2 1B C2 33 C2 A0 E5 F2 F2 E8 D3 EC D3 C3 D3 7C E3 AE DE 98 E0 8E E0 EF CC FE CC C3 CC E8 E0 10 DE 3D E6 7F EB 5B FC A8 C1 A9 FF B4 FF DD E0 09 DE 33 E6 74 EB 79 FC 89 C1 AA FF A9 FF CE E0 9B D1 8B D1 B6 D1 EC DC D2 E2 DC E2 AD FD 30 C3 5A FB 00 F6 2C E1 FA DC DA E2 D6 E2 96 FD 62 C3 78 FB 4F F6 7A E1 6E FB 6B FB 40 FB 5C F6 70 C8 15 C8 5C D7 A6 E9 DD 4B D4 4B F2 4B 76 59 54 61 5A 6C 6A 7B AA 46 8B 78 97 78 DB 67 17 59 DF B2 9B B2 EF B2 5D 98 1D 95 2B 82 FA BF C9 81 B0 81 8F 9E 63 A0 5D 98 13 95 2B 82 F8 BF D6 81 C7 81 8D 9E 17 A0 55 98 06 95 28 82 8E BF CA 81 C5 81 90 9E 12 A0 5E 98 6D 95 2B 82 E0 BF C3 81 C9 81 FB 9E 6D A0 29 98 19 95 2A 82 8F BF) */;

	public override bool Send(string msg)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		while (true)
		{
			base.LastSendDts = DxAtlasData.Ⴈ(14, 70);
			while (true)
			{
				IL_003f:
				object obj = ႣႼ.ႰႳ(ObjectCopierExt.Ⴄ(445, 491), msg, 430, 'ǯ');
				while (true)
				{
					IL_005f:
					int num = ⴃႣ[105] - 52223;
					while (true)
					{
						switch (num)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							num = 4;
							continue;
						case 4:
							break;
						case 3:
						case 5:
							goto IL_003f;
						case 2:
							goto IL_005f;
						case 1:
							return HostTcpServer.Send(Socket, obj as byte[]);
						}
						break;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static TelnetServerClient()
	{
		char[] array = new char[8];
		array[6] = 'Ɫ';
		array[0] = '㌤';
		array[2] = 'ツ';
		array[4] = '⪳';
		array[3] = '⟴';
		array[7] = '㌮';
		array[1] = 'ഒ';
		array[5] = 'ኋ';
		Ⴐ = new string[49];
		Ⴅ = array;
		UtilsIdentity.Ⴐ();
	}

	internal static string Ⴄ(int P_0, char P_1, int P_2)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj2 = default(object);
		int num6 = default(int);
		object obj6 = default(object);
		object obj3 = default(object);
		ISerializable serializable = default(ISerializable);
		char c = default(char);
		int num7 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = P_0 ^ 0x73F344CC ^ P_2;
			object ⴍ = Ⴍ;
			char[] obj = (char[])ⴍ;
			int num2 = obj[num];
			num2 = obj[num + 2] ^ num2;
			int num3 = 3;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = ⴗ[68] - 17886;
					continue;
				case 10:
					break;
				case 3:
					num3 = (((obj2 = ((string[])Ⴐ)[num2]) == null) ? (ⴐ[415] - 57869) : (ⴃႣ[215] - 32465));
					continue;
				case 15:
					return (string)obj2;
				case 1:
				{
					char[] obj4 = (char[])ⴍ;
					char[] obj5 = (char[])Ⴅ;
					num6 = num;
					obj6 = obj5;
					obj3 = obj4;
					num3 = 14;
					continue;
				}
				case 14:
					serializable = new StringBuilder();
					goto case 8;
				case 8:
					c = (obj3 as char[])[num6];
					num7 = ((char[])obj3)[num6 + 1] ^ c;
					num3 = 2;
					continue;
				case 2:
					num6 += 3;
					goto case 17;
				case 17:
					num5 = (num7 & 0x1F) | ((num7 & 0xFFC0) >> 1);
					num3 = 13;
					continue;
				case 7:
				case 13:
					num3 = (((num7 & 0x20) == 0) ? 11 : (ⴗ[55] - 6816));
					continue;
				case 12:
					num5 = (num5 << 15) | (((char[])obj3)[num6++] ^ c);
					num3 = ⴗ[115] - 18159;
					continue;
				case 11:
					num8 = ((char[])obj6).Length;
					num4 = 1;
					num3 = ⴐ[437] - 33217;
					continue;
				case 9:
					((StringBuilder)serializable).Append((char)(c ^ (obj3 as char[])[num6 + num5 - num4] ^ (obj6 as char[])[(num4 + num6 + 17) % num8]));
					num3 = 4;
					continue;
				case 4:
					num4++;
					num3 = ⴐ[41] - 59276;
					continue;
				case 16:
					num3 = ((num4 <= num5) ? 9 : (ⴃႤ[264] - 53639));
					continue;
				case 5:
					obj2 = (serializable as StringBuilder).ToString();
					((string[])Ⴐ)[num2] = obj2 as string;
					num3 = ⴃႤ[111] - 29459;
					continue;
				case 0:
					return obj2 as string;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴃ(DateTime P_0, TimeSpan P_1, char P_2, short P_3)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		DateTime result = default(DateTime);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 9:
				case 11:
					break;
				case 0:
					num2 = (((P_2 ^ P_3) - 110) ^ num) switch
					{
						0 => ⴃႤ[303] - 32031, 
						_ => 6, 
					};
					continue;
				case 6:
					result = default(DateTime);
					goto case 8;
				case 8:
					num2 = 7;
					continue;
				case 4:
				case 10:
					result = P_0 + P_1;
					num2 = ⴃႣ[184] - 34373;
					continue;
				case 7:
					num++;
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					num2 = ⴃႤ[320] - 20183;
					continue;
				case 2:
					num2 = ((num3 % 2 == 0) ? 3 : 0);
					continue;
				case 3:
					return result;
				case 5:
					num2 = ⴗ[101] - 49614;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴀ(char P_0, char P_1)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		IComparable comparable = default(IComparable);
		int num4 = default(int);
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
					num2 = 11;
					continue;
				case 11:
					break;
				case 10:
					num2 = (((P_0 ^ P_1) - 78) ^ num) switch
					{
						0 => ⴗ[33] - 33390, 
						_ => 0, 
					};
					continue;
				case 0:
					comparable = null;
					goto case 4;
				case 4:
				case 7:
					num2 = ⴀ[85] - 17498;
					continue;
				case 1:
				case 9:
					comparable = Environment.UserDomainName;
					num2 = 8;
					continue;
				case 8:
					num++;
					num4 = P_1 * P_1;
					num4 = P_1 + num4;
					num2 = 6;
					continue;
				case 6:
					num2 = ((num4 % 2 != 0) ? 10 : 5);
					continue;
				case 5:
					return (string)comparable;
				case 2:
				{
					char num3 = ⴗ[140];
					UtilsNumeric.Ⴀ[340] = (char)((UtilsNumeric.Ⴀ[340] - UtilsNumeric.Ⴀ[240]) & 0x19);
					num2 = num3 - 43350;
					continue;
				}
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, HorizontalAlignment P_1, char P_2, char P_3) where _0021_00210 : TextBox
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 7;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴗ[24] - 30801;
				continue;
			case 4:
				num = (((P_3 ^ P_2) - 100) ^ num2) switch
				{
					0 => 6, 
					_ => ⴀ[214] - 40453, 
				};
				continue;
			case 8:
				num = ⴃႭ[10] - 46802;
				continue;
			case 6:
				P_0.TextAlign = P_1;
				goto case 1;
			case 1:
				num2++;
				num3 = 1068;
				goto case 0;
			case 0:
				num4 = 152;
				break;
			case 2:
				break;
			case 3:
				return;
			}
			num = ((267 < num3 / 4 - num4) ? (ⴃႤ[438] - 63515) : (ⴐ[225] - 26611));
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : Socket
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 7;
				continue;
			case 7:
				num = (((P_1 ^ P_2) - 52) ^ num2) switch
				{
					0 => ⴗ[12] - 35090, 
					_ => 8, 
				};
				continue;
			case 8:
				num = 6;
				continue;
			case 0:
			case 1:
				P_0.Close();
				break;
			case 4:
			case 6:
				break;
			case 2:
				return;
			}
			num2++;
			int num3 = 1236;
			int num4 = 8;
			num = ((412 < num3 / 3 - num4) ? (ⴀ[51] - 42997) : 2);
		}
	}

	[SecuritySafeCritical]
	internal static IPAddress ႥႤ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
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
					num2 = 7;
					continue;
				case 7:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 44) ^ num) switch
					{
						0 => ⴃႤ[532] - 51864, 
						_ => ⴃႤ[210] - 27386, 
					};
					continue;
				case 10:
					obj = null;
					num2 = 6;
					continue;
				case 2:
				case 3:
					obj = IPAddress.Parse(P_0);
					num2 = 6;
					continue;
				case 6:
				case 9:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 != 0) ? 1 : (ⴃႤ[305] - 20873));
					continue;
				case 1:
				case 5:
					num2 = 4;
					continue;
				case 8:
					return (IPAddress)obj;
				case 11:
					num2 = ⴃႭ[49] - 57585;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object ႥႥ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : ResourceManager
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		object result = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[90] - 40883;
					continue;
				case 9:
					break;
				case 2:
				case 7:
					num2 = (((P_3 ^ P_2) - 23) ^ num) switch
					{
						0 => 0, 
						_ => 3, 
					};
					continue;
				case 3:
					result = null;
					goto case 10;
				case 10:
					num2 = ⴗ[139] - 41081;
					continue;
				case 0:
				case 8:
				{
					result = P_0.GetObject(P_1);
					char num4 = ⴀ[305];
					DataGridViewColumnSelector.Ⴐ[488] = (char)(DataGridViewColumnSelector.Ⴐ[488] & NeedsCfg.ႣႤ[21] & 0x10);
					num2 = num4 - 48550;
					continue;
				}
				case 11:
					num++;
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					num2 = ⴗ[140] - 43354;
					continue;
				case 6:
					num2 = ((num3 % 2 != 0) ? 2 : 4);
					continue;
				case 4:
					return result;
				case 5:
					num2 = ⴃႣ[21] - 1870;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime ႥႭ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : DxSpot
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		DateTime result = default(DateTime);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[42] - 36997;
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
				case 9:
					num2 = (((P_2 ^ P_1) - 3) ^ num) switch
					{
						0 => 11, 
						_ => 8, 
					};
					continue;
				case 8:
					result = default(DateTime);
					num2 = 1;
					continue;
				case 11:
					result = P_0.Dts;
					num2 = ⴃႣ[184] - 34379;
					continue;
				case 1:
				{
					num++;
					int num3 = 676;
					int num4 = 807;
					num2 = ((4035 <= num4 - num3 * 5) ? (ⴀ[230] - 37248) : 0);
					continue;
				}
				case 5:
				case 6:
				case 7:
					num2 = ⴃႤ[344] - 26225;
					continue;
				case 0:
					return result;
				case 2:
				case 10:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႥႰ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DataGridViewBand
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int result = default(int);
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
					num2 = ⴃႭ[167] - 37746;
					continue;
				case 7:
					break;
				case 2:
				case 10:
					num2 = (((P_2 ^ P_1) - 114) ^ num) switch
					{
						0 => ⴗ[148] - 25101, 
						_ => 1, 
					};
					continue;
				case 1:
					result = 2;
					num2 = ⴃႭ[209] - 32130;
					continue;
				case 5:
					result = P_0.Index;
					num2 = 6;
					continue;
				case 4:
				case 6:
				{
					num++;
					int num3 = 1836;
					int num4 = 303;
					num2 = ((612 < num3 / 3 - num4) ? 10 : 8);
					continue;
				}
				case 3:
				case 8:
					return result;
				case 0:
					num2 = ⴀ[198] - 33770;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႥႳ<_0021_00210>(ref float P_0, _0021_00210 P_1, char P_2, short P_3) where _0021_00210 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = 2;
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
				case 2:
				case 11:
					num2 = (((P_3 ^ P_2) - 22) ^ num) switch
					{
						0 => 8, 
						_ => 6, 
					};
					continue;
				case 6:
					convertible = null;
					goto case 3;
				case 3:
					num2 = 5;
					continue;
				case 8:
					convertible = P_0.ToString(P_1);
					num2 = 5;
					continue;
				case 5:
				{
					num++;
					int num3 = 349;
					int num4 = 554;
					num2 = ((1108 > num4 - num3 * 2) ? 9 : (ⴗ[157] - 44223));
					continue;
				}
				case 0:
					num2 = 2;
					continue;
				case 4:
				case 9:
					return (string)convertible;
				case 1:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}
}
