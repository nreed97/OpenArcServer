using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces;
using ArcShared;
using ArcShared.ArcUtils;
using Common.Logging;
using Ⴈ;

namespace ArcEngine.ContestProcessing;

public class N1mmCallHist
{
	private static readonly ILog m_Ⴃ = NodeUserCmd.Ⴗ(ShowSkimCtyHelp.Ⴍ(1216133594, 5, '¦'), 292, 329);

	private Dictionary<string, ႰႭ> Ⴍ;

	public void Process(ObjectManager om)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		try
		{
			int num = 7;
			object obj7 = default(object);
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			IComparable comparable = default(IComparable);
			BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
			IDisposable disposable = default(IDisposable);
			object obj2 = default(object);
			ICloneable cloneable = default(ICloneable);
			object obj6 = default(object);
			ICallbookData callbookData = default(ICallbookData);
			object obj5 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					Ⴍ = new Dictionary<string, ႰႭ>();
					obj7 = ShowLog.Ⴍ(975, 'χ');
					enumerable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)obj7, 555, 585), 208, 'Å'), ReplyMail.Ⴅ(3, 6, 1217944799), 311, 377);
					num = 2;
					continue;
				case 2:
					comparable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(obj7 as Assembly, 231, 133), 367, 'ź'), SetStationQth.Ⴍ(null, 1687351389, 2, 9), 734, 656);
					num = 10;
					continue;
				case 4:
				case 10:
					ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(obj7 as Assembly, 581, 551), 0, '\u0015'), ShowWxHelp.Ⴍ('î', 985808827, 8), 847, 769);
					num = 11;
					continue;
				case 11:
					ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ(obj7 as Assembly, 343, 309), 364, 'Ź'), ShowSkimCtyHelp.Ⴍ(1216133441, 1, '\u0005'), 11, 69);
					num = 9;
					continue;
				case 9:
					baseXmlSerializer = ObjectManager.Instance.Ⴓ();
					ShowQrz.Ⴈ(ShowConnectsHelp.Ⴍ(((ArcConnect)baseXmlSerializer).Cfg, 708, 722), 30.898f, 438, 416);
					num = ⴄႷ[78] - 48377;
					continue;
				case 3:
					ShowAnnHelp.Ⴐ(ShowConnectsHelp.Ⴍ((baseXmlSerializer as ArcConnect).Cfg, 847, 857), -97.3791f, 'ɔ', 571);
					goto case 8;
				case 8:
					num = 5;
					continue;
				case 5:
					disposable = new StreamWriter(comparable as string);
					goto case 0;
				case 0:
					SetStationBeep.Ⴄ(disposable as TextWriter, ReplyMail.Ⴅ(3, 6, 1217944827), 31, 28);
					num = 1;
					continue;
				case 1:
				{
					object obj = new FileStream(enumerable as string, FileMode.Open, FileAccess.Read);
					try
					{
						switch (0)
						{
						default:
							obj2 = new StreamReader((FileStream)obj);
							goto case 4;
						case 4:
							cloneable = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj2, 'ͷ', 826);
							break;
						case 2:
							break;
						}
						while (true)
						{
							IL_0a66:
							int num2 = 4;
							while (true)
							{
								switch (num2)
								{
								default:
									if (!(cloneable is string))
									{
										goto IL_0a94;
									}
									try
									{
										int num3 = 15;
										while (true)
										{
											switch (num3)
											{
											default:
												num3 = ((CallBlockCacheCfg.Ⴜ((string)cloneable, 130, 227) <= 0) ? 12 : (ⴀႣ[301] - 4333));
												continue;
											case 22:
												num3 = (SetAnnDefault.Ⴍ(cloneable as string, ႰႥ.Ⴅ(4, 'é', 952620230), 181, 231) ? 12 : (ⴄႷ[2] - 23583));
												continue;
											case 23:
												obj6 = om.Ⴀ().ႤႷ().CtyInfoFromCall(cloneable as string);
												num3 = ((!(obj6 is CtyInfo)) ? 12 : 26);
												continue;
											case 26:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ(obj6 as CtyInfo, 'ƴ', 429), ReplyMailHelp.Ⴄ(8, null, 1057162203, 0), 233, 142) ? (ⴃႰ[111] - 23881) : (ⴄႭ[627] - 119));
												continue;
											case 4:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ(obj6 as CtyInfo, 'Ĭ', 309), CallBlockCacheCfg.Ⴅ(null, 7, 62057562, null), 645, 738) ? 17 : (ⴀႣ[426] - 54235));
												continue;
											case 10:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ(obj6 as CtyInfo, 'ʛ', 642), SetStationClubHelp.Ⴍ(8, 3, 1747258035, null), 178, 213) ? 17 : 14);
												continue;
											case 14:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ((CtyInfo)obj6, '\u00af', 182), ႨႨ.Ⴀ(13, 7, 1157903566), 521, 622) ? 17 : (ⴀႨ[181] - 3881));
												continue;
											case 11:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ(obj6 as CtyInfo, 'Ǳ', 488), SetTalkCount.Ⴗ(1, null, 1267022398, typeof(SetWxOutputHelp)), 796, 891) ? ⴅ[46] : 0);
												continue;
											case 0:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ((CtyInfo)obj6, 'ȥ', 572), ReplyMailHelp.Ⴄ(7, null, 1057162218, 0), 368, 279) ? 17 : 28);
												continue;
											case 28:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ((CtyInfo)obj6, 'ˀ', 729), CallBlockCacheCfg.Ⴅ(null, 5, 62057546, null), 619, 524) ? (ⴄႭ[563] - 140) : 5);
												continue;
											case 5:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ((CtyInfo)obj6, '\u030e', 791), SetStationClubHelp.Ⴍ(5, 6, 1747258022, null), 1019, 924) ? 17 : 21);
												continue;
											case 21:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ(obj6 as CtyInfo, 'ł', 347), ႨႨ.Ⴀ(5, 2, 1157903576), 276, 371) ? 17 : 24);
												continue;
											case 24:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ((CtyInfo)obj6, 'α', 936), SetTalkCount.Ⴗ(7, null, 1267022386, typeof(ႥႠ)), 398, 489) ? 17 : 2);
												continue;
											case 2:
											case 9:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ((CtyInfo)obj6, 'Ĥ', 317), ReplyMailHelp.Ⴄ(5, null, 1057162215, 7), 263, 352) ? 17 : 8);
												continue;
											case 8:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ((CtyInfo)obj6, 'ϋ', 978), CallBlockCacheCfg.Ⴅ(null, 8, 62057597, null), 39, 64) ? 17 : 6);
												continue;
											case 6:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ(obj6 as CtyInfo, '\u0096', 143), SetStationClubHelp.Ⴍ(2, 5, 1747258079, null), 647, 736) ? 17 : (ⴀႣ[422] - 53511));
												continue;
											case 16:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ(obj6 as CtyInfo, 'ı', 296), ႨႨ.Ⴀ(7, 2, 1157903582), 75, 44) ? ⴀႼ[139] : 30);
												continue;
											case 30:
												num3 = (ByeHelp.Ⴍ(qslinfoSoapClient.Ⴈ(obj6 as CtyInfo, '\u0315', 780), SetStationQth.Ⴍ(null, 1687351301, 5, 6), 178, 213) ? 17 : (ⴀ[151] - 13299));
												continue;
											case 25:
												num3 = ((qslinfoSoapClient.Ⴈ((CtyInfo)obj6, 'ð', 233) == SetStationClubHelp.Ⴍ(5, 1, 1747258076, null)) ? 17 : 3);
												continue;
											case 3:
											case 27:
												num3 = (((obj6 as CtyInfo).Cty == ReplyMail.Ⴅ(3, 2, 1217944763)) ? 17 : 20);
												continue;
											case 20:
											case 29:
												num3 = (((obj6 as CtyInfo).Cty == CallBlockCacheCfg.Ⴅ(null, 7, 62057595, null)) ? (ⴀႨ[190] - 45577) : 19);
												continue;
											case 19:
												num3 = ((((CtyInfo)obj6).Cty == ႰႥ.Ⴅ(8, 'æ', 952620255)) ? 17 : 18);
												continue;
											case 18:
												num3 = ((!((obj6 as CtyInfo).Cty == ReplyMailHelp.Ⴄ(7, null, 1057162232, 6))) ? (ⴀႣ[5] - 60134) : 17);
												continue;
											case 17:
												callbookData = om.Ⴀ().UsVeCallbook.Search((string)cloneable);
												num3 = (((CallbookData)callbookData != null) ? 1 : ⴄႤ[47]);
												continue;
											case 1:
												obj5 = CallBlockCacheCfg.Ⴅ(null, 7, 62057575, null) + Ⴅ(callbookData as CallbookData);
												num3 = 13;
												continue;
											case 13:
											{
												TextWriter obj3 = disposable as TextWriter;
												object obj4 = new string[9];
												(obj4 as string[])[0] = (callbookData as CallbookData).Call;
												(obj4 as string[])[1] = ShowWxHelp.Ⴍ('}', 985808779, 6);
												(obj4 as string[])[2] = Ⴃ(((CallbookData)callbookData).FirstName);
												(obj4 as string[])[3] = ShowWxHelp.Ⴍ('\u0090', 985808776, 5);
												(obj4 as string[])[4] = ((CallbookData)callbookData).State;
												(obj4 as string[])[5] = ShowWxHelp.Ⴍ('Q', 985808781, 0);
												(obj4 as string[])[6] = (callbookData as CallbookData).State;
												(obj4 as string[])[7] = ShowWxHelp.Ⴍ('Y', 985808773, 8);
												((string[])obj4)[8] = (string)obj5;
												obj3.WriteLine(string.Concat((string[])obj4));
												break;
											}
											case 12:
												break;
											}
											break;
										}
										cloneable = ((StreamReader)obj2).ReadLine();
									}
									catch (Exception ex)
									{
										_ = ex.Message;
									}
									break;
								case 0:
								case 5:
									goto end_IL_0a69;
								}
								goto IL_0a66;
								IL_0a94:
								num2 = 0;
								continue;
								end_IL_0a69:
								break;
							}
							break;
						}
					}
					finally
					{
						int num4 = 6;
						while (true)
						{
							int num5;
							switch (num4)
							{
							default:
								num5 = (((FileStream)obj == null) ? 4 : 2);
								goto IL_0acb;
							case 2:
								((IDisposable)(FileStream)obj).Dispose();
								break;
							case 1:
							case 4:
								break;
							}
							break;
							IL_0acb:
							num4 = num5;
						}
					}
					switch (0)
					{
					default:
						((TextWriter)disposable).Close();
						break;
					case 4:
						break;
					}
					break;
				}
				}
				break;
			}
		}
		catch (Exception ex2)
		{
			_ = ex2.Message;
		}
		switch (1)
		{
		}
	}

	private string Ⴅ(CallbookData P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		while (true)
		{
			float rng = 0f;
			float brg = 0f;
			BaseXmlSerializer baseXmlSerializer = ObjectManager.Instance.Ⴓ();
			while (true)
			{
				IL_005b:
				UtilsLatLon.CalcGeodesic(ႰႰ.Ⴅ(ShowConnectsHelp.Ⴍ(((ArcConnect)baseXmlSerializer).Cfg, 471, 449), 718, 'ʀ'), ByeHelp.Ⴅ(ShowConnectsHelp.Ⴍ(((ArcConnect)baseXmlSerializer).Cfg, 181, 163), 'ú', 187), SetStationLatLon.Ⴓ(P_0, 383, 'ċ'), P_0.Lon, ref rng, ref brg);
				char num = ⴃႥ[161];
				IpLockoutCacheCfg.ႭႭ[233] = (char)((IpLockoutCacheCfg.ႭႭ[233] ^ IpLockoutCacheCfg.ႭႭ[230]) & 0x35);
				int num2 = num - 60129;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = ⴍႤ[70] - 4000;
						continue;
					case 5:
						break;
					case 4:
						goto IL_005b;
					case 0:
					case 3:
						return brg.ToString(SetTalkCount.Ⴗ(7, null, 1267022362, typeof(ႳႷ)));
					}
					break;
				}
				break;
			}
		}
	}

	private string Ⴃ(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		while (true)
		{
			object obj = new char[1];
			((char[])obj)[0] = ' ';
			object obj2 = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, obj as char[], 784, 838);
			while (true)
			{
				IL_0066:
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႥ[280] - 41715;
						continue;
					case 5:
						break;
					case 3:
						goto IL_0066;
					case 2:
						return ((string[])obj2)[0];
					}
					break;
				}
				break;
			}
		}
	}
}
