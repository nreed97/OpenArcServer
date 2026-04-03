using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using System.Security;
using System.Xml;
using ArcEngine;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcServerConfig.Io;
using ArcInterfaces;
using ArcInterfaces.Ui;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;

namespace Ⴈ;

internal static class ႷႷ
{
	internal static StatusBarData Ⴓ(ArcEngine.ObjectManager P_0)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		while (true)
		{
			object obj = new StatusBarData();
			DirectoryOwn.Ⴃ(obj as StatusBarData, P_0.Ⴐ().Ⴅ(), 522, 601);
			int num = ⴀႨ[70] - 57242;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႳ[198] - 8772;
					continue;
				case 5:
				case 6:
					break;
				case 8:
					ShowClusterHelp.Ⴍ((StatusBarData)obj, Ⴗ(P_0), 'σ', 'ϊ');
					ShowClusterHelp.Ⴍ((StatusBarData)obj, Ⴄ(P_0), 'ι', 'γ');
					num = ⴍႭ[296] - 40615;
					continue;
				case 0:
				case 2:
					ႷႤ.Ⴍ(obj as StatusBarData, P_0.Ⴀ().Ⴃ().Ⴀ()
						.Ⴄ(), 593, 518);
					goto case 4;
				case 4:
					num = ⴄႤ[47] / 4;
					continue;
				case 3:
					IoDevicesCfg.Ⴀ(obj as StatusBarData, Bye.Ⴄ(obj as StatusBarData, 'λ', 'Π') < P_0.Ⴍ().HealthMonitor.DxSpotThreshold, 782, '\u0327');
					num = ⴀႣ[26] - 16461;
					continue;
				case 10:
					((StatusBarData)obj).AlertUserCnt = (obj as StatusBarData).UserCnt < P_0.Ⴍ().HealthMonitor.UserCntThreshold;
					num = 7;
					continue;
				case 7:
					((StatusBarData)obj).AlertNodeCnt = (obj as StatusBarData).NodeCnt < P_0.Ⴍ().HealthMonitor.NodeCntThreshold;
					num = 9;
					continue;
				case 9:
					return obj as StatusBarData;
				}
				break;
			}
		}
	}

	private static int Ⴗ(ArcEngine.ObjectManager P_0)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 0;
		object enumerator = P_0.Ⴓ().ArcConnects.GetEnumerator();
		try
		{
			int num2 = 10;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num2)
				{
				case 7:
				case 9:
					current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
					goto case 11;
				case 11:
					num2 = ((current.Value.ConnectState == ConnectStateType.TelnetUser) ? (ⴃႠ[326] - 32485) : 0);
					continue;
				case 0:
					num2 = ((current.Value.ConnectState == ConnectStateType.ArxClient) ? (ⴄႭ[626] - 234) : 2);
					continue;
				case 2:
					num2 = ((current.Value.ConnectState == ConnectStateType.Pc92User) ? 8 : 5);
					continue;
				case 5:
					num2 = ((current.Value.ConnectState != ConnectStateType.PcxxUser) ? 1 : 8);
					continue;
				case 1:
				case 3:
					num2 = ((current.Value.ConnectState != ConnectStateType.AgwBpqUser) ? 4 : 8);
					continue;
				case 8:
					num++;
					num2 = ⴍႤ[313] - 18421;
					continue;
				default:
					num2 = ((enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? 9 : 6);
					continue;
				case 6:
					break;
				}
				break;
			}
		}
		finally
		{
			int num3 = 5;
			while (true)
			{
				int num4;
				switch (num3)
				{
				default:
					num4 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator != null) ? (ⴀ[7] - 13485) : 0);
					goto IL_01b8;
				case 2:
				case 3:
					(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
					break;
				case 0:
				case 4:
					break;
				}
				break;
				IL_01b8:
				num3 = num4;
			}
		}
		int result = num;
		SetAnnMode.ႤႭ[397] = (byte)((SetAnnMode.ႤႭ[397] | TxNodeUserCmd.ႤႷ[94]) & 0xA8);
		return result;
	}

	private static int Ⴄ(ArcEngine.ObjectManager P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 0;
		object enumerator = P_0.Ⴓ().ArcConnects.GetEnumerator();
		try
		{
			int num2 = 8;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 4:
					current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
					num2 = ((current.Value.ConnectState == ConnectStateType.ArxNode) ? (ⴍႭ[132] - 374) : 0);
					break;
				case 0:
					num2 = ((current.Value.ConnectState == ConnectStateType.PcxxNode) ? 5 : 6);
					break;
				case 6:
					num2 = ((current.Value.ConnectState != ConnectStateType.Pc92Node) ? 1 : (ⴄႭ[344] - ⴄႭ[410]));
					break;
				case 5:
				case 9:
					num++;
					num2 = ⴃႠ[288] - 10240;
					break;
				default:
					num2 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).MoveNext() ? 3 : ⴄႭ[246]);
					break;
				case 2:
				case 7:
					return num;
				}
			}
		}
		finally
		{
			int num3 = 3;
			while (true)
			{
				int num4;
				switch (num3)
				{
				default:
					num4 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 1 : 5);
					goto IL_015c;
				case 0:
				case 5:
					((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
					break;
				case 1:
					break;
				}
				break;
				IL_015c:
				num3 = num4;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴍ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[56] - 36248;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 1;
					continue;
				case 1:
					break;
				case 0:
					num2 = (((P_2 ^ P_1) - 13) ^ num) switch
					{
						0 => 7, 
						_ => 2, 
					};
					continue;
				case 2:
					result = false;
					goto case 3;
				case 3:
					num2 = 6;
					continue;
				case 7:
				case 8:
					result = UtilsCallsign.IsValidCall(P_0);
					num2 = ⴐ[204];
					continue;
				case 6:
					num++;
					num3 = 99;
					goto case 9;
				case 9:
				{
					int num4 = 143;
					num2 = ((429 > num4 - num3 * 3) ? (ⴐ[52] - 117) : ⴀႼ[136]);
					continue;
				}
				case 5:
					num2 = ⴄႤ[254] - 59;
					continue;
				case 11:
					return result;
				case 10:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string[] Ⴀ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : StationCfg
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		Array array = default(Array);
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
					num2 = 9;
					continue;
				case 1:
				case 9:
					break;
				case 0:
					num2 = (((P_1 ^ P_2) - 26) ^ num) switch
					{
						0 => ⴄႤ[32] - 183, 
						_ => 8, 
					};
					continue;
				case 8:
					array = null;
					num2 = ⴀ[385] - 61649;
					continue;
				case 2:
					array = P_0.Macros;
					num2 = ⴀႳ[278] - 16234;
					continue;
				case 5:
				case 6:
				{
					num++;
					int num3 = 160;
					int num4 = 71;
					num2 = ((80 < num3 / 2 - num4) ? (ⴀႨ[47] - 22488) : (ⴀ[289] - 38770));
					continue;
				}
				case 7:
				case 10:
					return array as string[];
				case 4:
					num2 = ⴀ[228] - 47208;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataTable Ⴅ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, int P_3) where _0021_00210 : string where _0021_00211 : DataTableCollection
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		ISerializable serializable = default(ISerializable);
		while (true)
		{
			int num = 0;
			int num2 = ⴀႨ[72] - 30948;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 1;
					continue;
				case 1:
					break;
				case 2:
					num2 = (((P_3 ^ P_2) - 87) ^ num) switch
					{
						0 => ⴃႠ[426] - 16011, 
						_ => 9, 
					};
					continue;
				case 9:
					serializable = null;
					num2 = ⴀႳ[66] - 4067;
					continue;
				case 4:
				case 7:
					serializable = P_0.Add(P_1);
					num2 = 11;
					continue;
				case 8:
				case 11:
				{
					int num3 = num;
					SetTalkCountHelp.Ⴅ[364] = (byte)((SetTalkCountHelp.Ⴅ[364] * P_3) & 0xBB);
					num = num3 + 1;
					int num4 = 763;
					num2 = (((num4 * num4 + num4) % 2 == 0) ? (ⴄႤ[406] - 194) : ⴀႼ[136]);
					continue;
				}
				case 5:
					num2 = 2;
					continue;
				case 6:
				case 10:
					return (DataTable)serializable;
				case 0:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static OutputType Ⴃ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : DxCfg
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		OutputType result = default(OutputType);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႭ[631] - 222;
					continue;
				case 6:
					break;
				case 1:
				case 5:
					num2 = (((P_1 ^ P_2) - 101) ^ num) switch
					{
						0 => 2, 
						_ => 3, 
					};
					continue;
				case 3:
					result = OutputType.Off;
					num2 = ⴀ[255] - 57050;
					continue;
				case 2:
					result = P_0.Output;
					num2 = 11;
					continue;
				case 11:
				{
					num++;
					int num3 = 963;
					int num4 = 994;
					num2 = ((7952 > num4 - num3 * 8) ? (ⴀႨ[28] - 17446) : 10);
					continue;
				}
				case 10:
					num2 = ⴀႳ[262] - 23920;
					continue;
				case 9:
					return result;
				case 8:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴐ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : StationCfg
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		object obj = default(object);
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
				case 8:
					break;
				case 0:
					num2 = (((P_2 ^ P_1) - 30) ^ num) switch
					{
						0 => 3, 
						1 => 4, 
						_ => ⴀႣ[350] - 49125, 
					};
					continue;
				case 5:
					obj = null;
					num2 = 11;
					continue;
				case 3:
					obj = P_0.Qth;
					num2 = ⴍႭ[325] - 18830;
					continue;
				case 4:
					obj = P_0.Phone;
					num2 = ⴀႳ[295] - 59868;
					continue;
				case 11:
				{
					num++;
					int num3 = 627;
					int num4 = 128;
					num2 = ((209 < num3 / 3 - num4) ? ⴄႭ[66] : (ⴄႷ[58] - 48419));
					continue;
				}
				case 1:
				case 7:
				case 10:
					return (string)obj;
				case 9:
					num2 = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, short P_3) where _0021_00210 : XmlDocument where _0021_00211 : string
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 1;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 2;
				break;
			case 2:
				num = (((P_2 ^ P_3) - 73) ^ num3) switch
				{
					0 => 3, 
					_ => 6, 
				};
				break;
			case 6:
				num = ⴅ[102] - 217;
				break;
			case 3:
				P_0.LoadXml(P_1);
				goto case 4;
			case 4:
			case 8:
			case 9:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = 7;
				break;
			case 7:
				num = ((num2 % 2 != 0) ? (ⴅ[131] - 63) : (ⴀ[478] - 14769));
				break;
			case 0:
			case 5:
				return;
			}
		}
	}
}
