using System;
using System.Collections.Generic;
using System.Threading;
using ArcEngine.ArcCmds.User;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class DxSpotUniqueCacheWorker
{
	private static readonly ILog Ⴍ;

	private static readonly object Ⴍ;

	private Help.Ⴗ m_Ⴃ = new Help.Ⴗ();

	internal DxSpotUniqueCacheWorker()
	{
		object obj = new Dictionary<string, ႨႣ>();
		this.m_Ⴃ.Ⴍ = (Dictionary<string, ႨႣ>)obj;
	}

	internal byte Ⴃ(string P_0, string P_1)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool flag = false;
		object ⴍ = default(object);
		byte b = default(byte);
		try
		{
			int num = 7;
			object obj = default(object);
			object current = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴍ = Ⴍ, ref flag, 1008, 1017);
					goto case 4;
				case 4:
				{
					bool num4 = this.m_Ⴃ.Ⴍ.ContainsKey(P_0);
					AnnCacheCfg.ႠႼ[19] = (byte)((AnnCacheCfg.ႠႼ[19] * AnnCacheCfg.ႠႼ[107]) & 0xF3);
					num = (num4 ? (ⴄႭ[246] / 2) : 8);
					continue;
				}
				case 8:
				{
					object obj3 = new ႨႣ(P_1);
					this.m_Ⴃ.Ⴍ.Add(P_0, obj3 as ႨႣ);
					num = ⴃႰ[116] - 19363;
					continue;
				}
				case 5:
					b = 1;
					break;
				case 0:
					break;
				case 1:
					obj = this.m_Ⴃ.Ⴍ[P_0];
					(obj as ႨႣ).Ⴈ(ShowAnnHelp.Ⴅ('Ϳ', 846));
					num = 2;
					continue;
				case 2:
				{
					bool flag2 = false;
					List<ႨႳ>.Enumerator enumerator = (obj as ႨႣ).Ⴀ().GetEnumerator();
					try
					{
						int num2 = 2;
						while (true)
						{
							switch (num2)
							{
							default:
								num2 = 8;
								continue;
							case 5:
								current = enumerator.Current;
								num2 = ((!ByeHelp.Ⴍ((current as ႨႳ).Ⴀ(), P_1, 248, 159)) ? 8 : 3);
								continue;
							case 3:
								((ႨႳ)current).Ⴀ(ShowAnnHelp.Ⴅ('Ø', 233));
								goto case 0;
							case 0:
							case 4:
								flag2 = true;
								num2 = 1;
								continue;
							case 8:
								num2 = (enumerator.MoveNext() ? 5 : (ⴀႨ[56] - 34621));
								continue;
							case 1:
								break;
							}
							break;
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
							break;
						}
					}
					int num3 = 6;
					while (true)
					{
						switch (num3)
						{
						default:
							num3 = (flag2 ? (ⴃႰ[147] - 1282) : (ⴄႭ[276] - 188));
							continue;
						case 3:
						{
							object obj2 = new ႨႳ(P_1);
							((ႨႣ)obj).Ⴀ().Add(obj2 as ႨႳ);
							goto case 0;
						}
						case 0:
							((ႨႣ)obj).Ⴀ().RemoveAll(Ⴈ);
							goto case 4;
						case 4:
							num3 = (((obj as ႨႣ).Ⴀ().Count <= 255) ? (ⴍႤ[447] - 10161) : 2);
							continue;
						case 2:
						case 8:
							b = byte.MaxValue;
							break;
						case 5:
							b = (byte)(obj as ႨႣ).Ⴀ().Count;
							break;
						}
						break;
					}
					break;
				}
				}
				break;
			}
		}
		finally
		{
			int num5 = 6;
			while (true)
			{
				int num6;
				switch (num5)
				{
				default:
					num6 = (flag ? 3 : 0);
					goto IL_0328;
				case 3:
					Monitor.Exit(ⴍ);
					break;
				case 0:
				case 1:
					break;
				}
				break;
				IL_0328:
				num5 = num6;
			}
		}
		return 2 switch
		{
			_ => b, 
		};
	}

	private bool Ⴈ(ႨႳ P_0)
	{
		while (true)
		{
			TimeSpan timeSpan = SetWxMode.Ⴃ(ShowAnnHelp.Ⴅ('Ó', 226), P_0.Ⴅ(), 192, 142);
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 1;
					continue;
				case 0:
				case 1:
					break;
				case 2:
				case 3:
				case 4:
					return timeSpan.Minutes > 10;
				}
				break;
			}
		}
	}

	internal void Ⴈ()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		bool flag = false;
		object ⴍ = default(object);
		try
		{
			int num = 0;
			object obj = default(object);
			KeyValuePair<string, ႨႣ> current = default(KeyValuePair<string, ႨႣ>);
			TimeSpan timeSpan = default(TimeSpan);
			IEquatable<string> current2 = default(IEquatable<string>);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴍ = Ⴍ, ref flag, 502, 511);
					obj = new List<string>();
					break;
				case 5:
					break;
				case 1:
				case 3:
				case 4:
				{
					Dictionary<string, ႨႣ>.Enumerator enumerator = this.m_Ⴃ.Ⴍ.GetEnumerator();
					try
					{
						int num2 = 0;
						while (true)
						{
							switch (num2)
							{
							default:
								num2 = 9;
								continue;
							case 2:
								current = enumerator.Current;
								goto case 1;
							case 1:
								timeSpan = SetWxMode.Ⴃ(ShowAnnHelp.Ⴅ('Ʌ', 628), current.Value.Ⴈ(), 805, 875);
								num2 = 5;
								continue;
							case 5:
								num2 = ((ShowNodes.Ⴍ(ref timeSpan, 457, 'ǻ') <= 10) ? (ⴍႭ[139] - 7122) : ⴅ[145]);
								continue;
							case 4:
							case 6:
							case 7:
								(obj as List<string>).Add(current.Key);
								break;
							case 9:
								break;
							case 3:
								goto end_IL_0081;
							}
							num2 = (enumerator.MoveNext() ? 2 : 3);
							continue;
							end_IL_0081:
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
					switch (1)
					{
					default:
					{
						List<string>.Enumerator enumerator2 = (obj as List<string>).GetEnumerator();
						try
						{
							int num3 = 3;
							while (true)
							{
								switch (num3)
								{
								default:
									num3 = ⴍႭ[194] - 23754;
									continue;
								case 0:
									current2 = enumerator2.Current;
									goto case 1;
								case 1:
									this.m_Ⴃ.Ⴍ.Remove(current2 as string);
									num3 = ⴃႰ[166] - 25961;
									continue;
								case 5:
								{
									int num4;
									if (!enumerator2.MoveNext())
									{
										num4 = 7;
									}
									else
									{
										char num5 = ⴀ[27];
										SetTalkCountHelp.Ⴅ[114] = (byte)((SetTalkCountHelp.Ⴅ[114] - SetTalkCountHelp.Ⴅ[108]) & 3);
										num4 = num5 - 20742;
									}
									num3 = num4;
									continue;
								}
								case 2:
								case 4:
								case 7:
									break;
								}
								break;
							}
						}
						finally
						{
							switch (3)
							{
							default:
								((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
								break;
							case 4:
								break;
							}
						}
						switch (4)
						{
						}
						break;
					}
					}
					goto end_IL_0029;
				}
				}
				num = 3;
				continue;
				end_IL_0029:
				break;
			}
		}
		finally
		{
			int num6 = 5;
			while (true)
			{
				int num7;
				switch (num6)
				{
				default:
					num7 = ((!flag) ? (ⴃႥ[223] - 25459) : 0);
					goto IL_02bd;
				case 0:
					Monitor.Exit(ⴍ);
					break;
				case 1:
				case 3:
				case 4:
				case 6:
					break;
				}
				break;
				IL_02bd:
				num6 = num7;
			}
		}
		switch (2)
		{
		}
	}

	static DxSpotUniqueCacheWorker()
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
				Ⴍ = new object();
				return;
			case 1:
				return;
			}
			DxSpotUniqueCacheWorker.Ⴍ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216132906, 5, 'r'), 829, 800);
			num = ⴃႠ[191] - 42063;
		}
	}
}
