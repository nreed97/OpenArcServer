using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.Node.Pc;
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
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.Callbook;

public sealed class UsCallbook
{
	public class IndexRecord
	{
		private long m_Ⴃ;

		private NodeUserCmd.Ⴃ m_Ⴅ = new NodeUserCmd.Ⴃ();

		[SpecialName]
		internal long Ⴅ()
		{
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			return this.m_Ⴅ.Ⴈ;
		}

		[SpecialName]
		internal void Ⴃ(long P_0)
		{
			this.m_Ⴅ.Ⴈ = P_0;
			ႨႣ.Ⴐ[366] = (byte)((ႨႣ.Ⴐ[366] - ShowSunHelp.ႣႠ[414]) & 0x55);
		}

		[SpecialName]
		internal long Ⴓ()
		{
			return this.m_Ⴅ.Ⴄ;
		}

		[SpecialName]
		internal void Ⴄ(long P_0)
		{
			this.m_Ⴅ.Ⴄ = P_0;
		}

		[SpecialName]
		internal long Ⴄ()
		{
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			return this.m_Ⴃ;
		}

		[SpecialName]
		internal void Ⴈ(long P_0)
		{
			this.m_Ⴃ = P_0;
		}
	}

	private static readonly ILog m_Ⴐ = SkimmerValidSpot.Ⴐ(ShowSkimCtyHelp.Ⴍ(1216133094, 0, '\u0097'), 584, 597);

	private readonly CallBookExtCache m_Ⴀ;

	public Dictionary<string, IndexRecord> _aFccIndex;

	public Dictionary<string, IndexRecord> _nFccIndex;

	public Dictionary<string, IndexRecord> _kFccIndex;

	public Dictionary<string, IndexRecord> _wFccIndex;

	private string m_Ⴄ;

	private SkimmerServerData.Ⴜ m_Ⴃ;

	[SpecialName]
	internal void Ⴄ(string P_0)
	{
		this.m_Ⴄ = P_0;
	}

	[SpecialName]
	internal string Ⴀ()
	{
		return this.m_Ⴄ;
	}

