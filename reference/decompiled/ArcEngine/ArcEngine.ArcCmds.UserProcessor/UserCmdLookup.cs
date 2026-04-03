using System;
using System.Collections;
using System.Collections.Generic;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.UserProcessor;

public sealed class UserCmdLookup
{
	private static readonly ILog Ⴀ = SkimmerValidSpot.Ⴐ(ReplyMail.Ⴅ(3, 14, 1217943617), 710, 731);

	private readonly Hashtable m_Ⴍ;

	public UserCmdLookup()
	{
		object obj = new ႰႥ();
		this.m_Ⴍ = new Hashtable();
		try
		{
			foreach (UserCmdCfg item in (obj as ႰႥ).Ⴃ)
			{
				ProcessCommand(item as UserCmdCfg);
			}
		}
		catch (Exception ex)
		{
			Ⴀ.Error(SkimmerSpotBins.Ⴈ(ex, 374, 344));
		}
	}

	public UserCmdCfg GetCmdTag(string msg)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		return (UserCmdCfg)this.m_Ⴍ[LogEntry.Ⴄ(msg, '\u030b', 801)];
	}

	public void ProcessCommand(UserCmdCfg userCmdCfg)
	{
		int num = 3;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				string text = SetStationHereHelp.Ⴗ(userCmdCfg, '\u00a0', 234);
				object obj2 = new char[1];
				(obj2 as char[])[0] = ' ';
				obj = Directory.Ⴓ(text, (char[])obj2, 429, 507);
				num = 4;
				break;
			}
			case 4:
			case 5:
				switch ((obj as string[]).Length)
				{
				default:
					num = 1;
					break;
				case 1:
					Ⴈ(userCmdCfg, obj as string[]);
					return;
				case 2:
					Ⴗ(userCmdCfg, obj as string[]);
					return;
				case 3:
					Ⴅ(userCmdCfg, (string[])obj);
					return;
				case 4:
					Ⴍ(userCmdCfg, obj as string[]);
					return;
				}
				break;
			case 0:
			case 1:
				return;
			}
		}
	}

	private void Ⴈ(UserCmdCfg P_0, string[] P_1)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		object obj = Ⴍ(P_1[0]);
		using List<string>.Enumerator enumerator = ((List<string>)obj).GetEnumerator();
		int num = 6;
		IEquatable<string> current = default(IEquatable<string>);
		while (true)
		{
			switch (num)
			{
			case 5:
				current = enumerator.Current;
				goto case 3;
			case 3:
				HealthMonitorCfg.Ⴍ(this.m_Ⴍ, (object)(string)current, (object)P_0, (short)41, '\u001d');
				break;
			case 1:
			case 2:
			case 4:
				return;
			}
			num = (enumerator.MoveNext() ? 5 : (ⴅ[365] / 3));
		}
	}

	private void Ⴗ(UserCmdCfg P_0, string[] P_1)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 0;
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = Ⴍ(P_1[0]);
				break;
			case 2:
				break;
			case 3:
			case 4:
			{
				List<string>.Enumerator enumerator = ((List<string>)obj).GetEnumerator();
				try
				{
					switch (1)
					{
					case 2:
					case 5:
					{
						object current = enumerator.Current;
						List<string>.Enumerator enumerator2 = (obj2 as List<string>).GetEnumerator();
						try
						{
							int num2 = 4;
							while (true)
							{
								switch (num2)
								{
								default:
									num2 = 7;
									continue;
								case 0:
								{
									IComparable<string> current2 = enumerator2.Current;
									HealthMonitorCfg.Ⴍ(this.m_Ⴍ, (object)ShowPrefixCalls.Ⴃ((object)(string)current, (object)' ', (object)(string)current2, 'ɗ', 637), (object)P_0, (short)949, '\u0381');
									break;
								}
								case 6:
								case 7:
									break;
								case 3:
									goto end_IL_009c;
								}
								num2 = (enumerator2.MoveNext() ? (ⴀႨ[221] - ⴀႨ[221]) : 3);
								continue;
								end_IL_009c:
								break;
							}
						}
						finally
						{
							switch (2)
							{
							default:
								((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
								break;
							}
						}
						goto default;
					}
					default:
					{
						int num3 = 0;
						while (true)
						{
							switch (num3)
							{
							default:
								if (!enumerator.MoveNext())
								{
									goto IL_0185;
								}
								break;
							case 5:
								goto end_IL_015a;
							}
							goto case 2;
							IL_0185:
							num3 = 5;
							continue;
							end_IL_015a:
							break;
						}
						break;
					}
					}
				}
				finally
				{
					switch (0)
					{
					default:
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						break;
					case 1:
					case 2:
					case 4:
						break;
					}
				}
				switch (3)
				{
				}
				return;
			}
			}
			obj2 = Ⴍ(P_1[1]);
			num = ⴍႤ[201] - 14719;
		}
	}

	private void Ⴅ(UserCmdCfg P_0, string[] P_1)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 0;
		object obj2 = default(object);
		object obj3 = default(object);
		IComparable<string> current2 = default(IComparable<string>);
		while (true)
		{
			switch (num)
			{
			default:
				obj2 = Ⴍ(P_1[0]);
				break;
			case 3:
				break;
			case 1:
			case 2:
			case 4:
			{
				object obj = Ⴍ(P_1[2]);
				List<string>.Enumerator enumerator = ((List<string>)obj2).GetEnumerator();
				try
				{
					switch (4)
					{
					case 2:
					case 3:
					{
						IEquatable<string> current = enumerator.Current;
						List<string>.Enumerator enumerator2 = ((List<string>)obj3).GetEnumerator();
						try
						{
							switch (0)
							{
							case 4:
								current2 = enumerator2.Current;
								goto case 1;
							case 1:
							case 2:
							{
								List<string>.Enumerator enumerator3 = ((List<string>)obj).GetEnumerator();
								try
								{
									int num2 = 5;
									while (true)
									{
										switch (num2)
										{
										default:
											num2 = ⴍႤ[415] - 11566;
											continue;
										case 1:
										case 2:
										{
											ICloneable current3 = enumerator3.Current;
											Hashtable ⴍ = this.m_Ⴍ;
											object obj4 = new object[5];
											((object[])obj4)[0] = current as string;
											(obj4 as object[])[1] = ' ';
											(obj4 as object[])[2] = (string)current2;
											(obj4 as object[])[3] = ' ';
											(obj4 as object[])[4] = current3 as string;
											HealthMonitorCfg.Ⴍ(ⴍ, (object)SetDxDefaultHelp.Ⴍ((object[])obj4, 'ɹ', 528), (object)P_0, (short)77, 'y');
											break;
										}
										case 0:
										case 6:
										case 7:
											break;
										case 4:
											goto end_IL_00d5;
										}
										num2 = (enumerator3.MoveNext() ? (ⴍႤ[35] - 22573) : (ⴄႤ[170] - 208));
										continue;
										end_IL_00d5:
										break;
									}
								}
								finally
								{
									switch (0)
									{
									default:
										((IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
										break;
									}
								}
								goto default;
							}
							default:
							{
								int num3 = 3;
								while (true)
								{
									switch (num3)
									{
									default:
										if (!enumerator2.MoveNext())
										{
											goto IL_021b;
										}
										break;
									case 0:
									case 1:
									case 2:
										goto end_IL_01f0;
									}
									goto case 4;
									IL_021b:
									num3 = 2;
									continue;
									end_IL_01f0:
									break;
								}
								break;
							}
							}
						}
						finally
						{
							switch (4)
							{
							default:
								((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
								break;
							case 1:
							case 3:
								break;
							}
						}
						goto default;
					}
					default:
					{
						int num4 = 0;
						while (true)
						{
							switch (num4)
							{
							default:
								if (!enumerator.MoveNext())
								{
									goto IL_027c;
								}
								break;
							case 5:
								goto end_IL_0251;
							}
							goto case 2;
							IL_027c:
							num4 = 5;
							continue;
							end_IL_0251:
							break;
						}
						break;
					}
					}
				}
				finally
				{
					switch (0)
					{
					default:
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						break;
					case 2:
					case 4:
						break;
					}
				}
				switch (1)
				{
				}
				return;
			}
			}
			obj3 = Ⴍ(P_1[1]);
			num = 4;
		}
	}

	private void Ⴍ(UserCmdCfg P_0, string[] P_1)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 4;
		object obj = default(object);
		object obj2 = default(object);
		object obj3 = default(object);
		object obj4 = default(object);
		IEnumerable current = default(IEnumerable);
		IConvertible current3 = default(IConvertible);
		IEnumerable<char> current4 = default(IEnumerable<char>);
		while (true)
		{
			switch (num)
			{
			default:
				obj = Ⴍ(P_1[0]);
				obj2 = Ⴍ(P_1[1]);
				goto case 2;
			case 2:
				num = 1;
				break;
			case 1:
				obj3 = Ⴍ(P_1[2]);
				obj4 = Ⴍ(P_1[3]);
				num = 3;
				break;
			case 3:
			case 5:
			{
				List<string>.Enumerator enumerator = (obj as List<string>).GetEnumerator();
				try
				{
					switch (1)
					{
					case 0:
						current = enumerator.Current;
						goto case 4;
					case 4:
					{
						List<string>.Enumerator enumerator2 = (obj2 as List<string>).GetEnumerator();
						try
						{
							switch (4)
							{
							case 1:
							case 3:
							{
								IEnumerable<char> current2 = enumerator2.Current;
								List<string>.Enumerator enumerator3 = ((List<string>)obj3).GetEnumerator();
								try
								{
									switch (1)
									{
									case 0:
									case 3:
										current3 = enumerator3.Current;
										goto case 5;
									case 5:
									{
										List<string>.Enumerator enumerator4 = (obj4 as List<string>).GetEnumerator();
										try
										{
											int num2 = 6;
											while (true)
											{
												switch (num2)
												{
												default:
													num2 = 7;
													continue;
												case 4:
													current4 = enumerator4.Current;
													goto case 1;
												case 1:
												case 2:
												{
													Hashtable ⴍ = this.m_Ⴍ;
													Array array = new object[7];
													(array as object[])[0] = current as string;
													((object[])array)[1] = ' ';
													((object[])array)[2] = current2 as string;
													((object[])array)[3] = ' ';
													((object[])array)[4] = current3 as string;
													((object[])array)[5] = ' ';
													((object[])array)[6] = (string)current4;
													HealthMonitorCfg.Ⴍ(ⴍ, (object)SetDxDefaultHelp.Ⴍ(array as object[], 'Ǉ', 430), (object)P_0, (short)202, 'þ');
													break;
												}
												case 5:
												case 7:
													break;
												case 3:
													goto end_IL_012c;
												}
												num2 = (enumerator4.MoveNext() ? (ⴀႣ[217] - 50652) : (ⴍႭ[52] - 72));
												continue;
												end_IL_012c:
												break;
											}
										}
										finally
										{
											switch (1)
											{
											default:
												((IDisposable)enumerator4/*cast due to .constrained prefix*/).Dispose();
												break;
											case 3:
											case 4:
												break;
											}
										}
										goto default;
									}
									default:
									{
										int num3 = 2;
										while (true)
										{
											switch (num3)
											{
											default:
												if (!enumerator3.MoveNext())
												{
													goto IL_0289;
												}
												break;
											case 1:
											case 3:
											case 4:
												goto end_IL_025e;
											}
											goto case 0;
											IL_0289:
											num3 = 3;
											continue;
											end_IL_025e:
											break;
										}
										break;
									}
									}
								}
								finally
								{
									switch (3)
									{
									default:
										((IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
										break;
									}
								}
								goto default;
							}
							default:
							{
								int num4 = 0;
								while (true)
								{
									switch (num4)
									{
									default:
										if (!enumerator2.MoveNext())
										{
											goto IL_02ea;
										}
										break;
									case 1:
										goto end_IL_02bf;
									}
									goto case 1;
									IL_02ea:
									num4 = ⴄႤ[148];
									continue;
									end_IL_02bf:
									break;
								}
								break;
							}
							}
						}
						finally
						{
							switch (1)
							{
							default:
								((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
								break;
							}
						}
						goto default;
					}
					default:
					{
						int num5 = 2;
						while (true)
						{
							switch (num5)
							{
							default:
								if (!enumerator.MoveNext())
								{
									goto IL_0352;
								}
								break;
							case 3:
							case 4:
								goto end_IL_0327;
							}
							goto case 0;
							IL_0352:
							num5 = ⴀႣ[186] - 23874;
							continue;
							end_IL_0327:
							break;
						}
						break;
					}
					}
				}
				finally
				{
					switch (2)
					{
					default:
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						break;
					case 1:
						break;
					}
				}
				switch (0)
				{
				}
				return;
			}
			}
		}
	}

	private static List<string> Ⴍ(string P_0)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		object obj3 = default(object);
		int num2 = default(int);
		char c = default(char);
		while (true)
		{
			object obj = new List<string>();
			bool flag = false;
			IEnumerable enumerable = string.Empty;
			object obj2 = SkimmerServerData.Ⴃ(P_0, 'ο', 1011);
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႰ[28] - 44205;
					continue;
				case 7:
					break;
				case 5:
					obj3 = (char[])obj2;
					num2 = 0;
					num = 14;
					continue;
				case 2:
					c = (obj3 as char[])[num2];
					num = (flag ? (ⴀႨ[17] - 11459) : 6);
					continue;
				case 6:
					num = ((!HamQthDotComLookupExt.Ⴍ(c, 930, 'φ')) ? 9 : (ⴄႭ[281] - ⴄႭ[14]));
					continue;
				case 1:
					flag = true;
					((List<string>)obj).Add(LogEntry.Ⴄ(enumerable as string, 'ϣ', 969));
					goto case 9;
				case 9:
					enumerable = SetWxCountHelp.Ⴗ((object)(enumerable as string), (object)c, 253, (short)134);
					num = ((!flag) ? ⴅ[365] : 11);
					continue;
				case 4:
				case 11:
					(obj as List<string>).Add(LogEntry.Ⴄ(enumerable as string, 'b', 72));
					goto case 12;
				case 12:
					num2++;
					num = 14;
					continue;
				case 14:
					num = ((num2 < (obj3 as char[]).Length) ? (ⴀ[338] - 25698) : 8);
					continue;
				case 8:
				case 10:
					num = ((!flag) ? 3 : 0);
					continue;
				case 3:
					(obj as List<string>).Add(P_0.ToLower());
					goto case 0;
				case 0:
					return (List<string>)obj;
				}
				break;
			}
		}
	}
}
