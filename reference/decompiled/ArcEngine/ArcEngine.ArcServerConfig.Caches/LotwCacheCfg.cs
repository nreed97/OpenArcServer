using System;
using System.ComponentModel;
using System.Net;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class LotwCacheCfg
{
	private bool Ⴓ;

	private ႰႼ.Ⴈ Ⴗ;

	[Description("Flag to automatically update from the web every day")]
	public bool AutoDownload
	{
		get
		{
			return Ⴗ.Ⴓ;
		}
		set
		{
			bool ⴓ = value;
			Ⴗ.Ⴓ = ⴓ;
		}
	}

	[Description("Flag to automatically reload the cache when the source text file changes")]
	public bool AutoReload
	{
		get
		{
			bool ⴓ = Ⴓ;
			SetAnnMode.ႤႭ[390] = (byte)((SetAnnMode.ႤႭ[390] | ShowQrzHelp.ႤႤ[355]) & 0x8A);
			return ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	[Description("Download url")]
	public string Url
	{
		get
		{
			return Ⴗ.Ⴃ;
		}
		set
		{
			Ⴗ.Ⴃ = value;
		}
	}

	public LotwCacheCfg()
	{
		AutoDownload = true;
		AutoReload = true;
		Url = CallBlockCacheCfg.Ⴅ(null, 3, 62054556, null);
	}

	public override string ToString()
	{
		return CallBlockCacheCfg.Ⴅ(null, 7, 62054561, null);
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : AnnWxSpot
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 12;
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
				case 12:
					num2 = (((P_2 ^ P_1) - 118) ^ num) switch
					{
						0 => 3, 
						1 => ⴀ[12] - 22296, 
						2 => 0, 
						_ => ⴄႷ[115] - 21751, 
					};
					continue;
				case 5:
				case 9:
					obj = null;
					num2 = 11;
					continue;
				case 3:
					obj = P_0.Msg;
					num2 = 11;
					continue;
				case 8:
					obj = P_0.SysopFlag;
					num2 = 11;
					continue;
				case 0:
					obj = P_0.SpotterCont;
					num2 = ⴃႠ[349] - 18139;
					continue;
				case 4:
				case 11:
				{
					num++;
					int num3 = 11;
					int num4 = 54;
					num2 = ((378 > num4 - num3 * 7) ? 10 : 7);
					continue;
				}
				case 7:
					num2 = ⴀႣ[426] - 54233;
					continue;
				case 10:
					return (string)obj;
				case 1:
					num2 = ⴀႳ[168] - 8454;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] Ⴈ(int P_0, int P_1, short P_2)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		object obj = default(object);
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
					num2 = 10;
					continue;
				case 10:
					break;
				case 8:
					num2 = (((P_1 ^ P_2) - 122) ^ num) switch
					{
						0 => 0, 
						_ => ⴐ[204], 
					};
					continue;
				case 6:
					obj = null;
					num2 = 9;
					continue;
				case 0:
					obj = BitConverter.GetBytes(P_0);
					num2 = 9;
					continue;
				case 9:
				{
					num++;
					int num3 = 1432;
					int num4 = 260;
					BandModeCacheCfg.ႠႳ[7] = (char)((BandModeCacheCfg.ႠႳ[7] | P_2) & 0xC);
					num2 = ((358 < num3 / 4 - num4) ? 8 : (ⴃႥ[108] - 64164));
					continue;
				}
				case 1:
				case 4:
					return (byte[])obj;
				case 2:
				case 3:
				case 5:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static WebResponse Ⴅ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : WebRequest
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		IDisposable disposable = default(IDisposable);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႨ[203] - 48778;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 6:
					num2 = (((P_1 ^ P_2) - 7) ^ num) switch
					{
						0 => 9, 
						_ => ⴃႥ[117] - 56002, 
					};
					continue;
				case 0:
					disposable = null;
					num2 = 4;
					continue;
				case 9:
					disposable = P_0.GetResponse();
					num2 = ⴃႰ[177] - 20356;
					continue;
				case 3:
				case 4:
				{
					num++;
					num4 = 126;
					int num5 = num4;
					num3 = num5 * num5;
					num2 = ⴀႼ[134] - 141;
					continue;
				}
				case 10:
					num3 = num4 + num3;
					num2 = ((num3 % 2 != 0) ? 6 : 5);
					continue;
				case 5:
					return disposable as WebResponse;
				case 1:
				case 8:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}
}
