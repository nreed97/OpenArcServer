using System;
using System.Security;
using System.Xml;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcWeb;
using ArcInterfaces;
using ArcShared.ArcUtils;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationLoginCmdsHelp : IArcCmd
{
	internal sealed class Ⴃ
	{
		internal ConnectStateType Ⴃ;

		internal string Ⴍ;

		internal string Ⴐ;

		internal string Ⴈ;

		internal string Ⴀ;

		internal Guid Ⴅ;

		internal SerializableConcurrentDictionary<Guid, ArcConnectObj> Ⴓ;

		internal Ⴃ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(2, null, 1267015285, typeof(YahooGeoRef)));
				num = ⴀႣ[348] - 32289;
				break;
			case 6:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130588, 8, '('));
				goto case 0;
			case 0:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(19, null, 1057166585, 0));
				goto case 1;
			case 1:
				num = ⴄႷ[100] - 20024;
				break;
			case 3:
			{
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 5, 62057205, null));
				char num2 = ⴄႷ[33];
				ShowWwvOptionsHelp.ႣႥ[114] = (char)((ShowWwvOptionsHelp.ႣႥ[114] * BandModeCacheCfg.ႠႳ[238]) & 0xEF);
				num = num2 - 18066;
				break;
			}
			case 4:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, short P_3) where _0021_00210 : XmlNode where _0021_00211 : string
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 5;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 2;
				break;
			case 2:
				num = (((P_3 ^ P_2) - 124) ^ num3) switch
				{
					0 => 0, 
					_ => 3, 
				};
				break;
			case 3:
				num = 9;
				break;
			case 0:
				P_0.InnerText = P_1;
				goto case 9;
			case 9:
				num3++;
				goto case 4;
			case 4:
				num2 = P_3 * P_3;
				goto case 1;
			case 1:
			case 7:
				num2 = P_3 + num2;
				num = ⴍႤ[492] - 50185;
				break;
			case 8:
				num = ((num2 % 2 != 0) ? 2 : (ⴄႤ[493] - 130));
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴀ(DateTime P_0, DateTime P_1, char P_2, char P_3)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool result = default(bool);
		int num3 = default(int);
		int num4 = default(int);
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
					num2 = 1;
					continue;
				case 1:
					break;
				case 2:
				case 5:
					num2 = (((P_3 ^ P_2) - 33) ^ num) switch
					{
						0 => ⴍႤ[212] - 34335, 
						_ => ⴍႤ[389] - 64197, 
					};
					continue;
				case 10:
					result = true;
					num2 = ⴄႤ[435] - 173;
					continue;
				case 4:
					result = P_0 < P_1;
					num2 = 8;
					continue;
				case 7:
				case 8:
					num++;
					num3 = 2;
					num4 = 40;
					goto case 0;
				case 0:
					num2 = ((160 > num4 - num3 * 4) ? 3 : 11);
					continue;
				case 11:
					num2 = 5;
					continue;
				case 3:
					return result;
				case 9:
					num2 = ⴃႰ[189] - 41969;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static short Ⴗ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : string where _0021_00211 : IFormatProvider
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		short result = default(short);
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
					num2 = 7;
					continue;
				case 3:
				case 7:
					break;
				case 5:
				case 6:
					num2 = (((P_2 ^ P_3) - 54) ^ num) switch
					{
						0 => 10, 
						_ => 1, 
					};
					continue;
				case 1:
					result = 5;
					num2 = ⴄႷ[70] - 5431;
					continue;
				case 10:
					result = Convert.ToInt16(P_0, P_1);
					num2 = 8;
					continue;
				case 2:
				case 8:
				{
					num++;
					int num3 = 254;
					int num4 = 18;
					num2 = ((127 < num3 / 2 - num4) ? 6 : 9);
					continue;
				}
				case 9:
					return result;
				case 0:
					num2 = ⴀႣ[13] - 52917;
					continue;
				}
				break;
			}
		}
	}
}