	internal void Ⴅ()
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 7:
				LoadIndexFile(ref _aFccIndex, ႨႨ.Ⴀ(6, 0, 1157904899));
				num = ⴅ[118] - 59;
				continue;
			case 1:
			case 6:
				LoadIndexFile(ref _nFccIndex, ReplyMailHelp.Ⴄ(6, null, 1057164470, 5));
				goto case 0;
			case 0:
				num = ⴃႰ[125] - 57499;
				continue;
			case 2:
				LoadIndexFile(ref _kFccIndex, SetStationClubHelp.Ⴍ(2, 4, 1747263025, null));
				num = 5;
				continue;
			case 3:
			case 5:
				LoadIndexFile(ref _wFccIndex, SetTalkCount.Ⴗ(3, null, 1267019163, typeof(UserCacheCfg)));
				return;
			}
			_aFccIndex = new Dictionary<string, IndexRecord>();
			_nFccIndex = new Dictionary<string, IndexRecord>();
			_kFccIndex = new Dictionary<string, IndexRecord>();
			_wFccIndex = new Dictionary<string, IndexRecord>();
			num = ⴐ[177] / 5;
		}
	}

	public void Restart()
	{
		_aFccIndex = null;
		_nFccIndex = null;
		_kFccIndex = null;
		_wFccIndex = null;
	}

	public UsCallbook(CallBookExtCache callBookExtCache, string filePath)
	{
		ISerializable serializable = ShowLog.Ⴍ(988, 'ϔ');
		IComparable<string> comparable = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)serializable, 111, 13), 163, '¶'), filePath, 329, 263);
		this.m_Ⴃ.Ⴍ = (string)comparable;
		this.m_Ⴀ = callBookExtCache;
	}

	public void BuildIndexes()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				_aFccIndex = new Dictionary<string, IndexRecord>();
				goto IL_002d;
			case 4:
				goto IL_002d;
			case 0:
				Ⴈ();
				break;
			case 3:
				break;
			}
			break;
			IL_002d:
			_nFccIndex = new Dictionary<string, IndexRecord>();
			_kFccIndex = new Dictionary<string, IndexRecord>();
			_wFccIndex = new Dictionary<string, IndexRecord>();
			num = ⴃႰ[200] - 13097;
		}
		Ⴓ();
		Ⴗ();
	}

	private void Ⴈ()
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 6;
		object obj = default(object);
		IConvertible convertible = default(IConvertible);
		long num2 = default(long);
		object obj2 = default(object);
		object obj3 = default(object);
		IConvertible convertible2 = default(IConvertible);
		IConvertible convertible3 = default(IConvertible);
		object obj4 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = ShowPrefixCallsHelp.Ⴃ(new FileInfo(ShowUsersHelp.Ⴅ(this.m_Ⴃ.Ⴍ, ႨႨ.Ⴀ(14, 5, 1157904906), 948, 1018)), 356, 278);
				num = ⴐ[257];
				break;
			case 7:
				convertible = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj, '\u00ad', 224);
				goto case 1;
			case 1:
				num2 = 0L;
				num = 9;
				break;
			case 8:
				obj2 = new IndexRecord();
				goto case 12;
			case 12:
				((IndexRecord)obj2).Ⴄ(num2);
				obj3 = (IndexRecord)obj2;
				convertible2 = Ⴗ((string)convertible);
				num = ⴍႤ[65] - 17235;
				break;
			case 0:
				num = ((CallBlockCacheCfg.Ⴜ((string)convertible2, 756, 661) <= 0) ? (ⴀႣ[208] - 49326) : 4);
				break;
			case 4:
				convertible3 = Ⴃ((string)convertible);
				goto case 5;
			case 5:
				num = ((!ByeHelp.Ⴍ((string)convertible3, CallBlockCacheCfg.Ⴅ(null, 1, 62057832, null), 835, 804)) ? (ⴀႨ[195] - 50772) : 10);
				break;
			case 10:
				obj4 = Ⴀ((string)convertible2);
				num = ((obj4 as Dictionary<string, IndexRecord>).ContainsKey(convertible2 as string) ? (ⴀ[144] - 15837) : 2);
				break;
			case 2:
				(obj4 as Dictionary<string, IndexRecord>).Add((string)convertible2, (IndexRecord)obj3);
				goto case 3;
			case 3:
				num2 += ((string)convertible).Length + 2;
				convertible = (obj as StreamReader).ReadLine();
				num = 9;
				break;
			case 9:
				num = (((string)convertible != null) ? (ⴀႼ[92] - ⴀႼ[50]) : 11);
				break;
			case 11:
				(obj as StreamReader).Close();
				return;
			}
		}
	}

	private Dictionary<string, IndexRecord> Ⴀ(string P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		while (true)
		{
			int num = ((!SetAnnDefault.Ⴍ(P_0, CallBlockCacheCfg.Ⴅ(null, 2, 62057835, null), 154, 200)) ? 1 : 8);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႨ[63] - 37860;
					continue;
				case 7:
					break;
				case 8:
					num = ((_aFccIndex != null) ? (ⴃႥ[152] - 55226) : 14);
					continue;
				case 14:
					_aFccIndex = new Dictionary<string, IndexRecord>();
					LoadIndexFile(ref _aFccIndex, ႨႨ.Ⴀ(5, 2, 1157904897));
					num = ⴃႥ[125] - 33357;
					continue;
				case 6:
					return _aFccIndex;
				case 1:
					num = ((!SetAnnDefault.Ⴍ(P_0, ShowWxHelp.Ⴍ('Å', 985806114, 4), 737, 691)) ? (ⴍႤ[73] - 60495) : 11);
					continue;
				case 11:
				case 15:
					num = ((_nFccIndex != null) ? 9 : 16);
					continue;
				case 3:
				case 16:
					_nFccIndex = new Dictionary<string, IndexRecord>();
					LoadIndexFile(ref _nFccIndex, ReplyMailHelp.Ⴄ(8, null, 1057164464, 3));
					num = 9;
					continue;
				case 9:
					return _nFccIndex;
				case 18:
					num = ((!SetAnnDefault.Ⴍ(P_0, ReplyMailHelp.Ⴄ(21, null, 1057162204, 7), 930, 1008)) ? 19 : 20);
					continue;
				case 20:
					num = ((_kFccIndex != null) ? (ⴀႨ[70] - 57246) : 0);
					continue;
				case 0:
					_kFccIndex = new Dictionary<string, IndexRecord>();
					LoadIndexFile(ref _kFccIndex, SetStationClubHelp.Ⴍ(10, 2, 1747263031, null));
					num = 4;
					continue;
				case 4:
					return _kFccIndex;
				case 19:
					num = ((!SetAnnDefault.Ⴍ(P_0, ShowSkimCtyHelp.Ⴍ(1216133065, 0, '~'), 256, 338)) ? (ⴍႤ[285] - 1099) : 10);
					continue;
				case 10:
					num = ((_wFccIndex != null) ? ⴐ[50] : (ⴀ[274] - 55004));
					continue;
				case 17:
					_wFccIndex = new Dictionary<string, IndexRecord>();
					LoadIndexFile(ref _wFccIndex, SetTalkCount.Ⴗ(2, null, 1267019162, typeof(ShowDxFilter)));
					num = 12;
					continue;
				case 12:
					return _wFccIndex;
				case 2:
					UsCallbook.m_Ⴐ.Info(ႰႥ.Ⴅ(5, '\u0084', 952621437) + P_0);
					goto case 13;
				case 13:
					return null;
				}
				break;
			}
		}
	}

	private void Ⴓ()
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 3;
		TextReader textReader = default(TextReader);
		IEnumerable enumerable = default(IEnumerable);
		long num2 = default(long);
		object obj = default(object);
		object obj3 = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				textReader = ShowPrefixCallsHelp.Ⴃ(new FileInfo(ShowUsersHelp.Ⴅ(this.m_Ⴃ.Ⴍ, SetTalkCount.Ⴗ(3, null, 1267019159, typeof(SetDxDefault)), 979, 925)), 579, 561);
				num = 4;
				break;
			case 4:
				enumerable = SetAnnModeHelp.Ⴐ((TextReader)(textReader as StreamReader), 'ʒ', 735);
				num2 = 0L;
				num = 10;
				break;
			case 5:
				obj = Ⴗ(enumerable as string);
				num = ((CallBlockCacheCfg.Ⴜ(obj as string, 803, 834) <= 0) ? ⴐ[204] : 0);
				break;
			case 0:
				obj3 = Ⴀ(obj as string);
				goto case 7;
			case 7:
				num = ((!(obj3 as Dictionary<string, IndexRecord>).ContainsKey((string)obj)) ? 6 : 8);
				break;
			case 8:
				obj2 = ((Dictionary<string, IndexRecord>)obj3)[obj as string];
				goto case 1;
			case 1:
				((IndexRecord)obj2).Ⴃ(num2);
				goto case 6;
			case 6:
				num2 += CallBlockCacheCfg.Ⴜ(enumerable as string, 262, 359) + 2;
				num = 9;
				break;
			case 9:
				enumerable = ((StreamReader)textReader).ReadLine();
				num = 10;
				break;
			case 2:
			case 10:
				num = ((enumerable is string) ? 5 : 11);
				break;
			case 11:
				((StreamReader)textReader).Close();
				return;
			}
		}
	}

	private void Ⴗ()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 8;
		object obj = default(object);
		object obj2 = default(object);
		long num2 = default(long);
		object obj3 = default(object);
		object obj5 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = ShowPrefixCallsHelp.Ⴃ(new FileInfo(ShowUsersHelp.Ⴅ(this.m_Ⴃ.Ⴍ, ShowSkimCtyHelp.Ⴍ(1216133069, 0, 'ò'), 658, 732)), 131, 241);
				num = 4;
				break;
			case 4:
				obj2 = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj, 'Ś', 279);
				goto case 7;
			case 7:
				num2 = 0L;
				num = 11;
				break;
			case 3:
				obj3 = Ⴗ(obj2 as string);
				num = ((CallBlockCacheCfg.Ⴜ(obj3 as string, 365, 268) <= 0) ? 9 : 5);
				break;
			case 5:
				obj5 = Ⴀ(obj3 as string);
				num = ((!((Dictionary<string, IndexRecord>)obj5).ContainsKey((string)obj3)) ? 9 : 10);
				break;
			case 10:
			{
				object obj4 = ((Dictionary<string, IndexRecord>)obj5)[(string)obj3];
				((IndexRecord)obj4).Ⴈ(num2);
				goto case 9;
			}
			case 9:
				num2 += CallBlockCacheCfg.Ⴜ(obj2 as string, 754, 659) + 2;
				goto case 0;
			case 0:
				num = 6;
				break;
			case 6:
				obj2 = (obj as StreamReader).ReadLine();
				num = ⴄႤ[154] - 201;
				break;
			case 11:
				num = (((string)obj2 != null) ? 3 : 2);
				break;
			case 1:
			case 2:
				(obj as StreamReader).Close();
				return;
			}
		}
	}

	private static string Ⴗ(string P_0)
	{
		while (true)
		{
			Array array = new char[1];
			((char[])array)[0] = '|';
			object obj = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, (char[])array, 67, 21);
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 5;
					continue;
				case 1:
				case 3:
				case 5:
					break;
				case 4:
				{
					string result = (obj as string[])[4];
					SetTalkCountHelp.Ⴅ[178] = (byte)((SetTalkCountHelp.Ⴅ[178] ^ SetWxOutput.ႣႰ[181]) & 0xD3);
					return result;
				}
				}
				break;
			}
		}
	}

	private static string Ⴃ(string P_0)
	{
		while (true)
		{
			object obj = new char[1];
			(obj as char[])[0] = '|';
			object obj2 = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, obj as char[], 998, 944);
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 5;
					continue;
				case 5:
					break;
				case 0:
				case 1:
				case 4:
					return ((string[])obj2)[5];
				}
				break;
			}
		}
	}

	internal CallbookData Ⴓ(string P_0)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		object obj4 = default(object);
		IEquatable<string> fccData2 = default(IEquatable<string>);
		IEnumerable<char> fccData = default(IEnumerable<char>);
		IEquatable<string> fccData3 = default(IEquatable<string>);
		object callbookExtensionDat = default(object);
		while (true)
		{
			object obj = null;
			object obj2 = Ⴀ(P_0);
			while (true)
			{
				IL_009d:
				int num = ((!(obj2 is Dictionary<string, IndexRecord>)) ? ⴅ[20] : (ⴅ[135] - 202));
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴄႭ[381] - 219;
						continue;
					case 17:
						break;
					case 12:
					case 16:
						goto IL_009d;
					case 5:
						num = ((!(obj2 as Dictionary<string, IndexRecord>).ContainsKey(P_0)) ? 10 : (ⴄႤ[131] - 193));
						continue;
					case 9:
						obj4 = (obj2 as Dictionary<string, IndexRecord>)[P_0];
						fccData2 = GetFccData(ShowUsersHelp.Ⴅ(this.m_Ⴃ.Ⴍ, SetTalkCount.Ⴗ(0, null, 1267019156, typeof(ArcEngine.ArcCmds.User.Operating.Mail.Directory)), 872, 806), ((IndexRecord)obj4).Ⴅ());
						num = ⴄႤ[494] - 135;
						continue;
					case 2:
						fccData = GetFccData(ShowUsersHelp.Ⴅ(this.m_Ⴃ.Ⴍ, ShowSkimCtyHelp.Ⴍ(1216133067, 6, 'w'), 939, 997), (obj4 as IndexRecord).Ⴄ());
						num = 14;
						continue;
					case 14:
						fccData3 = GetFccData(ShowUsersHelp.Ⴅ(this.m_Ⴃ.Ⴍ, SetStationClubHelp.Ⴍ(14, 0, 1747263009, null), 737, 687), ((IndexRecord)obj4).Ⴓ());
						num = ⴀ[75] - 15108;
						continue;
					case 1:
						num = ((CallBlockCacheCfg.Ⴜ(fccData2 as string, 6, 103) <= 0) ? 10 : 7);
						continue;
					case 7:
						num = ((CallBlockCacheCfg.Ⴜ(fccData as string, 610, 515) <= 0) ? (ⴀႳ[170] - 9995) : 11);
						continue;
					case 11:
					case 13:
						num = ((CallBlockCacheCfg.Ⴜ(fccData3 as string, 425, 456) <= 0) ? (ⴍႭ[366] - 19210) : (ⴍႭ[285] - 5802));
						continue;
					case 3:
						obj = Ⴗ(fccData2 as string, fccData as string, (string)fccData3);
						callbookExtensionDat = this.m_Ⴀ.GetCallbookExtensionDat(LogEntry.Ⴜ(obj as CallbookData, 901, 967));
						num = 8;
						continue;
					case 8:
					{
						CallbookExtensionDat obj3 = (CallbookExtensionDat)callbookExtensionDat;
						Arc4ServerClient.ႠႣ[382] = (char)((Arc4ServerClient.ႠႣ[382] | Arc4ServerClient.ႠႣ[298]) & 0x8D);
						num = ((obj3 == null) ? 10 : (ⴄႤ[157] - 68));
						continue;
					}
					case 15:
						((CallbookData)obj).ArrlSection = (callbookExtensionDat as CallbookExtensionDat).ArrlSection;
						(obj as CallbookData).County = ((CallbookExtensionDat)callbookExtensionDat).County;
						num = 6;
						continue;
					case 6:
						((CallbookData)obj).Grid = ((CallbookExtensionDat)callbookExtensionDat).GridSquare;
						(obj as CallbookData).Lat = ((CallbookExtensionDat)callbookExtensionDat).Lat;
						num = ⴄႤ[310] / 7;
						continue;
					case 4:
						((CallbookData)obj).Lon = ((CallbookExtensionDat)callbookExtensionDat).Lon;
						goto case 10;
					case 10:
						return obj as CallbookData;
					}
					break;
				}
				break;
			}
		}
	}

	private static CallbookData Ⴗ(string P_0, string P_1, string P_2)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		Array array = default(Array);
		Array array2 = default(Array);
		IComparable comparable2 = default(IComparable);
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			object obj = new char[1];
			(obj as char[])[0] = '|';
			object obj2 = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, obj as char[], 586, 540);
			while (true)
			{
				IL_00a7:
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴀႨ[145] - 20398;
						continue;
					case 1:
						break;
					case 6:
					case 9:
						goto IL_00a7;
					case 2:
					{
						object obj3 = new char[1];
						(obj3 as char[])[0] = '|';
						array = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_1, (char[])obj3, 859, 781);
						num = 12;
						continue;
					}
					case 12:
					{
						Array array3 = new char[1];
						((char[])array3)[0] = '|';
						array2 = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_2, array3 as char[], 937, 1023);
						num = ⴐ[257];
						continue;
					}
					case 7:
						num = ((!ByeHelp.Ⴍ((array2 as string[])[5], CallBlockCacheCfg.Ⴅ(null, 1, 62057832, null), 907, 1004)) ? ⴅ[6] : 8);
						continue;
					case 8:
						comparable2 = ((string[])array)[15];
						num = ((CallBlockCacheCfg.Ⴜ((string)comparable2, 698, 731) != 0) ? 11 : 10);
						continue;
					case 4:
					case 10:
						comparable2 = ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216133078, 0, '/'), (array as string[])[19], 207, 129);
						num = ⴄႷ[141] - 32619;
						continue;
					case 11:
						comparable = ((string[])array)[8];
						num = ((CallBlockCacheCfg.Ⴜ((string)comparable, 774, 871) != 0) ? 3 : (ⴃႥ[94] - 31071));
						continue;
					case 5:
						comparable = ((string[])array)[7];
						num = 3;
						continue;
					case 3:
						return new CallbookData((obj2 as string[])[4], (string)comparable, (array as string[])[9], ((string[])array)[10], (string)comparable2, (array as string[])[16], ((string[])array)[17], (array as string[])[18], (obj2 as string[])[5], ((string[])array2)[7], (array2 as string[])[8]);
					case 0:
						return null;
					}
					break;
				}
				break;
			}
		}
	}

	internal string Ⴐ(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		IComparable fccData = default(IComparable);
		Array array = default(Array);
		while (true)
		{
			object obj = Ⴀ(P_0);
			int num = ((!(obj is Dictionary<string, IndexRecord>)) ? 9 : (ⴃႥ[318] - 47519));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 1;
					continue;
				case 1:
				case 10:
					break;
				case 2:
				case 4:
					num = ((!(obj as Dictionary<string, IndexRecord>).ContainsKey(P_0)) ? 9 : (ⴄႭ[492] / 6));
					continue;
				case 6:
				{
					object obj4 = ((Dictionary<string, IndexRecord>)obj)[P_0];
					fccData = GetFccData(ShowUsersHelp.Ⴅ(this.m_Ⴃ.Ⴍ, ShowSkimCtyHelp.Ⴍ(1216133061, 8, '\u0001'), 212, 154), (obj4 as IndexRecord).Ⴄ());
					num = 5;
					continue;
				}
				case 5:
					num = ((CallBlockCacheCfg.Ⴜ(fccData as string, 132, 229) <= 0) ? 9 : (ⴃႠ[360] - 55997));
					continue;
				case 8:
				{
					string obj2 = fccData as string;
					object obj3 = new char[1];
					((char[])obj3)[0] = '|';
					array = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(obj2, obj3 as char[], 731, 653);
					num = ⴍႤ[494] - 40464;
					continue;
				}
				case 3:
					return ((string[])array)[17];
				case 0:
				case 9:
					return ReplyMailHelp.Ⴄ(1, null, 1057163268, 3);
				}
				break;
			}
		}
	}

	internal string Ⴈ(string P_0)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		ICallbookData callbookData = default(ICallbookData);
		Array array2 = default(Array);
		IConvertible convertible2 = default(IConvertible);
		Array array = default(Array);
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			object obj = AnnHelp.Ⴈ(ReplyMailHelp.Ⴄ(28, null, 1057164357, 2), Ⴀ(), ReplyMailHelp.Ⴄ(20, null, 1057162481, 0), 200, 'ÿ');
			int num = ⴍႤ[70] - 3982;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႷ[104] - 12527;
					continue;
				case 5:
					break;
				case 23:
					callbookData = Ⴓ(P_0);
					goto case 25;
				case 25:
				{
					int num2;
					if (callbookData is CallbookData)
					{
						num2 = 15;
					}
					else
					{
						char num3 = ⴍႭ[82];
						BandModeCacheCfg.ႠႳ[309] = (char)((BandModeCacheCfg.ႠႳ[309] - BandModeCacheCfg.ႠႳ[279]) & 0xA7);
						num2 = num3 - 37545;
					}
					num = num2;
					continue;
				}
				case 15:
					array2 = new string[7];
					((string[])array2)[0] = ShowWxHelp.Ⴍ('¾', 985806122, 0);
					num = 6;
					continue;
				case 6:
					(array2 as string[])[1] = ShowDxFilter.Ⴗ(callbookData as CallbookData, 220, 'Á');
					num = 26;
					continue;
				case 26:
					(array2 as string[])[2] = ႰႥ.Ⴅ(5, 'ö', 952621343);
					((string[])array2)[3] = ShowDxFilter.Ⴗ(callbookData as CallbookData, 413, 'ƃ');
					num = 12;
					continue;
				case 12:
					(array2 as string[])[4] = SetStationQth.Ⴍ(null, 1687354371, 7, 9);
					num = ⴄႷ[24] - 27217;
					continue;
				case 11:
					(array2 as string[])[5] = ShowWxOptions.Ⴍ(callbookData as CallbookData, 817, 802);
					num = 4;
					continue;
				case 4:
					(array2 as string[])[6] = ShowSkimCtyHelp.Ⴍ(1216133091, 3, 'c');
					convertible2 = ShowWwv.Ⴈ((string[])array2, 'Η', 1023);
					num = ⴍႤ[313] - 18424;
					continue;
				case 1:
					array = new string[14];
					(array as string[])[0] = Top100CacheCfg.Ⴄ(callbookData as CallbookData, 162, 153);
					num = 10;
					continue;
				case 10:
					((string[])array)[1] = SetTalkCount.Ⴗ(1, null, 1267022530, typeof(ႳႭ));
					num = ⴃႠ[293] - 12934;
					continue;
				case 19:
					((string[])array)[2] = Top100CacheCfg.Ⴄ((CallbookData)callbookData, 145, 173);
					num = ⴅ[379] - 65;
					continue;
				case 0:
					(array as string[])[3] = SetTalkCount.Ⴗ(2, null, 1267022529, typeof(AnnMaintenance));
					num = 13;
					continue;
				case 13:
					(array as string[])[4] = ShowDxFilter.Ⴗ(callbookData as CallbookData, 964, 'ϛ');
					num = 3;
					continue;
				case 3:
					((string[])array)[5] = CallBlockCacheCfg.Ⴅ(null, 8, 62057710, null);
					num = ⴀႳ[144] - 30570;
					continue;
				case 2:
					(array as string[])[6] = ShowDxFilter.Ⴗ(callbookData as CallbookData, 509, 'ǝ');
					num = ⴅ[46];
					continue;
				case 17:
					((string[])array)[7] = CallBlockCacheCfg.Ⴅ(null, 2, 62057700, null);
					num = ⴍႤ[287] - 10676;
					continue;
				case 14:
					(array as string[])[8] = SetDxDefault.Ⴅ(callbookData as CallbookData, 718, 703);
					num = 9;
					continue;
				case 9:
					(array as string[])[9] = CallBlockCacheCfg.Ⴅ(null, 6, 62057696, null);
					num = ⴀ[149] - 54898;
					continue;
				case 18:
				case 24:
					((string[])array)[10] = BadWordCacheCfg.Ⴅ(callbookData as CallbookData, 70, 47);
					num = 16;
					continue;
				case 16:
					((string[])array)[11] = ReplyMailHelp.Ⴄ(5, null, 1057164315, 7);
					num = ⴃႥ[330] - 24836;
					continue;
				case 20:
					((string[])array)[12] = (callbookData as CallbookData).Zip;
					(array as string[])[13] = SetStationClubHelp.Ⴍ(8, 2, 1747263068, null);
					num = ⴀႨ[23] - 24022;
					continue;
				case 7:
					convertible = string.Concat((string[])array);
					goto case 8;
				case 8:
					return (obj as string) + (string)convertible2 + (convertible as string);
				case 21:
					return (string)obj + SetStationQth.Ⴍ(null, 1687354430, 6, 2);
				}
				break;
			}
		}
	}

	public void WriteIndexFiles()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴍ(_aFccIndex, SetStationClubHelp.Ⴍ(7, 6, 1747263057, null));
				num = 3;
				break;
			case 3:
				Ⴍ(_kFccIndex, ShowWxHelp.Ⴍ('ß', 985806096, 1));
				Ⴍ(_nFccIndex, ReplyMailHelp.Ⴄ(11, null, 1057164318, 4));
				goto case 5;
			case 5:
				num = ⴀႨ[155] - 803;
				break;
			case 0:
			case 2:
				Ⴍ(_wFccIndex, ReplyMail.Ⴅ(5, 9, 1217942008));
				return;
			case 1:
				return;
			}
		}
	}

	private void Ⴍ(Dictionary<string, IndexRecord> P_0, string P_1)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 3;
		Stream stream = default(Stream);
		object value = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				stream = SetStationLatLonHelp.Ⴅ(ShowUsersHelp.Ⴅ(this.m_Ⴃ.Ⴍ, P_1, 383, 305), 'Õ', 218);
				break;
			case 0:
			case 2:
				break;
			case 4:
			{
				object obj = new BinaryWriter(stream as FileStream);
				Dictionary<string, IndexRecord>.Enumerator enumerator = P_0.GetEnumerator();
				try
				{
					int num2 = 0;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = 5;
							continue;
						case 4:
						{
							KeyValuePair<string, IndexRecord> current = enumerator.Current;
							IEnumerable<char> key = current.Key;
							value = current.Value;
							DeleteMailHelp.Ⴀ((BinaryWriter)obj, key as string, 'ʱ', 757);
							num2 = 9;
							continue;
						}
						case 6:
						case 9:
							SetWwvCountHelp.Ⴍ(obj as BinaryWriter, (value as IndexRecord).Ⴅ(), 972, 954);
							SetWwvCountHelp.Ⴍ(obj as BinaryWriter, (value as IndexRecord).Ⴄ(), 661, 739);
							num2 = 3;
							continue;
						case 3:
							SetWwvCountHelp.Ⴍ(obj as BinaryWriter, (value as IndexRecord).Ⴓ(), 38, 80);
							break;
						case 2:
						case 5:
						case 7:
							break;
						case 8:
							goto end_IL_0076;
						}
						num2 = (enumerator.MoveNext() ? 4 : 8);
						continue;
						end_IL_0076:
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
					case 3:
						break;
					}
				}
				int num3 = 1;
				while (true)
				{
					switch (num3)
					{
					case 0:
						((BinaryWriter)obj).Close();
						((FileStream)stream).Close();
						return;
					case 4:
						return;
					}
					((BinaryWriter)obj).Write(ႰႥ.Ⴅ(4, 'ü', 952621348));
					((BinaryWriter)obj).Write(UtilsCopyright.Copyright);
					num3 = 0;
				}
			}
			}
			num = ⴀႨ[23] - 24025;
		}
	}

	public bool LoadIndexFile(ref Dictionary<string, IndexRecord> index, string fileName)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		bool result = default(bool);
		ICloneable cloneable = default(ICloneable);
		object obj4 = default(object);
		object obj5 = default(object);
		while (true)
		{
			object obj = new PrecisionTimer();
			ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj, 274, 339);
			Ⴄ(GetFileInfo(fileName));
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 5;
					continue;
				case 5:
					break;
				case 1:
					result = false;
					goto case 0;
				case 0:
				case 2:
				{
					object obj2 = null;
					object obj3 = null;
					try
					{
						try
						{
							int num2 = 5;
							while (true)
							{
								switch (num2)
								{
								default:
									obj2 = SetStationGrid.Ⴃ(ShowUsersHelp.Ⴅ(this.m_Ⴃ.Ⴍ, fileName, 480, 430), 't', 20);
									num2 = 3;
									continue;
								case 3:
									obj3 = new BinaryReader(obj2 as FileStream);
									cloneable = ShowSun.Ⴜ(obj3 as BinaryReader, 348, 'Ē');
									num2 = ⴀႨ[147] - 30830;
									continue;
								case 6:
									obj4 = new IndexRecord();
									goto case 9;
								case 9:
								case 12:
									((IndexRecord)obj4).Ⴃ(WxHelp.Ⴃ((BinaryReader)obj3, 271, 287));
									num2 = 1;
									continue;
								case 1:
									(obj4 as IndexRecord).Ⴈ(WxHelp.Ⴃ(obj3 as BinaryReader, 693, 677));
									(obj4 as IndexRecord).Ⴄ(WxHelp.Ⴃ((BinaryReader)obj3, 1019, 1003));
									num2 = ⴍႭ[143] - 321;
									continue;
								case 2:
								case 4:
								{
									obj5 = obj4 as IndexRecord;
									bool num3 = index.ContainsKey(cloneable as string);
									SetDxCountHelp.ႭႤ[269] = (SetDxCountHelp.ႭႤ[269] * SetDxCountHelp.ႭႤ[80]) & 0x59;
									num2 = (num3 ? 8 : (ⴍႤ[481] - 37700));
									continue;
								}
								case 11:
									index.Add((string)cloneable, (IndexRecord)obj5);
									goto case 8;
								case 8:
									cloneable = ShowSun.Ⴜ(obj3 as BinaryReader, 210, '\u009c');
									num2 = ⴄႭ[94];
									continue;
								case 7:
									num2 = (ByeHelp.Ⴍ(cloneable as string, ႰႥ.Ⴅ(3, '\u0083', 952621347), 707, 683) ? (ⴀ[306] - 20729) : 10);
									continue;
								case 10:
									result = true;
									UsCallbook.m_Ⴐ.Info(string.Concat((PrecisionTimer)obj, ShowContestStationHelp.Ⴅ(fileName, SetTalkCount.Ⴗ(7, null, 1267019146, typeof(DeleteUserPc17)), string.Empty, 329, 'đ'), ReplyMail.Ⴅ(1, 7, 1217941995)));
									break;
								}
								break;
							}
						}
						catch (EndOfStreamException ex)
						{
							UsCallbook.m_Ⴐ.Error((ex as EndOfStreamException).Message);
						}
						catch (Exception ex2)
						{
							UsCallbook.m_Ⴐ.Warn((ex2 as Exception).Message);
						}
						switch (4)
						{
						}
					}
					finally
					{
						int num4 = 8;
						while (true)
						{
							switch (num4)
							{
							default:
								num4 = ((!(obj3 is BinaryReader)) ? 6 : 0);
								continue;
							case 0:
							case 7:
								((BinaryReader)obj3).Close();
								goto case 2;
							case 2:
							case 6:
								num4 = ((!(obj2 is FileStream)) ? (ⴃႠ[56] - 20635) : (ⴀႼ[63] - 71));
								continue;
							case 3:
								((FileStream)obj2).Close();
								break;
							case 4:
								break;
							}
							break;
						}
					}
					switch (4)
					{
					default:
						((PrecisionTimer)obj).Stop();
						return result;
					}
				}
				}
				break;
			}
		}
	}

	public string GetFileInfo(string fileName)
	{
		IComparable<string> comparable = default(IComparable<string>);
		try
		{
			int num = 0;
			object obj = default(object);
			DateTime dateTime = default(DateTime);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new FileInfo(ShowUsersHelp.Ⴅ(this.m_Ⴃ.Ⴍ, fileName, 493, 419));
					goto case 4;
				case 4:
					num = 7;
					continue;
				case 3:
				case 7:
					num = ((!SetTalkDefault.Ⴈ((FileSystemInfo)(FileInfo)obj, (short)713, (short)690)) ? 1 : 2);
					continue;
				case 2:
					dateTime = DxSpotUserHelp.Ⴀ((FileSystemInfo)(FileInfo)obj, 'Ǆ', 'Ƹ');
					goto case 5;
				case 5:
					comparable = ShowStation.Ⴐ(ref dateTime, 879, 852);
					break;
				case 1:
					throw new FileNotFoundException();
				}
				break;
			}
		}
		catch (FileNotFoundException ex)
		{
			UsCallbook.m_Ⴐ.Warn(SkimmerSpotBins.Ⴈ((Exception)ex, 398, (short)416));
			goto IL_00da;
		}
		catch (Exception ex2)
		{
			UsCallbook.m_Ⴐ.Error(ex2.Message);
			goto IL_00da;
		}
		goto IL_0102;
		IL_00da:
		switch (1)
		{
		default:
			return string.Empty;
		case 3:
		case 4:
			break;
		}
		goto IL_0102;
		IL_0102:
		return comparable as string;
	}

	public static string GetFccData(string filepath, long index)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		object obj = null;
		object obj2 = null;
		IComparable<string> comparable2 = default(IComparable<string>);
		try
		{
			try
			{
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						obj = new FileStream(filepath, FileMode.Open, FileAccess.Read);
						break;
					case 1:
						break;
					case 4:
					{
						IComparable<string> comparable = SetAnnModeHelp.Ⴐ((TextReader)(obj2 as StreamReader), '\u0018', 85);
						comparable2 = comparable as string;
						goto end_IL_0051;
					}
					case 0:
					case 5:
						goto end_IL_0051;
					}
					obj2 = new StreamReader((FileStream)obj);
					SetDxDefaultHelp.Ⴃ((Stream)(FileStream)obj, index, SeekOrigin.Begin, (short)544, 566);
					num = 4;
					continue;
					end_IL_0051:
					break;
				}
			}
			catch (Exception ex)
			{
				UsCallbook.m_Ⴐ.Error(SkimmerSpotBins.Ⴈ(ex as Exception, 593, 639));
				goto IL_00e1;
			}
			goto end_IL_004e;
			IL_00e1:
			switch (2)
			{
			}
			goto IL_018a;
			end_IL_004e:;
		}
		finally
		{
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				default:
					num2 = (((StreamReader)obj2 == null) ? (ⴄႷ[48] - 38963) : (ⴀႣ[380] - 26120));
					continue;
				case 3:
					ShowQrz.Ⴅ((TextReader)(obj2 as StreamReader), 'Ǚ', 'ǅ');
					goto case 4;
				case 4:
					num2 = ((obj is FileStream) ? 1 : 8);
					continue;
				case 1:
				case 2:
					(obj as FileStream).Close();
					break;
				case 7:
				case 8:
					break;
				}
				break;
			}
		}
		goto IL_01d1;
		IL_018a:
		switch (4)
		{
		default:
		{
			string empty = string.Empty;
			Arc4ServerClient.ႠႣ[22] = (char)((Arc4ServerClient.ႠႣ[22] + Arc4ServerClient.ႠႣ[131]) & 0x4A);
			return empty;
		}
		case 0:
			break;
		}
		goto IL_01d1;
		IL_01d1:
		return comparable2 as string;
	}

	public void Arc4CallbookBuild()
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		Ⴅ();
		using (Dictionary<string, IndexRecord>.Enumerator enumerator = _aFccIndex.GetEnumerator())
		{
			int num = 3;
			KeyValuePair<string, IndexRecord> current = default(KeyValuePair<string, IndexRecord>);
			while (true)
			{
				switch (num)
				{
				case 0:
					current = enumerator.Current;
					goto case 2;
				case 2:
					Ⴍ(current.Value);
					break;
				case 1:
				case 6:
					goto end_IL_002b;
				}
				num = ((!enumerator.MoveNext()) ? 1 : 0);
				continue;
				end_IL_002b:
				break;
			}
		}
		using (Dictionary<string, IndexRecord>.Enumerator enumerator2 = _nFccIndex.GetEnumerator())
		{
			int num2 = 1;
			KeyValuePair<string, IndexRecord> current2 = default(KeyValuePair<string, IndexRecord>);
			while (true)
			{
				switch (num2)
				{
				case 6:
					current2 = enumerator2.Current;
					goto case 3;
				case 3:
				case 4:
					Ⴍ(current2.Value);
					break;
				case 2:
					goto end_IL_0096;
				}
				num2 = (enumerator2.MoveNext() ? (ⴍႤ[228] - 16935) : (ⴄႤ[301] - 169));
				continue;
				end_IL_0096:
				break;
			}
		}
		using (Dictionary<string, IndexRecord>.Enumerator enumerator3 = _kFccIndex.GetEnumerator())
		{
			int num3 = 1;
			while (true)
			{
				switch (num3)
				{
				case 0:
				case 2:
					Ⴍ(enumerator3.Current.Value);
					break;
				case 4:
					goto end_IL_011b;
				}
				num3 = (enumerator3.MoveNext() ? (ⴍႭ[285] - 5805) : (ⴄႤ[6] - 200));
				continue;
				end_IL_011b:
				break;
			}
		}
		using (Dictionary<string, IndexRecord>.Enumerator enumerator4 = _wFccIndex.GetEnumerator())
		{
			int num4 = 5;
			KeyValuePair<string, IndexRecord> current3 = default(KeyValuePair<string, IndexRecord>);
			while (true)
			{
				switch (num4)
				{
				case 2:
				case 3:
					current3 = enumerator4.Current;
					goto case 0;
				case 0:
				case 4:
					Ⴍ(current3.Value);
					break;
				case 6:
					goto end_IL_019c;
				}
				num4 = (enumerator4.MoveNext() ? 3 : (ⴄႤ[363] - ⴄႤ[129]));
				continue;
				end_IL_019c:
				break;
			}
		}
		Ⴄ();
	}

	private void Ⴄ()
	{
		try
		{
			int num = 5;
			ICloneable cloneable = default(ICloneable);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					ႨႰ.Ⴗ(CommandType.Text, cloneable as string);
					goto end_IL_0003;
				}
				string text = ShowWxHelp.Ⴍ(';', 985806087, 8);
				DateTime dateTime = ShowAnnHelp.Ⴅ('à', 209);
				cloneable = AnnHelp.Ⴈ(text, ShowAnnOptionsHelp.Ⴗ(ref dateTime, SetStationQth.Ⴍ(null, 1687354404, 4, 9), 365, 361), ႨႨ.Ⴀ(15, 0, 1157903557), 930, 'Ε');
				num = 1;
				continue;
				end_IL_0003:
				break;
			}
		}
		catch (Exception ex)
		{
			UsCallbook.m_Ⴐ.Warn(SetTalkCount.Ⴗ(8, null, 1267019148, typeof(ႨႼ)) + ex.Message);
		}
		switch (0)
		{
		}
	}

	private void Ⴍ(IndexRecord P_0)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 2;
		IComparable<string> fccData = default(IComparable<string>);
		IConvertible fccData2 = default(IConvertible);
		IEnumerable<char> fccData3 = default(IEnumerable<char>);
		object obj = default(object);
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			switch (num)
			{
			default:
				fccData = GetFccData(ShowUsersHelp.Ⴅ(this.m_Ⴃ.Ⴍ, SetTalkCount.Ⴗ(3, null, 1267019159, typeof(SetAnnChatRoomsHelp)), 517, 587), P_0.Ⴅ());
				num = ⴃႥ[113] - 53019;
				continue;
			case 8:
				fccData2 = GetFccData(ShowUsersHelp.Ⴅ(this.m_Ⴃ.Ⴍ, ShowSkimCtyHelp.Ⴍ(1216133067, 6, 'K'), 314, 372), P_0.Ⴄ());
				num = ⴐ[204];
				continue;
			case 6:
				fccData3 = GetFccData(ShowUsersHelp.Ⴅ(this.m_Ⴃ.Ⴍ, SetStationClubHelp.Ⴍ(13, 5, 1747263012, null), 592, 542), P_0.Ⴓ());
				goto case 5;
			case 5:
				num = 3;
				continue;
			case 3:
				if (CallBlockCacheCfg.Ⴜ((string)fccData, 951, 982) > 0)
				{
					num = 1;
					continue;
				}
				break;
			case 1:
				if (CallBlockCacheCfg.Ⴜ((string)fccData2, 220, 189) > 0)
				{
					num = ⴄႷ[113] - 58467;
					continue;
				}
				break;
			case 0:
			case 4:
				if (CallBlockCacheCfg.Ⴜ(fccData3 as string, 967, 934) > 0)
				{
					num = 9;
					continue;
				}
				break;
			case 7:
			case 9:
			{
				ICallbookData callbookData = Ⴗ((string)fccData, (string)fccData2, fccData3 as string);
				try
				{
					int num2 = 19;
					while (true)
					{
						switch (num2)
						{
						default:
							obj = new string[27];
							(obj as string[])[0] = SetTalkCount.Ⴗ(0, null, 1267016259, typeof(ShowHam));
							num2 = 14;
							continue;
						case 14:
							((string[])obj)[1] = SetStationGrid.Ⴍ(ShowDxFilter.Ⴗ(callbookData as CallbookData, 106, 'w'), 40, 'z');
							num2 = 1;
							continue;
						case 1:
							((string[])obj)[2] = ShowWxHelp.Ⴍ('\u008f', 985806181, 3);
							((string[])obj)[3] = string.Empty;
							num2 = 18;
							continue;
						case 18:
							(obj as string[])[4] = ShowWxHelp.Ⴍ('H', 985806181, 3);
							(obj as string[])[5] = SetStationGrid.Ⴍ(Top100CacheCfg.Ⴄ((CallbookData)callbookData, 867, 856), 242, '\u00a0');
							num2 = 5;
							continue;
						case 5:
						case 10:
							((string[])obj)[6] = ShowWxHelp.Ⴍ('\u0017', 985806178, 4);
							(obj as string[])[7] = string.Empty;
							num2 = 9;
							continue;
						case 9:
							(obj as string[])[8] = ShowWxHelp.Ⴍ('ô', 985806181, 3);
							(obj as string[])[9] = SetStationGrid.Ⴍ(ShowDxFilter.Ⴗ(callbookData as CallbookData, 480, 'ǿ'), 755, 'ʡ');
							num2 = 3;
							continue;
						case 3:
							(obj as string[])[10] = ShowWxHelp.Ⴍ('Å', 985806176, 6);
							(obj as string[])[11] = SetStationGrid.Ⴍ(ShowDxFilter.Ⴗ((CallbookData)callbookData, 899, 'Σ'), 304, 'Ţ');
							num2 = 11;
							continue;
						case 11:
							((string[])obj)[12] = ShowWxHelp.Ⴍ('ð', 985806179, 5);
							((string[])obj)[13] = SetStationGrid.Ⴍ(SetDxDefault.Ⴅ(callbookData as CallbookData, 1000, 921), 315, 'ũ');
							num2 = ⴀႼ[100] - 10;
							continue;
						case 8:
							((string[])obj)[14] = ShowWxHelp.Ⴍ('\u0013', 985806177, 7);
							(obj as string[])[15] = SetStationGrid.Ⴍ(BadWordCacheCfg.Ⴅ(callbookData as CallbookData, 906, 995), 99, '1');
							num2 = ⴃႰ[15] - 46733;
							continue;
						case 16:
							(obj as string[])[16] = ShowWxHelp.Ⴍ('î', 985806182, 0);
							goto case 12;
						case 12:
							(obj as string[])[17] = SetStationGrid.Ⴍ(LogEntry.Ⴜ((CallbookData)callbookData, 957, 1023), 735, 'ʍ');
							num2 = 4;
							continue;
						case 4:
							((string[])obj)[18] = ShowWxHelp.Ⴍ('b', 985806178, 4);
							((string[])obj)[19] = SetStationGrid.Ⴍ(ShowWxOptions.Ⴍ(callbookData as CallbookData, 912, 899), 512, 'ɒ');
							num2 = ⴃႠ[141] - ⴃႠ[141];
							continue;
						case 0:
							(obj as string[])[20] = ShowWxHelp.Ⴍ('\t', 985806183, 1);
							((string[])obj)[21] = UtilsSql.ScrubSql(((CallbookData)callbookData).LicenseExpirationDate);
							num2 = 17;
							continue;
						case 17:
							(obj as string[])[22] = ShowWxHelp.Ⴍ('e', 985806182, 0);
							((string[])obj)[23] = string.Empty;
							num2 = ⴄႤ[2] - 205;
							continue;
						case 7:
							((string[])obj)[24] = ShowWxHelp.Ⴍ('®', 985806190, 8);
							((string[])obj)[25] = UtilsSql.ScrubSql((callbookData as CallbookData).LicenseClass);
							goto case 2;
						case 2:
							num2 = ⴀႳ[308] - 13021;
							continue;
						case 15:
							(obj as string[])[26] = ReplyMail.Ⴅ(4, 3, 1217944671);
							cloneable = string.Concat((string[])obj);
							num2 = ⴐ[244] - 85;
							continue;
						case 13:
							ႨႰ.Ⴗ(CommandType.Text, cloneable as string);
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					UsCallbook.m_Ⴐ.Warn(ႨႨ.Ⴀ(3, 4, 1157904958) + (callbookData as CallbookData).Call + ႰႥ.Ⴅ(6, '[', 952620212) + (ex as Exception).Message);
				}
				break;
			}
			}
			break;
		}
		switch (2)
		{
		}
	}
}
