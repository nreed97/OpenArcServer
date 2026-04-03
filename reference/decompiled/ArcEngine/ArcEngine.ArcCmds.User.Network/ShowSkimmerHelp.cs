using System;
using System.Data;
using System.Security;
using System.Xml.Serialization;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ShowSkimmerHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(8, null, 1267020292, typeof(global::_003CModule_003E)));
				num = 0;
				break;
			case 0:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134379, 6, 'ç'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(26, null, 1057162830, 8));
				num = 2;
				break;
			case 2:
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(2, 'ä', 952620566));
				obj = new Publisher();
				num = 1;
				break;
			case 1:
			case 5:
				(obj as Publisher).Process(cmd);
				BandModeCacheCfg.ႠႳ[316] = (char)((BandModeCacheCfg.ႠႳ[316] | BandModeCacheCfg.ႠႳ[262]) & 0x63);
				return;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DxCfg
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႤ[114] - 196;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 4:
				case 5:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 18) ^ num) switch
					{
						0 => 6, 
						_ => ⴀႼ[11] - 140, 
					};
					continue;
				case 10:
					obj = null;
					num2 = ⴄႭ[246];
					continue;
				case 6:
				case 7:
				case 8:
					obj = P_0.Filter;
					num2 = ⴀႨ[69] - 7590;
					continue;
				case 2:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 9 : (ⴍႭ[237] - 35375));
					continue;
				case 1:
					num2 = 11;
					continue;
				case 9:
					return obj as string;
				case 0:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴅ(int P_0, int P_1, char P_2)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int result = default(int);
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
					num2 = 2;
					continue;
				case 2:
					break;
				case 1:
				case 9:
					num2 = (((P_1 ^ P_2) - 62) ^ num) switch
					{
						0 => ⴍႭ[336] - 32778, 
						_ => 0, 
					};
					continue;
				case 0:
					result = 3;
					num2 = 10;
					continue;
				case 6:
					result = Math.Abs(P_0);
					num2 = ⴐ[302] - ⴐ[122];
					continue;
				case 8:
				case 10:
					num++;
					goto case 3;
				case 3:
				{
					int num3 = 600;
					int num4 = 17;
					num2 = ((150 < num3 / 4 - num4) ? (ⴃႠ[398] - 15616) : 5);
					continue;
				}
				case 5:
					return result;
				case 4:
					num2 = ⴐ[317] - ⴐ[109];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataTable Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : DataTable
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		IXmlSerializable xmlSerializable = default(IXmlSerializable);
		int num3 = default(int);
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 9:
					num2 = (((P_1 ^ P_2) - 106) ^ num) switch
					{
						0 => 0, 
						_ => ⴐ[271] / 9, 
					};
					continue;
				case 4:
					xmlSerializable = null;
					num2 = ⴀႨ[63] - 37864;
					continue;
				case 0:
					xmlSerializable = P_0.Clone();
					num2 = ⴐ[21];
					continue;
				case 2:
				case 3:
				case 7:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					goto case 11;
				case 11:
					num2 = ⴍႭ[95] - 30656;
					continue;
				case 8:
					num2 = ((num3 % 2 != 0) ? (ⴍႤ[417] - 41790) : (ⴍႤ[60] - 25046));
					continue;
				case 1:
					return xmlSerializable as DataTable;
				case 5:
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}
}
