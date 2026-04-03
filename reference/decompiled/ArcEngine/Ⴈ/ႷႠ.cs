using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
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
using ArcEngine.Callbook;
using Spring.Core.IO;
using Spring.Objects.Factory;
using Spring.Objects.Factory.Xml;
using log4net;

namespace Ⴈ;

internal sealed class ႷႠ
{
	private static readonly ILog m_Ⴃ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(7, null, 1267017749, typeof(SqlHelperParameterCache)), 216, 197);

	private readonly IObjectFactory m_Ⴓ;

	internal ႷႠ()
	{
		object obj = new FileSystemResource(ႰႥ.Ⴅ(1, '\u00ad', 952623051));
		this.m_Ⴓ = new XmlObjectFactory((IResource)obj);
	}

	internal UserCache Ⴃ()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		while (true)
		{
			object obj = (UserCache)this.m_Ⴓ.GetObject(ႨႨ.Ⴀ(6, 6, 1157903694));
			while (true)
			{
				IL_0059:
				int num = 3;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႥ[304] - 54438;
						continue;
					case 0:
					case 4:
						break;
					case 5:
						goto IL_0059;
					case 2:
					case 3:
					{
						UserCache result = obj as UserCache;
						IpLockoutCacheCfg.ႭႭ[67] = (char)(IpLockoutCacheCfg.ႭႭ[67] & BandModeCacheCfg.ႠႳ[121] & 0x21);
						return result;
					}
					}
					break;
				}
				break;
			}
		}
	}

	internal IArcCmd Ⴈ(string P_0)
	{
		object obj = (IArcCmd)this.m_Ⴓ.GetObject(P_0);
		return obj as IArcCmd;
	}

	internal ConnectsCache Ⴍ()
	{
		while (true)
		{
			object obj = (ConnectsCache)this.m_Ⴓ.GetObject(SetStationClubHelp.Ⴍ(14, 7, 1747257439, null));
			while (true)
			{
				IL_0049:
				int num = 5;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 1;
						continue;
					case 1:
						break;
					case 2:
						goto IL_0049;
					case 3:
					case 5:
						return (ConnectsCache)obj;
					}
					break;
				}
				break;
			}
		}
	}

	internal LotwCache Ⴐ()
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		while (true)
		{
			object obj = (LotwCache)this.m_Ⴓ.GetObject(SetTalkCount.Ⴗ(3, null, 1267023809, typeof(ShowUsers.ႨႭ)));
			int num = 0;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴐ[367];
					continue;
				case 4:
					break;
				case 0:
				case 2:
				case 3:
				{
					LotwCache result = obj as LotwCache;
					ShowWwvOptionsHelp.ႣႥ[259] = (char)((ShowWwvOptionsHelp.ႣႥ[259] * ShowWwvOptionsHelp.ႣႥ[218]) & 0x16);
					return result;
				}
				}
				break;
			}
		}
	}

	internal BadWordCache Ⴈ()
	{
		while (true)
		{
			object obj = (BadWordCache)this.m_Ⴓ.GetObject(ႨႨ.Ⴀ(4, 5, 1157906388));
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 0:
				case 3:
					break;
				case 2:
					return obj as BadWordCache;
				}
				break;
			}
		}
	}

	internal BandModeCache Ⴀ()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		while (true)
		{
			object obj = (BandModeCache)this.m_Ⴓ.GetObject(ShowSkimCtyHelp.Ⴍ(1216134204, 8, '\u0099'));
			while (true)
			{
				IL_005d:
				int num = 0;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴄႤ[273] - 237;
						continue;
					case 1:
						break;
					case 5:
						goto IL_005d;
					case 0:
					case 2:
					case 4:
						return obj as BandModeCache;
					}
					break;
				}
				break;
			}
		}
	}

	internal DxSpotBlockCache Ⴅ()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		while (true)
		{
			object obj = (DxSpotBlockCache)this.m_Ⴓ.GetObject(SetTalkCount.Ⴗ(3, null, 1267017772, typeof(ႥႳ)));
			while (true)
			{
				IL_0067:
				int num = ⴅ[6];
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴀႳ[101] - 15055;
						continue;
					case 3:
						break;
					case 2:
						goto IL_0067;
					case 0:
					case 1:
					case 5:
						return obj as DxSpotBlockCache;
					}
					break;
				}
				break;
			}
		}
	}

	internal CallBlockCache Ⴓ()
	{
		while (true)
		{
			object obj = (CallBlockCache)this.m_Ⴓ.GetObject(ShowSkimCtyHelp.Ⴍ(1216134466, 3, 'Ì'));
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2:
				case 3:
					break;
				case 0:
				case 1:
				case 4:
					return (CallBlockCache)obj;
				}
				break;
			}
		}
	}

	internal ConnectBlockCache Ⴄ()
	{
		while (true)
		{
			object obj = (ConnectBlockCache)this.m_Ⴓ.GetObject(ReplyMailHelp.Ⴄ(0, null, 1057165239, 6));
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 1;
					continue;
				case 0:
				case 1:
				case 5:
					break;
				case 3:
				case 4:
					return (ConnectBlockCache)obj;
				}
				break;
			}
		}
	}

	internal UsVeCallbook Ⴗ()
	{
		while (true)
		{
			object obj = (UsVeCallbook)this.m_Ⴓ.GetObject(ႰႥ.Ⴅ(3, 'Á', 952623074));
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
					break;
				case 1:
				case 2:
				case 3:
					return (UsVeCallbook)obj;
				}
				break;
			}
		}
	}

	internal CtyCache Ⴜ()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		while (true)
		{
			object obj = (CtyCache)this.m_Ⴓ.GetObject(CallBlockCacheCfg.Ⴅ(null, 5, 62056251, null));
			int num = ⴀႳ[102] - 41665;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 1;
					continue;
				case 1:
				case 3:
					break;
				case 0:
				case 4:
					return (CtyCache)obj;
				}
				break;
			}
		}
	}

	internal ChatRoomPvtCache ႭႣ()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		while (true)
		{
			object obj = (ChatRoomPvtCache)this.m_Ⴓ.GetObject(ShowSkimCtyHelp.Ⴍ(1216134183, 6, '\u001d'));
			int num = ⴀႳ[40] - 46796;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႨ[178] - 32265;
					continue;
				case 0:
				case 1:
				case 3:
				case 4:
					break;
				case 2:
					return (ChatRoomPvtCache)obj;
				}
				break;
			}
		}
	}

	internal ChatRoomPubCache ႭႭ()
	{
		while (true)
		{
			object obj = (ChatRoomPubCache)this.m_Ⴓ.GetObject(SetStationClubHelp.Ⴍ(10, 1, 1747255405, null));
			while (true)
			{
				IL_0049:
				int num = 5;
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
					case 1:
					case 2:
						goto IL_0049;
					case 5:
						return (ChatRoomPubCache)obj;
					}
					break;
				}
				break;
			}
		}
	}

	internal MasterCallCache ႭႰ()
	{
		while (true)
		{
			object obj = (MasterCallCache)this.m_Ⴓ.GetObject(SetTalkCount.Ⴗ(3, null, 1267022194, typeof(DeleteMailHelp)));
			while (true)
			{
				IL_0051:
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 0;
						continue;
					case 0:
					case 5:
						break;
					case 4:
						goto IL_0051;
					case 2:
						return (MasterCallCache)obj;
					}
					break;
				}
				break;
			}
		}
	}

	internal DxSpotUniqueCache ႭႨ()
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		while (true)
		{
			object obj = (DxSpotUniqueCache)this.m_Ⴓ.GetObject(ႨႨ.Ⴀ(2, 4, 1157906404));
			int num = ⴀႳ[89] - 7666;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
					break;
				case 1:
				case 2:
				case 3:
				case 4:
					return (DxSpotUniqueCache)obj;
				}
				break;
			}
		}
	}

	internal DxClusterListCache ႭႠ()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		while (true)
		{
			object obj = (DxClusterListCache)this.m_Ⴓ.GetObject(ShowWxHelp.Ⴍ('ç', 985808241, 8));
			while (true)
			{
				IL_005d:
				int num = 0;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႰ[191] - 1776;
						continue;
					case 3:
						break;
					case 2:
						goto IL_005d;
					case 0:
					{
						DxClusterListCache result = obj as DxClusterListCache;
						ShowSunHelp.ႣႠ[86] = (char)((ShowSunHelp.ႣႠ[86] | TxNodeUserCmd.ႤႷ[23]) & 0xE5);
						return result;
					}
					}
					break;
				}
				break;
			}
		}
	}

	internal MailCache ႭႥ()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		while (true)
		{
			object obj = (MailCache)this.m_Ⴓ.GetObject(ShowWxHelp.Ⴍ('Ì', 985808880, 1));
			int num = ⴀႼ[96];
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 3:
				case 5:
					break;
				case 1:
				case 4:
				{
					MailCache result = (MailCache)obj;
					AnnCacheCfg.ႠႼ[78] = (byte)((AnnCacheCfg.ႠႼ[78] - AnnCacheCfg.ႠႼ[23]) & 0xFA);
					return result;
				}
				}
				break;
			}
		}
	}

	public IpLockoutCache ႭႳ()
	{
		while (true)
		{
			object obj = (IpLockoutCache)this.m_Ⴓ.GetObject(ReplyMailHelp.Ⴄ(16, null, 1057163920, 5));
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
				case 2:
				case 4:
					break;
				case 3:
				case 5:
					return (IpLockoutCache)obj;
				}
				break;
			}
		}
	}

	internal Top100Cache ႭႤ()
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		while (true)
		{
			object obj = (Top100Cache)this.m_Ⴓ.GetObject(ReplyMailHelp.Ⴄ(18, null, 1057165146, 7));
			while (true)
			{
				IL_005b:
				int num = 3;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴀႣ[270] - 52115;
						continue;
					case 0:
						break;
					case 1:
					case 4:
						goto IL_005b;
					case 3:
						return (Top100Cache)obj;
					}
					break;
				}
				break;
			}
		}
	}

	internal LoginMsgCache ႭႷ()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		while (true)
		{
			object obj = (LoginMsgCache)this.m_Ⴓ.GetObject(ႰႥ.Ⴅ(4, 'M', 952623092));
			while (true)
			{
				IL_005a:
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴀႨ[212] - 27975;
						continue;
					case 3:
						break;
					case 4:
						goto IL_005a;
					case 0:
					case 1:
					case 2:
					{
						LoginMsgCache result = obj as LoginMsgCache;
						ShowQrzHelp.ႤႤ[522] = SetTalkCountHelp.Ⴅ[9];
						return result;
					}
					}
					break;
				}
				break;
			}
		}
	}

	internal FocCache ႭႼ()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		while (true)
		{
			object obj = (FocCache)this.m_Ⴓ.GetObject(CallBlockCacheCfg.Ⴅ(null, 1, 62056341, null));
			while (true)
			{
				IL_004e:
				int num = ⴃႥ[116] - 45454;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 3;
						continue;
					case 2:
					case 3:
						break;
					case 4:
						goto IL_004e;
					case 0:
					case 5:
						return (FocCache)obj;
					}
					break;
				}
				break;
			}
		}
	}

	internal SkimmerCt1bohCache ႰႣ()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		while (true)
		{
			object obj = (SkimmerCt1bohCache)this.m_Ⴓ.GetObject(ReplyMail.Ⴅ(2, 15, 1217943366));
			int num = ⴅ[470] - 191;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2:
				case 3:
					break;
				case 0:
				case 1:
				case 4:
				{
					SkimmerCt1bohCache result = (SkimmerCt1bohCache)obj;
					BandModeCacheCfg.ႠႳ[124] = (char)((BandModeCacheCfg.ႠႳ[124] + BandModeCacheCfg.ႠႳ[167]) & 0xF);
					return result;
				}
				}
				break;
			}
		}
	}
}
