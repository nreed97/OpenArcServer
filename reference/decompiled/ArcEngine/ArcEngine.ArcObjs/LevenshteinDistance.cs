using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcObjs;

public class LevenshteinDistance
{
	private static readonly ILog Ⴗ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(4, null, 1267016281, typeof(DirectoryOwn)), 168, 181);

	private static int Ⴄ(string P_0, string P_1)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		Array array = default(Array);
		int num5 = default(int);
		int num7 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num = CallBlockCacheCfg.Ⴜ(P_0, 198, 167);
			int num2 = CallBlockCacheCfg.Ⴜ(P_1, 490, 395);
			int num3 = ⴀႣ[186] - 23866;
			while (true)
			{
				int num8;
				int num9;
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = 21;
					continue;
				case 21:
					break;
				case 11:
					array = new int[num + 1, num2 + 1];
					num3 = ((num != 0) ? 22 : 7);
					continue;
				case 7:
					return num2;
				case 22:
					num3 = ((num2 != 0) ? (ⴐ[65] - 219) : (ⴐ[274] - 31));
					continue;
				case 15:
					return num;
				case 18:
					num5 = 0;
					num3 = 1;
					continue;
				case 16:
					(array as int[,])[num5, 0] = num5++;
					goto case 1;
				case 1:
				case 6:
					num3 = ((num5 <= num) ? 16 : 4);
					continue;
				case 4:
					num7 = 0;
					num3 = 10;
					continue;
				case 8:
					(array as int[,])[0, num7] = num7++;
					goto case 10;
				case 10:
					num3 = ((num7 <= num2) ? 8 : (ⴃႰ[163] - 18242));
					continue;
				case 2:
					num4 = 1;
					num3 = 14;
					continue;
				case 20:
					num6 = 1;
					num3 = 17;
					continue;
				case 0:
					num3 = (ByeHelp.Ⴍ(SetTalkOutputHelp.Ⴍ(P_1, num6 - 1, 1, 914, 961), SetTalkOutputHelp.Ⴍ(P_0, num4 - 1, 1, 457, 410), 844, 811) ? 24 : 5);
					continue;
				case 5:
					num8 = 1;
					goto IL_01ed;
				case 19:
				case 24:
					num8 = 0;
					goto IL_01ed;
				case 9:
					num6++;
					num3 = ⴃႥ[369] - 3593;
					continue;
				case 12:
				case 17:
					num3 = ((num6 > num2) ? 3 : 0);
					continue;
				case 3:
					num4++;
					num3 = ⴀႨ[45] - 15619;
					continue;
				case 14:
					num3 = ((num4 <= num) ? 20 : (ⴃႰ[105] - 25527));
					continue;
				case 13:
					{
						return ((int[,])array)[num, num2];
					}
					IL_01ed:
					num9 = num8;
					((int[,])array)[num4, num6] = ShowLogHelp.Ⴍ(ShowLogHelp.Ⴍ((array as int[,])[num4 - 1, num6] + 1, (array as int[,])[num4, num6 - 1] + 1, 674, 'ʓ'), (array as int[,])[num4 - 1, num6 - 1] + num9, 422, 'Ɨ');
					num3 = ⴃႠ[345] - 18100;
					continue;
				}
				break;
			}
		}
	}

	public static int Compute3(string s, string t)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int result = default(int);
		while (true)
		{
			int num = Ⴄ(s, t);
			while (true)
			{
				IL_0065:
				int num2 = 0;
				int num3 = ((CallBlockCacheCfg.Ⴜ(s, 221, 188) <= CallBlockCacheCfg.Ⴜ(t, 211, 178)) ? (ⴃႠ[46] - 40098) : (ⴀႳ[214] - 17003));
				while (true)
				{
					switch (num3)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num3 = ⴀ[226] - 13862;
						continue;
					case 4:
						break;
					case 1:
						goto IL_0065;
					case 6:
						num2 = CallBlockCacheCfg.Ⴜ(s, 978, 947);
						num3 = 0;
						continue;
					case 5:
						num2 = CallBlockCacheCfg.Ⴜ(t, 423, 454);
						num3 = ⴍႭ[281] - 23367;
						continue;
					case 0:
					case 3:
						return 100 - num * 100 / num2;
					case 2:
						return result;
					}
					break;
				}
				break;
			}
		}
	}
}
