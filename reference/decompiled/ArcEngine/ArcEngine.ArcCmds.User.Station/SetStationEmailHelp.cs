using System;
using System.Security;
using ArcEngine.ArcCaches;
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
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using HtmlAgilityPack;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationEmailHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int num = 6;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(3, null, 1267019414, typeof(CtyCache)));
				goto case 0;
			case 0:
			case 4:
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216132369, 1, 'ø'));
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(3, '8', 952620050));
				num = 5;
				break;
			case 5:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 6, 62057747, null));
				num = 1;
				break;
			case 1:
			case 3:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static WxCfg Ⴈ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : ArcUserCfg
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႠ[284] - 64251;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 2:
					num2 = (((P_1 ^ P_2) - 52) ^ num) switch
					{
						0 => 0, 
						_ => ⴀႣ[218] - 43542, 
					};
					continue;
				case 3:
					obj = null;
					num2 = ⴃႥ[73] - 11824;
					continue;
				case 0:
				case 1:
					obj = P_0.Wx;
					num2 = ⴃႰ[4] - 5307;
					continue;
				case 4:
					num++;
					goto case 6;
				case 6:
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = 7;
					continue;
				case 7:
				case 8:
					num2 = ((num3 % 2 != 0) ? (ⴄႤ[47] / 6) : 5);
					continue;
				case 5:
					return obj as WxCfg;
				case 10:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static HtmlDocument Ⴗ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00210 : string where _0021_00211 : HtmlWeb
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႼ[33];
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
				case 9:
					num2 = (((P_2 ^ P_3) - 28) ^ num) switch
					{
						0 => 4, 
						_ => ⴐ[303] - 107, 
					};
					continue;
				case 5:
					obj = null;
					goto case 7;
				case 7:
					num2 = 3;
					continue;
				case 2:
				case 4:
					obj = P_0.Load(P_1);
					num2 = 3;
					continue;
				case 1:
				case 3:
					num++;
					num3 = P_3 * P_3;
					num3 = P_3 + num3;
					num2 = 8;
					continue;
				case 8:
					num2 = ((num3 % 2 != 0) ? (ⴐ[228] - 200) : 11);
					continue;
				case 11:
					return (HtmlDocument)obj;
				case 6:
					num2 = ⴀႨ[125] - 14035;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		IEquatable<string> equatable = default(IEquatable<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
					break;
				case 4:
				case 8:
					num2 = (((P_3 ^ P_2) - 65) ^ num) switch
					{
						0 => 3, 
						_ => ⴃႥ[126] - 63597, 
					};
					continue;
				case 11:
					equatable = null;
					num2 = ⴅ[194] - 223;
					continue;
				case 3:
				{
					equatable = UnZipFiles.UnZip(P_0, P_1);
					byte num4 = ⴀႼ[113];
					byte num5 = ⴀႼ[136];
					AnnCacheCfg.ႠႼ[143] = (byte)(AnnCacheCfg.ႠႼ[143] & P_3 & 0xC5);
					num2 = num4 + num5;
					continue;
				}
				case 7:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 10;
				case 10:
					num2 = 1;
					continue;
				case 1:
				case 6:
					num2 = ((num3 % 2 != 0) ? (ⴅ[162] - ⴅ[181]) : 0);
					continue;
				case 0:
					return (string)equatable;
				case 9:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210>(_0021_00210 P_0, OutputType P_1, int P_2, char P_3) where _0021_00210 : AnnCfg
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 1;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴍႤ[204] - 7797;
				continue;
			case 5:
				num = (((P_2 ^ P_3) - 122) ^ num2) switch
				{
					0 => ⴄႤ[359] - 41, 
					_ => ⴄႷ[47] - 19220, 
				};
				continue;
			case 6:
			case 7:
				num = ⴃႠ[369] - 15019;
				continue;
			case 4:
			case 8:
				P_0.Output = P_1;
				goto case 3;
			case 3:
				num2++;
				num3 = 482;
				break;
			case 0:
				break;
			case 2:
				return;
			}
			int num4 = 125;
			num = ((241 < num3 / 2 - num4) ? 5 : 2);
		}
	}
}
