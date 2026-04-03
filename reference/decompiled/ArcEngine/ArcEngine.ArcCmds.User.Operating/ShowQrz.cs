using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using HtmlAgilityPack;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowQrz : IArcCmd
{
	private static void Ⴍ(NodeUserCmd P_0)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				object obj = new ShowContestStationHelp();
				((ShowContestStationHelp)obj).Exec(P_0);
				object obj2 = new Publisher();
				((Publisher)obj2).Process(P_0);
				return;
			}
			case 0:
			case 2:
				return;
			}
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(7, 1, 1157904007), P_0.Rx.Msg, 153, 215));
			num = 1;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		try
		{
			switch (0)
			{
			default:
				if (cmd.Rx.Split.Length == 3)
				{
					try
					{
						int num = 0;
						object obj7 = default(object);
						bool flag = default(bool);
						IEnumerable<HtmlNode> enumerable = default(IEnumerable<HtmlNode>);
						object current = default(object);
						object obj = default(object);
						int num3 = default(int);
						int num4 = default(int);
						IComparable comparable2 = default(IComparable);
						object obj3 = default(object);
						object obj2 = default(object);
						int num5 = default(int);
						object obj5 = default(object);
						while (true)
						{
							switch (num)
							{
							default:
								cmd.Tx.DistroType = DistroType.ToRequester;
								cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267023591, typeof(ႨႤ)));
								goto case 4;
							case 4:
								num = ⴀႣ[308] - 11284;
								continue;
							case 5:
							case 6:
							{
								object obj6 = new HtmlWeb();
								obj7 = SetStationEmailHelp.Ⴗ(obj6 as HtmlWeb, ShowUsersHelp.Ⴅ(SetStationQth.Ⴍ(null, 1687351966, 1, 23), cmd.Rx.Split[2], 297, 359), 'Ĵ', 'Ĩ');
								num = ⴃႰ[98] - 49512;
								continue;
							}
							case 1:
								flag = false;
								goto case 3;
							case 3:
								enumerable = ႷႤ.Ⴗ(ShowPrefix.Ⴐ((HtmlDocument)obj7, 500, 426), CallBlockCacheCfg.Ⴅ(null, 5, 62058391, null), 127, '\u0002');
								num = 7;
								continue;
							case 7:
							{
								object enumerator = ((IEnumerable<HtmlNode>)(HtmlNodeCollection)enumerable).GetEnumerator();
								try
								{
									int num2 = 3;
									while (true)
									{
										switch (num2)
										{
										default:
											num2 = 0;
											continue;
										case 10:
											current = (enumerator as IEnumerator<HtmlNode>).Current;
											goto case 5;
										case 5:
											num2 = ((!ByeHelp.Ⴍ(ႳႠ.Ⴄ((HtmlNode)current, 'Ψ', 'Ϡ'), CallBlockCacheCfg.Ⴅ(null, 7, 62058397, null), 458, 429)) ? (ⴀ[329] - 24510) : 6);
											continue;
										case 6:
											obj = WwvHelp.Ⴀ(current as HtmlNode, 'Ƕ', 454);
											num3 = ShowNodes.Ⴄ((string)obj, SetTalkCount.Ⴗ(0, null, 1267023549, typeof(ShowVersion)), 682, 661);
											num2 = 16;
											continue;
										case 4:
										case 16:
											num4 = ShowNodes.Ⴄ((string)obj, CallBlockCacheCfg.Ⴅ(null, 1, 62058380, null), 884, 843);
											num2 = ⴃႠ[273] - 14780;
											continue;
										case 7:
											num2 = ((num3 > 0) ? 18 : 0);
											continue;
										case 18:
											num2 = ((num4 <= 0) ? ⴄႭ[66] : 11);
											continue;
										case 11:
											flag = true;
											comparable2 = SetTalkOutputHelp.Ⴍ((string)obj, num3 + 28, num4 - num3 - 28, 575, 620);
											num2 = 2;
											continue;
										case 2:
											comparable2 = ShowContestStationHelp.Ⴅ((string)comparable2, ReplyMail.Ⴅ(8, 7, 1217945127), string.Empty, 525, 'ɕ');
											goto case 12;
										case 12:
											num2 = 8;
											continue;
										case 8:
										{
											string obj4 = comparable2 as string;
											Array array = new char[1];
											((char[])array)[0] = '\n';
											obj3 = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(obj4, array as char[], 831, 873);
											num2 = 15;
											continue;
										}
										case 15:
											obj2 = (string[])obj3;
											num5 = 0;
											num2 = ⴐ[341] / 5;
											continue;
										case 9:
										{
											IComparable<string> comparable = (obj2 as string[])[num5];
											cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(CallBlockCacheCfg.Ⴅ(null, 4, 62058423, null), comparable as string, 881, 831));
											num2 = ⴍႤ[345] - 45595;
											continue;
										}
										case 17:
											num5++;
											num2 = 14;
											continue;
										case 14:
											num2 = ((num5 < ((string[])obj2).Length) ? (ⴄႭ[30] - 184) : (ⴃႰ[155] - 30441));
											continue;
										case 0:
											num2 = ((!((IEnumerator<HtmlNode>)enumerator).MoveNext()) ? 1 : 10);
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								finally
								{
									int num6 = 3;
									while (true)
									{
										int num7;
										switch (num6)
										{
										default:
											num7 = (((IEnumerator<HtmlNode>)enumerator == null) ? (ⴀႨ[94] - 43550) : (ⴃႰ[6] - 7775));
											goto IL_047b;
										case 1:
										case 6:
											(enumerator as IEnumerator<HtmlNode>).Dispose();
											break;
										case 2:
										case 5:
											break;
										}
										break;
										IL_047b:
										num6 = num7;
									}
								}
								int num8 = 0;
								while (true)
								{
									int num9;
									switch (num8)
									{
									default:
										num9 = (flag ? 3 : (ⴀႳ[38] - 44449));
										goto IL_04cd;
									case 2:
									case 5:
										cmd.Tx.Msg.Add(ReplyMail.Ⴅ(7, 15, 1217945127));
										goto case 1;
									case 1:
									case 3:
										obj5 = new Publisher();
										break;
									case 4:
										break;
									}
									break;
									IL_04cd:
									num8 = num9;
								}
								(obj5 as Publisher).Process(cmd);
								break;
							}
							}
							break;
						}
					}
					catch (Exception)
					{
						Ⴍ(cmd);
					}
				}
				else
				{
					switch (3)
					{
					default:
						Ⴍ(cmd);
						break;
					case 0:
					case 1:
					case 4:
					case 5:
						break;
					}
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴍ(cmd);
		}
		switch (0)
		{
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, float P_1, short P_2, int P_3) where _0021_00210 : StationCfg
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				break;
			case 8:
				num = (((P_2 ^ P_3) - 22) ^ num2) switch
				{
					0 => 0, 
					_ => 7, 
				};
				break;
			case 7:
				num = ⴀႼ[33] - 6;
				break;
			case 0:
			case 1:
				P_0.Lat = P_1;
				goto case 3;
			case 3:
			case 9:
			{
				num2++;
				int num3 = 264;
				int num4 = 1004;
				num = ((3012 > num4 - num3 * 3) ? 6 : 4);
				break;
			}
			case 4:
			case 5:
				num = 8;
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : Hashtable
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 9;
				break;
			case 9:
				num = (((P_1 ^ P_2) - 60) ^ num2) switch
				{
					0 => ⴀ[402] - 55671, 
					_ => 5, 
				};
				break;
			case 5:
				num = 0;
				break;
			case 4:
				P_0.Clear();
				goto case 0;
			case 0:
			case 6:
				num2++;
				goto case 3;
			case 3:
			{
				int num3 = 635;
				int num4 = 961;
				num = ((3844 > num4 - num3 * 4) ? 2 : 7);
				break;
			}
			case 7:
				num = ⴄႷ[60] - 11689;
				break;
			case 2:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : TextReader
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 7;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				break;
			case 8:
				num = (((P_2 ^ P_1) - 28) ^ num2) switch
				{
					0 => ⴐ[254], 
					_ => ⴄႤ[81] / 9, 
				};
				break;
			case 4:
				num = 5;
				break;
			case 0:
				P_0.Close();
				goto case 5;
			case 5:
			case 9:
				num2++;
				num3 = 46;
				num4 = 376;
				goto case 6;
			case 6:
				num = ((1128 > num4 - num3 * 3) ? 2 : (ⴀႼ[22] - 230));
				break;
			case 1:
				num = ⴅ[210];
				break;
			case 2:
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, short P_3) where _0021_00210 : CounterCreationData where _0021_00211 : string
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 1;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴃႰ[2] - 38922;
				break;
			case 8:
				num = (((P_3 ^ P_2) - 66) ^ num3) switch
				{
					0 => 5, 
					_ => 2, 
				};
				break;
			case 2:
			case 9:
				num = ⴃႠ[151] - 42610;
				break;
			case 5:
				P_0.CounterHelp = P_1;
				goto case 3;
			case 3:
			case 6:
			case 7:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = ⴄႤ[66] - 134;
				break;
			case 0:
				num = ((num2 % 2 != 0) ? 8 : 4);
				break;
			case 4:
				return;
			}
		}
	}
}
