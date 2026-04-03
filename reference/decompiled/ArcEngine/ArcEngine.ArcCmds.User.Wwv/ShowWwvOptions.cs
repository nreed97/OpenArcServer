using System;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wwv;

public sealed class ShowWwvOptions : IArcCmd
{
	private static void Ⴍ(NodeUserCmd P_0)
	{
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 2:
				obj = new ShowWwvOptionsHelp();
				break;
			case 3:
			case 4:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(12, 3, 1157903444), P_0.Rx.Msg, 552, 614));
			num = 2;
		}
		((ShowWwvOptionsHelp)obj).Exec(P_0);
		object obj2 = new Publisher();
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		try
		{
			int num = 7;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length != 3) ? (ⴃႠ[131] - 13673) : 3);
					continue;
				case 3:
					cmd.Tx.DistroType = DistroType.ToRequester;
					goto case 2;
				case 2:
					cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687352027, 0, 14));
					num = 5;
					continue;
				case 5:
					cmd.Tx.Msg.Add(SetWxCountHelp.Ⴗ((object)ႨႨ.Ⴀ(5, 6, 1157903705), (object)WwvHelp.Ⴃ(ShowHeading.Ⴅ(cmd.Ⴍ().Cfg, 150, 146), 45, 'H'), 116, (short)15));
					goto case 8;
				case 8:
					num = 0;
					continue;
				case 0:
				{
					Ⴅ(cmd);
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					num = ⴃႰ[198] - 3698;
					continue;
				}
				case 1:
					Ⴍ(cmd);
					break;
				case 4:
				case 9:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴍ(cmd);
		}
		switch (4)
		{
		}
	}

	private static void Ⴅ(NodeUserCmd P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 1;
		IEquatable<string> equatable = default(IEquatable<string>);
		OutputType outputType = default(OutputType);
		while (true)
		{
			switch (num)
			{
			default:
				equatable = ShowWxHelp.Ⴍ('\u009c', 985808428, 1);
				outputType = StationHelp.Ⴃ(ShowHeading.Ⴅ(P_0.Ⴍ().Cfg, 182, 178), 561, 514);
				num = ⴍႭ[34] - 15436;
				break;
			case 2:
			case 3:
				num = outputType switch
				{
					OutputType.Off => ⴀ[162] - 41838, 
					OutputType.On => 8, 
					_ => ⴀႳ[84] - 27437, 
				};
				break;
			case 7:
				num = 6;
				break;
			case 0:
				equatable = ShowUsersHelp.Ⴅ((string)equatable, CallBlockCacheCfg.Ⴅ(null, 7, 62058144, null), 404, 474);
				num = 6;
				break;
			case 4:
			case 8:
				equatable = (string)equatable + ႨႨ.Ⴀ(8, 8, 1157903712);
				num = 6;
				break;
			case 6:
				P_0.Tx.Msg.Add((string)equatable);
				return;
			case 5:
				return;
			}
		}
	}
}
