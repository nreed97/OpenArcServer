using System;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;

namespace Ⴈ;

internal sealed class ႰႣ : IEquatable<string>
{
	internal string Ⴓ = string.Empty;

	internal string Ⴗ = string.Empty;

	internal bool Ⴃ(string P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		while (true)
		{
			int num = SetStationLoginCmds.Ⴓ(P_0, ႨႨ.Ⴀ(9, 5, 1157902497), '\u009c', 178);
			int num2 = ⴃႰ[139] - 40023;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႠ[404] - 53569;
					continue;
				case 7:
					break;
				case 4:
					num2 = ((num <= 0) ? 5 : (ⴀႣ[263] - 56179));
					continue;
				case 6:
				case 9:
					Ⴓ = SetTalkOutputHelp.Ⴍ(P_0, 0, num, 261, 342);
					Ⴗ = Clear.Ⴄ(P_0, num + 1, 'İ', 'Ę');
					num2 = 1;
					continue;
				case 1:
				case 3:
					Ⴗ = SetTalkDefault.Ⴃ(Ⴗ, 517, 'ȩ');
					Ⴗ = ShowContestStationHelp.Ⴅ(Ⴗ, SetTalkCount.Ⴗ(8, null, 1267022539, typeof(SetAnnOutput)), string.Empty, 933, 'Ͻ');
					num2 = 10;
					continue;
				case 10:
					Ⴗ = ShowWxHelp.Ⴍ('<', 985808778, 7) + Ⴗ + ShowWxHelp.Ⴍ('6', 985808783, 2);
					num2 = ⴃႠ[49] - ⴃႠ[49];
					continue;
				case 0:
					return true;
				case 5:
					return false;
				}
				break;
			}
		}
	}

	public bool Equals(string P_0)
	{
		return ByeHelp.Ⴍ(Ⴓ, P_0, 462, 425);
	}
}
