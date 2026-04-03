using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using ArcEngine.ArcCaches;
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
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcServerConfig.Io;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Talk;

public class TalkSpot
{
	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(CallBlockCacheCfg.Ⴅ(null, 2, 62055499, null), 457, 468);

	private string m_Ⴃ;

	private string m_Ⴀ;

	private string Ⴅ;

	private string Ⴓ;

	private string m_Ⴄ;

	private IoDevicesCfg.Ⴈ Ⴗ = new IoDevicesCfg.Ⴈ();

	public string To
	{
		get
		{
			byte[] ⴅ = SetTalkCountHelp.Ⴅ;
			return Ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	public string Spotter
	{
		get
		{
			return Ⴗ.Ⴗ;
		}
		set
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					Ⴗ.Ⴗ = value as string;
					num = ((CallBlockCacheCfg.Ⴜ(Ⴗ.Ⴗ, 922, 1019) <= 12) ? 5 : (ⴄႷ[20] - 44139));
					break;
				case 1:
				case 3:
				{
					IEnumerable<char> enumerable = SetTalkOutputHelp.Ⴍ(Ⴗ.Ⴗ, 0, 12, 465, 386);
					Ⴗ.Ⴗ = enumerable as string;
					num = 5;
					break;
				}
				case 4:
				case 5:
					ScrubbedSpotter = UtilsCallsign.GetNoSsidCall(value);
					return;
				case 0:
					return;
				}
			}
		}
	}

	[XmlIgnore]
	public string ScrubbedSpotter
	{
		get
		{
			return Ⴗ.Ⴍ;
		}
		set
		{
			Ⴗ.Ⴍ = value as string;
		}
	}

	public string SpotterNode
	{
		get
		{
			string ⴃ = this.m_Ⴃ;
			SetTalkCountHelp.Ⴅ[14] = (byte)((SetTalkCountHelp.Ⴅ[14] | SetDxCountHelp.ႭႤ[337]) & 0x2B);
			return ⴃ;
		}
		set
		{
			byte[] ⴐ = ႨႣ.Ⴐ;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					this.m_Ⴃ = value;
					goto case 3;
				case 3:
				case 5:
				{
					int num2 = CallBlockCacheCfg.Ⴜ(this.m_Ⴃ, 212, 181);
					DirectoryBulletin.ႠႨ[66] = (DirectoryBulletin.ႠႨ[66] - ShowSunHelp.ႣႠ[41]) & 0x4F;
					num = ((num2 <= 12) ? (ⴐ[182] - 21) : 0);
					break;
				}
				case 0:
					this.m_Ⴃ = this.m_Ⴃ.Substring(0, 12);
					num = 1;
					break;
				case 1:
				case 4:
					return;
				}
			}
		}
	}

	public string Msg
	{
		get
		{
			return this.m_Ⴀ;
		}
		set
		{
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
				{
					this.m_Ⴀ = value;
					int num2 = CallBlockCacheCfg.Ⴜ(this.m_Ⴀ, 152, 249);
					AnnCacheCfg.ႠႼ[95] = (byte)((AnnCacheCfg.ႠႼ[95] + AnnCacheCfg.ႠႼ[66]) & 0xE2);
					num = ((num2 <= 200) ? (ⴍႤ[307] - 52363) : (ⴀႣ[203] - 42476));
					break;
				}
				case 4:
					this.m_Ⴀ = this.m_Ⴀ.Substring(0, 200);
					num = 2;
					break;
				case 0:
				case 2:
				case 3:
					return;
				}
			}
		}
	}

	public string BellFlag
	{
		get
		{
			char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
			return Ⴗ.Ⴓ;
		}
		set
		{
			Ⴗ.Ⴓ = value as string;
		}
	}

	public string RelayToCall
	{
		get
		{
			return this.m_Ⴄ;
		}
		set
		{
			this.m_Ⴄ = value;
		}
	}

	public string Route
	{
		get
		{
			return Ⴅ;
		}
		set
		{
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					Ⴅ = value;
					goto case 0;
				case 0:
					num = ((CallBlockCacheCfg.Ⴜ(Ⴅ, 869, 772) <= 255) ? (ⴃႠ[299] - 20924) : ⴄႭ[246]);
					break;
				case 2:
				case 3:
					Ⴅ = Ⴅ.Substring(0, 255);
					num = ⴃႠ[304] - 2903;
					break;
				case 4:
					return;
				}
			}
		}
	}

	public DateTime Dts
	{
		get
		{
			return Ⴗ.Ⴀ;
		}
		set
		{
			Ⴗ.Ⴀ = value;
		}
	}

	[XmlIgnore]
	public string DupeKey
	{
		get
		{
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			return UtilsString.ScrubKey(qslinfoResponse.Ⴗ(Msg, To, Spotter, SpotterNode, 643, 'ˠ'));
		}
	}

	public TalkSpot()
	{
		ICloneable empty = string.Empty;
		Ⴗ.Ⴗ = empty as string;
		this.m_Ⴃ = string.Empty;
		this.m_Ⴀ = string.Empty;
		Ⴅ = string.Empty;
		base._002Ector();
		Dts = DateTime.MinValue;
		RelayToCall = string.Empty;
		BellFlag = string.Empty;
		To = string.Empty;
	}

	public void ExecPc10(NodeUserCmd cmd)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		try
		{
			int num = 1;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
				{
					string msg = cmd.Rx.Msg;
					object obj2 = new char[1];
					((char[])obj2)[0] = '^';
					obj = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(msg, (char[])obj2, 927, 969);
					num = ⴐ[243];
					continue;
				}
				case 2:
				case 8:
					num = ((((string[])obj).Length != 8) ? (ⴃႥ[346] - 63212) : 11);
					continue;
				case 11:
					Spotter = ((string[])obj)[1];
					goto case 7;
				case 7:
					To = ((string[])obj)[2];
					num = 9;
					continue;
				case 9:
					Msg = ((string[])obj)[3];
					goto case 4;
				case 4:
					BellFlag = (obj as string[])[4];
					num = ⴐ[148] - 132;
					continue;
				case 10:
					RelayToCall = (obj as string[])[5];
					SpotterNode = ((string[])obj)[6];
					num = ⴄႷ[33] - 18065;
					continue;
				case 5:
					Ⴐ(cmd);
					num = 3;
					continue;
				case 6:
					TalkSpot.Ⴅ.Warn(cmd.Rx.Msg);
					break;
				case 3:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			TalkSpot.Ⴅ.Warn(cmd.Rx.Msg + ႰႥ.Ⴅ(2, '\u0010', 952620208) + SkimmerSpotBins.Ⴈ(ex, 162, 140));
		}
		switch (0)
		{
		}
	}

	public void ExecUser(NodeUserCmd cmd, bool bTimeStamp)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		try
		{
			int num = 6;
			int num2 = default(int);
			IConvertible arcId = default(IConvertible);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length <= 1) ? (ⴍႤ[237] - 10446) : (ⴀႨ[125] - 14036));
					continue;
				case 8:
				{
					ICloneable call = cmd.Ⴍ().Call;
					Ⴗ.Ⴗ = call as string;
					num = 9;
					continue;
				}
				case 9:
					this.m_Ⴃ = cmd.Ⴍ().Call;
					To = SetDxFilter.Ⴀ(cmd.Rx.Split[1], 100, '%');
					goto case 5;
				case 5:
					num = ⴀႳ[302] - 61684;
					continue;
				case 2:
					num2 = ShowNodes.Ⴄ(cmd.Rx.Msg, cmd.Rx.Split[1], 804, 795);
					num = 11;
					continue;
				case 11:
					this.m_Ⴀ = SetDxFilter.Ⴀ(Clear.Ⴄ(cmd.Rx.Msg, num2 + CallBlockCacheCfg.Ⴜ(cmd.Rx.Split[1], 885, 788), 'Ɛ', 'Ƹ'), 577, 'ȁ');
					num = ⴀႳ[139] - 4369;
					continue;
				case 7:
					BellFlag = CallBlockCacheCfg.Ⴅ(null, 8, 62057904, null);
					RelayToCall = SetTalkCount.Ⴗ(5, null, 1267022534, typeof(DxSpotMirc));
					num = ⴃႥ[283] - 58286;
					continue;
				case 10:
					Ⴐ(cmd);
					goto case 12;
				case 12:
					arcId = UtilsString.GetArcId(cmd.Ⴍ().Call, cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call);
						goto case 0;
					case 0:
						num = ⴐ[212] - ⴐ[50];
						continue;
					case 1:
						cmd.Ⴍ().ႠႰ(arcId as string);
						break;
					case 3:
						break;
					}
					break;
				}
			}
			catch (Exception)
			{
			}
			switch (3)
			{
			}
		}

		private void Ⴐ(NodeUserCmd P_0)
		{
			char[] ⴀႣ = Arc4ServerClient.ႠႣ;
			char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
				case 3:
				case 4:
					return;
				}
				if (!Ⴃ(P_0))
				{
					num = ⴀႳ[25] - 26730;
					continue;
				}
				while (true)
				{
					P_0.Tx.DistroType = DistroType.ToCall;
					P_0.Tx.To = To;
					P_0.Tx.Msg.Add(Ⴃ());
					int num2 = ⴀႣ[424] - 4369;
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 2:
							break;
						case 1:
							goto IL_00b2;
						case 0:
						case 6:
							Ⴀ(P_0);
							goto case 3;
						case 3:
							P_0.Ⴍ().Ⴅ().Ⴀ()
								.Ⴅ()
								.AddSpot(this);
							return;
						case 5:
							return;
						}
						break;
						IL_00b2:
						P_0.Tx.Pcxx = Ⴄ();
						Dts = ShowAnnHelp.Ⴅ('Ĳ', 259);
						num2 = 0;
					}
				}
			}
		}

		private bool Ⴃ(NodeUserCmd P_0)
		{
			byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
			char[] ⴀ = SetAnnChatRooms.Ⴀ;
			char[] ⴃႠ = ShowSunHelp.ႣႠ;
			while (true)
			{
				int num = (ႷႷ.Ⴍ(To, 357, 'Ũ') ? 5 : 6);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴄႤ[139] / 2;
						continue;
					case 7:
						break;
					case 6:
						return false;
					case 5:
					case 9:
						num = (ႷႷ.Ⴍ(Ⴗ.Ⴗ, 751, 'ˢ') ? 11 : 4);
						continue;
					case 4:
						return false;
					case 11:
						num = (P_0.Ⴍ().Ⴅ().Ⴀ()
							.ႤႤ()
							.Ⴈ(this.m_Ⴀ) ? (ⴀ[275] - 38759) : 14);
						continue;
					case 14:
						return false;
					case 3:
						num = ((!P_0.Ⴍ().Ⴅ().Ⴀ()
							.Ⴅ()
							.Ⴈ(this)) ? ⴄႤ[504] : 2);
						continue;
					case 2:
						return false;
					case 13:
						num = ((!P_0.Ⴍ().Ⴅ().Ⴀ()
							.ႤႥ()
							.IsBlocked(ScrubbedSpotter)) ? 1 : (ⴃႠ[267] - 19276));
						continue;
					case 8:
					case 10:
					case 12:
						return false;
					case 1:
						return true;
					}
					break;
				}
			}
		}

		private string Ⴃ()
		{
			char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
			while (true)
			{
				Array array = new string[5];
				(array as string[])[0] = To;
				((string[])array)[1] = ReplyMailHelp.Ⴄ(30, null, 1057162081, 5);
				int num = ⴀႳ[227] - 26067;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 0;
						continue;
					case 0:
					case 3:
						break;
					case 6:
						(array as string[])[2] = Ⴗ.Ⴗ;
						goto case 5;
					case 5:
						(array as string[])[3] = SetStationClubHelp.Ⴍ(4, 6, 1747258347, null);
						num = 1;
						continue;
					case 1:
						(array as string[])[4] = this.m_Ⴀ;
						return ShowWwv.Ⴈ((string[])array, 'ŷ', 287);
					}
					break;
				}
			}
		}

		private string Ⴄ()
		{
			char[] ⴀ = SetAnnChatRooms.Ⴀ;
			byte[] ⴐ = ႨႣ.Ⴐ;
			IComparable comparable = default(IComparable);
			object obj = default(object);
			while (true)
			{
				Array array = new string[7];
				((string[])array)[0] = ReplyMail.Ⴅ(0, 7, 1217943860);
				int num = 8;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 6;
						continue;
					case 2:
					case 6:
						break;
					case 8:
						(array as string[])[1] = Ⴗ.Ⴗ;
						((string[])array)[2] = SetStationQth.Ⴍ(null, 1687351527, 8, 7);
						num = 4;
						continue;
					case 4:
					{
						((string[])array)[3] = To;
						((string[])array)[4] = SetStationQth.Ⴍ(null, 1687351529, 6, 24);
						char num2 = ⴀ[103];
						SetWxOutput.ႣႰ[173] = (char)((SetWxOutput.ႣႰ[173] + AnnCacheCfg.ႠႼ[48]) & 0x76);
						num = num2 - 25552;
						continue;
					}
					case 5:
						(array as string[])[5] = this.m_Ⴀ;
						((string[])array)[6] = SetStationQth.Ⴍ(null, 1687351532, 3, 13);
						num = ⴀ[322] - 8825;
						continue;
					case 12:
					{
						ICloneable cloneable = ShowWwv.Ⴈ((string[])array, '\u009b', 243);
						comparable = cloneable as string;
						goto case 9;
					}
					case 9:
						num = 13;
						continue;
					case 3:
					case 13:
						obj = new string[7];
						(obj as string[])[0] = comparable as string;
						((string[])obj)[1] = BellFlag;
						num = ⴐ[257];
						continue;
					case 7:
						(obj as string[])[2] = SetStationQth.Ⴍ(null, 1687351533, 2, 19);
						num = 10;
						continue;
					case 10:
						((string[])obj)[3] = RelayToCall;
						((string[])obj)[4] = SetStationQth.Ⴍ(null, 1687351533, 2, 8);
						num = 0;
						continue;
					case 0:
						((string[])obj)[5] = this.m_Ⴃ;
						((string[])obj)[6] = ReplyMail.Ⴅ(7, 1, 1217945020);
						num = 1;
						continue;
					case 1:
					{
						ICloneable cloneable = ShowWwv.Ⴈ((string[])obj, 'ο', 983);
						return (string)cloneable;
					}
					}
					break;
				}
			}
		}

		private void Ⴀ(NodeUserCmd P_0)
		{
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			int[] ⴍႤ = SetDxCountHelp.ႭႤ;
			int[] ⴀႨ = DirectoryBulletin.ႠႨ;
			int num = 9;
			Stream stream = default(Stream);
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
				{
					object obj = new XmlSerializer(DxClusterCacheCfg.Ⴃ((object)this, 192, (short)129));
					stream = new MemoryStream();
					Top100CacheCfg.Ⴓ(obj as XmlSerializer, (Stream)(MemoryStream)stream, (object)this, (short)720, (short)649);
					goto case 4;
				}
				case 4:
					num = ⴄႭ[125] / 6;
					break;
				case 8:
					enumerable = SetAnnFilterHelp.Ⴍ(ShowUptime.Ⴗ(367, 289), qslinfoResponseBody.Ⴀ((MemoryStream)stream, 517, 'ȝ'), 0, (int)SkimmerValidSpot.Ⴄ((Stream)(MemoryStream)stream, '\u02f8', 761), 208, 234);
					goto case 7;
				case 7:
					num = 1;
					break;
				case 1:
					enumerable = ShowContestStationHelp.Ⴅ(enumerable as string, ShowWxHelp.Ⴍ('u', 985807683, 2), string.Empty, 832, '\u0318');
					num = 6;
					break;
				case 6:
					enumerable = ShowContestStationHelp.Ⴅ((string)enumerable, ReplyMailHelp.Ⴄ(23, null, 1057162483, 2), string.Empty, 580, 'Ȝ');
					num = ⴍႤ[358] - 55696;
					break;
				case 5:
					enumerable = (enumerable as string).Substring(21, (enumerable as string).Length - 21);
					num = 3;
					break;
				case 3:
					enumerable = ((string)enumerable).Substring(0, 5) + ((string)enumerable).Substring(104, (enumerable as string).Length - 104);
					goto case 2;
				case 2:
					num = ⴀႨ[105] - ⴀႨ[105];
					break;
				case 0:
					P_0.Tx.NodeXml = (string)enumerable;
					return;
				}
			}
		}
	}
