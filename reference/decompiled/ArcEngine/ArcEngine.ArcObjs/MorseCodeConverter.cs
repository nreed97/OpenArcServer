using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcObjs;

public class MorseCodeConverter
{
	private sealed class ႨႳ
	{
		public StringBuilder Ⴍ;

		public MorseCodeConverter Ⴍ;

		public void Ⴅ(char P_0)
		{
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			int num = 3;
			char key = default(char);
			while (true)
			{
				switch (num)
				{
				default:
					key = ShowLogHelp.Ⴗ(P_0, 615, 'ȱ');
					num = ((!Ⴍ.Ⴃ.Ⴃ.ContainsKey(key)) ? 5 : ⴄႭ[246]);
					break;
				case 2:
					ႷႰ.Ⴅ(this.Ⴍ, Ⴍ.Ⴃ.Ⴃ[key], 'Ó', 'ã');
					num = 6;
					break;
				case 4:
				case 6:
					this.Ⴍ.Append(' ');
					num = 5;
					break;
				case 0:
				case 1:
				case 5:
					return;
				}
			}
		}
	}

	private Configuration.Ⴈ Ⴃ;

	public MorseCodeConverter()
	{
		object obj = new Dictionary<char, string>();
		Ⴃ.Ⴃ = obj as Dictionary<char, string>;
		Ⴍ();
	}

