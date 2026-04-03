using System.Collections;
using System.ComponentModel;
using System.Security;
using System.Xml;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class FocCacheCfg
{
	private bool Ⴄ;

	private ႰႼ.Ⴈ Ⴅ;

	[Description("Flag to automatically update from the web every day")]
	public bool AutoDownload
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			return Ⴅ.Ⴓ;
		}
		set
		{
			bool ⴓ = value;
			Ⴅ.Ⴓ = ⴓ;
		}
	}

	[Description("Flag to automatically reload the cache when the source text file changes")]
	public bool AutoReload
	{
		get
		{
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	[Description("Download url")]
	public string Url
	{
		get
		{
			byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
			return Ⴅ.Ⴃ;
		}
		set
		{
			Ⴅ.Ⴃ = value;
		}
	}

	public FocCacheCfg()
	{
		AutoDownload = true;
		AutoReload = true;
		Url = CallBlockCacheCfg.Ⴅ(null, 3, 62061647, null);
	}

	public override string ToString()
	{
		return CallBlockCacheCfg.Ⴅ(null, 6, 62061673, null);
	}

	[SecuritySafeCritical]
	internal static bool Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : CtyUpdate
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		bool result = default(bool);
		int num4 = default(int);
		int num3 = default(int);
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
					num2 = 2;
					continue;
				case 2:
				case 3:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 38) ^ num) switch
					{
						0 => ⴄႷ[21] - 64083, 
						_ => 6, 
					};
					continue;
				case 6:
					result = false;
					num2 = 9;
					continue;
				case 5:
				case 11:
					result = P_0.VerifyCopyDelete();
					num2 = ⴀႣ[405] - 56954;
					continue;
				case 9:
					num++;
					goto case 8;
				case 8:
				{
					num4 = 1267;
					int num5 = num4;
					num3 = num5 * num5;
					num2 = ⴀႨ[202] - 37300;
					continue;
				}
				case 7:
					num3 = num4 + num3;
					num2 = ((num3 % 2 == 0) ? (ⴄႷ[16] - 11917) : 0);
					continue;
				case 4:
					return result;
				case 1:
					num2 = ⴃႥ[109] - 17162;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static IEnumerator Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : XmlNodeList
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		object obj = default(object);
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
					num2 = ⴄႷ[87] - 25173;
					continue;
				case 0:
					break;
				case 4:
				case 5:
					num2 = (((P_1 ^ P_2) - 9) ^ num) switch
					{
						0 => 9, 
						_ => ⴀႨ[109] - 2188, 
					};
					continue;
				case 10:
					obj = null;
					num2 = ⴐ[183] - 193;
					continue;
				case 9:
					obj = P_0.GetEnumerator();
					num2 = 6;
					continue;
				case 6:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 1;
				case 1:
				case 11:
					num2 = ⴀႨ[86] - 43422;
					continue;
				case 2:
				{
					int num4;
					if (num3 % 2 == 0)
					{
						num4 = ⴍႤ[216] - 63962;
					}
					else
					{
						char num5 = ⴃႰ[116];
						SetTalkCountHelp.Ⴅ[480] = (byte)((SetTalkCountHelp.Ⴅ[480] - ShowQrzHelp.ႤႤ[408]) & 0x99);
						num4 = num5 - 19363;
					}
					num2 = num4;
					continue;
				}
				case 3:
					return obj as IEnumerator;
				case 8:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}
}
