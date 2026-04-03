using System;
using System.Collections.Generic;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ShowConnects : IArcCmd
{
	private sealed class ႥႥ
	{
		public NodeUserCmd Ⴄ;

		public void Ⴀ(ArcConnect P_0)
		{
			Ⴈ(Ⴄ, P_0);
		}
	}

	private static readonly ILog Ⴍ = SkimmerValidSpot.Ⴐ(ReplyMailHelp.Ⴄ(20, null, 1057161436, 8), 578, 607);

	private static Comparison<ArcConnect> Ⴍ;

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		object obj = null;
		object obj2 = new ႥႥ();
		((ႥႥ)obj2).Ⴄ = cmd;
		try
		{
			int num = 1;
			object obj3 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					((ႥႥ)obj2).Ⴄ.Tx.DistroType = DistroType.ToRequester;
					goto IL_0065;
				case 3:
					goto IL_0065;
				case 4:
					obj3 = new List<ArcConnect>();
					break;
				case 2:
				case 5:
					break;
				}
				break;
				IL_0065:
				(obj2 as ႥႥ).Ⴄ.Tx.Msg.Add(SetTalkCount.Ⴗ(0, null, 1267023641, typeof(SkimmerServerData)));
				byte num2 = ⴄႤ[119];
				byte num3 = ⴄႤ[52];
				ShowQrzHelp.ႤႤ[228] = (byte)((ShowQrzHelp.ႤႤ[228] * ShowQrzHelp.ႤႤ[494]) & 0x1C);
				num = num2 - num3;
			}
			object enumerator = ((ႥႥ)obj2).Ⴄ.Ⴍ().Ⴅ().Ⴓ()
				.ArcConnects.GetEnumerator();
			try
			{
				int num4 = 6;
				KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
				while (true)
				{
					switch (num4)
					{
					default:
						num4 = 7;
						continue;
					case 2:
						current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
						goto case 4;
					case 4:
						num4 = ((!current.Value.Io.IsConnected) ? ⴄႭ[94] : 8);
						continue;
					case 0:
					case 8:
						(obj3 as List<ArcConnect>).Add(current.Value);
						break;
					case 7:
						break;
					case 3:
					case 5:
						goto end_IL_00fd;
					}
					num4 = ((enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? 2 : (ⴅ[147] / 6));
					continue;
					end_IL_00fd:
					break;
				}
			}
			finally
			{
				int num5 = 4;
				while (true)
				{
					int num6;
					switch (num5)
					{
					default:
						num6 = ((enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>) ? 3 : 0);
						goto IL_01bf;
					case 2:
					case 3:
						(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
						break;
					case 0:
						break;
					}
					break;
					IL_01bf:
					num5 = num6;
				}
			}
			switch (0)
			{
			default:
			{
				List<ArcConnect> obj4 = obj3 as List<ArcConnect>;
				if (Ⴍ == null)
				{
					Ⴍ = Ⴄ;
				}
				obj4.Sort(Ⴍ);
				List<ArcConnect> obj5 = obj3 as List<ArcConnect>;
				if ((Action<ArcConnect>)obj == null)
				{
					obj = new Action<ArcConnect>(((ႥႥ)obj2).Ⴀ);
				}
				obj5.ForEach(obj as Action<ArcConnect>);
				(obj2 as ႥႥ).Ⴄ.Ⴀ();
				break;
			}
			case 4:
				break;
			case 1:
			case 3:
				goto end_IL_002c;
			}
			object obj6 = new Publisher();
			((Publisher)obj6).Process(((ႥႥ)obj2).Ⴄ);
			end_IL_002c:;
		}
		catch (Exception ex)
		{
			ShowConnects.Ⴍ.Error(SkimmerSpotBins.Ⴈ(ex as Exception, 231, 201));
		}
		switch (4)
		{
		}
	}

	private static void Ⴈ(NodeUserCmd P_0, ArcConnect P_1)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 5;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			switch (num)
			{
			default:
				enumerable = string.Empty;
				enumerable = P_1.Call;
				enumerable = ShowAnnHelp.Ⴀ((string)enumerable, 15, 360, 318);
				num = ⴀ[14] - 32165;
				break;
			case 6:
				enumerable = SetWxCountHelp.Ⴗ((object)(enumerable as string), (object)P_1.ConnectState, 154, (short)225);
				goto case 3;
			case 3:
				num = ⴃႠ[332] - 65389;
				break;
			case 0:
				enumerable = ShowAnnHelp.Ⴀ((string)enumerable, 30, 100, 50);
				goto case 1;
			case 1:
				enumerable = (string)enumerable + Ⴈ(P_1);
				num = 4;
				break;
			case 2:
			case 4:
				P_0.Tx.Msg.Add((string)enumerable);
				return;
			}
		}
	}

	private static string Ⴈ(ArcConnect P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		while (true)
		{
			int num = (ႰႨ.ႥႥ(P_0.Io.IoCfg.IpAddress, '\u02fe', '\u02d8') ? 1 : 3);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴅ[120] / 4;
					continue;
				case 5:
					break;
				case 3:
				case 6:
					return P_0.Io.IoCfg.IpAddress;
				case 1:
					num = (ႰႨ.ႥႥ(P_0.Io.EndPoint, 'x', '^') ? 4 : (ⴄႷ[126] - 39162));
					continue;
				case 8:
					return P_0.Io.EndPoint;
				case 4:
					return string.Empty;
				}
				break;
			}
		}
	}

	private static int Ⴄ(ArcConnect P_0, ArcConnect P_1)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int result = SetStationLoginCmds.Ⴀ(P_0.Call, P_1.Call, 732, 764);
		SetAnnMode.ႤႭ[37] = (byte)((SetAnnMode.ႤႭ[37] | SetAnnMode.ႤႭ[223]) & 0x58);
		return result;
	}
}
