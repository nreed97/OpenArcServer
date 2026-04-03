using System;
using System.Data;
using System.Data.Common;
using System.Security;
using ArcEngine.ArcCaches;
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
using ArcInterfaces;
using ArcInterfaces.Spots;
using ArcShared;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public sealed class ShowDxFilter : IArcCmd
{
	private static void Ⴃ(NodeUserCmd P_0)
	{
		int num = 3;
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 0:
			case 1:
			{
				object obj = new ShowDxFilterHelp();
				((ShowDxFilterHelp)obj).Exec(P_0);
				obj2 = new Publisher();
				break;
			}
			case 2:
				break;
			case 4:
				return;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(9, 3, 1157905537), P_0.Rx.Msg, 613, 555));
			num = 0;
		}
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		try
		{
			int num = 1;
			IArcCmd arcCmd = default(IArcCmd);
			while (true)
			{
				switch (num)
				{
				case 4:
				case 5:
					(arcCmd as ShowDxOptions).Exec(cmd);
					goto end_IL_0002;
				case 2:
					goto end_IL_0002;
				}
				arcCmd = new ShowDxOptions();
				cmd.Rx.Msg = SetTalkCount.Ⴗ(6, null, 1267021587, typeof(SkimmerCt1bohCache.SkimmerQualityType));
				num = 4;
				continue;
				end_IL_0002:
				break;
			}
		}
		catch (Exception)
		{
			Ⴃ(cmd);
		}
		switch (1)
		{
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴄ<_0021_00210, _0021_00211, _0021_00212>(_0021_00211 P_0, _0021_00212 P_1, _0021_00210 P_2, char P_3, char P_4) where _0021_00210 : string where _0021_00211 : DbDataAdapter where _0021_00212 : DataSet
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႷ[141] - 32626;
					continue;
				case 4:
					break;
				case 1:
				case 11:
					num2 = (((P_3 ^ P_4) - 90) ^ num) switch
					{
						0 => ⴍႤ[267] - 50387, 
						_ => 9, 
					};
					continue;
				case 9:
					result = 4;
					num2 = ⴍႤ[262] - 41192;
					continue;
				case 7:
					result = P_0.Fill(P_1, P_2);
					num2 = 5;
					continue;
				case 2:
				case 5:
					num++;
					num2 = (((P_4 * P_4 + P_4) % 2 == 0) ? 10 : (ⴄႤ[386] - ⴄႤ[66]));
					continue;
				case 0:
					num2 = ⴅ[268] - 199;
					continue;
				case 8:
				case 10:
					return result;
				case 6:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : CtyInfo
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		IEquatable<string> equatable = default(IEquatable<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[47] - 63720;
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
				case 10:
				case 11:
					num2 = (((P_1 ^ P_2) - 73) ^ num) switch
					{
						0 => 0, 
						_ => 3, 
					};
					continue;
				case 3:
					equatable = null;
					num2 = ⴄႭ[576] - 92;
					continue;
				case 0:
				case 7:
					equatable = P_0.Continent;
					num2 = 4;
					continue;
				case 4:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 9;
				case 9:
					num2 = ⴐ[131] - 177;
					continue;
				case 5:
					num2 = ((num3 % 2 != 0) ? (ⴀ[281] - 5618) : 6);
					continue;
				case 6:
					return equatable as string;
				case 8:
					num2 = ⴐ[183] - 189;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : DxSpot
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႠ[204] - 17764;
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
				case 6:
				case 7:
					num2 = (((P_1 ^ P_2) - 11) ^ num) switch
					{
						0 => ⴀႨ[99] - 1052, 
						_ => 1, 
					};
					continue;
				case 1:
					result = false;
					num2 = ⴍႤ[494] - 40457;
					continue;
				case 0:
				case 8:
					result = P_0.SkimDupe;
					num2 = 10;
					continue;
				case 10:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴀႣ[0] - 46442) : (ⴃႰ[58] - 19219));
					continue;
				case 3:
				case 5:
					num2 = ⴍႭ[13] - 25072;
					continue;
				case 11:
					return result;
				case 9:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : CallbookData
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[341] - 48;
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
				case 6:
					num2 = (((P_1 ^ P_2) - 29) ^ num) switch
					{
						0 => 11, 
						1 => 12, 
						2 => 8, 
						3 => ⴀႨ[45] - 15629, 
						_ => ⴀ[164] - 7651, 
					};
					continue;
				case 13:
					convertible = null;
					num2 = 5;
					continue;
				case 11:
					convertible = P_0.Call;
					num2 = ⴍႤ[190] - 43814;
					continue;
				case 12:
					convertible = P_0.LicenseClass;
					goto case 7;
				case 7:
					num2 = 5;
					continue;
				case 8:
					convertible = P_0.LastName;
					goto case 10;
				case 10:
					num2 = ⴀႳ[261] - 25324;
					continue;
				case 4:
					convertible = P_0.Address;
					num2 = 5;
					continue;
				case 5:
				{
					num++;
					int num3 = 1768;
					int num4 = 221;
					num2 = ((442 < num3 / 4 - num4) ? (ⴅ[99] - 10) : 9);
					continue;
				}
				case 9:
					return convertible as string;
				case 0:
					num2 = ⴃႥ[244] - 55718;
					continue;
				}
				break;
			}
		}
	}
}
