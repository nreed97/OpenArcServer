using System.Collections.Generic;
using System.ComponentModel;
using System.Security;
using System.Text.RegularExpressions;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;

namespace ArcEngine.ArcServerConfig;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class HamQthCfg
{
	private string Ⴀ;

	private ShowWx.Ⴀ m_Ⴅ = new ShowWx.Ⴀ();

	[Description("HamQth.com callsign")]
	public string Callsign
	{
		get
		{
			return this.m_Ⴅ.Ⴈ;
		}
		set
		{
			this.m_Ⴅ.Ⴈ = value as string;
		}
	}

	[Description("HamQth.com password")]
	public string Password
	{
		get
		{
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	[Description("URL")]
	public string Url
	{
		get
		{
			byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
			return this.m_Ⴅ.Ⴓ;
		}
		set
		{
			this.m_Ⴅ.Ⴓ = value as string;
		}
	}

	public HamQthCfg()
	{
		Callsign = string.Empty;
		Password = string.Empty;
		Url = CallBlockCacheCfg.Ⴅ(null, 3, 62062191, null);
	}

	public override string ToString()
	{
		return CallBlockCacheCfg.Ⴅ(null, 6, 62062091, null);
	}

	[SecuritySafeCritical]
	internal static bool Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DxCommentExtCfg
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႥ[347] - 38508;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 65) ^ num) switch
					{
						0 => 7, 
						1 => ⴀႨ[27] - 10516, 
						_ => ⴀႳ[249] - ⴀႳ[249], 
					};
					continue;
				case 0:
					result = false;
					goto case 5;
				case 5:
					num2 = 11;
					continue;
				case 7:
					result = P_0.Lotw;
					goto case 10;
				case 10:
					num2 = 11;
					continue;
				case 4:
					result = P_0.Grid;
					num2 = ⴀႳ[108] - 41957;
					continue;
				case 11:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 9 : 8);
					continue;
				case 6:
				case 8:
					num2 = ⴍႤ[427] - 18765;
					continue;
				case 9:
					return result;
				case 12:
					num2 = ⴍႤ[157] - 37358;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴅ<_0021_00210, _0021_00211, _0021_00212>(_0021_00210 P_0, _0021_00212 P_1, _0021_00211 P_2, RegexOptions P_3, char P_4, int P_5) where _0021_00210 : string where _0021_00211 : string where _0021_00212 : string
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႰ[58] - 19220;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႼ[100] - 9;
					continue;
				case 9:
					break;
				case 4:
					num2 = (((P_5 ^ P_4) - 24) ^ num) switch
					{
						0 => 0, 
						_ => ⴃႰ[108] - 48230, 
					};
					continue;
				case 1:
				case 2:
				case 8:
					enumerable = null;
					num2 = 3;
					continue;
				case 0:
					enumerable = Regex.Replace(P_0, P_1, P_2, P_3);
					num2 = 3;
					continue;
				case 3:
					num++;
					num2 = (((P_4 * P_4 + P_4) % 2 == 0) ? (ⴍႤ[359] - 6544) : 5);
					continue;
				case 5:
				case 7:
					num2 = ⴄႤ[329] - ⴄႤ[122];
					continue;
				case 10:
					return (string)enumerable;
				case 11:
					num2 = ⴀႼ[96];
					continue;
				}
				break;
			}
		}
	}
}
