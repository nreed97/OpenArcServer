using System;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ExtensionMethods;
using Ⴈ;

namespace ArcEngine.ArcCmds.AnnWx;

public sealed class WxFullHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267022057, typeof(SkimmerBandProcessor)));
				num = 1;
				break;
			case 1:
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133904, 6, 'S'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(5, null, 1057161864, 5));
				goto case 0;
			case 0:
			case 3:
				num = 5;
				break;
			case 5:
			{
				object obj = new Publisher();
				(obj as Publisher).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴐ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : WwvSpot
	{
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 2:
				case 4:
					num2 = (((P_1 ^ P_2) - 97) ^ num) switch
					{
						0 => 6, 
						_ => 7, 
					};
					continue;
				case 7:
					equatable = null;
					num2 = 8;
					continue;
				case 5:
				case 6:
					equatable = P_0.SerializeNode();
					num2 = 8;
					continue;
				case 8:
					num++;
					goto case 9;
				case 9:
					num2 = (((P_1 * P_1 + P_1) % 2 != 0) ? 1 : 0);
					continue;
				case 1:
					num2 = 2;
					continue;
				case 0:
					return (string)equatable;
				case 11:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : Letter
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = 11;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႤ[538] - ⴄႤ[77];
					continue;
				case 2:
				case 6:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 10) ^ num) switch
					{
						0 => ⴐ[20] - 221, 
						1 => ⴃႥ[401] - 25396, 
						_ => 10, 
					};
					continue;
				case 10:
					convertible = null;
					goto case 4;
				case 4:
					num2 = ⴄႭ[66];
					continue;
				case 9:
					convertible = P_0.ToNode;
					num2 = 0;
					continue;
				case 3:
					convertible = P_0.Subject;
					num2 = 0;
					continue;
				case 0:
					num++;
					goto case 1;
				case 1:
				{
					int num3 = 530;
					int num4 = 135;
					num2 = ((265 < num3 / 2 - num4) ? ⴅ[92] : (ⴀႳ[287] - 59540));
					continue;
				}
				case 8:
					return (string)convertible;
				case 5:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : AnnWxSpot
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = 9;
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
				case 9:
					num2 = (((P_1 ^ P_2) - 68) ^ num) switch
					{
						0 => 1, 
						_ => ⴀႨ[53] - 8345, 
					};
					continue;
				case 5:
					cloneable = null;
					num2 = 7;
					continue;
				case 1:
					cloneable = P_0.SpotterNode;
					num2 = ⴍႤ[189] - 29616;
					continue;
				case 7:
					num++;
					goto case 3;
				case 3:
				case 10:
				{
					int num3 = 1788;
					int num4 = 353;
					int num5;
					if (447 >= num3 / 4 - num4)
					{
						num5 = ⴅ[20] / 5;
					}
					else
					{
						char num6 = ⴍႭ[347];
						ShowQrzHelp.ႤႤ[128] = (byte)((ShowQrzHelp.ႤႤ[128] - IpLockoutCacheCfg.ႭႭ[263]) & 0x97);
						num5 = num6 - 58762;
					}
					num2 = num5;
					continue;
				}
				case 2:
					return cloneable as string;
				case 4:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}
}
