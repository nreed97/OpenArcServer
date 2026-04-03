using System.Data.Common;
using System.Security;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;

namespace ArcEngine.ArcCmds.NodeProcessor;

public sealed class NodeCmdCfg
{
	private ShowWx.Ⴀ Ⴃ = new ShowWx.Ⴀ();

	public string Key
	{
		get
		{
			return Ⴃ.Ⴈ;
		}
		set
		{
			Ⴃ.Ⴈ = value;
		}
	}

	public string CodeName
	{
		get
		{
			string ⴓ = Ⴃ.Ⴓ;
			SetWxOutput.ႣႰ[62] = (char)((SetWxOutput.ႣႰ[62] * TxNodeUserCmd.ႤႷ[22]) & 0x37);
			return ⴓ;
		}
		set
		{
			Ⴃ.Ⴓ = value as string;
		}
	}

	public NodeCmdCfg()
	{
	}

	public NodeCmdCfg(string key, string codeName)
	{
		Key = key;
		CodeName = codeName;
	}

	[SecuritySafeCritical]
	internal static TalkCfg Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : ArcUserCfg
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		object obj = default(object);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 10;
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
				case 10:
					num2 = (((P_2 ^ P_1) - 74) ^ num) switch
					{
						0 => ⴃႰ[95] - 17659, 
						_ => 7, 
					};
					continue;
				case 7:
					obj = null;
					num2 = 9;
					continue;
				case 4:
					obj = P_0.Talk;
					num2 = 9;
					continue;
				case 5:
				case 9:
					num++;
					num4 = 1112;
					goto case 8;
				case 8:
				{
					int num5 = num4;
					num3 = num5 * num5;
					num2 = ⴍႤ[395] - 14305;
					continue;
				}
				case 1:
				case 3:
					num3 = num4 + num3;
					num2 = ((num3 % 2 != 0) ? 10 : (ⴀႳ[344] - 9713));
					continue;
				case 2:
					return obj as TalkCfg;
				case 11:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DbParameter
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		object result = default(object);
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 0:
					num2 = (((P_2 ^ P_1) - 108) ^ num) switch
					{
						0 => 8, 
						_ => 5, 
					};
					continue;
				case 5:
					result = null;
					goto case 2;
				case 2:
					num2 = 6;
					continue;
				case 8:
					result = P_0.Value;
					num2 = 6;
					continue;
				case 3:
				case 6:
				{
					num++;
					int num3 = 385;
					int num4 = 639;
					num2 = ((1917 > num4 - num3 * 3) ? 7 : 11);
					continue;
				}
				case 9:
				case 11:
					num2 = ⴀႨ[167] - 4920;
					continue;
				case 7:
					return result;
				case 1:
					num2 = ⴀႳ[70] - 20220;
					continue;
				}
				break;
			}
		}
	}
}
