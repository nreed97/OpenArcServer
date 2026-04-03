using System;
using System.Collections;
using System.Collections.Generic;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Dx;
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
using ArcInterfaces;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ShowUsers : IArcCmd
{
	private sealed class ႨႭ
	{
		public ShowUsers Ⴅ;

		public NodeUserCmd Ⴀ;

		public void Ⴃ(string P_0)
		{
			Ⴅ.Ⴀ(Ⴀ, P_0);
		}
	}

	private int Ⴅ;

	private string m_Ⴍ;

	private static Comparison<string> Ⴃ;

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 5;
		object obj6 = default(object);
		object obj2 = default(object);
		object obj = default(object);
		KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
		while (true)
		{
			int num5;
			switch (num)
			{
			default:
				obj6 = null;
				obj2 = new ႨႭ();
				(obj2 as ႨႭ).Ⴀ = cmd;
				(obj2 as ႨႭ).Ⴅ = this;
				goto case 2;
			case 2:
				num = ⴀႨ[33] - 62155;
				break;
			case 1:
			case 6:
				((ႨႭ)obj2).Ⴀ.Tx.DistroType = DistroType.ToRequester;
				goto case 0;
			case 0:
				if (((ႨႭ)obj2).Ⴀ.Rx.Split.Length == 2)
				{
					num = ⴐ[21];
					break;
				}
				goto IL_03eb;
			case 3:
				(obj2 as ႨႭ).Ⴀ.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ReplyMailHelp.Ⴄ(9, null, 1057165677, 2), ((ႨႭ)obj2).Ⴀ.Ⴍ().Ⴅ().Ⴓ()
					.Call, 891, 821));
					num = ⴀႣ[230] - 15834;
					break;
				case 4:
					{
						obj = new List<string>();
						object enumerator = (obj2 as ႨႭ).Ⴀ.Ⴍ().Ⴅ().Ⴓ()
							.ArcConnects.GetEnumerator();
						try
						{
							int num2 = 7;
							while (true)
							{
								switch (num2)
								{
								default:
									num2 = 9;
									continue;
								case 1:
									current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
									num2 = ((!current.Value.Ⴄ()) ? 6 : (ⴃႥ[371] - 56153));
									continue;
								case 10:
								{
									ConnectStateType connectState = current.Value.ConnectState;
									ShowQrzHelp.ႤႤ[269] = (byte)((ShowQrzHelp.ႤႤ[269] * ShowQrzHelp.ႤႤ[74]) & 0x99);
									num2 = ((connectState == ConnectStateType.TelnetUser) ? (ⴃႠ[398] - 15621) : 6);
									continue;
								}
								case 6:
									num2 = ((current.Value.ConnectState == ConnectStateType.AgwBpqUser) ? 4 : (ⴀ[287] - 59334));
									continue;
								case 8:
								case 11:
									num2 = ((current.Value.ConnectState != ConnectStateType.ArxClient) ? (ⴅ[438] - 136) : 4);
									continue;
								case 4:
									(obj as List<string>).Add(current.Value.Ⴓ());
									break;
								case 9:
									break;
								case 2:
									goto end_IL_0175;
								}
								num2 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).MoveNext() ? (ⴃႥ[80] - 2255) : 2);
								continue;
								end_IL_0175:
								break;
							}
						}
						finally
						{
							int num3 = 3;
							while (true)
							{
								bool num4;
								switch (num3)
								{
								default:
									num4 = (IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator == null;
									goto IL_02e8;
								case 0:
								case 4:
									((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
									break;
								case 1:
								case 5:
									break;
								}
								break;
								IL_02e8:
								num3 = (num4 ? 1 : 0);
							}
						}
						num5 = 4;
						goto IL_02ff;
					}
					IL_02ff:
					while (true)
					{
						switch (num5)
						{
						default:
						{
							Ⴅ = 0;
							this.m_Ⴍ = string.Empty;
							List<string> obj4 = (List<string>)obj;
							if (Ⴃ == null)
							{
								Ⴃ = Ⴓ;
							}
							obj4.Sort(Ⴃ);
							List<string> obj5 = obj as List<string>;
							if (!(obj6 is Action<string>))
							{
								obj6 = new Action<string>(((ႨႭ)obj2).Ⴃ);
							}
							obj5.ForEach(obj6 as Action<string>);
							num5 = ((Ⴅ <= 0) ? 1 : (ⴃႰ[107] - 9435));
							continue;
						}
						case 5:
							(obj2 as ႨႭ).Ⴀ.Tx.Msg.Add(this.m_Ⴍ);
							num5 = 1;
							continue;
						case 3:
						case 7:
							break;
						case 13:
							num5 = (ByeHelp.Ⴍ((obj2 as ႨႭ).Ⴀ.Rx.Split[2], SetStationQth.Ⴍ(null, 1687354650, 8, 1), 89, 62) ? 12 : 0);
							continue;
						case 12:
							(obj2 as ႨႭ).Ⴀ.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetStationClubHelp.Ⴍ(2, 5, 1747263470, null), (obj2 as ႨႭ).Ⴀ.Ⴍ().Ⴅ().Ⴓ()
								.Call, 775, 841));
								num5 = 10;
								continue;
							case 10:
								Ⴍ(((ႨႭ)obj2).Ⴀ);
								num5 = ⴀႣ[85] - 26277;
								continue;
							case 0:
							case 9:
								num5 = ((((ႨႭ)obj2).Ⴀ.Rx.Split.Length != 4) ? 1 : (ⴄႤ[91] - 74));
								continue;
							case 8:
								num5 = ((!ByeHelp.Ⴍ((obj2 as ႨႭ).Ⴀ.Rx.Split[2], CallBlockCacheCfg.Ⴅ(null, 0, 62055287, null), 1016, 927)) ? (ⴅ[80] - 56) : 11);
								continue;
							case 11:
								Ⴗ(((ႨႭ)obj2).Ⴀ);
								goto case 1;
							case 1:
							case 2:
							{
								(obj2 as ႨႭ).Ⴀ.Ⴀ();
								object obj3 = new Publisher();
								((Publisher)obj3).Process((obj2 as ႨႭ).Ⴀ);
								return;
							}
							}
							break;
						}
						goto IL_03eb;
						IL_03eb:
						num5 = ((((ႨႭ)obj2).Ⴀ.Rx.Split.Length != 3) ? (ⴃႥ[224] - 19717) : 13);
						goto IL_02ff;
					}
				}
			}

			private void Ⴗ(NodeUserCmd P_0)
			{
				byte[] ⴅ = SetTalkCountHelp.Ⴅ;
				char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
				byte[] ⴄႭ = SetAnnMode.ႤႭ;
				int[] ⴀႨ = DirectoryBulletin.ႠႨ;
				char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
				int num = 1;
				IEnumerable enumerable = default(IEnumerable);
				KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
				while (true)
				{
					switch (num)
					{
					default:
						enumerable = SetDxFilter.Ⴀ(P_0.Rx.Split[3], 350, 'ğ');
						break;
					case 0:
					case 3:
						break;
					case 2:
					{
						object enumerator = P_0.Ⴍ().Ⴅ().Ⴓ()
							.ArcConnects.GetEnumerator();
						try
						{
							int num2 = 1;
							while (true)
							{
								switch (num2)
								{
								default:
									num2 = ⴅ[145];
									continue;
								case 4:
								{
									current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
									bool num3 = ByeHelp.Ⴍ(current.Value.Call, enumerable as string, 230, 129);
									BandModeCacheCfg.ႠႳ[245] = (char)((BandModeCacheCfg.ႠႳ[245] + BandModeCacheCfg.ႠႳ[46]) & 0x1B);
									num2 = ((!num3) ? 7 : (ⴄႷ[47] - 19218));
									continue;
								}
								case 8:
									num2 = ((!current.Value.Ⴄ()) ? 7 : 6);
									continue;
								case 6:
									num2 = ((current.Value.ConnectState != ConnectStateType.TelnetUser) ? (ⴀႨ[83] - 31168) : ⴄႭ[31]);
									continue;
								case 10:
									SetStationBeepHelp.Ⴅ(ShowAnnOptionsHelp.Ⴃ(current.Value.Cfg, 562, 584), string.Empty, 415, 470);
									break;
								case 7:
								case 9:
									break;
								case 0:
								case 5:
									goto end_IL_008b;
								}
								num2 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).MoveNext() ? 4 : 0);
								continue;
								end_IL_008b:
								break;
							}
						}
						finally
						{
							int num4 = 2;
							while (true)
							{
								int num5;
								switch (num4)
								{
								default:
									num5 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 5 : 0);
									goto IL_01e9;
								case 0:
									((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
									break;
								case 5:
									break;
								}
								break;
								IL_01e9:
								num4 = num5;
							}
						}
						switch (3)
						{
						}
						return;
					}
					}
					num = ⴍႭ[34] - 15436;
				}
			}

			private void Ⴍ(NodeUserCmd P_0)
			{
				char[] ⴀႣ = Arc4ServerClient.ႠႣ;
				int[] ⴀႨ = DirectoryBulletin.ႠႨ;
				char[] ⴀ = SetAnnChatRooms.Ⴀ;
				char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
				object enumerator = P_0.Ⴍ().Ⴅ().Ⴓ()
					.ArcConnects.GetEnumerator();
				try
				{
					int num = 5;
					KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
					while (true)
					{
						switch (num)
						{
						case 3:
							current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
							num = ((!current.Value.Ⴄ()) ? 4 : 2);
							continue;
						case 2:
						case 7:
							num = ((current.Value.ConnectState == ConnectStateType.TelnetUser) ? 9 : (ⴀႣ[264] - 37760));
							continue;
						case 4:
							num = ((current.Value.ConnectState == ConnectStateType.AgwBpqUser) ? 9 : (ⴀႨ[63] - 37859));
							continue;
						case 8:
							num = ((current.Value.ConnectState != ConnectStateType.ArxClient) ? 1 : (ⴀ[14] - 32162));
							continue;
						case 6:
						case 9:
						{
							List<string> msg = P_0.Tx.Msg;
							Array array = new string[6];
							(array as string[])[0] = CallBlockCacheCfg.Ⴅ(null, 8, 62058427, null);
							((string[])array)[1] = current.Value.Ⴓ();
							(array as string[])[2] = SetTalkCount.Ⴗ(5, null, 1267022534, typeof(AnnLocalUser));
							((string[])array)[3] = current.Value.Io.EndPoint;
							(array as string[])[4] = SetTalkCount.Ⴗ(3, null, 1267022528, typeof(DxSpotArx));
							((string[])array)[5] = ShowSkimmerHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ(current.Value.Cfg, 923, 993), 990, 972);
							msg.Add(ShowWwv.Ⴈ((string[])array, 'α', 985));
							break;
						}
						case 0:
						case 10:
							return;
						}
						num = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).MoveNext() ? (ⴍႭ[287] - 56435) : 0);
					}
				}
				finally
				{
					int num2 = 0;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator == null) ? 3 : 4);
							goto IL_0230;
						case 2:
						case 4:
							((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
							break;
						case 1:
						case 3:
							break;
						}
						break;
						IL_0230:
						num2 = num3;
					}
				}
			}

			private void Ⴀ(NodeUserCmd P_0, string P_1)
			{
				byte[] ⴄႭ = SetAnnMode.ႤႭ;
				int[] ⴀႨ = DirectoryBulletin.ႠႨ;
				char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
				char[] ⴃႰ = SetWxOutput.ႣႰ;
				int num = 6;
				while (true)
				{
					switch (num)
					{
					default:
						this.m_Ⴍ = ShowUsersHelp.Ⴅ(this.m_Ⴍ, ႰႥ.Ⴜ(P_1, 12, '\u0013', 39), 803, 877);
						num = ⴄႭ[323] - 191;
						continue;
					case 0:
						Ⴅ++;
						goto case 1;
					case 1:
					case 5:
						num = ((Ⴅ < 5) ? (ⴀႳ[287] - 59544) : (ⴀႨ[205] - 1020));
						continue;
					case 2:
						P_0.Tx.Msg.Add(this.m_Ⴍ);
						break;
					case 3:
						break;
					case 4:
						return;
					}
					this.m_Ⴍ = string.Empty;
					Ⴅ = 0;
					num = ⴃႰ[74] - 47653;
				}
			}

			private static int Ⴓ(string P_0, string P_1)
			{
				return SetStationLoginCmds.Ⴀ(P_0, P_1, 245, 213);
			}
		}
