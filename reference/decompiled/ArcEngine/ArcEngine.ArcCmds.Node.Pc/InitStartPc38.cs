using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.Node.Pc;

public sealed class InitStartPc38 : IArcCmd
{
	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(2, null, 1267019526, typeof(SkimmerSpot)), 141, 144);

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		try
		{
			int num = 0;
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj2 as PrecisionTimer, 1004, 941);
					ByeHelp.Ⴄ(obj2 as PrecisionTimer, 'Ǎ', 414);
					num = ⴅ[99] / 8;
					continue;
				case 2:
				case 4:
					Ⴅ.Info(SetWxCountHelp.Ⴗ((object)(obj2 as PrecisionTimer), (object)cmd.Rx.Msg, 688, (short)715));
					goto case 6;
				case 6:
					num = 5;
					continue;
				case 1:
				case 5:
				{
					object obj = new Publisher();
					((Publisher)obj).Process(cmd);
					break;
				}
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴅ.Warn(ex.Message);
		}
		switch (4)
		{
		}
	}

	public static void Tx(NodeUserCmd cmd)
	{
		int num = 4;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			switch (num)
			{
			default:
				cloneable = AnnHelp.Ⴈ(ႨႨ.Ⴀ(12, 0, 1157904890), cmd.Ⴍ().Ⴅ().Ⴓ()
					.Call, ReplyMail.Ⴅ(5, 14, 1217945022), 933, 'Β');
					goto IL_005b;
				case 2:
					goto IL_005b;
				case 0:
					cmd.Tx.DistroType = DistroType.ToRequester;
					break;
				case 3:
					break;
				case 1:
					return;
				}
				break;
				IL_005b:
				num = 0;
			}
			cmd.Tx.Msg.Add((string)cloneable);
		}
	}
