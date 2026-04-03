using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Xml;
using System.Xml.XPath;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Mirc;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.MaintenanceUpdates;
using HtmlAgilityPack;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowContestStation : IArcCmd
{
	internal sealed class Ⴓ
	{
		internal Dictionary<string, long> Ⴐ;

		internal Ⴓ()
		{
		}
	}

	internal sealed class Ⴅ
	{
		internal Dictionary<string, long> Ⴗ;

		internal string Ⴓ;

		internal Ⴅ()
		{
		}
	}

	private static Func<HtmlNode, bool> m_Ⴀ;

	private static void Ⴄ(NodeUserCmd P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 3;
		IArcCmd arcCmd = default(IArcCmd);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0023;
			case 2:
			case 4:
				arcCmd = new ShowContestStationHelp();
				goto case 1;
			case 1:
				(arcCmd as ShowContestStationHelp).Exec(P_0);
				obj = new Publisher();
				break;
			case 0:
				break;
			}
			break;
			IL_0023:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(12, 5, 1157904003), P_0.Rx.Msg, 674, 748));
			num = ⴃႥ[270] - 59306;
		}
		(obj as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		try
		{
			switch (2)
			{
			default:
				if (cmd.Rx.Split.Length == 3)
				{
					try
					{
						int num = 3;
						object obj3 = default(object);
						object obj = default(object);
						object current = default(object);
						IXPathNavigable current2 = default(IXPathNavigable);
						IComparable comparable = default(IComparable);
						object current3 = default(object);
						while (true)
						{
							switch (num)
							{
							default:
								cmd.Tx.DistroType = DistroType.ToRequester;
								goto case 2;
							case 2:
								cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(5, null, 1267015397, typeof(SetStationMacrosHelp)));
								num = ⴄႷ[121] - 57599;
								continue;
							case 5:
								obj3 = new HtmlWeb();
								goto case 4;
							case 4:
							case 7:
								obj = SetStationEmailHelp.Ⴗ((HtmlWeb)obj3, ShowUsersHelp.Ⴅ(SetStationQth.Ⴍ(null, 1687355140, 2, 8), cmd.Rx.Split[2], 605, 531), 'Ͷ', '\u036a');
								num = ⴍႤ[204] - 7801;
								continue;
							case 1:
							{
								IEnumerable<HtmlNode> source = ShowPrefix.Ⴐ((HtmlDocument)obj, 223, 129).Descendants();
								if (ShowContestStation.m_Ⴀ == null)
								{
									ShowContestStation.m_Ⴀ = Ⴀ;
								}
								object obj2 = source.Where(ShowContestStation.m_Ⴀ).FirstOrDefault();
								num = ((!ShowTalk.Ⴀ(ႳႠ.Ⴄ((HtmlNode)obj2, '\u00b8', 'ñ'), ႰႥ.Ⴅ(4, '\u008e', 952616575), 276, 'ŵ')) ? 6 : 8);
								continue;
							}
							case 8:
								cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetStationClubHelp.Ⴍ(4, 3, 1747260130, null), cmd.Rx.Split[2], 1010, 956));
								break;
							case 6:
							{
								object enumerator = ((IEnumerable<HtmlNode>)ႷႤ.Ⴗ(ShowPrefix.Ⴐ((HtmlDocument)obj, 928, 1022), ReplyMail.Ⴅ(6, 10, 1217940741), 588, 'ȱ')).GetEnumerator();
								try
								{
									switch (0)
									{
									case 3:
										current = ((IEnumerator<HtmlNode>)enumerator).Current;
										goto case 1;
									case 1:
									{
										object enumerator2 = ((IEnumerable<HtmlNode>)ႷႤ.Ⴗ((HtmlNode)current, SetStationClubHelp.Ⴍ(14, 4, 1747259906, null), 748, 'ʑ')).GetEnumerator();
										try
										{
											int num6;
											switch (1)
											{
											case 2:
											case 3:
												current2 = (enumerator2 as IEnumerator<HtmlNode>).Current;
												goto case 5;
											case 5:
												comparable = string.Empty;
												goto case 0;
											case 0:
											{
												object enumerator3 = ((IEnumerable<HtmlNode>)ႷႤ.Ⴗ((HtmlNode)current2, SetStationClubHelp.Ⴍ(12, 3, 1747259960, null), 477, 'Ơ')).GetEnumerator();
												try
												{
													int num2 = 5;
													while (true)
													{
														switch (num2)
														{
														default:
															num2 = ⴀႳ[40] - 46789;
															continue;
														case 0:
														{
															current3 = (enumerator3 as IEnumerator<HtmlNode>).Current;
															bool num3 = ByeHelp.Ⴍ(comparable as string, string.Empty, 691, 724);
															ShowWwvOptionsHelp.ႣႥ[201] = (char)(ShowWwvOptionsHelp.ႣႥ[201] & ShowWwvOptionsHelp.ႣႥ[297] & 0xC7);
															num2 = ((!num3) ? (ⴃႠ[16] - 45240) : 2);
															continue;
														}
														case 2:
														case 8:
															comparable = AnnHelp.Ⴈ(ႰႥ.Ⴜ((string)comparable, 2, '\u0334', 768), Ⴗ(WwvHelp.Ⴀ(current3 as HtmlNode, '\u0348', 888)), ShowWxHelp.Ⴍ('\u001b', 985805267, 2), 921, 'ή');
															goto case 3;
														case 3:
															num2 = 9;
															continue;
														case 6:
															comparable = ShowUsersHelp.Ⴅ(comparable as string, Ⴗ(WwvHelp.Ⴀ(current3 as HtmlNode, 'Ǯ', 478)), 128, 206);
															num2 = ⴃႠ[323] - 27194;
															continue;
														case 9:
															num2 = ((!((IEnumerator<HtmlNode>)enumerator3).MoveNext()) ? 1 : 0);
															continue;
														case 1:
														case 7:
															break;
														}
														break;
													}
												}
												finally
												{
													int num4 = 6;
													while (true)
													{
														int num5;
														switch (num4)
														{
														default:
															num5 = (((IEnumerator<HtmlNode>)enumerator3 == null) ? 4 : (ⴀ[441] - 32450));
															goto IL_048d;
														case 2:
														case 3:
															(enumerator3 as IEnumerator<HtmlNode>).Dispose();
															break;
														case 1:
														case 4:
															break;
														}
														break;
														IL_048d:
														num4 = num5;
													}
												}
												num6 = 5;
												goto IL_04a4;
											}
											default:
												{
													if ((enumerator2 as IEnumerator<HtmlNode>).MoveNext())
													{
														goto case 2;
													}
													num6 = ⴀႨ[193] - 56087;
													goto IL_04a4;
												}
												IL_04a4:
												switch (num6)
												{
												default:
													cmd.Tx.Msg.Add((string)comparable);
													break;
												case 1:
													break;
												case 3:
												case 6:
													goto end_IL_0287;
												}
												goto default;
												end_IL_0287:
												break;
											}
										}
										finally
										{
											int num7 = 2;
											while (true)
											{
												int num8;
												switch (num7)
												{
												default:
													num8 = (((IEnumerator<HtmlNode>)enumerator2 == null) ? 6 : 5);
													goto IL_0533;
												case 5:
													(enumerator2 as IEnumerator<HtmlNode>).Dispose();
													break;
												case 4:
												case 6:
													break;
												}
												break;
												IL_0533:
												num7 = num8;
											}
										}
										goto default;
									}
									default:
									{
										int num9 = 5;
										while (true)
										{
											switch (num9)
											{
											default:
												if (!(enumerator as IEnumerator<HtmlNode>).MoveNext())
												{
													goto IL_057a;
												}
												break;
											case 3:
											case 4:
												goto end_IL_054a;
											}
											goto case 3;
											IL_057a:
											num9 = ⴐ[243] / 2;
											continue;
											end_IL_054a:
											break;
										}
										break;
									}
									}
								}
								finally
								{
									int num10 = 5;
									while (true)
									{
										int num11;
										switch (num10)
										{
										default:
											num11 = (((IEnumerator<HtmlNode>)enumerator == null) ? 3 : 6);
											goto IL_05ba;
										case 6:
											(enumerator as IEnumerator<HtmlNode>).Dispose();
											break;
										case 2:
										case 3:
											break;
										}
										break;
										IL_05ba:
										num10 = num11;
									}
								}
								break;
							}
							}
							break;
						}
						switch (3)
						{
						default:
						{
							object obj4 = new Publisher();
							(obj4 as Publisher).Process(cmd);
							break;
						}
						case 0:
							break;
						}
					}
					catch (Exception)
					{
						Ⴄ(cmd);
					}
				}
				else
				{
					switch (2)
					{
					default:
						Ⴄ(cmd);
						break;
					case 3:
						break;
					}
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴄ(cmd);
		}
		switch (4)
		{
		}
	}

	private string Ⴗ(string P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		while (true)
		{
			P_0 = SetDxFilter.Ⴀ(P_0, 278, 'Ŗ');
			while (true)
			{
				IL_007b:
				P_0 = SetTalkDefault.Ⴃ(P_0, 71, 'k');
				int num = ⴃႰ[110] - 21222;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴍႤ[228] - 16939;
						continue;
					case 2:
						break;
					case 0:
						goto IL_007b;
					case 3:
						P_0 = ShowContestStationHelp.Ⴅ(P_0, ReplyMail.Ⴅ(8, 0, 1217944247), string.Empty, 133, 'Ý');
						num = ⴍႭ[108] - 50259;
						continue;
					case 9:
						P_0 = ShowContestStationHelp.Ⴅ(P_0, SetStationClubHelp.Ⴍ(15, 4, 1747258083, null), string.Empty, 673, '\u02f9');
						num = ⴀႳ[236] - 22358;
						continue;
					case 7:
					case 8:
						P_0 = ShowContestStationHelp.Ⴅ(P_0, ReplyMailHelp.Ⴄ(24, null, 1057162481, 0), string.Empty, 492, 'ƴ');
						goto case 4;
					case 4:
						num = 1;
						continue;
					case 1:
						P_0 = P_0.Replace(SetTalkCount.Ⴗ(5, null, 1267015534, typeof(DxClusterListCache)), string.Empty);
						num = ⴃႥ[107] - 34866;
						continue;
					case 5:
						P_0 = P_0.Replace(ႨႨ.Ⴀ(11, 0, 1157898821), string.Empty);
						return P_0;
					}
					break;
				}
				break;
			}
		}
	}

	private static bool Ⴀ(HtmlNode P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		return MircIo.ႠႠ(P_0, 661, 705) == SetStationQth.Ⴍ(null, 1687355269, 5, 22);
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, bool P_1, int P_2, char P_3) where _0021_00210 : DirectoryMonitor
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				break;
			case 5:
				num = (((P_2 ^ P_3) - 27) ^ num2) switch
				{
					0 => 1, 
					_ => ⴃႥ[161] - 60129, 
				};
				break;
			case 3:
				num = 4;
				break;
			case 1:
			case 9:
				P_0.Enable = P_1;
				goto case 4;
			case 4:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴍႭ[225] - 31550) : (ⴄႷ[141] - ⴄႷ[141]));
				break;
			case 0:
				num = 5;
				break;
			case 6:
			case 7:
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static XmlElement Ⴐ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : string where _0021_00211 : XmlNode
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		XmlLinkedNode xmlLinkedNode = default(XmlLinkedNode);
		while (true)
		{
			int num = 0;
			int num2 = 7;
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
				case 7:
					num2 = (((P_3 ^ P_2) - 88) ^ num) switch
					{
						0 => ⴃႠ[48] - 38915, 
						_ => 10, 
					};
					continue;
				case 10:
					xmlLinkedNode = null;
					num2 = 0;
					continue;
				case 3:
					xmlLinkedNode = P_0[P_1];
					num2 = 0;
					continue;
				case 0:
				case 4:
				{
					num++;
					int num3 = 124;
					int num4 = 667;
					num2 = ((2001 > num4 - num3 * 3) ? (ⴀ[5] - 40814) : (ⴀႼ[31] - ⴀႼ[117]));
					continue;
				}
				case 8:
				case 11:
					num2 = ⴀႨ[78] - 17091;
					continue;
				case 1:
				case 5:
					return (XmlElement)xmlLinkedNode;
				case 9:
					num2 = ⴀႼ[1] - 217;
					continue;
				}
				break;
			}
		}
	}
}
