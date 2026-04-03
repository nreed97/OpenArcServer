using System;
using System.Data;
using System.Security;
using System.Threading;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class DeleteMail : IArcCmd
{
	private static void Ⴈ(NodeUserCmd P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(10, 8, 1157903455), P_0.Rx.Msg, 278, 344));
				goto IL_005a;
			case 3:
				goto IL_005a;
			case 1:
			case 2:
			{
				object obj = new DeleteMailHelp();
				((DeleteMailHelp)obj).Exec(P_0);
				break;
			}
			case 0:
				break;
			}
			break;
			IL_005a:
			num = ⴍႤ[259] - 27509;
		}
		object obj2 = new Publisher();
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		try
		{
			int num = 7;
			IComparable<string> comparable = default(IComparable<string>);
			object obj2 = default(object);
			object obj3 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 2) ? (ⴃႥ[46] - 62974) : (ⴍႤ[347] - 1860));
					continue;
				case 14:
					num = ((!SkimmerValidSpot.Ⴈ(cmd.Rx.Split[1], 469, 417)) ? 12 : (ⴃႥ[85] - 8282));
					continue;
				case 15:
					comparable = ShowUsersHelp.Ⴅ(SetStationClubHelp.Ⴍ(5, 2, 1747258069, null), cmd.Rx.Split[1], 400, 478);
					num = 4;
					continue;
				case 4:
					obj2 = cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႨ()
						.Ⴀ((string)comparable);
					num = ((((DataRow[])obj2).Length <= 0) ? (ⴍႤ[404] - 20851) : 3);
					continue;
				case 3:
				case 18:
					obj3 = (obj2 as DataRow[])[0];
					num = ((!ByeHelp.Ⴍ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(obj3 as DataRow, SetStationClubHelp.Ⴍ(14, 4, 1747258014, null), 70, '\b'), '\u008c', 231), cmd.Ⴍ().Ⴀ(), 382, 281)) ? 1 : 5);
					continue;
				case 1:
					num = (ByeHelp.Ⴍ(UserCacheCfg.Ⴃ(qslinfoSoapClient.Ⴓ(obj3 as DataRow, ReplyMail.Ⴅ(7, 4, 1217944719), 1014, 'θ'), 'ȳ', 600), cmd.Ⴍ().Ⴀ(), 295, 320) ? (ⴀႼ[47] - 151) : 10);
					continue;
				case 10:
					num = ((!ByeHelp.Ⴍ(cmd.Ⴍ().Ⴀ(), cmd.Ⴍ().Ⴅ().Ⴓ()
						.Ⴀ(), 680, 719)) ? 9 : 5);
					continue;
				case 5:
					num = (cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႨ()
						.DeleteLetter(cmd.Rx.Split[1]) ? 11 : 0);
					continue;
				case 11:
					cmd.Tx.Msg.Add(AnnHelp.Ⴈ(CallBlockCacheCfg.Ⴅ(null, 7, 62057791, null), cmd.Rx.Split[1], ReplyMailHelp.Ⴄ(16, null, 1057162020, 2), 931, 'Δ'));
					num = 16;
					continue;
				case 0:
					cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(3, null, 1267022763, typeof(DxSpotUniqueCache)));
					goto case 13;
				case 13:
				case 17:
					num = ⴃႰ[80] - 24187;
					continue;
				case 9:
					cmd.Tx.Msg.Add(ႰႥ.Ⴅ(1, 'o', 952620484));
					num = ⴀႣ[264] - 37748;
					continue;
				case 8:
					cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(14, 3, 1747257914, null));
					goto case 16;
				case 16:
				{
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					num = 6;
					continue;
				}
				case 12:
					Ⴈ(cmd);
					break;
				case 6:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴈ(cmd);
		}
		switch (3)
		{
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, char P_3) where _0021_00210 : WaitCallback
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		bool result = default(bool);
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 1:
				case 5:
					num2 = (((P_3 ^ P_2) - 71) ^ num) switch
					{
						0 => 6, 
						_ => 9, 
					};
					continue;
				case 9:
					result = true;
					num2 = 7;
					continue;
				case 6:
					result = ThreadPool.QueueUserWorkItem(P_0, P_1);
					num2 = ⴍႤ[336] - 43918;
					continue;
				case 7:
				case 8:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? 3 : 0);
					continue;
				case 0:
					num2 = 1;
					continue;
				case 2:
				case 3:
					return result;
				case 4:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211, _0021_00212>(_0021_00211 P_0, _0021_00212 P_1, _0021_00210 P_2, short P_3, char P_4) where _0021_00210 : string where _0021_00211 : string where _0021_00212 : string
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 2;
		int num4 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = ⴀႣ[10] - 5858;
				break;
			case 4:
			{
				int num3 = P_4 ^ P_3;
				SetDxCountHelp.ႭႤ[476] = (SetDxCountHelp.ႭႤ[476] * P_3) & 0x34;
				num = ((num3 - 39) ^ num4) switch
				{
					0 => 3, 
					_ => ⴀႨ[4] - 27038, 
				};
				break;
			}
			case 6:
				num = 1;
				break;
			case 3:
				DownloadUrl.DownloadToFile(P_0, P_1, P_2);
				goto case 1;
			case 1:
				num4++;
				goto case 8;
			case 8:
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				goto case 7;
			case 7:
				num = 9;
				break;
			case 9:
				num = ((num2 % 2 != 0) ? 4 : (ⴄႷ[20] - ⴄႷ[20]));
				break;
			case 0:
			case 5:
				return;
			}
		}
	}
}
