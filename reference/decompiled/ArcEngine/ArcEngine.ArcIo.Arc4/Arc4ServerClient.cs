using System;
using System.ComponentModel;
using System.Text;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcIo.Tcp;
using Ⴈ;

namespace ArcEngine.ArcIo.Arc4;

public sealed class Arc4ServerClient : TcpServerClient
{
	internal static ႥႭ ႠႠ/* Not supported: data(75 B5 2B 33 A7 37 40 F5 D4 7E F2 EA BD 8F DF A4 5C 83 7A 37 E6 16 1C 77 67 55 BB CE 06 C8 1D BC E9 1F F9 5B 9D 0C A4 95 FB A2 F3 D0 9B BF C2 CF 72 A7 22 C0 57 40 CD A7 69 7E 25 30 A8 36 B9 A6 1F EA F5 6A 95 36 18 83 B7 FA 7C C5 61 91 18 27 CE 11 9B FB 58 78 9F 94 2F 85 9D BA 8D 76 01 E4 EE C7 29 D1 DA 2B 01 D0 3E 4F 11 C0 EE 3D 80 E4 8F 73 E4 67 CD 4D B0 BE 9A AA EE E7 75 26 37 53 D2 00 2C 70 FB 8C 70 EA 25 98 ED 44 64 C1 6B 5A 96 CA 84 E5 D6 83 5E A7 9B 58 FC 2A 93 4A D4 EC 94 49 54 5C DE DF 3E AD 4B 04 A6 66 7B 57 0E 2A 06 2D 13 52 89 0F D3 92 AE 77 AF D2 7C 7C DE 29 25 D5 20 25 CD 93 03 15 A1 2D 1B 8C DB 4B 00 83 C4 0F 6D D1 6A 05 B9 69 3B 3C 8E 96 E5 8B 93 48 51 1D F8 60 1B 75 46 4E 10 08 36 79 EB 4E 2A 9A B0 18 ED 62 6A BD 11 46 64 35 91 2E BC E2 E5 F7 07 69 F7 59 37 D2 7A 33 2E 97 8F 35 32 BF 77 BD 78 10 DD 5C 79 9D DD 32 3B 61 C1 ED D1 ED 76 96 2D C6 F4 C6 82 75 B6 16 94 5D 36 2E CD 21 EF 5B 34 D6 A1 F9 51 FC B3 CA B0 CE CA 05 9B 4D 32 E1 AF EE 83 0D B1 00 43 E2 55 C4 6A 58 64 B1 C0 E7 C4 A1 A2 B7 CD 3D 31 AB BB DB 0E 1C EF 38 EE 2A 1A 75 F3 26 E3 7F 6F 6E 0E B9 06 CC 51 9A D0 3A 29 38 48 76 45 5D 8B 9D 3D 39 7E F4 C6 EE AE 0A 42 0F 46 BC 2C 44 B7 53 0F ED 8E 0B 20 D2 C2 6D 90 15 C1 8D F1 74 F0 A5 68 F0 9A 76 32 80 25 BA B1 C0 63 D1 99 55 BD A7 E5 85 2B DF 23 28 A9 22 31 73 E0 C5 19 AA 0D 4E 24 FB D8 13 83 AE 45 AD DB C8 1E 33 EF 9B 75 1F E0 D7 37 E5 DE 3D 8B 69 D2 54 20 12 DF 58 4D 2B 14 57 5F F4 66 4A 8D C1 14 F6 1E A3 D9 DC D8 67 E4 9E 08 47 C8 84 15 30 22 94 83 21 85 E0 2E 27 74 61 12 84 9D 72 B7 01 3D DF AA C7 14 DD 49 BD AA DA BD 60 43 E2 79 DB 84 93 0D EC EB 52 C4 73 4C 86 D5 FC 93 CB D0 7E 79 7B 8A E8 F8 57 05 58 FE 36 AA 46 60 0E D2 81 55 AE DA 6B 51 8B 5D B6 B1 04 AF 16 16 08 BE D0 82 9F 27 57 0F 4C 69 8F 4B 17 1B 8D E2 E6 56 95 DA C0 5F 01 53 D4 D6 B2 1C F4 03 11 C8 A9 4B 97 EE 55 B4 61 B3 AB E8 78 19 2C 97 1A B7 CA 92 98 4A B9 41 5B F4 0E D0 6E 6B D5 E5 2B C7 D6 D5 7C F6 E3 2B 82 40 D4 24 2F C6 B0 2A 3C 85 67 5D EE A8 01 A0 C2 2A 97 9E 35 55 72 89 5B B5 8D 51 9D 11 C2 04 F4 6F 60 FC A2 FB 6A 2D 8F A4 A4 EB 84 6E 8C 7B B3 1E D6 08 BC 27 7E 12 78 EA BF F4 94 97 2A 7D 57 DF CE F0 71 C1 3C A3 7A 84 E6 C4 19 2E FA 55 BD 40 77 77 69 6C 83 19 95 3D 26 C0 5D 8B CD A1 71 BE AC 65 E1 75 CB CB 33 D9 11 C8 54 85 DD 55 4F B5 A2 4A FD 0B 66 7B AB 35 70 95 89 B6 02 36 02 07 0B D7 1A A8 8C C4 1B 8F 60 6D 47 80 0D AB 46 CD A8 A4 AD ED 17 2C 3B 7E 01 54 F7 3E 8D 5D 78 7C EE 85 0C 53 CB 83 DE 7D C9 CA F6 A3 45 16 7A 69 94 6B ED ED D7 39 E9 B7 B3 B2 4E 1F 4D AA ED C1 66 35 81 11 8A 65 0B 17 D1 C6 B1 12 11 50 65 E5 D3 CA 84 FD 8A 34 64 DB 3C 58 A2) */;

