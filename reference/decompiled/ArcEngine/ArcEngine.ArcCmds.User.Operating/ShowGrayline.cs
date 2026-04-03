using System;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.QslInfo;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowGrayline : IArcCmd
{
	internal sealed class Ⴃ
	{
		internal SkimmerSpotBins[] Ⴍ;

		internal int Ⴀ;

		internal Ⴃ()
		{
		}
	}

	private static void Ⴍ(NodeUserCmd P_0)
	{
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(12, 1, 1157903446), P_0.Rx.Msg, 885, 827));
				goto IL_0053;
			case 0:
				goto IL_0053;
			case 2:
			{
				IArcCmd arcCmd = new ShowGraylineHelp();
				((ShowGraylineHelp)arcCmd).Exec(P_0);
				obj = new Publisher();
				break;
			}
			case 4:
				break;
			}
			break;
			IL_0053:
			num = 2;
		}
		(obj as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		try
		{
			Ⴐ(cmd);
		}
		catch (Exception)
		{
			Ⴍ(cmd);
		}
	}

	private static void Ⴐ(NodeUserCmd P_0)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 6;
		double trise = default(double);
		double tset = default(double);
		int num2 = default(int);
		ICloneable cloneable = default(ICloneable);
		ICloneable cloneable2 = default(ICloneable);
		while (true)
		{
			switch (num)
			{
			default:
			{
				DateTime dateTime = ShowAnnHelp.Ⴅ('\u02d8', 745);
				trise = 0.0;
				tset = 0.0;
				num2 = SunCalculations.SunRiseSet(SetAnnChatRoomsHelp.Ⴄ(ref dateTime, 835, 890), ReadMailHelp.Ⴓ(ref dateTime, 724, 660), SetWxCountHelp.Ⴄ(ref dateTime, '@', 88), -97.0, 35.0, -7.0 / 12.0, upperLimb: true, ref trise, ref tset);
				goto case 2;
			}
			case 2:
				num = ⴀ[147] - 64096;
				continue;
			case 5:
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = 1;
					goto IL_00ee;
				case 1:
					num3 = 3;
					goto IL_00ee;
				case -1:
					break;
				case 0:
					goto IL_018a;
					IL_00ee:
					num = num3;
					continue;
				}
				break;
			}
			case 3:
				P_0.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133035, 1, 'd'));
				return;
			case 0:
			case 4:
				return;
			case 1:
				goto IL_018a;
				IL_018a:
				while (true)
				{
					int num4 = ((!(trise < 0.0)) ? 5 : (ⴄႷ[2] - 23603));
					while (true)
					{
						switch (num4)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 11:
						case 12:
							break;
						case 10:
							goto end_IL_011e;
						case 3:
							trise += 24.0;
							num4 = 5;
							continue;
						case 5:
						case 9:
							num4 = ((!(tset < 0.0)) ? (ⴄႤ[335] - 4) : 4);
							continue;
						case 4:
							tset += 24.0;
							num4 = 6;
							continue;
						case 6:
							num4 = ((!(trise > 24.0)) ? (ⴄႤ[180] - ⴄႤ[180]) : 14);
							continue;
						case 14:
							trise -= 24.0;
							num4 = 0;
							continue;
						case 0:
							num4 = ((!(tset > 24.0)) ? 1 : ⴅ[145]);
							continue;
						case 7:
						case 13:
							tset -= 24.0;
							num4 = ⴀႨ[80] - 46775;
							continue;
						case 1:
						{
							int num6 = (int)trise;
							string text = SetStationBuddyList.Ⴓ(ref num6, SetStationClubHelp.Ⴍ(6, 6, 1747263100, null), 'π', 898);
							string text2 = ShowSkimCtyHelp.Ⴍ(1216134125, 6, '\u0083');
							int num7 = ShowSkimmerHelp.Ⴅ((int)((trise - (double)(int)trise) * 60.0), 211, 'í');
							cloneable = qslinfoResponse.Ⴗ(text, text2, SetStationBuddyList.Ⴓ(ref num7, SetStationClubHelp.Ⴍ(2, 2, 1747263096, null), 'Æ', 132), ႨႨ.Ⴀ(8, 8, 1157903717), 641, 'ˢ');
							num4 = 2;
							continue;
						}
						case 2:
						{
							int num5 = (int)tset;
							cloneable2 = SetStationBuddyList.Ⴓ(ref num5, SetStationClubHelp.Ⴍ(13, 2, 1747263096, null), 'ʵ', 759) + ShowSkimCtyHelp.Ⴍ(1216134115, 8, 'è') + ShowSkimmerHelp.Ⴅ((int)((tset - (double)(int)tset) * 60.0), 1020, 'ς').ToString(SetStationClubHelp.Ⴍ(9, 6, 1747263100, null)) + ႨႨ.Ⴀ(0, 2, 1157903727);
							num4 = 15;
							continue;
						}
						case 15:
							P_0.Tx.Msg.Add(ႨႨ.Ⴀ(7, 6, 1157902544) + (string)cloneable + ႨႨ.Ⴀ(4, 4, 1157902546) + (cloneable2 as string));
							return;
						}
						goto end_IL_0028;
						continue;
						end_IL_011e:
						break;
					}
				}
				end_IL_0028:
				break;
			}
			break;
		}
		P_0.Tx.Msg.Add(ႰႥ.Ⴅ(4, 'D', 952621780));
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, int P_3) where _0021_00210 : string where _0021_00211 : LotwUpdate
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 6;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴃႠ[332] - 65386;
				break;
			case 1:
			case 3:
				num = (((P_3 ^ P_2) - 109) ^ num3) switch
				{
					0 => 2, 
					_ => ⴃႰ[165] - 8092, 
				};
				break;
			case 7:
				num = ⴀႣ[186] - 23873;
				break;
			case 2:
			case 8:
				P_0.Download(P_1);
				goto case 4;
			case 4:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 5;
				break;
			case 5:
				num = ((num2 % 2 != 0) ? 3 : 0);
				break;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		float result = default(float);
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
					num2 = 11;
					continue;
				case 11:
					break;
				case 10:
					num2 = (((P_2 ^ P_1) - 120) ^ num) switch
					{
						0 => 6, 
						_ => 7, 
					};
					continue;
				case 7:
					result = 0.5690867f;
					goto case 2;
				case 2:
					num2 = 9;
					continue;
				case 6:
					result = Convert.ToSingle(P_0);
					num2 = ⴀ[191] - 52031;
					continue;
				case 5:
				case 9:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 8 : (ⴀႨ[141] - 33435));
					continue;
				case 0:
				case 1:
					num2 = ⴍႤ[341] - 16476;
					continue;
				case 8:
					return result;
				case 4:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}
}
