using System;
using System.Collections.Generic;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ShowCluster : IArcCmd
{
	private sealed class ႨႥ
	{
		public NodeUserCmd Ⴄ;
	}

	private sealed class ႨႠ
	{
		public ႨႥ Ⴀ;

		public int Ⴍ;

		public void Ⴍ(ArcConnect P_0)
		{
			this.Ⴍ += Ⴀ(Ⴀ.Ⴄ, P_0);
		}
	}

	private sealed class ႨႨ
	{
		public int Ⴄ;

		public string Ⴃ;

		public NodeUserCmd Ⴄ;

		public void Ⴃ(ArcConnect P_0)
		{
			char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				default:
					this.Ⴃ = ShowUsersHelp.Ⴅ(this.Ⴃ, ShowAnnHelp.Ⴀ(P_0.Call, 12, 446, 488), 105, 39);
					num = 2;
					break;
				case 2:
					this.Ⴄ++;
					num = ((this.Ⴄ != 5) ? 1 : (ⴀႳ[170] - 9999));
					break;
				case 3:
				case 6:
					Ⴄ.Tx.Msg.Add(this.Ⴃ);
					this.Ⴄ = 0;
					goto case 7;
				case 7:
					num = 5;
					break;
				case 5:
					this.Ⴃ = string.Empty.PadRight(16);
					num = ⴍႤ[84] - 23388;
					break;
				case 1:
				case 4:
					return;
				}
			}
		}
	}

	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(ReplyMail.Ⴅ(2, 14, 1217944166), 131, 158);

	private static Comparison<ArcConnect> Ⴍ;

	private static Comparison<ArcConnect> Ⴐ;

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		object obj = new ႨႥ();
		((ႨႥ)obj).Ⴄ = cmd;
		try
		{
			int num = 3;
			object obj4 = default(object);
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			KeyValuePair<Guid, ArcConnect> current2 = default(KeyValuePair<Guid, ArcConnect>);
			int num12 = default(int);
			object obj3 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj4 = new ႨႠ();
					goto case 5;
				case 5:
					(obj4 as ႨႠ).Ⴀ = obj as ႨႥ;
					((ႨႥ)obj).Ⴄ.Tx.DistroType = DistroType.ToRequester;
					num = 6;
					continue;
				case 6:
					(obj as ႨႥ).Ⴄ.Tx.Msg.Add(ႰႥ.Ⴅ(3, '~', 952621146));
					num = ⴅ[476] - ⴅ[69];
					continue;
				case 1:
				case 7:
					(obj as ႨႥ).Ⴄ.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267019762, typeof(AnnLocalUser)));
					num = ⴄႤ[47] / 3;
					continue;
				case 4:
					((ႨႠ)obj4).Ⴍ = Ⴀ(((ႨႥ)obj).Ⴄ, ((ႨႥ)obj).Ⴄ.Ⴍ().Ⴅ().Ⴓ());
					num = 0;
					continue;
				case 0:
				case 2:
				{
					object obj2 = new List<ArcConnect>();
					object enumerator = ((ႨႥ)obj).Ⴄ.Ⴍ().Ⴅ().Ⴓ()
						.ArcConnects.GetEnumerator();
					try
					{
						int num2 = 0;
						while (true)
						{
							switch (num2)
							{
							case 5:
							{
								current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
								int num8;
								if (current.Value.Ⴃ())
								{
									char num7 = ⴍႭ[74];
									SetDxCountHelp.ႭႤ[162] = (SetDxCountHelp.ႭႤ[162] ^ ShowSunHelp.ႣႠ[300]) & 0xD7;
									num8 = num7 - 63171;
								}
								else
								{
									num8 = 7;
								}
								num2 = num8;
								continue;
							}
							case 6:
								num2 = ((current.Value.ConnectState == ConnectStateType.ArxNode) ? 9 : 8);
								continue;
							case 1:
							case 8:
								num2 = ((current.Value.ConnectState != ConnectStateType.PcxxNode) ? (ⴀ[243] - 39963) : 9);
								continue;
							case 2:
							case 9:
								((List<ArcConnect>)obj2).Add(current.Value);
								goto case 7;
							case 7:
							{
								object enumerator2 = current.Value.ArcConnects.GetEnumerator();
								try
								{
									int num3 = 1;
									while (true)
									{
										switch (num3)
										{
										default:
											num3 = ⴐ[48] - 148;
											continue;
										case 3:
										case 9:
											current2 = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator2).Current;
											num3 = ((!current.Value.Ⴃ()) ? 10 : 6);
											continue;
										case 5:
										case 6:
											num3 = ((current2.Value.ConnectState == ConnectStateType.ArxNode) ? (ⴀ[20] - 20319) : (ⴄႷ[11] - 38822));
											continue;
										case 2:
										case 7:
											num3 = ((current2.Value.ConnectState != ConnectStateType.PcxxNode) ? (ⴃႠ[116] - 41297) : 8);
											continue;
										case 8:
											(obj2 as List<ArcConnect>).Add(current2.Value);
											break;
										case 10:
											break;
										case 4:
											goto end_IL_0299;
										}
										num3 = ((enumerator2 as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? 9 : (ⴃႥ[118] - 60960));
										continue;
										end_IL_0299:
										break;
									}
								}
								finally
								{
									int num4 = 3;
									while (true)
									{
										int num5;
										switch (num4)
										{
										default:
											num5 = ((!(enumerator2 is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? ⴄႤ[135] : (ⴃႰ[50] - 2568));
											goto IL_03c2;
										case 4:
											(enumerator2 as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
											break;
										case 0:
										case 5:
											break;
										}
										break;
										IL_03c2:
										num4 = num5;
									}
								}
								goto default;
							}
							default:
							{
								int num6 = 2;
								while (true)
								{
									switch (num6)
									{
									default:
										if (!(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext())
										{
											goto IL_0410;
										}
										break;
									case 0:
									case 3:
										goto end_IL_03e0;
									}
									goto case 5;
									IL_0410:
									num6 = 0;
									continue;
									end_IL_03e0:
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
						int num9 = 4;
						while (true)
						{
							int num10;
							switch (num9)
							{
							default:
								num10 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 6 : (ⴀ[287] - 59343));
								goto IL_0454;
							case 2:
								((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
								break;
							case 6:
								break;
							}
							break;
							IL_0454:
							num9 = num10;
						}
					}
					int num11 = 5;
					while (true)
					{
						switch (num11)
						{
						default:
						{
							List<ArcConnect> obj5 = obj2 as List<ArcConnect>;
							if (Ⴍ == null)
							{
								Ⴍ = Ⴈ;
							}
							obj5.Sort(Ⴍ);
							((List<ArcConnect>)obj2).ForEach((obj4 as ႨႠ).Ⴍ);
							num12 = ((List<ArcConnect>)obj2).Count + 1;
							goto case 0;
						}
						case 0:
							num11 = 4;
							continue;
						case 4:
							(obj as ႨႥ).Ⴄ.Tx.Msg.Add(qslinfoResponse.Ⴗ(CallBlockCacheCfg.Ⴅ(null, 3, 62054636, null), num12.ToString(), SetStationQth.Ⴍ(null, 1687352347, 3, 26), (obj4 as ႨႠ).Ⴍ.ToString(), 137, 'ê'));
							goto case 2;
						case 2:
							num11 = 6;
							continue;
						case 6:
							(obj as ႨႥ).Ⴄ.Ⴀ();
							obj3 = new Publisher();
							break;
						case 3:
							break;
						}
						break;
					}
					((Publisher)obj3).Process(((ႨႥ)obj).Ⴄ);
					break;
				}
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴅ.Error(SkimmerSpotBins.Ⴈ(ex, 247, 217));
		}
		switch (0)
		{
		}
	}

	private static int Ⴀ(NodeUserCmd P_0, ArcConnect P_1)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		object obj = new ႨႨ();
		(obj as ႨႨ).Ⴄ = P_0;
		object obj2 = new List<ArcConnect>();
		object enumerator = P_1.ArcConnects.GetEnumerator();
		try
		{
			int num = 8;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num)
				{
				default:
					num = 7;
					continue;
				case 0:
					current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
					num = ((!current.Value.Ⴃ()) ? 7 : (ⴀႣ[107] - 27059));
					continue;
				case 6:
					num = ((current.Value.ConnectState == ConnectStateType.ArxClient) ? 5 : (ⴃႰ[71] - 42562));
					continue;
				case 4:
					num = ((current.Value.ConnectState == ConnectStateType.PcxxUser) ? (ⴀႼ[93] - 130) : (ⴍႭ[136] - 20900));
					continue;
				case 2:
					num = ((current.Value.ConnectState == ConnectStateType.TelnetUser) ? 5 : 12);
					continue;
				case 12:
					num = ((current.Value.ConnectState != ConnectStateType.AgwBpqUser) ? 7 : 5);
					continue;
				case 5:
				case 10:
					(obj2 as List<ArcConnect>).Add(current.Value);
					break;
				case 7:
					break;
				case 3:
					goto end_IL_0079;
				}
				num = ((!(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext()) ? 3 : 0);
				continue;
				end_IL_0079:
				break;
			}
		}
		finally
		{
			int num2 = 4;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator == null) ? 5 : (ⴄႷ[56] - 36248));
					goto IL_01d4;
				case 0:
				case 6:
					(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
					break;
				case 5:
					break;
				}
				break;
				IL_01d4:
				num2 = num3;
			}
		}
		int num4 = 6;
		while (true)
		{
			switch (num4)
			{
			default:
				(obj as ႨႨ).Ⴄ = 0;
				((ႨႨ)obj).Ⴃ = ShowAnnHelp.Ⴀ(P_1.Call, 16, 1022, 936);
				goto case 5;
			case 5:
				num4 = 2;
				continue;
			case 2:
			{
				List<ArcConnect> obj3 = obj2 as List<ArcConnect>;
				if (Ⴐ == null)
				{
					Ⴐ = Ⴗ;
				}
				obj3.Sort(Ⴐ);
				(obj2 as List<ArcConnect>).ForEach(((ႨႨ)obj).Ⴃ);
				goto case 4;
			}
			case 4:
				num4 = ((CallBlockCacheCfg.Ⴜ(((ႨႨ)obj).Ⴃ, 906, 1003) <= 14) ? 7 : (ⴀႳ[130] - 25463));
				continue;
			case 0:
			case 1:
				((ႨႨ)obj).Ⴄ.Tx.Msg.Add(((ႨႨ)obj).Ⴃ);
				break;
			case 7:
				break;
			}
			break;
		}
		return (obj2 as List<ArcConnect>).Count;
	}

	private static int Ⴈ(ArcConnect P_0, ArcConnect P_1)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		return SetStationLoginCmds.Ⴀ(P_0.Call, P_1.Call, 785, 817);
	}

	private static int Ⴗ(ArcConnect P_0, ArcConnect P_1)
	{
		return SetStationLoginCmds.Ⴀ(P_0.Call, P_1.Call, 337, 369);
	}
}