	internal static char[] ႠႣ;

	private SkimmerServerData.Ⴜ Ⴃ;

	[Browsable(false)]
	public string ToCall
	{
		get
		{
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			return Ⴃ.Ⴍ;
		}
		set
		{
			Ⴃ.Ⴍ = value as string;
		}
	}

	public override bool Send(string msg)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		object obj2 = default(object);
		IEquatable<string> equatable = default(IEquatable<string>);
		object obj = default(object);
		Array array = default(Array);
		while (true)
		{
			int num = ((ToCall != null) ? ⴐ[21] : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2:
					break;
				case 3:
					base.LastSendDts = ShowAnnHelp.Ⴅ('ϒ', 995);
					msg = ShowUsersHelp.Ⴅ(msg, SetStationClubHelp.Ⴍ(3, 5, 1747258082, null), 388, 458);
					num = 14;
					continue;
				case 14:
					obj2 = new string[5];
					((string[])obj2)[0] = ႰႥ.Ⴅ(5, 'j', 952621539);
					num = 13;
					continue;
				case 13:
					(obj2 as string[])[1] = ToCall;
					(obj2 as string[])[2] = SetStationQth.Ⴍ(null, 1687351530, 5, 1);
					goto case 12;
				case 12:
					num = 6;
					continue;
				case 6:
					((string[])obj2)[3] = ObjectManager.Instance.Ⴃ();
					((string[])obj2)[4] = SetStationQth.Ⴍ(null, 1687351532, 3, 13);
					num = ⴀႣ[259] - 48453;
					continue;
				case 4:
					equatable = ShowWwv.Ⴈ((string[])obj2, 'â', 138);
					obj = equatable as string;
					num = 10;
					continue;
				case 10:
					array = new object[4];
					goto case 5;
				case 5:
					((object[])array)[0] = obj;
					((object[])array)[1] = CallBlockCacheCfg.Ⴜ(msg, 761, 664);
					num = ⴃႠ[369] - 15021;
					continue;
				case 1:
					((object[])array)[2] = SetStationQth.Ⴍ(null, 1687351530, 5, 6);
					num = 7;
					continue;
				case 7:
					(array as object[])[3] = V4NodeParser.GetInstance.Parse(ToCall, msg);
					equatable = SetDxDefaultHelp.Ⴍ(array as object[], 'ʝ', 756);
					num = 11;
					continue;
				case 11:
				{
					Array bytes = Encoding.ASCII.GetBytes(equatable as string);
					return HostTcpServer.Send(Socket, bytes as byte[]);
				}
				case 0:
					return true;
				}
				break;
			}
		}
	}
}
