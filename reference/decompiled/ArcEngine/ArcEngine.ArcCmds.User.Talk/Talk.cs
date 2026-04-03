using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Talk;

public class Talk : IArcCmd
{
	private static readonly ILog Ⴅ = SkimmerValidSpot.Ⴐ(ႨႨ.Ⴀ(6, 0, 1157903700), 469, 456);

	private static void Ⴓ(NodeUserCmd P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 4;
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(15, 7, 1157902559), P_0.Rx.Msg, 795, 853));
				goto IL_005a;
			case 0:
				goto IL_005a;
			case 3:
			{
				object obj = new TalkHelp();
				(obj as TalkHelp).Exec(P_0);
				obj2 = new Publisher();
				break;
			}
			case 1:
				break;
			case 2:
				return;
			}
			break;
			IL_005a:
			num = ⴀႨ[122] - 31854;
		}
		(obj2 as Publisher).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		try
		{
			int num = 3;
			IConvertible convertible = default(IConvertible);
			Array array2 = default(Array);
			IComparable comparable = default(IComparable);
			BaseXmlSerializer baseXmlSerializer = default(BaseXmlSerializer);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((cmd.Rx.Split.Length <= 2) ? (ⴃႥ[223] - 25452) : (ⴃႥ[371] - 56162));
					continue;
				case 1:
					convertible = SetDxFilter.Ⴀ(cmd.Rx.Split[1], 713, 'ʈ');
					num = 4;
					continue;
				case 4:
					array2 = new string[5];
					(array2 as string[])[0] = (string)convertible;
					goto case 9;
				case 9:
					((string[])array2)[1] = ReplyMailHelp.Ⴄ(1, null, 1057162092, 8);
					num = ⴍႤ[481] - 37699;
					continue;
				case 12:
					(array2 as string[])[2] = cmd.Ⴍ().Call;
					(array2 as string[])[3] = SetStationClubHelp.Ⴍ(8, 8, 1747258341, null);
					num = ⴅ[310] - 178;
					continue;
				case 2:
				case 7:
					((string[])array2)[4] = cmd.Rx.GetMsgEnd2(2);
					comparable = ShowWwv.Ⴈ(array2 as string[], 'ǚ', 434);
					num = 6;
					continue;
				case 6:
					baseXmlSerializer = cmd.Ⴍ().Ⴅ().Ⴓ()
						.ႣႨ(convertible as string);
					num = ((!(baseXmlSerializer is ArcConnect)) ? 5 : 10);
					continue;
				case 10:
				{
					((ArcConnect)baseXmlSerializer).ႠႰ(comparable as string);
					ILog ⴅ2 = Ⴅ;
					Array array = new string[5];
					(array as string[])[0] = cmd.Ⴍ().Call;
					((string[])array)[1] = SetStationClubHelp.Ⴍ(9, 1, 1747257857, null);
					(array as string[])[2] = convertible as string;
					(array as string[])[3] = SetTalkCount.Ⴗ(6, null, 1267022533, typeof(ShowSkimmer));
					(array as string[])[4] = cmd.Tx.Msg[0];
					ⴅ2.Info(ShowWwv.Ⴈ((string[])array, 'ź', 274));
					num = 11;
					continue;
				}
				case 5:
				case 8:
					cmd.Ⴍ().ႠႰ(AnnHelp.Ⴈ(CallBlockCacheCfg.Ⴅ(null, 6, 62056937, null), convertible as string, SetTalkCount.Ⴗ(6, null, 1267023224, typeof(FocCache)), 555, 'Ȝ'));
					num = 11;
					continue;
				case 13:
					Ⴓ(cmd);
					break;
				case 11:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴓ(cmd);
		}
		switch (4)
		{
		}
	}
}
