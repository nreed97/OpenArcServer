using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class SkimmerServerData
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴜ
	{
		internal string Ⴍ;
	}

	public string Call;

	public long[] TotalCnt;

	public long[] UnknownCnt;

	public long[] ValidCnt;

	public long[] QsyCnt;

	public long[] BustedCnt;

	public float FreqQsyCnt;

	public override string ToString()
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		object obj = default(object);
		while (true)
		{
			FreqQsyCnt = Ⴓ();
			float num = Ⴓ();
			int num2 = ((!SetAnnCount.Ⴍ(num, 594, 'ɯ')) ? (ⴀႳ[22] - 54448) : 5);
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႠ[343] - 59177;
					continue;
				case 7:
					break;
				case 5:
					num = 0f;
					num2 = ⴄႷ[141] - 32624;
					continue;
				case 1:
				case 6:
					obj = new string[12];
					((string[])obj)[0] = ShowAnnHelp.Ⴀ(Call, 13, 19, 69);
					num2 = ⴄႤ[392] - 159;
					continue;
				case 2:
					((string[])obj)[1] = ShowDxOptionsHelp.Ⴅ(ref num, ႨႨ.Ⴀ(0, 3, 1157904479), 443, 'ƹ');
					goto case 9;
				case 9:
					num2 = ⴄႭ[66];
					continue;
				case 0:
					(obj as string[])[2] = ShowSkimCtyHelp.Ⴍ(1216132360, 4, 'Ö');
					((string[])obj)[3] = Ⴈ().ToString();
					num2 = ⴄႷ[7] - 54229;
					continue;
				case 11:
					(obj as string[])[4] = ShowSkimCtyHelp.Ⴍ(1216132365, 1, '.');
					((string[])obj)[5] = Ⴄ().ToString();
					num2 = 3;
					continue;
				case 3:
					((string[])obj)[6] = ShowSkimCtyHelp.Ⴍ(1216132363, 7, '=');
					(obj as string[])[7] = Ⴅ().ToString();
					num2 = 4;
					continue;
				case 4:
					((string[])obj)[8] = ShowSkimCtyHelp.Ⴍ(1216132361, 5, '{');
					((string[])obj)[9] = Ⴗ().ToString();
					goto case 8;
				case 8:
					num2 = 10;
					continue;
				case 10:
					((string[])obj)[10] = ShowSkimCtyHelp.Ⴍ(1216132367, 3, ',');
					(obj as string[])[11] = Ⴀ().ToString();
					num2 = 12;
					continue;
				case 12:
					return string.Concat((string[])obj);
				}
				break;
			}
		}
	}

	[SpecialName]
	private long Ⴈ()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		return TotalCnt[0] + TotalCnt[1] + TotalCnt[2] + TotalCnt[3] + TotalCnt[4] + TotalCnt[5];
	}

	[SpecialName]
	private long Ⴄ()
	{
		return UnknownCnt[0] + UnknownCnt[1] + UnknownCnt[2] + UnknownCnt[3] + UnknownCnt[4] + UnknownCnt[5];
	}

	[SpecialName]
	private long Ⴅ()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		return ValidCnt[0] + ValidCnt[1] + ValidCnt[2] + ValidCnt[3] + ValidCnt[4] + ValidCnt[5];
	}

	[SpecialName]
	private long Ⴗ()
	{
		return QsyCnt[0] + QsyCnt[1] + QsyCnt[2] + QsyCnt[3] + QsyCnt[4] + QsyCnt[5];
	}

	[SpecialName]
	private long Ⴀ()
	{
		long num = BustedCnt[0] + BustedCnt[1] + BustedCnt[2] + BustedCnt[3];
		long num2 = BustedCnt[4];
		SetAnnChatRooms.Ⴀ[222] = (char)((SetAnnChatRooms.Ⴀ[222] - SetAnnChatRooms.Ⴀ[425]) & 0x7B);
		return num + num2 + BustedCnt[5];
	}

	[SpecialName]
	internal float Ⴓ()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		while (true)
		{
			float result = (float)Ⴗ() / (float)Ⴈ() * 100f;
			while (true)
			{
				IL_0052:
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႥ[216] - 63048;
						continue;
					case 3:
						break;
					case 5:
						goto IL_0052;
					case 2:
					case 4:
						return result;
					}
					break;
				}
				break;
			}
		}
	}

	internal SkimmerServerData()
	{
		object obj = new long[6];
		TotalCnt = obj as long[];
		Array array = new long[6];
		UnknownCnt = array as long[];
		object obj2 = new long[6];
		ValidCnt = obj2 as long[];
		object obj3 = new long[6];
		QsyCnt = (long[])obj3;
		object obj4 = new long[6];
		BustedCnt = (long[])obj4;
	}

	internal SkimmerServerData(SkimmerCt1bohCache.SkimmerQualityType P_0)
		: this()
	{
		Ⴍ(P_0);
	}

	internal void Ⴍ(SkimmerCt1bohCache.SkimmerQualityType P_0)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				TotalCnt[0]++;
				goto case 4;
			case 4:
				num = 2;
				break;
			case 2:
				switch (P_0)
				{
				default:
					num = 0;
					break;
				case SkimmerCt1bohCache.SkimmerQualityType.Unknown:
					UnknownCnt[0]++;
					return;
				case SkimmerCt1bohCache.SkimmerQualityType.Busted:
					BustedCnt[0]++;
					return;
				case SkimmerCt1bohCache.SkimmerQualityType.Valid:
					ValidCnt[0]++;
					return;
				case SkimmerCt1bohCache.SkimmerQualityType.Qsy:
					QsyCnt[0]++;
					return;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal void Ⴐ()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 5;
				num = 5;
				break;
			case 4:
				TotalCnt[num2] = TotalCnt[num2 - 1];
				num = ⴀႼ[31] - 118;
				break;
			case 11:
				UnknownCnt[num2] = UnknownCnt[num2 - 1];
				num = 8;
				break;
			case 8:
			{
				ValidCnt[num2] = ValidCnt[num2 - 1];
				int num3 = ⴀႨ[216];
				IpLockoutCacheCfg.ႭႭ[186] = (char)((IpLockoutCacheCfg.ႭႭ[186] - IpLockoutCacheCfg.ႭႭ[299]) & 0xA9);
				num = num3 - 59543;
				break;
			}
			case 10:
			case 12:
				QsyCnt[num2] = QsyCnt[num2 - 1];
				num = 2;
				break;
			case 2:
				BustedCnt[num2] = BustedCnt[num2 - 1];
				num = 1;
				break;
			case 1:
			case 13:
				num2--;
				num = 5;
				break;
			case 5:
				num = ((num2 > 0) ? (ⴄႷ[28] - 45678) : 0);
				break;
			case 0:
				TotalCnt[0] = 0L;
				UnknownCnt[0] = 0L;
				num = 3;
				break;
			case 3:
				ValidCnt[0] = 0L;
				QsyCnt[0] = 0L;
				num = 6;
				break;
			case 6:
			case 9:
				BustedCnt[0] = 0L;
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static char[] Ⴃ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		Array array = default(Array);
		int num3 = default(int);
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
					num2 = ⴐ[257];
					continue;
				case 7:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 76) ^ num) switch
					{
						0 => 4, 
						_ => 10, 
					};
					continue;
				case 10:
					array = null;
					num2 = 11;
					continue;
				case 4:
				case 5:
					array = P_0.ToCharArray();
					num2 = 11;
					continue;
				case 6:
				case 11:
					num++;
					num3 = P_1 * P_1;
					goto case 3;
				case 3:
					num3 = P_1 + num3;
					num2 = ⴐ[356] - 218;
					continue;
				case 9:
					num2 = ((num3 % 2 == 0) ? (ⴀႣ[346] - 54813) : 0);
					continue;
				case 1:
					return array as char[];
				case 8:
					num2 = ⴀႨ[86] - ⴀႨ[86];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႷႳ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : string
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 1;
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
				case 0:
				case 1:
					num2 = (((P_2 ^ P_1) - 52) ^ num) switch
					{
						0 => ⴄႤ[273] - 235, 
						_ => 5, 
					};
					continue;
				case 5:
					obj = null;
					num2 = 9;
					continue;
				case 3:
					obj = CtyInfo.ScrubInfo(P_0);
					num2 = 9;
					continue;
				case 9:
				{
					num++;
					int num3 = 903;
					int num4 = 225;
					Arc4ServerClient.ႠႣ[256] = (char)((Arc4ServerClient.ႠႣ[256] - P_2) & 0x42);
					num2 = ((301 < num3 / 3 - num4) ? (ⴍႤ[336] - 43924) : 8);
					continue;
				}
				case 2:
				case 6:
				case 8:
					return obj as string;
				case 10:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}
}
