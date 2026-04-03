using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Node.Pc;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User;
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
using ArcEngine.ArcIo.Mirc;
using ArcEngine.ArcIo.ReverseBeacon;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcInterfaces;
using ArcInterfaces.Arcx;
using ArcInterfaces.Io;
using ArcInterfaces.Ui;
using ArcShared;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcObjs;

public sealed class ArcConnect : BaseXmlSerializer
{
	private static readonly ILog m_Ⴃ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(7, null, 1267018847, typeof(MircIo)), 442, 423);

	private ConnectStateType m_Ⴅ;

	private string m_Ⴃ;

	private string m_Ⴗ;

	private string m_Ⴅ;

	private string m_Ⴓ;

	private ArcConnect m_Ⴄ;

	private float m_Ⴍ;

	private PrintDxFilters.Ⴗ ႥႰ;

	public string Call
	{
		get
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			return ႥႰ.Ⴓ;
		}
		set
		{
			ႥႰ.Ⴓ = value as string;
			Ⴃ(ShowQslInfoHelp.Ⴓ(value, 770, 'ͱ'));
		}
	}

	public string Here
	{
		get
		{
			char[] ⴃႰ = SetWxOutput.ႣႰ;
			return ႥႰ.Ⴗ;
		}
		set
		{
			ႥႰ.Ⴗ = value;
		}
	}

	public ConnectStateType ConnectState
	{
		get
		{
			return this.m_Ⴅ;
		}
		set
		{
			this.m_Ⴅ = value;
		}
	}

	public string Cont
	{
		get
		{
			return ႥႰ.Ⴄ;
		}
		set
		{
			ႥႰ.Ⴄ = value as string;
		}
	}

	public string Cty
	{
		get
		{
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			return ႥႰ.Ⴍ;
		}
		set
		{
			ႥႰ.Ⴍ = value;
		}
	}

	public string State
	{
		get
		{
			return this.m_Ⴃ;
		}
		set
		{
			this.m_Ⴃ = value;
		}
	}

	public string SwVersion
	{
		get
		{
			return this.m_Ⴗ;
		}
		set
		{
			this.m_Ⴗ = value;
		}
	}

	public string IpAddress
	{
		get
		{
			string ⴅ = this.m_Ⴅ;
			ShowSunHelp.ႣႠ[281] = (char)((ShowSunHelp.ႣႠ[281] - ShowSunHelp.ႣႠ[176]) & 0x63);
			return ⴅ;
		}
		set
		{
			this.m_Ⴅ = value;
		}
	}

	public Guid Id
	{
		get
		{
			return ႥႰ.Ⴈ;
		}
		set
		{
			ႥႰ.Ⴈ = value;
		}
	}

	public SerializableConcurrentDictionary<Guid, ArcConnect> ArcConnects
	{
		get
		{
			return ႥႰ.Ⴐ;
		}
		set
		{
			ႥႰ.Ⴐ = value;
		}
	}

	[XmlIgnore]
	public ArcUserCfg Cfg
	{
		get
		{
			return ႥႰ.Ⴜ;
		}
		set
		{
			ႥႰ.Ⴜ = value;
		}
	}

	[XmlIgnore]
	public IIoClient Io
	{
		get
		{
			return ႥႰ.ႷႳ;
		}
		set
		{
			ႥႰ.ႷႳ = value as IIoClient;
		}
	}

	[SpecialName]
	internal string Ⴗ()
	{
		string ⴓ = this.m_Ⴓ;
		SetWxOutput.ႣႰ[130] = (char)((SetWxOutput.ႣႰ[130] | SetWxOutput.ႣႰ[120]) & 0x27);
		return ⴓ;
	}

	[SpecialName]
	internal void Ⴐ(string P_0)
	{
		this.m_Ⴓ = P_0;
	}

	[SpecialName]
	internal string Ⴓ()
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		while (true)
		{
			int num = ((!ByeHelp.Ⴍ(Here, ReplyMail.Ⴅ(3, 12, 1217944963), 395, 492)) ? 5 : 0);
			while (true)
			{
				switch (num)
				{
				default:
				{
					/*OpCode not supported: LdMemberToken*/;
					int num2 = ⴍႤ[425];
					SetAnnMode.ႤႭ[417] = (byte)((SetAnnMode.ႤႭ[417] ^ SetAnnMode.ႤႭ[348]) & 0x9F);
					num = num2 - 14662;
					continue;
				}
				case 1:
				case 3:
					break;
				case 2:
				case 4:
				case 5:
					return AnnHelp.Ⴈ(ShowWxHelp.Ⴍ('ó', 985806572, 4), Call, ReplyMailHelp.Ⴄ(30, null, 1057162127, 5), 291, 'Ĕ');
				case 0:
					return Call;
				}
				break;
			}
		}
	}

	[SpecialName]
	internal string Ⴈ()
	{
		return AnnHelp.Ⴈ(Call, ႰႥ.Ⴅ(8, ':', 952620218), Here, 668, 'ʫ');
	}

	[SpecialName]
	internal string Ⴀ()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		string ⴀ = ႥႰ.Ⴀ;
		SetDxCountHelp.ႭႤ[418] = (SetDxCountHelp.ႭႤ[418] * SetAnnChatRooms.Ⴀ[460]) & 0xEE;
		return ⴀ;
	}

	[SpecialName]
	private void Ⴃ(string P_0)
	{
		ႥႰ.Ⴀ = P_0;
	}

	[SpecialName]
	internal bool Ⴃ()
	{
		bool ⴃ = ႥႰ.Ⴃ;
		ShowWwvOptionsHelp.ႣႥ[211] = (char)((ShowWwvOptionsHelp.ႣႥ[211] - ႨႣ.Ⴐ[243]) & 0x8E);
		return ⴃ;
	}

	[SpecialName]
	internal void Ⴀ(bool P_0)
	{
		bool ⴃ = P_0;
		ႥႰ.Ⴃ = ⴃ;
	}

	[SpecialName]
	internal bool Ⴄ()
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		bool ⴅ = ႥႰ.Ⴅ;
		ShowSunHelp.ႣႠ[358] = (char)((ShowSunHelp.ႣႠ[358] ^ ShowSunHelp.ႣႠ[301]) & 2);
		return ⴅ;
	}

	[SpecialName]
	internal void Ⴅ(bool P_0)
	{
		bool ⴅ = P_0;
		ႥႰ.Ⴅ = ⴅ;
	}

	[SpecialName]
	internal ArcConnect Ⴍ()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		return this.m_Ⴄ;
	}

	[SpecialName]
	internal void Ⴓ(ArcConnect P_0)
	{
		this.m_Ⴄ = P_0;
	}

	[SpecialName]
	internal string Ⴐ()
	{
		return ႥႰ.ႷႷ;
	}

	[SpecialName]
	internal void Ⴍ(string P_0)
	{
		ႥႰ.ႷႷ = P_0 as string;
	}

	[SpecialName]
	internal ObjectManager Ⴅ()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		return ႥႰ.ႷႤ;
	}

	[SpecialName]
	internal void Ⴈ(ObjectManager P_0)
	{
		ႥႰ.ႷႤ = P_0;
	}

	[SpecialName]
	internal string Ⴜ()
	{
		return ႥႰ.ႷႭ;
	}

	[SpecialName]
	internal void Ⴄ(string P_0)
	{
		ႥႰ.ႷႭ = P_0 as string;
	}

	[SpecialName]
	internal float ႳႷ()
	{
		return this.m_Ⴍ;
	}

	[SpecialName]
	internal void Ⴗ(float P_0)
	{
		this.m_Ⴍ = P_0;
	}

	internal ArcConnect()
	{
		Id = RevBcnSpot.ႰႭ(337, 'ĩ');
		Ⴐ(string.Empty);
		Cfg = new ArcUserCfg();
		ArcConnects = new SerializableConcurrentDictionary<Guid, ArcConnect>();
		Ⴍ(ReplyMailHelp.Ⴄ(16, null, 1057162481, 0));
		Here = ReplyMail.Ⴅ(2, 3, 1217944962);
		State = string.Empty;
		SwVersion = ႰႥ.Ⴅ(6, 'y', 952623045);
		Ⴄ(ႨႨ.Ⴀ(5, 4, 1157905964));
		Ⴗ(-1f);
	}

	internal ArcConnect(ObjectManager P_0, string P_1)
		: this()
	{
		Ⴈ(P_0);
		Call = P_1;
		object obj = P_0.Ⴀ().ႤႷ().CtyInfoFromCall(Ⴀ());
		if (!(obj is CtyInfo))
		{
			return;
		}
		Cty = qslinfoSoapClient.Ⴈ(obj as CtyInfo, 'ʚ', 643);
		Cont = ShowDxFilter.Ⴈ((CtyInfo)obj, '\u0383', 'ϊ');
		if (ByeHelp.Ⴍ(Cty, ReplyMailHelp.Ⴄ(11, null, 1057162202, 1), 750, 649))
		{
			ICallbookData callbookData = P_0.Ⴀ().UsVeCallbook.Search(Ⴀ());
			if (callbookData is CallbookData)
			{
				State = (callbookData as CallbookData).State;
			}
		}
	}

	internal ArcConnect(ObjectManager P_0, string P_1, string P_2, string P_3, string P_4)
		: this()
	{
		Ⴈ(P_0);
		Call = P_1;
		Cont = P_2;
		Cty = P_3;
		State = P_4;
	}

	internal void Ⴜ(ArcConnect P_0)
	{
		ArcConnects.TryAdd(P_0.Id, P_0);
	}

	internal void ႣႰ(Guid P_0)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = ႣႣ(P_0);
				num = (((ArcConnect)obj == null) ? 2 : (ⴃႰ[192] - 49008));
				continue;
			case 4:
				(obj as ArcConnect).Io.Disconnect();
				goto case 5;
			case 5:
				num = ((Ⴅ().Ⴈ() == null) ? 2 : 3);
				continue;
			case 3:
			case 6:
				Ⴅ().Ⴈ().DeleteLocalConnect(Id);
				break;
			case 2:
				break;
			case 1:
				return;
			}
			break;
		}
		ႣႥ(P_0);
	}

	internal ArcConnect ႣႣ(Guid P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		object enumerator = ArcConnects.GetEnumerator();
		BaseXmlSerializer value = default(BaseXmlSerializer);
		try
		{
			int num = 4;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num)
				{
				case 2:
					current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
					goto case 7;
				case 7:
					num = ((!SetStationGrid.Ⴄ(current.Value.Io.IoCfg.Id, P_0, 114, 117)) ? (ⴍႤ[13] - 58420) : 3);
					continue;
				case 3:
				case 5:
					value = current.Value;
					goto IL_0151;
				default:
					num = ((enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? 2 : (ⴃႰ[80] - 24197));
					continue;
				case 6:
					break;
				}
				break;
			}
		}
		finally
		{
			int num2 = 4;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator != null) ? 1 : 5);
					goto IL_011e;
				case 1:
				case 3:
					((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
					break;
				case 0:
				case 2:
				case 5:
					break;
				}
				break;
				IL_011e:
				num2 = num3;
			}
		}
		switch (1)
		{
		default:
			return null;
		case 0:
		case 3:
		case 4:
			break;
		}
		goto IL_0151;
		IL_0151:
		return value as ArcConnect;
	}

	internal ArcConnect ႣႠ(Guid P_0)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		object enumerator = ArcConnects.GetEnumerator();
		BaseXmlSerializer value = default(BaseXmlSerializer);
		try
		{
			int num = 6;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
					goto case 7;
				case 7:
					num = ((!SetStationGrid.Ⴄ(current.Value.Id, P_0, 745, 750)) ? 2 : (ⴀ[212] - 5825));
					continue;
				case 0:
					value = current.Value;
					goto IL_012b;
				default:
					num = ((enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? 1 : 3);
					continue;
				case 3:
					break;
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
					num3 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 4 : 2);
					goto IL_00f8;
				case 2:
					((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
					break;
				case 1:
				case 4:
					break;
				}
				break;
				IL_00f8:
				num2 = num3;
			}
		}
		switch (3)
		{
		default:
			return null;
		case 0:
		case 4:
			break;
		}
		goto IL_012b;
		IL_012b:
		return (ArcConnect)value;
	}

	internal void ႣႥ(Guid P_0)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		object enumerator = ArcConnects.GetEnumerator();
		try
		{
			int num = 7;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num)
				{
				case 0:
					current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
					goto case 2;
				case 2:
					num = ((!SetStationGrid.Ⴄ(current.Value.Io.IoCfg.Id, P_0, 177, 182)) ? 1 : 5);
					break;
				case 5:
				{
					ArcConnects.TryRemove(current.Key, out var _);
					goto case 6;
				}
				case 6:
					num = 3;
					break;
				default:
					num = ((!((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).MoveNext()) ? (ⴄႷ[135] - 15689) : 0);
					break;
				case 3:
					return;
				}
			}
		}
		finally
		{
			int num2 = 1;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 2 : 4);
					goto IL_00ea;
				case 0:
				case 4:
				case 5:
					(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
					break;
				case 2:
					break;
				}
				break;
				IL_00ea:
				num2 = num3;
			}
		}
	}

	internal void ႣႳ(string P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		object enumerator = ArcConnects.GetEnumerator();
		try
		{
			int num = 0;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
					num = ((current.Value.ConnectState != ConnectStateType.AgwBpqUser) ? 4 : (ⴀႨ[148] - 33948));
					break;
				case 6:
				case 7:
					num = ((!ByeHelp.Ⴍ(current.Value.Call, P_0, 230, 129)) ? 4 : 8);
					break;
				case 8:
				{
					ArcConnects.TryRemove(current.Key, out var _);
					goto case 5;
				}
				case 5:
					num = 3;
					break;
				default:
					num = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).MoveNext() ? 2 : 3);
					break;
				case 3:
					return;
				}
			}
		}
		finally
		{
			int num2 = 2;
			while (true)
			{
				bool num3;
				switch (num2)
				{
				default:
					num3 = enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>;
					goto IL_0101;
				case 1:
				case 4:
				case 5:
					((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
					break;
				case 0:
				case 3:
					break;
				}
				break;
				IL_0101:
				num2 = (num3 ? 1 : 0);
			}
		}
	}

	internal void ႣႭ(string P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		object enumerator = ArcConnects.GetEnumerator();
		try
		{
			int num = 3;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num)
				{
				case 6:
				case 8:
					current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
					num = ((current.Value.ConnectState != ConnectStateType.PcxxUser) ? 1 : (ⴀႨ[224] - 5106));
					break;
				case 4:
					num = ((!ByeHelp.Ⴍ(current.Value.Call, P_0, 644, 739)) ? 1 : (ⴀႨ[4] - 27042));
					break;
				case 2:
				{
					ArcConnects.TryRemove(current.Key, out var _);
					num = ⴐ[171] - 169;
					break;
				}
				default:
					num = ((enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? 6 : 0);
					break;
				case 0:
				case 5:
				case 7:
					return;
				}
			}
		}
		finally
		{
			int num2 = 0;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 1 : 2);
					goto IL_011e;
				case 2:
				case 3:
				case 5:
					((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
					break;
				case 1:
				case 4:
					break;
				}
				break;
				IL_011e:
				num2 = num3;
			}
		}
	}

	internal ArcConnect ႣႨ(string P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		object enumerator = ArcConnects.GetEnumerator();
		object obj = default(object);
		try
		{
			int num = 9;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
				case 7:
					current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
					num = ((!ByeHelp.Ⴍ(current.Value.Call, P_0, 389, 482)) ? (ⴃႠ[221] - 18800) : (ⴀႨ[220] - 56037));
					continue;
				case 3:
				case 5:
					obj = current.Value;
					goto IL_018c;
				case 6:
					obj2 = current.Value.ႣႨ(P_0);
					num = (((ArcConnect)obj2 == null) ? 4 : (ⴍႭ[198] - 65403));
					continue;
				case 8:
					obj = obj2 as ArcConnect;
					goto IL_018c;
				default:
					num = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).MoveNext() ? 2 : 0);
					continue;
				case 0:
					break;
				}
				break;
			}
		}
		finally
		{
			int num2 = 3;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 4 : 5);
					goto IL_0159;
				case 0:
				case 5:
					(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
					break;
				case 1:
				case 4:
					break;
				}
				break;
				IL_0159:
				num2 = num3;
			}
		}
		switch (3)
		{
		default:
			return null;
		case 0:
		case 1:
			break;
		}
		goto IL_018c;
		IL_018c:
		return (ArcConnect)obj;
	}

	internal ArcConnect ႣႤ(string P_0)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
		object value = default(object);
		while (true)
		{
			int num = ((!ByeHelp.Ⴍ(P_0, Call, 511, 408)) ? 5 : 2);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
				case 6:
					break;
				case 2:
					return this;
				case 1:
				case 3:
				case 5:
					{
						object enumerator = ArcConnects.GetEnumerator();
						try
						{
							int num2 = 8;
							while (true)
							{
								switch (num2)
								{
								case 2:
									current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
									num2 = ((current.Value.ConnectState != ConnectStateType.PcxxNode) ? 1 : 6);
									continue;
								case 3:
								case 4:
								case 6:
									num2 = ((!ByeHelp.Ⴍ(current.Value.Call, P_0, 281, 382)) ? ⴄႤ[148] : 5);
									continue;
								case 5:
									value = current.Value;
									break;
								case 0:
									break;
								default:
									num2 = ((enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? 2 : 7);
									continue;
								case 7:
									goto IL_015b;
								}
								break;
							}
						}
						finally
						{
							int num3 = 0;
							while (true)
							{
								int num4;
								switch (num3)
								{
								default:
									num4 = ((enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>) ? 1 : (ⴄႭ[483] - 34));
									goto IL_013e;
								case 1:
								case 2:
								case 3:
								case 5:
									(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
									break;
								case 4:
									break;
								}
								break;
								IL_013e:
								num3 = num4;
							}
						}
						goto IL_017b;
					}
					IL_015b:
					switch (2)
					{
					default:
						return null;
					case 0:
					case 3:
						break;
					}
					goto IL_017b;
					IL_017b:
					return (ArcConnect)value;
				}
				break;
			}
		}
	}

	internal ArcConnect ႣႷ(string P_0)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		object enumerator = ArcConnects.GetEnumerator();
		object value = default(object);
		try
		{
			int num = 0;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num)
				{
				case 6:
					current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
					goto case 5;
				case 5:
				{
					int num3;
					if (current.Value.ConnectState == ConnectStateType.AgwBpqUser)
					{
						char num2 = ⴄႷ[110];
						ႨႣ.Ⴐ[346] = (byte)((ႨႣ.Ⴐ[346] + SetTalkCountHelp.Ⴅ[360]) & 0x79);
						num3 = num2 - 20071;
					}
					else
					{
						num3 = ⴅ[175] - 211;
					}
					num = num3;
					continue;
				}
				case 2:
					num = ((!ByeHelp.Ⴍ(current.Value.Call, P_0, 629, 530)) ? (ⴐ[338] / 8) : (ⴀႳ[15] - 55619));
					continue;
				case 4:
					value = current.Value;
					break;
				case 1:
					break;
				default:
					num = ((enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? 6 : 8);
					continue;
				case 8:
					goto IL_01a8;
				}
				break;
			}
		}
		finally
		{
			int num4 = 3;
			while (true)
			{
				int num5;
				switch (num4)
				{
				default:
					num5 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 5 : (ⴃႠ[52] - 36457));
					goto IL_0195;
				case 1:
				case 2:
				case 4:
					((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
					break;
				case 0:
				case 5:
					break;
				}
				break;
				IL_0195:
				num4 = num5;
			}
		}
		goto IL_01c8;
		IL_01a8:
		switch (1)
		{
		default:
			return null;
		case 3:
		case 4:
			break;
		}
		goto IL_01c8;
		IL_01c8:
		return value as ArcConnect;
	}

	internal string ႣႼ(Guid P_0)
	{
		ArcConnects.TryRemove(P_0, out var _);
		return SetStationQth.Ⴍ(null, 1687354195, 5, 8);
	}

	internal void ႠႰ(string P_0)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 15;
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			default:
				flag = Io.Send(ShowUsersHelp.Ⴅ(P_0, Ⴐ(), 572, 626));
				num = 10;
				break;
			case 10:
			case 14:
				num = (flag ? 16 : 11);
				break;
			case 11:
				Ⴍ().ႣႼ(Id);
				num = 16;
				break;
			case 16:
				num = ((ConnectState != ConnectStateType.TelnetUser) ? 1 : (ⴀႼ[90] - 133));
				break;
			case 3:
			case 13:
				num = ((!Ⴅ().Ⴍ().AppLog.LogTelnetOutboundTraffic) ? 1 : 9);
				break;
			case 1:
				num = ((ConnectState != ConnectStateType.ArxNode) ? 2 : 7);
				break;
			case 7:
				num = (Ⴅ().Ⴍ().AppLog.LogArc6NodeTraffic ? (ⴄႤ[348] - ⴄႤ[345]) : (ⴀႣ[136] - 4214));
				break;
			case 2:
				num = ((ConnectState != ConnectStateType.ArxClient) ? 5 : (ⴍႭ[225] - 31551));
				break;
			case 6:
			case 8:
				num = (Ⴅ().Ⴍ().AppLog.LogArc6ClientTraffic ? 9 : (ⴃႥ[169] - 41821));
				break;
			case 5:
				num = ((ConnectState != ConnectStateType.PcxxNode) ? (ⴃႥ[340] - 59137) : 12);
				break;
			case 12:
				num = (Ⴅ().Ⴍ().AppLog.LogPcxxTraffic ? 9 : 17);
				break;
			case 17:
				num = ((ConnectState != ConnectStateType.AgwBpqUser) ? 4 : 0);
				break;
			case 0:
			{
				bool logAgwBpqTraffic = Ⴅ().Ⴍ().AppLog.LogAgwBpqTraffic;
				DirectoryBulletin.ႠႨ[119] = (DirectoryBulletin.ႠႨ[119] ^ IpLockoutCacheCfg.ႭႭ[58]) & 0x97;
				num = ((!logAgwBpqTraffic) ? 4 : 9);
				break;
			}
			case 9:
				ArcConnect.m_Ⴃ.Info(Call + ReplyMail.Ⴅ(4, 5, 1217944104) + SetDxFilter.Ⴀ(P_0, 16, 'S'));
				return;
			case 4:
				return;
			}
		}
	}

	internal void ႠႣ(List<string> P_0)
	{
		using List<string>.Enumerator enumerator = P_0.GetEnumerator();
		int num = 1;
		IEnumerable<char> current = default(IEnumerable<char>);
		while (true)
		{
			switch (num)
			{
			case 6:
				current = enumerator.Current;
				goto case 0;
			case 0:
			case 4:
				ႠႰ((string)current);
				break;
			case 3:
				return;
			}
			num = (enumerator.MoveNext() ? 6 : 3);
		}
	}

	internal void ႳႳ()
	{
		Ⴅ().Ⴀ().ႨႣ().Ⴐ(this);
	}

	internal void ႳႨ()
	{
		Io.Disconnect();
	}

	public void OnRx(string msg)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 13;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((ConnectState != ConnectStateType.TelnetUser) ? 15 : 0);
				continue;
			case 0:
				num = (Ⴅ().Ⴍ().AppLog.LogTelnetInboundTraffic ? (ⴀႼ[13] - 94) : 15);
				continue;
			case 14:
			case 15:
				num = ((ConnectState != ConnectStateType.ArxNode) ? 9 : 8);
				continue;
			case 8:
				num = (Ⴅ().Ⴍ().AppLog.LogArc6NodeTraffic ? 12 : (ⴀ[452] - 4509));
				continue;
			case 9:
				num = ((ConnectState != ConnectStateType.ArxClient) ? 5 : (ⴍႭ[53] - 47904));
				continue;
			case 6:
				num = (Ⴅ().Ⴍ().AppLog.LogArc6ClientTraffic ? (ⴄႷ[102] - 5043) : 5);
				continue;
			case 5:
			{
				ConnectStateType connectState = ConnectState;
				ShowQrzHelp.ႤႤ[45] = (byte)((ShowQrzHelp.ႤႤ[45] + ႨႣ.Ⴐ[23]) & 0xF5);
				num = ((connectState != ConnectStateType.PcxxNode) ? 7 : ⴅ[92]);
				continue;
			}
			case 11:
				num = (Ⴅ().Ⴍ().AppLog.LogPcxxTraffic ? (ⴄႷ[60] - 11686) : (ⴃႥ[41] - 51150));
				continue;
			case 7:
				num = ((ConnectState != ConnectStateType.AgwBpqUser) ? (ⴀႨ[147] - 30833) : 10);
				continue;
			case 10:
				num = ((!Ⴅ().Ⴍ().AppLog.LogAgwBpqTraffic) ? (ⴄႤ[62] - 229) : 12);
				continue;
			case 12:
				ArcConnect.m_Ⴃ.Info(AnnHelp.Ⴈ(Call, ReplyMail.Ⴅ(7, 4, 1217944107), SetDxFilter.Ⴀ(msg, 476, 'Ɵ'), 450, 'ǵ'));
				break;
			case 4:
				break;
			case 1:
			case 2:
			case 3:
				return;
			}
			int num2;
			switch (Io.IoCfg.Category)
			{
			default:
				num = ⴀႨ[185] - 58117;
				break;
			case IoCategoryType.Server:
				num2 = ((!MailHelper.Ⴅ(SetAnnModeHelp.Ⴓ((object)Io.IoCfg, 911, 'υ'), typeof(ServerIoCfg), 398, 442)) ? (ⴍႭ[171] - 30383) : 6);
				goto IL_028e;
			case IoCategoryType.Client:
				goto IL_03c2;
				IL_03c2:
				num2 = ((!MailHelper.Ⴅ(SetAnnModeHelp.Ⴓ((object)Io.IoCfg, 972, 'Ά'), typeof(ClientIoCfg), 415, 427)) ? (ⴀႣ[83] - 44336) : 4);
				goto IL_028e;
				IL_028e:
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 0:
						break;
					case 6:
						num2 = ReadMail.Ⴃ((ServerIoCfg)Io.IoCfg, 88, 23) switch
						{
							ServerIoType.Telnet => ⴄႭ[217] / 9, 
							ServerIoType.ArxNode => 5, 
							ServerIoType.ArxClient => 5, 
							ServerIoType.PCxx => 8, 
							ServerIoType.AgwBpqTcp => ⴍႤ[88] - 21886, 
							ServerIoType.Arc4Active => 8, 
							ServerIoType.Arc4Passive => 8, 
							_ => 12, 
						};
						continue;
					case 12:
						return;
					case 10:
						OnRxTelnetRfUser(msg);
						return;
					case 8:
						OnRxPcxxServer(msg);
						return;
					case 5:
						ArxProtocol.OnRx(this, msg);
						return;
					case 16:
						return;
					case 3:
						goto IL_03c2;
					case 4:
						num2 = BaseCmd.Ⴓ((ClientIoCfg)Io.IoCfg, '\u001f', 46) switch
						{
							ClientIoType.Ar6Node => ⴍႤ[88] - 21883, 
							ClientIoType.Arc4Active => ⴀႨ[182] - 13146, 
							ClientIoType.Arc4Passive => ⴀႼ[93] - 134, 
							ClientIoType.PCxx => 15, 
							ClientIoType.Telnet => ⴄႭ[347] - 129, 
							ClientIoType.TelnetExtComment => 17, 
							ClientIoType.ReverseBeaconWeb => 18, 
							ClientIoType.Mirc => 2, 
							_ => ⴀႣ[193] - 48189, 
						};
						continue;
					case 9:
						return;
					case 1:
					{
						object obj3 = new ႨႭ(Ⴅ());
						((ႨႭ)obj3).Ⴓ(msg, this);
						return;
					}
					case 13:
					case 19:
						ArxProtocol.OnRx(this, msg);
						return;
					case 11:
						return;
					case 15:
						PcxxClientOnRx(msg);
						return;
					case 17:
						ႠႥ(msg);
						return;
					case 18:
					{
						object obj2 = new RevBcnSpotProcessor();
						((RevBcnSpotProcessor)obj2).ProcessSpots(this, msg);
						ႠႰ(((RevBcnSpotProcessor)obj2).Ⴈ());
						return;
					}
					case 2:
					{
						object obj = new ႨႭ(Ⴅ());
						((ႨႭ)obj).Ⴓ(CallBlockCacheCfg.Ⴅ(null, 5, 62054769, null) + msg, this);
						return;
					}
					case 14:
						return;
					}
					break;
				}
				goto case IoCategoryType.Server;
			}
		}
	}

	public void OnRxPcxxServer(string msg)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 16;
		bool flag = default(bool);
		IConvertible convertible = default(IConvertible);
		IEnumerable<char> pc18Cmd = default(IEnumerable<char>);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				if (!Ⴃ())
				{
					num = ⴍႤ[231] - 55847;
					continue;
				}
				object obj2 = new ႨႭ(Ⴅ());
				(obj2 as ႨႭ).Ⴓ(msg, this);
				return;
			}
			case 3:
				flag = SetAnnDefault.Ⴍ(msg, ႨႨ.Ⴀ(12, 2, 1157904773), 466, 384);
				num = ⴀႳ[288] - 24070;
				continue;
			case 21:
				num = ((!flag) ? (ⴍႤ[300] - 58946) : 0);
				continue;
			case 0:
				msg = ShowContestStationHelp.Ⴅ(msg, ႨႨ.Ⴀ(4, 3, 1157904772), string.Empty, 397, 'Ǖ');
				num = 5;
				continue;
			case 5:
				convertible = SetDxFilter.Ⴀ(SetDxFilter.Ⴀ(msg, 660, '\u02d5'), 702, '\u02fe');
				num = 12;
				continue;
			case 12:
				convertible = SetStationGrid.Ⴍ((string)convertible, 316, 'ů');
				if (ႷႷ.Ⴍ((string)convertible, 816, '\u033d'))
				{
					num = ⴍႭ[85] - 31473;
					continue;
				}
				Login.Ⴍ(this, Io.IoCfg);
				return;
			case 20:
				Call = convertible as string;
				Ⴅ(true);
				ConnectState = ConnectStateType.PcxxNode;
				num = ⴄႤ[139];
				continue;
			case 14:
				num = ((!flag) ? 23 : (ⴅ[321] - 35));
				continue;
			case 6:
				ႠႰ(ႰႥ.Ⴅ(0, '\u0010', 952621065));
				ႠႰ(SetStationQth.Ⴍ(null, 1687354195, 2, 3));
				num = ⴀႼ[113];
				continue;
			case 2:
				ႠႰ(ShowSkimCtyHelp.Ⴍ(1216132570, 7, '+'));
				ႠႰ(ReplyMail.Ⴅ(4, 14, 1217941690));
				num = 17;
				continue;
			case 17:
				ႠႰ(ShowWxHelp.Ⴍ('\'', 985806572, 0));
				ႠႰ(ႰႥ.Ⴅ(5, 'å', 952621082));
				num = ⴃႠ[299] - 20924;
				continue;
			case 4:
				ႠႰ(SetStationQth.Ⴍ(null, 1687354231, 8, 29));
				ႠႰ(ShowSkimCtyHelp.Ⴍ(1216132584, 7, 'A'));
				num = 10;
				continue;
			case 10:
				ႠႰ(ReplyMail.Ⴅ(1, 5, 1217941673));
				goto case 7;
			case 7:
			case 23:
				pc18Cmd = InitPc18.GetPc18Cmd();
				ႠႰ(pc18Cmd as string);
				obj = new LogEntry(Io.IoCfg, Call, ShowSkimCtyHelp.Ⴍ(1216135065, 6, 'g'));
				num = ⴀ[14] - 32160;
				continue;
			case 11:
				ArcConnect.m_Ⴃ.Info(ShowUsersHelp.Ⴅ(ShowWxHelp.Ⴍ('8', 985806538, 8), Call, 898, 972));
				num = ⴄႭ[559] - 17;
				continue;
			case 24:
				ArcConnect.m_Ⴃ.Info(qslinfoResponse.Ⴗ(SetStationQth.Ⴍ(null, 1687353091, 8, 31), Call, ReplyMail.Ⴅ(8, 10, 1217944100), pc18Cmd as string, 258, 'š'));
				num = 18;
				continue;
			case 18:
				Ⴅ().Ⴀ().Ⴐ().Add(obj as LogEntry);
				num = ((!flag) ? 13 : (ⴐ[337] - 117));
				continue;
			case 1:
				num = ((Ⴅ().Ⴈ() == null) ? (ⴍႤ[494] - 40459) : (ⴄႤ[475] - 111));
				continue;
			case 22:
				Ⴅ().Ⴈ().AddLocalConnect(new LocalConnect(Call, Id, UiConnectType.Arc4NodeIn));
				num = 8;
				continue;
			case 13:
			case 19:
				num = ((Ⴅ().Ⴈ() == null) ? 8 : (ⴄႤ[44] - 219));
				continue;
			case 15:
				Ⴅ().Ⴈ().AddLocalConnect(new LocalConnect(Call, Id, UiConnectType.PcxxNodeIn));
				break;
			case 8:
				break;
			case 9:
				return;
			}
			break;
		}
		Ⴀ(true);
	}

	public void PcxxClientOnRx(string msg)
	{
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			case 5:
				if (ShowDxHelp.Ⴀ(msg, 268, 'Ŵ'))
				{
					num = 1;
					continue;
				}
				return;
			case 1:
				Io.Send(ShowUsersHelp.Ⴅ(Io.IoCfg.ConnectAs, ReplyMailHelp.Ⴄ(28, null, 1057162481, 0), 604, 530));
				goto case 2;
			case 2:
				num = 6;
				continue;
			case 6:
			{
				Ⴀ(true);
				IUi ui = Ⴅ().Ⴈ();
				AnnCacheCfg.ႠႼ[14] = (byte)((AnnCacheCfg.ႠႼ[14] - AnnCacheCfg.ႠႼ[39]) & 6);
				if (ui != null)
				{
					num = 7;
					continue;
				}
				return;
			}
			case 0:
			case 3:
			case 7:
				Ⴅ().Ⴈ().AddLocalConnect(new LocalConnect(Call, Id, UiConnectType.PcxxNodeIn));
				return;
			}
			Publisher.ႣႤ(msg, 470, 'ƨ');
			if (!Ⴃ())
			{
				num = 5;
				continue;
			}
			while (true)
			{
				switch (SetAnnDefault.Ⴍ(msg, ႨႨ.Ⴀ(5, 2, 1157905617), 779, 857) ? 1 : 6)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					return;
				case 3:
					continue;
				case 1:
					obj = new ႨႭ(Ⴅ());
					break;
				case 2:
					break;
				case 5:
				case 6:
					return;
				}
				break;
			}
			((ႨႭ)obj).Ⴓ(msg, this);
			return;
		}
	}

	public void OnRxTelnetRfUser(string msg)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 5;
		IEquatable<string> equatable = default(IEquatable<string>);
		object obj = default(object);
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				msg = SetTalkDefault.Ⴃ(msg, 349, 'ų');
				if (!Ⴃ())
				{
					num = ⴃႥ[52] - 46695;
					break;
				}
				goto IL_0409;
			case 4:
				equatable = SetDxFilter.Ⴀ(SetDxFilter.Ⴀ(msg, 215, '\u0096'), 938, 'Ϫ');
				num = ⴄႷ[113] - 58465;
				break;
			case 6:
				if (ShowWwvHelp.Ⴗ((string)equatable, 'ˁ', 743))
				{
					num = ⴀႼ[93] - 132;
					break;
				}
				goto IL_0199;
			case 3:
				ArcConnect.m_Ⴃ.Warn(qslinfoResponse.Ⴗ(SetStationClubHelp.Ⴍ(3, 2, 1747261729, null), Io.EndPoint, ႰႥ.Ⴅ(5, 'ù', 952620215), equatable as string, 57, 'Z'));
				goto case 0;
			case 0:
				num = 1;
				break;
			case 1:
			case 2:
			case 7:
				{
					Io.Disconnect();
					return;
				}
				IL_0133:
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 20:
						return;
					case 19:
						break;
					case 7:
						Call = (string)equatable;
						goto case 12;
					case 12:
						num2 = ((!Ⴅ().Ⴀ().ႤႰ().IsBlocked(ShowQslInfoHelp.Ⴓ(equatable as string, 422, 'Ǖ'))) ? (ⴅ[65] - 219) : (ⴄႷ[4] - 30652));
						continue;
					case 0:
						ArcConnect.m_Ⴃ.Warn(ShowUsersHelp.Ⴅ(ReplyMailHelp.Ⴄ(14, null, 1057164742, 0), Call, 690, 764));
						num2 = 17;
						continue;
					case 17:
						Io.Disconnect();
						return;
					case 4:
					case 14:
						Ⴅ(true);
						Cfg = Ⴅ().Ⴀ().ႨႣ().Ⴃ(this);
						num2 = 16;
						continue;
					case 16:
						ႳႠ();
						ႳႣ();
						Login.Ⴃ(this, Io.IoCfg);
						PcxxNodeUser.Ⴓ(this);
						num2 = ⴄႭ[175] - 154;
						continue;
					case 15:
						obj = new LogEntry(Io.IoCfg, Call, ShowSkimCtyHelp.Ⴍ(1216135063, 8, '\u0015'));
						num2 = 18;
						continue;
					case 18:
						ArcConnect.m_Ⴃ.Info(ShowUsersHelp.Ⴅ(CallBlockCacheCfg.Ⴅ(null, 8, 62054772, null), Call, 533, 603));
						num2 = 3;
						continue;
					case 3:
						Ⴅ().Ⴀ().Ⴐ().Add((LogEntry)obj);
						Ⴀ(true);
						num2 = 2;
						continue;
					case 2:
						num2 = ((Ⴅ().Ⴈ() == null) ? 1 : 9);
						continue;
					case 9:
						Ⴅ().Ⴈ().AddLocalConnect(new LocalConnect(Call, Id, UiConnectType.TelnetIn));
						return;
					case 6:
						num2 = ((!Io.IsConnected) ? 1 : (ⴄႭ[211] - 179));
						continue;
					case 8:
						ArcConnect.m_Ⴃ.Warn(ShowUsersHelp.Ⴅ(ShowSkimCtyHelp.Ⴍ(1216132483, 2, 'ø'), (string)equatable, 28, 82));
						num2 = 5;
						continue;
					case 5:
						Login.Ⴍ(this, Io.IoCfg);
						return;
					case 10:
						goto IL_0409;
					case 11:
						msg = ႨႨ.Ⴀ(0, 1, 1157905618);
						num2 = 13;
						continue;
					case 13:
						msg = ႠႠ(msg);
						Ⴅ().Ⴜ().Ⴗ(msg, this);
						return;
					case 1:
						return;
					}
					break;
				}
				goto IL_0199;
				IL_0199:
				equatable = SetStationGrid.Ⴍ((string)equatable, 504, 'ƫ');
				num2 = ((!ႷႷ.Ⴍ(equatable as string, 708, 'ˉ')) ? (ⴀႳ[203] - 7248) : 7);
				goto IL_0133;
				IL_0409:
				num2 = ((!msg.ToUpper().StartsWith(ႨႨ.Ⴀ(3, 4, 1157905623))) ? (ⴀႳ[191] - 60318) : 11);
				goto IL_0133;
			}
		}
	}

	private void ႳႠ()
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 2:
				SetStationBeepHelp.Ⴅ(ShowAnnOptionsHelp.Ⴃ(Cfg, 176, 202), ShowSkimCtyHelp.Ⴍ(1216132506, 4, '\u0017'), 216, 145);
				goto case 5;
			case 5:
				num = 0;
				continue;
			case 0:
				ArcConnect.m_Ⴃ.Warn(AnnHelp.Ⴈ(SetStationClubHelp.Ⴍ(7, 0, 1747261808, null), Call, SetTalkCount.Ⴗ(8, null, 1267019718, typeof(AddUserPc16)), 926, 'Ω'));
				return;
			case 1:
				return;
			}
			if (ByeHelp.Ⴍ(SetDxFilter.Ⴀ(LogEntry.Ⴄ(ShowSkimmerHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ(Cfg, 20, 110), 298, 312), 'Ͻ', 983), 195, '\u0083'), ReplyMailHelp.Ⴄ(17, null, 1057164684, 3), 283, 380))
			{
				num = 2;
				continue;
			}
			while (true)
			{
				int num2 = (Ⴅ().Ⴀ().Ⴃ().Ⴅ(ShowSkimmerHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ(Cfg, 714, 688), 938, 952)) ? 5 : 0);
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 4:
					case 6:
						break;
					case 0:
						goto IL_0178;
					case 1:
					case 2:
						Cfg.Dx.Filter = ShowSkimCtyHelp.Ⴍ(1216132508, 2, '%');
						return;
					case 3:
					case 5:
						return;
					}
					break;
					IL_0178:
					ArcConnect.m_Ⴃ.Warn(ShowWxHelp.Ⴍ('E', 985806385, 8) + Call + ႰႥ.Ⴅ(7, '\u0018', 952620213) + Cfg.Dx.Filter);
					num2 = ⴀ[406] - 26257;
				}
			}
		}
	}

	private void ႳႣ()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				num = (Ⴅ().Ⴍ().SpotProcessing.EnableCt1bohProcessing ? 6 : (ⴀႳ[48] - 16492));
				break;
			case 8:
				num = ((!SetWwvOutputHelp.Ⴓ(ShowSkimmerHelp.Ⴀ(ShowAnnOptionsHelp.Ⴃ(Cfg, 40, 82), 93, 79), '\u0309', 792)) ? (ⴅ[176] - 223) : 7);
				break;
			case 7:
				SetStationBeepHelp.Ⴅ(ShowAnnOptionsHelp.Ⴃ(Cfg, 985, 931), string.Empty, 799, 854);
				num = 4;
				break;
			case 0:
			case 4:
				ႠႰ(SetTalkCount.Ⴗ(1, null, 1267019711, typeof(SetStationMacros)));
				goto case 5;
			case 5:
				ႠႰ(CallBlockCacheCfg.Ⴅ(null, 5, 62054674, null));
				num = ⴄႭ[52] - 184;
				break;
			case 1:
				ႠႰ(ႨႨ.Ⴀ(10, 6, 1157904777));
				return;
			case 6:
				return;
			}
		}
	}

	private string ႠႠ(string P_0)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num2 = default(int);
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = ((CallBlockCacheCfg.Ⴜ(P_0, 579, 546) <= 0) ? 8 : (ⴀ[405] - 62411));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႣ[236] - ⴀႣ[236];
					continue;
				case 0:
				case 11:
					break;
				case 2:
				case 3:
					num = ((!SetAnnDefaultHelp.Ⴗ(SetStationNeedsHelp.Ⴃ(P_0, 0, 675, 704), 65, 14)) ? ⴐ[243] : (ⴄႤ[538] - 158));
					continue;
				case 7:
					num2 = SetStationLoginCmdsHelp.Ⴗ(SetTalkOutputHelp.Ⴍ(P_0, 0, 1, 459, 408), (IFormatProvider)new CultureInfo(SetStationClubHelp.Ⴍ(6, 7, 1747258246, null)), 'ȣ', (short)533);
					num = 12;
					continue;
				case 12:
					num = ((!ႰႨ.ႥႥ(ႷႷ.Ⴀ(ShowConnectsHelp.Ⴍ(Cfg, 266, 284), 'ů', 373)[num2], 'å', 'Ã')) ? 1 : (ⴄႤ[481] - 168));
					continue;
				case 1:
					cloneable = Cfg.Station.Macros[num2];
					num = ((P_0.Length <= 1) ? (ⴀႳ[233] - 50827) : 4);
					continue;
				case 4:
					num = ((P_0[1] != ' ') ? 6 : (ⴐ[324] - 223));
					continue;
				case 5:
				case 9:
					cloneable = (string)cloneable + P_0.Substring(1);
					num = 6;
					continue;
				case 6:
					return cloneable as string;
				case 8:
					return P_0;
				}
				break;
			}
		}
	}

	private void ႠႥ(string P_0)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 0;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				if (!Ⴃ())
				{
					num = ⴄႤ[272] - 222;
					break;
				}
				goto IL_01ad;
			case 3:
			case 7:
				if (ShowDxHelp.Ⴀ(P_0, 288, 'Ř'))
				{
					num = ⴍႤ[284] - 31690;
					break;
				}
				goto IL_0155;
			case 5:
				Io.Send(ShowUsersHelp.Ⴅ(Io.IoCfg.ConnectAs, ReplyMailHelp.Ⴄ(31, null, 1057162483, 2), 549, 619));
				goto case 4;
			case 4:
				num = ⴄႭ[246];
				break;
			case 2:
				Ⴀ(true);
				if (Ⴅ().Ⴈ() != null)
				{
					num = 6;
					break;
				}
				return;
			case 6:
				Ⴅ().Ⴈ().AddLocalConnect(new LocalConnect(Call, Id, UiConnectType.SpotSuckerOut));
				return;
			case 1:
				return;
				IL_01ad:
				num2 = (ႰႨ.ႥႥ(Io.IoCfg.Password, 'ΐ', 'ζ') ? 10 : (ⴀႼ[87] - ⴀႼ[74]));
				goto IL_0117;
				IL_0117:
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 8:
						break;
					case 4:
					case 9:
						Io.IoCfg.ConnectAs = ShowQslInfoHelp.Ⴓ(Io.IoCfg.ConnectAs, 494, 'Ɲ');
						return;
					case 0:
						goto IL_01ad;
					case 11:
						num2 = ((!ShowTalk.Ⴀ(LogEntry.Ⴄ(P_0, 'ό', 998), SetTalkCount.Ⴗ(2, null, 1267018862, typeof(DirectorySubjectHelp)), 334, 'į')) ? 10 : 3);
						continue;
					case 3:
						Io.Send(ShowUsersHelp.Ⴅ(Io.IoCfg.Password, ReplyMailHelp.Ⴄ(12, null, 1057162485, 4), 427, 485));
						return;
					case 2:
					case 10:
						num2 = ((!P_0.ToLower().StartsWith(ShowWxHelp.Ⴍ('\u0083', 985806354, 3))) ? (ⴃႰ[82] - 44760) : (ⴄႭ[295] - 175));
						continue;
					case 5:
					case 6:
					{
						object obj = new ႨႭ(Ⴅ());
						((ႨႭ)obj).Ⴓ(SetStationClubHelp.Ⴍ(12, 0, 1747263132, null) + P_0, this);
						return;
					}
					case 7:
						return;
					}
					break;
				}
				goto IL_0155;
				IL_0155:
				num2 = ((!ShowTalk.Ⴀ(P_0, ႰႥ.Ⴅ(7, 'Q', 952621098), 743, 'ʆ')) ? 7 : 9);
				goto IL_0117;
			}
		}
	}

	public void OnDisconnect(string msg)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 11;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!SetStationGrid.Ⴄ(Ⴍ().Id, Ⴅ().Ⴓ().Id, 695, 688)) ? (ⴄႷ[113] - 58465) : 4);
				continue;
			case 4:
				ArcConnect.m_Ⴃ.Info(qslinfoResponse.Ⴗ(Call, CallBlockCacheCfg.Ⴅ(null, 8, 62058052, null), Io.EndPoint, ReplyMail.Ⴅ(5, 1, 1217945013), 606, 'Ƚ'));
				num = 13;
				continue;
			case 13:
				num = ((Ⴅ().Ⴈ() == null) ? 14 : 5);
				continue;
			case 5:
			case 9:
				Ⴅ().Ⴈ().DeleteLocalConnect(Id);
				goto case 1;
			case 1:
			case 14:
				Io.ConnectDts = DateTime.MinValue;
				obj = new LogEntry(Io.IoCfg, Call, msg);
				num = ⴄႷ[1] - 43573;
				continue;
			case 8:
				Ⴅ().Ⴀ().Ⴐ().Add(obj as LogEntry);
				goto case 6;
			case 6:
				num = ((ConnectState == ConnectStateType.ArxClient) ? 10 : (ⴃႠ[49] - 27484));
				continue;
			case 7:
			{
				ConnectStateType connectState = ConnectState;
				SetTalkCountHelp.Ⴅ[450] = (byte)((SetTalkCountHelp.Ⴅ[450] * SetTalkCountHelp.Ⴅ[137]) & 0x7B);
				num = ((connectState == ConnectStateType.TelnetUser) ? (ⴄႤ[239] / 2) : (ⴃႰ[141] - 47836));
				continue;
			}
			case 3:
				num = ((ConnectState == ConnectStateType.AgwBpqUser) ? 10 : 0);
				continue;
			case 10:
			case 12:
				PcxxNodeUser.Ⴅ(this);
				break;
			case 0:
				break;
			case 2:
				return;
			}
			switch (Io.IoCfg.Category)
			{
			default:
				num = 2;
				continue;
			case IoCategoryType.Server:
				while (true)
				{
					int num2 = ((Ⴍ() == null) ? 4 : (ⴃႠ[46] - 40103));
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 7:
							break;
						case 0:
							Ⴍ().ႣႼ(Id);
							goto case 8;
						case 8:
							Io.OnRxEvent -= OnRx;
							num2 = ⴃႠ[270] - 17700;
							continue;
						case 3:
							Io.OnConnectEvent -= OnConnect;
							Io.OnDisconnectEvent -= OnDisconnect;
							return;
						case 6:
							return;
						case 1:
							goto end_IL_024c;
						case 2:
							goto end_IL_0202;
						case 4:
							return;
						}
						break;
					}
					continue;
					end_IL_024c:
					break;
				}
				goto case IoCategoryType.Client;
			case IoCategoryType.Client:
				{
					Ⴀ(false);
					break;
				}
				end_IL_0202:
				break;
			}
			break;
		}
		Ⴅ(false);
	}

	public void OnConnect(string msg)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 4;
		IoCategoryType category = default(IoCategoryType);
		object obj3 = default(object);
		object obj = default(object);
		object obj8 = default(object);
		Array array = default(Array);
		object obj6 = default(object);
		object obj7 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				Io.ConnectDts = ShowAnnHelp.Ⴅ('ƍ', 444);
				category = Io.IoCfg.Category;
				num = 1;
				break;
			case 1:
			{
				int num2;
				switch (category)
				{
				default:
					num = 5;
					break;
				case IoCategoryType.Server:
					num2 = ((!Ⴅ().Ⴀ().ႨႭ().Ⴅ(Io.EndPoint)) ? (ⴀႨ[28] - 17438) : 14);
					goto IL_00b2;
				case IoCategoryType.Client:
					goto IL_03c7;
					IL_03c7:
					num2 = ((!MailHelper.Ⴅ(SetAnnModeHelp.Ⴓ((object)Io.IoCfg, 509, 'Ʒ'), typeof(ClientIoCfg), 557, 537)) ? (ⴄႷ[104] - 12503) : 13);
					goto IL_00b2;
					IL_00b2:
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 12:
							break;
						case 14:
							ArcConnect.m_Ⴃ.Warn(ShowUsersHelp.Ⴅ(SetStationClubHelp.Ⴍ(12, 5, 1747263121, null), Io.EndPoint, 935, 1001));
							num2 = 3;
							continue;
						case 3:
							Io.Disconnect();
							return;
						case 31:
							return;
						case 17:
							num2 = ((!MailHelper.Ⴅ(SetAnnModeHelp.Ⴓ((object)Io.IoCfg, 639, 'ȵ'), typeof(ServerIoCfg), 915, 935)) ? 29 : (ⴀႨ[47] - 22478));
							continue;
						case 10:
							num2 = ReadMail.Ⴃ((ServerIoCfg)Io.IoCfg, 658, 733) switch
							{
								ServerIoType.Telnet => ⴀႣ[167] - 59323, 
								ServerIoType.ArxNode => 6, 
								ServerIoType.ArxClient => 27, 
								ServerIoType.PCxx => 9, 
								ServerIoType.AgwBpqTcp => ⴀ[480] - 26843, 
								ServerIoType.Arc4Active => 9, 
								ServerIoType.Arc4Passive => ⴀႨ[83] - 31166, 
								_ => 20, 
							};
							continue;
						case 20:
							return;
						case 9:
							ႠႰ(ShowWxHelp.Ⴍ('å', 985806361, 1));
							return;
						case 5:
							Login.Ⴈ(this, Io.IoCfg);
							return;
						case 27:
							ConnectState = ConnectStateType.ArxClient;
							Ⴍ(string.Empty);
							obj3 = new ArcLogInRqst(Ⴅ().Ⴓ().Call, ShowSkimCtyHelp.Ⴍ(1216132521, 3, ' '), SetStationClubHelp.Ⴍ(11, 5, 1747263199, null));
							num2 = ⴀႨ[62] - 24097;
							continue;
						case 28:
						{
							object obj2 = ShowSun.Ⴈ(obj3 as ArcLogInRqst, 704, 650);
							ႠႰ(obj2 as string);
							return;
						}
						case 6:
							ConnectState = ConnectStateType.ArxNode;
							Ⴍ(string.Empty);
							obj = new ArcLogInRqst(Ⴅ().Ⴓ().Call, ShowSkimCtyHelp.Ⴍ(1216132520, 2, '^'), SetStationClubHelp.Ⴍ(15, 6, 1747263196, null));
							num2 = 22;
							continue;
						case 22:
						{
							IComparable comparable = ShowSun.Ⴈ(obj as ArcLogInRqst, 624, 570);
							ႠႰ(comparable as string);
							return;
						}
						case 19:
							goto IL_03c7;
						case 13:
							num2 = BaseCmd.Ⴓ((ClientIoCfg)Io.IoCfg, '½', 140) switch
							{
								ClientIoType.Ar6Node => 25, 
								ClientIoType.Arc4Active => 7, 
								ClientIoType.Arc4Passive => 7, 
								ClientIoType.PCxx => 26, 
								ClientIoType.Telnet => ⴃႥ[126] - 63582, 
								ClientIoType.TelnetExtComment => 26, 
								ClientIoType.ReverseBeaconWeb => 35, 
								ClientIoType.Mirc => 26, 
								_ => ⴄႭ[453] - 186, 
							};
							continue;
						case 30:
							num2 = ⴃႰ[193] - 56778;
							continue;
						case 7:
						{
							ILog ⴃ2 = ArcConnect.m_Ⴃ;
							Array array2 = new string[5];
							((string[])array2)[0] = ShowSkimCtyHelp.Ⴍ(1216132164, 6, '2');
							(array2 as string[])[1] = Call;
							(array2 as string[])[2] = CallBlockCacheCfg.Ⴅ(null, 2, 62058062, null);
							((string[])array2)[3] = Io.IoCfg.Description;
							((string[])array2)[4] = ReplyMail.Ⴅ(7, 8, 1217945015);
							ⴃ2.Info(ShowWwv.Ⴈ(array2 as string[], 'ž', 278));
							num2 = 24;
							continue;
						}
						case 24:
							obj8 = new LogEntry(Io.IoCfg, Call, msg);
							Ⴅ(true);
							num2 = 38;
							continue;
						case 38:
							Ⴀ(true);
							Ⴅ().Ⴀ().Ⴐ().Add(obj8 as LogEntry);
							num2 = ⴀႣ[9] - 14169;
							continue;
						case 33:
							array = new string[5];
							((string[])array)[0] = CallBlockCacheCfg.Ⴅ(null, 3, 62054852, null);
							num2 = ⴄႭ[523] - ⴄႭ[410];
							continue;
						case 0:
							((string[])array)[1] = Call;
							((string[])array)[2] = SetStationQth.Ⴍ(null, 1687351530, 5, 2);
							num2 = 18;
							continue;
						case 18:
							(array as string[])[3] = Io.IoCfg.ConnectAs;
							(array as string[])[4] = ShowSkimCtyHelp.Ⴍ(1216133782, 5, '\u009c');
							num2 = ⴄႷ[44] - 49631;
							continue;
						case 37:
							obj6 = ShowWwv.Ⴈ((string[])array, 'ʕ', 765);
							Io.Send((string)obj6);
							num2 = 40;
							continue;
						case 40:
							obj7 = new string[5];
							((string[])obj7)[0] = ႰႥ.Ⴅ(6, 'º', 952621536);
							num2 = ⴄႭ[492];
							continue;
						case 36:
							((string[])obj7)[1] = Call;
							(obj7 as string[])[2] = SetStationQth.Ⴍ(null, 1687351532, 3, 15);
							num2 = ⴄႤ[44] - 211;
							continue;
						case 23:
							((string[])obj7)[3] = Io.IoCfg.ConnectAs;
							(obj7 as string[])[4] = ShowSkimCtyHelp.Ⴍ(1216133781, 6, '\u008a');
							num2 = 32;
							continue;
						case 32:
							obj6 = ShowWwv.Ⴈ(obj7 as string[], '\u036c', 772);
							goto case 4;
						case 4:
							Io.Send((string)obj6);
							num2 = 15;
							continue;
						case 2:
						case 15:
							num2 = ((Ⴅ().Ⴈ() == null) ? (ⴃႠ[282] - 48579) : 16);
							continue;
						case 16:
							Ⴅ().Ⴈ().AddLocalConnect(new LocalConnect(Call, Id, UiConnectType.Arc4NodeOut));
							num2 = 35;
							continue;
						case 26:
							Ⴀ(false);
							num2 = ((!ByeHelp.Ⴍ(Call, ShowWxHelp.Ⴍ('Î', 985807205, 6), 349, 314)) ? (ⴄႭ[246] / 2) : 8);
							continue;
						case 8:
							Ⴀ(true);
							goto case 1;
						case 1:
						{
							ILog ⴃ = ArcConnect.m_Ⴃ;
							object obj5 = new string[5];
							(obj5 as string[])[0] = ShowSkimCtyHelp.Ⴍ(1216132161, 3, 'K');
							((string[])obj5)[1] = Io.IoCfg.ConnectTo;
							(obj5 as string[])[2] = CallBlockCacheCfg.Ⴅ(null, 4, 62058056, null);
							((string[])obj5)[3] = Io.IoCfg.Description;
							(obj5 as string[])[4] = ReplyMail.Ⴅ(0, 8, 1217945008);
							ⴃ.Info(ShowWwv.Ⴈ((string[])obj5, 'ƈ', 480));
							num2 = ⴅ[398];
							continue;
						}
						case 39:
						{
							object obj4 = new LogEntry(Io.IoCfg, msg);
							Ⴅ().Ⴀ().Ⴐ().Add(obj4 as LogEntry);
							num2 = ⴅ[170] - 39;
							continue;
						}
						case 25:
							ConnectState = ConnectStateType.ArxNode;
							Ⴍ(string.Empty);
							goto case 35;
						case 35:
							num2 = ((((ClientIoCfg)Io.IoCfg).Type != ClientIoType.Mirc) ? (ⴅ[165] - ⴅ[17]) : (ⴃႥ[17] - 43307));
							continue;
						case 34:
							num2 = ((Ⴅ().Ⴈ() == null) ? 29 : 21);
							continue;
						case 21:
							Ⴅ().Ⴈ().AddLocalConnect(new LocalConnect(Call, Id, UiConnectType.SpotSuckerOut));
							return;
						case 29:
							return;
						}
						break;
					}
					goto case IoCategoryType.Server;
				}
				break;
			}
			case 5:
				return;
			}
		}
	}

	public void SendId()
	{
		int num = 2;
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			switch (num)
			{
			default:
				enumerable = qslinfoRequest.Ⴃ(Call, Ⴅ().Ⴓ().Call, 113, 64);
				break;
			case 3:
				break;
			case 1:
				ႠႰ(enumerable as string);
				return;
			}
			num = 1;
		}
	}
}
