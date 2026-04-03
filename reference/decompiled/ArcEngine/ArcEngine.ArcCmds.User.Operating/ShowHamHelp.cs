using System;
using System.Data.Common;
using System.Security;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowHamHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 6;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267018209, typeof(DxSpotPc26)));
				num = ⴄႤ[222] - 183;
				break;
			case 0:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131724, 3, '\u00b4'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(9, null, 1057164974, 1));
				goto case 2;
			case 2:
				num = 3;
				break;
			case 3:
			case 4:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(5, '\t', 952620894));
				obj = new Publisher();
				goto case 1;
			case 1:
				num = ⴀႳ[191] - 60326;
				break;
			case 5:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, short P_3) where _0021_00210 : string where _0021_00211 : WwvSpot
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႣ[380] - 26116;
				break;
			case 7:
				num = (((P_2 ^ P_3) - 39) ^ num2) switch
				{
					0 => ⴄႷ[50] - 56637, 
					1 => 0, 
					_ => ⴃႠ[165] - 47294, 
				};
				break;
			case 1:
				num = 10;
				break;
			case 2:
			case 6:
				P_0.Sfi = P_1;
				num = 10;
				break;
			case 0:
				P_0.DeserializeNode(P_1);
				goto case 10;
			case 10:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 9 : (ⴍႭ[239] - 12404));
				break;
			case 4:
				num = 7;
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, short P_3) where _0021_00210 : string where _0021_00211 : Type
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		object result = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
					break;
				case 0:
					num2 = (((P_2 ^ P_3) - 126) ^ num) switch
					{
						0 => 8, 
						_ => 10, 
					};
					continue;
				case 10:
					result = null;
					num2 = 9;
					continue;
				case 8:
					result = BaseXmlSerializer.LoadFromFile(P_0, P_1);
					num2 = ⴄႭ[294] - 167;
					continue;
				case 9:
					num++;
					num3 = P_2 * P_2;
					goto case 11;
				case 11:
					num3 = P_2 + num3;
					goto case 6;
				case 6:
					num2 = 2;
					continue;
				case 2:
					num2 = ((num3 % 2 != 0) ? (ⴍႤ[124] - 46685) : ⴄႭ[94]);
					continue;
				case 7:
					return result;
				case 1:
				case 4:
					num2 = ⴃႥ[146] - ⴃႥ[146];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ(short P_0, char P_1)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 10;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႠ[67] - 9302;
					continue;
				case 7:
					break;
				case 10:
					num2 = (((P_0 ^ P_1) - 2) ^ num) switch
					{
						0 => ⴄႤ[189] - ⴄႤ[180], 
						_ => 3, 
					};
					continue;
				case 3:
				case 6:
					comparable = null;
					num2 = ⴀႳ[236] - 22361;
					continue;
				case 0:
					comparable = UtilsWeb.GetMyIpAddress();
					num2 = ⴍႭ[347] - 58767;
					continue;
				case 4:
					num++;
					num3 = 21;
					num4 = 1019;
					goto case 5;
				case 5:
					num2 = ((9171 > num4 - num3 * 9) ? (ⴀႼ[31] - 128) : 11);
					continue;
				case 8:
				case 11:
					num2 = 10;
					continue;
				case 1:
					return (string)comparable;
				case 9:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴐ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, char P_3) where _0021_00210 : string where _0021_00211 : DbCommand
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 2;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 1;
				break;
			case 1:
				num = (((P_2 ^ P_3) - 2) ^ num3) switch
				{
					0 => ⴐ[243], 
					_ => ⴀႼ[80] * 3, 
				};
				break;
			case 0:
				num = 3;
				break;
			case 8:
				P_0.CommandText = P_1;
				goto case 3;
			case 3:
			case 5:
			case 7:
			case 9:
			{
				num3++;
				num2 = P_2 * P_2;
				int num4 = num2;
				TxNodeUserCmd.ႤႷ[97] = (char)((TxNodeUserCmd.ႤႷ[97] + BandModeCacheCfg.ႠႳ[64]) & 0xD9);
				num2 = P_2 + num4;
				num = 4;
				break;
			}
			case 4:
				num = ((num2 % 2 != 0) ? 1 : (ⴄႭ[576] - 90));
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : StationCfg where _0021_00211 : string
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 8;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 7;
				break;
			case 4:
			case 7:
				num = (((P_3 ^ P_2) - 127) ^ num3) switch
				{
					0 => 1, 
					_ => ⴃႠ[204] - 17768, 
				};
				break;
			case 0:
			case 3:
				num = ⴀႨ[99] - 1051;
				break;
			case 1:
				P_0.Email = P_1;
				goto case 9;
			case 9:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				goto case 6;
			case 6:
				num = ⴍႤ[494] - 40465;
				break;
			case 2:
				num = ((num2 % 2 != 0) ? (ⴃႰ[58] - 19217) : 5);
				break;
			case 5:
				return;
			}
		}
	}
}
