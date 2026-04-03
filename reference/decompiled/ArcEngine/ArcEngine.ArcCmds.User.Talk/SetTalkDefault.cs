using System;
using System.IO;
using System.Security;
using ArcEngine.ArcCmds.NodeProcessor;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Talk;

public sealed class SetTalkDefault : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 6;
			case 6:
			{
				SetStationMacrosHelp.Ⴃ(NodeCmdCfg.Ⴗ(cmd.Ⴍ().Cfg, 1002, 928), OutputType.On, 'ų', 'İ');
				byte num2 = ⴄႤ[157];
				TxNodeUserCmd.ႤႷ[43] = (char)((TxNodeUserCmd.ႤႷ[43] - TxNodeUserCmd.ႤႷ[47]) & 0xE3);
				num = num2 - 79;
				continue;
			}
			case 4:
				MailCacheCfg.Ⴗ(NodeCmdCfg.Ⴗ(cmd.Ⴍ().Cfg, 620, 550), 10, 'Ĥ', 277);
				num = 3;
				continue;
			case 3:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(5, 15, 1217941810));
				obj = new ShowTalkOptions();
				num = 0;
				continue;
			case 0:
				((ShowTalkOptions)obj).Exec(cmd);
				break;
			case 1:
			case 5:
				break;
			}
			break;
		}
		object obj2 = new Publisher();
		((Publisher)obj2).Process(cmd);
	}

	[SecuritySafeCritical]
	internal static string Ⴅ(char P_0, short P_1)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႨ[182] - 13137;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 7:
					break;
				case 10:
					num2 = (((P_0 ^ P_1) - 38) ^ num) switch
					{
						0 => 5, 
						_ => 1, 
					};
					continue;
				case 1:
					obj = null;
					goto case 9;
				case 9:
					num2 = ⴐ[73] - 221;
					continue;
				case 5:
					obj = UtilsPerformance.GetAppPerformance();
					num2 = ⴀႳ[170] - 10003;
					continue;
				case 0:
				case 2:
					num++;
					num2 = (((P_0 * P_0 + P_0) % 2 == 0) ? (ⴄႤ[427] - 148) : (ⴍႭ[262] - 50121));
					continue;
				case 6:
					num2 = 10;
					continue;
				case 3:
				case 4:
					return obj as string;
				case 8:
					num2 = ⴍႤ[392] - 10969;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : string
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႤ[144] / 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 43) ^ num) switch
					{
						0 => ⴃႠ[52] - 36459, 
						1 => 9, 
						2 => ⴃႰ[32] - 1110, 
						3 => 6, 
						_ => 10, 
					};
					continue;
				case 10:
					cloneable = null;
					num2 = 2;
					continue;
				case 0:
					cloneable = UtilsString.ScrubKey(P_0);
					num2 = ⴀႼ[113];
					continue;
				case 9:
				case 13:
					cloneable = UtilsString.ScrubSpaces(P_0);
					num2 = 2;
					continue;
				case 12:
					cloneable = UtilsString.RemoveStartAndEndCommas(P_0);
					num2 = ⴄႭ[246];
					continue;
				case 5:
				case 6:
					cloneable = UtilsString.AdjustForBackspace(P_0);
					num2 = ⴀႳ[8] - 32496;
					continue;
				case 2:
				{
					num++;
					int num3 = 2100;
					int num4 = 237;
					num2 = ((525 < num3 / 4 - num4) ? (ⴄႭ[125] - 37) : 8);
					continue;
				}
				case 8:
					return (string)cloneable;
				case 1:
				case 4:
					num2 = ⴄႤ[433] - 204;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴈ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : FileSystemInfo
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		bool result = default(bool);
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
					num2 = ⴄႤ[170] - 209;
					continue;
				case 3:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 123) ^ num) switch
					{
						0 => ⴄႤ[114] - 205, 
						_ => 8, 
					};
					continue;
				case 8:
					result = true;
					num2 = 9;
					continue;
				case 2:
				case 7:
					result = P_0.Exists;
					num2 = 9;
					continue;
				case 4:
				case 9:
				{
					num++;
					int num3 = 1702;
					int num4 = 429;
					num2 = ((851 < num3 / 2 - num4) ? (ⴄႷ[38] - 46343) : (ⴍႤ[140] - 51172));
					continue;
				}
				case 1:
				case 5:
					return result;
				case 10:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}
}
