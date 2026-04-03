using System;
using System.Collections.Generic;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.QslInfo;
using ArcInterfaces;
using ArcInterfaces.Spots;
using ArcShared;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowHam : IArcCmd
{
	private static void Ⴈ(NodeUserCmd P_0)
	{
		int num = 1;
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 2:
			{
				object obj = new ShowHamHelp();
				(obj as ShowHamHelp).Exec(P_0);
				obj2 = new Publisher();
				break;
			}
			case 0:
				break;
			case 4:
				return;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(6, 1, 1157904603), P_0.Rx.Msg, 805, 875));
			num = 2;
		}
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		try
		{
			int num = 2;
			object obj3 = default(object);
			object obj = default(object);
			while (true)
			{
				int num3;
				object obj2;
				switch (num)
				{
				default:
					if (cmd.Rx.Split.Length == 3)
					{
						num = 5;
						continue;
					}
					break;
				case 5:
					cmd.Tx.DistroType = DistroType.ToRequester;
					obj3 = cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႷ()
						.CtyInfoFromCall(SetDxFilter.Ⴀ(cmd.Rx.Split[2], 590, 'ȏ'));
					goto case 0;
				case 0:
					num = ⴃႰ[170] - 54667;
					continue;
				case 6:
				case 7:
					obj = cmd.Ⴍ().Ⴅ().Ⴀ()
						.UsVeCallbook.Search(SetDxFilter.Ⴀ(cmd.Rx.Split[2], 923, 'Ϛ'), qslinfoSoapClient.Ⴈ(obj3 as CtyInfo, '\u0005', 28));
					goto case 1;
				case 1:
					num = 4;
					continue;
				case 4:
					if ((CallbookData)obj != null)
					{
						num = ⴄႭ[158] - 174;
						continue;
					}
					num3 = 4;
					goto IL_01ea;
				case 8:
					{
						object fullDescription = ((CallbookData)obj).GetFullDescription();
						List<string>.Enumerator enumerator = ((List<string>)fullDescription).GetEnumerator();
						try
						{
							int num2 = 4;
							while (true)
							{
								switch (num2)
								{
								default:
									num2 = ⴀႨ[221] - 55660;
									continue;
								case 7:
								{
									ICloneable current = enumerator.Current;
									cmd.Tx.Msg.Add((string)current);
									break;
								}
								case 2:
									break;
								case 1:
								case 6:
									goto end_IL_014a;
								}
								num2 = ((!enumerator.MoveNext()) ? 1 : ⴐ[257]);
								continue;
								end_IL_014a:
								break;
							}
						}
						finally
						{
							switch (1)
							{
							default:
								((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
								break;
							}
						}
						goto IL_022e;
					}
					IL_01ea:
					switch (num3)
					{
					default:
						cmd.Tx.Msg.Add(SetStationClubHelp.Ⴍ(2, 3, 1747255696, null));
						break;
					case 0:
					case 6:
						break;
					case 3:
						goto end_IL_0028;
					case 1:
					case 2:
						goto end_IL_0026;
					}
					goto IL_022e;
					IL_022e:
					obj2 = new Publisher();
					(obj2 as Publisher).Process(cmd);
					num3 = ⴀ[48] - 49718;
					goto IL_01ea;
					end_IL_0028:
					break;
				}
				Ⴈ(cmd);
				break;
				continue;
				end_IL_0026:
				break;
			}
		}
		catch (Exception)
		{
			Ⴈ(cmd);
		}
		switch (1)
		{
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, short P_3) where _0021_00210 : WwvSpot where _0021_00211 : string
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 1;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄႭ[66] / 3;
				continue;
			case 0:
				num = (((P_2 ^ P_3) - 78) ^ num2) switch
				{
					0 => ⴄႤ[135], 
					_ => ⴄႭ[134], 
				};
				continue;
			case 8:
				num = ⴄႷ[39] - 54272;
				continue;
			case 5:
				P_0.Route = P_1;
				goto case 7;
			case 7:
				num2++;
				num3 = 972;
				break;
			case 2:
			case 4:
				break;
			case 3:
				return;
			}
			int num4 = 22;
			num = ((243 >= num3 / 4 - num4) ? (ⴄႤ[50] / 8) : 0);
		}
	}
}
