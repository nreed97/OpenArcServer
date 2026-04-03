using System;
using System.Security;
using ArcEngine.ArcCmds.NodeProcessor;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ExtensionMethods;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Talk;

public sealed class ShowTalkOptions : IArcCmd
{
	private static void Ⴗ(NodeUserCmd P_0)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
			{
				IArcCmd arcCmd = new ShowTalkOptionsHelp();
				((ShowTalkOptionsHelp)arcCmd).Exec(P_0);
				object obj = new Publisher();
				(obj as Publisher).Process(P_0);
				return;
			}
			case 4:
				return;
			}
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(15, 8, 1157903455), P_0.Rx.Msg, 236, 162));
			num = 0;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		try
		{
			int num = 7;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 3) ? 3 : 6);
					continue;
				case 6:
					cmd.Tx.DistroType = DistroType.ToRequester;
					cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687355237, 0, 9));
					num = ⴄႷ[2] - 23604;
					continue;
				case 2:
					cmd.Tx.Msg.Add(SetWxCountHelp.Ⴗ((object)ႨႨ.Ⴀ(5, 6, 1157898886), (object)ShowDateTime.Ⴀ(NodeCmdCfg.Ⴗ(cmd.Ⴍ().Cfg, 201, 131), 'Ɣ', 'Ǜ'), 594, (short)553));
					num = ⴄႷ[70] - 5430;
					continue;
				case 9:
				{
					Ⴍ(cmd);
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					goto case 5;
				}
				case 5:
					num = 0;
					continue;
				case 3:
				case 4:
					Ⴗ(cmd);
					break;
				case 0:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴗ(cmd);
		}
		switch (1)
		{
		}
	}

	private static void Ⴍ(NodeUserCmd P_0)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 2;
		IEquatable<string> equatable = default(IEquatable<string>);
		OutputType outputType = default(OutputType);
		while (true)
		{
			switch (num)
			{
			default:
				equatable = ShowWxHelp.Ⴍ('ê', 985805308, 0);
				outputType = ShowNodes.Ⴓ(NodeCmdCfg.Ⴗ(P_0.Ⴍ().Cfg, 110, 36), 556, 566);
				num = 5;
				break;
			case 5:
				num = outputType switch
				{
					OutputType.Off => ⴄႭ[303] - 245, 
					OutputType.On => ⴃႥ[369] - 3610, 
					_ => 4, 
				};
				break;
			case 3:
			case 4:
				num = 8;
				break;
			case 7:
				equatable = ShowUsersHelp.Ⴅ((string)equatable, CallBlockCacheCfg.Ⴅ(null, 8, 62058159, null), 665, 727);
				num = 8;
				break;
			case 0:
				equatable = (string)equatable + SetStationClubHelp.Ⴍ(14, 4, 1747263476, null);
				num = ⴍႭ[74] - 63169;
				break;
			case 8:
				P_0.Tx.Msg.Add(equatable as string);
				return;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : string where _0021_00211 : AnnWxSpot
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				continue;
			case 4:
			case 8:
				num = (((P_3 ^ P_2) - 13) ^ num2) switch
				{
					0 => ⴀ[525] - 26810, 
					_ => 6, 
				};
				continue;
			case 6:
				num = ⴀႼ[79] - 164;
				continue;
			case 0:
				P_0.DeserializeNode(P_1);
				break;
			case 2:
			case 3:
			case 5:
				break;
			case 1:
				return;
			}
			num2++;
			int num3 = 108;
			int num4 = 11;
			num = ((27 < num3 / 4 - num4) ? 8 : ⴄႤ[148]);
		}
	}
}
