using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
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
using ArcInterfaces.Io;
using ArcInterfaces.Spots;
using ArcShared;
using ArcShared.ArcIo.Arx;
using ArcShared.ArcIo.Pcxx;
using ArcShared.ArcIo.Telnet;
using ArcShared.DxAtlas;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class ConnectsCache
{
	private static readonly ILog m_Ⴈ = SkimmerValidSpot.Ⴐ(SetStationClubHelp.Ⴍ(2, 5, 1747257437, null), 845, 848);

	internal ConnectsCache()
	{
	}

	internal BindingList<IIoClient> Ⴄ(ArcConnect P_0, string P_1)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		object obj = new BindingList<IIoClient>();
		object enumerator = P_0.ArcConnects.GetEnumerator();
		try
		{
			int num = 21;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			IEnumerable enumerable = default(IEnumerable);
			object obj3 = default(object);
			IEquatable<string> equatable = default(IEquatable<string>);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = 2;
					continue;
				case 18:
					current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
					num = ((current.Value.Io.IoCfg.Category != IoCategoryType.Server) ? 5 : 17);
					continue;
				case 17:
					num = (SetAnnDefault.Ⴍ(current.Value.Call, SetTalkCount.Ⴗ(4, null, 1267023135, typeof(BadWordCache)), 458, 408) ? 5 : 13);
					continue;
				case 13:
					enumerable = Ⴃ(UserCacheCfg.Ⴃ((object)SetAnnModeHelp.Ⴓ((object)current.Value.Io, 154, 'Ð'), 'Ð', 187));
					goto case 12;
				case 12:
					num = 15;
					continue;
				case 15:
					obj3 = Ⴀ(enumerable as string, P_1);
					num = ((!(obj3 is IIoClient)) ? 2 : 22);
					continue;
				case 22:
					((IIoClient)obj3).IoCfg = new ServerIoCfg();
					((IIoClient)obj3).IoCfg.ConnectTo = current.Value.Call;
					num = 10;
					continue;
				case 10:
					(obj3 as IIoClient).IoCfg.IpAddress = current.Value.Io.EndPoint;
					((IIoClient)obj3).IoCfg.Description = current.Value.Io.IoCfg.Description;
					num = 7;
					continue;
				case 7:
					(obj3 as IIoClient).ConnectDts = current.Value.Io.ConnectDts;
					goto case 20;
				case 20:
					((IIoClient)obj3).DxSpotRate = current.Value.Io.DxSpotRate;
					num = 9;
					continue;
				case 9:
					(obj3 as IIoClient).LastTenMinuteDxDupeCnt = current.Value.Io.LastTenMinuteDxDupeCnt;
					(obj as BindingList<IIoClient>).Add((IIoClient)obj3);
					num = 2;
					continue;
				case 5:
					num = ((current.Value.Io.IoCfg.Category != IoCategoryType.Client) ? 2 : (ⴃႥ[292] - 42982));
					continue;
				case 14:
					num = (SetAnnDefault.Ⴍ(current.Value.Call, SetTalkCount.Ⴗ(4, null, 1267023135, typeof(AnnCache)), 881, 803) ? 2 : 6);
					continue;
				case 6:
					equatable = Ⴃ(UserCacheCfg.Ⴃ((object)SetAnnModeHelp.Ⴓ((object)current.Value.Io, 662, '\u02dc'), 'ö', 157));
					num = ⴍႤ[252] - 52532;
					continue;
				case 1:
					obj2 = Ⴀ(equatable as string, P_1);
					num = (((IIoClient)obj2 == null) ? (ⴃႰ[195] - 17183) : 8);
					continue;
				case 8:
					(obj2 as IIoClient).IoCfg = new ServerIoCfg();
					((IIoClient)obj2).IoCfg.ConnectTo = current.Value.Call;
					num = 3;
					continue;
				case 3:
					((IIoClient)obj2).IoCfg.IpAddress = current.Value.Io.EndPoint;
					((IIoClient)obj2).IoCfg.Description = current.Value.Io.IoCfg.Description;
					num = ⴃႥ[278] - ⴃႥ[278];
					continue;
				case 0:
					(obj2 as IIoClient).ConnectDts = current.Value.Io.ConnectDts;
					goto case 19;
				case 19:
					(obj2 as IIoClient).DxSpotRate = current.Value.Io.DxSpotRate;
					num = ⴄႷ[38] - 46333;
					continue;
				case 16:
					((IIoClient)obj2).LastTenMinuteDxDupeCnt = current.Value.Io.LastTenMinuteDxDupeCnt;
					((BindingList<IIoClient>)obj).Add((IIoClient)obj2);
					break;
				case 2:
					break;
				case 4:
					goto end_IL_0069;
				}
				num = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).MoveNext() ? 18 : (ⴄႭ[492] / 9));
				continue;
				end_IL_0069:
				break;
			}
		}
		finally
		{
			int num2 = 6;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator == null) ? (ⴀႳ[89] - 7669) : (ⴄႷ[110] - 20071));
					goto IL_04f0;
				case 2:
				case 4:
					(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
					break;
				case 1:
					break;
				}
				break;
				IL_04f0:
				num2 = num3;
			}
		}
		return 3 switch
		{
			_ => obj as BindingList<IIoClient>, 
		};
	}

	private IIoClient Ⴀ(string P_0, string P_1)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		while (true)
		{
			object obj = null;
			int num = ((!ByeHelp.Ⴍ(P_0, ReplyMailHelp.Ⴄ(4, null, 1057163068, 5), 355, 260)) ? (ⴅ[52] / 7) : 22);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 11;
					continue;
				case 11:
					break;
				case 16:
				case 22:
					num = (ByeHelp.Ⴍ(P_1, string.Empty, 96, 7) ? 21 : (ⴃႰ[207] - 39470));
					continue;
				case 24:
					num = ((!ByeHelp.Ⴍ(P_1, ReplyMailHelp.Ⴄ(17, null, 1057163070, 7), 246, 145)) ? 6 : (ⴀႣ[271] - 32443));
					continue;
				case 21:
					obj = new ArxServerClient();
					num = 23;
					continue;
				case 6:
				case 10:
					num = ((!ByeHelp.Ⴍ(P_0, ReplyMailHelp.Ⴄ(15, null, 1057162958, 5), 241, 150)) ? (ⴄႤ[114] - ⴄႤ[74]) : 28);
					continue;
				case 28:
					num = ((!ByeHelp.Ⴍ(P_1, string.Empty, 311, 336)) ? 1 : 3);
					continue;
				case 1:
					num = (ByeHelp.Ⴍ(P_1, ReplyMailHelp.Ⴄ(7, null, 1057162953, 2), 557, 586) ? (ⴃႠ[84] - 58610) : 0);
					continue;
				case 3:
					obj = new TelnetServerClient();
					num = 23;
					continue;
				case 0:
					num = ((!ByeHelp.Ⴍ(P_0, ReplyMailHelp.Ⴄ(24, null, 1057162962, 2), 866, 773)) ? 18 : (ⴃႥ[110] - 54571));
					continue;
				case 25:
					num = (ByeHelp.Ⴍ(P_1, string.Empty, 792, 895) ? 5 : 19);
					continue;
				case 19:
					num = ((!ByeHelp.Ⴍ(P_1, ReplyMailHelp.Ⴄ(14, null, 1057162967, 7), 76, 43)) ? (ⴄႷ[116] - 52914) : (ⴐ[354] - ⴐ[50]));
					continue;
				case 5:
					obj = new Arc4ServerClient();
					num = ⴃႥ[321] - 16230;
					continue;
				case 18:
					num = ((!ByeHelp.Ⴍ(P_0, ReplyMailHelp.Ⴄ(12, null, 1057162979, 0), 679, 704)) ? (ⴍႭ[327] - 18860) : (ⴍႤ[124] - 46670));
					continue;
				case 15:
					num = (ByeHelp.Ⴍ(P_1, string.Empty, 902, 993) ? 14 : 7);
					continue;
				case 7:
					num = ((!ByeHelp.Ⴍ(P_1, ReplyMailHelp.Ⴄ(24, null, 1057162980, 7), 276, 371)) ? (ⴀႨ[203] - 48758) : 14);
					continue;
				case 14:
					obj = new ႷႥ();
					num = 23;
					continue;
				case 26:
					num = ((!ByeHelp.Ⴍ(P_0, ShowWxHelp.Ⴍ('6', 985807917, 1), 991, 952)) ? ⴄႭ[246] : (ⴃႰ[46] - 49472));
					continue;
				case 17:
					num = ((P_1 == string.Empty) ? 20 : 9);
					continue;
				case 9:
					num = ((!(P_1 == ShowWxHelp.Ⴍ('d', 985807913, 5))) ? (ⴀႨ[116] - 13791) : 20);
					continue;
				case 20:
				case 27:
					obj = new PcxxServerClient();
					num = ⴀႣ[357] - 31372;
					continue;
				case 2:
					num = ((!(P_0 == SetStationClubHelp.Ⴍ(3, 5, 1747257385, null))) ? 23 : 4);
					continue;
				case 4:
					num = ((P_1 == string.Empty) ? ⴅ[210] : 12);
					continue;
				case 12:
					num = ((!(P_1 == SetStationClubHelp.Ⴍ(1, 5, 1747257385, null))) ? (ⴀႣ[128] - 26864) : (ⴄႤ[104] - 166));
					continue;
				case 8:
					obj = new ArxClient();
					num = ⴃႥ[370] - 48606;
					continue;
				case 23:
					return obj as IIoClient;
				}
				break;
			}
		}
	}

	internal BindingList<IIoClient> Ⴍ(ArcConnect P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		object obj = new BindingList<IIoClient>();
		object enumerator = P_0.ArcConnects.GetEnumerator();
		try
		{
			int num = 5;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
					goto case 3;
				case 3:
					num = ((current.Value.Io.IoCfg.Category == IoCategoryType.Client) ? 2 : 0);
					continue;
				case 2:
					(obj as BindingList<IIoClient>).Add(current.Value.Io);
					break;
				case 6:
					goto end_IL_0058;
				}
				bool num2 = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext();
				SetWxOutput.ႣႰ[142] = (char)((SetWxOutput.ႣႰ[142] * Arc4ServerClient.ႠႣ[256]) & 0x6F);
				num = (num2 ? 1 : 6);
				continue;
				end_IL_0058:
				break;
			}
		}
		finally
		{
			int num3 = 4;
			while (true)
			{
				int num4;
				switch (num3)
				{
				default:
					num4 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator == null) ? 3 : (ⴃႥ[110] - 54596));
					goto IL_0138;
				case 0:
				case 5:
					((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
					break;
				case 3:
					break;
				}
				break;
				IL_0138:
				num3 = num4;
			}
		}
		return (BindingList<IIoClient>)obj;
	}

	private string Ⴃ(string P_0)
	{
		while (true)
		{
			Array array = new char[1];
			(array as char[])[0] = '.';
			object obj = Directory.Ⴓ(P_0, (char[])array, 887, 801);
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
				case 1:
				case 4:
				case 5:
					break;
				case 3:
				{
					string[] obj2 = obj as string[];
					int num2 = (obj as string[]).Length;
					ShowWwvOptionsHelp.ႣႥ[325] = (char)(ShowWwvOptionsHelp.ႣႥ[325] & SetWxOutput.ႣႰ[159] & 0x92);
					return obj2[num2 - 1];
				}
				}
				break;
			}
		}
	}

	internal BindingList<ClientIoCfg> Ⴀ(ObjectManager P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		object obj = new BindingList<ClientIoCfg>();
		using (List<ClientIoCfg>.Enumerator enumerator = P_0.Ⴍ().IoDevices.Client.List.GetEnumerator())
		{
			int num = 6;
			object current = default(object);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 7:
					current = enumerator.Current;
					num = ((P_0.Ⴓ().ႣႣ(SetDxOutput.Ⴍ((ClientIoCfg)current, 218, 155)) != null) ? 2 : 4);
					continue;
				case 1:
				case 4:
					(obj as BindingList<ClientIoCfg>).Add(current as ClientIoCfg);
					break;
				case 3:
				case 5:
					goto end_IL_0053;
				}
				num = ((!enumerator.MoveNext()) ? (ⴃႥ[107] - 34868) : 0);
				continue;
				end_IL_0053:
				break;
			}
		}
		return (BindingList<ClientIoCfg>)obj;
	}

	internal List<DxSpotRate> Ⴈ(ArcConnect P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		object obj = new List<DxSpotRate>();
		object enumerator = P_0.ArcConnects.GetEnumerator();
		try
		{
			int num = 5;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num)
				{
				case 3:
					current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
					goto case 4;
				case 4:
					num = ((current.Value.Io.IoCfg.Category == IoCategoryType.Client) ? 1 : 0);
					continue;
				case 1:
				case 7:
				{
					object obj2 = new DxSpotRate(current.Value.Call, current.Value.Io.DxSpotRate);
					((List<DxSpotRate>)obj).Add((DxSpotRate)obj2);
					break;
				}
				case 6:
					goto end_IL_004a;
				}
				num = ((enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? 3 : (ⴅ[206] - 13));
				continue;
				end_IL_004a:
				break;
			}
		}
		finally
		{
			int num2 = 5;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator != null) ? 1 : 4);
					goto IL_0122;
				case 1:
				case 2:
					((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
					break;
				case 0:
				case 3:
				case 4:
					break;
				}
				break;
				IL_0122:
				num2 = num3;
			}
		}
		List<DxSpotRate> result = (List<DxSpotRate>)obj;
		ႨႣ.Ⴐ[145] = (byte)((ႨႣ.Ⴐ[145] + ႨႣ.Ⴐ[167]) & 0xCE);
		return result;
	}

	internal List<DxAtlasData> Ⴓ(ArcConnect P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
		while (true)
		{
			float lat = 0f;
			float lon = 0f;
			while (true)
			{
				IL_005b:
				object obj = new List<DxAtlasData>();
				Ⴅ(P_0.Ⴅ(), P_0.Call, out lat, out lon);
				int num = 1;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 3;
						continue;
					case 3:
						break;
					case 0:
					case 5:
						goto IL_005b;
					case 1:
					{
						((List<DxAtlasData>)obj).Add(new DxAtlasData(P_0.Call, lat, lon));
						object enumerator = P_0.ArcConnects.GetEnumerator();
						try
						{
							int num2 = 0;
							while (true)
							{
								switch (num2)
								{
								default:
									num2 = ⴅ[145];
									continue;
								case 4:
									current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
									num2 = (SetAnnDefault.Ⴍ(current.Value.Call, SetTalkCount.Ⴗ(6, null, 1267023133, typeof(DirectoryBulletin)), 986, 904) ? 7 : (ⴃႠ[242] - 57252));
									continue;
								case 1:
									Ⴅ(P_0.Ⴅ(), current.Value.Call, out lat, out lon);
									(obj as List<DxAtlasData>).Add(new DxAtlasData(current.Value.Call, lat, lon));
									break;
								case 7:
									break;
								case 6:
									goto end_IL_00a4;
								}
								num2 = ((enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? ⴐ[367] : (ⴀႣ[157] - 1476));
								continue;
								end_IL_00a4:
								break;
							}
						}
						finally
						{
							int num3 = 3;
							while (true)
							{
								int num4;
								switch (num3)
								{
								default:
									num4 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator == null) ? (ⴍႭ[118] - 16217) : 5);
									goto IL_01cc;
								case 1:
								case 2:
								case 5:
									(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
									break;
								case 6:
									break;
								}
								break;
								IL_01cc:
								num3 = num4;
							}
						}
						return 0 switch
						{
							_ => obj as List<DxAtlasData>, 
						};
					}
					}
					break;
				}
				break;
			}
		}
	}

	private void Ⴅ(ObjectManager P_0, string P_1, out float P_2, out float P_3)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 7;
		IEnumerable enumerable = default(IEnumerable);
		object obj2 = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_2 = 0f;
				P_3 = 0f;
				enumerable = SetDxFilter.Ⴀ(P_1, 824, 'ͺ');
				num = 6;
				break;
			case 6:
				enumerable = ShowQslInfoHelp.Ⴓ(P_1, 651, '\u02f8');
				num = (ByeHelp.Ⴍ(enumerable as string, ReplyMail.Ⴅ(7, 5, 1217944019), 274, 373) ? (ⴀႼ[102] - 31) : 8);
				break;
			case 8:
				num = ((!ByeHelp.Ⴍ(enumerable as string, ReplyMail.Ⴅ(7, 4, 1217944019), 474, 445)) ? 11 : ⴄႤ[47]);
				break;
			case 3:
			case 12:
				enumerable = SetTalkCount.Ⴗ(7, null, 1267023122, typeof(ShowVersion));
				num = 11;
				break;
			case 11:
				obj2 = P_0.Ⴀ().ႤႷ().CtyInfoFromCall(enumerable as string);
				num = (((CtyInfo)obj2 != null) ? 1 : (ⴀႣ[331] - 13722));
				break;
			case 1:
			{
				P_2 = ShowAnn.Ⴀ(obj2 as CtyInfo, 79, 59);
				P_3 = SetWwvCount.Ⴓ(obj2 as CtyInfo, 'ɛ', 'ɭ');
				char num2 = ⴍႭ[189];
				ShowQrzHelp.ႤႤ[536] = (byte)((ShowQrzHelp.ႤႤ[536] + BandModeCacheCfg.ႠႳ[101]) & 0x56);
				num = num2 - 59323;
				break;
			}
			case 5:
			case 10:
				num = ((!(qslinfoSoapClient.Ⴈ((CtyInfo)obj2, 'Ǧ', 511) == ReplyMailHelp.Ⴄ(6, null, 1057162206, 5))) ? ⴐ[367] : 9);
				break;
			case 9:
				obj = P_0.Ⴀ().UsVeCallbook.Search(enumerable as string);
				num = ((!(obj is CallbookData)) ? 4 : 0);
				break;
			case 0:
				P_2 = ((CallbookData)obj).Lat;
				P_3 = (obj as CallbookData).Lon;
				num = 4;
				break;
			case 2:
			case 4:
				return;
			}
		}
	}
}
