using System;
using System.Collections;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds;

public sealed class RxNodeUserCmd
{
	private static readonly ILog Ⴐ = SkimmerValidSpot.Ⴐ(ႨႨ.Ⴀ(13, 7, 1157904941), 715, 726);

	private string Ⴅ;

	private bool Ⴃ;

	private DxCmdMsgExt.ႨႳ Ⴀ;

	public bool IsContestXml
	{
		get
		{
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	public string Msg
	{
		get
		{
			return Ⴅ;
		}
		set
		{
			Ⴅ = value;
			Split = Directory.Ⴓ(value, new char[3] { ' ', '/', '_' }, 991, 905);
			ShowQrzHelp.ႤႤ[509] = (byte)(ShowQrzHelp.ႤႤ[509] & ႨႣ.Ⴐ[249] & 3);
		}
	}

	public string[] Split
	{
		get
		{
			string[] ⴍ = Ⴀ.Ⴍ;
			Arc4ServerClient.ႠႣ[58] = (char)((Arc4ServerClient.ႠႣ[58] | Arc4ServerClient.ႠႣ[387]) & 0x72);
			return ⴍ;
		}
		set
		{
			Ⴀ.Ⴍ = value;
			SetDxCountHelp.ႭႤ[123] = (SetDxCountHelp.ႭႤ[123] * SetDxCountHelp.ႭႤ[174]) & 0x41;
		}
	}

	public string CmdKey
	{
		get
		{
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			while (true)
			{
				int num = ((SetStationNeedsHelp.Ⴃ(Msg, 0, 353, 258) != '<') ? 4 : 6);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴍႤ[335] - 55567;
						continue;
					case 0:
						break;
					case 5:
					case 6:
					case 8:
						return LogEntry.Ⴄ(Msg, 'Î', 227);
					case 2:
					case 4:
						num = ((CallBlockCacheCfg.Ⴜ(Msg, 118, 23) < 4) ? 1 : 7);
						continue;
					case 1:
						return string.Empty;
					case 7:
						return Msg.Substring(0, 4);
					}
					break;
				}
			}
		}
	}

	public string GetMsgEnd(int start)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		while (true)
		{
			IEnumerable enumerable = string.Empty;
			int num = start;
			int num2 = ⴃႰ[99] - 21867;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႭ[278] - 27793;
					continue;
				case 4:
				case 6:
					break;
				case 7:
					num2 = ((CallBlockCacheCfg.Ⴜ(enumerable as string, 653, 748) <= 0) ? (ⴍႭ[105] - 23845) : (ⴀႳ[57] - 52670));
					continue;
				case 9:
					enumerable = SetWxCountHelp.Ⴗ((object)(enumerable as string), (object)' ', 214, (short)173);
					num2 = ⴄႭ[405] - 231;
					continue;
				case 3:
				case 8:
					enumerable = ShowUsersHelp.Ⴅ((string)enumerable, Split[num], 887, 825);
					num2 = 0;
					continue;
				case 0:
				case 10:
					num++;
					num2 = ⴐ[124] - 67;
					continue;
				case 2:
					num2 = ((num >= Split.Length) ? 1 : 7);
					continue;
				case 1:
					return enumerable as string;
				}
				break;
			}
		}
	}

	public string GetMsgEnd2(int start)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		object obj = default(object);
		try
		{
			int num = 3;
			IEquatable<string> equatable = default(IEquatable<string>);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					equatable = Split[start - 1];
					num2 = ShowNodes.Ⴄ(Msg, (string)equatable, 28, 35);
					num = ⴐ[367];
					continue;
				case 4:
				case 6:
					num = ((num2 <= 0) ? (ⴐ[252] - 55) : (ⴃႰ[73] - 48542));
					continue;
				case 5:
					obj = Clear.Ⴄ(Msg, num2 + CallBlockCacheCfg.Ⴜ(equatable as string, 306, 339) + 1, 'Ŏ', 'Ŧ');
					goto IL_0185;
				case 1:
				case 2:
				case 7:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ILog ⴐ2 = Ⴐ;
			object obj2 = new string[6];
			(obj2 as string[])[0] = ReplyMail.Ⴅ(0, start, 1217942001);
			((string[])obj2)[1] = Msg;
			((string[])obj2)[2] = ShowWxHelp.Ⴍ('\u0095', 985806101, 8);
			((string[])obj2)[3] = start.ToString();
			(obj2 as string[])[4] = ႰႥ.Ⴅ(2, 'ñ', 952620208);
			((string[])obj2)[5] = SkimmerSpotBins.Ⴈ(ex as Exception, 112, 94);
			ⴐ2.Error(string.Concat(obj2 as string[]));
		}
		switch (4)
		{
		default:
			return string.Empty;
		case 1:
		case 3:
			break;
		}
		goto IL_0185;
		IL_0185:
		return obj as string;
	}

	public string GetLastToken()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		while (true)
		{
			object obj = string.Empty;
			int num = ShowLog.Ⴃ(Ⴅ, ' ', 'Ē', 267);
			int num2 = ⴄႭ[54] - ⴄႭ[275];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႨ[158] - 14715;
					continue;
				case 1:
				case 4:
					break;
				case 2:
				case 3:
					num2 = ((num <= 0) ? 6 : (ⴀ[389] - 31305));
					continue;
				case 0:
				case 7:
					obj = Clear.Ⴄ(Ⴅ, num, 'ǀ', 'Ǩ').Trim();
					num2 = 6;
					continue;
				case 6:
					return (string)obj;
				}
				break;
			}
		}
	}
}
