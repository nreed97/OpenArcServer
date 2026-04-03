using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Security;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;

namespace ArcEngine.ArcServerConfig;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class HealthMonitorCfg
{
	private int Ⴈ;

	private int Ⴄ;

	private SetStationQthHelp.Ⴈ Ⴐ = new SetStationQthHelp.Ⴈ();

	[Description("If the user count drops below this value a yellow alert on the status will appear")]
	public int UserCntThreshold
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

	[Description("If the node count drops below this value a yellow alert on the status will appear")]
	public int NodeCntThreshold
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

	[Description("If the DX rate drops below this value a yellow alert on the status will appear")]
	public int DxSpotThreshold
	{
		get
		{
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			return Ⴐ.Ⴍ;
		}
		set
		{
			Ⴐ.Ⴍ = value;
		}
	}

	public HealthMonitorCfg()
	{
		UserCntThreshold = 5;
		NodeCntThreshold = 5;
		DxSpotThreshold = 50;
	}

	public override string ToString()
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		return CallBlockCacheCfg.Ⴅ(null, 0, 62054415, null);
	}

	[SecuritySafeCritical]
	internal static DataColumnCollection Ⴅ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : DataTable
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႼ[96];
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
				case 1:
				case 4:
					num2 = (((P_1 ^ P_2) - 35) ^ num) switch
					{
						0 => 5, 
						_ => 0, 
					};
					continue;
				case 0:
					obj = null;
					num2 = 3;
					continue;
				case 5:
					obj = P_0.Columns;
					num2 = 3;
					continue;
				case 3:
					num++;
					num3 = 542;
					num4 = 603;
					goto case 6;
				case 6:
					num2 = ((6030 > num4 - num3 * 10) ? 8 : 9);
					continue;
				case 9:
					num2 = 4;
					continue;
				case 8:
				case 10:
					return (DataColumnCollection)obj;
				case 7:
					num2 = ⴍႤ[314] - 34773;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211, _0021_00212>(_0021_00212 P_0, _0021_00211 P_1, _0021_00210 P_2, short P_3, char P_4) where _0021_00212 : Hashtable
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 9;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴍႤ[284] - 31689;
				break;
			case 6:
				num = (((P_4 ^ P_3) - 52) ^ num3) switch
				{
					0 => ⴃႠ[56] - 20637, 
					_ => 0, 
				};
				break;
			case 0:
				num = 8;
				break;
			case 2:
				P_0.Add(P_1, P_2);
				goto case 8;
			case 8:
				num3++;
				goto case 5;
			case 5:
			case 7:
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = 1;
				break;
			case 1:
				num = ((num2 % 2 != 0) ? 6 : (ⴃႰ[13] - 37064));
				break;
			case 3:
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static float Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DxSpot
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		float result = default(float);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[16] - 11914;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႰ[202] - 40308;
					continue;
				case 3:
				case 5:
					break;
				case 7:
				case 9:
				{
					int num6;
					switch (((P_1 ^ P_2) - 39) ^ num)
					{
					default:
						num6 = 10;
						break;
					case 0:
					{
						byte num5 = ⴅ[223];
						IpLockoutCacheCfg.ႭႭ[368] = (char)((IpLockoutCacheCfg.ႭႭ[368] * P_1) & 3);
						num6 = num5 - 107;
						break;
					}
					}
					num2 = num6;
					continue;
				}
				case 10:
					result = 0.38906008f;
					goto case 6;
				case 6:
					num2 = 2;
					continue;
				case 8:
					result = P_0.Freq;
					num2 = 2;
					continue;
				case 2:
				{
					num++;
					int num3 = 1296;
					int num4 = 16;
					num2 = ((324 >= num3 / 4 - num4) ? 1 : (ⴀႣ[4] - 32461));
					continue;
				}
				case 1:
					return result;
				case 4:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}
}
