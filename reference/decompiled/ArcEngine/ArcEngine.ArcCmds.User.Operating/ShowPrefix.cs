using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Security;
using System.Xml;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces.Arcx;
using ArcInterfaces.Spots;
using ArcShared;
using ArcShared.ArcUtils;
using ArcShared.ExtensionMethods.Login;
using HtmlAgilityPack;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowPrefix : IArcCmd
{
	private static void Ⴄ(NodeUserCmd P_0)
	{
		int num = 4;
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(4, 4, 1157903443), P_0.Rx.Msg, 146, 220));
				goto IL_0052;
			case 2:
				goto IL_0052;
			case 1:
			{
				object obj = new ShowPrefixHelp();
				(obj as ShowPrefixHelp).Exec(P_0);
				obj2 = new Publisher();
				break;
			}
			case 0:
				break;
			case 3:
				return;
			}
			break;
			IL_0052:
			num = 1;
		}
		(obj2 as Publisher).Process(P_0);
		BandModeCacheCfg.ႠႳ[114] = (char)((BandModeCacheCfg.ႠႳ[114] - BandModeCacheCfg.ႠႳ[126]) & 0x76);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			int num = 6;
			IConvertible msgEnd = default(IConvertible);
			object obj3 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length < 3) ? 3 : 9);
					continue;
				case 9:
					msgEnd = cmd.Rx.GetMsgEnd(2);
					goto case 2;
				case 2:
					obj3 = cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႤႷ()
						.CtyInfoFromCall(SetDxFilter.Ⴀ((string)msgEnd, 391, 'ǆ'));
					num = ⴃႥ[104] - ⴃႥ[104];
					continue;
				case 0:
					num = (((CtyInfo)obj3 == null) ? 12 : (ⴃႰ[52] - 57976));
					continue;
				case 11:
					cmd.Tx.Msg.Add(qslinfoResponse.Ⴗ(SetTalkCount.Ⴗ(0, null, 1267017476, typeof(ႳႠ.ႷႣ)), SetDxOutput.Ⴓ((CtyInfo)obj3, 227, 212), ShowSkimCtyHelp.Ⴍ(1216129093, 3, 'þ'), qslinfoSoapClient.Ⴈ(obj3 as CtyInfo, 'G', 94), 879, '\u030c'));
					num = 7;
					continue;
				case 1:
				case 7:
				{
					List<string> msg2 = cmd.Tx.Msg;
					Array array = new object[8];
					(array as object[])[0] = SetStationQth.Ⴍ(null, 1687354460, 1, 22);
					((object[])array)[1] = ShowDxFilter.Ⴈ(obj3 as CtyInfo, '\u0312', '\u035b');
					((object[])array)[2] = ShowWxHelp.Ⴍ('\u007f', 985805813, 5);
					((object[])array)[3] = ShowUptime.Ⴄ(obj3 as CtyInfo, 753, 730);
					((object[])array)[4] = ShowSkimCtyHelp.Ⴍ(1216129106, 6, 'V');
					(array as object[])[5] = SetStationMacros.Ⴐ(obj3 as CtyInfo, 352, 'ħ');
					(array as object[])[6] = ႰႥ.Ⴅ(2, '#', 952621891);
					((object[])array)[7] = SetWxCountHelp.Ⴃ(obj3 as CtyInfo, '\u03a2', 943);
					msg2.Add(SetDxDefaultHelp.Ⴍ((object[])array, '\u02ed', 644));
					num = ⴀ[279] - 14077;
					continue;
				}
				case 5:
				{
					List<string> msg = cmd.Tx.Msg;
					object obj2 = new object[4];
					(obj2 as object[])[0] = ႰႥ.Ⴅ(6, 'Û', 952621392);
					((object[])obj2)[1] = ShowAnn.Ⴀ(obj3 as CtyInfo, 657, 741);
					(obj2 as object[])[2] = ReplyMail.Ⴅ(5, 0, 1217942177);
					((object[])obj2)[3] = (obj3 as CtyInfo).Longitude;
					msg.Add(string.Concat(obj2 as object[]));
					num = 4;
					continue;
				}
				case 4:
				{
					object obj = new Publisher();
					(obj as Publisher).Process(cmd);
					num = ⴀႳ[105] - 23056;
					continue;
				}
				case 3:
					Ⴄ(cmd);
					break;
				case 12:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴄ(cmd);
		}
		switch (0)
		{
		}
	}

	[SecuritySafeCritical]
	internal static HtmlNode Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : HtmlDocument
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		object obj = default(object);
		int num3 = default(int);
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
					num2 = 2;
					continue;
				case 2:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 94) ^ num) switch
					{
						0 => 7, 
						_ => 5, 
					};
					continue;
				case 5:
					obj = null;
					num2 = ⴅ[407] - 98;
					continue;
				case 1:
				case 7:
					obj = P_0.DocumentNode;
					num2 = 4;
					continue;
				case 4:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 6;
				case 6:
					num2 = ⴀႼ[7] / 7;
					continue;
				case 11:
					num2 = ((num3 % 2 != 0) ? 3 : (ⴃႥ[304] - 54434));
					continue;
				case 8:
					return (HtmlNode)obj;
				case 0:
				case 10:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴓ(double P_0, double P_1, int P_2, char P_3)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool result = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[14] - 22027;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႳ[38] - 44452;
					continue;
				case 2:
					break;
				case 7:
					num2 = (((P_3 ^ P_2) - 94) ^ num) switch
					{
						0 => ⴍႭ[47] - 63730, 
						_ => 10, 
					};
					continue;
				case 10:
					result = false;
					num2 = ⴄႤ[502] - 45;
					continue;
				case 0:
					result = UtilsLatLon.IsNonZeroLatLon(P_0, P_1);
					num2 = ⴃႥ[401] - 25393;
					continue;
				case 3:
				case 4:
				case 6:
					num++;
					num3 = 968;
					num4 = 201;
					goto case 5;
				case 5:
					num2 = ((242 < num3 / 4 - num4) ? (ⴃႰ[174] - 58158) : (ⴄႤ[155] / 5));
					continue;
				case 9:
					return result;
				case 8:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DxSpot
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		IComparable comparable = default(IComparable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 11;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 1:
				case 3:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 51) ^ num) switch
					{
						0 => ⴍႭ[92] - 9989, 
						_ => ⴀႼ[34] - 241, 
					};
					continue;
				case 2:
				case 8:
					comparable = null;
					num2 = 5;
					continue;
				case 7:
					comparable = P_0.SpotterNode;
					num2 = 5;
					continue;
				case 5:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					goto case 6;
				case 6:
					num2 = ⴀ[436] - 2464;
					continue;
				case 10:
				{
					int num4;
					if (num3 % 2 == 0)
					{
						num4 = ⴃႠ[355] - 31864;
					}
					else
					{
						char num5 = ⴃႠ[237];
						SetDxCountHelp.ႭႤ[4] = SetDxCountHelp.ႭႤ[4] & SetTalkCountHelp.Ⴅ[278] & 0xEB;
						num4 = num5 - 39370;
					}
					num2 = num4;
					continue;
				}
				case 9:
					return (string)comparable;
				case 0:
					num2 = ⴃႠ[411] - 51472;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static IEnumerator Ⴅ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : XmlNode
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 10;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႥ[203] - 52429;
					continue;
				case 7:
					break;
				case 10:
					num2 = (((P_1 ^ P_2) - 126) ^ num) switch
					{
						0 => ⴄႤ[135], 
						_ => 6, 
					};
					continue;
				case 6:
				case 8:
					obj = null;
					num2 = 2;
					continue;
				case 5:
					obj = P_0.GetEnumerator();
					num2 = ⴃႥ[231] - 57242;
					continue;
				case 0:
				case 2:
					num++;
					num3 = 921;
					num4 = 213;
					goto case 1;
				case 1:
					num2 = ((307 < num3 / 3 - num4) ? 10 : (ⴀႣ[395] - 44448));
					continue;
				case 4:
					return (IEnumerator)obj;
				case 9:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : PerformanceCounter
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		long result = default(long);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[452] - 4510;
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
				case 8:
				{
					int num4 = P_2 ^ P_1;
					ႨႣ.Ⴐ[88] = (byte)((ႨႣ.Ⴐ[88] | P_1) & 0x67);
					num2 = ((num4 - 119) ^ num) switch
					{
						0 => ⴐ[52] - 117, 
						_ => 4, 
					};
					continue;
				}
				case 4:
					result = 2L;
					num2 = 5;
					continue;
				case 10:
				case 11:
					result = P_0.Increment();
					num2 = 5;
					continue;
				case 5:
				case 9:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴀႼ[134] - 148;
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? 8 : (ⴍႤ[408] - 25579));
					continue;
				case 6:
					return result;
				case 0:
				case 2:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string[] Ⴃ<_0021_00210>(_0021_00210 P_0, char[] P_1, int P_2, short P_3, int P_4) where _0021_00210 : string
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		Array array = default(Array);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
					break;
				case 4:
				case 6:
					num2 = (((P_3 ^ P_4) - 95) ^ num) switch
					{
						0 => 8, 
						_ => ⴃႥ[228] - 40970, 
					};
					continue;
				case 7:
					array = null;
					num2 = 11;
					continue;
				case 8:
				case 10:
					array = P_0.Split(P_1, P_2);
					num2 = 11;
					continue;
				case 11:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴄႷ[70] - 5430) : 5);
					continue;
				case 5:
					num2 = ⴄႤ[385] - 45;
					continue;
				case 1:
				case 9:
					return (string[])array;
				case 3:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, short P_2, short P_3) where _0021_00210 : ICredentials where _0021_00211 : WebProxy
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႳ[55] - 32499;
				break;
			case 1:
				num = (((P_3 ^ P_2) - 23) ^ num2) switch
				{
					0 => 5, 
					_ => 4, 
				};
				break;
			case 4:
				num = ⴄႭ[246];
				break;
			case 5:
			case 9:
				P_0.Credentials = P_1;
				goto case 2;
			case 2:
			case 7:
			case 8:
			{
				num2++;
				int num3 = (P_3 * P_3 + P_3) % 2;
				AnnCacheCfg.ႠႼ[120] = (byte)(AnnCacheCfg.ႠႼ[120] & P_2 & 0x2E);
				num = ((num3 == 0) ? 3 : (ⴃႰ[72] - ⴃႰ[72]));
				break;
			}
			case 0:
				num = 1;
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : string where _0021_00211 : ArcLogInResp
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 5;
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
				num = (((P_2 ^ P_3) - 72) ^ num2) switch
				{
					0 => 2, 
					_ => 3, 
				};
				break;
			case 3:
				num = ⴃႥ[121] - 43212;
				break;
			case 2:
				P_0.DeserializeNode(P_1);
				goto case 6;
			case 6:
			case 7:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 != 0) ? 1 : 4);
				break;
			case 0:
			case 1:
				num = 9;
				break;
			case 4:
			case 8:
				return;
			}
		}
	}
}
