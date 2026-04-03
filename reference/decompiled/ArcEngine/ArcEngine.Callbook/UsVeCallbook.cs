using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using ArcEngine.ArcCaches;
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
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces;
using Common.Logging;
using Ⴈ;

namespace ArcEngine.Callbook;

public sealed class UsVeCallbook : IUsVeCallbook
{
	private static readonly ILog m_Ⴀ = NodeUserCmd.Ⴗ(ႰႥ.Ⴅ(8, '\u0096', 952623081), 591, 546);

	private ConcurrentDictionary<string, CallbookData> m_Ⴅ;

	private UsCallbook m_Ⴈ;

	private VeCallbook m_Ⴈ;

	public string CallbookDts => Ⴅ().Ⴀ();

	[SpecialName]
	private ConcurrentDictionary<string, CallbookData> Ⴃ()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		return this.m_Ⴅ;
	}

	[SpecialName]
	private void Ⴀ(ConcurrentDictionary<string, CallbookData> P_0)
	{
		this.m_Ⴅ = P_0;
	}

	[SpecialName]
	internal UsCallbook Ⴅ()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		return this.m_Ⴈ;
	}

	[SpecialName]
	internal void Ⴈ(UsCallbook P_0)
	{
		this.m_Ⴈ = P_0;
	}

	[SpecialName]
	internal VeCallbook Ⴀ()
	{
		VeCallbook ⴈ = this.m_Ⴈ;
		ShowSunHelp.ႣႠ[150] = (char)((ShowSunHelp.ႣႠ[150] | SetWxOutput.ႣႰ[203]) & 0xBE);
		return ⴈ;
	}

	[SpecialName]
	internal void Ⴅ(VeCallbook P_0)
	{
		this.m_Ⴈ = P_0;
	}

	public UsVeCallbook(CallBookExtCache callBookExtCache, string filePath)
	{
		Ⴀ(new ConcurrentDictionary<string, CallbookData>());
		Ⴈ(new UsCallbook(callBookExtCache, filePath));
		Ⴅ(new VeCallbook(filePath));
	}

	internal void Ⴓ()
	{
		Ⴅ().Ⴅ();
		Ⴀ().Preload();
	}

	public void Restart()
	{
		Ⴅ().Restart();
		Ⴀ().Restart();
	}

	public CallbookData Search(string call)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		while (true)
		{
			CallbookData value = null;
			while (true)
			{
				IL_0060:
				int num = ((!Ⴃ().ContainsKey(call)) ? 2 : 3);
				while (true)
				{
					CallbookData callbookData;
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴍႤ[73] - 60508;
						continue;
					case 5:
						break;
					case 7:
					case 9:
						goto IL_0060;
					case 3:
						Ⴃ().TryGetValue(call, out value);
						num = ⴀ[14] - 32163;
						continue;
					case 2:
						num = (SetAnnDefault.Ⴍ(call, SetTalkCount.Ⴗ(0, null, 1267019722, typeof(SkimmerValidSpot)), 632, 554) ? 1 : ⴐ[254]);
						continue;
					case 0:
						callbookData = Ⴅ().Ⴓ(call);
						goto IL_00e5;
					case 1:
					case 6:
						callbookData = Ⴀ().Ⴍ(call);
						goto IL_00e5;
					case 8:
						{
							return value;
						}
						IL_00e5:
						value = callbookData;
						Ⴃ().TryAdd(call, value);
						num = ⴄႭ[134];
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	public CallbookData Search(string call, string cty)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		IComparable comparable = default(IComparable);
		int value2 = default(int);
		while (true)
		{
			CallbookData value = null;
			int num = (Ⴃ().ContainsKey(call) ? 11 : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴐ[204] / 3;
					continue;
				case 2:
				case 14:
					break;
				case 11:
					Ⴃ().TryGetValue(call, out value);
					num = ⴀႼ[85] - 223;
					continue;
				case 0:
					num = (((comparable = cty) == null) ? 1 : (ⴃႥ[79] - 4224));
					continue;
				case 4:
					num = ((ႳႠ.Ⴅ != null) ? (ⴀႣ[70] - 49502) : (ⴃႠ[29] - 16842));
					continue;
				case 3:
					ႳႠ.Ⴅ = new Dictionary<string, int>(20)
					{
						{
							CallBlockCacheCfg.Ⴅ(null, 7, 62057562, null),
							0
						},
						{
							ReplyMailHelp.Ⴄ(27, null, 1057162207, 4),
							1
						},
						{
							SetStationClubHelp.Ⴍ(9, 5, 1747258037, null),
							2
						},
						{
							ႨႨ.Ⴀ(9, 4, 1157903565),
							3
						},
						{
							SetTalkCount.Ⴗ(8, null, 1267022391, typeof(ShowCluster.ႨႠ)),
							4
						},
						{
							ReplyMailHelp.Ⴄ(26, null, 1057162210, 8),
							5
						},
						{
							CallBlockCacheCfg.Ⴅ(null, 1, 62057550, null),
							6
						},
						{
							SetStationClubHelp.Ⴍ(10, 0, 1747258016, null),
							7
						},
						{
							ႨႨ.Ⴀ(4, 3, 1157903577),
							8
						},
						{
							SetTalkCount.Ⴗ(2, null, 1267022391, typeof(ShowNodes)),
							9
						},
						{
							ReplyMailHelp.Ⴄ(15, null, 1057162213, 5),
							10
						},
						{
							CallBlockCacheCfg.Ⴅ(null, 8, 62057597, null),
							11
						},
						{
							SetStationClubHelp.Ⴍ(1, 1, 1747258075, null),
							12
						},
						{
							ႨႨ.Ⴀ(2, 5, 1157903577),
							13
						},
						{
							SetStationQth.Ⴍ(null, 1687351300, 4, 4),
							14
						},
						{
							SetStationClubHelp.Ⴍ(5, 1, 1747258076, null),
							15
						},
						{
							ReplyMail.Ⴅ(6, 14, 1217944766),
							16
						},
						{
							CallBlockCacheCfg.Ⴅ(null, 2, 62057598, null),
							17
						},
						{
							ႰႥ.Ⴅ(5, 'Î', 952620242),
							18
						},
						{
							ReplyMailHelp.Ⴄ(1, null, 1057162238, 0),
							19
						}
					};
					num = 6;
					continue;
				case 6:
				case 13:
					num = ((!ႳႠ.Ⴅ.TryGetValue(comparable as string, out value2)) ? 1 : 8);
					continue;
				case 8:
					num = value2 switch
					{
						0 => 12, 
						1 => 9, 
						2 => 9, 
						3 => ⴀ[206] - 9796, 
						4 => 9, 
						5 => 9, 
						6 => 9, 
						7 => ⴃႥ[280] - 41711, 
						8 => ⴄႷ[11] - 38820, 
						9 => 9, 
						10 => 9, 
						11 => 9, 
						12 => 9, 
						13 => ⴄႷ[4] - 30643, 
						14 => ⴍႤ[66] - 29515, 
						15 => 9, 
						16 => 9, 
						17 => ⴍႤ[23] - 41755, 
						18 => 9, 
						19 => 9, 
						_ => ⴍႤ[36] - 43717, 
					};
					continue;
				case 7:
					num = ⴍႭ[127] - 24355;
					continue;
				case 12:
					value = Ⴀ().Ⴍ(call);
					Ⴃ().TryAdd(call, value);
					num = ⴃႰ[127] - 32169;
					continue;
				case 9:
					value = Ⴅ().Ⴓ(call);
					Ⴃ().TryAdd(call, value);
					num = ⴍႭ[18] - 56766;
					continue;
				case 1:
				case 10:
					return value;
				}
				break;
			}
		}
	}

	public string StateSearch(string call)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		while (true)
		{
			int num = (SetAnnDefault.Ⴍ(call, SetTalkCount.Ⴗ(2, null, 1267019720, typeof(DxHelp)), 753, 675) ? 3 : (ⴍႤ[35] - 22575));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႼ[96];
					continue;
				case 2:
				case 4:
				case 5:
				case 6:
					break;
				case 0:
					return Ⴅ().Ⴐ(call);
				case 3:
					return Ⴀ().Ⴄ(call);
				}
				break;
			}
		}
	}

	public string ShowHam(string call)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		while (true)
		{
			int num = (SetAnnDefault.Ⴍ(call, SetTalkCount.Ⴗ(0, null, 1267019722, typeof(DistroType)), 454, 404) ? 2 : 4);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႷ[66] - 17236;
					continue;
				case 6:
					break;
				case 4:
					return Ⴅ().Ⴈ(call);
				case 2:
					return Ⴀ().Ⴅ(call);
				}
				break;
			}
		}
	}

	public void Arc4CallbookBuild()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		try
		{
			int num = 5;
			DateTime dateTime = default(DateTime);
			IEvidenceFactory evidenceFactory = default(IEvidenceFactory);
			ICloneable cloneable = default(ICloneable);
			TimeSpan timeSpan = default(TimeSpan);
			while (true)
			{
				switch (num)
				{
				default:
					dateTime = PrintDxFilters.Ⴄ('ż', 'ğ');
					evidenceFactory = ShowLog.Ⴍ(422, 'Ʈ');
					num = 7;
					continue;
				case 7:
				case 8:
					cloneable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(evidenceFactory as Assembly, 63, 93), 361, 'ż'), CallBlockCacheCfg.Ⴅ(null, 6, 62054747, null), 457, 391);
					num = 1;
					continue;
				case 1:
					ShowPrefixCalls.Ⴄ(ShowUsersHelp.Ⴅ((string)cloneable, SetStationClubHelp.Ⴍ(11, 2, 1747261703, null), 558, 608), ShowUsersHelp.Ⴅ((string)cloneable, SetStationQth.Ⴍ(null, 1687353988, 6, 7), 732, 658), true, '\u0017', 117);
					num = 2;
					continue;
				case 2:
				{
					IComparable comparable = ႰႥ.Ⴅ(8, '"', 952621182);
					ႨႰ.Ⴗ(CommandType.Text, (string)comparable);
					num = 3;
					continue;
				}
				case 3:
				case 10:
				{
					IComparable comparable = SetStationQth.Ⴍ(null, 1687354024, 5, 17);
					ႨႰ.Ⴗ(CommandType.Text, comparable as string);
					num = 4;
					continue;
				}
				case 4:
					Ⴅ().Arc4CallbookBuild();
					Ⴀ().Arc4CallbookBuild();
					goto case 6;
				case 6:
					timeSpan = PrintDxFilters.Ⴄ('ɗ', 'ȴ') - dateTime;
					num = ⴃႰ[82] - 44767;
					continue;
				case 0:
					UsVeCallbook.m_Ⴀ.Info(ႨႨ.Ⴀ(10, 3, 1157905867) + timeSpan.Minutes + CallBlockCacheCfg.Ⴅ(null, 5, 62056063, null));
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			UsVeCallbook.m_Ⴀ.Error((ex as Exception).Message);
		}
		switch (0)
		{
		}
	}
}
