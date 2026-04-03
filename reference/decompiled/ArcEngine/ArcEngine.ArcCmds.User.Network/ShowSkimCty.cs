using System;
using System.Collections.Generic;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ShowSkimCty : IArcCmd
{
	private sealed class ႥႷ
	{
		public NodeUserCmd Ⴀ;
	}

	private sealed class ႥႭ
	{
		public ႥႷ Ⴃ;

		public string Ⴍ;

		public int Ⴃ;

		public void Ⴍ(string P_0)
		{
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					this.Ⴍ = ShowUsersHelp.Ⴅ(this.Ⴍ, ShowAnnHelp.Ⴀ(P_0, 12, 27, 77), 609, 559);
					num = 1;
					break;
				case 0:
				case 1:
					Ⴃ++;
					num = ((Ⴃ <= 5) ? 3 : 2);
					break;
				case 2:
					this.Ⴃ.Ⴀ.Tx.Msg.Add(this.Ⴍ);
					Ⴃ = 0;
					num = 7;
					break;
				case 6:
				case 7:
					this.Ⴍ = string.Empty.PadRight(6);
					num = 3;
					break;
				case 3:
					return;
				}
			}
		}
	}

	private static readonly ILog m_Ⴃ = SkimmerValidSpot.Ⴐ(SetStationQth.Ⴍ(null, 1687353010, 5, 4), 899, 926);

	private static Comparison<string> m_Ⴗ;

	private static void Ⴍ(NodeUserCmd P_0)
	{
		int num = 4;
		IArcCmd arcCmd = default(IArcCmd);
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(4, 2, 1157903132), P_0.Rx.Msg, 1023, 945));
				goto IL_0052;
			case 3:
				goto IL_0052;
			case 0:
				arcCmd = new ShowSkimCtyHelp();
				break;
			case 1:
				break;
			}
			break;
			IL_0052:
			num = 0;
		}
		((ShowSkimCtyHelp)arcCmd).Exec(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		try
		{
			int num = 9;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length == 3) ? 1 : 7);
					continue;
				case 1:
				case 8:
					cmd.Tx.DistroType = DistroType.ToRequester;
					cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687353003, 2, 19));
					goto case 3;
				case 3:
					num = 0;
					continue;
				case 0:
				{
					object obj2 = cmd.Rx.Split[2];
					Ⴃ(cmd, (string)obj2);
					num = 4;
					continue;
				}
				case 4:
					obj = new Publisher();
					goto case 5;
				case 5:
					(obj as Publisher).Process(cmd);
					num = 2;
					continue;
				case 7:
					Ⴍ(cmd);
					break;
				case 2:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ShowSkimCty.m_Ⴃ.Error(SkimmerSpotBins.Ⴈ(ex, 332, 354));
		}
		switch (1)
		{
		}
	}

	private void Ⴃ(NodeUserCmd P_0, string P_1)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 12;
		object obj3 = default(object);
		object obj4 = default(object);
		object obj = default(object);
		int num2 = default(int);
		KeyValuePair<string, SkimmerCtyCoverageData> keyValuePair = default(KeyValuePair<string, SkimmerCtyCoverageData>);
		object obj2 = default(object);
		object obj5 = default(object);
		Array array = default(Array);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				obj3 = new ႥႷ();
				((ႥႷ)obj3).Ⴀ = P_0;
				obj4 = Ⴗ(((ႥႷ)obj3).Ⴀ, P_1);
				num = ⴀႳ[299] - 13487;
				break;
			case 11:
				obj = ((SkimmerCtyCoverageCache)obj4).CtyCoverageDict.ToArray();
				num2 = 0;
				num = ⴅ[459] - 82;
				break;
			case 13:
				keyValuePair = ((KeyValuePair<string, SkimmerCtyCoverageData>[])obj)[num2];
				obj2 = new ႥႭ();
				((ႥႭ)obj2).Ⴃ = (ႥႷ)obj3;
				num = ⴀႳ[236] - 22350;
				break;
			case 15:
				(obj2 as ႥႭ).Ⴍ = ShowAnnHelp.Ⴀ(keyValuePair.Key, 6, 336, 262);
				num = ⴅ[306] - 75;
				break;
			case 14:
				obj5 = new List<string>();
				array = keyValuePair.Value.SkimmerCoverage.ToArray();
				num3 = 0;
				goto case 6;
			case 6:
				num = ⴀႼ[67] - 224;
				break;
			case 1:
			case 3:
			{
				KeyValuePair<string, DateTime> keyValuePair2 = ((KeyValuePair<string, DateTime>[])array)[num3];
				((List<string>)obj5).Add(keyValuePair2.Key);
				goto case 4;
			}
			case 4:
				num = 0;
				break;
			case 0:
				num3++;
				num = ⴄႭ[236] - 98;
				break;
			case 10:
				num = ((num3 < ((KeyValuePair<string, DateTime>[])array).Length) ? (ⴃႠ[146] - 42166) : 16);
				break;
			case 16:
			{
				List<string> obj6 = (List<string>)obj5;
				if (ShowSkimCty.m_Ⴗ == null)
				{
					ShowSkimCty.m_Ⴗ = Ⴈ;
				}
				obj6.Sort(ShowSkimCty.m_Ⴗ);
				(obj2 as ႥႭ).Ⴃ = 0;
				(obj5 as List<string>).ForEach(((ႥႭ)obj2).Ⴍ);
				num = 2;
				break;
			}
			case 2:
				num = ((CallBlockCacheCfg.Ⴜ(SetDxFilter.Ⴀ((obj2 as ႥႭ).Ⴍ, 124, '<'), 574, 607) <= 6) ? 5 : 8);
				break;
			case 8:
				(obj3 as ႥႷ).Ⴀ.Tx.Msg.Add(((ႥႭ)obj2).Ⴍ);
				goto case 5;
			case 5:
				num2++;
				num = ⴍႭ[43] - 57283;
				break;
			case 9:
				num = ((num2 < (obj as KeyValuePair<string, SkimmerCtyCoverageData>[]).Length) ? 13 : (ⴀႳ[120] - 50672));
				break;
			case 7:
				return;
			}
		}
	}

	private SkimmerCtyCoverageCache Ⴗ(NodeUserCmd P_0, string P_1)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int value = default(int);
		while (true)
		{
			IEquatable<string> equatable;
			int num = (((equatable = P_1) == null) ? 10 : (ⴀႨ[221] - 55642));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 14;
					continue;
				case 14:
					break;
				case 20:
					num = ((ႳႠ.Ⴃ != null) ? 11 : (ⴀႼ[15] - 133));
					continue;
				case 16:
					ႳႠ.Ⴃ = new Dictionary<string, int>(10)
					{
						{
							ႨႨ.Ⴀ(0, 3, 1157905607),
							0
						},
						{
							SetTalkCount.Ⴗ(4, null, 1267021672, typeof(DirectoryOwnHelp)),
							1
						},
						{
							ReplyMailHelp.Ⴄ(11, null, 1057164039, 5),
							2
						},
						{
							CallBlockCacheCfg.Ⴅ(null, 5, 62055684, null),
							3
						},
						{
							SetStationClubHelp.Ⴍ(0, 1, 1747258516, null),
							4
						},
						{
							ႨႨ.Ⴀ(9, 2, 1157905612),
							5
						},
						{
							SetTalkCount.Ⴗ(6, null, 1267021671, typeof(SetWxDefault)),
							6
						},
						{
							ReplyMailHelp.Ⴄ(4, null, 1057164052, 6),
							7
						},
						{
							CallBlockCacheCfg.Ⴅ(null, 7, 62055689, null),
							8
						},
						{
							SetStationClubHelp.Ⴍ(14, 7, 1747258505, null),
							9
						}
					};
					num = 11;
					continue;
				case 11:
					num = ((!ႳႠ.Ⴃ.TryGetValue(equatable as string, out value)) ? 10 : 7);
					continue;
				case 7:
					num = value switch
					{
						0 => 17, 
						1 => 0, 
						2 => 19, 
						3 => ⴐ[50], 
						4 => ⴄႷ[56] - 36245, 
						5 => 13, 
						6 => 6, 
						7 => 4, 
						8 => ⴀ[251] - 7816, 
						9 => ⴀႼ[2], 
						_ => 15, 
					};
					continue;
				case 15:
					num = 10;
					continue;
				case 17:
					return P_0.Ⴍ().Ⴅ().Ⴀ()
						.ႨႳ()
						.Skim160Processor.SkimCtyCoverageCache;
				case 0:
				case 8:
					return P_0.Ⴍ().Ⴅ().Ⴀ()
						.ႨႳ()
						.Skim80Processor.SkimCtyCoverageCache;
				case 19:
					return P_0.Ⴍ().Ⴅ().Ⴀ()
						.ႨႳ()
						.Skim40Processor.SkimCtyCoverageCache;
				case 12:
					return P_0.Ⴍ().Ⴅ().Ⴀ()
						.ႨႳ()
						.Skim30Processor.SkimCtyCoverageCache;
				case 3:
					return P_0.Ⴍ().Ⴅ().Ⴀ()
						.ႨႳ()
						.Skim20Processor.SkimCtyCoverageCache;
				case 13:
					return P_0.Ⴍ().Ⴅ().Ⴀ()
						.ႨႳ()
						.Skim17Processor.SkimCtyCoverageCache;
				case 2:
				case 6:
					return P_0.Ⴍ().Ⴅ().Ⴀ()
						.ႨႳ()
						.Skim15Processor.SkimCtyCoverageCache;
				case 4:
					return P_0.Ⴍ().Ⴅ().Ⴀ()
						.ႨႳ()
						.Skim12Processor.SkimCtyCoverageCache;
				case 1:
				case 9:
					return P_0.Ⴍ().Ⴅ().Ⴀ()
						.ႨႳ()
						.Skim10Processor.SkimCtyCoverageCache;
				case 18:
					return P_0.Ⴍ().Ⴅ().Ⴀ()
						.ႨႳ()
						.Skim6Processor.SkimCtyCoverageCache;
				case 10:
					ShowWwvOptionsHelp.ႣႥ[50] = (char)(ShowWwvOptionsHelp.ႣႥ[50] & ShowWwvOptionsHelp.ႣႥ[224] & 0xF0);
					return null;
				}
				break;
			}
		}
	}

	private static int Ⴈ(string P_0, string P_1)
	{
		return SetStationLoginCmds.Ⴀ(P_0, P_1, 425, 393);
	}
}
