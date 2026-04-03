using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.AnnWx;
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
using ArcShared;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public sealed class CtyCache
{
	private static readonly ILog m_Ⴃ;

	private static readonly object m_Ⴍ;

	private ShowUsersHelp.Ⴄ m_Ⴀ = new ShowUsersHelp.Ⴄ();

	public CtyCache()
	{
		object obj = new Dictionary<string, CtyInfo>();
		this.m_Ⴀ.Ⴗ = (Dictionary<string, CtyInfo>)obj;
		object obj2 = new Dictionary<string, CtyInfo>();
		this.m_Ⴀ.Ⴐ = obj2 as Dictionary<string, CtyInfo>;
		Init();
	}

	public void Init()
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		bool flag = false;
		object ⴍ = default(object);
		try
		{
			switch (3)
			{
			default:
				ႨႥ.Ⴍ(ⴍ = CtyCache.m_Ⴍ, ref flag, 367, 358);
				try
				{
					int num = 16;
					object obj = default(object);
					ICloneable cloneable = default(ICloneable);
					object obj2 = default(object);
					TextReader textReader = default(TextReader);
					IEnumerable enumerable = default(IEnumerable);
					while (true)
					{
						switch (num)
						{
						default:
						{
							obj = new PrecisionTimer();
							ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 564, 629);
							int ⴈ2 = 0;
							this.m_Ⴀ.Ⴈ = ⴈ2;
							num = ⴄႷ[23] - 32512;
							continue;
						}
						case 1:
						{
							int ⴀ = 0;
							this.m_Ⴀ.Ⴀ = ⴀ;
							this.m_Ⴀ.Ⴐ.Clear();
							num = ⴃႰ[11] - 51459;
							continue;
						}
						case 4:
						case 10:
						case 15:
						{
							object obj4 = ShowLog.Ⴍ(80, 'X');
							cloneable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)obj4, 606, 572), 627, 'ɦ'), ႰႥ.Ⴅ(5, 'Ú', 952622044), 791, 857);
							num = 12;
							continue;
						}
						case 12:
						{
							obj2 = new List<string>();
							object obj3 = new FileStream((string)cloneable, FileMode.Open, FileAccess.Read);
							textReader = new StreamReader((FileStream)obj3);
							num = 17;
							continue;
						}
						case 17:
							enumerable = SetAnnModeHelp.Ⴐ((TextReader)(textReader as StreamReader), 'ʤ', 745);
							num = 7;
							continue;
						case 18:
						{
							int ⴈ = this.m_Ⴀ.Ⴈ + 1;
							this.m_Ⴀ.Ⴈ = ⴈ;
							num = ⴀႳ[93] - 46482;
							continue;
						}
						case 6:
							num = (SetAnnDefault.Ⴍ((string)enumerable, ႰႥ.Ⴅ(3, 'K', 952620225), 461, 415) ? 5 : (ⴄႷ[69] - 16534));
							continue;
						case 13:
							num = ((CallBlockCacheCfg.Ⴜ(enumerable as string, 492, 397) <= 1) ? (ⴄႭ[297] - 17) : (ⴍႭ[96] - 3351));
							continue;
						case 8:
							num = ((SetStationNeedsHelp.Ⴃ(enumerable as string, 1, 711, 676) == ' ') ? (ⴀႼ[40] - 165) : 0);
							continue;
						case 0:
							num = (((obj2 as List<string>).Count <= 0) ? (ⴀႨ[178] - 32258) : (ⴃႰ[32] - 1120));
							continue;
						case 2:
							Ⴍ(obj2 as List<string>);
							(obj2 as List<string>).Clear();
							goto case 11;
						case 11:
							((List<string>)obj2).Add((string)enumerable);
							goto case 5;
						case 5:
							enumerable = SetAnnModeHelp.Ⴐ((TextReader)(textReader as StreamReader), 'ɤ', 553);
							num = 7;
							continue;
						case 7:
							num = (((string)enumerable != null) ? 18 : 19);
							continue;
						case 19:
							ShowQrz.Ⴅ((TextReader)(textReader as StreamReader), '\u0305', '\u0319');
							Ⴍ(obj2 as List<string>);
							goto case 14;
						case 14:
							num = 3;
							continue;
						case 3:
						{
							ByeHelp.Ⴄ(obj as PrecisionTimer, '\u0368', 827);
							ILog ⴃ = CtyCache.m_Ⴃ;
							Array array = new object[6];
							(array as object[])[0] = (PrecisionTimer)obj;
							(array as object[])[1] = ReplyMailHelp.Ⴄ(27, null, 1057165807, 8);
							((object[])array)[2] = this.m_Ⴀ.Ⴀ.ToString();
							(array as object[])[3] = SetStationQth.Ⴍ(null, 1687354694, 2, 9);
							((object[])array)[4] = this.m_Ⴀ.Ⴈ.ToString();
							((object[])array)[5] = ReplyMailHelp.Ⴄ(14, null, 1057165812, 0);
							ⴃ.Info(string.Concat(array as object[]));
							break;
						}
						}
						break;
					}
				}
				catch (Exception ex)
				{
					CtyCache.m_Ⴃ.Error((ex as Exception).Message);
				}
				switch (4)
				{
				}
				break;
			}
		}
		finally
		{
			int num2 = 5;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 3 : 2);
					goto IL_0481;
				case 0:
				case 2:
					Monitor.Exit(ⴍ);
					break;
				case 3:
				case 4:
				case 6:
					break;
				}
				break;
				IL_0481:
				num2 = num3;
			}
		}
		switch (4)
		{
		}
	}

	private void Ⴍ(IList<string> P_0)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		try
		{
			int num = 15;
			IComparable comparable = default(IComparable);
			object obj = default(object);
			int num2 = default(int);
			Array array2 = default(Array);
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					comparable = Clear.Ⴄ(P_0[0], 69, 'Ų', 'Ś');
					comparable = ShowContestStationHelp.Ⴅ((string)comparable, ShowSkimCtyHelp.Ⴍ(1216134120, 3, 'n'), string.Empty, 301, 'ŵ');
					num = 9;
					continue;
				case 9:
					num = ((SetStationNeedsHelp.Ⴃ(comparable as string, 0, 562, 593) != '*') ? 13 : (ⴄႷ[102] - 5039));
					continue;
				case 16:
					break;
				case 13:
				{
					int ⴀ = this.m_Ⴀ.Ⴀ + 1;
					this.m_Ⴀ.Ⴀ = ⴀ;
					num = ⴃႥ[434] - ⴃႥ[434];
					continue;
				}
				case 0:
					obj = new CtyInfo(P_0[0]);
					num = (this.m_Ⴀ.Ⴐ.ContainsKey(qslinfoSoapClient.Ⴈ((CtyInfo)obj, 'Q', 72)) ? (ⴄႤ[161] - 102) : (ⴀႳ[198] - 8767));
					continue;
				case 10:
					this.m_Ⴀ.Ⴐ.Add(qslinfoSoapClient.Ⴈ((CtyInfo)obj, 'ȕ', 524), obj as CtyInfo);
					goto case 2;
				case 2:
				case 4:
					num2 = 1;
					goto case 6;
				case 6:
				case 18:
					num = ⴄႷ[69] - 16540;
					continue;
				case 14:
				{
					string text = SetDxFilter.Ⴀ(P_0[num2], 893, '\u033d');
					Array array = new char[1];
					(array as char[])[0] = ',';
					array2 = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(text, array as char[], 495, 441);
					num = ⴍႤ[401] - 53835;
					continue;
				}
				case 8:
					num3 = 0;
					num = 1;
					continue;
				case 5:
					num = ((CallBlockCacheCfg.Ⴜ(((string[])array2)[num3], 770, 867) <= 0) ? 12 : 17);
					continue;
				case 17:
				{
					IEnumerable<char> enumerable = ((string[])array2)[num3];
					Ⴃ((string)enumerable, obj as CtyInfo);
					goto case 12;
				}
				case 12:
					num3++;
					num = ⴄႤ[148];
					continue;
				case 1:
					num = ((num3 < (array2 as string[]).Length) ? 5 : 3);
					continue;
				case 3:
					num2++;
					num = 7;
					continue;
				case 7:
					num = ((num2 < P_0.Count) ? (ⴀႳ[227] - 26059) : 11);
					continue;
				case 11:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			CtyCache.m_Ⴃ.Error(ex.Message);
		}
		switch (4)
		{
		}
	}

	private void Ⴃ(string P_0, CtyInfo P_1)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!Ⴈ(P_0)) ? (ⴃႠ[221] - 18805) : 0);
				break;
			case 0:
			case 5:
				P_1 = Ⴀ(P_0, P_1);
				num = 1;
				break;
			case 1:
			case 4:
				P_0 = Ⴅ(P_0);
				try
				{
					int num2 = 2;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = ((!SetAnnDefault.Ⴍ(P_0, ႨႨ.Ⴀ(0, 4, 1157902496), 446, 492)) ? (ⴍႤ[479] - 63046) : (ⴄႤ[6] - 198));
							break;
						case 6:
							num2 = ((CallBlockCacheCfg.Ⴜ(P_0, 276, 373) <= 1) ? (ⴍႤ[322] - 63851) : 0);
							break;
						case 0:
						case 7:
							P_0 = Clear.Ⴄ(P_0, 1, 'ʃ', 'ʫ');
							goto case 4;
						case 4:
							num2 = (this.m_Ⴀ.Ⴗ.ContainsKey(P_0) ? (ⴀႳ[148] - 39098) : (ⴃႠ[288] - 10238));
							break;
						case 3:
							this.m_Ⴀ.Ⴗ.Add(P_0, P_1);
							num2 = ⴄႭ[563] - 148;
							break;
						case 8:
							num2 = ((!this.m_Ⴀ.Ⴐ.ContainsKey(P_0)) ? 1 : 9);
							break;
						case 1:
							this.m_Ⴀ.Ⴐ.Add(P_0, P_1);
							return;
						case 9:
							return;
						}
					}
				}
				catch (Exception ex)
				{
					ILog ⴃ = CtyCache.m_Ⴃ;
					Array array = new object[8];
					((object[])array)[0] = SetTalkCount.Ⴗ(6, null, 1267023622, typeof(ႥႠ));
					(array as object[])[1] = this.m_Ⴀ.Ⴈ;
					((object[])array)[2] = ႰႥ.Ⴅ(5, '\u001e', 952622064);
					(array as object[])[3] = P_0;
					((object[])array)[4] = ReplyMailHelp.Ⴄ(25, null, 1057165701, 5);
					(array as object[])[5] = qslinfoSoapClient.Ⴈ(P_1, 'İ', 297);
					(array as object[])[6] = SetTalkCount.Ⴗ(1, null, 1267022530, typeof(ShowContestStation));
					(array as object[])[7] = ex.Message;
					ⴃ.Error(string.Concat(array as object[]));
					return;
				}
			}
		}
	}

	private string Ⴅ(string P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		while (true)
		{
			object obj = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, new char[6] { '(', '[', '{', '<', '~', ';' }, 643, 725);
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႨ[196] - 23284;
					continue;
				case 1:
				case 2:
					break;
				case 4:
				case 5:
					num = (((obj as string[]).Length <= 1) ? (ⴃႠ[415] - 56646) : 7);
					continue;
				case 7:
					return ((string[])obj)[0];
				case 0:
				case 6:
					return P_0;
				}
				break;
			}
		}
	}

	private CtyInfo Ⴀ(string P_0, CtyInfo P_1)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		while (true)
		{
			object obj = new CtyInfo(P_1);
			obj = Ⴐ(P_0, (CtyInfo)obj);
			while (true)
			{
				IL_0057:
				obj = Ⴍ(P_0, (CtyInfo)obj);
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴄႭ[224] - ⴄႭ[134];
						continue;
					case 6:
						break;
					case 5:
						goto IL_0057;
					case 2:
					case 3:
						obj = Ⴓ(P_0, (CtyInfo)obj);
						obj = Ⴄ(P_0, obj as CtyInfo);
						num = 4;
						continue;
					case 4:
						obj = Ⴗ(P_0, (CtyInfo)obj);
						return (CtyInfo)obj;
					}
					break;
				}
				break;
			}
		}
	}

	private CtyInfo Ⴐ(string P_0, CtyInfo P_1)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		while (true)
		{
			Array array = new char[2];
			(array as char[])[0] = '(';
			(array as char[])[1] = ')';
			object obj = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, array as char[], 970, 924);
			int num = 6;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႳ[26] - 61928;
					continue;
				case 0:
				case 2:
					break;
				case 6:
					num = (((obj as string[]).Length <= 1) ? 1 : (ⴀႼ[33] / 3));
					continue;
				case 3:
					P_1.CqZone = SetAnnModeHelp.Ⴅ(((string[])obj)[1], 'Ϯ', 'γ');
					goto case 1;
				case 1:
				case 4:
				case 7:
					return P_1;
				}
				break;
			}
		}
	}

	private CtyInfo Ⴍ(string P_0, CtyInfo P_1)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		while (true)
		{
			Array array = new char[2];
			(array as char[])[0] = '[';
			((char[])array)[1] = ']';
			object obj = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, (char[])array, 16, 70);
			while (true)
			{
				IL_0065:
				int num = 7;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 5;
						continue;
					case 0:
					case 5:
						break;
					case 1:
						goto IL_0065;
					case 7:
						num = (((obj as string[]).Length <= 1) ? 2 : (ⴄႤ[155] - ⴄႤ[323]));
						continue;
					case 4:
					case 6:
						P_1.ItuZone = SetAnnModeHelp.Ⴅ(((string[])obj)[1], 'ǜ', 'Ɓ');
						goto case 2;
					case 2:
						return P_1;
					}
					break;
				}
				break;
			}
		}
	}

	private CtyInfo Ⴄ(string P_0, CtyInfo P_1)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		Array array2 = default(Array);
		while (true)
		{
			Array array = new char[2];
			(array as char[])[0] = '<';
			(array as char[])[1] = '>';
			object obj = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, (char[])array, 501, 419);
			while (true)
			{
				IL_0084:
				int num = 1;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴐ[21];
						continue;
					case 3:
						break;
					case 2:
						goto IL_0084;
					case 1:
						num = ((((string[])obj).Length <= 1) ? (ⴀႣ[416] - 19738) : 0);
						continue;
					case 0:
					{
						string obj2 = ((string[])obj)[1];
						Array array3 = new char[1];
						(array3 as char[])[0] = '/';
						array2 = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(obj2, (char[])array3, 911, 985);
						goto case 4;
					}
					case 4:
					case 8:
						num = 10;
						continue;
					case 10:
					{
						int num2 = (array2 as string[]).Length;
						DirectoryBulletin.ႠႨ[104] = (DirectoryBulletin.ႠႨ[104] - DirectoryBulletin.ႠႨ[30]) & 0x88;
						num = ((num2 <= 1) ? 5 : 9);
						continue;
					}
					case 9:
						P_1.Latitude = NodeUserCmd.ႳႠ(((string[])array2)[0], 325, 'ļ');
						num = 6;
						continue;
					case 6:
						P_1.Longitude = CtyInfo.ScrubLon(((string[])array2)[1]);
						goto case 5;
					case 5:
						return P_1;
					}
					break;
				}
				break;
			}
		}
	}

	private CtyInfo Ⴓ(string P_0, CtyInfo P_1)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		while (true)
		{
			Array array = new char[2];
			(array as char[])[0] = '{';
			((char[])array)[1] = '}';
			object obj = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, (char[])array, 816, 870);
			int num = ⴃႠ[94] - 56382;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႰ[125] - 57494;
					continue;
				case 0:
				case 7:
					break;
				case 1:
					num = (((obj as string[]).Length <= 1) ? (ⴃႥ[397] - 30643) : 6);
					continue;
				case 2:
				case 6:
					P_1.Continent = SkimmerServerData.ႷႳ((obj as string[])[0], 'ƨ', 412);
					goto case 3;
				case 3:
				case 4:
					return P_1;
				}
				break;
			}
		}
	}

	private CtyInfo Ⴗ(string P_0, CtyInfo P_1)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		while (true)
		{
			Array array = new char[2];
			(array as char[])[0] = '~';
			(array as char[])[1] = '~';
			object obj = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, (char[])array, 34, 116);
			int num = ⴄႷ[21] - 64082;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႷ[2] - 23602;
					continue;
				case 3:
				case 4:
					break;
				case 0:
				case 6:
					num = (((obj as string[]).Length <= 1) ? (ⴐ[2] - 103) : 7);
					continue;
				case 1:
				case 7:
					P_1.TimeOffset = SetDxFilter.Ⴗ((obj as string[])[1], 'Č', 377);
					goto case 5;
				case 5:
					return P_1;
				}
				break;
			}
		}
	}

	private bool Ⴈ(string P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		while (true)
		{
			int num = (ShowTalk.Ⴀ(P_0, ShowWxHelp.Ⴍ(' ', 985806571, 3), 573, 'ɜ') ? 7 : (ⴀႣ[341] - 36648));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴍႤ[276] - 49259;
					continue;
				case 4:
				case 6:
					break;
				case 5:
					num = ((!ShowTalk.Ⴀ(P_0, CallBlockCacheCfg.Ⴅ(null, 5, 62058057, null), 824, '\u0359')) ? 1 : 7);
					continue;
				case 1:
					num = (ShowTalk.Ⴀ(P_0, SetTalkCount.Ⴗ(6, null, 1267017381, typeof(AnnWxSpotClient)), 562, 'ɓ') ? (ⴃႠ[160] - 12972) : 2);
					continue;
				case 2:
				case 8:
					num = (ShowTalk.Ⴀ(P_0, ShowSkimCtyHelp.Ⴍ(1216133151, 3, '«'), 316, 'ŝ') ? 7 : 3);
					continue;
				case 3:
				{
					bool result = P_0.Contains(ႨႨ.Ⴀ(11, 8, 1157899616));
					IpLockoutCacheCfg.ႭႭ[375] = (char)((IpLockoutCacheCfg.ႭႭ[375] | IpLockoutCacheCfg.ႭႭ[25]) & 0x72);
					return result;
				}
				case 7:
					return true;
				}
				break;
			}
		}
	}

	public CtyInfo CtyInfoFromCall(string callsign)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		bool flag = false;
		object ⴍ = default(object);
		object obj = default(object);
		try
		{
			int num = 9;
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴍ = CtyCache.m_Ⴍ, ref flag, 215, 222);
					enumerable = SetDxFilter.Ⴀ(callsign, 938, 'ϫ');
					num = ⴃႥ[15] - 9485;
					continue;
				case 1:
					num = ((!this.m_Ⴀ.Ⴗ.ContainsKey((string)enumerable)) ? 8 : (ⴄႷ[23] - 32507));
					continue;
				case 6:
				case 11:
					obj = this.m_Ⴀ.Ⴗ[(string)enumerable];
					goto IL_0333;
				case 8:
					num = ((!this.m_Ⴀ.Ⴐ.ContainsKey((string)enumerable)) ? 10 : (ⴍႤ[450] - 13509));
					continue;
				case 7:
					obj = this.m_Ⴀ.Ⴐ[(string)enumerable];
					goto IL_0333;
				case 10:
					enumerable = LogEntry.Ⴄ(enumerable as string, '\u02e7', 713);
					goto case 4;
				case 4:
				case 14:
					num = 5;
					continue;
				case 12:
				{
					int num3;
					if (this.m_Ⴀ.Ⴐ.ContainsKey((string)enumerable))
					{
						byte num2 = ⴅ[62];
						DirectoryBulletin.ႠႨ[120] = DirectoryBulletin.ႠႨ[120] & DirectoryBulletin.ႠႨ[86] & 0x1B;
						num3 = num2 - 162;
					}
					else
					{
						num3 = ⴄႤ[504];
					}
					num = num3;
					continue;
				}
				case 3:
					obj = this.m_Ⴀ.Ⴐ[(string)enumerable];
					goto IL_0333;
				case 13:
					enumerable = SetTalkOutputHelp.Ⴍ((string)enumerable, 0, CallBlockCacheCfg.Ⴜ(enumerable as string, 90, 59) - 1, 504, 427);
					num = 5;
					continue;
				case 5:
					num = ((CallBlockCacheCfg.Ⴜ((string)enumerable, 708, 677) > 0) ? (ⴃႥ[26] - 3087) : 2);
					continue;
				case 2:
					break;
				}
				break;
			}
		}
		finally
		{
			int num4 = 2;
			while (true)
			{
				int num5;
				switch (num4)
				{
				default:
					num5 = ((!flag) ? (ⴀႼ[50] - 100) : (ⴀႼ[127] - 35));
					goto IL_029e;
				case 1:
				case 4:
				case 5:
					DxCmdMsgExt.ႨႠ(ⴍ, 'Ʀ', 451);
					break;
				case 0:
					break;
				}
				break;
				IL_029e:
				num4 = num5;
			}
		}
		int num6 = 7;
		while (true)
		{
			int num7;
			switch (num6)
			{
			default:
				num7 = ((!(callsign != ShowWxHelp.Ⴍ('N', 985807202, 1))) ? (ⴄႭ[275] - ⴄႭ[485]) : 4);
				goto IL_02fd;
			case 2:
			case 4:
				CtyCache.m_Ⴃ.Warn(CallBlockCacheCfg.Ⴅ(null, 7, 62055103, null) + callsign);
				goto case 1;
			case 1:
				return null;
			case 3:
			case 6:
				break;
			}
			break;
			IL_02fd:
			num6 = num7;
		}
		goto IL_0333;
		IL_0333:
		return obj as CtyInfo;
	}

	internal string Ⴓ(string P_0)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		bool flag = false;
		object ⴍ = default(object);
		IComparable comparable = default(IComparable);
		try
		{
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴍ = CtyCache.m_Ⴍ, ref flag, 690, 699);
					num2 = ((!this.m_Ⴀ.Ⴐ.ContainsKey(P_0)) ? ⴐ[21] : 0);
					goto IL_008d;
				case 0:
					comparable = SetWxCountHelp.Ⴃ(this.m_Ⴀ.Ⴐ[P_0], 'ʽ', 688);
					break;
				case 2:
					break;
				case 1:
				case 3:
					goto IL_0111;
				}
				break;
				IL_008d:
				num = num2;
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
					num4 = ((!flag) ? (ⴄႤ[356] - ⴄႤ[356]) : (ⴀႣ[361] - 48466));
					goto IL_00f3;
				case 3:
					Monitor.Exit(ⴍ);
					break;
				case 0:
				case 1:
					break;
				}
				break;
				IL_00f3:
				num3 = num4;
			}
		}
		goto IL_0135;
		IL_0111:
		switch (0)
		{
		default:
			return string.Empty;
		case 1:
		case 3:
		case 4:
			break;
		}
		goto IL_0135;
		IL_0135:
		return (string)comparable;
	}

	static CtyCache()
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 2:
				CtyCache.m_Ⴍ = new object();
				return;
			case 1:
			case 4:
				return;
			}
			CtyCache.m_Ⴃ = SkimmerValidSpot.Ⴐ(CallBlockCacheCfg.Ⴅ(null, 4, 62056250, null), 938, 951);
			num = 2;
		}
	}
}
