using System;
using System.Collections.Generic;
using System.Security;
using System.Xml.Linq;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcDatabase;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ShowNodes : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(3, null, 1267020249, typeof(SqlHelperParameterCache)));
				goto IL_0081;
			case 4:
				goto IL_0081;
			case 0:
				cmd.Tx.Msg.Add(cmd.Ⴍ().Ⴅ().Ⴓ()
					.Ⴓ());
				break;
			case 1:
				break;
			}
			break;
			IL_0081:
			num = ⴃႰ[179] - ⴃႰ[179];
		}
		object enumerator = cmd.Ⴍ().Ⴅ().Ⴓ()
			.ArcConnects.GetEnumerator();
		try
		{
			int num2 = 3;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			KeyValuePair<Guid, ArcConnect> current2 = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				int num8;
				switch (num2)
				{
				case 4:
					current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
					if (Ⴃ(current.Value))
					{
						num2 = 7;
						break;
					}
					goto default;
				case 7:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(SetStationQth.Ⴍ(null, 1687352990, 7, 18), qslinfoResponse.Ⴃ(current.Value.Ⴓ(), 12, '_', 575, 'Ȁ'), 915, 989));
					num2 = ⴍႤ[322] - 63859;
					break;
				case 1:
					enumerable = string.Empty;
					goto case 6;
				case 6:
				{
					int num3 = 0;
					object enumerator2 = current.Value.ArcConnects.GetEnumerator();
					try
					{
						int num4 = 5;
						while (true)
						{
							switch (num4)
							{
							default:
								num4 = 10;
								continue;
							case 6:
								current2 = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator2).Current;
								num4 = ((!Ⴃ(current2.Value)) ? 10 : 12);
								continue;
							case 12:
								num4 = ((num3 != 0) ? 3 : 4);
								continue;
							case 4:
							case 8:
							case 11:
								enumerable = AnnHelp.Ⴈ((string)enumerable, ShowWxHelp.Ⴍ('ê', 985807415, 7), qslinfoResponse.Ⴃ(current2.Value.Ⴓ(), 12, '_', 428, 'Ɠ'), 926, 'Ω');
								num4 = ⴍႤ[169] - 33425;
								continue;
							case 3:
								enumerable = ShowUsersHelp.Ⴅ((string)enumerable, qslinfoResponse.Ⴃ(current2.Value.Ⴓ(), 12, '_', 276, 'ī'), 916, 986);
								num4 = 7;
								continue;
							case 1:
							case 7:
							{
								num3++;
								int num5 = num3;
								SetAnnMode.ႤႭ[288] = (byte)((SetAnnMode.ႤႭ[288] + SetAnnMode.ႤႭ[312]) & 0x2C);
								num4 = ((num5 < 5) ? 10 : (ⴍႤ[201] - 14713));
								continue;
							}
							case 9:
								cmd.Tx.Msg.Add((string)enumerable);
								num3 = 0;
								enumerable = string.Empty;
								num4 = 10;
								continue;
							case 10:
								num4 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator2).MoveNext() ? (ⴍႤ[17] - 62882) : (ⴃႠ[395] - 25833));
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					finally
					{
						int num6 = 3;
						while (true)
						{
							int num7;
							switch (num6)
							{
							default:
								num7 = ((!(enumerator2 is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 2 : 0);
								goto IL_0381;
							case 0:
							case 1:
								(enumerator2 as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
								break;
							case 2:
							case 4:
								break;
							}
							break;
							IL_0381:
							num6 = num7;
						}
					}
					num8 = 2;
					goto IL_0398;
				}
				default:
					{
						if (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).MoveNext())
						{
							goto case 4;
						}
						num8 = ⴀႳ[155] - 21206;
						goto IL_0398;
					}
					IL_0398:
					while (true)
					{
						switch (num8)
						{
						default:
							num8 = ((CallBlockCacheCfg.Ⴜ((string)enumerable, 138, 235) <= 0) ? ⴐ[257] : (ⴍႤ[287] - 10685));
							continue;
						case 5:
						case 6:
							cmd.Tx.Msg.Add(enumerable as string);
							goto case 1;
						case 1:
							enumerable = string.Empty;
							num8 = ⴍႭ[105] - 23846;
							continue;
						case 7:
							break;
						case 0:
							goto end_IL_0398;
						}
						goto default;
						continue;
						end_IL_0398:
						break;
					}
					goto end_IL_00da;
				}
				continue;
				end_IL_00da:
				break;
			}
		}
		finally
		{
			int num9 = 4;
			while (true)
			{
				int num10;
				switch (num9)
				{
				default:
					num10 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? (ⴀႳ[236] - 22364) : (ⴄႤ[394] - 17));
					goto IL_0483;
				case 0:
					(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
					break;
				case 1:
				case 6:
					break;
				}
				break;
				IL_0483:
				num9 = num10;
			}
		}
		object obj = default(object);
		switch (4)
		{
		default:
			cmd.Ⴀ();
			goto case 3;
		case 3:
			obj = new Publisher();
			break;
		case 1:
			break;
		case 2:
			return;
		}
		((Publisher)obj).Process(cmd);
	}

	private bool Ⴃ(ArcConnect P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		while (true)
		{
			int num = (P_0.Ⴃ() ? (ⴃႥ[270] - 59302) : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 5;
					continue;
				case 5:
					break;
				case 6:
					num = ((!P_0.Ⴄ()) ? ⴐ[254] : 7);
					continue;
				case 7:
					num = ((P_0.ConnectState == ConnectStateType.PcxxNode) ? 9 : 3);
					continue;
				case 3:
					return P_0.ConnectState == ConnectStateType.ArxNode;
				case 8:
				case 9:
					return true;
				case 0:
				case 1:
				case 4:
					return false;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴄ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, short P_3) where _0021_00210 : string where _0021_00211 : string
	{
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
				case 2:
					break;
				case 3:
					num2 = (((P_2 ^ P_3) - 63) ^ num) switch
					{
						0 => 7, 
						_ => 1, 
					};
					continue;
				case 1:
					result = P_2;
					goto case 11;
				case 11:
					num2 = 8;
					continue;
				case 7:
					result = P_0.IndexOf(P_1);
					num2 = 8;
					continue;
				case 8:
					num++;
					goto case 6;
				case 6:
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? 5 : 4);
					continue;
				case 4:
					num2 = 3;
					continue;
				case 5:
					return result;
				case 9:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴍ(ref TimeSpan P_0, int P_1, char P_2)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 0;
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
				case 0:
					num2 = (((P_1 ^ P_2) - 50) ^ num) switch
					{
						0 => 7, 
						_ => 6, 
					};
					continue;
				case 6:
					result = P_1;
					num2 = ⴀႼ[113];
					continue;
				case 7:
				case 8:
					result = P_0.Minutes;
					num2 = ⴐ[367] / 2;
					continue;
				case 2:
				{
					num++;
					int num3 = 194;
					int num4 = 3;
					num2 = ((97 >= num3 / 2 - num4) ? (ⴍႤ[440] - 1878) : 0);
					continue;
				}
				case 1:
				case 4:
					return result;
				case 3:
					num2 = ⴀႳ[178] - 52522;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : XElement
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[260] - 178;
					continue;
				case 1:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 18) ^ num) switch
					{
						0 => ⴃႰ[189] - 41963, 
						_ => 10, 
					};
					continue;
				case 10:
					equatable = null;
					num2 = 4;
					continue;
				case 7:
				case 11:
					equatable = P_0.Value;
					num2 = 4;
					continue;
				case 3:
				case 4:
					num++;
					goto case 0;
				case 0:
				{
					int num4;
					if ((P_2 * P_2 + P_2) % 2 != 0)
					{
						char num3 = ⴄႷ[66];
						SetAnnMode.ႤႭ[610] = (byte)((SetAnnMode.ႤႭ[610] + P_1) & 0xF9);
						num4 = num3 - 17237;
					}
					else
					{
						num4 = ⴄႤ[274] - 240;
					}
					num2 = num4;
					continue;
				}
				case 5:
					num2 = 8;
					continue;
				case 2:
					return equatable as string;
				case 6:
					num2 = ⴄႤ[459] - 236;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static OutputType Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : TalkCfg
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		OutputType result = default(OutputType);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႤ[278] - 18235;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 7:
					break;
				case 5:
					num2 = (((P_2 ^ P_1) - 26) ^ num) switch
					{
						0 => 8, 
						_ => 6, 
					};
					continue;
				case 0:
				case 3:
				case 6:
					result = OutputType.Off;
					num2 = 2;
					continue;
				case 8:
					result = P_0.Output;
					num2 = ⴃႥ[269] - 6345;
					continue;
				case 2:
				{
					num++;
					int num3 = 2884;
					int num4 = 183;
					num2 = ((721 >= num3 / 4 - num4) ? 1 : 5);
					continue;
				}
				case 1:
					return result;
				case 10:
					num2 = ⴃႥ[448] - 12689;
					continue;
				}
				break;
			}
		}
	}
}
