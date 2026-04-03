using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.ArcCmds;

public sealed class DxCmdMsgExt
{
	internal sealed class ႨႥ
	{
		internal bool Ⴃ;

		internal int Ⴅ;

		internal int Ⴀ;

		internal ႨႥ()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct ႨႳ
	{
		internal string[] Ⴍ;
	}

	private bool Ⴄ;

	private string Ⴄ;

	private string Ⴍ;

	private int Ⴃ;

	private int Ⴗ;

	private string Ⴀ;

	private string Ⴓ;

	private string Ⴜ;

	private string ႤႨ;

	private DirectorySubject.Ⴃ m_ႨႠ = new DirectorySubject.Ⴃ();

	public string ArrlSection
	{
		get
		{
			string ⴅ = this.m_ႨႠ.Ⴅ;
			ShowWwvOptionsHelp.ႣႥ[287] = (char)((ShowWwvOptionsHelp.ႣႥ[287] - ShowQrzHelp.ႤႤ[61]) & 0x38);
			return ⴅ;
		}
		set
		{
			this.m_ႨႠ.Ⴅ = value;
		}
	}

	public bool Lotw
	{
		get
		{
			return this.Ⴄ;
		}
		set
		{
			this.Ⴄ = value;
		}
	}

	public bool Skimmer
	{
		get
		{
			byte[] ⴅ = SetTalkCountHelp.Ⴅ;
			return this.m_ႨႠ.Ⴃ;
		}
		set
		{
			bool ⴃ = value;
			this.m_ႨႠ.Ⴃ = ⴃ;
			IpLockoutCacheCfg.ႭႭ[23] = (char)((IpLockoutCacheCfg.ႭႭ[23] | IpLockoutCacheCfg.ႭႭ[131]) & 0x82);
		}
	}

	public string Cty
	{
		get
		{
			char[] ⴃႰ = SetWxOutput.ႣႰ;
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	public string State
	{
		get
		{
			byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
			return Ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	public string County
	{
		get
		{
			return this.m_ႨႠ.Ⴍ;
		}
		set
		{
			this.m_ႨႠ.Ⴍ = value as string;
		}
	}

	public string Grid
	{
		get
		{
			return this.m_ႨႠ.Ⴄ;
		}
		set
		{
			this.m_ႨႠ.Ⴄ = value;
		}
	}

	public int CqZone
	{
		get
		{
			char[] ⴀ = SetAnnChatRooms.Ⴀ;
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	public int ItuZone
	{
		get
		{
			return Ⴗ;
		}
		set
		{
			Ⴗ = value;
		}
	}

	public string Name
	{
		get
		{
			return this.m_ႨႠ.Ⴓ;
		}
		set
		{
			this.m_ႨႠ.Ⴓ = value as string;
		}
	}

	public string Mode
	{
		get
		{
			return this.m_ႨႠ.Ⴀ;
		}
		set
		{
			this.m_ႨႠ.Ⴀ = value as string;
		}
	}

	public string SpotterCty
	{
		get
		{
			byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	public string SpotterState
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

	public string SpotterCont
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			return Ⴜ;
		}
		set
		{
			Ⴜ = value;
		}
	}

	public string SkimmerQuality
	{
		get
		{
			return ႤႨ;
		}
		set
		{
			ႤႨ = value;
		}
	}

	public DxCmdMsgExt()
	{
		ArrlSection = string.Empty;
		Lotw = false;
		Skimmer = false;
		Cty = string.Empty;
		State = string.Empty;
		County = string.Empty;
		Grid = string.Empty;
		Name = string.Empty;
		Mode = string.Empty;
		SpotterCty = string.Empty;
		SpotterState = string.Empty;
		SpotterCont = string.Empty;
		SkimmerQuality = string.Empty;
	}

	[SecuritySafeCritical]
	internal static void ႨႠ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				break;
			case 0:
			case 8:
				num = (((P_2 ^ P_1) - 101) ^ num2) switch
				{
					0 => ⴃႠ[398] - 15616, 
					_ => 4, 
				};
				break;
			case 4:
				num = 6;
				break;
			case 9:
				Monitor.Exit(P_0);
				goto case 6;
			case 6:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴐ[316] - 29) : 7);
				break;
			case 7:
				num = 8;
				break;
			case 2:
			case 3:
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႨႨ<_0021_00210>(_0021_00210 P_0, byte P_1, short P_2, short P_3) where _0021_00210 : DxSpot
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 4:
			case 7:
				num = (((P_3 ^ P_2) - 7) ^ num2) switch
				{
					0 => ⴄႷ[69] - 16538, 
					_ => 5, 
				};
				break;
			case 5:
				num = 3;
				break;
			case 0:
			case 1:
			case 9:
				P_0.SkimDb = P_1;
				goto case 3;
			case 3:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? ⴄႭ[134] : (ⴀႣ[395] - 44446));
				break;
			case 6:
				num = ⴀ[321] - 31068;
				break;
			case 8:
				return;
			}
		}
	}
}
