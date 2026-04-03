using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcDatabase;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.Callbook;

public sealed class VeCallbook
{
	private static readonly ILog m_Ⴅ = SkimmerValidSpot.Ⴐ(ReplyMailHelp.Ⴄ(20, null, 1057168301, 4), 915, 910);

	private readonly string m_Ⴗ;

	private ShowContestStation.Ⴅ Ⴃ = new ShowContestStation.Ⴅ();

	public VeCallbook(string filePath)
	{
		ISerializable serializable = ShowLog.Ⴍ(875, '\u0363');
		this.m_Ⴗ = Path.GetDirectoryName(DxSpotBlockCacheCfg.Ⴃ(serializable as Assembly, 546, 576)) + filePath;
	}

	public void Preload()
	{
		BuildIndex();
	}

	public void Restart()
	{
		object obj = null;
		Ⴃ.Ⴗ = (Dictionary<string, long>)obj;
	}

	public void BuildIndex()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 7;
		long num3 = default(long);
		object obj3 = default(object);
		object obj = default(object);
		int num2 = default(int);
		object obj2 = default(object);
		object obj4 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				num3 = 0L;
				object obj5 = new Dictionary<string, long>();
				Ⴃ.Ⴗ = obj5 as Dictionary<string, long>;
				num = ⴃႰ[166] - 25965;
				break;
			}
			case 1:
				obj3 = new FileStream(ShowUsersHelp.Ⴅ(this.m_Ⴗ, SetStationQth.Ⴍ(null, 1687355303, 7, 15), 418, 492), FileMode.Open, FileAccess.Read);
				num = 11;
				break;
			case 11:
				obj = new StreamReader(obj3 as FileStream, ChatRoomPubCfg.Ⴗ(1019, 'Μ'));
				num2 = 0;
				num = 8;
				break;
			case 4:
				obj2 = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj, 'Ű', 317);
				num3 += CallBlockCacheCfg.Ⴜ(obj2 as string, 946, 979) + 2;
				num = ⴍႤ[275] - 59989;
				break;
			case 2:
				num2++;
				num = 8;
				break;
			case 8:
			case 9:
				num = ((num2 < 4) ? 4 : 3);
				break;
			case 3:
				obj2 = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj, 'ȑ', 604);
				num = 13;
				break;
			case 10:
				obj4 = Ⴗ((string)obj2);
				num = ((CallBlockCacheCfg.Ⴜ((string)obj4, 681, 712) <= 0) ? 12 : (ⴃႠ[306] - 23235));
				break;
			case 15:
				num = (Ⴃ.Ⴗ.ContainsKey((string)obj4) ? ⴅ[365] : 6);
				break;
			case 6:
				Ⴃ.Ⴗ.Add(obj4 as string, num3);
				goto case 12;
			case 12:
				num3 += ((string)obj2).Length + 2;
				goto case 5;
			case 5:
				obj2 = (obj as StreamReader).ReadLine();
				num = 13;
				break;
			case 13:
			case 14:
				num = ((!string.IsNullOrEmpty(obj2 as string)) ? (ⴃႠ[155] - 34034) : 0);
				break;
			case 0:
				((StreamReader)obj).Close();
				return;
			}
		}
	}

	private static string Ⴗ(string P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		while (true)
		{
			int num = ((CallBlockCacheCfg.Ⴜ(P_0, 803, 834) > 6) ? (ⴄႤ[34] - 82) : 6);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႠ[275] - 31806;
					continue;
				case 0:
				case 3:
					break;
				case 6:
					return string.Empty;
				case 2:
				case 5:
					return P_0.Substring(0, 6).Trim();
				}
				break;
			}
		}
	}

	internal CallbookData Ⴍ(string P_0)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		object obj = default(object);
		object veData = default(object);
		while (true)
		{
			int num = ((Ⴃ.Ⴗ != null) ? 3 : 10);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 8;
					continue;
				case 0:
				case 8:
					break;
				case 10:
					LoadIndex();
					num = ⴄႤ[282] - 185;
					continue;
				case 3:
					obj = null;
					num = ((!Ⴃ.Ⴗ.ContainsKey(P_0)) ? (ⴐ[43] - 20) : (ⴐ[184] - 101));
					continue;
				case 5:
				{
					long index = Ⴃ.Ⴗ[P_0];
					veData = GetVeData(ShowUsersHelp.Ⴅ(this.m_Ⴗ, SetStationQth.Ⴍ(null, 1687355302, 6, 10), 434, 508), index);
					num = 6;
					continue;
				}
				case 4:
				case 6:
					num = ((CallBlockCacheCfg.Ⴜ((string)veData, 21, 116) <= 0) ? 2 : (ⴀႳ[291] - 40775));
					continue;
				case 1:
				case 9:
					obj = Ⴓ(veData as string);
					num = 2;
					continue;
				case 2:
					return obj as CallbookData;
				}
				break;
			}
		}
	}

	internal static CallbookData Ⴓ(string P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		object obj = default(object);
		IComparable<string> comparable = default(IComparable<string>);
		object obj2 = default(object);
		IEnumerable enumerable3 = default(IEnumerable);
		IEnumerable<char> enumerable4 = default(IEnumerable<char>);
		while (true)
		{
			IEnumerable enumerable = SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ(P_0, 0, 6, 523, 600), 302, 'Ů');
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႨ[62] - 24121;
					continue;
				case 0:
				case 4:
				case 6:
					break;
				case 5:
					obj = SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ(P_0, 7, 35, 823, 868), 70, '\u0006');
					goto case 7;
				case 7:
					num = ⴀႨ[14] - 1833;
					continue;
				case 2:
					comparable = SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ(P_0, 43, 35, 863, 780), 35, 'c');
					num = 1;
					continue;
				case 1:
					obj2 = SetDxFilter.Ⴀ(SetTalkOutputHelp.Ⴍ(P_0, 79, 70, 79, 28), 284, 'Ŝ');
					num = 9;
					continue;
				case 9:
					enumerable3 = P_0.Substring(150, 35).Trim();
					enumerable4 = P_0.Substring(186, 2).Trim();
					num = 8;
					continue;
				case 8:
				{
					IEnumerable<char> enumerable2 = P_0.Substring(189, 10).Trim();
					return new CallbookData((string)enumerable, obj as string, comparable as string, obj2 as string, enumerable3 as string, (string)enumerable4, enumerable2 as string);
				}
				}
				break;
			}
		}
	}

	internal string Ⴅ(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		object obj3 = default(object);
		IEnumerable enumerable2 = default(IEnumerable);
		object obj2 = default(object);
		while (true)
		{
			object obj = AnnHelp.Ⴈ(ReplyMailHelp.Ⴄ(14, null, 1057164359, 0), Ⴃ.Ⴓ, ReplyMailHelp.Ⴄ(31, null, 1057162489, 8), 333, 'ź');
			int num = 15;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႥ[405] - 45691;
					continue;
				case 12:
				case 19:
					break;
				case 15:
				{
					obj3 = Ⴍ(P_0);
					int num2;
					if (obj3 is CallbookData)
					{
						num2 = 0;
					}
					else
					{
						char num3 = ⴃႥ[146];
						ShowQrzHelp.ႤႤ[535] = (byte)((ShowQrzHelp.ႤႤ[535] | ShowQrzHelp.ႤႤ[63]) & 0x75);
						num2 = num3 - 5427;
					}
					num = num2;
					continue;
				}
				case 0:
					enumerable2 = AnnHelp.Ⴈ(ShowWxHelp.Ⴍ('\u009e', 985806120, 2), ShowDxFilter.Ⴗ((CallbookData)obj3, 686, 'ʳ'), ReplyMailHelp.Ⴄ(28, null, 1057162487, 6), 372, 'Ń');
					num = 9;
					continue;
				case 9:
					obj2 = new string[14];
					(obj2 as string[])[0] = Top100CacheCfg.Ⴄ(obj3 as CallbookData, 327, 380);
					num = ⴀႣ[263] - 56178;
					continue;
				case 7:
					((string[])obj2)[1] = SetTalkCount.Ⴗ(2, null, 1267022529, typeof(SetStationEmail));
					goto case 14;
				case 14:
					num = 5;
					continue;
				case 5:
					(obj2 as string[])[2] = Top100CacheCfg.Ⴄ(obj3 as CallbookData, 456, 500);
					num = ⴄႭ[217] / 5;
					continue;
				case 18:
					((string[])obj2)[3] = SetTalkCount.Ⴗ(8, null, 1267022539, typeof(DxMaintenance));
					num = ⴐ[159] - 201;
					continue;
				case 1:
					((string[])obj2)[4] = ShowDxFilter.Ⴗ((CallbookData)obj3, 494, 'Ǳ');
					num = 11;
					continue;
				case 11:
					((string[])obj2)[5] = CallBlockCacheCfg.Ⴅ(null, 6, 62057696, null);
					num = 17;
					continue;
				case 17:
					(obj2 as string[])[6] = ShowDxFilter.Ⴗ(obj3 as CallbookData, 517, 'ȥ');
					num = ⴃႥ[176] - 54686;
					continue;
				case 21:
					((string[])obj2)[7] = CallBlockCacheCfg.Ⴅ(null, 3, 62057701, null);
					num = 16;
					continue;
				case 16:
					((string[])obj2)[8] = SetDxDefault.Ⴅ(obj3 as CallbookData, 97, 16);
					num = ⴃႠ[299] - 20924;
					continue;
				case 4:
					((string[])obj2)[9] = CallBlockCacheCfg.Ⴅ(null, 5, 62057699, null);
					goto case 10;
				case 10:
					num = ⴃႠ[121] - 18999;
					continue;
				case 6:
					(obj2 as string[])[10] = BadWordCacheCfg.Ⴅ(obj3 as CallbookData, 165, 204);
					num = 3;
					continue;
				case 3:
					(obj2 as string[])[11] = ReplyMailHelp.Ⴄ(9, null, 1057164318, 2);
					num = 2;
					continue;
				case 2:
					((string[])obj2)[12] = (obj3 as CallbookData).Zip;
					((string[])obj2)[13] = ႨႨ.Ⴀ(6, 2, 1157899115);
					num = 13;
					continue;
				case 13:
				{
					IEnumerable enumerable = string.Concat(obj2 as string[]);
					return (obj as string) + (string)enumerable2 + (enumerable as string);
				}
				case 20:
					return (obj as string) + ShowWxHelp.Ⴍ('þ', 985805060, 3);
				}
				break;
			}
		}
	}

	internal string Ⴄ(string P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		while (true)
		{
			object obj = Ⴍ(P_0);
			int num = ((!(obj is CallbookData)) ? (ⴅ[143] - 175) : 3);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴅ[367] - 221;
					continue;
				case 1:
				case 4:
					break;
				case 3:
				case 6:
					return BadWordCacheCfg.Ⴅ((CallbookData)obj, 944, 985);
				case 2:
				case 5:
					return ReplyMailHelp.Ⴄ(24, null, 1057163267, 4);
				}
				break;
			}
		}
	}

	public void WriteIndexFile()
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 3;
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0033;
			case 0:
			case 4:
				obj = new BinaryWriter((FileStream)obj2);
				break;
			case 1:
				break;
			}
			break;
			IL_0033:
			obj2 = SetStationLatLonHelp.Ⴅ(ShowUsersHelp.Ⴅ(this.m_Ⴗ, ReplyMail.Ⴅ(3, 5, 1217941181), 177, 255), '£', 172);
			num = ⴃႰ[156] - ⴃႰ[156];
		}
		Dictionary<string, long>.Enumerator enumerator = Ⴃ.Ⴗ.GetEnumerator();
		try
		{
			int num2 = 5;
			KeyValuePair<string, long> current = default(KeyValuePair<string, long>);
			IConvertible key = default(IConvertible);
			long value = default(long);
			while (true)
			{
				switch (num2)
				{
				default:
					num2 = ⴍႭ[65] - 54283;
					continue;
				case 4:
					current = enumerator.Current;
					key = current.Key;
					goto case 3;
				case 3:
					value = current.Value;
					DeleteMailHelp.Ⴀ(obj as BinaryWriter, key as string, '\r', 73);
					num2 = 8;
					continue;
				case 8:
					SetWwvCountHelp.Ⴍ((BinaryWriter)obj, value, 787, 869);
					break;
				case 7:
					break;
				case 2:
				case 6:
					goto end_IL_009a;
				}
				num2 = (enumerator.MoveNext() ? ⴀႼ[96] : (ⴃႰ[176] - 25988));
				continue;
				end_IL_009a:
				break;
			}
		}
		finally
		{
			switch (4)
			{
			default:
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				break;
			case 2:
				break;
			}
		}
		int num3 = 5;
		while (true)
		{
			switch (num3)
			{
			default:
				((BinaryWriter)obj).Write(ႰႥ.Ⴅ(3, '\u000e', 952621347));
				((BinaryWriter)obj).Write(UtilsCopyright.Copyright);
				goto IL_01bb;
			case 3:
				goto IL_01bb;
			case 0:
				((BinaryWriter)obj).Close();
				break;
			case 1:
				break;
			}
			break;
			IL_01bb:
			num3 = 0;
		}
		(obj2 as FileStream).Close();
	}

	public bool LoadIndex()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		bool result = default(bool);
		Stream stream = default(Stream);
		object obj4 = default(object);
		while (true)
		{
			object obj = new PrecisionTimer();
			ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 436, 501);
			object obj2 = new Dictionary<string, long>();
			Ⴃ.Ⴗ = (Dictionary<string, long>)obj2;
			int num = 6;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 1;
					continue;
				case 1:
				case 5:
					break;
				case 6:
				{
					object fileInfo = GetFileInfo();
					Ⴃ.Ⴓ = (string)fileInfo;
					result = false;
					num = 2;
					continue;
				}
				case 2:
					Ⴃ.Ⴗ.Clear();
					goto case 4;
				case 4:
					stream = null;
					goto case 0;
				case 0:
				{
					object obj3 = null;
					try
					{
						try
						{
							int num2 = 2;
							while (true)
							{
								switch (num2)
								{
								default:
									stream = SetStationGrid.Ⴃ(ShowUsersHelp.Ⴅ(this.m_Ⴗ, ReplyMail.Ⴅ(3, 11, 1217941181), 988, 914), 'õ', 149);
									num2 = ⴄႷ[61] - 8218;
									continue;
								case 3:
									obj3 = new BinaryReader((FileStream)stream);
									obj4 = ShowSun.Ⴜ((BinaryReader)obj3, 386, 'ǌ');
									num2 = 8;
									continue;
								case 1:
								{
									long value = WxHelp.Ⴃ(obj3 as BinaryReader, 703, 687);
									Ⴃ.Ⴗ.Add(obj4 as string, value);
									num2 = ⴃႥ[78] - 62911;
									continue;
								}
								case 0:
								case 4:
								case 5:
									obj4 = ShowSun.Ⴜ((BinaryReader)obj3, 784, '\u035e');
									num2 = 8;
									continue;
								case 7:
								case 8:
									num2 = (ByeHelp.Ⴍ((string)obj4, ႰႥ.Ⴅ(3, '\u009c', 952621347), 315, 339) ? 1 : ⴐ[204]);
									continue;
								case 6:
									result = true;
									break;
								}
								break;
							}
						}
						catch (EndOfStreamException ex)
						{
							VeCallbook.m_Ⴅ.Error(SkimmerSpotBins.Ⴈ((Exception)ex, 735, (short)753));
						}
						catch (Exception ex2)
						{
							VeCallbook.m_Ⴅ.Warn(SkimmerSpotBins.Ⴈ(ex2, 869, 843));
						}
						switch (4)
						{
						}
					}
					finally
					{
						int num3 = 2;
						while (true)
						{
							switch (num3)
							{
							default:
								num3 = (((BinaryReader)obj3 == null) ? 8 : (ⴀႳ[144] - 30568));
								continue;
							case 1:
							case 4:
								((BinaryReader)obj3).Close();
								goto case 0;
							case 0:
							case 8:
								num3 = (((FileStream)stream == null) ? (ⴀႣ[66] - 36088) : 6);
								continue;
							case 5:
							case 6:
								((FileStream)stream).Close();
								break;
							case 3:
								break;
							}
							break;
						}
					}
					int num4 = 2;
					while (true)
					{
						switch (num4)
						{
						default:
							((PrecisionTimer)obj).Stop();
							goto case 1;
						case 1:
							VeCallbook.m_Ⴅ.Info(string.Concat(obj as PrecisionTimer, SetStationClubHelp.Ⴍ(8, 1, 1747260390, null)));
							break;
						case 3:
							break;
						case 4:
							return result;
						}
						num4 = 4;
					}
				}
				}
				break;
			}
		}
	}

	public string GetFileInfo()
	{
		object obj = default(object);
		try
		{
			int num = 3;
			FileSystemInfo fileSystemInfo = default(FileSystemInfo);
			DateTime dateTime = default(DateTime);
			while (true)
			{
				switch (num)
				{
				default:
					fileSystemInfo = new FileInfo(ShowUsersHelp.Ⴅ(this.m_Ⴗ, ReplyMail.Ⴅ(6, 2, 1217941176), 919, 985));
					num = 4;
					continue;
				case 4:
					num = ((!SetTalkDefault.Ⴈ((FileSystemInfo)(fileSystemInfo as FileInfo), (short)116, (short)15)) ? 1 : 2);
					continue;
				case 2:
					dateTime = DxSpotUserHelp.Ⴀ((FileSystemInfo)(FileInfo)fileSystemInfo, 'ʇ', '\u02fb');
					goto case 0;
				case 0:
					obj = ShowStation.Ⴐ(ref dateTime, 351, 356);
					break;
				case 6:
				case 7:
					break;
				case 1:
					throw new FileNotFoundException();
				}
				break;
			}
		}
		catch (FileNotFoundException ex)
		{
			VeCallbook.m_Ⴅ.Warn(SkimmerSpotBins.Ⴈ((Exception)ex, 319, (short)273));
			goto IL_00da;
		}
		catch (Exception ex2)
		{
			VeCallbook.m_Ⴅ.Error((ex2 as Exception).Message);
			goto IL_00da;
		}
		goto IL_0102;
		IL_00da:
		switch (4)
		{
		default:
			return string.Empty;
		case 1:
			break;
		}
		goto IL_0102;
		IL_0102:
		return obj as string;
	}

	public static string GetVeData(string filepath, long index)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		object obj = null;
		object obj2 = null;
		IComparable comparable = default(IComparable);
		try
		{
			try
			{
				int num = 3;
				IComparable comparable2 = default(IComparable);
				while (true)
				{
					switch (num)
					{
					default:
						obj = new FileStream(filepath, FileMode.Open, FileAccess.Read);
						obj2 = new StreamReader(obj as FileStream, ChatRoomPubCfg.Ⴗ(525, 'ɪ'));
						num = 6;
						continue;
					case 6:
						SetDxDefaultHelp.Ⴃ((Stream)(FileStream)obj, index, SeekOrigin.Begin, (short)141, 155);
						comparable2 = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj2, '\u007f', 50);
						num = 5;
						continue;
					case 5:
					case 7:
						ShowQrz.Ⴅ((TextReader)(obj2 as StreamReader), '\u0319', '\u0305');
						ႰႭ.Ⴃ((Stream)(FileStream)obj, 841, '\u0318');
						num = ⴍႭ[115] - 12356;
						continue;
					case 2:
						comparable = comparable2 as string;
						break;
					case 0:
					case 1:
						break;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				VeCallbook.m_Ⴅ.Error(SkimmerSpotBins.Ⴈ(ex as Exception, 895, 849));
				goto IL_012f;
			}
			goto end_IL_0044;
			IL_012f:
			switch (4)
			{
			}
			goto IL_01cb;
			end_IL_0044:;
		}
		finally
		{
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				default:
					num2 = (((StreamReader)obj2 == null) ? 5 : 2);
					continue;
				case 2:
					((StreamReader)obj2).Close();
					goto case 5;
				case 5:
				case 6:
					num2 = (((FileStream)obj == null) ? ⴄႭ[134] : (ⴍႭ[225] - 31550));
					continue;
				case 3:
				case 7:
					(obj as FileStream).Close();
					break;
				case 8:
					break;
				}
				break;
			}
		}
		goto IL_01f3;
		IL_01cb:
		switch (2)
		{
		default:
			return string.Empty;
		case 4:
		case 5:
			break;
		}
		goto IL_01f3;
		IL_01f3:
		return comparable as string;
	}

	public void Arc4CallbookBuild()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		Preload();
		using Dictionary<string, long>.Enumerator enumerator = Ⴃ.Ⴗ.GetEnumerator();
		int num = 4;
		KeyValuePair<string, long> current = default(KeyValuePair<string, long>);
		while (true)
		{
			switch (num)
			{
			case 3:
				current = enumerator.Current;
				goto case 0;
			case 0:
				Ⴀ(current.Value);
				break;
			case 1:
			case 5:
			case 6:
				return;
			}
			num = (enumerator.MoveNext() ? (ⴀႳ[77] - 50335) : 6);
		}
	}

	private void Ⴀ(long P_0)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 0;
		ICloneable veData = default(ICloneable);
		object obj = default(object);
		object obj2 = default(object);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			switch (num)
			{
			default:
				veData = GetVeData(ShowUsersHelp.Ⴅ(this.m_Ⴗ, SetStationQth.Ⴍ(null, 1687355304, 8, 29), 400, 478), P_0);
				goto case 1;
			case 1:
			case 2:
				num = 3;
				continue;
			case 3:
				if (CallBlockCacheCfg.Ⴜ((string)veData, 719, 686) > 0)
				{
					num = 4;
					continue;
				}
				break;
			case 4:
				obj = Ⴓ((string)veData);
				goto case 5;
			case 5:
				if (CallBlockCacheCfg.Ⴜ(ShowDxFilter.Ⴗ((CallbookData)obj, 621, 'ɲ'), 261, 356) > 25)
				{
					num = ⴍႭ[124] - 41300;
					continue;
				}
				goto IL_0112;
			case 6:
				{
					ShowSun.ႰႰ((CallbookData)obj, Clear.Ⴄ(ShowDxFilter.Ⴗ((CallbookData)obj, 23, '\b'), 25, 'ʎ', 'ʦ'), 428, 454);
					goto IL_0112;
				}
				IL_0112:
				try
				{
					int num2 = 2;
					while (true)
					{
						switch (num2)
						{
						default:
							obj2 = new string[15];
							goto case 4;
						case 4:
							(obj2 as string[])[0] = SetTalkCount.Ⴗ(1, null, 1267014689, typeof(SkimmerBandProcessor));
							num2 = 1;
							continue;
						case 1:
							((string[])obj2)[1] = SetStationGrid.Ⴍ(ShowDxFilter.Ⴗ((CallbookData)obj, 277, 'Ĉ'), 877, '\u033f');
							goto case 5;
						case 5:
							num2 = ⴀႳ[144] - 30563;
							continue;
						case 9:
							(obj2 as string[])[2] = ShowWxHelp.Ⴍ('\u0081', 985806182, 0);
							(obj2 as string[])[3] = SetStationGrid.Ⴍ(Top100CacheCfg.Ⴄ((CallbookData)obj, 169, 146), 275, 'Ł');
							num2 = 12;
							continue;
						case 12:
							(obj2 as string[])[4] = ShowWxHelp.Ⴍ('Û', 985806181, 3);
							(obj2 as string[])[5] = SetStationGrid.Ⴍ(ShowDxFilter.Ⴗ((CallbookData)obj, 489, 'Ƕ'), 62, 'l');
							num2 = ⴐ[21];
							continue;
						case 3:
							(obj2 as string[])[6] = ShowWxHelp.Ⴍ('î', 985806190, 8);
							(obj2 as string[])[7] = SetStationGrid.Ⴍ(ShowDxFilter.Ⴗ((CallbookData)obj, 902, 'Φ'), 407, 'ǅ');
							num2 = 13;
							continue;
						case 13:
							((string[])obj2)[8] = ShowWxHelp.Ⴍ('Û', 985806180, 2);
							((string[])obj2)[9] = SetStationGrid.Ⴍ(SetDxDefault.Ⴅ(obj as CallbookData, 496, 385), 9, '[');
							num2 = ⴀႳ[258] - 27291;
							continue;
						case 0:
							((string[])obj2)[10] = ShowWxHelp.Ⴍ('\u008b', 985806176, 6);
							(obj2 as string[])[11] = UtilsSql.ScrubSql(BadWordCacheCfg.Ⴅ(obj as CallbookData, 190, 215));
							num2 = ⴃႰ[114] - 38473;
							continue;
						case 7:
						case 11:
							((string[])obj2)[12] = ShowWxHelp.Ⴍ('\u0087', 985806179, 5);
							(obj2 as string[])[13] = UtilsSql.ScrubSql((obj as CallbookData).Zip);
							num2 = 8;
							continue;
						case 8:
							(obj2 as string[])[14] = ReplyMail.Ⴅ(5, 1, 1217944670);
							enumerable = string.Concat((string[])obj2);
							num2 = ⴃႥ[109] - 17156;
							continue;
						case 6:
							ႨႰ.Ⴗ(CommandType.Text, (string)enumerable);
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					VeCallbook.m_Ⴅ.Warn(ShowSkimCtyHelp.Ⴍ(1216127366, 2, 'S') + (obj as CallbookData).Call + ႰႥ.Ⴅ(4, '®', 952620214) + ex.Message);
				}
				break;
			}
			break;
		}
		switch (1)
		{
		}
	}
}
