using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Ui;
using HtmlAgilityPack;

namespace Ⴈ;

internal static class ႷႤ
{
	public static void Ⴈ()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 3;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			switch (num)
			{
			default:
			{
				_Assembly assembly = ShowLog.Ⴍ(254, 'ö');
				equatable = SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(assembly as Assembly, 804, 838), 728, 'ˍ') + CallBlockCacheCfg.Ⴅ(null, 4, 62055025, null);
				break;
			}
			case 4:
				break;
			case 0:
			case 1:
				Ⴃ(equatable as string);
				Ⴅ(equatable as string);
				return;
			case 2:
				return;
			}
			num = ⴃႰ[108] - 48237;
		}
	}

	private static void Ⴃ(string P_0)
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				P_0 = ShowUsersHelp.Ⴅ(P_0, SetStationQth.Ⴍ(null, 1687352287, 7, 2), 764, 690);
				num = 2;
				break;
			case 2:
				num = ((!LogCacheCfg.Ⴗ(P_0, 478, 478)) ? 1 : 3);
				break;
			case 1:
			case 6:
				Ⴀ(P_0);
				return;
			case 3:
			case 5:
				return;
			}
		}
	}

	private static void Ⴅ(string P_0)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				P_0 = ShowUsersHelp.Ⴅ(P_0, SetStationQth.Ⴍ(null, 1687354015, 8, 6), 751, 673);
				goto case 1;
			case 1:
			case 6:
				num = 4;
				break;
			case 4:
				num = ((!LogCacheCfg.Ⴗ(P_0, 598, 598)) ? 5 : 0);
				break;
			case 5:
				Ⴓ(P_0);
				return;
			case 0:
				return;
			}
		}
	}

	private static void Ⴀ(string P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 6;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new StreamWriter(P_0);
				SetStationBeep.Ⴄ((TextWriter)(obj as StreamWriter), ႨႨ.Ⴀ(5, 4, 1157905360), 954, 953);
				num = 5;
				break;
			case 5:
				SetStationBeep.Ⴄ((TextWriter)(obj as StreamWriter), ShowWxHelp.Ⴍ(')', 985806189, 5), 597, 598);
				num = ⴅ[210] / 8;
				break;
			case 0:
			case 1:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)obj, SetTalkCount.Ⴗ(1, null, 1267016333, typeof(V4NodeParser)), 895, 892);
				num = ⴀႣ[228] - 55260;
				break;
			case 2:
			case 4:
				(obj as StreamWriter).WriteLine(ႨႨ.Ⴀ(1, 3, 1157905367));
				(obj as StreamWriter).Close();
				return;
			}
		}
	}

	private static void Ⴓ(string P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 2;
		TextWriter textWriter = default(TextWriter);
		while (true)
		{
			switch (num)
			{
			default:
				textWriter = new StreamWriter(P_0);
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), ႨႨ.Ⴀ(11, 8, 1157905372), 967, 964);
				num = 5;
				continue;
			case 4:
			case 5:
				SetStationBeep.Ⴄ((TextWriter)(textWriter as StreamWriter), SetTalkCount.Ⴗ(4, null, 1267016542, typeof(PCxx)), 742, 741);
				num = ⴄႤ[3] - 111;
				continue;
			case 0:
				SetStationBeep.Ⴄ((TextWriter)(StreamWriter)textWriter, ShowSkimCtyHelp.Ⴍ(1216133104, 3, 'ß'), 426, 425);
				num = 1;
				continue;
			case 1:
			case 6:
				(textWriter as StreamWriter).WriteLine(ႨႨ.Ⴀ(0, 0, 1157905364));
				break;
			case 3:
				break;
			}
			break;
		}
		(textWriter as StreamWriter).Close();
	}

	[SecuritySafeCritical]
	internal static HtmlNodeCollection Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string where _0021_00211 : HtmlNode
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		IEnumerable<HtmlNode> enumerable = default(IEnumerable<HtmlNode>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႨ[142] - 64996;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 10:
					break;
				case 11:
					num2 = (((P_3 ^ P_2) - 125) ^ num) switch
					{
						0 => 2, 
						_ => ⴄႭ[479] - 192, 
					};
					continue;
				case 3:
				case 9:
					enumerable = null;
					num2 = 8;
					continue;
				case 2:
					enumerable = P_0.SelectNodes(P_1);
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 5;
				case 5:
					num2 = 0;
					continue;
				case 0:
					num2 = ((num3 % 2 == 0) ? 1 : 11);
					continue;
				case 1:
					return enumerable as HtmlNodeCollection;
				case 4:
				case 7:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, int P_3) where _0021_00210 : StatusBarData
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 6;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႰ[150] - 63821;
				continue;
			case 8:
				num = (((P_3 ^ P_2) - 87) ^ num2) switch
				{
					0 => 3, 
					_ => ⴃႰ[119] - 43554, 
				};
				continue;
			case 4:
				num = ⴀ[265] - 41620;
				continue;
			case 3:
				P_0.DxRate = P_1;
				goto case 7;
			case 7:
				num2++;
				num3 = 314;
				goto case 5;
			case 5:
				num4 = 143;
				break;
			case 1:
				break;
			case 0:
			case 2:
				return;
			}
			num = ((157 < num3 / 2 - num4) ? (ⴄႭ[570] - 176) : 2);
		}
	}
}
