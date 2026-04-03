using System.Collections.Generic;
using System.Reflection;
using System.Security;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Filters;
using Ⴀ;

namespace ArcClientEngine.ArcObjs;

public sealed class DxCommentExtCfg
{
	internal sealed class ႤႠ
	{
		internal int Ⴍ;

		internal ႤႠ()
		{
		}
	}

	internal sealed class ႤႭ
	{
		internal string Ⴈ;

		internal string Ⴅ;

		internal string Ⴀ;

		internal string Ⴍ;

		internal string Ⴗ;

		internal string Ⴃ;

		internal string Ⴓ;

		internal string Ⴐ;

		internal string Ⴄ;

		internal string Ⴜ;

		internal ႤႭ()
		{
		}
	}

	internal sealed class ႤႼ
	{
		internal List<DxFilter> Ⴅ;

		internal string Ⴄ;

		internal string Ⴗ;

		internal ႤႼ()
		{
		}
	}

	private bool Ⴄ;

	private bool Ⴗ;

	private bool Ⴈ;

	private bool Ⴐ;

	private bool Ⴍ;

	private bool Ⴜ;

	private bool ႤႷ;

	private bool ႤႨ;

	private bool ႤႣ;

	private bool ႤႳ;

	private ႥႤ.Ⴐ ႭႥ;

	public bool CqZone
	{
		get
		{
			char[] ⴗ = ႥႰ.Ⴗ;
			return ႭႥ.Ⴈ;
		}
		set
		{
			bool ⴈ = value;
			ႭႥ.Ⴈ = ⴈ;
		}
	}

	public bool Cty
	{
		get
		{
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	public bool State
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

	public bool Loc
	{
		get
		{
			return Ⴈ;
		}
		set
		{
			Ⴈ = value;
		}
	}

	public bool County
	{
		get
		{
			return ႭႥ.Ⴗ;
		}
		set
		{
			bool ⴗ = value;
			ႭႥ.Ⴗ = ⴗ;
		}
	}

	public bool Grid
	{
		get
		{
			char[] ⴗ = ႥႰ.Ⴗ;
			return ႭႥ.Ⴄ;
		}
		set
		{
			bool ⴄ = value;
			ႭႥ.Ⴄ = ⴄ;
		}
	}

	public bool ItuZone
	{
		get
		{
			return Ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	public bool Lotw
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return Ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	public bool Name
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return ႭႥ.Ⴀ;
		}
		set
		{
			bool ⴀ = value;
			ႭႥ.Ⴀ = ⴀ;
		}
	}

	public bool Section
	{
		get
		{
			return Ⴜ;
		}
		set
		{
			Ⴜ = value;
		}
	}

	public bool SpotterCty
	{
		get
		{
			bool ⴓ = ႭႥ.Ⴓ;
			ႥႰ.Ⴗ[112] = (char)((ႥႰ.Ⴗ[112] + ႥႰ.Ⴗ[103]) & 0xD);
			return ⴓ;
		}
		set
		{
			bool ⴓ = value;
			ႭႥ.Ⴓ = ⴓ;
			Bye.Ⴄ[81] = (char)((Bye.Ⴄ[81] - Bye.Ⴄ[219]) & 0x68);
		}
	}

	public bool SpotterState
	{
		get
		{
			bool ⴐ = ႭႥ.Ⴐ;
			ႥႰ.Ⴗ[17] = (char)((ႥႰ.Ⴗ[17] * UserCmd.Ⴅ[378]) & 0x38);
			return ⴐ;
		}
		set
		{
			bool ⴐ = value;
			ႭႥ.Ⴐ = ⴐ;
		}
	}

	public bool SpotterLoc
	{
		get
		{
			byte[] ⴅ = UserCmd.Ⴅ;
			bool ⴄႷ = ႤႷ;
			Bye.Ⴄ[76] = (char)((Bye.Ⴄ[76] ^ ႥႰ.Ⴗ[11]) & 0x32);
			return ⴄႷ;
		}
		set
		{
			ႤႷ = value;
		}
	}

	public bool SpotterCont
	{
		get
		{
			byte[] ⴅ = UserCmd.Ⴅ;
			return ႤႨ;
		}
		set
		{
			ႤႨ = value;
		}
	}

	public bool SkimmerQuality
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return ႤႣ;
		}
		set
		{
			ႤႣ = value;
		}
	}

	public bool Eos
	{
		get
		{
			bool ⴄႳ = ႤႳ;
			UserCmd.Ⴅ[21] = (byte)((UserCmd.Ⴅ[21] | UserCmd.Ⴅ[206]) & 0xBD);
			return ⴄႳ;
		}
		set
		{
			ႤႳ = value;
		}
	}

	[SecuritySafeCritical]
	static DxCommentExtCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static bool ႤႰ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[45] - 14536;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 6;
					continue;
				case 6:
					break;
				case 1:
					num2 = (((P_3 ^ P_2) - 37) ^ num) switch
					{
						0 => ⴅ[409] - ⴅ[117], 
						1 => ⴗ[161] - 4999, 
						_ => 3, 
					};
					continue;
				case 3:
					result = true;
					num2 = ⴗ[90] - 35262;
					continue;
				case 7:
					result = P_0.Contains(P_1);
					num2 = 2;
					continue;
				case 0:
					result = P_0 == P_1;
					num2 = ⴗ[21] - 63707;
					continue;
				case 2:
				case 9:
				{
					num++;
					int num3 = 540;
					int num4 = 26;
					num2 = ((180 < num3 / 3 - num4) ? (ⴀႠ[122] - 49009) : ⴅ[102]);
					continue;
				}
				case 5:
				case 10:
					return result;
				case 11:
					num2 = ⴀႠ[31] - 4541;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string[] ႠႰ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : Assembly
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႠ[117] - 64733;
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
				case 2:
				{
					int num5;
					switch (((P_2 ^ P_1) - 100) ^ num)
					{
					default:
						num5 = 8;
						break;
					case 0:
					{
						char num4 = ⴀႠ[10];
						UserCmd.Ⴅ[361] = (byte)((UserCmd.Ⴅ[361] ^ UserCmd.Ⴅ[134]) & 0x9D);
						num5 = num4 - 7241;
						break;
					}
					}
					num2 = num5;
					continue;
				}
				case 8:
					obj = null;
					num2 = 7;
					continue;
				case 5:
					obj = P_0.GetManifestResourceNames();
					num2 = 7;
					continue;
				case 7:
					num++;
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					goto case 10;
				case 10:
					num2 = ⴀႠ[94] - 21822;
					continue;
				case 3:
				case 6:
					num2 = ((num3 % 2 != 0) ? (ⴗ[111] - 41311) : 4);
					continue;
				case 4:
					return obj as string[];
				case 1:
				case 9:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}
}
