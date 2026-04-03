using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.Forms;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class UtilsString
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 5350)]
	private struct Ⴓ
	{
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴅ
	{
		internal string Ⴄ;

		internal float Ⴗ;
	}

	private static readonly object Ⴄ;

	private static readonly Array Ⴗ = new char[2675]
	{
		'\ud86c', '\ud86d', '\ud86c', '\uda4a', '嶐', '嶖', '嶑', '熗', '佷', '睁',
		'稅', '洺', '僇', '⫲', '⫥', '⫰', 'ᦤ', 'ᦹ', '\u06e4', '㠕',
		'(', '\u0d40', '\u1a58', '➍', 'ᦣ', 'ᦰ', 'ۿ', '㠺', '9', '൩',
		'\u1a74', '➋', 'ᦵ', 'ᦹ', '۸', '㠺', '7', 'ൡ', '\u1a72', '쏅',
		'쏁', '쏆', '\uf0e1', '\uefd3', '턡', '\ue938', '暹', '暸', '暽', '䅽',
		'嫩', '嫨', '嫬', '槶', '퇽', '톱', '퇻', 'ﶸ', '쌳', '\ufb1b',
		'\uf645', '\ue178', '\udcb9', '\ue295', '\ue29f', '\ufdca', '쌸', 'ﭩ', '\uf629', '\ue104',
		'\udccf', '\ue2f0', '\ue2f4', '\ufdda', '쌣', 'ﬂ', '\uf648', '\ue16f', '\udca3', '\ue295',
		'\ue286', '\ufdd1', '썑', 'ﭢ', '\uf620', '\ue11e', '\udc88', '\ue2b7', '\ue2ba', '\ufded',
		'쌂', 'יִ', '\uf627', '\ue154', '\udc8a', '\ue2ad', '\ue2a0', '\ufde6', '쌥', 'ﭩ',
		'\uf625', '駇', '駁', '駀', 'ꪵ', '뗖', '謫', '댛', '빿', '꥟',
		'叇', '叒', '叏', '惉', '翊', '䄸', '祔', '瑗', '捦', '庸',
		'悎', '悀', '翗', '䄸', '祔', '瑀', '捦', '庹', '悊', '悏',
		'羅', '䄫', '礛', '瑿', '獂', '獃', '獋', '咼', '㹘', '㹙',
		'㹒', '\u1dd3', '‼', '‽', '‷', 'ޖ', '⡌', '⡔', '⡀', 'њ',
		'㪦', 'ʛ', '\u0f96', 'ᣅ', '┟', '\u1b34', 'ᬉ', 'с', '㪨', 'ʝ',
		'࿔', 'ᣤ', '┿', 'ᬫ', 'ᬇ', 'Ѹ', '㪴', 'ʪ', '\u0fe4', 'ᣯ',
		'┸', 'ᬫ', '\u1b3e', '渂', '渀', '渏', '䦽', '庉', '䖓', '䖒',
		'䖝', '昙', '揁', '揞', '揎', '滳', '僟', '傁', '俌', '焣',
		'䤆', '䑅', '占', '溰', '傝', '傪', '侃', '焾', '䤗', '䑞',
		'卦', '溼', '傶', '像', '俈', '焩', '䤓', '䑗', '卩', '溿',
		'傄', '催', '俇', '焫', '䤗', '䑧', 'ﳪ', 'ﳴ', 'ﳺ', '챀',
		'\uf197', '쾧', '쾰', '탸', '\uee04', '혺', '\udb66', '챫', '\uf19c', '쾫',
		'쾷', '탧', '\uee11', '혪', '\udb77', '챪', '\uf18c', '쾭', '쾡', '탢',
		'\uee03', '혖', '\udb30', '챃', '\uf19d', '쾺', '쾷', '탱', '\uee32', '㋵',
		'㋯', '㋤', 'Ư', 'Ỷ', '‚', 'ᡨ', 'ᔱ', 'ȁ', '㿖', 'ơ',
		'ƴ', 'ể', '“', 'ᠳ', 'ᕑ', 'ɉ', '㾣', 'ƍ', 'ƫ', 'Ợ',
		'\u200a', 'ᠣ', 'ᕒ', 'ɭ', '㾀', 'Ʒ', 'Ƙ', 'ị', 'ᑖ', 'ᑈ',
		'ᑄ', '✜', '✗', '㡝', 'ک', '㺕', '㏇', '⓱', '\u193c', '✗',
		'❘', '㡚', 'ڲ', '㺌', '㏖', '⓳', '\u1927', '✛', '✞', '㡝',
		'گ', '㺀', '㏔', '⒲', '\u1930', '✜', '✝', '㡀', 'ڳ', '㺊',
		'㏡', '쟷', '쟻', '쟤', '\uf4bc', '\uebe1', '픝', '\ued20', '\ue073', '\uf766',
		'쫕', '\uf4e3', '\uf4e8', '\uebe5', '픓', '\ued10', '撃', '撛', '撗', '吳',
		'槰', '埃', '垃', '䢕', '白', '也', '䌜', '吤', '槾', '埫',
		'埝', '䢨', '癔', '乀', '䌂', '吳', '槴', '埴', '埱', '䢆',
		'癮', '乳', '䌫', '\ue630', '\ue63f', '\ue625', '쳦', '솰', '횕', '\ueb46',
		'핤', '핋', '쨦', '\uf4ce', '쳬', '솯', '횗', '\ueb4d', '하', '핮',
		'쨛', '橋', '橞', '橝', '䂖', '䷐', '嫦', '札', '夎', '夗',
		'䙜', '碧', '䂑', '䷙', '嫡', '朶', '夬', '奅', '䙇', '碯',
		'䂑', '䷋', '嫮', '札', '夼', '臨', '淋', '李', '쥋', '\uf481',
		'쪙', 'ⅺ', 'ⅶ', 'Ⅲ', 'Ⱅ', 'ሒ', 'መ', '൙', '㎲', '\u0be4',
		'ۀ', 'ᇷ', 'Ⱟ', 'ሑ', 'መ', '\u0d63', '뎉', '뎔', '뎐', '뻦',
		'胼', '胢', '龹', 'ꅄ', '餗', '鐩', '茞', '뻞', '胹', '胩',
		'龤', 'ꅁ', '餗', '鐿', '茞', '뻈', '胖', '肇', '龯', 'ꅌ',
		'饻', '鑝', '茆', '뺥', '肑', '胞', '龟', 'ꅁ', '꽫', '꽷',
		'꽱', '鰲', '鰔', '荌', '붲', '薞', '袲', '鿻', 'ꈪ', '鰊',
		'鰑', '荇', '붯', '薛', '袲', '鿸', 'ꈺ', '鰴', '鱥', '荍',
		'붮', '薙', '袿', '鿤', 'ꉇ', '鱳', '鰼', '荽', '붣', 'ꆽ',
		'ꇴ', 'ꆦ', '譳', '蘘', '鄼', '곽', '鋟', '銾', '趋', '덥',
		'譋', '蘝', '鄷', '고', '鋚', '銾', '趝', '덥', '譝', '蘲',
		'酙', '곫', '鋗', '鋒', '跿', '덳', '識', '虷', '酅', '곖',
		'鋭', '鋐', '跿', '덲', '譀', '蘈', '酙', '곤', '銧', '銯',
		'趦', '덂', '譍', '錊', '鍂', '錖', 'ꁙ', '뼹', '臄', '맫',
		'뒸', 'ꏣ', '鹌', 'ꁽ', 'ꁡ', '뼼', '臏', '맶', '뒽', 'ꏣ',
		'鹏', 'ꁭ', 'ꁟ', '뽈', '臅', '맷', '뒿', 'ꏮ', '鹝', 'ꁸ',
		'ꀚ', '뽔', '臸', '맍', '뒽', 'ꏮ', '鹜', 'ꁠ', 'ꁥ', '뽈',
		'臊', '릇', '듂', 'ꎷ', '鹬', 'ꁭ', '\uf29b', '\uf311', '\uf286', '\ud801',
		'핟', '쉯', 'ﾸ', '솆', '솇', '\uded9', '\ue02d', '\ud814', '핏', '숮',
		'￬', '쇍', '쇳', '\uded9', '\ue054', '\ud866', '픮', '쉿', 'ﾹ', '솏',
		'솆', '\udec1', '\ue022', '\ud808', '핒', '쉡', 'ﾩ', '쇎', '쇐', '\ude8b',
		'\ue056', '\ud808', '픽', '숐', 'ﾩ', '솏', '솀', '\udecd', '\ue021', '\ud81a',
		'핏', '쉢', 'ﾵ', '솟', '쇄', '\ude9c', '\ue062', '\ud86e', '핏', '숛',
		'ￇ', '쇾', '솕', '\udec9', '\ue020', '\ud81a', '핞', '쉭', 'ﾩ', '솂',
		'솋', '\uded9', '\ue061', '\ud84d', '픝', '숙', 'ﾩ', '쇭', '쇺', '\uded9',
		'\ue020', '\ud81d', '한', '쉫', 'ﾸ', '솟', '솈', '\udec5', '\ue030', '\ud859',
		'픊', '숭', 'ￏ', '솟', '쇱', '\udeb7', '\ue051', '\ud808', '핟', '쉪',
		'ﾸ', '솋', '솄', '\uded9', '\ue02d', '\ud816', '핏', '숮', '￬', '쇍',
		'쇳', '\uded9', '\ue042', '\ud867', '핏', '쉯', 'ﾹ', '소', '솂', '\uded9',
		'\ue02d', '\ud814', '핏', '숮', '￬', '쇍', '쇳', '\uded9', '\ue054', '\ud866',
		'픮', '쉿', 'ﾹ', '솏', '솅', '\udece', '\ue030', '\ud815', '핑', '쉿',
		'\ufff8', '쇚', '쇇', '\udebf', '\ue030', '\ud87a', '픠', '쉿', 'ﾹ', '솏',
		'소', '\udeca', '\ue030', '\ud815', '핓', '쉿', '\ufff8', '쇚', '쇇', '\udebf',
		'\ue030', '\ud86c', '픡', '숞', 'ﾩ', '솏', '솅', '\udecf', '\ue023', '\ud808',
		'핒', '쉡', 'ﾩ', '쇎', '쇐', '\ude8b', '\ue056', '\ud808', '픽', '숐',
		'ﾩ', '솏', '솅', '\udec9', '\ue022', '\ud808', '핒', '쉣', 'ﾩ', '쇎',
		'쇐', '\ude8b', '\ue056', '\ud808', '픫', '숑', '\uffc8', '솟', '솅', '\udec9',
		'\ue028', '\ud819', '핏', '쉢', 'ﾷ', '솟', '쇄', '\ude9c', '\ue062', '\ud86e',
		'핇', '⾒', '⸘', '⾌', '⊩', 'ᲆ', '\u1c8c', 'ς', '㴡', 'ԓ',
		'ࡆ', 'Ὣ', '⊼', 'Ზ', '\u1ccd', 'Ε', '㵫', 'է', 'ࡆ', 'ἒ',
		'⋎', '\u1cf7', 'Ნ', 'π', '㴩', 'ԑ', '࡞', 'ὤ', '⊠', '\u1c8b',
		'ᲂ', 'ϐ', '㵨', 'Մ', 'ࠔ', 'ἐ', '⊠', '\u1ce4', 'ᳳ', 'ϐ',
		'㴩', 'ԗ', 'ࡗ', 'ὧ', '⊲', 'Ზ', 'ᲁ', 'ό', '㴹', 'Ր',
		'ࠃ', 'ἤ', '⋆', 'Ზ', '\u1cf8', 'ξ', '㵘', 'ԁ', 'ࡖ', 'ὦ',
		'⊰', 'ᲇ', '\u1c8e', 'ϐ', '㴤', 'ԟ', 'ࡆ', 'ἧ', '⋥', '᳄',
		'ᳺ', 'ϐ', '㵋', 'ծ', 'ࡆ', 'Ὧ', '⊴', 'ᲇ', 'ᲈ', 'ρ',
		'㴹', 'Ԝ', '\u085a', 'ὶ', '⋱', '᳓', '\u1cce', 'ζ', '㴹', 'ե',
		'ࠨ', '\u1f17', '⊠', 'ᲆ', '\u1c8c', 'π', '㴭', 'Ԑ', 'ࡆ', 'Ὣ',
		'⊾', 'Ზ', '\u1ccd', 'Ε', '㵫', 'է', 'ࡆ', 'ἄ', '⋏', 'Ზ',
		'\u1c8c', 'π', '㴨', 'Ԗ', 'ࡆ', 'Ὣ', '⊼', 'Ზ', '\u1ccd', 'Ε',
		'㵫', 'է', 'ࡆ', 'ἒ', '⋎', '\u1cf7', 'Ნ', 'π', '㴩', 'ԑ',
		'ࡑ', 'ὶ', '⊽', 'ᲈ', 'Ნ', '\u0381', '㵼', 'Փ', '\u0820', 'ὶ',
		'⋒', '\u1cf9', 'Ნ', 'π', '㴩', 'ԗ', 'ࡕ', 'ὶ', '⊽', '\u1c8a',
		'Ნ', '\u0381', '㵼', 'Փ', '\u0820', 'ὶ', '⋄', '\u1cf8', '\u1cfd', 'ϐ',
		'㴩', 'ԑ', 'ࡓ', 'ὥ', '⊠', '\u1c8b', 'ᲂ', 'ϐ', '㵨', 'Մ',
		'ࠔ', 'ἐ', '⊠', '\u1ce4', 'ᳳ', 'ϐ', '㴩', 'ԑ', 'ࡖ', 'ὤ',
		'⊠', '\u1c8b', 'ᲀ', 'ϐ', '㵨', 'Մ', 'ࠔ', 'ἐ', '⊠', 'ᳲ',
		'ᳲ', 'α', '㴹', 'ԑ', 'ࡖ', 'Ὦ', '⊱', 'Ზ', 'ᲁ', 'ώ',
		'㴹', 'Ր', 'ࠃ', 'ἤ', '⋆', 'Პ', '\uf06b', '\uf069', '\uf074', '\udc52',
		'\ue2dd', '슦', '슽', '슆', '\ue835', '\ue568', '\uf205', '쿚', '\uf1eb', '\uf1fc',
		'\ueea7', '큈', '\ue87b', '\ue53c', '\uf20d', '쿗', '\uf1f1', '\uf1e1', '\ueea0', '퀍',
		'\ue838', '\ue572', '\uf20c', '쿛', '\uf1eb', '\uf1fc', '\ueeb4', '큈', '\ue876', '\ue52a',
		'\uf227', '皧', '皨', '皆', '媱', '摂', '山', '儺', '䘏', '篶',
		'䗱', '䗬', '媳', '摞', '山', '儀', '䘓', '篖', '䗗', '톹',
		'퇵', '톛', '썩', 'שׁ', '\uf63a', '\ue112', '\udcc7', '\ue2fb', '\ue2e5', 'ﶾ',
		'썄', 'ﭥ', '\uf66d', '\ue10f', '\udcce', '\ue2fb', '\ue2f1', 'ﶮ', '썐', 'שׁ',
		'\uf602', '\ue134', '\udc8b', '\ue2e9', '\ue2f9', 'ﶾ', '썄', 'ﭯ', '\uf63f', '\ue10d',
		'\udc8b', '\ue2f2', '\ue2e3', 'ﷻ', '썓', 'ﭾ', '\uf62c', '\ue119', '\udc8b', '\ue2fa',
		'\ue2f9', 'ﶲ', '썂', 'ﭧ', '\uf638', '\ue139', '\u1bfb', '\u1bf4', 'ᯘ', '⢹',
		'㟵', 'ऑ', 'ㄫ', '㰯', '⭍', '᚜', '⢰', '⢬', '㞹', '\u0902',
		'ㄭ', '㱻', '⭑', 'ᚌ', '瀐', '瀖', '瀴', '䌎', '䍐', '尛',
		'拼', '嫌', '垈', '狡', '狸', '狄', '堦', '啴', '䉁', '翝',
		'䆵', '䆬', '廰', '恄', '堠', '啰', '䉑', '羀', '䆤', '䆂',
		'廟', '怚', '堧', '啡', '䉀', '羠', '䆙', '䆨', '廥', '怩',
		'堎', '鞯', '鞸', '鞉', '뮹', '蕅', '뵸', '끵', '\ua70e', '髙',
		'ꓤ', '\ua4cc', '뮩', '蕊', '뵽', '뀙', 'ꜷ', '髍', '꓾', 'ꓵ',
		'뮨', '蕷', '뵀', '뀼', '\ua70d', '髾', 'ꓗ', 'ꓡ', 'ꓯ', '꓆',
		'鞪', '裷', '똋', '踶', '荥', '鑰', 'ꦖ', '鞡', '鞠', '裎',
		'똎', '踼', '荴', '鑧', '꩑', '꩕', '꩹', '蘓', '룤', '胞',
		'超', '≑', '≒', '≸', 'ࣂ', '\u0598', 'ኵ', '鎿', '鎲', '鎕',
		'뤬', '됹', 'ꌞ', '黀', 'ꃶ', 'ꃸ', '뾶', '腇', '뤬', '됿',
		'ꌔ', '黃', 'ꂻ', '彧', '彭', '彌', '剕', '水', '氽', '獪',
		'䶀', '痴', '磧', '濌', '创', '汣', '\udba4', '\udbad', '\udb88', '줏',
		'\uf175', 'ﰿ', '\ueb02', '횖', '\ue8f4', '\ue8e5', '\uf7a8', '줏', '\udf93', '\udf9b',
		'\udfbe', '\uec97', '\ueccc', '\uf392', '촸', '\uf554', '\uf808', '\uef39', '튡', '\u1bf1',
		'᯽', 'ᯟ', '⣿', '㟡', 'ट', 'ㄶ', '㱶', '⭔', 'ᚎ', '⣵',
		'⢫', '㟼', 'औ', 'ㅢ', '塊', '塀', '塥', '狙', '翜', '棭',
		'唶', '欇', '歄', '瑜', '䪮', '犗', '羞', '⭖', '⭞', '⭦',
		'\u181d', '\u0740', '㦸', 'Ɖ', '\u0cd2', '᯿', '☫', 'ᠱ', 'ꇮ', 'ꇢ',
		'ꇟ', '趬', '댔', '謾', '虷', '酃', '겗', '銹', '鋠', '跸',
		'댊', '謳', '蘺', 'ꯅ', 'ꯋ', '꯷', '飋', '蟂', '뤾', '脃',
		'豕', '魬', 'ꚾ', '颊', '题', '螇', '뤺', '脙', '豟', '鬡',
		'\u245b', '\u2457', '⑨', '\u0819', '㛠', '໘', 'Ξ', 'ᓯ', '⤦', 'ᜋ',
		'\u1755', 'ࡍ', '㚿', 'ຆ', 'Ώ', '빬', '빥', '빘', '躈', '댝',
		'货', '贤', '鈮', '겓', '钰', '駶', '躈', '㙧', '㙶', '㙒',
		'ᨥ', '⒂', 'Უ', 'ᇼ', 'ۍ', '㬞', 'ԭ', 'Լ', '\u1a68', '⒅',
		'Ჿ', 'ᇠ', 'ڃ', '㬁', 'Ԭ', 'ԧ', 'ᨥ', '屓', '屜', '履',
		'潗', '漙', '灘', '亴', '皁', '篑', '泺', '儨', '漜', '漎',
		'瀑', '京', '皏', '築', '沷', '\uf23a', '\uf237', '\uf20d', '섾', '셭',
		'\ude2b', '\ue0c0', '\ud8e4', '햧', '슕', '｛', '섾', '셠', '\ude37', '\ue0df',
		'\ud8a9', '\uf343', '\uf34d', '\uf37b', 'ﹱ', '쁗', '쁐', '\udf45', '\ue1ad', '\ud984',
		'퓄', '쏲', '\ufe33', '쀊', '쀄', '\udf4a', '\ue1bb', '\ud9d0', 'ヺ', 'ヰ',
		'ッ', 'Ჸ', '∞', 'ᨧ', '\u177a', '_', '㷈', 'Ϊ', 'λ', 'ᳶ',
		'≑', 'ꉋ', 'ꉆ', 'ꉱ', '踉', '낥', '袜', '藐', '鋢', '꼽',
		'鄁', '鄇', '踉', '내', '袗', '藑', '銯', '댯', '댮', '댔',
		'鍃', 'ꭼ', 'ꭷ', 'ꭀ', '顸', '頫', '蝺', '릓', '膺', '質',
		'鮘', 'ꘚ', '頷', '頼', '蜾', 'ぁ', 'え', 'ぼ', '\u1ad2', '\u17c7',
		'à', '㴾', '\u0308', '\u0306', '᱈', '⊹', '\u1ad2', 'ھ', 'ڸ', 'ڀ',
		'ᐕ', 'ⱺ', 'ℾ', '㘕', '\u0bc0', '㖺', '愫', '愮', '愔', '玀',
		'䯺', '䚰', '再', '氙', '䎱', '䎵', '䏱', '椢', '搴', '猖',
		'亃', '䷬', '䷤', '䶭', '绢', '懼', '异', '末', '橫', '絉',
		'䂓', '绨', '嶕', '嶓', '巗', '溑', '滙', '熔', '佰', '睏',
		'穁', '놣', '놫', '뇠', '陷', '脖', '볒', '苪', '苤', '鶪',
		'ꍛ', '鬰', '鱇', '鱍', '鰃', '꽃', '꼌', '끕', '躹', '뚐',
		'믞', '곪', '鄾', '꼐', '꽉', '⦘', '⦐', '⧝', '\u0e4c', 'ᥬ',
		'Ⓔ', '\u1a8d', '\u1ac6', '\u0595', '㭧', '\u030b', '\uf3af', '\uf3aa', '\uf3e9', '푻',
		'쌈', 'ﻒ', '샭', '삡', '訉', '訄', '詎', '귝', '몣', '蝬',
		'륂', '륉', 'ꘀ', '飬', 'ꃏ', '궐', '몤', '蝰', '륞', '뤇',
		'魅', '魎', '鬍', '陷', 'ꠅ', '\ua802', '띋', '覯', '놀', '볜',
		'\uabe8', '阼', 'ꠒ', 'ꡋ', '潴', '潮', '漽', '䍤', '続', '䖱',
		'䣲', '忕', '戵', '屰', '尨', '䍳', '綋', '䖴', '䣵', '応',
		'戥', '屽', '專', '䍗', '緟', '䖠', '䣮', '忙', '戒', '就',
		'尾', '䍦', '綪', 'ᶦ', 'ᶯ', '\u1dec', 'ⵂ', 'Ⴭ', '⻱', '\u2ef9',
		'ㆩ', 'ང', '㝾', '㨡', 'ⵂ', '䈲', '䈾', '䉹', '伀', '煲',
		'煹', '渤', '僊', '棴', '斤', '犛', '佉', '煽', '煯', '湰',
		'剱', '剷', '刽', '投', '弌', '愻', '愫', '繲', '䃚', '\u0ae4',
		'૭', '\u0aa9', '⚦', '᠊', '″', '\u2d7f', '㩍', 'ޒ', '㦮', '㦨',
		'⚦', 'ṓ', 'Ṕ', 'ḝ', 'ⵗ', 'ⴄ', '㉕', '\u0cbc', '㒕', '㧅',
		'⺷', '䇥', '䇦', '䆪', '淮', '匈', '欅', '鞙', '鞘', '韉',
		'ꜜ', '圢', '圣', '坳', '笋', '癧', '癯', '瘵', '笁', '䔰',
		'䔨', '婦', '撉', '岦', '凼', '䛥', '\uf11a', '\uf11d', '\uf149', '횜',
		'솻', 'ﱼ', '쉊', '쉛', '\udd08', '\ue3c2', '䛖', '䛝', '䚂', '䮡',
		'疖', '疗', '櫺', '启', '氀', '慖', '癦', '䮫', '疂', '疫',
		'ଷ', 'ଲ', '\u0b62', 'ـ', '㡧', '㡬', '✺', '᧮', 'ㇿ', 'ㇼ',
		'ㆩ', 'ʢ', '\u1de9', '⌰', '谿', '谴', '豨', '麉', 'ꛅ', 'ꮍ',
		'벨', '脍', '뼻', '뼱', 'ꁧ', '麔', 'ꚲ', 'ꮑ', '\u1a55', '\u1a57',
		'ᨍ', '⪱', 'ᝯ', '\udf7d', '\udf64', '\udf24', '\uf36b', '춗', '\uf5aa', '\uf8a7',
		'\uefdd', '툀', '\uec34', '\uec0c', '\uf36b', '춁', '\uf591', '\uf8f0', '\uefcd', '투',
		'\uec05', '\uec23', '\uf36a', '춂', '\uf5ab', '\uf8da', '\uefe5', '툈', '\uec3f', '\uec10',
		'\uf343', '⢶', '⢴', '⣬', 'ཫ', 'ᡒ', '㼖', '㼟', '㽍', 'ౝ',
		'ጀ', '\u2dfc', 'ᗁ', 'ᢒ', '\u0f87', '㉽', '\u0c46', '౻', '킔', '킑',
		'탈', '\ue3df', 'ﲂ', '쉾', '禎', '\uf713', '\ue47f', '\ue47b', '\ue422', '졸',
		'\uf699', '캭', '쏥', '北', '異', '綠', '짌', '稑', '稐', '穎',
		'噾', 'ᮔ', 'ᮎ', '\u1bf4', '㰔', '⬱', 'ᛢ', '⢞', '⣑', '㞕',
		'॰', 'ㅋ', '㰢', '⬤', 'ᛩ', '⣀', '⣩', '㞎', 'ज़', 'ㅻ',
		'㰐', '⬥', 'ᛲ', '⣕', '⣩', '㞪', 'ॸ', 'ㅁ', '㰣', '⬌',
		'㊕', '㊄', '㋴', 'Ǟ', 'ẃ', 'ⁿ', 'ᡂ', 'ᔑ', 'Ȅ', '㿬',
		'ǒ', 'ǔ', 'ẛ', '⁜', 'ᡒ', 'ᔎ', 'ȡ', '㿔', 'ǉ', 'ǿ',
		'᮷', 'ᮮ', 'ᯕ', '㰷', '⬒', 'ᛁ', '⢽', '⣪', '㞧', 'ख़',
		'ㅦ', '㰮', '⬖', 'ᛨ', '⣰', '⣶', '㞓', 'ॠ', 'ㅴ', '㰶',
		'⬇', 'ᛀ', '⣀', '⣅', '㞲', 'ग़', 'ㅇ', '㰟', '趹', '趿',
		'跚', 'ꝗ', '\uaa7c', '봅', '胙', '뻜', '뻌', '臿', '臻', '膛',
		'ꙧ', '녗', '貌', '늘', '橌', '橉', '権', '䷋', '嫩', '朷',
		'处', '夣', '밁', '밆', '뱧', '껯', '雕', '鮔', '貶', '녠',
		'轀', '轢', 'ƿ', 'ƻ', 'ǘ', '⭩', '☻', '\u3102', '\u0cf9', '긽',
		'긠', '깕', '蓳', '觽', '麂', 'ꍲ', '鴠', '鴾', '良', '볭',
		'蒣', '覴', '黊', 'ꍔ', '鵄', '鴪', '色', '벆', '蓕', '觠',
		'麥', 'ꍒ', '鴪', '鵨', '舂', '벏', '蒣', '觹', '麢', 'ꌇ',
		'鵅', '↼', '↺', '⇕', '㍊', 'ଽ', 'ذ', 'ᅂ', 'Ⲟ', 'ዣ',
		'褕', '褟', '西', '릵', '葢', '멅', '멈', 'ꔂ', '鯼', 'ꏋ',
		'꺈', '릺', '葴', '仹', '仸', '互', '爻', 'ᣁ', 'ᣌ', '\u18ad',
		'㓚', 'ਭ', '㈝', '㽙', '⡪', 'ᖽ', '⮍', '⮌', '㓆', 'ਞ',
		'㉟', '㽧', '⡄', 'ᨢ', 'ᨬ', 'ᩏ', '⥫', '㘮', 'ࣀ', 'ヿ',
		'㶿', '⪇', '\u175d', '⥣', '⥾', '㙠', '\u08cc', 'ー', '㶿', '⪲',
		'鿉', '鿅', '龧', '독', '货', '딟', '롏', '꽮', '銈', '겅',
		'겔', '돊', '贮', '딊', '롮', '\ue860', '\ue866', '\ue80f', '\udb7b', '쐳',
		'\ufadb', '싣', '쾺', '\ud894', 'ከ', 'ኾ', 'ዘ', '↭', '⇪', '㺦',
		'V', '㡵', '㕼', '∉', 'Ῐ', '↬', '⇲', '㺥', 'M', '㡵',
		'㔽', '∏', 'ᾚ', '⇼', '⇧', '㺧', 'W', '㡲', '㔞', '恦',
		'恰', '怗', '洀', '匣', '匬', '䰪', '犉', '䪧', '䟽', '僵',
		'洐', '匣', '匊', '䱘', '犝', '䪠', '䟦', '僇', '洧', '匞',
		'匯', '䱢', '犮', '䪉', 'ᮗ', 'ᮚ', 'ᯥ', 'ᛠ', '⣇', '⣘',
		'㞑', '६', 'ㅱ', '㰇', '⬡', 'ᛪ', '⣤', '⣝', '㞔', 'फ़',
		'呛', '呒', '吨', '䚢', '纍', '珙', '擭', '夬', '本', '服',
		'硋', '䚑', '맘', '릃', '리', '鹑', '褭', '뒱', '誡', '誡',
		'闿', '\uab08', '鍋', '鹑', '褮', '듦', '諍', '認', '闧', '\uab6a',
		'鍆', '鸜', '襇', '듪', '誁', '諅', '閖', 'ꭢ', '錐', '鹱',
		'褥', '듧', '諌', '読', '閚', 'ꬮ', '鍚', '鹗', '襁', '뒙',
		'課', '読', '閚', 'ꬮ', '鍙', '鸀', '褭', '뒱', '誡', '諏',
		'閗', 'ꭣ', '錰', '鸌', '襡', '듸', '諐', '談', '闁', 'ꬎ',
		'鍒', '鸁', '褬', '뒑', 'ᖣ', 'ᖪ', 'ᗖ', '⛹', '㦴', '\u0747',
		'㽵', '㈼', '┎', 'ᣃ', '⛳', '⛞', '\u1a55', 'ᩔ', 'ᨣ', '㷶',
		'㡺', '㡾', '㠍', '\u08cf', '㔍', 'ବ', '\u0b12', '\u1bed', '\u1bf6', 'ᮕ',
		'⢽', '⢢', '㟫', '\u0948', 'ㄵ', '㱺', '⭆', 'ᚓ', '⢋', '⢷',
		'㟬', '\u0903', '\u3130', '㱷', '⭆', 'ᚼ', '⢕', '⢳', '㟺', 'ऒ',
		'ㄻ', '㱊', '\u2b75', 'ᚘ', '⢯', '⢀', '㟓', '텕', '텇', '턬',
		'쎻', 'ﮒ', '\uf6c0', '\ue1f5', '\udc37', '\ue224', '\ue210', 'ﵔ', '쎱', 'ﮊ',
		'\uf6e3', '\ue1e5', '\udc24', '\ue214', '\ue215', 'ﵙ', '쎱', 'ﮥ', '靏', '靉',
		'霵', '뭈', '薪', '붓', '냡', 'ꟺ', '騞', '볈', '볏', '벳',
		'辉', '辈', '郅', '긙', '阎', '魈', '豅', 'ã', 'ç', '\u009f',
		'㎺', '\u2cf5', 'ሇ', '⨜', '뒚', '뒘', '듧', '鹘', '錭', '르',
		'륷', '뤊', '角', '됉', '訒', '뛄', '뛃', '뚻', '鰅', '酕',
		'虭', '뮻', '薉', '薁', '髵', '瘏', '瘉', '皏', '擦', '峸',
		'冖', '䚢', '筶', '䕸', 'ꎓ', 'ꎔ', 'ꌒ', '郐', '辁', '녏',
		'襍', '萎', '錼', '껒', '⚟', '⚗', '☝', 'ᘾ', '⯽', 'ᗎ',
		'ᗵ', 'ઐ', '㑽', '\u0c47', 'ĸ', '\u1fdd', 'Ί', '\u1f5e', '㡘', '⽚',
		'ኢ', 'Ⲑ', 'Ⲙ', '㏬', '\uef2c', '\uef25', '\uefa8', '\udc66', '쌧', '\ufdcb',
		'엾', '좎', '\udf85', '\ue257', '\udc63', '\udc51', '邘', '邟', '逝', '鷳',
		'ꏏ', 'ꏧ', '벗', '艺', '멀', '뜿', '뿥', '뿯', '뽣', '鏣',
		'괋', '锢', '顢', '轔', '늵', '責', '貢', '鏬', '괽', 'ⵍ',
		'ⵆ', 'ⷊ', 'ސ', '\u0ace', '\u1de6', '‱', 'Ḃ', 'ḍ', 'ź', '㾫',
		'ޗ', '\u0ad2', '\u1dda', '鬟', '鬙', '鮗', '觱', '뇙', '벚', 'ꮲ',
		'陣', 'ꡮ', '璩', '璯', '琠', '墹', '晇', '幮', '匮', '䐌',
		'秶', '䋝', '䋙', '䉗', '倴', '栭', '敇', '牐', '┛', '┝',
		'▐', '\u0949', '㞠', '\u0f99', 'ʟ', 'ᖰ', '⡝', '舡', '舢', '芭',
		'\ua8ff', 'ꖴ', '늭', '\ue304', '\ue307', '\ue389', '펣', '\uee79', '큦', '獾',
		'獺', '珰', '縈', '䀴', '䀱', '彞', '3', '1', '¼', 'ⰾ',
		'ዬ', '㾵', '㾶', '㼥', 'ᕡ', 'ᠲ', '༼', '䁕', '䁑', '䃄',
		'柄', '烵', '䴨', '猼', 'Ɱ', 'Ⱨ', '⳼', 'ἧ', 'm', '㺉',
		'ڛ', '௪', '᳅', 'ℏ', 'ἳ', 'ἓ', '瀮', '瀨', '炽', '䍭',
		'䍡', '尠', '拣', '嫥', '垍', '죩', '죭', '졽', 'ﯧ', '\ue4b1',
		'\uda42', '\ue264', 'ꔈ', 'ꔊ', 'ꖝ', '迹', '苓', '쀸', '쀼', '삮',
		'\ue79c', '\uf0ae', '쵻', '\uf333', 'ױ', '״', 'զ', '≊', '㕶', 'ࢰ',
		'㚜', '㚜', 'ᡁ', 'ᡘ', 'ᣙ', '⬁', '㑎', '\u0abf', '㊞', '㿚',
		'⣆', 'ᔫ', '⬊', '⬭', '㑗', 'લ', '㊗', '㿡', '⣲', 'ᔶ',
		'⬌', '⬹', '㑇', 'ણ', '㊀', '㿲', '⣤', 'ᔧ', '⬄', '⬫',
		'\ue33b', '\ue328', '\ue3a2', '\uf1d5', '짼', '쒮', '펛', '\uee59', '큊', '큡',
		'켪', '\uf1d9', '진', '쒽', '펚', '\uee5d', '크', '큠', '켵', '\uf1f3',
		'짰', '쒋', '燌', '燔', '煖', '䊜', '䊃', '巊', '捩', '嬔',
		'噛', '䅧', '粲', '䊪', '䊎', '巂', '挦', '嬼', '噤', '䅸',
		'粫', '䊜', '䊇', '巽', '挛', '嬘', '噞', '䅋', '粂', '납',
		'낦', '뀲', '耈', '뷏', '菬', '菣', '鲻', 'ꉷ', '驱', '霾',
		'耂', '뷗', '菏', '菫', '鲧', 'ꉃ', '驙', '틻', '틫', '퉧',
		'쁺', '\uf872', '\uf561', '\ue258', '\udf80', '\ue1ac', '\ue1b9', 'ﻵ', '쀑', '\uf82b',
		'\uf52f', '\ue24d', '\udf8c', '\ue1ab', '\ue1bb', 'ﻜ', 'Ｘ', 'Ｂ', 'ﾥ', '쿓',
		'\uf24d', '챮', '챹', '퍴', '\uedc0', '헥', '\ud8a8', '쾒', '\uf253', '챸',
		'참', '팪', '\uedda', '헠', '\ud8af', '쾙', '\uf242', '챿', '찹', '퍵',
		'\ued89', '헻', '\ud8b8', '쾈', '\uf242', 'Ü', 'Û', 'B', '⩑', '❑',
		'ぼ', 'ඡ', '㎚', '㏝', 'Ⲃ'
	};

	private static readonly Array Ⴈ;

	internal static Ⴓ Ⴀ/* Not supported: data(6C D8 6D D8 6C D8 4A DA 90 5D 96 5D 91 5D 97 71 77 4F 41 77 05 7A 3A 6D C7 50 F2 2A E5 2A F0 2A A4 19 B9 19 E4 06 15 38 28 00 40 0D 58 1A 8D 27 A3 19 B0 19 FF 06 3A 38 39 00 69 0D 74 1A 8B 27 B5 19 B9 19 F8 06 3A 38 37 00 61 0D 72 1A C5 C3 C1 C3 C6 C3 E1 F0 D3 EF 21 D1 38 E9 B9 66 B8 66 BD 66 7D 41 E9 5A E8 5A EC 5A F6 69 FD D1 B1 D1 FB D1 B8 FD 33 C3 1B FB 45 F6 78 E1 B9 DC 95 E2 9F E2 CA FD 38 C3 69 FB 29 F6 04 E1 CF DC F0 E2 F4 E2 DA FD 23 C3 02 FB 48 F6 6F E1 A3 DC 95 E2 86 E2 D1 FD 51 C3 62 FB 20 F6 1E E1 88 DC B7 E2 BA E2 ED FD 02 C3 1D FB 27 F6 54 E1 8A DC AD E2 A0 E2 E6 FD 25 C3 69 FB 25 F6 C7 99 C1 99 C0 99 B5 AA D6 B5 2B 8B 1B B3 7F BE 5F A9 C7 53 D2 53 CF 53 C9 60 CA 7F 38 41 54 79 57 74 66 63 B8 5E 8E 60 80 60 D7 7F 38 41 54 79 40 74 66 63 B9 5E 8A 60 8F 60 85 7F 2B 41 1B 79 7F 74 42 73 43 73 4B 73 BC 54 58 3E 59 3E 52 3E D3 1D 3C 20 3D 20 37 20 96 07 4C 28 54 28 40 28 5A 04 A6 3A 9B 02 96 0F C5 18 1F 25 34 1B 09 1B 41 04 A8 3A 9D 02 D4 0F E4 18 3F 25 2B 1B 07 1B 78 04 B4 3A AA 02 E4 0F EF 18 38 25 2B 1B 3E 1B 02 6E 00 6E 0F 6E BD 49 89 5E 93 45 92 45 9D 45 19 66 C1 63 DE 63 CE 63 F3 6E DF 50 81 50 CC 4F 23 71 06 49 45 44 60 53 B0 6E 9D 50 AA 50 83 4F 3E 71 17 49 5E 44 66 53 BC 6E B6 50 CF 50 C8 4F 29 71 13 49 57 44 69 53 BF 6E 84 50 AC 50 C7 4F 2B 71 17 49 67 44 EA FC F4 FC FA FC 40 CC 97 F1 A7 CF B0 CF F8 D0 04 EE 3A D6 66 DB 6B CC 9C F1 AB CF B7 CF E7 D0 11 EE 2A D6 77 DB 6A CC 8C F1 AD CF A1 CF E2 D0 03 EE 16 D6 30 DB 43 CC 9D F1 BA CF B7 CF F1 D0 32 EE F5 32 EF 32 E4 32 AF 01 F6 1E 1A 20 68 18 31 15 01 02 D6 3F A1 01 B4 01 C3 1E 1C 20 33 18 51 15 49 02 A3 3F 8D 01 AB 01 E2 1E 0A 20 23 18 52 15 6D 02 80 3F B7 01 98 01 CB 1E 56 14 48 14 44 14 1C 27 17 27 5D 38 A9 06 95 3E C7 33 F1 24 3C 19 17 27 58 27 5A 38 B2 06 8C 3E D6 33 F3 24 27 19 1B 27 1E 27 5D 38 AF 06 80 3E D4 33 B2 24 30 19 1C 27 1D 27 40 38 B3 06 8A 3E E1 33 F7 C7 FB C7 E4 C7 BC F4 E1 EB 1D D5 20 ED 73 E0 66 F7 D5 CA E3 F4 E8 F4 E5 EB 13 D5 10 ED 83 64 9B 64 97 64 33 54 F0 69 C3 57 83 57 95 48 7D 76 5F 4E 1C 43 24 54 FE 69 EB 57 DD 57 A8 48 54 76 40 4E 02 43 33 54 F4 69 F4 57 F1 57 86 48 6E 76 73 4E 2B 43 30 E6 3F E6 25 E6 E6 CC B0 C1 95 D6 46 EB 64 D5 4B D5 26 CA CE F4 EC CC AF C1 97 D6 4D EB 58 D5 6E D5 1B CA 4B 6A 5E 6A 5D 6A 96 40 D0 4D E6 5A 2D 67 0E 59 17 59 5C 46 A7 78 91 40 D9 4D E1 5A 36 67 2C 59 45 59 47 46 AF 78 91 40 CB 4D EE 5A 2D 67 3C 59 F6 F9 F5 F9 E1 F9 4B C9 81 F4 99 CA 7A 21 76 21 62 21 15 2C 12 12 18 12 59 0D B2 33 E4 0B C0 06 F7 11 2F 2C 11 12 18 12 63 0D 89 B3 94 B3 90 B3 E6 BE FC 80 E2 80 B9 9F 44 A1 17 99 29 94 1E 83 DE BE F9 80 E9 80 A4 9F 41 A1 17 99 3F 94 1E 83 C8 BE D6 80 87 80 AF 9F 4C A1 7B 99 5D 94 06 83 A5 BE 91 80 DE 80 9F 9F 41 A1 6B AF 77 AF 71 AF 32 9C 14 9C 4C 83 B2 BD 9E 85 B2 88 FB 9F 2A A2 0A 9C 11 9C 47 83 AF BD 9B 85 B2 88 F8 9F 3A A2 34 9C 65 9C 4D 83 AE BD 99 85 BF 88 E4 9F 47 A2 73 9C 3C 9C 7D 83 A3 BD BD A1 F4 A1 A6 A1 73 8B 18 86 3C 91 FD AC DF 92 BE 92 8B 8D 65 B3 4B 8B 1D 86 37 91 E0 AC DA 92 BE 92 9D 8D 65 B3 5D 8B 32 86 59 91 EB AC D7 92 D2 92 FF 8D 73 B3 58 8B 77 86 45 91 D6 AC ED 92 D0 92 FF 8D 72 B3 40 8B 08 86 59 91 E4 AC A7 92 AF 92 A6 8D 42 B3 4D 8B 0A 93 42 93 16 93 59 A0 39 BF C4 81 EB B9 B8 B4 E3 A3 4C 9E 7D A0 61 A0 3C BF CF 81 F6 B9 BD B4 E3 A3 4F 9E 6D A0 5F A0 48 BF C5 81 F7 B9 BF B4 EE A3 5D 9E 78 A0 1A A0 54 BF F8 81 CD B9 BD B4 EE A3 5C 9E 60 A0 65 A0 48 BF CA 81 87 B9 C2 B4 B7 A3 6C 9E 6D A0 9B F2 11 F3 86 F2 01 D8 5F D5 6F C2 B8 FF 86 C1 87 C1 D9 DE 2D E0 14 D8 4F D5 2E C2 EC FF CD C1 F3 C1 D9 DE 54 E0 66 D8 2E D5 7F C2 B9 FF 8F C1 86 C1 C1 DE 22 E0 08 D8 52 D5 61 C2 A9 FF CE C1 D0 C1 8B DE 56 E0 08 D8 3D D5 10 C2 A9 FF 8F C1 80 C1 CD DE 21 E0 1A D8 4F D5 62 C2 B5 FF 9F C1 C4 C1 9C DE 62 E0 6E D8 4F D5 1B C2 C7 FF FE C1 95 C1 C9 DE 20 E0 1A D8 5E D5 6D C2 A9 FF 82 C1 8B C1 D9 DE 61 E0 4D D8 1D D5 19 C2 A9 FF ED C1 FA C1 D9 DE 20 E0 1D D8 5C D5 6B C2 B8 FF 9F C1 88 C1 C5 DE 30 E0 59 D8 0A D5 2D C2 CF FF 9F C1 F1 C1 B7 DE 51 E0 08 D8 5F D5 6A C2 B8 FF 8B C1 84 C1 D9 DE 2D E0 16 D8 4F D5 2E C2 EC FF CD C1 F3 C1 D9 DE 42 E0 67 D8 4F D5 6F C2 B9 FF 8C C1 82 C1 D9 DE 2D E0 14 D8 4F D5 2E C2 EC FF CD C1 F3 C1 D9 DE 54 E0 66 D8 2E D5 7F C2 B9 FF 8F C1 85 C1 CE DE 30 E0 15 D8 51 D5 7F C2 F8 FF DA C1 C7 C1 BF DE 30 E0 7A D8 20 D5 7F C2 B9 FF 8F C1 8C C1 CA DE 30 E0 15 D8 53 D5 7F C2 F8 FF DA C1 C7 C1 BF DE 30 E0 6C D8 21 D5 1E C2 A9 FF 8F C1 85 C1 CF DE 23 E0 08 D8 52 D5 61 C2 A9 FF CE C1 D0 C1 8B DE 56 E0 08 D8 3D D5 10 C2 A9 FF 8F C1 85 C1 C9 DE 22 E0 08 D8 52 D5 63 C2 A9 FF CE C1 D0 C1 8B DE 56 E0 08 D8 2B D5 11 C2 C8 FF 9F C1 85 C1 C9 DE 28 E0 19 D8 4F D5 62 C2 B7 FF 9F C1 C4 C1 9C DE 62 E0 6E D8 47 D5 92 2F 18 2E 8C 2F A9 22 86 1C 8C 1C C2 03 21 3D 13 05 46 08 6B 1F BC 22 96 1C CD 1C 95 03 6B 3D 67 05 46 08 12 1F CE 22 F7 1C 9C 1C C0 03 29 3D 11 05 5E 08 64 1F A0 22 8B 1C 82 1C D0 03 68 3D 44 05 14 08 10 1F A0 22 E4 1C F3 1C D0 03 29 3D 17 05 57 08 67 1F B2 22 96 1C 81 1C CC 03 39 3D 50 05 03 08 24 1F C6 22 96 1C F8 1C BE 03 58 3D 01 05 56 08 66 1F B0 22 87 1C 8E 1C D0 03 24 3D 1F 05 46 08 27 1F E5 22 C4 1C FA 1C D0 03 4B 3D 6E 05 46 08 6F 1F B4 22 87 1C 88 1C C1 03 39 3D 1C 05 5A 08 76 1F F1 22 D3 1C CE 1C B6 03 39 3D 65 05 28 08 17 1F A0 22 86 1C 8C 1C C0 03 2D 3D 10 05 46 08 6B 1F BE 22 96 1C CD 1C 95 03 6B 3D 67 05 46 08 04 1F CF 22 96 1C 8C 1C C0 03 28 3D 16 05 46 08 6B 1F BC 22 96 1C CD 1C 95 03 6B 3D 67 05 46 08 12 1F CE 22 F7 1C 9C 1C C0 03 29 3D 11 05 51 08 76 1F BD 22 88 1C 9C 1C 81 03 7C 3D 53 05 20 08 76 1F D2 22 F9 1C 9C 1C C0 03 29 3D 17 05 55 08 76 1F BD 22 8A 1C 9C 1C 81 03 7C 3D 53 05 20 08 76 1F C4 22 F8 1C FD 1C D0 03 29 3D 11 05 53 08 65 1F A0 22 8B 1C 82 1C D0 03 68 3D 44 05 14 08 10 1F A0 22 E4 1C F3 1C D0 03 29 3D 11 05 56 08 64 1F A0 22 8B 1C 80 1C D0 03 68 3D 44 05 14 08 10 1F A0 22 F2 1C F2 1C B1 03 39 3D 11 05 56 08 6E 1F B1 22 96 1C 81 1C CE 03 39 3D 50 05 03 08 24 1F C6 22 9E 1C 6B F0 69 F0 74 F0 52 DC DD E2 A6 C2 BD C2 86 C2 35 E8 68 E5 05 F2 DA CF EB F1 FC F1 A7 EE 48 D0 7B E8 3C E5 0D F2 D7 CF F1 F1 E1 F1 A0 EE 0D D0 38 E8 72 E5 0C F2 DB CF EB F1 FC F1 B4 EE 48 D0 76 E8 2A E5 27 F2 A7 76 A8 76 86 76 B1 5A 42 64 71 5C 3A 51 0F 46 F6 7B F1 45 EC 45 B3 5A 5E 64 71 5C 00 51 13 46 D6 7B D7 45 B9 D1 F5 D1 9B D1 69 C3 2A FB 3A F6 12 E1 C7 DC FB E2 E5 E2 BE FD 44 C3 65 FB 6D F6 0F E1 CE DC FB E2 F1 E2 AE FD 50 C3 2A FB 02 F6 34 E1 8B DC E9 E2 F9 E2 BE FD 44 C3 6F FB 3F F6 0D E1 8B DC F2 E2 E3 E2 FB FD 53 C3 7E FB 2C F6 19 E1 8B DC FA E2 F9 E2 B2 FD 42 C3 67 FB 38 F6 39 E1 FB 1B F4 1B D8 1B B9 28 F5 37 11 09 2B 31 2F 3C 4D 2B 9C 16 B0 28 AC 28 B9 37 02 09 2D 31 7B 3C 51 2B 8C 16 10 70 16 70 34 70 0E 43 50 43 1B 5C FC 62 CC 5A 88 57 E1 72 F8 72 C4 72 26 58 74 55 41 42 DD 7F B5 41 AC 41 F0 5E 44 60 20 58 70 55 51 42 80 7F A4 41 82 41 DF 5E 1A 60 27 58 61 55 40 42 A0 7F 99 41 A8 41 E5 5E 29 60 0E 58 AF 97 B8 97 89 97 B9 BB 45 85 78 BD 75 B0 0E A7 D9 9A E4 A4 CC A4 A9 BB 4A 85 7D BD 19 B0 37 A7 CD 9A FE A4 F5 A4 A8 BB 77 85 40 BD 3C B0 0D A7 FE 9A D7 A4 E1 A4 EF A4 C6 A4 AA 97 F7 88 0B B6 36 8E 65 83 70 94 96 A9 A1 97 A0 97 CE 88 0E B6 3C 8E 74 83 67 94 51 AA 55 AA 79 AA 13 86 E4 B8 DE 80 85 8D 51 22 52 22 78 22 C2 08 98 05 B5 12 BF 93 B2 93 95 93 2C B9 39 B4 1E A3 C0 9E F6 A0 F8 A0 B6 BF 47 81 2C B9 3F B4 14 A3 C3 9E BB A0 67 5F 6D 5F 4C 5F 55 52 34 6C 3D 6C 6A 73 80 4D F4 75 E7 78 CC 6F 1B 52 63 6C A4 DB AD DB 88 DB 0F C9 75 F1 3F FC 02 EB 96 D6 F4 E8 E5 E8 A8 F7 0F C9 93 DF 9B DF BE DF 97 EC CC EC 92 F3 38 CD 54 F5 08 F8 39 EF A1 D2 F1 1B FD 1B DF 1B FF 28 E1 37 1F 09 36 31 76 3C 54 2B 8E 16 F5 28 AB 28 FC 37 14 09 62 31 4A 58 40 58 65 58 D9 72 DC 7F ED 68 36 55 07 6B 44 6B 5C 74 AE 4A 97 72 9E 7F 56 2B 5E 2B 66 2B 1D 18 40 07 B8 39 89 01 D2 0C FF 1B 2B 26 31 18 EE A1 E2 A1 DF A1 AC 8D 14 B3 3E 8B 77 86 43 91 97 AC B9 92 E0 92 F8 8D 0A B3 33 8B 3A 86 C5 AB CB AB F7 AB CB 98 C2 87 3E B9 03 81 55 8C 6C 9B BE A6 8A 98 98 98 87 87 3A B9 19 81 5F 8C 21 9B 5B 24 57 24 68 24 19 08 E0 36 D8 0E 9E 03 EF 14 26 29 0B 17 55 17 4D 08 BF 36 86 0E 8F 03 6C BE 65 BE 58 BE 88 8E 1D B3 27 8D 24 8D 2E 92 93 AC B0 94 F6 99 88 8E 67 36 76 36 52 36 25 1A 82 24 A3 1C FC 11 CD 06 1E 3B 2D 05 3C 05 68 1A 85 24 BF 1C E0 11 83 06 01 3B 2C 05 27 05 25 1A 53 5C 5C 5C 65 5C 57 6F 19 6F 58 70 B4 4E 81 76 D1 7B FA 6C 28 51 1C 6F 0E 6F 11 70 AC 4E 8F 76 C9 7B B7 6C 3A F2 37 F2 0D F2 3E C1 6D C1 2B DE C0 E0 E4 D8 A7 D5 95 C2 5B FF 3E C1 60 C1 37 DE DF E0 A9 D8 43 F3 4D F3 7B F3 71 FE 57 C0 50 C0 45 DF AD E1 84 D9 C4 D4 F2 C3 33 FE 0A C0 04 C0 4A DF BB E1 D0 D9 FA 30 F0 30 C3 30 B8 1C 1E 22 27 1A 7A 17 5F 00 C8 3D AA 03 BB 03 F6 1C 51 22 4B A2 46 A2 71 A2 09 8E A5 B0 9C 88 D0 85 E2 92 3D AF 01 91 07 91 09 8E B4 B0 97 88 D1 85 AF 92 2F B3 2E B3 14 B3 43 93 7C AB 77 AB 40 AB 78 98 2B 98 7A 87 93 B9 BA 81 EA 8C 98 9B 1A A6 37 98 3C 98 3E 87 41 30 48 30 7C 30 D2 1A C7 17 E0 00 3E 3D 08 03 06 03 48 1C B9 22 D2 1A BE 06 B8 06 80 06 15 14 7A 2C 3E 21 15 36 C0 0B BA 35 2B 61 2E 61 14 61 80 73 FA 4B B0 46 8D 51 19 6C B1 43 B5 43 F1 43 22 69 34 64 16 73 83 4E EC 4D E4 4D AD 4D E2 7E FC 61 02 5F 2B 67 6B 6A 49 7D 93 40 E8 7E 95 5D 93 5D D7 5D 91 6E D9 6E 94 71 70 4F 4F 77 41 7A A3 B1 AB B1 E0 B1 77 96 16 81 D2 BC EA 82 E4 82 AA 9D 5B A3 30 9B 47 9C 4D 9C 03 9C 43 AF 0C AF 55 B0 B9 8E 90 B6 DE BB EA AC 3E 91 10 AF 49 AF 98 29 90 29 DD 29 4C 0E 6C 19 BA 24 8D 1A C6 1A 95 05 67 3B 0B 03 AF F3 AA F3 E9 F3 7B D4 08 C3 D2 FE ED C0 A1 C0 09 8A 04 8A 4E 8A DD AD A3 BA 6C 87 42 B9 49 B9 00 A6 EC 98 CF A0 90 AD A4 BA 70 87 5E B9 07 B9 45 9B 4E 9B 0D 9B 77 96 05 A8 02 A8 4B B7 AF 89 80 B1 DC BC E8 AB 3C 96 12 A8 4B A8 74 6F 6E 6F 3D 6F 64 43 9A 7D B1 45 F2 48 D5 5F 35 62 70 5C 28 5C 73 43 8B 7D B4 45 F5 48 DC 5F 25 62 7D 5C 08 5C 57 43 DF 7D A0 45 EE 48 D9 5F 12 62 31 5C 3E 5C 66 43 AA 7D A6 1D AF 1D EC 1D 42 2D CD 10 F1 2E F9 2E A9 31 44 0F 7E 37 21 3A 42 2D 32 42 3E 42 79 42 00 4F 72 71 79 71 24 6E CA 50 F4 68 A4 65 9B 72 49 4F 7D 71 6F 71 70 6E 71 52 77 52 3D 52 95 62 0C 5F 3B 61 2B 61 72 7E DA 40 E4 0A ED 0A A9 0A A6 26 0A 18 33 20 7F 2D 4D 3A 92 07 AE 39 A8 39 A6 26 53 1E 54 1E 1D 1E 57 2D 04 2D 55 32 BC 0C 95 34 C5 39 B7 2E E5 41 E6 41 AA 41 EE 6D 08 53 05 6B 99 97 98 97 C9 97 1C A7 22 57 23 57 73 57 0B 7B 67 76 6F 76 35 76 01 7B 30 45 28 45 66 5A 89 64 A6 5C FC 51 E5 46 1A F1 1D F1 49 F1 9C D6 BB C1 7C FC 4A C2 5B C2 08 DD C2 E3 D6 46 DD 46 82 46 A1 4B 96 75 97 75 FA 6A 2F 54 00 6C 56 61 66 76 AB 4B 82 75 AB 75 37 0B 32 0B 62 0B 40 06 67 38 6C 38 3A 27 EE 19 FF 31 FC 31 A9 31 A2 02 E9 1D 30 23 3F 8C 34 8C 68 8C 89 9E C5 A6 8D AB A8 BC 0D 81 3B BF 31 BF 67 A0 94 9E B2 A6 91 AB 55 1A 57 1A 0D 1A B1 2A 6F 17 7D DF 64 DF 24 DF 6B F3 97 CD AA F5 A7 F8 DD EF 00 D2 34 EC 0C EC 6B F3 81 CD 91 F5 F0 F8 CD EF 2C D2 05 EC 23 EC 6A F3 82 CD AB F5 DA F8 E5 EF 08 D2 3F EC 10 EC 43 F3 B6 28 B4 28 EC 28 6B 0F 52 18 16 3F 1F 3F 4D 3F 5D 0C 00 13 FC 2D C1 15 92 18 87 0F 7D 32 46 0C 7B 0C 94 D0 91 D0 C8 D0 DF E3 82 FC 7E C2 53 FA 13 F7 7F E4 7B E4 22 E4 78 C8 99 F6 AD CE E5 C3 63 F9 62 F9 3D F9 CC C9 11 7A 10 7A 4E 7A 7E 56 94 1B 8E 1B F4 1B 14 3C 31 2B E2 16 9E 28 D1 28 95 37 70 09 4B 31 22 3C 24 2B E9 16 C0 28 E9 28 8E 37 5B 09 7B 31 10 3C 25 2B F2 16 D5 28 E9 28 AA 37 78 09 41 31 23 3C 0C 2B 95 32 84 32 F4 32 DE 01 83 1E 7F 20 42 18 11 15 04 02 EC 3F D2 01 D4 01 9B 1E 5C 20 52 18 0E 15 21 02 D4 3F C9 01 FF 01 B7 1B AE 1B D5 1B 37 3C 12 2B C1 16 BD 28 EA 28 A7 37 59 09 66 31 2E 3C 16 2B E8 16 F0 28 F6 28 93 37 60 09 74 31 36 3C 07 2B C0 16 C0 28 C5 28 B2 37 5A 09 47 31 1F 3C B9 8D BF 8D DA 8D 57 A7 7C AA 05 BD D9 80 DC BE CC BE FF 81 FB 81 9B 81 67 A6 57 B1 8C 8C 98 B2 4C 6A 49 6A 29 6A CB 4D E9 5A 37 67 04 59 23 59 01 BC 06 BC 67 BC EF AE D5 96 94 9B B6 8C 60 B1 40 8F 62 8F BF 01 BB 01 D8 01 69 2B 3B 26 02 31 F9 0C 3D AE 20 AE 55 AE F3 84 FD 89 82 9E 72 A3 20 9D 3E 9D 6F 82 ED BC A3 84 B4 89 CA 9E 54 A3 44 9D 2A 9D 72 82 86 BC D5 84 E0 89 A5 9E 52 A3 2A 9D 68 9D 02 82 8F BC A3 84 F9 89 A2 9E 07 A3 45 9D BC 21 BA 21 D5 21 4A 33 3D 0B 30 06 42 11 9E 2C E3 12 15 89 1F 89 7F 89 B5 B9 62 84 45 BA 48 BA 02 A5 FC 9B CB A3 88 AE BA B9 74 84 F9 4E F8 4E 92 4E 3B 72 C1 18 CC 18 AD 18 DA 34 2D 0A 1D 32 59 3F 6A 28 BD 15 8D 2B 8C 2B C6 34 1E 0A 5F 32 67 3F 44 28 22 1A 2C 1A 4F 1A 6B 29 2E 36 C0 08 FF 30 BF 3D 87 2A 5D 17 63 29 7E 29 60 36 CC 08 FC 30 BF 3D B2 2A C9 9F C5 9F A7 9F C5 B3 27 8D 1F B5 4F B8 6E AF 88 92 85 AC 94 AC CA B3 2E 8D 0A B5 6E B8 60 E8 66 E8 0F E8 7B DB 33 C4 DB FA E3 C2 BA CF 94 D8 A8 12 BE 12 D8 12 AD 21 EA 21 A6 3E 56 00 75 38 7C 35 09 22 D8 1F AC 21 F2 21 A5 3E 4D 00 75 38 3D 35 0F 22 9A 1F FC 21 E7 21 A7 3E 57 00 72 38 1E 35 66 60 70 60 17 60 00 6D 23 53 2C 53 2A 4C 89 72 A7 4A FD 47 F5 50 10 6D 23 53 0A 53 58 4C 9D 72 A0 4A E6 47 C7 50 27 6D 1E 53 2F 53 62 4C AE 72 89 4A 97 1B 9A 1B E5 1B E0 16 C7 28 D8 28 91 37 6C 09 71 31 07 3C 21 2B EA 16 E4 28 DD 28 94 37 5E 09 5B 54 52 54 28 54 A2 46 8D 7E D9 73 ED 64 2C 59 2C 67 0D 67 4B 78 91 46 D8 B9 83 B9 AC B9 51 9E 2D 89 B1 B4 A1 8A A1 8A FF 95 08 AB 4B 93 51 9E 2E 89 E6 B4 CD 8A 8D 8A E7 95 6A AB 46 93 1C 9E 47 89 EA B4 81 8A C5 8A 96 95 62 AB 10 93 71 9E 25 89 E7 B4 CC 8A AD 8A 9A 95 2E AB 5A 93 57 9E 41 89 99 B4 B2 8A AD 8A 9A 95 2E AB 59 93 00 9E 2D 89 B1 B4 A1 8A CF 8A 97 95 63 AB 30 93 0C 9E 61 89 F8 B4 D0 8A C7 8A C1 95 0E AB 52 93 01 9E 2C 89 91 B4 A3 15 AA 15 D6 15 F9 26 B4 39 47 07 75 3F 3C 32 0E 25 C3 18 F3 26 DE 26 55 1A 54 1A 23 1A F6 3D 7A 38 7E 38 0D 38 CF 08 0D 35 2C 0B 12 0B ED 1B F6 1B 95 1B BD 28 A2 28 EB 37 48 09 35 31 7A 3C 46 2B 93 16 8B 28 B7 28 EC 37 03 09 30 31 77 3C 46 2B BC 16 95 28 B3 28 FA 37 12 09 3B 31 4A 3C 75 2B 98 16 AF 28 80 28 D3 37 55 D1 47 D1 2C D1 BB C3 92 FB C0 F6 F5 E1 37 DC 24 E2 10 E2 54 FD B1 C3 8A FB E3 F6 E5 E1 24 DC 14 E2 15 E2 59 FD B1 C3 A5 FB 4F 97 49 97 35 97 48 BB AA 85 93 BD E1 B0 FA A7 1E 9A C8 BC CF BC B3 BC 89 8F 88 8F C5 90 19 AE 0E 96 48 9B 45 8C E3 00 E7 00 9F 00 BA 33 F5 2C 07 12 1C 2A 9A B4 98 B4 E7 B4 58 9E 2D 93 74 B9 77 B9 0A B9 D2 89 09 B4 12 8A C4 B6 C3 B6 BB B6 05 9C 55 91 6D 86 BB BB 89 85 81 85 F5 9A 0F 76 09 76 8F 76 E6 64 F8 5C 96 51 A2 46 76 7B 78 45 93 A3 94 A3 12 A3 D0 90 81 8F 4F B1 4D 89 0E 84 3C 93 D2 AE 9F 26 97 26 1D 26 3E 16 FD 2B CE 15 F5 15 90 0A 7D 34 47 0C 38 01 DD 1F DB 1F 5E 1F 58 38 5A 2F A2 12 90 2C 98 2C EC 33 2C EF 25 EF A8 EF 66 DC 27 C3 CB FD FE C5 8E C8 85 DF 57 E2 63 DC 51 DC 98 90 9F 90 1D 90 F3 9D CF A3 E7 A3 97 BC 7A 82 40 BA 3F B7 E5 BF EF BF 63 BF E3 93 0B AD 22 95 62 98 54 8F B5 B2 AC 8C A2 8C EC 93 3D AD 4D 2D 46 2D CA 2D 90 07 CE 0A E6 1D 31 20 02 1E 0D 1E 7A 01 AB 3F 97 07 D2 0A DA 1D 1F 9B 19 9B 97 9B F1 89 D9 B1 9A BC B2 AB 63 96 6E A8 A9 74 AF 74 20 74 B9 58 47 66 6E 5E 2E 53 0C 44 F6 79 DD 42 D9 42 57 42 34 50 2D 68 47 65 50 72 1B 25 1D 25 90 25 49 09 A0 37 99 0F 9F 02 B0 15 5D 28 21 82 22 82 AD 82 FF A8 B4 A5 AD B2 04 E3 07 E3 89 E3 A3 D3 79 EE 66 D0 7E 73 7A 73 F0 73 08 7E 34 40 31 40 5E 5F 33 00 31 00 BC 00 3E 2C EC 12 B5 3F B6 3F 25 3F 61 15 32 18 3C 0F 55 40 51 40 C4 40 C4 67 F5 70 28 4D 3C 73 6E 2C 67 2C FC 2C 27 1F 6D 00 89 3E 9B 06 EA 0B C5 1C 0F 21 33 1F 13 1F 2E 70 28 70 BD 70 6D 43 61 43 20 5C E3 62 E5 5A 8D 57 E9 C8 ED C8 7D C8 E7 FB B1 E4 42 DA 64 E2 08 A5 0A A5 9D A5 F9 8F D3 82 38 C0 3C C0 AE C0 9C E7 AE F0 7B CD 33 F3 F1 05 F4 05 66 05 4A 22 76 35 B0 08 9C 36 9C 36 41 18 58 18 D9 18 01 2B 4E 34 BF 0A 9E 32 DA 3F C6 28 2B 15 0A 2B 2D 2B 57 34 B2 0A 97 32 E1 3F F2 28 36 15 0C 2B 39 2B 47 34 A3 0A 80 32 F2 3F E4 28 27 15 04 2B 2B 2B 3B E3 28 E3 A2 E3 D5 F1 FC C9 AE C4 9B D3 59 EE 4A D0 61 D0 2A CF D9 F1 C4 C9 BD C4 9A D3 5D EE 6C D0 60 D0 35 CF F3 F1 F0 C9 8B C4 CC 71 D4 71 56 71 9C 42 83 42 CA 5D 69 63 14 5B 5B 56 67 41 B2 7C AA 42 8E 42 C2 5D 26 63 3C 5B 64 56 78 41 AB 7C 9C 42 87 42 FD 5D 1B 63 18 5B 5E 56 4B 41 82 7C A9 B0 A6 B0 32 B0 08 80 CF BD EC 83 E3 83 BB 9C 77 A2 71 9A 3E 97 02 80 D7 BD CF 83 EB 83 A7 9C 43 A2 59 9A FB D2 EB D2 67 D2 7A C0 72 F8 61 F5 58 E2 80 DF AC E1 B9 E1 F5 FE 11 C0 2B F8 2F F5 4D E2 8C DF AB E1 BB E1 DC FE 38 FF 22 FF A5 FF D3 CF 4D F2 6E CC 79 CC 74 D3 C0 ED E5 D5 A8 D8 92 CF 53 F2 78 CC 38 CC 2A D3 DA ED E0 D5 AF D8 99 CF 42 F2 7F CC 39 CC 75 D3 89 ED FB D5 B8 D8 88 CF 42 F2 DC 00 DB 00 42 00 51 2A 51 27 7C 30 A1 0D 9A 33 DD 33 82 2C) */;

	public static bool IsValidPhone(string phone)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		return ColumnFilterEventArgs.Ⴀ(phone, Ⴐ(null, 6, 192632280), 972, 924);
	}

	public static bool IsValidEmail(string email)
	{
		return ColumnFilterEventArgs.Ⴀ(email, ArcLogInRqstExt.Ⴗ(1706508024, 7, 4), 608, 560);
	}

	public static string AdjustForBackspace(string msg)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num4 = default(int);
		while (true)
		{
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴐ[168] - 4247;
					continue;
				case 4:
					break;
				case 6:
					num4 = DownloadUrl2.ႥႠ(msg, '\b', 1, 'Ȏ', 556);
					goto case 0;
				case 0:
					msg = ReverseBeaconClient.Ⴗ(UtilsLatLon.Ⴜ(msg, 0, num4 - 1, 964, 996), AutoUpdater.ႨႣ(msg, num4 + 1, 562, 629), 'Ȥ', 'ɬ');
					num = 5;
					continue;
				case 5:
					num = ((msg.Length <= 0) ? (ⴃႭ[67] - 30145) : 2);
					continue;
				case 2:
				{
					int num2;
					if (msg.IndexOf('\b', 1) <= 0)
					{
						num2 = ⴐ[168] - 4244;
					}
					else
					{
						char num3 = ⴀ[370];
						DxCfg.Ⴗ[108] = (char)((DxCfg.Ⴗ[108] ^ WxCfg.ႣႭ[195]) & 0x3F);
						num2 = num3 - 60431;
					}
					num = num2;
					continue;
				}
				case 1:
				case 7:
					return msg;
				}
				break;
			}
		}
	}

	public static string ScrubSpaces(string msg)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char c = default(char);
		object obj = default(object);
		int num2 = default(int);
		while (true)
		{
			Array array = ArcLogInRespExt.Ⴐ(UtilsXml.Ⴗ(msg, 411, 'Ɗ'), 472, 409);
			int num = ⴗ[152] - 36442;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 9;
					continue;
				case 9:
				case 12:
					break;
				case 2:
					c = ' ';
					goto case 5;
				case 5:
					obj = string.Empty;
					num2 = 0;
					num = 4;
					continue;
				case 3:
					num = (((array as char[])[num2] != ' ') ? 8 : 10);
					continue;
				case 10:
					num = ((c == ' ') ? 1 : 8);
					continue;
				case 8:
					obj = ႰႣ.Ⴀ((object)(string)obj, (object)(array as char[])[num2], (short)273, 339);
					goto case 6;
				case 6:
					num = ⴃႤ[311] - 40916;
					continue;
				case 11:
					c = ((char[])array)[num2];
					num = ⴃႭ[286] - 63495;
					continue;
				case 1:
					num2++;
					num = 4;
					continue;
				case 4:
					num = ((num2 < (array as char[]).Length) ? (ⴃႣ[2] - 5265) : (ⴃႣ[176] - 11039));
					continue;
				case 7:
					return (string)obj;
				}
				break;
			}
		}
	}

	public static string ScrubKey(string key)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		while (true)
		{
			IComparable<string> comparable = string.Empty;
			Array array = ArcLogInRespExt.Ⴐ(key, 43, 106);
			int num = 0;
			while (true)
			{
				IL_0078:
				int num2 = 11;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = 8;
						continue;
					case 8:
						break;
					case 2:
						goto IL_0078;
					case 13:
					{
						int num3;
						if (((char[])array)[num] > '@')
						{
							num3 = 14;
						}
						else
						{
							char num4 = ⴃႣ[28];
							TalkCfg.ႣႣ[158] = (char)((TalkCfg.ႣႣ[158] - TalkCfg.ႣႣ[86]) & 0xB6);
							num3 = num4 - 41384;
						}
						num2 = num3;
						continue;
					}
					case 14:
						num2 = ((((char[])array)[num] < '[') ? 7 : 6);
						continue;
					case 6:
						num2 = ((((char[])array)[num] <= '`') ? (ⴃႣ[181] - 42051) : 3);
						continue;
					case 3:
					case 12:
						num2 = ((((char[])array)[num] < '{') ? 7 : (ⴃႣ[12] - 27350));
						continue;
					case 0:
						num2 = ((((char[])array)[num] <= '/') ? (ⴃႣ[194] - 48168) : (ⴃႣ[131] - 64718));
						continue;
					case 9:
					case 10:
						num2 = ((((char[])array)[num] >= ':') ? 4 : (ⴗ[33] - 33384));
						continue;
					case 7:
						comparable = ႰႣ.Ⴀ((object)(string)comparable, (object)(array as char[])[num], (short)151, 213);
						num2 = ⴃႣ[232] - 47279;
						continue;
					case 4:
						num++;
						num2 = 11;
						continue;
					case 11:
						num2 = ((num < ((char[])array).Length) ? (ⴐ[320] - 49914) : 5);
						continue;
					case 5:
						return (string)comparable;
					}
					break;
				}
				break;
			}
		}
	}

	public static string GetArcId(string userCall, string nodeCall)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		while (true)
		{
			Array array = new string[6];
			while (true)
			{
				IL_004b:
				((string[])array)[0] = userCall;
				((string[])array)[1] = ႣႼ.Ⴜ(8, 365387265, 18);
				int num = ⴃႤ[482] - 36632;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 6;
						continue;
					case 6:
						break;
					case 1:
						goto IL_004b;
					case 2:
						((string[])array)[2] = nodeCall;
						((string[])array)[3] = ႣႼ.Ⴜ(2, 365387204, 1);
						num = 4;
						continue;
					case 4:
					case 8:
					{
						string[] obj = (string[])array;
						DateTime dateTime = DxAtlasData.Ⴈ(879, 807);
						obj[4] = DgvTextBoxColumnFilter.Ⴈ(ref dateTime, DownloadUrl2.Ⴅ(12, null, 2018868822, 6), 312, 379);
						num = 0;
						continue;
					}
					case 0:
						(array as string[])[5] = ႣႼ.ႥႭ(null, 624735547, 2, null);
						num = ⴀ[154] - 28007;
						continue;
					case 5:
					case 7:
						return string.Concat(array as string[]);
					}
					break;
				}
				break;
			}
		}
	}

	public static string ScrubLength(string val, int maxLength)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		while (true)
		{
			int num = ((UtilsCallsign.Ⴓ(val, 522, 573) <= maxLength) ? 6 : 3);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀ[17] - 63639;
					continue;
				case 1:
				case 2:
				case 5:
					break;
				case 3:
				case 4:
					return UtilsLatLon.Ⴜ(val, 0, maxLength, 606, 638);
				case 6:
					return val;
				}
				break;
			}
		}
	}

	public static string StripFileExt(string fileName)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			int num = UtilsSql.ႨႷ(fileName, '.', 350, 275);
			int num2 = ((num <= 0) ? 4 : 5);
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[115] - 18164;
					continue;
				case 6:
					break;
				case 0:
				case 5:
					return UtilsLatLon.Ⴜ(fileName, 0, num, 628, 596);
				case 4:
					return fileName;
				}
				break;
			}
		}
	}

	public static string RemoveStartAndEndCommas(string list)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		while (true)
		{
			int num = ((!AutoUpdater.ႨႰ(list, TelnetServerClient.Ⴄ(1945322520, '\u009f', 7), 29, 't')) ? 4 : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 5;
					continue;
				case 5:
					break;
				case 0:
				case 2:
					list = AutoUpdater.ႨႣ(list, 1, 981, 914);
					num = 4;
					continue;
				case 4:
				{
					int num2;
					if (HelpAboutServer.ႷႰ(list, TelnetServerClient.Ⴄ(1945322520, '\u000e', 7), 587, 516))
					{
						num2 = 8;
					}
					else
					{
						int num3 = ⴃႤ[608];
						UtilsNumeric.Ⴀ[139] = (char)((UtilsNumeric.Ⴀ[139] * WxCfg.ႣႭ[130]) & 0x82);
						num2 = num3 - 18936;
					}
					num = num2;
					continue;
				}
				case 8:
					list = list.Substring(0, list.Length - 1);
					num = 1;
					continue;
				case 1:
				case 7:
					return list;
				}
				break;
			}
		}
	}

	public static string StripHop(string cmd)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			int num = ColumnFilterEventArgs.Ⴍ(cmd, DownloadUrl2.Ⴅ(5, null, 2018868800, 1), 367, 361);
			while (true)
			{
				IL_005d:
				int num2 = ⴐ[300] - 16235;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = 2;
						continue;
					case 2:
					case 3:
						break;
					case 7:
						goto IL_005d;
					case 5:
						num2 = ((num > 0) ? (ⴗ[105] - 4874) : 4);
						continue;
					case 4:
						return cmd;
					case 1:
					case 6:
						return cmd.Substring(0, num);
					}
					break;
				}
				break;
			}
		}
	}

	public static string ScrubRxCommMsg(string msg)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			msg = DgvFilterManager.ႭႭ(msg, Ⴐ(null, 4, 192632144), Ⴐ(null, 7, 192631500), 639, 541);
			int num = ⴃႤ[167] - 17664;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
				case 2:
					break;
				case 9:
					msg = DgvFilterManager.ႭႭ(msg, ႣႼ.ႥႭ(null, 624735543, 1, null), Ⴐ(null, 0, 192631499), 448, 418);
					num = 7;
					continue;
				case 7:
					msg = DgvFilterManager.ႭႭ(msg, ႣႼ.ႥႭ(null, 624735530, 3, null), Ⴐ(null, 1, 192631498), 676, 710);
					num = ⴗ[8] - 15530;
					continue;
				case 3:
				case 8:
					msg = DgvFilterManager.ႭႭ(msg, ႣႼ.ႥႭ(null, 624735521, 3, null), DownloadUrl2.Ⴅ(24, null, 2018868800, 4), 87, 53);
					num = 6;
					continue;
				case 1:
				case 6:
					msg = msg.Replace(DownloadUrl2.Ⴅ(25, null, 2018868803, 7), string.Empty);
					num = ⴃႤ[120] - 14316;
					continue;
				case 4:
					return msg;
				}
				break;
			}
		}
	}

	public static bool IsMsgRequestingLogin(string msg)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		while (true)
		{
			int num3;
			if (!AutoUpdater.ႨႰ(msg, Ⴐ(null, 2, 192632443), 997, '\u038d'))
			{
				char num = ⴐ[534];
				char num2 = ⴐ[534];
				TalkCfg.ႣႣ[137] = (char)((TalkCfg.ႣႣ[137] + UtilsNumeric.Ⴀ[161]) & 0x8E);
				num3 = num - num2;
			}
			else
			{
				num3 = 7;
			}
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num4 = 5;
					continue;
				case 2:
				case 5:
					break;
				case 0:
					num4 = (AutoUpdater.ႨႰ(msg, Ⴐ(null, 3, 192632328), 669, '\u02f5') ? 7 : 4);
					continue;
				case 4:
					num4 = (AutoUpdater.ႨႰ(msg, ArcLogInRqstExt.Ⴗ(1706507820, 21, 3), 930, 'ϊ') ? 7 : (ⴐ[351] - 17277));
					continue;
				case 6:
				case 8:
					return msg.Contains(TelnetServerClient.Ⴄ(1945322515, 'M', 8));
				case 1:
				case 7:
					return true;
				}
				break;
			}
		}
	}

	public static string ConvertToHex(string asciiString)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num5 = default(int);
		while (true)
		{
			IEnumerable<char> enumerable = string.Empty;
			int num = 0;
			int num2 = ⴃႤ[222] - 57350;
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
				case 4:
				case 5:
				case 8:
				{
					char c = AnnWxSpotExt.Ⴅ(asciiString, num, 623, 596);
					num5 = c;
					num2 = 3;
					continue;
				}
				case 3:
					enumerable = ReverseBeaconClient.Ⴗ(enumerable as string, UnZipFiles.Ⴓ(Ⴐ(null, 3, 192632317), (object)DgvCheckBoxColumnFilter.Ⴐ(num5.ToString(), 'ϙ', 1005), (short)142, (short)146), '÷', '¿');
					num2 = 0;
					continue;
				case 0:
					num++;
					num2 = 9;
					continue;
				case 9:
				{
					int num4;
					if (num >= (asciiString as string).Length)
					{
						char num3 = ⴗ[33];
						NeedsCfg.ႣႤ[389] = (NeedsCfg.ႣႤ[389] + NeedsCfg.ႣႤ[97]) & 0xE5;
						num4 = num3 - 33384;
					}
					else
					{
						num4 = 4;
					}
					num2 = num4;
					continue;
				}
				case 2:
				case 7:
					return enumerable as string;
				}
				break;
			}
		}
	}

	public static string FileFromFilePath(string filePath)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		while (true)
		{
			object obj = string.Empty;
			while (true)
			{
				IL_004f:
				int num = WwvSpotExt.Ⴍ(filePath, '\\', 155, 201);
				int num2 = ((num <= 0) ? 1 : (ⴀ[271] - 42989));
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = ⴃႣ[187] - 55711;
						continue;
					case 5:
					case 6:
						break;
					case 3:
						goto IL_004f;
					case 2:
					case 4:
						obj = AutoUpdater.ႨႣ(filePath, num + 1, 364, 299);
						num2 = ⴃႣ[2] - 5267;
						continue;
					case 1:
						return obj as string;
					}
					break;
				}
				break;
			}
		}
	}

	public static bool DxFilterContainsCt1boh(string dxFilter)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		while (true)
		{
			dxFilter = UtilsDate.Ⴓ(dxFilter, 'Ó', 205);
			int num;
			if (!AutoUpdater.ႨႰ(dxFilter, ႣႼ.ႥႭ(dxFilter, 624735523, 4, null), 828, '\u0354'))
			{
				num = 3;
			}
			else
			{
				char num2 = ⴐ[447];
				WxCfg.ႣႭ[41] = (char)((WxCfg.ႣႭ[41] + WxCfg.ႣႭ[63]) & 0x74);
				num = num2 - 63932;
			}
			int num3 = num;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = 9;
					continue;
				case 9:
					break;
				case 3:
					num3 = (AutoUpdater.ႨႰ(dxFilter, ႣႼ.Ⴜ(5, 365387275, 28), 490, 'Ƃ') ? 6 : (ⴗ[115] - 18163));
					continue;
				case 2:
				case 7:
					num3 = ((!AutoUpdater.ႨႰ(dxFilter, Ⴐ(null, 6, 192632311), 888, '\u0310')) ? 1 : (ⴃႤ[515] - 50905));
					continue;
				case 1:
					num3 = (AutoUpdater.ႨႰ(dxFilter, ArcLogInRqstExt.Ⴗ(1706507836, 0, 5), 315, 'œ') ? 6 : 10);
					continue;
				case 0:
				case 10:
					num3 = ((!dxFilter.Contains(TelnetServerClient.Ⴄ(1945322541, 'ß', 7))) ? 5 : 6);
					continue;
				case 6:
					return true;
				case 5:
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static UtilsString()
	{
		char[] array = new char[8];
		array[6] = 'Ɫ';
		array[4] = '⪳';
		array[2] = 'ツ';
		array[5] = 'ኋ';
		array[1] = 'ഒ';
		array[7] = '㌮';
		array[0] = '㌤';
		array[3] = '⟴';
		Ⴈ = new string[159];
		Ⴄ = array;
		UtilsIdentity.Ⴐ();
	}

	internal static string Ⴐ(Assembly P_0, int P_1, int P_2)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		int num7 = default(int);
		object obj5 = default(object);
		object obj2 = default(object);
		ISerializable serializable = default(ISerializable);
		char c = default(char);
		int num6 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = P_2 ^ 0xB7B524D ^ P_1;
			object ⴗ = Ⴗ;
			char[] obj = (char[])ⴗ;
			int num2 = obj[num];
			num2 = obj[num + 2] ^ num2;
			int num3 = 11;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = ⴃႣ[206] - 36153;
					continue;
				case 3:
					break;
				case 11:
					num3 = (((enumerable = ((string[])Ⴈ)[num2]) == null) ? 16 : 9);
					continue;
				case 9:
				case 17:
					return enumerable as string;
				case 16:
				{
					char[] obj3 = (char[])ⴗ;
					char[] obj4 = (char[])Ⴄ;
					num7 = num;
					obj5 = obj4;
					obj2 = obj3;
					num3 = ⴃႤ[396] - 9911;
					continue;
				}
				case 15:
					serializable = new StringBuilder();
					c = (obj2 as char[])[num7];
					goto case 5;
				case 5:
				case 10:
					num6 = ((char[])obj2)[num7 + 1] ^ c;
					num3 = ⴐ[54] - 45100;
					continue;
				case 1:
					num7 += 3;
					num5 = (num6 & 0x1F) | ((num6 & 0xFFC0) >> 1);
					num3 = 8;
					continue;
				case 8:
					num3 = (((num6 & 0x20) == 0) ? (ⴀ[225] - 22439) : 7);
					continue;
				case 7:
					num5 = (num5 << 15) | (((char[])obj2)[num7++] ^ c);
					num3 = 4;
					continue;
				case 4:
					num8 = (obj5 as char[]).Length;
					num4 = 1;
					num3 = ⴐ[113] - 30581;
					continue;
				case 12:
					(serializable as StringBuilder).Append((char)(c ^ ((char[])obj2)[num7 + num5 - num4] ^ (obj5 as char[])[(num4 + num7 + 17) % num8]));
					num3 = 14;
					continue;
				case 14:
					num4++;
					num3 = 6;
					continue;
				case 6:
					num3 = ((num4 <= num5) ? (ⴀ[181] - 42545) : (ⴐ[24] - 4002));
					continue;
				case 0:
					enumerable = ((StringBuilder)serializable).ToString();
					((string[])Ⴈ)[num2] = enumerable as string;
					num3 = 13;
					continue;
				case 13:
					return enumerable as string;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[128] - 21300;
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
				case 8:
					num2 = (((P_2 ^ P_1) - 18) ^ num) switch
					{
						0 => 10, 
						_ => 11, 
					};
					continue;
				case 11:
					comparable = null;
					num2 = 6;
					continue;
				case 10:
					comparable = P_0.ToString();
					num2 = 6;
					continue;
				case 5:
				case 6:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 != 0) ? 1 : 9);
					continue;
				case 1:
				case 4:
					num2 = 8;
					continue;
				case 9:
					return comparable as string;
				case 0:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210, _0021_00211, _0021_00212>(_0021_00210 P_0, _0021_00211 P_1, _0021_00212 P_2, char P_3, int P_4) where _0021_00210 : WebClient where _0021_00211 : string where _0021_00212 : string
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 0;
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
				num = (((P_4 ^ P_3) - 18) ^ num3) switch
				{
					0 => 4, 
					_ => ⴗ[30] - 17777, 
				};
				break;
			case 7:
				num = 2;
				break;
			case 4:
				P_0.DownloadFile(P_1, P_2);
				goto case 1;
			case 1:
			case 2:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = 3;
				break;
			case 3:
				num = ((num2 % 2 != 0) ? (ⴐ[15] - 19734) : (ⴗ[144] - 45237));
				break;
			case 8:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 3;
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
				num = (((P_2 ^ P_1) - 9) ^ num2) switch
				{
					0 => 7, 
					_ => ⴐ[48] - 38877, 
				};
				break;
			case 2:
				num = 9;
				break;
			case 7:
			case 8:
				Monitor.Exit(P_0);
				goto case 9;
			case 9:
			{
				num2++;
				int num3 = 256;
				int num4 = 822;
				num = ((4110 > num4 - num3 * 5) ? (ⴃႣ[103] - 47726) : (ⴗ[93] - 717));
				break;
			}
			case 0:
				num = ⴃႤ[123] - 21534;
				break;
			case 1:
			case 4:
				return;
			}
		}
	}
}
