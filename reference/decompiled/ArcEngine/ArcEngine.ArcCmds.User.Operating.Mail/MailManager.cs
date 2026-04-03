using System;
using System.Collections;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class MailManager
{
	private Hashtable Ⴄ;

	private Hashtable Ⴀ;

	private readonly Hashtable Ⴗ;

	public MailManager()
	{
		Ⴄ = new Hashtable();
		Ⴀ = new Hashtable();
		Ⴗ = new Hashtable();
	}

	public void ProcessUserInput(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 5;
		object obj = default(object);
		IConvertible msg = default(IConvertible);
		while (true)
		{
			switch (num)
			{
			default:
				if (DxSpotUserHelp.Ⴅ(Ⴗ, (object)cmd.Ⴍ().Ⴀ(), '\u036e', (short)895))
				{
					num = 3;
					break;
				}
				return;
			case 3:
				obj = (Letter)ShowWwv.Ⴐ(Ⴗ, (object)cmd.Ⴍ().Ⴀ(), '\u031d', '\u0378');
				goto case 4;
			case 4:
			case 7:
				num = 1;
				break;
			case 0:
			case 1:
				if (CallBlockCacheCfg.Ⴜ(ႨႳ.Ⴐ((Letter)obj, 336, 290), 442, 475) == 0)
				{
					num = 2;
					break;
				}
				while (true)
				{
					int num2 = ((CallBlockCacheCfg.Ⴜ(WxFullHelp.Ⴓ((Letter)obj, 369, 378), 902, 999) != 0) ? 1 : 7);
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 0:
						case 5:
							break;
						case 7:
							CallbookCfg.Ⴐ((Letter)obj, cmd.Rx.Msg, 656, 680);
							cmd.Ⴍ().ႠႰ(ShowSkimCtyHelp.Ⴍ(1216129814, 2, '.'));
							return;
						case 1:
							msg = cmd.Rx.Msg;
							num2 = ((!SetAnnDefault.Ⴍ(LogEntry.Ⴄ((string)msg, '\u001a', 48), SetTalkCount.Ⴗ(7, null, 1267017160, typeof(ႳႤ)), 710, 660)) ? (ⴐ[158] - 217) : (ⴄႷ[116] - 52923));
							continue;
						case 2:
						case 9:
							cmd.Ⴍ().Ⴅ().Ⴀ()
								.ႨႨ()
								.AddLetter((Letter)obj);
							MailHelper.Ⴀ(Ⴗ, (object)cmd.Ⴍ().Ⴀ(), '\u0317', 879);
							num2 = ⴍႤ[72] - 6261;
							continue;
						case 8:
							cmd.Ⴍ().ႠႰ(SetStationQth.Ⴍ(null, 1687354849, 0, 29));
							return;
						case 3:
							num2 = ((!LogEntry.Ⴄ((string)msg, '\u008c', 166).StartsWith(CallBlockCacheCfg.Ⴅ(null, 4, 62061627, null))) ? 10 : ⴀႼ[96]);
							continue;
						case 4:
						case 12:
							Ⴗ.Remove(cmd.Ⴍ().Ⴀ());
							cmd.Ⴍ().ႠႰ(CallBlockCacheCfg.Ⴅ(null, 1, 62061604, null));
							return;
						case 10:
						{
							Letter obj2 = obj as Letter;
							obj2.Body = obj2.Body + cmd.Rx.Msg + ReplyMailHelp.Ⴄ(24, null, 1057162487, 6);
							return;
						}
						case 11:
							return;
						}
						break;
					}
				}
			case 2:
				qslinfoResponseBody.Ⴈ((Letter)obj, SetDxFilter.Ⴀ(cmd.Rx.Msg, 569, 'ɸ'), 491, 485);
				num = 6;
				break;
			case 6:
				cmd.Ⴍ().ႠႰ(CallBlockCacheCfg.Ⴅ(null, 0, 62061581, null));
				return;
			}
		}
	}
}
