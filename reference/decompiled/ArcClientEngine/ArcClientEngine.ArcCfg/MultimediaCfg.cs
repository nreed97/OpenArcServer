using System.ComponentModel;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcShared.ArcUtils;
using Ⴀ;

namespace ArcClientEngine.ArcCfg;

public sealed class MultimediaCfg
{
	internal sealed class Ⴍ
	{
		internal string Ⴍ;

		internal Ⴍ()
		{
		}
	}

	internal sealed class Ⴀ
	{
		internal IContainer Ⴐ;

		internal DataGridView Ⴓ;

		internal ArcClientObjMgr Ⴍ;

		internal BindingSource Ⴀ;

		internal Ⴀ()
		{
		}
	}

	private string Ⴃ;

	private string m_Ⴐ;

	private HighlightItuZoneCfg.ႳႰ m_Ⴍ = new HighlightItuZoneCfg.ႳႰ();

	[Description("TBD")]
	public bool Alert
	{
		get
		{
			return this.m_Ⴍ.Ⴐ;
		}
		set
		{
			bool ⴐ = value;
			this.m_Ⴍ.Ⴐ = ⴐ;
		}
	}

	[Description("TBD")]
	public bool FullAnnounce
	{
		get
		{
			byte[] ⴅ = UserCmd.Ⴅ;
			return this.m_Ⴍ.Ⴓ;
		}
		set
		{
			bool ⴓ = value;
			this.m_Ⴍ.Ⴓ = ⴓ;
		}
	}

	[Description("TBD")]
	public string AlertFile
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

	[Description("Multimedia DX filter name")]
	public string MultimediaFilterName
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return this.m_Ⴍ.Ⴍ;
		}
		set
		{
			this.m_Ⴍ.Ⴍ = value as string;
		}
	}

	[Description("Multimedia DX filter")]
	public string MultimediaFilter
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			string ⴐ = this.m_Ⴐ;
			UserCmd.Ⴅ[201] = (byte)((UserCmd.Ⴅ[201] + UserCmd.Ⴅ[400]) & 0x9C);
			return ⴐ;
		}
		set
		{
			this.m_Ⴐ = value;
		}
	}

	public MultimediaCfg()
	{
		AlertFile = string.Empty;
		MultimediaFilterName = string.Empty;
		MultimediaFilter = string.Empty;
	}

	internal void Ⴐ()
	{
		AlertFile = WxFilters.Ⴀ(null, 3, 103388526);
	}

	[SecuritySafeCritical]
	static MultimediaCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : PrecisionTimer
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 7;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴅ[285];
				break;
			case 5:
				num = (((P_2 ^ P_1) - 42) ^ num2) switch
				{
					0 => 9, 
					_ => 2, 
				};
				break;
			case 2:
				num = ⴗ[156] - 48829;
				break;
			case 9:
				P_0.Start();
				goto case 1;
			case 1:
			case 6:
				num2++;
				num3 = 643;
				goto case 8;
			case 8:
			{
				int num4 = 904;
				num = ((4520 > num4 - num3 * 5) ? (ⴀႠ[20] - 33396) : (ⴗ[152] - 32163));
				break;
			}
			case 0:
			case 3:
				num = 5;
				break;
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : PrecisionTimer
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 7;
		int num6 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num6 = 0;
				num = 6;
				break;
			case 6:
				num = (((P_1 ^ P_2) - 33) ^ num6) switch
				{
					0 => 4, 
					_ => ⴗ[130] - 30824, 
				};
				break;
			case 0:
			case 8:
				num = 3;
				break;
			case 4:
			case 5:
				P_0.Stop();
				goto case 3;
			case 3:
				num6++;
				num3 = 1510;
				goto case 1;
			case 1:
			{
				int num7 = num3;
				num5 = num7 * num7;
				num = 9;
				break;
			}
			case 9:
			{
				int num2 = num3;
				int num4 = num5;
				ႥႰ.Ⴗ[18] = (char)((ႥႰ.Ⴗ[18] - P_2) & 0x91);
				num5 = num2 + num4;
				num = ((num5 % 2 != 0) ? 6 : (ⴄ[269] - 37547));
				break;
			}
			case 2:
				return;
			}
		}
	}
}
