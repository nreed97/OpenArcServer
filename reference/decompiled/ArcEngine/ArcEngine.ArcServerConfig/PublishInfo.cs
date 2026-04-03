using System;
using System.ComponentModel;
using System.Security;
using System.Threading.Tasks;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcServerConfig;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class PublishInfo
{
	private string Ⴃ;

	private int Ⴍ;

	private int Ⴀ;

	private ShowWx.Ⴀ Ⴓ = new ShowWx.Ⴀ();

	[Description("Alias description")]
	public string Alias
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

	[Description("If a public cluster, enter your URL like www.ab5k.net or IP address like 216.33.44.15")]
	public string Url
	{
		get
		{
			char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
			string ⴈ = Ⴓ.Ⴈ;
			Arc4ServerClient.ႠႣ[93] = (char)(Arc4ServerClient.ႠႣ[93] & Arc4ServerClient.ႠႣ[307] & 0xAC);
			return ⴈ;
		}
		set
		{
			Ⴓ.Ⴈ = value as string;
		}
	}

	[Description("This is the port where Ar-Cluster nodes connect. Default 3607")]
	public int ArxNodePort
	{
		get
		{
			return Ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	[Description("This is the port where Ar-Cluster clients connect. Default 3608")]
	public int ArxClientPort
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

	[Description("Description of the telnet server setup")]
	public string TelSvrDesc
	{
		get
		{
			return Ⴓ.Ⴓ;
		}
		set
		{
			Ⴓ.Ⴓ = value;
		}
	}

	public PublishInfo()
	{
		Alias = string.Empty;
		Url = string.Empty;
		TelSvrDesc = string.Empty;
		ArxNodePort = 3607;
		ArxClientPort = 3608;
	}

	public override string ToString()
	{
		return ႨႨ.Ⴀ(2, 0, 1157899503);
	}

	[SecuritySafeCritical]
	internal static string Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, short P_3, short P_4) where _0021_00210 : string
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		ICloneable cloneable = default(ICloneable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 1:
				case 10:
					break;
				case 0:
				case 5:
					num2 = (((P_4 ^ P_3) - 35) ^ num) switch
					{
						0 => ⴃႰ[157] - 27344, 
						_ => 2, 
					};
					continue;
				case 2:
					cloneable = null;
					num2 = ⴃႥ[384] - 50479;
					continue;
				case 8:
					cloneable = P_0.PadRight(P_1, P_2);
					num2 = ⴍႭ[334] - 42943;
					continue;
				case 7:
					num++;
					num3 = 1398;
					goto case 4;
				case 4:
				{
					int num4 = 482;
					num2 = ((699 < num3 / 2 - num4) ? 5 : 6);
					continue;
				}
				case 6:
					return cloneable as string;
				case 3:
					num2 = ⴅ[462] - 145;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static TaskFactory Ⴅ(short P_0, short P_1)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 5;
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
				case 5:
					num2 = (((P_0 ^ P_1) - 91) ^ num) switch
					{
						0 => ⴀႨ[72] - 30941, 
						_ => ⴍႭ[314] - 35346, 
					};
					continue;
				case 6:
					obj = null;
					num2 = ⴀႳ[14] - 33598;
					continue;
				case 9:
					obj = Task.Factory;
					num2 = 0;
					continue;
				case 0:
					num++;
					num3 = 1402;
					num4 = 5;
					goto case 4;
				case 4:
				{
					int num5 = num3 / 2 - num4;
					AnnCacheCfg.ႠႼ[130] = (byte)(AnnCacheCfg.ႠႼ[130] & P_1 & 0x50);
					num2 = ((701 < num5) ? (ⴀႳ[278] - 16235) : 8);
					continue;
				}
				case 3:
				case 8:
					return obj as TaskFactory;
				case 2:
					num2 = ⴀႳ[11] - 7280;
					continue;
				}
				break;
			}
		}
	}
}
