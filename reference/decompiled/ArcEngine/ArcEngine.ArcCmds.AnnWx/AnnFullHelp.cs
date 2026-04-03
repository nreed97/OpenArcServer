using System;
using System.Collections;
using System.Data.Common;
using System.Security;
using System.Xml;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.AnnWx;

public sealed class AnnFullHelp : IArcCmd
{
	internal sealed class Ⴄ
	{
		internal ႨႤ Ⴍ;

		internal Ⴄ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(0, null, 1267019235, typeof(PublishInfo)));
				num = 5;
				break;
			case 5:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132871, 0, 'n'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(20, null, 1057164433, 5));
				goto case 1;
			case 1:
				num = ⴀႼ[113];
				break;
			case 2:
			case 4:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static XmlNode Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : XmlNode
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		IEnumerable enumerable = default(IEnumerable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[204];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႣ[23] - 53184;
					continue;
				case 2:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 34) ^ num) switch
					{
						0 => 5, 
						_ => ⴀႣ[301] - 4348, 
					};
					continue;
				case 7:
					enumerable = null;
					num2 = 10;
					continue;
				case 5:
				case 9:
					enumerable = P_0.FirstChild;
					num2 = 10;
					continue;
				case 10:
					num++;
					num3 = 1629;
					goto case 8;
				case 8:
				{
					int num4 = 334;
					num2 = ((543 < num3 / 3 - num4) ? 6 : 3);
					continue;
				}
				case 3:
					return enumerable as XmlNode;
				case 1:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00211 : DbParameter
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႥ[32] - 37171;
				break;
			case 4:
				num = (((P_2 ^ P_3) - 87) ^ num2) switch
				{
					0 => 8, 
					_ => ⴐ[189] - 123, 
				};
				break;
			case 1:
				num = 0;
				break;
			case 8:
				P_0.Value = P_1;
				goto case 0;
			case 0:
			{
				num2++;
				int num3 = 86;
				int num4 = 133;
				num = ((399 > num4 - num3 * 3) ? (ⴀႼ[33] / 3) : 7);
				break;
			}
			case 6:
			case 7:
				num = 4;
				break;
			case 2:
			case 3:
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2, int P_3) where _0021_00210 : WwvCfg
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				break;
			case 6:
				num = (((P_2 ^ P_3) - 109) ^ num2) switch
				{
					0 => 8, 
					_ => ⴄႷ[68] - 14170, 
				};
				break;
			case 1:
				num = 0;
				break;
			case 3:
			case 8:
				P_0.NmbrSpots = P_1;
				goto case 0;
			case 0:
				num2++;
				goto case 4;
			case 4:
			case 9:
			{
				int num3 = 354;
				int num4 = 495;
				num = ((3465 > num4 - num3 * 7) ? 5 : (ⴍႭ[18] - 56760));
				break;
			}
			case 7:
				num = 6;
				break;
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, char[] P_1, int P_2, char P_3) where _0021_00210 : string
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		IComparable comparable = default(IComparable);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[78] - 48375;
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
				case 5:
					num2 = (((P_2 ^ P_3) - 19) ^ num) switch
					{
						0 => ⴀႣ[182] - 39496, 
						_ => 3, 
					};
					continue;
				case 3:
					comparable = null;
					num2 = 10;
					continue;
				case 9:
					comparable = P_0.TrimEnd(P_1);
					num2 = 10;
					continue;
				case 10:
				case 11:
				{
					num++;
					int num3 = 327;
					int num4 = 349;
					num2 = ((2094 > num4 - num3 * 6) ? 6 : 2);
					continue;
				}
				case 2:
					num2 = ⴀႨ[83] - 31170;
					continue;
				case 6:
				case 8:
					return comparable as string;
				case 4:
					num2 = ⴀႼ[136];
					continue;
				}
				break;
			}
		}
	}
}
