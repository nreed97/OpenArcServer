using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using ArcEngine;
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
using ArcEngine.ArcDatabase;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcIo.Mirc;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using log4net;

namespace Ⴈ;

internal sealed class ႳႭ
{
	private static readonly ILog m_Ⴃ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('¤', 985805301, 5), 18, 15);

	private readonly DateTime m_Ⴓ = ShowAnnHelp.Ⴅ('ͼ', 845);

	private bool m_Ⴐ;

	private int m_Ⴍ;

	internal ႨႥ Ⴃ;

	private Timer m_Ⴍ;

	private MircIo.ႠႭ m_Ⴅ;

	internal ႳႭ(ObjectManager P_0)
	{
		this.m_Ⴅ.Ⴈ = 99;
		this.m_Ⴅ.Ⴅ = 99;
		base._002Ector();
		this.m_Ⴅ.Ⴀ = P_0;
		MulticastDelegate multicastDelegate = new TimerCallback(Ⴄ);
		this.m_Ⴍ = new Timer((TimerCallback)multicastDelegate, this, 1000, 1000);
		this.m_Ⴍ = ChatRoomPubCfg.Ⴀ(P_0.Ⴓ().Call, 889, 825);
		this.Ⴃ = new ႨႥ();
	}

	[SpecialName]
	internal TimeSpan Ⴅ()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		return ShowAnnHelp.Ⴅ('\u00af', 158).Subtract(this.m_Ⴓ);
	}

	private void Ⴄ(object P_0)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 7;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num)
			{
			default:
				dateTime = ShowAnnHelp.Ⴅ('#', 18);
				num = ((ႨႰ.Ⴀ(ref dateTime, 530, 604) == this.m_Ⴅ.Ⴈ) ? 8 : 3);
				continue;
			case 3:
				num = ((SetWxCountHelp.Ⴄ(ref dateTime, '\u0363', 890) >= 30) ? 8 : (ⴃႰ[97] - 18256));
				continue;
			case 2:
			{
				int ⴈ = ႨႰ.Ⴀ(ref dateTime, 567, 633);
				this.m_Ⴅ.Ⴈ = ⴈ;
				num = 10;
				continue;
			}
			case 1:
			case 10:
				Ⴀ(ႨႰ.Ⴀ(ref dateTime, 37, 107));
				goto case 8;
			case 8:
				num = ((ႨႰ.Ⴀ(ref dateTime, 738, 684) == this.m_Ⴅ.Ⴅ) ? 9 : 5);
				continue;
			case 5:
				num = ((dateTime.Second < 30) ? 9 : (ⴄႭ[563] - 153));
				continue;
			case 4:
			{
				int minute = dateTime.Minute;
				this.m_Ⴅ.Ⴅ = minute;
				break;
			}
			case 0:
				break;
			case 9:
				return;
			}
			break;
		}
		Ⴐ(dateTime.Minute);
	}

	private void Ⴀ(int P_0)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 8:
				P_0 -= 10;
				num = 17;
				continue;
			default:
				num = ((P_0 > 9) ? 8 : (ⴐ[109] - ⴐ[37]));
				continue;
			case 13:
				num = P_0 switch
				{
					0 => ⴍႤ[6] - 26931, 
					1 => 1, 
					2 => 16, 
					3 => 9, 
					4 => 4, 
					5 => 6, 
					6 => ⴍႤ[427] - 18753, 
					7 => 2, 
					8 => 10, 
					9 => 20, 
					_ => ⴍႤ[263] - 61954, 
				};
				continue;
			case 7:
				num = ⴀႼ[75] - ⴀႼ[42];
				continue;
			case 18:
				Ⴃ();
				Ⴗ();
				num = ⴀႨ[20] - 47571;
				continue;
			case 1:
				Ⴓ();
				Ⴄ();
				num = ⴍႤ[126] - 61698;
				continue;
			case 16:
				Ⴈ();
				Ⴗ();
				num = ⴐ[21];
				continue;
			case 9:
			case 11:
				Ⴐ();
				Ⴄ();
				num = 3;
				continue;
			case 4:
				Ⴀ();
				Ⴗ();
				num = 3;
				continue;
			case 6:
				Ⴜ();
				Ⴄ();
				num = 3;
				continue;
			case 15:
				ႭႥ();
				Ⴗ();
				goto case 14;
			case 14:
				num = 3;
				continue;
			case 2:
				ႭႭ();
				Ⴄ();
				num = ⴄႤ[280] - 178;
				continue;
			case 10:
				ႭႷ();
				Ⴗ();
				num = ⴃႥ[326] - 9872;
				continue;
			case 12:
			case 20:
				ႭႤ();
				Ⴄ();
				goto case 3;
			case 3:
				num = ((P_0 != this.m_Ⴍ) ? 5 : 19);
				continue;
			case 19:
			{
				object obj = new ArcWebService(this.m_Ⴅ.Ⴀ);
				(obj as ArcWebService).Process();
				break;
			}
			case 5:
				break;
			}
			break;
		}
		object enumerator = this.m_Ⴅ.Ⴀ.Ⴓ().ArcConnects.GetEnumerator();
		try
		{
			int num2 = 3;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			TimeSpan timeSpan = default(TimeSpan);
			int num5 = default(int);
			while (true)
			{
				switch (num2)
				{
				default:
					num2 = 7;
					continue;
				case 6:
				case 13:
					current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
					num2 = (current.Value.Ⴃ() ? (ⴍႤ[449] - 32153) : (ⴃႰ[179] - 27705));
					continue;
				case 12:
					num2 = ((!ByeHelp.Ⴍ(SetStationNameHelp.Ⴃ((MemberInfo)SetAnnModeHelp.Ⴓ((object)current.Value.Io, 624, 'Ⱥ'), (short)436, 'Ƈ'), CallBlockCacheCfg.Ⴅ(null, 2, 62062411, null), 991, 951)) ? 14 : 11);
					continue;
				case 11:
					timeSpan = SetWxMode.Ⴃ(ShowAnnHelp.Ⴅ('ĳ', 258), current.Value.Io.ConnectDts, 487, 425);
					num2 = 8;
					continue;
				case 8:
					num2 = ((ShowNodes.Ⴍ(ref timeSpan, 580, 'ɶ') <= 0) ? 14 : 4);
					continue;
				case 4:
					current.Value.ႳႨ();
					current.Value.ႣႥ(current.Value.Id);
					goto case 14;
				case 14:
					num5 = 0;
					num2 = 2;
					continue;
				case 15:
					current.Value.Io.DxSpotRate[num5] = current.Value.Io.DxSpotRate[num5 + 1];
					num2 = ⴍႤ[389] - 64198;
					continue;
				case 9:
				case 10:
					num5++;
					num2 = ⴀႣ[158] - 19865;
					continue;
				case 2:
					num2 = ((num5 < 59) ? 15 : 5);
					continue;
				case 5:
				case 16:
					current.Value.Io.DxSpotRate[59] = 0.0;
					num2 = 7;
					continue;
				case 7:
				{
					int num4;
					if (!(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext())
					{
						char num3 = ⴀႣ[100];
						AnnCacheCfg.ႠႼ[10] = (byte)(AnnCacheCfg.ႠႼ[10] & P_0 & 0x5F);
						num4 = num3 - 11681;
					}
					else
					{
						num4 = 6;
					}
					num2 = num4;
					continue;
				}
				case 0:
					break;
				}
				break;
			}
		}
		finally
		{
			int num6 = 6;
			while (true)
			{
				int num7;
				switch (num6)
				{
				default:
					num7 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 5 : (ⴍႤ[404] - 20857));
					goto IL_04f6;
				case 0:
				case 2:
					(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
					break;
				case 5:
					break;
				}
				break;
				IL_04f6:
				num6 = num7;
			}
		}
		switch (1)
		{
		case 3:
			return;
		}
		this.m_Ⴅ.Ⴀ.Ⴀ().Ⴃ().Ⴀ()
			.Ⴍ();
	}

	private void Ⴐ(int P_0)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 17;
		while (true)
		{
			switch (num)
			{
			case 9:
				P_0 -= 10;
				num = 3;
				continue;
			default:
				num = ((P_0 > 9) ? 9 : ⴐ[204]);
				continue;
			case 6:
				num = P_0 switch
				{
					0 => 18, 
					1 => ⴍႤ[401] - 53843, 
					2 => ⴀႣ[166] - 45408, 
					3 => ⴐ[80], 
					4 => 12, 
					5 => 5, 
					6 => 15, 
					7 => ⴃႠ[23] - 54158, 
					8 => ⴅ[210], 
					9 => 13, 
					_ => 7, 
				};
				continue;
			case 7:
				num = 16;
				continue;
			case 18:
				ႭႣ();
				num = ⴀႣ[355] - 29152;
				continue;
			case 0:
				ႭႳ();
				num = ⴃႥ[120] - 25346;
				continue;
			case 4:
				ႭႨ();
				num = ⴄႤ[180] - ⴄႤ[139];
				continue;
			case 14:
				ႭႰ();
				goto case 19;
			case 19:
				num = 16;
				continue;
			case 12:
				ႭႠ();
				num = ⴅ[99];
				continue;
			case 5:
				ႭႼ();
				num = 16;
				continue;
			case 15:
				ႷႥ();
				num = 16;
				continue;
			case 1:
				ႷႭ();
				num = 16;
				continue;
			case 8:
				ႷႷ();
				num = 16;
				continue;
			case 13:
				ႷႤ();
				break;
			case 16:
				break;
			case 10:
				return;
			}
			if (!this.m_Ⴐ)
			{
				break;
			}
			num = 10;
		}
		Ⴍ();
		this.m_Ⴅ.Ⴀ.Ⴀ().ႨႳ().OneMinMaint(this.m_Ⴅ.Ⴀ);
	}

	internal void Ⴍ()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		try
		{
			object enumerator = this.m_Ⴅ.Ⴀ.Ⴓ().ArcConnects.GetEnumerator();
			try
			{
				int num = 0;
				KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
				while (true)
				{
					switch (num)
					{
					case 5:
						current = (enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Current;
						num = ((current.Value.Io == null) ? 4 : 3);
						continue;
					case 1:
					case 3:
						num = ((!current.Value.Io.IoCfg.Enabled) ? 4 : 8);
						continue;
					case 8:
					case 9:
						num = (current.Value.Io.IsConnected ? 4 : (ⴀႼ[92] - 101));
						continue;
					case 7:
						current.Value.ArcConnects.Clear();
						current.Value.Io.Connect();
						break;
					case 2:
					case 6:
						goto end_IL_003a;
					}
					num = (((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).MoveNext() ? (ⴄႤ[180] - 25) : 6);
					continue;
					end_IL_003a:
					break;
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
						num3 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? 3 : 4);
						goto IL_0146;
					case 0:
					case 2:
					case 4:
						((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Dispose();
						break;
					case 3:
					case 5:
						break;
					}
					break;
					IL_0146:
					num2 = num3;
				}
			}
			int num4 = 0;
			object current2 = default(object);
			while (true)
			{
				switch (num4)
				{
				default:
					if (this.m_Ⴅ.Ⴀ.Ⴅ() == null)
					{
						return;
					}
					break;
				case 1:
				case 2:
				case 3:
				case 4:
				{
					using List<ႷႣ>.Enumerator enumerator2 = this.m_Ⴅ.Ⴀ.Ⴅ().Ⴀ.GetEnumerator();
					int num5 = 5;
					while (true)
					{
						switch (num5)
						{
						case 8:
							current2 = enumerator2.Current;
							goto case 2;
						case 2:
							num5 = ((!(current2 as ႷႣ).Ⴃ.IoDeviceCfg.Enabled) ? 4 : 0);
							continue;
						case 0:
						case 6:
						case 7:
							num5 = ((!((ႷႣ)current2).Ⴃ.IsConnected) ? 1 : 4);
							continue;
						case 1:
							((ႷႣ)current2).Ⴃ.Start();
							break;
						case 3:
							return;
						}
						int num7;
						if (!enumerator2.MoveNext())
						{
							byte num6 = ⴅ[310];
							SetAnnMode.ႤႭ[430] = (byte)(SetAnnMode.ႤႭ[430] & SetAnnMode.ႤႭ[490] & 0x4B);
							num7 = num6 - 177;
						}
						else
						{
							num7 = 8;
						}
						num5 = num7;
					}
				}
				}
				num4 = ⴃႰ[168] - 26503;
			}
		}
		catch (Exception ex)
		{
			ႳႭ.m_Ⴃ.Error(SkimmerSpotBins.Ⴈ(ex, 233, 199));
		}
	}

	private void Ⴗ()
	{
		global::Ⴈ.ႷႨ.Ⴃ(this.m_Ⴅ.Ⴀ);
	}

	private void Ⴄ()
	{
		this.m_Ⴅ.Ⴀ.Ⴀ().Ⴃ().Maintenance();
	}

	private void Ⴃ()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 7;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num)
			{
			default:
				dateTime = ShowAnnHelp.Ⴅ('Ƈ', 438);
				goto case 4;
			case 4:
			case 5:
				num = ((ႨႰ.Ⴀ(ref dateTime, 654, 704) != 0) ? 1 : (ⴄႤ[223] - 32));
				break;
			case 1:
			case 2:
				num = ((ႨႰ.Ⴀ(ref dateTime, 225, 175) == 30) ? (ⴄႷ[35] - 5043) : 0);
				break;
			case 3:
				ႷႳ();
				goto case 0;
			case 0:
				num = ((dateTime.Minute != 0) ? 8 : 6);
				break;
			case 6:
				ႷႣ();
				return;
			case 8:
				return;
			}
		}
	}

	private static void Ⴓ()
	{
	}

	private static void Ⴈ()
	{
	}

	private static void Ⴐ()
	{
	}

	private static void Ⴀ()
	{
	}

	private static void Ⴜ()
	{
	}

	private static void ႭႥ()
	{
	}

	private static void ႭႭ()
	{
	}

	private static void ႭႷ()
	{
	}

	private void ႭႤ()
	{
	}

	private static void ႭႣ()
	{
	}

	private static void ႭႳ()
	{
	}

	private void ႭႨ()
	{
	}

	private void ႭႰ()
	{
	}

	private void ႭႠ()
	{
		this.m_Ⴅ.Ⴀ.Ⴀ().Ⴍ().Maintenance();
	}

	private void ႭႼ()
	{
		this.m_Ⴅ.Ⴀ.Ⴀ().ႨႤ().Ⴐ();
	}

	private void ႷႥ()
	{
		this.m_Ⴅ.Ⴀ.Ⴀ().Ⴄ().Maintenance();
	}

	private void ႷႭ()
	{
		this.m_Ⴅ.Ⴀ.Ⴀ().Ⴈ().Maintenance();
	}

	private void ႷႷ()
	{
		this.m_Ⴅ.Ⴀ.Ⴀ().ႨႣ().SaveToDb();
	}

	private void ႷႤ()
	{
		ႷႨ();
		this.m_Ⴅ.Ⴀ.Ⴀ().Ⴐ().Maintenance();
	}

	private void ႷႣ()
	{
		object obj = new ArcNodeMaintenance(this.m_Ⴅ.Ⴀ);
		((ArcNodeMaintenance)obj).Process();
	}

	private static void ႷႳ()
	{
	}

	private void ႷႨ()
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		object enumerator = this.m_Ⴅ.Ⴀ.Ⴓ().ArcConnects.GetEnumerator();
		try
		{
			int num = 8;
			KeyValuePair<Guid, ArcConnect> current = default(KeyValuePair<Guid, ArcConnect>);
			while (true)
			{
				switch (num)
				{
				default:
					num = ⴐ[257];
					continue;
				case 5:
					current = ((IEnumerator<KeyValuePair<Guid, ArcConnect>>)enumerator).Current;
					goto case 2;
				case 2:
					current.Value.Io.LastTenMinuteDxDupeCnt = current.Value.Io.TenMinuteDxDupeCnt;
					num = 4;
					continue;
				case 0:
				case 3:
				case 4:
					current.Value.Io.TenMinuteDxDupeCnt = 0;
					break;
				case 7:
					break;
				case 6:
					goto end_IL_002b;
				}
				num = ((enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).MoveNext() ? (ⴅ[112] - 107) : (ⴐ[50] / 2));
				continue;
				end_IL_002b:
				break;
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
					num3 = ((!(enumerator is IEnumerator<KeyValuePair<Guid, ArcConnect>>)) ? ⴐ[21] : (ⴐ[232] - ⴐ[102]));
					goto IL_0106;
				case 5:
					(enumerator as IEnumerator<KeyValuePair<Guid, ArcConnect>>).Dispose();
					break;
				case 3:
					break;
				}
				break;
				IL_0106:
				num2 = num3;
			}
		}
		switch (4)
		{
		}
	}

	internal void ႷႰ()
	{
		this.m_Ⴐ = true;
	}
}
