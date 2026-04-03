using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowQslInfo : IArcCmd
{
	private static readonly ILog Ⴃ = SkimmerValidSpot.Ⴐ(ReplyMail.Ⴅ(0, 11, 1217944224), 930, 959);

	private static void Ⴈ(NodeUserCmd P_0)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(3, 5, 1157898688), P_0.Rx.Msg, 158, 208));
				break;
			case 1:
				break;
			case 0:
			case 3:
			{
				object obj = new ShowQslInfoHelp();
				(obj as ShowQslInfoHelp).Exec(P_0);
				object obj2 = new Publisher();
				((Publisher)obj2).Process(P_0);
				return;
			}
			}
			num = ⴍႭ[134] - 36330;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		try
		{
			int num = 11;
			object obj2 = default(object);
			Array array2 = default(Array);
			IConvertible convertible = default(IConvertible);
			IComparable<string> comparable = default(IComparable<string>);
			object obj3 = default(object);
			Array array = default(Array);
			int num2 = default(int);
			ICloneable cloneable = default(ICloneable);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					num = ((cmd.Rx.Split.Length == 3) ? 8 : 0);
					continue;
				case 8:
					obj2 = SetDxFilter.Ⴀ(cmd.Rx.Split[2], 255, '¾');
					num = 9;
					continue;
				case 9:
					array2 = new string[6];
					(array2 as string[])[0] = ShowWxHelp.Ⴍ('à', 985805408, 4);
					goto case 16;
				case 16:
					num = ⴍႤ[129] - 30327;
					continue;
				case 18:
					(array2 as string[])[1] = ShowVersionHelp.Ⴓ('d', 25);
					(array2 as string[])[2] = SetTalkCount.Ⴗ(1, null, 1267022530, typeof(ႳႨ));
					num = 15;
					continue;
				case 15:
					(array2 as string[])[3] = cmd.Ⴍ().Call;
					(array2 as string[])[4] = ႰႥ.Ⴅ(4, '½', 952622899);
					num = 5;
					continue;
				case 5:
					(array2 as string[])[5] = cmd.Ⴍ().Ⴅ().Ⴓ()
						.Call;
					convertible = ShowWwv.Ⴈ((string[])array2, 'ϰ', 920);
					num = 19;
					continue;
				case 7:
				case 19:
				{
					qslinfoSoap qslinfoSoap = new qslinfoSoapClient();
					comparable = (qslinfoSoap as qslinfoSoapClient).qslinfo((string)obj2, (string)convertible);
					num = ⴀ[256] - 7741;
					continue;
				}
				case 12:
					num = ((CallBlockCacheCfg.Ⴜ((string)comparable, 858, 827) <= 0) ? (ⴐ[126] - ⴐ[21]) : 14);
					continue;
				case 14:
				{
					string obj4 = comparable as string;
					Array array3 = new char[1];
					((char[])array3)[0] = '\n';
					obj3 = Directory.Ⴓ(obj4, (char[])array3, 965, 915);
					goto case 6;
				}
				case 6:
					num = ⴄႷ[2] - 23605;
					continue;
				case 1:
					array = (string[])obj3;
					num2 = 0;
					num = 20;
					continue;
				case 17:
					cloneable = (array as string[])[num2];
					num = ((CallBlockCacheCfg.Ⴜ(cloneable as string, 683, 714) <= 0) ? ⴀႼ[113] : 4);
					continue;
				case 4:
					cmd.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(0, 5, 1157902547), (string)cloneable, 144, 222));
					goto case 2;
				case 2:
					num2++;
					num = 20;
					continue;
				case 20:
					num = ((num2 < ((string[])array).Length) ? (ⴅ[331] - ⴅ[353]) : 10);
					continue;
				case 10:
				{
					object obj = new Publisher();
					(obj as Publisher).Process(cmd);
					num = 3;
					continue;
				}
				case 0:
					Ⴈ(cmd);
					break;
				case 3:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			cmd.Tx.Msg.Add(ReplyMail.Ⴅ(4, 13, 1217940579));
			Ⴃ.Warn(SetTalkCount.Ⴗ(6, null, 1267014602, typeof(ShowStation)) + ex.Message);
		}
		switch (0)
		{
		}
	}
}
