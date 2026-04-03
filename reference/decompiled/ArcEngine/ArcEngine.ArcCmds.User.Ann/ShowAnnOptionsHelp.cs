using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class ShowAnnOptionsHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(3, null, 1267016838, typeof(ArcWebService)));
				goto case 4;
			case 4:
				num = 5;
				break;
			case 5:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129865, 0, '\u00a8'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(6, null, 1057165378, 6));
				num = ⴅ[137] - 48;
				break;
			case 1:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(1, 2, 1217945181));
				obj = new Publisher();
				num = 0;
				break;
			case 0:
				(obj as Publisher).Process(cmd);
				return;
			case 3:
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DxCfg Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : ArcUserCfg
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		object obj = default(object);
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
					num2 = 4;
					continue;
				case 4:
					break;
				case 6:
					num2 = (((P_1 ^ P_2) - 122) ^ num) switch
					{
						0 => 5, 
						_ => ⴃႥ[122] - 48753, 
					};
					continue;
				case 3:
					obj = null;
					num2 = ⴀႨ[60] - 55452;
					continue;
				case 5:
				case 9:
					obj = P_0.Dx;
					num2 = 7;
					continue;
				case 2:
				case 7:
				{
					num++;
					int num3 = 1344;
					int num4 = 121;
					num2 = ((672 < num3 / 2 - num4) ? (ⴀႣ[254] - 29335) : 8);
					continue;
				}
				case 0:
				case 8:
					return (DxCfg)obj;
				case 10:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210>(ref DateTime P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : string
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		ICloneable cloneable = default(ICloneable);
		int num3 = default(int);
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
					num2 = 2;
					continue;
				case 2:
					break;
				case 8:
					num2 = (((P_2 ^ P_3) - 4) ^ num) switch
					{
						0 => ⴃႠ[345] - 18099, 
						_ => ⴍႭ[153] - 64903, 
					};
					continue;
				case 6:
					cloneable = null;
					goto case 5;
				case 5:
					num2 = ⴀႨ[212] - 27975;
					continue;
				case 10:
					cloneable = P_0.ToString(P_1);
					num2 = ⴅ[125] / 9;
					continue;
				case 3:
					num++;
					goto case 9;
				case 9:
					num3 = 185;
					goto case 7;
				case 7:
				{
					int num4 = 899;
					num2 = ((3596 > num4 - num3 * 4) ? 11 : ⴄႭ[66]);
					continue;
				}
				case 0:
					num2 = 8;
					continue;
				case 11:
					return (string)cloneable;
				case 4:
					num2 = ⴀႼ[90] - 128;
					continue;
				}
				break;
			}
		}
	}
}
