using System.Collections.Generic;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds;

public sealed class TxNodeUserCmd
{
	private List<string> Ⴅ;

	private string Ⴅ;

	private string Ⴀ;

	private int Ⴍ;

	private string Ⴓ;

	internal static ႳႥ ႤႳ/* Not supported: data(66 4C 3D AA 36 5C 8B 27 BC 77 83 51 AD 09 E0 D3 0D C3 96 81 9A 12 AD 97 FD AA 14 0E 5A 54 FD 10 91 2E 2A 59 5A 89 55 EB 6E AC 58 FA A4 1C 01 7F 5C 6A 1F A9 D0 23 8F E9 72 B2 AC E1 BD E3 53 A5 52 54 96 46 B7 D6 B6 13 BC FB 5D A9 0D B5 07 D4 D1 D8 30 DA B4 F6 E7 2A 04 C2 96 91 1C E8 1A 4B 37 98 34 46 3F DD 3A C9 96 ED FC F1 5F 9B 0D 52 98 8D 34 DD 2D BD 9C CE B2 2D 1D 20 6E 21 5F E1 D8 9D 46 6D 5A 43 66 64 5B 37 A3 40 3F 15 32 85 1B A4 51 B5 83 12 3D D2 A4 03 BC F1 FC BC C5 D8 02 C1 B5 D8 58 51 3D 6C 6C 04 83 1A BB B7 55 62 36 AB AA 84 1D 86 88 1E 2F EC 6F E6 55 A6 B4 B8 C2 B8 54 15 0E 8D BD 54 3B 4E B5 83 BF 13 94 57 F4 30 0C 58 1E 25 45 38 78 DF 20 C9 69 4E DA 9B 38 20 67 E4 9A 0D FC 54 C4 CE 2F B5 F3 DC 55 83 89 B5 04 E1 2F B9 B0 B2 84 BA B6 F6 02 99 AB BD FC 0E CE 59 7B 19 4E EE AE 64 3E 68 89 8A 4C 3D F5 C4 C3 F9 48 3B 5E AC 64 F5 76 7F) */;

	internal static char[] ႤႷ;

	private TalkHelp.Ⴐ Ⴄ;

	public List<string> Msg
	{
		get
		{
			return this.Ⴅ;
		}
		set
		{
			this.Ⴅ = value;
		}
	}

	public string Pcxx
	{
		get
		{
			return Ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	public string Arxx
	{
		get
		{
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	public string NodeXml
	{
		get
		{
			return Ⴄ.Ⴅ;
		}
		set
		{
			Ⴄ.Ⴅ = value as string;
		}
	}

	public string ClientXml
	{
		get
		{
			return Ⴄ.Ⴃ;
		}
		set
		{
			Ⴄ.Ⴃ = value;
		}
	}

	public DxCmdMsgExt DxCmdMsgExt
	{
		get
		{
			return Ⴄ.Ⴐ;
		}
		set
		{
			Ⴄ.Ⴐ = value as DxCmdMsgExt;
			ShowSunHelp.ႣႠ[301] = (char)((ShowSunHelp.ႣႠ[301] - IpLockoutCacheCfg.ႭႭ[239]) & 0x89);
		}
	}

	public DistroType DistroType
	{
		get
		{
			return Ⴄ.Ⴍ;
		}
		set
		{
			Ⴄ.Ⴍ = value;
		}
	}

	public int Id
	{
		get
		{
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			return Ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	public MsgType MsgType
	{
		get
		{
			byte[] ⴅ = SetTalkCountHelp.Ⴅ;
			return Ⴄ.Ⴗ;
		}
		set
		{
			Ⴄ.Ⴗ = value;
			ShowSunHelp.ႣႠ[379] = (char)((ShowSunHelp.ႣႠ[379] | ႨႣ.Ⴐ[335]) & 0x12);
		}
	}

	public string To
	{
		get
		{
			return Ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	public TxNodeUserCmd()
	{
		Msg = new List<string>();
		To = string.Empty;
		DistroType = DistroType.ToNil;
		DxCmdMsgExt = new DxCmdMsgExt();
	}
}
