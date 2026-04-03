using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Arcx;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods.Login;
using ZedGraph;
using Ⴀ;

namespace ArcClientEngine.ArcCfg;

public class ClientCty
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4266)]
	private struct Ⴐ
	{
	}

	private MultimediaCfg.Ⴍ Ⴈ = new MultimediaCfg.Ⴍ();

	private static readonly Array Ⴀ;

	private static readonly Array Ⴅ = new char[2133]
	{
		'臠', '臨', '臠', '꺕', '\ua82e', 'ꤢ', '\ua63e', '萅', '\uab08', '덗',
		'鹰', '滨', '满', '滩', '欱', '䑩', '屫', '煕', '䆏', '䜿',
		'䘀', '䤾', '欚', '嬏', '嬈', '嬍', '珑', '糄', '廍', '熲',
		'榎', '䒲', '瑄', '\u0e6c', '\u0e7c', '\u0e6f', 'ᇝ', '℞', '➣', '⚯',
		'⦫', '\u0b97', '⒄', '㳱', 'ᇝ', 'ℚ', '⟶', '⚲', '⦶', 'வ',
		'ⓔ', '㳐', '炯', '為', '炫', '漉', '忌', '好', '塶', '坠',
		'畼', '娰', '䉠', '漚', '忊', '奼', '塰', '坤', '畴', '娦',
		'䉠', '漓', '忝', '奧', '塭', '坏', '괌', '괆', '괉', '藀',
		'論', '\ua8de', '蟪', '龑', '늽', '艾', '蓅', '藀', '諯', 'ﳝ',
		'ﳜ', 'ﳛ', '\ude92', '⍝', '⍒', '⍚', '⚃', '\u09e5', 'ᇓ', '㳻',
		'జ', '\u0a82', '\u0b84', 'Ғ', '⚹', 'ৡ', 'ᇝ', '㳹', 'ఈ', 'ટ',
		'ழ', '墄', '墖', '墌', '䜸', '矲', '煟', '灛', '罭', '崒',
		'爩', '樟', '䜱', '矐', '焞', '灝', '罅', '嵂', '爟', '橋',
		'䜈', '矆', '\udd73', '\udd70', '\udd7a', '\uf49a', '\uf58a', '滋', '㍒', '㍋',
		'㍘', '᧮', 'ǜ', 'Ⳣ', 'ᱺ', '\u1a8c', 'ᮐ', 'ᒑ', '㚻', '᧮',
		'Ǌ', 'ⳙ', '\u1c2d', '\u1a9c', 'ᮜ', 'ᒠ', '㚔', '᧯', 'ǉ', 'ⳣ',
		'ᰇ', '\u1ab4', 'ᮘ', 'ᒚ', '㚧', 'ᧆ', '㭓', '㭀', '㭘', '⒯',
		'ᑵ', 'ኍ', '\u139b', 'Კ', '㺄', 'ᇴ', '\u09d0', '⒧', 'ᐦ', 'ኌ',
		'᎗', '\u1c8f', '㺑', 'ᇵ', '\u09c9', 'ⓨ', 'ᐶ', 'ዉ', '聉', '聂',
		'聅', '\ua981', '\ua881', 'ꞓ', '薓', 'ꫨ', '닠', '鿥', '꼋', 'ꦇ',
		'\ua881', 'Ꞵ', 'ᆪ', 'ᆦ', 'ᆧ', '㥵', '㙡', 'ᑨ', '㬎', '⌬',
		'\u0e38', '㻔', '㡔', '㥰', '㙫', 'ᑴ', '㬱', '\u0336', '\u0337', '\u0338',
		'\u31e5', '⒪', '⒧', '⒥', 'ᘠ', '㬖', '\u0bcf', '൱', '\u0c44', 'ͼ',
		'⅘', 'ถ', 'ᘫ', '㬛', '\u0bc5', 'ർ', '\u0c44', '캓', '캅', '캃',
		'\ue43e', 'ﰔ', '턤', '\ue1f4', '\ue76a', '\ue64d', '\ue949', '쭆', '\ue43e', 'ﰒ',
		'턩', '\ue1fa', '\ue76a', '\ue65d', '\ue94f', '쭤', '\ue42f', 'ﰒ', '턢', '\ue1fc',
		'\ue745', '\ue67d', 'ਝ', 'ਓ', '\u0a0c', '࿎', '₽', '㢑', 'ᖨ', '╘',
		'⏑', '⋇', '\u2de4', '\u0fdf', '₻', '㢗', 'ᖠ', '╷', '⏤', '\u07fc',
		'߹', '\u07ee', 'Ȧ', 'ⵕ', '㕺', 'ᡚ', '⢻', '磾', '磶', '磭',
		'儳', '值', '弴', '紦', '剟', '䩆', '杒', '垼', 'Ἰ', 'Ἶ',
		'Ἤ', 'が', '㛧', '㟷', '㣻', '\u1afb', '㖾', '䀿', '䀺', '䀪',
		'潔', '槨', '梨', '柙', '䗁', '\u1dfc', '\u1df3', '\u1dea', '⼺', 'ɼ',
		'㊷', '㐁', '㕹', '㩲', 'ᠯ', '㝙', '⽺', 'ɼ', '㋚', '㐲',
		'㔾', '㨢', '᠙', '챘', '챑', '챏', '\ue48c', '\ueb95', '즀', '\ue6f5',
		'ﻂ', '폽', '\ue33b', '\ue590', '\ue4b3', '\u0fdf', '࿋', '࿇', '⠕', 'ਅ',
		'╥', '㵟', 'ၜ', '\u20f9', '☀', '✚', '⠅', '\u0a49', '╱', '㵟',
		'\u102b', '₲', '☊', '✝', '⠓', '\u0a0e', '╸', '㵼', '첧', '철',
		'첾', '\ue56f', '\ue46f', '\ueb64', '쥼', '\ue606', '\ufe23', '팠', '\u171d', '\u1714',
		'ᜇ', '㶱', '▛', 'ࢥ', '㡺', '㻱', '㿝', 'ペ', 'ዀ', '㶆',
		'䯪', '䯢', '䯱', '挞', '気', '不', '愂', '票', '呗', '撇',
		'戃', 'ቪ', 'በ', 'ቶ', '㣆', '\u20e0', '\u0dca', '㴟', '㮥', '㪅',
		'㖩', '\u17b5', '㣉', '\u20d6', '뤯', '뤣', '뤲', '议', 'Ꚍ', '陆',
		'郻', '釩', '黯', '볌', '鏇', '训', 'Ꚓ', '陂', '郆', '踆',
		'踀', '踘', '꒟', '벪', '醿', 'ꅩ', 'ꟗ', '\ua6f8', '␟', '␙',
		'␀', '⇘', 'ດ', '\u169d', '㮢', '୲', '\u0df6', '臞', '臙', '臾',
		'ꤞ', 'ꘀ', '萿', 'ꭻ', '던', '鹡', '꺋', '說', '獵', '呂',
		'큩', '텩', '\ude7b', 'ﱤ', '팈', '쬃', '떪', '떬', '떈', '骜',
		'鰠', '鴶', '鉴', '끳', '鼶', 'ዓ', 'ዐ', 'ደ', '㨓', '㔜',
		'ᜭ', '\u173e', '\u173a', '\u171a', 'ヤ', 'ዦ', '㶙', '▒', '\uf875', '\uf873',
		'\uf850', '킽', '\udfb5', 'ﶬ', '틧', '쫫', '\ue7e2', '鉭', '鉩', '鉋',
		'떧', '鞵', '룄', 'ꃀ', 'ꬔ', '\uab1e', 'ꬳ', '馂', '뒴', '葱',
		'苜', '菜', '賎', '껖', '膳', '馋', '뒳', '啝', '啓', '啵',
		'翬', '柆', '䫠', '稷', '粆', '綅', '犂', '備', '翰', '柟',
		'䫤', '稲', '粌', '綃', 'ᑊ', 'ᑏ', 'ᑣ', '㺢', '⛲', '\u0bca',
		'㬃', '㶼', '垚', '垜', '垰', '刌', '紷', '攁', '䠯', '磨',
		'繳', 'ﭰ', 'ﭸ', 'ﭛ', '틪', '펳', '\udcb1', 'ﺯ', '퇌', '짼',
		'\ue4c1', '퐥', '\uf146', '\uf143', '\uf16a', '\ud8dc', '\ud98f', '횁', '\uf482', '\udbc9',
		'谫', '谣', '谆', '뻤', '鎚', 'ꍃ', 'ꗾ', 'ꓜ', '꯰', '觩',
		'ꚪ', '㰣', '㰨', '㰍', 'ጅ', 'ᗠ', 'ᓺ', 'ᯎ', '㧧', 'ᚎ',
		'\u0eb8', '⎃', 'ፊ', 'ᗩ', 'ᓝ', '直', '画', '慎', '툥', '\udd65',
		'ｱ', '퀬', '젵', '\ue519', '헚', '퍦', '퉪', '\udd76', 'ｍ', '祌',
		'祃', '祼', '噪', '傏', '冕', '庋', '粖', '句', '䯖', '曉',
		'嘸', '傓', '册', '序', '粓', '可', '䯰', '쫕', '쫘', '쫤',
		'\ue5b6', '\ue31b', '\ue219', '\ued0f', '켰', '\ue03d', '\uf848', '핤', '\ue5a7', '\ue31b',
		'\ue217', '\ued0b', '켰', '쉅', '쉍', '쉷', '\ue8e8', '\uf0c2', '\uddf2', '\ued22',
		'\uebbc', '\uea9e', '\ue59c', '잤', '烶', '烦', '烅', '堾', '圶', '甯',
		'婄', '䈹', '潷', '徤', '夅', '塻', '圪', '甥', '婊', '䉭',
		'潍', '往', '够', 'ᒡ', 'ᒳ', 'ᒕ', '㸍', '☠', 'ଔ', '㯅',
		'㴻', '㱩', '㍧', 'ᅣ', '㹉', '☨', 'ଚ', '㮇', '㵶', '㱣',
		'㍻', 'ᅣ', '㸆', '☌', '셁', '셃', '셴', '\uee75', '\ue8bf', 'Ⴐ',
		'Ⴑ', '\u1086', '\u05ab', '䆡', '䆠', '䆖', '縏', '僭', '僠', '僕',
		'羆', '礶', '砥', '眱', '唯', '究', '执', '佞', '羊', '示',
		'砉', '睭', '䗸', '躵', '軼', '躌', '護', 'ꐜ', '밾', '酏',
		'ꇀ', 'ꝡ', '\ua677', 'ꥲ', '護', 'ꐞ', '밿', '鄏', 'ꇝ', 'Ꝡ',
		'ꙛ', 'ꥩ', '警', 'ꐋ', '밨', '鄄', 'ꇠ', 'Ꝭ', 'Ꙫ', '\ua95a',
		'譟', 'ꐍ', '밯', '鄕', 'ꇖ', 'Ꝝ', 'Ꙭ', 'ꥵ', '警', 'ꐔ',
		'밶', '鄢', 'ꇯ', 'Ꝩ', '꙾', '\ua958', '譟', 'ﺋ', 'ﺊ', 'ﺱ',
		'토', 'ꐆ', 'ꐇ', 'ꐽ', 'ꇦ', '闰', '闱', '闌', '몴', '냴',
		'냵', '냉', '딓', 'ჴ', 'ყ', '\u10ca', '≩', 'ཅ', '㾂', '㤾',
		'㠸', '㜨', 'ᔕ', '㩎', '≾', 'བ', '㾀', '㤫', '㠊', '㜮',
		'ᔧ', '㩒', '≷', 'ཅ', '㾦', '齔', '齖', '齫', '뚖', '랽',
		'佮', '佡', '伮', '僟', '怏', '暵', '枰', '梳', '䪽', '旋',
		'綡', '僈', '怍', '暼', '枷', '梡', '䪽', '旱', '༴', '༤',
		'\u0f75', '૯', '░', '㷡', 'Ⴈ', '⁺', '⚮', '⟠', '⣣', '\u0afb',
		'▅', '㷴', 'Ⴍ', 'ⁿ', '⚡', '⟽', '⣾', '르', '륶', '뤶',
		'\ua6f8', '阥', '蚧', '蛭', '蛤', '긷', 'ꅧ', '荶', '갆', '됻',
		'餟', '꧍', '꽼', '깩', 'ꄶ', '荽', '갂', '됼', '餛', 'ꦏ',
		'꽳', '깭', 'ꅠ', '荢', '갃', '됤', '餒', '꧂', '꼲', '깧',
		'ꅦ', '荲', '걁', '됲', '餁', '꧐', '꼳', '깽', 'ꅾ', '荦',
		'걀', '둧', '饉', '꧑', '꽩', '깾', 'ꅡ', '対', '寸', '宺',
		'爨', '猶', '簳', '带', '煗', '楒', '\uf062', '\uf063', '\uf027', '쨝',
		'൭', '൮', 'ഫ', 'ዷ', '∥', '⒖', '혜', '혗', '홛', 'ￃ',
		'ﻜ', '\uf1d3', '폤', 'ﳴ', '\ue481', '즭', '葉', 'ￊ', 'ﻘ', '\uf1f4',
		'瞮', '瞡', '矦', '栂', '壬', '幋', '彷', '偮', '牽', '崏',
		'䔭', '根', '壷', '幟', '弶', '偂', '牙', '嵚', '峦', '峡',
		'岯', '癜', '湬', '䍁', '玵', '甿', '琹', '笉', '⎢', '⎴',
		'⏨', '☺', 'ऍ', 'ᄣ', '㰟', '\u0cd0', '੪', '୮', 'Ѹ', '♧',
		'\u094a', 'ᄾ', '㰟', '಄', '੬', 'ୡ', 'ѩ', '♽', 'आ', 'ᄎ',
		'㰕', '\u0cd6', 'ਖ਼', '૯', '\u0af4', 'ત', '㠮', 'ᕕ', '▞', '⌺',
		'∦', 'ⵡ', '\u0f3e', '⁉', '㡩', 'ᕏ', '▝', '⌠', '∪', 'ⴲ',
		'\u0f79', '\u2054', '㡩', 'ᔛ', '▝', '⌻', '∧', '\u2d28', '\u0f35', '\u2064',
		'㡣', 'ᕉ', '▨', '\ue8a3', '\ue8bd', '\ue8ef', '숟', '\uda2d', '\uf713', '잋',
		'셪', '쁫', '콮', '\ued7b', '숂', '\uda3a', '\uf718', '쟗', '셉', '쁒',
		'콽', '\ued60', '숟', '\uda29', '\uf724', '쟑', '셷', '쁫', '콤', '\ued79',
		'숨', '\uda10', '\uf710', '쟃', '셚', '쁒', '⊊', '⊈', '⋇', '\u0dcd',
		'\u0b63', '\udb11', '\udb1e', '\udb5f', '\ue99b', '쒭', '\uf474', '\uf2ca', '\uf3ff', 'ﳋ',
		'\uded4', '\uf1b0', '\ue9ba', '쒢', '\uf473', '\uf2e3', '\uf3c5', 'ﳋ', '\udee4', '莲',
		'莸', '菽', 'ꩺ', 'ꭺ', 'ꑨ', '虨', 'ꤓ', '넛', '鱆', '곃',
		'ꩭ', 'ꭑ', '邅', '邂', '郕', '輥', '뿯', '륊', '롉', '띍',
		'镖', '먉', 'ᱳ', 'ᳶ', 'ᰢ', 'ϕ', '㌐', '㖿', '㒬', '㮸',
		'ᦖ', '㚛', '⻨', 'ς', '㌛', '㖥', '㒻', '㮉', '᧥', '㛞',
		'\u2ef4', 'ϓ', '㍕', '㖦', '㒪', '㯽', 'ᦼ', '㛗', '⻬', 'ϗ',
		'㌔', '㗩', '㒱', '㮮', 'ᦩ', '㛺', '⺼', 'Ί', '㍕', '㖻',
		'㒻', '㮩', 'ᦩ', '㛒', '\u2efa', '·', '㌁', '㖥', '㒫', '㮼',
		'ᦣ', '㛞', '\u2ef8', '·', '㌐', '㖡', '㒪', '㯽', 'ᦷ', '㛞',
		'⻨', 'ϋ', '㌜', '㖯', '㓾', '㮮', '\u19ac', '㛓', '⻨', '·',
		'㌐', '㖢', '㒿', '㮐', '튜', '튘', '틎', '\ufdee', 'ﭏ', '突',
		'\uf577', '䞔', '䜓', '䟇', '畛', '塺', '棽', '湚', '漙', '恞',
		'䉇', '活', '甕', '堡', '棺', '湍', '漙', '恉', '䉃', '洫',
		'畛', '堲', '棷', '湘', '潋', '恟', '䉱', '浼', '甏', '堥',
		'棼', '湂', '潜', '恮', '䈂', '洹', '甓', '場', '梲', '湊',
		'潗', '恛', '䈂', '洫', '甔', '堤', '棼', '湇', '潎', '怚',
		'䉺', '洘', '畛', '堲', '棽', '湈', '漙', '恈', '䉇', '洨',
		'甗', '堩', '棴', '渎', '潍', '恖', '䉗', '洽', '甝', '堥',
		'棶', '渎', '潜', '恒', '䉶', '\uf6e9', '\uf6f9', '\uf6bd', '턷', '\uf32a',
		'\udc55', '쑣', '\ue96e', '\ud99b', '\udf3d', '\ude21', '턮', '\uf333', '\udc62', '쑚',
		'\ue95a', '\ud989', '\udf10', '\ude18', 'ᴐ', 'ᴕ', 'ᵅ', '㫊', 'ᣇ', '㞼',
		'⿑', 'ˮ', '\u0f7f', '\u0f71', '༩', '➦', '⢰', 'ભ', '▙', '㷴',
		'Ⴤ', '—', '⚚', '➦', '⢦', 'ખ', '◎', '㷤', '\u10c8', '삛',
		'쀗', '샌', '\ue715', '씗', '\uea3c', '\uf200', '\udf6f', '\ueff9', '\ue944', '\ue851',
		'\ue75b', '알', '\uea3b', '\uf217', '\udf6f', '\uefee', '\ue940', '\ue841', '\ue715', '앟',
		'\uea36', '\uf202', '\udf3d', '\ueff8', '\ue972', '\ue816', '\ue741', '안', '\uea3d', '\uf218',
		'\udf2a', '\uefc9', '\ue901', '\ue853', '\ue75d', '앙', '\uea73', '\uf210', '\udf21', '\ueffc',
		'\ue901', '\ue841', '\ue75a', '앉', '\uea3d', '\uf21d', '\udf38', '\uefbd', '\ue953', '\ue853',
		'\ue75d', '앙', '\uea32', '\uf211', '\udf18', '\uefbd', '\ue953', '\ue859', '\ue753', '씍',
		'\uea21', '\uf211', '\udf3b', '\ueff1', '\ue948', '\ue850', '\ue715', '앙', '\uea3f', '\uf201',
		'\udf2e', '\ueffb', '\ue944', '\ue852', '\ue715', '안', '\uea3b', '\uf220', '\ue8f2', '\ue879',
		'\ue8aa', '숗', '\uda30', '\uf70b', '쟙', '셥', '쁲', '콱', '\ued69', '숗',
		'\uda30', '\uf70b', '쟙', '셥', '쁲', '콱', '\ued69', '숗', '\uda30', '\uf70b',
		'쟙', '셥', '쁲', '콱', '\ued69', '숗', '\uda30', '\uf70b', '쟙', '셥',
		'쁲', '콱', '\ued69', '숗', '\uda30', '\uf70b', '쟙', '셥', '쁲', '콱',
		'\ued69', '숗', '\uda30', '\uf70b', '쟙', '셥', '쁲', '콱', '\ued69', '숗',
		'\uda30', '\uf70b', '쟙', '셥', '쁲', '콱', '\ued69', '숗', '\uda30', '\uf70b',
		'쟙', '셥', '쁲', '콱', '\ued69', '숗', '\uda30', '\uf70b', '쟙', '셥',
		'쁲', '콱', '\ued69', '숗', '\uda30', '\uf70b', '琉', '璂', '瑐', '殡',
		'嬯', '嶓', '岄', '厇', '熟', '廡', '䛆', '毽', '嬯', '嶓',
		'岄', '厇', '熟', '廡', '䛆', '毽', '嬯', '嶓', '峁', '叕',
		'燞', '庶', '䚒', '殻', '孠', '巠', '岄', '厑', '熟', '庯',
		'䚉', '殴', '孼', '巁', '峁', '叱', '熟', '庵', '䚈', '殸',
		'学', '巟', '峧', '厇', '燍', '庤', '䚒', '殮', '孺', '巟',
		'峧', '厊', '燭', '庀', '䛆', '殺', '孡', '巚', '峊', '叉',
		'燊', '库', '䛆', '毽', '嬯', '嶓', '岄', '厇', '熟', '廡',
		'䛆', '毽', '嬯', '巏', '쇤', '셨', '솾', '\uee90', '\ue83b', '\ue93d',
		'\ue639', '쐧', '\ueb40', '\uf368', '\ude10', '\uee87', '\ue836', '\ue93d', '\ue66a', '쐽',
		'\ueb58', '\uf365', '\ude59', '\ueec2', '\ue82d', '\ue92e', '\ue625', '쐾', '\ueb0c', '\uf379',
		'\ude55', '\uee91', '\ue82b', '\ue969', '\ue62f', '쐺', '\ueb58', '\uf32b', '\ude42', '\uee87',
		'\ue82a', '\ue92f', '\ue62b', '쑲', '\ueb48', '\uf36e', '\ude49', '\uee83', '\ue832', '\ue939',
		'\ue639', '쐻', '\ueb48', '\uf32b', '\ude44', '\uee91', '\ue82c', '\ue920', '\ue62c', '쑲',
		'\ueb5f', '\uf362', '\ude10', '\uee96', '\ue83f', '\ue921', '\ue63e', '쑲', '\ueb42', '\uf362',
		'\ude57', '\uee8d', '\ue832', '\ue969', '\ue62f', '쐿', '\ueb43', '\uf368', '\ude5c', '\uee87',
		'\ue809', '\ue969', '\ue669', '袈', '裝', '裓', 'ꟳ', 'ꅼ', 'ꁪ', '꽯',
		'赭', 'ꈒ', '먢', '霊', '\ua7cd', 'ꅠ', 'ꁤ', '꽝', '贞', 'ꈮ',
		'먈', '霵', 'ꟽ', 'ꅀ', 'ꁀ', '꽐', '贞', 'ꈴ', '먉', '霹',
		'\ua7e7', 'ꅞ', 'ꁦ', '꼆', '赌', 'ꈥ', '먓', '霯', 'ꟻ', 'ꅞ',
		'ꁦ', '꼋', '赬', 'ꈁ', '멇', '霹', '\ua7e6', 'ꅆ', 'ꀅ', '꽉',
		'赊', 'ꉠ', '먂', '霱', '\ua7e1', 'ꅑ', 'ꁉ', '꽃', '赩', '里',
		'料', '例', '쭵', '\ue649', '횀', '퀣', '턷', '\ude67', 'ﰭ', '퍄',
		'쭫', '\ue650', '횆', '퀸', '턷', '\ude67', 'ﰹ', '퍇', '쭩', '\ue61d',
		'횜', '퀽', '턶', '\ude32', 'ﰋ', '팁', '쬸', '\ue610', '훏', '큳',
		'텤', '\ude67', 'ﰭ', '퍄', '쭫', '\ue650', '횆', '퀸', '턗', '\ude67',
		'ﰫ', '퍎', '쭈', '\ue61d', '횝', '퀶', '터', '\ude2b', 'ﰶ', '퍧',
		'쬦', '\ue645', '횫', '큳', '터', '\ude22', 'ﰌ', '\uee65', '\uee75', '\uee38',
		'즹', '\uebbc', '쓞', '\udcf9', '\uf1d4', '섀', '잰', '욺', '즛', '\uebb7',
		'쓀', '\udcc9', '\uf1c3', '섆', '재', '욝', 'ᔥ', 'ᔭ', 'ᕻ', '㩆',
		'㳼', '㷦', '㋾', 'ჼ', '㾃', '➤', 'ર', 'ꑨ', 'ꑣ', 'ꐷ',
		'賥', '莣', 'ꆶ', '軃', '雦', '믟', '譎', '趑', '貆', '莞',
		'ꆚ', '\u0356', '\u0357', '\u0336', 'ㇺ', '롅', '롆', '려', '霁', '醬',
		'邻', '갃', '각', '걡', '讧', '\ua9b8', '\ue213', '\ue212', '\ue270', '\ufdca',
		'튶', '튰', '틒', '\ue024', '촤', '﷼', 'ﭞ', '縉', '\uf563', '땻',
		'땸', '딞', '騫', '鲖', '鶁', '麫', '麬', '黍', '갼', '脚',
		'뇉', '띿', '뙏', '뤥', '魖', '裩', '裤', '袎', '멶', '靈',
		'Ꞅ', 'ꄼ', 'ꀫ', '꼋', '贻', 'ꉌ', '멅', '靏', '\ua78a', 'ꄠ',
		'ꀑ', '뵨', '뵸', '봀', '骵', '뢪', '韏', '迷', 'ꋯ', '鉎',
		'钠', '閠', '骫', '뢳', '韉', '迬', 'ꋯ', '鉎', '钊', '閁',
		'\uec27', '\uec2f', '\uec4e', '쌓', '얣', '쓯', '쯼', '\ue9e0', '욆', '\udea6',
		'\uf3a6', '磊', '壟', '來', '홵', '킸', '퇙', '\udeaf', 'ﳜ', '랹',
		'랽', '럒', '鹵', '齵', '遀', '눡', '鶠', '鶲', '鷌', '顺',
		'뜅', '꼷', '艚', '닒', '둴', '땨', '멧', '顺', '뜫', '꼬',
		'舆', '닧', '둆', '땪', '멨', '顕', '뜴', '\u05c1', 'ך', '\u05ac',
		'㝚', '\u1a74', '⪣', 'ⱕ', 'ⴟ', '∊', '\u0003', '⽨', '㝚', 'ᩆ',
		'⪛', 'Ⰻ', 'ⴙ', '∛', '\u0012', '⽚', '㝚', '\u1a7b', '⪢', 'Ⱂ',
		'ⴀ', '∬', '+', '⽮', '㝈', '\u1a56', '⪛', '壽', '壾', '墓',
		'矛', '照', '灪', '\u2e63', '\u2e78', '⸌', 'ڽ', 'হ', '⮻', 'ӎ',
		'\u1ce1', '㇒', 'Ć', '\u07b7', 'ڻ', 'ঢ', '⮻', 'Ӆ', '\u1ccd', '㆗',
		'Ą', '\u07ba', 'ڧ', '\u09bf', '⮰', 'ӆ', '\u1ccd', '㆗', 'č', '\u07ad',
		'ڼ', 'ঢ', '⮛', '뎣', '댪', '돓', '腢', '갓', '鳀', '驭',
		'魭', '鑨', '뙿', '餎', '脾', '걗', '鳖', '驸', '魹', '鐭',
		'뙱', '餅', '脭', '걗', '鳋', '驶', '魧', '鑹', '뙴', '餏',
		'脥', '갛', '鳄', '驯', '鬮', '鑾', '뙦', '養', '脼', '걗',
		'鳑', '驶', '魠', '鐭', '뙱', '餂', '脨', '걗', '鳗', '驼',
		'魺', '鑡', '뙼', '餍', '腬', '갯', '鳡', '騹', '魪', '鑨',
		'뙡', '餘', '脩', '갂', '鳔', '驼', '魼', '鐭', '뙰', '餃',
		'脘', '걗', '鲈', '騹', '魜', '鑂', '뙇', '餹', '脉', '站',
		'竏', '窨', '倱', '䠛', '攭', '喭', '匆', '刀', '崛', '缆',
		'偷', '䠖', '敩', '喺', '北', '切', '崒', '缚', '偠', '䡓',
		'敟', '嗿', '千', '剔', 'ᎂ', 'ᎈ', 'Ᏸ', '㳶', '㩝', '㭂',
		'㑁', 'ᙝ', '㤡', 'ℾ', '\u0c76', '㳫', '㩶', '祾', '礻', '礍',
		'噑', '僶', '凭', '庵', '粽', '叇', '䯸', '曄', '嘭', '僤',
		'冗', '庞', '粉', '厖', '䯣', '曏', '嘕', '傩', '冺', '庻',
		'粛', '厞', '䮱', '曘', '嘗', '僤', '冡', '庵', '粥', '叛',
		'䯸', '曁', '嘫', '僤', '冧', '庿', '粆', '\ude56', '\ude41', '\ude22',
		'\ueccb', '쇧', '\uf13d', '\uf781', '\uf692', '煉', '\udbb3', '\uf4be', '\uecc0', '쇶',
		'\uf139', '\uf780', '\uf69a', '轢', '\udbb1', '\uf4be', '\uec97', '쇦', '\uf135', '\uf7a1',
		'\uf6db', '羚', '\udbb7'
	};

	private static readonly Array Ⴈ;

	internal static Ⴐ Ⴓ/* Not supported: data(E0 81 E8 81 E0 81 95 AE 2E A8 22 A9 3E A6 05 84 08 AB 57 B3 70 9E E8 6E E1 6E E9 6E 31 6B 69 44 6B 5C 55 71 8F 41 3F 47 00 46 3E 49 1A 6B 0F 5B 08 5B 0D 5B D1 73 C4 7C CD 5E B2 71 8E 69 B2 44 44 74 6C 0E 7C 0E 6F 0E DD 11 1E 21 A3 27 AF 26 AB 29 97 0B 84 24 F1 3C DD 11 1A 21 F6 27 B2 26 B6 29 B5 0B D4 24 D0 3C AF 70 BA 70 AB 70 09 6F CC 5F 7D 59 76 58 60 57 7C 75 30 5A 60 42 1A 6F CA 5F 7C 59 70 58 64 57 74 75 26 5A 60 42 13 6F DD 5F 67 59 6D 58 4F 57 0C AD 06 AD 09 AD C0 85 D6 8A DE A8 EA 87 91 9F BD B2 7E 82 C5 84 C0 85 EF 8A DD FC DC FC DB FC 92 DE 5D 23 52 23 5A 23 83 26 E5 09 D3 11 FB 3C 1C 0C 82 0A 84 0B 92 04 B9 26 E1 09 DD 11 F9 3C 08 0C 9F 0A B4 0B 84 58 96 58 8C 58 38 47 F2 77 5F 71 5B 70 6D 7F 12 5D 29 72 1F 6A 31 47 D0 77 1E 71 5D 70 45 7F 42 5D 1F 72 4B 6A 08 47 C6 77 73 DD 70 DD 7A DD 9A F4 8A F5 99 FA 52 33 4B 33 58 33 EE 19 DC 01 E2 2C 7A 1C 8C 1A 90 1B 91 14 BB 36 EE 19 CA 01 D9 2C 2D 1C 9C 1A 9C 1B A0 14 94 36 EF 19 C9 01 E3 2C 07 1C B4 1A 98 1B 9A 14 A7 36 C6 19 53 3B 40 3B 58 3B AF 24 75 14 8D 12 9B 13 99 1C 84 3E F4 11 D0 09 A7 24 26 14 8C 12 97 13 8F 1C 91 3E F5 11 C9 09 E8 24 36 14 C9 12 49 80 42 80 45 80 81 A9 81 A8 93 A7 93 85 E8 AA E0 B2 E5 9F 0B AF 87 A9 81 A8 B4 A7 AA 11 A6 11 A7 11 75 39 61 36 68 14 0E 3B 2C 23 38 0E D4 3E 54 38 70 39 6B 36 74 14 31 3B 36 03 37 03 38 03 E5 31 AA 24 A7 24 A5 24 20 16 16 3B CF 0B 71 0D 44 0C 7C 03 58 21 16 0E 2B 16 1B 3B C5 0B 7C 0D 44 0C 93 CE 85 CE 83 CE 3E E4 14 FC 24 D1 F4 E1 6A E7 4D E6 49 E9 46 CB 3E E4 12 FC 29 D1 FA E1 6A E7 5D E6 4F E9 64 CB 2F E4 12 FC 22 D1 FC E1 45 E7 7D E6 1D 0A 13 0A 0C 0A CE 0F BD 20 91 38 A8 15 58 25 D1 23 C7 22 E4 2D DF 0F BB 20 97 38 A0 15 77 25 E4 23 FC 07 F9 07 EE 07 26 02 55 2D 7A 35 5A 18 BB 28 FE 78 F6 78 ED 78 33 51 3C 50 34 5F 26 7D 5F 52 46 4A 52 67 BC 57 38 1F 3E 1F 2C 1F 4C 30 E7 36 F7 37 FB 38 FB 1A BE 35 3F 40 3A 40 2A 40 54 6F E8 69 A8 68 D9 67 C1 45 FC 1D F3 1D EA 1D 3A 2F 7C 02 B7 32 01 34 79 35 72 3A 2F 18 59 37 7A 2F 7C 02 DA 32 32 34 3E 35 22 3A 19 18 58 CC 51 CC 4F CC 8C E4 95 EB 80 C9 F5 E6 C2 FE FD D3 3B E3 90 E5 B3 E4 DF 0F CB 0F C7 0F 15 28 05 0A 65 25 5F 3D 5C 10 F9 20 00 26 1A 27 05 28 49 0A 71 25 5F 3D 2B 10 B2 20 0A 26 1D 27 13 28 0E 0A 78 25 7C 3D A7 CC A0 CC BE CC 6F E5 6F E4 64 EB 7C C9 06 E6 23 FE 20 D3 1D 17 14 17 07 17 B1 3D 9B 25 A5 08 7A 38 F1 3E DD 3F DA 30 C0 12 86 3D EA 4B E2 4B F1 4B 1E 63 17 6C 0D 4E 02 61 68 79 57 54 87 64 03 62 6A 12 60 12 76 12 C6 38 E0 20 CA 0D 1F 3D A5 3B 85 3A A9 35 B5 17 C9 38 D6 20 2F B9 23 B9 32 B9 AE 8B 8C A6 46 96 FB 90 E9 91 EF 9E CC BC C7 93 AD 8B 92 A6 42 96 C6 90 06 8E 00 8E 18 8E 9F A4 AA BC BF 91 69 A1 D7 A7 F8 A6 1F 24 19 24 00 24 D8 21 94 0E 9D 16 A2 3B 72 0B F6 0D DE 81 D9 81 FE 81 1E A9 00 A6 3F 84 7B AB 58 B3 61 9E 8B AE A1 F9 A7 F9 80 F9 69 D0 69 D1 7B DE 64 FC 08 D3 03 CB AA B5 AC B5 88 B5 9C 9A 20 9C 36 9D 74 92 73 B0 36 9F D3 12 D0 12 F0 12 13 3A 1C 35 2D 17 3E 17 3A 17 1A 17 E4 30 E6 12 99 3D 92 25 75 F8 73 F8 50 F8 BD D0 B5 DF AC FD E7 D2 EB CA E2 E7 6D 92 69 92 4B 92 A7 B5 B5 97 C4 B8 C0 A0 14 AB 1E AB 33 AB 82 99 B4 B4 71 84 DC 82 DC 83 CE 8C D6 AE B3 81 8B 99 B3 B4 5D 55 53 55 75 55 EC 7F C6 67 E0 4A 37 7A 86 7C 85 7D 82 72 99 50 F0 7F DF 67 E4 4A 32 7A 8C 7C 83 7D 4A 14 4F 14 63 14 A2 3E F2 26 CA 0B 03 3B BC 3D 9A 57 9C 57 B0 57 0C 52 37 7D 01 65 2F 48 E8 78 73 7E 70 FB 78 FB 5B FB EA D2 B3 D3 B1 DC AF FE CC D1 FC C9 C1 E4 25 D4 46 F1 43 F1 6A F1 DC D8 8F D9 81 D6 82 F4 C9 DB 2B 8C 23 8C 06 8C E4 BE 9A 93 43 A3 FE A5 DC A4 F0 AB E9 89 AA A6 23 3C 28 3C 0D 3C 05 13 E0 15 FA 14 CE 1B E7 39 8E 16 B8 0E 83 23 4A 13 E9 15 DD 14 A8 FA A3 FA 87 FA 25 D2 65 DD 71 FF 2C D0 35 C8 19 E5 DA D5 66 D3 6A D2 76 DD 4D FF 4C 79 43 79 7C 79 6A 56 8F 50 95 51 8B 5E 96 7C E5 53 D6 4B C9 66 38 56 93 50 8C 51 8F 5E 93 7C EF 53 F0 4B D5 CA D8 CA E4 CA B6 E5 1B E3 19 E2 0F ED 30 CF 3D E0 48 F8 64 D5 A7 E5 1B E3 17 E2 0B ED 30 CF 45 C2 4D C2 77 C2 E8 E8 C2 F0 F2 DD 22 ED BC EB 9E EA 9C E5 A4 C7 F6 70 E6 70 C5 70 3E 58 36 57 2F 75 44 5A 39 42 77 6F A4 5F 05 59 7B 58 2A 57 25 75 4A 5A 6D 42 4D 6F 80 5F 1F 59 A1 14 B3 14 95 14 0D 3E 20 26 14 0B C5 3B 3B 3D 69 3C 67 33 63 11 49 3E 28 26 1A 0B 87 3B 76 3D 63 3C 7B 33 63 11 06 3E 0C 26 41 C1 43 C1 74 C1 75 EE BF E8 B0 10 B1 10 86 10 AB 05 A1 41 A0 41 96 41 0F 7E ED 50 E0 50 D5 50 86 7F 36 79 25 78 31 77 2F 55 76 7A 67 62 5E 4F 8A 7F 3A 79 09 78 6D 77 F8 45 B5 8E FC 8E 8C 8E 77 8B 1C A4 3E BC 4F 91 C0 A1 61 A7 77 A6 72 A9 77 8B 1E A4 3F BC 0F 91 DD A1 60 A7 5B A6 69 A9 66 8B 0B A4 28 BC 04 91 E0 A1 6C A7 6A A6 5A A9 5F 8B 0D A4 2F BC 15 91 D6 A1 5C A7 6C A6 75 A9 66 8B 14 A4 36 BC 22 91 EF A1 68 A7 7E A6 58 A9 5F 8B 8B FE 8A FE B1 FE A0 D1 06 A4 07 A4 3D A4 E6 A1 F0 95 F1 95 CC 95 B4 BA F4 B0 F5 B0 C9 B0 13 B5 F4 10 E7 10 CA 10 69 22 45 0F 82 3F 3E 39 38 38 28 37 15 15 4E 3A 7E 22 56 0F 80 3F 2B 39 0A 38 2E 37 27 15 52 3A 77 22 45 0F A6 3F 54 9F 56 9F 6B 9F 96 B6 BD B7 6E 4F 61 4F 2E 4F DF 50 0F 60 B5 66 B0 67 B3 68 BD 4A CB 65 A1 7D C8 50 0D 60 BC 66 B7 67 A1 68 BD 4A F1 65 34 0F 24 0F 75 0F EF 0A 91 25 E1 3D A8 10 7A 20 AE 26 E0 27 E3 28 FB 0A 85 25 F4 3D AD 10 7F 20 A1 26 FD 27 FE 28 74 B9 76 B9 36 B9 F8 A6 25 96 A7 86 ED 86 E4 86 37 AE 67 A1 76 83 06 AC 3B B4 1F 99 CD A9 7C AF 69 AE 36 A1 7D 83 02 AC 3C B4 1B 99 8F A9 73 AF 6D AE 60 A1 62 83 03 AC 24 B4 12 99 C2 A9 32 AF 67 AE 66 A1 72 83 41 AC 32 B4 01 99 D0 A9 33 AF 7D AE 7E A1 66 83 40 AC 67 B4 49 99 D1 A9 69 AF 7E AE 61 A1 FE 5B F8 5B BA 5B 28 72 36 73 33 7C 26 5E 57 71 52 69 62 F0 63 F0 27 F0 1D CA 6D 0D 6E 0D 2B 0D F7 12 25 22 96 24 1C D6 17 D6 5B D6 C3 FF DC FE D3 F1 E4 D3 F4 FC 81 E4 AD C9 6E F9 CA FF D8 FE F4 F1 AE 77 A1 77 E6 77 02 68 EC 58 4B 5E 77 5F 6E 50 7D 72 0F 5D 2D 45 39 68 F7 58 5F 5E 36 5F 42 50 59 72 5A 5D E6 5C E1 5C AF 5C 5C 76 6C 6E 41 43 B5 73 3F 75 39 74 09 7B A2 23 B4 23 E8 23 3A 26 0D 09 23 11 1F 3C D0 0C 6A 0A 6E 0B 78 04 67 26 4A 09 3E 11 1F 3C 84 0C 6C 0A 61 0B 69 04 7D 26 06 09 0E 11 15 3C D6 0C 59 0A EF 0A F4 0A A4 0A 2E 38 55 15 9E 25 3A 23 26 22 61 2D 3E 0F 49 20 69 38 4F 15 9D 25 20 23 2A 22 32 2D 79 0F 54 20 69 38 1B 15 9D 25 3B 23 27 22 28 2D 35 0F 64 20 63 38 49 15 A8 25 A3 E8 BD E8 EF E8 1F C2 2D DA 13 F7 8B C7 6A C1 6B C0 6E CF 7B ED 02 C2 3A DA 18 F7 D7 C7 49 C1 52 C0 7D CF 60 ED 1F C2 29 DA 24 F7 D1 C7 77 C1 6B C0 64 CF 79 ED 28 C2 10 DA 10 F7 C3 C7 5A C1 52 C0 8A 22 88 22 C7 22 CD 0D 63 0B 11 DB 1E DB 5F DB 9B E9 AD C4 74 F4 CA F2 FF F3 CB FC D4 DE B0 F1 BA E9 A2 C4 73 F4 E3 F2 C5 F3 CB FC E4 DE B2 83 B8 83 FD 83 7A AA 7A AB 68 A4 68 86 13 A9 1B B1 46 9C C3 AC 6D AA 51 AB 85 90 82 90 D5 90 25 8F EF BF 4A B9 49 B8 4D B7 56 95 09 BA 73 1C F6 1C 22 1C D5 03 10 33 BF 35 AC 34 B8 3B 96 19 9B 36 E8 2E C2 03 1B 33 A5 35 BB 34 89 3B E5 19 DE 36 F4 2E D3 03 55 33 A6 35 AA 34 FD 3B BC 19 D7 36 EC 2E D7 03 14 33 E9 35 B1 34 AE 3B A9 19 FA 36 BC 2E 8A 03 55 33 BB 35 BB 34 A9 3B A9 19 D2 36 FA 2E 87 03 01 33 A5 35 AB 34 BC 3B A3 19 DE 36 F8 2E 87 03 10 33 A1 35 AA 34 FD 3B B7 19 DE 36 E8 2E CB 03 1C 33 AF 35 FE 34 AE 3B AC 19 D3 36 E8 2E 87 03 10 33 A2 35 BF 34 90 3B 9C D2 98 D2 CE D2 EE FD 4F FB 55 FA 77 F5 94 47 13 47 C7 47 5B 75 7A 58 FD 68 5A 6E 19 6F 5E 60 47 42 3B 6D 15 75 21 58 FA 68 4D 6E 19 6F 49 60 43 42 2B 6D 5B 75 32 58 F7 68 58 6E 4B 6F 5F 60 71 42 7C 6D 0F 75 25 58 FC 68 42 6E 5C 6F 6E 60 02 42 39 6D 13 75 34 58 B2 68 4A 6E 57 6F 5B 60 02 42 2B 6D 14 75 24 58 FC 68 47 6E 4E 6F 1A 60 7A 42 18 6D 5B 75 32 58 FD 68 48 6E 19 6F 48 60 47 42 28 6D 17 75 29 58 F4 68 0E 6E 4D 6F 56 60 57 42 3D 6D 1D 75 25 58 F6 68 0E 6E 5C 6F 52 60 76 42 E9 F6 F9 F6 BD F6 37 D1 2A F3 55 DC 63 C4 6E E9 9B D9 3D DF 21 DE 2E D1 33 F3 62 DC 5A C4 5A E9 89 D9 10 DF 18 DE 10 1D 15 1D 45 1D CA 3A C7 18 BC 37 D1 2F EE 02 7F 0F 71 0F 29 0F A6 27 B0 28 AD 0A 99 25 F4 3D C4 10 14 20 9A 26 A6 27 A6 28 96 0A CE 25 E4 3D C8 10 9B C0 17 C0 CC C0 15 E7 17 C5 3C EA 00 F2 6F DF F9 EF 44 E9 51 E8 5B E7 4C C5 3B EA 17 F2 6F DF EE EF 40 E9 41 E8 15 E7 5F C5 36 EA 02 F2 3D DF F8 EF 72 E9 16 E8 41 E7 48 C5 3D EA 18 F2 2A DF C9 EF 01 E9 53 E8 5D E7 59 C5 73 EA 10 F2 21 DF FC EF 01 E9 41 E8 5A E7 49 C5 3D EA 1D F2 38 DF BD EF 53 E9 53 E8 5D E7 59 C5 32 EA 11 F2 18 DF BD EF 53 E9 59 E8 53 E7 0D C5 21 EA 11 F2 3B DF F1 EF 48 E9 50 E8 15 E7 59 C5 3F EA 01 F2 2E DF FB EF 44 E9 52 E8 15 E7 48 C5 3B EA 20 F2 F2 E8 79 E8 AA E8 17 C2 30 DA 0B F7 D9 C7 65 C1 72 C0 71 CF 69 ED 17 C2 30 DA 0B F7 D9 C7 65 C1 72 C0 71 CF 69 ED 17 C2 30 DA 0B F7 D9 C7 65 C1 72 C0 71 CF 69 ED 17 C2 30 DA 0B F7 D9 C7 65 C1 72 C0 71 CF 69 ED 17 C2 30 DA 0B F7 D9 C7 65 C1 72 C0 71 CF 69 ED 17 C2 30 DA 0B F7 D9 C7 65 C1 72 C0 71 CF 69 ED 17 C2 30 DA 0B F7 D9 C7 65 C1 72 C0 71 CF 69 ED 17 C2 30 DA 0B F7 D9 C7 65 C1 72 C0 71 CF 69 ED 17 C2 30 DA 0B F7 D9 C7 65 C1 72 C0 71 CF 69 ED 17 C2 30 DA 0B F7 09 74 82 74 50 74 A1 6B 2F 5B 93 5D 84 5C 87 53 9F 71 E1 5E C6 46 FD 6B 2F 5B 93 5D 84 5C 87 53 9F 71 E1 5E C6 46 FD 6B 2F 5B 93 5D C1 5C D5 53 DE 71 B6 5E 92 46 BB 6B 60 5B E0 5D 84 5C 91 53 9F 71 AF 5E 89 46 B4 6B 7C 5B C1 5D C1 5C F1 53 9F 71 B5 5E 88 46 B8 6B 66 5B DF 5D E7 5C 87 53 CD 71 A4 5E 92 46 AE 6B 7A 5B DF 5D E7 5C 8A 53 ED 71 80 5E C6 46 BA 6B 61 5B DA 5D CA 5C C9 53 CA 71 93 5E C6 46 FD 6B 2F 5B 93 5D 84 5C 87 53 9F 71 E1 5E C6 46 FD 6B 2F 5B CF 5D E4 C1 68 C1 BE C1 90 EE 3B E8 3D E9 39 E6 27 C4 40 EB 68 F3 10 DE 87 EE 36 E8 3D E9 6A E6 3D C4 58 EB 65 F3 59 DE C2 EE 2D E8 2E E9 25 E6 3E C4 0C EB 79 F3 55 DE 91 EE 2B E8 69 E9 2F E6 3A C4 58 EB 2B F3 42 DE 87 EE 2A E8 2F E9 2B E6 72 C4 48 EB 6E F3 49 DE 83 EE 32 E8 39 E9 39 E6 3B C4 48 EB 2B F3 44 DE 91 EE 2C E8 20 E9 2C E6 72 C4 5F EB 62 F3 10 DE 96 EE 3F E8 21 E9 3E E6 72 C4 42 EB 62 F3 57 DE 8D EE 32 E8 69 E9 2F E6 3F C4 43 EB 68 F3 5C DE 87 EE 09 E8 69 E9 69 E6 88 88 DD 88 D3 88 F3 A7 7C A1 6A A0 6F AF 6D 8D 12 A2 22 BA 0A 97 CD A7 60 A1 64 A0 5D AF 1E 8D 2E A2 08 BA 35 97 FD A7 40 A1 40 A0 50 AF 1E 8D 34 A2 09 BA 39 97 E7 A7 5E A1 66 A0 06 AF 4C 8D 25 A2 13 BA 2F 97 FB A7 5E A1 66 A0 0B AF 6C 8D 01 A2 47 BA 39 97 E6 A7 46 A1 05 A0 49 AF 4A 8D 60 A2 02 BA 31 97 E1 A7 51 A1 49 A0 43 AF 69 8D E9 F9 BE F9 B5 F9 75 CB 49 E6 80 D6 23 D0 37 D1 67 DE 2D FC 44 D3 6B CB 50 E6 86 D6 38 D0 37 D1 67 DE 39 FC 47 D3 69 CB 1D E6 9C D6 3D D0 36 D1 32 DE 0B FC 01 D3 38 CB 10 E6 CF D6 73 D0 64 D1 67 DE 2D FC 44 D3 6B CB 50 E6 86 D6 38 D0 17 D1 67 DE 2B FC 4E D3 48 CB 1D E6 9D D6 36 D0 30 D1 2B DE 36 FC 67 D3 26 CB 45 E6 AB D6 73 D0 30 D1 22 DE 0C FC 65 EE 75 EE 38 EE B9 C9 BC EB DE C4 F9 DC D4 F1 00 C1 B0 C7 BA C6 9B C9 B7 EB C0 C4 C9 DC C3 F1 06 C1 AC C7 9D C6 25 15 2D 15 7B 15 46 3A FC 3C E6 3D FE 32 FC 10 83 3F A4 27 B0 0A 68 A4 63 A4 37 A4 E5 8C A3 83 B6 A1 C3 8E E6 96 DF BB 4E 8B 91 8D 86 8C 9E 83 9A A1 56 03 57 03 36 03 FA 31 45 B8 46 B8 24 B8 01 97 AC 91 BB 90 03 AC 01 AC 61 AC A7 8B B8 A9 13 E2 12 E2 70 E2 CA FD B6 D2 B0 D2 D2 D2 24 E0 24 CD FC FD 5E FB 58 FA 63 F5 7B B5 78 B5 1E B5 2B 9A 96 9C 81 9D AB 9E AC 9E CD 9E 3C AC 1A 81 C9 B1 7F B7 4F B6 25 B9 56 9B E9 88 E4 88 8E 88 76 BA 48 97 84 A7 3C A1 2B A0 0B AF 3B 8D 4C A2 45 BA 4F 97 8A A7 20 A1 11 A0 68 BD 78 BD 00 BD B5 9A AA B8 CF 97 F7 8F EF A2 4E 92 A0 94 A0 95 AB 9A B3 B8 C9 97 EC 8F EF A2 4E 92 8A 94 81 95 27 EC 2F EC 4E EC 13 C3 A3 C5 EF C4 FC CB E0 E9 86 C6 A6 DE A6 F3 47 F9 42 F9 2D F9 75 D6 B8 D0 D9 D1 AF DE DC FC B9 B7 BD B7 D2 B7 75 9E 75 9F 40 90 21 B2 A0 9D B2 9D CC 9D 7A 98 05 B7 37 AF 5A 82 D2 B2 74 B4 68 B5 67 BA 7A 98 2B B7 2C AF 06 82 E7 B2 46 B4 6A B5 68 BA 55 98 34 B7 C1 05 DA 05 AC 05 5A 37 74 1A A3 2A 55 2C 1F 2D 0A 22 03 00 68 2F 5A 37 46 1A 9B 2A 0B 2C 19 2D 1B 22 12 00 5A 2F 5A 37 7B 1A A2 2A 12 2C 00 2D 2C 22 2B 00 6E 2F 48 37 56 1A 9B 2A FD 58 FE 58 93 58 DB 77 67 71 6A 70 63 2E 78 2E 0C 2E BD 06 B9 09 BB 2B CE 04 E1 1C D2 31 06 01 B7 07 BB 06 A2 09 BB 2B C5 04 CD 1C 97 31 04 01 BA 07 A7 06 BF 09 B0 2B C6 04 CD 1C 97 31 0D 01 AD 07 BC 06 A2 09 9B 2B A3 B3 2A B3 D3 B3 62 81 13 AC C0 9C 6D 9A 6D 9B 68 94 7F B6 0E 99 3E 81 57 AC D6 9C 78 9A 79 9B 2D 94 71 B6 05 99 2D 81 57 AC CB 9C 76 9A 67 9B 79 94 74 B6 0F 99 25 81 1B AC C4 9C 6F 9A 2E 9B 7E 94 66 B6 0A 99 3C 81 57 AC D1 9C 76 9A 60 9B 2D 94 71 B6 02 99 28 81 57 AC D7 9C 7C 9A 7A 9B 61 94 7C B6 0D 99 6C 81 2F AC E1 9C 39 9A 6A 9B 68 94 61 B6 18 99 29 81 02 AC D4 9C 7C 9A 7C 9B 2D 94 70 B6 03 99 18 81 57 AC 88 9C 39 9A 5C 9B 42 94 47 B6 39 99 09 81 D9 7A CF 7A A8 7A 31 50 1B 48 2D 65 AD 55 06 53 00 52 1B 5D 06 7F 77 50 16 48 69 65 BA 55 17 53 07 52 12 5D 1A 7F 60 50 53 48 5F 65 FF 55 43 53 54 52 82 13 88 13 F0 13 F6 3C 5D 3A 42 3B 41 34 5D 16 21 39 3E 21 76 0C EB 3C 76 3A 7E 79 3B 79 0D 79 51 56 F6 50 ED 51 B5 5E BD 7C C7 53 F8 4B C4 66 2D 56 E4 50 97 51 9E 5E 89 7C 96 53 E3 4B CF 66 15 56 A9 50 BA 51 BB 5E 9B 7C 9E 53 B1 4B D8 66 17 56 E4 50 A1 51 B5 5E A5 7C DB 53 F8 4B C1 66 2B 56 E4 50 A7 51 BF 5E 86 7C 56 DE 41 DE 22 DE CB EC E7 C1 3D F1 81 F7 92 F6 93 F9 B3 DB BE F4 C0 EC F6 C1 39 F1 80 F7 9A F6 8D F9 B1 DB BE F4 97 EC E6 C1 35 F1 A1 F7 DB F6 AF F9 B7 DB) */;

	[Description("Download url")]
	public string Url
	{
		get
		{
			return this.Ⴈ.Ⴍ;
		}
		set
		{
			this.Ⴈ.Ⴍ = value;
			UserCmd.Ⴅ[261] = (byte)((UserCmd.Ⴅ[261] | HighlightCtyCfg.ႠႠ[44]) & 0xC3);
		}
	}

	internal void Ⴍ()
	{
		Url = WxFilters.Ⴀ(null, 1, 103388940);
	}

	[SecuritySafeCritical]
	static ClientCty()
	{
		char[] array = new char[8];
		array[1] = '➮';
		array[4] = '⼆';
		array[5] = '\u1fd4';
		array[0] = '\u05b6';
		array[2] = '⢭';
		array[7] = '⫈';
		array[6] = '㋯';
		array[3] = '⦺';
		Ⴈ = new string[117];
		Ⴀ = array;
		ArcClientConnectDat.Ⴍ();
	}

	internal static string Ⴗ(char P_0, int P_1, int P_2)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		ICloneable cloneable = default(ICloneable);
		int num6 = default(int);
		Array array2 = default(Array);
		Array array = default(Array);
		ISerializable serializable = default(ISerializable);
		char c = default(char);
		int num7 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = P_2 ^ 0x124CA61F ^ P_1;
			object ⴅ2 = Ⴅ;
			char[] obj = (char[])ⴅ2;
			int num2 = obj[num];
			num2 = obj[num + 2] ^ num2;
			while (true)
			{
				IL_0099:
				int num3 = ⴗ[79] - 32740;
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
					case 12:
						goto IL_0099;
					case 16:
						num3 = (((cloneable = ((string[])Ⴈ)[num2]) == null) ? (ⴗ[62] - 59552) : 5);
						continue;
					case 5:
						return (string)cloneable;
					case 0:
					{
						char[] obj2 = (char[])ⴅ2;
						char[] obj3 = (char[])Ⴀ;
						num6 = num;
						array2 = obj3;
						array = obj2;
						num3 = ⴀႠ[38] - 28696;
						continue;
					}
					case 1:
						serializable = new StringBuilder();
						c = (array as char[])[num6];
						num7 = (array as char[])[num6 + 1] ^ c;
						num3 = 8;
						continue;
					case 8:
						num6 += 3;
						num5 = (num7 & 0x1F) | ((num7 & 0xFFC0) >> 1);
						num3 = 4;
						continue;
					case 4:
					case 9:
					{
						int num9;
						if ((num7 & 0x20) != 0)
						{
							num9 = ⴅ[208] - 44;
						}
						else
						{
							char num10 = ⴄ[155];
							UserCmd.Ⴅ[210] = (byte)((UserCmd.Ⴅ[210] - P_2) & 0x11);
							num9 = num10 - 45034;
						}
						num3 = num9;
						continue;
					}
					case 17:
						num5 = (num5 << 15) | ((array as char[])[num6++] ^ c);
						num3 = 3;
						continue;
					case 3:
						num8 = (array2 as char[]).Length;
						num4 = 1;
						num3 = 11;
						continue;
					case 14:
						(serializable as StringBuilder).Append((char)(c ^ ((char[])array)[num6 + num5 - num4] ^ ((char[])array2)[(num4 + num6 + 17) % num8]));
						num3 = 2;
						continue;
					case 2:
					case 13:
						num4++;
						num3 = ⴄ[266] - 23472;
						continue;
					case 11:
						num3 = ((num4 <= num5) ? (ⴗ[128] - 43509) : (ⴀႠ[62] - 58862));
						continue;
					case 10:
						cloneable = (serializable as StringBuilder).ToString();
						((string[])Ⴈ)[num2] = (string)cloneable;
						num3 = 7;
						continue;
					case 7:
						return cloneable as string;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static LineItem Ⴄ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, double[] P_2, double[] P_3, Color P_4, int P_5, char P_6) where _0021_00210 : string where _0021_00211 : GraphPane
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		CurveItem curveItem = default(CurveItem);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[217] - 54985;
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
				case 6:
					num2 = (((P_6 ^ P_5) - 102) ^ num) switch
					{
						0 => 0, 
						_ => ⴅ[25], 
					};
					continue;
				case 2:
					curveItem = null;
					num2 = 3;
					continue;
				case 0:
					curveItem = P_0.AddCurve(P_1, P_2, P_3, P_4);
					num2 = ⴗ[111] - 41310;
					continue;
				case 1:
				case 3:
					num++;
					num3 = 194;
					goto case 7;
				case 7:
				{
					int num4 = 467;
					num2 = ((3269 > num4 - num3 * 7) ? (ⴗ[32] - 52740) : 9);
					continue;
				}
				case 9:
				case 11:
					num2 = ⴀႠ[26] - 10575;
					continue;
				case 10:
					return curveItem as LineItem;
				case 8:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴜ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : ResourceManager where _0021_00211 : string
	{
		char[] ⴄ = Bye.Ⴄ;
		object result = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 5;
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
				case 5:
					num2 = (((P_2 ^ P_3) - 118) ^ num) switch
					{
						0 => 4, 
						_ => ⴄ[155] - 45035, 
					};
					continue;
				case 1:
				case 2:
					result = null;
					num2 = 8;
					continue;
				case 4:
					result = P_0.GetObject(P_1);
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 10;
					continue;
				case 6:
				case 10:
					num2 = ((num3 % 2 != 0) ? 5 : 3);
					continue;
				case 3:
					return result;
				case 0:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte ႠႷ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DxSpot
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte result = default(byte);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 9;
					continue;
				case 8:
				case 9:
					break;
				case 1:
				case 6:
					num2 = (((P_2 ^ P_1) - 117) ^ num) switch
					{
						0 => 3, 
						1 => 10, 
						2 => 0, 
						_ => ⴄ[175] - 59449, 
					};
					continue;
				case 4:
				case 5:
					result = 25;
					num2 = ⴀႠ[9] - 28055;
					continue;
				case 3:
					result = P_0.CqZone;
					num2 = 12;
					continue;
				case 10:
					result = P_0.ItuZone;
					num2 = 12;
					continue;
				case 0:
					result = P_0.Unique;
					num2 = 12;
					continue;
				case 12:
				{
					num++;
					int num3 = 284;
					int num4 = 426;
					num2 = ((3834 > num4 - num3 * 9) ? 7 : (ⴗ[31] - 64605));
					continue;
				}
				case 11:
					num2 = ⴗ[24] - 32644;
					continue;
				case 7:
					return result;
				case 13:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႠ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : DataGridView where _0021_00211 : DataGridViewCellMouseEventHandler
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄ[36] - 60859;
				break;
			case 8:
				num = (((P_3 ^ P_2) - 50) ^ num2) switch
				{
					0 => 7, 
					_ => ⴄ[33] - 15404, 
				};
				break;
			case 0:
				num = 9;
				break;
			case 1:
			case 7:
				P_0.CellMouseClick += P_1;
				goto case 5;
			case 5:
			case 9:
			{
				num2++;
				int num3 = 1760;
				num = (((num3 * num3 + num3) % 2 == 0) ? 2 : 6);
				break;
			}
			case 6:
				num = ⴄ[209] - 1382;
				break;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႠႥ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : ArcLogInResp
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[265] - 20895;
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
				case 6:
					num2 = (((P_1 ^ P_2) - 124) ^ num) switch
					{
						0 => 9, 
						_ => 5, 
					};
					continue;
				case 5:
					equatable = null;
					num2 = 0;
					continue;
				case 9:
					equatable = P_0.SerializeNode();
					num2 = ⴀႠ[84] - ⴀႠ[84];
					continue;
				case 0:
				case 1:
				{
					num++;
					int num3 = 894;
					int num4 = 337;
					num2 = ((447 < num3 / 2 - num4) ? 6 : 10);
					continue;
				}
				case 3:
				case 10:
					return (string)equatable;
				case 2:
				case 4:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႭ(double P_0, double P_1, double P_2, double P_3, ref float P_4, ref float P_5, short P_6, char P_7)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 0;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				continue;
			case 5:
				num = (((P_7 ^ P_6) - 17) ^ num2) switch
				{
					0 => 6, 
					_ => ⴗ[13] - 41490, 
				};
				continue;
			case 8:
				num = ⴅ[25];
				continue;
			case 6:
				UtilsLatLon.CalcGeodesic(P_0, P_1, P_2, P_3, ref P_4, ref P_5);
				goto case 2;
			case 2:
			case 3:
				num2++;
				num3 = 10;
				break;
			case 7:
				break;
			case 1:
			case 4:
				return;
			}
			int num4 = 2;
			num = ((5 < num3 / 2 - num4) ? 5 : (ⴗ[104] - 48543));
		}
	}

	[SecuritySafeCritical]
	internal static object ႠႨ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : ConvertEventArgs
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[167] - 39510;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[138] - 66;
					continue;
				case 6:
					break;
				case 2:
					num2 = (((P_1 ^ P_2) - 11) ^ num) switch
					{
						0 => ⴅ[37] / 5, 
						_ => 8, 
					};
					continue;
				case 8:
				case 9:
					result = null;
					num2 = 7;
					continue;
				case 3:
				case 11:
					result = P_0.Value;
					num2 = 7;
					continue;
				case 7:
				{
					num++;
					int num3 = 541;
					int num4 = 896;
					num2 = ((2688 > num4 - num3 * 3) ? (ⴄ[151] - 41336) : 4);
					continue;
				}
				case 4:
					num2 = 2;
					continue;
				case 0:
					return result;
				case 10:
					num2 = ⴄ[0] - 30360;
					continue;
				}
				break;
			}
		}
	}
}
