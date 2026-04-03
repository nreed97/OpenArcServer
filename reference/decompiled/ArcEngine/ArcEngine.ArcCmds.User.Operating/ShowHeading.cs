using System;
using System.Collections.Generic;
using System.Data;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces;
using ArcInterfaces.Spots;
using ArcShared;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowHeading : IArcCmd
{
	private static void Ⴀ(NodeUserCmd P_0)
	{
		int num = 3;
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 1:
			case 4:
				obj = new ShowHeadingHelp();
				goto case 0;
			case 0:
				((ShowHeadingHelp)obj).Exec(P_0);
				obj2 = new Publisher();
				break;
			case 2:
				break;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(11, 7, 1157904175), P_0.Rx.Msg, 248, 182));
			num = 1;
		}
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		try
		{
			int num = 12;
			object obj3 = default(object);
			float num4 = default(float);
			float num2 = default(float);
			BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					goto case 9;
				case 9:
					num = ((cmd.Rx.Split.Length <= 2) ? (ⴀႨ[40] - 39556) : (ⴄႷ[120] - 46468));
					continue;
				case 5:
					ShowStation.Ⴗ(cmd.Ⴍ().Ⴅ(), cmd.Ⴍ());
					num = ((!ShowPrefix.Ⴓ(ႰႰ.Ⴅ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 842, 860), 947, 'Ͻ'), ByeHelp.Ⴅ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 912, 902), '\u0309', 840), 352, 'ľ')) ? 7 : 13);
					continue;
				case 13:
					obj3 = SetDxFilter.Ⴀ(cmd.Rx.GetLastToken(), 956, 'Ͻ');
					num4 = 0f;
					num = 10;
					continue;
				case 10:
					num2 = 0f;
					baseXmlSerializer = Ⴈ(cmd.Ⴍ().Ⴅ(), (string)obj3);
					num = 2;
					continue;
				case 2:
				case 8:
					ShowNodesHelp.Ⴄ(ႰႰ.Ⴅ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 450, 468), 601, 'ȗ'), ByeHelp.Ⴅ(ShowConnectsHelp.Ⴍ(cmd.Ⴍ().Cfg, 537, 527), '\u0379', 824), ႰႰ.Ⴅ(ShowConnectsHelp.Ⴍ(((ArcConnect)baseXmlSerializer).Cfg, 27, 13), 340, 'Ě'), ByeHelp.Ⴅ(ShowConnectsHelp.Ⴍ(((ArcConnect)baseXmlSerializer).Cfg, 169, 191), 'ʒ', 723), ref num4, ref num2, 729, 657);
					num = ⴃႥ[329] - 21272;
					continue;
				case 11:
				{
					List<string> msg = cmd.Tx.Msg;
					object obj2 = new string[13];
					((string[])obj2)[0] = ႰႥ.Ⴅ(2, '\u001b', 952619222);
					((string[])obj2)[1] = obj3 as string;
					(obj2 as string[])[2] = SetStationQth.Ⴍ(null, 1687352349, 5, 7);
					(obj2 as string[])[3] = Ⴀ(cmd.Ⴍ().Ⴅ(), (string)obj3);
					((string[])obj2)[4] = ႨႨ.Ⴀ(5, 4, 1157902546);
					((string[])obj2)[5] = ShowDxOptionsHelp.Ⴅ(ref num2, SetTalkCount.Ⴗ(3, null, 1267022366, typeof(DxClusterInfo)), 677, 'ʧ');
					((string[])obj2)[6] = ႰႥ.Ⴅ(6, '6', 952619178);
					string[] obj4 = (string[])obj2;
					double num3 = SetDxArPc.Ⴃ(num2, 53, 116);
					obj4[7] = ႷႳ.Ⴗ(ref num3, SetTalkCount.Ⴗ(5, null, 1267022360, typeof(SetStationMacros)), 803, '\u0336');
					(obj2 as string[])[8] = SetStationQth.Ⴍ(null, 1687352340, 0, 13);
					(obj2 as string[])[9] = ShowDxOptionsHelp.Ⴅ(ref num4, SetTalkCount.Ⴗ(4, null, 1267022361, typeof(ShowSunHelp)), 469, 'Ǘ');
					(obj2 as string[])[10] = CallBlockCacheCfg.Ⴅ(null, 8, 62056580, null);
					(obj2 as string[])[11] = UtilsLatLon.MilesToKm(num4).ToString(SetTalkCount.Ⴗ(2, null, 1267022367, typeof(ShowPrefix)));
					(obj2 as string[])[12] = SetTalkCount.Ⴗ(5, null, 1267023012, typeof(ႳႼ));
					msg.Add(string.Concat((string[])obj2));
					num = ⴄႷ[35] - 5042;
					continue;
				}
				case 7:
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134452, 8, 'ã'));
					goto case 4;
				case 4:
				{
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					goto case 6;
				}
				case 6:
					num = ⴄႤ[530] - 109;
					continue;
				case 1:
					Ⴀ(cmd);
					break;
				case 0:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			_ = ex.Message;
			Ⴀ(cmd);
		}
		switch (4)
		{
		}
	}

	private ArcConnect Ⴈ(ObjectManager P_0, string P_1)
	{
		while (true)
		{
			BaseXmlSerializer baseXmlSerializer = new ArcConnect(P_0, P_1);
			while (true)
			{
				IL_0032:
				(baseXmlSerializer as ArcConnect).Cfg = P_0.Ⴀ().ႨႣ().Ⴃ(baseXmlSerializer as ArcConnect);
				int num = 3;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 4;
						continue;
					case 0:
					case 4:
						break;
					case 2:
						goto IL_0032;
					case 3:
						ShowStation.Ⴗ(P_0, baseXmlSerializer as ArcConnect);
						return (ArcConnect)baseXmlSerializer;
					}
					break;
				}
				break;
			}
		}
	}

	private string Ⴀ(ObjectManager P_0, string P_1)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		ICallbookData callbookData = default(ICallbookData);
		while (true)
		{
			ICloneable cloneable = string.Empty;
			while (true)
			{
				IL_0063:
				object obj = P_0.Ⴀ().ႤႷ().CtyInfoFromCall(P_1);
				int num = ((!(obj is CtyInfo)) ? 7 : 8);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 10;
						continue;
					case 10:
						break;
					case 3:
						goto IL_0063;
					case 8:
						cloneable = SetDxOutput.Ⴓ(obj as CtyInfo, 258, 309);
						num = 7;
						continue;
					case 6:
					case 7:
						num = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ(obj as CtyInfo, '`', 121), ReplyMailHelp.Ⴄ(27, null, 1057162203, 0), 691, 724) ? (ⴃႠ[267] - 19280) : (ⴃႥ[143] - 48150));
						continue;
					case 0:
						num = ((!ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ(obj as CtyInfo, 'Ƥ', 445), CallBlockCacheCfg.Ⴅ(null, 5, 62057560, null), 882, 789)) ? 9 : (ⴃႥ[234] - 38052));
						continue;
					case 4:
						callbookData = P_0.Ⴀ().UsVeCallbook.Search(P_1);
						num = ((callbookData is CallbookData) ? 1 : (ⴅ[265] - 213));
						continue;
					case 1:
						cloneable = (string)cloneable + CallBlockCacheCfg.Ⴅ(null, 1, 62058061, null) + ((CallbookData)callbookData).State + ReplyMail.Ⴅ(0, 4, 1217945008);
						num = ⴀႼ[33];
						continue;
					case 9:
						return cloneable as string;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, DateTime P_1, short P_2, short P_3) where _0021_00210 : WwvSpot
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				break;
			case 0:
				num = (((P_2 ^ P_3) - 4) ^ num2) switch
				{
					0 => ⴀႨ[45] - 15626, 
					_ => 8, 
				};
				break;
			case 8:
				num = 1;
				break;
			case 7:
				P_0.Dts = P_1;
				goto case 1;
			case 1:
				num2++;
				goto case 5;
			case 5:
			case 6:
			{
				int num3 = 241;
				int num4 = 255;
				num = ((2295 > num4 - num3 * 9) ? 3 : 9);
				break;
			}
			case 2:
			case 9:
				num = 0;
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static WwvCfg Ⴅ<_0021_00210>(_0021_00210 P_0, short P_1, short P_2) where _0021_00210 : ArcUserCfg
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴍႭ[262] - 50125;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႳ[5] - 20328;
					continue;
				case 5:
					break;
				case 2:
					num2 = (((P_1 ^ P_2) - 4) ^ num) switch
					{
						0 => 11, 
						_ => ⴐ[194] - 132, 
					};
					continue;
				case 4:
					obj = null;
					num2 = 8;
					continue;
				case 3:
				case 11:
					obj = P_0.Wwv;
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = 241;
					num4 = 255;
					goto case 1;
				case 1:
					num2 = ((2295 > num4 - num3 * 9) ? 6 : 9);
					continue;
				case 9:
					num2 = ⴀႳ[280] - 57526;
					continue;
				case 6:
					return obj as WwvCfg;
				case 7:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataRowCollection Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : DataTable
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		InternalDataCollectionBase internalDataCollectionBase = default(InternalDataCollectionBase);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႰ[30] - 31729;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 5;
					continue;
				case 5:
				case 10:
					break;
				case 3:
					num2 = (((P_2 ^ P_1) - 0) ^ num) switch
					{
						0 => ⴀႨ[27] - 10518, 
						_ => ⴄႤ[148], 
					};
					continue;
				case 1:
					internalDataCollectionBase = null;
					num2 = 0;
					continue;
				case 2:
				case 4:
					internalDataCollectionBase = P_0.Rows;
					num2 = ⴃႰ[32] - ⴃႰ[32];
					continue;
				case 0:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? (ⴃႰ[2] - 38921) : 7);
					continue;
				case 7:
					num2 = 3;
					continue;
				case 9:
				case 11:
					return (DataRowCollection)internalDataCollectionBase;
				case 6:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}
}
