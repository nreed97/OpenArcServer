using System;
using System.IO;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowPrefixCalls
{
	private static void Ⴍ(NodeUserCmd P_0)
	{
		int num = 1;
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 4:
				obj = new ShowPrefixCallsHelp();
				goto case 3;
			case 3:
				(obj as ShowPrefixCallsHelp).Exec(P_0);
				obj2 = new Publisher();
				break;
			case 0:
				break;
			case 2:
				return;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(12, 0, 1157903447), P_0.Rx.Msg, 469, 411));
			num = 4;
		}
		((Publisher)obj2).Process(P_0);
		Arc4ServerClient.ႠႣ[269] = (char)((Arc4ServerClient.ႠႣ[269] ^ IpLockoutCacheCfg.ႭႭ[355]) & 0x7E);
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		try
		{
			int num = 4;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length < 3) ? 2 : (ⴄႭ[172] - ⴄႭ[85]));
					continue;
				case 5:
				{
					ICloneable msgEnd = cmd.Rx.GetMsgEnd(3);
					obj = cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႷ()
						.CtyInfoFromCall(SetDxFilter.Ⴀ((string)msgEnd, 309, 'Ŵ'));
					num = 6;
					continue;
				}
				case 3:
				case 6:
				case 7:
					num = ((!(obj is CtyInfo)) ? ⴐ[243] : 0);
					continue;
				case 0:
					cmd.Tx.Msg.Add(qslinfoResponse.Ⴗ(CallBlockCacheCfg.Ⴅ(null, 5, 62056860, null), SetDxOutput.Ⴓ((CtyInfo)obj, 516, 563), ReplyMail.Ⴅ(1, 12, 1217943667), qslinfoSoapClient.Ⴈ(obj as CtyInfo, '\u0325', 828), 663, '\u02f4'));
					num = 8;
					continue;
				case 2:
					Ⴍ(cmd);
					break;
				case 1:
				case 8:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴍ(cmd);
		}
		switch (4)
		{
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210, _0021_00211, _0021_00212>(_0021_00210 P_0, _0021_00211 P_1, _0021_00212 P_2, char P_3, int P_4)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		IComparable comparable = default(IComparable);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႥ[52] - 46689;
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
				case 10:
				{
					int num6;
					switch (((P_4 ^ P_3) - 42) ^ num)
					{
					default:
						num6 = 9;
						break;
					case 0:
					{
						char num5 = ⴃႠ[370];
						SetAnnMode.ႤႭ[561] = (byte)((SetAnnMode.ႤႭ[561] | SetDxCountHelp.ႭႤ[438]) & 0xD9);
						num6 = num5 - 30101;
						break;
					}
					}
					num2 = num6;
					continue;
				}
				case 9:
					comparable = null;
					num2 = 5;
					continue;
				case 7:
					comparable = string.Concat(P_0, P_1, P_2);
					num2 = 5;
					continue;
				case 5:
				{
					num++;
					int num3 = 833;
					int num4 = 962;
					num2 = ((6734 > num4 - num3 * 7) ? (ⴀႨ[7] - 41576) : 11);
					continue;
				}
				case 11:
					num2 = ⴃႠ[85] - 16993;
					continue;
				case 2:
				case 4:
					return comparable as string;
				case 0:
				case 3:
				case 8:
					num2 = ⴍႭ[43] - 57282;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, bool P_2, char P_3, int P_4) where _0021_00210 : string where _0021_00211 : string
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႼ[113] + ⴀႼ[96];
				continue;
			case 6:
				num = (((P_3 ^ P_4) - 98) ^ num2) switch
				{
					0 => ⴀႼ[136], 
					_ => ⴄႷ[71] - 34098, 
				};
				continue;
			case 0:
			case 4:
				num = 3;
				continue;
			case 5:
				File.Copy(P_0, P_1, P_2);
				goto case 2;
			case 2:
			case 3:
				num2++;
				break;
			case 7:
				break;
			case 1:
				return;
			}
			int num3 = 1108;
			int num4 = 260;
			num = ((277 >= num3 / 4 - num4) ? 1 : (ⴅ[369] + 5));
		}
	}
}
