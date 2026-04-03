using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Xml.Linq;
using ArcEngine;
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
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.MaintenanceUpdates;

namespace Ⴈ;

internal sealed class ႰႼ
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴈ
	{
		internal bool Ⴓ;

		internal string Ⴃ;
	}

	private ObjectManager m_Ⴐ;

	private DirectoryMonitor Ⴗ;

	private ShowDateTime.Ⴓ m_Ⴓ = new ShowDateTime.Ⴓ();

	[SpecialName]
	internal DirectoryMonitor Ⴅ()
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		return this.m_Ⴓ.Ⴈ;
	}

	[SpecialName]
	internal void Ⴐ(DirectoryMonitor P_0)
	{
		this.m_Ⴓ.Ⴈ = P_0;
		ႨႣ.Ⴐ[157] = (byte)((ႨႣ.Ⴐ[157] + SetTalkCountHelp.Ⴅ[295]) & 0x43);
	}

	[SpecialName]
	internal DirectoryMonitor Ⴀ()
	{
		return Ⴗ;
	}

	[SpecialName]
	internal void Ⴃ(DirectoryMonitor P_0)
	{
		Ⴗ = P_0;
	}

	internal ႰႼ(ObjectManager P_0)
	{
		this.m_Ⴐ = P_0;
		object obj = ShowLog.Ⴍ(987, 'ϓ');
		IComparable<string> comparable = SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(obj as Assembly, 68, 38), 292, 'ı');
		Ⴐ(new DirectoryMonitor(ShowUsersHelp.Ⴅ((string)comparable, ႨႨ.Ⴀ(5, 8, 1157902919), 379, 309)));
		ShowContestStationHelp.Ⴐ<DirectoryMonitor, FileSystemEvent>(Ⴅ(), Ⴅ, 453, 511);
		SetTalkDefaultHelp.Ⴓ(Ⴅ(), 690, 'ʞ');
		Ⴃ(new DirectoryMonitor((comparable as string) + ShowWxHelp.Ⴍ('\u0085', 985807691, 1)));
		Ⴀ().Change += Ⴀ;
		Ⴀ().Start();
	}

	private void Ⴀ(string P_0)
	{
		int num = 2;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			switch (num)
			{
			default:
				equatable = LogEntry.Ⴄ(ShowQslInfoHelp.Ⴓ(P_0, 21, 'a'), 'Ǉ', 493);
				break;
			case 1:
				break;
			case 0:
			case 3:
			case 4:
				this.m_Ⴐ.Ⴀ().ႨႰ().Ⴀ((string)equatable);
				SetWxOutput.ႣႰ[96] = (char)((SetWxOutput.ႣႰ[96] ^ ႨႣ.Ⴐ[184]) & 0x7C);
				return;
			}
			num = 4;
		}
	}

	private void Ⴅ(string P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 5;
		IConvertible convertible = default(IConvertible);
		IEnumerable enumerable = default(IEnumerable);
		int value = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				convertible = LogEntry.Ⴄ(ShowQslInfoHelp.Ⴓ(P_0, 59, 'O'), 'ư', 410);
				num = 3;
				break;
			case 3:
				ShowDxHelp.Ⴄ(1000, 458, 504);
				goto case 1;
			case 1:
				if ((enumerable = convertible as string) != null)
				{
					num = ⴄႷ[100] - 20020;
					break;
				}
				return;
			case 7:
				num = ((ႳႠ.Ⴈ == null) ? 2 : 0);
				break;
			case 2:
				ႳႠ.Ⴈ = new Dictionary<string, int>(16)
				{
					{
						ႨႨ.Ⴀ(0, 6, 1157902942),
						0
					},
					{
						CallBlockCacheCfg.Ⴅ(null, 4, 62055550, null),
						1
					},
					{
						SetTalkCount.Ⴗ(5, null, 1267019807, typeof(SetWxModeHelp)),
						2
					},
					{
						SetStationClubHelp.Ⴍ(9, 3, 1747258899, null),
						3
					},
					{
						ReplyMailHelp.Ⴄ(23, null, 1057162396, 4),
						4
					},
					{
						ႨႨ.Ⴀ(9, 2, 1157902952),
						5
					},
					{
						CallBlockCacheCfg.Ⴅ(null, 3, 62055529, null),
						6
					},
					{
						SetTalkCount.Ⴗ(1, null, 1267019784, typeof(SetDxCount)),
						7
					},
					{
						SetStationClubHelp.Ⴍ(5, 7, 1747258887, null),
						8
					},
					{
						ReplyMailHelp.Ⴄ(14, null, 1057162419, 2),
						9
					},
					{
						ႨႨ.Ⴀ(8, 6, 1157902869),
						10
					},
					{
						CallBlockCacheCfg.Ⴅ(null, 3, 62055428, null),
						11
					},
					{
						SetTalkCount.Ⴗ(6, null, 1267020028, typeof(PublishInfo)),
						12
					},
					{
						SetStationClubHelp.Ⴍ(3, 4, 1747258930, null),
						13
					},
					{
						ReplyMailHelp.Ⴄ(29, null, 1057162325, 8),
						14
					},
					{
						ႨႨ.Ⴀ(6, 8, 1157902888),
						15
					}
				};
				num = 0;
				break;
			case 0:
			case 9:
				if (ႳႠ.Ⴈ.TryGetValue(enumerable as string, out value))
				{
					num = 8;
					break;
				}
				return;
			case 4:
			case 8:
			{
				int num2;
				switch (value)
				{
				default:
					num = ⴄႤ[494] - 131;
					break;
				case 0:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.BadWord.AutoReload) ? (ⴀႨ[178] - 32266) : 8);
					goto IL_02df;
				case 1:
					goto IL_03cb;
				case 2:
					goto IL_0409;
				case 3:
					goto IL_0453;
				case 4:
					goto IL_049a;
				case 5:
					goto IL_04f1;
				case 6:
					goto IL_0536;
				case 7:
					goto IL_0577;
				case 8:
					goto IL_05b5;
				case 9:
					goto IL_0600;
				case 10:
					goto IL_0650;
				case 11:
					goto IL_069b;
				case 12:
					goto IL_06da;
				case 13:
					goto IL_0732;
				case 14:
					goto IL_0771;
				case 15:
					goto IL_07ae;
					IL_0453:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.CallBlock.AutoReload) ? 3 : (ⴃႥ[11] - 1970));
					goto IL_02df;
					IL_04f1:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.ConnectBlock.AutoReload) ? (ⴄႭ[56] / 9) : 34);
					goto IL_02df;
					IL_0536:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.ConnectBlock.AutoReload) ? 3 : ⴐ[50]);
					goto IL_02df;
					IL_02df:
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 36:
							break;
						case 8:
							this.m_Ⴐ.Ⴀ().ႤႤ().Init();
							return;
						case 9:
							goto IL_03cb;
						case 14:
							this.m_Ⴐ.Ⴀ().ႤႤ().Init();
							return;
						case 13:
							goto IL_0409;
						case 25:
							this.m_Ⴐ.Ⴀ().ႤႨ().Init();
							return;
						case 4:
							goto IL_0453;
						case 30:
							this.m_Ⴐ.Ⴀ().ႤႥ().Init();
							return;
						case 29:
							goto IL_049a;
						case 32:
							this.m_Ⴐ.Ⴀ().ႤႥ().Init();
							return;
						case 7:
							goto IL_04f1;
						case 34:
							this.m_Ⴐ.Ⴀ().ႤႰ().Init();
							return;
						case 22:
							goto IL_0536;
						case 12:
							this.m_Ⴐ.Ⴀ().ႤႰ().Init();
							return;
						case 5:
							goto IL_0577;
						case 28:
							this.m_Ⴐ.Ⴀ().ႤႷ().Init();
							return;
						case 0:
							return;
						case 10:
						case 11:
							goto IL_05b5;
						case 35:
							this.m_Ⴐ.Ⴀ().ႤႭ().Init();
							return;
						case 18:
							goto IL_0600;
						case 19:
							this.m_Ⴐ.Ⴀ().ႤႭ().Init();
							return;
						case 16:
							goto IL_0650;
						case 26:
							this.m_Ⴐ.Ⴀ().ႨႷ().Init();
							return;
						case 20:
							goto IL_069b;
						case 21:
							this.m_Ⴐ.Ⴀ().ႨႭ().Init();
							return;
						case 31:
							goto IL_06da;
						case 15:
							this.m_Ⴐ.Ⴀ().ႨႭ().Init();
							return;
						case 24:
							goto IL_0732;
						case 27:
							this.m_Ⴐ.Ⴀ().ႤႣ().Init();
							return;
						case 23:
							goto IL_0771;
						case 2:
							this.m_Ⴐ.Ⴀ().ႤႼ().Init();
							return;
						case 1:
						case 6:
							goto IL_07ae;
						case 33:
							this.m_Ⴐ.Ⴀ().ႨႥ().Init();
							num2 = ⴄႭ[330] - 25;
							continue;
						case 3:
							return;
						}
						break;
					}
					goto case 0;
					IL_07ae:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.Top100.AutoReload) ? ⴐ[21] : (ⴀႣ[105] - 53580));
					goto IL_02df;
					IL_0409:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.BandMode.AutoReload) ? 3 : (ⴀ[394] - 22117));
					goto IL_02df;
					IL_069b:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.IpLockout.AutoReload) ? 3 : 21);
					goto IL_02df;
					IL_0771:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.MasterCall.AutoReload) ? 3 : 2);
					goto IL_02df;
					IL_0650:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.Foc.AutoReload) ? 3 : (ⴅ[362] - 166));
					goto IL_02df;
					IL_0577:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.Cty.AutoReload) ? 3 : 28);
					goto IL_02df;
					IL_05b5:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.DxSpotBlock.AutoReload) ? (ⴃႠ[429] - 37100) : 35);
					goto IL_02df;
					IL_0732:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.Lotw.AutoReload) ? 3 : 27);
					goto IL_02df;
					IL_049a:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.CallBlock.AutoReload) ? (ⴃႥ[276] - 61050) : (ⴃႠ[231] - 45391));
					goto IL_02df;
					IL_0600:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.DxSpotBlock.AutoReload) ? (ⴄႷ[4] - 30649) : (ⴃႰ[52] - 57968));
					goto IL_02df;
					IL_03cb:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.BadWord.AutoReload) ? 3 : 14);
					goto IL_02df;
					IL_06da:
					num2 = ((!this.m_Ⴐ.Ⴍ().Caches.IpLockout.AutoReload) ? (ⴀႣ[191] - 2731) : (ⴀႨ[145] - 20384));
					goto IL_02df;
				}
				break;
			}
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ(char P_0, char P_1, int P_2)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႣ[397] - 15144;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀ[156] - ⴀ[156];
					continue;
				case 0:
					break;
				case 4:
				{
					int num4 = (P_1 ^ P_2) - 99;
					int num5 = num;
					DirectoryBulletin.ႠႨ[117] = (DirectoryBulletin.ႠႨ[117] - P_2) & 0xB8;
					num2 = (num4 ^ num5) switch
					{
						0 => ⴃႠ[22] - 46287, 
						_ => 7, 
					};
					continue;
				}
				case 7:
					comparable = null;
					num2 = ⴄႭ[31] / 2;
					continue;
				case 1:
				case 6:
				case 9:
				case 11:
					comparable = Convert.ToString(P_0);
					num2 = ⴍႭ[282] - 33567;
					continue;
				case 5:
					num++;
					num3 = P_0 * P_0;
					num3 = P_0 + num3;
					num2 = 2;
					continue;
				case 2:
					num2 = ((num3 % 2 != 0) ? 4 : 8);
					continue;
				case 8:
					return comparable as string;
				case 3:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static XName Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : XElement
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 10:
					break;
				case 5:
					num2 = (((P_2 ^ P_1) - 8) ^ num) switch
					{
						0 => ⴄႷ[100] - 20021, 
						_ => 3, 
					};
					continue;
				case 3:
					obj = null;
					num2 = 0;
					continue;
				case 6:
					obj = P_0.Name;
					num2 = ⴄႭ[66];
					continue;
				case 0:
					num++;
					num3 = 2229;
					goto case 1;
				case 1:
				case 4:
				{
					int num4 = 566;
					num2 = ((743 < num3 / 3 - num4) ? 5 : 7);
					continue;
				}
				case 7:
					return obj as XName;
				case 9:
					num2 = ⴀႼ[136];
					continue;
				}
				break;
			}
		}
	}
}
