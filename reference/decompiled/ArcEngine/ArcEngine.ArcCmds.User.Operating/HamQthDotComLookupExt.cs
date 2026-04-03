using System.Collections.Generic;
using System.Data.Common;
using System.Security;
using System.Xml.Linq;
using System.Xml.Serialization;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcIo.Mirc;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public static class HamQthDotComLookupExt
{
	public static void Deserialize(this HamQthDotComLookup lookup, string msg)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 2;
		IXmlSerializable current = default(IXmlSerializable);
		object obj2 = default(object);
		int value = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				msg = ShowContestStationHelp.Ⴅ(msg, ႨႨ.Ⴀ(11, 5, 1157905073), string.Empty, 128, 'Ø');
				num = ⴄႤ[135];
				break;
			case 5:
				msg = ShowContestStationHelp.Ⴅ(msg, SetStationClubHelp.Ⴍ(9, 5, 1747263169, null), string.Empty, 447, 'ǧ');
				goto case 0;
			case 0:
			case 4:
				num = 1;
				break;
			case 1:
			{
				object obj = ShowPerformance.Ⴀ(msg, 16, 'X');
				object enumerator = (obj as XElement).Elements().GetEnumerator();
				try
				{
					int num2 = 30;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = ⴍႤ[252] - 52529;
							continue;
						case 17:
							current = (enumerator as IEnumerator<XElement>).Current;
							num2 = (((obj2 = MircIo.Ⴜ(ႰႼ.Ⴍ(current as XElement, 'ʸ', 'ʰ'), 'Ƚ', 563)) == null) ? 4 : ⴀႼ[77]);
							continue;
						case 22:
							num2 = ((ႳႠ.Ⴀ != null) ? (ⴍႭ[371] - 49231) : (ⴀ[270] - 25182));
							continue;
						case 8:
							ႳႠ.Ⴀ = new Dictionary<string, int>(23)
							{
								{
									ReplyMailHelp.Ⴄ(13, null, 1057164524, 2),
									0
								},
								{
									CallBlockCacheCfg.Ⴅ(null, 6, 62054804, null),
									1
								},
								{
									SetStationClubHelp.Ⴍ(10, 1, 1747263217, null),
									2
								},
								{
									ႨႨ.Ⴀ(13, 3, 1157904960),
									3
								},
								{
									SetTalkCount.Ⴗ(0, null, 1267019128, typeof(ByeHelp)),
									4
								},
								{
									ReplyMailHelp.Ⴄ(10, null, 1057164516, 5),
									5
								},
								{
									CallBlockCacheCfg.Ⴅ(null, 0, 62054809, null),
									6
								},
								{
									SetStationQth.Ⴍ(null, 1687353751, 6, 21),
									7
								},
								{
									ႨႨ.Ⴀ(10, 5, 1157904972),
									8
								},
								{
									SetTalkCount.Ⴗ(8, null, 1267019127, typeof(DirectorySubjectHelp)),
									9
								},
								{
									ႰႥ.Ⴅ(3, '\u007f', 952621413),
									10
								},
								{
									SetStationClubHelp.Ⴍ(0, 1, 1747263211, null),
									11
								},
								{
									ShowWxHelp.Ⴍ('\u0094', 985806290, 3),
									12
								},
								{
									ReplyMailHelp.Ⴄ(24, null, 1057164536, 7),
									13
								},
								{
									ReplyMail.Ⴅ(2, 1, 1217941967),
									14
								},
								{
									ReplyMail.Ⴅ(2, 3, 1217943089),
									15
								},
								{
									ShowSkimCtyHelp.Ⴍ(1216132942, 8, 'é'),
									16
								},
								{
									CallBlockCacheCfg.Ⴅ(null, 6, 62054784, null),
									17
								},
								{
									SetStationQth.Ⴍ(null, 1687354441, 5, 11),
									18
								},
								{
									SetTalkCount.Ⴗ(0, null, 1267019114, typeof(MsgType)),
									19
								},
								{
									ႰႥ.Ⴅ(5, '\u00b4', 952621417),
									20
								},
								{
									SetStationClubHelp.Ⴍ(0, 2, 1747263206, null),
									21
								},
								{
									ShowWxHelp.Ⴍ('\u0090', 985806299, 5),
									22
								}
							};
							num2 = 35;
							continue;
						case 35:
							num2 = ((!ႳႠ.Ⴀ.TryGetValue((string)obj2, out value)) ? 4 : ⴄႤ[356]);
							continue;
						case 34:
							num2 = value switch
							{
								0 => ⴄႤ[408] - 72, 
								1 => 14, 
								2 => 24, 
								3 => ⴅ[10] - 208, 
								4 => 0, 
								5 => ⴐ[133] - 33, 
								6 => ⴀႳ[308] - 13007, 
								7 => 2, 
								8 => 16, 
								9 => ⴀႣ[379] - 64809, 
								10 => 11, 
								11 => ⴄႷ[16] - 11890, 
								12 => 5, 
								13 => 13, 
								14 => 10, 
								15 => ⴅ[479] - 235, 
								16 => 18, 
								17 => ⴄႷ[71] - 34095, 
								18 => 23, 
								19 => 26, 
								20 => 25, 
								21 => ⴃႰ[187] - 57492, 
								22 => 21, 
								_ => ⴀႣ[148] - 23941, 
							};
							continue;
						case 15:
							num2 = 4;
							continue;
						case 20:
							lookup.Ⴀ(SetDxFilter.Ⴀ(ShowNodes.Ⴀ(current as XElement, 988, 974), 373, 'Ĵ'));
							num2 = ⴐ[367];
							continue;
						case 14:
							lookup.Ⴅ(ShowNodes.Ⴀ(current as XElement, 579, 593));
							num2 = ⴄႭ[492] / 9;
							continue;
						case 24:
							lookup.Ⴈ(ShowNodes.Ⴀ((XElement)current, 594, 576));
							num2 = ⴄႤ[148] * 4;
							continue;
						case 6:
							lookup.Ⴓ(ShowNodes.Ⴀ((XElement)current, 251, 233));
							num2 = ⴄႷ[129] - 22986;
							continue;
						case 0:
						case 9:
							lookup.Ⴗ(ShowNodes.Ⴀ((XElement)current, 151, 133));
							num2 = ⴃႥ[269] - 6343;
							continue;
						case 32:
							lookup.Ⴄ(ShowNodes.Ⴀ((XElement)current, 27, 9));
							num2 = 4;
							continue;
						case 29:
							lookup.Ⴐ(ShowNodes.Ⴀ((XElement)current, 922, 904));
							num2 = ⴀႳ[152] - 25345;
							continue;
						case 2:
						case 28:
							lookup.Ⴍ(ShowNodes.Ⴀ((XElement)current, 360, 378));
							num2 = ⴄႤ[383] - 230;
							continue;
						case 16:
							lookup.Ⴃ(ShowNodes.Ⴀ(current as XElement, 831, 813));
							num2 = 4;
							continue;
						case 33:
							lookup.Ⴜ(ShowNodes.Ⴀ((XElement)current, 127, 109));
							num2 = 4;
							continue;
						case 11:
							lookup.ႥႠ(ShowNodes.Ⴀ((XElement)current, 323, 337));
							num2 = 4;
							continue;
						case 31:
							lookup.ႥႥ(ShowNodes.Ⴀ((XElement)current, 888, 874));
							num2 = ⴄႷ[16] - 11917;
							continue;
						case 5:
						case 27:
							lookup.ႥႨ(ShowNodes.Ⴀ((XElement)current, 939, 953));
							num2 = 4;
							continue;
						case 13:
							lookup.ႥႳ((current as XElement).Value);
							num2 = 4;
							continue;
						case 10:
							lookup.ႥႷ(((XElement)current).Value);
							num2 = ⴀႨ[33] - 62152;
							continue;
						case 1:
							lookup.ႥႤ(((XElement)current).Value);
							num2 = 4;
							continue;
						case 18:
							lookup.ႥႰ(((XElement)current).Value);
							num2 = 4;
							continue;
						case 3:
							lookup.ႥႭ((current as XElement).Value);
							num2 = ⴅ[145] - 3;
							continue;
						case 23:
							lookup.ႥႣ((current as XElement).Value);
							num2 = 4;
							continue;
						case 26:
							lookup.ႥႼ(((XElement)current).Value);
							num2 = ⴀ[448] - 16854;
							continue;
						case 25:
							lookup.ႨႠ((current as XElement).Value);
							num2 = 4;
							continue;
						case 19:
							lookup.ႨႥ((current as XElement).Value);
							num2 = ⴄႭ[221] - 61;
							continue;
						case 21:
							lookup.ႨႨ((current as XElement).Value);
							break;
						case 4:
							break;
						case 7:
							goto end_IL_0102;
						}
						num2 = (((IEnumerator<XElement>)enumerator).MoveNext() ? (ⴃႥ[234] - 38039) : (ⴀႳ[177] - 3853));
						continue;
						end_IL_0102:
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
							num4 = (((IEnumerator<XElement>)enumerator == null) ? ⴄႭ[66] : 2);
							goto IL_0952;
						case 2:
						case 3:
							((IEnumerator<XElement>)enumerator).Dispose();
							break;
						case 0:
							break;
						}
						break;
						IL_0952:
						num3 = num4;
					}
				}
				switch (2)
				{
				}
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴍ(char P_0, int P_1, char P_2)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 7;
					continue;
				case 7:
					break;
				case 6:
					num2 = (((P_1 ^ P_2) - 100) ^ num) switch
					{
						0 => ⴀႼ[128] - 39, 
						_ => 5, 
					};
					continue;
				case 5:
					result = false;
					goto case 9;
				case 9:
					num2 = 1;
					continue;
				case 3:
				case 4:
					result = char.IsLower(P_0);
					num2 = ⴄႭ[286] - 184;
					continue;
				case 1:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႥ[105] - ⴃႥ[105]) : 8);
					continue;
				case 8:
					num2 = ⴍႭ[187] - 998;
					continue;
				case 0:
				case 11:
					return result;
				case 10:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴀ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : DxCommentExtCfg
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 7;
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
				case 7:
					num2 = (((P_2 ^ P_1) - 24) ^ num) switch
					{
						0 => ⴀႳ[252] - 1341, 
						1 => ⴀႼ[33], 
						_ => 8, 
					};
					continue;
				case 8:
					result = false;
					num2 = 1;
					continue;
				case 0:
				case 2:
				case 10:
					result = P_0.Loc;
					num2 = ⴃႠ[375] - 37084;
					continue;
				case 9:
					result = P_0.County;
					num2 = ⴃႰ[203] - 59432;
					continue;
				case 1:
				{
					num++;
					int num3 = 1968;
					int num4 = 420;
					num2 = ((492 < num3 / 4 - num4) ? (ⴀႼ[44] - 152) : 4);
					continue;
				}
				case 4:
					return result;
				case 3:
				case 5:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2) where _0021_00210 : DbConnection
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 7;
				break;
			case 6:
			case 7:
				num = (((P_1 ^ P_2) - 109) ^ num2) switch
				{
					0 => ⴃႰ[4] - 5302, 
					_ => 5, 
				};
				break;
			case 5:
				num = ⴍႤ[0] - 24004;
				break;
			case 8:
			case 9:
				P_0.Close();
				goto case 4;
			case 4:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴀႼ[31] - 126) : (ⴃႥ[313] - 4484));
				break;
			case 0:
			case 1:
				num = ⴀ[435] - 13753;
				break;
			case 3:
				return;
			}
		}
	}
}
