using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class SetWxCountHelp : IArcCmd
{
	internal sealed class Ⴐ
	{
		internal ArcConnect Ⴄ;

		internal RxNodeUserCmd Ⴃ;

		internal TxNodeUserCmd Ⴀ;

		internal Ⴐ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 6;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267022528, typeof(ႳႥ)));
				num = ⴀႼ[66] - 61;
				break;
			case 3:
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133224, 0, '\u000f'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(2, null, 1057162173, 7));
				num = 7;
				break;
			case 7:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(1, '\u0099', 952620213));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 1, 62057608, null));
				num = 5;
				break;
			case 0:
			case 5:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(1, 5, 1217944672));
				obj = new Publisher();
				num = ⴄႤ[340] - 249;
				break;
			case 2:
				(obj as Publisher).Process(cmd);
				return;
			case 1:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		ICloneable cloneable = default(ICloneable);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႭ[470] - 72;
					continue;
				case 4:
					break;
				case 5:
					num2 = (((P_2 ^ P_3) - 123) ^ num) switch
					{
						0 => 3, 
						_ => 1, 
					};
					continue;
				case 1:
					cloneable = null;
					num2 = 10;
					continue;
				case 3:
				case 6:
				case 9:
					cloneable = string.Concat(P_0, P_1);
					num2 = 10;
					continue;
				case 10:
					num++;
					num3 = 868;
					num4 = 203;
					goto case 0;
				case 0:
					num2 = ((434 < num3 / 2 - num4) ? (ⴍႤ[189] - 29618) : (ⴀႳ[139] - 4374));
					continue;
				case 2:
					return (string)cloneable;
				case 7:
					num2 = ⴅ[462] - 145;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : AnnWxSpot
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		ICloneable cloneable = default(ICloneable);
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
					num2 = 1;
					continue;
				case 1:
					break;
				case 3:
				case 4:
					num2 = (((P_1 ^ P_2) - 126) ^ num) switch
					{
						0 => ⴃႥ[163] - 56572, 
						_ => 8, 
					};
					continue;
				case 8:
					cloneable = null;
					num2 = 0;
					continue;
				case 10:
					cloneable = P_0.SpotterState;
					num2 = 0;
					continue;
				case 0:
				case 5:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 6;
				case 6:
					num2 = 9;
					continue;
				case 9:
					num2 = ((num3 % 2 != 0) ? (ⴃႥ[57] - 8501) : (ⴀႨ[208] - 6500));
					continue;
				case 11:
					return cloneable as string;
				case 7:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴀ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DxCommentExtCfg
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		bool result = default(bool);
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
					num2 = 6;
					continue;
				case 6:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 92) ^ num) switch
					{
						0 => 3, 
						_ => 5, 
					};
					continue;
				case 5:
					result = true;
					num2 = 10;
					continue;
				case 1:
				case 3:
					result = P_0.Cty;
					num2 = ⴀႳ[228] - 55026;
					continue;
				case 8:
				case 10:
				{
					num++;
					int num3 = 111;
					int num4 = 177;
					num2 = ((708 > num4 - num3 * 4) ? (ⴀႳ[117] - 34475) : (ⴃႠ[323] - 27201));
					continue;
				}
				case 2:
					num2 = ⴍႤ[152] - ⴍႤ[152];
					continue;
				case 4:
				case 9:
					return result;
				case 7:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : DxSpot
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		DateTime result = default(DateTime);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႳ[5] - 20330;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႰ[15] - 46741;
					continue;
				case 8:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 1) ^ num) switch
					{
						0 => ⴀႼ[22] - 220, 
						_ => ⴍႭ[171] - 30390, 
					};
					continue;
				case 7:
					result = default(DateTime);
					num2 = 10;
					continue;
				case 4:
				case 11:
					result = P_0.DtsRx;
					num2 = 10;
					continue;
				case 6:
				case 10:
					num++;
					goto case 2;
				case 2:
					num2 = (((P_2 * P_2 + P_2) % 2 != 0) ? 5 : 0);
					continue;
				case 5:
					num2 = ⴃႠ[233] - 58639;
					continue;
				case 0:
					return result;
				case 9:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴄ(ref DateTime P_0, char P_1, short P_2)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 12;
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
				case 12:
					num2 = (((P_2 ^ P_1) - 24) ^ num) switch
					{
						0 => ⴀ[28] - 28829, 
						1 => ⴃႥ[422] - 7176, 
						_ => 7, 
					};
					continue;
				case 3:
				case 7:
					result = 3;
					num2 = ⴄႷ[49] - 17971;
					continue;
				case 2:
				case 4:
					result = P_0.Day;
					num2 = ⴄႭ[134] / 8;
					continue;
				case 5:
				case 11:
					result = P_0.Second;
					num2 = 1;
					continue;
				case 1:
				{
					num++;
					int num3 = 298;
					int num4 = 995;
					num2 = ((5970 > num4 - num3 * 6) ? 9 : (ⴀႣ[13] - 52923));
					continue;
				}
				case 0:
					num2 = ⴐ[243] + 4;
					continue;
				case 9:
					return result;
				case 6:
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : CtyInfo
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		IEquatable<string> equatable = default(IEquatable<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႰ[2] - 38926;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႣ[325] - 15399;
					continue;
				case 3:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 13) ^ num) switch
					{
						0 => 0, 
						_ => ⴀ[515] - 960, 
					};
					continue;
				case 8:
				case 11:
					equatable = null;
					num2 = 6;
					continue;
				case 0:
					equatable = P_0.TimeOffset;
					num2 = 6;
					continue;
				case 5:
				case 6:
					num++;
					num3 = 30;
					goto case 9;
				case 9:
				{
					int num4 = 205;
					num2 = ((2050 > num4 - num3 * 10) ? 10 : 7);
					continue;
				}
				case 7:
					num2 = 4;
					continue;
				case 10:
					return (string)equatable;
				case 2:
					num2 = ⴐ[367];
					continue;
				}
				break;
			}
		}
	}
}
