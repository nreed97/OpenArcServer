using System;
using System.ComponentModel;
using System.Security;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using Ⴀ;

namespace ArcClientEngine.ArcCfg;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class FilterCfg
{
	internal sealed class Ⴐ
	{
		internal int Ⴅ;

		internal int Ⴐ;

		internal ArcClientObjMgr Ⴀ;

		internal Ⴐ()
		{
		}
	}

	private AnnFilters m_Ⴄ;

	private WxFilters Ⴗ;

	private ႳႥ.ႥႳ m_Ⴓ = new ႳႥ.ႥႳ();

	[Description("DX Filter")]
	[ReadOnly(true)]
	public DxFilters Dx
	{
		get
		{
			return this.m_Ⴓ.Ⴅ;
		}
		set
		{
			this.m_Ⴓ.Ⴅ = value;
		}
	}

	[Description("Ann Filter")]
	[ReadOnly(true)]
	public AnnFilters Ann
	{
		get
		{
			return this.m_Ⴄ;
		}
		set
		{
			this.m_Ⴄ = value;
		}
	}

	[ReadOnly(true)]
	[Description("Ann Filter")]
	public WxFilters Wx
	{
		get
		{
			WxFilters ⴗ = Ⴗ;
			Bye.Ⴄ[182] = (char)((Bye.Ⴄ[182] ^ Bye.Ⴄ[57]) & 0x12);
			return ⴗ;
		}
		set
		{
			Ⴗ = value;
		}
	}

	public FilterCfg()
	{
		Dx = new DxFilters();
		Ann = new AnnFilters();
		Wx = new WxFilters();
	}

	public override string ToString()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		return WxFilters.Ⴀ(null, 1, 103387643);
	}

	internal void Ⴄ()
	{
		Dx.Ⴗ();
		Ann.Ⴈ();
		Wx.Ⴐ();
	}

	[SecuritySafeCritical]
	static FilterCfg()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : Exception
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[406] - 197;
					continue;
				case 6:
					break;
				case 8:
					num2 = (((P_1 ^ P_2) - 14) ^ num) switch
					{
						0 => 2, 
						_ => 5, 
					};
					continue;
				case 5:
					equatable = null;
					num2 = 10;
					continue;
				case 0:
				case 2:
				case 7:
					equatable = P_0.Message;
					num2 = 10;
					continue;
				case 10:
				{
					num++;
					int num3 = 3732;
					int num4 = 179;
					num2 = ((933 < num3 / 4 - num4) ? 8 : 9);
					continue;
				}
				case 3:
				case 9:
					return (string)equatable;
				case 1:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴈ<_0021_00210>(_0021_00210 P_0, object[] P_1, short P_2, int P_3) where _0021_00210 : Delegate
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		object result = default(object);
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
					num2 = ⴄ[179] - 31347;
					continue;
				case 5:
					break;
				case 3:
				case 4:
					num2 = (((P_3 ^ P_2) - 10) ^ num) switch
					{
						0 => 6, 
						_ => 8, 
					};
					continue;
				case 8:
					result = null;
					num2 = ⴗ[103] - 55680;
					continue;
				case 6:
					result = P_0.DynamicInvoke(P_1);
					num2 = ⴄ[101] - 33638;
					continue;
				case 0:
				case 11:
					num++;
					goto case 2;
				case 2:
				{
					num3 = P_2 * P_2;
					int num4 = num3;
					ႥႰ.Ⴗ[73] = (char)((ႥႰ.Ⴗ[73] + P_2) & 0xC2);
					num3 = P_2 + num4;
					num2 = ⴅ[115] + 5;
					continue;
				}
				case 9:
					num2 = ((num3 % 2 != 0) ? 4 : 10);
					continue;
				case 10:
					return result;
				case 1:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		IComparable comparable = default(IComparable);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[206] - 7504;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[373] - 28;
					continue;
				case 3:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 110) ^ num) switch
					{
						0 => 11, 
						_ => ⴄ[275] - 45767, 
					};
					continue;
				case 2:
					comparable = null;
					goto case 5;
				case 5:
				case 6:
					num2 = ⴅ[17];
					continue;
				case 11:
					comparable = P_0.ToString();
					num2 = 0;
					continue;
				case 0:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 1 : 7);
					continue;
				case 7:
					num2 = 8;
					continue;
				case 1:
					return comparable as string;
				case 4:
				case 10:
					num2 = ⴗ[85] - 18006;
					continue;
				}
				break;
			}
		}
	}
}
