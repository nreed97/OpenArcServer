using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Filters;
using ArcInterfaces.Spots;
using ArcShared.DgvUtils.DgvFilter;
using ZedGraph;
using Ⴀ;

namespace ArcClientEngine.ArcCfg.Filters;

public sealed class WxFilters
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4150)]
	private struct Ⴅ
	{
	}

	internal sealed class ႭႨ
	{
		internal DgvFilterManager Ⴃ;

		internal string Ⴍ;

		internal string Ⴈ;

		internal ႭႨ()
		{
		}
	}

	private List<WxFilter> Ⴗ;

	private string Ⴗ;

	private MultimediaCfg.Ⴍ m_Ⴀ = new MultimediaCfg.Ⴍ();

	private static readonly Array Ⴈ;

	private static readonly Array Ⴄ = new char[2075]
	{
		'\udcf0', '\udcf3', '\udcf0', '\uf656', '\uee71', '썥', '檂', '檆', '檃', '堟',
		'甴', '䗩', '䍶', '\ud9f8', '\ud9e5', '\ud9fa', '\ueb63', '왂', '\uf69b', '\uf02b',
		'\uf139', '︕', '\udc6e', '\uf342', '\ueb72', '왘', '\uf68d', '\uf037', '\uf139', '︕',
		'\udc63', '\uf362', '\ueb56', '옌', '\uf69b', '\uf026', '\uf175', '\ufe22', '\udc3c', '\uf355',
		'\ueb7b', '왭', '\uf6de', '\uf01a', '\uf111', '菊', '菀', '菉', 'ꨂ', 'ꬂ',
		'ꐐ', '蘐', 'ꥫ', '녣', '鱰', '격', 'ꨀ', 'ꬨ', '龜', '龑',
		'龘', '뙒', '띟', '롇', '驅', '딗', '굓', '耺', '냿', '뙋',
		'띜', '롛', '驁', '딇', '睉', '睊', '睌', '傀', '犌', '巌',
		'껂', '껉', '껄', '葯', '鱉', '녹', '膊', '蜊', '蘊', '褘',
		'\uab00', '葥', '鱝', '녅', '칏', '칃', '칈', 'ﳅ', '퇯', '\ue128',
		'\ue781', '\ue6b1', '\ue993', '쮜', '\ue4f3', 'ﳔ', '퇴', '\ue139', '\ue7a6', '\u0320',
		'\u0323', '\u0328', 'ⱕ', '⫮', '⯉', '\u17b4', '\u17b5', '\u17bd', 'ሡ', '斏',
		'文', '斅', '䱐', '䵊', '䉂', '恘', '伄', '圎', '稵', '䫈',
		'啴', '啹', '啿', '粼', '綼', '犮', '傮', '翕', '柝', '䪀',
		'稊', '粊', '緹', '犮', '傇', '翯', '\udfee', '\udfe0', '\udfe2', '\uf09a',
		'\uf631', '\uf737', '\uf82c', '\uda31', '\uf560', '\ued21', '쁂', '\uf0ac', '\uf674', '\uf734',
		'\uf82f', '\uda10', '\uf575', '뻲', '뻺', '뻿', '鐇', '豥', 'ꅏ', '醒',
		'霭', '阭', '餬', '뭤', 'ᖭ', 'ᖬ', 'ᖣ', '㰿', '俦', '俥',
		'俩', '栭', '䨩', '敬', '䡬', '䡭', '䡼', '埆', '⎐', '⎈',
		'⎁', '♊', 'व', 'ᄇ', '㱪', '\u0cff', '੮', '\u0b49', 'ѐ', '♃',
		'ऱ', 'ᄓ', '㰇', '\u0cf5', '\u0a58', '\u0b7c', 'Б', '♕', '\u093a', 'ᄖ',
		'㰈', 'ಹ', '\u0a4d', '\u0b5b', 'ѽ', '\uecf3', '\uecfd', '\uece1', '쬸', '\ue92d',
		'왘', '\ude7d', '\uf364', '쎛', '씧', '쐟', '쬩', '\ue92b', '왞', '\ude75',
		'\uf34b', '쎶', '詯', '詢', '詼', '궤', '辱', 'ꃄ', '룡', '闸',
		'ꔑ', 'ꎂ', 'ꊶ', '궯', '込', 'ꃎ', '룬', '闸', '탉', '탊',
		'택', '館', '\ue27e', '콙', '骩', '骭', '骼', '꠪', '蔑', '뗎',
		'덐', '嚫', '嚣', '嚽', '煫', '卺', '簊', '搷', '䤓', '私',
		'罰', '繅', '筰', '筠', '筧', '吘', '劭', '厴', '岭', '纪',
		'凔', '䧾', '擇', '呖', '劸', '厸', '岪', '纲', '凗', '䧯',
		'擷', '긧', '긣', '긿', '蟒', '蛄', '觝', 'ꯐ', '邡', '邱',
		'邸', 'ꈫ', '輛', '뿈', '뤻', '롻', '띪', '镹', '멉', 'ꈫ',
		'輘', '뿎', '륯', '렬', '띣', '镻', '먨', '鳗', '鳛', '鳍',
		'荷', '뎾', '딝', '됉', '뭙', '餓', '뙺', '깕', '荮', '뎸',
		'딆', '됩', '뾅', '뾒', '뾞', '锪', '贋', 'ꀽ', '郥', '队',
		'靱', '顸', '멢', '镭', '贘', 'ꀴ', '郮', '陒', '靁', '顀',
		'멠', '镭', '财', 'ꀞ', '郁', '阎', '靼', '顨', '먾', '먥',
		'먢', 'ꖍ', '镙', '鏨', '鋵', '鶰', '뿦', '邁', '袾', 'ꖄ',
		'镓', '鏪', '鋆', '鶰', '뿺', '邓', '袼', 'ꖇ', '镑', '鏯',
		'鋀', '鶰', '뿀', '邹', '袓', 'ꗛ', '镬', '鏇', '我', '扔',
		'戌', '綡', '䵻', '䯎', '䫕', '䗙', '枇', '䢭', '傐', '綠',
		'䵺', '䯆', '䫓', '䗜', '枇', '䢷', '傗', '緥', '䵆', '䯨',
		'䪜', '䗗', '染', '䢰', '傉', '緥', '䵣', '䯄', '䫌', '䗌',
		'枇', '䢫', '傛', '綨', '䵺', '䯂', '䫗', '䗬', '\ue2b5', '\ue2a3',
		'\ue2ab', '큳', 'ﴬ', '췣', '쭘', '쨰', '씻', '\ue767', '젘', '퀿',
		'ﴑ', '췀', '쬯', '쩏', '았', '\ue723', '젏', '퀿', 'ﴌ', '췞',
		'쭦', '쩳', '안', 'ᘶ', 'ᙳ', 'ᘩ', '⒭', '\u0991', '㥙', '㿠',
		'㺻', '\u31ea', 'Ꮵ', '㲊', '⒪', 'ই', '㥄', '㿢', '㻴', 'ㇻ',
		'Ꭰ', '㲿', '⒍', 'দ', '㤞', '㿾', '㻾', '\u31ec', 'Ᏻ', '㲟',
		'⒔', '\u09c2', '㥕', '㿤', '㻯', 'ㆸ', 'Ꮾ', '㲗', '⓹', '\u098e',
		'㥜', '㿭', '㻘', '觎', '觔', '觮', 'ꀀ', 'ꄐ', '급', '谔',
		'ꌦ', '묑', '阪', '\ua6f9', 'ꁔ', 'ꄓ', '긏', '谌', 'ꌦ', '뭃',
		'陯', 'Ꚙ', 'ꁔ', 'ꄻ', '긤', '豘', 'ꍣ', '뭉', '陮', 'ꛨ',
		'ꀚ', 'ꄪ', 'ﳇ', 'ﳙ', 'ﳦ', '편', '픞', '퐄', '\udb0c', '滑',
		'홾', '칍', '\ue361', '펧', '핝', '퐅', '\udb00', '洛', '홮', '칚',
		'\ue333', '펬', '픜', '퐂', '\udb49', '洛', '홦', '칄', '\ue372', '펷',
		'핝', '퐋', '\udb49', '車', '홆', '뫿', '뫶', '뫝', '뼽', '遙',
		'衵', 'ꕅ', '閐', '錱', '鈼', '鴾', '뼊', 'ၕ', 'ၓ', 'ၶ',
		'㞂', 'ᖗ', '㫳', '⋏', '\u0fee', '㼐', '춝', '춚', '춹', '\ue442',
		'\ue55e', '\uea5c', '족', '\ue775', 'Ｃ', '툊', '\ue228', '\ue23b', '\ue20d', '엵',
		'\ue7f0', '좇', '킮', 'ﶏ', '쵂', '쯾', '쫤', '업', '\ue7be', '좔',
		'킯', 'ﶛ', '쵇', '쯾', '쫭', '엡', '\ue7f7', '좨', '\udfa1', '\udfa5',
		'\udf87', '\uda60', '\uf51d', '\ued21', '쀙', '맂', '링', '맥', '譔', 'Ꙣ',
		'隧', '\udab2', '\udab7', '\uda9a', '\ue838', '씒', '\uf5d5', '\uf37c', '\uf26c', '睵',
		'睶', '睜', '堐', '庠', '徴', '䫶', '䫱', '䫜', '硷', '啍',
		'料', '挸', '戸', '洽', '伳', '\u0617', '\u0611', 'ؼ', 'Ⲧ', '㒌',
		'\u19ad', '⥤', '⿂', '⻙', '욗', '욓', '욻', '\uf41c', '\ud92a', '\ue9e3',
		'\uef4a', '\uda7c', '\uda7a', '\uda51', '\uf0d1', '\ue8fd', '엇', '\uf500', '\uf3b7', '\uf2b2',
		'逵', '進', '逛', '럾', '闭', '몒', 'ꊠ', '辔', '뽇', '맦',
		'ଘ', 'ଜ', 'ଷ', '\u0ecb', '↽', '㦖', 'ᒢ', '䧹', '䧲', '䧉',
		'筢', '噃', '暐', '怠', '愦', '渲', '䰻', '捅', '筹', '噝',
		'暌', '坈', '圍', '坹', '文', '䢦', '砡', '纆', '翅', '炒',
		'力', '緳', '文', '䣲', '砡', '纛', '羖', '炈', '力', '練',
		'旟', '䣹', '确', '纆', '羋', '炃', '劓', '緭', '旈', '䣿',
		'确', '纆', '羊', '炖', '劭', '綠', '旿', '䣘', '确', '绒',
		'翅', '⢾', '⢯', '⢌', 'g', '\u0f7e', '\u2d6d', 'Ș', 'ᨸ', '㜞',
		'ߖ', 'ū', 'P', '༰', '\u2d7a', 'ȓ', 'ᨥ', '㜞', 'ߗ', 'Ŵ',
		'@', '\u1f1e', 'ἓ', 'Ἥ', '㟖', '㣞', '\u1ac7', '㖌', 'ⶀ', '\u0089',
		'な', '㛁', '㟇', '㣄', '\u1ac7', '㖦', 'ⶢ', '폄', '폇', '폰',
		'현', '糧', '\ue17c', 'ʏ', 'ʎ', 'ʺ', 'ⷈ', 'ᑍ', 'ᑅ', 'ᑻ',
		'㻱', '⛑', '௸', '㬨', '㶒', '㲒', '㎌', 'ᆽ', '䉈', '䉊',
		'䉿', '洟', '殱', 'Ꮨ', 'Ꮫ', 'Ꮰ', '㬗', '㐙', 'ᘬ', '庉',
		'庄', '庰', '癁', '祃', '子', '琯', '汆', '䄺', '燡', '睚',
		'癐', '祓', '子', '琱', '氵', '햢', '향', '햘', '\ufaff', 'ﱪ',
		'ﵪ', '\uf278', '큸', '＃', '\ue70b', '\u0efc', '\u0ef4', '\u0ec7', '␔', '㰩',
		'ᅚ', '↟', '✲', '☽', '⤻', 'ଌ', '\uda71', '\uda7e', '\uda4d', 'ﶢ',
		'\udff4', '\uf0c2', '\ue8b2', '엘', '\uf545', '\uf3b0', '\uf2f0', 'ﶢ', '\udff6', '\uf0c2',
		'\ue8b2', '엘', '\uf547', '\uf3b0', '\uef3c', '\uef2e', '\uef01', '\uddb8', '\uf09a', '쁕',
		'웱', '쟥', '죷', '\ueac4', '엔', '\udda1', '\uf08d', '쁎', '웵', '쟤',
		'죾', '\ueac9', '엔', '\udd8b', '\uf0ac', 'ᐒ', 'ᐑ', 'ᐬ', '㬴', '㶅',
		'㲟', 'ꄎ', 'ꄞ', 'ꄱ', '讣', '鎉', '뺹', '蹩', '裷', '觐',
		'蛔', 'ꓛ', '讣', '鎏', '뺴', '蹧', '裷', '觀', '蛒', 'ꓹ',
		'㓾', '㓼', '㒾', 'ᯖ', 'ᵪ', '余', '佋', '优', '棗', '䫕',
		'旾', '緂', '傭', '怫', '暆', '枇', '棗', '䪝', '旴', '緂',
		'僡', '怶', '暅', '柔', '梯', '䪸', '쮥', '쮩', '쯧', '칠',
		'\ue11f', '勞', '퐅', '\ue4cf', '\ue276', '\ue36e', '\uec2b', '칧', '\ue102', '鷺',
		'퐢', '\ue326', '\ue32d', '\ue365', '톾', 'ﲗ', '챮', '쪼', '쯹', '쓭',
		'\ue6f9', '즜', '톼', 'ﲝ', '챣', 'ϳ', 'ϻ', 'η', '\u242a', 'ت',
		'⥟', 'ㅲ', 'ᱎ', 'Ⲣ', '⨱', '⬉', '\u0558', '՟', 'ԝ', 'ⲇ',
		'\u2d9d', '⊕', '\u008f', '⿓', '㟏', '\u1ac8', '艈', '艉', '舎', '력',
		'時', '晎', '昅', '哟', '秹', '䤰', '侑', '事', '䆩', '掆',
		'䳯', '哙', '秺', '䤭', '侾', '䏭', '䏾', '䎥', '沙', '樸',
		'欴', '搪', '䘿', '楠', '焢', '屋', '沎', '樣', '欬', '搪',
		'䘝', '椅', '煿', '屠', '沮', '樜', '欻', '㌱', '㍳', '㍸',
		'ᓭ', '㛢', 'ᦍ', 'Ʋ', 'Ⲍ', '᱑', '᪫', '\u1bf9', 'ᓷ', '㛳',
		'᧙', 'Ƭ', 'Ⲋ', '᱑', '᪫', '\u1bf9', 'ᓲ', '㛦', 'ᦗ', 'Ǿ',
		'Ⲅ', 'ᰗ', '\u1af9', '\u1bf9', 'ᓫ', '㛩', 'ᦜ', 'Ǿ', 'Ⲁ', '᱄',
		'\u1aea', '\u1bf9', 'ᓳ', '㛗', '꾼', '꾸', '꿶', 'ꨧ', '蔺', '鴝',
		'뀩', '奕', '奆', '夞', '毕', '䛵', '癳', '炜', '熋', '纞',
		'岑', '珹', '毞', '䛠', '癳', '炊', '熛', '纕', '岖', '珲',
		'比', '䛯', '瘒', '侴', '侽', '俸', '杮', '桵', '䩦', '攒',
		'紲', '倷', '惜', '晠', '杘', '傕', '傉', '僘', '睏', '啂',
		'稹', '扔', '伲', '翶', '祆', '硜', '睟', '啖', '稟', '戦',
		'伱', '翦', '祛', '硝', '睨', '啗', '稳', '戟', '伨', '翿',
		'祬', '硤', '睜', '啅', '稞', '戦', '듗', '득', '뒙', '虝',
		'\uab6b', '鮲', '鴌', '鰹', '錀', '넅', '鹻', '虍', 'ꭁ', '펪',
		'펧', '폥', '\ue120', '찝', 'ﳅ', '辶', 'ﭵ', '\uf461', '홏', '豈',
		'\ue120', '착', 'ﳏ', '謁', 'צּ', 'l', 'n', '<', '⦒', '⢈',
		'醿', '醯', '釮', 'ꌦ', '踜', '뻮', '롚', '륦', '뙿', '鑬',
		'묞', 'ꌼ', '踨', '뻦', '롎', '뤧', '뙓', '鑈', '뭋', '疌',
		'疞', '痞', '屎', '嵶', '剌', '灔', '弅', '䜼', '樬', '嫤',
		'屓', '嵈', '剎', '灹', '弛', '䜨', '橭', '嫈', '屷', '崝',
		'拷', '拤', '护', '䔼', '朲', '䡑', '偷', '絓', '䶂', '䬨',
		'䨈', '䕹', '术', '䡐', '偱', '絗', '䶒', '䬨', '䨴', '䔷',
		'朮', '䡼', '㥓', '㥑', '㤇', '\u0bd3', '⛎', '쎘', '쎍', '쏍',
		'\uf103', '\udc29', '\uecf0', '\uea0c', '\ueb47', '\ue453', '왚', '\ue923', '\uf102', '\udc20',
		'\uecdd', '\uea50', '\ueb74', '\ue476', '왚', '\ue922', '\uf112', '\udc20', '\uecdf', '\uea5a',
		'\ueb71', '䉰', '䉻', '䈦', '洄', '殯', '檰', '斳', '䞯', '棓',
		'烌', '嶄', '洂', '殥', '檓', '蝀', '蝒', '蜗', 'ꃀ', '芒',
		'귭', '뗋', '飵', '꠩', '꺖', '꿍', 'ꂝ', '芓', '귫', '뗁',
		'飽', '꠰', '꺕', '꾟', 'ꂞ', '苖', '\ue87a', '\ue878', '\ue822', '\udad4',
		'\uf7e0', '碸', '碫', '磡', '埍', '內', '偻', '役', '絔', '剐',
		'䨂', '朸', '執', '儢', '偡', '彾', '絩', '则', '䨻', '朄',
		'埙', '八', '偝', 'ﱼ', 'ﱰ', 'ﰦ', '햴', '풴', '\udba5', '羚',
		'훝', '컅', '\ue3da', '팟', '햲', '풽', '\udbbb', '歷', '漕', '漘',
		'潎', '䛝', '䟝', '䣏', '櫏', '䖴', '嶼', '烡', '䁶', '䛛',
		'䟝', '䣗', '櫆', '䖙', 'ಇ', 'ಕ', '\u0cdb', '\u0943', '☪', '㸜',
		'ጿ', '⏨', '╛', '␊', '⭚', 'क़', '☧', '㸜', '፳', '⏤',
		'╉', '\u244f', '⭅', '\u0954', '☋', '킦', '탩', '탻', '\uf87f', '\uf769',
		'해', '懲', '\ue22d', '켝', 'ￍ', '弄', '\uf87f', '\uf77f', '핏', '益',
		'\ue23d', '켑', 'ﾏ', '便', '\uf87f', '\uf76b', '픿', '糖', '\ue226', '켑',
		'ﾎ', '說', '\uf86e', '\uf764', '핹', '行', '\ue264', '켋', 'ￒ', '泌',
		'\uf865', '\uf77d', '핿', '嗀', '\ue267', '켅', 'ￗ', '參', '\uf824', '\uf727',
		'픪', '羽', '\ue23d', '켆', '\uffc8', '\udf50', '\udf40', '\udf0e', '샰', '\uf037',
		'\uf68e', '\uf7d3', '\uf890', '\uda8f', '\uf5ff', '\uedd0', '새', '\uf033', '\uf687', '\uf792',
		'\uf89d', '\uda8a', '\uf5fd', '\uede8', '\ueb74', '\uebf5', '\ueb2b', '첮', '\ueeac', '쇙',
		'\ud9f2', '\uf4cc', '쐱', '슭', '쎫', '첛', '\ueee2', '쇓', '\ud9ef', '\uf480',
		'쐁', '슠', '쎶', '첳', '\ueeb6', '쇟', '\ud9fe', '\uf4ce', '쐜', '슡',
		'쎺', '쳺', '\ueeb0', '쇓', '\ud9fd', '\uf480', '쐖', '슫', '쎠', '첻',
		'\ueeae', '쇌', '\ud9e8', '\uf4c9', '쐖', '싮', '쎭', '첩', '\ueeb0', '쇕',
		'\ud9fd', '\uf480', '쐁', '슧', '쏹', '첮', '\ueea3', '쇔', '\ud9ef', '\uf480',
		'쐜', '슧', '쎾', '첵', '\ueeae', '솜', '\ud9f4', '\uf4d2', '쐆', '슠',
		'쎐', '쳹', '捤', '揯', '挄', '䧐', '冫', '粐', '䱂', '䫾',
		'䯩', '䓪', '曲', '䦌', '冫', '粐', '䱂', '䫾', '䯩', '䓪',
		'曲', '䦌', '冫', '粐', '䱂', '䫾', '䯩', '䓪', '曲', '䦌',
		'冫', '粐', '䱂', '䫾', '䯩', '䓪', '曲', '䦌', '冫', '粐',
		'䱂', '䫾', '䯩', '䓪', '曲', '䦌', '冫', '粐', '䱂', '䫾',
		'䯩', '䓪', '曲', '䦌', '冫', '粐', '䱂', '䫾', '䯩', '䓪',
		'曲', '䦌', '冫', '粐', '䱂', '䫾', '䯩', '䓪', '曲', '䦌',
		'冫', '粐', '䱂', '䫾', '䯩', '䓪', '曲', '䦌', '冫', '糌',
		'ꧧ', 'ꥬ', 'ꦆ', '뙏', '蛁', '聽', '腪', '蹩', '걱', '茏',
		'鬨', '똓', '蛁', '聽', '腪', '蹩', '걱', '茏', '鬨', '똓',
		'蛁', '聽', '脯', '踥', '갳', '荎', '魤', '뙚', '蚀', '耫',
		'脫', '蹩', '갡', '荟', '魩', '똓', '蚑', '耲', '脾', '踢',
		'갢', '荊', '魬', '똓', '蚕', '耳', '脯', '踠', '갽', '荬',
		'鬨', '뙁', '蚄', '耩', '脹', '踼', '갽', '荬', '鬥', '뙡',
		'蚠', '聽', '腪', '蹩', '걱', '茏', '鬨', '똓', '蛁', '聽',
		'腪', '蹩', '걱', '茏', '鬨', '똓', '蛁', '耡', '턘', '턎',
		'텺', '\ue3d7', '캱', '﹒', '\uf8ee', '林', '\uf6f5', '퓺', 'ﮃ', '\ue3b8',
		'캄', '﹥', '\uf882', '秊', '\uf6cf', '퓌', 'ﯰ', '\ue393', '캩', '﹪',
		'\uf8d1', '栗', '\uf6fe', '眿', '瞻', '睜', '梙', '塜', '廨', '忿',
		'僸', '狢', '嶄', '䗰', '梌', '塗', '廬', '忶', '僤', '狥',
		'嶔', '䖾', '梂', '堙', '延', '忦', '僾', '狹', '嶄', '䗰',
		'梇', '塕', '廤', '徲', '僿', '狦', '巗', '䖣', '梅', '塋',
		'廰', '忆', '傱', '犷', '巚', '䗰', '棋', '堙', '庥', '徲',
		'傱', '犩', '巗', '䗰', '棋', '堙', '庥', '徲', '傱', '犩',
		'巗', '䖢', '梎', '塍', '廩', '忻', '僗', '犩', '嶏', '䖔',
		'棋', '塍', '廠', '忁', '໗', '\u0edb', 'ຳ', '↣', '✈', '☝',
		'⤘', 'ଏ', '⑾', '㱵', 'ᅦ', '↹', '✎', '☛', '⤺', '괎',
		'괙', '굫', '鿏', '늾', '艭', '蓎', '藊', '諎', '\ua8df', '螩',
		'龂', '늿', '艺', '蒔', '藗', '諏', '꣖', '蟦', '龅', '늴',
		'艩', '蓙', '藎', '諏', 'ꣻ', 'ܥ', 'ܠ', '\u0743', '㖷', 'ᢨ',
		'⡦', '⻔', '⿳', '䒡', '䒳', '䓆', '浨', '汾', '捪', '䅣',
		'渝', '瘡', '嬅', '毴', '活', '汸', '捧', '䅰', '渀', '瘢',
		'嬝', '毀', '浲', '汄', '퓿', '퓭', '풗', '턺', '﹒', '\ue679',
		'쭟', 'ﮗ', 'ﴰ', 'ﰽ', '\uf312', '텩', '﹃', '\ue678', '쭌', 'ﮐ',
		'ﴩ', 'ﰺ', '\uf336', '턠', 'ﹿ', '쉻', '쉰', '숒', '\uf0e2', '\uddce',
		'\ued0a', '\uebef', '\ueaa2', '\ue5b6', '잨', '\ue8dd', '\uf0fa', '\uddc0', '\ued3e', '\udb2f',
		'\udb28', '\udb45', '\udefc', '\uf18f', '\ue9a3', '쒚', '\uf46a', '\uf2ed', '\uf3d5', 'ꂔ',
		'ꂐ', 'ꃿ', '訅', '鈯', '뼔', '迀', '勒', '勞', '劾', '恀',
		'䵈', '綛', '笡', '稬', '甮', '圡', '硌', '恾', '䵔', '綕',
		'笓', '뫷', '뫰', '몚', '뼤', '遌', '衹', 'ꕡ', '閒', '錿',
		'鈛', '\uf293', '\uf29c', '\uf2fd', '\uda4d', '픚', '\uf77c', '\ud80f', '쀿', '\ued67',
		'\udde1', '\udb41', '\uda59', '핔', '\uf749', '\ud833', '쀛', '\ued2e', '\udddd', '썂',
		'썊', '쌭', '\udca7', '\uec7a', '\uea9d', '\ueb9a', '\ue49d', '욝', '\ue9e4', '\uf1f8',
		'ꦰ', 'ꦫ', '\ua9c0', '聖', '腮', '蹪', '건', '茝', '鬳', '똥',
		'蛪', '聹', '腸', '蹲', '걯', '茾', '鬩', '똅', '蛡', '聾',
		'腳', '蹻', '걯', '茔', '鬜', '똸', '蛑', '聬', '腞', '蹂',
		'Ǹ', 'Ǳ', 'Ɖ', '⭆', '㍶', 'ṻ', '⻐', '⠶', '⤻', '☿',
		'С', '⭠', 'ຑ', 'ພ', '\u0ee3', '⤑', '\u0b43', '\u243c', '㰚', 'ᄤ',
		'⇸', '❇', '☜', '⥌', '\u0b42', '\u242d', '㰟', 'ᄱ', '⇤', '✋',
		'䢳', '䢲', '䣀', '坮', '禱', '禡', '秅', '籴', '匜', '䬪',
		'昄', '囃', '偘', '儼', '幫', '籯', '匞', '䬷', '昉', '囟',
		'偬', '兵', '幗', '넙', '넎', '녬', '駆', '雒', '듂', '鮼',
		'莟', '꺦', '鹌', '颃', '駍', '雃', '듆', '鮽', '莗', '꺸',
		'鹎', '颃', '駜', '雐', '듆', '鮙', '菖', '꺚', '鹈', '枻',
		'枬', '柍', '䣎', '乯', '佹', '䁼', '批', '䴐', '唱', '砼',
		'䢝', '乍', '佄', '䁇', '扌', '䵓', '唠', '砇', '䣚', '乨',
		'佺', '䁽', '扪', '䴚', '唜'
	};

	private static readonly object Ⴃ;

	internal static Ⴅ Ⴓ/* Not supported: data(F0 DC F3 DC F0 DC 56 F6 71 EE 65 C3 82 6A 86 6A 83 6A 1F 58 34 75 E9 45 76 43 F8 D9 E5 D9 FA D9 63 EB 42 C6 9B F6 2B F0 39 F1 15 FE 6E DC 42 F3 72 EB 58 C6 8D F6 37 F0 39 F1 15 FE 63 DC 62 F3 56 EB 0C C6 9B F6 26 F0 75 F1 22 FE 3C DC 55 F3 7B EB 6D C6 DE F6 1A F0 11 F1 CA 83 C0 83 C9 83 02 AA 02 AB 10 A4 10 86 6B A9 63 B1 70 9C A9 AC 00 AA 28 AB 9C 9F 91 9F 98 9F 52 B6 5F B7 47 B8 45 9A 17 B5 53 AD 3A 80 FF B0 4B B6 5C B7 5B B8 41 9A 07 B5 49 77 4A 77 4C 77 80 50 8C 72 CC 5D C2 AE C9 AE C4 AE 6F 84 49 9C 79 B1 8A 81 0A 87 0A 86 18 89 00 AB 65 84 5D 9C 45 B1 4F CE 43 CE 48 CE C5 FC EF D1 28 E1 81 E7 B1 E6 93 E9 9C CB F3 E4 D4 FC F4 D1 39 E1 A6 E7 20 03 23 03 28 03 55 2C EE 2A C9 2B B4 17 B5 17 BD 17 21 12 8F 65 87 65 85 65 50 4C 4A 4D 42 42 58 60 04 4F 0E 57 35 7A C8 4A 74 55 79 55 7F 55 BC 7C BC 7D AE 72 AE 50 D5 7F DD 67 80 4A 0A 7A 8A 7C F9 7D AE 72 87 50 EF 7F EE DF E0 DF E2 DF 9A F0 31 F6 37 F7 2C F8 31 DA 60 F5 21 ED 42 C0 AC F0 74 F6 34 F7 2F F8 10 DA 75 F5 F2 BE FA BE FF BE 07 94 65 8C 4F A1 92 91 2D 97 2D 96 2C 99 64 BB AD 15 AC 15 A3 15 3F 3C E6 4F E5 4F E9 4F 2D 68 29 4A 6C 65 6C 48 6D 48 7C 48 C6 57 90 23 88 23 81 23 4A 26 35 09 07 11 6A 3C FF 0C 6E 0A 49 0B 50 04 43 26 31 09 13 11 07 3C F5 0C 58 0A 7C 0B 11 04 55 26 3A 09 16 11 08 3C B9 0C 4D 0A 5B 0B 7D 04 F3 EC FD EC E1 EC 38 CB 2D E9 58 C6 7D DE 64 F3 9B C3 27 C5 1F C4 29 CB 2B E9 5E C6 75 DE 4B F3 B6 C3 6F 8A 62 8A 7C 8A A4 AD B1 8F C4 A0 E1 B8 F8 95 11 A5 82 A3 B6 A2 AF AD BC 8F CE A0 EC B8 F8 95 C9 D0 CA D0 DD D0 2C FA 7E E2 59 CF A9 9A AD 9A BC 9A 2A A8 11 85 CE B5 50 B3 AB 56 A3 56 BD 56 6B 71 7A 53 0A 7C 37 64 13 49 C1 79 70 7F 45 7E 70 7B 60 7B 67 7B 18 54 AD 52 B4 53 AD 5C AA 7E D4 51 FE 49 C7 64 56 54 B8 52 B8 53 AA 5C B2 7E D7 51 EF 49 F7 64 27 AE 23 AE 3F AE D2 87 C4 86 DD 89 D0 AB A1 90 B1 90 B8 90 2B A2 1B 8F C8 BF 3B B9 7B B8 6A B7 79 95 49 BA 2B A2 18 8F CE BF 6F B9 2C B8 63 B7 7B 95 28 BA D7 9C DB 9C CD 9C 77 83 BE B3 1D B5 09 B4 59 BB 13 99 7A B6 55 AE 6E 83 B8 B3 06 B5 29 B4 85 BF 92 BF 9E BF 2A 95 0B 8D 3D A0 E5 90 1F 96 71 97 78 98 62 BA 6D 95 18 8D 34 A0 EE 90 52 96 41 97 40 98 60 BA 6D 95 22 8D 1E A0 C1 90 0E 96 7C 97 68 98 3E BA 25 BA 22 BA 8D A5 59 95 E8 93 F5 92 B0 9D E6 BF 81 90 BE 88 84 A5 53 95 EA 93 C6 92 B0 9D FA BF 93 90 BC 88 87 A5 51 95 EF 93 C0 92 B0 9D C0 BF B9 90 93 88 DB A5 6C 95 C7 93 11 62 54 62 0C 62 A1 7D 7B 4D CE 4B D5 4A D9 45 87 67 AD 48 90 50 A0 7D 7A 4D C6 4B D3 4A DC 45 87 67 B7 48 97 50 E5 7D 46 4D E8 4B 9C 4A D7 45 D3 67 B0 48 89 50 E5 7D 63 4D C4 4B CC 4A CC 45 87 67 AB 48 9B 50 A8 7D 7A 4D C2 4B D7 4A EC 45 B5 E2 A3 E2 AB E2 73 D0 2C FD E3 CD 58 CB 30 CA 3B C5 67 E7 18 C8 3F D0 11 FD C0 CD 2F CB 4F CA 58 C5 23 E7 0F C8 3F D0 0C FD DE CD 66 CB 73 CA 48 C5 36 16 73 16 29 16 AD 24 91 09 59 39 E0 3F BB 3E EA 31 E5 13 8A 3C AA 24 87 09 44 39 E2 3F F4 3E FB 31 A0 13 BF 3C 8D 24 A6 09 1E 39 FE 3F FE 3E EC 31 F3 13 9F 3C 94 24 C2 09 55 39 E4 3F EF 3E B8 31 EE 13 97 3C F9 24 8E 09 5C 39 ED 3F D8 3E CE 89 D4 89 EE 89 00 A0 10 A1 09 AE 14 8C 26 A3 11 BB 2A 96 F9 A6 54 A0 13 A1 0F AE 0C 8C 26 A3 43 BB 6F 96 98 A6 54 A0 3B A1 24 AE 58 8C 63 A3 49 BB 6E 96 E8 A6 1A A0 2A A1 C7 FC D9 FC E6 FC B8 D3 1E D5 04 D4 0C DB 04 F9 7E D6 4D CE 61 E3 A7 D3 5D D5 05 D4 00 DB 15 F9 6E D6 5A CE 33 E3 AC D3 1C D5 02 D4 49 DB 15 F9 66 D6 44 CE 72 E3 B7 D3 5D D5 0B D4 49 DB 02 F9 46 D6 FF BA F6 BA DD BA 3D BF 59 90 75 88 45 A5 90 95 31 93 3C 92 3E 9D 0A BF 55 10 53 10 76 10 82 37 97 15 F3 3A CF 22 EE 0F 10 3F 9D CD 9A CD B9 CD 42 E4 5E E5 5C EA 71 C8 75 E7 23 FF 0A D2 28 E2 3B E2 0D E2 F5 C5 F0 E7 87 C8 AE D0 8F FD 42 CD FE CB E4 CA C5 C5 BE E7 94 C8 AF D0 9B FD 47 CD FE CB ED CA E1 C5 F7 E7 A8 C8 A1 DF A5 DF 87 DF 60 DA 1D F5 21 ED 19 C0 C2 B9 C1 B9 E5 B9 54 8B 62 A6 A7 96 B2 DA B7 DA 9A DA 38 E8 12 C5 D5 F5 7C F3 6C F2 75 77 76 77 5C 77 10 58 A0 5E B4 5F F6 4A F1 4A DC 4A 77 78 4D 55 99 65 38 63 38 62 3D 6D 33 4F 17 06 11 06 3C 06 A6 2C 8C 34 AD 19 64 29 C2 2F D9 2E 97 C6 93 C6 BB C6 1C F4 2A D9 E3 E9 4A EF 7C DA 7A DA 51 DA D1 F0 FD E8 C7 C5 00 F5 B7 F3 B2 F2 35 90 32 90 1B 90 FE B7 ED 95 92 BA A0 A2 94 8F 47 BF E6 B9 18 0B 1C 0B 37 0B CB 0E BD 21 96 39 A2 14 F9 49 F2 49 C9 49 62 7B 43 56 90 66 20 60 26 61 32 6E 3B 4C 45 63 79 7B 5D 56 8C 66 48 57 0D 57 79 57 87 65 A6 48 21 78 86 7E C5 7F 92 70 9B 52 F3 7D 87 65 F2 48 21 78 9B 7E 96 7F 88 70 9B 52 F4 7D DF 65 F9 48 6E 78 86 7E 8B 7F 83 70 93 52 ED 7D C8 65 FF 48 6E 78 86 7E 8A 7F 96 70 AD 52 A0 7D FF 65 D8 48 6E 78 D2 7E C5 7F BE 28 AF 28 8C 28 67 00 7E 0F 6D 2D 18 02 38 1A 1E 37 D6 07 6B 01 50 00 30 0F 7A 2D 13 02 25 1A 1E 37 D7 07 74 01 40 00 1E 1F 13 1F 2D 1F D6 37 DE 38 C7 1A 8C 35 80 2D 89 00 6A 30 C1 36 C7 37 C4 38 C7 1A A6 35 A2 2D C4 D3 C7 D3 F0 D3 04 D6 7B F9 7C E1 8F 02 8E 02 BA 02 C8 2D 4D 14 45 14 7B 14 F1 3E D1 26 F8 0B 28 3B 92 3D 92 3C 8C 33 BD 11 48 42 4A 42 7F 42 1F 6D B1 6B D8 13 DB 13 E0 13 17 3B 19 34 2C 16 89 5E 84 5E B0 5E 41 76 43 79 50 5B 2F 74 46 6C 3A 41 E1 71 5A 77 50 76 53 79 50 5B 31 74 35 6C A2 D5 A5 D5 98 D5 FF FA 6A FC 6A FD 78 F2 78 D0 03 FF 0B E7 FC 0E F4 0E C7 0E 14 24 29 3C 5A 11 9F 21 32 27 3D 26 3B 29 0C 0B 71 DA 7E DA 4D DA A2 FD F4 DF C2 F0 B2 E8 D8 C5 45 F5 B0 F3 F0 F2 A2 FD F6 DF C2 F0 B2 E8 D8 C5 47 F5 B0 F3 3C EF 2E EF 01 EF B8 DD 9A F0 55 C0 F1 C6 E5 C7 F7 C8 C4 EA D4 C5 A1 DD 8D F0 4E C0 F5 C6 E4 C7 FE C8 C9 EA D4 C5 8B DD AC F0 12 14 11 14 2C 14 34 3B 85 3D 9F 3C 0E A1 1E A1 31 A1 A3 8B 89 93 B9 BE 69 8E F7 88 D0 89 D4 86 DB A4 A3 8B 8F 93 B4 BE 67 8E F7 88 C0 89 D2 86 F9 A4 FE 34 FC 34 BE 34 D6 1B 6A 1D 59 4F 4B 4F 18 4F D7 68 D5 4A FE 65 C2 7D AD 50 2B 60 86 66 87 67 D7 68 9D 4A F4 65 C2 7D E1 50 36 60 85 66 D4 67 AF 68 B8 4A A5 CB A9 CB E7 CB 60 CE 1F E1 2F F9 05 D4 CF E4 76 E2 6E E3 2B EC 67 CE 02 E1 3A F9 22 D4 26 E3 2D E3 65 E3 BE D1 97 FC 6E CC BC CA F9 CB ED C4 F9 E6 9C C9 BC D1 9D FC 63 CC F3 03 FB 03 B7 03 2A 24 2A 06 5F 29 72 31 4E 1C A2 2C 31 2A 09 2B 58 05 5F 05 1D 05 87 2C 9D 2D 95 22 8F 00 D3 2F CF 37 C8 1A 48 82 49 82 0E 82 25 B8 42 66 4E 66 05 66 DF 54 F9 79 30 49 91 4F 8B 4E A9 41 86 63 EF 4C D9 54 FA 79 2D 49 BE 4F ED 43 FE 43 A5 43 99 6C 38 6A 34 6B 2A 64 3F 46 60 69 22 71 4B 5C 8E 6C 23 6A 2C 6B 2A 64 1D 46 05 69 7F 71 60 5C AE 6C 1C 6A 3B 6B 31 33 73 33 78 33 ED 14 E2 36 8D 19 B2 01 8C 2C 51 1C AB 1A F9 1B F7 14 F3 36 D9 19 AC 01 8A 2C 51 1C AB 1A F9 1B F2 14 E6 36 97 19 FE 01 84 2C 17 1C F9 1A F9 1B EB 14 E9 36 9C 19 FE 01 80 2C 44 1C EA 1A F9 1B F3 14 D7 36 BC AF B8 AF F6 AF 27 AA 3A 85 1D 9D 29 B0 55 59 46 59 1E 59 D5 6B F5 46 73 76 9C 70 8B 71 9E 7E 91 5C F9 73 DE 6B E0 46 73 76 8A 70 9B 71 95 7E 96 5C F2 73 D4 6B EF 46 12 76 B4 4F BD 4F F8 4F 6E 67 75 68 66 4A 12 65 32 7D 37 50 DC 60 60 66 58 67 95 50 89 50 D8 50 4F 77 42 55 39 7A 54 62 32 4F F6 7F 46 79 5C 78 5F 77 56 55 1F 7A 26 62 31 4F E6 7F 5B 79 5D 78 68 77 57 55 33 7A 1F 62 28 4F FF 7F 6C 79 64 78 5C 77 45 55 1E 7A 26 62 D7 B4 DD B4 99 B4 5D 86 6B AB B2 9B 0C 9D 39 9C 00 93 05 B1 7B 9E 4D 86 41 AB AA D3 A7 D3 E5 D3 20 E1 1D CC C5 FC 66 FA 75 FB 61 F4 4F D6 00 F9 20 E1 29 CC CF FC 62 FA 46 FB 6C 00 6E 00 3C 00 92 29 88 28 BF 91 AF 91 EE 91 26 A3 1C 8E EE BE 5A B8 66 B9 7F B6 6C 94 1E BB 3C A3 28 8E E6 BE 4E B8 27 B9 53 B6 48 94 4B BB 8C 75 9E 75 DE 75 4E 5C 76 5D 4C 52 54 70 05 5F 3C 47 2C 6A E4 5A 53 5C 48 5D 4E 52 79 70 1B 5F 28 47 6D 6A C8 5A 77 5C 1D 5D F7 62 E4 62 A4 62 3C 45 32 67 51 48 77 50 53 7D 82 4D 28 4B 08 4A 79 45 2F 67 50 48 71 50 57 7D 92 4D 28 4B 34 4A 37 45 2E 67 7C 48 53 39 51 39 07 39 D3 0B CE 26 98 C3 8D C3 CD C3 03 F1 29 DC F0 EC 0C EA 47 EB 53 E4 5A C6 23 E9 02 F1 20 DC DD EC 50 EA 74 EB 76 E4 5A C6 22 E9 12 F1 20 DC DF EC 5A EA 71 EB 70 42 7B 42 26 42 04 6D AF 6B B0 6A B3 65 AF 47 D3 68 CC 70 84 5D 02 6D A5 6B 93 6A 40 87 52 87 17 87 C0 A0 92 82 ED AD CB B5 F5 98 29 A8 96 AE CD AF 9D A0 93 82 EB AD C1 B5 FD 98 30 A8 95 AE 9F AF 9E A0 D6 82 7A E8 78 E8 22 E8 D4 DA E0 F7 B8 78 AB 78 E1 78 CD 57 67 51 7B 50 79 5F 54 7D 50 52 02 4A 38 67 F7 57 22 51 61 50 7E 5F 69 7D 19 52 3B 4A 04 67 D9 57 6B 51 5D 50 7C FC 70 FC 26 FC B4 D5 B4 D4 A5 DB AF F9 DD D6 C5 CE DA E3 1F D3 B2 D5 BD D4 BB DB 8C F9 15 6F 18 6F 4E 6F DD 46 DD 47 CF 48 CF 6A B4 45 BC 5D E1 70 76 40 DB 46 DD 47 D7 48 C6 6A 99 45 87 0C 95 0C DB 0C 43 09 2A 26 1C 3E 3F 13 E8 23 5B 25 0A 24 5A 2B 58 09 27 26 1C 3E 73 13 E4 23 49 25 4F 24 45 2B 54 09 0B 26 A6 D0 E9 D0 FB D0 7F F8 69 F7 74 D5 40 FA 2D E2 1D CF CD FF 43 F9 7F F8 7F F7 4F D5 17 FA 3D E2 11 CF 8F FF 65 F9 7F F8 6B F7 3F D5 03 FA 26 E2 11 CF 8E FF 6F F9 6E F8 64 F7 79 D5 08 FA 64 E2 0B CF D2 FF 68 F9 65 F8 7D F7 7F D5 0D FA 67 E2 05 CF D7 FF 6B F9 24 F8 27 F7 2A D5 1E FA 3D E2 06 CF C8 FF 50 DF 40 DF 0E DF F0 C0 37 F0 8E F6 D3 F7 90 F8 8F DA FF F5 D0 ED C8 C0 33 F0 87 F6 92 F7 9D F8 8A DA FD F5 E8 ED 74 EB F5 EB 2B EB AE CC AC EE D9 C1 F2 D9 CC F4 31 C4 AD C2 AB C3 9B CC E2 EE D3 C1 EF D9 80 F4 01 C4 A0 C2 B6 C3 B3 CC B6 EE DF C1 FE D9 CE F4 1C C4 A1 C2 BA C3 FA CC B0 EE D3 C1 FD D9 80 F4 16 C4 AB C2 A0 C3 BB CC AE EE CC C1 E8 D9 C9 F4 16 C4 EE C2 AD C3 A9 CC B0 EE D5 C1 FD D9 80 F4 01 C4 A7 C2 F9 C3 AE CC A3 EE D4 C1 EF D9 80 F4 1C C4 A7 C2 BE C3 B5 CC AE EE 9C C1 F4 D9 D2 F4 06 C4 A0 C2 90 C3 F9 CC 64 63 EF 63 04 63 D0 49 AB 51 90 7C 42 4C FE 4A E9 4B EA 44 F2 66 8C 49 AB 51 90 7C 42 4C FE 4A E9 4B EA 44 F2 66 8C 49 AB 51 90 7C 42 4C FE 4A E9 4B EA 44 F2 66 8C 49 AB 51 90 7C 42 4C FE 4A E9 4B EA 44 F2 66 8C 49 AB 51 90 7C 42 4C FE 4A E9 4B EA 44 F2 66 8C 49 AB 51 90 7C 42 4C FE 4A E9 4B EA 44 F2 66 8C 49 AB 51 90 7C 42 4C FE 4A E9 4B EA 44 F2 66 8C 49 AB 51 90 7C 42 4C FE 4A E9 4B EA 44 F2 66 8C 49 AB 51 90 7C 42 4C FE 4A E9 4B EA 44 F2 66 8C 49 AB 51 CC 7C E7 A9 6C A9 86 A9 4F B6 C1 86 7D 80 6A 81 69 8E 71 AC 0F 83 28 9B 13 B6 C1 86 7D 80 6A 81 69 8E 71 AC 0F 83 28 9B 13 B6 C1 86 7D 80 2F 81 25 8E 33 AC 4E 83 64 9B 5A B6 80 86 2B 80 2B 81 69 8E 21 AC 5F 83 69 9B 13 B6 91 86 32 80 3E 81 22 8E 22 AC 4A 83 6C 9B 13 B6 95 86 33 80 2F 81 20 8E 3D AC 6C 83 28 9B 41 B6 84 86 29 80 39 81 3C 8E 3D AC 6C 83 25 9B 61 B6 A0 86 7D 80 6A 81 69 8E 71 AC 0F 83 28 9B 13 B6 C1 86 7D 80 6A 81 69 8E 71 AC 0F 83 28 9B 13 B6 C1 86 21 80 18 D1 0E D1 7A D1 D7 E3 B1 CE 52 FE EE F8 F4 F9 F5 F6 FA D4 83 FB B8 E3 84 CE 65 FE 82 F8 95 F9 CF F6 CC D4 F0 FB 93 E3 A9 CE 6A FE D1 F8 DA F9 FE F6 3F 77 BB 77 5C 77 99 68 5C 58 E8 5E FF 5F F8 50 E2 72 84 5D F0 45 8C 68 57 58 EC 5E F6 5F E4 50 E5 72 94 5D BE 45 82 68 19 58 F6 5E E6 5F FE 50 F9 72 84 5D F0 45 87 68 55 58 E4 5E B2 5F FF 50 E6 72 D7 5D A3 45 85 68 4B 58 F0 5E C6 5F B1 50 B7 72 DA 5D F0 45 CB 68 19 58 A5 5E B2 5F B1 50 A9 72 D7 5D F0 45 CB 68 19 58 A5 5E B2 5F B1 50 A9 72 D7 5D A2 45 8E 68 4D 58 E9 5E FB 5F D7 50 A9 72 8F 5D 94 45 CB 68 4D 58 E0 5E C1 5F D7 0E DB 0E B3 0E A3 21 08 27 1D 26 18 29 0F 0B 7E 24 75 3C 66 11 B9 21 0E 27 1B 26 3A 29 0E AD 19 AD 6B AD CF 9F BE B2 6D 82 CE 84 CA 85 CE 8A DF A8 A9 87 82 9F BF B2 7A 82 94 84 D7 85 CF 8A D6 A8 E6 87 85 9F B4 B2 69 82 D9 84 CE 85 CF 8A FB A8 25 07 20 07 43 07 B7 35 A8 18 66 28 D4 2E F3 2F A1 44 B3 44 C6 44 68 6D 7E 6C 6A 63 63 41 1D 6E 21 76 05 5B F4 6B 3B 6D 78 6C 67 63 70 41 00 6E 22 76 1D 5B C0 6B 72 6D 44 6C FF D4 ED D4 97 D4 3A D1 52 FE 79 E6 5F CB 97 FB 30 FD 3D FC 12 F3 69 D1 43 FE 78 E6 4C CB 90 FB 29 FD 3A FC 36 F3 20 D1 7F FE 7B C2 70 C2 12 C2 E2 F0 CE DD 0A ED EF EB A2 EA B6 E5 A8 C7 DD E8 FA F0 C0 DD 3E ED 2F DB 28 DB 45 DB FC DE 8F F1 A3 E9 9A C4 6A F4 ED F2 D5 F3 94 A0 90 A0 FF A0 05 8A 2F 92 14 BF C0 8F D2 52 DE 52 BE 52 40 60 48 4D 9B 7D 21 7B 2C 7A 2E 75 21 57 4C 78 7E 60 54 4D 95 7D 13 7B F7 BA F0 BA 9A BA 24 BF 4C 90 79 88 61 A5 92 95 3F 93 1B 92 93 F2 9C F2 FD F2 4D DA 1A D5 7C F7 0F D8 3F C0 67 ED E1 DD 41 DB 59 DA 54 D5 49 F7 33 D8 1B C0 2E ED DD DD 42 C3 4A C3 2D C3 A7 DC 7A EC 9D EA 9A EB 9D E4 9D C6 E4 E9 F8 F1 B0 A9 AB A9 C0 A9 56 80 6E 81 6A 8E 74 AC 1D 83 33 9B 25 B6 EA 86 79 80 78 81 72 8E 6F AC 3E 83 29 9B 05 B6 E1 86 7E 80 73 81 7B 8E 6F AC 14 83 1C 9B 38 B6 D1 86 6C 80 5E 81 42 8E F8 01 F1 01 89 01 46 2B 76 33 7B 1E D0 2E 36 28 3B 29 3F 26 21 04 60 2B 91 0E 9E 0E E3 0E 11 29 43 0B 3C 24 1A 3C 24 11 F8 21 47 27 1C 26 4C 29 42 0B 2D 24 1F 3C 31 11 E4 21 0B 27 B3 48 B2 48 C0 48 6E 57 B1 79 A1 79 C5 79 74 7C 1C 53 2A 4B 04 66 C3 56 58 50 3C 51 6B 5E 6F 7C 1E 53 37 4B 09 66 DF 56 6C 50 75 51 57 5E 19 B1 0E B1 6C B1 C6 99 D2 96 C2 B4 BC 9B 9F 83 A6 AE 4C 9E 83 98 CD 99 C3 96 C6 B4 BD 9B 97 83 B8 AE 4E 9E 83 98 DC 99 D0 96 C6 B4 99 9B D6 83 9A AE 48 9E BB 67 AC 67 CD 67 CE 48 6F 4E 79 4F 7C 40 79 62 10 4D 31 55 3C 78 9D 48 4D 4E 44 4F 47 40 4C 62 53 4D 20 55 07 78 DA 48 68 4E 7A 4F 7D 40 6A 62 1A 4D 1C 55) */;

	[Description("List of weather filters")]
	public List<WxFilter> List
	{
		get
		{
			char[] ⴗ = ႥႰ.Ⴗ;
			return this.Ⴗ;
		}
		set
		{
			this.Ⴗ = value;
		}
	}

	[Description("Default weather filter name")]
	public string DefaultFilterName
	{
		get
		{
			return this.m_Ⴀ.Ⴍ;
		}
		set
		{
			this.m_Ⴀ.Ⴍ = value;
			UserCmd.Ⴅ[355] = (byte)(UserCmd.Ⴅ[355] & UserCmd.Ⴅ[348] & 0x8F);
		}
	}

	[Description("Default weather filter")]
	public string DefaultFilter
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

	public WxFilters()
	{
		List = new List<WxFilter>();
		DefaultFilterName = string.Empty;
		DefaultFilter = string.Empty;
	}

	internal void Ⴐ()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new WxFilter(Ⴀ(null, 2, 103387773), string.Empty);
				List.Add(obj as WxFilter);
				goto case 4;
			case 4:
				num = 2;
				break;
			case 2:
				obj = new WxFilter(ClientCty.Ⴗ(')', 3, 307013160), ႥႥ.Ⴅ(1673508169, null, 0));
				num = ⴗ[79] - 32756;
				break;
			case 0:
			case 6:
				List.Add(obj as WxFilter);
				obj = new WxFilter(ႥႥ.Ⴅ(1673508184, null, 2), ႥႥ.Ⴍ(2, 1580608852, '~', null));
				num = 5;
				break;
			case 5:
				List.Add((WxFilter)obj);
				return;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static WxFilters()
	{
		char[] array = new char[8];
		array[0] = '\u05b6';
		array[5] = '\u1fd4';
		array[6] = '㋯';
		array[3] = '⦺';
		array[1] = '➮';
		array[7] = '⫈';
		array[4] = '⼆';
		array[2] = '⢭';
		Ⴃ = new string[119];
		Ⴈ = array;
		ArcClientConnectDat.Ⴍ();
	}

	internal static string Ⴀ(Assembly P_0, int P_1, int P_2)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		IComparable comparable = default(IComparable);
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
			int num = P_2 ^ 0x6299252 ^ P_1;
			object ⴄ2 = Ⴄ;
			char[] obj = (char[])ⴄ2;
			int num2 = obj[num];
			num2 = obj[num + 2] ^ num2;
			int num3 = ⴗ[78] - 57606;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = ⴄ[302] - 8848;
					continue;
				case 13:
					break;
				case 16:
					num3 = (((comparable = ((string[])Ⴃ)[num2]) == null) ? 8 : 12);
					continue;
				case 6:
				case 12:
					return (string)comparable;
				case 8:
				{
					char[] obj4 = (char[])ⴄ2;
					char[] obj5 = (char[])Ⴈ;
					num6 = num;
					obj6 = obj5;
					obj3 = obj4;
					num3 = ⴅ[396] - 55;
					continue;
				}
				case 2:
					obj2 = new StringBuilder();
					c = (obj3 as char[])[num6];
					num7 = ((char[])obj3)[num6 + 1] ^ c;
					num3 = 17;
					continue;
				case 17:
					num6 += 3;
					num5 = (num7 & 0x1F) | ((num7 & 0xFFC0) >> 1);
					num3 = ⴗ[38] - 31039;
					continue;
				case 1:
					num3 = (((num7 & 0x20) == 0) ? (ⴀႠ[126] - 21879) : 3);
					continue;
				case 3:
					num5 = (num5 << 15) | ((obj3 as char[])[num6++] ^ c);
					num3 = ⴄ[16] - 31810;
					continue;
				case 15:
					num8 = ((char[])obj6).Length;
					num4 = 1;
					num3 = 5;
					continue;
				case 11:
					(obj2 as StringBuilder).Append((char)(c ^ (obj3 as char[])[num6 + num5 - num4] ^ (obj6 as char[])[(num4 + num6 + 17) % num8]));
					num3 = ⴗ[161] - 4999;
					continue;
				case 0:
				case 9:
					num4++;
					num3 = 5;
					continue;
				case 5:
					num3 = ((num4 <= num5) ? 11 : (ⴄ[47] - 24197));
					continue;
				case 4:
					comparable = ((StringBuilder)obj2).ToString();
					((string[])Ⴃ)[num2] = comparable as string;
					goto case 14;
				case 14:
					num3 = 7;
					continue;
				case 7:
					return comparable as string;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴜ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : MailMessage where _0021_00211 : SmtpClient
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 2;
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = 1;
				continue;
			case 1:
				num = (((P_2 ^ P_3) - 43) ^ num4) switch
				{
					0 => ⴄ[288] - 36182, 
					_ => 9, 
				};
				continue;
			case 9:
				num = 3;
				continue;
			case 7:
				P_0.Send(P_1);
				goto case 3;
			case 3:
				num4++;
				goto case 6;
			case 6:
			case 8:
			{
				num3 = 593;
				int num5 = num3;
				num2 = num5 * num5;
				num = 5;
				continue;
			}
			case 5:
				num2 = num3 + num2;
				break;
			case 0:
				break;
			case 4:
				return;
			}
			num = ((num2 % 2 != 0) ? (ⴄ[210] - 42791) : (ⴄ[278] - 56973));
		}
	}

	[SecuritySafeCritical]
	internal static DataTable ႭႷ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, short P_3) where _0021_00210 : DataTableCollection
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		ISupportInitialize supportInitialize = default(ISupportInitialize);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[35] - 25311;
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
				case 4:
					num2 = (((P_2 ^ P_3) - 33) ^ num) switch
					{
						0 => ⴅ[161] - 214, 
						_ => ⴄ[199] - 65143, 
					};
					continue;
				case 10:
					supportInitialize = null;
					goto case 0;
				case 0:
					num2 = 9;
					continue;
				case 6:
					supportInitialize = P_0[P_1];
					num2 = ⴅ[205] - 53;
					continue;
				case 9:
				{
					num++;
					int num3 = 945;
					int num4 = 975;
					num2 = ((4875 > num4 - num3 * 5) ? (ⴗ[118] - 65335) : 2);
					continue;
				}
				case 2:
					num2 = 4;
					continue;
				case 1:
				case 8:
					return (DataTable)supportInitialize;
				case 3:
				case 5:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly ႭႭ(int P_0, int P_1)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		IEvidenceFactory evidenceFactory = default(IEvidenceFactory);
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
					num2 = 7;
					continue;
				case 7:
					break;
				case 6:
					num2 = (((P_0 ^ P_1) - 43) ^ num) switch
					{
						0 => 0, 
						_ => 5, 
					};
					continue;
				case 5:
					evidenceFactory = null;
					goto case 1;
				case 1:
					num2 = ⴗ[56] - 32873;
					continue;
				case 0:
				case 9:
					evidenceFactory = Assembly.GetExecutingAssembly();
					num2 = ⴅ[102];
					continue;
				case 2:
				case 10:
				{
					num++;
					int num3 = 2658;
					int num4 = 256;
					num2 = ((886 < num3 / 3 - num4) ? (ⴗ[31] - 64610) : (ⴗ[93] - 63515));
					continue;
				}
				case 4:
					return (Assembly)evidenceFactory;
				case 8:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static YAxis ႭႠ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : GraphPane
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		ISerializable serializable = default(ISerializable);
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
					num2 = 11;
					continue;
				case 4:
				case 11:
					break;
				case 7:
				{
					int num5 = (P_1 ^ P_2) - 33;
					int num6 = num;
					Bye.Ⴄ[128] = (char)((Bye.Ⴄ[128] - ႥႰ.Ⴗ[131]) & 0xD3);
					num2 = (num5 ^ num6) switch
					{
						0 => 6, 
						_ => ⴗ[161] - 4991, 
					};
					continue;
				}
				case 8:
					serializable = null;
					num2 = ⴗ[41] - 23803;
					continue;
				case 5:
				case 6:
					serializable = P_0.YAxis;
					num2 = 1;
					continue;
				case 1:
				{
					num++;
					int num3 = 945;
					int num4 = 975;
					num2 = ((4875 > num4 - num3 * 5) ? (ⴄ[295] - 49142) : 3);
					continue;
				}
				case 3:
					num2 = 7;
					continue;
				case 2:
					return serializable as YAxis;
				case 10:
					num2 = ⴗ[62] - 59545;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႭႰ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, int P_3) where _0021_00210 : DataGridViewLinkColumn
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 2;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 1;
				break;
			case 1:
				num = (((P_3 ^ P_2) - 53) ^ num2) switch
				{
					0 => 5, 
					_ => 9, 
				};
				break;
			case 9:
				num = ⴀႠ[112] - 45134;
				break;
			case 5:
				P_0.TrackVisitedState = P_1;
				goto case 0;
			case 0:
				num2++;
				num3 = 240;
				num4 = 555;
				goto case 3;
			case 3:
			case 6:
				num = ((1110 > num4 - num3 * 2) ? ⴅ[4] : 4);
				break;
			case 4:
				num = ⴅ[153] - 209;
				break;
			case 7:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float ႭႤ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DxSpot
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		float result = default(float);
		while (true)
		{
			int num = 0;
			int num2 = 8;
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
				case 8:
					num2 = (((P_1 ^ P_2) - 112) ^ num) switch
					{
						0 => 7, 
						_ => 4, 
					};
					continue;
				case 4:
					result = 0.7666295f;
					num2 = ⴀႠ[44] - 48725;
					continue;
				case 6:
				case 7:
					result = P_0.Freq;
					num2 = 3;
					continue;
				case 3:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴄ[80] - 22722) : (ⴗ[89] - 46811));
					continue;
				case 11:
					num2 = 8;
					continue;
				case 10:
					return result;
				case 0:
				case 5:
				case 9:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႭႣ<_0021_00210>(_0021_00210 P_0, bool P_1, char P_2, char P_3) where _0021_00210 : DxSpot
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_2 ^ P_3) - 72) ^ num2) switch
				{
					0 => 7, 
					_ => 9, 
				};
				break;
			case 9:
				num = ⴗ[149] - 53675;
				break;
			case 7:
				P_0.Buddy = P_1;
				goto case 3;
			case 3:
			case 6:
			{
				num2++;
				int num3 = 107;
				int num4 = 938;
				num = ((1876 > num4 - num3 * 2) ? (ⴗ[113] - 53669) : 5);
				break;
			}
			case 5:
				num = ⴗ[161] - 4995;
				break;
			case 0:
			case 1:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static TimeSpan ႭႥ(ref DateTime P_0, DateTime P_1, short P_2, char P_3)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		TimeSpan result = default(TimeSpan);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[34] - 61630;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[163] - 114;
					continue;
				case 4:
				case 10:
					break;
				case 3:
					num2 = (((P_3 ^ P_2) - 64) ^ num) switch
					{
						0 => ⴄ[92] - 14808, 
						_ => ⴄ[290] - 49150, 
					};
					continue;
				case 1:
					result = default(TimeSpan);
					num2 = ⴄ[187] - 15470;
					continue;
				case 7:
					result = P_0.Subtract(P_1);
					num2 = 0;
					continue;
				case 0:
					num++;
					goto case 2;
				case 2:
				case 9:
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 8 : (ⴅ[281] - 92));
					continue;
				case 6:
					num2 = 3;
					continue;
				case 8:
					return result;
				case 11:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}
}
