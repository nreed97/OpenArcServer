using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationBeepHelp : IArcCmd
{
	internal sealed class Ⴍ
	{
		internal string Ⴐ;

		internal string Ⴅ;

		internal string Ⴃ;

		internal string Ⴈ;

		internal Ⴍ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 5;
			case 5:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(5, null, 1267020402, typeof(V4NodeParser)));
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134343, 3, '%'));
				goto case 4;
			case 4:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(25, null, 1057162913, 2));
				num = ⴃႰ[71] - 42560;
				break;
			case 6:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(1, '\u0004', 952619364));
				goto case 0;
			case 0:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 2, 62057202, null));
				num = ⴀႳ[274] - 53565;
				break;
			case 3:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : DxCfg where _0021_00211 : string
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				break;
			case 6:
				num = (((P_2 ^ P_3) - 73) ^ num2) switch
				{
					0 => 4, 
					_ => 8, 
				};
				break;
			case 8:
				num = ⴄႷ[66] - 17233;
				break;
			case 4:
				P_0.Filter = P_1;
				goto case 9;
			case 9:
				num2++;
				goto case 3;
			case 3:
			{
				int num3 = 605;
				int num4 = 903;
				num = ((6321 > num4 - num3 * 7) ? (ⴀႼ[65] - 20) : ⴐ[257]);
				break;
			}
			case 7:
				num = ⴄႷ[44] - 49662;
				break;
			case 0:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Thread Ⴓ(int P_0, short P_1)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		CriticalFinalizerObject criticalFinalizerObject = default(CriticalFinalizerObject);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႤ[267] - ⴍႤ[267];
					continue;
				case 0:
					break;
				case 1:
					num2 = (((P_1 ^ P_0) - 51) ^ num) switch
					{
						0 => ⴀ[228] - 47203, 
						_ => ⴃႠ[216] - 62961, 
					};
					continue;
				case 2:
				case 3:
					criticalFinalizerObject = null;
					num2 = ⴃႥ[332] - 41011;
					continue;
				case 5:
					criticalFinalizerObject = Thread.CurrentThread;
					num2 = ⴄႤ[222] - 175;
					continue;
				case 7:
				case 8:
					num++;
					num3 = 576;
					num4 = 22;
					goto case 4;
				case 4:
					num2 = ((288 < num3 / 2 - num4) ? (ⴄႷ[11] - 38828) : (ⴃႰ[46] - 49483));
					continue;
				case 6:
					return (Thread)criticalFinalizerObject;
				case 9:
					num2 = ⴃႥ[290] - 3427;
					continue;
				}
				break;
			}
		}
	}
}
