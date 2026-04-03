using System;
using System.Collections.Generic;
using System.Security;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces;
using Ⴈ;

namespace ArcEngine.ArcCmds.Publish;

public sealed class Publisher
{
	internal sealed class ႣႣ
	{
		internal ArcServerCfg Ⴈ;

		internal ႣႣ()
		{
		}
	}

	public NodeUserCmd Process(NodeUserCmd cmd)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		while (true)
		{
			int num = cmd.Tx.DistroType switch
			{
				DistroType.ToRequester => 0, 
				DistroType.ToAll => ⴀႼ[121] - 81, 
				DistroType.ToCall => 15, 
				DistroType.ToCallPlusSsids => 4, 
				DistroType.ToPubChatRoom => ⴀႨ[196] - 23272, 
				DistroType.ToPvtChatRoom => 16, 
				DistroType.ToNil => 3, 
				DistroType.ToNode => 12, 
				DistroType.ToNodes => 10, 
				DistroType.ToPcxxNodes => ⴐ[243], 
				DistroType.ToUsers => ⴀ[487] - 53502, 
				_ => 7, 
			};
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
				case 5:
				case 7:
					num = 3;
					continue;
				case 13:
					Ⴐ(cmd);
					Ⴈ(cmd);
					num = 3;
					continue;
				case 0:
					Ⴃ(cmd.Ⴍ(), cmd);
					num = ⴀႼ[87] - 222;
					continue;
				case 15:
					Ⴗ();
					num = 3;
					continue;
				case 4:
					Ⴍ();
					num = ⴀႳ[136] - 18898;
					continue;
				case 10:
					Ⴐ(cmd);
					num = 3;
					continue;
				case 8:
					Ⴀ(cmd);
					goto case 9;
				case 9:
					num = ⴀ[439] - 14888;
					continue;
				case 1:
				case 6:
					Ⴈ(cmd);
					num = ⴀႨ[156] - 50194;
					continue;
				case 14:
					Ⴄ(cmd);
					Ⴐ(cmd);
					num = 3;
					continue;
				case 16:
					Ⴄ(cmd);
					Ⴗ(cmd);
					num = 3;
					continue;
				case 12:
					Ⴓ(cmd);
					goto case 3;
				case 3:
					Ⴅ(cmd);
					return cmd;
				}
				break;
			}
		}
	}

	private static void Ⴅ(NodeUserCmd P_0)
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				return;
			}
			switch (P_0.Tx.MsgType)
			{
			case MsgType.Dx:
			case MsgType.DxLocal:
				P_0.Ⴍ().Ⴅ().Ⴀ()
					.Ⴃ()
					.CleanTempCache(P_0.Tx.Id);
				return;
			case MsgType.Ann:
				P_0.Ⴍ().Ⴅ().Ⴀ()
					.Ⴄ()
					.CleanTempCache(P_0.Tx.Id);
				return;
			case MsgType.Wx:
				P_0.Ⴍ().Ⴅ().Ⴀ()
					.Ⴈ()
					.Ⴈ(P_0.Tx.Id);
				return;
			case MsgType.General:
				return;
			}
			num = 2;
		}
	}

	private static void Ⴐ(NodeUserCmd P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		object enumerator = P_0.Ⴍ().Ⴅ().Ⴓ()
			.ArcConnects.GetEnumerator();
		try
		{
			int num = 14;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			ConnectStateType connectState = default(ConnectStateType);
			while (true)
			{
				switch (num)
				{
				case 12:
					current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
					num = ((P_0.Tx.MsgType == MsgType.DxLocal) ? 5 : 3);
					continue;
				case 3:
					num = ((!current.Value.Ⴃ()) ? 5 : 2);
					continue;
				case 2:
					num = ((!current.Value.Ⴄ()) ? (ⴃႥ[17] - 43336) : (ⴀႣ[77] - 10997));
					continue;
				case 7:
					num = ((!current.Value.Io.IsConnected) ? 5 : ⴅ[20]);
					continue;
				case 9:
				case 10:
					num = ((!SetAnnFilter.Ⴐ(current.Value.Id, P_0.Ⴍ().Id, '1', 32)) ? 5 : (ⴄႤ[386] - 123));
					continue;
				case 11:
					connectState = current.Value.ConnectState;
					num = ((connectState == ConnectStateType.ArxNode) ? (ⴍႤ[256] - 47979) : 13);
					continue;
				case 0:
				case 13:
				case 15:
					num = ((connectState != ConnectStateType.PcxxNode) ? 1 : 6);
					continue;
				case 1:
					num = ⴐ[149] - ⴐ[53];
					continue;
				case 4:
					current.Value.ႠႰ(P_0.Tx.NodeXml);
					num = 5;
					continue;
				case 6:
					current.Value.ႠႰ(P_0.Tx.Pcxx);
					break;
				case 8:
					return;
				}
				num = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).MoveNext() ? ⴄႤ[47] : (ⴀ[30] - 41679));
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
					num3 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator == null) ? (ⴃႠ[29] - 16840) : 2);
					goto IL_023b;
				case 2:
					((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
					break;
				case 3:
				case 5:
					break;
				}
				break;
				IL_023b:
				num2 = num3;
			}
		}
	}

	private static void Ⴀ(NodeUserCmd P_0)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		object enumerator = P_0.Ⴍ().Ⴅ().Ⴓ()
			.ArcConnects.GetEnumerator();
		try
		{
			int num = 7;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num)
				{
				case 4:
				case 11:
				case 12:
				{
					current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
					ConnectStateType connectState = current.Value.ConnectState;
					TxNodeUserCmd.ႤႷ[59] = (char)((TxNodeUserCmd.ႤႷ[59] - TxNodeUserCmd.ႤႷ[66]) & 0x2C);
					num = ((connectState != ConnectStateType.PcxxNode) ? (ⴄႷ[70] - 5433) : 5);
					continue;
				}
				case 5:
					num = ((P_0.Tx.MsgType == MsgType.DxLocal) ? 6 : (ⴅ[6] / 7));
					continue;
				case 0:
					num = ((!current.Value.Ⴃ()) ? (ⴃႥ[321] - 16247) : (ⴀႳ[84] - 27442));
					continue;
				case 2:
					num = ((!current.Value.Ⴄ()) ? (ⴃႰ[19] - 63917) : 3);
					continue;
				case 3:
					num = ((!current.Value.Io.IsConnected) ? 6 : 10);
					continue;
				case 10:
					num = ((!SetAnnFilter.Ⴐ(current.Value.Id, P_0.Ⴍ().Id, 'ƹ', 424)) ? 6 : (ⴀႼ[113] * 4));
					continue;
				case 1:
				case 8:
					current.Value.ႠႰ(P_0.Tx.Pcxx);
					break;
				case 9:
					return;
				}
				num = ((enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? 11 : 9);
			}
		}
		finally
		{
			int num2 = 1;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 4 : 2);
					goto IL_01ef;
				case 0:
				case 2:
				case 5:
					(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
					break;
				case 3:
				case 4:
					break;
				}
				break;
				IL_01ef:
				num2 = num3;
			}
		}
	}

	private static void Ⴈ(NodeUserCmd P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
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
				case 8:
					current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
					num = ((!current.Value.Ⴃ()) ? 3 : (ⴄႤ[151] - 195));
					continue;
				case 4:
					num = ((current.Value.ConnectState == ConnectStateType.RcvOnly) ? (ⴃႥ[203] - 52433) : (ⴍႭ[111] - 31268));
					continue;
				case 10:
				case 11:
				{
					int num2;
					switch (current.Value.ConnectState)
					{
					default:
						num2 = ⴄႭ[246];
						break;
					case ConnectStateType.ArxClient:
					{
						int num3 = ⴀႨ[175];
						AnnCacheCfg.ႠႼ[80] = SetAnnMode.ႤႭ[66];
						num2 = num3 - 60070;
						break;
					}
					case ConnectStateType.TelnetUser:
						num2 = 7;
						break;
					case ConnectStateType.AgwBpqUser:
						num2 = 7;
						break;
					}
					num = num2;
					continue;
				}
				case 0:
				case 2:
					num = 3;
					continue;
				case 9:
					current.Value.ႠႰ(P_0.Tx.ClientXml);
					num = 3;
					continue;
				case 7:
					Ⴃ(current.Value, P_0);
					break;
				case 6:
					return;
				}
				num = ((enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? 8 : (ⴄႷ[70] - 5433));
			}
		}
		finally
		{
			int num4 = 0;
			while (true)
			{
				int num5;
				switch (num4)
				{
				default:
					num5 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator == null) ? 2 : 5);
					goto IL_01bd;
				case 4:
				case 5:
					(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
					break;
				case 1:
				case 2:
					break;
				}
				break;
				IL_01bd:
				num4 = num5;
			}
		}
	}

	private static void Ⴃ(ArcConnect P_0, NodeUserCmd P_1)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!P_0.Ⴃ()) ? 5 : 0);
				break;
			case 0:
			case 2:
				if (P_0.ConnectState == ConnectStateType.RcvOnly)
				{
					num = 5;
					break;
				}
				while (true)
				{
					switch (P_1.Tx.MsgType switch
					{
						MsgType.General => ⴅ[99] / 4, 
						MsgType.Dx => 2, 
						MsgType.DxLocal => 2, 
						MsgType.Ann => 1, 
						MsgType.Wx => 7, 
						MsgType.Wwv => ⴍႤ[192] - 28405, 
						_ => 6, 
					})
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 9:
						break;
					case 6:
						return;
					case 2:
						ႨႼ.Ⴈ(P_0, P_1);
						return;
					case 8:
						return;
					case 1:
						ႨႨ.Ⴅ(P_0, P_1);
						return;
					case 7:
					case 10:
						ႰႠ.Ⴅ(P_0, P_1);
						return;
					case 5:
						ႷႳ.Ⴍ(P_0, P_1);
						return;
					case 4:
						P_0.ႠႣ(P_1.Tx.Msg);
						return;
					case 0:
						return;
					}
				}
			case 1:
			case 3:
			case 5:
				return;
			}
		}
	}

	private static void Ⴗ()
	{
	}

	private static void Ⴍ()
	{
	}

	private static void Ⴓ(NodeUserCmd P_0)
	{
		P_0.Ⴍ().ႠႣ(P_0.Tx.Msg);
	}

	private static void Ⴄ(NodeUserCmd P_0)
	{
	}

	private static void Ⴗ(NodeUserCmd P_0)
	{
	}

	[SecuritySafeCritical]
	internal static double Ⴜ(ref TimeSpan P_0, char P_1, short P_2)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		double result = default(double);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[184] - 96;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
					break;
				case 10:
					num2 = (((P_2 ^ P_1) - 96) ^ num) switch
					{
						0 => ⴀ[385] - 61651, 
						_ => ⴄႭ[94], 
					};
					continue;
				case 7:
					result = 4.098354888773927;
					goto case 9;
				case 9:
					num2 = ⴀႼ[47] - 155;
					continue;
				case 4:
				case 11:
					result = P_0.TotalSeconds;
					num2 = 1;
					continue;
				case 1:
				{
					num++;
					int num3 = 68;
					int num4 = 525;
					num2 = ((2625 > num4 - num3 * 5) ? 3 : 0);
					continue;
				}
				case 0:
					num2 = ⴄႷ[69] - 16537;
					continue;
				case 3:
					return result;
				case 2:
				case 8:
					num2 = ⴀႼ[44] - ⴀႼ[15];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႣႤ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : string
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 7;
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
				num = (((P_1 ^ P_2) - 126) ^ num2) switch
				{
					0 => 5, 
					_ => 4, 
				};
				break;
			case 4:
				num = 2;
				break;
			case 5:
				Console.WriteLine(P_0);
				goto case 2;
			case 2:
			case 3:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴀႼ[66] - 63) : 0);
				break;
			case 0:
				num = ⴃႠ[105] - 25043;
				break;
			case 1:
			case 6:
			case 8:
				return;
			}
		}
	}
}
