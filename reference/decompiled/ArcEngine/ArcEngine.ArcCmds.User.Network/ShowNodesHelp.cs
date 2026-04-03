using System;
using System.Configuration;
using System.Diagnostics;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcInterfaces.Arcx;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods.Login;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ShowNodesHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 1;
			case 1:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(8, null, 1267020034, typeof(SkimmerServerCache)));
				num = ⴃႰ[34] - ⴃႰ[34];
				break;
			case 0:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134743, 0, '«'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(28, null, 1057164286, 6));
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(7, '[', 952620563));
				goto case 2;
			case 2:
				obj = new Publisher();
				num = ⴐ[75] - 181;
				break;
			case 5:
			case 6:
				(obj as Publisher).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : AnnCfg
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int result = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႤ[417] - 41788;
					continue;
				case 11:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 63) ^ num) switch
					{
						0 => 9, 
						_ => 10, 
					};
					continue;
				case 10:
					result = 3;
					num2 = 7;
					continue;
				case 9:
					result = P_0.NmbrSpots;
					num2 = 7;
					continue;
				case 7:
					num++;
					goto case 8;
				case 8:
					num3 = P_2 * P_2;
					goto case 1;
				case 1:
					num3 = P_2 + num3;
					num2 = ⴃႠ[233] - 58642;
					continue;
				case 0:
					num2 = ((num3 % 2 != 0) ? 4 : ⴄႤ[135]);
					continue;
				case 5:
					return result;
				case 2:
				case 3:
					num2 = ⴀႨ[7] - 41576;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static SettingsBase Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : SettingsBase
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
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
					num2 = 9;
					continue;
				case 9:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 23) ^ num) switch
					{
						0 => 4, 
						_ => ⴀႣ[193] - 48195, 
					};
					continue;
				case 0:
				case 3:
					obj = null;
					num2 = ⴀႨ[190] - 45589;
					continue;
				case 4:
				case 7:
					obj = SettingsBase.Synchronized(P_0);
					num2 = ⴄႭ[189] - 202;
					continue;
				case 5:
					num++;
					num3 = 141;
					num4 = 11;
					goto case 2;
				case 2:
					num2 = ((47 >= num3 / 3 - num4) ? 1 : 8);
					continue;
				case 1:
					return obj as SettingsBase;
				case 6:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ(double P_0, double P_1, double P_2, double P_3, ref float P_4, ref float P_5, int P_6, short P_7)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 9;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႠ[371] - 7875;
				break;
			case 5:
				num = (((P_6 ^ P_7) - 72) ^ num2) switch
				{
					0 => 7, 
					_ => 2, 
				};
				break;
			case 2:
				num = ⴀ[464] - 29728;
				break;
			case 7:
				UtilsLatLon.CalcGeodesic(P_0, P_1, P_2, P_3, ref P_4, ref P_5);
				goto case 1;
			case 1:
				num2++;
				goto case 3;
			case 3:
				num3 = 398;
				num4 = 883;
				goto case 0;
			case 0:
				num = ((4415 > num4 - num3 * 5) ? (ⴀႨ[116] - 13785) : 6);
				break;
			case 4:
			case 6:
				num = 5;
				break;
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DxSpot
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		IEquatable<string> equatable = default(IEquatable<string>);
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
					num2 = ⴀႣ[186] - 23873;
					continue;
				case 3:
				case 4:
					break;
				case 6:
					num2 = (((P_1 ^ P_2) - 7) ^ num) switch
					{
						0 => ⴃႰ[63] - 42187, 
						_ => 10, 
					};
					continue;
				case 10:
					equatable = null;
					num2 = 1;
					continue;
				case 9:
					equatable = P_0.Name;
					num2 = 1;
					continue;
				case 1:
				{
					num++;
					int num3 = 1062;
					int num4 = 331;
					num2 = ((354 < num3 / 3 - num4) ? (ⴃႰ[74] - 47651) : 5);
					continue;
				}
				case 5:
				case 8:
					return equatable as string;
				case 0:
				case 7:
					num2 = ⴍႤ[347] - 1868;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, char P_3) where _0021_00210 : CounterCreationData where _0021_00211 : string
	{
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				continue;
			case 6:
				num = (((P_2 ^ P_3) - 52) ^ num2) switch
				{
					0 => 2, 
					_ => 1, 
				};
				continue;
			case 1:
				num = 8;
				continue;
			case 2:
			case 3:
				P_0.CounterName = P_1;
				goto case 7;
			case 7:
			case 8:
				num2++;
				break;
			case 5:
				break;
			case 0:
				return;
			}
			int num3 = 2200;
			int num4 = 103;
			num = ((550 < num3 / 4 - num4) ? 6 : 0);
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, short P_3) where _0021_00210 : string where _0021_00211 : ArcLogInRqst
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 1;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				break;
			case 5:
				num = (((P_2 ^ P_3) - 29) ^ num2) switch
				{
					0 => ⴀႣ[345] - 45941, 
					_ => ⴅ[145], 
				};
				break;
			case 7:
				num = ⴅ[180] - 27;
				break;
			case 6:
				P_0.DeserializeNode(P_1);
				goto case 2;
			case 2:
			case 3:
				num2++;
				goto case 9;
			case 9:
				num3 = 633;
				num4 = 829;
				goto case 8;
			case 8:
				num = ((2487 > num4 - num3 * 3) ? 4 : 0);
				break;
			case 0:
				num = 5;
				break;
			case 4:
				return;
			}
		}
	}
}