	private void Ⴍ()
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 20;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴃ.Ⴃ.Add('a', ႨႨ.Ⴀ(11, 2, 1157899881));
				goto case 32;
			case 32:
				num = ⴐ[271];
				break;
			case 36:
				Ⴃ.Ⴃ.Add('b', ႨႨ.Ⴀ(7, 5, 1157899881));
				num = ⴀႼ[12] - 233;
				break;
			case 10:
				Ⴃ.Ⴃ.Add('c', ႨႨ.Ⴀ(10, 1, 1157899894));
				num = ⴄႷ[122] - 47385;
				break;
			case 22:
				Ⴃ.Ⴃ.Add('d', ႨႨ.Ⴀ(7, 4, 1157899898));
				num = ⴄႷ[110] - 20061;
				break;
			case 12:
				Ⴃ.Ⴃ.Add('e', SetStationClubHelp.Ⴍ(4, 1, 1747257860, null));
				num = 5;
				break;
			case 5:
				Ⴃ.Ⴃ.Add('f', ႨႨ.Ⴀ(12, 7, 1157899783));
				num = 24;
				break;
			case 24:
				Ⴃ.Ⴃ.Add('g', ႨႨ.Ⴀ(11, 1, 1157899786));
				num = ⴃႥ[262] - 48607;
				break;
			case 15:
				Ⴃ.Ⴃ.Add('h', ႨႨ.Ⴀ(6, 2, 1157899791));
				num = 1;
				break;
			case 1:
				Ⴃ.Ⴃ.Add('i', ႨႨ.Ⴀ(4, 8, 1157899804));
				num = 26;
				break;
			case 26:
				Ⴃ.Ⴃ.Add('j', ႨႨ.Ⴀ(6, 3, 1157899802));
				num = 6;
				break;
			case 6:
				Ⴃ.Ⴃ.Add('k', ႨႨ.Ⴀ(4, 2, 1157899810));
				num = 13;
				break;
			case 13:
				Ⴃ.Ⴃ.Add('l', ႨႨ.Ⴀ(2, 0, 1157899818));
				num = 11;
				break;
			case 11:
				Ⴃ.Ⴃ.Add('m', ႨႨ.Ⴀ(7, 4, 1157899817));
				num = ⴄႤ[51];
				break;
			case 27:
				Ⴃ.Ⴃ.Add('n', ႨႨ.Ⴀ(6, 6, 1157899885));
				num = 31;
				break;
			case 31:
				Ⴃ.Ⴃ.Add('o', ႨႨ.Ⴀ(4, 8, 1157899838));
				num = 25;
				break;
			case 25:
				Ⴃ.Ⴃ.Add('p', ႨႨ.Ⴀ(11, 1, 1157899833));
				num = ⴄႷ[139] - 44092;
				break;
			case 34:
				Ⴃ.Ⴃ.Add('q', ႨႨ.Ⴀ(4, 3, 1157900224));
				num = ⴃႥ[326] - 9861;
				break;
			case 14:
				Ⴃ.Ⴃ.Add('r', ႨႨ.Ⴀ(3, 5, 1157900239));
				goto case 16;
			case 16:
				num = ⴐ[303] - 79;
				break;
			case 33:
				Ⴃ.Ⴃ.Add('s', ႨႨ.Ⴀ(9, 2, 1157900238));
				num = 28;
				break;
			case 28:
				Ⴃ.Ⴃ.Add('t', ReplyMailHelp.Ⴄ(18, null, 1057162115, 5));
				num = 8;
				break;
			case 8:
				Ⴃ.Ⴃ.Add('u', ႨႨ.Ⴀ(5, 3, 1157900245));
				num = 17;
				break;
			case 17:
				Ⴃ.Ⴃ.Add('v', ႨႨ.Ⴀ(4, 4, 1157900252));
				num = ⴀႳ[12] - 3797;
				break;
			case 4:
				Ⴃ.Ⴃ.Add('w', ႨႨ.Ⴀ(1, 2, 1157900257));
				num = ⴀႳ[57] - 52677;
				break;
			case 2:
				Ⴃ.Ⴃ.Add('x', ႨႨ.Ⴀ(7, 6, 1157900259));
				num = 3;
				break;
			case 3:
				Ⴃ.Ⴃ.Add('y', ႨႨ.Ⴀ(7, 3, 1157900271));
				num = ⴄႤ[513] - 240;
				break;
			case 9:
				Ⴃ.Ⴃ.Add('z', ႨႨ.Ⴀ(14, 5, 1157900274));
				num = 29;
				break;
			case 29:
				Ⴃ.Ⴃ.Add('1', ႨႨ.Ⴀ(12, 0, 1157900286));
				num = ⴄႭ[66];
				break;
			case 0:
				Ⴃ.Ⴃ.Add('2', ႨႨ.Ⴀ(0, 8, 1157900174));
				num = ⴍႤ[54] - 39895;
				break;
			case 38:
				Ⴃ.Ⴃ.Add('3', ႨႨ.Ⴀ(6, 5, 1157900171));
				num = 35;
				break;
			case 35:
				Ⴃ.Ⴃ.Add('4', ႨႨ.Ⴀ(11, 8, 1157900190));
				goto case 19;
			case 19:
				num = 37;
				break;
			case 37:
				Ⴃ.Ⴃ.Add('5', ႨႨ.Ⴀ(0, 8, 1157900182));
				num = 30;
				break;
			case 30:
				Ⴃ.Ⴃ.Add('6', ႨႨ.Ⴀ(13, 5, 1157900195));
				num = 7;
				break;
			case 7:
				Ⴃ.Ⴃ.Add('7', ႨႨ.Ⴀ(2, 1, 1157900207));
				num = ⴅ[433] - 105;
				break;
			case 23:
				Ⴃ.Ⴃ.Add('8', ႨႨ.Ⴀ(15, 3, 1157900213));
				num = 18;
				break;
			case 18:
				Ⴃ.Ⴃ.Add('9', ႨႨ.Ⴀ(0, 0, 1157900222));
				num = 21;
				break;
			case 21:
				Ⴃ.Ⴃ.Add('0', ႨႨ.Ⴀ(6, 0, 1157900102));
				return;
			}
		}
	}

	public string Translate(string word)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		while (true)
		{
			object obj = new ႨႳ();
			((ႨႳ)obj).Ⴍ = this;
			while (true)
			{
				IL_0055:
				(obj as ႨႳ).Ⴍ = new StringBuilder();
				while (true)
				{
					IL_0065:
					int num = ⴍႤ[147] - 17584;
					while (true)
					{
						switch (num)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							num = ⴃႰ[154] - 27300;
							continue;
						case 2:
						case 5:
							break;
						case 0:
							goto IL_0055;
						case 1:
							goto IL_0065;
						case 3:
							word.ToList().ForEach((obj as ႨႳ).Ⴅ);
							return UserCacheCfg.Ⴃ((object)(obj as ႨႳ).Ⴍ, 'ʹ', 722);
						}
						break;
					}
					break;
				}
				break;
			}
		}
	}
}
