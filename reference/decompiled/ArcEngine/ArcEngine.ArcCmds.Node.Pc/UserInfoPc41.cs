using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;

namespace ArcEngine.ArcCmds.Node.Pc;

public sealed class UserInfoPc41 : IArcCmd
{
	private static readonly ILog Ⴀ;

	private static string Ⴗ;

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			int num = 2;
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ((PrecisionTimer)obj2, 778, 843);
					cmd.Tx.DistroType = DistroType.ToNil;
					num = ⴀႳ[58] - 11989;
					continue;
				case 5:
				case 6:
					Ⴄ(cmd);
					ByeHelp.Ⴄ(obj2 as PrecisionTimer, '\u001c', 79);
					Ⴀ.Info(SetWxCountHelp.Ⴗ((object)(PrecisionTimer)obj2, (object)cmd.Rx.Msg, 835, (short)824));
					num = 0;
					continue;
				case 0:
				{
					object obj = new Publisher();
					(obj as Publisher).Process(cmd);
					break;
				}
				case 4:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴀ.Warn(ex.Message);
		}
		switch (1)
		{
		}
	}

	private void Ⴄ(NodeUserCmd P_0)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
			{
				IConvertible convertible = LogEntry.Ⴄ(P_0.Rx.Msg, '\u032e', 775);
				if (ByeHelp.Ⴍ(convertible as string, Ⴗ, 199, 160))
				{
					break;
				}
				while (true)
				{
					Ⴗ = (string)convertible;
					string msg = P_0.Rx.Msg;
					object obj = new char[1];
					((char[])obj)[0] = '^';
					object obj2 = Directory.Ⴓ(msg, obj as char[], 153, 207);
					int num2 = 0;
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 6:
						case 8:
							break;
						case 0:
							num2 = (((obj2 as string[]).Length == 6) ? 1 : 4);
							continue;
						case 1:
							_ = (obj2 as string[])[1];
							goto case 3;
						case 3:
							_ = (obj2 as string[])[2];
							num2 = 5;
							continue;
						case 2:
						case 5:
							_ = ((string[])obj2)[3];
							return;
						case 4:
							Ⴀ.Error(ShowSkimCtyHelp.Ⴍ(1216132825, 5, 'ë') + P_0.Rx.Msg);
							return;
						}
						break;
					}
				}
			}
			case 0:
				P_0.Rx.Msg = ShowUsersHelp.Ⴅ(CallBlockCacheCfg.Ⴅ(null, 7, 62055120, null), P_0.Rx.Msg, 101, 43);
				return;
			}
			num = ⴍႤ[116] - ⴍႤ[116];
		}
	}

	static UserInfoPc41()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 2:
				Ⴗ = string.Empty;
				return;
			case 0:
				return;
			}
			Ⴀ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(1, null, 1267016586, typeof(ShowGraylineHelp)), 149, 136);
			num = ⴃႰ[143] - 1476;
		}
	}
}
