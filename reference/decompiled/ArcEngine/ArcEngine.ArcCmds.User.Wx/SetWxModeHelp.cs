using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class SetWxModeHelp : IArcCmd
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴃ
	{
		internal PerformanceCounter Ⴃ;

		internal PerformanceCounter Ⴅ;
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(2, null, 1267017742, typeof(SunCalculations)));
				num = ⴃႠ[54] - 44883;
				break;
			case 6:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131691, 0, '\a'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(5, null, 1057165136, 3));
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(8, 'É', 952622984));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 8, 62057601, null));
				num = 0;
				break;
			case 0:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(7, 10, 1217944678));
				obj = new Publisher();
				goto case 3;
			case 3:
				num = ⴃႥ[111] - 24813;
				break;
			case 1:
			case 7:
				(obj as Publisher).Process(cmd);
				return;
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DxCommentExtCfg
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[2] - 23605;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 12;
					continue;
				case 11:
				case 12:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 80) ^ num) switch
					{
						0 => 2, 
						1 => ⴐ[162] - 32, 
						_ => ⴄႷ[70] - 5435, 
					};
					continue;
				case 4:
					result = true;
					num2 = ⴍႤ[304] - 58575;
					continue;
				case 2:
				case 3:
					result = P_0.SkimmerQuality;
					num2 = ⴐ[330] - 225;
					continue;
				case 9:
					result = P_0.SpotterCty;
					num2 = 10;
					continue;
				case 10:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 8;
				case 8:
					num2 = 7;
					continue;
				case 7:
					num2 = ((num3 % 2 != 0) ? 1 : (ⴃႥ[79] - 4223));
					continue;
				case 5:
					return result;
				case 0:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}
}
