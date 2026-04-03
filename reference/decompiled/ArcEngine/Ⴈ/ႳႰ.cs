using System;
using System.Net;
using System.Runtime.CompilerServices;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using log4net;

namespace Ⴈ;

internal sealed class ႳႰ
{
	private static readonly ILog Ⴗ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216130213, 5, '2'), 898, 927);

	private long m_Ⴀ;

	[SpecialName]
	internal long Ⴄ()
	{
		long ⴀ = this.m_Ⴀ;
		SetAnnChatRooms.Ⴀ[178] = (char)((SetAnnChatRooms.Ⴀ[178] | SetAnnChatRooms.Ⴀ[269]) & 0x7A);
		return ⴀ;
	}

	[SpecialName]
	internal void Ⴅ(long P_0)
	{
		this.m_Ⴀ = P_0;
	}

	internal string Ⴀ()
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		object obj = new WebClient();
		object obj2 = ShowPrefixCalls.Ⴃ((object)ReplyMail.Ⴅ(0, 8, 1217940898), (object)Ⴄ(), (object)ShowSkimCtyHelp.Ⴍ(1216130184, 1, '\u0006'), 'Η', 957);
		object obj5 = default(object);
		try
		{
			int num = 5;
			object obj4 = default(object);
			object obj3;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					obj4 = SetStationGrid.Ⴀ(obj as WebClient, obj2 as string, 'ϰ', 1023);
					goto case 1;
				case 1:
				case 3:
					num2 = (ႰႨ.ႥႥ((string)obj4, 'ʵ', 'ʓ') ? 2 : (ⴀ[149] - 54918));
					goto IL_00dc;
				case 4:
					obj3 = obj4 as string;
					break;
				case 2:
					obj3 = null;
					break;
				}
				break;
				IL_00dc:
				num = num2;
			}
			obj5 = obj3;
		}
		catch (Exception ex)
		{
			Ⴗ.Warn(ReplyMailHelp.Ⴄ(30, null, 1057166873, 3) + ex.Message);
			goto IL_011b;
		}
		goto IL_013b;
		IL_011b:
		switch (3)
		{
		default:
			return null;
		case 0:
		case 1:
		case 2:
		case 4:
			break;
		}
		goto IL_013b;
		IL_013b:
		return (string)obj5;
	}
}
