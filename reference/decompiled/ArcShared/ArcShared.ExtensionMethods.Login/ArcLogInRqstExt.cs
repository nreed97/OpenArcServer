using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using ArcInterfaces.Arcx;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods.Objects;
using WindowsFormsApplication1.ApplicationUpdates;
using log4net;
using log4net.Core;
using Ⴃ;

namespace ArcShared.ExtensionMethods.Login;

public static class ArcLogInRqstExt
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3882)]
	private struct Ⴅ
	{
	}

	internal sealed class ႠႷ
	{
		internal string Ⴄ;

		internal bool Ⴅ;

		internal ႠႷ()
		{
		}
	}

	private static readonly object Ⴀ;

	private static readonly object Ⴃ = new char[1941]
	{
		'爐', '虜', '爐', '쨶', '쩨', '픿', '\uebf7', '舎', '舌', '舏',
		'邻', '\ua881', 'ꂀ', 'ꂄ', 'ꂂ', '訙', '蜗', '逦', '귳', '\uee48',
		'\uee05', '\uee4b', '쓜', '짹', '\uded9', '\ue316', '\udd2d', '\udd30', '쉦', 'ﲏ',
		'쒮', '짲', '\udeab', '\ue37a', '\udd52', '\udd5a', '숊', 'ﳪ', '쓜', '짹',
		'\uded9', '\ue316', '\udd2d', '\udd30', '쉦', 'ﲏ', '쒮', '짲', '\udeab', '\ue376',
		'\udd45', '\udd41', '쉍', 'ﲭ', '쒒', '짎', '\udef8', '\ue309', '\udd42', '\udd0b',
		'쉏', 'ﲷ', '쒈', '짅', '\udedf', '\ue37d', '\udd40', '뤻', '뤺', '뤿',
		'訡', '䔯', '䔭', '䔪', '垙', '澠', '틄', '틌', '틂', '\ue1c9',
		'\ue199', 'ﺎ', '쀼', '\uf80e', '\uf551', '\ue264', '\udff6', '\uf539', '\uf52b', '\uf53e',
		'\ue7d7', '\udfe9', '튣', '얜', '\uf845', '외', '왣', '\ud935', '\ue7db', '\udfeb',
		'튀', '얘', '\uf847', '왴', '왑', '\ud93c', '\ue7dd', '\udfc6', '뙘', '뙚',
		'뙐', '蚻', '뭯', '㣧', '㣢', '㣮', 'ࠉ', '㗕', '\u0bfe', '௩',
		'ᒏ', '巗', '巐', '川', '睃', '稃', '浖', '傎', '溺', '溵',
		'熕', '霜', '非', '霗', '驺', 'ꑙ', 'ꑖ', '뭐', '藚', '뷮',
		'내', 'Ꭓ', '驡', 'ꑗ', 'ꑐ', '묒', '藻', '뷎', '낫', 'ꞽ',
		'驘', 'ꑋ', 'ꑧ', '묢', '藤', '뷋', '낉', 'ꞷ', '驢', 'ꑖ',
		'ꑅ', '묑', '藓', '뷳', '낏', 'Ꞿ', '驍', 'ꑤ', '純', '紞',
		'紘', '儥', '濌', '埢', '媲', '䶀', '灞', '乵', '乶', '儧',
		'濌', '삌', '삘', '삁', '퉡', '\uea56', '\ue70a', '\uf02d', '췍', '\uf388',
		'\uf3d1', '\uec80', '퉦', '\uea6c', '\ue758', '\uf03c', '췸', '\uf3c7', '\uf3d1', '\uec81',
		'퉵', '\uea5c', '\ue711', '\uf005', '蠭', '蠢', '蠣', '뭱', 'ꐪ', '髐',
		'ꋬ', '꾼', '뢺', '蕋', '뭼', '뭬', 'ꐭ', '髧', 'ꋮ', '꾵',
		'뢌', '蕷', '䥆', '䥌', '䥉', '掁', '滇', '秭', '䐶', '稣',
		'穈', '敔', '审', '掐', '滺', '\uedda', '\uedd6', '\uedca', '쩊', '\udd7b',
		'\ue0bc', '\ude9d', '\ude91', '쇖', '\uff3f', '윆', '쩍', '\udd6d', '\ue0a1', '\udeba',
		'턅', '턌', '턔', '\ue259', 'ﴂ', '쏸', '\ufbc4', '\uf694', '\ue192', '\udc67',
		'\ue242', '\ue27f', '\ue35a', '\ue35f', '\ue348', '큀', '콽', '\uf1e2', '즯', '쒃',
		'₮', '₹', '₽', 'ⷎ', 'Ꮿ', 'Ᏼ', 'ಠ', '㉌', 'ਜ਼', '\u0734',
		'ဇ', 'ⷉ', 'Ꮶ', 'Ꮿ', 'ಏ', '㉝', 'ੲ', 'ܘ', 'စ', 'ⷞ',
		'Ꮷ', 'Ꮿ', 'ಏ', '㉓', '\u0a7a', 'ܞ', 'ޝ', 'ޘ', 'މ', '૪',
		'㓌', '㓟', '⮞', 'ᕀ', '௱', '௶', '\u0be4', 'ⱸ', '㭹', 'ڢ',
		'㢀', '㢎', '⟖', 'ᤁ', 'ọ', 'ệ', 'ớ', 'ⶔ', 'ⶡ', '㋼',
		'క', '㑓', '㥮', '\u2e5e', 'ᎎ', 'ⶪ', '\u2d98', '༽', '༴', '༪',
		'◳', '⢞', '㾺', 'Ȃ', '㱎', '㱄', '⌎', '\u1df5', '◵', '婑',
		'婛', '婉', '圾', '椷', '椬', '癠', '䣷', '炮', '緷', '櫇',
		'圂', '椎', '鯦', '鯯', '鯿', '褐', '넂', '뱑', '\uab0f', '隸',
		'ꢐ', 'ꢚ', '럅', '褖', '珍', '珟', '珗', '䍴', '纎', '䂬',
		'䂱', '忩', '慫', '太', '呪', '䍌', '纋', '䂧', '䂬', '忬',
		'慫', '夼', '呪', '䍚', '纤', '䤻', '䤪', '䤠', '攤', '寡',
		'揍', '溝', '禹', '䐄', '穋', '穆', '攜', '寤', '揆', '満',
		'禼', '䐄', '穈', '穖', '攢', '볒', '볐', '볎', '鬎', '谶',
		'꿐', '꿑', '꿍', '鳄', 'ਜ', '\u0a03', '\u0a02', 'ܮ', '㤂', '㥆',
		'☝', 'ᣲ', '\u20c1', 'ⶆ', '㪷', 'ݭ', '㤘', '㥕', '☐', '\u18fe',
		'\u20db', '\u2d98', '㪵', 'ݫ', '㥌', '㥆', '☟', 'ᢷ', '\u20db', 'ⶆ',
		'㪽', 'ݧ', '㥔', '㥑', '♞', 'ᣇ', '\u20ec', 'ⶼ', '﹐', '﹇',
		'\ufe4f', '\ud984', '캮', '\uf32c', '촛', '촗', '퉆', '\uecab', '풆', '\ud9c7',
		'컬', '\uf327', '쵔', '촊', '퉑', '\uecbe', '풍', '\ud9ca', '컻', '\uf321',
		'쵔', '촮', '퉱', '\uec8f', 'ಱ', 'ಸ', '\u0c91', '㿻', '₶', 'Ṏ',
		'♡', '⬠', '㰛', 'Ǎ', '㿺', '㿜', '뿆', '뿏', '뿧', '顂',
		'软', '늻', '財', '貛', '鏈', '괤', '锁', '顧', '䜡', '䜭',
		'䜃', '瞑', '䩝', '瑠', '瑦', '欯', '嗩', '淦', '悰', '瞋',
		'䩟', '瑠', '瑛', '꩞', 'ꨛ', '\uaa7d', '髮', 'ꜭ', '餞', '饞',
		'虌', '뢶', '肞', '趄', '髨', 'ꜩ', '餎', '餃', '虝', '뢘',
		'肱', '跞', '髴', 'ꜩ', '餎', '餞', '虓', '뢖', '肱', '跙',
		'髾', 'ꜭ', '餕', '餜', '虒', '뢢', '肂', '跮', '髆', 'ꜫ',
		'餜', '餳', '虠', '쾭', '쿧', '쾉', 'ﲣ', '\ue3a2', '\udd49', '\ue56c',
		'\ue83f', 'ｉ', '싚', 'ﳥ', 'ﳪ', '\ue3a9', '\udd06', '\ue572', '\ue838', '\uff00',
		'싋', 'ﳻ', 'ﳢ', '\ue39f', '\udd06', '\ue575', '\ue83a', '，', '싗', 'ﳊ',
		'ﲣ', '\ue3bd', '\udd43', '\ue56e', '\ue82c', 'Ｚ', '슟', 'ﳮ', 'ﳭ', '\ue3a6',
		'\udd42', '\ue57f', '\ue836', '％', '싑', 'ﳾ', 'ﳬ', '\ue38b', '\udaa0', '\udabf',
		'\uda85', '힒', '\ue9be', '\ue9e3', '\uf6ad', '졙', '\uf075', 'ﵴ', '\uea00', 'ퟗ',
		'\ue9e0', '\ue9ef', '\uf6ad', '졇', '\uf07d', 'ﴣ', '\uea0b', 'ퟖ', '\ue9a4', '\ue9fa',
		'\uf6a3', '졏', '\uf03d', 'ﴧ', '\uea16', 'ퟗ', '\ue9f7', '\ue9db', '\uf6b5', '졟',
		'\uf07c', 'ﴘ', '\uebcc', '\uebce', '\uebea', '잋', '怒', '笊', '笀', '笭',
		'峞', '䮋', '癓', '䡧', '䡨', '坈', '槕', '凶', '岰', '䯮',
		'㌬', '㌪', '㌄', 'ᦿ', 'ᒝ', 'Σ', '㹷', 'D', '"', '⌆',
		'⌍', '⌯', 'Ꮲ', '⸤', 'ဟ', 'ၚ', '༁', '㇠', '\u09d8', 'қ',
		'Ꭹ', '\u2e67', 'ဂ', 'ⳤ', 'ⳬ', 'Ⳏ', '㹏', '٧', 'ଭ', '᱗',
		'ↂ', 'ᾯ', 'ᾦ', '¦', '㣥', '㣢', '㣎', '௫', 'ᒷ', '⩓',
		'ሴ', '\u1f7e', 'ࡃ', '㗗', '勒', '勔', '勾', '懖', '懌', '纍',
		'䀨', '砂', '甆', '㯠', '㯪', '㯍', '⥋', 'ᅣ', '\u1c29', '\u0b56',
		'㚗', 'ࢰ', 'ࢽ', '៣', '⤆', 'ᅳ', '舤', '般', '舊', '넠',
		'넺', '깻', '郍', 'ꣴ', 'ꖾ', '늉', '輖', '䁎', '䁄', '䁡',
		'勥', '櫍', '枇', '烻', '䴿', '猇', '猉', '汇', '劶', '櫝',
		'煵', '煲', '煅', '䉻', '嵱', '掑', '實', '囃', '䇼', '籇',
		'ἁ', 'Ἅ', 'ἰ', '㍃', 'ය', '㖏', '㢐', '⾵', 'ቦ', 'ⱁ',
		'ⱂ', '㌊', '\u0de1', '㗁', '㣕', '\ue474', '\ue47e', '\ue446', '쎠', '풀',
		'\ue95b', '흠', '흪', '젧', '\uf68f', '캨', '쏴', '풐', 'ߣ', 'ߤ',
		'ߐ', 'ᕈ', 'ⵠ', '\u202a', '㝄', 'ઞ', '㒡', '㓭', '金', '釞',
		'釥', 'ꋟ', '붃', '荧', '묌', '뙒', 'ꅺ', '鲭', 'ꊞ', 'ꊑ',
		'뷆', '茷', '묋', '뙎', 'ꅦ', '鳣', '틓', '틞', '틦', '\ue1dd',
		'ﺁ', '쁥', '\uf804', '\uf54e', '\ue27b', '\udfa0', '\ue181', '\ue190', 'ﻘ', '쀳',
		'\uf813', '\uf507', '硑', '硚', '硧', '櫺', '勒', '徘', '䣬', '田',
		'䬄', '䬒', '呚', '檱', '劑', '待', '\ued42', '\ued52', '\ued75', '\ude46',
		'\ude08', '셅', 'ﾽ', '잂', '쫃', '\udde4', '\ue03d', '\ude0f', '\ude07', '셓',
		'￩', '입', '쫙', '\udde8', '\ue070', '捂', '捊', '捺', '䒖', '厶',
		'湭', '倉', '倂', '佔', '熨', '䧑', '酃', '酈', '酺', '鱱',
		'ꉗ', 'ꉐ', '뵄', '莬', '뮟', '뛚', 'ꇣ', '鰿', 'ꈅ', 'ꉍ',
		'鏸', '鏱', '鏂', '腓', '륻', '됱', 'ꍅ', '麎', 'ꂸ', 'ꂣ',
		'뿸', '腓', 'ᵖ', 'ᵓ', 'ᵭ', '\u0fe7', '㞈', '㫍', '\u2de0', 'ဂ',
		'텠', '텫', '템', '\uf6b4', '\ue195', '\udc4f', '\ue236', '\ue22b', 'ﵯ', '쎆',
		'\ufbba', '\uf6ff', '\ue1d7', '\udc52', '覊', '覂', '覷', 'ꗈ', '鬰', 'ꌄ',
		'급', '뤺', '蓷', '뫂', '몄', '㡧', '㡠', '㡙', '\u0b63', '\u0b78',
		'ᐸ', '⪎', 'ኻ', '\u1ff1', 'ࢃ', 'ڈ', 'ڎ', 'ڷ', '\u0bba', '㖝',
		'㖛', '⪛', 'ᑠ', 'Ⱋ', '⻋', '⻁', '⺋', 'ʉ', '㱱', 'х',
		'\u094d', 'Ṫ', '⎭', 'ᶜ', 'ᶄ', '\u02c4', '㱠', '待', '徍', '忄',
		'劷', '沐', '沖', '玅', '䵭', '畘', '砘', '潡', '詬', '試',
		'訮', '\ua62e', '飖', 'ꃢ', '귩', '뫋', '蜓', '뤡', '뤩', '\ua67d',
		'飇', '뵌', '뵀', '봏', '꿧', '韎', '骅', '跭', '뀮', '踝',
		'踆', '酃', '꾮', '鞔', '髋', '趨', '祬', '祦', '礨', '䦈',
		'瑏', '䩵', '䩲', '唾', '毖', '厯', '廷', '䧜', '瑞', '\uddce',
		'\uddc9', '\udd8b', '\uf75d', '廓', '\ued37', '킿', '\uee85', '\uee86', '\uf18c', '禗',
		'禘', '科', '嗕', '欭', '匙', '帍', '䤤', '瓪', '䫝', '䫒',
		'喛', '歩', '卉', '帊', '䤸', '瓶', '䪓', 'ጺ', 'ጷ', '\u137d',
		'㽸', 'ƀ', '㦴', '㒪', '⎗', 'Ṅ', 'ⁿ', '\u2062', '㼵', 'ǘ',
		'㧢', '㒽', '⏞', '\ue538', '\ue533', '\ue570', '쾫', '싽', '헁', '\ue853',
		'홯', '홧', '줷', '\uf7da', '쿠', '슿', '헜', '桑', '桟', '栘',
		'竺', '䋓', '侘', '壱', '攦', '嬁', '嬌', '䑆', '窸', '䊏',
		'俌', '壾', '攰', '孕', '\ued81', '\ued89', '\uedcb', '\ude85', '\ude9e', '쇞',
		'･', '읜', '쨁', '\udd24', '\ue0b3', '\ue495', '\ue49e', '\ue4de', '죗', '\uf62f',
		'츛', '쌄', '퐵', '\ue9e8', 'ퟜ', 'ퟟ', '좙', '\uf67c', '츆', '\udf0b',
		'\udf02', '\udf47', '\uefef', '툨', '\uec12', '\uec5c', '\uf30d', '췤', '\uf5cd', '\uf89d',
		'\uefef', '\ue5e6', '\ue5e4', '\ue5ab', '훨', '즣', '뱩', '뱡', '밧', '賨',
		'넰', '輄', '輋', '逫', '꺶', '隕', '鯓', 'ṱ', 'Ṿ', 'Ḿ',
		'㒴', '㧲', '⻢', 'ጼ', 'ⴡ', 'ⴱ', '㉶', 'ಓ', '㒮', '㧆',
		'⻪', 'ጨ', 'ⵠ', 'ⴝ', '㉒', 'ᧂ', '\u19cc', 'ᦒ', 'ତ', '㌞',
		'㹕', '⤨', 'ᒼ', '⪏', '⪍', '㗍', 'ମ', '㍟', '㹆', '⥲',
		'ᒽ', '⪕', '㎀', '㎌', '㏑', 'ᥖ', '᐀', '\u0325', '㻦', '×',
		'Ü', 'ᾇ', 'ⅿ', '᥇', 'ᐛ', '\u0334', '㻡', 'ퟅ', 'ퟁ', '힗',
		'\uf05d', '\ue76d', '\udab6', '\ue482', '鷑', '鷖', '鶂', '輮', '뜌', '멀',
		'굸', '邮', '꺚', '꺜', '쭛', '쭟', '쬏', '\ue18c', '\uecc6', 'ﯭ',
		'옮', 'Ⱥ', 'Ȳ', 'ɯ', 'ㅠ', '⸫', 'ა', '⣪', '▫', '㊌',
		'ཇ', 'ㅸ', '沀', '沇', '泖', '懏', '徖', '忖', '䂐', '繊',
		'䘜', '䬯', '㧜', '㦖', '㦋', 'ᖞ', '⬺', 'ጀ', 'Ṛ', 'ॾ',
		'㓮', 'જ', 'ગ', 'ᗚ', '⬶', 'ጀ', 'Ṅ', 'ॶ', '㒹', 'ગ',
		'ખ', 'ᖞ', '⭾', 'ጛ', 'ṉ', 'ॼ', '㓠', 'ઋ', '\u0a80', 'ᗛ',
		'⬵', 'ጂ', 'ṍ', '\u0955', '㒭', 'ગ', '\u0ab4', 'ᖖ', '⭷', 'ጊ',
		'Ṅ', 'ॱ', '㒨', '\u0ad8', '\u0ab1', 'ᗱ', '⬑', '䝶', '䝿', '䜮',
		'矗', '䨐', '琳', '琼', '此', '喨', '润', '惭', '矴', '姝',
		'姗', '妄', '櫓', '疅', '䬸', '猁', '繀', '楪', '咽', '檜',
		'檅', '疟', '䜝', '䜏', '䝇', '淋', '悅', '瞻', '䩮', '瑕',
		'瑚', '欞', '嗠', '淯', '悌', '瞭', '䩮', '瑝', '瑃', '欪',
		'嗻', '淜', '悯', '㹫', '㹮', '㸰', 'ᒋ', '\u19ca', 'ຂ', '㌗',
		'പ', '䚩', '䚠', '䛵', '痹', '痩', '檮', '呋', '汶', '愞',
		'瘕', '䯉', '痌', '칷', '츴', '츪', '\ue235', '\udcc6', '\ue4b0', '\ue9e2',
		'ﺓ', '쌀', '﴿', 'ﴰ', '\ue273', '\udcdc', '\ue4a3', '\ue9ea', 'ﻕ', '쌋',
		'ﴼ', 'ﴺ', '\ue235', '\udc99', '\ue4ac', '\ue9f7', 'ﺓ', '쌁', 'ﴲ', 'ﴼ',
		'\ue267', '\udcdc', '\ue4ab', '\ue9f7', 'ﺓ', '쌁', 'ﴶ', 'ﴵ', '\ue27c', '\udc9d',
		'\ue482', 'ꦨ', '\ua9b8', '꧶', '\ua4c9', '髩', '髲', '薫', '뭇', '荫',
		'踉', '餞', 'ꓟ', '髺', '髴', '薯', '뭰', '荸', '踮', '餭',
		'ꦡ', '꧱', 'ꧾ', '茶', '踨', '饒', '꒟', '骷', '髴', '薞',
		'뭰', '茿', '踔', '餟', '꒞', '髤', '體', '藨', '묃', '茼',
		'踉', '饎', 'ꓮ', '骨', '髸', '薟', '뭱', '茨', '蹪', '饍',
		'ꓳ', '骯', '骦', '藨', '뭷', '茿', '踢', '餹', 'ꓨ', '骫',
		'髓', '藹', '묕', '茺', '蹾', '餸', '꒞', '髲', '髓', '薘',
		'뭴', '\uea9d', '\uea92', '\ueafd', '웅', '\uf878', '쁉', '촀', '\uda2a', '\ue7e3',
		'\ud9d5', '\ud9d2', '욜', '\uf836', '쁜', '촌', '\uda2d', '\ue7e1', '\ud9fc', '♝',
		'♖', '☼', 'ಀ', 'Ǟ', 'ᛶ', '⬡', 'ᔒ', 'ᔝ', '\u0a4a', '㒻',
		'ಇ', 'ǂ', 'ᛪ', 'ਚ', 'ਈ', '\u0a78', 'ݯ', '㥐', '㥝', '☖',
		'\u18f8', '\u20c8', 'ⶃ', '㪻', 'ݺ', '㤞', '㥐', '☖', '\u18fe', '\u20ca',
		'ⶋ', '㪭', 'ܨ', '㤏', '\uf34c', '\uf359', '\uf32f', '︹', '쀆', '쀋',
		'\udf40', '\ue1ae', '\ud99e', '퓕', '쏭', '\ufe2c', '쁈', '쀑', '\udf4a', '\ue1a9',
		'\ud990', '퓛', '쏭', '\ufe2d', '쁈', '쀟', '\udf1e', '\ue1bc', '녲', '녱',
		'넖', '艡', '鴮', 'ꏙ', '쓗', '쓑', '쒲', '\uf783', '\uf798', '\ue8d8',
		'혨', '\uee0d', '\ue361', '웡', '웪', '욇', '\ueafe', '푘', '\uec29', '\ue12f',
		'\uf658', '쯂', '\uf5be', '\uf5f5', '\ueafe', '푚', '\uec29', '鎥', '鏢', '鏂',
		'ꂥ', 'ꂢ', '뾚', '腔', '뤻', '됰', 'ꌻ', '麚', 'ꃀ', 'ꃐ',
		'뾚', '腔', '뤻', '됰', 'ꌻ', '麚', 'ꃀ', 'ꃐ', '뾣', '腲',
		'륲', '됍', 'ꌼ', '黍', 'ꂬ', 'ꃪ', '뾝', '脃', '륗', '됊',
		'ꌼ', '黍', 'ꂬ', 'ꃪ', '뾝', '脃', '륗', '됊', 'ꍉ', 'ꕨ',
		'ꕡ', 'ꔀ', '达', '苲', '闅', 'ꠖ', '阾', '阣', '襮', '랍',
		'辎', '턺', '털', '텓', '\udc14', '\ue220', '⊪', '⊤', '⋀', 'ሖ',
		'\u2ffc', 'ᇑ', 'ᇰ', '\u0ea6', 'い', 'ࡰ', 'Բ', 'ር', '\u2fe7', 'ᇅ',
		'ᆱ', 'ຊ', 'だ', '⦁', '⦅', '⧪', '⓶', '\u1ac8', '\u1ace', '\u05ad',
		'\ue551', '\ue555', '\ue53d', '협', '혖', '쥁', '\uf79d', '鎺', '鎹', '鏗',
		'뾡', '腅', '륊', '\u0e37', '\u0e3c', '๙', '⓰', '⦭', '㺜', '\u0366',
		'㵡', '㵼', '∡', '\u1cc8', '⓫', '⦳', '㺠', '絚', '絋', '紵',
		'丆', '丣', '兖', '澿', '垨', '嫱', '䷪', '瀦', '丛', '丝',
		'兔', '澒', '垶', '嫥', '䶫', '瀊', '丿', '퓘', '퓞', '풨',
		'\ud9ea', '\ue799', '\ue792', '\uf89a', '옋', '\ufe2f', '疇', '疅', '痶', '姅',
		'本', 'Δ', 'Γ', 'Ϧ', 'フ', 'ポ', '⾗', 'ᅲ', '⥮', '\u244e',
		'⏰', '鷡', '鷪', '鶒', '뇦', '輇', '뜳', '멛', '괅', '邝',
		'꺨', '꺺', '뇯', '輅', '뜑', '뇄', '뇉', '놰', '鷒', 'ꌼ',
		'鬘', '陸', '腲', '벳', '芔', '芆', '鷏', 'ꌉ', '鬁', '陗',
		'腄', '骔', '骑', '髡', '뚮', '衛', '뀈', '봨', 'ꨃ', '㬬',
		'㬣', '㭚', '\u082c', '\u082b', 'ᝤ', '⧺', 'ᆲ', '\u1cf7', '\u0bd1', '㘓',
		'࠸', 'ࡘ', 'ᝣ', '⧦', 'ᇄ', 'ᳰ', 'ஶ', 'Ⲓ', 'Ⲑ', '⳥',
		'㹍', '؎', '\uf304', '\uf307', '\uf37c', '풽', '쎍', '︹', '傐', '傓',
		'僩', '巖', '揱', '揹', '痖', '痌', '疬', '姀', '朼', '弁',
		'刌', '䕰', '碱', '䚢', '䚕', '姛', '朲', '強', '剖', '䕳',
		'碬', '䚱', '䚤', '姄', '木', '弑', '則', '䕁', '碘', '䚕',
		'䚞', '姷', '朁', 'ᾏ', 'Ί', 'ῴ', 'ത', '㕑', '㠔', '⼹',
		'ዻ', 'ⲋ', 'Ⲉ', '㎙', '\u0d65', '㕘', '㡕', '⼩', 'የ', '⳻',
		'Ⳍ', '㎂', '൫', '㕮', '㠏', '⼪', 'ድ', '⳨', 'ⲉ', '㏍',
		'ൡ', '㕐', '㠒', '⼭', 'ኽ', 'ⳉ', 'Ⳕ', '㎽', '൩', '㕓',
		'㠔', '⼙', 'ዩ', 'Ⳋ', 'ⳉ', '㎮', 'ത', '㕛', '㠕', '⼢',
		'ዹ', 'Ⳋ', 'Ⳏ', '㎁', '൪', '㕋', '㠔', '⼏', '隲', '隷',
		'雎', '萙', '뱅', '너', '\ua637', '鮀', '㬭', '㭯', '㭐', '\u0bc9',
		'㙒', 'ࡦ', 'ࡱ', 'ᜩ', '⦆', 'ᇺ', '\u1cbc', '\u0b8d', '㙞', 'ࡦ',
		'\u086f', 'ᜡ', '⧑', 'ᇱ', 'Ჽ', '\u0bc9', '㙋', 'ࡨ', 'ࡧ', 'ᝡ',
		'⧒', 'ᇭ', 'Ჰ', '\u0ba5', '㙍', '\u086c', 'ࡷ', '\u173c', '⧓', 'ᇲ',
		'Ლ', '\u0b91', '㙻', '첐', '처', '쳮', '\ude79', '\ue646', '\ueb33', 'ﰧ',
		'쇮', '\uffdd', 'ￊ', '\ue0a7', 'ᛂ', 'ᛌ', 'ᚽ', '㫒', 'Ь', '㰁',
		'ㅆ', '♧', '\u1ba2', '▱', '▟', '㫁', 'Х', '㰅', 'ㅷ', '♾',
		'ᮔ'
	};

	private static readonly object Ⴈ;

	internal static Ⴅ Ⴓ/* Not supported: data(32 F9 36 F9 32 F9 36 CA 68 CA 3F D5 F7 EB 0E 82 0C 82 0F 82 BB 90 81 A8 80 A0 84 A0 82 A0 19 8A 17 87 26 90 F3 AD 48 EE 05 EE 4B EE DC C4 F9 C9 D9 DE 16 E3 2D DD 30 DD 66 C2 8F FC AE C4 F2 C9 AB DE 7A E3 52 DD 5A DD 0A C2 EA FC DC C4 F9 C9 D9 DE 16 E3 2D DD 30 DD 66 C2 8F FC AE C4 F2 C9 AB DE 76 E3 45 DD 41 DD 4D C2 AD FC 92 C4 CE C9 F8 DE 09 E3 42 DD 0B DD 4F C2 B7 FC 88 C4 C5 C9 DF DE 7D E3 40 DD 3B B9 3A B9 3F B9 21 8A 2F 45 2D 45 2A 45 99 57 A0 6F C4 D2 CC D2 C2 D2 C9 E1 99 E1 8E FE 3C C0 0E F8 51 F5 64 E2 F6 DF 39 F5 2B F5 3E F5 D7 E7 E9 DF A3 D2 9C C5 45 F8 78 C6 63 C6 35 D9 DB E7 EB DF 80 D2 98 C5 47 F8 74 C6 51 C6 3C D9 DD E7 C6 DF 58 B6 5A B6 50 B6 BB 86 6F BB E7 38 E2 38 EE 38 09 08 D5 35 FE 0B E9 0B 8F 14 D7 5D D0 5D DD 5D 43 77 03 7A 56 6D 8E 50 BA 6E B5 6E 95 71 1C 97 5E 97 17 97 7A 9A 59 A4 56 A4 50 BB DA 85 EE BD B4 B0 B3 A7 61 9A 57 A4 50 A4 12 BB FB 85 CE BD AB B0 BD A7 58 9A 4B A4 67 A4 22 BB E4 85 CB BD 89 B0 B7 A7 62 9A 56 A4 45 A4 11 BB D3 85 F3 BD 8F B0 BE A7 4D 9A 64 A4 14 7D 1E 7D 18 7D 25 51 CC 6F E2 57 B2 5A 80 4D 5E 70 75 4E 76 4E 27 51 CC 6F 8C C0 98 C0 81 C0 61 D2 56 EA 0A E7 2D F0 CD CD 88 F3 D1 F3 80 EC 66 D2 6C EA 58 E7 3C F0 F8 CD C7 F3 D1 F3 81 EC 75 D2 5C EA 11 E7 05 F0 2D 88 22 88 23 88 71 BB 2A A4 D0 9A EC A2 BC AF BA B8 4B 85 7C BB 6C BB 2D A4 E7 9A EE A2 B5 AF 8C B8 77 85 46 49 4C 49 49 49 81 63 C7 6E ED 79 36 44 23 7A 48 7A 54 65 A1 5B 90 63 FA 6E DA ED D6 ED CA ED 4A CA 7B DD BC E0 9D DE 91 DE D6 C1 3F FF 06 C7 4D CA 6D DD A1 E0 BA DE 05 D1 0C D1 14 D1 59 E2 02 FD F8 C3 C4 FB 94 F6 92 E1 67 DC 42 E2 7F E2 5A E3 5F E3 48 E3 40 D0 7D CF E2 F1 AF C9 83 C4 AE 20 B9 20 BD 20 CE 2D EF 13 F4 13 A0 0C 4C 32 5B 0A 34 07 07 10 C9 2D E6 13 EF 13 8F 0C 5D 32 72 0A 18 07 05 10 DE 2D E7 13 EF 13 8F 0C 53 32 7A 0A 1E 07 9D 07 98 07 89 07 EA 0A CC 34 DF 34 9E 2B 40 15 F1 0B F6 0B E4 0B 78 2C 79 3B A2 06 80 38 8E 38 D6 27 01 19 CD 1E C7 1E DB 1E 94 2D A1 2D FC 32 15 0C 53 34 6E 39 5E 2E 8E 13 AA 2D 98 2D 3D 0F 34 0F 2A 0F F3 25 9E 28 BA 3F 02 02 4E 3C 44 3C 0E 23 F5 1D F5 25 51 5A 5B 5A 49 5A 3E 57 37 69 2C 69 60 76 F7 48 AE 70 F7 7D C7 6A 02 57 0E 69 E6 9B EF 9B FF 9B 10 89 02 B1 51 BC 0F AB B8 96 90 A8 9A A8 C5 B7 16 89 CD 73 DF 73 D7 73 74 43 8E 7E AC 40 B1 40 E9 5F 6B 61 2A 59 6A 54 4C 43 8B 7E A7 40 AC 40 EC 5F 6B 61 3C 59 6A 54 5A 43 A4 7E 3B 49 2A 49 20 49 24 65 E1 5B CD 63 9D 6E B9 79 04 44 4B 7A 46 7A 1C 65 E4 5B C6 63 80 6E BC 79 04 44 48 7A 56 7A 22 65 D2 BC D0 BC CE BC 0E 9B 36 8C D0 AF D1 AF CD AF C4 9C 1C 0A 03 0A 02 0A 2E 07 02 39 46 39 1D 26 F2 18 C1 20 86 2D B7 3A 6D 07 18 39 55 39 10 26 FE 18 DB 20 98 2D B5 3A 6B 07 4C 39 46 39 1F 26 B7 18 DB 20 86 2D BD 3A 67 07 54 39 51 39 5E 26 C7 18 EC 20 BC 2D 50 FE 47 FE 4F FE 84 D9 AE CE 2C F3 1B CD 17 CD 46 D2 AB EC 86 D4 C7 D9 EC CE 27 F3 54 CD 0A CD 51 D2 BE EC 8D D4 CA D9 FB CE 21 F3 54 CD 2E CD 71 D2 8F EC B1 0C B8 0C 91 0C FB 3F B6 20 4E 1E 61 26 20 2B 1B 3C CD 01 FA 3F DC 3F C6 BF CF BF E7 BF 42 98 6F 8F BB B2 A1 8C 9B 8C C8 93 24 AD 01 95 67 98 21 47 2D 47 03 47 91 77 5D 4A 60 74 66 74 2F 6B E9 55 E6 6D B0 60 8B 77 5F 4A 60 74 5B 74 5E AA 1B AA 7D AA EE 9A 2D A7 1E 99 5E 99 4C 86 B6 B8 9E 80 84 8D E8 9A 29 A7 0E 99 03 99 5D 86 98 B8 B1 80 DE 8D F4 9A 29 A7 0E 99 1E 99 53 86 96 B8 B1 80 D9 8D FE 9A 2D A7 15 99 1C 99 52 86 A2 B8 82 80 EE 8D C6 9A 2B A7 1C 99 33 99 60 86 AD CF E7 CF 89 CF A3 FC A2 E3 49 DD 6C E5 3F E8 49 FF DA C2 E5 FC EA FC A9 E3 06 DD 72 E5 38 E8 00 FF CB C2 FB FC E2 FC 9F E3 06 DD 75 E5 3A E8 0C FF D7 C2 CA FC A3 FC BD E3 43 DD 6E E5 2C E8 3A FF 9F C2 EE FC ED FC A6 E3 42 DD 7F E5 36 E8 05 FF D1 C2 FE FC EC FC 8B E3 A0 DA BF DA 85 DA 92 D7 BE E9 E3 E9 AD F6 59 C8 75 F0 74 FD 00 EA D7 D7 E0 E9 EF E9 AD F6 47 C8 7D F0 23 FD 0B EA D6 D7 A4 E9 FA E9 A3 F6 4F C8 3D F0 27 FD 16 EA D7 D7 F7 E9 DB E9 B5 F6 5F C8 7C F0 18 FD CC EB CE EB EA EB 8B C7 60 F9 0A 7B 00 7B 2D 7B DE 5C 8B 4B 53 76 67 48 68 48 48 57 D5 69 F6 51 B0 5C EE 4B 2C 33 2A 33 04 33 BF 19 9D 14 A3 03 77 3E 44 00 22 00 06 23 0D 23 2F 23 E2 13 24 2E 1F 10 5A 10 01 0F E0 31 D8 09 9B 04 A9 13 67 2E 02 10 E4 2C EC 2C CE 2C 4F 3E 67 06 2D 0B 57 1C 82 21 AF 1F A6 1F A6 00 E5 38 E2 38 CE 38 EB 0B B7 14 53 2A 34 12 7E 1F 43 08 D7 35 D2 52 D4 52 FE 52 D6 61 CC 61 8D 7E 28 40 02 78 06 75 E0 3B EA 3B CD 3B 4B 29 63 11 29 1C 56 0B 97 36 B0 08 BD 08 E3 17 06 29 73 11 24 82 2C 82 0A 82 20 B1 3A B1 7B AE CD 90 F4 A8 BE A5 89 B2 16 8F 4E 40 44 40 61 40 E5 52 CD 6A 87 67 FB 70 3F 4D 07 73 09 73 47 6C B6 52 DD 6A 75 71 72 71 45 71 7B 42 71 5D 91 63 E6 5B C3 56 FC 41 47 7C 01 1F 0D 1F 30 1F 43 33 BA 0D 8F 35 90 38 B5 2F 66 12 41 2C 42 2C 0A 33 E1 0D C1 35 D5 38 74 E4 7E E4 46 E4 A0 C3 80 D4 5B E9 60 D7 6A D7 27 C8 8F F6 A8 CE F4 C3 90 D4 E3 07 E4 07 D0 07 48 15 60 2D 2A 20 44 37 9E 0A A1 34 ED 34 D1 91 DE 91 E5 91 DF A2 83 BD 67 83 0C BB 52 B6 7A A1 AD 9C 9E A2 91 A2 C6 BD 37 83 0B BB 4E B6 66 A1 E3 9C D3 D2 DE D2 E6 D2 DD E1 81 FE 65 C0 04 F8 4E F5 7B E2 A0 DF 81 E1 90 E1 D8 FE 33 C0 13 F8 07 F5 51 78 5A 78 67 78 FA 6A D2 52 98 5F EC 48 30 75 04 4B 12 4B 5A 54 B1 6A 91 52 85 5F 42 ED 52 ED 75 ED 46 DE 08 DE 45 C1 BD FF 82 C7 C3 CA E4 DD 3D E0 0F DE 07 DE 53 C1 E9 FF 85 C7 D9 CA E8 DD 70 E0 42 63 4A 63 7A 63 96 44 B6 53 6D 6E 09 50 02 50 54 4F A8 71 D1 49 43 91 48 91 7A 91 71 9C 57 A2 50 A2 44 BD AC 83 9F BB DA B6 E3 A1 3F 9C 05 A2 4D A2 F8 93 F1 93 C2 93 53 81 7B B9 31 B4 45 A3 8E 9E B8 A0 A3 A0 F8 BF 53 81 56 1D 53 1D 6D 1D E7 0F 88 37 CD 3A E0 2D 02 10 60 D1 6B D1 5C D1 B4 F6 95 E1 4F DC 36 E2 2B E2 6F FD 86 C3 BA FB FF F6 D7 E1 52 DC 8A 89 82 89 B7 89 C8 A5 30 9B 04 A3 09 AE 3A B9 F7 84 C2 BA 84 BA 67 38 60 38 59 38 63 0B 78 0B 38 14 8E 2A BB 12 F1 1F 83 08 88 06 8E 06 B7 06 BA 0B 9D 35 9B 35 9B 2A 60 14 1B 2C CB 2E C1 2E 8B 2E 89 02 71 3C 45 04 4D 09 6A 1E AD 23 9C 1D 84 1D C4 02 60 3C 85 5F 8D 5F C4 5F B7 52 90 6C 96 6C 85 73 6D 4D 58 75 18 78 61 6F 6C 8A 66 8A 2E 8A 2E A6 D6 98 E2 A0 E9 AD CB BA 13 87 21 B9 29 B9 7D A6 C7 98 4C BD 40 BD 0F BD E7 AF CE 97 85 9A ED 8D 2E B0 1D 8E 06 8E 43 91 AE AF 94 97 CB 9A A8 8D 6C 79 66 79 28 79 88 49 4F 74 75 4A 72 4A 3E 55 D6 6B AF 53 F7 5E DC 49 5E 74 CE DD C9 DD 8B DD 5D F7 0B FA 37 ED BF D0 85 EE 86 EE 8C F1 97 79 98 79 D1 79 D5 55 2D 6B 19 53 0D 5E 24 49 EA 74 DD 4A D2 4A 9B 55 69 6B 49 53 0A 5E 38 49 F6 74 93 4A 3A 13 37 13 7D 13 78 3F 80 01 B4 39 AA 34 97 23 44 1E 7F 20 62 20 35 3F D8 01 E2 39 BD 34 DE 23 38 E5 33 E5 70 E5 AB CF FD C2 C1 D5 53 E8 6F D6 67 D6 37 C9 DA F7 E0 CF BF C2 DC D5 51 68 5F 68 18 68 FA 7A D3 42 98 4F F1 58 26 65 01 5B 0C 5B 46 44 B8 7A 8F 42 CC 4F FE 58 30 65 55 5B 81 ED 89 ED CB ED 85 DE 9E DE DE C1 65 FF 5C C7 01 CA 24 DD B3 E0 95 E4 9E E4 DE E4 D7 C8 2F F6 1B CE 04 C3 35 D4 E8 E9 DC D7 DF D7 99 C8 7C F6 06 CE 0B DF 02 DF 47 DF EF EF 28 D2 12 EC 5C EC 0D F3 E4 CD CD F5 9D F8 EF EF E6 E5 E4 E5 AB E5 E8 D6 A3 C9 69 BC 61 BC 27 BC E8 8C 30 B1 04 8F 0B 8F 2B 90 B6 AE 95 96 D3 9B 71 1E 7E 1E 3E 1E B4 34 F2 39 E2 2E 3C 13 21 2D 31 2D 76 32 93 0C AE 34 C6 39 EA 2E 28 13 60 2D 1D 2D 52 32 C2 19 CC 19 92 19 24 0B 1E 33 55 3E 28 29 BC 14 8F 2A 8D 2A CD 35 2E 0B 5F 33 46 3E 72 29 BD 14 95 2A 80 33 8C 33 D1 33 56 19 00 14 25 03 E6 3E D7 00 DC 00 87 1F 7F 21 47 19 1B 14 34 03 E1 3E C5 D7 C1 D7 97 D7 5D F0 6D E7 B6 DA 82 E4 D1 9D D6 9D 82 9D 2E 8F 0C B7 40 BA 78 AD AE 90 9A AE 9C AE 5B CB 5F CB 0F CB 8C E1 C6 EC ED FB 2E C6 3A 02 32 02 6F 02 60 31 2B 2E D0 10 EA 28 AB 25 8C 32 47 0F 78 31 80 6C 87 6C D6 6C CF 61 96 5F D6 5F 90 40 4A 7E 1C 46 2F 4B DC 39 96 39 8B 39 9E 15 3A 2B 00 13 5A 1E 7E 09 EE 34 9C 0A 97 0A DA 15 36 2B 00 13 44 1E 76 09 B9 34 97 0A 96 0A 9E 15 7E 2B 1B 13 49 1E 7C 09 E0 34 8B 0A 80 0A DB 15 35 2B 02 13 4D 1E 55 09 AD 34 97 0A B4 0A 96 15 77 2B 0A 13 44 1E 71 09 A8 34 D8 0A B1 0A F1 15 11 2B 76 47 7F 47 2E 47 D7 77 10 4A 33 74 3C 74 64 6B A8 55 A6 6D ED 60 F4 77 DD 59 D7 59 84 59 D3 6A 85 75 38 4B 01 73 40 7E 6A 69 BD 54 9C 6A 85 6A 9F 75 1D 47 0F 47 47 47 CB 6D 85 60 BB 77 6E 4A 55 74 5A 74 1E 6B E0 55 EF 6D 8C 60 AD 77 6E 4A 5D 74 43 74 2A 6B FB 55 DC 6D AF 60 6B 3E 6E 3E 30 3E 8B 14 CA 19 82 0E 17 33 2A 0D A9 46 A0 46 F5 46 F9 75 E9 75 AE 6A 4B 54 76 6C 1E 61 15 76 C9 4B CC 75 77 CE 34 CE 2A CE 35 E2 C6 DC B0 E4 E2 E9 93 FE 00 C3 3F FD 30 FD 73 E2 DC DC A3 E4 EA E9 D5 FE 0B C3 3C FD 3A FD 35 E2 99 DC AC E4 F7 E9 93 FE 01 C3 32 FD 3C FD 67 E2 DC DC AB E4 F7 E9 93 FE 01 C3 36 FD 35 FD 7C E2 9D DC 82 E4 A8 A9 B8 A9 F6 A9 C9 A4 E9 9A F2 9A AB 85 47 BB 6B 83 09 8E 1E 99 DF A4 FA 9A F4 9A AF 85 70 BB 78 83 2E 8E 2D 99 A1 A9 F1 A9 FE A9 36 83 28 8E 52 99 9F A4 B7 9A F4 9A 9E 85 70 BB 3F 83 14 8E 1F 99 9E A4 E4 9A D4 9A E8 85 03 BB 3C 83 09 8E 4E 99 EE A4 A8 9A F8 9A 9F 85 71 BB 28 83 6A 8E 4D 99 F3 A4 AF 9A A6 9A E8 85 77 BB 3F 83 22 8E 39 99 E8 A4 AB 9A D3 9A F9 85 15 BB 3A 83 7E 8E 38 99 9E A4 F2 9A D3 9A 98 85 74 BB 9D EA 92 EA FD EA C5 C6 78 F8 49 C0 00 CD 2A DA E3 E7 D5 D9 D2 D9 9C C6 36 F8 5C C0 0C CD 2D DA E1 E7 FC D9 5D 26 56 26 3C 26 80 0C DE 01 F6 16 21 2B 12 15 1D 15 4A 0A BB 34 87 0C C2 01 EA 16 1A 0A 08 0A 78 0A 6F 07 50 39 5D 39 16 26 F8 18 C8 20 83 2D BB 3A 7A 07 1E 39 50 39 16 26 FE 18 CA 20 8B 2D AD 3A 28 07 0F 39 4C F3 59 F3 2F F3 39 FE 06 C0 0B C0 40 DF AE E1 9E D9 D5 D4 ED C3 2C FE 48 C0 11 C0 4A DF A9 E1 90 D9 DB D4 ED C3 2D FE 48 C0 1F C0 1E DF BC E1 72 B1 71 B1 16 B1 61 82 2E 9D D9 A3 D7 C4 D1 C4 B2 C4 83 F7 98 F7 D8 E8 28 D6 0D EE 61 E3 E1 C6 EA C6 87 C6 FE EA 58 D4 29 EC 2F E1 58 F6 C2 CB BE F5 F5 F5 FE EA 5A D4 29 EC A5 93 E2 93 C2 93 A5 A0 A2 A0 9A BF 54 81 3B B9 30 B4 3B A3 9A 9E C0 A0 D0 A0 9A BF 54 81 3B B9 30 B4 3B A3 9A 9E C0 A0 D0 A0 A3 BF 72 81 72 B9 0D B4 3C A3 CD 9E AC A0 EA A0 9D BF 03 81 57 B9 0A B4 3C A3 CD 9E AC A0 EA A0 9D BF 03 81 57 B9 0A B4 49 A3 68 A5 61 A5 00 A5 BE 8F F2 82 C5 95 16 A8 3E 96 23 96 6E 89 8D B7 8E 8F 3A D1 38 D1 53 D1 14 DC 20 E2 AA 22 A4 22 C0 22 16 12 FC 2F D1 11 F0 11 A6 0E 44 30 70 08 32 05 2D 12 E7 2F C5 11 B1 11 8A 0E 60 30 81 29 85 29 EA 29 F6 24 C8 1A CE 1A AD 05 51 E5 55 E5 3D E5 11 D6 16 D6 41 C9 9D F7 BA 93 B9 93 D7 93 A1 BF 45 81 4A B9 37 0E 3C 0E 59 0E F0 24 AD 29 9C 3E 66 03 61 3D 7C 3D 21 22 C8 1C EB 24 B3 29 A0 3E 5A 7D 4B 7D 35 7D 06 4E 23 4E 56 51 BF 6F A8 57 F1 5A EA 4D 26 70 1B 4E 1D 4E 54 51 92 6F B6 57 E5 5A AB 4D 0A 70 3F 4E D8 D4 DE D4 A8 D4 EA D9 99 E7 92 E7 9A F8 0B C6 2F FE 87 75 85 75 F6 75 C5 59 2C 67 94 03 93 03 E6 03 D5 30 DD 30 97 2F 72 11 6E 29 4E 24 F0 23 E1 9D EA 9D 92 9D E6 B1 07 8F 33 B7 5B BA 05 AD 9D 90 A8 AE BA AE EF B1 05 8F 11 B7 C4 B1 C9 B1 B0 B1 D2 9D 3C A3 18 9B 78 96 72 81 B3 BC 94 82 86 82 CF 9D 09 A3 01 9B 57 96 44 81 94 9A 91 9A E1 9A AE B6 5B 88 08 B0 28 BD 03 AA 2C 3B 23 3B 5A 3B 2C 08 2B 08 64 17 FA 29 B2 11 F7 1C D1 0B 13 36 38 08 58 08 63 17 E6 29 C4 11 F0 1C B6 0B 92 2C 90 2C E5 2C 4D 3E 0E 06 04 F3 07 F3 7C F3 BD D4 8D C3 39 FE 90 50 93 50 E9 50 D6 5D F1 63 F9 63 D6 75 CC 75 AC 75 C0 59 3C 67 01 5F 0C 52 70 45 B1 78 A2 46 95 46 DB 59 32 67 37 5F 56 52 73 45 AC 78 B1 46 A4 46 C4 59 28 67 11 5F 47 52 41 45 98 78 95 46 9E 46 F7 59 01 67 8F 1F DB 1F F4 1F 24 0D 51 35 14 38 39 2F FB 12 8B 2C 88 2C 99 33 65 0D 58 35 55 38 29 2F E8 12 FB 2C CC 2C 82 33 6B 0D 6E 35 0F 38 2A 2F F5 12 E8 2C 89 2C CD 33 61 0D 50 35 12 38 2D 2F BD 12 C9 2C D4 2C BD 33 69 0D 53 35 14 38 19 2F E9 12 CA 2C C9 2C AE 33 24 0D 5B 35 15 38 22 2F F9 12 CA 2C CE 2C 81 33 6A 0D 4B 35 14 38 0F 2F B2 96 B7 96 CE 96 19 84 45 BC 08 B1 37 A6 80 9B 2D 3B 6F 3B 50 3B C9 0B 52 36 66 08 71 08 29 17 86 29 FA 11 BC 1C 8D 0B 5E 36 66 08 6F 08 21 17 D1 29 F1 11 BD 1C C9 0B 4B 36 68 08 67 08 61 17 D2 29 ED 11 B0 1C A5 0B 4D 36 6C 08 77 08 3C 17 D3 29 F2 11 9A 1C 91 0B 7B 36 90 CC 98 CC EE CC 79 DE 46 E6 33 EB 27 FC EE C1 DD FF CA FF A7 E0 C2 16 CC 16 BD 16 D2 3A 2C 04 01 3C 46 31 67 26 A2 1B B1 25 9F 25 C1 3A 25 04 05 3C 77 31 7E 26 94 1B) */;

	public static string SerializeNode(this ArcLogInRqst arcLogInRqst)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			XName name = AnnWxSpotExt.Ⴍ(ႣႼ.Ⴜ(2, 365386179, 15), 'ȝ', 605);
			Array array = new object[3];
			((object[])array)[0] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 5, 192632123), 'ó', 179), PrecisionTimer.ႤႳ(arcLogInRqst, 339, 'ă'));
			((object[])array)[1] = new XElement(AnnWxSpotExt.Ⴍ(UtilsString.Ⴐ(null, 4, 192632267), 'ż', 316), ObjectCopierExt.ႥႨ(arcLogInRqst, 787, '\u0304'));
			((object[])array)[2] = new XElement(UtilsString.Ⴐ(null, 3, 192632258), arcLogInRqst.Type);
			XContainer xContainer = new XElement(name, (object[])array);
			int num = ⴗ[72] - 50240;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴗ[19] - 27392;
					continue;
				case 2:
				case 5:
					break;
				case 3:
					return (xContainer as XElement).ToString();
				}
				break;
			}
		}
	}

	public static void DeserializeNode(this ArcLogInRqst arcLogInRqst, string strXml)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		XContainer xContainer = DgvCheckBoxColumnFilter.Ⴓ(strXml, '0', 27);
		object enumerator = (xContainer as XElement).Elements().GetEnumerator();
		try
		{
			int num = 3;
			XContainer current = default(XContainer);
			object obj = default(object);
			IConvertible convertible = default(IConvertible);
			while (true)
			{
				switch (num)
				{
				default:
					num = 5;
					continue;
				case 6:
				case 13:
					current = ((IEnumerator<XElement>)enumerator).Current;
					obj = DxCommentExtCfg.ႷႭ(UtilsXml.Ⴓ((XElement)current, 848, '\u034b'), 431, 429);
					num = ⴐ[591] - 13388;
					continue;
				case 8:
					num = (((convertible = (string)obj) == null) ? 5 : 11);
					continue;
				case 11:
				case 15:
					num = (FrmUpdating.ႠႥ((string)convertible, UtilsString.Ⴐ(null, 8, 192632118), 246, 202) ? (ⴐ[115] - 41178) : (ⴃႤ[282] - ⴃႤ[282]));
					continue;
				case 0:
					num = (FrmUpdating.ႠႥ((string)convertible, UtilsString.Ⴐ(null, 7, 192632264), 356, 344) ? (ⴐ[487] - 19316) : 9);
					continue;
				case 9:
					num = (FrmUpdating.ႠႥ((string)convertible, UtilsString.Ⴐ(null, 8, 192632265), 214, 234) ? 7 : 2);
					continue;
				case 2:
					num = 5;
					continue;
				case 12:
					arcLogInRqst.Call = FrmUpdating.ႠႭ(current as XElement, 841, 769);
					num = ⴀ[100] - 44554;
					continue;
				case 4:
					arcLogInRqst.Message = ((XElement)current).Value;
					num = ⴃႣ[151] - 9082;
					continue;
				case 7:
					arcLogInRqst.Type = ((XElement)current).Value;
					break;
				case 1:
				case 5:
					break;
				case 10:
					goto end_IL_003b;
				}
				num = (((IEnumerator<XElement>)enumerator).MoveNext() ? 13 : 10);
				continue;
				end_IL_003b:
				break;
			}
		}
		finally
		{
			int num2 = 1;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((enumerator is IEnumerator<XElement>) ? 2 : 0);
					goto IL_0250;
				case 2:
				case 5:
					((IEnumerator<XElement>)enumerator).Dispose();
					break;
				case 0:
					break;
				}
				break;
				IL_0250:
				num2 = num3;
			}
		}
		switch (0)
		{
		}
	}

	[SecuritySafeCritical]
	static ArcLogInRqstExt()
	{
		char[] array = new char[8];
		array[3] = '⟴';
		array[0] = '㌤';
		array[6] = 'Ɫ';
		array[1] = 'ഒ';
		array[5] = 'ኋ';
		array[4] = '⪳';
		array[2] = 'ツ';
		array[7] = '㌮';
		Ⴈ = new string[128];
		Ⴀ = array;
		UtilsIdentity.Ⴐ();
	}

	internal static string Ⴗ(int P_0, byte P_1, int P_2)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		IComparable<string> comparable = default(IComparable<string>);
		int num7 = default(int);
		Array array2 = default(Array);
		Array array = default(Array);
		ISerializable serializable = default(ISerializable);
		char c = default(char);
		int num6 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = P_0 ^ 0x65B73B84 ^ P_2;
			object ⴃ = Ⴃ;
			char[] obj = (char[])ⴃ;
			int num2 = obj[num];
			num2 = obj[num + 2] ^ num2;
			int num3 = ⴀ[284] - 27900;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = 6;
					continue;
				case 6:
					break;
				case 3:
					num3 = (((comparable = ((string[])Ⴈ)[num2]) == null) ? (ⴃႣ[69] - 61587) : 0);
					continue;
				case 0:
					return comparable as string;
				case 9:
				{
					char[] obj2 = (char[])ⴃ;
					char[] obj3 = (char[])Ⴀ;
					num7 = num;
					array2 = obj3;
					array = obj2;
					num3 = ⴗ[39] - 40804;
					continue;
				}
				case 10:
					serializable = new StringBuilder();
					c = (array as char[])[num7];
					goto case 1;
				case 1:
					num6 = ((char[])array)[num7 + 1] ^ c;
					num3 = 14;
					continue;
				case 14:
					num7 += 3;
					num5 = (num6 & 0x1F) | ((num6 & 0xFFC0) >> 1);
					num3 = 17;
					continue;
				case 8:
				case 17:
					num3 = (((num6 & 0x20) == 0) ? 2 : 13);
					continue;
				case 13:
				{
					int num9 = num5;
					NeedsCfg.ႣႤ[331] = (NeedsCfg.ႣႤ[331] | P_0) & 0x2B;
					num5 = (num9 << 15) | (((char[])array)[num7++] ^ c);
					num3 = 2;
					continue;
				}
				case 2:
					num8 = ((char[])array2).Length;
					num4 = 1;
					num3 = 7;
					continue;
				case 4:
					((StringBuilder)serializable).Append((char)(c ^ ((char[])array)[num7 + num5 - num4] ^ ((char[])array2)[(num4 + num7 + 17) % num8]));
					num3 = ⴐ[65] - 53819;
					continue;
				case 12:
					num4++;
					num3 = 7;
					continue;
				case 7:
					num3 = ((num4 <= num5) ? (ⴃႤ[542] - 60409) : 11);
					continue;
				case 11:
					comparable = ((StringBuilder)serializable).ToString();
					((string[])Ⴈ)[num2] = comparable as string;
					num3 = 15;
					continue;
				case 15:
					return comparable as string;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ILog Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		ILoggerWrapper loggerWrapper = default(ILoggerWrapper);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[510] - 12614;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
				case 6:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 95) ^ num) switch
					{
						0 => 0, 
						_ => ⴃႤ[418] - 42615, 
					};
					continue;
				case 10:
					loggerWrapper = null;
					num2 = 5;
					continue;
				case 0:
				case 9:
					loggerWrapper = LogManager.GetLogger(P_0);
					num2 = ⴃႣ[19] - 59486;
					continue;
				case 5:
				{
					num++;
					int num3 = 794;
					int num4 = 310;
					num2 = ((397 < num3 / 2 - num4) ? 1 : 7);
					continue;
				}
				case 7:
					return loggerWrapper as ILog;
				case 8:
					num2 = ⴃႭ[147] - 4520;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, short P_3) where _0021_00210 : Control
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				continue;
			case 5:
			case 6:
				num = (((P_2 ^ P_3) - 33) ^ num2) switch
				{
					0 => ⴃႤ[445] - 24897, 
					_ => ⴗ[1] - 50402, 
				};
				continue;
			case 3:
			case 7:
				num = 2;
				continue;
			case 1:
				P_0.Visible = P_1;
				break;
			case 2:
				break;
			case 4:
				return;
			}
			num2++;
			int num3 = 1768;
			int num4 = 382;
			num = ((442 < num3 / 4 - num4) ? 5 : 4);
		}
	}

	[SecuritySafeCritical]
	internal static MouseButtons Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : MouseEventArgs
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		MouseButtons result = default(MouseButtons);
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
					num2 = 3;
					continue;
				case 3:
					break;
				case 4:
				case 9:
				case 10:
					num2 = (((P_1 ^ P_2) - 33) ^ num) switch
					{
						0 => ⴗ[141] - 5934, 
						_ => ⴃႣ[194] - 48171, 
					};
					continue;
				case 1:
					result = MouseButtons.None;
					num2 = ⴐ[317] - 12081;
					continue;
				case 8:
					result = P_0.Button;
					num2 = 7;
					continue;
				case 7:
				{
					num++;
					int num3 = 1768;
					int num4 = 382;
					int num5 = num3 / 4 - num4;
					NeedsCfg.ႣႤ[293] = (NeedsCfg.ႣႤ[293] ^ P_1) & 0x67;
					num2 = ((442 < num5) ? 10 : (ⴐ[268] - 57301));
					continue;
				}
				case 2:
				case 5:
					return result;
				case 6:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static FileStream Ⴜ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		object obj = default(object);
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
					num2 = ⴗ[26] - 58713;
					continue;
				case 3:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 33) ^ num) switch
					{
						0 => ⴃႣ[190] - 32270, 
						_ => ⴃႤ[178] - 25811, 
					};
					continue;
				case 1:
					obj = null;
					num2 = 2;
					continue;
				case 5:
				case 10:
					obj = File.OpenRead(P_0);
					num2 = 2;
					continue;
				case 2:
					num++;
					goto case 4;
				case 4:
				{
					int num4 = 1768;
					int num5 = 382;
					num2 = ((442 < num4 / 4 - num5) ? 7 : 9);
					continue;
				}
				case 0:
				case 9:
					return (FileStream)obj;
				case 8:
				{
					char num3 = ⴗ[89];
					TalkCfg.ႣႣ[64] = (char)((TalkCfg.ႣႣ[64] + P_1) & 0x1F);
					num2 = num3 - 20997;
					continue;
				}
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႠ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : DataGridViewCellPaintingEventHandler where _0021_00211 : DataGridView
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 4;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 2;
				break;
			case 2:
				num = (((P_3 ^ P_2) - 101) ^ num3) switch
				{
					0 => 8, 
					_ => ⴗ[63] - 23261, 
				};
				break;
			case 3:
				num = 0;
				break;
			case 8:
				P_0.CellPainting += P_1;
				goto case 0;
			case 0:
			case 5:
				num3++;
				goto case 9;
			case 9:
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = 1;
				break;
			case 1:
			case 7:
				num = ((num2 % 2 != 0) ? 2 : 6);
				break;
			case 6:
				return;
			}
		}
	}
}
