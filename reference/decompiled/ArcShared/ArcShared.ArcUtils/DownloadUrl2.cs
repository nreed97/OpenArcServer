using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using ArcInterfaces.Arcx;
using ArcShared.ArcCfg;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter.Extensions;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using Ⴃ;

namespace ArcShared.ArcUtils;

public sealed class DownloadUrl2
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3460)]
	private struct Ⴃ
	{
	}

	private long Ⴐ;

	private long Ⴗ;

	private static readonly Array Ⴍ;

	private static readonly object Ⴓ = new char[1730]
	{
		'않', '악', '않', '\ue296', '\uf5da', '젊', '\uf62b', '\uf632', '\ue966', '힎',
		'\uefba', '\ue296', '\uf5c2', '젔', '\uf63b', '\uf62a', '\ue97b', '히', '䜬', '䜨',
		'䜭', '眰', '䨞', '琶', '琾', '踭', '踯', '踯', '봣', 'ꉅ',
		'\uf575', '\uf577', '\uf576', '\udfe9', '튽', '펦', '펧', '펢', '\uf032', '\ud825',
		'\ud830', '\ud820', '\ueb65', '\ueb6e', '\uf433', '쫜', '\uf2f7', 'ﾥ', '\ue892', '픗',
		'\ueb73', '\ueb6e', '\uf429', '쫋', '\uf2e2', 'ﾢ', '\ue888', '핛', '\ueb21', '\ueb3d',
		'\uf411', '쫾', '\uf2df', '댘', '덞', '댞', '빾', '聝', '聒', '齔',
		'ꆣ', '馛', '铝', '莬', '빥', '聨', '联', '鼏', 'ꇃ', '駓',
		'钨', '莀', '빾', '聒', '聓', '鼎', 'ꇽ', '駄', '钯', '莀',
		'빹', '聘', '聗', '鼕', 'ꇿ', '駅', '钛', '莳', '빎', '聠',
		'聑', '鼜', 'ꇐ', '駷', '᧺', 'ᦱ', '᧽', '⫴', '㗵', 'ଞ',
		'㌻', '㹨', '⤞', 'ᓁ', '⪪', '⪵', '㗼', 'ୟ', '㍹', '㸾',
		'⤏', 'ᒘ', '⪱', '⪀', '㖰', '\u0b51', '㌬', '㹢', '⥗', 'ᒎ',
		'⫾', '⫤', '㖨', '\u0b40', '㍩', '㹾', '⥑', 'ᒼ', '⫾', '⪳',
		'㗶', 'ଘ', '㌭', '㹯', '⥑', 'ᒄ', '⪰', '⪣', '㗷', 'ଵ',
		'\uf61e', '\uf65a', '\uf616', '\uda08', '\ue4f4', '\udcc9', '퇄', '욮', 'ﭹ', '압',
		'앛', '\uda1f', '\ue4fa', '\udce1', '톚', '욓', 'ﭐ', '앎', '앞', '\uda19',
		'\ue4e1', '\udcc3', '톅', '욙', 'ﭐ', '앉', '암', '\uda1d', '\ue4fa', '\udcc1',
		'톄', '욭', 'ﭣ', '앾', '앬', '\uda1b', '\ue4f3', '\udcee', '톶', '⠶',
		'⡦', '⠿', '┄', '\u1b7f', '᭷', 'Ц', '㫛', 'ʥ', '\u0feb', '\u1886',
		'╅', '᭶', '\u1b36', 'Р', '㫈', '\u02ea', '\u0fa9', 'ᢑ', '╋', '᭞',
		'᭨', 'Н', '㪕', 'ʥ', '\u0fa7', 'ᢞ', '╍', '᭴', '\u1b38', 'Р',
		'㫈', '\u02ea', '\u0fa9', 'ᢑ', '╋', '᭞', '᭨', 'Н', '㪝', 'ˢ',
		'\u0fac', 'ᢛ', '╀', '\u1b73', '᭷', 'и', '㫓', '\u02f2', '\u0fad', 'ᢶ',
		'巔', '巇', '州', '溈', '燓', '伫', '看', '穉', '浖', '储',
		'溝', '溏', '燚', '估', '眤', '穅', '浤', '傧', '溴', '溌',
		'燑', '伛', '좘', '좙', '좓', '\uef41', '\u1c3a', '\u1c28', '\u1c36', '⼾',
		'⽻', '\u302c', 'ຑ', '㛧', '㮡', 'ⲗ', 'ᅜ', '⽽', '⽱', '〶',
		'ໟ', '㛦', '㮭', 'Ⳟ', 'ᅄ', '⽷', '⽚', '\uda82', '\uda88', '\uda8f',
		'젩', '\uf01c', 'ﵖ', '\uea1b', 'ퟣ', '\ue9c3', '\ue9d8', '\uf699', '졫', '\uf011',
		'訸', '詻', '訶', '궸', '몝', '蝎', '뤲', '륳', '\ua63e', '飜',
		'ꃆ', '궨', '몒', '蝋', '륞', '륊', '\ua62e', '飝', 'ꃮ', '궸',
		'몒', '蝅', '륟', '륊', '꘩', '飗', 'ꃪ', '궣', '몐', '蝄',
		'륫', '륹', 'ꘞ', '飯', 'ꃬ', '궪', '몿', '蝶', '귝', '궙',
		'귒', '鴹', 'ꂢ', '麖', '麁', '臙', '뽶', '蜊', '詌', '鵽',
		'ꂮ', '麖', '麟', '臑', '뼡', '蜁', '詍', '鴹', 'ꂪ', '麕',
		'麚', '臙', '뽶', '蜚', '詈', '鵽', 'ꃡ', '麉', '麐', '臌',
		'뽸', '蜜', '詌', '鵭', 'ꂼ', '麘', '麾', 'ꨥ', 'ꩫ', '\uaa35',
		'跱', '验', 'Ꝙ', '饳', '饭', '虧', '뢇', '胢', '趰', '骅',
		'ꜙ', '饤', '饯', '蘨', '룣', '胲', '趿', '骀', 'ꝵ', '餩',
		'餫', '蘢', '룂', '胿', '趷', '髁', 'Ꝓ', '饥', '饤', '蘊',
		'룊', '胸', '趰', '骣', 'ꜗ', '饦', '饥', '蘮', '룊', '胷',
		'趾', '骍', 'ꝙ', '饶', '饤', '蘃', '還', '邂', '邕', '멒',
		'뜓', 'ꀲ', '鷣', 'ꏏ', 'ꏙ', '偁', '偛', '偓', '崶', '按',
		'挍', '籂', '䊦', '窛', '矔', '想', '崲', '捅', '挜', '籊',
		'䋪', '窜', '矚', '惬', '崠', '挗', '挊', '籕', '䋪', '窅',
		'矐', '惫', '嵳', '挤', '擝', '擑', '擎', '垍', '垖', '䣑',
		'癸', '丅', '䌜', '呻', '榮', '埗', '垄', '䣈', '瘡', '賧',
		'賥', '賳', '軟', '뛣', '퍩', '퍫', '퍼', '\uf30d', '컌', '〄',
		'《', '〒', 'ភ', '®', '㵿', '\u0344', '\u034b', 'ᰉ', '⋣', '\u1ad9',
		'ជ', '\u00af', '㵒', '\u034c', '\u0348', 'ᰊ', '颟', '额', '颈', 'ꮜ',
		'ꮑ', '\u093b', '\u093c', 'ण', '㧟', 'ь', '㩻', '㨵', '┏', '\u1be7',
		'⏟', '쀊', '쀈', '쀓', '\uf304', '\uec44', '럷', '랲', '럭', '蒭',
		'鯴', 'ꔘ', '鵪', '遧', '蝜', '몈', '蒌', '蒭', '鯢', 'ꔣ',
		'鴽', '遷', '蝰', '몹', '蒧', '蒷', '鯰', 'ꔈ', '鴪', '遬',
		'蝰', '몹', '蒠', '蒽', '鯴', 'ꔓ', '鴨', '遭', '蝄', '몊',
		'蒗', '蒅', '鯲', 'ꔚ', '鴇', '遟', '啮', '啴', '啵', '翽',
		'狷', '旅', '堎', '昬', '晠', '祩', '䞉', '羴', '狼', '斊',
		'堥', '昞', '昃', '礬', '䞂', '羳', '狳', '旎', '堝', '春',
		'昬', '祢', '䞒', '羲', '狞', '\uefd3', '\uefca', '\uefcf', '\udcd7', '\udc90',
		'쏞', 'ﴪ', '씆', '젇', '\udf73', '\ue2a4', '\udc93', '\udc9c', '쏞', 'ﴴ',
		'씎', '졐', '\udf78', '\ue2a5', '\udcd7', '\udc98', '쏝', 'ﴱ', '씆', '젇',
		'\udf4e', '\ue295', '\udcb4', '蠇', '蠍', '蠚', '髵', 'ꋀ', '꾐', '뢱',
		'蕰', '뭗', '뭝', 'ꐊ', '髼', 'ꋇ', 'ꍅ', 'ꍎ', 'ꍛ', '蓟',
		'鏮', '긾', '逕', '逈', '轂', '놽', '覚', '蓃', '鏳', '긶',
		'䋧', '䋬', '䋸', '侐', '熧', '熦', '滫', '倞', '栱', '敧',
		'牗', '侚', '熳', '熺', 'ﱭ', 'ﱮ', 'ﱍ', '켤', '큼', '\uee8b',
		'\ua8c2', '\ua8c7', '\ua8e3', '鮘', '蓎', '먬', '與', '轓', '毹', '毺',
		'毛', '礁', '䄾', '䱩', '♹', '♵', '♚', 'ಸ', 'Ǩ', 'ᛋ',
		'⬙', 'ᔸ', 'ᔄ', '੯', '㒗', 'ತ', 'ǡ', 'ᛘ', '⬿', '\u13ff',
		'Ꮉ', 'Ꮫ', 'Ā', '㤭', '㑯', '⌕', 'Ẇ', '₸', '₾', '㿱',
		'Ķ', '㤸', '㑤', '⍋', 'Ế', '₣', 'ₕ', '㿁', 'Ā', '㤢',
		'㑮', '⍏', 'ẃ', '₴', 'ₒ', '㿁', 'ć', '㤨', '㑪', '⍔',
		'ẁ', '₵', '₦', '㿲', 'İ', '㤐', '㑬', '⍝', 'Ắ', '₇',
		'䮕', '䯁', '䮰', '愆', '氌', '笾', '䛵', '磗', '碛', '柞',
		'奪', '慇', '氅', '筿', '䛬', '磒', '磔', '枛', '奜', '慒',
		'氎', '笡', '䛔', '磉', '磿', '柟', '夾', '慃', '氍', '笸',
		'䛡', '碑', '磐', '枔', '奱', '慊', '氣', '笥', '䛨', '磁',
		'磨', '枏', '奚', '愆', '氆', '笿', '䛮', '磕', '磚', '枘',
		'奲', '慈', '氖', '笾', '䛃', '祜', '礙', '祺', '厛', '廉',
		'䧼', '瑠', '䨋', '䨀', '啛', '段', '厂', '廍', '䧕', '琭',
		'䨗', '䨴', '啢', '殣', '厁', '廍', '䧬', '琠', '䨗', '䨱',
		'啢', '殤', '压', '廉', '䧷', '琢', '䨖', '䨅', '啑', '殓',
		'厳', '廏', '䧾', '琍', '䨤', 'ퟟ', '힔', 'ퟸ', '\ue73b', '\udaa0',
		'\ue494', '\ue483', 'ﯛ', '앴', '﵅', '\uf05f', '\ue77a', '\udaa9', '\ue4d5', '\ue482',
		'\ufbcf', '씱', 'ﴎ', '\uf046', '\ue77e', '\uda80', '\ue498', '\ue49e', 'ﯻ', '야',
		'﵌', '\uf04e', '\ue777', '\udaa4', '\ue49d', '\ue4d1', 'ﯾ', '씛', 'ﴪ', '\uf00b',
		'\ue77c', '\udaa3', '\ue492', '\ue495', 'ﯜ', '씻', 'ﴀ', '\uf045', '\ue76c', '\udaa2',
		'\ue4bf', '䣭', '䣩', '䣅', '䗟', '箦', '箷', '撯', 'ꠠ', '\ua87c',
		'ꠉ', '鬻', '魹', '萭', '뫅', '芳', '辠', '颍', 'ꔒ', '魠',
		'魯', '萭', '뫇', '苽', '辣', '颋', 'ꕖ', '鬤', '魡', '萶',
		'몋', '苧', '辺', '颅', 'ꕅ', '鬤', '魻', '萭', '뫒', '芳',
		'辻', '颠', 'ꔒ', '鬤', '鬠', '萧', '뫇', '英', '辵', '颈',
		'ꕛ', '魥', '魸', '萣', '몋', '苠', '辽', '飄', 'ꕜ', '魫',
		'魧', '萱', '뫙', '苶', '辢', '飄', 'ꕅ', '魡', '魠', '葢',
		'뫪', '\uddc8', '\uddc9', '\udde2', '\ue7cc', '꒺', '꒾', '꒑', '茾', '鐗',
		'꧃', '韍', '珇', '珗', '珫', '忀', '愠', '外', '呒', '䍯',
		'纼', '䂂', '䂟', '忤', '慬', '夑', '呇', '䍢', '纱', '䂓',
		'䂼', '㋗', '㋂', '㋺', 'ẕ', '\u2066', '᠊', 'ᕌ', 'ɺ', '㾱',
		'ƃ', 'Ɯ', 'Ỗ', '․', 'ᠡ', 'ᔃ', 'Ⱦ', '㿥', 'Ɩ', 'Ɲ',
		'Ớ', '‒', 'ᡒ', 'ᕑ', 'ɒ', '⾤', '⾷', '⾊', 'գ', '࠵',
		'Ἆ', '⊘', 'ᳫ', 'Ჿ', 'Τ', '㵎', 'Թ', '\u0827', '\u1f17', '⋁',
		'Ჯ', 'Ქ', 'ϼ', '㵟', 'գ', 'ࠤ', 'Ἀ', '\ud85c', '\ud850', '\ud873',
		'\ufff2', '\ue8f5', '픣', '\ueb30', '\ueb3a', '\uf41e', '쪚', '\uf2a2', '￥', '\ue8b5',
		'픪', '\ueb1c', '쇊', '쇈', '쇺', '\uf2a6', '\uf2ba', 'ﰏ', 'ﰎ', 'ﰾ',
		'횻', '⍚', '⍜', '⍨', 'ㆥ', '\u0991', 'Ӌ', 'Ꮚ', '\u2e66', 'Í',
		'淁', '淅', '淲', '䝒', '䨈', '崻', '惙', '碔', '磖', '碠',
		'痲', '䯑', '䯞', '哘', '橻', '剕', '式', '䠇', '痢', '䯑',
		'䯸', '咪', '橫', '剉', '弅', '䠤', '痨', '䯟', '䯹', '咪',
		'橬', '剃', '弁', '䠿', '痪', '䯞', '䯍', '咙', '橛', '剻',
		'弇', '䠶', '病', '䯬', 'Ꜽ', 'ꝰ', '\ua709', '鐸', '鑿', '謱',
		'뗅', '跩', '胨', '韑', '\uaa5a', '鑹', '鑶', '議', '뗓', '跽',
		'肧', '鞯', 'ꩊ', '鑹', '鑐', '譶', '떗', '跪', '肤', '鞑',
		'ꩈ', '鐸', '鑶', '謬', '뗘', '跘', '肬', '鞙', 'ꩬ', '鐸',
		'鑵', '謰', '뗞', '跫', '肩', '鞗', 'ꩂ', '鑶', '鑥', '謱',
		'뗳', '礀', '祇', '礶', '䦰', '瑳', '䩀', '䨀', '唉', '毨',
		'叜', '庘', '䦆', '瑦', '䩇', '䩋', '唌', '毥', '叜', '康',
		'䦘', '瑦', '䩊', '䩋', '唖', '毥', '叜', '康', '䦘', '瑡',
		'䩀', '䩏', '唍', '毧', '叝', '広', '䦫', '瑖', '䩸', '䩉',
		'唄', '毈', '可', '\uf1e0', '\uf1b6', '\uf1d7', '혴', '셉', 'ﲝ', '슶',
		'슨', '\udda2', '\ue342', '\udb27', '홵', '셀', 'ﳜ', '슯', '슭', '\udded',
		'\ue307', '\udb11', '홠', '셇', 'ﲗ', '슪', '슠', '\udded', '\ue328', '\udb7b',
		'혴', '셁', 'ﲞ', '슭', '슨', '\udda2', '\ue300', '\udb30', '홻', '셈',
		'ﲰ', '슰', '슭', '\udde7', '\ue305', '\udb3d', '홻', '셧', 'ﳒ', '슣',
		'슠', '\uddeb', '\ue30f', '\udb32', '홻', '셈', 'ﲜ', '슳', '슡', '\uddc6',
		'ᜩ', 'ᜯ', 'ᜑ', '㷣', 'ォ', '➃', 'ᩎ', '③', '⑄', '\uf58c',
		'\uf580', '\uf5b5', '툝', '씼', '\uf8ff', '웜', '웱', '\ud99c', '\ue762', '\udf4b',
		'툌', '씧', '\uf8ee', '웻', '\uec3b', '\uec2e', '\uec01', '쮻', '\udc90', '\ue159',
		'\udf4c', '\udf6d', '쀎', 'ﻞ', '웦', '쮎', '\udca0', '\ue15d', '\udf71', '\udf70',
		'쀰', 'ﻜ', '웋', '쮐', '\udcb4', '\ue11c', '\udf5d', '\udf54', '\u139c', '\u139f',
		'Ꭷ', 'Ắ', '\u20d7', '\u20e6', '\u202e', '‼', '‒', 'స', '㋊', '૭',
		'މ', '႒', '\u2d78', 'ፕ', '፴', 'ఢ', '㋀', '\u0af4', '\u07b6', 'Ⴉ',
		'ⵣ', 'ፁ', 'ጵ', 'ఎ', '㋤', '嶪', '嶡', '嶗', '睫', '稻',
		'洚', '僔', '滧', '滂', '燨', '佄', '睯', '稿', '洽', '⨥',
		'⨧', '⨛', '❶', '\u192e', '渗', '渕', '渨', '䈿', '粳', '蓯',
		'蒼', '蒯', '깼', 'ꍶ', '둄', '規', '랭', '럡', '\ua8e9', '阁',
		'길', 'ꍺ', '둄', '覑', '랥', '랶', '\ua8e2', '阀', '깼', 'ꌲ',
		'둟', '覜', '랯', '럯', '\ua8ef', '阑', '긌', 'ꍶ', '둄', '覒',
		'랙', '략', '\ua8ec', '阌', '긟', 'ꌳ', '됋', '覘', '랧', '램',
		'\ua8eb', '附', '긾', 'ꍮ', '둻', '覐', '랤', '랮', '\ua8df', '阐',
		'긽', 'ꍳ', '둨', '\u1aee', '\u1afe', '\u1aaf', '⧠', '㚶', '\u0817', '〸',
		'㵮', '⩆', 'ផ', '⦬', '⧠', '㛨', 'ࠌ', '〱', '㵻', '⩜',
		'ធ', '⦃', '착', '쵷', '챫', 'Ｍ', 'ｰ', '\ue02e', '\udecb', '\ue6cc',
		'\uebbc', 'ﲙ', '셚', 'ｉ', 'Ｇ', '\ue02a', '\ude82', '\ue6e8', '\uebb2', 'ﳍ',
		'셞', '｡', '･', '\ue02a', '\udef6', '\ue6fb', '\ueba9', 'ﲌ', '셿', 'Ｍ',
		'ｦ', '\ue06b', '\ude8e', '\ue6ee', '\uebb8', 'ﲾ', '셚', 'ｹ', 'ｦ', '\ue00f',
		'\ude82', '\ue6fb', '\uebfd', 'ﲂ', '셏', 'Ｍ', '｣', '\ue025', '\uded7', '\ue6f5',
		'\uebbf', 'ﳍ', '셈', '､', 'Ｇ', '\ue023', '\udec1', '\ue6f3', '\uebb5', 'ﲚ',
		'섛', 'ｨ', '､', '\ue039', '\uded7', '\ue6f5', '\ueb8e', 'ﲊ', '셕', '､',
		'｣', '\ue025', '\udecb', '\ue6d8', '\uebfd', 'ﲌ', '섛', 'ｿ', 'ｨ', '\ue06b',
		'\uded5', '\ue6ff', '\uebb4', 'ﲻ', '셚', 'ｹ', 'ｦ', '\ue00f', '\ude82', '\ue6fb',
		'\uebfd', 'ﳁ', '셞', '｡', '･', '\ue02a', '\udef6', '\ue6fb', '\ueba9', 'ﲌ',
		'셿', 'Ｍ', 'ｦ', '\ue06b', '\ude8e', '\ue6ee', '\uebb8', 'ﲾ', '셚', 'ｹ',
		'ｦ', '\ue00f', '\ude82', '\ue6fb', '\uebfd', 'ﲈ', '셙', 'Ｍ', 'ｳ', '\ue038',
		'\uded7', '\ue6f7', '\uebfd', 'ﲈ', '션', 'ｿ', 'ｲ', '\ue024', '\udef1', '\ue6fb',
		'\ueba9', 'ﲌ', '셿', 'Ｍ', '｢', '\ue023', '\udef6', '\ue6ba', '\uebf3', 'ﲚ',
		'셞', '､', 'ｑ', '\ue02f', '\udecb', '\ue6e8', '\ueb9a', 'ﲌ', '셏', 'ｬ',
		'ｃ', '\ue06b', '\udec6', '\ue6f4', '\ueba8', 'ﲂ', '셙', 'Ｍ', 'ｯ', '\ue03f',
		'\udecb', '\ue6ed', '\uebfd', 'ﲆ', '셉', '｢', 'ｰ', '\ue06b', '\udedb', '\ue6f6',
		'\uebb3', 'ﲂ', '섛', '｣', 'ｦ', '\ue028', '\ude82', '\ue6e8', '\uebb8', 'ﲙ',
		'셗', '､', 'ａ', '\ue03c', '\udec7', '\ue6f3', '\ueb8b', 'ﲉ', '셒', 'ｿ',
		'\uff40', '\ue02a', '\uded6', '\ue6fb', '\ueb99', '獶', '獠', '猵', '縊', '䀿',
		'䀭', '彸', '憒', '妆', '哩', '䏜', '縍', '䀞', '䀯', '影',
		'憔', '妓', '哦', '䏛', '縖', '䀕', '䀹', '彠', '憜', '妁',
		'溊', '滎', '滎', '巚', '巅', '䊌', '簯', '䑒', '䤝', '帡',
		'援', '巬', '巈', '䊄', '籠', '䑺', '䤢', '帺', '揶', '巋',
		'巐', '䊆', '籮', '䑺', '䤢', '帽', '揼', '巏', '巋', '䊄',
		'籯', '䑎', '䤑', '帊', '揄', '巉', '巂', '䊫', '籝', '掿',
		'揯', '揺', '䑫', '化', '滂', '僩', '僷', '俽', '焝', '䥸',
		'䐪', '匟', '溃', '僰', '僲', '侲', '煘', '䥎', '䐧', '北',
		'滌', '僘', '傹', '俽', '煑', '䥠', '䐢', '匝', '溍', '僰',
		'僲', '侲', '煘', '䥎', '䐧', '北', '滌', '僘', '傱', '侺',
		'煚', '䥥', '䐯', '匚', '滂', '僷', '僿', '侪', '煛', '䥈'
	};

	private static readonly Array Ⴈ;

	internal static Ⴃ Ⴀ/* Not supported: data(4A C5 45 C5 4A C5 96 E2 DA F5 0A C8 2B F6 32 F6 66 E9 8E D7 BA EF 96 E2 C2 F5 14 C8 3B F6 2A F6 7B E9 88 D7 2C 47 28 47 2D 47 30 77 1E 4A 36 74 3E 74 2D 8E 2F 8E 2F 8E 23 BD 45 A2 75 F5 77 F5 76 F5 E9 DF BD D2 A6 D3 A7 D3 A2 D3 32 F0 25 D8 30 D8 20 D8 65 EB 6E EB 33 F4 DC CA F7 F2 A5 FF 92 E8 17 D5 73 EB 6E EB 29 F4 CB CA E2 F2 A2 FF 88 E8 5B D5 21 EB 3D EB 11 F4 FE CA DF F2 18 B3 5E B3 1E B3 7E BE 5D 80 52 80 54 9F A3 A1 9B 99 DD 94 AC 83 65 BE 68 80 54 80 0F 9F C3 A1 D3 99 A8 94 80 83 7E BE 52 80 53 80 0E 9F FD A1 C4 99 AF 94 80 83 79 BE 58 80 57 80 15 9F FF A1 C5 99 9B 94 B3 83 4E BE 60 80 51 80 1C 9F D0 A1 F7 99 FA 19 B1 19 FD 19 F4 2A F5 35 1E 0B 3B 33 68 3E 1E 29 C1 14 AA 2A B5 2A FC 35 5F 0B 79 33 3E 3E 0F 29 98 14 B1 2A 80 2A B0 35 51 0B 2C 33 62 3E 57 29 8E 14 FE 2A E4 2A A8 35 40 0B 69 33 7E 3E 51 29 BC 14 FE 2A B3 2A F6 35 18 0B 2D 33 6F 3E 51 29 84 14 B0 2A A3 2A F7 35 35 0B 1E F6 5A F6 16 F6 08 DA F4 E4 C9 DC C4 D1 AE C6 79 FB 55 C5 5B C5 1F DA FA E4 E1 DC 9A D1 93 C6 50 FB 4E C5 5E C5 19 DA E1 E4 C3 DC 85 D1 99 C6 50 FB 49 C5 54 C5 1D DA FA E4 C1 DC 84 D1 AD C6 63 FB 7E C5 6C C5 1B DA F3 E4 EE DC B6 D1 36 28 66 28 3F 28 04 25 7F 1B 77 1B 26 04 DB 3A A5 02 EB 0F 86 18 45 25 76 1B 36 1B 20 04 C8 3A EA 02 A9 0F 91 18 4B 25 5E 1B 68 1B 1D 04 95 3A A5 02 A7 0F 9E 18 4D 25 74 1B 38 1B 20 04 C8 3A EA 02 A9 0F 91 18 4B 25 5E 1B 68 1B 1D 04 9D 3A E2 02 AC 0F 9B 18 40 25 73 1B 77 1B 38 04 D3 3A F2 02 AD 0F B6 18 D4 5D C7 5D DE 5D 88 6E D3 71 2B 4F 0B 77 49 7A 56 6D A8 50 9D 6E 8F 6E DA 71 30 4F 24 77 45 7A 64 6D A7 50 B4 6E 8C 6E D1 71 1B 4F 98 C8 99 C8 93 C8 41 EF 3A 1C 28 1C 36 1C 3E 2F 7B 2F 2C 30 91 0E E7 36 A1 3B 97 2C 5C 11 7D 2F 71 2F 36 30 DF 0E E6 36 AD 3B DE 2C 44 11 77 2F 5A 2F 82 DA 88 DA 8F DA 29 C8 1C F0 56 FD 1B EA E3 D7 C3 E9 D8 E9 99 F6 6B C8 11 F0 38 8A 7B 8A 36 8A B8 AD 9D BA 4E 87 32 B9 73 B9 3E A6 DC 98 C6 A0 A8 AD 92 BA 4B 87 5E B9 4A B9 2E A6 DD 98 EE A0 B8 AD 92 BA 45 87 5F B9 4A B9 29 A6 D7 98 EA A0 A3 AD 90 BA 44 87 6B B9 79 B9 1E A6 EF 98 EC A0 AA AD BF BA 76 87 DD AD 99 AD D2 AD 39 9D A2 A0 96 9E 81 9E D9 81 76 BF 0A 87 4C 8A 7D 9D AE A0 96 9E 9F 9E D1 81 21 BF 01 87 4D 8A 39 9D AA A0 95 9E 9A 9E D9 81 76 BF 1A 87 48 8A 7D 9D E1 A0 89 9E 90 9E CC 81 78 BF 1C 87 4C 8A 6D 9D BC A0 98 9E BE 9E 25 AA 6B AA 35 AA F1 8D 8C 9A 58 A7 73 99 6D 99 67 86 87 B8 E2 80 B0 8D 85 9A 19 A7 64 99 6F 99 28 86 E3 B8 F2 80 BF 8D 80 9A 75 A7 29 99 2B 99 22 86 C2 B8 FF 80 B7 8D C1 9A 52 A7 65 99 64 99 0A 86 CA B8 F8 80 B0 8D A3 9A 17 A7 66 99 65 99 2E 86 CA B8 F7 80 BE 8D 8D 9A 59 A7 76 99 64 99 03 86 84 90 82 90 95 90 52 BA 13 B7 32 A0 E3 9D CF A3 D9 A3 41 50 5B 50 53 50 36 5D 09 63 0D 63 42 7C A6 42 9B 7A D4 77 F3 60 32 5D 45 63 1C 63 4A 7C EA 42 9C 7A DA 77 EC 60 20 5D 17 63 0A 63 55 7C EA 42 85 7A D0 77 EB 60 73 5D 24 63 DD 64 D1 64 CE 64 8D 57 96 57 D1 48 78 76 05 4E 1C 43 7B 54 AE 69 D7 57 84 57 C8 48 21 76 E7 8C E5 8C F3 8C DF 8E E3 B6 69 D3 6B D3 7C D3 0D F3 CC CE 04 30 0A 30 12 30 97 17 AE 00 7F 3D 44 03 4B 03 09 1C E3 22 D9 1A 87 17 AF 00 52 3D 4C 03 48 03 0A 1C 9F 98 9D 98 88 98 9C AB 91 AB 3B 09 3C 09 23 09 DF 39 4C 04 7B 3A 35 3A 0F 25 E7 1B DF 23 0A C0 08 C0 13 C0 04 F3 44 EC F7 B7 B2 B7 ED B7 AD 84 F4 9B 18 A5 6A 9D 67 90 5C 87 88 BA 8C 84 AD 84 E2 9B 23 A5 3D 9D 77 90 70 87 B9 BA A7 84 B7 84 F0 9B 08 A5 2A 9D 6C 90 70 87 B9 BA A0 84 BD 84 F4 9B 13 A5 28 9D 6D 90 44 87 8A BA 97 84 85 84 F2 9B 1A A5 07 9D 5F 90 6E 55 74 55 75 55 FD 7F F7 72 C5 65 0E 58 2C 66 60 66 69 79 89 47 B4 7F FC 72 8A 65 25 58 1E 66 03 66 2C 79 82 47 B3 7F F3 72 CE 65 1D 58 25 66 2C 66 62 79 92 47 B2 7F DE 72 D3 EF CA EF CF EF D7 DC 90 DC DE C3 2A FD 06 C5 07 C8 73 DF A4 E2 93 DC 9C DC DE C3 34 FD 0E C5 50 C8 78 DF A5 E2 D7 DC 98 DC DD C3 31 FD 06 C5 07 C8 4E DF 95 E2 B4 DC 07 88 0D 88 1A 88 F5 9A C0 A2 90 AF B1 B8 70 85 57 BB 5D BB 0A A4 FC 9A C7 A2 45 A3 4E A3 5B A3 DF 84 EE 93 3E AE 15 90 08 90 42 8F BD B1 9A 89 C3 84 F3 93 36 AE E7 42 EC 42 F8 42 90 4F A7 71 A6 71 EB 6E 1E 50 31 68 67 65 57 72 9A 4F B3 71 BA 71 6D FC 6E FC 4D FC 24 CF 7C D0 8B EE C2 A8 C7 A8 E3 A8 98 9B CE 84 2C BA 07 82 53 8F F9 6B FA 6B DB 6B 01 79 3E 41 69 4C 79 26 75 26 5A 26 B8 0C E8 01 CB 16 19 2B 38 15 04 15 6F 0A 97 34 A4 0C E1 01 D8 16 3F 2B FF 13 B9 13 DB 13 00 01 2D 39 6F 34 15 23 86 1E B8 20 BE 20 F1 3F 36 01 38 39 64 34 4B 23 BE 1E A3 20 95 20 C1 3F 00 01 22 39 6E 34 4F 23 83 1E B4 20 92 20 C1 3F 07 01 28 39 6A 34 54 23 81 1E B5 20 A6 20 F2 3F 30 01 10 39 6C 34 5D 23 AE 1E 87 20 95 4B C1 4B B0 4B 06 61 0C 6C 3E 7B F5 46 D7 78 9B 78 DE 67 6A 59 47 61 05 6C 7F 7B EC 46 D2 78 D4 78 9B 67 5C 59 52 61 0E 6C 21 7B D4 46 C9 78 FF 78 DF 67 3E 59 43 61 0D 6C 38 7B E1 46 91 78 D0 78 94 67 71 59 4A 61 23 6C 25 7B E8 46 C1 78 E8 78 8F 67 5A 59 06 61 06 6C 3F 7B EE 46 D5 78 DA 78 98 67 72 59 48 61 16 6C 3E 7B C3 46 5C 79 19 79 7A 79 9B 53 C9 5E FC 49 60 74 0B 4A 00 4A 5B 55 B5 6B 82 53 CD 5E D5 49 2D 74 17 4A 34 4A 62 55 A3 6B 81 53 CD 5E EC 49 20 74 17 4A 31 4A 62 55 A4 6B 8B 53 C9 5E F7 49 22 74 16 4A 05 4A 51 55 93 6B B3 53 CF 5E FE 49 0D 74 24 4A DF D7 94 D7 F8 D7 3B E7 A0 DA 94 E4 83 E4 DB FB 74 C5 45 FD 5F F0 7A E7 A9 DA D5 E4 82 E4 CF FB 31 C5 0E FD 46 F0 7E E7 80 DA 98 E4 9E E4 FB FB 7C C5 4C FD 4E F0 77 E7 A4 DA 9D E4 D1 E4 FE FB 1B C5 2A FD 0B F0 7C E7 A3 DA 92 E4 95 E4 DC FB 3B C5 00 FD 45 F0 6C E7 A2 DA BF E4 ED 48 E9 48 C5 48 DF 45 A6 7B B7 7B AF 64 20 A8 7C A8 09 A8 3B 9B 79 9B 2D 84 C5 BA B3 82 A0 8F 8D 98 12 A5 60 9B 6F 9B 2D 84 C7 BA FD 82 A3 8F 8B 98 56 A5 24 9B 61 9B 36 84 8B BA E7 82 BA 8F 85 98 45 A5 24 9B 7B 9B 2D 84 D2 BA B3 82 BB 8F A0 98 12 A5 24 9B 20 9B 27 84 C7 BA F1 82 B5 8F 88 98 5B A5 65 9B 78 9B 23 84 8B BA E0 82 BD 8F C4 98 5C A5 6B 9B 67 9B 31 84 D9 BA F6 82 A2 8F C4 98 45 A5 61 9B 60 9B 62 84 EA BA C8 DD C9 DD E2 DD CC E7 BA A4 BE A4 91 A4 3E 83 17 94 C3 A9 CD 97 C7 73 D7 73 EB 73 C0 5F 20 61 16 59 52 54 6F 43 BC 7E 82 40 9F 40 E4 5F 6C 61 11 59 47 54 62 43 B1 7E 93 40 BC 40 D7 32 C2 32 FA 32 95 1E 66 20 0A 18 4C 15 7A 02 B1 3F 83 01 9C 01 D6 1E 24 20 21 18 03 15 3E 02 E5 3F 96 01 9D 01 DA 1E 12 20 52 18 51 15 52 02 A4 2F B7 2F 8A 2F 63 05 35 08 0E 1F 98 22 EB 1C BF 1C A4 03 4E 3D 39 05 27 08 17 1F C1 22 AF 1C A5 1C FC 03 5F 3D 63 05 24 08 08 1F 5C D8 50 D8 73 D8 F2 FF F5 E8 23 D5 30 EB 3A EB 1E F4 9A CA A2 F2 E5 FF B5 E8 2A D5 1C EB CA C1 C8 C1 FA C1 A6 F2 BA F2 0F FC 0E FC 3E FC BB D6 5A 23 5C 23 68 23 A5 31 91 09 CB 04 CA 13 66 2E CD 00 C1 6D C5 6D F2 6D 52 47 08 4A 3B 5D D9 60 94 78 D6 78 A0 78 F2 75 D1 4B DE 4B D8 54 7B 6A 55 52 0F 5F 07 48 E2 75 D1 4B F8 4B AA 54 6B 6A 49 52 05 5F 24 48 E8 75 DF 4B F9 4B AA 54 6C 6A 43 52 01 5F 3F 48 EA 75 DE 4B CD 4B 99 54 5B 6A 7B 52 07 5F 36 48 C5 75 EC 4B 3C A7 70 A7 09 A7 38 94 7F 94 31 8B C5 B5 E9 8D E8 80 D1 97 5A AA 79 94 76 94 70 8B D3 B5 FD 8D A7 80 AF 97 4A AA 79 94 50 94 76 8B 97 B5 EA 8D A4 80 91 97 48 AA 38 94 76 94 2C 8B D8 B5 D8 8D AC 80 99 97 6C AA 38 94 75 94 30 8B DE B5 EB 8D A9 80 97 97 42 AA 76 94 65 94 31 8B F3 B5 00 79 47 79 36 79 B0 49 73 74 40 4A 00 4A 09 55 E8 6B DC 53 98 5E 86 49 66 74 47 4A 4B 4A 0C 55 E5 6B DC 53 B7 5E 98 49 66 74 4A 4A 4B 4A 16 55 E5 6B DC 53 B7 5E 98 49 61 74 40 4A 4F 4A 0D 55 E7 6B DD 53 83 5E AB 49 56 74 78 4A 49 4A 04 55 C8 6B EF 53 E0 F1 B6 F1 D7 F1 34 D6 49 C1 9D FC B6 C2 A8 C2 A2 DD 42 E3 27 DB 75 D6 40 C1 DC FC AF C2 AD C2 ED DD 07 E3 11 DB 60 D6 47 C1 97 FC AA C2 A0 C2 ED DD 28 E3 7B DB 34 D6 41 C1 9E FC AD C2 A8 C2 A2 DD 00 E3 30 DB 7B D6 48 C1 B0 FC B0 C2 AD C2 E7 DD 05 E3 3D DB 7B D6 67 C1 D2 FC A3 C2 A0 C2 EB DD 0F E3 32 DB 7B D6 48 C1 9C FC B3 C2 A1 C2 C6 DD 29 17 2F 17 11 17 E3 3D A9 30 83 27 4E 1A 62 24 44 24 8C F5 80 F5 B5 F5 1D D2 3C C5 FF F8 DC C6 F1 C6 9C D9 62 E7 4B DF 0C D2 27 C5 EE F8 FB C6 3B EC 2E EC 01 EC BB CB 90 DC 59 E1 4C DF 6D DF 0E C0 DE FE E6 C6 8E CB A0 DC 5D E1 71 DF 70 DF 30 C0 DC FE CB C6 90 CB B4 DC 1C E1 5D DF 54 DF 9C 13 9F 13 A7 13 AE 1E D7 20 E6 20 2E 20 3C 20 12 20 38 0C CA 32 ED 0A 89 07 92 10 78 2D 55 13 74 13 22 0C C0 32 F4 0A B6 07 A9 10 63 2D 41 13 35 13 0E 0C E4 32 AA 5D A1 5D 97 5D 6B 77 3B 7A 1A 6D D4 50 E7 6E C2 6E E8 71 44 4F 6F 77 3F 7A 3D 6D 25 2A 27 2A 1B 2A 76 27 2E 19 17 6E 15 6E 28 6E 3F 42 B3 7C EF 84 BC 84 AF 84 7C AE 76 A3 44 B4 8F 89 AD B7 E1 B7 E9 A8 01 96 38 AE 7A A3 44 B4 91 89 A5 B7 B6 B7 E2 A8 00 96 7C AE 32 A3 5F B4 9C 89 AF B7 EF B7 EF A8 11 96 0C AE 76 A3 44 B4 92 89 99 B7 B5 B7 EC A8 0C 96 1F AE 33 A3 0B B4 98 89 A7 B7 A8 B7 EB A8 44 96 3E AE 6E A3 7B B4 90 89 A4 B7 AE B7 DF A8 10 96 3D AE 73 A3 68 B4 EE 1A FE 1A AF 1A E0 29 B6 36 17 08 38 30 6E 3D 46 2A 95 17 AC 29 E0 29 E8 36 0C 08 31 30 7B 3D 5C 2A 92 17 83 29 29 CC 77 CD 6B CC 2D FF 70 FF 2E E0 CB DE CC E6 BC EB 99 FC 5A C1 49 FF 27 FF 2A E0 82 DE E8 E6 B2 EB CD FC 5E C1 61 FF 65 FF 2A E0 F6 DE FB E6 A9 EB 8C FC 7F C1 2D FF 66 FF 6B E0 8E DE EE E6 B8 EB BE FC 5A C1 79 FF 66 FF 0F E0 82 DE FB E6 FD EB 82 FC 4F C1 2D FF 63 FF 25 E0 D7 DE F5 E6 BF EB CD FC 48 C1 64 FF 27 FF 23 E0 C1 DE F3 E6 B5 EB 9A FC 1B C1 68 FF 64 FF 39 E0 D7 DE F5 E6 8E EB 8A FC 55 C1 64 FF 63 FF 25 E0 CB DE D8 E6 FD EB 8C FC 1B C1 7F FF 68 FF 6B E0 D5 DE FF E6 B4 EB BB FC 5A C1 79 FF 66 FF 0F E0 82 DE FB E6 FD EB C1 FC 5E C1 61 FF 65 FF 2A E0 F6 DE FB E6 A9 EB 8C FC 7F C1 2D FF 66 FF 6B E0 8E DE EE E6 B8 EB BE FC 5A C1 79 FF 66 FF 0F E0 82 DE FB E6 FD EB 88 FC 59 C1 2D FF 73 FF 38 E0 D7 DE F7 E6 FD EB 88 FC 58 C1 7F FF 72 FF 24 E0 F1 DE FB E6 A9 EB 8C FC 7F C1 2D FF 62 FF 23 E0 F6 DE BA E6 F3 EB 9A FC 5E C1 64 FF 51 FF 2F E0 CB DE E8 E6 9A EB 8C FC 4F C1 6C FF 43 FF 6B E0 C6 DE F4 E6 A8 EB 82 FC 59 C1 2D FF 6F FF 3F E0 CB DE ED E6 FD EB 86 FC 49 C1 62 FF 70 FF 6B E0 DB DE F6 E6 B3 EB 82 FC 1B C1 63 FF 66 FF 28 E0 82 DE E8 E6 B8 EB 99 FC 57 C1 64 FF 41 FF 3C E0 C7 DE F3 E6 8B EB 89 FC 52 C1 7F FF 40 FF 2A E0 D6 DE FB E6 99 EB 76 73 60 73 35 73 0A 7E 3F 40 2D 40 78 5F 92 61 86 59 E9 54 DC 43 0D 7E 1E 40 2F 40 71 5F 94 61 93 59 E6 54 DB 43 16 7E 15 40 39 40 60 5F 9C 61 81 59 8A 6E CE 6E CE 6E DA 5D C5 5D 8C 42 2F 7C 52 44 1D 49 21 5E F4 63 EC 5D C8 5D 84 42 60 7C 7A 44 22 49 3A 5E F6 63 CB 5D D0 5D 86 42 6E 7C 7A 44 22 49 3D 5E FC 63 CF 5D CB 5D 84 42 6F 7C 4E 44 11 49 0A 5E C4 63 C9 5D C2 5D AB 42 5D 7C BF 63 EF 63 FA 63 6B 44 16 53 C2 6E E9 50 F7 50 FD 4F 1D 71 78 49 2A 44 1F 53 83 6E F0 50 F2 50 B2 4F 58 71 4E 49 27 44 17 53 CC 6E D8 50 B9 50 FD 4F 51 71 60 49 22 44 1D 53 8D 6E F0 50 F2 50 B2 4F 58 71 4E 49 27 44 17 53 CC 6E D8 50 B1 50 BA 4F 5A 71 65 49 2F 44 1A 53 C2 6E F7 50 FF 50 AA 4F 5B 71 48 49) */;

	public long Length
	{
		get
		{
			return Ⴐ;
		}
		private set
		{
			Ⴐ = ⴐ;
		}
	}

	public long Progress
	{
		get
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			return Ⴗ;
		}
		private set
		{
			Ⴗ = ⴗ;
		}
	}

	public XmlDocument DownloadToXmlDoc(string url, string proxyURL)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		MarshalByRefObject responseStream = default(MarshalByRefObject);
		while (true)
		{
			XmlNode xmlNode = new XmlDocument();
			WebRequest webRequest = (HttpWebRequest)ArcLogInRespExt.Ⴀ(url, 673, 661);
			while (true)
			{
				IL_0057:
				int num = UtilsCallsign.Ⴓ(proxyURL, 189, 138);
				WxCfg.ႣႭ[53] = (char)((WxCfg.ႣႭ[53] ^ WxCfg.ႣႭ[154]) & 0x3C);
				int num2 = ((num <= 0) ? (ⴃႤ[334] - 39271) : 4);
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = 2;
						continue;
					case 2:
						break;
					case 3:
						goto IL_0057;
					case 4:
					case 7:
						AnnWxSpotExt.Ⴄ((WebRequest)(webRequest as HttpWebRequest), (IWebProxy)new WebProxy(proxyURL, BypassOnLocal: true), (short)505, 456);
						goto case 0;
					case 0:
					{
						ISerializable serializable = (HttpWebResponse)UtilsCopyright.Ⴅ((WebRequest)(webRequest as HttpWebRequest), 'ʮ', 690);
						responseStream = (serializable as HttpWebResponse).GetResponseStream();
						num2 = 6;
						continue;
					}
					case 1:
					case 6:
						((XmlDocument)xmlNode).Load(responseStream as Stream);
						return xmlNode as XmlDocument;
					}
					break;
				}
				break;
			}
		}
	}

	public void DownloadToFile(string url, string filePath, string sProxy)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 3;
		ISerializable serializable = default(ISerializable);
		object obj = default(object);
		WebResponse webResponse = default(WebResponse);
		IDisposable disposable = default(IDisposable);
		Array array = default(Array);
		Stream stream = default(Stream);
		while (true)
		{
			switch (num)
			{
			default:
				serializable = ArcLogInRespExt.Ⴀ(url, 195, 247);
				num = ((UtilsCallsign.Ⴓ(sProxy, 988, 1003) <= 0) ? 5 : 7);
				break;
			case 7:
				obj = new WebProxy(sProxy, BypassOnLocal: true);
				goto case 6;
			case 6:
				UtilsIdentity.Ⴓ((WebProxy)obj, UtilsEmail.Ⴅ('\u0093', 229), 686, 674);
				num = ⴀ[19] - 12897;
				break;
			case 0:
			case 9:
			{
				IWebProxy webProxy = (WebProxy)obj;
				AnnWxSpotExt.Ⴄ((WebRequest)serializable, (IWebProxy)(webProxy as WebProxy), (short)45, 28);
				goto case 5;
			}
			case 5:
				webResponse = (HttpWebResponse)UtilsCopyright.Ⴅ((WebRequest)serializable, '\u0004', 24);
				Length = ႰႣ.Ⴜ((WebResponse)(HttpWebResponse)webResponse, 890, (short)859);
				num = ⴗ[94] - 22931;
				break;
			case 8:
				disposable = UtilsXml.Ⴈ((WebResponse)(webResponse as HttpWebResponse), 444, 'Ƃ');
				array = Ⴄ(disposable as Stream, 32768);
				num = 2;
				break;
			case 2:
			case 4:
				stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
				(stream as FileStream).Write((byte[])array, 0, ((byte[])array).Length - 1);
				num = 1;
				break;
			case 1:
				((FileStream)stream).Close();
				((HttpWebResponse)webResponse).Close();
				(disposable as Stream).Close();
				return;
			}
		}
	}

	private byte[] Ⴄ(Stream P_0, int P_1)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = default(object);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		object obj2 = default(object);
		while (true)
		{
			int num = ((P_1 < 1) ? (ⴃႣ[36] - 35703) : 0);
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
				case 9:
					P_1 = 32768;
					num = ⴐ[383] - 8351;
					continue;
				case 0:
					obj = new byte[P_1];
					num2 = 0;
					num = 3;
					continue;
				case 2:
					num2 += num3;
					Progress = num2;
					num = ((num2 != (obj as byte[]).Length) ? (ⴗ[55] - 6825) : 4);
					continue;
				case 4:
					num4 = CtyInfo.Ⴓ(P_0, 145, '\u009a');
					goto case 6;
				case 6:
					num = ((num4 != -1) ? 12 : (ⴐ[129] - 20617));
					continue;
				case 13:
					return obj as byte[];
				case 12:
					obj2 = new byte[((byte[])obj).Length * 2];
					DgvFreqRangeColumnFilter.Ⴍ((Array)(obj as byte[]), (Array)(byte[])obj2, (obj as byte[]).Length, 643, 745);
					num = 11;
					continue;
				case 11:
					(obj2 as byte[])[num2] = (byte)num4;
					obj = (byte[])obj2;
					goto case 10;
				case 10:
					num2++;
					num = 3;
					continue;
				case 3:
					num = (((num3 = DxSpotExt.Ⴈ(P_0, obj as byte[], num2, ((byte[])obj).Length - num2, 281, 302)) > 0) ? 2 : (ⴃႭ[232] - 45206));
					continue;
				case 1:
				{
					Array array = new byte[num2];
					Array.Copy(obj as byte[], (byte[])array, num2);
					return array as byte[];
				}
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static DownloadUrl2()
	{
		char[] array = new char[8];
		array[1] = 'ഒ';
		array[7] = '㌮';
		array[0] = '㌤';
		array[3] = '⟴';
		array[5] = 'ኋ';
		array[6] = 'Ɫ';
		array[4] = '⪳';
		array[2] = 'ツ';
		Ⴈ = new string[70];
		Ⴍ = array;
		UtilsIdentity.Ⴐ();
	}

	internal static string Ⴅ(byte P_0, Assembly P_1, int P_2, int P_3)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		IComparable<string> comparable = default(IComparable<string>);
		int num6 = default(int);
		Array array2 = default(Array);
		Array array = default(Array);
		object obj2 = default(object);
		char c = default(char);
		int num7 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = P_2 ^ 0x78557A53 ^ P_3;
			object ⴓ = Ⴓ;
			char[] obj = (char[])ⴓ;
			int num2 = obj[num];
			num2 = obj[num + 2] ^ num2;
			int num3 = 11;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = 16;
					continue;
				case 16:
					break;
				case 11:
					num3 = (((comparable = ((string[])Ⴈ)[num2]) == null) ? (ⴗ[124] - 24223) : 13);
					continue;
				case 13:
					return comparable as string;
				case 6:
				{
					char[] obj3 = (char[])ⴓ;
					char[] obj4 = (char[])Ⴍ;
					num6 = num;
					array2 = obj4;
					array = obj3;
					num3 = 8;
					continue;
				}
				case 8:
					obj2 = new StringBuilder();
					goto case 2;
				case 2:
					c = (array as char[])[num6];
					num7 = (array as char[])[num6 + 1] ^ c;
					num3 = 15;
					continue;
				case 14:
				case 15:
					num6 += 3;
					num5 = (num7 & 0x1F) | ((num7 & 0xFFC0) >> 1);
					num3 = 12;
					continue;
				case 12:
					num3 = (((num7 & 0x20) != 0) ? 1 : (ⴀ[256] - 37547));
					continue;
				case 1:
					num5 = (num5 << 15) | ((array as char[])[num6++] ^ c);
					num3 = ⴃႭ[81] - 32197;
					continue;
				case 0:
					num8 = (array2 as char[]).Length;
					num4 = 1;
					goto case 10;
				case 10:
					num3 = 3;
					continue;
				case 7:
					(obj2 as StringBuilder).Append((char)(c ^ (array as char[])[num6 + num5 - num4] ^ (array2 as char[])[(num4 + num6 + 17) % num8]));
					num3 = 5;
					continue;
				case 5:
					num4++;
					num3 = ⴃႣ[65] - 114;
					continue;
				case 3:
					num3 = ((num4 <= num5) ? 7 : (ⴃႭ[104] - 37828));
					continue;
				case 9:
					comparable = (obj2 as StringBuilder).ToString();
					((string[])Ⴈ)[num2] = (string)comparable;
					num3 = ⴃႭ[79] - 47119;
					continue;
				case 17:
					return (string)comparable;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Delegate Ⴜ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : Delegate where _0021_00211 : Delegate
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[332] - 32833;
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
				case 3:
					num2 = (((P_3 ^ P_2) - 58) ^ num) switch
					{
						0 => ⴐ[534] - 20451, 
						_ => 7, 
					};
					continue;
				case 7:
					cloneable = null;
					num2 = ⴗ[128] - 21308;
					continue;
				case 10:
					cloneable = Delegate.Remove(P_0, P_1);
					num2 = ⴗ[50] - 11841;
					continue;
				case 0:
				{
					num++;
					int num3 = 202;
					int num4 = 338;
					int num6;
					if (3380 <= num4 - num3 * 10)
					{
						char num5 = ⴗ[22];
						DataGridViewColumnSelector.Ⴐ[287] = (char)((DataGridViewColumnSelector.Ⴐ[287] | DataGridViewColumnSelector.Ⴐ[300]) & 0xA7);
						num6 = num5 - 41760;
					}
					else
					{
						num6 = 8;
					}
					num2 = num6;
					continue;
				}
				case 1:
				case 2:
				case 5:
					num2 = 3;
					continue;
				case 8:
					return (Delegate)cloneable;
				case 9:
					num2 = ⴃႣ[180] - 10731;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႥႤ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = ⴗ[105] - 4872;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႤ[127] - 30453;
					continue;
				case 2:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 108) ^ num) switch
					{
						0 => ⴗ[127] - 49517, 
						_ => ⴃႭ[66] - 45110, 
					};
					continue;
				case 10:
					convertible = null;
					num2 = 0;
					continue;
				case 7:
				case 9:
					convertible = Path.GetDirectoryName(P_0);
					num2 = 0;
					continue;
				case 0:
				{
					num++;
					int num4;
					if ((P_1 * P_1 + P_1) % 2 != 0)
					{
						char num3 = ⴐ[23];
						NeedsCfg.ႣႤ[143] = (NeedsCfg.ႣႤ[143] + TalkCfg.ႣႣ[65]) & 0x4A;
						num4 = num3 - 46387;
					}
					else
					{
						num4 = 11;
					}
					num2 = num4;
					continue;
				}
				case 5:
					num2 = ⴃႤ[528] - 49551;
					continue;
				case 4:
				case 6:
				case 11:
					return (string)convertible;
				case 8:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static NetworkInterface[] ႥႥ(char P_0, char P_1)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 11;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴐ[186] - 52809;
					continue;
				case 1:
					break;
				case 7:
				case 11:
					num2 = (((P_1 ^ P_0) - 58) ^ num) switch
					{
						0 => 3, 
						_ => ⴗ[80] - 32457, 
					};
					continue;
				case 0:
				case 4:
					obj = null;
					num2 = ⴐ[506] - 14743;
					continue;
				case 3:
				case 8:
					obj = NetworkInterface.GetAllNetworkInterfaces();
					num2 = ⴃႭ[275] - 30857;
					continue;
				case 2:
					num++;
					num2 = (((P_0 * P_0 + P_0) % 2 == 0) ? (ⴐ[192] - 13905) : 10);
					continue;
				case 10:
					num2 = 11;
					continue;
				case 6:
					return obj as NetworkInterface[];
				case 5:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object ႥႭ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : ArrayList
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
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
					num2 = 4;
					continue;
				case 4:
					break;
				case 2:
					num2 = (((P_1 ^ P_2) - 30) ^ num) switch
					{
						0 => 7, 
						_ => ⴀ[192] - 12188, 
					};
					continue;
				case 1:
					result = null;
					num2 = 8;
					continue;
				case 7:
					result = P_0.SyncRoot;
					num2 = ⴃႤ[135] - 4051;
					continue;
				case 0:
				case 8:
				case 11:
					num++;
					num3 = 40;
					goto case 9;
				case 9:
				{
					int num4 = 676;
					num2 = ((6760 > num4 - num3 * 10) ? 3 : 5);
					continue;
				}
				case 5:
					num2 = 2;
					continue;
				case 3:
					return result;
				case 10:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႰ<_0021_00210>(_0021_00210 P_0, ref bool P_1, char P_2, char P_3)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 2;
				continue;
			case 2:
			case 7:
				num = (((P_2 ^ P_3) - 33) ^ num2) switch
				{
					0 => 3, 
					_ => 4, 
				};
				continue;
			case 4:
				num = ⴐ[515] - 33230;
				continue;
			case 0:
			case 3:
				Monitor.Enter(P_0, ref P_1);
				goto case 8;
			case 8:
				num2++;
				break;
			case 5:
				break;
			case 6:
				return;
			}
			int num3 = 1461;
			int num4 = 7;
			num = ((487 < num3 / 3 - num4) ? (ⴗ[124] - 24227) : 6);
		}
	}

	[SecuritySafeCritical]
	internal static int ႥႳ(ref int P_0, short P_1, char P_2)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int result = default(int);
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
					num2 = 11;
					continue;
				case 11:
					break;
				case 2:
					num2 = (((P_1 ^ P_2) - 48) ^ num) switch
					{
						0 => ⴐ[89] - 28941, 
						1 => 7, 
						_ => 9, 
					};
					continue;
				case 9:
					result = 9;
					num2 = 8;
					continue;
				case 5:
					result = Interlocked.Decrement(ref P_0);
					num2 = ⴃႣ[28] - 41382;
					continue;
				case 3:
				case 7:
					result = Interlocked.Increment(ref P_0);
					num2 = 8;
					continue;
				case 0:
				case 8:
				{
					num++;
					int num3 = 2544;
					int num4 = 230;
					num2 = ((636 < num3 / 4 - num4) ? (ⴐ[560] - 29994) : 4);
					continue;
				}
				case 4:
					return result;
				case 1:
					num2 = ⴃႭ[170] - 55340;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string[] ႥႨ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : Assembly
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[11] - 31093;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
				case 4:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 78) ^ num) switch
					{
						0 => 0, 
						_ => 6, 
					};
					continue;
				case 6:
					obj = null;
					num2 = 8;
					continue;
				case 0:
				case 9:
					obj = P_0.GetManifestResourceNames();
					num2 = 8;
					continue;
				case 8:
				{
					num++;
					int num3 = 540;
					int num4 = 161;
					num2 = ((180 < num3 / 3 - num4) ? 1 : 5);
					continue;
				}
				case 5:
				case 7:
					return (string[])obj;
				case 2:
					num2 = ⴃႤ[89] - 51959;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႥႣ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : ArcLogInResp
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 9;
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
				case 9:
					num2 = (((P_1 ^ P_2) - 12) ^ num) switch
					{
						0 => ⴃႣ[142] - ⴃႣ[142], 
						_ => 8, 
					};
					continue;
				case 8:
					obj = null;
					num2 = 6;
					continue;
				case 0:
					obj = P_0.Call;
					num2 = 6;
					continue;
				case 6:
					num++;
					goto case 5;
				case 5:
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 1;
					continue;
				case 1:
					num2 = ((num3 % 2 != 0) ? 9 : 4);
					continue;
				case 2:
				case 4:
				case 7:
					return obj as string;
				case 10:
					num2 = ⴀ[218] - 52344;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႥႠ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2, char P_3, int P_4) where _0021_00210 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int result = default(int);
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
					num2 = 0;
					continue;
				case 0:
				case 4:
					break;
				case 5:
				case 8:
					num2 = (((P_4 ^ P_3) - 34) ^ num) switch
					{
						0 => 6, 
						_ => 9, 
					};
					continue;
				case 9:
					result = P_2;
					num2 = 3;
					continue;
				case 6:
					result = P_0.IndexOf(P_1, P_2);
					num2 = 3;
					continue;
				case 3:
				{
					num++;
					int num3 = 163;
					int num4 = 799;
					int num5;
					if (5593 <= num4 - num3 * 7)
					{
						num5 = 10;
					}
					else
					{
						int num6 = ⴃႤ[344];
						WxCfg.ႣႭ[139] = (char)((WxCfg.ႣႭ[139] | DxCfg.Ⴗ[43]) & 0xB4);
						num5 = num6 - 26223;
					}
					num2 = num5;
					continue;
				}
				case 10:
					num2 = ⴐ[590] - 62392;
					continue;
				case 11:
					return result;
				case 7:
					num2 = ⴐ[360] - 45872;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႷ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, char P_3) where _0021_00210 : ComboBox where _0021_00211 : EventHandler
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 1;
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
			case 4:
			case 9:
				num = (((P_2 ^ P_3) - 101) ^ num3) switch
				{
					0 => 0, 
					_ => 7, 
				};
				break;
			case 7:
				num = 3;
				break;
			case 0:
				P_0.DropDown += P_1;
				goto case 3;
			case 3:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = ⴀ[181] - 42552;
				break;
			case 2:
			case 5:
				num = ((num2 % 2 != 0) ? (ⴃႤ[590] - 59438) : (ⴃႤ[303] - 32027));
				break;
			case 6:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataGridViewPaintParts ႥႼ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : DataGridViewCellPaintingEventArgs
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		DataGridViewPaintParts result = default(DataGridViewPaintParts);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 11;
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
					num2 = (((P_2 ^ P_1) - 16) ^ num) switch
					{
						0 => 2, 
						_ => 4, 
					};
					continue;
				case 4:
					result = DataGridViewPaintParts.None;
					num2 = 6;
					continue;
				case 2:
					result = P_0.PaintParts;
					num2 = 6;
					continue;
				case 3:
				case 6:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					goto case 8;
				case 8:
					num2 = ⴐ[245] - 13571;
					continue;
				case 5:
				case 7:
					num2 = ((num3 % 2 != 0) ? (ⴃႤ[20] - 6296) : (ⴗ[71] - 6965));
					continue;
				case 1:
					return result;
				case 0:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}
}
