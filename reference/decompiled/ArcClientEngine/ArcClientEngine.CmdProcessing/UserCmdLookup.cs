using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Io;
using log4net;
using Ⴀ;

namespace ArcClientEngine.CmdProcessing;

public sealed class UserCmdLookup
{
	private static readonly ILog Ⴀ;

	private readonly Hashtable Ⴅ;

	public UserCmdLookup()
	{
		object obj = new ႥႥ();
		Ⴅ = new Hashtable();
		try
		{
			foreach (UserCmdCfg item in ((ႥႥ)obj).Ⴈ)
			{
				ProcessCommand(item as UserCmdCfg);
			}
		}
		catch (Exception ex)
		{
			Ⴀ.Error(FilterCfg.Ⴍ(ex as Exception, 456, 454));
		}
	}

	public UserCmdCfg GetCmdTag(string msg)
	{
		return (UserCmdCfg)Ⴅ[FilterViewer.ႨႷ(msg, 44, 7)];
	}

	public void ProcessCommand(UserCmdCfg userCmdCfg)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 0;
		Array array = default(Array);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
			{
				string text = ႥႤ.Ⴅ(userCmdCfg, 921, 'Ρ');
				Array array2 = new char[1];
				(array2 as char[])[0] = ' ';
				array = ႳႳ.Ⴄ(text, (char[])array2, 202, '\u0085');
				goto case 4;
			}
			case 4:
				num = 1;
				continue;
			case 1:
				num2 = (array as string[]).Length;
				break;
			case 2:
				break;
			case 3:
			case 5:
				return;
			}
			switch (num2)
			{
			default:
				num = ⴀႠ[4] - 3449;
				break;
			case 1:
				Ⴗ(userCmdCfg, array as string[]);
				return;
			case 2:
				Ⴓ(userCmdCfg, (string[])array);
				return;
			case 3:
				Ⴐ(userCmdCfg, (string[])array);
				return;
			case 4:
				Ⴃ(userCmdCfg, (string[])array);
				return;
			}
		}
	}

	private void Ⴗ(UserCmdCfg P_0, string[] P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		object obj = Ⴃ(P_1[0]);
		using List<string>.Enumerator enumerator = ((List<string>)obj).GetEnumerator();
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 2:
			{
				IEnumerable<char> current = enumerator.Current;
				ShowUsers.Ⴜ(Ⴅ, (object)(current as string), (object)P_0, 'Ś', (short)279);
				break;
			}
			case 0:
			case 3:
			case 4:
				return;
			}
			num = (enumerator.MoveNext() ? ⴅ[25] : 3);
		}
	}

	private void Ⴓ(UserCmdCfg P_0, string[] P_1)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 1;
		object obj = default(object);
		object obj2 = default(object);
		object current = default(object);
		object current2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = Ⴃ(P_1[0]);
				goto case 2;
			case 2:
				obj2 = Ⴃ(P_1[1]);
				break;
			case 4:
				break;
			case 0:
			case 3:
			{
				List<string>.Enumerator enumerator = ((List<string>)obj).GetEnumerator();
				try
				{
					switch (5)
					{
					case 1:
					case 3:
						current = enumerator.Current;
						goto case 4;
					case 4:
					{
						List<string>.Enumerator enumerator2 = ((List<string>)obj2).GetEnumerator();
						try
						{
							int num2 = 2;
							while (true)
							{
								switch (num2)
								{
								default:
									num2 = 1;
									continue;
								case 3:
								case 7:
									current2 = enumerator2.Current;
									goto case 0;
								case 0:
								case 5:
									ShowUsers.Ⴜ(Ⴅ, (object)ႥႭ.ႳႣ((object)(current as string), (object)' ', (object)(string)current2, 'á', 218), (object)P_0, 'λ', (short)1014);
									break;
								case 1:
									break;
								case 4:
									goto end_IL_0088;
								}
								bool num3 = enumerator2.MoveNext();
								ႥႰ.Ⴗ[4] = (char)((ႥႰ.Ⴗ[4] + ႥႰ.Ⴗ[5]) & 0x62);
								num2 = (num3 ? 7 : (ⴗ[82] - 57057));
								continue;
								end_IL_0088:
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
							case 4:
								break;
							}
						}
						goto default;
					}
					default:
					{
						int num4 = 1;
						while (true)
						{
							switch (num4)
							{
							default:
								if (!enumerator.MoveNext())
								{
									goto IL_0187;
								}
								break;
							case 0:
							case 2:
							case 4:
								goto end_IL_015c;
							}
							goto case 1;
							IL_0187:
							num4 = 4;
							continue;
							end_IL_015c:
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
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						break;
					case 4:
						break;
					}
				}
				switch (0)
				{
				}
				return;
			}
			}
			num = 3;
		}
	}

	private void Ⴐ(UserCmdCfg P_0, string[] P_1)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 4;
		object obj2 = default(object);
		object obj3 = default(object);
		IEquatable<string> current = default(IEquatable<string>);
		object current2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj2 = Ⴃ(P_1[0]);
				obj3 = Ⴃ(P_1[1]);
				break;
			case 3:
				break;
			case 0:
			case 1:
			case 2:
			{
				object obj = Ⴃ(P_1[2]);
				List<string>.Enumerator enumerator = (obj2 as List<string>).GetEnumerator();
				try
				{
					switch (2)
					{
					case 1:
					case 3:
					case 5:
						current = enumerator.Current;
						goto case 0;
					case 0:
					{
						List<string>.Enumerator enumerator2 = (obj3 as List<string>).GetEnumerator();
						try
						{
							switch (0)
							{
							case 2:
							case 5:
								current2 = enumerator2.Current;
								goto case 4;
							case 4:
							{
								List<string>.Enumerator enumerator3 = (obj as List<string>).GetEnumerator();
								try
								{
									int num2 = 2;
									while (true)
									{
										switch (num2)
										{
										default:
											num2 = 7;
											continue;
										case 0:
										case 4:
										{
											IComparable current3 = enumerator3.Current;
											Hashtable ⴅ2 = Ⴅ;
											object obj4 = new object[5];
											(obj4 as object[])[0] = (string)current;
											((object[])obj4)[1] = ' ';
											(obj4 as object[])[2] = current2 as string;
											(obj4 as object[])[3] = ' ';
											(obj4 as object[])[4] = (string)current3;
											ShowUsers.Ⴜ(ⴅ2, (object)ShowDxFilter.Ⴓ((object[])obj4, 369, 308), (object)P_0, '\u02f5', (short)696);
											break;
										}
										case 5:
										case 7:
											break;
										case 3:
											goto end_IL_00d9;
										}
										num2 = (enumerator3.MoveNext() ? (ⴀႠ[99] - 46020) : 3);
										continue;
										end_IL_00d9:
										break;
									}
								}
								finally
								{
									switch (1)
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
								int num3 = 0;
								while (true)
								{
									switch (num3)
									{
									default:
										if (!enumerator2.MoveNext())
										{
											goto IL_020b;
										}
										break;
									case 2:
									case 5:
										goto end_IL_01e0;
									}
									goto case 2;
									IL_020b:
									num3 = 2;
									continue;
									end_IL_01e0:
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
								((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
								break;
							case 2:
								break;
							}
						}
						goto default;
					}
					default:
					{
						int num4 = 2;
						while (true)
						{
							switch (num4)
							{
							default:
								if (!enumerator.MoveNext())
								{
									goto IL_026c;
								}
								break;
							case 3:
							case 5:
								goto end_IL_0241;
							}
							goto case 1;
							IL_026c:
							num4 = 3;
							continue;
							end_IL_0241:
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
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						break;
					case 2:
						break;
					}
				}
				switch (3)
				{
				}
				return;
			}
			}
			num = ⴅ[17];
		}
	}

	private void Ⴃ(UserCmdCfg P_0, string[] P_1)
	{
		int num = 1;
		object obj = default(object);
		object obj2 = default(object);
		object obj3 = default(object);
		object obj4 = default(object);
		IEnumerable<char> current = default(IEnumerable<char>);
		object current2 = default(object);
		IEnumerable<char> current4 = default(IEnumerable<char>);
		while (true)
		{
			switch (num)
			{
			default:
				obj = Ⴃ(P_1[0]);
				obj2 = Ⴃ(P_1[1]);
				num = 5;
				break;
			case 5:
				obj3 = Ⴃ(P_1[2]);
				goto case 3;
			case 3:
				obj4 = Ⴃ(P_1[3]);
				num = 2;
				break;
			case 0:
			case 2:
			{
				List<string>.Enumerator enumerator = (obj as List<string>).GetEnumerator();
				try
				{
					switch (0)
					{
					case 3:
					case 5:
						current = enumerator.Current;
						goto case 4;
					case 4:
					{
						List<string>.Enumerator enumerator2 = (obj2 as List<string>).GetEnumerator();
						try
						{
							switch (0)
							{
							case 5:
								current2 = enumerator2.Current;
								goto case 1;
							case 1:
							case 2:
							{
								List<string>.Enumerator enumerator3 = (obj3 as List<string>).GetEnumerator();
								try
								{
									switch (2)
									{
									case 5:
									{
										IComparable current3 = enumerator3.Current;
										List<string>.Enumerator enumerator4 = (obj4 as List<string>).GetEnumerator();
										try
										{
											int num2 = 5;
											while (true)
											{
												switch (num2)
												{
												default:
													num2 = 4;
													continue;
												case 7:
													current4 = enumerator4.Current;
													goto case 3;
												case 3:
												case 6:
												{
													Hashtable ⴅ = Ⴅ;
													object obj5 = new object[7];
													((object[])obj5)[0] = current as string;
													((object[])obj5)[1] = ' ';
													(obj5 as object[])[2] = (string)current2;
													(obj5 as object[])[3] = ' ';
													((object[])obj5)[4] = current3 as string;
													(obj5 as object[])[5] = ' ';
													(obj5 as object[])[6] = (string)current4;
													ShowUsers.Ⴜ(ⴅ, (object)ShowDxFilter.Ⴓ(obj5 as object[], 324, 257), (object)P_0, 'â', (short)175);
													break;
												}
												case 4:
													break;
												case 2:
													goto end_IL_0117;
												}
												num2 = (enumerator4.MoveNext() ? 7 : 2);
												continue;
												end_IL_0117:
												break;
											}
										}
										finally
										{
											switch (2)
											{
											default:
												((IDisposable)enumerator4/*cast due to .constrained prefix*/).Dispose();
												break;
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
													goto IL_0260;
												}
												break;
											case 3:
												goto end_IL_0235;
											}
											goto case 5;
											IL_0260:
											num3 = 3;
											continue;
											end_IL_0235:
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
										((IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
										break;
									case 1:
									case 2:
									case 3:
										break;
									}
								}
								goto default;
							}
							default:
							{
								int num4 = 2;
								while (true)
								{
									switch (num4)
									{
									default:
										if (!enumerator2.MoveNext())
										{
											goto IL_02c1;
										}
										break;
									case 3:
									case 4:
										goto end_IL_0296;
									}
									goto case 5;
									IL_02c1:
									num4 = 4;
									continue;
									end_IL_0296:
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
							}
						}
						goto default;
					}
					default:
					{
						int num5 = 4;
						while (true)
						{
							switch (num5)
							{
							default:
								if (!enumerator.MoveNext())
								{
									goto IL_0322;
								}
								break;
							case 5:
								goto end_IL_02f7;
							}
							goto case 3;
							IL_0322:
							num5 = 5;
							continue;
							end_IL_02f7:
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
					case 3:
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
		}
	}

	private static List<string> Ⴃ(string P_0)
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		object obj2 = default(object);
		int num2 = default(int);
		char c = default(char);
		while (true)
		{
			object obj = new List<string>();
			bool flag = false;
			IComparable<string> comparable = string.Empty;
			Array array = ႳႰ.Ⴐ(P_0, 500, 505);
			int num = 13;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄ[163] - 58286;
					continue;
				case 10:
				case 12:
					break;
				case 13:
					obj2 = array as char[];
					goto case 7;
				case 7:
					num2 = 0;
					num = 11;
					continue;
				case 3:
					c = ((char[])obj2)[num2];
					num = (flag ? (ⴄ[304] - 28904) : (ⴅ[364] - 206));
					continue;
				case 9:
					num = ((!HighlightCountyCfg.ႷႰ(c, 790, 'ͳ')) ? 2 : 15);
					continue;
				case 15:
					flag = true;
					((List<string>)obj).Add(FilterViewer.ႨႷ(comparable as string, 130, 169));
					goto case 1;
				case 1:
				case 2:
					comparable = ႥႭ.ႳႭ((object)(string)comparable, (object)c, (short)127, 82);
					num = ((!flag) ? (ⴗ[12] - 296) : 4);
					continue;
				case 4:
					(obj as List<string>).Add(FilterViewer.ႨႷ((string)comparable, 340, 383));
					goto case 5;
				case 5:
					num2++;
					num = ⴀႠ[126] - 21883;
					continue;
				case 11:
					num = ((num2 < ((char[])obj2).Length) ? 3 : 6);
					continue;
				case 6:
					num = (flag ? (ⴀႠ[94] - 21814) : 8);
					continue;
				case 8:
					((List<string>)obj).Add(P_0.ToLower());
					goto case 14;
				case 14:
					return (List<string>)obj;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static UserCmdLookup()
	{
		ArcClientConnectDat.Ⴍ();
		Ⴀ = HighlightItuZoneCfg.Ⴓ(ClientCty.Ⴗ('Z', 7, 307011861), 39, 23);
	}
}
