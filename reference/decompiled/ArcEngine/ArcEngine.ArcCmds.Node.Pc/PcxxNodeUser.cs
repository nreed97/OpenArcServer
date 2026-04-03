using System;
using System.Collections;
using System.Collections.Generic;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
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
using ArcShared;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Node.Pc;

public sealed class PcxxNodeUser
{
	private static readonly ILog m_Ⴗ = SkimmerValidSpot.Ⴐ(SetStationQth.Ⴍ(null, 1687353144, 6, 13), 812, 817);

	private List<string> m_Ⴀ;

	private SetStationMacros.Ⴓ Ⴃ = new SetStationMacros.Ⴓ();

	public PcxxNodeUser()
	{
		IEnumerable enumerable = ShowSkimCtyHelp.Ⴍ(1216131359, 6, 'r');
		Ⴃ.Ⴄ = (string)enumerable;
		base._002Ector();
		object obj = new List<string>();
		Ⴃ.Ⴃ = (List<string>)obj;
		this.m_Ⴀ = new List<string>();
	}

	public void BuildAndSend(NodeUserCmd cmd)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		try
		{
			int num = 6;
			object obj = default(object);
			int num3 = default(int);
			double num2 = default(double);
			IEquatable<string> equatable = default(IEquatable<string>);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 273, 336);
					goto case 9;
				case 9:
					num = (Ⴍ(cmd) ? 3 : (ⴍႤ[307] - ⴍႤ[307]));
					continue;
				case 0:
					Ⴗ(cmd.Ⴍ().Ⴅ().Ⴓ(), cmd);
					num3 = Ⴃ.Ⴃ.Count + this.m_Ⴀ.Count;
					goto case 1;
				case 1:
					num = 8;
					continue;
				case 8:
					ByeHelp.Ⴄ((PrecisionTimer)obj, 'Æ', 149);
					num = ((num3 <= 0) ? 3 : ⴀႼ[96]);
					continue;
				case 4:
					num2 = ReadMailHelp.Ⴗ(obj as PrecisionTimer, 650, 712) / (double)num3;
					num = ⴍႭ[284] - 13678;
					continue;
				case 2:
					equatable = ႷႳ.Ⴗ(ref num2, SetStationQth.Ⴍ(null, 1687353099, 0, 12), 548, 'ȱ');
					num = 5;
					continue;
				case 5:
				case 7:
					Ⴍ(cmd, equatable as string);
					Ⴓ(cmd, (string)equatable);
					break;
				case 3:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			PcxxNodeUser.m_Ⴗ.Error(ex.Message);
		}
		switch (1)
		{
		}
	}

	private static bool Ⴍ(NodeUserCmd P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		while (true)
		{
			IoCategoryType category = P_0.Ⴍ().Io.IoCfg.Category;
			while (true)
			{
				IL_0052:
				int num = category switch
				{
					IoCategoryType.Client => ⴍႭ[200] - 53511, 
					IoCategoryType.Server => 2, 
					_ => 1, 
				};
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 0;
						continue;
					case 0:
						break;
					case 3:
						goto IL_0052;
					case 1:
						num = 6;
						continue;
					case 2:
						return ReadMail.Ⴃ((ServerIoCfg)P_0.Ⴍ().Io.IoCfg, 68, 11) == ServerIoType.Arc4Passive;
					case 4:
					case 8:
						return BaseCmd.Ⴓ((ClientIoCfg)P_0.Ⴍ().Io.IoCfg, 'Ȓ', 547) == ClientIoType.Arc4Passive;
					case 6:
						PcxxNodeUser.m_Ⴗ.Error(ႨႨ.Ⴀ(2, 4, 1157905584));
						goto case 7;
					case 7:
						ShowWwvOptionsHelp.ႣႥ[10] = (char)(ShowWwvOptionsHelp.ႣႥ[10] & ShowWwvOptionsHelp.ႣႥ[286] & 0x74);
						return true;
					}
					break;
				}
				break;
			}
		}
	}

	private void Ⴗ(ArcConnect P_0, NodeUserCmd P_1)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((P_0.ConnectState != ConnectStateType.PcxxNode) ? 8 : 3);
				continue;
			case 3:
				num = (ByeHelp.Ⴍ(P_0.Call, P_1.Ⴍ().Call, 414, 502) ? (ⴍႭ[331] - 20126) : 8);
				continue;
			case 8:
				if (SetStationGrid.Ⴄ(P_0.Id, P_1.Ⴍ().Ⴅ().Ⴓ()
					.Id, 993, 998))
					{
						num = 7;
						continue;
					}
					return;
				case 7:
				{
					object ⴄ = Ⴃ.Ⴄ;
					Array array = new object[9];
					(array as object[])[0] = ⴄ;
					(array as object[])[1] = P_0.Here;
					(array as object[])[2] = '^';
					(array as object[])[3] = P_0.Call;
					((object[])array)[4] = '^';
					((object[])array)[5] = P_0.Ⴜ();
					((object[])array)[6] = '^';
					(array as object[])[7] = P_0.SwVersion;
					((object[])array)[8] = '^';
					object obj = SetDxDefaultHelp.Ⴍ(array as object[], 'Ȇ', 623);
					Ⴃ.Ⴄ = (string)obj;
					goto case 5;
				}
				case 5:
					num = 4;
					continue;
				case 4:
				case 9:
					num = ((CallBlockCacheCfg.Ⴜ(Ⴃ.Ⴄ, 807, 838) <= 70) ? 6 : ⴄႤ[148]);
					continue;
				case 1:
					Ⴍ();
					goto case 6;
				case 6:
					Ⴀ(P_0);
					break;
				case 0:
					break;
				}
				object enumerator = P_0.ArcConnects.GetEnumerator();
				try
				{
					int num2 = 3;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = 1;
							continue;
						case 5:
							Ⴗ(((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current.Value, P_1);
							break;
						case 1:
						case 4:
							break;
						case 0:
						case 2:
							goto end_IL_01db;
						}
						num2 = ((enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? 5 : 2);
						continue;
						end_IL_01db:
						break;
					}
				}
				finally
				{
					int num3 = 6;
					while (true)
					{
						int num4;
						switch (num3)
						{
						default:
							num4 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator == null) ? (ⴅ[62] - 164) : 3);
							goto IL_0267;
						case 2:
						case 3:
							((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
							break;
						case 1:
							break;
						}
						break;
						IL_0267:
						num3 = num4;
					}
				}
				int num5 = 7;
				while (true)
				{
					switch (num5)
					{
					default:
						num5 = ((P_0.Id == P_1.Ⴍ().Ⴅ().Ⴓ()
							.Id) ? 1 : 0);
						break;
					case 1:
						num5 = ((Ⴃ.Ⴄ.Length > 5) ? (ⴀ[149] - 54916) : 0);
						break;
					case 6:
						Ⴍ();
						return;
					case 0:
					case 3:
						return;
					}
				}
			}
		}

		private void Ⴀ(ArcConnect P_0)
		{
			byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			char[] ⴀ = SetAnnChatRooms.Ⴀ;
			int num = 4;
			IEnumerable enumerable = default(IEnumerable);
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num)
				{
				default:
					enumerable = ShowPrefixCalls.Ⴃ((object)ShowSkimCtyHelp.Ⴍ(1216131365, 4, '\u0092'), (object)P_0.Call, (object)'^', '\u0368', 834);
					break;
				case 0:
					break;
				case 1:
				{
					object enumerator = P_0.ArcConnects.GetEnumerator();
					try
					{
						int num2 = 6;
						while (true)
						{
							switch (num2)
							{
							default:
								num2 = 12;
								continue;
							case 4:
								current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
								num2 = ((current.Value.ConnectState == ConnectStateType.TelnetUser) ? (ⴀ[452] - 4508) : 8);
								continue;
							case 8:
								num2 = ((current.Value.ConnectState == ConnectStateType.ArxClient) ? 10 : 3);
								continue;
							case 3:
							case 9:
								num2 = ((current.Value.ConnectState == ConnectStateType.PcxxUser) ? 10 : (ⴍႭ[95] - 30657));
								continue;
							case 7:
								num2 = ((current.Value.ConnectState != ConnectStateType.AgwBpqUser) ? 12 : 10);
								continue;
							case 10:
							case 11:
								enumerable = ShowPrefixCalls.Ⴃ((object)(string)enumerable, (object)current.Value.Ⴈ(), (object)'^', 'ȉ', 547);
								num2 = 5;
								continue;
							case 5:
								num2 = ((CallBlockCacheCfg.Ⴜ((string)enumerable, 691, 722) <= 70) ? 12 : 14);
								continue;
							case 14:
								enumerable = ShowUsersHelp.Ⴅ((string)enumerable, SetStationClubHelp.Ⴍ(2, 4, 1747258580, null), 589, 515);
								num2 = ⴃႥ[108] - ⴃႥ[108];
								continue;
							case 0:
							case 2:
								this.m_Ⴀ.Add(enumerable as string);
								enumerable = ShowPrefixCalls.Ⴃ((object)ShowSkimCtyHelp.Ⴍ(1216131361, 0, 'ç'), (object)P_0.Call, (object)'^', 'ξ', 916);
								num2 = 12;
								continue;
							case 12:
								num2 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).MoveNext() ? 4 : (ⴀႣ[32] - 59922));
								continue;
							case 13:
								break;
							}
							break;
						}
					}
					finally
					{
						int num3 = 2;
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								num4 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator == null) ? 5 : (ⴄႭ[307] - ⴄႭ[485]));
								goto IL_02a1;
							case 1:
								((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
								break;
							case 5:
								break;
							}
							break;
							IL_02a1:
							num3 = num4;
						}
					}
					int num5 = 6;
					while (true)
					{
						switch (num5)
						{
						default:
							num5 = ((CallBlockCacheCfg.Ⴜ((string)enumerable, 315, 346) > P_0.Call.Length + 8) ? 1 : (ⴀႼ[96] - 1));
							break;
						case 1:
							enumerable = (string)enumerable + SetStationClubHelp.Ⴍ(0, 0, 1747258576, null);
							goto case 4;
						case 4:
						case 5:
						case 7:
							num5 = 0;
							break;
						case 0:
							this.m_Ⴀ.Add(enumerable as string);
							return;
						case 3:
							return;
						}
					}
				}
				}
				num = ⴀ[393] - 25864;
			}
		}

		private void Ⴍ()
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
				{
					IEnumerable<char> enumerable = ShowUsersHelp.Ⴅ(Ⴃ.Ⴄ, SetStationClubHelp.Ⴍ(3, 5, 1747258581, null), 884, 826);
					Ⴃ.Ⴄ = enumerable as string;
					break;
				}
				case 3:
					break;
				case 0:
				case 4:
				{
					Ⴃ.Ⴃ.Add(Ⴃ.Ⴄ);
					ICloneable cloneable = ShowSkimCtyHelp.Ⴍ(1216131345, 8, 'ç');
					Ⴃ.Ⴄ = (string)cloneable;
					return;
				}
				case 1:
					return;
				}
				num = ⴃႥ[354] - 20227;
			}
		}

		private void Ⴍ(NodeUserCmd P_0, string P_1)
		{
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			using List<string>.Enumerator enumerator = Ⴃ.Ⴃ.GetEnumerator();
			int num = 1;
			IComparable current = default(IComparable);
			while (true)
			{
				switch (num)
				{
				case 2:
					current = enumerator.Current;
					P_0.Tx.Msg.Add(current as string);
					goto case 5;
				case 5:
					num = ((!P_0.Ⴍ().Ⴅ().Ⴍ()
						.PcxxCfg.LogOutboundNodeUser) ? (ⴍႤ[80] - 64085) : 4);
					continue;
				case 4:
					PcxxNodeUser.m_Ⴗ.Info(qslinfoResponse.Ⴗ(P_1, P_0.Ⴍ().Call, ReplyMail.Ⴅ(4, 4, 1217944104), (string)current, 721, 'ʲ'));
					break;
				case 0:
				case 6:
					return;
				}
				num = (enumerator.MoveNext() ? (ⴃႠ[70] - 48900) : 6);
			}
		}

		private void Ⴓ(NodeUserCmd P_0, string P_1)
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
			using List<string>.Enumerator enumerator = this.m_Ⴀ.GetEnumerator();
			int num = 4;
			IEnumerable current = default(IEnumerable);
			while (true)
			{
				switch (num)
				{
				case 2:
					current = enumerator.Current;
					goto case 6;
				case 6:
					P_0.Tx.Msg.Add((string)current);
					goto case 5;
				case 5:
					num = ((!P_0.Ⴍ().Ⴅ().Ⴍ()
						.PcxxCfg.LogOutboundNodeUser) ? (ⴄႷ[38] - ⴄႷ[38]) : 7);
					continue;
				case 1:
				case 7:
					PcxxNodeUser.m_Ⴗ.Info(qslinfoResponse.Ⴗ(P_1, P_0.Ⴍ().Call, ReplyMail.Ⴅ(3, 9, 1217944111), current as string, 212, '·'));
					break;
				case 3:
					return;
				}
				num = (enumerator.MoveNext() ? (ⴍႭ[347] - 58769) : (ⴀႣ[128] - 26884));
			}
		}

		internal static void Ⴓ(ArcConnect P_0)
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			char[] ⴃႰ = SetWxOutput.ႣႰ;
			int num = 2;
			Array array = default(Array);
			IComparable comparable = default(IComparable);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					array = new object[5];
					(array as object[])[0] = ShowSkimCtyHelp.Ⴍ(1216131362, 3, '8');
					num = 6;
					break;
				case 6:
					(array as object[])[1] = P_0.Ⴍ().Call;
					goto case 1;
				case 1:
					(array as object[])[2] = '^';
					num = ⴃႥ[224] - ⴃႥ[224];
					break;
				case 0:
					(array as object[])[3] = P_0.Ⴈ();
					goto case 3;
				case 3:
					((object[])array)[4] = SetStationClubHelp.Ⴍ(7, 4, 1747258575, null);
					num = 7;
					break;
				case 7:
					comparable = SetDxDefaultHelp.Ⴍ((object[])array, 'Ƨ', 462);
					obj2 = new NodeUserCmd(P_0.Ⴍ());
					num = 4;
					break;
				case 4:
				case 5:
					(obj2 as NodeUserCmd).Tx.Pcxx = comparable as string;
					(obj2 as NodeUserCmd).Tx.DistroType = DistroType.ToPcxxNodes;
					num = ⴃႰ[80] - 24195;
					break;
				case 8:
				{
					object obj = new Publisher();
					(obj as Publisher).Process(obj2 as NodeUserCmd);
					return;
				}
				}
			}
		}

		internal static void Ⴅ(ArcConnect P_0)
		{
			byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
			int[] ⴀႨ = DirectoryBulletin.ႠႨ;
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
			int num = 0;
			object obj3 = default(object);
			IConvertible convertible = default(IConvertible);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					return;
				}
				if (SetAnnFilter.Ⴐ(P_0.Ⴍ().Id, P_0.Ⴅ().Ⴓ().Id, '\u0019', 8))
				{
					num = ⴀႳ[4] - 24695;
					continue;
				}
				while (true)
				{
					int num2 = ((P_0.ConnectState == ConnectStateType.TelnetUser) ? 10 : (ⴀႼ[98] - 126));
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 11:
							break;
						case 1:
						case 6:
							num2 = ((P_0.ConnectState != ConnectStateType.AgwBpqUser) ? (ⴀႨ[14] - 1823) : 10);
							continue;
						case 10:
							obj3 = new object[5];
							((object[])obj3)[0] = ShowSkimCtyHelp.Ⴍ(1216131368, 1, 'Û');
							num2 = ⴄႷ[79] - 55493;
							continue;
						case 0:
							((object[])obj3)[1] = P_0.Call;
							(obj3 as object[])[2] = '^';
							num2 = 3;
							continue;
						case 2:
						case 3:
							(obj3 as object[])[3] = P_0.Ⴍ().Call;
							(obj3 as object[])[4] = SetStationClubHelp.Ⴍ(9, 7, 1747258572, null);
							num2 = 9;
							continue;
						case 7:
						case 9:
							convertible = SetDxDefaultHelp.Ⴍ((object[])obj3, 'ȓ', 634);
							obj2 = new NodeUserCmd(P_0.Ⴍ());
							num2 = ⴍႭ[278] - 27791;
							continue;
						case 8:
							((NodeUserCmd)obj2).Tx.Pcxx = convertible as string;
							(obj2 as NodeUserCmd).Tx.DistroType = DistroType.ToPcxxNodes;
							num2 = ⴀႣ[236] - 22287;
							continue;
						case 5:
						{
							object obj = new Publisher();
							(obj as Publisher).Process((NodeUserCmd)obj2);
							num2 = 12;
							continue;
						}
						case 12:
							return;
						}
						break;
					}
				}
			}
		}
	}
