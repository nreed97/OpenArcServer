using System;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using ArcEngine;
using ArcEngine.ArcCmds;
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
using ArcEngine.ArcCmds.UserProcessor;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;

namespace Ⴈ;

internal sealed class ႷႰ
{
	private sealed class ႥႳ
	{
		public NodeUserCmd Ⴄ;
	}

	private sealed class ႥႤ
	{
		public ႥႳ Ⴄ;

		public IArcCmd Ⴍ;

		public void Ⴍ(object P_0)
		{
			this.Ⴍ.Exec(Ⴄ.Ⴄ);
		}
	}

	internal sealed class Ⴄ
	{
		internal string Ⴈ;

		internal IIoDeviceCfg Ⴀ;

		internal Ⴄ()
		{
		}
	}

	private readonly UserCmdLookup m_Ⴗ;

	private SetDxCount.Ⴃ m_Ⴅ;

	internal ႷႰ(ObjectManager P_0)
	{
		this.m_Ⴅ.Ⴐ = P_0 as ObjectManager;
		this.m_Ⴗ = new UserCmdLookup();
	}

	internal void Ⴗ(string P_0, ArcConnect P_1)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 5;
		object obj = default(object);
		object obj3 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new ႥႳ();
				P_0 = SetDxFilter.Ⴀ(P_0, 165, 'å');
				(obj as ႥႳ).Ⴄ = new NodeUserCmd(P_1);
				num = ⴃႥ[112] - 11128;
				break;
			case 0:
			case 2:
				((ႥႳ)obj).Ⴄ.Rx.Msg = P_0;
				if (ႰႨ.ႥႥ(P_0, '\u0341', '\u0367'))
				{
					num = ⴅ[316] - 2;
					break;
				}
				while (true)
				{
					object obj2 = Ⴍ(P_0);
					int num2 = (((UserCmdCfg)obj2 == null) ? 4 : (ⴀႳ[116] - ⴀႳ[116]));
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 1:
						case 6:
							break;
						case 0:
						case 2:
							if (ႰႨ.ႥႥ(SetStationHereHelp.Ⴗ((UserCmdCfg)obj2, 'ʇ', 716), 'z', '\\'))
							{
								goto IL_012e;
							}
							try
							{
								int num3 = 1;
								while (true)
								{
									switch (num3)
									{
									default:
										obj3 = new ႥႤ();
										((ႥႤ)obj3).Ⴄ = (ႥႳ)obj;
										break;
									case 0:
									case 3:
										break;
									case 4:
										PublishInfo.Ⴅ(64, 27).StartNew((obj3 as ႥႤ).Ⴍ, TaskCreationOptions.PreferFairness);
										goto end_IL_0158;
									}
									((ႥႤ)obj3).Ⴍ = this.m_Ⴅ.Ⴐ.Ⴗ().Ⴈ(SetStationHereHelp.Ⴗ((UserCmdCfg)obj2, 'ɼ', 567));
									num3 = ⴃႠ[87] - 38009;
									continue;
									end_IL_0158:
									break;
								}
							}
							catch (Exception ex)
							{
								_ = (ex as Exception).Message;
								Ⴍ((obj as ႥႳ).Ⴄ, P_0);
							}
							switch (3)
							{
							}
							return;
						case 4:
							Ⴍ((obj as ႥႳ).Ⴄ, P_0);
							return;
						case 5:
							return;
						}
						break;
						IL_012e:
						num2 = ⴍႤ[313] - 18421;
					}
				}
			case 1:
			case 3:
			case 4:
				P_1.SendId();
				return;
			}
		}
	}

	private static void Ⴍ(NodeUserCmd P_0, string P_1)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.DistroType = DistroType.ToRequester;
				break;
			case 0:
			case 4:
				break;
			case 1:
			{
				object obj = new Publisher();
				(obj as Publisher).Process(P_0);
				return;
			}
			case 2:
				return;
			}
			P_0.Tx.Msg.Add(AnnHelp.Ⴈ(ReplyMailHelp.Ⴄ(1, null, 1057163993, 8), P_1, ShowSkimCtyHelp.Ⴍ(1216131441, 3, '_'), 750, '\u02d9'));
			num = ⴐ[228] - 208;
		}
	}

	private UserCmdCfg Ⴍ(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		while (true)
		{
			object obj = null;
			string text = LogEntry.Ⴄ(P_0, 'Ū', 320);
			Array array = new char[2];
			((char[])array)[0] = ' ';
			((char[])array)[1] = '/';
			Array array2 = Directory.Ⴓ(text, array as char[], 121, 47);
			int num = 6;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႥ[392] - 21709;
					continue;
				case 15:
					break;
				case 6:
					num = (((array2 as string[]).Length <= 3) ? 10 : (ⴃႰ[105] - 25529));
					continue;
				case 11:
				{
					UserCmdLookup ⴗ = this.m_Ⴗ;
					Array array3 = new object[7];
					(array3 as object[])[0] = (array2 as string[])[0];
					(array3 as object[])[1] = ' ';
					(array3 as object[])[2] = (array2 as string[])[1];
					(array3 as object[])[3] = ' ';
					(array3 as object[])[4] = ((string[])array2)[2];
					(array3 as object[])[5] = ' ';
					((object[])array3)[6] = (array2 as string[])[3];
					obj = ⴗ.GetCmdTag(SetDxDefaultHelp.Ⴍ((object[])array3, 'Ó', 186));
					num = ⴀႼ[8] - 191;
					continue;
				}
				case 7:
				case 10:
					num = ((obj is UserCmdCfg) ? (ⴍႤ[101] - 42320) : 14);
					continue;
				case 14:
					num = ((((string[])array2).Length > 2) ? 1 : 4);
					continue;
				case 1:
				{
					UserCmdLookup ⴗ2 = this.m_Ⴗ;
					Array array4 = new object[5];
					(array4 as object[])[0] = (array2 as string[])[0];
					((object[])array4)[1] = ' ';
					(array4 as object[])[2] = ((string[])array2)[1];
					((object[])array4)[3] = ' ';
					((object[])array4)[4] = (array2 as string[])[2];
					obj = ⴗ2.GetCmdTag(SetDxDefaultHelp.Ⴍ((object[])array4, 'Ƙ', 497));
					num = ⴀႳ[4] - 24693;
					continue;
				}
				case 4:
				case 5:
					num = ((obj is UserCmdCfg) ? 3 : 2);
					continue;
				case 2:
					num = (((array2 as string[]).Length <= 1) ? 3 : 12);
					continue;
				case 12:
					obj = this.m_Ⴗ.GetCmdTag(ShowPrefixCalls.Ⴃ((object)((string[])array2)[0], (object)' ', (object)(array2 as string[])[1], '\u0355', 895));
					num = ⴍႭ[89] - 16553;
					continue;
				case 3:
					num = ((obj is UserCmdCfg) ? 8 : 13);
					continue;
				case 13:
					obj = this.m_Ⴗ.GetCmdTag((array2 as string[])[0]);
					num = 8;
					continue;
				case 8:
					return obj as UserCmdCfg;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static StringBuilder Ⴅ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : StringBuilder where _0021_00211 : string
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[340] - 57681;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႠ[304] - 2897;
					continue;
				case 10:
					break;
				case 5:
				{
					int num4 = (P_3 ^ P_2) - 48;
					int num5 = num;
					SetAnnMode.ႤႭ[226] = (byte)((SetAnnMode.ႤႭ[226] - SetAnnMode.ႤႭ[238]) & 0xFD);
					num2 = (num4 ^ num5) switch
					{
						0 => ⴀႣ[274] - 22511, 
						_ => ⴃႰ[28] - 44205, 
					};
					continue;
				}
				case 7:
				case 8:
					obj = null;
					num2 = ⴄႭ[311] - 86;
					continue;
				case 9:
					obj = P_0.Append(P_1);
					num2 = 6;
					continue;
				case 6:
					num++;
					goto case 0;
				case 0:
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 11;
					continue;
				case 11:
					num2 = ((num3 % 2 == 0) ? 1 : 5);
					continue;
				case 1:
				case 3:
					return (StringBuilder)obj;
				case 4:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}
}
