using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces.Spots;
using ArcShared.ExtensionMethods;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class ShowDxOptionsHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(1, null, 1267020199, typeof(qslinfoRequestBody)));
				num = 5;
				break;
			case 5:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134667, 1, '\u001e'));
				goto case 0;
			case 0:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(23, null, 1057164184, 8));
				num = ⴃႰ[147] - 1280;
				break;
			case 2:
			case 4:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 2, 62057761, null));
				num = ⴍႭ[282] - 33566;
				break;
			case 3:
			case 6:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				ႨႣ.Ⴐ[174] = (byte)(ႨႣ.Ⴐ[174] & ႨႣ.Ⴐ[299] & 0xCC);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : string where _0021_00211 : DxSpot
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 4;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴀႳ[262] - 23915;
				break;
			case 6:
				num = (((P_2 ^ P_3) - 106) ^ num3) switch
				{
					0 => ⴀႳ[148] - 39098, 
					1 => 10, 
					2 => ⴐ[224] - 240, 
					_ => 3, 
				};
				break;
			case 3:
				num = 1;
				break;
			case 7:
			case 8:
			case 9:
				P_0.Spotter = P_1;
				num = ⴃႠ[372] - 55040;
				break;
			case 10:
				P_0.Cont = P_1;
				num = 1;
				break;
			case 2:
			case 5:
				P_0.DeserializeNode(P_1);
				goto case 1;
			case 1:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = ⴀႼ[96] + 7;
				break;
			case 11:
				num = ((num2 % 2 != 0) ? (ⴃႥ[23] - 11491) : (ⴀႣ[119] - 39466));
				break;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210>(ref float P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		IEquatable<string> equatable = default(IEquatable<string>);
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
					num2 = 8;
					continue;
				case 8:
					break;
				case 2:
					num2 = (((P_3 ^ P_2) - 2) ^ num) switch
					{
						0 => ⴀႳ[170] - 10001, 
						_ => 11, 
					};
					continue;
				case 11:
					equatable = null;
					goto case 1;
				case 1:
				case 3:
					num2 = ⴄႭ[520] - 132;
					continue;
				case 4:
					equatable = P_0.ToString(P_1);
					num2 = 9;
					continue;
				case 9:
				{
					num++;
					int num3 = 449;
					int num4 = 705;
					num2 = ((7050 > num4 - num3 * 10) ? ⴐ[254] : (ⴀႼ[57] - 159));
					continue;
				}
				case 6:
					num2 = 2;
					continue;
				case 0:
					return (string)equatable;
				case 10:
					num2 = ⴀႼ[113];
					continue;
				}
				break;
			}
		}
	}
}
